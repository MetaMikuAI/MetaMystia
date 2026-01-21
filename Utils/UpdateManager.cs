using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using BepInEx;
using MetaMystia;

namespace SgrYuki.Utils;

[AutoLog]
public static partial class UpdateManager
{
    private const string GitHubApiUrl = "https://api.github.com/repos/MetaMikuAI/MetaMystia/releases/latest";
    private const string RedirectUrl = "https://url.izakaya.cc/getMetaMystia";

    private static readonly HttpClient _httpClient = new(new SocketsHttpHandler
    {
        ConnectTimeout = TimeSpan.FromSeconds(10),
        PooledConnectionLifetime = TimeSpan.FromMinutes(5)
    })
    {
        Timeout = Timeout.InfiniteTimeSpan
    };

    private static readonly HttpClient _githubClient = new(new SocketsHttpHandler
    {
        ConnectTimeout = TimeSpan.FromSeconds(10),
        PooledConnectionLifetime = TimeSpan.FromMinutes(5)
    })
    {
        Timeout = Timeout.InfiniteTimeSpan
    };

    static UpdateManager()
    {
        _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(MetricsReporter.UserAgent);
        _githubClient.DefaultRequestHeaders.UserAgent.ParseAdd(MetricsReporter.UserAgent);
        _githubClient.DefaultRequestHeaders.Accept.ParseAdd("application/vnd.github+json");
    }

    private static async Task<(string url, string error)> GetDownloadUrlFromGitHubAsync()
    {
        try
        {
            Log.Info("Trying to get download URL from GitHub...");

            var response = await _githubClient.GetAsync(GitHubApiUrl);
            if (!response.IsSuccessStatusCode)
            {
                var error = $"HTTP{(int)response.StatusCode}";
                Log.Warning($"GitHub API returned {error}");
                return (null, error);
            }

            var json = await response.Content.ReadAsStringAsync();
            var dict = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);

            if (dict != null && dict.TryGetValue("assets", out var assets) && assets.ValueKind == JsonValueKind.Array)
            {
                var matchingAssets = assets.EnumerateArray()
                    .Where(asset => asset.TryGetProperty("name", out var name) &&
                                    name.GetString()?.StartsWith("MetaMystia-v", StringComparison.OrdinalIgnoreCase) == true &&
                                    name.GetString().EndsWith(".dll", StringComparison.OrdinalIgnoreCase) &&
                                    asset.TryGetProperty("browser_download_url", out _));

                foreach (var asset in matchingAssets)
                {
                    if (asset.TryGetProperty("browser_download_url", out var downloadUrl))
                    {
                        var url = downloadUrl.GetString();
                        Log.Info($"Found dll download URL from GitHub: {url}");

                        try
                        {
                            using var headRequest = new HttpRequestMessage(HttpMethod.Head, url);
                            using var headResponse = await _httpClient.SendAsync(headRequest, HttpCompletionOption.ResponseHeadersRead);

                            if (headResponse.IsSuccessStatusCode)
                            {
                                Log.Info("Download URL is accessible");
                                return (url, null);
                            }
                            else
                            {
                                Log.Warning($"Download URL returned {headResponse.StatusCode}, may not be accessible");
                                return (null, $"DownloadUrlNotAccessible:HTTP{(int)headResponse.StatusCode}");
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.Warning($"Failed to verify download URL accessibility: {ex.Message}");
                            return (null, $"DownloadUrlVerifyFailed:{ex.GetType().Name}");
                        }
                    }
                }
            }

            var parseError = "NoDllAssetFound";
            Log.Warning("No dll asset found in GitHub release");
            return (null, parseError);
        }
        catch (Exception ex)
        {
            var error = $"{ex.GetType().Name}:{ex.Message}";
            Log.Warning($"Failed to get download URL from GitHub: {ex.Message}");
            return (null, error);
        }
    }

    private static async Task<(string url, string error)> GetDownloadUrlFromRedirectAsync()
    {
        try
        {
            Log.Info("Trying to get download URL from redirect service...");
            using var request = new HttpRequestMessage(HttpMethod.Head, RedirectUrl);
            using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

            var redirectedUrl = response.RequestMessage?.RequestUri?.ToString() ?? RedirectUrl;
            Log.Info($"Redirected to: {redirectedUrl}");

            var uri = new Uri(redirectedUrl);
            var shareCode = uri.AbsolutePath.TrimStart('/').Split('/').LastOrDefault();

            if (string.IsNullOrEmpty(shareCode))
            {
                var error = $"ParseShareCodeFailed:{redirectedUrl}";
                Log.Error($"Failed to parse share code from {redirectedUrl}");
                return (null, error);
            }

            var baseUrl = $"{uri.Scheme}://{uri.Host}";
            var downloadUrl = $"{baseUrl}/api/public/dl/{shareCode}/MetaMystia-latest.dll";

            return (downloadUrl, null);
        }
        catch (Exception ex)
        {
            var error = $"{ex.GetType().Name}:{ex.Message}";
            Log.Error($"Failed to get download URL: {ex.Message}");
            return (null, error);
        }
    }

    private static async Task<(string url, string error)> GetDownloadUrlAsync()
    {
        var (githubUrl, githubError) = await GetDownloadUrlFromGitHubAsync();
        if (!string.IsNullOrEmpty(githubUrl)) return (githubUrl, null);

        Log.Info($"GitHub download failed ({githubError}), falling back to redirect service");

        var (redirectUrl, redirectError) = await GetDownloadUrlFromRedirectAsync();
        if (!string.IsNullOrEmpty(redirectUrl)) return (redirectUrl, null);

        var combinedError = $"GitHub:{githubError};Redirect:{redirectError}";
        return (null, combinedError);
    }

    private static string[] GetExistingDllFiles()
    {
        try
        {
            var pluginsPath = Paths.PluginPath;
            return [.. Directory.GetFiles(pluginsPath, "MetaMystia-*.dll").Select(Path.GetFileName)];
        }
        catch (Exception ex)
        {
            Log.Warning($"Failed to list dll files: {ex.Message}");
            return [];
        }
    }

    private static void CleanupFile(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Log.Info($"Deleted: {Path.GetFileName(filePath)}");
            }
        }
        catch (Exception ex)
        {
            Log.Warning($"Failed to delete {filePath}: {ex.Message}");
        }
    }

    public static void CleanupOldDlls()
    {
        try
        {
            var pluginsPath = Paths.PluginPath;
            var oldFiles = Directory.GetFiles(pluginsPath, "MetaMystia-v*.dll.old");

            foreach (var file in oldFiles)
            {
                var fileName = Path.GetFileName(file);
                var versionPart = fileName.Substring("MetaMystia-v".Length, fileName.Length - "MetaMystia-v".Length - ".dll.old".Length);

                if (!string.IsNullOrEmpty(versionPart) && versionPart.All(c => char.IsDigit(c) || c == '.'))
                    CleanupFile(file);
                else
                    Log.Warning($"Skipping invalid version format: {fileName}");
            }

            if (oldFiles.Length > 0)
            {
                Log.Info($"Cleaned up {oldFiles.Length} old dll file(s)");
            }
        }
        catch (Exception ex)
        {
            Log.Warning($"Failed to cleanup old dll files: {ex.Message}");
        }
    }

    private static async Task<(bool success, string error)> DownloadFileAsync(string url, string outputPath)
    {
        var tempPath = outputPath + ".tmp";

        try
        {
            Log.Info($"Downloading from {url}");

            using var response = await _httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);

            if (!response.IsSuccessStatusCode)
            {
                var error = $"HTTP{(int)response.StatusCode}:{response.ReasonPhrase}";
                Log.Error($"Download failed: {error}");
                return (false, error);
            }

            var totalBytes = response.Content.Headers.ContentLength ?? 0;
            Log.Info($"File size: {totalBytes / 1024.0:F2} KB");

            await using var contentStream = await response.Content.ReadAsStreamAsync();
            await using var fileStream = new FileStream(tempPath, FileMode.Create, FileAccess.Write, FileShare.None);

            var buffer = new byte[8192];
            long totalRead = 0;
            long lastLoggedBytes = 0;
            const long logInterval = 100 * 1024; // 每100KB记录一次
            int bytesRead;

            while ((bytesRead = await contentStream.ReadAsync(buffer)) > 0)
            {
                await fileStream.WriteAsync(buffer.AsMemory(0, bytesRead));
                totalRead += bytesRead;

                if (totalBytes > 0 && totalRead - lastLoggedBytes >= logInterval)
                {
                    var progress = (double)totalRead / totalBytes * 100;
                    Log.Info($"Download progress: {progress:F1}%");
                    lastLoggedBytes = totalRead;
                }
            }

            await fileStream.FlushAsync();
            fileStream.Close();

            if (File.Exists(outputPath)) File.Delete(outputPath);
            File.Move(tempPath, outputPath);

            Log.Info($"Download completed: {outputPath}");
            return (true, null);
        }
        catch (Exception ex)
        {
            var error = $"{ex.GetType().Name}:{ex.Message}";
            Log.Error($"Download failed: {error}");

            CleanupFile(tempPath);
            return (false, error);
        }
    }

    public static bool CheckCurrentVersionDllExists(string currentVersion)
    {
        try
        {
            var pluginsPath = Paths.PluginPath;
            var expectedDllName = $"MetaMystia-v{currentVersion}.dll";
            var dllPath = Path.Combine(pluginsPath, expectedDllName);

            var exists = File.Exists(dllPath);
            Log.Info($"Checking for {expectedDllName}: {(exists ? "Found" : "Not found")}");

            return exists;
        }
        catch (Exception ex)
        {
            Log.Warning($"Failed to check dll existence: {ex.Message}");
            return false;
        }
    }

    public static async Task<bool> ExecuteUpdateAsync(string currentVersion, string newVersion)
    {
        if (string.IsNullOrEmpty(newVersion))
        {
            Log.Error("New version is empty");
            return false;
        }
        if (currentVersion == newVersion)
        {
            Log.Info("Already up to date");
            return false;
        }

        try
        {
            Log.Info($"Fetching download URL from {RedirectUrl}");

            var (downloadUrl, urlError) = await GetDownloadUrlAsync();
            if (string.IsNullOrEmpty(downloadUrl))
            {
                Log.Error("Failed to get download URL");
                _ = MetricsReporter.ReportEvent("Update", "Failed", $"{currentVersion}->{newVersion}:URLFetch:{urlError}");
                return false;
            }

            Log.Info($"Download URL: {downloadUrl}");

            var newDllPath = Path.Combine(Paths.PluginPath, $"MetaMystia-v{newVersion}.dll");
            if (File.Exists(newDllPath))
            {
                Log.Warning($"Target file {newDllPath} already exists, deleting...");
                CleanupFile(newDllPath);
            }

            var (downloadSuccess, downloadError) = await DownloadFileAsync(downloadUrl, newDllPath);
            if (!downloadSuccess)
            {
                _ = MetricsReporter.ReportEvent("Update", "Failed", $"{currentVersion}->{newVersion}:Download:{downloadError}");
                return false;
            }

            Log.Info($"Downloaded new version: {Path.GetFileName(newDllPath)}");

            var existingDlls = GetExistingDllFiles();
            var oldDllsToRename = existingDlls
                .Where(dll => dll != $"MetaMystia-v{newVersion}.dll")
                .ToArray();

            foreach (var dll in oldDllsToRename)
            {
                var fullPath = Path.Combine(Paths.PluginPath, dll);
                var oldPath = fullPath + ".old";

                try
                {
                    if (File.Exists(oldPath)) File.Delete(oldPath);
                    File.Move(fullPath, oldPath);
                    Log.Info($"Renamed old dll: {dll} -> {Path.GetFileName(oldPath)}");
                }
                catch (Exception ex)
                {
                    Log.Warning($"Failed to rename {dll}: {ex.Message}");
                }
            }

            Log.Info("Update completed successfully!");
            _ = MetricsReporter.ReportEvent("Update", "Success", $"{currentVersion}->{newVersion}");

            return true;
        }
        catch (Exception ex)
        {
            Log.Error($"Update failed: {ex.Message}");
            _ = MetricsReporter.ReportEvent("Update", "Failed", $"{currentVersion}->{newVersion}:{ex.GetType().Name}:{ex.Message}");
            return false;
        }
    }

#if DEBUG
    private static string GetCurrentDllVersion()
    {
        try
        {
            var dlls = GetExistingDllFiles();
            if (dlls.Length == 0)
            {
                Log.Warning("No dll files found, falling back to ModVersion");
                return MpManager.ModVersion;
            }

            var highestVersion = dlls
                .Select(dll =>
                {
                    var match = System.Text.RegularExpressions.Regex.Match(dll, @"MetaMystia-v(\d+\.\d+\.\d+)\.dll");
                    return match.Success ? match.Groups[1].Value : null;
                })
                .Where(v => v != null)
                .OrderByDescending(v => new Version(v))
                .FirstOrDefault();

            if (highestVersion == null)
            {
                Log.Warning("No valid version found in dll filenames, falling back to ModVersion");
                return MpManager.ModVersion;
            }

            Log.Info($"Detected current dll version: {highestVersion}");

            return highestVersion;
        }
        catch (Exception ex)
        {
            Log.Warning($"Failed to get current dll version: {ex.Message}, falling back to ModVersion");
            return MpManager.ModVersion;
        }
    }

    private static void TestSimulateUpdate(string currentVersion, string newVersion)
    {
        try
        {
            Log.Info($"=== Simulating update from v{currentVersion} to v{newVersion} ===");

            var pluginsPath = Paths.PluginPath;
            var currentDllPath = Path.Combine(pluginsPath, $"MetaMystia-v{currentVersion}.dll");
            var newDllPath = Path.Combine(pluginsPath, $"MetaMystia-v{newVersion}.dll");

            if (!File.Exists(currentDllPath))
            {
                Log.Error($"Current version dll not found: {Path.GetFileName(currentDllPath)}");
                Log.Error("Cannot simulate update without a real dll to copy");
                return;
            }

            if (File.Exists(newDllPath))
            {
                Log.Warning($"New version dll already exists, deleting: {Path.GetFileName(newDllPath)}");
                File.Delete(newDllPath);
            }

            File.Copy(currentDllPath, newDllPath);
            Log.Info($"Copied current dll as simulated new version: {Path.GetFileName(newDllPath)}");

            var oldDlls = GetExistingDllFiles()
                .Where(dll => dll != $"MetaMystia-v{newVersion}.dll")
                .ToArray();

            Log.Info($"Found {oldDlls.Length} old dll file(s) to rename (including current running dll)");

            foreach (var dll in oldDlls)
            {
                var fullPath = Path.Combine(pluginsPath, dll);
                var oldPath = fullPath + ".old";

                try
                {
                    if (File.Exists(oldPath)) File.Delete(oldPath);
                    File.Move(fullPath, oldPath);
                    Log.Info($"Renamed: {dll} -> {Path.GetFileName(oldPath)}");
                }
                catch (Exception ex)
                {
                    Log.Warning($"Failed to rename {dll}: {ex.Message}");
                }
            }

            Log.Info("=== Simulated update completed successfully ===");
            Log.Info($"Next steps:");
            Log.Info($"  1. Restart the game");
            Log.Info($"  2. The new version ({Path.GetFileName(newDllPath)}) will be loaded");
            Log.Info($"  3. All old dlls (including current v{currentVersion}) have been renamed to .old and auto-deleted on next startup");
        }
        catch (Exception ex)
        {
            Log.Error($"Failed to simulate update: {ex.Message}");
        }
    }

    public static string ExecuteTestCommand(string[] args)
    {
        if (args.Length < 1)
        {
            return "用法: /test-update <新版本>";
        }

        var currentVersion = GetCurrentDllVersion();
        var newVersion = args[0];

        TestSimulateUpdate(currentVersion, newVersion);
        return $"已模拟更新流程: v{currentVersion} -> v{newVersion}\n请查看日志查看详细信息";
    }
#endif
}

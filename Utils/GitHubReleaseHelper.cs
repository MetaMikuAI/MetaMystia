using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;
using MetaMystia;

namespace SgrYuki.Utils;

[AutoLog]
public static partial class GitHubReleaseHelper
{   
    public const string GetPluginVersionAPI = "https://api.izakaya.cc/version/meta-mystia";
    public static string MetricsAPI(string version, string user_id) => $"https://track.izakaya.cc/api.php?idsite=13&rec=1&ca=1&e_c=Client&e_a=Run&e_n{version}&_id={user_id}&uid={user_id}";
    private static readonly System.Net.Http.HttpClient _http = new()
    {
        BaseAddress = new Uri("https://api.github.com/")
    };

    static GitHubReleaseHelper()
    {
        _http.DefaultRequestHeaders.UserAgent.ParseAdd("MetaMystia/1.0");
        _http.DefaultRequestHeaders.Accept.ParseAdd("application/vnd.github+json");
    }

    public static async Task<string> GetLatestReleaseTagUsingGithubAsync(
        string owner,
        string repo)
    {
        var response = await _http.GetAsync($"repos/{owner}/{repo}/releases/latest");

        if (!response.IsSuccessStatusCode) return null;

        var json = await response.Content.ReadAsStringAsync();
        var dict = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);
        // 200: {"tag_name":"v0.11.0"}
        if (dict != null && dict.TryGetValue("tag_name", out var tag))
        {
            return tag.ToString();
        }
        return null;
    }

    public static async Task<string> GetLatestReleaseTagAsync()
    {
        var c = new System.Net.Http.HttpClient();
        c.DefaultRequestHeaders.UserAgent.ParseAdd("MetaMystia/1.0");

        var response = await c.GetAsync(GetPluginVersionAPI);

        if (!response.IsSuccessStatusCode) return null;

        var json = await response.Content.ReadAsStringAsync();
        var dict = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);
        // 200: {"dll":"0.11.0","zip":"0.4.5"}
        if (dict != null && dict.TryGetValue("dll", out var ver))
        {
            return ver.ToString();
        }
        return null;
    }

    public static string GetPluginLatestTag(bool useGithub = false)
    {
        return GetPluginLatestTagAsync(useGithub).GetAwaiter().GetResult();
    }

    public static Task<string> GetPluginLatestTagAsync(bool useGithub = false)
    {
        if (useGithub)
        {
            return GetLatestReleaseTagUsingGithubAsync("MetaMikuAI", "MetaMystia");
        }
        return GetLatestReleaseTagAsync();
    }

    public static string GetActiveMacAddress()
    {
        foreach (var nic in NetworkInterface.GetAllNetworkInterfaces())
        {
            if (nic.OperationalStatus != OperationalStatus.Up)
                continue;

            if (nic.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                continue;

            var props = nic.GetIPProperties();
            if (props.UnicastAddresses.Any(u => u.Address.AddressFamily == AddressFamily.InterNetwork))
            {
                return nic.GetPhysicalAddress().ToString();
            }
        }
        return null;
    }

    public static async Task<bool> ReportMetrics()
    {
        var c = new System.Net.Http.HttpClient();
        c.DefaultRequestHeaders.UserAgent.ParseAdd("MetaMystia/1.0");

        var response = await c.GetAsync(MetricsAPI(MpManager.ModVersion, GetActiveMacAddress()));
        Log.Info($"reporting metrics {MpManager.ModVersion}, {GetActiveMacAddress()}");
        return response.IsSuccessStatusCode;
    }
}


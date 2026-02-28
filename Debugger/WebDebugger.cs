using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BepInEx.Logging;
using UnityEngine;

namespace MetaMystia.Debugger
{
    public class WebDebugger : IDisposable
    {
        private HttpListener _listener;
        private bool _isRunning;
        private string _token;
        private ManualLogSource _log => Plugin.Instance.Log;

        public WebDebugger()
        {
            _listener = new HttpListener();
            _listener.Prefixes.Add("http://127.0.0.1:21101/");

            // Initialize Lua VM when WebDebugger is created
            LuaDebugger.Initialize();
        }

        public void Start()
        {
            if (_isRunning)
            {
                OpenInBrowser();
                return;
            }

            try
            {
                _token = GenerateToken();
                _listener.Start();
                _isRunning = true;
                _log.LogWarning($"Web Debugger started.");
                OpenInBrowser();
                Task.Run(ListenLoop);
            }
            catch (Exception ex)
            {
                _log.LogError($"Failed to start Web Debugger: {ex}");
            }
        }

        public void OpenInBrowser()
        {
            if (string.IsNullOrEmpty(_token))
            {
                _log.LogWarning("Web Debugger token is not generated yet.");
                return;
            }
            string url = $"http://127.0.0.1:21101/?token={_token}";
            Application.OpenURL(url);
        }

        private string GenerateToken()
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Guid.NewGuid().ToString()));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < 16; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private async Task ListenLoop()
        {
            while (_isRunning && _listener.IsListening)
            {
                try
                {
                    var context = await _listener.GetContextAsync();
                    _ = ProcessRequestAsync(context);
                }
                catch (Exception ex)
                {
                    _log.LogError($"Error in Web Debugger loop: {ex}");
                }
            }
        }

        private async Task ProcessRequestAsync(HttpListenerContext context)
        {
            var request = context.Request;
            var response = context.Response;

            try
            {
                // Only accept connections from 127.0.0.1
                var remoteIp = request.RemoteEndPoint.Address;
                if (!IPAddress.IsLoopback(remoteIp))
                {
                    _log.LogWarning($"Rejected connection from non-loopback address: {remoteIp}");
                    response.StatusCode = 403;
                    response.Close();
                    return;
                }

                string reqToken = request.QueryString["token"];
                bool isAuthenticated = !string.IsNullOrEmpty(reqToken) && reqToken == _token;

                if (!isAuthenticated)
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(WebResources.LoginHtmlContent);
                    response.ContentType = "text/html";
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                }
                else if (request.Url.AbsolutePath == "/eval" && request.HttpMethod == "POST")
                {
                    using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                    {
                        string expression = reader.ReadToEnd();

                        InspectionResult result;
                        if (PluginManager.Instance != null)
                        {
                            var tcs = new TaskCompletionSource<InspectionResult>();
                            PluginManager.Instance.RunOnMainThread(() =>
                            {
                                try
                                {
                                    tcs.SetResult(ReflectionEvaluator.Inspect(expression));
                                }
                                catch (Exception ex)
                                {
                                    tcs.SetResult(new InspectionResult { Error = ex.ToString() });
                                }
                            });
                            result = await tcs.Task;
                        }
                        else
                        {
                            result = new InspectionResult { Error = "PluginManager not initialized" };
                        }

                        string json = System.Text.Json.JsonSerializer.Serialize(result);

                        byte[] buffer = Encoding.UTF8.GetBytes(json);
                        response.ContentType = "application/json";
                        response.ContentLength64 = buffer.Length;
                        response.OutputStream.Write(buffer, 0, buffer.Length);
                    }
                }
                else if (request.Url.AbsolutePath == "/eval-lua" && request.HttpMethod == "POST")
                {
                    using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                    {
                        string expression = reader.ReadToEnd();

                        string result = "";
                        if (LuaDebugger.LuaVm != null)
                        {
                            var tcs = new TaskCompletionSource<string>();
                            PluginManager.Instance.RunOnMainThread(() =>
                            {
                                try
                                {
                                    // Get DebugHelper instance to capture print output
                                    var debugHelper = LuaDebugger.DebugHelper;

                                    object[] res = LuaDebugger.LuaVm.DoString(expression);

                                    var sb = new StringBuilder();

                                    // First, add any captured print output
                                    if (debugHelper != null)
                                    {
                                        string printOutput = debugHelper.GetLuaOutput();
                                        if (!string.IsNullOrEmpty(printOutput))
                                        {
                                            sb.AppendLine(printOutput.TrimEnd());
                                        }
                                    }

                                    // Then add return values if any
                                    if (res != null && res.Length > 0)
                                    {
                                        if (sb.Length > 0) sb.AppendLine();
                                        sb.Append("=> ");
                                        foreach (var r in res) sb.Append(r?.ToString() + " ");
                                    }

                                    tcs.SetResult(sb.Length > 0 ? sb.ToString() : "OK");
                                }
                                catch (Exception ex)
                                {
                                    tcs.SetResult("Error: " + ex.Message);
                                }
                            });
                            result = await tcs.Task;
                        }
                        else
                        {
                            result = "Lua VM not initialized";
                        }

                        byte[] buffer = Encoding.UTF8.GetBytes(result);
                        response.ContentType = "text/plain";
                        response.ContentLength64 = buffer.Length;
                        response.OutputStream.Write(buffer, 0, buffer.Length);
                    }
                }
                else if (request.Url.AbsolutePath == "/scene-hierarchy")
                {
                    object result = null;
                    if (PluginManager.Instance != null)
                    {
                        var tcs = new TaskCompletionSource<object>();
                        PluginManager.Instance.RunOnMainThread(() =>
                        {
                            try
                            {
                                tcs.SetResult(ReflectionEvaluator.GetSceneHierarchy());
                            }
                            catch (Exception ex)
                            {
                                tcs.SetResult(new { error = ex.ToString() });
                            }
                        });
                        result = await tcs.Task;
                    }
                    else
                    {
                        result = new { error = "PluginManager not initialized" };
                    }

                    string json = System.Text.Json.JsonSerializer.Serialize(result);
                    byte[] buffer = Encoding.UTF8.GetBytes(json);
                    response.ContentType = "application/json";
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                }
                else if (request.Url.AbsolutePath == "/threads")
                {
                    var threads = new List<object>();
                    foreach (System.Diagnostics.ProcessThread t in System.Diagnostics.Process.GetCurrentProcess().Threads)
                    {
                        string state = "";
                        try { state = t.ThreadState.ToString(); } catch { state = "Unknown"; }

                        string priority = "";
#pragma warning disable CA1416 // 验证平台兼容性
                        try { priority = t.PriorityLevel.ToString(); } catch { priority = "Unknown"; }
#pragma warning restore CA1416 // 验证平台兼容性

                        string waitReason = "";
                        try { if (t.ThreadState == System.Diagnostics.ThreadState.Wait) waitReason = t.WaitReason.ToString(); } catch { }

                        threads.Add(new { Id = t.Id, State = state, Priority = priority, WaitReason = waitReason });
                    }

                    ThreadPool.GetAvailableThreads(out int wA, out int ioA);
                    ThreadPool.GetMaxThreads(out int wM, out int ioM);

                    var proc = System.Diagnostics.Process.GetCurrentProcess();
                    var procInfo = new
                    {
                        Name = proc.ProcessName,
                        Id = proc.Id,
                        Memory = (proc.WorkingSet64 / 1024 / 1024) + " MB",
                        StartTime = proc.StartTime.ToString("yyyy-MM-dd HH:mm:ss"),
                        RealTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        Threads = proc.Threads.Count
                    };

                    var data = new
                    {
                        Stats = $"Worker Threads: {wA}/{wM}, IO Threads: {ioA}/{ioM}",
                        Threads = threads,
                        Process = procInfo
                    };

                    string json = System.Text.Json.JsonSerializer.Serialize(data);
                    byte[] buffer = Encoding.UTF8.GetBytes(json);
                    response.ContentType = "application/json";
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                }
                else if (request.QueryString["action"] == "search_resources")
                {
                    string className = request.QueryString["className"];
                    string json = "[]";

                    if (PluginManager.Instance != null)
                    {
                        var tcs = new TaskCompletionSource<string>();
                        PluginManager.Instance.RunOnMainThread(() =>
                        {
                            try
                            {
                                var resources = ReflectionEvaluator.FindResources(className);
                                json = System.Text.Json.JsonSerializer.Serialize(resources);
                                tcs.SetResult(json);
                            }
                            catch (Exception ex)
                            {
                                tcs.SetResult(System.Text.Json.JsonSerializer.Serialize(new { error = ex.Message }));
                            }
                        });
                        json = await tcs.Task;
                    }

                    byte[] buffer = Encoding.UTF8.GetBytes(json);
                    response.ContentType = "application/json";
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                }
                else if (request.QueryString["action"] == "select_resource")
                {
                    int index = int.Parse(request.QueryString["index"]);
                    string result = "";

                    if (PluginManager.Instance != null)
                    {
                        var tcs = new TaskCompletionSource<string>();
                        PluginManager.Instance.RunOnMainThread(() =>
                        {
                            try
                            {
                                ReflectionEvaluator.SelectResource(index);
                                tcs.SetResult("Selected");
                            }
                            catch (Exception ex)
                            {
                                tcs.SetResult("Error: " + ex.Message);
                            }
                        });
                        result = await tcs.Task;
                    }

                    byte[] buffer = Encoding.UTF8.GetBytes(result);
                    response.ContentType = "text/plain";
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                }
                else if (request.Url.AbsolutePath == "/sprite-preview" && request.HttpMethod == "POST")
                {
                    using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                    {
                        string expression = reader.ReadToEnd();

                        byte[] pngData = null;
                        string error = null;

                        if (PluginManager.Instance != null)
                        {
                            var tcs = new TaskCompletionSource<(byte[], string)>();
                            PluginManager.Instance.RunOnMainThread(() =>
                            {
                                try
                                {
                                    object obj = ReflectionEvaluator.Evaluate(expression);
                                    if (obj is UnityEngine.Sprite sprite)
                                    {
                                        var data = SpritePreview.SpriteToPng(sprite);
                                        tcs.SetResult((data, null));
                                    }
                                    else
                                    {
                                        tcs.SetResult((null, $"Expression result is not a Sprite (got {obj?.GetType().Name ?? "null"})"));
                                    }
                                }
                                catch (Exception ex)
                                {
                                    tcs.SetResult((null, ex.ToString()));
                                }
                            });

                            var result = await tcs.Task;
                            pngData = result.Item1;
                            error = result.Item2;
                        }
                        else
                        {
                            error = "PluginManager not initialized";
                        }

                        if (pngData != null)
                        {
                            response.ContentType = "image/png";
                            response.ContentLength64 = pngData.Length;
                            response.OutputStream.Write(pngData, 0, pngData.Length);
                        }
                        else
                        {
                            byte[] buffer = Encoding.UTF8.GetBytes(error ?? "Unknown error");
                            response.StatusCode = 400;
                            response.ContentType = "text/plain";
                            response.ContentLength64 = buffer.Length;
                            response.OutputStream.Write(buffer, 0, buffer.Length);
                        }
                    }
                }
                else
                {
                    string content = WebResources.HtmlContent.Replace("[[TOKEN]]", _token);
                    byte[] buffer = Encoding.UTF8.GetBytes(content);
                    response.ContentType = "text/html";
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception ex)
            {
                string error = $"Internal Error: {ex.Message}";
                byte[] buffer = Encoding.UTF8.GetBytes(error);
                response.StatusCode = 500;
                response.ContentLength64 = buffer.Length;
                response.OutputStream.Write(buffer, 0, buffer.Length);
            }
            finally
            {
                response.OutputStream.Close();
            }
        }

        public void Dispose()
        {
            _isRunning = false;
            if (_listener.IsListening)
            {
                _listener.Stop();
            }
            _listener.Close();
        }
    }
}

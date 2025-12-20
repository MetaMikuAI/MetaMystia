using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BepInEx.Logging;
using System.IO;
using UnityEngine;
using System.Security.Cryptography;

using System.Collections.Generic;
using System.Threading;

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
            _listener.Prefixes.Add("http://localhost:21101/");
        }

        public void Start()
        {
            if (_isRunning) return;
            try
            {
                _token = GenerateToken();
                _listener.Start();
                _isRunning = true;
                string url = $"http://localhost:21101/?token={_token}";
                _log.LogInfo($"Web Debugger started on {url}");
                Application.OpenURL(url);
                Task.Run(ListenLoop);
            }
            catch (Exception ex)
            {
                _log.LogError($"Failed to start Web Debugger: {ex}");
            }
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
                else if (request.Url.AbsolutePath == "/threads")
                {
                    var threads = new List<object>();
                    foreach (System.Diagnostics.ProcessThread t in System.Diagnostics.Process.GetCurrentProcess().Threads)
                    {
                        string state = "";
                        try { state = t.ThreadState.ToString(); } catch { state = "Unknown"; }
                        
                        string priority = "";
                        try { priority = t.PriorityLevel.ToString(); } catch { priority = "Unknown"; }

                        string waitReason = "";
                        try { if (t.ThreadState == System.Diagnostics.ThreadState.Wait) waitReason = t.WaitReason.ToString(); } catch { }

                        threads.Add(new { Id = t.Id, State = state, Priority = priority, WaitReason = waitReason });
                    }
                    
                    ThreadPool.GetAvailableThreads(out int wA, out int ioA);
                    ThreadPool.GetMaxThreads(out int wM, out int ioM);
                    
                    var proc = System.Diagnostics.Process.GetCurrentProcess();
                    var procInfo = new {
                        Name = proc.ProcessName,
                        Id = proc.Id,
                        Memory = (proc.WorkingSet64 / 1024 / 1024) + " MB",
                        StartTime = proc.StartTime.ToString("yyyy-MM-dd HH:mm:ss"),
                        RealTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        Threads = proc.Threads.Count
                    };

                    var data = new {
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

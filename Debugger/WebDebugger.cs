using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BepInEx.Logging;
using System.IO;
using UnityEngine;

namespace MetaMystia.Debugger
{
    public class WebDebugger : IDisposable
    {
        private HttpListener _listener;
        private bool _isRunning;
        private ManualLogSource _log => Plugin.Instance.Log;
        private const string HtmlContent = @"
<!DOCTYPE html>
<html>
<head>
    <title>MetaMystia Debugger</title>
    <style>
        body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; padding: 20px; background: #1e1e1e; color: #d4d4d4; }
        h1, h2 { color: #569cd6; }
        .container { display: flex; gap: 20px; }
        .panel { flex: 1; background: #252526; padding: 15px; border-radius: 5px; border: 1px solid #3e3e42; }
        
        input[type=""text""] { width: 100%; padding: 8px; font-size: 14px; background: #3c3c3c; color: #cccccc; border: 1px solid #3e3e42; box-sizing: border-box; }
        button { background: #0e639c; color: white; border: none; padding: 8px 15px; cursor: pointer; margin-top: 5px; }
        button:hover { background: #1177bb; }
        
        #console-output { margin-top: 10px; white-space: pre-wrap; font-family: Consolas, monospace; min-height: 100px; max-height: 300px; overflow-y: auto; background: #1e1e1e; padding: 10px; border: 1px solid #3e3e42; }
        
        .watch-item { display: flex; justify-content: space-between; align-items: center; padding: 5px; border-bottom: 1px solid #3e3e42; }
        .watch-expr { font-family: Consolas, monospace; color: #9cdcfe; flex: 1; }
        .watch-val { font-family: Consolas, monospace; color: #ce9178; margin-left: 10px; flex: 1; text-align: right; }
        .watch-controls { margin-left: 10px; }
        .remove-btn { background: #c586c0; padding: 2px 8px; font-size: 12px; }
        
        .error { color: #f48771; }
        .success { color: #b5cea8; }
    </style>
</head>
<body>
    <h1>MetaMystia Debugger</h1>
    <div class=""container"">
        <div class=""panel"">
            <h2>Console</h2>
            <input type=""text"" id=""expr"" placeholder=""Enter expression..."" onkeydown=""if(event.key==='Enter') evalConsole()"">
            <button onclick=""evalConsole()"">Evaluate</button>
            <div id=""console-output""></div>
        </div>
        <div class=""panel"">
            <h2>Watch List <button onclick=""refreshWatch()"" style=""float:right; font-size: 12px;"">Refresh All</button></h2>
            <div style=""display:flex; gap:5px;"">
                <input type=""text"" id=""watch-input"" placeholder=""Add expression to watch..."" onkeydown=""if(event.key==='Enter') addWatch()"">
                <button onclick=""addWatch()"">Add</button>
            </div>
            <div id=""watch-list"" style=""margin-top: 15px;""></div>
            <div style=""margin-top: 10px;"">
                <label><input type=""checkbox"" id=""auto-refresh"" onchange=""toggleAutoRefresh()""> Auto Refresh (2s)</label>
            </div>
        </div>
    </div>

    <script>
        // Console Logic
        async function evalConsole() {
            const expr = document.getElementById('expr').value;
            const out = document.getElementById('console-output');
            out.textContent = 'Evaluating...';
            out.className = '';
            try {
                const res = await fetchVal(expr);
                out.textContent = res.val;
                out.className = res.ok ? 'success' : 'error';
            } catch (e) {
                out.textContent = 'Error: ' + e;
                out.className = 'error';
            }
        }

        async function fetchVal(expr) {
            try {
                const response = await fetch('/eval', { method: 'POST', body: expr });
                const text = await response.text();
                return { ok: response.ok, val: text };
            } catch (e) {
                return { ok: false, val: e.toString() };
            }
        }

        // Watch Logic
        let watches = JSON.parse(localStorage.getItem('watches') || '[]');
        let refreshTimer = null;

        function renderWatches() {
            const container = document.getElementById('watch-list');
            container.innerHTML = '';
            watches.forEach((w, idx) => {
                const div = document.createElement('div');
                div.className = 'watch-item';
                div.innerHTML = `
                    <span class=""watch-expr"" title=""${w.expr}"">${w.expr}</span>
                    <span class=""watch-val"" id=""val-${idx}"">...</span>
                    <div class=""watch-controls"">
                        <button class=""remove-btn"" onclick=""removeWatch(${idx})"">X</button>
                    </div>
                `;
                container.appendChild(div);
            });
            localStorage.setItem('watches', JSON.stringify(watches));
        }

        function addWatch() {
            const input = document.getElementById('watch-input');
            const expr = input.value.trim();
            if (expr) {
                watches.push({ expr: expr });
                input.value = '';
                renderWatches();
                refreshWatch();
            }
        }

        function removeWatch(idx) {
            watches.splice(idx, 1);
            renderWatches();
        }

        async function refreshWatch() {
            for (let i = 0; i < watches.length; i++) {
                const el = document.getElementById(`val-${i}`);
                if (el) {
                    const res = await fetchVal(watches[i].expr);
                    el.textContent = res.val;
                    el.style.color = res.ok ? '#ce9178' : '#f48771';
                }
            }
        }

        function toggleAutoRefresh() {
            const cb = document.getElementById('auto-refresh');
            if (cb.checked) {
                refreshTimer = setInterval(refreshWatch, 2000);
            } else {
                clearInterval(refreshTimer);
            }
        }

        // Init
        renderWatches();
        refreshWatch();
    </script>
</body>
</html>";

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
                _listener.Start();
                _isRunning = true;
                _log.LogInfo("Web Debugger started on http://localhost:21101/");
                Task.Run(ListenLoop);
            }
            catch (Exception ex)
            {
                _log.LogError($"Failed to start Web Debugger: {ex}");
            }
        }

        private async Task ListenLoop()
        {
            while (_isRunning && _listener.IsListening)
            {
                try
                {
                    var context = await _listener.GetContextAsync();
                    ProcessRequest(context);
                }
                catch (Exception ex)
                {
                    _log.LogError($"Error in Web Debugger loop: {ex}");
                }
            }
        }

        private void ProcessRequest(HttpListenerContext context)
        {
            var request = context.Request;
            var response = context.Response;

            try
            {
                if (request.Url.AbsolutePath == "/eval" && request.HttpMethod == "POST")
                {
                    using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                    {
                        string expression = reader.ReadToEnd();
                        object result = ReflectionEvaluator.Evaluate(expression);
                        
                        string responseString = result == null ? "null" : result.ToString();
                        
                        if (result is System.Collections.IEnumerable enumerable && !(result is string))
                        {
                            var sb = new StringBuilder();
                            sb.AppendLine(result.ToString());
                            foreach (var item in enumerable)
                            {
                                sb.AppendLine($" - {item}");
                            }
                            responseString = sb.ToString();
                        }

                        byte[] buffer = Encoding.UTF8.GetBytes(responseString);
                        response.ContentLength64 = buffer.Length;
                        response.OutputStream.Write(buffer, 0, buffer.Length);
                    }
                }
                else
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(HtmlContent);
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

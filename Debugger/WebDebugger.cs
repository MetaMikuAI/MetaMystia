using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BepInEx.Logging;
using System.IO;
using UnityEngine;
using System.Security.Cryptography;

namespace MetaMystia.Debugger
{
    public class WebDebugger : IDisposable
    {
        private HttpListener _listener;
        private bool _isRunning;
        private string _token;
        private ManualLogSource _log => Plugin.Instance.Log;

        private const string LoginHtmlContent = @"
<!DOCTYPE html>
<html>
<head>
    <meta charset=""UTF-8"">
    <title>MetaMystia Debugger Login</title>
    <style>
        body { font-family: 'Segoe UI', sans-serif; background: #1e1e1e; color: #d4d4d4; display: flex; justify-content: center; align-items: center; height: 100vh; margin: 0; }
        .login-box { background: #252526; padding: 30px; border-radius: 5px; border: 1px solid #3e3e42; text-align: center; }
        input { padding: 8px; background: #3c3c3c; color: #cccccc; border: 1px solid #3e3e42; margin-bottom: 10px; width: 200px; }
        button { background: #0e639c; color: white; border: none; padding: 8px 20px; cursor: pointer; }
        button:hover { background: #1177bb; }
    </style>
</head>
<body>
    <div class=""login-box"">
        <h2>Login Required</h2>
        <form action=""/"" method=""get"">
            <input type=""text"" name=""token"" placeholder=""Enter Token"" required>
            <br>
            <button type=""submit"">Login</button>
        </form>
    </div>
</body>
</html>";

        private const string HtmlContent = @"
<!DOCTYPE html>
<html>
<head>
    <meta charset=""UTF-8"">
    <title>MetaMystia Debugger</title>
    <style>
        body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; padding: 20px; background: #1e1e1e; color: #d4d4d4; }
        h1, h2 { color: #569cd6; }
        .container { display: flex; flex-direction: column; gap: 20px; }
        .panel { flex: 1; background: #252526; padding: 15px; border-radius: 5px; border: 1px solid #3e3e42; }
        
        input[type=""text""] { width: 100%; padding: 8px; font-size: 14px; background: #3c3c3c; color: #cccccc; border: 1px solid #3e3e42; box-sizing: border-box; }
        button { background: #0e639c; color: white; border: none; padding: 8px 15px; cursor: pointer; margin-top: 5px; }
        button:hover { background: #1177bb; }
        
        #console-output { margin-top: 10px; font-family: Consolas, monospace; min-height: 100px; max-height: 500px; overflow-y: auto; background: #1e1e1e; padding: 10px; border: 1px solid #3e3e42; }
        
        .tree-node { margin-left: 20px; }
        .tree-item { display: flex; align-items: center; padding: 2px 0; }
        .toggle { cursor: pointer; width: 16px; display: inline-block; user-select: none; color: #858585; }
        .toggle:hover { color: #fff; }
        .name { color: #9cdcfe; margin-right: 5px; }
        .type { color: #4ec9b0; margin-right: 5px; font-size: 0.9em; }
        .value { color: #ce9178; }
        .address { color: #808080; font-size: 0.8em; margin-left: 8px; }
        .error-text { color: #f48771; }
        
        .watch-item { display: flex; justify-content: space-between; align-items: center; padding: 5px; border-bottom: 1px solid #3e3e42; }
        .watch-expr { font-family: Consolas, monospace; color: #9cdcfe; flex: 1; }
        .watch-val { font-family: Consolas, monospace; color: #ce9178; margin-left: 10px; flex: 1; text-align: right; }
        .watch-controls { margin-left: 10px; }
        .remove-btn { background: #c586c0; padding: 2px 8px; font-size: 12px; }
    </style>
</head>
<body>
    <h1>MetaMystia Debugger</h1>
    <div class=""container"">
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
        <div class=""panel"">
            <h2>Console</h2>
            <input type=""text"" id=""expr"" placeholder=""Enter expression..."" onkeydown=""if(event.key==='Enter') evalConsole()"">
            <button onclick=""evalConsole()"">Evaluate</button>
            <div id=""console-output""></div>
        </div>
    </div>

    <script>
        const token = ""[[TOKEN]]"";

        // --- Tree View Logic ---
        function createTree(data, parentPath) {
            const container = document.createElement('div');
            
            // Root item
            const item = document.createElement('div');
            item.className = 'tree-item';
            
            const toggle = document.createElement('span');
            toggle.className = 'toggle';
            toggle.textContent = data.IsExpandable ? '▶' : ' ';
            
            const content = document.createElement('span');
            let html = `<span class=""type"">${data.Type}</span> <span class=""value"">${data.Value}</span>`;
            if (data.Address) html += `<span class=""address"">[${data.Address}]</span>`;
            if (data.Error) html = `<span class=""error-text"">${data.Error}</span>`;
            content.innerHTML = html;
            
            item.appendChild(toggle);
            item.appendChild(content);
            container.appendChild(item);
            
            // Children container
            const childrenDiv = document.createElement('div');
            childrenDiv.className = 'tree-node';
            childrenDiv.style.display = 'none';
            container.appendChild(childrenDiv);
            
            if (data.IsExpandable) {
                let loaded = false;
                toggle.onclick = async () => {
                    if (childrenDiv.style.display === 'none') {
                        childrenDiv.style.display = 'block';
                        toggle.textContent = '▼';
                        if (!loaded) {
                            if (data.Members) {
                                renderMembers(data.Members, parentPath, childrenDiv);
                                loaded = true;
                            }
                        }
                    } else {
                        childrenDiv.style.display = 'none';
                        toggle.textContent = '▶';
                    }
                };
                
                if (data.Members) {
                    renderMembers(data.Members, parentPath, childrenDiv);
                    loaded = true;
                    if (parentPath === data.Path) {
                        childrenDiv.style.display = 'block';
                        toggle.textContent = '▼';
                    }
                }
            }
            
            return container;
        }

        function renderMembers(members, parentPath, container) {
            members.forEach(m => {
                const div = document.createElement('div');
                div.className = 'tree-node';
                
                const item = document.createElement('div');
                item.className = 'tree-item';
                
                const toggle = document.createElement('span');
                toggle.className = 'toggle';
                toggle.textContent = m.IsExpandable ? '▶' : ' ';
                
                const content = document.createElement('span');
                let html = `<span class=""name"">${m.Name}</span>: <span class=""type"">${m.Type}</span> <span class=""value"">${m.Value}</span>`;
                if (m.Address) html += `<span class=""address"">[${m.Address}]</span>`;
                content.innerHTML = html;
                
                item.appendChild(toggle);
                item.appendChild(content);
                div.appendChild(item);
                
                const childContainer = document.createElement('div');
                childContainer.style.display = 'none';
                div.appendChild(childContainer);
                
                if (m.IsExpandable) {
                    let loaded = false;
                    toggle.onclick = async () => {
                        if (childContainer.style.display === 'none') {
                            toggle.textContent = '▼';
                            childContainer.style.display = 'block';
                            if (!loaded) {
                                childContainer.textContent = 'Loading...';
                                let newPath = parentPath;
                                if (m.Name.startsWith('[')) newPath += m.Name;
                                else newPath += '.' + m.Name;
                                
                                const res = await fetchVal(newPath);
                                childContainer.textContent = '';
                                if (res.ok) {
                                    if (res.data.Members) {
                                        renderMembers(res.data.Members, newPath, childContainer);
                                    }
                                } else {
                                    childContainer.textContent = 'Error loading';
                                }
                                loaded = true;
                            }
                        } else {
                            toggle.textContent = '▶';
                            childContainer.style.display = 'none';
                        }
                    };
                }
                
                container.appendChild(div);
            });
        }

        // Console Logic
        async function evalConsole() {
            const expr = document.getElementById('expr').value;
            const out = document.getElementById('console-output');
            out.innerHTML = 'Evaluating...';
            try {
                const res = await fetchVal(expr);
                out.innerHTML = '';
                if (res.ok) {
                    out.appendChild(createTree(res.data, expr));
                } else {
                    out.textContent = res.error;
                    out.className = 'error';
                }
            } catch (e) {
                out.textContent = 'Error: ' + e;
                out.className = 'error';
            }
        }

        async function fetchVal(expr) {
            try {
                const response = await fetch('/eval?token=' + token, { method: 'POST', body: expr });
                const text = await response.text();
                try {
                    const json = JSON.parse(text);
                    return { ok: true, data: json };
                } catch {
                    return { ok: false, error: text };
                }
            } catch (e) {
                return { ok: false, error: e.toString() };
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
                    if (res.ok) {
                        el.textContent = res.data.Value;
                        el.style.color = '#ce9178';
                        el.title = res.data.Type;
                    } else {
                        el.textContent = 'Error';
                        el.style.color = '#f48771';
                    }
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
                string reqToken = request.QueryString["token"];
                bool isAuthenticated = !string.IsNullOrEmpty(reqToken) && reqToken == _token;

                if (!isAuthenticated)
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(LoginHtmlContent);
                    response.ContentType = "text/html";
                    response.ContentLength64 = buffer.Length;
                    response.OutputStream.Write(buffer, 0, buffer.Length);
                }
                else if (request.Url.AbsolutePath == "/eval" && request.HttpMethod == "POST")
                {
                    using (var reader = new StreamReader(request.InputStream, request.ContentEncoding))
                    {
                        string expression = reader.ReadToEnd();
                        var result = ReflectionEvaluator.Inspect(expression);
                        
                        string json = System.Text.Json.JsonSerializer.Serialize(result);

                        byte[] buffer = Encoding.UTF8.GetBytes(json);
                        response.ContentType = "application/json";
                        response.ContentLength64 = buffer.Length;
                        response.OutputStream.Write(buffer, 0, buffer.Length);
                    }
                }
                else
                {
                    string content = HtmlContent.Replace("[[TOKEN]]", _token);
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

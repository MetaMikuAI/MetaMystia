namespace MetaMystia.Debugger
{
    public static class WebResources
    {
        public const string LoginHtmlContent = @"
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

        public const string HtmlContent = @"
<!DOCTYPE html>
<html>
<head>
    <meta charset=""UTF-8"">
    <title>MetaMystia Debugger</title>
    <style>
        body { font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif; padding: 20px; background: #1e1e1e; color: #d4d4d4; }
        h1, h2 { color: #569cd6; margin: 0; font-size: 1.2em; }
        .container { display: flex; flex-direction: column; gap: 20px; }
        .panel { background: #252526; border-radius: 5px; border: 1px solid #3e3e42; overflow: hidden; }
        .panel-header { display: flex; justify-content: space-between; align-items: center; cursor: pointer; background: #333; padding: 10px; user-select: none; }
        .panel-header:hover { background: #3e3e42; }
        .panel-content { padding: 15px; }
        .collapsed .panel-content { display: none; }
        
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
        .watch-controls { margin-left: 10px; display: flex; gap: 5px; }
        .icon-btn { background: #3e3e42; color: #d4d4d4; border: 1px solid #555; padding: 2px 8px; font-size: 12px; cursor: pointer; min-width: 24px; text-align: center; }
        .icon-btn:hover { background: #505050; }
        .remove-btn { color: #f48771; }

        #thread-list table { width: 100%; border-collapse: collapse; font-family: Consolas, monospace; font-size: 0.9em; }
        #thread-list th, #thread-list td { text-align: left; padding: 5px; border-bottom: 1px solid #3e3e42; }
        #thread-list th { color: #569cd6; }
    </style>
</head>
<body>
    <h1 style=""margin-bottom: 20px; font-size: 2em;"">MetaMystia Debugger</h1>
    <div class=""container"">
        <!-- Process Info Panel -->
        <div class=""panel"" id=""panel-process"">
            <div class=""panel-header"" onclick=""togglePanel('panel-process')"">
                <h2>Process Info</h2>
                <span>▼</span>
            </div>
            <div class=""panel-content"">
                <div id=""process-info"" style=""font-family: Consolas, monospace; color: #4ec9b0;"">Loading...</div>
            </div>
        </div>

        <!-- Thread Pool Panel -->
        <div class=""panel collapsed"" id=""panel-threads"">
            <div class=""panel-header"" onclick=""togglePanel('panel-threads')"">
                <h2>Thread Pool</h2>
                <span>▶</span>
            </div>
            <div class=""panel-content"">
                <div id=""thread-stats"" style=""margin-bottom: 10px; font-weight: bold; color: #4ec9b0;"">Loading stats...</div>
                <div id=""thread-list"" style=""max-height: 300px; overflow-y: auto;""></div>
                <div style=""margin-top: 10px; display: flex; justify-content: space-between; align-items: center;"">
                    <div style=""display:flex; align-items:center; gap:5px;"">
                        <label><input type=""checkbox"" id=""thread-auto-refresh"" onchange=""toggleThreadAutoRefresh()"" checked> Auto Refresh</label>
                        <input type=""number"" id=""thread-refresh-interval"" value=""2000"" style=""width: 60px;"" onchange=""resetThreadTimer()""> ms
                    </div>
                    <button onclick=""refreshThreads()"" style=""font-size: 12px;"">Refresh Now</button>
                </div>
            </div>
        </div>

        <!-- Watch List Panel -->
        <div class=""panel"" id=""panel-watch"">
            <div class=""panel-header"" onclick=""togglePanel('panel-watch')"">
                <h2>Watch List</h2>
                <span>▼</span>
            </div>
            <div class=""panel-content"">
                <div style=""display:flex; gap:5px;"">
                    <input type=""text"" id=""watch-input"" placeholder=""Add expression to watch..."" onkeydown=""if(event.key==='Enter') addWatch()"">
                    <button onclick=""addWatch()"">Add</button>
                </div>
                <div id=""watch-list"" style=""margin-top: 15px;""></div>
                <div style=""margin-top: 10px; display: flex; justify-content: space-between; align-items: center;"">
                    <div style=""display:flex; align-items:center; gap:5px;"">
                        <label><input type=""checkbox"" id=""auto-refresh"" onchange=""toggleAutoRefresh()"" checked> Auto Refresh</label>
                        <input type=""number"" id=""watch-refresh-interval"" value=""2000"" style=""width: 60px;"" onchange=""resetWatchTimer()""> ms
                    </div>
                    <button onclick=""refreshWatch()"" style=""font-size: 12px;"">Refresh All</button>
                </div>
            </div>
        </div>

        <!-- Console Panel -->
        <div class=""panel"" id=""panel-console"">
            <div class=""panel-header"" onclick=""togglePanel('panel-console')"">
                <h2>Console</h2>
                <span>▼</span>
            </div>
            <div class=""panel-content"">
                <input type=""text"" id=""expr"" placeholder=""Enter expression..."" onkeydown=""if(event.key==='Enter') evalConsole()"">
                <div style=""margin-top: 5px;"">
                    <button onclick=""evalConsole()"">Evaluate</button>
                    <button onclick=""addConsoleToWatch()"">Add to Watch</button>
                </div>
                <div id=""console-output""></div>
            </div>
        </div>
    </div>

    <script>
        const token = ""[[TOKEN]]"";

        function togglePanel(id) {
            const panel = document.getElementById(id);
            panel.classList.toggle('collapsed');
            const icon = panel.querySelector('.panel-header span');
            icon.textContent = panel.classList.contains('collapsed') ? '▶' : '▼';
        }

        // --- Thread Logic ---
        let threadRefreshTimer = null;

        function toggleThreadAutoRefresh() {
            const cb = document.getElementById('thread-auto-refresh');
            if (cb.checked) {
                resetThreadTimer();
            } else {
                if (threadRefreshTimer) clearInterval(threadRefreshTimer);
            }
        }

        function resetThreadTimer() {
            if (threadRefreshTimer) clearInterval(threadRefreshTimer);
            const cb = document.getElementById('thread-auto-refresh');
            if (!cb.checked) return;

            const intervalInput = document.getElementById('thread-refresh-interval');
            let interval = parseInt(intervalInput.value) || 2000;
            if (interval < 100) interval = 100; // Minimum limit

            threadRefreshTimer = setInterval(refreshThreads, interval);
        }

        async function refreshThreads() {
            const statsDiv = document.getElementById('thread-stats');
            const listDiv = document.getElementById('thread-list');
            const procDiv = document.getElementById('process-info');
            
            try {
                const response = await fetch('/threads?token=' + token);
                if (response.ok) {
                    const data = await response.json();
                    statsDiv.textContent = data.Stats;
                    
                    if (data.Process) {
                        procDiv.innerHTML = `
                            <div>Name: <span style=""color:#ce9178"">${data.Process.Name}</span> (ID: ${data.Process.Id})</div>
                            <div>Memory: <span style=""color:#b5cea8"">${data.Process.Memory}</span></div>
                            <div>Start Time: <span style=""color:#569cd6"">${data.Process.StartTime}</span></div>
                            <div>Real Time: <span style=""color:#dcdcaa"">${data.Process.RealTime}</span></div>
                            <div>Total Threads: <span style=""color:#dcdcaa"">${data.Process.Threads}</span></div>
                        `;
                    }

                    let html = '<table><thead><tr><th>ID</th><th>State</th><th>Priority</th><th>WaitReason</th></tr></thead><tbody>';
                    data.Threads.forEach(t => {
                        html += `<tr>
                            <td>${t.Id}</td>
                            <td>${t.State}</td>
                            <td>${t.Priority}</td>
                            <td>${t.WaitReason || '-'}</td>
                        </tr>`;
                    });
                    html += '</tbody></table>';
                    listDiv.innerHTML = html;
                } else {
                    statsDiv.textContent = 'Error fetching threads';
                }
            } catch (e) {
                statsDiv.textContent = 'Error: ' + e;
            }
        }

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
            
            const typeSpan = document.createElement('span');
            typeSpan.className = 'type';
            typeSpan.textContent = data.Type;
            
            const valSpan = document.createElement('span');
            valSpan.className = 'value';
            valSpan.textContent = data.Value;
            valSpan.title = 'Double click to edit';
            valSpan.style.cursor = 'text';
            valSpan.ondblclick = function() { enterEditMode(valSpan, parentPath); };
            
            content.appendChild(typeSpan);
            content.appendChild(document.createTextNode(' '));
            content.appendChild(valSpan);

            if (data.Address) {
                const addrSpan = document.createElement('span');
                addrSpan.className = 'address';
                addrSpan.textContent = `[${data.Address}]`;
                content.appendChild(addrSpan);
            }
            if (data.Error) {
                content.innerHTML = `<span class=""error-text"">${data.Error}</span>`;
            }
            
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
                
                const nameSpan = document.createElement('span');
                nameSpan.className = 'name';
                nameSpan.textContent = m.Name;
                
                const typeSpan = document.createElement('span');
                typeSpan.className = 'type';
                typeSpan.textContent = m.Type;
                
                const valSpan = document.createElement('span');
                valSpan.className = 'value';
                valSpan.textContent = m.Value;
                valSpan.title = 'Double click to edit';
                valSpan.style.cursor = 'text';
                
                let fullPath = parentPath;
                if (m.Name.startsWith('[')) fullPath += m.Name;
                else fullPath += '.' + m.Name;
                
                valSpan.ondblclick = function() { enterEditMode(valSpan, fullPath); };
                
                content.appendChild(nameSpan);
                content.appendChild(document.createTextNode(': '));
                content.appendChild(typeSpan);
                content.appendChild(document.createTextNode(' '));
                content.appendChild(valSpan);

                if (m.Address) {
                    const addrSpan = document.createElement('span');
                    addrSpan.className = 'address';
                    addrSpan.textContent = `[${m.Address}]`;
                    content.appendChild(addrSpan);
                }
                
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
                                
                                const res = await fetchVal(fullPath);
                                childContainer.textContent = '';
                                if (res.ok) {
                                    if (res.data.Members) {
                                        renderMembers(res.data.Members, fullPath, childContainer);
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

        function enterEditMode(element, path) {
            const originalValue = element.textContent;
            const input = document.createElement('input');
            input.type = 'text';
            input.value = originalValue;
            input.style.width = '150px';
            input.style.background = '#3c3c3c';
            input.style.color = '#ce9178';
            input.style.border = '1px solid #0e639c';
            input.style.padding = '2px';
            input.style.fontFamily = 'Consolas, monospace';
            
            let saved = false;
            function save() {
                if (saved) return;
                saved = true;
                const newValue = input.value;
                if (newValue === originalValue) {
                    element.textContent = originalValue;
                    return;
                }
                
                const expr = `${path} = ${newValue}`;
                element.textContent = 'Saving...';
                
                fetchVal(expr).then(res => {
                    if (res.ok) {
                        element.textContent = res.data.Value;
                    } else {
                        alert('Failed to set value: ' + res.error);
                        element.textContent = originalValue;
                    }
                });
            }
            
            input.onkeydown = function(e) {
                if (e.key === 'Enter') {
                    save();
                } else if (e.key === 'Escape') {
                    saved = true;
                    element.textContent = originalValue;
                }
            };
            
            input.onblur = function() {
                save();
            };
            
            element.textContent = '';
            element.appendChild(input);
            input.focus();
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
                
                const val = w.lastValue !== undefined ? w.lastValue : '...';
                const color = w.isError ? '#f48771' : '#ce9178';
                const title = w.lastType || '';
                
                const escapedExpr = w.expr.replace(/'/g, ""\\'"").replace(/""/g, ""&quot;"");

                div.innerHTML = `
                    <span class=""watch-expr"" title=""${w.expr}"">${w.expr}</span>
                    <span class=""watch-val"" id=""val-${idx}"" style=""color:${color}"" title=""${title}"">${val}</span>
                    <div class=""watch-controls"">
                        <button class=""icon-btn"" onclick=""sendToConsole('${escapedExpr}')"" title=""Edit in Console"">✎</button>
                        <button class=""icon-btn remove-btn"" onclick=""removeWatch(${idx})"" title=""Remove"">X</button>
                    </div>
                `;
                container.appendChild(div);
            });
            localStorage.setItem('watches', JSON.stringify(watches));
        }

        function addWatch(optExpr) {
            const input = document.getElementById('watch-input');
            const expr = optExpr || input.value.trim();
            if (expr) {
                watches.push({ expr: expr });
                if (!optExpr) input.value = '';
                renderWatches();
            }
        }

        function addConsoleToWatch() {
            const expr = document.getElementById('expr').value.trim();
            if (expr) addWatch(expr);
        }

        function sendToConsole(expr) {
            const input = document.getElementById('expr');
            input.value = expr;
            const panel = document.getElementById('panel-console');
            if (panel.classList.contains('collapsed')) togglePanel('panel-console');
            input.focus();
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
                        
                        watches[i].lastValue = res.data.Value;
                        watches[i].lastType = res.data.Type;
                        watches[i].isError = false;
                    } else {
                        el.textContent = 'Error';
                        el.style.color = '#f48771';
                        
                        watches[i].lastValue = 'Error';
                        watches[i].isError = true;
                    }
                }
            }
        }

        function toggleAutoRefresh() {
            const cb = document.getElementById('auto-refresh');
            if (cb.checked) {
                resetWatchTimer();
            } else {
                if (refreshTimer) clearInterval(refreshTimer);
            }
        }

        function resetWatchTimer() {
            if (refreshTimer) clearInterval(refreshTimer);
            const cb = document.getElementById('auto-refresh');
            if (!cb.checked) return;

            const intervalInput = document.getElementById('watch-refresh-interval');
            let interval = parseInt(intervalInput.value) || 2000;
            if (interval < 100) interval = 100;

            refreshTimer = setInterval(refreshWatch, interval);
        }

        // Init
        renderWatches();
        refreshWatch();
        refreshThreads();
        toggleAutoRefresh();
        toggleThreadAutoRefresh();
    </script>
</body>
</html>";
    }
}
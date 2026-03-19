using System.CommandLine;
using System.CommandLine.Invocation;

using MetaMystia.UI;

namespace MetaMystia.ConsoleSystem.Commands;

public static class DebugCommands
{
    public static void Register(RootCommand root)
    {
        // /debug
        var debugCmd = new Command("debug", "Show multiplayer debug info");
        debugCmd.SetHandler(ctx =>
        {
            ctx.Log(MpManager.DebugText);
        });
        root.AddCommand(debugCmd);

        // /webdebug start <key>
        var webDebugCmd = new Command("webdebug", "Web debugger management");
        var startCmd = new Command("start", "Start the web debugger");
        var keyArg = new Argument<string>("key", "Security confirmation key");
        startCmd.AddArgument(keyArg);
        startCmd.SetHandler(ctx =>
        {
            string key = ctx.ParseResult.GetValueForArgument(keyArg);
            if (key != "我已知晓风险并同意启动Web调试器")
            {
                ctx.Log(TextId.InvalidWebDebuggerKey.Get());
                return;
            }
            PluginManager.Debugger ??= new Debugger.WebDebugger();
            PluginManager.Debugger?.Start();
            ctx.Log(TextId.WebDebuggerStarted.Get());
        });
        webDebugCmd.AddCommand(startCmd);

        // Default handler for /webdebug without subcommand
        webDebugCmd.SetHandler(ctx =>
        {
            ctx.Log($"{ConsoleFormat.Cmd("/webdebug start")} {ConsoleFormat.Arg("<key>")}  {ConsoleFormat.Dim("Start web debugger")}");
        });

        root.AddCommand(webDebugCmd);

        CommandRegistry.RegisterCompletions("webdebug", 0, "start");
        CommandRegistry.RegisterHint("webdebug start", 0, "<security key>");
    }
}

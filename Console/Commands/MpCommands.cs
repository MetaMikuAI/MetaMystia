using System.CommandLine;
using System.CommandLine.Invocation;

using MetaMystia.Network;
using MetaMystia.UI;

namespace MetaMystia.ConsoleSystem.Commands;

public static class MpCommands
{
    public static void Register(RootCommand root)
    {
        var mpCmd = new Command("mp", "Multiplayer commands");

        // /mp start <role>
        var startCmd = new Command("start", "Start multiplayer");
        var roleArg = new Argument<string>("role", "server or client")
            .FromAmong("server", "client");
        startCmd.AddArgument(roleArg);
        startCmd.SetHandler(ctx =>
        {
            string role = ctx.ParseResult.GetValueForArgument(roleArg);
            if (MpManager.IsRunning)
            {
                ctx.Log(TextId.MpAlreadyStarted.Get(MpManager.RoleName));
                return;
            }
            if (role == "server")
            {
                if (MpManager.Start(MpManager.ROLE.Host))
                    ctx.Log(TextId.MpStartedAsHost.Get());
            }
            else
            {
                if (MpManager.Start(MpManager.ROLE.Client))
                    ctx.Log(TextId.MpStartedAsClient.Get());
            }
        });
        mpCmd.AddCommand(startCmd);

        // /mp stop
        var stopCmd = new Command("stop", "Stop multiplayer");
        stopCmd.SetHandler(ctx =>
        {
            MpManager.Stop();
            ctx.Log(TextId.MpStopped.Get());
        });
        mpCmd.AddCommand(stopCmd);

        // /mp restart
        var restartCmd = new Command("restart", "Restart multiplayer");
        restartCmd.SetHandler(ctx =>
        {
            if (MpManager.Restart())
                ctx.Log(TextId.MpRestarted.Get());
        });
        mpCmd.AddCommand(restartCmd);

        // /mp status
        var statusCmd = new Command("status", "Show multiplayer status");
        statusCmd.SetHandler(ctx =>
        {
            ctx.Log(MpManager.GetStatus());
            ctx.Log(MpManager.DebugText);
        });
        mpCmd.AddCommand(statusCmd);

        // /mp id <id>
        var idCmd = new Command("id", "Set player ID");
        var idArg = new Argument<string>("id", "New player ID");
        idCmd.AddArgument(idArg);
        idCmd.SetHandler(ctx =>
        {
            string id = ctx.ParseResult.GetValueForArgument(idArg);
            MpManager.PlayerId = id;
            PlayerIdChangeAction.Send(id);
            ctx.Log(TextId.MpPlayerIdSet.Get(id));
        });
        mpCmd.AddCommand(idCmd);

        // /mp connect <address> [port]
        var connectCmd = new Command("connect", "Connect to a peer");
        var addressArg = new Argument<string>("address", "IP address or IP:port");
        var portArg = new Argument<int?>("port") { Arity = ArgumentArity.ZeroOrOne };
        portArg.SetDefaultValue(null);
        connectCmd.AddArgument(addressArg);
        connectCmd.AddArgument(portArg);
        connectCmd.SetHandler(async ctx =>
        {
            string address = ctx.ParseResult.GetValueForArgument(addressArg);
            int? port = ctx.ParseResult.GetValueForArgument(portArg);
            bool result;

            if (port.HasValue)
            {
                result = await MpManager.ConnectToPeerAsync(address, port.Value);
            }
            else
            {
                // Try parsing ip:port format
                int idx = address.LastIndexOf(':');
                if (idx > 0 && idx != address.Length - 1)
                {
                    string host = address[..idx];
                    string portStr = address[(idx + 1)..];
                    if (int.TryParse(portStr, out int parsedPort))
                        result = await MpManager.ConnectToPeerAsync(host, parsedPort);
                    else
                        result = await MpManager.ConnectToPeerAsync(address);
                }
                else
                {
                    result = await MpManager.ConnectToPeerAsync(address);
                }
            }

            if (result)
                ctx.Log(TextId.ConnectCommandConnected.Get(address));
            else
                ctx.Log(TextId.ConnectCommandFail.Get(address));
        });
        mpCmd.AddCommand(connectCmd);

        // /mp disconnect
        var disconnectCmd = new Command("disconnect", "Disconnect from peer");
        disconnectCmd.SetHandler(ctx =>
        {
            if (!MpManager.IsConnected)
                ctx.Log(TextId.MpNoActiveConnection.Get());
            else
            {
                MpManager.DisconnectPeer();
                ctx.Log(TextId.MpDisconnected.Get());
            }
        });
        mpCmd.AddCommand(disconnectCmd);

        // /mp continue <phase>
        var continueCmd = new Command("continue", "Force continue to next phase (host only)");
        var phaseArg = new Argument<string>("phase", "Phase to continue to")
            .FromAmong("day", "prep");
        continueCmd.AddArgument(phaseArg);
        continueCmd.SetHandler(ctx =>
        {
            if (!MpManager.IsHost)
            {
                ctx.Log(TextId.MpContinueHostOnly.Get());
                return;
            }
            string phase = ctx.ParseResult.GetValueForArgument(phaseArg);
            bool success = phase == "day" ? MpManager.ContinueDay() : MpManager.ContinuePrep();
            ctx.Log(success
                ? TextId.MpContinueSuccess.Get(phase)
                : TextId.MpContinueFailed.Get(phase));
        });
        mpCmd.AddCommand(continueCmd);

        // Default handler when /mp is called without subcommand
        mpCmd.SetHandler(ctx =>
        {
            ctx.Log(ConsoleFormat.Header(TextId.MpHelpHeader.Get()));
            ctx.Log(ConsoleFormat.SubCmd("/mp start", "<server|client>", TextId.MpDescStart.Get()));
            ctx.Log(ConsoleFormat.SubCmd("/mp stop", null, TextId.MpDescStop.Get()));
            ctx.Log(ConsoleFormat.SubCmd("/mp restart", null, TextId.MpDescRestart.Get()));
            ctx.Log(ConsoleFormat.SubCmd("/mp status", null, TextId.MpDescStatus.Get()));
            ctx.Log(ConsoleFormat.SubCmd("/mp id", "<id>", TextId.MpDescId.Get()));
            ctx.Log(ConsoleFormat.SubCmd("/mp connect", "<addr> [port]", TextId.MpDescConnect.Get()));
            ctx.Log(ConsoleFormat.SubCmd("/mp disconnect", null, TextId.MpDescDisconnect.Get()));
            ctx.Log(ConsoleFormat.SubCmd("/mp continue", "<day|prep>", TextId.MpDescContinue.Get()));
            ctx.Log(ConsoleFormat.Line);
        });

        root.AddCommand(mpCmd);

        CommandRegistry.RegisterCompletions("mp", 0, "start", "stop", "restart", "status", "id", "connect", "disconnect", "continue");
        CommandRegistry.RegisterCompletions("mp start", 0, "server", "client");
        CommandRegistry.RegisterCompletions("mp continue", 0, "day", "prep");
        CommandRegistry.RegisterHint("mp id", 0, "<player ID>");
        CommandRegistry.RegisterHint("mp connect", 0, "<IP address or IP:port>");
        CommandRegistry.RegisterHint("mp connect", 1, "<port>");
    }
}

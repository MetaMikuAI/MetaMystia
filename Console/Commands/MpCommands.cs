using System.CommandLine;
using System.CommandLine.Invocation;
using System.Linq;

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
            ctx.Log(ConsoleFormat.Header("Multiplayer Status"));
            ctx.Log($"  {ConsoleFormat.Dim("Role:")} {ConsoleFormat.Cmd(MpManager.RoleName)} {ConsoleFormat.Dim("|")} {ConsoleFormat.Dim("ID:")} {ConsoleFormat.Arg(MpManager.PlayerId)} {ConsoleFormat.Dim($"(uid={PlayerManager.Local.Uid})")}");
            ctx.Log($"  {ConsoleFormat.Dim("Running:")} {(MpManager.IsRunning ? ConsoleFormat.Ok("Yes") : ConsoleFormat.Err("No"))} {ConsoleFormat.Dim("|")} {ConsoleFormat.Dim("Connected:")} {(MpManager.IsConnected ? ConsoleFormat.Ok("Yes") : ConsoleFormat.Err("No"))}");
            if (MpManager.IsConnected)
            {
                ctx.Log($"  {ConsoleFormat.Dim("Ping:")} {MpManager.Latency}ms {ConsoleFormat.Dim("|")} {ConsoleFormat.Dim("Players:")} {MpManager.AllPlayersCount}/{ConfigManager.MaxPlayers.Value} {ConsoleFormat.Dim("|")} {ConsoleFormat.Dim("Scene:")} {MpManager.LocalScene}");
                foreach (var kvp in PlayerManager.Peers)
                {
                    var role = kvp.Key == MpManager.HOST_UID ? ConsoleFormat.Cmd("[S]") : ConsoleFormat.Dim("[C]");
                    ctx.Log($"    {role} {ConsoleFormat.Arg(kvp.Value.Id)} {ConsoleFormat.Dim($"uid={kvp.Key}")}");
                }
            }
            ctx.Log(ConsoleFormat.Dim(MpManager.DebugText));
            ctx.Log(ConsoleFormat.Line);
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

        // /mp kick id <name> | /mp kick uid <uid>
        var kickCmd = new Command("kick", "Kick a player (host only)");

        var kickIdCmd = new Command("id", "Kick by player name");
        var kickNameArg = new Argument<string>("name", "Player name");
        kickIdCmd.AddArgument(kickNameArg);
        kickIdCmd.SetHandler(ctx =>
        {
            if (!MpManager.IsHost) { ctx.Log(TextId.MpKickHostOnly.Get()); return; }
            if (PlayerManager.Peers.IsEmpty) { ctx.Log(TextId.MpKickNoTarget.Get()); return; }
            string name = ctx.ParseResult.GetValueForArgument(kickNameArg);
            foreach (var kvp in PlayerManager.Peers)
            {
                if (string.Equals(kvp.Value.Id, name, System.StringComparison.OrdinalIgnoreCase))
                {
                    MpManager.DisconnectClient(kvp.Key);
                    ctx.Log(TextId.MpKickSuccess.Get(kvp.Value.Id, kvp.Key));
                    return;
                }
            }
            ctx.Log(ConsoleFormat.Err(TextId.MpKickNotFound.Get(name)));
        });
        kickCmd.AddCommand(kickIdCmd);

        var kickUidCmd = new Command("uid", "Kick by UID");
        var kickUidArg = new Argument<int>("uid", "Player UID");
        kickUidCmd.AddArgument(kickUidArg);
        kickUidCmd.SetHandler(ctx =>
        {
            if (!MpManager.IsHost) { ctx.Log(TextId.MpKickHostOnly.Get()); return; }
            if (PlayerManager.Peers.IsEmpty) { ctx.Log(TextId.MpKickNoTarget.Get()); return; }
            int uid = ctx.ParseResult.GetValueForArgument(kickUidArg);
            if (uid == MpManager.HOST_UID) { ctx.Log(TextId.MpKickSelf.Get()); return; }
            if (PlayerManager.Peers.TryGetValue(uid, out var peer))
            {
                MpManager.DisconnectClient(uid);
                ctx.Log(TextId.MpKickSuccess.Get(peer.Id, uid));
            }
            else
            {
                ctx.Log(ConsoleFormat.Err(TextId.MpKickNotFound.Get(uid.ToString())));
            }
        });
        kickCmd.AddCommand(kickUidCmd);

        // Default: show kick usage
        kickCmd.SetHandler(ctx =>
        {
            ctx.Log(ConsoleFormat.SubCmd("/mp kick id", "<name>", TextId.MpDescKickId.Get()));
            ctx.Log(ConsoleFormat.SubCmd("/mp kick uid", "<uid>", TextId.MpDescKickUid.Get()));
            if (MpManager.IsHost && !PlayerManager.Peers.IsEmpty)
            {
                ctx.Log(ConsoleFormat.Dim("Online: " + string.Join(", ",
                    PlayerManager.Peers.Select(p => $"{p.Value.Id}(uid={p.Key})"))));
            }
        });
        mpCmd.AddCommand(kickCmd);

        // /mp maxplayers [number]
        var maxPlayersCmd = new Command("maxplayers", "View or set max player limit");
        var maxPlayersArg = new Argument<int>("count", () => -1, "Max players (>= 2)");
        maxPlayersCmd.AddArgument(maxPlayersArg);
        maxPlayersCmd.SetHandler(ctx =>
        {
            int count = ctx.ParseResult.GetValueForArgument(maxPlayersArg);
            if (count == -1)
            {
                ctx.Log(TextId.MpMaxPlayersCurrent.Get(ConfigManager.MaxPlayers.Value));
                return;
            }
            if (!MpManager.IsHost && MpManager.IsConnected)
            {
                ctx.Log(ConsoleFormat.Err(TextId.MpMaxPlayersHostOnly.Get()));
                return;
            }
            if (count < 2)
            {
                ctx.Log(ConsoleFormat.Err(TextId.MpMaxPlayersRange.Get()));
                return;
            }
            ConfigManager.MaxPlayers.Value = count;
            ctx.Log(TextId.MpMaxPlayersSet.Get(count));
        });
        mpCmd.AddCommand(maxPlayersCmd);

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
            ctx.Log(ConsoleFormat.SubCmd("/mp kick", "id|uid <target>", TextId.MpDescKick.Get()));
            ctx.Log(ConsoleFormat.SubCmd("/mp maxplayers", "[count]", TextId.MpDescMaxPlayers.Get()));
            ctx.Log(ConsoleFormat.SubCmd("/mp continue", "<day|prep>", TextId.MpDescContinue.Get()));
            ctx.Log(ConsoleFormat.Line);
        });

        root.AddCommand(mpCmd);

        CommandRegistry.RegisterCompletions("mp", 0, "start", "stop", "restart", "status", "id", "connect", "disconnect", "kick", "maxplayers", "continue");
        CommandRegistry.RegisterCompletions("mp start", 0, "server", "client");
        CommandRegistry.RegisterCompletions("mp continue", 0, "day", "prep");
        CommandRegistry.RegisterCompletions("mp kick", 0, "id", "uid");
        CommandRegistry.RegisterDynamicCompletions("mp kick id", 0, () =>
            PlayerManager.Peers.Values.Select(p => p.Id).ToArray());
        CommandRegistry.RegisterDynamicCompletions("mp kick uid", 0, () =>
            PlayerManager.Peers.Keys.Select(uid => uid.ToString()).ToArray());
        CommandRegistry.RegisterHint("mp id", 0, "<player ID>");
        CommandRegistry.RegisterHint("mp connect", 0, "<IP address or IP:port>");
        CommandRegistry.RegisterHint("mp connect", 1, "<port>");
    }
}

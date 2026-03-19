using System.CommandLine;
using System.CommandLine.Invocation;

using MetaMystia.Network;
using MetaMystia.UI;

namespace MetaMystia.ConsoleSystem.Commands;

public static class SkinCommands
{
    public static void Register(RootCommand root)
    {
        var skinCmd = new Command("skin", "Character skin management");

        // /skin set <characterId> <type> <skinIndex>
        var setCmd = new Command("set", "Set character skin");
        var charIdArg = new Argument<int>("characterId", "Character ID");
        var typeArg = new Argument<string>("type", "Skin type: Default, Explicit, or DLC")
            .FromAmong("Default", "Explicit", "DLC");
        var skinIndexArg = new Argument<int>("skinIndex", "Skin index");
        setCmd.AddArgument(charIdArg);
        setCmd.AddArgument(typeArg);
        setCmd.AddArgument(skinIndexArg);
        setCmd.SetHandler(ctx =>
        {
            int characterId = ctx.ParseResult.GetValueForArgument(charIdArg);
            string typeStr = ctx.ParseResult.GetValueForArgument(typeArg);
            int skinIndex = ctx.ParseResult.GetValueForArgument(skinIndexArg);

            if (!System.Enum.TryParse<GameData.Core.Collections.CharacterUtility.CharacterSkinSets.SelectedType>(
                    typeStr, true, out var selectedType))
            {
                ctx.Log($"Invalid type: {typeStr}. Use Default, Explicit, or DLC.");
                return;
            }

            PlayerManager.Local.Skin.SetSkin(characterId, selectedType, skinIndex);
            PlayerManager.Local.IsCustomSkinOverride = true;
            PlayerManager.Local.UpdateCharacterSprite();
            if (MpManager.IsConnected)
                SkinChangeAction.Send(PlayerManager.Local.Skin);
            PlayerManager.RefreshPortrait();
            ctx.Log($"Skin set to: CharacterId={characterId}, Type={selectedType}, Index={skinIndex}");
        });
        skinCmd.AddCommand(setCmd);

        // /skin off
        var offCmd = new Command("off", "Reset skin to game default");
        offCmd.SetHandler(ctx =>
        {
            PlayerManager.Local.IsCustomSkinOverride = false;
            PlayerManager.InitLocalSkin();
            PlayerManager.Local.UpdateCharacterSprite();
            if (MpManager.IsConnected)
                SkinChangeAction.Send(PlayerManager.Local.Skin);
            PlayerManager.RefreshPortrait();
            ctx.Log("Skin reset to game default.");
        });
        skinCmd.AddCommand(offCmd);

        // /skin list
        var listCmd = new Command("list", "List all available skins");
        listCmd.SetHandler(ctx =>
        {
            ctx.Log(PlayerSkin.GetAllSkinsTable());
        });
        skinCmd.AddCommand(listCmd);

        // Default handler
        skinCmd.SetHandler(ctx =>
        {
            ctx.Log(ConsoleFormat.Header(TextId.SkinHelpHeader.Get()));
            ctx.Log(ConsoleFormat.SubCmd("/skin set", "<charId> <Default|Explicit|DLC> <skinIdx>", TextId.SkinDescSet.Get()));
            ctx.Log(ConsoleFormat.SubCmd("/skin off", null, TextId.SkinDescOff.Get()));
            ctx.Log(ConsoleFormat.SubCmd("/skin list", null, TextId.SkinDescList.Get()));
            ctx.Log(ConsoleFormat.Line);
        });

        root.AddCommand(skinCmd);

        CommandRegistry.RegisterCompletions("skin", 0, "set", "off", "list");
        CommandRegistry.RegisterCompletions("skin set", 1, "Default", "Explicit", "DLC");
        CommandRegistry.RegisterHint("skin set", 0, "<characterId>");
        CommandRegistry.RegisterHint("skin set", 2, "<skinIndex>");
    }
}

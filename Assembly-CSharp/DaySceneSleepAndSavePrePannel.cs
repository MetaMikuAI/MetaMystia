using System;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

// Token: 0x0200001F RID: 31
[Token(Token = "0x200001F")]
[GenerateCleanupMethod]
public class DaySceneSleepAndSavePrePannel : UIPanel
{
	// Token: 0x060000A2 RID: 162 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x40C1A0", Offset = "0x40ABA0", VA = "0x18040C1A0", Slot = "21")]
	protected override void OnPanelOpen()
	{
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x40C160", Offset = "0x40AB60", VA = "0x18040C160", Slot = "31")]
	protected override void Cleanup_Generated()
	{
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x408E80", Offset = "0x407880", VA = "0x180408E80")]
	public DaySceneSleepAndSavePrePannel()
	{
	}

	// Token: 0x04000086 RID: 134
	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x70")]
	public DialogPackage haveEventDialog;

	// Token: 0x04000087 RID: 135
	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x78")]
	public DaySceneSleepAndSavePannel pannel;
}

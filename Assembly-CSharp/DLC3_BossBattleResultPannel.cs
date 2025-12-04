using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

// Token: 0x02000030 RID: 48
[Token(Token = "0x2000030")]
[GenerateCleanupMethod]
public class DLC3_BossBattleResultPannel : UIPanel
{
	// Token: 0x1700001B RID: 27
	// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002448 File Offset: 0x00000648
	// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700001B")]
	public DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext PannelOpenContext
	{
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x408E90", Offset = "0x407890", VA = "0x180408E90")]
		[CompilerGenerated]
		private get
		{
			return default(DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext);
		}
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x408EA0", Offset = "0x4078A0", VA = "0x180408EA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x408B80", Offset = "0x407580", VA = "0x180408B80", Slot = "22")]
	protected override void OnPanelInitialize()
	{
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x408C30", Offset = "0x407630", VA = "0x180408C30", Slot = "21")]
	protected override void OnPanelOpen()
	{
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x408B00", Offset = "0x407500", VA = "0x180408B00", Slot = "31")]
	protected override void Cleanup_Generated()
	{
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x408E80", Offset = "0x407880", VA = "0x180408E80")]
	public DLC3_BossBattleResultPannel()
	{
	}

	// Token: 0x040000C4 RID: 196
	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x70")]
	public UIButtonSimple confirm;

	// Token: 0x040000C5 RID: 197
	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x78")]
	public UIElementCluster cluster;

	// Token: 0x040000C6 RID: 198
	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x80")]
	public GameObject cookPage;

	// Token: 0x040000C7 RID: 199
	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x88")]
	public GameObject musicPage;

	// Token: 0x040000C8 RID: 200
	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x90")]
	public GameObject risingEffect;

	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	public enum OpenType
	{
		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		Cook,
		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		Music
	}

	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	public readonly struct BossBattleResultPannelOpenContext
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x406C20", Offset = "0x405620", VA = "0x180406C20")]
		public BossBattleResultPannelOpenContext(DLC3_BossBattleResultPannel.OpenType openType, int myScore, int bossScore, int maxCombo)
		{
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x0")]
		public readonly DLC3_BossBattleResultPannel.OpenType openType;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x4")]
		public readonly int myScore;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x8")]
		public readonly int bossScore;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0xC")]
		public readonly int maxCombo;
	}
}

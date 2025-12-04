using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

// Token: 0x02000033 RID: 51
[Token(Token = "0x2000033")]
[GenerateCleanupMethod]
public class DLC5_ChallengeResult : UIPanelParamOpen<DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext>
{
	// Token: 0x060000F8 RID: 248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x40AC60", Offset = "0x409660", VA = "0x18040AC60", Slot = "22")]
	protected override void OnPanelInitialize()
	{
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x40AD20", Offset = "0x409720", VA = "0x18040AD20", Slot = "32")]
	protected override void OnPanelOpen(DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext openContext)
	{
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x40AC00", Offset = "0x409600", VA = "0x18040AC00", Slot = "31")]
	protected override void Cleanup_Generated()
	{
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x40AEE0", Offset = "0x4098E0", VA = "0x18040AEE0")]
	public DLC5_ChallengeResult()
	{
	}

	// Token: 0x040000D1 RID: 209
	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x80")]
	public UIButtonSimple confirm;

	// Token: 0x040000D2 RID: 210
	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x88")]
	public UIElementCluster cluster;

	// Token: 0x040000D3 RID: 211
	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x90")]
	public GameObject risingEffect;

	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public enum OpenType
	{
		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		Cook,
		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		Music
	}

	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public readonly struct DLC5_ChallengeResultPannelOpenContext
	{
		// Token: 0x060000FC RID: 252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x40ABE0", Offset = "0x4095E0", VA = "0x18040ABE0")]
		public DLC5_ChallengeResultPannelOpenContext(int oldTime, int newTime, float oldSpeed, float newSpeed)
		{
		}

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x0")]
		public readonly int oldTime;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x4")]
		public readonly int newTime;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x8")]
		public readonly float oldSpeed;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0xC")]
		public readonly float newSpeed;
	}
}

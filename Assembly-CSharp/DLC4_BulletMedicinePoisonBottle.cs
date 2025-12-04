using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Night.BossBattle.DLC4_BossBattle;
using UnityCSharpCleanupGenerator.Attribute;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
[GenerateCleanupMethod]
public class DLC4_BulletMedicinePoisonBottle : DLC4_BulletTeamParabolic
{
	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600004C RID: 76 RVA: 0x00002208 File Offset: 0x00000408
	// (set) Token: 0x0600004D RID: 77 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000009")]
	private bool HasPoison
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x409E30", Offset = "0x408830", VA = "0x180409E30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x409E60", Offset = "0x408860", VA = "0x180409E60")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600004E RID: 78 RVA: 0x00002220 File Offset: 0x00000420
	// (set) Token: 0x0600004F RID: 79 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700000A")]
	private int PoisonDamage
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x409E40", Offset = "0x408840", VA = "0x180409E40")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x409E70", Offset = "0x408870", VA = "0x180409E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000050 RID: 80 RVA: 0x00002238 File Offset: 0x00000438
	// (set) Token: 0x06000051 RID: 81 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700000B")]
	private int PoisonDuration
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x409E50", Offset = "0x408850", VA = "0x180409E50")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x409E80", Offset = "0x408880", VA = "0x180409E80")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x409E00", Offset = "0x408800", VA = "0x180409E00")]
	public void OnBulletEnable(bool hasPoison, int poisonDamage, int poisonDuration)
	{
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x409D50", Offset = "0x408750", VA = "0x180409D50", Slot = "9")]
	protected override void AfterHitEnemy(DLC4_FlandreEnemyCharacterController enemy)
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x409DF0", Offset = "0x4087F0", VA = "0x180409DF0", Slot = "7")]
	protected override void Cleanup_Generated()
	{
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x409E20", Offset = "0x408820", VA = "0x180409E20")]
	public DLC4_BulletMedicinePoisonBottle()
	{
	}
}

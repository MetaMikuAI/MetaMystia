using System;
using Il2CppDummyDll;
using Night.BossBattle.DLC4_BossBattle;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
[GenerateCleanupMethod]
public class DLC4_SadFlandreCharacterController : DLC4_FlandreEnemyCharacterController
{
	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000066 RID: 102 RVA: 0x00002268 File Offset: 0x00000468
	[Token(Token = "0x1700000C")]
	public override bool CanBeFrozen
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x40ABD0", Offset = "0x4095D0", VA = "0x18040ABD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x40A9C0", Offset = "0x4093C0", VA = "0x18040A9C0", Slot = "5")]
	public override void Initialize(DLC4_BossBattleManager dlc4BossBattleManager, Action afterAttackingFinishCallback, Action afterCompletelyDeadCallback, DLC4_FlandreEnemyCharacterController.AttackConditionCheck attackConditionCheck)
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x40AA60", Offset = "0x409460", VA = "0x18040AA60")]
	private void ShowHitEffect()
	{
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x40A740", Offset = "0x409140", VA = "0x18040A740", Slot = "10")]
	protected override void CalculateRemainingHealth(int damage, bool showMercy = false, bool internalInjury = false)
	{
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x40A930", Offset = "0x409330", VA = "0x18040A930", Slot = "12")]
	protected override void Cleanup_Generated()
	{
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x40A3C0", Offset = "0x408DC0", VA = "0x18040A3C0")]
	public DLC4_SadFlandreCharacterController()
	{
	}

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	private const string END_TRIGGER = "End";

	// Token: 0x0400004C RID: 76
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int s_End;

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private int m_ShieldHealth;

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private Animator m_ShieldVisual;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private SpriteRenderer m_ShieldSpriteRenderer;

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private SpriteRenderer m_HitEffectSpriteRenderer;

	// Token: 0x04000051 RID: 81
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private float m_ShieldMinAlpha;

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	private AudioClip m_HitShieldSfx;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x168")]
	[SerializeField]
	private AudioClip m_ShieldBrokenSfx;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x170")]
	private int currentShieldHealth;
}

using System;
using Common.Audio;
using Il2CppDummyDll;
using Night.BossBattle.DLC4_BossBattle;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

// Token: 0x02000013 RID: 19
[Token(Token = "0x2000013")]
[GenerateCleanupMethod]
public class DLC4_GladFlandreCharacterController : DLC4_FlandreEnemyCharacterController
{
	// Token: 0x06000056 RID: 86 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x409F40", Offset = "0x408940", VA = "0x180409F40", Slot = "5")]
	public override void Initialize(DLC4_BossBattleManager dlc4BossBattleManager, Action afterAttackingFinishCallback, Action afterCompletelyDeadCallback, DLC4_FlandreEnemyCharacterController.AttackConditionCheck attackConditionCheck)
	{
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002250 File Offset: 0x00000450
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x409E90", Offset = "0x408890", VA = "0x180409E90", Slot = "7")]
	public override bool CanAttack()
	{
		return default(bool);
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x40A1B0", Offset = "0x408BB0", VA = "0x18040A1B0")]
	private void Jump()
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x40A230", Offset = "0x408C30", VA = "0x18040A230")]
	private void PlayJumpAnimation()
	{
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x40A0E0", Offset = "0x408AE0", VA = "0x18040A0E0")]
	public void JumpDown()
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x40A180", Offset = "0x408B80", VA = "0x18040A180")]
	public void JumpUp()
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x409EF0", Offset = "0x4088F0", VA = "0x180409EF0", Slot = "12")]
	protected override void Cleanup_Generated()
	{
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x40A3C0", Offset = "0x408DC0", VA = "0x18040A3C0")]
	public DLC4_GladFlandreCharacterController()
	{
	}

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	private const string PARAMETER_JUMP = "Jump";

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private int m_JumpNum;

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private BoxCollider2D m_BoxCollider;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x148")]
	[SerializeField]
	private float m_XOffset;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x150")]
	[SerializeField]
	private GlobalAudioManager.DelayAudioClip m_JumpAudioClip;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x160")]
	private int currentJumpNum;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x164")]
	private bool isJumping;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x168")]
	private JumpState jumpManager;
}

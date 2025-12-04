using System;
using Common.Audio;
using Il2CppDummyDll;
using Night.BossBattle.DLC4_BossBattle;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

// Token: 0x02000014 RID: 20
[Token(Token = "0x2000014")]
[GenerateCleanupMethod]
public class DLC4_PleasedFlandreCharacterController : DLC4_FlandreEnemyCharacterController
{
	// Token: 0x0600005F RID: 95 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x40A420", Offset = "0x408E20", VA = "0x18040A420", Slot = "5")]
	public override void Initialize(DLC4_BossBattleManager dlc4BossBattleManager, Action afterAttackingFinishCallback, Action afterCompletelyDeadCallback, DLC4_FlandreEnemyCharacterController.AttackConditionCheck attackConditionCheck)
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x40A570", Offset = "0x408F70", VA = "0x18040A570", Slot = "6")]
	protected override void OnUpdate()
	{
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x40A630", Offset = "0x409030", VA = "0x18040A630")]
	public void Shoot()
	{
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x40A630", Offset = "0x409030", VA = "0x18040A630")]
	private void SpawnBullet()
	{
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x40A5E0", Offset = "0x408FE0", VA = "0x18040A5E0")]
	private void PlayThrowAnimation()
	{
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x40A3D0", Offset = "0x408DD0", VA = "0x18040A3D0", Slot = "12")]
	protected override void Cleanup_Generated()
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x40A3C0", Offset = "0x408DC0", VA = "0x18040A3C0")]
	public DLC4_PleasedFlandreCharacterController()
	{
	}

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	private const string PARAMETER_THROW = "Throw";

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x138")]
	[SerializeField]
	private float m_ShootInterval;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x140")]
	[SerializeField]
	private DLC4_FlandreEnemyCharacterController.FlandreBullet m_StarBullet;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private Transform m_BulletSpawnPoint;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	private GlobalAudioManager.DelayAudioClip m_BulletSpawnSfx;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x170")]
	private ThrowState throwManager;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x178")]
	private float waitToShootTime;
}

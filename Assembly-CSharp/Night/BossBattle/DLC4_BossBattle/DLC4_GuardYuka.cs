using System;
using System.Collections;
using System.Collections.Generic;
using Common.Audio;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001F9 RID: 505
	[Token(Token = "0x20001F9")]
	[GenerateCleanupMethod]
	public class DLC4_GuardYuka : DLC4_GuardController
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x000054C0 File Offset: 0x000036C0
		[Token(Token = "0x17000141")]
		public float FlowerSpawnPInterval
		{
			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0x5138B0", Offset = "0x5122B0", VA = "0x1805138B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x000054D8 File Offset: 0x000036D8
		[Token(Token = "0x17000142")]
		public int FlowerSpawnP
		{
			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0x45AA90", Offset = "0x459490", VA = "0x18045AA90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x000054F0 File Offset: 0x000036F0
		[Token(Token = "0x17000143")]
		public float FlowerSpawnDuration
		{
			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0x8D85E0", Offset = "0x8D6FE0", VA = "0x1808D85E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00005508 File Offset: 0x00003708
		[Token(Token = "0x17000144")]
		public float FlowerGenerateDuration
		{
			[Token(Token = "0x6000BFD")]
			[Address(RVA = "0x8D85D0", Offset = "0x8D6FD0", VA = "0x1808D85D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x00005520 File Offset: 0x00003720
		[Token(Token = "0x17000145")]
		public float PPointStayDuration
		{
			[Token(Token = "0x6000BFE")]
			[Address(RVA = "0x8D85F0", Offset = "0x8D6FF0", VA = "0x1808D85F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x00005538 File Offset: 0x00003738
		[Token(Token = "0x17000146")]
		public float PPointFlyDuration
		{
			[Token(Token = "0x6000BFF")]
			[Address(RVA = "0x4E0790", Offset = "0x4DF190", VA = "0x1804E0790")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x00005550 File Offset: 0x00003750
		[Token(Token = "0x17000147")]
		public VFXPrefab SunVFX
		{
			[Token(Token = "0x6000C00")]
			[Address(RVA = "0x8D8600", Offset = "0x8D7000", VA = "0x1808D8600")]
			get
			{
				return default(VFXPrefab);
			}
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x8D8090", Offset = "0x8D6A90", VA = "0x1808D8090", Slot = "4")]
		protected override void OnGuardControllerEnable()
		{
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x00005568 File Offset: 0x00003768
		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x8D7980", Offset = "0x8D6380", VA = "0x1808D7980")]
		private GuestGroupController.EvaluationResult Eat(GuestGroupController.EvaluationResult result, GuestGroupController thisGuest, bool oldComboProtect, out string message, out bool comboProtect)
		{
			return GuestGroupController.EvaluationResult.Exbad;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "7")]
		protected override void NormalAttack()
		{
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C04")]
		[Address(RVA = "0x8D83D0", Offset = "0x8D6DD0", VA = "0x1808D83D0", Slot = "8")]
		protected override IEnumerator SkillAttack()
		{
			return null;
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x8D7ED0", Offset = "0x8D68D0", VA = "0x1808D7ED0", Slot = "10")]
		protected override void OnDispose()
		{
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x8D78E0", Offset = "0x8D62E0", VA = "0x1808D78E0", Slot = "12")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x8D85B0", Offset = "0x8D6FB0", VA = "0x1808D85B0")]
		public DLC4_GuardYuka()
		{
		}

		// Token: 0x04000AA0 RID: 2720
		[Token(Token = "0x4000AA0")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private float m_EachSunflowerDecreaseCookTimeMultiplier;

		// Token: 0x04000AA1 RID: 2721
		[Token(Token = "0x4000AA1")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_FlowerGuardId;

		// Token: 0x04000AA2 RID: 2722
		[Token(Token = "0x4000AA2")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private DLC4_GuardController.TeamBulletProperty m_Spark;

		// Token: 0x04000AA3 RID: 2723
		[Token(Token = "0x4000AA3")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private float m_SparkStunDuration;

		// Token: 0x04000AA4 RID: 2724
		[Token(Token = "0x4000AA4")]
		[FieldOffset(Offset = "0x104")]
		[SerializeField]
		private float m_SparkWaitDuration;

		// Token: 0x04000AA5 RID: 2725
		[Token(Token = "0x4000AA5")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private float m_SparkRecoverDuration;

		// Token: 0x04000AA6 RID: 2726
		[Token(Token = "0x4000AA6")]
		[FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private float m_FlowerSpawnPInterval;

		// Token: 0x04000AA7 RID: 2727
		[Token(Token = "0x4000AA7")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private int m_FlowerSpawnP;

		// Token: 0x04000AA8 RID: 2728
		[Token(Token = "0x4000AA8")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		private float m_FlowerSpawnDuration;

		// Token: 0x04000AA9 RID: 2729
		[Token(Token = "0x4000AA9")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float m_FlowerGenerateDuration;

		// Token: 0x04000AAA RID: 2730
		[Token(Token = "0x4000AAA")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private float m_PPointStayDuration;

		// Token: 0x04000AAB RID: 2731
		[Token(Token = "0x4000AAB")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float m_PPointFlyDuration;

		// Token: 0x04000AAC RID: 2732
		[Token(Token = "0x4000AAC")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private VFXPrefab m_SunVFX;

		// Token: 0x04000AAD RID: 2733
		[Token(Token = "0x4000AAD")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private LoopedBGMPackage m_SparkSfx;

		// Token: 0x04000AAE RID: 2734
		[Token(Token = "0x4000AAE")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private AudioClip m_EndSfx;

		// Token: 0x04000AAF RID: 2735
		[Token(Token = "0x4000AAF")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private GlobalAudioManager.DelayAudioClip m_SparkStartSfx;

		// Token: 0x04000AB0 RID: 2736
		[Token(Token = "0x4000AB0")]
		[FieldOffset(Offset = "0x160")]
		public DLC4_GuardController.TeamBulletProperty m_SunFlowerGiantBullet;

		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4000AB1")]
		[FieldOffset(Offset = "0x178")]
		public DLC4_GuardController.TeamBulletProperty m_SunFlowerSmallBullet;

		// Token: 0x04000AB2 RID: 2738
		[Token(Token = "0x4000AB2")]
		[FieldOffset(Offset = "0x190")]
		private Dictionary<int, Vector2> allFlowerPosition;

		// Token: 0x04000AB3 RID: 2739
		[Token(Token = "0x4000AB3")]
		[FieldOffset(Offset = "0x198")]
		private List<int> hasSpawnedPlace;

		// Token: 0x04000AB4 RID: 2740
		[Token(Token = "0x4000AB4")]
		[FieldOffset(Offset = "0x1A0")]
		private Action interruptSunflowerBuffCallback;

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x1A8")]
		private List<DLC4_GuardYukaSunFlower> sunflowers;
	}
}

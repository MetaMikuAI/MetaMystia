using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.Audio;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001D0 RID: 464
	[Token(Token = "0x20001D0")]
	[GenerateCleanupMethod]
	public abstract class DLC4_GuardController : MonoBehaviour
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x17000115")]
		public static int MaxLevel
		{
			[Token(Token = "0x6000B14")]
			[Address(RVA = "0x7B2C90", Offset = "0x7B1690", VA = "0x1807B2C90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B15")]
		[Address(RVA = "0x8D1140", Offset = "0x8CFB40", VA = "0x1808D1140")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B16")]
		[Address(RVA = "0x8CE5C0", Offset = "0x8CCFC0", VA = "0x1808CE5C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x8D18F0", Offset = "0x8D02F0", VA = "0x1808D18F0")]
		public void Initialize(DLC4_BossBattleManager dlc4BossBattleManager, int poolId, int maxHp, GuestGroupController controller, Vector2 position, Vector3Int tablePosition, Action onLoseCallback, GuestGuardMapping.GuardType guardType, Action onDisposeCallback)
		{
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B18")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "4")]
		protected virtual void OnGuardControllerEnable()
		{
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B19")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "5")]
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1A")]
		public T SpawnBullet<T>(DLC4_GuardController.TeamBulletProperty bulletProperty, [Optional] Action<T> afterSpawn, [Optional] Vector2? overridePosition) where T : DLC4_BulletTeam
		{
			return null;
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x8D2070", Offset = "0x8D0A70", VA = "0x1808D2070")]
		protected void PlayAudio(AudioClip audioClip)
		{
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x8D1F80", Offset = "0x8D0980", VA = "0x1808D1F80")]
		protected void PlayAudioDelayed(AudioClip audioClip, float offset)
		{
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B1D")]
		[Address(RVA = "0x8D1F50", Offset = "0x8D0950", VA = "0x1808D1F50")]
		protected void PlayAudioDelayed(GlobalAudioManager.DelayAudioClip delayAudioClip)
		{
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B1E")]
		[Address(RVA = "0x8D1FB0", Offset = "0x8D09B0", VA = "0x1808D1FB0")]
		protected GameObject PlayAudioLooped(LoopedBGMPackage loopedBGMPackage, string label = "")
		{
			return null;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x8D0990", Offset = "0x8CF390", VA = "0x1808D0990", Slot = "6")]
		protected virtual bool CouldAttack()
		{
			return default(bool);
		}

		// Token: 0x06000B20 RID: 2848
		[Token(Token = "0x6000B20")]
		protected abstract void NormalAttack();

		// Token: 0x06000B21 RID: 2849
		[Token(Token = "0x6000B21")]
		protected abstract IEnumerator SkillAttack();

		// Token: 0x06000B22 RID: 2850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x8D2730", Offset = "0x8D1130", VA = "0x1808D2730")]
		public void UseSkill()
		{
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x8D22D0", Offset = "0x8D0CD0", VA = "0x1808D22D0")]
		private IEnumerator StartSkillAttack()
		{
			return null;
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x8D20A0", Offset = "0x8D0AA0", VA = "0x1808D20A0")]
		public void Recover(int hp)
		{
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00004F50 File Offset: 0x00003150
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x8D17D0", Offset = "0x8D01D0", VA = "0x1808D17D0")]
		protected bool GetBuffTime(GuardBuff.GuardBuffType buffType, out float duration)
		{
			return default(bool);
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x8D05F0", Offset = "0x8CEFF0", VA = "0x1808D05F0")]
		public void AddBuff(GuardBuff.GuardBuffType buffType, float duration, [Optional] Action onBuffEnd, [Optional] Func<GameObject> onBuffEffectCreate, [Optional] Action<GameObject> onBuffEffectEnd)
		{
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x8D2150", Offset = "0x8D0B50", VA = "0x1808D2150")]
		public void RemoveBuff(GuardBuff.GuardBuffType buffType)
		{
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x8D1E40", Offset = "0x8D0840", VA = "0x1808D1E40")]
		public void OnHurt(int damage)
		{
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x8D1D80", Offset = "0x8D0780", VA = "0x1808D1D80")]
		private void Lose()
		{
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x8D24F0", Offset = "0x8D0EF0", VA = "0x1808D24F0")]
		public void TryRepellController()
		{
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "9")]
		protected virtual void OnLoseExtraEffect()
		{
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x8D0A40", Offset = "0x8CF440", VA = "0x1808D0A40")]
		public void DisPose()
		{
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x8D1070", Offset = "0x8CFA70", VA = "0x1808D1070")]
		protected void EndSkillVFX()
		{
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "10")]
		protected virtual void OnDispose()
		{
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x8D2350", Offset = "0x8D0D50", VA = "0x1808D2350")]
		public void TryReleaseGuard()
		{
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x00004F68 File Offset: 0x00003168
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000116")]
		public int PoolId
		{
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x477F60", Offset = "0x476960", VA = "0x180477F60")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000B31")]
			[Address(RVA = "0x8D2FC0", Offset = "0x8D19C0", VA = "0x1808D2FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x00004F80 File Offset: 0x00003180
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000117")]
		public GuestGuardMapping.GuardType GuardType
		{
			[Token(Token = "0x6000B32")]
			[Address(RVA = "0x4404D0", Offset = "0x43EED0", VA = "0x1804404D0")]
			[CompilerGenerated]
			get
			{
				return GuestGuardMapping.GuardType.Hero;
			}
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x56F810", Offset = "0x56E210", VA = "0x18056F810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000118")]
		public GuestGroupController Controller
		{
			[Token(Token = "0x6000B34")]
			[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B35")]
			[Address(RVA = "0x45F1B0", Offset = "0x45DBB0", VA = "0x18045F1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x00004F98 File Offset: 0x00003198
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000119")]
		public DLC4_GuardController.GuardStatus CurrentGuardStatus
		{
			[Token(Token = "0x6000B36")]
			[Address(RVA = "0x4405B0", Offset = "0x43EFB0", VA = "0x1804405B0")]
			[CompilerGenerated]
			get
			{
				return DLC4_GuardController.GuardStatus.Idle;
			}
			[Token(Token = "0x6000B37")]
			[Address(RVA = "0x656A30", Offset = "0x655430", VA = "0x180656A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x00004FB0 File Offset: 0x000031B0
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700011A")]
		public Vector3Int TablePosition
		{
			[Token(Token = "0x6000B38")]
			[Address(RVA = "0x8D2C70", Offset = "0x8D1670", VA = "0x1808D2C70")]
			[CompilerGenerated]
			get
			{
				return default(Vector3Int);
			}
			[Token(Token = "0x6000B39")]
			[Address(RVA = "0x8D2FD0", Offset = "0x8D19D0", VA = "0x1808D2FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x1700011B")]
		public int CurrentLine
		{
			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0x8D2A70", Offset = "0x8D1470", VA = "0x1808D2A70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x00004FE0 File Offset: 0x000031E0
		// (set) Token: 0x06000B3C RID: 2876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700011C")]
		public bool ShouldBeIgnore
		{
			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x48A750", Offset = "0x489150", VA = "0x18048A750")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x48AB60", Offset = "0x489560", VA = "0x18048AB60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x00004FF8 File Offset: 0x000031F8
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700011D")]
		public int MaxHp
		{
			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0x477FA0", Offset = "0x4769A0", VA = "0x180477FA0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0x48AAC0", Offset = "0x4894C0", VA = "0x18048AAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x00005010 File Offset: 0x00003210
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700011E")]
		public float CurrentHealth
		{
			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0x8D2A60", Offset = "0x8D1460", VA = "0x1808D2A60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000B40")]
			[Address(RVA = "0x8D2C90", Offset = "0x8D1690", VA = "0x1808D2C90")]
			protected set
			{
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x8D20D0", Offset = "0x8D0AD0", VA = "0x1808D20D0")]
		private void RefreshHealthDisplay()
		{
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x00005028 File Offset: 0x00003228
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700011F")]
		public int Level
		{
			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x79D9A0", Offset = "0x79C3A0", VA = "0x18079D9A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x8D2D30", Offset = "0x8D1730", VA = "0x1808D2D30")]
			set
			{
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B45 RID: 2885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000120")]
		public DLC4_FlandreEnemyCharacterController TargetAttackEnemy
		{
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x4BE490", Offset = "0x4BCE90", VA = "0x1804BE490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x4BE690", Offset = "0x4BD090", VA = "0x1804BE690")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B47 RID: 2887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000121")]
		public List<DLC4_BulletTeam> AllShootBullet
		{
			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x48B890", Offset = "0x48A290", VA = "0x18048B890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x4D2550", Offset = "0x4D0F50", VA = "0x1804D2550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B49 RID: 2889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000122")]
		public DLC4_BossBattleManager Dlc4BossBattleManager
		{
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x428D60", Offset = "0x427760", VA = "0x180428D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B49")]
			[Address(RVA = "0x4D2530", Offset = "0x4D0F30", VA = "0x1804D2530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x00005040 File Offset: 0x00003240
		[Token(Token = "0x17000123")]
		protected virtual Vector2 SpawnPoint
		{
			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0x8D2C20", Offset = "0x8D1620", VA = "0x1808D2C20", Slot = "11")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000124")]
		protected GuestsManager GuestManager
		{
			[Token(Token = "0x6000B4B")]
			[Address(RVA = "0x8D2BF0", Offset = "0x8D15F0", VA = "0x1808D2BF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x8D0970", Offset = "0x8CF370", VA = "0x1808D0970")]
		private bool CouldAttackBase()
		{
			return default(bool);
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000B4D RID: 2893 RVA: 0x00005070 File Offset: 0x00003270
		[Token(Token = "0x17000125")]
		public bool CanNotContinueToFight
		{
			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0x8D29E0", Offset = "0x8D13E0", VA = "0x1808D29E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x00005088 File Offset: 0x00003288
		// (set) Token: 0x06000B4F RID: 2895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000126")]
		public int CanHurtByMelee
		{
			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0x43AEF0", Offset = "0x4398F0", VA = "0x18043AEF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0x448380", Offset = "0x446D80", VA = "0x180448380")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x000050A0 File Offset: 0x000032A0
		[Token(Token = "0x17000127")]
		public bool CanMeleeAttackEffective
		{
			[Token(Token = "0x6000B50")]
			[Address(RVA = "0x8D2990", Offset = "0x8D1390", VA = "0x1808D2990")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x000050B8 File Offset: 0x000032B8
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000128")]
		public int CanHurtByBullet
		{
			[Token(Token = "0x6000B51")]
			[Address(RVA = "0x409CD0", Offset = "0x4086D0", VA = "0x180409CD0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000B52")]
			[Address(RVA = "0x409D10", Offset = "0x408710", VA = "0x180409D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x000050D0 File Offset: 0x000032D0
		[Token(Token = "0x17000129")]
		public bool CanRemoteAttackEffective
		{
			[Token(Token = "0x6000B53")]
			[Address(RVA = "0x8D2A00", Offset = "0x8D1400", VA = "0x1808D2A00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012A")]
		public List<float> ExtraAttackSpeedMultiplier
		{
			[Token(Token = "0x6000B54")]
			[Address(RVA = "0x48A680", Offset = "0x489080", VA = "0x18048A680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x000050E8 File Offset: 0x000032E8
		[Token(Token = "0x1700012B")]
		private float ExtraAttackSpeed
		{
			[Token(Token = "0x6000B55")]
			[Address(RVA = "0x8D2A90", Offset = "0x8D1490", VA = "0x1808D2A90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x8D0820", Offset = "0x8CF220", VA = "0x1808D0820", Slot = "12")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x8D27B0", Offset = "0x8D11B0", VA = "0x1808D27B0")]
		protected DLC4_GuardController()
		{
		}

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		protected const int ENEMY_LAYER_MASK = 512;

		// Token: 0x040009D6 RID: 2518
		[Token(Token = "0x40009D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_NormalAttackInterval;

		// Token: 0x040009D7 RID: 2519
		[Token(Token = "0x40009D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected float m_AttackRange;

		// Token: 0x040009D8 RID: 2520
		[Token(Token = "0x40009D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected float m_FirstAttackWait;

		// Token: 0x040009D9 RID: 2521
		[Token(Token = "0x40009D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected List<GameObject> audioLoopedObjects;

		// Token: 0x040009DA RID: 2522
		[Token(Token = "0x40009DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float currentHealth;

		// Token: 0x040009DB RID: 2523
		[Token(Token = "0x40009DB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject flagObject;

		// Token: 0x040009DC RID: 2524
		[Token(Token = "0x40009DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool isUsingSkill;

		// Token: 0x040009DD RID: 2525
		[Token(Token = "0x40009DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int level;

		// Token: 0x040009DE RID: 2526
		[Token(Token = "0x40009DE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystem level2VFX;

		// Token: 0x040009DF RID: 2527
		[Token(Token = "0x40009DF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Action onDisposeLeaveCallback;

		// Token: 0x040009E0 RID: 2528
		[Token(Token = "0x40009E0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Action onLoseLeaveCallback;

		// Token: 0x040009E1 RID: 2529
		[Token(Token = "0x40009E1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action onSkillEnd;

		// Token: 0x040009E2 RID: 2530
		[Token(Token = "0x40009E2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Coroutine skillAttackCoroutine;

		// Token: 0x040009E3 RID: 2531
		[Token(Token = "0x40009E3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ParticleSystem skillVFX;

		// Token: 0x040009E4 RID: 2532
		[Token(Token = "0x40009E4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float waitToShootTime;

		// Token: 0x040009F2 RID: 2546
		[Token(Token = "0x40009F2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private List<GuardBuff> m_GuardBuffs;

		// Token: 0x040009F3 RID: 2547
		[Token(Token = "0x40009F3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private HashSet<GuardBuff.GuardBuffType> m_GuardBuffTypes;

		// Token: 0x020001D1 RID: 465
		[Token(Token = "0x20001D1")]
		[Serializable]
		public struct TeamBulletProperty
		{
			// Token: 0x040009F4 RID: 2548
			[Token(Token = "0x40009F4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public DLC4_BulletTeam m_Bullet;

			// Token: 0x040009F5 RID: 2549
			[Token(Token = "0x40009F5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			public int m_Damage;

			// Token: 0x040009F6 RID: 2550
			[Token(Token = "0x40009F6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[SerializeField]
			public float m_Speed;

			// Token: 0x040009F7 RID: 2551
			[Token(Token = "0x40009F7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public float m_MaxDuration;
		}

		// Token: 0x020001D2 RID: 466
		[Token(Token = "0x20001D2")]
		public enum GuardStatus
		{
			// Token: 0x040009F9 RID: 2553
			[Token(Token = "0x40009F9")]
			Idle,
			// Token: 0x040009FA RID: 2554
			[Token(Token = "0x40009FA")]
			Fight,
			// Token: 0x040009FB RID: 2555
			[Token(Token = "0x40009FB")]
			Defeated,
			// Token: 0x040009FC RID: 2556
			[Token(Token = "0x40009FC")]
			Disposed
		}
	}
}

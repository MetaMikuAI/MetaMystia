using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Night.BossBattle.DLC4_BossBattle;
using UnityEngine;
using UnityEngine.Serialization;

namespace GameData.Profile
{
	// Token: 0x02000C25 RID: 3109
	[Token(Token = "0x2000C25")]
	[CreateAssetMenu(fileName = "DLC4_MystiaVSFlandreBossData", menuName = "GameData Profile/BossData/DLC4_MystiaVSFlandreBossData", order = 7)]
	public class DLC4_MystiaVSFlandreBossData : BossData
	{
		// Token: 0x060048D3 RID: 18643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D3")]
		[Address(RVA = "0x74FD70", Offset = "0x74E770", VA = "0x18074FD70")]
		private DLC4_MystiaVSFlandreBossData.BigWaveProperty[] GetWaveData()
		{
			return null;
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048D4")]
		[Address(RVA = "0x74FF90", Offset = "0x74E990", VA = "0x18074FF90")]
		private void OnPreloadGeneralChallenge()
		{
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60048D5")]
		[Address(RVA = "0x74FEE0", Offset = "0x74E8E0", VA = "0x18074FEE0", Slot = "5")]
		public override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			return null;
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60048D6")]
		[Address(RVA = "0x750060", Offset = "0x74EA60", VA = "0x180750060")]
		public DLC4_MystiaVSFlandreBossData()
		{
		}

		// Token: 0x04004249 RID: 16969
		[Token(Token = "0x4004249")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int m_StartFund;

		// Token: 0x0400424A RID: 16970
		[Token(Token = "0x400424A")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("guardMappingDic")]
		[SerializeField]
		[FormerlySerializedAs("letterDic")]
		private GuestGuardMapping[] m_GuardMappingDic;

		// Token: 0x0400424B RID: 16971
		[Token(Token = "0x400424B")]
		[FieldOffset(Offset = "0x40")]
		public DLC4_ChallengeCardSelectorPanel m_CardSelectorPanel;

		// Token: 0x0400424C RID: 16972
		[Token(Token = "0x400424C")]
		[FieldOffset(Offset = "0x48")]
		public DLC4_BossBattleShopPanel m_DLC4BossBattleShopPanel;

		// Token: 0x0400424D RID: 16973
		[Token(Token = "0x400424D")]
		[FieldOffset(Offset = "0x50")]
		public DLC4_BossBattlePatchouliSpellPanel m_DLC4BossBattlePatchouliSpellPanelPanel;

		// Token: 0x0400424E RID: 16974
		[Token(Token = "0x400424E")]
		[FieldOffset(Offset = "0x58")]
		public VFXPrefab flagLevel1;

		// Token: 0x0400424F RID: 16975
		[Token(Token = "0x400424F")]
		[FieldOffset(Offset = "0x70")]
		public VFXPrefab flagLevel2;

		// Token: 0x04004250 RID: 16976
		[Token(Token = "0x4004250")]
		[FieldOffset(Offset = "0x88")]
		public VFXPrefab levelUpTo2;

		// Token: 0x04004251 RID: 16977
		[Token(Token = "0x4004251")]
		[FieldOffset(Offset = "0xA0")]
		public VFXPrefab levelUpAndSkill;

		// Token: 0x04004252 RID: 16978
		[Token(Token = "0x4004252")]
		[FieldOffset(Offset = "0xB8")]
		public VFXPrefab level2Vfx;

		// Token: 0x04004253 RID: 16979
		[Token(Token = "0x4004253")]
		[FieldOffset(Offset = "0xD0")]
		public Vector3 flagOffset;

		// Token: 0x04004254 RID: 16980
		[Token(Token = "0x4004254")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		public int m_PatchouliSpellMaxNum;

		// Token: 0x04004255 RID: 16981
		[Token(Token = "0x4004255")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		public float m_PatchouliSpellCoolDown;

		// Token: 0x04004256 RID: 16982
		[Token(Token = "0x4004256")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		public int m_PatchouliSpellPCost;

		// Token: 0x04004257 RID: 16983
		[Token(Token = "0x4004257")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private DLC4_MystiaVSFlandreBossData.PartnerMapping[] m_PartnerMapping;

		// Token: 0x04004258 RID: 16984
		[Token(Token = "0x4004258")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private DLC4_MystiaVSFlandreBossData.EnemyMapping[] m_FlandreController;

		// Token: 0x04004259 RID: 16985
		[Token(Token = "0x4004259")]
		[FieldOffset(Offset = "0xF8")]
		public VFXPrefab m_BrokenTablePic;

		// Token: 0x0400425A RID: 16986
		[Token(Token = "0x400425A")]
		[FieldOffset(Offset = "0x110")]
		public int m_LockTableDuration;

		// Token: 0x0400425B RID: 16987
		[Token(Token = "0x400425B")]
		[FieldOffset(Offset = "0x118")]
		public GameObject poisonVFX;

		// Token: 0x0400425C RID: 16988
		[Token(Token = "0x400425C")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private MultiLanguageTextMesh.MultiLanguageTextAsset m_GuardManualTxt;

		// Token: 0x0400425D RID: 16989
		[Token(Token = "0x400425D")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private MultiLanguageTextMesh.MultiLanguageTextAsset m_SpellManualTxt;

		// Token: 0x0400425E RID: 16990
		[Token(Token = "0x400425E")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private float m_LastLineXPosition;

		// Token: 0x0400425F RID: 16991
		[Token(Token = "0x400425F")]
		[FieldOffset(Offset = "0x134")]
		[SerializeField]
		private float m_FirstRefreshEnemyNeedToWait;

		// Token: 0x04004260 RID: 16992
		[Token(Token = "0x4004260")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private float m_DamageCheckingPercentage;

		// Token: 0x04004261 RID: 16993
		[Token(Token = "0x4004261")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		private float m_MinWaitTimeToNextWave;

		// Token: 0x04004262 RID: 16994
		[Token(Token = "0x4004262")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float m_WaitTimeToNextWaveDueToDamage;

		// Token: 0x04004263 RID: 16995
		[Token(Token = "0x4004263")]
		[FieldOffset(Offset = "0x144")]
		[FormerlySerializedAs("m_LastWaveLeastWait")]
		[SerializeField]
		private Vector2 m_ToRefreshNextWaveLeastWait;

		// Token: 0x04004264 RID: 16996
		[Token(Token = "0x4004264")]
		[FieldOffset(Offset = "0x14C")]
		[FormerlySerializedAs("m_WaveLeastWait")]
		[SerializeField]
		private float m_ToRefreshNextBigWaveLeastWait;

		// Token: 0x04004265 RID: 16997
		[Token(Token = "0x4004265")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Header("默认/简单难度")]
		private DLC4_MystiaVSFlandreBossData.BigWaveProperty[] m_BigWaveProperty;

		// Token: 0x04004266 RID: 16998
		[Token(Token = "0x4004266")]
		[FieldOffset(Offset = "0x158")]
		[Header("N难度")]
		public DLC4_MystiaVSFlandreBossData.BigWaveProperty[] m_BigWavePropertyNormal;

		// Token: 0x04004267 RID: 16999
		[Token(Token = "0x4004267")]
		[FieldOffset(Offset = "0x160")]
		[Header("H难度")]
		public DLC4_MystiaVSFlandreBossData.BigWaveProperty[] m_BigWavePropertyHard;

		// Token: 0x04004268 RID: 17000
		[Token(Token = "0x4004268")]
		[FieldOffset(Offset = "0x168")]
		[Header("L难度")]
		public DLC4_MystiaVSFlandreBossData.BigWaveProperty[] m_BigWavePropertyLunatic;

		// Token: 0x04004269 RID: 17001
		[Token(Token = "0x4004269")]
		[FieldOffset(Offset = "0x170")]
		public AudioClip defaultTeamBulletHitSfx;

		// Token: 0x0400426A RID: 17002
		[Token(Token = "0x400426A")]
		[FieldOffset(Offset = "0x178")]
		public AudioClip level2Sfx;

		// Token: 0x0400426B RID: 17003
		[Token(Token = "0x400426B")]
		[FieldOffset(Offset = "0x180")]
		public AudioClip skillSfx;

		// Token: 0x0400426C RID: 17004
		[Token(Token = "0x400426C")]
		[FieldOffset(Offset = "0x188")]
		private Action onChallengeEnd;

		// Token: 0x0400426D RID: 17005
		[Token(Token = "0x400426D")]
		[FieldOffset(Offset = "0x190")]
		public SpellMetal m_SpellMetal;

		// Token: 0x0400426E RID: 17006
		[Token(Token = "0x400426E")]
		[FieldOffset(Offset = "0x198")]
		public SpellWood m_SpellWood;

		// Token: 0x0400426F RID: 17007
		[Token(Token = "0x400426F")]
		[FieldOffset(Offset = "0x1A0")]
		public SpellWater m_SpellWater;

		// Token: 0x04004270 RID: 17008
		[Token(Token = "0x4004270")]
		[FieldOffset(Offset = "0x1A8")]
		public SpellFire m_SpellFire;

		// Token: 0x04004271 RID: 17009
		[Token(Token = "0x4004271")]
		[FieldOffset(Offset = "0x1B0")]
		public SpellEarth m_SpellEarth;

		// Token: 0x04004272 RID: 17010
		[Token(Token = "0x4004272")]
		[FieldOffset(Offset = "0x1B8")]
		public SpellSun m_SpellSun;

		// Token: 0x04004273 RID: 17011
		[Token(Token = "0x4004273")]
		[FieldOffset(Offset = "0x1C0")]
		public SpellMoon m_SpellMoon;

		// Token: 0x02000C26 RID: 3110
		[Token(Token = "0x2000C26")]
		[Serializable]
		public struct PartnerMapping
		{
			// Token: 0x04004274 RID: 17012
			[Token(Token = "0x4004274")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public int PartnerId;

			// Token: 0x04004275 RID: 17013
			[Token(Token = "0x4004275")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public PartnerBase.PartnerType PartnerType;
		}

		// Token: 0x02000C27 RID: 3111
		[Token(Token = "0x2000C27")]
		[Serializable]
		public struct EnemyMapping
		{
			// Token: 0x04004276 RID: 17014
			[Token(Token = "0x4004276")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public FlandreTypeIndex EnemyType;

			// Token: 0x04004277 RID: 17015
			[Token(Token = "0x4004277")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public GameObject FlandreController;
		}

		// Token: 0x02000C28 RID: 3112
		[Token(Token = "0x2000C28")]
		[Serializable]
		public struct BigWaveProperty
		{
			// Token: 0x04004278 RID: 17016
			[Token(Token = "0x4004278")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public List<DLC4_MystiaVSFlandreBossData.WaveProperty> WaveProperties;
		}

		// Token: 0x02000C29 RID: 3113
		[Token(Token = "0x2000C29")]
		[Serializable]
		public struct WaveProperty
		{
			// Token: 0x04004279 RID: 17017
			[Token(Token = "0x4004279")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public DialogPackage EventDialog;

			// Token: 0x0400427A RID: 17018
			[Token(Token = "0x400427A")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public List<DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty> EnemyRefreshProperties;
		}

		// Token: 0x02000C2A RID: 3114
		[Token(Token = "0x2000C2A")]
		[Serializable]
		public struct EnemyRefreshProperty
		{
			// Token: 0x0400427B RID: 17019
			[Token(Token = "0x400427B")]
			[FieldOffset(Offset = "0x0")]
			public FlandreTypeIndex EnemyType;

			// Token: 0x0400427C RID: 17020
			[Token(Token = "0x400427C")]
			[FieldOffset(Offset = "0x4")]
			public DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty.SpawnType EnemySpawnType;

			// Token: 0x0400427D RID: 17021
			[Token(Token = "0x400427D")]
			[FieldOffset(Offset = "0x8")]
			public DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty.RefreshNextWaveType EnemyRefreshNextWaveType;

			// Token: 0x0400427E RID: 17022
			[Token(Token = "0x400427E")]
			[FieldOffset(Offset = "0xC")]
			public int Num;

			// Token: 0x02000C2B RID: 3115
			[Token(Token = "0x2000C2B")]
			public enum RefreshNextWaveType
			{
				// Token: 0x04004280 RID: 17024
				[Token(Token = "0x4004280")]
				[InspectorName("正常机制(受到一定伤害后加速刷新下一波)")]
				Normal,
				// Token: 0x04004281 RID: 17025
				[Token(Token = "0x4004281")]
				[InspectorName("等待自身死亡")]
				WaitUntilDie,
				// Token: 0x04004282 RID: 17026
				[Token(Token = "0x4004282")]
				[InspectorName("无任何影响")]
				None
			}

			// Token: 0x02000C2C RID: 3116
			[Token(Token = "0x2000C2C")]
			public enum SpawnType
			{
				// Token: 0x04004284 RID: 17028
				[Token(Token = "0x4004284")]
				[InspectorName("正态分布")]
				NormalDistribution,
				// Token: 0x04004285 RID: 17029
				[Token(Token = "0x4004285")]
				[InspectorName("完全随机")]
				Random,
				// Token: 0x04004286 RID: 17030
				[Token(Token = "0x4004286")]
				[InspectorName("怪物最少一排")]
				FindMinimum,
				// Token: 0x04004287 RID: 17031
				[Token(Token = "0x4004287")]
				[InspectorName("仅用于Boss分身")]
				None
			}
		}

		// Token: 0x02000C2D RID: 3117
		[Token(Token = "0x2000C2D")]
		public class FlandreData
		{
			// Token: 0x17000A9D RID: 2717
			// (get) Token: 0x060048D7 RID: 18647 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060048D8 RID: 18648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A9D")]
			public List<DLC4_MystiaVSFlandreBossData.BigWaveProperty> m_BigWaveProperty
			{
				[Token(Token = "0x60048D7")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60048D8")]
				[Address(RVA = "0x3FC090", Offset = "0x3FAA90", VA = "0x1803FC090")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060048D9 RID: 18649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60048D9")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public FlandreData()
			{
			}

			// Token: 0x04004288 RID: 17032
			[Token(Token = "0x4004288")]
			[FieldOffset(Offset = "0x10")]
			public bool use;
		}
	}
}

using System;
using System.Collections;
using GameData.RunTime.NightSceneUtility;
using Il2CppDummyDll;
using NightScene;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using NightScene.Tiles;
using NightScene.UI;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BD8 RID: 3032
	[Token(Token = "0x2000BD8")]
	[CreateAssetMenu(fileName = "BossData", menuName = "GameData Profile/BossData/BaseBossData", order = 0)]
	public abstract class BossData : ScriptableObject
	{
		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x060046E5 RID: 18149 RVA: 0x000197D0 File Offset: 0x000179D0
		[Token(Token = "0x17000A5C")]
		public bool UseGhostCharacter
		{
			[Token(Token = "0x60046E5")]
			[Address(RVA = "0x685340", Offset = "0x683D40", VA = "0x180685340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E6")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "4")]
		public virtual void GotoBossChallengeScene()
		{
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x060046E7 RID: 18151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5D")]
		protected WaitForSeconds OneSecondDelay
		{
			[Token(Token = "0x60046E7")]
			[Address(RVA = "0x7330D0", Offset = "0x731AD0", VA = "0x1807330D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060046E8 RID: 18152
		[Token(Token = "0x60046E8")]
		public abstract IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext);

		// Token: 0x060046E9 RID: 18153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046E9")]
		[Address(RVA = "0x7330B0", Offset = "0x731AB0", VA = "0x1807330B0")]
		protected BossData()
		{
		}

		// Token: 0x04004009 RID: 16393
		[Token(Token = "0x4004009")]
		protected const string CORE_KEY = "CORE";

		// Token: 0x0400400A RID: 16394
		[Token(Token = "0x400400A")]
		protected const string DLC1_KEY = "DLC1";

		// Token: 0x0400400B RID: 16395
		[Token(Token = "0x400400B")]
		protected const string DLC2_KEY = "DLC2";

		// Token: 0x0400400C RID: 16396
		[Token(Token = "0x400400C")]
		protected const string DLC3_KEY = "DLC3";

		// Token: 0x0400400D RID: 16397
		[Token(Token = "0x400400D")]
		protected const string DLC4_KEY = "DLC4";

		// Token: 0x0400400E RID: 16398
		[Token(Token = "0x400400E")]
		protected const string DLC_MUSIC_KEY = "DLCMUSIC";

		// Token: 0x0400400F RID: 16399
		[Token(Token = "0x400400F")]
		[FieldOffset(Offset = "0x18")]
		public bool doNotMakePassionEffectMusic;

		// Token: 0x04004010 RID: 16400
		[Token(Token = "0x4004010")]
		[FieldOffset(Offset = "0x1C")]
		public int startPassion;

		// Token: 0x04004011 RID: 16401
		[Token(Token = "0x4004011")]
		[FieldOffset(Offset = "0x20")]
		public GameObject bossStatusUI;

		// Token: 0x04004012 RID: 16402
		[Token(Token = "0x4004012")]
		[FieldOffset(Offset = "0x28")]
		[Header("- Base Boss Data")]
		[SerializeField]
		private bool useGhostCharacter;

		// Token: 0x02000BD9 RID: 3033
		[Token(Token = "0x2000BD9")]
		public readonly struct BossDataContext
		{
			// Token: 0x060046EA RID: 18154 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60046EA")]
			[Address(RVA = "0x732FF0", Offset = "0x7319F0", VA = "0x180732FF0")]
			public BossDataContext(EventManager eventManagerInstance, UIManager uIManagerInstance, GuestsManager guestsManagerInstance, IzakayaConfigure izakayaConfigureInstance, CookSystemManager cookSystemManagerInstance, PartnerManager partnerManagerInstance, TileManager tileManagerInstance, SceneManager sceneManager, QTERewardManager qteManager)
			{
			}

			// Token: 0x04004013 RID: 16403
			[Token(Token = "0x4004013")]
			[FieldOffset(Offset = "0x0")]
			public readonly EventManager EventManagerInstance;

			// Token: 0x04004014 RID: 16404
			[Token(Token = "0x4004014")]
			[FieldOffset(Offset = "0x8")]
			public readonly UIManager UIManagerInstance;

			// Token: 0x04004015 RID: 16405
			[Token(Token = "0x4004015")]
			[FieldOffset(Offset = "0x10")]
			public readonly GuestsManager GuestsManagerInstance;

			// Token: 0x04004016 RID: 16406
			[Token(Token = "0x4004016")]
			[FieldOffset(Offset = "0x18")]
			public readonly CookSystemManager CookSystemManagerInstance;

			// Token: 0x04004017 RID: 16407
			[Token(Token = "0x4004017")]
			[FieldOffset(Offset = "0x20")]
			public readonly IzakayaConfigure IzakayaConfigureInstance;

			// Token: 0x04004018 RID: 16408
			[Token(Token = "0x4004018")]
			[FieldOffset(Offset = "0x28")]
			public readonly PartnerManager PartnerManagerInstance;

			// Token: 0x04004019 RID: 16409
			[Token(Token = "0x4004019")]
			[FieldOffset(Offset = "0x30")]
			public readonly TileManager TileManagerInstance;

			// Token: 0x0400401A RID: 16410
			[Token(Token = "0x400401A")]
			[FieldOffset(Offset = "0x38")]
			public readonly SceneManager SceneManager;

			// Token: 0x0400401B RID: 16411
			[Token(Token = "0x400401B")]
			[FieldOffset(Offset = "0x40")]
			public readonly QTERewardManager QTEManager;
		}
	}
}

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Night.BossBattle.DLC5_MizuchiBossBattle;
using NightScene;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C34 RID: 3124
	[Token(Token = "0x2000C34")]
	[CreateAssetMenu(fileName = "DLC5_MizuchiBossData", menuName = "GameData Profile/BossData/DLC5_MizuchiBossData", order = 7)]
	public class DLC5_MizuchiChallengeBossData : BossData
	{
		// Token: 0x06004909 RID: 18697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004909")]
		[Address(RVA = "0x764500", Offset = "0x762F00", VA = "0x180764500", Slot = "5")]
		public override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			return null;
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600490A")]
		[Address(RVA = "0x764650", Offset = "0x763050", VA = "0x180764650")]
		public DLC5_MizuchiChallengeBossData()
		{
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600490B")]
		[Address(RVA = "0x7645C0", Offset = "0x762FC0", VA = "0x1807645C0")]
		[CompilerGenerated]
		internal static void <MainChallengeLoop>g__DeleteAllPuyoyoFruit|66_7()
		{
		}

		// Token: 0x040042BE RID: 17086
		[Token(Token = "0x40042BE")]
		public const string MIZUCHIBUFFSWITCH_TAN = "Mizuchi_Buff_Switch_A";

		// Token: 0x040042BF RID: 17087
		[Token(Token = "0x40042BF")]
		public const string MIZUCHIBUFFSWITCH_CHEN = "Mizuchi_Buff_Switch_B";

		// Token: 0x040042C0 RID: 17088
		[Token(Token = "0x40042C0")]
		public const string MIZUCHIBUFFSWITCH_CHI = "Mizuchi_Buff_Switch_C";

		// Token: 0x040042C1 RID: 17089
		[Token(Token = "0x40042C1")]
		public const string LUNARCAPITAL_PRACTICE_KEY = "Lunarcapital_Practice_Key";

		// Token: 0x040042C2 RID: 17090
		[Token(Token = "0x40042C2")]
		private const int PUYOYOFRUIT_ID = 5002;

		// Token: 0x040042C3 RID: 17091
		[Token(Token = "0x40042C3")]
		private const int PEPPER_WATER_ID = 5005;

		// Token: 0x040042C4 RID: 17092
		[Token(Token = "0x40042C4")]
		private const int MIZUCHI_ID = 5013;

		// Token: 0x040042C5 RID: 17093
		[Token(Token = "0x40042C5")]
		[FieldOffset(Offset = "0x30")]
		[Header("客人生成时被瑞灵附身的概率")]
		public float prdRateForMizuchiSpawn;

		// Token: 0x040042C6 RID: 17094
		[Token(Token = "0x40042C6")]
		[FieldOffset(Offset = "0x38")]
		[Header("挑战数据")]
		public DLC5_MizuchiChallengeBossData.ChallengeData[] ChallengeDatas;

		// Token: 0x040042C7 RID: 17095
		[Token(Token = "0x40042C7")]
		[FieldOffset(Offset = "0x40")]
		[Header("触发粉评提高的时限")]
		public int getTimeWhenPinkEval;

		// Token: 0x040042C8 RID: 17096
		[Token(Token = "0x40042C8")]
		[FieldOffset(Offset = "0x44")]
		[Header("触发橙评提高的时限")]
		public int getTimeWhenOrangeEval;

		// Token: 0x040042C9 RID: 17097
		[Token(Token = "0x40042C9")]
		[FieldOffset(Offset = "0x48")]
		[Header("触发绿评提高的时限")]
		public int getTimeWhenGreenEval;

		// Token: 0x040042CA RID: 17098
		[Token(Token = "0x40042CA")]
		[FieldOffset(Offset = "0x4C")]
		[Header("触发紫评提高的时限")]
		public int getTimeWhenPurpleEval;

		// Token: 0x040042CB RID: 17099
		[Token(Token = "0x40042CB")]
		[FieldOffset(Offset = "0x50")]
		[Header("触发黑评提高的时限")]
		public int getTimeWhenBlackEval;

		// Token: 0x040042CC RID: 17100
		[Token(Token = "0x40042CC")]
		[FieldOffset(Offset = "0x54")]
		[Header("瑞灵逃跑提高的时限")]
		public int getTimeWhenMizuchiRun;

		// Token: 0x040042CD RID: 17101
		[Token(Token = "0x40042CD")]
		[FieldOffset(Offset = "0x58")]
		[Header("客人耐心耗尽提高的时限")]
		public int getTimeWhenPatienceRunOut;

		// Token: 0x040042CE RID: 17102
		[Token(Token = "0x40042CE")]
		[FieldOffset(Offset = "0x5C")]
		[Header("挑战客人间隔")]
		public Vector2Int guestRefreshTime;

		// Token: 0x040042CF RID: 17103
		[Token(Token = "0x40042CF")]
		[FieldOffset(Offset = "0x64")]
		[Header("禁咒·贪 封印食材时间")]
		public int banTimeForTanBuff;

		// Token: 0x040042D0 RID: 17104
		[Token(Token = "0x40042D0")]
		[FieldOffset(Offset = "0x68")]
		[Header("禁咒·贪 封印食材图标")]
		public GameObject ingredientPrefab;

		// Token: 0x040042D1 RID: 17105
		[Token(Token = "0x40042D1")]
		[FieldOffset(Offset = "0x70")]
		[Header("禁咒·嗔 耐心衰减倍率")]
		public float patienceExtraDecreaseSpeedForChenBuff;

		// Token: 0x040042D2 RID: 17106
		[Token(Token = "0x40042D2")]
		[FieldOffset(Offset = "0x74")]
		[Header("禁咒·痴 触发QTE的间隔")]
		public float qteIntervalForChiBuff;

		// Token: 0x040042D3 RID: 17107
		[Token(Token = "0x40042D3")]
		[FieldOffset(Offset = "0x78")]
		[Header("禁咒·痴 未全中QTE的Debuff持续时间")]
		public int qteFailedDebuffTimeForChiBuff;

		// Token: 0x040042D4 RID: 17108
		[Token(Token = "0x40042D4")]
		[FieldOffset(Offset = "0x7C")]
		[Header("禁咒·痴 未全中QTE的Debuff降低充能速率")]
		public float qteFailedDebuffRateForChiBuff;

		// Token: 0x040042D5 RID: 17109
		[Token(Token = "0x40042D5")]
		[FieldOffset(Offset = "0x80")]
		[Header("瑞灵战的黑雾特效_Lv1")]
		public GameObject fogForMizuchiMap;

		// Token: 0x040042D6 RID: 17110
		[Token(Token = "0x40042D6")]
		[FieldOffset(Offset = "0x88")]
		[Header("瑞灵战的黑雾特效_Lv2")]
		public GameObject fogForMizuchiMap2;

		// Token: 0x040042D7 RID: 17111
		[Token(Token = "0x40042D7")]
		[FieldOffset(Offset = "0x90")]
		[Header("瑞灵战的黑雾特效_Lv3")]
		public GameObject fogForMizuchiMap3;

		// Token: 0x040042D8 RID: 17112
		[Token(Token = "0x40042D8")]
		[FieldOffset(Offset = "0x98")]
		[Header("瑞灵战的黑雾特效_Lv4")]
		public GameObject fogForMizuchiMap4;

		// Token: 0x040042D9 RID: 17113
		[Token(Token = "0x40042D9")]
		[FieldOffset(Offset = "0xA0")]
		[Header("在游戏开始的前X秒不会刷新瑞灵")]
		public int protectTime;

		// Token: 0x040042DA RID: 17114
		[Token(Token = "0x40042DA")]
		[FieldOffset(Offset = "0xA8")]
		[Header("微动之眼特效")]
		public GameObject moonEyeEffect;

		// Token: 0x040042DB RID: 17115
		[Token(Token = "0x40042DB")]
		[FieldOffset(Offset = "0xB0")]
		[Header("微动之眼持续时间")]
		public float moonEyeDuration;

		// Token: 0x040042DC RID: 17116
		[Token(Token = "0x40042DC")]
		[FieldOffset(Offset = "0xB8")]
		[Header("微动之眼控制面板")]
		public DLC5_MoonEyeControllerPanel moonEyeControllerPanel;

		// Token: 0x040042DD RID: 17117
		[Token(Token = "0x40042DD")]
		[FieldOffset(Offset = "0xC0")]
		[Header("微动之眼半径")]
		public float m_MirrorRadius;

		// Token: 0x040042DE RID: 17118
		[Token(Token = "0x40042DE")]
		[FieldOffset(Offset = "0xC4")]
		[Header("微动之眼开启动画时间")]
		public float m_WaitForAnimator;

		// Token: 0x040042DF RID: 17119
		[Token(Token = "0x40042DF")]
		[FieldOffset(Offset = "0xC8")]
		[Header("微动之眼结束动画时间")]
		public float m_WaitForAnimatorEnd;

		// Token: 0x040042E0 RID: 17120
		[Token(Token = "0x40042E0")]
		[FieldOffset(Offset = "0xCC")]
		[Header("微动之眼移动速度")]
		public float m_MoveSpeed;

		// Token: 0x040042E1 RID: 17121
		[Token(Token = "0x40042E1")]
		[FieldOffset(Offset = "0xD0")]
		[Header("微动之眼偏移")]
		public Vector2 m_OffsetOfPlayer;

		// Token: 0x040042E2 RID: 17122
		[Token(Token = "0x40042E2")]
		[FieldOffset(Offset = "0xD8")]
		[Header("微动之眼发现瑞灵的特效")]
		public GameObject m_FindMizuchiVfxL;

		// Token: 0x040042E3 RID: 17123
		[Token(Token = "0x40042E3")]
		[FieldOffset(Offset = "0xE0")]
		[Header("微动之眼发现瑞灵的特效")]
		public GameObject m_FindMizuchiVfxR;

		// Token: 0x040042E4 RID: 17124
		[Token(Token = "0x40042E4")]
		[FieldOffset(Offset = "0xE8")]
		[Header("微动之眼试炼发现特效")]
		public GameObject m_FindVfx;

		// Token: 0x040042E5 RID: 17125
		[Token(Token = "0x40042E5")]
		[FieldOffset(Offset = "0xF0")]
		[Header("结算面板")]
		public DLC5_ChallengeResult m_DLC5_ChallengeResult;

		// Token: 0x040042E6 RID: 17126
		[Token(Token = "0x40042E6")]
		[FieldOffset(Offset = "0xF8")]
		[Header("微动之眼充能时间-初始")]
		public int m_StartMirrorDuration;

		// Token: 0x040042E7 RID: 17127
		[Token(Token = "0x40042E7")]
		[FieldOffset(Offset = "0xFC")]
		[Header("微动之眼充能时间-第一次后")]
		public int m_FirstAddMirrorDuration;

		// Token: 0x040042E8 RID: 17128
		[Token(Token = "0x40042E8")]
		[FieldOffset(Offset = "0x100")]
		[Header("微动之眼充能速率-第一次后")]
		public float m_MirrorExtraRecoverSpeedFirst;

		// Token: 0x040042E9 RID: 17129
		[Token(Token = "0x40042E9")]
		[FieldOffset(Offset = "0x104")]
		[Header("微动之眼充能时间-第二次后")]
		public int m_SecondAddMirrorDuration;

		// Token: 0x040042EA RID: 17130
		[Token(Token = "0x40042EA")]
		[FieldOffset(Offset = "0x108")]
		[Header("微动之眼充能速率-第二次后")]
		public float m_MirrorExtraRecoverSpeedSecond;

		// Token: 0x040042EB RID: 17131
		[Token(Token = "0x40042EB")]
		[FieldOffset(Offset = "0x10C")]
		[Header("微动之眼充能时间-第三次后")]
		public int m_ThirdAddMirrorDuration;

		// Token: 0x040042EC RID: 17132
		[Token(Token = "0x40042EC")]
		[FieldOffset(Offset = "0x110")]
		[Header("微动之眼充能速率-第三次后")]
		public float m_MirrorExtraRecoverSpeedThird;

		// Token: 0x040042ED RID: 17133
		[Token(Token = "0x40042ED")]
		[FieldOffset(Offset = "0x114")]
		[Header("微动之眼充能时间-重复试炼延长")]
		public int m_CirculatedAddMirrorDuration;

		// Token: 0x040042EE RID: 17134
		[Token(Token = "0x40042EE")]
		[FieldOffset(Offset = "0x118")]
		[Header("微动之眼充能速度")]
		public float m_MirrorChargingSpeed;

		// Token: 0x040042EF RID: 17135
		[Token(Token = "0x40042EF")]
		[FieldOffset(Offset = "0x11C")]
		[Header("微动之眼充能额外充能速率")]
		public float m_MirrorExtraRecoverSpeedAfterChallenge;

		// Token: 0x040042F0 RID: 17136
		[Token(Token = "0x40042F0")]
		[FieldOffset(Offset = "0x120")]
		[Header("稀客吃到辣椒粉跑走")]
		public GameObject m_EatPepperVfx;

		// Token: 0x040042F1 RID: 17137
		[Token(Token = "0x40042F1")]
		[FieldOffset(Offset = "0x128")]
		[Header("稀客吃到辣椒粉跑走")]
		public Vector3 m_EatPepperVfxOffset;

		// Token: 0x040042F2 RID: 17138
		[Token(Token = "0x40042F2")]
		[FieldOffset(Offset = "0x138")]
		[Header("稀客吃到辣椒粉冒火")]
		public GameObject m_EatPepperVfx2;

		// Token: 0x040042F3 RID: 17139
		[Token(Token = "0x40042F3")]
		[FieldOffset(Offset = "0x140")]
		[Header("稀客吃到辣椒粉冒火")]
		public Vector3 m_EatPepperVfx2Offset;

		// Token: 0x040042F4 RID: 17140
		[Token(Token = "0x40042F4")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		[Header("[Challenge Finished Event]")]
		private string m_PracticeAChallengeFinishedEvent;

		// Token: 0x040042F5 RID: 17141
		[Token(Token = "0x40042F5")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private string m_PracticeBChallengeFinishedEvent;

		// Token: 0x040042F6 RID: 17142
		[Token(Token = "0x40042F6")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private string m_PracticeCChallengeFinishedEvent;

		// Token: 0x040042F7 RID: 17143
		[Token(Token = "0x40042F7")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private MultiLanguageTextMesh.MultiLanguageTextAsset m_MizuchiExtraTalkingDialog;

		// Token: 0x040042F8 RID: 17144
		[Token(Token = "0x40042F8")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private DLC5_MizuchiChallengeBossData.GuestRunType[] m_GuestActionWhenTheyEatPepper;

		// Token: 0x040042F9 RID: 17145
		[Token(Token = "0x40042F9")]
		[FieldOffset(Offset = "0x178")]
		[Header("Sfx")]
		[SerializeField]
		[Space]
		private AudioClip m_EatPepperSfx;

		// Token: 0x02000C35 RID: 3125
		[Token(Token = "0x2000C35")]
		[Serializable]
		public struct ChallengeData
		{
			// Token: 0x040042FA RID: 17146
			[Token(Token = "0x40042FA")]
			[FieldOffset(Offset = "0x0")]
			public NightSceneDirector.ChallengeType ChallengeType;

			// Token: 0x040042FB RID: 17147
			[Token(Token = "0x40042FB")]
			[FieldOffset(Offset = "0x4")]
			[Header("挑战给的噗噗呦果数量")]
			public int puyoyoFruitGiveNum;

			// Token: 0x040042FC RID: 17148
			[Token(Token = "0x40042FC")]
			[FieldOffset(Offset = "0x8")]
			[Header("挑战需要抓住瑞灵的次数")]
			public int needCatchMizuchiTime;

			// Token: 0x040042FD RID: 17149
			[Token(Token = "0x40042FD")]
			[FieldOffset(Offset = "0xC")]
			[Header("挑战[时限]")]
			public int challengeHp;
		}

		// Token: 0x02000C36 RID: 3126
		[Token(Token = "0x2000C36")]
		[Serializable]
		public struct GuestRunType
		{
			// Token: 0x040042FE RID: 17150
			[Token(Token = "0x40042FE")]
			[FieldOffset(Offset = "0x0")]
			public int id;

			// Token: 0x040042FF RID: 17151
			[Token(Token = "0x40042FF")]
			[FieldOffset(Offset = "0x4")]
			public DLC5_MizuchiChallengeBossData.MouthFireType MouthFireType;

			// Token: 0x04004300 RID: 17152
			[Token(Token = "0x4004300")]
			[FieldOffset(Offset = "0x8")]
			public DLC5_MizuchiChallengeBossData.RunSpeed RunSpeed;

			// Token: 0x04004301 RID: 17153
			[Token(Token = "0x4004301")]
			[FieldOffset(Offset = "0xC")]
			public DLC5_MizuchiChallengeBossData.EyeType EyeType;
		}

		// Token: 0x02000C37 RID: 3127
		[Token(Token = "0x2000C37")]
		public enum MouthFireType
		{
			// Token: 0x04004303 RID: 17155
			[Token(Token = "0x4004303")]
			Fire,
			// Token: 0x04004304 RID: 17156
			[Token(Token = "0x4004304")]
			None
		}

		// Token: 0x02000C38 RID: 3128
		[Token(Token = "0x2000C38")]
		public enum RunSpeed
		{
			// Token: 0x04004306 RID: 17158
			[Token(Token = "0x4004306")]
			Normal,
			// Token: 0x04004307 RID: 17159
			[Token(Token = "0x4004307")]
			Fast,
			// Token: 0x04004308 RID: 17160
			[Token(Token = "0x4004308")]
			VeryFast
		}

		// Token: 0x02000C39 RID: 3129
		[Token(Token = "0x2000C39")]
		public enum EyeType
		{
			// Token: 0x0400430A RID: 17162
			[Token(Token = "0x400430A")]
			Smile,
			// Token: 0x0400430B RID: 17163
			[Token(Token = "0x400430B")]
			Normal,
			// Token: 0x0400430C RID: 17164
			[Token(Token = "0x400430C")]
			Pain,
			// Token: 0x0400430D RID: 17165
			[Token(Token = "0x400430D")]
			Close
		}

		// Token: 0x02000C3A RID: 3130
		[Token(Token = "0x2000C3A")]
		private enum MizuchiControlType
		{
			// Token: 0x0400430F RID: 17167
			[Token(Token = "0x400430F")]
			WrongBeverageTag,
			// Token: 0x04004310 RID: 17168
			[Token(Token = "0x4004310")]
			WrongFoodOrder,
			// Token: 0x04004311 RID: 17169
			[Token(Token = "0x4004311")]
			WrongTalkingDialog,
			// Token: 0x04004312 RID: 17170
			[Token(Token = "0x4004312")]
			None
		}
	}
}

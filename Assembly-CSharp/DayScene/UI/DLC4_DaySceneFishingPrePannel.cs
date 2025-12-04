using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using DayScene.Input;
using DayScene.Interactables.Collections.BehaviourComponents;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection.Async;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DayScene.UI
{
	// Token: 0x020002E5 RID: 741
	[Token(Token = "0x20002E5")]
	[GenerateCleanupMethod]
	public class DLC4_DaySceneFishingPrePannel : AsyncUIPanelParamClose<DLC4_DaySceneFishingPrePannel.ResultContext>
	{
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019A")]
		public FishingBehaviourCompoent.FishReward[] OpenContext
		{
			[Token(Token = "0x60010CF")]
			[Address(RVA = "0x4405A0", Offset = "0x43EFA0", VA = "0x1804405A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60010D0")]
			[Address(RVA = "0x4D25F0", Offset = "0x4D0FF0", VA = "0x1804D25F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019B")]
		public FishingBehaviourCompoent.FishReward[] TreasureContext
		{
			[Token(Token = "0x60010D1")]
			[Address(RVA = "0x48A630", Offset = "0x489030", VA = "0x18048A630")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60010D2")]
			[Address(RVA = "0x4D2650", Offset = "0x4D1050", VA = "0x1804D2650")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010D4 RID: 4308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019C")]
		public Action AnimatorSetToBite
		{
			[Token(Token = "0x60010D3")]
			[Address(RVA = "0x4D1EB0", Offset = "0x4D08B0", VA = "0x1804D1EB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60010D4")]
			[Address(RVA = "0x4D25B0", Offset = "0x4D0FB0", VA = "0x1804D25B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019D")]
		public Action AnimatorSetToUnBite
		{
			[Token(Token = "0x60010D5")]
			[Address(RVA = "0x4D1EE0", Offset = "0x4D08E0", VA = "0x1804D1EE0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60010D6")]
			[Address(RVA = "0x4D2630", Offset = "0x4D1030", VA = "0x1804D2630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010D8 RID: 4312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019E")]
		public Action ResetFocusIndicatorCallback
		{
			[Token(Token = "0x60010D7")]
			[Address(RVA = "0x4D1EA0", Offset = "0x4D08A0", VA = "0x1804D1EA0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60010D8")]
			[Address(RVA = "0x4D2510", Offset = "0x4D0F10", VA = "0x1804D2510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060010DA RID: 4314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700019F")]
		public DayScenePlayerInputGenerator Player
		{
			[Token(Token = "0x60010D9")]
			[Address(RVA = "0x4D1ED0", Offset = "0x4D08D0", VA = "0x1804D1ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60010DA")]
			[Address(RVA = "0x4D2610", Offset = "0x4D1010", VA = "0x1804D2610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x00006990 File Offset: 0x00004B90
		[Token(Token = "0x170001A0")]
		private bool CheckNeedSetFishUnBite
		{
			[Token(Token = "0x60010DB")]
			[Address(RVA = "0x91B520", Offset = "0x919F20", VA = "0x18091B520")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x000069A8 File Offset: 0x00004BA8
		// (set) Token: 0x060010DD RID: 4317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A1")]
		public bool ForceSpawnTreasureInUnityEditor
		{
			[Token(Token = "0x60010DC")]
			[Address(RVA = "0x4E0A50", Offset = "0x4DF450", VA = "0x1804E0A50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60010DD")]
			[Address(RVA = "0x4E0B80", Offset = "0x4DF580", VA = "0x1804E0B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x060010DE RID: 4318 RVA: 0x000069C0 File Offset: 0x00004BC0
		[Token(Token = "0x170001A2")]
		public override AdpUIPanelManager.RequestedInputMode RequestedInputMode
		{
			[Token(Token = "0x60010DE")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "17")]
			get
			{
				return AdpUIPanelManager.RequestedInputMode.Player;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x000069D8 File Offset: 0x00004BD8
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A3")]
		public Product ThisRewardProduct
		{
			[Token(Token = "0x60010DF")]
			[Address(RVA = "0x91B5E0", Offset = "0x919FE0", VA = "0x18091B5E0")]
			[CompilerGenerated]
			get
			{
				return default(Product);
			}
			[Token(Token = "0x60010E0")]
			[Address(RVA = "0x91B600", Offset = "0x91A000", VA = "0x18091B600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x000069F0 File Offset: 0x00004BF0
		[Token(Token = "0x170001A4")]
		public bool HardFishingMode
		{
			[Token(Token = "0x60010E1")]
			[Address(RVA = "0x91B540", Offset = "0x919F40", VA = "0x18091B540")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E2")]
		[Address(RVA = "0x91AB30", Offset = "0x919530", VA = "0x18091AB30", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E3")]
		[Address(RVA = "0x91AD40", Offset = "0x919740", VA = "0x18091AD40")]
		private void OnSubmit(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x00006A08 File Offset: 0x00004C08
		[Token(Token = "0x60010E4")]
		[Address(RVA = "0x91ACA0", Offset = "0x9196A0", VA = "0x18091ACA0", Slot = "33")]
		protected override UniTaskVoid OnPanelOpenAsync()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E5")]
		[Address(RVA = "0x91AD60", Offset = "0x919760", VA = "0x18091AD60")]
		private void TryClosePanel(bool result)
		{
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E6")]
		[Address(RVA = "0x91AA60", Offset = "0x919460", VA = "0x18091AA60", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010E7")]
		[Address(RVA = "0x91B4E0", Offset = "0x919EE0", VA = "0x18091B4E0")]
		public DLC4_DaySceneFishingPrePannel()
		{
		}

		// Token: 0x04000F6D RID: 3949
		[Token(Token = "0x4000F6D")]
		private const string PRD_FISHING_GET_TREASURE = "FishingGetTreasurePRDLabel";

		// Token: 0x04000F6E RID: 3950
		[Token(Token = "0x4000F6E")]
		private const float PRD_FISHING_GET_RATE = 0.33f;

		// Token: 0x04000F6F RID: 3951
		[Token(Token = "0x4000F6F")]
		private const int PRD_FISHING_FIRST_GET_CHANCE = 5;

		// Token: 0x04000F70 RID: 3952
		[Token(Token = "0x4000F70")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Tooltip("高级钓鱼竿ID")]
		private int[] m_hardModeFishingRodIds;

		// Token: 0x04000F71 RID: 3953
		[Token(Token = "0x4000F71")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Tooltip("普通钓鱼等待时间")]
		[Header("简单模式相关")]
		private Vector2 waitTime;

		// Token: 0x04000F72 RID: 3954
		[Token(Token = "0x4000F72")]
		[FieldOffset(Offset = "0xD0")]
		[Tooltip("普通钓鱼脱饵时间")]
		[SerializeField]
		private float missingTime;

		// Token: 0x04000F73 RID: 3955
		[Token(Token = "0x4000F73")]
		[FieldOffset(Offset = "0xD8")]
		[Header("困难模式相关")]
		[SerializeField]
		private DLC4_DaySceneFishingQTEPannel m_HardModeQTEPannel;

		// Token: 0x04000F74 RID: 3956
		[Token(Token = "0x4000F74")]
		[FieldOffset(Offset = "0xE0")]
		private bool isFishBiting;

		// Token: 0x04000F75 RID: 3957
		[Token(Token = "0x4000F75")]
		[FieldOffset(Offset = "0xE1")]
		private bool isTrash;

		// Token: 0x04000F76 RID: 3958
		[Token(Token = "0x4000F76")]
		[FieldOffset(Offset = "0xE4")]
		private DLC4_DaySceneFishingQTEPannel.FishingResult successStatus;

		// Token: 0x020002E6 RID: 742
		[Token(Token = "0x20002E6")]
		public struct ResultContext
		{
			// Token: 0x060010E9 RID: 4329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60010E9")]
			[Address(RVA = "0x92D5B0", Offset = "0x92BFB0", VA = "0x18092D5B0")]
			public ResultContext(Product? rewardProduct, Product? treasureProduct, bool checkNeedSetFishUnBite, Func<Product, Item> checkIfOpenResultPanel)
			{
			}

			// Token: 0x04000F7F RID: 3967
			[Token(Token = "0x4000F7F")]
			[FieldOffset(Offset = "0x0")]
			public Product? RewardProduct;

			// Token: 0x04000F80 RID: 3968
			[Token(Token = "0x4000F80")]
			[FieldOffset(Offset = "0x20")]
			public Product? TreasureProduct;

			// Token: 0x04000F81 RID: 3969
			[Token(Token = "0x4000F81")]
			[FieldOffset(Offset = "0x40")]
			public bool CheckNeedSetFishUnBite;

			// Token: 0x04000F82 RID: 3970
			[Token(Token = "0x4000F82")]
			[FieldOffset(Offset = "0x48")]
			public Func<Product, Item> CheckIfOpenResultPanel;
		}
	}
}

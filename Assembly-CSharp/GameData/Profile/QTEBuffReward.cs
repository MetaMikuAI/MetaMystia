using System;
using DEYU.Utils;
using Il2CppDummyDll;
using NightScene;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.Tiles;
using NightScene.UI;
using UnityEngine;
using UnityEngine.InputSystem;

namespace GameData.Profile
{
	// Token: 0x02000CA2 RID: 3234
	[Token(Token = "0x2000CA2")]
	public abstract class QTEBuffReward : ScriptableObject
	{
		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06004B6D RID: 19309 RVA: 0x0001B390 File Offset: 0x00019590
		[Token(Token = "0x17000AD1")]
		protected bool CanThrowDeliver
		{
			[Token(Token = "0x6004B6D")]
			[Address(RVA = "0x7833B0", Offset = "0x781DB0", VA = "0x1807833B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06004B6E RID: 19310 RVA: 0x0001B3A8 File Offset: 0x000195A8
		[Token(Token = "0x17000AD2")]
		protected bool CanOpenThrowDeliverPanel
		{
			[Token(Token = "0x6004B6E")]
			[Address(RVA = "0x783390", Offset = "0x781D90", VA = "0x180783390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004B6F RID: 19311 RVA: 0x0001B3C0 File Offset: 0x000195C0
		[Token(Token = "0x6004B6F")]
		[Address(RVA = "0x7830A0", Offset = "0x781AA0", VA = "0x1807830A0")]
		protected int ApplyDurationMultiplier(int sourceDuration)
		{
			return 0;
		}

		// Token: 0x06004B70 RID: 19312 RVA: 0x0001B3D8 File Offset: 0x000195D8
		[Token(Token = "0x6004B70")]
		[Address(RVA = "0x7831D0", Offset = "0x781BD0", VA = "0x1807831D0")]
		protected bool CheckPRD()
		{
			return default(bool);
		}

		// Token: 0x06004B71 RID: 19313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B71")]
		[Address(RVA = "0x783350", Offset = "0x781D50", VA = "0x180783350")]
		protected void StopAllCoroutines()
		{
		}

		// Token: 0x06004B72 RID: 19314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B72")]
		[Address(RVA = "0x783320", Offset = "0x781D20", VA = "0x180783320")]
		public void SetContext(QTEBuffReward.QTEManagerContext qTEManagerContext)
		{
		}

		// Token: 0x06004B73 RID: 19315
		[Token(Token = "0x6004B73")]
		public abstract void Initialize(Transform playerCharacter);

		// Token: 0x06004B74 RID: 19316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B74")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "5")]
		public virtual void OnQTESucceeded(int index = -1, bool mustSuccess = false)
		{
		}

		// Token: 0x06004B75 RID: 19317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B75")]
		[Address(RVA = "0x783370", Offset = "0x781D70", VA = "0x180783370", Slot = "6")]
		public virtual void TryExecuteThrowDeliver(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06004B76 RID: 19318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B76")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "7")]
		public virtual void TryExecuteThrowDeliver()
		{
		}

		// Token: 0x06004B77 RID: 19319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B77")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "8")]
		public virtual void OnFocusingDeskChanged(int deskCode)
		{
		}

		// Token: 0x06004B78 RID: 19320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B78")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "9")]
		public virtual void ToggleThrowDeliverIndicator(bool on)
		{
		}

		// Token: 0x06004B79 RID: 19321
		[Token(Token = "0x6004B79")]
		public abstract void ClearAllBuff();

		// Token: 0x06004B7A RID: 19322
		[Token(Token = "0x6004B7A")]
		public abstract string QTEBuffOwnerIdentifier();

		// Token: 0x06004B7B RID: 19323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B7B")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "12")]
		public virtual void Dispose()
		{
		}

		// Token: 0x06004B7C RID: 19324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B7C")]
		[Address(RVA = "0x77C800", Offset = "0x77B200", VA = "0x18077C800")]
		protected QTEBuffReward()
		{
		}

		// Token: 0x0400455E RID: 17758
		[Token(Token = "0x400455E")]
		[FieldOffset(Offset = "0x18")]
		protected int currentTries;

		// Token: 0x0400455F RID: 17759
		[Token(Token = "0x400455F")]
		[FieldOffset(Offset = "0x20")]
		protected QTEBuffReward.QTEManagerContext qTEManagerContext;

		// Token: 0x02000CA3 RID: 3235
		[Token(Token = "0x2000CA3")]
		public readonly struct QTEManagerContext
		{
			// Token: 0x06004B7D RID: 19325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004B7D")]
			[Address(RVA = "0x44F2B0", Offset = "0x44DCB0", VA = "0x18044F2B0")]
			public QTEManagerContext(EventManager eventManagerInstance, UIManager uIManagerInstance, GuestsManager guestsManagerInstance, CookSystemManager cookSystemManagerInstance, PRD pRDInstance, TileManager tileManagerInstance, NightSceneDirector nightSceneDirectorInstance, SceneManager sceneManagerInstance)
			{
			}

			// Token: 0x04004560 RID: 17760
			[Token(Token = "0x4004560")]
			[FieldOffset(Offset = "0x0")]
			public readonly EventManager EventManagerInstance;

			// Token: 0x04004561 RID: 17761
			[Token(Token = "0x4004561")]
			[FieldOffset(Offset = "0x8")]
			public readonly UIManager UIManagerInstance;

			// Token: 0x04004562 RID: 17762
			[Token(Token = "0x4004562")]
			[FieldOffset(Offset = "0x10")]
			public readonly GuestsManager GuestsManagerInstance;

			// Token: 0x04004563 RID: 17763
			[Token(Token = "0x4004563")]
			[FieldOffset(Offset = "0x18")]
			public readonly CookSystemManager CookSystemManagerInstance;

			// Token: 0x04004564 RID: 17764
			[Token(Token = "0x4004564")]
			[FieldOffset(Offset = "0x20")]
			public readonly PRD PRDInstance;

			// Token: 0x04004565 RID: 17765
			[Token(Token = "0x4004565")]
			[FieldOffset(Offset = "0x28")]
			public readonly TileManager TileManagerInstance;

			// Token: 0x04004566 RID: 17766
			[Token(Token = "0x4004566")]
			[FieldOffset(Offset = "0x30")]
			public readonly NightSceneDirector NightSceneDirectorInstance;

			// Token: 0x04004567 RID: 17767
			[Token(Token = "0x4004567")]
			[FieldOffset(Offset = "0x38")]
			public readonly SceneManager SceneManagerInstance;
		}
	}
}

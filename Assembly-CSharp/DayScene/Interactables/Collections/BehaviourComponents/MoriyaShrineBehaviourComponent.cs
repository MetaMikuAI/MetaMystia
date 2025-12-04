using System;
using System.Collections.Generic;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine.Playables;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200050D RID: 1293
	[Token(Token = "0x200050D")]
	[GenerateCleanupMethod]
	public class MoriyaShrineBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001CF1 RID: 7409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF1")]
		[Address(RVA = "0x4B1CC0", Offset = "0x4B06C0", VA = "0x1804B1CC0", Slot = "12")]
		protected override void OnInitialize()
		{
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF2")]
		[Address(RVA = "0x4B1E30", Offset = "0x4B0830", VA = "0x1804B1E30", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF3")]
		[Address(RVA = "0x4B16A0", Offset = "0x4B00A0", VA = "0x1804B16A0")]
		private void InitializeRewardActions()
		{
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF4")]
		[Address(RVA = "0x4B1A10", Offset = "0x4B0410", VA = "0x1804B1A10")]
		private void Lottery()
		{
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF5")]
		private void PlayDialog<T>(T[] dialogs, Action action) where T : DialogPackage
		{
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF6")]
		[Address(RVA = "0x4B15F0", Offset = "0x4AFFF0", VA = "0x1804B15F0", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF7")]
		[Address(RVA = "0x4B20A0", Offset = "0x4B0AA0", VA = "0x1804B20A0")]
		public MoriyaShrineBehaviourComponent()
		{
		}

		// Token: 0x04001AAD RID: 6829
		[Token(Token = "0x4001AAD")]
		private const int SILVER_COIN_ID = 29;

		// Token: 0x04001AAE RID: 6830
		[Token(Token = "0x4001AAE")]
		private const int GOLD_COIN_ID = 30;

		// Token: 0x04001AAF RID: 6831
		[Token(Token = "0x4001AAF")]
		private const int JK_CLOTHES = 31;

		// Token: 0x04001AB0 RID: 6832
		[Token(Token = "0x4001AB0")]
		private const int WIND_BEVERAGE_ID = 18;

		// Token: 0x04001AB1 RID: 6833
		[Token(Token = "0x4001AB1")]
		private const int CONDITION_FULFILLED_COUNT = 100;

		// Token: 0x04001AB2 RID: 6834
		[Token(Token = "0x4001AB2")]
		private const int ACTION_CONSUMPTION = 1;

		// Token: 0x04001AB3 RID: 6835
		[Token(Token = "0x4001AB3")]
		private const string COMPONENT_ID = "MoriyaShrine";

		// Token: 0x04001AB4 RID: 6836
		[Token(Token = "0x4001AB4")]
		[FieldOffset(Offset = "0x18")]
		public int interactCount;

		// Token: 0x04001AB5 RID: 6837
		[Token(Token = "0x4001AB5")]
		[FieldOffset(Offset = "0x20")]
		public DialogPackage[] beginDialogs;

		// Token: 0x04001AB6 RID: 6838
		[Token(Token = "0x4001AB6")]
		[FieldOffset(Offset = "0x28")]
		public DialogPackage[] runOutOfLotteryDialogs;

		// Token: 0x04001AB7 RID: 6839
		[Token(Token = "0x4001AB7")]
		[FieldOffset(Offset = "0x30")]
		public DialogPackage[] noRewardDialogs;

		// Token: 0x04001AB8 RID: 6840
		[Token(Token = "0x4001AB8")]
		[FieldOffset(Offset = "0x38")]
		public PlayableAsset conditionFulfilledTimeline;

		// Token: 0x04001AB9 RID: 6841
		[Token(Token = "0x4001AB9")]
		[FieldOffset(Offset = "0x40")]
		public MoriyaShrineRewardPair[] Rewards;

		// Token: 0x04001ABA RID: 6842
		[Token(Token = "0x4001ABA")]
		[FieldOffset(Offset = "0x48")]
		private readonly Dictionary<MoriyaShrineRewardType, Action> rewardActions;

		// Token: 0x04001ABB RID: 6843
		[Token(Token = "0x4001ABB")]
		[FieldOffset(Offset = "0x50")]
		private int[] itemsPercentage;
	}
}

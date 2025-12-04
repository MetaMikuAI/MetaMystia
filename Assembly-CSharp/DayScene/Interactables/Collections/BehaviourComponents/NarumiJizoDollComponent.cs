using System;
using DayScene.Interactables.Collections.ConditionExtensions;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200051A RID: 1306
	[Token(Token = "0x200051A")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(StatusTrackerConditionExtension))]
	public class NarumiJizoDollComponent : EntityBehaviourComponent
	{
		// Token: 0x06001D3D RID: 7485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3D")]
		[Address(RVA = "0x4B3620", Offset = "0x4B2020", VA = "0x1804B3620", Slot = "12")]
		protected override void OnInitialize()
		{
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3E")]
		[Address(RVA = "0x4B33D0", Offset = "0x4B1DD0", VA = "0x1804B33D0")]
		private void GiveItem()
		{
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3F")]
		[Address(RVA = "0x4B2E00", Offset = "0x4B1800", VA = "0x1804B2E00")]
		private void CalculateItemsPercentage()
		{
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x0000AF20 File Offset: 0x00009120
		[Token(Token = "0x6001D40")]
		[Address(RVA = "0x4B32F0", Offset = "0x4B1CF0", VA = "0x1804B32F0")]
		private NarumiJizoDollRewardPair GetReward(int[] targetPercentage, NarumiJizoDollRewardPair[] targetRewardArray)
		{
			return default(NarumiJizoDollRewardPair);
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x0000AF38 File Offset: 0x00009138
		[Token(Token = "0x6001D41")]
		[Address(RVA = "0x4B3760", Offset = "0x4B2160", VA = "0x1804B3760")]
		private int SelectReward(NarumiJizoDollRewardPair rewardPair)
		{
			return 0;
		}

		// Token: 0x06001D42 RID: 7490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D42")]
		[Address(RVA = "0x4B3680", Offset = "0x4B2080", VA = "0x1804B3680", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D43")]
		private void PlayDialog<T>(T[] dialogs, Action action) where T : DialogPackage
		{
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D44")]
		[Address(RVA = "0x4B3240", Offset = "0x4B1C40", VA = "0x1804B3240", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D45")]
		[Address(RVA = "0x4B3F90", Offset = "0x4B2990", VA = "0x1804B3F90")]
		public NarumiJizoDollComponent()
		{
		}

		// Token: 0x04001AE1 RID: 6881
		[Token(Token = "0x4001AE1")]
		[FieldOffset(Offset = "0x18")]
		public DialogPackage[] EndDialog;

		// Token: 0x04001AE2 RID: 6882
		[Token(Token = "0x4001AE2")]
		[FieldOffset(Offset = "0x20")]
		public DialogPackage[] runOutOfLotteryDialogs;

		// Token: 0x04001AE3 RID: 6883
		[Token(Token = "0x4001AE3")]
		[FieldOffset(Offset = "0x28")]
		public DialogPackage[] openDialog;

		// Token: 0x04001AE4 RID: 6884
		[Token(Token = "0x4001AE4")]
		[FieldOffset(Offset = "0x30")]
		public DialogPackage[] rewardDialog;

		// Token: 0x04001AE5 RID: 6885
		[Token(Token = "0x4001AE5")]
		[FieldOffset(Offset = "0x38")]
		public int ingredientNum;

		// Token: 0x04001AE6 RID: 6886
		[Token(Token = "0x4001AE6")]
		[FieldOffset(Offset = "0x3C")]
		public int bevNum;

		// Token: 0x04001AE7 RID: 6887
		[Token(Token = "0x4001AE7")]
		[FieldOffset(Offset = "0x40")]
		public NarumiJizoDollRewardPair[] reward;

		// Token: 0x04001AE8 RID: 6888
		[Token(Token = "0x4001AE8")]
		[FieldOffset(Offset = "0x48")]
		public int interactCount;

		// Token: 0x04001AE9 RID: 6889
		[Token(Token = "0x4001AE9")]
		[FieldOffset(Offset = "0x50")]
		private int[] bevPercentage;

		// Token: 0x04001AEA RID: 6890
		[Token(Token = "0x4001AEA")]
		[FieldOffset(Offset = "0x58")]
		private NarumiJizoDollRewardPair[] bevReward;

		// Token: 0x04001AEB RID: 6891
		[Token(Token = "0x4001AEB")]
		[FieldOffset(Offset = "0x60")]
		private int[] ingredientPercentage;

		// Token: 0x04001AEC RID: 6892
		[Token(Token = "0x4001AEC")]
		[FieldOffset(Offset = "0x68")]
		private NarumiJizoDollRewardPair[] ingredientReward;

		// Token: 0x04001AED RID: 6893
		[Token(Token = "0x4001AED")]
		[FieldOffset(Offset = "0x70")]
		private string moduleID;
	}
}

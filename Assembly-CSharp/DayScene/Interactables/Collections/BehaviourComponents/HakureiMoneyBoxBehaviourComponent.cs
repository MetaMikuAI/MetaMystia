using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine.Playables;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004FD RID: 1277
	[Token(Token = "0x20004FD")]
	[GenerateCleanupMethod]
	public class HakureiMoneyBoxBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001CA5 RID: 7333 RVA: 0x0000AE00 File Offset: 0x00009000
		[Token(Token = "0x170003DC")]
		private bool IfReimuStay
		{
			[Token(Token = "0x6001CA5")]
			[Address(RVA = "0x4AF460", Offset = "0x4ADE60", VA = "0x1804AF460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x4AE9E0", Offset = "0x4AD3E0", VA = "0x1804AE9E0")]
		public DialogPackage GetDialog()
		{
			return null;
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x4AEEB0", Offset = "0x4AD8B0", VA = "0x1804AEEB0", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0x4AEE50", Offset = "0x4AD850", VA = "0x1804AEE50", Slot = "12")]
		protected override void OnInitialize()
		{
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA9")]
		[Address(RVA = "0x4AEC60", Offset = "0x4AD660", VA = "0x1804AEC60")]
		private void InitButtonInternal(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, string titleKey, int targetAmount, DialogPackage[] dialogPackageCollection, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0x4AEA40", Offset = "0x4AD440", VA = "0x1804AEA40")]
		private void InitButtonFinal(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, string titleKey, int targetAmount, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAB")]
		[Address(RVA = "0x4AF050", Offset = "0x4ADA50", VA = "0x1804AF050")]
		private void OneHundredButtonConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAC")]
		[Address(RVA = "0x4AE940", Offset = "0x4AD340", VA = "0x1804AE940")]
		private void FiveHundredButtonConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAD")]
		[Address(RVA = "0x4AEFB0", Offset = "0x4AD9B0", VA = "0x1804AEFB0")]
		private void OneHousandButtonConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAE")]
		[Address(RVA = "0x4AE8B0", Offset = "0x4AD2B0", VA = "0x1804AE8B0")]
		private void FinalButtonConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CAF")]
		[Address(RVA = "0x4AE720", Offset = "0x4AD120", VA = "0x1804AE720")]
		private void EndButtonAction(Action closePannelCallback)
		{
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB0")]
		[Address(RVA = "0x4AE0B0", Offset = "0x4ACAB0", VA = "0x1804AE0B0")]
		private void DonateBecomeBuff(int donateMoney)
		{
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB1")]
		[Address(RVA = "0x4ADF40", Offset = "0x4AC940", VA = "0x1804ADF40")]
		private void AddKizuna(int amount)
		{
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB2")]
		[Address(RVA = "0x4AE000", Offset = "0x4ACA00", VA = "0x1804AE000", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB3")]
		[Address(RVA = "0x4AF400", Offset = "0x4ADE00", VA = "0x1804AF400")]
		public HakureiMoneyBoxBehaviourComponent()
		{
		}

		// Token: 0x04001A5E RID: 6750
		[Token(Token = "0x4001A5E")]
		private const int maxDonateNumPerDay = 1;

		// Token: 0x04001A5F RID: 6751
		[Token(Token = "0x4001A5F")]
		private const string REIMU_STRINGID = "Reimu";

		// Token: 0x04001A60 RID: 6752
		[Token(Token = "0x4001A60")]
		[FieldOffset(Offset = "0x18")]
		public DialogPackage[] openDialog;

		// Token: 0x04001A61 RID: 6753
		[Token(Token = "0x4001A61")]
		[FieldOffset(Offset = "0x20")]
		public DialogPackage[] specialDialogWhenReimuDisappear;

		// Token: 0x04001A62 RID: 6754
		[Token(Token = "0x4001A62")]
		[FieldOffset(Offset = "0x28")]
		public float reimuDisappearDistance;

		// Token: 0x04001A63 RID: 6755
		[Token(Token = "0x4001A63")]
		[FieldOffset(Offset = "0x30")]
		public DialogPackage[] oneHundredDialog;

		// Token: 0x04001A64 RID: 6756
		[Token(Token = "0x4001A64")]
		[FieldOffset(Offset = "0x38")]
		public DialogPackage[] fiveHundredDialog;

		// Token: 0x04001A65 RID: 6757
		[Token(Token = "0x4001A65")]
		[FieldOffset(Offset = "0x40")]
		public DialogPackage[] oneThousandDialog;

		// Token: 0x04001A66 RID: 6758
		[Token(Token = "0x4001A66")]
		[FieldOffset(Offset = "0x48")]
		public DialogPackage[] EndDialog;

		// Token: 0x04001A67 RID: 6759
		[Token(Token = "0x4001A67")]
		[FieldOffset(Offset = "0x50")]
		public PlayableAsset conditionFulfilledTimeline;

		// Token: 0x04001A68 RID: 6760
		[Token(Token = "0x4001A68")]
		[FieldOffset(Offset = "0x58")]
		public string yukariFinalEvent;

		// Token: 0x04001A69 RID: 6761
		[Token(Token = "0x4001A69")]
		[FieldOffset(Offset = "0x60")]
		public string oldSavementEvent;

		// Token: 0x04001A6A RID: 6762
		[Token(Token = "0x4001A6A")]
		[FieldOffset(Offset = "0x68")]
		public int finalDonateNum;

		// Token: 0x04001A6B RID: 6763
		[Token(Token = "0x4001A6B")]
		[FieldOffset(Offset = "0x70")]
		private string m_ModuleID;
	}
}

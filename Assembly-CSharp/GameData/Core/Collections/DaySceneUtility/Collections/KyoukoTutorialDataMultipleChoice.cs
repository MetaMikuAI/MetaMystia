using System;
using DayScene.UI;
using Il2CppDummyDll;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B1E RID: 2846
	[Token(Token = "0x2000B1E")]
	[Serializable]
	public abstract class KyoukoTutorialDataMultipleChoice : KyoukoTutorialData
	{
		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x0600446A RID: 17514
		[Token(Token = "0x170009BF")]
		protected abstract KyoukoTutorialData[] ChildKyoukoTutorialData
		{
			[Token(Token = "0x600446A")]
			get;
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x0600446B RID: 17515 RVA: 0x00018C30 File Offset: 0x00016E30
		[Token(Token = "0x170009C0")]
		public override bool HaveFinishedTutorial
		{
			[Token(Token = "0x600446B")]
			[Address(RVA = "0x71BC00", Offset = "0x71A600", VA = "0x18071BC00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x0600446C RID: 17516 RVA: 0x00018C48 File Offset: 0x00016E48
		[Token(Token = "0x170009C1")]
		public override bool NeedToShow
		{
			[Token(Token = "0x600446C")]
			[Address(RVA = "0x71BD40", Offset = "0x71A740", VA = "0x18071BD40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x00018C60 File Offset: 0x00016E60
		[Token(Token = "0x600446D")]
		[Address(RVA = "0x4A6560", Offset = "0x4A4F60", VA = "0x1804A6560", Slot = "11")]
		protected virtual bool ChildSelectionExtraCheck(bool baseAvailability)
		{
			return default(bool);
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600446E")]
		[Address(RVA = "0x71B8F0", Offset = "0x71A2F0", VA = "0x18071B8F0")]
		protected void OpenChildData(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
		}

		// Token: 0x0600446F RID: 17519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600446F")]
		[Address(RVA = "0x71B8E0", Offset = "0x71A2E0", VA = "0x18071B8E0", Slot = "9")]
		protected override void OnButtonInteractDialogPackageClose(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004470")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		protected KyoukoTutorialDataMultipleChoice()
		{
		}
	}
}

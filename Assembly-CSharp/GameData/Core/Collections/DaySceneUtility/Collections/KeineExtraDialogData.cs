using System;
using DayScene.UI;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Playables;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B10 RID: 2832
	[Token(Token = "0x2000B10")]
	[CreateAssetMenu(fileName = "KeineExtraDialogData", menuName = "GameData Profile/Extra Dialog Data/Keine", order = 4)]
	public class KeineExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x0600442E RID: 17454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600442E")]
		[Address(RVA = "0x71AF20", Offset = "0x719920", VA = "0x18071AF20", Slot = "5")]
		public override void GetSpecialGuestExtraDialogData(out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelection, out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections)
		{
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600442F")]
		[Address(RVA = "0x71B030", Offset = "0x719A30", VA = "0x18071B030")]
		private void ReturnToMemory(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004430")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public KeineExtraDialogData()
		{
		}

		// Token: 0x04003C47 RID: 15431
		[Token(Token = "0x4003C47")]
		private const string PHRASE_KEY = "KEINE_AFTER_STORY";

		// Token: 0x04003C48 RID: 15432
		[Token(Token = "0x4003C48")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_PreEvent;

		// Token: 0x04003C49 RID: 15433
		[Token(Token = "0x4003C49")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PlayableAsset m_StartTimeline;

		// Token: 0x04003C4A RID: 15434
		[Token(Token = "0x4003C4A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AssetReference m_MemoryTimeline;

		// Token: 0x04003C4B RID: 15435
		[Token(Token = "0x4003C4B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_FinishEvent;

		// Token: 0x04003C4C RID: 15436
		[Token(Token = "0x4003C4C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string m_AchievementEvent;
	}
}

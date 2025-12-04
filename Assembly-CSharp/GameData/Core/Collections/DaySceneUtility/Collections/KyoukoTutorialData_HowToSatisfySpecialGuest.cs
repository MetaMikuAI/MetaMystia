using System;
using DayScene.UI;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B25 RID: 2853
	[Token(Token = "0x2000B25")]
	[Serializable]
	public class KyoukoTutorialData_HowToSatisfySpecialGuest : KyoukoTutorialDataContainsTimeline
	{
		// Token: 0x0600447F RID: 17535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600447F")]
		[Address(RVA = "0x71CF10", Offset = "0x71B910", VA = "0x18071CF10", Slot = "9")]
		protected override void OnButtonInteractDialogPackageClose(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004480")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public KyoukoTutorialData_HowToSatisfySpecialGuest()
		{
		}

		// Token: 0x04003C91 RID: 15505
		[Token(Token = "0x4003C91")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AssetReference backToDayTimelineAsset;
	}
}

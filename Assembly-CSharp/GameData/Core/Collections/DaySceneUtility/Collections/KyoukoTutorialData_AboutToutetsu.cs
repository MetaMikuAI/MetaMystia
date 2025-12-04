using System;
using Cysharp.Threading.Tasks;
using DayScene.UI;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B2C RID: 2860
	[Token(Token = "0x2000B2C")]
	[Serializable]
	public class KyoukoTutorialData_AboutToutetsu : KyoukoTutorialData
	{
		// Token: 0x06004492 RID: 17554 RVA: 0x00018CD8 File Offset: 0x00016ED8
		[Token(Token = "0x6004492")]
		[Address(RVA = "0x71C0C0", Offset = "0x71AAC0", VA = "0x18071C0C0")]
		private UniTask OnButtonInteractAsync(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			return default(UniTask);
		}

		// Token: 0x06004493 RID: 17555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004493")]
		[Address(RVA = "0x71C1A0", Offset = "0x71ABA0", VA = "0x18071C1A0", Slot = "9")]
		protected override void OnButtonInteractDialogPackageClose(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
		}

		// Token: 0x06004494 RID: 17556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004494")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public KyoukoTutorialData_AboutToutetsu()
		{
		}

		// Token: 0x04003CA5 RID: 15525
		[Token(Token = "0x4003CA5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AssetReference yuumaTutorial;
	}
}

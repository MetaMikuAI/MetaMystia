using System;
using Cysharp.Threading.Tasks;
using DayScene.UI;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B29 RID: 2857
	[Token(Token = "0x2000B29")]
	[Serializable]
	public class KyoukoTutorialData_WhatIsQTE : KyoukoTutorialData
	{
		// Token: 0x0600448B RID: 17547 RVA: 0x00018CC0 File Offset: 0x00016EC0
		[Token(Token = "0x600448B")]
		[Address(RVA = "0x71D730", Offset = "0x71C130", VA = "0x18071D730")]
		private UniTask OnButtonInteractAsync(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			return default(UniTask);
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600448C")]
		[Address(RVA = "0x71D810", Offset = "0x71C210", VA = "0x18071D810", Slot = "9")]
		protected override void OnButtonInteractDialogPackageClose(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
		}

		// Token: 0x0600448D RID: 17549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600448D")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public KyoukoTutorialData_WhatIsQTE()
		{
		}

		// Token: 0x04003C9B RID: 15515
		[Token(Token = "0x4003C9B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AssetReference qteTutorial;
	}
}

using System;
using Cysharp.Threading.Tasks;
using DayScene.UI;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B1C RID: 2844
	[Token(Token = "0x2000B1C")]
	[Serializable]
	public class KyoukoTutorialDataWithPrefab : KyoukoTutorialData
	{
		// Token: 0x06004465 RID: 17509 RVA: 0x00018C18 File Offset: 0x00016E18
		[Token(Token = "0x6004465")]
		[Address(RVA = "0x71BE80", Offset = "0x71A880", VA = "0x18071BE80")]
		private UniTask OnButtonInteractAsync(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			return default(UniTask);
		}

		// Token: 0x06004466 RID: 17510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004466")]
		[Address(RVA = "0x71BF70", Offset = "0x71A970", VA = "0x18071BF70", Slot = "8")]
		protected override void OnButtonInteract(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
		}

		// Token: 0x06004467 RID: 17511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004467")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public KyoukoTutorialDataWithPrefab()
		{
		}

		// Token: 0x04003C7A RID: 15482
		[Token(Token = "0x4003C7A")]
		private const string TUTORIAL_LABEL = "Tutorial";

		// Token: 0x04003C7B RID: 15483
		[Token(Token = "0x4003C7B")]
		[FieldOffset(Offset = "0x70")]
		[NotNull]
		public AssetReference dialogPrefab;
	}
}

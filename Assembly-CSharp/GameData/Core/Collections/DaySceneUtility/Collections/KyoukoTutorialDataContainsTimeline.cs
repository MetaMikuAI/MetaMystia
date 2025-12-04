using System;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine.AddressableAssets;
using UnityEngine.Playables;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B1B RID: 2843
	[Token(Token = "0x2000B1B")]
	[Serializable]
	public class KyoukoTutorialDataContainsTimeline : KyoukoTutorialData
	{
		// Token: 0x06004464 RID: 17508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004464")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public KyoukoTutorialDataContainsTimeline()
		{
		}

		// Token: 0x04003C78 RID: 15480
		[Token(Token = "0x4003C78")]
		[FieldOffset(Offset = "0x70")]
		[NotNull]
		public PlayableAsset tutorialTimeline;

		// Token: 0x04003C79 RID: 15481
		[Token(Token = "0x4003C79")]
		[FieldOffset(Offset = "0x78")]
		[NotNull]
		public AssetReference tutorialTimelineAsset;
	}
}

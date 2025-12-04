using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Profile
{
	// Token: 0x02000B80 RID: 2944
	[Token(Token = "0x2000B80")]
	[CreateAssetMenu(fileName = "DaySceneMapProfile", menuName = "GameData Profile/CreateDaySceneMapProfile", order = 3)]
	public class DaySceneMapProfile : ScriptableObject
	{
		// Token: 0x06004634 RID: 17972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004634")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DaySceneMapProfile()
		{
		}

		// Token: 0x04003E1B RID: 15899
		[Token(Token = "0x4003E1B")]
		[FieldOffset(Offset = "0x18")]
		public DaySceneMapProfile.MapNode[] allMapNodes;

		// Token: 0x02000B81 RID: 2945
		[Token(Token = "0x2000B81")]
		[Serializable]
		public struct MapNode
		{
			// Token: 0x04003E1C RID: 15900
			[Token(Token = "0x4003E1C")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string mapName;

			// Token: 0x04003E1D RID: 15901
			[Token(Token = "0x4003E1D")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public string parent;

			// Token: 0x04003E1E RID: 15902
			[Token(Token = "0x4003E1E")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public AssetReference mapAssetReference;

			// Token: 0x04003E1F RID: 15903
			[Token(Token = "0x4003E1F")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public string[] mapCollectableLabels;

			// Token: 0x04003E20 RID: 15904
			[Token(Token = "0x4003E20")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			public string[] mapSpawnMarkerLabels;

			// Token: 0x04003E21 RID: 15905
			[Token(Token = "0x4003E21")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			public int[] level1IzakayaId;

			// Token: 0x04003E22 RID: 15906
			[Token(Token = "0x4003E22")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			public int[] level2IzakayaId;

			// Token: 0x04003E23 RID: 15907
			[Token(Token = "0x4003E23")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			public int[] level3IzakayaId;
		}
	}
}

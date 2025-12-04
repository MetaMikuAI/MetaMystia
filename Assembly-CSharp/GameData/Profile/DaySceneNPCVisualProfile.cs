using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B82 RID: 2946
	[Token(Token = "0x2000B82")]
	[CreateAssetMenu(fileName = "DaySceneNPCVisualProfile", menuName = "GameData Profile/DaySceneNPCVisualProfile", order = 3)]
	public class DaySceneNPCVisualProfile : ScriptableObject
	{
		// Token: 0x06004635 RID: 17973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004635")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DaySceneNPCVisualProfile()
		{
		}

		// Token: 0x04003E24 RID: 15908
		[Token(Token = "0x4003E24")]
		[FieldOffset(Offset = "0x18")]
		public DaySceneNPCVisualProfile.IDVisualPair[] allVisuals;

		// Token: 0x02000B83 RID: 2947
		[Token(Token = "0x2000B83")]
		[Serializable]
		public struct IDVisualPair
		{
			// Token: 0x04003E25 RID: 15909
			[Token(Token = "0x4003E25")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public int characterID;

			// Token: 0x04003E26 RID: 15910
			[Token(Token = "0x4003E26")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public CharacterSpriteSetCompact visual;
		}
	}
}

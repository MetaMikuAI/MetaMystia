using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BA5 RID: 2981
	[Token(Token = "0x2000BA5")]
	[CreateAssetMenu(fileName = "LevelProfile", menuName = "GameData Profile/CreateLevelProfile", order = 3)]
	public class LevelProfile : ScriptableObject
	{
		// Token: 0x0600468E RID: 18062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600468E")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public LevelProfile()
		{
		}

		// Token: 0x04003F10 RID: 16144
		[Token(Token = "0x4003F10")]
		[FieldOffset(Offset = "0x18")]
		public LevelProfile.LevelPropertiesPair[] profiles;

		// Token: 0x04003F11 RID: 16145
		[Token(Token = "0x4003F11")]
		[FieldOffset(Offset = "0x20")]
		public TextAsset tsvBackup;

		// Token: 0x02000BA6 RID: 2982
		[Token(Token = "0x2000BA6")]
		[Serializable]
		public class LevelPropertiesPair
		{
			// Token: 0x0600468F RID: 18063 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600468F")]
			[Address(RVA = "0x73F230", Offset = "0x73DC30", VA = "0x18073F230")]
			public LevelPropertiesPair(int level, DataBaseCore.LevelProperties properties)
			{
			}

			// Token: 0x04003F12 RID: 16146
			[Token(Token = "0x4003F12")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public int level;

			// Token: 0x04003F13 RID: 16147
			[Token(Token = "0x4003F13")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public DataBaseCore.LevelProperties properties;
		}
	}
}

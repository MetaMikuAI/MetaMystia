using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BAB RID: 2987
	[Token(Token = "0x2000BAB")]
	[CreateAssetMenu(fileName = "DaySceneMusicGameMappingProfile", menuName = "GameData Profile/CreateDaySceneMusicGameMappingProfile", order = 2500)]
	public class MusicGameMappingProfile : ScriptableObject
	{
		// Token: 0x060046A3 RID: 18083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A3")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public MusicGameMappingProfile()
		{
		}

		// Token: 0x04003F25 RID: 16165
		[Token(Token = "0x4003F25")]
		[FieldOffset(Offset = "0x18")]
		public MusicGameMappingProfile.MusicMapping[] musicMappings;

		// Token: 0x02000BAC RID: 2988
		[Token(Token = "0x2000BAC")]
		[Serializable]
		public struct MusicMapping
		{
			// Token: 0x04003F26 RID: 16166
			[Token(Token = "0x4003F26")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string mapLabel;

			// Token: 0x04003F27 RID: 16167
			[Token(Token = "0x4003F27")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public string alternativeMapName;

			// Token: 0x04003F28 RID: 16168
			[Token(Token = "0x4003F28")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string DLCMapping;

			// Token: 0x04003F29 RID: 16169
			[Token(Token = "0x4003F29")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public string[] musicChapters;

			// Token: 0x04003F2A RID: 16170
			[Token(Token = "0x4003F2A")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			public string[] unlockedMapLabelAfterFinish;

			// Token: 0x04003F2B RID: 16171
			[Token(Token = "0x4003F2B")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			public int easyBadgeId;

			// Token: 0x04003F2C RID: 16172
			[Token(Token = "0x4003F2C")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			public int hardBadgeId;
		}
	}
}

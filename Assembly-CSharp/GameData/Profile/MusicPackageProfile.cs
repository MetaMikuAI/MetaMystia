using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BAD RID: 2989
	[Token(Token = "0x2000BAD")]
	[CreateAssetMenu(fileName = "MusicPackageProfile", menuName = "GameData Profile/CreateMusicPackageProfile", order = 3)]
	public class MusicPackageProfile : ScriptableObject
	{
		// Token: 0x060046A4 RID: 18084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A4")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public MusicPackageProfile()
		{
		}

		// Token: 0x04003F2D RID: 16173
		[Token(Token = "0x4003F2D")]
		[FieldOffset(Offset = "0x18")]
		public TextAsset switchEntry;

		// Token: 0x04003F2E RID: 16174
		[Token(Token = "0x4003F2E")]
		[FieldOffset(Offset = "0x20")]
		public MusicPackageProfile.MusicChannel musicChannel_1;

		// Token: 0x04003F2F RID: 16175
		[Token(Token = "0x4003F2F")]
		[FieldOffset(Offset = "0x28")]
		public MusicPackageProfile.MusicChannel musicChannel_2;

		// Token: 0x04003F30 RID: 16176
		[Token(Token = "0x4003F30")]
		[FieldOffset(Offset = "0x30")]
		public MusicPackageProfile.MusicChannel musicChannel_3;

		// Token: 0x02000BAE RID: 2990
		[Token(Token = "0x2000BAE")]
		[Serializable]
		public class MusicChannel
		{
			// Token: 0x060046A5 RID: 18085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60046A5")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public MusicChannel()
			{
			}

			// Token: 0x04003F31 RID: 16177
			[Token(Token = "0x4003F31")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public LoopedBGMPackage musicData;

			// Token: 0x04003F32 RID: 16178
			[Token(Token = "0x4003F32")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public TextAsset midiData;
		}
	}
}

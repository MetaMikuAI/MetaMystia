using System;
using GameData.Core.MusicUtility;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B9F RID: 2975
	[Token(Token = "0x2000B9F")]
	[CreateAssetMenu(fileName = "IzakayaMusicProfile", menuName = "GameData Profile/Dialog/IzakayaMusicProfile", order = 3)]
	public class IzakayaMusicProfile : ScriptableObject
	{
		// Token: 0x06004688 RID: 18056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004688")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public IzakayaMusicProfile()
		{
		}

		// Token: 0x04003EFF RID: 16127
		[Token(Token = "0x4003EFF")]
		[FieldOffset(Offset = "0x18")]
		public long[] switchEntry;

		// Token: 0x04003F00 RID: 16128
		[Token(Token = "0x4003F00")]
		[FieldOffset(Offset = "0x20")]
		public IzakayaMusic.MusicChannelPackage passionP1;

		// Token: 0x04003F01 RID: 16129
		[Token(Token = "0x4003F01")]
		[FieldOffset(Offset = "0x30")]
		public IzakayaMusic.MusicChannelPackage passionP2;

		// Token: 0x04003F02 RID: 16130
		[Token(Token = "0x4003F02")]
		[FieldOffset(Offset = "0x40")]
		public IzakayaMusic.MusicChannelPackage passionP3;
	}
}

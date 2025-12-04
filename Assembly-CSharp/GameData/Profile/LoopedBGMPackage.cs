using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BA7 RID: 2983
	[Token(Token = "0x2000BA7")]
	[CreateAssetMenu(fileName = "LoopedBGMPackage", menuName = "GameData Profile/LoopedBGMPackage", order = 3)]
	public class LoopedBGMPackage : ScriptableObject
	{
		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06004690 RID: 18064 RVA: 0x00019638 File Offset: 0x00017838
		[Token(Token = "0x17000A48")]
		public bool Valid
		{
			[Token(Token = "0x6004690")]
			[Address(RVA = "0x73F2D0", Offset = "0x73DCD0", VA = "0x18073F2D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004691")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public LoopedBGMPackage()
		{
		}

		// Token: 0x04003F14 RID: 16148
		[Token(Token = "0x4003F14")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip intro;

		// Token: 0x04003F15 RID: 16149
		[Token(Token = "0x4003F15")]
		[FieldOffset(Offset = "0x20")]
		public AudioClip loop;
	}
}

using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BB6 RID: 2998
	[Token(Token = "0x2000BB6")]
	[Serializable]
	public class GuestProfilePair
	{
		// Token: 0x060046B2 RID: 18098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B2")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		private GuestProfilePair()
		{
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B3")]
		[Address(RVA = "0x73EF30", Offset = "0x73D930", VA = "0x18073EF30")]
		public GuestProfilePair(int id, Color bgColor, Color textColor, CharacterProtrayalSet characterPortrayal, CharacterSkinSets characterPixel)
		{
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x000196C8 File Offset: 0x000178C8
		[Token(Token = "0x17000A57")]
		public int ID
		{
			[Token(Token = "0x60046B4")]
			[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x060046B5 RID: 18101 RVA: 0x000196E0 File Offset: 0x000178E0
		[Token(Token = "0x17000A58")]
		public Color BgColor
		{
			[Token(Token = "0x60046B5")]
			[Address(RVA = "0x73EFA0", Offset = "0x73D9A0", VA = "0x18073EFA0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x060046B6 RID: 18102 RVA: 0x000196F8 File Offset: 0x000178F8
		[Token(Token = "0x17000A59")]
		public Color TextColor
		{
			[Token(Token = "0x60046B6")]
			[Address(RVA = "0x73F190", Offset = "0x73DB90", VA = "0x18073F190")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x060046B7 RID: 18103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5A")]
		public CharacterProtrayalSet CharacterPortrayal
		{
			[Token(Token = "0x60046B7")]
			[Address(RVA = "0x73F0A0", Offset = "0x73DAA0", VA = "0x18073F0A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A5B")]
		public CharacterSkinSets CharacterPixel
		{
			[Token(Token = "0x60046B8")]
			[Address(RVA = "0x73EFB0", Offset = "0x73D9B0", VA = "0x18073EFB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046B9")]
		[Address(RVA = "0x73EE80", Offset = "0x73D880", VA = "0x18073EE80")]
		public static GuestProfilePair CreateDefault(CharacterProtrayalSet characterPortrayalSet, CharacterSkinSets skinSets)
		{
			return null;
		}

		// Token: 0x04003F40 RID: 16192
		[Token(Token = "0x4003F40")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int id;

		// Token: 0x04003F41 RID: 16193
		[Token(Token = "0x4003F41")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Color bgColor;

		// Token: 0x04003F42 RID: 16194
		[Token(Token = "0x4003F42")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Color textColor;

		// Token: 0x04003F43 RID: 16195
		[Token(Token = "0x4003F43")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CharacterProtrayalSet characterPortrayal;

		// Token: 0x04003F44 RID: 16196
		[Token(Token = "0x4003F44")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CharacterSkinSets characterPixel;
	}
}

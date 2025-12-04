using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	[Serializable]
	public struct GuestGuardMapping
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B8")]
		public string[] DescribeText
		{
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x531450", Offset = "0x52FE50", VA = "0x180531450")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x82C580", Offset = "0x82AF80", VA = "0x18082C580")]
		public bool Equals(GuestGuardMapping other)
		{
			return default(bool);
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x82C610", Offset = "0x82B010", VA = "0x18082C610", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x82C750", Offset = "0x82B150", VA = "0x18082C750", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		[FieldOffset(Offset = "0x0")]
		public int letterId;

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		[FieldOffset(Offset = "0x4")]
		public int id;

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		[FieldOffset(Offset = "0x8")]
		public int costP;

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0xC")]
		public float coolDown;

		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x10")]
		public int maxHp;

		// Token: 0x040007D1 RID: 2001
		[Token(Token = "0x40007D1")]
		[FieldOffset(Offset = "0x14")]
		public GuestGuardMapping.GuardType guardType;

		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		[FieldOffset(Offset = "0x18")]
		public int youseiOrderBevId;

		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		[FieldOffset(Offset = "0x20")]
		public GameObject guardController;

		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		[FieldOffset(Offset = "0x28")]
		public string inviteEventLabel;

		// Token: 0x02000175 RID: 373
		[Token(Token = "0x2000175")]
		public enum GuardType
		{
			// Token: 0x040007D7 RID: 2007
			[Token(Token = "0x40007D7")]
			Hero,
			// Token: 0x040007D8 RID: 2008
			[Token(Token = "0x40007D8")]
			Yousei,
			// Token: 0x040007D9 RID: 2009
			[Token(Token = "0x40007D9")]
			Other
		}
	}
}

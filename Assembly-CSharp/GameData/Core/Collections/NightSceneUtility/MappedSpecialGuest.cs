using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x020008E9 RID: 2281
	[Token(Token = "0x20008E9")]
	[Serializable]
	public class MappedSpecialGuest
	{
		// Token: 0x060038CD RID: 14541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038CD")]
		[Address(RVA = "0x687030", Offset = "0x685A30", VA = "0x180687030")]
		public MappedSpecialGuest(int id, int sourceGuestID, NPC.Destination overrideDestination, string stringId)
		{
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060038CE RID: 14542 RVA: 0x000157B0 File Offset: 0x000139B0
		[Token(Token = "0x170007C7")]
		public int ID
		{
			[Token(Token = "0x60038CE")]
			[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060038CF RID: 14543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C8")]
		public string StrID
		{
			[Token(Token = "0x60038CF")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060038D0 RID: 14544 RVA: 0x000157C8 File Offset: 0x000139C8
		[Token(Token = "0x170007C9")]
		public int SourceGuestID
		{
			[Token(Token = "0x60038D0")]
			[Address(RVA = "0x3F8D30", Offset = "0x3F7730", VA = "0x1803F8D30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x060038D1 RID: 14545 RVA: 0x000157E0 File Offset: 0x000139E0
		[Token(Token = "0x170007CA")]
		public NPC.Destination OverrideDestination
		{
			[Token(Token = "0x60038D1")]
			[Address(RVA = "0x6870A0", Offset = "0x685AA0", VA = "0x1806870A0")]
			get
			{
				return default(NPC.Destination);
			}
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038D2")]
		[Address(RVA = "0x686FA0", Offset = "0x6859A0", VA = "0x180686FA0")]
		public SpecialGuest GenerateDummy()
		{
			return null;
		}

		// Token: 0x04003071 RID: 12401
		[Token(Token = "0x4003071")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int id;

		// Token: 0x04003072 RID: 12402
		[Token(Token = "0x4003072")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string stringId;

		// Token: 0x04003073 RID: 12403
		[Token(Token = "0x4003073")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int sourceGuestID;

		// Token: 0x04003074 RID: 12404
		[Token(Token = "0x4003074")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private NPC.Destination overrideDestination;
	}
}

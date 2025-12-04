using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B30 RID: 2864
	[Token(Token = "0x2000B30")]
	[Serializable]
	public class KyoukoTutorialData_Basement : KyoukoTutorialDataMultipleChoice
	{
		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x0600449B RID: 17563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009C4")]
		protected override KyoukoTutorialData[] ChildKyoukoTutorialData
		{
			[Token(Token = "0x600449B")]
			[Address(RVA = "0x71C430", Offset = "0x71AE30", VA = "0x18071C430", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600449C RID: 17564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449C")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public KyoukoTutorialData_Basement()
		{
		}

		// Token: 0x04003CB7 RID: 15543
		[Token(Token = "0x4003CB7")]
		[FieldOffset(Offset = "0x70")]
		[Header("5.3.1-展示柜")]
		public KyoukoTutorialData_ShowCase ShowCase;

		// Token: 0x04003CB8 RID: 15544
		[Token(Token = "0x4003CB8")]
		[FieldOffset(Offset = "0x78")]
		[Header("5.3.2-衣橱")]
		public KyoukoTutorialData_Closet Closet;

		// Token: 0x04003CB9 RID: 15545
		[Token(Token = "0x4003CB9")]
		[FieldOffset(Offset = "0x80")]
		[Header("5.3.3-留声机")]
		public KyoukoTutorialData_CDPlayer CdPlayer;
	}
}

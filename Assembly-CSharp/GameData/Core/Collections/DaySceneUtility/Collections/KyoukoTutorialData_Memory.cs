using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B22 RID: 2850
	[Token(Token = "0x2000B22")]
	[Serializable]
	public class KyoukoTutorialData_Memory : KyoukoTutorialDataMultipleChoice
	{
		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06004479 RID: 17529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009C2")]
		protected override KyoukoTutorialData[] ChildKyoukoTutorialData
		{
			[Token(Token = "0x6004479")]
			[Address(RVA = "0x71D160", Offset = "0x71BB60", VA = "0x18071D160", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600447A")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public KyoukoTutorialData_Memory()
		{
		}

		// Token: 0x04003C8A RID: 15498
		[Token(Token = "0x4003C8A")]
		[FieldOffset(Offset = "0x70")]
		[Header("2.1-新手需知…")]
		public KyoukoTutorialData_FreshManTip FreshManTip;

		// Token: 0x04003C8B RID: 15499
		[Token(Token = "0x4003C8B")]
		[FieldOffset(Offset = "0x78")]
		[Header("2.2-如何满足稀客")]
		public KyoukoTutorialData_HowToSatisfySpecialGuest HowToSatisfySpecialGuest;

		// Token: 0x04003C8C RID: 15500
		[Token(Token = "0x4003C8C")]
		[FieldOffset(Offset = "0x80")]
		[Header("2.3-夜雀之歌")]
		public KyoukoTutorialData_WhatIsQTE WhatIsQTE;

		// Token: 0x04003C8D RID: 15501
		[Token(Token = "0x4003C8D")]
		[FieldOffset(Offset = "0x88")]
		[Header("2.4-关于飞行")]
		public KyoukoTutorialData AboutFly;

		// Token: 0x04003C8E RID: 15502
		[Token(Token = "0x4003C8E")]
		[FieldOffset(Offset = "0x90")]
		[Header("2.5-有关饕餮尤魔")]
		public KyoukoTutorialData_AboutToutetsu AboutToutetsu;
	}
}

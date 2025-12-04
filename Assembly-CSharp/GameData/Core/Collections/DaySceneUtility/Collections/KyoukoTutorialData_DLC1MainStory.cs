using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B36 RID: 2870
	[Token(Token = "0x2000B36")]
	[Serializable]
	public class KyoukoTutorialData_DLC1MainStory : KyoukoTutorialData
	{
		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060044A8 RID: 17576 RVA: 0x00018D68 File Offset: 0x00016F68
		[Token(Token = "0x170009C9")]
		public override bool NeedToShow
		{
			[Token(Token = "0x60044A8")]
			[Address(RVA = "0x71C620", Offset = "0x71B020", VA = "0x18071C620", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060044A9 RID: 17577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044A9")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public KyoukoTutorialData_DLC1MainStory()
		{
		}

		// Token: 0x04003CBC RID: 15548
		[Token(Token = "0x4003CBC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string finishEventLabel;
	}
}

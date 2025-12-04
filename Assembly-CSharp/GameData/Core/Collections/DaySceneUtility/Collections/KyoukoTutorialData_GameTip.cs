using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B2F RID: 2863
	[Token(Token = "0x2000B2F")]
	[Serializable]
	public class KyoukoTutorialData_GameTip : KyoukoTutorialDataMultipleChoice
	{
		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06004499 RID: 17561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009C3")]
		protected override KyoukoTutorialData[] ChildKyoukoTutorialData
		{
			[Token(Token = "0x6004499")]
			[Address(RVA = "0x71C9F0", Offset = "0x71B3F0", VA = "0x18071C9F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600449A RID: 17562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600449A")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public KyoukoTutorialData_GameTip()
		{
		}

		// Token: 0x04003CAF RID: 15535
		[Token(Token = "0x4003CAF")]
		[FieldOffset(Offset = "0x70")]
		[Header("5.1-置顶")]
		public KyoukoTutorialDataWithPrefab TopMode;

		// Token: 0x04003CB0 RID: 15536
		[Token(Token = "0x4003CB0")]
		[FieldOffset(Offset = "0x78")]
		[Header("5.2-预设")]
		public KyoukoTutorialDataWithPrefab IzakayaPreset;

		// Token: 0x04003CB1 RID: 15537
		[Token(Token = "0x4003CB1")]
		[FieldOffset(Offset = "0x80")]
		[Header("5.3-地下室")]
		public KyoukoTutorialData_Basement AboutBasement;

		// Token: 0x04003CB2 RID: 15538
		[Token(Token = "0x4003CB2")]
		[FieldOffset(Offset = "0x88")]
		[Header("5.4-奖励符卡")]
		public KyoukoTutorialData_SpellCard AboutPositiveSpellCard;

		// Token: 0x04003CB3 RID: 15539
		[Token(Token = "0x4003CB3")]
		[FieldOffset(Offset = "0x90")]
		[Header("5.5-香霖堂")]
		public KyoukoTutorialData AboutKourindou;

		// Token: 0x04003CB4 RID: 15540
		[Token(Token = "0x4003CB4")]
		[FieldOffset(Offset = "0x98")]
		[Header("5.6-白玉楼")]
		public KyoukoTutorialData AboutHakugyokurou;

		// Token: 0x04003CB5 RID: 15541
		[Token(Token = "0x4003CB5")]
		[FieldOffset(Offset = "0xA0")]
		[Header("5.7-DLC")]
		public KyoukoTutorialData AboutDLC;

		// Token: 0x04003CB6 RID: 15542
		[Token(Token = "0x4003CB6")]
		[FieldOffset(Offset = "0xA8")]
		[Header("5.8-DLC1主线")]
		public KyoukoTutorialData_DLC1MainStory ForDLC1MainStory;
	}
}

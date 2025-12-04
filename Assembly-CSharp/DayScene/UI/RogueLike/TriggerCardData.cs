using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200038B RID: 907
	[Token(Token = "0x200038B")]
	[JsonObject(MemberSerialization.OptIn)]
	[Serializable]
	public struct TriggerCardData
	{
		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600142D RID: 5165 RVA: 0x00007B60 File Offset: 0x00005D60
		[Token(Token = "0x17000247")]
		public TriggerCardCondition TriggerCardCondition
		{
			[Token(Token = "0x600142D")]
			[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
			get
			{
				return TriggerCardCondition.EnoughCombo;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600142E RID: 5166 RVA: 0x00007B78 File Offset: 0x00005D78
		[Token(Token = "0x17000248")]
		public int InitialCardNum
		{
			[Token(Token = "0x600142E")]
			[Address(RVA = "0x43B0B0", Offset = "0x439AB0", VA = "0x18043B0B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600142F RID: 5167 RVA: 0x00007B90 File Offset: 0x00005D90
		[Token(Token = "0x17000249")]
		public bool AddMaxCardNumWhenTrigger
		{
			[Token(Token = "0x600142F")]
			[Address(RVA = "0x4506F0", Offset = "0x44F0F0", VA = "0x1804506F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040012AB RID: 4779
		[Token(Token = "0x40012AB")]
		[FieldOffset(Offset = "0x0")]
		[JsonProperty("TriggerCardCondition")]
		[SerializeField]
		private TriggerCardCondition m_TriggerCardCondition;

		// Token: 0x040012AC RID: 4780
		[Token(Token = "0x40012AC")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[JsonProperty("InitialCardNum")]
		private int m_InitialCardNum;

		// Token: 0x040012AD RID: 4781
		[Token(Token = "0x40012AD")]
		[FieldOffset(Offset = "0x8")]
		[JsonProperty("AddMaxCardNumWhenTrigger")]
		[SerializeField]
		private bool m_AddMaxCardNumWhenTrigger;
	}
}

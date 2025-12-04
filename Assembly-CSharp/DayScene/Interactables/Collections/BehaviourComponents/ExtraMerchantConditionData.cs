using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200051E RID: 1310
	[Token(Token = "0x200051E")]
	[Serializable]
	public struct ExtraMerchantConditionData
	{
		// Token: 0x04001B03 RID: 6915
		[Token(Token = "0x4001B03")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public string merchantKey;

		// Token: 0x04001B04 RID: 6916
		[Token(Token = "0x4001B04")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public ExtraMerchantConditionData.ConditionType merchantType;

		// Token: 0x04001B05 RID: 6917
		[Token(Token = "0x4001B05")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string eventKey;

		// Token: 0x0200051F RID: 1311
		[Token(Token = "0x200051F")]
		[SerializeField]
		public enum ConditionType
		{
			// Token: 0x04001B07 RID: 6919
			[Token(Token = "0x4001B07")]
			FinishEvent,
			// Token: 0x04001B08 RID: 6920
			[Token(Token = "0x4001B08")]
			FinishMission
		}
	}
}

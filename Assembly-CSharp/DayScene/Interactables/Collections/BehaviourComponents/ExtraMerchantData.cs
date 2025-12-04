using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200051C RID: 1308
	[Token(Token = "0x200051C")]
	[Serializable]
	public struct ExtraMerchantData
	{
		// Token: 0x04001AFC RID: 6908
		[Token(Token = "0x4001AFC")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public string merchantKey;

		// Token: 0x04001AFD RID: 6909
		[Token(Token = "0x4001AFD")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public string merchantMapLabel;

		// Token: 0x04001AFE RID: 6910
		[Token(Token = "0x4001AFE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public ExtraMerchantData.MerchantType merchantType;

		// Token: 0x04001AFF RID: 6911
		[Token(Token = "0x4001AFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public string collabKey;

		// Token: 0x0200051D RID: 1309
		[Token(Token = "0x200051D")]
		[SerializeField]
		public enum MerchantType
		{
			// Token: 0x04001B01 RID: 6913
			[Token(Token = "0x4001B01")]
			AlwaysOpen,
			// Token: 0x04001B02 RID: 6914
			[Token(Token = "0x4001B02")]
			Collab
		}
	}
}

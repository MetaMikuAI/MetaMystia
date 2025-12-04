using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.Interactables.Merchant
{
	// Token: 0x020004BA RID: 1210
	[Token(Token = "0x20004BA")]
	[CreateAssetMenu(fileName = "MerchantProfile", menuName = "GameData Profile/MerchantProfile", order = 0)]
	public class MerchantProfile : ScriptableObject
	{
		// Token: 0x06001B8C RID: 7052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8C")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public MerchantProfile()
		{
		}

		// Token: 0x0400194F RID: 6479
		[Token(Token = "0x400194F")]
		[FieldOffset(Offset = "0x18")]
		public Merchant[] merchants;

		// Token: 0x04001950 RID: 6480
		[Token(Token = "0x4001950")]
		[FieldOffset(Offset = "0x20")]
		public SellableProfile foodProfile;

		// Token: 0x04001951 RID: 6481
		[Token(Token = "0x4001951")]
		[FieldOffset(Offset = "0x28")]
		public SellableProfile beverageProfile;

		// Token: 0x04001952 RID: 6482
		[Token(Token = "0x4001952")]
		[FieldOffset(Offset = "0x30")]
		public IngredientProfile ingredientProfile;

		// Token: 0x04001953 RID: 6483
		[Token(Token = "0x4001953")]
		[FieldOffset(Offset = "0x38")]
		public CookerProfile cookerProfile;

		// Token: 0x04001954 RID: 6484
		[Token(Token = "0x4001954")]
		[FieldOffset(Offset = "0x40")]
		public TextAsset tsvBackup;
	}
}

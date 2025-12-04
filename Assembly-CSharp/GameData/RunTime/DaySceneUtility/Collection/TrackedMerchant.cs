using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.RunTime.DaySceneUtility.Collection
{
	// Token: 0x020007F6 RID: 2038
	[Token(Token = "0x20007F6")]
	[Serializable]
	public class TrackedMerchant : IDeepClonable<TrackedMerchant>
	{
		// Token: 0x06003044 RID: 12356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003044")]
		[Address(RVA = "0x46BA70", Offset = "0x46A470", VA = "0x18046BA70")]
		public TrackedMerchant(string key)
		{
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003045")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		private TrackedMerchant()
		{
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003046")]
		[Address(RVA = "0x617AA0", Offset = "0x6164A0", VA = "0x180617AA0", Slot = "4")]
		public TrackedMerchant Clone()
		{
			return null;
		}

		// Token: 0x06003047 RID: 12359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003047")]
		[Address(RVA = "0x617B80", Offset = "0x616580", VA = "0x180617B80")]
		public void GenerateProduct()
		{
		}

		// Token: 0x04002B1F RID: 11039
		[Token(Token = "0x4002B1F")]
		[FieldOffset(Offset = "0x10")]
		public string key;

		// Token: 0x04002B20 RID: 11040
		[Token(Token = "0x4002B20")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public float currentPriceMultiplier;

		// Token: 0x04002B21 RID: 11041
		[Token(Token = "0x4002B21")]
		[FieldOffset(Offset = "0x20")]
		public Product[] products;
	}
}

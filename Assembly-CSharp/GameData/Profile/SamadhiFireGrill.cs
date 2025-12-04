using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C85 RID: 3205
	[Token(Token = "0x2000C85")]
	[CreateAssetMenu(fileName = "SamadhiFireGrill", menuName = "GameData Profile/Cooker Asset/SamadhiFireGrill", order = 3000)]
	public class SamadhiFireGrill : CookerAssetBase
	{
		// Token: 0x06004AE8 RID: 19176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE8")]
		[Address(RVA = "0x7837B0", Offset = "0x7821B0", VA = "0x1807837B0", Slot = "12")]
		protected override string ProcessBaseDescriptionCallback(string baseDescription)
		{
			return null;
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x0001B2D0 File Offset: 0x000194D0
		[Token(Token = "0x6004AE9")]
		[Address(RVA = "0x7833D0", Offset = "0x781DD0", VA = "0x1807833D0", Slot = "7")]
		public override float ExtraCookTimeMultiplier(CookController thisCookController, Sellable food)
		{
			return 0f;
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AEA")]
		[Address(RVA = "0x783460", Offset = "0x781E60", VA = "0x180783460", Slot = "10")]
		public override Sellable OnFinishCook(Sellable finishedFood, float qteScore, bool couldReturnIngredients)
		{
			return null;
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AEB")]
		[Address(RVA = "0x783840", Offset = "0x782240", VA = "0x180783840")]
		public SamadhiFireGrill()
		{
		}

		// Token: 0x040044F7 RID: 17655
		[Token(Token = "0x40044F7")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float returnBackRate;

		// Token: 0x040044F8 RID: 17656
		[Token(Token = "0x40044F8")]
		[FieldOffset(Offset = "0x2C")]
		public int meatTag;
	}
}

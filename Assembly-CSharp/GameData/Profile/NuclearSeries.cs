using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C82 RID: 3202
	[Token(Token = "0x2000C82")]
	[CreateAssetMenu(fileName = "NuclearSeries", menuName = "GameData Profile/Cooker Asset/NuclearSeries", order = 3)]
	public class NuclearSeries : CookerAssetBase
	{
		// Token: 0x06004ADE RID: 19166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ADE")]
		[Address(RVA = "0x7820A0", Offset = "0x780AA0", VA = "0x1807820A0", Slot = "12")]
		protected override string ProcessBaseDescriptionCallback(string baseDescription)
		{
			return null;
		}

		// Token: 0x06004ADF RID: 19167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ADF")]
		[Address(RVA = "0x782040", Offset = "0x780A40", VA = "0x180782040", Slot = "10")]
		public override Sellable OnFinishCook(Sellable finishedFood, float qteScore, bool couldReturnIngredients)
		{
			return null;
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE0")]
		[Address(RVA = "0x782170", Offset = "0x780B70", VA = "0x180782170")]
		public NuclearSeries()
		{
		}

		// Token: 0x040044F2 RID: 17650
		[Token(Token = "0x40044F2")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float failProbability;

		// Token: 0x040044F3 RID: 17651
		[Token(Token = "0x40044F3")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float qteSucceededfailProbability;
	}
}

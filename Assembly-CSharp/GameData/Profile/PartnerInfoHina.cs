using System;
using System.Text;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CCF RID: 3279
	[Token(Token = "0x2000CCF")]
	[CreateAssetMenu(fileName = "DLC1_PartnerInfo_Hina", menuName = "GameData Profile/PartnerInfoCollection/DLC1_PartnerInfoHina", order = 6)]
	public sealed class PartnerInfoHina : PartnerInfo
	{
		// Token: 0x06004C4A RID: 19530 RVA: 0x0001BA20 File Offset: 0x00019C20
		[Token(Token = "0x6004C4A")]
		[Address(RVA = "0x79E030", Offset = "0x79CA30", VA = "0x18079E030", Slot = "11")]
		public override float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseTime, ref bool doNotCostIngredients)
		{
			return 0f;
		}

		// Token: 0x06004C4B RID: 19531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C4B")]
		[Address(RVA = "0x79E040", Offset = "0x79CA40", VA = "0x18079E040", Slot = "12")]
		public override Sellable OnGetOverrideFinalCookResult(CookController cooker, Sellable lastFood, out bool isRequestedFood)
		{
			return null;
		}

		// Token: 0x06004C4C RID: 19532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4C")]
		[Address(RVA = "0x79E3A0", Offset = "0x79CDA0", VA = "0x18079E3A0", Slot = "22")]
		protected override void PostProcessInfo(StringBuilder builder)
		{
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4D")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public PartnerInfoHina()
		{
		}

		// Token: 0x0400463A RID: 17978
		[Token(Token = "0x400463A")]
		[FieldOffset(Offset = "0x58")]
		public float darkMatterRate;

		// Token: 0x0400463B RID: 17979
		[Token(Token = "0x400463B")]
		[FieldOffset(Offset = "0x60")]
		public GameObject failedEffect;

		// Token: 0x0400463C RID: 17980
		[Token(Token = "0x400463C")]
		[FieldOffset(Offset = "0x68")]
		public GameObject successEffect;

		// Token: 0x0400463D RID: 17981
		[Token(Token = "0x400463D")]
		[FieldOffset(Offset = "0x70")]
		public AudioClip successSFX;

		// Token: 0x0400463E RID: 17982
		[Token(Token = "0x400463E")]
		[FieldOffset(Offset = "0x78")]
		public AudioClip failSFX;
	}
}

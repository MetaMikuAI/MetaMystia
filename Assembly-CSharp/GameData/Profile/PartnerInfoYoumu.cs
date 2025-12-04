using System;
using System.Text;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CEA RID: 3306
	[Token(Token = "0x2000CEA")]
	[CreateAssetMenu(fileName = "PartnerInfo_Youmu", menuName = "GameData Profile/PartnerInfoCollection/PartnerInfoYoumu", order = 5)]
	public sealed class PartnerInfoYoumu : PartnerInfo
	{
		// Token: 0x06004CBB RID: 19643 RVA: 0x0001BBA0 File Offset: 0x00019DA0
		[Token(Token = "0x6004CBB")]
		[Address(RVA = "0x79FA70", Offset = "0x79E470", VA = "0x18079FA70", Slot = "11")]
		public override float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseTime, ref bool doNotCostIngredients)
		{
			return 0f;
		}

		// Token: 0x06004CBC RID: 19644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CBC")]
		[Address(RVA = "0x79FDA0", Offset = "0x79E7A0", VA = "0x18079FDA0", Slot = "22")]
		protected override void PostProcessInfo(StringBuilder builder)
		{
		}

		// Token: 0x06004CBD RID: 19645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CBD")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public PartnerInfoYoumu()
		{
		}

		// Token: 0x040046A6 RID: 18086
		[Token(Token = "0x40046A6")]
		[FieldOffset(Offset = "0x58")]
		public Cooker.CookerType cookerType;

		// Token: 0x040046A7 RID: 18087
		[Token(Token = "0x40046A7")]
		[FieldOffset(Offset = "0x60")]
		public GameObject successEffect;

		// Token: 0x040046A8 RID: 18088
		[Token(Token = "0x40046A8")]
		[FieldOffset(Offset = "0x68")]
		public GameObject successTextEffect;

		// Token: 0x040046A9 RID: 18089
		[Token(Token = "0x40046A9")]
		[FieldOffset(Offset = "0x70")]
		public AudioClip successSFX;
	}
}

using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace GameData.Profile
{
	// Token: 0x02000C7F RID: 3199
	[Token(Token = "0x2000C7F")]
	[CreateAssetMenu(fileName = "NitoriIndustryPot", menuName = "GameData Profile/Cooker Asset/NitoriIndustryPot", order = 1000)]
	public class NitoriIndustryPot : CookerAssetBase
	{
		// Token: 0x06004ACE RID: 19150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ACE")]
		[Address(RVA = "0x781D90", Offset = "0x780790", VA = "0x180781D90", Slot = "19")]
		public override void OnCookerWorkTimeUpdate(CookController targetCooker, float oldWorkTime)
		{
		}

		// Token: 0x06004ACF RID: 19151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ACF")]
		[Address(RVA = "0x781F50", Offset = "0x780950", VA = "0x180781F50", Slot = "12")]
		protected override string ProcessBaseDescriptionCallback(string baseDescription)
		{
			return null;
		}

		// Token: 0x06004AD0 RID: 19152 RVA: 0x0001B1B0 File Offset: 0x000193B0
		[Token(Token = "0x6004AD0")]
		[Address(RVA = "0x781670", Offset = "0x780070", VA = "0x180781670", Slot = "7")]
		public override float ExtraCookTimeMultiplier(CookController thisCookController, Sellable food)
		{
			return 0f;
		}

		// Token: 0x06004AD1 RID: 19153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AD1")]
		[Address(RVA = "0x782020", Offset = "0x780A20", VA = "0x180782020")]
		public NitoriIndustryPot()
		{
		}

		// Token: 0x040044E1 RID: 17633
		[Token(Token = "0x40044E1")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float finalFoodUseTime;

		// Token: 0x040044E2 RID: 17634
		[Token(Token = "0x40044E2")]
		[FieldOffset(Offset = "0x2C")]
		public int targetWorkTime;

		// Token: 0x040044E3 RID: 17635
		[Token(Token = "0x40044E3")]
		[FieldOffset(Offset = "0x30")]
		public GameObject upgradeVfx;

		// Token: 0x040044E4 RID: 17636
		[Token(Token = "0x40044E4")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 upgradeVfxOffset;

		// Token: 0x040044E5 RID: 17637
		[Token(Token = "0x40044E5")]
		[FieldOffset(Offset = "0x48")]
		public AnimatedTile v2Idle;

		// Token: 0x040044E6 RID: 17638
		[Token(Token = "0x40044E6")]
		[FieldOffset(Offset = "0x50")]
		public AnimatedTile v2Load;

		// Token: 0x040044E7 RID: 17639
		[Token(Token = "0x40044E7")]
		[FieldOffset(Offset = "0x58")]
		public AnimatedTile v2Cooking;
	}
}

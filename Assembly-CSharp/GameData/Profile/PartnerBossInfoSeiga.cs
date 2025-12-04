using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CB4 RID: 3252
	[Token(Token = "0x2000CB4")]
	[CreateAssetMenu(fileName = "DLC3_PartnerBossInfo_Seiga", menuName = "GameData Profile/PartnerInfoCollection/Boss/DLC3_Seiga", order = 0)]
	public class PartnerBossInfoSeiga : PartnerBossInfo
	{
		// Token: 0x06004BC4 RID: 19396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC4")]
		[Address(RVA = "0x7990E0", Offset = "0x797AE0", VA = "0x1807990E0", Slot = "25")]
		public override void BossSpecialAbilityPreLoad(PartnerBase currentPartner, EventManager eventManager, PartnerManager manager, object[] additionalData)
		{
		}

		// Token: 0x06004BC5 RID: 19397 RVA: 0x0001B5D0 File Offset: 0x000197D0
		[Token(Token = "0x6004BC5")]
		[Address(RVA = "0x799280", Offset = "0x797C80", VA = "0x180799280", Slot = "11")]
		public override float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseTime, ref bool doNotCostIngredients)
		{
			return 0f;
		}

		// Token: 0x06004BC6 RID: 19398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BC6")]
		[Address(RVA = "0x799220", Offset = "0x797C20", VA = "0x180799220", Slot = "24")]
		public override string GetBossSpecialSkill()
		{
			return null;
		}

		// Token: 0x06004BC7 RID: 19399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BC7")]
		[Address(RVA = "0x7993C0", Offset = "0x797DC0", VA = "0x1807993C0")]
		public PartnerBossInfoSeiga()
		{
		}

		// Token: 0x040045B6 RID: 17846
		[Token(Token = "0x40045B6")]
		[FieldOffset(Offset = "0x80")]
		public int lockTableNum;

		// Token: 0x040045B7 RID: 17847
		[Token(Token = "0x40045B7")]
		[FieldOffset(Offset = "0x84")]
		public int lockDuration;

		// Token: 0x040045B8 RID: 17848
		[Token(Token = "0x40045B8")]
		[FieldOffset(Offset = "0x88")]
		public int lockInterval;

		// Token: 0x040045B9 RID: 17849
		[Token(Token = "0x40045B9")]
		[FieldOffset(Offset = "0x90")]
		public GameObject seigaSmileEffect;

		// Token: 0x040045BA RID: 17850
		[Token(Token = "0x40045BA")]
		[FieldOffset(Offset = "0x98")]
		public AudioClip seigaSmileSFX;
	}
}

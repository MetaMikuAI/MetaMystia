using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CA9 RID: 3241
	[Token(Token = "0x2000CA9")]
	[CreateAssetMenu(fileName = "DLC3_PartnerBossInfo_Futo", menuName = "GameData Profile/PartnerInfoCollection/Boss/DLC3_Futo", order = 1)]
	public class PartnerBossInfoFuto : PartnerBossInfo
	{
		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06004B92 RID: 19346 RVA: 0x0001B4B0 File Offset: 0x000196B0
		[Token(Token = "0x17000ADD")]
		public override PartnerInfoBase.DeliverType PartnerDeliverType
		{
			[Token(Token = "0x6004B92")]
			[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "9")]
			get
			{
				return PartnerInfoBase.DeliverType.Normal;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06004B93 RID: 19347 RVA: 0x0001B4C8 File Offset: 0x000196C8
		[Token(Token = "0x17000ADE")]
		protected override int AdditionalDataRequirement
		{
			[Token(Token = "0x6004B93")]
			[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004B94 RID: 19348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B94")]
		[Address(RVA = "0x782510", Offset = "0x780F10", VA = "0x180782510", Slot = "16")]
		protected override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, object[] additionalData)
		{
		}

		// Token: 0x06004B95 RID: 19349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B95")]
		[Address(RVA = "0x782190", Offset = "0x780B90", VA = "0x180782190", Slot = "25")]
		public override void BossSpecialAbilityPreLoad(PartnerBase currentPartner, EventManager eventManager, PartnerManager manager, object[] additionalData)
		{
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x0001B4E0 File Offset: 0x000196E0
		[Token(Token = "0x6004B96")]
		[Address(RVA = "0x782370", Offset = "0x780D70", VA = "0x180782370", Slot = "11")]
		public override float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseTime, ref bool doNotCostIngredients)
		{
			return 0f;
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B97")]
		[Address(RVA = "0x782310", Offset = "0x780D10", VA = "0x180782310", Slot = "24")]
		public override string GetBossSpecialSkill()
		{
			return null;
		}

		// Token: 0x06004B98 RID: 19352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B98")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public PartnerBossInfoFuto()
		{
		}

		// Token: 0x0400457B RID: 17787
		[Token(Token = "0x400457B")]
		[FieldOffset(Offset = "0x80")]
		public GameObject throwFood;

		// Token: 0x0400457C RID: 17788
		[Token(Token = "0x400457C")]
		[FieldOffset(Offset = "0x88")]
		public AudioClip throwSFX;

		// Token: 0x0400457D RID: 17789
		[Token(Token = "0x400457D")]
		[FieldOffset(Offset = "0x90")]
		public AudioClip hitSFX;

		// Token: 0x0400457E RID: 17790
		[Token(Token = "0x400457E")]
		[FieldOffset(Offset = "0x98")]
		public float launchSpeed;

		// Token: 0x0400457F RID: 17791
		[Token(Token = "0x400457F")]
		[FieldOffset(Offset = "0x9C")]
		public float launchHeight;

		// Token: 0x04004580 RID: 17792
		[Token(Token = "0x4004580")]
		[FieldOffset(Offset = "0xA0")]
		public int fireNum;

		// Token: 0x04004581 RID: 17793
		[Token(Token = "0x4004581")]
		[FieldOffset(Offset = "0xA4")]
		public int fireInterval;

		// Token: 0x04004582 RID: 17794
		[Token(Token = "0x4004582")]
		[FieldOffset(Offset = "0xA8")]
		public int fireDuration;

		// Token: 0x04004583 RID: 17795
		[Token(Token = "0x4004583")]
		[FieldOffset(Offset = "0xAC")]
		public int burnDuration;

		// Token: 0x04004584 RID: 17796
		[Token(Token = "0x4004584")]
		[FieldOffset(Offset = "0xB0")]
		public float fireRadius;

		// Token: 0x04004585 RID: 17797
		[Token(Token = "0x4004585")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject fireEffect;

		// Token: 0x04004586 RID: 17798
		[Token(Token = "0x4004586")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject fireExplosion;

		// Token: 0x04004587 RID: 17799
		[Token(Token = "0x4004587")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject fireExplosionTray;

		// Token: 0x04004588 RID: 17800
		[Token(Token = "0x4004588")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject firePlayer;

		// Token: 0x04004589 RID: 17801
		[Token(Token = "0x4004589")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject fireEnergy;

		// Token: 0x0400458A RID: 17802
		[Token(Token = "0x400458A")]
		[FieldOffset(Offset = "0xE0")]
		public AudioClip fireSpawnSFX;

		// Token: 0x0400458B RID: 17803
		[Token(Token = "0x400458B")]
		[FieldOffset(Offset = "0xE8")]
		public AudioClip fireContinueSFX;

		// Token: 0x0400458C RID: 17804
		[Token(Token = "0x400458C")]
		[FieldOffset(Offset = "0xF0")]
		public AudioClip fireExplosionSFX;

		// Token: 0x0400458D RID: 17805
		[Token(Token = "0x400458D")]
		[FieldOffset(Offset = "0xF8")]
		public AudioClip playerBurntSFX;
	}
}

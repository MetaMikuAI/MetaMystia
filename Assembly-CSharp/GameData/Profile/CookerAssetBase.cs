using System;
using System.Collections.Generic;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using NightScene.UI.CookingUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C7A RID: 3194
	[Token(Token = "0x2000C7A")]
	public abstract class CookerAssetBase : ScriptableObject
	{
		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06004AB0 RID: 19120 RVA: 0x0001B138 File Offset: 0x00019338
		[Token(Token = "0x17000ACC")]
		protected virtual bool IncludesGeneralData
		{
			[Token(Token = "0x6004AB0")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB1")]
		[Address(RVA = "0x3FA8D0", Offset = "0x3F92D0", VA = "0x1803FA8D0", Slot = "5")]
		public virtual IEnumerable<IEnumerable<NormalGuest>> OnGetNormalGuests(IEnumerable<IEnumerable<NormalGuest>> preFillteredGuests)
		{
			return null;
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB2")]
		[Address(RVA = "0x3FA8D0", Offset = "0x3F92D0", VA = "0x1803FA8D0", Slot = "6")]
		public virtual IEnumerable<WorkSceneCookingSelectionPannel.MatchedCookCombo> OnGetCookerOutput(IEnumerable<WorkSceneCookingSelectionPannel.MatchedCookCombo> preFillteredRecipe)
		{
			return null;
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x0001B150 File Offset: 0x00019350
		[Token(Token = "0x6004AB3")]
		[Address(RVA = "0x77CDA0", Offset = "0x77B7A0", VA = "0x18077CDA0", Slot = "7")]
		public virtual float ExtraCookTimeMultiplier(CookController targetCooker, Sellable food)
		{
			return 0f;
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x0001B168 File Offset: 0x00019368
		[Token(Token = "0x6004AB4")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "8")]
		public virtual float ExtraAdditiveNextOrderProb(Sellable food)
		{
			return 0f;
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AB5")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "9")]
		public virtual void OnStartCook()
		{
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB6")]
		[Address(RVA = "0x3FA8D0", Offset = "0x3F92D0", VA = "0x1803FA8D0", Slot = "10")]
		public virtual Sellable OnFinishCook(Sellable finishedFood, float qteScore, bool couldReturnIngredients)
		{
			return null;
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x0001B180 File Offset: 0x00019380
		[Token(Token = "0x6004AB7")]
		[Address(RVA = "0x437070", Offset = "0x435A70", VA = "0x180437070", Slot = "11")]
		public virtual int OnEvaluate(int evaluationResult, GuestGroupController guestGroupController, Sellable serveFood)
		{
			return 0;
		}

		// Token: 0x06004AB8 RID: 19128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB8")]
		[Address(RVA = "0x77CDB0", Offset = "0x77B7B0", VA = "0x18077CDB0")]
		public ObjectLanguageBase GetText(ObjectLanguageBase baseLanguageData)
		{
			return null;
		}

		// Token: 0x06004AB9 RID: 19129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AB9")]
		[Address(RVA = "0x3FA8D0", Offset = "0x3F92D0", VA = "0x1803FA8D0", Slot = "12")]
		protected virtual string ProcessBaseDescriptionCallback(string baseDescription)
		{
			return null;
		}

		// Token: 0x06004ABA RID: 19130 RVA: 0x0001B198 File Offset: 0x00019398
		[Token(Token = "0x6004ABA")]
		[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "13")]
		public virtual bool ShouldShowThisCookerBG(Sellable outputFood)
		{
			return default(bool);
		}

		// Token: 0x06004ABB RID: 19131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ABB")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "14")]
		public virtual void OnPlayerFinishExtract(CookController targetCooker)
		{
		}

		// Token: 0x06004ABC RID: 19132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ABC")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "15")]
		public virtual void WhenPlayerTryExtractWithFullTray(CookController targetCooker)
		{
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06004ABD RID: 19133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ACD")]
		public virtual Cooker.CookerType[] ExtraAvailableCookerType
		{
			[Token(Token = "0x6004ABD")]
			[Address(RVA = "0x77D0B0", Offset = "0x77BAB0", VA = "0x18077D0B0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06004ABE RID: 19134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ACE")]
		public virtual string OverrideTypeName
		{
			[Token(Token = "0x6004ABE")]
			[Address(RVA = "0x77D0E0", Offset = "0x77BAE0", VA = "0x18077D0E0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004ABF RID: 19135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004ABF")]
		[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "18")]
		public virtual AudioClip OverrideStartSFX(Cooker.CookerType cookerType)
		{
			return null;
		}

		// Token: 0x06004AC0 RID: 19136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC0")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "19")]
		public virtual void OnCookerWorkTimeUpdate(CookController targetCooker, float oldWorkTime)
		{
		}

		// Token: 0x06004AC1 RID: 19137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC1")]
		[Address(RVA = "0x77CD90", Offset = "0x77B790", VA = "0x18077CD90")]
		protected CookerAssetBase()
		{
		}

		// Token: 0x040044CF RID: 17615
		[Token(Token = "0x40044CF")]
		[FieldOffset(Offset = "0x18")]
		public float cookTimeMultiplier;

		// Token: 0x040044D0 RID: 17616
		[Token(Token = "0x40044D0")]
		[FieldOffset(Offset = "0x1C")]
		public float additiveNextOrderProb;

		// Token: 0x040044D1 RID: 17617
		[Token(Token = "0x40044D1")]
		[FieldOffset(Offset = "0x20")]
		public bool canNotOpenByPartner;

		// Token: 0x040044D2 RID: 17618
		[Token(Token = "0x40044D2")]
		[FieldOffset(Offset = "0x21")]
		public bool cookTimeMultiplierCanUseByPartner;
	}
}

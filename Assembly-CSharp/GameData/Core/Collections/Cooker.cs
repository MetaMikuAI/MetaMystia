using System;
using System.Collections.Generic;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppDummyDll;
using JetBrains.Annotations;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using NightScene.UI.CookingUtility;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace GameData.Core.Collections
{
	// Token: 0x020008E3 RID: 2275
	[Token(Token = "0x20008E3")]
	[Serializable]
	public class Cooker : NonTradableObjectBase
	{
		// Token: 0x0600389E RID: 14494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600389E")]
		[Address(RVA = "0x680230", Offset = "0x67EC30", VA = "0x180680230")]
		public Cooker(int id, Cooker.CookerType type, Cooker.CookerSeries cookerSeries, CookerAssetBase cookerAsset, AnimatedTile idle, AnimatedTile loaded, AnimatedTile cooking, float illuminationIntensity, AudioClip startCookSFX, AudioClip openCookSFX)
		{
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x0600389F RID: 14495 RVA: 0x00015690 File Offset: 0x00013890
		[Token(Token = "0x170007B4")]
		public Cooker.CookerType Type
		{
			[Token(Token = "0x600389F")]
			[Address(RVA = "0x403830", Offset = "0x402230", VA = "0x180403830")]
			get
			{
				return Cooker.CookerType.Empty;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060038A0 RID: 14496 RVA: 0x000156A8 File Offset: 0x000138A8
		[Token(Token = "0x170007B5")]
		public Cooker.CookerSeries Series
		{
			[Token(Token = "0x60038A0")]
			[Address(RVA = "0x4506E0", Offset = "0x44F0E0", VA = "0x1804506E0")]
			get
			{
				return Cooker.CookerSeries.Base;
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x060038A1 RID: 14497 RVA: 0x000156C0 File Offset: 0x000138C0
		[Token(Token = "0x170007B6")]
		public bool CanOpenByPartner
		{
			[Token(Token = "0x60038A1")]
			[Address(RVA = "0x680430", Offset = "0x67EE30", VA = "0x180680430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x060038A2 RID: 14498 RVA: 0x000156D8 File Offset: 0x000138D8
		[Token(Token = "0x170007B7")]
		public bool CookTimeMultiplierCanUseByPartner
		{
			[Token(Token = "0x60038A2")]
			[Address(RVA = "0x6804F0", Offset = "0x67EEF0", VA = "0x1806804F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x060038A3 RID: 14499 RVA: 0x000156F0 File Offset: 0x000138F0
		[Token(Token = "0x170007B8")]
		public float CookTimeMultiplier
		{
			[Token(Token = "0x60038A3")]
			[Address(RVA = "0x680510", Offset = "0x67EF10", VA = "0x180680510")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x060038A4 RID: 14500 RVA: 0x00015708 File Offset: 0x00013908
		[Token(Token = "0x170007B9")]
		public float AdditiveNextOrderProb
		{
			[Token(Token = "0x60038A4")]
			[Address(RVA = "0x6802E0", Offset = "0x67ECE0", VA = "0x1806802E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x060038A5 RID: 14501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BA")]
		public AnimatedTile Idle
		{
			[Token(Token = "0x60038A5")]
			[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x060038A6 RID: 14502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BB")]
		public AnimatedTile Loaded
		{
			[Token(Token = "0x60038A6")]
			[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060038A7 RID: 14503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BC")]
		public AnimatedTile Cooking
		{
			[Token(Token = "0x60038A7")]
			[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x060038A8 RID: 14504 RVA: 0x00015720 File Offset: 0x00013920
		[Token(Token = "0x170007BD")]
		public float IlluminationIntensity
		{
			[Token(Token = "0x60038A8")]
			[Address(RVA = "0x680550", Offset = "0x67EF50", VA = "0x180680550")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060038A9 RID: 14505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007BE")]
		public AudioClip OpenCookSFX
		{
			[Token(Token = "0x60038A9")]
			[Address(RVA = "0x440270", Offset = "0x43EC70", VA = "0x180440270")]
			get
			{
				return null;
			}
		}

		// Token: 0x060038AA RID: 14506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038AA")]
		[Address(RVA = "0x67FE00", Offset = "0x67E800", VA = "0x18067FE00")]
		public AudioClip GetStartCookSFX(Cooker.CookerType cookerType)
		{
			return null;
		}

		// Token: 0x060038AB RID: 14507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038AB")]
		[Address(RVA = "0x67FE40", Offset = "0x67E840", VA = "0x18067FE40", Slot = "8")]
		protected override ObjectLanguageBase GetText(int id)
		{
			return null;
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060038AC RID: 14508 RVA: 0x00015738 File Offset: 0x00013938
		[Token(Token = "0x170007BF")]
		private bool CanTriggerSpecialCookerSkill
		{
			[Token(Token = "0x60038AC")]
			[Address(RVA = "0x680450", Offset = "0x67EE50", VA = "0x180680450")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038AD")]
		[Address(RVA = "0x680090", Offset = "0x67EA90", VA = "0x180680090")]
		public IEnumerable<IEnumerable<NormalGuest>> OnGetNormalGuests(IEnumerable<IEnumerable<NormalGuest>> preFillteredGuests)
		{
			return null;
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038AE")]
		[Address(RVA = "0x680030", Offset = "0x67EA30", VA = "0x180680030")]
		public IEnumerable<WorkSceneCookingSelectionPannel.MatchedCookCombo> OnGetCookerOutput(IEnumerable<WorkSceneCookingSelectionPannel.MatchedCookCombo> preFillteredRecipe)
		{
			return null;
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x00015750 File Offset: 0x00013950
		[Token(Token = "0x60038AF")]
		[Address(RVA = "0x67FD80", Offset = "0x67E780", VA = "0x18067FD80")]
		public float GetExtraCookSpeedMultiplier(CookController targetCooker, Sellable sellable)
		{
			return 0f;
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x00015768 File Offset: 0x00013968
		[Token(Token = "0x60038B0")]
		[Address(RVA = "0x67FD20", Offset = "0x67E720", VA = "0x18067FD20")]
		public float GetExtraAdditiveNextOrderProb(Sellable sellable)
		{
			return 0f;
		}

		// Token: 0x060038B1 RID: 14513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038B1")]
		[Address(RVA = "0x680140", Offset = "0x67EB40", VA = "0x180680140")]
		public void OnStartCook()
		{
		}

		// Token: 0x060038B2 RID: 14514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B2")]
		[Address(RVA = "0x67FFB0", Offset = "0x67E9B0", VA = "0x18067FFB0")]
		public Sellable OnFinishCook(Sellable finishedFood, float qteScore, bool couldReturnIngredients)
		{
			return null;
		}

		// Token: 0x060038B3 RID: 14515 RVA: 0x00015780 File Offset: 0x00013980
		[Token(Token = "0x60038B3")]
		[Address(RVA = "0x67FF30", Offset = "0x67E930", VA = "0x18067FF30")]
		public int OnEvaluate(int evaluationResult, GuestGroupController guestGroupController, Sellable serveFood)
		{
			return 0;
		}

		// Token: 0x060038B4 RID: 14516 RVA: 0x00015798 File Offset: 0x00013998
		[Token(Token = "0x60038B4")]
		[Address(RVA = "0x680180", Offset = "0x67EB80", VA = "0x180680180")]
		public bool ShouldShowThisCookerBG(Sellable outputFood)
		{
			return default(bool);
		}

		// Token: 0x060038B5 RID: 14517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038B5")]
		[Address(RVA = "0x6800F0", Offset = "0x67EAF0", VA = "0x1806800F0")]
		public void OnPlayerFinishExtract(CookController targetCooker)
		{
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038B6")]
		[Address(RVA = "0x6801E0", Offset = "0x67EBE0", VA = "0x1806801E0")]
		public void WhenPlayerTryExtractWithFullTray(CookController targetCooker)
		{
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060038B7 RID: 14519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C0")]
		public override Sprite BGSprite
		{
			[Token(Token = "0x60038B7")]
			[Address(RVA = "0x680420", Offset = "0x67EE20", VA = "0x180680420", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038B8")]
		[Address(RVA = "0x67FBF0", Offset = "0x67E5F0", VA = "0x18067FBF0", Slot = "7")]
		public override object Clone()
		{
			return null;
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060038B9 RID: 14521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C1")]
		public IEnumerable<Cooker.CookerType> AllAvailableCookerType
		{
			[Token(Token = "0x60038B9")]
			[Address(RVA = "0x680320", Offset = "0x67ED20", VA = "0x180680320")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060038BA RID: 14522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C2")]
		public string OverrideTypeName
		{
			[Token(Token = "0x60038BA")]
			[Address(RVA = "0x680560", Offset = "0x67EF60", VA = "0x180680560")]
			get
			{
				return null;
			}
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038BB")]
		[Address(RVA = "0x67FF00", Offset = "0x67E900", VA = "0x18067FF00")]
		public void OnCookerWorkTimeUpdate(CookController targetCooker, float oldWorkTime)
		{
		}

		// Token: 0x0400304B RID: 12363
		[Token(Token = "0x400304B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Cooker.CookerType type;

		// Token: 0x0400304C RID: 12364
		[Token(Token = "0x400304C")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Cooker.CookerSeries cookerSeries;

		// Token: 0x0400304D RID: 12365
		[Token(Token = "0x400304D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CookerAssetBase cookerAsset;

		// Token: 0x0400304E RID: 12366
		[Token(Token = "0x400304E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimatedTile idle;

		// Token: 0x0400304F RID: 12367
		[Token(Token = "0x400304F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimatedTile loaded;

		// Token: 0x04003050 RID: 12368
		[Token(Token = "0x4003050")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimatedTile cooking;

		// Token: 0x04003051 RID: 12369
		[Token(Token = "0x4003051")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float illuminationIntensity;

		// Token: 0x04003052 RID: 12370
		[Token(Token = "0x4003052")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AudioClip startCookSFX;

		// Token: 0x04003053 RID: 12371
		[Token(Token = "0x4003053")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[CanBeNull]
		private AudioClip openCookSFX;

		// Token: 0x04003054 RID: 12372
		[Token(Token = "0x4003054")]
		private const int EMPTY_DESK = -1;

		// Token: 0x020008E4 RID: 2276
		[Token(Token = "0x20008E4")]
		public enum CookerSeries
		{
			// Token: 0x04003056 RID: 12374
			[Token(Token = "0x4003056")]
			Base,
			// Token: 0x04003057 RID: 12375
			[Token(Token = "0x4003057")]
			Sparrow,
			// Token: 0x04003058 RID: 12376
			[Token(Token = "0x4003058")]
			Super,
			// Token: 0x04003059 RID: 12377
			[Token(Token = "0x4003059")]
			Extreme,
			// Token: 0x0400305A RID: 12378
			[Token(Token = "0x400305A")]
			Nuclear,
			// Token: 0x0400305B RID: 12379
			[Token(Token = "0x400305B")]
			Suspicious,
			// Token: 0x0400305C RID: 12380
			[Token(Token = "0x400305C")]
			Tsukimi,
			// Token: 0x0400305D RID: 12381
			[Token(Token = "0x400305D")]
			StarMagicPot = 1000,
			// Token: 0x0400305E RID: 12382
			[Token(Token = "0x400305E")]
			PureHellFryer = 2000,
			// Token: 0x0400305F RID: 12383
			[Token(Token = "0x400305F")]
			SamadhiFire = 3000,
			// Token: 0x04003060 RID: 12384
			[Token(Token = "0x4003060")]
			PeerlessWindGod = 4000,
			// Token: 0x04003061 RID: 12385
			[Token(Token = "0x4003061")]
			ByakurenCuttingBoard = 5000,
			// Token: 0x04003062 RID: 12386
			[Token(Token = "0x4003062")]
			Trinity
		}

		// Token: 0x020008E5 RID: 2277
		[Token(Token = "0x20008E5")]
		public enum CookerType
		{
			// Token: 0x04003064 RID: 12388
			[Token(Token = "0x4003064")]
			Empty,
			// Token: 0x04003065 RID: 12389
			[Token(Token = "0x4003065")]
			Pot,
			// Token: 0x04003066 RID: 12390
			[Token(Token = "0x4003066")]
			Grill,
			// Token: 0x04003067 RID: 12391
			[Token(Token = "0x4003067")]
			Fryer,
			// Token: 0x04003068 RID: 12392
			[Token(Token = "0x4003068")]
			Steamer,
			// Token: 0x04003069 RID: 12393
			[Token(Token = "0x4003069")]
			CuttingBoard
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Common.CharacterUtility;
using DayScene.Input;
using GameData.Core.Collections;
using Il2CppDummyDll;
using JetBrains.Annotations;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using NightScene.Tiles;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CC2 RID: 3266
	[Token(Token = "0x2000CC2")]
	public abstract class PartnerInfoBase : ScriptableObject
	{
		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06004C01 RID: 19457 RVA: 0x0001B768 File Offset: 0x00019968
		[Token(Token = "0x17000AEE")]
		public int PartnerId
		{
			[Token(Token = "0x6004C01")]
			[Address(RVA = "0x403830", Offset = "0x402230", VA = "0x180403830")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06004C02 RID: 19458 RVA: 0x0001B780 File Offset: 0x00019980
		[Token(Token = "0x17000AEF")]
		public float PartnerCut
		{
			[Token(Token = "0x6004C02")]
			[Address(RVA = "0x43B0A0", Offset = "0x439AA0", VA = "0x18043B0A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06004C03 RID: 19459 RVA: 0x0001B798 File Offset: 0x00019998
		[Token(Token = "0x17000AF0")]
		public float AddToInventoryDelay
		{
			[Token(Token = "0x6004C03")]
			[Address(RVA = "0x4506D0", Offset = "0x44F0D0", VA = "0x1804506D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06004C04 RID: 19460 RVA: 0x0001B7B0 File Offset: 0x000199B0
		[Token(Token = "0x17000AF1")]
		public float ExtractFromInventoryDelay
		{
			[Token(Token = "0x6004C04")]
			[Address(RVA = "0x4506C0", Offset = "0x44F0C0", VA = "0x1804506C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06004C05 RID: 19461 RVA: 0x0001B7C8 File Offset: 0x000199C8
		[Token(Token = "0x17000AF2")]
		public float DeliverDelay
		{
			[Token(Token = "0x6004C05")]
			[Address(RVA = "0x68E920", Offset = "0x68D320", VA = "0x18068E920")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06004C06 RID: 19462 RVA: 0x0001B7E0 File Offset: 0x000199E0
		[Token(Token = "0x17000AF3")]
		public PartnerInfoBase.Speed WorkSpeedLiteral
		{
			[Token(Token = "0x6004C06")]
			[Address(RVA = "0x79D9A0", Offset = "0x79C3A0", VA = "0x18079D9A0")]
			get
			{
				return PartnerInfoBase.Speed.Slow;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06004C07 RID: 19463 RVA: 0x0001B7F8 File Offset: 0x000199F8
		[Token(Token = "0x17000AF4")]
		public virtual float MoveSpdMultiplier
		{
			[Token(Token = "0x6004C07")]
			[Address(RVA = "0x79D850", Offset = "0x79C250", VA = "0x18079D850", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06004C08 RID: 19464 RVA: 0x0001B810 File Offset: 0x00019A10
		[Token(Token = "0x17000AF5")]
		public bool NotUseCollider
		{
			[Token(Token = "0x6004C08")]
			[Address(RVA = "0x494130", Offset = "0x492B30", VA = "0x180494130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06004C09 RID: 19465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF6")]
		public IEnumerable<int> BanGuestId
		{
			[Token(Token = "0x6004C09")]
			[Address(RVA = "0x79D740", Offset = "0x79C140", VA = "0x18079D740")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06004C0A RID: 19466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF7")]
		public PartnerInfoBase.CompanionProperty[] CompanionPartners
		{
			[Token(Token = "0x6004C0A")]
			[Address(RVA = "0x79D7C0", Offset = "0x79C1C0", VA = "0x18079D7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06004C0B RID: 19467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF8")]
		protected Transform UiAnimationFieldFront
		{
			[Token(Token = "0x6004C0B")]
			[Address(RVA = "0x79D8C0", Offset = "0x79C2C0", VA = "0x18079D8C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06004C0C RID: 19468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AF9")]
		protected Transform UiAnimationFieldTop
		{
			[Token(Token = "0x6004C0C")]
			[Address(RVA = "0x79D950", Offset = "0x79C350", VA = "0x18079D950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06004C0D RID: 19469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFA")]
		protected Transform UiAnimationFieldMiddle
		{
			[Token(Token = "0x6004C0D")]
			[Address(RVA = "0x79D910", Offset = "0x79C310", VA = "0x18079D910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06004C0E RID: 19470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AFB")]
		protected Transform UiAnimationFieldBack
		{
			[Token(Token = "0x6004C0E")]
			[Address(RVA = "0x79D880", Offset = "0x79C280", VA = "0x18079D880")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06004C0F RID: 19471 RVA: 0x0001B828 File Offset: 0x00019A28
		[Token(Token = "0x17000AFC")]
		public virtual bool IfNeverWork
		{
			[Token(Token = "0x6004C0F")]
			[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06004C10 RID: 19472 RVA: 0x0001B840 File Offset: 0x00019A40
		[Token(Token = "0x17000AFD")]
		public virtual bool HasWorkSleepLoop
		{
			[Token(Token = "0x6004C10")]
			[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06004C11 RID: 19473 RVA: 0x0001B858 File Offset: 0x00019A58
		[Token(Token = "0x17000AFE")]
		protected virtual Vector2Int WorkTime
		{
			[Token(Token = "0x6004C11")]
			[Address(RVA = "0x684620", Offset = "0x683020", VA = "0x180684620", Slot = "7")]
			get
			{
				return default(Vector2Int);
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06004C12 RID: 19474 RVA: 0x0001B870 File Offset: 0x00019A70
		[Token(Token = "0x17000AFF")]
		protected virtual Vector2Int SleepTime
		{
			[Token(Token = "0x6004C12")]
			[Address(RVA = "0x684620", Offset = "0x683020", VA = "0x180684620", Slot = "8")]
			get
			{
				return default(Vector2Int);
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06004C13 RID: 19475 RVA: 0x0001B888 File Offset: 0x00019A88
		[Token(Token = "0x17000B00")]
		public virtual PartnerInfoBase.DeliverType PartnerDeliverType
		{
			[Token(Token = "0x6004C13")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "9")]
			get
			{
				return PartnerInfoBase.DeliverType.Normal;
			}
		}

		// Token: 0x06004C14 RID: 19476 RVA: 0x0001B8A0 File Offset: 0x00019AA0
		[Token(Token = "0x6004C14")]
		[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "10")]
		public virtual PartnerInfoBase.PartnerType GetPartnerType()
		{
			return PartnerInfoBase.PartnerType.Normal;
		}

		// Token: 0x06004C15 RID: 19477 RVA: 0x0001B8B8 File Offset: 0x00019AB8
		[Token(Token = "0x6004C15")]
		[Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		protected Vector3 GetWorldToScreenPoint(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06004C16 RID: 19478 RVA: 0x0001B8D0 File Offset: 0x00019AD0
		[Token(Token = "0x6004C16")]
		[Address(RVA = "0x79D390", Offset = "0x79BD90", VA = "0x18079D390", Slot = "11")]
		public virtual float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseSpeed, ref bool doNotCostIngredients)
		{
			return 0f;
		}

		// Token: 0x06004C17 RID: 19479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C17")]
		[Address(RVA = "0x79D3A0", Offset = "0x79BDA0", VA = "0x18079D3A0", Slot = "12")]
		public virtual Sellable OnGetOverrideFinalCookResult(CookController cooker, Sellable lastFood, out bool isRequestedFood)
		{
			return null;
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06004C18 RID: 19480 RVA: 0x0001B8E8 File Offset: 0x00019AE8
		[Token(Token = "0x17000B01")]
		protected virtual int AdditionalDataRequirement
		{
			[Token(Token = "0x6004C18")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06004C19 RID: 19481 RVA: 0x0001B900 File Offset: 0x00019B00
		[Token(Token = "0x17000B02")]
		public int TotalAdditionalDataRequirement
		{
			[Token(Token = "0x6004C19")]
			[Address(RVA = "0x79D860", Offset = "0x79C260", VA = "0x18079D860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1A")]
		[Address(RVA = "0x79D400", Offset = "0x79BE00", VA = "0x18079D400")]
		public void PreloadPartner(PartnerBase currentPartner, EventManager eventManager, PartnerManager manager, object[] additionalData)
		{
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C1B")]
		[Address(RVA = "0x79CC60", Offset = "0x79B660", VA = "0x18079CC60", Slot = "14")]
		public virtual ValueTuple<PartnerInfoBase.CompanionProperty, PartnerBase.PartnerType>[] GetCompanionPartnerType(PartnerBase currentPartner)
		{
			return null;
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1C")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "15")]
		public virtual void OnInventoryUpdate(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager)
		{
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C1D")]
		[Address(RVA = "0x79D690", Offset = "0x79C090", VA = "0x18079D690")]
		private IEnumerator WorkSleepLoop(PartnerBase currentPartner, object[] additionalData)
		{
			return null;
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1E")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "16")]
		protected virtual void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, object[] additionalData)
		{
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C1F")]
		[Address(RVA = "0x79D5D0", Offset = "0x79BFD0", VA = "0x18079D5D0")]
		public void ReleasePartner(PartnerManager partnerManager, object[] additionalData)
		{
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C20")]
		[Address(RVA = "0x79D1D0", Offset = "0x79BBD0", VA = "0x18079D1D0", Slot = "17")]
		public virtual void MoveCharacter(AStarInputGeneratorComponent controlledCharacter, TileManager tileManager, Vector3Int dest, Vector3 extraOffset, DayScenePlayerInputGenerator.CharacterRotation onArrivalRotation, Action onArrivalCallback, PartnerManager manager, bool haveCollision, ref object partnerMovementAdditionData)
		{
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C21")]
		[Address(RVA = "0x4EA490", Offset = "0x4E8E90", VA = "0x1804EA490", Slot = "18")]
		public virtual void ExternalStop(AStarInputGeneratorComponent controlledCharacter, PartnerManager manager, ref object partnerMovementAdditionData)
		{
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C22")]
		[Address(RVA = "0x79D3B0", Offset = "0x79BDB0", VA = "0x18079D3B0")]
		protected void PlayAudio(AudioClip audioClip)
		{
		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C23")]
		[Address(RVA = "0x79CE30", Offset = "0x79B830", VA = "0x18079CE30")]
		public string GetText(bool showFullText)
		{
			return null;
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C24")]
		[Address(RVA = "0x79CC10", Offset = "0x79B610", VA = "0x18079CC10")]
		protected static string FormatString(string data)
		{
			return null;
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C25")]
		[Address(RVA = "0x79CD60", Offset = "0x79B760", VA = "0x18079CD60")]
		protected static string GetSpeedLang(PartnerInfoBase.Speed speed)
		{
			return null;
		}

		// Token: 0x06004C26 RID: 19494
		[Token(Token = "0x6004C26")]
		protected abstract string GetMoveSpeedText();

		// Token: 0x06004C27 RID: 19495
		[Token(Token = "0x6004C27")]
		protected abstract string GetWorkSpeedText();

		// Token: 0x06004C28 RID: 19496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C28")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "21")]
		protected virtual void PreProcessInfo([NotNull] StringBuilder builder)
		{
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C29")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "22")]
		protected virtual void PostProcessInfo([NotNull] StringBuilder builder)
		{
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06004C2A RID: 19498 RVA: 0x0001B918 File Offset: 0x00019B18
		[Token(Token = "0x17000B03")]
		protected virtual bool DoNotShowRevenueCut
		{
			[Token(Token = "0x6004C2A")]
			[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004C2B RID: 19499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C2B")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		protected PartnerInfoBase()
		{
		}

		// Token: 0x040045FA RID: 17914
		[Token(Token = "0x40045FA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int partnerId;

		// Token: 0x040045FB RID: 17915
		[Token(Token = "0x40045FB")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float partnerCut;

		// Token: 0x040045FC RID: 17916
		[Token(Token = "0x40045FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float addToInventoryDelay;

		// Token: 0x040045FD RID: 17917
		[Token(Token = "0x40045FD")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float extractFromInventoryDelay;

		// Token: 0x040045FE RID: 17918
		[Token(Token = "0x40045FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float deliverDelay;

		// Token: 0x040045FF RID: 17919
		[Token(Token = "0x40045FF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public int[] banSGuestToSpawnId;

		// Token: 0x04004600 RID: 17920
		[Token(Token = "0x4004600")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("伴生伙伴")]
		[SerializeField]
		private PartnerInfoBase.CompanionProperty[] companionPartners;

		// Token: 0x04004601 RID: 17921
		[Token(Token = "0x4004601")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool notUseCollider;

		// Token: 0x04004602 RID: 17922
		[Token(Token = "0x4004602")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private PartnerInfoBase.Speed workSpeedLiteral;

		// Token: 0x04004603 RID: 17923
		[Token(Token = "0x4004603")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float moveSpdMultiplier;

		// Token: 0x02000CC3 RID: 3267
		[Token(Token = "0x2000CC3")]
		public enum CompanionType
		{
			// Token: 0x04004605 RID: 17925
			[Token(Token = "0x4004605")]
			[InspectorName("并排")]
			SideBySide,
			// Token: 0x04004606 RID: 17926
			[Token(Token = "0x4004606")]
			[InspectorName("浑然一体")]
			BlendTogether,
			// Token: 0x04004607 RID: 17927
			[Token(Token = "0x4004607")]
			[InspectorName("赤蛮奇")]
			Sekibanki
		}

		// Token: 0x02000CC4 RID: 3268
		[Token(Token = "0x2000CC4")]
		public enum DeliverType
		{
			// Token: 0x04004609 RID: 17929
			[Token(Token = "0x4004609")]
			Normal,
			// Token: 0x0400460A RID: 17930
			[Token(Token = "0x400460A")]
			Throw
		}

		// Token: 0x02000CC5 RID: 3269
		[Token(Token = "0x2000CC5")]
		public enum PartnerType
		{
			// Token: 0x0400460C RID: 17932
			[Token(Token = "0x400460C")]
			Normal,
			// Token: 0x0400460D RID: 17933
			[Token(Token = "0x400460D")]
			Boss
		}

		// Token: 0x02000CC6 RID: 3270
		[Token(Token = "0x2000CC6")]
		public enum Speed
		{
			// Token: 0x0400460F RID: 17935
			[Token(Token = "0x400460F")]
			Slow,
			// Token: 0x04004610 RID: 17936
			[Token(Token = "0x4004610")]
			Medium,
			// Token: 0x04004611 RID: 17937
			[Token(Token = "0x4004611")]
			Fast,
			// Token: 0x04004612 RID: 17938
			[Token(Token = "0x4004612")]
			None
		}

		// Token: 0x02000CC7 RID: 3271
		[Token(Token = "0x2000CC7")]
		public enum WorkState
		{
			// Token: 0x04004614 RID: 17940
			[Token(Token = "0x4004614")]
			InWork,
			// Token: 0x04004615 RID: 17941
			[Token(Token = "0x4004615")]
			Sleep,
			// Token: 0x04004616 RID: 17942
			[Token(Token = "0x4004616")]
			FocusOnOtherThing
		}

		// Token: 0x02000CC8 RID: 3272
		[Token(Token = "0x2000CC8")]
		[Serializable]
		public struct CompanionProperty
		{
			// Token: 0x17000B04 RID: 2820
			// (get) Token: 0x06004C2C RID: 19500 RVA: 0x0001B930 File Offset: 0x00019B30
			[Token(Token = "0x17000B04")]
			public int CompanionPartnerId
			{
				[Token(Token = "0x6004C2C")]
				[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000B05 RID: 2821
			// (get) Token: 0x06004C2D RID: 19501 RVA: 0x0001B948 File Offset: 0x00019B48
			[Token(Token = "0x17000B05")]
			public int MappingIndex
			{
				[Token(Token = "0x6004C2D")]
				[Address(RVA = "0x43B0B0", Offset = "0x439AB0", VA = "0x18043B0B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000B06 RID: 2822
			// (get) Token: 0x06004C2E RID: 19502 RVA: 0x0001B960 File Offset: 0x00019B60
			[Token(Token = "0x17000B06")]
			public PartnerInfoBase.CompanionType Type
			{
				[Token(Token = "0x6004C2E")]
				[Address(RVA = "0x48B8C0", Offset = "0x48A2C0", VA = "0x18048B8C0")]
				get
				{
					return PartnerInfoBase.CompanionType.SideBySide;
				}
			}

			// Token: 0x04004617 RID: 17943
			[Token(Token = "0x4004617")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private int companionPartnerId;

			// Token: 0x04004618 RID: 17944
			[Token(Token = "0x4004618")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			private int mappingIndex;

			// Token: 0x04004619 RID: 17945
			[Token(Token = "0x4004619")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private PartnerInfoBase.CompanionType companionType;
		}
	}
}

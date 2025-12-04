using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.CharacterUtility
{
	// Token: 0x02000B5D RID: 2909
	[Token(Token = "0x2000B5D")]
	public class CharacterSpriteSetCompact : ScriptableObject
	{
		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06004536 RID: 17718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009CF")]
		public Sprite[] MainSprite
		{
			[Token(Token = "0x6004536")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06004537 RID: 17719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D0")]
		public Sprite[] EyeSprite
		{
			[Token(Token = "0x6004537")]
			[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06004538 RID: 17720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D1")]
		public virtual Sprite[] HairSprite
		{
			[Token(Token = "0x6004538")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06004539 RID: 17721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D2")]
		public virtual Sprite[] BackSprite
		{
			[Token(Token = "0x6004539")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x0600453A RID: 17722 RVA: 0x00018F90 File Offset: 0x00017190
		[Token(Token = "0x170009D3")]
		public CharacterSpriteSetCompact.Type SpriteType
		{
			[Token(Token = "0x600453A")]
			[Address(RVA = "0x4404D0", Offset = "0x43EED0", VA = "0x1804404D0")]
			get
			{
				return CharacterSpriteSetCompact.Type.Compact;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x0600453B RID: 17723 RVA: 0x00018FA8 File Offset: 0x000171A8
		[Token(Token = "0x170009D4")]
		public bool HasPrebakedShadow
		{
			[Token(Token = "0x600453B")]
			[Address(RVA = "0x44FC20", Offset = "0x44E620", VA = "0x18044FC20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x0600453C RID: 17724 RVA: 0x00018FC0 File Offset: 0x000171C0
		[Token(Token = "0x170009D5")]
		public float AnimationSpeedMultiplier
		{
			[Token(Token = "0x600453C")]
			[Address(RVA = "0x734060", Offset = "0x732A60", VA = "0x180734060")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x0600453D RID: 17725 RVA: 0x00018FD8 File Offset: 0x000171D8
		[Token(Token = "0x170009D6")]
		public float MoveSpeedMultiplier
		{
			[Token(Token = "0x600453D")]
			[Address(RVA = "0x7340A0", Offset = "0x732AA0", VA = "0x1807340A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x0600453E RID: 17726 RVA: 0x00018FF0 File Offset: 0x000171F0
		[Token(Token = "0x170009D7")]
		public float ExtraYOffset
		{
			[Token(Token = "0x600453E")]
			[Address(RVA = "0x440510", Offset = "0x43EF10", VA = "0x180440510")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x0600453F RID: 17727 RVA: 0x00019008 File Offset: 0x00017208
		[Token(Token = "0x170009D8")]
		public bool IsHina
		{
			[Token(Token = "0x600453F")]
			[Address(RVA = "0x494130", Offset = "0x492B30", VA = "0x180494130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06004540 RID: 17728 RVA: 0x00019020 File Offset: 0x00017220
		[Token(Token = "0x170009D9")]
		public float RotatePerTime
		{
			[Token(Token = "0x6004540")]
			[Address(RVA = "0x7340B0", Offset = "0x732AB0", VA = "0x1807340B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06004541 RID: 17729 RVA: 0x00019038 File Offset: 0x00017238
		[Token(Token = "0x170009DA")]
		public bool DoNotHaveStepVFX
		{
			[Token(Token = "0x6004541")]
			[Address(RVA = "0x734090", Offset = "0x732A90", VA = "0x180734090")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06004542 RID: 17730 RVA: 0x00019050 File Offset: 0x00017250
		[Token(Token = "0x170009DB")]
		public bool DoNotUseEyeSprite
		{
			[Token(Token = "0x6004542")]
			[Address(RVA = "0x51B640", Offset = "0x51A040", VA = "0x18051B640")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06004543 RID: 17731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DC")]
		public CharacterSpriteSetCompact.RemovableTrimProperty[] RemovableTrims
		{
			[Token(Token = "0x6004543")]
			[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06004544 RID: 17732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DD")]
		public Sprite[] TrimSpritesDisplayFront
		{
			[Token(Token = "0x6004544")]
			[Address(RVA = "0x48B8D0", Offset = "0x48A2D0", VA = "0x18048B8D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06004545 RID: 17733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DE")]
		public Sprite TrimSpriteDisplayFrontInCard
		{
			[Token(Token = "0x6004545")]
			[Address(RVA = "0x7341A0", Offset = "0x732BA0", VA = "0x1807341A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06004546 RID: 17734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DF")]
		public Sprite[] TrimSpritesDisplayBack
		{
			[Token(Token = "0x6004546")]
			[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E0")]
		public Sprite TrimSpriteDisplayBackInCard
		{
			[Token(Token = "0x6004547")]
			[Address(RVA = "0x734160", Offset = "0x732B60", VA = "0x180734160")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06004548 RID: 17736 RVA: 0x00019068 File Offset: 0x00017268
		[Token(Token = "0x170009E1")]
		public float TrimFrontSpriteFrameSpeed
		{
			[Token(Token = "0x6004548")]
			[Address(RVA = "0x477F30", Offset = "0x476930", VA = "0x180477F30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06004549 RID: 17737 RVA: 0x00019080 File Offset: 0x00017280
		[Token(Token = "0x170009E2")]
		public float TrimBackSpriteFrameSpeed
		{
			[Token(Token = "0x6004549")]
			[Address(RVA = "0x477F40", Offset = "0x476940", VA = "0x180477F40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x0600454A RID: 17738 RVA: 0x00019098 File Offset: 0x00017298
		[Token(Token = "0x170009E3")]
		public bool ShouldDisplayFront
		{
			[Token(Token = "0x600454A")]
			[Address(RVA = "0x734100", Offset = "0x732B00", VA = "0x180734100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x0600454B RID: 17739 RVA: 0x000190B0 File Offset: 0x000172B0
		[Token(Token = "0x170009E4")]
		public bool ShouldDisplayBack
		{
			[Token(Token = "0x600454B")]
			[Address(RVA = "0x7340C0", Offset = "0x732AC0", VA = "0x1807340C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x0600454C RID: 17740 RVA: 0x000190C8 File Offset: 0x000172C8
		[Token(Token = "0x170009E5")]
		public Vector2 DaySceneInteractableHighlightOffset
		{
			[Token(Token = "0x600454C")]
			[Address(RVA = "0x734070", Offset = "0x732A70", VA = "0x180734070")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x0600454D RID: 17741 RVA: 0x000190E0 File Offset: 0x000172E0
		[Token(Token = "0x170009E6")]
		public float DaySceneInteractableColliderAdditiveRadius
		{
			[Token(Token = "0x600454D")]
			[Address(RVA = "0x440540", Offset = "0x43EF40", VA = "0x180440540")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x0600454E RID: 17742 RVA: 0x000190F8 File Offset: 0x000172F8
		[Token(Token = "0x170009E7")]
		public Vector2 SpriteOffsetInNoteBook
		{
			[Token(Token = "0x600454E")]
			[Address(RVA = "0x734140", Offset = "0x732B40", VA = "0x180734140")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600454F")]
		[Address(RVA = "0x733E90", Offset = "0x732890", VA = "0x180733E90")]
		public void Initialize(Sprite[] mainSprite, bool doNotUseEyeSprite, Sprite[] eyeSprite, bool hasPrebakedShadow, float animSpeedMultiplier, float extraYOffset, bool isHina, float rotatePerTime, bool doNotHaveStepVFX, float moveSpeedMultiplier, CharacterSpriteSetCompact.RemovableTrimProperty[] removableTrims, Sprite[] trimSpritesDisplayFront, Sprite[] trimSpritesDisplayBack, float trimFrontSpriteFrameSpeed, float trimBackSpriteFrameSpeed)
		{
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004550")]
		[Address(RVA = "0x733FD0", Offset = "0x7329D0", VA = "0x180733FD0")]
		public CharacterSpriteSetCompact()
		{
		}

		// Token: 0x04003D67 RID: 15719
		[Token(Token = "0x4003D67")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite[] mainSprite;

		// Token: 0x04003D68 RID: 15720
		[Token(Token = "0x4003D68")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool doNotUseEyeSprite;

		// Token: 0x04003D69 RID: 15721
		[Token(Token = "0x4003D69")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite[] eyeSprite;

		// Token: 0x04003D6A RID: 15722
		[Token(Token = "0x4003D6A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool hasPrebakedShadow;

		// Token: 0x04003D6B RID: 15723
		[Token(Token = "0x4003D6B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float animSpeedMultiplier;

		// Token: 0x04003D6C RID: 15724
		[Token(Token = "0x4003D6C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float moveSpeedMultiplier;

		// Token: 0x04003D6D RID: 15725
		[Token(Token = "0x4003D6D")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float extraYOffset;

		// Token: 0x04003D6E RID: 15726
		[Token(Token = "0x4003D6E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool isHina;

		// Token: 0x04003D6F RID: 15727
		[Token(Token = "0x4003D6F")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float rotatePerTime;

		// Token: 0x04003D70 RID: 15728
		[Token(Token = "0x4003D70")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool doNotHaveStepVFX;

		// Token: 0x04003D71 RID: 15729
		[Token(Token = "0x4003D71")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Vector2 daySceneInteractableHighlightOffset;

		// Token: 0x04003D72 RID: 15730
		[Token(Token = "0x4003D72")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float daySceneInteractableColliderAdditiveRadius;

		// Token: 0x04003D73 RID: 15731
		[Token(Token = "0x4003D73")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CharacterSpriteSetCompact.RemovableTrimProperty[] removableTrims;

		// Token: 0x04003D74 RID: 15732
		[Token(Token = "0x4003D74")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Sprite[] trimSpritesDisplayFront;

		// Token: 0x04003D75 RID: 15733
		[Token(Token = "0x4003D75")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Sprite[] trimSpritesDisplayBack;

		// Token: 0x04003D76 RID: 15734
		[Token(Token = "0x4003D76")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float trimFrontSpriteFrameSpeed;

		// Token: 0x04003D77 RID: 15735
		[Token(Token = "0x4003D77")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float trimBackSpriteFrameSpeed;

		// Token: 0x04003D78 RID: 15736
		[Token(Token = "0x4003D78")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector2 spriteOffsetInNoteBook;

		// Token: 0x04003D79 RID: 15737
		[Token(Token = "0x4003D79")]
		[FieldOffset(Offset = "0x80")]
		protected CharacterSpriteSetCompact.Type spriteType;

		// Token: 0x02000B5E RID: 2910
		[Token(Token = "0x2000B5E")]
		public enum Type
		{
			// Token: 0x04003D7B RID: 15739
			[Token(Token = "0x4003D7B")]
			Compact,
			// Token: 0x04003D7C RID: 15740
			[Token(Token = "0x4003D7C")]
			Full
		}

		// Token: 0x02000B5F RID: 2911
		[Token(Token = "0x2000B5F")]
		[Serializable]
		public struct RemovableTrimProperty
		{
			// Token: 0x170009E8 RID: 2536
			// (get) Token: 0x06004551 RID: 17745 RVA: 0x00019110 File Offset: 0x00017310
			[Token(Token = "0x170009E8")]
			public CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition RemovableTrimLayerIndex
			{
				[Token(Token = "0x6004551")]
				[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
				get
				{
					return CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition.BehindBack;
				}
			}

			// Token: 0x170009E9 RID: 2537
			// (get) Token: 0x06004552 RID: 17746 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009E9")]
			public CharacterSpriteSetCompact RemovableTrimCompact
			{
				[Token(Token = "0x6004552")]
				[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170009EA RID: 2538
			// (get) Token: 0x06004553 RID: 17747 RVA: 0x00019128 File Offset: 0x00017328
			[Token(Token = "0x170009EA")]
			public bool CanBeRemoved
			{
				[Token(Token = "0x6004553")]
				[Address(RVA = "0x420C60", Offset = "0x41F660", VA = "0x180420C60")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x04003D7D RID: 15741
			[Token(Token = "0x4003D7D")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition removableTrimLayerIndex;

			// Token: 0x04003D7E RID: 15742
			[Token(Token = "0x4003D7E")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private CharacterSpriteSetCompact removableTrimCompact;

			// Token: 0x04003D7F RID: 15743
			[Token(Token = "0x4003D7F")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool canNotBeRemoved;

			// Token: 0x02000B60 RID: 2912
			[Token(Token = "0x2000B60")]
			public enum TrimPosition
			{
				// Token: 0x04003D81 RID: 15745
				[Token(Token = "0x4003D81")]
				[InspectorName("背后")]
				BehindBack,
				// Token: 0x04003D82 RID: 15746
				[Token(Token = "0x4003D82")]
				[InspectorName("翅膀前，背后，仅限老板娘")]
				BehindBackAndFrontWing,
				// Token: 0x04003D83 RID: 15747
				[Token(Token = "0x4003D83")]
				[InspectorName("脸上（眼睛后）")]
				OnFace,
				// Token: 0x04003D84 RID: 15748
				[Token(Token = "0x4003D84")]
				[InspectorName("最前")]
				Front
			}
		}
	}
}

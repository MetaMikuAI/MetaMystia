using System;
using GameData.Core.Collections.CharacterUtility;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x020008F2 RID: 2290
	[Token(Token = "0x20008F2")]
	[Serializable]
	public class NormalGuest : GuestBase
	{
		// Token: 0x0600392D RID: 14637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600392D")]
		[Address(RVA = "0x688200", Offset = "0x686C00", VA = "0x180688200")]
		public NormalGuest(int id, float fundMultiplier, int evaluation, int[] likeFoodTag, int[] likeBevTag, int[] convGroup, bool isLikeAllFoodTag, bool isLikeAllBevTag, bool isChild, bool doNotShowInNotebook, GuestFoodEasterEggData guestFoodEasterEggData)
		{
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x0600392E RID: 14638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F3")]
		public override CharacterSpriteSetCompact CharacterPixel
		{
			[Token(Token = "0x600392E")]
			[Address(RVA = "0x688300", Offset = "0x686D00", VA = "0x180688300", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x0600392F RID: 14639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F4")]
		public override LanguageBase Text
		{
			[Token(Token = "0x600392F")]
			[Address(RVA = "0x6885D0", Offset = "0x686FD0", VA = "0x1806885D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06003930 RID: 14640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F5")]
		public override int[] LikeFoodTag
		{
			[Token(Token = "0x6003930")]
			[Address(RVA = "0x688560", Offset = "0x686F60", VA = "0x180688560", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06003931 RID: 14641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F6")]
		public int[] LikeBevTag
		{
			[Token(Token = "0x6003931")]
			[Address(RVA = "0x688400", Offset = "0x686E00", VA = "0x180688400")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06003932 RID: 14642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F7")]
		public string[] Evaluation
		{
			[Token(Token = "0x6003932")]
			[Address(RVA = "0x688360", Offset = "0x686D60", VA = "0x180688360")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06003933 RID: 14643 RVA: 0x00015B28 File Offset: 0x00013D28
		[Token(Token = "0x170007F8")]
		public float FundMultiplier
		{
			[Token(Token = "0x6003933")]
			[Address(RVA = "0x4506D0", Offset = "0x44F0D0", VA = "0x1804506D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06003934 RID: 14644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F9")]
		public int[] ConvGroupValue
		{
			[Token(Token = "0x6003934")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06003935 RID: 14645 RVA: 0x00015B40 File Offset: 0x00013D40
		[Token(Token = "0x170007FA")]
		public int EvaluationValue
		{
			[Token(Token = "0x6003935")]
			[Address(RVA = "0x440570", Offset = "0x43EF70", VA = "0x180440570")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06003936 RID: 14646 RVA: 0x00015B58 File Offset: 0x00013D58
		[Token(Token = "0x170007FB")]
		public bool IsChild
		{
			[Token(Token = "0x6003936")]
			[Address(RVA = "0x6883E0", Offset = "0x686DE0", VA = "0x1806883E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x00015B70 File Offset: 0x00013D70
		[Token(Token = "0x170007FC")]
		public bool IsLikeAllFoodTag
		{
			[Token(Token = "0x6003937")]
			[Address(RVA = "0x44F9B0", Offset = "0x44E3B0", VA = "0x18044F9B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06003938 RID: 14648 RVA: 0x00015B88 File Offset: 0x00013D88
		[Token(Token = "0x170007FD")]
		public bool IsLikeAllBevTag
		{
			[Token(Token = "0x6003938")]
			[Address(RVA = "0x6883F0", Offset = "0x686DF0", VA = "0x1806883F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06003939 RID: 14649 RVA: 0x00015BA0 File Offset: 0x00013DA0
		[Token(Token = "0x170007FE")]
		public bool DoNotShowInNotebook
		{
			[Token(Token = "0x6003939")]
			[Address(RVA = "0x688350", Offset = "0x686D50", VA = "0x180688350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600393A RID: 14650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007FF")]
		public GuestFoodEasterEggData GuestFoodEasterEggData
		{
			[Token(Token = "0x600393A")]
			[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x00015BB8 File Offset: 0x00013DB8
		[Token(Token = "0x600393B")]
		[Address(RVA = "0x6879F0", Offset = "0x6863F0", VA = "0x1806879F0", Slot = "9")]
		public override Vector2Int GetFundRange()
		{
			return default(Vector2Int);
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600393C")]
		[Address(RVA = "0x687AD0", Offset = "0x6864D0", VA = "0x180687AD0", Slot = "10")]
		protected override GuestProfilePair OnGetVisual(int id)
		{
			return null;
		}

		// Token: 0x0600393D RID: 14653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600393D")]
		[Address(RVA = "0x6879A0", Offset = "0x6863A0", VA = "0x1806879A0")]
		public string GenerateRandomConvMessage()
		{
			return null;
		}

		// Token: 0x0600393E RID: 14654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600393E")]
		[Address(RVA = "0x687B20", Offset = "0x686520", VA = "0x180687B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040030C0 RID: 12480
		[Token(Token = "0x40030C0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int[] convGroup;

		// Token: 0x040030C1 RID: 12481
		[Token(Token = "0x40030C1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float fundMultiplier;

		// Token: 0x040030C2 RID: 12482
		[Token(Token = "0x40030C2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int[] likeFoodTag;

		// Token: 0x040030C3 RID: 12483
		[Token(Token = "0x40030C3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int[] likeBevTag;

		// Token: 0x040030C4 RID: 12484
		[Token(Token = "0x40030C4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int evaluation;

		// Token: 0x040030C5 RID: 12485
		[Token(Token = "0x40030C5")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool isLikeAllFoodTag;

		// Token: 0x040030C6 RID: 12486
		[Token(Token = "0x40030C6")]
		[FieldOffset(Offset = "0x3D")]
		[SerializeField]
		private bool isLikeAllBevTag;

		// Token: 0x040030C7 RID: 12487
		[Token(Token = "0x40030C7")]
		[FieldOffset(Offset = "0x3E")]
		[SerializeField]
		private bool isChild;

		// Token: 0x040030C8 RID: 12488
		[Token(Token = "0x40030C8")]
		[FieldOffset(Offset = "0x3F")]
		[SerializeField]
		private bool doNotShowInNotebook;

		// Token: 0x040030C9 RID: 12489
		[Token(Token = "0x40030C9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[CanBeNull]
		private GuestFoodEasterEggData m_GuestFoodEasterEggData;
	}
}

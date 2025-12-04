using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections
{
	// Token: 0x020008DC RID: 2268
	[Token(Token = "0x20008DC")]
	[Serializable]
	public class Sellable : TradableObjectBase
	{
		// Token: 0x06003871 RID: 14449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003871")]
		[Address(RVA = "0x68B470", Offset = "0x689E70", VA = "0x18068B470")]
		public Sellable(int id, int baseValue, int level, int[] tags, int[] banTags, Sellable.SellableType type, List<int> additiveTags, bool isCollab)
		{
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06003872 RID: 14450 RVA: 0x000155A0 File Offset: 0x000137A0
		[Token(Token = "0x170007A9")]
		public bool IsCollab
		{
			[Token(Token = "0x6003872")]
			[Address(RVA = "0x685340", Offset = "0x683D40", VA = "0x180685340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x06003873 RID: 14451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AA")]
		public int[] BanTags
		{
			[Token(Token = "0x6003873")]
			[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06003874 RID: 14452 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003875 RID: 14453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007AB")]
		public int[] Modifier
		{
			[Token(Token = "0x6003874")]
			[Address(RVA = "0x68B6E0", Offset = "0x68A0E0", VA = "0x18068B6E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003875")]
			[Address(RVA = "0x6086D0", Offset = "0x6070D0", VA = "0x1806086D0")]
			set
			{
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06003876 RID: 14454 RVA: 0x000155B8 File Offset: 0x000137B8
		// (set) Token: 0x06003877 RID: 14455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007AC")]
		public Guid? RunTimeGUID
		{
			[Token(Token = "0x6003876")]
			[Address(RVA = "0x68B810", Offset = "0x68A210", VA = "0x18068B810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003877")]
			[Address(RVA = "0x68BC20", Offset = "0x68A620", VA = "0x18068BC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06003878 RID: 14456 RVA: 0x000155D0 File Offset: 0x000137D0
		[Token(Token = "0x170007AD")]
		public bool Altered
		{
			[Token(Token = "0x6003878")]
			[Address(RVA = "0x68B5F0", Offset = "0x689FF0", VA = "0x18068B5F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06003879 RID: 14457 RVA: 0x000155E8 File Offset: 0x000137E8
		[Token(Token = "0x170007AE")]
		public bool HasModifier
		{
			[Token(Token = "0x6003879")]
			[Address(RVA = "0x68B680", Offset = "0x68A080", VA = "0x18068B680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x0600387A RID: 14458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AF")]
		private List<int> PriceTag
		{
			[Token(Token = "0x600387A")]
			[Address(RVA = "0x68B730", Offset = "0x68A130", VA = "0x18068B730")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x0600387B RID: 14459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B0")]
		public List<int> AdditiveTags
		{
			[Token(Token = "0x600387B")]
			[Address(RVA = "0x68B560", Offset = "0x689F60", VA = "0x18068B560")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x0600387C RID: 14460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007B1")]
		public override int[] Tags
		{
			[Token(Token = "0x600387C")]
			[Address(RVA = "0x68B830", Offset = "0x68A230", VA = "0x18068B830", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x0600387D RID: 14461 RVA: 0x00015600 File Offset: 0x00013800
		// (set) Token: 0x0600387E RID: 14462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B2")]
		public Sellable.SellableType Type
		{
			[Token(Token = "0x600387D")]
			[Address(RVA = "0x440570", Offset = "0x43EF70", VA = "0x180440570")]
			get
			{
				return Sellable.SellableType.Food;
			}
			[Token(Token = "0x600387E")]
			[Address(RVA = "0x68BC30", Offset = "0x68A630", VA = "0x18068BC30")]
			set
			{
			}
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600387F")]
		[Address(RVA = "0x689EE0", Offset = "0x6888E0", VA = "0x180689EE0")]
		private IEnumerable<int> GetPopTag(IEnumerable<int> sourceTag)
		{
			return null;
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003880")]
		[Address(RVA = "0x68A330", Offset = "0x688D30", VA = "0x18068A330", Slot = "8")]
		protected override ObjectLanguageBase GetText(int id)
		{
			return null;
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003881")]
		[Address(RVA = "0x689C00", Offset = "0x688600", VA = "0x180689C00")]
		public void AddToTags(int tag)
		{
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003882")]
		[Address(RVA = "0x68A0D0", Offset = "0x688AD0", VA = "0x18068A0D0")]
		public void GetTagDiff(out IEnumerable<int> unchanged, out IEnumerable<int> addedTags, out IEnumerable<int> removedTags)
		{
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003883")]
		[Address(RVA = "0x689CB0", Offset = "0x6886B0", VA = "0x180689CB0", Slot = "7")]
		public override object Clone()
		{
			return null;
		}

		// Token: 0x06003884 RID: 14468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003884")]
		[Address(RVA = "0x689CC0", Offset = "0x6886C0", VA = "0x180689CC0")]
		public Sellable Duplicate()
		{
			return null;
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003885")]
		[Address(RVA = "0x68A360", Offset = "0x688D60", VA = "0x18068A360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x00015618 File Offset: 0x00013818
		[Token(Token = "0x6003886")]
		[Address(RVA = "0x68A350", Offset = "0x688D50", VA = "0x18068A350", Slot = "10")]
		protected override SchedulerNode.Reward.ObjectType OnGetObjectType()
		{
			return SchedulerNode.Reward.ObjectType.Food;
		}

		// Token: 0x04003036 RID: 12342
		[Token(Token = "0x4003036")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool isCollab;

		// Token: 0x04003037 RID: 12343
		[Token(Token = "0x4003037")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int[] banTags;

		// Token: 0x04003038 RID: 12344
		[Token(Token = "0x4003038")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sellable.SellableType type;

		// Token: 0x04003039 RID: 12345
		[Token(Token = "0x4003039")]
		[FieldOffset(Offset = "0x40")]
		private List<int> additiveTags;

		// Token: 0x0400303A RID: 12346
		[Token(Token = "0x400303A")]
		[FieldOffset(Offset = "0x48")]
		private int[] modifier;

		// Token: 0x020008DD RID: 2269
		[Token(Token = "0x20008DD")]
		public enum SellableType
		{
			// Token: 0x0400303D RID: 12349
			[Token(Token = "0x400303D")]
			Food,
			// Token: 0x0400303E RID: 12350
			[Token(Token = "0x400303E")]
			Beverage
		}
	}
}

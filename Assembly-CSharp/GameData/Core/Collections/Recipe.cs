using System;
using GameData.CoreLanguage;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections
{
	// Token: 0x020008D8 RID: 2264
	[Token(Token = "0x20008D8")]
	[Serializable]
	public class Recipe : NonTradableObjectBase, IEquatable<Recipe>
	{
		// Token: 0x06003853 RID: 14419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003853")]
		[Address(RVA = "0x689130", Offset = "0x687B30", VA = "0x180689130")]
		public Recipe(int id, int foodID, Cooker.CookerType cookerType, float cookTime, int[] ingredients)
		{
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06003854 RID: 14420 RVA: 0x00015498 File Offset: 0x00013698
		[Token(Token = "0x1700079F")]
		public int FoodID
		{
			[Token(Token = "0x6003854")]
			[Address(RVA = "0x403830", Offset = "0x402230", VA = "0x180403830")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06003855 RID: 14421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A0")]
		public Sellable Food
		{
			[Token(Token = "0x6003855")]
			[Address(RVA = "0x689290", Offset = "0x687C90", VA = "0x180689290")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06003856 RID: 14422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A1")]
		public int[] Ingredients
		{
			[Token(Token = "0x6003856")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x06003857 RID: 14423 RVA: 0x000154B0 File Offset: 0x000136B0
		[Token(Token = "0x170007A2")]
		public Cooker.CookerType CookerType
		{
			[Token(Token = "0x6003857")]
			[Address(RVA = "0x44F9E0", Offset = "0x44E3E0", VA = "0x18044F9E0")]
			get
			{
				return Cooker.CookerType.Empty;
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06003858 RID: 14424 RVA: 0x000154C8 File Offset: 0x000136C8
		[Token(Token = "0x170007A3")]
		public float BaseCookTime
		{
			[Token(Token = "0x6003858")]
			[Address(RVA = "0x689190", Offset = "0x687B90", VA = "0x180689190")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06003859 RID: 14425 RVA: 0x000154E0 File Offset: 0x000136E0
		[Token(Token = "0x170007A4")]
		public float CookTime
		{
			[Token(Token = "0x6003859")]
			[Address(RVA = "0x6891A0", Offset = "0x687BA0", VA = "0x1806891A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x0600385A RID: 14426 RVA: 0x000154F8 File Offset: 0x000136F8
		// (set) Token: 0x0600385B RID: 14427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A5")]
		public int CookCount
		{
			[Token(Token = "0x600385A")]
			[Address(RVA = "0x44F9C0", Offset = "0x44E3C0", VA = "0x18044F9C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600385B")]
			[Address(RVA = "0x4B2A20", Offset = "0x4B1420", VA = "0x1804B2A20")]
			set
			{
			}
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385C")]
		[Address(RVA = "0x688960", Offset = "0x687360", VA = "0x180688960")]
		public string GetCookCountNum()
		{
			return null;
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x00015510 File Offset: 0x00013710
		[Token(Token = "0x600385D")]
		[Address(RVA = "0x688830", Offset = "0x687230", VA = "0x180688830", Slot = "9")]
		public bool Equals(Recipe other)
		{
			return default(bool);
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385E")]
		[Address(RVA = "0x688B60", Offset = "0x687560", VA = "0x180688B60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600385F")]
		[Address(RVA = "0x688B20", Offset = "0x687520", VA = "0x180688B20", Slot = "8")]
		protected override ObjectLanguageBase GetText(int id)
		{
			return null;
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003860")]
		[Address(RVA = "0x6885F0", Offset = "0x686FF0", VA = "0x1806885F0", Slot = "7")]
		public override object Clone()
		{
			return null;
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x00015528 File Offset: 0x00013728
		[Token(Token = "0x6003861")]
		[Address(RVA = "0x6886B0", Offset = "0x6870B0", VA = "0x1806886B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x00015540 File Offset: 0x00013740
		[Token(Token = "0x6003862")]
		[Address(RVA = "0x6889C0", Offset = "0x6873C0", VA = "0x1806889C0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04003021 RID: 12321
		[Token(Token = "0x4003021")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int foodID;

		// Token: 0x04003022 RID: 12322
		[Token(Token = "0x4003022")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int[] ingredients;

		// Token: 0x04003023 RID: 12323
		[Token(Token = "0x4003023")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Cooker.CookerType cookerType;

		// Token: 0x04003024 RID: 12324
		[Token(Token = "0x4003024")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float cookTime;

		// Token: 0x04003025 RID: 12325
		[Token(Token = "0x4003025")]
		[FieldOffset(Offset = "0x30")]
		private int cookCount;

		// Token: 0x020008D9 RID: 2265
		[Token(Token = "0x20008D9")]
		public enum SortType
		{
			// Token: 0x04003027 RID: 12327
			[Token(Token = "0x4003027")]
			CookTime,
			// Token: 0x04003028 RID: 12328
			[Token(Token = "0x4003028")]
			CookCount,
			// Token: 0x04003029 RID: 12329
			[Token(Token = "0x4003029")]
			ID,
			// Token: 0x0400302A RID: 12330
			[Token(Token = "0x400302A")]
			Level,
			// Token: 0x0400302B RID: 12331
			[Token(Token = "0x400302B")]
			Value,
			// Token: 0x0400302C RID: 12332
			[Token(Token = "0x400302C")]
			Tag
		}
	}
}

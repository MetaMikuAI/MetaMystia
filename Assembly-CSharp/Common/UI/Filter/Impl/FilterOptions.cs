using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameData.Core;
using GameData.Core.Collections;
using Il2CppDummyDll;

namespace Common.UI.Filter.Impl
{
	// Token: 0x02000F06 RID: 3846
	[Token(Token = "0x2000F06")]
	public static class FilterOptions
	{
		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06005A9B RID: 23195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C92")]
		public static IReadOnlyList<FilterConfigFactory<Recipe>> RecipeFilterConfigFactories
		{
			[Token(Token = "0x6005A9B")]
			[Address(RVA = "0x8893E0", Offset = "0x887DE0", VA = "0x1808893E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06005A9C RID: 23196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C93")]
		public static IReadOnlyList<FilterConfigFactory<Sellable>> FoodFilterConfigFactories
		{
			[Token(Token = "0x6005A9C")]
			[Address(RVA = "0x8892F0", Offset = "0x887CF0", VA = "0x1808892F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06005A9D RID: 23197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C94")]
		public static IReadOnlyList<FilterConfigFactory<Sellable>> DailyFoodFilterConfigFactories
		{
			[Token(Token = "0x6005A9D")]
			[Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06005A9E RID: 23198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C95")]
		public static IReadOnlyList<FilterConfigFactory<Sellable>> BeverageFilterConfigFactories
		{
			[Token(Token = "0x6005A9E")]
			[Address(RVA = "0x8891B0", Offset = "0x887BB0", VA = "0x1808891B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06005A9F RID: 23199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C96")]
		public static IReadOnlyList<FilterConfigFactory<Sellable>> DailyBeverageFilterConfigFactories
		{
			[Token(Token = "0x6005A9F")]
			[Address(RVA = "0x889250", Offset = "0x887C50", VA = "0x180889250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06005AA0 RID: 23200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C97")]
		public static IReadOnlyList<FilterConfigFactory<Ingredient>> IngredientFilterConfigFactories
		{
			[Token(Token = "0x6005AA0")]
			[Address(RVA = "0x889340", Offset = "0x887D40", VA = "0x180889340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06005AA1 RID: 23201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C98")]
		public static IReadOnlyList<FilterConfigFactory<Cooker>> CookerFilterConfigFactories
		{
			[Token(Token = "0x6005AA1")]
			[Address(RVA = "0x889200", Offset = "0x887C00", VA = "0x180889200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06005AA2 RID: 23202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C99")]
		public static IReadOnlyList<FilterConfigFactory<Item>> ItemFilterConfigFactories
		{
			[Token(Token = "0x6005AA2")]
			[Address(RVA = "0x889390", Offset = "0x887D90", VA = "0x180889390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x02000F07 RID: 3847
		[Token(Token = "0x2000F07")]
		private class CookerByAcquireOrderFactory : FilterOptions.NonTradableByAcquireOrderFactory<Cooker>
		{
			// Token: 0x17000C9A RID: 3226
			// (get) Token: 0x06005AA4 RID: 23204 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C9A")]
			public override string FactoryName
			{
				[Token(Token = "0x6005AA4")]
				[Address(RVA = "0x87FFF0", Offset = "0x87E9F0", VA = "0x18087FFF0", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005AA5 RID: 23205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AA5")]
			[Address(RVA = "0x87FF10", Offset = "0x87E910", VA = "0x18087FF10", Slot = "17")]
			public override void OnWillFilter()
			{
			}

			// Token: 0x06005AA6 RID: 23206 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AA6")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450", Slot = "26")]
			protected override List<int> GetAcquireOrderList()
			{
				return null;
			}

			// Token: 0x06005AA7 RID: 23207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AA7")]
			[Address(RVA = "0x87FFA0", Offset = "0x87E9A0", VA = "0x18087FFA0")]
			public CookerByAcquireOrderFactory(uint selectionPriorityWeight)
			{
			}

			// Token: 0x040054B8 RID: 21688
			[Token(Token = "0x40054B8")]
			[FieldOffset(Offset = "0x18")]
			private List<int> m_AcquireOrderCache;
		}

		// Token: 0x02000F08 RID: 3848
		[Token(Token = "0x2000F08")]
		private class CookerByCookerTypeFactory : ByValueContainsConfigFactory<Cooker.CookerType, Cooker>
		{
			// Token: 0x17000C9B RID: 3227
			// (get) Token: 0x06005AA8 RID: 23208 RVA: 0x0001FBC0 File Offset: 0x0001DDC0
			[Token(Token = "0x17000C9B")]
			protected override Rule ContainsRule
			{
				[Token(Token = "0x6005AA8")]
				[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "24")]
				get
				{
					return Rule.ContainsAnd;
				}
			}

			// Token: 0x17000C9C RID: 3228
			// (get) Token: 0x06005AA9 RID: 23209 RVA: 0x0001FBD8 File Offset: 0x0001DDD8
			[Token(Token = "0x17000C9C")]
			public sealed override FilterType FilterType
			{
				[Token(Token = "0x6005AA9")]
				[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "15")]
				get
				{
					return FilterType.SingleChoice;
				}
			}

			// Token: 0x17000C9D RID: 3229
			// (get) Token: 0x06005AAA RID: 23210 RVA: 0x0001FBF0 File Offset: 0x0001DDF0
			[Token(Token = "0x17000C9D")]
			public sealed override uint ColumnCount
			{
				[Token(Token = "0x6005AAA")]
				[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "14")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x06005AAB RID: 23211 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AAB")]
			[Address(RVA = "0x880030", Offset = "0x87EA30", VA = "0x180880030", Slot = "25")]
			protected override string GetByTypeText(Rule rule)
			{
				return null;
			}

			// Token: 0x06005AAC RID: 23212 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AAC")]
			[Address(RVA = "0x8800A0", Offset = "0x87EAA0", VA = "0x1808800A0", Slot = "21")]
			protected override IEnumerable<Cooker.CookerType> GetSelectionsTyped()
			{
				return null;
			}

			// Token: 0x06005AAD RID: 23213 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AAD")]
			[Address(RVA = "0x525790", Offset = "0x524190", VA = "0x180525790", Slot = "22")]
			protected override string GetSelectionTextTyped(Cooker.CookerType value)
			{
				return null;
			}

			// Token: 0x06005AAE RID: 23214 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AAE")]
			[Address(RVA = "0x880080", Offset = "0x87EA80", VA = "0x180880080", Slot = "26")]
			protected override IEnumerable<Cooker.CookerType> GetFocusing(Cooker ordering)
			{
				return null;
			}

			// Token: 0x06005AAF RID: 23215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AAF")]
			[Address(RVA = "0x880180", Offset = "0x87EB80", VA = "0x180880180")]
			public CookerByCookerTypeFactory(uint selectionPriorityWeight)
			{
			}

			// Token: 0x040054B9 RID: 21689
			[Token(Token = "0x40054B9")]
			[FieldOffset(Offset = "0x0")]
			private static readonly IReadOnlyCollection<Cooker.CookerType> m_CookerTypes;
		}

		// Token: 0x02000F09 RID: 3849
		[Token(Token = "0x2000F09")]
		private class CookerBySeriesTypeFactory : ByValueContainsConfigFactory<Cooker.CookerSeries, Cooker>
		{
			// Token: 0x17000C9E RID: 3230
			// (get) Token: 0x06005AB1 RID: 23217 RVA: 0x0001FC08 File Offset: 0x0001DE08
			[Token(Token = "0x17000C9E")]
			public override FilterType FilterType
			{
				[Token(Token = "0x6005AB1")]
				[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "15")]
				get
				{
					return FilterType.SingleChoice;
				}
			}

			// Token: 0x17000C9F RID: 3231
			// (get) Token: 0x06005AB2 RID: 23218 RVA: 0x0001FC20 File Offset: 0x0001DE20
			[Token(Token = "0x17000C9F")]
			public sealed override uint ColumnCount
			{
				[Token(Token = "0x6005AB2")]
				[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "14")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x17000CA0 RID: 3232
			// (get) Token: 0x06005AB3 RID: 23219 RVA: 0x0001FC38 File Offset: 0x0001DE38
			[Token(Token = "0x17000CA0")]
			protected override Rule ContainsRule
			{
				[Token(Token = "0x6005AB3")]
				[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "24")]
				get
				{
					return Rule.ContainsAnd;
				}
			}

			// Token: 0x06005AB4 RID: 23220 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AB4")]
			[Address(RVA = "0x8801D0", Offset = "0x87EBD0", VA = "0x1808801D0", Slot = "25")]
			protected override string GetByTypeText(Rule rule)
			{
				return null;
			}

			// Token: 0x06005AB5 RID: 23221 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AB5")]
			[Address(RVA = "0x880320", Offset = "0x87ED20", VA = "0x180880320", Slot = "21")]
			protected override IEnumerable<Cooker.CookerSeries> GetSelectionsTyped()
			{
				return null;
			}

			// Token: 0x06005AB6 RID: 23222 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AB6")]
			[Address(RVA = "0x880310", Offset = "0x87ED10", VA = "0x180880310", Slot = "22")]
			protected override string GetSelectionTextTyped(Cooker.CookerSeries value)
			{
				return null;
			}

			// Token: 0x06005AB7 RID: 23223 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AB7")]
			[Address(RVA = "0x8802C0", Offset = "0x87ECC0", VA = "0x1808802C0", Slot = "26")]
			protected override IEnumerable<Cooker.CookerSeries> GetFocusing(Cooker ordering)
			{
				return null;
			}

			// Token: 0x06005AB8 RID: 23224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AB8")]
			[Address(RVA = "0x880460", Offset = "0x87EE60", VA = "0x180880460")]
			public CookerBySeriesTypeFactory(uint selectionPriorityWeight)
			{
			}
		}

		// Token: 0x02000F0B RID: 3851
		[Token(Token = "0x2000F0B")]
		private class IngredientByTagFactory : FilterOptions.TradableByTagFactory<Ingredient>
		{
			// Token: 0x06005ABC RID: 23228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005ABC")]
			[Address(RVA = "0x88B540", Offset = "0x889F40", VA = "0x18088B540")]
			public IngredientByTagFactory(bool contains, uint columnCount, uint selectionPriorityWeight)
			{
			}

			// Token: 0x17000CA1 RID: 3233
			// (get) Token: 0x06005ABD RID: 23229 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CA1")]
			protected override string GetTradableName
			{
				[Token(Token = "0x6005ABD")]
				[Address(RVA = "0x88B020", Offset = "0x889A20", VA = "0x18088B020", Slot = "27")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005ABE RID: 23230 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005ABE")]
			[Address(RVA = "0x88B380", Offset = "0x889D80", VA = "0x18088B380", Slot = "21")]
			protected override IEnumerable<int> GetSelectionsTyped()
			{
				return null;
			}

			// Token: 0x06005ABF RID: 23231 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005ABF")]
			[Address(RVA = "0x4EA210", Offset = "0x4E8C10", VA = "0x1804EA210", Slot = "22")]
			protected override string GetSelectionTextTyped(int value)
			{
				return null;
			}
		}

		// Token: 0x02000F0D RID: 3853
		[Token(Token = "0x2000F0D")]
		private class IngredientByPriceFactory : FilterOptions.TradableByPriceFactory<Ingredient>
		{
			// Token: 0x17000CA2 RID: 3234
			// (get) Token: 0x06005AC3 RID: 23235 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CA2")]
			protected override string GetTradableName
			{
				[Token(Token = "0x6005AC3")]
				[Address(RVA = "0x88B020", Offset = "0x889A20", VA = "0x18088B020", Slot = "26")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005AC4 RID: 23236 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AC4")]
			[Address(RVA = "0x88B330", Offset = "0x889D30", VA = "0x18088B330")]
			public IngredientByPriceFactory(uint selectionPriorityWeight)
			{
			}
		}

		// Token: 0x02000F0E RID: 3854
		[Token(Token = "0x2000F0E")]
		private class IngredientByLevelFactory : FilterOptions.TradableByLevelFactory<Ingredient>
		{
			// Token: 0x17000CA3 RID: 3235
			// (get) Token: 0x06005AC5 RID: 23237 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CA3")]
			protected override string GetTradableName
			{
				[Token(Token = "0x6005AC5")]
				[Address(RVA = "0x88B020", Offset = "0x889A20", VA = "0x18088B020", Slot = "26")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005AC6 RID: 23238 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AC6")]
			[Address(RVA = "0x88B2E0", Offset = "0x889CE0", VA = "0x18088B2E0")]
			public IngredientByLevelFactory(uint selectionPriorityWeight)
			{
			}
		}

		// Token: 0x02000F0F RID: 3855
		[Token(Token = "0x2000F0F")]
		private class IngredientByCountFactory : FilterOptions.TradableByCountFactory<Ingredient>
		{
			// Token: 0x17000CA4 RID: 3236
			// (get) Token: 0x06005AC7 RID: 23239 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CA4")]
			protected override string GetObjectName
			{
				[Token(Token = "0x6005AC7")]
				[Address(RVA = "0x88B020", Offset = "0x889A20", VA = "0x18088B020", Slot = "26")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005AC8 RID: 23240 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AC8")]
			[Address(RVA = "0x88B060", Offset = "0x889A60", VA = "0x18088B060", Slot = "17")]
			public override void OnWillFilter()
			{
			}

			// Token: 0x06005AC9 RID: 23241 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AC9")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450", Slot = "27")]
			protected override Dictionary<int, int> GetCountList()
			{
				return null;
			}

			// Token: 0x06005ACA RID: 23242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005ACA")]
			[Address(RVA = "0x88B290", Offset = "0x889C90", VA = "0x18088B290")]
			public IngredientByCountFactory(uint selectionPriorityWeight)
			{
			}

			// Token: 0x040054BE RID: 21694
			[Token(Token = "0x40054BE")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<int, int> m_CountCache;
		}

		// Token: 0x02000F11 RID: 3857
		[Token(Token = "0x2000F11")]
		private class IngredientByAcquireOrderFactory : FilterOptions.TradableByAcquireOrderFactory<Ingredient>
		{
			// Token: 0x17000CA5 RID: 3237
			// (get) Token: 0x06005ACF RID: 23247 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CA5")]
			protected override string GetTradableName
			{
				[Token(Token = "0x6005ACF")]
				[Address(RVA = "0x88B020", Offset = "0x889A20", VA = "0x18088B020", Slot = "27")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005AD0 RID: 23248 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AD0")]
			[Address(RVA = "0x88AF40", Offset = "0x889940", VA = "0x18088AF40", Slot = "17")]
			public override void OnWillFilter()
			{
			}

			// Token: 0x06005AD1 RID: 23249 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AD1")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0", Slot = "26")]
			protected override List<int> GetAcquireOrderList()
			{
				return null;
			}

			// Token: 0x06005AD2 RID: 23250 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AD2")]
			[Address(RVA = "0x88AFD0", Offset = "0x8899D0", VA = "0x18088AFD0")]
			public IngredientByAcquireOrderFactory(uint selectionPriorityWeight)
			{
			}

			// Token: 0x040054C2 RID: 21698
			[Token(Token = "0x40054C2")]
			[FieldOffset(Offset = "0x18")]
			private readonly Sellable.SellableType m_SellableType;

			// Token: 0x040054C3 RID: 21699
			[Token(Token = "0x40054C3")]
			[FieldOffset(Offset = "0x20")]
			private List<int> m_AcquireOrderCache;
		}

		// Token: 0x02000F12 RID: 3858
		[Token(Token = "0x2000F12")]
		private class ItemByCountFactory : FilterOptions.NonTradableByCountFactory<Item>
		{
			// Token: 0x17000CA6 RID: 3238
			// (get) Token: 0x06005AD3 RID: 23251 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CA6")]
			protected override string GetObjectName
			{
				[Token(Token = "0x6005AD3")]
				[Address(RVA = "0x88B960", Offset = "0x88A360", VA = "0x18088B960", Slot = "26")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005AD4 RID: 23252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AD4")]
			[Address(RVA = "0x88B6E0", Offset = "0x88A0E0", VA = "0x18088B6E0", Slot = "17")]
			public override void OnWillFilter()
			{
			}

			// Token: 0x06005AD5 RID: 23253 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AD5")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450", Slot = "27")]
			protected override Dictionary<int, int> GetCountList()
			{
				return null;
			}

			// Token: 0x06005AD6 RID: 23254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AD6")]
			[Address(RVA = "0x88B910", Offset = "0x88A310", VA = "0x18088B910")]
			public ItemByCountFactory(uint selectionPriorityWeight)
			{
			}

			// Token: 0x040054C4 RID: 21700
			[Token(Token = "0x40054C4")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<int, int> m_CountCache;
		}

		// Token: 0x02000F14 RID: 3860
		[Token(Token = "0x2000F14")]
		private class ItemByAcquireOrderFactory : FilterOptions.NonTradableByAcquireOrderFactory<Item>
		{
			// Token: 0x17000CA7 RID: 3239
			// (get) Token: 0x06005ADB RID: 23259 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CA7")]
			public override string FactoryName
			{
				[Token(Token = "0x6005ADB")]
				[Address(RVA = "0x88B6A0", Offset = "0x88A0A0", VA = "0x18088B6A0", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005ADC RID: 23260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005ADC")]
			[Address(RVA = "0x88B5C0", Offset = "0x889FC0", VA = "0x18088B5C0", Slot = "17")]
			public override void OnWillFilter()
			{
			}

			// Token: 0x06005ADD RID: 23261 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005ADD")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450", Slot = "26")]
			protected override List<int> GetAcquireOrderList()
			{
				return null;
			}

			// Token: 0x06005ADE RID: 23262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005ADE")]
			[Address(RVA = "0x88B650", Offset = "0x88A050", VA = "0x18088B650")]
			public ItemByAcquireOrderFactory(uint selectionPriorityWeight)
			{
			}

			// Token: 0x040054C8 RID: 21704
			[Token(Token = "0x40054C8")]
			[FieldOffset(Offset = "0x18")]
			private List<int> m_AcquireOrderCache;
		}

		// Token: 0x02000F15 RID: 3861
		[Token(Token = "0x2000F15")]
		private class ItemByTypeFactory : ByValueContainsConfigFactory<FilterOptions.ItemByTypeFactory.ItemType, Item>
		{
			// Token: 0x17000CA8 RID: 3240
			// (get) Token: 0x06005ADF RID: 23263 RVA: 0x0001FCC8 File Offset: 0x0001DEC8
			[Token(Token = "0x17000CA8")]
			public override FilterType FilterType
			{
				[Token(Token = "0x6005ADF")]
				[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "15")]
				get
				{
					return FilterType.SingleChoice;
				}
			}

			// Token: 0x17000CA9 RID: 3241
			// (get) Token: 0x06005AE0 RID: 23264 RVA: 0x0001FCE0 File Offset: 0x0001DEE0
			[Token(Token = "0x17000CA9")]
			public sealed override uint ColumnCount
			{
				[Token(Token = "0x6005AE0")]
				[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "14")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x17000CAA RID: 3242
			// (get) Token: 0x06005AE1 RID: 23265 RVA: 0x0001FCF8 File Offset: 0x0001DEF8
			[Token(Token = "0x17000CAA")]
			protected override Rule ContainsRule
			{
				[Token(Token = "0x6005AE1")]
				[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "24")]
				get
				{
					return Rule.ContainsAnd;
				}
			}

			// Token: 0x06005AE2 RID: 23266 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AE2")]
			[Address(RVA = "0x88B9A0", Offset = "0x88A3A0", VA = "0x18088B9A0", Slot = "25")]
			protected override string GetByTypeText(Rule rule)
			{
				return null;
			}

			// Token: 0x06005AE3 RID: 23267 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AE3")]
			[Address(RVA = "0x88BC20", Offset = "0x88A620", VA = "0x18088BC20", Slot = "21")]
			protected override IEnumerable<FilterOptions.ItemByTypeFactory.ItemType> GetSelectionsTyped()
			{
				return null;
			}

			// Token: 0x06005AE4 RID: 23268 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AE4")]
			[Address(RVA = "0x88BAB0", Offset = "0x88A4B0", VA = "0x18088BAB0", Slot = "22")]
			protected override string GetSelectionTextTyped(FilterOptions.ItemByTypeFactory.ItemType value)
			{
				return null;
			}

			// Token: 0x06005AE5 RID: 23269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005AE5")]
			[Address(RVA = "0x88B9F0", Offset = "0x88A3F0", VA = "0x18088B9F0", Slot = "26")]
			protected override IEnumerable<FilterOptions.ItemByTypeFactory.ItemType> GetFocusing(Item ordering)
			{
				return null;
			}

			// Token: 0x06005AE6 RID: 23270 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005AE6")]
			[Address(RVA = "0x88BD00", Offset = "0x88A700", VA = "0x18088BD00")]
			public ItemByTypeFactory(uint selectionPriorityWeight)
			{
			}

			// Token: 0x040054C9 RID: 21705
			[Token(Token = "0x40054C9")]
			[FieldOffset(Offset = "0x0")]
			private static readonly IReadOnlyCollection<FilterOptions.ItemByTypeFactory.ItemType> m_ItemTypes;

			// Token: 0x040054CA RID: 21706
			[Token(Token = "0x40054CA")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<FilterOptions.ItemByTypeFactory.ItemType, string> m_ItemTypeTexts;

			// Token: 0x02000F16 RID: 3862
			[Token(Token = "0x2000F16")]
			public enum ItemType
			{
				// Token: 0x040054CC RID: 21708
				[Token(Token = "0x40054CC")]
				Clothes,
				// Token: 0x040054CD RID: 21709
				[Token(Token = "0x40054CD")]
				Decoration,
				// Token: 0x040054CE RID: 21710
				[Token(Token = "0x40054CE")]
				Record,
				// Token: 0x040054CF RID: 21711
				[Token(Token = "0x40054CF")]
				TimeLimitedItem,
				// Token: 0x040054D0 RID: 21712
				[Token(Token = "0x40054D0")]
				Other
			}
		}

		// Token: 0x02000F17 RID: 3863
		[Token(Token = "0x2000F17")]
		public static class LanguageList
		{
			// Token: 0x02000F18 RID: 3864
			[Token(Token = "0x2000F18")]
			private static class StringProvider
			{
				// Token: 0x17000CAB RID: 3243
				// (get) Token: 0x06005AE8 RID: 23272 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CAB")]
				public static string Rule_ContainsAnd
				{
					[Token(Token = "0x6005AE8")]
					[Address(RVA = "0x896A40", Offset = "0x895440", VA = "0x180896A40")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CAC RID: 3244
				// (get) Token: 0x06005AE9 RID: 23273 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CAC")]
				public static string Rule_ContainsOr
				{
					[Token(Token = "0x6005AE9")]
					[Address(RVA = "0x896AC0", Offset = "0x8954C0", VA = "0x180896AC0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CAD RID: 3245
				// (get) Token: 0x06005AEA RID: 23274 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CAD")]
				public static string Rule_ContainsNot
				{
					[Token(Token = "0x6005AEA")]
					[Address(RVA = "0x896A80", Offset = "0x895480", VA = "0x180896A80")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CAE RID: 3246
				// (get) Token: 0x06005AEB RID: 23275 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CAE")]
				public static string General_Amount
				{
					[Token(Token = "0x6005AEB")]
					[Address(RVA = "0x896800", Offset = "0x895200", VA = "0x180896800")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CAF RID: 3247
				// (get) Token: 0x06005AEC RID: 23276 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CAF")]
				public static string General_Tag
				{
					[Token(Token = "0x6005AEC")]
					[Address(RVA = "0x896980", Offset = "0x895380", VA = "0x180896980")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CB0 RID: 3248
				// (get) Token: 0x06005AED RID: 23277 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CB0")]
				public static string General_Price
				{
					[Token(Token = "0x6005AED")]
					[Address(RVA = "0x896900", Offset = "0x895300", VA = "0x180896900")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CB1 RID: 3249
				// (get) Token: 0x06005AEE RID: 23278 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CB1")]
				public static string General_Level
				{
					[Token(Token = "0x6005AEE")]
					[Address(RVA = "0x8968C0", Offset = "0x8952C0", VA = "0x1808968C0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CB2 RID: 3250
				// (get) Token: 0x06005AEF RID: 23279 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CB2")]
				public static string General_Type
				{
					[Token(Token = "0x6005AEF")]
					[Address(RVA = "0x8969C0", Offset = "0x8953C0", VA = "0x1808969C0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CB3 RID: 3251
				// (get) Token: 0x06005AF0 RID: 23280 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CB3")]
				public static string General_Serie
				{
					[Token(Token = "0x6005AF0")]
					[Address(RVA = "0x896940", Offset = "0x895340", VA = "0x180896940")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CB4 RID: 3252
				// (get) Token: 0x06005AF1 RID: 23281 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CB4")]
				public static string General_AcquireOrder
				{
					[Token(Token = "0x6005AF1")]
					[Address(RVA = "0x8967C0", Offset = "0x8951C0", VA = "0x1808967C0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CB5 RID: 3253
				// (get) Token: 0x06005AF2 RID: 23282 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CB5")]
				public static string General_FirstDigit
				{
					[Token(Token = "0x6005AF2")]
					[Address(RVA = "0x88A740", Offset = "0x889140", VA = "0x18088A740")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CB6 RID: 3254
				// (get) Token: 0x06005AF3 RID: 23283 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CB6")]
				public static string General_IsDailyMenu
				{
					[Token(Token = "0x6005AF3")]
					[Address(RVA = "0x8954D0", Offset = "0x893ED0", VA = "0x1808954D0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CB7 RID: 3255
				// (get) Token: 0x06005AF4 RID: 23284 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CB7")]
				public static string General_Ascending
				{
					[Token(Token = "0x6005AF4")]
					[Address(RVA = "0x896840", Offset = "0x895240", VA = "0x180896840")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CB8 RID: 3256
				// (get) Token: 0x06005AF5 RID: 23285 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CB8")]
				public static string General_Descending
				{
					[Token(Token = "0x6005AF5")]
					[Address(RVA = "0x896880", Offset = "0x895280", VA = "0x180896880")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CB9 RID: 3257
				// (get) Token: 0x06005AF6 RID: 23286 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CB9")]
				public static string Recipe_Name
				{
					[Token(Token = "0x6005AF6")]
					[Address(RVA = "0x896A00", Offset = "0x895400", VA = "0x180896A00")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CBA RID: 3258
				// (get) Token: 0x06005AF7 RID: 23287 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CBA")]
				public static string Item_Name
				{
					[Token(Token = "0x6005AF7")]
					[Address(RVA = "0x88B960", Offset = "0x88A360", VA = "0x18088B960")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CBB RID: 3259
				// (get) Token: 0x06005AF8 RID: 23288 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CBB")]
				public static string Ingredient_Name
				{
					[Token(Token = "0x6005AF8")]
					[Address(RVA = "0x88B020", Offset = "0x889A20", VA = "0x18088B020")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CBC RID: 3260
				// (get) Token: 0x06005AF9 RID: 23289 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CBC")]
				public static string Cooker_Name
				{
					[Token(Token = "0x6005AF9")]
					[Address(RVA = "0x896740", Offset = "0x895140", VA = "0x180896740")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CBD RID: 3261
				// (get) Token: 0x06005AFA RID: 23290 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CBD")]
				public static string Food_Name
				{
					[Token(Token = "0x6005AFA")]
					[Address(RVA = "0x896780", Offset = "0x895180", VA = "0x180896780")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CBE RID: 3262
				// (get) Token: 0x06005AFB RID: 23291 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CBE")]
				public static string Beverage_Name
				{
					[Token(Token = "0x6005AFB")]
					[Address(RVA = "0x8963C0", Offset = "0x894DC0", VA = "0x1808963C0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CBF RID: 3263
				// (get) Token: 0x06005AFC RID: 23292 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CBF")]
				public static string CookerSeries_Base
				{
					[Token(Token = "0x6005AFC")]
					[Address(RVA = "0x896400", Offset = "0x894E00", VA = "0x180896400")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CC0 RID: 3264
				// (get) Token: 0x06005AFD RID: 23293 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CC0")]
				public static string CookerSeries_Super
				{
					[Token(Token = "0x6005AFD")]
					[Address(RVA = "0x896640", Offset = "0x895040", VA = "0x180896640")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CC1 RID: 3265
				// (get) Token: 0x06005AFE RID: 23294 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CC1")]
				public static string CookerSeries_Extreme
				{
					[Token(Token = "0x6005AFE")]
					[Address(RVA = "0x896480", Offset = "0x894E80", VA = "0x180896480")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CC2 RID: 3266
				// (get) Token: 0x06005AFF RID: 23295 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CC2")]
				public static string CookerSeries_Sparrow
				{
					[Token(Token = "0x6005AFF")]
					[Address(RVA = "0x8965C0", Offset = "0x894FC0", VA = "0x1808965C0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CC3 RID: 3267
				// (get) Token: 0x06005B00 RID: 23296 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CC3")]
				public static string CookerSeries_Nuclear
				{
					[Token(Token = "0x6005B00")]
					[Address(RVA = "0x8964C0", Offset = "0x894EC0", VA = "0x1808964C0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CC4 RID: 3268
				// (get) Token: 0x06005B01 RID: 23297 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CC4")]
				public static string CookerSeries_Suspicious
				{
					[Token(Token = "0x6005B01")]
					[Address(RVA = "0x896680", Offset = "0x895080", VA = "0x180896680")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CC5 RID: 3269
				// (get) Token: 0x06005B02 RID: 23298 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CC5")]
				public static string CookerSeries_Tsukimi
				{
					[Token(Token = "0x6005B02")]
					[Address(RVA = "0x896700", Offset = "0x895100", VA = "0x180896700")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CC6 RID: 3270
				// (get) Token: 0x06005B03 RID: 23299 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CC6")]
				public static string CookerSeries_SamadhiFire
				{
					[Token(Token = "0x6005B03")]
					[Address(RVA = "0x896580", Offset = "0x894F80", VA = "0x180896580")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CC7 RID: 3271
				// (get) Token: 0x06005B04 RID: 23300 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CC7")]
				public static string CookerSeries_PeerlessWindGod
				{
					[Token(Token = "0x6005B04")]
					[Address(RVA = "0x896500", Offset = "0x894F00", VA = "0x180896500")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CC8 RID: 3272
				// (get) Token: 0x06005B05 RID: 23301 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CC8")]
				public static string CookerSeries_StarMagicPot
				{
					[Token(Token = "0x6005B05")]
					[Address(RVA = "0x896600", Offset = "0x895000", VA = "0x180896600")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CC9 RID: 3273
				// (get) Token: 0x06005B06 RID: 23302 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CC9")]
				public static string CookerSeries_PureHellFryer
				{
					[Token(Token = "0x6005B06")]
					[Address(RVA = "0x896540", Offset = "0x894F40", VA = "0x180896540")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CCA RID: 3274
				// (get) Token: 0x06005B07 RID: 23303 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CCA")]
				public static string CookerSeries_ByakurenCuttingBoard
				{
					[Token(Token = "0x6005B07")]
					[Address(RVA = "0x896440", Offset = "0x894E40", VA = "0x180896440")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CCB RID: 3275
				// (get) Token: 0x06005B08 RID: 23304 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CCB")]
				public static string CookerSeries_Trinity
				{
					[Token(Token = "0x6005B08")]
					[Address(RVA = "0x8966C0", Offset = "0x8950C0", VA = "0x1808966C0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000CCC RID: 3276
				// (get) Token: 0x06005B09 RID: 23305 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000CCC")]
				public static string Cook_Count
				{
					[Token(Token = "0x6005B09")]
					[Address(RVA = "0x894640", Offset = "0x893040", VA = "0x180894640")]
					get
					{
						return null;
					}
				}
			}

			// Token: 0x02000F19 RID: 3865
			[Token(Token = "0x2000F19")]
			private static class ByValueContains
			{
				// Token: 0x06005B0A RID: 23306 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B0A")]
				[Address(RVA = "0x87FE10", Offset = "0x87E810", VA = "0x18087FE10")]
				public static string GetRuleText(Rule rule)
				{
					return null;
				}
			}

			// Token: 0x02000F1A RID: 3866
			[Token(Token = "0x2000F1A")]
			public static class GeneralFilter
			{
				// Token: 0x06005B0B RID: 23307 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B0B")]
				[Address(RVA = "0x88A940", Offset = "0x889340", VA = "0x18088A940")]
				public static string GetByTagFactoryText(string objectName, Rule rule)
				{
					return null;
				}

				// Token: 0x06005B0C RID: 23308 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B0C")]
				[Address(RVA = "0x88A800", Offset = "0x889200", VA = "0x18088A800")]
				public static string GetByPriceFactoryText(string objectName)
				{
					return null;
				}

				// Token: 0x06005B0D RID: 23309 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B0D")]
				[Address(RVA = "0x88A780", Offset = "0x889180", VA = "0x18088A780")]
				public static string GetByLevelFactoryText(string objectName)
				{
					return null;
				}

				// Token: 0x06005B0E RID: 23310 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B0E")]
				[Address(RVA = "0x88A640", Offset = "0x889040", VA = "0x18088A640")]
				public static string GetByAcquireOrderFactoryText(string objectName)
				{
					return null;
				}

				// Token: 0x06005B0F RID: 23311 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B0F")]
				[Address(RVA = "0x88A6C0", Offset = "0x8890C0", VA = "0x18088A6C0")]
				public static string GetByAmountFactoryText(string objectName)
				{
					return null;
				}

				// Token: 0x06005B10 RID: 23312 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B10")]
				[Address(RVA = "0x88AA00", Offset = "0x889400", VA = "0x18088AA00")]
				public static string GetByTypeFactoryText(string objectName, Rule rule)
				{
					return null;
				}

				// Token: 0x06005B11 RID: 23313 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B11")]
				[Address(RVA = "0x88A880", Offset = "0x889280", VA = "0x18088A880")]
				public static string GetBySeriesFactoryText(string objectName, Rule rule)
				{
					return null;
				}

				// Token: 0x06005B12 RID: 23314 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B12")]
				[Address(RVA = "0x88AAC0", Offset = "0x8894C0", VA = "0x18088AAC0")]
				public static string GetOrderText(Order order)
				{
					return null;
				}

				// Token: 0x06005B13 RID: 23315 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B13")]
				[Address(RVA = "0x88A740", Offset = "0x889140", VA = "0x18088A740")]
				public static string GetByCapicalLetterFactoryText()
				{
					return null;
				}
			}

			// Token: 0x02000F1B RID: 3867
			[Token(Token = "0x2000F1B")]
			public static class CookerFilter
			{
				// Token: 0x06005B14 RID: 23316 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B14")]
				[Address(RVA = "0x87FFF0", Offset = "0x87E9F0", VA = "0x18087FFF0")]
				public static string GetCookerByAcquireOrderFactoryName()
				{
					return null;
				}

				// Token: 0x06005B15 RID: 23317 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B15")]
				[Address(RVA = "0x8804B0", Offset = "0x87EEB0", VA = "0x1808804B0")]
				public static string GetCookerByCookerTypeFactoryName(Rule rule)
				{
					return null;
				}

				// Token: 0x06005B16 RID: 23318 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B16")]
				[Address(RVA = "0x880500", Offset = "0x87EF00", VA = "0x180880500")]
				public static string GetCookerBySeriesTypeFactoryName(Rule rule)
				{
					return null;
				}

				// Token: 0x06005B17 RID: 23319 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B17")]
				[Address(RVA = "0x8805F0", Offset = "0x87EFF0", VA = "0x1808805F0")]
				public static string GetSeriesSelectionText(Cooker.CookerSeries series)
				{
					return null;
				}
			}

			// Token: 0x02000F1C RID: 3868
			[Token(Token = "0x2000F1C")]
			public static class IngredientFilter
			{
				// Token: 0x06005B18 RID: 23320 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B18")]
				[Address(RVA = "0x88B020", Offset = "0x889A20", VA = "0x18088B020")]
				public static string GetIngredientTypeName()
				{
					return null;
				}
			}

			// Token: 0x02000F1D RID: 3869
			[Token(Token = "0x2000F1D")]
			public static class ItemFilter
			{
				// Token: 0x06005B19 RID: 23321 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B19")]
				[Address(RVA = "0x88B960", Offset = "0x88A360", VA = "0x18088B960")]
				public static string GetItemTypeName()
				{
					return null;
				}

				// Token: 0x06005B1A RID: 23322 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B1A")]
				[Address(RVA = "0x88B6A0", Offset = "0x88A0A0", VA = "0x18088B6A0")]
				public static string GetItemByAcquireOrderFactoryName()
				{
					return null;
				}

				// Token: 0x06005B1B RID: 23323 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B1B")]
				[Address(RVA = "0x88BD50", Offset = "0x88A750", VA = "0x18088BD50")]
				public static string GetItemByTypeOrderFactoryName(Rule rule)
				{
					return null;
				}
			}

			// Token: 0x02000F1E RID: 3870
			[Token(Token = "0x2000F1E")]
			public static class RecipeFilter
			{
				// Token: 0x06005B1C RID: 23324 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B1C")]
				[Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60")]
				public static string GetRecipeByCookerFactoryName(Rule rule)
				{
					return null;
				}

				// Token: 0x06005B1D RID: 23325 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B1D")]
				[Address(RVA = "0x894DB0", Offset = "0x8937B0", VA = "0x180894DB0")]
				public static string GetRecipeByTagFactoryName(Rule rule)
				{
					return null;
				}

				// Token: 0x06005B1E RID: 23326 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B1E")]
				[Address(RVA = "0x8949A0", Offset = "0x8933A0", VA = "0x1808949A0")]
				public static string GetRecipeByFoodPriceFactoryName()
				{
					return null;
				}

				// Token: 0x06005B1F RID: 23327 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B1F")]
				[Address(RVA = "0x8948A0", Offset = "0x8932A0", VA = "0x1808948A0")]
				public static string GetRecipeByFoodLevelFactoryName()
				{
					return null;
				}

				// Token: 0x06005B20 RID: 23328 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B20")]
				[Address(RVA = "0x894640", Offset = "0x893040", VA = "0x180894640")]
				public static string GetRecipeByCookCountFactoryName()
				{
					return null;
				}

				// Token: 0x06005B21 RID: 23329 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B21")]
				[Address(RVA = "0x894560", Offset = "0x892F60", VA = "0x180894560")]
				public static string GetRecipeByAcquireOrderFactoryName()
				{
					return null;
				}
			}

			// Token: 0x02000F1F RID: 3871
			[Token(Token = "0x2000F1F")]
			public static class SellableFilter
			{
				// Token: 0x06005B22 RID: 23330 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B22")]
				[Address(RVA = "0x8959B0", Offset = "0x8943B0", VA = "0x1808959B0")]
				public static string GetSellableName(Sellable.SellableType sellableType)
				{
					return null;
				}

				// Token: 0x06005B23 RID: 23331 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6005B23")]
				[Address(RVA = "0x8954D0", Offset = "0x893ED0", VA = "0x1808954D0")]
				public static string GetIsDailySellableFactoryName()
				{
					return null;
				}
			}
		}

		// Token: 0x02000F20 RID: 3872
		[Token(Token = "0x2000F20")]
		private abstract class NonTradableByCountFactory<TNonTradableObjectBase> : FilterOptions.TmiByValueOrderConfigFactory<int, TNonTradableObjectBase> where TNonTradableObjectBase : NonTradableObjectBase
		{
			// Token: 0x17000CCD RID: 3277
			// (get) Token: 0x06005B24 RID: 23332
			[Token(Token = "0x17000CCD")]
			protected abstract string GetObjectName
			{
				[Token(Token = "0x6005B24")]
				get;
			}

			// Token: 0x17000CCE RID: 3278
			// (get) Token: 0x06005B25 RID: 23333 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CCE")]
			public sealed override string FactoryName
			{
				[Token(Token = "0x6005B25")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005B26 RID: 23334
			[Token(Token = "0x6005B26")]
			protected abstract Dictionary<int, int> GetCountList();

			// Token: 0x06005B27 RID: 23335 RVA: 0x0001FD10 File Offset: 0x0001DF10
			[Token(Token = "0x6005B27")]
			protected sealed override int GetFocusing(TNonTradableObjectBase ordering)
			{
				return 0;
			}

			// Token: 0x06005B28 RID: 23336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B28")]
			protected NonTradableByCountFactory(uint selectionPriorityWeight)
			{
			}
		}

		// Token: 0x02000F21 RID: 3873
		[Token(Token = "0x2000F21")]
		private abstract class NonTradableByAcquireOrderFactory<TNonTradableObjectBase> : FilterOptions.TmiByValueOrderConfigFactory<int, TNonTradableObjectBase> where TNonTradableObjectBase : NonTradableObjectBase
		{
			// Token: 0x06005B29 RID: 23337
			[Token(Token = "0x6005B29")]
			protected abstract List<int> GetAcquireOrderList();

			// Token: 0x06005B2A RID: 23338 RVA: 0x0001FD28 File Offset: 0x0001DF28
			[Token(Token = "0x6005B2A")]
			protected sealed override int GetFocusing(TNonTradableObjectBase ordering)
			{
				return 0;
			}

			// Token: 0x06005B2B RID: 23339 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B2B")]
			protected NonTradableByAcquireOrderFactory(uint selectionPriorityWeight)
			{
			}
		}

		// Token: 0x02000F22 RID: 3874
		[Token(Token = "0x2000F22")]
		private abstract class TmiByValueOrderConfigFactory<TFocusing, TOrdering> : ByValueOrderConfigFactory<TFocusing, TOrdering>
		{
			// Token: 0x06005B2C RID: 23340 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B2C")]
			protected sealed override string GetSelectionTextTyped(Order value)
			{
				return null;
			}

			// Token: 0x06005B2D RID: 23341 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B2D")]
			protected TmiByValueOrderConfigFactory(uint selectionPriorityWeight)
			{
			}
		}

		// Token: 0x02000F23 RID: 3875
		[Token(Token = "0x2000F23")]
		private class TmiByFirstLetterFactory<TOrdering> : FilterOptions.TmiByValueOrderConfigFactory<ushort, TOrdering> where TOrdering : NonTradableObjectBase
		{
			// Token: 0x17000CCF RID: 3279
			// (get) Token: 0x06005B2E RID: 23342 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CCF")]
			public override string FactoryName
			{
				[Token(Token = "0x6005B2E")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000CD0 RID: 3280
			// (get) Token: 0x06005B2F RID: 23343 RVA: 0x0001FD40 File Offset: 0x0001DF40
			[Token(Token = "0x17000CD0")]
			protected override bool InvertSelection
			{
				[Token(Token = "0x6005B2F")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06005B30 RID: 23344 RVA: 0x0001FD58 File Offset: 0x0001DF58
			[Token(Token = "0x6005B30")]
			public override bool ShouldEnable()
			{
				return default(bool);
			}

			// Token: 0x06005B31 RID: 23345 RVA: 0x0001FD70 File Offset: 0x0001DF70
			[Token(Token = "0x6005B31")]
			protected override ushort GetFocusing(TOrdering ordering)
			{
				return 0;
			}

			// Token: 0x06005B32 RID: 23346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B32")]
			public TmiByFirstLetterFactory(uint selectionPriorityWeight)
			{
			}
		}

		// Token: 0x02000F24 RID: 3876
		[Token(Token = "0x2000F24")]
		private abstract class RecipeByFoodFactory<TOrderValue> : FilterOptions.TmiByValueOrderConfigFactory<TOrderValue, Recipe>
		{
			// Token: 0x06005B33 RID: 23347
			[Token(Token = "0x6005B33")]
			protected abstract TOrderValue GetValue(Sellable food);

			// Token: 0x06005B34 RID: 23348 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B34")]
			protected sealed override TOrderValue GetFocusing(Recipe ordering)
			{
				return null;
			}

			// Token: 0x06005B35 RID: 23349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B35")]
			protected RecipeByFoodFactory(uint selectionPriorityWeight)
			{
			}
		}

		// Token: 0x02000F25 RID: 3877
		[Token(Token = "0x2000F25")]
		private class RecipeByCookerFactory : ByValueContainsConfigFactory<Cooker.CookerType, Recipe>
		{
			// Token: 0x17000CD1 RID: 3281
			// (get) Token: 0x06005B36 RID: 23350 RVA: 0x0001FD88 File Offset: 0x0001DF88
			[Token(Token = "0x17000CD1")]
			protected override Rule ContainsRule
			{
				[Token(Token = "0x6005B36")]
				[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "24")]
				get
				{
					return Rule.ContainsAnd;
				}
			}

			// Token: 0x17000CD2 RID: 3282
			// (get) Token: 0x06005B37 RID: 23351 RVA: 0x0001FDA0 File Offset: 0x0001DFA0
			[Token(Token = "0x17000CD2")]
			public sealed override FilterType FilterType
			{
				[Token(Token = "0x6005B37")]
				[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "15")]
				get
				{
					return FilterType.SingleChoice;
				}
			}

			// Token: 0x17000CD3 RID: 3283
			// (get) Token: 0x06005B38 RID: 23352 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
			[Token(Token = "0x17000CD3")]
			public sealed override uint ColumnCount
			{
				[Token(Token = "0x6005B38")]
				[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "14")]
				get
				{
					return 0U;
				}
			}

			// Token: 0x06005B39 RID: 23353 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B39")]
			[Address(RVA = "0x894680", Offset = "0x893080", VA = "0x180894680", Slot = "25")]
			protected override string GetByTypeText(Rule rule)
			{
				return null;
			}

			// Token: 0x06005B3A RID: 23354 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B3A")]
			[Address(RVA = "0x894720", Offset = "0x893120", VA = "0x180894720", Slot = "21")]
			protected override IEnumerable<Cooker.CookerType> GetSelectionsTyped()
			{
				return null;
			}

			// Token: 0x06005B3B RID: 23355 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B3B")]
			[Address(RVA = "0x525790", Offset = "0x524190", VA = "0x180525790", Slot = "22")]
			protected override string GetSelectionTextTyped(Cooker.CookerType value)
			{
				return null;
			}

			// Token: 0x06005B3C RID: 23356 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B3C")]
			[Address(RVA = "0x8946D0", Offset = "0x8930D0", VA = "0x1808946D0", Slot = "26")]
			protected override IEnumerable<Cooker.CookerType> GetFocusing(Recipe ordering)
			{
				return null;
			}

			// Token: 0x06005B3D RID: 23357 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B3D")]
			[Address(RVA = "0x894800", Offset = "0x893200", VA = "0x180894800")]
			public RecipeByCookerFactory(uint selectionPriorityWeight)
			{
			}

			// Token: 0x040054D1 RID: 21713
			[Token(Token = "0x40054D1")]
			[FieldOffset(Offset = "0x0")]
			private static readonly IReadOnlyCollection<Cooker.CookerType> m_CookerTypes;
		}

		// Token: 0x02000F26 RID: 3878
		[Token(Token = "0x2000F26")]
		private class RecipeByTagFactory : ByValueContainsConfigFactory<int, Recipe>
		{
			// Token: 0x06005B3F RID: 23359 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B3F")]
			[Address(RVA = "0x894CE0", Offset = "0x8936E0", VA = "0x180894CE0")]
			public RecipeByTagFactory(bool contains, uint columnCount, uint selectionPriorityWeight)
			{
			}

			// Token: 0x17000CD4 RID: 3284
			// (get) Token: 0x06005B40 RID: 23360 RVA: 0x0001FDD0 File Offset: 0x0001DFD0
			[Token(Token = "0x17000CD4")]
			protected override Rule ContainsRule
			{
				[Token(Token = "0x6005B40")]
				[Address(RVA = "0x403830", Offset = "0x402230", VA = "0x180403830", Slot = "24")]
				[CompilerGenerated]
				get
				{
					return Rule.ContainsAnd;
				}
			}

			// Token: 0x17000CD5 RID: 3285
			// (get) Token: 0x06005B41 RID: 23361 RVA: 0x0001FDE8 File Offset: 0x0001DFE8
			[Token(Token = "0x17000CD5")]
			public sealed override FilterType FilterType
			{
				[Token(Token = "0x6005B41")]
				[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "15")]
				get
				{
					return FilterType.SingleChoice;
				}
			}

			// Token: 0x17000CD6 RID: 3286
			// (get) Token: 0x06005B42 RID: 23362 RVA: 0x0001FE00 File Offset: 0x0001E000
			[Token(Token = "0x17000CD6")]
			public sealed override uint ColumnCount
			{
				[Token(Token = "0x6005B42")]
				[Address(RVA = "0x4506E0", Offset = "0x44F0E0", VA = "0x1804506E0", Slot = "14")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x06005B43 RID: 23363 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B43")]
			[Address(RVA = "0x894A50", Offset = "0x893450", VA = "0x180894A50", Slot = "25")]
			protected override string GetByTypeText(Rule rule)
			{
				return null;
			}

			// Token: 0x06005B44 RID: 23364 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B44")]
			[Address(RVA = "0x894B40", Offset = "0x893540", VA = "0x180894B40", Slot = "21")]
			protected override IEnumerable<int> GetSelectionsTyped()
			{
				return null;
			}

			// Token: 0x06005B45 RID: 23365 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B45")]
			[Address(RVA = "0x4EA210", Offset = "0x4E8C10", VA = "0x1804EA210", Slot = "22")]
			protected override string GetSelectionTextTyped(int value)
			{
				return null;
			}

			// Token: 0x06005B46 RID: 23366 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B46")]
			[Address(RVA = "0x4A64E0", Offset = "0x4A4EE0", VA = "0x1804A64E0", Slot = "26")]
			protected override IEnumerable<int> GetFocusing(Recipe ordering)
			{
				return null;
			}
		}

		// Token: 0x02000F28 RID: 3880
		[Token(Token = "0x2000F28")]
		private class RecipeByFoodPriceFactory : FilterOptions.RecipeByFoodFactory<int>
		{
			// Token: 0x17000CD7 RID: 3287
			// (get) Token: 0x06005B4A RID: 23370 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CD7")]
			public override string FactoryName
			{
				[Token(Token = "0x6005B4A")]
				[Address(RVA = "0x8949A0", Offset = "0x8933A0", VA = "0x1808949A0", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005B4B RID: 23371 RVA: 0x0001FE18 File Offset: 0x0001E018
			[Token(Token = "0x6005B4B")]
			[Address(RVA = "0x61C040", Offset = "0x61AA40", VA = "0x18061C040", Slot = "26")]
			protected override int GetValue(Sellable food)
			{
				return 0;
			}

			// Token: 0x06005B4C RID: 23372 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B4C")]
			[Address(RVA = "0x894950", Offset = "0x893350", VA = "0x180894950")]
			public RecipeByFoodPriceFactory(uint selectionPriorityWeight)
			{
			}
		}

		// Token: 0x02000F29 RID: 3881
		[Token(Token = "0x2000F29")]
		private class RecipeByFoodLevelFactory : FilterOptions.RecipeByFoodFactory<int>
		{
			// Token: 0x17000CD8 RID: 3288
			// (get) Token: 0x06005B4D RID: 23373 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CD8")]
			public override string FactoryName
			{
				[Token(Token = "0x6005B4D")]
				[Address(RVA = "0x8948A0", Offset = "0x8932A0", VA = "0x1808948A0", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005B4E RID: 23374 RVA: 0x0001FE30 File Offset: 0x0001E030
			[Token(Token = "0x6005B4E")]
			[Address(RVA = "0x4054B0", Offset = "0x403EB0", VA = "0x1804054B0", Slot = "26")]
			protected override int GetValue(Sellable food)
			{
				return 0;
			}

			// Token: 0x06005B4F RID: 23375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B4F")]
			[Address(RVA = "0x894850", Offset = "0x893250", VA = "0x180894850")]
			public RecipeByFoodLevelFactory(uint selectionPriorityWeight)
			{
			}
		}

		// Token: 0x02000F2A RID: 3882
		[Token(Token = "0x2000F2A")]
		private class RecipeByCookCountFactory : FilterOptions.TmiByValueOrderConfigFactory<int, Recipe>
		{
			// Token: 0x17000CD9 RID: 3289
			// (get) Token: 0x06005B50 RID: 23376 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CD9")]
			public override string FactoryName
			{
				[Token(Token = "0x6005B50")]
				[Address(RVA = "0x894640", Offset = "0x893040", VA = "0x180894640", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005B51 RID: 23377 RVA: 0x0001FE48 File Offset: 0x0001E048
			[Token(Token = "0x6005B51")]
			[Address(RVA = "0x579CA0", Offset = "0x5786A0", VA = "0x180579CA0", Slot = "25")]
			protected override int GetFocusing(Recipe ordering)
			{
				return 0;
			}

			// Token: 0x06005B52 RID: 23378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B52")]
			[Address(RVA = "0x8945A0", Offset = "0x892FA0", VA = "0x1808945A0", Slot = "17")]
			public sealed override void OnWillFilter()
			{
			}

			// Token: 0x06005B53 RID: 23379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B53")]
			[Address(RVA = "0x8945F0", Offset = "0x892FF0", VA = "0x1808945F0")]
			public RecipeByCookCountFactory(uint selectionPriorityWeight)
			{
			}
		}

		// Token: 0x02000F2B RID: 3883
		[Token(Token = "0x2000F2B")]
		private class RecipeByAcquireOrderFactory : FilterOptions.TmiByValueOrderConfigFactory<int, Recipe>
		{
			// Token: 0x17000CDA RID: 3290
			// (get) Token: 0x06005B54 RID: 23380 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CDA")]
			public override string FactoryName
			{
				[Token(Token = "0x6005B54")]
				[Address(RVA = "0x894560", Offset = "0x892F60", VA = "0x180894560", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005B55 RID: 23381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B55")]
			[Address(RVA = "0x8944C0", Offset = "0x892EC0", VA = "0x1808944C0", Slot = "17")]
			public override void OnWillFilter()
			{
			}

			// Token: 0x06005B56 RID: 23382 RVA: 0x0001FE60 File Offset: 0x0001E060
			[Token(Token = "0x6005B56")]
			[Address(RVA = "0x894470", Offset = "0x892E70", VA = "0x180894470", Slot = "25")]
			protected override int GetFocusing(Recipe ordering)
			{
				return 0;
			}

			// Token: 0x06005B57 RID: 23383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B57")]
			[Address(RVA = "0x894510", Offset = "0x892F10", VA = "0x180894510")]
			public RecipeByAcquireOrderFactory(uint selectionPriorityWeight)
			{
			}

			// Token: 0x040054D6 RID: 21718
			[Token(Token = "0x40054D6")]
			[FieldOffset(Offset = "0x18")]
			private Recipe[] m_Recipes;
		}

		// Token: 0x02000F2C RID: 3884
		[Token(Token = "0x2000F2C")]
		private class SellableByTagFactory : FilterOptions.TradableByTagFactory<Sellable>
		{
			// Token: 0x06005B58 RID: 23384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B58")]
			[Address(RVA = "0x8958C0", Offset = "0x8942C0", VA = "0x1808958C0")]
			public SellableByTagFactory(Sellable.SellableType sellableType, bool contains, uint columnCount, uint selectionPriorityWeight)
			{
			}

			// Token: 0x17000CDB RID: 3291
			// (get) Token: 0x06005B59 RID: 23385 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CDB")]
			protected override string GetTradableName
			{
				[Token(Token = "0x6005B59")]
				[Address(RVA = "0x895940", Offset = "0x894340", VA = "0x180895940", Slot = "27")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005B5A RID: 23386 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B5A")]
			[Address(RVA = "0x8955F0", Offset = "0x893FF0", VA = "0x1808955F0", Slot = "21")]
			protected override IEnumerable<int> GetSelectionsTyped()
			{
				return null;
			}

			// Token: 0x06005B5B RID: 23387 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B5B")]
			[Address(RVA = "0x8955D0", Offset = "0x893FD0", VA = "0x1808955D0", Slot = "22")]
			protected override string GetSelectionTextTyped(int value)
			{
				return null;
			}

			// Token: 0x040054D7 RID: 21719
			[Token(Token = "0x40054D7")]
			[FieldOffset(Offset = "0x20")]
			private readonly Sellable.SellableType m_SellableType;
		}

		// Token: 0x02000F2E RID: 3886
		[Token(Token = "0x2000F2E")]
		private class SellableByPriceFactory : FilterOptions.TradableByPriceFactory<Sellable>
		{
			// Token: 0x06005B60 RID: 23392 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B60")]
			[Address(RVA = "0x895570", Offset = "0x893F70", VA = "0x180895570")]
			public SellableByPriceFactory(Sellable.SellableType sellableType, uint selectionPriorityWeight)
			{
			}

			// Token: 0x17000CDC RID: 3292
			// (get) Token: 0x06005B61 RID: 23393 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CDC")]
			protected override string GetTradableName
			{
				[Token(Token = "0x6005B61")]
				[Address(RVA = "0x894FB0", Offset = "0x8939B0", VA = "0x180894FB0", Slot = "26")]
				get
				{
					return null;
				}
			}

			// Token: 0x040054DB RID: 21723
			[Token(Token = "0x40054DB")]
			[FieldOffset(Offset = "0x18")]
			private readonly Sellable.SellableType m_SellableType;
		}

		// Token: 0x02000F2F RID: 3887
		[Token(Token = "0x2000F2F")]
		private class SellableByLevelFactory : FilterOptions.TradableByLevelFactory<Sellable>
		{
			// Token: 0x06005B62 RID: 23394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B62")]
			[Address(RVA = "0x895510", Offset = "0x893F10", VA = "0x180895510")]
			public SellableByLevelFactory(Sellable.SellableType sellableType, uint selectionPriorityWeight)
			{
			}

			// Token: 0x17000CDD RID: 3293
			// (get) Token: 0x06005B63 RID: 23395 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CDD")]
			protected override string GetTradableName
			{
				[Token(Token = "0x6005B63")]
				[Address(RVA = "0x894FB0", Offset = "0x8939B0", VA = "0x180894FB0", Slot = "26")]
				get
				{
					return null;
				}
			}

			// Token: 0x040054DC RID: 21724
			[Token(Token = "0x40054DC")]
			[FieldOffset(Offset = "0x18")]
			private readonly Sellable.SellableType m_SellableType;
		}

		// Token: 0x02000F30 RID: 3888
		[Token(Token = "0x2000F30")]
		private class SellableByInDailyMenuFactory : FilterOptions.TmiByValueOrderConfigFactory<bool, Sellable>
		{
			// Token: 0x06005B64 RID: 23396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B64")]
			[Address(RVA = "0x895480", Offset = "0x893E80", VA = "0x180895480")]
			public SellableByInDailyMenuFactory(uint selectionPriorityWeight)
			{
			}

			// Token: 0x17000CDE RID: 3294
			// (get) Token: 0x06005B65 RID: 23397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CDE")]
			public override string FactoryName
			{
				[Token(Token = "0x6005B65")]
				[Address(RVA = "0x8954D0", Offset = "0x893ED0", VA = "0x1808954D0", Slot = "16")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005B66 RID: 23398 RVA: 0x0001FE78 File Offset: 0x0001E078
			[Token(Token = "0x6005B66")]
			[Address(RVA = "0x8952A0", Offset = "0x893CA0", VA = "0x1808952A0", Slot = "25")]
			protected override bool GetFocusing(Sellable ordering)
			{
				return default(bool);
			}
		}

		// Token: 0x02000F32 RID: 3890
		[Token(Token = "0x2000F32")]
		private class SellableByCountFactory : FilterOptions.TradableByCountFactory<Sellable>
		{
			// Token: 0x06005B6A RID: 23402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B6A")]
			[Address(RVA = "0x895240", Offset = "0x893C40", VA = "0x180895240")]
			public SellableByCountFactory(Sellable.SellableType sellableType, uint selectionPriorityWeight)
			{
			}

			// Token: 0x17000CDF RID: 3295
			// (get) Token: 0x06005B6B RID: 23403 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CDF")]
			protected override string GetObjectName
			{
				[Token(Token = "0x6005B6B")]
				[Address(RVA = "0x894FB0", Offset = "0x8939B0", VA = "0x180894FB0", Slot = "26")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005B6C RID: 23404 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B6C")]
			[Address(RVA = "0x895020", Offset = "0x893A20", VA = "0x180895020", Slot = "17")]
			public override void OnWillFilter()
			{
			}

			// Token: 0x06005B6D RID: 23405 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B6D")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0", Slot = "27")]
			protected override Dictionary<int, int> GetCountList()
			{
				return null;
			}

			// Token: 0x040054DE RID: 21726
			[Token(Token = "0x40054DE")]
			[FieldOffset(Offset = "0x18")]
			private readonly Sellable.SellableType m_SellableType;

			// Token: 0x040054DF RID: 21727
			[Token(Token = "0x40054DF")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<int, int> m_CountCache;
		}

		// Token: 0x02000F34 RID: 3892
		[Token(Token = "0x2000F34")]
		private class SellableByAcquireOrderFactory : FilterOptions.TradableByAcquireOrderFactory<Sellable>
		{
			// Token: 0x06005B72 RID: 23410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B72")]
			[Address(RVA = "0x894F50", Offset = "0x893950", VA = "0x180894F50")]
			public SellableByAcquireOrderFactory(Sellable.SellableType sellableType, uint selectionPriorityWeight)
			{
			}

			// Token: 0x17000CE0 RID: 3296
			// (get) Token: 0x06005B73 RID: 23411 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CE0")]
			protected override string GetTradableName
			{
				[Token(Token = "0x6005B73")]
				[Address(RVA = "0x894FB0", Offset = "0x8939B0", VA = "0x180894FB0", Slot = "27")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005B74 RID: 23412 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B74")]
			[Address(RVA = "0x894EA0", Offset = "0x8938A0", VA = "0x180894EA0", Slot = "17")]
			public override void OnWillFilter()
			{
			}

			// Token: 0x06005B75 RID: 23413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B75")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0", Slot = "26")]
			protected override List<int> GetAcquireOrderList()
			{
				return null;
			}

			// Token: 0x040054E3 RID: 21731
			[Token(Token = "0x40054E3")]
			[FieldOffset(Offset = "0x18")]
			private readonly Sellable.SellableType m_SellableType;

			// Token: 0x040054E4 RID: 21732
			[Token(Token = "0x40054E4")]
			[FieldOffset(Offset = "0x20")]
			private List<int> m_AcquireOrderCache;
		}

		// Token: 0x02000F35 RID: 3893
		[Token(Token = "0x2000F35")]
		private abstract class TradableByTagFactory<TTradableObjectBase> : ByValueContainsConfigFactory<int, TTradableObjectBase> where TTradableObjectBase : TradableObjectBase
		{
			// Token: 0x06005B76 RID: 23414 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B76")]
			protected TradableByTagFactory(bool contains, uint columnCount, uint selectionPriorityWeight)
			{
			}

			// Token: 0x17000CE1 RID: 3297
			// (get) Token: 0x06005B77 RID: 23415 RVA: 0x0001FEF0 File Offset: 0x0001E0F0
			[Token(Token = "0x17000CE1")]
			public sealed override FilterType FilterType
			{
				[Token(Token = "0x6005B77")]
				get
				{
					return FilterType.SingleChoice;
				}
			}

			// Token: 0x17000CE2 RID: 3298
			// (get) Token: 0x06005B78 RID: 23416 RVA: 0x0001FF08 File Offset: 0x0001E108
			[Token(Token = "0x17000CE2")]
			public sealed override uint ColumnCount
			{
				[Token(Token = "0x6005B78")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x17000CE3 RID: 3299
			// (get) Token: 0x06005B79 RID: 23417
			[Token(Token = "0x17000CE3")]
			protected abstract string GetTradableName
			{
				[Token(Token = "0x6005B79")]
				get;
			}

			// Token: 0x17000CE4 RID: 3300
			// (get) Token: 0x06005B7A RID: 23418 RVA: 0x0001FF20 File Offset: 0x0001E120
			[Token(Token = "0x17000CE4")]
			protected sealed override Rule ContainsRule
			{
				[Token(Token = "0x6005B7A")]
				[CompilerGenerated]
				get
				{
					return Rule.ContainsAnd;
				}
			}

			// Token: 0x06005B7B RID: 23419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B7B")]
			protected sealed override string GetByTypeText(Rule rule)
			{
				return null;
			}

			// Token: 0x06005B7C RID: 23420 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B7C")]
			protected sealed override IEnumerable<int> GetFocusing(TTradableObjectBase ordering)
			{
				return null;
			}
		}

		// Token: 0x02000F36 RID: 3894
		[Token(Token = "0x2000F36")]
		private abstract class TradableByPriceFactory<TTradableObjectBase> : FilterOptions.TmiByValueOrderConfigFactory<int, TTradableObjectBase> where TTradableObjectBase : TradableObjectBase
		{
			// Token: 0x17000CE5 RID: 3301
			// (get) Token: 0x06005B7D RID: 23421
			[Token(Token = "0x17000CE5")]
			protected abstract string GetTradableName
			{
				[Token(Token = "0x6005B7D")]
				get;
			}

			// Token: 0x17000CE6 RID: 3302
			// (get) Token: 0x06005B7E RID: 23422 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CE6")]
			public sealed override string FactoryName
			{
				[Token(Token = "0x6005B7E")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005B7F RID: 23423 RVA: 0x0001FF38 File Offset: 0x0001E138
			[Token(Token = "0x6005B7F")]
			protected sealed override int GetFocusing(TTradableObjectBase ordering)
			{
				return 0;
			}

			// Token: 0x06005B80 RID: 23424 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B80")]
			protected TradableByPriceFactory(uint selectionPriorityWeight)
			{
			}
		}

		// Token: 0x02000F37 RID: 3895
		[Token(Token = "0x2000F37")]
		private abstract class TradableByLevelFactory<TTradableObjectBase> : FilterOptions.TmiByValueOrderConfigFactory<int, TTradableObjectBase> where TTradableObjectBase : TradableObjectBase
		{
			// Token: 0x17000CE7 RID: 3303
			// (get) Token: 0x06005B81 RID: 23425
			[Token(Token = "0x17000CE7")]
			protected abstract string GetTradableName
			{
				[Token(Token = "0x6005B81")]
				get;
			}

			// Token: 0x17000CE8 RID: 3304
			// (get) Token: 0x06005B82 RID: 23426 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CE8")]
			public sealed override string FactoryName
			{
				[Token(Token = "0x6005B82")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005B83 RID: 23427 RVA: 0x0001FF50 File Offset: 0x0001E150
			[Token(Token = "0x6005B83")]
			protected sealed override int GetFocusing(TTradableObjectBase ordering)
			{
				return 0;
			}

			// Token: 0x06005B84 RID: 23428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B84")]
			protected TradableByLevelFactory(uint selectionPriorityWeight)
			{
			}
		}

		// Token: 0x02000F38 RID: 3896
		[Token(Token = "0x2000F38")]
		private abstract class TradableByCountFactory<TTradableObjectBase> : FilterOptions.NonTradableByCountFactory<TTradableObjectBase> where TTradableObjectBase : TradableObjectBase
		{
			// Token: 0x06005B85 RID: 23429 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B85")]
			protected TradableByCountFactory(uint selectionPriorityWeight)
			{
			}
		}

		// Token: 0x02000F39 RID: 3897
		[Token(Token = "0x2000F39")]
		private abstract class TradableByAcquireOrderFactory<TTradableObjectBase> : FilterOptions.NonTradableByAcquireOrderFactory<TTradableObjectBase> where TTradableObjectBase : TradableObjectBase
		{
			// Token: 0x17000CE9 RID: 3305
			// (get) Token: 0x06005B86 RID: 23430
			[Token(Token = "0x17000CE9")]
			protected abstract string GetTradableName
			{
				[Token(Token = "0x6005B86")]
				get;
			}

			// Token: 0x17000CEA RID: 3306
			// (get) Token: 0x06005B87 RID: 23431 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000CEA")]
			public sealed override string FactoryName
			{
				[Token(Token = "0x6005B87")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005B88 RID: 23432 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B88")]
			protected TradableByAcquireOrderFactory(uint selectionPriorityWeight)
			{
			}
		}
	}
}

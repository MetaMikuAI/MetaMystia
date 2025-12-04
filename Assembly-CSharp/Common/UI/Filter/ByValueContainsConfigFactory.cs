using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EE4 RID: 3812
	[Token(Token = "0x2000EE4")]
	public abstract class ByValueContainsConfigFactory<TFocusing, TOrdering> : FilterContainsConfigFactoryTyped<TOrdering, TFocusing>
	{
		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060059FE RID: 23038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6F")]
		public sealed override string FactoryName
		{
			[Token(Token = "0x60059FE")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060059FF RID: 23039
		[Token(Token = "0x17000C70")]
		protected abstract Rule ContainsRule
		{
			[Token(Token = "0x60059FF")]
			get;
		}

		// Token: 0x06005A00 RID: 23040
		[Token(Token = "0x6005A00")]
		protected abstract string GetByTypeText(Rule rule);

		// Token: 0x06005A01 RID: 23041
		[Token(Token = "0x6005A01")]
		protected abstract IEnumerable<TFocusing> GetFocusing(TOrdering ordering);

		// Token: 0x06005A02 RID: 23042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A02")]
		protected override WhereFilterConfig<TOrdering> CreateFilterConfig(IEnumerable<TFocusing> value)
		{
			return null;
		}

		// Token: 0x06005A03 RID: 23043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A03")]
		protected ByValueContainsConfigFactory(uint selectionPriorityWeight)
		{
		}

		// Token: 0x02000EE5 RID: 3813
		[Token(Token = "0x2000EE5")]
		private class ByValueContainsConfig : WhereFilterConfig<TOrdering>
		{
			// Token: 0x06005A04 RID: 23044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A04")]
			public ByValueContainsConfig(IFilterConfigFactory factory, IEnumerable<TFocusing> focusing)
			{
			}

			// Token: 0x17000C71 RID: 3185
			// (get) Token: 0x06005A05 RID: 23045 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C71")]
			private ByValueContainsConfigFactory<TFocusing, TOrdering> TypedFactory
			{
				[Token(Token = "0x6005A05")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000C72 RID: 3186
			// (get) Token: 0x06005A06 RID: 23046 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C72")]
			public sealed override IEnumerable<object> SelectedElements
			{
				[Token(Token = "0x6005A06")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A07 RID: 23047 RVA: 0x0001FA10 File Offset: 0x0001DC10
			[Token(Token = "0x6005A07")]
			protected override bool OnWhere(TOrdering value)
			{
				return default(bool);
			}

			// Token: 0x04005471 RID: 21617
			[Token(Token = "0x4005471")]
			[FieldOffset(Offset = "0x0")]
			private readonly HashSet<TFocusing> m_Focusing;
		}
	}
}

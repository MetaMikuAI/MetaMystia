using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EE6 RID: 3814
	[Token(Token = "0x2000EE6")]
	public abstract class ByValueEqualityConfigFactory<TFocusing, TOrdering> : FilterWhereConfigFactoryTyped<TOrdering, TFocusing>
	{
		// Token: 0x06005A08 RID: 23048
		[Token(Token = "0x6005A08")]
		protected abstract TFocusing GetFocusing(TOrdering ordering);

		// Token: 0x06005A09 RID: 23049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A09")]
		protected override WhereFilterConfig<TOrdering> CreateFilterConfig(TFocusing value)
		{
			return null;
		}

		// Token: 0x06005A0A RID: 23050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A0A")]
		protected ByValueEqualityConfigFactory(uint selectionPriorityWeight)
		{
		}

		// Token: 0x02000EE7 RID: 3815
		[Token(Token = "0x2000EE7")]
		private class ByValueEqualityConfig : WhereFilterConfig<TOrdering>
		{
			// Token: 0x06005A0B RID: 23051 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005A0B")]
			public ByValueEqualityConfig(IFilterConfigFactory factory, TFocusing equals)
			{
			}

			// Token: 0x17000C73 RID: 3187
			// (get) Token: 0x06005A0C RID: 23052 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C73")]
			private ByValueEqualityConfigFactory<TFocusing, TOrdering> TypedFactory
			{
				[Token(Token = "0x6005A0C")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000C74 RID: 3188
			// (get) Token: 0x06005A0D RID: 23053 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C74")]
			public override IEnumerable<object> SelectedElements
			{
				[Token(Token = "0x6005A0D")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005A0E RID: 23054 RVA: 0x0001FA28 File Offset: 0x0001DC28
			[Token(Token = "0x6005A0E")]
			protected override bool OnWhere(TOrdering value)
			{
				return default(bool);
			}

			// Token: 0x04005472 RID: 21618
			[Token(Token = "0x4005472")]
			[FieldOffset(Offset = "0x0")]
			private readonly TFocusing m_Equals;
		}
	}
}

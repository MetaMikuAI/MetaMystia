using System;
using System.Collections.Generic;
using System.Linq;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EEF RID: 3823
	[Token(Token = "0x2000EEF")]
	public abstract class OrderFilterConfig<TOrderingElement, TFocusingElement> : BaseFilterConfig
	{
		// Token: 0x06005A2A RID: 23082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2A")]
		protected OrderFilterConfig(IFilterConfigFactory factory, Order order)
		{
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06005A2B RID: 23083 RVA: 0x0001FA58 File Offset: 0x0001DC58
		[Token(Token = "0x17000C7E")]
		public sealed override IFilterConfig.Type FilterType
		{
			[Token(Token = "0x6005A2B")]
			get
			{
				return IFilterConfig.Type.Where;
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06005A2C RID: 23084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7F")]
		public override IEnumerable<object> SelectedElements
		{
			[Token(Token = "0x6005A2C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005A2D RID: 23085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A2D")]
		public sealed override IOrderedEnumerable<object> DoFilter(IEnumerable<object> objectsToFilter)
		{
			return null;
		}

		// Token: 0x06005A2E RID: 23086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A2E")]
		public sealed override IOrderedEnumerable<object> DoFilter(IOrderedEnumerable<object> objectsToFilter)
		{
			return null;
		}

		// Token: 0x06005A2F RID: 23087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A2F")]
		private TFocusingElement InternalValueSelector(object value)
		{
			return null;
		}

		// Token: 0x06005A30 RID: 23088
		[Token(Token = "0x6005A30")]
		protected abstract TFocusingElement GetFocusingElement(TOrderingElement orderingElement);

		// Token: 0x0400547E RID: 21630
		[Token(Token = "0x400547E")]
		[FieldOffset(Offset = "0x0")]
		private readonly Order m_Order;
	}
}

using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EF1 RID: 3825
	[Token(Token = "0x2000EF1")]
	public abstract class WhereFilterConfig<T> : BaseFilterConfig
	{
		// Token: 0x06005A39 RID: 23097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A39")]
		protected WhereFilterConfig(IFilterConfigFactory factory)
		{
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06005A3A RID: 23098 RVA: 0x0001FA88 File Offset: 0x0001DC88
		[Token(Token = "0x17000C82")]
		public sealed override IFilterConfig.Type FilterType
		{
			[Token(Token = "0x6005A3A")]
			get
			{
				return IFilterConfig.Type.Where;
			}
		}

		// Token: 0x06005A3B RID: 23099
		[Token(Token = "0x6005A3B")]
		protected abstract bool OnWhere(T value);

		// Token: 0x06005A3C RID: 23100 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
		[Token(Token = "0x6005A3C")]
		private bool InternalWhereSelector(object value)
		{
			return default(bool);
		}

		// Token: 0x06005A3D RID: 23101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A3D")]
		public sealed override IEnumerable<object> DoWhere(IEnumerable<object> objectsToFilter)
		{
			return null;
		}
	}
}

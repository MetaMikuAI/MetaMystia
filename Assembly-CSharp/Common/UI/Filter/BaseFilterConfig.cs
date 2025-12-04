using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EED RID: 3821
	[Token(Token = "0x2000EED")]
	public abstract class BaseFilterConfig : IFilterConfig
	{
		// Token: 0x06005A23 RID: 23075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A23")]
		[Address(RVA = "0x46BA70", Offset = "0x46A470", VA = "0x18046BA70")]
		protected BaseFilterConfig(IFilterConfigFactory factory)
		{
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06005A24 RID: 23076
		[Token(Token = "0x17000C7B")]
		public abstract IEnumerable<object> SelectedElements
		{
			[Token(Token = "0x6005A24")]
			get;
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06005A25 RID: 23077
		[Token(Token = "0x17000C7C")]
		public abstract IFilterConfig.Type FilterType
		{
			[Token(Token = "0x6005A25")]
			get;
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06005A26 RID: 23078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C7D")]
		public IFilterConfigFactory Factory
		{
			[Token(Token = "0x6005A26")]
			[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A27")]
		[Address(RVA = "0x87FD20", Offset = "0x87E720", VA = "0x18087FD20", Slot = "12")]
		public virtual IOrderedEnumerable<object> DoFilter(IEnumerable<object> objectsToFilter)
		{
			return null;
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A28")]
		[Address(RVA = "0x87FD70", Offset = "0x87E770", VA = "0x18087FD70", Slot = "13")]
		public virtual IOrderedEnumerable<object> DoFilter(IOrderedEnumerable<object> objectsToFilter)
		{
			return null;
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A29")]
		[Address(RVA = "0x87FDC0", Offset = "0x87E7C0", VA = "0x18087FDC0", Slot = "14")]
		public virtual IEnumerable<object> DoWhere(IEnumerable<object> objectsToFilter)
		{
			return null;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Common.UI.Filter
{
	// Token: 0x02000EF7 RID: 3831
	[Token(Token = "0x2000EF7")]
	public abstract class FilterConfigFactory<TOrderingType> : IFilterConfigFactory
	{
		// Token: 0x06005A52 RID: 23122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A52")]
		protected FilterConfigFactory(uint selectionPriorityWeight)
		{
		}

		// Token: 0x06005A53 RID: 23123 RVA: 0x0001FB18 File Offset: 0x0001DD18
		[Token(Token = "0x6005A53")]
		public virtual bool ShouldEnable()
		{
			return default(bool);
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06005A54 RID: 23124 RVA: 0x0001FB30 File Offset: 0x0001DD30
		[Token(Token = "0x17000C87")]
		public virtual uint ColumnCount
		{
			[Token(Token = "0x6005A54")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06005A55 RID: 23125 RVA: 0x0001FB48 File Offset: 0x0001DD48
		[Token(Token = "0x17000C88")]
		public uint SelectionPriorityWeight
		{
			[Token(Token = "0x6005A55")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06005A56 RID: 23126
		[Token(Token = "0x17000C89")]
		public abstract FilterType FilterType
		{
			[Token(Token = "0x6005A56")]
			get;
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06005A57 RID: 23127
		[Token(Token = "0x17000C8A")]
		public abstract string FactoryName
		{
			[Token(Token = "0x6005A57")]
			get;
		}

		// Token: 0x06005A58 RID: 23128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A58")]
		private IEnumerable<object> Common.UI.Filter.IFilterConfigFactory.GetSelections()
		{
			return null;
		}

		// Token: 0x06005A59 RID: 23129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A59")]
		private IFilterConfig Common.UI.Filter.IFilterConfigFactory.CreateFilterConfig(IReadOnlyList<object> value)
		{
			return null;
		}

		// Token: 0x06005A5A RID: 23130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005A5A")]
		private string Common.UI.Filter.IFilterConfigFactory.GetSelectionText(object value)
		{
			return null;
		}

		// Token: 0x06005A5B RID: 23131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A5B")]
		public virtual void OnWillFilter()
		{
		}

		// Token: 0x06005A5C RID: 23132
		[Token(Token = "0x6005A5C")]
		protected abstract IEnumerable<object> GetSelections();

		// Token: 0x06005A5D RID: 23133
		[Token(Token = "0x6005A5D")]
		protected abstract BaseFilterConfig CreateFilterConfig(IReadOnlyList<object> value);

		// Token: 0x06005A5E RID: 23134
		[Token(Token = "0x6005A5E")]
		protected abstract string GetSelectionText(object value);
	}
}

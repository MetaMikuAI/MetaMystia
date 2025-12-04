using System;
using System.Collections.Generic;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core
{
	// Token: 0x020008A8 RID: 2216
	[Token(Token = "0x20008A8")]
	[Serializable]
	public abstract class TradableObjectBase : NonTradableObjectBase
	{
		// Token: 0x0600369C RID: 13980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600369C")]
		[Address(RVA = "0x674510", Offset = "0x672F10", VA = "0x180674510")]
		public TradableObjectBase(int id, int level, int baseValue, int[] tags)
		{
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x00014B08 File Offset: 0x00012D08
		[Token(Token = "0x17000715")]
		public int Level
		{
			[Token(Token = "0x600369D")]
			[Address(RVA = "0x403830", Offset = "0x402230", VA = "0x180403830")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x0600369E RID: 13982 RVA: 0x00014B20 File Offset: 0x00012D20
		[Token(Token = "0x17000716")]
		public int BaseValue
		{
			[Token(Token = "0x600369E")]
			[Address(RVA = "0x4506E0", Offset = "0x44F0E0", VA = "0x1804506E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x0600369F RID: 13983 RVA: 0x00014B38 File Offset: 0x00012D38
		[Token(Token = "0x17000717")]
		public int TrueValue
		{
			[Token(Token = "0x600369F")]
			[Address(RVA = "0x674570", Offset = "0x672F70", VA = "0x180674570")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060036A0 RID: 13984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000718")]
		public virtual int[] Tags
		{
			[Token(Token = "0x60036A0")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060036A1 RID: 13985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000719")]
		public int[] RawTags
		{
			[Token(Token = "0x60036A1")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060036A2 RID: 13986
		[Token(Token = "0x60036A2")]
		protected abstract SchedulerNode.Reward.ObjectType OnGetObjectType();

		// Token: 0x060036A3 RID: 13987 RVA: 0x00014B50 File Offset: 0x00012D50
		[Token(Token = "0x60036A3")]
		[Address(RVA = "0x6744A0", Offset = "0x672EA0", VA = "0x1806744A0")]
		private KeyValuePair<SchedulerNode.Reward.ObjectType, int> GetGlobalKey()
		{
			return default(KeyValuePair<SchedulerNode.Reward.ObjectType, int>);
		}

		// Token: 0x04002F2F RID: 12079
		[Token(Token = "0x4002F2F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int level;

		// Token: 0x04002F30 RID: 12080
		[Token(Token = "0x4002F30")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int baseValue;

		// Token: 0x04002F31 RID: 12081
		[Token(Token = "0x4002F31")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected int[] tags;

		// Token: 0x020008A9 RID: 2217
		[Token(Token = "0x20008A9")]
		public enum SortType
		{
			// Token: 0x04002F33 RID: 12083
			[Token(Token = "0x4002F33")]
			ID,
			// Token: 0x04002F34 RID: 12084
			[Token(Token = "0x4002F34")]
			Level,
			// Token: 0x04002F35 RID: 12085
			[Token(Token = "0x4002F35")]
			Value
		}
	}
}

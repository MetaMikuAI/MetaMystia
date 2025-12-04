using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace GameData.RunTime.Common
{
	// Token: 0x020007FB RID: 2043
	[Token(Token = "0x20007FB")]
	public struct GameDate
	{
		// Token: 0x06003060 RID: 12384 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		[Token(Token = "0x6003060")]
		[Address(RVA = "0x604020", Offset = "0x602A20", VA = "0x180604020")]
		public int ToCorrectedDay(int originDay)
		{
			return 0;
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06003061 RID: 12385 RVA: 0x00011B08 File Offset: 0x0000FD08
		[Token(Token = "0x17000651")]
		[JsonIgnore]
		public int Year
		{
			[Token(Token = "0x6003061")]
			[Address(RVA = "0x6048A0", Offset = "0x6032A0", VA = "0x1806048A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x00011B20 File Offset: 0x0000FD20
		[Token(Token = "0x17000652")]
		[JsonIgnore]
		public int Week
		{
			[Token(Token = "0x6003062")]
			[Address(RVA = "0x604880", Offset = "0x603280", VA = "0x180604880")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06003063 RID: 12387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000653")]
		[JsonIgnore]
		public string DaysOfTheWeek
		{
			[Token(Token = "0x6003063")]
			[Address(RVA = "0x6047A0", Offset = "0x6031A0", VA = "0x1806047A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06003064 RID: 12388 RVA: 0x00011B38 File Offset: 0x0000FD38
		[Token(Token = "0x17000654")]
		[JsonIgnore]
		public int Day
		{
			[Token(Token = "0x6003064")]
			[Address(RVA = "0x604770", Offset = "0x603170", VA = "0x180604770")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06003065 RID: 12389 RVA: 0x00011B50 File Offset: 0x0000FD50
		[Token(Token = "0x17000655")]
		[JsonIgnore]
		public int Month
		{
			[Token(Token = "0x6003065")]
			[Address(RVA = "0x604840", Offset = "0x603240", VA = "0x180604840")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x00011B68 File Offset: 0x0000FD68
		[Token(Token = "0x17000656")]
		[JsonIgnore]
		public GameDate.Season CurrentSeason
		{
			[Token(Token = "0x6003066")]
			[Address(RVA = "0x604720", Offset = "0x603120", VA = "0x180604720")]
			get
			{
				return GameDate.Season.Spring;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06003067 RID: 12391 RVA: 0x00011B80 File Offset: 0x0000FD80
		// (set) Token: 0x06003068 RID: 12392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000657")]
		[JsonIgnore]
		public int CorrectedDay
		{
			[Token(Token = "0x6003067")]
			[Address(RVA = "0x604710", Offset = "0x603110", VA = "0x180604710")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003068")]
			[Address(RVA = "0x604910", Offset = "0x603310", VA = "0x180604910")]
			set
			{
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06003069 RID: 12393 RVA: 0x00011B98 File Offset: 0x0000FD98
		// (set) Token: 0x0600306A RID: 12394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000658")]
		[JsonIgnore]
		public int ActuallDay
		{
			[Token(Token = "0x6003069")]
			[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600306A")]
			[Address(RVA = "0x425CA0", Offset = "0x4246A0", VA = "0x180425CA0")]
			set
			{
			}
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306B")]
		[Address(RVA = "0x6041C0", Offset = "0x602BC0", VA = "0x1806041C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600306C RID: 12396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306C")]
		[Address(RVA = "0x604030", Offset = "0x602A30", VA = "0x180604030")]
		public static string ToDetailedText(int inDay)
		{
			return null;
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600306D")]
		[Address(RVA = "0x603EE0", Offset = "0x6028E0", VA = "0x180603EE0")]
		public string DetailedText()
		{
			return null;
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		[Token(Token = "0x600306E")]
		[Address(RVA = "0x6048F0", Offset = "0x6032F0", VA = "0x1806048F0")]
		public static GameDate operator +(GameDate date, int day)
		{
			return default(GameDate);
		}

		// Token: 0x04002B32 RID: 11058
		[Token(Token = "0x4002B32")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] daysOfTheWeek;

		// Token: 0x04002B33 RID: 11059
		[Token(Token = "0x4002B33")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[JsonProperty]
		private int day;

		// Token: 0x04002B34 RID: 11060
		[Token(Token = "0x4002B34")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[JsonProperty]
		public int correctionOffset;

		// Token: 0x020007FC RID: 2044
		[Token(Token = "0x20007FC")]
		public enum Season
		{
			// Token: 0x04002B36 RID: 11062
			[Token(Token = "0x4002B36")]
			Spring,
			// Token: 0x04002B37 RID: 11063
			[Token(Token = "0x4002B37")]
			Summer,
			// Token: 0x04002B38 RID: 11064
			[Token(Token = "0x4002B38")]
			Autumn,
			// Token: 0x04002B39 RID: 11065
			[Token(Token = "0x4002B39")]
			Winter
		}
	}
}

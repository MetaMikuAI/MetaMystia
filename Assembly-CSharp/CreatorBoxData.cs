using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using Newtonsoft.Json;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
[JsonObject(MemberSerialization.OptIn)]
public struct CreatorBoxData : IDeepClonable<CreatorBoxData>
{
	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000008")]
	public IReadOnlyList<CreatorBoxData.SpecGuestRefreshNode> SpecGuestSettingStream
	{
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x4070A0", Offset = "0x405AA0", VA = "0x1804070A0")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600001A RID: 26 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x406EC0", Offset = "0x4058C0", VA = "0x180406EC0")]
	public static CreatorBoxData Create()
	{
		return default(CreatorBoxData);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x406F40", Offset = "0x405940", VA = "0x180406F40")]
	public CreatorBoxData([TupleElementNames(new string[] { "time", "guestId" })] IEnumerable<ValueTuple<int, int>> values)
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x3EC190", Offset = "0x3EAB90", VA = "0x1803EC190")]
	public CreatorBoxData(List<CreatorBoxData.SpecGuestRefreshNode> stream)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x406E60", Offset = "0x405860", VA = "0x180406E60", Slot = "4")]
	public CreatorBoxData Clone()
	{
		return default(CreatorBoxData);
	}

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x0")]
	[JsonProperty("SpecGuestSettingStream")]
	private List<CreatorBoxData.SpecGuestRefreshNode> m_Stream;

	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	[JsonObject(MemberSerialization.OptIn)]
	public readonly struct SpecGuestRefreshNode
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x41AF60", Offset = "0x419960", VA = "0x18041AF60")]
		public SpecGuestRefreshNode(int time, int id)
		{
		}

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x0")]
		[JsonProperty]
		public readonly int RefreshPointTime;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x4")]
		[JsonProperty]
		public readonly int SpecGuestId;
	}
}

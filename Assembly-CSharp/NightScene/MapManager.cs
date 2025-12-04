using System;
using DEYU.Singletons;
using Il2CppDummyDll;
using NightScene.Tiles;

namespace NightScene
{
	// Token: 0x02000563 RID: 1379
	[Token(Token = "0x2000563")]
	public class MapManager : MonoSingleton<IzakayaMap>
	{
		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000402")]
		public new static IzakayaMap Instance
		{
			[Token(Token = "0x6001EB1")]
			[Address(RVA = "0x4E1C30", Offset = "0x4E0630", VA = "0x1804E1C30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EB2")]
		[Address(RVA = "0x4E1BF0", Offset = "0x4E05F0", VA = "0x1804E1BF0")]
		public MapManager()
		{
		}
	}
}

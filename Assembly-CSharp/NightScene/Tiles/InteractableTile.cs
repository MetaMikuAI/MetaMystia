using System;
using Il2CppDummyDll;
using UnityEngine.Tilemaps;

namespace NightScene.Tiles
{
	// Token: 0x0200067D RID: 1661
	[Token(Token = "0x200067D")]
	public class InteractableTile : Tile
	{
		// Token: 0x06002701 RID: 9985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002701")]
		[Address(RVA = "0x531520", Offset = "0x52FF20", VA = "0x180531520")]
		public InteractableTile()
		{
		}

		// Token: 0x04002386 RID: 9094
		[Token(Token = "0x4002386")]
		[FieldOffset(Offset = "0x80")]
		public InteractableTile.TileType type;

		// Token: 0x04002387 RID: 9095
		[Token(Token = "0x4002387")]
		[FieldOffset(Offset = "0x84")]
		public byte index;

		// Token: 0x0200067E RID: 1662
		[Token(Token = "0x200067E")]
		public enum TileType
		{
			// Token: 0x04002389 RID: 9097
			[Token(Token = "0x4002389")]
			CookDesk,
			// Token: 0x0400238A RID: 9098
			[Token(Token = "0x400238A")]
			FoodStorage,
			// Token: 0x0400238B RID: 9099
			[Token(Token = "0x400238B")]
			BeverageStorage,
			// Token: 0x0400238C RID: 9100
			[Token(Token = "0x400238C")]
			Trash,
			// Token: 0x0400238D RID: 9101
			[Token(Token = "0x400238D")]
			GuestTable,
			// Token: 0x0400238E RID: 9102
			[Token(Token = "0x400238E")]
			GuestSeat,
			// Token: 0x0400238F RID: 9103
			[Token(Token = "0x400238F")]
			LEGACY_HeadOfLine,
			// Token: 0x04002390 RID: 9104
			[Token(Token = "0x4002390")]
			LEGACY_TailOfLine,
			// Token: 0x04002391 RID: 9105
			[Token(Token = "0x4002391")]
			GuestSpawnA,
			// Token: 0x04002392 RID: 9106
			[Token(Token = "0x4002392")]
			GuestSpawnB,
			// Token: 0x04002393 RID: 9107
			[Token(Token = "0x4002393")]
			PlayerSpawn,
			// Token: 0x04002394 RID: 9108
			[Token(Token = "0x4002394")]
			PlayerBorder,
			// Token: 0x04002395 RID: 9109
			[Token(Token = "0x4002395")]
			WaitSeat,
			// Token: 0x04002396 RID: 9110
			[Token(Token = "0x4002396")]
			InDoor,
			// Token: 0x04002397 RID: 9111
			[Token(Token = "0x4002397")]
			OutDoor,
			// Token: 0x04002398 RID: 9112
			[Token(Token = "0x4002398")]
			AreaA,
			// Token: 0x04002399 RID: 9113
			[Token(Token = "0x4002399")]
			AreaB,
			// Token: 0x0400239A RID: 9114
			[Token(Token = "0x400239A")]
			DoorA,
			// Token: 0x0400239B RID: 9115
			[Token(Token = "0x400239B")]
			DoorB,
			// Token: 0x0400239C RID: 9116
			[Token(Token = "0x400239C")]
			Line,
			// Token: 0x0400239D RID: 9117
			[Token(Token = "0x400239D")]
			PasserBorder,
			// Token: 0x0400239E RID: 9118
			[Token(Token = "0x400239E")]
			AIdle,
			// Token: 0x0400239F RID: 9119
			[Token(Token = "0x400239F")]
			RabbitIdle,
			// Token: 0x040023A0 RID: 9120
			[Token(Token = "0x40023A0")]
			FoodStorage_BOSS,
			// Token: 0x040023A1 RID: 9121
			[Token(Token = "0x40023A1")]
			BeverageStorage_BOSS,
			// Token: 0x040023A2 RID: 9122
			[Token(Token = "0x40023A2")]
			Trash_BOSS,
			// Token: 0x040023A3 RID: 9123
			[Token(Token = "0x40023A3")]
			FurnitureArea_Ground,
			// Token: 0x040023A4 RID: 9124
			[Token(Token = "0x40023A4")]
			FurnitureArea_Wall,
			// Token: 0x040023A5 RID: 9125
			[Token(Token = "0x40023A5")]
			FurnitureArea_Carpet,
			// Token: 0x040023A6 RID: 9126
			[Token(Token = "0x40023A6")]
			Null
		}
	}
}

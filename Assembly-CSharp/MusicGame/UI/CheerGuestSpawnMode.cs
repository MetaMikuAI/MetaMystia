using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace MusicGame.UI
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[Serializable]
	public struct CheerGuestSpawnMode
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000182 RID: 386 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x17000023")]
		public CheerGuestSpawnMode.CornerType Corner
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
			get
			{
				return CheerGuestSpawnMode.CornerType.RightBottom;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		public AssetReference CheerGuestImage
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private CheerGuestSpawnMode.CornerType corner;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private AssetReference cheerGuestImage;

		// Token: 0x0200004E RID: 78
		[Token(Token = "0x200004E")]
		public enum CornerType
		{
			// Token: 0x0400014F RID: 335
			[Token(Token = "0x400014F")]
			[InspectorName("右下")]
			RightBottom,
			// Token: 0x04000150 RID: 336
			[Token(Token = "0x4000150")]
			[InspectorName("左下（不支持）")]
			LeftBottom,
			// Token: 0x04000151 RID: 337
			[Token(Token = "0x4000151")]
			[InspectorName("左上")]
			LeftTop,
			// Token: 0x04000152 RID: 338
			[Token(Token = "0x4000152")]
			[InspectorName("右上")]
			RightTop
		}
	}
}

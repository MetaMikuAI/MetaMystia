using System;
using System.Runtime.CompilerServices;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core.Collections
{
	// Token: 0x020008E0 RID: 2272
	[Token(Token = "0x20008E0")]
	public static class SellablePropertyHelper
	{
		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06003893 RID: 14483 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003894 RID: 14484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007B3")]
		public static Func<Sellable, Sprite> BGGetter
		{
			[Token(Token = "0x6003893")]
			[Address(RVA = "0x689B60", Offset = "0x688560", VA = "0x180689B60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6003894")]
			[Address(RVA = "0x689BA0", Offset = "0x6885A0", VA = "0x180689BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003895")]
		[Address(RVA = "0x689AA0", Offset = "0x6884A0", VA = "0x180689AA0")]
		private static void AssignForSellableModify(bool hasModify, Image modifySign)
		{
		}

		// Token: 0x06003896 RID: 14486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003896")]
		[Address(RVA = "0x689830", Offset = "0x688230", VA = "0x180689830")]
		public static void AssignForSellableModify(this Sellable sellable, Image modifySign)
		{
		}

		// Token: 0x06003897 RID: 14487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003897")]
		[Address(RVA = "0x6898F0", Offset = "0x6882F0", VA = "0x1806898F0")]
		public static void AssignForSellableModify(this UIElementCluster cluster, Sellable sellable)
		{
		}

		// Token: 0x06003898 RID: 14488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003898")]
		[Address(RVA = "0x6899D0", Offset = "0x6883D0", VA = "0x1806899D0")]
		public static void AssignForSellableModify(this UIElementCluster cluster, bool hasModify)
		{
		}

		// Token: 0x06003899 RID: 14489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003899")]
		[Address(RVA = "0x689AD0", Offset = "0x6884D0", VA = "0x180689AD0")]
		public static Sprite GetSellabeBGSprite(Sellable target)
		{
			return null;
		}
	}
}

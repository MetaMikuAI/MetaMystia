using System;
using System.Collections.Generic;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core
{
	// Token: 0x020008AB RID: 2219
	[Token(Token = "0x20008AB")]
	public static class NonTradableObjectBaseBGSpriteHelper
	{
		// Token: 0x060036AA RID: 13994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AA")]
		[Address(RVA = "0x6659E0", Offset = "0x6643E0", VA = "0x1806659E0")]
		private static void AssignObjectBg(this NonTradableObjectBase nonTradableObjectBase, Image bgPic)
		{
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AB")]
		[Address(RVA = "0x665B00", Offset = "0x664500", VA = "0x180665B00")]
		private static void AssignObjectBg(Sprite sprite, Image bgPic)
		{
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AC")]
		[Address(RVA = "0x665930", Offset = "0x664330", VA = "0x180665930")]
		private static void AssignNull(Image bgPic)
		{
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AD")]
		[Address(RVA = "0x665BA0", Offset = "0x6645A0", VA = "0x180665BA0")]
		public static void AssignObjectBg(this UIElementCluster cluster, NonTradableObjectBase nonTradableObjectBase)
		{
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AE")]
		[Address(RVA = "0x665A20", Offset = "0x664420", VA = "0x180665A20")]
		public static void AssignObjectBg(this UIElementCluster cluster, [CanBeNull] Sprite sprite)
		{
		}

		// Token: 0x060036AF RID: 13999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036AF")]
		[Address(RVA = "0x665950", Offset = "0x664350", VA = "0x180665950")]
		public static void AssignNull(this UIElementCluster cluster)
		{
		}

		// Token: 0x060036B0 RID: 14000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036B0")]
		public static string GetNonTradableObjectNum<T>(this KeyValuePair<T, int> objectCollectionPair)
		{
			return null;
		}
	}
}

using System;
using System.Threading;
using Common.UI;
using GameData.Core.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000443 RID: 1091
	[Token(Token = "0x2000443")]
	[GenerateCleanupMethod]
	public class RecycleItemDescriber : ObjectLanguageBaseDescriber, ITypedDescriber<RecycleItemDescriber.RecycleItem>, IDescriber
	{
		// Token: 0x0600188C RID: 6284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188C")]
		[Address(RVA = "0x479140", Offset = "0x477B40", VA = "0x180479140", Slot = "11")]
		public void Describe(RecycleItemDescriber.RecycleItem data, CancellationToken cancellationToken)
		{
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188D")]
		[Address(RVA = "0x4791D0", Offset = "0x477BD0", VA = "0x1804791D0", Slot = "8")]
		protected override void OnDescriberDestroyed()
		{
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188E")]
		[Address(RVA = "0x479110", Offset = "0x477B10", VA = "0x180479110", Slot = "9")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600188F")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public RecycleItemDescriber()
		{
		}

		// Token: 0x040016BA RID: 5818
		[Token(Token = "0x40016BA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		public TextMeshProUGUI m_recyclePriceText;

		// Token: 0x040016BB RID: 5819
		[Token(Token = "0x40016BB")]
		public const int WASHI_ID = 1;

		// Token: 0x040016BC RID: 5820
		[Token(Token = "0x40016BC")]
		public const int CANDY_ID = 5011;

		// Token: 0x02000444 RID: 1092
		[Token(Token = "0x2000444")]
		public class RecycleItem : Item
		{
			// Token: 0x06001890 RID: 6288 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001890")]
			[Address(RVA = "0x479200", Offset = "0x477C00", VA = "0x180479200")]
			public RecycleItem(int id, int price)
			{
			}

			// Token: 0x040016BD RID: 5821
			[Token(Token = "0x40016BD")]
			[FieldOffset(Offset = "0x18")]
			public int Price;
		}
	}
}

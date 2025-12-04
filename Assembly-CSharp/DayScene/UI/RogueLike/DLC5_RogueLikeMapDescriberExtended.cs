using System;
using System.Collections.Generic;
using System.Threading;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020003BA RID: 954
	[Token(Token = "0x20003BA")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeMapDescriberExtended : DLC5_RogueLikeMapDescriber
	{
		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x000080B8 File Offset: 0x000062B8
		[Token(Token = "0x1700027A")]
		protected override int Max
		{
			[Token(Token = "0x6001511")]
			[Address(RVA = "0x446620", Offset = "0x445020", VA = "0x180446620", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001512")]
		[Address(RVA = "0x4451E0", Offset = "0x443BE0", VA = "0x1804451E0", Slot = "7")]
		public override void Describe(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext data, CancellationToken cancellationToken)
		{
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001513")]
		[Address(RVA = "0x4462A0", Offset = "0x444CA0", VA = "0x1804462A0")]
		private static void ProcessObject(UIElementCluster uiElementCluster, Sprite sprite)
		{
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001514")]
		[Address(RVA = "0x444E60", Offset = "0x443860", VA = "0x180444E60", Slot = "8")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001515")]
		[Address(RVA = "0x446370", Offset = "0x444D70", VA = "0x180446370")]
		public DLC5_RogueLikeMapDescriberExtended()
		{
		}

		// Token: 0x040013BD RID: 5053
		[Token(Token = "0x40013BD")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TextMeshProUGUI m_IzakayaDescription;

		// Token: 0x040013BE RID: 5054
		[Token(Token = "0x40013BE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject m_SpecCharacterPrefab;

		// Token: 0x040013BF RID: 5055
		[Token(Token = "0x40013BF")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject m_ItemPrefab;

		// Token: 0x040013C0 RID: 5056
		[Token(Token = "0x40013C0")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RectTransform m_InviteGuestField;

		// Token: 0x040013C1 RID: 5057
		[Token(Token = "0x40013C1")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private RectTransform m_ResourceField;

		// Token: 0x040013C2 RID: 5058
		[Token(Token = "0x40013C2")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject m_CookerViewer;

		// Token: 0x040013C3 RID: 5059
		[Token(Token = "0x40013C3")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private RectTransform m_CookerField;

		// Token: 0x040013C4 RID: 5060
		[Token(Token = "0x40013C4")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIElementCluster m_Partner;

		// Token: 0x040013C5 RID: 5061
		[Token(Token = "0x40013C5")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private UIElementCluster m_Decoration;

		// Token: 0x040013C6 RID: 5062
		[Token(Token = "0x40013C6")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private RectTransform m_ClothesField;

		// Token: 0x040013C7 RID: 5063
		[Token(Token = "0x40013C7")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private TextMeshProUGUI m_NeighbourText;

		// Token: 0x040013C8 RID: 5064
		[Token(Token = "0x40013C8")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TextMeshProUGUI m_DLCLabelText;

		// Token: 0x040013C9 RID: 5065
		[Token(Token = "0x40013C9")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private TextMeshProUGUI m_CollectRateText;

		// Token: 0x040013CA RID: 5066
		[Token(Token = "0x40013CA")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private TextMeshProUGUI m_CollectRecipeText;

		// Token: 0x040013CB RID: 5067
		[Token(Token = "0x40013CB")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private TextMeshProUGUI m_CollectItemText;

		// Token: 0x040013CC RID: 5068
		[Token(Token = "0x40013CC")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private TextMeshProUGUI m_CollectPartnerText;

		// Token: 0x040013CD RID: 5069
		[Token(Token = "0x40013CD")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private TextMeshProUGUI m_CollectIzakayaText;

		// Token: 0x040013CE RID: 5070
		[Token(Token = "0x40013CE")]
		[FieldOffset(Offset = "0x120")]
		private readonly List<GameObject> allInviteCharacterInstancePool;

		// Token: 0x040013CF RID: 5071
		[Token(Token = "0x40013CF")]
		[FieldOffset(Offset = "0x128")]
		private readonly List<GameObject> allResourceInstancePool;

		// Token: 0x040013D0 RID: 5072
		[Token(Token = "0x40013D0")]
		[FieldOffset(Offset = "0x130")]
		private readonly List<GameObject> allRecipeInstancePool;

		// Token: 0x040013D1 RID: 5073
		[Token(Token = "0x40013D1")]
		[FieldOffset(Offset = "0x138")]
		private readonly List<GameObject> allCookerInstancePool;

		// Token: 0x040013D2 RID: 5074
		[Token(Token = "0x40013D2")]
		[FieldOffset(Offset = "0x140")]
		private readonly List<GameObject> allClothesInstancePool;
	}
}

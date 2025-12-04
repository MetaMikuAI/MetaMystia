using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000E52 RID: 3666
	[Token(Token = "0x2000E52")]
	[GenerateCleanupMethod]
	public class MultipleChoicePannel : UIPanel
	{
		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x060055BC RID: 21948 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060055BD RID: 21949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C04")]
		public List<object> FinalSelectedID
		{
			[Token(Token = "0x60055BC")]
			[Address(RVA = "0x4405A0", Offset = "0x43EFA0", VA = "0x1804405A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60055BD")]
			[Address(RVA = "0x4D25F0", Offset = "0x4D0FF0", VA = "0x1804D25F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x060055BE RID: 21950 RVA: 0x0001E798 File Offset: 0x0001C998
		// (set) Token: 0x060055BF RID: 21951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C05")]
		public bool IsConfirm
		{
			[Token(Token = "0x60055BE")]
			[Address(RVA = "0x853D70", Offset = "0x852770", VA = "0x180853D70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60055BF")]
			[Address(RVA = "0x853E20", Offset = "0x852820", VA = "0x180853E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060055C0 RID: 21952 RVA: 0x0001E7B0 File Offset: 0x0001C9B0
		// (set) Token: 0x060055C1 RID: 21953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C06")]
		public MultipleChoicePannel.MultipleChoicePannelOpenContext OpenContext
		{
			[Token(Token = "0x60055C0")]
			[Address(RVA = "0x853DD0", Offset = "0x8527D0", VA = "0x180853DD0")]
			[CompilerGenerated]
			private get
			{
				return default(MultipleChoicePannel.MultipleChoicePannelOpenContext);
			}
			[Token(Token = "0x60055C1")]
			[Address(RVA = "0x853E90", Offset = "0x852890", VA = "0x180853E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x060055C2 RID: 21954 RVA: 0x0001E7C8 File Offset: 0x0001C9C8
		// (set) Token: 0x060055C3 RID: 21955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C07")]
		public MultipleChoicePannel.MultipleChoicePannelOpenContext OpenContextString
		{
			[Token(Token = "0x60055C2")]
			[Address(RVA = "0x853D80", Offset = "0x852780", VA = "0x180853D80")]
			[CompilerGenerated]
			private get
			{
				return default(MultipleChoicePannel.MultipleChoicePannelOpenContext);
			}
			[Token(Token = "0x60055C3")]
			[Address(RVA = "0x853E30", Offset = "0x852830", VA = "0x180853E30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C4")]
		[Address(RVA = "0x43ED60", Offset = "0x43D760", VA = "0x18043ED60", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x060055C5 RID: 21957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C5")]
		[Address(RVA = "0x852EC0", Offset = "0x8518C0", VA = "0x180852EC0", Slot = "22")]
		protected sealed override void OnPanelInitialize()
		{
		}

		// Token: 0x060055C6 RID: 21958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C6")]
		[Address(RVA = "0x852DE0", Offset = "0x8517E0", VA = "0x180852DE0")]
		private void OnConfirm()
		{
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C7")]
		[Address(RVA = "0x852E20", Offset = "0x851820", VA = "0x180852E20")]
		private void OnDeny()
		{
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C8")]
		[Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0", Slot = "21")]
		protected sealed override void OnPanelOpen()
		{
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055C9")]
		[Address(RVA = "0x853AF0", Offset = "0x8524F0", VA = "0x180853AF0")]
		private void UpdateSubmitBtn(bool requestedAvailibility)
		{
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055CA")]
		[Address(RVA = "0x852E30", Offset = "0x851830", VA = "0x180852E30", Slot = "23")]
		protected sealed override void OnPanelClose()
		{
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055CB")]
		[Address(RVA = "0x852C70", Offset = "0x851670", VA = "0x180852C70", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060055CC RID: 21964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055CC")]
		[Address(RVA = "0x853C50", Offset = "0x852650", VA = "0x180853C50")]
		public MultipleChoicePannel()
		{
		}

		// Token: 0x0400507C RID: 20604
		[Token(Token = "0x400507C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject Parent;

		// Token: 0x0400507D RID: 20605
		[Token(Token = "0x400507D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GridLayoutGroup Field;

		// Token: 0x0400507E RID: 20606
		[Token(Token = "0x400507E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AdpProgressIndicatorComponent Scroller;

		// Token: 0x0400507F RID: 20607
		[Token(Token = "0x400507F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI PannelTitle;

		// Token: 0x04005080 RID: 20608
		[Token(Token = "0x4005080")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI SubmitBtnTitle;

		// Token: 0x04005081 RID: 20609
		[Token(Token = "0x4005081")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI DenyBtnTitle;

		// Token: 0x04005082 RID: 20610
		[Token(Token = "0x4005082")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UIButtonSimple ConfirmBtn;

		// Token: 0x04005083 RID: 20611
		[Token(Token = "0x4005083")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UIButtonSimple DenyBtn;

		// Token: 0x04005084 RID: 20612
		[Token(Token = "0x4005084")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[TupleElementNames(new string[] { "Title", "AltTitle" })]
		private readonly Dictionary<object, ValueTuple<string, string>> m_AllExtraSelections;

		// Token: 0x04005085 RID: 20613
		[Token(Token = "0x4005085")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<object> m_AllValue;

		// Token: 0x04005086 RID: 20614
		[Token(Token = "0x4005086")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly List<object> SelectedID;

		// Token: 0x04005087 RID: 20615
		[Token(Token = "0x4005087")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private StaticVerticalGridScrollListUILogicalGroupT<object, UIElementCluster, UIButtonToggle> m_GridControl;

		// Token: 0x04005088 RID: 20616
		[Token(Token = "0x4005088")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[TupleElementNames(new string[] { "ID", "Title", "AltTitle" })]
		private ValueTuple<object, string, string> m_SelectAllSelection;

		// Token: 0x02000E53 RID: 3667
		[Token(Token = "0x2000E53")]
		public struct MultipleChoicePannelOpenContext
		{
			// Token: 0x060055D0 RID: 21968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60055D0")]
			[Address(RVA = "0x8526B0", Offset = "0x8510B0", VA = "0x1808526B0")]
			public MultipleChoicePannelOpenContext(object[] allData, [TupleElementNames(new string[] { "ID", "Title", "AltTitle" })] IEnumerable<ValueTuple<object, string, string>> extraSelections, [TupleElementNames(new string[] { "ID", "Title", "AltTitle" })] ValueTuple<object, string, string> selectAllSelection, Func<object, string> idToSelectionTextCallback, string pannelTitle, string submitBtnTitle, string debyBtnTitle, [TupleElementNames(new string[] { "currentSelected", "targetAvailability" })] [Optional] Func<ValueTuple<IEnumerable<object>, bool>, bool> getSubmitButtonAvailabilityCallback)
			{
			}

			// Token: 0x060055D1 RID: 21969 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60055D1")]
			[Address(RVA = "0x852990", Offset = "0x851390", VA = "0x180852990")]
			public MultipleChoicePannelOpenContext(object[] allData, [TupleElementNames(new string[] { "ID", "Title", "AltTitle" })] IEnumerable<ValueTuple<object, string, string>> extraSelections, [TupleElementNames(new string[] { "ID", "Title", "AltTitle" })] ValueTuple<object, string, string> selectAllSelection, Func<object, string> idToSelectionTextCallback, string pannelTitle, Func<IEnumerable<object>, string> getSubmitBtnTitleCallback, string denyBtnTitle, [TupleElementNames(new string[] { "currentSelected", "targetAvailability" })] [Optional] Func<ValueTuple<IEnumerable<object>, bool>, bool> getSubmitButtonAvailabilityCallback)
			{
			}

			// Token: 0x0400508D RID: 20621
			[Token(Token = "0x400508D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly object[] AllData;

			// Token: 0x0400508E RID: 20622
			[Token(Token = "0x400508E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[TupleElementNames(new string[] { "ID", "Title", "AltTitle" })]
			public readonly IEnumerable<ValueTuple<object, string, string>> ExtraSelections;

			// Token: 0x0400508F RID: 20623
			[Token(Token = "0x400508F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[TupleElementNames(new string[] { "ID", "Title", "AltTitle" })]
			public readonly ValueTuple<object, string, string> SelectAllSelection;

			// Token: 0x04005090 RID: 20624
			[Token(Token = "0x4005090")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public readonly Func<object, string> IdToSelectionTextCallback;

			// Token: 0x04005091 RID: 20625
			[Token(Token = "0x4005091")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public readonly string PannelTitle;

			// Token: 0x04005092 RID: 20626
			[Token(Token = "0x4005092")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[TupleElementNames(new string[] { "currentSelected", "targetAvailability" })]
			public readonly Func<ValueTuple<IEnumerable<object>, bool>, bool> GetSubmitButtonAvailabilityCallback;

			// Token: 0x04005093 RID: 20627
			[Token(Token = "0x4005093")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public readonly string SubmitBtnTitle;

			// Token: 0x04005094 RID: 20628
			[Token(Token = "0x4005094")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public readonly string DenyBtnTitle;

			// Token: 0x04005095 RID: 20629
			[Token(Token = "0x4005095")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public readonly Func<IEnumerable<object>, string> GetSubmitBtnTextCallback;
		}
	}
}

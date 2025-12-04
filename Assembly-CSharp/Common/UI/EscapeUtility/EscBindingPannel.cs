using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.EscapeUtility
{
	// Token: 0x02000F3A RID: 3898
	[Token(Token = "0x2000F3A")]
	[GenerateCleanupMethod]
	public class EscBindingPannel : UISubPanel<EscMainPannel>
	{
		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x06005B89 RID: 23433 RVA: 0x0001FF68 File Offset: 0x0001E168
		[Token(Token = "0x17000CEB")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6005B89")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005B8A RID: 23434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8A")]
		[Address(RVA = "0x880F50", Offset = "0x87F950", VA = "0x180880F50", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005B8B RID: 23435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005B8B")]
		[Address(RVA = "0x6028B0", Offset = "0x6012B0", VA = "0x1806028B0")]
		private static string GetCommonPhraseCallback(string x)
		{
			return null;
		}

		// Token: 0x06005B8C RID: 23436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8C")]
		[Address(RVA = "0x880B00", Offset = "0x87F500", VA = "0x180880B00")]
		public static void DrawBindingElements(GameObject bindingSettingParent, RectTransform bindingField, EscBindingPannel.InputBindingData[] inputBindingDatas, List<GameObject> allGameObjectInstances, [TupleElementNames(new string[] { "Interactable", "UIElements", "GetCurrentKBDBindingCallback" })] Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> instances, EscBindingPannel.StringArray[] groups, Action<RectTransform> onScrollCallback, UILogicalGroupT<string> allChildrenInstancesLogicalGroup)
		{
		}

		// Token: 0x06005B8D RID: 23437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8D")]
		[Address(RVA = "0x881850", Offset = "0x880250", VA = "0x180881850", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005B8E RID: 23438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B8E")]
		[Address(RVA = "0x880EF0", Offset = "0x87F8F0", VA = "0x180880EF0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005B8F RID: 23439 RVA: 0x0001FF80 File Offset: 0x0001E180
		[Token(Token = "0x6005B8F")]
		[Address(RVA = "0x880E90", Offset = "0x87F890", VA = "0x180880E90", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B90")]
		[Address(RVA = "0x8809A0", Offset = "0x87F3A0", VA = "0x1808809A0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005B91 RID: 23441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005B91")]
		[Address(RVA = "0x8819F0", Offset = "0x8803F0", VA = "0x1808819F0")]
		public EscBindingPannel()
		{
		}

		// Token: 0x040054E7 RID: 21735
		[Token(Token = "0x40054E7")]
		[FieldOffset(Offset = "0x78")]
		public EscBindingPannel.InputBindingData[] inputBindingDatas;

		// Token: 0x040054E8 RID: 21736
		[Token(Token = "0x40054E8")]
		[FieldOffset(Offset = "0x80")]
		public EscBindingPannel.StringArray[] groups;

		// Token: 0x040054E9 RID: 21737
		[Token(Token = "0x40054E9")]
		[FieldOffset(Offset = "0x88")]
		public GameObject bindingSettingParent;

		// Token: 0x040054EA RID: 21738
		[Token(Token = "0x40054EA")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform bindingField;

		// Token: 0x040054EB RID: 21739
		[Token(Token = "0x40054EB")]
		[FieldOffset(Offset = "0x98")]
		public AdpScrollListAdaptiveComponent Scroller;

		// Token: 0x040054EC RID: 21740
		[Token(Token = "0x40054EC")]
		[FieldOffset(Offset = "0xA0")]
		public UIButtonSimple PlayStationStyledInput;

		// Token: 0x040054ED RID: 21741
		[Token(Token = "0x40054ED")]
		[FieldOffset(Offset = "0xA8")]
		public UIButtonSimple XBoxStyeldInput;

		// Token: 0x040054EE RID: 21742
		[Token(Token = "0x40054EE")]
		[FieldOffset(Offset = "0xB0")]
		public UIButtonHold ResetBindingBtn;

		// Token: 0x040054EF RID: 21743
		[Token(Token = "0x40054EF")]
		[FieldOffset(Offset = "0xB8")]
		public Image PlayStationIndicator;

		// Token: 0x040054F0 RID: 21744
		[Token(Token = "0x40054F0")]
		[FieldOffset(Offset = "0xC0")]
		public Image XboxIndicator;

		// Token: 0x040054F1 RID: 21745
		[Token(Token = "0x40054F1")]
		[FieldOffset(Offset = "0xC8")]
		private readonly List<GameObject> AllGameObjectInstances;

		// Token: 0x040054F2 RID: 21746
		[Token(Token = "0x40054F2")]
		[FieldOffset(Offset = "0xD0")]
		[TupleElementNames(new string[] { "Interactable", "UIElements", "GetCurrentKBDBindingCallback" })]
		private readonly Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> instances;

		// Token: 0x040054F3 RID: 21747
		[Token(Token = "0x40054F3")]
		[FieldOffset(Offset = "0xD8")]
		private readonly UILogicalGroupT<string> m_AllChildrenInstances;

		// Token: 0x02000F3B RID: 3899
		[Token(Token = "0x2000F3B")]
		[Serializable]
		public struct InputBindingData
		{
			// Token: 0x040054F4 RID: 21748
			[Token(Token = "0x40054F4")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public EscBindingPannel.InputBindingData.InputActionReferencePair[] focusingInputAction;

			// Token: 0x040054F5 RID: 21749
			[Token(Token = "0x40054F5")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public string titleKey;

			// Token: 0x02000F3C RID: 3900
			[Token(Token = "0x2000F3C")]
			[Serializable]
			public class InputActionReferencePair
			{
				// Token: 0x06005B92 RID: 23442 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6005B92")]
				[Address(RVA = "0x88B5B0", Offset = "0x889FB0", VA = "0x18088B5B0")]
				public InputActionReferencePair()
				{
				}

				// Token: 0x040054F6 RID: 21750
				[Token(Token = "0x40054F6")]
				[FieldOffset(Offset = "0x10")]
				[SerializeField]
				public InputActionReference focusingInputAction;

				// Token: 0x040054F7 RID: 21751
				[Token(Token = "0x40054F7")]
				[FieldOffset(Offset = "0x18")]
				[SerializeField]
				public int overrideBindingIndex;
			}
		}

		// Token: 0x02000F3D RID: 3901
		[Token(Token = "0x2000F3D")]
		[Serializable]
		public class StringArray : IEnumerable<string>, IEnumerable
		{
			// Token: 0x06005B93 RID: 23443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B93")]
			[Address(RVA = "0x896280", Offset = "0x894C80", VA = "0x180896280", Slot = "4")]
			public IEnumerator<string> GetEnumerator()
			{
				return null;
			}

			// Token: 0x06005B94 RID: 23444 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005B94")]
			[Address(RVA = "0x8962D0", Offset = "0x894CD0", VA = "0x1808962D0", Slot = "5")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			// Token: 0x06005B95 RID: 23445 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005B95")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public StringArray()
			{
			}

			// Token: 0x040054F8 RID: 21752
			[Token(Token = "0x40054F8")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string[] array;
		}
	}
}

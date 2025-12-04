using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI.EscapeUtility;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000E5D RID: 3677
	[Token(Token = "0x2000E5D")]
	[GenerateCleanupMethod]
	public class EscBindingSubPannel : UIPanel
	{
		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x060055F1 RID: 22001 RVA: 0x0001E858 File Offset: 0x0001CA58
		// (set) Token: 0x060055F2 RID: 22002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C0A")]
		public EscBindingPannel.InputBindingData ActionGroupToRebind
		{
			[Token(Token = "0x60055F1")]
			[Address(RVA = "0x48A650", Offset = "0x489050", VA = "0x18048A650")]
			[CompilerGenerated]
			private get
			{
				return default(EscBindingPannel.InputBindingData);
			}
			[Token(Token = "0x60055F2")]
			[Address(RVA = "0x84FA50", Offset = "0x84E450", VA = "0x18084FA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060055F3 RID: 22003 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060055F4 RID: 22004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C0B")]
		public EscBindingPannel.StringArray[] Groups
		{
			[Token(Token = "0x60055F3")]
			[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60055F4")]
			[Address(RVA = "0x45F1B0", Offset = "0x45DBB0", VA = "0x18045F1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x060055F5 RID: 22005 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060055F6 RID: 22006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C0C")]
		[TupleElementNames(new string[] { "Interactable", "UIElements", "GetCurrentKBDBindingCallback" })]
		public Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> Instances
		{
			[Token(Token = "0x60055F5")]
			[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60055F6")]
			[Address(RVA = "0x45ABC0", Offset = "0x4595C0", VA = "0x18045ABC0")]
			[CompilerGenerated]
			[param: TupleElementNames(new string[] { "Interactable", "UIElements", "GetCurrentKBDBindingCallback" })]
			set
			{
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x060055F7 RID: 22007 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060055F8 RID: 22008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C0D")]
		public EscBindingPannel.InputBindingData[] InputBindingDatas
		{
			[Token(Token = "0x60055F7")]
			[Address(RVA = "0x440500", Offset = "0x43EF00", VA = "0x180440500")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60055F8")]
			[Address(RVA = "0x48AAA0", Offset = "0x4894A0", VA = "0x18048AAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060055F9 RID: 22009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055F9")]
		[Address(RVA = "0x84EEF0", Offset = "0x84D8F0", VA = "0x18084EEF0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060055FA RID: 22010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FA")]
		[Address(RVA = "0x84EE80", Offset = "0x84D880", VA = "0x18084EE80", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060055FB RID: 22011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055FB")]
		[Address(RVA = "0x408E80", Offset = "0x407880", VA = "0x180408E80")]
		public EscBindingSubPannel()
		{
		}

		// Token: 0x040050BC RID: 20668
		[Token(Token = "0x40050BC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TextMeshProUGUI bindingIndicatorTitle;
	}
}

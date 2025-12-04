using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI.GenericButtonSet
{
	// Token: 0x02000EDF RID: 3807
	[Token(Token = "0x2000EDF")]
	[GenerateCleanupMethod]
	public class GenericButtonSetPanel : UIPanelParamExternOpen<GenericButtonSetParam>
	{
		// Token: 0x060059F4 RID: 23028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F4")]
		[Address(RVA = "0x88ABC0", Offset = "0x8895C0", VA = "0x18088ABC0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060059F5 RID: 23029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F5")]
		[Address(RVA = "0x88AC10", Offset = "0x889610", VA = "0x18088AC10", Slot = "32")]
		protected override void OnPanelOpen(GenericButtonSetParam openParam)
		{
		}

		// Token: 0x060059F6 RID: 23030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F6")]
		[Address(RVA = "0x88AB30", Offset = "0x889530", VA = "0x18088AB30", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060059F7 RID: 23031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059F7")]
		[Address(RVA = "0x88AE60", Offset = "0x889860", VA = "0x18088AE60")]
		public GenericButtonSetPanel()
		{
		}

		// Token: 0x04005465 RID: 21605
		[Token(Token = "0x4005465")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIElementCluster m_Selection;

		// Token: 0x04005466 RID: 21606
		[Token(Token = "0x4005466")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform m_Field;

		// Token: 0x04005467 RID: 21607
		[Token(Token = "0x4005467")]
		[FieldOffset(Offset = "0x90")]
		private readonly List<GameObject> m_Instances;
	}
}

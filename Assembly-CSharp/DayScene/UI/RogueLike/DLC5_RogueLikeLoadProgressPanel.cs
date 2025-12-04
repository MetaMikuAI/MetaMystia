using System;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020003AB RID: 939
	[Token(Token = "0x20003AB")]
	public class DLC5_RogueLikeLoadProgressPanel : UIPanelExtern
	{
		// Token: 0x060014CF RID: 5327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014CF")]
		[Address(RVA = "0x442DE0", Offset = "0x4417E0", VA = "0x180442DE0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D0")]
		[Address(RVA = "0x442E00", Offset = "0x441800", VA = "0x180442E00", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D1")]
		[Address(RVA = "0x410B60", Offset = "0x40F560", VA = "0x180410B60")]
		public DLC5_RogueLikeLoadProgressPanel()
		{
		}

		// Token: 0x0400136A RID: 4970
		[Token(Token = "0x400136A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Animator m_Animator;

		// Token: 0x0400136B RID: 4971
		[Token(Token = "0x400136B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int Variant;
	}
}

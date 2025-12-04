using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using Night.BossBattle.DLC4_BossBattle;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020006DD RID: 1757
	[Token(Token = "0x20006DD")]
	[GenerateCleanupMethod]
	public class IncomeControllerFlandre_CardRechargeIndicator : MonoBehaviour
	{
		// Token: 0x0600299D RID: 10653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600299D")]
		[Address(RVA = "0x547760", Offset = "0x546160", VA = "0x180547760")]
		private void Awake()
		{
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600299E")]
		[Address(RVA = "0x547AC0", Offset = "0x5464C0", VA = "0x180547AC0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600299F")]
		[Address(RVA = "0x547AB0", Offset = "0x5464B0", VA = "0x180547AB0")]
		public void Initialize(DLC4_BossBattleManager manager)
		{
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A0")]
		[Address(RVA = "0x547C40", Offset = "0x546640", VA = "0x180547C40")]
		public void UpdateVisual(IReadOnlyList<RechargeInfo> rechargeInfo)
		{
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A1")]
		[Address(RVA = "0x5479B0", Offset = "0x5463B0", VA = "0x1805479B0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029A2")]
		[Address(RVA = "0x5483E0", Offset = "0x546DE0", VA = "0x1805483E0")]
		public IncomeControllerFlandre_CardRechargeIndicator()
		{
		}

		// Token: 0x040025FC RID: 9724
		[Token(Token = "0x40025FC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform m_SpecialCardField;

		// Token: 0x040025FD RID: 9725
		[Token(Token = "0x40025FD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform m_NormalCardField;

		// Token: 0x040025FE RID: 9726
		[Token(Token = "0x40025FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform m_BufferField;

		// Token: 0x040025FF RID: 9727
		[Token(Token = "0x40025FF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIElementCluster m_CardRechargeElement;

		// Token: 0x04002600 RID: 9728
		[Token(Token = "0x4002600")]
		[FieldOffset(Offset = "0x38")]
		[TupleElementNames(new string[] { "UI", "Progress" })]
		private readonly Dictionary<int, ValueTuple<UIElementCluster, Image>> m_RegisteredElement;

		// Token: 0x04002601 RID: 9729
		[Token(Token = "0x4002601")]
		[FieldOffset(Offset = "0x40")]
		private readonly Stack<int> m_RemoveBuffer;

		// Token: 0x04002602 RID: 9730
		[Token(Token = "0x4002602")]
		[FieldOffset(Offset = "0x48")]
		private readonly HashSet<int> m_UpdatedSet;

		// Token: 0x04002603 RID: 9731
		[Token(Token = "0x4002603")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform m_CurrentInstantiateField;

		// Token: 0x04002604 RID: 9732
		[Token(Token = "0x4002604")]
		[FieldOffset(Offset = "0x58")]
		private DLC4_BossBattleManager m_Manager;

		// Token: 0x04002605 RID: 9733
		[Token(Token = "0x4002605")]
		[FieldOffset(Offset = "0x60")]
		private ObjectPool<UIElementCluster> m_ObjectPool;
	}
}

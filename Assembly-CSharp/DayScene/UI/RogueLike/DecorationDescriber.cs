using System;
using System.Threading;
using Common.UI;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200036F RID: 879
	[Token(Token = "0x200036F")]
	[GenerateCleanupMethod]
	public class DecorationDescriber : MonoBehaviour, ITypedDescriber<Decoration>, IDescriber
	{
		// Token: 0x06001380 RID: 4992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001380")]
		[Address(RVA = "0x44F0C0", Offset = "0x44DAC0", VA = "0x18044F0C0")]
		public void Describe(Decoration decoration)
		{
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001381")]
		[Address(RVA = "0x44F0C0", Offset = "0x44DAC0", VA = "0x18044F0C0", Slot = "4")]
		public void Describe(Decoration data, CancellationToken cancellationToken)
		{
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001382")]
		[Address(RVA = "0x44EF20", Offset = "0x44D920", VA = "0x18044EF20", Slot = "5")]
		public void DescribeNull()
		{
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001383")]
		[Address(RVA = "0x44EC20", Offset = "0x44D620", VA = "0x18044EC20")]
		public static void DescribeDecorations(UIElementCluster uiElementCluster, Decoration decoration)
		{
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001384")]
		[Address(RVA = "0x44ED80", Offset = "0x44D780", VA = "0x18044ED80")]
		public static void DescribeNull(UIElementCluster uiElementCluster)
		{
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001385")]
		[Address(RVA = "0x43B080", Offset = "0x439A80", VA = "0x18043B080")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001386")]
		[Address(RVA = "0x3EA340", Offset = "0x3E8D40", VA = "0x1803EA340", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001387")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public DecorationDescriber()
		{
		}

		// Token: 0x040011C3 RID: 4547
		[Token(Token = "0x40011C3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIElementCluster m_ItemDescriberCluster;
	}
}

using System;
using System.Threading;
using Common.UI;
using GameData.Core.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200036E RID: 878
	[Token(Token = "0x200036E")]
	[GenerateCleanupMethod]
	public class ClothesDescriber : MonoBehaviour, ITypedDescriber<Item>, IDescriber
	{
		// Token: 0x0600137B RID: 4987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600137B")]
		[Address(RVA = "0x43AF40", Offset = "0x439940", VA = "0x18043AF40", Slot = "4")]
		public void Describe(Item data, CancellationToken cancellationToken)
		{
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600137C")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "5")]
		public void DescribeNull()
		{
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600137D")]
		[Address(RVA = "0x43B080", Offset = "0x439A80", VA = "0x18043B080")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600137E")]
		[Address(RVA = "0x3EE530", Offset = "0x3ECF30", VA = "0x1803EE530", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600137F")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public ClothesDescriber()
		{
		}

		// Token: 0x040011C1 RID: 4545
		[Token(Token = "0x40011C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image m_Portrayal;

		// Token: 0x040011C2 RID: 4546
		[Token(Token = "0x40011C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI m_Text;
	}
}

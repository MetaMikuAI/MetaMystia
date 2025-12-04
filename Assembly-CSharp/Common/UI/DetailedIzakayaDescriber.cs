using System;
using System.Threading;
using GameData.Core.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000E34 RID: 3636
	[Token(Token = "0x2000E34")]
	[GenerateCleanupMethod]
	public class DetailedIzakayaDescriber : SelectedIzakayaDescriber
	{
		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x060054FC RID: 21756 RVA: 0x0001E558 File Offset: 0x0001C758
		[Token(Token = "0x17000BF9")]
		protected override int Max
		{
			[Token(Token = "0x60054FC")]
			[Address(RVA = "0x446620", Offset = "0x445020", VA = "0x180446620", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FD")]
		[Address(RVA = "0x838620", Offset = "0x837020", VA = "0x180838620", Slot = "7")]
		public override void Describe(Izakaya data, CancellationToken cancellationToken)
		{
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FE")]
		[Address(RVA = "0x8385F0", Offset = "0x836FF0", VA = "0x1808385F0", Slot = "8")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FF")]
		[Address(RVA = "0x8386B0", Offset = "0x8370B0", VA = "0x1808386B0")]
		public DetailedIzakayaDescriber()
		{
		}

		// Token: 0x04004FE1 RID: 20449
		[Token(Token = "0x4004FE1")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TextMeshProUGUI m_IzakayaDescription;
	}
}

using System;
using System.Threading;
using Common.UI;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200043D RID: 1085
	[Token(Token = "0x200043D")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLike_PartnerDescriber : MonoBehaviour, ITypedDescriber<SpecialGuest>, IDescriber
	{
		// Token: 0x060017EE RID: 6126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017EE")]
		[Address(RVA = "0x4766B0", Offset = "0x4750B0", VA = "0x1804766B0", Slot = "4")]
		public void Describe(SpecialGuest detail, CancellationToken cancellationToken)
		{
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017EF")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "5")]
		public void DescribeNull()
		{
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F0")]
		[Address(RVA = "0x43B080", Offset = "0x439A80", VA = "0x18043B080")]
		private void OnDestroy()
		{
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F1")]
		[Address(RVA = "0x3E85F0", Offset = "0x3E6FF0", VA = "0x1803E85F0", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017F2")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public DLC5_RogueLike_PartnerDescriber()
		{
		}

		// Token: 0x04001684 RID: 5764
		[Token(Token = "0x4001684")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image m_Portrayal;

		// Token: 0x04001685 RID: 5765
		[Token(Token = "0x4001685")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI m_GuestName;

		// Token: 0x04001686 RID: 5766
		[Token(Token = "0x4001686")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI m_PartnerProperties;
	}
}

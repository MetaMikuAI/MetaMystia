using System;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI
{
	// Token: 0x020002FB RID: 763
	[Token(Token = "0x20002FB")]
	[RequireComponent(typeof(CanvasGroup))]
	[GenerateCleanupMethod]
	public class FastTravelPanel_TimeIndicator : MonoBehaviour, ITimeIndicator
	{
		// Token: 0x0600113D RID: 4413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x9433A0", Offset = "0x941DA0", VA = "0x1809433A0")]
		private void Awake()
		{
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x943420", Offset = "0x941E20", VA = "0x180943420", Slot = "4")]
		public void SetValue(TimeIndicatorContext? context)
		{
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600113F")]
		[Address(RVA = "0x4043B0", Offset = "0x402DB0", VA = "0x1804043B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001140")]
		[Address(RVA = "0x943300", Offset = "0x941D00", VA = "0x180943300")]
		public void ApplyOffset(Vector2? offset)
		{
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001141")]
		[Address(RVA = "0x531530", Offset = "0x52FF30", VA = "0x180531530", Slot = "5")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001142")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public FastTravelPanel_TimeIndicator()
		{
		}

		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI m_CurrentTime;

		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI m_TargetTime;

		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI m_CostTime;

		// Token: 0x0400100B RID: 4107
		[Token(Token = "0x400100B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI m_CostMoney;

		// Token: 0x0400100C RID: 4108
		[Token(Token = "0x400100C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject m_CostMoneyPanel;

		// Token: 0x0400100D RID: 4109
		[Token(Token = "0x400100D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform m_FloatMenuRig;

		// Token: 0x0400100E RID: 4110
		[Token(Token = "0x400100E")]
		[FieldOffset(Offset = "0x48")]
		private CanvasGroup m_CanvasGroup;

		// Token: 0x0400100F RID: 4111
		[Token(Token = "0x400100F")]
		[FieldOffset(Offset = "0x50")]
		private Vector2 m_StartOffset;
	}
}

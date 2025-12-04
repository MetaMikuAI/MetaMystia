using System;
using System.Collections.Generic;
using DEYU.UniversalUISystem;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020006ED RID: 1773
	[Token(Token = "0x20006ED")]
	[GenerateCleanupMethod]
	public class PartnerStateModuleUI : MonoBehaviour
	{
		// Token: 0x06002A0E RID: 10766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0E")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A0F")]
		[Address(RVA = "0x585540", Offset = "0x583F40", VA = "0x180585540")]
		public void Initialize(IEnumerable<ValueTuple<int, int, PartnerBase>> employeeData)
		{
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A10")]
		[Address(RVA = "0x584F30", Offset = "0x583930", VA = "0x180584F30")]
		private void InitializePartnerStatus(UIElementCluster component, ValueTuple<int, int, PartnerBase> data)
		{
		}

		// Token: 0x06002A11 RID: 10769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A11")]
		[Address(RVA = "0x5857E0", Offset = "0x5841E0", VA = "0x1805857E0")]
		public void UpdateStatus(int? deskCode, string data, int partnerIndex)
		{
		}

		// Token: 0x06002A12 RID: 10770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A12")]
		[Address(RVA = "0x584E50", Offset = "0x583850", VA = "0x180584E50", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A13")]
		[Address(RVA = "0x585890", Offset = "0x584290", VA = "0x180585890")]
		public PartnerStateModuleUI()
		{
		}

		// Token: 0x0400268F RID: 9871
		[Token(Token = "0x400268F")]
		[FieldOffset(Offset = "0x18")]
		public GameObject partnerStatusElementParent;

		// Token: 0x04002690 RID: 9872
		[Token(Token = "0x4002690")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform partnerStatusField;

		// Token: 0x04002691 RID: 9873
		[Token(Token = "0x4002691")]
		[FieldOffset(Offset = "0x28")]
		public PartnerStateModuleUI.JobColorPair[] jobTextColors;

		// Token: 0x04002692 RID: 9874
		[Token(Token = "0x4002692")]
		[FieldOffset(Offset = "0x30")]
		private readonly string[] allBgs;

		// Token: 0x04002693 RID: 9875
		[Token(Token = "0x4002693")]
		[FieldOffset(Offset = "0x38")]
		private readonly string[] allFgs;

		// Token: 0x04002694 RID: 9876
		[Token(Token = "0x4002694")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<int, Action<int?, string>> handles;

		// Token: 0x04002695 RID: 9877
		[Token(Token = "0x4002695")]
		[FieldOffset(Offset = "0x48")]
		private List<GameObject> allPartnerStatusElementInstances;

		// Token: 0x04002696 RID: 9878
		[Token(Token = "0x4002696")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<PartnerBase.PartnerType, Color32> partnerTypeColor;

		// Token: 0x020006EE RID: 1774
		[Token(Token = "0x20006EE")]
		[Serializable]
		public struct JobColorPair
		{
			// Token: 0x04002697 RID: 9879
			[Token(Token = "0x4002697")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public PartnerBase.PartnerType partnerType;

			// Token: 0x04002698 RID: 9880
			[Token(Token = "0x4002698")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public Color32 textColor;
		}
	}
}

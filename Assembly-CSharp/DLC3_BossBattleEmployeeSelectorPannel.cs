using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

// Token: 0x02000020 RID: 32
[Token(Token = "0x2000020")]
[GenerateCleanupMethod]
public class DLC3_BossBattleEmployeeSelectorPannel : UIPanel
{
	// Token: 0x17000011 RID: 17
	// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002310 File Offset: 0x00000510
	// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000011")]
	public DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext PannelOpenContext
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x408AA0", Offset = "0x4074A0", VA = "0x180408AA0")]
		[CompilerGenerated]
		private get
		{
			return default(DLC3_BossBattleEmployeeSelectorPannel.EmployeeSelectorOpenContext);
		}
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x408AE0", Offset = "0x4074E0", VA = "0x180408AE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x060000A7 RID: 167 RVA: 0x00002328 File Offset: 0x00000528
	// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000012")]
	public DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty FinalSelected
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x408A80", Offset = "0x407480", VA = "0x180408A80")]
		[CompilerGenerated]
		get
		{
			return default(DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty);
		}
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x408AB0", Offset = "0x4074B0", VA = "0x180408AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x407860", Offset = "0x406260", VA = "0x180407860", Slot = "22")]
	protected override void OnPanelInitialize()
	{
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x407B70", Offset = "0x406570", VA = "0x180407B70", Slot = "21")]
	protected override void OnPanelOpen()
	{
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x408020", Offset = "0x406A20", VA = "0x180408020")]
	private void ProcessElements(UIElementCluster uiElement, int partnerId)
	{
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x4070B0", Offset = "0x405AB0", VA = "0x1804070B0")]
	private void ChangeImage(Image image, bool shouldOpen, Sprite sprite)
	{
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x4072A0", Offset = "0x405CA0", VA = "0x1804072A0")]
	private void Describe(int partnerId, string titleLang)
	{
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x407230", Offset = "0x405C30", VA = "0x180407230")]
	private void ConfirmChoiceStart(InputAction.CallbackContext callbackContext)
	{
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x407200", Offset = "0x405C00", VA = "0x180407200")]
	private void ConfirmChoiceEnd(InputAction.CallbackContext callbackContext)
	{
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x407820", Offset = "0x406220", VA = "0x180407820", Slot = "23")]
	protected override void OnPanelClose()
	{
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x407110", Offset = "0x405B10", VA = "0x180407110", Slot = "31")]
	protected override void Cleanup_Generated()
	{
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x408990", Offset = "0x407390", VA = "0x180408990")]
	public DLC3_BossBattleEmployeeSelectorPannel()
	{
	}

	// Token: 0x04000088 RID: 136
	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x70")]
	public UIElementCluster cluster;

	// Token: 0x04000089 RID: 137
	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x78")]
	public RectTransform container;

	// Token: 0x0400008A RID: 138
	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x80")]
	public UIButtonHold buttonHold;

	// Token: 0x0400008B RID: 139
	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x88")]
	public GameObject charaterObject;

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x90")]
	public DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty[] partnerProperty;

	// Token: 0x0400008D RID: 141
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x98")]
	private readonly List<GameObject> m_AllInstances;

	// Token: 0x0400008E RID: 142
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0xA0")]
	private readonly UILogicalGroupT<int> m_PartnerGroup;

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0xA8")]
	private CancellationTokenSource m_PanelTokenSource;

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<int, DLC3_BossBattleEmployeeSelectorPannel.PartnerProperty> partnerPropertyDic;

	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public readonly struct EmployeeSelectorOpenContext
	{
		// Token: 0x060000BA RID: 186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x40C360", Offset = "0x40AD60", VA = "0x18040C360")]
		public EmployeeSelectorOpenContext(PartnerBossInfo bossStatus, List<int> unlockedPartner)
		{
		}

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x0")]
		public readonly PartnerBossInfo bossStatus;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x8")]
		public readonly List<int> unlockedPartner;
	}

	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[Serializable]
	public struct PartnerProperty
	{
		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public int id;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public string key;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string interactableKey;
	}
}

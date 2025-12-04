using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using GameData.Profile;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020002AD RID: 685
	[Token(Token = "0x20002AD")]
	[GenerateCleanupMethod]
	public class DaySceneIzakayaSelectorPartnerSubPannel : UIPanelParamOpen<DaySceneIzakayaSelectorPartnerSubPannel.OpenContext>
	{
		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017D")]
		private IEnumerable<int> PartnerData
		{
			[Token(Token = "0x6000F6A")]
			[Address(RVA = "0x9200A0", Offset = "0x91EAA0", VA = "0x1809200A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x000062E8 File Offset: 0x000044E8
		[Token(Token = "0x1700017E")]
		private int MaxPartnerSlots
		{
			[Token(Token = "0x6000F6B")]
			[Address(RVA = "0x920010", Offset = "0x91EA10", VA = "0x180920010")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00006300 File Offset: 0x00004500
		// (set) Token: 0x06000F6D RID: 3949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700017F")]
		[TupleElementNames(new string[] { "CharacterId", "CharacterJob" })]
		private ValueTuple<int, PartnerBase.PartnerType> SelectedCharacterData
		{
			[Token(Token = "0x6000F6C")]
			[Address(RVA = "0x9200D0", Offset = "0x91EAD0", VA = "0x1809200D0")]
			get
			{
				return default(ValueTuple<int, PartnerBase.PartnerType>);
			}
			[Token(Token = "0x6000F6D")]
			[Address(RVA = "0x920160", Offset = "0x91EB60", VA = "0x180920160")]
			[param: TupleElementNames(new string[] { "CharacterId", "CharacterJob" })]
			set
			{
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000F6E RID: 3950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000180")]
		[TupleElementNames(new string[] { "CharacterId", "CharacterJob" })]
		private IList<ValueTuple<int, PartnerBase.PartnerType>> partnerSelection
		{
			[Token(Token = "0x6000F6E")]
			[Address(RVA = "0x920130", Offset = "0x91EB30", VA = "0x180920130")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0x91CF50", Offset = "0x91B950", VA = "0x18091CF50", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F70")]
		[Address(RVA = "0x91D900", Offset = "0x91C300", VA = "0x18091D900")]
		private void PartnerUITabSwitchHandler(InputAction.CallbackContext switchAction)
		{
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F71")]
		[Address(RVA = "0x91E5C0", Offset = "0x91CFC0", VA = "0x18091E5C0")]
		public void UISetSlot(int slotIndex)
		{
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F72")]
		[Address(RVA = "0x91E500", Offset = "0x91CF00", VA = "0x18091E500")]
		public void UISetJob(int jobData)
		{
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F73")]
		[Address(RVA = "0x91D350", Offset = "0x91BD50", VA = "0x18091D350", Slot = "32")]
		protected override void OnPanelOpen(DaySceneIzakayaSelectorPartnerSubPannel.OpenContext openParam)
		{
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F74")]
		[Address(RVA = "0x91D830", Offset = "0x91C230", VA = "0x18091D830")]
		private void OnPartnerUIMove(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F75")]
		[Address(RVA = "0x91D890", Offset = "0x91C290", VA = "0x18091D890")]
		private void OnPartnerUIScroll(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F76")]
		[Address(RVA = "0x91D360", Offset = "0x91BD60", VA = "0x18091D360")]
		private void OnPartnerUIMoveInternal(MoveDirection moveDirection)
		{
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x91CD80", Offset = "0x91B780", VA = "0x18091CD80")]
		private void CorrectTargetId(PartnerBase.PartnerType targetJob, ref int targetId)
		{
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x91E5D0", Offset = "0x91CFD0", VA = "0x18091E5D0")]
		private void UpdatePartnerUI()
		{
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F79")]
		[Address(RVA = "0x91CBE0", Offset = "0x91B5E0", VA = "0x18091CBE0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0x91FE10", Offset = "0x91E810", VA = "0x18091FE10")]
		public DaySceneIzakayaSelectorPartnerSubPannel()
		{
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00006318 File Offset: 0x00004518
		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0x91DDF0", Offset = "0x91C7F0", VA = "0x18091DDF0")]
		[CompilerGenerated]
		internal static PartnerBase.PartnerType <OnPartnerUIMoveInternal>g__GetNextJob|33_0(PartnerBase.PartnerType currentJob)
		{
			return PartnerBase.PartnerType.Cook;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x00006330 File Offset: 0x00004530
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0x91E170", Offset = "0x91CB70", VA = "0x18091E170")]
		[CompilerGenerated]
		internal static PartnerBase.PartnerType <OnPartnerUIMoveInternal>g__GetPrevJob|33_1(PartnerBase.PartnerType currentJob)
		{
			return PartnerBase.PartnerType.Cook;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00006348 File Offset: 0x00004548
		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0x91DE20", Offset = "0x91C820", VA = "0x18091DE20")]
		[CompilerGenerated]
		private int <OnPartnerUIMoveInternal>g__GetNextPartner|33_2(int currentPartner)
		{
			return 0;
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00006390 File Offset: 0x00004590
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x91E1A0", Offset = "0x91CBA0", VA = "0x18091E1A0")]
		[CompilerGenerated]
		private int <OnPartnerUIMoveInternal>g__GetPrevPartner|33_3(int currentPartner)
		{
			return 0;
		}

		// Token: 0x04000E34 RID: 3636
		[Token(Token = "0x4000E34")]
		[FieldOffset(Offset = "0x80")]
		public GameObject partnerElementParent;

		// Token: 0x04000E35 RID: 3637
		[Token(Token = "0x4000E35")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform selectablePartnerField;

		// Token: 0x04000E36 RID: 3638
		[Token(Token = "0x4000E36")]
		[FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI selectedCharacterName;

		// Token: 0x04000E37 RID: 3639
		[Token(Token = "0x4000E37")]
		[FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI selectedCharacterDescription;

		// Token: 0x04000E38 RID: 3640
		[Token(Token = "0x4000E38")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI selectedCharacterProperties;

		// Token: 0x04000E39 RID: 3641
		[Token(Token = "0x4000E39")]
		[FieldOffset(Offset = "0xA8")]
		public Image selectedCharacterMain;

		// Token: 0x04000E3A RID: 3642
		[Token(Token = "0x4000E3A")]
		[FieldOffset(Offset = "0xB0")]
		public Image selectedCharacterEyes;

		// Token: 0x04000E3B RID: 3643
		[Token(Token = "0x4000E3B")]
		[FieldOffset(Offset = "0xB8")]
		public Image selectedCharacterTrimBack;

		// Token: 0x04000E3C RID: 3644
		[Token(Token = "0x4000E3C")]
		[FieldOffset(Offset = "0xC0")]
		public Image selectedCharacterTrimFront;

		// Token: 0x04000E3D RID: 3645
		[Token(Token = "0x4000E3D")]
		[FieldOffset(Offset = "0xC8")]
		public Sprite clear;

		// Token: 0x04000E3E RID: 3646
		[Token(Token = "0x4000E3E")]
		[FieldOffset(Offset = "0xD0")]
		public UIElementCluster[] partnerSlots;

		// Token: 0x04000E3F RID: 3647
		[Token(Token = "0x4000E3F")]
		[FieldOffset(Offset = "0xD8")]
		public UIElementCluster[] selectedCharacterJobButtons;

		// Token: 0x04000E40 RID: 3648
		[Token(Token = "0x4000E40")]
		[FieldOffset(Offset = "0xE0")]
		public AdpScrollListFixedComponent partnerFieldScroller;

		// Token: 0x04000E41 RID: 3649
		[Token(Token = "0x4000E41")]
		[FieldOffset(Offset = "0xE8")]
		private readonly List<GameObject> allPartnerInstance;

		// Token: 0x04000E42 RID: 3650
		[Token(Token = "0x4000E42")]
		[FieldOffset(Offset = "0xF0")]
		private int currentSlotSelectionIndex;

		// Token: 0x04000E43 RID: 3651
		[Token(Token = "0x4000E43")]
		[FieldOffset(Offset = "0xF8")]
		private readonly string[] colorBGCollection;

		// Token: 0x020002AE RID: 686
		[Token(Token = "0x20002AE")]
		public readonly struct OpenContext
		{
			// Token: 0x06000F83 RID: 3971 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000F83")]
			[Address(RVA = "0x40C360", Offset = "0x40AD60", VA = "0x18040C360")]
			public OpenContext(IEnumerable<int> partnerData, [TupleElementNames(new string[] { "CharacterId", "CharacterJob" })] IList<ValueTuple<int, PartnerBase.PartnerType>> partnerSelection)
			{
			}

			// Token: 0x04000E44 RID: 3652
			[Token(Token = "0x4000E44")]
			[FieldOffset(Offset = "0x0")]
			public readonly IEnumerable<int> PartnerData;

			// Token: 0x04000E45 RID: 3653
			[Token(Token = "0x4000E45")]
			[FieldOffset(Offset = "0x8")]
			[TupleElementNames(new string[] { "CharacterId", "CharacterJob" })]
			public readonly IList<ValueTuple<int, PartnerBase.PartnerType>> PartnerSelection;
		}
	}
}

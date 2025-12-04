using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000E19 RID: 3609
	[Token(Token = "0x2000E19")]
	[GenerateCleanupMethod]
	public class SpecialGuestDescriber : LanguageBaseDescriber, ITypedDescriber<SpecialGuest>, IDescriber
	{
		// Token: 0x06005461 RID: 21601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005461")]
		[Address(RVA = "0x845410", Offset = "0x843E10", VA = "0x180845410")]
		protected void Awake()
		{
		}

		// Token: 0x06005462 RID: 21602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005462")]
		[Address(RVA = "0x847200", Offset = "0x845C00", VA = "0x180847200")]
		private void OnDisable()
		{
		}

		// Token: 0x06005463 RID: 21603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005463")]
		[Address(RVA = "0x847280", Offset = "0x845C80", VA = "0x180847280", Slot = "6")]
		protected override void OnPreload()
		{
		}

		// Token: 0x06005464 RID: 21604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005464")]
		[Address(RVA = "0x847180", Offset = "0x845B80", VA = "0x180847180", Slot = "8")]
		protected override void OnDescriberDestroyed()
		{
		}

		// Token: 0x06005465 RID: 21605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005465")]
		[Address(RVA = "0x8476C0", Offset = "0x8460C0", VA = "0x1808476C0")]
		public void SwitchMode()
		{
		}

		// Token: 0x06005466 RID: 21606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005466")]
		[Address(RVA = "0x847460", Offset = "0x845E60", VA = "0x180847460")]
		private void ShowDescription()
		{
		}

		// Token: 0x06005467 RID: 21607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005467")]
		[Address(RVA = "0x847480", Offset = "0x845E80", VA = "0x180847480")]
		private void ShowInfo()
		{
		}

		// Token: 0x06005468 RID: 21608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005468")]
		[Address(RVA = "0x8476F0", Offset = "0x8460F0", VA = "0x1808476F0")]
		private void UpdateModeVisual()
		{
		}

		// Token: 0x06005469 RID: 21609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005469")]
		[Address(RVA = "0x8474A0", Offset = "0x845EA0", VA = "0x1808474A0")]
		private void StartTrimCoroutine(CharacterSpriteSetCompact pixel)
		{
		}

		// Token: 0x0600546A RID: 21610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600546A")]
		[Address(RVA = "0x847430", Offset = "0x845E30", VA = "0x180847430")]
		public void SetParticularMode(bool hideKisunaBox)
		{
		}

		// Token: 0x0600546B RID: 21611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600546B")]
		[Address(RVA = "0x846780", Offset = "0x845180", VA = "0x180846780", Slot = "10")]
		public void Describe(SpecialGuest detail, CancellationToken cancellationToken)
		{
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600546C")]
		[Address(RVA = "0x8452B0", Offset = "0x843CB0", VA = "0x1808452B0")]
		private void ApplySpriteOffset(SpecialGuest detail)
		{
		}

		// Token: 0x0600546D RID: 21613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600546D")]
		[Address(RVA = "0x845A50", Offset = "0x844450", VA = "0x180845A50")]
		public void DescribePartner(SpecialGuest detail, CancellationToken cancellationToken)
		{
		}

		// Token: 0x0600546E RID: 21614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600546E")]
		[Address(RVA = "0x845CC0", Offset = "0x8446C0", VA = "0x180845CC0")]
		public void DescribeSpellCard(SpecialGuest detail)
		{
		}

		// Token: 0x0600546F RID: 21615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600546F")]
		[Address(RVA = "0x8457F0", Offset = "0x8441F0", VA = "0x1808457F0", Slot = "9")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005470")]
		[Address(RVA = "0x847820", Offset = "0x846220", VA = "0x180847820")]
		public SpecialGuestDescriber()
		{
		}

		// Token: 0x04004F44 RID: 20292
		[Token(Token = "0x4004F44")]
		[FieldOffset(Offset = "0x60")]
		[Header("Speical Guest")]
		public Image bse;

		// Token: 0x04004F45 RID: 20293
		[Token(Token = "0x4004F45")]
		[FieldOffset(Offset = "0x68")]
		public Image eyes;

		// Token: 0x04004F46 RID: 20294
		[Token(Token = "0x4004F46")]
		[FieldOffset(Offset = "0x70")]
		public Image trimBack;

		// Token: 0x04004F47 RID: 20295
		[Token(Token = "0x4004F47")]
		[FieldOffset(Offset = "0x78")]
		public Image trimFront;

		// Token: 0x04004F48 RID: 20296
		[Token(Token = "0x4004F48")]
		[FieldOffset(Offset = "0x80")]
		public Image portrayal;

		// Token: 0x04004F49 RID: 20297
		[Token(Token = "0x4004F49")]
		[FieldOffset(Offset = "0x88")]
		public GameObject foodTagParent;

		// Token: 0x04004F4A RID: 20298
		[Token(Token = "0x4004F4A")]
		[FieldOffset(Offset = "0x90")]
		public GameObject banTagParent;

		// Token: 0x04004F4B RID: 20299
		[Token(Token = "0x4004F4B")]
		[FieldOffset(Offset = "0x98")]
		public GameObject bevTagParent;

		// Token: 0x04004F4C RID: 20300
		[Token(Token = "0x4004F4C")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI placeText;

		// Token: 0x04004F4D RID: 20301
		[Token(Token = "0x4004F4D")]
		[FieldOffset(Offset = "0xA8")]
		public RectTransform foodTagField;

		// Token: 0x04004F4E RID: 20302
		[Token(Token = "0x4004F4E")]
		[FieldOffset(Offset = "0xB0")]
		public RectTransform bevTagField;

		// Token: 0x04004F4F RID: 20303
		[Token(Token = "0x4004F4F")]
		[FieldOffset(Offset = "0xB8")]
		public TextMeshProUGUI funds;

		// Token: 0x04004F50 RID: 20304
		[Token(Token = "0x4004F50")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject kizunaField;

		// Token: 0x04004F51 RID: 20305
		[Token(Token = "0x4004F51")]
		[FieldOffset(Offset = "0xC8")]
		public Image kizunaExp;

		// Token: 0x04004F52 RID: 20306
		[Token(Token = "0x4004F52")]
		[FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI kizunaLevel;

		// Token: 0x04004F53 RID: 20307
		[Token(Token = "0x4004F53")]
		[FieldOffset(Offset = "0xD8")]
		public CanvasGroup InfoField;

		// Token: 0x04004F54 RID: 20308
		[Token(Token = "0x4004F54")]
		[FieldOffset(Offset = "0xE0")]
		public CanvasGroup DescriptionField;

		// Token: 0x04004F55 RID: 20309
		[Token(Token = "0x4004F55")]
		[FieldOffset(Offset = "0xE8")]
		public UIButtonToggle GotoInfoToggle;

		// Token: 0x04004F56 RID: 20310
		[Token(Token = "0x4004F56")]
		[FieldOffset(Offset = "0xF0")]
		public UIButtonToggle GotoDescriptionToggle;

		// Token: 0x04004F57 RID: 20311
		[Token(Token = "0x4004F57")]
		[FieldOffset(Offset = "0xF8")]
		[Header("Partner")]
		public TextMeshProUGUI partnerProperties;

		// Token: 0x04004F58 RID: 20312
		[Token(Token = "0x4004F58")]
		[FieldOffset(Offset = "0x100")]
		[Header("SpellCard")]
		public UIElementCluster positiveSC;

		// Token: 0x04004F59 RID: 20313
		[Token(Token = "0x4004F59")]
		[FieldOffset(Offset = "0x108")]
		public UIElementCluster negativeSC;

		// Token: 0x04004F5A RID: 20314
		[Token(Token = "0x4004F5A")]
		[FieldOffset(Offset = "0x110")]
		private List<GameObject> allBanTagInstances;

		// Token: 0x04004F5B RID: 20315
		[Token(Token = "0x4004F5B")]
		[FieldOffset(Offset = "0x118")]
		private List<GameObject> allBevTagInstances;

		// Token: 0x04004F5C RID: 20316
		[Token(Token = "0x4004F5C")]
		[FieldOffset(Offset = "0x120")]
		private List<GameObject> allFoodTagInstances;

		// Token: 0x04004F5D RID: 20317
		[Token(Token = "0x4004F5D")]
		[FieldOffset(Offset = "0x128")]
		private NumberFormatInfo currencyInfo;

		// Token: 0x04004F5E RID: 20318
		[Token(Token = "0x4004F5E")]
		[FieldOffset(Offset = "0x130")]
		private SpecialGuestDescriber.SwitcherMode m_CurrentSwitcherSwitcherMode;

		// Token: 0x04004F5F RID: 20319
		[Token(Token = "0x4004F5F")]
		[FieldOffset(Offset = "0x134")]
		private bool? m_LastMode;

		// Token: 0x04004F60 RID: 20320
		[Token(Token = "0x4004F60")]
		[FieldOffset(Offset = "0x138")]
		private Coroutine trimBackCoroutine;

		// Token: 0x04004F61 RID: 20321
		[Token(Token = "0x4004F61")]
		[FieldOffset(Offset = "0x140")]
		private bool m_IsSwitchModeEnabled;

		// Token: 0x04004F62 RID: 20322
		[Token(Token = "0x4004F62")]
		[FieldOffset(Offset = "0x148")]
		private Coroutine trimFrontCoroutine;

		// Token: 0x02000E1A RID: 3610
		[Token(Token = "0x2000E1A")]
		private enum SwitcherMode
		{
			// Token: 0x04004F64 RID: 20324
			[Token(Token = "0x4004F64")]
			Info,
			// Token: 0x04004F65 RID: 20325
			[Token(Token = "0x4004F65")]
			Description
		}
	}
}

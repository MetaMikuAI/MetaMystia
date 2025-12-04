using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using GameData.Profile;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020002A2 RID: 674
	[Token(Token = "0x20002A2")]
	[GenerateCleanupMethod]
	public class DaySceneIzakayaSelectorPannel : UIPanel
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000F1E RID: 3870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000176")]
		[TupleElementNames(new string[] { "CharacterId", "CharacterJob" })]
		public ValueTuple<int, PartnerBase.PartnerType>[] partnerSelection
		{
			[Token(Token = "0x6000F1D")]
			[Address(RVA = "0x48A980", Offset = "0x489380", VA = "0x18048A980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F1E")]
			[Address(RVA = "0x90AFC0", Offset = "0x9099C0", VA = "0x18090AFC0")]
			[CompilerGenerated]
			[param: TupleElementNames(new string[] { "CharacterId", "CharacterJob" })]
			private set
			{
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000177")]
		public IEnumerable<int> PartnerData
		{
			[Token(Token = "0x6000F1F")]
			[Address(RVA = "0x90AD80", Offset = "0x909780", VA = "0x18090AD80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000178")]
		[TupleElementNames(new string[] { "CharacterId", "CharacterJob" })]
		public IList<ValueTuple<int, PartnerBase.PartnerType>> PartnerSelection
		{
			[Token(Token = "0x6000F20")]
			[Address(RVA = "0x48A980", Offset = "0x489380", VA = "0x18048A980")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00006180 File Offset: 0x00004380
		// (set) Token: 0x06000F22 RID: 3874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000179")]
		public int selectedIzakayaIndex
		{
			[Token(Token = "0x6000F21")]
			[Address(RVA = "0x90ADA0", Offset = "0x9097A0", VA = "0x18090ADA0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000F22")]
			[Address(RVA = "0x90AFE0", Offset = "0x9099E0", VA = "0x18090AFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700017A RID: 378
		// (set) Token: 0x06000F23 RID: 3875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700017A")]
		private int CookingDeskAmount
		{
			[Token(Token = "0x6000F23")]
			[Address(RVA = "0x90ADB0", Offset = "0x9097B0", VA = "0x18090ADB0")]
			set
			{
			}
		}

		// Token: 0x1700017B RID: 379
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700017B")]
		private int GuestTableAmount
		{
			[Token(Token = "0x6000F24")]
			[Address(RVA = "0x90AEA0", Offset = "0x9098A0", VA = "0x18090AEA0")]
			set
			{
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00006198 File Offset: 0x00004398
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700017C")]
		public DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext OpenContext
		{
			[Token(Token = "0x6000F25")]
			[Address(RVA = "0x90AD60", Offset = "0x909760", VA = "0x18090AD60")]
			[CompilerGenerated]
			private get
			{
				return default(DaySceneIzakayaSelectorPannel.IzakayaConfigurePannelOpenContext);
			}
			[Token(Token = "0x6000F26")]
			[Address(RVA = "0x90AF90", Offset = "0x909990", VA = "0x18090AF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F27")]
		[Address(RVA = "0x907B00", Offset = "0x906500", VA = "0x180907B00", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F28")]
		[Address(RVA = "0x9085C0", Offset = "0x906FC0", VA = "0x1809085C0")]
		private void OpenNotebook()
		{
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F29")]
		[Address(RVA = "0x908780", Offset = "0x907180", VA = "0x180908780")]
		private void OpenStorage()
		{
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F2A")]
		[Address(RVA = "0x908BA0", Offset = "0x9075A0", VA = "0x180908BA0")]
		private void TabSwitchHandler(InputAction.CallbackContext switchAction)
		{
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F2B")]
		[Address(RVA = "0x908AD0", Offset = "0x9074D0", VA = "0x180908AD0")]
		private void SetupPartnerPannelInput(bool doReg)
		{
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F2C")]
		[Address(RVA = "0x907F00", Offset = "0x906900", VA = "0x180907F00", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F2D")]
		[Address(RVA = "0x90A880", Offset = "0x909280", VA = "0x18090A880")]
		public void UpdatePartnerIndicator()
		{
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F2E")]
		[Address(RVA = "0x9072B0", Offset = "0x905CB0", VA = "0x1809072B0")]
		public string GetEnableColor(PartnerBase.PartnerType jobType)
		{
			return null;
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F2F")]
		[Address(RVA = "0x907A60", Offset = "0x906460", VA = "0x180907A60", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F30")]
		[Address(RVA = "0x908660", Offset = "0x907060", VA = "0x180908660")]
		private void OpenPartnerUI(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F31")]
		[Address(RVA = "0x908660", Offset = "0x907060", VA = "0x180908660")]
		private void OpenPartnerUI()
		{
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F32")]
		[Address(RVA = "0x909200", Offset = "0x907C00", VA = "0x180909200")]
		private void UpdateAllSpot()
		{
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F33")]
		[Address(RVA = "0x907540", Offset = "0x905F40", VA = "0x180907540")]
		private void OnHighlight(List<int> izakayaId, IzakayaSpot currentSelectedSpot)
		{
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F34")]
		[Address(RVA = "0x909C30", Offset = "0x908630", VA = "0x180909C30")]
		private void UpdateCurrentIzakaya(int newIzakayaId)
		{
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F35")]
		[Address(RVA = "0x908820", Offset = "0x907220", VA = "0x180908820")]
		private static void Process(UIElementCluster visual, [TupleElementNames(new string[] { "Name", "CharacterSprite" })] ValueTuple<string, CharacterSpriteSetCompact> data)
		{
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F36")]
		[Address(RVA = "0x907020", Offset = "0x905A20", VA = "0x180907020")]
		private void ConfirmChoiceStart(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F37")]
		[Address(RVA = "0x906FF0", Offset = "0x9059F0", VA = "0x180906FF0")]
		private void ConfirmChoiceEnd(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F38")]
		[Address(RVA = "0x907090", Offset = "0x905A90", VA = "0x180907090")]
		private void ConfirmChoice()
		{
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F39")]
		[Address(RVA = "0x907370", Offset = "0x905D70", VA = "0x180907370")]
		private void LoadSelectionToIzakayaConfig()
		{
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F3A")]
		[Address(RVA = "0x906C40", Offset = "0x905640", VA = "0x180906C40", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F3B")]
		[Address(RVA = "0x90AAB0", Offset = "0x9094B0", VA = "0x18090AAB0")]
		public DaySceneIzakayaSelectorPannel()
		{
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F3C")]
		[Address(RVA = "0x908DE0", Offset = "0x9077E0", VA = "0x180908DE0")]
		[CompilerGenerated]
		private void <UpdatePartnerIndicator>g__ProcessSpawnedPartnerDataElement|66_0(UIElementCluster elementCluster, [TupleElementNames(new string[] { "PartnerId", "Selection" })] ValueTuple<int, PartnerBase.PartnerType> partnerData)
		{
		}

		// Token: 0x04000DE5 RID: 3557
		[Token(Token = "0x4000DE5")]
		[FieldOffset(Offset = "0x70")]
		public IzakayaSpot[] allSpots;

		// Token: 0x04000DE6 RID: 3558
		[Token(Token = "0x4000DE6")]
		[FieldOffset(Offset = "0x78")]
		public GameObject highlight;

		// Token: 0x04000DE7 RID: 3559
		[Token(Token = "0x4000DE7")]
		[FieldOffset(Offset = "0x80")]
		public AudioClip switchAudio;

		// Token: 0x04000DE8 RID: 3560
		[Token(Token = "0x4000DE8")]
		[FieldOffset(Offset = "0x88")]
		public Sprite normalSprite;

		// Token: 0x04000DE9 RID: 3561
		[Token(Token = "0x4000DE9")]
		[FieldOffset(Offset = "0x90")]
		public Sprite selectdSprite;

		// Token: 0x04000DEA RID: 3562
		[Token(Token = "0x4000DEA")]
		[FieldOffset(Offset = "0x98")]
		public Sprite disabledSprite;

		// Token: 0x04000DEB RID: 3563
		[Token(Token = "0x4000DEB")]
		[FieldOffset(Offset = "0xA0")]
		public UIButtonHold gotoIzakayaButton;

		// Token: 0x04000DEC RID: 3564
		[Token(Token = "0x4000DEC")]
		[FieldOffset(Offset = "0xA8")]
		public UIButtonSimple noteBookBtn;

		// Token: 0x04000DED RID: 3565
		[Token(Token = "0x4000DED")]
		[FieldOffset(Offset = "0xB0")]
		public UIButtonSimple storageBtn;

		// Token: 0x04000DEE RID: 3566
		[Token(Token = "0x4000DEE")]
		[FieldOffset(Offset = "0xB8")]
		public UIButtonSimple[] izakayaSelections;

		// Token: 0x04000DEF RID: 3567
		[Token(Token = "0x4000DEF")]
		[FieldOffset(Offset = "0xC0")]
		public TextMeshProUGUI izakayaName;

		// Token: 0x04000DF0 RID: 3568
		[Token(Token = "0x4000DF0")]
		[FieldOffset(Offset = "0xC8")]
		public TextMeshProUGUI description;

		// Token: 0x04000DF1 RID: 3569
		[Token(Token = "0x4000DF1")]
		[FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI cookingDeskAmount1;

		// Token: 0x04000DF2 RID: 3570
		[Token(Token = "0x4000DF2")]
		[FieldOffset(Offset = "0xD8")]
		public TextMeshProUGUI cookingDeskAmount2;

		// Token: 0x04000DF3 RID: 3571
		[Token(Token = "0x4000DF3")]
		[FieldOffset(Offset = "0xE0")]
		public TextMeshProUGUI guestTableAmount1;

		// Token: 0x04000DF4 RID: 3572
		[Token(Token = "0x4000DF4")]
		[FieldOffset(Offset = "0xE8")]
		public TextMeshProUGUI guestTableAmount2;

		// Token: 0x04000DF5 RID: 3573
		[Token(Token = "0x4000DF5")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject characterParent;

		// Token: 0x04000DF6 RID: 3574
		[Token(Token = "0x4000DF6")]
		[FieldOffset(Offset = "0xF8")]
		public RectTransform characterField;

		// Token: 0x04000DF7 RID: 3575
		[Token(Token = "0x4000DF7")]
		[FieldOffset(Offset = "0x100")]
		public GameObject specialFieldParent;

		// Token: 0x04000DF8 RID: 3576
		[Token(Token = "0x4000DF8")]
		[FieldOffset(Offset = "0x108")]
		public RectTransform specialCharacterField;

		// Token: 0x04000DF9 RID: 3577
		[Token(Token = "0x4000DF9")]
		[FieldOffset(Offset = "0x110")]
		public GameObject multiPartnerParent;

		// Token: 0x04000DFA RID: 3578
		[Token(Token = "0x4000DFA")]
		[FieldOffset(Offset = "0x118")]
		public GameObject multiPartnerObject;

		// Token: 0x04000DFB RID: 3579
		[Token(Token = "0x4000DFB")]
		[FieldOffset(Offset = "0x120")]
		public GameObject singlePartnerObject;

		// Token: 0x04000DFC RID: 3580
		[Token(Token = "0x4000DFC")]
		[FieldOffset(Offset = "0x128")]
		public RectTransform partnerField;

		// Token: 0x04000DFD RID: 3581
		[Token(Token = "0x4000DFD")]
		[FieldOffset(Offset = "0x130")]
		public GameObject lockedSelectionPointerParent;

		// Token: 0x04000DFE RID: 3582
		[Token(Token = "0x4000DFE")]
		[FieldOffset(Offset = "0x138")]
		public RectTransform lockedSelectionPointerField;

		// Token: 0x04000DFF RID: 3583
		[Token(Token = "0x4000DFF")]
		[FieldOffset(Offset = "0x140")]
		public GameObject lockedSelectionIndicator;

		// Token: 0x04000E00 RID: 3584
		[Token(Token = "0x4000E00")]
		[FieldOffset(Offset = "0x148")]
		public UIButtonSimple gotoPartnerButton;

		// Token: 0x04000E01 RID: 3585
		[Token(Token = "0x4000E01")]
		[FieldOffset(Offset = "0x150")]
		public DaySceneIzakayaSelectorPannel.Connection[] connections;

		// Token: 0x04000E02 RID: 3586
		[Token(Token = "0x4000E02")]
		[FieldOffset(Offset = "0x158")]
		private readonly List<GameObject> allLockedSelectionPointerInstances;

		// Token: 0x04000E03 RID: 3587
		[Token(Token = "0x4000E03")]
		[FieldOffset(Offset = "0x160")]
		private readonly List<GameObject> allNormalCharacterInstances;

		// Token: 0x04000E04 RID: 3588
		[Token(Token = "0x4000E04")]
		[FieldOffset(Offset = "0x168")]
		private readonly List<GameObject> allPartnerInstances;

		// Token: 0x04000E05 RID: 3589
		[Token(Token = "0x4000E05")]
		[FieldOffset(Offset = "0x170")]
		private readonly List<GameObject> allSpecialCharacterInstances;

		// Token: 0x04000E06 RID: 3590
		[Token(Token = "0x4000E06")]
		[FieldOffset(Offset = "0x178")]
		public readonly string[] colorBGCollection;

		// Token: 0x04000E07 RID: 3591
		[Token(Token = "0x4000E07")]
		[FieldOffset(Offset = "0x180")]
		private string currentSelectedPlace;

		// Token: 0x04000E08 RID: 3592
		[Token(Token = "0x4000E08")]
		[FieldOffset(Offset = "0x188")]
		private Action deSelectHandle;

		// Token: 0x04000E09 RID: 3593
		[Token(Token = "0x4000E09")]
		[FieldOffset(Offset = "0x190")]
		private List<int> focusedMapIzakayas;

		// Token: 0x04000E0A RID: 3594
		[Token(Token = "0x4000E0A")]
		[FieldOffset(Offset = "0x198")]
		private SchedulerNode.Trigger.IzakayaLockType izakayaLockType;

		// Token: 0x04000E0B RID: 3595
		[Token(Token = "0x4000E0B")]
		[FieldOffset(Offset = "0x1A0")]
		private Dictionary<int, int> izakayaMappings;

		// Token: 0x04000E0C RID: 3596
		[Token(Token = "0x4000E0C")]
		[FieldOffset(Offset = "0x1A8")]
		private Image[] izakayaSelectionVisual;

		// Token: 0x020002A3 RID: 675
		[Token(Token = "0x20002A3")]
		public struct IzakayaConfigurePannelOpenContext
		{
			// Token: 0x06000F3E RID: 3902 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000F3E")]
			[Address(RVA = "0x92CF60", Offset = "0x92B960", VA = "0x18092CF60")]
			public IzakayaConfigurePannelOpenContext(SchedulerNode.Trigger.IzakayaLockType lockType, SchedulerNode.Trigger.IzakayaMapping[] mappings, IEnumerable<int> partnerData)
			{
			}

			// Token: 0x04000E10 RID: 3600
			[Token(Token = "0x4000E10")]
			[FieldOffset(Offset = "0x0")]
			public readonly SchedulerNode.Trigger.IzakayaLockType LockType;

			// Token: 0x04000E11 RID: 3601
			[Token(Token = "0x4000E11")]
			[FieldOffset(Offset = "0x8")]
			public readonly SchedulerNode.Trigger.IzakayaMapping[] Mappings;

			// Token: 0x04000E12 RID: 3602
			[Token(Token = "0x4000E12")]
			[FieldOffset(Offset = "0x10")]
			public readonly IEnumerable<int> PartnerData;
		}

		// Token: 0x020002A4 RID: 676
		[Token(Token = "0x20002A4")]
		[Serializable]
		public struct Connection
		{
			// Token: 0x04000E13 RID: 3603
			[Token(Token = "0x4000E13")]
			[FieldOffset(Offset = "0x0")]
			public IzakayaSpot a;

			// Token: 0x04000E14 RID: 3604
			[Token(Token = "0x4000E14")]
			[FieldOffset(Offset = "0x8")]
			public IzakayaSpot b;

			// Token: 0x04000E15 RID: 3605
			[Token(Token = "0x4000E15")]
			[FieldOffset(Offset = "0x10")]
			public Image visual;
		}
	}
}

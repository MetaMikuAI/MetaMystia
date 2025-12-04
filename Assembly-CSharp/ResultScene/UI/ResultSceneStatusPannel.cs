using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace ResultScene.UI
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	[GenerateCleanupMethod]
	public class ResultSceneStatusPannel : UIPanel
	{
		// Token: 0x06000394 RID: 916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x575250", Offset = "0x573C50", VA = "0x180575250", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x575300", Offset = "0x573D00", VA = "0x180575300", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x575760", Offset = "0x574160", VA = "0x180575760")]
		private void ShowTrackedStatus()
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x575340", Offset = "0x573D40", VA = "0x180575340")]
		private void Paint(RectTransform field, IEnumerable<int> collection, Func<int, Sprite> getSpriteCallback, int offset, int paintFrames)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x5751D0", Offset = "0x573BD0", VA = "0x1805751D0")]
		private IEnumerator OnPaintEnd()
		{
			return null;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x576320", Offset = "0x574D20", VA = "0x180576320")]
		public void Type(TextMeshProUGUI text, string prependValue, string appendValue, int targetValue, float duration)
		{
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x575180", Offset = "0x573B80", VA = "0x180575180")]
		public static void DisposeWorkSceneData()
		{
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x574EA0", Offset = "0x5738A0", VA = "0x180574EA0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x5766C0", Offset = "0x5750C0", VA = "0x1805766C0")]
		public ResultSceneStatusPannel()
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x5764C0", Offset = "0x574EC0", VA = "0x1805764C0")]
		[CompilerGenerated]
		private void <ShowTrackedStatus>g__TypeObject|39_0(RectTransform field, IEnumerable<int> collection, Func<int, Sprite> getSpriteCallback, int offset)
		{
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x5764F0", Offset = "0x574EF0", VA = "0x1805764F0")]
		[CompilerGenerated]
		private void <ShowTrackedStatus>g__TypeText|39_1(TextMeshProUGUI textMesh, int targetValue, string prepend, string append)
		{
		}

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		private const int GAINED_OBJECTS_PAINT_FRAMES = 3;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		private const float DIGIT_TYPE_SPEED = 1f;

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[FieldOffset(Offset = "0x70")]
		public GameObject showedObjectParent;

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		[FieldOffset(Offset = "0x78")]
		public GameObject showedObjectParentWithNum;

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[FieldOffset(Offset = "0x80")]
		[Header("Audio")]
		public AudioClip printObject;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x40003B1")]
		[FieldOffset(Offset = "0x88")]
		[Header("Expences")]
		public TextMeshProUGUI bussinessExpences;

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		[FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI missionExpences;

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		[FieldOffset(Offset = "0x98")]
		public GameObject[] debtValuePairs;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI debtExpences;

		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject[] partnerValuePairs;

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		[FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI partnerExpences;

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		[FieldOffset(Offset = "0xB8")]
		[Header("Income")]
		public TextMeshProUGUI missionIncome;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		[FieldOffset(Offset = "0xC0")]
		public TextMeshProUGUI bussinessIncome;

		// Token: 0x040003B9 RID: 953
		[Token(Token = "0x40003B9")]
		[FieldOffset(Offset = "0xC8")]
		public TextMeshProUGUI fee;

		// Token: 0x040003BA RID: 954
		[Token(Token = "0x40003BA")]
		[FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI netProfit;

		// Token: 0x040003BB RID: 955
		[Token(Token = "0x40003BB")]
		[FieldOffset(Offset = "0xD8")]
		[Header("Performance")]
		public TextMeshProUGUI performanceCount;

		// Token: 0x040003BC RID: 956
		[Token(Token = "0x40003BC")]
		[FieldOffset(Offset = "0xE0")]
		public TextMeshProUGUI performanceSucceedCount;

		// Token: 0x040003BD RID: 957
		[Token(Token = "0x40003BD")]
		[FieldOffset(Offset = "0xE8")]
		public TextMeshProUGUI performanceFullComboCount;

		// Token: 0x040003BE RID: 958
		[Token(Token = "0x40003BE")]
		[FieldOffset(Offset = "0xF0")]
		[Header("Business Consumes")]
		public RectTransform bussinessFoodConsumes;

		// Token: 0x040003BF RID: 959
		[Token(Token = "0x40003BF")]
		[FieldOffset(Offset = "0xF8")]
		public RectTransform bussinessBeverageConsumes;

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x100")]
		[Header("Mission Consumes")]
		public RectTransform missionIngredientConsumes;

		// Token: 0x040003C1 RID: 961
		[Token(Token = "0x40003C1")]
		[FieldOffset(Offset = "0x108")]
		public RectTransform missionFoodConsumes;

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		[FieldOffset(Offset = "0x110")]
		public RectTransform missionBeverageConsumes;

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x118")]
		[Header("Invalid Consumes")]
		public RectTransform invalidFoodConsumes;

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x120")]
		[Header("Stats")]
		public TextMeshProUGUI gainExp;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x128")]
		public TextMeshProUGUI maxCombo;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x130")]
		public TextMeshProUGUI maxPassion;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x138")]
		public TextMeshProUGUI visitors;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x140")]
		public TextMeshProUGUI normalGuestReception;

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x148")]
		public TextMeshProUGUI specialGuestReception;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x150")]
		public TextMeshProUGUI triggeredPositiveSkill;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x158")]
		public TextMeshProUGUI triggeredNegativeSkill;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x160")]
		public UIButtonSimple ClosePanelBtn;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		private const int ELEMENT_NUM_LINE = 11;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		private const int ELEMENT_NUM_COLUMN = 2;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x168")]
		private int m_CurrentPaintNum;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x170")]
		private readonly List<AutoScroller> m_AutoScrollers;
	}
}

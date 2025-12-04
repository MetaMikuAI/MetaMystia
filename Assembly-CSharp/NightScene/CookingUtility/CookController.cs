using System;
using System.Collections;
using System.Runtime.CompilerServices;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.UI.CookingUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.CookingUtility
{
	// Token: 0x0200068A RID: 1674
	[Token(Token = "0x200068A")]
	[GenerateCleanupMethod]
	public class CookController : MonoBehaviour
	{
		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06002749 RID: 10057 RVA: 0x0000E9A0 File Offset: 0x0000CBA0
		// (set) Token: 0x0600274A RID: 10058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057E")]
		public bool IsEmptyDesk
		{
			[Token(Token = "0x6002749")]
			[Address(RVA = "0x52F160", Offset = "0x52DB60", VA = "0x18052F160")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600274A")]
			[Address(RVA = "0x52F1D0", Offset = "0x52DBD0", VA = "0x18052F1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600274B RID: 10059 RVA: 0x0000E9B8 File Offset: 0x0000CBB8
		// (set) Token: 0x0600274C RID: 10060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057F")]
		public CookController.CookPhase Phase
		{
			[Token(Token = "0x600274B")]
			[Address(RVA = "0x477EF0", Offset = "0x4768F0", VA = "0x180477EF0")]
			[CompilerGenerated]
			get
			{
				return CookController.CookPhase.Idle;
			}
			[Token(Token = "0x600274C")]
			[Address(RVA = "0x4D2360", Offset = "0x4D0D60", VA = "0x1804D2360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600274E RID: 10062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000580")]
		public Cooker Cooker
		{
			[Token(Token = "0x600274D")]
			[Address(RVA = "0x426F70", Offset = "0x425970", VA = "0x180426F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600274E")]
			[Address(RVA = "0x52F180", Offset = "0x52DB80", VA = "0x18052F180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		// (set) Token: 0x06002750 RID: 10064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000581")]
		public float CookingProgress
		{
			[Token(Token = "0x600274F")]
			[Address(RVA = "0x477F30", Offset = "0x476930", VA = "0x180477F30")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002750")]
			[Address(RVA = "0x52EAD0", Offset = "0x52D4D0", VA = "0x18052EAD0")]
			private set
			{
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06002751 RID: 10065 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002752 RID: 10066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000582")]
		public Recipe[] ObtainedRecipes
		{
			[Token(Token = "0x6002751")]
			[Address(RVA = "0x4BE490", Offset = "0x4BCE90", VA = "0x1804BE490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002752")]
			[Address(RVA = "0x4BE690", Offset = "0x4BD090", VA = "0x1804BE690")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06002753 RID: 10067 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002754 RID: 10068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000583")]
		public Recipe[] UnObtainedRecipes
		{
			[Token(Token = "0x6002753")]
			[Address(RVA = "0x48B890", Offset = "0x48A290", VA = "0x18048B890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002754")]
			[Address(RVA = "0x4D2550", Offset = "0x4D0F50", VA = "0x1804D2550")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06002755 RID: 10069 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002756 RID: 10070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000584")]
		public Recipe[] ShownRecipes
		{
			[Token(Token = "0x6002755")]
			[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002756")]
			[Address(RVA = "0x45ABC0", Offset = "0x4595C0", VA = "0x18045ABC0")]
			set
			{
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06002757 RID: 10071 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002758 RID: 10072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000585")]
		public Sellable Result
		{
			[Token(Token = "0x6002757")]
			[Address(RVA = "0x428D60", Offset = "0x427760", VA = "0x180428D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002758")]
			[Address(RVA = "0x4D2530", Offset = "0x4D0F30", VA = "0x1804D2530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06002759 RID: 10073 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600275A RID: 10074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000586")]
		public Sellable LastResult
		{
			[Token(Token = "0x6002759")]
			[Address(RVA = "0x48A8D0", Offset = "0x4892D0", VA = "0x18048A8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600275A")]
			[Address(RVA = "0x48AC50", Offset = "0x489650", VA = "0x18048AC50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x0600275B RID: 10075 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600275C RID: 10076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000587")]
		public Recipe ChosenRecipe
		{
			[Token(Token = "0x600275B")]
			[Address(RVA = "0x48A680", Offset = "0x489080", VA = "0x18048A680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600275C")]
			[Address(RVA = "0x4D24D0", Offset = "0x4D0ED0", VA = "0x1804D24D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x0600275D RID: 10077 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		// (set) Token: 0x0600275E RID: 10078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000588")]
		public float CookControllerWorkTime
		{
			[Token(Token = "0x600275D")]
			[Address(RVA = "0x52F0C0", Offset = "0x52DAC0", VA = "0x18052F0C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600275E")]
			[Address(RVA = "0x52F170", Offset = "0x52DB70", VA = "0x18052F170")]
			set
			{
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x0600275F RID: 10079 RVA: 0x0000EA00 File Offset: 0x0000CC00
		[Token(Token = "0x17000589")]
		public bool CookingAllowInterrupt
		{
			[Token(Token = "0x600275F")]
			[Address(RVA = "0x418FE0", Offset = "0x4179E0", VA = "0x180418FE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x0000EA18 File Offset: 0x0000CC18
		// (set) Token: 0x06002761 RID: 10081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058A")]
		public Vector3Int GridPosition
		{
			[Token(Token = "0x6002760")]
			[Address(RVA = "0x52F140", Offset = "0x52DB40", VA = "0x18052F140")]
			[CompilerGenerated]
			get
			{
				return default(Vector3Int);
			}
			[Token(Token = "0x6002761")]
			[Address(RVA = "0x52F1B0", Offset = "0x52DBB0", VA = "0x18052F1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x0000EA30 File Offset: 0x0000CC30
		// (set) Token: 0x06002763 RID: 10083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700058B")]
		public int GridIndex
		{
			[Token(Token = "0x6002762")]
			[Address(RVA = "0x440430", Offset = "0x43EE30", VA = "0x180440430")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002763")]
			[Address(RVA = "0x52F1A0", Offset = "0x52DBA0", VA = "0x18052F1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002764")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002765")]
		[Address(RVA = "0x52E280", Offset = "0x52CC80", VA = "0x18052E280")]
		public void Initialize(Cooker cooker, CookAnimator visual, Vector3Int gridPosition, int gridIndex)
		{
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002766")]
		[Address(RVA = "0x52E150", Offset = "0x52CB50", VA = "0x18052E150")]
		public void Initialize(CookAnimator visual, Vector3Int gridPosition, int gridIndex)
		{
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002767")]
		[Address(RVA = "0x52E810", Offset = "0x52D210", VA = "0x18052E810")]
		public void SetCook(Sellable thisResult, Recipe recipe, bool thisCouldReturnIngredients)
		{
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x0000EA48 File Offset: 0x0000CC48
		[Token(Token = "0x6002768")]
		[Address(RVA = "0x52DFD0", Offset = "0x52C9D0", VA = "0x18052DFD0")]
		public float GetTrueCookingTime(Sellable output, Recipe recipe, bool userType = true, bool usePlayerLevelProperty = true, bool useExtraCookTimeModifier = true)
		{
			return 0f;
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002769")]
		[Address(RVA = "0x52F020", Offset = "0x52DA20", VA = "0x18052F020")]
		private void UpdateCookControllerWorkTime(float workTime)
		{
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600276A")]
		[Address(RVA = "0x52DF10", Offset = "0x52C910", VA = "0x18052DF10")]
		public Sellable GetFinalFood(Sellable result, out bool isRequestedFood)
		{
			return null;
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600276B RID: 10091 RVA: 0x0000EA60 File Offset: 0x0000CC60
		[Token(Token = "0x1700058C")]
		public bool CouldCookerOpen
		{
			[Token(Token = "0x600276B")]
			[Address(RVA = "0x52F0D0", Offset = "0x52DAD0", VA = "0x18052F0D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600276C RID: 10092 RVA: 0x0000EA78 File Offset: 0x0000CC78
		[Token(Token = "0x1700058D")]
		public bool CanCookerOpenByPartner
		{
			[Token(Token = "0x600276C")]
			[Address(RVA = "0x52F090", Offset = "0x52DA90", VA = "0x18052F090")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276D")]
		[Address(RVA = "0x52EC40", Offset = "0x52D640", VA = "0x18052EC40")]
		public void StartCookCountDown(float qteScore, bool allowInterrupt = false)
		{
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276E")]
		[Address(RVA = "0x52EB00", Offset = "0x52D500", VA = "0x18052EB00")]
		public void ShowCookingVisual(Sprite outputIcon)
		{
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276F")]
		[Address(RVA = "0x52EAD0", Offset = "0x52D4D0", VA = "0x18052EAD0")]
		public void SetCookerProgressExtern(float overrideProgress)
		{
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x52E620", Offset = "0x52D020", VA = "0x18052E620")]
		public void InterruptCook()
		{
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x52D3A0", Offset = "0x52BDA0", VA = "0x18052D3A0")]
		public void FinishCooking()
		{
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002772")]
		[Address(RVA = "0x52EF50", Offset = "0x52D950", VA = "0x18052EF50")]
		public void Store(Sellable value)
		{
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002773")]
		[Address(RVA = "0x52D190", Offset = "0x52BB90", VA = "0x18052D190")]
		public void Extract(Action<Sellable> targetAssignmentCallBack)
		{
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002774")]
		[Address(RVA = "0x52CDA0", Offset = "0x52B7A0", VA = "0x18052CDA0")]
		public void AfterPlayerExtract()
		{
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002775")]
		[Address(RVA = "0x52F060", Offset = "0x52DA60", VA = "0x18052F060")]
		public void WhenPlayerTryExtractWithFullTray()
		{
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002776")]
		[Address(RVA = "0x52D0B0", Offset = "0x52BAB0", VA = "0x18052D0B0")]
		public void CloseCookingVisual()
		{
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002777")]
		[Address(RVA = "0x52E780", Offset = "0x52D180", VA = "0x18052E780")]
		private IEnumerator OnCooking(float cookingDuration)
		{
			return null;
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x0000EA90 File Offset: 0x0000CC90
		[Token(Token = "0x6002778")]
		[Address(RVA = "0x52EBC0", Offset = "0x52D5C0", VA = "0x18052EBC0")]
		public float SolveQteMultiplier()
		{
			return 0f;
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		[Token(Token = "0x6002779")]
		[Address(RVA = "0x52CDD0", Offset = "0x52B7D0", VA = "0x18052CDD0")]
		private bool CheckFailCook(Sellable food, float qteScore)
		{
			return default(bool);
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277A")]
		[Address(RVA = "0x52CF70", Offset = "0x52B970", VA = "0x18052CF70", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277B")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public CookController()
		{
		}

		// Token: 0x040023E1 RID: 9185
		[Token(Token = "0x40023E1")]
		[FieldOffset(Offset = "0x18")]
		public CookAnimator visual;

		// Token: 0x040023E2 RID: 9186
		[Token(Token = "0x40023E2")]
		[FieldOffset(Offset = "0x20")]
		public CookingStatusModule onStatus;

		// Token: 0x040023E3 RID: 9187
		[Token(Token = "0x40023E3")]
		[FieldOffset(Offset = "0x28")]
		public AudioClip start;

		// Token: 0x040023E4 RID: 9188
		[Token(Token = "0x40023E4")]
		[FieldOffset(Offset = "0x30")]
		public SpriteRenderer sellableShadow;

		// Token: 0x040023E5 RID: 9189
		[Token(Token = "0x40023E5")]
		[FieldOffset(Offset = "0x38")]
		public SpriteRenderer steam;

		// Token: 0x040023E6 RID: 9190
		[Token(Token = "0x40023E6")]
		[FieldOffset(Offset = "0x40")]
		public SpriteRenderer result;

		// Token: 0x040023E7 RID: 9191
		[Token(Token = "0x40023E7")]
		[FieldOffset(Offset = "0x48")]
		public SpriteRenderer resultVisual;

		// Token: 0x040023E8 RID: 9192
		[Token(Token = "0x40023E8")]
		[FieldOffset(Offset = "0x50")]
		public Color normalColor;

		// Token: 0x040023E9 RID: 9193
		[Token(Token = "0x40023E9")]
		[FieldOffset(Offset = "0x60")]
		public Color failedColor;

		// Token: 0x040023EA RID: 9194
		[Token(Token = "0x40023EA")]
		[FieldOffset(Offset = "0x70")]
		private float cookingProgress;

		// Token: 0x040023EB RID: 9195
		[Token(Token = "0x40023EB")]
		[FieldOffset(Offset = "0x74")]
		private float cookTime;

		// Token: 0x040023EC RID: 9196
		[Token(Token = "0x40023EC")]
		[FieldOffset(Offset = "0x78")]
		private bool couldReturnIngredients;

		// Token: 0x040023ED RID: 9197
		[Token(Token = "0x40023ED")]
		[FieldOffset(Offset = "0x80")]
		private Coroutine onCookingCoroutine;

		// Token: 0x040023EE RID: 9198
		[Token(Token = "0x40023EE")]
		[FieldOffset(Offset = "0x88")]
		private float qteScore;

		// Token: 0x040023EF RID: 9199
		[Token(Token = "0x40023EF")]
		[FieldOffset(Offset = "0x90")]
		private Recipe[] shownRecipes;

		// Token: 0x040023FA RID: 9210
		[Token(Token = "0x40023FA")]
		[FieldOffset(Offset = "0xE0")]
		private float cookControllerWorkTime;

		// Token: 0x040023FB RID: 9211
		[Token(Token = "0x40023FB")]
		[FieldOffset(Offset = "0xE4")]
		private float startCookTime;

		// Token: 0x040023FC RID: 9212
		[Token(Token = "0x40023FC")]
		[FieldOffset(Offset = "0xE8")]
		private bool thisCookAllowInterrupt;

		// Token: 0x0200068B RID: 1675
		[Token(Token = "0x200068B")]
		public enum CookPhase
		{
			// Token: 0x040023FE RID: 9214
			[Token(Token = "0x40023FE")]
			Idle,
			// Token: 0x040023FF RID: 9215
			[Token(Token = "0x40023FF")]
			Loaded,
			// Token: 0x04002400 RID: 9216
			[Token(Token = "0x4002400")]
			Cooking,
			// Token: 0x04002401 RID: 9217
			[Token(Token = "0x4002401")]
			Finished
		}
	}
}

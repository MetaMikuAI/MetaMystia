using System;
using System.Runtime.CompilerServices;
using Common.UI;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000433 RID: 1075
	[Token(Token = "0x2000433")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeTutorialPanel : UIPanelParamOpen<bool>
	{
		// Token: 0x060017C7 RID: 6087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C7")]
		[Address(RVA = "0x475830", Offset = "0x474230", VA = "0x180475830", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017C8")]
		[Address(RVA = "0x475B30", Offset = "0x474530", VA = "0x180475B30", Slot = "32")]
		protected override void OnPanelOpen(bool isFirstTutorial)
		{
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x060017C9 RID: 6089 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060017CA RID: 6090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B9")]
		public static Action CleanRogueTutorialCallback
		{
			[Token(Token = "0x60017C9")]
			[Address(RVA = "0x476100", Offset = "0x474B00", VA = "0x180476100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60017CA")]
			[Address(RVA = "0x476140", Offset = "0x474B40", VA = "0x180476140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CB")]
		[Address(RVA = "0x475DC0", Offset = "0x4747C0", VA = "0x180475DC0")]
		public static void TriggerCleanRogueTutorialCallback()
		{
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CC")]
		[Address(RVA = "0x475800", Offset = "0x474200", VA = "0x180475800", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x475520", Offset = "0x473F20", VA = "0x180475520")]
		private void CleanRogueTutorialPanelHandle()
		{
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x475C90", Offset = "0x474690", VA = "0x180475C90")]
		private void OpenBaseRuleImage()
		{
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x475D00", Offset = "0x474700", VA = "0x180475D00")]
		private void OpenKourindouImage()
		{
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D0")]
		[Address(RVA = "0x475CC0", Offset = "0x4746C0", VA = "0x180475CC0")]
		private void OpenCardImage()
		{
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D1")]
		[Address(RVA = "0x475D40", Offset = "0x474740", VA = "0x180475D40")]
		private void OpenMapImage()
		{
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x475D80", Offset = "0x474780", VA = "0x180475D80")]
		private void OpenMoreImage()
		{
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00008DC0 File Offset: 0x00006FC0
		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x475F30", Offset = "0x474930", VA = "0x180475F30")]
		private UniTask TryLoadOrOpenTargetTutorial(DLC5_RogueLikeTutorialPanel.TutorialType tutorialType)
		{
			return default(UniTask);
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00008DD8 File Offset: 0x00006FD8
		[Token(Token = "0x60017D4")]
		[Address(RVA = "0x475E50", Offset = "0x474850", VA = "0x180475E50")]
		private UniTask TryLoadOrOpenTargetTutorialInternal(IGameObjectAssetHandle<ImageDisplayerPannel> handle, AssetReference baseReference)
		{
			return default(UniTask);
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x475620", Offset = "0x474020", VA = "0x180475620", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x4760C0", Offset = "0x474AC0", VA = "0x1804760C0")]
		public DLC5_RogueLikeTutorialPanel()
		{
		}

		// Token: 0x0400164F RID: 5711
		[Token(Token = "0x400164F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIButtonSimple m_Button_BaseRule;

		// Token: 0x04001650 RID: 5712
		[Token(Token = "0x4001650")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIButtonSimple m_Button_AboutKourindou;

		// Token: 0x04001651 RID: 5713
		[Token(Token = "0x4001651")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIButtonSimple m_Button_AboutCard;

		// Token: 0x04001652 RID: 5714
		[Token(Token = "0x4001652")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIButtonSimple m_Button_AboutMap;

		// Token: 0x04001653 RID: 5715
		[Token(Token = "0x4001653")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIButtonSimple m_Button_MoreRules;

		// Token: 0x04001654 RID: 5716
		[Token(Token = "0x4001654")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIButtonSimple m_Button_End;

		// Token: 0x04001655 RID: 5717
		[Token(Token = "0x4001655")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIButtonSimple m_Button_Bye;

		// Token: 0x04001656 RID: 5718
		[Token(Token = "0x4001656")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private DialogPackage m_EndFirstTutorial;

		// Token: 0x04001657 RID: 5719
		[Token(Token = "0x4001657")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AssetReference m_BaseRuleImage;

		// Token: 0x04001658 RID: 5720
		[Token(Token = "0x4001658")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AssetReference m_KourindouImage;

		// Token: 0x04001659 RID: 5721
		[Token(Token = "0x4001659")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private AssetReference m_CardImage;

		// Token: 0x0400165A RID: 5722
		[Token(Token = "0x400165A")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private AssetReference m_MapImage;

		// Token: 0x0400165B RID: 5723
		[Token(Token = "0x400165B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private AssetReference m_MoreRuleImage;

		// Token: 0x0400165C RID: 5724
		[Token(Token = "0x400165C")]
		[FieldOffset(Offset = "0xE0")]
		private IGameObjectAssetHandle<ImageDisplayerPannel> m_BaseRuleImageHandle;

		// Token: 0x0400165D RID: 5725
		[Token(Token = "0x400165D")]
		[FieldOffset(Offset = "0xE8")]
		private IGameObjectAssetHandle<ImageDisplayerPannel> m_KourindouImageHandle;

		// Token: 0x0400165E RID: 5726
		[Token(Token = "0x400165E")]
		[FieldOffset(Offset = "0xF0")]
		private IGameObjectAssetHandle<ImageDisplayerPannel> m_CardImageHandle;

		// Token: 0x0400165F RID: 5727
		[Token(Token = "0x400165F")]
		[FieldOffset(Offset = "0xF8")]
		private IGameObjectAssetHandle<ImageDisplayerPannel> m_MapImageHandle;

		// Token: 0x04001660 RID: 5728
		[Token(Token = "0x4001660")]
		[FieldOffset(Offset = "0x100")]
		private IGameObjectAssetHandle<ImageDisplayerPannel> m_MoreRuleImageHandle;

		// Token: 0x02000434 RID: 1076
		[Token(Token = "0x2000434")]
		private enum TutorialType
		{
			// Token: 0x04001663 RID: 5731
			[Token(Token = "0x4001663")]
			BaseRuleImage,
			// Token: 0x04001664 RID: 5732
			[Token(Token = "0x4001664")]
			KourindouImage,
			// Token: 0x04001665 RID: 5733
			[Token(Token = "0x4001665")]
			CardImage,
			// Token: 0x04001666 RID: 5734
			[Token(Token = "0x4001666")]
			MapImage,
			// Token: 0x04001667 RID: 5735
			[Token(Token = "0x4001667")]
			MoreRuleImage
		}
	}
}

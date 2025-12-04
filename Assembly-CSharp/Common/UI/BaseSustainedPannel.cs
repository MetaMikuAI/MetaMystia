using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.UI.EscapeUtility;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace Common.UI
{
	// Token: 0x02000E21 RID: 3617
	[Token(Token = "0x2000E21")]
	[GenerateCleanupMethod]
	public abstract class BaseSustainedPannel : UIPanelExtern
	{
		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x0600548D RID: 21645 RVA: 0x0001E438 File Offset: 0x0001C638
		[Token(Token = "0x17000BF2")]
		protected virtual AdpUIPanelManager.PanelOpenMode PanelOpenMode
		{
			[Token(Token = "0x600548D")]
			[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "33")]
			get
			{
				return AdpUIPanelManager.PanelOpenMode.DisableCurrentUI;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x0600548E RID: 21646 RVA: 0x0001E450 File Offset: 0x0001C650
		[Token(Token = "0x17000BF3")]
		public override bool MutePanelOpenAudio
		{
			[Token(Token = "0x600548E")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x0600548F RID: 21647 RVA: 0x0001E468 File Offset: 0x0001C668
		[Token(Token = "0x17000BF4")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x600548F")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06005490 RID: 21648 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005491 RID: 21649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000035")]
		[CleanupIgnore]
		public static event Action OnBasePannelOnTop
		{
			[Token(Token = "0x6005490")]
			[Address(RVA = "0x832B30", Offset = "0x831530", VA = "0x180832B30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005491")]
			[Address(RVA = "0x832BF0", Offset = "0x8315F0", VA = "0x180832BF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06005492 RID: 21650 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005493 RID: 21651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BF5")]
		public Action<bool> OnBasePanelProcessedCallback
		{
			[Token(Token = "0x6005492")]
			[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005493")]
			[Address(RVA = "0x45ABC0", Offset = "0x4595C0", VA = "0x18045ABC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06005494 RID: 21652 RVA: 0x0001E480 File Offset: 0x0001C680
		// (set) Token: 0x06005495 RID: 21653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BF6")]
		public bool EnablePlayerOpenAnyPannel
		{
			[Token(Token = "0x6005494")]
			[Address(RVA = "0x608690", Offset = "0x607090", VA = "0x180608690")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005495")]
			[Address(RVA = "0x832CB0", Offset = "0x8316B0", VA = "0x180832CB0")]
			set
			{
			}
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x0001E498 File Offset: 0x0001C698
		[Token(Token = "0x6005496")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public sealed override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005497")]
		[Address(RVA = "0x8326F0", Offset = "0x8310F0", VA = "0x1808326F0", Slot = "22")]
		protected sealed override void OnPanelInitialize()
		{
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005498")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "34")]
		protected virtual void OnPannelPostInitialize()
		{
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005499")]
		[Address(RVA = "0x8326B0", Offset = "0x8310B0", VA = "0x1808326B0", Slot = "24")]
		protected sealed override void OnPanelDestroyed()
		{
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549A")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "35")]
		protected virtual void OnPrePanelDestroyed()
		{
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549B")]
		[Address(RVA = "0x832600", Offset = "0x831000", VA = "0x180832600", Slot = "30")]
		protected override void OnCurrentPanelLayerChanged(IEnumerable<UIPanelBaseImpl> currentLayer)
		{
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549C")]
		[Address(RVA = "0x832480", Offset = "0x830E80", VA = "0x180832480")]
		protected void CallAndCleanOnTopCallback()
		{
		}

		// Token: 0x0600549D RID: 21661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549D")]
		[Address(RVA = "0x832A60", Offset = "0x831460", VA = "0x180832A60")]
		public void TryCloseActivePannel()
		{
		}

		// Token: 0x0600549E RID: 21662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600549E")]
		[Address(RVA = "0x832560", Offset = "0x830F60", VA = "0x180832560")]
		public void CloseActivePannel()
		{
		}

		// Token: 0x0600549F RID: 21663 RVA: 0x0001E4B0 File Offset: 0x0001C6B0
		[Token(Token = "0x600549F")]
		protected bool PreProcessOpen<T>(T parent, out T pannelInstance, ref Action OnPanelCloseCallback, bool alwaysPersistent = false, bool needFreezeTime = true) where T : UIPanelBaseImpl, IExternalPanel
		{
			return default(bool);
		}

		// Token: 0x060054A0 RID: 21664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054A0")]
		protected virtual void OnPanelWillOpen<T>(T panelParent) where T : UIPanelBaseImpl, IExternalPanel
		{
		}

		// Token: 0x060054A1 RID: 21665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054A1")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "37")]
		protected virtual void OnPanelClosed()
		{
		}

		// Token: 0x060054A2 RID: 21666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054A2")]
		[Address(RVA = "0x832A00", Offset = "0x831400", VA = "0x180832A00")]
		public void OpenEscPanelParameterless()
		{
		}

		// Token: 0x060054A3 RID: 21667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054A3")]
		[Address(RVA = "0x832A20", Offset = "0x831420", VA = "0x180832A20")]
		public void OpenEscPanel([MetadataOffset(Offset = "0x6D8012")] [Optional] EscMainPannel.GoToSpecificType? overrideOpenType, [Optional] AdpUIPanelManager.PanelOpenMode? overrideOpenMode, [Optional] Action onPanelCloseCallback, [Optional] Action afterEscPanelCloseByLoadOrExitCallback, bool needFreezeTime = true)
		{
		}

		// Token: 0x060054A4 RID: 21668 RVA: 0x0001E4C8 File Offset: 0x0001C6C8
		[Token(Token = "0x60054A4")]
		[Address(RVA = "0x8329E0", Offset = "0x8313E0", VA = "0x1808329E0")]
		public UniTaskVoid OpenEscPanelAsync([MetadataOffset(Offset = "0x6D8014")] [Optional] EscMainPannel.GoToSpecificType? overrideOpenType, [Optional] AdpUIPanelManager.PanelOpenMode? overrideOpenMode, [Optional] Action onPanelCloseCallback, [Optional] Action afterEscPanelCloseByLoadOrExitCallback, bool needFreezeTime = true)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060054A5 RID: 21669 RVA: 0x0001E4E0 File Offset: 0x0001C6E0
		[Token(Token = "0x60054A5")]
		[Address(RVA = "0x8328E0", Offset = "0x8312E0", VA = "0x1808328E0")]
		private UniTaskVoid OpenEscPanelAsyncInternal([MetadataOffset(Offset = "0x6D8016")] [Optional] EscMainPannel.GoToSpecificType? overrideOpenType, [Optional] AdpUIPanelManager.PanelOpenMode? overrideOpenMode, [Optional] Action onPanelCloseCallback, [Optional] Action afterEscPanelCloseByLoadOrExitCallback, bool needFreezeTime = true)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060054A6 RID: 21670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054A6")]
		[Address(RVA = "0x832830", Offset = "0x831230", VA = "0x180832830", Slot = "21")]
		protected sealed override void OnPanelOpen()
		{
		}

		// Token: 0x060054A7 RID: 21671
		[Token(Token = "0x60054A7")]
		protected abstract void OnPannelPostOpen();

		// Token: 0x060054A8 RID: 21672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054A8")]
		[Address(RVA = "0x8324F0", Offset = "0x830EF0", VA = "0x1808324F0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060054A9 RID: 21673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054A9")]
		[Address(RVA = "0x410B60", Offset = "0x40F560", VA = "0x180410B60")]
		protected BaseSustainedPannel()
		{
		}

		// Token: 0x04004F8D RID: 20365
		[Token(Token = "0x4004F8D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UIButtonSimple EscapePannelBtn;

		// Token: 0x04004F8E RID: 20366
		[Token(Token = "0x4004F8E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UIPanelBaseImpl m_CurrentPanelParent;

		// Token: 0x04004F8F RID: 20367
		[Token(Token = "0x4004F8F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Action m_LastPannelCloseHandle;

		// Token: 0x04004F90 RID: 20368
		[Token(Token = "0x4004F90")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_EnablePlayerOpenAnyPannel;
	}
}

using System;
using System.Runtime.InteropServices;
using Common.UI.NoteBookUtility;
using Common.UI.StorageUtility;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace Common.UI
{
	// Token: 0x02000E4C RID: 3660
	[Token(Token = "0x2000E4C")]
	[GenerateCleanupMethod]
	public abstract class GeneralSustainedPannel : BaseSustainedPannel
	{
		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06005594 RID: 21908 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005595 RID: 21909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C02")]
		public static GeneralSustainedPannel CurrentActiveSustainedPannel
		{
			[Token(Token = "0x6005594")]
			[Address(RVA = "0x851580", Offset = "0x84FF80", VA = "0x180851580")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005595")]
			[Address(RVA = "0x851650", Offset = "0x850050", VA = "0x180851650")]
			private set
			{
			}
		}

		// Token: 0x06005596 RID: 21910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005596")]
		[Address(RVA = "0x850A60", Offset = "0x84F460", VA = "0x180850A60", Slot = "34")]
		protected override void OnPannelPostInitialize()
		{
		}

		// Token: 0x06005597 RID: 21911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005597")]
		[Address(RVA = "0x850C80", Offset = "0x84F680", VA = "0x180850C80", Slot = "38")]
		protected override void OnPannelPostOpen()
		{
		}

		// Token: 0x06005598 RID: 21912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005598")]
		[Address(RVA = "0x8508A0", Offset = "0x84F2A0", VA = "0x1808508A0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005599 RID: 21913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005599")]
		[Address(RVA = "0x850F90", Offset = "0x84F990", VA = "0x180850F90")]
		private void OnSustainedPannelStatusChanged(bool _)
		{
		}

		// Token: 0x0600559A RID: 21914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559A")]
		[Address(RVA = "0x850E80", Offset = "0x84F880", VA = "0x180850E80")]
		private void OnSustainedPannelStatusChanged()
		{
		}

		// Token: 0x0600559B RID: 21915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559B")]
		[Address(RVA = "0x850FA0", Offset = "0x84F9A0", VA = "0x180850FA0")]
		public void OpenNoteBookPanelParameterless()
		{
		}

		// Token: 0x0600559C RID: 21916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559C")]
		[Address(RVA = "0x4416C0", Offset = "0x4400C0", VA = "0x1804416C0")]
		public void OpenStoragePanelParameterless()
		{
		}

		// Token: 0x0600559D RID: 21917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559D")]
		[Address(RVA = "0x8510D0", Offset = "0x84FAD0", VA = "0x1808510D0")]
		public void OpenNoteBookPannel([Optional] NoteBookMainPannel.GoToSpecificType? overrideOpenType, [Optional] AdpUIPanelManager.PanelOpenMode? overrideOpenMode, [Optional] Action<UISubPanel<NoteBookMainPannel>> preOpenPannelCallback, [Optional] Action onPannelCloseCallback)
		{
		}

		// Token: 0x0600559E RID: 21918 RVA: 0x0001E738 File Offset: 0x0001C938
		[Token(Token = "0x600559E")]
		[Address(RVA = "0x850FD0", Offset = "0x84F9D0", VA = "0x180850FD0")]
		private UniTaskVoid OpenNoteBookPannelAsyncInternal([Optional] NoteBookMainPannel.GoToSpecificType? overrideOpenType, [Optional] AdpUIPanelManager.PanelOpenMode? overrideOpenMode, [Optional] Action<UISubPanel<NoteBookMainPannel>> preOpenPannelCallback, [Optional] Action onPannelCloseCallback)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x0600559F RID: 21919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600559F")]
		[Address(RVA = "0x8512C0", Offset = "0x84FCC0", VA = "0x1808512C0")]
		public void OpenStoragePannel([Optional] StorageMainPannel.GoToSpecificType? overrideOpenType, [Optional] AdpUIPanelManager.PanelOpenMode? overrideOpenMode, [Optional] Action onPannelCloseCallback)
		{
		}

		// Token: 0x060055A0 RID: 21920 RVA: 0x0001E750 File Offset: 0x0001C950
		[Token(Token = "0x60055A0")]
		[Address(RVA = "0x8511E0", Offset = "0x84FBE0", VA = "0x1808511E0")]
		private UniTaskVoid OpenStoragePannelAsyncInternal([Optional] StorageMainPannel.GoToSpecificType? overrideOpenType, [Optional] AdpUIPanelManager.PanelOpenMode? overrideOpenMode, [Optional] Action onPannelCloseCallback)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060055A1 RID: 21921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A1")]
		[Address(RVA = "0x8507C0", Offset = "0x84F1C0", VA = "0x1808507C0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060055A2 RID: 21922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A2")]
		[Address(RVA = "0x851570", Offset = "0x84FF70", VA = "0x180851570")]
		protected GeneralSustainedPannel()
		{
		}

		// Token: 0x0400505E RID: 20574
		[Token(Token = "0x400505E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GeneralSustainedPannel m_CurrentActiveSustainedPannel;

		// Token: 0x0400505F RID: 20575
		[Token(Token = "0x400505F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UIButtonSimple NoteBookPannelBtn;

		// Token: 0x04005060 RID: 20576
		[Token(Token = "0x4005060")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UIButtonSimple StoragePannelBtn;
	}
}

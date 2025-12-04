using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.UI;
using Common.UI.GlobalMap;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using DEYU.AssetHandleUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020002E1 RID: 737
	[Token(Token = "0x20002E1")]
	[GenerateCleanupMethod]
	public class DaySceneSustainedPannel : ExtendedSustainedPannel
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x00006930 File Offset: 0x00004B30
		[Token(Token = "0x17000197")]
		public override AdpUIPanelManager.RequestedInputMode RequestedInputMode
		{
			[Token(Token = "0x60010B2")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "17")]
			get
			{
				return AdpUIPanelManager.RequestedInputMode.Player;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000198")]
		public override string HoldActionMap
		{
			[Token(Token = "0x60010B3")]
			[Address(RVA = "0x92CE70", Offset = "0x92B870", VA = "0x18092CE70", Slot = "39")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000199")]
		public override string HoldActionName
		{
			[Token(Token = "0x60010B4")]
			[Address(RVA = "0x92CEA0", Offset = "0x92B8A0", VA = "0x18092CEA0", Slot = "40")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060010B5 RID: 4277 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060010B6 RID: 4278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000A")]
		public event Action OnPanelWillOpenCallback
		{
			[Token(Token = "0x60010B5")]
			[Address(RVA = "0x92CDC0", Offset = "0x92B7C0", VA = "0x18092CDC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60010B6")]
			[Address(RVA = "0x92CEB0", Offset = "0x92B8B0", VA = "0x18092CEB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B7")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "32")]
		protected override void OnExitExtern()
		{
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B8")]
		[Address(RVA = "0x92C6D0", Offset = "0x92B0D0", VA = "0x18092C6D0", Slot = "35")]
		protected override void OnPrePanelDestroyed()
		{
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010B9")]
		[Address(RVA = "0x92C420", Offset = "0x92AE20", VA = "0x18092C420", Slot = "34")]
		protected override void OnPannelPostInitialize()
		{
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010BA")]
		protected override void OnPanelWillOpen<T>(T panelParent)
		{
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0x92C3E0", Offset = "0x92ADE0", VA = "0x18092C3E0", Slot = "37")]
		protected override void OnPanelClosed()
		{
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x92CD60", Offset = "0x92B760", VA = "0x18092CD60")]
		private void UpdateMapBtnVisual()
		{
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x92CD30", Offset = "0x92B730", VA = "0x18092CD30")]
		private void UpdateFastForwardBtn()
		{
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00006948 File Offset: 0x00004B48
		[Token(Token = "0x60010BE")]
		[Address(RVA = "0x92C040", Offset = "0x92AA40", VA = "0x18092C040")]
		private bool CheckCanOpen()
		{
			return default(bool);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010BF")]
		[Address(RVA = "0x92C640", Offset = "0x92B040", VA = "0x18092C640", Slot = "38")]
		protected override void OnPannelPostOpen()
		{
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00006960 File Offset: 0x00004B60
		[Token(Token = "0x60010C0")]
		[Address(RVA = "0x92C1C0", Offset = "0x92ABC0", VA = "0x18092C1C0")]
		public UniTask LoadPanelAsync()
		{
			return default(UniTask);
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C1")]
		[Address(RVA = "0x92CC60", Offset = "0x92B660", VA = "0x18092CC60")]
		public void ReleasePanel()
		{
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C2")]
		[Address(RVA = "0x92C7C0", Offset = "0x92B1C0", VA = "0x18092C7C0")]
		public void OpenFastTravelPanelParameterless()
		{
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C3")]
		[Address(RVA = "0x92C870", Offset = "0x92B270", VA = "0x18092C870")]
		public void OpenFastTravelPannel(bool isYukari, [Optional] Predicate<IGuideMapSpot> getFirstToSelectNodeCallback, [Optional] Action onPannelCloseCallback)
		{
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C4")]
		[Address(RVA = "0x92C370", Offset = "0x92AD70", VA = "0x18092C370", Slot = "41")]
		public override void OnFastForwardSubmit()
		{
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C5")]
		[Address(RVA = "0x92C0F0", Offset = "0x92AAF0", VA = "0x18092C0F0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60010C6")]
		[Address(RVA = "0x92CDB0", Offset = "0x92B7B0", VA = "0x18092CDB0")]
		public DaySceneSustainedPannel()
		{
		}

		// Token: 0x04000F5D RID: 3933
		[Token(Token = "0x4000F5D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public UIButtonSimple MapBtn;

		// Token: 0x04000F5E RID: 3934
		[Token(Token = "0x4000F5E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AssetReferenceT<GameObject> DaySceneFastTravelPannel;

		// Token: 0x04000F5F RID: 3935
		[Token(Token = "0x4000F5F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public string[] disableMapEvents;

		// Token: 0x04000F60 RID: 3936
		[Token(Token = "0x4000F60")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Tips tipsPannel;

		// Token: 0x04000F61 RID: 3937
		[Token(Token = "0x4000F61")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Image m_MapBlocker;

		// Token: 0x04000F62 RID: 3938
		[Token(Token = "0x4000F62")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private IGameObjectAssetHandle<FastTravelPanel_New> m_LoadedFastTravelPanel;

		// Token: 0x04000F63 RID: 3939
		[Token(Token = "0x4000F63")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private FastTravelPanel_New m_DaySceneFastTravelPanelInstance;

		// Token: 0x04000F64 RID: 3940
		[Token(Token = "0x4000F64")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool? m_YukariToggle;
	}
}

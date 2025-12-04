using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Pool;

namespace NightScene.UI
{
	// Token: 0x020006AF RID: 1711
	[Token(Token = "0x20006AF")]
	[GenerateCleanupMethod]
	public class WorkSceneTrayPannel : UIPanelExtern
	{
		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		[Token(Token = "0x170005AD")]
		public override AdpUIPanelManager.RequestedInputMode RequestedInputMode
		{
			[Token(Token = "0x600286A")]
			[Address(RVA = "0x55DE40", Offset = "0x55C840", VA = "0x18055DE40", Slot = "17")]
			get
			{
				return AdpUIPanelManager.RequestedInputMode.Player;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x0000EDD8 File Offset: 0x0000CFD8
		// (set) Token: 0x0600286C RID: 10348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AE")]
		public WorkSceneTrayPannel.PannelOpenContext? OpenContext
		{
			[Token(Token = "0x600286B")]
			[Address(RVA = "0x55DE00", Offset = "0x55C800", VA = "0x18055DE00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600286C")]
			[Address(RVA = "0x55DED0", Offset = "0x55C8D0", VA = "0x18055DED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x0600286D RID: 10349 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600286E RID: 10350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AF")]
		public UILogicalGroupT<int> AllTrayElementGroup
		{
			[Token(Token = "0x600286D")]
			[Address(RVA = "0x449340", Offset = "0x447D40", VA = "0x180449340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600286E")]
			[Address(RVA = "0x48AA80", Offset = "0x489480", VA = "0x18048AA80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005B0")]
		public Transform EffectField
		{
			[Token(Token = "0x600286F")]
			[Address(RVA = "0x4402B0", Offset = "0x43ECB0", VA = "0x1804402B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		[Token(Token = "0x6002870")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002871")]
		[Address(RVA = "0x55D210", Offset = "0x55BC10", VA = "0x18055D210")]
		private void PlayClip()
		{
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002872")]
		[Address(RVA = "0x555710", Offset = "0x554110", VA = "0x180555710", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002873")]
		[Address(RVA = "0x55CE10", Offset = "0x55B810", VA = "0x18055CE10", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002874")]
		[Address(RVA = "0x55D200", Offset = "0x55BC00", VA = "0x18055D200", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002875")]
		[Address(RVA = "0x55C460", Offset = "0x55AE60", VA = "0x18055C460")]
		private void InitializeTray()
		{
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002876")]
		[Address(RVA = "0x55CA90", Offset = "0x55B490", VA = "0x18055CA90", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002877")]
		[Address(RVA = "0x55D3A0", Offset = "0x55BDA0", VA = "0x18055D3A0")]
		public void UpdateTrayVisual()
		{
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002878")]
		[Address(RVA = "0x55C410", Offset = "0x55AE10", VA = "0x18055C410")]
		public void ClearTargetTray(IEnumerable<int> targetId)
		{
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002879")]
		[Address(RVA = "0x55C320", Offset = "0x55AD20", VA = "0x18055C320", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600287A")]
		[Address(RVA = "0x55DD70", Offset = "0x55C770", VA = "0x18055DD70")]
		public WorkSceneTrayPannel()
		{
		}

		// Token: 0x040024CB RID: 9419
		[Token(Token = "0x40024CB")]
		private const int NORMAL_TRAY_LAYER = 4500;

		// Token: 0x040024CC RID: 9420
		[Token(Token = "0x40024CC")]
		private const int INTERACTABLE_TRAY_LAYER = 8000;

		// Token: 0x040024CD RID: 9421
		[Token(Token = "0x40024CD")]
		[FieldOffset(Offset = "0x70")]
		public GameObject TrayParent;

		// Token: 0x040024CE RID: 9422
		[Token(Token = "0x40024CE")]
		[FieldOffset(Offset = "0x78")]
		public Transform TrayField;

		// Token: 0x040024CF RID: 9423
		[Token(Token = "0x40024CF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform m_EffectField;

		// Token: 0x040024D0 RID: 9424
		[Token(Token = "0x40024D0")]
		[FieldOffset(Offset = "0x88")]
		public AudioClip OnTrayUpdateSFX;

		// Token: 0x040024D1 RID: 9425
		[Token(Token = "0x40024D1")]
		[FieldOffset(Offset = "0x90")]
		public Canvas TrayCanvas;

		// Token: 0x040024D2 RID: 9426
		[Token(Token = "0x40024D2")]
		[FieldOffset(Offset = "0x98")]
		[TupleElementNames(new string[] { "UI", "Button" })]
		private readonly List<ValueTuple<UIElementCluster, UIButtonSimple>> m_AllTrayInstances;

		// Token: 0x040024D3 RID: 9427
		[Token(Token = "0x40024D3")]
		[FieldOffset(Offset = "0xA0")]
		private ObjectPool<UIElementCluster> m_TrayInstancePool;

		// Token: 0x020006B0 RID: 1712
		[Token(Token = "0x20006B0")]
		public readonly struct PannelOpenContext
		{
			// Token: 0x0600287D RID: 10365 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600287D")]
			[Address(RVA = "0x54D4F0", Offset = "0x54BEF0", VA = "0x18054D4F0")]
			public PannelOpenContext(bool enableControl, Action<Sellable> onTrayElementSelect, Action<Sellable> onTrayElementSubmit, Action onNullTrayElementSelect, Action<MoveDirection, int> onTrayElementOverrideUpDownMove, Transform traySpecialEffectTransform, AdpUIPanelManager.RequestedInputMode inputMode = AdpUIPanelManager.RequestedInputMode.UI)
			{
			}

			// Token: 0x0600287E RID: 10366 RVA: 0x0000EE20 File Offset: 0x0000D020
			[Token(Token = "0x600287E")]
			[Address(RVA = "0x54D3E0", Offset = "0x54BDE0", VA = "0x18054D3E0")]
			public static WorkSceneTrayPannel.PannelOpenContext GetDefaultContext(AdpUIPanelManager.RequestedInputMode inputMode)
			{
				return default(WorkSceneTrayPannel.PannelOpenContext);
			}

			// Token: 0x040024D6 RID: 9430
			[Token(Token = "0x40024D6")]
			[FieldOffset(Offset = "0x0")]
			public readonly bool EnableControl;

			// Token: 0x040024D7 RID: 9431
			[Token(Token = "0x40024D7")]
			[FieldOffset(Offset = "0x4")]
			public readonly AdpUIPanelManager.RequestedInputMode InputMode;

			// Token: 0x040024D8 RID: 9432
			[Token(Token = "0x40024D8")]
			[FieldOffset(Offset = "0x8")]
			public readonly Action<Sellable> OnTrayElementSelect;

			// Token: 0x040024D9 RID: 9433
			[Token(Token = "0x40024D9")]
			[FieldOffset(Offset = "0x10")]
			public readonly Action<Sellable> OnTrayElementSubmit;

			// Token: 0x040024DA RID: 9434
			[Token(Token = "0x40024DA")]
			[FieldOffset(Offset = "0x18")]
			public readonly Action OnNullTrayElementSelect;

			// Token: 0x040024DB RID: 9435
			[Token(Token = "0x40024DB")]
			[FieldOffset(Offset = "0x20")]
			public readonly Action<MoveDirection, int> OnTrayElementOverrideUpDownMove;

			// Token: 0x040024DC RID: 9436
			[Token(Token = "0x40024DC")]
			[FieldOffset(Offset = "0x28")]
			public readonly Canvas TraySpecialEffectCanvas;
		}
	}
}

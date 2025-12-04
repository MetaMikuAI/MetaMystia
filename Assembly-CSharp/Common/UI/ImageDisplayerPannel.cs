using System;
using System.Collections;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace Common.UI
{
	// Token: 0x02000E62 RID: 3682
	[Token(Token = "0x2000E62")]
	[GenerateCleanupMethod]
	public class ImageDisplayerPannel : UIPanel
	{
		// Token: 0x0600560C RID: 22028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560C")]
		[Address(RVA = "0x851C50", Offset = "0x850650", VA = "0x180851C50", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600560D RID: 22029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560D")]
		[Address(RVA = "0x851FB0", Offset = "0x8509B0", VA = "0x180851FB0")]
		private void ScrollCallback(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x0600560E RID: 22030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560E")]
		[Address(RVA = "0x852010", Offset = "0x850A10", VA = "0x180852010")]
		private void Scroll(MoveDirection moveDirection)
		{
		}

		// Token: 0x0600560F RID: 22031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560F")]
		[Address(RVA = "0x851B20", Offset = "0x850520", VA = "0x180851B20")]
		private void ApplyOffset(Vector2 offset)
		{
		}

		// Token: 0x06005610 RID: 22032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005610")]
		[Address(RVA = "0x8522E0", Offset = "0x850CE0", VA = "0x1808522E0")]
		private IEnumerator UpdatePosition()
		{
			return null;
		}

		// Token: 0x06005611 RID: 22033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005611")]
		[Address(RVA = "0x851DA0", Offset = "0x8507A0", VA = "0x180851DA0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005612 RID: 22034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005612")]
		[Address(RVA = "0x851C20", Offset = "0x850620", VA = "0x180851C20", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005613 RID: 22035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005613")]
		[Address(RVA = "0x852180", Offset = "0x850B80", VA = "0x180852180")]
		private void SetProgress()
		{
		}

		// Token: 0x06005614 RID: 22036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005614")]
		[Address(RVA = "0x851BC0", Offset = "0x8505C0", VA = "0x180851BC0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005615 RID: 22037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005615")]
		[Address(RVA = "0x852360", Offset = "0x850D60", VA = "0x180852360")]
		public ImageDisplayerPannel()
		{
		}

		// Token: 0x040050D1 RID: 20689
		[Token(Token = "0x40050D1")]
		private const float MOVESPEED = 20f;

		// Token: 0x040050D2 RID: 20690
		[Token(Token = "0x40050D2")]
		private const float SNAPDURATION = 0.1f;

		// Token: 0x040050D3 RID: 20691
		[Token(Token = "0x40050D3")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform movablePannel;

		// Token: 0x040050D4 RID: 20692
		[Token(Token = "0x40050D4")]
		[FieldOffset(Offset = "0x78")]
		public Vector2 navigationRangeMin;

		// Token: 0x040050D5 RID: 20693
		[Token(Token = "0x40050D5")]
		[FieldOffset(Offset = "0x80")]
		public float areaHeight;

		// Token: 0x040050D6 RID: 20694
		[Token(Token = "0x40050D6")]
		[FieldOffset(Offset = "0x88")]
		private Coroutine m_ActiveCoroutine;

		// Token: 0x040050D7 RID: 20695
		[Token(Token = "0x40050D7")]
		[FieldOffset(Offset = "0x90")]
		public bool forceAlignTop;

		// Token: 0x040050D8 RID: 20696
		[Token(Token = "0x40050D8")]
		[FieldOffset(Offset = "0x98")]
		[CanBeNull]
		public AdpProgressIndicatorComponent progressIndicator;

		// Token: 0x040050D9 RID: 20697
		[Token(Token = "0x40050D9")]
		[FieldOffset(Offset = "0xA0")]
		private Vector2 targetPosition;

		// Token: 0x040050DA RID: 20698
		[Token(Token = "0x40050DA")]
		[FieldOffset(Offset = "0xA8")]
		private Vector2 velocity;

		// Token: 0x040050DB RID: 20699
		[Token(Token = "0x40050DB")]
		[FieldOffset(Offset = "0xB0")]
		private Vector2 currentNavigationMin;

		// Token: 0x040050DC RID: 20700
		[Token(Token = "0x40050DC")]
		[FieldOffset(Offset = "0xB8")]
		private Vector2 currentNavigationMax;
	}
}

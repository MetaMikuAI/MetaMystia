using System;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Night.BossBattle.DLC5_MizuchiBossBattle
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	[GenerateCleanupMethod]
	public class DLC5_MoonEyeControllerPanel : UIPanelParam<DLC5_MoonEyeControllerPanel.OpenContext, float>
	{
		// Token: 0x06000807 RID: 2055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x826CB0", Offset = "0x8256B0", VA = "0x180826CB0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x826DD0", Offset = "0x8257D0", VA = "0x180826DD0", Slot = "32")]
		protected override void OnPanelOpen(DLC5_MoonEyeControllerPanel.OpenContext openParam)
		{
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x826B10", Offset = "0x825510", VA = "0x180826B10", Slot = "33")]
		protected override void OnPanelClose(float closeParam)
		{
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x8271C0", Offset = "0x825BC0", VA = "0x1808271C0")]
		private void Update()
		{
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x827190", Offset = "0x825B90", VA = "0x180827190")]
		private void TryClose(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x8269A0", Offset = "0x8253A0", VA = "0x1808269A0")]
		private void MoveMirror(InputAction.CallbackContext x)
		{
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x826940", Offset = "0x825340", VA = "0x180826940")]
		private void CancelInput(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x827080", Offset = "0x825A80", VA = "0x180827080")]
		private void SetMirrorPosition(Vector2 targetPosition)
		{
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x4754F0", Offset = "0x473EF0", VA = "0x1804754F0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x827430", Offset = "0x825E30", VA = "0x180827430")]
		public DLC5_MoonEyeControllerPanel()
		{
		}

		// Token: 0x0400074F RID: 1871
		[Token(Token = "0x400074F")]
		[FieldOffset(Offset = "0xD0")]
		private bool canMove;

		// Token: 0x04000750 RID: 1872
		[Token(Token = "0x4000750")]
		[FieldOffset(Offset = "0xD4")]
		private float remainingAnimationTime;

		// Token: 0x04000751 RID: 1873
		[Token(Token = "0x4000751")]
		[FieldOffset(Offset = "0xD8")]
		private float remainingAnimationEndTime;

		// Token: 0x04000752 RID: 1874
		[Token(Token = "0x4000752")]
		[FieldOffset(Offset = "0xDC")]
		private float remainingCouldUseTime;

		// Token: 0x04000753 RID: 1875
		[Token(Token = "0x4000753")]
		[FieldOffset(Offset = "0xE0")]
		private Vector2 moveDirection;

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0xE8")]
		private bool hasFinded;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0xE9")]
		private bool isClosing;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0xEA")]
		private bool isClosed;

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0xF0")]
		private DLC5_MoonEyeControllerPanel.OpenContext openContext;

		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x148")]
		private float realRemainingCouldUseTime;

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		private const float INPUT_CUTOFF = 0.2f;

		// Token: 0x02000151 RID: 337
		[Token(Token = "0x2000151")]
		public struct OpenContext
		{
			// Token: 0x06000811 RID: 2065 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x82C8A0", Offset = "0x82B2A0", VA = "0x18082C8A0")]
			public OpenContext(Transform targetMirror, Transform playerTransform, float maxCouldUseTime, float mirrorRadius, float waitForAnimator, float moveSpeed, Vector2 offsetOfPlayer, Action onFindMizuchiCallback, Vector2? mizuchiPosition, Action<float> onUpdateMirrorProgressCallback, float waitForAnimatorEnd, Action setEndAnimator)
			{
			}

			// Token: 0x0400075A RID: 1882
			[Token(Token = "0x400075A")]
			[FieldOffset(Offset = "0x0")]
			public Transform TargetMirror;

			// Token: 0x0400075B RID: 1883
			[Token(Token = "0x400075B")]
			[FieldOffset(Offset = "0x8")]
			public Transform PlayerTransform;

			// Token: 0x0400075C RID: 1884
			[Token(Token = "0x400075C")]
			[FieldOffset(Offset = "0x10")]
			public float MaxCouldUseTime;

			// Token: 0x0400075D RID: 1885
			[Token(Token = "0x400075D")]
			[FieldOffset(Offset = "0x14")]
			public float MirrorRadius;

			// Token: 0x0400075E RID: 1886
			[Token(Token = "0x400075E")]
			[FieldOffset(Offset = "0x18")]
			public float WaitForAnimator;

			// Token: 0x0400075F RID: 1887
			[Token(Token = "0x400075F")]
			[FieldOffset(Offset = "0x1C")]
			public float MoveSpeed;

			// Token: 0x04000760 RID: 1888
			[Token(Token = "0x4000760")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 OffsetOfPlayer;

			// Token: 0x04000761 RID: 1889
			[Token(Token = "0x4000761")]
			[FieldOffset(Offset = "0x28")]
			public Action OnFindMizuchiCallback;

			// Token: 0x04000762 RID: 1890
			[Token(Token = "0x4000762")]
			[FieldOffset(Offset = "0x30")]
			public Vector2? MizuchiPosition;

			// Token: 0x04000763 RID: 1891
			[Token(Token = "0x4000763")]
			[FieldOffset(Offset = "0x40")]
			public Action<float> OnUpdateMirrorProgressCallback;

			// Token: 0x04000764 RID: 1892
			[Token(Token = "0x4000764")]
			[FieldOffset(Offset = "0x48")]
			public float WaitForAnimatorEnd;

			// Token: 0x04000765 RID: 1893
			[Token(Token = "0x4000765")]
			[FieldOffset(Offset = "0x50")]
			public Action SetEndAnimator;
		}
	}
}

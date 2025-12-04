using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.CharacterUtility;
using DayScene.Interactables;
using DayScene.UI;
using DEYU.AdpUISystem.Managers;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DayScene.Input
{
	// Token: 0x020004AE RID: 1198
	[Token(Token = "0x20004AE")]
	[GenerateCleanupMethod]
	public class DayScenePlayerInputGenerator : CharacterControllerInputGeneratorComponent
	{
		// Token: 0x06001B36 RID: 6966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B36")]
		[Address(RVA = "0x49C930", Offset = "0x49B330", VA = "0x18049C930")]
		private void Update()
		{
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B37")]
		[Address(RVA = "0x49B060", Offset = "0x499A60", VA = "0x18049B060")]
		private void RegisterBinding(string bindingName, InputActionPhase phase, Action<InputAction.CallbackContext> action)
		{
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B38")]
		[Address(RVA = "0x49B1F0", Offset = "0x499BF0", VA = "0x18049B1F0")]
		private void RegisterPanelWiseBinding(string bindingName, InputActionPhase phase, Action<InputAction.CallbackContext> action)
		{
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B39")]
		[Address(RVA = "0x49B550", Offset = "0x499F50", VA = "0x18049B550")]
		public void UpdateCharacter(DaySceneMap map, SpawnMarker spawnMarker)
		{
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3A")]
		[Address(RVA = "0x49AFB0", Offset = "0x4999B0", VA = "0x18049AFB0")]
		private void OnPanelWillOpenCallback()
		{
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3B")]
		[Address(RVA = "0x49ADC0", Offset = "0x4997C0", VA = "0x18049ADC0")]
		private void OnMovePerformed(InputAction.CallbackContext x)
		{
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3C")]
		[Address(RVA = "0x49AFB0", Offset = "0x4999B0", VA = "0x18049AFB0")]
		private void OnSprintCanceled(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0x49AFC0", Offset = "0x4999C0", VA = "0x18049AFC0")]
		private void OnSprintPerformed(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3E")]
		[Address(RVA = "0x49ACE0", Offset = "0x4996E0", VA = "0x18049ACE0")]
		private void OnMoveCanceled(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3F")]
		[Address(RVA = "0x49C810", Offset = "0x49B210", VA = "0x18049C810")]
		private void UpdateInputAvaility(bool enabled)
		{
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B40")]
		[Address(RVA = "0x49A860", Offset = "0x499260", VA = "0x18049A860")]
		public void Dispose()
		{
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B41")]
		[Address(RVA = "0x49B330", Offset = "0x499D30", VA = "0x18049B330")]
		private void TryCancelExecutionIfUI(AdpUIPanelManager.RequestedInputMode requestedInput)
		{
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B42")]
		[Address(RVA = "0x49B420", Offset = "0x499E20", VA = "0x18049B420")]
		private void TryInteract()
		{
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B43")]
		[Address(RVA = "0x49B190", Offset = "0x499B90", VA = "0x18049B190")]
		public void RegisterInteractableEvent(InteractableArea entity)
		{
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B44")]
		[Address(RVA = "0x49A800", Offset = "0x499200", VA = "0x18049A800")]
		public void DeRegInteractableEvent(InteractableArea entity)
		{
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B45")]
		[Address(RVA = "0x49C920", Offset = "0x49B320", VA = "0x18049C920")]
		private void UpdateUIBehaviour(bool _)
		{
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B46")]
		[Address(RVA = "0x49C210", Offset = "0x49AC10", VA = "0x18049C210")]
		private void UpdateCurrentFocusing()
		{
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B47")]
		[Address(RVA = "0x49AC80", Offset = "0x499680", VA = "0x18049AC80", Slot = "4")]
		protected override void OnExternalStop()
		{
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B48")]
		[Address(RVA = "0x49A780", Offset = "0x499180", VA = "0x18049A780", Slot = "8")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B49")]
		[Address(RVA = "0x49C960", Offset = "0x49B360", VA = "0x18049C960")]
		public DayScenePlayerInputGenerator()
		{
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B4C")]
		[Address(RVA = "0x49B4C0", Offset = "0x499EC0", VA = "0x18049B4C0")]
		[CompilerGenerated]
		private IEnumerator <TryInteract>g__ExecuteDelayed|23_0()
		{
			return null;
		}

		// Token: 0x0400190B RID: 6411
		[Token(Token = "0x400190B")]
		[FieldOffset(Offset = "0x28")]
		[Range(1f, 50f)]
		public float moveSpeed;

		// Token: 0x0400190C RID: 6412
		[Token(Token = "0x400190C")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<InteractableArea> allInteractables;

		// Token: 0x0400190D RID: 6413
		[Token(Token = "0x400190D")]
		[FieldOffset(Offset = "0x38")]
		[CleanupIgnore]
		private readonly Stack<ValueTuple<string, InputActionPhase, Action<InputAction.CallbackContext>>> m_RegisteredBinding;

		// Token: 0x0400190E RID: 6414
		[Token(Token = "0x400190E")]
		[FieldOffset(Offset = "0x40")]
		[CleanupIgnore]
		private readonly Stack<ValueTuple<string, InputActionPhase, Action<InputAction.CallbackContext>>> m_RegisteredPanelWiseBinding;

		// Token: 0x0400190F RID: 6415
		[Token(Token = "0x400190F")]
		[FieldOffset(Offset = "0x48")]
		private Action currentInteractAction;

		// Token: 0x04001910 RID: 6416
		[Token(Token = "0x4001910")]
		[FieldOffset(Offset = "0x50")]
		private bool initialized;

		// Token: 0x04001911 RID: 6417
		[Token(Token = "0x4001911")]
		[FieldOffset(Offset = "0x51")]
		private bool internalAvailability;

		// Token: 0x04001912 RID: 6418
		[Token(Token = "0x4001912")]
		[FieldOffset(Offset = "0x58")]
		[CleanupIgnore]
		private DaySceneSustainedPannel m_SustainedPanel;

		// Token: 0x04001913 RID: 6419
		[Token(Token = "0x4001913")]
		[FieldOffset(Offset = "0x60")]
		private bool onWillExecuteInteractAction;

		// Token: 0x04001914 RID: 6420
		[Token(Token = "0x4001914")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine onWillExecuteInteractActionProcess;

		// Token: 0x020004AF RID: 1199
		[Token(Token = "0x20004AF")]
		public enum CharacterRotation
		{
			// Token: 0x04001916 RID: 6422
			[Token(Token = "0x4001916")]
			Down,
			// Token: 0x04001917 RID: 6423
			[Token(Token = "0x4001917")]
			Left,
			// Token: 0x04001918 RID: 6424
			[Token(Token = "0x4001918")]
			Up,
			// Token: 0x04001919 RID: 6425
			[Token(Token = "0x4001919")]
			Right,
			// Token: 0x0400191A RID: 6426
			[Token(Token = "0x400191A")]
			Null = -1
		}
	}
}

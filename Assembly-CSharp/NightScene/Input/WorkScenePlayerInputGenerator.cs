using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.CharacterUtility;
using DEYU.AdpUISystem.Managers;
using Il2CppDummyDll;
using NightScene.UI;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

namespace NightScene.Input
{
	// Token: 0x0200056E RID: 1390
	[Token(Token = "0x200056E")]
	[GenerateCleanupMethod]
	public class WorkScenePlayerInputGenerator : CharacterControllerInputGeneratorComponent
	{
		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001F28 RID: 7976 RVA: 0x0000BB20 File Offset: 0x00009D20
		[Token(Token = "0x1700040D")]
		private Vector3Int GridPosition
		{
			[Token(Token = "0x6001F28")]
			[Address(RVA = "0x4F00F0", Offset = "0x4EEAF0", VA = "0x1804F00F0")]
			get
			{
				return default(Vector3Int);
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001F29 RID: 7977 RVA: 0x0000BB38 File Offset: 0x00009D38
		[Token(Token = "0x1700040E")]
		public bool IsStuned
		{
			[Token(Token = "0x6001F29")]
			[Address(RVA = "0x4F0180", Offset = "0x4EEB80", VA = "0x1804F0180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001F2A RID: 7978 RVA: 0x0000BB50 File Offset: 0x00009D50
		[Token(Token = "0x1700040F")]
		public bool ProhibitMovement
		{
			[Token(Token = "0x6001F2A")]
			[Address(RVA = "0x4F0190", Offset = "0x4EEB90", VA = "0x1804F0190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001F2B RID: 7979 RVA: 0x0000BB68 File Offset: 0x00009D68
		// (set) Token: 0x06001F2C RID: 7980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000410")]
		public float StunSeconds
		{
			[Token(Token = "0x6001F2B")]
			[Address(RVA = "0x440520", Offset = "0x43EF20", VA = "0x180440520")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001F2C")]
			[Address(RVA = "0x4F01A0", Offset = "0x4EEBA0", VA = "0x1804F01A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F2D")]
		[Address(RVA = "0x4EDA80", Offset = "0x4EC480", VA = "0x1804EDA80")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F2E")]
		[Address(RVA = "0x4EED50", Offset = "0x4ED750", VA = "0x1804EED50")]
		private void RegisterBinding(string bindingName, InputActionPhase phase, Action<InputAction.CallbackContext> action)
		{
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F2F")]
		[Address(RVA = "0x4EEE80", Offset = "0x4ED880", VA = "0x1804EEE80")]
		private void RegisterPanelWiseBinding(string bindingName, InputActionPhase phase, Action<InputAction.CallbackContext> action)
		{
		}

		// Token: 0x06001F30 RID: 7984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F30")]
		[Address(RVA = "0x4EDB00", Offset = "0x4EC500", VA = "0x1804EDB00")]
		public void Initialize(Tilemap heightMap, float stunIncrement, float stunMin)
		{
		}

		// Token: 0x06001F31 RID: 7985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F31")]
		[Address(RVA = "0x4EEFD0", Offset = "0x4ED9D0", VA = "0x1804EEFD0")]
		public void SetPlayerCharacterToDefaultSpawn()
		{
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F32")]
		[Address(RVA = "0x4EE990", Offset = "0x4ED390", VA = "0x1804EE990")]
		private void ReadInput(InputAction.CallbackContext x)
		{
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F33")]
		[Address(RVA = "0x4EE500", Offset = "0x4ECF00", VA = "0x1804EE500")]
		private void Interact(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F34")]
		[Address(RVA = "0x4ED470", Offset = "0x4EBE70", VA = "0x1804ED470")]
		private void CancelInput(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F35")]
		[Address(RVA = "0x4EFE90", Offset = "0x4EE890", VA = "0x1804EFE90")]
		private void UpdateInputAvaility(bool enabled)
		{
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F36")]
		[Address(RVA = "0x4ED670", Offset = "0x4EC070", VA = "0x1804ED670")]
		public void Dispose()
		{
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F37")]
		[Address(RVA = "0x4EF2C0", Offset = "0x4EDCC0", VA = "0x1804EF2C0")]
		private void TryCancelExecution(AdpUIPanelManager.RequestedInputMode requestedInputMode)
		{
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F38")]
		[Address(RVA = "0x4EF470", Offset = "0x4EDE70", VA = "0x1804EF470")]
		public void UpdateCurrentFocus()
		{
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F39")]
		[Address(RVA = "0x4EECF0", Offset = "0x4ED6F0", VA = "0x1804EECF0")]
		public void RefreshCurrentFocus()
		{
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F3A")]
		[Address(RVA = "0x4ED9D0", Offset = "0x4EC3D0", VA = "0x1804ED9D0")]
		public IEnumerator ExecuteThrowDeliver(Sprite sprite, Vector3 target)
		{
			return null;
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F3B")]
		[Address(RVA = "0x4EEFC0", Offset = "0x4ED9C0", VA = "0x1804EEFC0")]
		public void Reverse()
		{
		}

		// Token: 0x06001F3C RID: 7996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F3C")]
		[Address(RVA = "0x4ED930", Offset = "0x4EC330", VA = "0x1804ED930")]
		public void EndReverse()
		{
		}

		// Token: 0x06001F3D RID: 7997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F3D")]
		[Address(RVA = "0x4ED660", Offset = "0x4EC060", VA = "0x1804ED660")]
		public void Crazy()
		{
		}

		// Token: 0x06001F3E RID: 7998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F3E")]
		[Address(RVA = "0x4ED920", Offset = "0x4EC320", VA = "0x1804ED920")]
		public void EndCrazy()
		{
		}

		// Token: 0x06001F3F RID: 7999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F3F")]
		[Address(RVA = "0x4EF0C0", Offset = "0x4EDAC0", VA = "0x1804EF0C0")]
		public void Stun(int durationSec, Action actionEndCallBack, Action<float> actionUpdateCallBack, [Optional] Action actionOnlyOnTimeEndCallback)
		{
		}

		// Token: 0x06001F40 RID: 8000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F40")]
		[Address(RVA = "0x4ED940", Offset = "0x4EC340", VA = "0x1804ED940")]
		public void EndStunExtern()
		{
		}

		// Token: 0x06001F41 RID: 8001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F41")]
		[Address(RVA = "0x4EE900", Offset = "0x4ED300", VA = "0x1804EE900")]
		private IEnumerator OnStunLoop(Action<float> actionUpdateCallBack)
		{
			return null;
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F42")]
		[Address(RVA = "0x4EE640", Offset = "0x4ED040", VA = "0x1804EE640")]
		private void OnStunEnds(bool endDuetoTimeOut = false)
		{
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F43")]
		[Address(RVA = "0x49AC80", Offset = "0x499680", VA = "0x18049AC80", Slot = "4")]
		protected override void OnExternalStop()
		{
		}

		// Token: 0x06001F44 RID: 8004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F44")]
		[Address(RVA = "0x4EDAE0", Offset = "0x4EC4E0", VA = "0x1804EDAE0")]
		public void ForbidMovement()
		{
		}

		// Token: 0x06001F45 RID: 8005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F45")]
		[Address(RVA = "0x4EECE0", Offset = "0x4ED6E0", VA = "0x1804EECE0")]
		public void RecoverMovement()
		{
		}

		// Token: 0x06001F46 RID: 8006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F46")]
		[Address(RVA = "0x4ED5A0", Offset = "0x4EBFA0", VA = "0x1804ED5A0", Slot = "8")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001F47 RID: 8007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F47")]
		[Address(RVA = "0x4EFF80", Offset = "0x4EE980", VA = "0x1804EFF80")]
		public WorkScenePlayerInputGenerator()
		{
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F48")]
		[Address(RVA = "0x4EF3F0", Offset = "0x4EDDF0", VA = "0x1804EF3F0")]
		[CompilerGenerated]
		private IEnumerator <Interact>g__ExecuteDelayed|36_0()
		{
			return null;
		}

		// Token: 0x04001CAC RID: 7340
		[Token(Token = "0x4001CAC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[CleanupIgnore]
		private readonly Stack<ValueTuple<string, InputActionPhase, Action<InputAction.CallbackContext>>> m_RegisteredBinding;

		// Token: 0x04001CAD RID: 7341
		[Token(Token = "0x4001CAD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[CleanupIgnore]
		private readonly Stack<ValueTuple<string, InputActionPhase, Action<InputAction.CallbackContext>>> m_RegisteredPanelWiseBinding;

		// Token: 0x04001CAE RID: 7342
		[Token(Token = "0x4001CAE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<Action> stunEndsActions;

		// Token: 0x04001CAF RID: 7343
		[Token(Token = "0x4001CAF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<Action> stunOnlyOnTimeEndsActions;

		// Token: 0x04001CB0 RID: 7344
		[Token(Token = "0x4001CB0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3Int faceDirection;

		// Token: 0x04001CB1 RID: 7345
		[Token(Token = "0x4001CB1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3Int? focusedTileCoordinate;

		// Token: 0x04001CB2 RID: 7346
		[Token(Token = "0x4001CB2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool internalAvailability;

		// Token: 0x04001CB3 RID: 7347
		[Token(Token = "0x4001CB3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool isCrazy;

		// Token: 0x04001CB4 RID: 7348
		[Token(Token = "0x4001CB4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool isReversed;

		// Token: 0x04001CB5 RID: 7349
		[Token(Token = "0x4001CB5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int isStuned;

		// Token: 0x04001CB6 RID: 7350
		[Token(Token = "0x4001CB6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3Int? lastFocusedTileCoordinate;

		// Token: 0x04001CB7 RID: 7351
		[Token(Token = "0x4001CB7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[CleanupIgnore]
		private WorkSceneSustainedPannel m_SustainedPanel;

		// Token: 0x04001CB8 RID: 7352
		[Token(Token = "0x4001CB8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Coroutine onStun;

		// Token: 0x04001CB9 RID: 7353
		[Token(Token = "0x4001CB9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool onWillExecuteInteractAction;

		// Token: 0x04001CBA RID: 7354
		[Token(Token = "0x4001CBA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Coroutine onWillExecuteInteractActionProcess;

		// Token: 0x04001CBB RID: 7355
		[Token(Token = "0x4001CBB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int prohibitMovement;

		// Token: 0x04001CBC RID: 7356
		[Token(Token = "0x4001CBC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Grid referenceGrid;

		// Token: 0x04001CBD RID: 7357
		[Token(Token = "0x4001CBD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float stunIncrement;

		// Token: 0x04001CBE RID: 7358
		[Token(Token = "0x4001CBE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float stunMin;

		// Token: 0x04001CBF RID: 7359
		[Token(Token = "0x4001CBF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float stunMultiplier;
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using NightScene.UI.GuestManagementUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene
{
	// Token: 0x02000548 RID: 1352
	[Token(Token = "0x2000548")]
	[GenerateCleanupMethod]
	public class NightSceneDirector : MonoSingleton<NightSceneDirector>
	{
		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x0000B448 File Offset: 0x00009648
		// (set) Token: 0x06001E09 RID: 7689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E5")]
		public static bool IsManualWorkSceneSession
		{
			[Token(Token = "0x6001E08")]
			[Address(RVA = "0x4B5C10", Offset = "0x4B4610", VA = "0x1804B5C10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E09")]
			[Address(RVA = "0x4B5E50", Offset = "0x4B4850", VA = "0x1804B5E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x0000B460 File Offset: 0x00009660
		// (set) Token: 0x06001E0B RID: 7691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E6")]
		public static int DaySceneRemainedActions
		{
			[Token(Token = "0x6001E0A")]
			[Address(RVA = "0x4B5B00", Offset = "0x4B4500", VA = "0x1804B5B00")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E0B")]
			[Address(RVA = "0x4B5D30", Offset = "0x4B4730", VA = "0x1804B5D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001E0C RID: 7692 RVA: 0x0000B478 File Offset: 0x00009678
		// (set) Token: 0x06001E0D RID: 7693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E7")]
		public static bool IsKyoukoTutorialMode
		{
			[Token(Token = "0x6001E0C")]
			[Address(RVA = "0x4B5BD0", Offset = "0x4B45D0", VA = "0x1804B5BD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E0D")]
			[Address(RVA = "0x4B5E10", Offset = "0x4B4810", VA = "0x1804B5E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x0000B490 File Offset: 0x00009690
		// (set) Token: 0x06001E0F RID: 7695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E8")]
		public static ValueTuple<Action, Action> KyoukoTutorialTimelineCallback
		{
			[Token(Token = "0x6001E0E")]
			[Address(RVA = "0x4B5CA0", Offset = "0x4B46A0", VA = "0x1804B5CA0")]
			[CompilerGenerated]
			get
			{
				return default(ValueTuple<Action, Action>);
			}
			[Token(Token = "0x6001E0F")]
			[Address(RVA = "0x4B5E90", Offset = "0x4B4890", VA = "0x1804B5E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x0000B4A8 File Offset: 0x000096A8
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E9")]
		public static NightSceneDirector.ChallengeType ChallengeMode
		{
			[Token(Token = "0x6001E10")]
			[Address(RVA = "0x4B5AC0", Offset = "0x4B44C0", VA = "0x1804B5AC0")]
			[CompilerGenerated]
			get
			{
				return NightSceneDirector.ChallengeType.NotChallenge;
			}
			[Token(Token = "0x6001E11")]
			[Address(RVA = "0x4B5CF0", Offset = "0x4B46F0", VA = "0x1804B5CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x0000B4C0 File Offset: 0x000096C0
		// (set) Token: 0x06001E13 RID: 7699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003EA")]
		public static NightSceneDirector.Difficulty DifficultyMode
		{
			[Token(Token = "0x6001E12")]
			[Address(RVA = "0x4B5B40", Offset = "0x4B4540", VA = "0x1804B5B40")]
			[CompilerGenerated]
			get
			{
				return NightSceneDirector.Difficulty.None;
			}
			[Token(Token = "0x6001E13")]
			[Address(RVA = "0x4B5D70", Offset = "0x4B4770", VA = "0x1804B5D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x0000B4D8 File Offset: 0x000096D8
		// (set) Token: 0x06001E15 RID: 7701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003EB")]
		public static bool DoNotFadeOutInChallenge
		{
			[Token(Token = "0x6001E14")]
			[Address(RVA = "0x4B5B80", Offset = "0x4B4580", VA = "0x1804B5B80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E15")]
			[Address(RVA = "0x4B5DB0", Offset = "0x4B47B0", VA = "0x1804B5DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[Token(Token = "0x170003EC")]
		public static bool IsNormalNightOrRogueLike
		{
			[Token(Token = "0x6001E16")]
			[Address(RVA = "0x4B5C50", Offset = "0x4B4650", VA = "0x1804B5C50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x0000B508 File Offset: 0x00009708
		// (set) Token: 0x06001E18 RID: 7704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003ED")]
		public bool IsInTutorial
		{
			[Token(Token = "0x6001E17")]
			[Address(RVA = "0x4B5BC0", Offset = "0x4B45C0", VA = "0x1804B5BC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E18")]
			[Address(RVA = "0x4B5DF0", Offset = "0x4B47F0", VA = "0x1804B5DF0")]
			private set
			{
			}
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E19")]
		[Address(RVA = "0x4B4360", Offset = "0x4B2D60", VA = "0x1804B4360")]
		public GuestGroupController GetControlled(string guestLabel)
		{
			return null;
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1A")]
		[Address(RVA = "0x4B4410", Offset = "0x4B2E10", VA = "0x1804B4410", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1B")]
		[Address(RVA = "0x4B51E0", Offset = "0x4B3BE0", VA = "0x1804B51E0")]
		public void ShouldTimeFlow(bool doFlow)
		{
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1C")]
		[Address(RVA = "0x4B5190", Offset = "0x4B3B90", VA = "0x1804B5190")]
		public void ShouldGuestSpawn(bool doSpawn)
		{
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x4B5230", Offset = "0x4B3C30", VA = "0x1804B5230")]
		public void SpawnManualControlledSpecialGuestAuto(int specialGuestId, Action onEnd)
		{
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1E")]
		[Address(RVA = "0x4B5380", Offset = "0x4B3D80", VA = "0x1804B5380")]
		public void SpawnManualControlledSpecialGuest(int specialGuestId, string label, bool spawnInA)
		{
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0x4B49D0", Offset = "0x4B33D0", VA = "0x1804B49D0")]
		public void SetManualControlledToSeat(string label, int mood, int deskCode, Action onFinish)
		{
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E20")]
		[Address(RVA = "0x4B4BE0", Offset = "0x4B35E0", VA = "0x1804B4BE0")]
		public void SetSpecialGuestOrder(string label, int foodId, int bevId, Action<GuestGroupController.EvaluationResult> onFinish)
		{
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E21")]
		[Address(RVA = "0x4B4D80", Offset = "0x4B3780", VA = "0x1804B4D80")]
		public void SetSpecialGuestSpecialOrder(string label, int foodTag, int bevTag, Action<GuestGroupController.EvaluationResult> onFinish)
		{
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E22")]
		[Address(RVA = "0x4B4AB0", Offset = "0x4B34B0", VA = "0x1804B4AB0")]
		public void SetSpecialGuestLeave(string label, bool shouldLeaveInstantly)
		{
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E23")]
		[Address(RVA = "0x4B4CD0", Offset = "0x4B36D0", VA = "0x1804B4CD0")]
		public void SetSpecialGuestPatient(string label, int targetPatient)
		{
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E24")]
		[Address(RVA = "0x4B4E70", Offset = "0x4B3870", VA = "0x1804B4E70")]
		public void SetSpecialGuestSpell(string label, bool isPositive, bool visualOnly, Action onFinish)
		{
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E25")]
		[Address(RVA = "0x4B4480", Offset = "0x4B2E80", VA = "0x1804B4480")]
		public void PlayCustomDialog(string characterId, string title, float duration = -1f, [Optional] Action onFinish)
		{
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E26")]
		[Address(RVA = "0x4B46E0", Offset = "0x4B30E0", VA = "0x1804B46E0")]
		public void PlaySpecialGuestEvaluationDialog(string specialGuestId, GuestGroupController.EvaluationResult result, [Optional] Action onFinish)
		{
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E27")]
		private IEnumerator PlayDialogCoroutine<TDialogBox>(string characterId, [TupleElementNames(new string[] { "dialogBox", "pushCallback" })] Func<ValueTuple<TDialogBox, Action<TDialogBox>>> getNewDialogBox, Func<TDialogBox, IEnumerator> setMessage, Action onFinish) where TDialogBox : DialogBoxUI
		{
			return null;
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E28")]
		[Address(RVA = "0x4B56E0", Offset = "0x4B40E0", VA = "0x1804B56E0")]
		public void TryLeaveSession(Action onFinish)
		{
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E29")]
		[Address(RVA = "0x4B4470", Offset = "0x4B2E70", VA = "0x1804B4470")]
		public void OnInteractableOpen()
		{
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x0000B520 File Offset: 0x00009720
		[Token(Token = "0x6001E2A")]
		[Address(RVA = "0x4B43E0", Offset = "0x4B2DE0", VA = "0x1804B43E0")]
		private bool HasInteractableOpened()
		{
			return default(bool);
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E2B")]
		[Address(RVA = "0x4B4400", Offset = "0x4B2E00", VA = "0x1804B4400")]
		public void OnCanGotoNextPhase()
		{
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x0000B538 File Offset: 0x00009738
		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0x4B4110", Offset = "0x4B2B10", VA = "0x1804B4110")]
		private bool CanGotoNextPhase()
		{
			return default(bool);
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E2D")]
		[Address(RVA = "0x4B4460", Offset = "0x4B2E60", VA = "0x1804B4460")]
		public void OnInteractableExit()
		{
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0000B550 File Offset: 0x00009750
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x4B43C0", Offset = "0x4B2DC0", VA = "0x1804B43C0")]
		private bool HasInteractableExit()
		{
			return default(bool);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x4B49B0", Offset = "0x4B33B0", VA = "0x1804B49B0")]
		private void ResetParams()
		{
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E30")]
		[Address(RVA = "0x4B5820", Offset = "0x4B4220", VA = "0x1804B5820")]
		private IEnumerator TutorialSession(GameObject displayedObject, Action preInitialize, Func<bool> waitHandle)
		{
			return null;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E31")]
		[Address(RVA = "0x4B5660", Offset = "0x4B4060", VA = "0x1804B5660")]
		public void StartTutorial()
		{
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E32")]
		[Address(RVA = "0x4B54F0", Offset = "0x4B3EF0", VA = "0x1804B54F0")]
		public void StartTutorial2()
		{
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E33")]
		[Address(RVA = "0x4B5570", Offset = "0x4B3F70", VA = "0x1804B5570")]
		public void StartTutorial3(Action onFinish)
		{
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E34")]
		[Address(RVA = "0x4B4130", Offset = "0x4B2B30", VA = "0x1804B4130", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E35")]
		[Address(RVA = "0x4B59D0", Offset = "0x4B43D0", VA = "0x1804B59D0")]
		public NightSceneDirector()
		{
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E36")]
		[Address(RVA = "0x4B5950", Offset = "0x4B4350", VA = "0x1804B5950")]
		[CompilerGenerated]
		private IEnumerator <StartTutorial>g__Tutorial|89_0()
		{
			return null;
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E37")]
		[Address(RVA = "0x4B58D0", Offset = "0x4B42D0", VA = "0x1804B58D0")]
		[CompilerGenerated]
		private IEnumerator <StartTutorial2>g__Tutorial|90_0()
		{
			return null;
		}

		// Token: 0x04001BB8 RID: 7096
		[Token(Token = "0x4001BB8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Tutorial1")]
		public GameObject cookerSelectionOverlay;

		// Token: 0x04001BB9 RID: 7097
		[Token(Token = "0x4001BB9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject recipeSelectionOverlay;

		// Token: 0x04001BBA RID: 7098
		[Token(Token = "0x4001BBA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject startCookingOverlay;

		// Token: 0x04001BBB RID: 7099
		[Token(Token = "0x4001BBB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject cookingOverlay;

		// Token: 0x04001BBC RID: 7100
		[Token(Token = "0x4001BBC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject extractOverlay;

		// Token: 0x04001BBD RID: 7101
		[Token(Token = "0x4001BBD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject gotoBeverageOverlay;

		// Token: 0x04001BBE RID: 7102
		[Token(Token = "0x4001BBE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject extractBeverageOverlay;

		// Token: 0x04001BBF RID: 7103
		[Token(Token = "0x4001BBF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject closeBeverageOverlay;

		// Token: 0x04001BC0 RID: 7104
		[Token(Token = "0x4001BC0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject gotoDeliverOverlay;

		// Token: 0x04001BC1 RID: 7105
		[Token(Token = "0x4001BC1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject deliverOverlay;

		// Token: 0x04001BC2 RID: 7106
		[Token(Token = "0x4001BC2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject closeDeliverOverlay;

		// Token: 0x04001BC3 RID: 7107
		[Token(Token = "0x4001BC3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Tutorial 2")]
		public GameObject openWriggleOverlay;

		// Token: 0x04001BC4 RID: 7108
		[Token(Token = "0x4001BC4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GameObject exitWriggleOverlay;

		// Token: 0x04001BC5 RID: 7109
		[Token(Token = "0x4001BC5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public DialogPackage dialog;

		// Token: 0x04001BC6 RID: 7110
		[Token(Token = "0x4001BC6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GameObject openCookerOverlay;

		// Token: 0x04001BC7 RID: 7111
		[Token(Token = "0x4001BC7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject selectOverlay;

		// Token: 0x04001BC8 RID: 7112
		[Token(Token = "0x4001BC8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject waitOverlay;

		// Token: 0x04001BC9 RID: 7113
		[Token(Token = "0x4001BC9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GameObject extractCookedOverlay;

		// Token: 0x04001BCA RID: 7114
		[Token(Token = "0x4001BCA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public GameObject openBeverageOverlay;

		// Token: 0x04001BCB RID: 7115
		[Token(Token = "0x4001BCB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public GameObject selectBeverageOverlay;

		// Token: 0x04001BCC RID: 7116
		[Token(Token = "0x4001BCC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public GameObject closeBeverageOverlay2;

		// Token: 0x04001BCD RID: 7117
		[Token(Token = "0x4001BCD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public GameObject deliverSpecialGuestOverlay;

		// Token: 0x04001BCE RID: 7118
		[Token(Token = "0x4001BCE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public GameObject executeDeliverSpecialGuestOverlay;

		// Token: 0x04001BCF RID: 7119
		[Token(Token = "0x4001BCF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Header("Tutorial 3")]
		public GameObject qteTutorial;

		// Token: 0x04001BD0 RID: 7120
		[Token(Token = "0x4001BD0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly Dictionary<string, GuestGroupController> controlledGuest;

		// Token: 0x04001BD1 RID: 7121
		[Token(Token = "0x4001BD1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly Dictionary<string, Action> m_CurrentDisplayDialogBox;

		// Token: 0x04001BD2 RID: 7122
		[Token(Token = "0x4001BD2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool canGotoNextPhase;

		// Token: 0x04001BD3 RID: 7123
		[Token(Token = "0x4001BD3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
		private bool isInTutorial;

		// Token: 0x04001BD4 RID: 7124
		[Token(Token = "0x4001BD4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
		private bool onInteractableExit;

		// Token: 0x04001BD5 RID: 7125
		[Token(Token = "0x4001BD5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEB")]
		private bool onInteractableOpen;

		// Token: 0x02000549 RID: 1353
		[Token(Token = "0x2000549")]
		public enum ChallengeType
		{
			// Token: 0x04001BDE RID: 7134
			[Token(Token = "0x4001BDE")]
			[InspectorName("不是挑战")]
			NotChallenge,
			// Token: 0x04001BDF RID: 7135
			[Token(Token = "0x4001BDF")]
			[InspectorName("妖梦科目一")]
			Story_Basic,
			// Token: 0x04001BE0 RID: 7136
			[Token(Token = "0x4001BE0")]
			[InspectorName("妖梦科目二")]
			Story_Advanced,
			// Token: 0x04001BE1 RID: 7137
			[Token(Token = "0x4001BE1")]
			[InspectorName("幽幽子挑战")]
			Story_Yuyuko,
			// Token: 0x04001BE2 RID: 7138
			[Token(Token = "0x4001BE2")]
			[InspectorName("幽幽子重修")]
			Challenge_Yuyuko,
			// Token: 0x04001BE3 RID: 7139
			[Token(Token = "0x4001BE3")]
			[InspectorName("任何挑战")]
			AnyChallenge,
			// Token: 0x04001BE4 RID: 7140
			[Token(Token = "0x4001BE4")]
			[InspectorName("血池地狱挑战")]
			Story_BloodPondHell,
			// Token: 0x04001BE5 RID: 7141
			[Token(Token = "0x4001BE5")]
			[InspectorName("怪诞料理大赛挑战")]
			Story_WackyCookingCompetition,
			// Token: 0x04001BE6 RID: 7142
			[Token(Token = "0x4001BE6")]
			[InspectorName("青娥 料理挑战")]
			Story_Seiga_TempleCuisineCompetition,
			// Token: 0x04001BE7 RID: 7143
			[Token(Token = "0x4001BE7")]
			[InspectorName("布都 料理挑战")]
			Story_Futo_TempleCuisineCompetition,
			// Token: 0x04001BE8 RID: 7144
			[Token(Token = "0x4001BE8")]
			[InspectorName("屠自古 料理挑战")]
			Story_Tochiko_TempleCuisineCompetition,
			// Token: 0x04001BE9 RID: 7145
			[Token(Token = "0x4001BE9")]
			[InspectorName("云居一轮 音游挑战")]
			Story_Ichirin_MusicCompetition,
			// Token: 0x04001BEA RID: 7146
			[Token(Token = "0x4001BEA")]
			[InspectorName("村纱水蜜 音游挑战")]
			Story_Minamitu_MusicCompetition,
			// Token: 0x04001BEB RID: 7147
			[Token(Token = "0x4001BEB")]
			[InspectorName("寅丸星 音游挑战")]
			Story_Toramaru_MusicCompetition,
			// Token: 0x04001BEC RID: 7148
			[Token(Token = "0x4001BEC")]
			[InspectorName("芙兰朵露的笼女游戏")]
			Story_Flandre,
			// Token: 0x04001BED RID: 7149
			[Token(Token = "0x4001BED")]
			[InspectorName("Rogue Like")]
			RogueLike,
			// Token: 0x04001BEE RID: 7150
			[Token(Token = "0x4001BEE")]
			[InspectorName("寻找瑞灵踪迹")]
			Story_Mizuchi,
			// Token: 0x04001BEF RID: 7151
			[Token(Token = "0x4001BEF")]
			[InspectorName("月都试炼1")]
			Story_Mizuchi_1,
			// Token: 0x04001BF0 RID: 7152
			[Token(Token = "0x4001BF0")]
			[InspectorName("月都试炼2")]
			Story_Mizuchi_2,
			// Token: 0x04001BF1 RID: 7153
			[Token(Token = "0x4001BF1")]
			[InspectorName("月都试炼3")]
			Story_Mizuchi_3
		}

		// Token: 0x0200054A RID: 1354
		[Token(Token = "0x200054A")]
		public enum Difficulty
		{
			// Token: 0x04001BF3 RID: 7155
			[Token(Token = "0x4001BF3")]
			None,
			// Token: 0x04001BF4 RID: 7156
			[Token(Token = "0x4001BF4")]
			Easy,
			// Token: 0x04001BF5 RID: 7157
			[Token(Token = "0x4001BF5")]
			Normal,
			// Token: 0x04001BF6 RID: 7158
			[Token(Token = "0x4001BF6")]
			Hard,
			// Token: 0x04001BF7 RID: 7159
			[Token(Token = "0x4001BF7")]
			Lunatic
		}
	}
}

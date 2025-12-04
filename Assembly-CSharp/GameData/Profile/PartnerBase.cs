using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.CharacterUtility;
using DayScene.Input;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using NightScene.Tiles;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CF1 RID: 3313
	[Token(Token = "0x2000CF1")]
	public abstract class PartnerBase
	{
		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06004CD8 RID: 19672 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004CD9 RID: 19673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B1F")]
		protected GuestsManager.OrderBase FocusingOrderBase
		{
			[Token(Token = "0x6004CD8")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004CD9")]
			[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
			set
			{
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06004CDA RID: 19674 RVA: 0x0001BC60 File Offset: 0x00019E60
		[Token(Token = "0x17000B20")]
		public int FocusingOrderNum
		{
			[Token(Token = "0x6004CDA")]
			[Address(RVA = "0x7933F0", Offset = "0x791DF0", VA = "0x1807933F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06004CDB RID: 19675 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004CDC RID: 19676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B21")]
		private protected Func<PartnerManager.OrderChangeContext, GuestsManager.OrderBase, object, bool> OnSystemStatusChangedShouldInterruptCurrentStateCallback
		{
			[Token(Token = "0x6004CDB")]
			[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6004CDC")]
			[Address(RVA = "0x45F1B0", Offset = "0x45DBB0", VA = "0x18045F1B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06004CDD RID: 19677 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004CDE RID: 19678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B22")]
		private protected Action CurrentStateInterrupt
		{
			[Token(Token = "0x6004CDD")]
			[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6004CDE")]
			[Address(RVA = "0x45ABC0", Offset = "0x4595C0", VA = "0x18045ABC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06004CDF RID: 19679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B23")]
		protected TileManager TileManager
		{
			[Token(Token = "0x6004CDF")]
			[Address(RVA = "0x793460", Offset = "0x791E60", VA = "0x180793460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06004CE0 RID: 19680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B24")]
		protected PartnerManager Manager
		{
			[Token(Token = "0x6004CE0")]
			[Address(RVA = "0x793410", Offset = "0x791E10", VA = "0x180793410")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06004CE1 RID: 19681 RVA: 0x0001BC78 File Offset: 0x00019E78
		[Token(Token = "0x17000B25")]
		protected Vector3 CharacterPosition
		{
			[Token(Token = "0x6004CE1")]
			[Address(RVA = "0x7932F0", Offset = "0x791CF0", VA = "0x1807932F0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06004CE2 RID: 19682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B26")]
		public AStarInputGeneratorComponent ControlledCharacter
		{
			[Token(Token = "0x6004CE2")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06004CE3 RID: 19683 RVA: 0x0001BC90 File Offset: 0x00019E90
		[Token(Token = "0x17000B27")]
		public Vector3Int IdlePosition
		{
			[Token(Token = "0x6004CE3")]
			[Address(RVA = "0x6AEDE0", Offset = "0x6AD7E0", VA = "0x1806AEDE0")]
			get
			{
				return default(Vector3Int);
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06004CE4 RID: 19684 RVA: 0x0001BCA8 File Offset: 0x00019EA8
		[Token(Token = "0x17000B28")]
		public int PartnerIndex
		{
			[Token(Token = "0x6004CE4")]
			[Address(RVA = "0x477F70", Offset = "0x476970", VA = "0x180477F70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06004CE5 RID: 19685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B29")]
		public PartnerInfoBase PartnerData
		{
			[Token(Token = "0x6004CE5")]
			[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06004CE6 RID: 19686 RVA: 0x0001BCC0 File Offset: 0x00019EC0
		[Token(Token = "0x17000B2A")]
		public PartnerInfoBase.WorkState PartnerWorkingState
		{
			[Token(Token = "0x6004CE6")]
			[Address(RVA = "0x793450", Offset = "0x791E50", VA = "0x180793450")]
			get
			{
				return PartnerInfoBase.WorkState.InWork;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06004CE7 RID: 19687 RVA: 0x0001BCD8 File Offset: 0x00019ED8
		[Token(Token = "0x17000B2B")]
		public float PartnerSleepStateProgress
		{
			[Token(Token = "0x6004CE7")]
			[Address(RVA = "0x477F30", Offset = "0x476930", VA = "0x180477F30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06004CE8 RID: 19688 RVA: 0x0001BCF0 File Offset: 0x00019EF0
		[Token(Token = "0x17000B2C")]
		public PartnerBase.PartnerStatus PartnerStatusEnum
		{
			[Token(Token = "0x6004CE8")]
			[Address(RVA = "0x793440", Offset = "0x791E40", VA = "0x180793440")]
			get
			{
				return PartnerBase.PartnerStatus.Idle;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06004CE9 RID: 19689 RVA: 0x0001BD08 File Offset: 0x00019F08
		[Token(Token = "0x17000B2D")]
		public float ExtraWorkSpeedRate
		{
			[Token(Token = "0x6004CE9")]
			[Address(RVA = "0x793380", Offset = "0x791D80", VA = "0x180793380")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06004CEA RID: 19690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B2E")]
		public List<int> CompanionPartnerIndexs
		{
			[Token(Token = "0x6004CEA")]
			[Address(RVA = "0x440500", Offset = "0x43EF00", VA = "0x180440500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06004CEB RID: 19691 RVA: 0x0001BD20 File Offset: 0x00019F20
		[Token(Token = "0x17000B2F")]
		public Vector3 ExtraOffset
		{
			[Token(Token = "0x6004CEB")]
			[Address(RVA = "0x793340", Offset = "0x791D40", VA = "0x180793340")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06004CEC RID: 19692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEC")]
		[Address(RVA = "0x7918E0", Offset = "0x7902E0", VA = "0x1807918E0")]
		public void ForceInterrupt()
		{
		}

		// Token: 0x06004CED RID: 19693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CED")]
		[Address(RVA = "0x791B60", Offset = "0x790560", VA = "0x180791B60")]
		public void Initialize(Vector3Int idlePosition, AStarInputGeneratorComponent controlledCharacter, PartnerInfoBase partnerData, int partnerIndex)
		{
		}

		// Token: 0x06004CEE RID: 19694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEE")]
		public void SetAdditionalData<T>(T extraData, int index)
		{
		}

		// Token: 0x06004CEF RID: 19695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CEF")]
		[Address(RVA = "0x7931C0", Offset = "0x791BC0", VA = "0x1807931C0")]
		public void UpdateStatus(PartnerInfoBase.WorkState currentWorkState)
		{
		}

		// Token: 0x06004CF0 RID: 19696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF0")]
		[Address(RVA = "0x793120", Offset = "0x791B20", VA = "0x180793120")]
		private void UpdateSleepingStatus(PartnerInfoBase.WorkState currentWorkState)
		{
		}

		// Token: 0x06004CF1 RID: 19697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF1")]
		[Address(RVA = "0x793110", Offset = "0x791B10", VA = "0x180793110")]
		private void UpdateCurrentWorkStateProgress(float progressToFinishState)
		{
		}

		// Token: 0x06004CF2 RID: 19698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF2")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "4")]
		protected virtual void OnInitialize()
		{
		}

		// Token: 0x06004CF3 RID: 19699
		[Token(Token = "0x6004CF3")]
		protected abstract void OnPlayIdleState();

		// Token: 0x06004CF4 RID: 19700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF4")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "6")]
		public virtual void OnDestroy()
		{
		}

		// Token: 0x06004CF5 RID: 19701
		[Token(Token = "0x6004CF5")]
		protected abstract void ResetStatus();

		// Token: 0x06004CF6 RID: 19702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF6")]
		[Address(RVA = "0x792E00", Offset = "0x791800", VA = "0x180792E00")]
		public void TryAddCompanionPartnerBaseIndex(int companionBaseIndex)
		{
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CF7")]
		[Address(RVA = "0x7920C0", Offset = "0x790AC0", VA = "0x1807920C0")]
		public void NotifyOrderStatusChanged(int senderIndex, PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, object additionalInformation)
		{
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CF8")]
		[Address(RVA = "0x791900", Offset = "0x790300", VA = "0x180791900")]
		public Transform GetControlledTransform()
		{
			return null;
		}

		// Token: 0x06004CF9 RID: 19705
		[Token(Token = "0x6004CF9")]
		public abstract PartnerBase.PartnerType GetPartnerType();

		// Token: 0x06004CFA RID: 19706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CFA")]
		[Address(RVA = "0x792330", Offset = "0x790D30", VA = "0x180792330")]
		protected void PartnerLog(string args)
		{
		}

		// Token: 0x06004CFB RID: 19707 RVA: 0x0001BD38 File Offset: 0x00019F38
		[Token(Token = "0x6004CFB")]
		[Address(RVA = "0x791920", Offset = "0x790320", VA = "0x180791920")]
		public float GetPartnerRevenueCut(float multiplyingPower = 1f, bool ignoreTewiLuck = false)
		{
			return 0f;
		}

		// Token: 0x06004CFC RID: 19708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CFC")]
		[Address(RVA = "0x4A6ED0", Offset = "0x4A58D0", VA = "0x1804A6ED0")]
		protected void Take(Sellable sellable)
		{
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CFD")]
		[Address(RVA = "0x792CA0", Offset = "0x7916A0", VA = "0x180792CA0")]
		protected Sellable Send()
		{
			return null;
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CFE")]
		[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
		public Sellable InspectBuffer()
		{
			return null;
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CFF")]
		[Address(RVA = "0x792CD0", Offset = "0x7916D0", VA = "0x180792CD0")]
		protected void SetUIStatus(int? targetDeskCode, string key)
		{
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D00")]
		[Address(RVA = "0x7919D0", Offset = "0x7903D0", VA = "0x1807919D0")]
		protected void IngredientInRange(IEnumerable<int> ingredients)
		{
		}

		// Token: 0x06004D01 RID: 19713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D01")]
		[Address(RVA = "0x791A80", Offset = "0x790480", VA = "0x180791A80")]
		protected void IngredientOutRange(IEnumerable<int> ingredients)
		{
		}

		// Token: 0x06004D02 RID: 19714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D02")]
		[Address(RVA = "0x7925F0", Offset = "0x790FF0", VA = "0x1807925F0")]
		public void PlayIdleState()
		{
		}

		// Token: 0x06004D03 RID: 19715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D03")]
		[Address(RVA = "0x7921E0", Offset = "0x790BE0", VA = "0x1807921E0")]
		private void OnMoveToIdlePositionCompelete()
		{
		}

		// Token: 0x06004D04 RID: 19716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D04")]
		[Address(RVA = "0x792270", Offset = "0x790C70", VA = "0x180792270")]
		private void OnStartSleeping()
		{
		}

		// Token: 0x06004D05 RID: 19717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D05")]
		[Address(RVA = "0x7922E0", Offset = "0x790CE0", VA = "0x1807922E0")]
		protected void OnStartWorking()
		{
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D06")]
		[Address(RVA = "0x7927A0", Offset = "0x7911A0", VA = "0x1807927A0")]
		protected void PlayMoveToReturnInventoryState(PartnerBase.InventoryType inventoryType, int? targetDeskCode, Vector3Int? overridePosition, [Optional] Action onReturnFinish)
		{
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D07")]
		[Address(RVA = "0x792B20", Offset = "0x791520", VA = "0x180792B20", Slot = "9")]
		protected virtual void PlayReturnToInventoryState(Action onFinish)
		{
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D08")]
		[Address(RVA = "0x791E90", Offset = "0x790890", VA = "0x180791E90")]
		public void MoveCharacter(Vector3Int dest, Vector3 extraOffset, DayScenePlayerInputGenerator.CharacterRotation onArrivalRotation, Action onArrivalCallback)
		{
		}

		// Token: 0x06004D09 RID: 19721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D09")]
		[Address(RVA = "0x792D80", Offset = "0x791780", VA = "0x180792D80")]
		public void StopCharacter()
		{
		}

		// Token: 0x06004D0A RID: 19722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0A")]
		[Address(RVA = "0x792EA0", Offset = "0x7918A0", VA = "0x180792EA0")]
		public void TryStopCharacterAndRecordAction()
		{
		}

		// Token: 0x06004D0B RID: 19723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0B")]
		[Address(RVA = "0x792F50", Offset = "0x791950", VA = "0x180792F50")]
		public void TryToMoveAgain()
		{
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0C")]
		[Address(RVA = "0x7925A0", Offset = "0x790FA0", VA = "0x1807925A0")]
		protected void PlayAudio(AudioClip audioClip)
		{
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D0D")]
		[Address(RVA = "0x7917B0", Offset = "0x7901B0", VA = "0x1807917B0")]
		public AStarInputGeneratorComponent Dispose()
		{
			return null;
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D0E")]
		[Address(RVA = "0x793260", Offset = "0x791C60", VA = "0x180793260")]
		protected PartnerBase()
		{
		}

		// Token: 0x040046C7 RID: 18119
		[Token(Token = "0x40046C7")]
		private const string SPECIAL_EVENT_KEY = "Special_Event_Tewi_Buy_Reisen";

		// Token: 0x040046C8 RID: 18120
		[Token(Token = "0x40046C8")]
		private const string PARTNER_STATUS_IDLE = "PARTNERSTATUS_IDLE";

		// Token: 0x040046C9 RID: 18121
		[Token(Token = "0x40046C9")]
		private const string PARTNER_STATUS_STORING = "PARTNERSTATUS_STORING";

		// Token: 0x040046CA RID: 18122
		[Token(Token = "0x40046CA")]
		private const string PARTNER_STATUS_SLEEPING = "PARTNERSTATUS_SLEEPING";

		// Token: 0x040046CB RID: 18123
		[Token(Token = "0x40046CB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static readonly Vector3 EXTRA_STORAGE_MOVEMENT_OFFSET;

		// Token: 0x040046CC RID: 18124
		[Token(Token = "0x40046CC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Sellable buffer;

		// Token: 0x040046CD RID: 18125
		[Token(Token = "0x40046CD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private AStarInputGeneratorComponent controlledCharacter;

		// Token: 0x040046CE RID: 18126
		[Token(Token = "0x40046CE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GuestsManager.OrderBase focusingOrder;

		// Token: 0x040046CF RID: 18127
		[Token(Token = "0x40046CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3Int idlePosition;

		// Token: 0x040046D0 RID: 18128
		[Token(Token = "0x40046D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected object[] m_PartnerAdditionalData;

		// Token: 0x040046D1 RID: 18129
		[Token(Token = "0x40046D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action moveCharacterAction;

		// Token: 0x040046D2 RID: 18130
		[Token(Token = "0x40046D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action OnStartIdleExtraCallback;

		// Token: 0x040046D3 RID: 18131
		[Token(Token = "0x40046D3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action OnStartWorkingExtraCallback;

		// Token: 0x040046D4 RID: 18132
		[Token(Token = "0x40046D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PartnerInfoBase partnerData;

		// Token: 0x040046D5 RID: 18133
		[Token(Token = "0x40046D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int partnerIndex;

		// Token: 0x040046D6 RID: 18134
		[Token(Token = "0x40046D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private object partnerMovementAdditionData;

		// Token: 0x040046D7 RID: 18135
		[Token(Token = "0x40046D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float partnerSleepStateProgress;

		// Token: 0x040046D8 RID: 18136
		[Token(Token = "0x40046D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private PartnerBase.PartnerStatus partnerStatus;

		// Token: 0x040046D9 RID: 18137
		[Token(Token = "0x40046D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PartnerInfoBase.WorkState partnerWorkingState;

		// Token: 0x040046DA RID: 18138
		[Token(Token = "0x40046DA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<bool> shouldNotMove;

		// Token: 0x02000CF2 RID: 3314
		[Token(Token = "0x2000CF2")]
		public enum PartnerStatus : byte
		{
			// Token: 0x040046DF RID: 18143
			[Token(Token = "0x40046DF")]
			Idle,
			// Token: 0x040046E0 RID: 18144
			[Token(Token = "0x40046E0")]
			CompletelyIdle,
			// Token: 0x040046E1 RID: 18145
			[Token(Token = "0x40046E1")]
			Working
		}

		// Token: 0x02000CF3 RID: 3315
		[Token(Token = "0x2000CF3")]
		public enum PartnerType : byte
		{
			// Token: 0x040046E3 RID: 18147
			[Token(Token = "0x40046E3")]
			Cook,
			// Token: 0x040046E4 RID: 18148
			[Token(Token = "0x40046E4")]
			Waitress,
			// Token: 0x040046E5 RID: 18149
			[Token(Token = "0x40046E5")]
			Barmaid,
			// Token: 0x040046E6 RID: 18150
			[Token(Token = "0x40046E6")]
			None,
			// Token: 0x040046E7 RID: 18151
			[Token(Token = "0x40046E7")]
			Boss
		}

		// Token: 0x02000CF4 RID: 3316
		[Token(Token = "0x2000CF4")]
		protected enum InventoryType : byte
		{
			// Token: 0x040046E9 RID: 18153
			[Token(Token = "0x40046E9")]
			Food,
			// Token: 0x040046EA RID: 18154
			[Token(Token = "0x40046EA")]
			Beverage
		}
	}
}

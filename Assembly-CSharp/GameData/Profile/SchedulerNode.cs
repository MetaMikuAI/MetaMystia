using System;
using Common;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.CoreLanguage;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using NightScene;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Playables;

namespace GameData.Profile
{
	// Token: 0x02000BBA RID: 3002
	[Token(Token = "0x2000BBA")]
	public abstract class SchedulerNode : ScriptableObject
	{
		// Token: 0x060046BD RID: 18109
		[Token(Token = "0x60046BD")]
		public abstract SchedulerNode.NodeType GetNodeType();

		// Token: 0x060046BE RID: 18110
		[Token(Token = "0x60046BE")]
		protected abstract void PostIntializeClone(SchedulerNode instance);

		// Token: 0x060046BF RID: 18111
		[Token(Token = "0x60046BF")]
		protected abstract Type InternalGetNodeType();

		// Token: 0x060046C0 RID: 18112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046C0")]
		[Address(RVA = "0x740A70", Offset = "0x73F470", VA = "0x180740A70")]
		public SchedulerNode Clone()
		{
			return null;
		}

		// Token: 0x060046C1 RID: 18113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046C1")]
		[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060046C2 RID: 18114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046C2")]
		[Address(RVA = "0x740EA0", Offset = "0x73F8A0", VA = "0x180740EA0")]
		protected SchedulerNode()
		{
		}

		// Token: 0x04003F48 RID: 16200
		[Token(Token = "0x4003F48")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04003F49 RID: 16201
		[Token(Token = "0x4003F49")]
		[FieldOffset(Offset = "0x20")]
		public string debugLabel;

		// Token: 0x04003F4A RID: 16202
		[Token(Token = "0x4003F4A")]
		[FieldOffset(Offset = "0x28")]
		public SchedulerNode.Reward[] rewards;

		// Token: 0x04003F4B RID: 16203
		[Token(Token = "0x4003F4B")]
		[FieldOffset(Offset = "0x30")]
		public SchedulerNode.Reward[] postRewards;

		// Token: 0x04003F4C RID: 16204
		[Token(Token = "0x4003F4C")]
		[FieldOffset(Offset = "0x38")]
		public string[] postEvents;

		// Token: 0x04003F4D RID: 16205
		[Token(Token = "0x4003F4D")]
		[FieldOffset(Offset = "0x40")]
		public string[] postMissions;

		// Token: 0x04003F4E RID: 16206
		[Token(Token = "0x4003F4E")]
		[FieldOffset(Offset = "0x48")]
		public string[] postMissionsAfterPerformance;

		// Token: 0x04003F4F RID: 16207
		[Token(Token = "0x4003F4F")]
		[FieldOffset(Offset = "0x50")]
		public string[] preNodes;

		// Token: 0x04003F50 RID: 16208
		[Token(Token = "0x4003F50")]
		[FieldOffset(Offset = "0x58")]
		public SchedulerNode.SchedulerType missionType;

		// Token: 0x02000BBB RID: 3003
		[Token(Token = "0x2000BBB")]
		public enum NodeType
		{
			// Token: 0x04003F52 RID: 16210
			[Token(Token = "0x4003F52")]
			Event,
			// Token: 0x04003F53 RID: 16211
			[Token(Token = "0x4003F53")]
			Mission,
			// Token: 0x04003F54 RID: 16212
			[Token(Token = "0x4003F54")]
			Aya
		}

		// Token: 0x02000BBC RID: 3004
		[Token(Token = "0x2000BBC")]
		public enum SchedulerType
		{
			// Token: 0x04003F56 RID: 16214
			[Token(Token = "0x4003F56")]
			Main,
			// Token: 0x04003F57 RID: 16215
			[Token(Token = "0x4003F57")]
			Side,
			// Token: 0x04003F58 RID: 16216
			[Token(Token = "0x4003F58")]
			Kitsuna
		}

		// Token: 0x02000BBD RID: 3005
		[Token(Token = "0x2000BBD")]
		[Serializable]
		public struct Trigger
		{
			// Token: 0x04003F59 RID: 16217
			[Token(Token = "0x4003F59")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public SchedulerNode.Trigger.TriggerType triggerType;

			// Token: 0x04003F5A RID: 16218
			[Token(Token = "0x4003F5A")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public string triggerId;

			// Token: 0x04003F5B RID: 16219
			[Token(Token = "0x4003F5B")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public SchedulerNode.Day time;

			// Token: 0x04003F5C RID: 16220
			[Token(Token = "0x4003F5C")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			public SchedulerNode.Trigger.IzakayaLockType izakayaLockType;

			// Token: 0x04003F5D RID: 16221
			[Token(Token = "0x4003F5D")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			public SchedulerNode.Trigger.IzakayaMapping[] izakayaMappings;

			// Token: 0x04003F5E RID: 16222
			[Token(Token = "0x4003F5E")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			public NightSceneDirector.ChallengeType challengeEndContext;

			// Token: 0x04003F5F RID: 16223
			[Token(Token = "0x4003F5F")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			public int overrideIzakayaIndex;

			// Token: 0x04003F60 RID: 16224
			[Token(Token = "0x4003F60")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			public Product product;

			// Token: 0x04003F61 RID: 16225
			[Token(Token = "0x4003F61")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			public bool anyTime;

			// Token: 0x04003F62 RID: 16226
			[Token(Token = "0x4003F62")]
			[FieldOffset(Offset = "0x51")]
			[SerializeField]
			public bool scheduleAtFirst;

			// Token: 0x04003F63 RID: 16227
			[Token(Token = "0x4003F63")]
			[FieldOffset(Offset = "0x54")]
			[SerializeField]
			public int executeOrder;

			// Token: 0x04003F64 RID: 16228
			[Token(Token = "0x4003F64")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public int amount;

			// Token: 0x04003F65 RID: 16229
			[Token(Token = "0x4003F65")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public string[] labels;

			// Token: 0x02000BBE RID: 3006
			[Token(Token = "0x2000BBE")]
			public enum IzakayaLockType
			{
				// Token: 0x04003F67 RID: 16231
				[Token(Token = "0x4003F67")]
				Unlocked,
				// Token: 0x04003F68 RID: 16232
				[Token(Token = "0x4003F68")]
				Locked,
				// Token: 0x04003F69 RID: 16233
				[Token(Token = "0x4003F69")]
				Masked
			}

			// Token: 0x02000BBF RID: 3007
			[Token(Token = "0x2000BBF")]
			public enum TriggerType
			{
				// Token: 0x04003F6B RID: 16235
				[Token(Token = "0x4003F6B")]
				[InspectorName("进入白天地图前(OnEnterDaySceneMap)")]
				OnEnterDaySceneMap,
				// Token: 0x04003F6C RID: 16236
				[Token(Token = "0x4003F6C")]
				[InspectorName("进入白天前(OnEnterDayScene)")]
				OnEnterDayScene,
				// Token: 0x04003F6D RID: 16237
				[Token(Token = "0x4003F6D")]
				[InspectorName("工作结束前(OnWorkEnd)")]
				OnWorkEnd,
				// Token: 0x04003F6E RID: 16238
				[Token(Token = "0x4003F6E")]
				[InspectorName("和角色对话时(OnTalkWithCharacter)")]
				OnTalkWithCharacter,
				// Token: 0x04003F6F RID: 16239
				[Token(Token = "0x4003F6F")]
				[InspectorName("工作开始之前(OnBeforeWorkStart)")]
				OnBeforeWorkStart,
				// Token: 0x04003F70 RID: 16240
				[Token(Token = "0x4003F70")]
				[InspectorName("羁绊等级升级时(KizunaCheckPoint)")]
				KizunaCheckPoint,
				// Token: 0x04003F71 RID: 16241
				[Token(Token = "0x4003F71")]
				[InspectorName("白天结束时，在夜雀的进入店面对话前(OnDayEnd)")]
				OnDayEnd,
				// Token: 0x04003F72 RID: 16242
				[Token(Token = "0x4003F72")]
				[InspectorName("等级升级时(LevelCheckPoint)")]
				LevelCheckPoint,
				// Token: 0x04003F73 RID: 16243
				[Token(Token = "0x4003F73")]
				[InspectorName("【未实现】购买了目标物品X个数量时(BuyCount)")]
				BuyCount,
				// Token: 0x04003F74 RID: 16244
				[Token(Token = "0x4003F74")]
				[InspectorName("挑战开始前(OnBeforeChallengeStart)")]
				OnBeforeChallengeStart,
				// Token: 0x04003F75 RID: 16245
				[Token(Token = "0x4003F75")]
				[InspectorName("挑战结束前(OnChallengeEnd)")]
				OnChallengeEnd,
				// Token: 0x04003F76 RID: 16246
				[Token(Token = "0x4003F76")]
				[InspectorName("【已弃用】挑战阶段切换时(Obsolete_OnChallengePhaseChange)")]
				Obsolete_OnChallengePhaseChange,
				// Token: 0x04003F77 RID: 16247
				[Token(Token = "0x4003F77")]
				[InspectorName("挑战失败时(OnChallengeFailed)")]
				OnChallengeFailed,
				// Token: 0x04003F78 RID: 16248
				[Token(Token = "0x4003F78")]
				[InspectorName("挑战成功时(OnChallengeSucceed)")]
				OnChallengeSucceed,
				// Token: 0x04003F79 RID: 16249
				[Token(Token = "0x4003F79")]
				[InspectorName("白天结束时，在夜雀的进入店面对话后(OnAfterDayEnd)")]
				OnAfterDayEnd,
				// Token: 0x04003F7A RID: 16250
				[Token(Token = "0x4003F7A")]
				[InspectorName("进入雀食堂配置前(OnBeforeIzakayaConfigure)")]
				OnBeforeIzakayaConfigure,
				// Token: 0x04003F7B RID: 16251
				[Token(Token = "0x4003F7B")]
				[InspectorName("进入白天触发区域(OnEnterDaySceneTriggerArea)")]
				OnEnterDaySceneTriggerArea,
				// Token: 0x04003F7C RID: 16252
				[Token(Token = "0x4003F7C")]
				[InspectorName("立刻获得该事件内包含的奖励以及后置信息(TriggerFinishImmediate)")]
				TriggerFinishImmediate,
				// Token: 0x04003F7D RID: 16253
				[Token(Token = "0x4003F7D")]
				[InspectorName("在白天结束，雀食堂配置面板打开后(OnAfterDayEndIzakayaSelectionOpen)")]
				OnAfterDayEndIzakayaSelectionOpen,
				// Token: 0x04003F7E RID: 16254
				[Token(Token = "0x4003F7E")]
				[InspectorName("完成以下事件中的X(指定数量)个(CompleteSpecifiedFollowingEvents)")]
				CompleteSpecifiedFollowingEvents,
				// Token: 0x04003F7F RID: 16255
				[Token(Token = "0x4003F7F")]
				[InspectorName("表示某种事情发生(不会自动完成，需要手动完成或者取消计划)(ImpossibleFinish)")]
				ImpossibleFinish,
				// Token: 0x04003F80 RID: 16256
				[Token(Token = "0x4003F80")]
				[InspectorName("在羁绊经验到达当前等级最大值时(OnAnyKizunaExpFull)")]
				OnAnyKizunaExpFull
			}

			// Token: 0x02000BC0 RID: 3008
			[Token(Token = "0x2000BC0")]
			[Serializable]
			public struct IzakayaMapping
			{
				// Token: 0x04003F81 RID: 16257
				[Token(Token = "0x4003F81")]
				[FieldOffset(Offset = "0x0")]
				[SerializeField]
				public int sourceId;

				// Token: 0x04003F82 RID: 16258
				[Token(Token = "0x4003F82")]
				[FieldOffset(Offset = "0x4")]
				[SerializeField]
				public int targetId;
			}
		}

		// Token: 0x02000BC1 RID: 3009
		[Token(Token = "0x2000BC1")]
		[Serializable]
		public struct Day
		{
			// Token: 0x060046C3 RID: 18115 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60046C3")]
			[Address(RVA = "0x73DC40", Offset = "0x73C640", VA = "0x18073DC40", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x060046C4 RID: 18116 RVA: 0x00019710 File Offset: 0x00017910
			[Token(Token = "0x60046C4")]
			[Address(RVA = "0x73DC20", Offset = "0x73C620", VA = "0x18073DC20")]
			private int GetDayCount()
			{
				return 0;
			}

			// Token: 0x060046C5 RID: 18117 RVA: 0x00019728 File Offset: 0x00017928
			[Token(Token = "0x60046C5")]
			[Address(RVA = "0x73DB80", Offset = "0x73C580", VA = "0x18073DB80")]
			public int GetAbsoluteDay()
			{
				return 0;
			}

			// Token: 0x04003F83 RID: 16259
			[Token(Token = "0x4003F83")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public SchedulerNode.Day.DayType dayType;

			// Token: 0x04003F84 RID: 16260
			[Token(Token = "0x4003F84")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public SchedulerNode.Day.CalculateType dayCalcType;

			// Token: 0x04003F85 RID: 16261
			[Token(Token = "0x4003F85")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public int day;

			// Token: 0x04003F86 RID: 16262
			[Token(Token = "0x4003F86")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			public Vector2Int dayRange;

			// Token: 0x02000BC2 RID: 3010
			[Token(Token = "0x2000BC2")]
			public enum CalculateType
			{
				// Token: 0x04003F88 RID: 16264
				[Token(Token = "0x4003F88")]
				Constant,
				// Token: 0x04003F89 RID: 16265
				[Token(Token = "0x4003F89")]
				Random
			}

			// Token: 0x02000BC3 RID: 3011
			[Token(Token = "0x2000BC3")]
			public enum DayType
			{
				// Token: 0x04003F8B RID: 16267
				[Token(Token = "0x4003F8B")]
				Relative,
				// Token: 0x04003F8C RID: 16268
				[Token(Token = "0x4003F8C")]
				Absolute
			}
		}

		// Token: 0x02000BC4 RID: 3012
		[Token(Token = "0x2000BC4")]
		[Serializable]
		public struct Event
		{
			// Token: 0x060046C6 RID: 18118 RVA: 0x00019740 File Offset: 0x00017940
			[Token(Token = "0x60046C6")]
			[Address(RVA = "0x73DD60", Offset = "0x73C760", VA = "0x18073DD60")]
			public static SchedulerNode.Event DialogEvent(DialogPackage dialogPackage)
			{
				return default(SchedulerNode.Event);
			}

			// Token: 0x060046C7 RID: 18119 RVA: 0x00019758 File Offset: 0x00017958
			[Token(Token = "0x60046C7")]
			[Address(RVA = "0x73DDA0", Offset = "0x73C7A0", VA = "0x18073DDA0")]
			public static SchedulerNode.Event TimelineEvent(PlayableAsset timeline)
			{
				return default(SchedulerNode.Event);
			}

			// Token: 0x060046C8 RID: 18120 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60046C8")]
			[Address(RVA = "0x73DDE0", Offset = "0x73C7E0", VA = "0x18073DDE0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04003F8D RID: 16269
			[Token(Token = "0x4003F8D")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public SchedulerNode.Event.EventType eventType;

			// Token: 0x04003F8E RID: 16270
			[Token(Token = "0x4003F8E")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public AssetReference eventTimeline;

			// Token: 0x04003F8F RID: 16271
			[Token(Token = "0x4003F8F")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public AssetReference eventDialogPackage;

			// Token: 0x04003F90 RID: 16272
			[Token(Token = "0x4003F90")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public PlayableAsset runtimeTimeline;

			// Token: 0x04003F91 RID: 16273
			[Token(Token = "0x4003F91")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			public DialogPackage runtimeDialogPackage;

			// Token: 0x04003F92 RID: 16274
			[Token(Token = "0x4003F92")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			public bool doNotHideBackgroundUIInDialog;

			// Token: 0x02000BC5 RID: 3013
			[Token(Token = "0x2000BC5")]
			public enum EventType
			{
				// Token: 0x04003F94 RID: 16276
				[Token(Token = "0x4003F94")]
				Null,
				// Token: 0x04003F95 RID: 16277
				[Token(Token = "0x4003F95")]
				Timeline,
				// Token: 0x04003F96 RID: 16278
				[Token(Token = "0x4003F96")]
				Dialog
			}
		}

		// Token: 0x02000BC6 RID: 3014
		[Token(Token = "0x2000BC6")]
		[Serializable]
		public struct Character : IEquatable<SchedulerNode.Character>
		{
			// Token: 0x060046C9 RID: 18121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60046C9")]
			[Address(RVA = "0x41AF60", Offset = "0x419960", VA = "0x18041AF60")]
			public Character(SceneDirector.Identity characterIdentity, int characterId)
			{
			}

			// Token: 0x060046CA RID: 18122 RVA: 0x00019770 File Offset: 0x00017970
			[Token(Token = "0x60046CA")]
			[Address(RVA = "0x734DC0", Offset = "0x7337C0", VA = "0x180734DC0", Slot = "4")]
			public bool Equals(SchedulerNode.Character other)
			{
				return default(bool);
			}

			// Token: 0x060046CB RID: 18123 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60046CB")]
			[Address(RVA = "0x734DE0", Offset = "0x7337E0", VA = "0x180734DE0")]
			public LanguageBase GetLanguageData()
			{
				return null;
			}

			// Token: 0x060046CC RID: 18124 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60046CC")]
			[Address(RVA = "0x734E10", Offset = "0x733810", VA = "0x180734E10")]
			public CharacterSpriteSetCompact GetVisual()
			{
				return null;
			}

			// Token: 0x060046CD RID: 18125 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60046CD")]
			[Address(RVA = "0x734EB0", Offset = "0x7338B0", VA = "0x180734EB0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04003F97 RID: 16279
			[Token(Token = "0x4003F97")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public SceneDirector.Identity characterIdentity;

			// Token: 0x04003F98 RID: 16280
			[Token(Token = "0x4003F98")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public int characterId;
		}

		// Token: 0x02000BC7 RID: 3015
		[Token(Token = "0x2000BC7")]
		[Serializable]
		public struct ScheduledEvent
		{
			// Token: 0x060046CE RID: 18126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60046CE")]
			[Address(RVA = "0x7409E0", Offset = "0x73F3E0", VA = "0x1807409E0")]
			public ScheduledEvent(SchedulerNode.Trigger trigger, SchedulerNode.Event eventData)
			{
			}

			// Token: 0x060046CF RID: 18127 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60046CF")]
			[Address(RVA = "0x7408E0", Offset = "0x73F2E0", VA = "0x1807408E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04003F99 RID: 16281
			[Token(Token = "0x4003F99")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public SchedulerNode.Trigger trigger;

			// Token: 0x04003F9A RID: 16282
			[Token(Token = "0x4003F9A")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			public SchedulerNode.Event eventData;
		}

		// Token: 0x02000BC8 RID: 3016
		[Token(Token = "0x2000BC8")]
		[Serializable]
		public struct Reward
		{
			// Token: 0x060046D0 RID: 18128 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60046D0")]
			[Address(RVA = "0x73F7A0", Offset = "0x73E1A0", VA = "0x18073F7A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04003F9B RID: 16283
			[Token(Token = "0x4003F9B")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public SchedulerNode.Reward.RewardType rewardType;

			// Token: 0x04003F9C RID: 16284
			[Token(Token = "0x4003F9C")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public string rewardId;

			// Token: 0x04003F9D RID: 16285
			[Token(Token = "0x4003F9D")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string rewardAltId;

			// Token: 0x04003F9E RID: 16286
			[Token(Token = "0x4003F9E")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public string rewardAltAltId;

			// Token: 0x04003F9F RID: 16287
			[Token(Token = "0x4003F9F")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			public string[] rewardIdArray;

			// Token: 0x04003FA0 RID: 16288
			[Token(Token = "0x4003FA0")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			public int[] rewardIntArray;

			// Token: 0x04003FA1 RID: 16289
			[Token(Token = "0x4003FA1")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			public SchedulerNode.Day time;

			// Token: 0x04003FA2 RID: 16290
			[Token(Token = "0x4003FA2")]
			[FieldOffset(Offset = "0x44")]
			[SerializeField]
			public int id;

			// Token: 0x04003FA3 RID: 16291
			[Token(Token = "0x4003FA3")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			public RunTimePlayerData.PopType popType;

			// Token: 0x04003FA4 RID: 16292
			[Token(Token = "0x4003FA4")]
			[FieldOffset(Offset = "0x4C")]
			[SerializeField]
			public RunTimePlayerData.TagType tagType;

			// Token: 0x04003FA5 RID: 16293
			[Token(Token = "0x4003FA5")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			public SchedulerNode.Reward.ObjectType objectType;

			// Token: 0x04003FA6 RID: 16294
			[Token(Token = "0x4003FA6")]
			[FieldOffset(Offset = "0x54")]
			[SerializeField]
			public bool should;

			// Token: 0x04003FA7 RID: 16295
			[Token(Token = "0x4003FA7")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public float value;

			// Token: 0x04003FA8 RID: 16296
			[Token(Token = "0x4003FA8")]
			[FieldOffset(Offset = "0x5C")]
			[SerializeField]
			public Vector2 position;

			// Token: 0x04003FA9 RID: 16297
			[Token(Token = "0x4003FA9")]
			[FieldOffset(Offset = "0x64")]
			[SerializeField]
			public NightSceneDirector.ChallengeType challengeType;

			// Token: 0x02000BC9 RID: 3017
			[Token(Token = "0x2000BC9")]
			public enum ObjectType
			{
				// Token: 0x04003FAB RID: 16299
				[Token(Token = "0x4003FAB")]
				Food,
				// Token: 0x04003FAC RID: 16300
				[Token(Token = "0x4003FAC")]
				Ingredient,
				// Token: 0x04003FAD RID: 16301
				[Token(Token = "0x4003FAD")]
				Beverage,
				// Token: 0x04003FAE RID: 16302
				[Token(Token = "0x4003FAE")]
				Item,
				// Token: 0x04003FAF RID: 16303
				[Token(Token = "0x4003FAF")]
				Recipe,
				// Token: 0x04003FB0 RID: 16304
				[Token(Token = "0x4003FB0")]
				Izakaya,
				// Token: 0x04003FB1 RID: 16305
				[Token(Token = "0x4003FB1")]
				Partner,
				// Token: 0x04003FB2 RID: 16306
				[Token(Token = "0x4003FB2")]
				Badge,
				// Token: 0x04003FB3 RID: 16307
				[Token(Token = "0x4003FB3")]
				Cooker
			}

			// Token: 0x02000BCA RID: 3018
			[Token(Token = "0x2000BCA")]
			public enum RewardType
			{
				// Token: 0x04003FB5 RID: 16309
				[Token(Token = "0x4003FB5")]
				[InspectorName("解锁NPC")]
				UnlockNPC,
				// Token: 0x04003FB6 RID: 16310
				[Token(Token = "0x4003FB6")]
				[InspectorName("计划新闻")]
				ScheduleNews,
				// Token: 0x04003FB7 RID: 16311
				[Token(Token = "0x4003FB7")]
				[InspectorName("取消被计划的新闻")]
				DismissNews,
				// Token: 0x04003FB8 RID: 16312
				[Token(Token = "0x4003FB8")]
				[InspectorName("修改流行系统")]
				ModifyPopSystem,
				// Token: 0x04003FB9 RID: 16313
				[Token(Token = "0x4003FB9")]
				[InspectorName("开关采集点")]
				ToggleResourcePoint,
				// Token: 0x04003FBA RID: 16314
				[Token(Token = "0x4003FBA")]
				[InspectorName("设置全局客人携带金额因子")]
				SetGlobalGuestFundModifier,
				// Token: 0x04003FBB RID: 16315
				[Token(Token = "0x4003FBB")]
				[InspectorName("设置具体物品价格因子")]
				SetObjectPriceModifier,
				// Token: 0x04003FBC RID: 16316
				[Token(Token = "0x4003FBC")]
				[InspectorName("【已弃用】取消被计划的事件")]
				DismissEvents,
				// Token: 0x04003FBD RID: 16317
				[Token(Token = "0x4003FBD")]
				[InspectorName("移动NPC到给定位置")]
				RequestNPC,
				// Token: 0x04003FBE RID: 16318
				[Token(Token = "0x4003FBE")]
				[InspectorName("将NPC移动回原位置")]
				DismissNPC,
				// Token: 0x04003FBF RID: 16319
				[Token(Token = "0x4003FBF")]
				[InspectorName("将目标对话加入给定NPC的对话池")]
				AddNPCDialog,
				// Token: 0x04003FC0 RID: 16320
				[Token(Token = "0x4003FC0")]
				[InspectorName("将目标对话从给定NPC的对话池移除")]
				RemoveNPCDialog,
				// Token: 0x04003FC1 RID: 16321
				[Token(Token = "0x4003FC1")]
				[InspectorName("设置可互动物品的可用性")]
				ToggleInteractableEntity,
				// Token: 0x04003FC2 RID: 16322
				[Token(Token = "0x4003FC2")]
				[InspectorName("解锁地图")]
				UnlockMap,
				// Token: 0x04003FC3 RID: 16323
				[Token(Token = "0x4003FC3")]
				[InspectorName("设置按钮是否可以互动")]
				SetEnableInteractablesUI,
				// Token: 0x04003FC4 RID: 16324
				[Token(Token = "0x4003FC4")]
				[InspectorName("【已弃用】设置覆写雀食堂的ID")]
				SetIzakayaIndex,
				// Token: 0x04003FC5 RID: 16325
				[Token(Token = "0x4003FC5")]
				[InspectorName("获得给定物品")]
				GiveItem,
				// Token: 0x04003FC6 RID: 16326
				[Token(Token = "0x4003FC6")]
				[InspectorName("设置白天稀有NPC的")]
				SetDaySpecialNPCVisibility,
				// Token: 0x04003FC7 RID: 16327
				[Token(Token = "0x4003FC7")]
				[InspectorName("设置NPC的对话池")]
				SetNPCDialog,
				// Token: 0x04003FC8 RID: 16328
				[Token(Token = "0x4003FC8")]
				[InspectorName("将稀客的羁绊等级提升一级")]
				UpgradeKizunaLevel,
				// Token: 0x04003FC9 RID: 16329
				[Token(Token = "0x4003FC9")]
				[InspectorName("设置玩家是否能让稀客达到5级羁绊")]
				SetCanHaveLevel5Kizuna,
				// Token: 0x04003FCA RID: 16330
				[Token(Token = "0x4003FCA")]
				[InspectorName("获得目标数量的金钱")]
				GetFund,
				// Token: 0x04003FCB RID: 16331
				[Token(Token = "0x4003FCB")]
				[InspectorName("设置任务切换物品的开启状态")]
				ToggleSwitchEntity,
				// Token: 0x04003FCC RID: 16332
				[Token(Token = "0x4003FCC")]
				[InspectorName("设置等级限制")]
				SetLevelCap,
				// Token: 0x04003FCD RID: 16333
				[Token(Token = "0x4003FCD")]
				[InspectorName("设置是否会生成因幡帝")]
				CouldSpawnTewi,
				// Token: 0x04003FCE RID: 16334
				[Token(Token = "0x4003FCE")]
				[InspectorName("设置当天晚上因幡帝是否会被生成")]
				TewiSpawnTonight,
				// Token: 0x04003FCF RID: 16335
				[Token(Token = "0x4003FCF")]
				[InspectorName("获得灵梦的保护")]
				AskReimuProtectYou,
				// Token: 0x04003FD0 RID: 16336
				[Token(Token = "0x4003FD0")]
				[InspectorName("将目标物品加入香霖堂")]
				AddToKourindoStaticMerchandise,
				// Token: 0x04003FD1 RID: 16337
				[Token(Token = "0x4003FD1")]
				[InspectorName("开启多伙伴模式")]
				EnableMultiPartnerMode,
				// Token: 0x04003FD2 RID: 16338
				[Token(Token = "0x4003FD2")]
				[InspectorName("设置可用的最大伙伴数量")]
				SetPartnerCount,
				// Token: 0x04003FD3 RID: 16339
				[Token(Token = "0x4003FD3")]
				[InspectorName("前往给定的挑战模式")]
				MoveToChallenge,
				// Token: 0x04003FD4 RID: 16340
				[Token(Token = "0x4003FD4")]
				[InspectorName("取消被计划的目标事件")]
				CancelEvent,
				// Token: 0x04003FD5 RID: 16341
				[Token(Token = "0x4003FD5")]
				[InspectorName("前往制作人员名单场景")]
				MoveToStaff,
				// Token: 0x04003FD6 RID: 16342
				[Token(Token = "0x4003FD6")]
				[InspectorName("设置稀客是否生成")]
				EnableSpecialGuestSpawnInNight,
				// Token: 0x04003FD7 RID: 16343
				[Token(Token = "0x4003FD7")]
				[InspectorName("设置稀客在指定雀食堂生成（通过雀食堂Id）")]
				EnableSGuestSpawnInTargetIzakayaById,
				// Token: 0x04003FD8 RID: 16344
				[Token(Token = "0x4003FD8")]
				[InspectorName("设置稀客在指定地图对应的雀食堂生成（通过地图Label）")]
				EnableSGuestSpawnInTargetIzakayaByMap,
				// Token: 0x04003FD9 RID: 16345
				[Token(Token = "0x4003FD9")]
				[InspectorName("解锁对应稀客的笔记本图鉴")]
				UnlockSGuestInNotebook,
				// Token: 0x04003FDA RID: 16346
				[Token(Token = "0x4003FDA")]
				[InspectorName("使对应任务的全部条件完成")]
				SetTargetMissionFulfilled,
				// Token: 0x04003FDB RID: 16347
				[Token(Token = "0x4003FDB")]
				[InspectorName("解锁音游章节")]
				UnlockMusicGameChapter,
				// Token: 0x04003FDC RID: 16348
				[Token(Token = "0x4003FDC")]
				[InspectorName("尝试移除香霖堂的货物")]
				RemoveKourindouMerchandise,
				// Token: 0x04003FDD RID: 16349
				[Token(Token = "0x4003FDD")]
				[InspectorName("完成伪造任务")]
				FinishFakeMission,
				// Token: 0x04003FDE RID: 16350
				[Token(Token = "0x4003FDE")]
				[InspectorName("强制完成计划中的任务")]
				ForceCompleteMission,
				// Token: 0x04003FDF RID: 16351
				[Token(Token = "0x4003FDF")]
				[InspectorName("刷新随机生成的NPC")]
				RefreshRandomSpawnNpc,
				// Token: 0x04003FE0 RID: 16352
				[Token(Token = "0x4003FE0")]
				[InspectorName("添加固定菜谱")]
				AddLockedRecipe,
				// Token: 0x04003FE1 RID: 16353
				[Token(Token = "0x4003FE1")]
				[InspectorName("移除固定菜谱")]
				ClearLockedRecipe,
				// Token: 0x04003FE2 RID: 16354
				[Token(Token = "0x4003FE2")]
				[InspectorName("添加稀客映射")]
				AddEffectiveSGuestMapping,
				// Token: 0x04003FE3 RID: 16355
				[Token(Token = "0x4003FE3")]
				[InspectorName("移除稀客映射")]
				RemoveEffectiveSGuestMapping,
				// Token: 0x04003FE4 RID: 16356
				[Token(Token = "0x4003FE4")]
				[InspectorName("完成目标事件")]
				FinishEvent,
				// Token: 0x04003FE5 RID: 16357
				[Token(Token = "0x4003FE5")]
				[InspectorName("仅白天：开始或继续RogueLike")]
				StartOrContinueRogueLike,
				// Token: 0x04003FE6 RID: 16358
				[Token(Token = "0x4003FE6")]
				[InspectorName("随机选取一位稀客加入控制计划")]
				ControlSpecialGuestScheduled,
				// Token: 0x04003FE7 RID: 16359
				[Token(Token = "0x4003FE7")]
				[InspectorName("移除控制计划中尚未被控制的稀客")]
				CancelControlSpecialGuestScheduled,
				// Token: 0x04003FE8 RID: 16360
				[Token(Token = "0x4003FE8")]
				[InspectorName("指定一位稀客今晚不会到店")]
				IgnoreSpecialGuest,
				// Token: 0x04003FE9 RID: 16361
				[Token(Token = "0x4003FE9")]
				[InspectorName("添加DLC锁")]
				AddDLCLock,
				// Token: 0x04003FEA RID: 16362
				[Token(Token = "0x4003FEA")]
				[InspectorName("移除DLC锁")]
				RemoveDLCLock,
				// Token: 0x04003FEB RID: 16363
				[Token(Token = "0x4003FEB")]
				[InspectorName("停止SceneDirector中所有非托管的协程")]
				StopAllUnmanagedMovingProcess,
				// Token: 0x04003FEC RID: 16364
				[Token(Token = "0x4003FEC")]
				[InspectorName("提示稀客开始全图刷新")]
				NotifySpecialGuestSpawnInNight,
				// Token: 0x04003FED RID: 16365
				[Token(Token = "0x4003FED")]
				[InspectorName("设置PlayerPref")]
				SetAndSavePlayerPref
			}
		}
	}
}

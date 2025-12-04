using System;
using System.Runtime.CompilerServices;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile.SchedulerNodeCollection
{
	// Token: 0x02000D1D RID: 3357
	[Token(Token = "0x2000D1D")]
	[CreateAssetMenu(fileName = "Mission", menuName = "GameData Profile/Scheduler Node/Mission", order = 0)]
	public class MissionNode : SchedulerNode
	{
		// Token: 0x06004E1B RID: 19995 RVA: 0x0001C590 File Offset: 0x0001A790
		[Token(Token = "0x6004E1B")]
		[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "4")]
		public override SchedulerNode.NodeType GetNodeType()
		{
			return SchedulerNode.NodeType.Event;
		}

		// Token: 0x06004E1C RID: 19996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E1C")]
		[Address(RVA = "0x7B2A00", Offset = "0x7B1400", VA = "0x1807B2A00", Slot = "5")]
		protected override void PostIntializeClone(SchedulerNode instance)
		{
		}

		// Token: 0x06004E1D RID: 19997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E1D")]
		[Address(RVA = "0x7B29A0", Offset = "0x7B13A0", VA = "0x1807B29A0", Slot = "6")]
		protected override Type InternalGetNodeType()
		{
			return null;
		}

		// Token: 0x06004E1E RID: 19998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E1E")]
		[Address(RVA = "0x7B2C80", Offset = "0x7B1680", VA = "0x1807B2C80")]
		public MissionNode()
		{
		}

		// Token: 0x0400478A RID: 18314
		[Token(Token = "0x400478A")]
		[FieldOffset(Offset = "0x60")]
		public bool isTimedMission;

		// Token: 0x0400478B RID: 18315
		[Token(Token = "0x400478B")]
		[FieldOffset(Offset = "0x61")]
		public bool loopedMission;

		// Token: 0x0400478C RID: 18316
		[Token(Token = "0x400478C")]
		[FieldOffset(Offset = "0x68")]
		public SchedulerNode.Trigger missionTimeLimit;

		// Token: 0x0400478D RID: 18317
		[Token(Token = "0x400478D")]
		[FieldOffset(Offset = "0xD0")]
		public SchedulerNode.Event missionFailedEvent;

		// Token: 0x0400478E RID: 18318
		[Token(Token = "0x400478E")]
		[FieldOffset(Offset = "0x100")]
		public MissionNode.MissionFailedAction missionFailedAction;

		// Token: 0x0400478F RID: 18319
		[Token(Token = "0x400478F")]
		[FieldOffset(Offset = "0x104")]
		public bool hasSender;

		// Token: 0x04004790 RID: 18320
		[Token(Token = "0x4004790")]
		[FieldOffset(Offset = "0x108")]
		public string sender;

		// Token: 0x04004791 RID: 18321
		[Token(Token = "0x4004791")]
		[FieldOffset(Offset = "0x110")]
		public bool hasReciever;

		// Token: 0x04004792 RID: 18322
		[Token(Token = "0x4004792")]
		[FieldOffset(Offset = "0x118")]
		public string reciever;

		// Token: 0x04004793 RID: 18323
		[Token(Token = "0x4004793")]
		[FieldOffset(Offset = "0x120")]
		public bool hideReciever;

		// Token: 0x04004794 RID: 18324
		[Token(Token = "0x4004794")]
		[FieldOffset(Offset = "0x128")]
		public MissionNode.FinishCondition[] finishCondition;

		// Token: 0x04004795 RID: 18325
		[Token(Token = "0x4004795")]
		[FieldOffset(Offset = "0x130")]
		public SchedulerNode.Event missionFinishEvent;

		// Token: 0x02000D1E RID: 3358
		[Token(Token = "0x2000D1E")]
		public enum MissionFailedAction
		{
			// Token: 0x04004797 RID: 18327
			[Token(Token = "0x4004797")]
			BackToMainMenu,
			// Token: 0x04004798 RID: 18328
			[Token(Token = "0x4004798")]
			Rewind,
			// Token: 0x04004799 RID: 18329
			[Token(Token = "0x4004799")]
			None
		}

		// Token: 0x02000D1F RID: 3359
		[Token(Token = "0x2000D1F")]
		[Serializable]
		public struct FinishCondition
		{
			// Token: 0x06004E1F RID: 19999 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E1F")]
			[Address(RVA = "0x6086B0", Offset = "0x6070B0", VA = "0x1806086B0")]
			public void SetMissionLabel(string missionLabel)
			{
			}

			// Token: 0x06004E20 RID: 20000 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E20")]
			[Address(RVA = "0x7ACC80", Offset = "0x7AB680", VA = "0x1807ACC80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06004E21 RID: 20001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E21")]
			[Address(RVA = "0x7ABE70", Offset = "0x7AA870", VA = "0x1807ABE70")]
			public string GetText(RunTimeScheduler.MissionStatus missionStatus)
			{
				return null;
			}

			// Token: 0x06004E22 RID: 20002 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E22")]
			[Address(RVA = "0x7AC0D0", Offset = "0x7AAAD0", VA = "0x1807AC0D0")]
			public string GetText()
			{
				return null;
			}

			// Token: 0x06004E23 RID: 20003 RVA: 0x0001C5A8 File Offset: 0x0001A7A8
			[Token(Token = "0x6004E23")]
			[Address(RVA = "0x7ABA30", Offset = "0x7AA430", VA = "0x1807ABA30", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06004E24 RID: 20004 RVA: 0x0001C5C0 File Offset: 0x0001A7C0
			[Token(Token = "0x6004E24")]
			[Address(RVA = "0x7ABCA0", Offset = "0x7AA6A0", VA = "0x1807ABCA0", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06004E25 RID: 20005 RVA: 0x0001C5D8 File Offset: 0x0001A7D8
			[Token(Token = "0x6004E25")]
			[Address(RVA = "0x7AD970", Offset = "0x7AC370", VA = "0x1807AD970")]
			public static bool operator ==(MissionNode.FinishCondition left, MissionNode.FinishCondition right)
			{
				return default(bool);
			}

			// Token: 0x06004E26 RID: 20006 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
			[Token(Token = "0x6004E26")]
			[Address(RVA = "0x7ADA20", Offset = "0x7AC420", VA = "0x1807ADA20")]
			public static bool operator !=(MissionNode.FinishCondition left, MissionNode.FinishCondition right)
			{
				return default(bool);
			}

			// Token: 0x06004E27 RID: 20007 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E27")]
			[Address(RVA = "0x7AD690", Offset = "0x7AC090", VA = "0x1807AD690")]
			[CompilerGenerated]
			internal static string <GetText>g__AddColor|20_0(string text, string colorLabel)
			{
				return null;
			}

			// Token: 0x06004E28 RID: 20008 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E28")]
			[Address(RVA = "0x7AD8B0", Offset = "0x7AC2B0", VA = "0x1807AD8B0")]
			[CompilerGenerated]
			internal static string <GetText>g__AddStrikeThrough|20_1(string text)
			{
				return null;
			}

			// Token: 0x06004E29 RID: 20009 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E29")]
			[Address(RVA = "0x6028B0", Offset = "0x6012B0", VA = "0x1806028B0")]
			[CompilerGenerated]
			internal static string <GetText>g__GetTitleKWD|21_0(string key)
			{
				return null;
			}

			// Token: 0x06004E2A RID: 20010 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004E2A")]
			[Address(RVA = "0x7AD900", Offset = "0x7AC300", VA = "0x1807AD900")]
			[CompilerGenerated]
			internal static string <GetText>g__GetTitleKWD_1|21_1(string key, string data)
			{
				return null;
			}

			// Token: 0x0400479A RID: 18330
			[Token(Token = "0x400479A")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public MissionNode.FinishCondition.ConditionType conditionType;

			// Token: 0x0400479B RID: 18331
			[Token(Token = "0x400479B")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public int amount;

			// Token: 0x0400479C RID: 18332
			[Token(Token = "0x400479C")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public int tag;

			// Token: 0x0400479D RID: 18333
			[Token(Token = "0x400479D")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public int[] tags;

			// Token: 0x0400479E RID: 18334
			[Token(Token = "0x400479E")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public string label;

			// Token: 0x0400479F RID: 18335
			[Token(Token = "0x400479F")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			public string additionalString;

			// Token: 0x040047A0 RID: 18336
			[Token(Token = "0x40047A0")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			public Product product;

			// Token: 0x040047A1 RID: 18337
			[Token(Token = "0x40047A1")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			public Sellable.SellableType sellableType;

			// Token: 0x040047A2 RID: 18338
			[Token(Token = "0x40047A2")]
			[FieldOffset(Offset = "0x44")]
			[SerializeField]
			public bool valify;

			// Token: 0x040047A3 RID: 18339
			[Token(Token = "0x40047A3")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			public string additionalString2;

			// Token: 0x040047A4 RID: 18340
			[Token(Token = "0x40047A4")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			public string additionalString3;

			// Token: 0x040047A5 RID: 18341
			[Token(Token = "0x40047A5")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public string additionalString4;

			// Token: 0x040047A6 RID: 18342
			[Token(Token = "0x40047A6")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public string[] labels;

			// Token: 0x040047A7 RID: 18343
			[Token(Token = "0x40047A7")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			public MissionNode.FinishCondition.KeyValuePair[] labelKeyValuePairs;

			// Token: 0x040047A8 RID: 18344
			[Token(Token = "0x40047A8")]
			[FieldOffset(Offset = "0x70")]
			[SerializeField]
			public bool contradictionCheck;

			// Token: 0x040047A9 RID: 18345
			[Token(Token = "0x40047A9")]
			[FieldOffset(Offset = "0x78")]
			private string missionLabel;

			// Token: 0x02000D20 RID: 3360
			[Token(Token = "0x2000D20")]
			public enum CharacterType
			{
				// Token: 0x040047AB RID: 18347
				[Token(Token = "0x40047AB")]
				Normal,
				// Token: 0x040047AC RID: 18348
				[Token(Token = "0x40047AC")]
				Special
			}

			// Token: 0x02000D21 RID: 3361
			[Token(Token = "0x2000D21")]
			public enum ConditionType
			{
				// Token: 0x040047AE RID: 18350
				[Token(Token = "0x40047AE")]
				[InspectorName("还债")]
				BillRepayment,
				// Token: 0x040047AF RID: 18351
				[Token(Token = "0x40047AF")]
				[InspectorName("和角色交谈")]
				TalkWithCharacter,
				// Token: 0x040047B0 RID: 18352
				[Token(Token = "0x40047B0")]
				[InspectorName("调查白天交互物品")]
				InspectInteractable,
				// Token: 0x040047B1 RID: 18353
				[Token(Token = "0x40047B1")]
				[InspectorName("交付目标物品")]
				SubmitItem,
				// Token: 0x040047B2 RID: 18354
				[Token(Token = "0x40047B2")]
				[InspectorName("请角色品尝料理")]
				ServeInWork,
				// Token: 0x040047B3 RID: 18355
				[Token(Token = "0x40047B3")]
				[InspectorName("交付包含Tag的对应物品")]
				SubmitByTag,
				// Token: 0x040047B4 RID: 18356
				[Token(Token = "0x40047B4")]
				[InspectorName("交付包含多个Tag的对应物品")]
				SubmitByTags,
				// Token: 0x040047B5 RID: 18357
				[Token(Token = "0x40047B5")]
				[InspectorName("在工作中售卖料理")]
				SellInWork,
				// Token: 0x040047B6 RID: 18358
				[Token(Token = "0x40047B6")]
				[InspectorName("交付包含食材的料理")]
				SubmitByIngredients,
				// Token: 0x040047B7 RID: 18359
				[Token(Token = "0x40047B7")]
				[InspectorName("完成以下任务中的几个")]
				CompleteSpecifiedFollowingTasks,
				// Token: 0x040047B8 RID: 18360
				[Token(Token = "0x40047B8")]
				[InspectorName("(完成以下任务中的几个)操作的任务条件")]
				CompleteSpecifiedFollowingTasksSubCondition,
				// Token: 0x040047B9 RID: 18361
				[Token(Token = "0x40047B9")]
				[InspectorName("达到目标角色的羁绊等级LV")]
				ReachTargetCharacterKisunaLevel,
				// Token: 0x040047BA RID: 18362
				[Token(Token = "0x40047BA")]
				[InspectorName("表示某种事情发生(不会自动完成，需要手动完成或者取消计划)")]
				FakeMission,
				// Token: 0x040047BB RID: 18363
				[Token(Token = "0x40047BB")]
				[InspectorName("交付包含任意一个Tag的对应物品")]
				SubmitByAnyOneTag,
				// Token: 0x040047BC RID: 18364
				[Token(Token = "0x40047BC")]
				[InspectorName("完成以下事件中的X(指定数量)个")]
				CompleteSpecifiedFollowingEvents,
				// Token: 0x040047BD RID: 18365
				[Token(Token = "0x40047BD")]
				[InspectorName("交付指定Level的对应物品")]
				SubmitByLevel
			}

			// Token: 0x02000D22 RID: 3362
			[Token(Token = "0x2000D22")]
			[Serializable]
			public struct KeyValuePair
			{
				// Token: 0x040047BE RID: 18366
				[Token(Token = "0x40047BE")]
				[FieldOffset(Offset = "0x0")]
				public string Key;

				// Token: 0x040047BF RID: 18367
				[Token(Token = "0x40047BF")]
				[FieldOffset(Offset = "0x8")]
				public string Value;
			}
		}
	}
}

using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x020004CA RID: 1226
	[Token(Token = "0x20004CA")]
	[GenerateCleanupMethod]
	public class SchedulerConditionComponent : EntityConditionComponent
	{
		// Token: 0x06001BDA RID: 7130 RVA: 0x0000AB48 File Offset: 0x00008D48
		[Token(Token = "0x6001BDA")]
		[Address(RVA = "0x4A1D80", Offset = "0x4A0780", VA = "0x1804A1D80", Slot = "6")]
		protected override bool ShouldFadeOut()
		{
			return default(bool);
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0000AB60 File Offset: 0x00008D60
		[Token(Token = "0x6001BDB")]
		[Address(RVA = "0x4A1CD0", Offset = "0x4A06D0", VA = "0x1804A1CD0", Slot = "9")]
		protected override bool OnGetAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0000AB78 File Offset: 0x00008D78
		[Token(Token = "0x6001BDC")]
		[Address(RVA = "0x4A1A70", Offset = "0x4A0470", VA = "0x1804A1A70")]
		public static bool Finished(SchedulerConditionComponent.SchedulerData schedulerData)
		{
			return default(bool);
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BDD")]
		[Address(RVA = "0x4A1C70", Offset = "0x4A0670", VA = "0x1804A1C70", Slot = "4")]
		protected override Type GetComponentType()
		{
			return null;
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BDE")]
		[Address(RVA = "0x494090", Offset = "0x492A90", VA = "0x180494090", Slot = "10")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BDF")]
		[Address(RVA = "0x4A1D90", Offset = "0x4A0790", VA = "0x1804A1D90")]
		public SchedulerConditionComponent()
		{
		}

		// Token: 0x04001975 RID: 6517
		[Token(Token = "0x4001975")]
		[FieldOffset(Offset = "0x40")]
		[CleanupIgnore]
		public SchedulerConditionComponent.SchedulerData[] conditions;

		// Token: 0x04001976 RID: 6518
		[Token(Token = "0x4001976")]
		[FieldOffset(Offset = "0x48")]
		public bool inverse;

		// Token: 0x04001977 RID: 6519
		[Token(Token = "0x4001977")]
		[FieldOffset(Offset = "0x49")]
		public bool shouldFadeOut;

		// Token: 0x020004CB RID: 1227
		[Token(Token = "0x20004CB")]
		[Serializable]
		public struct SchedulerData
		{
			// Token: 0x04001978 RID: 6520
			[Token(Token = "0x4001978")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public SchedulerNode.NodeType nodeType;

			// Token: 0x04001979 RID: 6521
			[Token(Token = "0x4001979")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public string nodeKey;

			// Token: 0x0400197A RID: 6522
			[Token(Token = "0x400197A")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public SchedulerConditionComponent.SchedulerData.Condition status;

			// Token: 0x020004CC RID: 1228
			[Token(Token = "0x20004CC")]
			public enum Condition
			{
				// Token: 0x0400197C RID: 6524
				[Token(Token = "0x400197C")]
				Finished,
				// Token: 0x0400197D RID: 6525
				[Token(Token = "0x400197D")]
				InProgress,
				// Token: 0x0400197E RID: 6526
				[Token(Token = "0x400197E")]
				Unfinshed
			}
		}
	}
}

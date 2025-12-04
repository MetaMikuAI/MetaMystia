using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile.SchedulerNodeCollection
{
	// Token: 0x02000D1B RID: 3355
	[Token(Token = "0x2000D1B")]
	[CreateAssetMenu(fileName = "Event", menuName = "GameData Profile/Scheduler Node/Event", order = 0)]
	public class EventNode : SchedulerNode
	{
		// Token: 0x06004E17 RID: 19991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E17")]
		[Address(RVA = "0x7AB8B0", Offset = "0x7AA2B0", VA = "0x1807AB8B0", Slot = "5")]
		protected override void PostIntializeClone(SchedulerNode instance)
		{
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x0001C578 File Offset: 0x0001A778
		[Token(Token = "0x6004E18")]
		[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "4")]
		public override SchedulerNode.NodeType GetNodeType()
		{
			return SchedulerNode.NodeType.Event;
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E19")]
		[Address(RVA = "0x7AB850", Offset = "0x7AA250", VA = "0x1807AB850", Slot = "6")]
		protected override Type InternalGetNodeType()
		{
			return null;
		}

		// Token: 0x06004E1A RID: 19994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E1A")]
		[Address(RVA = "0x7ABA20", Offset = "0x7AA420", VA = "0x1807ABA20")]
		public EventNode()
		{
		}

		// Token: 0x0400477F RID: 18303
		[Token(Token = "0x400477F")]
		[FieldOffset(Offset = "0x60")]
		public bool scheduleOnce;

		// Token: 0x04004780 RID: 18304
		[Token(Token = "0x4004780")]
		[FieldOffset(Offset = "0x61")]
		public bool saveToArchiveOnce;

		// Token: 0x04004781 RID: 18305
		[Token(Token = "0x4004781")]
		[FieldOffset(Offset = "0x62")]
		public bool upgradeShopEvent;

		// Token: 0x04004782 RID: 18306
		[Token(Token = "0x4004782")]
		[FieldOffset(Offset = "0x63")]
		public bool autoCompleteAtDayEnd;

		// Token: 0x04004783 RID: 18307
		[Token(Token = "0x4004783")]
		[FieldOffset(Offset = "0x64")]
		public EventNode.EventLockMode eventLockMode;

		// Token: 0x04004784 RID: 18308
		[Token(Token = "0x4004784")]
		[FieldOffset(Offset = "0x68")]
		public SchedulerNode.ScheduledEvent scheduledEvent;

		// Token: 0x04004785 RID: 18309
		[Token(Token = "0x4004785")]
		[FieldOffset(Offset = "0x100")]
		public bool disableInNX;

		// Token: 0x02000D1C RID: 3356
		[Token(Token = "0x2000D1C")]
		public enum EventLockMode
		{
			// Token: 0x04004787 RID: 18311
			[Token(Token = "0x4004787")]
			None,
			// Token: 0x04004788 RID: 18312
			[Token(Token = "0x4004788")]
			Lock,
			// Token: 0x04004789 RID: 18313
			[Token(Token = "0x4004789")]
			Unlock
		}
	}
}

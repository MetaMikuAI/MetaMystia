using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile.SchedulerNodeCollection
{
	// Token: 0x02000D25 RID: 3365
	[Token(Token = "0x2000D25")]
	[CreateAssetMenu(fileName = "News", menuName = "GameData Profile/Scheduler Node/News", order = 0)]
	public class NewsNode : SchedulerNode
	{
		// Token: 0x06004E37 RID: 20023 RVA: 0x0001C608 File Offset: 0x0001A808
		[Token(Token = "0x6004E37")]
		[Address(RVA = "0x7B2C90", Offset = "0x7B1690", VA = "0x1807B2C90", Slot = "4")]
		public override SchedulerNode.NodeType GetNodeType()
		{
			return SchedulerNode.NodeType.Event;
		}

		// Token: 0x06004E38 RID: 20024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E38")]
		[Address(RVA = "0x7B2CA0", Offset = "0x7B16A0", VA = "0x1807B2CA0", Slot = "6")]
		protected override Type InternalGetNodeType()
		{
			return null;
		}

		// Token: 0x06004E39 RID: 20025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E39")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "5")]
		protected override void PostIntializeClone(SchedulerNode instance)
		{
		}

		// Token: 0x06004E3A RID: 20026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E3A")]
		[Address(RVA = "0x7ABA20", Offset = "0x7AA420", VA = "0x1807ABA20")]
		public NewsNode()
		{
		}
	}
}

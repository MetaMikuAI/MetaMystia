using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004EE RID: 1262
	[Token(Token = "0x20004EE")]
	[GenerateCleanupMethod]
	public class EventTriggerBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001C7B RID: 7291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7B")]
		[Address(RVA = "0x49D8B0", Offset = "0x49C2B0", VA = "0x18049D8B0", Slot = "7")]
		public override void OnPlayerEnter()
		{
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0000AD40 File Offset: 0x00008F40
		[Token(Token = "0x6001C7C")]
		[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "11")]
		protected override bool IsTriggerMode()
		{
			return default(bool);
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7D")]
		[Address(RVA = "0x493E90", Offset = "0x492890", VA = "0x180493E90", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7E")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public EventTriggerBehaviourComponent()
		{
		}

		// Token: 0x040019F6 RID: 6646
		[Token(Token = "0x40019F6")]
		[FieldOffset(Offset = "0x18")]
		public string triggerId;
	}
}

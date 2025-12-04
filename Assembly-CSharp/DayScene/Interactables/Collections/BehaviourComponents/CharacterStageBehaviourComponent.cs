using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine.Playables;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004D5 RID: 1237
	[Token(Token = "0x20004D5")]
	[GenerateCleanupMethod]
	public class CharacterStageBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001C08 RID: 7176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x493660", Offset = "0x492060", VA = "0x180493660", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C09")]
		[Address(RVA = "0x493620", Offset = "0x492020", VA = "0x180493620", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0A")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public CharacterStageBehaviourComponent()
		{
		}

		// Token: 0x0400199A RID: 6554
		[Token(Token = "0x400199A")]
		[FieldOffset(Offset = "0x18")]
		public CharacterStageBehaviourComponent.EventType eventType;

		// Token: 0x0400199B RID: 6555
		[Token(Token = "0x400199B")]
		[FieldOffset(Offset = "0x20")]
		public DialogPackage chatDialog;

		// Token: 0x0400199C RID: 6556
		[Token(Token = "0x400199C")]
		[FieldOffset(Offset = "0x28")]
		public PlayableAsset chatTimeline;

		// Token: 0x020004D6 RID: 1238
		[Token(Token = "0x20004D6")]
		public enum EventType : byte
		{
			// Token: 0x0400199E RID: 6558
			[Token(Token = "0x400199E")]
			Dialog,
			// Token: 0x0400199F RID: 6559
			[Token(Token = "0x400199F")]
			Timeline
		}
	}
}

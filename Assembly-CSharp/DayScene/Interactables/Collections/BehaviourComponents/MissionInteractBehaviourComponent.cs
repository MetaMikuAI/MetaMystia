using System;
using DayScene.Interactables.Collections.ConditionComponents;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004E2 RID: 1250
	[Token(Token = "0x20004E2")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(MissionInteractConditionComponent))]
	public class MissionInteractBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001C4B RID: 7243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4B")]
		[Address(RVA = "0x4A1620", Offset = "0x4A0020", VA = "0x1804A1620", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4C")]
		[Address(RVA = "0x4A15E0", Offset = "0x49FFE0", VA = "0x1804A15E0", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4D")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public MissionInteractBehaviourComponent()
		{
		}

		// Token: 0x040019D4 RID: 6612
		[Token(Token = "0x40019D4")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip onInteractAudio;

		// Token: 0x040019D5 RID: 6613
		[Token(Token = "0x40019D5")]
		[FieldOffset(Offset = "0x20")]
		public SchedulerNode.Reward[] rewards;
	}
}

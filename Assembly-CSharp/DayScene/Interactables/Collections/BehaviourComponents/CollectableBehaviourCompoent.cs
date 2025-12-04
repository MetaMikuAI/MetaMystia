using System;
using DayScene.Interactables.Collections.ConditionComponents;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004DF RID: 1247
	[Token(Token = "0x20004DF")]
	[RequireComponent(typeof(CollectableConditionComponent))]
	[GenerateCleanupMethod]
	public class CollectableBehaviourCompoent : EntityBehaviourComponent
	{
		// Token: 0x06001C3A RID: 7226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3A")]
		[Address(RVA = "0x493EC0", Offset = "0x4928C0", VA = "0x180493EC0", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3B")]
		[Address(RVA = "0x493E90", Offset = "0x492890", VA = "0x180493E90", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3C")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public CollectableBehaviourCompoent()
		{
		}

		// Token: 0x040019CF RID: 6607
		[Token(Token = "0x40019CF")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip onCollectAudio;
	}
}

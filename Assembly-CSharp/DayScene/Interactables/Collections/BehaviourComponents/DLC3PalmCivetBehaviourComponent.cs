using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004ED RID: 1261
	[Token(Token = "0x20004ED")]
	[GenerateCleanupMethod]
	public class DLC3PalmCivetBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001C77 RID: 7287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C77")]
		[Address(RVA = "0x494A20", Offset = "0x493420", VA = "0x180494A20", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C78")]
		[Address(RVA = "0x4949D0", Offset = "0x4933D0", VA = "0x1804949D0", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C79")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public DLC3PalmCivetBehaviourComponent()
		{
		}

		// Token: 0x040019F3 RID: 6643
		[Token(Token = "0x40019F3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_TipIcon;

		// Token: 0x040019F4 RID: 6644
		[Token(Token = "0x40019F4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private PlayableAsset m_ExecuteTimeline;

		// Token: 0x040019F5 RID: 6645
		[Token(Token = "0x40019F5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_ScheduledEvent;
	}
}

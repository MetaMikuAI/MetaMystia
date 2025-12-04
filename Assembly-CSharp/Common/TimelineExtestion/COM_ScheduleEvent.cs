using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FDC RID: 4060
	[Token(Token = "0x2000FDC")]
	public class COM_ScheduleEvent : PlayableAsset
	{
		// Token: 0x06005ECD RID: 24269 RVA: 0x00020DD8 File Offset: 0x0001EFD8
		[Token(Token = "0x6005ECD")]
		[Address(RVA = "0x8C0FF0", Offset = "0x8BF9F0", VA = "0x1808C0FF0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005ECE RID: 24270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ECE")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_ScheduleEvent()
		{
		}

		// Token: 0x040057C5 RID: 22469
		[Token(Token = "0x40057C5")]
		[FieldOffset(Offset = "0x18")]
		public string eventName;
	}
}

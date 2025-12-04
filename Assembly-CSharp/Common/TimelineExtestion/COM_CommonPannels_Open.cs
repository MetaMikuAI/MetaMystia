using System;
using Common.UI.NoteBookUtility;
using Common.UI.StorageUtility;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FB1 RID: 4017
	[Token(Token = "0x2000FB1")]
	public class COM_CommonPannels_Open : PlayableAsset
	{
		// Token: 0x06005E6F RID: 24175 RVA: 0x000209B8 File Offset: 0x0001EBB8
		[Token(Token = "0x6005E6F")]
		[Address(RVA = "0x8BF130", Offset = "0x8BDB30", VA = "0x1808BF130", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E70 RID: 24176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E70")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_CommonPannels_Open()
		{
		}

		// Token: 0x04005766 RID: 22374
		[Token(Token = "0x4005766")]
		[FieldOffset(Offset = "0x18")]
		public COM_CommonPannels_Open_Behaviour.PannelType PannelOpenType;

		// Token: 0x04005767 RID: 22375
		[Token(Token = "0x4005767")]
		[FieldOffset(Offset = "0x1C")]
		public NoteBookMainPannel.GoToSpecificType NoteBookGotoType;

		// Token: 0x04005768 RID: 22376
		[Token(Token = "0x4005768")]
		[FieldOffset(Offset = "0x20")]
		public StorageMainPannel.GoToSpecificType StorageGotoType;
	}
}

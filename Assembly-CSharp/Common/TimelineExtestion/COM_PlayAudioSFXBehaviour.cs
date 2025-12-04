using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02001024 RID: 4132
	[Token(Token = "0x2001024")]
	public class COM_PlayAudioSFXBehaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F71 RID: 24433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F71")]
		[Address(RVA = "0x8C0D50", Offset = "0x8BF750", VA = "0x1808C0D50", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F72")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_PlayAudioSFXBehaviour()
		{
		}

		// Token: 0x04005869 RID: 22633
		[Token(Token = "0x4005869")]
		[FieldOffset(Offset = "0x10")]
		public AudioClip audioClip;
	}
}

using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02001013 RID: 4115
	[Token(Token = "0x2001013")]
	public class COM_ACharacter_ResetClothes_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005F4A RID: 24394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4A")]
		[Address(RVA = "0x8BBB00", Offset = "0x8BA500", VA = "0x1808BBB00", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F4B RID: 24395 RVA: 0x00020FA0 File Offset: 0x0001F1A0
		[Token(Token = "0x6005F4B")]
		[Address(RVA = "0x8BBA70", Offset = "0x8BA470", VA = "0x1808BBA70")]
		private UniTask OnBehaviourEnterAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06005F4C RID: 24396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F4C")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ACharacter_ResetClothes_Behaviour()
		{
		}
	}
}

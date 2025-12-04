using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x0200103E RID: 4158
	[Token(Token = "0x200103E")]
	public abstract class CharacterControllerUnitInputProcessorComponent : CharacterControllerUnitComponent
	{
		// Token: 0x06006007 RID: 24583
		[Token(Token = "0x6006007")]
		public abstract Vector2 OnInputPassed(Vector2 input);

		// Token: 0x06006008 RID: 24584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006008")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		protected CharacterControllerUnitInputProcessorComponent()
		{
		}
	}
}

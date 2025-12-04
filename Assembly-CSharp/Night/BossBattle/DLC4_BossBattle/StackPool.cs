using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Pool;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001DA RID: 474
	[Token(Token = "0x20001DA")]
	internal static class StackPool<T>
	{
		// Token: 0x06000B71 RID: 2929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B71")]
		public static Stack<T> Get()
		{
			return null;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B72")]
		public static void Release(Stack<T> toRelease)
		{
		}

		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ObjectPool<Stack<T>> s_StackPool;
	}
}

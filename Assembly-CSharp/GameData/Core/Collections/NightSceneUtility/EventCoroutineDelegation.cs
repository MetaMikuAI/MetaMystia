using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000920 RID: 2336
	[Token(Token = "0x2000920")]
	public static class EventCoroutineDelegation
	{
		// Token: 0x06003A5D RID: 14941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A5D")]
		[Address(RVA = "0x684480", Offset = "0x682E80", VA = "0x180684480")]
		public static Coroutine Schedule(this IEnumerator coroutineHandle)
		{
			return null;
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A5E")]
		[Address(RVA = "0x6844D0", Offset = "0x682ED0", VA = "0x1806844D0")]
		public static void Stop(this Coroutine coroutine)
		{
		}
	}
}

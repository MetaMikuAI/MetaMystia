using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.RunTime.Common
{
	// Token: 0x020007FD RID: 2045
	[Token(Token = "0x20007FD")]
	public static class CloneUtils
	{
		// Token: 0x06003070 RID: 12400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003070")]
		public static T[] RegularClone<T>(T[] srcArray)
		{
			return null;
		}

		// Token: 0x06003071 RID: 12401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003071")]
		public static T RegularClone<T>(T value)
		{
			return null;
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003072")]
		public static List<T> RegularClone<T>(List<T> srcArray)
		{
			return null;
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003073")]
		public static HashSet<T> RegularClone<T>(HashSet<T> srcArray)
		{
			return null;
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003074")]
		public static List<T>[] RegularClone<T>(List<T>[] srcArray)
		{
			return null;
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003075")]
		public static Dictionary<TKey, TValue> RegularClone<TKey, TValue>(Dictionary<TKey, TValue> srcDictionary)
		{
			return null;
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003076")]
		[Address(RVA = "0x5FCAC0", Offset = "0x5FB4C0", VA = "0x1805FCAC0")]
		public static Dictionary<string, Tuple<string, string[]>> RegularClone(Dictionary<string, Tuple<string, string[]>> srcDictionary)
		{
			return null;
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003077")]
		[Address(RVA = "0x5FCEC0", Offset = "0x5FB8C0", VA = "0x1805FCEC0")]
		public static List<KeyValuePair<string, RunTimeScheduler.HistoryNewsData.ReplaceContent[]>> RegularClone(List<KeyValuePair<string, RunTimeScheduler.HistoryNewsData.ReplaceContent[]>> srcArray)
		{
			return null;
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003078")]
		[Address(RVA = "0x5FD010", Offset = "0x5FBA10", VA = "0x1805FD010")]
		public static Dictionary<int, ValueTuple<int, List<Vector2Int>>> RegularClone(Dictionary<int, ValueTuple<int, List<Vector2Int>>> srcDictionary)
		{
			return null;
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003079")]
		public static Dictionary<TKey, List<TValue>> RegularClone<TKey, TValue>(Dictionary<TKey, List<TValue>> srcDictionary)
		{
			return null;
		}

		// Token: 0x0600307A RID: 12410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307A")]
		[Address(RVA = "0x5FCCC0", Offset = "0x5FB6C0", VA = "0x1805FCCC0")]
		public static Dictionary<int, List<KeyValuePair<string, RunTimeScheduler.HistoryNewsData.ReplaceContent[]>>> RegularClone(Dictionary<int, List<KeyValuePair<string, RunTimeScheduler.HistoryNewsData.ReplaceContent[]>>> srcDictionary)
		{
			return null;
		}

		// Token: 0x0600307B RID: 12411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307B")]
		public static T DeepClone<T>(T value) where T : class, IDeepClonable<T>
		{
			return null;
		}

		// Token: 0x0600307C RID: 12412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307C")]
		public static T DeepCloneS<T>(T value) where T : struct, IDeepClonable<T>
		{
			return null;
		}

		// Token: 0x0600307D RID: 12413 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		[Token(Token = "0x600307D")]
		public static T? DeepCloneS<T>(T? value) where T : struct, IDeepClonable<T>
		{
			return null;
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307E")]
		public static T[] DeepClone<T>(T[] srcArray) where T : class, IDeepClonable<T>
		{
			return null;
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600307F")]
		public static T?[] DeepCloneS<T>(T?[] srcArray) where T : struct, IDeepClonable<T>
		{
			return null;
		}

		// Token: 0x06003080 RID: 12416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003080")]
		public static List<T> DeepClone<T>(List<T> srcArray) where T : class, IDeepClonable<T>
		{
			return null;
		}

		// Token: 0x06003081 RID: 12417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003081")]
		public static List<T> DeepCloneS<T>(List<T> srcArray) where T : IDeepClonable<T>
		{
			return null;
		}

		// Token: 0x06003082 RID: 12418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003082")]
		public static Dictionary<TKey, TValue> DeepClone<TKey, TValue>(Dictionary<TKey, TValue> srcDictionary) where TValue : class, IDeepClonable<TValue>
		{
			return null;
		}

		// Token: 0x06003083 RID: 12419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003083")]
		public static Dictionary<TKey, TValue> DeepCloneS<TKey, TValue>(Dictionary<TKey, TValue> srcDictionary) where TValue : struct, IDeepClonable<TValue>
		{
			return null;
		}

		// Token: 0x06003084 RID: 12420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003084")]
		public static Dictionary<TKey, List<TValue>> DeepClone<TKey, TValue>(Dictionary<TKey, List<TValue>> srcDictionary) where TValue : class, IDeepClonable<TValue>
		{
			return null;
		}

		// Token: 0x06003085 RID: 12421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003085")]
		public static Dictionary<TKey, List<TValue>> DeepCloneS<TKey, TValue>(Dictionary<TKey, List<TValue>> srcDictionary) where TValue : struct, IDeepClonable<TValue>
		{
			return null;
		}

		// Token: 0x06003086 RID: 12422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003086")]
		public static Dictionary<TKey1, Dictionary<TKey2, TValue>> DeepClone<TKey1, TKey2, TValue>(Dictionary<TKey1, Dictionary<TKey2, TValue>> srcDictionary) where TValue : class, IDeepClonable<TValue>
		{
			return null;
		}
	}
}

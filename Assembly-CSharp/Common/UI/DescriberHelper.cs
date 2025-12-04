using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000DF1 RID: 3569
	[Token(Token = "0x2000DF1")]
	public static class DescriberHelper
	{
		// Token: 0x06005385 RID: 21381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005385")]
		[Address(RVA = "0x838300", Offset = "0x836D00", VA = "0x180838300")]
		private static void SpawnConditioned(GameObject gameObject, Transform field, IReadOnlyList<int> tags, Func<int, string> getLangHandler, List<GameObject> instances)
		{
		}

		// Token: 0x06005386 RID: 21382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005386")]
		[Address(RVA = "0x838130", Offset = "0x836B30", VA = "0x180838130")]
		public static void PrintGuestTags(GameObject prefab, Transform field, List<int> collectionBuffer, IReadOnlyList<int> tags, bool all, string allKey, List<GameObject> instances, bool isFoodTag)
		{
		}

		// Token: 0x06005387 RID: 21383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005387")]
		[Address(RVA = "0x837E50", Offset = "0x836850", VA = "0x180837E50")]
		public static void AssignImageSpriteAsync(this Image imageComponent, UniTask<IAssetHandle<Sprite>> spriteHandle, CancellationToken cancellationToken, [Optional] Action<Image> postProcessCallback)
		{
		}

		// Token: 0x06005388 RID: 21384 RVA: 0x0001E108 File Offset: 0x0001C308
		[Token(Token = "0x6005388")]
		[Address(RVA = "0x837F90", Offset = "0x836990", VA = "0x180837F90")]
		private static UniTaskVoid AssignImageSpriteImpl(Image imageComponent, UniTask<IAssetHandle<Sprite>> spriteHandle, CancellationToken cancellationToken, Action<Image> postProcessCallback)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06005389 RID: 21385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005389")]
		[Address(RVA = "0x838090", Offset = "0x836A90", VA = "0x180838090")]
		public static Action<Image> GetMultiplyImageSizePostProcessor(int multiplier)
		{
			return null;
		}

		// Token: 0x04004E75 RID: 20085
		[Token(Token = "0x4004E75")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] s_SingleElementArray;
	}
}

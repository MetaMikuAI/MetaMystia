using System;
using System.Collections.Generic;
using Common.Effects;
using DEYU.Singletons;
using Il2CppDummyDll;
using NightScene.UI;
using NightScene.UI.GuestManagementUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

// Token: 0x02000016 RID: 22
[Token(Token = "0x2000016")]
[GenerateCleanupMethod]
public class ObjectCacheManager : MonoSingleton<ObjectCacheManager>
{
	// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x41A0F0", Offset = "0x418AF0", VA = "0x18041A0F0")]
	private DialogBoxUI CreateNewNormalDialog()
	{
		return null;
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x41A010", Offset = "0x418A10", VA = "0x18041A010")]
	private EvalulationBoxUI CreateNewEvaluationDialog()
	{
		return null;
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x41A1D0", Offset = "0x418BD0", VA = "0x18041A1D0")]
	private ControllableLaunchAnimation CreateNewThrowDeliverObject()
	{
		return null;
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x41A2C0", Offset = "0x418CC0", VA = "0x18041A2C0")]
	private GameObject CreateNewTipCoinObject()
	{
		return null;
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x41A340", Offset = "0x418D40", VA = "0x18041A340")]
	private OrderingElement CreateOrderingElement()
	{
		return null;
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x419F50", Offset = "0x418950", VA = "0x180419F50")]
	private Transform CreateGhostOrderingElement()
	{
		return null;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x41A710", Offset = "0x419110", VA = "0x18041A710")]
	public DialogBoxUI GetNormalDialogBoxUI(out Action<DialogBoxUI> pushCallback)
	{
		return null;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x41A4D0", Offset = "0x418ED0", VA = "0x18041A4D0")]
	public EvalulationBoxUI GetNewEvaluationDialog(out Action<EvalulationBoxUI> pushCallback)
	{
		return null;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x41A590", Offset = "0x418F90", VA = "0x18041A590")]
	public ControllableLaunchAnimation GetNewThrowDeliverObject(out Action<ControllableLaunchAnimation> pushCallback)
	{
		return null;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x41A650", Offset = "0x419050", VA = "0x18041A650")]
	public GameObject GetNewTipCoinObject(out Action<GameObject> pushCallback)
	{
		return null;
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x41A7D0", Offset = "0x4191D0", VA = "0x18041A7D0")]
	public OrderingElement GetOrderingElement(out Action<OrderingElement> pushCallback)
	{
		return null;
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x41A410", Offset = "0x418E10", VA = "0x18041A410")]
	public Transform GetGhostOrderingElement(out Action<Transform> pushCallback)
	{
		return null;
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x41A890", Offset = "0x419290", VA = "0x18041A890")]
	public void InitializeAndPreload()
	{
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x419DA0", Offset = "0x4187A0", VA = "0x180419DA0")]
	private static void CleanupCache(Stack<GameObject> cached)
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007C")]
	private static void CleanupCache<T>(Stack<T> cached) where T : Component
	{
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x41ABA0", Offset = "0x4195A0", VA = "0x18041ABA0", Slot = "5")]
	protected override void OnInstanceDestroyed()
	{
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007E")]
	private T GetCacheData<T>(Stack<T> targetStack, Func<T> createCallback, out Action<T> pushCallback)
	{
		return null;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007F")]
	private void Preload<T>(ObjectCacheManager.PreloadCacheMethod<T> preloadMethod, ObjectCacheManager.CachedObject cachedObject)
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x419E40", Offset = "0x418840", VA = "0x180419E40", Slot = "6")]
	protected virtual void Cleanup_Generated()
	{
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x41AD20", Offset = "0x419720", VA = "0x18041AD20")]
	public ObjectCacheManager()
	{
	}

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x18")]
	public ObjectCacheManager.CachedObject dialogBoxParent;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x28")]
	public ObjectCacheManager.CachedObject evaluationBoxParent;

	// Token: 0x04000057 RID: 87
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x38")]
	public ObjectCacheManager.CachedObject throwDeliverParent;

	// Token: 0x04000058 RID: 88
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x48")]
	public ObjectCacheManager.CachedObject tipCoinParent;

	// Token: 0x04000059 RID: 89
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x58")]
	public ObjectCacheManager.CachedObject orderingElementParent;

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x68")]
	public ObjectCacheManager.CachedObject ghostOrderingElementParent;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x78")]
	private readonly Stack<DialogBoxUI> allNormalDialogInstances;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x80")]
	private readonly Stack<EvalulationBoxUI> allEvaluationDialogInstances;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x88")]
	private readonly Stack<ControllableLaunchAnimation> allThrowDeliverObjects;

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x90")]
	private readonly Stack<GameObject> allTipCoinObjects;

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x98")]
	private readonly Stack<OrderingElement> allOrderElementObjects;

	// Token: 0x04000060 RID: 96
	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0xA0")]
	private readonly Stack<Transform> allGhostOrderElementObjects;

	// Token: 0x04000061 RID: 97
	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0xA8")]
	private UIManager uiManager;

	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[Serializable]
	public struct CachedObject
	{
		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x0")]
		public GameObject objectParent;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x8")]
		public int preloadNum;
	}

	// Token: 0x02000018 RID: 24
	// (Invoke) Token: 0x06000083 RID: 131
	[Token(Token = "0x2000018")]
	private delegate T PreloadCacheMethod<T>(out Action<T> pushCallback);
}

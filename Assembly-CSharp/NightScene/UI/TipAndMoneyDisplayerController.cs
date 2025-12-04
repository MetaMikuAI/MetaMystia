using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.UI
{
	// Token: 0x0200069B RID: 1691
	[Token(Token = "0x200069B")]
	[GenerateCleanupMethod]
	public class TipAndMoneyDisplayerController : MonoBehaviour
	{
		// Token: 0x060027F9 RID: 10233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F9")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FA")]
		[Address(RVA = "0x54E110", Offset = "0x54CB10", VA = "0x18054E110")]
		public void NotifyOrderMoneyMessage(int costMoney)
		{
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FB")]
		[Address(RVA = "0x54E210", Offset = "0x54CC10", VA = "0x18054E210")]
		public void NotifyTipMessage(int tipMoney, int comboBuff, int moodBuff, int extraBuff)
		{
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027FC")]
		[Address(RVA = "0x54E010", Offset = "0x54CA10", VA = "0x18054E010")]
		public void NotifyExpMessage(int count)
		{
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x0000EC58 File Offset: 0x0000CE58
		[Token(Token = "0x60027FD")]
		[Address(RVA = "0x54DB30", Offset = "0x54C530", VA = "0x18054DB30")]
		private ValueTuple<UIElementCluster, GameObject> GetOrderMoneyMessageInstance()
		{
			return default(ValueTuple<UIElementCluster, GameObject>);
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x0000EC70 File Offset: 0x0000CE70
		[Token(Token = "0x60027FE")]
		[Address(RVA = "0x54DCD0", Offset = "0x54C6D0", VA = "0x18054DCD0")]
		private ValueTuple<UIElementCluster, GameObject> GetTipMessageInstance()
		{
			return default(ValueTuple<UIElementCluster, GameObject>);
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x0000EC88 File Offset: 0x0000CE88
		[Token(Token = "0x60027FF")]
		[Address(RVA = "0x54D990", Offset = "0x54C390", VA = "0x18054D990")]
		private ValueTuple<UIElementCluster, GameObject> GetExpMessageInstance()
		{
			return default(ValueTuple<UIElementCluster, GameObject>);
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x0000ECA0 File Offset: 0x0000CEA0
		[Token(Token = "0x6002800")]
		[Address(RVA = "0x54D9D0", Offset = "0x54C3D0", VA = "0x18054D9D0")]
		private ValueTuple<UIElementCluster, GameObject> GetInstanceInternal([TupleElementNames(new string[] { "objectData", "objectLayoutData" })] Stack<ValueTuple<UIElementCluster, GameObject>> collection, GameObject parent)
		{
			return default(ValueTuple<UIElementCluster, GameObject>);
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		[Token(Token = "0x6002801")]
		[Address(RVA = "0x54DB70", Offset = "0x54C570", VA = "0x18054DB70")]
		private ValueTuple<UIElementCluster, GameObject> GetTipInstance([TupleElementNames(new string[] { "objectData", "objectLayoutData" })] Stack<ValueTuple<UIElementCluster, GameObject>> collection, GameObject parent)
		{
			return default(ValueTuple<UIElementCluster, GameObject>);
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002802")]
		[Address(RVA = "0x54E370", Offset = "0x54CD70", VA = "0x18054E370")]
		private void TryExecuteNotify()
		{
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002803")]
		[Address(RVA = "0x54DE50", Offset = "0x54C850", VA = "0x18054DE50")]
		private void NotifyDataInternal([TupleElementNames(new string[] { "objectData", "objectLayoutData" })] Func<ValueTuple<UIElementCluster, GameObject>> objectGenerator, [TupleElementNames(new string[] { "objectData", "objectLayoutData" })] Stack<ValueTuple<UIElementCluster, GameObject>> cachedObjectPool, Action<UIElementCluster> dataProcessor)
		{
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002804")]
		[Address(RVA = "0x54E400", Offset = "0x54CE00", VA = "0x18054E400")]
		private void UpdateRegisteredMessagePosition()
		{
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002805")]
		[Address(RVA = "0x54D860", Offset = "0x54C260", VA = "0x18054D860")]
		public void Dispose()
		{
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002806")]
		[Address(RVA = "0x54D6E0", Offset = "0x54C0E0", VA = "0x18054D6E0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002807")]
		[Address(RVA = "0x54E740", Offset = "0x54D140", VA = "0x18054E740")]
		public TipAndMoneyDisplayerController()
		{
		}

		// Token: 0x0400246A RID: 9322
		[Token(Token = "0x400246A")]
		[FieldOffset(Offset = "0x18")]
		public GameObject orderMoneyMessageParent;

		// Token: 0x0400246B RID: 9323
		[Token(Token = "0x400246B")]
		[FieldOffset(Offset = "0x20")]
		public GameObject tipMessageParent;

		// Token: 0x0400246C RID: 9324
		[Token(Token = "0x400246C")]
		[FieldOffset(Offset = "0x28")]
		public GameObject expMessageParent;

		// Token: 0x0400246D RID: 9325
		[Token(Token = "0x400246D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject recievedMessagePositionIndicatorParent;

		// Token: 0x0400246E RID: 9326
		[Token(Token = "0x400246E")]
		[FieldOffset(Offset = "0x38")]
		public GameObject recievedTipPositionIndicatorParent;

		// Token: 0x0400246F RID: 9327
		[Token(Token = "0x400246F")]
		[FieldOffset(Offset = "0x40")]
		public RectTransform recievedObjectField;

		// Token: 0x04002470 RID: 9328
		[Token(Token = "0x4002470")]
		[FieldOffset(Offset = "0x48")]
		public RectTransform recievedObjectLayoutField;

		// Token: 0x04002471 RID: 9329
		[Token(Token = "0x4002471")]
		[FieldOffset(Offset = "0x50")]
		public float messageStayDuration;

		// Token: 0x04002472 RID: 9330
		[Token(Token = "0x4002472")]
		[FieldOffset(Offset = "0x54")]
		public float messageInsertionAdjustmentDuration;

		// Token: 0x04002473 RID: 9331
		[Token(Token = "0x4002473")]
		[FieldOffset(Offset = "0x58")]
		public Sprite normalEvalSprite;

		// Token: 0x04002474 RID: 9332
		[Token(Token = "0x4002474")]
		[FieldOffset(Offset = "0x60")]
		public Sprite goodEvalSprite;

		// Token: 0x04002475 RID: 9333
		[Token(Token = "0x4002475")]
		[FieldOffset(Offset = "0x68")]
		public Sprite exgoodEvalSprite;

		// Token: 0x04002476 RID: 9334
		[Token(Token = "0x4002476")]
		[FieldOffset(Offset = "0x70")]
		[TupleElementNames(new string[] { "objectData", "objectLayoutData" })]
		private readonly Stack<ValueTuple<UIElementCluster, GameObject>> cachedSpriteMessageCountInstences;

		// Token: 0x04002477 RID: 9335
		[Token(Token = "0x4002477")]
		[FieldOffset(Offset = "0x78")]
		[TupleElementNames(new string[] { "objectData", "objectLayoutData" })]
		private readonly Stack<ValueTuple<UIElementCluster, GameObject>> cachedSpriteMessageInstences;

		// Token: 0x04002478 RID: 9336
		[Token(Token = "0x4002478")]
		[FieldOffset(Offset = "0x80")]
		[TupleElementNames(new string[] { "objectData", "objectLayoutData" })]
		private readonly Stack<ValueTuple<UIElementCluster, GameObject>> cachedTextMessageInstences;

		// Token: 0x04002479 RID: 9337
		[Token(Token = "0x4002479")]
		[FieldOffset(Offset = "0x88")]
		private readonly Queue<Action> executionQueue;

		// Token: 0x0400247A RID: 9338
		[Token(Token = "0x400247A")]
		[FieldOffset(Offset = "0x90")]
		private readonly HashSet<Action> interruptionCollection;

		// Token: 0x0400247B RID: 9339
		[Token(Token = "0x400247B")]
		[FieldOffset(Offset = "0x98")]
		[TupleElementNames(new string[] { "objectData", "objectLayoutData" })]
		private readonly HashSet<ValueTuple<UIElementCluster, GameObject>> registeredObjectCollection;
	}
}

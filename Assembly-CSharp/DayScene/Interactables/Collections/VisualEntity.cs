using System;
using DayScene.Interactables.Collections.ConditionComponents;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections
{
	// Token: 0x020004BB RID: 1211
	[Token(Token = "0x20004BB")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(EntityConditionComponent))]
	public class VisualEntity : MonoBehaviour
	{
		// Token: 0x06001B8D RID: 7053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8D")]
		[Address(RVA = "0x4043B0", Offset = "0x402DB0", VA = "0x1804043B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B8E")]
		[Address(RVA = "0x4ABD50", Offset = "0x4AA750", VA = "0x1804ABD50")]
		public Action<bool, bool> Initialize()
		{
			return null;
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B8F")]
		[Address(RVA = "0x4ABDD0", Offset = "0x4AA7D0", VA = "0x1804ABDD0")]
		private void SetAlpha(float targetAlpha)
		{
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x4AC160", Offset = "0x4AAB60", VA = "0x1804AC160", Slot = "4")]
		protected virtual void UpdateAvailability(bool shouldActive, bool shouldFadeOut = false)
		{
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B91")]
		[Address(RVA = "0x42B4C0", Offset = "0x429EC0", VA = "0x18042B4C0", Slot = "5")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B92")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public VisualEntity()
		{
		}

		// Token: 0x04001955 RID: 6485
		[Token(Token = "0x4001955")]
		[FieldOffset(Offset = "0x18")]
		public SpriteRenderer[] visuals;

		// Token: 0x04001956 RID: 6486
		[Token(Token = "0x4001956")]
		[FieldOffset(Offset = "0x20")]
		public SpriteRenderer[] visualsOnOff;

		// Token: 0x04001957 RID: 6487
		[Token(Token = "0x4001957")]
		[FieldOffset(Offset = "0x28")]
		public Collider2D[] collisionsOnOn;

		// Token: 0x04001958 RID: 6488
		[Token(Token = "0x4001958")]
		[FieldOffset(Offset = "0x30")]
		public Collider2D[] collisionsOnOff;

		// Token: 0x04001959 RID: 6489
		[Token(Token = "0x4001959")]
		[FieldOffset(Offset = "0x38")]
		private bool? internalActiveState;
	}
}

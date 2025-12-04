using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI
{
	// Token: 0x0200023F RID: 575
	[Token(Token = "0x200023F")]
	[RequireComponent(typeof(UIButtonSimple))]
	[GenerateCleanupMethod]
	public class MapTransitionNode : MonoBehaviour
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x00005B08 File Offset: 0x00003D08
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000169")]
		public int YukariTeleportCost
		{
			[Token(Token = "0x6000D90")]
			[Address(RVA = "0x4D1E80", Offset = "0x4D0880", VA = "0x1804D1E80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000D91")]
			[Address(RVA = "0x8EDC90", Offset = "0x8EC690", VA = "0x1808EDC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00005B20 File Offset: 0x00003D20
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016A")]
		public int Cost
		{
			[Token(Token = "0x6000D92")]
			[Address(RVA = "0x79D9A0", Offset = "0x79C3A0", VA = "0x18079D9A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000D93")]
			[Address(RVA = "0x8EDC80", Offset = "0x8EC680", VA = "0x1808EDC80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D94")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D95")]
		[Address(RVA = "0x8EDC50", Offset = "0x8EC650", VA = "0x1808EDC50")]
		public void SetOff()
		{
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00005B38 File Offset: 0x00003D38
		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x8EDAD0", Offset = "0x8EC4D0", VA = "0x1808EDAD0")]
		public bool Initialize(Action onHighlightAction, Action onEnterTravelConfimationCallback)
		{
			return default(bool);
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x8EDA70", Offset = "0x8EC470", VA = "0x1808EDA70", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public MapTransitionNode()
		{
		}

		// Token: 0x04000C23 RID: 3107
		[Token(Token = "0x4000C23")]
		[FieldOffset(Offset = "0x18")]
		public string key;

		// Token: 0x04000C24 RID: 3108
		[Token(Token = "0x4000C24")]
		[FieldOffset(Offset = "0x20")]
		public bool costOneAction;

		// Token: 0x04000C25 RID: 3109
		[Token(Token = "0x4000C25")]
		[FieldOffset(Offset = "0x28")]
		public MapTransitionNode[] connections;

		// Token: 0x04000C26 RID: 3110
		[Token(Token = "0x4000C26")]
		[FieldOffset(Offset = "0x30")]
		public UIButtonSimple interactable;

		// Token: 0x04000C27 RID: 3111
		[Token(Token = "0x4000C27")]
		[FieldOffset(Offset = "0x38")]
		public GameObject visualParent;
	}
}

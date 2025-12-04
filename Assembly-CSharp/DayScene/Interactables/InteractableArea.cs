using System;
using System.Runtime.CompilerServices;
using DayScene.Interactables.Collections.BehaviourComponents;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables
{
	// Token: 0x020004B6 RID: 1206
	[Token(Token = "0x20004B6")]
	[RequireComponent(typeof(Collider2D), typeof(EntityBehaviourComponent))]
	[GenerateCleanupMethod]
	public class InteractableArea : MonoBehaviour
	{
		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001B6A RID: 7018 RVA: 0x0000A950 File Offset: 0x00008B50
		// (set) Token: 0x06001B6B RID: 7019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D5")]
		public static bool IsInTrigger
		{
			[Token(Token = "0x6001B6A")]
			[Address(RVA = "0x4A0010", Offset = "0x49EA10", VA = "0x1804A0010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B6B")]
			[Address(RVA = "0x4A0140", Offset = "0x49EB40", VA = "0x1804A0140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001B6C RID: 7020 RVA: 0x0000A968 File Offset: 0x00008B68
		// (set) Token: 0x06001B6D RID: 7021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D6")]
		public bool DoNotAutoFacingWhenInteract
		{
			[Token(Token = "0x6001B6C")]
			[Address(RVA = "0x4A0000", Offset = "0x49EA00", VA = "0x1804A0000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B6D")]
			[Address(RVA = "0x4A0130", Offset = "0x49EB30", VA = "0x1804A0130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6E")]
		[Address(RVA = "0x49F480", Offset = "0x49DE80", VA = "0x18049F480")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B6F")]
		[Address(RVA = "0x49F540", Offset = "0x49DF40", VA = "0x18049F540")]
		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B70")]
		[Address(RVA = "0x49F650", Offset = "0x49E050", VA = "0x18049F650")]
		private void OnTriggerExit2D(Collider2D collision)
		{
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B71")]
		[Address(RVA = "0x49F7B0", Offset = "0x49E1B0", VA = "0x18049F7B0")]
		private void OnTriggerStay2D(Collider2D collision)
		{
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06001B72 RID: 7026 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001B73 RID: 7027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000C")]
		[CleanupIgnore]
		public static event Action<bool> OnTriggerEnterStateChanged
		{
			[Token(Token = "0x6001B72")]
			[Address(RVA = "0x49FF20", Offset = "0x49E920", VA = "0x18049FF20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001B73")]
			[Address(RVA = "0x4A0050", Offset = "0x49EA50", VA = "0x1804A0050")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B74")]
		[Address(RVA = "0x49F070", Offset = "0x49DA70", VA = "0x18049F070")]
		public void Initialize(EntityBehaviourComponent entityBehaviourComponent, bool isTriggerMode, bool doNotAutoFacingWhenInteract)
		{
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B75")]
		[Address(RVA = "0x49F4D0", Offset = "0x49DED0", VA = "0x18049F4D0")]
		public void OnInteract()
		{
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B76")]
		[Address(RVA = "0x49F8C0", Offset = "0x49E2C0", VA = "0x18049F8C0")]
		public void SetSelected(bool doHighlight)
		{
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B77")]
		[Address(RVA = "0x49FD50", Offset = "0x49E750", VA = "0x18049FD50")]
		public void UpdateAvailability(bool shouldActive)
		{
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B78")]
		[Address(RVA = "0x49EFE0", Offset = "0x49D9E0", VA = "0x18049EFE0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B79")]
		[Address(RVA = "0x49FEB0", Offset = "0x49E8B0", VA = "0x18049FEB0")]
		public InteractableArea()
		{
		}

		// Token: 0x04001932 RID: 6450
		[Token(Token = "0x4001932")]
		protected const float ON_INTERACTABLE_VISUAL_SWITCH_DURATION = 0.5f;

		// Token: 0x04001933 RID: 6451
		[Token(Token = "0x4001933")]
		[FieldOffset(Offset = "0x18")]
		public SpriteRenderer[] showsOnInteractable;

		// Token: 0x04001934 RID: 6452
		[Token(Token = "0x4001934")]
		[FieldOffset(Offset = "0x20")]
		public SpriteRenderer[] hidesOninteractable;

		// Token: 0x04001935 RID: 6453
		[Token(Token = "0x4001935")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 highlightOffset;

		// Token: 0x04001936 RID: 6454
		[Token(Token = "0x4001936")]
		[FieldOffset(Offset = "0x38")]
		public Collider2D[] enabledWhenOffCollider;

		// Token: 0x04001937 RID: 6455
		[Token(Token = "0x4001937")]
		[FieldOffset(Offset = "0x40")]
		public bool uiBehaviourIndependent;

		// Token: 0x04001938 RID: 6456
		[Token(Token = "0x4001938")]
		[FieldOffset(Offset = "0x41")]
		public bool isEventTrigger;

		// Token: 0x04001939 RID: 6457
		[Token(Token = "0x4001939")]
		[FieldOffset(Offset = "0x48")]
		public Action<bool> AfterTrigger;

		// Token: 0x0400193A RID: 6458
		[Token(Token = "0x400193A")]
		[FieldOffset(Offset = "0x50")]
		private EntityBehaviourComponent behaviourComponent;

		// Token: 0x0400193B RID: 6459
		[Token(Token = "0x400193B")]
		[FieldOffset(Offset = "0x58")]
		private float[] hideStartAlpha;

		// Token: 0x0400193C RID: 6460
		[Token(Token = "0x400193C")]
		[FieldOffset(Offset = "0x60")]
		private float[] startAlpha;

		// Token: 0x0400193D RID: 6461
		[Token(Token = "0x400193D")]
		[FieldOffset(Offset = "0x68")]
		private bool triggerMode;
	}
}

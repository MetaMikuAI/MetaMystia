using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004E8 RID: 1256
	[Token(Token = "0x20004E8")]
	public class CreatorBoxBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001C63 RID: 7267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C63")]
		[Address(RVA = "0x494430", Offset = "0x492E30", VA = "0x180494430", Slot = "12")]
		protected override void OnInitialize()
		{
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C64")]
		[Address(RVA = "0x4948C0", Offset = "0x4932C0", VA = "0x1804948C0")]
		private void UpdateAppearance()
		{
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C65")]
		[Address(RVA = "0x494450", Offset = "0x492E50", VA = "0x180494450", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C66")]
		[Address(RVA = "0x494470", Offset = "0x492E70", VA = "0x180494470")]
		private void OpenOption()
		{
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x0000AD10 File Offset: 0x00008F10
		[Token(Token = "0x170003DA")]
		private bool CheckOpenStatus
		{
			[Token(Token = "0x6001C67")]
			[Address(RVA = "0x494940", Offset = "0x493340", VA = "0x180494940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C68")]
		[Address(RVA = "0x494700", Offset = "0x493100", VA = "0x180494700")]
		private void SetCreatorBoxActive(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C69")]
		[Address(RVA = "0x4941D0", Offset = "0x492BD0", VA = "0x1804941D0")]
		private void EditCreatorBox(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6A")]
		[Address(RVA = "0x4942E0", Offset = "0x492CE0", VA = "0x1804942E0")]
		private void Manual(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6B")]
		[Address(RVA = "0x494410", Offset = "0x492E10", VA = "0x180494410")]
		private static void OnCloseButtonSubmit(Action action)
		{
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C6C")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public CreatorBoxBehaviourComponent()
		{
		}

		// Token: 0x040019E8 RID: 6632
		[Token(Token = "0x40019E8")]
		[FieldOffset(Offset = "0x18")]
		public Sprite activeSprite;

		// Token: 0x040019E9 RID: 6633
		[Token(Token = "0x40019E9")]
		[FieldOffset(Offset = "0x20")]
		public Sprite inactiveSprite;

		// Token: 0x040019EA RID: 6634
		[Token(Token = "0x40019EA")]
		[FieldOffset(Offset = "0x28")]
		public SpriteRenderer baseSpriteRenderer;

		// Token: 0x040019EB RID: 6635
		[Token(Token = "0x40019EB")]
		[FieldOffset(Offset = "0x30")]
		public SpriteRenderer outlineSpriteRenderer;

		// Token: 0x040019EC RID: 6636
		[Token(Token = "0x40019EC")]
		[FieldOffset(Offset = "0x38")]
		public DialogPackage manualDialog;
	}
}

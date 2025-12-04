using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x0200023B RID: 571
	[Token(Token = "0x200023B")]
	[RequireComponent(typeof(UIButtonSimple))]
	[GenerateCleanupMethod]
	public class IzakayaSpot : MonoBehaviour
	{
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00005A00 File Offset: 0x00003C00
		[Token(Token = "0x17000168")]
		public bool Activated
		{
			[Token(Token = "0x6000D7A")]
			[Address(RVA = "0x8ECC10", Offset = "0x8EB610", VA = "0x1808ECC10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D7C")]
		[Address(RVA = "0x8ECB80", Offset = "0x8EB580", VA = "0x1808ECB80")]
		public void SetOff()
		{
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D7D")]
		[Address(RVA = "0x8ECBB0", Offset = "0x8EB5B0", VA = "0x1808ECBB0")]
		public void SetOn()
		{
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D7E")]
		[Address(RVA = "0x8ECB50", Offset = "0x8EB550", VA = "0x1808ECB50")]
		public void Select()
		{
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00005A18 File Offset: 0x00003C18
		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x8EBED0", Offset = "0x8EA8D0", VA = "0x1808EBED0")]
		public bool Initialize(Action<List<int>> onSelectAction, Func<int, bool> getOverrideOpenStatus)
		{
			return default(bool);
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D80")]
		[Address(RVA = "0x838760", Offset = "0x837160", VA = "0x180838760", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D81")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public IzakayaSpot()
		{
		}

		// Token: 0x04000C08 RID: 3080
		[Token(Token = "0x4000C08")]
		[FieldOffset(Offset = "0x18")]
		public string daySceneMapId;

		// Token: 0x04000C09 RID: 3081
		[Token(Token = "0x4000C09")]
		[FieldOffset(Offset = "0x20")]
		public Image izakayaIndicator;

		// Token: 0x04000C0A RID: 3082
		[Token(Token = "0x4000C0A")]
		[FieldOffset(Offset = "0x28")]
		public Image normalIndicator;

		// Token: 0x04000C0B RID: 3083
		[Token(Token = "0x4000C0B")]
		[FieldOffset(Offset = "0x30")]
		public Image level1Icon;

		// Token: 0x04000C0C RID: 3084
		[Token(Token = "0x4000C0C")]
		[FieldOffset(Offset = "0x38")]
		public Image level2Icon;

		// Token: 0x04000C0D RID: 3085
		[Token(Token = "0x4000C0D")]
		[FieldOffset(Offset = "0x40")]
		public Image level3Icon;

		// Token: 0x04000C0E RID: 3086
		[Token(Token = "0x4000C0E")]
		[FieldOffset(Offset = "0x48")]
		public GameObject levelIndicator;

		// Token: 0x04000C0F RID: 3087
		[Token(Token = "0x4000C0F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject parentVisualNode;

		// Token: 0x04000C10 RID: 3088
		[Token(Token = "0x4000C10")]
		[FieldOffset(Offset = "0x58")]
		public Sprite highlightInidicator;

		// Token: 0x04000C11 RID: 3089
		[Token(Token = "0x4000C11")]
		[FieldOffset(Offset = "0x60")]
		private UIButtonSimple interactable;

		// Token: 0x0200023C RID: 572
		[Token(Token = "0x200023C")]
		public enum LevelSelectionType
		{
			// Token: 0x04000C13 RID: 3091
			[Token(Token = "0x4000C13")]
			Level1,
			// Token: 0x04000C14 RID: 3092
			[Token(Token = "0x4000C14")]
			Level2,
			// Token: 0x04000C15 RID: 3093
			[Token(Token = "0x4000C15")]
			Level3
		}
	}
}

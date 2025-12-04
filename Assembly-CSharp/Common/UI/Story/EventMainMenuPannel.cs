using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine.UI;

namespace Common.UI.Story
{
	// Token: 0x02000F59 RID: 3929
	[Token(Token = "0x2000F59")]
	[GenerateCleanupMethod]
	public class EventMainMenuPannel : UIPanel
	{
		// Token: 0x06005C6E RID: 23662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6E")]
		[Address(RVA = "0x8AA980", Offset = "0x8A9380", VA = "0x1808AA980", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005C6F RID: 23663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C6F")]
		[Address(RVA = "0x8AA860", Offset = "0x8A9260", VA = "0x1808AA860")]
		private void ContinueGame()
		{
		}

		// Token: 0x06005C70 RID: 23664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C70")]
		[Address(RVA = "0x8AAA60", Offset = "0x8A9460", VA = "0x1808AAA60", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005C71 RID: 23665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005C71")]
		[Address(RVA = "0x8AA900", Offset = "0x8A9300", VA = "0x1808AA900")]
		private IEnumerator ExecuteDelayed(Action action)
		{
			return null;
		}

		// Token: 0x06005C72 RID: 23666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C72")]
		[Address(RVA = "0x8AA810", Offset = "0x8A9210", VA = "0x1808AA810", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005C73 RID: 23667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C73")]
		[Address(RVA = "0x408E80", Offset = "0x407880", VA = "0x180408E80")]
		public EventMainMenuPannel()
		{
		}

		// Token: 0x06005C74 RID: 23668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C74")]
		[Address(RVA = "0x8AAB00", Offset = "0x8A9500", VA = "0x1808AAB00")]
		[CompilerGenerated]
		private void <ContinueGame>g__OnFadeInFinish|4_0()
		{
		}

		// Token: 0x06005C76 RID: 23670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C76")]
		[Address(RVA = "0x8AAD00", Offset = "0x8A9700", VA = "0x1808AAD00")]
		[CompilerGenerated]
		private void <OnPanelOpen>g__OnFadeOutFinish|5_1()
		{
		}

		// Token: 0x040055A6 RID: 21926
		[Token(Token = "0x40055A6")]
		[FieldOffset(Offset = "0x70")]
		public UIButtonSimple ContinueGameBtn;

		// Token: 0x040055A7 RID: 21927
		[Token(Token = "0x40055A7")]
		[FieldOffset(Offset = "0x78")]
		public MultiLanguageSprite TitleSprite;

		// Token: 0x040055A8 RID: 21928
		[Token(Token = "0x40055A8")]
		[FieldOffset(Offset = "0xA0")]
		public Image Title;
	}
}

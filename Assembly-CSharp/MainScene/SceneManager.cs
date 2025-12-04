using System;
using Common.UI;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppDummyDll;
using MainScene.UI;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace MainScene
{
	// Token: 0x02000218 RID: 536
	[Token(Token = "0x2000218")]
	[GenerateCleanupMethod]
	public class SceneManager : MonoSingleton<SceneManager>
	{
		// Token: 0x06000CB8 RID: 3256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x8EE790", Offset = "0x8ED190", VA = "0x1808EE790", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x8EF400", Offset = "0x8EDE00", VA = "0x1808EF400")]
		public void Dispose()
		{
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x8F0240", Offset = "0x8EEC40", VA = "0x1808F0240", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x8EF580", Offset = "0x8EDF80", VA = "0x1808EF580")]
		public void GotoDayScene(Action loadAction)
		{
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x8EF080", Offset = "0x8EDA80", VA = "0x1808EF080", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x8F10A0", Offset = "0x8EFAA0", VA = "0x1808F10A0")]
		public SceneManager()
		{
		}

		// Token: 0x04000B54 RID: 2900
		[Token(Token = "0x4000B54")]
		[FieldOffset(Offset = "0x18")]
		public LoopedBGMPackage bgm;

		// Token: 0x04000B55 RID: 2901
		[Token(Token = "0x4000B55")]
		[FieldOffset(Offset = "0x20")]
		public MainMenuPannel MainPanelParent;

		// Token: 0x04000B56 RID: 2902
		[Token(Token = "0x4000B56")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform PannelRoot;

		// Token: 0x04000B57 RID: 2903
		[Token(Token = "0x4000B57")]
		[FieldOffset(Offset = "0x30")]
		public RectTransform DLCElementRoot;

		// Token: 0x04000B58 RID: 2904
		[Token(Token = "0x4000B58")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MultiLanguageSprite m_TitleSprite;

		// Token: 0x04000B59 RID: 2905
		[Token(Token = "0x4000B59")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image m_TitleImage;
	}
}

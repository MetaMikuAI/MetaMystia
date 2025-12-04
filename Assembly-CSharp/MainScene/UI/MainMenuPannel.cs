using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace MainScene.UI
{
	// Token: 0x0200021B RID: 539
	[Token(Token = "0x200021B")]
	[GenerateCleanupMethod]
	public class MainMenuPannel : BaseSustainedPannel
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000CC4 RID: 3268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000158")]
		public SceneManager SceneManager
		{
			[Token(Token = "0x6000CC3")]
			[Address(RVA = "0x512D40", Offset = "0x511740", VA = "0x180512D40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000CC4")]
			[Address(RVA = "0x516E90", Offset = "0x515890", VA = "0x180516E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x000057D8 File Offset: 0x000039D8
		[Token(Token = "0x17000159")]
		public override AdpUIPanelManager.RequestedInputMode RequestedInputMode
		{
			[Token(Token = "0x6000CC5")]
			[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "17")]
			get
			{
				return AdpUIPanelManager.RequestedInputMode.Player;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x000057F0 File Offset: 0x000039F0
		[Token(Token = "0x1700015A")]
		protected override AdpUIPanelManager.PanelOpenMode PanelOpenMode
		{
			[Token(Token = "0x6000CC6")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "33")]
			get
			{
				return AdpUIPanelManager.PanelOpenMode.DisableCurrentUI;
			}
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CC7")]
		[Address(RVA = "0x4E3810", Offset = "0x4E2210", VA = "0x1804E3810")]
		private void Update()
		{
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "32")]
		protected override void OnExitExtern()
		{
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x8ECD20", Offset = "0x8EB720", VA = "0x1808ECD20", Slot = "34")]
		protected override void OnPannelPostInitialize()
		{
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x8ECCC0", Offset = "0x8EB6C0", VA = "0x1808ECCC0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x8ECF50", Offset = "0x8EB950", VA = "0x1808ECF50", Slot = "38")]
		protected override void OnPannelPostOpen()
		{
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x8ECC30", Offset = "0x8EB630", VA = "0x1808ECC30", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x8ED9F0", Offset = "0x8EC3F0", VA = "0x1808ED9F0")]
		public MainMenuPannel()
		{
		}

		// Token: 0x04000B5D RID: 2909
		[Token(Token = "0x4000B5D")]
		[FieldOffset(Offset = "0x98")]
		public UIButtonSimple ContinueBtn;

		// Token: 0x04000B5E RID: 2910
		[Token(Token = "0x4000B5E")]
		[FieldOffset(Offset = "0xA0")]
		public UIButtonSimple NewGameBtn;

		// Token: 0x04000B5F RID: 2911
		[Token(Token = "0x4000B5F")]
		[FieldOffset(Offset = "0xA8")]
		public UIButtonSimple SavesBtn;

		// Token: 0x04000B60 RID: 2912
		[Token(Token = "0x4000B60")]
		[FieldOffset(Offset = "0xB0")]
		public UIButtonSimple ExitBtn;

		// Token: 0x04000B61 RID: 2913
		[Token(Token = "0x4000B61")]
		[FieldOffset(Offset = "0xB8")]
		private readonly UILogicalGroup m_AllBtns;

		// Token: 0x04000B62 RID: 2914
		[Token(Token = "0x4000B62")]
		[FieldOffset(Offset = "0xC0")]
		private int m_FrameCode;

		// Token: 0x04000B63 RID: 2915
		[Token(Token = "0x4000B63")]
		[FieldOffset(Offset = "0xC8")]
		private KeyValuePair<PlayerSaveFile, int> m_WillLoadSaveFile;
	}
}

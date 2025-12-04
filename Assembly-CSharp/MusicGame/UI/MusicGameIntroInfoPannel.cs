using System;
using Common.UI;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection.Async;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem;

namespace MusicGame.UI
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	[GenerateCleanupMethod]
	public class MusicGameIntroInfoPannel : AsyncUIPanel
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x410880", Offset = "0x40F280", VA = "0x180410880", Slot = "32")]
		protected override UniTaskVoid OnPanelOpenAsync()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x410630", Offset = "0x40F030", VA = "0x180410630", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x4106D0", Offset = "0x40F0D0", VA = "0x1804106D0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x410910", Offset = "0x40F310", VA = "0x180410910")]
		private void OnWillClose(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x4104C0", Offset = "0x40EEC0", VA = "0x1804104C0")]
		private void OnClose()
		{
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x410420", Offset = "0x40EE20", VA = "0x180410420")]
		private void GotoSelectorPannel()
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x410560", Offset = "0x40EF60", VA = "0x180410560")]
		private void OnFadeFinish()
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x410330", Offset = "0x40ED30", VA = "0x180410330", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x410B60", Offset = "0x40F560", VA = "0x180410B60")]
		public MusicGameIntroInfoPannel()
		{
		}

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		private const string EXIT_MUSICGAME_WARNING = "MUSICGAME_WARNING";

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x70")]
		public UIButtonSimple startButton;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x78")]
		public UIButtonSimple endButton;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x80")]
		public UIButtonSimple customButton;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x88")]
		public MusicGameMapSelectPannel mapSelectPannel;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x90")]
		public AssetReference MusicGameMenuBGMPackage;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x98")]
		public DialogBoxPannel DialogBoxPannel;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private MusicCustomizerBootstrapPanel m_BootstrapPanel;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0xA8")]
		private LoopedBGMPackage m_LastPlayingBGMPackage;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0xB0")]
		private IAssetHandle<LoopedBGMPackage> m_LoadedBGMHandle;
	}
}

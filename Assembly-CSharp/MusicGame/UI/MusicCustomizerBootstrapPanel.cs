using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace MusicGame.UI
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	[GenerateCleanupMethod]
	public class MusicCustomizerBootstrapPanel : UIPanel
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x40FFA0", Offset = "0x40E9A0", VA = "0x18040FFA0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x40FEE0", Offset = "0x40E8E0", VA = "0x18040FEE0")]
		private void Launch(string fileName)
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x410110", Offset = "0x40EB10", VA = "0x180410110", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x40FE80", Offset = "0x40E880", VA = "0x18040FE80", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x408E80", Offset = "0x407880", VA = "0x180408E80")]
		public MusicCustomizerBootstrapPanel()
		{
		}

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		private const string MapCreatorExeRelativePath = "Music Map Creator/Music Map Creator.exe";

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		private const string MapPlayerExeRelativePath = "Music Map Player/Music Map Player.exe";

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIButtonSimple m_LaunchMapPlayerBtn;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIButtonSimple m_LaunchMapCreatorBtn;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIButtonSimple m_BackBtn;
	}
}

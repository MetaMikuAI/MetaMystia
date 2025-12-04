using System;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace MusicGame.UI
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	[GenerateCleanupMethod]
	public class MusicSelectorInfoPannel : UIPanelExtern
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600023B RID: 571 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x17000041")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x426FE0", Offset = "0x4259E0", VA = "0x180426FE0")]
		public void SetMusicLabel(string data)
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "32")]
		protected override void OnExitExtern()
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x426FB0", Offset = "0x4259B0", VA = "0x180426FB0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x410B60", Offset = "0x40F560", VA = "0x180410B60")]
		public MusicSelectorInfoPannel()
		{
		}

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIElementCluster m_UIElementCluster;
	}
}

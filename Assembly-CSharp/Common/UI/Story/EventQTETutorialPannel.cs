using System;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace Common.UI.Story
{
	// Token: 0x02000F5F RID: 3935
	[Token(Token = "0x2000F5F")]
	[GenerateCleanupMethod]
	public class EventQTETutorialPannel : UIPanel
	{
		// Token: 0x06005C88 RID: 23688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C88")]
		[Address(RVA = "0x8AB410", Offset = "0x8A9E10", VA = "0x1808AB410", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005C89 RID: 23689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C89")]
		[Address(RVA = "0x8AB5C0", Offset = "0x8A9FC0", VA = "0x1808AB5C0")]
		private void OpenPannel(EventQTETutorialSubPannel pannelPrefab, Action<EventQTETutorialSubPannel.PannelCloseType> onPannelClose)
		{
		}

		// Token: 0x06005C8A RID: 23690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8A")]
		[Address(RVA = "0x8AB410", Offset = "0x8A9E10", VA = "0x1808AB410")]
		private void OpenPanelA()
		{
		}

		// Token: 0x06005C8B RID: 23691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8B")]
		[Address(RVA = "0x8AB4A0", Offset = "0x8A9EA0", VA = "0x1808AB4A0")]
		private void OpenPanelB()
		{
		}

		// Token: 0x06005C8C RID: 23692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8C")]
		[Address(RVA = "0x8AB530", Offset = "0x8A9F30", VA = "0x1808AB530")]
		private void OpenPanelC()
		{
		}

		// Token: 0x06005C8D RID: 23693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8D")]
		[Address(RVA = "0x8AB3C0", Offset = "0x8A9DC0", VA = "0x1808AB3C0")]
		private void OnPanelClose(EventQTETutorialSubPannel.PannelCloseType closeInfo, Action prev, Action next)
		{
		}

		// Token: 0x06005C8E RID: 23694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8E")]
		[Address(RVA = "0x8AB160", Offset = "0x8A9B60", VA = "0x1808AB160")]
		private void OnPanelAClose(EventQTETutorialSubPannel.PannelCloseType closeInfo)
		{
		}

		// Token: 0x06005C8F RID: 23695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C8F")]
		[Address(RVA = "0x8AB200", Offset = "0x8A9C00", VA = "0x1808AB200")]
		private void OnPanelBClose(EventQTETutorialSubPannel.PannelCloseType closeInfo)
		{
		}

		// Token: 0x06005C90 RID: 23696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C90")]
		[Address(RVA = "0x8AB2E0", Offset = "0x8A9CE0", VA = "0x1808AB2E0")]
		private void OnPanelCClose(EventQTETutorialSubPannel.PannelCloseType closeInfo)
		{
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C91")]
		[Address(RVA = "0x40FE80", Offset = "0x40E880", VA = "0x18040FE80", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005C92 RID: 23698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C92")]
		[Address(RVA = "0x408E80", Offset = "0x407880", VA = "0x180408E80")]
		public EventQTETutorialPannel()
		{
		}

		// Token: 0x040055BA RID: 21946
		[Token(Token = "0x40055BA")]
		[FieldOffset(Offset = "0x70")]
		public EventQTETutorialSubPannel pageA;

		// Token: 0x040055BB RID: 21947
		[Token(Token = "0x40055BB")]
		[FieldOffset(Offset = "0x78")]
		public EventQTETutorialSubPannel pageB;

		// Token: 0x040055BC RID: 21948
		[Token(Token = "0x40055BC")]
		[FieldOffset(Offset = "0x80")]
		public EventQTETutorialSubPannel pageC;
	}
}

using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace PrepNightScene.UI
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	[GenerateCleanupMethod]
	public class IzakayaConfigSubPannel : UISubPanel<IzakayaConfigPannel>
	{
		// Token: 0x0600046C RID: 1132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x56C970", Offset = "0x56B370", VA = "0x18056C970", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x56CDD0", Offset = "0x56B7D0", VA = "0x18056CDD0", Slot = "33")]
		protected virtual void SetLogicalGroup()
		{
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x56CD10", Offset = "0x56B710", VA = "0x18056CD10")]
		private void OpenPreset()
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x56CCB0", Offset = "0x56B6B0", VA = "0x18056CCB0")]
		private void OpenFilter()
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x56C910", Offset = "0x56B310", VA = "0x18056C910", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x56CC60", Offset = "0x56B660", VA = "0x18056CC60", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x56C870", Offset = "0x56B270", VA = "0x18056C870", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x56C830", Offset = "0x56B230", VA = "0x18056C830")]
		public IzakayaConfigSubPannel()
		{
		}

		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		[FieldOffset(Offset = "0x78")]
		public UIButtonSimple NoteBookBtn;

		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		[FieldOffset(Offset = "0x80")]
		public UIButtonSimple StorageBtn;

		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		[FieldOffset(Offset = "0x88")]
		public UIButtonSimple PresetBtn;

		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x90")]
		public UIButtonSimple FilterBtn;

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x98")]
		public IzakayaPresetPannel SubPannel;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0xA0")]
		protected UILogicalGroup m_LogicalGroup;
	}
}

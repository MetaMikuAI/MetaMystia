using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.PanelCollection.Async;
using GameData.CoreLanguage;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000E35 RID: 3637
	[Token(Token = "0x2000E35")]
	[GenerateCleanupMethod]
	public class DLC4_DaySceneFishingResultPanel : AsyncUIPanel
	{
		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06005500 RID: 21760 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005501 RID: 21761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BFA")]
		public ObjectLanguageBase TrophyResult
		{
			[Token(Token = "0x6005500")]
			[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6005501")]
			[Address(RVA = "0x45F1B0", Offset = "0x45DBB0", VA = "0x18045F1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005502")]
		[Address(RVA = "0x833500", Offset = "0x831F00", VA = "0x180833500", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x0001E570 File Offset: 0x0001C770
		[Token(Token = "0x6005503")]
		[Address(RVA = "0x833670", Offset = "0x832070", VA = "0x180833670", Slot = "32")]
		protected override UniTaskVoid OnPanelOpenAsync()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005504")]
		[Address(RVA = "0x833700", Offset = "0x832100", VA = "0x180833700")]
		private void TryClose()
		{
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005505")]
		[Address(RVA = "0x8334C0", Offset = "0x831EC0", VA = "0x1808334C0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005506 RID: 21766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005506")]
		[Address(RVA = "0x833460", Offset = "0x831E60", VA = "0x180833460", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005507 RID: 21767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005507")]
		[Address(RVA = "0x410B60", Offset = "0x40F560", VA = "0x180410B60")]
		public DLC4_DaySceneFishingResultPanel()
		{
		}

		// Token: 0x04004FE2 RID: 20450
		[Token(Token = "0x4004FE2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Animator m_Animator;

		// Token: 0x04004FE3 RID: 20451
		[Token(Token = "0x4004FE3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ObjectLanguageBaseDescriber m_Describer;

		// Token: 0x04004FE4 RID: 20452
		[Token(Token = "0x4004FE4")]
		[FieldOffset(Offset = "0x80")]
		private bool canClose;
	}
}

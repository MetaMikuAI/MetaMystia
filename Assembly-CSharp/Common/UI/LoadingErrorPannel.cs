using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000E50 RID: 3664
	[Token(Token = "0x2000E50")]
	[GenerateCleanupMethod]
	public class LoadingErrorPannel : UIPanel
	{
		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x060055B1 RID: 21937 RVA: 0x0001E768 File Offset: 0x0001C968
		// (set) Token: 0x060055B2 RID: 21938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C03")]
		public bool QuitOnExitPanel
		{
			[Token(Token = "0x60055B1")]
			[Address(RVA = "0x608690", Offset = "0x607090", VA = "0x180608690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60055B2")]
			[Address(RVA = "0x6086E0", Offset = "0x6070E0", VA = "0x1806086E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B3")]
		[Address(RVA = "0x852380", Offset = "0x850D80", VA = "0x180852380")]
		public void AddErrorMessage(string message)
		{
		}

		// Token: 0x060055B4 RID: 21940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B4")]
		[Address(RVA = "0x8523F0", Offset = "0x850DF0", VA = "0x1808523F0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060055B5 RID: 21941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B5")]
		[Address(RVA = "0x852530", Offset = "0x850F30", VA = "0x180852530", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060055B6 RID: 21942 RVA: 0x0001E780 File Offset: 0x0001C980
		[Token(Token = "0x60055B6")]
		[Address(RVA = "0x8524A0", Offset = "0x850EA0", VA = "0x1808524A0")]
		protected UniTaskVoid OnPanelOpenAsync()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B7")]
		[Address(RVA = "0x40C160", Offset = "0x40AB60", VA = "0x18040C160", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060055B8 RID: 21944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055B8")]
		[Address(RVA = "0x852630", Offset = "0x851030", VA = "0x180852630")]
		public LoadingErrorPannel()
		{
		}

		// Token: 0x04005074 RID: 20596
		[Token(Token = "0x4005074")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TextMeshProUGUI m_ErrorMsg;

		// Token: 0x04005075 RID: 20597
		[Token(Token = "0x4005075")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIButtonSimple m_QuitGameBtn;

		// Token: 0x04005076 RID: 20598
		[Token(Token = "0x4005076")]
		[FieldOffset(Offset = "0x80")]
		private readonly StringBuilder m_StringBuilder;
	}
}

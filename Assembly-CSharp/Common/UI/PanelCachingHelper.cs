using System;
using System.Runtime.InteropServices;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;

namespace Common.UI
{
	// Token: 0x02000DB6 RID: 3510
	[Token(Token = "0x2000DB6")]
	public static class PanelCachingHelper
	{
		// Token: 0x06005259 RID: 21081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005259")]
		public static T PrepareOrGetTempPanelInstance<T>(this T panelParent, [Optional] string bufferPanelLabel) where T : UIPanelBaseImpl
		{
			return null;
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600525A")]
		public static T PrepareBufferedPanelWithRecord<T>(this T panelParent, [Optional] Action<T> preInitializeCallback, [Optional] string bufferPanelLabel) where T : UIPanelBaseImpl
		{
			return null;
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600525B")]
		public static T PreBufferPanelWithRecord<T>(this T panelParent, [Optional] string bufferPanelLabel) where T : UIPanelBaseImpl
		{
			return null;
		}
	}
}

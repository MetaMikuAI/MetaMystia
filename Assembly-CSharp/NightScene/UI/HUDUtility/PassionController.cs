using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020006F1 RID: 1777
	[Token(Token = "0x20006F1")]
	[GenerateCleanupMethod]
	public class PassionController : MonoBehaviour
	{
		// Token: 0x06002A21 RID: 10785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A21")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A22")]
		[Address(RVA = "0x585C20", Offset = "0x584620", VA = "0x180585C20")]
		public void SetValue(int percentage, int musicLevel)
		{
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A23")]
		[Address(RVA = "0x3EA340", Offset = "0x3E8D40", VA = "0x1803EA340", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A24")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public PassionController()
		{
		}

		// Token: 0x040026A5 RID: 9893
		[Token(Token = "0x40026A5")]
		[FieldOffset(Offset = "0x18")]
		public Image fill;

		// Token: 0x040026A6 RID: 9894
		[Token(Token = "0x40026A6")]
		[FieldOffset(Offset = "0x20")]
		public Color i;

		// Token: 0x040026A7 RID: 9895
		[Token(Token = "0x40026A7")]
		[FieldOffset(Offset = "0x30")]
		public Color ii;

		// Token: 0x040026A8 RID: 9896
		[Token(Token = "0x40026A8")]
		[FieldOffset(Offset = "0x40")]
		public Color iii;
	}
}

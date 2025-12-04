using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.MusicUtility
{
	// Token: 0x020006F8 RID: 1784
	[Token(Token = "0x20006F8")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(Image))]
	public class SequentialImageTransition : MonoBehaviour
	{
		// Token: 0x06002A3F RID: 10815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A3F")]
		[Address(RVA = "0x585CC0", Offset = "0x5846C0", VA = "0x180585CC0")]
		protected void OnEnable()
		{
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A40")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A41")]
		[Address(RVA = "0x585D20", Offset = "0x584720", VA = "0x180585D20")]
		public void OnProgressUpdate(float progress)
		{
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A42")]
		[Address(RVA = "0x3EE530", Offset = "0x3ECF30", VA = "0x1803EE530", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A43")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public SequentialImageTransition()
		{
		}

		// Token: 0x040026CA RID: 9930
		[Token(Token = "0x40026CA")]
		[FieldOffset(Offset = "0x18")]
		public Image image;

		// Token: 0x040026CB RID: 9931
		[Token(Token = "0x40026CB")]
		[FieldOffset(Offset = "0x20")]
		public Sprite[] imageSequence;
	}
}

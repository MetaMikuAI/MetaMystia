using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020006CF RID: 1743
	[Token(Token = "0x20006CF")]
	[GenerateCleanupMethod]
	public class ComboController : MonoBehaviour
	{
		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06002946 RID: 10566 RVA: 0x0000F180 File Offset: 0x0000D380
		// (set) Token: 0x06002947 RID: 10567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C9")]
		public bool ReverseAdd
		{
			[Token(Token = "0x6002946")]
			[Address(RVA = "0x545D90", Offset = "0x544790", VA = "0x180545D90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002947")]
			[Address(RVA = "0x545DA0", Offset = "0x5447A0", VA = "0x180545DA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002948")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002949")]
		[Address(RVA = "0x545AE0", Offset = "0x5444E0", VA = "0x180545AE0")]
		public void SetCombo(int value)
		{
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600294A")]
		[Address(RVA = "0x545A50", Offset = "0x544450", VA = "0x180545A50")]
		private IEnumerator OnComboIlluminationUpdating(float fadeSpeed)
		{
			return null;
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294B")]
		[Address(RVA = "0x545950", Offset = "0x544350", VA = "0x180545950", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294C")]
		[Address(RVA = "0x545D70", Offset = "0x544770", VA = "0x180545D70")]
		public ComboController()
		{
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600294D")]
		[Address(RVA = "0x545CF0", Offset = "0x5446F0", VA = "0x180545CF0")]
		[CompilerGenerated]
		private Sprite <SetCombo>g__GetCorrspondingSprite|21_0(int digit)
		{
			return null;
		}

		// Token: 0x040025B4 RID: 9652
		[Token(Token = "0x40025B4")]
		[FieldOffset(Offset = "0x18")]
		public Sprite i;

		// Token: 0x040025B5 RID: 9653
		[Token(Token = "0x40025B5")]
		[FieldOffset(Offset = "0x20")]
		public Sprite ii;

		// Token: 0x040025B6 RID: 9654
		[Token(Token = "0x40025B6")]
		[FieldOffset(Offset = "0x28")]
		public Sprite iii;

		// Token: 0x040025B7 RID: 9655
		[Token(Token = "0x40025B7")]
		[FieldOffset(Offset = "0x30")]
		public Sprite iv;

		// Token: 0x040025B8 RID: 9656
		[Token(Token = "0x40025B8")]
		[FieldOffset(Offset = "0x38")]
		public Sprite v;

		// Token: 0x040025B9 RID: 9657
		[Token(Token = "0x40025B9")]
		[FieldOffset(Offset = "0x40")]
		public Sprite vi;

		// Token: 0x040025BA RID: 9658
		[Token(Token = "0x40025BA")]
		[FieldOffset(Offset = "0x48")]
		public Sprite vii;

		// Token: 0x040025BB RID: 9659
		[Token(Token = "0x40025BB")]
		[FieldOffset(Offset = "0x50")]
		public Sprite viii;

		// Token: 0x040025BC RID: 9660
		[Token(Token = "0x40025BC")]
		[FieldOffset(Offset = "0x58")]
		public Sprite ix;

		// Token: 0x040025BD RID: 9661
		[Token(Token = "0x40025BD")]
		[FieldOffset(Offset = "0x60")]
		public Sprite o;

		// Token: 0x040025BE RID: 9662
		[Token(Token = "0x40025BE")]
		[FieldOffset(Offset = "0x68")]
		public Image hundredth;

		// Token: 0x040025BF RID: 9663
		[Token(Token = "0x40025BF")]
		[FieldOffset(Offset = "0x70")]
		public Image tens;

		// Token: 0x040025C0 RID: 9664
		[Token(Token = "0x40025C0")]
		[FieldOffset(Offset = "0x78")]
		public Image unit;

		// Token: 0x040025C1 RID: 9665
		[Token(Token = "0x40025C1")]
		[FieldOffset(Offset = "0x80")]
		public Image illumination;

		// Token: 0x040025C2 RID: 9666
		[Token(Token = "0x40025C2")]
		[FieldOffset(Offset = "0x88")]
		public Color onDeductingComboColor;

		// Token: 0x040025C3 RID: 9667
		[Token(Token = "0x40025C3")]
		[FieldOffset(Offset = "0x98")]
		private int current;
	}
}

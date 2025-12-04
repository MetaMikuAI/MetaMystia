using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DEYU.Singletons;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000DB2 RID: 3506
	[Token(Token = "0x2000DB2")]
	[RequireComponent(typeof(CanvasGroup))]
	[GenerateCleanupMethod]
	public class KizunaStatusNotifier : MonoSingleton<KizunaStatusNotifier>
	{
		// Token: 0x06005240 RID: 21056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005240")]
		[Address(RVA = "0x7FE100", Offset = "0x7FCB00", VA = "0x1807FE100", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005241")]
		[Address(RVA = "0x7FE3B0", Offset = "0x7FCDB0", VA = "0x1807FE3B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005242")]
		[Address(RVA = "0x7FE450", Offset = "0x7FCE50", VA = "0x1807FE450")]
		private void SetAlpha(float alpha)
		{
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005243")]
		[Address(RVA = "0x7FE280", Offset = "0x7FCC80", VA = "0x1807FE280")]
		public void Notify(string characterName, bool add)
		{
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005244")]
		[Address(RVA = "0x7FE220", Offset = "0x7FCC20", VA = "0x1807FE220", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005245")]
		[Address(RVA = "0x7FE580", Offset = "0x7FCF80", VA = "0x1807FE580")]
		public KizunaStatusNotifier()
		{
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005246")]
		[Address(RVA = "0x7FE500", Offset = "0x7FCF00", VA = "0x1807FE500")]
		[CompilerGenerated]
		private IEnumerator <Notify>g__HideDelayed|8_0()
		{
			return null;
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005247")]
		[Address(RVA = "0x7FE470", Offset = "0x7FCE70", VA = "0x1807FE470")]
		[CompilerGenerated]
		private void <Notify>g__GotoNext|8_1()
		{
		}

		// Token: 0x04004D2C RID: 19756
		[Token(Token = "0x4004D2C")]
		[FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI characterName;

		// Token: 0x04004D2D RID: 19757
		[Token(Token = "0x4004D2D")]
		[FieldOffset(Offset = "0x20")]
		public GameObject add;

		// Token: 0x04004D2E RID: 19758
		[Token(Token = "0x4004D2E")]
		[FieldOffset(Offset = "0x28")]
		public GameObject deduct;

		// Token: 0x04004D2F RID: 19759
		[Token(Token = "0x4004D2F")]
		[FieldOffset(Offset = "0x30")]
		public float notifyDuration;

		// Token: 0x04004D30 RID: 19760
		[Token(Token = "0x4004D30")]
		[FieldOffset(Offset = "0x38")]
		private CanvasGroup canvasGroup;
	}
}

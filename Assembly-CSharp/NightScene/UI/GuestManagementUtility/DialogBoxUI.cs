using System;
using System.Collections;
using System.Threading;
using Common;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.UI.GuestManagementUtility
{
	// Token: 0x020006BD RID: 1725
	[Token(Token = "0x20006BD")]
	[RequireComponent(typeof(WorldSpaceUITracker))]
	[GenerateCleanupMethod]
	public class DialogBoxUI : MonoBehaviour
	{
		// Token: 0x060028D0 RID: 10448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D0")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028D1")]
		[Address(RVA = "0x546BC0", Offset = "0x5455C0", VA = "0x180546BC0")]
		public IEnumerator SetMessage(string message, Transform followTarget, float overrideShowDuration = -1f)
		{
			return null;
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x0000EF40 File Offset: 0x0000D140
		[Token(Token = "0x60028D2")]
		[Address(RVA = "0x5469A0", Offset = "0x5453A0", VA = "0x1805469A0")]
		public UniTask SetMessageAsync(string message, Transform followTarget, bool waitUntilFadeOutFinish, float overrideShowDuration = -1f)
		{
			return default(UniTask);
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D3")]
		[Address(RVA = "0x546980", Offset = "0x545380", VA = "0x180546980")]
		public void Interrupt()
		{
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D4")]
		[Address(RVA = "0x3E85F0", Offset = "0x3E6FF0", VA = "0x1803E85F0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028D5")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public DialogBoxUI()
		{
		}

		// Token: 0x0400253B RID: 9531
		[Token(Token = "0x400253B")]
		private const float DIALOG_BOX_OFFSET = 1.5f;

		// Token: 0x0400253C RID: 9532
		[Token(Token = "0x400253C")]
		private const float DIALOG_BOX_SHOW_DURATION = 5f;

		// Token: 0x0400253D RID: 9533
		[Token(Token = "0x400253D")]
		[FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI text;

		// Token: 0x0400253E RID: 9534
		[Token(Token = "0x400253E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WorldSpaceUITracker m_WorldSpaceUITracker;

		// Token: 0x0400253F RID: 9535
		[Token(Token = "0x400253F")]
		[FieldOffset(Offset = "0x28")]
		private CancellationTokenSource m_CancellationTokenSource;
	}
}

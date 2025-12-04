using System;
using System.Threading;
using Il2CppDummyDll;
using Plugins.DEYU;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000210 RID: 528
	[Token(Token = "0x2000210")]
	[GenerateCleanupMethod]
	public class DLC4_ChallengeCardSelectorPanel_Describer : MonoBehaviour
	{
		// Token: 0x06000C94 RID: 3220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x8E6B50", Offset = "0x8E5550", VA = "0x1808E6B50")]
		private void Awake()
		{
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x8E6C70", Offset = "0x8E5670", VA = "0x1808E6C70")]
		public void SetVisual(bool enable, bool immediateMode)
		{
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C96")]
		[Address(RVA = "0x8E6B60", Offset = "0x8E5560", VA = "0x1808E6B60")]
		public void Describe(GuestGuardMapping mapping, CancellationToken token)
		{
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C97")]
		[Address(RVA = "0x3EEA30", Offset = "0x3ED430", VA = "0x1803EEA30", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C98")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public DLC4_ChallengeCardSelectorPanel_Describer()
		{
		}

		// Token: 0x04000B33 RID: 2867
		[Token(Token = "0x4000B33")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActionExecutionScheduler m_Scheduler;

		// Token: 0x04000B34 RID: 2868
		[Token(Token = "0x4000B34")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup m_DescriberCanvas;

		// Token: 0x04000B35 RID: 2869
		[Token(Token = "0x4000B35")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup m_DescriberSecondaryCanvas;

		// Token: 0x04000B36 RID: 2870
		[Token(Token = "0x4000B36")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI m_ManualText;

		// Token: 0x04000B37 RID: 2871
		[Token(Token = "0x4000B37")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI m_HPText;

		// Token: 0x04000B38 RID: 2872
		[Token(Token = "0x4000B38")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI m_NameText;
	}
}

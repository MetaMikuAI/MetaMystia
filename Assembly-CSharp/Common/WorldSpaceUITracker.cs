using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common
{
	// Token: 0x02000D81 RID: 3457
	[Token(Token = "0x2000D81")]
	[GenerateCleanupMethod]
	public class WorldSpaceUITracker : MonoBehaviour
	{
		// Token: 0x06005103 RID: 20739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005103")]
		[Address(RVA = "0x7F96F0", Offset = "0x7F80F0", VA = "0x1807F96F0")]
		private void Awake()
		{
		}

		// Token: 0x06005104 RID: 20740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005104")]
		[Address(RVA = "0x7F97C0", Offset = "0x7F81C0", VA = "0x1807F97C0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06005105 RID: 20741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005105")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005106 RID: 20742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005106")]
		[Address(RVA = "0x7F9860", Offset = "0x7F8260", VA = "0x1807F9860")]
		public void FocusToTarget(Transform followTarget, Vector3 worldOffset)
		{
		}

		// Token: 0x06005107 RID: 20743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005107")]
		[Address(RVA = "0x7F99A0", Offset = "0x7F83A0", VA = "0x1807F99A0")]
		private void RefreshPosition()
		{
		}

		// Token: 0x06005108 RID: 20744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005108")]
		[Address(RVA = "0x7F9770", Offset = "0x7F8170", VA = "0x1807F9770", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06005109 RID: 20745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005109")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public WorldSpaceUITracker()
		{
		}

		// Token: 0x04004C01 RID: 19457
		[Token(Token = "0x4004C01")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3 m_WorldOffset;

		// Token: 0x04004C02 RID: 19458
		[Token(Token = "0x4004C02")]
		[FieldOffset(Offset = "0x28")]
		private Camera m_Camera;

		// Token: 0x04004C03 RID: 19459
		[Token(Token = "0x4004C03")]
		[FieldOffset(Offset = "0x30")]
		private Canvas m_Canvas;

		// Token: 0x04004C04 RID: 19460
		[Token(Token = "0x4004C04")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_FollowTarget;
	}
}

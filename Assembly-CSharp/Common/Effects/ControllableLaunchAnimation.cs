using System;
using System.Collections;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.Effects
{
	// Token: 0x02000DA2 RID: 3490
	[Token(Token = "0x2000DA2")]
	[GenerateCleanupMethod]
	public class ControllableLaunchAnimation : MonoBehaviour
	{
		// Token: 0x060051DF RID: 20959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051DF")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E0")]
		[Address(RVA = "0x7FAC70", Offset = "0x7F9670", VA = "0x1807FAC70")]
		public void Initialize()
		{
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E1")]
		[Address(RVA = "0x7FAD40", Offset = "0x7F9740", VA = "0x1807FAD40")]
		public IEnumerator Setup(Vector3 startPosition, Vector3 launchDestination, Sprite targetSprite)
		{
			return null;
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051E2")]
		[Address(RVA = "0x7FACC0", Offset = "0x7F96C0", VA = "0x1807FACC0")]
		private IEnumerator OnLaunch()
		{
			return null;
		}

		// Token: 0x060051E3 RID: 20963 RVA: 0x0001DBB0 File Offset: 0x0001BDB0
		[Token(Token = "0x60051E3")]
		[Address(RVA = "0x7FAE10", Offset = "0x7F9810", VA = "0x1807FAE10")]
		private Vector3 SolveBezierLocation(float t)
		{
			return default(Vector3);
		}

		// Token: 0x060051E4 RID: 20964 RVA: 0x0001DBC8 File Offset: 0x0001BDC8
		[Token(Token = "0x60051E4")]
		[Address(RVA = "0x7FAF60", Offset = "0x7F9960", VA = "0x1807FAF60")]
		private float SolveLaunchSpeed(float t)
		{
			return 0f;
		}

		// Token: 0x060051E5 RID: 20965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E5")]
		[Address(RVA = "0x7FAC50", Offset = "0x7F9650", VA = "0x1807FAC50", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060051E6 RID: 20966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051E6")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public ControllableLaunchAnimation()
		{
		}

		// Token: 0x04004CFE RID: 19710
		[Token(Token = "0x4004CFE")]
		[FieldOffset(Offset = "0x18")]
		public float launchHeight;

		// Token: 0x04004CFF RID: 19711
		[Token(Token = "0x4004CFF")]
		[FieldOffset(Offset = "0x1C")]
		public float launchSpeed;

		// Token: 0x04004D00 RID: 19712
		[Token(Token = "0x4004D00")]
		[FieldOffset(Offset = "0x20")]
		[Range(0.01f, 1f)]
		public float launchWeight;

		// Token: 0x04004D01 RID: 19713
		[Token(Token = "0x4004D01")]
		[FieldOffset(Offset = "0x24")]
		private float distance;

		// Token: 0x04004D02 RID: 19714
		[Token(Token = "0x4004D02")]
		[FieldOffset(Offset = "0x28")]
		private ParticleSystem effect;

		// Token: 0x04004D03 RID: 19715
		[Token(Token = "0x4004D03")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 start;

		// Token: 0x04004D04 RID: 19716
		[Token(Token = "0x4004D04")]
		[FieldOffset(Offset = "0x3C")]
		private Vector3 control;

		// Token: 0x04004D05 RID: 19717
		[Token(Token = "0x4004D05")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 dest;
	}
}

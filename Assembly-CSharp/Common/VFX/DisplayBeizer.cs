using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.VFX
{
	// Token: 0x02000DA5 RID: 3493
	[Token(Token = "0x2000DA5")]
	[GenerateCleanupMethod]
	[ExecuteAlways]
	public class DisplayBeizer : MonoBehaviour
	{
		// Token: 0x060051F3 RID: 20979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F3")]
		[Address(RVA = "0x7FC810", Offset = "0x7FB210", VA = "0x1807FC810")]
		private void Update()
		{
		}

		// Token: 0x060051F4 RID: 20980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F4")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x060051F5 RID: 20981 RVA: 0x0001DC10 File Offset: 0x0001BE10
		[Token(Token = "0x60051F5")]
		[Address(RVA = "0x7FC660", Offset = "0x7FB060", VA = "0x1807FC660")]
		public static Vector3 SolveBezierLocation(Vector3 start, Vector3 control, Vector3 target, float t)
		{
			return default(Vector3);
		}

		// Token: 0x060051F6 RID: 20982 RVA: 0x0001DC28 File Offset: 0x0001BE28
		[Token(Token = "0x60051F6")]
		[Address(RVA = "0x7FC4F0", Offset = "0x7FAEF0", VA = "0x1807FC4F0")]
		public static Vector3 SolveBezierLocationCubic(Vector3 start, Vector3 control1, Vector3 control2, Vector3 target, float t)
		{
			return default(Vector3);
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F7")]
		[Address(RVA = "0x3E85F0", Offset = "0x3E6FF0", VA = "0x1803E85F0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051F8")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public DisplayBeizer()
		{
		}

		// Token: 0x04004D10 RID: 19728
		[Token(Token = "0x4004D10")]
		[FieldOffset(Offset = "0x18")]
		public Transform start;

		// Token: 0x04004D11 RID: 19729
		[Token(Token = "0x4004D11")]
		[FieldOffset(Offset = "0x20")]
		public Transform target;

		// Token: 0x04004D12 RID: 19730
		[Token(Token = "0x4004D12")]
		[FieldOffset(Offset = "0x28")]
		public LineRenderer trail;

		// Token: 0x04004D13 RID: 19731
		[Token(Token = "0x4004D13")]
		[FieldOffset(Offset = "0x30")]
		public float height;

		// Token: 0x04004D14 RID: 19732
		[Token(Token = "0x4004D14")]
		[FieldOffset(Offset = "0x34")]
		public int steps;

		// Token: 0x04004D15 RID: 19733
		[Token(Token = "0x4004D15")]
		[FieldOffset(Offset = "0x38")]
		[Range(0.5f, 1f)]
		public float maxSteps;
	}
}

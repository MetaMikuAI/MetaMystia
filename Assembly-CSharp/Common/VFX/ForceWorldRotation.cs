using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.VFX
{
	// Token: 0x02000DA7 RID: 3495
	[Token(Token = "0x2000DA7")]
	[ExecuteAlways]
	[GenerateCleanupMethod]
	public class ForceWorldRotation : MonoBehaviour
	{
		// Token: 0x060051FE RID: 20990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FE")]
		[Address(RVA = "0x7FD7F0", Offset = "0x7FC1F0", VA = "0x1807FD7F0")]
		private void Update()
		{
		}

		// Token: 0x060051FF RID: 20991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FF")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005200")]
		[Address(RVA = "0x7FD7F0", Offset = "0x7FC1F0", VA = "0x1807FD7F0")]
		private void OnValidate()
		{
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005201")]
		[Address(RVA = "0x7FD7F0", Offset = "0x7FC1F0", VA = "0x1807FD7F0")]
		private void UpdateEuler()
		{
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005202")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005203")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public ForceWorldRotation()
		{
		}

		// Token: 0x04004D18 RID: 19736
		[Token(Token = "0x4004D18")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 worldEulerAngles;
	}
}

using System;
using DEYU.Utils.MaterialController;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.VFX
{
	// Token: 0x02000DA8 RID: 3496
	[Token(Token = "0x2000DA8")]
	[ExecuteAlways]
	[GenerateCleanupMethod]
	public class UIDistortionMaterialController : MaterialControllerBase
	{
		// Token: 0x06005204 RID: 20996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005204")]
		[Address(RVA = "0x4043B0", Offset = "0x402DB0", VA = "0x1804043B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005205 RID: 20997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005205")]
		[Address(RVA = "0x8128C0", Offset = "0x8112C0", VA = "0x1808128C0", Slot = "4")]
		protected override void OnUpdatingAllProperties()
		{
		}

		// Token: 0x06005206 RID: 20998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005206")]
		[Address(RVA = "0x812870", Offset = "0x811270", VA = "0x180812870", Slot = "5")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005207")]
		[Address(RVA = "0x812AD0", Offset = "0x8114D0", VA = "0x180812AD0")]
		public UIDistortionMaterialController()
		{
		}

		// Token: 0x04004D19 RID: 19737
		[Token(Token = "0x4004D19")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D mainTex;

		// Token: 0x04004D1A RID: 19738
		[Token(Token = "0x4004D1A")]
		[FieldOffset(Offset = "0x28")]
		public Texture2D noiseTex;

		// Token: 0x04004D1B RID: 19739
		[Token(Token = "0x4004D1B")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D noiseTex2;

		// Token: 0x04004D1C RID: 19740
		[Token(Token = "0x4004D1C")]
		[FieldOffset(Offset = "0x38")]
		public Color mainColor;

		// Token: 0x04004D1D RID: 19741
		[Token(Token = "0x4004D1D")]
		[FieldOffset(Offset = "0x48")]
		[Range(-1f, 2f)]
		public float dissiolve;

		// Token: 0x04004D1E RID: 19742
		[Token(Token = "0x4004D1E")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float edgeWidth;

		// Token: 0x04004D1F RID: 19743
		[Token(Token = "0x4004D1F")]
		[FieldOffset(Offset = "0x50")]
		public Color edgeColor;

		// Token: 0x04004D20 RID: 19744
		[Token(Token = "0x4004D20")]
		[FieldOffset(Offset = "0x60")]
		public float edgePower;

		// Token: 0x04004D21 RID: 19745
		[Token(Token = "0x4004D21")]
		[FieldOffset(Offset = "0x64")]
		public float noiseSpeed_U;

		// Token: 0x04004D22 RID: 19746
		[Token(Token = "0x4004D22")]
		[FieldOffset(Offset = "0x68")]
		public float noiseSpeed_V;

		// Token: 0x04004D23 RID: 19747
		[Token(Token = "0x4004D23")]
		[FieldOffset(Offset = "0x6C")]
		public float noiseSpeed;

		// Token: 0x04004D24 RID: 19748
		[Token(Token = "0x4004D24")]
		[FieldOffset(Offset = "0x70")]
		public Vector4 noise_uv;

		// Token: 0x04004D25 RID: 19749
		[Token(Token = "0x4004D25")]
		[FieldOffset(Offset = "0x80")]
		public float lerp_Alpha;
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000A RID: 10
[Token(Token = "0x200000A")]
[ExecuteAlways]
public class CanvasScaleShaderInjector : MonoBehaviour
{
	// Token: 0x06000022 RID: 34 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x406CF0", Offset = "0x4056F0", VA = "0x180406CF0")]
	private void OnRectTransformDimensionsChange()
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x406D30", Offset = "0x405730", VA = "0x180406D30")]
	public CanvasScaleShaderInjector()
	{
	}

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform m_RectTransform;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_ShaderKeyword;
}

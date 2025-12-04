using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000011 RID: 17
[Token(Token = "0x2000011")]
[ExecuteAlways]
public class UnscaledTimeShaderInjector : MonoBehaviour
{
	// Token: 0x0600004A RID: 74 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x4210A0", Offset = "0x41FAA0", VA = "0x1804210A0")]
	private void Update()
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x421100", Offset = "0x41FB00", VA = "0x180421100")]
	public UnscaledTimeShaderInjector()
	{
	}

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string m_ShaderKeyword;
}

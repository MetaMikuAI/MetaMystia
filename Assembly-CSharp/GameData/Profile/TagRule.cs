using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BD1 RID: 3025
	[Token(Token = "0x2000BD1")]
	[Serializable]
	public class TagRule
	{
		// Token: 0x060046D6 RID: 18134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D6")]
		[Address(RVA = "0x46BA70", Offset = "0x46A470", VA = "0x18046BA70")]
		public TagRule(int[] rule)
		{
		}

		// Token: 0x04003FFC RID: 16380
		[Token(Token = "0x4003FFC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public int[] rule;
	}
}

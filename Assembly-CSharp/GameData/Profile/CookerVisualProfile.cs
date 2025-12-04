using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B7E RID: 2942
	[Token(Token = "0x2000B7E")]
	[CreateAssetMenu(fileName = "CookerProfile", menuName = "GameData Profile/CreateCookerVisualProfile", order = 3)]
	public class CookerVisualProfile : ScriptableObject
	{
		// Token: 0x06004632 RID: 17970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004632")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public CookerVisualProfile()
		{
		}

		// Token: 0x04003E19 RID: 15897
		[Token(Token = "0x4003E19")]
		[FieldOffset(Offset = "0x18")]
		public VisualIdPair[] tiles;
	}
}

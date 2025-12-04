using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BB5 RID: 2997
	[Token(Token = "0x2000BB5")]
	[CreateAssetMenu(fileName = "NPCVisualProfile", menuName = "GameData Profile/CreateNPCVisualProfile", order = 3)]
	public class NPCVisualProfile : ScriptableObject
	{
		// Token: 0x060046B1 RID: 18097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046B1")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public NPCVisualProfile()
		{
		}

		// Token: 0x04003F3F RID: 16191
		[Token(Token = "0x4003F3F")]
		[FieldOffset(Offset = "0x18")]
		public GuestProfilePair[] characterPortrayals;
	}
}

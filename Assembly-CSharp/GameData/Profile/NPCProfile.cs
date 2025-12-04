using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BD3 RID: 3027
	[Token(Token = "0x2000BD3")]
	[CreateAssetMenu(fileName = "NPCProfile", menuName = "GameData Profile/NPCProfile", order = 3)]
	public class NPCProfile : ScriptableObject
	{
		// Token: 0x060046D8 RID: 18136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D8")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public NPCProfile()
		{
		}

		// Token: 0x04003FFF RID: 16383
		[Token(Token = "0x4003FFF")]
		[FieldOffset(Offset = "0x18")]
		public NPC[] allNPCData;
	}
}

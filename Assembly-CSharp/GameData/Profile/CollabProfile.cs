using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B79 RID: 2937
	[Token(Token = "0x2000B79")]
	[CreateAssetMenu(fileName = "CollabProfile", menuName = "GameData Profile/CollabProfile", order = 3)]
	public class CollabProfile : ScriptableObject
	{
		// Token: 0x0600462E RID: 17966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600462E")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public CollabProfile()
		{
		}

		// Token: 0x04003E0F RID: 15887
		[Token(Token = "0x4003E0F")]
		[FieldOffset(Offset = "0x18")]
		public CollabPackage[] collabPackages;
	}
}

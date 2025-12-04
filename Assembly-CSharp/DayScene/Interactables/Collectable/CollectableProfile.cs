using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.Interactables.Collectable
{
	// Token: 0x02000545 RID: 1349
	[Token(Token = "0x2000545")]
	[CreateAssetMenu(fileName = "CollectableProfile", menuName = "GameData Profile/CollectableProfile", order = 0)]
	public class CollectableProfile : ScriptableObject
	{
		// Token: 0x06001DED RID: 7661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DED")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public CollectableProfile()
		{
		}

		// Token: 0x04001BAA RID: 7082
		[Token(Token = "0x4001BAA")]
		[FieldOffset(Offset = "0x18")]
		public Collectable[] collectables;
	}
}

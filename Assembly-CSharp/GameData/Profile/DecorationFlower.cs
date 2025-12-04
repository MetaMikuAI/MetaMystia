using System;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C8A RID: 3210
	[Token(Token = "0x2000C8A")]
	[CreateAssetMenu(fileName = "DecorationFlower", menuName = "GameData Profile/Decoration/DecorationFlower", order = 1)]
	public class DecorationFlower : DecorationBase
	{
		// Token: 0x06004AF7 RID: 19191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF7")]
		[Address(RVA = "0x77D770", Offset = "0x77C170", VA = "0x18077D770", Slot = "4")]
		public override void DecorationBuffEnterNight(EventManager eventManager)
		{
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF8")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DecorationFlower()
		{
		}

		// Token: 0x040044FD RID: 17661
		[Token(Token = "0x40044FD")]
		[FieldOffset(Offset = "0x18")]
		public int extraMood;
	}
}

using System;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C8E RID: 3214
	[Token(Token = "0x2000C8E")]
	[CreateAssetMenu(fileName = "DecorationRabbit", menuName = "GameData Profile/Decoration/DecorationRabbit", order = 4)]
	public class DecorationRabbit : DecorationBase
	{
		// Token: 0x06004AFF RID: 19199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFF")]
		[Address(RVA = "0x77D890", Offset = "0x77C290", VA = "0x18077D890", Slot = "4")]
		public override void DecorationBuffEnterNight(EventManager eventManager)
		{
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B00")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DecorationRabbit()
		{
		}

		// Token: 0x04004503 RID: 17667
		[Token(Token = "0x4004503")]
		[FieldOffset(Offset = "0x18")]
		public float freeCookRate;

		// Token: 0x04004504 RID: 17668
		[Token(Token = "0x4004504")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 rabbitOffset;

		// Token: 0x04004505 RID: 17669
		[Token(Token = "0x4004505")]
		[FieldOffset(Offset = "0x28")]
		public GameObject rabbitParent;
	}
}

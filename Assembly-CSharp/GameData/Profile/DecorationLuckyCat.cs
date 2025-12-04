using System;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C8B RID: 3211
	[Token(Token = "0x2000C8B")]
	[CreateAssetMenu(fileName = "DecorationLuckyCat", menuName = "GameData Profile/Decoration/DecorationLuckyCat", order = 0)]
	public class DecorationLuckyCat : DecorationBase
	{
		// Token: 0x06004AF9 RID: 19193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF9")]
		[Address(RVA = "0x77D7B0", Offset = "0x77C1B0", VA = "0x18077D7B0", Slot = "4")]
		public override void DecorationBuffEnterNight(EventManager eventManager)
		{
		}

		// Token: 0x06004AFA RID: 19194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFA")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DecorationLuckyCat()
		{
		}

		// Token: 0x040044FE RID: 17662
		[Token(Token = "0x40044FE")]
		[FieldOffset(Offset = "0x18")]
		public float extraFeeRate;
	}
}

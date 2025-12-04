using System;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C8C RID: 3212
	[Token(Token = "0x2000C8C")]
	[CreateAssetMenu(fileName = "DecorationPanda", menuName = "GameData Profile/Decoration/DecorationPanda", order = 3)]
	public class DecorationPanda : DecorationBase
	{
		// Token: 0x06004AFB RID: 19195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFB")]
		[Address(RVA = "0x77D800", Offset = "0x77C200", VA = "0x18077D800", Slot = "4")]
		public override void DecorationBuffEnterNight(EventManager eventManager)
		{
		}

		// Token: 0x06004AFC RID: 19196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFC")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DecorationPanda()
		{
		}

		// Token: 0x040044FF RID: 17663
		[Token(Token = "0x40044FF")]
		[FieldOffset(Offset = "0x18")]
		public int moneyMin;

		// Token: 0x04004500 RID: 17664
		[Token(Token = "0x4004500")]
		[FieldOffset(Offset = "0x1C")]
		public int moneyMax;

		// Token: 0x04004501 RID: 17665
		[Token(Token = "0x4004501")]
		[FieldOffset(Offset = "0x20")]
		public int interval;
	}
}

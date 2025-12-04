using System;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C8D RID: 3213
	[Token(Token = "0x2000C8D")]
	[CreateAssetMenu(fileName = "DecorationPeach", menuName = "GameData Profile/Decoration/DecorationPeach", order = 2)]
	public class DecorationPeach : DecorationBase
	{
		// Token: 0x06004AFD RID: 19197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFD")]
		[Address(RVA = "0x77D850", Offset = "0x77C250", VA = "0x18077D850", Slot = "4")]
		public override void DecorationBuffEnterNight(EventManager eventManager)
		{
		}

		// Token: 0x06004AFE RID: 19198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AFE")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DecorationPeach()
		{
		}

		// Token: 0x04004502 RID: 17666
		[Token(Token = "0x4004502")]
		[FieldOffset(Offset = "0x18")]
		public float bestEvalRate;
	}
}

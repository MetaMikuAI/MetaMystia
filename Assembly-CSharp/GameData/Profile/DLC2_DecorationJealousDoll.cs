using System;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C90 RID: 3216
	[Token(Token = "0x2000C90")]
	[CreateAssetMenu(fileName = "DLC2_DecorationJealousDoll", menuName = "GameData Profile/Decoration/DLC2/DecorationJealousDoll", order = 1)]
	public class DLC2_DecorationJealousDoll : DecorationBase
	{
		// Token: 0x06004B03 RID: 19203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B03")]
		[Address(RVA = "0x77D120", Offset = "0x77BB20", VA = "0x18077D120", Slot = "4")]
		public override void DecorationBuffEnterNight(EventManager eventManager)
		{
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B04")]
		[Address(RVA = "0x77C800", Offset = "0x77B200", VA = "0x18077C800")]
		public DLC2_DecorationJealousDoll()
		{
		}

		// Token: 0x04004507 RID: 17671
		[Token(Token = "0x4004507")]
		[FieldOffset(Offset = "0x18")]
		public int buffNum;
	}
}

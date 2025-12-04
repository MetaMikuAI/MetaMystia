using System;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C98 RID: 3224
	[Token(Token = "0x2000C98")]
	[CreateAssetMenu(fileName = "DLC5_DecorationDoorPlate", menuName = "GameData Profile/Decoration/DLC5/DLC5_DecorationDoorPlate", order = 1)]
	public class DLC5_DecorationDoorPlate : DecorationBase
	{
		// Token: 0x06004B1A RID: 19226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1A")]
		[Address(RVA = "0x77D500", Offset = "0x77BF00", VA = "0x18077D500", Slot = "4")]
		public override void DecorationBuffEnterNight(EventManager eventManager)
		{
		}

		// Token: 0x06004B1B RID: 19227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B1B")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DLC5_DecorationDoorPlate()
		{
		}

		// Token: 0x04004519 RID: 17689
		[Token(Token = "0x4004519")]
		[FieldOffset(Offset = "0x18")]
		public DLC5_DecorationDoorPlate.DoorPlateType buffType;

		// Token: 0x02000C99 RID: 3225
		[Token(Token = "0x2000C99")]
		public enum DoorPlateType
		{
			// Token: 0x0400451B RID: 17691
			[Token(Token = "0x400451B")]
			门无杂宾,
			// Token: 0x0400451C RID: 17692
			[Token(Token = "0x400451C")]
			杜门谢客
		}
	}
}

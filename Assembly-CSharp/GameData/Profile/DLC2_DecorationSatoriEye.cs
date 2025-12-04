using System;
using Il2CppDummyDll;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.UI.EventUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C91 RID: 3217
	[Token(Token = "0x2000C91")]
	[CreateAssetMenu(fileName = "DLC2_DecorationSatoriEye", menuName = "GameData Profile/Decoration/DLC2/DecorationSatoriEye", order = 0)]
	public class DLC2_DecorationSatoriEye : DecorationBase
	{
		// Token: 0x06004B05 RID: 19205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B05")]
		[Address(RVA = "0x77D170", Offset = "0x77BB70", VA = "0x18077D170", Slot = "4")]
		public override void DecorationBuffEnterNight(EventManager eventManager)
		{
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B06")]
		[Address(RVA = "0x77D3F0", Offset = "0x77BDF0", VA = "0x18077D3F0")]
		private void SetNum(GuestGroupController guestGroupController, GameObject targetDisplayer)
		{
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B07")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DLC2_DecorationSatoriEye()
		{
		}

		// Token: 0x04004508 RID: 17672
		[Token(Token = "0x4004508")]
		private const GuestBuffMarkModule.GuestBuffMark SATORI_EYE_BUFF_MARK = GuestBuffMarkModule.GuestBuffMark.BuffMark_SatoriEye;

		// Token: 0x04004509 RID: 17673
		[Token(Token = "0x4004509")]
		[FieldOffset(Offset = "0x18")]
		public GameObject displayUI;

		// Token: 0x0400450A RID: 17674
		[Token(Token = "0x400450A")]
		[FieldOffset(Offset = "0x20")]
		public int UIFieldIndex;

		// Token: 0x0400450B RID: 17675
		[Token(Token = "0x400450B")]
		[FieldOffset(Offset = "0x24")]
		public float UIOffset;
	}
}

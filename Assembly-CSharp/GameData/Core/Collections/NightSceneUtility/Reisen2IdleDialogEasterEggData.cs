using System;
using System.Collections.Generic;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x0200092B RID: 2347
	[Token(Token = "0x200092B")]
	[CreateAssetMenu(fileName = "DLC5_IdleDialogEasterEgg_Reisen2", menuName = "GameData Profile/Easter Egg Data/Reisen2", order = 8)]
	public class Reisen2IdleDialogEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06003A77 RID: 14967 RVA: 0x00016278 File Offset: 0x00014478
		[Token(Token = "0x6003A77")]
		[Address(RVA = "0x6894A0", Offset = "0x687EA0", VA = "0x1806894A0", Slot = "5")]
		public override bool TryGetEasterEggIdleDialog(IEnumerable<PartnerBase> partners, out IEnumerable<string> idleDialog)
		{
			return default(bool);
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A78")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public Reisen2IdleDialogEasterEggData()
		{
		}

		// Token: 0x04003199 RID: 12697
		[Token(Token = "0x4003199")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_PartnerId;

		// Token: 0x0400319A RID: 12698
		[Token(Token = "0x400319A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] IdleDialogTitles;
	}
}

using System;
using System.Collections.Generic;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000924 RID: 2340
	[Token(Token = "0x2000924")]
	[CreateAssetMenu(fileName = "DLC5_IdleDialogEasterEgg_Luize", menuName = "GameData Profile/Easter Egg Data/Luize", order = 7)]
	public class LuizeIdleDialogEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06003A67 RID: 14951 RVA: 0x000161E8 File Offset: 0x000143E8
		[Token(Token = "0x6003A67")]
		[Address(RVA = "0x686C20", Offset = "0x685620", VA = "0x180686C20", Slot = "5")]
		public override bool TryGetEasterEggIdleDialog(IEnumerable<PartnerBase> partners, out IEnumerable<string> idleDialog)
		{
			return default(bool);
		}

		// Token: 0x06003A68 RID: 14952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A68")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public LuizeIdleDialogEasterEggData()
		{
		}

		// Token: 0x04003193 RID: 12691
		[Token(Token = "0x4003193")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_PartnerId;

		// Token: 0x04003194 RID: 12692
		[Token(Token = "0x4003194")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] IdleDialogTitles;
	}
}

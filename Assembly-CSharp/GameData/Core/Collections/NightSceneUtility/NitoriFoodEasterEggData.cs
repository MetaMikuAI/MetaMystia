using System;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x0200092A RID: 2346
	[Token(Token = "0x200092A")]
	[CreateAssetMenu(fileName = "NitoriEaster Egg", menuName = "GameData Profile/Easter Egg Data/Nitori", order = 1)]
	public class NitoriFoodEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06003A75 RID: 14965 RVA: 0x00016260 File Offset: 0x00014460
		[Token(Token = "0x6003A75")]
		[Address(RVA = "0x687670", Offset = "0x686070", VA = "0x180687670", Slot = "4")]
		public override bool CheckEasterEgg(GuestsManager.OrderBase lastOrder, GuestGroupController toEval, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult finalResult, out string specialDialog)
		{
			return default(bool);
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A76")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public NitoriFoodEasterEggData()
		{
		}

		// Token: 0x04003198 RID: 12696
		[Token(Token = "0x4003198")]
		[FieldOffset(Offset = "0x20")]
		public int cucumberId;
	}
}

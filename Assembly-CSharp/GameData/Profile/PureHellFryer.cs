using System;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C84 RID: 3204
	[Token(Token = "0x2000C84")]
	[CreateAssetMenu(fileName = "PureHellFryer", menuName = "GameData Profile/Cooker Asset/PureHellFryer", order = 2000)]
	public class PureHellFryer : CookerAssetBase
	{
		// Token: 0x06004AE5 RID: 19173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE5")]
		[Address(RVA = "0x782EB0", Offset = "0x7818B0", VA = "0x180782EB0", Slot = "14")]
		public override void OnPlayerFinishExtract(CookController targetCooker)
		{
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE6")]
		[Address(RVA = "0x783070", Offset = "0x781A70", VA = "0x180783070", Slot = "15")]
		public override void WhenPlayerTryExtractWithFullTray(CookController targetCooker)
		{
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE7")]
		[Address(RVA = "0x77CD90", Offset = "0x77B790", VA = "0x18077CD90")]
		public PureHellFryer()
		{
		}
	}
}

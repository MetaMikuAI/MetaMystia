using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C78 RID: 3192
	[Token(Token = "0x2000C78")]
	[CreateAssetMenu(fileName = "ByakurenCuttingBoard", menuName = "GameData Profile/Cooker Asset/ByakurenCuttingBoard", order = 5000)]
	public class ByakurenCuttingBoard : CookerAssetBase
	{
		// Token: 0x06004AA9 RID: 19113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AA9")]
		[Address(RVA = "0x77CC70", Offset = "0x77B670", VA = "0x18077CC70", Slot = "12")]
		protected override string ProcessBaseDescriptionCallback(string baseDescription)
		{
			return null;
		}

		// Token: 0x06004AAA RID: 19114 RVA: 0x0001B108 File Offset: 0x00019308
		[Token(Token = "0x6004AAA")]
		[Address(RVA = "0x77C810", Offset = "0x77B210", VA = "0x18077C810", Slot = "7")]
		public override float ExtraCookTimeMultiplier(CookController thisCookController, Sellable food)
		{
			return 0f;
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x0001B120 File Offset: 0x00019320
		[Token(Token = "0x6004AAB")]
		[Address(RVA = "0x77C8A0", Offset = "0x77B2A0", VA = "0x18077C8A0", Slot = "11")]
		public override int OnEvaluate(int evaluationResult, GuestGroupController guestGroupController, Sellable serveFood)
		{
			return 0;
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AAC")]
		[Address(RVA = "0x77CD90", Offset = "0x77B790", VA = "0x18077CD90")]
		public ByakurenCuttingBoard()
		{
		}

		// Token: 0x040044C7 RID: 17607
		[Token(Token = "0x40044C7")]
		private const int MEAT_TAG = 0;

		// Token: 0x040044C8 RID: 17608
		[Token(Token = "0x40044C8")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float extraCookSpeed;

		// Token: 0x040044C9 RID: 17609
		[Token(Token = "0x40044C9")]
		[FieldOffset(Offset = "0x2C")]
		public float extraCookSpeedWithMeat;

		// Token: 0x040044CA RID: 17610
		[Token(Token = "0x40044CA")]
		private const string BYAKURENCUTTINGBOARD_RECORDFOOD = "ByakurenCuttingBoard_RecordFood";

		// Token: 0x040044CB RID: 17611
		[Token(Token = "0x40044CB")]
		private const string BYAKURENCUTTINGBOARD_RECORDEVAL = "ByakurenCuttingBoard_RecordEval";
	}
}

using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C83 RID: 3203
	[Token(Token = "0x2000C83")]
	[CreateAssetMenu(fileName = "PeerlessWindGodSteamer", menuName = "GameData Profile/Cooker Asset/PeerlessWindGodSteamer", order = 4000)]
	public class PeerlessWindGodSteamer : CookerAssetBase
	{
		// Token: 0x06004AE1 RID: 19169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AE1")]
		[Address(RVA = "0x782D90", Offset = "0x781790", VA = "0x180782D90", Slot = "12")]
		protected override string ProcessBaseDescriptionCallback(string baseDescription)
		{
			return null;
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x0001B2A0 File Offset: 0x000194A0
		[Token(Token = "0x6004AE2")]
		[Address(RVA = "0x782CF0", Offset = "0x7816F0", VA = "0x180782CF0", Slot = "7")]
		public override float ExtraCookTimeMultiplier(CookController thisCookController, Sellable food)
		{
			return 0f;
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x0001B2B8 File Offset: 0x000194B8
		[Token(Token = "0x6004AE3")]
		[Address(RVA = "0x782C50", Offset = "0x781650", VA = "0x180782C50", Slot = "8")]
		public override float ExtraAdditiveNextOrderProb(Sellable food)
		{
			return 0f;
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AE4")]
		[Address(RVA = "0x77CD90", Offset = "0x77B790", VA = "0x18077CD90")]
		public PeerlessWindGodSteamer()
		{
		}

		// Token: 0x040044F4 RID: 17652
		[Token(Token = "0x40044F4")]
		private const int POPULAR_LIKE_ID = -20;

		// Token: 0x040044F5 RID: 17653
		[Token(Token = "0x40044F5")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float extraCookSpeed;

		// Token: 0x040044F6 RID: 17654
		[Token(Token = "0x40044F6")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float extraOrderRate;
	}
}

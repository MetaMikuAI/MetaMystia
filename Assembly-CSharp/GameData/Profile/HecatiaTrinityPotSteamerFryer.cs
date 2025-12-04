using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C7C RID: 3196
	[Token(Token = "0x2000C7C")]
	[CreateAssetMenu(fileName = "HecatiaTrinityPotGrillFryer", menuName = "GameData Profile/Cooker Asset/HecatiaTrinityPotSteamerFryer", order = 5001)]
	public class HecatiaTrinityPotSteamerFryer : CookerAssetBase
	{
		// Token: 0x06004AC3 RID: 19139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC3")]
		[Address(RVA = "0x77E1B0", Offset = "0x77CBB0", VA = "0x18077E1B0", Slot = "18")]
		public override AudioClip OverrideStartSFX(Cooker.CookerType cookerType)
		{
			return null;
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06004AC4 RID: 19140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000ACF")]
		public override Cooker.CookerType[] ExtraAvailableCookerType
		{
			[Token(Token = "0x6004AC4")]
			[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06004AC5 RID: 19141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD0")]
		public override string OverrideTypeName
		{
			[Token(Token = "0x6004AC5")]
			[Address(RVA = "0x77E1E0", Offset = "0x77CBE0", VA = "0x18077E1E0", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004AC6 RID: 19142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC6")]
		[Address(RVA = "0x77CD90", Offset = "0x77B790", VA = "0x18077CD90")]
		public HecatiaTrinityPotSteamerFryer()
		{
		}

		// Token: 0x040044D3 RID: 17619
		[Token(Token = "0x40044D3")]
		[FieldOffset(Offset = "0x28")]
		public AudioClip startCookSFXForPot;

		// Token: 0x040044D4 RID: 17620
		[Token(Token = "0x40044D4")]
		[FieldOffset(Offset = "0x30")]
		public AudioClip startCookSFXForSteamer;

		// Token: 0x040044D5 RID: 17621
		[Token(Token = "0x40044D5")]
		[FieldOffset(Offset = "0x38")]
		public AudioClip startCookSFXForFryer;

		// Token: 0x040044D6 RID: 17622
		[Token(Token = "0x40044D6")]
		[FieldOffset(Offset = "0x40")]
		public Cooker.CookerType[] extraCookerType;

		// Token: 0x040044D7 RID: 17623
		[Token(Token = "0x40044D7")]
		private const string DLC5_HECATIA_COOK_NAME = "FILTER_COOKERSERIES_TRINITY";
	}
}

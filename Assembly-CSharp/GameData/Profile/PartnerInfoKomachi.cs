using System;
using System.Text;
using Il2CppDummyDll;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CD3 RID: 3283
	[Token(Token = "0x2000CD3")]
	[CreateAssetMenu(fileName = "DLC2_PartnerInfo_Komachi(Test)", menuName = "GameData Profile/PartnerInfoCollection/DLC2_PartnerInfoKomachi(Test)", order = 8)]
	public sealed class PartnerInfoKomachi : PartnerInfo
	{
		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06004C54 RID: 19540 RVA: 0x0001BA50 File Offset: 0x00019C50
		[Token(Token = "0x17000B0C")]
		public override bool HasWorkSleepLoop
		{
			[Token(Token = "0x6004C54")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06004C55 RID: 19541 RVA: 0x0001BA68 File Offset: 0x00019C68
		[Token(Token = "0x17000B0D")]
		protected override Vector2Int SleepTime
		{
			[Token(Token = "0x6004C55")]
			[Address(RVA = "0x48A940", Offset = "0x489340", VA = "0x18048A940", Slot = "8")]
			get
			{
				return default(Vector2Int);
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06004C56 RID: 19542 RVA: 0x0001BA80 File Offset: 0x00019C80
		[Token(Token = "0x17000B0E")]
		protected override Vector2Int WorkTime
		{
			[Token(Token = "0x6004C56")]
			[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300", Slot = "7")]
			get
			{
				return default(Vector2Int);
			}
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C57")]
		[Address(RVA = "0x79E5A0", Offset = "0x79CFA0", VA = "0x18079E5A0", Slot = "16")]
		protected override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, object[] additionalData)
		{
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C58")]
		[Address(RVA = "0x79E5E0", Offset = "0x79CFE0", VA = "0x18079E5E0", Slot = "22")]
		protected override void PostProcessInfo(StringBuilder builder)
		{
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C59")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public PartnerInfoKomachi()
		{
		}

		// Token: 0x0400464A RID: 17994
		[Token(Token = "0x400464A")]
		[FieldOffset(Offset = "0x58")]
		public GameObject coinEffect;

		// Token: 0x0400464B RID: 17995
		[Token(Token = "0x400464B")]
		[FieldOffset(Offset = "0x60")]
		public GameObject theHandEffect;

		// Token: 0x0400464C RID: 17996
		[Token(Token = "0x400464C")]
		[FieldOffset(Offset = "0x68")]
		public Vector2Int workTime;

		// Token: 0x0400464D RID: 17997
		[Token(Token = "0x400464D")]
		[FieldOffset(Offset = "0x70")]
		public Vector2Int sleepTime;
	}
}

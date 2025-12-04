using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C7D RID: 3197
	[Token(Token = "0x2000C7D")]
	[CreateAssetMenu(fileName = "MoonLightSeries", menuName = "GameData Profile/Cooker Asset/MoonLightSeries", order = 3)]
	public class MoonLightSeries : CookerAssetBase
	{
		// Token: 0x06004AC7 RID: 19143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AC7")]
		[Address(RVA = "0x780450", Offset = "0x77EE50", VA = "0x180780450", Slot = "12")]
		protected override string ProcessBaseDescriptionCallback(string baseDescription)
		{
			return null;
		}

		// Token: 0x06004AC8 RID: 19144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC8")]
		[Address(RVA = "0x780080", Offset = "0x77EA80", VA = "0x180780080", Slot = "9")]
		public override void OnStartCook()
		{
		}

		// Token: 0x06004AC9 RID: 19145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AC9")]
		[Address(RVA = "0x7805C0", Offset = "0x77EFC0", VA = "0x1807805C0")]
		public MoonLightSeries()
		{
		}

		// Token: 0x040044D8 RID: 17624
		[Token(Token = "0x40044D8")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float rabbitGenerationProbability;

		// Token: 0x040044D9 RID: 17625
		[Token(Token = "0x40044D9")]
		[FieldOffset(Offset = "0x2C")]
		public float perRabbitAdditiveFeeRate;

		// Token: 0x040044DA RID: 17626
		[Token(Token = "0x40044DA")]
		[FieldOffset(Offset = "0x30")]
		public int rabbitDuration;

		// Token: 0x040044DB RID: 17627
		[Token(Token = "0x40044DB")]
		[FieldOffset(Offset = "0x34")]
		public Vector2 rabbitOffset;

		// Token: 0x040044DC RID: 17628
		[Token(Token = "0x40044DC")]
		[FieldOffset(Offset = "0x40")]
		public GameObject rabbitParent;

		// Token: 0x040044DD RID: 17629
		[Token(Token = "0x40044DD")]
		[FieldOffset(Offset = "0x0")]
		public static string TSUKIMI_RABBIT;
	}
}

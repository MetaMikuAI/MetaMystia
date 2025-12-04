using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B7C RID: 2940
	[Token(Token = "0x2000B7C")]
	[CreateAssetMenu(fileName = "CookerProfile", menuName = "GameData Profile/CookerProfile", order = 3)]
	public class CookerProfile : ScriptableObject
	{
		// Token: 0x06004631 RID: 17969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004631")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public CookerProfile()
		{
		}

		// Token: 0x04003E14 RID: 15892
		[Token(Token = "0x4003E14")]
		[FieldOffset(Offset = "0x18")]
		public Cooker[] cookers;

		// Token: 0x04003E15 RID: 15893
		[Token(Token = "0x4003E15")]
		[FieldOffset(Offset = "0x20")]
		public TextAsset cookersPreview;

		// Token: 0x04003E16 RID: 15894
		[Token(Token = "0x4003E16")]
		[FieldOffset(Offset = "0x28")]
		public CookerProfile.CookerSeriesPicMapping[] cookerSeriesPicMappings;

		// Token: 0x02000B7D RID: 2941
		[Token(Token = "0x2000B7D")]
		public struct CookerSeriesPicMapping
		{
			// Token: 0x04003E17 RID: 15895
			[Token(Token = "0x4003E17")]
			[FieldOffset(Offset = "0x0")]
			public Cooker.CookerSeries Series;

			// Token: 0x04003E18 RID: 15896
			[Token(Token = "0x4003E18")]
			[FieldOffset(Offset = "0x8")]
			public Sprite bgPic;
		}
	}
}

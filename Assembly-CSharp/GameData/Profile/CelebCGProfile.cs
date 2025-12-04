using System;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B72 RID: 2930
	[Token(Token = "0x2000B72")]
	[CreateAssetMenu(fileName = "CelebCGProfile", menuName = "GameData Profile/CreateCelebCGProfile", order = 3)]
	public class CelebCGProfile : ScriptableObject
	{
		// Token: 0x0600461B RID: 17947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461B")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public CelebCGProfile()
		{
		}

		// Token: 0x04003DF5 RID: 15861
		[Token(Token = "0x4003DF5")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04003DF6 RID: 15862
		[Token(Token = "0x4003DF6")]
		[FieldOffset(Offset = "0x20")]
		public RunTimeScheduler.CGPicture[] cgPictures;
	}
}

using System;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B73 RID: 2931
	[Token(Token = "0x2000B73")]
	[CreateAssetMenu(fileName = "CGProfile", menuName = "GameData Profile/CreateCGprofile", order = 3)]
	public class CGProfile : ScriptableObject
	{
		// Token: 0x0600461C RID: 17948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461C")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public CGProfile()
		{
		}

		// Token: 0x04003DF7 RID: 15863
		[Token(Token = "0x4003DF7")]
		[FieldOffset(Offset = "0x18")]
		public CGProfile.CGPictureProperty[] cgPictures;

		// Token: 0x02000B74 RID: 2932
		[Token(Token = "0x2000B74")]
		[Serializable]
		public struct CGPictureProperty
		{
			// Token: 0x04003DF8 RID: 15864
			[Token(Token = "0x4003DF8")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string CGKey;

			// Token: 0x04003DF9 RID: 15865
			[Token(Token = "0x4003DF9")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public RunTimeScheduler.CGPicture[] cgPictures;

			// Token: 0x04003DFA RID: 15866
			[Token(Token = "0x4003DFA")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public bool haveLinkedCG;

			// Token: 0x04003DFB RID: 15867
			[Token(Token = "0x4003DFB")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public string linkedCGLabel;
		}
	}
}

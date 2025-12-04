using System;
using GameData.RunTime.Common.AchievementSystem;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B6F RID: 2927
	[Token(Token = "0x2000B6F")]
	[Serializable]
	public struct AchievementData
	{
		// Token: 0x04003DE9 RID: 15849
		[Token(Token = "0x4003DE9")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public string Id;

		// Token: 0x04003DEA RID: 15850
		[Token(Token = "0x4003DEA")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public string StreamVariable;

		// Token: 0x04003DEB RID: 15851
		[Token(Token = "0x4003DEB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string Description;

		// Token: 0x04003DEC RID: 15852
		[Token(Token = "0x4003DEC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public int IntData;

		// Token: 0x04003DED RID: 15853
		[Token(Token = "0x4003DED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public int[] IntArrayData;

		// Token: 0x04003DEE RID: 15854
		[Token(Token = "0x4003DEE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public string StringData;

		// Token: 0x04003DEF RID: 15855
		[Token(Token = "0x4003DEF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public string[] StringArrayData;

		// Token: 0x04003DF0 RID: 15856
		[Token(Token = "0x4003DF0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public AchievementType AchievementType;

		// Token: 0x04003DF1 RID: 15857
		[Token(Token = "0x4003DF1")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public int NativeProgressMaxValue;
	}
}

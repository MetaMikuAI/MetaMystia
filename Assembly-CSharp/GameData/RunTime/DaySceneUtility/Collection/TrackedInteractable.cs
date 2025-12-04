using System;
using GameData.RunTime.Common;
using Il2CppDummyDll;

namespace GameData.RunTime.DaySceneUtility.Collection
{
	// Token: 0x020007F5 RID: 2037
	[Token(Token = "0x20007F5")]
	[Serializable]
	public class TrackedInteractable : IDeepClonable<TrackedInteractable>
	{
		// Token: 0x06003041 RID: 12353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003041")]
		[Address(RVA = "0x617A60", Offset = "0x616460", VA = "0x180617A60")]
		public TrackedInteractable(string label)
		{
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003042")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		private TrackedInteractable()
		{
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003043")]
		[Address(RVA = "0x617990", Offset = "0x616390", VA = "0x180617990", Slot = "4")]
		public TrackedInteractable Clone()
		{
			return null;
		}

		// Token: 0x04002B1C RID: 11036
		[Token(Token = "0x4002B1C")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x04002B1D RID: 11037
		[Token(Token = "0x4002B1D")]
		[FieldOffset(Offset = "0x18")]
		public bool openStatus;

		// Token: 0x04002B1E RID: 11038
		[Token(Token = "0x4002B1E")]
		[FieldOffset(Offset = "0x1C")]
		public int trackedTime;
	}
}

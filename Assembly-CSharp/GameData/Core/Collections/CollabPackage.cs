using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections
{
	// Token: 0x020008C8 RID: 2248
	[Token(Token = "0x20008C8")]
	[Serializable]
	public class CollabPackage
	{
		// Token: 0x06003811 RID: 14353 RVA: 0x00015240 File Offset: 0x00013440
		[Token(Token = "0x6003811")]
		[Address(RVA = "0x67FAF0", Offset = "0x67E4F0", VA = "0x18067FAF0")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06003812 RID: 14354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003812")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public CollabPackage()
		{
		}

		// Token: 0x04002FE4 RID: 12260
		[Token(Token = "0x4002FE4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string label;

		// Token: 0x04002FE5 RID: 12261
		[Token(Token = "0x4002FE5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public string headerKey;

		// Token: 0x04002FE6 RID: 12262
		[Token(Token = "0x4002FE6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public bool enabled;

		// Token: 0x04002FE7 RID: 12263
		[Token(Token = "0x4002FE7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public CollabPackage.CollabRule[] rules;

		// Token: 0x04002FE8 RID: 12264
		[Token(Token = "0x4002FE8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public CollabPackage.TimeRange time;

		// Token: 0x04002FE9 RID: 12265
		[Token(Token = "0x4002FE9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public DialogPackage collablAdvDialog;

		// Token: 0x04002FEA RID: 12266
		[Token(Token = "0x4002FEA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public DialogPackage openCollabDialog;

		// Token: 0x020008C9 RID: 2249
		[Token(Token = "0x20008C9")]
		[Serializable]
		public struct CollabRule
		{
			// Token: 0x04002FEB RID: 12267
			[Token(Token = "0x4002FEB")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public CollabPackage.CollabRule.RuleType ruleType;

			// Token: 0x04002FEC RID: 12268
			[Token(Token = "0x4002FEC")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public string key;

			// Token: 0x020008CA RID: 2250
			[Token(Token = "0x20008CA")]
			public enum RuleType
			{
				// Token: 0x04002FEE RID: 12270
				[Token(Token = "0x4002FEE")]
				SpecialNPCToggle,
				// Token: 0x04002FEF RID: 12271
				[Token(Token = "0x4002FEF")]
				InteractableSwitch
			}
		}

		// Token: 0x020008CB RID: 2251
		[Token(Token = "0x20008CB")]
		[Serializable]
		public struct TimeRange
		{
			// Token: 0x04002FF0 RID: 12272
			[Token(Token = "0x4002FF0")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public bool useTime;

			// Token: 0x04002FF1 RID: 12273
			[Token(Token = "0x4002FF1")]
			[FieldOffset(Offset = "0x2")]
			[SerializeField]
			public CollabPackage.Time min;

			// Token: 0x04002FF2 RID: 12274
			[Token(Token = "0x4002FF2")]
			[FieldOffset(Offset = "0x6")]
			[SerializeField]
			public CollabPackage.Time max;
		}

		// Token: 0x020008CC RID: 2252
		[Token(Token = "0x20008CC")]
		[Serializable]
		public struct Time
		{
			// Token: 0x04002FF3 RID: 12275
			[Token(Token = "0x4002FF3")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public short year;

			// Token: 0x04002FF4 RID: 12276
			[Token(Token = "0x4002FF4")]
			[FieldOffset(Offset = "0x2")]
			[SerializeField]
			public byte month;

			// Token: 0x04002FF5 RID: 12277
			[Token(Token = "0x4002FF5")]
			[FieldOffset(Offset = "0x3")]
			[SerializeField]
			public byte day;
		}
	}
}

using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace GameData.Core.Collections
{
	// Token: 0x020008B4 RID: 2228
	[Token(Token = "0x20008B4")]
	[CreateAssetMenu(fileName = "TrophiesProfile", menuName = "GameData Profile/CreateTrophiesProfile", order = 0)]
	public class TrophiesProfile : ScriptableObject
	{
		// Token: 0x060036CE RID: 14030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CE")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public TrophiesProfile()
		{
		}

		// Token: 0x04002F4C RID: 12108
		[Token(Token = "0x4002F4C")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("Trophies")]
		public TrophiesProfile.Trophy[] trophies;

		// Token: 0x04002F4D RID: 12109
		[Token(Token = "0x4002F4D")]
		[FieldOffset(Offset = "0x20")]
		public string previewName;

		// Token: 0x020008B5 RID: 2229
		[Token(Token = "0x20008B5")]
		[Serializable]
		public class Trophy : Item
		{
			// Token: 0x060036CF RID: 14031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036CF")]
			[Address(RVA = "0x674700", Offset = "0x673100", VA = "0x180674700")]
			public Trophy(int id)
			{
			}

			// Token: 0x17000728 RID: 1832
			// (get) Token: 0x060036D0 RID: 14032 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000728")]
			public string DaySceneMapLabel
			{
				[Token(Token = "0x60036D0")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x060036D1 RID: 14033 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000729")]
			public string DLCLabel
			{
				[Token(Token = "0x60036D1")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x04002F4E RID: 12110
			[Token(Token = "0x4002F4E")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string daySceneMapLabel;

			// Token: 0x04002F4F RID: 12111
			[Token(Token = "0x4002F4F")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private string dlcLabel;
		}
	}
}

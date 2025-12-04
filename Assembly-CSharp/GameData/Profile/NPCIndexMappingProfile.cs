using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BB2 RID: 2994
	[Token(Token = "0x2000BB2")]
	[CreateAssetMenu(fileName = "NPCIndexMappingProfile", menuName = "GameData Profile/NPCIndexMappingProfile", order = 3)]
	public class NPCIndexMappingProfile : ScriptableObject
	{
		// Token: 0x060046A8 RID: 18088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046A8")]
		[Address(RVA = "0x73F530", Offset = "0x73DF30", VA = "0x18073F530")]
		public Dictionary<string, SchedulerNode.Character> GetDictionary()
		{
			return null;
		}

		// Token: 0x060046A9 RID: 18089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A9")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public NPCIndexMappingProfile()
		{
		}

		// Token: 0x04003F39 RID: 16185
		[Token(Token = "0x4003F39")]
		[FieldOffset(Offset = "0x18")]
		public NPCIndexMappingProfile.StringIdentityPair[] NPCIndex;

		// Token: 0x02000BB3 RID: 2995
		[Token(Token = "0x2000BB3")]
		[Serializable]
		public struct StringIdentityPair
		{
			// Token: 0x060046AA RID: 18090 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60046AA")]
			[Address(RVA = "0x742C40", Offset = "0x741640", VA = "0x180742C40")]
			public StringIdentityPair(string stringName, SchedulerNode.Character identity)
			{
			}

			// Token: 0x17000A55 RID: 2645
			// (get) Token: 0x060046AB RID: 18091 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A55")]
			public string StringNameData
			{
				[Token(Token = "0x60046AB")]
				[Address(RVA = "0x4070A0", Offset = "0x405AA0", VA = "0x1804070A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A56 RID: 2646
			// (get) Token: 0x060046AC RID: 18092 RVA: 0x00019698 File Offset: 0x00017898
			[Token(Token = "0x17000A56")]
			public SchedulerNode.Character IdentityData
			{
				[Token(Token = "0x60046AC")]
				[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
				get
				{
					return default(SchedulerNode.Character);
				}
			}

			// Token: 0x04003F3A RID: 16186
			[Token(Token = "0x4003F3A")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private string StringName;

			// Token: 0x04003F3B RID: 16187
			[Token(Token = "0x4003F3B")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private SchedulerNode.Character Identity;
		}
	}
}

using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BB9 RID: 3001
	[Token(Token = "0x2000BB9")]
	[CreateAssetMenu(fileName = "RecordProfile", menuName = "GameData Profile/CreateRecordProfile", order = 3)]
	public class RecordProfile : ScriptableObject
	{
		// Token: 0x060046BC RID: 18108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BC")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public RecordProfile()
		{
		}

		// Token: 0x04003F47 RID: 16199
		[Token(Token = "0x4003F47")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Record[] records;
	}
}

using System;
using GameData.Profile.SchedulerNodeCollection;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BCB RID: 3019
	[Token(Token = "0x2000BCB")]
	[CreateAssetMenu(fileName = "MissionProfile", menuName = "GameData Profile/CreateMissionProfile", order = 3)]
	public class SchedulerProfile : ScriptableObject
	{
		// Token: 0x060046D1 RID: 18129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D1")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public SchedulerProfile()
		{
		}

		// Token: 0x04003FEE RID: 16366
		[Token(Token = "0x4003FEE")]
		[FieldOffset(Offset = "0x18")]
		public SchedulerNode[] allNodes;

		// Token: 0x04003FEF RID: 16367
		[Token(Token = "0x4003FEF")]
		[FieldOffset(Offset = "0x20")]
		public NewsNode[] allNews;
	}
}

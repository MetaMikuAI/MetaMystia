using System;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C89 RID: 3209
	[Token(Token = "0x2000C89")]
	[CreateAssetMenu(fileName = "DecorationBase", menuName = "GameData Profile/Decoration/DecorationBase", order = 0)]
	public class DecorationBase : ScriptableObject
	{
		// Token: 0x06004AF5 RID: 19189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF5")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "4")]
		public virtual void DecorationBuffEnterNight(EventManager eventManager)
		{
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF6")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DecorationBase()
		{
		}
	}
}

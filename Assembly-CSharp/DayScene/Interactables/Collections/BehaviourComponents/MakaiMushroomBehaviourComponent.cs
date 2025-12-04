using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000509 RID: 1289
	[Token(Token = "0x2000509")]
	public class MakaiMushroomBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001CE8 RID: 7400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE8")]
		[Address(RVA = "0x4B12A0", Offset = "0x4AFCA0", VA = "0x1804B12A0", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CE9")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public MakaiMushroomBehaviourComponent()
		{
		}

		// Token: 0x04001A9E RID: 6814
		[Token(Token = "0x4001A9E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DialogPackage m_InteractDialog;
	}
}

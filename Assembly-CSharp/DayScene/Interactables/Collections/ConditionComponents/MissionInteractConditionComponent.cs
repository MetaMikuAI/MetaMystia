using System;
using DayScene.Interactables.Collections.BehaviourComponents;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x020004C4 RID: 1220
	[Token(Token = "0x20004C4")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(MissionInteractBehaviourComponent))]
	public class MissionInteractConditionComponent : EntityConditionComponent
	{
		// Token: 0x06001BC1 RID: 7105 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		[Token(Token = "0x6001BC1")]
		[Address(RVA = "0x4A1850", Offset = "0x4A0250", VA = "0x1804A1850", Slot = "9")]
		protected override bool OnGetAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BC2")]
		[Address(RVA = "0x4A17F0", Offset = "0x4A01F0", VA = "0x1804A17F0", Slot = "4")]
		protected override Type GetComponentType()
		{
			return null;
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC3")]
		[Address(RVA = "0x493F40", Offset = "0x492940", VA = "0x180493F40", Slot = "10")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC4")]
		[Address(RVA = "0x4A1860", Offset = "0x4A0260", VA = "0x1804A1860")]
		public MissionInteractConditionComponent()
		{
		}

		// Token: 0x0400196D RID: 6509
		[Token(Token = "0x400196D")]
		[FieldOffset(Offset = "0x40")]
		public string interactableKey;
	}
}

using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x020004C8 RID: 1224
	[Token(Token = "0x20004C8")]
	[GenerateCleanupMethod]
	public class FishingRodConditionComponent : EntityConditionComponent
	{
		// Token: 0x06001BD2 RID: 7122 RVA: 0x0000AB18 File Offset: 0x00008D18
		[Token(Token = "0x6001BD2")]
		[Address(RVA = "0x49E810", Offset = "0x49D210", VA = "0x18049E810", Slot = "9")]
		protected override bool OnGetAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD3")]
		[Address(RVA = "0x49E7B0", Offset = "0x49D1B0", VA = "0x18049E7B0", Slot = "4")]
		protected override Type GetComponentType()
		{
			return null;
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD4")]
		[Address(RVA = "0x493F40", Offset = "0x492940", VA = "0x180493F40", Slot = "10")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD5")]
		[Address(RVA = "0x49E8A0", Offset = "0x49D2A0", VA = "0x18049E8A0")]
		public FishingRodConditionComponent()
		{
		}

		// Token: 0x04001972 RID: 6514
		[Token(Token = "0x4001972")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int[] m_FishingRodIds;
	}
}

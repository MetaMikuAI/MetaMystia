using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x020004CD RID: 1229
	[Token(Token = "0x20004CD")]
	[GenerateCleanupMethod]
	public class StorageConditionComponent : EntityConditionComponent
	{
		// Token: 0x06001BE0 RID: 7136 RVA: 0x0000AB90 File Offset: 0x00008D90
		[Token(Token = "0x6001BE0")]
		[Address(RVA = "0x4A20A0", Offset = "0x4A0AA0", VA = "0x1804A20A0", Slot = "9")]
		protected override bool OnGetAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BE1")]
		[Address(RVA = "0x4A2040", Offset = "0x4A0A40", VA = "0x1804A2040", Slot = "4")]
		protected override Type GetComponentType()
		{
			return null;
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE2")]
		[Address(RVA = "0x4A1FE0", Offset = "0x4A09E0", VA = "0x1804A1FE0", Slot = "10")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE3")]
		[Address(RVA = "0x4A2470", Offset = "0x4A0E70", VA = "0x1804A2470")]
		public StorageConditionComponent()
		{
		}

		// Token: 0x0400197F RID: 6527
		[Token(Token = "0x400197F")]
		[FieldOffset(Offset = "0x40")]
		public Product[] mustHaveProducts;

		// Token: 0x04001980 RID: 6528
		[Token(Token = "0x4001980")]
		[FieldOffset(Offset = "0x48")]
		[Header("在上述满足的情况下，下面这个满足一个就行")]
		public Product[] alternativeOptionsProducts;
	}
}

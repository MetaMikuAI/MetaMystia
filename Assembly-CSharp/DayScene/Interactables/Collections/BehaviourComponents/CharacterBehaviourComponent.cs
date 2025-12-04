using System;
using DayScene.Interactables.Collections.ConditionComponents;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004D3 RID: 1235
	[Token(Token = "0x20004D3")]
	[RequireComponent(typeof(CharacterConditionComponent))]
	[GenerateCleanupMethod]
	public class CharacterBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001C03 RID: 7171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C03")]
		[Address(RVA = "0x492210", Offset = "0x490C10", VA = "0x180492210", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C04")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C05")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public CharacterBehaviourComponent()
		{
		}
	}
}

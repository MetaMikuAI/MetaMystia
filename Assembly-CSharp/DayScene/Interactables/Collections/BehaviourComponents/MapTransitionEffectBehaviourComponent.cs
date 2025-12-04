using System;
using DayScene.Interactables.Collections.ConditionComponents;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004E1 RID: 1249
	[Token(Token = "0x20004E1")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(MapTransitionConditionComponent))]
	public class MapTransitionEffectBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001C45 RID: 7237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C45")]
		[Address(RVA = "0x4A1590", Offset = "0x49FF90", VA = "0x1804A1590")]
		private void Start()
		{
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		[Token(Token = "0x6001C46")]
		[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "11")]
		protected override bool IsTriggerMode()
		{
			return default(bool);
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C47")]
		[Address(RVA = "0x4A1490", Offset = "0x49FE90", VA = "0x1804A1490", Slot = "7")]
		public override void OnPlayerEnter()
		{
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C48")]
		[Address(RVA = "0x4A1540", Offset = "0x49FF40", VA = "0x1804A1540", Slot = "9")]
		public override void OnPlayerExit()
		{
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C49")]
		[Address(RVA = "0x493E90", Offset = "0x492890", VA = "0x180493E90", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4A")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public MapTransitionEffectBehaviourComponent()
		{
		}

		// Token: 0x040019D3 RID: 6611
		[Token(Token = "0x40019D3")]
		[FieldOffset(Offset = "0x18")]
		private MapTransitionConditionComponent conditionComponent;
	}
}

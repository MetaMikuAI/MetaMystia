using System;
using DayScene.Interactables.Collections.ConditionComponents;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004E0 RID: 1248
	[Token(Token = "0x20004E0")]
	[RequireComponent(typeof(MapTransitionConditionComponent))]
	[GenerateCleanupMethod]
	public class MapTransitionBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001C3D RID: 7229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3D")]
		[Address(RVA = "0x4A12A0", Offset = "0x49FCA0", VA = "0x1804A12A0")]
		private void Start()
		{
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		[Token(Token = "0x6001C3E")]
		[Address(RVA = "0x4A1260", Offset = "0x49FC60", VA = "0x1804A1260", Slot = "11")]
		protected override bool IsTriggerMode()
		{
			return default(bool);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3F")]
		[Address(RVA = "0x4A1100", Offset = "0x49FB00", VA = "0x1804A1100")]
		private void ExecuteMapTransition()
		{
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C40")]
		[Address(RVA = "0x4A1290", Offset = "0x49FC90", VA = "0x1804A1290", Slot = "7")]
		public override void OnPlayerEnter()
		{
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C41")]
		[Address(RVA = "0x4A1270", Offset = "0x49FC70", VA = "0x1804A1270", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C42")]
		[Address(RVA = "0x4A10D0", Offset = "0x49FAD0", VA = "0x1804A10D0", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C43")]
		[Address(RVA = "0x4A1300", Offset = "0x49FD00", VA = "0x1804A1300")]
		public MapTransitionBehaviourComponent()
		{
		}

		// Token: 0x040019D0 RID: 6608
		[Token(Token = "0x40019D0")]
		[FieldOffset(Offset = "0x18")]
		public bool isInteractTransition;

		// Token: 0x040019D1 RID: 6609
		[Token(Token = "0x40019D1")]
		[FieldOffset(Offset = "0x19")]
		private bool canBeInteract;

		// Token: 0x040019D2 RID: 6610
		[Token(Token = "0x40019D2")]
		[FieldOffset(Offset = "0x20")]
		private MapTransitionConditionComponent conditionComponent;
	}
}

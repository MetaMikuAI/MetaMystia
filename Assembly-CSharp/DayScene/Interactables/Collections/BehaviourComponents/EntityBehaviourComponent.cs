using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000517 RID: 1303
	[Token(Token = "0x2000517")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(InteractableArea))]
	public abstract class EntityBehaviourComponent : MonoBehaviour
	{
		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x0000AED8 File Offset: 0x000090D8
		[Token(Token = "0x170003E0")]
		protected virtual bool DoNotAutoFacingWhenInteract
		{
			[Token(Token = "0x6001D2C")]
			[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0x4AD7D0", Offset = "0x4AC1D0", VA = "0x1804AD7D0")]
		private void Awake()
		{
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D2E")]
		[Address(RVA = "0x4ADAC0", Offset = "0x4AC4C0", VA = "0x1804ADAC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D2F")]
		[Address(RVA = "0x4ADA20", Offset = "0x4AC420", VA = "0x1804ADA20")]
		private void OnDisable()
		{
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D30")]
		[Address(RVA = "0x4AD970", Offset = "0x4AC370", VA = "0x1804AD970")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D31")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "5")]
		public virtual void OnEnterMap(string mapLabel)
		{
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D32")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "6")]
		public virtual void OnInteract()
		{
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D33")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "7")]
		public virtual void OnPlayerEnter()
		{
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D34")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "8")]
		public virtual void OnPlayerStay()
		{
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D35")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "9")]
		public virtual void OnPlayerExit()
		{
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x0000AEF0 File Offset: 0x000090F0
		[Token(Token = "0x6001D36")]
		[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "10")]
		protected virtual bool AutoInitialize()
		{
			return default(bool);
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x0000AF08 File Offset: 0x00009108
		[Token(Token = "0x6001D37")]
		[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0", Slot = "11")]
		protected virtual bool IsTriggerMode()
		{
			return default(bool);
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D38")]
		[Address(RVA = "0x4AD8B0", Offset = "0x4AC2B0", VA = "0x1804AD8B0")]
		public void Initialize()
		{
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D39")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "12")]
		protected virtual void OnInitialize()
		{
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3A")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "13")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3B")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		protected EntityBehaviourComponent()
		{
		}
	}
}

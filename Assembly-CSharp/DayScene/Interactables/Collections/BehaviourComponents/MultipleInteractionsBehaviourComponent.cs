using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000511 RID: 1297
	[Token(Token = "0x2000511")]
	[GenerateCleanupMethod]
	public abstract class MultipleInteractionsBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DD")]
		public string Id
		{
			[Token(Token = "0x6001D08")]
			[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D09")]
			[Address(RVA = "0x47DD00", Offset = "0x47C700", VA = "0x18047DD00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001D0A RID: 7434 RVA: 0x0000AE90 File Offset: 0x00009090
		// (set) Token: 0x06001D0B RID: 7435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DE")]
		public int CurrentIndex
		{
			[Token(Token = "0x6001D0A")]
			[Address(RVA = "0x44F9C0", Offset = "0x44E3C0", VA = "0x18044F9C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D0B")]
			[Address(RVA = "0x4B2A20", Offset = "0x4B1420", VA = "0x1804B2A20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x0000AEA8 File Offset: 0x000090A8
		// (set) Token: 0x06001D0D RID: 7437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DF")]
		public int MaxIndex
		{
			[Token(Token = "0x6001D0C")]
			[Address(RVA = "0x44FA10", Offset = "0x44E410", VA = "0x18044FA10")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001D0D")]
			[Address(RVA = "0x4B2A30", Offset = "0x4B1430", VA = "0x1804B2A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001D0E RID: 7438
		[Token(Token = "0x6001D0E")]
		protected abstract void Start();

		// Token: 0x06001D0F RID: 7439
		[Token(Token = "0x6001D0F")]
		protected abstract void Interact();

		// Token: 0x06001D10 RID: 7440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D10")]
		[Address(RVA = "0x4B24D0", Offset = "0x4B0ED0", VA = "0x1804B24D0", Slot = "12")]
		protected override void OnInitialize()
		{
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D11")]
		[Address(RVA = "0x4B24F0", Offset = "0x4B0EF0", VA = "0x1804B24F0", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D12")]
		[Address(RVA = "0x4B23A0", Offset = "0x4B0DA0", VA = "0x1804B23A0")]
		protected void Init(string id, int currentIndex, int maxIndex, params Action[] tasks)
		{
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D13")]
		[Address(RVA = "0x4B22E0", Offset = "0x4B0CE0", VA = "0x1804B22E0")]
		protected void Execute()
		{
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D14")]
		[Address(RVA = "0x4B2510", Offset = "0x4B0F10", VA = "0x1804B2510", Slot = "16")]
		protected virtual void OpenShop(DialogPackage dialogPackage)
		{
		}

		// Token: 0x06001D15 RID: 7445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D15")]
		[Address(RVA = "0x4B2920", Offset = "0x4B1320", VA = "0x1804B2920", Slot = "17")]
		protected virtual void PlayDialog(DialogPackage dialogPackage, Action callback)
		{
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D16")]
		[Address(RVA = "0x4B2270", Offset = "0x4B0C70", VA = "0x1804B2270", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D17")]
		[Address(RVA = "0x4B2990", Offset = "0x4B1390", VA = "0x1804B2990")]
		protected MultipleInteractionsBehaviourComponent()
		{
		}

		// Token: 0x04001AC5 RID: 6853
		[Token(Token = "0x4001AC5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string characterLabel;

		// Token: 0x04001AC6 RID: 6854
		[Token(Token = "0x4001AC6")]
		[FieldOffset(Offset = "0x20")]
		private readonly Dictionary<int, Action> _actions;
	}
}

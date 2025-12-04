using System;
using System.Runtime.CompilerServices;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x0200103C RID: 4156
	[Token(Token = "0x200103C")]
	[GenerateCleanupMethod]
	public abstract class CharacterControllerInputGeneratorComponent : MonoBehaviour
	{
		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06005FED RID: 24557 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005FEE RID: 24558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D40")]
		public CharacterControllerUnit Character
		{
			[Token(Token = "0x6005FED")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005FEE")]
			[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06005FEF RID: 24559 RVA: 0x000211B0 File Offset: 0x0001F3B0
		// (set) Token: 0x06005FF0 RID: 24560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D41")]
		[CleanupIgnore]
		protected bool Moving
		{
			[Token(Token = "0x6005FEF")]
			[Address(RVA = "0x8C4000", Offset = "0x8C2A00", VA = "0x1808C4000")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005FF0")]
			[Address(RVA = "0x8C4020", Offset = "0x8C2A20", VA = "0x1808C4020")]
			set
			{
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (set) Token: 0x06005FF1 RID: 24561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D42")]
		[CleanupIgnore]
		protected bool Sprint
		{
			[Token(Token = "0x6005FF1")]
			[Address(RVA = "0x8C4040", Offset = "0x8C2A40", VA = "0x1808C4040")]
			set
			{
			}
		}

		// Token: 0x17000D43 RID: 3395
		// (get) Token: 0x06005FF2 RID: 24562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D43")]
		protected CharacterControllerUnit CharacterController
		{
			[Token(Token = "0x6005FF2")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005FF3 RID: 24563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF3")]
		[Address(RVA = "0x8C3C80", Offset = "0x8C2680", VA = "0x1808C3C80")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005FF4 RID: 24564
		[Token(Token = "0x6005FF4")]
		protected abstract void OnExternalStop();

		// Token: 0x06005FF5 RID: 24565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF5")]
		[Address(RVA = "0x8C3B90", Offset = "0x8C2590", VA = "0x1808C3B90")]
		public void ExternalStop()
		{
		}

		// Token: 0x06005FF6 RID: 24566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF6")]
		[Address(RVA = "0x8C3BD0", Offset = "0x8C25D0", VA = "0x1808C3BD0")]
		public void Initialize(CharacterSpriteSetCompact visualCompact, float moveSpeedMultiplier, bool shouldTurnOnCollider)
		{
		}

		// Token: 0x06005FF7 RID: 24567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF7")]
		[Address(RVA = "0x8C3BD0", Offset = "0x8C25D0", VA = "0x1808C3BD0")]
		public void Initialize(CharacterSpriteSetFull visualFull, float moveSpeedMultiplier, bool shouldTurnOnCollider)
		{
		}

		// Token: 0x06005FF8 RID: 24568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF8")]
		[Address(RVA = "0x8C3D40", Offset = "0x8C2740", VA = "0x1808C3D40")]
		public void ResetCharacter()
		{
		}

		// Token: 0x06005FF9 RID: 24569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FF9")]
		[Address(RVA = "0x43B080", Offset = "0x439A80", VA = "0x18043B080", Slot = "5")]
		public virtual void OnInitialize()
		{
		}

		// Token: 0x06005FFA RID: 24570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FFA")]
		[Address(RVA = "0x8C3F70", Offset = "0x8C2970", VA = "0x1808C3F70")]
		public void UpdateRotation(int rotation)
		{
		}

		// Token: 0x06005FFB RID: 24571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FFB")]
		[Address(RVA = "0x8C3F90", Offset = "0x8C2990", VA = "0x1808C3F90")]
		public void UpdateSpeed(float extraSpeed)
		{
		}

		// Token: 0x06005FFC RID: 24572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FFC")]
		[Address(RVA = "0x8C3D90", Offset = "0x8C2790", VA = "0x1808C3D90")]
		protected void UpdateInputDirection(Vector2 inputDirection)
		{
		}

		// Token: 0x06005FFD RID: 24573 RVA: 0x000211C8 File Offset: 0x0001F3C8
		[Token(Token = "0x6005FFD")]
		[Address(RVA = "0x8C3CC0", Offset = "0x8C26C0", VA = "0x1808C3CC0")]
		protected Vector3 PreviewTargetPosition(Vector2 inputDirection)
		{
			return default(Vector3);
		}

		// Token: 0x06005FFE RID: 24574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FFE")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "6")]
		public virtual void OnTimelinePositionUpdated()
		{
		}

		// Token: 0x06005FFF RID: 24575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FFF")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "7")]
		protected virtual void OnDestroyCalled()
		{
		}

		// Token: 0x06006000 RID: 24576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006000")]
		[Address(RVA = "0x861FA0", Offset = "0x8609A0", VA = "0x180861FA0", Slot = "8")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06006001 RID: 24577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006001")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		protected CharacterControllerInputGeneratorComponent()
		{
		}

		// Token: 0x040058D8 RID: 22744
		[Token(Token = "0x40058D8")]
		protected const float INPUT_CUTOFF = 0.2f;

		// Token: 0x040058D9 RID: 22745
		[Token(Token = "0x40058D9")]
		public const float CHARACTER_CELL_DISTANCE_OFFSET = 0.05f;

		// Token: 0x040058DA RID: 22746
		[Token(Token = "0x40058DA")]
		[FieldOffset(Offset = "0x18")]
		private bool deltaInputAvailability;
	}
}

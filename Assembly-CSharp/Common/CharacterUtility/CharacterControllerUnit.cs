using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x02001041 RID: 4161
	[Token(Token = "0x2001041")]
	[RequireComponent(typeof(Rigidbody2D))]
	[GenerateCleanupMethod]
	public class CharacterControllerUnit : MonoBehaviour
	{
		// Token: 0x17000D46 RID: 3398
		// (get) Token: 0x06006012 RID: 24594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D46")]
		public SpriteRenderer[] AllSpriteRenderers
		{
			[Token(Token = "0x6006012")]
			[Address(RVA = "0x8C6C60", Offset = "0x8C5660", VA = "0x1808C6C60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06006013 RID: 24595 RVA: 0x00021258 File Offset: 0x0001F458
		[Token(Token = "0x17000D47")]
		public int CanDetachTrimNum
		{
			[Token(Token = "0x6006013")]
			[Address(RVA = "0x8C70F0", Offset = "0x8C5AF0", VA = "0x1808C70F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (set) Token: 0x06006014 RID: 24596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D48")]
		public bool DoSprint
		{
			[Token(Token = "0x6006014")]
			[Address(RVA = "0x8C7370", Offset = "0x8C5D70", VA = "0x1808C7370")]
			set
			{
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06006015 RID: 24597 RVA: 0x00021270 File Offset: 0x0001F470
		// (set) Token: 0x06006016 RID: 24598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D49")]
		public float ExtraYOffset
		{
			[Token(Token = "0x6006015")]
			[Address(RVA = "0x8C7330", Offset = "0x8C5D30", VA = "0x1808C7330")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6006016")]
			[Address(RVA = "0x8C73B0", Offset = "0x8C5DB0", VA = "0x1808C73B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (set) Token: 0x06006017 RID: 24599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D4A")]
		public string OverrideLayerName
		{
			[Token(Token = "0x6006017")]
			[Address(RVA = "0x8C7540", Offset = "0x8C5F40", VA = "0x1808C7540")]
			set
			{
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06006018 RID: 24600 RVA: 0x00021288 File Offset: 0x0001F488
		[Token(Token = "0x17000D4B")]
		private float CurrentMoveSpeed
		{
			[Token(Token = "0x6006018")]
			[Address(RVA = "0x8C7210", Offset = "0x8C5C10", VA = "0x1808C7210")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06006019 RID: 24601 RVA: 0x000212A0 File Offset: 0x0001F4A0
		// (set) Token: 0x0600601A RID: 24602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D4C")]
		public float MoveSpeedMultiplier
		{
			[Token(Token = "0x6006019")]
			[Address(RVA = "0x429B50", Offset = "0x428550", VA = "0x180429B50")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600601A")]
			[Address(RVA = "0x429B80", Offset = "0x428580", VA = "0x180429B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x0600601B RID: 24603 RVA: 0x000212B8 File Offset: 0x0001F4B8
		[Token(Token = "0x17000D4D")]
		public int CurrentRotation
		{
			[Token(Token = "0x600601B")]
			[Address(RVA = "0x8C72C0", Offset = "0x8C5CC0", VA = "0x1808C72C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x0600601C RID: 24604 RVA: 0x000212D0 File Offset: 0x0001F4D0
		// (set) Token: 0x0600601D RID: 24605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D4E")]
		public bool IsMoving
		{
			[Token(Token = "0x600601C")]
			[Address(RVA = "0x8C7340", Offset = "0x8C5D40", VA = "0x1808C7340")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600601D")]
			[Address(RVA = "0x8C73C0", Offset = "0x8C5DC0", VA = "0x1808C73C0")]
			set
			{
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x0600601E RID: 24606 RVA: 0x000212E8 File Offset: 0x0001F4E8
		// (set) Token: 0x0600601F RID: 24607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D4F")]
		public bool ShouldHaveStepSFX
		{
			[Token(Token = "0x600601E")]
			[Address(RVA = "0x8C7350", Offset = "0x8C5D50", VA = "0x1808C7350")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600601F")]
			[Address(RVA = "0x8C75F0", Offset = "0x8C5FF0", VA = "0x1808C75F0")]
			set
			{
			}
		}

		// Token: 0x06006020 RID: 24608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006020")]
		[Address(RVA = "0x8C4380", Offset = "0x8C2D80", VA = "0x1808C4380")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006021")]
		[Address(RVA = "0x8C4980", Offset = "0x8C3380", VA = "0x1808C4980")]
		private void LateUpdate()
		{
		}

		// Token: 0x06006022 RID: 24610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006022")]
		[Address(RVA = "0x8C4D10", Offset = "0x8C3710", VA = "0x1808C4D10")]
		public void SetShadow(bool shadowOpen)
		{
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006023")]
		[Address(RVA = "0x8C47F0", Offset = "0x8C31F0", VA = "0x1808C47F0")]
		public void Initialize(CharacterSpriteSetCompact compactOrFullvisual, float moveSpeedMultiplier, bool shouldTurnOnCollider)
		{
		}

		// Token: 0x06006024 RID: 24612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006024")]
		public T GetInputProcessor<T>() where T : CharacterControllerUnitInputProcessorComponent
		{
			return null;
		}

		// Token: 0x06006025 RID: 24613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006025")]
		public T AddInputProcessor<T>() where T : CharacterControllerUnitInputProcessorComponent
		{
			return null;
		}

		// Token: 0x06006026 RID: 24614 RVA: 0x00021300 File Offset: 0x0001F500
		[Token(Token = "0x6006026")]
		[Address(RVA = "0x8C5E80", Offset = "0x8C4880", VA = "0x1808C5E80")]
		private bool TryUpdateCurrent(CharacterSpriteSetCompact visual)
		{
			return default(bool);
		}

		// Token: 0x06006027 RID: 24615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006027")]
		[Address(RVA = "0x8C5FA0", Offset = "0x8C49A0", VA = "0x1808C5FA0")]
		public void UpdateCharacterSprite(CharacterSpriteSetCompact compactOrFullVisual)
		{
		}

		// Token: 0x06006028 RID: 24616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006028")]
		[Address(RVA = "0x8C6650", Offset = "0x8C5050", VA = "0x1808C6650")]
		public void UpdateColliderStatus(bool shouldOpen)
		{
		}

		// Token: 0x06006029 RID: 24617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006029")]
		[Address(RVA = "0x8C66F0", Offset = "0x8C50F0", VA = "0x1808C66F0")]
		public void UpdateInputVelocity(Vector2 inputDirection)
		{
		}

		// Token: 0x0600602A RID: 24618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602A")]
		[Address(RVA = "0x8C4C50", Offset = "0x8C3650", VA = "0x1808C4C50")]
		public void SetRotation(int rotation)
		{
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602B")]
		[Address(RVA = "0x8C4B20", Offset = "0x8C3520", VA = "0x1808C4B20")]
		public void SetFace(int faceId)
		{
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602C")]
		[Address(RVA = "0x8C4D30", Offset = "0x8C3730", VA = "0x1808C4D30")]
		public void SetStepManual(int step)
		{
		}

		// Token: 0x0600602D RID: 24621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602D")]
		[Address(RVA = "0x8C4A60", Offset = "0x8C3460", VA = "0x1808C4A60")]
		public void SetExtraSpeed(float extraSpeed)
		{
		}

		// Token: 0x0600602E RID: 24622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600602E")]
		[Address(RVA = "0x8C42C0", Offset = "0x8C2CC0", VA = "0x1808C42C0")]
		private void FixedUpdateMoving()
		{
		}

		// Token: 0x0600602F RID: 24623 RVA: 0x00021318 File Offset: 0x0001F518
		[Token(Token = "0x600602F")]
		[Address(RVA = "0x8C4660", Offset = "0x8C3060", VA = "0x1808C4660")]
		public Vector2 GetTargetMovePosition(Vector3 inputDirection)
		{
			return default(Vector2);
		}

		// Token: 0x06006030 RID: 24624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006030")]
		[Address(RVA = "0x8C6810", Offset = "0x8C5210", VA = "0x1808C6810")]
		private void UpdateVisualRepresentation()
		{
		}

		// Token: 0x06006031 RID: 24625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006031")]
		[Address(RVA = "0x8C49A0", Offset = "0x8C33A0", VA = "0x1808C49A0")]
		private void SetAnimator(sbyte currentRotation)
		{
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006032")]
		[Address(RVA = "0x8C5790", Offset = "0x8C4190", VA = "0x1808C5790")]
		private void TrySpawnAccompanyingTrim(CharacterSpriteSetCompact visualCompact)
		{
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006033")]
		[Address(RVA = "0x8C4D60", Offset = "0x8C3760", VA = "0x1808C4D60")]
		private void SetTrimParent(CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition index, CharacterControllerUnit newAccompanyingTrim, CharacterControllerUnit parentTrim)
		{
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x00021330 File Offset: 0x0001F530
		[Token(Token = "0x6006034")]
		[Address(RVA = "0x8C56B0", Offset = "0x8C40B0", VA = "0x1808C56B0")]
		private bool TryGet(out CharacterControllerUnit detachControllerUnit, int index)
		{
			return default(bool);
		}

		// Token: 0x06006035 RID: 24629 RVA: 0x00021348 File Offset: 0x0001F548
		[Token(Token = "0x6006035")]
		[Address(RVA = "0x8C5420", Offset = "0x8C3E20", VA = "0x1808C5420")]
		public bool TryDetach(out CharacterControllerUnit detachControllerUnit, int index)
		{
			return default(bool);
		}

		// Token: 0x06006036 RID: 24630 RVA: 0x00021360 File Offset: 0x0001F560
		[Token(Token = "0x6006036")]
		[Address(RVA = "0x8C4EB0", Offset = "0x8C38B0", VA = "0x1808C4EB0")]
		public bool TryConnect()
		{
			return default(bool);
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006037")]
		[Address(RVA = "0x8C4090", Offset = "0x8C2A90", VA = "0x1808C4090", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006038")]
		[Address(RVA = "0x8C6B40", Offset = "0x8C5540", VA = "0x1808C6B40")]
		public CharacterControllerUnit()
		{
		}

		// Token: 0x06006039 RID: 24633 RVA: 0x00021378 File Offset: 0x0001F578
		[Token(Token = "0x6006039")]
		[Address(RVA = "0x8C5F20", Offset = "0x8C4920", VA = "0x1808C5F20")]
		[CompilerGenerated]
		internal static Vector2Int <UpdateVisualRepresentation>g__NormalizeVelocity|72_0(Vector2 value)
		{
			return default(Vector2Int);
		}

		// Token: 0x040058E0 RID: 22752
		[Token(Token = "0x40058E0")]
		public const int BASE_MOVE_SPEED = 5;

		// Token: 0x040058E1 RID: 22753
		[Token(Token = "0x40058E1")]
		public const float SPRINT_SPEED_MULTIPLIER = 1.5f;

		// Token: 0x040058E2 RID: 22754
		[Token(Token = "0x40058E2")]
		[FieldOffset(Offset = "0x18")]
		public SpriteRenderer pfxRenderer;

		// Token: 0x040058E3 RID: 22755
		[Token(Token = "0x40058E3")]
		[FieldOffset(Offset = "0x20")]
		public SpriteRenderer baseRenderer;

		// Token: 0x040058E4 RID: 22756
		[Token(Token = "0x40058E4")]
		[FieldOffset(Offset = "0x28")]
		public SpriteRenderer faceRenderer;

		// Token: 0x040058E5 RID: 22757
		[Token(Token = "0x40058E5")]
		[FieldOffset(Offset = "0x30")]
		public SpriteRenderer hairRenderer;

		// Token: 0x040058E6 RID: 22758
		[Token(Token = "0x40058E6")]
		[FieldOffset(Offset = "0x38")]
		public SpriteRenderer mainRenderer;

		// Token: 0x040058E7 RID: 22759
		[Token(Token = "0x40058E7")]
		[FieldOffset(Offset = "0x40")]
		public SpriteRenderer backRenderer;

		// Token: 0x040058E8 RID: 22760
		[Token(Token = "0x40058E8")]
		[FieldOffset(Offset = "0x48")]
		public SpriteRenderer shadowRenderer;

		// Token: 0x040058E9 RID: 22761
		[Token(Token = "0x40058E9")]
		[FieldOffset(Offset = "0x50")]
		public Transform frontTrimParent;

		// Token: 0x040058EA RID: 22762
		[Token(Token = "0x40058EA")]
		[FieldOffset(Offset = "0x58")]
		public Transform faceTrimParent;

		// Token: 0x040058EB RID: 22763
		[Token(Token = "0x40058EB")]
		[FieldOffset(Offset = "0x60")]
		public Transform wingTrimParent;

		// Token: 0x040058EC RID: 22764
		[Token(Token = "0x40058EC")]
		[FieldOffset(Offset = "0x68")]
		public Transform behindTrimParent;

		// Token: 0x040058ED RID: 22765
		[Token(Token = "0x40058ED")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CharacterControllerUnit accompanyingTrimParent;

		// Token: 0x040058EE RID: 22766
		[Token(Token = "0x40058EE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool connectedToParent;

		// Token: 0x040058EF RID: 22767
		[Token(Token = "0x40058EF")]
		[FieldOffset(Offset = "0x7C")]
		public Vector2 animationPlaySpeedLerpRange;

		// Token: 0x040058F0 RID: 22768
		[Token(Token = "0x40058F0")]
		[FieldOffset(Offset = "0x88")]
		public AudioClip[] stepSFX;

		// Token: 0x040058F1 RID: 22769
		[Token(Token = "0x40058F1")]
		[FieldOffset(Offset = "0x90")]
		[TupleElementNames(new string[] { "Trim", "IsConnected", "TrimPosition", "CanBeRemoved" })]
		private List<ValueTuple<CharacterControllerUnit, bool, CharacterSpriteSetCompact.RemovableTrimProperty.TrimPosition, bool>> accompanyingTrim;

		// Token: 0x040058F2 RID: 22770
		[Token(Token = "0x40058F2")]
		[FieldOffset(Offset = "0x98")]
		private CharacterAnimator animator;

		// Token: 0x040058F3 RID: 22771
		[Token(Token = "0x40058F3")]
		[FieldOffset(Offset = "0xA0")]
		private sbyte cachedRotation;

		// Token: 0x040058F4 RID: 22772
		[Token(Token = "0x40058F4")]
		[FieldOffset(Offset = "0xA8")]
		private PolygonCollider2D cl2d;

		// Token: 0x040058F5 RID: 22773
		[Token(Token = "0x40058F5")]
		[FieldOffset(Offset = "0xB0")]
		private float extraMoveSpeed;

		// Token: 0x040058F6 RID: 22774
		[Token(Token = "0x40058F6")]
		[FieldOffset(Offset = "0xB4")]
		private bool hasCollider;

		// Token: 0x040058F7 RID: 22775
		[Token(Token = "0x40058F7")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 inputDirection;

		// Token: 0x040058F8 RID: 22776
		[Token(Token = "0x40058F8")]
		[FieldOffset(Offset = "0xC8")]
		private CharacterControllerUnitInputProcessorComponent[] inputProcessors;

		// Token: 0x040058F9 RID: 22777
		[Token(Token = "0x40058F9")]
		[FieldOffset(Offset = "0xD0")]
		private bool isMoving;

		// Token: 0x040058FA RID: 22778
		[Token(Token = "0x40058FA")]
		[FieldOffset(Offset = "0xD8")]
		private CharacterSpriteSetCompact m_CurrentVisual;

		// Token: 0x040058FB RID: 22779
		[Token(Token = "0x40058FB")]
		[FieldOffset(Offset = "0xE0")]
		private Rigidbody2D rb2d;

		// Token: 0x040058FC RID: 22780
		[Token(Token = "0x40058FC")]
		[FieldOffset(Offset = "0xE8")]
		private sbyte scheduledRotation;

		// Token: 0x040058FD RID: 22781
		[Token(Token = "0x40058FD")]
		[FieldOffset(Offset = "0xEC")]
		private float sprintMultiplier;
	}
}

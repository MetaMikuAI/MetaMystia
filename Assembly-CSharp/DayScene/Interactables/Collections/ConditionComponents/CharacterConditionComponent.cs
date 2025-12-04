using System;
using System.Runtime.CompilerServices;
using Common.CharacterUtility;
using GameData.Core.Collections.CharacterUtility;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x020004C1 RID: 1217
	[Token(Token = "0x20004C1")]
	[RequireComponent(typeof(InteractableArea))]
	[GenerateCleanupMethod]
	public class CharacterConditionComponent : EntityConditionComponent
	{
		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D7")]
		public CharacterControllerUnit Character
		{
			[Token(Token = "0x6001BA8")]
			[Address(RVA = "0x48A940", Offset = "0x489340", VA = "0x18048A940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BA9")]
			[Address(RVA = "0x493610", Offset = "0x492010", VA = "0x180493610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001BAA RID: 7082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D8")]
		public string CharacterLabel
		{
			[Token(Token = "0x6001BAA")]
			[Address(RVA = "0x4935D0", Offset = "0x491FD0", VA = "0x1804935D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001BAB RID: 7083 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		[Token(Token = "0x170003D9")]
		public bool IsOverridePosition
		{
			[Token(Token = "0x6001BAB")]
			[Address(RVA = "0x4935F0", Offset = "0x491FF0", VA = "0x1804935F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BAC")]
		[Address(RVA = "0x4925E0", Offset = "0x490FE0", VA = "0x1804925E0")]
		public void Initialize(TrackedNPC characterData)
		{
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BAD")]
		[Address(RVA = "0x493070", Offset = "0x491A70", VA = "0x180493070")]
		public void SetCircleColliderRadius(float newRadius)
		{
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BAE")]
		[Address(RVA = "0x4934D0", Offset = "0x491ED0", VA = "0x1804934D0")]
		public void UpdatePositionAndRotation()
		{
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0x4934B0", Offset = "0x491EB0", VA = "0x1804934B0")]
		private void UpdateIcon(bool enabled)
		{
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB0")]
		[Address(RVA = "0x492FC0", Offset = "0x4919C0", VA = "0x180492FC0", Slot = "7")]
		protected override void PostDestroy()
		{
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x0000AA10 File Offset: 0x00008C10
		[Token(Token = "0x6001BB1")]
		[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0", Slot = "5")]
		protected override bool AutoInitialize()
		{
			return default(bool);
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x0000AA28 File Offset: 0x00008C28
		[Token(Token = "0x6001BB2")]
		[Address(RVA = "0x492BE0", Offset = "0x4915E0", VA = "0x180492BE0", Slot = "9")]
		protected override bool OnGetAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x0000AA40 File Offset: 0x00008C40
		[Token(Token = "0x6001BB3")]
		[Address(RVA = "0x492490", Offset = "0x490E90", VA = "0x180492490")]
		private bool CheckIfShouldShowIconInMap()
		{
			return default(bool);
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0000AA58 File Offset: 0x00008C58
		[Token(Token = "0x6001BB4")]
		[Address(RVA = "0x492AB0", Offset = "0x4914B0", VA = "0x180492AB0")]
		private bool KyoukoTutorialSet(out bool hasNewTutorial)
		{
			return default(bool);
		}

		// Token: 0x06001BB5 RID: 7093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB5")]
		[Address(RVA = "0x4930C0", Offset = "0x491AC0", VA = "0x1804930C0")]
		private void SetSprite(Sprite sprite)
		{
		}

		// Token: 0x06001BB6 RID: 7094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BB6")]
		[Address(RVA = "0x492580", Offset = "0x490F80", VA = "0x180492580", Slot = "4")]
		protected override Type GetComponentType()
		{
			return null;
		}

		// Token: 0x06001BB7 RID: 7095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB7")]
		[Address(RVA = "0x4924E0", Offset = "0x490EE0", VA = "0x1804924E0", Slot = "10")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB8")]
		[Address(RVA = "0x493540", Offset = "0x491F40", VA = "0x180493540")]
		public CharacterConditionComponent()
		{
		}

		// Token: 0x04001961 RID: 6497
		[Token(Token = "0x4001961")]
		private const float SPRITE_OFFSET = 1.55f;

		// Token: 0x04001962 RID: 6498
		[Token(Token = "0x4001962")]
		private const string KYOUKO_STRINGID = "Kyouko";

		// Token: 0x04001963 RID: 6499
		[Token(Token = "0x4001963")]
		[FieldOffset(Offset = "0x40")]
		private bool internalIconAvailability;

		// Token: 0x04001964 RID: 6500
		[Token(Token = "0x4001964")]
		[FieldOffset(Offset = "0x44")]
		private float m_AdditiveRadius;

		// Token: 0x04001965 RID: 6501
		[Token(Token = "0x4001965")]
		[FieldOffset(Offset = "0x48")]
		private CircleCollider2D m_CircleCollider2D;

		// Token: 0x04001966 RID: 6502
		[Token(Token = "0x4001966")]
		[FieldOffset(Offset = "0x50")]
		private CharacterSpriteSetCompact m_Pixel;

		// Token: 0x04001967 RID: 6503
		[Token(Token = "0x4001967")]
		[FieldOffset(Offset = "0x58")]
		private Transform tipIconTransform;

		// Token: 0x04001968 RID: 6504
		[Token(Token = "0x4001968")]
		[FieldOffset(Offset = "0x60")]
		private SpriteRenderer tipIconRenderer;

		// Token: 0x04001969 RID: 6505
		[Token(Token = "0x4001969")]
		[FieldOffset(Offset = "0x68")]
		private TrackedNPC trackedNPCData;
	}
}

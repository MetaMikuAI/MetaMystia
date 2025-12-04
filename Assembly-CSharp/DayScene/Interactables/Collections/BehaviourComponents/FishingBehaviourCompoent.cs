using System;
using Common.UI;
using Cysharp.Threading.Tasks;
using DayScene.Input;
using DayScene.Interactables.Collections.ConditionComponents;
using DayScene.UI;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using NightScene.UI.GuestManagementUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004EF RID: 1263
	[Token(Token = "0x20004EF")]
	[RequireComponent(typeof(FishingRodConditionComponent))]
	[GenerateCleanupMethod]
	public class FishingBehaviourCompoent : EntityBehaviourComponent
	{
		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x0000AD58 File Offset: 0x00008F58
		[Token(Token = "0x170003DB")]
		protected override bool DoNotAutoFacingWhenInteract
		{
			[Token(Token = "0x6001C7F")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C80")]
		[Address(RVA = "0x49DCC0", Offset = "0x49C6C0", VA = "0x18049DCC0", Slot = "12")]
		protected override void OnInitialize()
		{
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C81")]
		[Address(RVA = "0x49DE10", Offset = "0x49C810", VA = "0x18049DE10", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x6001C82")]
		[Address(RVA = "0x49DD80", Offset = "0x49C780", VA = "0x18049DD80")]
		private UniTaskVoid OnInteractAsync()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0000AD88 File Offset: 0x00008F88
		[Token(Token = "0x6001C83")]
		[Address(RVA = "0x49E0E0", Offset = "0x49CAE0", VA = "0x18049E0E0")]
		private UniTask ShowDialogBoxes(Transform characterTransform, params FishingBehaviourCompoent.FishingResultState[] fishingResultStates)
		{
			return default(UniTask);
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[Token(Token = "0x6001C84")]
		[Address(RVA = "0x49DBD0", Offset = "0x49C5D0", VA = "0x18049DBD0")]
		private UniTask CreateDialogBoxAsync(FishingBehaviourCompoent.FishingResultState fishingResultState, Transform characterTransform)
		{
			return default(UniTask);
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x6001C85")]
		[Address(RVA = "0x49E1E0", Offset = "0x49CBE0", VA = "0x18049E1E0")]
		private UniTask SpawnBonusVFX(bool shouldSpawn)
		{
			return default(UniTask);
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		[Token(Token = "0x6001C86")]
		[Address(RVA = "0x49D940", Offset = "0x49C340", VA = "0x18049D940")]
		private UniTask CharacterStep(Transform characterTransform, DayScenePlayerInputGenerator character, Vector3 characterStartPosition, Vector3 characterTargetPosition)
		{
			return default(UniTask);
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C87")]
		[Address(RVA = "0x49DEB0", Offset = "0x49C8B0", VA = "0x18049DEB0")]
		private void SetRodAnimator(FishingBehaviourCompoent.FishingRotState state)
		{
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C88")]
		[Address(RVA = "0x49DA80", Offset = "0x49C480", VA = "0x18049DA80", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C89")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public FishingBehaviourCompoent()
		{
		}

		// Token: 0x040019F7 RID: 6647
		[Token(Token = "0x40019F7")]
		[FieldOffset(Offset = "0x0")]
		[CleanupIgnore]
		private static readonly Vector2[] m_PlayerTargetPosition;

		// Token: 0x040019F8 RID: 6648
		[Token(Token = "0x40019F8")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int AnimatorKey_Throw;

		// Token: 0x040019F9 RID: 6649
		[Token(Token = "0x40019F9")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int AnimatorKey_Bite;

		// Token: 0x040019FA RID: 6650
		[Token(Token = "0x40019FA")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int AnimatorKey_UnBite;

		// Token: 0x040019FB RID: 6651
		[Token(Token = "0x40019FB")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int AnimatorKey_Lift;

		// Token: 0x040019FC RID: 6652
		[Token(Token = "0x40019FC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DLC4_DaySceneFishingPrePannel m_daySceneFishingPrePannel;

		// Token: 0x040019FD RID: 6653
		[Token(Token = "0x40019FD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DLC4_DaySceneFishingResultPanel m_daySceneFishingResultPannel;

		// Token: 0x040019FE RID: 6654
		[Token(Token = "0x40019FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator m_FishingRodAnimator;

		// Token: 0x040019FF RID: 6655
		[Token(Token = "0x40019FF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_PlayerFishingPosition;

		// Token: 0x04001A00 RID: 6656
		[Token(Token = "0x4001A00")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform m_PlayerThrowPosition;

		// Token: 0x04001A01 RID: 6657
		[Token(Token = "0x4001A01")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float m_PlayerThrowAnimationEndDelay;

		// Token: 0x04001A02 RID: 6658
		[Token(Token = "0x4001A02")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_UnBiteDelay;

		// Token: 0x04001A03 RID: 6659
		[Token(Token = "0x4001A03")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_TreasureDelay;

		// Token: 0x04001A04 RID: 6660
		[Token(Token = "0x4001A04")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Vector2 m_TreasureBonusVFXOffset;

		// Token: 0x04001A05 RID: 6661
		[Token(Token = "0x4001A05")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private DialogBoxUI m_DialogBoxUI;

		// Token: 0x04001A06 RID: 6662
		[Token(Token = "0x4001A06")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_DialogBoxUIDuration;

		// Token: 0x04001A07 RID: 6663
		[Token(Token = "0x4001A07")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SpriteRenderer m_ResultSpriteRenderer;

		// Token: 0x04001A08 RID: 6664
		[Token(Token = "0x4001A08")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SpriteRenderer m_TreasureSpriteRenderer;

		// Token: 0x04001A09 RID: 6665
		[Token(Token = "0x4001A09")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Sprite m_TreasureSprite;

		// Token: 0x04001A0A RID: 6666
		[Token(Token = "0x4001A0A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Sprite m_RubbishSprite;

		// Token: 0x04001A0B RID: 6667
		[Token(Token = "0x4001A0B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject m_BonusEffect;

		// Token: 0x04001A0C RID: 6668
		[Token(Token = "0x4001A0C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform m_VisualPointPosition;

		// Token: 0x04001A0D RID: 6669
		[Token(Token = "0x4001A0D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Vector2 m_VisualPointHelperOffset;

		// Token: 0x04001A0E RID: 6670
		[Token(Token = "0x4001A0E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip m_LiftFromWater;

		// Token: 0x04001A0F RID: 6671
		[Token(Token = "0x4001A0F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip m_AfterLifting;

		// Token: 0x04001A10 RID: 6672
		[Token(Token = "0x4001A10")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip m_BiteSfx;

		// Token: 0x04001A11 RID: 6673
		[Token(Token = "0x4001A11")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private FishingBehaviourCompoent.FishReward[] m_fishRewards;

		// Token: 0x04001A12 RID: 6674
		[Token(Token = "0x4001A12")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private FishingBehaviourCompoent.FishReward[] m_fishRewardsTreasureMode;

		// Token: 0x04001A13 RID: 6675
		[Token(Token = "0x4001A13")]
		[FieldOffset(Offset = "0xC8")]
		private FishingBehaviourCompoent.FishingRotState currentState;

		// Token: 0x020004F0 RID: 1264
		[Token(Token = "0x20004F0")]
		[Serializable]
		public struct FishReward
		{
			// Token: 0x06001C8E RID: 7310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001C8E")]
			[Address(RVA = "0x49D900", Offset = "0x49C300", VA = "0x18049D900")]
			public FishReward(Product rewardProduct, float probability)
			{
			}

			// Token: 0x04001A14 RID: 6676
			[Token(Token = "0x4001A14")]
			[FieldOffset(Offset = "0x0")]
			public Product RewardProduct;

			// Token: 0x04001A15 RID: 6677
			[Token(Token = "0x4001A15")]
			[FieldOffset(Offset = "0x18")]
			public float Probability;
		}

		// Token: 0x020004F1 RID: 1265
		[Token(Token = "0x20004F1")]
		private enum FishingRotState
		{
			// Token: 0x04001A17 RID: 6679
			[Token(Token = "0x4001A17")]
			ThrowAndWait,
			// Token: 0x04001A18 RID: 6680
			[Token(Token = "0x4001A18")]
			Bite,
			// Token: 0x04001A19 RID: 6681
			[Token(Token = "0x4001A19")]
			UnBite,
			// Token: 0x04001A1A RID: 6682
			[Token(Token = "0x4001A1A")]
			LiftToIdle,
			// Token: 0x04001A1B RID: 6683
			[Token(Token = "0x4001A1B")]
			None
		}

		// Token: 0x020004F2 RID: 1266
		[Token(Token = "0x20004F2")]
		private enum FishingResultState
		{
			// Token: 0x04001A1D RID: 6685
			[Token(Token = "0x4001A1D")]
			Fish,
			// Token: 0x04001A1E RID: 6686
			[Token(Token = "0x4001A1E")]
			Trash,
			// Token: 0x04001A1F RID: 6687
			[Token(Token = "0x4001A1F")]
			Treasure,
			// Token: 0x04001A20 RID: 6688
			[Token(Token = "0x4001A20")]
			None
		}
	}
}

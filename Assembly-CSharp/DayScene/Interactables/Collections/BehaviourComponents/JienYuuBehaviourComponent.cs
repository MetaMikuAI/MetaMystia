using System;
using Common.CharacterUtility;
using DayScene.Input;
using DayScene.Interactables.Collections.ConditionComponents;
using DayScene.UI;
using GameData.Core.Collections.CharacterUtility;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004D9 RID: 1241
	[Token(Token = "0x20004D9")]
	[GenerateCleanupMethod]
	public class JienYuuBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001C16 RID: 7190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C16")]
		[Address(RVA = "0x4A0630", Offset = "0x49F030", VA = "0x1804A0630", Slot = "12")]
		protected override void OnInitialize()
		{
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C17")]
		[Address(RVA = "0x4A0590", Offset = "0x49EF90", VA = "0x1804A0590", Slot = "5")]
		public override void OnEnterMap(string mapLabel)
		{
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C18")]
		[Address(RVA = "0x4A0760", Offset = "0x49F160", VA = "0x1804A0760", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C19")]
		[Address(RVA = "0x4A0980", Offset = "0x49F380", VA = "0x1804A0980")]
		private void ReliveHakureiFestival(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1A")]
		[Address(RVA = "0x4A0450", Offset = "0x49EE50", VA = "0x1804A0450")]
		private void MusicRepeatChallenge(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1B")]
		[Address(RVA = "0x4A0280", Offset = "0x49EC80", VA = "0x1804A0280")]
		private void CookingRepeatChallenge(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x4A0AC0", Offset = "0x49F4C0", VA = "0x1804A0AC0")]
		private void SetTargetCompetition(Action closeFirstPanelCallback, DaySceneChatSelectionPannel.BaseInteractData baseInteractData, NightSceneDirector.ChallengeType challengeMode, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C1D")]
		[Address(RVA = "0x4A03C0", Offset = "0x49EDC0", VA = "0x1804A03C0")]
		private string GetTitle(DaySceneChatSelectionPannel.BaseInteractData data, string replaceText)
		{
			return null;
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1E")]
		[Address(RVA = "0x4A0180", Offset = "0x49EB80", VA = "0x1804A0180", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C1F")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public JienYuuBehaviourComponent()
		{
		}

		// Token: 0x040019AA RID: 6570
		[Token(Token = "0x40019AA")]
		private const string INTERACTABLE_KEY = "DLC3_HakureiFestival_JienYuu";

		// Token: 0x040019AB RID: 6571
		[Token(Token = "0x40019AB")]
		private const string OPTION_SELECTDIFFICULTY_RELIVE = "DLC3_HAKUREIFESTIVAL_REPEATCHALLENGE_RELIVE";

		// Token: 0x040019AC RID: 6572
		[Token(Token = "0x40019AC")]
		private const string OPTION_SELECTDIFFICULTY_MUSIC = "DLC3_HAKUREIFESTIVAL_REPEATCHALLENGE_MUSIC";

		// Token: 0x040019AD RID: 6573
		[Token(Token = "0x40019AD")]
		private const string OPTION_SELECTDIFFICULTY_COOKING = "DLC3_HAKUREIFESTIVAL_REPEATCHALLENGE_COOKING";

		// Token: 0x040019AE RID: 6574
		[Token(Token = "0x40019AE")]
		private const string OPTION_SELECTTARGET = "DLC3_HAKUREIFESTIVAL_REPEATCHALLENGE_CHALLENGE_SOMEONE";

		// Token: 0x040019AF RID: 6575
		[Token(Token = "0x40019AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterSpriteSetCompact m_CharacterVisual;

		// Token: 0x040019B0 RID: 6576
		[Token(Token = "0x40019B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_TipIcon;

		// Token: 0x040019B1 RID: 6577
		[Token(Token = "0x40019B1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DayScenePlayerInputGenerator.CharacterRotation m_FaceDirection;

		// Token: 0x040019B2 RID: 6578
		[Token(Token = "0x40019B2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DialogPackage m_FirstDialog;

		// Token: 0x040019B3 RID: 6579
		[Token(Token = "0x40019B3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PlayableAsset m_ReliveTimeline;

		// Token: 0x040019B4 RID: 6580
		[Token(Token = "0x40019B4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DialogPackage m_ConfirmDialog;

		// Token: 0x040019B5 RID: 6581
		[Token(Token = "0x40019B5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string repeatChallengeEventId;

		// Token: 0x040019B6 RID: 6582
		[Token(Token = "0x40019B6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Header("[Switch Platform Specific]")]
		private CharacterSpriteSetCompact m_SwitchCharacterVisual;

		// Token: 0x040019B7 RID: 6583
		[Token(Token = "0x40019B7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private DialogPackage m_SwitchFirstDialog;

		// Token: 0x040019B8 RID: 6584
		[Token(Token = "0x40019B8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private DialogPackage m_SwitchNormalDialog;

		// Token: 0x040019B9 RID: 6585
		[Token(Token = "0x40019B9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private DialogPackage m_SwitchAcceptDialog;

		// Token: 0x040019BA RID: 6586
		[Token(Token = "0x40019BA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private DialogPackage m_SwitchRefuseDialog;

		// Token: 0x040019BB RID: 6587
		[Token(Token = "0x40019BB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private PlayableAsset m_SwitchReliveTimeline;

		// Token: 0x040019BC RID: 6588
		[Token(Token = "0x40019BC")]
		[FieldOffset(Offset = "0x80")]
		private CharacterControllerUnit m_CharacterControllerUnit;

		// Token: 0x040019BD RID: 6589
		[Token(Token = "0x40019BD")]
		[FieldOffset(Offset = "0x88")]
		private SwitchConditionComponent m_SwitchConditionComponent;

		// Token: 0x040019BE RID: 6590
		[Token(Token = "0x40019BE")]
		[FieldOffset(Offset = "0x90")]
		private readonly bool IsSwitchPlatform;
	}
}

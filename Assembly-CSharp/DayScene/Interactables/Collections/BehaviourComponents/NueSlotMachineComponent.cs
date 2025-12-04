using System;
using System.Collections;
using System.Collections.Generic;
using DayScene.Interactables.Collections.ConditionExtensions;
using DayScene.UI;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.NightSceneUtility.SkillCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200053E RID: 1342
	[Token(Token = "0x200053E")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(StatusTrackerConditionExtension))]
	public class NueSlotMachineComponent : EntityBehaviourComponent
	{
		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x0000B298 File Offset: 0x00009498
		[Token(Token = "0x170003E1")]
		private int CurrentSlotPrice
		{
			[Token(Token = "0x6001DC1")]
			[Address(RVA = "0x4BB450", Offset = "0x4B9E50", VA = "0x1804BB450")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC2")]
		[Address(RVA = "0x4BA230", Offset = "0x4B8C30", VA = "0x1804BA230", Slot = "12")]
		protected override void OnInitialize()
		{
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC3")]
		[Address(RVA = "0x4BB070", Offset = "0x4B9A70", VA = "0x1804BB070")]
		private void TryButton(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC4")]
		[Address(RVA = "0x4BA330", Offset = "0x4B8D30", VA = "0x1804BA330", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0x4BAF10", Offset = "0x4B9910", VA = "0x1804BAF10")]
		private void SetSprites(Spell_Nue.ColorType color, ParticleSystem particle, TrailRenderer trailRenderer)
		{
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DC6")]
		[Address(RVA = "0x4BB370", Offset = "0x4B9D70", VA = "0x1804BB370")]
		private IEnumerator TrySlot()
		{
			return null;
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC7")]
		[Address(RVA = "0x4B9E40", Offset = "0x4B8840", VA = "0x1804B9E40")]
		private void GiveItem(HashSet<Spell_Nue.ColorType> colors)
		{
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[Token(Token = "0x6001DC8")]
		[Address(RVA = "0x4BA520", Offset = "0x4B8F20", VA = "0x1804BA520")]
		private int SelectReward(NueRewardPair rewardPair, NueUFORewardType rewardType, bool isOther)
		{
			return 0;
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC9")]
		[Address(RVA = "0x4B9C90", Offset = "0x4B8690", VA = "0x1804B9C90", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DCA")]
		[Address(RVA = "0x4BB430", Offset = "0x4B9E30", VA = "0x1804BB430")]
		public NueSlotMachineComponent()
		{
		}

		// Token: 0x04001B72 RID: 7026
		[Token(Token = "0x4001B72")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 offset;

		// Token: 0x04001B73 RID: 7027
		[Token(Token = "0x4001B73")]
		[FieldOffset(Offset = "0x28")]
		public GameObject priceTag;

		// Token: 0x04001B74 RID: 7028
		[Token(Token = "0x4001B74")]
		[FieldOffset(Offset = "0x30")]
		public SpriteRenderer MachineOutline;

		// Token: 0x04001B75 RID: 7029
		[Token(Token = "0x4001B75")]
		[FieldOffset(Offset = "0x38")]
		public Sprite slotMachineSprite2;

		// Token: 0x04001B76 RID: 7030
		[Token(Token = "0x4001B76")]
		[FieldOffset(Offset = "0x40")]
		public float waitSeconds;

		// Token: 0x04001B77 RID: 7031
		[Token(Token = "0x4001B77")]
		[FieldOffset(Offset = "0x48")]
		public Spell_Nue.ColorUFO[] colorUFO;

		// Token: 0x04001B78 RID: 7032
		[Token(Token = "0x4001B78")]
		[FieldOffset(Offset = "0x50")]
		public GameObject UFO;

		// Token: 0x04001B79 RID: 7033
		[Token(Token = "0x4001B79")]
		[FieldOffset(Offset = "0x58")]
		public GameObject BingoEffect;

		// Token: 0x04001B7A RID: 7034
		[Token(Token = "0x4001B7A")]
		[FieldOffset(Offset = "0x60")]
		public GameObject BingoEffectR;

		// Token: 0x04001B7B RID: 7035
		[Token(Token = "0x4001B7B")]
		[FieldOffset(Offset = "0x68")]
		public GameObject BingoEffectG;

		// Token: 0x04001B7C RID: 7036
		[Token(Token = "0x4001B7C")]
		[FieldOffset(Offset = "0x70")]
		public GameObject BingoEffectB;

		// Token: 0x04001B7D RID: 7037
		[Token(Token = "0x4001B7D")]
		[FieldOffset(Offset = "0x78")]
		public GameObject NotBingoEffect;

		// Token: 0x04001B7E RID: 7038
		[Token(Token = "0x4001B7E")]
		[FieldOffset(Offset = "0x80")]
		public NueUFORewardMatch[] reward;

		// Token: 0x04001B7F RID: 7039
		[Token(Token = "0x4001B7F")]
		[FieldOffset(Offset = "0x88")]
		public int interactCount;

		// Token: 0x04001B80 RID: 7040
		[Token(Token = "0x4001B80")]
		[FieldOffset(Offset = "0x90")]
		public AudioClip costMoneyClip;

		// Token: 0x04001B81 RID: 7041
		[Token(Token = "0x4001B81")]
		[FieldOffset(Offset = "0x98")]
		public AudioClip goodRewardClip;

		// Token: 0x04001B82 RID: 7042
		[Token(Token = "0x4001B82")]
		[FieldOffset(Offset = "0xA0")]
		public AudioClip badRewardClip;

		// Token: 0x04001B83 RID: 7043
		[Token(Token = "0x4001B83")]
		[FieldOffset(Offset = "0xA8")]
		public int RGBMeatNum;

		// Token: 0x04001B84 RID: 7044
		[Token(Token = "0x4001B84")]
		[FieldOffset(Offset = "0xAC")]
		public int RGBVegNum;

		// Token: 0x04001B85 RID: 7045
		[Token(Token = "0x4001B85")]
		[FieldOffset(Offset = "0xB0")]
		private int[] bevPercentage;

		// Token: 0x04001B86 RID: 7046
		[Token(Token = "0x4001B86")]
		[FieldOffset(Offset = "0xB8")]
		private NueRewardPair[] bevReward;

		// Token: 0x04001B87 RID: 7047
		[Token(Token = "0x4001B87")]
		[FieldOffset(Offset = "0xC0")]
		private List<int> bevs;

		// Token: 0x04001B88 RID: 7048
		[Token(Token = "0x4001B88")]
		[FieldOffset(Offset = "0xC8")]
		private UIElementCluster cluster;

		// Token: 0x04001B89 RID: 7049
		[Token(Token = "0x4001B89")]
		[FieldOffset(Offset = "0xD0")]
		private int[] ingredientPercentage;

		// Token: 0x04001B8A RID: 7050
		[Token(Token = "0x4001B8A")]
		[FieldOffset(Offset = "0xD8")]
		private NueRewardPair[] ingredientReward;

		// Token: 0x04001B8B RID: 7051
		[Token(Token = "0x4001B8B")]
		[FieldOffset(Offset = "0xE0")]
		private List<int> ings;

		// Token: 0x04001B8C RID: 7052
		[Token(Token = "0x4001B8C")]
		[FieldOffset(Offset = "0xE8")]
		private string moduleID;

		// Token: 0x04001B8D RID: 7053
		[Token(Token = "0x4001B8D")]
		[FieldOffset(Offset = "0xF0")]
		private int rewardNum;
	}
}

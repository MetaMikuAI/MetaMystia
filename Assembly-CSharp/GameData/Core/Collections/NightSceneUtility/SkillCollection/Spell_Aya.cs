using System;
using System.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;
using UnityEngine.Serialization;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000945 RID: 2373
	[Token(Token = "0x2000945")]
	[CreateAssetMenu(fileName = "DLC4_Spell_Aya", menuName = "Spells/DLC4/Aya", order = 0)]
	public class Spell_Aya : SpellBase
	{
		// Token: 0x06003AD6 RID: 15062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD6")]
		[Address(RVA = "0x69BC90", Offset = "0x69A690", VA = "0x18069BC90", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x000163F8 File Offset: 0x000145F8
		[Token(Token = "0x6003AD7")]
		[Address(RVA = "0x69BED0", Offset = "0x69A8D0", VA = "0x18069BED0", Slot = "5")]
		protected override bool ShouldCallSpellDeclarationAuto(bool isPositive)
		{
			return default(bool);
		}

		// Token: 0x06003AD8 RID: 15064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AD8")]
		[Address(RVA = "0x69BDB0", Offset = "0x69A7B0", VA = "0x18069BDB0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003AD9 RID: 15065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003AD9")]
		[Address(RVA = "0x69B8E0", Offset = "0x69A2E0", VA = "0x18069B8E0")]
		private void MergeConflict()
		{
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003ADA")]
		[Address(RVA = "0x69BE40", Offset = "0x69A840", VA = "0x18069BE40", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003ADB RID: 15067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADB")]
		[Address(RVA = "0x69BCC0", Offset = "0x69A6C0", VA = "0x18069BCC0")]
		private void OnGuestSpawn(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x06003ADC RID: 15068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADC")]
		[Address(RVA = "0x69B690", Offset = "0x69A090", VA = "0x18069B690")]
		private void AyaSignatureBuff(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADD")]
		[Address(RVA = "0x69BB80", Offset = "0x69A580", VA = "0x18069BB80")]
		private void OnBuffEnd()
		{
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003ADE")]
		[Address(RVA = "0x69C550", Offset = "0x69AF50", VA = "0x18069C550")]
		public Spell_Aya()
		{
		}

		// Token: 0x040031FB RID: 12795
		[Token(Token = "0x40031FB")]
		private const string AYA_NEWS_CHECK_SHOULD_SPAWN = "Aya_News_Check";

		// Token: 0x040031FC RID: 12796
		[Token(Token = "0x40031FC")]
		private const int AYA_SPECIAL_POSITIVE_SPELL = 2;

		// Token: 0x040031FD RID: 12797
		[Token(Token = "0x40031FD")]
		private const int POPULAR_ID = -20;

		// Token: 0x040031FE RID: 12798
		[Token(Token = "0x40031FE")]
		private const string AYA_ADD_ORDERCOUNT_KEY = "Aya_Add_OrderCount_Key";

		// Token: 0x040031FF RID: 12799
		[Token(Token = "0x40031FF")]
		[FieldOffset(Offset = "0x18")]
		public int positiveDuration;

		// Token: 0x04003200 RID: 12800
		[Token(Token = "0x4003200")]
		[FieldOffset(Offset = "0x1C")]
		public int negativeDuration;

		// Token: 0x04003201 RID: 12801
		[Token(Token = "0x4003201")]
		[FieldOffset(Offset = "0x20")]
		public string negativeSpellCardScheduledEventId;

		// Token: 0x04003202 RID: 12802
		[Token(Token = "0x4003202")]
		[FieldOffset(Offset = "0x28")]
		public string positiveSpellCardScheduledEventId;

		// Token: 0x04003203 RID: 12803
		[Token(Token = "0x4003203")]
		[FieldOffset(Offset = "0x30")]
		public string negativeSpellCardNewsLabel;

		// Token: 0x04003204 RID: 12804
		[Token(Token = "0x4003204")]
		[FieldOffset(Offset = "0x38")]
		public string positiveSpellCardNewsLabel;

		// Token: 0x04003205 RID: 12805
		[Token(Token = "0x4003205")]
		[FieldOffset(Offset = "0x40")]
		public int signatureTagId;

		// Token: 0x04003206 RID: 12806
		[Token(Token = "0x4003206")]
		[FieldOffset(Offset = "0x44")]
		public float signatureExtraOrderRate;

		// Token: 0x04003207 RID: 12807
		[Token(Token = "0x4003207")]
		[FieldOffset(Offset = "0x48")]
		public float minCookTimeSatisfyCondition;

		// Token: 0x04003208 RID: 12808
		[Token(Token = "0x4003208")]
		[FieldOffset(Offset = "0x4C")]
		public float addOrderCountRate;

		// Token: 0x04003209 RID: 12809
		[Token(Token = "0x4003209")]
		[FieldOffset(Offset = "0x50")]
		[Header("奖励-报纸")]
		[Header("VFX")]
		public GameObject newspaperVFX;

		// Token: 0x0400320A RID: 12810
		[Token(Token = "0x400320A")]
		[FieldOffset(Offset = "0x58")]
		public GameObject newspaperVFXEN;

		// Token: 0x0400320B RID: 12811
		[Token(Token = "0x400320B")]
		[FieldOffset(Offset = "0x60")]
		public GameObject newspaperVFXJP;

		// Token: 0x0400320C RID: 12812
		[Token(Token = "0x400320C")]
		[FieldOffset(Offset = "0x68")]
		public GameObject newspaperVFXKR;

		// Token: 0x0400320D RID: 12813
		[Token(Token = "0x400320D")]
		[FieldOffset(Offset = "0x70")]
		public GameObject newspaperVFXCNT;

		// Token: 0x0400320E RID: 12814
		[Token(Token = "0x400320E")]
		[FieldOffset(Offset = "0x78")]
		[Header("奖励-无双风神")]
		[Header("VFX")]
		public GameObject peerlessWindGodTrail;

		// Token: 0x0400320F RID: 12815
		[Token(Token = "0x400320F")]
		[FieldOffset(Offset = "0x80")]
		public GameObject jumpEffect;

		// Token: 0x04003210 RID: 12816
		[Token(Token = "0x4003210")]
		[FieldOffset(Offset = "0x88")]
		public float offset;

		// Token: 0x04003211 RID: 12817
		[Token(Token = "0x4003211")]
		[FieldOffset(Offset = "0x8C")]
		public float newsOffset;

		// Token: 0x04003212 RID: 12818
		[Token(Token = "0x4003212")]
		[FieldOffset(Offset = "0x90")]
		public float flashOffset;

		// Token: 0x04003213 RID: 12819
		[Token(Token = "0x4003213")]
		[FieldOffset(Offset = "0x94")]
		[FormerlySerializedAs("startSpeed")]
		public float startDashCost;

		// Token: 0x04003214 RID: 12820
		[Token(Token = "0x4003214")]
		[FieldOffset(Offset = "0x98")]
		[FormerlySerializedAs("finalSpeed")]
		public float finalDashCost;

		// Token: 0x04003215 RID: 12821
		[Token(Token = "0x4003215")]
		[FieldOffset(Offset = "0x9C")]
		public float dashCoolDown;

		// Token: 0x04003216 RID: 12822
		[Token(Token = "0x4003216")]
		[FieldOffset(Offset = "0xA0")]
		public float dashCoolDown2;

		// Token: 0x04003217 RID: 12823
		[Token(Token = "0x4003217")]
		[FieldOffset(Offset = "0xA4")]
		public float angle;

		// Token: 0x04003218 RID: 12824
		[Token(Token = "0x4003218")]
		[FieldOffset(Offset = "0xA8")]
		public Vector2 xRange;

		// Token: 0x04003219 RID: 12825
		[Token(Token = "0x4003219")]
		[FieldOffset(Offset = "0xB0")]
		public Vector2 yRange;

		// Token: 0x0400321A RID: 12826
		[Token(Token = "0x400321A")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject tagObject;

		// Token: 0x0400321B RID: 12827
		[Token(Token = "0x400321B")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject newsObject;

		// Token: 0x0400321C RID: 12828
		[Token(Token = "0x400321C")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject spawnTagEffect;

		// Token: 0x0400321D RID: 12829
		[Token(Token = "0x400321D")]
		[FieldOffset(Offset = "0xD0")]
		[Header("惩罚-龙卷风")]
		public GameObject tornadoVFX;

		// Token: 0x0400321E RID: 12830
		[Token(Token = "0x400321E")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject fogVFX;

		// Token: 0x0400321F RID: 12831
		[Token(Token = "0x400321F")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject newspaperPunishmentVFX;

		// Token: 0x04003220 RID: 12832
		[Token(Token = "0x4003220")]
		[FieldOffset(Offset = "0xE8")]
		public GameObject newspaperPunishmentVFXEN;

		// Token: 0x04003221 RID: 12833
		[Token(Token = "0x4003221")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject newspaperPunishmentVFXJP;

		// Token: 0x04003222 RID: 12834
		[Token(Token = "0x4003222")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject newspaperPunishmentVFXKR;

		// Token: 0x04003223 RID: 12835
		[Token(Token = "0x4003223")]
		[FieldOffset(Offset = "0x100")]
		public GameObject newspaperPunishmentVFXCNT;

		// Token: 0x04003224 RID: 12836
		[Token(Token = "0x4003224")]
		[FieldOffset(Offset = "0x108")]
		public Vector2 newspaperPunishmentFinalPosition;

		// Token: 0x04003225 RID: 12837
		[Token(Token = "0x4003225")]
		[FieldOffset(Offset = "0x110")]
		public float tornadoDuration;

		// Token: 0x04003226 RID: 12838
		[Token(Token = "0x4003226")]
		[FieldOffset(Offset = "0x114")]
		public float tornadoOffset;

		// Token: 0x04003227 RID: 12839
		[Token(Token = "0x4003227")]
		[FieldOffset(Offset = "0x118")]
		public float newspaperPunishmentDuration;

		// Token: 0x04003228 RID: 12840
		[Token(Token = "0x4003228")]
		[FieldOffset(Offset = "0x11C")]
		public float newspaperPunishmentSpawnWait;

		// Token: 0x04003229 RID: 12841
		[Token(Token = "0x4003229")]
		[FieldOffset(Offset = "0x120")]
		public float itemMinDashDistance;

		// Token: 0x0400322A RID: 12842
		[Token(Token = "0x400322A")]
		[FieldOffset(Offset = "0x124")]
		public float itemMaxDashDistance;

		// Token: 0x0400322B RID: 12843
		[Token(Token = "0x400322B")]
		[FieldOffset(Offset = "0x128")]
		public float itemMinRange;

		// Token: 0x0400322C RID: 12844
		[Token(Token = "0x400322C")]
		[FieldOffset(Offset = "0x12C")]
		public float itemMaxRange;

		// Token: 0x0400322D RID: 12845
		[Token(Token = "0x400322D")]
		[FieldOffset(Offset = "0x130")]
		public float itemControlPoint1AngularOffset;

		// Token: 0x0400322E RID: 12846
		[Token(Token = "0x400322E")]
		[FieldOffset(Offset = "0x134")]
		public float itemControlPoint2AngularOffset;

		// Token: 0x0400322F RID: 12847
		[Token(Token = "0x400322F")]
		[FieldOffset(Offset = "0x138")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip newspaperRewardSfx;

		// Token: 0x04003230 RID: 12848
		[Token(Token = "0x4003230")]
		[FieldOffset(Offset = "0x148")]
		public SpellBase.DelayAudioClip ayaJumpSfx;

		// Token: 0x04003231 RID: 12849
		[Token(Token = "0x4003231")]
		[FieldOffset(Offset = "0x158")]
		public SpellBase.DelayAudioClip ayaDash1Sfx;

		// Token: 0x04003232 RID: 12850
		[Token(Token = "0x4003232")]
		[FieldOffset(Offset = "0x168")]
		public SpellBase.DelayAudioClip ayaDash2Sfx;

		// Token: 0x04003233 RID: 12851
		[Token(Token = "0x4003233")]
		[FieldOffset(Offset = "0x178")]
		public SpellBase.DelayAudioClip tornadoSfx;

		// Token: 0x04003234 RID: 12852
		[Token(Token = "0x4003234")]
		[FieldOffset(Offset = "0x188")]
		public SpellBase.DelayAudioClip newspaperPunishmentSfx;

		// Token: 0x04003235 RID: 12853
		[Token(Token = "0x4003235")]
		[FieldOffset(Offset = "0x198")]
		private readonly string AYA_FAMOUS_IZAKAYA;
	}
}

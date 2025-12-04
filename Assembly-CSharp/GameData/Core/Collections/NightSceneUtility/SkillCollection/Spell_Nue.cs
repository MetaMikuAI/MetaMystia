using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x020009EB RID: 2539
	[Token(Token = "0x20009EB")]
	[CreateAssetMenu(fileName = "DLC3_Spell_Nue", menuName = "Spells/DLC3/Nue", order = 2)]
	public class Spell_Nue : SpellBase
	{
		// Token: 0x06003E30 RID: 15920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E30")]
		[Address(RVA = "0x6B3EC0", Offset = "0x6B28C0", VA = "0x1806B3EC0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E31")]
		[Address(RVA = "0x6B4010", Offset = "0x6B2A10", VA = "0x1806B4010")]
		private void SetSprites(Spell_Nue.ColorType color, ParticleSystem particle, TrailRenderer trailRenderer)
		{
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E32")]
		[Address(RVA = "0x6B3EF0", Offset = "0x6B28F0", VA = "0x1806B3EF0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E33")]
		[Address(RVA = "0x6B3F80", Offset = "0x6B2980", VA = "0x1806B3F80", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E34")]
		[Address(RVA = "0x6B4170", Offset = "0x6B2B70", VA = "0x1806B4170")]
		public Spell_Nue()
		{
		}

		// Token: 0x04003616 RID: 13846
		[Token(Token = "0x4003616")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject UFOEffect;

		// Token: 0x04003617 RID: 13847
		[Token(Token = "0x4003617")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float UFODurationSec;

		// Token: 0x04003618 RID: 13848
		[Token(Token = "0x4003618")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float waitForUFOEffective;

		// Token: 0x04003619 RID: 13849
		[Token(Token = "0x4003619")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Spell_Nue.PositiveRewardType targetPostiveIdInUnityEditor;

		// Token: 0x0400361A RID: 13850
		[Token(Token = "0x400361A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Spell_Nue.PunishmentRewardType targetNegativeIdInUnityEditor;

		// Token: 0x0400361B RID: 13851
		[Token(Token = "0x400361B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Spell_Nue.ColorUFO[] ufoSprites;

		// Token: 0x0400361C RID: 13852
		[Token(Token = "0x400361C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Spell_Nue.NueRewardPair[] reward;

		// Token: 0x0400361D RID: 13853
		[Token(Token = "0x400361D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float threeBlueUFOExtraFundRate;

		// Token: 0x0400361E RID: 13854
		[Token(Token = "0x400361E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Spell_Nue.NuePunishmentPair[] punish;

		// Token: 0x0400361F RID: 13855
		[Token(Token = "0x400361F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int ggbUFOExtraCost;

		// Token: 0x04003620 RID: 13856
		[Token(Token = "0x4003620")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float bbrUFOExtraFundRate;

		// Token: 0x04003621 RID: 13857
		[Token(Token = "0x4003621")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("SFX")]
		public AudioClip ufoSFX;

		// Token: 0x04003622 RID: 13858
		[Token(Token = "0x4003622")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioClip rewardSFX;

		// Token: 0x04003623 RID: 13859
		[Token(Token = "0x4003623")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioClip punishmentSFX;

		// Token: 0x020009EC RID: 2540
		[Token(Token = "0x20009EC")]
		public enum ColorType
		{
			// Token: 0x04003625 RID: 13861
			[Token(Token = "0x4003625")]
			R,
			// Token: 0x04003626 RID: 13862
			[Token(Token = "0x4003626")]
			G,
			// Token: 0x04003627 RID: 13863
			[Token(Token = "0x4003627")]
			B,
			// Token: 0x04003628 RID: 13864
			[Token(Token = "0x4003628")]
			E
		}

		// Token: 0x020009ED RID: 2541
		[Token(Token = "0x20009ED")]
		public enum PositiveRewardType
		{
			// Token: 0x0400362A RID: 13866
			[Token(Token = "0x400362A")]
			RRR,
			// Token: 0x0400362B RID: 13867
			[Token(Token = "0x400362B")]
			GGG,
			// Token: 0x0400362C RID: 13868
			[Token(Token = "0x400362C")]
			BBB,
			// Token: 0x0400362D RID: 13869
			[Token(Token = "0x400362D")]
			RGB,
			// Token: 0x0400362E RID: 13870
			[Token(Token = "0x400362E")]
			None
		}

		// Token: 0x020009EE RID: 2542
		[Token(Token = "0x20009EE")]
		public enum PunishmentRewardType
		{
			// Token: 0x04003630 RID: 13872
			[Token(Token = "0x4003630")]
			R2,
			// Token: 0x04003631 RID: 13873
			[Token(Token = "0x4003631")]
			G2,
			// Token: 0x04003632 RID: 13874
			[Token(Token = "0x4003632")]
			B2,
			// Token: 0x04003633 RID: 13875
			[Token(Token = "0x4003633")]
			RRB,
			// Token: 0x04003634 RID: 13876
			[Token(Token = "0x4003634")]
			None
		}

		// Token: 0x020009EF RID: 2543
		[Token(Token = "0x20009EF")]
		[Serializable]
		public struct ColorUFO
		{
			// Token: 0x04003635 RID: 13877
			[Token(Token = "0x4003635")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public Spell_Nue.ColorType colorType;

			// Token: 0x04003636 RID: 13878
			[Token(Token = "0x4003636")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			public Sprite[] ufoSprites;

			// Token: 0x04003637 RID: 13879
			[Token(Token = "0x4003637")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public Gradient trailGradient;
		}

		// Token: 0x020009F0 RID: 2544
		[Token(Token = "0x20009F0")]
		[Serializable]
		public struct NueRewardPair
		{
			// Token: 0x06003E35 RID: 15925 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003E35")]
			[Address(RVA = "0x6B1750", Offset = "0x6B0150", VA = "0x1806B1750")]
			public NueRewardPair(Spell_Nue.PositiveRewardType rewardType, float probability, float durationTime, [Optional] GameObject blinkEffect, [Optional] Spell_Nue.ColorType[] colors)
			{
			}

			// Token: 0x04003638 RID: 13880
			[Token(Token = "0x4003638")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public Spell_Nue.PositiveRewardType RewardType;

			// Token: 0x04003639 RID: 13881
			[Token(Token = "0x4003639")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[SerializeField]
			public float Probability;

			// Token: 0x0400363A RID: 13882
			[Token(Token = "0x400363A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			public float DurationTime;

			// Token: 0x0400363B RID: 13883
			[Token(Token = "0x400363B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public GameObject blinkEffect;

			// Token: 0x0400363C RID: 13884
			[Token(Token = "0x400363C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			public Spell_Nue.ColorType[] colors;
		}

		// Token: 0x020009F1 RID: 2545
		[Token(Token = "0x20009F1")]
		[Serializable]
		public struct NuePunishmentPair
		{
			// Token: 0x06003E36 RID: 15926 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003E36")]
			[Address(RVA = "0x6B1750", Offset = "0x6B0150", VA = "0x1806B1750")]
			public NuePunishmentPair(Spell_Nue.PunishmentRewardType type, float probability, float durationTime, [Optional] GameObject smokeEffect, [Optional] Spell_Nue.ColorType[] colors)
			{
			}

			// Token: 0x0400363D RID: 13885
			[Token(Token = "0x400363D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public Spell_Nue.PunishmentRewardType PunishmentType;

			// Token: 0x0400363E RID: 13886
			[Token(Token = "0x400363E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[SerializeField]
			public float Probability;

			// Token: 0x0400363F RID: 13887
			[Token(Token = "0x400363F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			public float DurationTime;

			// Token: 0x04003640 RID: 13888
			[Token(Token = "0x4003640")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public GameObject smokeEffect;

			// Token: 0x04003641 RID: 13889
			[Token(Token = "0x4003641")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			public Spell_Nue.ColorType[] colors;
		}
	}
}

using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A34 RID: 2612
	[Token(Token = "0x2000A34")]
	[CreateAssetMenu(fileName = "Spell_Sanae", menuName = "Spells/Sanae", order = 45)]
	public class Spell_Sanae : SpellBase
	{
		// Token: 0x06003F8C RID: 16268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8C")]
		[Address(RVA = "0x6C9720", Offset = "0x6C8120", VA = "0x1806C9720", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8D")]
		[Address(RVA = "0x6C9750", Offset = "0x6C8150", VA = "0x1806C9750", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003F8E RID: 16270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F8E")]
		[Address(RVA = "0x6C97D0", Offset = "0x6C81D0", VA = "0x1806C97D0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x000174D8 File Offset: 0x000156D8
		[Token(Token = "0x6003F8F")]
		[Address(RVA = "0x6C9860", Offset = "0x6C8260", VA = "0x1806C9860")]
		private int SelectReward(Spell_Sanae.SanaeRewardPair rewardPair)
		{
			return 0;
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F90")]
		[Address(RVA = "0x6CA090", Offset = "0x6C8A90", VA = "0x1806CA090")]
		public Spell_Sanae()
		{
		}

		// Token: 0x0400379C RID: 14236
		[Token(Token = "0x400379C")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int negativeDuration;

		// Token: 0x0400379D RID: 14237
		[Token(Token = "0x400379D")]
		[FieldOffset(Offset = "0x20")]
		public Spell_Sanae.SanaeRewardPair[] reward;

		// Token: 0x0400379E RID: 14238
		[Token(Token = "0x400379E")]
		[FieldOffset(Offset = "0x28")]
		public int positiveBevNum;

		// Token: 0x0400379F RID: 14239
		[Token(Token = "0x400379F")]
		[FieldOffset(Offset = "0x2C")]
		public int positiveIngredientNum;

		// Token: 0x040037A0 RID: 14240
		[Token(Token = "0x40037A0")]
		[FieldOffset(Offset = "0x30")]
		[Header("Effects")]
		public GameObject sanaeSealPaper;

		// Token: 0x040037A1 RID: 14241
		[Token(Token = "0x40037A1")]
		[FieldOffset(Offset = "0x38")]
		public GameObject sanaeMagicObject;

		// Token: 0x040037A2 RID: 14242
		[Token(Token = "0x40037A2")]
		[FieldOffset(Offset = "0x40")]
		public float punishmentDuration;

		// Token: 0x040037A3 RID: 14243
		[Token(Token = "0x40037A3")]
		[FieldOffset(Offset = "0x44")]
		public float delayTime;

		// Token: 0x040037A4 RID: 14244
		[Token(Token = "0x40037A4")]
		[FieldOffset(Offset = "0x48")]
		public Vector2 paperOffset;

		// Token: 0x040037A5 RID: 14245
		[Token(Token = "0x40037A5")]
		[FieldOffset(Offset = "0x50")]
		public Vector2 magicOffset;

		// Token: 0x040037A6 RID: 14246
		[Token(Token = "0x40037A6")]
		[FieldOffset(Offset = "0x58")]
		public AudioClip punishmentSFX;

		// Token: 0x040037A7 RID: 14247
		[Token(Token = "0x40037A7")]
		[FieldOffset(Offset = "0x60")]
		public GameObject sanaeRewardObject;

		// Token: 0x040037A8 RID: 14248
		[Token(Token = "0x40037A8")]
		[FieldOffset(Offset = "0x68")]
		public float rewardDuration;

		// Token: 0x040037A9 RID: 14249
		[Token(Token = "0x40037A9")]
		[FieldOffset(Offset = "0x70")]
		public AudioClip rewardSFX;

		// Token: 0x02000A35 RID: 2613
		[Token(Token = "0x2000A35")]
		public enum SanaeRewardType : byte
		{
			// Token: 0x040037AB RID: 14251
			[Token(Token = "0x40037AB")]
			Ingredient,
			// Token: 0x040037AC RID: 14252
			[Token(Token = "0x40037AC")]
			Bev
		}

		// Token: 0x02000A36 RID: 2614
		[Token(Token = "0x2000A36")]
		[Serializable]
		public struct SanaeRewardPair
		{
			// Token: 0x06003F91 RID: 16273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003F91")]
			[Address(RVA = "0x4B2260", Offset = "0x4B0C60", VA = "0x1804B2260")]
			public SanaeRewardPair(Spell_Sanae.SanaeRewardType type, int level, float probability)
			{
			}

			// Token: 0x040037AD RID: 14253
			[Token(Token = "0x40037AD")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public Spell_Sanae.SanaeRewardType RewardType;

			// Token: 0x040037AE RID: 14254
			[Token(Token = "0x40037AE")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public int Level;

			// Token: 0x040037AF RID: 14255
			[Token(Token = "0x40037AF")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public float Probability;
		}
	}
}

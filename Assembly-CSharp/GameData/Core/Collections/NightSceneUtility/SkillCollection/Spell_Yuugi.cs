using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000ACE RID: 2766
	[Token(Token = "0x2000ACE")]
	[CreateAssetMenu(fileName = "DLC2_Spell_Yuugi", menuName = "Spells/DLC2/DLC2_Spell_Yuugi", order = 2)]
	public class Spell_Yuugi : SpellBase
	{
		// Token: 0x060042A9 RID: 17065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042A9")]
		[Address(RVA = "0x6FF360", Offset = "0x6FDD60", VA = "0x1806FF360", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x060042AA RID: 17066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AA")]
		[Address(RVA = "0x6FF390", Offset = "0x6FDD90", VA = "0x1806FF390", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x060042AB RID: 17067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AB")]
		[Address(RVA = "0x6FF410", Offset = "0x6FDE10", VA = "0x1806FF410", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x060042AC RID: 17068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042AC")]
		[Address(RVA = "0x6FF500", Offset = "0x6FDF00", VA = "0x1806FF500")]
		public Spell_Yuugi()
		{
		}

		// Token: 0x060042AD RID: 17069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AD")]
		[Address(RVA = "0x6FF490", Offset = "0x6FDE90", VA = "0x1806FF490")]
		[CompilerGenerated]
		internal static IEnumerator <OnNegativeBuffExecute>g__Follow|26_6(Transform gameObject)
		{
			return null;
		}

		// Token: 0x060042AE RID: 17070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AE")]
		[Address(RVA = "0x69E840", Offset = "0x69D240", VA = "0x18069E840")]
		[CompilerGenerated]
		internal static GameObject <OnNegativeBuffExecute>g__GetGameObject|26_8()
		{
			return null;
		}

		// Token: 0x04003AAA RID: 15018
		[Token(Token = "0x4003AAA")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int level1BevNum;

		// Token: 0x04003AAB RID: 15019
		[Token(Token = "0x4003AAB")]
		[FieldOffset(Offset = "0x1C")]
		public float level1BevTransRate;

		// Token: 0x04003AAC RID: 15020
		[Token(Token = "0x4003AAC")]
		[FieldOffset(Offset = "0x20")]
		public int level2BevNum;

		// Token: 0x04003AAD RID: 15021
		[Token(Token = "0x4003AAD")]
		[FieldOffset(Offset = "0x24")]
		public float level2BevTransRate;

		// Token: 0x04003AAE RID: 15022
		[Token(Token = "0x4003AAE")]
		[FieldOffset(Offset = "0x28")]
		public int level3BevNum;

		// Token: 0x04003AAF RID: 15023
		[Token(Token = "0x4003AAF")]
		[FieldOffset(Offset = "0x2C")]
		public float level3BevTransRate;

		// Token: 0x04003AB0 RID: 15024
		[Token(Token = "0x4003AB0")]
		[FieldOffset(Offset = "0x30")]
		public GameObject bowlEffect;

		// Token: 0x04003AB1 RID: 15025
		[Token(Token = "0x4003AB1")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 bowlOffset;

		// Token: 0x04003AB2 RID: 15026
		[Token(Token = "0x4003AB2")]
		[FieldOffset(Offset = "0x40")]
		public GameObject passionHappyEffect;

		// Token: 0x04003AB3 RID: 15027
		[Token(Token = "0x4003AB3")]
		[FieldOffset(Offset = "0x48")]
		public float passionHappyDuration;

		// Token: 0x04003AB4 RID: 15028
		[Token(Token = "0x4003AB4")]
		[FieldOffset(Offset = "0x50")]
		public GameObject removeBevEffect;

		// Token: 0x04003AB5 RID: 15029
		[Token(Token = "0x4003AB5")]
		[FieldOffset(Offset = "0x58")]
		public GameObject getBevEffect;

		// Token: 0x04003AB6 RID: 15030
		[Token(Token = "0x4003AB6")]
		[FieldOffset(Offset = "0x60")]
		public GameObject threeStepsObject;

		// Token: 0x04003AB7 RID: 15031
		[Token(Token = "0x4003AB7")]
		[FieldOffset(Offset = "0x68")]
		public GameObject stunEffect;

		// Token: 0x04003AB8 RID: 15032
		[Token(Token = "0x4003AB8")]
		[FieldOffset(Offset = "0x70")]
		public GameObject bulletEffect;

		// Token: 0x04003AB9 RID: 15033
		[Token(Token = "0x4003AB9")]
		[FieldOffset(Offset = "0x78")]
		public GameObject sinnerShacklesEffect;

		// Token: 0x04003ABA RID: 15034
		[Token(Token = "0x4003ABA")]
		[FieldOffset(Offset = "0x80")]
		public float circle2MoveSpeedMultiplier;

		// Token: 0x04003ABB RID: 15035
		[Token(Token = "0x4003ABB")]
		[FieldOffset(Offset = "0x84")]
		public int circle3StunTime;

		// Token: 0x04003ABC RID: 15036
		[Token(Token = "0x4003ABC")]
		[FieldOffset(Offset = "0x88")]
		public float circle1Radius;

		// Token: 0x04003ABD RID: 15037
		[Token(Token = "0x4003ABD")]
		[FieldOffset(Offset = "0x8C")]
		public float circle2Radius;

		// Token: 0x04003ABE RID: 15038
		[Token(Token = "0x4003ABE")]
		[FieldOffset(Offset = "0x90")]
		public int negativeDuration;

		// Token: 0x04003ABF RID: 15039
		[Token(Token = "0x4003ABF")]
		[FieldOffset(Offset = "0x98")]
		[Header("SFX")]
		public AudioClip rewardSFX;

		// Token: 0x04003AC0 RID: 15040
		[Token(Token = "0x4003AC0")]
		[FieldOffset(Offset = "0xA0")]
		public AudioClip punishmentSFX1;

		// Token: 0x04003AC1 RID: 15041
		[Token(Token = "0x4003AC1")]
		[FieldOffset(Offset = "0xA8")]
		public AudioClip punishmentSFX2;

		// Token: 0x04003AC2 RID: 15042
		[Token(Token = "0x4003AC2")]
		[FieldOffset(Offset = "0xB0")]
		public AudioClip bulletHit;
	}
}

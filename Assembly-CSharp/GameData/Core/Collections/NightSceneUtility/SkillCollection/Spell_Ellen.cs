using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200095F RID: 2399
	[Token(Token = "0x200095F")]
	[CreateAssetMenu(fileName = "DLC5_Spell_Ellen", menuName = "Spells/DLC5/Ellen", order = 0)]
	public class Spell_Ellen : SpellBase
	{
		// Token: 0x06003B5E RID: 15198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B5E")]
		[Address(RVA = "0x69CB40", Offset = "0x69B540", VA = "0x18069CB40", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B5F")]
		[Address(RVA = "0x69CC00", Offset = "0x69B600", VA = "0x18069CC00", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B60")]
		[Address(RVA = "0x69C850", Offset = "0x69B250", VA = "0x18069C850")]
		private void CandyPartySet(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B61")]
		[Address(RVA = "0x69C940", Offset = "0x69B340", VA = "0x18069C940")]
		private void CandyParty(GuestGroupController.EvaluationResult eval, GuestGroupController guestGroupController, bool _)
		{
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B62")]
		[Address(RVA = "0x69CB70", Offset = "0x69B570", VA = "0x18069CB70", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B63")]
		[Address(RVA = "0x69CF60", Offset = "0x69B960", VA = "0x18069CF60")]
		public Spell_Ellen()
		{
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B65")]
		[Address(RVA = "0x69CE50", Offset = "0x69B850", VA = "0x18069CE50")]
		[CompilerGenerated]
		private void <OnPositiveBuffExecute>g__OnBuffEnd|21_1()
		{
		}

		// Token: 0x040032DA RID: 13018
		[Token(Token = "0x40032DA")]
		[FieldOffset(Offset = "0x18")]
		public GameObject candy;

		// Token: 0x040032DB RID: 13019
		[Token(Token = "0x40032DB")]
		[FieldOffset(Offset = "0x20")]
		public int candyId;

		// Token: 0x040032DC RID: 13020
		[Token(Token = "0x40032DC")]
		[FieldOffset(Offset = "0x24")]
		public float candyBuffDuration;

		// Token: 0x040032DD RID: 13021
		[Token(Token = "0x40032DD")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 candyOffsetX;

		// Token: 0x040032DE RID: 13022
		[Token(Token = "0x40032DE")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 candyOffsetY;

		// Token: 0x040032DF RID: 13023
		[Token(Token = "0x40032DF")]
		[FieldOffset(Offset = "0x38")]
		public int negativeDuration;

		// Token: 0x040032E0 RID: 13024
		[Token(Token = "0x40032E0")]
		[FieldOffset(Offset = "0x3C")]
		public float blackCatSpeedModifer;

		// Token: 0x040032E1 RID: 13025
		[Token(Token = "0x40032E1")]
		[FieldOffset(Offset = "0x40")]
		public float blackCatWorkSpeedModifer;

		// Token: 0x040032E2 RID: 13026
		[Token(Token = "0x40032E2")]
		[FieldOffset(Offset = "0x48")]
		[Header("Vfx")]
		public GameObject startCandy;

		// Token: 0x040032E3 RID: 13027
		[Token(Token = "0x40032E3")]
		[FieldOffset(Offset = "0x50")]
		public float candayVfxDuration;

		// Token: 0x040032E4 RID: 13028
		[Token(Token = "0x40032E4")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 candayVfxOffset;

		// Token: 0x040032E5 RID: 13029
		[Token(Token = "0x40032E5")]
		[FieldOffset(Offset = "0x60")]
		public GameObject catVfx;

		// Token: 0x040032E6 RID: 13030
		[Token(Token = "0x40032E6")]
		[FieldOffset(Offset = "0x68")]
		public GameObject catIntimidateVfx;

		// Token: 0x040032E7 RID: 13031
		[Token(Token = "0x40032E7")]
		[FieldOffset(Offset = "0x70")]
		public Vector2 catOffset;

		// Token: 0x040032E8 RID: 13032
		[Token(Token = "0x40032E8")]
		[FieldOffset(Offset = "0x78")]
		public Vector2 catIntimidateOffset;

		// Token: 0x040032E9 RID: 13033
		[Token(Token = "0x40032E9")]
		[FieldOffset(Offset = "0x80")]
		[Header("Sfx")]
		public AudioClip getCandy;

		// Token: 0x040032EA RID: 13034
		[Token(Token = "0x40032EA")]
		[FieldOffset(Offset = "0x88")]
		public SpellBase.DelayAudioClip negativeSfx;

		// Token: 0x040032EB RID: 13035
		[Token(Token = "0x40032EB")]
		[FieldOffset(Offset = "0x98")]
		public SpellBase.DelayAudioClip positiveSfx;

		// Token: 0x040032EC RID: 13036
		[Token(Token = "0x40032EC")]
		[FieldOffset(Offset = "0xA8")]
		public SpellBase.DelayAudioClip positiveSfx2;

		// Token: 0x040032ED RID: 13037
		[Token(Token = "0x40032ED")]
		[FieldOffset(Offset = "0xB8")]
		public SpellBase.DelayAudioClip positiveCandyDrop;
	}
}

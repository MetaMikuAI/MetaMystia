using System;
using System.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.CoreLanguage;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A6C RID: 2668
	[Token(Token = "0x2000A6C")]
	[CreateAssetMenu(fileName = "Spell_Tewi", menuName = "Spells/Tewi", order = 29)]
	public class Spell_Tewi : SpellBase
	{
		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060040BF RID: 16575 RVA: 0x000179E8 File Offset: 0x00015BE8
		[Token(Token = "0x17000942")]
		protected override bool ShouldProtectedByShield
		{
			[Token(Token = "0x60040BF")]
			[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060040C0 RID: 16576 RVA: 0x00017A00 File Offset: 0x00015C00
		[Token(Token = "0x17000943")]
		public override bool HasLeaveSpell
		{
			[Token(Token = "0x60040C0")]
			[Address(RVA = "0x51B640", Offset = "0x51A040", VA = "0x18051B640", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C1")]
		[Address(RVA = "0x6CC8F0", Offset = "0x6CB2F0", VA = "0x1806CC8F0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x00017A18 File Offset: 0x00015C18
		[Token(Token = "0x60040C2")]
		[Address(RVA = "0x6CCB70", Offset = "0x6CB570", VA = "0x1806CCB70", Slot = "5")]
		protected override bool ShouldCallSpellDeclarationAuto(bool isPositive)
		{
			return default(bool);
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C3")]
		[Address(RVA = "0x6CCA40", Offset = "0x6CB440", VA = "0x1806CCA40", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C4")]
		[Address(RVA = "0x6CC540", Offset = "0x6CAF40", VA = "0x1806CC540")]
		private Product[] GetProducts()
		{
			return null;
		}

		// Token: 0x060040C5 RID: 16581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C5")]
		[Address(RVA = "0x6CC9B0", Offset = "0x6CB3B0", VA = "0x1806CC9B0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C6")]
		[Address(RVA = "0x6CC920", Offset = "0x6CB320", VA = "0x1806CC920", Slot = "12")]
		protected override IEnumerator OnLeaveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C7")]
		[Address(RVA = "0x6CCAC0", Offset = "0x6CB4C0", VA = "0x1806CCAC0")]
		private IEnumerator RunPunishmentSpell(SpecialGuest characterData, LanguageBase[] spellLanguageData)
		{
			return null;
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040C8")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Tewi()
		{
		}

		// Token: 0x040038E5 RID: 14565
		[Token(Token = "0x40038E5")]
		private const string SPECIAL_EVENT_KEY = "Special_Event_Tewi_Buy_Reisen";

		// Token: 0x040038E6 RID: 14566
		[Token(Token = "0x40038E6")]
		[FieldOffset(Offset = "0x18")]
		public Spell_Tewi_SharedData sharedData;

		// Token: 0x040038E7 RID: 14567
		[Token(Token = "0x40038E7")]
		[FieldOffset(Offset = "0x20")]
		public bool isHardSell;
	}
}

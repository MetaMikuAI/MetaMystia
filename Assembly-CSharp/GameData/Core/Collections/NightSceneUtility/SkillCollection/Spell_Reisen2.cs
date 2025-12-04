using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A14 RID: 2580
	[Token(Token = "0x2000A14")]
	[CreateAssetMenu(fileName = "DLC5_Spell_Reisen2", menuName = "Spells/DLC5/Reisen2", order = 3)]
	public class Spell_Reisen2 : SpellBase
	{
		// Token: 0x06003EEA RID: 16106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEA")]
		[Address(RVA = "0x6C77E0", Offset = "0x6C61E0", VA = "0x1806C77E0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EEB")]
		[Address(RVA = "0x6C78A0", Offset = "0x6C62A0", VA = "0x1806C78A0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEC")]
		[Address(RVA = "0x6C7920", Offset = "0x6C6320", VA = "0x1806C7920")]
		private void OnRabbitSpawn(Transform offset, EventManager.RabbitType rabbitType)
		{
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EED")]
		[Address(RVA = "0x6C7060", Offset = "0x6C5A60", VA = "0x1806C7060")]
		private List<ValueTuple<Transform, EventManager.RabbitType>> FindAllRabbits()
		{
			return null;
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEE")]
		[Address(RVA = "0x6C7930", Offset = "0x6C6330", VA = "0x1806C7930")]
		private void SpawnIngredientsOrBeverage(Transform offset, EventManager.RabbitType rabbitType)
		{
		}

		// Token: 0x06003EEF RID: 16111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EEF")]
		[Address(RVA = "0x6C7BE0", Offset = "0x6C65E0", VA = "0x1806C7BE0")]
		private void SpawnRabbitVfx(Transform offset, EventManager.RabbitType rabbitType, Sprite sprite)
		{
		}

		// Token: 0x06003EF0 RID: 16112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EF0")]
		[Address(RVA = "0x6C7810", Offset = "0x6C6210", VA = "0x1806C7810", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF1")]
		[Address(RVA = "0x6C7F80", Offset = "0x6C6980", VA = "0x1806C7F80")]
		public Spell_Reisen2()
		{
		}

		// Token: 0x040036FB RID: 14075
		[Token(Token = "0x40036FB")]
		[FieldOffset(Offset = "0x18")]
		public float ingredientsRate;

		// Token: 0x040036FC RID: 14076
		[Token(Token = "0x40036FC")]
		[FieldOffset(Offset = "0x1C")]
		public int positiveDuration;

		// Token: 0x040036FD RID: 14077
		[Token(Token = "0x40036FD")]
		[FieldOffset(Offset = "0x20")]
		public int negativeDuration;

		// Token: 0x040036FE RID: 14078
		[Token(Token = "0x40036FE")]
		[FieldOffset(Offset = "0x24")]
		public int negativeDurationIfReisenExist;

		// Token: 0x040036FF RID: 14079
		[Token(Token = "0x40036FF")]
		[FieldOffset(Offset = "0x28")]
		[Header("VFX")]
		public GameObject magicianHat;

		// Token: 0x04003700 RID: 14080
		[Token(Token = "0x4003700")]
		[FieldOffset(Offset = "0x30")]
		public float magicianHatDuration;

		// Token: 0x04003701 RID: 14081
		[Token(Token = "0x4003701")]
		[FieldOffset(Offset = "0x34")]
		public float magicianRabbitSpawnDuration;

		// Token: 0x04003702 RID: 14082
		[Token(Token = "0x4003702")]
		[FieldOffset(Offset = "0x38")]
		public GameObject rabbitVfx;

		// Token: 0x04003703 RID: 14083
		[Token(Token = "0x4003703")]
		[FieldOffset(Offset = "0x40")]
		public float rabbitDuration;

		// Token: 0x04003704 RID: 14084
		[Token(Token = "0x4003704")]
		[FieldOffset(Offset = "0x48")]
		public Sprite[] rabbits;

		// Token: 0x04003705 RID: 14085
		[Token(Token = "0x4003705")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 offsetForRabbitGuest;

		// Token: 0x04003706 RID: 14086
		[Token(Token = "0x4003706")]
		[FieldOffset(Offset = "0x5C")]
		public Vector3 offsetForRabbitDecoration;

		// Token: 0x04003707 RID: 14087
		[Token(Token = "0x4003707")]
		[FieldOffset(Offset = "0x68")]
		public Vector3 offsetForRabbitEffect;

		// Token: 0x04003708 RID: 14088
		[Token(Token = "0x4003708")]
		[FieldOffset(Offset = "0x78")]
		public GameObject ammopackVfx;

		// Token: 0x04003709 RID: 14089
		[Token(Token = "0x4003709")]
		[FieldOffset(Offset = "0x80")]
		public Vector3 ammopackVfxOffset;

		// Token: 0x0400370A RID: 14090
		[Token(Token = "0x400370A")]
		[FieldOffset(Offset = "0x8C")]
		public float ammopackVfxDelay;

		// Token: 0x0400370B RID: 14091
		[Token(Token = "0x400370B")]
		[FieldOffset(Offset = "0x90")]
		public GameObject starVfx;

		// Token: 0x0400370C RID: 14092
		[Token(Token = "0x400370C")]
		[FieldOffset(Offset = "0x98")]
		public Vector3 starVfxOffset;

		// Token: 0x0400370D RID: 14093
		[Token(Token = "0x400370D")]
		[FieldOffset(Offset = "0xA4")]
		public float starVfxDelay;

		// Token: 0x0400370E RID: 14094
		[Token(Token = "0x400370E")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject bulletVfx;

		// Token: 0x0400370F RID: 14095
		[Token(Token = "0x400370F")]
		[FieldOffset(Offset = "0xB0")]
		public Vector3 bulletVfxOffset;

		// Token: 0x04003710 RID: 14096
		[Token(Token = "0x4003710")]
		[FieldOffset(Offset = "0xBC")]
		public float bulletVfxDelay;

		// Token: 0x04003711 RID: 14097
		[Token(Token = "0x4003711")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject boomVfx;

		// Token: 0x04003712 RID: 14098
		[Token(Token = "0x4003712")]
		[FieldOffset(Offset = "0xC8")]
		public Vector3 boomVfxOffset;

		// Token: 0x04003713 RID: 14099
		[Token(Token = "0x4003713")]
		[FieldOffset(Offset = "0xD4")]
		public int angleOffset;

		// Token: 0x04003714 RID: 14100
		[Token(Token = "0x4003714")]
		[FieldOffset(Offset = "0xD8")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip positiveSfxHat;

		// Token: 0x04003715 RID: 14101
		[Token(Token = "0x4003715")]
		[FieldOffset(Offset = "0xE8")]
		public SpellBase.DelayAudioClip positiveSfxRabbit;

		// Token: 0x04003716 RID: 14102
		[Token(Token = "0x4003716")]
		[FieldOffset(Offset = "0xF8")]
		public SpellBase.DelayAudioClip negativeSfxAmmopack;

		// Token: 0x04003717 RID: 14103
		[Token(Token = "0x4003717")]
		[FieldOffset(Offset = "0x108")]
		public SpellBase.DelayAudioClip negativeSfxShoot;

		// Token: 0x04003718 RID: 14104
		[Token(Token = "0x4003718")]
		[FieldOffset(Offset = "0x118")]
		public SpellBase.DelayAudioClip negativeSfxBoom;

		// Token: 0x04003719 RID: 14105
		[Token(Token = "0x4003719")]
		private const int REISEN_PARTNER_ID = 21;

		// Token: 0x0400371A RID: 14106
		[Token(Token = "0x400371A")]
		private const int HIGH_ALCOHOL_ID = 2;
	}
}

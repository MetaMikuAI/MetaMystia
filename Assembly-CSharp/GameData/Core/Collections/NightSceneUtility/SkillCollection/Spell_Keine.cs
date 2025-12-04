using System;
using System.Collections;
using System.Runtime.CompilerServices;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200097F RID: 2431
	[Token(Token = "0x200097F")]
	[CreateAssetMenu(fileName = "Spell_Keine", menuName = "Spells/Keine", order = 0)]
	public class Spell_Keine : SpellBase
	{
		// Token: 0x06003C05 RID: 15365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C05")]
		[Address(RVA = "0x69E6F0", Offset = "0x69D0F0", VA = "0x18069E6F0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003C06 RID: 15366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C06")]
		[Address(RVA = "0x69E720", Offset = "0x69D120", VA = "0x18069E720", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003C07 RID: 15367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C07")]
		[Address(RVA = "0x69E7B0", Offset = "0x69D1B0", VA = "0x18069E7B0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003C08 RID: 15368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003C08")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Keine()
		{
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x000168A8 File Offset: 0x00014AA8
		[Token(Token = "0x6003C09")]
		[Address(RVA = "0x69E870", Offset = "0x69D270", VA = "0x18069E870")]
		[CompilerGenerated]
		internal static Vector3 <OnNegativeBuffExecute>g__GetPlayerHitPos|73_3()
		{
			return default(Vector3);
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C0A")]
		[Address(RVA = "0x69E840", Offset = "0x69D240", VA = "0x18069E840")]
		[CompilerGenerated]
		internal static GameObject <OnNegativeBuffExecute>g__GetGameObject|73_6()
		{
			return null;
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x000168C0 File Offset: 0x00014AC0
		[Token(Token = "0x6003C0B")]
		[Address(RVA = "0x69E8C0", Offset = "0x69D2C0", VA = "0x18069E8C0")]
		[CompilerGenerated]
		internal static int <OnPositiveBuffExecute>g__FindCouldUnlock|74_26(int specGuestId)
		{
			return 0;
		}

		// Token: 0x04003380 RID: 13184
		[Token(Token = "0x4003380")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int stunDuration;

		// Token: 0x04003381 RID: 13185
		[Token(Token = "0x4003381")]
		[FieldOffset(Offset = "0x1C")]
		public int unlockInfoCount;

		// Token: 0x04003382 RID: 13186
		[Token(Token = "0x4003382")]
		[FieldOffset(Offset = "0x20")]
		public int giveVeggiesCount;

		// Token: 0x04003383 RID: 13187
		[Token(Token = "0x4003383")]
		[FieldOffset(Offset = "0x24")]
		public int freeCookDuration;

		// Token: 0x04003384 RID: 13188
		[Token(Token = "0x4003384")]
		[FieldOffset(Offset = "0x28")]
		public int spawnNormalGuestCount;

		// Token: 0x04003385 RID: 13189
		[Token(Token = "0x4003385")]
		[FieldOffset(Offset = "0x2C")]
		public int spawnNormalGuestDuration;

		// Token: 0x04003386 RID: 13190
		[Token(Token = "0x4003386")]
		[FieldOffset(Offset = "0x30")]
		[Header("用于控制三种神器的轮盘,0为随机,1~4分别对应四种效果,1-镜,2-玉,3-乡,4-剑")]
		[Header("Positive")]
		public int testUsetoControlSelection;

		// Token: 0x04003387 RID: 13191
		[Token(Token = "0x4003387")]
		[FieldOffset(Offset = "0x38")]
		public GameObject selectionEffect;

		// Token: 0x04003388 RID: 13192
		[Token(Token = "0x4003388")]
		[FieldOffset(Offset = "0x40")]
		public float selectionObjectStartActivateDelay;

		// Token: 0x04003389 RID: 13193
		[Token(Token = "0x4003389")]
		[FieldOffset(Offset = "0x44")]
		public float selectionObjectActivateOffset;

		// Token: 0x0400338A RID: 13194
		[Token(Token = "0x400338A")]
		[FieldOffset(Offset = "0x48")]
		public float selectionObjectStartSelectionDelay;

		// Token: 0x0400338B RID: 13195
		[Token(Token = "0x400338B")]
		[FieldOffset(Offset = "0x50")]
		public GameObject objectSelectedEffect;

		// Token: 0x0400338C RID: 13196
		[Token(Token = "0x400338C")]
		[FieldOffset(Offset = "0x58")]
		public GameObject objectSelectedTextEffect;

		// Token: 0x0400338D RID: 13197
		[Token(Token = "0x400338D")]
		[FieldOffset(Offset = "0x60")]
		public Sprite[] text;

		// Token: 0x0400338E RID: 13198
		[Token(Token = "0x400338E")]
		[FieldOffset(Offset = "0x68")]
		public float objectSelectedDuration;

		// Token: 0x0400338F RID: 13199
		[Token(Token = "0x400338F")]
		[FieldOffset(Offset = "0x6C")]
		public float objectSelectedTextDuration;

		// Token: 0x04003390 RID: 13200
		[Token(Token = "0x4003390")]
		[FieldOffset(Offset = "0x70")]
		public GameObject objectRemovedEffect;

		// Token: 0x04003391 RID: 13201
		[Token(Token = "0x4003391")]
		[FieldOffset(Offset = "0x78")]
		public float objectRemovedDuration;

		// Token: 0x04003392 RID: 13202
		[Token(Token = "0x4003392")]
		[FieldOffset(Offset = "0x7C")]
		public float selectionObjectEndDelay;

		// Token: 0x04003393 RID: 13203
		[Token(Token = "0x4003393")]
		[FieldOffset(Offset = "0x80")]
		public AudioClip magicFieldExpansionSFX;

		// Token: 0x04003394 RID: 13204
		[Token(Token = "0x4003394")]
		[FieldOffset(Offset = "0x88")]
		public AudioClip objectSelectedSFX;

		// Token: 0x04003395 RID: 13205
		[Token(Token = "0x4003395")]
		[FieldOffset(Offset = "0x90")]
		public float removedSFXOffset;

		// Token: 0x04003396 RID: 13206
		[Token(Token = "0x4003396")]
		[FieldOffset(Offset = "0x98")]
		public AudioClip objectRemovedSFX;

		// Token: 0x04003397 RID: 13207
		[Token(Token = "0x4003397")]
		[FieldOffset(Offset = "0xA0")]
		[Header("Positive-Magatama")]
		public GameObject magatamaEffect;

		// Token: 0x04003398 RID: 13208
		[Token(Token = "0x4003398")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject specialGuestInfo;

		// Token: 0x04003399 RID: 13209
		[Token(Token = "0x4003399")]
		[FieldOffset(Offset = "0xB0")]
		public float magatamaEffectDuration;

		// Token: 0x0400339A RID: 13210
		[Token(Token = "0x400339A")]
		[FieldOffset(Offset = "0xB4")]
		public float timeForInformationToDisappear;

		// Token: 0x0400339B RID: 13211
		[Token(Token = "0x400339B")]
		[FieldOffset(Offset = "0xB8")]
		public AudioClip chainSFX;

		// Token: 0x0400339C RID: 13212
		[Token(Token = "0x400339C")]
		[FieldOffset(Offset = "0xC0")]
		public AudioClip chainBreakSFX;

		// Token: 0x0400339D RID: 13213
		[Token(Token = "0x400339D")]
		[FieldOffset(Offset = "0xC8")]
		public AudioClip aquireSFX;

		// Token: 0x0400339E RID: 13214
		[Token(Token = "0x400339E")]
		[FieldOffset(Offset = "0xD0")]
		[Header("Positive-Sword")]
		public GameObject swordEffect;

		// Token: 0x0400339F RID: 13215
		[Token(Token = "0x400339F")]
		[FieldOffset(Offset = "0xD8")]
		public float swordEffectDuration;

		// Token: 0x040033A0 RID: 13216
		[Token(Token = "0x40033A0")]
		[FieldOffset(Offset = "0xDC")]
		public float swordEffectSpriteSwapOffset;

		// Token: 0x040033A1 RID: 13217
		[Token(Token = "0x40033A1")]
		[FieldOffset(Offset = "0xE0")]
		public AudioClip swordSFX;

		// Token: 0x040033A2 RID: 13218
		[Token(Token = "0x40033A2")]
		[FieldOffset(Offset = "0xE8")]
		public AudioClip swordTransformSFX;

		// Token: 0x040033A3 RID: 13219
		[Token(Token = "0x40033A3")]
		[FieldOffset(Offset = "0xF0")]
		public AudioClip itemGainSFX;

		// Token: 0x040033A4 RID: 13220
		[Token(Token = "0x40033A4")]
		[FieldOffset(Offset = "0xF8")]
		[Header("Positive-Mirror")]
		public GameObject mirrorEffect;

		// Token: 0x040033A5 RID: 13221
		[Token(Token = "0x40033A5")]
		[FieldOffset(Offset = "0x100")]
		public float mirrorStartWarmDownOffset;

		// Token: 0x040033A6 RID: 13222
		[Token(Token = "0x40033A6")]
		[FieldOffset(Offset = "0x104")]
		public float mirrorWarmDownDuration;

		// Token: 0x040033A7 RID: 13223
		[Token(Token = "0x40033A7")]
		[FieldOffset(Offset = "0x108")]
		public AudioClip mirrorSFX;

		// Token: 0x040033A8 RID: 13224
		[Token(Token = "0x40033A8")]
		[FieldOffset(Offset = "0x110")]
		[Header("Positive-Village")]
		public GameObject villageEffect;

		// Token: 0x040033A9 RID: 13225
		[Token(Token = "0x40033A9")]
		[FieldOffset(Offset = "0x118")]
		public float villageDuration;

		// Token: 0x040033AA RID: 13226
		[Token(Token = "0x40033AA")]
		[FieldOffset(Offset = "0x11C")]
		public float villageCameraShakeAmplitude;

		// Token: 0x040033AB RID: 13227
		[Token(Token = "0x40033AB")]
		[FieldOffset(Offset = "0x120")]
		public float villageCameraShakeDuration;

		// Token: 0x040033AC RID: 13228
		[Token(Token = "0x40033AC")]
		[FieldOffset(Offset = "0x124")]
		public float villageCameraShakeFadeDuration;

		// Token: 0x040033AD RID: 13229
		[Token(Token = "0x40033AD")]
		[FieldOffset(Offset = "0x128")]
		public float bookSFXDelay;

		// Token: 0x040033AE RID: 13230
		[Token(Token = "0x40033AE")]
		[FieldOffset(Offset = "0x130")]
		public AudioClip bookSFX;

		// Token: 0x040033AF RID: 13231
		[Token(Token = "0x40033AF")]
		[FieldOffset(Offset = "0x138")]
		public float itemGetSFXDelay;

		// Token: 0x040033B0 RID: 13232
		[Token(Token = "0x40033B0")]
		[FieldOffset(Offset = "0x140")]
		public AudioClip itemGetSFX;

		// Token: 0x040033B1 RID: 13233
		[Token(Token = "0x40033B1")]
		[FieldOffset(Offset = "0x148")]
		[Header("Negative")]
		public GameObject eyeEffect;

		// Token: 0x040033B2 RID: 13234
		[Token(Token = "0x40033B2")]
		[FieldOffset(Offset = "0x150")]
		public float eyeEffectDuration;

		// Token: 0x040033B3 RID: 13235
		[Token(Token = "0x40033B3")]
		[FieldOffset(Offset = "0x158")]
		public GameObject jumpEffect;

		// Token: 0x040033B4 RID: 13236
		[Token(Token = "0x40033B4")]
		[FieldOffset(Offset = "0x160")]
		public float jumpEffectDuration;

		// Token: 0x040033B5 RID: 13237
		[Token(Token = "0x40033B5")]
		[FieldOffset(Offset = "0x164")]
		public float jumpEffectShakeAmplitude;

		// Token: 0x040033B6 RID: 13238
		[Token(Token = "0x40033B6")]
		[FieldOffset(Offset = "0x168")]
		public float jumpEffectShakeFadeDuration;

		// Token: 0x040033B7 RID: 13239
		[Token(Token = "0x40033B7")]
		[FieldOffset(Offset = "0x16C")]
		public float characterJumpToWorldHeight;

		// Token: 0x040033B8 RID: 13240
		[Token(Token = "0x40033B8")]
		[FieldOffset(Offset = "0x170")]
		public float characterJumpDuration;

		// Token: 0x040033B9 RID: 13241
		[Token(Token = "0x40033B9")]
		[FieldOffset(Offset = "0x174")]
		public float characterTurnDuration;

		// Token: 0x040033BA RID: 13242
		[Token(Token = "0x40033BA")]
		[FieldOffset(Offset = "0x178")]
		public GameObject nuclearEffect;

		// Token: 0x040033BB RID: 13243
		[Token(Token = "0x40033BB")]
		[FieldOffset(Offset = "0x180")]
		public float nuclearEffectDuration;

		// Token: 0x040033BC RID: 13244
		[Token(Token = "0x40033BC")]
		[FieldOffset(Offset = "0x184")]
		public float nuclearEffectShakeAmplitude;

		// Token: 0x040033BD RID: 13245
		[Token(Token = "0x40033BD")]
		[FieldOffset(Offset = "0x188")]
		public float nuclearEffectShakeDuration;

		// Token: 0x040033BE RID: 13246
		[Token(Token = "0x40033BE")]
		[FieldOffset(Offset = "0x18C")]
		public float nuclearEffectShakeFadeDuration;

		// Token: 0x040033BF RID: 13247
		[Token(Token = "0x40033BF")]
		[FieldOffset(Offset = "0x190")]
		public GameObject stunEffect;

		// Token: 0x040033C0 RID: 13248
		[Token(Token = "0x40033C0")]
		[FieldOffset(Offset = "0x198")]
		public float afterJumpHeight;

		// Token: 0x040033C1 RID: 13249
		[Token(Token = "0x40033C1")]
		[FieldOffset(Offset = "0x19C")]
		public float afterJumpSpeed;

		// Token: 0x040033C2 RID: 13250
		[Token(Token = "0x40033C2")]
		[FieldOffset(Offset = "0x1A0")]
		public float afterJumpRotationSpeed;

		// Token: 0x040033C3 RID: 13251
		[Token(Token = "0x40033C3")]
		[FieldOffset(Offset = "0x1A8")]
		public Sprite specialFace;

		// Token: 0x040033C4 RID: 13252
		[Token(Token = "0x40033C4")]
		[FieldOffset(Offset = "0x1B0")]
		public LoopedBGMPackage warningSFX;

		// Token: 0x040033C5 RID: 13253
		[Token(Token = "0x40033C5")]
		[FieldOffset(Offset = "0x1B8")]
		public AudioClip launchSFX;

		// Token: 0x040033C6 RID: 13254
		[Token(Token = "0x40033C6")]
		[FieldOffset(Offset = "0x1C0")]
		public LoopedBGMPackage inAirSFX;

		// Token: 0x040033C7 RID: 13255
		[Token(Token = "0x40033C7")]
		[FieldOffset(Offset = "0x1C8")]
		public AudioClip impactSFX;
	}
}

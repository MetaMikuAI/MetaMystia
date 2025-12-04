using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200099C RID: 2460
	[Token(Token = "0x200099C")]
	[CreateAssetMenu(fileName = "DLC5_Spell_Luize", menuName = "Spells/DLC5/Luize", order = 2)]
	public class Spell_Luize : SpellBase
	{
		// Token: 0x06003CA7 RID: 15527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CA7")]
		[Address(RVA = "0x6B1880", Offset = "0x6B0280", VA = "0x1806B1880", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003CA8 RID: 15528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CA8")]
		[Address(RVA = "0x6B1930", Offset = "0x6B0330", VA = "0x1806B1930", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003CA9 RID: 15529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CA9")]
		[Address(RVA = "0x6B1790", Offset = "0x6B0190", VA = "0x1806B1790")]
		private void CheckLeave(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x06003CAA RID: 15530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CAA")]
		[Address(RVA = "0x6B19B0", Offset = "0x6B03B0", VA = "0x1806B19B0")]
		private void TryRecordGuest(GuestGroupController guestsController)
		{
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CAB")]
		[Address(RVA = "0x6B18B0", Offset = "0x6B02B0", VA = "0x1806B18B0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CAC")]
		[Address(RVA = "0x6B2170", Offset = "0x6B0B70", VA = "0x1806B2170")]
		public Spell_Luize()
		{
		}

		// Token: 0x06003CB1 RID: 15537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CB1")]
		[Address(RVA = "0x6B1E20", Offset = "0x6B0820", VA = "0x1806B1E20")]
		[CompilerGenerated]
		private void <OnNegativeBuffExecute>g__OnNightEnd|23_0()
		{
		}

		// Token: 0x04003447 RID: 13383
		[Token(Token = "0x4003447")]
		[FieldOffset(Offset = "0x18")]
		public int timeForWaitToEnd;

		// Token: 0x04003448 RID: 13384
		[Token(Token = "0x4003448")]
		[FieldOffset(Offset = "0x20")]
		[Header("Vfx")]
		public GameObject luizeShoe;

		// Token: 0x04003449 RID: 13385
		[Token(Token = "0x4003449")]
		[FieldOffset(Offset = "0x28")]
		public float luizeShoeDuration;

		// Token: 0x0400344A RID: 13386
		[Token(Token = "0x400344A")]
		[FieldOffset(Offset = "0x30")]
		public GameObject cameraSpawnVfx;

		// Token: 0x0400344B RID: 13387
		[Token(Token = "0x400344B")]
		[FieldOffset(Offset = "0x38")]
		public GameObject cameraVfx;

		// Token: 0x0400344C RID: 13388
		[Token(Token = "0x400344C")]
		[FieldOffset(Offset = "0x40")]
		public float photoDelay;

		// Token: 0x0400344D RID: 13389
		[Token(Token = "0x400344D")]
		[FieldOffset(Offset = "0x48")]
		public GameObject photoVfx;

		// Token: 0x0400344E RID: 13390
		[Token(Token = "0x400344E")]
		[FieldOffset(Offset = "0x50")]
		public GameObject photoVfx_2;

		// Token: 0x0400344F RID: 13391
		[Token(Token = "0x400344F")]
		[FieldOffset(Offset = "0x58")]
		public float photoLeaveDelay;

		// Token: 0x04003450 RID: 13392
		[Token(Token = "0x4003450")]
		[FieldOffset(Offset = "0x5C")]
		public float photoReleaseDelay;

		// Token: 0x04003451 RID: 13393
		[Token(Token = "0x4003451")]
		[FieldOffset(Offset = "0x60")]
		public float photoSpace;

		// Token: 0x04003452 RID: 13394
		[Token(Token = "0x4003452")]
		[FieldOffset(Offset = "0x64")]
		public Vector3 photoOffset;

		// Token: 0x04003453 RID: 13395
		[Token(Token = "0x4003453")]
		[FieldOffset(Offset = "0x70")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip positiveSfxCamera;

		// Token: 0x04003454 RID: 13396
		[Token(Token = "0x4003454")]
		[FieldOffset(Offset = "0x80")]
		public SpellBase.DelayAudioClip positiveSfxShot;

		// Token: 0x04003455 RID: 13397
		[Token(Token = "0x4003455")]
		[FieldOffset(Offset = "0x90")]
		public SpellBase.DelayAudioClip positiveSfxInstantiate;

		// Token: 0x04003456 RID: 13398
		[Token(Token = "0x4003456")]
		[FieldOffset(Offset = "0xA0")]
		public SpellBase.DelayAudioClip positiveSfxEnd;

		// Token: 0x04003457 RID: 13399
		[Token(Token = "0x4003457")]
		[FieldOffset(Offset = "0xB0")]
		public SpellBase.DelayAudioClip negativeSfxClock;

		// Token: 0x04003458 RID: 13400
		[Token(Token = "0x4003458")]
		[FieldOffset(Offset = "0xC0")]
		public SpellBase.DelayAudioClip negativeSfxGlassBroken;

		// Token: 0x04003459 RID: 13401
		[Token(Token = "0x4003459")]
		private const string LUIZE_PHOTO_RELEASE = "Luize_Photo_Release";
	}
}

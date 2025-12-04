using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x020009DC RID: 2524
	[Token(Token = "0x20009DC")]
	[CreateAssetMenu(fileName = "Spell_Narumi", menuName = "Spells/Narumi", order = 42)]
	public class Spell_Narumi : SpellBase
	{
		// Token: 0x06003DEE RID: 15854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DEE")]
		[Address(RVA = "0x6B3BA0", Offset = "0x6B25A0", VA = "0x1806B3BA0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003DEF RID: 15855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DEF")]
		[Address(RVA = "0x6B3BD0", Offset = "0x6B25D0", VA = "0x1806B3BD0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DF0")]
		[Address(RVA = "0x6B3C60", Offset = "0x6B2660", VA = "0x1806B3C60", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DF1")]
		[Address(RVA = "0x6B3D50", Offset = "0x6B2750", VA = "0x1806B3D50")]
		public Spell_Narumi()
		{
		}

		// Token: 0x040035C6 RID: 13766
		[Token(Token = "0x40035C6")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public float extraFeeRate;

		// Token: 0x040035C7 RID: 13767
		[Token(Token = "0x40035C7")]
		[FieldOffset(Offset = "0x1C")]
		public float positiveDuration;

		// Token: 0x040035C8 RID: 13768
		[Token(Token = "0x40035C8")]
		[FieldOffset(Offset = "0x20")]
		public int clearBuffNum;

		// Token: 0x040035C9 RID: 13769
		[Token(Token = "0x40035C9")]
		[FieldOffset(Offset = "0x28")]
		[Header("Effects")]
		public GameObject rewardObject;

		// Token: 0x040035CA RID: 13770
		[Token(Token = "0x40035CA")]
		[FieldOffset(Offset = "0x30")]
		public float rewardDuration;

		// Token: 0x040035CB RID: 13771
		[Token(Token = "0x40035CB")]
		[FieldOffset(Offset = "0x34")]
		public float effectDuration;

		// Token: 0x040035CC RID: 13772
		[Token(Token = "0x40035CC")]
		[FieldOffset(Offset = "0x38")]
		public AudioClip rewardSFX;

		// Token: 0x040035CD RID: 13773
		[Token(Token = "0x40035CD")]
		[FieldOffset(Offset = "0x40")]
		public GameObject fireBulletObject;

		// Token: 0x040035CE RID: 13774
		[Token(Token = "0x40035CE")]
		[FieldOffset(Offset = "0x48")]
		public float bulletDuration;

		// Token: 0x040035CF RID: 13775
		[Token(Token = "0x40035CF")]
		[FieldOffset(Offset = "0x4C")]
		public float bulletDelay;

		// Token: 0x040035D0 RID: 13776
		[Token(Token = "0x40035D0")]
		[FieldOffset(Offset = "0x50")]
		public float bulletFlyTime;

		// Token: 0x040035D1 RID: 13777
		[Token(Token = "0x40035D1")]
		[FieldOffset(Offset = "0x54")]
		public float magicSphereLaunchSpeed;

		// Token: 0x040035D2 RID: 13778
		[Token(Token = "0x40035D2")]
		[FieldOffset(Offset = "0x58")]
		public float magicSphereMaxAnglerSpeed;

		// Token: 0x040035D3 RID: 13779
		[Token(Token = "0x40035D3")]
		[FieldOffset(Offset = "0x5C")]
		public float magicSphereMinAnglerSpeed;

		// Token: 0x040035D4 RID: 13780
		[Token(Token = "0x40035D4")]
		[FieldOffset(Offset = "0x60")]
		public GameObject finalFireObject;

		// Token: 0x040035D5 RID: 13781
		[Token(Token = "0x40035D5")]
		[FieldOffset(Offset = "0x68")]
		public float fireDuration;

		// Token: 0x040035D6 RID: 13782
		[Token(Token = "0x40035D6")]
		[FieldOffset(Offset = "0x70")]
		public AudioClip punishmentSFX;
	}
}

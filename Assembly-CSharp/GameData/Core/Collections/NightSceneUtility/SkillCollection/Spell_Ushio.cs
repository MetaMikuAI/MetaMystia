using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A95 RID: 2709
	[Token(Token = "0x2000A95")]
	[CreateAssetMenu(fileName = "Spell_Ushio", menuName = "Spells/Ushio", order = 36)]
	public class Spell_Ushio : SpellBase
	{
		// Token: 0x0600418A RID: 16778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418A")]
		[Address(RVA = "0x6FD7C0", Offset = "0x6FC1C0", VA = "0x1806FD7C0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x0600418B RID: 16779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418B")]
		[Address(RVA = "0x6FD8D0", Offset = "0x6FC2D0", VA = "0x1806FD8D0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x0600418C RID: 16780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600418C")]
		[Address(RVA = "0x6FD950", Offset = "0x6FC350", VA = "0x1806FD950", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x0600418D RID: 16781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600418D")]
		[Address(RVA = "0x6FD7F0", Offset = "0x6FC1F0", VA = "0x1806FD7F0")]
		private void OnGuestSpawn(GuestGroupController guestGroup)
		{
		}

		// Token: 0x0600418E RID: 16782 RVA: 0x00017E08 File Offset: 0x00016008
		[Token(Token = "0x600418E")]
		[Address(RVA = "0x6FDF60", Offset = "0x6FC960", VA = "0x1806FDF60")]
		private float UshioSpecialOrderProbabilityCheck(GuestGroupController toOverride, float lastProbability)
		{
			return 0f;
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600418F")]
		[Address(RVA = "0x6FD4D0", Offset = "0x6FBED0", VA = "0x1806FD4D0")]
		private void OnBuffEnd()
		{
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004190")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Ushio()
		{
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004191")]
		[Address(RVA = "0x6FD9D0", Offset = "0x6FC3D0", VA = "0x1806FD9D0")]
		[CompilerGenerated]
		private string <OnNegativeBuffExecute>g__OnGettingCurrentBuffContext|6_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004192")]
		[Address(RVA = "0x6FDE80", Offset = "0x6FC880", VA = "0x1806FDE80")]
		[CompilerGenerated]
		private string <OnPositiveBuffExecute>g__OnGettingCurrentBuffContext|7_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x040039A7 RID: 14759
		[Token(Token = "0x40039A7")]
		[FieldOffset(Offset = "0x18")]
		[Header("value")]
		public int negativeDuration;

		// Token: 0x040039A8 RID: 14760
		[Token(Token = "0x40039A8")]
		[FieldOffset(Offset = "0x20")]
		public int[] negativeTags;

		// Token: 0x040039A9 RID: 14761
		[Token(Token = "0x40039A9")]
		[FieldOffset(Offset = "0x28")]
		public float negativeRate;

		// Token: 0x040039AA RID: 14762
		[Token(Token = "0x40039AA")]
		[FieldOffset(Offset = "0x2C")]
		public int positiveDuration;

		// Token: 0x040039AB RID: 14763
		[Token(Token = "0x40039AB")]
		[FieldOffset(Offset = "0x30")]
		public float leastOrderCost;
	}
}

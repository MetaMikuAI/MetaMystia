using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using NightScene.UI.EventUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000AC3 RID: 2755
	[Token(Token = "0x2000AC3")]
	[CreateAssetMenu(fileName = "Spell_Yuu", menuName = "Spells/Yuu", order = 37)]
	public class Spell_Yuu : SpellBase
	{
		// Token: 0x0600427F RID: 17023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600427F")]
		[Address(RVA = "0x6FF010", Offset = "0x6FDA10", VA = "0x1806FF010", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004280")]
		[Address(RVA = "0x6FF040", Offset = "0x6FDA40", VA = "0x1806FF040", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004281")]
		[Address(RVA = "0x6FF0C0", Offset = "0x6FDAC0", VA = "0x1806FF0C0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004282")]
		[Address(RVA = "0x6FEDD0", Offset = "0x6FD7D0", VA = "0x1806FEDD0")]
		private GameObject GetEffectDisplayer(GuestGroupController guestGroup, out bool successNewSpawn)
		{
			return null;
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004283")]
		[Address(RVA = "0x6FF150", Offset = "0x6FDB50", VA = "0x1806FF150")]
		private void SetNum(GuestGroupController guestGroupController, GameObject targetDisplayer)
		{
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004284")]
		[Address(RVA = "0x6FF350", Offset = "0x6FDD50", VA = "0x1806FF350")]
		public Spell_Yuu()
		{
		}

		// Token: 0x06004285 RID: 17029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004285")]
		[Address(RVA = "0x6FF2F0", Offset = "0x6FDCF0", VA = "0x1806FF2F0")]
		[CompilerGenerated]
		internal static string <OnPositiveBuffExecute>g__OnGettingCurrentBuffContext|8_3(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x04003A8A RID: 14986
		[Token(Token = "0x4003A8A")]
		private const GuestBuffMarkModule.GuestBuffMark YUU_BUFF_MARK = GuestBuffMarkModule.GuestBuffMark.BuffMark_JienYuuEye;

		// Token: 0x04003A8B RID: 14987
		[Token(Token = "0x4003A8B")]
		[FieldOffset(Offset = "0x18")]
		[Header("Effect")]
		public GameObject displayUI;

		// Token: 0x04003A8C RID: 14988
		[Token(Token = "0x4003A8C")]
		[FieldOffset(Offset = "0x20")]
		[Header("value")]
		public int negativeDuration;

		// Token: 0x04003A8D RID: 14989
		[Token(Token = "0x4003A8D")]
		[FieldOffset(Offset = "0x24")]
		public int positiveDuration;

		// Token: 0x04003A8E RID: 14990
		[Token(Token = "0x4003A8E")]
		[FieldOffset(Offset = "0x28")]
		public int UIFieldIndex;

		// Token: 0x04003A8F RID: 14991
		[Token(Token = "0x4003A8F")]
		[FieldOffset(Offset = "0x2C")]
		public float UIOffset;
	}
}

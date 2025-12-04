using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A73 RID: 2675
	[Token(Token = "0x2000A73")]
	[CreateAssetMenu(fileName = "Spell_Tewi_SharedData", menuName = "Spells/Tewi_SharedData", order = 29)]
	public class Spell_Tewi_SharedData : ScriptableObject
	{
		// Token: 0x060040F2 RID: 16626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040F2")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public Spell_Tewi_SharedData()
		{
		}

		// Token: 0x04003904 RID: 14596
		[Token(Token = "0x4003904")]
		[FieldOffset(Offset = "0x18")]
		[Header("value")]
		public int noComboDuration;

		// Token: 0x04003905 RID: 14597
		[Token(Token = "0x4003905")]
		[FieldOffset(Offset = "0x20")]
		public GameObject tewiHardSellParent;

		// Token: 0x04003906 RID: 14598
		[Token(Token = "0x4003906")]
		[FieldOffset(Offset = "0x28")]
		public Vector2Int rumiaSellProductAmountRange;

		// Token: 0x04003907 RID: 14599
		[Token(Token = "0x4003907")]
		[FieldOffset(Offset = "0x30")]
		public Vector2Int rumiaSellProductPriceMultiplierRange;

		// Token: 0x04003908 RID: 14600
		[Token(Token = "0x4003908")]
		[FieldOffset(Offset = "0x38")]
		public DialogPackage[] onLeaveDialog;

		// Token: 0x04003909 RID: 14601
		[Token(Token = "0x4003909")]
		[FieldOffset(Offset = "0x40")]
		public DialogPackage[] onLeaveHardSellDialog;

		// Token: 0x0400390A RID: 14602
		[Token(Token = "0x400390A")]
		[FieldOffset(Offset = "0x48")]
		public DialogPackage[] onPurchaseDialog;

		// Token: 0x0400390B RID: 14603
		[Token(Token = "0x400390B")]
		[FieldOffset(Offset = "0x50")]
		public DialogPackage[] onNonPurchaseDialog;

		// Token: 0x0400390C RID: 14604
		[Token(Token = "0x400390C")]
		[FieldOffset(Offset = "0x58")]
		public DialogPackage[] onCheatDialog;

		// Token: 0x0400390D RID: 14605
		[Token(Token = "0x400390D")]
		[FieldOffset(Offset = "0x60")]
		public int giveItemId;

		// Token: 0x0400390E RID: 14606
		[Token(Token = "0x400390E")]
		[FieldOffset(Offset = "0x68")]
		[Header("effect")]
		public AudioClip luckySFX;

		// Token: 0x0400390F RID: 14607
		[Token(Token = "0x400390F")]
		[FieldOffset(Offset = "0x70")]
		public GameObject luckyEffect;

		// Token: 0x04003910 RID: 14608
		[Token(Token = "0x4003910")]
		[FieldOffset(Offset = "0x78")]
		public float positiveEffectDuration;

		// Token: 0x04003911 RID: 14609
		[Token(Token = "0x4003911")]
		[FieldOffset(Offset = "0x80")]
		public GameObject comboDestroyEffect;

		// Token: 0x04003912 RID: 14610
		[Token(Token = "0x4003912")]
		[FieldOffset(Offset = "0x88")]
		public float negativeEffectDuration;

		// Token: 0x04003913 RID: 14611
		[Token(Token = "0x4003913")]
		[FieldOffset(Offset = "0x90")]
		public AudioClip negativeSFXA;

		// Token: 0x04003914 RID: 14612
		[Token(Token = "0x4003914")]
		[FieldOffset(Offset = "0x98")]
		public AudioClip negativeSFXB;

		// Token: 0x04003915 RID: 14613
		[Token(Token = "0x4003915")]
		[FieldOffset(Offset = "0xA0")]
		public float negativeSFXDelay;
	}
}

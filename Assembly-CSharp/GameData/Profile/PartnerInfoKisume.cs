using System;
using System.Text;
using Il2CppDummyDll;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CD1 RID: 3281
	[Token(Token = "0x2000CD1")]
	[CreateAssetMenu(fileName = "DLC2_PartnerInfo_Kisume(Test)", menuName = "GameData Profile/PartnerInfoCollection/DLC2_PartnerInfoKisume(Test)", order = 9)]
	public sealed class PartnerInfoKisume : PartnerInfo
	{
		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06004C50 RID: 19536 RVA: 0x0001BA38 File Offset: 0x00019C38
		[Token(Token = "0x17000B0B")]
		public override bool IfNeverWork
		{
			[Token(Token = "0x6004C50")]
			[Address(RVA = "0x79E590", Offset = "0x79CF90", VA = "0x18079E590", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004C51 RID: 19537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C51")]
		[Address(RVA = "0x79E4D0", Offset = "0x79CED0", VA = "0x18079E4D0", Slot = "16")]
		protected override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, object[] additionalData)
		{
		}

		// Token: 0x06004C52 RID: 19538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C52")]
		[Address(RVA = "0x79E540", Offset = "0x79CF40", VA = "0x18079E540", Slot = "22")]
		protected override void PostProcessInfo(StringBuilder builder)
		{
		}

		// Token: 0x06004C53 RID: 19539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C53")]
		[Address(RVA = "0x79E580", Offset = "0x79CF80", VA = "0x18079E580")]
		public PartnerInfoKisume()
		{
		}

		// Token: 0x0400463F RID: 17983
		[Token(Token = "0x400463F")]
		[FieldOffset(Offset = "0x58")]
		public bool neverWork;

		// Token: 0x04004640 RID: 17984
		[Token(Token = "0x4004640")]
		[FieldOffset(Offset = "0x60")]
		public PartnerInfoKisume.KisumeEffect kisumeEffect;

		// Token: 0x02000CD2 RID: 3282
		[Token(Token = "0x2000CD2")]
		[Serializable]
		public struct KisumeEffect
		{
			// Token: 0x04004641 RID: 17985
			[Token(Token = "0x4004641")]
			[FieldOffset(Offset = "0x0")]
			public float jumpEffectShakeAmplitude;

			// Token: 0x04004642 RID: 17986
			[Token(Token = "0x4004642")]
			[FieldOffset(Offset = "0x4")]
			public float jumpEffectShakeFadeDuration;

			// Token: 0x04004643 RID: 17987
			[Token(Token = "0x4004643")]
			[FieldOffset(Offset = "0x8")]
			public float mudamudamudaShakeAmplitude;

			// Token: 0x04004644 RID: 17988
			[Token(Token = "0x4004644")]
			[FieldOffset(Offset = "0xC")]
			public float mudamudamudaDuration;

			// Token: 0x04004645 RID: 17989
			[Token(Token = "0x4004645")]
			[FieldOffset(Offset = "0x10")]
			public GameObject jumpEffect;

			// Token: 0x04004646 RID: 17990
			[Token(Token = "0x4004646")]
			[FieldOffset(Offset = "0x18")]
			public float jumpEffectDuration;

			// Token: 0x04004647 RID: 17991
			[Token(Token = "0x4004647")]
			[FieldOffset(Offset = "0x20")]
			public GameObject dropEffect;

			// Token: 0x04004648 RID: 17992
			[Token(Token = "0x4004648")]
			[FieldOffset(Offset = "0x28")]
			public GameObject mudamudamudaEffect;

			// Token: 0x04004649 RID: 17993
			[Token(Token = "0x4004649")]
			[FieldOffset(Offset = "0x30")]
			public GameObject exclamationMarkEffect;
		}
	}
}

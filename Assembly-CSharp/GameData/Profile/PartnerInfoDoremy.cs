using System;
using System.Runtime.CompilerServices;
using System.Text;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CCD RID: 3277
	[Token(Token = "0x2000CCD")]
	[CreateAssetMenu(fileName = "DLC5_PartnerInfo_Doremy", menuName = "GameData Profile/PartnerInfoCollection/DLC5_PartnerInfoDoremy", order = 5000)]
	public class PartnerInfoDoremy : PartnerInfo
	{
		// Token: 0x06004C41 RID: 19521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C41")]
		[Address(RVA = "0x79DED0", Offset = "0x79C8D0", VA = "0x18079DED0", Slot = "22")]
		protected override void PostProcessInfo(StringBuilder builder)
		{
		}

		// Token: 0x06004C42 RID: 19522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C42")]
		[Address(RVA = "0x79DE00", Offset = "0x79C800", VA = "0x18079DE00", Slot = "16")]
		protected override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, object[] additionalData)
		{
		}

		// Token: 0x06004C43 RID: 19523 RVA: 0x0001B9F0 File Offset: 0x00019BF0
		[Token(Token = "0x6004C43")]
		[Address(RVA = "0x79D9B0", Offset = "0x79C3B0", VA = "0x18079D9B0")]
		private GuestGroupController.EvaluationResult GiveDreamShards(GuestGroupController.EvaluationResult result, GuestGroupController guestGroupController, bool oldComboProtect, out string newMessage, out bool comboProtect)
		{
			return GuestGroupController.EvaluationResult.Exbad;
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x0001BA08 File Offset: 0x00019C08
		[Token(Token = "0x6004C44")]
		[Address(RVA = "0x79DCC0", Offset = "0x79C6C0", VA = "0x18079DCC0", Slot = "11")]
		public override float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseTime, ref bool doNotCostIngredients)
		{
			return 0f;
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C45")]
		[Address(RVA = "0x79DFF0", Offset = "0x79C9F0", VA = "0x18079DFF0")]
		public PartnerInfoDoremy()
		{
		}

		// Token: 0x06004C46 RID: 19526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C46")]
		[Address(RVA = "0x79DF10", Offset = "0x79C910", VA = "0x18079DF10")]
		[CompilerGenerated]
		private void <OnPartnerLoad>g__OnGuestSpawn|9_0(GuestGroupController guestGroup)
		{
		}

		// Token: 0x0400462E RID: 17966
		[Token(Token = "0x400462E")]
		[FieldOffset(Offset = "0x58")]
		public float eachShallowDreamShardsDecreaseCookTime;

		// Token: 0x0400462F RID: 17967
		[Token(Token = "0x400462F")]
		[FieldOffset(Offset = "0x5C")]
		public float eachShallowDreamShardsDecreaseCookTimeAfterSpring;

		// Token: 0x04004630 RID: 17968
		[Token(Token = "0x4004630")]
		[FieldOffset(Offset = "0x60")]
		public int maxShallowDreamShardsNum;

		// Token: 0x04004631 RID: 17969
		[Token(Token = "0x4004631")]
		[FieldOffset(Offset = "0x64")]
		public int maxShallowDreamShardsNumAfterSpring;

		// Token: 0x04004632 RID: 17970
		[Token(Token = "0x4004632")]
		[FieldOffset(Offset = "0x68")]
		public float eachPhantomDreamShardsExtraReturnIngRate;

		// Token: 0x04004633 RID: 17971
		[Token(Token = "0x4004633")]
		[FieldOffset(Offset = "0x6C")]
		public float eachPhantomDreamShardsExtraReturnIngRateAfterSpring;

		// Token: 0x04004634 RID: 17972
		[Token(Token = "0x4004634")]
		[FieldOffset(Offset = "0x70")]
		public int maxPhantomDreamShardsNum;

		// Token: 0x04004635 RID: 17973
		[Token(Token = "0x4004635")]
		[FieldOffset(Offset = "0x74")]
		public int maxPhantomDreamShardsNumAfterSpring;
	}
}

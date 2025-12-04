using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CEB RID: 3307
	[Token(Token = "0x2000CEB")]
	[CreateAssetMenu(fileName = "DLC1_PartnerInfo_Yumeko", menuName = "GameData Profile/PartnerInfoCollection/DLC1_PartnerInfoYumeko", order = 7)]
	public sealed class PartnerInfoYumeko : PartnerInfo
	{
		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06004CBE RID: 19646 RVA: 0x0001BBB8 File Offset: 0x00019DB8
		[Token(Token = "0x17000B19")]
		public override PartnerInfoBase.DeliverType PartnerDeliverType
		{
			[Token(Token = "0x6004CBE")]
			[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "9")]
			get
			{
				return PartnerInfoBase.DeliverType.Normal;
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06004CBF RID: 19647 RVA: 0x0001BBD0 File Offset: 0x00019DD0
		[Token(Token = "0x17000B1A")]
		protected override int AdditionalDataRequirement
		{
			[Token(Token = "0x6004CBF")]
			[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004CC0 RID: 19648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC0")]
		[Address(RVA = "0x79FDE0", Offset = "0x79E7E0", VA = "0x18079FDE0", Slot = "16")]
		protected override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, object[] additionalData)
		{
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC1")]
		[Address(RVA = "0x79FEE0", Offset = "0x79E8E0", VA = "0x18079FEE0", Slot = "22")]
		protected override void PostProcessInfo(StringBuilder builder)
		{
		}

		// Token: 0x06004CC2 RID: 19650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC2")]
		[Address(RVA = "0x79FF20", Offset = "0x79E920", VA = "0x18079FF20")]
		private static IEnumerator SpecialLerpParabolic(Transform source, Func<Vector3> targetPosition, float launchHeight, float launchSpeed)
		{
			return null;
		}

		// Token: 0x06004CC3 RID: 19651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CC3")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public PartnerInfoYumeko()
		{
		}

		// Token: 0x06004CC4 RID: 19652 RVA: 0x0001BBE8 File Offset: 0x00019DE8
		[Token(Token = "0x6004CC4")]
		[Address(RVA = "0x40BF20", Offset = "0x40A920", VA = "0x18040BF20")]
		[CompilerGenerated]
		internal static float <SpecialLerpParabolic>g__GetDistance|11_0(ref PartnerInfoYumeko.<>c__DisplayClass11_0 A_0)
		{
			return 0f;
		}

		// Token: 0x06004CC5 RID: 19653 RVA: 0x0001BC00 File Offset: 0x00019E00
		[Token(Token = "0x6004CC5")]
		[Address(RVA = "0x40BD10", Offset = "0x40A710", VA = "0x18040BD10")]
		[CompilerGenerated]
		internal static Vector3 <SpecialLerpParabolic>g__GetControl|11_1(ref PartnerInfoYumeko.<>c__DisplayClass11_0 A_0)
		{
			return default(Vector3);
		}

		// Token: 0x040046AA RID: 18090
		[Token(Token = "0x40046AA")]
		[FieldOffset(Offset = "0x58")]
		public GameObject throwFood;

		// Token: 0x040046AB RID: 18091
		[Token(Token = "0x40046AB")]
		[FieldOffset(Offset = "0x60")]
		public AudioClip throwSFX;

		// Token: 0x040046AC RID: 18092
		[Token(Token = "0x40046AC")]
		[FieldOffset(Offset = "0x68")]
		public float throwDuration;

		// Token: 0x040046AD RID: 18093
		[Token(Token = "0x40046AD")]
		[FieldOffset(Offset = "0x6C")]
		public float launchSpeed;

		// Token: 0x040046AE RID: 18094
		[Token(Token = "0x40046AE")]
		[FieldOffset(Offset = "0x70")]
		public float launchHeight;
	}
}

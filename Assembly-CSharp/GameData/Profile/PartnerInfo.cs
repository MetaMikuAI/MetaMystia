using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CC1 RID: 3265
	[Token(Token = "0x2000CC1")]
	[CreateAssetMenu(fileName = "PartnerInfoGeneral", menuName = "GameData Profile/PartnerInfoCollection/PartnerInfoGeneral", order = 3)]
	public class PartnerInfo : PartnerInfoBase
	{
		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06004BFD RID: 19453 RVA: 0x0001B750 File Offset: 0x00019950
		[Token(Token = "0x17000AED")]
		public PartnerInfoBase.Speed MoveSpeedLiteral
		{
			[Token(Token = "0x6004BFD")]
			[Address(RVA = "0x79FFF0", Offset = "0x79E9F0", VA = "0x18079FFF0")]
			get
			{
				return PartnerInfoBase.Speed.Slow;
			}
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFE")]
		[Address(RVA = "0x79FFE0", Offset = "0x79E9E0", VA = "0x18079FFE0", Slot = "19")]
		protected override string GetMoveSpeedText()
		{
			return null;
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFF")]
		[Address(RVA = "0x79ECC0", Offset = "0x79D6C0", VA = "0x18079ECC0", Slot = "20")]
		protected override string GetWorkSpeedText()
		{
			return null;
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C00")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public PartnerInfo()
		{
		}

		// Token: 0x040045F9 RID: 17913
		[Token(Token = "0x40045F9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private PartnerInfoBase.Speed moveSpeedLiteral;
	}
}

using System;
using GameData.Profile;
using Il2CppDummyDll;

namespace Common.DialogUtility
{
	// Token: 0x02000D94 RID: 3476
	[Token(Token = "0x2000D94")]
	public abstract class DialogPannelOpenContextBase
	{
		// Token: 0x060051B5 RID: 20917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B5")]
		[Address(RVA = "0x7FC450", Offset = "0x7FAE50", VA = "0x1807FC450")]
		protected DialogPannelOpenContextBase(DialogPackage dialogPackageToPlay)
		{
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060051B6 RID: 20918
		[Token(Token = "0x17000B92")]
		public abstract bool ManualMode
		{
			[Token(Token = "0x60051B6")]
			get;
		}

		// Token: 0x04004CAA RID: 19626
		[Token(Token = "0x4004CAA")]
		[FieldOffset(Offset = "0x10")]
		public readonly DialogPackage DialogPackageToPlay;
	}
}

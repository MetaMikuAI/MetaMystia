using System;
using System.Collections.Generic;
using GameData.Profile;
using Il2CppDummyDll;

namespace Common.DialogUtility
{
	// Token: 0x02000D95 RID: 3477
	[Token(Token = "0x2000D95")]
	public class NormalDialogPannelOpenContext : DialogPannelOpenContextBase
	{
		// Token: 0x060051B7 RID: 20919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B7")]
		[Address(RVA = "0x8001D0", Offset = "0x7FEBD0", VA = "0x1808001D0")]
		public NormalDialogPannelOpenContext(DialogPackage dialogPackageToPlay, Action<Dictionary<int, string>> overrideReplaceTextCallback)
		{
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060051B8 RID: 20920 RVA: 0x0001DAC0 File Offset: 0x0001BCC0
		[Token(Token = "0x17000B93")]
		public override bool ManualMode
		{
			[Token(Token = "0x60051B8")]
			[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04004CAB RID: 19627
		[Token(Token = "0x4004CAB")]
		[FieldOffset(Offset = "0x18")]
		public readonly Action<Dictionary<int, string>> OverrideReplaceTextCallback;
	}
}

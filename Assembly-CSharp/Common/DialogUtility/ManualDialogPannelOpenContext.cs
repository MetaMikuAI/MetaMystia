using System;
using GameData.Profile;
using Il2CppDummyDll;

namespace Common.DialogUtility
{
	// Token: 0x02000D96 RID: 3478
	[Token(Token = "0x2000D96")]
	public class ManualDialogPannelOpenContext : DialogPannelOpenContextBase
	{
		// Token: 0x060051B9 RID: 20921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051B9")]
		[Address(RVA = "0x7FF2A0", Offset = "0x7FDCA0", VA = "0x1807FF2A0")]
		public ManualDialogPannelOpenContext(DialogPackage dialogPackageToPlay, bool openWithBlackBackground, Action onDialogFinishCallback, Action onLoadFinishCallback)
		{
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060051BA RID: 20922 RVA: 0x0001DAD8 File Offset: 0x0001BCD8
		[Token(Token = "0x17000B94")]
		public override bool ManualMode
		{
			[Token(Token = "0x60051BA")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04004CAC RID: 19628
		[Token(Token = "0x4004CAC")]
		[FieldOffset(Offset = "0x18")]
		public readonly Action OnDialogFinishCallback;

		// Token: 0x04004CAD RID: 19629
		[Token(Token = "0x4004CAD")]
		[FieldOffset(Offset = "0x20")]
		public readonly Action OnLoadFinishCallback;

		// Token: 0x04004CAE RID: 19630
		[Token(Token = "0x4004CAE")]
		[FieldOffset(Offset = "0x28")]
		public readonly bool OpenWithBlackBackground;
	}
}

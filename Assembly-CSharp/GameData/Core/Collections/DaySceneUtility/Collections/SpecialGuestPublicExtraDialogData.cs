using System;
using DayScene.UI;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B41 RID: 2881
	[Token(Token = "0x2000B41")]
	public abstract class SpecialGuestPublicExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x060044C7 RID: 17607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009CA")]
		public string[] TargetSpecialGuestLabel
		{
			[Token(Token = "0x60044C7")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x060044C8 RID: 17608 RVA: 0x00018DB0 File Offset: 0x00016FB0
		[Token(Token = "0x60044C8")]
		[Address(RVA = "0x71F840", Offset = "0x71E240", VA = "0x18071F840")]
		public bool CheckIsTargetSGuest(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData)
		{
			return default(bool);
		}

		// Token: 0x060044C9 RID: 17609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044C9")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		protected SpecialGuestPublicExtraDialogData()
		{
		}

		// Token: 0x04003CEA RID: 15594
		[Token(Token = "0x4003CEA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string[] targetSpecialGuestLabel;
	}
}

using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BB7 RID: 2999
	[Token(Token = "0x2000BB7")]
	[CreateAssetMenu(fileName = "DayScenePublicExtraSelectionProfile", menuName = "GameData Profile/CreateDayScenePublicExtraDialogProfile", order = 2502)]
	public class PublicExtraDialogProfile : ScriptableObject
	{
		// Token: 0x060046BA RID: 18106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BA")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public PublicExtraDialogProfile()
		{
		}

		// Token: 0x04003F45 RID: 16197
		[Token(Token = "0x4003F45")]
		[FieldOffset(Offset = "0x18")]
		public SpecialGuestPublicExtraDialogData[] specialGuestPublicExtraDialogDatas;
	}
}

using System;
using DayScene.UI;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B47 RID: 2887
	[Token(Token = "0x2000B47")]
	public abstract class SpecialGuestExtraDialogData : ScriptableObject
	{
		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x00018DC8 File Offset: 0x00016FC8
		[Token(Token = "0x170009CB")]
		public virtual bool DoNotSkipGreeting
		{
			[Token(Token = "0x60044DE")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060044DF RID: 17631
		[Token(Token = "0x60044DF")]
		public abstract void GetSpecialGuestExtraDialogData(out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelection, out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections);

		// Token: 0x060044E0 RID: 17632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E0")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		protected SpecialGuestExtraDialogData()
		{
		}
	}
}

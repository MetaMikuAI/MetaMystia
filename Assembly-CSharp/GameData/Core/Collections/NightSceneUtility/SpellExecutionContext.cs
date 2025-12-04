using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.CharacterUtility;
using GameData.CoreLanguage;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x020008F7 RID: 2295
	[Token(Token = "0x20008F7")]
	public class SpellExecutionContext
	{
		// Token: 0x06003946 RID: 14662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003946")]
		[Address(RVA = "0x692F50", Offset = "0x691950", VA = "0x180692F50")]
		public SpellExecutionContext(SpecialGuestsController guestsController, SpecialGuest characterData, AStarInputGeneratorComponent[] guestCharacterInstances, LanguageBase[] spellLanguageData, Action onFinishCallback, bool shouldRecordSpellNum)
		{
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06003947 RID: 14663 RVA: 0x00015C00 File Offset: 0x00013E00
		[Token(Token = "0x17000800")]
		public Vector3? GuestPosition
		{
			[Token(Token = "0x6003947")]
			[Address(RVA = "0x693000", Offset = "0x691A00", VA = "0x180693000")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x06003948 RID: 14664 RVA: 0x00015C18 File Offset: 0x00013E18
		[Token(Token = "0x17000801")]
		public bool IsSitInLeftSeat
		{
			[Token(Token = "0x6003948")]
			[Address(RVA = "0x693240", Offset = "0x691C40", VA = "0x180693240")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000802")]
		public SpecialGuestsController GuestsController
		{
			[Token(Token = "0x6003949")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x0600394A RID: 14666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000803")]
		public SpecialGuest CharacterData
		{
			[Token(Token = "0x600394A")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x0600394B RID: 14667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000804")]
		public AStarInputGeneratorComponent[] GuestCharacterInstances
		{
			[Token(Token = "0x600394B")]
			[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x0600394C RID: 14668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000805")]
		public LanguageBase[] SpellLanguageData
		{
			[Token(Token = "0x600394C")]
			[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x0600394D RID: 14669 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600394E RID: 14670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000806")]
		public Action OnFinishCallback
		{
			[Token(Token = "0x600394D")]
			[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600394E")]
			[Address(RVA = "0x4AD3C0", Offset = "0x4ABDC0", VA = "0x1804AD3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600394F RID: 14671 RVA: 0x00015C30 File Offset: 0x00013E30
		[Token(Token = "0x17000807")]
		public bool ShouldRecordSpellNum
		{
			[Token(Token = "0x600394F")]
			[Address(RVA = "0x494130", Offset = "0x492B30", VA = "0x180494130")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06003950 RID: 14672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000808")]
		public Dictionary<string, Coroutine> RotationsCoroutineHandles
		{
			[Token(Token = "0x6003950")]
			[Address(RVA = "0x6932F0", Offset = "0x691CF0", VA = "0x1806932F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x040030D9 RID: 12505
		[Token(Token = "0x40030D9")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, Coroutine> m_RotationsCoroutineHandles;
	}
}

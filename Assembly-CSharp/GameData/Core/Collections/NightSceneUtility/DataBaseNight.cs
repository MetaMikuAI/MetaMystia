using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AssetHandleUtility;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x020008E6 RID: 2278
	[Token(Token = "0x20008E6")]
	public static class DataBaseNight
	{
		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060038BC RID: 14524 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060038BD RID: 14525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C3")]
		private static Dictionary<int, IAssetHandle<SpellBase>> SpecialGuestSpell
		{
			[Token(Token = "0x60038BC")]
			[Address(RVA = "0x6811F0", Offset = "0x67FBF0", VA = "0x1806811F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60038BD")]
			[Address(RVA = "0x6812F0", Offset = "0x67FCF0", VA = "0x1806812F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060038BE RID: 14526 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060038BF RID: 14527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C4")]
		private static Dictionary<int, string> SpecialGuestSpellMapping
		{
			[Token(Token = "0x60038BE")]
			[Address(RVA = "0x681170", Offset = "0x67FB70", VA = "0x180681170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60038BF")]
			[Address(RVA = "0x681230", Offset = "0x67FC30", VA = "0x180681230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060038C0 RID: 14528 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060038C1 RID: 14529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007C5")]
		[TupleElementNames(new string[] { "Positive", "Negative" })]
		private static Dictionary<int, ValueTuple<IAssetHandle<Sprite>, IAssetHandle<Sprite>>> SpecialGuestSpellPortrayal
		{
			[Token(Token = "0x60038C0")]
			[Address(RVA = "0x6811B0", Offset = "0x67FBB0", VA = "0x1806811B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60038C1")]
			[Address(RVA = "0x681290", Offset = "0x67FC90", VA = "0x180681290")]
			[CompilerGenerated]
			[param: TupleElementNames(new string[] { "Positive", "Negative" })]
			set
			{
			}
		}

		// Token: 0x060038C2 RID: 14530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C2")]
		[Address(RVA = "0x6805E0", Offset = "0x67EFE0", VA = "0x1806805E0")]
		public static void Initialize(Dictionary<string, DataBaseNight.DataBaseNightData> nightData, [TupleElementNames(new string[] { "Positive", "Negative" })] Dictionary<int, ValueTuple<IAssetHandle<Sprite>, IAssetHandle<Sprite>>> characterPortrayalDictionary)
		{
		}

		// Token: 0x060038C3 RID: 14531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C3")]
		[Address(RVA = "0x680DE0", Offset = "0x67F7E0", VA = "0x180680DE0")]
		public static Sprite WorkSceneGetSpellPortrayal(int specialGuestId, bool isPositiveSpellCard)
		{
			return null;
		}

		// Token: 0x060038C4 RID: 14532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038C4")]
		[Address(RVA = "0x680F80", Offset = "0x67F980", VA = "0x180680F80")]
		public static SpellBase WorkSceneGetSpell(int specialGuestId)
		{
			return null;
		}

		// Token: 0x060038C5 RID: 14533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038C5")]
		[Address(RVA = "0x6808B0", Offset = "0x67F2B0", VA = "0x1806808B0")]
		public static void UnloadWorkSceneData()
		{
		}

		// Token: 0x020008E7 RID: 2279
		[Token(Token = "0x20008E7")]
		public class DataBaseNightData
		{
			// Token: 0x060038C6 RID: 14534 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60038C6")]
			[Address(RVA = "0x46BA70", Offset = "0x46A470", VA = "0x18046BA70")]
			public DataBaseNightData(Dictionary<int, IAssetHandle<SpellBase>> specialGuestSpell)
			{
			}

			// Token: 0x170007C6 RID: 1990
			// (get) Token: 0x060038C7 RID: 14535 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060038C8 RID: 14536 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170007C6")]
			internal Dictionary<int, IAssetHandle<SpellBase>> SpecialGuestSpell
			{
				[Token(Token = "0x60038C7")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60038C8")]
				[Address(RVA = "0x4A6ED0", Offset = "0x4A58D0", VA = "0x1804A6ED0")]
				[CompilerGenerated]
				set
				{
				}
			}
		}
	}
}

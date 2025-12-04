using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core.Collections.CharacterUtility
{
	// Token: 0x02000B63 RID: 2915
	[Token(Token = "0x2000B63")]
	public static class DataBaseCharacter
	{
		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06004564 RID: 17764 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004565 RID: 17765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009EF")]
		private static Dictionary<int, CharacterSpriteSetCompact[]> NormalGuestVisual
		{
			[Token(Token = "0x6004564")]
			[Address(RVA = "0x73C940", Offset = "0x73B340", VA = "0x18073C940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004565")]
			[Address(RVA = "0x73D530", Offset = "0x73BF30", VA = "0x18073D530")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06004566 RID: 17766 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004567 RID: 17767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F0")]
		private static Dictionary<int, GuestProfilePair> SpecialGuestVisual
		{
			[Token(Token = "0x6004566")]
			[Address(RVA = "0x73CCC0", Offset = "0x73B6C0", VA = "0x18073CCC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004567")]
			[Address(RVA = "0x73D970", Offset = "0x73C370", VA = "0x18073D970")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06004568 RID: 17768 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004569 RID: 17769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F1")]
		private static Dictionary<int, CharacterSpriteSetCompact> DaySceneNormalGuestVisual
		{
			[Token(Token = "0x6004568")]
			[Address(RVA = "0x73C4F0", Offset = "0x73AEF0", VA = "0x18073C4F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004569")]
			[Address(RVA = "0x73D060", Offset = "0x73BA60", VA = "0x18073D060")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x0600456A RID: 17770 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600456B RID: 17771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F2")]
		private static Dictionary<int, NormalGuest> NormalGuest
		{
			[Token(Token = "0x600456A")]
			[Address(RVA = "0x73C990", Offset = "0x73B390", VA = "0x18073C990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600456B")]
			[Address(RVA = "0x73D5A0", Offset = "0x73BFA0", VA = "0x18073D5A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x0600456C RID: 17772 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600456D RID: 17773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F3")]
		private static Dictionary<int, SpecialGuest> SpecialGuest
		{
			[Token(Token = "0x600456C")]
			[Address(RVA = "0x73CD10", Offset = "0x73B710", VA = "0x18073CD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600456D")]
			[Address(RVA = "0x73D9E0", Offset = "0x73C3E0", VA = "0x18073D9E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x0600456E RID: 17774 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600456F RID: 17775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F4")]
		private static Dictionary<int, MappedSpecialGuest> MappedSpecialGuest
		{
			[Token(Token = "0x600456E")]
			[Address(RVA = "0x73C7D0", Offset = "0x73B1D0", VA = "0x18073C7D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600456F")]
			[Address(RVA = "0x73D3C0", Offset = "0x73BDC0", VA = "0x18073D3C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06004570 RID: 17776 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004571 RID: 17777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F5")]
		private static Dictionary<int, SpecialGuest> BufferedMappedSpecialGuest
		{
			[Token(Token = "0x6004570")]
			[Address(RVA = "0x73C260", Offset = "0x73AC60", VA = "0x18073C260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004571")]
			[Address(RVA = "0x73CE70", Offset = "0x73B870", VA = "0x18073CE70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06004572 RID: 17778 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004573 RID: 17779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F6")]
		private static Dictionary<int, PartnerInfoBase> PartnerInfo
		{
			[Token(Token = "0x6004572")]
			[Address(RVA = "0x73CA40", Offset = "0x73B440", VA = "0x18073CA40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004573")]
			[Address(RVA = "0x73D690", Offset = "0x73C090", VA = "0x18073D690")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004575 RID: 17781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F7")]
		private static Dictionary<string, SchedulerNode.Character> StringMappingData
		{
			[Token(Token = "0x6004574")]
			[Address(RVA = "0x73CD60", Offset = "0x73B760", VA = "0x18073CD60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004575")]
			[Address(RVA = "0x73DA50", Offset = "0x73C450", VA = "0x18073DA50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06004576 RID: 17782 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004577 RID: 17783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F8")]
		private static Dictionary<SchedulerNode.Character, string[]> InvStringMappingData
		{
			[Token(Token = "0x6004576")]
			[Address(RVA = "0x73C720", Offset = "0x73B120", VA = "0x18073C720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004577")]
			[Address(RVA = "0x73D2D0", Offset = "0x73BCD0", VA = "0x18073D2D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06004578 RID: 17784 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004579 RID: 17785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009F9")]
		private static Dictionary<int, int> SpecialGuestMappingRules
		{
			[Token(Token = "0x6004578")]
			[Address(RVA = "0x73CBB0", Offset = "0x73B5B0", VA = "0x18073CBB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004579")]
			[Address(RVA = "0x73D800", Offset = "0x73C200", VA = "0x18073D800")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x00019140 File Offset: 0x00017340
		// (set) Token: 0x0600457B RID: 17787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009FA")]
		private static Color UnifiedNormalGuestBGColor
		{
			[Token(Token = "0x600457A")]
			[Address(RVA = "0x73CDB0", Offset = "0x73B7B0", VA = "0x18073CDB0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600457B")]
			[Address(RVA = "0x73DAC0", Offset = "0x73C4C0", VA = "0x18073DAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x0600457C RID: 17788 RVA: 0x00019158 File Offset: 0x00017358
		// (set) Token: 0x0600457D RID: 17789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009FB")]
		private static Color UnifiedNormalGuestTextColor
		{
			[Token(Token = "0x600457C")]
			[Address(RVA = "0x73CE10", Offset = "0x73B810", VA = "0x18073CE10")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600457D")]
			[Address(RVA = "0x73DB20", Offset = "0x73C520", VA = "0x18073DB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x0600457E RID: 17790 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600457F RID: 17791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009FC")]
		private static Dictionary<int, string> NormalGuestVisualMapping
		{
			[Token(Token = "0x600457E")]
			[Address(RVA = "0x73C8E0", Offset = "0x73B2E0", VA = "0x18073C8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600457F")]
			[Address(RVA = "0x73D4B0", Offset = "0x73BEB0", VA = "0x18073D4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06004580 RID: 17792 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004581 RID: 17793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009FD")]
		private static Dictionary<int, string> SpecialGuestVisualMapping
		{
			[Token(Token = "0x6004580")]
			[Address(RVA = "0x73CC60", Offset = "0x73B660", VA = "0x18073CC60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004581")]
			[Address(RVA = "0x73D8F0", Offset = "0x73C2F0", VA = "0x18073D8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06004582 RID: 17794 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004583 RID: 17795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009FE")]
		private static Dictionary<int, string> DaySceneNormalGuestVisualMapping
		{
			[Token(Token = "0x6004582")]
			[Address(RVA = "0x73C490", Offset = "0x73AE90", VA = "0x18073C490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004583")]
			[Address(RVA = "0x73CFE0", Offset = "0x73B9E0", VA = "0x18073CFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06004584 RID: 17796 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004585 RID: 17797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009FF")]
		private static Dictionary<int, string> NormalGuestMapping
		{
			[Token(Token = "0x6004584")]
			[Address(RVA = "0x73C880", Offset = "0x73B280", VA = "0x18073C880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004585")]
			[Address(RVA = "0x73D430", Offset = "0x73BE30", VA = "0x18073D430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06004586 RID: 17798 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004587 RID: 17799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A00")]
		private static Dictionary<int, string> SpecialGuestMapping
		{
			[Token(Token = "0x6004586")]
			[Address(RVA = "0x73CC00", Offset = "0x73B600", VA = "0x18073CC00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004587")]
			[Address(RVA = "0x73D870", Offset = "0x73C270", VA = "0x18073D870")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06004588 RID: 17800 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004589 RID: 17801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A01")]
		private static Dictionary<int, string> PartnerInfoMapping
		{
			[Token(Token = "0x6004588")]
			[Address(RVA = "0x73C9E0", Offset = "0x73B3E0", VA = "0x18073C9E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004589")]
			[Address(RVA = "0x73D610", Offset = "0x73C010", VA = "0x18073D610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x0600458A RID: 17802 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600458B RID: 17803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A02")]
		private static Dictionary<int, string> MappedSpecialGuestMapping
		{
			[Token(Token = "0x600458A")]
			[Address(RVA = "0x73C770", Offset = "0x73B170", VA = "0x18073C770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600458B")]
			[Address(RVA = "0x73D340", Offset = "0x73BD40", VA = "0x18073D340")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x0600458C RID: 17804 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600458D RID: 17805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A03")]
		public static GuestProfilePair FallbackSpecialGuestVisual
		{
			[Token(Token = "0x600458C")]
			[Address(RVA = "0x73C6C0", Offset = "0x73B0C0", VA = "0x18073C6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600458D")]
			[Address(RVA = "0x73D250", Offset = "0x73BC50", VA = "0x18073D250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x0600458E RID: 17806 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600458F RID: 17807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A04")]
		public static CharacterPortrayal FallbackPortrayal
		{
			[Token(Token = "0x600458E")]
			[Address(RVA = "0x73C660", Offset = "0x73B060", VA = "0x18073C660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600458F")]
			[Address(RVA = "0x73D1D0", Offset = "0x73BBD0", VA = "0x18073D1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06004590 RID: 17808 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004591 RID: 17809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A05")]
		public static CharacterSpriteSetFull FallbackFullPixel
		{
			[Token(Token = "0x6004590")]
			[Address(RVA = "0x73C600", Offset = "0x73B000", VA = "0x18073C600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004591")]
			[Address(RVA = "0x73D150", Offset = "0x73BB50", VA = "0x18073D150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06004592 RID: 17810 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004593 RID: 17811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A06")]
		public static CharacterSpriteSetCompact FallbackCompactPixel
		{
			[Token(Token = "0x6004592")]
			[Address(RVA = "0x73C5A0", Offset = "0x73AFA0", VA = "0x18073C5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004593")]
			[Address(RVA = "0x73D0D0", Offset = "0x73BAD0", VA = "0x18073D0D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06004594 RID: 17812 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004595 RID: 17813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A07")]
		public static CharacterSkinSets SelfSpriteSet
		{
			[Token(Token = "0x6004594")]
			[Address(RVA = "0x73CB50", Offset = "0x73B550", VA = "0x18073CB50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004595")]
			[Address(RVA = "0x73D780", Offset = "0x73C180", VA = "0x18073D780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004597 RID: 17815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A08")]
		public static CharacterProtrayalSet SelfPortrayalSet
		{
			[Token(Token = "0x6004596")]
			[Address(RVA = "0x73CAF0", Offset = "0x73B4F0", VA = "0x18073CAF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004597")]
			[Address(RVA = "0x73D700", Offset = "0x73C100", VA = "0x18073D700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06004598 RID: 17816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A09")]
		public static byte[,] FaceMatrix
		{
			[Token(Token = "0x6004598")]
			[Address(RVA = "0x73C540", Offset = "0x73AF40", VA = "0x18073C540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06004599 RID: 17817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A0A")]
		public static sbyte[,] MovingMatrix
		{
			[Token(Token = "0x6004599")]
			[Address(RVA = "0x73C820", Offset = "0x73B220", VA = "0x18073C820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x0600459A RID: 17818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A0B")]
		public static sbyte[,] RotatingMatrix
		{
			[Token(Token = "0x600459A")]
			[Address(RVA = "0x73CA90", Offset = "0x73B490", VA = "0x18073CA90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x0600459B RID: 17819 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600459C RID: 17820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A0C")]
		public static GameObject CharacterBase
		{
			[Token(Token = "0x600459B")]
			[Address(RVA = "0x73C2B0", Offset = "0x73ACB0", VA = "0x18073C2B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600459C")]
			[Address(RVA = "0x73CEE0", Offset = "0x73B8E0", VA = "0x18073CEE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x0600459D RID: 17821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A0D")]
		public static List<Sprite> CharacterMouth
		{
			[Token(Token = "0x600459D")]
			[Address(RVA = "0x73C370", Offset = "0x73AD70", VA = "0x18073C370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x0600459E RID: 17822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A0E")]
		public static Dictionary<int, AudioClip> CharacterSFX
		{
			[Token(Token = "0x600459E")]
			[Address(RVA = "0x73C430", Offset = "0x73AE30", VA = "0x18073C430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x0600459F RID: 17823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A0F")]
		public static Dictionary<int, Sprite[]> CharacterPFX
		{
			[Token(Token = "0x600459F")]
			[Address(RVA = "0x73C3D0", Offset = "0x73ADD0", VA = "0x18073C3D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x060045A0 RID: 17824 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060045A1 RID: 17825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A10")]
		public static Dictionary<int, bool> CharacterHasSpell
		{
			[Token(Token = "0x60045A0")]
			[Address(RVA = "0x73C310", Offset = "0x73AD10", VA = "0x18073C310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60045A1")]
			[Address(RVA = "0x73CF60", Offset = "0x73B960", VA = "0x18073CF60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060045A2 RID: 17826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A2")]
		[Address(RVA = "0x737650", Offset = "0x736050", VA = "0x180737650")]
		public static string GetNormalGuestVisualDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x060045A3 RID: 17827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A3")]
		[Address(RVA = "0x737890", Offset = "0x736290", VA = "0x180737890")]
		public static string GetSpecialGuestVisualDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x060045A4 RID: 17828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A4")]
		[Address(RVA = "0x736F70", Offset = "0x735970", VA = "0x180736F70")]
		public static string GetDaySceneNormalGuestVisualDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x060045A5 RID: 17829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A5")]
		[Address(RVA = "0x737590", Offset = "0x735F90", VA = "0x180737590")]
		public static string GetNormalGuestDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x060045A6 RID: 17830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A6")]
		[Address(RVA = "0x7377D0", Offset = "0x7361D0", VA = "0x1807377D0")]
		public static string GetSpecialGuestDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x060045A7 RID: 17831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A7")]
		[Address(RVA = "0x737710", Offset = "0x736110", VA = "0x180737710")]
		public static string GetPartnerInfoDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x060045A8 RID: 17832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045A8")]
		[Address(RVA = "0x737030", Offset = "0x735A30", VA = "0x180737030")]
		public static string GetMappedSpecialGuestDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x060045A9 RID: 17833 RVA: 0x00019170 File Offset: 0x00017370
		[Token(Token = "0x60045A9")]
		[Address(RVA = "0x739F20", Offset = "0x738920", VA = "0x180739F20")]
		public static UniTask LoadActivePlayerSkinAsync(ClothesProfile.Clothes clothesData)
		{
			return default(UniTask);
		}

		// Token: 0x060045AA RID: 17834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AA")]
		[Address(RVA = "0x73BF60", Offset = "0x73A960", VA = "0x18073BF60")]
		public static void UnloadActivePlayerSkin()
		{
		}

		// Token: 0x060045AB RID: 17835 RVA: 0x00019188 File Offset: 0x00017388
		[Token(Token = "0x60045AB")]
		[Address(RVA = "0x73B880", Offset = "0x73A280", VA = "0x18073B880")]
		public static bool SetupPortrayalVisual(Image imageComponent, MonoBehaviour coroutineRunner, ref Coroutine dynamicPortrayalCoroutine)
		{
			return default(bool);
		}

		// Token: 0x060045AC RID: 17836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AC")]
		[Address(RVA = "0x737AA0", Offset = "0x7364A0", VA = "0x180737AA0")]
		public static void Initialize(GameObject characterControllerUnitParent, CharacterPortrayal characterPortrayalFallback, CharacterSpriteSetFull defaultFullSpriteSet, CharacterSpriteSetCompact defaultCompactSpriteSet, CharacterProtrayalSet selfPortrayalSet, CharacterSkinSets selfSpriteSet, Color unifiedNormalGuestBGColor, Color unifiedNormalGuestTextColor, Dictionary<string, SchedulerNode.Character> extraStringMappingData, Dictionary<string, DataBaseCharacter.DataBaseCharacterData> characterData)
		{
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AD")]
		[Address(RVA = "0x73A300", Offset = "0x738D00", VA = "0x18073A300")]
		private static GuestProfilePair PopulateNullValues(GuestProfilePair toPopulate, GuestProfilePair populateReference)
		{
			return null;
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045AE")]
		[Address(RVA = "0x73A310", Offset = "0x738D10", VA = "0x18073A310")]
		private static CharacterSpriteSetCompact[] PopulateNullValues(CharacterSpriteSetCompact[] original, CharacterSpriteSetCompact reference)
		{
			return null;
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x000191A0 File Offset: 0x000173A0
		[Token(Token = "0x60045AF")]
		[Address(RVA = "0x73A250", Offset = "0x738C50", VA = "0x18073A250")]
		public static bool NormalGuestExists(int id)
		{
			return default(bool);
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B0")]
		[Address(RVA = "0x73A8E0", Offset = "0x7392E0", VA = "0x18073A8E0")]
		public static NormalGuest RefNGuest(this int id)
		{
			return null;
		}

		// Token: 0x060045B1 RID: 17841 RVA: 0x000191B8 File Offset: 0x000173B8
		[Token(Token = "0x60045B1")]
		[Address(RVA = "0x739E70", Offset = "0x738870", VA = "0x180739E70")]
		public static bool IsSpecialGuestMapped(int id)
		{
			return default(bool);
		}

		// Token: 0x060045B2 RID: 17842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B2")]
		[Address(RVA = "0x73B260", Offset = "0x739C60", VA = "0x18073B260")]
		public static SpecialGuest RefSGuest(this string daySceneNPCid)
		{
			return null;
		}

		// Token: 0x060045B3 RID: 17843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B3")]
		[Address(RVA = "0x73B580", Offset = "0x739F80", VA = "0x18073B580")]
		public static SpecialGuest RefSGuest(this int id)
		{
			return null;
		}

		// Token: 0x060045B4 RID: 17844 RVA: 0x000191D0 File Offset: 0x000173D0
		[Token(Token = "0x60045B4")]
		[Address(RVA = "0x73A0E0", Offset = "0x738AE0", VA = "0x18073A0E0")]
		public static int MappedID2TargetID(int source)
		{
			return 0;
		}

		// Token: 0x060045B5 RID: 17845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B5")]
		[Address(RVA = "0x7369A0", Offset = "0x7353A0", VA = "0x1807369A0")]
		public static NormalGuest[] GetAllNormalGuests()
		{
			return null;
		}

		// Token: 0x060045B6 RID: 17846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B6")]
		[Address(RVA = "0x736B00", Offset = "0x735500", VA = "0x180736B00")]
		public static SpecialGuest[] GetAllSpecialGuests()
		{
			return null;
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x000191E8 File Offset: 0x000173E8
		[Token(Token = "0x60045B7")]
		[Address(RVA = "0x73BBE0", Offset = "0x73A5E0", VA = "0x18073BBE0")]
		public static bool SpecialGuestExists(int id)
		{
			return default(bool);
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045B8")]
		[Address(RVA = "0x7368E0", Offset = "0x7352E0", VA = "0x1807368E0")]
		public static MappedSpecialGuest[] GetAllMappedGuests()
		{
			return null;
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045B9")]
		[Address(RVA = "0x73A3C0", Offset = "0x738DC0", VA = "0x18073A3C0")]
		private static void PreinitSpecialGuests()
		{
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BA")]
		[Address(RVA = "0x737950", Offset = "0x736350", VA = "0x180737950")]
		public static SpecialGuest[] GetSpecialGuestsAndMappedGuests()
		{
			return null;
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BB")]
		[Address(RVA = "0x7370F0", Offset = "0x735AF0", VA = "0x1807370F0")]
		public static Dictionary<string, SpecialGuest[]> GetMappedSpecialGuests()
		{
			return null;
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BC")]
		[Address(RVA = "0x73B1C0", Offset = "0x739BC0", VA = "0x18073B1C0")]
		public static PartnerInfoBase RefPartnerInfo(this int id)
		{
			return null;
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x00019200 File Offset: 0x00017400
		[Token(Token = "0x60045BD")]
		[Address(RVA = "0x736830", Offset = "0x735230", VA = "0x180736830")]
		public static bool CheckIdIsPartner(int id)
		{
			return default(bool);
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x00019218 File Offset: 0x00017418
		[Token(Token = "0x60045BE")]
		[Address(RVA = "0x736610", Offset = "0x735010", VA = "0x180736610")]
		public static bool CheckIdIsBossPartner(int id)
		{
			return default(bool);
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045BF")]
		[Address(RVA = "0x736BC0", Offset = "0x7355C0", VA = "0x180736BC0")]
		public static IEnumerable<int> GetAllValidPartnerIndex()
		{
			return null;
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C0")]
		[Address(RVA = "0x7362E0", Offset = "0x734CE0", VA = "0x1807362E0")]
		public static Sprite[] AsCharacterSpriteSet(this Sprite original)
		{
			return null;
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C1")]
		[Address(RVA = "0x73AEC0", Offset = "0x7398C0", VA = "0x18073AEC0")]
		public static GuestProfilePair RefNormalGuestVisual(this int id)
		{
			return null;
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C2")]
		[Address(RVA = "0x73A700", Offset = "0x739100", VA = "0x18073A700")]
		public static CharacterSpriteSetCompact RefDaySceneNormalGuestVisual(this int id)
		{
			return null;
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C3")]
		[Address(RVA = "0x73B790", Offset = "0x73A190", VA = "0x18073B790")]
		public static GuestProfilePair RefSpecialGuestVisual(this int id)
		{
			return null;
		}

		// Token: 0x060045C4 RID: 17860 RVA: 0x00019230 File Offset: 0x00017430
		[Token(Token = "0x60045C4")]
		[Address(RVA = "0x73A980", Offset = "0x739380", VA = "0x18073A980")]
		public static SchedulerNode.Character RefNPCIdentity(this string stringId)
		{
			return default(SchedulerNode.Character);
		}

		// Token: 0x060045C5 RID: 17861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C5")]
		[Address(RVA = "0x737450", Offset = "0x735E50", VA = "0x180737450")]
		public static string GetNPCLabel(SchedulerNode.Character identity)
		{
			return null;
		}

		// Token: 0x060045C6 RID: 17862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C6")]
		[Address(RVA = "0x73ADB0", Offset = "0x7397B0", VA = "0x18073ADB0")]
		public static CharacterSpriteSetCompact RefNPCVisual(this string stringId)
		{
			return null;
		}

		// Token: 0x060045C7 RID: 17863 RVA: 0x00019248 File Offset: 0x00017448
		[Token(Token = "0x60045C7")]
		[Address(RVA = "0x736550", Offset = "0x734F50", VA = "0x180736550")]
		public static bool CheckCharacterHasSpell(int specialGuestId)
		{
			return default(bool);
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045C8")]
		[Address(RVA = "0x736A60", Offset = "0x735460", VA = "0x180736A60")]
		public static IEnumerable<int> GetAllOriginSGuestMapping()
		{
			return null;
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x00019260 File Offset: 0x00017460
		[Token(Token = "0x60045C9")]
		[Address(RVA = "0x73BE80", Offset = "0x73A880", VA = "0x18073BE80")]
		public static bool TryGetTargetSGuestMapping(int originalGuest, out int mappingGuest)
		{
			return default(bool);
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x00019278 File Offset: 0x00017478
		[Token(Token = "0x60045CA")]
		[Address(RVA = "0x73BC90", Offset = "0x73A690", VA = "0x18073BC90")]
		public static bool TryGetOriginalSGuestFromMapping(int mappingGuest, out int originalGuest)
		{
			return default(bool);
		}

		// Token: 0x04003D88 RID: 15752
		[Token(Token = "0x4003D88")]
		[FieldOffset(Offset = "0x0")]
		private static ClothesProfile.Clothes m_ClothesData;

		// Token: 0x04003D89 RID: 15753
		[Token(Token = "0x4003D89")]
		[FieldOffset(Offset = "0x8")]
		private static IAssetHandle<Sprite> m_PlayerActiveSkinPortrayal;

		// Token: 0x04003D8A RID: 15754
		[Token(Token = "0x4003D8A")]
		[FieldOffset(Offset = "0x10")]
		private static IAssetHandleArray<Sprite> m_PlayerActiveAnimatedSkinPortrayal;

		// Token: 0x02000B64 RID: 2916
		[Token(Token = "0x2000B64")]
		public class DataBaseCharacterData
		{
			// Token: 0x060045CC RID: 17868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60045CC")]
			[Address(RVA = "0x736200", Offset = "0x734C00", VA = "0x180736200")]
			public DataBaseCharacterData(Dictionary<int, CharacterSpriteSetCompact[]> normalGuestVisual, Dictionary<int, GuestProfilePair> specialGuestVisual, Dictionary<int, CharacterSpriteSetCompact> daySceneNormalGuestVisual, Dictionary<int, NormalGuest> normalGuest, Dictionary<int, SpecialGuest> specialGuest, Dictionary<int, PartnerInfoBase> partnerInfo, Dictionary<int, MappedSpecialGuest> mappedSpecialGuestData, List<int[]> specialGuestMappingRules, Dictionary<int, bool> characterHasSpell)
			{
			}

			// Token: 0x17000A11 RID: 2577
			// (get) Token: 0x060045CD RID: 17869 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060045CE RID: 17870 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A11")]
			internal Dictionary<int, CharacterSpriteSetCompact[]> NormalGuestVisual
			{
				[Token(Token = "0x60045CD")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60045CE")]
				[Address(RVA = "0x4A6ED0", Offset = "0x4A58D0", VA = "0x1804A6ED0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000A12 RID: 2578
			// (get) Token: 0x060045CF RID: 17871 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060045D0 RID: 17872 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A12")]
			internal Dictionary<int, GuestProfilePair> SpecialGuestVisual
			{
				[Token(Token = "0x60045CF")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60045D0")]
				[Address(RVA = "0x3FC090", Offset = "0x3FAA90", VA = "0x1803FC090")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000A13 RID: 2579
			// (get) Token: 0x060045D1 RID: 17873 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060045D2 RID: 17874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A13")]
			internal Dictionary<int, CharacterSpriteSetCompact> DaySceneNormalGuestVisual
			{
				[Token(Token = "0x60045D1")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60045D2")]
				[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000A14 RID: 2580
			// (get) Token: 0x060045D3 RID: 17875 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060045D4 RID: 17876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A14")]
			internal Dictionary<int, NormalGuest> NormalGuest
			{
				[Token(Token = "0x60045D3")]
				[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60045D4")]
				[Address(RVA = "0x47DD00", Offset = "0x47C700", VA = "0x18047DD00")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000A15 RID: 2581
			// (get) Token: 0x060045D5 RID: 17877 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060045D6 RID: 17878 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A15")]
			internal Dictionary<int, SpecialGuest> SpecialGuest
			{
				[Token(Token = "0x60045D5")]
				[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60045D6")]
				[Address(RVA = "0x531450", Offset = "0x52FE50", VA = "0x180531450")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000A16 RID: 2582
			// (get) Token: 0x060045D7 RID: 17879 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060045D8 RID: 17880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A16")]
			internal Dictionary<int, bool> CharacterHasSpell
			{
				[Token(Token = "0x60045D7")]
				[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60045D8")]
				[Address(RVA = "0x4AD3C0", Offset = "0x4ABDC0", VA = "0x1804AD3C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000A17 RID: 2583
			// (get) Token: 0x060045D9 RID: 17881 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060045DA RID: 17882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A17")]
			internal Dictionary<int, PartnerInfoBase> PartnerInfo
			{
				[Token(Token = "0x60045D9")]
				[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60045DA")]
				[Address(RVA = "0x51B180", Offset = "0x519B80", VA = "0x18051B180")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000A18 RID: 2584
			// (get) Token: 0x060045DB RID: 17883 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060045DC RID: 17884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A18")]
			internal Dictionary<int, MappedSpecialGuest> MappedSpecialGuest
			{
				[Token(Token = "0x60045DB")]
				[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60045DC")]
				[Address(RVA = "0x6086D0", Offset = "0x6070D0", VA = "0x1806086D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000A19 RID: 2585
			// (get) Token: 0x060045DD RID: 17885 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060045DE RID: 17886 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000A19")]
			internal List<int[]> SpecialGuestMappingRules
			{
				[Token(Token = "0x60045DD")]
				[Address(RVA = "0x440270", Offset = "0x43EC70", VA = "0x180440270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60045DE")]
				[Address(RVA = "0x51B160", Offset = "0x519B60", VA = "0x18051B160")]
				[CompilerGenerated]
				set
				{
				}
			}
		}
	}
}

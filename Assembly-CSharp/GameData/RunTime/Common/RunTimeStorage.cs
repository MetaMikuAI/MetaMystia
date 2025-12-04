using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace GameData.RunTime.Common
{
	// Token: 0x02000894 RID: 2196
	[Token(Token = "0x2000894")]
	public static class RunTimeStorage
	{
		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06003546 RID: 13638 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003547 RID: 13639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006EF")]
		public static Action OnAnyObjectInCallback
		{
			[Token(Token = "0x6003546")]
			[Address(RVA = "0x671F50", Offset = "0x670950", VA = "0x180671F50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003547")]
			[Address(RVA = "0x672630", Offset = "0x671030", VA = "0x180672630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06003548 RID: 13640 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003549 RID: 13641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F0")]
		public static Action OnAnyObjectOutCallback
		{
			[Token(Token = "0x6003548")]
			[Address(RVA = "0x671F90", Offset = "0x670990", VA = "0x180671F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003549")]
			[Address(RVA = "0x672690", Offset = "0x671090", VA = "0x180672690")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600354A RID: 13642 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600354B RID: 13643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F1")]
		public static Action<ObjectLanguageBase, int> ObjectLangageBaseInCounted
		{
			[Token(Token = "0x600354A")]
			[Address(RVA = "0x671F10", Offset = "0x670910", VA = "0x180671F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600354B")]
			[Address(RVA = "0x6725D0", Offset = "0x670FD0", VA = "0x1806725D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600354C RID: 13644 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600354D RID: 13645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F2")]
		public static Action<ObjectLanguageBase, int> BadgeInCounted
		{
			[Token(Token = "0x600354C")]
			[Address(RVA = "0x671C10", Offset = "0x670610", VA = "0x180671C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600354D")]
			[Address(RVA = "0x672150", Offset = "0x670B50", VA = "0x180672150")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600354E RID: 13646 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600354F RID: 13647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F3")]
		public static Action<int> RecipeInCallback
		{
			[Token(Token = "0x600354E")]
			[Address(RVA = "0x672010", Offset = "0x670A10", VA = "0x180672010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600354F")]
			[Address(RVA = "0x672750", Offset = "0x671150", VA = "0x180672750")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06003550 RID: 13648 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003551 RID: 13649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F4")]
		public static Action<int> IzakayaInCallback
		{
			[Token(Token = "0x6003550")]
			[Address(RVA = "0x671E90", Offset = "0x670890", VA = "0x180671E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003551")]
			[Address(RVA = "0x672510", Offset = "0x670F10", VA = "0x180672510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06003552 RID: 13650 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003553 RID: 13651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F5")]
		public static Action<int> DecorationInCallback
		{
			[Token(Token = "0x6003552")]
			[Address(RVA = "0x671D50", Offset = "0x670750", VA = "0x180671D50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003553")]
			[Address(RVA = "0x672330", Offset = "0x670D30", VA = "0x180672330")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06003554 RID: 13652 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003555 RID: 13653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F6")]
		public static Action<int> PartnerInCallback
		{
			[Token(Token = "0x6003554")]
			[Address(RVA = "0x671FD0", Offset = "0x6709D0", VA = "0x180671FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003555")]
			[Address(RVA = "0x6726F0", Offset = "0x6710F0", VA = "0x1806726F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06003556 RID: 13654 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003557 RID: 13655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F7")]
		public static Action<ObjectLanguageBase> TrophyInCallback
		{
			[Token(Token = "0x6003556")]
			[Address(RVA = "0x6720D0", Offset = "0x670AD0", VA = "0x1806720D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003557")]
			[Address(RVA = "0x672870", Offset = "0x671270", VA = "0x180672870")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06003558 RID: 13656 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003559 RID: 13657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F8")]
		public static Action<ValueTuple<ObjectLanguageBase, Sprite>, int> CookerInCallback
		{
			[Token(Token = "0x6003558")]
			[Address(RVA = "0x671CD0", Offset = "0x6706D0", VA = "0x180671CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003559")]
			[Address(RVA = "0x672270", Offset = "0x670C70", VA = "0x180672270")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600355A RID: 13658 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600355B RID: 13659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006F9")]
		private static Dictionary<int, int> Foods
		{
			[Token(Token = "0x600355A")]
			[Address(RVA = "0x671D90", Offset = "0x670790", VA = "0x180671D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600355B")]
			[Address(RVA = "0x672390", Offset = "0x670D90", VA = "0x180672390")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x0600355C RID: 13660 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600355D RID: 13661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FA")]
		private static Dictionary<int, int> Beverages
		{
			[Token(Token = "0x600355C")]
			[Address(RVA = "0x671C90", Offset = "0x670690", VA = "0x180671C90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600355D")]
			[Address(RVA = "0x672210", Offset = "0x670C10", VA = "0x180672210")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x0600355E RID: 13662 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600355F RID: 13663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FB")]
		private static Dictionary<int, int> Ingredients
		{
			[Token(Token = "0x600355E")]
			[Address(RVA = "0x671DD0", Offset = "0x6707D0", VA = "0x180671DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600355F")]
			[Address(RVA = "0x6723F0", Offset = "0x670DF0", VA = "0x1806723F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06003560 RID: 13664 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003561 RID: 13665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FC")]
		private static Dictionary<int, int> Cookers
		{
			[Token(Token = "0x6003560")]
			[Address(RVA = "0x671D10", Offset = "0x670710", VA = "0x180671D10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003561")]
			[Address(RVA = "0x6722D0", Offset = "0x670CD0", VA = "0x1806722D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06003562 RID: 13666 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003563 RID: 13667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FD")]
		private static Dictionary<int, int> Items
		{
			[Token(Token = "0x6003562")]
			[Address(RVA = "0x671E50", Offset = "0x670850", VA = "0x180671E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003563")]
			[Address(RVA = "0x6724B0", Offset = "0x670EB0", VA = "0x1806724B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06003564 RID: 13668 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003565 RID: 13669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FE")]
		private static Dictionary<int, int> Badges
		{
			[Token(Token = "0x6003564")]
			[Address(RVA = "0x671C50", Offset = "0x670650", VA = "0x180671C50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003565")]
			[Address(RVA = "0x6721B0", Offset = "0x670BB0", VA = "0x1806721B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06003566 RID: 13670 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003567 RID: 13671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006FF")]
		private static List<int> Trophies
		{
			[Token(Token = "0x6003566")]
			[Address(RVA = "0x672090", Offset = "0x670A90", VA = "0x180672090")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003567")]
			[Address(RVA = "0x672810", Offset = "0x671210", VA = "0x180672810")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06003568 RID: 13672 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003569 RID: 13673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000700")]
		private static List<int> ItemsDeleteEnterWork
		{
			[Token(Token = "0x6003568")]
			[Address(RVA = "0x671E10", Offset = "0x670810", VA = "0x180671E10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003569")]
			[Address(RVA = "0x672450", Offset = "0x670E50", VA = "0x180672450")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600356A RID: 13674 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600356B RID: 13675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000701")]
		private static List<int> Recipes
		{
			[Token(Token = "0x600356A")]
			[Address(RVA = "0x672050", Offset = "0x670A50", VA = "0x180672050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600356B")]
			[Address(RVA = "0x6727B0", Offset = "0x6711B0", VA = "0x1806727B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600356C RID: 13676 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600356D RID: 13677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000702")]
		private static List<int> Izakayas
		{
			[Token(Token = "0x600356C")]
			[Address(RVA = "0x671ED0", Offset = "0x6708D0", VA = "0x180671ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600356D")]
			[Address(RVA = "0x672570", Offset = "0x670F70", VA = "0x180672570")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600356E RID: 13678 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600356F RID: 13679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000703")]
		private static List<int> UnlockedPartner
		{
			[Token(Token = "0x600356E")]
			[Address(RVA = "0x672110", Offset = "0x670B10", VA = "0x180672110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600356F")]
			[Address(RVA = "0x6728D0", Offset = "0x6712D0", VA = "0x1806728D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003570")]
		[Address(RVA = "0x66BD50", Offset = "0x66A750", VA = "0x18066BD50")]
		public static void Initialize(PlayerSaveFile.RunTimeStorageSaveDataPartial saveDataPartial, Dictionary<string, PlayerSaveFile.RunTimeStorageSaveDataPartial> saveDataDLCPartial)
		{
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003571")]
		[Address(RVA = "0x668D60", Offset = "0x667760", VA = "0x180668D60")]
		private static void ForceObjectsNum(Dictionary<int, int> targetDictionary, params int[] ignoreId)
		{
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x00014298 File Offset: 0x00012498
		[Token(Token = "0x6003572")]
		[Address(RVA = "0x66B2E0", Offset = "0x669CE0", VA = "0x18066B2E0")]
		private static int GetElementCount(this Dictionary<int, int> collection, Product product)
		{
			return 0;
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x000142B0 File Offset: 0x000124B0
		[Token(Token = "0x6003573")]
		[Address(RVA = "0x66AE50", Offset = "0x669850", VA = "0x18066AE50")]
		public static long GetAmountInStorage(this Product product)
		{
			return 0L;
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003574")]
		[Address(RVA = "0x66F5D0", Offset = "0x66DFD0", VA = "0x18066F5D0")]
		public static void SendToStorage(this Product product, bool suppressCallbacks = false)
		{
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003575")]
		[Address(RVA = "0x66F0F0", Offset = "0x66DAF0", VA = "0x18066F0F0")]
		public static void RemoveFromStorage(this Product product)
		{
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003576")]
		[Address(RVA = "0x666DA0", Offset = "0x6657A0", VA = "0x180666DA0")]
		public static void ClearForChallenge()
		{
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003577")]
		[Address(RVA = "0x6689E0", Offset = "0x6673E0", VA = "0x1806689E0")]
		public static void DumpForChallenge(out IEnumerable<KeyValuePair<int, int>> foods, out IEnumerable<KeyValuePair<int, int>> bevs, out IEnumerable<KeyValuePair<int, int>> ings)
		{
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003578")]
		[Address(RVA = "0x66BBF0", Offset = "0x66A5F0", VA = "0x18066BBF0")]
		public static void InitializeForChallenge(IEnumerable<KeyValuePair<int, int>> foods, IEnumerable<KeyValuePair<int, int>> beverages, IEnumerable<KeyValuePair<int, int>> ingredients)
		{
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x000142C8 File Offset: 0x000124C8
		[Token(Token = "0x6003579")]
		[Address(RVA = "0x668EE0", Offset = "0x6678E0", VA = "0x180668EE0")]
		public static PlayerSaveFile.RunTimeStorageSaveDataPartial GenerateSaveData()
		{
			return default(PlayerSaveFile.RunTimeStorageSaveDataPartial);
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600357A")]
		private static void ObjectInRange<T>(this Dictionary<int, int> objectPool, IEnumerable<int> objectIds, Func<int, T> objectToLanguageHandler, Action<int> tryRecordHandler, bool suppressCallbacks, Action<T, int> altObjectLanguageBaseInCountedCallback, [Optional] Predicate<int> infiniteResolver)
		{
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600357B")]
		[Address(RVA = "0x66E4D0", Offset = "0x66CED0", VA = "0x18066E4D0")]
		private static void ObjectInRange(this Dictionary<int, int> objectPool, IEnumerable<int> objectIds, Func<int, ObjectLanguageBase> objectToLanguageHandler, Action<int> tryRecordHandler, bool suppressCallbacks = false, [Optional] Action<ObjectLanguageBase, int> altObjectLanguageBaseInCountedCallback, [Optional] Predicate<int> infiniteResolver)
		{
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600357C")]
		[Address(RVA = "0x66E7A0", Offset = "0x66D1A0", VA = "0x18066E7A0")]
		private static void ObjectOut(this Dictionary<int, int> objectPool, int objectId, bool suppressCallbacks = false, [Optional] Predicate<int> infiniteResolver)
		{
		}

		// Token: 0x0600357D RID: 13693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600357D")]
		[Address(RVA = "0x66E5C0", Offset = "0x66CFC0", VA = "0x18066E5C0")]
		private static void ObjectOutRange(this Dictionary<int, int> objectPool, IEnumerable<int> objectIds, bool suppressCallbacks = false, [Optional] Predicate<int> infiniteResolver)
		{
		}

		// Token: 0x0600357E RID: 13694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600357E")]
		private static KeyValuePair<T, int>[] GetObject<T>(this Dictionary<int, int> objectPool, Func<int, T> objectReferenceMethod, [Optional] Predicate<int> infiniteResolver)
		{
			return null;
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x000142E0 File Offset: 0x000124E0
		[Token(Token = "0x600357F")]
		[Address(RVA = "0x671930", Offset = "0x670330", VA = "0x180671930")]
		private static bool TryGetObjectByTag(this Dictionary<int, int> objectPool, Func<int, int[]> objectTagAccessMethod, out int amount, out IEnumerable<int> ids, int tag = -900)
		{
			return default(bool);
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x000142F8 File Offset: 0x000124F8
		[Token(Token = "0x6003580")]
		[Address(RVA = "0x671640", Offset = "0x670040", VA = "0x180671640")]
		private static bool TryGetObjectByLevel(this Dictionary<int, int> objectPool, Func<int, int> objectTagAccessMethod, out int amount, out IEnumerable<int> ids, int level = -900)
		{
			return default(bool);
		}

		// Token: 0x06003581 RID: 13697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003581")]
		[Address(RVA = "0x66E170", Offset = "0x66CB70", VA = "0x18066E170")]
		private static void ObjectInDistinct(this List<int> collection, int item, Action<int> onObjectInNotify, [Optional] Action<int> onObjectIn)
		{
		}

		// Token: 0x06003582 RID: 13698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003582")]
		[Address(RVA = "0x66E2F0", Offset = "0x66CCF0", VA = "0x18066E2F0")]
		private static void ObjectInRangeDistinct(this List<int> collection, IEnumerable<int> items, Action<int> onObjectInNotify, [Optional] Action<int> onObjectIn)
		{
		}

		// Token: 0x06003583 RID: 13699 RVA: 0x00014310 File Offset: 0x00012510
		[Token(Token = "0x6003583")]
		[Address(RVA = "0x667AF0", Offset = "0x6664F0", VA = "0x180667AF0")]
		public static int CountFood()
		{
			return 0;
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x00014328 File Offset: 0x00012528
		[Token(Token = "0x6003584")]
		[Address(RVA = "0x66B360", Offset = "0x669D60", VA = "0x18066B360")]
		public static int GetFoodCountById(int key)
		{
			return 0;
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x00014340 File Offset: 0x00012540
		[Token(Token = "0x6003585")]
		[Address(RVA = "0x667880", Offset = "0x666280", VA = "0x180667880")]
		public static int CountFoodLong()
		{
			return 0;
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003586")]
		[Address(RVA = "0x668B00", Offset = "0x667500", VA = "0x180668B00")]
		public static void FoodInRange(IEnumerable<int> foodIds, bool suppressCallbacks = false)
		{
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003587")]
		[Address(RVA = "0x668D00", Offset = "0x667700", VA = "0x180668D00")]
		public static void FoodOut(int foodId, bool suppressCallbacks = false)
		{
		}

		// Token: 0x06003588 RID: 13704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003588")]
		[Address(RVA = "0x668C90", Offset = "0x667690", VA = "0x180668C90")]
		public static void FoodOutRange(IEnumerable<int> foodIds, bool suppressCallbacks = false)
		{
		}

		// Token: 0x06003589 RID: 13705 RVA: 0x00014358 File Offset: 0x00012558
		[Token(Token = "0x6003589")]
		[Address(RVA = "0x670D60", Offset = "0x66F760", VA = "0x180670D60")]
		public static bool TryGetFoodById(int id, out int amount)
		{
			return default(bool);
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x00014370 File Offset: 0x00012570
		[Token(Token = "0x600358A")]
		[Address(RVA = "0x670F50", Offset = "0x66F950", VA = "0x180670F50")]
		public static bool TryGetFoodByTag(out int amount, out IEnumerable<int> ids, int tag = -900)
		{
			return default(bool);
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x00014388 File Offset: 0x00012588
		[Token(Token = "0x600358B")]
		[Address(RVA = "0x670DE0", Offset = "0x66F7E0", VA = "0x180670DE0")]
		public static bool TryGetFoodByLevel(out int amount, out IEnumerable<int> ids, int level = -900)
		{
			return default(bool);
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358C")]
		[Address(RVA = "0x669F10", Offset = "0x668910", VA = "0x180669F10")]
		public static KeyValuePair<Sellable, int>[] GetAllFoods()
		{
			return null;
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358D")]
		[Address(RVA = "0x669DC0", Offset = "0x6687C0", VA = "0x180669DC0")]
		public static KeyValuePair<int, int>[] GetAllFoodsId()
		{
			return null;
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600358E")]
		[Address(RVA = "0x66D0E0", Offset = "0x66BAE0", VA = "0x18066D0E0")]
		public static void InvalifyAllFoods()
		{
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x000143A0 File Offset: 0x000125A0
		[Token(Token = "0x600358F")]
		[Address(RVA = "0x667730", Offset = "0x666130", VA = "0x180667730")]
		public static int CountBeverage()
		{
			return 0;
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x000143B8 File Offset: 0x000125B8
		[Token(Token = "0x6003590")]
		[Address(RVA = "0x667790", Offset = "0x666190", VA = "0x180667790")]
		public static int CountBeverage(int key)
		{
			return 0;
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003591")]
		[Address(RVA = "0x666030", Offset = "0x664A30", VA = "0x180666030")]
		public static void BeverageInRange(IEnumerable<int> beverageIds, bool suppressCallbacks = false)
		{
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003592")]
		[Address(RVA = "0x666440", Offset = "0x664E40", VA = "0x180666440")]
		public static void BeverageOut(int beverageId, bool suppressCallbacks = false)
		{
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003593")]
		[Address(RVA = "0x6662B0", Offset = "0x664CB0", VA = "0x1806662B0")]
		public static void BeverageOutRange(IEnumerable<int> beverageIds, bool suppressCallbacks = false)
		{
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003594")]
		[Address(RVA = "0x6664B0", Offset = "0x664EB0", VA = "0x1806664B0")]
		public static void ClearAllBeverage()
		{
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x000143D0 File Offset: 0x000125D0
		[Token(Token = "0x6003595")]
		[Address(RVA = "0x66B180", Offset = "0x669B80", VA = "0x18066B180")]
		public static int GetBeverageCountById(int id)
		{
			return 0;
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x000143E8 File Offset: 0x000125E8
		[Token(Token = "0x6003596")]
		[Address(RVA = "0x670800", Offset = "0x66F200", VA = "0x180670800")]
		public static bool TryGetBeverageById(int id, out int amount)
		{
			return default(bool);
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x00014400 File Offset: 0x00012600
		[Token(Token = "0x6003597")]
		[Address(RVA = "0x670AF0", Offset = "0x66F4F0", VA = "0x180670AF0")]
		public static bool TryGetBeverageByTag(out int amount, out IEnumerable<int> ids, int tag = -900)
		{
			return default(bool);
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x00014418 File Offset: 0x00012618
		[Token(Token = "0x6003598")]
		[Address(RVA = "0x670880", Offset = "0x66F280", VA = "0x180670880")]
		public static bool TryGetBeverageByLevel(out int amount, out IEnumerable<int> ids, int level = -900)
		{
			return default(bool);
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003599")]
		[Address(RVA = "0x669480", Offset = "0x667E80", VA = "0x180669480")]
		public static KeyValuePair<Sellable, int>[] GetAllBeverages()
		{
			return null;
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359A")]
		[Address(RVA = "0x669330", Offset = "0x667D30", VA = "0x180669330")]
		public static KeyValuePair<int, int>[] GetAllBeveragesId()
		{
			return null;
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359B")]
		[Address(RVA = "0x6710C0", Offset = "0x66FAC0", VA = "0x1806710C0")]
		private static Predicate<int> TryGetInfiniteIngredientResolver()
		{
			return null;
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x00014430 File Offset: 0x00012630
		[Token(Token = "0x600359C")]
		[Address(RVA = "0x66B3F0", Offset = "0x669DF0", VA = "0x18066B3F0")]
		public static int GetIngredientCountById(int key)
		{
			return 0;
		}

		// Token: 0x0600359D RID: 13725 RVA: 0x00014448 File Offset: 0x00012648
		[Token(Token = "0x600359D")]
		[Address(RVA = "0x667B50", Offset = "0x666550", VA = "0x180667B50")]
		public static int CountIngredient()
		{
			return 0;
		}

		// Token: 0x0600359E RID: 13726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359E")]
		[Address(RVA = "0x66B960", Offset = "0x66A360", VA = "0x18066B960")]
		public static void IngredientInRange(IEnumerable<int> ingredientIds, bool suppressCallbacks = false)
		{
		}

		// Token: 0x0600359F RID: 13727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600359F")]
		[Address(RVA = "0x66BB70", Offset = "0x66A570", VA = "0x18066BB70")]
		public static void IngredientOut(int ingredientId, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A0")]
		[Address(RVA = "0x66BAF0", Offset = "0x66A4F0", VA = "0x18066BAF0")]
		public static void IngredientOutRange(IEnumerable<int> ingredientIds, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035A1")]
		[Address(RVA = "0x666520", Offset = "0x664F20", VA = "0x180666520")]
		public static void ClearAllIngredients()
		{
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x00014460 File Offset: 0x00012660
		[Token(Token = "0x60035A2")]
		[Address(RVA = "0x6712A0", Offset = "0x66FCA0", VA = "0x1806712A0")]
		public static bool TryGetIngredientById(int id, out int amount)
		{
			return default(bool);
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x00014478 File Offset: 0x00012678
		[Token(Token = "0x60035A3")]
		[Address(RVA = "0x6714D0", Offset = "0x66FED0", VA = "0x1806714D0")]
		public static bool TryGetIngredientByTag(out int amount, out IEnumerable<int> ids, int tag = -900)
		{
			return default(bool);
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x00014490 File Offset: 0x00012690
		[Token(Token = "0x60035A4")]
		[Address(RVA = "0x671360", Offset = "0x66FD60", VA = "0x180671360")]
		public static bool TryGetIngredientByLevel(out int amount, out IEnumerable<int> ids, int level = -900)
		{
			return default(bool);
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x000144A8 File Offset: 0x000126A8
		[Token(Token = "0x60035A5")]
		[Address(RVA = "0x667210", Offset = "0x665C10", VA = "0x180667210")]
		public static bool ContainsAllFollowingIngredients(IEnumerable<int> ingredients)
		{
			return default(bool);
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035A6")]
		[Address(RVA = "0x66A060", Offset = "0x668A60", VA = "0x18066A060")]
		public static KeyValuePair<Ingredient, int>[] GetAllIngredients()
		{
			return null;
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x000144C0 File Offset: 0x000126C0
		[Token(Token = "0x60035A7")]
		[Address(RVA = "0x667820", Offset = "0x666220", VA = "0x180667820")]
		public static int CountCooker()
		{
			return 0;
		}

		// Token: 0x060035A8 RID: 13736 RVA: 0x000144D8 File Offset: 0x000126D8
		[Token(Token = "0x60035A8")]
		[Address(RVA = "0x66B6F0", Offset = "0x66A0F0", VA = "0x18066B6F0")]
		public static bool HasCooker(this int cookerId)
		{
			return default(bool);
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x000144F0 File Offset: 0x000126F0
		[Token(Token = "0x60035A9")]
		[Address(RVA = "0x66B210", Offset = "0x669C10", VA = "0x18066B210")]
		public static int GetCookerCountById(int id)
		{
			return 0;
		}

		// Token: 0x060035AA RID: 13738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AA")]
		[Address(RVA = "0x667460", Offset = "0x665E60", VA = "0x180667460")]
		public static void CookerInRange(IEnumerable<int> cookerIds, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035AB RID: 13739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AB")]
		[Address(RVA = "0x6676D0", Offset = "0x6660D0", VA = "0x1806676D0")]
		public static void CookerOut(int cookerId, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035AC RID: 13740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AC")]
		[Address(RVA = "0x667660", Offset = "0x666060", VA = "0x180667660")]
		public static void CookerOutRange(int[] cookerIds, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035AD RID: 13741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035AD")]
		[Address(RVA = "0x6697D0", Offset = "0x6681D0", VA = "0x1806697D0")]
		public static KeyValuePair<Cooker, int>[] GetAllCookers()
		{
			return null;
		}

		// Token: 0x060035AE RID: 13742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AE")]
		[Address(RVA = "0x670590", Offset = "0x66EF90", VA = "0x180670590")]
		public static void SolveGlobalCookCount()
		{
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035AF")]
		[Address(RVA = "0x66FF20", Offset = "0x66E920", VA = "0x18066FF20")]
		public static void SolveCookCount(IEnumerable<Recipe> value, int[] selected)
		{
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x00014508 File Offset: 0x00012708
		[Token(Token = "0x60035B0")]
		[Address(RVA = "0x667BB0", Offset = "0x6665B0", VA = "0x180667BB0")]
		public static int CountItem()
		{
			return 0;
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x00014520 File Offset: 0x00012720
		[Token(Token = "0x60035B1")]
		[Address(RVA = "0x667D00", Offset = "0x666700", VA = "0x180667D00")]
		public static int CountItem(int key)
		{
			return 0;
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x00014538 File Offset: 0x00012738
		[Token(Token = "0x60035B2")]
		[Address(RVA = "0x66B490", Offset = "0x669E90", VA = "0x18066B490")]
		public static int GetItemCountById(int id)
		{
			return 0;
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B3")]
		[Address(RVA = "0x66D460", Offset = "0x66BE60", VA = "0x18066D460")]
		public static void ItemInRange(IEnumerable<int> itemIds, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B4")]
		[Address(RVA = "0x66D150", Offset = "0x66BB50", VA = "0x18066D150")]
		public static void ItemInRangeWithoutDecorationNotice(IEnumerable<int> itemIds)
		{
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B5")]
		[Address(RVA = "0x66D910", Offset = "0x66C310", VA = "0x18066D910")]
		public static void ItemOut(int itemId, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B6")]
		[Address(RVA = "0x66A420", Offset = "0x668E20", VA = "0x18066A420")]
		public static KeyValuePair<Item, int>[] GetAllItems()
		{
			return null;
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B7")]
		[Address(RVA = "0x66A1C0", Offset = "0x668BC0", VA = "0x18066A1C0")]
		public static KeyValuePair<int, int>[] GetAllItemsId()
		{
			return null;
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035B8")]
		[Address(RVA = "0x66D8A0", Offset = "0x66C2A0", VA = "0x18066D8A0")]
		public static void ItemOutRange(IEnumerable<int> itemIds, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x00014550 File Offset: 0x00012750
		[Token(Token = "0x60035B9")]
		[Address(RVA = "0x66B680", Offset = "0x66A080", VA = "0x18066B680")]
		public static bool HasBadge(this int badgeId)
		{
			return default(bool);
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035BA")]
		[Address(RVA = "0x6691A0", Offset = "0x667BA0", VA = "0x1806691A0")]
		public static KeyValuePair<Badge, int>[] GetAllBadges()
		{
			return null;
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BB")]
		[Address(RVA = "0x665CA0", Offset = "0x6646A0", VA = "0x180665CA0")]
		public static void BadgeInRange(IEnumerable<int> badgeIds, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BC")]
		[Address(RVA = "0x665FD0", Offset = "0x6649D0", VA = "0x180665FD0")]
		public static void BadgeOut(int badgeId, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BD")]
		[Address(RVA = "0x665F60", Offset = "0x664960", VA = "0x180665F60")]
		public static void BadgeOutRange(IEnumerable<int> badgeIds, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035BE")]
		[Address(RVA = "0x666590", Offset = "0x664F90", VA = "0x180666590")]
		public static void ClearAllItems()
		{
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x00014568 File Offset: 0x00012768
		[Token(Token = "0x60035BF")]
		[Address(RVA = "0x6673F0", Offset = "0x665DF0", VA = "0x1806673F0")]
		public static bool ContainsItem(int id)
		{
			return default(bool);
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C0")]
		[Address(RVA = "0x6695D0", Offset = "0x667FD0", VA = "0x1806695D0")]
		public static ClothesProfile.Clothes[] GetAllClothes()
		{
			return null;
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C1")]
		[Address(RVA = "0x669BC0", Offset = "0x6685C0", VA = "0x180669BC0")]
		public static Decoration[] GetAllDecorations()
		{
			return null;
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C2")]
		[Address(RVA = "0x66AA70", Offset = "0x669470", VA = "0x18066AA70")]
		public static Record[] GetAllRecords()
		{
			return null;
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C3")]
		[Address(RVA = "0x66AC70", Offset = "0x669670", VA = "0x18066AC70")]
		public static TrophiesProfile.Trophy[] GetAllTrophies()
		{
			return null;
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C4")]
		[Address(RVA = "0x670640", Offset = "0x66F040", VA = "0x180670640")]
		public static void TrophyInRange(int trophy, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x00014580 File Offset: 0x00012780
		[Token(Token = "0x60035C5")]
		[Address(RVA = "0x66B860", Offset = "0x66A260", VA = "0x18066B860")]
		public static bool HasTrophy(int trophy)
		{
			return default(bool);
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C6")]
		[Address(RVA = "0x668660", Offset = "0x667060", VA = "0x180668660")]
		public static void DeleteAllItemsBeforeWork()
		{
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x00014598 File Offset: 0x00012798
		[Token(Token = "0x60035C7")]
		[Address(RVA = "0x66B8E0", Offset = "0x66A2E0", VA = "0x18066B8E0")]
		public static bool HaveRecipe(int recipeId)
		{
			return default(bool);
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x000145B0 File Offset: 0x000127B0
		[Token(Token = "0x60035C8")]
		[Address(RVA = "0x668030", Offset = "0x666A30", VA = "0x180668030")]
		public static int CountRecipes()
		{
			return 0;
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C9")]
		[Address(RVA = "0x66EB30", Offset = "0x66D530", VA = "0x18066EB30")]
		public static void RecipeInRange(IEnumerable<int> recipeIds, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CA")]
		[Address(RVA = "0x66F000", Offset = "0x66DA00", VA = "0x18066F000")]
		public static void RecipeOut(int recipeId)
		{
		}

		// Token: 0x060035CB RID: 13771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CB")]
		[Address(RVA = "0x66EE60", Offset = "0x66D860", VA = "0x18066EE60")]
		public static void RecipeOutRange(int[] recipeIds)
		{
		}

		// Token: 0x060035CC RID: 13772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035CC")]
		[Address(RVA = "0x66A900", Offset = "0x669300", VA = "0x18066A900")]
		public static Recipe[] GetAllRecipes()
		{
			return null;
		}

		// Token: 0x060035CD RID: 13773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035CD")]
		[Address(RVA = "0x65B1D0", Offset = "0x659BD0", VA = "0x18065B1D0")]
		public static IEnumerable<int> GetAllRecipeIndex()
		{
			return null;
		}

		// Token: 0x060035CE RID: 13774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035CE")]
		[Address(RVA = "0x66B560", Offset = "0x669F60", VA = "0x18066B560")]
		public static int[] GetRecipesByCookerType(IEnumerable<Cooker.CookerType> type)
		{
			return null;
		}

		// Token: 0x060035CF RID: 13775 RVA: 0x000145C8 File Offset: 0x000127C8
		[Token(Token = "0x60035CF")]
		[Address(RVA = "0x66B760", Offset = "0x66A160", VA = "0x18066B760")]
		public static bool HasIzakaya(this int id)
		{
			return default(bool);
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D0")]
		[Address(RVA = "0x66DAD0", Offset = "0x66C4D0", VA = "0x18066DAD0")]
		public static void IzakayaIn(int izakayaId, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D1")]
		[Address(RVA = "0x66D970", Offset = "0x66C370", VA = "0x18066D970")]
		public static void IzakayaInRange(IEnumerable<int> izakayaIds)
		{
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035D2")]
		[Address(RVA = "0x66A810", Offset = "0x669210", VA = "0x18066A810")]
		public static IEnumerable<int> GetAllPartners()
		{
			return null;
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x000145E0 File Offset: 0x000127E0
		[Token(Token = "0x60035D3")]
		[Address(RVA = "0x667F10", Offset = "0x666910", VA = "0x180667F10")]
		public static int CountPartner()
		{
			return 0;
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x000145F8 File Offset: 0x000127F8
		[Token(Token = "0x60035D4")]
		[Address(RVA = "0x66B7E0", Offset = "0x66A1E0", VA = "0x18066B7E0")]
		public static bool HasPartner(this int id)
		{
			return default(bool);
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D5")]
		[Address(RVA = "0x66E970", Offset = "0x66D370", VA = "0x18066E970")]
		public static void PartnerIn(int partnerId, bool suppressCallbacks = false)
		{
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035D6")]
		[Address(RVA = "0x66A6A0", Offset = "0x6690A0", VA = "0x18066A6A0")]
		public static Izakaya[] GetAllIzakayas()
		{
			return null;
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D7")]
		[Address(RVA = "0x666EF0", Offset = "0x6658F0", VA = "0x180666EF0")]
		public static void ClearOutdatedFoods()
		{
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D8")]
		[Address(RVA = "0x666980", Offset = "0x665380", VA = "0x180666980")]
		public static void ClearAndDumpPlayerRuntimeData(out RunTimeStorage.RuntimePlayerDataCache cache)
		{
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035D9")]
		[Address(RVA = "0x6680A0", Offset = "0x666AA0", VA = "0x1806680A0")]
		public static RunTimeStorage.RuntimePlayerDataCache CreatePlayerRuntimeDataCache()
		{
			return null;
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DA")]
		[Address(RVA = "0x66DC90", Offset = "0x66C690", VA = "0x18066DC90")]
		public static void MountAndOverridePlayerRuntimeData(RunTimeStorage.RuntimePlayerDataCache cache)
		{
		}

		// Token: 0x04002E6C RID: 11884
		[Token(Token = "0x4002E6C")]
		public const int GREEN_TEA_ID = 0;

		// Token: 0x04002E6D RID: 11885
		[Token(Token = "0x4002E6D")]
		public const int DARK_MATTER_ID = -1;

		// Token: 0x04002E6E RID: 11886
		[Token(Token = "0x4002E6E")]
		public const int RICE_BALL_ID = 7;

		// Token: 0x04002E6F RID: 11887
		[Token(Token = "0x4002E6F")]
		public const int MYSTIA_NORMAL_CLOTHES = -2;

		// Token: 0x04002E70 RID: 11888
		[Token(Token = "0x4002E70")]
		public const int MYSTIA_NORMAL_WORKING_CLOTHES = -1;

		// Token: 0x04002E71 RID: 11889
		[Token(Token = "0x4002E71")]
		public const int MAX_OBJECT_COUNT = 99999;

		// Token: 0x04002E72 RID: 11890
		[Token(Token = "0x4002E72")]
		public const long MAX_FUND_AMOUNT = 99999999L;

		// Token: 0x02000895 RID: 2197
		[Token(Token = "0x2000895")]
		[JsonObject(MemberSerialization.OptIn)]
		public class RuntimePlayerDataCache : IDeepClonable<RunTimeStorage.RuntimePlayerDataCache>
		{
			// Token: 0x17000704 RID: 1796
			// (get) Token: 0x060035DB RID: 13787 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000704")]
			public IEnumerable<KeyValuePair<int, int>> CachedFoods
			{
				[Token(Token = "0x60035DB")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000705 RID: 1797
			// (get) Token: 0x060035DC RID: 13788 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000705")]
			public IEnumerable<KeyValuePair<int, int>> CachedBeverages
			{
				[Token(Token = "0x60035DC")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000706 RID: 1798
			// (get) Token: 0x060035DD RID: 13789 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000706")]
			public IEnumerable<KeyValuePair<int, int>> CachedIngredients
			{
				[Token(Token = "0x60035DD")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000707 RID: 1799
			// (get) Token: 0x060035DE RID: 13790 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000707")]
			public IEnumerable<KeyValuePair<int, int>> CachedCookers
			{
				[Token(Token = "0x60035DE")]
				[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000708 RID: 1800
			// (get) Token: 0x060035DF RID: 13791 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000708")]
			public IEnumerable<KeyValuePair<int, int>> CachedItems
			{
				[Token(Token = "0x60035DF")]
				[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000709 RID: 1801
			// (get) Token: 0x060035E0 RID: 13792 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000709")]
			public IEnumerable<KeyValuePair<int, int>> CachedBadges
			{
				[Token(Token = "0x60035E0")]
				[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x060035E1 RID: 13793 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700070A")]
			public IEnumerable<int> CachedTrophies
			{
				[Token(Token = "0x60035E1")]
				[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700070B RID: 1803
			// (get) Token: 0x060035E2 RID: 13794 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700070B")]
			public IEnumerable<int> CachedItemsDeleteEnterWork
			{
				[Token(Token = "0x60035E2")]
				[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700070C RID: 1804
			// (get) Token: 0x060035E3 RID: 13795 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700070C")]
			public IEnumerable<int> CachedRecipes
			{
				[Token(Token = "0x60035E3")]
				[Address(RVA = "0x440270", Offset = "0x43EC70", VA = "0x180440270")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x060035E4 RID: 13796 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700070D")]
			public IEnumerable<int> CachedIzakayas
			{
				[Token(Token = "0x60035E4")]
				[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x060035E5 RID: 13797 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700070E")]
			public IEnumerable<int> CachedPopLikeFoodTags
			{
				[Token(Token = "0x60035E5")]
				[Address(RVA = "0x48B8D0", Offset = "0x48A2D0", VA = "0x18048B8D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x060035E6 RID: 13798 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700070F")]
			public IEnumerable<int> CachedPopHateFoodTags
			{
				[Token(Token = "0x60035E6")]
				[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000710 RID: 1808
			// (get) Token: 0x060035E7 RID: 13799 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000710")]
			public IEnumerable<int> CachedPartners
			{
				[Token(Token = "0x60035E7")]
				[Address(RVA = "0x440320", Offset = "0x43ED20", VA = "0x180440320")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000711 RID: 1809
			// (get) Token: 0x060035E8 RID: 13800 RVA: 0x00014610 File Offset: 0x00012810
			[Token(Token = "0x17000711")]
			public int CachedLevel
			{
				[Token(Token = "0x60035E8")]
				[Address(RVA = "0x3EBDA0", Offset = "0x3EA7A0", VA = "0x1803EBDA0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000712 RID: 1810
			// (get) Token: 0x060035E9 RID: 13801 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000712")]
			public IEnumerable<KeyValuePair<PlayerSaveFile.DefaultProp, List<int>>> PinnedObjects
			{
				[Token(Token = "0x60035E9")]
				[Address(RVA = "0x4402B0", Offset = "0x43ECB0", VA = "0x1804402B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000713 RID: 1811
			// (get) Token: 0x060035EA RID: 13802 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000713")]
			public IEnumerable<KeyValuePair<int, List<PlayerSaveFile.HistoryIzakayaMenuSelection>>> UserIzakayaPresets
			{
				[Token(Token = "0x60035EA")]
				[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000714 RID: 1812
			// (get) Token: 0x060035EB RID: 13803 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000714")]
			public IEnumerable<ValueTuple<int, PartnerBase.PartnerType>> HistoryPartnerSelection
			{
				[Token(Token = "0x60035EB")]
				[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x060035EC RID: 13804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60035EC")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public RuntimePlayerDataCache()
			{
			}

			// Token: 0x060035ED RID: 13805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60035ED")]
			[Address(RVA = "0x672C20", Offset = "0x671620", VA = "0x180672C20")]
			[JsonConstructor]
			public RuntimePlayerDataCache(KeyValuePair<int, int>[] foods, KeyValuePair<int, int>[] beverages, KeyValuePair<int, int>[] ingredients, KeyValuePair<int, int>[] cookers, KeyValuePair<int, int>[] items, KeyValuePair<int, int>[] badges, int[] trophies, int[] itemsDeleteEnterWork, int[] recipes, int[] izakayas, int[] popLikeFoodTags, int[] popHateFoodTags, int[] partners, int level, Dictionary<PlayerSaveFile.DefaultProp, List<int>> pinnedObjects, Dictionary<int, List<PlayerSaveFile.HistoryIzakayaMenuSelection>> userIzakayaPresets, ValueTuple<int, PartnerBase.PartnerType>[] historyPartnerSelection)
			{
			}

			// Token: 0x060035EE RID: 13806 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60035EE")]
			[Address(RVA = "0x672930", Offset = "0x671330", VA = "0x180672930", Slot = "4")]
			public RunTimeStorage.RuntimePlayerDataCache Clone()
			{
				return null;
			}

			// Token: 0x04002E88 RID: 11912
			[Token(Token = "0x4002E88")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[JsonProperty("Foods")]
			private readonly KeyValuePair<int, int>[] m_Foods;

			// Token: 0x04002E89 RID: 11913
			[Token(Token = "0x4002E89")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[JsonProperty("Beverages")]
			private readonly KeyValuePair<int, int>[] m_Beverages;

			// Token: 0x04002E8A RID: 11914
			[Token(Token = "0x4002E8A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[JsonProperty("Ingredients")]
			private readonly KeyValuePair<int, int>[] m_Ingredients;

			// Token: 0x04002E8B RID: 11915
			[Token(Token = "0x4002E8B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[JsonProperty("Cookers")]
			private readonly KeyValuePair<int, int>[] m_Cookers;

			// Token: 0x04002E8C RID: 11916
			[Token(Token = "0x4002E8C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[JsonProperty("Items")]
			private readonly KeyValuePair<int, int>[] m_Items;

			// Token: 0x04002E8D RID: 11917
			[Token(Token = "0x4002E8D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[JsonProperty("Badges")]
			private readonly KeyValuePair<int, int>[] m_Badges;

			// Token: 0x04002E8E RID: 11918
			[Token(Token = "0x4002E8E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[JsonProperty("Trophies")]
			private readonly int[] m_Trophies;

			// Token: 0x04002E8F RID: 11919
			[Token(Token = "0x4002E8F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[JsonProperty("ItemsDeleteEnterWork")]
			private readonly int[] m_ItemsDeleteEnterWork;

			// Token: 0x04002E90 RID: 11920
			[Token(Token = "0x4002E90")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[JsonProperty("Recipes")]
			private readonly int[] m_Recipes;

			// Token: 0x04002E91 RID: 11921
			[Token(Token = "0x4002E91")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[JsonProperty("Izakayas")]
			private readonly int[] m_Izakayas;

			// Token: 0x04002E92 RID: 11922
			[Token(Token = "0x4002E92")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[JsonProperty("PopLikeFoodTags")]
			private readonly int[] m_PopLikeFoodTags;

			// Token: 0x04002E93 RID: 11923
			[Token(Token = "0x4002E93")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[JsonProperty("PopHateFoodTags")]
			private readonly int[] m_PopHateFoodTags;

			// Token: 0x04002E94 RID: 11924
			[Token(Token = "0x4002E94")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[JsonProperty("Level")]
			private readonly int m_Level;

			// Token: 0x04002E95 RID: 11925
			[Token(Token = "0x4002E95")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[JsonProperty("Partners")]
			private readonly int[] m_Partners;

			// Token: 0x04002E96 RID: 11926
			[Token(Token = "0x4002E96")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[JsonProperty("PinnedObjects")]
			private readonly Dictionary<PlayerSaveFile.DefaultProp, List<int>> m_PinnedObjects;

			// Token: 0x04002E97 RID: 11927
			[Token(Token = "0x4002E97")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[JsonProperty("IzakayaPresets")]
			private readonly Dictionary<int, List<PlayerSaveFile.HistoryIzakayaMenuSelection>> m_UserIzakayaPresets;

			// Token: 0x04002E98 RID: 11928
			[Token(Token = "0x4002E98")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[JsonProperty("HistoryPartnerSelection")]
			private readonly ValueTuple<int, PartnerBase.PartnerType>[] m_HistoryPartnerSelection;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameData.Profile;
using GameData.Profile.SchedulerNodeCollection;
using Il2CppDummyDll;

namespace GameData.Core.Collections
{
	// Token: 0x020008C3 RID: 2243
	[Token(Token = "0x20008C3")]
	public static class DataBaseScheduler
	{
		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060037D8 RID: 14296 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060037D9 RID: 14297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000773")]
		private static Dictionary<string, CGProfile.CGPictureProperty> CGDictionary
		{
			[Token(Token = "0x60037D8")]
			[Address(RVA = "0x683E80", Offset = "0x682880", VA = "0x180683E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60037D9")]
			[Address(RVA = "0x684080", Offset = "0x682A80", VA = "0x180684080")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060037DA RID: 14298 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060037DB RID: 14299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000774")]
		private static Dictionary<string, string> AllNodesMapping
		{
			[Token(Token = "0x60037DA")]
			[Address(RVA = "0x683E00", Offset = "0x682800", VA = "0x180683E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60037DB")]
			[Address(RVA = "0x683FC0", Offset = "0x6829C0", VA = "0x180683FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060037DC RID: 14300 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060037DD RID: 14301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000775")]
		private static Dictionary<string, string> NewsNodesMapping
		{
			[Token(Token = "0x60037DC")]
			[Address(RVA = "0x683F00", Offset = "0x682900", VA = "0x180683F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60037DD")]
			[Address(RVA = "0x684140", Offset = "0x682B40", VA = "0x180684140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060037DE RID: 14302 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060037DF RID: 14303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000776")]
		private static Dictionary<string, string> CGDictionaryMapping
		{
			[Token(Token = "0x60037DE")]
			[Address(RVA = "0x683E40", Offset = "0x682840", VA = "0x180683E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60037DF")]
			[Address(RVA = "0x684020", Offset = "0x682A20", VA = "0x180684020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060037E0 RID: 14304 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060037E1 RID: 14305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000777")]
		public static Dictionary<string, List<SchedulerNode>> DefaultSchedulerData
		{
			[Token(Token = "0x60037E0")]
			[Address(RVA = "0x683EC0", Offset = "0x6828C0", VA = "0x180683EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60037E1")]
			[Address(RVA = "0x6840E0", Offset = "0x682AE0", VA = "0x1806840E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060037E2 RID: 14306 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060037E3 RID: 14307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000778")]
		public static Dictionary<string, ExpandableGameDataPack.SchedulerConnectionData[]> SchedulerConnectionData
		{
			[Token(Token = "0x60037E2")]
			[Address(RVA = "0x683F40", Offset = "0x682940", VA = "0x180683F40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60037E3")]
			[Address(RVA = "0x6841A0", Offset = "0x682BA0", VA = "0x1806841A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060037E4 RID: 14308 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060037E5 RID: 14309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000779")]
		public static Dictionary<string, ExpandableGameDataPack.SchedulerNewsData[]> SchedulerNewsData
		{
			[Token(Token = "0x60037E4")]
			[Address(RVA = "0x683F80", Offset = "0x682980", VA = "0x180683F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60037E5")]
			[Address(RVA = "0x684200", Offset = "0x682C00", VA = "0x180684200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060037E6 RID: 14310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037E6")]
		[Address(RVA = "0x681A70", Offset = "0x680470", VA = "0x180681A70")]
		public static void Initialize(Dictionary<string, DataBaseScheduler.DataBaseSchedulerData> schedulerData, Dictionary<string, ExpandableGameDataPack.SchedulerConnectionData[]> allDlcSchedulerNodeConnections, Dictionary<string, ExpandableGameDataPack.SchedulerNewsData[]> allDlcSchedulerNews)
		{
		}

		// Token: 0x060037E7 RID: 14311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037E7")]
		[Address(RVA = "0x681810", Offset = "0x680210", VA = "0x180681810")]
		public static IEnumerable<SchedulerNode> GetAllNodes()
		{
			return null;
		}

		// Token: 0x060037E8 RID: 14312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037E8")]
		[Address(RVA = "0x6817B0", Offset = "0x6801B0", VA = "0x1806817B0")]
		public static IEnumerable<string> GetAllNodesLabel()
		{
			return null;
		}

		// Token: 0x060037E9 RID: 14313 RVA: 0x000151C8 File Offset: 0x000133C8
		[Token(Token = "0x60037E9")]
		[Address(RVA = "0x683D90", Offset = "0x682790", VA = "0x180683D90")]
		public static bool TargetNodeExists(this string nodeLabel)
		{
			return default(bool);
		}

		// Token: 0x060037EA RID: 14314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037EA")]
		[Address(RVA = "0x683D30", Offset = "0x682730", VA = "0x180683D30")]
		public static SchedulerNode RefNode(this string nodeLabel)
		{
			return null;
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037EB")]
		[Address(RVA = "0x683A60", Offset = "0x682460", VA = "0x180683A60")]
		public static EventNode RefEvent(this string eventLabel)
		{
			return null;
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037EC")]
		[Address(RVA = "0x683B90", Offset = "0x682590", VA = "0x180683B90")]
		public static MissionNode RefMission(this string missionLabel)
		{
			return null;
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037ED")]
		[Address(RVA = "0x683CD0", Offset = "0x6826D0", VA = "0x180683CD0")]
		public static NewsNode RefNews(this string newLabel)
		{
			return null;
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x000151E0 File Offset: 0x000133E0
		[Token(Token = "0x60037EE")]
		[Address(RVA = "0x683940", Offset = "0x682340", VA = "0x180683940")]
		public static bool IsNewsPresent(this string newLabel)
		{
			return default(bool);
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x000151F8 File Offset: 0x000133F8
		[Token(Token = "0x60037EF")]
		[Address(RVA = "0x6839B0", Offset = "0x6823B0", VA = "0x1806839B0")]
		public static CGProfile.CGPictureProperty RefCGPicture(this string cgLabel)
		{
			return default(CGProfile.CGPictureProperty);
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F0")]
		[Address(RVA = "0x6815A0", Offset = "0x67FFA0", VA = "0x1806815A0")]
		public static IEnumerable<CGProfile.CGPictureProperty> GetAllCGPicture()
		{
			return null;
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x00015210 File Offset: 0x00013410
		[Token(Token = "0x60037F1")]
		[Address(RVA = "0x6819F0", Offset = "0x6803F0", VA = "0x1806819F0")]
		public static bool IfThisMissionHaveCG(this string key)
		{
			return default(bool);
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F2")]
		[Address(RVA = "0x681610", Offset = "0x680010", VA = "0x180681610")]
		public static IEnumerable<ValueTuple<SchedulerNode.NodeType, SchedulerNode.SchedulerType, string, string>> GetAllLabels()
		{
			return null;
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F3")]
		[Address(RVA = "0x681750", Offset = "0x680150", VA = "0x180681750")]
		public static IEnumerable<string> GetAllNews()
		{
			return null;
		}

		// Token: 0x060037F4 RID: 14324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F4")]
		[Address(RVA = "0x681970", Offset = "0x680370", VA = "0x180681970")]
		public static string GetSchedulerNodesDLCMapping(this string key)
		{
			return null;
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F5")]
		[Address(RVA = "0x6818F0", Offset = "0x6802F0", VA = "0x1806818F0")]
		public static string GetNewsNodesDLCMapping(this string key)
		{
			return null;
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037F6")]
		[Address(RVA = "0x681870", Offset = "0x680270", VA = "0x180681870")]
		public static string GetCGDictionaryDLCMapping(this string key)
		{
			return null;
		}

		// Token: 0x04002FCB RID: 12235
		[Token(Token = "0x4002FCB")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, SchedulerNode> allNodes;

		// Token: 0x04002FCC RID: 12236
		[Token(Token = "0x4002FCC")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, NewsNode> newsNodes;

		// Token: 0x020008C4 RID: 2244
		[Token(Token = "0x20008C4")]
		public class DataBaseSchedulerData
		{
			// Token: 0x060037F7 RID: 14327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60037F7")]
			[Address(RVA = "0x681360", Offset = "0x67FD60", VA = "0x180681360")]
			public DataBaseSchedulerData(Dictionary<string, SchedulerNode> allNodes, Dictionary<string, NewsNode> newsNodes, Dictionary<string, CGProfile.CGPictureProperty> cGDictionary)
			{
			}

			// Token: 0x1700077A RID: 1914
			// (get) Token: 0x060037F8 RID: 14328 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060037F9 RID: 14329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700077A")]
			internal Dictionary<string, SchedulerNode> AllNodes
			{
				[Token(Token = "0x60037F8")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60037F9")]
				[Address(RVA = "0x4A6ED0", Offset = "0x4A58D0", VA = "0x1804A6ED0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700077B RID: 1915
			// (get) Token: 0x060037FA RID: 14330 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060037FB RID: 14331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700077B")]
			internal Dictionary<string, NewsNode> NewsNodes
			{
				[Token(Token = "0x60037FA")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60037FB")]
				[Address(RVA = "0x3FC090", Offset = "0x3FAA90", VA = "0x1803FC090")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x060037FC RID: 14332 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060037FD RID: 14333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700077C")]
			internal Dictionary<string, CGProfile.CGPictureProperty> CGDictionary
			{
				[Token(Token = "0x60037FC")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60037FD")]
				[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060037FE RID: 14334 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60037FE")]
			[Address(RVA = "0x681350", Offset = "0x67FD50", VA = "0x180681350")]
			[CompilerGenerated]
			internal static SchedulerNode <.ctor>g__GetDuplicatedNode|0_0(SchedulerNode node)
			{
				return null;
			}
		}
	}
}

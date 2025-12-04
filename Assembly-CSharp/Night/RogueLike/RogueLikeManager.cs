using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using DayScene.UI.RogueLike;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using PrepNightScene.UI;

namespace Night.RogueLike
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	public class RogueLikeManager : IPostExtraChecker
	{
		// Token: 0x060006FC RID: 1788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x6F7580", Offset = "0x6F5F80", VA = "0x1806F7580")]
		public RogueLikeManager(RogueLikeRunTimeData rogueLikeRunTimeData, BossData.BossDataContext bossDataContext)
		{
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000084")]
		public RogueLikeRunTimeData RogueLikeRunTimeData
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x17000085")]
		public BossData.BossDataContext BossDataContext
		{
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x6F78F0", Offset = "0x6F62F0", VA = "0x1806F78F0")]
			[CompilerGenerated]
			get
			{
				return default(BossData.BossDataContext);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000086")]
		public EventManager EventManager
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x6F7920", Offset = "0x6F6320", VA = "0x1806F7920")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000087")]
		public GuestsManager GuestsManager
		{
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x6F7970", Offset = "0x6F6370", VA = "0x1806F7970")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00003AC8 File Offset: 0x00001CC8
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000088")]
		public int TargetRequirement
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x477F70", Offset = "0x476970", VA = "0x180477F70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x6F7AA0", Offset = "0x6F64A0", VA = "0x1806F7AA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000089")]
		public List<RogueLikeCardInstance> GainedCards
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x1700008A")]
		public int Funds
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x6F7930", Offset = "0x6F6330", VA = "0x1806F7930")]
			get
			{
				return 0;
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x06000705 RID: 1797 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000706 RID: 1798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000008")]
		public event Action<int> OnCurrentRequireNumChanged
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x6F7840", Offset = "0x6F6240", VA = "0x1806F7840")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x6F79A0", Offset = "0x6F63A0", VA = "0x1806F79A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00003AF8 File Offset: 0x00001CF8
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008B")]
		public UniTask? GachaLoop
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x6F7950", Offset = "0x6F6350", VA = "0x1806F7950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x6F7A50", Offset = "0x6F6450", VA = "0x1806F7A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700008C")]
		public Queue<TriggerCardCondition> GachaCardConditionQueue
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x440500", Offset = "0x43EF00", VA = "0x180440500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008D")]
		public DLC5_RogueLikeCardSelectorPanel DLC5_RogueLikeCardSelectorPanel
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x4BE490", Offset = "0x4BCE90", VA = "0x1804BE490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x4BE690", Offset = "0x4BD090", VA = "0x1804BE690")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00003B10 File Offset: 0x00001D10
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008E")]
		public bool IsCardSelectorPanelOpened
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x48A900", Offset = "0x489300", VA = "0x18048A900")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x48AC70", Offset = "0x489670", VA = "0x18048AC70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700008F")]
		public Queue<RogueLikeCardInstance> SelectedCard
		{
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x428D60", Offset = "0x427760", VA = "0x180428D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x4D2530", Offset = "0x4D0F30", VA = "0x1804D2530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00003B28 File Offset: 0x00001D28
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000090")]
		public int RemainingTime
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x43AEF0", Offset = "0x4398F0", VA = "0x18043AEF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x448380", Offset = "0x446D80", VA = "0x180448380")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00003B40 File Offset: 0x00001D40
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000091")]
		public bool HasWorkEnd
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x6F7990", Offset = "0x6F6390", VA = "0x1806F7990")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x6F7A90", Offset = "0x6F6490", VA = "0x1806F7A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00003B58 File Offset: 0x00001D58
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000092")]
		public bool HasDisposed
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x6F7980", Offset = "0x6F6380", VA = "0x1806F7980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x6F7A80", Offset = "0x6F6480", VA = "0x1806F7A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000093")]
		public Action<RogueLikeManager> OnWorkEndCallback
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x48A680", Offset = "0x489080", VA = "0x18048A680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x4D24D0", Offset = "0x4D0ED0", VA = "0x1804D24D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x6F6D40", Offset = "0x6F5740", VA = "0x1806F6D40")]
		public void ChangeTargetRequirement(int num)
		{
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x6F6D70", Offset = "0x6F5770", VA = "0x1806F6D70")]
		public void Dispose()
		{
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x6F7290", Offset = "0x6F5C90", VA = "0x1806F7290", Slot = "4")]
		public bool PostCheck(out string message)
		{
			return default(bool);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x6F7170", Offset = "0x6F5B70", VA = "0x1806F7170", Slot = "5")]
		public UniTask<bool> OpenReminderAsync(string message)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000094")]
		public UISubPanel<IzakayaConfigPannel> SubPannel
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x48A7A0", Offset = "0x4891A0", VA = "0x18048A7A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x4D2570", Offset = "0x4D0F70", VA = "0x1804D2570")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000095")]
		public RemindSubPanel RemindPanel
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x48A4C0", Offset = "0x488EC0", VA = "0x18048A4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x4D2590", Offset = "0x4D0F90", VA = "0x1804D2590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x6F6F50", Offset = "0x6F5950", VA = "0x1806F6F50")]
		public void EnqueueWorkCard(RogueLikeCardInstance card, List<RogueLikeCardInstance> associatedCards)
		{
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x6F7380", Offset = "0x6F5D80", VA = "0x1806F7380")]
		public UniTask WaitForScorePanelLoad(List<DLC5_RogueLikeCardScorePanel.CardScorePair> cardScorePairs, Action onPanelCloseCallback)
		{
			return default(UniTask);
		}

		// Token: 0x040006B9 RID: 1721
		[Token(Token = "0x40006B9")]
		[FieldOffset(Offset = "0x78")]
		public Action<Dictionary<RogueLikeCardBase.CardType, List<Product>>> OnSettleCardTrigger;

		// Token: 0x040006BC RID: 1724
		[Token(Token = "0x40006BC")]
		[FieldOffset(Offset = "0xA0")]
		public readonly CancellationTokenSource CancellationTokenSource;
	}
}

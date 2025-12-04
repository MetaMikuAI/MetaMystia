using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200041C RID: 1052
	[Token(Token = "0x200041C")]
	[TupleElementNames(new string[] { "unlockedIzakayaInfos", "currentSpot", "unlockAllLevel2Spot", "unlockAllLevel3Spot", null, null })]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeSpotSelectionPanel : UIPanelParam<ValueTuple<IReadOnlyDictionary<string, UnlockedIzakayaInfo>, string, bool, bool>, ValueTuple<string, UnlockedIzakayaInfo>>
	{
		// Token: 0x0600175A RID: 5978 RVA: 0x00008C10 File Offset: 0x00006E10
		[Token(Token = "0x600175A")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600175B")]
		[Address(RVA = "0x468DE0", Offset = "0x4677E0", VA = "0x180468DE0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00008C28 File Offset: 0x00006E28
		[Token(Token = "0x600175C")]
		[Address(RVA = "0x469700", Offset = "0x468100", VA = "0x180469700")]
		private UniTaskVoid OnSelectMap(ValueTuple<string, UnlockedIzakayaInfo> tuple)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600175D")]
		[Address(RVA = "0x4691E0", Offset = "0x467BE0", VA = "0x1804691E0", Slot = "32")]
		protected override void OnPanelOpen([TupleElementNames(new string[] { "unlockedIzakayaInfos", "currentSpot", "unlockAllLevel2Spot", "unlockAllLevel3Spot" })] ValueTuple<IReadOnlyDictionary<string, UnlockedIzakayaInfo>, string, bool, bool> openParam)
		{
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600175E")]
		[Address(RVA = "0x4649A0", Offset = "0x4633A0", VA = "0x1804649A0")]
		private void AddSpotToDataSet(string spotCandidateName, int level)
		{
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600175F")]
		[Address(RVA = "0x43ED60", Offset = "0x43D760", VA = "0x18043ED60", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001760")]
		[Address(RVA = "0x464B80", Offset = "0x463580", VA = "0x180464B80", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001761")]
		[Address(RVA = "0x469A40", Offset = "0x468440", VA = "0x180469A40")]
		public DLC5_RogueLikeSpotSelectionPanel()
		{
		}

		// Token: 0x040015DC RID: 5596
		[Token(Token = "0x40015DC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private DLC5_RogueLikeSpotSelectionPanel.MapConnections[] m_MapConnections;

		// Token: 0x040015DD RID: 5597
		[Token(Token = "0x40015DD")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GridLayoutGroup m_LayoutGroup;

		// Token: 0x040015DE RID: 5598
		[Token(Token = "0x40015DE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject m_ElementPrefab;

		// Token: 0x040015DF RID: 5599
		[Token(Token = "0x40015DF")]
		[FieldOffset(Offset = "0xB0")]
		private StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<string, UnlockedIzakayaInfo>, UIElementCluster, UIButtonSimple> m_Group;

		// Token: 0x040015E0 RID: 5600
		[Token(Token = "0x40015E0")]
		[FieldOffset(Offset = "0xB8")]
		private Dictionary<string, HashSet<string>> m_MapConnectionDictionary;

		// Token: 0x040015E1 RID: 5601
		[Token(Token = "0x40015E1")]
		[FieldOffset(Offset = "0xC0")]
		private readonly List<ValueTuple<string, UnlockedIzakayaInfo>> m_DataSet;

		// Token: 0x040015E2 RID: 5602
		[Token(Token = "0x40015E2")]
		[FieldOffset(Offset = "0xC8")]
		private readonly List<string> m_MapExploredData;

		// Token: 0x0200041D RID: 1053
		[Token(Token = "0x200041D")]
		[Serializable]
		private struct MapConnections
		{
			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x06001764 RID: 5988 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002B4")]
			public string MapName
			{
				[Token(Token = "0x6001764")]
				[Address(RVA = "0x4070A0", Offset = "0x405AA0", VA = "0x1804070A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002B5 RID: 693
			// (get) Token: 0x06001765 RID: 5989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170002B5")]
			public IReadOnlyList<string> MapConnectionsInfo
			{
				[Token(Token = "0x6001765")]
				[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x040015E3 RID: 5603
			[Token(Token = "0x40015E3")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private string m_MapName;

			// Token: 0x040015E4 RID: 5604
			[Token(Token = "0x40015E4")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private string[] m_MapConnections;
		}
	}
}

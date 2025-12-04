using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Common.UI.GlobalMap
{
	// Token: 0x02000F99 RID: 3993
	[Token(Token = "0x2000F99")]
	[RequireComponent(typeof(UIButtonSimple))]
	public class GuideMapController : MonoBehaviour
	{
		// Token: 0x06005DD0 RID: 24016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD0")]
		[Address(RVA = "0x8AE800", Offset = "0x8AD200", VA = "0x1808AE800")]
		private void Awake()
		{
		}

		// Token: 0x14000041 RID: 65
		// (add) Token: 0x06005DD1 RID: 24017 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005DD2 RID: 24018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000041")]
		public event Action<PointerEventData.InputButton, Vector2> OnPointerDownCallback
		{
			[Token(Token = "0x6005DD1")]
			[Address(RVA = "0x8AF860", Offset = "0x8AE260", VA = "0x1808AF860")]
			add
			{
			}
			[Token(Token = "0x6005DD2")]
			[Address(RVA = "0x8AF8A0", Offset = "0x8AE2A0", VA = "0x1808AF8A0")]
			remove
			{
			}
		}

		// Token: 0x14000042 RID: 66
		// (add) Token: 0x06005DD3 RID: 24019 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005DD4 RID: 24020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000042")]
		public event Action<PointerEventData.InputButton, Vector2, Vector2> OnPointerDragCallback
		{
			[Token(Token = "0x6005DD3")]
			[Address(RVA = "0x8AF880", Offset = "0x8AE280", VA = "0x1808AF880")]
			add
			{
			}
			[Token(Token = "0x6005DD4")]
			[Address(RVA = "0x8AF8C0", Offset = "0x8AE2C0", VA = "0x1808AF8C0")]
			remove
			{
			}
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DD5")]
		[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290")]
		public IReadOnlyList<IGuideMapSpot> GetSpotList()
		{
			return null;
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x000207A8 File Offset: 0x0001E9A8
		[Token(Token = "0x6005DD6")]
		[Address(RVA = "0x8AF170", Offset = "0x8ADB70", VA = "0x1808AF170")]
		public int GetTravelCount(IGuideMapSpot from, IGuideMapSpot to)
		{
			return 0;
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DD7")]
		[Address(RVA = "0x8AEEC0", Offset = "0x8AD8C0", VA = "0x1808AEEC0")]
		public IReadOnlyDictionary<GuideMapSpot, int> GetNeighbourDistance(IGuideMapSpot guideMapSpot)
		{
			return null;
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD8")]
		[Address(RVA = "0x8AF410", Offset = "0x8ADE10", VA = "0x1808AF410")]
		public void UpdateGuideMapVisual(Predicate<IGuideMapSpot> activateHandler, Func<IGuideMapSpot, IGuideMapSpot, bool> showPathHandler)
		{
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD9")]
		[Address(RVA = "0x8AF7D0", Offset = "0x8AE1D0", VA = "0x1808AF7D0")]
		public GuideMapController()
		{
		}

		// Token: 0x040056EF RID: 22255
		[Token(Token = "0x40056EF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GuideMapController.MapConnection[] m_MapConnections;

		// Token: 0x040056F0 RID: 22256
		[Token(Token = "0x40056F0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GuideMapSpot[] m_GlobalSpots;

		// Token: 0x040056F1 RID: 22257
		[Token(Token = "0x40056F1")]
		[FieldOffset(Offset = "0x28")]
		private UIButtonSimple m_Button;

		// Token: 0x040056F2 RID: 22258
		[Token(Token = "0x40056F2")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<GuideMapSpot, Dijkstra.DijkstraNode<GuideMapSpot>> m_MapDictionary;

		// Token: 0x040056F3 RID: 22259
		[Token(Token = "0x40056F3")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<Dijkstra.DijkstraNode<GuideMapSpot>> m_NodeMap;

		// Token: 0x040056F4 RID: 22260
		[Token(Token = "0x40056F4")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<GuideMapSpot> m_GlobalSpotSet;

		// Token: 0x040056F5 RID: 22261
		[Token(Token = "0x40056F5")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<GuideMapSpot> m_GuideMapSpots;

		// Token: 0x02000F9A RID: 3994
		[Token(Token = "0x2000F9A")]
		[Serializable]
		private class MapConnection
		{
			// Token: 0x17000D15 RID: 3349
			// (get) Token: 0x06005DDA RID: 24026 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005DDB RID: 24027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000D15")]
			public GuideMapSpot SourceSpot
			{
				[Token(Token = "0x6005DDA")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6005DDB")]
				[Address(RVA = "0x4A6ED0", Offset = "0x4A58D0", VA = "0x1804A6ED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000D16 RID: 3350
			// (get) Token: 0x06005DDC RID: 24028 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005DDD RID: 24029 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000D16")]
			public GuideMapSpot TargetSpot
			{
				[Token(Token = "0x6005DDC")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6005DDD")]
				[Address(RVA = "0x3FC090", Offset = "0x3FAA90", VA = "0x1803FC090")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000D17 RID: 3351
			// (get) Token: 0x06005DDE RID: 24030 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005DDF RID: 24031 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000D17")]
			public Image PathVisual
			{
				[Token(Token = "0x6005DDE")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6005DDF")]
				[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06005DE0 RID: 24032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DE0")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public MapConnection()
			{
			}
		}
	}
}

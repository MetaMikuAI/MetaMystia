using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace GameData.Profile
{
	// Token: 0x02000B91 RID: 2961
	[Token(Token = "0x2000B91")]
	[CreateAssetMenu(fileName = "FlandreHomeFurnitureProfile", menuName = "GameData Profile/FlandreHomeFurnitureProfile", order = 4000)]
	public class FlandreHomeFurnitureProfile : ScriptableObject
	{
		// Token: 0x06004657 RID: 18007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004657")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public FlandreHomeFurnitureProfile()
		{
		}

		// Token: 0x04003EC2 RID: 16066
		[Token(Token = "0x4003EC2")]
		[FieldOffset(Offset = "0x18")]
		public FlandreHomeFurnitureProfile.FlandreHomeFurniture[] flandreHomeFurnitures;

		// Token: 0x04003EC3 RID: 16067
		[Token(Token = "0x4003EC3")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D texture2D;

		// Token: 0x02000B92 RID: 2962
		[Token(Token = "0x2000B92")]
		[Serializable]
		public struct FlandreHomeFurniture
		{
			// Token: 0x06004658 RID: 18008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004658")]
			[Address(RVA = "0x73DE60", Offset = "0x73C860", VA = "0x18073DE60")]
			public FlandreHomeFurniture(int id, string labelInEditor, FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement placement, Vector2Int[] points, GameObject furnitureObject, Sprite previewImage, Vector2 positionInShopUI, int maxNum, int price, FlandreHomeFurnitureProfile.FlandreHomeFurniture.FurnitureType furnitureType)
			{
			}

			// Token: 0x17000A3A RID: 2618
			// (get) Token: 0x06004659 RID: 18009 RVA: 0x00019500 File Offset: 0x00017700
			[Token(Token = "0x17000A3A")]
			public int ID
			{
				[Token(Token = "0x6004659")]
				[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A3B RID: 2619
			// (get) Token: 0x0600465A RID: 18010 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A3B")]
			public string LabelInEditor
			{
				[Token(Token = "0x600465A")]
				[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A3C RID: 2620
			// (get) Token: 0x0600465B RID: 18011 RVA: 0x00019518 File Offset: 0x00017718
			[Token(Token = "0x17000A3C")]
			public FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement PlacementType
			{
				[Token(Token = "0x600465B")]
				[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
				get
				{
					return FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement.Ground;
				}
			}

			// Token: 0x17000A3D RID: 2621
			// (get) Token: 0x0600465C RID: 18012 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A3D")]
			public Vector2Int[] Points
			{
				[Token(Token = "0x600465C")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A3E RID: 2622
			// (get) Token: 0x0600465D RID: 18013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A3E")]
			public GameObject FurnitureObject
			{
				[Token(Token = "0x600465D")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A3F RID: 2623
			// (get) Token: 0x0600465E RID: 18014 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A3F")]
			public Sprite PreviewImage
			{
				[Token(Token = "0x600465E")]
				[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A40 RID: 2624
			// (get) Token: 0x0600465F RID: 18015 RVA: 0x00019530 File Offset: 0x00017730
			[Token(Token = "0x17000A40")]
			public Vector2 PositionInShopUI
			{
				[Token(Token = "0x600465F")]
				[Address(RVA = "0x73DEF0", Offset = "0x73C8F0", VA = "0x18073DEF0")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x17000A41 RID: 2625
			// (get) Token: 0x06004660 RID: 18016 RVA: 0x00019548 File Offset: 0x00017748
			[Token(Token = "0x17000A41")]
			public int MaxNum
			{
				[Token(Token = "0x6004660")]
				[Address(RVA = "0x440570", Offset = "0x43EF70", VA = "0x180440570")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A42 RID: 2626
			// (get) Token: 0x06004661 RID: 18017 RVA: 0x00019560 File Offset: 0x00017760
			[Token(Token = "0x17000A42")]
			public int Price
			{
				[Token(Token = "0x6004661")]
				[Address(RVA = "0x476FF0", Offset = "0x4759F0", VA = "0x180476FF0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A43 RID: 2627
			// (get) Token: 0x06004662 RID: 18018 RVA: 0x00019578 File Offset: 0x00017778
			[Token(Token = "0x17000A43")]
			public FlandreHomeFurnitureProfile.FlandreHomeFurniture.FurnitureType FurnitureTypes
			{
				[Token(Token = "0x6004662")]
				[Address(RVA = "0x4D1E80", Offset = "0x4D0880", VA = "0x1804D1E80")]
				get
				{
					return FlandreHomeFurnitureProfile.FlandreHomeFurniture.FurnitureType.Carpet;
				}
			}

			// Token: 0x06004663 RID: 18019 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004663")]
			[Address(RVA = "0x73DE40", Offset = "0x73C840", VA = "0x18073DE40", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04003EC4 RID: 16068
			[Token(Token = "0x4003EC4")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			[FormerlySerializedAs("mappedItemId")]
			private int id;

			// Token: 0x04003EC5 RID: 16069
			[Token(Token = "0x4003EC5")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private string labelInEditor;

			// Token: 0x04003EC6 RID: 16070
			[Token(Token = "0x4003EC6")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement placement;

			// Token: 0x04003EC7 RID: 16071
			[Token(Token = "0x4003EC7")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Vector2Int[] points;

			// Token: 0x04003EC8 RID: 16072
			[Token(Token = "0x4003EC8")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject furnitureObject;

			// Token: 0x04003EC9 RID: 16073
			[Token(Token = "0x4003EC9")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Sprite previewImage;

			// Token: 0x04003ECA RID: 16074
			[Token(Token = "0x4003ECA")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Vector2 positionInShopUI;

			// Token: 0x04003ECB RID: 16075
			[Token(Token = "0x4003ECB")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private int maxNum;

			// Token: 0x04003ECC RID: 16076
			[Token(Token = "0x4003ECC")]
			[FieldOffset(Offset = "0x3C")]
			[SerializeField]
			private int price;

			// Token: 0x04003ECD RID: 16077
			[Token(Token = "0x4003ECD")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private FlandreHomeFurnitureProfile.FlandreHomeFurniture.FurnitureType furnitureType;

			// Token: 0x02000B93 RID: 2963
			[Token(Token = "0x2000B93")]
			public enum FurnitureType
			{
				// Token: 0x04003ECF RID: 16079
				[Token(Token = "0x4003ECF")]
				[InspectorName("地毯")]
				Carpet,
				// Token: 0x04003ED0 RID: 16080
				[Token(Token = "0x4003ED0")]
				[InspectorName("柜子")]
				Cabinet,
				// Token: 0x04003ED1 RID: 16081
				[Token(Token = "0x4003ED1")]
				[InspectorName("桌子")]
				Table,
				// Token: 0x04003ED2 RID: 16082
				[Token(Token = "0x4003ED2")]
				[InspectorName("椅子")]
				Chair,
				// Token: 0x04003ED3 RID: 16083
				[Token(Token = "0x4003ED3")]
				[InspectorName("床")]
				Bed,
				// Token: 0x04003ED4 RID: 16084
				[Token(Token = "0x4003ED4")]
				[InspectorName("物件")]
				Object,
				// Token: 0x04003ED5 RID: 16085
				[Token(Token = "0x4003ED5")]
				[InspectorName("墙饰")]
				Paint
			}

			// Token: 0x02000B94 RID: 2964
			[Token(Token = "0x2000B94")]
			public enum Placement
			{
				// Token: 0x04003ED7 RID: 16087
				[Token(Token = "0x4003ED7")]
				Ground,
				// Token: 0x04003ED8 RID: 16088
				[Token(Token = "0x4003ED8")]
				Wall,
				// Token: 0x04003ED9 RID: 16089
				[Token(Token = "0x4003ED9")]
				Carpet
			}
		}
	}
}

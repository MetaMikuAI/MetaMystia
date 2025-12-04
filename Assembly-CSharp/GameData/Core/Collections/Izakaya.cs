using System;
using System.Collections.Generic;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections
{
	// Token: 0x020008D2 RID: 2258
	[Token(Token = "0x20008D2")]
	[Serializable]
	public class Izakaya : NonTradableObjectBase
	{
		// Token: 0x0600382A RID: 14378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600382A")]
		[Address(RVA = "0x6850E0", Offset = "0x683AE0", VA = "0x1806850E0")]
		public Izakaya(int id, Vector2Int baseFundRange, Vector2 normalGuestSpanInterval, Izakaya.NormalGuestGroup[] normalGuestPool, float specialGuestGachaInterval, Izakaya.SpecialGuestGroup[] specialGuestPool, int musicPackageIndex, string daySceneMapLabel)
		{
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x0600382B RID: 14379 RVA: 0x00015330 File Offset: 0x00013530
		[Token(Token = "0x17000788")]
		public Vector2Int BaseFundRange
		{
			[Token(Token = "0x600382B")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return default(Vector2Int);
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x0600382C RID: 14380 RVA: 0x00015348 File Offset: 0x00013548
		[Token(Token = "0x17000789")]
		public Vector2 NormalGuestSpanInterval
		{
			[Token(Token = "0x600382C")]
			[Address(RVA = "0x685300", Offset = "0x683D00", VA = "0x180685300")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x0600382D RID: 14381 RVA: 0x00015360 File Offset: 0x00013560
		[Token(Token = "0x1700078A")]
		public bool SpawnPasserbyGuest
		{
			[Token(Token = "0x600382D")]
			[Address(RVA = "0x685340", Offset = "0x683D40", VA = "0x180685340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x0600382E RID: 14382 RVA: 0x00015378 File Offset: 0x00013578
		[Token(Token = "0x1700078B")]
		public Vector2 PasserbyGuestSpanInterval
		{
			[Token(Token = "0x600382E")]
			[Address(RVA = "0x685320", Offset = "0x683D20", VA = "0x180685320")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x0600382F RID: 14383 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003830 RID: 14384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700078C")]
		public Izakaya.NormalGuestGroup[] NormalGuestPool
		{
			[Token(Token = "0x600382F")]
			[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003830")]
			[Address(RVA = "0x4AD3C0", Offset = "0x4ABDC0", VA = "0x1804AD3C0")]
			set
			{
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06003831 RID: 14385 RVA: 0x00015390 File Offset: 0x00013590
		[Token(Token = "0x1700078D")]
		public float SpecialGuestGachaInterval
		{
			[Token(Token = "0x6003831")]
			[Address(RVA = "0x680550", Offset = "0x67EF50", VA = "0x180680550")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06003832 RID: 14386 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003833 RID: 14387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700078E")]
		public Izakaya.SpecialGuestGroup[] SpecialGuestPool
		{
			[Token(Token = "0x6003832")]
			[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003833")]
			[Address(RVA = "0x6086D0", Offset = "0x6070D0", VA = "0x1806086D0")]
			set
			{
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06003834 RID: 14388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078F")]
		public Izakaya.SpecialGuestGroup[] OriginalSpecialGuestPool
		{
			[Token(Token = "0x6003834")]
			[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x06003835 RID: 14389 RVA: 0x000153A8 File Offset: 0x000135A8
		[Token(Token = "0x17000790")]
		public int MusicPackageIndex
		{
			[Token(Token = "0x6003835")]
			[Address(RVA = "0x477F70", Offset = "0x476970", VA = "0x180477F70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06003836 RID: 14390 RVA: 0x000153C0 File Offset: 0x000135C0
		[Token(Token = "0x17000791")]
		public bool MusicPackageOverride
		{
			[Token(Token = "0x6003836")]
			[Address(RVA = "0x6852F0", Offset = "0x683CF0", VA = "0x1806852F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06003837 RID: 14391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000792")]
		public string DaySceneMapLabel
		{
			[Token(Token = "0x6003837")]
			[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06003838 RID: 14392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000793")]
		public string DaySceneMapName
		{
			[Token(Token = "0x6003838")]
			[Address(RVA = "0x685190", Offset = "0x683B90", VA = "0x180685190")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06003839 RID: 14393 RVA: 0x000153D8 File Offset: 0x000135D8
		[Token(Token = "0x17000794")]
		public int IzakayaLevel
		{
			[Token(Token = "0x6003839")]
			[Address(RVA = "0x6851C0", Offset = "0x683BC0", VA = "0x1806851C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x0600383A RID: 14394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000795")]
		public AssetReference MapAssetReference
		{
			[Token(Token = "0x600383A")]
			[Address(RVA = "0x440270", Offset = "0x43EC70", VA = "0x180440270")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x0600383B RID: 14395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000796")]
		public IEnumerable<AssetReference> MapSkinAssetReferences
		{
			[Token(Token = "0x600383B")]
			[Address(RVA = "0x6851D0", Offset = "0x683BD0", VA = "0x1806851D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600383C RID: 14396 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600383D RID: 14397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000797")]
		public ExpandableGameDataPack.AssetReferenceIdPair[] MapSkinAssetReference
		{
			[Token(Token = "0x600383C")]
			[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600383D")]
			[Address(RVA = "0x547AB0", Offset = "0x5464B0", VA = "0x180547AB0")]
			set
			{
			}
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600383E")]
		[Address(RVA = "0x684F20", Offset = "0x683920", VA = "0x180684F20")]
		public AssetReference GetMap(int skinOffset)
		{
			return null;
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600383F")]
		[Address(RVA = "0x684ED0", Offset = "0x6838D0", VA = "0x180684ED0", Slot = "7")]
		public override object Clone()
		{
			return null;
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003840")]
		[Address(RVA = "0x685070", Offset = "0x683A70", VA = "0x180685070", Slot = "8")]
		protected override ObjectLanguageBase GetText(int id)
		{
			return null;
		}

		// Token: 0x04003008 RID: 12296
		[Token(Token = "0x4003008")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector2Int baseFundRange;

		// Token: 0x04003009 RID: 12297
		[Token(Token = "0x4003009")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2 normalGuestSpanInterval;

		// Token: 0x0400300A RID: 12298
		[Token(Token = "0x400300A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool spawnPasserbyGuest;

		// Token: 0x0400300B RID: 12299
		[Token(Token = "0x400300B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector2 passerbyGuestSpanInterval;

		// Token: 0x0400300C RID: 12300
		[Token(Token = "0x400300C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Izakaya.NormalGuestGroup[] normalGuestPool;

		// Token: 0x0400300D RID: 12301
		[Token(Token = "0x400300D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float specialGuestGachaInterval;

		// Token: 0x0400300E RID: 12302
		[Token(Token = "0x400300E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Izakaya.SpecialGuestGroup[] specialGuestPool;

		// Token: 0x0400300F RID: 12303
		[Token(Token = "0x400300F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AssetReference mapAssetReference;

		// Token: 0x04003010 RID: 12304
		[Token(Token = "0x4003010")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ExpandableGameDataPack.AssetReferenceIdPair[] mapSkinAssetReference;

		// Token: 0x04003011 RID: 12305
		[Token(Token = "0x4003011")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int musicPackageIndex;

		// Token: 0x04003012 RID: 12306
		[Token(Token = "0x4003012")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private bool musicPackageOverride;

		// Token: 0x04003013 RID: 12307
		[Token(Token = "0x4003013")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string daySceneMapLabel;

		// Token: 0x04003014 RID: 12308
		[Token(Token = "0x4003014")]
		[FieldOffset(Offset = "0x70")]
		public int guestTableCount;

		// Token: 0x04003015 RID: 12309
		[Token(Token = "0x4003015")]
		[FieldOffset(Offset = "0x74")]
		public int cookTableCount;

		// Token: 0x020008D3 RID: 2259
		[Token(Token = "0x20008D3")]
		[Serializable]
		public class NormalGuestGroup
		{
			// Token: 0x06003841 RID: 14401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003841")]
			[Address(RVA = "0x687800", Offset = "0x686200", VA = "0x180687800")]
			public NormalGuestGroup(int[] data, int weight)
			{
			}

			// Token: 0x17000798 RID: 1944
			// (get) Token: 0x06003842 RID: 14402 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000798")]
			public IEnumerable<IEnumerable<NormalGuest>> Expanded
			{
				[Token(Token = "0x6003842")]
				[Address(RVA = "0x687850", Offset = "0x686250", VA = "0x180687850")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000799 RID: 1945
			// (get) Token: 0x06003843 RID: 14403 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000799")]
			public int[] Data
			{
				[Token(Token = "0x6003843")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700079A RID: 1946
			// (get) Token: 0x06003844 RID: 14404 RVA: 0x000153F0 File Offset: 0x000135F0
			[Token(Token = "0x1700079A")]
			public int Weight
			{
				[Token(Token = "0x6003844")]
				[Address(RVA = "0x403830", Offset = "0x402230", VA = "0x180403830")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04003016 RID: 12310
			[Token(Token = "0x4003016")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private int[] data;

			// Token: 0x04003017 RID: 12311
			[Token(Token = "0x4003017")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private int weight;
		}

		// Token: 0x020008D5 RID: 2261
		[Token(Token = "0x20008D5")]
		[Serializable]
		public class SpecialGuestGroup
		{
			// Token: 0x06003848 RID: 14408 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003848")]
			[Address(RVA = "0x68BC40", Offset = "0x68A640", VA = "0x18068BC40")]
			public SpecialGuestGroup(int groupId, float probPerDraw, bool onlySpawnAfterUnlocking, bool onlySpawnWhenPlaceBeRecorded)
			{
			}

			// Token: 0x1700079B RID: 1947
			// (get) Token: 0x06003849 RID: 14409 RVA: 0x00015408 File Offset: 0x00013608
			[Token(Token = "0x1700079B")]
			public int GroupId
			{
				[Token(Token = "0x6003849")]
				[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700079C RID: 1948
			// (get) Token: 0x0600384A RID: 14410 RVA: 0x00015420 File Offset: 0x00013620
			[Token(Token = "0x1700079C")]
			public float ProbPerDraw
			{
				[Token(Token = "0x600384A")]
				[Address(RVA = "0x517C30", Offset = "0x516630", VA = "0x180517C30")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700079D RID: 1949
			// (get) Token: 0x0600384B RID: 14411 RVA: 0x00015438 File Offset: 0x00013638
			[Token(Token = "0x1700079D")]
			public bool OnlySpawnAfterUnlocking
			{
				[Token(Token = "0x600384B")]
				[Address(RVA = "0x438D10", Offset = "0x437710", VA = "0x180438D10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700079E RID: 1950
			// (get) Token: 0x0600384C RID: 14412 RVA: 0x00015450 File Offset: 0x00013650
			[Token(Token = "0x1700079E")]
			public bool OnlySpawnWhenPlaceBeRecorded
			{
				[Token(Token = "0x600384C")]
				[Address(RVA = "0x477170", Offset = "0x475B70", VA = "0x180477170")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0400301A RID: 12314
			[Token(Token = "0x400301A")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private int groupId;

			// Token: 0x0400301B RID: 12315
			[Token(Token = "0x400301B")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private float probPerDraw;

			// Token: 0x0400301C RID: 12316
			[Token(Token = "0x400301C")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private bool onlySpawnAfterUnlocking;

			// Token: 0x0400301D RID: 12317
			[Token(Token = "0x400301D")]
			[FieldOffset(Offset = "0x19")]
			[SerializeField]
			private bool onlySpawnWhenPlaceBeRecorded;
		}
	}
}

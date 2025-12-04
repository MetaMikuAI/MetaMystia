using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Profile
{
	// Token: 0x02000B95 RID: 2965
	[Token(Token = "0x2000B95")]
	[CreateAssetMenu(fileName = "GameDataProfile", menuName = "GameData Profile/GameDataProfile", order = 0)]
	public class GameDataProfile : ScriptableObject
	{
		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06004664 RID: 18020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A44")]
		public List<string> ActiveDLCLabel
		{
			[Token(Token = "0x6004664")]
			[Address(RVA = "0x73E2B0", Offset = "0x73CCB0", VA = "0x18073E2B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06004665 RID: 18021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A45")]
		[TupleElementNames(new string[] { "DataPack", "IsPrimary" })]
		private Dictionary<string, List<ValueTuple<ExpandableGameDataPack, bool>>> AllGameDataPacks
		{
			[Token(Token = "0x6004665")]
			[Address(RVA = "0x73E450", Offset = "0x73CE50", VA = "0x18073E450")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004666")]
		public IEnumerable<KeyValuePair<string, T[]>> GetAssets<T>(Func<ExpandableGameDataPack, T[]> getAssetCallback)
		{
			return null;
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004667")]
		public IEnumerable<KeyValuePair<string, T>> GetAssets<T>(Func<ExpandableGameDataPack, T> getAssetCallback)
		{
			return null;
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004668")]
		[Address(RVA = "0x73DF10", Offset = "0x73C910", VA = "0x18073DF10")]
		public IEnumerable<KeyValuePair<string, AssetReference>> GetAssets(Func<ExpandableGameDataPack, AssetReference> getAssetCallback)
		{
			return null;
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004669")]
		[Address(RVA = "0x73E040", Offset = "0x73CA40", VA = "0x18073E040")]
		public IEnumerable<KeyValuePair<string, MultiLanguageTextMesh.MultiLanguageAssetReference>> GetAssets(Func<ExpandableGameDataPack, MultiLanguageTextMesh.MultiLanguageAssetReference> getAssetCallback)
		{
			return null;
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600466A")]
		private IEnumerable<KeyValuePair<string, T>> GetAssets<T>(Func<ExpandableGameDataPack, T> getAssetCallback, Func<T, bool> valifyAssetCallback)
		{
			return null;
		}

		// Token: 0x0600466B RID: 18027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600466B")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public GameDataProfile()
		{
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600466D")]
		[Address(RVA = "0x73E170", Offset = "0x73CB70", VA = "0x18073E170")]
		[CompilerGenerated]
		private List<ValueTuple<ExpandableGameDataPack, bool>> <get_AllGameDataPacks>g__GetList|9_0(string dlcKey)
		{
			return null;
		}

		// Token: 0x04003EDA RID: 16090
		[Token(Token = "0x4003EDA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ProfilerMarker s_GetAssets_Profiler;

		// Token: 0x04003EDB RID: 16091
		[Token(Token = "0x4003EDB")]
		[FieldOffset(Offset = "0x18")]
		public ExpandableGameDataPack coreDataPack;

		// Token: 0x04003EDC RID: 16092
		[Token(Token = "0x4003EDC")]
		[FieldOffset(Offset = "0x20")]
		public GameDataProfile.DLCGameDataPack[] dlcGameDataPacks;

		// Token: 0x04003EDD RID: 16093
		[Token(Token = "0x4003EDD")]
		[FieldOffset(Offset = "0x28")]
		public GameDataProfile.SharedGameDataPack[] sharedGameDataPacks;

		// Token: 0x04003EDE RID: 16094
		[Token(Token = "0x4003EDE")]
		[FieldOffset(Offset = "0x30")]
		private List<string> m_ActiveDLCLabel;

		// Token: 0x04003EDF RID: 16095
		[Token(Token = "0x4003EDF")]
		[FieldOffset(Offset = "0x38")]
		[TupleElementNames(new string[] { "DataPack", "IsPrimary" })]
		private Dictionary<string, List<ValueTuple<ExpandableGameDataPack, bool>>> m_AllGameDataPacks;

		// Token: 0x02000B96 RID: 2966
		[Token(Token = "0x2000B96")]
		[Serializable]
		public struct DLCGameDataPack
		{
			// Token: 0x04003EE0 RID: 16096
			[Token(Token = "0x4003EE0")]
			[FieldOffset(Offset = "0x0")]
			public string key;

			// Token: 0x04003EE1 RID: 16097
			[Token(Token = "0x4003EE1")]
			[FieldOffset(Offset = "0x8")]
			public string[] sharedKey;

			// Token: 0x04003EE2 RID: 16098
			[Token(Token = "0x4003EE2")]
			[FieldOffset(Offset = "0x10")]
			public ExpandableGameDataPack dlcGameDataPack;
		}

		// Token: 0x02000B97 RID: 2967
		[Token(Token = "0x2000B97")]
		[Serializable]
		public struct SharedGameDataPack
		{
			// Token: 0x04003EE3 RID: 16099
			[Token(Token = "0x4003EE3")]
			[FieldOffset(Offset = "0x0")]
			public string key;

			// Token: 0x04003EE4 RID: 16100
			[Token(Token = "0x4003EE4")]
			[FieldOffset(Offset = "0x8")]
			public string originKey;

			// Token: 0x04003EE5 RID: 16101
			[Token(Token = "0x4003EE5")]
			[FieldOffset(Offset = "0x10")]
			public ExpandableGameDataPack sharedGameDataPack;
		}
	}
}

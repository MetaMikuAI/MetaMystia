using System;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using GameData;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Common.DataBaseProfiles
{
	// Token: 0x02000FAF RID: 4015
	[Token(Token = "0x2000FAF")]
	[CreateAssetMenu(fileName = "ConcertProfile", menuName = "GameData Profile/ConcertProfile", order = 3)]
	public class ConcertProfile : ScriptableObject
	{
		// Token: 0x06005E6B RID: 24171 RVA: 0x00020988 File Offset: 0x0001EB88
		[Token(Token = "0x6005E6B")]
		[Address(RVA = "0x8C7BD0", Offset = "0x8C65D0", VA = "0x1808C7BD0")]
		public UniTask<ValueTuple<IAssetHandle<Sprite>, IAssetHandle<TextAsset>, IAssetHandle<LoopedBGMPackage>, IGameObjectAssetHandle<CanvasGroup>>> LoadAssets(out float endCGDuration, out bool showLyrics)
		{
			return default(UniTask<ValueTuple<IAssetHandle<Sprite>, IAssetHandle<TextAsset>, IAssetHandle<LoopedBGMPackage>, IGameObjectAssetHandle<CanvasGroup>>>);
		}

		// Token: 0x06005E6C RID: 24172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E6C")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public ConcertProfile()
		{
		}

		// Token: 0x04005760 RID: 22368
		[Token(Token = "0x4005760")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AssetReference _cg;

		// Token: 0x04005761 RID: 22369
		[Token(Token = "0x4005761")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MultiLanguageTextMesh.MultiLanguageAssetReference _lyrics;

		// Token: 0x04005762 RID: 22370
		[Token(Token = "0x4005762")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AssetReference _music;

		// Token: 0x04005763 RID: 22371
		[Token(Token = "0x4005763")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _endCGDuration;

		// Token: 0x04005764 RID: 22372
		[Token(Token = "0x4005764")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _showLyrics;

		// Token: 0x04005765 RID: 22373
		[Token(Token = "0x4005765")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AssetReference _concertPage;
	}
}

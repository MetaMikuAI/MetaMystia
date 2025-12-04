using System;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Profile
{
	// Token: 0x02000B75 RID: 2933
	[Token(Token = "0x2000B75")]
	[CreateAssetMenu(fileName = "CharacterProtrayal", menuName = "GameData Profile/CreateCharacterProtrayal", order = 3)]
	public class CharacterPortrayal : ScriptableObject
	{
		// Token: 0x0600461D RID: 17949 RVA: 0x000193F8 File Offset: 0x000175F8
		[Token(Token = "0x600461D")]
		[Address(RVA = "0x733760", Offset = "0x732160", VA = "0x180733760")]
		private UniTask<IAssetHandle<Sprite>> LoadVisualHandle(int index, AssetLifetime assetLifetime, [Optional] CancellationToken? cancellationToken)
		{
			return default(UniTask<IAssetHandle<Sprite>>);
		}

		// Token: 0x0600461E RID: 17950 RVA: 0x00019410 File Offset: 0x00017610
		[Token(Token = "0x600461E")]
		[Address(RVA = "0x733120", Offset = "0x731B20", VA = "0x180733120")]
		public UniTask<IAssetHandleArray<Sprite>> LoadAllVisualHandles(AssetLifetime assetLifetime, [Optional] CancellationToken? cancellationToken)
		{
			return default(UniTask<IAssetHandleArray<Sprite>>);
		}

		// Token: 0x0600461F RID: 17951 RVA: 0x00019428 File Offset: 0x00017628
		[Token(Token = "0x600461F")]
		[Address(RVA = "0x7331E0", Offset = "0x731BE0", VA = "0x1807331E0")]
		public UniTask<IAssetHandle<Sprite>> LoadNotebookVisual(AssetLifetime assetLifetime, [Optional] CancellationToken? cancellationToken)
		{
			return default(UniTask<IAssetHandle<Sprite>>);
		}

		// Token: 0x06004620 RID: 17952 RVA: 0x00019440 File Offset: 0x00017640
		[Token(Token = "0x6004620")]
		[Address(RVA = "0x733470", Offset = "0x731E70", VA = "0x180733470")]
		public ValueTuple<UniTask<IAssetHandle<Sprite>>, UniTask<IAssetHandle<Sprite>>> LoadSpellPortrayal()
		{
			return default(ValueTuple<UniTask<IAssetHandle<Sprite>>, UniTask<IAssetHandle<Sprite>>>);
		}

		// Token: 0x06004621 RID: 17953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004621")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public CharacterPortrayal()
		{
		}

		// Token: 0x04003DFC RID: 15868
		[Token(Token = "0x4003DFC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int positiveSpellCardFace;

		// Token: 0x04003DFD RID: 15869
		[Token(Token = "0x4003DFD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int negativeSpellCardFace;

		// Token: 0x04003DFE RID: 15870
		[Token(Token = "0x4003DFE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int faceInNoteBook;

		// Token: 0x04003DFF RID: 15871
		[Token(Token = "0x4003DFF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AssetReferenceAtlasedSprite[] m_VisualAssetAtlasReference;
	}
}

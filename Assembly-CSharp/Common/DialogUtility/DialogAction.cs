using System;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Common.DialogUtility
{
	// Token: 0x02000D9D RID: 3485
	[Token(Token = "0x2000D9D")]
	[Serializable]
	public class DialogAction
	{
		// Token: 0x060051CD RID: 20941 RVA: 0x0001DB68 File Offset: 0x0001BD68
		[Token(Token = "0x60051CD")]
		private UniTask<IAssetHandle<T>> LoadAssetAllowNull<T>(AssetReferenceT<T> assetReferenceT) where T : global::UnityEngine.Object
		{
			return default(UniTask<IAssetHandle<T>>);
		}

		// Token: 0x060051CE RID: 20942 RVA: 0x0001DB80 File Offset: 0x0001BD80
		[Token(Token = "0x60051CE")]
		[Address(RVA = "0x7FB7E0", Offset = "0x7FA1E0", VA = "0x1807FB7E0")]
		public UniTask<LoadedDialogActionData> LoadDialogActionData()
		{
			return default(UniTask<LoadedDialogActionData>);
		}

		// Token: 0x060051CF RID: 20943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051CF")]
		[Address(RVA = "0x7FB900", Offset = "0x7FA300", VA = "0x1807FB900")]
		public DialogAction()
		{
		}

		// Token: 0x04004CD6 RID: 19670
		[Token(Token = "0x4004CD6")]
		[FieldOffset(Offset = "0x10")]
		public bool shouldSet;

		// Token: 0x04004CD7 RID: 19671
		[Token(Token = "0x4004CD7")]
		[FieldOffset(Offset = "0x18")]
		public Position[] foregroundCleaning;

		// Token: 0x04004CD8 RID: 19672
		[Token(Token = "0x4004CD8")]
		[FieldOffset(Offset = "0x20")]
		public ActionType actionType;

		// Token: 0x04004CD9 RID: 19673
		[Token(Token = "0x4004CD9")]
		[FieldOffset(Offset = "0x28")]
		public int[] selections;

		// Token: 0x04004CDA RID: 19674
		[Token(Token = "0x4004CDA")]
		[FieldOffset(Offset = "0x30")]
		public int[] jumps;

		// Token: 0x04004CDB RID: 19675
		[Token(Token = "0x4004CDB")]
		[FieldOffset(Offset = "0x38")]
		public int[] prices;

		// Token: 0x04004CDC RID: 19676
		[Token(Token = "0x4004CDC")]
		[FieldOffset(Offset = "0x40")]
		public int index;

		// Token: 0x04004CDD RID: 19677
		[Token(Token = "0x4004CDD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AssetReferenceSprite m_SpriteAsset;

		// Token: 0x04004CDE RID: 19678
		[Token(Token = "0x4004CDE")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AssetReferenceSprite m_SpriteENAsset;

		// Token: 0x04004CDF RID: 19679
		[Token(Token = "0x4004CDF")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AssetReferenceSprite m_SpriteJPAsset;

		// Token: 0x04004CE0 RID: 19680
		[Token(Token = "0x4004CE0")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AssetReferenceSprite m_SpriteKOAsset;

		// Token: 0x04004CE1 RID: 19681
		[Token(Token = "0x4004CE1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AssetReferenceSprite m_SpriteCNTAsset;

		// Token: 0x04004CE2 RID: 19682
		[Token(Token = "0x4004CE2")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AssetReferenceT<Material> m_MaterialAsset;

		// Token: 0x04004CE3 RID: 19683
		[Token(Token = "0x4004CE3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AssetReferenceT<AudioClip> m_AudioAsset;

		// Token: 0x04004CE4 RID: 19684
		[Token(Token = "0x4004CE4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AssetReferenceT<LoopedBGMPackage> m_BgmPackageAsset;
	}
}

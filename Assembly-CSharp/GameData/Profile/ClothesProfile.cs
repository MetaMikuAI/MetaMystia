using System;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Profile
{
	// Token: 0x02000B77 RID: 2935
	[Token(Token = "0x2000B77")]
	[CreateAssetMenu(fileName = "ClothesProfile", menuName = "GameData Profile/CreateClothesProfile", order = 3)]
	public class ClothesProfile : ScriptableObject
	{
		// Token: 0x06004626 RID: 17958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004626")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public ClothesProfile()
		{
		}

		// Token: 0x04003E03 RID: 15875
		[Token(Token = "0x4003E03")]
		[FieldOffset(Offset = "0x18")]
		public ClothesProfile.Clothes[] clothesIndex;

		// Token: 0x04003E04 RID: 15876
		[Token(Token = "0x4003E04")]
		[FieldOffset(Offset = "0x20")]
		public string previewName;

		// Token: 0x02000B78 RID: 2936
		[Token(Token = "0x2000B78")]
		[Serializable]
		public class Clothes
		{
			// Token: 0x17000A1C RID: 2588
			// (get) Token: 0x06004627 RID: 17959 RVA: 0x00019458 File Offset: 0x00017658
			[Token(Token = "0x17000A1C")]
			public bool IsValidVisual
			{
				[Token(Token = "0x6004627")]
				[Address(RVA = "0x7351B0", Offset = "0x733BB0", VA = "0x1807351B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000A1D RID: 2589
			// (get) Token: 0x06004628 RID: 17960 RVA: 0x00019470 File Offset: 0x00017670
			[Token(Token = "0x17000A1D")]
			public bool IsDynamicVisualPortrayal
			{
				[Token(Token = "0x6004628")]
				[Address(RVA = "0x735190", Offset = "0x733B90", VA = "0x180735190")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06004629 RID: 17961 RVA: 0x00019488 File Offset: 0x00017688
			[Token(Token = "0x6004629")]
			[Address(RVA = "0x7350E0", Offset = "0x733AE0", VA = "0x1807350E0")]
			public UniTask<IAssetHandle<Sprite>> LoadOverrideVisual()
			{
				return default(UniTask<IAssetHandle<Sprite>>);
			}

			// Token: 0x0600462A RID: 17962 RVA: 0x000194A0 File Offset: 0x000176A0
			[Token(Token = "0x600462A")]
			[Address(RVA = "0x735030", Offset = "0x733A30", VA = "0x180735030")]
			public UniTask<IAssetHandleArray<Sprite>> LoadOverrideDynamicVisual()
			{
				return default(UniTask<IAssetHandleArray<Sprite>>);
			}

			// Token: 0x0600462B RID: 17963 RVA: 0x000194B8 File Offset: 0x000176B8
			[Token(Token = "0x600462B")]
			[Address(RVA = "0x734F70", Offset = "0x733970", VA = "0x180734F70")]
			public UniTask<IAssetHandle<Sprite>> LoadFirstOverrideDynamicVisual()
			{
				return default(UniTask<IAssetHandle<Sprite>>);
			}

			// Token: 0x0600462C RID: 17964 RVA: 0x000194D0 File Offset: 0x000176D0
			[Token(Token = "0x600462C")]
			[Address(RVA = "0x734F50", Offset = "0x733950", VA = "0x180734F50")]
			public int ChangeTypeToInt(CharacterSkinSets.SkinSelectionInfo skin)
			{
				return 0;
			}

			// Token: 0x0600462D RID: 17965 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600462D")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public Clothes()
			{
			}

			// Token: 0x04003E05 RID: 15877
			[Token(Token = "0x4003E05")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public CharacterSkinSets.SkinSelectionInfo skinIndex;

			// Token: 0x04003E06 RID: 15878
			[Token(Token = "0x4003E06")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public int index;

			// Token: 0x04003E07 RID: 15879
			[Token(Token = "0x4003E07")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			public int izakayaSkinIndex;

			// Token: 0x04003E08 RID: 15880
			[Token(Token = "0x4003E08")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			public AssetReferenceSprite m_OverrideVisualAsset;

			// Token: 0x04003E09 RID: 15881
			[Token(Token = "0x4003E09")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			public AssetReferenceSprite[] m_OverrideDynamicVisualAsset;

			// Token: 0x04003E0A RID: 15882
			[Token(Token = "0x4003E0A")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			public float frameTime;

			// Token: 0x04003E0B RID: 15883
			[Token(Token = "0x4003E0B")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			public float izkayaHorizontalOffset;

			// Token: 0x04003E0C RID: 15884
			[Token(Token = "0x4003E0C")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			public float notebookHorizontalOffset;

			// Token: 0x04003E0D RID: 15885
			[Token(Token = "0x4003E0D")]
			[FieldOffset(Offset = "0x3C")]
			[SerializeField]
			public float notebookVerticalOffset;

			// Token: 0x04003E0E RID: 15886
			[Token(Token = "0x4003E0E")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			public Vector2 notebookUITitleOffset;
		}
	}
}

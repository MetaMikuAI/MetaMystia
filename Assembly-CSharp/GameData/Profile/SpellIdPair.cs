using System;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Profile
{
	// Token: 0x02000CA5 RID: 3237
	[Token(Token = "0x2000CA5")]
	[Serializable]
	public class SpellIdPair
	{
		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06004B80 RID: 19328 RVA: 0x0001B3F0 File Offset: 0x000195F0
		[Token(Token = "0x17000AD4")]
		public bool HasSpell
		{
			[Token(Token = "0x6004B80")]
			[Address(RVA = "0x783AD0", Offset = "0x7824D0", VA = "0x180783AD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004B81 RID: 19329 RVA: 0x0001B408 File Offset: 0x00019608
		[Token(Token = "0x6004B81")]
		[Address(RVA = "0x783A20", Offset = "0x782420", VA = "0x180783A20")]
		public UniTask<IAssetHandle<SpellBase>> LoadSpellAssetAsync()
		{
			return default(UniTask<IAssetHandle<SpellBase>>);
		}

		// Token: 0x06004B82 RID: 19330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B82")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public SpellIdPair()
		{
		}

		// Token: 0x0400456B RID: 17771
		[Token(Token = "0x400456B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public int guestId;

		// Token: 0x0400456C RID: 17772
		[Token(Token = "0x400456C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public bool notShowInNotebook;

		// Token: 0x0400456D RID: 17773
		[Token(Token = "0x400456D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AssetReferenceT<SpellBase> m_SpellAsset;
	}
}

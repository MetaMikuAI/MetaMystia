using System;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Common.DialogUtility
{
	// Token: 0x02000D9B RID: 3483
	[Token(Token = "0x2000D9B")]
	[Serializable]
	public struct DialogMeta
	{
		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060051BD RID: 20925 RVA: 0x0001DB08 File Offset: 0x0001BD08
		[Token(Token = "0x17000B95")]
		public bool OverrideSpriteValid
		{
			[Token(Token = "0x60051BD")]
			[Address(RVA = "0x7FC420", Offset = "0x7FAE20", VA = "0x1807FC420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060051BE RID: 20926 RVA: 0x0001DB20 File Offset: 0x0001BD20
		[Token(Token = "0x60051BE")]
		[Address(RVA = "0x7FC300", Offset = "0x7FAD00", VA = "0x1807FC300")]
		public UniTask<IAssetHandle<Sprite>> LoadOverrideSprite()
		{
			return default(UniTask<IAssetHandle<Sprite>>);
		}

		// Token: 0x04004CC8 RID: 19656
		[Token(Token = "0x4004CC8")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public int dialogId;

		// Token: 0x04004CC9 RID: 19657
		[Token(Token = "0x4004CC9")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public DialogAction[] dialogAction;

		// Token: 0x04004CCA RID: 19658
		[Token(Token = "0x4004CCA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public SpeakerIdentity speakerIdentity;

		// Token: 0x04004CCB RID: 19659
		[Token(Token = "0x4004CCB")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		public Position speakerPosition;

		// Token: 0x04004CCC RID: 19660
		[Token(Token = "0x4004CCC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public bool isSpeakInForeground;

		// Token: 0x04004CCD RID: 19661
		[Token(Token = "0x4004CCD")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		public bool isDark;

		// Token: 0x04004CCE RID: 19662
		[Token(Token = "0x4004CCE")]
		[FieldOffset(Offset = "0x22")]
		[SerializeField]
		public bool useNameInText;

		// Token: 0x04004CCF RID: 19663
		[Token(Token = "0x4004CCF")]
		[FieldOffset(Offset = "0x23")]
		[SerializeField]
		public bool useOverrideSprite;

		// Token: 0x04004CD0 RID: 19664
		[Token(Token = "0x4004CD0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public AssetReferenceSprite m_OverrideSpriteAsset;
	}
}

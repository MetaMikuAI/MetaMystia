using System;
using System.Runtime.InteropServices;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.DialogUtility
{
	// Token: 0x02000D9C RID: 3484
	[Token(Token = "0x2000D9C")]
	public class LoadedDialogActionData : IDisposable
	{
		// Token: 0x060051BF RID: 20927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051BF")]
		[Address(RVA = "0x7FF100", Offset = "0x7FDB00", VA = "0x1807FF100")]
		private LoadedDialogActionData(DialogAction dialogActionData, [Optional] IAssetHandle<Sprite> loadedSprite, [Optional] IAssetHandle<Material> loadedMaterial, [Optional] IAssetHandle<AudioClip> loadedAudio, [Optional] IAssetHandle<LoopedBGMPackage> loadedBgmPackage)
		{
		}

		// Token: 0x060051C0 RID: 20928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C0")]
		[Address(RVA = "0x46BA70", Offset = "0x46A470", VA = "0x18046BA70")]
		private LoadedDialogActionData(DialogAction dialogActionData)
		{
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x060051C1 RID: 20929 RVA: 0x0001DB38 File Offset: 0x0001BD38
		[Token(Token = "0x17000B96")]
		public ActionType DialogActionType
		{
			[Token(Token = "0x60051C1")]
			[Address(RVA = "0x7FF190", Offset = "0x7FDB90", VA = "0x1807FF190")]
			get
			{
				return ActionType.ForegroundCleaning;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x060051C2 RID: 20930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B97")]
		public int[] DialogSelections
		{
			[Token(Token = "0x60051C2")]
			[Address(RVA = "0x7FF1F0", Offset = "0x7FDBF0", VA = "0x1807FF1F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x060051C3 RID: 20931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B98")]
		public int[] DialogJumps
		{
			[Token(Token = "0x60051C3")]
			[Address(RVA = "0x7FF1B0", Offset = "0x7FDBB0", VA = "0x1807FF1B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x060051C4 RID: 20932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B99")]
		public int[] DialogPrices
		{
			[Token(Token = "0x60051C4")]
			[Address(RVA = "0x7FF1D0", Offset = "0x7FDBD0", VA = "0x1807FF1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x060051C5 RID: 20933 RVA: 0x0001DB50 File Offset: 0x0001BD50
		[Token(Token = "0x17000B9A")]
		public int Index
		{
			[Token(Token = "0x60051C5")]
			[Address(RVA = "0x7FF210", Offset = "0x7FDC10", VA = "0x1807FF210")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C6")]
		[Address(RVA = "0x7FE970", Offset = "0x7FD370", VA = "0x1807FE970", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051C7")]
		[Address(RVA = "0x7FEA00", Offset = "0x7FD400", VA = "0x1807FEA00")]
		public void Run(DialogPannel dialogModuleUI)
		{
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C8")]
		[Address(RVA = "0x7FE830", Offset = "0x7FD230", VA = "0x1807FE830")]
		public static LoadedDialogActionData CreateDefault(DialogAction dialogAction)
		{
			return null;
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051C9")]
		[Address(RVA = "0x7FE5C0", Offset = "0x7FCFC0", VA = "0x1807FE5C0")]
		public static LoadedDialogActionData CreateBg(DialogAction dialogAction, IAssetHandle<Sprite> bgAssetHandle, IAssetHandle<Material> materialAssetHandle)
		{
			return null;
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051CA")]
		[Address(RVA = "0x7FE760", Offset = "0x7FD160", VA = "0x1807FE760")]
		public static LoadedDialogActionData CreateCg(DialogAction dialogAction, IAssetHandle<Sprite> cgAssetHandle, IAssetHandle<Material> materialAssetHandle)
		{
			return null;
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051CB")]
		[Address(RVA = "0x7FE690", Offset = "0x7FD090", VA = "0x1807FE690")]
		public static LoadedDialogActionData CreateBgm(DialogAction dialogAction, IAssetHandle<LoopedBGMPackage> bgmAssetHandle)
		{
			return null;
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60051CC")]
		[Address(RVA = "0x7FE8A0", Offset = "0x7FD2A0", VA = "0x1807FE8A0")]
		public static LoadedDialogActionData CreateSound(DialogAction dialogAction, IAssetHandle<AudioClip> soundAssetHandle)
		{
			return null;
		}

		// Token: 0x04004CD1 RID: 19665
		[Token(Token = "0x4004CD1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly DialogAction m_DialogActionData;

		// Token: 0x04004CD2 RID: 19666
		[Token(Token = "0x4004CD2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IAssetHandle<AudioClip> m_LoadedAudio;

		// Token: 0x04004CD3 RID: 19667
		[Token(Token = "0x4004CD3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly IAssetHandle<LoopedBGMPackage> m_LoadedBgmPackage;

		// Token: 0x04004CD4 RID: 19668
		[Token(Token = "0x4004CD4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly IAssetHandle<Material> m_LoadedMaterial;

		// Token: 0x04004CD5 RID: 19669
		[Token(Token = "0x4004CD5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IAssetHandle<Sprite> m_LoadedSprite;
	}
}

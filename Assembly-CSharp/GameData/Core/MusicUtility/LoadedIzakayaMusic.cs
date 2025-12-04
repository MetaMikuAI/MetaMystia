using System;
using System.Runtime.CompilerServices;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppDummyDll;

namespace GameData.Core.MusicUtility
{
	// Token: 0x020008B3 RID: 2227
	[Token(Token = "0x20008B3")]
	public class LoadedIzakayaMusic : Singleton<LoadedIzakayaMusic>
	{
		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060036C7 RID: 14023 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036C8 RID: 14024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000727")]
		private IzakayaMusicProfile MusicProfile
		{
			[Token(Token = "0x60036C7")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036C8")]
			[Address(RVA = "0x3FC090", Offset = "0x3FAA90", VA = "0x1803FC090")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036C9")]
		[Address(RVA = "0x665630", Offset = "0x664030", VA = "0x180665630")]
		public long[] GetEntry()
		{
			return null;
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CA")]
		[Address(RVA = "0x665870", Offset = "0x664270", VA = "0x180665870")]
		public void SetValue(IzakayaMusicProfile loadedMusicPackages, int musicIndex = -1)
		{
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036CB")]
		[Address(RVA = "0x6656A0", Offset = "0x6640A0", VA = "0x1806656A0")]
		public IzakayaMusic.MusicChannelPackage[] GetPackages()
		{
			return null;
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CC")]
		[Address(RVA = "0x6657E0", Offset = "0x6641E0", VA = "0x1806657E0", Slot = "4")]
		protected override void OnDispose()
		{
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CD")]
		[Address(RVA = "0x665890", Offset = "0x664290", VA = "0x180665890")]
		public LoadedIzakayaMusic()
		{
		}

		// Token: 0x04002F4A RID: 12106
		[Token(Token = "0x4002F4A")]
		[FieldOffset(Offset = "0x10")]
		private int musicIndex;
	}
}

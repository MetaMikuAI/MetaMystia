using System;
using System.Runtime.CompilerServices;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Music
{
	// Token: 0x02000546 RID: 1350
	[Token(Token = "0x2000546")]
	[GenerateCleanupMethod]
	public class AudioManager : MonoSingleton<AudioManager>
	{
		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DEF RID: 7663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E4")]
		public LoopedBGMPackage CurrentActiveBGMPackage
		{
			[Token(Token = "0x6001DEE")]
			[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DEF")]
			[Address(RVA = "0x4AD3C0", Offset = "0x4ABDC0", VA = "0x1804AD3C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x06001DF0 RID: 7664 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001DF1 RID: 7665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000D")]
		public event Action OnLastLoopedBGMStoped
		{
			[Token(Token = "0x6001DF0")]
			[Address(RVA = "0x4AD280", Offset = "0x4ABC80", VA = "0x1804AD280")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001DF1")]
			[Address(RVA = "0x4AD320", Offset = "0x4ABD20", VA = "0x1804AD320")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF2")]
		[Address(RVA = "0x4ACA60", Offset = "0x4AB460", VA = "0x1804ACA60")]
		public void Initialize()
		{
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF3")]
		[Address(RVA = "0x4AC790", Offset = "0x4AB190", VA = "0x1804AC790")]
		public void Dispose()
		{
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF4")]
		[Address(RVA = "0x4ACBA0", Offset = "0x4AB5A0", VA = "0x1804ACBA0", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF5")]
		[Address(RVA = "0x4AC990", Offset = "0x4AB390", VA = "0x1804AC990")]
		public void FadeMainBGM()
		{
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF6")]
		[Address(RVA = "0x4ACEC0", Offset = "0x4AB8C0", VA = "0x1804ACEC0")]
		public void RestoreMainBGM()
		{
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF7")]
		[Address(RVA = "0x4ACBF0", Offset = "0x4AB5F0", VA = "0x1804ACBF0")]
		public void PlayLoopedBGM(LoopedBGMPackage loopedBGMPackage)
		{
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF8")]
		[Address(RVA = "0x4AC8C0", Offset = "0x4AB2C0", VA = "0x1804AC8C0")]
		public void FadeBGM()
		{
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF9")]
		[Address(RVA = "0x4ACFA0", Offset = "0x4AB9A0", VA = "0x1804ACFA0")]
		public void StopBGM()
		{
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFA")]
		[Address(RVA = "0x4ACF90", Offset = "0x4AB990", VA = "0x1804ACF90")]
		private void SetMusicVolume(float value)
		{
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFB")]
		[Address(RVA = "0x4AD140", Offset = "0x4ABB40", VA = "0x1804AD140")]
		private void UpdateMusicVolume()
		{
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFC")]
		[Address(RVA = "0x4AD130", Offset = "0x4ABB30", VA = "0x1804AD130")]
		private void UpdateMusicVolumeMultiplier(float targetMultiplier)
		{
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFD")]
		[Address(RVA = "0x4AD120", Offset = "0x4ABB20", VA = "0x1804AD120")]
		private void UpdateMusicOverrideVolumeMultiplier(float targetMultiplier)
		{
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFE")]
		[Address(RVA = "0x4AD110", Offset = "0x4ABB10", VA = "0x1804AD110")]
		public void UpdateMusicOverrideOverrideVolumeMultiplier(float targetMultiplier)
		{
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DFF")]
		[Address(RVA = "0x4AC730", Offset = "0x4AB130", VA = "0x1804AC730", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E00")]
		[Address(RVA = "0x4AD230", Offset = "0x4ABC30", VA = "0x1804AD230")]
		public AudioManager()
		{
		}

		// Token: 0x04001BAB RID: 7083
		[Token(Token = "0x4001BAB")]
		private const double MUSIC_START_OFFSET = 0.5;

		// Token: 0x04001BAC RID: 7084
		[Token(Token = "0x4001BAC")]
		private const float MUSIC_FADE_DURATION = 1f;

		// Token: 0x04001BAD RID: 7085
		[Token(Token = "0x4001BAD")]
		[FieldOffset(Offset = "0x18")]
		public AudioSource introPlayer;

		// Token: 0x04001BAE RID: 7086
		[Token(Token = "0x4001BAE")]
		[FieldOffset(Offset = "0x20")]
		public AudioSource loopPlayer;

		// Token: 0x04001BAF RID: 7087
		[Token(Token = "0x4001BAF")]
		[FieldOffset(Offset = "0x28")]
		private float musicMainVolume;

		// Token: 0x04001BB0 RID: 7088
		[Token(Token = "0x4001BB0")]
		[FieldOffset(Offset = "0x2C")]
		private float musicOverrideOverrideVolumeMultiplier;

		// Token: 0x04001BB1 RID: 7089
		[Token(Token = "0x4001BB1")]
		[FieldOffset(Offset = "0x30")]
		private float musicOverrideVolumeMultiplier;

		// Token: 0x04001BB2 RID: 7090
		[Token(Token = "0x4001BB2")]
		[FieldOffset(Offset = "0x34")]
		private float musicVolumeMultiplier;
	}
}

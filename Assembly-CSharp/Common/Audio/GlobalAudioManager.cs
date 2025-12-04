using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.Audio
{
	// Token: 0x02000FA3 RID: 4003
	[Token(Token = "0x2000FA3")]
	public class GlobalAudioManager : MonoSingletonPersistant<GlobalAudioManager>
	{
		// Token: 0x06005E2B RID: 24107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2B")]
		[Address(RVA = "0x8AE370", Offset = "0x8ACD70", VA = "0x1808AE370")]
		private void Update()
		{
		}

		// Token: 0x06005E2C RID: 24108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2C")]
		[Address(RVA = "0x8ACEE0", Offset = "0x8AB8E0", VA = "0x1808ACEE0", Slot = "6")]
		protected override void OnAwake()
		{
		}

		// Token: 0x06005E2D RID: 24109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2D")]
		[Address(RVA = "0x8AE290", Offset = "0x8ACC90", VA = "0x1808AE290")]
		private void UpdateSFXVolume(float targetVolume)
		{
		}

		// Token: 0x06005E2E RID: 24110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E2E")]
		[Address(RVA = "0x8AE200", Offset = "0x8ACC00", VA = "0x1808AE200")]
		private void UpdateBGMVolume(float targetVolume)
		{
		}

		// Token: 0x06005E2F RID: 24111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E2F")]
		[Address(RVA = "0x8AC8B0", Offset = "0x8AB2B0", VA = "0x1808AC8B0")]
		public string GetSystemString()
		{
			return null;
		}

		// Token: 0x06005E30 RID: 24112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E30")]
		[Address(RVA = "0x8AC6C0", Offset = "0x8AB0C0", VA = "0x1808AC6C0")]
		private AudioSource GetIdle(out bool temp)
		{
			return null;
		}

		// Token: 0x06005E31 RID: 24113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E31")]
		[Address(RVA = "0x8AD280", Offset = "0x8ABC80", VA = "0x1808AD280")]
		public void PlayLoopedSFX(global::UnityEngine.Object identifier, LoopedBGMPackage loopedBGMPackage)
		{
		}

		// Token: 0x06005E32 RID: 24114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E32")]
		[Address(RVA = "0x8AD850", Offset = "0x8AC250", VA = "0x1808AD850")]
		private void Release(GlobalAudioManager.WorkingLoopedSFX workingLoopedSFX)
		{
		}

		// Token: 0x06005E33 RID: 24115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E33")]
		[Address(RVA = "0x8ADEC0", Offset = "0x8AC8C0", VA = "0x1808ADEC0")]
		private void SetSourceVolume(float progress, AudioSource componentA, AudioSource componentB)
		{
		}

		// Token: 0x06005E34 RID: 24116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E34")]
		[Address(RVA = "0x8ACE20", Offset = "0x8AB820", VA = "0x1808ACE20")]
		public void MuteAllLoopedSFX()
		{
		}

		// Token: 0x06005E35 RID: 24117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E35")]
		[Address(RVA = "0x8ADA50", Offset = "0x8AC450", VA = "0x1808ADA50")]
		public void RestoreAllLoopedSFX()
		{
		}

		// Token: 0x06005E36 RID: 24118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E36")]
		[Address(RVA = "0x8ADCB0", Offset = "0x8AC6B0", VA = "0x1808ADCB0")]
		private void SetAllLoopedSFXVolume(float volume)
		{
		}

		// Token: 0x06005E37 RID: 24119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E37")]
		[Address(RVA = "0x8ADF10", Offset = "0x8AC910", VA = "0x1808ADF10")]
		public void StopAllLoopedSFX()
		{
		}

		// Token: 0x06005E38 RID: 24120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E38")]
		[Address(RVA = "0x8AE250", Offset = "0x8ACC50", VA = "0x1808AE250")]
		public void UpdateEntry(Action onFadeMainBGMCallback, Action onRestoreMainBGMCallback)
		{
		}

		// Token: 0x06005E39 RID: 24121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E39")]
		[Address(RVA = "0x8AD6C0", Offset = "0x8AC0C0", VA = "0x1808AD6C0")]
		public void Play(AudioClip audioClip)
		{
		}

		// Token: 0x06005E3A RID: 24122 RVA: 0x000208E0 File Offset: 0x0001EAE0
		[Token(Token = "0x6005E3A")]
		[Address(RVA = "0x8AD440", Offset = "0x8ABE40", VA = "0x1808AD440")]
		public ValueTuple<AudioSource, AudioSource> PlayOverrideBGM(LoopedBGMPackage bgmPackage)
		{
			return default(ValueTuple<AudioSource, AudioSource>);
		}

		// Token: 0x06005E3B RID: 24123 RVA: 0x000208F8 File Offset: 0x0001EAF8
		[Token(Token = "0x6005E3B")]
		[Address(RVA = "0x8AD480", Offset = "0x8ABE80", VA = "0x1808AD480")]
		public ValueTuple<AudioSource, AudioSource> PlayOverrideBGM(LoopedBGMPackage bgmPackage, double delay, bool instantSwitch)
		{
			return default(ValueTuple<AudioSource, AudioSource>);
		}

		// Token: 0x06005E3C RID: 24124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E3C")]
		[Address(RVA = "0x8AD1C0", Offset = "0x8ABBC0", VA = "0x1808AD1C0")]
		public void PauseOverrideBGM()
		{
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E3D")]
		[Address(RVA = "0x8ADB20", Offset = "0x8AC520", VA = "0x1808ADB20")]
		public void ResumeOverrideBGM(double delay)
		{
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E3E")]
		[Address(RVA = "0x8AE1C0", Offset = "0x8ACBC0", VA = "0x1808AE1C0")]
		public void StopOverrideBGM([Optional] Action onFinish)
		{
		}

		// Token: 0x06005E3F RID: 24127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E3F")]
		[Address(RVA = "0x8AE0B0", Offset = "0x8ACAB0", VA = "0x1808AE0B0")]
		private void StopOverrideBGMInternal(Action onFinish, bool instantSwitch)
		{
		}

		// Token: 0x06005E40 RID: 24128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E40")]
		[Address(RVA = "0x8AC620", Offset = "0x8AB020", VA = "0x1808AC620")]
		public void FadeOverrideBGM()
		{
		}

		// Token: 0x06005E41 RID: 24129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E41")]
		[Address(RVA = "0x8ADB10", Offset = "0x8AC510", VA = "0x1808ADB10")]
		public void RestoreOverrideBGM()
		{
		}

		// Token: 0x06005E42 RID: 24130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E42")]
		[Address(RVA = "0x8ADE60", Offset = "0x8AC860", VA = "0x1808ADE60")]
		private void SetOverrideBGMMultiplier(float multiplier)
		{
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E43")]
		[Address(RVA = "0x8AC530", Offset = "0x8AAF30", VA = "0x1808AC530")]
		private void FadeOverrideBGMInternal(GlobalAudioManager.FadeType fadeType, Action onFinishCallback)
		{
		}

		// Token: 0x06005E44 RID: 24132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E44")]
		[Address(RVA = "0x8AC440", Offset = "0x8AAE40", VA = "0x1808AC440")]
		private void FadeAudioSource(object extraIndentifier, GlobalAudioManager.FadeType fadeType, float startVolume, Action<float> updateAudioSourceCallback, Action onFinishCallback)
		{
		}

		// Token: 0x06005E45 RID: 24133 RVA: 0x00020910 File Offset: 0x0001EB10
		[Token(Token = "0x6005E45")]
		[Address(RVA = "0x8AC630", Offset = "0x8AB030", VA = "0x1808AC630")]
		private int GetHash(object extraIndentifier)
		{
			return 0;
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E46")]
		[Address(RVA = "0x8AE620", Offset = "0x8AD020", VA = "0x1808AE620")]
		public GlobalAudioManager()
		{
		}

		// Token: 0x0400572E RID: 22318
		[Token(Token = "0x400572E")]
		private const int MaxAudioSources = 10;

		// Token: 0x0400572F RID: 22319
		[Token(Token = "0x400572F")]
		public const float MUSIC_FADE_DURATION = 0.5f;

		// Token: 0x04005730 RID: 22320
		[Token(Token = "0x4005730")]
		private const float REPEAT_AUDIO_PROTECTION_OFFSET = 0.05f;

		// Token: 0x04005731 RID: 22321
		[Token(Token = "0x4005731")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<LoopedBGMPackage, GlobalAudioManager.WorkingLoopedSFX> looping;

		// Token: 0x04005732 RID: 22322
		[Token(Token = "0x4005732")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Stack<LoopedBGMPackage> m_WorkingGC;

		// Token: 0x04005733 RID: 22323
		[Token(Token = "0x4005733")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Stack<AudioSource> pool;

		// Token: 0x04005734 RID: 22324
		[Token(Token = "0x4005734")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<AudioSource, Coroutine> working;

		// Token: 0x04005735 RID: 22325
		[Token(Token = "0x4005735")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<int> workingAudio;

		// Token: 0x04005736 RID: 22326
		[Token(Token = "0x4005736")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AudioSource bgmStart;

		// Token: 0x04005737 RID: 22327
		[Token(Token = "0x4005737")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource bgmLoop;

		// Token: 0x04005738 RID: 22328
		[Token(Token = "0x4005738")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float bufferedSFXVolume;

		// Token: 0x04005739 RID: 22329
		[Token(Token = "0x4005739")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int currentAudioSources;

		// Token: 0x0400573A RID: 22330
		[Token(Token = "0x400573A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float internalBGMVolumeMultiplier;

		// Token: 0x0400573B RID: 22331
		[Token(Token = "0x400573B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool isOverrideBGMPlaying;

		// Token: 0x0400573C RID: 22332
		[Token(Token = "0x400573C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool m_IsOverrideBGMStopping;

		// Token: 0x0400573D RID: 22333
		[Token(Token = "0x400573D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float? m_PausedStartTime;

		// Token: 0x0400573E RID: 22334
		[Token(Token = "0x400573E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action onFadeMainBGMCallback;

		// Token: 0x0400573F RID: 22335
		[Token(Token = "0x400573F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Action onRestoreMainBGMCallback;

		// Token: 0x02000FA4 RID: 4004
		[Token(Token = "0x2000FA4")]
		[Serializable]
		public struct DelayAudioClip
		{
			// Token: 0x04005740 RID: 22336
			[Token(Token = "0x4005740")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public AudioClip audioClip;

			// Token: 0x04005741 RID: 22337
			[Token(Token = "0x4005741")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			public float delay;
		}

		// Token: 0x02000FA5 RID: 4005
		[Token(Token = "0x2000FA5")]
		private enum FadeType
		{
			// Token: 0x04005743 RID: 22339
			[Token(Token = "0x4005743")]
			FadeIn,
			// Token: 0x04005744 RID: 22340
			[Token(Token = "0x4005744")]
			FadeOut
		}

		// Token: 0x02000FA6 RID: 4006
		[Token(Token = "0x2000FA6")]
		private class WorkingLoopedSFX
		{
			// Token: 0x06005E47 RID: 24135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005E47")]
			[Address(RVA = "0x8B7B50", Offset = "0x8B6550", VA = "0x1808B7B50")]
			private WorkingLoopedSFX(AudioSource componentA, AudioSource componentB, bool aIsTemp, bool bIsTemp, global::UnityEngine.Object identifier, LoopedBGMPackage bgmPkg)
			{
			}

			// Token: 0x17000D1F RID: 3359
			// (get) Token: 0x06005E48 RID: 24136 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D1F")]
			public global::UnityEngine.Object Identifier
			{
				[Token(Token = "0x6005E48")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000D20 RID: 3360
			// (get) Token: 0x06005E49 RID: 24137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D20")]
			public AudioSource ComponentA
			{
				[Token(Token = "0x6005E49")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000D21 RID: 3361
			// (get) Token: 0x06005E4A RID: 24138 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D21")]
			public AudioSource ComponentB
			{
				[Token(Token = "0x6005E4A")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000D22 RID: 3362
			// (get) Token: 0x06005E4B RID: 24139 RVA: 0x00020928 File Offset: 0x0001EB28
			[Token(Token = "0x17000D22")]
			public bool AIsTemp
			{
				[Token(Token = "0x6005E4B")]
				[Address(RVA = "0x685340", Offset = "0x683D40", VA = "0x180685340")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000D23 RID: 3363
			// (get) Token: 0x06005E4C RID: 24140 RVA: 0x00020940 File Offset: 0x0001EB40
			[Token(Token = "0x17000D23")]
			public bool BIsTemp
			{
				[Token(Token = "0x6005E4C")]
				[Address(RVA = "0x8B7BE0", Offset = "0x8B65E0", VA = "0x1808B7BE0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000D24 RID: 3364
			// (get) Token: 0x06005E4D RID: 24141 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D24")]
			public LoopedBGMPackage BgmPkg
			{
				[Token(Token = "0x6005E4D")]
				[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06005E4E RID: 24142 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005E4E")]
			[Address(RVA = "0x8B78C0", Offset = "0x8B62C0", VA = "0x1808B78C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06005E4F RID: 24143 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005E4F")]
			[Address(RVA = "0x8B7700", Offset = "0x8B6100", VA = "0x1808B7700")]
			public static GlobalAudioManager.WorkingLoopedSFX Generate(GlobalAudioManager manager, global::UnityEngine.Object identifier, LoopedBGMPackage loopedBGMPackage)
			{
				return null;
			}
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.Singletons;
using GameData.Core.MusicUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.MusicUtility
{
	// Token: 0x02000578 RID: 1400
	[Token(Token = "0x2000578")]
	[GenerateCleanupMethod]
	public class MusicManager : MonoSingleton<MusicManager>
	{
		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x0000BC88 File Offset: 0x00009E88
		// (set) Token: 0x06001F87 RID: 8071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041B")]
		public float MidiSegmentMultiplier
		{
			[Token(Token = "0x6001F86")]
			[Address(RVA = "0x4E32A0", Offset = "0x4E1CA0", VA = "0x1804E32A0")]
			[CompilerGenerated]
			private get
			{
				return 0f;
			}
			[Token(Token = "0x6001F87")]
			[Address(RVA = "0x4E32C0", Offset = "0x4E1CC0", VA = "0x1804E32C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		[Token(Token = "0x1700041C")]
		public long MidiSegmentLength
		{
			[Token(Token = "0x6001F88")]
			[Address(RVA = "0x4E3280", Offset = "0x4E1C80", VA = "0x1804E3280")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041D")]
		public bool IsMidiOn
		{
			[Token(Token = "0x6001F89")]
			[Address(RVA = "0x4E3270", Offset = "0x4E1C70", VA = "0x1804E3270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F8A")]
			[Address(RVA = "0x4E32B0", Offset = "0x4E1CB0", VA = "0x1804E32B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041E")]
		public long PlaybackTime
		{
			[Token(Token = "0x6001F8B")]
			[Address(RVA = "0x4BE490", Offset = "0x4BCE90", VA = "0x1804BE490")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001F8C")]
			[Address(RVA = "0x4E32E0", Offset = "0x4E1CE0", VA = "0x1804E32E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041F")]
		public long MusicSystemBeginPlayMiliseconds
		{
			[Token(Token = "0x6001F8D")]
			[Address(RVA = "0x48B890", Offset = "0x48A290", VA = "0x18048B890")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001F8E")]
			[Address(RVA = "0x4E32D0", Offset = "0x4E1CD0", VA = "0x1804E32D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8F")]
		[Address(RVA = "0x4E2ED0", Offset = "0x4E18D0", VA = "0x1804E2ED0")]
		private void Update()
		{
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F90")]
		[Address(RVA = "0x4E2160", Offset = "0x4E0B60", VA = "0x1804E2160")]
		public Action Initialize()
		{
			return null;
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F91")]
		[Address(RVA = "0x4E1E10", Offset = "0x4E0810", VA = "0x1804E1E10")]
		public void FadeMainBGM()
		{
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F92")]
		[Address(RVA = "0x4E2880", Offset = "0x4E1280", VA = "0x1804E2880")]
		public void RestoreMainBGM()
		{
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F93")]
		[Address(RVA = "0x4E2E80", Offset = "0x4E1880", VA = "0x1804E2E80")]
		private void UpdateMusicVolume(float value)
		{
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F94")]
		[Address(RVA = "0x4E2870", Offset = "0x4E1270", VA = "0x1804E2870")]
		public void RequestChannelSwitch(int requestedValue)
		{
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F95")]
		[Address(RVA = "0x4E2BF0", Offset = "0x4E15F0", VA = "0x1804E2BF0")]
		private void SwitchChannel()
		{
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F96")]
		[Address(RVA = "0x4E27F0", Offset = "0x4E11F0", VA = "0x1804E27F0")]
		private IEnumerator OnSwitching()
		{
			return null;
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F97")]
		[Address(RVA = "0x4E29A0", Offset = "0x4E13A0", VA = "0x1804E29A0")]
		public void StopMusic()
		{
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F98")]
		[Address(RVA = "0x4E1FE0", Offset = "0x4E09E0", VA = "0x1804E1FE0")]
		public IzakayaMusic.SingleNote[] GetMidiNotes(float QTEMultiplier)
		{
			return null;
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F99")]
		[Address(RVA = "0x4E2AE0", Offset = "0x4E14E0", VA = "0x1804E2AE0")]
		public void SwitchBackToMain()
		{
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F9A")]
		[Address(RVA = "0x4E1F30", Offset = "0x4E0930", VA = "0x1804E1F30")]
		public IzakayaMusic.SingleNote[] FetchNotes(long startTime, long endTime, long preparationOffset)
		{
			return null;
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9B")]
		[Address(RVA = "0x4E2770", Offset = "0x4E1170", VA = "0x1804E2770", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9C")]
		[Address(RVA = "0x4E1D90", Offset = "0x4E0790", VA = "0x1804E1D90", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9D")]
		[Address(RVA = "0x4E31C0", Offset = "0x4E1BC0", VA = "0x1804E31C0")]
		public MusicManager()
		{
		}

		// Token: 0x04001CED RID: 7405
		[Token(Token = "0x4001CED")]
		public const double MUSIC_START_OFFSET = 0.0;

		// Token: 0x04001CEE RID: 7406
		[Token(Token = "0x4001CEE")]
		[FieldOffset(Offset = "0x18")]
		[Header("MIDI Data")]
		[Tooltip("音符开启时间(ms)")]
		public long midiNoteOpenPreparationTime;

		// Token: 0x04001CEF RID: 7407
		[Token(Token = "0x4001CEF")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("音符前置裕度(ms)")]
		public long midiNotePreValidTime;

		// Token: 0x04001CF0 RID: 7408
		[Token(Token = "0x4001CF0")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("音符后置裕度(ms)")]
		public long midiNotePostValidTime;

		// Token: 0x04001CF1 RID: 7409
		[Token(Token = "0x4001CF1")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("音符长按提前结束裕度(ms)")]
		public long midiNoteHoldEarlyEndTime;

		// Token: 0x04001CF2 RID: 7410
		[Token(Token = "0x4001CF2")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("QTE最大值(ms)")]
		public long maxQTEDuration;

		// Token: 0x04001CF3 RID: 7411
		[Token(Token = "0x4001CF3")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("音乐切换QTE时间")]
		public float musicSwitchTime;

		// Token: 0x04001CF4 RID: 7412
		[Token(Token = "0x4001CF4")]
		[FieldOffset(Offset = "0x44")]
		[Header("Volume Data")]
		[Tooltip("音乐音量")]
		public float musicVolume;

		// Token: 0x04001CF5 RID: 7413
		[Token(Token = "0x4001CF5")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("音乐音量(QTE模式)")]
		public float musicVolumeWhenMidi;

		// Token: 0x04001CF6 RID: 7414
		[Token(Token = "0x4001CF6")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("MIDI音效音量")]
		public float midiNoteVolume;

		// Token: 0x04001CF7 RID: 7415
		[Token(Token = "0x4001CF7")]
		[FieldOffset(Offset = "0x50")]
		public AudioClip onMusicChange;

		// Token: 0x04001CF8 RID: 7416
		[Token(Token = "0x4001CF8")]
		[FieldOffset(Offset = "0x58")]
		public Action<float> onMusicVolumeChange;

		// Token: 0x04001CF9 RID: 7417
		[Token(Token = "0x4001CF9")]
		[FieldOffset(Offset = "0x60")]
		private LoopedBGMChannel[] channels;

		// Token: 0x04001CFA RID: 7418
		[Token(Token = "0x4001CFA")]
		[FieldOffset(Offset = "0x68")]
		private long clipLoopTotalMiliseconds;

		// Token: 0x04001CFB RID: 7419
		[Token(Token = "0x4001CFB")]
		[FieldOffset(Offset = "0x70")]
		private int currentChannelIndex;

		// Token: 0x04001CFC RID: 7420
		[Token(Token = "0x4001CFC")]
		[FieldOffset(Offset = "0x78")]
		private long[] entry;

		// Token: 0x04001CFD RID: 7421
		[Token(Token = "0x4001CFD")]
		[FieldOffset(Offset = "0x80")]
		private bool isChannelSwitching;

		// Token: 0x04001CFE RID: 7422
		[Token(Token = "0x4001CFE")]
		[FieldOffset(Offset = "0x88")]
		private AudioSource onMusicTransitionSource;

		// Token: 0x04001CFF RID: 7423
		[Token(Token = "0x4001CFF")]
		[FieldOffset(Offset = "0x90")]
		private int requestedChannelIndex;

		// Token: 0x04001D00 RID: 7424
		[Token(Token = "0x4001D00")]
		[FieldOffset(Offset = "0x98")]
		private Queue<long> streamingSwitchPointList;
	}
}

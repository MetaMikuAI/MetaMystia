using System;
using System.Collections;
using System.Collections.Generic;
using DEYU.Utils;
using GameData.Core.MusicUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.MusicUtility
{
	// Token: 0x02000574 RID: 1396
	[Token(Token = "0x2000574")]
	[GenerateCleanupMethod]
	public class LoopedBGMChannel : MonoBehaviour
	{
		// Token: 0x06001F68 RID: 8040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F68")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F69")]
		[Address(RVA = "0x4E1220", Offset = "0x4DFC20", VA = "0x1804E1220")]
		public Action<float> Initialize()
		{
			return null;
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6A")]
		[Address(RVA = "0x4E0B90", Offset = "0x4DF590", VA = "0x1804E0B90")]
		private void ChangeMusicVolume(float targetVolume)
		{
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6B")]
		[Address(RVA = "0x4E1450", Offset = "0x4DFE50", VA = "0x1804E1450")]
		public void Play(IzakayaMusic.MusicChannelPackage channelPackage, bool defaultChannel)
		{
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6C")]
		[Address(RVA = "0x4E0D10", Offset = "0x4DF710", VA = "0x1804E0D10")]
		public void Dispose()
		{
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6D")]
		[Address(RVA = "0x4E0D80", Offset = "0x4DF780", VA = "0x1804E0D80")]
		public void FadeMainBGM()
		{
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6E")]
		[Address(RVA = "0x4E18A0", Offset = "0x4E02A0", VA = "0x1804E18A0")]
		public void RestoreMainBGM()
		{
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F6F")]
		[Address(RVA = "0x4E1B10", Offset = "0x4E0510", VA = "0x1804E1B10")]
		private void UpdateMusicOverrideVolumeMultiplier(float targetMultiplier)
		{
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F70")]
		[Address(RVA = "0x4E1B80", Offset = "0x4E0580", VA = "0x1804E1B80")]
		private void UpdateVolume()
		{
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F71")]
		[Address(RVA = "0x4E1980", Offset = "0x4E0380", VA = "0x1804E1980")]
		public void ToggleChannelVolume(bool on)
		{
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F72")]
		[Address(RVA = "0x4E0C00", Offset = "0x4DF600", VA = "0x1804E0C00")]
		private IEnumerator ChannelOn(bool on)
		{
			return null;
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F73")]
		[Address(RVA = "0x4E1A60", Offset = "0x4E0460", VA = "0x1804E1A60")]
		public void ToggleMidiVolume(bool on)
		{
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F74")]
		[Address(RVA = "0x4E13C0", Offset = "0x4DFDC0", VA = "0x1804E13C0")]
		private IEnumerator MidiOn(bool on)
		{
			return null;
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F75")]
		[Address(RVA = "0x4E0E60", Offset = "0x4DF860", VA = "0x1804E0E60")]
		public IEnumerable<IzakayaMusic.SingleNote> FetchNotes(long startTime, long endTime, long clipLoopTotalMilliseconds)
		{
			return null;
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F76")]
		[Address(RVA = "0x4E0C90", Offset = "0x4DF690", VA = "0x1804E0C90", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F77")]
		[Address(RVA = "0x4E1BE0", Offset = "0x4E05E0", VA = "0x1804E1BE0")]
		public LoopedBGMChannel()
		{
		}

		// Token: 0x04001CD7 RID: 7383
		[Token(Token = "0x4001CD7")]
		[FieldOffset(Offset = "0x18")]
		private IzakayaMusic.SingleNote[] allMidis;

		// Token: 0x04001CD8 RID: 7384
		[Token(Token = "0x4001CD8")]
		[FieldOffset(Offset = "0x20")]
		private float channelVolumeMultiplier;

		// Token: 0x04001CD9 RID: 7385
		[Token(Token = "0x4001CD9")]
		[FieldOffset(Offset = "0x28")]
		private AudioSource introPlayer;

		// Token: 0x04001CDA RID: 7386
		[Token(Token = "0x4001CDA")]
		[FieldOffset(Offset = "0x30")]
		private bool isDisposed;

		// Token: 0x04001CDB RID: 7387
		[Token(Token = "0x4001CDB")]
		[FieldOffset(Offset = "0x38")]
		private AudioSource loopPlayer;

		// Token: 0x04001CDC RID: 7388
		[Token(Token = "0x4001CDC")]
		[FieldOffset(Offset = "0x40")]
		private float masterVolume;

		// Token: 0x04001CDD RID: 7389
		[Token(Token = "0x4001CDD")]
		[FieldOffset(Offset = "0x44")]
		private float midiVolumeMultiplier;

		// Token: 0x04001CDE RID: 7390
		[Token(Token = "0x4001CDE")]
		[FieldOffset(Offset = "0x48")]
		private float musicOverrideVolumeMultiplier;

		// Token: 0x04001CDF RID: 7391
		[Token(Token = "0x4001CDF")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine onMidiSwitching;

		// Token: 0x04001CE0 RID: 7392
		[Token(Token = "0x4001CE0")]
		[FieldOffset(Offset = "0x58")]
		private Coroutine onChannelSwitching;

		// Token: 0x04001CE1 RID: 7393
		[Token(Token = "0x4001CE1")]
		[FieldOffset(Offset = "0x60")]
		private LQueue<IzakayaMusic.SingleNote> streamingMidiList;
	}
}

using System;
using System.Runtime.CompilerServices;
using DEYU.Singletons;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FB2 RID: 4018
	[Token(Token = "0x2000FB2")]
	public class GameTimeManager : MonoSingleton<GameTimeManager>
	{
		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06005E71 RID: 24177 RVA: 0x000209D0 File Offset: 0x0001EBD0
		// (set) Token: 0x06005E72 RID: 24178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D29")]
		public bool ShouldUpdateTime
		{
			[Token(Token = "0x6005E71")]
			[Address(RVA = "0x8C8270", Offset = "0x8C6C70", VA = "0x1808C8270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005E72")]
			[Address(RVA = "0x8C8290", Offset = "0x8C6C90", VA = "0x1808C8290")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06005E73 RID: 24179 RVA: 0x000209E8 File Offset: 0x0001EBE8
		// (set) Token: 0x06005E74 RID: 24180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D2A")]
		public float DefaultTimeScale
		{
			[Token(Token = "0x6005E73")]
			[Address(RVA = "0x4506C0", Offset = "0x44F0C0", VA = "0x1804506C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005E74")]
			[Address(RVA = "0x8C8280", Offset = "0x8C6C80", VA = "0x1808C8280")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06005E75 RID: 24181 RVA: 0x00020A00 File Offset: 0x0001EC00
		// (set) Token: 0x06005E76 RID: 24182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D2B")]
		public GameTimeManager.TimeMode CurrentTimeMode
		{
			[Token(Token = "0x6005E75")]
			[Address(RVA = "0x44F9E0", Offset = "0x44E3E0", VA = "0x18044F9E0")]
			[CompilerGenerated]
			get
			{
				return GameTimeManager.TimeMode.Freeze;
			}
			[Token(Token = "0x6005E76")]
			[Address(RVA = "0x450630", Offset = "0x44F030", VA = "0x180450630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005E77 RID: 24183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E77")]
		[Address(RVA = "0x8C8000", Offset = "0x8C6A00", VA = "0x1808C8000", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E78")]
		[Address(RVA = "0x8C8170", Offset = "0x8C6B70", VA = "0x1808C8170")]
		private void Update()
		{
		}

		// Token: 0x06005E79 RID: 24185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E79")]
		[Address(RVA = "0x8C80B0", Offset = "0x8C6AB0", VA = "0x1808C80B0")]
		private void OnPlayableDirectorPlayed(PlayableDirector playableDirector)
		{
		}

		// Token: 0x06005E7A RID: 24186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E7A")]
		[Address(RVA = "0x8C80C0", Offset = "0x8C6AC0", VA = "0x1808C80C0")]
		public void SetGameTimeMode(GameTimeManager.TimeMode mode)
		{
		}

		// Token: 0x06005E7B RID: 24187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E7B")]
		[Address(RVA = "0x8C7FB0", Offset = "0x8C69B0", VA = "0x1808C7FB0")]
		public void AddTicks(int ticks)
		{
		}

		// Token: 0x06005E7C RID: 24188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E7C")]
		[Address(RVA = "0x8C8230", Offset = "0x8C6C30", VA = "0x1808C8230")]
		public GameTimeManager()
		{
		}

		// Token: 0x04005769 RID: 22377
		[Token(Token = "0x4005769")]
		private const float CLIP_TIME_DURATION = 0.016666668f;

		// Token: 0x0400576A RID: 22378
		[Token(Token = "0x400576A")]
		[FieldOffset(Offset = "0x18")]
		public PlayableDirector playableDirector;

		// Token: 0x0400576B RID: 22379
		[Token(Token = "0x400576B")]
		[FieldOffset(Offset = "0x20")]
		private bool isPlayablePlaying;

		// Token: 0x02000FB3 RID: 4019
		[Token(Token = "0x2000FB3")]
		public enum TimeMode
		{
			// Token: 0x04005770 RID: 22384
			[Token(Token = "0x4005770")]
			Freeze,
			// Token: 0x04005771 RID: 22385
			[Token(Token = "0x4005771")]
			HalfFreeze,
			// Token: 0x04005772 RID: 22386
			[Token(Token = "0x4005772")]
			Resume
		}
	}
}

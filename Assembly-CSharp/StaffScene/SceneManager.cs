using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AssetHandleUtility;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace StaffScene
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	[GenerateCleanupMethod]
	public class SceneManager : MonoSingleton<SceneManager>
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00002CB8 File Offset: 0x00000EB8
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000052")]
		public static SceneManager.StaffScenePlaybackInfo? PlaybackInfo
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x42E100", Offset = "0x42CB00", VA = "0x18042E100")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x42E280", Offset = "0x42CC80", VA = "0x18042E280")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060002EB RID: 747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000053")]
		[CleanupIgnore]
		public static GameObject[] NpcCGDB
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x42E0C0", Offset = "0x42CAC0", VA = "0x18042E0C0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x42E220", Offset = "0x42CC20", VA = "0x18042E220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x17000054")]
		private float CurrentPlayBackTime
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x42E020", Offset = "0x42CA20", VA = "0x18042E020")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x42CFC0", Offset = "0x42B9C0", VA = "0x18042CFC0")]
		private void Start()
		{
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060002EE RID: 750 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060002EF RID: 751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000001")]
		public static event Action ResetAllNPCCallback
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x42DF40", Offset = "0x42C940", VA = "0x18042DF40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x42E160", Offset = "0x42CB60", VA = "0x18042E160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x42CB10", Offset = "0x42B510", VA = "0x18042CB10", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x42CC80", Offset = "0x42B680", VA = "0x18042CC80")]
		private IEnumerator PlayLyrics()
		{
			return null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x42CBF0", Offset = "0x42B5F0", VA = "0x18042CBF0")]
		private IEnumerator PlayBGMDelayed(LoopedBGMPackage selectedBGMPackage)
		{
			return null;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x42C270", Offset = "0x42AC70", VA = "0x18042C270")]
		private IEnumerator OnDisplayingData(float selectedBGMLength)
		{
			return null;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x42B9D0", Offset = "0x42A3D0", VA = "0x18042B9D0")]
		public void Dispose()
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x42BD90", Offset = "0x42A790", VA = "0x18042BD90")]
		private void GotoResultScene()
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x42B340", Offset = "0x429D40", VA = "0x18042B340", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x42DEA0", Offset = "0x42C8A0", VA = "0x18042DEA0")]
		public SceneManager()
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		[CompilerGenerated]
		internal static void <OnDisplayingData>g__UpdateVisualAlpha|39_0(CanvasGroup image, float alpha)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x42DC30", Offset = "0x42C630", VA = "0x18042DC30")]
		[CompilerGenerated]
		internal static IEnumerator <OnDisplayingData>g__DisplayData|39_1(CanvasGroup canvasGroup, float transition, float display, Action onBeforeFadeCallback)
		{
			return null;
		}

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x0")]
		public static string[] unlockedLevel5Guests;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x18")]
		public CanvasGroup edCG;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x20")]
		public Image endCGImage;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x28")]
		public RectTransform npcCGTransform;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x30")]
		public GameObject lyricsContainer;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI lyricsVisual;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float edTransitionRatio;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		[FieldOffset(Offset = "0x44")]
		public float npcCgDurationWeight;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		[FieldOffset(Offset = "0x48")]
		public List<CanvasGroup> pages;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x50")]
		public List<CanvasGroup> nx_pages;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x58")]
		public int musicPageIndex;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x5C")]
		public int nxMusicPageIndex;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform m_PagesField;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x68")]
		public CanvasGroup bg;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x70")]
		public CanvasGroup bg2;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x78")]
		public CanvasGroup shade;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float transitionRatio;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x84")]
		public float extraOffset;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x88")]
		private readonly List<FlexibleCGElement> m_NPCCG;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x90")]
		private AudioSource m_LoopAudioSource;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x98")]
		private CanvasGroup[] _staffPageInstances;

		// Token: 0x0200008A RID: 138
		[Token(Token = "0x200008A")]
		public readonly struct StaffScenePlaybackInfo : IDisposable
		{
			// Token: 0x060002FA RID: 762 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x42FAB0", Offset = "0x42E4B0", VA = "0x18042FAB0")]
			public StaffScenePlaybackInfo(IAssetHandle<Sprite> cg, IAssetHandle<LoopedBGMPackage> bgm, ValueTuple<float, string>[] lyrics, float endCGDuration, bool showLyrics, IGameObjectAssetHandle<CanvasGroup> page)
			{
			}

			// Token: 0x060002FB RID: 763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x42FA30", Offset = "0x42E430", VA = "0x18042FA30", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x040002E4 RID: 740
			[Token(Token = "0x40002E4")]
			[FieldOffset(Offset = "0x0")]
			public readonly IAssetHandle<Sprite> CG;

			// Token: 0x040002E5 RID: 741
			[Token(Token = "0x40002E5")]
			[FieldOffset(Offset = "0x8")]
			public readonly IAssetHandle<LoopedBGMPackage> BGM;

			// Token: 0x040002E6 RID: 742
			[Token(Token = "0x40002E6")]
			[FieldOffset(Offset = "0x10")]
			public readonly ValueTuple<float, string>[] Lyrics;

			// Token: 0x040002E7 RID: 743
			[Token(Token = "0x40002E7")]
			[FieldOffset(Offset = "0x18")]
			public readonly float EndCGDuration;

			// Token: 0x040002E8 RID: 744
			[Token(Token = "0x40002E8")]
			[FieldOffset(Offset = "0x1C")]
			public readonly bool ShowLyrics;

			// Token: 0x040002E9 RID: 745
			[Token(Token = "0x40002E9")]
			[FieldOffset(Offset = "0x20")]
			public readonly IGameObjectAssetHandle<CanvasGroup> Page;
		}
	}
}

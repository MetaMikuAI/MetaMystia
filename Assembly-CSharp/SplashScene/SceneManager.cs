using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using GamePlatform.Systems;
using Il2CppDummyDll;
using Omt.Net.Http;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Video;

namespace SplashScene
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	[GenerateCleanupMethod]
	public class SceneManager : MonoBehaviour
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x1700005D")]
		public static ConsoleMode CurrentConsoleMode
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x42E000", Offset = "0x42CA00", VA = "0x18042E000")]
			get
			{
				return ConsoleMode.Full;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000325 RID: 805 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x1700005E")]
		public static bool EnableDebugCosole
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x42ADB0", Offset = "0x4297B0", VA = "0x18042ADB0")]
		private void Awake()
		{
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x42C3F0", Offset = "0x42ADF0", VA = "0x18042C3F0")]
		private void OnGUI()
		{
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x42BA20", Offset = "0x42A420", VA = "0x18042BA20")]
		private void GetLoginResultCallback(HttpResponse httpResponseMessage)
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x42CB60", Offset = "0x42B560", VA = "0x18042CB60")]
		private void OnLoginFailed(Exception exception)
		{
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x42C0E0", Offset = "0x42AAE0", VA = "0x18042C0E0")]
		private void LoadLoginResultCallback(string data)
		{
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x42D9B0", Offset = "0x42C3B0", VA = "0x18042D9B0")]
		private void Start()
		{
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x42CD00", Offset = "0x42B700", VA = "0x18042CD00")]
		private void PreInitAllSplashGUIs()
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x42BE60", Offset = "0x42A860", VA = "0x18042BE60")]
		private void Init()
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x42C300", Offset = "0x42AD00", VA = "0x18042C300")]
		private UniTask OnDisplayingSplash()
		{
			return default(UniTask);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x42DD40", Offset = "0x42C740", VA = "0x18042DD40")]
		private void Update()
		{
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x42B580", Offset = "0x429F80", VA = "0x18042B580")]
		private UniTask DisplayImageSession(CanvasGroup canvasGroup, float displayDuration, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x42B8B0", Offset = "0x42A2B0", VA = "0x18042B8B0")]
		private UniTask DisplayVideoSession(UniTask<IAssetHandle<VideoClip>> loadingAssetHandle, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x42B520", Offset = "0x429F20", VA = "0x18042B520")]
		private void ClearRenderTexture()
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x42B6A0", Offset = "0x42A0A0", VA = "0x18042B6A0")]
		private UniTask DisplayIn(CanvasGroup pair, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x42DD10", Offset = "0x42C710", VA = "0x18042DD10")]
		private void UpdateVisualAlpha(CanvasGroup image, float alpha)
		{
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x42B7A0", Offset = "0x42A1A0", VA = "0x18042B7A0")]
		private UniTask DisplayOut(CanvasGroup pair, CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x42C200", Offset = "0x42AC00", VA = "0x18042C200")]
		private void LoadScene()
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x42B250", Offset = "0x429C50", VA = "0x18042B250", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x42DD90", Offset = "0x42C790", VA = "0x18042DD90")]
		public SceneManager()
		{
		}

		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		[FieldOffset(Offset = "0x18")]
		[AssetReferenceUILabelRestriction(new string[] { "Scene" })]
		public AssetReference loadScene;

		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		[FieldOffset(Offset = "0x20")]
		public float logoTransitionDuration;

		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		[FieldOffset(Offset = "0x28")]
		public SceneManager.SplashVisualPair[] splashVisuals;

		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		[FieldOffset(Offset = "0x30")]
		public CanvasGroup syncWithSteamVisual;

		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		[FieldOffset(Offset = "0x38")]
		public CanvasGroup video;

		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		[FieldOffset(Offset = "0x40")]
		public RenderTexture videoRenderTexture;

		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x48")]
		public TextAsset versionData;

		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x50")]
		public AssetReference TMP_Settings;

		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x58")]
		public VideoPlayer videoPlayer;

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x60")]
		private bool requirdTesterLogin;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x68")]
		private CancellationTokenSource cancellationTokenSource;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x70")]
		private string userName;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x78")]
		private string password;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x80")]
		private string errorMessage;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x88")]
		private string deviceID;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		private const string INCORRECT_USERNAME_OR_PASSWORD = "<color=red>用户名或密码错误</color>";

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		private const string MAX_DEVICE_COUNT = "<color=yellow>设备数量超限</color>";

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		private const string SERVER_ERROR = "<color=fuchsia >服务器错误($a)</color>";

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x90")]
		private readonly HttpRequester m_HttpRequester;

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x2000093")]
		[Serializable]
		public struct SplashVisualPair
		{
			// Token: 0x04000322 RID: 802
			[Token(Token = "0x4000322")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public CanvasGroup visual;

			// Token: 0x04000323 RID: 803
			[Token(Token = "0x4000323")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public bool mustCompleteBeforeFirstScene;

			// Token: 0x04000324 RID: 804
			[Token(Token = "0x4000324")]
			[FieldOffset(Offset = "0x9")]
			[SerializeField]
			public bool hideInSwitchPlatform;

			// Token: 0x04000325 RID: 805
			[Token(Token = "0x4000325")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public AssetReference video;

			// Token: 0x04000326 RID: 806
			[Token(Token = "0x4000326")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public float displayDuration;
		}

		// Token: 0x02000094 RID: 148
		[Token(Token = "0x2000094")]
		private struct LoginResultDataModel
		{
			// Token: 0x1700005F RID: 95
			// (get) Token: 0x0600033A RID: 826 RVA: 0x00002E68 File Offset: 0x00001068
			// (set) Token: 0x0600033B RID: 827 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700005F")]
			public SceneManager.LoginResultDataModel.LoginResult ResultCode
			{
				[Token(Token = "0x600033A")]
				[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
				[CompilerGenerated]
				readonly get
				{
					return SceneManager.LoginResultDataModel.LoginResult.Succeed;
				}
				[Token(Token = "0x600033B")]
				[Address(RVA = "0x425CA0", Offset = "0x4246A0", VA = "0x180425CA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x02000095 RID: 149
			[Token(Token = "0x2000095")]
			public enum LoginResult
			{
				// Token: 0x04000329 RID: 809
				[Token(Token = "0x4000329")]
				Succeed,
				// Token: 0x0400032A RID: 810
				[Token(Token = "0x400032A")]
				MismatchedUserNameOrPassword,
				// Token: 0x0400032B RID: 811
				[Token(Token = "0x400032B")]
				DeviceUpToLimit
			}
		}
	}
}

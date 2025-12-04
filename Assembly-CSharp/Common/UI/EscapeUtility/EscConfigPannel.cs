using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData;
using GameData.Utils;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI.EscapeUtility
{
	// Token: 0x02000F42 RID: 3906
	[Token(Token = "0x2000F42")]
	[GenerateCleanupMethod]
	public class EscConfigPannel : UISubPanel<EscMainPannel>
	{
		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06005BB7 RID: 23479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CEC")]
		private static PlayerSettings CurrentSettings
		{
			[Token(Token = "0x6005BB7")]
			[Address(RVA = "0x8851B0", Offset = "0x883BB0", VA = "0x1808851B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x06005BB8 RID: 23480 RVA: 0x0001FFB0 File Offset: 0x0001E1B0
		[Token(Token = "0x17000CED")]
		public static MultiLanguageTextMesh.LoadLanguageType CurrentLanguage
		{
			[Token(Token = "0x6005BB8")]
			[Address(RVA = "0x885190", Offset = "0x883B90", VA = "0x180885190")]
			get
			{
				return MultiLanguageTextMesh.LoadLanguageType.Chinese;
			}
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06005BB9 RID: 23481 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
		[Token(Token = "0x17000CEE")]
		public static bool EnableSpellDecalareCutin
		{
			[Token(Token = "0x6005BB9")]
			[Address(RVA = "0x885290", Offset = "0x883C90", VA = "0x180885290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06005BBA RID: 23482 RVA: 0x0001FFE0 File Offset: 0x0001E1E0
		[Token(Token = "0x17000CEF")]
		public static bool EnableLegacyQTEPannel
		{
			[Token(Token = "0x6005BBA")]
			[Address(RVA = "0x885250", Offset = "0x883C50", VA = "0x180885250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06005BBB RID: 23483 RVA: 0x0001FFF8 File Offset: 0x0001E1F8
		[Token(Token = "0x17000CF0")]
		public static bool EnableLegacyThrowDeliver
		{
			[Token(Token = "0x6005BBB")]
			[Address(RVA = "0x885270", Offset = "0x883C70", VA = "0x180885270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06005BBC RID: 23484 RVA: 0x00020010 File Offset: 0x0001E210
		[Token(Token = "0x17000CF1")]
		public static bool CleanMusicGameMode
		{
			[Token(Token = "0x6005BBC")]
			[Address(RVA = "0x885170", Offset = "0x883B70", VA = "0x180885170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06005BBD RID: 23485 RVA: 0x00020028 File Offset: 0x0001E228
		[Token(Token = "0x17000CF2")]
		public static float SfxVol
		{
			[Token(Token = "0x6005BBD")]
			[Address(RVA = "0x8852D0", Offset = "0x883CD0", VA = "0x1808852D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06005BBE RID: 23486 RVA: 0x00020040 File Offset: 0x0001E240
		[Token(Token = "0x17000CF3")]
		public static float MusicVol
		{
			[Token(Token = "0x6005BBE")]
			[Address(RVA = "0x8852B0", Offset = "0x883CB0", VA = "0x1808852B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06005BBF RID: 23487 RVA: 0x00020058 File Offset: 0x0001E258
		[Token(Token = "0x17000CF4")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6005BBF")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1400003E RID: 62
		// (add) Token: 0x06005BC0 RID: 23488 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005BC1 RID: 23489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003E")]
		[CleanupIgnore]
		public static event Action<float> OnMusicVolumeUpdate
		{
			[Token(Token = "0x6005BC0")]
			[Address(RVA = "0x884ED0", Offset = "0x8838D0", VA = "0x180884ED0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005BC1")]
			[Address(RVA = "0x8852F0", Offset = "0x883CF0", VA = "0x1808852F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400003F RID: 63
		// (add) Token: 0x06005BC2 RID: 23490 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005BC3 RID: 23491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003F")]
		[CleanupIgnore]
		public static event Action<float> OnOverrideMusicVolumeUpdate
		{
			[Token(Token = "0x6005BC2")]
			[Address(RVA = "0x884FB0", Offset = "0x8839B0", VA = "0x180884FB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005BC3")]
			[Address(RVA = "0x8853D0", Offset = "0x883DD0", VA = "0x1808853D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000040 RID: 64
		// (add) Token: 0x06005BC4 RID: 23492 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005BC5 RID: 23493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000040")]
		[CleanupIgnore]
		public static event Action<float> OnSFXVolumeUpdate
		{
			[Token(Token = "0x6005BC4")]
			[Address(RVA = "0x885090", Offset = "0x883A90", VA = "0x180885090")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005BC5")]
			[Address(RVA = "0x8854B0", Offset = "0x883EB0", VA = "0x1808854B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005BC6 RID: 23494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC6")]
		[Address(RVA = "0x882E10", Offset = "0x881810", VA = "0x180882E10", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x00020070 File Offset: 0x0001E270
		[Token(Token = "0x6005BC7")]
		[Address(RVA = "0x8825A0", Offset = "0x880FA0", VA = "0x1808825A0", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC8")]
		[Address(RVA = "0x48F5A0", Offset = "0x48DFA0", VA = "0x18048F5A0")]
		private void InitButton(UIButtonToggle toggle)
		{
		}

		// Token: 0x06005BC9 RID: 23497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BC9")]
		[Address(RVA = "0x8842B0", Offset = "0x882CB0", VA = "0x1808842B0")]
		public static void RunVolumeUpdateCallback()
		{
		}

		// Token: 0x06005BCA RID: 23498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCA")]
		[Address(RVA = "0x884510", Offset = "0x882F10", VA = "0x180884510")]
		public static void SetSFXVolume(float volume)
		{
		}

		// Token: 0x06005BCB RID: 23499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCB")]
		[Address(RVA = "0x8844A0", Offset = "0x882EA0", VA = "0x1808844A0")]
		public static void SetMusicVolume(float volume)
		{
		}

		// Token: 0x06005BCC RID: 23500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCC")]
		[Address(RVA = "0x884470", Offset = "0x882E70", VA = "0x180884470")]
		public static void SetMusicGameCleanMode(bool enabled)
		{
		}

		// Token: 0x06005BCD RID: 23501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCD")]
		[Address(RVA = "0x8820B0", Offset = "0x880AB0", VA = "0x1808820B0")]
		public static void ChangeMusicVolume(float volume)
		{
		}

		// Token: 0x06005BCE RID: 23502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCE")]
		[Address(RVA = "0x882200", Offset = "0x880C00", VA = "0x180882200")]
		private void ChangeSFXVolume(float volume)
		{
		}

		// Token: 0x06005BCF RID: 23503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCF")]
		[Address(RVA = "0x882000", Offset = "0x880A00", VA = "0x180882000")]
		private void ChangeMusicVolumeVisual(float volume)
		{
		}

		// Token: 0x06005BD0 RID: 23504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD0")]
		[Address(RVA = "0x882150", Offset = "0x880B50", VA = "0x180882150")]
		private void ChangeSFXVolumeVisual(float volume)
		{
		}

		// Token: 0x06005BD1 RID: 23505 RVA: 0x00020088 File Offset: 0x0001E288
		[Token(Token = "0x6005BD1")]
		[Address(RVA = "0x882CE0", Offset = "0x8816E0", VA = "0x180882CE0")]
		private static long Lerp(int a, int b, float t)
		{
			return 0L;
		}

		// Token: 0x06005BD2 RID: 23506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD2")]
		[Address(RVA = "0x881C60", Offset = "0x880660", VA = "0x180881C60")]
		public static void ChangeCalibration(float targetCalibration)
		{
		}

		// Token: 0x06005BD3 RID: 23507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD3")]
		[Address(RVA = "0x881B40", Offset = "0x880540", VA = "0x180881B40")]
		private void ChangeCalibrationVisual(float targetCalibration)
		{
		}

		// Token: 0x06005BD4 RID: 23508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005BD4")]
		[Address(RVA = "0x8824B0", Offset = "0x880EB0", VA = "0x1808824B0")]
		public static string GetCalibrationVisual(float targetCalibration)
		{
			return null;
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x000200A0 File Offset: 0x0001E2A0
		[Token(Token = "0x6005BD5")]
		[Address(RVA = "0x882450", Offset = "0x880E50", VA = "0x180882450")]
		public static float GetCalibrationProgress()
		{
			return 0f;
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD6")]
		[Address(RVA = "0x881D30", Offset = "0x880730", VA = "0x180881D30")]
		private static void ChangeFullScreenMode(FullScreenMode targetFullScreenMode)
		{
		}

		// Token: 0x06005BD7 RID: 23511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD7")]
		[Address(RVA = "0x881CD0", Offset = "0x8806D0", VA = "0x180881CD0")]
		private void ChangeDisplayResolution(PlayerSettings.SupportedResolution targetResolution)
		{
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD8")]
		[Address(RVA = "0x884E40", Offset = "0x883840", VA = "0x180884E40")]
		private static void UpdateDisplaySettings()
		{
		}

		// Token: 0x06005BD9 RID: 23513 RVA: 0x000200B8 File Offset: 0x0001E2B8
		[Token(Token = "0x6005BD9")]
		[Address(RVA = "0x8827A0", Offset = "0x8811A0", VA = "0x1808827A0")]
		private static Vector2Int GetResolution(PlayerSettings.SupportedResolution resolution)
		{
			return default(Vector2Int);
		}

		// Token: 0x06005BDA RID: 23514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BDA")]
		[Address(RVA = "0x8845B0", Offset = "0x882FB0", VA = "0x1808845B0")]
		private void ToggleSpellDecalareCutin(bool enable)
		{
		}

		// Token: 0x06005BDB RID: 23515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BDB")]
		[Address(RVA = "0x884580", Offset = "0x882F80", VA = "0x180884580")]
		private static void ToggleRunInBackground(bool enable)
		{
		}

		// Token: 0x06005BDC RID: 23516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BDC")]
		[Address(RVA = "0x884640", Offset = "0x883040", VA = "0x180884640")]
		private static void ToggleUseLegacyQTEPannel(bool enable)
		{
		}

		// Token: 0x06005BDD RID: 23517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BDD")]
		[Address(RVA = "0x884670", Offset = "0x883070", VA = "0x180884670")]
		private static void ToggleUseLegacyThrowDeliver(bool enable)
		{
		}

		// Token: 0x06005BDE RID: 23518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BDE")]
		[Address(RVA = "0x8845E0", Offset = "0x882FE0", VA = "0x1808845E0")]
		private static void ToggleUseLargerFontSize(bool enable)
		{
		}

		// Token: 0x06005BDF RID: 23519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BDF")]
		[Address(RVA = "0x8846A0", Offset = "0x8830A0", VA = "0x1808846A0")]
		private void ToggleVsync(bool doVsync)
		{
		}

		// Token: 0x06005BE0 RID: 23520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE0")]
		[Address(RVA = "0x882270", Offset = "0x880C70", VA = "0x180882270")]
		private void ChangeTargetRefreshRate(PlayerSettings.SupportedRefreshRate refreshRate)
		{
		}

		// Token: 0x06005BE1 RID: 23521 RVA: 0x000200D0 File Offset: 0x0001E2D0
		[Token(Token = "0x6005BE1")]
		[Address(RVA = "0x882600", Offset = "0x881000", VA = "0x180882600")]
		private static int GetRefreshRate(PlayerSettings.SupportedRefreshRate refreshRate)
		{
			return 0;
		}

		// Token: 0x06005BE2 RID: 23522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE2")]
		[Address(RVA = "0x881D90", Offset = "0x880790", VA = "0x180881D90")]
		private void ChangeLangaugeButton(MultiLanguageTextMesh.LoadLanguageType langauge)
		{
		}

		// Token: 0x06005BE3 RID: 23523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE3")]
		[Address(RVA = "0x881EE0", Offset = "0x8808E0", VA = "0x180881EE0")]
		public static void ChangeLangauge(MultiLanguageTextMesh.LoadLanguageType langauge)
		{
		}

		// Token: 0x06005BE4 RID: 23524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE4")]
		[Address(RVA = "0x8841D0", Offset = "0x882BD0", VA = "0x1808841D0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005BE5 RID: 23525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE5")]
		[Address(RVA = "0x882910", Offset = "0x881310", VA = "0x180882910")]
		private void InitializeBtn()
		{
		}

		// Token: 0x06005BE6 RID: 23526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE6")]
		[Address(RVA = "0x882D30", Offset = "0x881730", VA = "0x180882D30")]
		public static void MountCurrentSettings()
		{
		}

		// Token: 0x06005BE7 RID: 23527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE7")]
		[Address(RVA = "0x882DA0", Offset = "0x8817A0", VA = "0x180882DA0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005BE8 RID: 23528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE8")]
		[Address(RVA = "0x884420", Offset = "0x882E20", VA = "0x180884420")]
		public static void SaveSettingData()
		{
		}

		// Token: 0x06005BE9 RID: 23529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BE9")]
		[Address(RVA = "0x8822B0", Offset = "0x880CB0", VA = "0x1808822B0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005BEA RID: 23530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BEA")]
		[Address(RVA = "0x884E90", Offset = "0x883890", VA = "0x180884E90")]
		public EscConfigPannel()
		{
		}

		// Token: 0x04005521 RID: 21793
		[Token(Token = "0x4005521")]
		[FieldOffset(Offset = "0x0")]
		[CleanupIgnore]
		private static PlayerSettings m_CurrentSettings;

		// Token: 0x04005522 RID: 21794
		[Token(Token = "0x4005522")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI CalibrationAmountText;

		// Token: 0x04005523 RID: 21795
		[Token(Token = "0x4005523")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI MusicVolumeText;

		// Token: 0x04005524 RID: 21796
		[Token(Token = "0x4005524")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI SFXVolumeText;

		// Token: 0x04005525 RID: 21797
		[Token(Token = "0x4005525")]
		[FieldOffset(Offset = "0x90")]
		public UIScrollBar MusicVolume;

		// Token: 0x04005526 RID: 21798
		[Token(Token = "0x4005526")]
		[FieldOffset(Offset = "0x98")]
		public UIScrollBar SfxVolume;

		// Token: 0x04005527 RID: 21799
		[Token(Token = "0x4005527")]
		[FieldOffset(Offset = "0xA0")]
		public UIButtonToggle EnableSpellDeclareCutin;

		// Token: 0x04005528 RID: 21800
		[Token(Token = "0x4005528")]
		[FieldOffset(Offset = "0xA8")]
		public UIButtonToggle[] FullScreenMode;

		// Token: 0x04005529 RID: 21801
		[Token(Token = "0x4005529")]
		[FieldOffset(Offset = "0xB0")]
		public UIButtonToggle[] RenderResolution;

		// Token: 0x0400552A RID: 21802
		[Token(Token = "0x400552A")]
		[FieldOffset(Offset = "0xB8")]
		public UIButtonToggle Vsync;

		// Token: 0x0400552B RID: 21803
		[Token(Token = "0x400552B")]
		[FieldOffset(Offset = "0xC0")]
		public UIButtonToggle[] TargetRefreshRate;

		// Token: 0x0400552C RID: 21804
		[Token(Token = "0x400552C")]
		[FieldOffset(Offset = "0xC8")]
		public UIButtonToggle[] Language;

		// Token: 0x0400552D RID: 21805
		[Token(Token = "0x400552D")]
		[FieldOffset(Offset = "0xD0")]
		public UIScrollBar QTECalibration;

		// Token: 0x0400552E RID: 21806
		[Token(Token = "0x400552E")]
		[FieldOffset(Offset = "0xD8")]
		public UIButtonToggle RunInBackground;

		// Token: 0x0400552F RID: 21807
		[Token(Token = "0x400552F")]
		[FieldOffset(Offset = "0xE0")]
		public UIButtonToggle UseLegacyQTEPannel;

		// Token: 0x04005530 RID: 21808
		[Token(Token = "0x4005530")]
		[FieldOffset(Offset = "0xE8")]
		public UIButtonToggle UseLegacyThrowDeliver;

		// Token: 0x04005531 RID: 21809
		[Token(Token = "0x4005531")]
		[FieldOffset(Offset = "0xF0")]
		public UIButtonToggle EnableLargerFontSize;

		// Token: 0x04005532 RID: 21810
		[Token(Token = "0x4005532")]
		[FieldOffset(Offset = "0xF8")]
		public CanvasGroup TargetRefreshRateGroup;

		// Token: 0x04005533 RID: 21811
		[Token(Token = "0x4005533")]
		[FieldOffset(Offset = "0x100")]
		public CanvasGroup LanguageGroup;
	}
}

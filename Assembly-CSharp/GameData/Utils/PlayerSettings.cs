using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace GameData.Utils
{
	// Token: 0x02000775 RID: 1909
	[Token(Token = "0x2000775")]
	[JsonObject(MemberSerialization.OptIn)]
	public class PlayerSettings
	{
		// Token: 0x06002C48 RID: 11336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C48")]
		[Address(RVA = "0x5E3B20", Offset = "0x5E2520", VA = "0x1805E3B20")]
		[JsonConstructor]
		public PlayerSettings()
		{
		}

		// Token: 0x06002C49 RID: 11337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C49")]
		[Address(RVA = "0x5E3B80", Offset = "0x5E2580", VA = "0x1805E3B80")]
		public PlayerSettings(int version)
		{
		}

		// Token: 0x06002C4A RID: 11338 RVA: 0x0000FB28 File Offset: 0x0000DD28
		[Token(Token = "0x6002C4A")]
		[Address(RVA = "0x5E3410", Offset = "0x5E1E10", VA = "0x1805E3410")]
		private static MultiLanguageTextMesh.LoadLanguageType MapLanguage(string cultureName)
		{
			return MultiLanguageTextMesh.LoadLanguageType.Chinese;
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x0000FB40 File Offset: 0x0000DD40
		// (set) Token: 0x06002C4C RID: 11340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F3")]
		[JsonProperty]
		private int SaveFileVersion
		{
			[Token(Token = "0x6002C4B")]
			[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002C4C")]
			[Address(RVA = "0x403870", Offset = "0x402270", VA = "0x180403870")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x0000FB58 File Offset: 0x0000DD58
		// (set) Token: 0x06002C4E RID: 11342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F4")]
		[JsonProperty]
		public float MusicVol
		{
			[Token(Token = "0x6002C4D")]
			[Address(RVA = "0x517C30", Offset = "0x516630", VA = "0x180517C30")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002C4E")]
			[Address(RVA = "0x5E3CD0", Offset = "0x5E26D0", VA = "0x1805E3CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06002C4F RID: 11343 RVA: 0x0000FB70 File Offset: 0x0000DD70
		// (set) Token: 0x06002C50 RID: 11344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F5")]
		[JsonProperty]
		public float SfxVol
		{
			[Token(Token = "0x6002C4F")]
			[Address(RVA = "0x3EFAC0", Offset = "0x3EE4C0", VA = "0x1803EFAC0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002C50")]
			[Address(RVA = "0x5E3CF0", Offset = "0x5E26F0", VA = "0x1805E3CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06002C51 RID: 11345 RVA: 0x0000FB88 File Offset: 0x0000DD88
		// (set) Token: 0x06002C52 RID: 11346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F6")]
		[JsonProperty]
		public bool EnableSpellDecalareCutin
		{
			[Token(Token = "0x6002C51")]
			[Address(RVA = "0x44F3C0", Offset = "0x44DDC0", VA = "0x18044F3C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C52")]
			[Address(RVA = "0x5E3CB0", Offset = "0x5E26B0", VA = "0x1805E3CB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06002C53 RID: 11347 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		// (set) Token: 0x06002C54 RID: 11348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F7")]
		[JsonProperty]
		public bool RunInBackground
		{
			[Token(Token = "0x6002C53")]
			[Address(RVA = "0x44F3B0", Offset = "0x44DDB0", VA = "0x18044F3B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C54")]
			[Address(RVA = "0x5E3CE0", Offset = "0x5E26E0", VA = "0x1805E3CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06002C55 RID: 11349 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		// (set) Token: 0x06002C56 RID: 11350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F8")]
		[JsonProperty]
		public bool UseLegacyQTEPannel
		{
			[Token(Token = "0x6002C55")]
			[Address(RVA = "0x5E3C60", Offset = "0x5E2660", VA = "0x1805E3C60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C56")]
			[Address(RVA = "0x5E3D00", Offset = "0x5E2700", VA = "0x1805E3D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06002C57 RID: 11351 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		// (set) Token: 0x06002C58 RID: 11352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005F9")]
		[JsonProperty]
		public bool UseLegacyThrowDeliver
		{
			[Token(Token = "0x6002C57")]
			[Address(RVA = "0x5E3C70", Offset = "0x5E2670", VA = "0x1805E3C70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C58")]
			[Address(RVA = "0x5E3D10", Offset = "0x5E2710", VA = "0x1805E3D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002C59 RID: 11353 RVA: 0x0000FBE8 File Offset: 0x0000DDE8
		// (set) Token: 0x06002C5A RID: 11354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FA")]
		[JsonProperty]
		public bool EnableLargerFontSize
		{
			[Token(Token = "0x6002C59")]
			[Address(RVA = "0x51B640", Offset = "0x51A040", VA = "0x18051B640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C5A")]
			[Address(RVA = "0x51B650", Offset = "0x51A050", VA = "0x18051B650")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002C5B RID: 11355 RVA: 0x0000FC00 File Offset: 0x0000DE00
		// (set) Token: 0x06002C5C RID: 11356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FB")]
		[JsonProperty]
		public PlayerSettings.SupportedResolution CurrentResolution
		{
			[Token(Token = "0x6002C5B")]
			[Address(RVA = "0x5E3C40", Offset = "0x5E2640", VA = "0x1805E3C40")]
			[CompilerGenerated]
			get
			{
				return PlayerSettings.SupportedResolution.NATIVE;
			}
			[Token(Token = "0x6002C5C")]
			[Address(RVA = "0x5E3CA0", Offset = "0x5E26A0", VA = "0x1805E3CA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06002C5D RID: 11357 RVA: 0x0000FC18 File Offset: 0x0000DE18
		// (set) Token: 0x06002C5E RID: 11358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FC")]
		[JsonProperty]
		public FullScreenMode FullScreenMode
		{
			[Token(Token = "0x6002C5D")]
			[Address(RVA = "0x44F9E0", Offset = "0x44E3E0", VA = "0x18044F9E0")]
			[CompilerGenerated]
			get
			{
				return FullScreenMode.ExclusiveFullScreen;
			}
			[Token(Token = "0x6002C5E")]
			[Address(RVA = "0x450630", Offset = "0x44F030", VA = "0x180450630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06002C5F RID: 11359 RVA: 0x0000FC30 File Offset: 0x0000DE30
		// (set) Token: 0x06002C60 RID: 11360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FD")]
		[JsonProperty]
		public bool Vsync
		{
			[Token(Token = "0x6002C5F")]
			[Address(RVA = "0x5E3C80", Offset = "0x5E2680", VA = "0x1805E3C80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C60")]
			[Address(RVA = "0x5E3D20", Offset = "0x5E2720", VA = "0x1805E3D20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002C61 RID: 11361 RVA: 0x0000FC48 File Offset: 0x0000DE48
		// (set) Token: 0x06002C62 RID: 11362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FE")]
		[JsonProperty]
		public PlayerSettings.SupportedRefreshRate TargetRefreshRate
		{
			[Token(Token = "0x6002C61")]
			[Address(RVA = "0x44F9C0", Offset = "0x44E3C0", VA = "0x18044F9C0")]
			[CompilerGenerated]
			get
			{
				return PlayerSettings.SupportedRefreshRate.R60;
			}
			[Token(Token = "0x6002C62")]
			[Address(RVA = "0x4B2A20", Offset = "0x4B1420", VA = "0x1804B2A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002C63 RID: 11363 RVA: 0x0000FC60 File Offset: 0x0000DE60
		// (set) Token: 0x06002C64 RID: 11364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005FF")]
		[JsonProperty]
		public MultiLanguageTextMesh.LoadLanguageType CurrentLanguage
		{
			[Token(Token = "0x6002C63")]
			[Address(RVA = "0x44FA10", Offset = "0x44E410", VA = "0x18044FA10")]
			[CompilerGenerated]
			get
			{
				return MultiLanguageTextMesh.LoadLanguageType.Chinese;
			}
			[Token(Token = "0x6002C64")]
			[Address(RVA = "0x4B2A30", Offset = "0x4B1430", VA = "0x1804B2A30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002C65 RID: 11365 RVA: 0x0000FC78 File Offset: 0x0000DE78
		// (set) Token: 0x06002C66 RID: 11366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000600")]
		[JsonProperty]
		public long MusicCalibrationOffset
		{
			[Token(Token = "0x6002C65")]
			[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6002C66")]
			[Address(RVA = "0x5E3CC0", Offset = "0x5E26C0", VA = "0x1805E3CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06002C67 RID: 11367 RVA: 0x0000FC90 File Offset: 0x0000DE90
		// (set) Token: 0x06002C68 RID: 11368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000601")]
		[JsonProperty]
		public bool CleanMusicGameMode
		{
			[Token(Token = "0x6002C67")]
			[Address(RVA = "0x494130", Offset = "0x492B30", VA = "0x180494130")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002C68")]
			[Address(RVA = "0x5E3C90", Offset = "0x5E2690", VA = "0x1805E3C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06002C69 RID: 11369 RVA: 0x0000FCA8 File Offset: 0x0000DEA8
		[Token(Token = "0x17000602")]
		public bool IsRecentVersion
		{
			[Token(Token = "0x6002C69")]
			[Address(RVA = "0x5E3C50", Offset = "0x5E2650", VA = "0x1805E3C50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002C6A RID: 11370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C6A")]
		[Address(RVA = "0x5E3770", Offset = "0x5E2170", VA = "0x1805E3770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400285F RID: 10335
		[Token(Token = "0x400285F")]
		public const int CURRENT_SETTING_VERSION = 5;

		// Token: 0x02000776 RID: 1910
		[Token(Token = "0x2000776")]
		public enum SupportedRefreshRate
		{
			// Token: 0x04002870 RID: 10352
			[Token(Token = "0x4002870")]
			R60,
			// Token: 0x04002871 RID: 10353
			[Token(Token = "0x4002871")]
			R120,
			// Token: 0x04002872 RID: 10354
			[Token(Token = "0x4002872")]
			R144,
			// Token: 0x04002873 RID: 10355
			[Token(Token = "0x4002873")]
			R240,
			// Token: 0x04002874 RID: 10356
			[Token(Token = "0x4002874")]
			UNLIMITED,
			// Token: 0x04002875 RID: 10357
			[Token(Token = "0x4002875")]
			SCREEEN
		}

		// Token: 0x02000777 RID: 1911
		[Token(Token = "0x2000777")]
		public enum SupportedResolution
		{
			// Token: 0x04002877 RID: 10359
			[Token(Token = "0x4002877")]
			NATIVE,
			// Token: 0x04002878 RID: 10360
			[Token(Token = "0x4002878")]
			X720,
			// Token: 0x04002879 RID: 10361
			[Token(Token = "0x4002879")]
			X768,
			// Token: 0x0400287A RID: 10362
			[Token(Token = "0x400287A")]
			X900,
			// Token: 0x0400287B RID: 10363
			[Token(Token = "0x400287B")]
			X1080,
			// Token: 0x0400287C RID: 10364
			[Token(Token = "0x400287C")]
			X2K,
			// Token: 0x0400287D RID: 10365
			[Token(Token = "0x400287D")]
			X4K
		}
	}
}

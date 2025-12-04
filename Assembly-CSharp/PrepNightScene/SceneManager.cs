using System;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace PrepNightScene
{
	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	[GenerateCleanupMethod]
	public class SceneManager : MonoSingleton<SceneManager>
	{
		// Token: 0x060003C4 RID: 964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x576840", Offset = "0x575240", VA = "0x180576840")]
		private void Start()
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x576750", Offset = "0x575150", VA = "0x180576750", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x5767A0", Offset = "0x5751A0", VA = "0x1805767A0")]
		private void OpenIzakayaConfigMenu()
		{
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x576A00", Offset = "0x575400", VA = "0x180576A00")]
		public void ToWork()
		{
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x3EE530", Offset = "0x3ECF30", VA = "0x1803EE530", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x576C70", Offset = "0x575670", VA = "0x180576C70")]
		public SceneManager()
		{
		}

		// Token: 0x040003F5 RID: 1013
		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x18")]
		[Header("Pannels")]
		public RectTransform PannelRoot;

		// Token: 0x040003F6 RID: 1014
		[Token(Token = "0x40003F6")]
		[FieldOffset(Offset = "0x20")]
		public LoopedBGMPackage bgm;
	}
}

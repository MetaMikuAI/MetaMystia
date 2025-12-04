using System;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace GameData
{
	// Token: 0x0200076E RID: 1902
	[Token(Token = "0x200076E")]
	[GenerateCleanupMethod]
	public class VersionDisplayer : MonoBehaviour
	{
		// Token: 0x06002C26 RID: 11302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C26")]
		[Address(RVA = "0x5FC950", Offset = "0x5FB350", VA = "0x1805FC950")]
		private void Awake()
		{
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C27")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C28")]
		[Address(RVA = "0x3EE530", Offset = "0x3ECF30", VA = "0x1803EE530", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C29")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public VersionDisplayer()
		{
		}

		// Token: 0x04002859 RID: 10329
		[Token(Token = "0x4002859")]
		[FieldOffset(Offset = "0x18")]
		public TextMeshProUGUI versionText;

		// Token: 0x0400285A RID: 10330
		[Token(Token = "0x400285A")]
		[FieldOffset(Offset = "0x20")]
		public MultiLanguageTextMesh.MultiLanguageString addOnText;
	}
}

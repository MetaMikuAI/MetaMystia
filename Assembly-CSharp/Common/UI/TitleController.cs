using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000DBB RID: 3515
	[Token(Token = "0x2000DBB")]
	[GenerateCleanupMethod]
	public class TitleController : MonoBehaviour
	{
		// Token: 0x06005270 RID: 21104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005270")]
		[Address(RVA = "0x801030", Offset = "0x7FFA30", VA = "0x180801030")]
		private void Start()
		{
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005271")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005272")]
		[Address(RVA = "0x3EA340", Offset = "0x3E8D40", VA = "0x1803EA340", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005273")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public TitleController()
		{
		}

		// Token: 0x04004D47 RID: 19783
		[Token(Token = "0x4004D47")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image m_Title;

		// Token: 0x04004D48 RID: 19784
		[Token(Token = "0x4004D48")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MultiLanguageSprite m_TitleSprite;
	}
}

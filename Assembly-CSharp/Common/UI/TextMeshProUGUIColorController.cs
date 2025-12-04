using System;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000E61 RID: 3681
	[Token(Token = "0x2000E61")]
	[GenerateCleanupMethod]
	public class TextMeshProUGUIColorController : MonoBehaviour
	{
		// Token: 0x06005609 RID: 22025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005609")]
		[Address(RVA = "0x861FC0", Offset = "0x8609C0", VA = "0x180861FC0")]
		public void Do(bool on)
		{
		}

		// Token: 0x0600560A RID: 22026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560A")]
		[Address(RVA = "0x861FA0", Offset = "0x8609A0", VA = "0x180861FA0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x0600560B RID: 22027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600560B")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public TextMeshProUGUIColorController()
		{
		}

		// Token: 0x040050CE RID: 20686
		[Token(Token = "0x40050CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color32 m_EnableColor;

		// Token: 0x040050CF RID: 20687
		[Token(Token = "0x40050CF")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color32 m_DisableColor;

		// Token: 0x040050D0 RID: 20688
		[Token(Token = "0x40050D0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI m_TextMeshProUGUI;
	}
}

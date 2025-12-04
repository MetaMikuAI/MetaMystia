using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Common.UI.CreatorsBox
{
	// Token: 0x02000F83 RID: 3971
	[Token(Token = "0x2000F83")]
	[RequireComponent(typeof(CanvasGroup))]
	public class CreatorsBoxTimelineInBetweenElement : MonoBehaviour
	{
		// Token: 0x06005D52 RID: 23890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D52")]
		[Address(RVA = "0x89F030", Offset = "0x89DA30", VA = "0x18089F030")]
		private void Awake()
		{
		}

		// Token: 0x06005D53 RID: 23891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D53")]
		[Address(RVA = "0x89F080", Offset = "0x89DA80", VA = "0x18089F080")]
		public void Setup(int amount)
		{
		}

		// Token: 0x06005D54 RID: 23892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D54")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public CreatorsBoxTimelineInBetweenElement()
		{
		}

		// Token: 0x0400567F RID: 22143
		[Token(Token = "0x400567F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI m_AmountText;

		// Token: 0x04005680 RID: 22144
		[Token(Token = "0x4005680")]
		[FieldOffset(Offset = "0x20")]
		private CanvasGroup m_CanvasGroup;
	}
}

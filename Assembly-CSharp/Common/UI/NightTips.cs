using System;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000DB5 RID: 3509
	[Token(Token = "0x2000DB5")]
	[GenerateCleanupMethod]
	public class NightTips : MonoBehaviour
	{
		// Token: 0x06005255 RID: 21077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005255")]
		[Address(RVA = "0x800070", Offset = "0x7FEA70", VA = "0x180800070")]
		private void Start()
		{
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005256")]
		[Address(RVA = "0x800020", Offset = "0x7FEA20", VA = "0x180800020")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005257")]
		[Address(RVA = "0x3EA340", Offset = "0x3E8D40", VA = "0x1803EA340", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005258")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public NightTips()
		{
		}

		// Token: 0x04004D37 RID: 19767
		[Token(Token = "0x4004D37")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI youmuChallengeTips;
	}
}

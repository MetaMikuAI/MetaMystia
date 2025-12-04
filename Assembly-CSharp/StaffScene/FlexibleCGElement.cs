using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace StaffScene
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	[GenerateCleanupMethod]
	public class FlexibleCGElement : MonoBehaviour
	{
		// Token: 0x060002E5 RID: 741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x3E85F0", Offset = "0x3E6FF0", VA = "0x1803E85F0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public FlexibleCGElement()
		{
		}

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x18")]
		public string unlockedEventLabel;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x20")]
		public FlexibleCGElement.FlexibleElement[] flexibleElements;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x28")]
		public CanvasGroup page;

		// Token: 0x02000088 RID: 136
		[Token(Token = "0x2000088")]
		[Serializable]
		public struct FlexibleElement
		{
			// Token: 0x040002CA RID: 714
			[Token(Token = "0x40002CA")]
			[FieldOffset(Offset = "0x0")]
			public string npcName;

			// Token: 0x040002CB RID: 715
			[Token(Token = "0x40002CB")]
			[FieldOffset(Offset = "0x8")]
			public GameObject visual;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace Common.UI.QTEUtility
{
	// Token: 0x02000E8D RID: 3725
	[Token(Token = "0x2000E8D")]
	[GenerateCleanupMethod]
	public class NoteHeadHoldEnd : NoteHeadBase
	{
		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x0600574C RID: 22348 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600574D RID: 22349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C31")]
		public NoteHeadHoldStart StartNote
		{
			[Token(Token = "0x600574C")]
			[Address(RVA = "0x440320", Offset = "0x43ED20", VA = "0x180440320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600574D")]
			[Address(RVA = "0x6086B0", Offset = "0x6070B0", VA = "0x1806086B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600574E RID: 22350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574E")]
		[Address(RVA = "0x856A20", Offset = "0x855420", VA = "0x180856A20", Slot = "20")]
		protected override void OnStatusChangedToPostPerfect()
		{
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600574F")]
		[Address(RVA = "0x856A00", Offset = "0x855400", VA = "0x180856A00", Slot = "19")]
		protected override void OnDemoModeStatusChangeToPostPerfect()
		{
		}

		// Token: 0x06005750 RID: 22352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005750")]
		[Address(RVA = "0x8569D0", Offset = "0x8553D0", VA = "0x1808569D0", Slot = "24")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005751 RID: 22353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005751")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public NoteHeadHoldEnd()
		{
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x0200103D RID: 4157
	[Token(Token = "0x200103D")]
	[GenerateCleanupMethod]
	public abstract class CharacterControllerUnitComponent : MonoBehaviour
	{
		// Token: 0x17000D44 RID: 3396
		// (get) Token: 0x06006002 RID: 24578 RVA: 0x000211E0 File Offset: 0x0001F3E0
		// (set) Token: 0x06006003 RID: 24579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D44")]
		public bool Ready
		{
			[Token(Token = "0x6006002")]
			[Address(RVA = "0x438D10", Offset = "0x437710", VA = "0x180438D10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006003")]
			[Address(RVA = "0x477190", Offset = "0x475B90", VA = "0x180477190")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006004 RID: 24580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006004")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006005 RID: 24581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006005")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06006006 RID: 24582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006006")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		protected CharacterControllerUnitComponent()
		{
		}
	}
}

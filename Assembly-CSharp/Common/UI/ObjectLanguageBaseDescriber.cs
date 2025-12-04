using System;
using System.Runtime.CompilerServices;
using System.Threading;
using GameData.CoreLanguage;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000DFF RID: 3583
	[Token(Token = "0x2000DFF")]
	[GenerateCleanupMethod]
	public class ObjectLanguageBaseDescriber : LanguageBaseDescriber, ITypedDescriber<ObjectLanguageBase>, IDescriber
	{
		// Token: 0x14000032 RID: 50
		// (add) Token: 0x060053B0 RID: 21424 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060053B1 RID: 21425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000032")]
		public event Action OnToggleToObjectLanguageBase
		{
			[Token(Token = "0x60053B0")]
			[Address(RVA = "0x83CFC0", Offset = "0x83B9C0", VA = "0x18083CFC0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60053B1")]
			[Address(RVA = "0x83D060", Offset = "0x83BA60", VA = "0x18083D060")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060053B2 RID: 21426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B2")]
		[Address(RVA = "0x83CF60", Offset = "0x83B960", VA = "0x18083CF60")]
		public void Describe(ObjectLanguageBase detail)
		{
		}

		// Token: 0x060053B3 RID: 21427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B3")]
		[Address(RVA = "0x83CF60", Offset = "0x83B960", VA = "0x18083CF60", Slot = "10")]
		public void Describe(ObjectLanguageBase detail, CancellationToken cancellationToken)
		{
		}

		// Token: 0x060053B4 RID: 21428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B4")]
		[Address(RVA = "0x83CE60", Offset = "0x83B860", VA = "0x18083CE60")]
		public void Describe(ObjectLanguageBase detail, Sprite bgSprite)
		{
		}

		// Token: 0x060053B5 RID: 21429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B5")]
		[Address(RVA = "0x83CF70", Offset = "0x83B970", VA = "0x18083CF70")]
		public void ToggleVisualForObjectLanguageBase()
		{
		}

		// Token: 0x060053B6 RID: 21430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B6")]
		[Address(RVA = "0x83CE00", Offset = "0x83B800", VA = "0x18083CE00", Slot = "9")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060053B7 RID: 21431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B7")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public ObjectLanguageBaseDescriber()
		{
		}

		// Token: 0x04004EA9 RID: 20137
		[Token(Token = "0x4004EA9")]
		[FieldOffset(Offset = "0x60")]
		[Header("Object")]
		public Image objectVisual;

		// Token: 0x04004EAA RID: 20138
		[Token(Token = "0x4004EAA")]
		[FieldOffset(Offset = "0x68")]
		public Image bgVisualParent;

		// Token: 0x04004EAB RID: 20139
		[Token(Token = "0x4004EAB")]
		[FieldOffset(Offset = "0x70")]
		public GameObject[] objectLanguageVisuals;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000E47 RID: 3655
	[Token(Token = "0x2000E47")]
	[GenerateCleanupMethod]
	public class SelectedPartnerDescriber : MonoBehaviour, ITypedDescriber<ValueTuple<int, PartnerBase.PartnerType>[]>, IDescriber
	{
		// Token: 0x0600556C RID: 21868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600556C")]
		[Address(RVA = "0x85C190", Offset = "0x85AB90", VA = "0x18085C190", Slot = "4")]
		public void Describe([TupleElementNames(new string[] { "CharacterId", "CharacterJob" })] ValueTuple<int, PartnerBase.PartnerType>[] partnerSelection, CancellationToken cancellationToken)
		{
		}

		// Token: 0x0600556D RID: 21869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600556D")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "5")]
		public void DescribeNull()
		{
		}

		// Token: 0x0600556E RID: 21870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600556E")]
		[Address(RVA = "0x85C100", Offset = "0x85AB00", VA = "0x18085C100", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x0600556F RID: 21871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600556F")]
		[Address(RVA = "0x85C6C0", Offset = "0x85B0C0", VA = "0x18085C6C0")]
		public SelectedPartnerDescriber()
		{
		}

		// Token: 0x04005048 RID: 20552
		[Token(Token = "0x4005048")]
		[FieldOffset(Offset = "0x18")]
		public GameObject multiPartnerParent;

		// Token: 0x04005049 RID: 20553
		[Token(Token = "0x4005049")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform partnerField;

		// Token: 0x0400504A RID: 20554
		[Token(Token = "0x400504A")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<GameObject> m_PartnerInstancesPool;

		// Token: 0x0400504B RID: 20555
		[Token(Token = "0x400504B")]
		[FieldOffset(Offset = "0x30")]
		public readonly string[] m_ColorBgCollection;
	}
}

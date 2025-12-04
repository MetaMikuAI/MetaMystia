using System;
using System.Collections.Generic;
using System.Threading;
using Common.UI;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI
{
	// Token: 0x020002F1 RID: 753
	[Token(Token = "0x20002F1")]
	[GenerateCleanupMethod]
	public class DaySceneMapDescriber : MonoBehaviour, ITypedDescriber<string>, IDescriber
	{
		// Token: 0x06001119 RID: 4377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001119")]
		[Address(RVA = "0x43B080", Offset = "0x439A80", VA = "0x18043B080")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600111A")]
		[Address(RVA = "0x941640", Offset = "0x940040", VA = "0x180941640", Slot = "4")]
		public void Describe(string mapName, CancellationToken cancellationToken)
		{
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600111B")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "5")]
		public void DescribeNull()
		{
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600111C")]
		[Address(RVA = "0x941570", Offset = "0x93FF70", VA = "0x180941570", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600111D")]
		[Address(RVA = "0x941AE0", Offset = "0x9404E0", VA = "0x180941AE0")]
		public DaySceneMapDescriber()
		{
		}

		// Token: 0x04000FDD RID: 4061
		[Token(Token = "0x4000FDD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI m_MapName;

		// Token: 0x04000FDE RID: 4062
		[Token(Token = "0x4000FDE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI m_MapDescription;

		// Token: 0x04000FDF RID: 4063
		[Token(Token = "0x4000FDF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_CollectablePrefab;

		// Token: 0x04000FE0 RID: 4064
		[Token(Token = "0x4000FE0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform m_CollectableField;

		// Token: 0x04000FE1 RID: 4065
		[Token(Token = "0x4000FE1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject m_CollectablePanel;

		// Token: 0x04000FE2 RID: 4066
		[Token(Token = "0x4000FE2")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<Sprite> m_Collectables;

		// Token: 0x04000FE3 RID: 4067
		[Token(Token = "0x4000FE3")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<GameObject> m_CollectablePool;
	}
}

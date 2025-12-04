using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.CreatorsBox
{
	// Token: 0x02000F80 RID: 3968
	[Token(Token = "0x2000F80")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(UIButtonSimple))]
	public class CreatorsBoxTimelineElement : MonoBehaviour
	{
		// Token: 0x06005D40 RID: 23872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D40")]
		[Address(RVA = "0x89E740", Offset = "0x89D140", VA = "0x18089E740")]
		public void Setup(int timeStamp, bool isEnd, bool isExtra, bool nextIsExtra, SpecialGuest specialGuest)
		{
		}

		// Token: 0x06005D41 RID: 23873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D41")]
		[Address(RVA = "0x580480", Offset = "0x57EE80", VA = "0x180580480", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06005D42 RID: 23874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D42")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public CreatorsBoxTimelineElement()
		{
		}

		// Token: 0x04005669 RID: 22121
		[Token(Token = "0x4005669")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite m_CenterVisual_Start;

		// Token: 0x0400566A RID: 22122
		[Token(Token = "0x400566A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite m_CenterVisual_Normal;

		// Token: 0x0400566B RID: 22123
		[Token(Token = "0x400566B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIElementCluster m_SpecialGuestElement;

		// Token: 0x0400566C RID: 22124
		[Token(Token = "0x400566C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup m_AvailableIndicator1;

		// Token: 0x0400566D RID: 22125
		[Token(Token = "0x400566D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup m_AvailableIndicator2;

		// Token: 0x0400566E RID: 22126
		[Token(Token = "0x400566E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI m_TimeStamp;

		// Token: 0x0400566F RID: 22127
		[Token(Token = "0x400566F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image m_CenterVisual;

		// Token: 0x04005670 RID: 22128
		[Token(Token = "0x4005670")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image m_LeftLine;

		// Token: 0x04005671 RID: 22129
		[Token(Token = "0x4005671")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image m_RightLine;

		// Token: 0x04005672 RID: 22130
		[Token(Token = "0x4005672")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color m_NormalColor;

		// Token: 0x04005673 RID: 22131
		[Token(Token = "0x4005673")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color m_ExtraColor;

		// Token: 0x04005674 RID: 22132
		[Token(Token = "0x4005674")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color m_NullGuestParentNameColor;

		// Token: 0x04005675 RID: 22133
		[Token(Token = "0x4005675")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color m_NullGuestParentAvatarMaskColor;
	}
}

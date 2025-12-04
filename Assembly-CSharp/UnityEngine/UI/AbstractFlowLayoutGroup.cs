using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	// Token: 0x02001046 RID: 4166
	[Token(Token = "0x2001046")]
	[ExecuteAlways]
	public abstract class AbstractFlowLayoutGroup : LayoutGroup
	{
		// Token: 0x0600605E RID: 24670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600605E")]
		[Address(RVA = "0x8B89C0", Offset = "0x8B73C0", VA = "0x1808B89C0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x17000D55 RID: 3413
		// (get) Token: 0x0600605F RID: 24671 RVA: 0x00021408 File Offset: 0x0001F608
		// (set) Token: 0x06006060 RID: 24672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D55")]
		public float spacing
		{
			[Token(Token = "0x600605F")]
			[Address(RVA = "0x440310", Offset = "0x43ED10", VA = "0x180440310")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6006060")]
			[Address(RVA = "0x8BADC0", Offset = "0x8B97C0", VA = "0x1808BADC0")]
			set
			{
			}
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06006061 RID: 24673 RVA: 0x00021420 File Offset: 0x0001F620
		// (set) Token: 0x06006062 RID: 24674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D56")]
		public float lineSpacing
		{
			[Token(Token = "0x6006061")]
			[Address(RVA = "0x4402D0", Offset = "0x43ECD0", VA = "0x1804402D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6006062")]
			[Address(RVA = "0x8BAD20", Offset = "0x8B9720", VA = "0x1808BAD20")]
			set
			{
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06006063 RID: 24675 RVA: 0x00021438 File Offset: 0x0001F638
		[Token(Token = "0x17000D57")]
		public virtual Vector2 Spacing
		{
			[Token(Token = "0x6006063")]
			[Address(RVA = "0x8BAB90", Offset = "0x8B9590", VA = "0x1808BAB90", Slot = "40")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06006064 RID: 24676 RVA: 0x00021450 File Offset: 0x0001F650
		// (set) Token: 0x06006065 RID: 24677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D58")]
		public bool childControlWidth
		{
			[Token(Token = "0x6006064")]
			[Address(RVA = "0x51B0D0", Offset = "0x519AD0", VA = "0x18051B0D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006065")]
			[Address(RVA = "0x8BAC30", Offset = "0x8B9630", VA = "0x1808BAC30")]
			set
			{
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06006066 RID: 24678 RVA: 0x00021468 File Offset: 0x0001F668
		// (set) Token: 0x06006067 RID: 24679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D59")]
		public bool childControlHeight
		{
			[Token(Token = "0x6006066")]
			[Address(RVA = "0x8BABB0", Offset = "0x8B95B0", VA = "0x1808BABB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006067")]
			[Address(RVA = "0x8BABE0", Offset = "0x8B95E0", VA = "0x1808BABE0")]
			set
			{
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06006068 RID: 24680 RVA: 0x00021480 File Offset: 0x0001F680
		// (set) Token: 0x06006069 RID: 24681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D5A")]
		public bool childScaleWidth
		{
			[Token(Token = "0x6006068")]
			[Address(RVA = "0x8BABD0", Offset = "0x8B95D0", VA = "0x1808BABD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006069")]
			[Address(RVA = "0x8BACD0", Offset = "0x8B96D0", VA = "0x1808BACD0")]
			set
			{
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x0600606A RID: 24682 RVA: 0x00021498 File Offset: 0x0001F698
		// (set) Token: 0x0600606B RID: 24683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D5B")]
		public bool childScaleHeight
		{
			[Token(Token = "0x600606A")]
			[Address(RVA = "0x8BABC0", Offset = "0x8B95C0", VA = "0x1808BABC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600606B")]
			[Address(RVA = "0x8BAC80", Offset = "0x8B9680", VA = "0x1808BAC80")]
			set
			{
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x0600606C RID: 24684 RVA: 0x000214B0 File Offset: 0x0001F6B0
		// (set) Token: 0x0600606D RID: 24685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D5C")]
		public bool reverseArrangement
		{
			[Token(Token = "0x600606C")]
			[Address(RVA = "0x6852F0", Offset = "0x683CF0", VA = "0x1806852F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600606D")]
			[Address(RVA = "0x8BAD70", Offset = "0x8B9770", VA = "0x1808BAD70")]
			set
			{
			}
		}

		// Token: 0x0600606E RID: 24686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600606E")]
		[Address(RVA = "0x8B8A20", Offset = "0x8B7420", VA = "0x1808B8A20")]
		protected void CalcAlongAxis(int axis, bool isVertical)
		{
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x0600606F RID: 24687 RVA: 0x000214C8 File Offset: 0x0001F6C8
		[Token(Token = "0x17000D5D")]
		public float GetWidth
		{
			[Token(Token = "0x600606F")]
			[Address(RVA = "0x8BAB10", Offset = "0x8B9510", VA = "0x1808BAB10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06006070 RID: 24688 RVA: 0x000214E0 File Offset: 0x0001F6E0
		[Token(Token = "0x17000D5E")]
		public float GetHeight
		{
			[Token(Token = "0x6006070")]
			[Address(RVA = "0x8BAAC0", Offset = "0x8B94C0", VA = "0x1808BAAC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06006071 RID: 24689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006071")]
		[Address(RVA = "0x8B93A0", Offset = "0x8B7DA0", VA = "0x1808B93A0")]
		protected void SetChildrenAlongAxis(int axis, bool isVertical)
		{
		}

		// Token: 0x06006072 RID: 24690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006072")]
		[Address(RVA = "0x8B9290", Offset = "0x8B7C90", VA = "0x1808B9290")]
		private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
		{
		}

		// Token: 0x06006073 RID: 24691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006073")]
		[Address(RVA = "0x8BAAB0", Offset = "0x8B94B0", VA = "0x1808BAAB0")]
		protected AbstractFlowLayoutGroup()
		{
		}

		// Token: 0x06006074 RID: 24692 RVA: 0x000214F8 File Offset: 0x0001F6F8
		[Token(Token = "0x6006074")]
		[Address(RVA = "0x8BA2E0", Offset = "0x8B8CE0", VA = "0x1808BA2E0")]
		[CompilerGenerated]
		private float <SetChildrenAlongAxis>g__CalcOtherAxisOffset|36_0(float delta, ref AbstractFlowLayoutGroup.<>c__DisplayClass36_0 A_2)
		{
			return 0f;
		}

		// Token: 0x06006075 RID: 24693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006075")]
		[Address(RVA = "0x8BA690", Offset = "0x8B9090", VA = "0x1808BA690")]
		[CompilerGenerated]
		private List<List<RectTransform>> <SetChildrenAlongAxis>g__DivideIntoRows|36_1(ref AbstractFlowLayoutGroup.<>c__DisplayClass36_0 A_1)
		{
			return null;
		}

		// Token: 0x06006076 RID: 24694 RVA: 0x00021510 File Offset: 0x0001F710
		[Token(Token = "0x6006076")]
		[Address(RVA = "0x8BA3E0", Offset = "0x8B8DE0", VA = "0x1808BA3E0")]
		[CompilerGenerated]
		private float <SetChildrenAlongAxis>g__CalcRowSize|36_2(int index, ref AbstractFlowLayoutGroup.<>c__DisplayClass36_0 A_2, ref AbstractFlowLayoutGroup.<>c__DisplayClass36_1 A_3)
		{
			return 0f;
		}

		// Token: 0x06006077 RID: 24695 RVA: 0x00021528 File Offset: 0x0001F728
		[Token(Token = "0x6006077")]
		[Address(RVA = "0x8BA340", Offset = "0x8B8D40", VA = "0x1808BA340")]
		[CompilerGenerated]
		private float <SetChildrenAlongAxis>g__CalcRowOffset|36_3(int index, ref AbstractFlowLayoutGroup.<>c__DisplayClass36_0 A_2, ref AbstractFlowLayoutGroup.<>c__DisplayClass36_1 A_3)
		{
			return 0f;
		}

		// Token: 0x04005912 RID: 22802
		[Token(Token = "0x4005912")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float m_Spacing;

		// Token: 0x04005913 RID: 22803
		[Token(Token = "0x4005913")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		protected float m_LineSpacing;

		// Token: 0x04005914 RID: 22804
		[Token(Token = "0x4005914")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected bool m_ChildControlWidth;

		// Token: 0x04005915 RID: 22805
		[Token(Token = "0x4005915")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		protected bool m_ChildControlHeight;

		// Token: 0x04005916 RID: 22806
		[Token(Token = "0x4005916")]
		[FieldOffset(Offset = "0x62")]
		[SerializeField]
		protected bool m_ChildScaleWidth;

		// Token: 0x04005917 RID: 22807
		[Token(Token = "0x4005917")]
		[FieldOffset(Offset = "0x63")]
		[SerializeField]
		protected bool m_ChildScaleHeight;

		// Token: 0x04005918 RID: 22808
		[Token(Token = "0x4005918")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		protected bool m_ReverseArrangement;
	}
}

using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.UI.CookingUtility
{
	// Token: 0x0200070B RID: 1803
	[Token(Token = "0x200070B")]
	[GenerateCleanupMethod]
	public class CookingStatusModule : MonoBehaviour
	{
		// Token: 0x170005E1 RID: 1505
		// (set) Token: 0x06002AA1 RID: 10913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E1")]
		private Sprite BarSprite
		{
			[Token(Token = "0x6002AA1")]
			[Address(RVA = "0x580460", Offset = "0x57EE60", VA = "0x180580460")]
			set
			{
			}
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA2")]
		[Address(RVA = "0x5802F0", Offset = "0x57ECF0", VA = "0x1805802F0")]
		public void Start()
		{
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA3")]
		[Address(RVA = "0x580190", Offset = "0x57EB90", VA = "0x180580190")]
		public void SetProgress(float progress)
		{
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA4")]
		[Address(RVA = "0x580230", Offset = "0x57EC30", VA = "0x180580230")]
		public void Show()
		{
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA5")]
		[Address(RVA = "0x5800D0", Offset = "0x57EAD0", VA = "0x1805800D0")]
		public void Finish()
		{
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA6")]
		[Address(RVA = "0x580100", Offset = "0x57EB00", VA = "0x180580100")]
		public void Hide()
		{
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA7")]
		[Address(RVA = "0x580060", Offset = "0x57EA60", VA = "0x180580060", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA8")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public CookingStatusModule()
		{
		}

		// Token: 0x04002719 RID: 10009
		[Token(Token = "0x4002719")]
		[FieldOffset(Offset = "0x18")]
		public SpriteRenderer indicator;

		// Token: 0x0400271A RID: 10010
		[Token(Token = "0x400271A")]
		[FieldOffset(Offset = "0x20")]
		public SpriteRenderer body;

		// Token: 0x0400271B RID: 10011
		[Token(Token = "0x400271B")]
		[FieldOffset(Offset = "0x28")]
		public float transitionDuration;

		// Token: 0x0400271C RID: 10012
		[Token(Token = "0x400271C")]
		[FieldOffset(Offset = "0x30")]
		public Sprite cooking;

		// Token: 0x0400271D RID: 10013
		[Token(Token = "0x400271D")]
		[FieldOffset(Offset = "0x38")]
		public Sprite finishCook;

		// Token: 0x0400271E RID: 10014
		[Token(Token = "0x400271E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2 m_SizeMinMax;
	}
}

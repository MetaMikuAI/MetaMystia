using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.EventSystem.Spells.SpecialItem
{
	// Token: 0x0200011A RID: 282
	[Token(Token = "0x200011A")]
	public class Ellen_Candy : MonoBehaviour
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060006DD RID: 1757 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060006DE RID: 1758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000005")]
		public event Action<Ellen_Candy> OnPlayerGetCallback
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x6E7F90", Offset = "0x6E6990", VA = "0x1806E7F90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x6E8040", Offset = "0x6E6A40", VA = "0x1806E8040")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x6E7CE0", Offset = "0x6E66E0", VA = "0x1806E7CE0")]
		public void Start()
		{
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x531450", Offset = "0x52FE50", VA = "0x180531450")]
		public void SetPlayerTransform(Transform player)
		{
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x6E7D00", Offset = "0x6E6700", VA = "0x1806E7D00")]
		public void Update()
		{
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x6E7C80", Offset = "0x6E6680", VA = "0x1806E7C80")]
		public void OnTriggerEnter2D(Collider2D col)
		{
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x6E7C00", Offset = "0x6E6600", VA = "0x1806E7C00")]
		private void Get()
		{
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x6E7BA0", Offset = "0x6E65A0", VA = "0x1806E7BA0")]
		private void DisAppear()
		{
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x6E7F70", Offset = "0x6E6970", VA = "0x1806E7F70")]
		public Ellen_Candy()
		{
		}

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0x18")]
		public int lifeTime;

		// Token: 0x040006A3 RID: 1699
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x1C")]
		public float swallowSpeed;

		// Token: 0x040006A4 RID: 1700
		[Token(Token = "0x40006A4")]
		[FieldOffset(Offset = "0x20")]
		public float swallowRadius;

		// Token: 0x040006A5 RID: 1701
		[Token(Token = "0x40006A5")]
		[FieldOffset(Offset = "0x24")]
		private float leftTime;

		// Token: 0x040006A6 RID: 1702
		[Token(Token = "0x40006A6")]
		[FieldOffset(Offset = "0x28")]
		private bool swallowMode;

		// Token: 0x040006A7 RID: 1703
		[Token(Token = "0x40006A7")]
		[FieldOffset(Offset = "0x29")]
		private bool hasDisappear;

		// Token: 0x040006A8 RID: 1704
		[Token(Token = "0x40006A8")]
		[FieldOffset(Offset = "0x30")]
		private Transform playerTransform;
	}
}

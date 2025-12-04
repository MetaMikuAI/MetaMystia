using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.EventSystem.Spells.SpecialItem
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	[GenerateCleanupMethod]
	public class Yukari_Kima : MonoBehaviour
	{
		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060006E6 RID: 1766 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060006E7 RID: 1767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000006")]
		public event Action<GameObject> OnPlayerEnterKima
		{
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x6FC620", Offset = "0x6FB020", VA = "0x1806FC620")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x6FC780", Offset = "0x6FB180", VA = "0x1806FC780")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060006E8 RID: 1768 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060006E9 RID: 1769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000007")]
		public event Action<Yukari_Kima> OnKimaChangePosition
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x6FC570", Offset = "0x6FAF70", VA = "0x1806FC570")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x6FC6D0", Offset = "0x6FB0D0", VA = "0x1806FC6D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x00003A68 File Offset: 0x00001C68
		// (set) Token: 0x060006EB RID: 1771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000081")]
		public bool CanBeTrigger
		{
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x685340", Offset = "0x683D40", VA = "0x180685340")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x6FC830", Offset = "0x6FB230", VA = "0x1806FC830")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00003A80 File Offset: 0x00001C80
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000082")]
		public float WaitChangePositionTime
		{
			[Token(Token = "0x60006EC")]
			[Address(RVA = "0x689190", Offset = "0x687B90", VA = "0x180689190")]
			[CompilerGenerated]
			private get
			{
				return 0f;
			}
			[Token(Token = "0x60006ED")]
			[Address(RVA = "0x6FC850", Offset = "0x6FB250", VA = "0x1806FC850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x00003A98 File Offset: 0x00001C98
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000083")]
		public Vector2Int OccupyPosition
		{
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
			[CompilerGenerated]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x6FC840", Offset = "0x6FB240", VA = "0x1806FC840")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x6FC4C0", Offset = "0x6FAEC0", VA = "0x1806FC4C0")]
		private void Start()
		{
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x6FC510", Offset = "0x6FAF10", VA = "0x1806FC510")]
		private void Update()
		{
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x6FC440", Offset = "0x6FAE40", VA = "0x1806FC440")]
		public void OnTriggerEnter2D(Collider2D col)
		{
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x6FC4C0", Offset = "0x6FAEC0", VA = "0x1806FC4C0")]
		private void OnTriggerExit2D(Collider2D col)
		{
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x6FC4D0", Offset = "0x6FAED0", VA = "0x1806FC4D0")]
		private void Teleport()
		{
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x3EE530", Offset = "0x3ECF30", VA = "0x1803EE530", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public Yukari_Kima()
		{
		}
	}
}

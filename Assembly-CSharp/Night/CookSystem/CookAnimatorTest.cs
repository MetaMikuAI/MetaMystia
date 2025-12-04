using System;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using NightScene.UI.CookingUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.CookSystem
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	[GenerateCleanupMethod]
	public class CookAnimatorTest : MonoBehaviour
	{
		// Token: 0x060006F7 RID: 1783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500")]
		private void Start()
		{
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x6DE280", Offset = "0x6DCC80", VA = "0x1806DE280")]
		private void OnValidate()
		{
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x6DE240", Offset = "0x6DCC40", VA = "0x1806DE240", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public CookAnimatorTest()
		{
		}

		// Token: 0x040006AF RID: 1711
		[Token(Token = "0x40006AF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CookerProfile m_CookerProfile;

		// Token: 0x040006B0 RID: 1712
		[Token(Token = "0x40006B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_CookerIndex;

		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x40006B1")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CookController.CookPhase m_State;

		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0x28")]
		private CookAnimator m_Animator;

		// Token: 0x040006B3 RID: 1715
		[Token(Token = "0x40006B3")]
		[FieldOffset(Offset = "0x30")]
		private CookController.CookPhase m_LastState;
	}
}

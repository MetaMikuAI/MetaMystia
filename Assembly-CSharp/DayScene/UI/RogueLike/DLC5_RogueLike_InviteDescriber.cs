using System;
using System.Threading;
using Common.UI;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x200043C")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLike_InviteDescriber : MonoBehaviour, ITypedDescriber<SpecialGuest>, IDescriber
	{
		// Token: 0x060017E9 RID: 6121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E9")]
		[Address(RVA = "0x476690", Offset = "0x475090", VA = "0x180476690", Slot = "4")]
		public void Describe(SpecialGuest detail, CancellationToken cancellationToken)
		{
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017EA")]
		[Address(RVA = "0x476670", Offset = "0x475070", VA = "0x180476670", Slot = "5")]
		public void DescribeNull()
		{
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017EB")]
		[Address(RVA = "0x43B080", Offset = "0x439A80", VA = "0x18043B080")]
		private void OnDestroy()
		{
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017EC")]
		[Address(RVA = "0x3EA340", Offset = "0x3E8D40", VA = "0x1803EA340", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017ED")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public DLC5_RogueLike_InviteDescriber()
		{
		}

		// Token: 0x04001683 RID: 5763
		[Token(Token = "0x4001683")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpecialGuestDescriber m_SpecialGuestDescriber;
	}
}

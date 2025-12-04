using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	[GenerateCleanupMethod]
	public class DLC4_BulletFlandreHakaiShin : DLC4_BulletEnemy
	{
		// Token: 0x06000888 RID: 2184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x823F40", Offset = "0x822940", VA = "0x180823F40")]
		public void AfterInitialize(int targetDeskCode, Vector3Int targetPosition)
		{
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x824100", Offset = "0x822B00", VA = "0x180824100", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x823970", Offset = "0x822370", VA = "0x180823970", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		public DLC4_BulletFlandreHakaiShin()
		{
		}

		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 moveDirection;

		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		[FieldOffset(Offset = "0x8C")]
		private int targetDeskCode;

		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 targetPosition;
	}
}

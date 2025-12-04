using System;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;

namespace NightScene.CookingUtility
{
	// Token: 0x02000694 RID: 1684
	[Token(Token = "0x2000694")]
	[GenerateCleanupMethod]
	public class QTERewardManager : MonoSingleton<QTERewardManager>
	{
		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000594")]
		[CleanupIgnore]
		public QTEBuffReward CurrentBuffReward
		{
			[Token(Token = "0x60027BA")]
			[Address(RVA = "0x531A40", Offset = "0x530440", VA = "0x180531A40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60027BB")]
			[Address(RVA = "0x531AC0", Offset = "0x5304C0", VA = "0x180531AC0")]
			set
			{
			}
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BC")]
		[Address(RVA = "0x531970", Offset = "0x530370", VA = "0x180531970")]
		public void ResetBuffReward()
		{
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BD")]
		[Address(RVA = "0x5319D0", Offset = "0x5303D0", VA = "0x1805319D0")]
		public void TryOpenRemotePanel(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BE")]
		[Address(RVA = "0x531920", Offset = "0x530320", VA = "0x180531920")]
		public void OnQTESucceeded(int index = -1, bool mustSuccess = false)
		{
		}

		// Token: 0x060027BF RID: 10175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027BF")]
		[Address(RVA = "0x531610", Offset = "0x530010", VA = "0x180531610")]
		public void Initialize(Transform playerCharacter)
		{
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C0")]
		[Address(RVA = "0x531870", Offset = "0x530270", VA = "0x180531870", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C1")]
		[Address(RVA = "0x5315C0", Offset = "0x52FFC0", VA = "0x1805315C0", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C2")]
		[Address(RVA = "0x531A00", Offset = "0x530400", VA = "0x180531A00")]
		public QTERewardManager()
		{
		}

		// Token: 0x04002422 RID: 9250
		[Token(Token = "0x4002422")]
		[FieldOffset(Offset = "0x18")]
		public QTEBuffReward defaultBuffReward;

		// Token: 0x04002423 RID: 9251
		[Token(Token = "0x4002423")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool disableReward;

		// Token: 0x04002424 RID: 9252
		[Token(Token = "0x4002424")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private QTEBuffReward currentBuffReward;

		// Token: 0x04002425 RID: 9253
		[Token(Token = "0x4002425")]
		[FieldOffset(Offset = "0x30")]
		private Transform playerCharacter;
	}
}

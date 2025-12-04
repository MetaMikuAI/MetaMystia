using System;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000DB8 RID: 3512
	[Token(Token = "0x2000DB8")]
	[GenerateCleanupMethod]
	public class Tips : MonoBehaviour
	{
		// Token: 0x06005262 RID: 21090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005262")]
		[Address(RVA = "0x800D80", Offset = "0x7FF780", VA = "0x180800D80")]
		private void Start()
		{
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005263")]
		[Address(RVA = "0x800A20", Offset = "0x7FF420", VA = "0x180800A20")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005264")]
		[Address(RVA = "0x801020", Offset = "0x7FFA20", VA = "0x180801020")]
		public void TryRefresh()
		{
		}

		// Token: 0x06005265 RID: 21093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005265")]
		[Address(RVA = "0x800880", Offset = "0x7FF280", VA = "0x180800880")]
		private void Dispose()
		{
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005266")]
		[Address(RVA = "0x800AF0", Offset = "0x7FF4F0", VA = "0x180800AF0")]
		private void PerformRefresh()
		{
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005267")]
		[Address(RVA = "0x800E80", Offset = "0x7FF880", VA = "0x180800E80")]
		private void StoreLockdownTipsRefresh()
		{
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005268")]
		[Address(RVA = "0x800940", Offset = "0x7FF340", VA = "0x180800940")]
		private void ImportantMissionTipsRefresh()
		{
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005269")]
		[Address(RVA = "0x8006A0", Offset = "0x7FF0A0", VA = "0x1808006A0")]
		private void ChenShopUpgradeEventTipsRefresh()
		{
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600526A")]
		[Address(RVA = "0x3E85F0", Offset = "0x3E6FF0", VA = "0x1803E85F0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600526B")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public Tips()
		{
		}

		// Token: 0x04004D3C RID: 19772
		[Token(Token = "0x4004D3C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI storeLockdownTips;

		// Token: 0x04004D3D RID: 19773
		[Token(Token = "0x4004D3D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI importantMissionTips;

		// Token: 0x04004D3E RID: 19774
		[Token(Token = "0x4004D3E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI shopUpgrateMissionTips;

		// Token: 0x04004D3F RID: 19775
		[Token(Token = "0x4004D3F")]
		[FieldOffset(Offset = "0x30")]
		private bool hasInitialized;
	}
}

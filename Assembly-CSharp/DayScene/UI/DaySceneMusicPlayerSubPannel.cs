using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace DayScene.UI
{
	// Token: 0x020002D6 RID: 726
	[Token(Token = "0x20002D6")]
	[GenerateCleanupMethod]
	public class DaySceneMusicPlayerSubPannel : UISubPanel<DaySceneMusicPlayerPannel>
	{
		// Token: 0x06001060 RID: 4192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001060")]
		[Address(RVA = "0x927940", Offset = "0x926340", VA = "0x180927940", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001061")]
		[Address(RVA = "0x928090", Offset = "0x926A90", VA = "0x180928090")]
		private void Play()
		{
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001062")]
		[Address(RVA = "0x928460", Offset = "0x926E60", VA = "0x180928460")]
		private void Stop()
		{
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001063")]
		[Address(RVA = "0x927F30", Offset = "0x926930", VA = "0x180927F30")]
		private void PlayCurrentInIzakaya()
		{
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001064")]
		[Address(RVA = "0x927FE0", Offset = "0x9269E0", VA = "0x180927FE0")]
		private void PlayWholeSetInIzakaya()
		{
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001065")]
		[Address(RVA = "0x9283D0", Offset = "0x926DD0", VA = "0x1809283D0")]
		private void ResetIzakayaBGM()
		{
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001066")]
		[Address(RVA = "0x928500", Offset = "0x926F00", VA = "0x180928500")]
		private void TryReleaseCurrentPlayingPackage()
		{
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001067")]
		[Address(RVA = "0x927CB0", Offset = "0x9266B0", VA = "0x180927CB0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001068")]
		[Address(RVA = "0x927890", Offset = "0x926290", VA = "0x180927890")]
		private void ClearCurrentPlayingBGM(string _)
		{
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001069")]
		[Address(RVA = "0x574C10", Offset = "0x573610", VA = "0x180574C10", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600106A")]
		[Address(RVA = "0x9287A0", Offset = "0x9271A0", VA = "0x1809287A0")]
		public DaySceneMusicPlayerSubPannel()
		{
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600106C")]
		[Address(RVA = "0x928640", Offset = "0x927040", VA = "0x180928640")]
		[CompilerGenerated]
		private void <Play>g__OnLoadFinish|7_0(AsyncOperationHandle loadedBgmPackage)
		{
		}

		// Token: 0x04000F14 RID: 3860
		[Token(Token = "0x4000F14")]
		[FieldOffset(Offset = "0x78")]
		public UIButtonToggle PlayBtn;

		// Token: 0x04000F15 RID: 3861
		[Token(Token = "0x4000F15")]
		[FieldOffset(Offset = "0x80")]
		public UIButtonToggle PlayCurrentInIzakayaBtn;

		// Token: 0x04000F16 RID: 3862
		[Token(Token = "0x4000F16")]
		[FieldOffset(Offset = "0x88")]
		public UIButtonToggle PlayWholeSetInIzakayaBtn;

		// Token: 0x04000F17 RID: 3863
		[Token(Token = "0x4000F17")]
		[FieldOffset(Offset = "0x90")]
		private bool hasAddReset;

		// Token: 0x04000F18 RID: 3864
		[Token(Token = "0x4000F18")]
		[FieldOffset(Offset = "0x98")]
		private AsyncOperationHandle m_CurrentPlayingBGMHandle;

		// Token: 0x04000F19 RID: 3865
		[Token(Token = "0x4000F19")]
		[FieldOffset(Offset = "0xB0")]
		private int? m_CurrentPlayingBGMId;
	}
}

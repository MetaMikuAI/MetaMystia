using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.EventUtility
{
	// Token: 0x020006F9 RID: 1785
	[Token(Token = "0x20006F9")]
	[GenerateCleanupMethod]
	public class BuffElement : MonoBehaviour
	{
		// Token: 0x170005DD RID: 1501
		// (set) Token: 0x06002A44 RID: 10820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DD")]
		[CleanupIgnore]
		private string Count
		{
			[Token(Token = "0x6002A44")]
			[Address(RVA = "0x57DE30", Offset = "0x57C830", VA = "0x18057DE30")]
			set
			{
			}
		}

		// Token: 0x170005DE RID: 1502
		// (set) Token: 0x06002A45 RID: 10821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005DE")]
		[CleanupIgnore]
		private Sprite Visual
		{
			[Token(Token = "0x6002A45")]
			[Address(RVA = "0x57DE90", Offset = "0x57C890", VA = "0x18057DE90")]
			set
			{
			}
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A46")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A47")]
		[Address(RVA = "0x57DBA0", Offset = "0x57C5A0", VA = "0x18057DBA0")]
		public void InitializeVisual(Sprite visual, string title, Action onPointerFocusToBuffCallback, Action onPointExitBuffCallback)
		{
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A48")]
		[Address(RVA = "0x57DDC0", Offset = "0x57C7C0", VA = "0x18057DDC0")]
		public void UpdateBuff(string context, float progress)
		{
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A49")]
		[Address(RVA = "0x57DD30", Offset = "0x57C730", VA = "0x18057DD30")]
		public void UpdateBuff(string context, int count)
		{
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4A")]
		[Address(RVA = "0x57DAB0", Offset = "0x57C4B0", VA = "0x18057DAB0")]
		public void GetBuffInformation(Action<string> onUpdateDescriptionCallack, out Sprite visual, out string title, out string currentDescription, out Action onCancelSubscriptionCallback)
		{
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4B")]
		[Address(RVA = "0x57DCF0", Offset = "0x57C6F0", VA = "0x18057DCF0")]
		public void ToggleHighlight(bool doHighlight)
		{
		}

		// Token: 0x06002A4C RID: 10828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4C")]
		[Address(RVA = "0x57D9F0", Offset = "0x57C3F0", VA = "0x18057D9F0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4D")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public BuffElement()
		{
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4E")]
		[Address(RVA = "0x57DD10", Offset = "0x57C710", VA = "0x18057DD10")]
		[CompilerGenerated]
		private void <GetBuffInformation>g__CancelSubscription|19_0()
		{
		}

		// Token: 0x040026CC RID: 9932
		[Token(Token = "0x40026CC")]
		[FieldOffset(Offset = "0x18")]
		public RectTransform elementTransform;

		// Token: 0x040026CD RID: 9933
		[Token(Token = "0x40026CD")]
		[FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI count;

		// Token: 0x040026CE RID: 9934
		[Token(Token = "0x40026CE")]
		[FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI altCount;

		// Token: 0x040026CF RID: 9935
		[Token(Token = "0x40026CF")]
		[FieldOffset(Offset = "0x30")]
		public Image visual;

		// Token: 0x040026D0 RID: 9936
		[Token(Token = "0x40026D0")]
		[FieldOffset(Offset = "0x38")]
		public Image visualOutline;

		// Token: 0x040026D1 RID: 9937
		[Token(Token = "0x40026D1")]
		[FieldOffset(Offset = "0x40")]
		public Image progress;

		// Token: 0x040026D2 RID: 9938
		[Token(Token = "0x40026D2")]
		[FieldOffset(Offset = "0x48")]
		public Transform previewPoint;

		// Token: 0x040026D3 RID: 9939
		[Token(Token = "0x40026D3")]
		[FieldOffset(Offset = "0x50")]
		public UIButtonSimple interactableBase;

		// Token: 0x040026D4 RID: 9940
		[Token(Token = "0x40026D4")]
		[FieldOffset(Offset = "0x58")]
		[TextArea]
		public string title;

		// Token: 0x040026D5 RID: 9941
		[Token(Token = "0x40026D5")]
		[FieldOffset(Offset = "0x60")]
		[TextArea]
		public string description;

		// Token: 0x040026D6 RID: 9942
		[Token(Token = "0x40026D6")]
		[FieldOffset(Offset = "0x68")]
		private Action<string> onUpdateDescriptionCallack;
	}
}

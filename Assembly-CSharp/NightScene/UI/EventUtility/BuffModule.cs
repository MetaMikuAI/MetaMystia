using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;

namespace NightScene.UI.EventUtility
{
	// Token: 0x020006FA RID: 1786
	[Token(Token = "0x20006FA")]
	[GenerateCleanupMethod]
	public class BuffModule : MonoBehaviour
	{
		// Token: 0x06002A4F RID: 10831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A4F")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		[Token(Token = "0x6002A50")]
		[Address(RVA = "0x57EA50", Offset = "0x57D450", VA = "0x18057EA50")]
		public bool TryGetBuffElement(Guid buffId, out BuffElement buffElement)
		{
			return default(bool);
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A51")]
		[Address(RVA = "0x57E4A0", Offset = "0x57CEA0", VA = "0x18057E4A0")]
		public void RegisterBuff(Sprite visual, string buffTitle, Guid guid, out Action<string, float> onBuffUpdate, out Action<string, int> onBuffCountUpdate, out Action onBuffEnd)
		{
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A52")]
		[Address(RVA = "0x57E040", Offset = "0x57CA40", VA = "0x18057E040")]
		public void GetTargetElementTransform(Guid guid, out Transform targetTransform)
		{
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A53")]
		[Address(RVA = "0x57E280", Offset = "0x57CC80", VA = "0x18057E280")]
		public void Initialize()
		{
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A54")]
		[Address(RVA = "0x57ED90", Offset = "0x57D790", VA = "0x18057ED90")]
		private void UpdateCurrentFocusingDescriptor()
		{
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A55")]
		[Address(RVA = "0x57E340", Offset = "0x57CD40", VA = "0x18057E340")]
		public void OnExecuteNavigateAction(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A56")]
		[Address(RVA = "0x57DFB0", Offset = "0x57C9B0", VA = "0x18057DFB0")]
		private void CloseCurrentSelection()
		{
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A57")]
		[Address(RVA = "0x57F490", Offset = "0x57DE90", VA = "0x18057F490")]
		private void UpdatePannelAlpha(float alpha)
		{
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A58")]
		[Address(RVA = "0x57E2B0", Offset = "0x57CCB0", VA = "0x18057E2B0")]
		private void NotifyBuffDescriptor()
		{
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A59")]
		[Address(RVA = "0x57DEF0", Offset = "0x57C8F0", VA = "0x18057DEF0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5A")]
		[Address(RVA = "0x57F4B0", Offset = "0x57DEB0", VA = "0x18057F4B0")]
		public BuffModule()
		{
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002A5B")]
		[Address(RVA = "0x57EC80", Offset = "0x57D680", VA = "0x18057EC80")]
		[CompilerGenerated]
		private IEnumerator <NotifyBuffDescriptor>g__Loop|21_0()
		{
			return null;
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		[Token(Token = "0x6002A5C")]
		[Address(RVA = "0x57ED00", Offset = "0x57D700", VA = "0x18057ED00")]
		[CompilerGenerated]
		private bool <NotifyBuffDescriptor>g__ShowBuffDescriptor|21_1()
		{
			return default(bool);
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A5D")]
		[Address(RVA = "0x57EC10", Offset = "0x57D610", VA = "0x18057EC10")]
		[CompilerGenerated]
		private void <NotifyBuffDescriptor>g__HideBuffDescriptor|21_2()
		{
		}

		// Token: 0x040026D7 RID: 9943
		[Token(Token = "0x40026D7")]
		private const float BUFF_ELEMENT_RANDOM_RANGE = 3f;

		// Token: 0x040026D8 RID: 9944
		[Token(Token = "0x40026D8")]
		[FieldOffset(Offset = "0x18")]
		public GameObject buffElement;

		// Token: 0x040026D9 RID: 9945
		[Token(Token = "0x40026D9")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform buffField;

		// Token: 0x040026DA RID: 9946
		[Token(Token = "0x40026DA")]
		[FieldOffset(Offset = "0x28")]
		public UIElementCluster descriptor;

		// Token: 0x040026DB RID: 9947
		[Token(Token = "0x40026DB")]
		[FieldOffset(Offset = "0x30")]
		public CanvasGroup canvasGroup;

		// Token: 0x040026DC RID: 9948
		[Token(Token = "0x40026DC")]
		[FieldOffset(Offset = "0x38")]
		public float buffDescriberStayDuraion;

		// Token: 0x040026DD RID: 9949
		[Token(Token = "0x40026DD")]
		[FieldOffset(Offset = "0x40")]
		private readonly Queue<BuffElement> cachedBuffElement;

		// Token: 0x040026DE RID: 9950
		[Token(Token = "0x40026DE")]
		[FieldOffset(Offset = "0x48")]
		private readonly Vector3[] m_FourCornerWorldBuffer;

		// Token: 0x040026DF RID: 9951
		[Token(Token = "0x40026DF")]
		[FieldOffset(Offset = "0x50")]
		[TupleElementNames(new string[] { "BuffIdentifier", "BuffGUIData" })]
		private readonly List<ValueTuple<Guid, BuffElement>> registeredBuffElement;

		// Token: 0x040026E0 RID: 9952
		[Token(Token = "0x40026E0")]
		[FieldOffset(Offset = "0x58")]
		private int currentFocusingBuffIndex;

		// Token: 0x040026E1 RID: 9953
		[Token(Token = "0x40026E1")]
		[FieldOffset(Offset = "0x60")]
		private Action onCancelLastSubscriptionCallback;

		// Token: 0x040026E2 RID: 9954
		[Token(Token = "0x40026E2")]
		[FieldOffset(Offset = "0x68")]
		private bool isFoucusing;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Common.UI.GlobalMap
{
	// Token: 0x02000F9D RID: 3997
	[Token(Token = "0x2000F9D")]
	[RequireComponent(typeof(CanvasGroup), typeof(UIButtonSimple))]
	public class GuideMapSpot : MonoBehaviour, IGuideMapSpot, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x06005DE9 RID: 24041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE9")]
		[Address(RVA = "0x8AFB00", Offset = "0x8AE500", VA = "0x1808AFB00")]
		public static void DisablePointerInteraction()
		{
		}

		// Token: 0x06005DEA RID: 24042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DEA")]
		[Address(RVA = "0x8AFBA0", Offset = "0x8AE5A0", VA = "0x1808AFBA0")]
		public static void EnablePointerInteraction()
		{
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06005DEB RID: 24043 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005DEC RID: 24044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D18")]
		public string MapName
		{
			[Token(Token = "0x6005DEB")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005DEC")]
			[Address(RVA = "0x3FC090", Offset = "0x3FAA90", VA = "0x1803FC090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06005DED RID: 24045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D19")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x6005DED")]
			[Address(RVA = "0x8AFF20", Offset = "0x8AE920", VA = "0x1808AFF20", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005DEE RID: 24046 RVA: 0x000207F0 File Offset: 0x0001E9F0
		[Token(Token = "0x6005DEE")]
		[Address(RVA = "0x8AFBF0", Offset = "0x8AE5F0", VA = "0x1808AFBF0", Slot = "7")]
		public bool MatchesMapNameOrSubset(string mapName)
		{
			return default(bool);
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x06005DEF RID: 24047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D1A")]
		public string PrimaryName
		{
			[Token(Token = "0x6005DEF")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x06005DF0 RID: 24048 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005DF1 RID: 24049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D1B")]
		public UIButtonSimple UIButton
		{
			[Token(Token = "0x6005DF0")]
			[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005DF1")]
			[Address(RVA = "0x51B180", Offset = "0x519B80", VA = "0x18051B180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06005DF2 RID: 24050 RVA: 0x00020808 File Offset: 0x0001EA08
		// (set) Token: 0x06005DF3 RID: 24051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D1C")]
		public bool IsActivated
		{
			[Token(Token = "0x6005DF2")]
			[Address(RVA = "0x734090", Offset = "0x732A90", VA = "0x180734090", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005DF3")]
			[Address(RVA = "0x8AFF80", Offset = "0x8AE980", VA = "0x1808AFF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005DF4 RID: 24052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF4")]
		[Address(RVA = "0x8AF8E0", Offset = "0x8AE2E0", VA = "0x1808AF8E0")]
		private void Awake()
		{
		}

		// Token: 0x06005DF5 RID: 24053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF5")]
		[Address(RVA = "0x8AFC70", Offset = "0x8AE670", VA = "0x1808AFC70")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005DF6 RID: 24054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF6")]
		[Address(RVA = "0x8AFE40", Offset = "0x8AE840", VA = "0x1808AFE40")]
		private void OnTurnOffPointerInteraction()
		{
		}

		// Token: 0x06005DF7 RID: 24055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF7")]
		[Address(RVA = "0x8AFDC0", Offset = "0x8AE7C0", VA = "0x1808AFDC0", Slot = "9")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06005DF8 RID: 24056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF8")]
		[Address(RVA = "0x8AFE40", Offset = "0x8AE840", VA = "0x1808AFE40", Slot = "10")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DF9")]
		[Address(RVA = "0x8AFE70", Offset = "0x8AE870", VA = "0x1808AFE70")]
		public void UpdateVisual(bool activate)
		{
		}

		// Token: 0x06005DFA RID: 24058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DFA")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public GuideMapSpot()
		{
		}

		// Token: 0x04005701 RID: 22273
		[Token(Token = "0x4005701")]
		[FieldOffset(Offset = "0x0")]
		[CleanupIgnore]
		private static Action s_TurnOffPointerInteractionCallback;

		// Token: 0x04005702 RID: 22274
		[Token(Token = "0x4005702")]
		[FieldOffset(Offset = "0x8")]
		private static bool s_IsPointerInteractionOn;

		// Token: 0x04005703 RID: 22275
		[Token(Token = "0x4005703")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] m_MapSubsetName;

		// Token: 0x04005704 RID: 22276
		[Token(Token = "0x4005704")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup m_OnHover;

		// Token: 0x04005705 RID: 22277
		[Token(Token = "0x4005705")]
		[FieldOffset(Offset = "0x30")]
		private CanvasGroup m_CanvasGroup;

		// Token: 0x04005706 RID: 22278
		[Token(Token = "0x4005706")]
		[FieldOffset(Offset = "0x38")]
		private HashSet<string> m_MapSubsetNameHashSet;
	}
}

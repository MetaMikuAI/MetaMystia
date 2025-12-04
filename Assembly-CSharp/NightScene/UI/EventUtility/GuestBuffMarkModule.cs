using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.Singletons;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.UI.EventUtility
{
	// Token: 0x02000702 RID: 1794
	[Token(Token = "0x2000702")]
	[GenerateCleanupMethod]
	public class GuestBuffMarkModule : MonoSingleton<GuestBuffMarkModule>
	{
		// Token: 0x06002A7B RID: 10875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7B")]
		[Address(RVA = "0x580BC0", Offset = "0x57F5C0", VA = "0x180580BC0")]
		public void Initialize()
		{
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7C")]
		[Address(RVA = "0x581800", Offset = "0x580200", VA = "0x180581800")]
		public void TryShowTargetDeskBuffMarkCanvasGroup(int deskCode)
		{
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x0000F3A8 File Offset: 0x0000D5A8
		[Token(Token = "0x6002A7D")]
		[Address(RVA = "0x580B70", Offset = "0x57F570", VA = "0x180580B70")]
		public Vector3 GetUiWorldPosition(Vector3 oldPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		[Token(Token = "0x6002A7E")]
		[Address(RVA = "0x5818E0", Offset = "0x5802E0", VA = "0x1805818E0")]
		public bool TrySpawnTargetDeskNewBuffMark(int deskCode, GuestBuffMarkModule.GuestBuffMark buffMarkType, GameObject buffMarkEffect, Action<GameObject> objectProcessingCallback, Action<GameObject> onMarkRemovedCallback, out GameObject effect, int index = 0)
		{
			return default(bool);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A7F")]
		[Address(RVA = "0x580960", Offset = "0x57F360", VA = "0x180580960")]
		public void ClearBuffMarkWhenTargetDeskGuestLeave(int deskCode)
		{
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A80")]
		[Address(RVA = "0x581630", Offset = "0x580030", VA = "0x180581630")]
		public void RemoveTargetBuffMark(int deskCode, GuestBuffMarkModule.GuestBuffMark guestBuffMark)
		{
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		[Token(Token = "0x6002A81")]
		[Address(RVA = "0x580B10", Offset = "0x57F510", VA = "0x180580B10")]
		private int GetBuffMarkSortIndex(GuestBuffMarkModule.GuestBuffMark mark)
		{
			return 0;
		}

		// Token: 0x06002A82 RID: 10882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A82")]
		[Address(RVA = "0x580FD0", Offset = "0x57F9D0", VA = "0x180580FD0")]
		private void RefreshTargetBuffMarkContainerSorting(int deskCode)
		{
		}

		// Token: 0x06002A83 RID: 10883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A83")]
		[Address(RVA = "0x580F30", Offset = "0x57F930", VA = "0x180580F30", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x06002A84 RID: 10884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A84")]
		[Address(RVA = "0x580480", Offset = "0x57EE80", VA = "0x180580480", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002A85 RID: 10885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A85")]
		[Address(RVA = "0x582110", Offset = "0x580B10", VA = "0x180582110")]
		public GuestBuffMarkModule()
		{
		}

		// Token: 0x040026F2 RID: 9970
		[Token(Token = "0x40026F2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<GuestBuffMarkModule.GuestBuffMarkProperty> m_GuestBuffMarkSort;

		// Token: 0x040026F3 RID: 9971
		[Token(Token = "0x40026F3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_BuffMarkContainer;

		// Token: 0x040026F4 RID: 9972
		[Token(Token = "0x40026F4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform m_BuffMarkUIParent;

		// Token: 0x040026F5 RID: 9973
		[Token(Token = "0x40026F5")]
		[FieldOffset(Offset = "0x30")]
		[TupleElementNames(new string[] { null, null, "Displayer", "OnMarkRemoved" })]
		private Dictionary<int, ValueTuple<UIElementCluster, Dictionary<GuestBuffMarkModule.GuestBuffMark, ValueTuple<List<GameObject>, Action<GameObject>>>>> buffMarkSetAccordingToDeskCode;

		// Token: 0x040026F6 RID: 9974
		[Token(Token = "0x40026F6")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<GuestBuffMarkModule.GuestBuffMark, ValueTuple<int, GuestBuffMarkModule.GuestBuffMarkProperty>> guestBuffMarkPropertiesDic;

		// Token: 0x040026F7 RID: 9975
		[Token(Token = "0x40026F7")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<GuestBuffMarkModule.GuestBuffMark, HashSet<GuestBuffMarkModule.GuestBuffMark>> guestBuffMarkSortingDic;

		// Token: 0x040026F8 RID: 9976
		[Token(Token = "0x40026F8")]
		[FieldOffset(Offset = "0x48")]
		private Camera m_Camera;

		// Token: 0x040026F9 RID: 9977
		[Token(Token = "0x40026F9")]
		[FieldOffset(Offset = "0x50")]
		private Canvas m_Canvas;

		// Token: 0x040026FA RID: 9978
		[Token(Token = "0x40026FA")]
		[FieldOffset(Offset = "0x58")]
		private Comparer<int> m_Comparer;

		// Token: 0x02000703 RID: 1795
		[Token(Token = "0x2000703")]
		public enum DisplayType
		{
			// Token: 0x040026FC RID: 9980
			[Token(Token = "0x40026FC")]
			Floating,
			// Token: 0x040026FD RID: 9981
			[Token(Token = "0x40026FD")]
			Static
		}

		// Token: 0x02000704 RID: 1796
		[Token(Token = "0x2000704")]
		public enum GuestBuffMark
		{
			// Token: 0x040026FF RID: 9983
			[Token(Token = "0x40026FF")]
			[InspectorName("冴月麟·续单标记")]
			BuffMark_Rin,
			// Token: 0x04002700 RID: 9984
			[Token(Token = "0x4002700")]
			[InspectorName("正邪·普客强化标记")]
			BuffMark_Seija,
			// Token: 0x04002701 RID: 9985
			[Token(Token = "0x4002701")]
			[InspectorName("时焉侑·审判之眼")]
			BuffMark_JienYuuEye,
			// Token: 0x04002702 RID: 9986
			[Token(Token = "0x4002702")]
			[InspectorName("装饰品·觉之眼")]
			BuffMark_SatoriEye
		}

		// Token: 0x02000705 RID: 1797
		[Token(Token = "0x2000705")]
		[Serializable]
		public struct GuestBuffMarkProperty
		{
			// Token: 0x04002703 RID: 9987
			[Token(Token = "0x4002703")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public GuestBuffMarkModule.GuestBuffMark buffMark;

			// Token: 0x04002704 RID: 9988
			[Token(Token = "0x4002704")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public GuestBuffMarkModule.DisplayType displayType;

			// Token: 0x04002705 RID: 9989
			[Token(Token = "0x4002705")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public GuestBuffMarkModule.GuestBuffMark[] overridedByOtherMarkList;
		}
	}
}

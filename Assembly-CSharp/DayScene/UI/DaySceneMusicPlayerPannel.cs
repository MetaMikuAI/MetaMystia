using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI
{
	// Token: 0x020002D2 RID: 722
	[Token(Token = "0x20002D2")]
	[GenerateCleanupMethod]
	public class DaySceneMusicPlayerPannel : UIPanel
	{
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06001045 RID: 4165 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001046 RID: 4166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000190")]
		public List<Record> UnlockedCD
		{
			[Token(Token = "0x6001045")]
			[Address(RVA = "0x48A7A0", Offset = "0x4891A0", VA = "0x18048A7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001046")]
			[Address(RVA = "0x4D2570", Offset = "0x4D0F70", VA = "0x1804D2570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x00006840 File Offset: 0x00004A40
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000191")]
		public int CurrentSelectedRecordIzakayaMusicPackageID
		{
			[Token(Token = "0x6001047")]
			[Address(RVA = "0x440580", Offset = "0x43EF80", VA = "0x180440580")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001048")]
			[Address(RVA = "0x927880", Offset = "0x926280", VA = "0x180927880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x00006858 File Offset: 0x00004A58
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000192")]
		public int CurrentSelectedRecordIndex
		{
			[Token(Token = "0x6001049")]
			[Address(RVA = "0x440430", Offset = "0x43EE30", VA = "0x180440430")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600104A")]
			[Address(RVA = "0x52F1A0", Offset = "0x52DBA0", VA = "0x18052F1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600104C RID: 4172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000193")]
		public Record CurrentSelectedRecordInfo
		{
			[Token(Token = "0x600104B")]
			[Address(RVA = "0x449340", Offset = "0x447D40", VA = "0x180449340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600104C")]
			[Address(RVA = "0x48AA80", Offset = "0x489480", VA = "0x18048AA80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600104D")]
		[Address(RVA = "0x81CA30", Offset = "0x81B430", VA = "0x18081CA30")]
		public void UpdateCheck()
		{
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600104E")]
		[Address(RVA = "0x926AA0", Offset = "0x9254A0", VA = "0x180926AA0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600104F")]
		[Address(RVA = "0x927220", Offset = "0x925C20", VA = "0x180927220")]
		private void ProcessRecordElement(UIElementCluster uIElementCluster, Record recordInfo, int index)
		{
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001050")]
		[Address(RVA = "0x927170", Offset = "0x925B70", VA = "0x180927170")]
		private void OpenSubPannel()
		{
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001051")]
		[Address(RVA = "0x926BE0", Offset = "0x9255E0", VA = "0x180926BE0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001052")]
		[Address(RVA = "0x926A40", Offset = "0x925440", VA = "0x180926A40", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001053")]
		[Address(RVA = "0x9268E0", Offset = "0x9252E0", VA = "0x1809268E0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001054")]
		[Address(RVA = "0x927760", Offset = "0x926160", VA = "0x180927760")]
		public DaySceneMusicPlayerPannel()
		{
		}

		// Token: 0x04000EF6 RID: 3830
		[Token(Token = "0x4000EF6")]
		[FieldOffset(Offset = "0x70")]
		public GameObject recordElement;

		// Token: 0x04000EF7 RID: 3831
		[Token(Token = "0x4000EF7")]
		[FieldOffset(Offset = "0x78")]
		public GameObject emptyElement;

		// Token: 0x04000EF8 RID: 3832
		[Token(Token = "0x4000EF8")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform recordPannel;

		// Token: 0x04000EF9 RID: 3833
		[Token(Token = "0x4000EF9")]
		[FieldOffset(Offset = "0x88")]
		public AdpScrollListFixedComponent scroller;

		// Token: 0x04000EFA RID: 3834
		[Token(Token = "0x4000EFA")]
		[FieldOffset(Offset = "0x90")]
		public Sprite[] deselectedImages;

		// Token: 0x04000EFB RID: 3835
		[Token(Token = "0x4000EFB")]
		[FieldOffset(Offset = "0x98")]
		public Sprite[] selectedImages;

		// Token: 0x04000EFC RID: 3836
		[Token(Token = "0x4000EFC")]
		[FieldOffset(Offset = "0xA0")]
		public DaySceneMusicPlayerSubPannel SubPannel;

		// Token: 0x04000EFD RID: 3837
		[Token(Token = "0x4000EFD")]
		[FieldOffset(Offset = "0xA8")]
		private readonly List<GameObject> m_AllInstances;

		// Token: 0x04000EFE RID: 3838
		[Token(Token = "0x4000EFE")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<UILogicalUnit>[] m_ArrayBuffer;

		// Token: 0x04000EFF RID: 3839
		[Token(Token = "0x4000EFF")]
		[FieldOffset(Offset = "0xB8")]
		private readonly UILogicalGroupT<Record> m_RecordGroup;

		// Token: 0x04000F00 RID: 3840
		[Token(Token = "0x4000F00")]
		[FieldOffset(Offset = "0xC0")]
		private Transform m_EmptyElementTransform;

		// Token: 0x04000F01 RID: 3841
		[Token(Token = "0x4000F01")]
		[FieldOffset(Offset = "0xC8")]
		private Action m_UpdateHandle;
	}
}

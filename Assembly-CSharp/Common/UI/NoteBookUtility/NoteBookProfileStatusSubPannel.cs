using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000ECF RID: 3791
	[Token(Token = "0x2000ECF")]
	[GenerateCleanupMethod]
	public class NoteBookProfileStatusSubPannel : UIPanelExtern
	{
		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x0600597B RID: 22907 RVA: 0x0001F620 File Offset: 0x0001D820
		[Token(Token = "0x17000C69")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x600597B")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x0001F638 File Offset: 0x0001D838
		[Token(Token = "0x600597C")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600597D")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "32")]
		protected override void OnExitExtern()
		{
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600597E")]
		[Address(RVA = "0x88F120", Offset = "0x88DB20", VA = "0x18088F120", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600597F")]
		[Address(RVA = "0x88EED0", Offset = "0x88D8D0", VA = "0x18088EED0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005980")]
		[Address(RVA = "0x8925A0", Offset = "0x890FA0", VA = "0x1808925A0")]
		public NoteBookProfileStatusSubPannel()
		{
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005981")]
		[Address(RVA = "0x8920A0", Offset = "0x890AA0", VA = "0x1808920A0")]
		[CompilerGenerated]
		internal static string <OnPanelOpen>g__FormatToProb|29_1(float value)
		{
			return null;
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005982")]
		[Address(RVA = "0x892050", Offset = "0x890A50", VA = "0x180892050")]
		[CompilerGenerated]
		internal static string <OnPanelOpen>g__AddPlus|29_2(float value)
		{
			return null;
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005983")]
		[Address(RVA = "0x892100", Offset = "0x890B00", VA = "0x180892100")]
		[CompilerGenerated]
		private void <OnPanelOpen>g__Show|29_3(TextMeshProUGUI textMesh, Func<DataBaseCore.LevelProperties, float> getValueCallback, Func<float, string> overrideToStringCallback, ref NoteBookProfileStatusSubPannel.<>c__DisplayClass29_0 A_4)
		{
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005984")]
		[Address(RVA = "0x892200", Offset = "0x890C00", VA = "0x180892200")]
		[CompilerGenerated]
		private void <OnPanelOpen>g__TrySpawnNext|29_20(Func<DataBaseCore.LevelProperties, float> getValueCallback, string objectTitleKey, Func<float, string> overrideToStringCallback, bool alwaysShow, bool thisProfileInfo, ref NoteBookProfileStatusSubPannel.<>c__DisplayClass29_0 A_6)
		{
		}

		// Token: 0x040053DF RID: 21471
		[Token(Token = "0x40053DF")]
		[FieldOffset(Offset = "0x70")]
		[Header("Profile Values Page1")]
		public TextMeshProUGUI basePassion;

		// Token: 0x040053E0 RID: 21472
		[Token(Token = "0x40053E0")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI baseTipRate;

		// Token: 0x040053E1 RID: 21473
		[Token(Token = "0x40053E1")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI maxDailyRecipes;

		// Token: 0x040053E2 RID: 21474
		[Token(Token = "0x40053E2")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI maxDailyBeverages;

		// Token: 0x040053E3 RID: 21475
		[Token(Token = "0x40053E3")]
		[FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI dayCookCount;

		// Token: 0x040053E4 RID: 21476
		[Token(Token = "0x40053E4")]
		[FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI moveSpeed;

		// Token: 0x040053E5 RID: 21477
		[Token(Token = "0x40053E5")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI cookSpeed;

		// Token: 0x040053E6 RID: 21478
		[Token(Token = "0x40053E6")]
		[FieldOffset(Offset = "0xA8")]
		public TextMeshProUGUI qteBuffRate;

		// Token: 0x040053E7 RID: 21479
		[Token(Token = "0x40053E7")]
		[FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI qteBuffDuration;

		// Token: 0x040053E8 RID: 21480
		[Token(Token = "0x40053E8")]
		[FieldOffset(Offset = "0xB8")]
		public TextMeshProUGUI extraCollectRate;

		// Token: 0x040053E9 RID: 21481
		[Token(Token = "0x40053E9")]
		[FieldOffset(Offset = "0xC0")]
		public TextMeshProUGUI merchantDiscount;

		// Token: 0x040053EA RID: 21482
		[Token(Token = "0x40053EA")]
		[FieldOffset(Offset = "0xC8")]
		public TextMeshProUGUI trayCount;

		// Token: 0x040053EB RID: 21483
		[Token(Token = "0x40053EB")]
		[FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI guestBaseMood;

		// Token: 0x040053EC RID: 21484
		[Token(Token = "0x40053EC")]
		[FieldOffset(Offset = "0xD8")]
		public TextMeshProUGUI guestBasePatience;

		// Token: 0x040053ED RID: 21485
		[Token(Token = "0x40053ED")]
		[FieldOffset(Offset = "0xE0")]
		public TextMeshProUGUI guestSpawnRate;

		// Token: 0x040053EE RID: 21486
		[Token(Token = "0x40053EE")]
		[FieldOffset(Offset = "0xE8")]
		public TextMeshProUGUI postiveBuffTime;

		// Token: 0x040053EF RID: 21487
		[Token(Token = "0x40053EF")]
		[FieldOffset(Offset = "0xF0")]
		public TextMeshProUGUI fund;

		// Token: 0x040053F0 RID: 21488
		[Token(Token = "0x40053F0")]
		[FieldOffset(Offset = "0xF8")]
		public TextMeshProUGUI level;

		// Token: 0x040053F1 RID: 21489
		[Token(Token = "0x40053F1")]
		[FieldOffset(Offset = "0x100")]
		public TextMeshProUGUI expValue;

		// Token: 0x040053F2 RID: 21490
		[Token(Token = "0x40053F2")]
		[FieldOffset(Offset = "0x108")]
		public TextMeshProUGUI nextLevel;

		// Token: 0x040053F3 RID: 21491
		[Token(Token = "0x40053F3")]
		[FieldOffset(Offset = "0x110")]
		public Image expBar;

		// Token: 0x040053F4 RID: 21492
		[Token(Token = "0x40053F4")]
		[FieldOffset(Offset = "0x118")]
		[Header("Next Properties")]
		public Transform propertiesParent;

		// Token: 0x040053F5 RID: 21493
		[Token(Token = "0x40053F5")]
		[FieldOffset(Offset = "0x120")]
		public Transform propertiesField;

		// Token: 0x040053F6 RID: 21494
		[Token(Token = "0x40053F6")]
		[FieldOffset(Offset = "0x128")]
		public GameObject propertyObject;

		// Token: 0x040053F7 RID: 21495
		[Token(Token = "0x40053F7")]
		[FieldOffset(Offset = "0x130")]
		private readonly HashSet<GameObject> allInstances;
	}
}

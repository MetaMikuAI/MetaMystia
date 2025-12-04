using System;
using System.Collections.Generic;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000DF9 RID: 3577
	[Token(Token = "0x2000DF9")]
	[GenerateCleanupMethod]
	public class NormalGuestDescriber : LanguageBaseDescriber
	{
		// Token: 0x0600539B RID: 21403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539B")]
		[Address(RVA = "0x83C560", Offset = "0x83AF60", VA = "0x18083C560", Slot = "6")]
		protected override void OnPreload()
		{
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539C")]
		[Address(RVA = "0x83C4F0", Offset = "0x83AEF0", VA = "0x18083C4F0", Slot = "8")]
		protected override void OnDescriberDestroyed()
		{
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539D")]
		[Address(RVA = "0x83CAD0", Offset = "0x83B4D0", VA = "0x18083CAD0")]
		private void StartTrimCoroutine(CharacterSpriteSetCompact pixel)
		{
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539E")]
		[Address(RVA = "0x83C010", Offset = "0x83AA10", VA = "0x18083C010")]
		public void Describe(NormalGuest detail)
		{
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600539F")]
		[Address(RVA = "0x83C620", Offset = "0x83B020", VA = "0x18083C620")]
		public static void PrintFrequentlyShownText(NormalGuestDescriber.PlaceRenderMode mode, bool known, IEnumerable<int> shownIzakayaIds, TextMeshProUGUI text)
		{
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A0")]
		[Address(RVA = "0x83BEC0", Offset = "0x83A8C0", VA = "0x18083BEC0", Slot = "9")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053A1")]
		[Address(RVA = "0x83CCF0", Offset = "0x83B6F0", VA = "0x18083CCF0")]
		public NormalGuestDescriber()
		{
		}

		// Token: 0x04004E89 RID: 20105
		[Token(Token = "0x4004E89")]
		[FieldOffset(Offset = "0x60")]
		[Header("Normal Guest")]
		public Image bse;

		// Token: 0x04004E8A RID: 20106
		[Token(Token = "0x4004E8A")]
		[FieldOffset(Offset = "0x68")]
		public Image eyes;

		// Token: 0x04004E8B RID: 20107
		[Token(Token = "0x4004E8B")]
		[FieldOffset(Offset = "0x70")]
		public Image trimBack;

		// Token: 0x04004E8C RID: 20108
		[Token(Token = "0x4004E8C")]
		[FieldOffset(Offset = "0x78")]
		public Image trimFront;

		// Token: 0x04004E8D RID: 20109
		[Token(Token = "0x4004E8D")]
		[FieldOffset(Offset = "0x80")]
		public GameObject foodTagParent;

		// Token: 0x04004E8E RID: 20110
		[Token(Token = "0x4004E8E")]
		[FieldOffset(Offset = "0x88")]
		public GameObject bevTagParent;

		// Token: 0x04004E8F RID: 20111
		[Token(Token = "0x4004E8F")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform foodTagField;

		// Token: 0x04004E90 RID: 20112
		[Token(Token = "0x4004E90")]
		[FieldOffset(Offset = "0x98")]
		public RectTransform bevTagField;

		// Token: 0x04004E91 RID: 20113
		[Token(Token = "0x4004E91")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI placeText;

		// Token: 0x04004E92 RID: 20114
		[Token(Token = "0x4004E92")]
		[FieldOffset(Offset = "0xA8")]
		public Action OnCancelDescribeCallback;

		// Token: 0x04004E93 RID: 20115
		[Token(Token = "0x4004E93")]
		[FieldOffset(Offset = "0xB0")]
		private List<GameObject> allBevTagInstances;

		// Token: 0x04004E94 RID: 20116
		[Token(Token = "0x4004E94")]
		[FieldOffset(Offset = "0xB8")]
		private List<GameObject> allFoodTagInstances;

		// Token: 0x04004E95 RID: 20117
		[Token(Token = "0x4004E95")]
		[FieldOffset(Offset = "0xC0")]
		private List<GameObject> allPlacesInstances;

		// Token: 0x04004E96 RID: 20118
		[Token(Token = "0x4004E96")]
		[FieldOffset(Offset = "0xC8")]
		private Coroutine trimBackCoroutine;

		// Token: 0x04004E97 RID: 20119
		[Token(Token = "0x4004E97")]
		[FieldOffset(Offset = "0xD0")]
		private Coroutine trimFrontCoroutine;

		// Token: 0x02000DFA RID: 3578
		[Token(Token = "0x2000DFA")]
		public enum PlaceRenderMode
		{
			// Token: 0x04004E99 RID: 20121
			[Token(Token = "0x4004E99")]
			IncludeOnlyProvidedPlaces,
			// Token: 0x04004E9A RID: 20122
			[Token(Token = "0x4004E9A")]
			ExcludeProvidedPlaces
		}
	}
}

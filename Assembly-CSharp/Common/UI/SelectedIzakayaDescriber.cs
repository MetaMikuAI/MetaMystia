using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000E44 RID: 3652
	[Token(Token = "0x2000E44")]
	[GenerateCleanupMethod]
	public class SelectedIzakayaDescriber : MonoBehaviour, ITypedDescriber<Izakaya>, IDescriber
	{
		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x06005559 RID: 21849 RVA: 0x0001E6F0 File Offset: 0x0001C8F0
		[Token(Token = "0x17000BFD")]
		protected virtual int Max
		{
			[Token(Token = "0x6005559")]
			[Address(RVA = "0x4470A0", Offset = "0x445AA0", VA = "0x1804470A0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600555A RID: 21850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555A")]
		[Address(RVA = "0x85B910", Offset = "0x85A310", VA = "0x18085B910")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600555B RID: 21851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555B")]
		[Address(RVA = "0x85A640", Offset = "0x859040", VA = "0x18085A640", Slot = "7")]
		public virtual void Describe(Izakaya data, CancellationToken cancellationToken)
		{
		}

		// Token: 0x0600555C RID: 21852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555C")]
		[Address(RVA = "0x85B930", Offset = "0x85A330", VA = "0x18085B930")]
		public static void PrintImpl(Izakaya data, IReadOnlyList<ValueTuple<string, CharacterSpriteSetCompact>> specialGuestPrintInfo, IReadOnlyList<ValueTuple<string, CharacterSpriteSetCompact>> normalGuestPrintInfo, bool normalGuestLimiterApplies, bool specialGuestsLimiterApplies, TextMeshProUGUI m_IzakayaName, TextMeshProUGUI m_CookingDeskAmount1, TextMeshProUGUI m_CookingDeskAmount2, TextMeshProUGUI m_GuestTableAmount1, TextMeshProUGUI m_GuestTableAmount2, GameObject m_CharacterPrefab, GameObject m_NormalGuestContainer, GameObject m_SpecialGuestContainer, RectTransform m_NormalGuestField, RectTransform m_SpecialGuestField, CanvasGroup m_NormalGuestsMoreIndicator, CanvasGroup m_SpecialGuestsMoreIndicator, List<GameObject> allNormalCharacterInstancePool, List<GameObject> allSpecialCharacterInstancePool)
		{
		}

		// Token: 0x0600555D RID: 21853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555D")]
		[Address(RVA = "0x85AAE0", Offset = "0x8594E0", VA = "0x18085AAE0")]
		public static void MapNormalGuestPrintData(int max, IReadOnlyList<Izakaya.NormalGuestGroup> normalGuestGroups, out bool limiterApplies, List<ValueTuple<string, CharacterSpriteSetCompact>> m_PrintingCache)
		{
		}

		// Token: 0x0600555E RID: 21854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555E")]
		[Address(RVA = "0x85B2F0", Offset = "0x859CF0", VA = "0x18085B2F0")]
		public static void MapSpecialGuestPrintData(int max, Izakaya data, out IReadOnlyList<ValueTuple<string, CharacterSpriteSetCompact>> printInfo, out bool limiterApplies, List<ValueTuple<string, CharacterSpriteSetCompact>> m_PrintingCache)
		{
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600555F")]
		[Address(RVA = "0x85BD00", Offset = "0x85A700", VA = "0x18085BD00")]
		public static void Process(UIElementCluster visual, [TupleElementNames(new string[] { "Name", "CharacterSprite" })] ValueTuple<string, CharacterSpriteSetCompact> data)
		{
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005560")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "5")]
		public void DescribeNull()
		{
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005561")]
		[Address(RVA = "0x85A4D0", Offset = "0x858ED0", VA = "0x18085A4D0", Slot = "8")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005562")]
		[Address(RVA = "0x85BFB0", Offset = "0x85A9B0", VA = "0x18085BFB0")]
		public SelectedIzakayaDescriber()
		{
		}

		// Token: 0x04005035 RID: 20533
		[Token(Token = "0x4005035")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI m_IzakayaName;

		// Token: 0x04005036 RID: 20534
		[Token(Token = "0x4005036")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI m_CookingDeskAmount1;

		// Token: 0x04005037 RID: 20535
		[Token(Token = "0x4005037")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI m_CookingDeskAmount2;

		// Token: 0x04005038 RID: 20536
		[Token(Token = "0x4005038")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI m_GuestTableAmount1;

		// Token: 0x04005039 RID: 20537
		[Token(Token = "0x4005039")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI m_GuestTableAmount2;

		// Token: 0x0400503A RID: 20538
		[Token(Token = "0x400503A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject m_CharacterPrefab;

		// Token: 0x0400503B RID: 20539
		[Token(Token = "0x400503B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject m_SpecialGuestModule;

		// Token: 0x0400503C RID: 20540
		[Token(Token = "0x400503C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject m_NormalGuestModule;

		// Token: 0x0400503D RID: 20541
		[Token(Token = "0x400503D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform m_NormalGuestField;

		// Token: 0x0400503E RID: 20542
		[Token(Token = "0x400503E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform m_SpecialGuestField;

		// Token: 0x0400503F RID: 20543
		[Token(Token = "0x400503F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup m_NormalGuestsMoreIndicator;

		// Token: 0x04005040 RID: 20544
		[Token(Token = "0x4005040")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup m_SpecialGuestsMoreIndicator;

		// Token: 0x04005041 RID: 20545
		[Token(Token = "0x4005041")]
		[FieldOffset(Offset = "0x78")]
		private readonly List<GameObject> allNormalCharacterInstancePool;

		// Token: 0x04005042 RID: 20546
		[Token(Token = "0x4005042")]
		[FieldOffset(Offset = "0x80")]
		private readonly List<GameObject> allSpecialCharacterInstancePool;

		// Token: 0x04005043 RID: 20547
		[Token(Token = "0x4005043")]
		[FieldOffset(Offset = "0x88")]
		private readonly List<ValueTuple<string, CharacterSpriteSetCompact>> m_SpecialGuestPrintingCache;

		// Token: 0x04005044 RID: 20548
		[Token(Token = "0x4005044")]
		[FieldOffset(Offset = "0x90")]
		private readonly List<ValueTuple<string, CharacterSpriteSetCompact>> m_NormalGuestPrintingCache;
	}
}

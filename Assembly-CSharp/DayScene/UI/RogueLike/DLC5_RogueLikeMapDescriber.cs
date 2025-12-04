using System;
using System.Collections.Generic;
using System.Threading;
using Common.UI;
using Common.UI.GlobalMap;
using GameData.Core.Collections;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020003B5 RID: 949
	[Token(Token = "0x20003B5")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeMapDescriber : MonoBehaviour, ITypedDescriber<DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext>, IDescriber
	{
		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x00007FF8 File Offset: 0x000061F8
		[Token(Token = "0x17000278")]
		protected virtual int Max
		{
			[Token(Token = "0x60014FF")]
			[Address(RVA = "0x4470A0", Offset = "0x445AA0", VA = "0x1804470A0", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000279")]
		protected GameObject CharacterPrefab
		{
			[Token(Token = "0x6001500")]
			[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x446850", Offset = "0x445250", VA = "0x180446850", Slot = "7")]
		public virtual void Describe(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext data, CancellationToken cancellationToken)
		{
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "5")]
		public void DescribeNull()
		{
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x4466E0", Offset = "0x4450E0", VA = "0x1804466E0", Slot = "8")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x446F50", Offset = "0x445950", VA = "0x180446F50")]
		public DLC5_RogueLikeMapDescriber()
		{
		}

		// Token: 0x040013A0 RID: 5024
		[Token(Token = "0x40013A0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI m_IzakayaName;

		// Token: 0x040013A1 RID: 5025
		[Token(Token = "0x40013A1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI m_CookingDeskAmount1;

		// Token: 0x040013A2 RID: 5026
		[Token(Token = "0x40013A2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI m_CookingDeskAmount2;

		// Token: 0x040013A3 RID: 5027
		[Token(Token = "0x40013A3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI m_GuestTableAmount1;

		// Token: 0x040013A4 RID: 5028
		[Token(Token = "0x40013A4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI m_GuestTableAmount2;

		// Token: 0x040013A5 RID: 5029
		[Token(Token = "0x40013A5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject m_CharacterPrefab;

		// Token: 0x040013A6 RID: 5030
		[Token(Token = "0x40013A6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject m_SpecialGuestModule;

		// Token: 0x040013A7 RID: 5031
		[Token(Token = "0x40013A7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject m_NormalGuestModule;

		// Token: 0x040013A8 RID: 5032
		[Token(Token = "0x40013A8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform m_NormalGuestField;

		// Token: 0x040013A9 RID: 5033
		[Token(Token = "0x40013A9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform m_SpecialGuestField;

		// Token: 0x040013AA RID: 5034
		[Token(Token = "0x40013AA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup m_NormalGuestsMoreIndicator;

		// Token: 0x040013AB RID: 5035
		[Token(Token = "0x40013AB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup m_SpecialGuestsMoreIndicator;

		// Token: 0x040013AC RID: 5036
		[Token(Token = "0x40013AC")]
		[FieldOffset(Offset = "0x78")]
		private readonly List<GameObject> allNormalCharacterInstancePool;

		// Token: 0x040013AD RID: 5037
		[Token(Token = "0x40013AD")]
		[FieldOffset(Offset = "0x80")]
		private readonly List<GameObject> allSpecialCharacterInstancePool;

		// Token: 0x040013AE RID: 5038
		[Token(Token = "0x40013AE")]
		[FieldOffset(Offset = "0x88")]
		private readonly List<ValueTuple<string, CharacterSpriteSetCompact>> m_SpecialGuestPrintingCache;

		// Token: 0x040013AF RID: 5039
		[Token(Token = "0x40013AF")]
		[FieldOffset(Offset = "0x90")]
		private readonly List<ValueTuple<string, CharacterSpriteSetCompact>> m_NormalGuestPrintingCache;

		// Token: 0x020003B6 RID: 950
		[Token(Token = "0x20003B6")]
		public struct DLC5_RogueLikeMapDescriberOpenContext
		{
			// Token: 0x06001505 RID: 5381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001505")]
			[Address(RVA = "0x446630", Offset = "0x445030", VA = "0x180446630")]
			public DLC5_RogueLikeMapDescriberOpenContext(DLC5_RogueLikeDataProfile.MapSetup mapSetup, Izakaya izakaya, RogueLikeRunTimeData runTimeData, RogueLikeRunTimeData.DLCAreaCollectRate dlcAreaCollectRate, IEnumerable<IGuideMapSpot> getNeighbourCallback)
			{
			}

			// Token: 0x040013B0 RID: 5040
			[Token(Token = "0x40013B0")]
			[FieldOffset(Offset = "0x0")]
			public readonly DLC5_RogueLikeDataProfile.MapSetup MapSetup;

			// Token: 0x040013B1 RID: 5041
			[Token(Token = "0x40013B1")]
			[FieldOffset(Offset = "0x50")]
			public Izakaya Izakaya;

			// Token: 0x040013B2 RID: 5042
			[Token(Token = "0x40013B2")]
			[FieldOffset(Offset = "0x58")]
			public RogueLikeRunTimeData RunTimeData;

			// Token: 0x040013B3 RID: 5043
			[Token(Token = "0x40013B3")]
			[FieldOffset(Offset = "0x60")]
			public readonly RogueLikeRunTimeData.DLCAreaCollectRate DlcAreaCollectRate;

			// Token: 0x040013B4 RID: 5044
			[Token(Token = "0x40013B4")]
			[FieldOffset(Offset = "0x88")]
			public readonly IEnumerable<IGuideMapSpot> GetNeighbourCallback;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000E56 RID: 3670
	[Token(Token = "0x2000E56")]
	[GenerateCleanupMethod]
	public class DailyRecipePrinter : MonoBehaviour
	{
		// Token: 0x060055D9 RID: 21977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055D9")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055DA")]
		[Address(RVA = "0x84E720", Offset = "0x84D120", VA = "0x18084E720")]
		public void UpdateDaily(Action<DailyRecipePrinter.RecipePrinterData, UIButtonSimple> onObjectSpawnedCallback, [Optional] AdpScrollListFixedComponent scroll)
		{
		}

		// Token: 0x060055DB RID: 21979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055DB")]
		[Address(RVA = "0x84E510", Offset = "0x84CF10", VA = "0x18084E510", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060055DC RID: 21980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055DC")]
		[Address(RVA = "0x84EB30", Offset = "0x84D530", VA = "0x18084EB30")]
		public DailyRecipePrinter()
		{
		}

		// Token: 0x060055DD RID: 21981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055DD")]
		[Address(RVA = "0x84E650", Offset = "0x84D050", VA = "0x18084E650")]
		[CompilerGenerated]
		internal static string <UpdateDaily>g__FormateByLanguage|18_2(string name)
		{
			return null;
		}

		// Token: 0x0400509B RID: 20635
		[Token(Token = "0x400509B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject recipeParent;

		// Token: 0x0400509C RID: 20636
		[Token(Token = "0x400509C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject recipeNullParent;

		// Token: 0x0400509D RID: 20637
		[Token(Token = "0x400509D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject beverageParent;

		// Token: 0x0400509E RID: 20638
		[Token(Token = "0x400509E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject beverageNullParent;

		// Token: 0x0400509F RID: 20639
		[Token(Token = "0x400509F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RectTransform recipeField;

		// Token: 0x040050A0 RID: 20640
		[Token(Token = "0x40050A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RectTransform beverageField;

		// Token: 0x040050A1 RID: 20641
		[Token(Token = "0x40050A1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public SellableDescriber describer;

		// Token: 0x040050A2 RID: 20642
		[Token(Token = "0x40050A2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Sprite check;

		// Token: 0x040050A3 RID: 20643
		[Token(Token = "0x40050A3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Sprite cross;

		// Token: 0x040050A4 RID: 20644
		[Token(Token = "0x40050A4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Color checkColor;

		// Token: 0x040050A5 RID: 20645
		[Token(Token = "0x40050A5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Color crossColor;

		// Token: 0x040050A6 RID: 20646
		[Token(Token = "0x40050A6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Color lockColor;

		// Token: 0x040050A7 RID: 20647
		[Token(Token = "0x40050A7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly List<GameObject> m_AllRegisteredBeverageInstances;

		// Token: 0x040050A8 RID: 20648
		[Token(Token = "0x40050A8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly List<GameObject> m_AllRegisteredBeverageNullInstances;

		// Token: 0x040050A9 RID: 20649
		[Token(Token = "0x40050A9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly List<GameObject> m_AllRegisteredRecipeInstances;

		// Token: 0x040050AA RID: 20650
		[Token(Token = "0x40050AA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly List<GameObject> m_AllRegisteredRecipeNullInstances;

		// Token: 0x02000E57 RID: 3671
		[Token(Token = "0x2000E57")]
		public enum RecipePrinterType
		{
			// Token: 0x040050AC RID: 20652
			[Token(Token = "0x40050AC")]
			Recipe,
			// Token: 0x040050AD RID: 20653
			[Token(Token = "0x40050AD")]
			Beverage
		}

		// Token: 0x02000E58 RID: 3672
		[Token(Token = "0x2000E58")]
		public struct RecipePrinterData : IEquatable<DailyRecipePrinter.RecipePrinterData>
		{
			// Token: 0x060055DE RID: 21982 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60055DE")]
			[Address(RVA = "0x41AF60", Offset = "0x419960", VA = "0x18041AF60")]
			public RecipePrinterData(int id, DailyRecipePrinter.RecipePrinterType recipePrinterType)
			{
			}

			// Token: 0x17000C08 RID: 3080
			// (get) Token: 0x060055DF RID: 21983 RVA: 0x0001E810 File Offset: 0x0001CA10
			[Token(Token = "0x17000C08")]
			public readonly int Id
			{
				[Token(Token = "0x60055DF")]
				[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000C09 RID: 3081
			// (get) Token: 0x060055E0 RID: 21984 RVA: 0x0001E828 File Offset: 0x0001CA28
			[Token(Token = "0x17000C09")]
			public readonly DailyRecipePrinter.RecipePrinterType RecipePrinterType
			{
				[Token(Token = "0x60055E0")]
				[Address(RVA = "0x43B0B0", Offset = "0x439AB0", VA = "0x18043B0B0")]
				[CompilerGenerated]
				get
				{
					return DailyRecipePrinter.RecipePrinterType.Recipe;
				}
			}

			// Token: 0x060055E1 RID: 21985 RVA: 0x0001E840 File Offset: 0x0001CA40
			[Token(Token = "0x60055E1")]
			[Address(RVA = "0x734DC0", Offset = "0x7337C0", VA = "0x180734DC0", Slot = "4")]
			public bool Equals(DailyRecipePrinter.RecipePrinterData other)
			{
				return default(bool);
			}
		}
	}
}

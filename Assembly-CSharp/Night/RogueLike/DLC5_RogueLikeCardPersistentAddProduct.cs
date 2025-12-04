using System;
using System.Runtime.CompilerServices;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x0200012D RID: 301
	[Token(Token = "0x200012D")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddProduct", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddProduct", order = 1)]
	public class DLC5_RogueLikeCardPersistentAddProduct : RogueLikeCardPersistent
	{
		// Token: 0x0600075A RID: 1882 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x6E0B20", Offset = "0x6DF520", VA = "0x1806E0B20", Slot = "7")]
		public override bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			return default(bool);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x6DF710", Offset = "0x6DE110", VA = "0x1806DF710", Slot = "12")]
		public override void AfterInitialize(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x6E0BE0", Offset = "0x6DF5E0", VA = "0x1806E0BE0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x6E0B80", Offset = "0x6DF580", VA = "0x1806E0B80", Slot = "6")]
		public override string GetDescriptionInAlbum(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			return null;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x6E07D0", Offset = "0x6DF1D0", VA = "0x1806E07D0", Slot = "10")]
		public override void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddProduct()
		{
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x6E0F30", Offset = "0x6DF930", VA = "0x1806E0F30")]
		[CompilerGenerated]
		internal static void <AfterInitialize>g__GetMapProduct|1_2(string mapLabel, out int[] cooker, out int[] decoration, out int[] clothes, out int[] partner, ref DLC5_RogueLikeCardPersistentAddProduct.<>c__DisplayClass1_0 A_5)
		{
		}
	}
}

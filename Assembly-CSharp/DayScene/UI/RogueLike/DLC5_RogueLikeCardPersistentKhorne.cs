using System;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000358 RID: 856
	[Token(Token = "0x2000358")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentKhorne", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentKhorne", order = 201)]
	public class DLC5_RogueLikeCardPersistentKhorne : RogueLikeCardPersistent
	{
		// Token: 0x0600132D RID: 4909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600132D")]
		[Address(RVA = "0x43B2E0", Offset = "0x439CE0", VA = "0x18043B2E0", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600132E")]
		[Address(RVA = "0x43B4F0", Offset = "0x439EF0", VA = "0x18043B4F0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600132F")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DLC5_RogueLikeCardPersistentKhorne()
		{
		}

		// Token: 0x04001196 RID: 4502
		[Token(Token = "0x4001196")]
		[FieldOffset(Offset = "0x40")]
		public float multiplier;

		// Token: 0x04001197 RID: 4503
		[Token(Token = "0x4001197")]
		[FieldOffset(Offset = "0x44")]
		public float debuffMultiplier;
	}
}

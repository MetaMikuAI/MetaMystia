using System;
using Common.CharacterUtility;
using DEYU.Utils;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.EditingUtility
{
	// Token: 0x02001031 RID: 4145
	[Token(Token = "0x2001031")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(CharacterControllerUnit))]
	public class CharacterUnitEditorHelper : LayerSortingController
	{
		// Token: 0x06005F8E RID: 24462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8E")]
		[Address(RVA = "0x8C7B10", Offset = "0x8C6510", VA = "0x1808C7B10")]
		private void Update()
		{
		}

		// Token: 0x06005F8F RID: 24463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8F")]
		[Address(RVA = "0x8C7610", Offset = "0x8C6010", VA = "0x1808C7610")]
		public void AssignCompact(int rotation, int face)
		{
		}

		// Token: 0x06005F90 RID: 24464 RVA: 0x00021048 File Offset: 0x0001F248
		[Token(Token = "0x6005F90")]
		[Address(RVA = "0x8C7A70", Offset = "0x8C6470", VA = "0x1808C7A70")]
		private ValueTuple<int, int> GetSpriteCode(int orientation, int faceId)
		{
			return default(ValueTuple<int, int>);
		}

		// Token: 0x06005F91 RID: 24465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F91")]
		[Address(RVA = "0x8C77F0", Offset = "0x8C61F0", VA = "0x1808C77F0")]
		public void AssignFull(int rotation, int face)
		{
		}

		// Token: 0x06005F92 RID: 24466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F92")]
		[Address(RVA = "0x8C7A30", Offset = "0x8C6430", VA = "0x1808C7A30", Slot = "4")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005F93 RID: 24467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F93")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public CharacterUnitEditorHelper()
		{
		}

		// Token: 0x04005889 RID: 22665
		[Token(Token = "0x4005889")]
		[FieldOffset(Offset = "0x0")]
		[CleanupIgnore]
		private static Sprite[] m_CachedSprite;

		// Token: 0x0400588A RID: 22666
		[Token(Token = "0x400588A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterSpriteSetCompact m_Compact;

		// Token: 0x0400588B RID: 22667
		[Token(Token = "0x400588B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CharacterSpriteSetFull m_Full;

		// Token: 0x0400588C RID: 22668
		[Token(Token = "0x400588C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int m_SelectedRotation;

		// Token: 0x0400588D RID: 22669
		[Token(Token = "0x400588D")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private int m_SelectedFace;
	}
}

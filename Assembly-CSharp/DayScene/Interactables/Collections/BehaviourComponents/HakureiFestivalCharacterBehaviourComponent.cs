using System;
using Common.CharacterUtility;
using DayScene.Input;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004D8 RID: 1240
	[Token(Token = "0x20004D8")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(CharacterControllerUnit))]
	public class HakureiFestivalCharacterBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001C0E RID: 7182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0E")]
		[Address(RVA = "0x49ED40", Offset = "0x49D740", VA = "0x18049ED40")]
		private void OnValidate()
		{
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0F")]
		[Address(RVA = "0x49EA40", Offset = "0x49D440", VA = "0x18049EA40", Slot = "12")]
		protected override void OnInitialize()
		{
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C10")]
		[Address(RVA = "0x49EC40", Offset = "0x49D640", VA = "0x18049EC40", Slot = "8")]
		public override void OnPlayerStay()
		{
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C11")]
		[Address(RVA = "0x49EC00", Offset = "0x49D600", VA = "0x18049EC00", Slot = "9")]
		public override void OnPlayerExit()
		{
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C12")]
		[Address(RVA = "0x49EB40", Offset = "0x49D540", VA = "0x18049EB40", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		[Token(Token = "0x6001C13")]
		[Address(RVA = "0x49E9A0", Offset = "0x49D3A0", VA = "0x18049E9A0")]
		private ValueTuple<int, int> GetSpriteCode(int orientation, int faceId)
		{
			return default(ValueTuple<int, int>);
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C14")]
		[Address(RVA = "0x49E930", Offset = "0x49D330", VA = "0x18049E930", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C15")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public HakureiFestivalCharacterBehaviourComponent()
		{
		}

		// Token: 0x040019A2 RID: 6562
		[Token(Token = "0x40019A2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_DaySceneNPCLabel;

		// Token: 0x040019A3 RID: 6563
		[Token(Token = "0x40019A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_UsePlainSpriteSet;

		// Token: 0x040019A4 RID: 6564
		[Token(Token = "0x40019A4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterSpriteSetCompact m_CharacterSpriteSet;

		// Token: 0x040019A5 RID: 6565
		[Token(Token = "0x40019A5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DayScenePlayerInputGenerator.CharacterRotation m_FaceDirection;

		// Token: 0x040019A6 RID: 6566
		[Token(Token = "0x40019A6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] m_DialogPackages;

		// Token: 0x040019A7 RID: 6567
		[Token(Token = "0x40019A7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Collider2D m_Collider;

		// Token: 0x040019A8 RID: 6568
		[Token(Token = "0x40019A8")]
		[FieldOffset(Offset = "0x48")]
		private bool hasInteracted;

		// Token: 0x040019A9 RID: 6569
		[Token(Token = "0x40019A9")]
		[FieldOffset(Offset = "0x50")]
		private CharacterControllerUnit m_CharacterControllerUnit;
	}
}

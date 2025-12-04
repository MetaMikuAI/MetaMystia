using System;
using DayScene.Input;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FF4 RID: 4084
	[Token(Token = "0x2000FF4")]
	public class COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F00 RID: 24320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F00")]
		[Address(RVA = "0x8BCE80", Offset = "0x8BB880", VA = "0x1808BCE80", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F01 RID: 24321 RVA: 0x00020F28 File Offset: 0x0001F128
		[Token(Token = "0x6005F01")]
		[Address(RVA = "0x8BCE10", Offset = "0x8BB810", VA = "0x1808BCE10")]
		private DayScenePlayerInputGenerator.CharacterRotation GetOppositeRotation(DayScenePlayerInputGenerator.CharacterRotation rotation)
		{
			return DayScenePlayerInputGenerator.CharacterRotation.Down;
		}

		// Token: 0x06005F02 RID: 24322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F02")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc_Behaviour()
		{
		}

		// Token: 0x040057FF RID: 22527
		[Token(Token = "0x40057FF")]
		[FieldOffset(Offset = "0x10")]
		public int characterId;

		// Token: 0x04005800 RID: 22528
		[Token(Token = "0x4005800")]
		[FieldOffset(Offset = "0x14")]
		public SceneDirector.Identity characterType;

		// Token: 0x04005801 RID: 22529
		[Token(Token = "0x4005801")]
		[FieldOffset(Offset = "0x18")]
		public float distance;

		// Token: 0x04005802 RID: 22530
		[Token(Token = "0x4005802")]
		[FieldOffset(Offset = "0x20")]
		public string identifierLabel;

		// Token: 0x04005803 RID: 22531
		[Token(Token = "0x4005803")]
		[FieldOffset(Offset = "0x28")]
		public DayScenePlayerInputGenerator.CharacterRotation targetCharacterOverrideRotation;

		// Token: 0x04005804 RID: 22532
		[Token(Token = "0x4005804")]
		[FieldOffset(Offset = "0x30")]
		public string targetCharacterStringKey;
	}
}

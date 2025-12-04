using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FF3 RID: 4083
	[Token(Token = "0x2000FF3")]
	public class COM_ACharacter_SpawnOrSetPosition_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005EFE RID: 24318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EFE")]
		[Address(RVA = "0x8BCD60", Offset = "0x8BB760", VA = "0x1808BCD60", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005EFF RID: 24319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EFF")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ACharacter_SpawnOrSetPosition_Behaviour()
		{
		}

		// Token: 0x040057F9 RID: 22521
		[Token(Token = "0x40057F9")]
		[FieldOffset(Offset = "0x10")]
		public int characterId;

		// Token: 0x040057FA RID: 22522
		[Token(Token = "0x40057FA")]
		[FieldOffset(Offset = "0x14")]
		public SceneDirector.Identity characterType;

		// Token: 0x040057FB RID: 22523
		[Token(Token = "0x40057FB")]
		[FieldOffset(Offset = "0x18")]
		public string identifierLabel;

		// Token: 0x040057FC RID: 22524
		[Token(Token = "0x40057FC")]
		[FieldOffset(Offset = "0x20")]
		public string positionLabel;

		// Token: 0x040057FD RID: 22525
		[Token(Token = "0x40057FD")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 startPosition;

		// Token: 0x040057FE RID: 22526
		[Token(Token = "0x40057FE")]
		[FieldOffset(Offset = "0x30")]
		public bool usePosition;
	}
}

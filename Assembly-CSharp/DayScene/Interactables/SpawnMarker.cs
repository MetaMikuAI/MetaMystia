using System;
using DayScene.Input;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables
{
	// Token: 0x020004B5 RID: 1205
	[Token(Token = "0x20004B5")]
	[GenerateCleanupMethod]
	public class SpawnMarker : MonoBehaviour
	{
		// Token: 0x06001B67 RID: 7015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B67")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B68")]
		[Address(RVA = "0x3EA340", Offset = "0x3E8D40", VA = "0x1803EA340", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B69")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public SpawnMarker()
		{
		}

		// Token: 0x0400192E RID: 6446
		[Token(Token = "0x400192E")]
		[FieldOffset(Offset = "0x18")]
		public string spawnMarkerName;

		// Token: 0x0400192F RID: 6447
		[Token(Token = "0x400192F")]
		[FieldOffset(Offset = "0x20")]
		public DayScenePlayerInputGenerator.CharacterRotation targetRotation;

		// Token: 0x04001930 RID: 6448
		[Token(Token = "0x4001930")]
		[FieldOffset(Offset = "0x24")]
		public bool shouldOverrideRadius;

		// Token: 0x04001931 RID: 6449
		[Token(Token = "0x4001931")]
		[FieldOffset(Offset = "0x28")]
		public float overrideRadius;
	}
}

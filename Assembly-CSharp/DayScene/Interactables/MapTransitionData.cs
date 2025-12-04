using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables
{
	// Token: 0x020004B4 RID: 1204
	[Token(Token = "0x20004B4")]
	[GenerateCleanupMethod]
	public class MapTransitionData : MonoBehaviour
	{
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x0000A938 File Offset: 0x00008B38
		[Token(Token = "0x170003D4")]
		public bool Unlocked
		{
			[Token(Token = "0x6001B63")]
			[Address(RVA = "0x4A1480", Offset = "0x49FE80", VA = "0x1804A1480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B64")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B65")]
		[Address(RVA = "0x4A1430", Offset = "0x49FE30", VA = "0x1804A1430", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public MapTransitionData()
		{
		}

		// Token: 0x0400192A RID: 6442
		[Token(Token = "0x400192A")]
		[FieldOffset(Offset = "0x18")]
		public bool shouldCostAction;

		// Token: 0x0400192B RID: 6443
		[Token(Token = "0x400192B")]
		[FieldOffset(Offset = "0x20")]
		public AudioClip transitionClip;

		// Token: 0x0400192C RID: 6444
		[Token(Token = "0x400192C")]
		[FieldOffset(Offset = "0x28")]
		public string targetSceneLabel;

		// Token: 0x0400192D RID: 6445
		[Token(Token = "0x400192D")]
		[FieldOffset(Offset = "0x30")]
		public string targetSceneSpawnMarker;
	}
}

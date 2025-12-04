using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000495 RID: 1173
	[Token(Token = "0x2000495")]
	public class DS_MoveToMap_AtSpawnMarker_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06001AF9 RID: 6905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF9")]
		[Address(RVA = "0x4985E0", Offset = "0x496FE0", VA = "0x1804985E0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06001AFA RID: 6906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFA")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_MoveToMap_AtSpawnMarker_Behaviour()
		{
		}

		// Token: 0x040018A4 RID: 6308
		[Token(Token = "0x40018A4")]
		[FieldOffset(Offset = "0x10")]
		public string targetMapLabel;

		// Token: 0x040018A5 RID: 6309
		[Token(Token = "0x40018A5")]
		[FieldOffset(Offset = "0x18")]
		public string targetMarkerName;

		// Token: 0x040018A6 RID: 6310
		[Token(Token = "0x40018A6")]
		[FieldOffset(Offset = "0x20")]
		public bool shouldCostAction;

		// Token: 0x040018A7 RID: 6311
		[Token(Token = "0x40018A7")]
		[FieldOffset(Offset = "0x21")]
		public bool shouldFadeInFadeOut;

		// Token: 0x040018A8 RID: 6312
		[Token(Token = "0x40018A8")]
		[FieldOffset(Offset = "0x22")]
		public bool triggerEnterMapEvent;
	}
}

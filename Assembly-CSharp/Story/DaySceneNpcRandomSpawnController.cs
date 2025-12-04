using System;
using DayScene.Input;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Story
{
	// Token: 0x0200007F RID: 127
	[Token(Token = "0x200007F")]
	[GenerateCleanupMethod]
	public class DaySceneNpcRandomSpawnController : MonoBehaviour
	{
		// Token: 0x060002CA RID: 714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x4256E0", Offset = "0x4240E0", VA = "0x1804256E0")]
		private void Start()
		{
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x4255E0", Offset = "0x423FE0", VA = "0x1804255E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x425810", Offset = "0x424210", VA = "0x180425810")]
		private void UpdateNpcPosition()
		{
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x4257D0", Offset = "0x4241D0", VA = "0x1804257D0")]
		private void UpdateNpcPosition(string npcLabel)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x3EE530", Offset = "0x3ECF30", VA = "0x1803EE530", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public DaySceneNpcRandomSpawnController()
		{
		}

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_NpcLabel;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DaySceneNpcRandomSpawnController.RandomSpawnData[] m_Maps;

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x2000080")]
		[Serializable]
		private struct RandomSpawnData
		{
			// Token: 0x040002AE RID: 686
			[Token(Token = "0x40002AE")]
			[FieldOffset(Offset = "0x0")]
			public string MapLabel;

			// Token: 0x040002AF RID: 687
			[Token(Token = "0x40002AF")]
			[FieldOffset(Offset = "0x8")]
			public string EventId;

			// Token: 0x040002B0 RID: 688
			[Token(Token = "0x40002B0")]
			[FieldOffset(Offset = "0x10")]
			public DaySceneNpcRandomSpawnController.RandomSpawnData.KeyValuePair<Vector2, DayScenePlayerInputGenerator.CharacterRotation>[] Position;

			// Token: 0x02000081 RID: 129
			[Token(Token = "0x2000081")]
			[Serializable]
			public struct KeyValuePair<TKey, TValue>
			{
				// Token: 0x040002B1 RID: 689
				[Token(Token = "0x40002B1")]
				[FieldOffset(Offset = "0x0")]
				public TKey Position;

				// Token: 0x040002B2 RID: 690
				[Token(Token = "0x40002B2")]
				[FieldOffset(Offset = "0x0")]
				public TValue Rotation;
			}
		}
	}
}

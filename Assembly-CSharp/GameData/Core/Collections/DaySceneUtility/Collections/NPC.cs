using System;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000AFB RID: 2811
	[Token(Token = "0x2000AFB")]
	[Serializable]
	public struct NPC
	{
		// Token: 0x060043DC RID: 17372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043DC")]
		[Address(RVA = "0x71DEF0", Offset = "0x71C8F0", VA = "0x18071DEF0")]
		public NPC(SpecialGuest specialNPC)
		{
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043DD")]
		[Address(RVA = "0x71DDD0", Offset = "0x71C7D0", VA = "0x18071DDD0")]
		public CharacterSpriteSetCompact GetVisual()
		{
			return null;
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x00018960 File Offset: 0x00016B60
		[Token(Token = "0x60043DE")]
		[Address(RVA = "0x71DDA0", Offset = "0x71C7A0", VA = "0x18071DDA0")]
		public Vector2Int GetTrueShowAction()
		{
			return default(Vector2Int);
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x00018978 File Offset: 0x00016B78
		[Token(Token = "0x60043DF")]
		[Address(RVA = "0x71DB90", Offset = "0x71C590", VA = "0x18071DB90")]
		public NPC.Destination GenerateFirstDestination()
		{
			return default(NPC.Destination);
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x00018990 File Offset: 0x00016B90
		[Token(Token = "0x60043E0")]
		[Address(RVA = "0x71DC60", Offset = "0x71C660", VA = "0x18071DC60")]
		public NPC.Destination GenerateNextDestination(NPC.Destination destination)
		{
			return default(NPC.Destination);
		}

		// Token: 0x060043E1 RID: 17377 RVA: 0x000189A8 File Offset: 0x00016BA8
		[Token(Token = "0x60043E1")]
		[Address(RVA = "0x71DD80", Offset = "0x71C780", VA = "0x18071DD80")]
		public int GenerateRestDays()
		{
			return 0;
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043E2")]
		[Address(RVA = "0x71DDE0", Offset = "0x71C7E0", VA = "0x18071DDE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04003BE7 RID: 15335
		[Token(Token = "0x4003BE7")]
		[FieldOffset(Offset = "0x0")]
		private static NPC.Destination defaultDestination;

		// Token: 0x04003BE8 RID: 15336
		[Token(Token = "0x4003BE8")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public string key;

		// Token: 0x04003BE9 RID: 15337
		[Token(Token = "0x4003BE9")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public SchedulerNode.Character identity;

		// Token: 0x04003BEA RID: 15338
		[Token(Token = "0x4003BEA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public bool offByDefault;

		// Token: 0x04003BEB RID: 15339
		[Token(Token = "0x4003BEB")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		public Vector2Int showTime;

		// Token: 0x04003BEC RID: 15340
		[Token(Token = "0x4003BEC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		public Vector2Int restTime;

		// Token: 0x04003BED RID: 15341
		[Token(Token = "0x4003BED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public NPC.Destination[] possibleDestinations;

		// Token: 0x02000AFC RID: 2812
		[Token(Token = "0x2000AFC")]
		[Serializable]
		public struct Destination : IEquatable<NPC.Destination>
		{
			// Token: 0x170009B5 RID: 2485
			// (get) Token: 0x060043E4 RID: 17380 RVA: 0x000189C0 File Offset: 0x00016BC0
			[Token(Token = "0x170009B5")]
			public static NPC.Destination None
			{
				[Token(Token = "0x60043E4")]
				[Address(RVA = "0x7196F0", Offset = "0x7180F0", VA = "0x1807196F0")]
				get
				{
					return default(NPC.Destination);
				}
			}

			// Token: 0x060043E5 RID: 17381 RVA: 0x000189D8 File Offset: 0x00016BD8
			[Token(Token = "0x60043E5")]
			[Address(RVA = "0x719620", Offset = "0x718020", VA = "0x180719620", Slot = "4")]
			public bool Equals(NPC.Destination other)
			{
				return default(bool);
			}

			// Token: 0x060043E6 RID: 17382 RVA: 0x000189F0 File Offset: 0x00016BF0
			[Token(Token = "0x60043E6")]
			[Address(RVA = "0x719650", Offset = "0x718050", VA = "0x180719650")]
			public int GenerateStayDays()
			{
				return 0;
			}

			// Token: 0x060043E7 RID: 17383 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60043E7")]
			[Address(RVA = "0x719670", Offset = "0x718070", VA = "0x180719670", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04003BEE RID: 15342
			[Token(Token = "0x4003BEE")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string spawnMarker;

			// Token: 0x04003BEF RID: 15343
			[Token(Token = "0x4003BEF")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public Vector2Int stayTime;

			// Token: 0x04003BF0 RID: 15344
			[Token(Token = "0x4003BF0")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public string[] initialDialogPackIDs;

			// Token: 0x04003BF1 RID: 15345
			[Token(Token = "0x4003BF1")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public float interactiveAreaSize;
		}
	}
}

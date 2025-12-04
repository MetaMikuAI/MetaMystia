using System;
using System.Collections.Generic;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace GameData.RunTime.DaySceneUtility.Collection
{
	// Token: 0x020007F8 RID: 2040
	[Token(Token = "0x20007F8")]
	[Serializable]
	public class TrackedNPC : IDeepClonable<TrackedNPC>
	{
		// Token: 0x0600304A RID: 12362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600304A")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		[JsonConstructor]
		public TrackedNPC()
		{
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600304B")]
		[Address(RVA = "0x618130", Offset = "0x616B30", VA = "0x180618130", Slot = "4")]
		public TrackedNPC Clone()
		{
			return null;
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600304C")]
		[Address(RVA = "0x6193F0", Offset = "0x617DF0", VA = "0x1806193F0")]
		public TrackedNPC(NPC npcData)
		{
		}

		// Token: 0x0600304D RID: 12365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600304D")]
		[Address(RVA = "0x618A60", Offset = "0x617460", VA = "0x180618A60")]
		public string ToString(int remaindActions)
		{
			return null;
		}

		// Token: 0x0600304E RID: 12366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600304E")]
		[Address(RVA = "0x618490", Offset = "0x616E90", VA = "0x180618490")]
		public CharacterSpriteSetCompact GetVisual()
		{
			return null;
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600304F")]
		[Address(RVA = "0x6192E0", Offset = "0x617CE0", VA = "0x1806192E0")]
		public void UpdateTime()
		{
		}

		// Token: 0x06003050 RID: 12368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003050")]
		[Address(RVA = "0x618550", Offset = "0x616F50", VA = "0x180618550")]
		public void InitializeDestination()
		{
		}

		// Token: 0x06003051 RID: 12369 RVA: 0x00011AC0 File Offset: 0x0000FCC0
		[Token(Token = "0x6003051")]
		[Address(RVA = "0x6188E0", Offset = "0x6172E0", VA = "0x1806188E0")]
		public bool ShouldShown(int remainedActions)
		{
			return default(bool);
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003052")]
		[Address(RVA = "0x618020", Offset = "0x616A20", VA = "0x180618020")]
		public void AddDialogPackage(string destination, string key)
		{
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003053")]
		[Address(RVA = "0x618610", Offset = "0x617010", VA = "0x180618610")]
		public void RemoveDialogPackage(string destination, string key)
		{
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003054")]
		[Address(RVA = "0x618840", Offset = "0x617240", VA = "0x180618840")]
		public void SetDialogPackage(string destination, string[] keys)
		{
		}

		// Token: 0x04002B23 RID: 11043
		[Token(Token = "0x4002B23")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string key;

		// Token: 0x04002B24 RID: 11044
		[Token(Token = "0x4002B24")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public bool openStatus;

		// Token: 0x04002B25 RID: 11045
		[Token(Token = "0x4002B25")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public NPC.Destination currentDestination;

		// Token: 0x04002B26 RID: 11046
		[Token(Token = "0x4002B26")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public int stayedDays;

		// Token: 0x04002B27 RID: 11047
		[Token(Token = "0x4002B27")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		public int restDays;

		// Token: 0x04002B28 RID: 11048
		[Token(Token = "0x4002B28")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public Dictionary<string, Tuple<string, string[]>> dialogPackagePool;

		// Token: 0x04002B29 RID: 11049
		[Token(Token = "0x4002B29")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public TrackedNPC.OverridePosition overridePosition;

		// Token: 0x020007F9 RID: 2041
		[Token(Token = "0x20007F9")]
		[Serializable]
		public class OverridePosition : IDeepClonable<TrackedNPC.OverridePosition>
		{
			// Token: 0x06003055 RID: 12373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003055")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public OverridePosition()
			{
			}

			// Token: 0x06003056 RID: 12374 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003056")]
			[Address(RVA = "0x60A5E0", Offset = "0x608FE0", VA = "0x18060A5E0")]
			public OverridePosition(string mapLabel, Vector2 position, int rotation)
			{
			}

			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x06003057 RID: 12375 RVA: 0x00011AD8 File Offset: 0x0000FCD8
			[Token(Token = "0x17000650")]
			[JsonIgnore]
			public Vector2 Position
			{
				[Token(Token = "0x6003057")]
				[Address(RVA = "0x60A670", Offset = "0x609070", VA = "0x18060A670")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x06003058 RID: 12376 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003058")]
			[Address(RVA = "0x60A530", Offset = "0x608F30", VA = "0x18060A530", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06003059 RID: 12377 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003059")]
			[Address(RVA = "0x60A440", Offset = "0x608E40", VA = "0x18060A440", Slot = "4")]
			public TrackedNPC.OverridePosition Clone()
			{
				return null;
			}

			// Token: 0x04002B2A RID: 11050
			[Token(Token = "0x4002B2A")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			[SerializeField]
			public string mapLabel;

			// Token: 0x04002B2B RID: 11051
			[Token(Token = "0x4002B2B")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[JsonProperty]
			public KeyValuePair<float, float> position;

			// Token: 0x04002B2C RID: 11052
			[Token(Token = "0x4002B2C")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			[JsonProperty]
			public int rotation;
		}
	}
}

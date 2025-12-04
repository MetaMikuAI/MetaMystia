using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.RunTime.DaySceneUtility.Collection
{
	// Token: 0x020007F0 RID: 2032
	[Token(Token = "0x20007F0")]
	[Serializable]
	public class TrackedCollectable : IDeepClonable<TrackedCollectable>
	{
		// Token: 0x0600302C RID: 12332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600302C")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public TrackedCollectable()
		{
		}

		// Token: 0x0600302D RID: 12333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600302D")]
		[Address(RVA = "0x616EB0", Offset = "0x6158B0", VA = "0x180616EB0", Slot = "4")]
		public TrackedCollectable Clone()
		{
			return null;
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600302E")]
		[Address(RVA = "0x617930", Offset = "0x616330", VA = "0x180617930")]
		public TrackedCollectable(Collectable collectable)
		{
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x00011A18 File Offset: 0x0000FC18
		[Token(Token = "0x1700064F")]
		public bool Availabile
		{
			[Token(Token = "0x600302F")]
			[Address(RVA = "0x617980", Offset = "0x616380", VA = "0x180617980")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003030")]
		[Address(RVA = "0x616F80", Offset = "0x615980", VA = "0x180616F80")]
		public void Collect()
		{
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003031")]
		[Address(RVA = "0x6178C0", Offset = "0x6162C0", VA = "0x1806178C0")]
		public void TryUpdateCoolDown(int actionPassed)
		{
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003032")]
		[Address(RVA = "0x6178B0", Offset = "0x6162B0", VA = "0x1806178B0")]
		public void RefreshCoolDownImmediately()
		{
		}

		// Token: 0x04002B0E RID: 11022
		[Token(Token = "0x4002B0E")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string key;

		// Token: 0x04002B0F RID: 11023
		[Token(Token = "0x4002B0F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public int currentCoolDown;

		// Token: 0x04002B10 RID: 11024
		[Token(Token = "0x4002B10")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		public bool openStatus;
	}
}

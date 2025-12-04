using System;
using System.Collections.Generic;
using DayScene.Interactables.Collections.ConditionExtensions;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x020004D0 RID: 1232
	[Token(Token = "0x20004D0")]
	[RequireComponent(typeof(VisualEntity))]
	[GenerateCleanupMethod]
	public abstract class EntityConditionComponent : MonoBehaviour
	{
		// Token: 0x06001BEE RID: 7150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEE")]
		public static void TryUpdateConditionComponent<T>() where T : class
		{
		}

		// Token: 0x06001BEF RID: 7151
		[Token(Token = "0x6001BEF")]
		protected abstract Type GetComponentType();

		// Token: 0x06001BF0 RID: 7152 RVA: 0x0000AC20 File Offset: 0x00008E20
		[Token(Token = "0x6001BF0")]
		[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "5")]
		protected virtual bool AutoInitialize()
		{
			return default(bool);
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x0000AC38 File Offset: 0x00008E38
		[Token(Token = "0x6001BF1")]
		[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0", Slot = "6")]
		protected virtual bool ShouldFadeOut()
		{
			return default(bool);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF2")]
		[Address(RVA = "0x49CD00", Offset = "0x49B700", VA = "0x18049CD00")]
		public static void Dispose()
		{
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF3")]
		[Address(RVA = "0x49D0F0", Offset = "0x49BAF0", VA = "0x18049D0F0")]
		public void Initialize()
		{
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF4")]
		[Address(RVA = "0x49CCB0", Offset = "0x49B6B0", VA = "0x18049CCB0")]
		private void Awake()
		{
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF5")]
		[Address(RVA = "0x49D5D0", Offset = "0x49BFD0", VA = "0x18049D5D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF6")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "7")]
		protected virtual void PostDestroy()
		{
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF7")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "8")]
		protected virtual void OnInitialize()
		{
		}

		// Token: 0x06001BF8 RID: 7160
		[Token(Token = "0x6001BF8")]
		protected abstract bool OnGetAvailability();

		// Token: 0x06001BF9 RID: 7161 RVA: 0x0000AC50 File Offset: 0x00008E50
		[Token(Token = "0x6001BF9")]
		[Address(RVA = "0x49CD70", Offset = "0x49B770", VA = "0x18049CD70")]
		private bool GetAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFA")]
		[Address(RVA = "0x49D760", Offset = "0x49C160", VA = "0x18049D760")]
		protected void Refresh()
		{
		}

		// Token: 0x06001BFB RID: 7163 RVA: 0x0000AC68 File Offset: 0x00008E68
		[Token(Token = "0x6001BFB")]
		[Address(RVA = "0x49CCF0", Offset = "0x49B6F0", VA = "0x18049CCF0")]
		private bool CalculateAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFC")]
		[Address(RVA = "0x494090", Offset = "0x492A90", VA = "0x180494090", Slot = "10")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFD")]
		[Address(RVA = "0x49D860", Offset = "0x49C260", VA = "0x18049D860")]
		protected EntityConditionComponent()
		{
		}

		// Token: 0x04001988 RID: 6536
		[Token(Token = "0x4001988")]
		[FieldOffset(Offset = "0x0")]
		[CleanupIgnore]
		private static readonly Dictionary<Type, HashSet<Action>> conditionUpdateAction;

		// Token: 0x04001989 RID: 6537
		[Token(Token = "0x4001989")]
		[FieldOffset(Offset = "0x18")]
		[CleanupIgnore]
		private Action<bool, bool> onRefreshEntityCallback;

		// Token: 0x0400198A RID: 6538
		[Token(Token = "0x400198A")]
		[FieldOffset(Offset = "0x20")]
		protected bool initialized;

		// Token: 0x0400198B RID: 6539
		[Token(Token = "0x400198B")]
		[FieldOffset(Offset = "0x24")]
		public EntityConditionComponent.Rule CheckRule;

		// Token: 0x0400198C RID: 6540
		[Token(Token = "0x400198C")]
		[FieldOffset(Offset = "0x28")]
		public bool DisableInNX;

		// Token: 0x0400198D RID: 6541
		[Token(Token = "0x400198D")]
		[FieldOffset(Offset = "0x30")]
		public EntityConditionExtension[] Extensions;

		// Token: 0x0400198E RID: 6542
		[Token(Token = "0x400198E")]
		[FieldOffset(Offset = "0x38")]
		private bool[] m_Status;

		// Token: 0x020004D1 RID: 1233
		[Token(Token = "0x20004D1")]
		public enum Rule
		{
			// Token: 0x04001990 RID: 6544
			[Token(Token = "0x4001990")]
			AllTrue,
			// Token: 0x04001991 RID: 6545
			[Token(Token = "0x4001991")]
			AnyTrue,
			// Token: 0x04001992 RID: 6546
			[Token(Token = "0x4001992")]
			AllFalseExceptItself
		}
	}
}

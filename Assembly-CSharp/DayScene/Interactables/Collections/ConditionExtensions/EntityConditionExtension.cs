using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.Interactables.Collections.ConditionExtensions
{
	// Token: 0x020004C0 RID: 1216
	[Token(Token = "0x20004C0")]
	[GenerateCleanupMethod]
	public abstract class EntityConditionExtension : MonoBehaviour
	{
		// Token: 0x06001BA3 RID: 7075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0x43B080", Offset = "0x439A80", VA = "0x18043B080")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001BA4 RID: 7076
		[Token(Token = "0x6001BA4")]
		public abstract bool OnGetExtensionAvailability();

		// Token: 0x06001BA5 RID: 7077
		[Token(Token = "0x6001BA5")]
		public abstract Type OnGetExtensionType();

		// Token: 0x06001BA6 RID: 7078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		protected EntityConditionExtension()
		{
		}
	}
}

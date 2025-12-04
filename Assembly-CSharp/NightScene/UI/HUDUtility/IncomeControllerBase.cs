using System;
using Common.UI;
using Il2CppDummyDll;
using NightScene.EventUtility;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020006D2 RID: 1746
	[Token(Token = "0x20006D2")]
	[GenerateCleanupMethod]
	public class IncomeControllerBase : MonoBehaviour
	{
		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600295B RID: 10587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CC")]
		protected PassionController passionController
		{
			[Token(Token = "0x600295B")]
			[Address(RVA = "0x5471B0", Offset = "0x545BB0", VA = "0x1805471B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CD")]
		protected ComboController comboController
		{
			[Token(Token = "0x600295C")]
			[Address(RVA = "0x547130", Offset = "0x545B30", VA = "0x180547130")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600295D RID: 10589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CE")]
		protected ClockController clockController
		{
			[Token(Token = "0x600295D")]
			[Address(RVA = "0x5470E0", Offset = "0x545AE0", VA = "0x1805470E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CF")]
		protected EventManager eventManager
		{
			[Token(Token = "0x600295E")]
			[Address(RVA = "0x547180", Offset = "0x545B80", VA = "0x180547180")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x0600295F RID: 10591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005D0")]
		protected TextMeshProUGUI IzakayaDescription
		{
			[Token(Token = "0x600295F")]
			[Address(RVA = "0x5470A0", Offset = "0x545AA0", VA = "0x1805470A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002960")]
		[Address(RVA = "0x4043B0", Offset = "0x402DB0", VA = "0x1804043B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002961")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "4")]
		public virtual void Initialize()
		{
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002962")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500")]
		protected void SetExp(int amount)
		{
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002963")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "5")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002964")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public IncomeControllerBase()
		{
		}
	}
}

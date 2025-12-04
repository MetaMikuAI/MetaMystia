using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.Singletons;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using NightScene.UI;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.CookingUtility
{
	// Token: 0x02000690 RID: 1680
	[Token(Token = "0x2000690")]
	[GenerateCleanupMethod]
	public class CookSystemManager : MonoSingleton<CookSystemManager>
	{
		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000590")]
		public UIManager HudManager
		{
			[Token(Token = "0x600278E")]
			[Address(RVA = "0x531200", Offset = "0x52FC00", VA = "0x180531200")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002790 RID: 10128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000591")]
		private Dictionary<Vector3Int, CookController> AllCookers
		{
			[Token(Token = "0x600278F")]
			[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002790")]
			[Address(RVA = "0x531450", Offset = "0x52FE50", VA = "0x180531450")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000592")]
		public IEnumerable<CookController> AllCookerControllers
		{
			[Token(Token = "0x6002791")]
			[Address(RVA = "0x5311B0", Offset = "0x52FBB0", VA = "0x1805311B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002792")]
		[Address(RVA = "0x530DF0", Offset = "0x52F7F0", VA = "0x180530DF0")]
		public void SetCookingSelectionModuleAlpha(float ing, float recipe)
		{
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002793")]
		[Address(RVA = "0x530E00", Offset = "0x52F800", VA = "0x180530E00")]
		public void SetStorageModuleAlpha(float food, float bev)
		{
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x0000EB68 File Offset: 0x0000CD68
		// (set) Token: 0x06002795 RID: 10133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000593")]
		public bool IsCookingSelectionPanelOpen
		{
			[Token(Token = "0x6002794")]
			[Address(RVA = "0x531230", Offset = "0x52FC30", VA = "0x180531230")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002795")]
			[Address(RVA = "0x4D2420", Offset = "0x4D0E20", VA = "0x1804D2420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06002796 RID: 10134 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002797 RID: 10135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000021")]
		public event Action<CookController> OnQTENotFullScoreCallback
		{
			[Token(Token = "0x6002796")]
			[Address(RVA = "0x531050", Offset = "0x52FA50", VA = "0x180531050")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002797")]
			[Address(RVA = "0x5312F0", Offset = "0x52FCF0", VA = "0x1805312F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06002798 RID: 10136 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002799 RID: 10137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000022")]
		public event Action<Sellable, Recipe> OnCookerStartCookCallback
		{
			[Token(Token = "0x6002798")]
			[Address(RVA = "0x530FA0", Offset = "0x52F9A0", VA = "0x180530FA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002799")]
			[Address(RVA = "0x531240", Offset = "0x52FC40", VA = "0x180531240")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279A")]
		[Address(RVA = "0x52F1E0", Offset = "0x52DBE0", VA = "0x18052F1E0")]
		public void CallCookerStartCallback(Sellable sellable, Recipe recipe)
		{
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x0600279B RID: 10139 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600279C RID: 10140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000023")]
		public event Action<Sellable> OnResultCompleteCallback
		{
			[Token(Token = "0x600279B")]
			[Address(RVA = "0x531100", Offset = "0x52FB00", VA = "0x180531100")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600279C")]
			[Address(RVA = "0x5313A0", Offset = "0x52FDA0", VA = "0x1805313A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279D")]
		[Address(RVA = "0x52F6B0", Offset = "0x52E0B0", VA = "0x18052F6B0")]
		public void CallOnResultCompleteCallback(Sellable sellable)
		{
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x0000EB80 File Offset: 0x0000CD80
		[Token(Token = "0x600279E")]
		[Address(RVA = "0x52FBD0", Offset = "0x52E5D0", VA = "0x18052FBD0")]
		public bool GetCooker(Sellable sellable, out Cooker cookerData)
		{
			return default(bool);
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600279F")]
		[Address(RVA = "0x530C20", Offset = "0x52F620", VA = "0x180530C20")]
		public void RegisterCooker(Sellable sellable, Cooker cookerData)
		{
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A0")]
		[Address(RVA = "0x530D10", Offset = "0x52F710", VA = "0x180530D10")]
		public void ReleaseCooker(Sellable sellable)
		{
		}

		// Token: 0x060027A1 RID: 10145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027A1")]
		[Address(RVA = "0x52FCE0", Offset = "0x52E6E0", VA = "0x18052FCE0")]
		public IEnumerable<NormalGuest> GetRandomNormalGuestGroups()
		{
			return null;
		}

		// Token: 0x060027A2 RID: 10146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A2")]
		[Address(RVA = "0x530010", Offset = "0x52EA10", VA = "0x180530010")]
		public void Initialize(IReadOnlyList<Vector3Int> cookerPositions)
		{
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x0000EB98 File Offset: 0x0000CD98
		[Token(Token = "0x60027A3")]
		[Address(RVA = "0x52F850", Offset = "0x52E250", VA = "0x18052F850")]
		public bool CouldCookerOpen(Vector3Int targetPos)
		{
			return default(bool);
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A4")]
		[Address(RVA = "0x530880", Offset = "0x52F280", VA = "0x180530880")]
		public void RefreshCookerStatus()
		{
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A5")]
		[Address(RVA = "0x52F770", Offset = "0x52E170", VA = "0x18052F770")]
		public void CallTrash()
		{
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A6")]
		[Address(RVA = "0x52F6F0", Offset = "0x52E0F0", VA = "0x18052F6F0")]
		public void CallStorage(Sellable.SellableType storageType)
		{
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027A7")]
		[Address(RVA = "0x52FB60", Offset = "0x52E560", VA = "0x18052FB60")]
		public CookController GetCooker(Vector3Int cookerPosition)
		{
			return null;
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027A8")]
		[Address(RVA = "0x52F930", Offset = "0x52E330", VA = "0x18052F930")]
		public IEnumerable<Sellable> DumpAllCookers()
		{
			return null;
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A9")]
		[Address(RVA = "0x52F200", Offset = "0x52DC00", VA = "0x18052F200")]
		public void CallCooker(Vector3Int cookerPosition)
		{
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AA")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500")]
		public void RefreshCookingSelectionUI()
		{
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AB")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500")]
		public void RefreshInventoryUI()
		{
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AC")]
		[Address(RVA = "0x530830", Offset = "0x52F230", VA = "0x180530830", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AD")]
		[Address(RVA = "0x52F6D0", Offset = "0x52E0D0", VA = "0x18052F6D0")]
		public void CallQTENotFullScore(CookController cookController)
		{
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AE")]
		[Address(RVA = "0x52F7C0", Offset = "0x52E1C0", VA = "0x18052F7C0", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AF")]
		[Address(RVA = "0x530F00", Offset = "0x52F900", VA = "0x180530F00")]
		public CookSystemManager()
		{
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B0")]
		[Address(RVA = "0x530E10", Offset = "0x52F810", VA = "0x180530E10")]
		[CompilerGenerated]
		private void <CallCooker>g__TryCallCook|39_0(ref CookSystemManager.<>c__DisplayClass39_0 A_1)
		{
		}

		// Token: 0x04002410 RID: 9232
		[Token(Token = "0x4002410")]
		[FieldOffset(Offset = "0x18")]
		private readonly Dictionary<Guid, Cooker> registeredSellables;

		// Token: 0x04002411 RID: 9233
		[Token(Token = "0x4002411")]
		[FieldOffset(Offset = "0x20")]
		private Vector2 cookingSelectionModuleAlpha;

		// Token: 0x04002412 RID: 9234
		[Token(Token = "0x4002412")]
		[FieldOffset(Offset = "0x28")]
		private Vector2 storageModuleAlpha;
	}
}

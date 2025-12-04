using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.CharacterUtility;
using DEYU.Singletons;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x02000595 RID: 1429
	[Token(Token = "0x2000595")]
	[GenerateCleanupMethod]
	public class GuestsManager : MonoSingleton<GuestsManager>
	{
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060020AC RID: 8364 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x060020AD RID: 8365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000010")]
		public event Action<GuestGroupController> OnGuestSpawn
		{
			[Token(Token = "0x60020AC")]
			[Address(RVA = "0x4E05A0", Offset = "0x4DEFA0", VA = "0x1804E05A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60020AD")]
			[Address(RVA = "0x4E0A60", Offset = "0x4DF460", VA = "0x1804E0A60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020AF RID: 8367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000463")]
		public Action<SpecialGuestsController> OnPositiveSpellTriggered
		{
			[Token(Token = "0x60020AE")]
			[Address(RVA = "0x48A630", Offset = "0x489030", VA = "0x18048A630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020AF")]
			[Address(RVA = "0x4D2650", Offset = "0x4D1050", VA = "0x1804D2650")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020B1 RID: 8369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000464")]
		public Action<SpecialGuestsController> OnPositiveSpellEnd
		{
			[Token(Token = "0x60020B0")]
			[Address(RVA = "0x4D1EB0", Offset = "0x4D08B0", VA = "0x1804D1EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020B1")]
			[Address(RVA = "0x4D25B0", Offset = "0x4D0FB0", VA = "0x1804D25B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060020B2 RID: 8370 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020B3 RID: 8371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000465")]
		public Action<SpecialGuestsController> OnSpellEnd
		{
			[Token(Token = "0x60020B2")]
			[Address(RVA = "0x4D1EE0", Offset = "0x4D08E0", VA = "0x1804D1EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020B3")]
			[Address(RVA = "0x4D2630", Offset = "0x4D1030", VA = "0x1804D2630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020B5 RID: 8373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000466")]
		public Action OnIzakayaClosed
		{
			[Token(Token = "0x60020B4")]
			[Address(RVA = "0x4D1EA0", Offset = "0x4D08A0", VA = "0x1804D1EA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020B5")]
			[Address(RVA = "0x4D2510", Offset = "0x4D0F10", VA = "0x1804D2510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060020B6 RID: 8374 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020B7 RID: 8375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000467")]
		public Action OnBussinessTimeEnd
		{
			[Token(Token = "0x60020B6")]
			[Address(RVA = "0x4D1ED0", Offset = "0x4D08D0", VA = "0x1804D1ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020B7")]
			[Address(RVA = "0x4D2610", Offset = "0x4D1010", VA = "0x1804D2610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		// (set) Token: 0x060020B9 RID: 8377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000468")]
		public bool canGuestBeRepelled
		{
			[Token(Token = "0x60020B8")]
			[Address(RVA = "0x4E0A50", Offset = "0x4DF450", VA = "0x1804E0A50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020B9")]
			[Address(RVA = "0x4E0B80", Offset = "0x4DF580", VA = "0x1804E0B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060020BA RID: 8378 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
		// (set) Token: 0x060020BB RID: 8379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000469")]
		public bool IsOpenThroughInteract
		{
			[Token(Token = "0x60020BA")]
			[Address(RVA = "0x4E0780", Offset = "0x4DF180", VA = "0x1804E0780")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x60020BB")]
			[Address(RVA = "0x4E0B40", Offset = "0x4DF540", VA = "0x1804E0B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060020BC RID: 8380 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		// (set) Token: 0x060020BD RID: 8381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046A")]
		private int LevelExtraGuestBaseMood
		{
			[Token(Token = "0x60020BC")]
			[Address(RVA = "0x48A710", Offset = "0x489110", VA = "0x18048A710")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60020BD")]
			[Address(RVA = "0x48AB20", Offset = "0x489520", VA = "0x18048AB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060020BE RID: 8382 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		// (set) Token: 0x060020BF RID: 8383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046B")]
		private float LevelExtraGuestPatient
		{
			[Token(Token = "0x60020BE")]
			[Address(RVA = "0x4E0790", Offset = "0x4DF190", VA = "0x1804E0790")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60020BF")]
			[Address(RVA = "0x4E0B50", Offset = "0x4DF550", VA = "0x1804E0B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020C1 RID: 8385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046C")]
		private Dictionary<int, GuestGroupController> CanPlayerRepellGuest
		{
			[Token(Token = "0x60020C0")]
			[Address(RVA = "0x419D00", Offset = "0x418700", VA = "0x180419D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020C1")]
			[Address(RVA = "0x419D50", Offset = "0x418750", VA = "0x180419D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060020C2 RID: 8386 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020C3 RID: 8387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046D")]
		private Dictionary<int, GuestGroupController> AllGuestsControllersInDesk
		{
			[Token(Token = "0x60020C2")]
			[Address(RVA = "0x4E0700", Offset = "0x4DF100", VA = "0x1804E0700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020C3")]
			[Address(RVA = "0x4E0B20", Offset = "0x4DF520", VA = "0x1804E0B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020C5 RID: 8389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700046E")]
		private Dictionary<int, GuestGroupController> ManualDesksDic
		{
			[Token(Token = "0x60020C4")]
			[Address(RVA = "0x4E07A0", Offset = "0x4DF1A0", VA = "0x1804E07A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020C5")]
			[Address(RVA = "0x4E0B60", Offset = "0x4DF560", VA = "0x1804E0B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046F")]
		[CleanupIgnore]
		private Dictionary<int, int> TrueAvailableDesks
		{
			[Token(Token = "0x60020C6")]
			[Address(RVA = "0x4E07F0", Offset = "0x4DF1F0", VA = "0x1804E07F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x0000C300 File Offset: 0x0000A500
		[Token(Token = "0x17000470")]
		public int MaxDeskNum
		{
			[Token(Token = "0x60020C7")]
			[Address(RVA = "0x4E07B0", Offset = "0x4DF1B0", VA = "0x1804E07B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x0000C318 File Offset: 0x0000A518
		[Token(Token = "0x17000471")]
		public int CurrentOccupiedDeskNum
		{
			[Token(Token = "0x60020C8")]
			[Address(RVA = "0x4E0710", Offset = "0x4DF110", VA = "0x1804E0710")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060020C9 RID: 8393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000472")]
		public IEnumerable<int> AllGuestInDeskCode
		{
			[Token(Token = "0x60020C9")]
			[Address(RVA = "0x4E0660", Offset = "0x4DF060", VA = "0x1804E0660")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000473")]
		public IEnumerable<GuestGroupController> AllGuestInDeskController
		{
			[Token(Token = "0x60020CA")]
			[Address(RVA = "0x4E06B0", Offset = "0x4DF0B0", VA = "0x1804E06B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060020CB RID: 8395 RVA: 0x0000C330 File Offset: 0x0000A530
		[Token(Token = "0x17000474")]
		public int InitializedControllerMood
		{
			[Token(Token = "0x60020CB")]
			[Address(RVA = "0x4E0750", Offset = "0x4DF150", VA = "0x1804E0750")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CC")]
		[Address(RVA = "0x4D7DF0", Offset = "0x4D67F0", VA = "0x1804D7DF0")]
		public string GetAllDeskData()
		{
			return null;
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x4D94D0", Offset = "0x4D7ED0", VA = "0x1804D94D0")]
		public void Initialize(Func<Action<AStarInputGeneratorComponent>> getPostprocessCharacterCallback)
		{
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CE")]
		[Address(RVA = "0x4D9000", Offset = "0x4D7A00", VA = "0x1804D9000")]
		public void InitializeHUD()
		{
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x4DC930", Offset = "0x4DB330", VA = "0x1804DC930")]
		public void RemoveGuestIcon(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x0000C348 File Offset: 0x0000A548
		[Token(Token = "0x60020D0")]
		[Address(RVA = "0x4D40C0", Offset = "0x4D2AC0", VA = "0x1804D40C0")]
		public bool CheckCanPlayerRepelGuest(int deskCode)
		{
			return default(bool);
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D1")]
		[Address(RVA = "0x4DD670", Offset = "0x4DC070", VA = "0x1804DD670")]
		private void SetPlayerCanRepelGuest(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x4DD650", Offset = "0x4DC050", VA = "0x1804DD650")]
		private void SetPlayerCanNotRepelGuest(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x0000C360 File Offset: 0x0000A560
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x4D4150", Offset = "0x4D2B50", VA = "0x1804D4150")]
		private bool CheckGuestIsInDesk(int deskCode)
		{
			return default(bool);
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x4DCD90", Offset = "0x4DB790", VA = "0x1804DCD90")]
		private void SetGuestInDesk(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D5")]
		[Address(RVA = "0x4DCDB0", Offset = "0x4DB7B0", VA = "0x1804DCDB0")]
		private void SetGuestOutDesk(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x4D8520", Offset = "0x4D6F20", VA = "0x1804D8520")]
		public GuestGroupController GetInDeskGuest(int deskCode)
		{
			return null;
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x4DC530", Offset = "0x4DAF30", VA = "0x1804DC530")]
		private void Register(Dictionary<int, GuestGroupController> collection, GuestGroupController data)
		{
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D8")]
		[Address(RVA = "0x4D47C0", Offset = "0x4D31C0", VA = "0x1804D47C0")]
		private void DeRegister(Dictionary<int, GuestGroupController> collection, GuestGroupController data)
		{
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020D9")]
		[Address(RVA = "0x4D70C0", Offset = "0x4D5AC0", VA = "0x1804D70C0")]
		public void ExcuteEventAtCorodinate(int corodinate)
		{
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DA")]
		[Address(RVA = "0x4D3C40", Offset = "0x4D2640", VA = "0x1804D3C40")]
		public void AddToOrder(GuestsManager.OrderBase add)
		{
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x4DC750", Offset = "0x4DB150", VA = "0x1804DC750")]
		public void RemoveFromOrder(GuestsManager.OrderBase order)
		{
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x4DAAA0", Offset = "0x4D94A0", VA = "0x1804DAAA0")]
		public void ManualSpawnNormalGuestGroups(int amount, int durationSec, out Action onInterruptCallback, int targetNormalGuestId = -1, bool continueToSpawnAfterDayEnd = false)
		{
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x4DA960", Offset = "0x4D9360", VA = "0x1804DA960")]
		public void ManualSpawnNormalGuestGroups(Vector2 spawnTime, int durationSec, out Action onInterruptCallback, float extraSpawnRate, int targetNormalGuestId = -1, bool continueToSpawnAfterDayEnd = false)
		{
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x4DA7D0", Offset = "0x4D91D0", VA = "0x1804DA7D0")]
		public void ManualSpawnGuestGroupsFromTargetIzakaya(Izakaya.NormalGuestGroup[] normalGuestGroups, Vector2 normalGuestSpanInterval, float specialGuestGachaInterval, IReadOnlyList<int> specialGuestPool, float extraRefreshRate, out Action onInterruptCallback, bool continueToSpawnAfterDayEnd = false)
		{
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x4DABD0", Offset = "0x4D95D0", VA = "0x1804DABD0")]
		public void ManualSpawnSpecialGuestGroupsFromPoolForSara(int spawnInterval, out Action onInterruptCallback, Action onAllGuestSpawned, bool continueToSpawnAfterDayEnd = false)
		{
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E0")]
		[Address(RVA = "0x4DAD00", Offset = "0x4D9700", VA = "0x1804DAD00")]
		public void MoodEdit(IEnumerable<GuestGroupController> toEdit, float value, EventManager.MathOperation math)
		{
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E1")]
		[Address(RVA = "0x4DADE0", Offset = "0x4D97E0", VA = "0x1804DADE0")]
		public void MoodEdit(GuestGroupController toEdit, float value, EventManager.MathOperation math)
		{
		}

		// Token: 0x060020E2 RID: 8418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E2")]
		[Address(RVA = "0x4DF350", Offset = "0x4DDD50", VA = "0x1804DF350")]
		public void TryCloseIzakaya()
		{
		}

		// Token: 0x060020E3 RID: 8419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E3")]
		[Address(RVA = "0x4D4720", Offset = "0x4D3120", VA = "0x1804D4720")]
		public IEnumerator CloseIzakayaDelayed(GuestsManager.IzakayaCloseType izakayaCloseType, [Optional] Action onSessionLeave)
		{
			return null;
		}

		// Token: 0x060020E4 RID: 8420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E4")]
		[Address(RVA = "0x4D4500", Offset = "0x4D2F00", VA = "0x1804D4500")]
		public void CloseIzakayaAndLeaveChallengeMode(Action onSessionLeave, bool needAutoFadeOut = false)
		{
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E5")]
		[Address(RVA = "0x4D48A0", Offset = "0x4D32A0", VA = "0x1804D48A0")]
		public void DisposeAllFoods()
		{
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E6")]
		[Address(RVA = "0x4D4F80", Offset = "0x4D3980", VA = "0x1804D4F80")]
		public void DisposeTray()
		{
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E7")]
		[Address(RVA = "0x4DB230", Offset = "0x4D9C30", VA = "0x1804DB230")]
		public IEnumerator OnWaitForAllGuestToLeave(Func<IEnumerator> onFinish)
		{
			return null;
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E8")]
		[Address(RVA = "0x4DB0D0", Offset = "0x4D9AD0", VA = "0x1804DB0D0")]
		public IEnumerator OnWaitForAllGuestDisAppear(Func<IEnumerator> onFinish)
		{
			return null;
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E9")]
		[Address(RVA = "0x4DB160", Offset = "0x4D9B60", VA = "0x1804DB160")]
		public IEnumerator OnWaitForAllGuestToLeaveForRogueLike(Func<IEnumerator> onFinish, int extraWaitTime, [Optional] Func<bool> extraCheck, [Optional] Action onGuestAllLeave)
		{
			return null;
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EA")]
		[Address(RVA = "0x4DF470", Offset = "0x4DDE70", VA = "0x1804DF470")]
		public void TryRepellAllQueuedGuestControllers()
		{
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EB")]
		[Address(RVA = "0x4DEA70", Offset = "0x4DD470", VA = "0x1804DEA70")]
		public void SpawnNormalGuestGroupExtern()
		{
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EC")]
		[Address(RVA = "0x4DB010", Offset = "0x4D9A10", VA = "0x1804DB010")]
		private IEnumerator OnIdleDialog()
		{
			return null;
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020ED")]
		[Address(RVA = "0x4DE330", Offset = "0x4DCD30", VA = "0x1804DE330")]
		public void ShowTargetDialog(string message, GuestGroupController guestGroupController, GuestGroupController.EvaluationResult boxType)
		{
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EE")]
		[Address(RVA = "0x4DE1B0", Offset = "0x4DCBB0", VA = "0x1804DE1B0")]
		public void ShowRepellDialog(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EF")]
		[Address(RVA = "0x4DE290", Offset = "0x4DCC90", VA = "0x1804DE290")]
		public void ShowSeenRepellDialog(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F0")]
		[Address(RVA = "0x4DD7F0", Offset = "0x4DC1F0", VA = "0x1804DD7F0")]
		private IEnumerator ShowEvaluationDialog(GuestGroupController toTalk, string message, GuestGroupController.EvaluationResult result, Transform target)
		{
			return null;
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x0000C378 File Offset: 0x0000A578
		[Token(Token = "0x60020F1")]
		[Address(RVA = "0x4DF570", Offset = "0x4DDF70", VA = "0x1804DF570")]
		public bool TrySendToSeat(GuestGroupController toTry, bool firstSpawn, int targetDeskCode = -1, bool shouldOrder = true)
		{
			return default(bool);
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F2")]
		[Address(RVA = "0x4DE4B0", Offset = "0x4DCEB0", VA = "0x1804DE4B0")]
		private void SpawnGuest(GuestGroupController toTry)
		{
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F3")]
		[Address(RVA = "0x4DAEA0", Offset = "0x4D98A0", VA = "0x1804DAEA0")]
		private void OnGuestSpawnAndCheckRabbitGuest(GuestGroupController guest)
		{
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F4")]
		[Address(RVA = "0x4D8640", Offset = "0x4D7040", VA = "0x1804D8640")]
		public List<Transform> GetRabbitGuest(GuestGroupController guest)
		{
			return null;
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x4DEA70", Offset = "0x4DD470", VA = "0x1804DEA70")]
		private void SpawnNormalGuestGroup()
		{
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F6")]
		[Address(RVA = "0x4DED70", Offset = "0x4DD770", VA = "0x1804DED70")]
		private void SpawnPasserbyGuestGroup()
		{
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F7")]
		[Address(RVA = "0x4DE5F0", Offset = "0x4DCFF0", VA = "0x1804DE5F0")]
		private void SpawnInvitedGuestGroup()
		{
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F8")]
		[Address(RVA = "0x4DEC10", Offset = "0x4DD610", VA = "0x1804DEC10")]
		public NormalGuestsController SpawnNormalGuestGroup(IEnumerable<NormalGuest> normalGuests, [Optional] Vector3? overrideSpawnPosition, GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move, int targetDeskCode = -1, bool shouldFade = true)
		{
			return null;
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F9")]
		[Address(RVA = "0x4DEE80", Offset = "0x4DD880", VA = "0x1804DEE80")]
		public SpecialGuestsController SpawnSpecialGuestGroup(int id, SpecialGuestsController.GuestSpawnType guestSpawnType, [Optional] Vector3? overrideSpawnPosition, [Optional] Action<GuestGroupController> onGuestLeave, GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move, bool recordIzakaya = true, int targetDeskCode = -1, bool tryToJumpQueue = false, [Optional] Action<AStarInputGeneratorComponent> postProcessCharacterCallback, bool shouldFade = true)
		{
			return null;
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FA")]
		[Address(RVA = "0x4DC720", Offset = "0x4DB120", VA = "0x1804DC720")]
		public void RegisteredToIconManager(GuestGroupController controller)
		{
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FB")]
		[Address(RVA = "0x4DC270", Offset = "0x4DAC70", VA = "0x1804DC270")]
		private void PostInitializeGuestGroup(GuestGroupController initializedController, int targetDeskCode = -1, bool tryToJumpQueue = false, bool shouldFade = true)
		{
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FC")]
		[Address(RVA = "0x4DE890", Offset = "0x4DD290", VA = "0x1804DE890")]
		public GuestGroupController SpawnManualControlledSpecialGuestGroup(int id, bool spawnInA, [Optional] Vector3? overrideSpawnPosition, GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move, bool recordIzakaya = true)
		{
			return null;
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FD")]
		[Address(RVA = "0x4DD060", Offset = "0x4DBA60", VA = "0x1804DD060")]
		public void SetManualControlledToSeat(GuestGroupController manualControlled, int guestMood, int deskCode, Action onFinish)
		{
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FE")]
		[Address(RVA = "0x4DD520", Offset = "0x4DBF20", VA = "0x1804DD520")]
		public void SetNormalManualControlledOrder(GuestGroupController manualControlled, int foodId, int bevId, Action<GuestGroupController.EvaluationResult> onEvaluate, [Optional] Sprite hiddenPic)
		{
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020FF")]
		[Address(RVA = "0x4DD690", Offset = "0x4DC090", VA = "0x1804DD690")]
		public void SetSpecialManualControlledOrder(GuestGroupController manualControlled, int foodTag, int bevTag, Action<GuestGroupController.EvaluationResult> onEvaluate, [Optional] Sprite hiddenPic)
		{
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002100")]
		[Address(RVA = "0x4DD1A0", Offset = "0x4DBBA0", VA = "0x1804DD1A0")]
		private void SetManualControllerOrderInternal(GuestGroupController manualControlled, Action<GuestGroupController.EvaluationResult> onEvaluate, GuestsManager.OrderBase order)
		{
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002101")]
		[Address(RVA = "0x4D5400", Offset = "0x4D3E00", VA = "0x1804D5400")]
		public void Dlc4SpecialManualOrder(GuestGroupController guest, Action onServePanelOpenAndEvaluate)
		{
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002102")]
		[Address(RVA = "0x4D5470", Offset = "0x4D3E70", VA = "0x1804D5470")]
		public void EndDlc4SpecialManualOrder(GuestGroupController guest)
		{
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002103")]
		[Address(RVA = "0x4DD8C0", Offset = "0x4DC2C0", VA = "0x1804DD8C0")]
		private void ShowManualOrder(GuestGroupController toShow, Action<GuestGroupController.EvaluationResult> onEvaluate)
		{
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002104")]
		[Address(RVA = "0x4D41B0", Offset = "0x4D2BB0", VA = "0x1804D41B0")]
		public void CleanOrderInfo(GuestGroupController guestGroup)
		{
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002105")]
		[Address(RVA = "0x4DCDD0", Offset = "0x4DB7D0", VA = "0x1804DCDD0")]
		public void SetManualControlledLeave(GuestGroupController manualControlled, bool shouldLeaveInstantly)
		{
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002106")]
		[Address(RVA = "0x4DCFF0", Offset = "0x4DB9F0", VA = "0x1804DCFF0")]
		public void SetManualControlledPatient(GuestGroupController manualControlled, int targetPatient)
		{
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002107")]
		[Address(RVA = "0x4D76E0", Offset = "0x4D60E0", VA = "0x1804D76E0")]
		private void GenerateOrderSession(GuestGroupController guestGroup, bool doContinue)
		{
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002108")]
		[Address(RVA = "0x4D7210", Offset = "0x4D5C10", VA = "0x1804D7210")]
		private void FirstOrder(GuestGroupController first)
		{
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002109")]
		[Address(RVA = "0x4DA200", Offset = "0x4D8C00", VA = "0x1804DA200")]
		private void MainOrderCycle(GuestGroupController toCycle, float accumlateDoContinueProbability)
		{
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210A")]
		[Address(RVA = "0x4DDD30", Offset = "0x4DC730", VA = "0x1804DDD30")]
		private void ShowOrder(GuestGroupController toShow)
		{
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210B")]
		[Address(RVA = "0x4DB600", Offset = "0x4DA000", VA = "0x1804DB600")]
		private void PlayEvaluateSFX(GuestGroupController.EvaluationResult result)
		{
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210C")]
		[Address(RVA = "0x4DB5F0", Offset = "0x4D9FF0", VA = "0x1804DB5F0")]
		public void PlayEvaluateSFXExtern(GuestGroupController.EvaluationResult result)
		{
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210D")]
		[Address(RVA = "0x4D5980", Offset = "0x4D4380", VA = "0x1804D5980")]
		public void EvaluateOrder(GuestGroupController toEvaluate, bool isTriggerByPartner, [Optional] Action onFinishEvaluateCallback)
		{
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600210E")]
		[Address(RVA = "0x4D6700", Offset = "0x4D5100", VA = "0x1804D6700")]
		private void EvaulateManualOrder(GuestGroupController toEvaluate, Action<GuestGroupController.EvaluationResult> onEvaluate)
		{
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x0000C390 File Offset: 0x0000A590
		[Token(Token = "0x600210F")]
		[Address(RVA = "0x4D66D0", Offset = "0x4D50D0", VA = "0x1804D66D0")]
		private GuestGroupController.EvaluationResult EvaluationTrans(int evaluation)
		{
			return GuestGroupController.EvaluationResult.Exbad;
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002110")]
		[Address(RVA = "0x4DF190", Offset = "0x4DDB90", VA = "0x1804DF190")]
		private void StartPassionGenerationSession(float duration, int amount, GuestGroupController toEvaluate)
		{
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002111")]
		[Address(RVA = "0x4D54D0", Offset = "0x4D3ED0", VA = "0x1804D54D0")]
		private void Eval(int firstMood, int moon, float delay, int amount, bool shouldAddCombo, Action<GuestGroupController> onDeleyEndCallback, GuestGroupController toEvaluate)
		{
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002112")]
		[Address(RVA = "0x4DB7A0", Offset = "0x4DA1A0", VA = "0x1804DB7A0")]
		private void PlayGuestEatSFX()
		{
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002113")]
		[Address(RVA = "0x4D9E50", Offset = "0x4D8850", VA = "0x1804D9E50")]
		private void LackMoneyEvaluate(GuestGroupController toEvaluate, bool exceedEndurance)
		{
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002114")]
		[Address(RVA = "0x4D3C70", Offset = "0x4D2670", VA = "0x1804D3C70")]
		private void AddToPatientCountdown(GuestGroupController toCountDown, Action<GuestGroupController> onPatientDepeletedCallback)
		{
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002115")]
		[Address(RVA = "0x4DC780", Offset = "0x4DB180", VA = "0x1804DC780")]
		private void RemoveFromPatientCountdown(GuestGroupController toCountDown)
		{
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002116")]
		[Address(RVA = "0x4E01F0", Offset = "0x4DEBF0", VA = "0x1804E01F0")]
		private void UpdateTick()
		{
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002117")]
		[Address(RVA = "0x4D8860", Offset = "0x4D7260", VA = "0x1804D8860")]
		public List<int> GetSeatable(int guestCount)
		{
			return null;
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002118")]
		[Address(RVA = "0x4D7150", Offset = "0x4D5B50", VA = "0x1804D7150")]
		public void ExecuteDelayed(float offset, Action onDeleyEndCallback, Func<bool> onVertify)
		{
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002119")]
		[Address(RVA = "0x4DB080", Offset = "0x4D9A80", VA = "0x1804DB080", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211A")]
		[Address(RVA = "0x4DF2A0", Offset = "0x4DDCA0", VA = "0x1804DF2A0")]
		public void TryCloseCurrentDialogBox(GuestGroupController toEvaluate)
		{
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211B")]
		[Address(RVA = "0x4D9F50", Offset = "0x4D8950", VA = "0x1804D9F50")]
		private void LeaveFromDesk(GuestGroupController toLeave, GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move, [Optional] Action leaveAction, bool triggerLeaveBuff = true)
		{
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211C")]
		[Address(RVA = "0x4D3ED0", Offset = "0x4D28D0", VA = "0x1804D3ED0")]
		public void CheckAndSendFromQueue()
		{
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211D")]
		[Address(RVA = "0x4DB4C0", Offset = "0x4D9EC0", VA = "0x1804DB4C0")]
		public void PayAndLeave(GuestGroupController toPayAndLeave, bool includeTip)
		{
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211E")]
		[Address(RVA = "0x4D8A50", Offset = "0x4D7450", VA = "0x1804D8A50")]
		public void GuestPay(GuestGroupController toPayAndLeave, bool includeTip)
		{
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600211F")]
		[Address(RVA = "0x4DB820", Offset = "0x4DA220", VA = "0x1804DB820")]
		private void PlayPayAudio()
		{
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002120")]
		[Address(RVA = "0x4DB510", Offset = "0x4D9F10", VA = "0x1804DB510")]
		public void PayByMood(GuestGroupController toPayAndLeave)
		{
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002121")]
		[Address(RVA = "0x4DB2C0", Offset = "0x4D9CC0", VA = "0x1804DB2C0")]
		private void PatientDepletedLeave(GuestGroupController toPatientDepletedLeave)
		{
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002122")]
		[Address(RVA = "0x4D7050", Offset = "0x4D5A50", VA = "0x1804D7050")]
		private void ExBadLeave(GuestGroupController toExBadLeave)
		{
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002123")]
		[Address(RVA = "0x4DC990", Offset = "0x4DB390", VA = "0x1804DC990")]
		public void RepellAndLeavePay(GuestGroupController toRepell, GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move, bool triggerBuff = true)
		{
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002124")]
		[Address(RVA = "0x4DC960", Offset = "0x4DB360", VA = "0x1804DC960")]
		public void RepellAndLeaveNoPay(GuestGroupController toRepell, GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move, bool triggerBuff = true)
		{
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002125")]
		[Address(RVA = "0x4DB8B0", Offset = "0x4DA2B0", VA = "0x1804DB8B0")]
		public void PlayerRepell(int deskCode)
		{
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002126")]
		[Address(RVA = "0x4D7430", Offset = "0x4D5E30", VA = "0x1804D7430")]
		public void FlyCharaRepell(GuestGroupController toRepell)
		{
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002127")]
		[Address(RVA = "0x4DCAB0", Offset = "0x4DB4B0", VA = "0x1804DCAB0")]
		private void RepellInternal(GuestGroupController guestGroupController, out bool haveSeated, GuestGroupController.LeaveType leaveType = GuestGroupController.LeaveType.Move, bool triggerLeaveBuff = true)
		{
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002128")]
		[Address(RVA = "0x4D4260", Offset = "0x4D2C60", VA = "0x1804D4260", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002129")]
		[Address(RVA = "0x4E0440", Offset = "0x4DEE40", VA = "0x1804E0440")]
		public GuestsManager()
		{
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600212D")]
		[Address(RVA = "0x4DFAA0", Offset = "0x4DE4A0", VA = "0x1804DFAA0")]
		[CompilerGenerated]
		internal static void <CloseIzakayaDelayed>g__AchievementJudgement|128_1()
		{
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002131")]
		[Address(RVA = "0x4DFF00", Offset = "0x4DE900", VA = "0x1804DFF00")]
		[CompilerGenerated]
		private void <PostInitializeGuestGroup>g__OnMoveFinish|159_1(GuestGroupController groupController)
		{
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002132")]
		[Address(RVA = "0x4DFFB0", Offset = "0x4DE9B0", VA = "0x1804DFFB0")]
		[CompilerGenerated]
		private void <PostInitializeGuestGroup>g__OnPatiendDepleted|159_2(GuestGroupController guest)
		{
		}

		// Token: 0x04001DB5 RID: 7605
		[Token(Token = "0x4001DB5")]
		private const int GUEST_INITIAL_MOOD_MIN = 30;

		// Token: 0x04001DB6 RID: 7606
		[Token(Token = "0x4001DB6")]
		private const int GUEST_INITIAL_MOOD_MAX = 50;

		// Token: 0x04001DB7 RID: 7607
		[Token(Token = "0x4001DB7")]
		private const float FIRSTORDER_DELAY_TIME = 10f;

		// Token: 0x04001DB8 RID: 7608
		[Token(Token = "0x4001DB8")]
		private const float STATE_ICON_OFFSET = 1.5f;

		// Token: 0x04001DB9 RID: 7609
		[Token(Token = "0x4001DB9")]
		private const int ON_GUEST_START_PROVIDE_PASSION_MOOD = 30;

		// Token: 0x04001DBA RID: 7610
		[Token(Token = "0x4001DBA")]
		private const int TOTAL_NORMAL_PASSION_GENERATE_AMOUNT = 4;

		// Token: 0x04001DBB RID: 7611
		[Token(Token = "0x4001DBB")]
		private const int TOTAL_BAD_PASSION_GENERATE_AMOUNT = 2;

		// Token: 0x04001DBC RID: 7612
		[Token(Token = "0x4001DBC")]
		private const int ON_GUEST_BAD_LEAVE_PASSION_PUNISHMENT = 15;

		// Token: 0x04001DBD RID: 7613
		[Token(Token = "0x4001DBD")]
		private const float DELAY_EVALUATE_TIME = 1.5f;

		// Token: 0x04001DBE RID: 7614
		[Token(Token = "0x4001DBE")]
		private const float BAD_MOOD_EXP = 1f;

		// Token: 0x04001DBF RID: 7615
		[Token(Token = "0x4001DBF")]
		private const float NORMAL_MOOD_EXP = 1.2f;

		// Token: 0x04001DC0 RID: 7616
		[Token(Token = "0x4001DC0")]
		private const float GOOD_MOOD_EXP = 1.5f;

		// Token: 0x04001DC1 RID: 7617
		[Token(Token = "0x4001DC1")]
		private const float EXGOOD_MOOD_EXP = 2f;

		// Token: 0x04001DC2 RID: 7618
		[Token(Token = "0x4001DC2")]
		private const int MEDICINE_SPECIAL_FOOD_TAG = 4000;

		// Token: 0x04001DC3 RID: 7619
		[Token(Token = "0x4001DC3")]
		private const int MEDICINE_SPECIAL_MILK_TAG = 24;

		// Token: 0x04001DC4 RID: 7620
		[Token(Token = "0x4001DC4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] evaulate;

		// Token: 0x04001DC5 RID: 7621
		[Token(Token = "0x4001DC5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip order;

		// Token: 0x04001DC6 RID: 7622
		[Token(Token = "0x4001DC6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip pay;

		// Token: 0x04001DC7 RID: 7623
		[Token(Token = "0x4001DC7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip timeEnd;

		// Token: 0x04001DC8 RID: 7624
		[Token(Token = "0x4001DC8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Icon")]
		public Canvas uiContainer;

		// Token: 0x04001DC9 RID: 7625
		[Token(Token = "0x4001DC9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject Await;

		// Token: 0x04001DCA RID: 7626
		[Token(Token = "0x4001DCA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject Eat;

		// Token: 0x04001DCB RID: 7627
		[Token(Token = "0x4001DCB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject serveInWorkMissionIcon;

		// Token: 0x04001DCC RID: 7628
		[Token(Token = "0x4001DCC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject hateFoodTagIcon;

		// Token: 0x04001DCD RID: 7629
		[Token(Token = "0x4001DCD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioClip hateFoodTagAudio;

		// Token: 0x04001DCE RID: 7630
		[Token(Token = "0x4001DCE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Space(10f)]
		public AudioClip[] eatSFX;

		// Token: 0x04001DCF RID: 7631
		[Token(Token = "0x4001DCF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioClip[] glassSFX;

		// Token: 0x04001DD0 RID: 7632
		[Token(Token = "0x4001DD0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Func<Action<AStarInputGeneratorComponent>> getPostprocessCharacterCallback;

		// Token: 0x04001DD1 RID: 7633
		[Token(Token = "0x4001DD1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<GuestGroupController, Action> currentDisplayedDialogBox;

		// Token: 0x04001DD2 RID: 7634
		[Token(Token = "0x4001DD2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Dictionary<int, int> allDesks;

		// Token: 0x04001DD3 RID: 7635
		[Token(Token = "0x4001DD3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GuestIconManager guestIconManager;

		// Token: 0x04001DD4 RID: 7636
		[Token(Token = "0x4001DD4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool isIzakayaClosing;

		// Token: 0x04001DD5 RID: 7637
		[Token(Token = "0x4001DD5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int largestDesk;

		// Token: 0x04001DD6 RID: 7638
		[Token(Token = "0x4001DD6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<int> occupiedDesks;

		// Token: 0x04001DD7 RID: 7639
		[Token(Token = "0x4001DD7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private KeyValuePair<GuestGroupController, Action>? onForcePannelClosingWhenGuestRepellCallback;

		// Token: 0x04001DD8 RID: 7640
		[Token(Token = "0x4001DD8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Action<GuestsManager.OrderBase> onOrderAdd;

		// Token: 0x04001DD9 RID: 7641
		[Token(Token = "0x4001DD9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Action<GuestsManager.OrderBase> onOrderRemove;

		// Token: 0x04001DDA RID: 7642
		[Token(Token = "0x4001DDA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Dictionary<int, Action> registeredCharacterArrivedEvents;

		// Token: 0x04001DDB RID: 7643
		[Token(Token = "0x4001DDB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Dictionary<GuestGroupController, GuestsManager.TimedEvent> timed;

		// Token: 0x04001DDC RID: 7644
		[Token(Token = "0x4001DDC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public readonly HashSet<GuestGroupController> AllPresentedGuestGroupController;

		// Token: 0x04001DEA RID: 7658
		[Token(Token = "0x4001DEA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public int ForceDialogDeskCode;

		// Token: 0x04001DEB RID: 7659
		[Token(Token = "0x4001DEB")]
		private const int TEWI_ID = 29;

		// Token: 0x04001DEC RID: 7660
		[Token(Token = "0x4001DEC")]
		private const int TEWI_ID_2 = 16;

		// Token: 0x04001DED RID: 7661
		[Token(Token = "0x4001DED")]
		private const int REISEN2_ID = 5000;

		// Token: 0x04001DEE RID: 7662
		[Token(Token = "0x4001DEE")]
		private const int YOUKAI_RABBIT = 0;

		// Token: 0x04001DEF RID: 7663
		[Token(Token = "0x4001DEF")]
		private const int MOON_RABBIT = 5004;

		// Token: 0x04001DF0 RID: 7664
		[Token(Token = "0x4001DF0")]
		private const int MOON_RABBIT_2 = 5005;

		// Token: 0x04001DF1 RID: 7665
		[Token(Token = "0x4001DF1")]
		private const int GUEST_BASE_EXP = 10;

		// Token: 0x04001DF2 RID: 7666
		[Token(Token = "0x4001DF2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public Action<int, Action> KisumeRepellCallback;

		// Token: 0x02000596 RID: 1430
		[Token(Token = "0x2000596")]
		public enum GuestType
		{
			// Token: 0x04001DF4 RID: 7668
			[Token(Token = "0x4001DF4")]
			Normal,
			// Token: 0x04001DF5 RID: 7669
			[Token(Token = "0x4001DF5")]
			Special
		}

		// Token: 0x02000597 RID: 1431
		[Token(Token = "0x2000597")]
		public enum IzakayaCloseType
		{
			// Token: 0x04001DF7 RID: 7671
			[Token(Token = "0x4001DF7")]
			General,
			// Token: 0x04001DF8 RID: 7672
			[Token(Token = "0x4001DF8")]
			Challenge,
			// Token: 0x04001DF9 RID: 7673
			[Token(Token = "0x4001DF9")]
			Tutorial
		}

		// Token: 0x02000598 RID: 1432
		[Token(Token = "0x2000598")]
		private class TimedEvent
		{
			// Token: 0x06002134 RID: 8500 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002134")]
			[Address(RVA = "0x51E6D0", Offset = "0x51D0D0", VA = "0x18051E6D0")]
			public TimedEvent(int time, Action onTimingUpdatedCallback, Action onTimingEndCallback)
			{
			}

			// Token: 0x06002135 RID: 8501 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
			[Token(Token = "0x6002135")]
			[Address(RVA = "0x51E680", Offset = "0x51D080", VA = "0x18051E680")]
			public bool UpdateTime()
			{
				return default(bool);
			}

			// Token: 0x04001DFA RID: 7674
			[Token(Token = "0x4001DFA")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Action onTimingEndCallback;

			// Token: 0x04001DFB RID: 7675
			[Token(Token = "0x4001DFB")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly Action onTimingUpdatedCallback;

			// Token: 0x04001DFC RID: 7676
			[Token(Token = "0x4001DFC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int time;
		}

		// Token: 0x02000599 RID: 1433
		[Token(Token = "0x2000599")]
		private enum OrderGenerationResult
		{
			// Token: 0x04001DFE RID: 7678
			[Token(Token = "0x4001DFE")]
			Succeed,
			// Token: 0x04001DFF RID: 7679
			[Token(Token = "0x4001DFF")]
			OrderCountDepleted,
			// Token: 0x04001E00 RID: 7680
			[Token(Token = "0x4001E00")]
			NoMoney,
			// Token: 0x04001E01 RID: 7681
			[Token(Token = "0x4001E01")]
			ExceedEndurance,
			// Token: 0x04001E02 RID: 7682
			[Token(Token = "0x4001E02")]
			NotContinue
		}

		// Token: 0x0200059A RID: 1434
		[Token(Token = "0x200059A")]
		public class OrderBase
		{
			// Token: 0x06002136 RID: 8502 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002136")]
			[Address(RVA = "0x51B010", Offset = "0x519A10", VA = "0x18051B010")]
			public OrderBase(GuestsManager.OrderBase.OrderType orderType, int requestFood, int requestBev, int deskCode, bool notShowInUI, bool freeOrder, [Optional] Sprite hiddenPic)
			{
			}

			// Token: 0x17000475 RID: 1141
			// (get) Token: 0x06002137 RID: 8503 RVA: 0x0000C408 File Offset: 0x0000A608
			[Token(Token = "0x17000475")]
			public GuestsManager.OrderBase.OrderType Type
			{
				[Token(Token = "0x6002137")]
				[Address(RVA = "0x440570", Offset = "0x43EF70", VA = "0x180440570")]
				[CompilerGenerated]
				get
				{
					return GuestsManager.OrderBase.OrderType.Normal;
				}
			}

			// Token: 0x17000476 RID: 1142
			// (get) Token: 0x06002138 RID: 8504 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002139 RID: 8505 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000476")]
			public Sellable ServFood
			{
				[Token(Token = "0x6002138")]
				[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002139")]
				[Address(RVA = "0x51B200", Offset = "0x519C00", VA = "0x18051B200")]
				set
				{
				}
			}

			// Token: 0x17000477 RID: 1143
			// (get) Token: 0x0600213A RID: 8506 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600213B RID: 8507 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000477")]
			public Sellable ServBeverage
			{
				[Token(Token = "0x600213A")]
				[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
				get
				{
					return null;
				}
				[Token(Token = "0x600213B")]
				[Address(RVA = "0x51B190", Offset = "0x519B90", VA = "0x18051B190")]
				set
				{
				}
			}

			// Token: 0x17000478 RID: 1144
			// (get) Token: 0x0600213C RID: 8508 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600213D RID: 8509 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000478")]
			public Action<bool, bool> OnUpdateServeDataVisualCallback
			{
				[Token(Token = "0x600213C")]
				[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x600213D")]
				[Address(RVA = "0x51B180", Offset = "0x519B80", VA = "0x18051B180")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000479 RID: 1145
			// (get) Token: 0x0600213E RID: 8510 RVA: 0x0000C420 File Offset: 0x0000A620
			[Token(Token = "0x17000479")]
			public int Price
			{
				[Token(Token = "0x600213E")]
				[Address(RVA = "0x51B0E0", Offset = "0x519AE0", VA = "0x18051B0E0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700047A RID: 1146
			// (get) Token: 0x0600213F RID: 8511 RVA: 0x0000C438 File Offset: 0x0000A638
			[Token(Token = "0x1700047A")]
			public int DeskCode
			{
				[Token(Token = "0x600213F")]
				[Address(RVA = "0x51B080", Offset = "0x519A80", VA = "0x18051B080")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700047B RID: 1147
			// (get) Token: 0x06002140 RID: 8512 RVA: 0x0000C450 File Offset: 0x0000A650
			[Token(Token = "0x1700047B")]
			public bool IsFullfilled
			{
				[Token(Token = "0x6002140")]
				[Address(RVA = "0x51B0A0", Offset = "0x519AA0", VA = "0x18051B0A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700047C RID: 1148
			// (get) Token: 0x06002141 RID: 8513 RVA: 0x0000C468 File Offset: 0x0000A668
			// (set) Token: 0x06002142 RID: 8514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700047C")]
			public bool ManualOrder
			{
				[Token(Token = "0x6002141")]
				[Address(RVA = "0x51B0C0", Offset = "0x519AC0", VA = "0x18051B0C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002142")]
				[Address(RVA = "0x51B170", Offset = "0x519B70", VA = "0x18051B170")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700047D RID: 1149
			// (get) Token: 0x06002143 RID: 8515 RVA: 0x0000C480 File Offset: 0x0000A680
			// (set) Token: 0x06002144 RID: 8516 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700047D")]
			public bool FreeOrder
			{
				[Token(Token = "0x6002143")]
				[Address(RVA = "0x51B090", Offset = "0x519A90", VA = "0x18051B090")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002144")]
				[Address(RVA = "0x51B150", Offset = "0x519B50", VA = "0x18051B150")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700047E RID: 1150
			// (get) Token: 0x06002145 RID: 8517 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002146 RID: 8518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700047E")]
			public Sellable ServedFoodInAir
			{
				[Token(Token = "0x6002145")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002146")]
				[Address(RVA = "0x51B2E0", Offset = "0x519CE0", VA = "0x18051B2E0")]
				set
				{
				}
			}

			// Token: 0x1700047F RID: 1151
			// (get) Token: 0x06002147 RID: 8519 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002148 RID: 8520 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700047F")]
			public Sellable ServedBeverageInAir
			{
				[Token(Token = "0x6002147")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				get
				{
					return null;
				}
				[Token(Token = "0x6002148")]
				[Address(RVA = "0x51B270", Offset = "0x519C70", VA = "0x18051B270")]
				set
				{
				}
			}

			// Token: 0x17000480 RID: 1152
			// (get) Token: 0x06002149 RID: 8521 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600214A RID: 8522 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000480")]
			public Sprite HiddenPic
			{
				[Token(Token = "0x6002149")]
				[Address(RVA = "0x440270", Offset = "0x43EC70", VA = "0x180440270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600214A")]
				[Address(RVA = "0x51B160", Offset = "0x519B60", VA = "0x18051B160")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000481 RID: 1153
			// (get) Token: 0x0600214B RID: 8523 RVA: 0x0000C498 File Offset: 0x0000A698
			// (set) Token: 0x0600214C RID: 8524 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000481")]
			public GuestsManager.OrderBase.SenderType FoodSender
			{
				[Token(Token = "0x600214B")]
				[Address(RVA = "0x48A760", Offset = "0x489160", VA = "0x18048A760")]
				[CompilerGenerated]
				get
				{
					return GuestsManager.OrderBase.SenderType.Self;
				}
				[Token(Token = "0x600214C")]
				[Address(RVA = "0x51B140", Offset = "0x519B40", VA = "0x18051B140")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000482 RID: 1154
			// (get) Token: 0x0600214D RID: 8525 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
			// (set) Token: 0x0600214E RID: 8526 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000482")]
			public GuestsManager.OrderBase.SenderType BevSender
			{
				[Token(Token = "0x600214D")]
				[Address(RVA = "0x48A640", Offset = "0x489040", VA = "0x18048A640")]
				[CompilerGenerated]
				get
				{
					return GuestsManager.OrderBase.SenderType.Self;
				}
				[Token(Token = "0x600214E")]
				[Address(RVA = "0x486940", Offset = "0x485340", VA = "0x180486940")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000483 RID: 1155
			// (get) Token: 0x0600214F RID: 8527 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
			[Token(Token = "0x17000483")]
			public bool NotShowInUI
			{
				[Token(Token = "0x600214F")]
				[Address(RVA = "0x51B0D0", Offset = "0x519AD0", VA = "0x18051B0D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06002150 RID: 8528 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002150")]
			[Address(RVA = "0x51AAE0", Offset = "0x5194E0", VA = "0x18051AAE0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04001E03 RID: 7683
			[Token(Token = "0x4001E03")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			protected int beverageRequest;

			// Token: 0x04001E04 RID: 7684
			[Token(Token = "0x4001E04")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			protected int foodRequest;

			// Token: 0x04001E05 RID: 7685
			[Token(Token = "0x4001E05")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Sellable m_ServedBeverageInAir;

			// Token: 0x04001E06 RID: 7686
			[Token(Token = "0x4001E06")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Sellable m_ServedFoodInAir;

			// Token: 0x04001E07 RID: 7687
			[Token(Token = "0x4001E07")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Sellable servBeverage;

			// Token: 0x04001E08 RID: 7688
			[Token(Token = "0x4001E08")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Sellable servFood;

			// Token: 0x0200059B RID: 1435
			[Token(Token = "0x200059B")]
			public enum OrderType
			{
				// Token: 0x04001E13 RID: 7699
				[Token(Token = "0x4001E13")]
				Normal,
				// Token: 0x04001E14 RID: 7700
				[Token(Token = "0x4001E14")]
				Special
			}

			// Token: 0x0200059C RID: 1436
			[Token(Token = "0x200059C")]
			public enum SenderType
			{
				// Token: 0x04001E16 RID: 7702
				[Token(Token = "0x4001E16")]
				Self,
				// Token: 0x04001E17 RID: 7703
				[Token(Token = "0x4001E17")]
				Partner,
				// Token: 0x04001E18 RID: 7704
				[Token(Token = "0x4001E18")]
				Boss
			}
		}

		// Token: 0x0200059D RID: 1437
		[Token(Token = "0x200059D")]
		public class NormalOrder : GuestsManager.OrderBase
		{
			// Token: 0x06002151 RID: 8529 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002151")]
			[Address(RVA = "0x51AA20", Offset = "0x519420", VA = "0x18051AA20")]
			public NormalOrder(GuestBase guest, int requestFoodId, int requestBevId, int deskCode, bool notShowInUI, bool isFree, [Optional] Sprite hiddenPic)
			{
			}

			// Token: 0x17000484 RID: 1156
			// (get) Token: 0x06002152 RID: 8530 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002153 RID: 8531 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000484")]
			public GuestBase Guest
			{
				[Token(Token = "0x6002152")]
				[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6002153")]
				[Address(RVA = "0x51AAD0", Offset = "0x5194D0", VA = "0x18051AAD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000485 RID: 1157
			// (get) Token: 0x06002154 RID: 8532 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000485")]
			public Sellable RequestFood
			{
				[Token(Token = "0x6002154")]
				[Address(RVA = "0x51AAC0", Offset = "0x5194C0", VA = "0x18051AAC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000486 RID: 1158
			// (get) Token: 0x06002155 RID: 8533 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000486")]
			public Sellable RequestBeverage
			{
				[Token(Token = "0x6002155")]
				[Address(RVA = "0x51AAB0", Offset = "0x5194B0", VA = "0x18051AAB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002156 RID: 8534 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002156")]
			[Address(RVA = "0x51A6B0", Offset = "0x5190B0", VA = "0x18051A6B0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		// Token: 0x0200059E RID: 1438
		[Token(Token = "0x200059E")]
		public class SpecialOrder : GuestsManager.OrderBase
		{
			// Token: 0x06002157 RID: 8535 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002157")]
			[Address(RVA = "0x51E5F0", Offset = "0x51CFF0", VA = "0x18051E5F0")]
			public SpecialOrder(SpecialGuest specialGuests, int requestFoodTag, int requestBevTag, int deskCode, bool notShowInUI, bool isFree, [Optional] Sprite hiddenPic)
			{
			}

			// Token: 0x17000487 RID: 1159
			// (get) Token: 0x06002158 RID: 8536 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
			[Token(Token = "0x17000487")]
			public int RequestFoodTag
			{
				[Token(Token = "0x6002158")]
				[Address(RVA = "0x403840", Offset = "0x402240", VA = "0x180403840")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000488 RID: 1160
			// (get) Token: 0x06002159 RID: 8537 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
			[Token(Token = "0x17000488")]
			public int RequestBeverageTag
			{
				[Token(Token = "0x6002159")]
				[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000489 RID: 1161
			// (get) Token: 0x0600215A RID: 8538 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000489")]
			public SpecialGuest SpecialGuests
			{
				[Token(Token = "0x600215A")]
				[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x0600215B RID: 8539 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600215B")]
			[Address(RVA = "0x51E2E0", Offset = "0x51CCE0", VA = "0x18051E2E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		// Token: 0x0200059F RID: 1439
		[Token(Token = "0x200059F")]
		public class OrderProperty
		{
			// Token: 0x0600215C RID: 8540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600215C")]
			[Address(RVA = "0x51B5E0", Offset = "0x519FE0", VA = "0x18051B5E0")]
			public OrderProperty(GuestsManager.OrderProperty.OrderSource source, string sourceLabel, bool isFree)
			{
			}

			// Token: 0x1700048A RID: 1162
			// (get) Token: 0x0600215D RID: 8541 RVA: 0x0000C510 File Offset: 0x0000A710
			// (set) Token: 0x0600215E RID: 8542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700048A")]
			public bool IsFree
			{
				[Token(Token = "0x600215D")]
				[Address(RVA = "0x51B640", Offset = "0x51A040", VA = "0x18051B640")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600215E")]
				[Address(RVA = "0x51B650", Offset = "0x51A050", VA = "0x18051B650")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600215F RID: 8543 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600215F")]
			[Address(RVA = "0x51B350", Offset = "0x519D50", VA = "0x18051B350", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04001E1B RID: 7707
			[Token(Token = "0x4001E1B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GuestsManager.OrderProperty.OrderSource Source;

			// Token: 0x04001E1C RID: 7708
			[Token(Token = "0x4001E1C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string SourceLabel;

			// Token: 0x020005A0 RID: 1440
			[Token(Token = "0x20005A0")]
			public enum OrderSource
			{
				// Token: 0x04001E1F RID: 7711
				[Token(Token = "0x4001E1F")]
				Base,
				// Token: 0x04001E20 RID: 7712
				[Token(Token = "0x4001E20")]
				Extra
			}
		}
	}
}

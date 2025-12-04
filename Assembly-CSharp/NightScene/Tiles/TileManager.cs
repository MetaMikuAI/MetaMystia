using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DayScene.Input;
using DEYU.Singletons;
using DEYU.UniversalUISystem;
using DEYU.Utils;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace NightScene.Tiles
{
	// Token: 0x02000680 RID: 1664
	[Token(Token = "0x2000680")]
	[GenerateCleanupMethod]
	public class TileManager : MonoSingleton<TileManager>
	{
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06002704 RID: 9988 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002705 RID: 9989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700056F")]
		public Grid LayoutGrid
		{
			[Token(Token = "0x6002704")]
			[Address(RVA = "0x426F70", Offset = "0x425970", VA = "0x180426F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002705")]
			[Address(RVA = "0x52F180", Offset = "0x52DB80", VA = "0x18052F180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000570")]
		public ICollection<int> ThrowDeliverExclusion
		{
			[Token(Token = "0x6002706")]
			[Address(RVA = "0x4BE490", Offset = "0x4BCE90", VA = "0x1804BE490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002708 RID: 9992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000571")]
		public Vector3Int[] CookerDesks
		{
			[Token(Token = "0x6002707")]
			[Address(RVA = "0x48B890", Offset = "0x48A290", VA = "0x18048B890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002708")]
			[Address(RVA = "0x4D2550", Offset = "0x4D0F50", VA = "0x1804D2550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600270A RID: 9994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000572")]
		public Vector3Int[] FoodStorage
		{
			[Token(Token = "0x6002709")]
			[Address(RVA = "0x428D60", Offset = "0x427760", VA = "0x180428D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600270A")]
			[Address(RVA = "0x4D2530", Offset = "0x4D0F30", VA = "0x1804D2530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000573")]
		public Vector3Int[] BeverageStorage
		{
			[Token(Token = "0x600270B")]
			[Address(RVA = "0x48A8D0", Offset = "0x4892D0", VA = "0x18048A8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600270C")]
			[Address(RVA = "0x48AC50", Offset = "0x489650", VA = "0x18048AC50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000574")]
		public Vector3Int[] FoodStorageBoss
		{
			[Token(Token = "0x600270D")]
			[Address(RVA = "0x48A680", Offset = "0x489080", VA = "0x18048A680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600270E")]
			[Address(RVA = "0x4D24D0", Offset = "0x4D0ED0", VA = "0x1804D24D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002710 RID: 10000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000575")]
		public Vector3Int[] BeverageStorageBoss
		{
			[Token(Token = "0x600270F")]
			[Address(RVA = "0x48A7A0", Offset = "0x4891A0", VA = "0x18048A7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002710")]
			[Address(RVA = "0x4D2570", Offset = "0x4D0F70", VA = "0x1804D2570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002712 RID: 10002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000576")]
		public Vector3Int[] GuestSpawnA
		{
			[Token(Token = "0x6002711")]
			[Address(RVA = "0x48A4C0", Offset = "0x488EC0", VA = "0x18048A4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002712")]
			[Address(RVA = "0x4D2590", Offset = "0x4D0F90", VA = "0x1804D2590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06002713 RID: 10003 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002714 RID: 10004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000577")]
		public Vector3Int[] GuestSpawnB
		{
			[Token(Token = "0x6002713")]
			[Address(RVA = "0x449340", Offset = "0x447D40", VA = "0x180449340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002714")]
			[Address(RVA = "0x48AA80", Offset = "0x489480", VA = "0x18048AA80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x0000E808 File Offset: 0x0000CA08
		// (set) Token: 0x06002716 RID: 10006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000578")]
		public Vector3Int PlayerSpawn
		{
			[Token(Token = "0x6002715")]
			[Address(RVA = "0x536FC0", Offset = "0x5359C0", VA = "0x180536FC0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3Int);
			}
			[Token(Token = "0x6002716")]
			[Address(RVA = "0x537060", Offset = "0x535A60", VA = "0x180537060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06002717 RID: 10007 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002718 RID: 10008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000579")]
		public Vector3Int[] PasserBorder
		{
			[Token(Token = "0x6002717")]
			[Address(RVA = "0x4D1EB0", Offset = "0x4D08B0", VA = "0x1804D1EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002718")]
			[Address(RVA = "0x4D25B0", Offset = "0x4D0FB0", VA = "0x1804D25B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06002719 RID: 10009 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600271A RID: 10010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057A")]
		public Vector3Int[] AIdle
		{
			[Token(Token = "0x6002719")]
			[Address(RVA = "0x4D1EE0", Offset = "0x4D08E0", VA = "0x1804D1EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600271A")]
			[Address(RVA = "0x4D2630", Offset = "0x4D1030", VA = "0x1804D2630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x0600271B RID: 10011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057B")]
		public IEnumerable<Vector2Int> Rabbit
		{
			[Token(Token = "0x600271B")]
			[Address(RVA = "0x536FE0", Offset = "0x5359E0", VA = "0x180536FE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600271D RID: 10013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700057C")]
		public ValueTuple<Vector3Int, DayScenePlayerInputGenerator.CharacterRotation>[] WaitSeats
		{
			[Token(Token = "0x600271C")]
			[Address(RVA = "0x4D1EA0", Offset = "0x4D08A0", VA = "0x1804D1EA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600271D")]
			[Address(RVA = "0x4D2510", Offset = "0x4D0F10", VA = "0x1804D2510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600271E RID: 10014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700057D")]
		public Dictionary<int, TileManager.GuestTableData> GuestTables
		{
			[Token(Token = "0x600271E")]
			[Address(RVA = "0x4D1ED0", Offset = "0x4D08D0", VA = "0x1804D1ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600271F")]
		[Address(RVA = "0x535C00", Offset = "0x534600", VA = "0x180535C00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x0000E820 File Offset: 0x0000CA20
		[Token(Token = "0x6002720")]
		[Address(RVA = "0x533460", Offset = "0x531E60", VA = "0x180533460")]
		public Vector3 GetInteractablesCenter(InteractableTile.TileType tileType)
		{
			return default(Vector3);
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002721")]
		[Address(RVA = "0x532BD0", Offset = "0x5315D0", VA = "0x180532BD0")]
		public InteractableTile GetCustomerDesk(int deskCode, out Vector3Int position)
		{
			return null;
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x0000E838 File Offset: 0x0000CA38
		[Token(Token = "0x6002722")]
		[Address(RVA = "0x5323A0", Offset = "0x530DA0", VA = "0x1805323A0")]
		public Vector3 GetCellCenterWorld(Vector3Int cellPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x0000E850 File Offset: 0x0000CA50
		[Token(Token = "0x6002723")]
		[Address(RVA = "0x5328C0", Offset = "0x5312C0", VA = "0x1805328C0")]
		public UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int> GetCollider(Vector3Int colliderExclusion, IReadOnlyList<Vector3Int> appendColliderExclusion)
		{
			return default(UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int>);
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x0000E868 File Offset: 0x0000CA68
		[Token(Token = "0x6002724")]
		[Address(RVA = "0x532400", Offset = "0x530E00", VA = "0x180532400")]
		public UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int> GetCollider(IReadOnlyList<Vector3Int> colliderExclusion, [Optional] IReadOnlyList<Vector3Int> appendColliderExclusion)
		{
			return default(UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int>);
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002725")]
		[Address(RVA = "0x531EB0", Offset = "0x5308B0", VA = "0x180531EB0")]
		private void AddToColliders(Vector3Int collider)
		{
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002726")]
		[Address(RVA = "0x5336D0", Offset = "0x5320D0", VA = "0x1805336D0")]
		public void Initialize()
		{
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002727")]
		[Address(RVA = "0x536C60", Offset = "0x535660", VA = "0x180536C60")]
		private void UpdateInputAvailability(bool enabled)
		{
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002728")]
		[Address(RVA = "0x536360", Offset = "0x534D60", VA = "0x180536360")]
		public void UpdateCurser(Vector3Int? requestedPosition)
		{
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002729")]
		[Address(RVA = "0x535E20", Offset = "0x534820", VA = "0x180535E20")]
		private void ShowPainter(Vector3 coordinate, Sprite visual)
		{
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600272A")]
		[Address(RVA = "0x5334E0", Offset = "0x531EE0", VA = "0x1805334E0")]
		private void HidePainter(Vector3 coordinate)
		{
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x0000E880 File Offset: 0x0000CA80
		[Token(Token = "0x600272B")]
		[Address(RVA = "0x535CA0", Offset = "0x5346A0", VA = "0x180535CA0")]
		public Vector3Int RemapPosition(Vector3Int position, out InteractableTile.TileType clickType)
		{
			return default(Vector3Int);
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x0000E898 File Offset: 0x0000CA98
		[Token(Token = "0x600272C")]
		[Address(RVA = "0x533380", Offset = "0x531D80", VA = "0x180533380")]
		public InteractableTile.TileType GetInteractableType(Vector3Int position, out InteractableTile atPos)
		{
			return InteractableTile.TileType.CookDesk;
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		[Token(Token = "0x600272D")]
		[Address(RVA = "0x532CB0", Offset = "0x5316B0", VA = "0x180532CB0")]
		private static Vector3Int GetDirection(int direction)
		{
			return default(Vector3Int);
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		[Token(Token = "0x600272E")]
		[Address(RVA = "0x5321D0", Offset = "0x530BD0", VA = "0x1805321D0")]
		public static int FindDirection(Vector3 self, Vector3 towards)
		{
			return 0;
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600272F")]
		[Address(RVA = "0x533020", Offset = "0x531A20", VA = "0x180533020")]
		private Vector3Int[] GetGuestSeats(Vector3Int deskCord)
		{
			return null;
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x0000E8E0 File Offset: 0x0000CAE0
		[Token(Token = "0x6002730")]
		[Address(RVA = "0x532D10", Offset = "0x531710", VA = "0x180532D10")]
		private Vector3Int GetGuestDesk(Vector3Int seatCord)
		{
			return default(Vector3Int);
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002731")]
		[Address(RVA = "0x531F30", Offset = "0x530930", VA = "0x180531F30", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002732")]
		[Address(RVA = "0x536C80", Offset = "0x535680", VA = "0x180536C80")]
		public TileManager()
		{
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x0000E8F8 File Offset: 0x0000CAF8
		[Token(Token = "0x6002733")]
		[Address(RVA = "0x5360F0", Offset = "0x534AF0", VA = "0x1805360F0")]
		[CompilerGenerated]
		internal static Vector3 <Initialize>g__SolveCenter|80_0(IEnumerable<Vector3Int> locations)
		{
			return default(Vector3);
		}

		// Token: 0x040023AE RID: 9134
		[Token(Token = "0x40023AE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UIElementCluster onSelection;

		// Token: 0x040023AF RID: 9135
		[Token(Token = "0x40023AF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject stencilPainterParent;

		// Token: 0x040023B0 RID: 9136
		[Token(Token = "0x40023B0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform stencilPainterField;

		// Token: 0x040023B1 RID: 9137
		[Token(Token = "0x40023B1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<Vector3, StencilPainterController> activePainter;

		// Token: 0x040023B2 RID: 9138
		[Token(Token = "0x40023B2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[TupleElementNames(new string[] { "TileReference", "TilePosition" })]
		private readonly Dictionary<int, ValueTuple<InteractableTile, Vector3Int>> allGuestTables;

		// Token: 0x040023B3 RID: 9139
		[Token(Token = "0x40023B3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Queue<StencilPainterController> idlePainter;

		// Token: 0x040023B4 RID: 9140
		[Token(Token = "0x40023B4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly Dictionary<InteractableTile.TileType, Vector3> interactablesCenter;

		// Token: 0x040023B5 RID: 9141
		[Token(Token = "0x40023B5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Dictionary<Sprite, Sprite> interactablesHighlightedVisual;

		// Token: 0x040023B6 RID: 9142
		[Token(Token = "0x40023B6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public HashSet<Vector2Int> AllAvailableAreas;

		// Token: 0x040023B7 RID: 9143
		[Token(Token = "0x40023B7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private HashSet<Vector2Int> allColliders;

		// Token: 0x040023B8 RID: 9144
		[Token(Token = "0x40023B8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private HashSet<Vector2Int> rayBorder;

		// Token: 0x040023B9 RID: 9145
		[Token(Token = "0x40023B9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Tilemap interactable;

		// Token: 0x040023BA RID: 9146
		[Token(Token = "0x40023BA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Tilemap collidable;

		// Token: 0x040023BB RID: 9147
		[Token(Token = "0x40023BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Tilemap inOutDoor;

		// Token: 0x040023BC RID: 9148
		[Token(Token = "0x40023BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Tilemap rayCollider;

		// Token: 0x040023BD RID: 9149
		[Token(Token = "0x40023BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPainterBuffer;

		// Token: 0x040023BE RID: 9150
		[Token(Token = "0x40023BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private InteractableTile.TileType tileTypeBuffer;

		// Token: 0x02000681 RID: 1665
		[Token(Token = "0x2000681")]
		private struct CheckPoint
		{
			// Token: 0x06002734 RID: 10036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002734")]
			[Address(RVA = "0x52CD90", Offset = "0x52B790", VA = "0x18052CD90")]
			public CheckPoint(Vector2Int startPoint, int ignoreDirection)
			{
			}

			// Token: 0x040023CD RID: 9165
			[Token(Token = "0x40023CD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector2Int startPoint;

			// Token: 0x040023CE RID: 9166
			[Token(Token = "0x40023CE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int ignoreDirection;
		}

		// Token: 0x02000682 RID: 1666
		[Token(Token = "0x2000682")]
		public struct GuestTableData
		{
			// Token: 0x06002735 RID: 10037 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002735")]
			[Address(RVA = "0x5314D0", Offset = "0x52FED0", VA = "0x1805314D0")]
			public GuestTableData(Vector3Int tablePosition, Vector3Int[] seatPosition, GuestTableDisplayer tableDisplayer)
			{
			}

			// Token: 0x040023CF RID: 9167
			[Token(Token = "0x40023CF")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3Int tablePosition;

			// Token: 0x040023D0 RID: 9168
			[Token(Token = "0x40023D0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3Int[] seatPositions;

			// Token: 0x040023D1 RID: 9169
			[Token(Token = "0x40023D1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GuestTableDisplayer tableDisplayer;
		}
	}
}

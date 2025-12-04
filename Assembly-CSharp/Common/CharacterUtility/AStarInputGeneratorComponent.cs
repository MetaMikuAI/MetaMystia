using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DayScene.Input;
using DEYU.Utils;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x02001038 RID: 4152
	[Token(Token = "0x2001038")]
	[GenerateCleanupMethod]
	public class AStarInputGeneratorComponent : CharacterControllerInputGeneratorComponent
	{
		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06005FC3 RID: 24515 RVA: 0x000210F0 File Offset: 0x0001F2F0
		// (set) Token: 0x06005FC4 RID: 24516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D35")]
		public int DoNotUseCollisionCounter
		{
			[Token(Token = "0x6005FC3")]
			[Address(RVA = "0x51B080", Offset = "0x519A80", VA = "0x18051B080")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005FC4")]
			[Address(RVA = "0x654500", Offset = "0x652F00", VA = "0x180654500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06005FC5 RID: 24517 RVA: 0x00021108 File Offset: 0x0001F308
		[Token(Token = "0x17000D36")]
		public bool NotUseCollision
		{
			[Token(Token = "0x6005FC5")]
			[Address(RVA = "0x8B89B0", Offset = "0x8B73B0", VA = "0x1808B89B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06005FC6 RID: 24518 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005FC7 RID: 24519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D37")]
		public Action OnFinish
		{
			[Token(Token = "0x6005FC6")]
			[Address(RVA = "0x440270", Offset = "0x43EC70", VA = "0x180440270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005FC7")]
			[Address(RVA = "0x51B160", Offset = "0x519B60", VA = "0x18051B160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06005FC8 RID: 24520 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005FC9 RID: 24521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D38")]
		public Action OnExternalEndCallback
		{
			[Token(Token = "0x6005FC8")]
			[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005FC9")]
			[Address(RVA = "0x547AB0", Offset = "0x5464B0", VA = "0x180547AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06005FCA RID: 24522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D39")]
		public List<Vector3Int> PathCache
		{
			[Token(Token = "0x6005FCA")]
			[Address(RVA = "0x48B8D0", Offset = "0x48A2D0", VA = "0x18048B8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06005FCB RID: 24523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCB")]
		[Address(RVA = "0x8B8420", Offset = "0x8B6E20", VA = "0x1808B8420")]
		public static void Initialize(Grid referenceGrid)
		{
		}

		// Token: 0x06005FCC RID: 24524 RVA: 0x00021120 File Offset: 0x0001F320
		[Token(Token = "0x6005FCC")]
		[Address(RVA = "0x8B80E0", Offset = "0x8B6AE0", VA = "0x1808B80E0")]
		public Vector3Int GetGridPosition()
		{
			return default(Vector3Int);
		}

		// Token: 0x06005FCD RID: 24525 RVA: 0x00021138 File Offset: 0x0001F338
		[Token(Token = "0x6005FCD")]
		[Address(RVA = "0x8B7E10", Offset = "0x8B6810", VA = "0x1808B7E10")]
		public static Vector3 ComputeCharacterWorldPosition(Vector3Int cellPosition, float extraYOffset)
		{
			return default(Vector3);
		}

		// Token: 0x06005FCE RID: 24526 RVA: 0x00021150 File Offset: 0x0001F350
		[Token(Token = "0x6005FCE")]
		[Address(RVA = "0x8B8220", Offset = "0x8B6C20", VA = "0x1808B8220")]
		public Vector3 GetWorldPosition(Vector3Int cellPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06005FCF RID: 24527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FCF")]
		[Address(RVA = "0x8B8770", Offset = "0x8B7170", VA = "0x1808B8770")]
		public void SetPath(Vector3Int targetPt, UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int> colliderCollections, float delay, Action onFinish, DayScenePlayerInputGenerator.CharacterRotation rotationOnFinish, [Optional] Vector3? extraOnArrivalOffset)
		{
		}

		// Token: 0x06005FD0 RID: 24528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD0")]
		[Address(RVA = "0x8B8770", Offset = "0x8B7170", VA = "0x1808B8770")]
		public void SetPath(Vector3Int targetPt, UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int> colliderCollections, float delay, Action onFinish, int rotationOnFinish, [Optional] Vector3? extraOnArrivalOffset)
		{
		}

		// Token: 0x06005FD1 RID: 24529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FD1")]
		[Address(RVA = "0x8B8680", Offset = "0x8B7080", VA = "0x1808B8680")]
		private IEnumerator SetPathImpl(Vector3Int targetPt, UnityEngineExtensionStatic.ScopedTempHashSetHandle<Vector2Int> colliderCollections, float delay, Action onFinish, int rotationOnFinish, Vector3? extraOnArrivalOffset)
		{
			return null;
		}

		// Token: 0x06005FD2 RID: 24530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD2")]
		[Address(RVA = "0x8B7FD0", Offset = "0x8B69D0", VA = "0x1808B7FD0")]
		private void FinishPath(int rotationOnFinish)
		{
		}

		// Token: 0x06005FD3 RID: 24531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FD3")]
		[Address(RVA = "0x8B8020", Offset = "0x8B6A20", VA = "0x1808B8020")]
		private IEnumerator FollowPath(IList<Vector3Int> path, Vector3? extraOnArrivalOffset, int rotationOnFinish)
		{
			return null;
		}

		// Token: 0x06005FD4 RID: 24532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FD4")]
		[Address(RVA = "0x8B8490", Offset = "0x8B6E90", VA = "0x1808B8490")]
		private IEnumerator MoveToTargetPosition(Vector3 targetWorldPosition)
		{
			return null;
		}

		// Token: 0x06005FD5 RID: 24533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD5")]
		[Address(RVA = "0x8B8520", Offset = "0x8B6F20", VA = "0x1808B8520", Slot = "4")]
		protected override void OnExternalStop()
		{
		}

		// Token: 0x06005FD6 RID: 24534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD6")]
		[Address(RVA = "0x8B85C0", Offset = "0x8B6FC0", VA = "0x1808B85C0", Slot = "6")]
		public override void OnTimelinePositionUpdated()
		{
		}

		// Token: 0x06005FD7 RID: 24535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD7")]
		[Address(RVA = "0x8B7D70", Offset = "0x8B6770", VA = "0x1808B7D70", Slot = "8")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005FD8 RID: 24536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FD8")]
		[Address(RVA = "0x8B8920", Offset = "0x8B7320", VA = "0x1808B8920")]
		public AStarInputGeneratorComponent()
		{
		}

		// Token: 0x040058BA RID: 22714
		[Token(Token = "0x40058BA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[CleanupIgnore]
		private static Grid s_ReferenceGrid;

		// Token: 0x040058BB RID: 22715
		[Token(Token = "0x40058BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly WaitForFixedUpdate s_WaitForFixedUpdate;

		// Token: 0x040058BC RID: 22716
		[Token(Token = "0x40058BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3Int m_LastGridPosition;

		// Token: 0x040058BD RID: 22717
		[Token(Token = "0x40058BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Coroutine m_MoveCoroutine;

		// Token: 0x040058BE RID: 22718
		[Token(Token = "0x40058BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine m_WaitCoroutine;
	}
}

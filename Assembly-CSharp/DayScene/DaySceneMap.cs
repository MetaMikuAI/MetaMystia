using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using DayScene.Interactables;
using DayScene.Interactables.Collections.ConditionComponents;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace DayScene
{
	// Token: 0x02000225 RID: 549
	[Token(Token = "0x2000225")]
	[GenerateCleanupMethod]
	public class DaySceneMap : MonoBehaviour
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700015B")]
		private Dictionary<string, SpawnMarker> AllSpawnMarkers
		{
			[Token(Token = "0x6000CF6")]
			[Address(RVA = "0x8EB030", Offset = "0x8E9A30", VA = "0x1808EB030")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CF7")]
			[Address(RVA = "0x608700", Offset = "0x607100", VA = "0x180608700")]
			set
			{
			}
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CF8")]
		[Address(RVA = "0x8EA0C0", Offset = "0x8E8AC0", VA = "0x1808EA0C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000CF9 RID: 3321 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06000CFA RID: 3322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000009")]
		[CleanupIgnore]
		public static event Action<string> OnEnterMapCallback
		{
			[Token(Token = "0x6000CF9")]
			[Address(RVA = "0x8EAF20", Offset = "0x8E9920", VA = "0x1808EAF20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000CFA")]
			[Address(RVA = "0x8EB080", Offset = "0x8E9A80", VA = "0x1808EB080")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x8EADF0", Offset = "0x8E97F0", VA = "0x1808EADF0")]
		public static CharacterConditionComponent TryGetCharacter(string characterId)
		{
			return null;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFC")]
		[Address(RVA = "0x8E9CA0", Offset = "0x8E86A0", VA = "0x1808E9CA0", Slot = "4")]
		protected virtual Dictionary<string, SpawnMarker> GenerateSpawnMarkerData()
		{
			return null;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFD")]
		[Address(RVA = "0x8E9DF0", Offset = "0x8E87F0", VA = "0x1808E9DF0")]
		public IEnumerable<string> GetAllCollectableLabels()
		{
			return null;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x8E9F20", Offset = "0x8E8920", VA = "0x1808E9F20")]
		public CollectableConditionComponent[] GetAllCollectables()
		{
			return null;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00005898 File Offset: 0x00003A98
		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x8E9A10", Offset = "0x8E8410", VA = "0x1808E9A10")]
		public bool CheckIfContainsSpawnMarkers(string spawnMarker)
		{
			return default(bool);
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x8EA180", Offset = "0x8E8B80", VA = "0x1808EA180")]
		public void PreInitialize(string mapLabel, IGameObjectAssetHandle<DaySceneMap> gameObjectAssetHandle)
		{
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x8EA240", Offset = "0x8E8C40", VA = "0x1808EA240")]
		public void RefreshNPCs(bool rotateCharacter = false)
		{
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x8EAD40", Offset = "0x8E9740", VA = "0x1808EAD40")]
		public bool SolveAndUpdateCharacterPosition(TrackedNPC npc, CharacterConditionComponent character, bool rotateCharacter = false)
		{
			return default(bool);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x8EA630", Offset = "0x8E9030", VA = "0x1808EA630")]
		private void SolveAndUpdateCharacterPositionInternal(Dictionary<string, TrackedNPC> npcs, TrackedNPC npc, CharacterConditionComponent character, out bool isNPCOnMap, bool changeRotation = false)
		{
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x000058C8 File Offset: 0x00003AC8
		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x8E9BC0", Offset = "0x8E85C0", VA = "0x1808E9BC0")]
		public UniTask EnterSceneAsync(string mapLabel)
		{
			return default(UniTask);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x000058E0 File Offset: 0x00003AE0
		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x8EA120", Offset = "0x8E8B20", VA = "0x1808EA120", Slot = "5")]
		public virtual UniTask OnPostEnterSceneAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "6")]
		public virtual void OnPostLeaveScene()
		{
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x8E9B50", Offset = "0x8E8550", VA = "0x1808E9B50")]
		public static void Dispose()
		{
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D08")]
		[Address(RVA = "0x8EA030", Offset = "0x8E8A30", VA = "0x1808EA030")]
		public SpawnMarker GetSpawnMarker(string markerName)
		{
			return null;
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x8E9AA0", Offset = "0x8E84A0", VA = "0x1808E9AA0", Slot = "7")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public DaySceneMap()
		{
		}

		// Token: 0x04000B80 RID: 2944
		[Token(Token = "0x4000B80")]
		[FieldOffset(Offset = "0x0")]
		[CleanupIgnore]
		protected static readonly Dictionary<string, CharacterConditionComponent> allCharacters;

		// Token: 0x04000B81 RID: 2945
		[Token(Token = "0x4000B81")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 cameraDefaultPosition;

		// Token: 0x04000B82 RID: 2946
		[Token(Token = "0x4000B82")]
		[FieldOffset(Offset = "0x24")]
		public bool shouldCameraFollow;

		// Token: 0x04000B83 RID: 2947
		[Token(Token = "0x4000B83")]
		[FieldOffset(Offset = "0x28")]
		public LoopedBGMPackage mapBGM;

		// Token: 0x04000B84 RID: 2948
		[Token(Token = "0x4000B84")]
		[FieldOffset(Offset = "0x30")]
		public Tilemap height;

		// Token: 0x04000B85 RID: 2949
		[Token(Token = "0x4000B85")]
		[FieldOffset(Offset = "0x38")]
		public Collider2D boundingShape;

		// Token: 0x04000B86 RID: 2950
		[Token(Token = "0x4000B86")]
		[FieldOffset(Offset = "0x40")]
		public Transform spawnMarkerField;

		// Token: 0x04000B87 RID: 2951
		[Token(Token = "0x4000B87")]
		[FieldOffset(Offset = "0x48")]
		public Transform collectableField;

		// Token: 0x04000B88 RID: 2952
		[Token(Token = "0x4000B88")]
		[FieldOffset(Offset = "0x50")]
		public bool doNotShowIconSprite;

		// Token: 0x04000B89 RID: 2953
		[Token(Token = "0x4000B89")]
		[FieldOffset(Offset = "0x51")]
		public bool hideClock;

		// Token: 0x04000B8A RID: 2954
		[Token(Token = "0x4000B8A")]
		[FieldOffset(Offset = "0x58")]
		private CollectableConditionComponent[] allCollectables;

		// Token: 0x04000B8B RID: 2955
		[Token(Token = "0x4000B8B")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, SpawnMarker> allSpawnMarkers;

		// Token: 0x04000B8C RID: 2956
		[Token(Token = "0x4000B8C")]
		[FieldOffset(Offset = "0x68")]
		private bool initialized;

		// Token: 0x04000B8D RID: 2957
		[Token(Token = "0x4000B8D")]
		[FieldOffset(Offset = "0x70")]
		protected string mapLabel;

		// Token: 0x04000B8E RID: 2958
		[Token(Token = "0x4000B8E")]
		[FieldOffset(Offset = "0x78")]
		private IGameObjectAssetHandle<DaySceneMap> _Handle;
	}
}

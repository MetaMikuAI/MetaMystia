using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using DayScene;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Tilemaps;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
[GenerateCleanupMethod]
public class FlandreHomeMap : DaySceneMap
{
	// Token: 0x06000024 RID: 36 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x40C3A0", Offset = "0x40ADA0", VA = "0x18040C3A0")]
	public void Awake()
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x40E320", Offset = "0x40CD20", VA = "0x18040E320", Slot = "5")]
	public override UniTask OnPostEnterSceneAsync()
	{
		return default(UniTask);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x40E590", Offset = "0x40CF90", VA = "0x18040E590")]
	public void RefreshStateArea(IEnumerable<Vector2Int> pointsNeedToRefresh, int count, FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement furnitureType, Vector2Int[] currentPositionBuffer, bool canPutDown = true)
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x40E410", Offset = "0x40CE10", VA = "0x18040E410")]
	private void PrintColliderTiles(in FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int[] currentPosition)
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x40E3A0", Offset = "0x40CDA0", VA = "0x18040E3A0")]
	public void PrintColliderTiles(in FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int currentPosition)
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x40C5C0", Offset = "0x40AFC0", VA = "0x18040C5C0")]
	public void ClearTilemap()
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x40CE70", Offset = "0x40B870", VA = "0x18040CE70")]
	public HashSet<Vector2Int> GetAllTargetPlacementGrids(FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement placement)
	{
		return null;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x40C3B0", Offset = "0x40ADB0", VA = "0x18040C3B0")]
	public bool CheckFurnitureCanSetHere(FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int position)
	{
		return default(bool);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002160 File Offset: 0x00000360
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x40C860", Offset = "0x40B260", VA = "0x18040C860")]
	public bool FindPositionToSet(in FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, out Vector2Int finalPosition)
	{
		return default(bool);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x40DD60", Offset = "0x40C760", VA = "0x18040DD60")]
	public FlandreFurnitureComponent InstantiateFurniture(in FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int position)
	{
		return null;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002178 File Offset: 0x00000378
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x40D0F0", Offset = "0x40BAF0", VA = "0x18040D0F0")]
	public bool GetTargetPositionObject(FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement placementType, Vector2Int position, out FlandreFurnitureComponent furnitureObject)
	{
		return default(bool);
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x40CD00", Offset = "0x40B700", VA = "0x18040CD00")]
	public List<FlandreFurnitureComponent> GetAllSpawnedFurnitureInstance()
	{
		return null;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x40C5F0", Offset = "0x40AFF0", VA = "0x18040C5F0")]
	public void DeleteFurniture(FlandreFurnitureComponent furnitureObject)
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002190 File Offset: 0x00000390
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x40F230", Offset = "0x40DC30", VA = "0x18040F230")]
	public bool SetOccupiedPosition(in FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int position, FlandreFurnitureComponent furnitureObject)
	{
		return default(bool);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x40EF20", Offset = "0x40D920", VA = "0x18040EF20")]
	public void RemoveOccupiedPosition(in FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int position)
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x40F1A0", Offset = "0x40DBA0", VA = "0x18040F1A0")]
	public void SetFurnitureData(FlandreHomeMap.EditorMode editorMode, in FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int? oldPosition, Vector2Int? newPosition)
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x40F120", Offset = "0x40DB20", VA = "0x18040F120")]
	public void SetFurnitureData(FlandreHomeMap.EditorMode editorMode, int furnitureId, Vector2Int? oldPosition, Vector2Int? newPosition)
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x40CF40", Offset = "0x40B940", VA = "0x18040CF40")]
	public Vector2Int[] GetFurnitureWorldPosition(FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int position)
	{
		return null;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x40CED0", Offset = "0x40B8D0", VA = "0x18040CED0")]
	public void GetFurnitureWorldPositionNonAlloc(FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int position, Vector2Int[] buffer)
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x40D010", Offset = "0x40BA10", VA = "0x18040D010")]
	private Vector2Int[] GetTargetPlacementAvailableGrids(FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement placement)
	{
		return null;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x40DE70", Offset = "0x40C870", VA = "0x18040DE70")]
	private void LoadSavedFurnitures()
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x40D1B0", Offset = "0x40BBB0", VA = "0x18040D1B0")]
	private void InitGridPosition(Tilemap tilemap)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x40F5A0", Offset = "0x40DFA0", VA = "0x18040F5A0")]
	private void SetPosition(Transform transform, Vector2Int position)
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x40F5F0", Offset = "0x40DFF0", VA = "0x18040F5F0")]
	private void TrySpawnDefaultFurniture()
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x40C480", Offset = "0x40AE80", VA = "0x18040C480", Slot = "7")]
	protected override void Cleanup_Generated()
	{
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x40F960", Offset = "0x40E360", VA = "0x18040F960")]
	public FlandreHomeMap()
	{
	}

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	private const string FIRST_GOTO_SDM_BASEMENT = "FirstTimeToSDMBasement";

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Tilemap tilemap;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Transform furnitureTransform;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Tile availableArea;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Tile forbiddenArea;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private Tile placedArea;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Tile currentArea;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0xB0")]
	private readonly Dictionary<Vector2Int, Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, FlandreFurnitureComponent>> allSpawnedFurnitureObjects;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0xB8")]
	private readonly Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, HashSet<Vector2Int>> availableGridPosition;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0xC0")]
	private readonly Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, HashSet<Vector2Int>> occupiedGridPosition;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0xC8")]
	private Dictionary<FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement, HashSet<Vector2Int>> allGridPosition;

	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public enum EditorMode
	{
		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		Move,
		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		Delete,
		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		Set
	}
}

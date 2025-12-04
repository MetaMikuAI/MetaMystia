using System;
using Cysharp.Threading.Tasks;
using DayScene;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
[GenerateCleanupMethod]
public class HakureiFestivalMap : DaySceneMap
{
	// Token: 0x06000046 RID: 70 RVA: 0x000021F0 File Offset: 0x000003F0
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x40FB30", Offset = "0x40E530", VA = "0x18040FB30", Slot = "5")]
	public override UniTask OnPostEnterSceneAsync()
	{
		return default(UniTask);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x40FD30", Offset = "0x40E730", VA = "0x18040FD30")]
	public GameObject SetViewer(HakureiFestivalMap.ViewLabel viewLabel, bool open)
	{
		return null;
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x40FAA0", Offset = "0x40E4A0", VA = "0x18040FAA0", Slot = "7")]
	protected override void Cleanup_Generated()
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x40FE30", Offset = "0x40E830", VA = "0x18040FE30")]
	public HakureiFestivalMap()
	{
	}

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject musicViewer1;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private GameObject musicViewer2;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject musicViewer3;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject musicViewerSuccess3;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private GameObject light;

	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public enum ViewLabel
	{
		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[InspectorName("一轮比赛观众")]
		View1,
		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[InspectorName("村纱比赛观众")]
		View2,
		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[InspectorName("寅丸星比赛观众")]
		View3,
		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[InspectorName("胜利观众")]
		ViewSuccess3,
		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[InspectorName("灯光")]
		Light
	}
}

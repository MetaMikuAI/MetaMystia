using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

// Token: 0x0200001A RID: 26
[Token(Token = "0x200001A")]
[GenerateCleanupMethod]
public class DaySceneSleepAndSavePannel : UISubPanelParamOpen<DaySceneSleepAndSavePrePannel, Action>
{
	// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x40BBA0", Offset = "0x40A5A0", VA = "0x18040BBA0", Slot = "22")]
	protected override void OnPanelInitialize()
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x40BCC0", Offset = "0x40A6C0", VA = "0x18040BCC0", Slot = "32")]
	protected override void OnPanelOpen(Action finishAutoCompleteEvents)
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0", Slot = "23")]
	protected override void OnPanelClose()
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x40B850", Offset = "0x40A250", VA = "0x18040B850")]
	private void Confirm()
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x40AC00", Offset = "0x409600", VA = "0x18040AC00", Slot = "31")]
	protected override void Cleanup_Generated()
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x40C0E0", Offset = "0x40AAE0", VA = "0x18040C0E0")]
	public DaySceneSleepAndSavePannel()
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008E")]
	[Address(RVA = "0x40C040", Offset = "0x40AA40", VA = "0x18040C040")]
	[CompilerGenerated]
	internal static IEnumerator <Confirm>g__OnRotation|11_1(Transform source, float speed, Vector3 point)
	{
		return null;
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002280 File Offset: 0x00000480
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x40BF20", Offset = "0x40A920", VA = "0x18040BF20")]
	[CompilerGenerated]
	internal static float <Confirm>g__GetDistance|11_4(ref DaySceneSleepAndSavePannel.<>c__DisplayClass11_1 A_0)
	{
		return 0f;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002298 File Offset: 0x00000498
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x40BD10", Offset = "0x40A710", VA = "0x18040BD10")]
	[CompilerGenerated]
	internal static Vector3 <Confirm>g__GetControl|11_5(ref DaySceneSleepAndSavePannel.<>c__DisplayClass11_1 A_0)
	{
		return default(Vector3);
	}

	// Token: 0x04000066 RID: 102
	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x80")]
	public Action finishAutoCompleteEvents;

	// Token: 0x04000067 RID: 103
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x88")]
	public UIButtonHold confirmButton;

	// Token: 0x04000068 RID: 104
	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x90")]
	public UIButtonSimple refuseButton;

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x98")]
	public Vector2 finalPosition;

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0xA0")]
	private readonly Vector2 bezierPt1;

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0xA8")]
	private readonly Vector2 bezierPt2;

	// Token: 0x0400006C RID: 108
	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0xB0")]
	private readonly Vector2 bezierPt3;

	// Token: 0x0400006D RID: 109
	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0xB8")]
	private readonly Vector2 bezierPt4;
}

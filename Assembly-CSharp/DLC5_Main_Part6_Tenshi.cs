using System;
using Cysharp.Threading.Tasks;
using DayScene.Interactables.Collections.BehaviourComponents;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

// Token: 0x02000037 RID: 55
[Token(Token = "0x2000037")]
public class DLC5_Main_Part6_Tenshi : EntityBehaviourComponent
{
	// Token: 0x060000FF RID: 255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x40B4C0", Offset = "0x409EC0", VA = "0x18040B4C0")]
	private void Start()
	{
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000100")]
	[Address(RVA = "0x40AFB0", Offset = "0x4099B0", VA = "0x18040AFB0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000101")]
	[Address(RVA = "0x40B1B0", Offset = "0x409BB0", VA = "0x18040B1B0", Slot = "6")]
	public override void OnInteract()
	{
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00002460 File Offset: 0x00000660
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x40B110", Offset = "0x409B10", VA = "0x18040B110")]
	private UniTaskVoid OnInteractAsync()
	{
		return default(UniTaskVoid);
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000103")]
	[Address(RVA = "0x40B260", Offset = "0x409C60", VA = "0x18040B260")]
	private void OnToggleTrackedSwitch(string key, bool isOpen)
	{
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x40B3B0", Offset = "0x409DB0", VA = "0x18040B3B0")]
	private void StartShake()
	{
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x40B780", Offset = "0x40A180", VA = "0x18040B780")]
	private void StopShake()
	{
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
	public DLC5_Main_Part6_Tenshi()
	{
	}

	// Token: 0x040000DC RID: 220
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x18")]
	private string m_EntityKey;

	// Token: 0x040000DD RID: 221
	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x20")]
	private Coroutine m_ShakeCoroutine;

	// Token: 0x040000DE RID: 222
	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AssetReferenceT<DialogPackage> m_InteractDialogAsset;
}

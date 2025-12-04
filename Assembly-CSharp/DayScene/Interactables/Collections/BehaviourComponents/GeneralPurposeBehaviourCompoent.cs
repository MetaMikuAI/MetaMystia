using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004FA RID: 1274
	[Token(Token = "0x20004FA")]
	[GenerateCleanupMethod]
	public class GeneralPurposeBehaviourCompoent : EntityBehaviourComponent
	{
		// Token: 0x06001C9E RID: 7326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C9E")]
		[Address(RVA = "0x4ADC00", Offset = "0x4AC600", VA = "0x1804ADC00", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		[Token(Token = "0x6001C9F")]
		[Address(RVA = "0x4ADB60", Offset = "0x4AC560", VA = "0x1804ADB60")]
		private UniTaskVoid LoadAndOpenUIPanelAsset(AssetReferenceGameObject panelAssetReference)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CA0")]
		private static T GetComponentNotNull<T>(GameObject gameObjectInstance) where T : Component
		{
			return null;
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x4A1430", Offset = "0x49FE30", VA = "0x1804A1430", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public GeneralPurposeBehaviourCompoent()
		{
		}

		// Token: 0x04001A4F RID: 6735
		[Token(Token = "0x4001A4F")]
		[FieldOffset(Offset = "0x18")]
		public GeneralPurposeBehaviourCompoent.EntryType uiType;

		// Token: 0x04001A50 RID: 6736
		[Token(Token = "0x4001A50")]
		[FieldOffset(Offset = "0x20")]
		public GameObject customUI;

		// Token: 0x04001A51 RID: 6737
		[Token(Token = "0x4001A51")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public AssetReferenceGameObject m_CustomUIAssetReference;

		// Token: 0x04001A52 RID: 6738
		[Token(Token = "0x4001A52")]
		[FieldOffset(Offset = "0x30")]
		public string dialogLabel;

		// Token: 0x020004FB RID: 1275
		[Token(Token = "0x20004FB")]
		public enum EntryType
		{
			// Token: 0x04001A54 RID: 6740
			[Token(Token = "0x4001A54")]
			FoodStorage,
			// Token: 0x04001A55 RID: 6741
			[Token(Token = "0x4001A55")]
			BeverageStorage,
			// Token: 0x04001A56 RID: 6742
			[Token(Token = "0x4001A56")]
			Custom,
			// Token: 0x04001A57 RID: 6743
			[Token(Token = "0x4001A57")]
			YukariMapTeleport,
			// Token: 0x04001A58 RID: 6744
			[Token(Token = "0x4001A58")]
			Dialog
		}
	}
}

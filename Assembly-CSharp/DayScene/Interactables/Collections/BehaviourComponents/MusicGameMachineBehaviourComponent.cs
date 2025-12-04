using System;
using Cysharp.Threading.Tasks;
using DayScene.Interactables.Collections.ConditionComponents;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000514 RID: 1300
	[Token(Token = "0x2000514")]
	[RequireComponent(typeof(MusicGameMachineConditionComponent))]
	[GenerateCleanupMethod]
	public class MusicGameMachineBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001D1E RID: 7454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1E")]
		[Address(RVA = "0x4B2A40", Offset = "0x4B1440", VA = "0x1804B2A40", Slot = "5")]
		public override void OnEnterMap(string mapLabel)
		{
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D1F")]
		[Address(RVA = "0x4B2AE0", Offset = "0x4B14E0", VA = "0x1804B2AE0", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D20")]
		[Address(RVA = "0x4B2D60", Offset = "0x4B1760", VA = "0x1804B2D60")]
		private void OpenPannel()
		{
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x0000AEC0 File Offset: 0x000090C0
		[Token(Token = "0x6001D21")]
		[Address(RVA = "0x4B2CD0", Offset = "0x4B16D0", VA = "0x1804B2CD0")]
		private UniTaskVoid OpenPanelAsync()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D22")]
		[Address(RVA = "0x3E85F0", Offset = "0x3E6FF0", VA = "0x1803E85F0", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D23")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public MusicGameMachineBehaviourComponent()
		{
		}

		// Token: 0x04001ACE RID: 6862
		[Token(Token = "0x4001ACE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AssetReferenceT<GameObject> m_PannelPrefab;

		// Token: 0x04001ACF RID: 6863
		[Token(Token = "0x4001ACF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject m_TipIcon;

		// Token: 0x04001AD0 RID: 6864
		[Token(Token = "0x4001AD0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DialogPackage m_FirstOpenDialog;

		// Token: 0x04001AD1 RID: 6865
		[Token(Token = "0x4001AD1")]
		[FieldOffset(Offset = "0x30")]
		private bool m_IsMainMap;
	}
}

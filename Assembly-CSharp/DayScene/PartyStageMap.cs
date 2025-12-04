using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using DayScene.Interactables;
using DayScene.Interactables.Collections.BehaviourComponents;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Playables;
using UnityEngine.Serialization;

namespace DayScene
{
	// Token: 0x0200022B RID: 555
	[Token(Token = "0x200022B")]
	[GenerateCleanupMethod]
	public class PartyStageMap : DaySceneMap
	{
		// Token: 0x06000D24 RID: 3364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x8EDDD0", Offset = "0x8EC7D0", VA = "0x1808EDDD0", Slot = "4")]
		protected override Dictionary<string, SpawnMarker> GenerateSpawnMarkerData()
		{
			return null;
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x8EE0C0", Offset = "0x8ECAC0", VA = "0x1808EE0C0", Slot = "6")]
		public override void OnPostLeaveScene()
		{
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00005928 File Offset: 0x00003B28
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x8EDFD0", Offset = "0x8EC9D0", VA = "0x1808EDFD0", Slot = "5")]
		public override UniTask OnPostEnterSceneAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x8EDCA0", Offset = "0x8EC6A0", VA = "0x1808EDCA0", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x8EE250", Offset = "0x8ECC50", VA = "0x1808EE250")]
		public PartyStageMap()
		{
		}

		// Token: 0x04000BA5 RID: 2981
		[Token(Token = "0x4000BA5")]
		private const string KYOUKO_KEY = "Kyouko";

		// Token: 0x04000BA6 RID: 2982
		[Token(Token = "0x4000BA6")]
		[FieldOffset(Offset = "0x80")]
		public PartyStageMap.CharacterStageData[] level5CharacterData;

		// Token: 0x04000BA7 RID: 2983
		[Token(Token = "0x4000BA7")]
		[FieldOffset(Offset = "0x88")]
		public PartyStageMap.CharacterStageData[] level5CharacterDataDLC;

		// Token: 0x04000BA8 RID: 2984
		[Token(Token = "0x4000BA8")]
		[FieldOffset(Offset = "0x90")]
		private readonly List<GameObject> m_Vfxs;

		// Token: 0x04000BA9 RID: 2985
		[Token(Token = "0x4000BA9")]
		[FieldOffset(Offset = "0x98")]
		private Action m_CharacterStageDataDispose;

		// Token: 0x0200022C RID: 556
		[Token(Token = "0x200022C")]
		[Serializable]
		public struct CharacterStageData
		{
			// Token: 0x06000D29 RID: 3369 RVA: 0x00005940 File Offset: 0x00003B40
			[Token(Token = "0x6000D29")]
			[Address(RVA = "0x8E3B50", Offset = "0x8E2550", VA = "0x1808E3B50")]
			public UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>> LoadAssetsAsync()
			{
				return default(UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>>);
			}

			// Token: 0x04000BAA RID: 2986
			[Token(Token = "0x4000BAA")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public SpawnMarker characterSpawnMarker;

			// Token: 0x04000BAB RID: 2987
			[Token(Token = "0x4000BAB")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public CharacterStageBehaviourComponent.EventType eventType;

			// Token: 0x04000BAC RID: 2988
			[Token(Token = "0x4000BAC")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public AssetReference chatDialogReference;

			// Token: 0x04000BAD RID: 2989
			[Token(Token = "0x4000BAD")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public AssetReference chatTimelineReference;

			// Token: 0x04000BAE RID: 2990
			[Token(Token = "0x4000BAE")]
			[FieldOffset(Offset = "0x20")]
			[FormerlySerializedAs("ExtraEffectReference")]
			public GameObject ExtraEffect;
		}
	}
}

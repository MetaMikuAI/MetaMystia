using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cinemachine;
using Common.CharacterUtility;
using Cysharp.Threading.Tasks;
using DayScene.Input;
using DEYU.AssetHandleUtility;
using DEYU.Singletons;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common
{
	// Token: 0x02000D5C RID: 3420
	[Token(Token = "0x2000D5C")]
	[RequireComponent(typeof(PlayableDirector))]
	public class SceneDirector : MonoSingletonPersistant<SceneDirector>
	{
		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06005049 RID: 20553 RVA: 0x0001D550 File Offset: 0x0001B750
		// (set) Token: 0x0600504A RID: 20554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B5F")]
		public static bool IsInEvent
		{
			[Token(Token = "0x6005049")]
			[Address(RVA = "0x7E4D10", Offset = "0x7E3710", VA = "0x1807E4D10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600504A")]
			[Address(RVA = "0x7E4D60", Offset = "0x7E3760", VA = "0x1807E4D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600504B")]
		[Address(RVA = "0x7E21C0", Offset = "0x7E0BC0", VA = "0x1807E21C0", Slot = "6")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600504C")]
		[Address(RVA = "0x7E14D0", Offset = "0x7DFED0", VA = "0x1807E14D0")]
		public static void GotoStaffScene(SceneDirector.StaffScenePlayBackIndicator playBackIndicator)
		{
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x0001D568 File Offset: 0x0001B768
		[Token(Token = "0x600504D")]
		[Address(RVA = "0x7E1450", Offset = "0x7DFE50", VA = "0x1807E1450")]
		private static UniTaskVoid GotoStaffSceneAsync(SceneDirector.StaffScenePlayBackIndicator playBackIndicator)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x0600504E RID: 20558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600504E")]
		[Address(RVA = "0x7E0950", Offset = "0x7DF350", VA = "0x1807E0950")]
		public void DisposeMissionEvents()
		{
		}

		// Token: 0x0600504F RID: 20559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600504F")]
		[Address(RVA = "0x7E44F0", Offset = "0x7E2EF0", VA = "0x1807E44F0")]
		public void ToggleEventState(bool enabled)
		{
		}

		// Token: 0x06005050 RID: 20560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005050")]
		[Address(RVA = "0x7E1150", Offset = "0x7DFB50", VA = "0x1807E1150")]
		public void ExecuteEvent(SchedulerNode.Event eventData, Action onFinishCallback)
		{
		}

		// Token: 0x06005051 RID: 20561 RVA: 0x0001D580 File Offset: 0x0001B780
		[Token(Token = "0x6005051")]
		[Address(RVA = "0x7E1050", Offset = "0x7DFA50", VA = "0x1807E1050")]
		private UniTask ExecuteEventImplAsync(SchedulerNode.Event eventData)
		{
			return default(UniTask);
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x0001D598 File Offset: 0x0001B798
		[Token(Token = "0x6005052")]
		[Address(RVA = "0x7E0F30", Offset = "0x7DF930", VA = "0x1807E0F30")]
		private UniTask ExecuteEventCoreAsync(SchedulerNode.Event eventData)
		{
			return default(UniTask);
		}

		// Token: 0x06005053 RID: 20563 RVA: 0x0001D5B0 File Offset: 0x0001B7B0
		[Token(Token = "0x6005053")]
		[Address(RVA = "0x7E24A0", Offset = "0x7E0EA0", VA = "0x1807E24A0")]
		private UniTask PlayTimelineAsync(PlayableAsset playableAsset)
		{
			return default(UniTask);
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005054")]
		[Address(RVA = "0x7E0EA0", Offset = "0x7DF8A0", VA = "0x1807E0EA0")]
		public void EnableNoteAndStorageUI()
		{
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005055")]
		[Address(RVA = "0x7E0870", Offset = "0x7DF270", VA = "0x1807E0870")]
		public void DisableNoteAndStorageUI()
		{
		}

		// Token: 0x06005056 RID: 20566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005056")]
		[Address(RVA = "0x7E2A50", Offset = "0x7E1450", VA = "0x1807E2A50")]
		public void RestorePlayerInput()
		{
		}

		// Token: 0x06005057 RID: 20567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005057")]
		[Address(RVA = "0x7E0900", Offset = "0x7DF300", VA = "0x1807E0900")]
		public void DisablePlayerInput()
		{
		}

		// Token: 0x06005058 RID: 20568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005058")]
		[Address(RVA = "0x7E3170", Offset = "0x7E1B70", VA = "0x1807E3170")]
		public void SetMainScene(string mainSceneKey, GameObject mainScene)
		{
		}

		// Token: 0x06005059 RID: 20569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005059")]
		[Address(RVA = "0x7E1590", Offset = "0x7DFF90", VA = "0x1807E1590")]
		public void Initialize(CinemachineVirtualCamera cinemachineVirtualCamera)
		{
		}

		// Token: 0x0600505A RID: 20570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505A")]
		[Address(RVA = "0x7E3390", Offset = "0x7E1D90", VA = "0x1807E3390")]
		public void SetPlayerCharacter(CharacterControllerUnit character)
		{
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505B")]
		[Address(RVA = "0x7E42F0", Offset = "0x7E2CF0", VA = "0x1807E42F0")]
		public void SwitchScene(GameObject targetScene, string key)
		{
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505C")]
		[Address(RVA = "0x7E0440", Offset = "0x7DEE40", VA = "0x1807E0440")]
		public void CleanCharacters()
		{
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505D")]
		[Address(RVA = "0x7E47F0", Offset = "0x7E31F0", VA = "0x1807E47F0")]
		public void UpdateCachedScenes()
		{
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505E")]
		[Address(RVA = "0x7E05D0", Offset = "0x7DEFD0", VA = "0x1807E05D0")]
		public void CleanScenes()
		{
		}

		// Token: 0x0600505F RID: 20575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600505F")]
		[Address(RVA = "0x7E2E60", Offset = "0x7E1860", VA = "0x1807E2E60")]
		public void SetCameraWorld(Vector2 position, float damping)
		{
		}

		// Token: 0x06005060 RID: 20576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005060")]
		[Address(RVA = "0x7E30C0", Offset = "0x7E1AC0", VA = "0x1807E30C0")]
		public void SetFollowCameraWorld(string characterLabel, float damping)
		{
		}

		// Token: 0x06005061 RID: 20577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005061")]
		[Address(RVA = "0x7E29A0", Offset = "0x7E13A0", VA = "0x1807E29A0")]
		public void ResetCameraWorld()
		{
		}

		// Token: 0x06005062 RID: 20578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005062")]
		[Address(RVA = "0x7E39F0", Offset = "0x7E23F0", VA = "0x1807E39F0")]
		public void SpawnCharacter(SceneDirector.Identity characterType, int characterId, Vector2 startPosition, string label)
		{
		}

		// Token: 0x06005063 RID: 20579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005063")]
		[Address(RVA = "0x7E3890", Offset = "0x7E2290", VA = "0x1807E3890")]
		public void SpawnCharacterByPosition(SceneDirector.Identity characterType, int characterId, string characterLabel, string referencePositionCharacterLabel)
		{
		}

		// Token: 0x06005064 RID: 20580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005064")]
		[Address(RVA = "0x7E1380", Offset = "0x7DFD80", VA = "0x1807E1380")]
		public void GiveItem(Product[] items, bool suppressCallbacks = false)
		{
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005065")]
		[Address(RVA = "0x7E2660", Offset = "0x7E1060", VA = "0x1807E2660")]
		public void RemoveItem(Product[] items)
		{
		}

		// Token: 0x06005066 RID: 20582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005066")]
		[Address(RVA = "0x7E4250", Offset = "0x7E2C50", VA = "0x1807E4250")]
		public void StopCharacterMovingProcess(string label)
		{
		}

		// Token: 0x06005067 RID: 20583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005067")]
		[Address(RVA = "0x7E3F50", Offset = "0x7E2950", VA = "0x1807E3F50")]
		public void StopAllMovingProcess()
		{
		}

		// Token: 0x06005068 RID: 20584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005068")]
		[Address(RVA = "0x7E40D0", Offset = "0x7E2AD0", VA = "0x1807E40D0")]
		public void StopAllUnmanagedMovingProcess()
		{
		}

		// Token: 0x06005069 RID: 20585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005069")]
		[Address(RVA = "0x7E1ED0", Offset = "0x7E08D0", VA = "0x1807E1ED0")]
		public void MoveObject(string label, Vector2[] wayPoints, float speedMultiplier, [Optional] Action onFinishCallback)
		{
		}

		// Token: 0x0600506A RID: 20586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600506A")]
		[Address(RVA = "0x7E3250", Offset = "0x7E1C50", VA = "0x1807E3250")]
		public void SetObjectFollowTarget(string label, string targetLabel)
		{
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506B")]
		[Address(RVA = "0x7E12F0", Offset = "0x7DFCF0", VA = "0x1807E12F0")]
		private IEnumerator FollowTargetCoroutine(Transform self, Transform target)
		{
			return null;
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600506C")]
		[Address(RVA = "0x7E1690", Offset = "0x7E0090", VA = "0x1807E1690")]
		public void MoveCamera(Vector2 startPoint, Vector2[] wayPoints, float speedMultiplier, [Optional] Action onFinishCallback)
		{
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600506D")]
		[Address(RVA = "0x7E2AA0", Offset = "0x7E14A0", VA = "0x1807E2AA0")]
		public void RotateAroundCamera(Vector2 startPoint, Vector2 pivot, float angle, float speedMultiplier, [Optional] Action onFinishCallback)
		{
		}

		// Token: 0x0600506E RID: 20590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600506E")]
		[Address(RVA = "0x7E3DB0", Offset = "0x7E27B0", VA = "0x1807E3DB0")]
		private void StartWorkCoroutine(string label, Func<IEnumerator> executeCoroutine, [Optional] Action onFinishCallback)
		{
		}

		// Token: 0x0600506F RID: 20591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600506F")]
		[Address(RVA = "0x7E2100", Offset = "0x7E0B00", VA = "0x1807E2100")]
		private IEnumerator MoveTo(Transform entityTransform, Vector2[] wayPoints, float speedMultiplier, [Optional] Action onFinishCallback)
		{
			return null;
		}

		// Token: 0x06005070 RID: 20592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005070")]
		[Address(RVA = "0x7E2D10", Offset = "0x7E1710", VA = "0x1807E2D10")]
		private IEnumerator RotateAround(Transform entityTransform, Vector2 pivot, float angle, float speedMultiplier, [Optional] Action onFinishCallback)
		{
			return null;
		}

		// Token: 0x06005071 RID: 20593 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
		[Token(Token = "0x6005071")]
		[Address(RVA = "0x7E18F0", Offset = "0x7E02F0", VA = "0x1807E18F0")]
		public UniTask MoveCharacterAsync(string label, Vector2[] wayPoints, float speedMultiplier)
		{
			return default(UniTask);
		}

		// Token: 0x06005072 RID: 20594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005072")]
		[Address(RVA = "0x7E1C40", Offset = "0x7E0640", VA = "0x1807E1C40")]
		public void MoveCharacter(string label, Vector2[] wayPoints, float speedMultiplier, Action onFinishCallback)
		{
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005073")]
		[Address(RVA = "0x7E1A10", Offset = "0x7E0410", VA = "0x1807E1A10")]
		public void MoveCharacterNoAnimation(string label, Vector2[] wayPoints, float speedMultiplier, [Optional] Action onFinished)
		{
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005074")]
		[Address(RVA = "0x7DF750", Offset = "0x7DE150", VA = "0x1807DF750")]
		public void CharacterJump(string label, float startPoint, float jumpHeight, float gravity, int jumpCount = 1, float jumpInterval = 0.1f, [Optional] Action onFinished)
		{
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005075")]
		[Address(RVA = "0x7DF680", Offset = "0x7DE080", VA = "0x1807DF680")]
		public IEnumerator CharacterJumpCoroutine(Transform transform, float startPoint, float jumpHeight, float gravity, int jumpCount = 1, float jumpInterval = 0.1f, [Optional] Action onFinished)
		{
			return null;
		}

		// Token: 0x06005076 RID: 20598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005076")]
		[Address(RVA = "0x7DF9B0", Offset = "0x7DE3B0", VA = "0x1807DF9B0")]
		public void CharacterRotationZ(string label, float targetValue, bool isContinuous, [Optional] Action onFinished)
		{
		}

		// Token: 0x06005077 RID: 20599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005077")]
		[Address(RVA = "0x7DF5F0", Offset = "0x7DDFF0", VA = "0x1807DF5F0")]
		private IEnumerator CharacterContinuousRotationZCoroutine(Transform transform, float value)
		{
			return null;
		}

		// Token: 0x06005078 RID: 20600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005078")]
		[Address(RVA = "0x7E01A0", Offset = "0x7DEBA0", VA = "0x1807E01A0")]
		public void CharacterShake(string label, Vector2 amplitude, float duration, [Optional] Action onFinished)
		{
		}

		// Token: 0x06005079 RID: 20601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005079")]
		[Address(RVA = "0x7DFEE0", Offset = "0x7DE8E0", VA = "0x1807DFEE0")]
		public void CharacterShakeUnmanaged(string label, Vector2 amplitude)
		{
		}

		// Token: 0x0600507A RID: 20602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507A")]
		[Address(RVA = "0x7DFE10", Offset = "0x7DE810", VA = "0x1807DFE10")]
		private IEnumerator CharacterShakeCoroutine(Transform transform, Vector3 oldPosition, Vector2 amplitude, float duration, [Optional] Action onFinished)
		{
			return null;
		}

		// Token: 0x0600507B RID: 20603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600507B")]
		[Address(RVA = "0x7DFD40", Offset = "0x7DE740", VA = "0x1807DFD40")]
		public IEnumerator CharacterShakeCoroutineExtern(Transform transform, Vector3 oldPosition, Vector2 amplitude, float duration, [Optional] Action onFinished)
		{
			return null;
		}

		// Token: 0x0600507C RID: 20604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600507C")]
		[Address(RVA = "0x7E2F80", Offset = "0x7E1980", VA = "0x1807E2F80")]
		public void SetCharacterVisualActive(string label, bool active)
		{
		}

		// Token: 0x0600507D RID: 20605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600507D")]
		[Address(RVA = "0x7E2DD0", Offset = "0x7E17D0", VA = "0x1807E2DD0")]
		public void RotateCharacter(string label, DayScenePlayerInputGenerator.CharacterRotation targetRotation)
		{
		}

		// Token: 0x0600507E RID: 20606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600507E")]
		[Address(RVA = "0x7E2EF0", Offset = "0x7E18F0", VA = "0x1807E2EF0")]
		public void SetCharacterFace(string label, int faceId)
		{
		}

		// Token: 0x0600507F RID: 20607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600507F")]
		[Address(RVA = "0x7E2580", Offset = "0x7E0F80", VA = "0x1807E2580")]
		public void RemoveCharacter(string label)
		{
		}

		// Token: 0x06005080 RID: 20608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005080")]
		[Address(RVA = "0x7E3770", Offset = "0x7E2170", VA = "0x1807E3770")]
		public void SetWorldOverlay(GameObject overlayGameObject, string characterLabel, string label, float transitionDuration, bool uiMode, bool tutorialMode, bool needToInstantiate)
		{
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005081")]
		[Address(RVA = "0x7E3460", Offset = "0x7E1E60", VA = "0x1807E3460")]
		public void SetWorldOverlay(GameObject overlayGameObject, Vector2 worldPosition, string label, float transitionDuration, bool uiMode, bool tutorialMode, bool needToInstantiate)
		{
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005082")]
		[Address(RVA = "0x7E4650", Offset = "0x7E3050", VA = "0x1807E4650")]
		public void TriggerWorldOverlayAnimation(string label, string trigger)
		{
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005083")]
		[Address(RVA = "0x7E26F0", Offset = "0x7E10F0", VA = "0x1807E26F0")]
		public void RemoveWorldOverlay(string label, float duration, bool needDestroy = true)
		{
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005084")]
		[Address(RVA = "0x7E2290", Offset = "0x7E0C90", VA = "0x1807E2290")]
		public void OpenLockedPannel(GameObject pannelObject, Action onFinish)
		{
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005085")]
		[Address(RVA = "0x7E2350", Offset = "0x7E0D50", VA = "0x1807E2350")]
		public void OpenLogicBranchUISelectionPanel(GameObject panelObject, Action<bool> onFinish)
		{
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005086")]
		[Address(RVA = "0x7E0780", Offset = "0x7DF180", VA = "0x1807E0780")]
		public void Delay(float seconds, Action onFinish)
		{
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005087")]
		[Address(RVA = "0x7E4AE0", Offset = "0x7E34E0", VA = "0x1807E4AE0")]
		public SceneDirector()
		{
		}

		// Token: 0x04004B43 RID: 19267
		[Token(Token = "0x4004B43")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<bool> OnEventPlayStatusUpdateCallback;

		// Token: 0x04004B44 RID: 19268
		[Token(Token = "0x4004B44")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly WaitForFixedUpdate s_WaitForFixedUpdate;

		// Token: 0x04004B45 RID: 19269
		[Token(Token = "0x4004B45")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlayableDirector playableDirector;

		// Token: 0x04004B46 RID: 19270
		[Token(Token = "0x4004B46")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material spritesDefaultMaterial;

		// Token: 0x04004B47 RID: 19271
		[Token(Token = "0x4004B47")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Material spritesTransparentMaterial;

		// Token: 0x04004B48 RID: 19272
		[Token(Token = "0x4004B48")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<string, GameObject> cachedOverrideScene;

		// Token: 0x04004B49 RID: 19273
		[Token(Token = "0x4004B49")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly Dictionary<string, CharacterControllerUnit> characterCollection;

		// Token: 0x04004B4A RID: 19274
		[Token(Token = "0x4004B4A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Stack<string> m_SceneGC;

		// Token: 0x04004B4B RID: 19275
		[Token(Token = "0x4004B4B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly Dictionary<string, GameObject> overlayCollection;

		// Token: 0x04004B4C RID: 19276
		[Token(Token = "0x4004B4C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Dictionary<string, GameObject> unmanagedOverlayCollection;

		// Token: 0x04004B4D RID: 19277
		[Token(Token = "0x4004B4D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly Dictionary<string, Action> workingCoroutines;

		// Token: 0x04004B4E RID: 19278
		[Token(Token = "0x4004B4E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly Dictionary<string, Action> unmanagedWorkingCoroutines;

		// Token: 0x04004B4F RID: 19279
		[Token(Token = "0x4004B4F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CinemachineVirtualCamera cinemachineVirtualCamera;

		// Token: 0x04004B50 RID: 19280
		[Token(Token = "0x4004B50")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private CinemachineHardLockToTarget cinemachinHardLockToTarget;

		// Token: 0x04004B51 RID: 19281
		[Token(Token = "0x4004B51")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private KeyValuePair<string, GameObject> currentActiveScene;

		// Token: 0x04004B52 RID: 19282
		[Token(Token = "0x4004B52")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform sceneTracker;

		// Token: 0x02000D5D RID: 3421
		[Token(Token = "0x2000D5D")]
		public enum Identity
		{
			// Token: 0x04004B55 RID: 19285
			[Token(Token = "0x4004B55")]
			Special,
			// Token: 0x04004B56 RID: 19286
			[Token(Token = "0x4004B56")]
			Normal
		}

		// Token: 0x02000D5E RID: 3422
		[Token(Token = "0x2000D5E")]
		public enum StaffScenePlayBackIndicator
		{
			// Token: 0x04004B58 RID: 19288
			[Token(Token = "0x4004B58")]
			Core_Normal,
			// Token: 0x04004B59 RID: 19289
			[Token(Token = "0x4004B59")]
			Core_True,
			// Token: 0x04004B5A RID: 19290
			[Token(Token = "0x4004B5A")]
			DLC1,
			// Token: 0x04004B5B RID: 19291
			[Token(Token = "0x4004B5B")]
			DLC2,
			// Token: 0x04004B5C RID: 19292
			[Token(Token = "0x4004B5C")]
			DLC3,
			// Token: 0x04004B5D RID: 19293
			[Token(Token = "0x4004B5D")]
			DLC4,
			// Token: 0x04004B5E RID: 19294
			[Token(Token = "0x4004B5E")]
			DLC5
		}

		// Token: 0x02000D5F RID: 3423
		[Token(Token = "0x2000D5F")]
		private class RuntimeHandle<T> : IAssetHandle<T>, IDisposable where T : global::UnityEngine.Object
		{
			// Token: 0x0600508A RID: 20618 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600508A")]
			public RuntimeHandle(T asset)
			{
			}

			// Token: 0x0600508B RID: 20619 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600508B")]
			public void Dispose()
			{
			}

			// Token: 0x17000B60 RID: 2912
			// (get) Token: 0x0600508C RID: 20620 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000B60")]
			public T Asset
			{
				[Token(Token = "0x600508C")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B61 RID: 2913
			// (get) Token: 0x0600508D RID: 20621 RVA: 0x0001D5E0 File Offset: 0x0001B7E0
			[Token(Token = "0x17000B61")]
			public bool IsPersistentAsset
			{
				[Token(Token = "0x600508D")]
				get
				{
					return default(bool);
				}
			}
		}
	}
}

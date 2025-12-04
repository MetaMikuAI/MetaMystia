using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020002FC RID: 764
	[Token(Token = "0x20002FC")]
	[GenerateCleanupMethod]
	public class DLC4_FlandreHomeDecorationEditorPanel : UIPanel
	{
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x00006C78 File Offset: 0x00004E78
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B3")]
		private DLC4_FlandreHomeDecorationEditorPanel.EditorType CurrentEditorType
		{
			[Token(Token = "0x6001143")]
			[Address(RVA = "0x4404F0", Offset = "0x43EEF0", VA = "0x1804404F0")]
			get
			{
				return DLC4_FlandreHomeDecorationEditorPanel.EditorType.Carpet;
			}
			[Token(Token = "0x6001144")]
			[Address(RVA = "0x937A60", Offset = "0x936460", VA = "0x180937A60")]
			set
			{
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x00006C90 File Offset: 0x00004E90
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B4")]
		public DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty? EditorFurniture
		{
			[Token(Token = "0x6001145")]
			[Address(RVA = "0x9379E0", Offset = "0x9363E0", VA = "0x1809379E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001146")]
			[Address(RVA = "0x937B00", Offset = "0x936500", VA = "0x180937B00")]
			private set
			{
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B5")]
		public FlandreHomeMap FlandreHomeMap
		{
			[Token(Token = "0x6001147")]
			[Address(RVA = "0x937A30", Offset = "0x936430", VA = "0x180937A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001148")]
			[Address(RVA = "0x937B60", Offset = "0x936560", VA = "0x180937B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x00006CA8 File Offset: 0x00004EA8
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B6")]
		public int LastStoragePageIndex
		{
			[Token(Token = "0x6001149")]
			[Address(RVA = "0x937A50", Offset = "0x936450", VA = "0x180937A50")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600114A")]
			[Address(RVA = "0x937B90", Offset = "0x936590", VA = "0x180937B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x00006CC0 File Offset: 0x00004EC0
		// (set) Token: 0x0600114C RID: 4428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001B7")]
		public DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType LastStoragePageAlbumType
		{
			[Token(Token = "0x600114B")]
			[Address(RVA = "0x937A40", Offset = "0x936440", VA = "0x180937A40")]
			[CompilerGenerated]
			get
			{
				return DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType.All;
			}
			[Token(Token = "0x600114C")]
			[Address(RVA = "0x937B80", Offset = "0x936580", VA = "0x180937B80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B8")]
		public Image OutlineArea
		{
			[Token(Token = "0x600114D")]
			[Address(RVA = "0x428D60", Offset = "0x427760", VA = "0x180428D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x00006CD8 File Offset: 0x00004ED8
		[Token(Token = "0x170001B9")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x600114E")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BA")]
		private DaySceneMap CurrentActiveMap
		{
			[Token(Token = "0x600114F")]
			[Address(RVA = "0x9379A0", Offset = "0x9363A0", VA = "0x1809379A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001150")]
		[Address(RVA = "0x934AB0", Offset = "0x9334B0", VA = "0x180934AB0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001151")]
		[Address(RVA = "0x934020", Offset = "0x932A20", VA = "0x180934020")]
		private void ConfirmChoiceStart(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001152")]
		[Address(RVA = "0x933FF0", Offset = "0x9329F0", VA = "0x180933FF0")]
		private void ConfirmChoiceEnd(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001153")]
		[Address(RVA = "0x934F60", Offset = "0x933960", VA = "0x180934F60", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001154")]
		[Address(RVA = "0x9372F0", Offset = "0x935CF0", VA = "0x1809372F0")]
		private void ReverseEditorType(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001155")]
		[Address(RVA = "0x9372F0", Offset = "0x935CF0", VA = "0x1809372F0")]
		private void ReverseEditorTypeFunc()
		{
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001156")]
		[Address(RVA = "0x933BD0", Offset = "0x9325D0", VA = "0x180933BD0")]
		private void AutoSetEditorType(bool forced)
		{
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001157")]
		[Address(RVA = "0x9330E0", Offset = "0x931AE0", VA = "0x1809330E0")]
		private void AddToDic(in FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int placedPosition)
		{
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001158")]
		[Address(RVA = "0x9364F0", Offset = "0x934EF0", VA = "0x1809364F0")]
		private void RefreshPanel(DLC4_FlandreHomeDecorationEditorPanel.RefreshType refreshType)
		{
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001159")]
		[Address(RVA = "0x937350", Offset = "0x935D50", VA = "0x180937350")]
		private void SetCurrentEditorTypeByPlacementType(FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement placementType)
		{
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600115A")]
		[Address(RVA = "0x936110", Offset = "0x934B10", VA = "0x180936110")]
		private void RefreshEditorType()
		{
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600115B")]
		[Address(RVA = "0x9345D0", Offset = "0x932FD0", VA = "0x1809345D0")]
		private void EnterNearestPoint()
		{
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600115C")]
		[Address(RVA = "0x934770", Offset = "0x933170", VA = "0x180934770")]
		private void HideCharacter()
		{
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600115D")]
		[Address(RVA = "0x936F00", Offset = "0x935900", VA = "0x180936F00")]
		private void ResetCharacter()
		{
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600115E")]
		[Address(RVA = "0x935B50", Offset = "0x934550", VA = "0x180935B50")]
		private void ProcessVirtualSelectedFurnitureElement(UIButtonSimple button, KeyValuePair<Vector2Int, Vector2Int> buttonPointPair)
		{
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600115F")]
		[Address(RVA = "0x935870", Offset = "0x934270", VA = "0x180935870")]
		private void ProcessButtonFurnitureElement(UIButtonSimple button, KeyValuePair<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty> buttonPointPair)
		{
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001160")]
		[Address(RVA = "0x937440", Offset = "0x935E40", VA = "0x180937440")]
		public void SetOutline(Sprite previewImage, Vector2 thisPairPosition)
		{
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001161")]
		[Address(RVA = "0x937390", Offset = "0x935D90", VA = "0x180937390")]
		public void SetOutlinePosition(Vector2 position)
		{
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001162")]
		[Address(RVA = "0x935860", Offset = "0x934260", VA = "0x180935860")]
		private void OpenStorage(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001163")]
		[Address(RVA = "0x9356C0", Offset = "0x9340C0", VA = "0x1809356C0")]
		private void OpenStorageFunc()
		{
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x934090", Offset = "0x932A90", VA = "0x180934090")]
		private void DeleteAllFurniture()
		{
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001165")]
		[Address(RVA = "0x935D60", Offset = "0x934760", VA = "0x180935D60")]
		public void PutNewFurniture(FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int startPosition)
		{
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001166")]
		[Address(RVA = "0x934880", Offset = "0x933280", VA = "0x180934880", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001167")]
		[Address(RVA = "0x9370C0", Offset = "0x935AC0", VA = "0x1809370C0")]
		private void ResetFurnitureColor()
		{
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001168")]
		[Address(RVA = "0x937760", Offset = "0x936160", VA = "0x180937760")]
		public IEnumerator WaitForFrameEndAndClosePanel(Action onFinish)
		{
			return null;
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001169")]
		[Address(RVA = "0x933D40", Offset = "0x932740", VA = "0x180933D40", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600116A")]
		[Address(RVA = "0x9377E0", Offset = "0x9361E0", VA = "0x1809377E0")]
		public DLC4_FlandreHomeDecorationEditorPanel()
		{
		}

		// Token: 0x04001010 RID: 4112
		[Token(Token = "0x4001010")]
		private const string SPAWN_MARKET_LABEL = "DLC4_ScarletMansionBasement";

		// Token: 0x04001011 RID: 4113
		[Token(Token = "0x4001011")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string flandreHomeMapLabel;

		// Token: 0x04001012 RID: 4114
		[Token(Token = "0x4001012")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DLC4_FlandreHomeDecorationStorageTabPanel m_StorageTabPanel;

		// Token: 0x04001013 RID: 4115
		[Token(Token = "0x4001013")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private DLC4_FlandreHomeDecorationEditorSubPanel m_PutPanel;

		// Token: 0x04001014 RID: 4116
		[Token(Token = "0x4001014")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIButtonSimple m_StorageButton;

		// Token: 0x04001015 RID: 4117
		[Token(Token = "0x4001015")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIButtonSimple m_SwitchButton;

		// Token: 0x04001016 RID: 4118
		[Token(Token = "0x4001016")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIButtonHold m_DeleteAllButton;

		// Token: 0x04001017 RID: 4119
		[Token(Token = "0x4001017")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject furnitureElement;

		// Token: 0x04001018 RID: 4120
		[Token(Token = "0x4001018")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject furnitureButtonElement;

		// Token: 0x04001019 RID: 4121
		[Token(Token = "0x4001019")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private TextMeshProUGUI switchText;

		// Token: 0x0400101A RID: 4122
		[Token(Token = "0x400101A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Image outlineArea;

		// Token: 0x0400101B RID: 4123
		[Token(Token = "0x400101B")]
		[FieldOffset(Offset = "0xC0")]
		[FormerlySerializedAs("furnitureVirtualButtonContent")]
		[SerializeField]
		private RectTransform m_FurnitureVirtualButtonContent;

		// Token: 0x0400101C RID: 4124
		[Token(Token = "0x400101C")]
		[FieldOffset(Offset = "0xC8")]
		[FormerlySerializedAs("furnitureContent")]
		[SerializeField]
		private RectTransform m_FurnitureContent;

		// Token: 0x0400101D RID: 4125
		[Token(Token = "0x400101D")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private DLC4_FlandreHomeDecorationEditorPanel.EditorType currentEditorType;

		// Token: 0x0400101E RID: 4126
		[Token(Token = "0x400101E")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private bool subPanelHasOpened;

		// Token: 0x0400101F RID: 4127
		[Token(Token = "0x400101F")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty? m_EditorFurniture;

		// Token: 0x04001020 RID: 4128
		[Token(Token = "0x4001020")]
		[FieldOffset(Offset = "0x148")]
		private readonly List<GameObject> allButtonInstances2;

		// Token: 0x04001021 RID: 4129
		[Token(Token = "0x4001021")]
		[FieldOffset(Offset = "0x150")]
		private readonly List<GameObject> allVirtualInstances;

		// Token: 0x04001022 RID: 4130
		[Token(Token = "0x4001022")]
		[FieldOffset(Offset = "0x158")]
		private DLC4_FlandreHomeDecorationEditorSubPanel _subPutPanel;

		// Token: 0x04001023 RID: 4131
		[Token(Token = "0x4001023")]
		[FieldOffset(Offset = "0x160")]
		private DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets carpetFurnitureSets;

		// Token: 0x04001024 RID: 4132
		[Token(Token = "0x4001024")]
		[FieldOffset(Offset = "0x168")]
		private UIButtonSimple currentButton;

		// Token: 0x04001025 RID: 4133
		[Token(Token = "0x4001025")]
		[FieldOffset(Offset = "0x170")]
		private Vector2Int currentButtonPosition;

		// Token: 0x04001026 RID: 4134
		[Token(Token = "0x4001026")]
		[FieldOffset(Offset = "0x178")]
		private Canvas furnitureContentCanvas;

		// Token: 0x04001027 RID: 4135
		[Token(Token = "0x4001027")]
		[FieldOffset(Offset = "0x180")]
		private Canvas furnitureVirtualButtonContentCanvas;

		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		[FieldOffset(Offset = "0x188")]
		private DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets groundFurnitureSets;

		// Token: 0x04001029 RID: 4137
		[Token(Token = "0x4001029")]
		[FieldOffset(Offset = "0x190")]
		private bool hasAnyCarpet;

		// Token: 0x0400102A RID: 4138
		[Token(Token = "0x400102A")]
		[FieldOffset(Offset = "0x191")]
		private bool hasAnyGround;

		// Token: 0x0400102B RID: 4139
		[Token(Token = "0x400102B")]
		[FieldOffset(Offset = "0x198")]
		private UILogicalGroupT<Vector2Int> m_PlacedFurnitureGroup;

		// Token: 0x0400102C RID: 4140
		[Token(Token = "0x400102C")]
		[FieldOffset(Offset = "0x1A0")]
		private Camera mainCamera;

		// Token: 0x0400102D RID: 4141
		[Token(Token = "0x400102D")]
		[FieldOffset(Offset = "0x1A8")]
		private float oldClockAlpha;

		// Token: 0x0400102E RID: 4142
		[Token(Token = "0x400102E")]
		[FieldOffset(Offset = "0x1B0")]
		private TrackedNPC.OverridePosition oldPosition;

		// Token: 0x0400102F RID: 4143
		[Token(Token = "0x400102F")]
		[FieldOffset(Offset = "0x1B8")]
		private Canvas outlineCanvas;

		// Token: 0x04001030 RID: 4144
		[Token(Token = "0x4001030")]
		[FieldOffset(Offset = "0x1C0")]
		private Dictionary<int, DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets> placementRetrievalDictionary;

		// Token: 0x04001031 RID: 4145
		[Token(Token = "0x4001031")]
		[FieldOffset(Offset = "0x1C8")]
		private Dictionary<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty> selectableButtons;

		// Token: 0x04001032 RID: 4146
		[Token(Token = "0x4001032")]
		[FieldOffset(Offset = "0x1D0")]
		private Dictionary<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty> unselectableButtons;

		// Token: 0x04001033 RID: 4147
		[Token(Token = "0x4001033")]
		[FieldOffset(Offset = "0x1D8")]
		private DLC4_FlandreHomeDecorationEditorPanel.FlandreHomeFurniturePlacementSets wallFurnitureSets;

		// Token: 0x020002FD RID: 765
		[Token(Token = "0x20002FD")]
		public enum RefreshType
		{
			// Token: 0x04001038 RID: 4152
			[Token(Token = "0x4001038")]
			OnOpen,
			// Token: 0x04001039 RID: 4153
			[Token(Token = "0x4001039")]
			EditorCompleted,
			// Token: 0x0400103A RID: 4154
			[Token(Token = "0x400103A")]
			EditorCanceled,
			// Token: 0x0400103B RID: 4155
			[Token(Token = "0x400103B")]
			ClearAll,
			// Token: 0x0400103C RID: 4156
			[Token(Token = "0x400103C")]
			SwitchEditorMode
		}

		// Token: 0x020002FE RID: 766
		[Token(Token = "0x20002FE")]
		private class FlandreHomeFurniturePlacementSets
		{
			// Token: 0x0600116E RID: 4462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600116E")]
			[Address(RVA = "0x943750", Offset = "0x942150", VA = "0x180943750")]
			public FlandreHomeFurniturePlacementSets(FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement placementType)
			{
			}

			// Token: 0x170001BB RID: 443
			// (get) Token: 0x0600116F RID: 4463 RVA: 0x00006D08 File Offset: 0x00004F08
			[Token(Token = "0x170001BB")]
			public FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement PlacementType
			{
				[Token(Token = "0x600116F")]
				[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
				[CompilerGenerated]
				get
				{
					return FlandreHomeFurnitureProfile.FlandreHomeFurniture.Placement.Ground;
				}
			}

			// Token: 0x170001BC RID: 444
			// (get) Token: 0x06001170 RID: 4464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170001BC")]
			public Dictionary<Vector2Int, Vector2Int> VirtualFurnitureDic
			{
				[Token(Token = "0x6001170")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170001BD RID: 445
			// (get) Token: 0x06001171 RID: 4465 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170001BD")]
			public Dictionary<Vector2Int, DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty> ButtonFurnitureDic
			{
				[Token(Token = "0x6001171")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170001BE RID: 446
			// (get) Token: 0x06001172 RID: 4466 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170001BE")]
			public IEnumerable<FlandreFurnitureComponent> AllFurnitureComponent
			{
				[Token(Token = "0x6001172")]
				[Address(RVA = "0x943830", Offset = "0x942230", VA = "0x180943830")]
				get
				{
					return null;
				}
			}

			// Token: 0x06001173 RID: 4467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001173")]
			[Address(RVA = "0x9436E0", Offset = "0x9420E0", VA = "0x1809436E0")]
			public void ClearAllDic()
			{
			}
		}

		// Token: 0x02000300 RID: 768
		[Token(Token = "0x2000300")]
		public struct EditorFurnitureProperty
		{
			// Token: 0x06001177 RID: 4471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001177")]
			[Address(RVA = "0x941BC0", Offset = "0x9405C0", VA = "0x180941BC0")]
			public EditorFurnitureProperty(FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture, Vector2Int memoryPosition, Vector2Int[] buttonPositionList, FlandreFurnitureComponent targetFurnitureInstance)
			{
			}

			// Token: 0x06001178 RID: 4472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001178")]
			[Address(RVA = "0x941BB0", Offset = "0x9405B0", VA = "0x180941BB0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04001042 RID: 4162
			[Token(Token = "0x4001042")]
			[FieldOffset(Offset = "0x0")]
			public FlandreHomeFurnitureProfile.FlandreHomeFurniture Furniture;

			// Token: 0x04001043 RID: 4163
			[Token(Token = "0x4001043")]
			[FieldOffset(Offset = "0x48")]
			public Vector2Int MemoryPosition;

			// Token: 0x04001044 RID: 4164
			[Token(Token = "0x4001044")]
			[FieldOffset(Offset = "0x50")]
			public Vector2Int[] ButtonPositionList;

			// Token: 0x04001045 RID: 4165
			[Token(Token = "0x4001045")]
			[FieldOffset(Offset = "0x58")]
			public FlandreFurnitureComponent TargetFurnitureInstance;

			// Token: 0x04001046 RID: 4166
			[Token(Token = "0x4001046")]
			[FieldOffset(Offset = "0x60")]
			public Vector2Int CenterPoint;
		}

		// Token: 0x02000303 RID: 771
		[Token(Token = "0x2000303")]
		private enum EditorType
		{
			// Token: 0x0400104E RID: 4174
			[Token(Token = "0x400104E")]
			Carpet,
			// Token: 0x0400104F RID: 4175
			[Token(Token = "0x400104F")]
			Ground
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace DayScene.UI
{
	// Token: 0x0200030B RID: 779
	[Token(Token = "0x200030B")]
	[GenerateCleanupMethod]
	public class DLC4_FlandreHomeDecorationEditorSubPanel : UISubPanel<DLC4_FlandreHomeDecorationEditorPanel>
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00006E28 File Offset: 0x00005028
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C1")]
		public Vector2Int? EndPosition
		{
			[Token(Token = "0x60011A3")]
			[Address(RVA = "0x939E50", Offset = "0x938850", VA = "0x180939E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60011A4")]
			[Address(RVA = "0x939FF0", Offset = "0x9389F0", VA = "0x180939FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00006E40 File Offset: 0x00005040
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C2")]
		public DLC4_FlandreHomeDecorationEditorPanel.RefreshType ParentRefreshType
		{
			[Token(Token = "0x60011A5")]
			[Address(RVA = "0x440440", Offset = "0x43EE40", VA = "0x180440440")]
			[CompilerGenerated]
			get
			{
				return DLC4_FlandreHomeDecorationEditorPanel.RefreshType.OnOpen;
			}
			[Token(Token = "0x60011A6")]
			[Address(RVA = "0x93A010", Offset = "0x938A10", VA = "0x18093A010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C3")]
		private Transform SpawnedFurnitureTransform
		{
			[Token(Token = "0x60011A7")]
			[Address(RVA = "0x939FC0", Offset = "0x9389C0", VA = "0x180939FC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00006E58 File Offset: 0x00005058
		[Token(Token = "0x170001C4")]
		private DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty OpenContext
		{
			[Token(Token = "0x60011A8")]
			[Address(RVA = "0x939E70", Offset = "0x938870", VA = "0x180939E70")]
			get
			{
				return default(DLC4_FlandreHomeDecorationEditorPanel.EditorFurnitureProperty);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x00006E70 File Offset: 0x00005070
		[Token(Token = "0x170001C5")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x60011A9")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AA")]
		[Address(RVA = "0x938890", Offset = "0x937290", VA = "0x180938890", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AB")]
		[Address(RVA = "0x938B60", Offset = "0x937560", VA = "0x180938B60", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AC")]
		[Address(RVA = "0x939630", Offset = "0x938030", VA = "0x180939630")]
		private void RefreshFurniturePositionBuffer()
		{
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AD")]
		[Address(RVA = "0x937EF0", Offset = "0x9368F0", VA = "0x180937EF0")]
		private void MoveFurniture(InputAction.CallbackContext x)
		{
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00006E88 File Offset: 0x00005088
		[Token(Token = "0x60011AE")]
		[Address(RVA = "0x937BA0", Offset = "0x9365A0", VA = "0x180937BA0")]
		private bool CheckBorder(MoveDirection moveDirection, int multi)
		{
			return default(bool);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011AF")]
		[Address(RVA = "0x939AA0", Offset = "0x9384A0", VA = "0x180939AA0")]
		private void TryOverridePosition(InputAction.CallbackContext input)
		{
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B0")]
		[Address(RVA = "0x9397A0", Offset = "0x9381A0", VA = "0x1809397A0")]
		private void TryOverridePositionFunc()
		{
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B1")]
		[Address(RVA = "0x938460", Offset = "0x936E60", VA = "0x180938460")]
		private void OnDragEnd()
		{
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B2")]
		[Address(RVA = "0x939720", Offset = "0x938120", VA = "0x180939720")]
		private IEnumerator TryDrag()
		{
			return null;
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B3")]
		[Address(RVA = "0x939C50", Offset = "0x938650", VA = "0x180939C50")]
		private void TryPutDown(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B4")]
		[Address(RVA = "0x939AB0", Offset = "0x9384B0", VA = "0x180939AB0")]
		private void TryPutDownFunc()
		{
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B5")]
		[Address(RVA = "0x937E40", Offset = "0x936840", VA = "0x180937E40")]
		private void Delete(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B6")]
		[Address(RVA = "0x937E40", Offset = "0x936840", VA = "0x180937E40")]
		private void DeleteFunc()
		{
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011B7")]
		[Address(RVA = "0x939CC0", Offset = "0x9386C0", VA = "0x180939CC0")]
		private IEnumerator WaitForFrameEndAndClosePanel()
		{
			return null;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00006EA0 File Offset: 0x000050A0
		[Token(Token = "0x60011B8")]
		[Address(RVA = "0x937C10", Offset = "0x936610", VA = "0x180937C10")]
		private bool CheckCanMoveToTargetPosition(Vector2Int finalPointPosition)
		{
			return default(bool);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011B9")]
		[Address(RVA = "0x938120", Offset = "0x936B20", VA = "0x180938120")]
		private void MoveToNewPlace(Vector2Int newPosition)
		{
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011BA")]
		[Address(RVA = "0x9384B0", Offset = "0x936EB0", VA = "0x1809384B0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011BB")]
		[Address(RVA = "0x937D60", Offset = "0x936760", VA = "0x180937D60", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011BC")]
		[Address(RVA = "0x939DB0", Offset = "0x9387B0", VA = "0x180939DB0")]
		public DLC4_FlandreHomeDecorationEditorSubPanel()
		{
		}

		// Token: 0x0400106D RID: 4205
		[Token(Token = "0x400106D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector2Int m_CurrentPosition;

		// Token: 0x0400106E RID: 4206
		[Token(Token = "0x400106E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool canSetHere;

		// Token: 0x0400106F RID: 4207
		[Token(Token = "0x400106F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIButtonSimple m_DeleteButton;

		// Token: 0x04001070 RID: 4208
		[Token(Token = "0x4001070")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIButtonSimple m_ConfirmButton;

		// Token: 0x04001071 RID: 4209
		[Token(Token = "0x4001071")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool NewlyPlaced;

		// Token: 0x04001072 RID: 4210
		[Token(Token = "0x4001072")]
		[FieldOffset(Offset = "0xA0")]
		private readonly HashSet<Vector2Int> m_RefreshBuffer;

		// Token: 0x04001073 RID: 4211
		[Token(Token = "0x4001073")]
		[FieldOffset(Offset = "0xA8")]
		private HashSet<Vector2Int> availableGrid;

		// Token: 0x04001074 RID: 4212
		[Token(Token = "0x4001074")]
		[FieldOffset(Offset = "0xB0")]
		private Coroutine dragCoroutine;

		// Token: 0x04001075 RID: 4213
		[Token(Token = "0x4001075")]
		[FieldOffset(Offset = "0xB8")]
		private int gridDownBorder;

		// Token: 0x04001076 RID: 4214
		[Token(Token = "0x4001076")]
		[FieldOffset(Offset = "0xBC")]
		private int gridLeftBorder;

		// Token: 0x04001077 RID: 4215
		[Token(Token = "0x4001077")]
		[FieldOffset(Offset = "0xC0")]
		private int gridRightBorder;

		// Token: 0x04001078 RID: 4216
		[Token(Token = "0x4001078")]
		[FieldOffset(Offset = "0xC4")]
		private int gridUpBorder;

		// Token: 0x04001079 RID: 4217
		[Token(Token = "0x4001079")]
		[FieldOffset(Offset = "0xC8")]
		private Vector2Int[] m_FurniturePositionBuffer;

		// Token: 0x0400107A RID: 4218
		[Token(Token = "0x400107A")]
		[FieldOffset(Offset = "0xD0")]
		private FlandreFurnitureComponent spawnedFurniture;
	}
}

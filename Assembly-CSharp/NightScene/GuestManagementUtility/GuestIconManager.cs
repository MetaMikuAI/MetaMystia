using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x02000593 RID: 1427
	[Token(Token = "0x2000593")]
	public class GuestIconManager
	{
		// Token: 0x0600209B RID: 8347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600209B")]
		[Address(RVA = "0x4D39B0", Offset = "0x4D23B0", VA = "0x1804D39B0")]
		public GuestIconManager(MonoBehaviour monoBehaviour, Canvas uiContainer, GameObject awaitPrototype, GameObject eatPrototype, GameObject serveInWorkMissionPrototype, GameObject hateFoodTagPrototype, AudioClip hateFoodTagAudio)
		{
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209C")]
		[Address(RVA = "0x4D38C0", Offset = "0x4D22C0", VA = "0x1804D38C0")]
		private IEnumerator UpdateIcon()
		{
			return null;
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600209D")]
		[Address(RVA = "0x4D2760", Offset = "0x4D1160", VA = "0x1804D2760")]
		public void Add(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x0000C258 File Offset: 0x0000A458
		[Token(Token = "0x600209E")]
		[Address(RVA = "0x4D2D40", Offset = "0x4D1740", VA = "0x1804D2D40")]
		public bool Remove(GuestGroupController guestGroupController)
		{
			return default(bool);
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600209F")]
		[Address(RVA = "0x4D3660", Offset = "0x4D2060", VA = "0x1804D3660")]
		public void SwitchState(GuestGroupController guestGroupController, GuestState state)
		{
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A0")]
		[Address(RVA = "0x4D3270", Offset = "0x4D1C70", VA = "0x1804D3270")]
		public void ShowHateFoodTag(GuestGroupController guestGroupController, string tagName)
		{
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A1")]
		[Address(RVA = "0x4D2AD0", Offset = "0x4D14D0", VA = "0x1804D2AD0")]
		private void InstantiateGameObjects(ref GuestIcon guestIcon)
		{
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A2")]
		[Address(RVA = "0x4D2F00", Offset = "0x4D1900", VA = "0x1804D2F00")]
		private void SetGameObjectsActive(GameObject[] gameObjects, bool value)
		{
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A3")]
		[Address(RVA = "0x4D2FC0", Offset = "0x4D19C0", VA = "0x1804D2FC0")]
		private void SetGameObjectsPosition(GameObject[] gameObjects, GuestGroupController guestGroupController, GuestState guestState)
		{
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A4")]
		[Address(RVA = "0x4D29D0", Offset = "0x4D13D0", VA = "0x1804D29D0")]
		private void DestroyGameObjects(GameObject[] gameObjects)
		{
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x0000C270 File Offset: 0x0000A470
		[Token(Token = "0x60020A5")]
		[Address(RVA = "0x4D3940", Offset = "0x4D2340", VA = "0x1804D3940")]
		private Vector3 WorldPositionToUIPosition(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		// Token: 0x04001DA8 RID: 7592
		[Token(Token = "0x4001DA8")]
		private const float STATE_ICON_OFFSET = 1.55f;

		// Token: 0x04001DA9 RID: 7593
		[Token(Token = "0x4001DA9")]
		[FieldOffset(Offset = "0x10")]
		private readonly GameObject awaitPrototype;

		// Token: 0x04001DAA RID: 7594
		[Token(Token = "0x4001DAA")]
		[FieldOffset(Offset = "0x18")]
		private readonly GameObject eatPrototype;

		// Token: 0x04001DAB RID: 7595
		[Token(Token = "0x4001DAB")]
		[FieldOffset(Offset = "0x20")]
		private readonly GameObject serveInWorkMissionPrototype;

		// Token: 0x04001DAC RID: 7596
		[Token(Token = "0x4001DAC")]
		[FieldOffset(Offset = "0x28")]
		private readonly Dictionary<GuestGroupController, List<GuestIconOverride>> guestIconBuffer;

		// Token: 0x04001DAD RID: 7597
		[Token(Token = "0x4001DAD")]
		[FieldOffset(Offset = "0x30")]
		private readonly Dictionary<GuestGroupController, GuestIcon> guests;

		// Token: 0x04001DAE RID: 7598
		[Token(Token = "0x4001DAE")]
		[FieldOffset(Offset = "0x38")]
		private readonly AudioClip hateFoodTagAudio;

		// Token: 0x04001DAF RID: 7599
		[Token(Token = "0x4001DAF")]
		[FieldOffset(Offset = "0x40")]
		private readonly GameObject hateFoodTagPrototype;

		// Token: 0x04001DB0 RID: 7600
		[Token(Token = "0x4001DB0")]
		[FieldOffset(Offset = "0x48")]
		private readonly Vector3 iconOffset;

		// Token: 0x04001DB1 RID: 7601
		[Token(Token = "0x4001DB1")]
		[FieldOffset(Offset = "0x58")]
		private readonly Canvas uiContainer;
	}
}

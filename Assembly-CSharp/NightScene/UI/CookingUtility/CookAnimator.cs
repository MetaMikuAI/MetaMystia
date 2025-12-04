using System;
using System.Collections.Generic;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Tilemaps;

namespace NightScene.UI.CookingUtility
{
	// Token: 0x0200070A RID: 1802
	[Token(Token = "0x200070A")]
	[GenerateCleanupMethod]
	public class CookAnimator : MonoBehaviour
	{
		// Token: 0x06002A94 RID: 10900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A94")]
		[Address(RVA = "0x57F760", Offset = "0x57E160", VA = "0x18057F760")]
		private void Reset()
		{
		}

		// Token: 0x06002A95 RID: 10901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A95")]
		[Address(RVA = "0x57FF70", Offset = "0x57E970", VA = "0x18057FF70")]
		private void Update()
		{
		}

		// Token: 0x06002A96 RID: 10902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A96")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002A97 RID: 10903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A97")]
		[Address(RVA = "0x57F650", Offset = "0x57E050", VA = "0x18057F650")]
		public void Initialize(Cooker cookerInfo, Vector3 cookerWorldPosition)
		{
		}

		// Token: 0x06002A98 RID: 10904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A98")]
		[Address(RVA = "0x57F8E0", Offset = "0x57E2E0", VA = "0x18057F8E0")]
		public void SetAnimator(AnimatedTile idle, AnimatedTile loaded, AnimatedTile cooking)
		{
		}

		// Token: 0x06002A99 RID: 10905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A99")]
		[Address(RVA = "0x57F620", Offset = "0x57E020", VA = "0x18057F620")]
		public void HideCookerPermanent()
		{
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9A")]
		[Address(RVA = "0x57F730", Offset = "0x57E130", VA = "0x18057F730")]
		public void RecoverCookerPermanent()
		{
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9B")]
		[Address(RVA = "0x57F940", Offset = "0x57E340", VA = "0x18057F940")]
		public void SetState(CookController.CookPhase phase)
		{
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9C")]
		[Address(RVA = "0x57FB70", Offset = "0x57E570", VA = "0x18057FB70")]
		private void UpdateLights(CookController.CookPhase currentPhase)
		{
		}

		// Token: 0x06002A9D RID: 10909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9D")]
		[Address(RVA = "0x57FE90", Offset = "0x57E890", VA = "0x18057FE90")]
		private void UpdateSprites(CookController.CookPhase currentPhase)
		{
		}

		// Token: 0x06002A9E RID: 10910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9E")]
		[Address(RVA = "0x57F970", Offset = "0x57E370", VA = "0x18057F970")]
		private void UpdateAnimatedTile(AnimatedTile tile, ref float nextUpdate, ref int? nextIndex)
		{
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A9F")]
		[Address(RVA = "0x57F5B0", Offset = "0x57DFB0", VA = "0x18057F5B0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002AA0")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public CookAnimator()
		{
		}

		// Token: 0x0400270F RID: 9999
		[Token(Token = "0x400270F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpriteRenderer m_CookerSpriteRenderer;

		// Token: 0x04002710 RID: 10000
		[Token(Token = "0x4002710")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("cookerLight")]
		private List<SpriteRenderer> m_CookerLight;

		// Token: 0x04002711 RID: 10001
		[Token(Token = "0x4002711")]
		[FieldOffset(Offset = "0x28")]
		private AnimatedTile m_Cooking;

		// Token: 0x04002712 RID: 10002
		[Token(Token = "0x4002712")]
		[FieldOffset(Offset = "0x30")]
		private CookController.CookPhase m_CookingPhase;

		// Token: 0x04002713 RID: 10003
		[Token(Token = "0x4002713")]
		[FieldOffset(Offset = "0x34")]
		private int? m_CurrentAnimatedTileFrameIndex;

		// Token: 0x04002714 RID: 10004
		[Token(Token = "0x4002714")]
		[FieldOffset(Offset = "0x40")]
		private AnimatedTile m_Idle;

		// Token: 0x04002715 RID: 10005
		[Token(Token = "0x4002715")]
		[FieldOffset(Offset = "0x48")]
		private bool m_Initialized;

		// Token: 0x04002716 RID: 10006
		[Token(Token = "0x4002716")]
		[FieldOffset(Offset = "0x4C")]
		private float m_LightIntensity;

		// Token: 0x04002717 RID: 10007
		[Token(Token = "0x4002717")]
		[FieldOffset(Offset = "0x50")]
		private AnimatedTile m_Loaded;

		// Token: 0x04002718 RID: 10008
		[Token(Token = "0x4002718")]
		[FieldOffset(Offset = "0x58")]
		private float m_NextAnimatedTileUpdateDelta;
	}
}

using System;
using Common.CharacterUtility;
using DayScene.Input;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using NightScene.PartnerUtility;
using NightScene.Tiles;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CDA RID: 3290
	[Token(Token = "0x2000CDA")]
	[CreateAssetMenu(fileName = "PartnerInfoSakuya", menuName = "GameData Profile/PartnerInfoCollection/PartnerInfoSakuya", order = 3)]
	public sealed class PartnerInfoSakuya : PartnerInfoBase
	{
		// Token: 0x06004C76 RID: 19574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C76")]
		[Address(RVA = "0x79ECD0", Offset = "0x79D6D0", VA = "0x18079ECD0", Slot = "17")]
		public override void MoveCharacter(AStarInputGeneratorComponent controlledCharacter, TileManager tileManager, Vector3Int dest, Vector3 extraOffset, DayScenePlayerInputGenerator.CharacterRotation onArrivalRotation, Action onArrivalCallback, PartnerManager manager, bool useCollision, ref object additionalData)
		{
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C77")]
		[Address(RVA = "0x79EC00", Offset = "0x79D600", VA = "0x18079EC00", Slot = "18")]
		public override void ExternalStop(AStarInputGeneratorComponent controlledCharacter, PartnerManager manager, ref object partnerMovementAdditionData)
		{
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x0001BAC8 File Offset: 0x00019CC8
		[Token(Token = "0x6004C78")]
		[Address(RVA = "0x79EE90", Offset = "0x79D890", VA = "0x18079EE90", Slot = "11")]
		public override float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseSpeed, ref bool doNotCostIngredients)
		{
			return 0f;
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C79")]
		[Address(RVA = "0x79EC80", Offset = "0x79D680", VA = "0x18079EC80", Slot = "19")]
		protected override string GetMoveSpeedText()
		{
			return null;
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C7A")]
		[Address(RVA = "0x79ECC0", Offset = "0x79D6C0", VA = "0x18079ECC0", Slot = "20")]
		protected override string GetWorkSpeedText()
		{
			return null;
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C7B")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public PartnerInfoSakuya()
		{
		}

		// Token: 0x04004663 RID: 18019
		[Token(Token = "0x4004663")]
		[FieldOffset(Offset = "0x50")]
		public float blinkDuration;

		// Token: 0x04004664 RID: 18020
		[Token(Token = "0x4004664")]
		[FieldOffset(Offset = "0x58")]
		public GameObject teleportEffectStart;

		// Token: 0x04004665 RID: 18021
		[Token(Token = "0x4004665")]
		[FieldOffset(Offset = "0x60")]
		public GameObject teleportEffectEnd;

		// Token: 0x04004666 RID: 18022
		[Token(Token = "0x4004666")]
		[FieldOffset(Offset = "0x68")]
		public AudioClip sakuyaTeleportSFX;

		// Token: 0x04004667 RID: 18023
		[Token(Token = "0x4004667")]
		[FieldOffset(Offset = "0x70")]
		public bool instantCook;
	}
}

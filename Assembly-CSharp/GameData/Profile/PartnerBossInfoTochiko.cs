using System;
using Common.CharacterUtility;
using DayScene.Input;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using NightScene.Tiles;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CBA RID: 3258
	[Token(Token = "0x2000CBA")]
	[CreateAssetMenu(fileName = "DLC3_PartnerBossInfo_Tochiko", menuName = "GameData Profile/PartnerInfoCollection/Boss/DLC3_Tochiko", order = 2)]
	public class PartnerBossInfoTochiko : PartnerBossInfo
	{
		// Token: 0x06004BD8 RID: 19416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD8")]
		[Address(RVA = "0x799940", Offset = "0x798340", VA = "0x180799940", Slot = "17")]
		public override void MoveCharacter(AStarInputGeneratorComponent controlledCharacter, TileManager tileManager, Vector3Int dest, Vector3 extraOffset, DayScenePlayerInputGenerator.CharacterRotation onArrivalRotation, Action onArrivalCallback, PartnerManager manager, bool useCollision, ref object additionalData)
		{
		}

		// Token: 0x06004BD9 RID: 19417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD9")]
		[Address(RVA = "0x799560", Offset = "0x797F60", VA = "0x180799560", Slot = "18")]
		public override void ExternalStop(AStarInputGeneratorComponent controlledCharacter, PartnerManager manager, ref object partnerMovementAdditionData)
		{
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BDA")]
		[Address(RVA = "0x7993F0", Offset = "0x797DF0", VA = "0x1807993F0", Slot = "25")]
		public override void BossSpecialAbilityPreLoad(PartnerBase currentPartner, EventManager eventManager, PartnerManager manager, object[] additionalData)
		{
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x0001B618 File Offset: 0x00019818
		[Token(Token = "0x6004BDB")]
		[Address(RVA = "0x79A040", Offset = "0x798A40", VA = "0x18079A040", Slot = "11")]
		public override float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseTime, ref bool doNotCostIngredients)
		{
			return 0f;
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BDC")]
		[Address(RVA = "0x7998E0", Offset = "0x7982E0", VA = "0x1807998E0", Slot = "24")]
		public override string GetBossSpecialSkill()
		{
			return null;
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BDD")]
		[Address(RVA = "0x79A0F0", Offset = "0x798AF0", VA = "0x18079A0F0")]
		public PartnerBossInfoTochiko()
		{
		}

		// Token: 0x040045C7 RID: 17863
		[Token(Token = "0x40045C7")]
		private const int MAX_THUNDER_NUM = 4;

		// Token: 0x040045C8 RID: 17864
		[Token(Token = "0x40045C8")]
		[FieldOffset(Offset = "0x80")]
		public GameObject thunderWarning;

		// Token: 0x040045C9 RID: 17865
		[Token(Token = "0x40045C9")]
		[FieldOffset(Offset = "0x88")]
		public GameObject thunderEffect;

		// Token: 0x040045CA RID: 17866
		[Token(Token = "0x40045CA")]
		[FieldOffset(Offset = "0x90")]
		public GameObject notEffectiveEffect;

		// Token: 0x040045CB RID: 17867
		[Token(Token = "0x40045CB")]
		[FieldOffset(Offset = "0x98")]
		public GameObject teleportEffect;

		// Token: 0x040045CC RID: 17868
		[Token(Token = "0x40045CC")]
		[FieldOffset(Offset = "0xA0")]
		public int thunderInterval;

		// Token: 0x040045CD RID: 17869
		[Token(Token = "0x40045CD")]
		[FieldOffset(Offset = "0xA4")]
		public int thunderDelay;

		// Token: 0x040045CE RID: 17870
		[Token(Token = "0x40045CE")]
		[FieldOffset(Offset = "0xA8")]
		public int thunderRadius;

		// Token: 0x040045CF RID: 17871
		[Token(Token = "0x40045CF")]
		[FieldOffset(Offset = "0xAC")]
		public int stunDuration;

		// Token: 0x040045D0 RID: 17872
		[Token(Token = "0x40045D0")]
		[FieldOffset(Offset = "0xB0")]
		public float blinkDuration;

		// Token: 0x040045D1 RID: 17873
		[Token(Token = "0x40045D1")]
		[FieldOffset(Offset = "0xB4")]
		public float teleportRate;

		// Token: 0x040045D2 RID: 17874
		[Token(Token = "0x40045D2")]
		[FieldOffset(Offset = "0xB8")]
		public AudioClip thunderSFX;

		// Token: 0x040045D3 RID: 17875
		[Token(Token = "0x40045D3")]
		[FieldOffset(Offset = "0xC0")]
		public AudioClip hitAunnSFX;
	}
}

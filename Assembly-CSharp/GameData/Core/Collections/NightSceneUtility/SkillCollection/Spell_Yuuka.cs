using System;
using System.Collections;
using System.Collections.Generic;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000ADE RID: 2782
	[Token(Token = "0x2000ADE")]
	[CreateAssetMenu(fileName = "DLC4_Spell_Yuuka", menuName = "Spells/DLC4/Yuuka", order = 2)]
	public class Spell_Yuuka : SpellBase
	{
		// Token: 0x060042FC RID: 17148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FC")]
		[Address(RVA = "0x720AD0", Offset = "0x71F4D0", VA = "0x180720AD0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FD")]
		[Address(RVA = "0x71F8A0", Offset = "0x71E2A0", VA = "0x18071F8A0")]
		private List<int> FindBestFitLine(Dictionary<int, Vector2> allDeskPosition, int currentDeskIndex)
		{
			return null;
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FE")]
		[Address(RVA = "0x720B00", Offset = "0x71F500", VA = "0x180720B00", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042FF")]
		[Address(RVA = "0x720B90", Offset = "0x71F590", VA = "0x180720B90", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004300")]
		[Address(RVA = "0x720C20", Offset = "0x71F620", VA = "0x180720C20")]
		private void OnYuukaSpellPowerAbsorbCallback(SpecialGuestsController specialGuestsController)
		{
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004301")]
		[Address(RVA = "0x7209B0", Offset = "0x71F3B0", VA = "0x1807209B0")]
		private void FlowerDisappear()
		{
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004302")]
		[Address(RVA = "0x720410", Offset = "0x71EE10", VA = "0x180720410")]
		private void FlowerBlossom(SpecialGuestsController specialGuestsController)
		{
		}

		// Token: 0x06004303 RID: 17155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004303")]
		[Address(RVA = "0x720C60", Offset = "0x71F660", VA = "0x180720C60")]
		private void Wither(GameObject flower)
		{
		}

		// Token: 0x06004304 RID: 17156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004304")]
		[Address(RVA = "0x720DB0", Offset = "0x71F7B0", VA = "0x180720DB0")]
		public Spell_Yuuka()
		{
		}

		// Token: 0x04003B03 RID: 15107
		[Token(Token = "0x4003B03")]
		private const string YUUKA_FLOWER_QUEUE = "Yuuka_Flower_Queue";

		// Token: 0x04003B04 RID: 15108
		[Token(Token = "0x4003B04")]
		private const string YUUKA_COMBO_CHECK = "Yuuka_Combo_Check";

		// Token: 0x04003B05 RID: 15109
		[Token(Token = "0x4003B05")]
		private const int WRIGGLE_ID = 0;

		// Token: 0x04003B06 RID: 15110
		[Token(Token = "0x4003B06")]
		private const int YUUKA_ID = 4002;

		// Token: 0x04003B07 RID: 15111
		[Token(Token = "0x4003B07")]
		[FieldOffset(Offset = "0x18")]
		public GameObject sunFlowerParent;

		// Token: 0x04003B08 RID: 15112
		[Token(Token = "0x4003B08")]
		[FieldOffset(Offset = "0x20")]
		public GameObject sunVFX;

		// Token: 0x04003B09 RID: 15113
		[Token(Token = "0x4003B09")]
		[FieldOffset(Offset = "0x28")]
		public float generateDuration;

		// Token: 0x04003B0A RID: 15114
		[Token(Token = "0x4003B0A")]
		[FieldOffset(Offset = "0x2C")]
		public float flowerSpawnDuration;

		// Token: 0x04003B0B RID: 15115
		[Token(Token = "0x4003B0B")]
		[FieldOffset(Offset = "0x30")]
		public float sunDuration;

		// Token: 0x04003B0C RID: 15116
		[Token(Token = "0x4003B0C")]
		[FieldOffset(Offset = "0x34")]
		public int giveTipNum;

		// Token: 0x04003B0D RID: 15117
		[Token(Token = "0x4003B0D")]
		[FieldOffset(Offset = "0x38")]
		public float giveTipInterval;

		// Token: 0x04003B0E RID: 15118
		[Token(Token = "0x4003B0E")]
		[FieldOffset(Offset = "0x3C")]
		public int eachBuffTriggerNeedNum;

		// Token: 0x04003B0F RID: 15119
		[Token(Token = "0x4003B0F")]
		[FieldOffset(Offset = "0x40")]
		public int extraMood;

		// Token: 0x04003B10 RID: 15120
		[Token(Token = "0x4003B10")]
		[FieldOffset(Offset = "0x44")]
		public int blossomDuration;

		// Token: 0x04003B11 RID: 15121
		[Token(Token = "0x4003B11")]
		[FieldOffset(Offset = "0x48")]
		public int specialWrigglePositiveDuration;

		// Token: 0x04003B12 RID: 15122
		[Token(Token = "0x4003B12")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_PunishmentBlasterFireDelay;

		// Token: 0x04003B13 RID: 15123
		[Token(Token = "0x4003B13")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject m_PunishmentBlaster;

		// Token: 0x04003B14 RID: 15124
		[Token(Token = "0x4003B14")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_PunishmentBlasterFireKickGuestOffset;

		// Token: 0x04003B15 RID: 15125
		[Token(Token = "0x4003B15")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_PunishmentBlasterFireLength;

		// Token: 0x04003B16 RID: 15126
		[Token(Token = "0x4003B16")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_PunishmentBlasterChargeCameraShakeAmplitude;

		// Token: 0x04003B17 RID: 15127
		[Token(Token = "0x4003B17")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_PunishmentBlasterFireCameraShakeAmplitude;

		// Token: 0x04003B18 RID: 15128
		[Token(Token = "0x4003B18")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject brokenDesk;

		// Token: 0x04003B19 RID: 15129
		[Token(Token = "0x4003B19")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject smokeVFX;

		// Token: 0x04003B1A RID: 15130
		[Token(Token = "0x4003B1A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float m_WaitForSparkEnd;

		// Token: 0x04003B1B RID: 15131
		[Token(Token = "0x4003B1B")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private float m_SmokeOffset;

		// Token: 0x04003B1C RID: 15132
		[Token(Token = "0x4003B1C")]
		[FieldOffset(Offset = "0x80")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip flowerSpawnSfx;

		// Token: 0x04003B1D RID: 15133
		[Token(Token = "0x4003B1D")]
		[FieldOffset(Offset = "0x90")]
		public SpellBase.DelayAudioClip flowerSunSfx;

		// Token: 0x04003B1E RID: 15134
		[Token(Token = "0x4003B1E")]
		[FieldOffset(Offset = "0xA0")]
		public SpellBase.DelayAudioClip flowerTipSfx;

		// Token: 0x04003B1F RID: 15135
		[Token(Token = "0x4003B1F")]
		[FieldOffset(Offset = "0xB0")]
		public SpellBase.DelayAudioClip flowerEnergySfx;

		// Token: 0x04003B20 RID: 15136
		[Token(Token = "0x4003B20")]
		[FieldOffset(Offset = "0xC0")]
		public SpellBase.DelayAudioClip negativeStartSfx;

		// Token: 0x04003B21 RID: 15137
		[Token(Token = "0x4003B21")]
		[FieldOffset(Offset = "0xD0")]
		public LoopedBGMPackage laserStartSfx;

		// Token: 0x04003B22 RID: 15138
		[Token(Token = "0x4003B22")]
		[FieldOffset(Offset = "0xD8")]
		public SpellBase.DelayAudioClip laserEndSfx;
	}
}

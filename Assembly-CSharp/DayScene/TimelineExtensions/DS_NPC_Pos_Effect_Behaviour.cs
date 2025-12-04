using System;
using System.Collections;
using Common.TimelineExtestion;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200048C RID: 1164
	[Token(Token = "0x200048C")]
	public class DS_NPC_Pos_Effect_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06001ADC RID: 6876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADC")]
		[Address(RVA = "0x498E30", Offset = "0x497830", VA = "0x180498E30")]
		public void Initialize(string characterLabel, float characterSetDelay, bool shouldWaitForFinish, string effectLabel, GameObject effectPrefab, Vector2 effectPositionOffset, float effectDestroyDelay, float effectTransitionDuration = 1f)
		{
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0x499140", Offset = "0x497B40", VA = "0x180499140", Slot = "23")]
		protected virtual bool TryGetCharacterPosition(out Vector2 position)
		{
			return default(bool);
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADE")]
		[Address(RVA = "0x498EC0", Offset = "0x4978C0", VA = "0x180498EC0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADF")]
		[Address(RVA = "0x498E20", Offset = "0x497820", VA = "0x180498E20", Slot = "24")]
		protected virtual void Execute(string characterLabel, bool timeContinue)
		{
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x498DA0", Offset = "0x4977A0", VA = "0x180498DA0")]
		private IEnumerator DestroyEffect()
		{
			return null;
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_NPC_Pos_Effect_Behaviour()
		{
		}

		// Token: 0x04001890 RID: 6288
		[Token(Token = "0x4001890")]
		[FieldOffset(Offset = "0x10")]
		private string m_CharacterLabel;

		// Token: 0x04001891 RID: 6289
		[Token(Token = "0x4001891")]
		[FieldOffset(Offset = "0x18")]
		private float m_CharacterSetDelay;

		// Token: 0x04001892 RID: 6290
		[Token(Token = "0x4001892")]
		[FieldOffset(Offset = "0x1C")]
		private float m_EffectDestroyDelay;

		// Token: 0x04001893 RID: 6291
		[Token(Token = "0x4001893")]
		[FieldOffset(Offset = "0x20")]
		private string m_EffectLabel;

		// Token: 0x04001894 RID: 6292
		[Token(Token = "0x4001894")]
		[FieldOffset(Offset = "0x28")]
		private Vector2 m_EffectPositionOffset;

		// Token: 0x04001895 RID: 6293
		[Token(Token = "0x4001895")]
		[FieldOffset(Offset = "0x30")]
		private GameObject m_EffectPrefab;

		// Token: 0x04001896 RID: 6294
		[Token(Token = "0x4001896")]
		[FieldOffset(Offset = "0x38")]
		private float m_EffectTransitionDuration;

		// Token: 0x04001897 RID: 6295
		[Token(Token = "0x4001897")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_ShouldWaitForFinish;
	}
}

using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200015E RID: 350
	[Token(Token = "0x200015E")]
	public class DLC4_BulletAyaWind : DLC4_BulletTeamLinear
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x00004158 File Offset: 0x00002358
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700009E")]
		public DLC4_GuardAya.AyaBulletProperty AyaBulletProperty
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x823400", Offset = "0x821E00", VA = "0x180823400")]
			[CompilerGenerated]
			private get
			{
				return default(DLC4_GuardAya.AyaBulletProperty);
			}
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x823420", Offset = "0x821E20", VA = "0x180823420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x823010", Offset = "0x821A10", VA = "0x180823010")]
		public void OnBulletEnable()
		{
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x823110", Offset = "0x821B10", VA = "0x180823110", Slot = "8")]
		protected override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x822F30", Offset = "0x821930", VA = "0x180822F30")]
		private void AfterHit()
		{
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		public DLC4_BulletAyaWind()
		{
		}

		// Token: 0x04000787 RID: 1927
		[Token(Token = "0x4000787")]
		[FieldOffset(Offset = "0x98")]
		private ParticleSystem particleSystem;
	}
}

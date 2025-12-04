using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	public enum BossBattleVFX
	{
		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		[InspectorName("损坏桌子")]
		TableBroken,
		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		[InspectorName("流星坠落")]
		DracoMeteor,
		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		[InspectorName("破坏神·分身状态")]
		SpawnSpiritObject,
		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		[InspectorName("花妈魔炮")]
		YukaSpark,
		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[InspectorName("小碗·万宝槌出现")]
		MagicWalletSpawn,
		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[InspectorName("小碗·万宝槌消失")]
		MagicWalletDisappear,
		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		[InspectorName("影狼·狼爪爪击")]
		WolfClaw,
		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x40007F5")]
		[InspectorName("影狼·强力狼爪爪击")]
		WolfClawPowerUp,
		// Token: 0x040007F6 RID: 2038
		[Token(Token = "0x40007F6")]
		[InspectorName("影狼·狼血觉醒")]
		WolfDance,
		// Token: 0x040007F7 RID: 2039
		[Token(Token = "0x40007F7")]
		[InspectorName("影狼·狼魂爆破")]
		WolfSpirit,
		// Token: 0x040007F8 RID: 2040
		[Token(Token = "0x40007F8")]
		[InspectorName("喜·星弹击中")]
		StarHit,
		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		[InspectorName("妖精·光玉命中")]
		NormalBulletHit,
		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		[InspectorName("妖精·大玉命中")]
		GiantBulletHit,
		// Token: 0x040007FB RID: 2043
		[Token(Token = "0x40007FB")]
		[InspectorName("小碗·魔力爆发")]
		ShinmyoumaruMagic,
		// Token: 0x040007FC RID: 2044
		[Token(Token = "0x40007FC")]
		[InspectorName("正邪·进入隐身")]
		HideSeija,
		// Token: 0x040007FD RID: 2045
		[Token(Token = "0x40007FD")]
		[InspectorName("正邪·解除隐身")]
		ShowSeija,
		// Token: 0x040007FE RID: 2046
		[Token(Token = "0x40007FE")]
		[InspectorName("正邪·终极气球")]
		EvilInBalloon,
		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		[InspectorName("破坏神·分身显形")]
		SpawnSpiritVFX,
		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		[InspectorName("花妈·向日葵弹幕击中")]
		FlowerBulletHit,
		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		[InspectorName("花妈·向日葵生产阳光")]
		FlowerSun,
		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000802")]
		[InspectorName("帕秋莉·火球")]
		Patchouli_FireBall,
		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		[InspectorName("帕秋莉·爆炸")]
		Patchouli_FireBomb,
		// Token: 0x04000804 RID: 2052
		[Token(Token = "0x4000804")]
		[InspectorName("梅蒂欣·小瓶子碎裂")]
		Medicine_SmallBottleBreak,
		// Token: 0x04000805 RID: 2053
		[Token(Token = "0x4000805")]
		[InspectorName("梅蒂欣·大瓶子碎裂")]
		Medicine_GiantBottleBreak,
		// Token: 0x04000806 RID: 2054
		[Token(Token = "0x4000806")]
		[InspectorName("梅蒂欣·中毒")]
		Medicine_Poison,
		// Token: 0x04000807 RID: 2055
		[Token(Token = "0x4000807")]
		[InspectorName("怒·莱瓦汀斩击")]
		AngryFlandre_Laevatain,
		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		[InspectorName("破坏神·震击")]
		Hakaishin_Earthquake,
		// Token: 0x04000809 RID: 2057
		[Token(Token = "0x4000809")]
		[InspectorName("破坏神·死亡血雾")]
		Hakaishin_Die,
		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		[InspectorName("普通芙兰·死亡血雾")]
		Flandre_Die,
		// Token: 0x0400080B RID: 2059
		[Token(Token = "0x400080B")]
		[InspectorName("天壤梦弓·击中")]
		SeijaBowHit,
		// Token: 0x0400080C RID: 2060
		[Token(Token = "0x400080C")]
		[InspectorName("客人防御塔旗帜1")]
		LevelFlag1,
		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		[InspectorName("客人防御塔旗帜2")]
		LevelFlag2,
		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		[InspectorName("梅蒂欣·死亡爆炸")]
		Medicine_DeadPoison,
		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		[InspectorName("客人等级提升")]
		LevelUpVFX,
		// Token: 0x04000810 RID: 2064
		[Token(Token = "0x4000810")]
		[InspectorName("客人使用技能")]
		LevelUpSkillVFX,
		// Token: 0x04000811 RID: 2065
		[Token(Token = "0x4000811")]
		[InspectorName("客人等级2")]
		Level2VFX,
		// Token: 0x04000812 RID: 2066
		[Token(Token = "0x4000812")]
		[InspectorName("针妙丸勇者Buff")]
		ShinmyoumaruYuushaBuff,
		// Token: 0x04000813 RID: 2067
		[Token(Token = "0x4000813")]
		[InspectorName("影狼BeastarBuff")]
		KagerouBeastarBuff,
		// Token: 0x04000814 RID: 2068
		[Token(Token = "0x4000814")]
		[InspectorName("针妙丸范围勇者Buff")]
		ShinmyoumaruYuushaGloryBuff
	}
}

using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000392 RID: 914
	[Token(Token = "0x2000392")]
	[Serializable]
	public abstract class RogueLikeCardBase : ScriptableObject
	{
		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06001445 RID: 5189 RVA: 0x00007C68 File Offset: 0x00005E68
		[Token(Token = "0x17000252")]
		public bool IsDangerousCard
		{
			[Token(Token = "0x6001445")]
			[Address(RVA = "0x44F3C0", Offset = "0x44DDC0", VA = "0x18044F3C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000253")]
		public Sprite BG
		{
			[Token(Token = "0x6001446")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x00007C80 File Offset: 0x00005E80
		[Token(Token = "0x17000254")]
		public bool ForcedShow
		{
			[Token(Token = "0x6001447")]
			[Address(RVA = "0x44F3B0", Offset = "0x44DDB0", VA = "0x18044F3B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x00007C98 File Offset: 0x00005E98
		[Token(Token = "0x17000255")]
		public RogueLikeCardBase.CardType GetCardType
		{
			[Token(Token = "0x6001448")]
			[Address(RVA = "0x403830", Offset = "0x402230", VA = "0x180403830")]
			get
			{
				return RogueLikeCardBase.CardType.获得食材;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06001449 RID: 5193
		[Token(Token = "0x17000256")]
		public abstract RogueLikeCardBase.CardForm GetCardForm
		{
			[Token(Token = "0x6001449")]
			get;
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00007CB0 File Offset: 0x00005EB0
		[Token(Token = "0x600144A")]
		[Address(RVA = "0x44F360", Offset = "0x44DD60", VA = "0x18044F360")]
		protected bool RegisterTimedBuff(EventManager eventManager, EventManager.BuffType buffType, float duration, Action<int> defaultRegisterBuffAction, EventManager.BuffRegisterType buffRegisterType = EventManager.BuffRegisterType.Additive, int extraDuration = -1, [Optional] Action<int> haveBuffRegisterBuffAction)
		{
			return default(bool);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144B")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		protected RogueLikeCardBase()
		{
		}

		// Token: 0x040012BD RID: 4797
		[Token(Token = "0x40012BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RogueLikeCardBase.CardType m_CardType;

		// Token: 0x040012BE RID: 4798
		[Token(Token = "0x40012BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_IsDangerousCard;

		// Token: 0x040012BF RID: 4799
		[Token(Token = "0x40012BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[SerializeField]
		private bool m_ForcedShow;

		// Token: 0x040012C0 RID: 4800
		[Token(Token = "0x40012C0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite m_Bg;

		// Token: 0x02000393 RID: 915
		[Token(Token = "0x2000393")]
		public enum Rarity
		{
			// Token: 0x040012C2 RID: 4802
			[Token(Token = "0x40012C2")]
			Green,
			// Token: 0x040012C3 RID: 4803
			[Token(Token = "0x40012C3")]
			Blue,
			// Token: 0x040012C4 RID: 4804
			[Token(Token = "0x40012C4")]
			Purple,
			// Token: 0x040012C5 RID: 4805
			[Token(Token = "0x40012C5")]
			Gold
		}

		// Token: 0x02000394 RID: 916
		[Token(Token = "0x2000394")]
		public enum CardType
		{
			// Token: 0x040012C7 RID: 4807
			[Token(Token = "0x40012C7")]
			获得食材,
			// Token: 0x040012C8 RID: 4808
			[Token(Token = "0x40012C8")]
			获得酒水,
			// Token: 0x040012C9 RID: 4809
			[Token(Token = "0x40012C9")]
			营业额增加,
			// Token: 0x040012CA RID: 4810
			[Token(Token = "0x40012CA")]
			食材不消耗,
			// Token: 0x040012CB RID: 4811
			[Token(Token = "0x40012CB")]
			酒水不消耗,
			// Token: 0x040012CC RID: 4812
			[Token(Token = "0x40012CC")]
			客人强化,
			// Token: 0x040012CD RID: 4813
			[Token(Token = "0x40012CD")]
			空白卡牌,
			// Token: 0x040012CE RID: 4814
			[Token(Token = "0x40012CE")]
			怒押必中,
			// Token: 0x040012CF RID: 4815
			[Token(Token = "0x40012CF")]
			被遗忘者的哲学,
			// Token: 0x040012D0 RID: 4816
			[Token(Token = "0x40012D0")]
			文化之风镇魂曲,
			// Token: 0x040012D1 RID: 4817
			[Token(Token = "0x40012D1")]
			辉夜姬的秘宝,
			// Token: 0x040012D2 RID: 4818
			[Token(Token = "0x40012D2")]
			法外分身,
			// Token: 0x040012D3 RID: 4819
			[Token(Token = "0x40012D3")]
			鬼杰组长的恐吓,
			// Token: 0x040012D4 RID: 4820
			[Token(Token = "0x40012D4")]
			万物丰穰,
			// Token: 0x040012D5 RID: 4821
			[Token(Token = "0x40012D5")]
			刻耳柏洛斯捕兽夹,
			// Token: 0x040012D6 RID: 4822
			[Token(Token = "0x40012D6")]
			三途川牛鬼鱼市,
			// Token: 0x040012D7 RID: 4823
			[Token(Token = "0x40012D7")]
			山童式购物术,
			// Token: 0x040012D8 RID: 4824
			[Token(Token = "0x40012D8")]
			瞬摄留影念写术,
			// Token: 0x040012D9 RID: 4825
			[Token(Token = "0x40012D9")]
			诅咒之血火,
			// Token: 0x040012DA RID: 4826
			[Token(Token = "0x40012DA")]
			黄泉之通路,
			// Token: 0x040012DB RID: 4827
			[Token(Token = "0x40012DB")]
			灵魂之呓语,
			// Token: 0x040012DC RID: 4828
			[Token(Token = "0x40012DC")]
			寂灭为乐之王,
			// Token: 0x040012DD RID: 4829
			[Token(Token = "0x40012DD")]
			纳兹琳灵摆,
			// Token: 0x040012DE RID: 4830
			[Token(Token = "0x40012DE")]
			噬龙之蛊虫,
			// Token: 0x040012DF RID: 4831
			[Token(Token = "0x40012DF")]
			龙宫使的预言,
			// Token: 0x040012E0 RID: 4832
			[Token(Token = "0x40012E0")]
			低价酒水补充 = 1000,
			// Token: 0x040012E1 RID: 4833
			[Token(Token = "0x40012E1")]
			高价酒水补充,
			// Token: 0x040012E2 RID: 4834
			[Token(Token = "0x40012E2")]
			溢出的瑕秽,
			// Token: 0x040012E3 RID: 4835
			[Token(Token = "0x40012E3")]
			梦醒时分,
			// Token: 0x040012E4 RID: 4836
			[Token(Token = "0x40012E4")]
			山谷回声,
			// Token: 0x040012E5 RID: 4837
			[Token(Token = "0x40012E5")]
			棱镜协奏曲,
			// Token: 0x040012E6 RID: 4838
			[Token(Token = "0x40012E6")]
			[InspectorName("Persistent/店铺升级")]
			店铺升级 = 25,
			// Token: 0x040012E7 RID: 4839
			[Token(Token = "0x40012E7")]
			[InspectorName("Persistent/移动步数提升")]
			移动步数提升,
			// Token: 0x040012E8 RID: 4840
			[Token(Token = "0x40012E8")]
			[InspectorName("Persistent/开放特客出没")]
			开放特客出没,
			// Token: 0x040012E9 RID: 4841
			[Token(Token = "0x40012E9")]
			[InspectorName("Persistent/抽取食谱备选数增加")]
			抽取食谱备选数增加,
			// Token: 0x040012EA RID: 4842
			[Token(Token = "0x40012EA")]
			[InspectorName("Persistent/可抽取食谱数增加")]
			可抽取食谱数增加,
			// Token: 0x040012EB RID: 4843
			[Token(Token = "0x40012EB")]
			[InspectorName("Persistent/酒水刷新数量增加")]
			酒水刷新数量增加,
			// Token: 0x040012EC RID: 4844
			[Token(Token = "0x40012EC")]
			[InspectorName("Persistent/伙伴效率永久提升")]
			伙伴效率永久提升,
			// Token: 0x040012ED RID: 4845
			[Token(Token = "0x40012ED")]
			[InspectorName("Persistent/小费率永久提升")]
			小费率永久提升,
			// Token: 0x040012EE RID: 4846
			[Token(Token = "0x40012EE")]
			[InspectorName("Persistent/续单率永久提升")]
			续单率永久提升,
			// Token: 0x040012EF RID: 4847
			[Token(Token = "0x40012EF")]
			[InspectorName("Persistent/客流量永久提升")]
			客流量永久提升,
			// Token: 0x040012F0 RID: 4848
			[Token(Token = "0x40012F0")]
			[InspectorName("Persistent/客人预算永久提升")]
			客人预算永久提升,
			// Token: 0x040012F1 RID: 4849
			[Token(Token = "0x40012F1")]
			[InspectorName("Persistent/料理速度永久提升")]
			料理速度永久提升,
			// Token: 0x040012F2 RID: 4850
			[Token(Token = "0x40012F2")]
			[InspectorName("Persistent/抽卡连击条件减少")]
			抽卡连击条件减少,
			// Token: 0x040012F3 RID: 4851
			[Token(Token = "0x40012F3")]
			[InspectorName("Persistent/评价连击条件减少")]
			评价连击条件减少,
			// Token: 0x040012F4 RID: 4852
			[Token(Token = "0x40012F4")]
			[InspectorName("Persistent/香霖堂折扣")]
			香霖堂折扣,
			// Token: 0x040012F5 RID: 4853
			[Token(Token = "0x40012F5")]
			[InspectorName("Persistent/添加物件")]
			添加物件,
			// Token: 0x040012F6 RID: 4854
			[Token(Token = "0x40012F6")]
			[InspectorName("Persistent/抽奖")]
			抽奖,
			// Token: 0x040012F7 RID: 4855
			[Token(Token = "0x40012F7")]
			[InspectorName("Persistent/额外出售")]
			额外出售,
			// Token: 0x040012F8 RID: 4856
			[Token(Token = "0x40012F8")]
			[InspectorName("Persistent/垒石")]
			垒石,
			// Token: 0x040012F9 RID: 4857
			[Token(Token = "0x40012F9")]
			[InspectorName("Persistent/馈赠的季节")]
			馈赠的季节 = 56,
			// Token: 0x040012FA RID: 4858
			[Token(Token = "0x40012FA")]
			[InspectorName("Persistent/额外素材售卖")]
			额外素材售卖,
			// Token: 0x040012FB RID: 4859
			[Token(Token = "0x40012FB")]
			[InspectorName("Persistent/结账暴击")]
			结账暴击 = 60,
			// Token: 0x040012FC RID: 4860
			[Token(Token = "0x40012FC")]
			[InspectorName("Persistent/中华菜售价提升")]
			中华菜售价提升,
			// Token: 0x040012FD RID: 4861
			[Token(Token = "0x40012FD")]
			[InspectorName("Persistent/和风菜售价提升")]
			和风菜售价提升,
			// Token: 0x040012FE RID: 4862
			[Token(Token = "0x40012FE")]
			[InspectorName("Persistent/西式菜售价提升")]
			西式菜售价提升,
			// Token: 0x040012FF RID: 4863
			[Token(Token = "0x40012FF")]
			[InspectorName("Persistent/流行菜售价提升")]
			流行菜售价提升,
			// Token: 0x04001300 RID: 4864
			[Token(Token = "0x4001300")]
			[InspectorName("Persistent/鬼渡试炼局外")]
			鬼渡试炼局外 = 44,
			// Token: 0x04001301 RID: 4865
			[Token(Token = "0x4001301")]
			[InspectorName("Persistent/通关要求减少")]
			通关要求减少,
			// Token: 0x04001302 RID: 4866
			[Token(Token = "0x4001302")]
			[InspectorName("Persistent/断CB保护")]
			断CB保护,
			// Token: 0x04001303 RID: 4867
			[Token(Token = "0x4001303")]
			[InspectorName("Persistent/改判")]
			改判,
			// Token: 0x04001304 RID: 4868
			[Token(Token = "0x4001304")]
			[InspectorName("Persistent/开局获得菜品")]
			开局获得菜品,
			// Token: 0x04001305 RID: 4869
			[Token(Token = "0x4001305")]
			[InspectorName("Persistent/强制爱上指定标签")]
			强制爱上指定标签 = 50,
			// Token: 0x04001306 RID: 4870
			[Token(Token = "0x4001306")]
			[InspectorName("Persistent/诅咒之血火局外")]
			诅咒之血火局外,
			// Token: 0x04001307 RID: 4871
			[Token(Token = "0x4001307")]
			[InspectorName("Persistent/黄泉之通路局外")]
			黄泉之通路局外,
			// Token: 0x04001308 RID: 4872
			[Token(Token = "0x4001308")]
			[InspectorName("Persistent/灵魂之呓语局外")]
			灵魂之呓语局外,
			// Token: 0x04001309 RID: 4873
			[Token(Token = "0x4001309")]
			[InspectorName("Persistent/噬龙之蛊虫局外")]
			噬龙之蛊虫局外,
			// Token: 0x0400130A RID: 4874
			[Token(Token = "0x400130A")]
			[InspectorName("Persistent/寂灭为乐之王局外")]
			寂灭为乐之王局外,
			// Token: 0x0400130B RID: 4875
			[Token(Token = "0x400130B")]
			[InspectorName("Persistent/白莲")]
			白莲庇佑 = 58,
			// Token: 0x0400130C RID: 4876
			[Token(Token = "0x400130C")]
			[InspectorName("Persistent/神子")]
			神子庇佑,
			// Token: 0x0400130D RID: 4877
			[Token(Token = "0x400130D")]
			[InspectorName("Persistent/完全净化")]
			完全净化 = 2000,
			// Token: 0x0400130E RID: 4878
			[Token(Token = "0x400130E")]
			[InspectorName("Persistent/绯想天")]
			绯想天
		}

		// Token: 0x02000395 RID: 917
		[Token(Token = "0x2000395")]
		public enum CardForm
		{
			// Token: 0x04001310 RID: 4880
			[Token(Token = "0x4001310")]
			InGame,
			// Token: 0x04001311 RID: 4881
			[Token(Token = "0x4001311")]
			InSettled
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameData;
using Il2CppDummyDll;
using UnityEngine;

namespace PrototypingManagers
{
	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	public class MainSceneDebugConsole : DebugConsoleBase
	{
		// Token: 0x060005C4 RID: 1476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x6EE6D0", Offset = "0x6ED0D0", VA = "0x1806EE6D0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x6ECAD0", Offset = "0x6EB4D0", VA = "0x1806ECAD0")]
		public static MainSceneDebugConsole.TempIzakayaSelection[] GetIzakayaOptions()
		{
			return null;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x6EDA80", Offset = "0x6EC480", VA = "0x1806EDA80")]
		public static MainSceneDebugConsole.SkinSelection[] GetSkinOptions()
		{
			return null;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x6ED4A0", Offset = "0x6EBEA0", VA = "0x1806ED4A0")]
		public static MainSceneDebugConsole.PartnerCharacterSelections[] GetPartnerSelections()
		{
			return null;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x6EF350", Offset = "0x6EDD50", VA = "0x1806EF350", Slot = "4")]
		protected override void OnStart()
		{
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x6EE790", Offset = "0x6ED190", VA = "0x1806EE790", Slot = "5")]
		protected override void OnDrawDebugConsole()
		{
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x6EE270", Offset = "0x6ECC70", VA = "0x1806EE270")]
		private void GotoTestWorkScene()
		{
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x6EFF90", Offset = "0x6EE990", VA = "0x1806EFF90")]
		public MainSceneDebugConsole()
		{
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x6EFA30", Offset = "0x6EE430", VA = "0x1806EFA30")]
		[CompilerGenerated]
		private void <GotoTestWorkScene>g__OnLoadFinish|28_1()
		{
		}

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0x18")]
		public bool isIzakayaSkinSelectionExpanded;

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x40005AE")]
		[FieldOffset(Offset = "0x20")]
		private readonly bool[] isExpandedCharacter;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[FieldOffset(Offset = "0x28")]
		private readonly bool[] isExpandedJob;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[FieldOffset(Offset = "0x30")]
		private readonly ValueTuple<MainSceneDebugConsole.PartnerCharacterSelections, MainSceneDebugConsole.PartnerSelections>[] selections;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<MainSceneDebugConsole.TempIzakayaSelection, string> availableIzakayaSelections;

		// Token: 0x040005B2 RID: 1458
		[Token(Token = "0x40005B2")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<MainSceneDebugConsole.PartnerCharacterSelections, string> availablePartnerSelections;

		// Token: 0x040005B3 RID: 1459
		[Token(Token = "0x40005B3")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<MainSceneDebugConsole.SkinSelection, string> availableskinSelections;

		// Token: 0x040005B4 RID: 1460
		[Token(Token = "0x40005B4")]
		[FieldOffset(Offset = "0x50")]
		private MultiLanguageTextMesh.LoadLanguageType currentLanguage;

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x54")]
		private Vector2 currentPannelScroll;

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x5C")]
		private bool isIzakayaSelectionExpanded;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x5D")]
		private bool isLanguageSetExpanded;

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x5E")]
		private bool isNewGameModeExpanded;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x5F")]
		private bool isSkinExpanded;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x60")]
		private MainSceneDebugConsole.IzakayaSkinSelections izakayaSkinSelection;

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x40005BB")]
		[FieldOffset(Offset = "0x64")]
		private MainSceneDebugConsole.SkinSelection skinSelection;

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x68")]
		private MainSceneDebugConsole.TempIzakayaSelection tempIzakayaSelection;

		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x6C")]
		private bool useAllDecorations;

		// Token: 0x02000100 RID: 256
		[Token(Token = "0x2000100")]
		public enum IzakayaSkinSelections
		{
			// Token: 0x040005BF RID: 1471
			[Token(Token = "0x40005BF")]
			无 = -1,
			// Token: 0x040005C0 RID: 1472
			[Token(Token = "0x40005C0")]
			万圣节 = 54,
			// Token: 0x040005C1 RID: 1473
			[Token(Token = "0x40005C1")]
			圣诞节 = 59,
			// Token: 0x040005C2 RID: 1474
			[Token(Token = "0x40005C2")]
			春节 = 57
		}

		// Token: 0x02000101 RID: 257
		[Token(Token = "0x2000101")]
		public enum PartnerCharacterSelections
		{
			// Token: 0x040005C4 RID: 1476
			[Token(Token = "0x40005C4")]
			None,
			// Token: 0x040005C5 RID: 1477
			[Token(Token = "0x40005C5")]
			幽谷响子 = 14,
			// Token: 0x040005C6 RID: 1478
			[Token(Token = "0x40005C6")]
			本居小铃 = 18,
			// Token: 0x040005C7 RID: 1479
			[Token(Token = "0x40005C7")]
			高丽野阿吽,
			// Token: 0x040005C8 RID: 1480
			[Token(Token = "0x40005C8")]
			十六夜咲夜,
			// Token: 0x040005C9 RID: 1481
			[Token(Token = "0x40005C9")]
			铃仙,
			// Token: 0x040005CA RID: 1482
			[Token(Token = "0x40005CA")]
			妖梦 = 39,
			// Token: 0x040005CB RID: 1483
			[Token(Token = "0x40005CB")]
			转转 = 1006,
			// Token: 0x040005CC RID: 1484
			[Token(Token = "0x40005CC")]
			梦子,
			// Token: 0x040005CD RID: 1485
			[Token(Token = "0x40005CD")]
			小町 = 2008,
			// Token: 0x040005CE RID: 1486
			[Token(Token = "0x40005CE")]
			琪斯美 = 2007,
			// Token: 0x040005CF RID: 1487
			[Token(Token = "0x40005CF")]
			云居一轮 = 3006,
			// Token: 0x040005D0 RID: 1488
			[Token(Token = "0x40005D0")]
			芳香 = 3008,
			// Token: 0x040005D1 RID: 1489
			[Token(Token = "0x40005D1")]
			巴大蝶 = 4009,
			// Token: 0x040005D2 RID: 1490
			[Token(Token = "0x40005D2")]
			赤蛮奇,
			// Token: 0x040005D3 RID: 1491
			[Token(Token = "0x40005D3")]
			哆来咪 = 5006,
			// Token: 0x040005D4 RID: 1492
			[Token(Token = "0x40005D4")]
			萨拉
		}

		// Token: 0x02000102 RID: 258
		[Token(Token = "0x2000102")]
		public enum PartnerSelections
		{
			// Token: 0x040005D6 RID: 1494
			[Token(Token = "0x40005D6")]
			None,
			// Token: 0x040005D7 RID: 1495
			[Token(Token = "0x40005D7")]
			厨师,
			// Token: 0x040005D8 RID: 1496
			[Token(Token = "0x40005D8")]
			传菜,
			// Token: 0x040005D9 RID: 1497
			[Token(Token = "0x40005D9")]
			传酒,
			// Token: 0x040005DA RID: 1498
			[Token(Token = "0x40005DA")]
			BOSS
		}

		// Token: 0x02000103 RID: 259
		[Token(Token = "0x2000103")]
		public enum SkinSelection
		{
			// Token: 0x040005DC RID: 1500
			[Token(Token = "0x40005DC")]
			原皮 = -1,
			// Token: 0x040005DD RID: 1501
			[Token(Token = "0x40005DD")]
			老板娘 = -2,
			// Token: 0x040005DE RID: 1502
			[Token(Token = "0x40005DE")]
			黑色 = 23,
			// Token: 0x040005DF RID: 1503
			[Token(Token = "0x40005DF")]
			中国,
			// Token: 0x040005E0 RID: 1504
			[Token(Token = "0x40005E0")]
			巫女,
			// Token: 0x040005E1 RID: 1505
			[Token(Token = "0x40005E1")]
			睡衣,
			// Token: 0x040005E2 RID: 1506
			[Token(Token = "0x40005E2")]
			和服,
			// Token: 0x040005E3 RID: 1507
			[Token(Token = "0x40005E3")]
			水手夏 = 31,
			// Token: 0x040005E4 RID: 1508
			[Token(Token = "0x40005E4")]
			万圣节 = 54,
			// Token: 0x040005E5 RID: 1509
			[Token(Token = "0x40005E5")]
			偶像 = 56,
			// Token: 0x040005E6 RID: 1510
			[Token(Token = "0x40005E6")]
			春节,
			// Token: 0x040005E7 RID: 1511
			[Token(Token = "0x40005E7")]
			执事,
			// Token: 0x040005E8 RID: 1512
			[Token(Token = "0x40005E8")]
			圣诞,
			// Token: 0x040005E9 RID: 1513
			[Token(Token = "0x40005E9")]
			水手冬 = 1001,
			// Token: 0x040005EA RID: 1514
			[Token(Token = "0x40005EA")]
			魔女,
			// Token: 0x040005EB RID: 1515
			[Token(Token = "0x40005EB")]
			浴衣 = 2001,
			// Token: 0x040005EC RID: 1516
			[Token(Token = "0x40005EC")]
			星空披风,
			// Token: 0x040005ED RID: 1517
			[Token(Token = "0x40005ED")]
			朋克乐队 = 2500
		}

		// Token: 0x02000104 RID: 260
		[Token(Token = "0x2000104")]
		public enum TempIzakayaSelection
		{
			// Token: 0x040005EF RID: 1519
			[Token(Token = "0x40005EF")]
			兽道推车,
			// Token: 0x040005F0 RID: 1520
			[Token(Token = "0x40005F0")]
			兽道小屋,
			// Token: 0x040005F1 RID: 1521
			[Token(Token = "0x40005F1")]
			兽道雀食堂,
			// Token: 0x040005F2 RID: 1522
			[Token(Token = "0x40005F2")]
			人里推车,
			// Token: 0x040005F3 RID: 1523
			[Token(Token = "0x40005F3")]
			人里小屋,
			// Token: 0x040005F4 RID: 1524
			[Token(Token = "0x40005F4")]
			人里雀食堂,
			// Token: 0x040005F5 RID: 1525
			[Token(Token = "0x40005F5")]
			神社推车,
			// Token: 0x040005F6 RID: 1526
			[Token(Token = "0x40005F6")]
			神社小屋,
			// Token: 0x040005F7 RID: 1527
			[Token(Token = "0x40005F7")]
			神社雀食堂,
			// Token: 0x040005F8 RID: 1528
			[Token(Token = "0x40005F8")]
			神社推车EX,
			// Token: 0x040005F9 RID: 1529
			[Token(Token = "0x40005F9")]
			红魔馆推车,
			// Token: 0x040005FA RID: 1530
			[Token(Token = "0x40005FA")]
			红魔馆小屋,
			// Token: 0x040005FB RID: 1531
			[Token(Token = "0x40005FB")]
			红魔馆雀食堂,
			// Token: 0x040005FC RID: 1532
			[Token(Token = "0x40005FC")]
			竹林推车 = 14,
			// Token: 0x040005FD RID: 1533
			[Token(Token = "0x40005FD")]
			竹林小屋,
			// Token: 0x040005FE RID: 1534
			[Token(Token = "0x40005FE")]
			竹林雀食堂,
			// Token: 0x040005FF RID: 1535
			[Token(Token = "0x40005FF")]
			竹林推车但是无辉夜和妹红 = 18,
			// Token: 0x04000600 RID: 1536
			[Token(Token = "0x4000600")]
			竹林推车但是没有稀客,
			// Token: 0x04000601 RID: 1537
			[Token(Token = "0x4000601")]
			白玉楼 = 13,
			// Token: 0x04000602 RID: 1538
			[Token(Token = "0x4000602")]
			白玉楼EX = 17,
			// Token: 0x04000603 RID: 1539
			[Token(Token = "0x4000603")]
			妖怪之山推车 = 1000,
			// Token: 0x04000604 RID: 1540
			[Token(Token = "0x4000604")]
			妖怪之山小屋,
			// Token: 0x04000605 RID: 1541
			[Token(Token = "0x4000605")]
			妖怪之山雀食堂,
			// Token: 0x04000606 RID: 1542
			[Token(Token = "0x4000606")]
			魔法森林推车,
			// Token: 0x04000607 RID: 1543
			[Token(Token = "0x4000607")]
			魔法森林小屋,
			// Token: 0x04000608 RID: 1544
			[Token(Token = "0x4000608")]
			魔法森林雀食堂,
			// Token: 0x04000609 RID: 1545
			[Token(Token = "0x4000609")]
			血池地狱,
			// Token: 0x0400060A RID: 1546
			[Token(Token = "0x400060A")]
			旧地狱推车 = 2000,
			// Token: 0x0400060B RID: 1547
			[Token(Token = "0x400060B")]
			旧地狱小屋,
			// Token: 0x0400060C RID: 1548
			[Token(Token = "0x400060C")]
			旧地狱雀食堂,
			// Token: 0x0400060D RID: 1549
			[Token(Token = "0x400060D")]
			地灵殿推车,
			// Token: 0x0400060E RID: 1550
			[Token(Token = "0x400060E")]
			地灵殿小屋,
			// Token: 0x0400060F RID: 1551
			[Token(Token = "0x400060F")]
			地灵殿雀食堂,
			// Token: 0x04000610 RID: 1552
			[Token(Token = "0x4000610")]
			旧地狱雀食堂赛场,
			// Token: 0x04000611 RID: 1553
			[Token(Token = "0x4000611")]
			命莲寺推车 = 3000,
			// Token: 0x04000612 RID: 1554
			[Token(Token = "0x4000612")]
			命莲寺小屋,
			// Token: 0x04000613 RID: 1555
			[Token(Token = "0x4000613")]
			命莲寺雀食堂,
			// Token: 0x04000614 RID: 1556
			[Token(Token = "0x4000614")]
			神灵庙推车,
			// Token: 0x04000615 RID: 1557
			[Token(Token = "0x4000615")]
			神灵庙小屋,
			// Token: 0x04000616 RID: 1558
			[Token(Token = "0x4000616")]
			神灵庙雀食堂,
			// Token: 0x04000617 RID: 1559
			[Token(Token = "0x4000617")]
			神灵庙比赛现场,
			// Token: 0x04000618 RID: 1560
			[Token(Token = "0x4000618")]
			太阳花田推车 = 4000,
			// Token: 0x04000619 RID: 1561
			[Token(Token = "0x4000619")]
			太阳花田小屋,
			// Token: 0x0400061A RID: 1562
			[Token(Token = "0x400061A")]
			太阳花田雀食堂,
			// Token: 0x0400061B RID: 1563
			[Token(Token = "0x400061B")]
			辉针城推车,
			// Token: 0x0400061C RID: 1564
			[Token(Token = "0x400061C")]
			辉针城小屋,
			// Token: 0x0400061D RID: 1565
			[Token(Token = "0x400061D")]
			辉针城雀食堂
		}
	}
}

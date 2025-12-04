using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.Singletons;
using DEYU.Utils;
using GameData.Core.Collections;
using Il2CppDummyDll;

namespace GameData.RunTime.NightSceneUtility
{
	// Token: 0x020007E4 RID: 2020
	[Token(Token = "0x20007E4")]
	public class IzakayaTray : Singleton<IzakayaTray>
	{
		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F88 RID: 12168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000640")]
		public FixedList<Sellable> Tray
		{
			[Token(Token = "0x6002F87")]
			[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F88")]
			[Address(RVA = "0x4A6ED0", Offset = "0x4A58D0", VA = "0x1804A6ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x00011550 File Offset: 0x0000F750
		[Token(Token = "0x17000641")]
		public bool IsTrayEmpty
		{
			[Token(Token = "0x6002F89")]
			[Address(RVA = "0x608F70", Offset = "0x607970", VA = "0x180608F70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06002F8A RID: 12170 RVA: 0x00011568 File Offset: 0x0000F768
		[Token(Token = "0x17000642")]
		public bool IsTrayFull
		{
			[Token(Token = "0x6002F8A")]
			[Address(RVA = "0x6090C0", Offset = "0x607AC0", VA = "0x1806090C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x06002F8B RID: 12171 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002F8C RID: 12172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000025")]
		public event Action OnTrayUpdate
		{
			[Token(Token = "0x6002F8B")]
			[Address(RVA = "0x608ED0", Offset = "0x6078D0", VA = "0x180608ED0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002F8C")]
			[Address(RVA = "0x609330", Offset = "0x607D30", VA = "0x180609330")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x06002F8D RID: 12173 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002F8E RID: 12174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000026")]
		public event Action OnTrayUpdateClipPlay
		{
			[Token(Token = "0x6002F8D")]
			[Address(RVA = "0x608E30", Offset = "0x607830", VA = "0x180608E30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002F8E")]
			[Address(RVA = "0x609290", Offset = "0x607C90", VA = "0x180609290")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F8F")]
		[Address(RVA = "0x608B20", Offset = "0x607520", VA = "0x180608B20")]
		public void Initialize()
		{
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06002F90 RID: 12176 RVA: 0x00011580 File Offset: 0x0000F780
		[Token(Token = "0x17000643")]
		public int TrayMaxNum
		{
			[Token(Token = "0x6002F90")]
			[Address(RVA = "0x609170", Offset = "0x607B70", VA = "0x180609170")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F91")]
		[Address(RVA = "0x608D50", Offset = "0x607750", VA = "0x180608D50")]
		public Sellable Swap(Sellable toDeliver, Sellable toRecieve)
		{
			return null;
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F92")]
		[Address(RVA = "0x608A10", Offset = "0x607410", VA = "0x180608A10")]
		public Sellable Deliver(Sellable value)
		{
			return null;
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F93")]
		[Address(RVA = "0x6089A0", Offset = "0x6073A0", VA = "0x1806089A0")]
		private Sellable DeliverInternal(Sellable value)
		{
			return null;
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F94")]
		[Address(RVA = "0x608810", Offset = "0x607210", VA = "0x180608810")]
		public IEnumerable<Sellable> ClearTray()
		{
			return null;
		}

		// Token: 0x06002F95 RID: 12181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F95")]
		[Address(RVA = "0x608710", Offset = "0x607110", VA = "0x180608710")]
		public void ClearTargetTray(IEnumerable<int> targetId)
		{
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x00011598 File Offset: 0x0000F798
		[Token(Token = "0x6002F96")]
		[Address(RVA = "0x608BB0", Offset = "0x6075B0", VA = "0x180608BB0")]
		public int Receive(Sellable value)
		{
			return 0;
		}

		// Token: 0x06002F97 RID: 12183 RVA: 0x000115B0 File Offset: 0x0000F7B0
		[Token(Token = "0x6002F97")]
		[Address(RVA = "0x608BF0", Offset = "0x6075F0", VA = "0x180608BF0")]
		public int RecieveInternal(Sellable value)
		{
			return 0;
		}

		// Token: 0x06002F98 RID: 12184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F98")]
		[Address(RVA = "0x452950", Offset = "0x451350", VA = "0x180452950")]
		public void UpdateTray()
		{
		}

		// Token: 0x06002F99 RID: 12185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F99")]
		[Address(RVA = "0x608DF0", Offset = "0x6077F0", VA = "0x180608DF0")]
		public IzakayaTray()
		{
		}
	}
}

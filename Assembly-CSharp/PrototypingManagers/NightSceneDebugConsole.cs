using System;
using System.Collections.Generic;
using System.Reflection;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace PrototypingManagers
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	public class NightSceneDebugConsole : DebugConsoleBase
	{
		// Token: 0x060004C1 RID: 1217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x574060", Offset = "0x572A60", VA = "0x180574060")]
		private void OnDestroy()
		{
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x574080", Offset = "0x572A80", VA = "0x180574080", Slot = "4")]
		protected override void OnStart()
		{
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x574070", Offset = "0x572A70", VA = "0x180574070", Slot = "5")]
		protected override void OnDrawDebugConsole()
		{
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x570450", Offset = "0x56EE50", VA = "0x180570450")]
		private void DrawConsolePannelNew()
		{
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x570280", Offset = "0x56EC80", VA = "0x180570280")]
		private void DrawBuffNew()
		{
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x574990", Offset = "0x573390", VA = "0x180574990")]
		private void ToggleFoldOut(string displayName, Action drawDataCallback, ref bool currentToggleState)
		{
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x56FD10", Offset = "0x56E710", VA = "0x18056FD10")]
		private void Buttons()
		{
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x571880", Offset = "0x570280", VA = "0x180571880")]
		private void Guests()
		{
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x5740F0", Offset = "0x572AF0", VA = "0x1805740F0")]
		private void Partners()
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x574000", Offset = "0x572A00", VA = "0x180574000")]
		private void InitPartners()
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x56FAD0", Offset = "0x56E4D0", VA = "0x18056FAD0")]
		private void Buffs()
		{
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x572920", Offset = "0x571320", VA = "0x180572920")]
		private void InitBuffs()
		{
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x56F830", Offset = "0x56E230", VA = "0x18056F830")]
		private void BuffPass(string title, ref MethodInfo selectedMethod, ref bool isBuffExpanded, ref bool isMethodExpanded)
		{
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x5709F0", Offset = "0x56F3F0", VA = "0x1805709F0")]
		private void DrawForTargetobject(MethodInfo method)
		{
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x574AF0", Offset = "0x5734F0", VA = "0x180574AF0")]
		public NightSceneDebugConsole()
		{
		}

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x18")]
		private Vector2 currentPannelScrollViewPosition;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x20")]
		private bool isBtnSetShown;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x21")]
		private bool isBuffSetShown;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x22")]
		private bool isGuestSetShown;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x23")]
		private bool isPartnerSetShown;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x24")]
		private bool largeMode;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[FieldOffset(Offset = "0x25")]
		private bool shouldOnGUIBuffConsoleShown;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[FieldOffset(Offset = "0x28")]
		private int selectedSpecialGuestIndex;

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[FieldOffset(Offset = "0x2C")]
		private int selectedNormalGuestIndex;

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0x30")]
		private bool isSelectedSpecialGuestExpanded;

		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0x31")]
		private bool isSelectedNormalGuestExpanded;

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x34")]
		private Vector2 currentInDeskGuestPannelScrollViewPosition;

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x3C")]
		private Vector2 currentQueuedGuestPannelScrollViewPosition;

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x40004DE")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 currentPartnerPannelScrollViewPosition;

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x40004DF")]
		[FieldOffset(Offset = "0x50")]
		private IEnumerable<KeyValuePair<PartnerBase.PartnerType, IEnumerable<PartnerBase>>> allPartners;

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x40004E0")]
		[FieldOffset(Offset = "0x58")]
		private readonly Dictionary<MethodInfo, string> m_BuffMethods;

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x60")]
		private readonly Dictionary<string, object[]> m_BuffValues;

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0x68")]
		private readonly Dictionary<string, bool[]> m_BuffValueExpansions;

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x70")]
		private bool isBuffAExpaneded;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x71")]
		private bool isMethodAExpaneded;

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x78")]
		private MethodInfo selectedMethodA;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x80")]
		private bool isBuffBExpaneded;

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x81")]
		private bool isMethodBExpaneded;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0x88")]
		private MethodInfo selectedMethodB;

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x90")]
		private bool isBuffCExpaneded;

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x91")]
		private bool isMethodCExpaneded;

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x98")]
		private MethodInfo selectedMethodC;
	}
}

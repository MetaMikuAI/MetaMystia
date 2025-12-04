using System;
using System.Collections.Generic;
using DEYU.Singletons;
using GameData.Core.Collections.NightSceneUtility;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace Story
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	public class SpecialGuestControlled : Singleton<SpecialGuestControlled>
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x42F710", Offset = "0x42E110", VA = "0x18042F710")]
		public SpecialGuestControlled()
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x42ED00", Offset = "0x42D700", VA = "0x18042ED00")]
		public void Initialize(int masterId, Vector2Int disappearDayRange, string disappearNewsLabel, string appearNewsLabel, string[] disappearReason, string[] mapExclusions)
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x42EAE0", Offset = "0x42D4E0", VA = "0x18042EAE0")]
		public int[] GetMizuchiControlledGuest()
		{
			return null;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x42E680", Offset = "0x42D080", VA = "0x18042E680")]
		public bool ContainsDisappearSpecialGuests(int specialGuestId)
		{
			return default(bool);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x42E7B0", Offset = "0x42D1B0", VA = "0x18042E7B0")]
		public void ControlScheduled()
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x42E2F0", Offset = "0x42CCF0", VA = "0x18042E2F0")]
		public void CancelControl()
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x42F2D0", Offset = "0x42DCD0", VA = "0x18042F2D0")]
		public void ReleaseControl(string newsLabel, RunTimeScheduler.HistoryNewsData.ReplaceContent[] replaceContents)
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x42F4B0", Offset = "0x42DEB0", VA = "0x18042F4B0")]
		public bool TryConvertControllableSpecialGuest(SpecialGuest sourceSpecialGuest, out SpecialGuest destinationSpecialGuest)
		{
			return default(bool);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x42E8E0", Offset = "0x42D2E0", VA = "0x18042E8E0")]
		private ControlledSpecialGuest GenerateControllableSpecialGuest()
		{
			return default(ControlledSpecialGuest);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x42E460", Offset = "0x42CE60", VA = "0x18042E460")]
		private bool CheckSpecialGuestUsability(int specialGuestId)
		{
			return default(bool);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x42F260", Offset = "0x42DC60", VA = "0x18042F260")]
		private static void PrintLog(string log)
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x42F1F0", Offset = "0x42DBF0", VA = "0x18042F1F0")]
		private static void PrintLogWarning(string log)
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x42F180", Offset = "0x42DB80", VA = "0x18042F180")]
		private static void PrintLogError(string log)
		{
		}

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<SpecialGuest> m_SpecialGuestsCache;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<ControlledSpecialGuest> m_ControlledSpecialGuests;

		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		[FieldOffset(Offset = "0x20")]
		private int m_MasterId;

		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		[FieldOffset(Offset = "0x24")]
		private Vector2Int m_DisappearDayRange;

		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		[FieldOffset(Offset = "0x30")]
		private string m_DisappearNewsLabel;

		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		[FieldOffset(Offset = "0x38")]
		private string m_AppearNewsLabel;

		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		[FieldOffset(Offset = "0x40")]
		private string[] m_DisappearReason;

		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		[FieldOffset(Offset = "0x48")]
		private string[] m_MapExclusions;

		// Token: 0x02000085 RID: 133
		[Token(Token = "0x2000085")]
		private static class Callbacks
		{
			// Token: 0x060002DE RID: 734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x4215A0", Offset = "0x41FFA0", VA = "0x1804215A0")]
			public static void OnBeforeIzakayaConfiguration()
			{
			}

			// Token: 0x060002DF RID: 735 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x421920", Offset = "0x420320", VA = "0x180421920")]
			public static void OnWorkEnd()
			{
			}
		}
	}
}

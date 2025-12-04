using System;
using System.Runtime.InteropServices;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.MusicUtility
{
	// Token: 0x020008AE RID: 2222
	[Token(Token = "0x20008AE")]
	public class IzakayaMusic
	{
		// Token: 0x060036B5 RID: 14005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036B5")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public IzakayaMusic()
		{
		}

		// Token: 0x020008AF RID: 2223
		[Token(Token = "0x20008AF")]
		[Serializable]
		public struct MusicChannelPackage
		{
			// Token: 0x060036B6 RID: 14006 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036B6")]
			[Address(RVA = "0x40C360", Offset = "0x40AD60", VA = "0x18040C360")]
			public MusicChannelPackage(LoopedBGMPackage musicData, IzakayaMusic.SingleNote[] qtes)
			{
			}

			// Token: 0x1700071D RID: 1821
			// (get) Token: 0x060036B7 RID: 14007 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700071D")]
			public AudioClip ClipIntro
			{
				[Token(Token = "0x60036B7")]
				[Address(RVA = "0x6658E0", Offset = "0x6642E0", VA = "0x1806658E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x060036B8 RID: 14008 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700071E")]
			public AudioClip ClipLoop
			{
				[Token(Token = "0x60036B8")]
				[Address(RVA = "0x665900", Offset = "0x664300", VA = "0x180665900")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700071F RID: 1823
			// (get) Token: 0x060036B9 RID: 14009 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060036BA RID: 14010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700071F")]
			public IzakayaMusic.SingleNote[] Qtes
			{
				[Token(Token = "0x60036B9")]
				[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60036BA")]
				[Address(RVA = "0x665920", Offset = "0x664320", VA = "0x180665920")]
				set
				{
				}
			}

			// Token: 0x04002F39 RID: 12089
			[Token(Token = "0x4002F39")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			private LoopedBGMPackage musicData;

			// Token: 0x04002F3A RID: 12090
			[Token(Token = "0x4002F3A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			private IzakayaMusic.SingleNote[] qtes;
		}

		// Token: 0x020008B0 RID: 2224
		[Token(Token = "0x20008B0")]
		[Serializable]
		public struct SingleNote
		{
			// Token: 0x060036BB RID: 14011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036BB")]
			[Address(RVA = "0x673050", Offset = "0x671A50", VA = "0x180673050")]
			public SingleNote(IzakayaMusic.SingleNote source, [Optional] long? newStartTime, [Optional] long? newEndTime, [Optional] IzakayaMusic.SingleNote.NotePosition? newPosition)
			{
			}

			// Token: 0x060036BC RID: 14012 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036BC")]
			[Address(RVA = "0x673160", Offset = "0x671B60", VA = "0x180673160")]
			public SingleNote(long startTime, long endTime, IzakayaMusic.SingleNote.NoteType noteType, IzakayaMusic.SingleNote.NotePosition positionType)
			{
			}

			// Token: 0x17000720 RID: 1824
			// (get) Token: 0x060036BD RID: 14013 RVA: 0x00014B80 File Offset: 0x00012D80
			[Token(Token = "0x17000720")]
			private static long m_CalibrationOffset
			{
				[Token(Token = "0x60036BD")]
				[Address(RVA = "0x673240", Offset = "0x671C40", VA = "0x180673240")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x060036BE RID: 14014 RVA: 0x00014B98 File Offset: 0x00012D98
			[Token(Token = "0x17000721")]
			public long CorrectedStartTime
			{
				[Token(Token = "0x60036BE")]
				[Address(RVA = "0x6731E0", Offset = "0x671BE0", VA = "0x1806731E0")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x060036BF RID: 14015 RVA: 0x00014BB0 File Offset: 0x00012DB0
			[Token(Token = "0x17000722")]
			public long CorrectedEndTime
			{
				[Token(Token = "0x60036BF")]
				[Address(RVA = "0x673180", Offset = "0x671B80", VA = "0x180673180")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17000723 RID: 1827
			// (get) Token: 0x060036C0 RID: 14016 RVA: 0x00014BC8 File Offset: 0x00012DC8
			[Token(Token = "0x17000723")]
			public long StartTime
			{
				[Token(Token = "0x60036C0")]
				[Address(RVA = "0x4070A0", Offset = "0x405AA0", VA = "0x1804070A0")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x060036C1 RID: 14017 RVA: 0x00014BE0 File Offset: 0x00012DE0
			[Token(Token = "0x17000724")]
			public long EndTime
			{
				[Token(Token = "0x60036C1")]
				[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x060036C2 RID: 14018 RVA: 0x00014BF8 File Offset: 0x00012DF8
			[Token(Token = "0x17000725")]
			public IzakayaMusic.SingleNote.NoteType Type
			{
				[Token(Token = "0x60036C2")]
				[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
				get
				{
					return IzakayaMusic.SingleNote.NoteType.Single;
				}
			}

			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x060036C3 RID: 14019 RVA: 0x00014C10 File Offset: 0x00012E10
			[Token(Token = "0x17000726")]
			public IzakayaMusic.SingleNote.NotePosition Position
			{
				[Token(Token = "0x60036C3")]
				[Address(RVA = "0x653EC0", Offset = "0x6528C0", VA = "0x180653EC0")]
				get
				{
					return IzakayaMusic.SingleNote.NotePosition.None;
				}
			}

			// Token: 0x060036C4 RID: 14020 RVA: 0x00014C28 File Offset: 0x00012E28
			[Token(Token = "0x60036C4")]
			[Address(RVA = "0x672E10", Offset = "0x671810", VA = "0x180672E10")]
			public IzakayaMusic.SingleNote CreateEnd()
			{
				return default(IzakayaMusic.SingleNote);
			}

			// Token: 0x060036C5 RID: 14021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60036C5")]
			[Address(RVA = "0x672E40", Offset = "0x671840", VA = "0x180672E40")]
			public static void PreloadCalibration(Func<long> getCalibrationCallback)
			{
			}

			// Token: 0x060036C6 RID: 14022 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60036C6")]
			[Address(RVA = "0x672EA0", Offset = "0x6718A0", VA = "0x180672EA0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04002F3B RID: 12091
			[Token(Token = "0x4002F3B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Func<long> m_GetCalibrationCallback;

			// Token: 0x04002F3C RID: 12092
			[Token(Token = "0x4002F3C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			private long startTime;

			// Token: 0x04002F3D RID: 12093
			[Token(Token = "0x4002F3D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			private long endTime;

			// Token: 0x04002F3E RID: 12094
			[Token(Token = "0x4002F3E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private IzakayaMusic.SingleNote.NoteType noteType;

			// Token: 0x04002F3F RID: 12095
			[Token(Token = "0x4002F3F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			private IzakayaMusic.SingleNote.NotePosition positionType;

			// Token: 0x020008B1 RID: 2225
			[Token(Token = "0x20008B1")]
			[Flags]
			public enum NotePosition : byte
			{
				// Token: 0x04002F41 RID: 12097
				[Token(Token = "0x4002F41")]
				None = 0,
				// Token: 0x04002F42 RID: 12098
				[Token(Token = "0x4002F42")]
				Left = 1,
				// Token: 0x04002F43 RID: 12099
				[Token(Token = "0x4002F43")]
				Right = 2,
				// Token: 0x04002F44 RID: 12100
				[Token(Token = "0x4002F44")]
				Any = 3
			}

			// Token: 0x020008B2 RID: 2226
			[Token(Token = "0x20008B2")]
			public enum NoteType
			{
				// Token: 0x04002F46 RID: 12102
				[Token(Token = "0x4002F46")]
				Single,
				// Token: 0x04002F47 RID: 12103
				[Token(Token = "0x4002F47")]
				Hold,
				// Token: 0x04002F48 RID: 12104
				[Token(Token = "0x4002F48")]
				HoldSingle,
				// Token: 0x04002F49 RID: 12105
				[Token(Token = "0x4002F49")]
				HoldEnd
			}
		}
	}
}

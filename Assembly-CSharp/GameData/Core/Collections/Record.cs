using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections
{
	// Token: 0x020008DB RID: 2267
	[Token(Token = "0x20008DB")]
	[Serializable]
	public class Record : Item
	{
		// Token: 0x06003867 RID: 14439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003867")]
		[Address(RVA = "0x689310", Offset = "0x687D10", VA = "0x180689310")]
		public Record(int id, string nameKey, AssetReference targetBGMReference, KeyValuePair<Sprite, Sprite> playerImage)
		{
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06003868 RID: 14440 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003869 RID: 14441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A6")]
		public string NameKey
		{
			[Token(Token = "0x6003868")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003869")]
			[Address(RVA = "0x3FC090", Offset = "0x3FAA90", VA = "0x1803FC090")]
			set
			{
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x0600386A RID: 14442 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600386B RID: 14443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A7")]
		public AssetReference TargetBGMReference
		{
			[Token(Token = "0x600386A")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600386B")]
			[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
			set
			{
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x0600386C RID: 14444 RVA: 0x00015558 File Offset: 0x00013758
		// (set) Token: 0x0600386D RID: 14445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A8")]
		public KeyValuePair<Sprite, Sprite> PlayerImage
		{
			[Token(Token = "0x600386C")]
			[Address(RVA = "0x6893C0", Offset = "0x687DC0", VA = "0x1806893C0")]
			get
			{
				return default(KeyValuePair<Sprite, Sprite>);
			}
			[Token(Token = "0x600386D")]
			[Address(RVA = "0x689420", Offset = "0x687E20", VA = "0x180689420")]
			set
			{
			}
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600386E")]
		[Address(RVA = "0x6892A0", Offset = "0x687CA0", VA = "0x1806892A0")]
		private void SetImage(KeyValuePair<Sprite, Sprite> valuePair)
		{
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x00015570 File Offset: 0x00013770
		[Token(Token = "0x600386F")]
		[Address(RVA = "0x440570", Offset = "0x43EF70", VA = "0x180440570")]
		public int GetIzakayaMusicPackageIndex()
		{
			return 0;
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x00015588 File Offset: 0x00013788
		[Token(Token = "0x6003870")]
		[Address(RVA = "0x476FF0", Offset = "0x4759F0", VA = "0x180476FF0")]
		public int GetIzakayaMusicIndex()
		{
			return 0;
		}

		// Token: 0x04003030 RID: 12336
		[Token(Token = "0x4003030")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string nameKey;

		// Token: 0x04003031 RID: 12337
		[Token(Token = "0x4003031")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AssetReference targetBGMReference;

		// Token: 0x04003032 RID: 12338
		[Token(Token = "0x4003032")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite selectedImage;

		// Token: 0x04003033 RID: 12339
		[Token(Token = "0x4003033")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite deselectedImage;

		// Token: 0x04003034 RID: 12340
		[Token(Token = "0x4003034")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int IzakayaMusicPackageIndex;

		// Token: 0x04003035 RID: 12341
		[Token(Token = "0x4003035")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private int IzakayaMusicIndex;
	}
}

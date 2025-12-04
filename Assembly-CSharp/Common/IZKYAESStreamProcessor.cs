using System;
using System.IO;
using Il2CppDummyDll;
using UnityEngine.ResourceManagement.ResourceProviders;

namespace Common
{
	// Token: 0x02000D26 RID: 3366
	[Token(Token = "0x2000D26")]
	public class IZKYAESStreamProcessor : IDataConverter
	{
		// Token: 0x06004E3B RID: 20027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3B")]
		[Address(RVA = "0x7ADB10", Offset = "0x7AC510", VA = "0x1807ADB10", Slot = "5")]
		public Stream CreateReadStream(Stream input, string id)
		{
			return null;
		}

		// Token: 0x06004E3C RID: 20028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E3C")]
		[Address(RVA = "0x7ADBC0", Offset = "0x7AC5C0", VA = "0x1807ADBC0", Slot = "4")]
		public Stream CreateWriteStream(Stream input, string id)
		{
			return null;
		}

		// Token: 0x06004E3D RID: 20029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E3D")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public IZKYAESStreamProcessor()
		{
		}

		// Token: 0x02000D27 RID: 3367
		[Token(Token = "0x2000D27")]
		public class EncryptStream : Stream
		{
			// Token: 0x17000B4D RID: 2893
			// (get) Token: 0x06004E3E RID: 20030 RVA: 0x0001C620 File Offset: 0x0001A820
			[Token(Token = "0x17000B4D")]
			public override bool CanRead
			{
				[Token(Token = "0x6004E3E")]
				[Address(RVA = "0x7AB730", Offset = "0x7AA130", VA = "0x1807AB730", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000B4E RID: 2894
			// (get) Token: 0x06004E3F RID: 20031 RVA: 0x0001C638 File Offset: 0x0001A838
			[Token(Token = "0x17000B4E")]
			public override bool CanSeek
			{
				[Token(Token = "0x6004E3F")]
				[Address(RVA = "0x7AB760", Offset = "0x7AA160", VA = "0x1807AB760", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000B4F RID: 2895
			// (get) Token: 0x06004E40 RID: 20032 RVA: 0x0001C650 File Offset: 0x0001A850
			[Token(Token = "0x17000B4F")]
			public override bool CanWrite
			{
				[Token(Token = "0x6004E40")]
				[Address(RVA = "0x7AB790", Offset = "0x7AA190", VA = "0x1807AB790", Slot = "10")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000B50 RID: 2896
			// (get) Token: 0x06004E41 RID: 20033 RVA: 0x0001C668 File Offset: 0x0001A868
			[Token(Token = "0x17000B50")]
			public override long Length
			{
				[Token(Token = "0x6004E41")]
				[Address(RVA = "0x7AB7C0", Offset = "0x7AA1C0", VA = "0x1807AB7C0", Slot = "11")]
				get
				{
					return 0L;
				}
			}

			// Token: 0x17000B51 RID: 2897
			// (get) Token: 0x06004E42 RID: 20034 RVA: 0x0001C680 File Offset: 0x0001A880
			// (set) Token: 0x06004E43 RID: 20035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000B51")]
			public override long Position
			{
				[Token(Token = "0x6004E42")]
				[Address(RVA = "0x7AB7F0", Offset = "0x7AA1F0", VA = "0x1807AB7F0", Slot = "12")]
				get
				{
					return 0L;
				}
				[Token(Token = "0x6004E43")]
				[Address(RVA = "0x7AB820", Offset = "0x7AA220", VA = "0x1807AB820", Slot = "13")]
				set
				{
				}
			}

			// Token: 0x06004E44 RID: 20036 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E44")]
			[Address(RVA = "0x7AB2E0", Offset = "0x7A9CE0", VA = "0x1807AB2E0")]
			public EncryptStream(Stream stream, string key, string identifier)
			{
			}

			// Token: 0x06004E45 RID: 20037 RVA: 0x0001C698 File Offset: 0x0001A898
			[Token(Token = "0x6004E45")]
			[Address(RVA = "0x7AB0A0", Offset = "0x7A9AA0", VA = "0x1807AB0A0", Slot = "34")]
			public override int Read(byte[] array, int offset, int count)
			{
				return 0;
			}

			// Token: 0x06004E46 RID: 20038 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E46")]
			[Address(RVA = "0x7AB200", Offset = "0x7A9C00", VA = "0x1807AB200", Slot = "37")]
			public override void Write(byte[] array, int offset, int count)
			{
			}

			// Token: 0x06004E47 RID: 20039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E47")]
			[Address(RVA = "0x7AB070", Offset = "0x7A9A70", VA = "0x1807AB070", Slot = "22")]
			public override void Flush()
			{
			}

			// Token: 0x06004E48 RID: 20040 RVA: 0x0001C6B0 File Offset: 0x0001A8B0
			[Token(Token = "0x6004E48")]
			[Address(RVA = "0x7AB1A0", Offset = "0x7A9BA0", VA = "0x1807AB1A0", Slot = "32")]
			public override long Seek(long offset, SeekOrigin origin)
			{
				return 0L;
			}

			// Token: 0x06004E49 RID: 20041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004E49")]
			[Address(RVA = "0x7AB1D0", Offset = "0x7A9BD0", VA = "0x1807AB1D0", Slot = "33")]
			public override void SetLength(long value)
			{
			}

			// Token: 0x040047CA RID: 18378
			[Token(Token = "0x40047CA")]
			[FieldOffset(Offset = "0x28")]
			private readonly Stream _stream;

			// Token: 0x040047CB RID: 18379
			[Token(Token = "0x40047CB")]
			[FieldOffset(Offset = "0x30")]
			private readonly int _identifier;

			// Token: 0x040047CC RID: 18380
			[Token(Token = "0x40047CC")]
			[FieldOffset(Offset = "0x34")]
			private readonly int keyBytes;
		}
	}
}

using System;
using DEYU.Singletons;
using Il2CppDummyDll;

namespace Common
{
	// Token: 0x02000D82 RID: 3458
	[Token(Token = "0x2000D82")]
	public class DataExporter : MonoSingletonPersistant<DataExporter>
	{
		// Token: 0x0600510A RID: 20746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510A")]
		[Address(RVA = "0x7DAC70", Offset = "0x7D9670", VA = "0x1807DAC70")]
		public void Init()
		{
		}

		// Token: 0x0600510B RID: 20747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510B")]
		[Address(RVA = "0x7DADE0", Offset = "0x7D97E0", VA = "0x1807DADE0")]
		public DataExporter()
		{
		}

		// Token: 0x04004C05 RID: 19461
		[Token(Token = "0x4004C05")]
		[FieldOffset(Offset = "0x18")]
		public DataExporterInput inputAction;
	}
}

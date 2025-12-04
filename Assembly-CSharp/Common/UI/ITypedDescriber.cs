using System;
using System.Threading;
using Il2CppDummyDll;

namespace Common.UI
{
	// Token: 0x02000DED RID: 3565
	[Token(Token = "0x2000DED")]
	public interface ITypedDescriber<in T> : IDescriber
	{
		// Token: 0x0600536F RID: 21359
		[Token(Token = "0x600536F")]
		void Describe(T data, CancellationToken cancellationToken);
	}
}

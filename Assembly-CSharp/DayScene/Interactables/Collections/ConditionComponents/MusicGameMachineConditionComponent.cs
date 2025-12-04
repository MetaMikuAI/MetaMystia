using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x020004C9 RID: 1225
	[Token(Token = "0x20004C9")]
	[GenerateCleanupMethod]
	public class MusicGameMachineConditionComponent : EntityConditionComponent
	{
		// Token: 0x06001BD6 RID: 7126 RVA: 0x0000AB30 File Offset: 0x00008D30
		[Token(Token = "0x6001BD6")]
		[Address(RVA = "0x4A1950", Offset = "0x4A0350", VA = "0x1804A1950", Slot = "9")]
		protected override bool OnGetAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BD7 RID: 7127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BD7")]
		[Address(RVA = "0x4A18F0", Offset = "0x4A02F0", VA = "0x1804A18F0", Slot = "4")]
		protected override Type GetComponentType()
		{
			return null;
		}

		// Token: 0x06001BD8 RID: 7128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD8")]
		[Address(RVA = "0x494090", Offset = "0x492A90", VA = "0x180494090", Slot = "10")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001BD9 RID: 7129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD9")]
		[Address(RVA = "0x4A19E0", Offset = "0x4A03E0", VA = "0x1804A19E0")]
		public MusicGameMachineConditionComponent()
		{
		}

		// Token: 0x04001973 RID: 6515
		[Token(Token = "0x4001973")]
		public const string INTERACTABLE_KEY = "DLC2.5_MusicMachine";

		// Token: 0x04001974 RID: 6516
		[Token(Token = "0x4001974")]
		public const string MAIN_MAP_LABEL = "BeastForest";
	}
}

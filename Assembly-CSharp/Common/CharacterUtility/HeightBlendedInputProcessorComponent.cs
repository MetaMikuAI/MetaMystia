using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Common.CharacterUtility
{
	// Token: 0x0200103F RID: 4159
	[Token(Token = "0x200103F")]
	[GenerateCleanupMethod]
	public class HeightBlendedInputProcessorComponent : CharacterControllerUnitInputProcessorComponent
	{
		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06006009 RID: 24585 RVA: 0x000211F8 File Offset: 0x0001F3F8
		[Token(Token = "0x17000D45")]
		private Vector3Int GridPosition
		{
			[Token(Token = "0x6006009")]
			[Address(RVA = "0x8C88C0", Offset = "0x8C72C0", VA = "0x1808C88C0")]
			get
			{
				return default(Vector3Int);
			}
		}

		// Token: 0x0600600A RID: 24586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600600A")]
		[Address(RVA = "0x8C82A0", Offset = "0x8C6CA0", VA = "0x1808C82A0")]
		public void Initialize(Tilemap heightMap)
		{
		}

		// Token: 0x0600600B RID: 24587 RVA: 0x00021210 File Offset: 0x0001F410
		[Token(Token = "0x600600B")]
		[Address(RVA = "0x8C82C0", Offset = "0x8C6CC0", VA = "0x1808C82C0", Slot = "5")]
		public override Vector2 OnInputPassed(Vector2 input)
		{
			return default(Vector2);
		}

		// Token: 0x0600600C RID: 24588 RVA: 0x00021228 File Offset: 0x0001F428
		[Token(Token = "0x600600C")]
		[Address(RVA = "0x8C83A0", Offset = "0x8C6DA0", VA = "0x1808C83A0")]
		private float SampleColorAtCurrentCoordinate()
		{
			return 0f;
		}

		// Token: 0x0600600D RID: 24589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600600D")]
		[Address(RVA = "0x861FA0", Offset = "0x8609A0", VA = "0x180861FA0", Slot = "4")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600600E RID: 24590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600600E")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public HeightBlendedInputProcessorComponent()
		{
		}

		// Token: 0x040058DD RID: 22749
		[Token(Token = "0x40058DD")]
		[FieldOffset(Offset = "0x20")]
		private Tilemap heightMap;
	}
}

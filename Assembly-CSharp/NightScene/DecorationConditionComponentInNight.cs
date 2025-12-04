using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NightScene
{
	// Token: 0x02000547 RID: 1351
	[Token(Token = "0x2000547")]
	public class DecorationConditionComponentInNight : MonoBehaviour
	{
		// Token: 0x06001E02 RID: 7682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E02")]
		[Address(RVA = "0x4AD460", Offset = "0x4ABE60", VA = "0x1804AD460")]
		public static void ForceActivateFiltered(Predicate<int> filter)
		{
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E03")]
		[Address(RVA = "0x4AD3D0", Offset = "0x4ABDD0", VA = "0x1804AD3D0")]
		private void Awake()
		{
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E04")]
		[Address(RVA = "0x4AD680", Offset = "0x4AC080", VA = "0x1804AD680")]
		private void UpdateGameObjectMode()
		{
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E05")]
		[Address(RVA = "0x4AD600", Offset = "0x4AC000", VA = "0x1804AD600")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E06")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public DecorationConditionComponentInNight()
		{
		}

		// Token: 0x04001BB5 RID: 7093
		[Token(Token = "0x4001BB5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<DecorationConditionComponentInNight> s_AllComponents;

		// Token: 0x04001BB6 RID: 7094
		[Token(Token = "0x4001BB6")]
		[FieldOffset(Offset = "0x18")]
		public int decorationId;

		// Token: 0x04001BB7 RID: 7095
		[Token(Token = "0x4001BB7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_OverrideActiveState;
	}
}

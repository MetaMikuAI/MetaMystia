using System;
using System.Runtime.CompilerServices;
using System.Threading;
using GameData.CoreLanguage;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000DF0 RID: 3568
	[Token(Token = "0x2000DF0")]
	[GenerateCleanupMethod]
	public class LanguageBaseDescriber : MonoBehaviour, ITypedDescriber<LanguageBase>, IDescriber
	{
		// Token: 0x06005372 RID: 21362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005372")]
		[Address(RVA = "0x43B080", Offset = "0x439A80", VA = "0x18043B080")]
		private void Start()
		{
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005373")]
		[Address(RVA = "0x83B9E0", Offset = "0x83A3E0", VA = "0x18083B9E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06005374 RID: 21364 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005375 RID: 21365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000030")]
		public event Action OnToggleToLanguageBase
		{
			[Token(Token = "0x6005374")]
			[Address(RVA = "0x83BC40", Offset = "0x83A640", VA = "0x18083BC40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005375")]
			[Address(RVA = "0x83BD80", Offset = "0x83A780", VA = "0x18083BD80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06005376 RID: 21366 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005377 RID: 21367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000031")]
		public event Action OnToggleToNull
		{
			[Token(Token = "0x6005376")]
			[Address(RVA = "0x83BCE0", Offset = "0x83A6E0", VA = "0x18083BCE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005377")]
			[Address(RVA = "0x83BE20", Offset = "0x83A820", VA = "0x18083BE20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005378 RID: 21368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005378")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "6")]
		protected virtual void OnPreload()
		{
		}

		// Token: 0x06005379 RID: 21369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005379")]
		[Address(RVA = "0x83B920", Offset = "0x83A320", VA = "0x18083B920", Slot = "4")]
		public void Describe(LanguageBase detail, CancellationToken cancellationToken)
		{
		}

		// Token: 0x0600537A RID: 21370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600537A")]
		[Address(RVA = "0x83B850", Offset = "0x83A250", VA = "0x18083B850")]
		public void Describe(LanguageBase detail)
		{
		}

		// Token: 0x0600537B RID: 21371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600537B")]
		[Address(RVA = "0x83B7C0", Offset = "0x83A1C0", VA = "0x18083B7C0", Slot = "5")]
		public void DescribeNull()
		{
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600537C")]
		[Address(RVA = "0x83BB60", Offset = "0x83A560", VA = "0x18083BB60")]
		private void TrySetDescription(string message)
		{
		}

		// Token: 0x0600537D RID: 21373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600537D")]
		[Address(RVA = "0x83B9D0", Offset = "0x83A3D0", VA = "0x18083B9D0", Slot = "7")]
		protected virtual void HideElements()
		{
		}

		// Token: 0x0600537E RID: 21374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600537E")]
		[Address(RVA = "0x83BAC0", Offset = "0x83A4C0", VA = "0x18083BAC0")]
		public void ToggleVisualForLanguageBase()
		{
		}

		// Token: 0x0600537F RID: 21375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600537F")]
		[Address(RVA = "0x83BB10", Offset = "0x83A510", VA = "0x18083BB10")]
		public void ToggleVisualForNull()
		{
		}

		// Token: 0x06005380 RID: 21376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005380")]
		[Address(RVA = "0x83B930", Offset = "0x83A330", VA = "0x18083B930")]
		public void HideAllChildObject()
		{
		}

		// Token: 0x06005381 RID: 21377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005381")]
		[Address(RVA = "0x83BA20", Offset = "0x83A420", VA = "0x18083BA20")]
		public void ShowAllChildObjct()
		{
		}

		// Token: 0x06005382 RID: 21378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005382")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "8")]
		protected virtual void OnDescriberDestroyed()
		{
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005383")]
		[Address(RVA = "0x83B720", Offset = "0x83A120", VA = "0x18083B720", Slot = "9")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005384")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public LanguageBaseDescriber()
		{
		}

		// Token: 0x04004E6B RID: 20075
		[Token(Token = "0x4004E6B")]
		protected const int PreloadAmount = 5;

		// Token: 0x04004E6C RID: 20076
		[Token(Token = "0x4004E6C")]
		[FieldOffset(Offset = "0x18")]
		[Header("Base")]
		public GameObject[] allElementsToHide;

		// Token: 0x04004E6D RID: 20077
		[Token(Token = "0x4004E6D")]
		[FieldOffset(Offset = "0x20")]
		[Header("Null")]
		public GameObject[] nullVisual;

		// Token: 0x04004E6E RID: 20078
		[Token(Token = "0x4004E6E")]
		[FieldOffset(Offset = "0x28")]
		[Header("Language")]
		public TextMeshProUGUI objectName;

		// Token: 0x04004E6F RID: 20079
		[Token(Token = "0x4004E6F")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI objectDescription;

		// Token: 0x04004E70 RID: 20080
		[Token(Token = "0x4004E70")]
		[FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI objectDescription_optional;

		// Token: 0x04004E71 RID: 20081
		[Token(Token = "0x4004E71")]
		[FieldOffset(Offset = "0x40")]
		public bool longDescriptionMode;

		// Token: 0x04004E72 RID: 20082
		[Token(Token = "0x4004E72")]
		[FieldOffset(Offset = "0x48")]
		public GameObject[] languageBaseVisual;
	}
}

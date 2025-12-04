using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Serialization;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x020005CC RID: 1484
	[Token(Token = "0x20005CC")]
	[GenerateCleanupMethod]
	public class GuestTableDisplayer : MonoBehaviour
	{
		// Token: 0x0600223A RID: 8762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223A")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223B")]
		[Address(RVA = "0x5180F0", Offset = "0x516AF0", VA = "0x1805180F0")]
		public void ShowMood()
		{
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223C")]
		[Address(RVA = "0x517FC0", Offset = "0x5169C0", VA = "0x180517FC0")]
		public void SetMoodProgress(float progress)
		{
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223D")]
		[Address(RVA = "0x518440", Offset = "0x516E40", VA = "0x180518440")]
		public void UpdatePatient(int progress)
		{
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223E")]
		[Address(RVA = "0x517D90", Offset = "0x516790", VA = "0x180517D90")]
		public void DisablePatient()
		{
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600223F")]
		[Address(RVA = "0x517DC0", Offset = "0x5167C0", VA = "0x180517DC0")]
		public void Initialize(int index)
		{
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002240")]
		[Address(RVA = "0x517E40", Offset = "0x516840", VA = "0x180517E40")]
		public void ResetValue()
		{
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002241")]
		[Address(RVA = "0x517CC0", Offset = "0x5166C0", VA = "0x180517CC0")]
		public void CleanDesk()
		{
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002242")]
		[Address(RVA = "0x517F60", Offset = "0x516960", VA = "0x180517F60")]
		public void SetFoodVisual(Sprite food)
		{
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002243")]
		[Address(RVA = "0x517F10", Offset = "0x516910", VA = "0x180517F10")]
		public void SetBeverageVisual(Sprite beverage)
		{
		}

		// Token: 0x06002244 RID: 8772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002244")]
		[Address(RVA = "0x5180B0", Offset = "0x516AB0", VA = "0x1805180B0")]
		private void SetValue(Sprite food, Sprite beverage)
		{
		}

		// Token: 0x06002245 RID: 8773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002245")]
		[Address(RVA = "0x517CF0", Offset = "0x5166F0", VA = "0x180517CF0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002246 RID: 8774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002246")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public GuestTableDisplayer()
		{
		}

		// Token: 0x06002247 RID: 8775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002247")]
		[Address(RVA = "0x518240", Offset = "0x516C40", VA = "0x180518240")]
		[CompilerGenerated]
		internal static void <SetValue>g__SetupRenderer|22_0(SpriteRenderer renderer, Sprite target)
		{
		}

		// Token: 0x04001EFD RID: 7933
		[Token(Token = "0x4001EFD")]
		private const float RENDERER_INITIAL_Y = 0.1875f;

		// Token: 0x04001EFE RID: 7934
		[Token(Token = "0x4001EFE")]
		[FieldOffset(Offset = "0x18")]
		public SpriteRenderer foodRenderer;

		// Token: 0x04001EFF RID: 7935
		[Token(Token = "0x4001EFF")]
		[FieldOffset(Offset = "0x20")]
		public SpriteRenderer beverageRenderer;

		// Token: 0x04001F00 RID: 7936
		[Token(Token = "0x4001F00")]
		[FieldOffset(Offset = "0x28")]
		public SpriteRenderer moodRenderer;

		// Token: 0x04001F01 RID: 7937
		[Token(Token = "0x4001F01")]
		[FieldOffset(Offset = "0x30")]
		public SpriteRenderer moodBarRenderer;

		// Token: 0x04001F02 RID: 7938
		[Token(Token = "0x4001F02")]
		[FieldOffset(Offset = "0x38")]
		public float moodRendererToggleDuration;

		// Token: 0x04001F03 RID: 7939
		[Token(Token = "0x4001F03")]
		[FieldOffset(Offset = "0x40")]
		public TextMeshPro deskCode;

		// Token: 0x04001F04 RID: 7940
		[Token(Token = "0x4001F04")]
		[FieldOffset(Offset = "0x48")]
		public GameObject deskCodeDisplayer;

		// Token: 0x04001F05 RID: 7941
		[Token(Token = "0x4001F05")]
		[FieldOffset(Offset = "0x50")]
		public Sprite[] allProgressBars;

		// Token: 0x04001F06 RID: 7942
		[Token(Token = "0x4001F06")]
		[FieldOffset(Offset = "0x58")]
		public SpriteRenderer patientProgress;

		// Token: 0x04001F07 RID: 7943
		[Token(Token = "0x4001F07")]
		[FieldOffset(Offset = "0x60")]
		[FormerlySerializedAs("m_SizeMinMax")]
		[SerializeField]
		private Vector2 m_MoodSizeMinMax;

		// Token: 0x04001F08 RID: 7944
		[Token(Token = "0x4001F08")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector2 m_PatientSizeMinMax;
	}
}

using System;
using System.Collections;
using DEYU.Utils;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Rendering;

namespace Common.CharacterUtility
{
	// Token: 0x02001032 RID: 4146
	[Token(Token = "0x2001032")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(Animator), typeof(SortingGroup))]
	public class CharacterAnimator : LayerSortingController
	{
		// Token: 0x17000D2E RID: 3374
		// (set) Token: 0x06005F94 RID: 24468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D2E")]
		public float Speed
		{
			[Token(Token = "0x6005F94")]
			[Address(RVA = "0x8C3B40", Offset = "0x8C2540", VA = "0x1808C3B40")]
			set
			{
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (set) Token: 0x06005F95 RID: 24469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D2F")]
		public string sortingLayerName
		{
			[Token(Token = "0x6005F95")]
			[Address(RVA = "0x8C3B70", Offset = "0x8C2570", VA = "0x1808C3B70")]
			set
			{
			}
		}

		// Token: 0x06005F96 RID: 24470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F96")]
		[Address(RVA = "0x8C3570", Offset = "0x8C1F70", VA = "0x1808C3570")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005F97 RID: 24471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F97")]
		[Address(RVA = "0x8C32C0", Offset = "0x8C1CC0", VA = "0x1808C32C0")]
		public void Initialize(CharacterSpriteSetCompact characterSpriteSet, SpriteRenderer pfxRender, SpriteRenderer faceRenderer, SpriteRenderer aoRenderer, AudioClip[] stepSFX, Transform backTrimPartent, Transform frontTrimParent)
		{
		}

		// Token: 0x06005F98 RID: 24472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F98")]
		[Address(RVA = "0x8C3880", Offset = "0x8C2280", VA = "0x1808C3880")]
		public void SetOrientation(int orientation)
		{
		}

		// Token: 0x06005F99 RID: 24473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F99")]
		[Address(RVA = "0x8C3240", Offset = "0x8C1C40", VA = "0x1808C3240")]
		private IEnumerator HinaSpecialMove()
		{
			return null;
		}

		// Token: 0x06005F9A RID: 24474 RVA: 0x00021060 File Offset: 0x0001F260
		[Token(Token = "0x6005F9A")]
		[Address(RVA = "0x8C31F0", Offset = "0x8C1BF0", VA = "0x1808C31F0")]
		public int GetOrientation()
		{
			return 0;
		}

		// Token: 0x06005F9B RID: 24475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9B")]
		[Address(RVA = "0x8C37C0", Offset = "0x8C21C0", VA = "0x1808C37C0")]
		public void SetMoving(bool isMoving)
		{
		}

		// Token: 0x06005F9C RID: 24476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9C")]
		[Address(RVA = "0x8C36D0", Offset = "0x8C20D0", VA = "0x1808C36D0")]
		private void SetFace(int face)
		{
		}

		// Token: 0x06005F9D RID: 24477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9D")]
		[Address(RVA = "0x8C3670", Offset = "0x8C2070", VA = "0x1808C3670")]
		public void SetFaceExtern(int face)
		{
		}

		// Token: 0x06005F9E RID: 24478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9E")]
		[Address(RVA = "0x8C39A0", Offset = "0x8C23A0", VA = "0x1808C39A0")]
		public void SetTimedPFX(Sprite[] pfx, float length)
		{
		}

		// Token: 0x06005F9F RID: 24479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F9F")]
		[Address(RVA = "0x8C38E0", Offset = "0x8C22E0", VA = "0x1808C38E0")]
		public void SetPFX(Sprite[] pfx)
		{
		}

		// Token: 0x06005FA0 RID: 24480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA0")]
		[Address(RVA = "0x8C3620", Offset = "0x8C2020", VA = "0x1808C3620")]
		public void ReleasePFX()
		{
		}

		// Token: 0x06005FA1 RID: 24481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA1")]
		[Address(RVA = "0x8C3070", Offset = "0x8C1A70", VA = "0x1808C3070")]
		public void AnimatorUpdatePFX()
		{
		}

		// Token: 0x06005FA2 RID: 24482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005FA2")]
		[Address(RVA = "0x8C3590", Offset = "0x8C1F90", VA = "0x1808C3590")]
		private IEnumerator OnPFXUpdating(float length)
		{
			return null;
		}

		// Token: 0x06005FA3 RID: 24483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA3")]
		[Address(RVA = "0x8C2F80", Offset = "0x8C1980", VA = "0x1808C2F80", Slot = "5")]
		public virtual void AnimatorSetStep(int step)
		{
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA4")]
		[Address(RVA = "0x8C2E50", Offset = "0x8C1850", VA = "0x1808C2E50", Slot = "6")]
		protected virtual void AnimatorSetOrientation(int orientation)
		{
		}

		// Token: 0x06005FA5 RID: 24485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA5")]
		[Address(RVA = "0x8C3AF0", Offset = "0x8C24F0", VA = "0x1808C3AF0")]
		private void UpdateVisual()
		{
		}

		// Token: 0x06005FA6 RID: 24486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA6")]
		[Address(RVA = "0x8C3A80", Offset = "0x8C2480", VA = "0x1808C3A80")]
		public void UpdateVisualExtern()
		{
		}

		// Token: 0x06005FA7 RID: 24487 RVA: 0x00021078 File Offset: 0x0001F278
		[Token(Token = "0x6005FA7")]
		[Address(RVA = "0x8C3970", Offset = "0x8C2370", VA = "0x1808C3970", Slot = "7")]
		protected virtual bool SetSprite(int spriteCode, int faceCode)
		{
			return default(bool);
		}

		// Token: 0x06005FA8 RID: 24488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA8")]
		[Address(RVA = "0x8C30D0", Offset = "0x8C1AD0", VA = "0x1808C30D0", Slot = "4")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005FA9 RID: 24489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FA9")]
		[Address(RVA = "0x8C29D0", Offset = "0x8C13D0", VA = "0x1808C29D0")]
		public CharacterAnimator()
		{
		}

		// Token: 0x0400588E RID: 22670
		[Token(Token = "0x400588E")]
		private const int BACK_TRIM_INDEX = 8;

		// Token: 0x0400588F RID: 22671
		[Token(Token = "0x400588F")]
		private const int FRONT_TRIM_INDEX = 0;

		// Token: 0x04005890 RID: 22672
		[Token(Token = "0x4005890")]
		[FieldOffset(Offset = "0x48")]
		public bool shouldHaveStepSFX;

		// Token: 0x04005891 RID: 22673
		[Token(Token = "0x4005891")]
		[FieldOffset(Offset = "0x4C")]
		private float animationSpeedMultiplier;

		// Token: 0x04005892 RID: 22674
		[Token(Token = "0x4005892")]
		[FieldOffset(Offset = "0x50")]
		protected Animator animator;

		// Token: 0x04005893 RID: 22675
		[Token(Token = "0x4005893")]
		[FieldOffset(Offset = "0x58")]
		protected Transform backTrimPartent;

		// Token: 0x04005894 RID: 22676
		[Token(Token = "0x4005894")]
		[FieldOffset(Offset = "0x60")]
		protected SortingGroup backTrimSortingGroup;

		// Token: 0x04005895 RID: 22677
		[Token(Token = "0x4005895")]
		[FieldOffset(Offset = "0x68")]
		protected CharacterSpriteSetCompact characterSpriteSet;

		// Token: 0x04005896 RID: 22678
		[Token(Token = "0x4005896")]
		[FieldOffset(Offset = "0x70")]
		protected int face;

		// Token: 0x04005897 RID: 22679
		[Token(Token = "0x4005897")]
		[FieldOffset(Offset = "0x74")]
		protected int faceId;

		// Token: 0x04005898 RID: 22680
		[Token(Token = "0x4005898")]
		[FieldOffset(Offset = "0x78")]
		protected SpriteRenderer faceRenderer;

		// Token: 0x04005899 RID: 22681
		[Token(Token = "0x4005899")]
		[FieldOffset(Offset = "0x80")]
		protected Transform frontTrimParent;

		// Token: 0x0400589A RID: 22682
		[Token(Token = "0x400589A")]
		[FieldOffset(Offset = "0x88")]
		protected SortingGroup frontTrimSortingGroup;

		// Token: 0x0400589B RID: 22683
		[Token(Token = "0x400589B")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine hinaRotateCoroutine;

		// Token: 0x0400589C RID: 22684
		[Token(Token = "0x400589C")]
		[FieldOffset(Offset = "0x98")]
		private bool isHina;

		// Token: 0x0400589D RID: 22685
		[Token(Token = "0x400589D")]
		[FieldOffset(Offset = "0x9C")]
		protected int lastFace;

		// Token: 0x0400589E RID: 22686
		[Token(Token = "0x400589E")]
		[FieldOffset(Offset = "0xA0")]
		protected int lastSprite;

		// Token: 0x0400589F RID: 22687
		[Token(Token = "0x400589F")]
		[FieldOffset(Offset = "0xA8")]
		protected Coroutine onPFXUpdate;

		// Token: 0x040058A0 RID: 22688
		[Token(Token = "0x40058A0")]
		[FieldOffset(Offset = "0xB0")]
		protected int orientation;

		// Token: 0x040058A1 RID: 22689
		[Token(Token = "0x40058A1")]
		[FieldOffset(Offset = "0xB8")]
		protected Sprite[] pfx;

		// Token: 0x040058A2 RID: 22690
		[Token(Token = "0x40058A2")]
		[FieldOffset(Offset = "0xC0")]
		protected int pfxEnumrator;

		// Token: 0x040058A3 RID: 22691
		[Token(Token = "0x40058A3")]
		[FieldOffset(Offset = "0xC8")]
		protected SpriteRenderer pfxRender;

		// Token: 0x040058A4 RID: 22692
		[Token(Token = "0x40058A4")]
		[FieldOffset(Offset = "0xD0")]
		private int removableTrimBackLayer;

		// Token: 0x040058A5 RID: 22693
		[Token(Token = "0x40058A5")]
		[FieldOffset(Offset = "0xD4")]
		private int removableTrimFrontLayer;

		// Token: 0x040058A6 RID: 22694
		[Token(Token = "0x40058A6")]
		[FieldOffset(Offset = "0xD8")]
		private float rotatePerTime;

		// Token: 0x040058A7 RID: 22695
		[Token(Token = "0x40058A7")]
		[FieldOffset(Offset = "0xDC")]
		protected int step;

		// Token: 0x040058A8 RID: 22696
		[Token(Token = "0x40058A8")]
		[FieldOffset(Offset = "0xE0")]
		private AudioClip[] stepSFX;

		// Token: 0x02001033 RID: 4147
		[Token(Token = "0x2001033")]
		public enum AnimatorType
		{
			// Token: 0x040058AA RID: 22698
			[Token(Token = "0x40058AA")]
			Layered,
			// Token: 0x040058AB RID: 22699
			[Token(Token = "0x40058AB")]
			Compact
		}
	}
}

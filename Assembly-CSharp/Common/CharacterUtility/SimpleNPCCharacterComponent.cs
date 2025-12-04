using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Serialization;

namespace Common.CharacterUtility
{
	// Token: 0x02001043 RID: 4163
	[Token(Token = "0x2001043")]
	[ExecuteAlways]
	[RequireComponent(typeof(CharacterControllerUnit))]
	[GenerateCleanupMethod]
	public class SimpleNPCCharacterComponent : MonoBehaviour
	{
		// Token: 0x06006041 RID: 24641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006041")]
		[Address(RVA = "0x8C93C0", Offset = "0x8C7DC0", VA = "0x1808C93C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06006042 RID: 24642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006042")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006043 RID: 24643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006043")]
		[Address(RVA = "0x8C9500", Offset = "0x8C7F00", VA = "0x1808C9500")]
		private void OnValidate()
		{
		}

		// Token: 0x06006044 RID: 24644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006044")]
		[Address(RVA = "0x8C97A0", Offset = "0x8C81A0", VA = "0x1808C97A0")]
		private void Set()
		{
		}

		// Token: 0x06006045 RID: 24645 RVA: 0x000213D8 File Offset: 0x0001F5D8
		[Token(Token = "0x6006045")]
		[Address(RVA = "0x8C9320", Offset = "0x8C7D20", VA = "0x1808C9320")]
		private ValueTuple<int, int> GetSpriteCode(int orientation, int faceId)
		{
			return default(ValueTuple<int, int>);
		}

		// Token: 0x06006046 RID: 24646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006046")]
		[Address(RVA = "0x6DE240", Offset = "0x6DCC40", VA = "0x1806DE240", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06006047 RID: 24647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006047")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public SimpleNPCCharacterComponent()
		{
		}

		// Token: 0x04005906 RID: 22790
		[Token(Token = "0x4005906")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("m_Compact")]
		[SerializeField]
		private CharacterSpriteSetCompact m_CharacterVisual;

		// Token: 0x04005907 RID: 22791
		[Token(Token = "0x4005907")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("m_SelectedRotation")]
		[SerializeField]
		private int m_FaceDirection;

		// Token: 0x04005908 RID: 22792
		[Token(Token = "0x4005908")]
		[FieldOffset(Offset = "0x24")]
		[FormerlySerializedAs("m_SelectedFace")]
		[SerializeField]
		private int m_SelectedFace;

		// Token: 0x04005909 RID: 22793
		[Token(Token = "0x4005909")]
		[FieldOffset(Offset = "0x28")]
		private CharacterControllerUnit controllerUnit;
	}
}

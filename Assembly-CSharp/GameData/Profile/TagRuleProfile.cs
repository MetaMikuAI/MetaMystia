using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BCF RID: 3023
	[Token(Token = "0x2000BCF")]
	[CreateAssetMenu(fileName = "TagRuleProfile", menuName = "GameData Profile/CreateTagRuleProfile", order = 3)]
	public class TagRuleProfile : ScriptableObject
	{
		// Token: 0x060046D5 RID: 18133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D5")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public TagRuleProfile()
		{
		}

		// Token: 0x04003FF6 RID: 16374
		[Token(Token = "0x4003FF6")]
		[FieldOffset(Offset = "0x18")]
		public TagRule[] rules;

		// Token: 0x04003FF7 RID: 16375
		[Token(Token = "0x4003FF7")]
		[FieldOffset(Offset = "0x20")]
		public IndexProfile previews;

		// Token: 0x04003FF8 RID: 16376
		[Token(Token = "0x4003FF8")]
		[FieldOffset(Offset = "0x28")]
		public TagRuleProfile.TagType tagType;

		// Token: 0x02000BD0 RID: 3024
		[Token(Token = "0x2000BD0")]
		public enum TagType
		{
			// Token: 0x04003FFA RID: 16378
			[Token(Token = "0x4003FFA")]
			[InspectorName("料理Tag覆写规则")]
			FoodTagRule,
			// Token: 0x04003FFB RID: 16379
			[Token(Token = "0x4003FFB")]
			[InspectorName("上位稀客覆写规则")]
			SGuestMappingRule
		}
	}
}

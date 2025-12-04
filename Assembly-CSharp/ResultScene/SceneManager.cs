using System;
using Cysharp.Threading.Tasks;
using GameData.Profile;
using Il2CppDummyDll;
using ResultScene.UI;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace ResultScene
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	[GenerateCleanupMethod]
	public class SceneManager : MonoBehaviour
	{
		// Token: 0x0600035F RID: 863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x42CF10", Offset = "0x42B910", VA = "0x18042CF10")]
		private void Start()
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x42CE70", Offset = "0x42B870", VA = "0x18042CE70")]
		private UniTaskVoid StartAsync()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x42BC70", Offset = "0x42A670", VA = "0x18042BC70")]
		private static void GotoLoadScene()
		{
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x42B4C0", Offset = "0x429EC0", VA = "0x18042B4C0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public SceneManager()
		{
		}

		// Token: 0x04000366 RID: 870
		[Token(Token = "0x4000366")]
		[FieldOffset(Offset = "0x0")]
		public static int? overrideDay;

		// Token: 0x04000367 RID: 871
		[Token(Token = "0x4000367")]
		[FieldOffset(Offset = "0x8")]
		public static int? additiveDay;

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x18")]
		[Header("Pannels Transform")]
		public RectTransform activePannelRoot;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x20")]
		public ResultSceneStatusPannel ResultSceneStatusPannel;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x28")]
		public ResultSceneSavePannel ResultSceneSavePannel;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x30")]
		public LoopedBGMPackage bgm;
	}
}

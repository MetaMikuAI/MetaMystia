using System;
using Cinemachine;
using DEYU.SceneComposer;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace PrototypingManagers
{
	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	public class DialogConstructionSceneManager : MonoBehaviour
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006E")]
		private PlayableDirector Director
		{
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x6E6F30", Offset = "0x6E5930", VA = "0x1806E6F30")]
			get
			{
				return null;
			}
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x6E6D40", Offset = "0x6E5740", VA = "0x1806E6D40")]
		private void Start()
		{
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public DialogConstructionSceneManager()
		{
		}

		// Token: 0x04000584 RID: 1412
		[Token(Token = "0x4000584")]
		[FieldOffset(Offset = "0x18")]
		[Header("Scene Transition")]
		public TransitingModuleBase transitionModule;

		// Token: 0x04000585 RID: 1413
		[Token(Token = "0x4000585")]
		[FieldOffset(Offset = "0x20")]
		public DialogPackage packageToRun;

		// Token: 0x04000586 RID: 1414
		[Token(Token = "0x4000586")]
		[FieldOffset(Offset = "0x28")]
		public CinemachineVirtualCamera virtualCamera;

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		[FieldOffset(Offset = "0x30")]
		private bool m_IsDialogPannelOn;
	}
}

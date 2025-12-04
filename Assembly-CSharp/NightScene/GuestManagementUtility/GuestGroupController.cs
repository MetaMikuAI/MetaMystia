using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.CharacterUtility;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using NightScene.Tiles;
using UnityEngine;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x0200057B RID: 1403
	[Token(Token = "0x200057B")]
	public abstract class GuestGroupController
	{
		// Token: 0x06001FAA RID: 8106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAA")]
		[Address(RVA = "0x4D1A40", Offset = "0x4D0440", VA = "0x1804D1A40")]
		protected GuestGroupController()
		{
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0000BD18 File Offset: 0x00009F18
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000422")]
		public bool DoNotShowHerOrderOnUI
		{
			[Token(Token = "0x6001FAB")]
			[Address(RVA = "0x4D1D60", Offset = "0x4D0760", VA = "0x1804D1D60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FAC")]
			[Address(RVA = "0x4D2370", Offset = "0x4D0D70", VA = "0x1804D2370")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x0000BD30 File Offset: 0x00009F30
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000423")]
		public int GetFund
		{
			[Token(Token = "0x6001FAD")]
			[Address(RVA = "0x3EBD10", Offset = "0x3EA710", VA = "0x1803EBD10")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FAE")]
			[Address(RVA = "0x4D23A0", Offset = "0x4D0DA0", VA = "0x1804D23A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001FAF RID: 8111 RVA: 0x0000BD48 File Offset: 0x00009F48
		// (set) Token: 0x06001FB0 RID: 8112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000424")]
		public int MaxFundCarry
		{
			[Token(Token = "0x6001FAF")]
			[Address(RVA = "0x3EBDA0", Offset = "0x3EA7A0", VA = "0x1803EBDA0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FB0")]
			[Address(RVA = "0x4D2470", Offset = "0x4D0E70", VA = "0x1804D2470")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001FB1 RID: 8113 RVA: 0x0000BD60 File Offset: 0x00009F60
		// (set) Token: 0x06001FB2 RID: 8114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000425")]
		public int ExtraFundByBuff
		{
			[Token(Token = "0x6001FB1")]
			[Address(RVA = "0x440490", Offset = "0x43EE90", VA = "0x180440490")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FB2")]
			[Address(RVA = "0x4D2390", Offset = "0x4D0D90", VA = "0x1804D2390")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001FB3 RID: 8115 RVA: 0x0000BD78 File Offset: 0x00009F78
		[Token(Token = "0x17000426")]
		public int RemainOrderCount
		{
			[Token(Token = "0x6001FB3")]
			[Address(RVA = "0x4D2200", Offset = "0x4D0C00", VA = "0x1804D2200")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x0000BD90 File Offset: 0x00009F90
		[Token(Token = "0x17000427")]
		public int FreeOrderCount
		{
			[Token(Token = "0x6001FB4")]
			[Address(RVA = "0x44F9E0", Offset = "0x44E3E0", VA = "0x18044F9E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000428")]
		public float EnduranceLimit
		{
			[Token(Token = "0x6001FB5")]
			[Address(RVA = "0x477F50", Offset = "0x476950", VA = "0x180477F50")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001FB6")]
			[Address(RVA = "0x4D2380", Offset = "0x4D0D80", VA = "0x1804D2380")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001FB7 RID: 8119 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FB8 RID: 8120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000429")]
		public GuestGroupController.OverrideEvalResultDelegate OverrideEvaluationCallback
		{
			[Token(Token = "0x6001FB7")]
			[Address(RVA = "0x4402B0", Offset = "0x43ECB0", VA = "0x1804402B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FB8")]
			[Address(RVA = "0x4D2670", Offset = "0x4D1070", VA = "0x1804D2670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		[Token(Token = "0x1700042A")]
		private static int GuestQueueLength
		{
			[Token(Token = "0x6001FB9")]
			[Address(RVA = "0x4D1D90", Offset = "0x4D0790", VA = "0x1804D1D90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042B")]
		public static List<GuestGroupController> QueuedGuestControllers
		{
			[Token(Token = "0x6001FBA")]
			[Address(RVA = "0x4D21C0", Offset = "0x4D0BC0", VA = "0x1804D21C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FBB")]
			[Address(RVA = "0x4D26C0", Offset = "0x4D10C0", VA = "0x1804D26C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042C")]
		public GuestBase OrderingGuest
		{
			[Token(Token = "0x6001FBC")]
			[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FBD")]
			[Address(RVA = "0x45F1B0", Offset = "0x45DBB0", VA = "0x18045F1B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FBF RID: 8127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042D")]
		protected Stack<GuestsManager.OrderBase> AllOrdersData
		{
			[Token(Token = "0x6001FBE")]
			[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FBF")]
			[Address(RVA = "0x45ABC0", Offset = "0x4595C0", VA = "0x18045ABC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700042E")]
		public IEnumerable<GuestsManager.OrderBase> AllOrders
		{
			[Token(Token = "0x6001FC0")]
			[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001FC1 RID: 8129 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		[Token(Token = "0x1700042F")]
		public int AllOrdersCount
		{
			[Token(Token = "0x6001FC1")]
			[Address(RVA = "0x4D1C00", Offset = "0x4D0600", VA = "0x1804D1C00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		[Token(Token = "0x17000430")]
		public GuestGroupController.LeaveType FinalLeaveType
		{
			[Token(Token = "0x6001FC2")]
			[Address(RVA = "0x476FF0", Offset = "0x4759F0", VA = "0x180476FF0")]
			get
			{
				return GuestGroupController.LeaveType.Move;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001FC3 RID: 8131 RVA: 0x0000BE08 File Offset: 0x0000A008
		// (set) Token: 0x06001FC4 RID: 8132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000431")]
		public GuestsManager.GuestType ControllType
		{
			[Token(Token = "0x6001FC3")]
			[Address(RVA = "0x477F00", Offset = "0x476900", VA = "0x180477F00")]
			[CompilerGenerated]
			get
			{
				return GuestsManager.GuestType.Normal;
			}
			[Token(Token = "0x6001FC4")]
			[Address(RVA = "0x4D2350", Offset = "0x4D0D50", VA = "0x1804D2350")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x0000BE20 File Offset: 0x0000A020
		// (set) Token: 0x06001FC6 RID: 8134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000432")]
		public int CurrentPatient
		{
			[Token(Token = "0x6001FC5")]
			[Address(RVA = "0x477EF0", Offset = "0x4768F0", VA = "0x180477EF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FC6")]
			[Address(RVA = "0x4D2360", Offset = "0x4D0D60", VA = "0x1804D2360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x0000BE38 File Offset: 0x0000A038
		// (set) Token: 0x06001FC8 RID: 8136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000433")]
		public int MaxPatient
		{
			[Token(Token = "0x6001FC7")]
			[Address(RVA = "0x477F90", Offset = "0x476990", VA = "0x180477F90")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FC8")]
			[Address(RVA = "0x4D2480", Offset = "0x4D0E80", VA = "0x1804D2480")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000434")]
		public Action<Vector3Int, GuestGroupController> OnMoveToSeatCallback
		{
			[Token(Token = "0x6001FC9")]
			[Address(RVA = "0x4BE490", Offset = "0x4BCE90", VA = "0x1804BE490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FCA")]
			[Address(RVA = "0x4BE690", Offset = "0x4BD090", VA = "0x1804BE690")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000435")]
		public Action<GuestGroupController> OnFundOrOrderChangeCallback
		{
			[Token(Token = "0x6001FCB")]
			[Address(RVA = "0x48B890", Offset = "0x48A290", VA = "0x18048B890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FCC")]
			[Address(RVA = "0x4D2550", Offset = "0x4D0F50", VA = "0x1804D2550")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000436")]
		public Action<GuestGroupController> OnFinishEatingCallbackWithParam
		{
			[Token(Token = "0x6001FCD")]
			[Address(RVA = "0x428D60", Offset = "0x427760", VA = "0x180428D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FCE")]
			[Address(RVA = "0x4D2530", Offset = "0x4D0F30", VA = "0x1804D2530")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000437")]
		public Action<GuestGroupController> OnFinishOrderCallback
		{
			[Token(Token = "0x6001FCF")]
			[Address(RVA = "0x48A8D0", Offset = "0x4892D0", VA = "0x18048A8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD0")]
			[Address(RVA = "0x48AC50", Offset = "0x489650", VA = "0x18048AC50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000438")]
		public Action<GuestGroupController> OnCompletelyLeaveCallback
		{
			[Token(Token = "0x6001FD1")]
			[Address(RVA = "0x48A680", Offset = "0x489080", VA = "0x18048A680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD2")]
			[Address(RVA = "0x4D24D0", Offset = "0x4D0ED0", VA = "0x1804D24D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000439")]
		public Action<GuestGroupController> OnLeaveCallback
		{
			[Token(Token = "0x6001FD3")]
			[Address(RVA = "0x48A7A0", Offset = "0x4891A0", VA = "0x18048A7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD4")]
			[Address(RVA = "0x4D2570", Offset = "0x4D0F70", VA = "0x1804D2570")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043A")]
		public Action<GuestGroupController> OnLeaveDeskCallback
		{
			[Token(Token = "0x6001FD5")]
			[Address(RVA = "0x48A4C0", Offset = "0x488EC0", VA = "0x18048A4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD6")]
			[Address(RVA = "0x4D2590", Offset = "0x4D0F90", VA = "0x1804D2590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043B")]
		public Action<GuestGroupController> OnPatienceRunOutCallback
		{
			[Token(Token = "0x6001FD7")]
			[Address(RVA = "0x449340", Offset = "0x447D40", VA = "0x180449340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FD8")]
			[Address(RVA = "0x48AA80", Offset = "0x489480", VA = "0x18048AA80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043C")]
		public Action<GuestGroupController> OnPatientDepeletedCallback
		{
			[Token(Token = "0x6001FD9")]
			[Address(RVA = "0x4405A0", Offset = "0x43EFA0", VA = "0x1804405A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FDA")]
			[Address(RVA = "0x4D25F0", Offset = "0x4D0FF0", VA = "0x1804D25F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043D")]
		public Action<GuestGroupController> OnStopInQueueCallback
		{
			[Token(Token = "0x6001FDB")]
			[Address(RVA = "0x48A630", Offset = "0x489030", VA = "0x18048A630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FDC")]
			[Address(RVA = "0x4D2650", Offset = "0x4D1050", VA = "0x1804D2650")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043E")]
		public Action<GuestGroupController> OnLeaveQueueCallback
		{
			[Token(Token = "0x6001FDD")]
			[Address(RVA = "0x4D1EB0", Offset = "0x4D08B0", VA = "0x1804D1EB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FDE")]
			[Address(RVA = "0x4D25B0", Offset = "0x4D0FB0", VA = "0x1804D25B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043F")]
		public Action<GuestGroupController> OnSitCallback
		{
			[Token(Token = "0x6001FDF")]
			[Address(RVA = "0x4D1EE0", Offset = "0x4D08E0", VA = "0x1804D1EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FE0")]
			[Address(RVA = "0x4D2630", Offset = "0x4D1030", VA = "0x1804D2630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000440")]
		public Action<Action, GuestGroupController> OnExtraFinishEvaluationCallback
		{
			[Token(Token = "0x6001FE1")]
			[Address(RVA = "0x4D1EA0", Offset = "0x4D08A0", VA = "0x1804D1EA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FE2")]
			[Address(RVA = "0x4D2510", Offset = "0x4D0F10", VA = "0x1804D2510")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000441")]
		public Action<int> OnPatientUpdatedCallback
		{
			[Token(Token = "0x6001FE3")]
			[Address(RVA = "0x4D1ED0", Offset = "0x4D08D0", VA = "0x1804D1ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FE4")]
			[Address(RVA = "0x4D2610", Offset = "0x4D1010", VA = "0x1804D2610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000442")]
		public Action<GuestGroupController.EvaluationResult, GuestGroupController, bool> OnEvalFinishCallback
		{
			[Token(Token = "0x6001FE5")]
			[Address(RVA = "0x4D1E90", Offset = "0x4D0890", VA = "0x1804D1E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FE6")]
			[Address(RVA = "0x4D24F0", Offset = "0x4D0EF0", VA = "0x1804D24F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000443")]
		public Func<string, string> talkMessageOverrideCallback
		{
			[Token(Token = "0x6001FE7")]
			[Address(RVA = "0x4D2230", Offset = "0x4D0C30", VA = "0x1804D2230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FE8")]
			[Address(RVA = "0x4D2740", Offset = "0x4D1140", VA = "0x1804D2740")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x0000BE50 File Offset: 0x0000A050
		[Token(Token = "0x17000444")]
		public int GuestCount
		{
			[Token(Token = "0x6001FE9")]
			[Address(RVA = "0x4D1D70", Offset = "0x4D0770", VA = "0x1804D1D70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x0000BE68 File Offset: 0x0000A068
		// (set) Token: 0x06001FEB RID: 8171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000445")]
		public int DeskCode
		{
			[Token(Token = "0x6001FEA")]
			[Address(RVA = "0x48A690", Offset = "0x489090", VA = "0x18048A690")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FEB")]
			[Address(RVA = "0x48AB00", Offset = "0x489500", VA = "0x18048AB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x0000BE80 File Offset: 0x0000A080
		// (set) Token: 0x06001FED RID: 8173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000446")]
		public int TotalPassionGivenAmount
		{
			[Token(Token = "0x6001FEC")]
			[Address(RVA = "0x48A860", Offset = "0x489260", VA = "0x18048A860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FED")]
			[Address(RVA = "0x48ABD0", Offset = "0x4895D0", VA = "0x18048ABD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x0000BE98 File Offset: 0x0000A098
		// (set) Token: 0x06001FEF RID: 8175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000447")]
		public bool CanIdleDialog
		{
			[Token(Token = "0x6001FEE")]
			[Address(RVA = "0x4D1C50", Offset = "0x4D0650", VA = "0x1804D1C50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FEF")]
			[Address(RVA = "0x4D2310", Offset = "0x4D0D10", VA = "0x1804D2310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		// (set) Token: 0x06001FF1 RID: 8177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000448")]
		public bool HasEvaluated
		{
			[Token(Token = "0x6001FF0")]
			[Address(RVA = "0x4D1DE0", Offset = "0x4D07E0", VA = "0x1804D1DE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FF1")]
			[Address(RVA = "0x4D23B0", Offset = "0x4D0DB0", VA = "0x1804D23B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		[Token(Token = "0x17000449")]
		public int OrderNumMax
		{
			[Token(Token = "0x6001FF2")]
			[Address(RVA = "0x4D1EF0", Offset = "0x4D08F0", VA = "0x1804D1EF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044A")]
		public int ExtraOrderNumMax
		{
			[Token(Token = "0x6001FF3")]
			[Address(RVA = "0x48A730", Offset = "0x489130", VA = "0x18048A730")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FF4")]
			[Address(RVA = "0x48AB40", Offset = "0x489540", VA = "0x18048AB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001FF5 RID: 8181 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		[Token(Token = "0x1700044B")]
		public bool IsThisOrderFree
		{
			[Token(Token = "0x6001FF5")]
			[Address(RVA = "0x4D1E10", Offset = "0x4D0810", VA = "0x1804D1E10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x0000BF10 File Offset: 0x0000A110
		// (set) Token: 0x06001FF7 RID: 8183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044C")]
		public int Mood
		{
			[Token(Token = "0x6001FF6")]
			[Address(RVA = "0x4D1E80", Offset = "0x4D0880", VA = "0x1804D1E80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001FF7")]
			[Address(RVA = "0x4D2490", Offset = "0x4D0E90", VA = "0x1804D2490")]
			set
			{
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x0000BF28 File Offset: 0x0000A128
		// (set) Token: 0x06001FF9 RID: 8185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044D")]
		public bool IsFirst
		{
			[Token(Token = "0x6001FF8")]
			[Address(RVA = "0x4D1DF0", Offset = "0x4D07F0", VA = "0x1804D1DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001FF9")]
			[Address(RVA = "0x4D2400", Offset = "0x4D0E00", VA = "0x1804D2400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001FFA RID: 8186 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FFB RID: 8187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044E")]
		public Action<float> OnMoodUpdateCallback
		{
			[Token(Token = "0x6001FFA")]
			[Address(RVA = "0x4D1EC0", Offset = "0x4D08C0", VA = "0x1804D1EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FFB")]
			[Address(RVA = "0x4D25D0", Offset = "0x4D0FD0", VA = "0x1804D25D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001FFC RID: 8188 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FFD RID: 8189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044F")]
		public GuestGroupController.OverrideOrderGenerationDelegate OverrideOrderGenerationCallback
		{
			[Token(Token = "0x6001FFC")]
			[Address(RVA = "0x48A840", Offset = "0x489240", VA = "0x18048A840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FFD")]
			[Address(RVA = "0x4D26A0", Offset = "0x4D10A0", VA = "0x1804D26A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001FFE RID: 8190 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FFF RID: 8191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000450")]
		public GuestGroupController.ContinueOrderProbabilityDelegate ContinueOrderProbabilityCallback
		{
			[Token(Token = "0x6001FFE")]
			[Address(RVA = "0x48A930", Offset = "0x489330", VA = "0x18048A930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FFF")]
			[Address(RVA = "0x4D2320", Offset = "0x4D0D20", VA = "0x1804D2320")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06002000 RID: 8192 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002001 RID: 8193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000451")]
		protected int[] LikeFoodTags
		{
			[Token(Token = "0x6002000")]
			[Address(RVA = "0x48A610", Offset = "0x489010", VA = "0x18048A610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002001")]
			[Address(RVA = "0x4D2450", Offset = "0x4D0E50", VA = "0x1804D2450")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002003 RID: 8195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000452")]
		protected int[] LikeBevTags
		{
			[Token(Token = "0x6002002")]
			[Address(RVA = "0x4D1E30", Offset = "0x4D0830", VA = "0x1804D1E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002003")]
			[Address(RVA = "0x4D2430", Offset = "0x4D0E30", VA = "0x1804D2430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000453")]
		protected int[] HateFoodTags
		{
			[Token(Token = "0x6002004")]
			[Address(RVA = "0x48A8F0", Offset = "0x4892F0", VA = "0x18048A8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002005")]
			[Address(RVA = "0x4D23E0", Offset = "0x4D0DE0", VA = "0x1804D23E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000454")]
		protected int[] HateBevTags
		{
			[Token(Token = "0x6002006")]
			[Address(RVA = "0x48A8E0", Offset = "0x4892E0", VA = "0x18048A8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002007")]
			[Address(RVA = "0x4D23C0", Offset = "0x4D0DC0", VA = "0x1804D23C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002009 RID: 8201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000455")]
		public GuestGroupController.OverrideHateFoodTagsDelegate OverrideHateFoodTagsCallback
		{
			[Token(Token = "0x6002008")]
			[Address(RVA = "0x48A790", Offset = "0x489190", VA = "0x18048A790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002009")]
			[Address(RVA = "0x4D2680", Offset = "0x4D1080", VA = "0x1804D2680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600200A RID: 8202
		[Token(Token = "0x17000456")]
		public abstract int[] EvaluateLikeFoodTags
		{
			[Token(Token = "0x600200A")]
			get;
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x0600200B RID: 8203
		[Token(Token = "0x17000457")]
		public abstract int[] EvaluateHateFoodTags
		{
			[Token(Token = "0x600200B")]
			get;
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x0000BF40 File Offset: 0x0000A140
		// (set) Token: 0x0600200D RID: 8205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000458")]
		public bool IsOrdering
		{
			[Token(Token = "0x600200C")]
			[Address(RVA = "0x4D1E00", Offset = "0x4D0800", VA = "0x1804D1E00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600200D")]
			[Address(RVA = "0x4D2410", Offset = "0x4D0E10", VA = "0x1804D2410")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x0000BF58 File Offset: 0x0000A158
		// (set) Token: 0x0600200F RID: 8207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000459")]
		public bool ContinueOrderWhenExbadEval
		{
			[Token(Token = "0x600200E")]
			[Address(RVA = "0x4D1D50", Offset = "0x4D0750", VA = "0x1804D1D50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600200F")]
			[Address(RVA = "0x4D2340", Offset = "0x4D0D40", VA = "0x1804D2340")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x0000BF70 File Offset: 0x0000A170
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045A")]
		public bool WillPayMoney
		{
			[Token(Token = "0x6002010")]
			[Address(RVA = "0x4D2220", Offset = "0x4D0C20", VA = "0x1804D2220")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002011")]
			[Address(RVA = "0x4D2730", Offset = "0x4D1130", VA = "0x1804D2730")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x0000BF88 File Offset: 0x0000A188
		// (set) Token: 0x06002013 RID: 8211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045B")]
		public bool CanBeRepelled
		{
			[Token(Token = "0x6002012")]
			[Address(RVA = "0x4D1C40", Offset = "0x4D0640", VA = "0x1804D1C40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002013")]
			[Address(RVA = "0x4D2300", Offset = "0x4D0D00", VA = "0x1804D2300")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700045C RID: 1116
		// (set) Token: 0x06002014 RID: 8212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045C")]
		public bool Left
		{
			[Token(Token = "0x6002014")]
			[Address(RVA = "0x4D2420", Offset = "0x4D0E20", VA = "0x1804D2420")]
			set
			{
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		// (set) Token: 0x06002016 RID: 8214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045D")]
		public bool ShouldHideFund
		{
			[Token(Token = "0x6002015")]
			[Address(RVA = "0x4D2210", Offset = "0x4D0C10", VA = "0x1804D2210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002016")]
			[Address(RVA = "0x4D2720", Offset = "0x4D1120", VA = "0x1804D2720")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		[Token(Token = "0x1700045E")]
		private float ComboExtraFeeRate
		{
			[Token(Token = "0x6002017")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0660", VA = "0x1804D1C60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		[Token(Token = "0x1700045F")]
		private float MoodExtraFeeRate
		{
			[Token(Token = "0x6002018")]
			[Address(RVA = "0x4D1E40", Offset = "0x4D0840", VA = "0x1804D1E40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06002019 RID: 8217 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		[Token(Token = "0x17000460")]
		private float OtherExtraFeeRate
		{
			[Token(Token = "0x6002019")]
			[Address(RVA = "0x4D1F10", Offset = "0x4D0910", VA = "0x1804D1F10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600201A RID: 8218
		[Token(Token = "0x600201A")]
		public abstract IEnumerable<GuestBase> GetAllGuests();

		// Token: 0x0600201B RID: 8219 RVA: 0x0000C000 File Offset: 0x0000A200
		[Token(Token = "0x600201B")]
		[Address(RVA = "0x4CE8A0", Offset = "0x4CD2A0", VA = "0x1804CE8A0")]
		public bool IsQueued(out int index)
		{
			return default(bool);
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600201C RID: 8220 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600201D RID: 8221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000F")]
		public event Action<GuestGroupController, string> OnSpecialGuestHateFoodTag
		{
			[Token(Token = "0x600201C")]
			[Address(RVA = "0x4D1B40", Offset = "0x4D0540", VA = "0x1804D1B40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600201D")]
			[Address(RVA = "0x4D2240", Offset = "0x4D0C40", VA = "0x1804D2240")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x0000C018 File Offset: 0x0000A218
		[Token(Token = "0x600201E")]
		[Address(RVA = "0x4CE770", Offset = "0x4CD170", VA = "0x1804CE770")]
		public bool HaveNotLeft()
		{
			return default(bool);
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201F")]
		[Address(RVA = "0x4CE780", Offset = "0x4CD180", VA = "0x1804CE780")]
		public static void Initialize()
		{
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002020")]
		[Address(RVA = "0x4CFE90", Offset = "0x4CE890", VA = "0x1804CFE90")]
		public void PushToOrder(GuestsManager.OrderBase orderData)
		{
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002021")]
		[Address(RVA = "0x4CFD10", Offset = "0x4CE710", VA = "0x1804CFD10")]
		public GuestsManager.OrderBase PeekOrders()
		{
			return null;
		}

		// Token: 0x06002022 RID: 8226
		[Token(Token = "0x6002022")]
		public abstract string OnRequestIdleDialog(out Transform speaker);

		// Token: 0x06002023 RID: 8227
		[Token(Token = "0x6002023")]
		public abstract string OnGetGuestName();

		// Token: 0x06002024 RID: 8228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002024")]
		[Address(RVA = "0x4CFBB0", Offset = "0x4CE5B0", VA = "0x1804CFBB0")]
		public string OnRequestEvaluationDialog(GuestGroupController.EvaluationResult evaluation, out Transform speaker)
		{
			return null;
		}

		// Token: 0x06002025 RID: 8229
		[Token(Token = "0x6002025")]
		protected abstract string GetEvaluationDialog(int evaluationIndex, out Transform speaker);

		// Token: 0x06002026 RID: 8230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002026")]
		[Address(RVA = "0x4CFC20", Offset = "0x4CE620", VA = "0x1804CFC20")]
		public string OnRequestNoMoneyDialog(out Transform speaker)
		{
			return null;
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002027")]
		[Address(RVA = "0x4CFBD0", Offset = "0x4CE5D0", VA = "0x1804CFBD0")]
		public string OnRequestNoMoneyAngryDialog(out Transform speaker)
		{
			return null;
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002028")]
		[Address(RVA = "0x4CFC70", Offset = "0x4CE670", VA = "0x1804CFC70")]
		public string OnRequestRepellDialog(out Transform speaker)
		{
			return null;
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002029")]
		[Address(RVA = "0x4CFCC0", Offset = "0x4CE6C0", VA = "0x1804CFCC0")]
		public string OnRequestSeenRepellDialog(out Transform speaker)
		{
			return null;
		}

		// Token: 0x0600202A RID: 8234
		[Token(Token = "0x600202A")]
		protected abstract int GetNoMoneyDialogIndex();

		// Token: 0x0600202B RID: 8235
		[Token(Token = "0x600202B")]
		protected abstract int GetNoMoneyAngryDialogIndex();

		// Token: 0x0600202C RID: 8236
		[Token(Token = "0x600202C")]
		protected abstract int GetRepellDialogIndex();

		// Token: 0x0600202D RID: 8237
		[Token(Token = "0x600202D")]
		protected abstract int GetSeenRepellDialogIndex();

		// Token: 0x0600202E RID: 8238 RVA: 0x0000C030 File Offset: 0x0000A230
		[Token(Token = "0x600202E")]
		[Address(RVA = "0x4CD3A0", Offset = "0x4CBDA0", VA = "0x1804CD3A0")]
		public bool GenerateOrder(bool isFreeOrder, out string orderGenerationMessage, out GuestsManager.OrderBase generatedOrder)
		{
			return default(bool);
		}

		// Token: 0x0600202F RID: 8239
		[Token(Token = "0x600202F")]
		public abstract GuestsManager.OrderBase PostGenerateOrder(bool isFreeOrder, out string orderGenerationMessage);

		// Token: 0x06002030 RID: 8240 RVA: 0x0000C048 File Offset: 0x0000A248
		[Token(Token = "0x6002030")]
		[Address(RVA = "0x4CAD10", Offset = "0x4C9710", VA = "0x1804CAD10")]
		public int Evaluate()
		{
			return 0;
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x0000C060 File Offset: 0x0000A260
		[Token(Token = "0x6002031")]
		[Address(RVA = "0x4C9FA0", Offset = "0x4C89A0", VA = "0x1804C9FA0")]
		public int EvaluateUnderSparrowTune(int oldEvaluate)
		{
			return 0;
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x0000C078 File Offset: 0x0000A278
		[Token(Token = "0x6002032")]
		[Address(RVA = "0x4D0DE0", Offset = "0x4CF7E0", VA = "0x1804D0DE0")]
		public int TryOverrideEvaluateByBuff(GuestGroupController.EvaluationResult lastResult)
		{
			return 0;
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002033")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "15")]
		public virtual void PostEvaluation(GuestGroupController.EvaluationResult evaluationType, Action onFinish, bool finishedByPartner, bool obtainedExGoodRatingWithModifiers = false)
		{
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002034")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500")]
		public void ApplyFX()
		{
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x0000C090 File Offset: 0x0000A290
		[Token(Token = "0x6002035")]
		[Address(RVA = "0x4CD510", Offset = "0x4CBF10", VA = "0x1804CD510")]
		public int GetPaymentByMood()
		{
			return 0;
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002036")]
		[Address(RVA = "0x4CE940", Offset = "0x4CD340", VA = "0x1804CE940")]
		public void ModifyExtraFreeFund(int extraFreeFund)
		{
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002037")]
		[Address(RVA = "0x4CFEF0", Offset = "0x4CE8F0", VA = "0x1804CFEF0")]
		public void RefreshCurrentFundAndOrder()
		{
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002038")]
		[Address(RVA = "0x4D1000", Offset = "0x4CFA00", VA = "0x1804D1000")]
		private void TryUpdateFundAndOrder()
		{
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[Token(Token = "0x6002039")]
		[Address(RVA = "0x4CD580", Offset = "0x4CBF80", VA = "0x1804CD580")]
		public int GetPayment(bool includeTip, float extraFeeRate, out int tip, out float comboExtraFee, out float moodExtraFee, out float otherExtraFee)
		{
			return 0;
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203A")]
		[Address(RVA = "0x4C9C00", Offset = "0x4C8600", VA = "0x1804C9C00")]
		public void AddExtraOrderCount(int num, bool isFree, string source = "default")
		{
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203B")]
		[Address(RVA = "0x4C9D20", Offset = "0x4C8720", VA = "0x1804C9D20")]
		public void AddFreeOrderNum(int freeOrderNum)
		{
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		[Token(Token = "0x600203C")]
		[Address(RVA = "0x4C9E40", Offset = "0x4C8840", VA = "0x1804C9E40")]
		public bool CheckOrderCount(ref bool doContinue)
		{
			return default(bool);
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600203D")]
		[Address(RVA = "0x4D0050", Offset = "0x4CEA50", VA = "0x1804D0050")]
		public void SetGuestCannotOrder()
		{
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		[Token(Token = "0x600203E")]
		[Address(RVA = "0x4CE650", Offset = "0x4CD050", VA = "0x1804CE650")]
		public int GetVariableExtraOrderNumByLabel(string label, out bool checkThisOrder)
		{
			return 0;
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		[Token(Token = "0x600203F")]
		[Address(RVA = "0x4CE570", Offset = "0x4CCF70", VA = "0x1804CE570")]
		public int GetStaticExtraOrderNumByLabel(string label)
		{
			return 0;
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002040")]
		[Address(RVA = "0x4D00E0", Offset = "0x4CEAE0", VA = "0x1804D00E0")]
		public void SetPatient(int patient)
		{
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002041")]
		[Address(RVA = "0x4C9D30", Offset = "0x4C8730", VA = "0x1804C9D30")]
		public void AddPatient(int patient)
		{
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002042")]
		[Address(RVA = "0x4D1080", Offset = "0x4CFA80", VA = "0x1804D1080")]
		public void UpdatePatient()
		{
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002043")]
		[Address(RVA = "0x4CE980", Offset = "0x4CD380", VA = "0x1804CE980")]
		public void MoveToDesk(int deskCode, Action onMovementFinishCallback)
		{
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x0000C108 File Offset: 0x0000A308
		[Token(Token = "0x6002044")]
		[Address(RVA = "0x4C9D90", Offset = "0x4C8790", VA = "0x1804C9D90")]
		public static bool CanQueue(int guestCount)
		{
			return default(bool);
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002045")]
		[Address(RVA = "0x4CEFD0", Offset = "0x4CD9D0", VA = "0x1804CEFD0")]
		public void MoveToQueue(Action<GuestGroupController> onMovementFinishCallback, bool tryToJumpQueue = false)
		{
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002046")]
		[Address(RVA = "0x4CFF30", Offset = "0x4CE930", VA = "0x1804CFF30")]
		public void RemoveFromQueue()
		{
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002047")]
		[Address(RVA = "0x4D0ED0", Offset = "0x4CF8D0", VA = "0x1804D0ED0")]
		public void TryReleaseAllServedFood()
		{
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002048")]
		[Address(RVA = "0x4D11B0", Offset = "0x4CFBB0", VA = "0x1804D11B0")]
		private void UpdateQueuedCharacters(List<AStarInputGeneratorComponent> trackMovement, Action onTrackingMovementFinishCallback)
		{
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002049")]
		[Address(RVA = "0x4CED70", Offset = "0x4CD770", VA = "0x1804CED70")]
		private void MoveToFirstQueue()
		{
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204A")]
		[Address(RVA = "0x4CF230", Offset = "0x4CDC30", VA = "0x1804CF230")]
		public void MoveToSpawn()
		{
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204B")]
		[Address(RVA = "0x4CCEB0", Offset = "0x4CB8B0", VA = "0x1804CCEB0")]
		public void FlyToSpawn(bool shouldFade)
		{
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204C")]
		[Address(RVA = "0x4CF740", Offset = "0x4CE140", VA = "0x1804CF740")]
		public void MoveToTargetPosition(int rotation, Vector3? extraOnArrivalOffset, Vector3Int targetPosition, bool triggerLeaveCallback, Action<GuestGroupController> onMoveFinishCallback)
		{
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204D")]
		[Address(RVA = "0x4CFD60", Offset = "0x4CE760", VA = "0x1804CFD60")]
		protected void PreInit()
		{
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204E")]
		[Address(RVA = "0x4D0750", Offset = "0x4CF150", VA = "0x1804D0750")]
		protected void SpawnCharacterControllers(Vector3? overrideSpawnPosition, IEnumerable<CharacterSpriteSetCompact> characterSprite, Action<AStarInputGeneratorComponent> postprocessCharacterCallback, IEnumerable<string> characterNames)
		{
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600204F")]
		[Address(RVA = "0x4D0130", Offset = "0x4CEB30", VA = "0x1804D0130")]
		protected void SpawnCharacterControllers(IEnumerable<CharacterSpriteSetFull> characterSprite, IEnumerable<string> characterNames)
		{
		}

		// Token: 0x04001D0C RID: 7436
		[Token(Token = "0x4001D0C")]
		private const int GUEST_MOOD_MIN = 0;

		// Token: 0x04001D0D RID: 7437
		[Token(Token = "0x4001D0D")]
		private const int GUEST_MOOD_MAX = 100;

		// Token: 0x04001D0E RID: 7438
		[Token(Token = "0x4001D0E")]
		private const int NORMAL_GUEST_MAX_EVAL = 3;

		// Token: 0x04001D0F RID: 7439
		[Token(Token = "0x4001D0F")]
		private const int SPECIAL_GUEST_MAX_EVAL = 4;

		// Token: 0x04001D10 RID: 7440
		[Token(Token = "0x4001D10")]
		private const int POPULAR_TAG = -20;

		// Token: 0x04001D11 RID: 7441
		[Token(Token = "0x4001D11")]
		private const float EXTRA_FEE_WHEN_CONTAINS_POPULAR_TAG = 0.15f;

		// Token: 0x04001D12 RID: 7442
		[Token(Token = "0x4001D12")]
		private const int BAD_MOOD_FEE = 1;

		// Token: 0x04001D13 RID: 7443
		[Token(Token = "0x4001D13")]
		private const int NORMAL_MOOD_FEE = 5;

		// Token: 0x04001D14 RID: 7444
		[Token(Token = "0x4001D14")]
		private const int GOOD_MOOD_FEE = 10;

		// Token: 0x04001D15 RID: 7445
		[Token(Token = "0x4001D15")]
		private const int EXGOOD_MOOD_FEE = 25;

		// Token: 0x04001D16 RID: 7446
		[Token(Token = "0x4001D16")]
		[FieldOffset(Offset = "0x0")]
		private static List<AStarInputGeneratorComponent> currentQueuedChatacters;

		// Token: 0x04001D17 RID: 7447
		[Token(Token = "0x4001D17")]
		[FieldOffset(Offset = "0x10")]
		public GuestsManager.OrderProperty CurrentOrderPropertySource;

		// Token: 0x04001D18 RID: 7448
		[Token(Token = "0x4001D18")]
		[FieldOffset(Offset = "0x18")]
		private readonly Queue<GuestsManager.OrderProperty> ExtraOrderStaticSource;

		// Token: 0x04001D19 RID: 7449
		[Token(Token = "0x4001D19")]
		[FieldOffset(Offset = "0x20")]
		private readonly Queue<GuestsManager.OrderProperty> ExtraOrderVariableSource;

		// Token: 0x04001D1A RID: 7450
		[Token(Token = "0x4001D1A")]
		[FieldOffset(Offset = "0x28")]
		protected int freeOrderCount;

		// Token: 0x04001D1B RID: 7451
		[Token(Token = "0x4001D1B")]
		[FieldOffset(Offset = "0x30")]
		public AStarInputGeneratorComponent[] guestInstances;

		// Token: 0x04001D1C RID: 7452
		[Token(Token = "0x4001D1C")]
		[FieldOffset(Offset = "0x38")]
		private bool haveLeft;

		// Token: 0x04001D1D RID: 7453
		[Token(Token = "0x4001D1D")]
		[FieldOffset(Offset = "0x3C")]
		protected GuestGroupController.LeaveType leaveType;

		// Token: 0x04001D1E RID: 7454
		[Token(Token = "0x4001D1E")]
		[FieldOffset(Offset = "0x40")]
		private int mood;

		// Token: 0x04001D1F RID: 7455
		[Token(Token = "0x4001D1F")]
		[FieldOffset(Offset = "0x48")]
		public GuestGroupController.OverrideLikeFoodTagsDelegate OverrideLikeFoodTagsCallback;

		// Token: 0x04001D20 RID: 7456
		[Token(Token = "0x4001D20")]
		[FieldOffset(Offset = "0x50")]
		private bool queued;

		// Token: 0x04001D21 RID: 7457
		[Token(Token = "0x4001D21")]
		[FieldOffset(Offset = "0x54")]
		protected int remainOrderCount;

		// Token: 0x04001D22 RID: 7458
		[Token(Token = "0x4001D22")]
		[FieldOffset(Offset = "0x58")]
		public bool? spawnedFromPTA;

		// Token: 0x04001D23 RID: 7459
		[Token(Token = "0x4001D23")]
		[FieldOffset(Offset = "0x60")]
		private readonly TileManager tileManager;

		// Token: 0x0200057C RID: 1404
		// (Invoke) Token: 0x06002052 RID: 8274
		[Token(Token = "0x200057C")]
		public delegate float ContinueOrderProbabilityDelegate(GuestGroupController guestGroup, float lastOrderProbability);

		// Token: 0x0200057D RID: 1405
		// (Invoke) Token: 0x06002056 RID: 8278
		[Token(Token = "0x200057D")]
		public delegate int[] OverrideHateFoodTagsDelegate(int[] tags, GuestGroupController controller);

		// Token: 0x0200057E RID: 1406
		// (Invoke) Token: 0x0600205A RID: 8282
		[Token(Token = "0x200057E")]
		public delegate int[] OverrideLikeFoodTagsDelegate(int[] tags, GuestGroupController controller);

		// Token: 0x0200057F RID: 1407
		// (Invoke) Token: 0x0600205E RID: 8286
		[Token(Token = "0x200057F")]
		public delegate GuestsManager.OrderBase OverrideOrderGenerationDelegate(GuestGroupController guestGroup, out string orderGenerationMessage);

		// Token: 0x02000580 RID: 1408
		// (Invoke) Token: 0x06002062 RID: 8290
		[Token(Token = "0x2000580")]
		public delegate GuestGroupController.EvaluationResult OverrideEvalResultDelegate(GuestGroupController.EvaluationResult oldResult, GuestGroupController guestGroup, bool oldComboProtect, out string newEvalMessage, out bool protectCombo);

		// Token: 0x02000581 RID: 1409
		[Token(Token = "0x2000581")]
		public enum EvaluationResult
		{
			// Token: 0x04001D55 RID: 7509
			[Token(Token = "0x4001D55")]
			Exbad,
			// Token: 0x04001D56 RID: 7510
			[Token(Token = "0x4001D56")]
			Bad,
			// Token: 0x04001D57 RID: 7511
			[Token(Token = "0x4001D57")]
			Normal,
			// Token: 0x04001D58 RID: 7512
			[Token(Token = "0x4001D58")]
			Good,
			// Token: 0x04001D59 RID: 7513
			[Token(Token = "0x4001D59")]
			ExGood,
			// Token: 0x04001D5A RID: 7514
			[Token(Token = "0x4001D5A")]
			Null
		}

		// Token: 0x02000582 RID: 1410
		[Token(Token = "0x2000582")]
		public enum LeaveType
		{
			// Token: 0x04001D5C RID: 7516
			[Token(Token = "0x4001D5C")]
			Move,
			// Token: 0x04001D5D RID: 7517
			[Token(Token = "0x4001D5D")]
			Fading,
			// Token: 0x04001D5E RID: 7518
			[Token(Token = "0x4001D5E")]
			Delete,
			// Token: 0x04001D5F RID: 7519
			[Token(Token = "0x4001D5F")]
			MoveToTargetPosition
		}
	}
}

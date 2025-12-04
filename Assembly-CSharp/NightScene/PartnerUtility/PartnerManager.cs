using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DEYU.Singletons;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.PartnerUtility
{
	// Token: 0x02000564 RID: 1380
	[Token(Token = "0x2000564")]
	[GenerateCleanupMethod]
	public class PartnerManager : MonoSingleton<PartnerManager>
	{
		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000403")]
		public IEnumerable<GuestsManager.OrderBase> AllProcessingOrders
		{
			[Token(Token = "0x6001EB3")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000404")]
		public IEnumerable<CookController> AllAvailableCookerCanUseByPartner
		{
			[Token(Token = "0x6001EB4")]
			[Address(RVA = "0x4E8DE0", Offset = "0x4E77E0", VA = "0x1804E8DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000405")]
		public IEnumerable<PartnerBase> AllStunedPartners
		{
			[Token(Token = "0x6001EB5")]
			[Address(RVA = "0x4E8F00", Offset = "0x4E7900", VA = "0x1804E8F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000406")]
		public IEnumerable<int> AllOrdersCookHasFinish
		{
			[Token(Token = "0x6001EB6")]
			[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x0000B760 File Offset: 0x00009960
		// (set) Token: 0x06001EB8 RID: 7864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000407")]
		public bool HaveInitialized
		{
			[Token(Token = "0x6001EB7")]
			[Address(RVA = "0x4E90C0", Offset = "0x4E7AC0", VA = "0x1804E90C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EB8")]
			[Address(RVA = "0x4E9160", Offset = "0x4E7B60", VA = "0x1804E9160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB9")]
		[Address(RVA = "0x4E4280", Offset = "0x4E2C80", VA = "0x1804E4280")]
		public IEnumerable<KeyValuePair<PartnerBase.PartnerType, IEnumerable<PartnerBase>>> GetAllPartnersAndType()
		{
			return null;
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBA")]
		[Address(RVA = "0x4E4420", Offset = "0x4E2E20", VA = "0x1804E4420")]
		public IEnumerable<PartnerBase> GetAllPartners()
		{
			return null;
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x0000B778 File Offset: 0x00009978
		[Token(Token = "0x6001EBB")]
		[Address(RVA = "0x4E4F70", Offset = "0x4E3970", VA = "0x1804E4F70")]
		public bool GetTargetPartner(int partnerId, out PartnerBase partnerBase)
		{
			return default(bool);
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0x4E4F00", Offset = "0x4E3900", VA = "0x1804E4F00")]
		public bool GetTargetPartnerByIndex(int partnerIndex, out PartnerBase partnerBase)
		{
			return default(bool);
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x4E68A0", Offset = "0x4E52A0", VA = "0x1804E68A0")]
		public void MarkForOccupied(PartnerBase.PartnerType partnerType, GuestsManager.OrderBase orderBase)
		{
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0x4E5170", Offset = "0x4E3B70", VA = "0x1804E5170")]
		public bool HasOccupied(PartnerBase.PartnerType partnerType, GuestsManager.OrderBase orderBase)
		{
			return default(bool);
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EBF")]
		[Address(RVA = "0x4E7A90", Offset = "0x4E6490", VA = "0x1804E7A90")]
		public void ReleaseFromOccupied(PartnerBase.PartnerType partnerType, GuestsManager.OrderBase orderBase)
		{
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x0000B7C0 File Offset: 0x000099C0
		[Token(Token = "0x6001EC0")]
		[Address(RVA = "0x4E47C0", Offset = "0x4E31C0", VA = "0x1804E47C0")]
		public bool GetOrderedAwaitingOrder(PartnerBase.PartnerType partnerType, out IEnumerable<GuestsManager.OrderBase> awaitingOrderBases, bool bossMode, float normalGuestServeWeight)
		{
			return default(bool);
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[Token(Token = "0x6001EC1")]
		[Address(RVA = "0x4E8330", Offset = "0x4E6D30", VA = "0x1804E8330")]
		public PartnerManager.GetCookerInfo TryGetCookerForOrder(Sellable food, out CookController cookController, out Recipe targetRecipe, params int[] canUsedCooker)
		{
			return PartnerManager.GetCookerInfo.AllCookerBusy;
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x0000B7F0 File Offset: 0x000099F0
		// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000408")]
		public bool CanAddAvailableCooker
		{
			[Token(Token = "0x6001EC2")]
			[Address(RVA = "0x4E90B0", Offset = "0x4E7AB0", VA = "0x1804E90B0")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x6001EC3")]
			[Address(RVA = "0x4E9150", Offset = "0x4E7B50", VA = "0x1804E9150")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC4")]
		[Address(RVA = "0x4E39D0", Offset = "0x4E23D0", VA = "0x1804E39D0")]
		public void AddToAvailableCooker(CookController cooker)
		{
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC5")]
		[Address(RVA = "0x4E7C70", Offset = "0x4E6670", VA = "0x1804E7C70")]
		public void RemoveFromAvailableCooker(CookController cooker)
		{
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC6")]
		[Address(RVA = "0x4E7CD0", Offset = "0x4E66D0", VA = "0x1804E7CD0")]
		public void ResetAvailableCooker()
		{
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EC7")]
		[Address(RVA = "0x4E7EC0", Offset = "0x4E68C0", VA = "0x1804E7EC0")]
		public void SetTargetDeskOrderHasMadeByCook(int orderDeskCode)
		{
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC8")]
		[Address(RVA = "0x4E4300", Offset = "0x4E2D00", VA = "0x1804E4300")]
		public IEnumerable<Transform> GetAllPartnersTransform()
		{
			return null;
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x0000B808 File Offset: 0x00009A08
		[Token(Token = "0x6001EC9")]
		[Address(RVA = "0x4E45F0", Offset = "0x4E2FF0", VA = "0x1804E45F0")]
		public int GetBufferCount(int targetSellableId, Sellable.SellableType sellableType)
		{
			return 0;
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x0000B820 File Offset: 0x00009A20
		[Token(Token = "0x6001ECA")]
		[Address(RVA = "0x4E3A30", Offset = "0x4E2430", VA = "0x1804E3A30")]
		public bool CheckStunedStatus(int partnerIndex)
		{
			return default(bool);
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECB")]
		[Address(RVA = "0x4E3900", Offset = "0x4E2300", VA = "0x1804E3900")]
		public void AddStunedStatus(List<int> partnerIndex)
		{
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECC")]
		[Address(RVA = "0x4E7D40", Offset = "0x4E6740", VA = "0x1804E7D40")]
		public void ResetStunedStatus(List<int> partnerIndex)
		{
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECD")]
		[Address(RVA = "0x4E5290", Offset = "0x4E3C90", VA = "0x1804E5290")]
		public void Initialize(IEnumerable<ValueTuple<int, PartnerBase>> employeeData, IEnumerable<CookController> cookers)
		{
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECE")]
		[Address(RVA = "0x4E3F60", Offset = "0x4E2960", VA = "0x1804E3F60")]
		public void Dispose()
		{
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ECF")]
		[Address(RVA = "0x4E8160", Offset = "0x4E6B60", VA = "0x1804E8160")]
		public void StopPartnerCoroutines()
		{
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED0")]
		[Address(RVA = "0x4E7F90", Offset = "0x4E6990", VA = "0x1804E7F90")]
		public void StartPartnerCoroutine(PartnerInfoBase partnerInfoBase, string name, IEnumerator enumerator)
		{
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED1")]
		[Address(RVA = "0x4E8660", Offset = "0x4E7060", VA = "0x1804E8660")]
		public void TryStopPartnerCoroutine(PartnerInfoBase partnerInfoBase, string name)
		{
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED2")]
		[Address(RVA = "0x4E7E10", Offset = "0x4E6810", VA = "0x1804E7E10")]
		public void SetPartnerOrderData(int deskCode, PartnerBase.PartnerType? targetPartnerTypeOnUI, Sellable.SellableType sellableType, string debugMessage, GuestsManager.OrderBase orderInfo)
		{
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED3")]
		[Address(RVA = "0x4E89E0", Offset = "0x4E73E0", VA = "0x1804E89E0")]
		public void UpdateStatus(int? deskCode, string data, int partnerIndex)
		{
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED4")]
		[Address(RVA = "0x4E6EB0", Offset = "0x4E58B0", VA = "0x1804E6EB0")]
		public void NotifySystemChanged(int senderIndex, PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, [Optional] object additionalInformation)
		{
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED5")]
		[Address(RVA = "0x4E7590", Offset = "0x4E5F90", VA = "0x1804E7590")]
		public void OnOrderBaseAdd(GuestsManager.OrderBase orderBase)
		{
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0x4E77F0", Offset = "0x4E61F0", VA = "0x1804E77F0")]
		public void OnThrowDeliverStart(GuestsManager.OrderBase targetOrder, Sellable[] additionalSellableData, int senderIndex = -1)
		{
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED7")]
		[Address(RVA = "0x4E7620", Offset = "0x4E6020", VA = "0x1804E7620")]
		public void OnOrderBaseStatusUpdate(GuestsManager.OrderBase orderBase, PartnerManager.OrderChangeContext updateContext, int senderIndex = -1)
		{
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED8")]
		[Address(RVA = "0x4E7560", Offset = "0x4E5F60", VA = "0x1804E7560")]
		public void OnInventoryRefresh(int senderIndex)
		{
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ED9")]
		[Address(RVA = "0x4E7790", Offset = "0x4E6190", VA = "0x1804E7790")]
		public void OnPlayerRefreshInventory()
		{
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDA")]
		[Address(RVA = "0x4E77C0", Offset = "0x4E61C0", VA = "0x1804E77C0")]
		public void OnPlayerStartCooker(CookController cookController)
		{
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDB")]
		[Address(RVA = "0x4E6FF0", Offset = "0x4E59F0", VA = "0x1804E6FF0")]
		public void OnCookerAvailabilityUpdate(int senderIndex = -1)
		{
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDC")]
		[Address(RVA = "0x4E7760", Offset = "0x4E6160", VA = "0x1804E7760")]
		public void OnPartnerWakeUp()
		{
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDD")]
		[Address(RVA = "0x4E76E0", Offset = "0x4E60E0", VA = "0x1804E76E0")]
		public void OnPartnerStunBegin(PartnerBase target)
		{
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDE")]
		[Address(RVA = "0x4E7720", Offset = "0x4E6120", VA = "0x1804E7720")]
		public void OnPartnerStunEnd(PartnerBase target)
		{
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EDF")]
		[Address(RVA = "0x4E7220", Offset = "0x4E5C20", VA = "0x1804E7220", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE0")]
		[Address(RVA = "0x4E38A0", Offset = "0x4E22A0", VA = "0x1804E38A0")]
		public void AddBossPartner(PartnerBossInfo partnerBossInfo)
		{
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x0000B838 File Offset: 0x00009A38
		// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000409")]
		public int BossGetScore
		{
			[Token(Token = "0x6001EE1")]
			[Address(RVA = "0x440490", Offset = "0x43EE90", VA = "0x180440490")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001EE2")]
			[Address(RVA = "0x4E90D0", Offset = "0x4E7AD0", VA = "0x1804E90D0")]
			set
			{
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x0000B850 File Offset: 0x00009A50
		// (set) Token: 0x06001EE4 RID: 7908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040A")]
		public int BossGetCombo
		{
			[Token(Token = "0x6001EE3")]
			[Address(RVA = "0x43AEF0", Offset = "0x4398F0", VA = "0x18043AEF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001EE4")]
			[Address(RVA = "0x448380", Offset = "0x446D80", VA = "0x180448380")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE5")]
		[Address(RVA = "0x4E3810", Offset = "0x4E2210", VA = "0x1804E3810")]
		public void AddBossCombo()
		{
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE6")]
		[Address(RVA = "0x448380", Offset = "0x446D80", VA = "0x180448380")]
		public void SetBossCombo(int combo)
		{
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE7")]
		[Address(RVA = "0x4E81B0", Offset = "0x4E6BB0", VA = "0x1804E81B0")]
		public void TryAddBossOccupiedDeskCode(int deskCode, int partnerId)
		{
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE8")]
		[Address(RVA = "0x4E7A20", Offset = "0x4E6420", VA = "0x1804E7A20")]
		public void ReleaseBossOccupiedDeskCode(int deskCode)
		{
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EE9")]
		[Address(RVA = "0x4E8240", Offset = "0x4E6C40", VA = "0x1804E8240")]
		public void TryAddPlayerOccupiedDeskCode(int deskCode)
		{
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEA")]
		[Address(RVA = "0x4E7BF0", Offset = "0x4E65F0", VA = "0x1804E7BF0")]
		public void ReleasePlayerOccupiedDeskCode(int deskCode)
		{
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0000B868 File Offset: 0x00009A68
		[Token(Token = "0x6001EEB")]
		[Address(RVA = "0x4E3C20", Offset = "0x4E2620", VA = "0x1804E3C20")]
		public bool CheckThisDeskHaveOccupiedByBoss(int deskCode)
		{
			return default(bool);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x0000B880 File Offset: 0x00009A80
		[Token(Token = "0x6001EEC")]
		[Address(RVA = "0x4E3C80", Offset = "0x4E2680", VA = "0x1804E3C80")]
		public bool CheckThisDeskHaveOccupiedByPlayer(int deskCode)
		{
			return default(bool);
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0000B898 File Offset: 0x00009A98
		[Token(Token = "0x6001EED")]
		[Address(RVA = "0x4E3B80", Offset = "0x4E2580", VA = "0x1804E3B80")]
		public bool CheckThisDeskHaveOccupiedByAnyone(int deskCode)
		{
			return default(bool);
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		[Token(Token = "0x6001EEE")]
		[Address(RVA = "0x4E4540", Offset = "0x4E2F40", VA = "0x1804E4540")]
		public float GetBossTipRate(int deskCode)
		{
			return 0f;
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EEF")]
		[Address(RVA = "0x4E3820", Offset = "0x4E2220", VA = "0x1804E3820")]
		public void AddBossGetScore(int fund)
		{
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF0")]
		[Address(RVA = "0x4E51F0", Offset = "0x4E3BF0", VA = "0x1804E51F0")]
		public void InitializeBossPartnerModeManager(Action<int> setBossScoreCallback, Action<int, int> partnerOccupyDeskCallback, Action<int> partnerReleaseDeskCallback, Action<int> playerOccupyDeskCallback, Action<int> playerReleaseDeskCallback)
		{
		}

		// Token: 0x06001EF1 RID: 7921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF1")]
		[Address(RVA = "0x4E7020", Offset = "0x4E5A20", VA = "0x1804E7020")]
		private void OnGUI()
		{
		}

		// Token: 0x06001EF2 RID: 7922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF2")]
		[Address(RVA = "0x4E3CE0", Offset = "0x4E26E0", VA = "0x1804E3CE0", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001EF3 RID: 7923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EF3")]
		[Address(RVA = "0x4E8A20", Offset = "0x4E7420", VA = "0x1804E8A20")]
		public PartnerManager()
		{
		}

		// Token: 0x04001C59 RID: 7257
		[Token(Token = "0x4001C59")]
		public const int ANONYMOUS_SYSTEM_CHANGE_SENDER_INDEX = -1;

		// Token: 0x04001C5A RID: 7258
		[Token(Token = "0x4001C5A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action afterInitialize;

		// Token: 0x04001C5B RID: 7259
		[Token(Token = "0x4001C5B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly HashSet<GuestsManager.OrderBase> allOrders;

		// Token: 0x04001C5C RID: 7260
		[Token(Token = "0x4001C5C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly HashSet<CookController> availableCookers;

		// Token: 0x04001C5D RID: 7261
		[Token(Token = "0x4001C5D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<PartnerBase.PartnerType, HashSet<GuestsManager.OrderBase>> occupiedOrderData;

		// Token: 0x04001C5E RID: 7262
		[Token(Token = "0x4001C5E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly HashSet<int> allOrdersCookHasFinish;

		// Token: 0x04001C5F RID: 7263
		[Token(Token = "0x4001C5F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Dictionary<PartnerInfoBase, Dictionary<string, Coroutine>> partnerInfoCoroutines;

		// Token: 0x04001C60 RID: 7264
		[Token(Token = "0x4001C60")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly Dictionary<PartnerBase.PartnerType, HashSet<PartnerBase>> partners;

		// Token: 0x04001C61 RID: 7265
		[Token(Token = "0x4001C61")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Dictionary<int, PartnerBase> partnersByIndex;

		// Token: 0x04001C62 RID: 7266
		[Token(Token = "0x4001C62")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly List<List<int>> stunedPartners;

		// Token: 0x04001C63 RID: 7267
		[Token(Token = "0x4001C63")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Action<int, PartnerBase.PartnerType?, Sellable.SellableType, string> setPartnerOrderDataCallback;

		// Token: 0x04001C64 RID: 7268
		[Token(Token = "0x4001C64")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Action<int?, string, int> setPartnerStateCallback;

		// Token: 0x04001C67 RID: 7271
		[Token(Token = "0x4001C67")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int bossGetScore;

		// Token: 0x04001C68 RID: 7272
		[Token(Token = "0x4001C68")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<int, int> BossOccupiedDeskCodeList;

		// Token: 0x04001C69 RID: 7273
		[Token(Token = "0x4001C69")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly List<int> PlayerOccupiedDeskCodeList;

		// Token: 0x04001C6A RID: 7274
		[Token(Token = "0x4001C6A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly Dictionary<int, PartnerBossInfo> BossPartnerMatching;

		// Token: 0x04001C6B RID: 7275
		[Token(Token = "0x4001C6B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Func<string> GetLabel;

		// Token: 0x04001C6C RID: 7276
		[Token(Token = "0x4001C6C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Action<int> setBossScoreCallback;

		// Token: 0x04001C6D RID: 7277
		[Token(Token = "0x4001C6D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action<int, int> partnerOccupyDeskCallback;

		// Token: 0x04001C6E RID: 7278
		[Token(Token = "0x4001C6E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Action<int> partnerReleaseDeskCallback;

		// Token: 0x04001C6F RID: 7279
		[Token(Token = "0x4001C6F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Action<int> playerOccupyDeskCallback;

		// Token: 0x04001C70 RID: 7280
		[Token(Token = "0x4001C70")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Action<int> playerReleaseDeskCallback;

		// Token: 0x02000565 RID: 1381
		[Token(Token = "0x2000565")]
		public enum GetCookerInfo
		{
			// Token: 0x04001C73 RID: 7283
			[Token(Token = "0x4001C73")]
			AllCookerBusy,
			// Token: 0x04001C74 RID: 7284
			[Token(Token = "0x4001C74")]
			NoMatchingRecipes,
			// Token: 0x04001C75 RID: 7285
			[Token(Token = "0x4001C75")]
			NoMatchingCooker,
			// Token: 0x04001C76 RID: 7286
			[Token(Token = "0x4001C76")]
			Succeed
		}

		// Token: 0x02000566 RID: 1382
		[Token(Token = "0x2000566")]
		public enum OrderChangeContext
		{
			// Token: 0x04001C78 RID: 7288
			[Token(Token = "0x4001C78")]
			Null,
			// Token: 0x04001C79 RID: 7289
			[Token(Token = "0x4001C79")]
			OrderAdd,
			// Token: 0x04001C7A RID: 7290
			[Token(Token = "0x4001C7A")]
			OrderRemove,
			// Token: 0x04001C7B RID: 7291
			[Token(Token = "0x4001C7B")]
			FoodDelivered,
			// Token: 0x04001C7C RID: 7292
			[Token(Token = "0x4001C7C")]
			BeverageDelivered,
			// Token: 0x04001C7D RID: 7293
			[Token(Token = "0x4001C7D")]
			InventoryUpdate,
			// Token: 0x04001C7E RID: 7294
			[Token(Token = "0x4001C7E")]
			CookerStart,
			// Token: 0x04001C7F RID: 7295
			[Token(Token = "0x4001C7F")]
			OnCookerAvailabilityUpdate,
			// Token: 0x04001C80 RID: 7296
			[Token(Token = "0x4001C80")]
			WakeUp,
			// Token: 0x04001C81 RID: 7297
			[Token(Token = "0x4001C81")]
			PlayerOccupyDesk,
			// Token: 0x04001C82 RID: 7298
			[Token(Token = "0x4001C82")]
			PartnerGetStuned,
			// Token: 0x04001C83 RID: 7299
			[Token(Token = "0x4001C83")]
			PartnerStunEnd
		}
	}
}

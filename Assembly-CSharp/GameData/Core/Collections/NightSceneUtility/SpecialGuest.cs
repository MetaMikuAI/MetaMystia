using System;
using System.Collections.Generic;
using Common.UI;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.CoreLanguage;
using GameData.Profile;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x020008EA RID: 2282
	[Token(Token = "0x20008EA")]
	[Serializable]
	public class SpecialGuest : GuestBase
	{
		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060038D3 RID: 14547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007CB")]
		public RunTimeAlbum.SpecialGuestRunTimeData RunTimeData
		{
			[Token(Token = "0x60038D3")]
			[Address(RVA = "0x68F310", Offset = "0x68DD10", VA = "0x18068F310")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060038D4 RID: 14548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007CC")]
		public override CharacterPortrayal CharacterPortrayal
		{
			[Token(Token = "0x60038D4")]
			[Address(RVA = "0x68E810", Offset = "0x68D210", VA = "0x18068E810", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060038D5 RID: 14549 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007CD")]
		public CharacterPortrayal CharacterDefaultPortrayal
		{
			[Token(Token = "0x60038D5")]
			[Address(RVA = "0x68E770", Offset = "0x68D170", VA = "0x18068E770")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060038D6 RID: 14550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007CE")]
		public override CharacterSpriteSetCompact CharacterPixel
		{
			[Token(Token = "0x60038D6")]
			[Address(RVA = "0x68E7C0", Offset = "0x68D1C0", VA = "0x18068E7C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x060038D7 RID: 14551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007CF")]
		public GuestFoodEasterEggData GuestFoodEasterEggData
		{
			[Token(Token = "0x60038D7")]
			[Address(RVA = "0x48A8F0", Offset = "0x4892F0", VA = "0x18048A8F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060038D8 RID: 14552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D0")]
		public IEnumerable<int> HateFoodTag
		{
			[Token(Token = "0x60038D8")]
			[Address(RVA = "0x68EA00", Offset = "0x68D400", VA = "0x18068EA00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060038D9 RID: 14553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D1")]
		public int[] LikeBevTagUnfolded
		{
			[Token(Token = "0x60038D9")]
			[Address(RVA = "0x68EC90", Offset = "0x68D690", VA = "0x18068EC90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060038DA RID: 14554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D2")]
		public int[] LikeBevTag
		{
			[Token(Token = "0x60038DA")]
			[Address(RVA = "0x68EDE0", Offset = "0x68D7E0", VA = "0x18068EDE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060038DB RID: 14555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D3")]
		public override int[] LikeFoodTag
		{
			[Token(Token = "0x60038DB")]
			[Address(RVA = "0x68F1C0", Offset = "0x68DBC0", VA = "0x18068F1C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060038DC RID: 14556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D4")]
		public int[] LikeFoodTagUnfolded
		{
			[Token(Token = "0x60038DC")]
			[Address(RVA = "0x68F070", Offset = "0x68DA70", VA = "0x18068F070")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060038DD RID: 14557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D5")]
		public int[] LikeFoodTagOriginal
		{
			[Token(Token = "0x60038DD")]
			[Address(RVA = "0x68EF30", Offset = "0x68D930", VA = "0x18068EF30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060038DE RID: 14558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D6")]
		public int[] HateFoodTagOriginal
		{
			[Token(Token = "0x60038DE")]
			[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060038DF RID: 14559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D7")]
		public int[] LikeBevTagOriginal
		{
			[Token(Token = "0x60038DF")]
			[Address(RVA = "0x68EB50", Offset = "0x68D550", VA = "0x18068EB50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060038E0 RID: 14560 RVA: 0x000157F8 File Offset: 0x000139F8
		[Token(Token = "0x170007D8")]
		public bool HideInAlbum
		{
			[Token(Token = "0x60038E0")]
			[Address(RVA = "0x4A6EE0", Offset = "0x4A58E0", VA = "0x1804A6EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060038E1 RID: 14561 RVA: 0x00015810 File Offset: 0x00013A10
		[Token(Token = "0x170007D9")]
		public bool HideInAlbumAfterOverride
		{
			[Token(Token = "0x60038E1")]
			[Address(RVA = "0x68EA80", Offset = "0x68D480", VA = "0x18068EA80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060038E2 RID: 14562 RVA: 0x00015828 File Offset: 0x00013A28
		[Token(Token = "0x170007DA")]
		public bool DoNotShowInNightByDefault
		{
			[Token(Token = "0x60038E2")]
			[Address(RVA = "0x52F160", Offset = "0x52DB60", VA = "0x18052F160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060038E3 RID: 14563 RVA: 0x00015840 File Offset: 0x00013A40
		[Token(Token = "0x170007DB")]
		public bool DoNotShowInChallenge
		{
			[Token(Token = "0x60038E3")]
			[Address(RVA = "0x68E890", Offset = "0x68D290", VA = "0x18068E890")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060038E4 RID: 14564 RVA: 0x00015858 File Offset: 0x00013A58
		[Token(Token = "0x170007DC")]
		public bool IsParticular
		{
			[Token(Token = "0x60038E4")]
			[Address(RVA = "0x68EB40", Offset = "0x68D540", VA = "0x18068EB40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x00015870 File Offset: 0x00013A70
		[Token(Token = "0x170007DD")]
		public bool IsCollabCharacter
		{
			[Token(Token = "0x60038E5")]
			[Address(RVA = "0x68EB30", Offset = "0x68D530", VA = "0x18068EB30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060038E6 RID: 14566 RVA: 0x00015888 File Offset: 0x00013A88
		[Token(Token = "0x170007DE")]
		public bool HideInNX
		{
			[Token(Token = "0x60038E6")]
			[Address(RVA = "0x68EB20", Offset = "0x68D520", VA = "0x18068EB20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060038E7 RID: 14567 RVA: 0x000158A0 File Offset: 0x00013AA0
		[Token(Token = "0x170007DF")]
		public bool Controllable
		{
			[Token(Token = "0x60038E7")]
			[Address(RVA = "0x68E860", Offset = "0x68D260", VA = "0x18068E860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060038E8 RID: 14568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E0")]
		public IEnumerable<int> HateBevTag
		{
			[Token(Token = "0x60038E8")]
			[Address(RVA = "0x68E980", Offset = "0x68D380", VA = "0x18068E980")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060038E9 RID: 14569 RVA: 0x000158B8 File Offset: 0x00013AB8
		[Token(Token = "0x170007E1")]
		public SpecialGuest.Prespective Reaction
		{
			[Token(Token = "0x60038E9")]
			[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290")]
			get
			{
				return default(SpecialGuest.Prespective);
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060038EA RID: 14570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E2")]
		public override LanguageBase Text
		{
			[Token(Token = "0x60038EA")]
			[Address(RVA = "0x68F3C0", Offset = "0x68DDC0", VA = "0x18068F3C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E3")]
		public string StringId
		{
			[Token(Token = "0x60038EB")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060038EC RID: 14572 RVA: 0x000158D0 File Offset: 0x00013AD0
		[Token(Token = "0x170007E4")]
		public bool HasSpell
		{
			[Token(Token = "0x60038EC")]
			[Address(RVA = "0x68E930", Offset = "0x68D330", VA = "0x18068E930")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060038ED RID: 14573 RVA: 0x000158E8 File Offset: 0x00013AE8
		[Token(Token = "0x170007E5")]
		public float GetEnduranceLimit
		{
			[Token(Token = "0x60038ED")]
			[Address(RVA = "0x68E920", Offset = "0x68D320", VA = "0x18068E920")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060038EE RID: 14574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E6")]
		public string[] Evaluation
		{
			[Token(Token = "0x60038EE")]
			[Address(RVA = "0x68E8A0", Offset = "0x68D2A0", VA = "0x18068E8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x00015900 File Offset: 0x00013B00
		[Token(Token = "0x170007E7")]
		public NPC.Destination Destination
		{
			[Token(Token = "0x60038EF")]
			[Address(RVA = "0x68E870", Offset = "0x68D270", VA = "0x18068E870")]
			get
			{
				return default(NPC.Destination);
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060038F0 RID: 14576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007E8")]
		public string CommisionAreaLabel
		{
			[Token(Token = "0x60038F0")]
			[Address(RVA = "0x48A940", Offset = "0x489340", VA = "0x18048A940")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x00015918 File Offset: 0x00013B18
		[Token(Token = "0x170007E9")]
		public SpecialGuest.WorkSceneSpawnType SpawnType
		{
			[Token(Token = "0x60038F1")]
			[Address(RVA = "0x477F60", Offset = "0x476960", VA = "0x180477F60")]
			get
			{
				return SpecialGuest.WorkSceneSpawnType.Specific;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060038F2 RID: 14578 RVA: 0x00015930 File Offset: 0x00013B30
		[Token(Token = "0x170007EA")]
		public ValueTuple<float, string[]> SpawnExtraProperty
		{
			[Token(Token = "0x60038F2")]
			[Address(RVA = "0x68F360", Offset = "0x68DD60", VA = "0x18068F360")]
			get
			{
				return default(ValueTuple<float, string[]>);
			}
		}

		// Token: 0x060038F3 RID: 14579 RVA: 0x00015948 File Offset: 0x00013B48
		[Token(Token = "0x60038F3")]
		[Address(RVA = "0x68C590", Offset = "0x68AF90", VA = "0x18068C590", Slot = "9")]
		public override Vector2Int GetFundRange()
		{
			return default(Vector2Int);
		}

		// Token: 0x060038F4 RID: 14580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F4")]
		[Address(RVA = "0x68CFD0", Offset = "0x68B9D0", VA = "0x18068CFD0")]
		public void InjectAdditiveData(ExpandableGameDataPack.SpecialGuestAdditiveData additiveDataPack)
		{
		}

		// Token: 0x060038F5 RID: 14581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038F5")]
		[Address(RVA = "0x68C8F0", Offset = "0x68B2F0", VA = "0x18068C8F0")]
		public void GetSpecialGuestSpawnInfo(out NormalGuestDescriber.PlaceRenderMode renderMode, out int[] izakayaInfo)
		{
		}

		// Token: 0x060038F6 RID: 14582 RVA: 0x00015960 File Offset: 0x00013B60
		[Token(Token = "0x60038F6")]
		[Address(RVA = "0x68D9D0", Offset = "0x68C3D0", VA = "0x18068D9D0")]
		public bool ShouldSpawnHere(int izakayaId, string daySceneMapLabel, IEnumerable<Izakaya.SpecialGuestGroup> specialGuestGroups, bool isChallengeSession, out float spawnProb)
		{
			return default(bool);
		}

		// Token: 0x060038F7 RID: 14583 RVA: 0x00015978 File Offset: 0x00013B78
		[Token(Token = "0x60038F7")]
		[Address(RVA = "0x68BC90", Offset = "0x68A690", VA = "0x18068BC90")]
		private bool CheckCanSpawnEveryWhere()
		{
			return default(bool);
		}

		// Token: 0x060038F8 RID: 14584 RVA: 0x00015990 File Offset: 0x00013B90
		[Token(Token = "0x60038F8")]
		[Address(RVA = "0x68D990", Offset = "0x68C390", VA = "0x18068D990")]
		public bool ShouldSpawnHere(Izakaya izakaya, bool isChallengeSession, out float spawnProb)
		{
			return default(bool);
		}

		// Token: 0x060038F9 RID: 14585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038F9")]
		[Address(RVA = "0x68D940", Offset = "0x68C340", VA = "0x18068D940", Slot = "10")]
		protected override GuestProfilePair OnGetVisual(int id)
		{
			return null;
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038FA")]
		[Address(RVA = "0x68C6A0", Offset = "0x68B0A0", VA = "0x18068C6A0")]
		private IEnumerable<SpecialGuest.WeightedTag> GetLikeTagWeighted(IEnumerable<SpecialGuest.WeightedTag> rawTagSet, bool includesPop)
		{
			return null;
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038FB")]
		[Address(RVA = "0x68C4D0", Offset = "0x68AED0", VA = "0x18068C4D0")]
		public string GetFoodTagText(int tagId)
		{
			return null;
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038FC")]
		[Address(RVA = "0x68C3C0", Offset = "0x68ADC0", VA = "0x18068C3C0")]
		public string GetBevTagText(int tagId)
		{
			return null;
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038FD")]
		[Address(RVA = "0x68C3B0", Offset = "0x68ADB0", VA = "0x18068C3B0")]
		public string GenerateRandomConvMessage()
		{
			return null;
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038FE")]
		[Address(RVA = "0x68C2B0", Offset = "0x68ACB0", VA = "0x18068C2B0")]
		public string GenerateRandomConvMessage(IEnumerable<string> extraConv)
		{
			return null;
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038FF")]
		[Address(RVA = "0x68CF70", Offset = "0x68B970", VA = "0x18068CF70")]
		public LanguageBase[] GetSpellLanguage()
		{
			return null;
		}

		// Token: 0x06003900 RID: 14592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003900")]
		[Address(RVA = "0x68C480", Offset = "0x68AE80", VA = "0x18068C480")]
		public string[] GetDialogPackagesAtKizunaLevel(int level)
		{
			return null;
		}

		// Token: 0x06003901 RID: 14593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003901")]
		[Address(RVA = "0x68CF80", Offset = "0x68B980", VA = "0x18068CF80")]
		public DialogPackage[] GetWelcomeDialogPackagesAtKizunaLevel(int level)
		{
			return null;
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003902")]
		[Address(RVA = "0x68C640", Offset = "0x68B040", VA = "0x18068C640")]
		public DialogPackage[] GetInviteDialogPackageAtKizunaLevel(int level, bool succeed)
		{
			return null;
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003903")]
		[Address(RVA = "0x68C8C0", Offset = "0x68B2C0", VA = "0x18068C8C0")]
		public DialogPackage[] GetRequestIngerdientAtKizunaLevel(int level)
		{
			return null;
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003904")]
		[Address(RVA = "0x68C8A0", Offset = "0x68B2A0", VA = "0x18068C8A0")]
		public DialogPackage[] GetRequestBeverageAtKizunaLevel(int level)
		{
			return null;
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003905")]
		[Address(RVA = "0x48A930", Offset = "0x489330", VA = "0x18048A930")]
		public DialogPackage[] GetCommisionDialogPackage()
		{
			return null;
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003906")]
		[Address(RVA = "0x48A610", Offset = "0x489010", VA = "0x18048A610")]
		public DialogPackage[] GetCommisionFinishDialogPackage()
		{
			return null;
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003907")]
		[Address(RVA = "0x68DCA0", Offset = "0x68C6A0", VA = "0x18068DCA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003908")]
		[Address(RVA = "0x68BD80", Offset = "0x68A780", VA = "0x18068BD80")]
		public SpecialGuest Clone(NPC.Destination overrideDestination, string daySceneLabel)
		{
			return null;
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x000159A8 File Offset: 0x00013BA8
		[Token(Token = "0x6003909")]
		[Address(RVA = "0x68D830", Offset = "0x68C230", VA = "0x18068D830")]
		public UniTask<IAssetHandle<SpecialGuestExtraDialogData>> LoadExtraDialogData()
		{
			return default(UniTask<IAssetHandle<SpecialGuestExtraDialogData>>);
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600390A")]
		[Address(RVA = "0x68E350", Offset = "0x68CD50", VA = "0x18068E350")]
		public SpecialGuest(int id, string stringId, Vector2Int fundRange, int[] hateFoodTag, SpecialGuest.WeightedTag[] likeFoodTag, SpecialGuest.WeightedTag[] likeBevTag, SpecialGuest.Prespective reaction, NPC.Destination destination, string commisionAreaLabel, DialogPackage[] characterKizunaLevel1Welcome, DialogPackage[] characterKizunaLevel2Welcome, DialogPackage[] characterKizunaLevel3Welcome, DialogPackage[] characterKizunaLevel4Welcome, DialogPackage[] characterKizunaLevel5Welcome, string[] characterKizunaLevel1ChatData, string[] characterKizunaLevel2ChatData, string[] characterKizunaLevel3ChatData, string[] characterKizunaLevel4ChatData, string[] characterKizunaLevel5ChatData, DialogPackage[] characterKizunaLevel2InviteSucceed, DialogPackage[] characterKizunaLevel2InviteFailed, DialogPackage[] characterKizunaLevel3InviteSucceed, DialogPackage[] characterKizunaLevel3InviteFailed, DialogPackage[] characterKizunaLevel4InviteSucceed, DialogPackage[] characterKizunaLevel4InviteFailed, DialogPackage[] characterKizunaLevel5InviteSucceed, DialogPackage[] characterKizunaLevel3RequestIngerdient, DialogPackage[] characterKizunaLevel4RequestIngerdient, DialogPackage[] characterKizunaLevel5RequestIngerdient, DialogPackage[] characterKizunaLevel4RequestBeverage, DialogPackage[] characterKizunaLevel5RequestBeverage, DialogPackage[] characterKizunaLevel5Commision, DialogPackage[] characterKizunaLevel5CommisionFinish, bool hideInAlbum, bool isParticular, bool isCollabCharacter, SpecialGuest.WorkSceneSpawnType spawnType, string[] unifiedSpawnExclusion, string unifiedSpawnWhereAfterEventOrMission, float unifiedSpawnProb, AssetReferenceT<SpecialGuestExtraDialogData> specialGuestExtraDialogData, bool doNotShowInNightByDefault, bool doNotShowInChallenge, GuestFoodEasterEggData guestFoodEasterEggData)
		{
		}

		// Token: 0x04003075 RID: 12405
		[Token(Token = "0x4003075")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string stringId;

		// Token: 0x04003076 RID: 12406
		[Token(Token = "0x4003076")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector2Int fundRange;

		// Token: 0x04003077 RID: 12407
		[Token(Token = "0x4003077")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float enduranceLimit;

		// Token: 0x04003078 RID: 12408
		[Token(Token = "0x4003078")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int[] hateFoodTag;

		// Token: 0x04003079 RID: 12409
		[Token(Token = "0x4003079")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public SpecialGuest.WeightedTag[] likeFoodTag;

		// Token: 0x0400307A RID: 12410
		[Token(Token = "0x400307A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		public SpecialGuest.WeightedTag[] likeBevTag;

		// Token: 0x0400307B RID: 12411
		[Token(Token = "0x400307B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SpecialGuest.Prespective reaction;

		// Token: 0x0400307C RID: 12412
		[Token(Token = "0x400307C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private NPC.Destination destination;

		// Token: 0x0400307D RID: 12413
		[Token(Token = "0x400307D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string commisionAreaLabel;

		// Token: 0x0400307E RID: 12414
		[Token(Token = "0x400307E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool hideInAlbum;

		// Token: 0x0400307F RID: 12415
		[Token(Token = "0x400307F")]
		[FieldOffset(Offset = "0x79")]
		[SerializeField]
		private bool isParticular;

		// Token: 0x04003080 RID: 12416
		[Token(Token = "0x4003080")]
		[FieldOffset(Offset = "0x7A")]
		[SerializeField]
		private bool isCollabCharacter;

		// Token: 0x04003081 RID: 12417
		[Token(Token = "0x4003081")]
		[FieldOffset(Offset = "0x7B")]
		[SerializeField]
		private bool hideInNX;

		// Token: 0x04003082 RID: 12418
		[Token(Token = "0x4003082")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private SpecialGuest.WorkSceneSpawnType spawnType;

		// Token: 0x04003083 RID: 12419
		[Token(Token = "0x4003083")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float unifiedSpawnProb;

		// Token: 0x04003084 RID: 12420
		[Token(Token = "0x4003084")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string[] unifiedSpawnExclusion;

		// Token: 0x04003085 RID: 12421
		[Token(Token = "0x4003085")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string unifiedSpawnWhereAfterEventOrMission;

		// Token: 0x04003086 RID: 12422
		[Token(Token = "0x4003086")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool doNotShowInNightByDefault;

		// Token: 0x04003087 RID: 12423
		[Token(Token = "0x4003087")]
		[FieldOffset(Offset = "0x99")]
		[SerializeField]
		private bool doNotShowInChallenge;

		// Token: 0x04003088 RID: 12424
		[Token(Token = "0x4003088")]
		[FieldOffset(Offset = "0x9A")]
		[SerializeField]
		private bool controllable;

		// Token: 0x04003089 RID: 12425
		[Token(Token = "0x4003089")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel1Welcome;

		// Token: 0x0400308A RID: 12426
		[Token(Token = "0x400308A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel2Welcome;

		// Token: 0x0400308B RID: 12427
		[Token(Token = "0x400308B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel3Welcome;

		// Token: 0x0400308C RID: 12428
		[Token(Token = "0x400308C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel4Welcome;

		// Token: 0x0400308D RID: 12429
		[Token(Token = "0x400308D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel5Welcome;

		// Token: 0x0400308E RID: 12430
		[Token(Token = "0x400308E")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private string[] characterKizunaLevel1ChatData;

		// Token: 0x0400308F RID: 12431
		[Token(Token = "0x400308F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private string[] characterKizunaLevel2ChatData;

		// Token: 0x04003090 RID: 12432
		[Token(Token = "0x4003090")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private string[] characterKizunaLevel3ChatData;

		// Token: 0x04003091 RID: 12433
		[Token(Token = "0x4003091")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private string[] characterKizunaLevel4ChatData;

		// Token: 0x04003092 RID: 12434
		[Token(Token = "0x4003092")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private string[] characterKizunaLevel5ChatData;

		// Token: 0x04003093 RID: 12435
		[Token(Token = "0x4003093")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel2InviteSucceed;

		// Token: 0x04003094 RID: 12436
		[Token(Token = "0x4003094")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel2InviteFailed;

		// Token: 0x04003095 RID: 12437
		[Token(Token = "0x4003095")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel3InviteSucceed;

		// Token: 0x04003096 RID: 12438
		[Token(Token = "0x4003096")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel3InviteFailed;

		// Token: 0x04003097 RID: 12439
		[Token(Token = "0x4003097")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel4InviteSucceed;

		// Token: 0x04003098 RID: 12440
		[Token(Token = "0x4003098")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel4InviteFailed;

		// Token: 0x04003099 RID: 12441
		[Token(Token = "0x4003099")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel5InviteSucceed;

		// Token: 0x0400309A RID: 12442
		[Token(Token = "0x400309A")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel3RequestIngerdient;

		// Token: 0x0400309B RID: 12443
		[Token(Token = "0x400309B")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel4RequestIngerdient;

		// Token: 0x0400309C RID: 12444
		[Token(Token = "0x400309C")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel5RequestIngerdient;

		// Token: 0x0400309D RID: 12445
		[Token(Token = "0x400309D")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel4RequestBeverage;

		// Token: 0x0400309E RID: 12446
		[Token(Token = "0x400309E")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel5RequestBeverage;

		// Token: 0x0400309F RID: 12447
		[Token(Token = "0x400309F")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel5Commision;

		// Token: 0x040030A0 RID: 12448
		[Token(Token = "0x40030A0")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private DialogPackage[] characterKizunaLevel5CommisionFinish;

		// Token: 0x040030A1 RID: 12449
		[Token(Token = "0x40030A1")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private AssetReferenceT<SpecialGuestExtraDialogData> m_SpecialGuestExtraDialogDataAsset;

		// Token: 0x040030A2 RID: 12450
		[Token(Token = "0x40030A2")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private GuestFoodEasterEggData guestFoodEasterEggData;

		// Token: 0x020008EB RID: 2283
		[Token(Token = "0x20008EB")]
		public enum WorkSceneSpawnType
		{
			// Token: 0x040030A4 RID: 12452
			[Token(Token = "0x40030A4")]
			Specific,
			// Token: 0x040030A5 RID: 12453
			[Token(Token = "0x40030A5")]
			EveryWhere,
			// Token: 0x040030A6 RID: 12454
			[Token(Token = "0x40030A6")]
			NeverCome
		}

		// Token: 0x020008EC RID: 2284
		[Token(Token = "0x20008EC")]
		[Serializable]
		public class WeightedTag
		{
			// Token: 0x0600390D RID: 14605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600390D")]
			[Address(RVA = "0x44F3D0", Offset = "0x44DDD0", VA = "0x18044F3D0")]
			public WeightedTag(int tagId, int weight)
			{
			}

			// Token: 0x040030A7 RID: 12455
			[Token(Token = "0x40030A7")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public int tagId;

			// Token: 0x040030A8 RID: 12456
			[Token(Token = "0x40030A8")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			public int weight;
		}

		// Token: 0x020008ED RID: 2285
		[Token(Token = "0x20008ED")]
		[Serializable]
		public struct Prespective
		{
			// Token: 0x0600390E RID: 14606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600390E")]
			[Address(RVA = "0x6885E0", Offset = "0x686FE0", VA = "0x1806885E0")]
			public Prespective(Vector2Int raw)
			{
			}

			// Token: 0x170007EB RID: 2027
			// (get) Token: 0x0600390F RID: 14607 RVA: 0x000159F0 File Offset: 0x00013BF0
			[Token(Token = "0x170007EB")]
			public SpecialGuest.Prespective.Respond ToPopLike
			{
				[Token(Token = "0x600390F")]
				[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
				get
				{
					return SpecialGuest.Prespective.Respond.Negative;
				}
			}

			// Token: 0x170007EC RID: 2028
			// (get) Token: 0x06003910 RID: 14608 RVA: 0x00015A08 File Offset: 0x00013C08
			[Token(Token = "0x170007EC")]
			public SpecialGuest.Prespective.Respond ToPopHate
			{
				[Token(Token = "0x6003910")]
				[Address(RVA = "0x43B0B0", Offset = "0x439AB0", VA = "0x18043B0B0")]
				get
				{
					return SpecialGuest.Prespective.Respond.Negative;
				}
			}

			// Token: 0x040030A9 RID: 12457
			[Token(Token = "0x40030A9")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private SpecialGuest.Prespective.Respond toPop;

			// Token: 0x040030AA RID: 12458
			[Token(Token = "0x40030AA")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			private SpecialGuest.Prespective.Respond toInfam;

			// Token: 0x020008EE RID: 2286
			[Token(Token = "0x20008EE")]
			public enum Respond
			{
				// Token: 0x040030AC RID: 12460
				[Token(Token = "0x40030AC")]
				[InspectorName("与常人相反")]
				Negative,
				// Token: 0x040030AD RID: 12461
				[Token(Token = "0x40030AD")]
				[InspectorName("无视流行")]
				Neutral,
				// Token: 0x040030AE RID: 12462
				[Token(Token = "0x40030AE")]
				[InspectorName("与常人相同")]
				Positive
			}
		}
	}
}

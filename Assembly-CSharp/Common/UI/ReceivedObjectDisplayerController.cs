using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DEYU.Singletons;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.CoreLanguage;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000E00 RID: 3584
	[Token(Token = "0x2000E00")]
	public class ReceivedObjectDisplayerController : MonoSingleton<ReceivedObjectDisplayerController>, IDisposable
	{
		// Token: 0x17000BEA RID: 3050
		// (set) Token: 0x060053B8 RID: 21432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BEA")]
		private float FlexibleSpaceHeight
		{
			[Token(Token = "0x60053B8")]
			[Address(RVA = "0x843190", Offset = "0x841B90", VA = "0x180843190")]
			set
			{
			}
		}

		// Token: 0x060053B9 RID: 21433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053B9")]
		[Address(RVA = "0x83EAD0", Offset = "0x83D4D0", VA = "0x18083EAD0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BA")]
		[Address(RVA = "0x841E30", Offset = "0x840830", VA = "0x180841E30")]
		private void OnDestroy()
		{
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BB")]
		[Address(RVA = "0x83E680", Offset = "0x83D080", VA = "0x18083E680", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x060053BC RID: 21436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BC")]
		public static void TryRegisterCustomSpacing<T>(RectTransform rect)
		{
		}

		// Token: 0x060053BD RID: 21437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BD")]
		public static void TryRemoveCustomSpacing<T>()
		{
		}

		// Token: 0x060053BE RID: 21438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BE")]
		[Address(RVA = "0x841EF0", Offset = "0x8408F0", VA = "0x180841EF0")]
		public static void TryUpdateMetrics()
		{
		}

		// Token: 0x060053BF RID: 21439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053BF")]
		[Address(RVA = "0x842F70", Offset = "0x841970", VA = "0x180842F70")]
		private void UpdateMetrics()
		{
		}

		// Token: 0x060053C0 RID: 21440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C0")]
		[Address(RVA = "0x842C50", Offset = "0x841650", VA = "0x180842C50")]
		private void UpdateMetricsImpl()
		{
		}

		// Token: 0x060053C1 RID: 21441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C1")]
		[Address(RVA = "0x841C50", Offset = "0x840650", VA = "0x180841C50")]
		public void NotifyTextMessage(string content)
		{
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C2")]
		[Address(RVA = "0x83F260", Offset = "0x83DC60", VA = "0x18083F260")]
		public void NotifyCommonPhraseUpdate(string titleKeyword)
		{
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C3")]
		[Address(RVA = "0x841090", Offset = "0x83FA90", VA = "0x180841090")]
		public void NotifySpecialGuestSpawnInNight(string characterLabel, bool targetIzakaya = false, [Optional] int[] spawnIzakaya)
		{
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C4")]
		[Address(RVA = "0x840CE0", Offset = "0x83F6E0", VA = "0x180840CE0")]
		public void NotifyObjectLanguageBase(ObjectLanguageBase objectLanguageBase, int count)
		{
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C5")]
		[Address(RVA = "0x840F10", Offset = "0x83F910", VA = "0x180840F10")]
		public void NotifySellableLanguageBase(Sellable sellable, int count)
		{
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C6")]
		[Address(RVA = "0x83EF80", Offset = "0x83D980", VA = "0x18083EF80")]
		public void NotifyBadgeLanguageBase(ObjectLanguageBase objectLanguageBase, int count)
		{
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C7")]
		[Address(RVA = "0x83F0E0", Offset = "0x83DAE0", VA = "0x18083F0E0")]
		public void NotifyBadgeWithoutCountLanguageBase(ObjectLanguageBase objectLanguageBase)
		{
		}

		// Token: 0x060053C8 RID: 21448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C8")]
		[Address(RVA = "0x83F130", Offset = "0x83DB30", VA = "0x18083F130")]
		public void NotifyBadgeWithoutCountLanguageBase(Sprite badgeSprite, string textName)
		{
		}

		// Token: 0x060053C9 RID: 21449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053C9")]
		[Address(RVA = "0x840AE0", Offset = "0x83F4E0", VA = "0x180840AE0")]
		public void NotifyMap(string key)
		{
		}

		// Token: 0x060053CA RID: 21450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CA")]
		[Address(RVA = "0x8416E0", Offset = "0x8400E0", VA = "0x1808416E0")]
		public void NotifySpell(string characterName, string spellName)
		{
		}

		// Token: 0x060053CB RID: 21451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CB")]
		[Address(RVA = "0x841D60", Offset = "0x840760", VA = "0x180841D60")]
		private void NotifyTrophy(ObjectLanguageBase objectLanguageBase)
		{
		}

		// Token: 0x060053CC RID: 21452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CC")]
		[Address(RVA = "0x83F800", Offset = "0x83E200", VA = "0x18083F800")]
		private void NotifyIzakaya(int id)
		{
		}

		// Token: 0x060053CD RID: 21453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CD")]
		[Address(RVA = "0x840D50", Offset = "0x83F750", VA = "0x180840D50")]
		private void NotifyPartner(int id)
		{
		}

		// Token: 0x060053CE RID: 21454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CE")]
		[Address(RVA = "0x83F290", Offset = "0x83DC90", VA = "0x18083F290")]
		private void NotifyCooker([TupleElementNames(new string[] { "Text", "BG" })] ValueTuple<ObjectLanguageBase, Sprite> objectLanguageBase, int count)
		{
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053CF")]
		[Address(RVA = "0x840E10", Offset = "0x83F810", VA = "0x180840E10")]
		private void NotifyRecipe(int id)
		{
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D0")]
		[Address(RVA = "0x841A00", Offset = "0x840400", VA = "0x180841A00")]
		private void NotifyTagUpdate([TupleElementNames(new string[] { "characterId", "tagType", "isHateTag", "tagId" })] ValueTuple<int, Sellable.SellableType, bool, int> data)
		{
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D1")]
		[Address(RVA = "0x83F750", Offset = "0x83E150", VA = "0x18083F750")]
		private void NotifyIzakayaUpdate([TupleElementNames(new string[] { "characterId", "izakayaId" })] ValueTuple<int, int> data)
		{
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D2")]
		[Address(RVA = "0x840FD0", Offset = "0x83F9D0", VA = "0x180840FD0")]
		private void NotifySpecialGuestNewInfo(int characterId)
		{
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D3")]
		[Address(RVA = "0x841640", Offset = "0x840040", VA = "0x180841640")]
		private void NotifySpecialGuestUpgrateKizunaLevel([TupleElementNames(new string[] { "characterId", "level" })] ValueTuple<int, int> data)
		{
		}

		// Token: 0x060053D4 RID: 21460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D4")]
		[Address(RVA = "0x83F6D0", Offset = "0x83E0D0", VA = "0x18083F6D0")]
		private void NotifyFund(int amount)
		{
		}

		// Token: 0x060053D5 RID: 21461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D5")]
		[Address(RVA = "0x83F600", Offset = "0x83E000", VA = "0x18083F600")]
		private void NotifyDecoration(int itemId)
		{
		}

		// Token: 0x060053D6 RID: 21462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D6")]
		[Address(RVA = "0x8418C0", Offset = "0x8402C0", VA = "0x1808418C0")]
		private void NotifySpriteMessage(Sprite sprite, string name, Sprite bg)
		{
		}

		// Token: 0x060053D7 RID: 21463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D7")]
		[Address(RVA = "0x83F8C0", Offset = "0x83E2C0", VA = "0x18083F8C0")]
		private void NotifyLevelMessage(int level)
		{
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D8")]
		[Address(RVA = "0x840C40", Offset = "0x83F640", VA = "0x180840C40")]
		private void NotifyMissionStart(string missionName)
		{
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053D9")]
		[Address(RVA = "0x840BA0", Offset = "0x83F5A0", VA = "0x180840BA0")]
		private void NotifyMissionFinish(string missionName)
		{
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DA")]
		[Address(RVA = "0x841750", Offset = "0x840150", VA = "0x180841750")]
		private void NotifySpriteCountMessage(Sprite sprite, string name, int count, Sprite bg, bool addModify)
		{
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DB")]
		[Address(RVA = "0x83EE30", Offset = "0x83D830", VA = "0x18083EE30")]
		private void NotifyBadgeCountMessage(Sprite sprite, string name, int count)
		{
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DC")]
		[Address(RVA = "0x83F140", Offset = "0x83DB40", VA = "0x18083F140")]
		private void NotifyBadgeWithoutCountMessage(Sprite sprite, string name)
		{
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DD")]
		[Address(RVA = "0x841B20", Offset = "0x840520", VA = "0x180841B20")]
		private void NotifyTextCountMessage(string content, int count)
		{
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DE")]
		[Address(RVA = "0x83D5C0", Offset = "0x83BFC0", VA = "0x18083D5C0")]
		public void BindDayScene()
		{
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053DF")]
		[Address(RVA = "0x83DED0", Offset = "0x83C8D0", VA = "0x18083DED0")]
		public void BindWorkScene()
		{
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E0")]
		[Address(RVA = "0x699430", Offset = "0x697E30", VA = "0x180699430")]
		private string GetTitleKWD(string key)
		{
			return null;
		}

		// Token: 0x060053E1 RID: 21473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E1")]
		[Address(RVA = "0x83E9C0", Offset = "0x83D3C0", VA = "0x18083E9C0")]
		private string GetTitleKWD(string key, string data)
		{
			return null;
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E2")]
		[Address(RVA = "0x83EA30", Offset = "0x83D430", VA = "0x18083EA30")]
		private string GetTitleKWD(string key, string data1, string data2)
		{
			return null;
		}

		// Token: 0x060053E3 RID: 21475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053E3")]
		[Address(RVA = "0x83E740", Offset = "0x83D140", VA = "0x18083E740")]
		private string GetCount(int count)
		{
			return null;
		}

		// Token: 0x060053E4 RID: 21476 RVA: 0x0001E180 File Offset: 0x0001C380
		[Token(Token = "0x60053E4")]
		[Address(RVA = "0x83E930", Offset = "0x83D330", VA = "0x18083E930")]
		private ValueTuple<UIElementCluster, GameObject> GetSpriteMessageInstance()
		{
			return default(ValueTuple<UIElementCluster, GameObject>);
		}

		// Token: 0x060053E5 RID: 21477 RVA: 0x0001E198 File Offset: 0x0001C398
		[Token(Token = "0x60053E5")]
		[Address(RVA = "0x83E6E0", Offset = "0x83D0E0", VA = "0x18083E6E0")]
		private ValueTuple<UIElementCluster, GameObject> GetBadgeMessageInstance()
		{
			return default(ValueTuple<UIElementCluster, GameObject>);
		}

		// Token: 0x060053E6 RID: 21478 RVA: 0x0001E1B0 File Offset: 0x0001C3B0
		[Token(Token = "0x60053E6")]
		[Address(RVA = "0x83E710", Offset = "0x83D110", VA = "0x18083E710")]
		private ValueTuple<UIElementCluster, GameObject> GetBadgeWithoutCountMessageInstance()
		{
			return default(ValueTuple<UIElementCluster, GameObject>);
		}

		// Token: 0x060053E7 RID: 21479 RVA: 0x0001E1C8 File Offset: 0x0001C3C8
		[Token(Token = "0x60053E7")]
		[Address(RVA = "0x83E990", Offset = "0x83D390", VA = "0x18083E990")]
		private ValueTuple<UIElementCluster, GameObject> GetTextMessageInstance()
		{
			return default(ValueTuple<UIElementCluster, GameObject>);
		}

		// Token: 0x060053E8 RID: 21480 RVA: 0x0001E1E0 File Offset: 0x0001C3E0
		[Token(Token = "0x60053E8")]
		[Address(RVA = "0x83E900", Offset = "0x83D300", VA = "0x18083E900")]
		private ValueTuple<UIElementCluster, GameObject> GetSpriteMessageCountInstance()
		{
			return default(ValueTuple<UIElementCluster, GameObject>);
		}

		// Token: 0x060053E9 RID: 21481 RVA: 0x0001E1F8 File Offset: 0x0001C3F8
		[Token(Token = "0x60053E9")]
		[Address(RVA = "0x83E960", Offset = "0x83D360", VA = "0x18083E960")]
		private ValueTuple<UIElementCluster, GameObject> GetTextMessageCountInstance()
		{
			return default(ValueTuple<UIElementCluster, GameObject>);
		}

		// Token: 0x060053EA RID: 21482 RVA: 0x0001E210 File Offset: 0x0001C410
		[Token(Token = "0x60053EA")]
		[Address(RVA = "0x83E810", Offset = "0x83D210", VA = "0x18083E810")]
		private ValueTuple<UIElementCluster, GameObject> GetInstanceInternal(GameObject parent)
		{
			return default(ValueTuple<UIElementCluster, GameObject>);
		}

		// Token: 0x060053EB RID: 21483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053EB")]
		[Address(RVA = "0x841E50", Offset = "0x840850", VA = "0x180841E50")]
		private void TryExecuteNotify()
		{
		}

		// Token: 0x060053EC RID: 21484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053EC")]
		[Address(RVA = "0x83F370", Offset = "0x83DD70", VA = "0x18083F370")]
		private void NotifyDataInternal([TupleElementNames(new string[] { "objectData", "objectLayoutData" })] Func<ValueTuple<UIElementCluster, GameObject>> objectGenerator, Action<UIElementCluster> dataProcessor)
		{
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053ED")]
		[Address(RVA = "0x842F80", Offset = "0x841980", VA = "0x180842F80")]
		public ReceivedObjectDisplayerController()
		{
		}

		// Token: 0x060053EE RID: 21486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053EE")]
		[Address(RVA = "0x842960", Offset = "0x841360", VA = "0x180842960")]
		[CompilerGenerated]
		internal static string <NotifyLevelMessage>g__FormatToProb|78_0(float value)
		{
			return null;
		}

		// Token: 0x060053EF RID: 21487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053EF")]
		[Address(RVA = "0x8428E0", Offset = "0x8412E0", VA = "0x1808428E0")]
		[CompilerGenerated]
		internal static string <NotifyLevelMessage>g__FormatToOneMinusProb|78_1(float value)
		{
			return null;
		}

		// Token: 0x060053F0 RID: 21488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F0")]
		[Address(RVA = "0x842890", Offset = "0x841290", VA = "0x180842890")]
		[CompilerGenerated]
		internal static string <NotifyLevelMessage>g__AddPlus|78_2(float value)
		{
			return null;
		}

		// Token: 0x060053F1 RID: 21489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60053F1")]
		[Address(RVA = "0x8429D0", Offset = "0x8413D0", VA = "0x1808429D0")]
		[CompilerGenerated]
		private void <NotifyLevelMessage>g__TryShow|78_3(Func<DataBaseCore.LevelProperties, float> getValueCallback, string property, Func<float, string> overrideToStringCallback, ref ReceivedObjectDisplayerController.<>c__DisplayClass78_0 A_4)
		{
		}

		// Token: 0x060053F4 RID: 21492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053F4")]
		[Address(RVA = "0x842BD0", Offset = "0x8415D0", VA = "0x180842BD0")]
		[CompilerGenerated]
		private IEnumerator <TryExecuteNotify>g__Execute|98_0()
		{
			return null;
		}

		// Token: 0x04004EAD RID: 20141
		[Token(Token = "0x4004EAD")]
		private const string RECIEVE_IZAKAYA_KWD = "RECIEVE_IZAKAYA";

		// Token: 0x04004EAE RID: 20142
		[Token(Token = "0x4004EAE")]
		private const string RECIEVE_PARTNER_KWD = "RECIEVE_PARTNER";

		// Token: 0x04004EAF RID: 20143
		[Token(Token = "0x4004EAF")]
		private const string RECIEVE_RECIPE_KWD = "RECIEVE_RECIPE";

		// Token: 0x04004EB0 RID: 20144
		[Token(Token = "0x4004EB0")]
		private const string RECIEVE_FUND_ADD_KWD = "RECIEVE_FUND_ADD";

		// Token: 0x04004EB1 RID: 20145
		[Token(Token = "0x4004EB1")]
		private const string RECIEVE_FUND_LOST_KWD = "RECIEVE_FUND_LOST";

		// Token: 0x04004EB2 RID: 20146
		[Token(Token = "0x4004EB2")]
		private const string RECIEVE_DECORATION_KWD = "DECORATION_GET";

		// Token: 0x04004EB3 RID: 20147
		[Token(Token = "0x4004EB3")]
		private const string RECIEVE_MAP_UNLOCK_KWD = "RECIEVE_MAP_UNLOCK";

		// Token: 0x04004EB4 RID: 20148
		[Token(Token = "0x4004EB4")]
		private const string RECIEVE_TROPHY_KWD = "DLC4_FISHINGTROPHY_GET";

		// Token: 0x04004EB5 RID: 20149
		[Token(Token = "0x4004EB5")]
		private const string RECIEVE_COOKER_KWD = "COMMON_COOKER";

		// Token: 0x04004EB6 RID: 20150
		[Token(Token = "0x4004EB6")]
		private const string ALBUM_SPECIALGUEST_SPAWN_EVERYWHERE_KWD = "ALBUM_INFO_UPDATE_SPAWN_EVERYWHERE";

		// Token: 0x04004EB7 RID: 20151
		[Token(Token = "0x4004EB7")]
		private const string ALBUM_SPECIALGUEST_SPAWN_SPECIFIC_KWD = "ALBUM_INFO_UPDATE_SPAWN_SPECIFIC";

		// Token: 0x04004EB8 RID: 20152
		[Token(Token = "0x4004EB8")]
		private const string ALBUM_UPDATE_FOODTAG_KWD = "ALBUM_INFO_UPDATE_FOODTAG";

		// Token: 0x04004EB9 RID: 20153
		[Token(Token = "0x4004EB9")]
		private const string ALBUM_UPDATE_HATEFOODTAG_KWD = "ALBUM_INFO_UPDATE_HATEFOODTAG";

		// Token: 0x04004EBA RID: 20154
		[Token(Token = "0x4004EBA")]
		private const string ALBUM_UPDATE_BEVTAG_KWD = "ALBUM_INFO_UPDATE_BEVTAG";

		// Token: 0x04004EBB RID: 20155
		[Token(Token = "0x4004EBB")]
		private const string ALBUM_UPDATE_IZAKAYA_KWD = "ALBUM_INFO_UPDATE_IZAKAYA";

		// Token: 0x04004EBC RID: 20156
		[Token(Token = "0x4004EBC")]
		private const string ALBUM_WRITE_MORE_KWD = "ALBUM_INFO_WRITE_MORE";

		// Token: 0x04004EBD RID: 20157
		[Token(Token = "0x4004EBD")]
		private const string ALBUM_UPGRATE_KIZUNA_KWD = "ALBUM_INFO_UPGRATE_KIZUNA";

		// Token: 0x04004EBE RID: 20158
		[Token(Token = "0x4004EBE")]
		private const string LEVEL_UP_KWD = "LEVEL_UP";

		// Token: 0x04004EBF RID: 20159
		[Token(Token = "0x4004EBF")]
		private const string LEVEL_UP_PROPERTIES_KWD = "LEVEL_UP_PROPERTIES_TIP";

		// Token: 0x04004EC0 RID: 20160
		[Token(Token = "0x4004EC0")]
		private const string MISSION_START_KWD = "RECIEVE_MISSION_START";

		// Token: 0x04004EC1 RID: 20161
		[Token(Token = "0x4004EC1")]
		private const string MISSION_FINISH_KWD = "RECIEVE_MISSION_FINISH";

		// Token: 0x04004EC2 RID: 20162
		[Token(Token = "0x4004EC2")]
		private const string SPELL_DECALARATION_KWD = "SPELL_DECLARE_TEXT";

		// Token: 0x04004EC3 RID: 20163
		[Token(Token = "0x4004EC3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject spriteMessageParent;

		// Token: 0x04004EC4 RID: 20164
		[Token(Token = "0x4004EC4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject badgeMessageParent;

		// Token: 0x04004EC5 RID: 20165
		[Token(Token = "0x4004EC5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject badgeWithoutCountMessageParent;

		// Token: 0x04004EC6 RID: 20166
		[Token(Token = "0x4004EC6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject textMessageParent;

		// Token: 0x04004EC7 RID: 20167
		[Token(Token = "0x4004EC7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject spriteMessageCountParent;

		// Token: 0x04004EC8 RID: 20168
		[Token(Token = "0x4004EC8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject textMessageCountParent;

		// Token: 0x04004EC9 RID: 20169
		[Token(Token = "0x4004EC9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject recievedMessagePositionIndicatorParent;

		// Token: 0x04004ECA RID: 20170
		[Token(Token = "0x4004ECA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RectTransform recievedObjectField;

		// Token: 0x04004ECB RID: 20171
		[Token(Token = "0x4004ECB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RectTransform recievedObjectLayoutField;

		// Token: 0x04004ECC RID: 20172
		[Token(Token = "0x4004ECC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public RectTransform flexibleRect;

		// Token: 0x04004ECD RID: 20173
		[Token(Token = "0x4004ECD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioClip onNotify;

		// Token: 0x04004ECE RID: 20174
		[Token(Token = "0x4004ECE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float messageStayDuration;

		// Token: 0x04004ECF RID: 20175
		[Token(Token = "0x4004ECF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float messageInsertionAdjustmentDuration;

		// Token: 0x04004ED0 RID: 20176
		[Token(Token = "0x4004ED0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int burstMessageFrameOffset;

		// Token: 0x04004ED1 RID: 20177
		[Token(Token = "0x4004ED1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int maxMessageCount;

		// Token: 0x04004ED2 RID: 20178
		[Token(Token = "0x4004ED2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<UIElementCluster, Vector3> currentVelocityBuffer;

		// Token: 0x04004ED3 RID: 20179
		[Token(Token = "0x4004ED3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly Queue<Action> executionQueue;

		// Token: 0x04004ED4 RID: 20180
		[Token(Token = "0x4004ED4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly Dictionary<Type, RectTransform> m_CustomSpacing;

		// Token: 0x04004ED5 RID: 20181
		[Token(Token = "0x4004ED5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly Vector3[] m_WorldPositionBuffer;

		// Token: 0x04004ED6 RID: 20182
		[Token(Token = "0x4004ED6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[TupleElementNames(new string[] { "objectData", "objectLayoutData" })]
		private readonly HashSet<ValueTuple<UIElementCluster, GameObject>> registeredObjectCollection;

		// Token: 0x04004ED7 RID: 20183
		[Token(Token = "0x4004ED7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly Queue<Action> releaseHandle;

		// Token: 0x04004ED8 RID: 20184
		[Token(Token = "0x4004ED8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Coroutine executionCoroutine;

		// Token: 0x04004ED9 RID: 20185
		[Token(Token = "0x4004ED9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool m_RefreshRequested;

		// Token: 0x04004EDA RID: 20186
		[Token(Token = "0x4004EDA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Action m_UnBindCallback;
	}
}

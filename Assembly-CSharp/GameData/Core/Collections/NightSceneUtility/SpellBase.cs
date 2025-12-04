using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cinemachine;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.UI.EventUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x020008F9 RID: 2297
	[Token(Token = "0x20008F9")]
	public abstract class SpellBase : ScriptableObject
	{
		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x06003954 RID: 14676 RVA: 0x00015C60 File Offset: 0x00013E60
		[Token(Token = "0x17000809")]
		protected virtual bool ShouldProtectedByShield
		{
			[Token(Token = "0x6003954")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06003955 RID: 14677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080A")]
		protected EventManager Manager
		{
			[Token(Token = "0x6003955")]
			[Address(RVA = "0x692EE0", Offset = "0x6918E0", VA = "0x180692EE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06003956 RID: 14678 RVA: 0x00015C78 File Offset: 0x00013E78
		[Token(Token = "0x1700080B")]
		protected float ExtraBuffTime
		{
			[Token(Token = "0x6003956")]
			[Address(RVA = "0x692E10", Offset = "0x691810", VA = "0x180692E10")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06003957 RID: 14679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080C")]
		private CinemachineVirtualCamera VirtualCamera
		{
			[Token(Token = "0x6003957")]
			[Address(RVA = "0x692F10", Offset = "0x691910", VA = "0x180692F10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x00015C90 File Offset: 0x00013E90
		[Token(Token = "0x6003958")]
		[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "5")]
		protected virtual bool ShouldCallSpellDeclarationAuto(bool isPositive)
		{
			return default(bool);
		}

		// Token: 0x06003959 RID: 14681
		[Token(Token = "0x6003959")]
		protected abstract string OnGettingSpellOwnerIdentifier();

		// Token: 0x0600395A RID: 14682 RVA: 0x00015CA8 File Offset: 0x00013EA8
		[Token(Token = "0x600395A")]
		[Address(RVA = "0x68FA00", Offset = "0x68E400", VA = "0x18068FA00")]
		protected int FinalBuffTime(float oldTime)
		{
			return 0;
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x00015CC0 File Offset: 0x00013EC0
		[Token(Token = "0x600395B")]
		[Address(RVA = "0x692150", Offset = "0x690B50", VA = "0x180692150")]
		protected bool RegisterTimedBuff(EventManager.BuffType buffType, float duration, Action<int> defaultRegisterBuffAction, EventManager.BuffRegisterType buffRegisterType = EventManager.BuffRegisterType.Additive, int extraDuration = -1, [Optional] Action<int> haveBuffRegisterBuffAction, bool isPositive = true)
		{
			return default(bool);
		}

		// Token: 0x0600395C RID: 14684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600395C")]
		[Address(RVA = "0x68F590", Offset = "0x68DF90", VA = "0x18068F590")]
		protected static void ExecuteDelayed(float delay, Action onDelayEndCallback)
		{
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600395D")]
		[Address(RVA = "0x68F490", Offset = "0x68DE90", VA = "0x18068F490")]
		protected static void ExecuteDelayedForOneFrame(Action onDelayEndCallback)
		{
		}

		// Token: 0x0600395E RID: 14686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600395E")]
		[Address(RVA = "0x68F3D0", Offset = "0x68DDD0", VA = "0x18068F3D0")]
		protected IEnumerator CallSpellDeclaration(SpecialGuest guestData, LanguageBase text, bool isPositiveSpellCard)
		{
			return null;
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600395F")]
		[Address(RVA = "0x692940", Offset = "0x691340", VA = "0x180692940")]
		protected IEnumerator SetCameraShake(float amplitude, float duration, float fadeTime)
		{
			return null;
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003960")]
		[Address(RVA = "0x6928F0", Offset = "0x6912F0", VA = "0x1806928F0")]
		protected void SetCameraShake(float amplitude)
		{
		}

		// Token: 0x06003961 RID: 14689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003961")]
		[Address(RVA = "0x691EB0", Offset = "0x6908B0", VA = "0x180691EB0")]
		protected void PlayAudio(AudioClip audioClip)
		{
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003962")]
		[Address(RVA = "0x691C30", Offset = "0x690630", VA = "0x180691C30")]
		protected void PlayAudioDelayed(AudioClip audioClip, float offset)
		{
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003963")]
		[Address(RVA = "0x691D40", Offset = "0x690740", VA = "0x180691D40")]
		protected void PlayAudioDelayed(SpellBase.DelayAudioClip delayAudioClip)
		{
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003964")]
		[Address(RVA = "0x691E50", Offset = "0x690850", VA = "0x180691E50")]
		protected void PlayAudioLooped(global::UnityEngine.Object identifier, LoopedBGMPackage loopedBGMPackage)
		{
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06003965 RID: 14693 RVA: 0x00015CD8 File Offset: 0x00013ED8
		[Token(Token = "0x1700080D")]
		public virtual bool HasPositiveSpell
		{
			[Token(Token = "0x6003965")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003966")]
		[Address(RVA = "0x692700", Offset = "0x691100", VA = "0x180692700")]
		public void SchedulePositiveBuffExecution(SpellExecutionContext spellExecutionContext)
		{
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003967")]
		[Address(RVA = "0x68F8E0", Offset = "0x68E2E0", VA = "0x18068F8E0")]
		public IEnumerator ExecutePositiveBuffAsync(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x00015CF0 File Offset: 0x00013EF0
		[Token(Token = "0x6003968")]
		[Address(RVA = "0x692060", Offset = "0x690A60", VA = "0x180692060")]
		private bool PreprocessPositiveBuff(SpellExecutionContext spellExecutionContext)
		{
			return default(bool);
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003969")]
		[Address(RVA = "0x68F970", Offset = "0x68E370", VA = "0x18068F970")]
		private IEnumerator ExecutePositiveBuff(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x0600396A RID: 14698
		[Token(Token = "0x600396A")]
		protected abstract IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext);

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x0600396B RID: 14699 RVA: 0x00015D08 File Offset: 0x00013F08
		[Token(Token = "0x1700080E")]
		public virtual bool HasNegativeSpell
		{
			[Token(Token = "0x600396B")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x00015D20 File Offset: 0x00013F20
		[Token(Token = "0x600396C")]
		[Address(RVA = "0x692CB0", Offset = "0x6916B0", VA = "0x180692CB0")]
		protected bool TryDefendNegativeSpell()
		{
			return default(bool);
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x00015D38 File Offset: 0x00013F38
		[Token(Token = "0x600396D")]
		[Address(RVA = "0x691F00", Offset = "0x690900", VA = "0x180691F00")]
		private bool PreprocessNegativeBuff(SpellExecutionContext spellExecutionContext)
		{
			return default(bool);
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396E")]
		[Address(RVA = "0x692210", Offset = "0x690C10", VA = "0x180692210")]
		public void ScheduleNegativeBuffExecution(SpellExecutionContext spellExecutionContext)
		{
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600396F")]
		[Address(RVA = "0x68F6A0", Offset = "0x68E0A0", VA = "0x18068F6A0")]
		public IEnumerator ExecuteNegativeBuffAsync(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003970")]
		[Address(RVA = "0x68F730", Offset = "0x68E130", VA = "0x18068F730")]
		private IEnumerator ExecuteNegativeBuff(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003971 RID: 14705
		[Token(Token = "0x6003971")]
		protected abstract IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext);

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06003972 RID: 14706 RVA: 0x00015D50 File Offset: 0x00013F50
		[Token(Token = "0x1700080F")]
		public virtual bool HasLeaveSpell
		{
			[Token(Token = "0x6003972")]
			[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003973")]
		[Address(RVA = "0x692510", Offset = "0x690F10", VA = "0x180692510")]
		public void ScheduleOnLeaveBuffExecution(SpellExecutionContext spellExecutionContext)
		{
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003974")]
		[Address(RVA = "0x68F7C0", Offset = "0x68E1C0", VA = "0x18068F7C0")]
		public IEnumerator ExecuteOnLeaveBuffAsync(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x00015D68 File Offset: 0x00013F68
		[Token(Token = "0x6003975")]
		[Address(RVA = "0x691FF0", Offset = "0x6909F0", VA = "0x180691FF0")]
		private bool PreprocessOnLeaveBuff(SpellExecutionContext spellExecutionContext)
		{
			return default(bool);
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003976")]
		[Address(RVA = "0x68F850", Offset = "0x68E250", VA = "0x18068F850")]
		private IEnumerator ExecuteOnLeaveBuff(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003977")]
		[Address(RVA = "0x691BD0", Offset = "0x6905D0", VA = "0x180691BD0", Slot = "12")]
		protected virtual IEnumerator OnLeaveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003978")]
		[Address(RVA = "0x691290", Offset = "0x68FC90", VA = "0x180691290")]
		protected IEnumerator InstantiateTimedC(GameObject parent, Action<GameObject> objectProcessingCallback, float duration, EffectLayerInfo effectLayerInfo = EffectLayerInfo.World)
		{
			return null;
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003979")]
		[Address(RVA = "0x691360", Offset = "0x68FD60", VA = "0x180691360")]
		protected IEnumerator InstantiateTimedC(GameObject parent, Vector3 position, float duration)
		{
			return null;
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397A")]
		[Address(RVA = "0x691110", Offset = "0x68FB10", VA = "0x180691110")]
		protected IEnumerator InstantiateTimedC(GameObject parent, Vector3 position, Action<GameObject> objectProcessingCallback, float duration)
		{
			return null;
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397B")]
		[Address(RVA = "0x6911D0", Offset = "0x68FBD0", VA = "0x1806911D0")]
		protected IEnumerator InstantiateTimedC(GameObject parent, Transform transform, Action<GameObject> objectProcessingCallback, float duration)
		{
			return null;
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397C")]
		[Address(RVA = "0x691600", Offset = "0x690000", VA = "0x180691600")]
		protected GameObject InstantiateTimedN(GameObject parent, float duration, EffectLayerInfo effectLayerInfo = EffectLayerInfo.World)
		{
			return null;
		}

		// Token: 0x0600397D RID: 14717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397D")]
		[Address(RVA = "0x691400", Offset = "0x68FE00", VA = "0x180691400")]
		protected GameObject InstantiateTimedN(GameObject parent, Action<GameObject> objectProcessingCallback, float duration, EffectLayerInfo effectLayerInfo = EffectLayerInfo.World)
		{
			return null;
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397E")]
		[Address(RVA = "0x6916B0", Offset = "0x6900B0", VA = "0x1806916B0")]
		protected GameObject InstantiateTimedN(GameObject parent, Vector3 position, float duration)
		{
			return null;
		}

		// Token: 0x0600397F RID: 14719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600397F")]
		[Address(RVA = "0x6914E0", Offset = "0x68FEE0", VA = "0x1806914E0")]
		protected GameObject InstantiateTimedN(GameObject parent, Vector3 position, Action<GameObject> objectProcessingCallback, float duration, EffectLayerInfo effectLayerInfo = EffectLayerInfo.World)
		{
			return null;
		}

		// Token: 0x06003980 RID: 14720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003980")]
		[Address(RVA = "0x691780", Offset = "0x690180", VA = "0x180691780")]
		protected GameObject InstantiateTimedN(GameObject parent, Transform transform, Action<GameObject> objectProcessingCallback, float duration)
		{
			return null;
		}

		// Token: 0x06003981 RID: 14721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003981")]
		[Address(RVA = "0x690C70", Offset = "0x68F670", VA = "0x180690C70")]
		private Transform GetSpellEffectParentTransform(EffectLayerInfo effectLayerInfo)
		{
			return null;
		}

		// Token: 0x06003982 RID: 14722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003982")]
		[Address(RVA = "0x691B10", Offset = "0x690510", VA = "0x180691B10")]
		protected IEnumerator LerpPosition(Transform source, Func<Vector3> targetPosition, float duration)
		{
			return null;
		}

		// Token: 0x06003983 RID: 14723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003983")]
		[Address(RVA = "0x691A30", Offset = "0x690430", VA = "0x180691A30")]
		protected IEnumerator LerpParabolic(Transform source, Func<Vector3> targetPosition, float launchHeight, float launchSpeed, bool forceRotate = false)
		{
			return null;
		}

		// Token: 0x06003984 RID: 14724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003984")]
		[Address(RVA = "0x691940", Offset = "0x690340", VA = "0x180691940")]
		protected IEnumerator LerpBezier(Transform source, Func<Vector3> controlPosition, Func<Vector3> targetPosition, float duration, bool forceRotate = false)
		{
			return null;
		}

		// Token: 0x06003985 RID: 14725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003985")]
		[Address(RVA = "0x691840", Offset = "0x690240", VA = "0x180691840")]
		protected IEnumerator LerpBezierCubic(Transform source, Func<Vector3> control1Position, Func<Vector3> control2Position, Func<Vector3> targetPosition, float duration, bool forceRotate = false)
		{
			return null;
		}

		// Token: 0x06003986 RID: 14726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003986")]
		[Address(RVA = "0x691020", Offset = "0x68FA20", VA = "0x180691020")]
		protected IEnumerator Homing(Transform source, Func<Vector3> targetPosition, float speed, float miniumAnglarSpeed, float maxinumAngularSpeed, float distanceOffset = 0.5f)
		{
			return null;
		}

		// Token: 0x06003987 RID: 14727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003987")]
		[Address(RVA = "0x690F20", Offset = "0x68F920", VA = "0x180690F20")]
		protected IEnumerator Homing(Transform source, Func<Vector3> targetPosition, Func<float> speed, Func<float> miniumAnglarSpeed, Func<float> maxinumAngularSpeed, float distanceOffset = 0.5f)
		{
			return null;
		}

		// Token: 0x06003988 RID: 14728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003988")]
		[Address(RVA = "0x692B40", Offset = "0x691540", VA = "0x180692B40")]
		protected void StopRotation(ref SpellExecutionContext spellExecutionContext, Transform source, string label)
		{
		}

		// Token: 0x06003989 RID: 14729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003989")]
		[Address(RVA = "0x6929D0", Offset = "0x6913D0", VA = "0x1806929D0")]
		protected void SetRotation(ref SpellExecutionContext spellExecutionContext, Transform source, string label, float speed, Vector3 point)
		{
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x00015D80 File Offset: 0x00013F80
		[Token(Token = "0x600398A")]
		[Address(RVA = "0x690A80", Offset = "0x68F480", VA = "0x180690A80")]
		public static Vector3 GetPlayerPosition(bool center = false)
		{
			return default(Vector3);
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398B")]
		[Address(RVA = "0x68FDB0", Offset = "0x68E7B0", VA = "0x18068FDB0")]
		protected IEnumerable<Vector3> GetAllGuestsPosition(bool center = false)
		{
			return null;
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x00015D98 File Offset: 0x00013F98
		[Token(Token = "0x600398C")]
		[Address(RVA = "0x690910", Offset = "0x68F310", VA = "0x180690910")]
		protected Vector3 GetFoodStoragePosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x00015DB0 File Offset: 0x00013FB0
		[Token(Token = "0x600398D")]
		[Address(RVA = "0x6906F0", Offset = "0x68F0F0", VA = "0x1806906F0")]
		protected Vector3 GetBeverageStoragePosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x00015DC8 File Offset: 0x00013FC8
		[Token(Token = "0x600398E")]
		[Address(RVA = "0x690BB0", Offset = "0x68F5B0", VA = "0x180690BB0")]
		protected Vector3 GetPlayerSpawnPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600398F")]
		[Address(RVA = "0x690C20", Offset = "0x68F620", VA = "0x180690C20")]
		public static Transform GetPlayerTransform()
		{
			return null;
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003990")]
		[Address(RVA = "0x690DD0", Offset = "0x68F7D0", VA = "0x180690DD0")]
		protected Transform GetUIEffectTransformFront()
		{
			return null;
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003991")]
		[Address(RVA = "0x690E60", Offset = "0x68F860", VA = "0x180690E60")]
		protected Transform GetUIEffectTransformTop()
		{
			return null;
		}

		// Token: 0x06003992 RID: 14738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003992")]
		[Address(RVA = "0x690E20", Offset = "0x68F820", VA = "0x180690E20")]
		protected Transform GetUIEffectTransformMiddle()
		{
			return null;
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003993")]
		[Address(RVA = "0x690D90", Offset = "0x68F790", VA = "0x180690D90")]
		protected Transform GetUIEffectTransformBack()
		{
			return null;
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003994")]
		[Address(RVA = "0x690760", Offset = "0x68F160", VA = "0x180690760")]
		protected BuffModule GetBuffModule()
		{
			return null;
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003995")]
		[Address(RVA = "0x690980", Offset = "0x68F380", VA = "0x180690980")]
		protected GuestBuffMarkModule GetGuestBuffMarkModule()
		{
			return null;
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x00015DE0 File Offset: 0x00013FE0
		[Token(Token = "0x6003996")]
		[Address(RVA = "0x690EB0", Offset = "0x68F8B0", VA = "0x180690EB0")]
		protected Vector3 GetWorldToScreenPoint(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x00015DF8 File Offset: 0x00013FF8
		[Token(Token = "0x6003997")]
		[Address(RVA = "0x6909C0", Offset = "0x68F3C0", VA = "0x1806909C0")]
		public static Vector3 GetGuestTable(int deskCode)
		{
			return default(Vector3);
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003998")]
		[Address(RVA = "0x68FEA0", Offset = "0x68E8A0", VA = "0x18068FEA0")]
		protected IEnumerable<GuestGroupController> GetAllSeatedGuestGroups()
		{
			return null;
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003999")]
		[Address(RVA = "0x68FB30", Offset = "0x68E530", VA = "0x18068FB30")]
		protected IEnumerable<GuestGroupController> GetAllActiveGuestGroups()
		{
			return null;
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x00015E10 File Offset: 0x00014010
		[Token(Token = "0x600399A")]
		[Address(RVA = "0x690850", Offset = "0x68F250", VA = "0x180690850")]
		protected Vector3 GetCookerTable(int deskCode)
		{
			return default(Vector3);
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399B")]
		[Address(RVA = "0x6907A0", Offset = "0x68F1A0", VA = "0x1806907A0")]
		protected CookController GetCookerController(int deskCode)
		{
			return null;
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399C")]
		[Address(RVA = "0x68FB80", Offset = "0x68E580", VA = "0x18068FB80")]
		protected IEnumerable<Vector3> GetAllCookerTables()
		{
			return null;
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399D")]
		[Address(RVA = "0x6905A0", Offset = "0x68EFA0", VA = "0x1806905A0")]
		protected IEnumerable<Vector3> GetAllTables()
		{
			return null;
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399E")]
		[Address(RVA = "0x6901B0", Offset = "0x68EBB0", VA = "0x1806901B0")]
		protected Dictionary<int, Vector3> GetAllTablesData()
		{
			return null;
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399F")]
		[Address(RVA = "0x6903C0", Offset = "0x68EDC0", VA = "0x1806903C0")]
		protected IEnumerable<Vector3> GetAllTablesExceptOne(int deskCode)
		{
			return null;
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A0")]
		[Address(RVA = "0x68FEF0", Offset = "0x68E8F0", VA = "0x18068FEF0")]
		protected Dictionary<int, Vector3> GetAllTablesDataExceptOne(int deskCode)
		{
			return null;
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A1")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		protected SpellBase()
		{
		}

		// Token: 0x040030E2 RID: 12514
		[Token(Token = "0x40030E2")]
		public const int DEFAULT_POSITIVE_SPELL_LANG = 0;

		// Token: 0x040030E3 RID: 12515
		[Token(Token = "0x40030E3")]
		public const int DEFAULT_NEGATIVE_SPELL_LANG = 1;

		// Token: 0x020008FA RID: 2298
		[Token(Token = "0x20008FA")]
		[Serializable]
		public struct DelayAudioClip
		{
			// Token: 0x040030E4 RID: 12516
			[Token(Token = "0x40030E4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public AudioClip audioClip;

			// Token: 0x040030E5 RID: 12517
			[Token(Token = "0x40030E5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			public float delay;
		}
	}
}

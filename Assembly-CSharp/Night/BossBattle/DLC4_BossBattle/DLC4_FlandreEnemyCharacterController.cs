using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001A8 RID: 424
	[Token(Token = "0x20001A8")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(Rigidbody2D))]
	public class DLC4_FlandreEnemyCharacterController : MonoBehaviour
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x170000E9")]
		public FlandreTypeIndex Id
		{
			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x403830", Offset = "0x402230", VA = "0x180403830")]
			get
			{
				return FlandreTypeIndex.Pleased;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EA")]
		public Rigidbody2D Rigidbody2D
		{
			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000EB")]
		public Animator Animator
		{
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Token(Token = "0x170000EC")]
		public int MaxHealth
		{
			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x4D1E80", Offset = "0x4D0880", VA = "0x1804D1E80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x00004B00 File Offset: 0x00002D00
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000ED")]
		public int CurrentHealth
		{
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x477F00", Offset = "0x476900", VA = "0x180477F00")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x8D0020", Offset = "0x8CEA20", VA = "0x1808D0020")]
			private set
			{
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x170000EE")]
		public int DropPPoint
		{
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x79FFF0", Offset = "0x79E9F0", VA = "0x18079FFF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x00004B30 File Offset: 0x00002D30
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000EF")]
		public Vector2Int MoveDirection
		{
			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x8D0010", Offset = "0x8CEA10", VA = "0x1808D0010")]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x8D0060", Offset = "0x8CEA60", VA = "0x1808D0060")]
			private set
			{
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x00004B48 File Offset: 0x00002D48
		// (set) Token: 0x06000A3B RID: 2619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F0")]
		public int? MoveTargetY
		{
			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x4D1ED0", Offset = "0x4D08D0", VA = "0x1804D1ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x8D0090", Offset = "0x8CEA90", VA = "0x1808D0090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x170000F1")]
		public int CurrentLine
		{
			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x8CFD50", Offset = "0x8CE750", VA = "0x1808CFD50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x170000F2")]
		public Vector2 CurrentPosition
		{
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x8CFDD0", Offset = "0x8CE7D0", VA = "0x1808CFDD0")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x00004B90 File Offset: 0x00002D90
		// (set) Token: 0x06000A3F RID: 2623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F3")]
		public bool SuperArmor
		{
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x4E0A50", Offset = "0x4DF450", VA = "0x1804E0A50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x4E0B80", Offset = "0x4DF580", VA = "0x1804E0B80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x00004BA8 File Offset: 0x00002DA8
		// (set) Token: 0x06000A41 RID: 2625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F4")]
		public bool IsMoving
		{
			[Token(Token = "0x6000A40")]
			[Address(RVA = "0x4E0780", Offset = "0x4DF180", VA = "0x1804E0780")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A41")]
			[Address(RVA = "0x4E0B40", Offset = "0x4DF540", VA = "0x1804E0B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x00004BC0 File Offset: 0x00002DC0
		// (set) Token: 0x06000A43 RID: 2627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F5")]
		public bool IsAttacking
		{
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x8CFFE0", Offset = "0x8CE9E0", VA = "0x1808CFFE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x8D0040", Offset = "0x8CEA40", VA = "0x1808D0040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x00004BD8 File Offset: 0x00002DD8
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F6")]
		public bool IsDead
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x8CFFF0", Offset = "0x8CE9F0", VA = "0x1808CFFF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x8D0050", Offset = "0x8CEA50", VA = "0x1808D0050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x170000F7")]
		public bool IsStuned
		{
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x8D0000", Offset = "0x8CEA00", VA = "0x1808D0000")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000A47 RID: 2631 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x170000F8")]
		public virtual bool CanBeFrozen
		{
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000A48 RID: 2632 RVA: 0x00004C20 File Offset: 0x00002E20
		// (set) Token: 0x06000A49 RID: 2633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000F9")]
		public DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty.RefreshNextWaveType RefreshNextWaveType
		{
			[Token(Token = "0x6000A48")]
			[Address(RVA = "0x48A710", Offset = "0x489110", VA = "0x18048A710")]
			[CompilerGenerated]
			get
			{
				return DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty.RefreshNextWaveType.Normal;
			}
			[Token(Token = "0x6000A49")]
			[Address(RVA = "0x48AB20", Offset = "0x489520", VA = "0x18048AB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000A4A RID: 2634 RVA: 0x00004C38 File Offset: 0x00002E38
		// (set) Token: 0x06000A4B RID: 2635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FA")]
		public DLC4_FlandreEnemyCharacterController.CharacterState CurrentState
		{
			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0x45EA70", Offset = "0x45D470", VA = "0x18045EA70")]
			[CompilerGenerated]
			get
			{
				return DLC4_FlandreEnemyCharacterController.CharacterState.Idle;
			}
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x48AAF0", Offset = "0x4894F0", VA = "0x18048AAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x170000FB")]
		public float CurrentSpeed
		{
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x8CFFC0", Offset = "0x8CE9C0", VA = "0x1808CFFC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000A4D RID: 2637 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A4E RID: 2638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FC")]
		public DLC4_BossBattleManager Dlc4BossBattleManager
		{
			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x419D00", Offset = "0x418700", VA = "0x180419D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x419D50", Offset = "0x418750", VA = "0x180419D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x170000FD")]
		protected int CurrentPower
		{
			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x8CFE10", Offset = "0x8CE810", VA = "0x1808CFE10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000A50 RID: 2640 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A51 RID: 2641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000FE")]
		protected DLC4_GuardController TargetGuestFortification
		{
			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x4E0700", Offset = "0x4DF100", VA = "0x1804E0700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x4E0B20", Offset = "0x4DF520", VA = "0x1804E0B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x8CD810", Offset = "0x8CC210", VA = "0x1808CD810")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x8CE5C0", Offset = "0x8CCFC0", VA = "0x1808CE5C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x8CF4B0", Offset = "0x8CDEB0", VA = "0x1808CF4B0")]
		private void SetSpeedMultiplierBuffer()
		{
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x8CD8A0", Offset = "0x8CC2A0", VA = "0x1808CD8A0")]
		public string GetFlandreNameInConsole()
		{
			return null;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x8CD970", Offset = "0x8CC370", VA = "0x1808CD970", Slot = "5")]
		public virtual void Initialize(DLC4_BossBattleManager dlc4BossBattleManager, Action afterAttackingFinishCallback, Action afterCompletelyDeadCallback, DLC4_FlandreEnemyCharacterController.AttackConditionCheck attackConditionCheck)
		{
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x8CF830", Offset = "0x8CE230", VA = "0x1808CF830")]
		private void SpeedCheck()
		{
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x8CE7E0", Offset = "0x8CD1E0", VA = "0x1808CE7E0")]
		private void PoisonDamage()
		{
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "6")]
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x8CEEE0", Offset = "0x8CD8E0", VA = "0x1808CEEE0")]
		public void SetCurrentState(DLC4_FlandreEnemyCharacterController.CharacterState nextState)
		{
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x8CCD40", Offset = "0x8CB740", VA = "0x1808CCD40", Slot = "7")]
		public virtual bool CanAttack()
		{
			return default(bool);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x8CCAF0", Offset = "0x8CB4F0", VA = "0x1808CCAF0")]
		public void Attack()
		{
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x8CE330", Offset = "0x8CCD30", VA = "0x1808CE330", Slot = "8")]
		protected virtual void OnAttack()
		{
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "9")]
		protected virtual void OnCurrentHPChangeCallback(int hpAfterChange)
		{
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x8CE5E0", Offset = "0x8CCFE0", VA = "0x1808CE5E0")]
		public void OnHurt(int damage, bool showMercy = false, bool internalInjury = false)
		{
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x8CCCA0", Offset = "0x8CB6A0", VA = "0x1808CCCA0", Slot = "10")]
		protected virtual void CalculateRemainingHealth(int damage, bool showMercy = false, bool internalInjury = false)
		{
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x8CE2D0", Offset = "0x8CCCD0", VA = "0x1808CE2D0")]
		public void Kill()
		{
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x8CCFA0", Offset = "0x8CB9A0", VA = "0x1808CCFA0")]
		public void ChangeSpeed(int bulletId, float multiplier, float duration, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x8CF000", Offset = "0x8CDA00", VA = "0x1808CF000")]
		public void SetPoison(int bulletId, int poisonDamage, float duration, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x8CFC20", Offset = "0x8CE620", VA = "0x1808CFC20")]
		private void StopPoisonVFX()
		{
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x8CCBB0", Offset = "0x8CB5B0", VA = "0x1808CCBB0")]
		public void BeginStun(float duration, out Action interruptCallback)
		{
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x8CCE50", Offset = "0x8CB850", VA = "0x1808CCE50")]
		public void ChangePower(float multiplier, float duration, out Action interruptCallback)
		{
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x8CEC80", Offset = "0x8CD680", VA = "0x1808CEC80")]
		public void RegisterCoroutine(IEnumerator enumerator)
		{
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x8CF730", Offset = "0x8CE130", VA = "0x1808CF730")]
		public void SetTargetPositionY(int? targetPositionY)
		{
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x8CEFA0", Offset = "0x8CD9A0", VA = "0x1808CEFA0")]
		public void SetMoveDirectionX(bool targetPositionX)
		{
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x8CFA40", Offset = "0x8CE440", VA = "0x1808CFA40")]
		private void StartRegisterBuff(float duration, Action onBuffEnd, out Action interruptCallback)
		{
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x8CEE40", Offset = "0x8CD840", VA = "0x1808CEE40")]
		private IEnumerator RegisterTimedBuffInternal(Guid guid, float duration)
		{
			return null;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x8CEBD0", Offset = "0x8CD5D0", VA = "0x1808CEBD0")]
		private IEnumerator RegisterCoroutineInternal(Guid guid, Coroutine coroutine)
		{
			return null;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x8CD2F0", Offset = "0x8CBCF0", VA = "0x1808CD2F0", Slot = "11")]
		protected virtual void Die()
		{
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x8CE6F0", Offset = "0x8CD0F0", VA = "0x1808CE6F0")]
		private void PlayIdleAnimation()
		{
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x8CE740", Offset = "0x8CD140", VA = "0x1808CE740")]
		private void PlayMoveAnimation()
		{
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x8CE650", Offset = "0x8CD050", VA = "0x1808CE650")]
		private void PlayAttackAnimation()
		{
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x8CE790", Offset = "0x8CD190", VA = "0x1808CE790")]
		private void PlayStunAnimation()
		{
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x8CE6A0", Offset = "0x8CD0A0", VA = "0x1808CE6A0")]
		private void PlayDieAnimation()
		{
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x8CD460", Offset = "0x8CBE60", VA = "0x1808CD460")]
		public void Dispose()
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x8CD140", Offset = "0x8CBB40", VA = "0x1808CD140", Slot = "12")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x8CFCC0", Offset = "0x8CE6C0", VA = "0x1808CFCC0")]
		public DLC4_FlandreEnemyCharacterController()
		{
		}

		// Token: 0x0400092A RID: 2346
		[Token(Token = "0x400092A")]
		private const string PARAMETER_IDLE = "Idle";

		// Token: 0x0400092B RID: 2347
		[Token(Token = "0x400092B")]
		private const string PARAMETER_MOVE = "Move";

		// Token: 0x0400092C RID: 2348
		[Token(Token = "0x400092C")]
		private const string PARAMETER_ATTACK = "Attack";

		// Token: 0x0400092D RID: 2349
		[Token(Token = "0x400092D")]
		private const string PARAMETER_STUN = "Stun";

		// Token: 0x0400092E RID: 2350
		[Token(Token = "0x400092E")]
		private const string PARAMETER_DIE = "Die";

		// Token: 0x0400092F RID: 2351
		[Token(Token = "0x400092F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FlandreTypeIndex m_EnemyId;

		// Token: 0x04000930 RID: 2352
		[Token(Token = "0x4000930")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform m_PivotPoint;

		// Token: 0x04000931 RID: 2353
		[Token(Token = "0x4000931")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected SpriteRenderer m_SpriteRenderer;

		// Token: 0x04000932 RID: 2354
		[Token(Token = "0x4000932")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Rigidbody2D m_Rigidbody2D;

		// Token: 0x04000933 RID: 2355
		[Token(Token = "0x4000933")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Animator m_Animator;

		// Token: 0x04000934 RID: 2356
		[Token(Token = "0x4000934")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int m_MaxHealth;

		// Token: 0x04000935 RID: 2357
		[Token(Token = "0x4000935")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int m_AttackPower;

		// Token: 0x04000936 RID: 2358
		[Token(Token = "0x4000936")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float m_BaseSpeed;

		// Token: 0x04000937 RID: 2359
		[Token(Token = "0x4000937")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_AttackRange;

		// Token: 0x04000938 RID: 2360
		[Token(Token = "0x4000938")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("掉落P点")]
		[SerializeField]
		private int m_DropPPoint;

		// Token: 0x04000939 RID: 2361
		[Token(Token = "0x4000939")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("死亡特效")]
		[SerializeField]
		protected VFXPrefab m_BatFogVFX;

		// Token: 0x0400093A RID: 2362
		[Token(Token = "0x400093A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Action<DLC4_FlandreEnemyCharacterController> OnFlandreCompletelyDied;

		// Token: 0x0400093B RID: 2363
		[Token(Token = "0x400093B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Dictionary<Guid, Action> ActiveCoroutineList;

		// Token: 0x0400093C RID: 2364
		[Token(Token = "0x400093C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private DLC4_FlandreEnemyCharacterController.AttackConditionCheck attackConditionCheck;

		// Token: 0x0400093D RID: 2365
		[Token(Token = "0x400093D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AttackState attackManager;

		// Token: 0x0400093E RID: 2366
		[Token(Token = "0x400093E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<float> attackMultiplier;

		// Token: 0x0400093F RID: 2367
		[Token(Token = "0x400093F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int currentHealth;

		// Token: 0x04000940 RID: 2368
		[Token(Token = "0x4000940")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private DieState dieManager;

		// Token: 0x04000941 RID: 2369
		[Token(Token = "0x4000941")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private DLC4_FlandreEnemyState enemyCurrentState;

		// Token: 0x04000942 RID: 2370
		[Token(Token = "0x4000942")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private IdleState idleManager;

		// Token: 0x04000943 RID: 2371
		[Token(Token = "0x4000943")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int isStuned;

		// Token: 0x04000944 RID: 2372
		[Token(Token = "0x4000944")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector2Int moveDirection;

		// Token: 0x04000945 RID: 2373
		[Token(Token = "0x4000945")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private MoveState moveManager;

		// Token: 0x04000946 RID: 2374
		[Token(Token = "0x4000946")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Action<int> onHurtCallback;

		// Token: 0x04000947 RID: 2375
		[Token(Token = "0x4000947")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Dictionary<int, DLC4_FlandreEnemyCharacterController.MultiplierModifier> poisonDamageStorage;

		// Token: 0x04000948 RID: 2376
		[Token(Token = "0x4000948")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float poisonProgress;

		// Token: 0x04000949 RID: 2377
		[Token(Token = "0x4000949")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ParticleSystem poisonVFX;

		// Token: 0x0400094A RID: 2378
		[Token(Token = "0x400094A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Dictionary<int, DLC4_FlandreEnemyCharacterController.MultiplierModifier> speedMultiplier;

		// Token: 0x0400094B RID: 2379
		[Token(Token = "0x400094B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float speedMultiplierBuffer;

		// Token: 0x0400094C RID: 2380
		[Token(Token = "0x400094C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected Dictionary<DLC4_FlandreEnemyCharacterController.CharacterState, DLC4_FlandreEnemyState> StateDictionary;

		// Token: 0x0400094D RID: 2381
		[Token(Token = "0x400094D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private StunState stunManager;

		// Token: 0x020001A9 RID: 425
		// (Invoke) Token: 0x06000A78 RID: 2680
		[Token(Token = "0x20001A9")]
		public delegate bool AttackConditionCheck(bool moveDirection, float attackRange, int currentLine, Vector2 position, out DLC4_GuardController guestFortification);

		// Token: 0x020001AA RID: 426
		[Token(Token = "0x20001AA")]
		public enum CharacterState
		{
			// Token: 0x04000958 RID: 2392
			[Token(Token = "0x4000958")]
			[InspectorName("闲置")]
			Idle,
			// Token: 0x04000959 RID: 2393
			[Token(Token = "0x4000959")]
			[InspectorName("移动")]
			Move,
			// Token: 0x0400095A RID: 2394
			[Token(Token = "0x400095A")]
			[InspectorName("攻击")]
			Attack,
			// Token: 0x0400095B RID: 2395
			[Token(Token = "0x400095B")]
			[InspectorName("眩晕")]
			Stun,
			// Token: 0x0400095C RID: 2396
			[Token(Token = "0x400095C")]
			[InspectorName("死亡")]
			Die,
			// Token: 0x0400095D RID: 2397
			[Token(Token = "0x400095D")]
			[InspectorName("远程攻击（喜、破坏神）")]
			Throw,
			// Token: 0x0400095E RID: 2398
			[Token(Token = "0x400095E")]
			[InspectorName("跳跃（乐）")]
			Jump
		}

		// Token: 0x020001AB RID: 427
		[Token(Token = "0x20001AB")]
		[Serializable]
		public struct FlandreBullet
		{
			// Token: 0x0400095F RID: 2399
			[Token(Token = "0x400095F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public DLC4_BulletEnemy m_Bullet;

			// Token: 0x04000960 RID: 2400
			[Token(Token = "0x4000960")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			public int m_Damage;

			// Token: 0x04000961 RID: 2401
			[Token(Token = "0x4000961")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			[SerializeField]
			public float m_Speed;

			// Token: 0x04000962 RID: 2402
			[Token(Token = "0x4000962")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public float m_MaxDuration;
		}

		// Token: 0x020001AC RID: 428
		[Token(Token = "0x20001AC")]
		private struct MultiplierModifier
		{
			// Token: 0x06000A7B RID: 2683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x8D9E40", Offset = "0x8D8840", VA = "0x1808D9E40")]
			public MultiplierModifier(float duration, float multiplier, Action onBuffEnd)
			{
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x06000A7C RID: 2684 RVA: 0x00004C98 File Offset: 0x00002E98
			// (set) Token: 0x06000A7D RID: 2685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170000FF")]
			public float RemainingDuration
			{
				[Token(Token = "0x6000A7C")]
				[Address(RVA = "0x517C90", Offset = "0x516690", VA = "0x180517C90")]
				[CompilerGenerated]
				readonly get
				{
					return 0f;
				}
				[Token(Token = "0x6000A7D")]
				[Address(RVA = "0x517CB0", Offset = "0x5166B0", VA = "0x180517CB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x06000A7E RID: 2686 RVA: 0x00004CB0 File Offset: 0x00002EB0
			[Token(Token = "0x17000100")]
			public readonly float Multiplier
			{
				[Token(Token = "0x6000A7E")]
				[Address(RVA = "0x8D9E60", Offset = "0x8D8860", VA = "0x1808D9E60")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}

			// Token: 0x06000A7F RID: 2687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000A7F")]
			[Address(RVA = "0x8D9E00", Offset = "0x8D8800", VA = "0x1808D9E00")]
			public void OnBuffEnd()
			{
			}

			// Token: 0x06000A80 RID: 2688 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x3EC190", Offset = "0x3EAB90", VA = "0x1803EC190")]
			public void SetNewAction(Action onBuffEnd)
			{
			}

			// Token: 0x04000963 RID: 2403
			[Token(Token = "0x4000963")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Action onBuffEnd;
		}
	}
}

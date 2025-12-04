using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Common
{
	// Token: 0x02000D83 RID: 3459
	[Token(Token = "0x2000D83")]
	public class DataExporterInput : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
	{
		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x0600510C RID: 20748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B72")]
		public InputActionAsset asset
		{
			[Token(Token = "0x600510C")]
			[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600510D RID: 20749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510D")]
		[Address(RVA = "0x7DA9C0", Offset = "0x7D93C0", VA = "0x1807DA9C0")]
		public DataExporterInput()
		{
		}

		// Token: 0x0600510E RID: 20750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600510E")]
		[Address(RVA = "0x7DA8B0", Offset = "0x7D92B0", VA = "0x1807DA8B0", Slot = "17")]
		public void Dispose()
		{
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x0600510F RID: 20751 RVA: 0x0001D700 File Offset: 0x0001B900
		// (set) Token: 0x06005110 RID: 20752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B73")]
		public InputBinding? bindingMask
		{
			[Token(Token = "0x600510F")]
			[Address(RVA = "0x7DAAE0", Offset = "0x7D94E0", VA = "0x1807DAAE0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005110")]
			[Address(RVA = "0x7DABD0", Offset = "0x7D95D0", VA = "0x1807DABD0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x06005111 RID: 20753 RVA: 0x0001D718 File Offset: 0x0001B918
		// (set) Token: 0x06005112 RID: 20754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B74")]
		public ReadOnlyArray<InputDevice>? devices
		{
			[Token(Token = "0x6005111")]
			[Address(RVA = "0x7DAB90", Offset = "0x7D9590", VA = "0x1807DAB90", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005112")]
			[Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x06005113 RID: 20755 RVA: 0x0001D730 File Offset: 0x0001B930
		[Token(Token = "0x17000B75")]
		public ReadOnlyArray<InputControlScheme> controlSchemes
		{
			[Token(Token = "0x6005113")]
			[Address(RVA = "0x7DAB50", Offset = "0x7D9550", VA = "0x1807DAB50", Slot = "11")]
			get
			{
				return default(ReadOnlyArray<InputControlScheme>);
			}
		}

		// Token: 0x06005114 RID: 20756 RVA: 0x0001D748 File Offset: 0x0001B948
		[Token(Token = "0x6005114")]
		[Address(RVA = "0x7DA870", Offset = "0x7D9270", VA = "0x1807DA870", Slot = "12")]
		public bool Contains(InputAction action)
		{
			return default(bool);
		}

		// Token: 0x06005115 RID: 20757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005115")]
		[Address(RVA = "0x7DA9A0", Offset = "0x7D93A0", VA = "0x1807DA9A0", Slot = "15")]
		public IEnumerator<InputAction> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005116 RID: 20758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005116")]
		[Address(RVA = "0x7DA9A0", Offset = "0x7D93A0", VA = "0x1807DA9A0", Slot = "16")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005117 RID: 20759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005117")]
		[Address(RVA = "0x7DA900", Offset = "0x7D9300", VA = "0x1807DA900", Slot = "13")]
		public void Enable()
		{
		}

		// Token: 0x06005118 RID: 20760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005118")]
		[Address(RVA = "0x7DA890", Offset = "0x7D9290", VA = "0x1807DA890", Slot = "14")]
		public void Disable()
		{
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x06005119 RID: 20761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B76")]
		public IEnumerable<InputBinding> bindings
		{
			[Token(Token = "0x6005119")]
			[Address(RVA = "0x7DAB30", Offset = "0x7D9530", VA = "0x1807DAB30", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600511A RID: 20762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600511A")]
		[Address(RVA = "0x7DA920", Offset = "0x7D9320", VA = "0x1807DA920", Slot = "5")]
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			return null;
		}

		// Token: 0x0600511B RID: 20763 RVA: 0x0001D760 File Offset: 0x0001B960
		[Token(Token = "0x600511B")]
		[Address(RVA = "0x7DA940", Offset = "0x7D9340", VA = "0x1807DA940", Slot = "6")]
		public int FindBinding(InputBinding bindingMask, out InputAction action)
		{
			return 0;
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x0600511C RID: 20764 RVA: 0x0001D778 File Offset: 0x0001B978
		[Token(Token = "0x17000B77")]
		public DataExporterInput.UniversalActions Universal
		{
			[Token(Token = "0x600511C")]
			[Address(RVA = "0x7DAAC0", Offset = "0x7D94C0", VA = "0x1807DAAC0")]
			get
			{
				return default(DataExporterInput.UniversalActions);
			}
		}

		// Token: 0x04004C07 RID: 19463
		[Token(Token = "0x4004C07")]
		[FieldOffset(Offset = "0x18")]
		private readonly InputActionMap m_Universal;

		// Token: 0x04004C08 RID: 19464
		[Token(Token = "0x4004C08")]
		[FieldOffset(Offset = "0x20")]
		private DataExporterInput.IUniversalActions m_UniversalActionsCallbackInterface;

		// Token: 0x04004C09 RID: 19465
		[Token(Token = "0x4004C09")]
		[FieldOffset(Offset = "0x28")]
		private readonly InputAction m_Universal_Export;

		// Token: 0x04004C0A RID: 19466
		[Token(Token = "0x4004C0A")]
		[FieldOffset(Offset = "0x30")]
		private readonly InputAction m_Universal_SkipButton;

		// Token: 0x02000D84 RID: 3460
		[Token(Token = "0x2000D84")]
		public struct UniversalActions
		{
			// Token: 0x0600511D RID: 20765 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600511D")]
			[Address(RVA = "0x3EC190", Offset = "0x3EAB90", VA = "0x1803EC190")]
			public UniversalActions(DataExporterInput wrapper)
			{
			}

			// Token: 0x17000B78 RID: 2936
			// (get) Token: 0x0600511E RID: 20766 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000B78")]
			public InputAction Export
			{
				[Token(Token = "0x600511E")]
				[Address(RVA = "0x7F92F0", Offset = "0x7F7CF0", VA = "0x1807F92F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B79 RID: 2937
			// (get) Token: 0x0600511F RID: 20767 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000B79")]
			public InputAction SkipButton
			{
				[Token(Token = "0x600511F")]
				[Address(RVA = "0x7F9310", Offset = "0x7F7D10", VA = "0x1807F9310")]
				get
				{
					return null;
				}
			}

			// Token: 0x06005120 RID: 20768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005120")]
			[Address(RVA = "0x6658E0", Offset = "0x6642E0", VA = "0x1806658E0")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06005121 RID: 20769 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005121")]
			[Address(RVA = "0x7F88D0", Offset = "0x7F72D0", VA = "0x1807F88D0")]
			public void Enable()
			{
			}

			// Token: 0x06005122 RID: 20770 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005122")]
			[Address(RVA = "0x7F88A0", Offset = "0x7F72A0", VA = "0x1807F88A0")]
			public void Disable()
			{
			}

			// Token: 0x17000B7A RID: 2938
			// (get) Token: 0x06005123 RID: 20771 RVA: 0x0001D790 File Offset: 0x0001B990
			[Token(Token = "0x17000B7A")]
			public bool enabled
			{
				[Token(Token = "0x6005123")]
				[Address(RVA = "0x7F9330", Offset = "0x7F7D30", VA = "0x1807F9330")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06005124 RID: 20772 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005124")]
			[Address(RVA = "0x7F9360", Offset = "0x7F7D60", VA = "0x1807F9360")]
			public static implicit operator InputActionMap(DataExporterInput.UniversalActions set)
			{
				return null;
			}

			// Token: 0x06005125 RID: 20773 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005125")]
			[Address(RVA = "0x7F8900", Offset = "0x7F7300", VA = "0x1807F8900")]
			public void SetCallbacks(DataExporterInput.IUniversalActions instance)
			{
			}

			// Token: 0x04004C0B RID: 19467
			[Token(Token = "0x4004C0B")]
			[FieldOffset(Offset = "0x0")]
			private DataExporterInput m_Wrapper;
		}

		// Token: 0x02000D85 RID: 3461
		[Token(Token = "0x2000D85")]
		public interface IUniversalActions
		{
			// Token: 0x06005126 RID: 20774
			[Token(Token = "0x6005126")]
			void OnExport(InputAction.CallbackContext context);

			// Token: 0x06005127 RID: 20775
			[Token(Token = "0x6005127")]
			void OnSkipButton(InputAction.CallbackContext context);
		}
	}
}

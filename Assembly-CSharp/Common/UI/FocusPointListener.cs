using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Common.UI
{
	// Token: 0x02000E74 RID: 3700
	[Token(Token = "0x2000E74")]
	public class FocusPointListener : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
	{
		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x0600567C RID: 22140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C16")]
		public InputActionAsset asset
		{
			[Token(Token = "0x600567C")]
			[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600567D RID: 22141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600567D")]
		[Address(RVA = "0x8506F0", Offset = "0x84F0F0", VA = "0x1808506F0")]
		public FocusPointListener()
		{
		}

		// Token: 0x0600567E RID: 22142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600567E")]
		[Address(RVA = "0x8506A0", Offset = "0x84F0A0", VA = "0x1808506A0", Slot = "17")]
		public void Dispose()
		{
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x0600567F RID: 22143 RVA: 0x0001E8E8 File Offset: 0x0001CAE8
		// (set) Token: 0x06005680 RID: 22144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C17")]
		public InputBinding? bindingMask
		{
			[Token(Token = "0x600567F")]
			[Address(RVA = "0x7DAAE0", Offset = "0x7D94E0", VA = "0x1807DAAE0", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005680")]
			[Address(RVA = "0x7DABD0", Offset = "0x7D95D0", VA = "0x1807DABD0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06005681 RID: 22145 RVA: 0x0001E900 File Offset: 0x0001CB00
		// (set) Token: 0x06005682 RID: 22146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C18")]
		public ReadOnlyArray<InputDevice>? devices
		{
			[Token(Token = "0x6005681")]
			[Address(RVA = "0x7DAB90", Offset = "0x7D9590", VA = "0x1807DAB90", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005682")]
			[Address(RVA = "0x7DAC30", Offset = "0x7D9630", VA = "0x1807DAC30", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x06005683 RID: 22147 RVA: 0x0001E918 File Offset: 0x0001CB18
		[Token(Token = "0x17000C19")]
		public ReadOnlyArray<InputControlScheme> controlSchemes
		{
			[Token(Token = "0x6005683")]
			[Address(RVA = "0x7DAB50", Offset = "0x7D9550", VA = "0x1807DAB50", Slot = "11")]
			get
			{
				return default(ReadOnlyArray<InputControlScheme>);
			}
		}

		// Token: 0x06005684 RID: 22148 RVA: 0x0001E930 File Offset: 0x0001CB30
		[Token(Token = "0x6005684")]
		[Address(RVA = "0x7DA870", Offset = "0x7D9270", VA = "0x1807DA870", Slot = "12")]
		public bool Contains(InputAction action)
		{
			return default(bool);
		}

		// Token: 0x06005685 RID: 22149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005685")]
		[Address(RVA = "0x7DA9A0", Offset = "0x7D93A0", VA = "0x1807DA9A0", Slot = "15")]
		public IEnumerator<InputAction> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005686 RID: 22150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005686")]
		[Address(RVA = "0x7DA9A0", Offset = "0x7D93A0", VA = "0x1807DA9A0", Slot = "16")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06005687 RID: 22151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005687")]
		[Address(RVA = "0x7DA900", Offset = "0x7D9300", VA = "0x1807DA900", Slot = "13")]
		public void Enable()
		{
		}

		// Token: 0x06005688 RID: 22152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005688")]
		[Address(RVA = "0x7DA890", Offset = "0x7D9290", VA = "0x1807DA890", Slot = "14")]
		public void Disable()
		{
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06005689 RID: 22153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C1A")]
		public IEnumerable<InputBinding> bindings
		{
			[Token(Token = "0x6005689")]
			[Address(RVA = "0x7DAB30", Offset = "0x7D9530", VA = "0x1807DAB30", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600568A RID: 22154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600568A")]
		[Address(RVA = "0x7DA920", Offset = "0x7D9320", VA = "0x1807DA920", Slot = "5")]
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			return null;
		}

		// Token: 0x0600568B RID: 22155 RVA: 0x0001E948 File Offset: 0x0001CB48
		[Token(Token = "0x600568B")]
		[Address(RVA = "0x7DA940", Offset = "0x7D9340", VA = "0x1807DA940", Slot = "6")]
		public int FindBinding(InputBinding bindingMask, out InputAction action)
		{
			return 0;
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x0600568C RID: 22156 RVA: 0x0001E960 File Offset: 0x0001CB60
		[Token(Token = "0x17000C1B")]
		public FocusPointListener.PersistentActions Persistent
		{
			[Token(Token = "0x600568C")]
			[Address(RVA = "0x7DAAC0", Offset = "0x7D94C0", VA = "0x1807DAAC0")]
			get
			{
				return default(FocusPointListener.PersistentActions);
			}
		}

		// Token: 0x04005132 RID: 20786
		[Token(Token = "0x4005132")]
		[FieldOffset(Offset = "0x18")]
		private readonly InputActionMap m_Persistent;

		// Token: 0x04005133 RID: 20787
		[Token(Token = "0x4005133")]
		[FieldOffset(Offset = "0x20")]
		private FocusPointListener.IPersistentActions m_PersistentActionsCallbackInterface;

		// Token: 0x04005134 RID: 20788
		[Token(Token = "0x4005134")]
		[FieldOffset(Offset = "0x28")]
		private readonly InputAction m_Persistent_Move;

		// Token: 0x02000E75 RID: 3701
		[Token(Token = "0x2000E75")]
		public struct PersistentActions
		{
			// Token: 0x0600568D RID: 22157 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600568D")]
			[Address(RVA = "0x3EC190", Offset = "0x3EAB90", VA = "0x1803EC190")]
			public PersistentActions(FocusPointListener wrapper)
			{
			}

			// Token: 0x17000C1C RID: 3100
			// (get) Token: 0x0600568E RID: 22158 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000C1C")]
			public InputAction Move
			{
				[Token(Token = "0x600568E")]
				[Address(RVA = "0x7F92F0", Offset = "0x7F7CF0", VA = "0x1807F92F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600568F RID: 22159 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600568F")]
			[Address(RVA = "0x6658E0", Offset = "0x6642E0", VA = "0x1806658E0")]
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06005690 RID: 22160 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005690")]
			[Address(RVA = "0x7F88D0", Offset = "0x7F72D0", VA = "0x1807F88D0")]
			public void Enable()
			{
			}

			// Token: 0x06005691 RID: 22161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005691")]
			[Address(RVA = "0x7F88A0", Offset = "0x7F72A0", VA = "0x1807F88A0")]
			public void Disable()
			{
			}

			// Token: 0x17000C1D RID: 3101
			// (get) Token: 0x06005692 RID: 22162 RVA: 0x0001E978 File Offset: 0x0001CB78
			[Token(Token = "0x17000C1D")]
			public bool enabled
			{
				[Token(Token = "0x6005692")]
				[Address(RVA = "0x7F9330", Offset = "0x7F7D30", VA = "0x1807F9330")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06005693 RID: 22163 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005693")]
			[Address(RVA = "0x7F9360", Offset = "0x7F7D60", VA = "0x1807F9360")]
			public static implicit operator InputActionMap(FocusPointListener.PersistentActions set)
			{
				return null;
			}

			// Token: 0x06005694 RID: 22164 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005694")]
			[Address(RVA = "0x8579D0", Offset = "0x8563D0", VA = "0x1808579D0")]
			public void SetCallbacks(FocusPointListener.IPersistentActions instance)
			{
			}

			// Token: 0x04005135 RID: 20789
			[Token(Token = "0x4005135")]
			[FieldOffset(Offset = "0x0")]
			private FocusPointListener m_Wrapper;
		}

		// Token: 0x02000E76 RID: 3702
		[Token(Token = "0x2000E76")]
		public interface IPersistentActions
		{
			// Token: 0x06005695 RID: 22165
			[Token(Token = "0x6005695")]
			void OnMove(InputAction.CallbackContext context);
		}
	}
}

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace mk152.My
{
	// Token: 0x02000004 RID: 4
	[HideModuleName]
	[GeneratedCode("MyTemplate", "8.0.0.0")]
	[StandardModule]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0014A820 File Offset: 0x00148C20
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0014A83C File Offset: 0x00148C3C
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0014A858 File Offset: 0x00148C58
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0014A874 File Offset: 0x00148C74
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0014A890 File Offset: 0x00148C90
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000004 RID: 4
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000005 RID: 5
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000006 RID: 6
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000005 RID: 5
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyForms
		{
			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600000C RID: 12 RVA: 0x0014A8AC File Offset: 0x00148CAC
			// (set) Token: 0x0600000E RID: 14 RVA: 0x0014A8FC File Offset: 0x00148CFC
			public Univac1219 Univac1219
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_Univac1219 = MyProject.MyForms.Create__Instance__<Univac1219>(this.m_Univac1219);
					return this.m_Univac1219;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_Univac1219;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Univac1219>(ref this.m_Univac1219);
					}
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x0600000D RID: 13 RVA: 0x0014A8D4 File Offset: 0x00148CD4
			// (set) Token: 0x0600000F RID: 15 RVA: 0x0014A940 File Offset: 0x00148D40
			public UNIVAC1532 UNIVAC1532
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_UNIVAC1532 = MyProject.MyForms.Create__Instance__<UNIVAC1532>(this.m_UNIVAC1532);
					return this.m_UNIVAC1532;
				}
				[DebuggerNonUserCode]
				set
				{
					bool flag = value == this.m_UNIVAC1532;
					if (!flag)
					{
						flag = value != null;
						if (flag)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<UNIVAC1532>(ref this.m_UNIVAC1532);
					}
				}
			}

			// Token: 0x06000010 RID: 16 RVA: 0x0014A984 File Offset: 0x00148D84
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				bool flag = Instance == null || Instance.IsDisposed;
				if (flag)
				{
					bool flag2 = MyProject.MyForms.m_FormBeingCreated != null;
					if (flag2)
					{
						bool flag3 = MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T));
						if (flag3)
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return new T();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[] { ex.InnerException.Message });
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			// Token: 0x06000011 RID: 17 RVA: 0x0014AAC0 File Offset: 0x00148EC0
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x06000012 RID: 18 RVA: 0x0014AAEC File Offset: 0x00148EEC
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public MyForms()
			{
			}

			// Token: 0x06000013 RID: 19 RVA: 0x0014AAF8 File Offset: 0x00148EF8
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000014 RID: 20 RVA: 0x0014AB18 File Offset: 0x00148F18
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000015 RID: 21 RVA: 0x0014AB30 File Offset: 0x00148F30
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x06000016 RID: 22 RVA: 0x0014AB4C File Offset: 0x00148F4C
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x04000007 RID: 7
			public Univac1219 m_Univac1219;

			// Token: 0x04000008 RID: 8
			public UNIVAC1532 m_UNIVAC1532;

			// Token: 0x04000009 RID: 9
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;
		}

		// Token: 0x02000006 RID: 6
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class MyWebServices
		{
			// Token: 0x06000017 RID: 23 RVA: 0x0014AB64 File Offset: 0x00148F64
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000018 RID: 24 RVA: 0x0014AB84 File Offset: 0x00148F84
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000019 RID: 25 RVA: 0x0014AB9C File Offset: 0x00148F9C
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x0600001A RID: 26 RVA: 0x0014ABB8 File Offset: 0x00148FB8
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x0600001B RID: 27 RVA: 0x0014ABD0 File Offset: 0x00148FD0
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				bool flag = instance == null;
				T t;
				if (flag)
				{
					t = new T();
				}
				else
				{
					t = instance;
				}
				return t;
			}

			// Token: 0x0600001C RID: 28 RVA: 0x0014ABFC File Offset: 0x00148FFC
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x0600001D RID: 29 RVA: 0x0014AC1C File Offset: 0x0014901C
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000007 RID: 7
		[ComVisible(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600001E RID: 30 RVA: 0x0014AC28 File Offset: 0x00149028
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					bool flag = MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null;
					if (flag)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x0600001F RID: 31 RVA: 0x0014AC5C File Offset: 0x0014905C
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x0400000A RID: 10
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;
		}
	}
}

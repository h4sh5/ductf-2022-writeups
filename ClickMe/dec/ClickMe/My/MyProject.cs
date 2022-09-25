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

namespace ClickMe.My
{
	// Token: 0x02000004 RID: 4
	[StandardModule]
	[HideModuleName]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class MyProject
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020D2 File Offset: 0x000002D2
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
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000020DE File Offset: 0x000002DE
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
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000020EA File Offset: 0x000002EA
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
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000020F6 File Offset: 0x000002F6
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
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002102 File Offset: 0x00000302
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000002 RID: 2
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000003 RID: 3
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000004 RID: 4
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000005 RID: 5
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x02000007 RID: 7
		[EditorBrowsable(1)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			// Token: 0x06000032 RID: 50 RVA: 0x00002E54 File Offset: 0x00001054
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				if (Instance == null || Instance.IsDisposed)
				{
					if (MyProject.MyForms.m_FormBeingCreated != null)
					{
						if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
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
						return Activator.CreateInstance<T>();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", new string[]
						{
							ex.InnerException.Message
						}), ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			// Token: 0x06000033 RID: 51 RVA: 0x00002F58 File Offset: 0x00001158
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x06000034 RID: 52 RVA: 0x00002F6D File Offset: 0x0000116D
			[DebuggerHidden]
			[EditorBrowsable(1)]
			public MyForms()
			{
			}

			// Token: 0x06000035 RID: 53 RVA: 0x00002F75 File Offset: 0x00001175
			[EditorBrowsable(1)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x06000036 RID: 54 RVA: 0x00002F83 File Offset: 0x00001183
			[EditorBrowsable(1)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x06000037 RID: 55 RVA: 0x00002F8B File Offset: 0x0000118B
			[EditorBrowsable(1)]
			internal Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x06000038 RID: 56 RVA: 0x00002F97 File Offset: 0x00001197
			[EditorBrowsable(1)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000039 RID: 57 RVA: 0x00002F9F File Offset: 0x0000119F
			// (set) Token: 0x0600003A RID: 58 RVA: 0x00002FB8 File Offset: 0x000011B8
			public Form1 Form1
			{
				get
				{
					this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
					return this.m_Form1;
				}
				set
				{
					if (value != this.m_Form1)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Form1>(ref this.m_Form1);
					}
				}
			}

			// Token: 0x04000019 RID: 25
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			// Token: 0x0400001A RID: 26
			[EditorBrowsable(1)]
			public Form1 m_Form1;
		}

		// Token: 0x02000008 RID: 8
		[EditorBrowsable(1)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x0600003B RID: 59 RVA: 0x00002FDD File Offset: 0x000011DD
			[EditorBrowsable(1)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x0600003C RID: 60 RVA: 0x00002FEB File Offset: 0x000011EB
			[EditorBrowsable(1)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600003D RID: 61 RVA: 0x00002FF3 File Offset: 0x000011F3
			[EditorBrowsable(1)]
			[DebuggerHidden]
			internal Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x0600003E RID: 62 RVA: 0x00002FFF File Offset: 0x000011FF
			[EditorBrowsable(1)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x0600003F RID: 63 RVA: 0x00003008 File Offset: 0x00001208
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				T result;
				if (instance == null)
				{
					result = Activator.CreateInstance<T>();
				}
				else
				{
					result = instance;
				}
				return result;
			}

			// Token: 0x06000040 RID: 64 RVA: 0x00003028 File Offset: 0x00001228
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x06000041 RID: 65 RVA: 0x00003031 File Offset: 0x00001231
			[DebuggerHidden]
			[EditorBrowsable(1)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x02000009 RID: 9
		[EditorBrowsable(1)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000042 RID: 66 RVA: 0x00003039 File Offset: 0x00001239
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x06000043 RID: 67 RVA: 0x00003056 File Offset: 0x00001256
			[DebuggerHidden]
			[EditorBrowsable(1)]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x0400001B RID: 27
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;
		}
	}
}

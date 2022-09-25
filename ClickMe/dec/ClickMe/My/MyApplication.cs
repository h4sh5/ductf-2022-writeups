using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace ClickMe.My
{
	// Token: 0x02000002 RID: 2
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[EditorBrowsable(1)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002048 File Offset: 0x00000248
		[STAThread]
		[DebuggerHidden]
		[EditorBrowsable(2)]
		[MethodImpl(72)]
		internal static void Main(string[] Args)
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			MyProject.Application.Run(Args);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000205F File Offset: 0x0000025F
		[DebuggerStepThrough]
		public MyApplication() : base(0)
		{
			base.IsSingleInstance = false;
			base.EnableVisualStyles = true;
			base.SaveMySettingsOnExit = true;
			base.ShutdownStyle = 0;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002084 File Offset: 0x00000284
		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			base.MainForm = MyProject.Forms.Form1;
		}
	}
}

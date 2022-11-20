// Decompiled with JetBrains decompiler
// Type: ClubCompFS.My.MyApplication
// Assembly: ClubCompFS_10p0p6, Version=1.0.0.6, Culture=neutral, PublicKeyToken=null
// MVID: F1E583B2-A781-4EC4-B47C-BA3F451903AE
// Assembly location: E:\zz Personal_Doc\Personal\Cinzia\programmaLibertas_openNEW\ClubCompFS_10p0p6.exe

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ClubCompFS.My
{
    [GeneratedCode("MyTemplate", "10.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal class MyApplication : WindowsFormsApplicationBase
    {
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [DebuggerHidden]
        [STAThread]
        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        internal static void Main(string[] Args)
        {
            Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
            MyProject.Application.Run(Args);
        }

        [DebuggerStepThrough]
        public MyApplication()
          : base(AuthenticationMode.Windows)
        {
            this.IsSingleInstance = true;
            this.EnableVisualStyles = true;
            this.SaveMySettingsOnExit = true;
            this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
        }

        [DebuggerStepThrough]
        protected override void OnCreateMainForm() => this.MainForm = (Form)MyProject.Forms.MainForm;
    }
}

// Decompiled with JetBrains decompiler
// Type: ClubCompFS.My.MyProject
// Assembly: ClubCompFS_10p0p6, Version=1.0.0.6, Culture=neutral, PublicKeyToken=null
// MVID: F1E583B2-A781-4EC4-B47C-BA3F451903AE
// Assembly location: E:\zz Personal_Doc\Personal\Cinzia\programmaLibertas_openNEW\ClubCompFS_10p0p6.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
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

namespace ClubCompFS.My
{
    [StandardModule]
    [GeneratedCode("MyTemplate", "10.0.0.0")]
    [HideModuleName]
    internal sealed class MyProject
    {
        private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
        private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
        private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
        private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
        private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

        [HelpKeyword("My.Computer")]
        internal static MyComputer Computer
        {
            [DebuggerHidden]
            get => MyProject.m_ComputerObjectProvider.GetInstance;
        }

        [HelpKeyword("My.Application")]
        internal static MyApplication Application
        {
            [DebuggerHidden]
            get => MyProject.m_AppObjectProvider.GetInstance;
        }

        [HelpKeyword("My.User")]
        internal static User User
        {
            [DebuggerHidden]
            get => MyProject.m_UserObjectProvider.GetInstance;
        }

        [HelpKeyword("My.Forms")]
        internal static MyProject.MyForms Forms
        {
            [DebuggerHidden]
            get => MyProject.m_MyFormsObjectProvider.GetInstance;
        }

        [HelpKeyword("My.WebServices")]
        internal static MyProject.MyWebServices WebServices
        {
            [DebuggerHidden]
            get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
        internal sealed class MyForms
        {
            public CustDialog m_CustDialog;
            public CategoryDialog m_CategoryDialog;
            public InputJudgesDataDialog m_InputJudgesDataDialog;
            public DeductionsDialog m_DeductionsDialog;
            public NetworkStatusDialog m_NetworkStatusDialog;
            public ConfigurationDataDialog m_ConfigurationDataDialog;
            public JudgesSetupDialog m_JudgesSetupDialog;
            public ParticipantInputDialog m_ParticipantInputDialog;
            public IceResurfacingMealBreakDialog m_IceResurfacingMealBreakDialog;
            public HeadPageDialog m_HeadPageDialog;
            public MainForm m_MainForm;
            public PrinterForm m_PrinterForm;
            public PrinterMessageForm m_PrinterMessageForm;
            public IndTAEntriesForm m_IndTAEntriesForm;
            public ElementDBDisplayForm m_ElementDBDisplayForm;
            public StartListForm m_StartListForm;
            public DBForm m_DBForm;
            public JudgesDetailsForm m_JudgesDetailsForm;
            public ElementInputForm m_ElementInputForm;
            public ResultsForm m_ResultsForm;
            public WarmupGroupsForm m_WarmupGroupsForm;
            public JudgesCardForm m_JudgesCardForm;
            public ElementIncorrectForm m_ElementIncorrectForm;
            [ThreadStatic]
            private static Hashtable m_FormBeingCreated;

            public CustDialog CustDialog
            {
                get
                {
                    this.m_CustDialog = MyProject.MyForms.Create__Instance__<CustDialog>(this.m_CustDialog);
                    return this.m_CustDialog;
                }
                set
                {
                    if (value == this.m_CustDialog)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<CustDialog>(ref this.m_CustDialog);
                }
            }

            public CategoryDialog CategoryDialog
            {
                get
                {
                    this.m_CategoryDialog = MyProject.MyForms.Create__Instance__<CategoryDialog>(this.m_CategoryDialog);
                    return this.m_CategoryDialog;
                }
                set
                {
                    if (value == this.m_CategoryDialog)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<CategoryDialog>(ref this.m_CategoryDialog);
                }
            }

            public InputJudgesDataDialog InputJudgesDataDialog
            {
                get
                {
                    this.m_InputJudgesDataDialog = MyProject.MyForms.Create__Instance__<InputJudgesDataDialog>(this.m_InputJudgesDataDialog);
                    return this.m_InputJudgesDataDialog;
                }
                set
                {
                    if (value == this.m_InputJudgesDataDialog)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<InputJudgesDataDialog>(ref this.m_InputJudgesDataDialog);
                }
            }

            public DeductionsDialog DeductionsDialog
            {
                get
                {
                    this.m_DeductionsDialog = MyProject.MyForms.Create__Instance__<DeductionsDialog>(this.m_DeductionsDialog);
                    return this.m_DeductionsDialog;
                }
                set
                {
                    if (value == this.m_DeductionsDialog)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<DeductionsDialog>(ref this.m_DeductionsDialog);
                }
            }

            public NetworkStatusDialog NetworkStatusDialog
            {
                get
                {
                    this.m_NetworkStatusDialog = MyProject.MyForms.Create__Instance__<NetworkStatusDialog>(this.m_NetworkStatusDialog);
                    return this.m_NetworkStatusDialog;
                }
                set
                {
                    if (value == this.m_NetworkStatusDialog)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<NetworkStatusDialog>(ref this.m_NetworkStatusDialog);
                }
            }

            public ConfigurationDataDialog ConfigurationDataDialog
            {
                get
                {
                    this.m_ConfigurationDataDialog = MyProject.MyForms.Create__Instance__<ConfigurationDataDialog>(this.m_ConfigurationDataDialog);
                    return this.m_ConfigurationDataDialog;
                }
                set
                {
                    if (value == this.m_ConfigurationDataDialog)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<ConfigurationDataDialog>(ref this.m_ConfigurationDataDialog);
                }
            }

            public JudgesSetupDialog JudgesSetupDialog
            {
                get
                {
                    this.m_JudgesSetupDialog = MyProject.MyForms.Create__Instance__<JudgesSetupDialog>(this.m_JudgesSetupDialog);
                    return this.m_JudgesSetupDialog;
                }
                set
                {
                    if (value == this.m_JudgesSetupDialog)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<JudgesSetupDialog>(ref this.m_JudgesSetupDialog);
                }
            }

            public ParticipantInputDialog ParticipantInputDialog
            {
                get
                {
                    this.m_ParticipantInputDialog = MyProject.MyForms.Create__Instance__<ParticipantInputDialog>(this.m_ParticipantInputDialog);
                    return this.m_ParticipantInputDialog;
                }
                set
                {
                    if (value == this.m_ParticipantInputDialog)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<ParticipantInputDialog>(ref this.m_ParticipantInputDialog);
                }
            }

            public IceResurfacingMealBreakDialog IceResurfacingMealBreakDialog
            {
                get
                {
                    this.m_IceResurfacingMealBreakDialog = MyProject.MyForms.Create__Instance__<IceResurfacingMealBreakDialog>(this.m_IceResurfacingMealBreakDialog);
                    return this.m_IceResurfacingMealBreakDialog;
                }
                set
                {
                    if (value == this.m_IceResurfacingMealBreakDialog)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<IceResurfacingMealBreakDialog>(ref this.m_IceResurfacingMealBreakDialog);
                }
            }

            public HeadPageDialog HeadPageDialog
            {
                get
                {
                    this.m_HeadPageDialog = MyProject.MyForms.Create__Instance__<HeadPageDialog>(this.m_HeadPageDialog);
                    return this.m_HeadPageDialog;
                }
                set
                {
                    if (value == this.m_HeadPageDialog)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<HeadPageDialog>(ref this.m_HeadPageDialog);
                }
            }

            public MainForm MainForm
            {
                get
                {
                    this.m_MainForm = MyProject.MyForms.Create__Instance__<MainForm>(this.m_MainForm);
                    return this.m_MainForm;
                }
                set
                {
                    if (value == this.m_MainForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<MainForm>(ref this.m_MainForm);
                }
            }

            public PrinterForm PrinterForm
            {
                get
                {
                    this.m_PrinterForm = MyProject.MyForms.Create__Instance__<PrinterForm>(this.m_PrinterForm);
                    return this.m_PrinterForm;
                }
                set
                {
                    if (value == this.m_PrinterForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<PrinterForm>(ref this.m_PrinterForm);
                }
            }

            public PrinterMessageForm PrinterMessageForm
            {
                get
                {
                    this.m_PrinterMessageForm = MyProject.MyForms.Create__Instance__<PrinterMessageForm>(this.m_PrinterMessageForm);
                    return this.m_PrinterMessageForm;
                }
                set
                {
                    if (value == this.m_PrinterMessageForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<PrinterMessageForm>(ref this.m_PrinterMessageForm);
                }
            }

            public IndTAEntriesForm IndTAEntriesForm
            {
                get
                {
                    this.m_IndTAEntriesForm = MyProject.MyForms.Create__Instance__<IndTAEntriesForm>(this.m_IndTAEntriesForm);
                    return this.m_IndTAEntriesForm;
                }
                set
                {
                    if (value == this.m_IndTAEntriesForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<IndTAEntriesForm>(ref this.m_IndTAEntriesForm);
                }
            }

            public ElementDBDisplayForm ElementDBDisplayForm
            {
                get
                {
                    this.m_ElementDBDisplayForm = MyProject.MyForms.Create__Instance__<ElementDBDisplayForm>(this.m_ElementDBDisplayForm);
                    return this.m_ElementDBDisplayForm;
                }
                set
                {
                    if (value == this.m_ElementDBDisplayForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<ElementDBDisplayForm>(ref this.m_ElementDBDisplayForm);
                }
            }

            public StartListForm StartListForm
            {
                get
                {
                    this.m_StartListForm = MyProject.MyForms.Create__Instance__<StartListForm>(this.m_StartListForm);
                    return this.m_StartListForm;
                }
                set
                {
                    if (value == this.m_StartListForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<StartListForm>(ref this.m_StartListForm);
                }
            }

            public DBForm DBForm
            {
                get
                {
                    this.m_DBForm = MyProject.MyForms.Create__Instance__<DBForm>(this.m_DBForm);
                    return this.m_DBForm;
                }
                set
                {
                    if (value == this.m_DBForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<DBForm>(ref this.m_DBForm);
                }
            }

            public JudgesDetailsForm JudgesDetailsForm
            {
                get
                {
                    this.m_JudgesDetailsForm = MyProject.MyForms.Create__Instance__<JudgesDetailsForm>(this.m_JudgesDetailsForm);
                    return this.m_JudgesDetailsForm;
                }
                set
                {
                    if (value == this.m_JudgesDetailsForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<JudgesDetailsForm>(ref this.m_JudgesDetailsForm);
                }
            }

            public ElementInputForm ElementInputForm
            {
                get
                {
                    this.m_ElementInputForm = MyProject.MyForms.Create__Instance__<ElementInputForm>(this.m_ElementInputForm);
                    return this.m_ElementInputForm;
                }
                set
                {
                    if (value == this.m_ElementInputForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<ElementInputForm>(ref this.m_ElementInputForm);
                }
            }

            public ResultsForm ResultsForm
            {
                get
                {
                    this.m_ResultsForm = MyProject.MyForms.Create__Instance__<ResultsForm>(this.m_ResultsForm);
                    return this.m_ResultsForm;
                }
                set
                {
                    if (value == this.m_ResultsForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<ResultsForm>(ref this.m_ResultsForm);
                }
            }

            public WarmupGroupsForm WarmupGroupsForm
            {
                get
                {
                    this.m_WarmupGroupsForm = MyProject.MyForms.Create__Instance__<WarmupGroupsForm>(this.m_WarmupGroupsForm);
                    return this.m_WarmupGroupsForm;
                }
                set
                {
                    if (value == this.m_WarmupGroupsForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<WarmupGroupsForm>(ref this.m_WarmupGroupsForm);
                }
            }

            public JudgesCardForm JudgesCardForm
            {
                get
                {
                    this.m_JudgesCardForm = MyProject.MyForms.Create__Instance__<JudgesCardForm>(this.m_JudgesCardForm);
                    return this.m_JudgesCardForm;
                }
                set
                {
                    if (value == this.m_JudgesCardForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<JudgesCardForm>(ref this.m_JudgesCardForm);
                }
            }

            public ElementIncorrectForm ElementIncorrectForm
            {
                get
                {
                    this.m_ElementIncorrectForm = MyProject.MyForms.Create__Instance__<ElementIncorrectForm>(this.m_ElementIncorrectForm);
                    return this.m_ElementIncorrectForm;
                }
                set
                {
                    if (value == this.m_ElementIncorrectForm)
                        return;
                    if (value != null)
                        throw new ArgumentException("Property can only be set to Nothing");
                    this.Dispose__Instance__<ElementIncorrectForm>(ref this.m_ElementIncorrectForm);
                }
            }

            [DebuggerHidden]
            private static T Create__Instance__<T>(T Instance) where T : Form, new()
            {
                if ((object)Instance != null && !Instance.IsDisposed)
                    return Instance;
                if (MyProject.MyForms.m_FormBeingCreated != null)
                {
                    if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object)typeof(T)))
                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
                }
                else
                    MyProject.MyForms.m_FormBeingCreated = new Hashtable();
                MyProject.MyForms.m_FormBeingCreated.Add((object)typeof(T), (object)null);
                try
                {
                    return new T();
                }
                catch (TargetInvocationException ex)
                {
                    throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message), ex.InnerException);
                }
                finally
                {
                    MyProject.MyForms.m_FormBeingCreated.Remove((object)typeof(T));
                }
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance) where T : Form
            {
                instance.Dispose();
                instance = default(T);
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public MyForms()
            {
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode() => base.GetHashCode();

            [EditorBrowsable(EditorBrowsableState.Never)]
            internal new System.Type GetType() => typeof(MyProject.MyForms);

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString() => base.ToString();
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
        internal sealed class MyWebServices
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            [DebuggerHidden]
            public override bool Equals(object o) => base.Equals(RuntimeHelpers.GetObjectValue(o));

            [EditorBrowsable(EditorBrowsableState.Never)]
            [DebuggerHidden]
            public override int GetHashCode() => base.GetHashCode();

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            internal new System.Type GetType() => typeof(MyProject.MyWebServices);

            [EditorBrowsable(EditorBrowsableState.Never)]
            [DebuggerHidden]
            public override string ToString() => base.ToString();

            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance) where T : new() => (object)instance == null ? new T() : instance;

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance) => instance = default(T);

            [EditorBrowsable(EditorBrowsableState.Never)]
            [DebuggerHidden]
            public MyWebServices()
            {
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        [ComVisible(false)]
        internal sealed class ThreadSafeObjectProvider<T> where T : new()
        {
            private static T m_ThreadStaticValue;

            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    if ((object)MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
                        MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
                    return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
                }
            }

            [DebuggerHidden]
            [EditorBrowsable(EditorBrowsableState.Never)]
            public ThreadSafeObjectProvider()
            {
            }
        }
    }
}

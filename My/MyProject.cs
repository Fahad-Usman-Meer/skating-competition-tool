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
      [DebuggerHidden] get => MyProject.m_ComputerObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get => MyProject.m_AppObjectProvider.GetInstance;
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get => MyProject.m_UserObjectProvider.GetInstance;
    }

    [HelpKeyword("My.Forms")]
    internal static MyProject.MyForms Forms
    {
      [DebuggerHidden] get => MyProject.m_MyFormsObjectProvider.GetInstance;
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get => MyProject.m_MyWebServicesObjectProvider.GetInstance;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    internal sealed class MyForms
    {
      public CustDialog m_CustDialog;
      public CategoryDialog m_CategoryDialog;
      public Dialog10 m_Dialog10;
      public Dialog11 m_Dialog11;
      public Dialog2 m_Dialog2;
      public Dialog3 m_Dialog3;
      public Dialog4 m_Dialog4;
      public Dialog5 m_Dialog5;
      public Dialog7 m_Dialog7;
      public Dialog8 m_Dialog8;
      public Form1 m_Form1;
      public Form10 m_Form10;
      public Form11 m_Form11;
      public Form12 m_Form12;
      public Form13 m_Form13;
      public Form2 m_Form2;
      public Form3 m_Form3;
      public Form4 m_Form4;
      public Form5 m_Form5;
      public Form6 m_Form6;
      public Form7 m_Form7;
      public Form8 m_Form8;
      public Form9 m_Form9;
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

      public Dialog10 Dialog10
      {
        get
        {
          this.m_Dialog10 = MyProject.MyForms.Create__Instance__<Dialog10>(this.m_Dialog10);
          return this.m_Dialog10;
        }
        set
        {
          if (value == this.m_Dialog10)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Dialog10>(ref this.m_Dialog10);
        }
      }

      public Dialog11 Dialog11
      {
        get
        {
          this.m_Dialog11 = MyProject.MyForms.Create__Instance__<Dialog11>(this.m_Dialog11);
          return this.m_Dialog11;
        }
        set
        {
          if (value == this.m_Dialog11)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Dialog11>(ref this.m_Dialog11);
        }
      }

      public Dialog2 Dialog2
      {
        get
        {
          this.m_Dialog2 = MyProject.MyForms.Create__Instance__<Dialog2>(this.m_Dialog2);
          return this.m_Dialog2;
        }
        set
        {
          if (value == this.m_Dialog2)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Dialog2>(ref this.m_Dialog2);
        }
      }

      public Dialog3 Dialog3
      {
        get
        {
          this.m_Dialog3 = MyProject.MyForms.Create__Instance__<Dialog3>(this.m_Dialog3);
          return this.m_Dialog3;
        }
        set
        {
          if (value == this.m_Dialog3)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Dialog3>(ref this.m_Dialog3);
        }
      }

      public Dialog4 Dialog4
      {
        get
        {
          this.m_Dialog4 = MyProject.MyForms.Create__Instance__<Dialog4>(this.m_Dialog4);
          return this.m_Dialog4;
        }
        set
        {
          if (value == this.m_Dialog4)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Dialog4>(ref this.m_Dialog4);
        }
      }

      public Dialog5 Dialog5
      {
        get
        {
          this.m_Dialog5 = MyProject.MyForms.Create__Instance__<Dialog5>(this.m_Dialog5);
          return this.m_Dialog5;
        }
        set
        {
          if (value == this.m_Dialog5)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Dialog5>(ref this.m_Dialog5);
        }
      }

      public Dialog7 Dialog7
      {
        get
        {
          this.m_Dialog7 = MyProject.MyForms.Create__Instance__<Dialog7>(this.m_Dialog7);
          return this.m_Dialog7;
        }
        set
        {
          if (value == this.m_Dialog7)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Dialog7>(ref this.m_Dialog7);
        }
      }

      public Dialog8 Dialog8
      {
        get
        {
          this.m_Dialog8 = MyProject.MyForms.Create__Instance__<Dialog8>(this.m_Dialog8);
          return this.m_Dialog8;
        }
        set
        {
          if (value == this.m_Dialog8)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Dialog8>(ref this.m_Dialog8);
        }
      }

      public Form1 Form1
      {
        get
        {
          this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
          return this.m_Form1;
        }
        set
        {
          if (value == this.m_Form1)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form1>(ref this.m_Form1);
        }
      }

      public Form10 Form10
      {
        get
        {
          this.m_Form10 = MyProject.MyForms.Create__Instance__<Form10>(this.m_Form10);
          return this.m_Form10;
        }
        set
        {
          if (value == this.m_Form10)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form10>(ref this.m_Form10);
        }
      }

      public Form11 Form11
      {
        get
        {
          this.m_Form11 = MyProject.MyForms.Create__Instance__<Form11>(this.m_Form11);
          return this.m_Form11;
        }
        set
        {
          if (value == this.m_Form11)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form11>(ref this.m_Form11);
        }
      }

      public Form12 Form12
      {
        get
        {
          this.m_Form12 = MyProject.MyForms.Create__Instance__<Form12>(this.m_Form12);
          return this.m_Form12;
        }
        set
        {
          if (value == this.m_Form12)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form12>(ref this.m_Form12);
        }
      }

      public Form13 Form13
      {
        get
        {
          this.m_Form13 = MyProject.MyForms.Create__Instance__<Form13>(this.m_Form13);
          return this.m_Form13;
        }
        set
        {
          if (value == this.m_Form13)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form13>(ref this.m_Form13);
        }
      }

      public Form2 Form2
      {
        get
        {
          this.m_Form2 = MyProject.MyForms.Create__Instance__<Form2>(this.m_Form2);
          return this.m_Form2;
        }
        set
        {
          if (value == this.m_Form2)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form2>(ref this.m_Form2);
        }
      }

      public Form3 Form3
      {
        get
        {
          this.m_Form3 = MyProject.MyForms.Create__Instance__<Form3>(this.m_Form3);
          return this.m_Form3;
        }
        set
        {
          if (value == this.m_Form3)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form3>(ref this.m_Form3);
        }
      }

      public Form4 Form4
      {
        get
        {
          this.m_Form4 = MyProject.MyForms.Create__Instance__<Form4>(this.m_Form4);
          return this.m_Form4;
        }
        set
        {
          if (value == this.m_Form4)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form4>(ref this.m_Form4);
        }
      }

      public Form5 Form5
      {
        get
        {
          this.m_Form5 = MyProject.MyForms.Create__Instance__<Form5>(this.m_Form5);
          return this.m_Form5;
        }
        set
        {
          if (value == this.m_Form5)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form5>(ref this.m_Form5);
        }
      }

      public Form6 Form6
      {
        get
        {
          this.m_Form6 = MyProject.MyForms.Create__Instance__<Form6>(this.m_Form6);
          return this.m_Form6;
        }
        set
        {
          if (value == this.m_Form6)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form6>(ref this.m_Form6);
        }
      }

      public Form7 Form7
      {
        get
        {
          this.m_Form7 = MyProject.MyForms.Create__Instance__<Form7>(this.m_Form7);
          return this.m_Form7;
        }
        set
        {
          if (value == this.m_Form7)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form7>(ref this.m_Form7);
        }
      }

      public Form8 Form8
      {
        get
        {
          this.m_Form8 = MyProject.MyForms.Create__Instance__<Form8>(this.m_Form8);
          return this.m_Form8;
        }
        set
        {
          if (value == this.m_Form8)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form8>(ref this.m_Form8);
        }
      }

      public Form9 Form9
      {
        get
        {
          this.m_Form9 = MyProject.MyForms.Create__Instance__<Form9>(this.m_Form9);
          return this.m_Form9;
        }
        set
        {
          if (value == this.m_Form9)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Form9>(ref this.m_Form9);
        }
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Form, new()
      {
        if ((object) Instance != null && !Instance.IsDisposed)
          return Instance;
        if (MyProject.MyForms.m_FormBeingCreated != null)
        {
          if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
        }
        else
          MyProject.MyForms.m_FormBeingCreated = new Hashtable();
        MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
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
          MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
        }
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Form
      {
        instance.Dispose();
        instance = default (T);
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
      internal new System.Type GetType() => typeof (MyProject.MyForms);

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
      internal new System.Type GetType() => typeof (MyProject.MyWebServices);

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override string ToString() => base.ToString();

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new() => (object) instance == null ? new T() : instance;

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) => instance = default (T);

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
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
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

// Decompiled with JetBrains decompiler
// Type: ClubCompFS.Form9
// Assembly: ClubCompFS_10p0p6, Version=1.0.0.6, Culture=neutral, PublicKeyToken=null
// MVID: F1E583B2-A781-4EC4-B47C-BA3F451903AE
// Assembly location: E:\zz Personal_Doc\Personal\Cinzia\programmaLibertas_openNEW\ClubCompFS_10p0p6.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ClubCompFS
{
  [DesignerGenerated]
  public class Form9 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("txtEL")]
    private TextBox _txtEL;
    [AccessedThroughProperty("Button1")]
    private Button _Button1;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;

    public Form9()
    {
      this.Load += new EventHandler(this.Form9_Load);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.txtEL = new TextBox();
      this.Button1 = new Button();
      this.Label1 = new Label();
      this.SuspendLayout();
      this.txtEL.Location = new Point(450, 12);
      this.txtEL.Name = "txtEL";
      TextBox txtEl = this.txtEL;
      Size size1 = new Size(64, 20);
      Size size2 = size1;
      txtEl.Size = size2;
      this.txtEL.TabIndex = 0;
      this.txtEL.Visible = false;
      this.Button1.Location = new Point(191, 88);
      this.Button1.Name = "Button1";
      Button button1 = this.Button1;
      size1 = new Size(110, 36);
      Size size3 = size1;
      button1.Size = size3;
      this.Button1.TabIndex = 2;
      this.Button1.Text = "OK";
      this.Button1.UseVisualStyleBackColor = true;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(68, 30);
      this.Label1.Name = "Label1";
      Label label1 = this.Label1;
      size1 = new Size(57, 20);
      Size size4 = size1;
      label1.Size = size4;
      this.Label1.TabIndex = 3;
      this.Label1.Text = "Label1";
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      size1 = new Size(526, 145);
      this.ClientSize = size1;
      this.ControlBox = false;
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.txtEL);
      this.Name = nameof (Form9);
      this.StartPosition = FormStartPosition.Manual;
      this.Text = nameof (Form9);
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TextBox txtEL
    {
      get => this._txtEL;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtEL = value;
    }

    internal virtual Button Button1
    {
      get => this._Button1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        if (this._Button1 != null)
          this._Button1.Click -= eventHandler;
        this._Button1 = value;
        if (this._Button1 == null)
          return;
        this._Button1.Click += eventHandler;
      }
    }

    internal virtual Label Label1
    {
      get => this._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    private void Form9_Load(object sender, EventArgs e)
    {
      this.Top = -1;
      this.Left = checked (Screen.PrimaryScreen.WorkingArea.Width - this.Width);
      this.Top = checked (Screen.PrimaryScreen.WorkingArea.Height - this.Height);
      this.Label1.Text = "The Element '" + this.txtEL.Text + "' is not correct!";
    }

    private void Button1_Click(object sender, EventArgs e) => this.Close();
  }
}

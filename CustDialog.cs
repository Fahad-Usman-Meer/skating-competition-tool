// Decompiled with JetBrains decompiler
// Type: ClubCompFS.CustDialog
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
  public class CustDialog : Form
  {
    private IContainer components;
    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;
    [AccessedThroughProperty("OK_Button")]
    private Button _OK_Button;
    [AccessedThroughProperty("Cancel_Button")]
    private Button _Cancel_Button;
    [AccessedThroughProperty("txtInput")]
    private TextBox _txtInput;
    [AccessedThroughProperty("lblTxt")]
    private Label _lblTxt;
    private string intxt;

    public CustDialog() => this.InitializeComponent();

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
      this.TableLayoutPanel1 = new TableLayoutPanel();
      this.OK_Button = new Button();
      this.Cancel_Button = new Button();
      this.txtInput = new TextBox();
      this.lblTxt = new Label();
      this.TableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.TableLayoutPanel1.ColumnCount = 2;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel1.Controls.Add((Control) this.OK_Button, 0, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.Cancel_Button, 1, 0);
      this.TableLayoutPanel1.Location = new Point(140, 69);
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 1;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
      TableLayoutPanel tableLayoutPanel1 = this.TableLayoutPanel1;
      Size size1 = new Size(146, 29);
      Size size2 = size1;
      tableLayoutPanel1.Size = size2;
      this.TableLayoutPanel1.TabIndex = 0;
      this.OK_Button.Anchor = AnchorStyles.None;
      this.OK_Button.Location = new Point(3, 3);
      this.OK_Button.Name = "OK_Button";
      Button okButton = this.OK_Button;
      size1 = new Size(67, 23);
      Size size3 = size1;
      okButton.Size = size3;
      this.OK_Button.TabIndex = 0;
      this.OK_Button.Text = "OK";
      this.Cancel_Button.Anchor = AnchorStyles.None;
      this.Cancel_Button.DialogResult = DialogResult.Cancel;
      this.Cancel_Button.Location = new Point(76, 3);
      this.Cancel_Button.Name = "Cancel_Button";
      Button cancelButton = this.Cancel_Button;
      size1 = new Size(67, 23);
      Size size4 = size1;
      cancelButton.Size = size4;
      this.Cancel_Button.TabIndex = 1;
      this.Cancel_Button.Text = "Cancel";
      this.txtInput.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtInput.Location = new Point(3, 38);
      this.txtInput.Name = "txtInput";
      TextBox txtInput = this.txtInput;
      size1 = new Size(420, 22);
      Size size5 = size1;
      txtInput.Size = size5;
      this.txtInput.TabIndex = 1;
      this.lblTxt.AutoSize = true;
      this.lblTxt.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.lblTxt.Location = new Point(0, 9);
      this.lblTxt.Name = "lblTxt";
      Label lblTxt = this.lblTxt;
      size1 = new Size(248, 16);
      Size size6 = size1;
      lblTxt.Size = size6;
      this.lblTxt.TabIndex = 2;
      this.lblTxt.Text = "Edit the element with the keyboard!";
      this.AcceptButton = (IButtonControl) this.OK_Button;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.CancelButton = (IButtonControl) this.Cancel_Button;
      size1 = new Size(429, 110);
      this.ClientSize = size1;
      this.ControlBox = false;
      this.Controls.Add((Control) this.lblTxt);
      this.Controls.Add((Control) this.txtInput);
      this.Controls.Add((Control) this.TableLayoutPanel1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (CustDialog);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "SuSanne Software";
      this.TopMost = true;
      this.TableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual TableLayoutPanel TableLayoutPanel1
    {
      get => this._TableLayoutPanel1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._TableLayoutPanel1 = value;
    }

    internal virtual Button OK_Button
    {
      get => this._OK_Button;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.OK_Button_Click);
        if (this._OK_Button != null)
          this._OK_Button.Click -= eventHandler;
        this._OK_Button = value;
        if (this._OK_Button == null)
          return;
        this._OK_Button.Click += eventHandler;
      }
    }

    internal virtual Button Cancel_Button
    {
      get => this._Cancel_Button;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Cancel_Button_Click);
        if (this._Cancel_Button != null)
          this._Cancel_Button.Click -= eventHandler;
        this._Cancel_Button = value;
        if (this._Cancel_Button == null)
          return;
        this._Cancel_Button.Click += eventHandler;
      }
    }

    internal virtual TextBox txtInput
    {
      get => this._txtInput;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtInput_KeyPress);
        if (this._txtInput != null)
          this._txtInput.KeyPress -= pressEventHandler;
        this._txtInput = value;
        if (this._txtInput == null)
          return;
        this._txtInput.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label lblTxt
    {
      get => this._lblTxt;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._lblTxt = value;
    }

    private void OK_Button_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
      this.txtInput.Text = this.intxt;
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '"':
        case '&':
        case '\'':
        case ':':
        case ';':
        case '>':
          e.Handled = true;
          break;
      }
    }
  }
}

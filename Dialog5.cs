﻿// Decompiled with JetBrains decompiler
// Type: ClubCompFS.Dialog5
// Assembly: ClubCompFS_10p0p6, Version=1.0.0.6, Culture=neutral, PublicKeyToken=null
// MVID: F1E583B2-A781-4EC4-B47C-BA3F451903AE
// Assembly location: E:\zz Personal_Doc\Personal\Cinzia\programmaLibertas_openNEW\ClubCompFS_10p0p6.exe

using ClubCompFS.My;
using Microsoft.VisualBasic;
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
  public class Dialog5 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;
    [AccessedThroughProperty("OK_Button")]
    private Button _OK_Button;
    [AccessedThroughProperty("Cancel_Button")]
    private Button _Cancel_Button;
    [AccessedThroughProperty("txtStartNo")]
    private TextBox _txtStartNo;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("txtFirstName")]
    private TextBox _txtFirstName;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("txtSurname")]
    private TextBox _txtSurname;
    [AccessedThroughProperty("Label4")]
    private Label _Label4;
    [AccessedThroughProperty("txtClub")]
    private TextBox _txtClub;
    [AccessedThroughProperty("txtIndForm2")]
    private TextBox _txtIndForm2;
    [AccessedThroughProperty("txtFuncForm2")]
    private TextBox _txtFuncForm2;
    [AccessedThroughProperty("TxtClubID")]
    private TextBox _TxtClubID;
    [AccessedThroughProperty("Label5")]
    private Label _Label5;
    [AccessedThroughProperty("txtID")]
    private TextBox _txtID;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;

    public Dialog5()
    {
      this.Load += new EventHandler(this.Dialog5_Load);
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Dialog5));
      this.TableLayoutPanel1 = new TableLayoutPanel();
      this.OK_Button = new Button();
      this.Cancel_Button = new Button();
      this.txtStartNo = new TextBox();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.txtFirstName = new TextBox();
      this.Label3 = new Label();
      this.txtSurname = new TextBox();
      this.Label4 = new Label();
      this.txtClub = new TextBox();
      this.txtIndForm2 = new TextBox();
      this.txtFuncForm2 = new TextBox();
      this.TxtClubID = new TextBox();
      this.Label5 = new Label();
      this.txtID = new TextBox();
      this.Label6 = new Label();
      this.TableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.TableLayoutPanel1.BackColor = Color.White;
      this.TableLayoutPanel1.ColumnCount = 2;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel1.Controls.Add((Control) this.OK_Button, 0, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.Cancel_Button, 1, 0);
      this.TableLayoutPanel1.Location = new Point(88, 216);
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
      this.txtStartNo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtStartNo.Location = new Point(12, 26);
      this.txtStartNo.Name = "txtStartNo";
      TextBox txtStartNo = this.txtStartNo;
      size1 = new Size(71, 20);
      Size size5 = size1;
      txtStartNo.Size = size5;
      this.txtStartNo.TabIndex = 5;
      this.txtStartNo.TextAlign = HorizontalAlignment.Center;
      this.Label1.AutoSize = true;
      this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(9, 11);
      this.Label1.Name = "Label1";
      Label label1 = this.Label1;
      size1 = new Size(81, 13);
      Size size6 = size1;
      label1.Size = size6;
      this.Label1.TabIndex = 2;
      this.Label1.Text = "Start Number";
      this.Label2.AutoSize = true;
      this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(9, 49);
      this.Label2.Name = "Label2";
      Label label2 = this.Label2;
      size1 = new Size(67, 13);
      Size size7 = size1;
      label2.Size = size7;
      this.Label2.TabIndex = 4;
      this.Label2.Text = "First Name";
      this.txtFirstName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtFirstName.Location = new Point(12, 64);
      this.txtFirstName.Name = "txtFirstName";
      TextBox txtFirstName = this.txtFirstName;
      size1 = new Size(298, 20);
      Size size8 = size1;
      txtFirstName.Size = size8;
      this.txtFirstName.TabIndex = 1;
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(9, 87);
      this.Label3.Name = "Label3";
      Label label3 = this.Label3;
      size1 = new Size(56, 13);
      Size size9 = size1;
      label3.Size = size9;
      this.Label3.TabIndex = 6;
      this.Label3.Text = "Surname";
      this.txtSurname.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtSurname.Location = new Point(12, 102);
      this.txtSurname.Name = "txtSurname";
      TextBox txtSurname = this.txtSurname;
      size1 = new Size(298, 20);
      Size size10 = size1;
      txtSurname.Size = size10;
      this.txtSurname.TabIndex = 2;
      this.Label4.AutoSize = true;
      this.Label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.Location = new Point(9, 125);
      this.Label4.Name = "Label4";
      Label label4 = this.Label4;
      size1 = new Size(32, 13);
      Size size11 = size1;
      label4.Size = size11;
      this.Label4.TabIndex = 8;
      this.Label4.Text = "Club";
      this.txtClub.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtClub.Location = new Point(12, 140);
      this.txtClub.Name = "txtClub";
      TextBox txtClub = this.txtClub;
      size1 = new Size(298, 20);
      Size size12 = size1;
      txtClub.Size = size12;
      this.txtClub.TabIndex = 3;
      this.txtIndForm2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtIndForm2.Location = new Point(157, 179);
      this.txtIndForm2.Name = "txtIndForm2";
      TextBox txtIndForm2 = this.txtIndForm2;
      size1 = new Size(71, 20);
      Size size13 = size1;
      txtIndForm2.Size = size13;
      this.txtIndForm2.TabIndex = 9;
      this.txtIndForm2.Visible = false;
      this.txtFuncForm2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtFuncForm2.Location = new Point(239, 179);
      this.txtFuncForm2.Name = "txtFuncForm2";
      TextBox txtFuncForm2 = this.txtFuncForm2;
      size1 = new Size(71, 20);
      Size size14 = size1;
      txtFuncForm2.Size = size14;
      this.txtFuncForm2.TabIndex = 10;
      this.txtFuncForm2.Visible = false;
      this.TxtClubID.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.TxtClubID.Location = new Point(12, 179);
      this.TxtClubID.Name = "TxtClubID";
      TextBox txtClubId = this.TxtClubID;
      size1 = new Size(108, 20);
      Size size15 = size1;
      txtClubId.Size = size15;
      this.TxtClubID.TabIndex = 20;
      this.Label5.AutoSize = true;
      this.Label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.Location = new Point(9, 164);
      this.Label5.Name = "Label5";
      Label label5 = this.Label5;
      size1 = new Size(49, 13);
      Size size16 = size1;
      label5.Size = size16;
      this.Label5.TabIndex = 21;
      this.Label5.Text = "Club ID";
      this.txtID.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtID.Location = new Point(157, 26);
      this.txtID.Name = "txtID";
      TextBox txtId = this.txtID;
      size1 = new Size(153, 20);
      Size size17 = size1;
      txtId.Size = size17;
      this.txtID.TabIndex = 22;
      this.Label6.AutoSize = true;
      this.Label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.Location = new Point(154, 11);
      this.Label6.Name = "Label6";
      Label label6 = this.Label6;
      size1 = new Size(85, 13);
      Size size18 = size1;
      label6.Size = size18;
      this.Label6.TabIndex = 23;
      this.Label6.Text = "Participant ID";
      this.AcceptButton = (IButtonControl) this.OK_Button;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.CancelButton = (IButtonControl) this.Cancel_Button;
      size1 = new Size(325, 257);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.txtID);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.TxtClubID);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.txtFuncForm2);
      this.Controls.Add((Control) this.txtIndForm2);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.txtClub);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.txtSurname);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.txtFirstName);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.txtStartNo);
      this.Controls.Add((Control) this.TableLayoutPanel1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Dialog5);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Participant Input";
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

    internal virtual TextBox txtStartNo
    {
      get => this._txtStartNo;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtStartNo_KeyPress);
        if (this._txtStartNo != null)
          this._txtStartNo.KeyPress -= pressEventHandler;
        this._txtStartNo = value;
        if (this._txtStartNo == null)
          return;
        this._txtStartNo.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label1
    {
      get => this._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual Label Label2
    {
      get => this._Label2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label2 = value;
    }

    internal virtual TextBox txtFirstName
    {
      get => this._txtFirstName;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtFirstName_KeyPress);
        if (this._txtFirstName != null)
          this._txtFirstName.KeyPress -= pressEventHandler;
        this._txtFirstName = value;
        if (this._txtFirstName == null)
          return;
        this._txtFirstName.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label3
    {
      get => this._Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal virtual TextBox txtSurname
    {
      get => this._txtSurname;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtSurname_KeyPress);
        if (this._txtSurname != null)
          this._txtSurname.KeyPress -= pressEventHandler;
        this._txtSurname = value;
        if (this._txtSurname == null)
          return;
        this._txtSurname.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label4
    {
      get => this._Label4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label4 = value;
    }

    internal virtual TextBox txtClub
    {
      get => this._txtClub;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtClub_KeyPress);
        if (this._txtClub != null)
          this._txtClub.KeyPress -= pressEventHandler;
        this._txtClub = value;
        if (this._txtClub == null)
          return;
        this._txtClub.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox txtIndForm2
    {
      get => this._txtIndForm2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtIndForm2 = value;
    }

    internal virtual TextBox txtFuncForm2
    {
      get => this._txtFuncForm2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtFuncForm2 = value;
    }

    internal virtual TextBox TxtClubID
    {
      get => this._TxtClubID;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.TxtClubID_KeyPress);
        if (this._TxtClubID != null)
          this._TxtClubID.KeyPress -= pressEventHandler;
        this._TxtClubID = value;
        if (this._TxtClubID == null)
          return;
        this._TxtClubID.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label5
    {
      get => this._Label5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label5 = value;
    }

    internal virtual TextBox txtID
    {
      get => this._txtID;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtID_KeyPress);
        if (this._txtID != null)
          this._txtID.KeyPress -= pressEventHandler;
        this._txtID = value;
        if (this._txtID == null)
          return;
        this._txtID.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label6
    {
      get => this._Label6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
    }

    private void OK_Button_Click(object sender, EventArgs e)
    {
      int num1 = 0;
      int num2 = 0;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        int integer = Conversions.ToInteger(this.txtIndForm2.Text);
        if (Strings.Len(Strings.Trim(this.txtFirstName.Text)) > 0)
        {
          DataGridView dataGridView1 = MyProject.Forms.Form2.DataGridView1;
          string segment = Module1.Segment;
          if (Operators.CompareString(segment, "Seg1", false) == 0)
            Module1.Vek[checked (integer + 1)].Startno_Seg1 = Strings.Len(this.txtStartNo.Text) <= 0 ? 0 : Conversions.ToInteger(this.txtStartNo.Text);
          else if (Operators.CompareString(segment, "Seg2", false) == 0)
            Module1.Vek[checked (integer + 1)].Startno_Seg2 = Strings.Len(this.txtStartNo.Text) <= 0 ? 0 : Conversions.ToInteger(this.txtStartNo.Text);
          Module1.Vek[checked (integer + 1)].Name.FName = this.txtFirstName.Text;
          Module1.Vek[checked (integer + 1)].Name.LName = this.txtSurname.Text;
          Module1.Vek[checked (integer + 1)].Name.ID = this.txtID.Text;
          Module1.Vek[checked (integer + 1)].Club = this.txtClub.Text;
          Module1.Vek[checked (integer + 1)].ClubID = this.TxtClubID.Text;
          string text = this.txtFuncForm2.Text;
          if (Operators.CompareString(text, "New", false) == 0)
            checked { ++Module1.TNop; }
          else if (Operators.CompareString(text, "Edit", false) == 0)
            Module1.TNop = Module1.TNop;
          this.DialogResult = DialogResult.OK;
          this.Close();
          MyProject.Forms.Form2.TopMost = true;
          MyProject.Forms.Form2.CreateStartList(Module1.TNop);
          if (Module1.WorkMode == 1)
          {
            Module1.SaveCategoryFile(Module1.CategoryFileName);
            goto label_18;
          }
          else
            goto label_18;
        }
        else
        {
          int num3 = (int) Interaction.MsgBox((object) ("First name is missing!" + Information.Err().Description), MsgBoxStyle.SystemModal, (object) "Susanne SW");
          goto label_18;
        }
      }
      catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
      }
      num2 = -1;
      if (num1 == 2)
      {
        int num4 = (int) Interaction.MsgBox((object) ("Dialog 5, OK_Button_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object) "Susanne SW");
      }
label_18:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
      MyProject.Forms.Form2.TopMost = true;
    }

    private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '"':
        case '&':
        case '\'':
        case ':':
        case ';':
        case '<':
        case '>':
          e.Handled = true;
          break;
      }
    }

    private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '"':
        case '&':
        case '\'':
        case ':':
        case ';':
        case '<':
        case '>':
          e.Handled = true;
          break;
      }
    }

    private void txtStartNo_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
        return;
      e.KeyChar = char.MinValue;
    }

    private void txtClub_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '"':
        case '&':
        case '\'':
        case ':':
        case ';':
        case '<':
        case '>':
          e.Handled = true;
          break;
      }
    }

    private void Dialog5_Load(object sender, EventArgs e)
    {
      this.Top = MyProject.Forms.Form2.Top;
      this.Left = checked ((int) Math.Round(unchecked ((double) MyProject.Forms.Form2.Left + (double) MyProject.Forms.Form2.Width / 2.0 - (double) this.Width / 2.0)));
      this.TopMost = true;
    }

    private void txtID_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
        return;
      e.KeyChar = char.MinValue;
    }

    private void TxtClubID_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
        return;
      e.KeyChar = char.MinValue;
    }
  }
}

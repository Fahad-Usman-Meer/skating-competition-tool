// Decompiled with JetBrains decompiler
// Type: ClubCompFS.Dialog4
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
  public class Dialog4 : Form
  {
    private IContainer components;
    [AccessedThroughProperty("TableLayoutPanel1")]
    private TableLayoutPanel _TableLayoutPanel1;
    [AccessedThroughProperty("OK_Button")]
    private Button _OK_Button;
    [AccessedThroughProperty("Cancel_Button")]
    private Button _Cancel_Button;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("txtJ_func1")]
    private TextBox _txtJ_func1;
    [AccessedThroughProperty("txtCno1")]
    private TextBox _txtCno1;
    [AccessedThroughProperty("btnJ1")]
    private Button _btnJ1;
    [AccessedThroughProperty("btnJ2")]
    private Button _btnJ2;
    [AccessedThroughProperty("btnJ3")]
    private Button _btnJ3;
    [AccessedThroughProperty("btnJ4")]
    private Button _btnJ4;
    [AccessedThroughProperty("btnJ5")]
    private Button _btnJ5;
    [AccessedThroughProperty("btnJ6")]
    private Button _btnJ6;
    [AccessedThroughProperty("btnJ7")]
    private Button _btnJ7;
    [AccessedThroughProperty("txtCno3")]
    private TextBox _txtCno3;
    [AccessedThroughProperty("txtCno4")]
    private TextBox _txtCno4;
    [AccessedThroughProperty("txtCno5")]
    private TextBox _txtCno5;
    [AccessedThroughProperty("txtCno6")]
    private TextBox _txtCno6;
    [AccessedThroughProperty("txtCno7")]
    private TextBox _txtCno7;
    [AccessedThroughProperty("txtCno2")]
    private TextBox _txtCno2;
    [AccessedThroughProperty("txtJ_func4")]
    private TextBox _txtJ_func4;
    [AccessedThroughProperty("txtJ_func5")]
    private TextBox _txtJ_func5;
    [AccessedThroughProperty("txtJ_func6")]
    private TextBox _txtJ_func6;
    [AccessedThroughProperty("txtJ_func7")]
    private TextBox _txtJ_func7;
    [AccessedThroughProperty("txtJ_func3")]
    private TextBox _txtJ_func3;
    [AccessedThroughProperty("txtJ_func2")]
    private TextBox _txtJ_func2;
    [AccessedThroughProperty("txtNonJudgingRefree")]
    private TextBox _txtNonJudgingRefree;
    [AccessedThroughProperty("txtTrialJudge")]
    private TextBox _txtTrialJudge;
    [AccessedThroughProperty("txtJudge")]
    private TextBox _txtJudge;
    [AccessedThroughProperty("NumericUpDown2")]
    private NumericUpDown _NumericUpDown2;
    [AccessedThroughProperty("NumericUpDown1")]
    private NumericUpDown _NumericUpDown1;
    [AccessedThroughProperty("btnNonJudgingReferee")]
    private Button _btnNonJudgingReferee;
    [AccessedThroughProperty("Label6")]
    private Label _Label6;
    private int NoJ_Ca;
    private int NoTrj_Ca;
    private int JudgeSel_Ca;
    private int btnON;
    private bool MeLoad;

    public Dialog4()
    {
      this.Load += new EventHandler(this.Dialog4_Load);
      this.btnON = 1;
      this.MeLoad = true;
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
      this.TableLayoutPanel1 = new TableLayoutPanel();
      this.OK_Button = new Button();
      this.Cancel_Button = new Button();
      this.Label1 = new Label();
      this.Label3 = new Label();
      this.txtJ_func1 = new TextBox();
      this.txtCno1 = new TextBox();
      this.btnJ1 = new Button();
      this.btnJ2 = new Button();
      this.btnJ3 = new Button();
      this.btnJ4 = new Button();
      this.btnJ5 = new Button();
      this.btnJ6 = new Button();
      this.btnJ7 = new Button();
      this.txtCno3 = new TextBox();
      this.txtCno4 = new TextBox();
      this.txtCno5 = new TextBox();
      this.txtCno6 = new TextBox();
      this.txtCno7 = new TextBox();
      this.txtCno2 = new TextBox();
      this.txtJ_func4 = new TextBox();
      this.txtJ_func5 = new TextBox();
      this.txtJ_func6 = new TextBox();
      this.txtJ_func7 = new TextBox();
      this.txtJ_func3 = new TextBox();
      this.txtJ_func2 = new TextBox();
      this.txtNonJudgingRefree = new TextBox();
      this.txtTrialJudge = new TextBox();
      this.txtJudge = new TextBox();
      this.NumericUpDown2 = new NumericUpDown();
      this.NumericUpDown1 = new NumericUpDown();
      this.btnNonJudgingReferee = new Button();
      this.Label6 = new Label();
      this.TableLayoutPanel1.SuspendLayout();
      this.NumericUpDown2.BeginInit();
      this.NumericUpDown1.BeginInit();
      this.SuspendLayout();
      this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
      this.TableLayoutPanel1.BackColor = Color.White;
      this.TableLayoutPanel1.ColumnCount = 2;
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
      this.TableLayoutPanel1.Controls.Add((Control) this.OK_Button, 0, 0);
      this.TableLayoutPanel1.Controls.Add((Control) this.Cancel_Button, 1, 0);
      this.TableLayoutPanel1.Location = new Point(149, 445);
      this.TableLayoutPanel1.Name = "TableLayoutPanel1";
      this.TableLayoutPanel1.RowCount = 1;
      this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
      TableLayoutPanel tableLayoutPanel1 = this.TableLayoutPanel1;
      Size size1 = new Size(146, 29);
      Size size2 = size1;
      tableLayoutPanel1.Size = size2;
      this.TableLayoutPanel1.TabIndex = 0;
      this.OK_Button.Anchor = AnchorStyles.None;
      this.OK_Button.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
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
      this.Cancel_Button.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Cancel_Button.Location = new Point(76, 3);
      this.Cancel_Button.Name = "Cancel_Button";
      Button cancelButton = this.Cancel_Button;
      size1 = new Size(67, 23);
      Size size4 = size1;
      cancelButton.Size = size4;
      this.Cancel_Button.TabIndex = 1;
      this.Cancel_Button.Text = "Cancel";
      this.Label1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(124, 194);
      this.Label1.Name = "Label1";
      Label label1 = this.Label1;
      size1 = new Size(77, 52);
      Size size5 = size1;
      label1.Size = size5;
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Judge Number, Selection";
      this.Label3.AutoSize = true;
      this.Label3.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.Location = new Point(222, 227);
      this.Label3.Name = "Label3";
      Label label3 = this.Label3;
      size1 = new Size(119, 17);
      Size size6 = size1;
      label3.Size = size6;
      this.Label3.TabIndex = 3;
      this.Label3.Text = "Judge Function";
      this.txtJ_func1.BackColor = Color.White;
      this.txtJ_func1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtJ_func1.Location = new Point(216, 249);
      this.txtJ_func1.Name = "txtJ_func1";
      this.txtJ_func1.ReadOnly = true;
      TextBox txtJFunc1 = this.txtJ_func1;
      size1 = new Size(219, 20);
      Size size7 = size1;
      txtJFunc1.Size = size7;
      this.txtJ_func1.TabIndex = 5;
      this.txtJ_func1.TextAlign = HorizontalAlignment.Center;
      this.txtCno1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCno1.Location = new Point(50, 249);
      this.txtCno1.Name = "txtCno1";
      TextBox txtCno1 = this.txtCno1;
      size1 = new Size(31, 20);
      Size size8 = size1;
      txtCno1.Size = size8;
      this.txtCno1.TabIndex = 1;
      this.txtCno1.Text = "1";
      this.txtCno1.TextAlign = HorizontalAlignment.Center;
      this.btnJ1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnJ1.Location = new Point(140, 248);
      this.btnJ1.Name = "btnJ1";
      Button btnJ1 = this.btnJ1;
      size1 = new Size(35, 21);
      Size size9 = size1;
      btnJ1.Size = size9;
      this.btnJ1.TabIndex = 8;
      this.btnJ1.Text = "1";
      this.btnJ1.UseVisualStyleBackColor = true;
      this.btnJ2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnJ2.Location = new Point(140, 275);
      this.btnJ2.Name = "btnJ2";
      Button btnJ2 = this.btnJ2;
      size1 = new Size(35, 21);
      Size size10 = size1;
      btnJ2.Size = size10;
      this.btnJ2.TabIndex = 9;
      this.btnJ2.Text = "2";
      this.btnJ2.UseVisualStyleBackColor = true;
      this.btnJ2.Visible = false;
      this.btnJ3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnJ3.Location = new Point(140, 302);
      this.btnJ3.Name = "btnJ3";
      Button btnJ3 = this.btnJ3;
      size1 = new Size(35, 21);
      Size size11 = size1;
      btnJ3.Size = size11;
      this.btnJ3.TabIndex = 10;
      this.btnJ3.Text = "3";
      this.btnJ3.UseVisualStyleBackColor = true;
      this.btnJ3.Visible = false;
      this.btnJ4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnJ4.Location = new Point(140, 329);
      this.btnJ4.Name = "btnJ4";
      Button btnJ4 = this.btnJ4;
      size1 = new Size(35, 21);
      Size size12 = size1;
      btnJ4.Size = size12;
      this.btnJ4.TabIndex = 11;
      this.btnJ4.Text = "4";
      this.btnJ4.UseVisualStyleBackColor = true;
      this.btnJ4.Visible = false;
      this.btnJ5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnJ5.Location = new Point(140, 356);
      this.btnJ5.Name = "btnJ5";
      Button btnJ5 = this.btnJ5;
      size1 = new Size(35, 21);
      Size size13 = size1;
      btnJ5.Size = size13;
      this.btnJ5.TabIndex = 12;
      this.btnJ5.Text = "5";
      this.btnJ5.UseVisualStyleBackColor = true;
      this.btnJ5.Visible = false;
      this.btnJ6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnJ6.Location = new Point(140, 383);
      this.btnJ6.Name = "btnJ6";
      Button btnJ6 = this.btnJ6;
      size1 = new Size(35, 21);
      Size size14 = size1;
      btnJ6.Size = size14;
      this.btnJ6.TabIndex = 13;
      this.btnJ6.Text = "6";
      this.btnJ6.UseVisualStyleBackColor = true;
      this.btnJ6.Visible = false;
      this.btnJ7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnJ7.Location = new Point(140, 410);
      this.btnJ7.Name = "btnJ7";
      Button btnJ7 = this.btnJ7;
      size1 = new Size(35, 21);
      Size size15 = size1;
      btnJ7.Size = size15;
      this.btnJ7.TabIndex = 14;
      this.btnJ7.Text = "7";
      this.btnJ7.UseVisualStyleBackColor = true;
      this.btnJ7.Visible = false;
      this.txtCno3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCno3.Location = new Point(50, 303);
      this.txtCno3.Name = "txtCno3";
      TextBox txtCno3 = this.txtCno3;
      size1 = new Size(31, 20);
      Size size16 = size1;
      txtCno3.Size = size16;
      this.txtCno3.TabIndex = 3;
      this.txtCno3.Text = "3";
      this.txtCno3.TextAlign = HorizontalAlignment.Center;
      this.txtCno4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCno4.Location = new Point(50, 330);
      this.txtCno4.Name = "txtCno4";
      TextBox txtCno4 = this.txtCno4;
      size1 = new Size(31, 20);
      Size size17 = size1;
      txtCno4.Size = size17;
      this.txtCno4.TabIndex = 4;
      this.txtCno4.Text = "4";
      this.txtCno4.TextAlign = HorizontalAlignment.Center;
      this.txtCno5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCno5.Location = new Point(50, 357);
      this.txtCno5.Name = "txtCno5";
      TextBox txtCno5 = this.txtCno5;
      size1 = new Size(31, 20);
      Size size18 = size1;
      txtCno5.Size = size18;
      this.txtCno5.TabIndex = 5;
      this.txtCno5.Text = "5";
      this.txtCno5.TextAlign = HorizontalAlignment.Center;
      this.txtCno6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCno6.Location = new Point(50, 384);
      this.txtCno6.Name = "txtCno6";
      TextBox txtCno6 = this.txtCno6;
      size1 = new Size(31, 20);
      Size size19 = size1;
      txtCno6.Size = size19;
      this.txtCno6.TabIndex = 6;
      this.txtCno6.Text = "6";
      this.txtCno6.TextAlign = HorizontalAlignment.Center;
      this.txtCno7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCno7.Location = new Point(50, 411);
      this.txtCno7.Name = "txtCno7";
      TextBox txtCno7 = this.txtCno7;
      size1 = new Size(31, 20);
      Size size20 = size1;
      txtCno7.Size = size20;
      this.txtCno7.TabIndex = 7;
      this.txtCno7.Text = "7";
      this.txtCno7.TextAlign = HorizontalAlignment.Center;
      this.txtCno2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtCno2.Location = new Point(50, 276);
      this.txtCno2.Name = "txtCno2";
      TextBox txtCno2 = this.txtCno2;
      size1 = new Size(31, 20);
      Size size21 = size1;
      txtCno2.Size = size21;
      this.txtCno2.TabIndex = 2;
      this.txtCno2.Text = "2";
      this.txtCno2.TextAlign = HorizontalAlignment.Center;
      this.txtJ_func4.BackColor = Color.White;
      this.txtJ_func4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtJ_func4.Location = new Point(216, 330);
      this.txtJ_func4.Name = "txtJ_func4";
      this.txtJ_func4.ReadOnly = true;
      TextBox txtJFunc4 = this.txtJ_func4;
      size1 = new Size(219, 20);
      Size size22 = size1;
      txtJFunc4.Size = size22;
      this.txtJ_func4.TabIndex = 28;
      this.txtJ_func4.TextAlign = HorizontalAlignment.Center;
      this.txtJ_func4.Visible = false;
      this.txtJ_func5.BackColor = Color.White;
      this.txtJ_func5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtJ_func5.Location = new Point(216, 357);
      this.txtJ_func5.Name = "txtJ_func5";
      this.txtJ_func5.ReadOnly = true;
      TextBox txtJFunc5 = this.txtJ_func5;
      size1 = new Size(219, 20);
      Size size23 = size1;
      txtJFunc5.Size = size23;
      this.txtJ_func5.TabIndex = 29;
      this.txtJ_func5.TextAlign = HorizontalAlignment.Center;
      this.txtJ_func5.Visible = false;
      this.txtJ_func6.BackColor = Color.White;
      this.txtJ_func6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtJ_func6.Location = new Point(216, 384);
      this.txtJ_func6.Name = "txtJ_func6";
      this.txtJ_func6.ReadOnly = true;
      TextBox txtJFunc6 = this.txtJ_func6;
      size1 = new Size(219, 20);
      Size size24 = size1;
      txtJFunc6.Size = size24;
      this.txtJ_func6.TabIndex = 30;
      this.txtJ_func6.TextAlign = HorizontalAlignment.Center;
      this.txtJ_func6.Visible = false;
      this.txtJ_func7.BackColor = Color.White;
      this.txtJ_func7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtJ_func7.Location = new Point(216, 411);
      this.txtJ_func7.Name = "txtJ_func7";
      this.txtJ_func7.ReadOnly = true;
      TextBox txtJFunc7 = this.txtJ_func7;
      size1 = new Size(219, 20);
      Size size25 = size1;
      txtJFunc7.Size = size25;
      this.txtJ_func7.TabIndex = 31;
      this.txtJ_func7.TextAlign = HorizontalAlignment.Center;
      this.txtJ_func7.Visible = false;
      this.txtJ_func3.BackColor = Color.White;
      this.txtJ_func3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtJ_func3.Location = new Point(216, 304);
      this.txtJ_func3.Name = "txtJ_func3";
      this.txtJ_func3.ReadOnly = true;
      TextBox txtJFunc3 = this.txtJ_func3;
      size1 = new Size(219, 20);
      Size size26 = size1;
      txtJFunc3.Size = size26;
      this.txtJ_func3.TabIndex = 32;
      this.txtJ_func3.TextAlign = HorizontalAlignment.Center;
      this.txtJ_func3.Visible = false;
      this.txtJ_func2.BackColor = Color.White;
      this.txtJ_func2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtJ_func2.Location = new Point(216, 276);
      this.txtJ_func2.Name = "txtJ_func2";
      this.txtJ_func2.ReadOnly = true;
      TextBox txtJFunc2 = this.txtJ_func2;
      size1 = new Size(219, 20);
      Size size27 = size1;
      txtJFunc2.Size = size27;
      this.txtJ_func2.TabIndex = 33;
      this.txtJ_func2.TextAlign = HorizontalAlignment.Center;
      this.txtJ_func2.Visible = false;
      this.txtNonJudgingRefree.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.txtNonJudgingRefree.BorderStyle = BorderStyle.None;
      this.txtNonJudgingRefree.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtNonJudgingRefree.Location = new Point(265, 24);
      this.txtNonJudgingRefree.Multiline = true;
      this.txtNonJudgingRefree.Name = "txtNonJudgingRefree";
      this.txtNonJudgingRefree.ReadOnly = true;
      TextBox nonJudgingRefree = this.txtNonJudgingRefree;
      size1 = new Size(163, 38);
      Size size28 = size1;
      nonJudgingRefree.Size = size28;
      this.txtNonJudgingRefree.TabIndex = 40;
      this.txtNonJudgingRefree.Text = "Judging Referee";
      this.txtTrialJudge.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.txtTrialJudge.BorderStyle = BorderStyle.None;
      this.txtTrialJudge.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtTrialJudge.Location = new Point(39, 148);
      this.txtTrialJudge.Multiline = true;
      this.txtTrialJudge.Name = "txtTrialJudge";
      this.txtTrialJudge.ReadOnly = true;
      TextBox txtTrialJudge = this.txtTrialJudge;
      size1 = new Size(192, 41);
      Size size29 = size1;
      txtTrialJudge.Size = size29;
      this.txtTrialJudge.TabIndex = 39;
      this.txtTrialJudge.Text = "Number of Trial Judges";
      this.txtJudge.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.txtJudge.BorderStyle = BorderStyle.None;
      this.txtJudge.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.txtJudge.Location = new Point(38, 101);
      this.txtJudge.Multiline = true;
      this.txtJudge.Name = "txtJudge";
      this.txtJudge.ReadOnly = true;
      TextBox txtJudge = this.txtJudge;
      size1 = new Size(194, 42);
      Size size30 = size1;
      txtJudge.Size = size30;
      this.txtJudge.TabIndex = 38;
      this.txtJudge.Text = "Number of Judges including a Judging Referee";
      this.NumericUpDown2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.NumericUpDown2.Location = new Point(308, 148);
      this.NumericUpDown2.Maximum = new Decimal(new int[4]
      {
        7,
        0,
        0,
        0
      });
      this.NumericUpDown2.Name = "NumericUpDown2";
      this.NumericUpDown2.ReadOnly = true;
      NumericUpDown numericUpDown2 = this.NumericUpDown2;
      size1 = new Size(69, 26);
      Size size31 = size1;
      numericUpDown2.Size = size31;
      this.NumericUpDown2.TabIndex = 37;
      this.NumericUpDown2.TextAlign = HorizontalAlignment.Center;
      this.NumericUpDown1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.NumericUpDown1.Location = new Point(308, 101);
      this.NumericUpDown1.Maximum = new Decimal(new int[4]
      {
        7,
        0,
        0,
        0
      });
      this.NumericUpDown1.Minimum = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.NumericUpDown1.Name = "NumericUpDown1";
      this.NumericUpDown1.ReadOnly = true;
      NumericUpDown numericUpDown1 = this.NumericUpDown1;
      size1 = new Size(69, 26);
      Size size32 = size1;
      numericUpDown1.Size = size32;
      this.NumericUpDown1.TabIndex = 36;
      this.NumericUpDown1.TextAlign = HorizontalAlignment.Center;
      this.NumericUpDown1.Value = new Decimal(new int[4]
      {
        1,
        0,
        0,
        0
      });
      this.btnNonJudgingReferee.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btnNonJudgingReferee.Location = new Point(39, 12);
      this.btnNonJudgingReferee.Name = "btnNonJudgingReferee";
      Button nonJudgingReferee = this.btnNonJudgingReferee;
      size1 = new Size(193, 64);
      Size size33 = size1;
      nonJudgingReferee.Size = size33;
      this.btnNonJudgingReferee.TabIndex = 35;
      this.btnNonJudgingReferee.Text = "Select Non-Judging Referee";
      this.btnNonJudgingReferee.UseVisualStyleBackColor = true;
      this.Label6.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.Location = new Point(35, 193);
      this.Label6.Name = "Label6";
      Label label6 = this.Label6;
      size1 = new Size(79, 53);
      Size size34 = size1;
      label6.Size = size34;
      this.Label6.TabIndex = 43;
      this.Label6.Text = "Judge Computer Number";
      this.AcceptButton = (IButtonControl) this.OK_Button;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
      this.CancelButton = (IButtonControl) this.Cancel_Button;
      size1 = new Size(447, 486);
      this.ClientSize = size1;
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.txtNonJudgingRefree);
      this.Controls.Add((Control) this.txtTrialJudge);
      this.Controls.Add((Control) this.txtJudge);
      this.Controls.Add((Control) this.NumericUpDown2);
      this.Controls.Add((Control) this.NumericUpDown1);
      this.Controls.Add((Control) this.btnNonJudgingReferee);
      this.Controls.Add((Control) this.txtJ_func2);
      this.Controls.Add((Control) this.txtJ_func3);
      this.Controls.Add((Control) this.txtJ_func7);
      this.Controls.Add((Control) this.txtJ_func6);
      this.Controls.Add((Control) this.txtJ_func5);
      this.Controls.Add((Control) this.txtJ_func4);
      this.Controls.Add((Control) this.txtCno2);
      this.Controls.Add((Control) this.txtCno7);
      this.Controls.Add((Control) this.txtCno6);
      this.Controls.Add((Control) this.txtCno5);
      this.Controls.Add((Control) this.txtCno4);
      this.Controls.Add((Control) this.txtCno3);
      this.Controls.Add((Control) this.btnJ7);
      this.Controls.Add((Control) this.btnJ6);
      this.Controls.Add((Control) this.btnJ5);
      this.Controls.Add((Control) this.btnJ4);
      this.Controls.Add((Control) this.btnJ3);
      this.Controls.Add((Control) this.btnJ2);
      this.Controls.Add((Control) this.btnJ1);
      this.Controls.Add((Control) this.txtCno1);
      this.Controls.Add((Control) this.txtJ_func1);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.TableLayoutPanel1);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Dialog4);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "JUDGES SETUP";
      this.TopMost = true;
      this.TableLayoutPanel1.ResumeLayout(false);
      this.NumericUpDown2.EndInit();
      this.NumericUpDown1.EndInit();
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

    internal virtual Label Label1
    {
      get => this._Label1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label1 = value;
    }

    internal virtual Label Label3
    {
      get => this._Label3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label3 = value;
    }

    internal virtual TextBox txtJ_func1
    {
      get => this._txtJ_func1;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtJ_func1 = value;
    }

    internal virtual TextBox txtCno1
    {
      get => this._txtCno1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtCno1_KeyPress);
        if (this._txtCno1 != null)
          this._txtCno1.KeyPress -= pressEventHandler;
        this._txtCno1 = value;
        if (this._txtCno1 == null)
          return;
        this._txtCno1.KeyPress += pressEventHandler;
      }
    }

    internal virtual Button btnJ1
    {
      get => this._btnJ1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnJ1_Click);
        if (this._btnJ1 != null)
          this._btnJ1.Click -= eventHandler;
        this._btnJ1 = value;
        if (this._btnJ1 == null)
          return;
        this._btnJ1.Click += eventHandler;
      }
    }

    internal virtual Button btnJ2
    {
      get => this._btnJ2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnJ2_Click);
        if (this._btnJ2 != null)
          this._btnJ2.Click -= eventHandler;
        this._btnJ2 = value;
        if (this._btnJ2 == null)
          return;
        this._btnJ2.Click += eventHandler;
      }
    }

    internal virtual Button btnJ3
    {
      get => this._btnJ3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnJ3_Click);
        if (this._btnJ3 != null)
          this._btnJ3.Click -= eventHandler;
        this._btnJ3 = value;
        if (this._btnJ3 == null)
          return;
        this._btnJ3.Click += eventHandler;
      }
    }

    internal virtual Button btnJ4
    {
      get => this._btnJ4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnJ4_Click);
        if (this._btnJ4 != null)
          this._btnJ4.Click -= eventHandler;
        this._btnJ4 = value;
        if (this._btnJ4 == null)
          return;
        this._btnJ4.Click += eventHandler;
      }
    }

    internal virtual Button btnJ5
    {
      get => this._btnJ5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnJ5_Click);
        if (this._btnJ5 != null)
          this._btnJ5.Click -= eventHandler;
        this._btnJ5 = value;
        if (this._btnJ5 == null)
          return;
        this._btnJ5.Click += eventHandler;
      }
    }

    internal virtual Button btnJ6
    {
      get => this._btnJ6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnJ6_Click);
        if (this._btnJ6 != null)
          this._btnJ6.Click -= eventHandler;
        this._btnJ6 = value;
        if (this._btnJ6 == null)
          return;
        this._btnJ6.Click += eventHandler;
      }
    }

    internal virtual Button btnJ7
    {
      get => this._btnJ7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnJ7_Click);
        if (this._btnJ7 != null)
          this._btnJ7.Click -= eventHandler;
        this._btnJ7 = value;
        if (this._btnJ7 == null)
          return;
        this._btnJ7.Click += eventHandler;
      }
    }

    internal virtual TextBox txtCno3
    {
      get => this._txtCno3;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtCno3_KeyPress);
        if (this._txtCno3 != null)
          this._txtCno3.KeyPress -= pressEventHandler;
        this._txtCno3 = value;
        if (this._txtCno3 == null)
          return;
        this._txtCno3.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox txtCno4
    {
      get => this._txtCno4;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtCno4_KeyPress);
        if (this._txtCno4 != null)
          this._txtCno4.KeyPress -= pressEventHandler;
        this._txtCno4 = value;
        if (this._txtCno4 == null)
          return;
        this._txtCno4.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox txtCno5
    {
      get => this._txtCno5;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtCno5_KeyPress);
        if (this._txtCno5 != null)
          this._txtCno5.KeyPress -= pressEventHandler;
        this._txtCno5 = value;
        if (this._txtCno5 == null)
          return;
        this._txtCno5.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox txtCno6
    {
      get => this._txtCno6;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtCno6_KeyPress);
        if (this._txtCno6 != null)
          this._txtCno6.KeyPress -= pressEventHandler;
        this._txtCno6 = value;
        if (this._txtCno6 == null)
          return;
        this._txtCno6.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox txtCno7
    {
      get => this._txtCno7;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtCno7_KeyPress);
        if (this._txtCno7 != null)
          this._txtCno7.KeyPress -= pressEventHandler;
        this._txtCno7 = value;
        if (this._txtCno7 == null)
          return;
        this._txtCno7.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox txtCno2
    {
      get => this._txtCno2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtCno2_KeyPress);
        if (this._txtCno2 != null)
          this._txtCno2.KeyPress -= pressEventHandler;
        this._txtCno2 = value;
        if (this._txtCno2 == null)
          return;
        this._txtCno2.KeyPress += pressEventHandler;
      }
    }

    internal virtual TextBox txtJ_func4
    {
      get => this._txtJ_func4;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtJ_func4 = value;
    }

    internal virtual TextBox txtJ_func5
    {
      get => this._txtJ_func5;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtJ_func5 = value;
    }

    internal virtual TextBox txtJ_func6
    {
      get => this._txtJ_func6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtJ_func6 = value;
    }

    internal virtual TextBox txtJ_func7
    {
      get => this._txtJ_func7;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtJ_func7 = value;
    }

    internal virtual TextBox txtJ_func3
    {
      get => this._txtJ_func3;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtJ_func3 = value;
    }

    internal virtual TextBox txtJ_func2
    {
      get => this._txtJ_func2;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtJ_func2 = value;
    }

    internal virtual TextBox txtNonJudgingRefree
    {
      get => this._txtNonJudgingRefree;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtNonJudgingRefree = value;
    }

    internal virtual TextBox txtTrialJudge
    {
      get => this._txtTrialJudge;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtTrialJudge = value;
    }

    internal virtual TextBox txtJudge
    {
      get => this._txtJudge;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._txtJudge = value;
    }

    internal virtual NumericUpDown NumericUpDown2
    {
      get => this._NumericUpDown2;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.NumericUpDown2_ValueChanged);
        if (this._NumericUpDown2 != null)
          this._NumericUpDown2.ValueChanged -= eventHandler;
        this._NumericUpDown2 = value;
        if (this._NumericUpDown2 == null)
          return;
        this._NumericUpDown2.ValueChanged += eventHandler;
      }
    }

    internal virtual NumericUpDown NumericUpDown1
    {
      get => this._NumericUpDown1;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.NumericUpDown1_ValueChanged);
        if (this._NumericUpDown1 != null)
          this._NumericUpDown1.ValueChanged -= eventHandler;
        this._NumericUpDown1 = value;
        if (this._NumericUpDown1 == null)
          return;
        this._NumericUpDown1.ValueChanged += eventHandler;
      }
    }

    internal virtual Button btnNonJudgingReferee
    {
      get => this._btnNonJudgingReferee;
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.btnNonJudgingReferee_Click);
        if (this._btnNonJudgingReferee != null)
          this._btnNonJudgingReferee.Click -= eventHandler;
        this._btnNonJudgingReferee = value;
        if (this._btnNonJudgingReferee == null)
          return;
        this._btnNonJudgingReferee.Click += eventHandler;
      }
    }

    internal virtual Label Label6
    {
      get => this._Label6;
      [MethodImpl(MethodImplOptions.Synchronized)] set => this._Label6 = value;
    }

    private void Dialog4_Load(object sender, EventArgs e)
    {
      int num1 = 0;
      int num2 = 0;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        this.Top = MyProject.Forms.Form1.Top;
        this.Left = checked ((int) Math.Round(unchecked ((double) MyProject.Forms.Form1.Left + (double) MyProject.Forms.Form1.Width / 2.0 - (double) this.Width / 2.0)));
        this.TopMost = true;
        this.NumericUpDown1.Maximum = 7M;
        this.NumericUpDown1.Increment = 1M;
        this.NumericUpDown1.Minimum = 1M;
        this.NumericUpDown2.Maximum = 7M;
        this.NumericUpDown2.Minimum = 0M;
        this.NumericUpDown2.Increment = 1M;
        string segment = Module1.Segment;
        if (Operators.CompareString(segment, "Seg1", false) == 0)
        {
          this.NoJ_Ca = Module1.NoJ_Seg1;
          this.NoTrj_Ca = Module1.NoTrJ_Seg1;
          this.JudgeSel_Ca = Module1.JudgeSel_Seg1;
        }
        else if (Operators.CompareString(segment, "Seg2", false) == 0)
        {
          this.NoJ_Ca = Module1.NoJ_Seg2;
          this.NoTrj_Ca = Module1.NoTrJ_Seg2;
          this.JudgeSel_Ca = Module1.JudgeSel_Seg2;
        }
        else
        {
          this.NoJ_Ca = Module1.NoJ_Seg1;
          this.NoTrj_Ca = Module1.NoTrJ_Seg1;
          this.JudgeSel_Ca = Module1.JudgeSel_Seg1;
        }
        this.NumericUpDown1.Text = Conversions.ToString(this.NoJ_Ca);
        this.NumericUpDown2.Text = Conversions.ToString(this.NoTrj_Ca);
        switch (this.JudgeSel_Ca)
        {
          case 0:
            this.btnNonJudgingReferee.Text = "SELECT\r\nNon-Judging Referee";
            this.txtNonJudgingRefree.Text = "Judging Referee";
            this.txtJudge.Text = "No. of Judges (1-7)\r\nincluding a Judging Referee";
            this.txtTrialJudge.Text = "No. of trial judges (0-" + Strings.Trim(Conversions.ToString(checked (7 - this.NoJ_Ca))) + ")";
            break;
          case 1:
            this.btnNonJudgingReferee.Text = "DESELECT\r\nNon-Judging Referee";
            this.txtNonJudgingRefree.Text = "Non-Judging Referee as Judge no. 7";
            this.txtJudge.Text = "No. of Judges (1-6)";
            this.txtTrialJudge.Text = "No. of trial judges (0-" + Strings.Trim(Conversions.ToString(checked (7 - this.NoJ_Ca - 1))) + ")";
            break;
        }
        this.MeLoad = false;
        this.SetJudgeTextIni();
        goto label_15;
      }
      catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
      }
      num2 = -1;
      if (num1 == 2)
      {
        int num3 = (int) Interaction.MsgBox((object) ("Dialog4_Load - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object) "Susanne SW");
      }
label_15:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    private void OK_Button_Click(object sender, EventArgs e)
    {
      int num1 = 0;
      int num2 = 0;
      try
      {
        string cno = "";
        string Jno = "";
        ProjectData.ClearProjectError();
        num1 = 2;
        int num3 = this.JudgeSel_Ca == 0 ? 7 : 6;
        if (!this.CompMissing(ref Jno))
        {
          int num4 = (int) Interaction.MsgBox((object) ("The Computer no. for Judge #" + Jno + "\r\nis not selected!"), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object) "Susanne SW");
          goto label_36;
        }
        else if (!this.CompSet(ref cno))
        {
          int num5 = (int) Interaction.MsgBox((object) ("The Computer no. are not correct!\r\nComputer #" + cno + " is in multiple locations!"), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object) "Susanne SW");
          goto label_36;
        }
        else
        {
          if (Decimal.Compare(this.NumericUpDown1.Value, 0M) > 0 && this.NoJ_Ca < 1 | this.NoJ_Ca > num3)
          {
            int num6 = (int) Interaction.MsgBox((object) "The no. of Judges for PC has been set to 3!", MsgBoxStyle.SystemModal, (object) "Susanne SW");
            this.NoJ_Ca = 3;
          }
          if (Decimal.Compare(this.NumericUpDown2.Value, 0M) > 0)
          {
            switch (this.JudgeSel_Ca)
            {
              case 0:
                Module1.NoTrj = Convert.ToInt32(Conversion.Int(this.NumericUpDown2.Value));
                if (Module1.NoTrj < 0 | Module1.NoTrj > checked (7 - this.NoJ_Ca))
                {
                  int num7 = (int) Interaction.MsgBox((object) ("The no. of Trial Judges has been set to " + Strings.Trim(Conversions.ToString(checked (7 - this.NoJ_Ca))) + "!"), MsgBoxStyle.SystemModal, (object) "Susanne SW");
                  Module1.NoTrj = checked (7 - this.NoJ_Ca);
                  break;
                }
                break;
              case 1:
                Module1.NoTrj = Convert.ToInt32(Conversion.Int(this.NumericUpDown2.Value));
                if (Module1.NoTrj < 0 | Module1.NoTrj > checked (7 - this.NoJ_Ca - 1))
                {
                  int num8 = (int) Interaction.MsgBox((object) ("The no. of Trial Judges has been set to " + Strings.Trim(Conversions.ToString(checked (7 - this.NoJ_Ca - 1))) + "!"), MsgBoxStyle.SystemModal, (object) "Susanne SW");
                  Module1.NoTrj = checked (7 - this.NoJ_Ca - 1);
                  break;
                }
                break;
            }
          }
          if (Module1.WorkMode == 1)
          {
            string seg = Module1.GetSeg();
            if (Operators.CompareString(seg, "SS", false) == 0 || Operators.CompareString(seg, "FF", false) == 0 || Operators.CompareString(seg, "SF", false) == 0)
            {
              int num9 = (int) Interaction.MsgBox((object) "Do you want to have the same set-up for\r\nboth Segment 1 and Segment 2?", MsgBoxStyle.YesNo | MsgBoxStyle.Question, (object) "Susanne SW");
              string segment = Module1.Segment;
              if (Operators.CompareString(segment, "Seg1", false) == 0)
              {
                Module1.NoJ_Seg1 = this.NoJ_Ca;
                Module1.NoTrJ_Seg1 = this.NoTrj_Ca;
                Module1.JudgeSel_Seg1 = this.JudgeSel_Ca;
                if (num9 == 6)
                {
                  Module1.NoJ_Seg2 = this.NoJ_Ca;
                  Module1.NoTrJ_Seg2 = this.NoTrj_Ca;
                  Module1.JudgeSel_Seg2 = this.JudgeSel_Ca;
                }
              }
              else if (Operators.CompareString(segment, "Seg2", false) == 0)
              {
                Module1.NoJ_Seg2 = this.NoJ_Ca;
                Module1.NoTrJ_Seg2 = this.NoTrj_Ca;
                Module1.JudgeSel_Seg2 = this.JudgeSel_Ca;
                if (num9 == 6)
                {
                  Module1.NoJ_Seg1 = this.NoJ_Ca;
                  Module1.NoTrJ_Seg1 = this.NoTrj_Ca;
                  Module1.JudgeSel_Seg1 = this.JudgeSel_Ca;
                }
              }
            }
            else if (Operators.CompareString(seg, "0F", false) == 0)
            {
              Module1.NoJ_Seg2 = this.NoJ_Ca;
              Module1.NoTrJ_Seg2 = this.NoTrj_Ca;
              Module1.JudgeSel_Seg2 = this.JudgeSel_Ca;
            }
            else if (Operators.CompareString(seg, "S0", false) == 0)
            {
              Module1.NoJ_Seg1 = this.NoJ_Ca;
              Module1.NoTrJ_Seg1 = this.NoTrj_Ca;
              Module1.JudgeSel_Seg1 = this.JudgeSel_Ca;
            }
            else
            {
              Module1.NoJ_Seg1 = this.NoJ_Ca;
              Module1.NoTrJ_Seg1 = this.NoTrj_Ca;
              Module1.JudgeSel_Seg1 = this.JudgeSel_Ca;
              Module1.NoJ_Seg2 = this.NoJ_Ca;
              Module1.NoTrJ_Seg2 = this.NoTrj_Ca;
              Module1.JudgeSel_Seg2 = this.JudgeSel_Ca;
            }
          }
          else
          {
            int num10 = (int) Interaction.MsgBox((object) "This can not be possible!");
          }
          Module1.SetNoJ();
          this.GetJudgeComp();
          this.DialogResult = DialogResult.OK;
          this.Close();
          Module1.CreateForm1();
          Module1.SaveIniData("CLUBCOMP.INI");
          if (Strings.Len(Module1.Competition.Name) > 0)
            Module1.SaveCategoryFile(Module1.CategoryFileName);
          if (Module1.WorkMode == 1)
          {
            MyProject.Forms.Form1.SendFunc();
            goto label_36;
          }
          else
            goto label_36;
        }
      }
      catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
      }
      num2 = -1;
      if (num1 == 2)
      {
        int num11 = (int) Interaction.MsgBox((object) ("OK_Button_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object) "Susanne SW");
      }
label_36:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public bool CompSet(ref string cno)
    {
      bool flag = true;
      int num1 = 1;
      do
      {
        string key1 = "txtCno" + Conversions.ToString(num1);
        int num2 = checked (num1 + 1);
        while (num2 <= 7)
        {
          string key2 = "txtCno" + Conversions.ToString(num2);
          if (Operators.CompareString(this.Controls[key1].Text, this.Controls[key2].Text, false) == 0 & Operators.CompareString(this.Controls[key1].Text, "0", false) != 0)
          {
            flag = false;
            cno = this.Controls[key1].Text;
            goto label_7;
          }
          else
            checked { ++num2; }
        }
        checked { ++num1; }
      }
      while (num1 <= 7);
label_7:
      return flag;
    }

    public bool CompMissing(ref string Jno)
    {
      bool flag = true;
      int num = 1;
      while (!(Operators.CompareString(this.Controls["txtCno" + Conversions.ToString(num)].Text, "0", false) == 0 & this.Controls["btnJ" + Conversions.ToString(num)].Visible))
      {
        checked { ++num; }
        if (num > 7)
          goto label_4;
      }
      flag = false;
      Jno = Conversions.ToString(num);
label_4:
      return flag;
    }

    private void GetJudgeComp()
    {
      Module1.JudgeCompNo = (int[]) null;
      Module1.JudgeCompNo = new int[8];
      Module1.JudgeCompFunc = (int[]) null;
      Module1.JudgeCompFunc = new int[8];
      int index = 1;
      do
      {
        string key1 = "txtCno" + Conversions.ToString(index);
        string key2 = "txtJ_func" + Conversions.ToString(index);
        Module1.JudgeCompNo[index] = Conversions.ToInteger(this.Controls[key1].Text);
        Module1.JudgeCompFunc[index] = Conversions.ToInteger(this.GetFuncNo(this.Controls[key2].Text));
        checked { ++index; }
      }
      while (index <= 7);
    }

    public string GetFuncText(int ind)
    {
      string funcText;
      switch (ind)
      {
        case 0:
        case 2:
          funcText = "Judge for Scores";
          break;
        case 1:
          funcText = "Referee and Judge for Scores";
          break;
        case 3:
          funcText = "Non-Judging Referee";
          break;
        case 4:
          funcText = "Trial Judge";
          break;
        default:
          funcText = "";
          break;
      }
      return funcText;
    }

    public string GetFuncNo(string txt)
    {
      string Left = txt;
      if (Operators.CompareString(Left, "Referee and Judge for Scores", false) == 0)
        return "1";
      if (Operators.CompareString(Left, "Judge for Scores", false) == 0)
        return "2";
      if (Operators.CompareString(Left, "Non-Judging Referee", false) == 0)
        return "3";
      return Operators.CompareString(Left, "Trial Judge", false) == 0 ? "4" : "0";
    }

    private void Cancel_Button_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
    {
      int num1 = 0;
      int num2 = 0;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        if (this.btnON != 1)
        {
          if (Decimal.Compare(new Decimal(this.NoJ_Ca), this.NumericUpDown1.Value) >= 0)
          {
            if (Convert.ToInt32(this.NumericUpDown1.Value) >= 1)
            {
              this.NoJ_Ca = Convert.ToInt32(Conversion.Int(this.NumericUpDown1.Value));
              this.NumericUpDown1.Value = Conversions.ToDecimal(Conversions.ToString(this.NoJ_Ca));
              this.txtTrialJudge.Text = "No. of trial judges (0-" + Strings.Trim(Conversion.Str((object) checked (7 - this.JudgeSel_Ca - this.NoJ_Ca))) + ")";
              this.NumericUpDown2.Maximum = new Decimal(checked (7 - this.JudgeSel_Ca - this.NoJ_Ca));
              if (Convert.ToInt32(this.NumericUpDown2.Value) > checked (7 - this.JudgeSel_Ca - this.NoJ_Ca))
                this.NumericUpDown2.Value = new Decimal(checked (7 - this.NoJ_Ca));
              this.SetJudgeText();
            }
          }
          else if (Decimal.Compare(new Decimal(this.NoJ_Ca), this.NumericUpDown1.Value) < 0)
          {
            if (Convert.ToInt32(this.NumericUpDown1.Value) <= 7)
            {
              this.NoJ_Ca = Convert.ToInt32(Conversion.Int(this.NumericUpDown1.Value));
              this.NumericUpDown1.Value = Conversions.ToDecimal(Conversions.ToString(this.NoJ_Ca));
              this.txtTrialJudge.Text = "No. of trial judges (0-" + Strings.Trim(Conversion.Str((object) checked (7 - this.JudgeSel_Ca - this.NoJ_Ca))) + ")";
              this.NumericUpDown2.Maximum = new Decimal(checked (7 - this.JudgeSel_Ca - this.NoJ_Ca));
              if (Convert.ToInt32(this.NumericUpDown2.Value) > checked (7 - this.NoJ_Ca))
                this.NumericUpDown2.Value = new Decimal(checked (7 - this.JudgeSel_Ca - this.NoJ_Ca));
              this.SetJudgeText();
            }
            else
            {
              int num3 = (int) Interaction.MsgBox((object) "The no. of judges should be between 1 and 7!", MsgBoxStyle.SystemModal, (object) "Susanne SW");
              this.NumericUpDown1.Value = new Decimal(this.NoJ_Ca);
            }
          }
        }
        this.OK_Button.Select();
        this.btnON = 0;
        goto label_19;
      }
      catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
      }
      num2 = -1;
      if (num1 == 2)
      {
        int num4 = (int) Interaction.MsgBox((object) ("NumericUpDown1_ValueChanged - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object) "Susanne SW");
      }
label_19:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    private void btnNonJudgingReferee_Click(object sender, EventArgs e)
    {
      int num1 = 0;
      int num2 = 0;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        this.btnON = 1;
        switch (this.JudgeSel_Ca)
        {
          case 0:
            this.JudgeSel_Ca = 1;
            this.NumericUpDown1.Maximum = 6M;
            this.btnNonJudgingReferee.Text = "DESELECT\r\nNon-Judging Referee";
            this.txtNonJudgingRefree.Text = "Non-Judging Referee as Judge no. 7";
            this.txtJudge.Text = "No. of Judges (1-6)";
            this.SetReferee(7);
            if (this.NoJ_Ca > 6)
            {
              this.NumericUpDown1.Maximum = 6M;
              checked { --this.NoJ_Ca; }
              this.NumericUpDown1.Value = Conversions.ToDecimal(Conversions.ToString(this.NoJ_Ca));
            }
            this.txtTrialJudge.Text = "No. of trial judges (0-" + Strings.Trim(Conversion.Str((object) checked (7 - this.NoJ_Ca - 1))) + ")";
            this.NumericUpDown2.Maximum = new Decimal(checked (7 - this.NoJ_Ca - 1));
            if (Convert.ToInt32(this.NumericUpDown2.Value) > checked (7 - this.NoJ_Ca - 1))
            {
              checked { --this.NoTrj_Ca; }
              this.NumericUpDown2.Value = Conversions.ToDecimal(Conversions.ToString(this.NoTrj_Ca));
              break;
            }
            break;
          case 1:
            this.JudgeSel_Ca = 0;
            this.NumericUpDown1.Maximum = 7M;
            this.btnNonJudgingReferee.Text = "SELECT\r\nNon-Judging Referee";
            this.txtNonJudgingRefree.Text = "Judging Referee";
            this.txtJudge.Text = "No. of Judges (1-7)\r\nincluding a Judging Referee";
            this.txtTrialJudge.Text = "No. of trial judges (0-" + Strings.Trim(Conversion.Str((object) checked (7 - this.NoJ_Ca))) + ")";
            this.NumericUpDown2.Maximum = new Decimal(checked (7 - this.NoJ_Ca));
            if (Convert.ToInt32(this.NumericUpDown2.Value) > checked (7 - this.NoJ_Ca))
            {
              this.NumericUpDown2.Value = Conversions.ToDecimal(Conversions.ToString(checked (7 - this.NoJ_Ca - 1)));
              break;
            }
            break;
        }
        this.SetJudgeText();
        this.OK_Button.Select();
        this.btnON = 0;
        goto label_14;
      }
      catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
      }
      num2 = -1;
      if (num1 == 2)
      {
        int num3 = (int) Interaction.MsgBox((object) ("btnNonJudgingReferee_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object) "Susanne SW");
      }
label_14:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
    {
      int num1 = 0;
      int num2 = 0;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        if (this.btnON != 1)
        {
          if (Decimal.Compare(new Decimal(this.NoTrj_Ca), Conversion.Int(this.NumericUpDown2.Value)) >= 0)
          {
            if (Convert.ToInt32(this.NumericUpDown2.Value) >= 0)
            {
              this.NoTrj_Ca = Convert.ToInt32(this.NumericUpDown2.Value);
              this.NumericUpDown2.Value = new Decimal(this.NoTrj_Ca);
            }
            this.SetJudgeText();
          }
          else if (Decimal.Compare(new Decimal(this.NoTrj_Ca), Conversion.Int(this.NumericUpDown2.Value)) < 0)
          {
            if (this.JudgeSel_Ca == 0)
            {
              if (Convert.ToInt32(this.NumericUpDown2.Value) <= checked (7 - this.NoJ_Ca))
              {
                this.NoTrj_Ca = Convert.ToInt32(this.NumericUpDown2.Value);
                this.NumericUpDown2.Value = new Decimal(this.NoTrj_Ca);
                this.SetJudgeText();
              }
              else
              {
                int num3 = (int) Interaction.MsgBox((object) ("The no. of trial judges should be between 0 and " + Strings.Trim(Conversion.Str((object) checked (7 - this.NoJ_Ca - this.JudgeSel_Ca)))));
                this.NumericUpDown2.Value = new Decimal(checked (7 - this.NoJ_Ca));
              }
            }
            else if (Convert.ToInt32(this.NumericUpDown2.Value) <= checked (7 - this.NoJ_Ca - 1))
            {
              this.NoTrj_Ca = Convert.ToInt32(this.NumericUpDown2.Value);
              this.NumericUpDown2.Value = new Decimal(this.NoTrj_Ca);
              this.SetJudgeText();
            }
            else
            {
              int num4 = (int) Interaction.MsgBox((object) ("The no. of trial judges should be between 0 and " + Strings.Trim(Conversion.Str((object) checked (7 - this.NoJ_Ca - 1)))));
              this.NumericUpDown2.Value = new Decimal(this.NoTrj_Ca);
            }
          }
        }
        this.OK_Button.Select();
        this.btnON = 0;
        goto label_20;
      }
      catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
      }
      num2 = -1;
      if (num1 == 2)
      {
        int num5 = (int) Interaction.MsgBox((object) ("NumericUpDown2_ValueChanged - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object) "Susanne SW");
      }
label_20:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    private void txtCno1_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
          e.Handled = false;
          break;
        default:
          e.Handled = true;
          break;
      }
    }

    private void txtCno2_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
          e.Handled = false;
          break;
        default:
          e.Handled = true;
          break;
      }
    }

    private void txtCno3_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
          e.Handled = false;
          break;
        default:
          e.Handled = true;
          break;
      }
    }

    private void txtCno4_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
          e.Handled = false;
          break;
        default:
          e.Handled = true;
          break;
      }
    }

    private void txtCno5_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
          e.Handled = false;
          break;
        default:
          e.Handled = true;
          break;
      }
    }

    private void txtCno6_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
          e.Handled = false;
          break;
        default:
          e.Handled = true;
          break;
      }
    }

    private void txtCno7_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
          e.Handled = false;
          break;
        default:
          e.Handled = true;
          break;
      }
    }

    public void SetJudgeTextIni()
    {
      int num1 = 0;
      int num2 = 0;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        if (!this.MeLoad)
        {
          int index = 1;
          do
          {
            string key1 = "txtCno" + Conversions.ToString(index);
            string key2 = "btnJ" + Conversions.ToString(index);
            string key3 = "txtJ_func" + Conversions.ToString(index);
            this.Controls[key1].Visible = true;
            this.Controls[key1].Text = Conversions.ToString(Module1.JudgeCompNo[index]);
            if (index <= checked (this.NoJ_Ca + this.NoTrj_Ca) | index == checked (7 * this.JudgeSel_Ca))
            {
              this.Controls[key2].Visible = true;
              this.Controls[key3].Visible = true;
              if (this.JudgeSel_Ca == 1 & index == 7)
                this.Controls[key3].Text = this.GetFuncText(3);
              else if (index > this.NoJ_Ca & index <= checked (this.NoJ_Ca + this.NoTrj_Ca))
                this.Controls[key3].Text = this.GetFuncText(4);
              else
                this.Controls[key3].Text = this.GetFuncText(Module1.JudgeCompFunc[index]);
            }
            else
            {
              this.Controls[key2].Visible = false;
              this.Controls[key3].Visible = false;
            }
            checked { ++index; }
          }
          while (index <= 7);
          goto label_16;
        }
        else
          goto label_16;
      }
      catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
      }
      num2 = -1;
      if (num1 == 2)
      {
        int num3 = (int) Interaction.MsgBox((object) ("SetJudgeTextIni - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object) "Susanne SW");
      }
label_16:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public void SetJudgeText()
    {
      int num1 = 0;
      int num2 = 0;
      try
      {
        ProjectData.ClearProjectError();
        num1 = 2;
        if (!this.MeLoad)
        {
          int index = 1;
          do
          {
            string key1 = "txtCno" + Conversions.ToString(index);
            string key2 = "btnJ" + Conversions.ToString(index);
            string key3 = "txtJ_func" + Conversions.ToString(index);
            this.Controls[key1].Visible = true;
            this.Controls[key1].Text = Conversions.ToString(Module1.JudgeCompNo[index]);
            if (index <= checked (this.NoJ_Ca + this.NoTrj_Ca) | index == checked (7 * this.JudgeSel_Ca))
            {
              this.Controls[key2].Visible = true;
              this.Controls[key3].Visible = true;
              if (this.JudgeSel_Ca == 1 & index == 7)
                this.Controls[key3].Text = this.GetFuncText(3);
              else if (index > this.NoJ_Ca & index <= checked (this.NoJ_Ca + this.NoTrj_Ca))
                this.Controls[key3].Text = this.GetFuncText(4);
              else if (Operators.CompareString(this.Controls[key3].Text, this.GetFuncText(1), false) != 0)
                this.Controls[key3].Text = this.GetFuncText(2);
            }
            else
            {
              this.Controls[key2].Visible = false;
              this.Controls[key3].Visible = false;
            }
            checked { ++index; }
          }
          while (index <= 7);
          goto label_17;
        }
        else
          goto label_17;
      }
      catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
      {
        ProjectData.SetProjectError(ex);
      }
      num2 = -1;
      if (num1 == 2)
      {
        int num3 = (int) Interaction.MsgBox((object) ("SetJudgeText - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object) "Susanne SW");
      }
label_17:
      if (num2 == 0)
        return;
      ProjectData.ClearProjectError();
    }

    public void SetReferee(int JudgeNo)
    {
      int num = 1;
      do
      {
        string key = "txtJ_func" + Conversions.ToString(num);
        if (num != JudgeNo & Operators.CompareString(this.Controls[key].Text, "Trial Judge", false) != 0)
          this.Controls[key].Text = "Judge for Scores";
        checked { ++num; }
      }
      while (num <= 7);
    }

    private void btnJ1_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtJ_func1.Text, "Trial Judge", false) == 0)
        return;
      if (Operators.CompareString(this.txtJ_func1.Text, "Judge for Scores", false) == 0)
      {
        if (this.JudgeSel_Ca != 0)
          return;
        this.txtJ_func1.Text = "Referee and Judge for Scores";
        this.SetReferee(1);
      }
      else
        this.txtJ_func1.Text = "Judge for Scores";
    }

    private void btnJ2_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtJ_func2.Text, "Trial Judge", false) == 0)
        return;
      if (Operators.CompareString(this.txtJ_func2.Text, "Judge for Scores", false) == 0)
      {
        if (this.JudgeSel_Ca != 0)
          return;
        this.txtJ_func2.Text = "Referee and Judge for Scores";
        this.SetReferee(2);
      }
      else
        this.txtJ_func2.Text = "Judge for Scores";
    }

    private void btnJ3_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtJ_func3.Text, "Trial Judge", false) == 0)
        return;
      if (Operators.CompareString(this.txtJ_func3.Text, "Judge for Scores", false) == 0)
      {
        if (this.JudgeSel_Ca != 0)
          return;
        this.txtJ_func3.Text = "Referee and Judge for Scores";
        this.SetReferee(3);
      }
      else
        this.txtJ_func3.Text = "Judge for Scores";
    }

    private void btnJ4_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtJ_func4.Text, "Trial Judge", false) == 0)
        return;
      if (Operators.CompareString(this.txtJ_func4.Text, "Judge for Scores", false) == 0)
      {
        if (this.JudgeSel_Ca != 0)
          return;
        this.txtJ_func4.Text = "Referee and Judge for Scores";
        this.SetReferee(4);
      }
      else
        this.txtJ_func4.Text = "Judge for Scores";
    }

    private void btnJ5_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtJ_func5.Text, "Trial Judge", false) == 0)
        return;
      if (Operators.CompareString(this.txtJ_func5.Text, "Judge for Scores", false) == 0)
      {
        if (this.JudgeSel_Ca != 0)
          return;
        this.txtJ_func5.Text = "Referee and Judge for Scores";
        this.SetReferee(5);
      }
      else
        this.txtJ_func5.Text = "Judge for Scores";
    }

    private void btnJ6_Click(object sender, EventArgs e)
    {
      if (Operators.CompareString(this.txtJ_func6.Text, "Trial Judge", false) == 0)
        return;
      if (Operators.CompareString(this.txtJ_func6.Text, "Judge for Scores", false) == 0)
      {
        if (this.JudgeSel_Ca != 0)
          return;
        this.txtJ_func6.Text = "Referee and Judge for Scores";
        this.SetReferee(6);
      }
      else
        this.txtJ_func6.Text = "Judge for Scores";
    }

    private void btnJ7_Click(object sender, EventArgs e)
    {
      if (!(Operators.CompareString(this.txtJ_func7.Text, "Non-Judging Referee", false) != 0 & Operators.CompareString(this.txtJ_func7.Text, "Trial Judge", false) != 0))
        return;
      if (Operators.CompareString(this.txtJ_func7.Text, "Judge for Scores", false) == 0)
      {
        if (this.JudgeSel_Ca != 0)
          return;
        this.txtJ_func7.Text = "Referee and Judge for Scores";
        this.SetReferee(7);
      }
      else
        this.txtJ_func7.Text = "Judge for Scores";
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: ClubCompFS.InputJudgesDataDialog
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
    public class InputJudgesDataDialog : Form
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
        [AccessedThroughProperty("lblPC")]
        private Label _lblPC;
        [AccessedThroughProperty("lblDeduction")]
        private Label _lblDeduction;
        [AccessedThroughProperty("EL1")]
        private TextBox _EL1;
        [AccessedThroughProperty("EL2")]
        private TextBox _EL2;
        [AccessedThroughProperty("EL3")]
        private TextBox _EL3;
        [AccessedThroughProperty("EL4")]
        private TextBox _EL4;
        [AccessedThroughProperty("EL5")]
        private TextBox _EL5;
        [AccessedThroughProperty("EL6")]
        private TextBox _EL6;
        [AccessedThroughProperty("EL7")]
        private TextBox _EL7;
        [AccessedThroughProperty("EL8")]
        private TextBox _EL8;
        [AccessedThroughProperty("EL9")]
        private TextBox _EL9;
        [AccessedThroughProperty("EL10")]
        private TextBox _EL10;
        [AccessedThroughProperty("EL11")]
        private TextBox _EL11;
        [AccessedThroughProperty("EL12")]
        private TextBox _EL12;
        [AccessedThroughProperty("EL13")]
        private TextBox _EL13;
        [AccessedThroughProperty("EL14")]
        private TextBox _EL14;
        [AccessedThroughProperty("EL15")]
        private TextBox _EL15;
        [AccessedThroughProperty("txtPC1")]
        private TextBox _txtPC1;
        [AccessedThroughProperty("txtPC2")]
        private TextBox _txtPC2;
        [AccessedThroughProperty("txtPC3")]
        private TextBox _txtPC3;
        [AccessedThroughProperty("txtPC4")]
        private TextBox _txtPC4;
        [AccessedThroughProperty("txtPC5")]
        private TextBox _txtPC5;
        [AccessedThroughProperty("txtDed1")]
        private TextBox _txtDed1;
        [AccessedThroughProperty("txtDed2")]
        private TextBox _txtDed2;
        [AccessedThroughProperty("txtDed3")]
        private TextBox _txtDed3;
        [AccessedThroughProperty("JI1")]
        private TextBox _JI1;
        [AccessedThroughProperty("JI2")]
        private TextBox _JI2;
        [AccessedThroughProperty("JI3")]
        private TextBox _JI3;
        [AccessedThroughProperty("JI4")]
        private TextBox _JI4;
        [AccessedThroughProperty("JI5")]
        private TextBox _JI5;
        [AccessedThroughProperty("JI6")]
        private TextBox _JI6;
        [AccessedThroughProperty("JI7")]
        private TextBox _JI7;
        [AccessedThroughProperty("JI8")]
        private TextBox _JI8;
        [AccessedThroughProperty("JI9")]
        private TextBox _JI9;
        [AccessedThroughProperty("JI10")]
        private TextBox _JI10;
        [AccessedThroughProperty("JI11")]
        private TextBox _JI11;
        [AccessedThroughProperty("JI12")]
        private TextBox _JI12;
        [AccessedThroughProperty("JI13")]
        private TextBox _JI13;
        [AccessedThroughProperty("JI14")]
        private TextBox _JI14;
        [AccessedThroughProperty("JI15")]
        private TextBox _JI15;
        [AccessedThroughProperty("PC1")]
        private TextBox _PC1;
        [AccessedThroughProperty("PC2")]
        private TextBox _PC2;
        [AccessedThroughProperty("PC3")]
        private TextBox _PC3;
        [AccessedThroughProperty("PC4")]
        private TextBox _PC4;
        [AccessedThroughProperty("PC5")]
        private TextBox _PC5;
        [AccessedThroughProperty("chD1")]
        private CheckBox _chD1;
        [AccessedThroughProperty("chD2")]
        private CheckBox _chD2;
        [AccessedThroughProperty("chD3")]
        private CheckBox _chD3;
        [AccessedThroughProperty("txtJudgeNo")]
        private TextBox _txtJudgeNo;
        [AccessedThroughProperty("txtPno")]
        private TextBox _txtPno;
        [AccessedThroughProperty("lblJno")]
        private Label _lblJno;
        private int NoEl;

        public InputJudgesDataDialog()
        {
            this.Load += new EventHandler(this.InputJudgesDataDialog_Load);
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(InputJudgesDataDialog));
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.OK_Button = new Button();
            this.Cancel_Button = new Button();
            this.Label1 = new Label();
            this.lblPC = new Label();
            this.lblDeduction = new Label();
            this.EL1 = new TextBox();
            this.EL2 = new TextBox();
            this.EL3 = new TextBox();
            this.EL4 = new TextBox();
            this.EL5 = new TextBox();
            this.EL6 = new TextBox();
            this.EL7 = new TextBox();
            this.EL8 = new TextBox();
            this.EL9 = new TextBox();
            this.EL10 = new TextBox();
            this.EL11 = new TextBox();
            this.EL12 = new TextBox();
            this.EL13 = new TextBox();
            this.EL14 = new TextBox();
            this.EL15 = new TextBox();
            this.txtPC1 = new TextBox();
            this.txtPC2 = new TextBox();
            this.txtPC3 = new TextBox();
            this.txtPC4 = new TextBox();
            this.txtPC5 = new TextBox();
            this.txtDed1 = new TextBox();
            this.txtDed2 = new TextBox();
            this.txtDed3 = new TextBox();
            this.JI1 = new TextBox();
            this.JI2 = new TextBox();
            this.JI3 = new TextBox();
            this.JI4 = new TextBox();
            this.JI5 = new TextBox();
            this.JI6 = new TextBox();
            this.JI7 = new TextBox();
            this.JI8 = new TextBox();
            this.JI9 = new TextBox();
            this.JI10 = new TextBox();
            this.JI11 = new TextBox();
            this.JI12 = new TextBox();
            this.JI13 = new TextBox();
            this.JI14 = new TextBox();
            this.JI15 = new TextBox();
            this.PC1 = new TextBox();
            this.PC2 = new TextBox();
            this.PC3 = new TextBox();
            this.PC4 = new TextBox();
            this.PC5 = new TextBox();
            this.chD1 = new CheckBox();
            this.chD2 = new CheckBox();
            this.chD3 = new CheckBox();
            this.txtJudgeNo = new TextBox();
            this.txtPno = new TextBox();
            this.lblJno = new Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.TableLayoutPanel1.BackColor = Color.White;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add((Control)this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add((Control)this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.TableLayoutPanel1.Location = new Point(366, 281);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            TableLayoutPanel tableLayoutPanel1 = this.TableLayoutPanel1;
            Size size1 = new Size(146, 29);
            Size size2 = size1;
            tableLayoutPanel1.Size = size2;
            this.TableLayoutPanel1.TabIndex = 0;
            this.OK_Button.Anchor = AnchorStyles.None;
            this.OK_Button.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
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
            this.Cancel_Button.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Cancel_Button.Location = new Point(76, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            Button cancelButton = this.Cancel_Button;
            size1 = new Size(67, 23);
            Size size4 = size1;
            cancelButton.Size = size4;
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new Point(2, 9);
            this.Label1.Name = "Label1";
            Label label1 = this.Label1;
            size1 = new Size(143, 13);
            Size size5 = size1;
            label1.Size = size5;
            this.Label1.TabIndex = 1;
            this.Label1.Text = "EXECUTED ELEMENTS";
            this.lblPC.AutoSize = true;
            this.lblPC.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblPC.Location = new Point(296, 9);
            this.lblPC.Name = "lblPC";
            Label lblPc = this.lblPC;
            size1 = new Size(159, 13);
            Size size6 = size1;
            lblPc.Size = size6;
            this.lblPC.TabIndex = 2;
            this.lblPC.Text = "PROGRAM COMPONENTS";
            this.lblDeduction.AutoSize = true;
            this.lblDeduction.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblDeduction.Location = new Point(296, 149);
            this.lblDeduction.Name = "lblDeduction";
            Label lblDeduction = this.lblDeduction;
            size1 = new Size(88, 13);
            Size size7 = size1;
            lblDeduction.Size = size7;
            this.lblDeduction.TabIndex = 3;
            this.lblDeduction.Text = "DEDUCTIONS";
            this.EL1.BackColor = Color.White;
            this.EL1.Enabled = false;
            this.EL1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL1.Location = new Point(5, 25);
            this.EL1.Name = "EL1";
            this.EL1.ReadOnly = true;
            TextBox el1 = this.EL1;
            size1 = new Size(232, 20);
            Size size8 = size1;
            el1.Size = size8;
            this.EL1.TabIndex = 4;
            this.EL1.Visible = false;
            this.EL2.BackColor = Color.FromArgb(224, 224, 224);
            this.EL2.Enabled = false;
            this.EL2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL2.Location = new Point(5, 45);
            this.EL2.Name = "EL2";
            this.EL2.ReadOnly = true;
            TextBox el2 = this.EL2;
            size1 = new Size(232, 20);
            Size size9 = size1;
            el2.Size = size9;
            this.EL2.TabIndex = 5;
            this.EL2.Visible = false;
            this.EL3.BackColor = Color.White;
            this.EL3.Enabled = false;
            this.EL3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL3.Location = new Point(5, 65);
            this.EL3.Name = "EL3";
            this.EL3.ReadOnly = true;
            TextBox el3 = this.EL3;
            size1 = new Size(232, 20);
            Size size10 = size1;
            el3.Size = size10;
            this.EL3.TabIndex = 6;
            this.EL3.Visible = false;
            this.EL4.BackColor = Color.FromArgb(224, 224, 224);
            this.EL4.Enabled = false;
            this.EL4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL4.Location = new Point(5, 85);
            this.EL4.Name = "EL4";
            this.EL4.ReadOnly = true;
            TextBox el4 = this.EL4;
            size1 = new Size(232, 20);
            Size size11 = size1;
            el4.Size = size11;
            this.EL4.TabIndex = 7;
            this.EL4.Visible = false;
            this.EL5.BackColor = Color.White;
            this.EL5.Enabled = false;
            this.EL5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL5.Location = new Point(5, 105);
            this.EL5.Name = "EL5";
            this.EL5.ReadOnly = true;
            TextBox el5 = this.EL5;
            size1 = new Size(232, 20);
            Size size12 = size1;
            el5.Size = size12;
            this.EL5.TabIndex = 8;
            this.EL5.Visible = false;
            this.EL6.BackColor = Color.FromArgb(224, 224, 224);
            this.EL6.Enabled = false;
            this.EL6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL6.Location = new Point(5, 125);
            this.EL6.Name = "EL6";
            this.EL6.ReadOnly = true;
            TextBox el6 = this.EL6;
            size1 = new Size(232, 20);
            Size size13 = size1;
            el6.Size = size13;
            this.EL6.TabIndex = 9;
            this.EL6.Visible = false;
            this.EL7.BackColor = Color.White;
            this.EL7.Enabled = false;
            this.EL7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL7.Location = new Point(5, 145);
            this.EL7.Name = "EL7";
            this.EL7.ReadOnly = true;
            TextBox el7 = this.EL7;
            size1 = new Size(232, 20);
            Size size14 = size1;
            el7.Size = size14;
            this.EL7.TabIndex = 10;
            this.EL7.Visible = false;
            this.EL8.BackColor = Color.FromArgb(224, 224, 224);
            this.EL8.Enabled = false;
            this.EL8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL8.Location = new Point(5, 165);
            this.EL8.Name = "EL8";
            this.EL8.ReadOnly = true;
            TextBox el8 = this.EL8;
            size1 = new Size(232, 20);
            Size size15 = size1;
            el8.Size = size15;
            this.EL8.TabIndex = 11;
            this.EL8.Visible = false;
            this.EL9.BackColor = Color.White;
            this.EL9.Enabled = false;
            this.EL9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL9.Location = new Point(5, 185);
            this.EL9.Name = "EL9";
            this.EL9.ReadOnly = true;
            TextBox el9 = this.EL9;
            size1 = new Size(232, 20);
            Size size16 = size1;
            el9.Size = size16;
            this.EL9.TabIndex = 12;
            this.EL9.Visible = false;
            this.EL10.BackColor = Color.FromArgb(224, 224, 224);
            this.EL10.Enabled = false;
            this.EL10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL10.Location = new Point(5, 205);
            this.EL10.Name = "EL10";
            this.EL10.ReadOnly = true;
            TextBox el10 = this.EL10;
            size1 = new Size(232, 20);
            Size size17 = size1;
            el10.Size = size17;
            this.EL10.TabIndex = 13;
            this.EL10.Visible = false;
            this.EL11.BackColor = Color.White;
            this.EL11.Enabled = false;
            this.EL11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL11.Location = new Point(5, 225);
            this.EL11.Name = "EL11";
            this.EL11.ReadOnly = true;
            TextBox el11 = this.EL11;
            size1 = new Size(232, 20);
            Size size18 = size1;
            el11.Size = size18;
            this.EL11.TabIndex = 14;
            this.EL11.Visible = false;
            this.EL12.BackColor = Color.FromArgb(224, 224, 224);
            this.EL12.Enabled = false;
            this.EL12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL12.Location = new Point(5, 245);
            this.EL12.Name = "EL12";
            this.EL12.ReadOnly = true;
            TextBox el12 = this.EL12;
            size1 = new Size(232, 20);
            Size size19 = size1;
            el12.Size = size19;
            this.EL12.TabIndex = 15;
            this.EL12.Visible = false;
            this.EL13.BackColor = Color.White;
            this.EL13.Enabled = false;
            this.EL13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL13.Location = new Point(5, 265);
            this.EL13.Name = "EL13";
            this.EL13.ReadOnly = true;
            TextBox el13 = this.EL13;
            size1 = new Size(232, 20);
            Size size20 = size1;
            el13.Size = size20;
            this.EL13.TabIndex = 16;
            this.EL13.Visible = false;
            this.EL14.BackColor = Color.FromArgb(224, 224, 224);
            this.EL14.Enabled = false;
            this.EL14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL14.Location = new Point(5, 285);
            this.EL14.Name = "EL14";
            this.EL14.ReadOnly = true;
            TextBox el14 = this.EL14;
            size1 = new Size(232, 20);
            Size size21 = size1;
            el14.Size = size21;
            this.EL14.TabIndex = 17;
            this.EL14.Visible = false;
            this.EL15.BackColor = Color.White;
            this.EL15.Enabled = false;
            this.EL15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EL15.Location = new Point(5, 305);
            this.EL15.Name = "EL15";
            this.EL15.ReadOnly = true;
            TextBox el15 = this.EL15;
            size1 = new Size(232, 20);
            Size size22 = size1;
            el15.Size = size22;
            this.EL15.TabIndex = 18;
            this.EL15.Visible = false;
            this.txtPC1.BackColor = Color.White;
            this.txtPC1.Enabled = false;
            this.txtPC1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtPC1.Location = new Point(299, 25);
            this.txtPC1.Name = "txtPC1";
            this.txtPC1.ReadOnly = true;
            TextBox txtPc1 = this.txtPC1;
            size1 = new Size(232, 20);
            Size size23 = size1;
            txtPc1.Size = size23;
            this.txtPC1.TabIndex = 19;
            this.txtPC1.Text = "Skating Skills";
            this.txtPC2.BackColor = Color.FromArgb(224, 224, 224);
            this.txtPC2.Enabled = false;
            this.txtPC2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtPC2.Location = new Point(299, 45);
            this.txtPC2.Name = "txtPC2";
            this.txtPC2.ReadOnly = true;
            TextBox txtPc2 = this.txtPC2;
            size1 = new Size(232, 20);
            Size size24 = size1;
            txtPc2.Size = size24;
            this.txtPC2.TabIndex = 20;
            this.txtPC2.Text = "Transistion";
            this.txtPC3.BackColor = Color.White;
            this.txtPC3.Enabled = false;
            this.txtPC3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtPC3.Location = new Point(299, 65);
            this.txtPC3.Name = "txtPC3";
            this.txtPC3.ReadOnly = true;
            TextBox txtPc3 = this.txtPC3;
            size1 = new Size(232, 20);
            Size size25 = size1;
            txtPc3.Size = size25;
            this.txtPC3.TabIndex = 21;
            this.txtPC3.Text = "Performance/Execution";
            this.txtPC4.BackColor = Color.FromArgb(224, 224, 224);
            this.txtPC4.Enabled = false;
            this.txtPC4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtPC4.Location = new Point(299, 85);
            this.txtPC4.Name = "txtPC4";
            this.txtPC4.ReadOnly = true;
            TextBox txtPc4 = this.txtPC4;
            size1 = new Size(232, 20);
            Size size26 = size1;
            txtPc4.Size = size26;
            this.txtPC4.TabIndex = 22;
            this.txtPC4.Text = "Composition";
            this.txtPC5.BackColor = Color.White;
            this.txtPC5.Enabled = false;
            this.txtPC5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtPC5.Location = new Point(299, 105);
            this.txtPC5.Name = "txtPC5";
            this.txtPC5.ReadOnly = true;
            TextBox txtPc5 = this.txtPC5;
            size1 = new Size(232, 20);
            Size size27 = size1;
            txtPc5.Size = size27;
            this.txtPC5.TabIndex = 23;
            this.txtPC5.Text = "Interpretation";
            this.txtDed1.BackColor = Color.White;
            this.txtDed1.Enabled = false;
            this.txtDed1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtDed1.Location = new Point(299, 165);
            this.txtDed1.Name = "txtDed1";
            this.txtDed1.ReadOnly = true;
            TextBox txtDed1 = this.txtDed1;
            size1 = new Size(232, 20);
            Size size28 = size1;
            txtDed1.Size = size28;
            this.txtDed1.TabIndex = 24;
            this.txtDed1.Text = "Costume Violation";
            this.txtDed2.BackColor = Color.FromArgb(224, 224, 224);
            this.txtDed2.Enabled = false;
            this.txtDed2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtDed2.Location = new Point(299, 185);
            this.txtDed2.Name = "txtDed2";
            this.txtDed2.ReadOnly = true;
            TextBox txtDed2 = this.txtDed2;
            size1 = new Size(232, 20);
            Size size29 = size1;
            txtDed2.Size = size29;
            this.txtDed2.TabIndex = 25;
            this.txtDed2.Text = "Props";
            this.txtDed3.BackColor = Color.White;
            this.txtDed3.Enabled = false;
            this.txtDed3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtDed3.Location = new Point(299, 205);
            this.txtDed3.Name = "txtDed3";
            this.txtDed3.ReadOnly = true;
            TextBox txtDed3 = this.txtDed3;
            size1 = new Size(232, 20);
            Size size30 = size1;
            txtDed3.Size = size30;
            this.txtDed3.TabIndex = 26;
            this.txtDed3.Text = "Music Violation";
            this.txtDed3.Visible = false;
            this.JI1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI1.Location = new Point(243, 25);
            this.JI1.MaxLength = 2;
            this.JI1.Name = "JI1";
            TextBox ji1 = this.JI1;
            size1 = new Size(50, 20);
            Size size31 = size1;
            ji1.Size = size31;
            this.JI1.TabIndex = 1;
            this.JI1.TextAlign = HorizontalAlignment.Center;
            this.JI1.Visible = false;
            this.JI2.BackColor = Color.FromArgb(224, 224, 224);
            this.JI2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI2.Location = new Point(243, 45);
            this.JI2.MaxLength = 2;
            this.JI2.Name = "JI2";
            TextBox ji2 = this.JI2;
            size1 = new Size(50, 20);
            Size size32 = size1;
            ji2.Size = size32;
            this.JI2.TabIndex = 2;
            this.JI2.TextAlign = HorizontalAlignment.Center;
            this.JI2.Visible = false;
            this.JI3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI3.Location = new Point(243, 65);
            this.JI3.MaxLength = 2;
            this.JI3.Name = "JI3";
            TextBox ji3 = this.JI3;
            size1 = new Size(50, 20);
            Size size33 = size1;
            ji3.Size = size33;
            this.JI3.TabIndex = 3;
            this.JI3.TextAlign = HorizontalAlignment.Center;
            this.JI3.Visible = false;
            this.JI4.BackColor = Color.FromArgb(224, 224, 224);
            this.JI4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI4.Location = new Point(243, 85);
            this.JI4.MaxLength = 2;
            this.JI4.Name = "JI4";
            TextBox ji4 = this.JI4;
            size1 = new Size(50, 20);
            Size size34 = size1;
            ji4.Size = size34;
            this.JI4.TabIndex = 4;
            this.JI4.TextAlign = HorizontalAlignment.Center;
            this.JI4.Visible = false;
            this.JI5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI5.Location = new Point(243, 105);
            this.JI5.MaxLength = 2;
            this.JI5.Name = "JI5";
            TextBox ji5 = this.JI5;
            size1 = new Size(50, 20);
            Size size35 = size1;
            ji5.Size = size35;
            this.JI5.TabIndex = 5;
            this.JI5.TextAlign = HorizontalAlignment.Center;
            this.JI5.Visible = false;
            this.JI6.BackColor = Color.FromArgb(224, 224, 224);
            this.JI6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI6.Location = new Point(243, 125);
            this.JI6.MaxLength = 2;
            this.JI6.Name = "JI6";
            TextBox ji6 = this.JI6;
            size1 = new Size(50, 20);
            Size size36 = size1;
            ji6.Size = size36;
            this.JI6.TabIndex = 6;
            this.JI6.TextAlign = HorizontalAlignment.Center;
            this.JI6.Visible = false;
            this.JI7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI7.Location = new Point(243, 145);
            this.JI7.MaxLength = 2;
            this.JI7.Name = "JI7";
            TextBox ji7 = this.JI7;
            size1 = new Size(50, 20);
            Size size37 = size1;
            ji7.Size = size37;
            this.JI7.TabIndex = 7;
            this.JI7.TextAlign = HorizontalAlignment.Center;
            this.JI7.Visible = false;
            this.JI8.BackColor = Color.FromArgb(224, 224, 224);
            this.JI8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI8.Location = new Point(243, 165);
            this.JI8.MaxLength = 2;
            this.JI8.Name = "JI8";
            TextBox ji8 = this.JI8;
            size1 = new Size(50, 20);
            Size size38 = size1;
            ji8.Size = size38;
            this.JI8.TabIndex = 8;
            this.JI8.TextAlign = HorizontalAlignment.Center;
            this.JI8.Visible = false;
            this.JI9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI9.Location = new Point(243, 185);
            this.JI9.MaxLength = 2;
            this.JI9.Name = "JI9";
            TextBox ji9 = this.JI9;
            size1 = new Size(50, 20);
            Size size39 = size1;
            ji9.Size = size39;
            this.JI9.TabIndex = 9;
            this.JI9.TextAlign = HorizontalAlignment.Center;
            this.JI9.Visible = false;
            this.JI10.BackColor = Color.FromArgb(224, 224, 224);
            this.JI10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI10.Location = new Point(243, 205);
            this.JI10.MaxLength = 2;
            this.JI10.Name = "JI10";
            TextBox ji10 = this.JI10;
            size1 = new Size(50, 20);
            Size size40 = size1;
            ji10.Size = size40;
            this.JI10.TabIndex = 10;
            this.JI10.TextAlign = HorizontalAlignment.Center;
            this.JI10.Visible = false;
            this.JI11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI11.Location = new Point(243, 225);
            this.JI11.MaxLength = 2;
            this.JI11.Name = "JI11";
            TextBox ji11 = this.JI11;
            size1 = new Size(50, 20);
            Size size41 = size1;
            ji11.Size = size41;
            this.JI11.TabIndex = 11;
            this.JI11.TextAlign = HorizontalAlignment.Center;
            this.JI11.Visible = false;
            this.JI12.BackColor = Color.FromArgb(224, 224, 224);
            this.JI12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI12.Location = new Point(243, 245);
            this.JI12.MaxLength = 2;
            this.JI12.Name = "JI12";
            TextBox ji12 = this.JI12;
            size1 = new Size(50, 20);
            Size size42 = size1;
            ji12.Size = size42;
            this.JI12.TabIndex = 12;
            this.JI12.TextAlign = HorizontalAlignment.Center;
            this.JI12.Visible = false;
            this.JI13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI13.Location = new Point(243, 265);
            this.JI13.MaxLength = 2;
            this.JI13.Name = "JI13";
            TextBox ji13 = this.JI13;
            size1 = new Size(50, 20);
            Size size43 = size1;
            ji13.Size = size43;
            this.JI13.TabIndex = 13;
            this.JI13.TextAlign = HorizontalAlignment.Center;
            this.JI13.Visible = false;
            this.JI14.BackColor = Color.FromArgb(224, 224, 224);
            this.JI14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI14.Location = new Point(243, 285);
            this.JI14.MaxLength = 2;
            this.JI14.Name = "JI14";
            TextBox ji14 = this.JI14;
            size1 = new Size(50, 20);
            Size size44 = size1;
            ji14.Size = size44;
            this.JI14.TabIndex = 14;
            this.JI14.TextAlign = HorizontalAlignment.Center;
            this.JI14.Visible = false;
            this.JI15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JI15.Location = new Point(243, 305);
            this.JI15.MaxLength = 2;
            this.JI15.Name = "JI15";
            TextBox ji15 = this.JI15;
            size1 = new Size(50, 20);
            Size size45 = size1;
            ji15.Size = size45;
            this.JI15.TabIndex = 15;
            this.JI15.TextAlign = HorizontalAlignment.Center;
            this.JI15.Visible = false;
            this.PC1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.PC1.Location = new Point(537, 25);
            this.PC1.Name = "PC1";
            TextBox pc1 = this.PC1;
            size1 = new Size(50, 20);
            Size size46 = size1;
            pc1.Size = size46;
            this.PC1.TabIndex = 16;
            this.PC1.TextAlign = HorizontalAlignment.Center;
            this.PC2.BackColor = Color.FromArgb(224, 224, 224);
            this.PC2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.PC2.Location = new Point(537, 45);
            this.PC2.Name = "PC2";
            TextBox pc2 = this.PC2;
            size1 = new Size(50, 20);
            Size size47 = size1;
            pc2.Size = size47;
            this.PC2.TabIndex = 17;
            this.PC2.TextAlign = HorizontalAlignment.Center;
            this.PC3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.PC3.Location = new Point(537, 65);
            this.PC3.Name = "PC3";
            TextBox pc3 = this.PC3;
            size1 = new Size(50, 20);
            Size size48 = size1;
            pc3.Size = size48;
            this.PC3.TabIndex = 18;
            this.PC3.TextAlign = HorizontalAlignment.Center;
            this.PC4.BackColor = Color.FromArgb(224, 224, 224);
            this.PC4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.PC4.Location = new Point(537, 85);
            this.PC4.Name = "PC4";
            TextBox pc4 = this.PC4;
            size1 = new Size(50, 20);
            Size size49 = size1;
            pc4.Size = size49;
            this.PC4.TabIndex = 19;
            this.PC4.TextAlign = HorizontalAlignment.Center;
            this.PC5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.PC5.Location = new Point(537, 105);
            this.PC5.Name = "PC5";
            TextBox pc5 = this.PC5;
            size1 = new Size(50, 20);
            Size size50 = size1;
            pc5.Size = size50;
            this.PC5.TabIndex = 20;
            this.PC5.TextAlign = HorizontalAlignment.Center;
            this.chD1.AutoSize = true;
            this.chD1.Location = new Point(550, 168);
            this.chD1.Name = "chD1";
            CheckBox chD1 = this.chD1;
            size1 = new Size(15, 14);
            Size size51 = size1;
            chD1.Size = size51;
            this.chD1.TabIndex = 21;
            this.chD1.UseVisualStyleBackColor = true;
            this.chD2.AutoSize = true;
            this.chD2.Location = new Point(550, 188);
            this.chD2.Name = "chD2";
            CheckBox chD2 = this.chD2;
            size1 = new Size(15, 14);
            Size size52 = size1;
            chD2.Size = size52;
            this.chD2.TabIndex = 22;
            this.chD2.UseVisualStyleBackColor = true;
            this.chD3.AutoSize = true;
            this.chD3.Location = new Point(550, 208);
            this.chD3.Name = "chD3";
            CheckBox chD3 = this.chD3;
            size1 = new Size(15, 14);
            Size size53 = size1;
            chD3.Size = size53;
            this.chD3.TabIndex = 23;
            this.chD3.UseVisualStyleBackColor = true;
            this.chD3.Visible = false;
            this.txtJudgeNo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtJudgeNo.Location = new Point(536, 305);
            this.txtJudgeNo.Name = "txtJudgeNo";
            TextBox txtJudgeNo = this.txtJudgeNo;
            size1 = new Size(50, 20);
            Size size54 = size1;
            txtJudgeNo.Size = size54;
            this.txtJudgeNo.TabIndex = 50;
            this.txtJudgeNo.Visible = false;
            this.txtPno.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtPno.Location = new Point(299, 305);
            this.txtPno.Name = "txtPno";
            TextBox txtPno = this.txtPno;
            size1 = new Size(50, 20);
            Size size55 = size1;
            txtPno.Size = size55;
            this.txtPno.TabIndex = 51;
            this.txtPno.Visible = false;
            this.lblJno.AutoSize = true;
            this.lblJno.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblJno.Location = new Point(240, 9);
            this.lblJno.Name = "lblJno";
            Label lblJno = this.lblJno;
            size1 = new Size(45, 13);
            Size size56 = size1;
            lblJno.Size = size56;
            this.lblJno.TabIndex = 52;
            this.lblJno.Text = "Label2";
            this.AcceptButton = (IButtonControl)this.OK_Button;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb((int)byte.MaxValue, 192, 128);
            this.CancelButton = (IButtonControl)this.Cancel_Button;
            size1 = new Size(593, 328);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.lblJno);
            this.Controls.Add((Control)this.txtPno);
            this.Controls.Add((Control)this.txtJudgeNo);
            this.Controls.Add((Control)this.chD3);
            this.Controls.Add((Control)this.chD2);
            this.Controls.Add((Control)this.chD1);
            this.Controls.Add((Control)this.PC5);
            this.Controls.Add((Control)this.PC4);
            this.Controls.Add((Control)this.PC3);
            this.Controls.Add((Control)this.PC2);
            this.Controls.Add((Control)this.PC1);
            this.Controls.Add((Control)this.JI15);
            this.Controls.Add((Control)this.JI14);
            this.Controls.Add((Control)this.JI13);
            this.Controls.Add((Control)this.JI12);
            this.Controls.Add((Control)this.JI11);
            this.Controls.Add((Control)this.JI10);
            this.Controls.Add((Control)this.JI9);
            this.Controls.Add((Control)this.JI8);
            this.Controls.Add((Control)this.JI7);
            this.Controls.Add((Control)this.JI6);
            this.Controls.Add((Control)this.JI5);
            this.Controls.Add((Control)this.JI4);
            this.Controls.Add((Control)this.JI3);
            this.Controls.Add((Control)this.JI2);
            this.Controls.Add((Control)this.JI1);
            this.Controls.Add((Control)this.txtDed3);
            this.Controls.Add((Control)this.txtDed2);
            this.Controls.Add((Control)this.txtDed1);
            this.Controls.Add((Control)this.txtPC5);
            this.Controls.Add((Control)this.txtPC4);
            this.Controls.Add((Control)this.txtPC3);
            this.Controls.Add((Control)this.txtPC2);
            this.Controls.Add((Control)this.txtPC1);
            this.Controls.Add((Control)this.EL15);
            this.Controls.Add((Control)this.EL14);
            this.Controls.Add((Control)this.EL13);
            this.Controls.Add((Control)this.EL12);
            this.Controls.Add((Control)this.EL11);
            this.Controls.Add((Control)this.EL10);
            this.Controls.Add((Control)this.EL9);
            this.Controls.Add((Control)this.EL8);
            this.Controls.Add((Control)this.EL7);
            this.Controls.Add((Control)this.EL6);
            this.Controls.Add((Control)this.EL5);
            this.Controls.Add((Control)this.EL4);
            this.Controls.Add((Control)this.EL3);
            this.Controls.Add((Control)this.EL2);
            this.Controls.Add((Control)this.EL1);
            this.Controls.Add((Control)this.lblDeduction);
            this.Controls.Add((Control)this.lblPC);
            this.Controls.Add((Control)this.Label1);
            this.Controls.Add((Control)this.TableLayoutPanel1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(InputJudgesDataDialog);
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "INPUT JUDGES DATA";
            this.TopMost = true;
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual TableLayoutPanel TableLayoutPanel1
        {
            get => this._TableLayoutPanel1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._TableLayoutPanel1 = value;
        }

        internal virtual Button OK_Button
        {
            get => this._OK_Button;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
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
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label1 = value;
        }

        internal virtual Label lblPC
        {
            get => this._lblPC;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblPC = value;
        }

        internal virtual Label lblDeduction
        {
            get => this._lblDeduction;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblDeduction = value;
        }

        internal virtual TextBox EL1
        {
            get => this._EL1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL1 = value;
        }

        internal virtual TextBox EL2
        {
            get => this._EL2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL2 = value;
        }

        internal virtual TextBox EL3
        {
            get => this._EL3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL3 = value;
        }

        internal virtual TextBox EL4
        {
            get => this._EL4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL4 = value;
        }

        internal virtual TextBox EL5
        {
            get => this._EL5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL5 = value;
        }

        internal virtual TextBox EL6
        {
            get => this._EL6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL6 = value;
        }

        internal virtual TextBox EL7
        {
            get => this._EL7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL7 = value;
        }

        internal virtual TextBox EL8
        {
            get => this._EL8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL8 = value;
        }

        internal virtual TextBox EL9
        {
            get => this._EL9;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL9 = value;
        }

        internal virtual TextBox EL10
        {
            get => this._EL10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL10 = value;
        }

        internal virtual TextBox EL11
        {
            get => this._EL11;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL11 = value;
        }

        internal virtual TextBox EL12
        {
            get => this._EL12;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL12 = value;
        }

        internal virtual TextBox EL13
        {
            get => this._EL13;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL13 = value;
        }

        internal virtual TextBox EL14
        {
            get => this._EL14;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL14 = value;
        }

        internal virtual TextBox EL15
        {
            get => this._EL15;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EL15 = value;
        }

        internal virtual TextBox txtPC1
        {
            get => this._txtPC1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtPC1 = value;
        }

        internal virtual TextBox txtPC2
        {
            get => this._txtPC2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtPC2 = value;
        }

        internal virtual TextBox txtPC3
        {
            get => this._txtPC3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtPC3 = value;
        }

        internal virtual TextBox txtPC4
        {
            get => this._txtPC4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtPC4 = value;
        }

        internal virtual TextBox txtPC5
        {
            get => this._txtPC5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtPC5 = value;
        }

        internal virtual TextBox txtDed1
        {
            get => this._txtDed1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtDed1 = value;
        }

        internal virtual TextBox txtDed2
        {
            get => this._txtDed2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtDed2 = value;
        }

        internal virtual TextBox txtDed3
        {
            get => this._txtDed3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtDed3 = value;
        }

        internal virtual TextBox JI1
        {
            get => this._JI1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI1_KeyPress);
                if (this._JI1 != null)
                    this._JI1.KeyPress -= pressEventHandler;
                this._JI1 = value;
                if (this._JI1 == null)
                    return;
                this._JI1.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox JI2
        {
            get => this._JI2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI2_KeyPress);
                if (this._JI2 != null)
                    this._JI2.KeyPress -= pressEventHandler;
                this._JI2 = value;
                if (this._JI2 == null)
                    return;
                this._JI2.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox JI3
        {
            get => this._JI3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI3_KeyPress);
                if (this._JI3 != null)
                    this._JI3.KeyPress -= pressEventHandler;
                this._JI3 = value;
                if (this._JI3 == null)
                    return;
                this._JI3.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox JI4
        {
            get => this._JI4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI4_KeyPress);
                if (this._JI4 != null)
                    this._JI4.KeyPress -= pressEventHandler;
                this._JI4 = value;
                if (this._JI4 == null)
                    return;
                this._JI4.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox JI5
        {
            get => this._JI5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI5_KeyPress);
                if (this._JI5 != null)
                    this._JI5.KeyPress -= pressEventHandler;
                this._JI5 = value;
                if (this._JI5 == null)
                    return;
                this._JI5.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox JI6
        {
            get => this._JI6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI6_KeyPress);
                if (this._JI6 != null)
                    this._JI6.KeyPress -= pressEventHandler;
                this._JI6 = value;
                if (this._JI6 == null)
                    return;
                this._JI6.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox JI7
        {
            get => this._JI7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI7_KeyPress);
                if (this._JI7 != null)
                    this._JI7.KeyPress -= pressEventHandler;
                this._JI7 = value;
                if (this._JI7 == null)
                    return;
                this._JI7.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox JI8
        {
            get => this._JI8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI8_KeyPress);
                if (this._JI8 != null)
                    this._JI8.KeyPress -= pressEventHandler;
                this._JI8 = value;
                if (this._JI8 == null)
                    return;
                this._JI8.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox JI9
        {
            get => this._JI9;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI9_KeyPress);
                if (this._JI9 != null)
                    this._JI9.KeyPress -= pressEventHandler;
                this._JI9 = value;
                if (this._JI9 == null)
                    return;
                this._JI9.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox JI10
        {
            get => this._JI10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI10_KeyPress);
                if (this._JI10 != null)
                    this._JI10.KeyPress -= pressEventHandler;
                this._JI10 = value;
                if (this._JI10 == null)
                    return;
                this._JI10.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox JI11
        {
            get => this._JI11;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI11_KeyPress);
                if (this._JI11 != null)
                    this._JI11.KeyPress -= pressEventHandler;
                this._JI11 = value;
                if (this._JI11 == null)
                    return;
                this._JI11.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox JI12
        {
            get => this._JI12;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI12_KeyPress);
                if (this._JI12 != null)
                    this._JI12.KeyPress -= pressEventHandler;
                this._JI12 = value;
                if (this._JI12 == null)
                    return;
                this._JI12.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox JI13
        {
            get => this._JI13;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI13_KeyPress);
                if (this._JI13 != null)
                    this._JI13.KeyPress -= pressEventHandler;
                this._JI13 = value;
                if (this._JI13 == null)
                    return;
                this._JI13.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox JI14
        {
            get => this._JI14;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI14_KeyPress);
                if (this._JI14 != null)
                    this._JI14.KeyPress -= pressEventHandler;
                this._JI14 = value;
                if (this._JI14 == null)
                    return;
                this._JI14.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox JI15
        {
            get => this._JI15;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JI15_KeyPress);
                if (this._JI15 != null)
                    this._JI15.KeyPress -= pressEventHandler;
                this._JI15 = value;
                if (this._JI15 == null)
                    return;
                this._JI15.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox PC1
        {
            get => this._PC1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.PC1_Leave);
                if (this._PC1 != null)
                    this._PC1.Leave -= eventHandler;
                this._PC1 = value;
                if (this._PC1 == null)
                    return;
                this._PC1.Leave += eventHandler;
            }
        }

        internal virtual TextBox PC2
        {
            get => this._PC2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.PC2_Leave);
                if (this._PC2 != null)
                    this._PC2.Leave -= eventHandler;
                this._PC2 = value;
                if (this._PC2 == null)
                    return;
                this._PC2.Leave += eventHandler;
            }
        }

        internal virtual TextBox PC3
        {
            get => this._PC3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.PC3_Leave);
                if (this._PC3 != null)
                    this._PC3.Leave -= eventHandler;
                this._PC3 = value;
                if (this._PC3 == null)
                    return;
                this._PC3.Leave += eventHandler;
            }
        }

        internal virtual TextBox PC4
        {
            get => this._PC4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.PC4_Leave);
                if (this._PC4 != null)
                    this._PC4.Leave -= eventHandler;
                this._PC4 = value;
                if (this._PC4 == null)
                    return;
                this._PC4.Leave += eventHandler;
            }
        }

        internal virtual TextBox PC5
        {
            get => this._PC5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.PC5_Leave);
                if (this._PC5 != null)
                    this._PC5.Leave -= eventHandler;
                this._PC5 = value;
                if (this._PC5 == null)
                    return;
                this._PC5.Leave += eventHandler;
            }
        }

        internal virtual CheckBox chD1
        {
            get => this._chD1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._chD1 = value;
        }

        internal virtual CheckBox chD2
        {
            get => this._chD2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._chD2 = value;
        }

        internal virtual CheckBox chD3
        {
            get => this._chD3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._chD3 = value;
        }

        internal virtual TextBox txtJudgeNo
        {
            get => this._txtJudgeNo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtJudgeNo = value;
        }

        internal virtual TextBox txtPno
        {
            get => this._txtPno;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtPno = value;
        }

        internal virtual Label lblJno
        {
            get => this._lblJno;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblJno = value;
        }

        private void InputJudgesDataDialog_Load(object sender, EventArgs e)
        {
            this.Top = MyProject.Forms.Form4.Top;
            this.Left = checked((int)Math.Round(unchecked((double)MyProject.Forms.Form4.Left + (double)MyProject.Forms.Form4.Width / 2.0 - (double)this.Width / 2.0)));
            this.TopMost = true;
            this.Text = "INPUT JUDGES DATA - " + Module1.Vek[Module1.PNo].Name.FName + " " + Module1.Vek[Module1.PNo].Name.LName;
            this.JudgeManualInput();
            this.JI1.Select();
        }

        private void JudgeManualInput()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 0;
                ProjectData.ClearProjectError();
                num1 = 2;
                InputJudgesDataDialog dialog10 = this;
                string segment1 = Module1.Segment;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    this.NoEl = 1;
                    while (Strings.Len(Module1.Vek[Conversions.ToInteger(this.txtPno.Text)].SSS_Seg1[this.NoEl]) != 0)
                    {
                        checked { ++this.NoEl; }
                        if (this.NoEl > 15)
                            break;
                    }
                }
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                {
                    this.NoEl = 1;
                    while (Strings.Len(Module1.Vek[Conversions.ToInteger(this.txtPno.Text)].SSS_Seg2[this.NoEl]) != 0)
                    {
                        checked { ++this.NoEl; }
                        if (this.NoEl > 15)
                            break;
                    }
                }
                checked { --this.NoEl; }
                this.lblJno.Text = "Judge" + this.txtJudgeNo.Text;
                int noEl = this.NoEl;
                int index1 = 1;
                while (index1 <= noEl)
                {
                    string key1 = "EL" + Strings.Trim(Conversions.ToString(index1));
                    string key2 = "JI" + Strings.Trim(Conversions.ToString(index1));
                    string segment2 = Module1.Segment;
                    if (Operators.CompareString(segment2, "Seg1", false) == 0)
                    {
                        dialog10.Controls[key1].Text = Strings.Trim(Conversions.ToString(index1)) + "  " + Module1.Vek[Conversions.ToInteger(this.txtPno.Text)].SSS_Seg1[index1];
                        dialog10.Controls[key2].Text = Conversions.ToString(Module1.Vek[Conversions.ToInteger(this.txtPno.Text)].J_Seg1.EE[index1, Conversions.ToInteger(this.txtJudgeNo.Text)]);
                        dialog10.Controls[key1].Visible = true;
                        dialog10.Controls[key2].Visible = true;
                    }
                    else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                    {
                        dialog10.Controls[key1].Text = Strings.Trim(Conversions.ToString(index1)) + "  " + Module1.Vek[Conversions.ToInteger(this.txtPno.Text)].SSS_Seg2[index1];
                        dialog10.Controls[key2].Text = Conversions.ToString(Module1.Vek[Conversions.ToInteger(this.txtPno.Text)].J_Seg2.EE[index1, Conversions.ToInteger(this.txtJudgeNo.Text)]);
                        dialog10.Controls[key1].Visible = true;
                        dialog10.Controls[key2].Visible = true;
                    }
                    checked { ++index1; }
                }
                int index2 = 1;
                do
                {
                    string key3 = "PC" + Strings.Trim(Conversions.ToString(index2));
                    string key4 = "txtPC" + Strings.Trim(Conversions.ToString(index2));
                    string segment3 = Module1.Segment;
                    if (Operators.CompareString(segment3, "Seg1", false) == 0)
                    {
                        if (Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[index2] > 0.0)
                        {
                            dialog10.Controls[key3].Visible = true;
                            dialog10.Controls[key4].Visible = true;
                        }
                        else
                        {
                            dialog10.Controls[key3].Visible = false;
                            dialog10.Controls[key4].Visible = false;
                        }
                        dialog10.Controls[key3].Text = Strings.Format((object)Module1.Vek[Conversions.ToInteger(this.txtPno.Text)].J_Seg1.PC[index2, Conversions.ToInteger(this.txtJudgeNo.Text)], "0.00");
                    }
                    else if (Operators.CompareString(segment3, "Seg2", false) == 0)
                    {
                        if (Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[index2] > 0.0)
                        {
                            dialog10.Controls[key3].Visible = true;
                            dialog10.Controls[key4].Visible = true;
                        }
                        else
                        {
                            dialog10.Controls[key3].Visible = false;
                            dialog10.Controls[key4].Visible = false;
                        }
                        dialog10.Controls[key3].Text = Strings.Format((object)Module1.Vek[Conversions.ToInteger(this.txtPno.Text)].J_Seg2.PC[index2, Conversions.ToInteger(this.txtJudgeNo.Text)], "0.00");
                    }
                    checked { ++index2; }
                }
                while (index2 <= 5);
                string segment4 = Module1.Segment;
                if (Operators.CompareString(segment4, "Seg1", false) == 0)
                    num3 = checked((int)Module1.Vek[Module1.PNo].J_Seg1.Deduction[Conversions.ToInteger(this.txtJudgeNo.Text)]);
                else if (Operators.CompareString(segment4, "Seg2", false) == 0)
                    num3 = checked((int)Module1.Vek[Module1.PNo].J_Seg2.Deduction[Conversions.ToInteger(this.txtJudgeNo.Text)]);
                if (num3 >= 4)
                {
                    this.chD3.Checked = true;
                    checked { num3 -= 4; }
                }
                else
                    this.chD3.Checked = false;
                if (num3 >= 2)
                {
                    this.chD2.Checked = true;
                    checked { num3 -= 2; }
                }
                else
                    this.chD2.Checked = false;
                if (num3 >= 1)
                {
                    this.chD1.Checked = true;
                    int num4 = checked(num3 - 1);
                    goto label_46;
                }
                else
                {
                    this.chD1.Checked = false;
                    goto label_46;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("InputJudgesDataDialog, JudgeManualInput - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_46:
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
                ProjectData.ClearProjectError();
                num1 = 2;
                InputJudgesDataDialog dialog10 = this;
                int noEl = this.NoEl;
                int index1 = 1;
                while (index1 <= noEl)
                {
                    string str = "EL" + Strings.Trim(Conversions.ToString(index1));
                    string key = "JI" + Strings.Trim(Conversions.ToString(index1));
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                        Module1.Vek[Conversions.ToInteger(this.txtPno.Text)].J_Seg1.EE[index1, Conversions.ToInteger(this.txtJudgeNo.Text)] = Conversions.ToInteger(dialog10.Controls[key].Text);
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                        Module1.Vek[Conversions.ToInteger(this.txtPno.Text)].J_Seg2.EE[index1, Conversions.ToInteger(this.txtJudgeNo.Text)] = Conversions.ToInteger(dialog10.Controls[key].Text);
                    checked { ++index1; }
                }
                int index2 = 1;
                do
                {
                    string key = "PC" + Strings.Trim(Conversions.ToString(index2));
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                        Module1.Vek[Conversions.ToInteger(this.txtPno.Text)].J_Seg1.PC[index2, Conversions.ToInteger(this.txtJudgeNo.Text)] = Conversions.ToDouble(dialog10.Controls[key].Text);
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                        Module1.Vek[Conversions.ToInteger(this.txtPno.Text)].J_Seg2.PC[index2, Conversions.ToInteger(this.txtJudgeNo.Text)] = Conversions.ToDouble(dialog10.Controls[key].Text);
                    checked { ++index2; }
                }
                while (index2 <= 5);
                int num3 = !this.chD1.Checked ? 0 : 1;
                int num4 = !this.chD2.Checked ? 0 : 2;
                string segment1 = Module1.Segment;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                    Module1.Vek[Module1.PNo].J_Seg1.Deduction[Conversions.ToInteger(this.txtJudgeNo.Text)] = (long)checked(num3 + num4);
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                    Module1.Vek[Module1.PNo].J_Seg2.Deduction[Conversions.ToInteger(this.txtJudgeNo.Text)] = (long)checked(num3 + num4);
                this.DialogResult = DialogResult.OK;
                this.Close();
                int rowDed = 0;
                Module1.CreateJudgesDetails(0, ref rowDed);
                MyProject.Forms.Form4.ShowJD(rowDed);
                MyProject.Forms.Form4.Show();
                if (Module1.WorkMode == 3)
                {
                    Module1.SaveCategoryFile(Module1.CategoryFileName);
                    goto label_25;
                }
                else
                    goto label_25;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("InputJudgesDataDialog, JudgeManualInput - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_25:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void JI1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void JI2_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void JI3_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void JI4_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void JI5_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void JI6_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void JI7_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void JI8_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void JI9_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void JI10_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void JI11_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void JI12_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void JI13_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void JI14_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void JI15_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\b':
                case '-':
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void PCtest(int no)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                InputJudgesDataDialog dialog10 = this;
                num3 = 3;
                string key = "PC" + Strings.Trim(Conversions.ToString(no));
                num3 = 4;
                if (!Versioned.IsNumeric((object)dialog10.Controls[key].Text) | Conversion.Val(dialog10.Controls[key].Text) < 0.0 | Conversion.Val(dialog10.Controls[key].Text) > 10.0)
                {
                    num3 = 5;
                    int num4 = (int)Interaction.MsgBox((object)"You Must Enter a number between 0-10!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    num3 = 6;
                    dialog10.Controls[key].Text = "";
                    num3 = 7;
                    dialog10.Controls[key].Select();
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void PC1_Leave(object sender, EventArgs e)
        {
            string Expression = this.PC1.Text.Replace(".", ",");
            if (!Versioned.IsNumeric((object)Expression))
            {
                int num = (int)Interaction.MsgBox((object)"You Must Enter a number between 0-10!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                this.PC1.Text = "0";
            }
            else
            {
                this.PC1.Text = Strings.Format((object)(Conversion.Int((Conversions.ToDouble(Expression) + 0.125) / 0.25) / 4.0), "0.00");
                this.PCtest(1);
            }
        }

        private void PC2_Leave(object sender, EventArgs e)
        {
            string Expression = this.PC2.Text.Replace(".", ",");
            if (!Versioned.IsNumeric((object)Expression))
            {
                int num = (int)Interaction.MsgBox((object)"You Must Enter a number between 0-10!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                this.PC2.Text = "0";
            }
            else
            {
                this.PC2.Text = Strings.Format((object)(Conversion.Int((Conversions.ToDouble(Expression) + 0.125) / 0.25) / 4.0), "0.00");
                this.PCtest(2);
            }
        }

        private void PC3_Leave(object sender, EventArgs e)
        {
            string Expression = this.PC3.Text.Replace(".", ",");
            if (!Versioned.IsNumeric((object)Expression))
            {
                int num = (int)Interaction.MsgBox((object)"You Must Enter a number between 0-10!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                this.PC3.Text = "0";
            }
            else
            {
                this.PC3.Text = Strings.Format((object)(Conversion.Int((Conversions.ToDouble(Expression) + 0.125) / 0.25) / 4.0), "0.00");
                this.PCtest(3);
            }
        }

        private void PC4_Leave(object sender, EventArgs e)
        {
            string Expression = this.PC4.Text.Replace(".", ",");
            if (!Versioned.IsNumeric((object)Expression))
            {
                int num = (int)Interaction.MsgBox((object)"You Must Enter a number between 0-10!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                this.PC4.Text = "0";
            }
            else
            {
                this.PC4.Text = Strings.Format((object)(Conversion.Int((Conversions.ToDouble(Expression) + 0.125) / 0.25) / 4.0), "0.00");
                this.PCtest(4);
            }
        }

        private void PC5_Leave(object sender, EventArgs e)
        {
            string Expression = this.PC5.Text.Replace(".", ",");
            if (!Versioned.IsNumeric((object)Expression))
            {
                int num = (int)Interaction.MsgBox((object)"You Must Enter a number between 0-10!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                this.PC5.Text = "0";
            }
            else
            {
                this.PC5.Text = Strings.Format((object)(Conversion.Int((Conversions.ToDouble(Expression) + 0.125) / 0.25) / 4.0), "0.00");
                this.PCtest(5);
            }
        }
    }
}

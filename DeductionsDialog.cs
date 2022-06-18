// Decompiled with JetBrains decompiler
// Type: ClubCompFS.DeductionsDialog
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
    public class DeductionsDialog : Form
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
        [AccessedThroughProperty("DedLabel4")]
        private TextBox _DedLabel4;
        [AccessedThroughProperty("DedLabel5")]
        private TextBox _DedLabel5;
        [AccessedThroughProperty("DedLabel6")]
        private TextBox _DedLabel6;
        [AccessedThroughProperty("DedLabel7")]
        private TextBox _DedLabel7;
        [AccessedThroughProperty("DedLabel8")]
        private TextBox _DedLabel8;
        [AccessedThroughProperty("Ded_4")]
        private TextBox _Ded_4;
        [AccessedThroughProperty("Ded_5")]
        private TextBox _Ded_5;
        [AccessedThroughProperty("Ded_6")]
        private TextBox _Ded_6;
        [AccessedThroughProperty("Ded_7")]
        private TextBox _Ded_7;
        [AccessedThroughProperty("Ded_8")]
        private TextBox _Ded_8;
        [AccessedThroughProperty("Ded_9")]
        private TextBox _Ded_9;
        [AccessedThroughProperty("DedLabel9")]
        private TextBox _DedLabel9;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("m4")]
        private Button _m4;
        [AccessedThroughProperty("p4")]
        private Button _p4;
        [AccessedThroughProperty("m7")]
        private Button _m7;
        [AccessedThroughProperty("m8")]
        private Button _m8;
        [AccessedThroughProperty("m9")]
        private Button _m9;
        [AccessedThroughProperty("m6")]
        private Button _m6;
        [AccessedThroughProperty("m5")]
        private Button _m5;
        [AccessedThroughProperty("p5")]
        private Button _p5;
        [AccessedThroughProperty("p6")]
        private Button _p6;
        [AccessedThroughProperty("p7")]
        private Button _p7;
        [AccessedThroughProperty("p8")]
        private Button _p8;
        [AccessedThroughProperty("p9")]
        private Button _p9;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("p10")]
        private Button _p10;
        [AccessedThroughProperty("m10")]
        private Button _m10;
        [AccessedThroughProperty("Ded_10")]
        private TextBox _Ded_10;
        [AccessedThroughProperty("DedLabel10")]
        private TextBox _DedLabel10;
        private string Falls;

        public DeductionsDialog()
        {
            this.Load += new EventHandler(this.DeductionsDialog_Load);
            this.Falls = "0";
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DeductionsDialog));
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.OK_Button = new Button();
            this.Cancel_Button = new Button();
            this.Label1 = new Label();
            this.DedLabel4 = new TextBox();
            this.DedLabel5 = new TextBox();
            this.DedLabel6 = new TextBox();
            this.DedLabel7 = new TextBox();
            this.DedLabel8 = new TextBox();
            this.Ded_4 = new TextBox();
            this.Ded_5 = new TextBox();
            this.Ded_6 = new TextBox();
            this.Ded_7 = new TextBox();
            this.Ded_8 = new TextBox();
            this.Ded_9 = new TextBox();
            this.DedLabel9 = new TextBox();
            this.Label3 = new Label();
            this.m4 = new Button();
            this.p4 = new Button();
            this.m7 = new Button();
            this.m8 = new Button();
            this.m9 = new Button();
            this.m6 = new Button();
            this.m5 = new Button();
            this.p5 = new Button();
            this.p6 = new Button();
            this.p7 = new Button();
            this.p8 = new Button();
            this.p9 = new Button();
            this.Label4 = new Label();
            this.Label2 = new Label();
            this.p10 = new Button();
            this.m10 = new Button();
            this.Ded_10 = new TextBox();
            this.DedLabel10 = new TextBox();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.TableLayoutPanel1.BackColor = Color.White;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add((Control)this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add((Control)this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new Point(123, 302);
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
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new Point(16, 13);
            this.Label1.Name = "Label1";
            Label label1 = this.Label1;
            size1 = new Size(202, 16);
            Size size5 = size1;
            label1.Size = size5;
            this.Label1.TabIndex = 27;
            this.Label1.Text = "Technical Panel Deductions";
            this.DedLabel4.BackColor = Color.White;
            this.DedLabel4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DedLabel4.Location = new Point(19, 125);
            this.DedLabel4.Name = "DedLabel4";
            this.DedLabel4.ReadOnly = true;
            TextBox dedLabel4 = this.DedLabel4;
            size1 = new Size(221, 22);
            Size size6 = size1;
            dedLabel4.Size = size6;
            this.DedLabel4.TabIndex = 9;
            this.DedLabel4.TabStop = false;
            this.DedLabel4.Text = "TIME VIOLATION";
            this.DedLabel5.BackColor = Color.White;
            this.DedLabel5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DedLabel5.Location = new Point(19, 32);
            this.DedLabel5.Name = "DedLabel5";
            this.DedLabel5.ReadOnly = true;
            TextBox dedLabel5 = this.DedLabel5;
            size1 = new Size(221, 22);
            Size size7 = size1;
            dedLabel5.Size = size7;
            this.DedLabel5.TabIndex = 7;
            this.DedLabel5.TabStop = false;
            this.DedLabel5.Text = "FALLS";
            this.DedLabel6.BackColor = Color.White;
            this.DedLabel6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DedLabel6.Location = new Point(19, 62);
            this.DedLabel6.Name = "DedLabel6";
            this.DedLabel6.ReadOnly = true;
            TextBox dedLabel6 = this.DedLabel6;
            size1 = new Size(221, 22);
            Size size8 = size1;
            dedLabel6.Size = size8;
            this.DedLabel6.TabIndex = 8;
            this.DedLabel6.TabStop = false;
            this.DedLabel6.Text = "ILLEGAL ELEMENT";
            this.DedLabel7.BackColor = Color.White;
            this.DedLabel7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DedLabel7.Location = new Point(19, 155);
            this.DedLabel7.Name = "DedLabel7";
            this.DedLabel7.ReadOnly = true;
            TextBox dedLabel7 = this.DedLabel7;
            size1 = new Size(221, 22);
            Size size9 = size1;
            dedLabel7.Size = size9;
            this.DedLabel7.TabIndex = 10;
            this.DedLabel7.TabStop = false;
            this.DedLabel7.Text = "INTERRUPT";
            this.DedLabel8.BackColor = Color.White;
            this.DedLabel8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DedLabel8.Location = new Point(19, 185);
            this.DedLabel8.Name = "DedLabel8";
            this.DedLabel8.ReadOnly = true;
            TextBox dedLabel8 = this.DedLabel8;
            size1 = new Size(221, 22);
            Size size10 = size1;
            dedLabel8.Size = size10;
            this.DedLabel8.TabIndex = 11;
            this.DedLabel8.TabStop = false;
            this.DedLabel8.Text = "COSTUME FAILURE";
            this.Ded_4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Ded_4.Location = new Point(336, 125);
            this.Ded_4.MaxLength = 1;
            this.Ded_4.Name = "Ded_4";
            TextBox ded4 = this.Ded_4;
            size1 = new Size(46, 22);
            Size size11 = size1;
            ded4.Size = size11;
            this.Ded_4.TabIndex = 3;
            this.Ded_4.TextAlign = HorizontalAlignment.Center;
            this.Ded_5.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Ded_5.Location = new Point(333, 32);
            this.Ded_5.MaxLength = 1;
            this.Ded_5.Name = "Ded_5";
            TextBox ded5 = this.Ded_5;
            size1 = new Size(46, 22);
            Size size12 = size1;
            ded5.Size = size12;
            this.Ded_5.TabIndex = 1;
            this.Ded_5.TextAlign = HorizontalAlignment.Center;
            this.Ded_6.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Ded_6.Location = new Point(333, 62);
            this.Ded_6.MaxLength = 1;
            this.Ded_6.Name = "Ded_6";
            TextBox ded6 = this.Ded_6;
            size1 = new Size(46, 22);
            Size size13 = size1;
            ded6.Size = size13;
            this.Ded_6.TabIndex = 2;
            this.Ded_6.TextAlign = HorizontalAlignment.Center;
            this.Ded_7.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Ded_7.Location = new Point(336, 155);
            this.Ded_7.MaxLength = 1;
            this.Ded_7.Name = "Ded_7";
            TextBox ded7 = this.Ded_7;
            size1 = new Size(46, 22);
            Size size14 = size1;
            ded7.Size = size14;
            this.Ded_7.TabIndex = 4;
            this.Ded_7.TextAlign = HorizontalAlignment.Center;
            this.Ded_8.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Ded_8.Location = new Point(336, 185);
            this.Ded_8.MaxLength = 1;
            this.Ded_8.Name = "Ded_8";
            TextBox ded8 = this.Ded_8;
            size1 = new Size(46, 22);
            Size size15 = size1;
            ded8.Size = size15;
            this.Ded_8.TabIndex = 5;
            this.Ded_8.TextAlign = HorizontalAlignment.Center;
            this.Ded_9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Ded_9.Location = new Point(336, 215);
            this.Ded_9.MaxLength = 1;
            this.Ded_9.Name = "Ded_9";
            TextBox ded9 = this.Ded_9;
            size1 = new Size(46, 22);
            Size size16 = size1;
            ded9.Size = size16;
            this.Ded_9.TabIndex = 6;
            this.Ded_9.TextAlign = HorizontalAlignment.Center;
            this.DedLabel9.BackColor = Color.White;
            this.DedLabel9.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DedLabel9.Location = new Point(19, 215);
            this.DedLabel9.Name = "DedLabel9";
            this.DedLabel9.ReadOnly = true;
            TextBox dedLabel9 = this.DedLabel9;
            size1 = new Size(221, 22);
            Size size17 = size1;
            dedLabel9.Size = size17;
            this.DedLabel9.TabIndex = 12;
            this.DedLabel9.TabStop = false;
            this.DedLabel9.Text = "LATE START";
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new Point(335, 15);
            this.Label3.Name = "Label3";
            Label label3 = this.Label3;
            size1 = new Size(42, 13);
            Size size18 = size1;
            label3.Size = size18;
            this.Label3.TabIndex = 26;
            this.Label3.Text = "No. of";
            this.m4.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.m4.Location = new Point(249, 125);
            this.m4.Name = "m4";
            Button m4 = this.m4;
            size1 = new Size(36, 22);
            Size size19 = size1;
            m4.Size = size19;
            this.m4.TabIndex = 29;
            this.m4.TabStop = false;
            this.m4.Text = "-";
            this.m4.UseVisualStyleBackColor = true;
            this.p4.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.p4.Location = new Point(291, 125);
            this.p4.Name = "p4";
            Button p4 = this.p4;
            size1 = new Size(36, 22);
            Size size20 = size1;
            p4.Size = size20;
            this.p4.TabIndex = 30;
            this.p4.TabStop = false;
            this.p4.Text = "+";
            this.p4.UseVisualStyleBackColor = true;
            this.m7.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.m7.Location = new Point(249, 155);
            this.m7.Name = "m7";
            Button m7 = this.m7;
            size1 = new Size(36, 22);
            Size size21 = size1;
            m7.Size = size21;
            this.m7.TabIndex = 31;
            this.m7.TabStop = false;
            this.m7.Text = "-";
            this.m7.UseVisualStyleBackColor = true;
            this.m8.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.m8.Location = new Point(249, 185);
            this.m8.Name = "m8";
            Button m8 = this.m8;
            size1 = new Size(36, 22);
            Size size22 = size1;
            m8.Size = size22;
            this.m8.TabIndex = 32;
            this.m8.TabStop = false;
            this.m8.Text = "-";
            this.m8.UseVisualStyleBackColor = true;
            this.m9.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.m9.Location = new Point(249, 215);
            this.m9.Name = "m9";
            Button m9 = this.m9;
            size1 = new Size(36, 22);
            Size size23 = size1;
            m9.Size = size23;
            this.m9.TabIndex = 33;
            this.m9.TabStop = false;
            this.m9.Text = "-";
            this.m9.UseVisualStyleBackColor = true;
            this.m6.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.m6.Location = new Point(249, 62);
            this.m6.Name = "m6";
            Button m6 = this.m6;
            size1 = new Size(36, 22);
            Size size24 = size1;
            m6.Size = size24;
            this.m6.TabIndex = 34;
            this.m6.TabStop = false;
            this.m6.Text = "-";
            this.m6.UseVisualStyleBackColor = true;
            this.m5.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.m5.Location = new Point(249, 32);
            this.m5.Name = "m5";
            Button m5 = this.m5;
            size1 = new Size(36, 22);
            Size size25 = size1;
            m5.Size = size25;
            this.m5.TabIndex = 35;
            this.m5.TabStop = false;
            this.m5.Text = "-";
            this.m5.UseVisualStyleBackColor = true;
            this.p5.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.p5.Location = new Point(291, 32);
            this.p5.Name = "p5";
            Button p5 = this.p5;
            size1 = new Size(36, 22);
            Size size26 = size1;
            p5.Size = size26;
            this.p5.TabIndex = 36;
            this.p5.TabStop = false;
            this.p5.Text = "+";
            this.p5.UseVisualStyleBackColor = true;
            this.p6.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.p6.Location = new Point(291, 62);
            this.p6.Name = "p6";
            Button p6 = this.p6;
            size1 = new Size(36, 22);
            Size size27 = size1;
            p6.Size = size27;
            this.p6.TabIndex = 37;
            this.p6.TabStop = false;
            this.p6.Text = "+";
            this.p6.UseVisualStyleBackColor = true;
            this.p7.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.p7.Location = new Point(291, 155);
            this.p7.Name = "p7";
            Button p7 = this.p7;
            size1 = new Size(36, 22);
            Size size28 = size1;
            p7.Size = size28;
            this.p7.TabIndex = 38;
            this.p7.TabStop = false;
            this.p7.Text = "+";
            this.p7.UseVisualStyleBackColor = true;
            this.p8.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.p8.Location = new Point(291, 185);
            this.p8.Name = "p8";
            Button p8 = this.p8;
            size1 = new Size(36, 22);
            Size size29 = size1;
            p8.Size = size29;
            this.p8.TabIndex = 39;
            this.p8.TabStop = false;
            this.p8.Text = "+";
            this.p8.UseVisualStyleBackColor = true;
            this.p9.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.p9.Location = new Point(291, 215);
            this.p9.Name = "p9";
            Button p9 = this.p9;
            size1 = new Size(36, 22);
            Size size30 = size1;
            p9.Size = size30;
            this.p9.TabIndex = 40;
            this.p9.TabStop = false;
            this.p9.Text = "+";
            this.p9.UseVisualStyleBackColor = true;
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label4.Location = new Point(16, 106);
            this.Label4.Name = "Label4";
            Label label4 = this.Label4;
            size1 = new Size(146, 16);
            Size size31 = size1;
            label4.Size = size31;
            this.Label4.TabIndex = 41;
            this.Label4.Text = "Referee Deductions";
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new Point(335, 109);
            this.Label2.Name = "Label2";
            Label label2 = this.Label2;
            size1 = new Size(42, 13);
            Size size32 = size1;
            label2.Size = size32;
            this.Label2.TabIndex = 42;
            this.Label2.Text = "No. of";
            this.p10.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.p10.Location = new Point(291, 245);
            this.p10.Name = "p10";
            Button p10 = this.p10;
            size1 = new Size(36, 22);
            Size size33 = size1;
            p10.Size = size33;
            this.p10.TabIndex = 50;
            this.p10.TabStop = false;
            this.p10.Text = "+";
            this.p10.UseVisualStyleBackColor = true;
            this.m10.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.m10.Location = new Point(249, 245);
            this.m10.Name = "m10";
            Button m10 = this.m10;
            size1 = new Size(36, 22);
            Size size34 = size1;
            m10.Size = size34;
            this.m10.TabIndex = 49;
            this.m10.TabStop = false;
            this.m10.Text = "-";
            this.m10.UseVisualStyleBackColor = true;
            this.Ded_10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Ded_10.Location = new Point(336, 245);
            this.Ded_10.MaxLength = 1;
            this.Ded_10.Name = "Ded_10";
            TextBox ded10 = this.Ded_10;
            size1 = new Size(46, 22);
            Size size35 = size1;
            ded10.Size = size35;
            this.Ded_10.TabIndex = 47;
            this.Ded_10.TextAlign = HorizontalAlignment.Center;
            this.DedLabel10.BackColor = Color.White;
            this.DedLabel10.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DedLabel10.Location = new Point(19, 245);
            this.DedLabel10.Name = "DedLabel10";
            this.DedLabel10.ReadOnly = true;
            TextBox dedLabel10 = this.DedLabel10;
            size1 = new Size(221, 22);
            Size size36 = size1;
            dedLabel10.Size = size36;
            this.DedLabel10.TabIndex = 48;
            this.DedLabel10.TabStop = false;
            this.DedLabel10.Text = "MISSING ELEMENT";
            this.AcceptButton = (IButtonControl)this.OK_Button;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb((int)byte.MaxValue, 192, 128);
            this.CancelButton = (IButtonControl)this.Cancel_Button;
            size1 = new Size(386, 343);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.p10);
            this.Controls.Add((Control)this.m10);
            this.Controls.Add((Control)this.Ded_10);
            this.Controls.Add((Control)this.DedLabel10);
            this.Controls.Add((Control)this.Label2);
            this.Controls.Add((Control)this.Label4);
            this.Controls.Add((Control)this.p9);
            this.Controls.Add((Control)this.p8);
            this.Controls.Add((Control)this.p7);
            this.Controls.Add((Control)this.p6);
            this.Controls.Add((Control)this.p5);
            this.Controls.Add((Control)this.m5);
            this.Controls.Add((Control)this.m6);
            this.Controls.Add((Control)this.m9);
            this.Controls.Add((Control)this.m8);
            this.Controls.Add((Control)this.m7);
            this.Controls.Add((Control)this.p4);
            this.Controls.Add((Control)this.m4);
            this.Controls.Add((Control)this.Label3);
            this.Controls.Add((Control)this.Ded_9);
            this.Controls.Add((Control)this.DedLabel9);
            this.Controls.Add((Control)this.Ded_8);
            this.Controls.Add((Control)this.Ded_7);
            this.Controls.Add((Control)this.Ded_6);
            this.Controls.Add((Control)this.Ded_5);
            this.Controls.Add((Control)this.Ded_4);
            this.Controls.Add((Control)this.DedLabel8);
            this.Controls.Add((Control)this.DedLabel7);
            this.Controls.Add((Control)this.DedLabel6);
            this.Controls.Add((Control)this.DedLabel5);
            this.Controls.Add((Control)this.DedLabel4);
            this.Controls.Add((Control)this.Label1);
            this.Controls.Add((Control)this.TableLayoutPanel1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(DeductionsDialog);
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "DEDUCTIONS";
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

        internal virtual TextBox DedLabel4
        {
            get => this._DedLabel4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._DedLabel4 = value;
        }

        internal virtual TextBox DedLabel5
        {
            get => this._DedLabel5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._DedLabel5 = value;
        }

        internal virtual TextBox DedLabel6
        {
            get => this._DedLabel6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._DedLabel6 = value;
        }

        internal virtual TextBox DedLabel7
        {
            get => this._DedLabel7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._DedLabel7 = value;
        }

        internal virtual TextBox DedLabel8
        {
            get => this._DedLabel8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._DedLabel8 = value;
        }

        internal virtual TextBox Ded_4
        {
            get => this._Ded_4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Ded_4_TextChanged);
                if (this._Ded_4 != null)
                    this._Ded_4.TextChanged -= eventHandler;
                this._Ded_4 = value;
                if (this._Ded_4 == null)
                    return;
                this._Ded_4.TextChanged += eventHandler;
            }
        }

        internal virtual TextBox Ded_5
        {
            get => this._Ded_5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Ded_5_TextChanged);
                if (this._Ded_5 != null)
                    this._Ded_5.TextChanged -= eventHandler;
                this._Ded_5 = value;
                if (this._Ded_5 == null)
                    return;
                this._Ded_5.TextChanged += eventHandler;
            }
        }

        internal virtual TextBox Ded_6
        {
            get => this._Ded_6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Ded_6_TextChanged);
                if (this._Ded_6 != null)
                    this._Ded_6.TextChanged -= eventHandler;
                this._Ded_6 = value;
                if (this._Ded_6 == null)
                    return;
                this._Ded_6.TextChanged += eventHandler;
            }
        }

        internal virtual TextBox Ded_7
        {
            get => this._Ded_7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Ded_7_TextChanged);
                if (this._Ded_7 != null)
                    this._Ded_7.TextChanged -= eventHandler;
                this._Ded_7 = value;
                if (this._Ded_7 == null)
                    return;
                this._Ded_7.TextChanged += eventHandler;
            }
        }

        internal virtual TextBox Ded_8
        {
            get => this._Ded_8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Ded_8_TextChanged);
                if (this._Ded_8 != null)
                    this._Ded_8.TextChanged -= eventHandler;
                this._Ded_8 = value;
                if (this._Ded_8 == null)
                    return;
                this._Ded_8.TextChanged += eventHandler;
            }
        }

        internal virtual TextBox Ded_9
        {
            get => this._Ded_9;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Ded_9_TextChanged);
                if (this._Ded_9 != null)
                    this._Ded_9.TextChanged -= eventHandler;
                this._Ded_9 = value;
                if (this._Ded_9 == null)
                    return;
                this._Ded_9.TextChanged += eventHandler;
            }
        }

        internal virtual TextBox DedLabel9
        {
            get => this._DedLabel9;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._DedLabel9 = value;
        }

        internal virtual Label Label3
        {
            get => this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label3 = value;
        }

        internal virtual Button m4
        {
            get => this._m4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.m4_Click);
                if (this._m4 != null)
                    this._m4.Click -= eventHandler;
                this._m4 = value;
                if (this._m4 == null)
                    return;
                this._m4.Click += eventHandler;
            }
        }

        internal virtual Button p4
        {
            get => this._p4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.p4_Click);
                if (this._p4 != null)
                    this._p4.Click -= eventHandler;
                this._p4 = value;
                if (this._p4 == null)
                    return;
                this._p4.Click += eventHandler;
            }
        }

        internal virtual Button m7
        {
            get => this._m7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.m7_Click);
                if (this._m7 != null)
                    this._m7.Click -= eventHandler;
                this._m7 = value;
                if (this._m7 == null)
                    return;
                this._m7.Click += eventHandler;
            }
        }

        internal virtual Button m8
        {
            get => this._m8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.m8_Click);
                if (this._m8 != null)
                    this._m8.Click -= eventHandler;
                this._m8 = value;
                if (this._m8 == null)
                    return;
                this._m8.Click += eventHandler;
            }
        }

        internal virtual Button m9
        {
            get => this._m9;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.m9_Click);
                if (this._m9 != null)
                    this._m9.Click -= eventHandler;
                this._m9 = value;
                if (this._m9 == null)
                    return;
                this._m9.Click += eventHandler;
            }
        }

        internal virtual Button m6
        {
            get => this._m6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.m6_Click);
                if (this._m6 != null)
                    this._m6.Click -= eventHandler;
                this._m6 = value;
                if (this._m6 == null)
                    return;
                this._m6.Click += eventHandler;
            }
        }

        internal virtual Button m5
        {
            get => this._m5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.m5_Click);
                if (this._m5 != null)
                    this._m5.Click -= eventHandler;
                this._m5 = value;
                if (this._m5 == null)
                    return;
                this._m5.Click += eventHandler;
            }
        }

        internal virtual Button p5
        {
            get => this._p5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.p5_Click);
                if (this._p5 != null)
                    this._p5.Click -= eventHandler;
                this._p5 = value;
                if (this._p5 == null)
                    return;
                this._p5.Click += eventHandler;
            }
        }

        internal virtual Button p6
        {
            get => this._p6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.p6_Click);
                if (this._p6 != null)
                    this._p6.Click -= eventHandler;
                this._p6 = value;
                if (this._p6 == null)
                    return;
                this._p6.Click += eventHandler;
            }
        }

        internal virtual Button p7
        {
            get => this._p7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.p7_Click);
                if (this._p7 != null)
                    this._p7.Click -= eventHandler;
                this._p7 = value;
                if (this._p7 == null)
                    return;
                this._p7.Click += eventHandler;
            }
        }

        internal virtual Button p8
        {
            get => this._p8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.p8_Click);
                if (this._p8 != null)
                    this._p8.Click -= eventHandler;
                this._p8 = value;
                if (this._p8 == null)
                    return;
                this._p8.Click += eventHandler;
            }
        }

        internal virtual Button p9
        {
            get => this._p9;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.p9_Click);
                if (this._p9 != null)
                    this._p9.Click -= eventHandler;
                this._p9 = value;
                if (this._p9 == null)
                    return;
                this._p9.Click += eventHandler;
            }
        }

        internal virtual Label Label4
        {
            get => this._Label4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label4 = value;
        }

        internal virtual Label Label2
        {
            get => this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label2 = value;
        }

        internal virtual Button p10
        {
            get => this._p10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.p10_Click);
                if (this._p10 != null)
                    this._p10.Click -= eventHandler;
                this._p10 = value;
                if (this._p10 == null)
                    return;
                this._p10.Click += eventHandler;
            }
        }

        internal virtual Button m10
        {
            get => this._m10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.m10_Click);
                if (this._m10 != null)
                    this._m10.Click -= eventHandler;
                this._m10 = value;
                if (this._m10 == null)
                    return;
                this._m10.Click += eventHandler;
            }
        }

        internal virtual TextBox Ded_10
        {
            get => this._Ded_10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Ded_10_TextChanged);
                if (this._Ded_10 != null)
                    this._Ded_10.TextChanged -= eventHandler;
                this._Ded_10 = value;
                if (this._Ded_10 == null)
                    return;
                this._Ded_10.TextChanged += eventHandler;
            }
        }

        internal virtual TextBox DedLabel10
        {
            get => this._DedLabel10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._DedLabel10 = value;
        }

        private void DeductionsDialog_Load(object sender, EventArgs e)
        {
            this.Top = MyProject.Forms.JudgesDetailsForm.Top;
            this.Left = checked((int)Math.Round(unchecked((double)checked(Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2.0)));
            this.TopMost = true;
            if (!(Module1.PNo > 0 & Module1.PNo <= Module1.TNop))
                return;
            this.DedLabel4.Visible = true;
            this.DedLabel5.Visible = true;
            this.DedLabel6.Visible = true;
            this.DedLabel7.Visible = true;
            this.DedLabel8.Visible = true;
            this.Ded_4.Visible = true;
            this.Ded_5.Visible = true;
            this.Ded_6.Visible = true;
            this.Ded_7.Visible = true;
            this.Ded_8.Visible = true;
            this.Ded_9.Visible = true;
            if (Strings.UCase(Module1.Category.Name).Contains("ARTISTISK"))
            {
                this.Height = 351;
                this.DedLabel10.Visible = true;
                this.m10.Visible = true;
                this.p10.Visible = true;
                this.Ded_10.Visible = true;
            }
            else
            {
                this.Height = 323;
                this.DedLabel10.Visible = false;
                this.m10.Visible = false;
                this.p10.Visible = false;
                this.Ded_10.Visible = false;
            }
            this.SetActualDED(Module1.Segment);
            this.Text = "DEDUCTION INPUT - " + Module1.Vek[Module1.PNo].Name.FName + " " + Module1.Vek[Module1.PNo].Name.LName;
            this.Ded_5.Select();
        }

        private void GetDED()
        {
            if (Operators.CompareString(this.Ded_5.Text, "", false) != 0)
                this.SetFalls(Conversions.ToInteger(this.Ded_5.Text));
            if (Operators.CompareString(this.Ded_4.Text, "", false) != 0)
                Module1.SetDed(checked((int)Math.Round(Conversion.Val(this.Ded_4.Text))), 1, Module1.Segment);
            if (Operators.CompareString(this.Ded_6.Text, "", false) != 0)
                Module1.SetDed(checked((int)Math.Round(Conversion.Val(this.Ded_6.Text))), 3, Module1.Segment);
            if (Operators.CompareString(this.Ded_7.Text, "", false) != 0)
                Module1.SetDed(checked((int)Math.Round(Conversion.Val(this.Ded_7.Text))), 4, Module1.Segment);
            if (Operators.CompareString(this.Ded_8.Text, "", false) != 0)
                Module1.SetDed(checked((int)Math.Round(Conversion.Val(this.Ded_8.Text))), 5, Module1.Segment);
            if (Operators.CompareString(this.Ded_9.Text, "", false) != 0)
                Module1.SetDed(checked((int)Math.Round(Conversion.Val(this.Ded_9.Text))), 2, Module1.Segment);
            if (Operators.CompareString(this.Ded_10.Text, "", false) == 0)
                return;
            Module1.SetDed(checked((int)Math.Round(Conversion.Val(this.Ded_10.Text))), 6, Module1.Segment);
        }

        public void SetFalls(int value)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                string segment = Module1.Segment;
                num3 = 5;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    num3 = 6;
                    Module1.Vek[Module1.PNo].Falls_seg1 = value;
                }
                else
                {
                    num3 = 8;
                    if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        num3 = 9;
                        Module1.Vek[Module1.PNo].Falls_seg2 = value;
                    }
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

        private void SetActualDED(string prog)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int[] myarr = new int[11];
                ProjectData.ClearProjectError();
                num1 = 2;
                string Left = prog;
                long DedLong = 0;
                if (Operators.CompareString(Left, "Seg1", false) == 0)
                {
                    if (Module1.Vek[Module1.PNo].Falls_seg1 > 0)
                        this.Ded_5.Text = Conversions.ToString(Module1.Vek[Module1.PNo].Falls_seg1);
                    DedLong = Module1.Vek[Module1.PNo].Deductions_Seg1;
                }
                else if (Operators.CompareString(Left, "Seg2", false) == 0)
                {
                    if (Module1.Vek[Module1.PNo].Falls_seg2 > 0)
                        this.Ded_5.Text = Conversions.ToString(Module1.Vek[Module1.PNo].Falls_seg2);
                    DedLong = Module1.Vek[Module1.PNo].Deductions_Seg2;
                }
                Module1.GetArr(ref myarr, DedLong);
                long num3 = 0;
                if (myarr[1] > 0)
                    this.Ded_4.Text = Conversions.ToString(num3);
                if (myarr[2] > 0)
                    this.Ded_9.Text = Conversions.ToString(num3);
                if (myarr[3] > 0)
                    this.Ded_6.Text = Conversions.ToString(num3);
                if (myarr[4] > 0)
                    this.Ded_7.Text = Conversions.ToString(num3);
                if (myarr[5] > 0)
                    this.Ded_8.Text = Conversions.ToString(num3);
                if (myarr[6] > 0)
                {
                    this.Ded_10.Text = Conversions.ToString(num3);
                    goto label_26;
                }
                else
                    goto label_26;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("Dialog 11, SetActualDED - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_26:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void DEDmsg()
        {
            int num = (int)Interaction.MsgBox((object)"Wrong input! Should be between 0 and 9!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.GetDED();
            this.Falls = Strings.Len(this.Ded_5.Text) <= 0 ? "0" : this.Ded_5.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
            switch (Module1.WorkMode)
            {
                case 1:
                    MyProject.Forms.ElementInputForm.Show();
                    break;
                case 2:
                case 3:
                    if (Module1.IsFormOpen((Form)MyProject.Forms.ElementInputForm))
                    {
                        MyProject.Forms.ElementInputForm.Falls_out.Text = "FALLS  " + this.Falls;
                        MyProject.Forms.ElementInputForm.TopMost = true;
                        Module1.SaveCategoryFile(Module1.CategoryFileName);
                        break;
                    }
                    int rowDed = 0;
                    Module1.CreateJudgesDetails(0, ref rowDed);
                    MyProject.Forms.JudgesDetailsForm.ShowJD(rowDed);
                    MyProject.Forms.JudgesDetailsForm.Show();
                    Module1.SaveCategoryFile(Module1.CategoryFileName);
                    break;
            }
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Ded_4_TextChanged(object sender, EventArgs e)
        {
            if (this.Ded_4.TextLength < 1)
                return;
            if (Versioned.IsNumeric((object)this.Ded_4.Text) & Conversion.Val(this.Ded_4.Text) >= 0.0 & Conversion.Val(this.Ded_4.Text) <= 9.0)
            {
                this.Ded_4.Select();
            }
            else
            {
                this.DEDmsg();
                this.Ded_4.Text = "";
                this.Ded_4.Select();
            }
        }

        private void Ded_5_TextChanged(object sender, EventArgs e)
        {
            if (this.Ded_5.TextLength < 2)
                return;
            if (Versioned.IsNumeric((object)this.Ded_5.Text) & Conversion.Val(this.Ded_5.Text) >= 0.0 & Conversion.Val(this.Ded_5.Text) <= 19.0)
            {
                this.Ded_5.Select();
            }
            else
            {
                this.DEDmsg();
                this.Ded_5.Text = "";
                this.Ded_5.Select();
            }
        }

        private void Ded_6_TextChanged(object sender, EventArgs e)
        {
            if (this.Ded_6.TextLength < 1)
                return;
            if (Versioned.IsNumeric((object)this.Ded_6.Text) & Conversion.Val(this.Ded_6.Text) >= 0.0 & Conversion.Val(this.Ded_6.Text) <= 9.0)
            {
                this.Ded_6.Select();
            }
            else
            {
                this.DEDmsg();
                this.Ded_6.Text = "";
                this.Ded_6.Select();
            }
        }

        private void Ded_7_TextChanged(object sender, EventArgs e)
        {
            if (this.Ded_7.TextLength < 1)
                return;
            if (Versioned.IsNumeric((object)this.Ded_7.Text) & Conversion.Val(this.Ded_7.Text) >= 0.0 & Conversion.Val(this.Ded_7.Text) <= 9.0)
            {
                this.Ded_7.Select();
            }
            else
            {
                this.DEDmsg();
                this.Ded_7.Text = "";
                this.Ded_7.Select();
            }
        }

        private void Ded_8_TextChanged(object sender, EventArgs e)
        {
            if (this.Ded_8.TextLength < 1)
                return;
            if (Versioned.IsNumeric((object)this.Ded_8.Text) & Conversion.Val(this.Ded_8.Text) >= 0.0 & Conversion.Val(this.Ded_8.Text) <= 9.0)
            {
                this.Ded_8.Select();
            }
            else
            {
                this.DEDmsg();
                this.Ded_8.Text = "";
                this.Ded_8.Select();
            }
        }

        private void Ded_9_TextChanged(object sender, EventArgs e)
        {
            if (this.Ded_9.TextLength < 1)
                return;
            if (Versioned.IsNumeric((object)this.Ded_9.Text) & Conversion.Val(this.Ded_9.Text) >= 0.0 & Conversion.Val(this.Ded_9.Text) <= 9.0)
            {
                this.Ded_9.Select();
            }
            else
            {
                this.DEDmsg();
                this.Ded_9.Text = "";
                this.Ded_9.Select();
            }
        }

        private void Ded_10_TextChanged(object sender, EventArgs e)
        {
            if (this.Ded_10.TextLength < 1)
                return;
            if (Versioned.IsNumeric((object)this.Ded_10.Text) & Conversion.Val(this.Ded_10.Text) >= 0.0 & Conversion.Val(this.Ded_10.Text) <= 9.0)
            {
                this.Ded_10.Select();
            }
            else
            {
                this.DEDmsg();
                this.Ded_10.Text = "";
                this.Ded_10.Select();
            }
        }

        private void m4_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                if (Strings.Len(this.Ded_4.Text) > 0)
                {
                    num3 = 4;
                    num4 = Conversions.ToInteger(this.Ded_4.Text);
                }
                num3 = 6;
                if (num4 > 0)
                {
                    num3 = 7;
                    this.Ded_4.Text = Conversions.ToString(checked(num4 - 1));
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

        private void p4_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                if (Strings.Len(this.Ded_4.Text) > 0)
                {
                    num3 = 4;
                    num4 = Conversions.ToInteger(this.Ded_4.Text);
                }
                num3 = 6;
                if (num4 < 9)
                {
                    num3 = 7;
                    int num5 = checked(num4 + 1);
                    num3 = 8;
                    this.Ded_4.Text = Conversions.ToString(num5);
                }
                else
                {
                    num3 = 10;
                    num3 = 11;
                    int num6 = (int)Interaction.MsgBox((object)("Max no. of Deduction = " + Conversions.ToString(9) + "!"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
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

        private void m5_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                if (Strings.Len(this.Ded_5.Text) > 0)
                {
                    num3 = 4;
                    num4 = Conversions.ToInteger(this.Ded_5.Text);
                }
                num3 = 6;
                if (num4 > 0)
                {
                    num3 = 7;
                    this.Ded_5.Text = Conversions.ToString(checked(num4 - 1));
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

        private void p5_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                if (Strings.Len(this.Ded_5.Text) > 0)
                {
                    num3 = 4;
                    num4 = Conversions.ToInteger(this.Ded_5.Text);
                }
                num3 = 6;
                if (num4 < 19)
                {
                    num3 = 7;
                    int num5 = checked(num4 + 1);
                    num3 = 8;
                    this.Ded_5.Text = Conversions.ToString(num5);
                }
                else
                {
                    num3 = 10;
                    num3 = 11;
                    int num6 = (int)Interaction.MsgBox((object)("Max no. of Deduction = " + Conversions.ToString(19) + "!"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
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

        private void m6_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                if (Strings.Len(this.Ded_6.Text) > 0)
                {
                    num3 = 4;
                    num4 = Conversions.ToInteger(this.Ded_6.Text);
                }
                num3 = 6;
                if (num4 > 0)
                {
                    num3 = 7;
                    this.Ded_6.Text = Conversions.ToString(checked(num4 - 1));
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

        private void p6_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                if (Strings.Len(this.Ded_6.Text) > 0)
                {
                    num3 = 4;
                    num4 = Conversions.ToInteger(this.Ded_6.Text);
                }
                num3 = 6;
                if (num4 < 9)
                {
                    num3 = 7;
                    int num5 = checked(num4 + 1);
                    num3 = 8;
                    this.Ded_6.Text = Conversions.ToString(num5);
                }
                else
                {
                    num3 = 10;
                    num3 = 11;
                    int num6 = (int)Interaction.MsgBox((object)("Max no. of Deduction = " + Conversions.ToString(9) + "!"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
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

        private void m7_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                if (Strings.Len(this.Ded_7.Text) > 0)
                {
                    num3 = 4;
                    num4 = Conversions.ToInteger(this.Ded_7.Text);
                }
                num3 = 6;
                if (num4 > 0)
                {
                    num3 = 7;
                    this.Ded_7.Text = Conversions.ToString(checked(num4 - 1));
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

        private void p7_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                if (Strings.Len(this.Ded_7.Text) > 0)
                {
                    num3 = 4;
                    num4 = Conversions.ToInteger(this.Ded_7.Text);
                }
                num3 = 6;
                if (num4 < 9)
                {
                    num3 = 7;
                    int num5 = checked(num4 + 1);
                    num3 = 8;
                    this.Ded_7.Text = Conversions.ToString(num5);
                }
                else
                {
                    num3 = 10;
                    num3 = 11;
                    int num6 = (int)Interaction.MsgBox((object)("Max no. of Deduction = " + Conversions.ToString(9) + "!"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
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

        private void m8_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                if (Strings.Len(this.Ded_8.Text) > 0)
                {
                    num3 = 4;
                    num4 = Conversions.ToInteger(this.Ded_8.Text);
                }
                num3 = 6;
                if (num4 > 0)
                {
                    num3 = 7;
                    this.Ded_8.Text = Conversions.ToString(checked(num4 - 1));
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

        private void p8_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                if (Strings.Len(this.Ded_8.Text) > 0)
                {
                    num3 = 4;
                    num4 = Conversions.ToInteger(this.Ded_8.Text);
                }
                num3 = 6;
                if (num4 < 9)
                {
                    num3 = 7;
                    int num5 = checked(num4 + 1);
                    num3 = 8;
                    this.Ded_8.Text = Conversions.ToString(num5);
                }
                else
                {
                    num3 = 10;
                    num3 = 11;
                    int num6 = (int)Interaction.MsgBox((object)("Max no. of Deduction = " + Conversions.ToString(9) + "!"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
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

        private void m9_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                if (Strings.Len(this.Ded_9.Text) > 0)
                {
                    num3 = 4;
                    num4 = Conversions.ToInteger(this.Ded_9.Text);
                }
                num3 = 6;
                if (num4 > 0)
                {
                    num3 = 7;
                    this.Ded_9.Text = Conversions.ToString(checked(num4 - 1));
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

        private void p9_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                if (Strings.Len(this.Ded_9.Text) > 0)
                {
                    num3 = 4;
                    num4 = Conversions.ToInteger(this.Ded_9.Text);
                }
                num3 = 6;
                if (num4 < 9)
                {
                    num3 = 7;
                    int num5 = checked(num4 + 1);
                    num3 = 8;
                    this.Ded_9.Text = Conversions.ToString(num5);
                }
                else
                {
                    num3 = 10;
                    num3 = 11;
                    int num6 = (int)Interaction.MsgBox((object)("Max no. of Deduction = " + Conversions.ToString(9) + "!"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
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

        private void m10_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                if (Strings.Len(this.Ded_10.Text) > 0)
                {
                    num3 = 4;
                    num4 = Conversions.ToInteger(this.Ded_10.Text);
                }
                num3 = 6;
                if (num4 > 0)
                {
                    num3 = 7;
                    this.Ded_10.Text = Conversions.ToString(checked(num4 - 1));
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

        private void p10_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                if (Strings.Len(this.Ded_10.Text) > 0)
                {
                    num3 = 4;
                    num4 = Conversions.ToInteger(this.Ded_10.Text);
                }
                num3 = 6;
                if (num4 < 9)
                {
                    num3 = 7;
                    int num5 = checked(num4 + 1);
                    num3 = 8;
                    this.Ded_10.Text = Conversions.ToString(num5);
                }
                else
                {
                    num3 = 10;
                    num3 = 11;
                    int num6 = (int)Interaction.MsgBox((object)("Max no. of Deduction = " + Conversions.ToString(9) + "!"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
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
    }
}

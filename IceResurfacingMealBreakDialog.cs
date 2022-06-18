// Decompiled with JetBrains decompiler
// Type: ClubCompFS.IceResurfacingMealBreakDialog
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
    public class IceResurfacingMealBreakDialog : Form
    {
        private IContainer components;
        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;
        [AccessedThroughProperty("OK_Button")]
        private Button _OK_Button;
        [AccessedThroughProperty("Cancel_Button")]
        private Button _Cancel_Button;
        [AccessedThroughProperty("txtNoSkater")]
        private TextBox _txtNoSkater;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Ice1")]
        private Button _Ice1;
        [AccessedThroughProperty("Ice2")]
        private Button _Ice2;
        [AccessedThroughProperty("Ice3")]
        private Button _Ice3;
        [AccessedThroughProperty("Ice4")]
        private Button _Ice4;
        [AccessedThroughProperty("Ice5")]
        private Button _Ice5;
        [AccessedThroughProperty("Ice6")]
        private Button _Ice6;
        [AccessedThroughProperty("M16")]
        private Button _M16;
        [AccessedThroughProperty("M15")]
        private Button _M15;
        [AccessedThroughProperty("M14")]
        private Button _M14;
        [AccessedThroughProperty("M13")]
        private Button _M13;
        [AccessedThroughProperty("M12")]
        private Button _M12;
        [AccessedThroughProperty("M11")]
        private Button _M11;
        [AccessedThroughProperty("Gr6")]
        private Button _Gr6;
        [AccessedThroughProperty("Gr7")]
        private Button _Gr7;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("M17")]
        private Button _M17;
        [AccessedThroughProperty("Ice7")]
        private Button _Ice7;
        [AccessedThroughProperty("lblRemWT")]
        private Label _lblRemWT;
        private int nogr;
        private int[] OldIceArr_Seg1;
        private int[] OldIceArr_Seg2;
        private int[] OldLunchArr_Seg1;
        private int[] OldLunchArr_Seg2;
        private int OldWupG_Seg1;
        private int OldWupG_Seg2;

        public IceResurfacingMealBreakDialog()
        {
            this.Load += new EventHandler(this.IceResurfacingMealBreakDialog_Load);
            this.OldIceArr_Seg1 = new int[8];
            this.OldIceArr_Seg2 = new int[8];
            this.OldLunchArr_Seg1 = new int[8];
            this.OldLunchArr_Seg2 = new int[8];
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(IceResurfacingMealBreakDialog));
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.Cancel_Button = new Button();
            this.OK_Button = new Button();
            this.txtNoSkater = new TextBox();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.Label3 = new Label();
            this.Ice1 = new Button();
            this.Ice2 = new Button();
            this.Ice3 = new Button();
            this.Ice4 = new Button();
            this.Ice5 = new Button();
            this.Ice6 = new Button();
            this.M16 = new Button();
            this.M15 = new Button();
            this.M14 = new Button();
            this.M13 = new Button();
            this.M12 = new Button();
            this.M11 = new Button();
            this.Gr6 = new Button();
            this.Gr7 = new Button();
            this.Label4 = new Label();
            this.M17 = new Button();
            this.Ice7 = new Button();
            this.lblRemWT = new Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.TableLayoutPanel1.BackColor = Color.White;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add((Control)this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Controls.Add((Control)this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Location = new Point(314, 120);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            TableLayoutPanel tableLayoutPanel1 = this.TableLayoutPanel1;
            Size size1 = new Size(146, 29);
            Size size2 = size1;
            tableLayoutPanel1.Size = size2;
            this.TableLayoutPanel1.TabIndex = 0;
            this.Cancel_Button.Anchor = AnchorStyles.None;
            this.Cancel_Button.DialogResult = DialogResult.Cancel;
            this.Cancel_Button.Location = new Point(76, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            Button cancelButton = this.Cancel_Button;
            size1 = new Size(67, 23);
            Size size3 = size1;
            cancelButton.Size = size3;
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.OK_Button.Anchor = AnchorStyles.None;
            this.OK_Button.Location = new Point(3, 3);
            this.OK_Button.Name = "OK_Button";
            Button okButton = this.OK_Button;
            size1 = new Size(67, 23);
            Size size4 = size1;
            okButton.Size = size4;
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.txtNoSkater.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtNoSkater.Location = new Point(12, 32);
            this.txtNoSkater.Name = "txtNoSkater";
            this.txtNoSkater.ReadOnly = true;
            TextBox txtNoSkater = this.txtNoSkater;
            size1 = new Size(76, 22);
            Size size5 = size1;
            txtNoSkater.Size = size5;
            this.txtNoSkater.TabIndex = 1;
            this.txtNoSkater.TextAlign = HorizontalAlignment.Center;
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new Point(13, 13);
            this.Label1.Name = "Label1";
            Label label1 = this.Label1;
            size1 = new Size(106, 16);
            Size size6 = size1;
            label1.Size = size6;
            this.Label1.TabIndex = 2;
            this.Label1.Text = "No. of Skaters";
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new Point(15, 72);
            this.Label2.Name = "Label2";
            Label label2 = this.Label2;
            size1 = new Size(244, 16);
            Size size7 = size1;
            label2.Size = size7;
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Ice resurfacing after group number";
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new Point(15, 129);
            this.Label3.Name = "Label3";
            Label label3 = this.Label3;
            size1 = new Size(220, 16);
            Size size8 = size1;
            label3.Size = size8;
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Meal break after group number";
            this.Ice1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Ice1.Location = new Point(18, 91);
            this.Ice1.Name = "Ice1";
            Button ice1 = this.Ice1;
            size1 = new Size(30, 30);
            Size size9 = size1;
            ice1.Size = size9;
            this.Ice1.TabIndex = 5;
            this.Ice1.Text = "1";
            this.Ice1.UseVisualStyleBackColor = true;
            this.Ice2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Ice2.Location = new Point(58, 91);
            this.Ice2.Name = "Ice2";
            Button ice2 = this.Ice2;
            size1 = new Size(30, 30);
            Size size10 = size1;
            ice2.Size = size10;
            this.Ice2.TabIndex = 6;
            this.Ice2.Text = "2";
            this.Ice2.UseVisualStyleBackColor = true;
            this.Ice3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Ice3.Location = new Point(98, 91);
            this.Ice3.Name = "Ice3";
            Button ice3 = this.Ice3;
            size1 = new Size(30, 30);
            Size size11 = size1;
            ice3.Size = size11;
            this.Ice3.TabIndex = 7;
            this.Ice3.Text = "3";
            this.Ice3.UseVisualStyleBackColor = true;
            this.Ice4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Ice4.Location = new Point(138, 91);
            this.Ice4.Name = "Ice4";
            Button ice4 = this.Ice4;
            size1 = new Size(30, 30);
            Size size12 = size1;
            ice4.Size = size12;
            this.Ice4.TabIndex = 8;
            this.Ice4.Text = "4";
            this.Ice4.UseVisualStyleBackColor = true;
            this.Ice5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Ice5.Location = new Point(178, 91);
            this.Ice5.Name = "Ice5";
            Button ice5 = this.Ice5;
            size1 = new Size(30, 30);
            Size size13 = size1;
            ice5.Size = size13;
            this.Ice5.TabIndex = 9;
            this.Ice5.Text = "5";
            this.Ice5.UseVisualStyleBackColor = true;
            this.Ice6.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Ice6.Location = new Point(218, 91);
            this.Ice6.Name = "Ice6";
            Button ice6 = this.Ice6;
            size1 = new Size(30, 30);
            Size size14 = size1;
            ice6.Size = size14;
            this.Ice6.TabIndex = 10;
            this.Ice6.Text = "6";
            this.Ice6.UseVisualStyleBackColor = true;
            this.M16.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.M16.Location = new Point(218, 148);
            this.M16.Name = "M16";
            Button m16 = this.M16;
            size1 = new Size(30, 30);
            Size size15 = size1;
            m16.Size = size15;
            this.M16.TabIndex = 16;
            this.M16.Text = "6";
            this.M16.UseVisualStyleBackColor = true;
            this.M15.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.M15.Location = new Point(178, 148);
            this.M15.Name = "M15";
            Button m15 = this.M15;
            size1 = new Size(30, 30);
            Size size16 = size1;
            m15.Size = size16;
            this.M15.TabIndex = 15;
            this.M15.Text = "5";
            this.M15.UseVisualStyleBackColor = true;
            this.M14.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.M14.Location = new Point(138, 148);
            this.M14.Name = "M14";
            Button m14 = this.M14;
            size1 = new Size(30, 30);
            Size size17 = size1;
            m14.Size = size17;
            this.M14.TabIndex = 14;
            this.M14.Text = "4";
            this.M14.UseVisualStyleBackColor = true;
            this.M13.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.M13.Location = new Point(98, 148);
            this.M13.Name = "M13";
            Button m13 = this.M13;
            size1 = new Size(30, 30);
            Size size18 = size1;
            m13.Size = size18;
            this.M13.TabIndex = 13;
            this.M13.Text = "3";
            this.M13.UseVisualStyleBackColor = true;
            this.M12.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.M12.Location = new Point(58, 148);
            this.M12.Name = "M12";
            Button m12 = this.M12;
            size1 = new Size(30, 30);
            Size size19 = size1;
            m12.Size = size19;
            this.M12.TabIndex = 12;
            this.M12.Text = "2";
            this.M12.UseVisualStyleBackColor = true;
            this.M11.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.M11.Location = new Point(18, 148);
            this.M11.Name = "M11";
            Button m11 = this.M11;
            size1 = new Size(30, 30);
            Size size20 = size1;
            m11.Size = size20;
            this.M11.TabIndex = 11;
            this.M11.Text = "1";
            this.M11.UseVisualStyleBackColor = true;
            this.Gr6.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Gr6.Location = new Point(353, 32);
            this.Gr6.Name = "Gr6";
            Button gr6 = this.Gr6;
            size1 = new Size(30, 30);
            Size size21 = size1;
            gr6.Size = size21;
            this.Gr6.TabIndex = 17;
            this.Gr6.Text = "6";
            this.Gr6.UseVisualStyleBackColor = true;
            this.Gr7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Gr7.Location = new Point(403, 32);
            this.Gr7.Name = "Gr7";
            Button gr7 = this.Gr7;
            size1 = new Size(30, 30);
            Size size22 = size1;
            gr7.Size = size22;
            this.Gr7.TabIndex = 18;
            this.Gr7.Text = "7";
            this.Gr7.UseVisualStyleBackColor = true;
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label4.Location = new Point(351, 13);
            this.Label4.Name = "Label4";
            Label label4 = this.Label4;
            size1 = new Size(82, 16);
            Size size23 = size1;
            label4.Size = size23;
            this.Label4.TabIndex = 19;
            this.Label4.Text = "Group size";
            this.M17.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.M17.Location = new Point(258, 148);
            this.M17.Name = "M17";
            Button m17 = this.M17;
            size1 = new Size(30, 30);
            Size size24 = size1;
            m17.Size = size24;
            this.M17.TabIndex = 24;
            this.M17.Text = "7";
            this.M17.UseVisualStyleBackColor = true;
            this.Ice7.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Ice7.Location = new Point(258, 91);
            this.Ice7.Name = "Ice7";
            Button ice7 = this.Ice7;
            size1 = new Size(30, 30);
            Size size25 = size1;
            ice7.Size = size25;
            this.Ice7.TabIndex = 23;
            this.Ice7.Text = "7";
            this.Ice7.UseVisualStyleBackColor = true;
            this.lblRemWT.AutoSize = true;
            this.lblRemWT.BackColor = Color.FromArgb((int)byte.MaxValue, 192, 128);
            this.lblRemWT.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblRemWT.ForeColor = Color.Red;
            this.lblRemWT.Location = new Point(113, 191);
            this.lblRemWT.Name = "lblRemWT";
            Label lblRemWt = this.lblRemWT;
            size1 = new Size(258, 20);
            Size size26 = size1;
            lblRemWt.Size = size26;
            this.lblRemWT.TabIndex = 41;
            this.lblRemWT.Text = "Warmup time group 1 removed!";
            this.AcceptButton = (IButtonControl)this.OK_Button;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb((int)byte.MaxValue, 192, 128);
            this.CancelButton = (IButtonControl)this.Cancel_Button;
            size1 = new Size(472, 225);
            this.ClientSize = size1;
            this.ControlBox = false;
            this.Controls.Add((Control)this.lblRemWT);
            this.Controls.Add((Control)this.M17);
            this.Controls.Add((Control)this.Ice7);
            this.Controls.Add((Control)this.Label4);
            this.Controls.Add((Control)this.Gr7);
            this.Controls.Add((Control)this.Gr6);
            this.Controls.Add((Control)this.M16);
            this.Controls.Add((Control)this.M15);
            this.Controls.Add((Control)this.M14);
            this.Controls.Add((Control)this.M13);
            this.Controls.Add((Control)this.M12);
            this.Controls.Add((Control)this.M11);
            this.Controls.Add((Control)this.Ice6);
            this.Controls.Add((Control)this.Ice5);
            this.Controls.Add((Control)this.Ice4);
            this.Controls.Add((Control)this.Ice3);
            this.Controls.Add((Control)this.Ice2);
            this.Controls.Add((Control)this.Ice1);
            this.Controls.Add((Control)this.Label3);
            this.Controls.Add((Control)this.Label2);
            this.Controls.Add((Control)this.Label1);
            this.Controls.Add((Control)this.txtNoSkater);
            this.Controls.Add((Control)this.TableLayoutPanel1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(IceResurfacingMealBreakDialog);
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Select Ice resurfacing and Meal break";
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

        internal virtual TextBox txtNoSkater
        {
            get => this._txtNoSkater;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtNoSkater = value;
        }

        internal virtual Label Label1
        {
            get => this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label1 = value;
        }

        internal virtual Label Label2
        {
            get => this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label2 = value;
        }

        internal virtual Label Label3
        {
            get => this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label3 = value;
        }

        internal virtual Button Ice1
        {
            get => this._Ice1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Ice1_Click);
                if (this._Ice1 != null)
                    this._Ice1.Click -= eventHandler;
                this._Ice1 = value;
                if (this._Ice1 == null)
                    return;
                this._Ice1.Click += eventHandler;
            }
        }

        internal virtual Button Ice2
        {
            get => this._Ice2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Ice2_Click);
                if (this._Ice2 != null)
                    this._Ice2.Click -= eventHandler;
                this._Ice2 = value;
                if (this._Ice2 == null)
                    return;
                this._Ice2.Click += eventHandler;
            }
        }

        internal virtual Button Ice3
        {
            get => this._Ice3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Ice3_Click);
                if (this._Ice3 != null)
                    this._Ice3.Click -= eventHandler;
                this._Ice3 = value;
                if (this._Ice3 == null)
                    return;
                this._Ice3.Click += eventHandler;
            }
        }

        internal virtual Button Ice4
        {
            get => this._Ice4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Ice4_Click);
                if (this._Ice4 != null)
                    this._Ice4.Click -= eventHandler;
                this._Ice4 = value;
                if (this._Ice4 == null)
                    return;
                this._Ice4.Click += eventHandler;
            }
        }

        internal virtual Button Ice5
        {
            get => this._Ice5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Ice5_Click);
                if (this._Ice5 != null)
                    this._Ice5.Click -= eventHandler;
                this._Ice5 = value;
                if (this._Ice5 == null)
                    return;
                this._Ice5.Click += eventHandler;
            }
        }

        internal virtual Button Ice6
        {
            get => this._Ice6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Ice6_Click);
                if (this._Ice6 != null)
                    this._Ice6.Click -= eventHandler;
                this._Ice6 = value;
                if (this._Ice6 == null)
                    return;
                this._Ice6.Click += eventHandler;
            }
        }

        internal virtual Button M16
        {
            get => this._M16;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.M16_Click);
                if (this._M16 != null)
                    this._M16.Click -= eventHandler;
                this._M16 = value;
                if (this._M16 == null)
                    return;
                this._M16.Click += eventHandler;
            }
        }

        internal virtual Button M15
        {
            get => this._M15;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.M15_Click);
                if (this._M15 != null)
                    this._M15.Click -= eventHandler;
                this._M15 = value;
                if (this._M15 == null)
                    return;
                this._M15.Click += eventHandler;
            }
        }

        internal virtual Button M14
        {
            get => this._M14;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.M14_Click);
                if (this._M14 != null)
                    this._M14.Click -= eventHandler;
                this._M14 = value;
                if (this._M14 == null)
                    return;
                this._M14.Click += eventHandler;
            }
        }

        internal virtual Button M13
        {
            get => this._M13;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.M13_Click);
                if (this._M13 != null)
                    this._M13.Click -= eventHandler;
                this._M13 = value;
                if (this._M13 == null)
                    return;
                this._M13.Click += eventHandler;
            }
        }

        internal virtual Button M12
        {
            get => this._M12;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.M12_Click);
                if (this._M12 != null)
                    this._M12.Click -= eventHandler;
                this._M12 = value;
                if (this._M12 == null)
                    return;
                this._M12.Click += eventHandler;
            }
        }

        internal virtual Button M11
        {
            get => this._M11;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.M11_Click);
                if (this._M11 != null)
                    this._M11.Click -= eventHandler;
                this._M11 = value;
                if (this._M11 == null)
                    return;
                this._M11.Click += eventHandler;
            }
        }

        internal virtual Button Gr6
        {
            get => this._Gr6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Gr6_Click);
                if (this._Gr6 != null)
                    this._Gr6.Click -= eventHandler;
                this._Gr6 = value;
                if (this._Gr6 == null)
                    return;
                this._Gr6.Click += eventHandler;
            }
        }

        internal virtual Button Gr7
        {
            get => this._Gr7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Gr7_Click);
                if (this._Gr7 != null)
                    this._Gr7.Click -= eventHandler;
                this._Gr7 = value;
                if (this._Gr7 == null)
                    return;
                this._Gr7.Click += eventHandler;
            }
        }

        internal virtual Label Label4
        {
            get => this._Label4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label4 = value;
        }

        internal virtual Button M17
        {
            get => this._M17;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.M17_Click);
                if (this._M17 != null)
                    this._M17.Click -= eventHandler;
                this._M17 = value;
                if (this._M17 == null)
                    return;
                this._M17.Click += eventHandler;
            }
        }

        internal virtual Button Ice7
        {
            get => this._Ice7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Ice7_Click);
                if (this._Ice7 != null)
                    this._Ice7.Click -= eventHandler;
                this._Ice7 = value;
                if (this._Ice7 == null)
                    return;
                this._Ice7.Click += eventHandler;
            }
        }

        internal virtual Label lblRemWT
        {
            get => this._lblRemWT;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblRemWT = value;
        }

        private void IceResurfacingMealBreakDialog_Load(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                this.Top = MyProject.Forms.StartListForm.Top;
                num3 = 3;
                this.Left = checked((int)Math.Round(unchecked((double)MyProject.Forms.StartListForm.Left + (double)MyProject.Forms.StartListForm.Width / 2.0 - (double)this.Width / 2.0)));
                num3 = 4;
                this.TopMost = true;
                num3 = 5;
                int index = 1;
                do
                {
                    num3 = 6;
                    this.OldIceArr_Seg1[index] = Program.IceArr_Seg1[index];
                    num3 = 7;
                    this.OldIceArr_Seg2[index] = Program.IceArr_Seg2[index];
                    num3 = 8;
                    this.OldLunchArr_Seg1[index] = Program.LunchArr_Seg1[index];
                    num3 = 9;
                    this.OldLunchArr_Seg2[index] = Program.LunchArr_Seg2[index];
                    num3 = 10;
                    checked { ++index; }
                }
                while (index <= 7);
                num3 = 11;
                this.OldWupG_Seg1 = Program.WupG_Seg1;
                num3 = 12;
                this.OldWupG_Seg2 = Program.WupG_Seg2;
                num3 = 13;
                string segment = Program.Segment;
                num3 = 16;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    num3 = 17;
                    switch (Program.WupG_Seg1)
                    {
                        case 6:
                            num3 = 21;
                            this.Gr66();
                            break;
                        case 7:
                            num3 = 24;
                            this.Gr77();
                            break;
                        case 8:
                            num3 = 27;
                            this.Gr88();
                            break;
                        default:
                            num3 = 30;
                            this.Gr66();
                            break;
                    }
                    num3 = 32;
                    if (Program.RemWarmupTimeSeg1)
                    {
                        num3 = 33;
                        this.lblRemWT.Visible = true;
                    }
                    else
                    {
                        num3 = 35;
                        num3 = 36;
                        this.lblRemWT.Visible = false;
                    }
                }
                else
                {
                    num3 = 39;
                    if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        num3 = 40;
                        switch (Program.WupG_Seg2)
                        {
                            case 6:
                                num3 = 44;
                                this.Gr66();
                                break;
                            case 7:
                                num3 = 47;
                                this.Gr77();
                                break;
                            case 8:
                                num3 = 50;
                                this.Gr88();
                                break;
                            default:
                                num3 = 53;
                                this.Gr66();
                                break;
                        }
                        num3 = 55;
                        if (Program.RemWarmupTimeSeg2)
                        {
                            num3 = 56;
                            this.lblRemWT.Visible = true;
                        }
                        else
                        {
                            num3 = 58;
                            num3 = 59;
                            this.lblRemWT.Visible = false;
                        }
                    }
                }
                num3 = 62;
                this.Get_Ice_Lunch();
                num3 = 63;
                this.SetGroupSize();
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
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
                string segment = Program.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    Program.IceArr_Seg1 = (int[])null;
                    Program.IceArr_Seg1 = new int[8];
                    Program.LunchArr_Seg1 = (int[])null;
                    Program.LunchArr_Seg1 = new int[8];
                    int ReNo = 1;
                    do
                    {
                        string key1 = "Ice" + Strings.Trim(Conversions.ToString(ReNo));
                        string key2 = "M" + Strings.Trim(Conversions.ToString(checked(ReNo + 10)));
                        if (this.Controls[key1].Visible & this.Controls[key1].BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0))
                            Program.IceArr_Seg1[ReNo] = Program.CalcRes(ref Program.gr, ReNo);
                        if (this.Controls[key2].Visible & this.Controls[key2].BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0))
                            Program.LunchArr_Seg1[ReNo] = Program.CalcLunch(ref Program.gr, checked(ReNo + 10));
                        checked { ++ReNo; }
                    }
                    while (ReNo <= 7);
                }
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                {
                    Program.IceArr_Seg2 = (int[])null;
                    Program.IceArr_Seg2 = new int[8];
                    Program.LunchArr_Seg2 = (int[])null;
                    Program.LunchArr_Seg2 = new int[8];
                    int ReNo = 1;
                    do
                    {
                        string key3 = "Ice" + Strings.Trim(Conversions.ToString(ReNo));
                        string key4 = "M" + Strings.Trim(Conversions.ToString(checked(ReNo + 10)));
                        if (this.Controls[key3].Visible & this.Controls[key3].BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0))
                            Program.IceArr_Seg2[ReNo] = Program.CalcRes(ref Program.gr, ReNo);
                        if (this.Controls[key4].Visible & this.Controls[key4].BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0))
                            Program.LunchArr_Seg2[ReNo] = Program.CalcLunch(ref Program.gr, checked(ReNo + 10));
                        checked { ++ReNo; }
                    }
                    while (ReNo <= 7);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
                MyProject.Forms.WarmupGroupsForm.TopMost = true;
                MyProject.Forms.WarmupGroupsForm.CreateWarmup_2(0);
                goto label_21;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("IceResurfacingMealBreakDialog, OK_Button_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_21:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int index = 1;
                do
                {
                    num3 = 3;
                    Program.IceArr_Seg1[index] = this.OldIceArr_Seg1[index];
                    num3 = 4;
                    Program.IceArr_Seg2[index] = this.OldIceArr_Seg2[index];
                    num3 = 5;
                    Program.LunchArr_Seg1[index] = this.OldLunchArr_Seg1[index];
                    num3 = 6;
                    Program.LunchArr_Seg2[index] = this.OldLunchArr_Seg2[index];
                    num3 = 7;
                    checked { ++index; }
                }
                while (index <= 7);
                num3 = 8;
                Program.WupG_Seg1 = this.OldWupG_Seg1;
                num3 = 9;
                Program.WupG_Seg2 = this.OldWupG_Seg2;
                num3 = 10;
                MyProject.Forms.WarmupGroupsForm.TopMost = true;
                num3 = 11;
                this.DialogResult = DialogResult.Cancel;
                num3 = 12;
                this.Close();
                num3 = 13;
                MyProject.Forms.WarmupGroupsForm.Close();
                num3 = 14;
                MyProject.Forms.StartListForm.TopMost = true;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void ClearButtons()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int num3 = 1;
                do
                {
                    this.Controls["Ice" + Strings.Trim(Conversions.ToString(num3))].BackColor = Color.FromArgb(236, 233, 216);
                    checked { ++num3; }
                }
                while (num3 <= 7);
                int num4 = 11;
                do
                {
                    this.Controls["M" + Strings.Trim(Conversions.ToString(num4))].BackColor = Color.FromArgb(236, 233, 216);
                    checked { ++num4; }
                }
                while (num4 <= 17);
                goto label_10;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("IceResurfacingMealBreakDialog, ClearButtons - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_10:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void SetReNo(int no)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int num4 = 0;
                num3 = 3;
                string key1;
                if (no < 7)
                {
                    num3 = 4;
                    key1 = "Ice" + Strings.Trim(Conversions.ToString(no));
                }
                else
                {
                    num3 = 6;
                    num3 = 7;
                    key1 = "M" + Strings.Trim(Conversions.ToString(no));
                }
                num3 = 9;
                if (this.Controls[key1].BackColor != Color.FromArgb((int)byte.MaxValue, 0, 0))
                {
                    num3 = 10;
                    this.Controls[key1].BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                }
                else
                {
                    num3 = 12;
                    num3 = 13;
                    this.Controls[key1].BackColor = Color.FromArgb(236, 233, 216);
                }
                num3 = 15;
                int num5 = 1;
                do
                {
                    num3 = 16;
                    if (num5 <= 7 | num5 > 10)
                    {
                        num3 = 17;
                        string key2;
                        if (num5 <= 7)
                        {
                            num3 = 18;
                            key2 = "Ice" + Strings.Trim(Conversions.ToString(num5));
                        }
                        else
                        {
                            num3 = 20;
                            num3 = 21;
                            key2 = "M" + Strings.Trim(Conversions.ToString(num5));
                        }
                        num3 = 23;
                        if (this.Controls[key2].Visible & this.Controls[key2].BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0))
                        {
                            num3 = 24;
                            checked { ++num4; }
                        }
                        num3 = 26;
                        if (num4 > 7)
                        {
                            num3 = 27;
                            string key3;
                            if (no <= 7)
                            {
                                num3 = 28;
                                key3 = "Ice" + Strings.Trim(Conversions.ToString(no));
                            }
                            else
                            {
                                num3 = 30;
                                num3 = 31;
                                key3 = "M" + Strings.Trim(Conversions.ToString(no));
                            }
                            num3 = 33;
                            if (this.Controls[key3].Visible & this.Controls[key3].BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0))
                            {
                                num3 = 34;
                                this.Controls[key3].BackColor = Color.FromArgb(236, 233, 216);
                                break;
                            }
                            break;
                        }
                    }
                    num3 = 39;
                    checked { ++num5; }
                }
                while (num5 <= 17);
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void SetGroupSize()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int grSize = Program.OpenDB[Program.PcIndex].GrSize;
                num3 = 5;
                if (grSize == 6)
                {
                    num3 = 6;
                    this.Gr6.Visible = true;
                    num3 = 7;
                    this.Gr7.Visible = false;
                }
                else
                {
                    num3 = 9;
                    if (grSize == 7)
                    {
                        num3 = 10;
                        this.Gr6.Visible = true;
                        num3 = 11;
                        this.Gr7.Text = "7";
                        num3 = 12;
                        this.Gr7.Visible = false;
                    }
                    else
                    {
                        num3 = 14;
                        if (grSize == 8)
                        {
                            num3 = 15;
                            this.Gr6.Visible = false;
                            num3 = 16;
                            this.Gr7.Text = "8";
                            num3 = 17;
                            this.Gr7.Visible = true;
                        }
                        else
                        {
                            num3 = 19;
                            if (grSize == 67)
                            {
                                num3 = 20;
                                this.Gr6.Visible = true;
                                num3 = 21;
                                this.Gr7.Text = "7";
                                num3 = 22;
                                this.Gr7.Visible = true;
                            }
                            else
                            {
                                num3 = 24;
                                if (grSize == 68)
                                {
                                    num3 = 25;
                                    this.Gr6.Visible = true;
                                    num3 = 26;
                                    this.Gr7.Text = "8";
                                    num3 = 27;
                                    this.Gr7.Visible = true;
                                }
                                else
                                {
                                    num3 = 30;
                                    this.Gr6.Visible = true;
                                    num3 = 31;
                                    this.Gr7.Visible = false;
                                }
                            }
                        }
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

        public void Get_Ice_Lunch()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int num4 = 0;
                num3 = 3;
                string segment = Program.Segment;
                num3 = 6;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    num3 = 7;
                    int index = 1;
                    do
                    {
                        num3 = 8;
                        string key1 = "Ice" + Strings.Trim(Conversions.ToString(index));
                        num3 = 9;
                        string key2 = "M" + Strings.Trim(Conversions.ToString(checked(index + 10)));
                        num3 = 10;
                        checked { num4 += Program.gr[index]; }
                        num3 = 11;
                        if (num4 == Program.IceArr_Seg1[index])
                        {
                            num3 = 12;
                            this.Controls[key1].BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                        }
                        else
                        {
                            num3 = 14;
                            num3 = 15;
                            this.Controls[key1].BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                        }
                        num3 = 17;
                        if (num4 == Program.LunchArr_Seg1[index])
                        {
                            num3 = 18;
                            this.Controls[key2].BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                        }
                        else
                        {
                            num3 = 20;
                            num3 = 21;
                            this.Controls[key2].BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                        }
                        num3 = 23;
                        checked { ++index; }
                    }
                    while (index <= 7);
                    num3 = 24;
                }
                else
                {
                    num3 = 26;
                    if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        num3 = 27;
                        int index = 1;
                        do
                        {
                            num3 = 28;
                            string key3 = "Ice" + Strings.Trim(Conversions.ToString(index));
                            num3 = 29;
                            string key4 = "M" + Strings.Trim(Conversions.ToString(checked(index + 10)));
                            num3 = 30;
                            checked { num4 += Program.gr[index]; }
                            num3 = 31;
                            if (num4 == Program.IceArr_Seg2[index])
                            {
                                num3 = 32;
                                this.Controls[key3].BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                            }
                            else
                            {
                                num3 = 34;
                                num3 = 35;
                                this.Controls[key3].BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                            }
                            num3 = 37;
                            if (num4 == Program.LunchArr_Seg2[index])
                            {
                                num3 = 38;
                                this.Controls[key4].BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                            }
                            else
                            {
                                num3 = 40;
                                num3 = 41;
                                this.Controls[key4].BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                            }
                            num3 = 43;
                            checked { ++index; }
                        }
                        while (index <= 7);
                        num3 = 44;
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

        private void Ice1_Click(object sender, EventArgs e) => this.SetReNo(1);

        private void Ice2_Click(object sender, EventArgs e) => this.SetReNo(2);

        private void Ice3_Click(object sender, EventArgs e) => this.SetReNo(3);

        private void Ice4_Click(object sender, EventArgs e) => this.SetReNo(4);

        private void Ice5_Click(object sender, EventArgs e) => this.SetReNo(5);

        private void Ice6_Click(object sender, EventArgs e) => this.SetReNo(6);

        private void Ice7_Click(object sender, EventArgs e) => this.SetReNo(7);

        private void M11_Click(object sender, EventArgs e) => this.SetReNo(11);

        private void M12_Click(object sender, EventArgs e) => this.SetReNo(12);

        private void M13_Click(object sender, EventArgs e) => this.SetReNo(13);

        private void M14_Click(object sender, EventArgs e) => this.SetReNo(14);

        private void M15_Click(object sender, EventArgs e) => this.SetReNo(15);

        private void M16_Click(object sender, EventArgs e) => this.SetReNo(16);

        private void M17_Click(object sender, EventArgs e) => this.SetReNo(17);

        private void Gr66()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                this.Gr6.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                num3 = 3;
                this.Gr7.BackColor = Color.FromArgb(236, 233, 216);
                num3 = 4;
                string segment = Program.Segment;
                num3 = 7;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    num3 = 8;
                    Program.WupG_Seg1 = 6;
                }
                else
                {
                    num3 = 10;
                    if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        num3 = 11;
                        Program.WupG_Seg2 = 6;
                    }
                }
                num3 = 13;
                int index = 1;
                do
                {
                    num3 = 14;
                    Program.gr[index] = 0;
                    num3 = 15;
                    checked { ++index; }
                }
                while (index <= 7);
                num3 = 16;
                MyProject.Forms.WarmupGroupsForm.CalcGroup1(Conversions.ToInteger(this.txtNoSkater.Text), ref Program.gr);
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Gr6_Click(object sender, EventArgs e) => this.Gr66();

        private void Gr77()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                this.Gr7.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                num3 = 3;
                this.Gr6.BackColor = Color.FromArgb(236, 233, 216);
                num3 = 4;
                string segment = Program.Segment;
                num3 = 7;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    num3 = 8;
                    Program.WupG_Seg1 = 7;
                }
                else
                {
                    num3 = 10;
                    if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        num3 = 11;
                        Program.WupG_Seg2 = 7;
                    }
                }
                num3 = 13;
                int index = 1;
                do
                {
                    num3 = 14;
                    Program.gr[index] = 0;
                    num3 = 15;
                    checked { ++index; }
                }
                while (index <= 7);
                num3 = 16;
                MyProject.Forms.WarmupGroupsForm.CalcGroup1(Conversions.ToInteger(this.txtNoSkater.Text), ref Program.gr);
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Gr88()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                this.Gr7.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                num3 = 3;
                this.Gr6.BackColor = Color.FromArgb(236, 233, 216);
                num3 = 4;
                string segment = Program.Segment;
                num3 = 7;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    num3 = 8;
                    Program.WupG_Seg1 = 8;
                }
                else
                {
                    num3 = 10;
                    if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        num3 = 11;
                        Program.WupG_Seg2 = 8;
                    }
                }
                num3 = 13;
                int index = 1;
                do
                {
                    num3 = 14;
                    Program.gr[index] = 0;
                    num3 = 15;
                    checked { ++index; }
                }
                while (index <= 7);
                num3 = 16;
                MyProject.Forms.WarmupGroupsForm.CalcGroup1(Conversions.ToInteger(this.txtNoSkater.Text), ref Program.gr);
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Gr7_Click(object sender, EventArgs e)
        {
            string text = this.Gr7.Text;
            if (Operators.CompareString(text, "7", false) == 0)
            {
                this.Gr77();
            }
            else
            {
                if (Operators.CompareString(text, "8", false) != 0)
                    return;
                this.Gr88();
            }
        }
    }
}

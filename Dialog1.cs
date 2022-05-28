// Decompiled with JetBrains decompiler
// Type: ClubCompFS.Dialog1
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
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ClubCompFS
{
    [DesignerGenerated]
    public class Dialog1 : Form
    {
        private IContainer components;
        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;
        [AccessedThroughProperty("OK_Button")]
        private Button _OK_Button;
        [AccessedThroughProperty("Cancel_Button")]
        private Button _Cancel_Button;
        [AccessedThroughProperty("TextBox1")]
        private TextBox _TextBox1;
        [AccessedThroughProperty("TextBox2")]
        private TextBox _TextBox2;
        [AccessedThroughProperty("DateTimePicker1")]
        private DateTimePicker _DateTimePicker1;
        [AccessedThroughProperty("DateTimePicker2")]
        private DateTimePicker _DateTimePicker2;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("DataGridView1")]
        private DataGridView _DataGridView1;
        [AccessedThroughProperty("btnSeg1")]
        private Button _btnSeg1;
        [AccessedThroughProperty("btnSeg2")]
        private Button _btnSeg2;
        [AccessedThroughProperty("Column1")]
        private DataGridViewTextBoxColumn _Column1;
        [AccessedThroughProperty("Column2")]
        private DataGridViewTextBoxColumn _Column2;
        [AccessedThroughProperty("txtCategoryID")]
        private TextBox _txtCategoryID;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("txtIndTADisc")]
        private TextBox _txtIndTADisc;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("txtIndTAClass")]
        private TextBox _txtIndTAClass;
        [AccessedThroughProperty("ComboBox1")]
        private ComboBox _ComboBox1;
        [AccessedThroughProperty("txtWarmup")]
        private TextBox _txtWarmup;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("btnRemoveWarmupTime")]
        private Button _btnRemoveWarmupTime;
        private const string CloseDownD1 = "VABpAG0AZQBsAGkAbQBpAHQAIABoAGEAcwAgAHAAYQBzAHMAZQBkACEADQAKAFQAaABlACAAcAByAG8AZwByAGEAbQAgAHcAaQBsAGwAIABjAGwAbwBzAGUAIABkAG8AdwBuACEA";
        private string OldCategory;
        private string OldCategoryID;
        private string OldIndTADiscipline;
        private string OldIndTAClass;
        private string OldSubcategory;
        private string Oldsegment;
        private DateTime OldDatumSeg1;
        private DateTime OldDatumSeg2;
        private string OldTimeSeg1;
        private string OldTimeSeg2;
        private string OldWarmup;
        private bool OldRemWarmupTimeSeg1;
        private bool OldRemWarmupTimeSeg2;
        private string MaxDateD1;

        public Dialog1()
        {
            this.Load += new EventHandler(this.Dialog1_Load);
            this.MaxDateD1 = "736973632000000000";
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
            DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Dialog1));
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.OK_Button = new Button();
            this.Cancel_Button = new Button();
            this.TextBox1 = new TextBox();
            this.TextBox2 = new TextBox();
            this.DateTimePicker1 = new DateTimePicker();
            this.DateTimePicker2 = new DateTimePicker();
            this.Label2 = new Label();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this.DataGridView1 = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.btnSeg1 = new Button();
            this.btnSeg2 = new Button();
            this.txtCategoryID = new TextBox();
            this.Label5 = new Label();
            this.Label6 = new Label();
            this.txtIndTADisc = new TextBox();
            this.Label7 = new Label();
            this.Label1 = new Label();
            this.txtIndTAClass = new TextBox();
            this.ComboBox1 = new ComboBox();
            this.txtWarmup = new TextBox();
            this.Label8 = new Label();
            this.btnRemoveWarmupTime = new Button();
            this.TableLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)this.DataGridView1).BeginInit();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.TableLayoutPanel1.BackColor = SystemColors.Control;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add((Control)this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add((Control)this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new Point(475, 458);
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
            this.TextBox1.BackColor = Color.White;
            this.TextBox1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.TextBox1.Location = new Point(3, 29);
            this.TextBox1.Multiline = true;
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            TextBox textBox1 = this.TextBox1;
            size1 = new Size(257, 27);
            Size size5 = size1;
            textBox1.Size = size5;
            this.TextBox1.TabIndex = 2;
            this.TextBox2.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.TextBox2.Location = new Point(144, 81);
            this.TextBox2.Multiline = true;
            this.TextBox2.Name = "TextBox2";
            TextBox textBox2 = this.TextBox2;
            size1 = new Size(251, 28);
            Size size6 = size1;
            textBox2.Size = size6;
            this.TextBox2.TabIndex = 3;
            this.TextBox2.Visible = false;
            this.DateTimePicker1.CustomFormat = "";
            this.DateTimePicker1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DateTimePicker1.Format = DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new Point(450, 193);
            this.DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker dateTimePicker1 = this.DateTimePicker1;
            size1 = new Size(171, 26);
            Size size7 = size1;
            dateTimePicker1.Size = size7;
            this.DateTimePicker1.TabIndex = 7;
            this.DateTimePicker2.CustomFormat = "HH:mm";
            this.DateTimePicker2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.DateTimePicker2.Location = new Point(450, 251);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.ShowUpDown = true;
            DateTimePicker dateTimePicker2 = this.DateTimePicker2;
            size1 = new Size(101, 26);
            Size size8 = size1;
            dateTimePicker2.Size = size8;
            this.DateTimePicker2.TabIndex = 9;
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new Point(447, 231);
            this.Label2.Name = "Label2";
            Label label2 = this.Label2;
            size1 = new Size(78, 17);
            Size size9 = size1;
            label2.Size = size9;
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Start time";
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new Point(0, 9);
            this.Label3.Name = "Label3";
            Label label3 = this.Label3;
            size1 = new Size(73, 17);
            Size size10 = size1;
            label3.Size = size10;
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Category";
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label4.Location = new Point(0, 66);
            this.Label4.Name = "Label4";
            Label label4 = this.Label4;
            size1 = new Size(99, 17);
            Size size11 = size1;
            label4.Size = size11;
            this.Label4.TabIndex = 13;
            this.Label4.Text = "Subcategory";
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange((DataGridViewColumn)this.Column1, (DataGridViewColumn)this.Column2);
            this.DataGridView1.Location = new Point(3, 118);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView1.ScrollBars = ScrollBars.Vertical;
            DataGridView dataGridView1 = this.DataGridView1;
            size1 = new Size(406, 376);
            Size size12 = size1;
            dataGridView1.Size = size12;
            this.DataGridView1.TabIndex = 14;
            this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column1.DefaultCellStyle = gridViewCellStyle1;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Category";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = DataGridViewTriState.False;
            this.Column1.Width = (int)byte.MaxValue;
            this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column2.DefaultCellStyle = gridViewCellStyle2;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Program";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = DataGridViewTriState.False;
            this.Column2.Width = 130;
            this.btnSeg1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.btnSeg1.Location = new Point(450, 135);
            this.btnSeg1.Name = "btnSeg1";
            Button btnSeg1 = this.btnSeg1;
            size1 = new Size(80, 26);
            Size size13 = size1;
            btnSeg1.Size = size13;
            this.btnSeg1.TabIndex = 15;
            this.btnSeg1.Text = "SHORT";
            this.btnSeg1.UseVisualStyleBackColor = true;
            this.btnSeg2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.btnSeg2.Location = new Point(546, 135);
            this.btnSeg2.Name = "btnSeg2";
            Button btnSeg2 = this.btnSeg2;
            size1 = new Size(80, 26);
            Size size14 = size1;
            btnSeg2.Size = size14;
            this.btnSeg2.TabIndex = 16;
            this.btnSeg2.Text = "FREE";
            this.btnSeg2.UseVisualStyleBackColor = true;
            this.txtCategoryID.BackColor = Color.White;
            this.txtCategoryID.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtCategoryID.Location = new Point(288, 29);
            this.txtCategoryID.Multiline = true;
            this.txtCategoryID.Name = "txtCategoryID";
            TextBox txtCategoryId = this.txtCategoryID;
            size1 = new Size(107, 27);
            Size size15 = size1;
            txtCategoryId.Size = size15;
            this.txtCategoryID.TabIndex = 22;
            this.txtCategoryID.Visible = false;
            this.Label5.AutoSize = true;
            this.Label5.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label5.Location = new Point(285, 9);
            this.Label5.Name = "Label5";
            Label label5 = this.Label5;
            size1 = new Size(93, 17);
            Size size16 = size1;
            label5.Size = size16;
            this.Label5.TabIndex = 23;
            this.Label5.Text = "Category ID";
            this.Label5.Visible = false;
            this.Label6.AutoSize = true;
            this.Label6.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label6.Location = new Point(429, 9);
            this.Label6.Name = "Label6";
            Label label6 = this.Label6;
            size1 = new Size(125, 17);
            Size size17 = size1;
            label6.Size = size17;
            this.Label6.TabIndex = 24;
            this.Label6.Text = "IndTA Discipline";
            this.txtIndTADisc.BackColor = Color.White;
            this.txtIndTADisc.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtIndTADisc.Location = new Point(432, 29);
            this.txtIndTADisc.Multiline = true;
            this.txtIndTADisc.Name = "txtIndTADisc";
            TextBox txtIndTaDisc = this.txtIndTADisc;
            size1 = new Size(218, 27);
            Size size18 = size1;
            txtIndTaDisc.Size = size18;
            this.txtIndTADisc.TabIndex = 25;
            this.Label7.AutoSize = true;
            this.Label7.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label7.Location = new Point(447, 173);
            this.Label7.Name = "Label7";
            Label label7 = this.Label7;
            size1 = new Size(42, 17);
            Size size19 = size1;
            label7.Size = size19;
            this.Label7.TabIndex = 10;
            this.Label7.Text = "Date";
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new Point(431, 66);
            this.Label1.Name = "Label1";
            Label label1 = this.Label1;
            size1 = new Size(94, 17);
            Size size20 = size1;
            label1.Size = size20;
            this.Label1.TabIndex = 26;
            this.Label1.Text = "IndTA Class";
            this.txtIndTAClass.BackColor = Color.White;
            this.txtIndTAClass.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtIndTAClass.Location = new Point(432, 85);
            this.txtIndTAClass.Multiline = true;
            this.txtIndTAClass.Name = "txtIndTAClass";
            TextBox txtIndTaClass = this.txtIndTAClass;
            size1 = new Size(218, 27);
            Size size21 = size1;
            txtIndTaClass.Size = size21;
            this.txtIndTAClass.TabIndex = 27;
            this.ComboBox1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new Point(3, 85);
            this.ComboBox1.Name = "ComboBox1";
            ComboBox comboBox1 = this.ComboBox1;
            size1 = new Size(106, 24);
            Size size22 = size1;
            comboBox1.Size = size22;
            this.ComboBox1.TabIndex = 35;
            this.txtWarmup.BackColor = Color.White;
            this.txtWarmup.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtWarmup.Location = new Point(450, 312);
            this.txtWarmup.Multiline = true;
            this.txtWarmup.Name = "txtWarmup";
            TextBox txtWarmup = this.txtWarmup;
            size1 = new Size(101, 27);
            Size size23 = size1;
            txtWarmup.Size = size23;
            this.txtWarmup.TabIndex = 38;
            this.Label8.AutoSize = true;
            this.Label8.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label8.Location = new Point(447, 292);
            this.Label8.Name = "Label8";
            Label label8 = this.Label8;
            size1 = new Size(191, 17);
            Size size24 = size1;
            label8.Size = size24;
            this.Label8.TabIndex = 39;
            this.Label8.Text = "Warmup time (HH:mm:ss)";
            this.btnRemoveWarmupTime.BackColor = SystemColors.ButtonFace;
            this.btnRemoveWarmupTime.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.btnRemoveWarmupTime.Location = new Point(450, 355);
            this.btnRemoveWarmupTime.Name = "btnRemoveWarmupTime";
            Button removeWarmupTime = this.btnRemoveWarmupTime;
            size1 = new Size(188, 58);
            Size size25 = size1;
            removeWarmupTime.Size = size25;
            this.btnRemoveWarmupTime.TabIndex = 41;
            this.btnRemoveWarmupTime.Text = "REMOVE WARMUP TIME GROUP 1";
            this.btnRemoveWarmupTime.UseVisualStyleBackColor = false;
            this.AcceptButton = (IButtonControl)this.OK_Button;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb((int)byte.MaxValue, 192, 128);
            this.CancelButton = (IButtonControl)this.Cancel_Button;
            size1 = new Size(671, 499);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.btnRemoveWarmupTime);
            this.Controls.Add((Control)this.txtWarmup);
            this.Controls.Add((Control)this.Label8);
            this.Controls.Add((Control)this.ComboBox1);
            this.Controls.Add((Control)this.txtIndTAClass);
            this.Controls.Add((Control)this.Label1);
            this.Controls.Add((Control)this.txtIndTADisc);
            this.Controls.Add((Control)this.Label6);
            this.Controls.Add((Control)this.txtCategoryID);
            this.Controls.Add((Control)this.Label5);
            this.Controls.Add((Control)this.btnSeg2);
            this.Controls.Add((Control)this.btnSeg1);
            this.Controls.Add((Control)this.DataGridView1);
            this.Controls.Add((Control)this.Label4);
            this.Controls.Add((Control)this.Label3);
            this.Controls.Add((Control)this.Label2);
            this.Controls.Add((Control)this.Label7);
            this.Controls.Add((Control)this.DateTimePicker2);
            this.Controls.Add((Control)this.DateTimePicker1);
            this.Controls.Add((Control)this.TextBox2);
            this.Controls.Add((Control)this.TextBox1);
            this.Controls.Add((Control)this.TableLayoutPanel1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(Dialog1);
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Select Category, Program, Start time and Date";
            this.TopMost = true;
            this.TableLayoutPanel1.ResumeLayout(false);
            ((ISupportInitialize)this.DataGridView1).EndInit();
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

        internal virtual TextBox TextBox1
        {
            get => this._TextBox1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._TextBox1 = value;
        }

        internal virtual TextBox TextBox2
        {
            get => this._TextBox2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.TextBox2_KeyPress);
                if (this._TextBox2 != null)
                    this._TextBox2.KeyPress -= pressEventHandler;
                this._TextBox2 = value;
                if (this._TextBox2 == null)
                    return;
                this._TextBox2.KeyPress += pressEventHandler;
            }
        }

        internal virtual DateTimePicker DateTimePicker1
        {
            get => this._DateTimePicker1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler1 = new EventHandler(this.DateTimePicker1_ValueChanged);
                EventHandler eventHandler2 = new EventHandler(this.DateTimePicker1_ValueChanged);
                if (this._DateTimePicker1 != null)
                {
                    this._DateTimePicker1.ValueChanged -= eventHandler1;
                    this._DateTimePicker1.ValueChanged -= eventHandler2;
                }
                this._DateTimePicker1 = value;
                if (this._DateTimePicker1 == null)
                    return;
                this._DateTimePicker1.ValueChanged += eventHandler1;
                this._DateTimePicker1.ValueChanged += eventHandler2;
            }
        }

        internal virtual DateTimePicker DateTimePicker2
        {
            get => this._DateTimePicker2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.DateTimePicker2_ValueChanged);
                if (this._DateTimePicker2 != null)
                    this._DateTimePicker2.ValueChanged -= eventHandler;
                this._DateTimePicker2 = value;
                if (this._DateTimePicker2 == null)
                    return;
                this._DateTimePicker2.ValueChanged += eventHandler;
            }
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

        internal virtual Label Label4
        {
            get => this._Label4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label4 = value;
        }

        internal virtual DataGridView DataGridView1
        {
            get => this._DataGridView1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
                if (this._DataGridView1 != null)
                    this._DataGridView1.CellDoubleClick -= cellEventHandler;
                this._DataGridView1 = value;
                if (this._DataGridView1 == null)
                    return;
                this._DataGridView1.CellDoubleClick += cellEventHandler;
            }
        }

        internal virtual Button btnSeg1
        {
            get => this._btnSeg1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnSeg1_Click_1);
                if (this._btnSeg1 != null)
                    this._btnSeg1.Click -= eventHandler;
                this._btnSeg1 = value;
                if (this._btnSeg1 == null)
                    return;
                this._btnSeg1.Click += eventHandler;
            }
        }

        internal virtual Button btnSeg2
        {
            get => this._btnSeg2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnSeg2_Click_1);
                if (this._btnSeg2 != null)
                    this._btnSeg2.Click -= eventHandler;
                this._btnSeg2 = value;
                if (this._btnSeg2 == null)
                    return;
                this._btnSeg2.Click += eventHandler;
            }
        }

        internal virtual DataGridViewTextBoxColumn Column1
        {
            get => this._Column1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column1 = value;
        }

        internal virtual DataGridViewTextBoxColumn Column2
        {
            get => this._Column2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column2 = value;
        }

        internal virtual TextBox txtCategoryID
        {
            get => this._txtCategoryID;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CategoryID_KeyPress);
                if (this._txtCategoryID != null)
                    this._txtCategoryID.KeyPress -= pressEventHandler;
                this._txtCategoryID = value;
                if (this._txtCategoryID == null)
                    return;
                this._txtCategoryID.KeyPress += pressEventHandler;
            }
        }

        internal virtual Label Label5
        {
            get => this._Label5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label5 = value;
        }

        internal virtual Label Label6
        {
            get => this._Label6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label6 = value;
        }

        internal virtual TextBox txtIndTADisc
        {
            get => this._txtIndTADisc;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtIndTADisc_KeyPress);
                if (this._txtIndTADisc != null)
                    this._txtIndTADisc.KeyPress -= pressEventHandler;
                this._txtIndTADisc = value;
                if (this._txtIndTADisc == null)
                    return;
                this._txtIndTADisc.KeyPress += pressEventHandler;
            }
        }

        internal virtual Label Label7
        {
            get => this._Label7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label7 = value;
        }

        internal virtual Label Label1
        {
            get => this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label1 = value;
        }

        internal virtual TextBox txtIndTAClass
        {
            get => this._txtIndTAClass;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtIndTAClass_KeyPress);
                if (this._txtIndTAClass != null)
                    this._txtIndTAClass.KeyPress -= pressEventHandler;
                this._txtIndTAClass = value;
                if (this._txtIndTAClass == null)
                    return;
                this._txtIndTAClass.KeyPress += pressEventHandler;
            }
        }

        internal virtual ComboBox ComboBox1
        {
            get => this._ComboBox1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.ComboBox1_KeyPress);
                if (this._ComboBox1 != null)
                    this._ComboBox1.KeyPress -= pressEventHandler;
                this._ComboBox1 = value;
                if (this._ComboBox1 == null)
                    return;
                this._ComboBox1.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox txtWarmup
        {
            get => this._txtWarmup;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.txtWarmup_Leave);
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtWarmup_KeyPress);
                if (this._txtWarmup != null)
                {
                    this._txtWarmup.Leave -= eventHandler;
                    this._txtWarmup.KeyPress -= pressEventHandler;
                }
                this._txtWarmup = value;
                if (this._txtWarmup == null)
                    return;
                this._txtWarmup.Leave += eventHandler;
                this._txtWarmup.KeyPress += pressEventHandler;
            }
        }

        internal virtual Label Label8
        {
            get => this._Label8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label8 = value;
        }

        internal virtual Button btnRemoveWarmupTime
        {
            get => this._btnRemoveWarmupTime;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnRemoveWarmupTime_Click);
                if (this._btnRemoveWarmupTime != null)
                    this._btnRemoveWarmupTime.Click -= eventHandler;
                this._btnRemoveWarmupTime = value;
                if (this._btnRemoveWarmupTime == null)
                    return;
                this._btnRemoveWarmupTime.Click += eventHandler;
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.DialogResult = DialogResult.OK;
                if (Module1.TNop > 0 & (Operators.CompareString(this.TextBox1.Text, this.OldCategory, false) != 0 | Operators.CompareString(this.ComboBox1.Text, this.OldSubcategory, false) != 0))
                {
                    switch (Interaction.MsgBox((object)"Do you want to clear the skater's data?", MsgBoxStyle.YesNoCancel | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW"))
                    {
                        case MsgBoxResult.Cancel:
                            this.TextBox1.Text = this.OldCategory;
                            this.ComboBox1.Text = this.OldSubcategory;
                            this.txtCategoryID.Text = this.OldCategoryID;
                            this.txtIndTADisc.Text = this.OldIndTADiscipline;
                            this.txtIndTAClass.Text = this.OldIndTAClass;
                            goto label_22;
                        case MsgBoxResult.Yes:
                            MyProject.Forms.Form1.InitVariables();
                            break;
                    }
                }
                if (Strings.Len(this.TextBox1.Text) > 2)
                {
                    Module1.Category.Name = this.TextBox1.Text;
                    Module1.Category.ID = this.txtCategoryID.Text;
                    Module1.Category.IndTADiscipline = this.txtIndTADisc.Text;
                    Module1.Category.IndTAClass = this.txtIndTAClass.Text;
                    Module1.CalcPCindex();
                    Module1.WarmUpTime = this.txtWarmup.Text;
                    Module1.SubCategory = Strings.Trim(this.ComboBox1.Text);
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        Module1.Datum.Seg1 = this.DateTimePicker1.Value;
                        Module1.Datum.Seg1Start = this.DateTimePicker2.Text;
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        Module1.Datum.Seg2 = this.DateTimePicker1.Value;
                        Module1.Datum.Seg2Start = this.DateTimePicker2.Text;
                    }
                    else
                    {
                        Module1.Datum.Seg1 = this.DateTimePicker1.Value;
                        Module1.Datum.Seg1Start = this.DateTimePicker2.Text;
                        Module1.Datum.Seg2 = this.DateTimePicker1.Value;
                        Module1.Datum.Seg2Start = this.DateTimePicker2.Text;
                    }
                    this.TimeLimitD1(Module1.Datum.Seg1.ToString("yyyy-MM-dd"));
                    this.TimeLimitD1(Module1.Datum.Seg2.ToString("yyyy-MM-dd"));
                    if (this.btnSeg1.BackColor == Color.Green)
                        Module1.Segment = "Seg1";
                    if (this.btnSeg2.BackColor == Color.Green)
                        Module1.Segment = "Seg2";
                    this.Close();
                    MyProject.Forms.Form1.txtCompetitionName.Enabled = false;
                    MyProject.Forms.Form1.btnSeg1Seg2();
                    Module1.SetNoJ();
                    Module1.CreateForm1();
                    Module1.SaveCategoryFile(Module1.CategoryFileName);
                    MyProject.Forms.Form1.txtCompetitionName.Enabled = true;
                    MyProject.Forms.Form1.txtCompetitionName.Select();
                    goto label_22;
                }
                else
                {
                    this.Close();
                    goto label_22;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("OK_Button_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_22:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void TimeLimitD1(string Nu)
        {
            string Right = DateTime.FromBinary(checked((long)Math.Round(Conversion.Val(this.MaxDateD1)))).ToString("yyyy-MM-dd");
            string Prompt = Module1.decode((object)"VABpAG0AZQBsAGkAbQBpAHQAIABoAGEAcwAgAHAAYQBzAHMAZQBkACEADQAKAFQAaABlACAAcAByAG8AZwByAGEAbQAgAHcAaQBsAGwAIABjAGwAbwBzAGUAIABkAG8AdwBuACEA");
            if (Operators.CompareString(Nu, Right, false) <= 0)
                return;
            int num = (int)Interaction.MsgBox((object)Prompt, MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            MyProject.Forms.Form1.WillExit = true;
            MyProject.Forms.Form1.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Module1.Category.Name = this.OldCategory;
                Module1.Category.ID = this.OldCategoryID;
                Module1.Category.IndTADiscipline = this.OldIndTADiscipline;
                Module1.Category.IndTAClass = this.OldIndTAClass;
                Module1.SubCategory = this.OldSubcategory;
                Module1.WarmUpTime = this.OldWarmup;
                Module1.Segment = this.Oldsegment;
                Module1.RemWarmupTimeSeg1 = this.OldRemWarmupTimeSeg1;
                Module1.RemWarmupTimeSeg2 = this.OldRemWarmupTimeSeg2;
                this.TextBox1.Text = Module1.Category.Name;
                this.txtCategoryID.Text = Module1.Category.ID;
                this.txtIndTADisc.Text = Module1.Category.IndTADiscipline;
                this.txtIndTADisc.Text = Module1.Category.IndTAClass;
                this.ComboBox1.Text = Module1.SubCategory;
                Module1.Datum.Seg1 = this.OldDatumSeg1;
                Module1.Datum.Seg2 = this.OldDatumSeg2;
                Module1.Datum.Seg1Start = this.OldTimeSeg1;
                Module1.Datum.Seg2Start = this.OldTimeSeg2;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("Cancel_Button_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Dialog1_Load(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.Top = MyProject.Forms.Form1.Top;
                this.TopMost = true;
                this.Left = checked((int)Math.Round(unchecked((double)MyProject.Forms.Form1.Left + (double)MyProject.Forms.Form1.Width / 2.0 - (double)this.Width / 2.0)));
                this.DateTimePicker1.Format = DateTimePickerFormat.Short;
                this.OldCategory = Module1.Category.Name;
                this.OldCategoryID = Module1.Category.ID;
                this.OldSubcategory = Module1.SubCategory;
                this.OldRemWarmupTimeSeg1 = Module1.RemWarmupTimeSeg1;
                this.OldRemWarmupTimeSeg2 = Module1.RemWarmupTimeSeg2;
                this.ShowButton();
                this.TextBox1.Text = Module1.Category.Name;
                this.txtCategoryID.Text = Module1.Category.ID;
                this.txtIndTADisc.Text = Module1.Category.IndTADiscipline;
                this.txtIndTAClass.Text = Module1.Category.IndTAClass;
                this.txtWarmup.Text = Module1.WarmUpTime;
                this.OldWarmup = Module1.WarmUpTime;
                this.LoadComboBox1();
                if (Strings.Len(Module1.Datum.Seg1Start) < 2)
                    Module1.Datum.Seg1Start = Strings.Format((object)DateTime.Now, "HH:mm");
                if (Strings.Len(Module1.Datum.Seg2Start) < 2)
                    Module1.Datum.Seg2Start = Strings.Format((object)DateTime.Now, "HH:mm");
                this.OldDatumSeg1 = Module1.Datum.Seg1;
                this.OldDatumSeg2 = Module1.Datum.Seg2;
                this.OldTimeSeg1 = Module1.Datum.Seg1Start;
                this.OldTimeSeg2 = Module1.Datum.Seg2Start;
                this.Oldsegment = Module1.Segment;
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    this.DateTimePicker1.Text = Module1.FormShortDate(Module1.Datum.Seg1);
                    this.DateTimePicker2.Text = Module1.Datum.Seg1Start;
                }
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                {
                    this.DateTimePicker1.Text = Module1.FormShortDate(Module1.Datum.Seg2);
                    this.DateTimePicker2.Text = Module1.Datum.Seg2Start;
                }
                string prog = "";
                if (Strings.Len(Module1.Category.Name) > 1)
                {
                    string seg = Module1.GetSeg();
                    if (Operators.CompareString(seg, "0F", false) == 0)
                        prog = "Free";
                    else if (Operators.CompareString(seg, "S0", false) == 0)
                        prog = "Short";
                    else if (Operators.CompareString(seg, "SF", false) == 0)
                        prog = "Short & Free";
                    else if (Operators.CompareString(seg, "FF", false) == 0)
                        prog = "Free & Free";
                    else if (Operators.CompareString(seg, "SS", false) == 0)
                        prog = "Short & Short";
                    this.ShowBtn(prog);
                }
                else
                {
                    this.btnSeg1.Visible = false;
                    this.btnSeg2.Visible = false;
                }
                this.ShowCategory();
                goto label_28;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("Dialog1_Load - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_28:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void ShowButton()
        {
            string segment = Module1.Segment;
            if (Operators.CompareString(segment, "Seg1", false) == 0)
            {
                if (!Module1.RemWarmupTimeSeg1)
                {
                    this.btnRemoveWarmupTime.BackColor = SystemColors.ButtonFace;
                    this.btnRemoveWarmupTime.Text = "REMOVE WARMUP TIME GROUP 1";
                }
                else
                {
                    this.btnRemoveWarmupTime.BackColor = Color.Red;
                    this.btnRemoveWarmupTime.Text = "WARMUP TIME GROUP 1 REMOVED";
                }
            }
            else
            {
                if (Operators.CompareString(segment, "Seg2", false) != 0)
                    return;
                if (!Module1.RemWarmupTimeSeg2)
                {
                    this.btnRemoveWarmupTime.BackColor = SystemColors.ButtonFace;
                    this.btnRemoveWarmupTime.Text = "REMOVE WARMUP TIME GROUP 1";
                }
                else
                {
                    this.btnRemoveWarmupTime.BackColor = Color.Red;
                    this.btnRemoveWarmupTime.Text = "WARMUP TIME GROUP 1 REMOVED";
                }
            }
        }

        public void LoadComboBox1()
        {
            ComboBox comboBox1 = this.ComboBox1;
            comboBox1.Items.Clear();
            comboBox1.Text = Strings.Len(Module1.SubCategory) >= 1 ? Module1.SubCategory : "";
            comboBox1.Items.Add((object)"");
            comboBox1.Items.Add((object)"Group 1");
            comboBox1.Items.Add((object)"Group 2");
            comboBox1.Items.Add((object)"Group 3");
            comboBox1.Items.Add((object)"Group 4");
            comboBox1.Items.Add((object)"Group 5");
        }

        private void ComboBox1_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        public void ShowCategory()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                dataGridView1.RowCount = Module1.NoOfCategory;
                dataGridView1.ColumnHeadersVisible = true;
                dataGridView1.ReadOnly = true;
                dataGridView1.ColumnCount = 2;
                dataGridView1.Columns[0].HeaderText = "Category";
                dataGridView1.Columns[1].HeaderText = "Program";
                dataGridView1.RowHeadersVisible = false;
                int index = 0;
                while (Strings.Len(Module1.OpenDB[index].Category) > 2)
                {
                    string str = "";
                    dataGridView1.Rows[index].Cells[0].Value = (object)Module1.OpenDB[index].Category;
                    if (Operators.CompareString(Module1.OpenDB[index].Segment_1, "S", false) == 0 & Operators.CompareString(Module1.OpenDB[index].Segment_2, "F", false) == 0)
                        str = "Short & Free";
                    if (Operators.CompareString(Module1.OpenDB[index].Segment_1, "F", false) == 0 & Operators.CompareString(Module1.OpenDB[index].Segment_2, "F", false) == 0)
                        str = "Free & Free";
                    if (Operators.CompareString(Module1.OpenDB[index].Segment_1, "S", false) == 0 & Operators.CompareString(Module1.OpenDB[index].Segment_2, "S", false) == 0)
                        str = "Short & Short";
                    if (Operators.CompareString(Module1.OpenDB[index].Segment_1, "S", false) == 0 & Operators.CompareString(Module1.OpenDB[index].Segment_2, "0", false) == 0)
                        str = "Short";
                    if (Operators.CompareString(Module1.OpenDB[index].Segment_1, "0", false) == 0 & Operators.CompareString(Module1.OpenDB[index].Segment_2, "F", false) == 0)
                        str = "Free";
                    dataGridView1.Rows[index].Cells[1].Value = (object)str;
                    if ((double)index == Conversion.Int((double)index / 2.0) * 2.0)
                        dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightGray;
                    checked { ++index; }
                }
                goto label_21;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ShowCategory - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_21:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = this.DataGridView1.CurrentCellAddress.Y;
            this.TextBox1.Text = Conversions.ToString(this.DataGridView1.Rows[y].Cells[0].Value);
            Module1.Category.Name = this.TextBox1.Text;
            this.txtCategoryID.Text = "";
            Module1.Category.ID = "";
            this.txtIndTADisc.Text = "";
            Module1.Category.IndTADiscipline = "";
            this.txtIndTAClass.Text = "";
            Module1.Category.IndTAClass = "";
            Module1.CalcPCindex();
            this.ShowBtn(Conversions.ToString(this.DataGridView1.Rows[y].Cells[1].Value));
            Module1.Category.Name = this.TextBox1.Text;
            this.txtWarmup.Text = Module1.OpenDB[Module1.PcIndex].Warmup;
        }

        private void ShowBtn(string prog)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                string Left = prog;
                if (Operators.CompareString(Left, "Short", false) == 0)
                {
                    this.btnSeg1.Text = "SHORT";
                    this.btnSeg1.Visible = true;
                    this.btnSeg2.Visible = false;
                    this.btnSeg1.BackColor = Color.Green;
                    Module1.Segment = "Seg1";
                    goto label_28;
                }
                else if (Operators.CompareString(Left, "Free", false) == 0)
                {
                    this.btnSeg1.Text = "FREE";
                    this.btnSeg1.Visible = false;
                    this.btnSeg2.Visible = true;
                    this.btnSeg2.BackColor = Color.Green;
                    Module1.Segment = "Seg2";
                    goto label_28;
                }
                else if (Operators.CompareString(Left, "Short & Free", false) == 0)
                {
                    this.btnSeg1.Text = "SHORT";
                    this.btnSeg2.Text = "FREE";
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        this.btnSeg1.Visible = true;
                        this.btnSeg2.Visible = true;
                        this.btnSeg1.BackColor = Color.Green;
                        this.btnSeg2.BackColor = SystemColors.Control;
                        goto label_28;
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        this.btnSeg1.Visible = true;
                        this.btnSeg2.Visible = true;
                        this.btnSeg1.BackColor = SystemColors.Control;
                        this.btnSeg2.BackColor = Color.Green;
                        goto label_28;
                    }
                    else
                    {
                        Module1.Segment = "Seg1";
                        this.btnSeg1.Visible = true;
                        this.btnSeg2.Visible = true;
                        this.btnSeg1.BackColor = Color.Green;
                        this.btnSeg2.BackColor = SystemColors.Control;
                        goto label_28;
                    }
                }
                else if (Operators.CompareString(Left, "Free & Free", false) == 0)
                {
                    this.btnSeg1.Text = "FREE";
                    this.btnSeg2.Text = "FREE";
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        this.btnSeg1.Visible = true;
                        this.btnSeg2.Visible = true;
                        this.btnSeg1.BackColor = Color.Green;
                        this.btnSeg2.BackColor = SystemColors.Control;
                        goto label_28;
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        this.btnSeg1.Visible = true;
                        this.btnSeg2.Visible = true;
                        this.btnSeg1.BackColor = SystemColors.Control;
                        this.btnSeg2.BackColor = Color.Green;
                        goto label_28;
                    }
                    else
                    {
                        Module1.Segment = "Seg1";
                        this.btnSeg1.Visible = true;
                        this.btnSeg2.Visible = true;
                        this.btnSeg1.BackColor = Color.Green;
                        this.btnSeg2.BackColor = SystemColors.Control;
                        goto label_28;
                    }
                }
                else if (Operators.CompareString(Left, "Short & Short", false) == 0)
                {
                    this.btnSeg1.Text = "SHORT";
                    this.btnSeg2.Text = "SHORT";
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        this.btnSeg1.Visible = true;
                        this.btnSeg2.Visible = true;
                        this.btnSeg1.BackColor = Color.Green;
                        this.btnSeg2.BackColor = SystemColors.Control;
                        goto label_28;
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        this.btnSeg1.Visible = true;
                        this.btnSeg2.Visible = true;
                        this.btnSeg1.BackColor = SystemColors.Control;
                        this.btnSeg2.BackColor = Color.Green;
                        goto label_28;
                    }
                    else
                    {
                        Module1.Segment = "Seg1";
                        this.btnSeg1.Visible = true;
                        this.btnSeg2.Visible = true;
                        this.btnSeg1.BackColor = Color.Green;
                        this.btnSeg2.BackColor = SystemColors.Control;
                        goto label_28;
                    }
                }
                else
                    goto label_28;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ShowBtn - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_28:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void btnSeg1_Click_1(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                string seg = Module1.GetSeg();
                if (Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "SS", false) == 0)
                {
                    Module1.Segment = "Seg1";
                    this.btnSeg1.Text = "SHORT";
                    this.btnSeg1.BackColor = Color.Green;
                    this.btnSeg2.BackColor = SystemColors.Control;
                    this.DateTimePicker1.Text = Module1.FormShortDate(Module1.Datum.Seg1);
                    this.DateTimePicker2.Text = Module1.Datum.Seg1Start;
                }
                else if (Operators.CompareString(seg, "FF", false) == 0)
                {
                    Module1.Segment = "Seg1";
                    this.btnSeg1.Text = "FREE";
                    this.btnSeg1.BackColor = Color.Green;
                    this.btnSeg2.BackColor = SystemColors.Control;
                    this.DateTimePicker1.Text = Module1.FormShortDate(Module1.Datum.Seg1);
                    this.DateTimePicker2.Text = Module1.Datum.Seg1Start;
                }
                this.ShowButton();
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void btnSeg2_Click_1(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                string seg = Module1.GetSeg();
                num3 = 5;
                if (Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "FF", false) == 0)
                {
                    num3 = 6;
                    Module1.Segment = "Seg2";
                    num3 = 7;
                    this.btnSeg2.Text = "FREE";
                    num3 = 8;
                    this.btnSeg1.BackColor = SystemColors.Control;
                    num3 = 9;
                    this.btnSeg2.BackColor = Color.Green;
                    num3 = 10;
                    this.DateTimePicker1.Text = Module1.FormShortDate(Module1.Datum.Seg2);
                    num3 = 11;
                    this.DateTimePicker2.Text = Module1.Datum.Seg2Start;
                }
                else
                {
                    num3 = 13;
                    if (Operators.CompareString(seg, "SS", false) == 0)
                    {
                        num3 = 14;
                        Module1.Segment = "Seg2";
                        num3 = 15;
                        this.btnSeg2.Text = "SHORT";
                        num3 = 16;
                        this.btnSeg1.BackColor = SystemColors.Control;
                        num3 = 17;
                        this.btnSeg2.BackColor = Color.Green;
                        num3 = 18;
                        this.DateTimePicker1.Text = Module1.FormShortDate(Module1.Datum.Seg2);
                        num3 = 19;
                        this.DateTimePicker2.Text = Module1.Datum.Seg2Start;
                    }
                }
                num3 = 21;
                this.ShowButton();
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string segment = Module1.Segment;
            if (Operators.CompareString(segment, "Seg1", false) == 0)
            {
                Module1.Datum.Seg1 = this.DateTimePicker1.Value;
            }
            else
            {
                if (Operators.CompareString(segment, "Seg2", false) != 0)
                    return;
                Module1.Datum.Seg2 = this.DateTimePicker1.Value;
            }
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string segment = Module1.Segment;
            if (Operators.CompareString(segment, "Seg1", false) == 0)
            {
                Module1.Datum.Seg1Start = this.DateTimePicker2.Text;
            }
            else
            {
                if (Operators.CompareString(segment, "Seg2", false) != 0)
                    return;
                Module1.Datum.Seg2Start = this.DateTimePicker2.Text;
            }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;
            switch (keyChar)
            {
                case '!':
                case '"':
                case '&':
                case '\'':
                case ':':
                case ';':
                case '<':
                case '>':
                    e.Handled = true;
                    break;
                default:
                    if ((int)keyChar != (int)Strings.Chr(229) && (int)keyChar != (int)Strings.Chr(197) && (int)keyChar != (int)Strings.Chr(228) && (int)keyChar != (int)Strings.Chr(196) && (int)keyChar != (int)Strings.Chr(246) && (int)keyChar != (int)Strings.Chr(214) && keyChar != '[' && keyChar != ']' && keyChar != '/' && keyChar != '\\' && keyChar != '~' && keyChar != '?' && keyChar != '*' && keyChar != '+' && keyChar != '.' && keyChar != ',')
                        break;
                    goto case '!';
            }
        }

        private void CategoryID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                return;
            e.KeyChar = char.MinValue;
        }

        private void txtIndTADisc_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;
            switch (keyChar)
            {
                case '!':
                case '"':
                case '&':
                case '\'':
                case ':':
                case ';':
                case '<':
                case '>':
                    e.Handled = true;
                    break;
                default:
                    if ((int)keyChar != (int)Strings.Chr(229) && (int)keyChar != (int)Strings.Chr(197) && (int)keyChar != (int)Strings.Chr(228) && (int)keyChar != (int)Strings.Chr(196) && (int)keyChar != (int)Strings.Chr(246) && (int)keyChar != (int)Strings.Chr(214) && keyChar != '[' && keyChar != ']' && keyChar != '/' && keyChar != '\\' && keyChar != '~' && keyChar != '?' && keyChar != '*' && keyChar != '+' && keyChar != '.' && keyChar != ',')
                        break;
                    goto case '!';
            }
        }

        private void txtIndTAClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = e.KeyChar;
            switch (keyChar)
            {
                case '!':
                case '"':
                case '&':
                case '\'':
                case ':':
                case ';':
                case '<':
                case '>':
                    e.Handled = true;
                    break;
                default:
                    if ((int)keyChar != (int)Strings.Chr(229) && (int)keyChar != (int)Strings.Chr(197) && (int)keyChar != (int)Strings.Chr(228) && (int)keyChar != (int)Strings.Chr(196) && (int)keyChar != (int)Strings.Chr(246) && (int)keyChar != (int)Strings.Chr(214) && keyChar != '[' && keyChar != ']' && keyChar != '/' && keyChar != '\\' && keyChar != '~' && keyChar != '?' && keyChar != '*' && keyChar != '+' && keyChar != '.' && keyChar != ',')
                        break;
                    goto case '!';
            }
        }

        private void txtWarmup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ':' || e.KeyChar == '\b' || e.KeyChar == '\u007F')
                return;
            e.Handled = true;
        }

        private void txtWarmup_Leave(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(this.txtWarmup.Text, "HH:mm:ss", (IFormatProvider)null, DateTimeStyles.NoCurrentDateDefault, out DateTime _))
                return;
            int num = (int)MessageBox.Show("Enter a valid time e.g. 00:02:30");
            this.txtWarmup.Text = this.OldWarmup;
        }

        private void btnRemoveWarmupTime_Click(object sender, EventArgs e)
        {
            string segment = Module1.Segment;
            if (Operators.CompareString(segment, "Seg1", false) == 0)
                Module1.RemWarmupTimeSeg1 = !Module1.RemWarmupTimeSeg1;
            else if (Operators.CompareString(segment, "Seg2", false) == 0)
            {
                Module1.RemWarmupTimeSeg2 = !Module1.RemWarmupTimeSeg2;
            }
            else
            {
                int num = (int)Interaction.MsgBox((object)"Select a Category!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                return;
            }
            this.ShowButton();
        }
    }
}

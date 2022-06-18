// Decompiled with JetBrains decompiler
// Type: ClubCompFS.Form4
// Assembly: ClubCompFS_10p0p6, Version=1.0.0.6, Culture=neutral, PublicKeyToken=null
// MVID: 18AFA868-014F-449A-91A2-9536DA06DEFC
// Assembly location: E:\zz Personal_Doc\Personal\Cinzia\ClubCompFS_Version2_Oct2020_NEW3\ClubCompFS_NEW2.exe

using ClubCompFS.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ClubCompFS
{
    [DesignerGenerated]
    public class Form4 : Form
    {
        private IContainer components;
        [AccessedThroughProperty("DataGridView1")]
        private DataGridView _DataGridView1;
        [AccessedThroughProperty("Mode")]
        private TextBox _Mode;
        [AccessedThroughProperty("Timer1")]
        private Timer _Timer1;
        [AccessedThroughProperty("MenuStrip2")]
        private MenuStrip _MenuStrip2;
        [AccessedThroughProperty("txtIndex")]
        private TextBox _txtIndex;
        [AccessedThroughProperty("EXITToolStripMenuItem")]
        private ToolStripMenuItem _EXITToolStripMenuItem;
        [AccessedThroughProperty("PrintPreviewDialog1")]
        private PrintPreviewDialog _PrintPreviewDialog1;
        [AccessedThroughProperty("DataGridView2")]
        private DataGridView _DataGridView2;
        [AccessedThroughProperty("PrintDocument2")]
        private PrintDocument _PrintDocument2;
        [AccessedThroughProperty("PrintPreviewDialog2")]
        private PrintPreviewDialog _PrintPreviewDialog2;
        [AccessedThroughProperty("Column1")]
        private DataGridViewTextBoxColumn _Column1;
        [AccessedThroughProperty("Column2")]
        private DataGridViewTextBoxColumn _Column2;
        [AccessedThroughProperty("Column3")]
        private DataGridViewTextBoxColumn _Column3;
        [AccessedThroughProperty("Column4")]
        private DataGridViewTextBoxColumn _Column4;
        [AccessedThroughProperty("Column5")]
        private DataGridViewTextBoxColumn _Column5;
        [AccessedThroughProperty("Column6")]
        private DataGridViewTextBoxColumn _Column6;
        [AccessedThroughProperty("Column7")]
        private DataGridViewTextBoxColumn _Column7;
        [AccessedThroughProperty("Column8")]
        private DataGridViewTextBoxColumn _Column8;
        [AccessedThroughProperty("Column9")]
        private DataGridViewTextBoxColumn _Column9;
        [AccessedThroughProperty("Column10")]
        private DataGridViewTextBoxColumn _Column10;
        [AccessedThroughProperty("Column11")]
        private DataGridViewTextBoxColumn _Column11;
        [AccessedThroughProperty("Column12")]
        private DataGridViewTextBoxColumn _Column12;
        [AccessedThroughProperty("Column13")]
        private DataGridViewTextBoxColumn _Column13;
        [AccessedThroughProperty("Column14")]
        private DataGridViewTextBoxColumn _Column14;
        [AccessedThroughProperty("txtPrint")]
        private TextBox _txtPrint;
        [AccessedThroughProperty("Column15")]
        private DataGridViewTextBoxColumn _Column15;
        [AccessedThroughProperty("Column16")]
        private DataGridViewTextBoxColumn _Column16;
        [AccessedThroughProperty("INPUTELEMENTToolStripMenuItem")]
        private ToolStripMenuItem _INPUTELEMENTToolStripMenuItem;
        [AccessedThroughProperty("CREATERESULTSToolStripMenuItem")]
        private ToolStripMenuItem _CREATERESULTSToolStripMenuItem;
        [AccessedThroughProperty("EDITJUDGEDATAToolStripMenuItem")]
        private ToolStripMenuItem _EDITJUDGEDATAToolStripMenuItem;
        [AccessedThroughProperty("txtNoOfCopies")]
        private TextBox _txtNoOfCopies;
        [AccessedThroughProperty("PrintDialog1")]
        private PrintDialog _PrintDialog1;
        [AccessedThroughProperty("BackgroundWorker1")]
        private BackgroundWorker _BackgroundWorker1;
        private Timer t;
        private int[] ErrCount13;
        private int[] ErrCount5;
        private string[,] JDarr1;
        private string[,] JDded;
        public bool WillExitForm4;
        private int F4arrRows;
        private int mRow;
        private bool newpage;
        private string CreateMenu;
        private bool Completed1;
        public bool completed2;

        public Form4()
        {
            this.FormClosing += new FormClosingEventHandler(this.Form4_FormClosing);
            this.KeyDown += new KeyEventHandler(this.Form4_KeyDown);
            this.Load += new EventHandler(this.Form4_Load);
            this.t = new Timer();
            this.ErrCount13 = new int[8];
            this.ErrCount5 = new int[8];
            this.JDarr1 = new string[51, 15];
            this.JDded = new string[2, 3];
            this.WillExitForm4 = false;
            this.mRow = 1;
            this.newpage = true;
            this.CreateMenu = "Gray";
            this.Completed1 = true;
            this.completed2 = true;
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
            this.components = (IContainer)new Container();
            DataGridViewCellStyle gridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form4));
            DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
            this.DataGridView1 = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.Column8 = new DataGridViewTextBoxColumn();
            this.Column9 = new DataGridViewTextBoxColumn();
            this.Column10 = new DataGridViewTextBoxColumn();
            this.Column11 = new DataGridViewTextBoxColumn();
            this.Column12 = new DataGridViewTextBoxColumn();
            this.Column13 = new DataGridViewTextBoxColumn();
            this.Column14 = new DataGridViewTextBoxColumn();
            this.Mode = new TextBox();
            this.Timer1 = new Timer(this.components);
            this.MenuStrip2 = new MenuStrip();
            this.EXITToolStripMenuItem = new ToolStripMenuItem();
            this.INPUTELEMENTToolStripMenuItem = new ToolStripMenuItem();
            this.CREATERESULTSToolStripMenuItem = new ToolStripMenuItem();
            this.EDITJUDGEDATAToolStripMenuItem = new ToolStripMenuItem();
            this.txtIndex = new TextBox();
            this.PrintPreviewDialog1 = new PrintPreviewDialog();
            this.DataGridView2 = new DataGridView();
            this.Column15 = new DataGridViewTextBoxColumn();
            this.Column16 = new DataGridViewTextBoxColumn();
            this.PrintDocument2 = new PrintDocument();
            this.PrintPreviewDialog2 = new PrintPreviewDialog();
            this.txtPrint = new TextBox();
            this.txtNoOfCopies = new TextBox();
            this.PrintDialog1 = new PrintDialog();
            this.BackgroundWorker1 = new BackgroundWorker();
            ((ISupportInitialize)this.DataGridView1).BeginInit();
            this.MenuStrip2.SuspendLayout();
            ((ISupportInitialize)this.DataGridView2).BeginInit();
            this.SuspendLayout();
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange((DataGridViewColumn)this.Column1, (DataGridViewColumn)this.Column2, (DataGridViewColumn)this.Column3, (DataGridViewColumn)this.Column4, (DataGridViewColumn)this.Column5, (DataGridViewColumn)this.Column6, (DataGridViewColumn)this.Column7, (DataGridViewColumn)this.Column8, (DataGridViewColumn)this.Column9, (DataGridViewColumn)this.Column10, (DataGridViewColumn)this.Column11, (DataGridViewColumn)this.Column12, (DataGridViewColumn)this.Column13, (DataGridViewColumn)this.Column14);
            this.DataGridView1.Location = new Point(0, 27);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ScrollBars = ScrollBars.None;
            DataGridView dataGridView1 = this.DataGridView1;
            Size size1 = new Size(968, 583);
            Size size2 = size1;
            dataGridView1.Size = size2;
            this.DataGridView1.TabIndex = 1;
            gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Column1.DefaultCellStyle = gridViewCellStyle1;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Column2.DefaultCellStyle = gridViewCellStyle2;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column12.HeaderText = "Column12";
            this.Column12.Name = "Column12";
            this.Column13.HeaderText = "Column13";
            this.Column13.Name = "Column13";
            gridViewCellStyle3.Format = "N2";
            gridViewCellStyle3.NullValue = (object)null;
            this.Column14.DefaultCellStyle = gridViewCellStyle3;
            this.Column14.HeaderText = "Column14";
            this.Column14.Name = "Column14";
            this.Mode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.Mode.BackColor = Color.FromArgb(128, (int)byte.MaxValue, (int)byte.MaxValue);
            this.Mode.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Mode.Location = new Point(852, 2);
            this.Mode.Name = "Mode";
            TextBox mode = this.Mode;
            size1 = new Size(116, 20);
            Size size3 = size1;
            mode.Size = size3;
            this.Mode.TabIndex = 66;
            this.Mode.TextAlign = HorizontalAlignment.Center;
            this.Timer1.Interval = 1000;
            this.MenuStrip2.BackColor = SystemColors.Control;
            this.MenuStrip2.Items.AddRange(new ToolStripItem[4]
            {
        (ToolStripItem) this.EXITToolStripMenuItem,
        (ToolStripItem) this.INPUTELEMENTToolStripMenuItem,
        (ToolStripItem) this.CREATERESULTSToolStripMenuItem,
        (ToolStripItem) this.EDITJUDGEDATAToolStripMenuItem
            });
            this.MenuStrip2.Location = new Point(0, 0);
            this.MenuStrip2.Name = "MenuStrip2";
            MenuStrip menuStrip2 = this.MenuStrip2;
            size1 = new Size(968, 24);
            Size size4 = size1;
            menuStrip2.Size = size4;
            this.MenuStrip2.TabIndex = 69;
            this.MenuStrip2.Text = "MenuStrip2";
            this.EXITToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem1 = this.EXITToolStripMenuItem;
            size1 = new Size(44, 20);
            Size size5 = size1;
            toolStripMenuItem1.Size = size5;
            this.EXITToolStripMenuItem.Text = "EXIT";
            this.INPUTELEMENTToolStripMenuItem.BackColor = Color.FromArgb(128, (int)byte.MaxValue, 128);
            this.INPUTELEMENTToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.INPUTELEMENTToolStripMenuItem.Name = "INPUTELEMENTToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem2 = this.INPUTELEMENTToolStripMenuItem;
            size1 = new Size(104, 20);
            Size size6 = size1;
            toolStripMenuItem2.Size = size6;
            this.INPUTELEMENTToolStripMenuItem.Text = "INPUT ELEMENT";
            this.CREATERESULTSToolStripMenuItem.BackColor = SystemColors.Control;
            this.CREATERESULTSToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.CREATERESULTSToolStripMenuItem.Name = "CREATERESULTSToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem3 = this.CREATERESULTSToolStripMenuItem;
            size1 = new Size(113, 20);
            Size size7 = size1;
            toolStripMenuItem3.Size = size7;
            this.CREATERESULTSToolStripMenuItem.Text = "CREATE RESULTS";
            this.EDITJUDGEDATAToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EDITJUDGEDATAToolStripMenuItem.Name = "EDITJUDGEDATAToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem4 = this.EDITJUDGEDATAToolStripMenuItem;
            size1 = new Size(118, 20);
            Size size8 = size1;
            toolStripMenuItem4.Size = size8;
            this.EDITJUDGEDATAToolStripMenuItem.Text = "EDIT JUDGE DATA";
            this.txtIndex.Location = new Point(701, 2);
            this.txtIndex.Name = "txtIndex";
            TextBox txtIndex = this.txtIndex;
            size1 = new Size(61, 20);
            Size size9 = size1;
            txtIndex.Size = size9;
            this.txtIndex.TabIndex = 70;
            this.txtIndex.Visible = false;
            PrintPreviewDialog printPreviewDialog1_1 = this.PrintPreviewDialog1;
            size1 = new Size(0, 0);
            Size size10 = size1;
            printPreviewDialog1_1.AutoScrollMargin = size10;
            PrintPreviewDialog printPreviewDialog1_2 = this.PrintPreviewDialog1;
            size1 = new Size(0, 0);
            Size size11 = size1;
            printPreviewDialog1_2.AutoScrollMinSize = size11;
            PrintPreviewDialog printPreviewDialog1_3 = this.PrintPreviewDialog1;
            size1 = new Size(400, 300);
            Size size12 = size1;
            printPreviewDialog1_3.ClientSize = size12;
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = (Icon)componentResourceManager.GetObject("PrintPreviewDialog1.Icon");
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            this.DataGridView2.AllowUserToResizeColumns = false;
            this.DataGridView2.AllowUserToResizeRows = false;
            this.DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Columns.AddRange((DataGridViewColumn)this.Column15, (DataGridViewColumn)this.Column16);
            this.DataGridView2.Location = new Point(0, 453);
            this.DataGridView2.Name = "DataGridView2";
            DataGridView dataGridView2 = this.DataGridView2;
            size1 = new Size(964, 33);
            Size size13 = size1;
            dataGridView2.Size = size13;
            this.DataGridView2.TabIndex = 73;
            gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column15.DefaultCellStyle = gridViewCellStyle4;
            this.Column15.HeaderText = "Column15";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Resizable = DataGridViewTriState.False;
            gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column16.DefaultCellStyle = gridViewCellStyle5;
            this.Column16.HeaderText = "Column16";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            PrintPreviewDialog printPreviewDialog2_1 = this.PrintPreviewDialog2;
            size1 = new Size(0, 0);
            Size size14 = size1;
            printPreviewDialog2_1.AutoScrollMargin = size14;
            PrintPreviewDialog printPreviewDialog2_2 = this.PrintPreviewDialog2;
            size1 = new Size(0, 0);
            Size size15 = size1;
            printPreviewDialog2_2.AutoScrollMinSize = size15;
            PrintPreviewDialog printPreviewDialog2_3 = this.PrintPreviewDialog2;
            size1 = new Size(400, 300);
            Size size16 = size1;
            printPreviewDialog2_3.ClientSize = size16;
            this.PrintPreviewDialog2.Enabled = true;
            this.PrintPreviewDialog2.Icon = (Icon)componentResourceManager.GetObject("PrintPreviewDialog2.Icon");
            this.PrintPreviewDialog2.Name = "PrintPreviewDialog2";
            this.PrintPreviewDialog2.Visible = false;
            this.txtPrint.Location = new Point(768, 2);
            this.txtPrint.Name = "txtPrint";
            TextBox txtPrint = this.txtPrint;
            size1 = new Size(19, 20);
            Size size17 = size1;
            txtPrint.Size = size17;
            this.txtPrint.TabIndex = 74;
            this.txtPrint.Text = "0";
            this.txtPrint.Visible = false;
            this.txtNoOfCopies.Location = new Point(634, 2);
            this.txtNoOfCopies.Name = "txtNoOfCopies";
            TextBox txtNoOfCopies = this.txtNoOfCopies;
            size1 = new Size(61, 20);
            Size size18 = size1;
            txtNoOfCopies.Size = size18;
            this.txtNoOfCopies.TabIndex = 75;
            this.txtNoOfCopies.Text = "0";
            this.txtNoOfCopies.Visible = false;
            this.PrintDialog1.UseEXDialog = true;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.Silver;
            size1 = new Size(968, 609);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.txtNoOfCopies);
            this.Controls.Add((Control)this.txtPrint);
            this.Controls.Add((Control)this.DataGridView2);
            this.Controls.Add((Control)this.txtIndex);
            this.Controls.Add((Control)this.Mode);
            this.Controls.Add((Control)this.DataGridView1);
            this.Controls.Add((Control)this.MenuStrip2);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = nameof(Form4);
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "JUDGES DETAILS";
            this.TopMost = true;
            ((ISupportInitialize)this.DataGridView1).EndInit();
            this.MenuStrip2.ResumeLayout(false);
            this.MenuStrip2.PerformLayout();
            ((ISupportInitialize)this.DataGridView2).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual DataGridView DataGridView1
        {
            get => this._DataGridView1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                DataGridViewCellMouseEventHandler mouseEventHandler = new DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDown);
                if (this._DataGridView1 != null)
                    this._DataGridView1.CellMouseDown -= mouseEventHandler;
                this._DataGridView1 = value;
                if (this._DataGridView1 == null)
                    return;
                this._DataGridView1.CellMouseDown += mouseEventHandler;
            }
        }

        internal virtual TextBox Mode
        {
            get => this._Mode;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Mode = value;
        }

        internal virtual Timer Timer1
        {
            get => this._Timer1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
                if (this._Timer1 != null)
                    this._Timer1.Tick -= eventHandler;
                this._Timer1 = value;
                if (this._Timer1 == null)
                    return;
                this._Timer1.Tick += eventHandler;
            }
        }

        internal virtual MenuStrip MenuStrip2
        {
            get => this._MenuStrip2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._MenuStrip2 = value;
        }

        internal virtual TextBox txtIndex
        {
            get => this._txtIndex;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtIndex = value;
        }

        internal virtual ToolStripMenuItem EXITToolStripMenuItem
        {
            get => this._EXITToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.EXITToolStripMenuItem_Click);
                if (this._EXITToolStripMenuItem != null)
                    this._EXITToolStripMenuItem.Click -= eventHandler;
                this._EXITToolStripMenuItem = value;
                if (this._EXITToolStripMenuItem == null)
                    return;
                this._EXITToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual PrintPreviewDialog PrintPreviewDialog1
        {
            get => this._PrintPreviewDialog1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PrintPreviewDialog1 = value;
        }

        internal virtual DataGridView DataGridView2
        {
            get => this._DataGridView2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._DataGridView2 = value;
        }

        internal virtual PrintDocument PrintDocument2
        {
            get => this._PrintDocument2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                PrintPageEventHandler pageEventHandler = new PrintPageEventHandler(this.PrintDocument2_PrintPage);
                if (this._PrintDocument2 != null)
                    this._PrintDocument2.PrintPage -= pageEventHandler;
                this._PrintDocument2 = value;
                if (this._PrintDocument2 == null)
                    return;
                this._PrintDocument2.PrintPage += pageEventHandler;
            }
        }

        internal virtual PrintPreviewDialog PrintPreviewDialog2
        {
            get => this._PrintPreviewDialog2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PrintPreviewDialog2 = value;
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

        internal virtual DataGridViewTextBoxColumn Column3
        {
            get => this._Column3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column3 = value;
        }

        internal virtual DataGridViewTextBoxColumn Column4
        {
            get => this._Column4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column4 = value;
        }

        internal virtual DataGridViewTextBoxColumn Column5
        {
            get => this._Column5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column5 = value;
        }

        internal virtual DataGridViewTextBoxColumn Column6
        {
            get => this._Column6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column6 = value;
        }

        internal virtual DataGridViewTextBoxColumn Column7
        {
            get => this._Column7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column7 = value;
        }

        internal virtual DataGridViewTextBoxColumn Column8
        {
            get => this._Column8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column8 = value;
        }

        internal virtual DataGridViewTextBoxColumn Column9
        {
            get => this._Column9;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column9 = value;
        }

        internal virtual DataGridViewTextBoxColumn Column10
        {
            get => this._Column10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column10 = value;
        }

        internal virtual DataGridViewTextBoxColumn Column11
        {
            get => this._Column11;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column11 = value;
        }

        internal virtual DataGridViewTextBoxColumn Column12
        {
            get => this._Column12;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column12 = value;
        }

        internal virtual DataGridViewTextBoxColumn Column13
        {
            get => this._Column13;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column13 = value;
        }

        internal virtual DataGridViewTextBoxColumn Column14
        {
            get => this._Column14;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column14 = value;
        }

        internal virtual TextBox txtPrint
        {
            get => this._txtPrint;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtPrint = value;
        }

        internal virtual DataGridViewTextBoxColumn Column15
        {
            get => this._Column15;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column15 = value;
        }

        internal virtual DataGridViewTextBoxColumn Column16
        {
            get => this._Column16;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column16 = value;
        }

        internal virtual ToolStripMenuItem INPUTELEMENTToolStripMenuItem
        {
            get => this._INPUTELEMENTToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.INPUTELEMENTToolStripMenuItem_Click);
                if (this._INPUTELEMENTToolStripMenuItem != null)
                    this._INPUTELEMENTToolStripMenuItem.Click -= eventHandler;
                this._INPUTELEMENTToolStripMenuItem = value;
                if (this._INPUTELEMENTToolStripMenuItem == null)
                    return;
                this._INPUTELEMENTToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem CREATERESULTSToolStripMenuItem
        {
            get => this._CREATERESULTSToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.CREATERESULTSToolStripMenuItem_Click);
                if (this._CREATERESULTSToolStripMenuItem != null)
                    this._CREATERESULTSToolStripMenuItem.Click -= eventHandler;
                this._CREATERESULTSToolStripMenuItem = value;
                if (this._CREATERESULTSToolStripMenuItem == null)
                    return;
                this._CREATERESULTSToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem EDITJUDGEDATAToolStripMenuItem
        {
            get => this._EDITJUDGEDATAToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.EDITJUDGEDATAToolStripMenuItem_Click);
                if (this._EDITJUDGEDATAToolStripMenuItem != null)
                    this._EDITJUDGEDATAToolStripMenuItem.Click -= eventHandler;
                this._EDITJUDGEDATAToolStripMenuItem = value;
                if (this._EDITJUDGEDATAToolStripMenuItem == null)
                    return;
                this._EDITJUDGEDATAToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual TextBox txtNoOfCopies
        {
            get => this._txtNoOfCopies;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtNoOfCopies = value;
        }

        internal virtual PrintDialog PrintDialog1
        {
            get => this._PrintDialog1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PrintDialog1 = value;
        }

        internal virtual BackgroundWorker BackgroundWorker1
        {
            get => this._BackgroundWorker1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._BackgroundWorker1 = value;
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Module1.ScanJudges > 0 & !this.WillExitForm4 && Interaction.MsgBox((object)"Do you really want to disable the ongoing Judges' Input?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                MyProject.Forms.InputJudgesDataDialog.Close();
                MyProject.Forms.DeductionsDialog.Close();
                Module1.ScanJudges = 0;
                this.Timer1.Enabled = false;
                MyProject.Forms.Form2.TopMost = true;
            }
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (Module1.WorkMode != 2 || (-(e.KeyValue == 112 ? 1 : 0) | 113 | 114 | 115 | 116 | 117 | 118 | 119 | 120 | 121 | 122 | 123) == 0)
                return;
            this.FuncKeysModule4((System.Windows.Forms.Keys)e.KeyValue);
            e.Handled = true;
        }

        public void FuncKeysModule4(System.Windows.Forms.Keys value)
        {
            if (value != System.Windows.Forms.Keys.F12)
                return;
            MyProject.Forms.Form1.SendMessage(Module1.LastOutTxt);
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Module1.IPar.EE = (string[])null;
            Module1.IPar.EE = new string[16];
            Module1.IPar.PC = (string[])null;
            Module1.IPar.PC = new string[6];
            Module1.JCStatus = (int[])null;
            Module1.JCStatus = new int[8];
            Module1.UpdStr = new string[21];
            this.Left = checked((int)Math.Round(unchecked((double)checked(Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2.0)));
            this.Top = 0;
            this.CREATERESULTSToolStripMenuItem.BackColor = SystemColors.Control;
            this.CreateMenu = "Gray";
            this.WillExitForm4 = false;
            switch (Module1.WorkMode)
            {
                case 1:
                    this.INPUTELEMENTToolStripMenuItem.Visible = false;
                    this.CREATERESULTSToolStripMenuItem.Visible = false;
                    this.EDITJUDGEDATAToolStripMenuItem.Visible = false;
                    this.Timer1.Enabled = false;
                    break;
                case 2:
                    switch (Module1.ScanJudges)
                    {
                        case 0:
                            this.INPUTELEMENTToolStripMenuItem.Visible = false;
                            this.CREATERESULTSToolStripMenuItem.Visible = false;
                            this.EDITJUDGEDATAToolStripMenuItem.Visible = false;
                            this.Timer1.Enabled = false;
                            break;
                        case 1:
                            this.INPUTELEMENTToolStripMenuItem.Visible = true;
                            this.CREATERESULTSToolStripMenuItem.Visible = true;
                            this.EDITJUDGEDATAToolStripMenuItem.Visible = false;
                            this.Timer1.Enabled = true;
                            break;
                    }
                    break;
                case 3:
                    this.INPUTELEMENTToolStripMenuItem.Visible = true;
                    this.CREATERESULTSToolStripMenuItem.Visible = true;
                    this.EDITJUDGEDATAToolStripMenuItem.Visible = true;
                    this.Timer1.Enabled = false;
                    break;
            }
            this.Text = "JUDGES DETAILS: " + Module1.GetSegTxt(Module1.Segment);
            this.Mode.Text = Module1.GetWorkMode();
        }

        public void ImportTCP_Files()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int index1 = 1;
                do
                {
                    int index2 = Module1.JudgeCompNo[index1];
                    int judgeNo = Module1.GetJudgeNo((object)index2);
                    if (judgeNo > 0 & (judgeNo <= checked(Module1.NoJ_GOE + Module1.NoTrj) | judgeNo == checked(Module1.JudgeSel * 7)))
                    {
                        if (MyProject.Forms.Form1.Controls["lblJ" + Conversions.ToString(judgeNo)].ForeColor == Color.Red)
                        {
                            this.SetCreateResultsRed(judgeNo);
                        }
                        else
                        {
                            if (this.DataGridView1.Rows[7].Cells[checked(5 + judgeNo)].Style.BackColor != Color.Green)
                                this.SetCreateResultsYellow(judgeNo);
                            if (Strings.Len(Module1.UpdStr[index2]) > 10 & this.completed2)
                                this.ImportOneTCP_File(Module1.UpdStr[index2], judgeNo, index2);
                        }
                    }
                    checked { ++index1; }
                }
                while (index1 <= 7);
                goto label_15;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ImportTCP_Files - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_15:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void ImportOneTCP_File(string Intxt, int Jno, int Cno)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int ErrReturn = 0;
                ProjectData.ClearProjectError();
                num1 = 2;
                int num3 = this.JoutDecode(Intxt, Cno);
                if (num3 == 0)
                {
                    if (Operators.CompareString(Module1.CC_Time, Module1.In_Time, false) == 0 & Operators.CompareString(Strings.Trim(Module1.IPar.JudgeNo), Strings.Trim(Conversion.Str((object)Cno)), false) == 0 & Operators.CompareString(Strings.Trim(Module1.IPar.Name), Strings.Trim(Strings.Trim(Module1.Vek[Module1.PNo].Name.FName) + " " + Strings.Trim(Module1.Vek[Module1.PNo].Name.LName)), false) == 0 & Operators.CompareString(Strings.Trim(Module1.IPar.Club), Strings.Trim(Module1.Vek[Module1.PNo].Club), false) == 0 & Operators.CompareString(Strings.Trim(Module1.IPar.Category), Strings.Trim(Module1.Category.Name) + Strings.Trim(Module1.SubCat()), false) == 0 & Operators.CompareString(Strings.Trim(Module1.IPar.Segment), Strings.Trim(Module1.Segment), false) == 0)
                    {
                        if (Module1.JCStatus[Cno] != 1)
                        {
                            if (Jno > 0)
                            {
                                this.UpdateJudgesDetails(Jno, (object)Color.Green, ref ErrReturn);
                                if (ErrReturn == 0)
                                {
                                    Module1.UpdStr[Cno] = "";
                                    MyProject.Forms.Form1.MakeJudgeTxtFile(Cno);
                                }
                                else
                                    goto label_16;
                            }
                            else
                            {
                                int num4 = (int)Interaction.MsgBox((object)"The Judge setup is terribly wrong!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            }
                        }
                        this.SetCreateResultsGreen();
                        goto label_16;
                    }
                    else
                    {
                        Module1.UpdStr[Cno] = "";
                        int num5 = (int)Interaction.MsgBox((object)("The data from computer " + Conversions.ToString(Cno) + " is not correct!\r\nThe data will be cleared! New input is required!\r\nIf needed initialize this with F12!"), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_16;
                    }
                }
                else
                {
                    Module1.UpdStr[Cno] = "";
                    int num6 = (int)Interaction.MsgBox((object)("The data from computer " + Conversions.ToString(Cno) + " is not correct!\r\nThe data will be cleared! New input is required!\r\n\r\nErrcode= " + Conversions.ToString(num3)), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    goto label_16;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num7 = (int)Interaction.MsgBox((object)("ImportOneTCP_File - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_16:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void UpdateJudgesDetails(int Jno, object Cind, ref int ErrReturn)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int[] myarr = new int[11];
                ProjectData.ClearProjectError();
                num1 = 2;
                int num3 = Module1.NoOfElement();
                if (num3 > 0 | num3 == 0 & Strings.UCase(Module1.Category.Name).Contains("ARTISTISK"))
                {
                    ErrReturn = 0;
                    DataGridView dataGridView1 = this.DataGridView1;
                    object obj1 = Cind;
                    Color green = Color.Green;
                    if ((obj1 != null ? (Color)obj1 : green) == Color.Green)
                    {
                        if (num3 == Module1.IPar.NoE)
                        {
                            int num4 = num3;
                            int index1 = 1;
                            while (index1 <= num4)
                            {
                                string segment = Module1.Segment;
                                if (Operators.CompareString(segment, "Seg1", false) == 0)
                                    Module1.Vek[Module1.PNo].J_Seg1.EE[index1, Jno] = Conversions.ToInteger(Module1.IPar.EE[index1]);
                                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                                    Module1.Vek[Module1.PNo].J_Seg2.EE[index1, Jno] = Conversions.ToInteger(Module1.IPar.EE[index1]);
                                checked { ++index1; }
                            }
                            int noPc = Module1.IPar.NoPC;
                            int index2 = 1;
                            while (index2 <= noPc)
                            {
                                string segment = Module1.Segment;
                                if (Operators.CompareString(segment, "Seg1", false) == 0)
                                    Module1.Vek[Module1.PNo].J_Seg1.PC[index2, Jno] = Conversions.ToDouble(Module1.IPar.PC[index2].Replace(".", ","));
                                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                                    Module1.Vek[Module1.PNo].J_Seg2.PC[index2, Jno] = Conversions.ToDouble(Module1.IPar.PC[index2].Replace(".", ","));
                                checked { ++index2; }
                            }
                            string segment1 = Module1.Segment;
                            if (Operators.CompareString(segment1, "Seg1", false) == 0)
                                Module1.Vek[Module1.PNo].J_Seg1.Deduction[Jno] = Module1.IPar.Deduct1;
                            else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                                Module1.Vek[Module1.PNo].J_Seg2.Deduction[Jno] = Module1.IPar.Deduct1;
                            if (Jno <= Module1.NoJ_GOE | Jno > checked(Module1.NoJ_GOE + Module1.NoTrj))
                            {
                                Module1.GetArr(ref myarr, Module1.IPar.Deduct2);
                                if (myarr[1] > 0)
                                    Module1.SetDed(myarr[1], 1, Module1.Segment);
                                if (myarr[2] > 0)
                                    Module1.SetDed(myarr[2], 4, Module1.Segment);
                                if (myarr[3] > 0)
                                    Module1.SetDed(myarr[3], 5, Module1.Segment);
                                if (myarr[4] > 0)
                                    Module1.SetDed(myarr[4], 2, Module1.Segment);
                                if (myarr[5] > 0)
                                    Module1.SetDed(myarr[5], 3, Module1.Segment);
                                if (myarr[6] > 0)
                                    Module1.SetDed(myarr[6], 6, Module1.Segment);
                            }
                            int row = Module1.B_SSS_data(0);
                            int num5 = checked(row - 8);
                            Module1.A_Calc_Sum(0, 1);
                            Module1.B_Show_GOEdata(0, row);
                            Module1.B_Show_PCfactors(0, checked(row + 1));
                            Module1.A_CalcPC(0, checked(row + 2), 1);
                            Module1.B_Show_PCdata(0, checked(row + 3));
                            Module1.B_Calc_BaseSum(0, row);
                            Module1.B_Show_Bonus(0);
                            int rowDGW = 0;
                            Module1.B_Show_Deductions(0, checked(row + 9), ref rowDGW);
                            Module1.B_Show_Scores(0);
                            this.ShowJD(rowDGW);
                        }
                        else
                        {
                            int num6 = (int)Interaction.MsgBox((object)("Error in data from Judge no." + Conversions.ToString(Jno) + "\r\nDifferent no. of elements!"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            ErrReturn = 9999;
                            goto label_43;
                        }
                    }
                    DataGridViewCellStyle style = dataGridView1.Rows[7].Cells[checked(5 + Jno)].Style;
                    object obj2 = Cind;
                    Color color = obj2 != null ? (Color)obj2 : green;
                    style.BackColor = color;
                    goto label_43;
                }
                else
                    goto label_43;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                ErrReturn = 8888;
                int num7 = (int)Interaction.MsgBox((object)("UpdateJudgesDetails - \r\n" + Information.Err().Description), MsgBoxStyle.Critical | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_43:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public int JoutDecode(string InTxt, int Jnr)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                num2 = 0;
                string[] strArray = InTxt.Split(';');
                if ((double)checked(Strings.Len(InTxt) - Strings.Len(strArray[0]) - 1) == Conversions.ToDouble(strArray[0]))
                {
                    Module1.In_Time = strArray[1];
                    if (Operators.CompareString(Module1.CC_Time, Module1.In_Time, false) == 0)
                    {
                        Module1.IPar.JudgeNo = strArray[2];
                        if (Jnr == Conversions.ToInteger(Module1.IPar.JudgeNo))
                        {
                            Module1.IPar.Name = strArray[3];
                            Module1.IPar.Club = strArray[4];
                            Module1.IPar.Category = strArray[5];
                            Module1.IPar.Segment = strArray[6];
                            Module1.IPar.NoE = checked((int)Conversions.ToLong(strArray[7]));
                            int noE = Module1.IPar.NoE;
                            int index1 = 1;
                            while (index1 <= noE)
                            {
                                Module1.IPar.EE[index1] = strArray[checked(7 + index1)];
                                checked { ++index1; }
                            }
                            Module1.IPar.NoPC = checked((int)Conversions.ToLong(strArray[7 + Module1.IPar.NoE + 1]));
                            int noPc = Module1.IPar.NoPC;
                            int index2 = 1;
                            while (index2 <= noPc)
                            {
                                Module1.IPar.PC[index2] = strArray[checked(7 + Module1.IPar.NoE + 1 + index2)];
                                checked { ++index2; }
                            }
                            int index3 = checked(7 + Module1.IPar.NoE + Module1.IPar.NoPC + 2);
                            Module1.IPar.Deduct1 = Conversions.ToLong(strArray[index3]);
                            Module1.IPar.Deduct2 = Conversions.ToLong(strArray[checked(index3 + 1)]);
                            Module1.IPar.Deduct3 = Conversions.ToLong(strArray[checked(index3 + 2)]);
                            if (checked(index3 + 3) <= checked(strArray.Length - 2))
                            {
                                Module1.IPar.StartNo = Conversions.ToInteger(strArray[checked(index3 + 3)]);
                                goto label_18;
                            }
                            else
                                goto label_18;
                        }
                        else
                        {
                            num2 = 998;
                            goto label_18;
                        }
                    }
                    else
                        goto label_18;
                }
                else
                {
                    num2 = 999;
                    goto label_18;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num3 = -1;
            if (num1 == 2)
            {
                num2 = 997;
                int num4 = (int)Interaction.MsgBox((object)("JoutDecode - \r\n" + Information.Err().Description), MsgBoxStyle.Critical | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_18:
            int num5 = num2;
            if (num3 == 0)
                return num5;
            ProjectData.ClearProjectError();
            return num5;
        }

        public void ExportDataToPDFTable1(int norow, int nocol, string txt, string pathfile, int msg)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string str1 = "";
                int num3 = 110;
                int x1 = 20;
                int width1 = 20;
                int Length = 36;
                ProjectData.ClearProjectError();
                num1 = 2;
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                    str1 = ", Date: " + Module1.FormShortDate(Module1.Datum.Seg1);
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    str1 = ", Date: " + Module1.FormShortDate(Module1.Datum.Seg2);
                PdfDocument pdfDocument = new PdfDocument();
                pdfDocument.Info.Title = "JUDGES DETAILS";
                pdfDocument.Info.Subject = Module1.Category.Name + Module1.SubCat() + ", " + txt;
                pdfDocument.Info.Author = "ClubCompFS Single ver. 10.0.6, 2019-01-12";
                PdfPage page = pdfDocument.AddPage();
                page.Size = PageSize.A4;
                int width2 = checked((int)Math.Round(unchecked(page.Width.Point - (double)x1 - (double)width1)));
                float[] numArray = new float[15]
                {
          0.0f,
          3f,
          21f,
          3f,
          12f,
          3f,
          6f,
          6f,
          6f,
          6f,
          6f,
          6f,
          6f,
          6f,
          10f
                };
                int num4 = checked((int)Math.Round(page.Height.Point));
                XFont xfont1 = new XFont("ARIAL", 12.0, XFontStyle.Bold | XFontStyle.Underline);
                XFont font1 = new XFont("ARIAL", 8.0, XFontStyle.Bold);
                XFont xfont2 = new XFont("ARIAL", 8.0, XFontStyle.Regular);
                XFont xfont3 = new XFont("ARIAL", 6.0, XFontStyle.Regular);
                XGraphics xgraphics1 = XGraphics.FromPdfPage(page);
                int integer1 = Conversions.ToInteger(this.txtPrint.Text);
                int index1 = 1;
                int integer2 = Conversions.ToInteger(Module1.F4arr[1, 0]);
                do
                {
                    XImage image = XImage.FromFile("IE_Logo_HD.png");
                    XImage image2 = XImage.FromFile("FSI_Logo_HD.png");
                    XRect rect = new XRect(10.0, 10.0, image.PointWidth, image.PointHeight);
                    XRect rect2 = new XRect(480.0, 10.0, 100, 80);
                    xgraphics1.DrawImage(image, rect);
                    xgraphics1.DrawImage(image, rect2);
                    int num5 = 0;
                    int num6 = 0;
                    int height = 0;
                    do
                    {
                        checked { ++num5; }
                        int y1 = num5 != 1 ? checked(num6 + 4 * height) : num3;
                        int num7 = y1;
                        xgraphics1.DrawLine(XPens.Gray, checked(x1 - 1), checked(y1 - 1), checked(x1 + width2 + 1), checked(y1 - 1));
                        height = checked((int)Math.Round(font1.GetHeight()));
                        xgraphics1.DrawString("JUDGES DETAILS", font1, (XBrush)XBrushes.Black, new XRect((double)x1, (double)y1, (double)width2, (double)height), XStringFormats.TopLeft);
                        int y2 = checked(y1 + height);
                        XGraphics xgraphics2 = xgraphics1;
                        string str2 = "COMPETITION: " + Module1.Competition.Name + str1;
                        XFont xfont4 = font1;
                        XSolidBrush black1 = XBrushes.Black;
                        XRect xrect1 = new XRect((double)x1, (double)y2, (double)width2, (double)height);
                        XStringFormat topLeft1 = XStringFormats.TopLeft;
                        string text1 = str2;
                        XFont font2 = xfont4;
                        XSolidBrush brush1 = black1;
                        XRect layoutRectangle1 = xrect1;
                        XStringFormat format1 = topLeft1;
                        xgraphics2.DrawString(text1, font2, (XBrush)brush1, layoutRectangle1, format1);
                        int y3 = checked(y2 + height);
                        xgraphics1.DrawString("CATEGORY: " + Module1.Category.Name + Module1.SubCat() + ", " + Module1.GetSegTxt(Module1.Segment), font1, (XBrush)XBrushes.Black, new XRect((double)x1, (double)y3, (double)width2, (double)height), XStringFormats.TopLeft);
                        int num8 = 0;
                        do
                        {
                            checked { ++num8; }
                            if (num8 > 3)
                            {
                                y3 = checked(y3 + height + 1);
                                int x2 = x1;
                                int index2 = 1;
                                do
                                {
                                    int width3 = checked((int)Math.Round(unchecked((double)numArray[index2] * (double)width2 / 100.0)));
                                    string str3 = Strings.Left(Strings.Len(Module1.F4arr[index1, index2]) <= 0 ? " " : Module1.F4arr[index1, index2], Length);
                                    if (num8 == 4 || num8 == 8)
                                    {
                                        XFont xfont5 = font1;
                                        if (integer1 == 1 | integer1 == 0 & num8 == 4 | integer1 == 0 & num8 == 8 & (checked(index2 - 7) < Module1.NoJ_GOE | index2 == 14))
                                        {
                                            switch (index2)
                                            {
                                                case 1:
                                                case 3:
                                                case 4:
                                                case 5:
                                                case 6:
                                                case 7:
                                                case 8:
                                                case 9:
                                                case 10:
                                                case 11:
                                                case 12:
                                                case 13:
                                                case 14:
                                                    XGraphics xgraphics3 = xgraphics1;
                                                    string str4 = str3;
                                                    XFont xfont6 = xfont5;
                                                    XSolidBrush black2 = XBrushes.Black;
                                                    XRect xrect2 = new XRect((double)x2, (double)y3, (double)width3, (double)height);
                                                    XStringFormat center = XStringFormats.Center;
                                                    string text2 = str4;
                                                    XFont font3 = xfont6;
                                                    XSolidBrush brush2 = black2;
                                                    XRect layoutRectangle2 = xrect2;
                                                    XStringFormat format2 = center;
                                                    xgraphics3.DrawString(text2, font3, (XBrush)brush2, layoutRectangle2, format2);
                                                    break;
                                                case 2:
                                                    XGraphics xgraphics4 = xgraphics1;
                                                    string str5 = str3;
                                                    XFont xfont7 = xfont5;
                                                    XSolidBrush black3 = XBrushes.Black;
                                                    XRect xrect3 = new XRect((double)x2, (double)y3, (double)width3, (double)height);
                                                    XStringFormat topLeft2 = XStringFormats.TopLeft;
                                                    string text3 = str5;
                                                    XFont font4 = xfont7;
                                                    XSolidBrush brush3 = black3;
                                                    XRect layoutRectangle3 = xrect3;
                                                    XStringFormat format3 = topLeft2;
                                                    xgraphics4.DrawString(text3, font4, (XBrush)brush3, layoutRectangle3, format3);
                                                    break;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        XFont xfont8 = xfont2;
                                        if (integer1 == 1)
                                        {
                                            switch (index2)
                                            {
                                                case 1:
                                                case 3:
                                                case 4:
                                                case 5:
                                                case 6:
                                                case 7:
                                                case 8:
                                                case 9:
                                                case 10:
                                                case 11:
                                                case 12:
                                                case 13:
                                                case 14:
                                                    XGraphics xgraphics5 = xgraphics1;
                                                    string str6 = str3;
                                                    XFont xfont9 = xfont8;
                                                    XSolidBrush black4 = XBrushes.Black;
                                                    XRect xrect4 = new XRect((double)x2, (double)y3, (double)width3, (double)height);
                                                    XStringFormat center1 = XStringFormats.Center;
                                                    string text4 = str6;
                                                    XFont font5 = xfont9;
                                                    XSolidBrush brush4 = black4;
                                                    XRect layoutRectangle4 = xrect4;
                                                    XStringFormat format4 = center1;
                                                    xgraphics5.DrawString(text4, font5, (XBrush)brush4, layoutRectangle4, format4);
                                                    break;
                                                case 2:
                                                    XGraphics xgraphics6 = xgraphics1;
                                                    string str7 = str3;
                                                    XFont xfont10 = xfont8;
                                                    XSolidBrush black5 = XBrushes.Black;
                                                    XRect xrect5 = new XRect((double)x2, (double)y3, (double)width3, (double)height);
                                                    XStringFormat topLeft3 = XStringFormats.TopLeft;
                                                    string text5 = str7;
                                                    XFont font6 = xfont10;
                                                    XSolidBrush brush5 = black5;
                                                    XRect layoutRectangle5 = xrect5;
                                                    XStringFormat format5 = topLeft3;
                                                    xgraphics6.DrawString(text5, font6, (XBrush)brush5, layoutRectangle5, format5);
                                                    break;
                                            }
                                        }
                                        else if (num8 < 8)
                                        {
                                            switch (index2)
                                            {
                                                case 1:
                                                case 3:
                                                case 4:
                                                case 5:
                                                case 6:
                                                case 7:
                                                case 8:
                                                case 9:
                                                case 10:
                                                case 11:
                                                case 12:
                                                case 13:
                                                case 14:
                                                    XGraphics xgraphics7 = xgraphics1;
                                                    string str8 = str3;
                                                    XFont xfont11 = xfont8;
                                                    XSolidBrush black6 = XBrushes.Black;
                                                    XRect xrect6 = new XRect((double)x2, (double)y3, (double)width3, (double)height);
                                                    XStringFormat center2 = XStringFormats.Center;
                                                    string text6 = str8;
                                                    XFont font7 = xfont11;
                                                    XSolidBrush brush6 = black6;
                                                    XRect layoutRectangle6 = xrect6;
                                                    XStringFormat format6 = center2;
                                                    xgraphics7.DrawString(text6, font7, (XBrush)brush6, layoutRectangle6, format6);
                                                    break;
                                                case 2:
                                                    XGraphics xgraphics8 = xgraphics1;
                                                    string str9 = str3;
                                                    XFont xfont12 = xfont8;
                                                    XSolidBrush black7 = XBrushes.Black;
                                                    XRect xrect7 = new XRect((double)x2, (double)y3, (double)width3, (double)height);
                                                    XStringFormat topLeft4 = XStringFormats.TopLeft;
                                                    string text7 = str9;
                                                    XFont font8 = xfont12;
                                                    XSolidBrush brush7 = black7;
                                                    XRect layoutRectangle7 = xrect7;
                                                    XStringFormat format7 = topLeft4;
                                                    xgraphics8.DrawString(text7, font8, (XBrush)brush7, layoutRectangle7, format7);
                                                    break;
                                            }
                                        }
                                        else if (checked(index2 - 7) < Module1.NoJ_GOE | index2 == 14)
                                        {
                                            switch (index2)
                                            {
                                                case 1:
                                                case 3:
                                                case 4:
                                                case 5:
                                                case 6:
                                                case 7:
                                                case 8:
                                                case 9:
                                                case 10:
                                                case 11:
                                                case 12:
                                                case 13:
                                                case 14:
                                                    XGraphics xgraphics9 = xgraphics1;
                                                    string str10 = str3;
                                                    XFont xfont13 = xfont8;
                                                    XSolidBrush black8 = XBrushes.Black;
                                                    XRect xrect8 = new XRect((double)x2, (double)y3, (double)width3, (double)height);
                                                    XStringFormat center3 = XStringFormats.Center;
                                                    string text8 = str10;
                                                    XFont font9 = xfont13;
                                                    XSolidBrush brush8 = black8;
                                                    XRect layoutRectangle8 = xrect8;
                                                    XStringFormat format8 = center3;
                                                    xgraphics9.DrawString(text8, font9, (XBrush)brush8, layoutRectangle8, format8);
                                                    break;
                                                case 2:
                                                    XGraphics xgraphics10 = xgraphics1;
                                                    string str11 = str3;
                                                    XFont xfont14 = xfont8;
                                                    XSolidBrush black9 = XBrushes.Black;
                                                    XRect xrect9 = new XRect((double)x2, (double)y3, (double)width3, (double)height);
                                                    XStringFormat topLeft5 = XStringFormats.TopLeft;
                                                    string text9 = str11;
                                                    XFont font10 = xfont14;
                                                    XSolidBrush brush9 = black9;
                                                    XRect layoutRectangle9 = xrect9;
                                                    XStringFormat format9 = topLeft5;
                                                    xgraphics10.DrawString(text9, font10, (XBrush)brush9, layoutRectangle9, format9);
                                                    break;
                                            }
                                        }
                                    }
                                    checked { x2 += width3; }
                                    checked { ++index2; }
                                }
                                while (index2 <= 14);
                            }
                            checked { ++index1; }
                        }
                        while (!(index1 == norow | (double)integer2 != Conversions.ToDouble(Module1.F4arr[checked(index1 + 1), 0])));
                        int index3 = 1;
                        do
                        {
                            string str12 = Strings.Len(Module1.F4arr[index1, index3]) <= 0 ? " " : Module1.F4arr[index1, index3];
                            switch (index3)
                            {
                                case 1:
                                    XGraphics xgraphics11 = xgraphics1;
                                    string str13 = str12;
                                    XFont xfont15 = xfont2;
                                    XSolidBrush black10 = XBrushes.Black;
                                    XRect xrect10 = new XRect((double)x1 + (double)numArray[1] * (double)width2 / 100.0, (double)y3, (double)checked(x1 + width2), (double)height);
                                    XStringFormat topLeft6 = XStringFormats.TopLeft;
                                    string text10 = str13;
                                    XFont font11 = xfont15;
                                    XSolidBrush brush10 = black10;
                                    XRect layoutRectangle10 = xrect10;
                                    XStringFormat format10 = topLeft6;
                                    xgraphics11.DrawString(text10, font11, (XBrush)brush10, layoutRectangle10, format10);
                                    checked { y3 += height; }
                                    break;
                                case 2:
                                    XGraphics xgraphics12 = xgraphics1;
                                    string str14 = str12;
                                    XFont xfont16 = xfont2;
                                    XSolidBrush black11 = XBrushes.Black;
                                    XRect xrect11 = new XRect((double)x1 + (double)numArray[1] * (double)width2 / 100.0, (double)y3, (double)checked(x1 + width2), (double)height);
                                    XStringFormat topLeft7 = XStringFormats.TopLeft;
                                    string text11 = str14;
                                    XFont font12 = xfont16;
                                    XSolidBrush brush11 = black11;
                                    XRect layoutRectangle11 = xrect11;
                                    XStringFormat format11 = topLeft7;
                                    xgraphics12.DrawString(text11, font12, (XBrush)brush11, layoutRectangle11, format11);
                                    break;
                            }
                            checked { ++index3; }
                        }
                        while (index3 <= 2);
                        checked { ++index1; }
                        integer2 = Conversions.ToInteger(Module1.F4arr[index1, 0]);
                        num6 = checked(y3 + height);
                        xgraphics1.DrawLine(XPens.Gray, checked(x1 - 1), checked(num7 - 1), checked(x1 - 1), checked(num6 + 1));
                        xgraphics1.DrawLine(XPens.Gray, checked(x1 + width2 + 1), checked(num7 - 1), checked(x1 + width2 + 1), checked(num6 + 1));
                        xgraphics1.DrawLine(XPens.Gray, checked(x1 - 1), checked(num6 + 1), checked(x1 + width2 + 1), checked(num6 + 1));
                        XGraphics xgraphics13 = xgraphics1;
                        string str15 = "Attenzione, il seguente \"Judges details\" non è confrontabile con quelli delle gare di fascia silver, gold, elite o internazionali. "; // "Attenzione, il seguente \"Judges details\" non è confrontabile con quelli delle gare di fascia (interregionale, nazionale ed elite) o internazionali,"
                        XFont xfont17 = xfont2;
                        XSolidBrush black12 = XBrushes.Black;
                        XRect xrect12 = new XRect((double)x1, (double)num6 + 5.0, (double)checked(x1 + width2), (double)num6 + 7.0);
                        XStringFormat topLeft8 = XStringFormats.TopLeft;
                        string text12 = str15;
                        XFont font13 = xfont17;
                        XSolidBrush brush12 = black12;
                        XRect layoutRectangle12 = xrect12;
                        XStringFormat format12 = topLeft8;
                        xgraphics13.DrawString(text12, font13, (XBrush)brush12, layoutRectangle12, format12);
                        XGraphics xgraphics14 = xgraphics1;
                        string str16 = "";// "in quanto è stata utilizzata la tabella dei valori delle gare Intersociali.";
                        XFont xfont18 = xfont2;
                        XSolidBrush black13 = XBrushes.Black;
                        XRect xrect13 = new XRect((double)x1, (double)num6 + 13.0, (double)checked(x1 + width2), (double)num6 + 15.0);
                        XStringFormat topLeft9 = XStringFormats.TopLeft;
                        string text13 = str16;
                        XFont font14 = xfont18;
                        XSolidBrush brush13 = black13;
                        XRect layoutRectangle13 = xrect13;
                        XStringFormat format13 = topLeft9;
                        xgraphics14.DrawString(text13, font14, (XBrush)brush13, layoutRectangle13, format13);
                        int num9 = checked(y3 + height);
                    }
                    while (!(num5 == 2 | index1 >= norow | (double)integer2 != Conversions.ToDouble(Module1.F4arr[checked(index1 + 1), 0])));
                    XGraphics xgraphics15 = xgraphics1;
                    string str17 = "Figure Skating Italia | Created: " + Module1.DateTimeToStr(DateTime.Now);
                    XFont xfont19 = font1;
                    XSolidBrush black = XBrushes.Black;
                    XRect xrect = new XRect((double)x1, (double)num6 + 40.0, (double)width1, (double)num6 + 45.0);
                    XStringFormat topLeft = XStringFormats.TopLeft;
                    string text = str17;
                    XFont font15 = xfont19;
                    XSolidBrush brush = black;
                    XRect layoutRectangle = xrect;
                    XStringFormat format = topLeft;
                    xgraphics15.DrawString(text, font15, (XBrush)brush, layoutRectangle, format);
                    integer2 = Conversions.ToInteger(Module1.F4arr[index1, 0]);
                    if (index1 != norow)
                        xgraphics1 = XGraphics.FromPdfPage(pdfDocument.AddPage());
                }
                while (index1 < norow);
                pdfDocument.Save(pathfile);
                pdfDocument.Close();
                switch (msg)
                {
                    case 1:
                        int num10 = (int)Interaction.MsgBox((object)("The file has been saved as:\r\n" + pathfile), MsgBoxStyle.Information | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_46;
                    case 2:
                        int num11 = (int)Interaction.MsgBox((object)("The file(s) has been saved in:\r\n" + Module1.GetPath(pathfile)), MsgBoxStyle.Information | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_46;
                    default:
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
                int num12 = (int)Interaction.MsgBox((object)("Form4, ExportDataToPDFTable1 - \r\n" + Information.Err().Description), MsgBoxStyle.Critical | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_46:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e) => this.ExitForm4();

        public void CreateJD_PDFfile(int msg)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string Path = "";
                int num3 = 0;
                ProjectData.ClearProjectError();
                num1 = 2;
                Module1.F4arr = (string[,])null;
                Module1.F4arr = new string[2501, 15];
                string par = "";
                string segTxt = Module1.GetSegTxt(Module1.Segment);
                string segment1 = Module1.Segment;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    Module1.SortListSeg1(Module1.TNop);
                    Module1.Seg1Pl(checked(Module1.TNop - Module1.DNS_Seg1));
                    par = "Segment_1";
                }
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                {
                    Module1.SortListSeg2(Module1.TNop);
                    Module1.Seg2Pl(checked(Module1.TNop - Module1.DNS_Seg1 - Module1.DNS_Seg2));
                    par = "Segment_2";
                }
                int num4 = 1;
                Module1.PNo = 0;
                int tnop = Module1.TNop;
                Module1.PNo = 1;
                int norow = 0;
                while (Module1.PNo <= tnop)
                {
                    string segment2 = Module1.Segment;
                    int rowDed = 0;
                    if (Operators.CompareString(segment2, "Seg1", false) == 0)
                    {
                        if (Module1.Vek[Module1.PNo].Finished_Seg1 == 1)
                        {
                            Module1.CreateJudgesDetails(0, ref rowDed);
                            checked { ++num3; }
                        }
                        else
                            goto label_18;
                    }
                    else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                    {
                        if (Module1.Vek[Module1.PNo].Finished_Seg2 == 1)
                        {
                            Module1.CreateJudgesDetails(0, ref rowDed);
                            checked { ++num3; }
                        }
                        else
                            goto label_18;
                    }
                    int num5 = checked(num4 + rowDed);
                    int index1 = 0;
                    int num6 = num4;
                    int num7 = checked(num5 - 1);
                    norow = num6;
                    while (norow <= num7)
                    {
                        checked { ++index1; }
                        Module1.F4arr[norow, 0] = Conversions.ToString(Module1.PNo);
                        int index2 = 1;
                        do
                        {
                            Module1.F4arr[norow, index2] = Module1.JDarr[index1, index2];
                            checked { ++index2; }
                        }
                        while (index2 <= 14);
                        checked { ++norow; }
                    }
                    num4 = num5;
                    label_18:
                    checked { ++Module1.PNo; }
                }
                if (num3 > 0)
                {
                    if (Conversions.ToBoolean(Module1.CreatePath(par, ref Path)))
                    {
                        this.ExportDataToPDFTable1(norow, 14, segTxt, Path + "_JD.pdf", msg);
                        goto label_29;
                    }
                    else
                        goto label_29;
                }
                else
                {
                    int num8 = (int)Interaction.MsgBox((object)"No finished program!", MsgBoxStyle.Information | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    goto label_29;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num9 = (int)Interaction.MsgBox((object)("Form4, CreateJD_PDFfile - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_29:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void ShowJD(int DGVrows)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.Width = 1035;
                this.Text = "JUDGES DETAILS";
                DataGridView dataGridView1 = this.DataGridView1;
                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.ReadOnly = Module1.WorkMode > 1;
                dataGridView1.ColumnCount = 14;
                dataGridView1.RowCount = checked(DGVrows - 1);
                dataGridView1.Width = 1045;
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 30;
                dataGridView1.Columns[3].Width = 85;
                dataGridView1.Columns[4].Width = 30;
                dataGridView1.Columns[5].Width = 70;
                dataGridView1.Columns[6].Width = 70;
                dataGridView1.Columns[7].Width = 70;
                dataGridView1.Columns[8].Width = 70;
                dataGridView1.Columns[9].Width = 70;
                dataGridView1.Columns[10].Width = 70;
                dataGridView1.Columns[11].Width = 70;
                dataGridView1.Columns[12].Width = 70;
                dataGridView1.Columns[13].Width = 90;
                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[13].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.RowHeadersVisible = false;
                int num3 = -1;
                int num4 = checked(DGVrows - 1);
                int rowIndex = 1;
                while (rowIndex <= num4)
                {
                    if (Conversions.ToDouble(Module1.JDarr[rowIndex, 0]) != (double)num3)
                    {
                        num3 = Conversions.ToInteger(Module1.JDarr[rowIndex, 0]);
                        dataGridView1.Rows[checked(rowIndex - 1)].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    int columnIndex = 1;
                    do
                    {
                        dataGridView1.Rows[checked(rowIndex - 1)].Cells[checked(columnIndex - 1)].Value = (object)Module1.JDarr[rowIndex, columnIndex];
                        if (rowIndex >= 8 & columnIndex == 1 && Module1.ElErrorArr[checked(rowIndex - 7)] > 0)
                            dataGridView1[columnIndex, rowIndex].Style.BackColor = Color.LightPink;
                        checked { ++columnIndex; }
                    }
                    while (columnIndex <= 14);
                    string Left = Strings.UCase(Module1.JDarr[rowIndex, 2]);
                    if (Operators.CompareString(Left, "NAME", false) == 0)
                    {
                        int index = checked(rowIndex - 1);
                        dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    else if (Operators.CompareString(Left, "EXECUTED ELEMENTS", false) == 0)
                    {
                        int index = checked(rowIndex - 1);
                        dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    else if (Operators.CompareString(Left, "PROGRAM COMPONENTS", false) == 0)
                    {
                        int index = checked(rowIndex - 1);
                        dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    checked { ++rowIndex; }
                }
                this.DataGridView1.Height = checked((DGVrows - 2) * this.DataGridView1.RowTemplate.Height + this.DataGridView1.Top);
                DataGridView dataGridView2 = this.DataGridView2;
                dataGridView2.RowCount = 1;
                dataGridView2.ColumnCount = 2;
                dataGridView2.Width = this.DataGridView1.Width;
                dataGridView2.Top = this.DataGridView1.Bottom;
                dataGridView2.Columns[0].Width = 30;
                dataGridView2.Columns[1].Width = 995;
                dataGridView2.Height = checked(dataGridView2.RowTemplate.Height + 5);
                dataGridView2.Rows[0].Cells[1].Value = (object)Module1.JDarr[DGVrows, 2];
                dataGridView2.RowHeadersVisible = false;
                dataGridView2.ColumnHeadersVisible = false;
                this.Height = checked(this.DataGridView1.Top + this.DataGridView1.Height + this.DataGridView2.Height + 30);
                goto label_22;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("ShowJD - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_22:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void PrintDocument2_PrintPage(object sender, PrintPageEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                double num3 = Module1.Page_Size * 0.7 / 100.0;
                int pageLeftMargin = Module1.Page_Left_Margin;
                int pageTopMargin = Module1.Page_Top_Margin;
                string str = "";
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                int integer1 = Conversions.ToInteger(this.txtPrint.Text);
                StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit)
                {
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter
                };
                StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
                StringFormat format2 = new StringFormat(StringFormatFlags.NoClip);
                format1.Alignment = StringAlignment.Center;
                format2.Alignment = StringAlignment.Near;
                int emSize = checked((int)Math.Round(Conversion.Int(unchecked(num3 * 10.0 + 2.55))));
                Font font1 = new Font("ARIAL", (float)checked(emSize + 3), FontStyle.Bold, GraphicsUnit.Pixel);
                Font font2 = new Font("ARIAL", (float)emSize, FontStyle.Bold, GraphicsUnit.Pixel);
                Font font3 = new Font("ARIAL", (float)emSize, FontStyle.Regular, GraphicsUnit.Pixel);
                int integer2 = Conversions.ToInteger(Module1.F4arr[this.mRow, 0]);
                float num4 = 40f;
                int num5 = 0;
                do
                {
                    checked { ++num5; }
                    if (num5 == 1)
                    {
                        string segTxt = Module1.GetSegTxt(Module1.Segment);
                        string segment = Module1.Segment;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                            str = ", DATE: " + Module1.FormShortDate(Module1.Datum.Seg1);
                        else if (Operators.CompareString(segment, "Seg2", false) == 0)
                            str = ", DATE: " + Module1.FormShortDate(Module1.Datum.Seg2);
                        e.Graphics.DrawString("JUDGES DETAILS", font1, Brushes.Black, (float)pageLeftMargin, num4, new StringFormat());
                        float y1 = (float)((double)num4 + (double)dataGridView1.Font.GetHeight(e.Graphics) + 5.0);
                        e.Graphics.DrawString("COMPETITION: " + Module1.Competition.Name + str, font1, Brushes.Black, (float)pageLeftMargin, y1, new StringFormat());
                        float y2 = y1 + dataGridView1.Font.GetHeight(e.Graphics);
                        e.Graphics.DrawString("CATEGORY: " + Module1.Category.Name + Module1.SubCat() + ", " + segTxt, font1, Brushes.Black, (float)pageLeftMargin, y2, new StringFormat());
                        num4 = (float)((double)y2 + (double)dataGridView1.Font.GetHeight(e.Graphics) + 5.0);
                    }
                    int num6 = 0;
                    int num7 = 0;
                    int num8 = 0;
                    do
                    {
                        checked { ++num6; }
                        if (num6 > 3)
                        {
                            Font font4 = !(num6 == 4 | num6 == 8) ? font3 : font2;
                            if (num6 == 4)
                                num7 = checked((int)Math.Round((double)num4));
                            float x = (float)pageLeftMargin;
                            float num9 = 0.0f;
                            int index = 1;
                            do
                            {
                                int num10 = 0;
                                switch (index)
                                {
                                    case 1:
                                        num10 = 25;
                                        break;
                                    case 2:
                                        num10 = 200;
                                        break;
                                    case 3:
                                        num10 = 40;
                                        break;
                                    case 4:
                                        num10 = 90;
                                        break;
                                    case 5:
                                        num10 = 80;
                                        break;
                                    case 6:
                                    case 7:
                                    case 8:
                                    case 9:
                                    case 10:
                                    case 11:
                                    case 12:
                                    case 13:
                                        num10 = 65;
                                        break;
                                    case 14:
                                        num10 = 100;
                                        break;
                                }
                                RectangleF layoutRectangle = new RectangleF(x, num4, (float)num10 * (float)num3, (float)(25.0 * num3 * 0.8));
                                string s = Strings.Left(Module1.F4arr[this.mRow, index], 28);
                                if (index == 2)
                                    e.Graphics.DrawString(s, font4, Brushes.Black, layoutRectangle, format2);
                                else if (integer1 == 1)
                                    e.Graphics.DrawString(s, font4, Brushes.Black, layoutRectangle, format1);
                                else if (num6 < 8)
                                    e.Graphics.DrawString(s, font4, Brushes.Black, layoutRectangle, format1);
                                else if (checked(index - 7) < Module1.NoJ_GOE | index == 14)
                                    e.Graphics.DrawString(s, font4, Brushes.Black, layoutRectangle, format1);
                                x += layoutRectangle.Width;
                                num9 = Math.Max(num9, layoutRectangle.Height);
                                num8 = checked((int)Math.Round((double)num9));
                                checked { ++index; }
                            }
                            while (index <= 14);
                            this.newpage = false;
                            num4 += num9;
                        }
                        checked { ++this.mRow; }
                    }
                    while (!(this.mRow >= this.F4arrRows | (double)integer2 != Conversions.ToDouble(Module1.F4arr[checked(this.mRow + 1), 0])));
                    float x1 = (float)pageLeftMargin;
                    int index1 = 1;
                    do
                    {
                        int num11 = 0;
                        switch (index1)
                        {
                            case 1:
                                num11 = 25;
                                break;
                            case 2:
                                num11 = 1000;
                                break;
                        }
                        RectangleF layoutRectangle = new RectangleF(x1, num4, (float)num11 * (float)num3, (float)(25.0 * num3 * 0.8));
                        e.Graphics.DrawString(Module1.F4arr[this.mRow, index1], font3, Brushes.Black, layoutRectangle, format2);
                        x1 += layoutRectangle.Width;
                        checked { ++index1; }
                    }
                    while (index1 <= 2);
                    this.newpage = false;
                    checked { ++this.mRow; }
                    num4 = num4 + (float)num8 + (float)num8;
                    integer2 = Conversions.ToInteger(Module1.F4arr[this.mRow, 0]);
                    int width = checked((int)Math.Round(unchecked(1055.0 * num3)));
                    int height = checked((int)Math.Round(unchecked((double)num4 - (double)num7 - (double)num8)));
                    e.Graphics.DrawRectangle(Pens.Gray, pageLeftMargin, checked(num7 - 1), width, height);
                }
                while (!(num5 >= Module1.JDperPage | this.mRow >= this.F4arrRows));
                e.HasMorePages = this.mRow < this.F4arrRows;
                this.newpage = true;
                goto label_44;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num12 = (int)Interaction.MsgBox((object)("Form4, PrintDocument2_PrintPage - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_44:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void CreateJDAllSkaters(int dialog)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 0;
                ProjectData.ClearProjectError();
                num1 = 2;
                Module1.F4arr = (string[,])null;
                Module1.F4arr = new string[1501, 15];
                this.F4arrRows = 0;
                this.mRow = 1;
                string segment1 = Module1.Segment;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    Module1.SortListSeg1(Module1.TNop);
                    Module1.Seg1Pl(checked(Module1.TNop - Module1.DNS_Seg1));
                }
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                {
                    Module1.SortListSeg2(Module1.TNop);
                    Module1.Seg2Pl(checked(Module1.TNop - Module1.DNS_Seg1 - Module1.DNS_Seg2));
                }
                int num4 = 1;
                Module1.PNo = 0;
                int tnop = Module1.TNop;
                Module1.PNo = 1;
                int index1 = 0;
                while (Module1.PNo <= tnop)
                {
                    string segment2 = Module1.Segment;
                    int rowDed = 0;
                    if (Operators.CompareString(segment2, "Seg1", false) == 0)
                    {
                        if (Module1.Vek[Module1.PNo].Finished_Seg1 == 1)
                        {
                            Module1.CreateJudgesDetails(0, ref rowDed);
                            checked { ++num3; }
                        }
                        else
                            goto label_18;
                    }
                    else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                    {
                        if (Module1.Vek[Module1.PNo].Finished_Seg2 == 1)
                        {
                            Module1.CreateJudgesDetails(0, ref rowDed);
                            checked { ++num3; }
                        }
                        else
                            goto label_18;
                    }
                    int num5 = checked(num4 + rowDed);
                    int index2 = 0;
                    int num6 = num4;
                    int num7 = checked(num5 - 1);
                    index1 = num6;
                    while (index1 <= num7)
                    {
                        checked { ++index2; }
                        Module1.F4arr[index1, 0] = Conversions.ToString(Module1.PNo);
                        int index3 = 1;
                        do
                        {
                            Module1.F4arr[index1, index3] = Module1.JDarr[index2, index3];
                            checked { ++index3; }
                        }
                        while (index3 <= 14);
                        checked { ++index1; }
                    }
                    num4 = num5;
                    label_18:
                    checked { ++Module1.PNo; }
                }
                if (num3 > 0)
                {
                    this.F4arrRows = index1;
                    goto label_28;
                }
                else
                {
                    int num8 = (int)Interaction.MsgBox((object)"No finished program!", MsgBoxStyle.Information | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    goto label_28;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num9 = (int)Interaction.MsgBox((object)("Form4, CreateJDAllSkaters - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_28:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void ExitForm4()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.WillExitForm4 = false;
                switch (Module1.WorkMode)
                {
                    case 1:
                    case 3:
                        this.WillExitForm4 = true;
                        MyProject.Forms.InputJudgesDataDialog.Close();
                        MyProject.Forms.DeductionsDialog.Close();
                        this.Timer1.Enabled = false;
                        this.Close();
                        break;
                    case 2:
                        if (Module1.ScanJudges == 1 & this.Timer1.Enabled & Operators.CompareString(this.CreateMenu, "LightYellow", false) == 0)
                            this.WillExitForm4 = true;
                        else if (Module1.ScanJudges == 0)
                            this.WillExitForm4 = true;
                        else if (Interaction.MsgBox((object)"Do you really want to disable the ongoing Judges' Input?", MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") != MsgBoxResult.No)
                            this.WillExitForm4 = true;
                        else
                            goto label_18;
                        this.Timer1.Enabled = false;
                        MyProject.Forms.InputJudgesDataDialog.Close();
                        MyProject.Forms.DeductionsDialog.Close();
                        this.Close();
                        if (Module1.IsFormOpen((Form)MyProject.Forms.Form2))
                        {
                            MyProject.Forms.Form2.WillExitForm2 = true;
                            MyProject.Forms.Form2.Close();
                        }
                        MyProject.Forms.Form2.Show();
                        break;
                }
                MyProject.Forms.Form2.TopMost = true;
                goto label_18;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ExitForm4 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_18:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public bool MenuPossibleForm4()
        {
            bool flag = true;
            if (Module1.IsFormOpen((Form)MyProject.Forms.Dialog7))
            {
                int num = (int)Interaction.MsgBox((object)"Please close the DIALOG!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                flag = false;
            }
            else if (Module1.IsFormOpen((Form)MyProject.Forms.Form7))
            {
                int num = (int)Interaction.MsgBox((object)"Please close the WARMUP GROUPS!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                flag = false;
            }
            else if (Module1.IsFormOpen((Form)MyProject.Forms.Form5))
            {
                int num = (int)Interaction.MsgBox((object)"Please close the ELEMENT INPUT!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                flag = false;
            }
            return flag;
        }

        private void INPUTELEMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (this.MenuPossibleForm4())
                {
                    this.WillExitForm4 = false;
                    switch (Module1.WorkMode)
                    {
                        case 1:
                        case 3:
                            this.WillExitForm4 = true;
                            MyProject.Forms.InputJudgesDataDialog.Close();
                            MyProject.Forms.DeductionsDialog.Close();
                            this.Timer1.Enabled = false;
                            this.Close();
                            MyProject.Forms.Form2.ElementInput(4);
                            goto label_11;
                        case 2:
                            if (Interaction.MsgBox((object)"Do you really want to disable the ongoing Judges' Input?", MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") != MsgBoxResult.No)
                            {
                                this.WillExitForm4 = true;
                                MyProject.Forms.InputJudgesDataDialog.Close();
                                MyProject.Forms.DeductionsDialog.Close();
                                this.Timer1.Enabled = false;
                                this.Close();
                                MyProject.Forms.Form2.ElementInput(4);
                                goto label_11;
                            }
                            else
                                goto label_11;
                        default:
                            goto label_11;
                    }
                }
                else
                    goto label_11;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("INPUTELEMENTToolStripMenuItem_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_11:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void CREATERESULTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (this.MenuPossibleForm4())
                {
                    bool flag = true;
                    int num3 = 1;
                    do
                    {
                        if (num3 <= checked(Module1.NoJ_GOE + Module1.NoTrj) | num3 == 7 & Module1.NoJ_GOE <= 6 & Module1.JudgeSel != 0 && this.DataGridView1.Rows[7].Cells[checked(5 + num3)].Style.BackColor != Color.Green)
                            flag = false;
                        checked { ++num3; }
                    }
                    while (num3 <= 7);
                    if (flag | Module1.WorkMode == 3)
                    {
                        string segment = Module1.Segment;
                        int StNo = 0;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                        {
                            StNo = Module1.Vek[Module1.PNo].Startno_Seg1;
                            if (Module1.Vek[Module1.PNo].TES_Seg1 > Conversions.ToDouble(Module1.TE_Leader))
                                Module1.TE_Leader = Strings.Format((object)Module1.Vek[Module1.PNo].TES_Seg1, "0.00");
                        }
                        else if (Operators.CompareString(segment, "Seg2", false) == 0)
                        {
                            StNo = Module1.Vek[Module1.PNo].Startno_Seg2;
                            if (Module1.Vek[Module1.PNo].TES_Seg2 > Conversions.ToDouble(Module1.TE_Leader))
                                Module1.TE_Leader = Strings.Format((object)Module1.Vek[Module1.PNo].TES_Seg2, "0.00");
                        }
                        if (Module1.CreateHTMFile(StNo))
                        {
                            this.CREATERESULTSToolStripMenuItem.BackColor = Color.LightYellow;
                            this.CreateMenu = "LightYellow";
                            if (Strings.Len(Module1.CategoryFileName) > 1)
                            {
                                Module1.SaveCategoryFile(Module1.CategoryFileName);
                                this.ExitForm4();
                            }
                            MyProject.Forms.Form2.WillExitForm2 = true;
                            if (Module1.IsFormOpen((Form)MyProject.Forms.Form2))
                                MyProject.Forms.Form2.Close();
                            MyProject.Forms.Form2.Show();
                            MyProject.Forms.Form2.Top = -1;
                            goto label_26;
                        }
                        else
                        {
                            this.CREATERESULTSToolStripMenuItem.BackColor = Color.Red;
                            this.CreateMenu = "Red";
                            goto label_26;
                        }
                    }
                    else
                    {
                        this.CREATERESULTSToolStripMenuItem.BackColor = Color.Red;
                        this.CreateMenu = "Red";
                        int num4 = (int)Interaction.MsgBox((object)"The Judges are not ready!\r\nThe results have not been calculated!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_26;
                    }
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
                int num5 = (int)Interaction.MsgBox((object)("CREATERESULTSToolStripMenuItem_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_26:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void EDITJUDGEDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (this.MenuPossibleForm4())
                {
                    int num3 = checked(this.DataGridView1.CurrentCellAddress.X - 5);
                    if (num3 > 0 & num3 <= checked(Module1.NoJ_GOE + Module1.NoTrj) | Module1.JudgeSel == 1 & num3 == 7)
                    {
                        if (Module1.IsFormOpen((Form)MyProject.Forms.InputJudgesDataDialog))
                            MyProject.Forms.InputJudgesDataDialog.Close();
                        InputJudgesDataDialog dialog10 = MyProject.Forms.InputJudgesDataDialog;
                        dialog10.txtPno.Text = Conversions.ToString(Module1.PNo);
                        dialog10.txtJudgeNo.Text = Conversions.ToString(num3);
                        int num4 = (int)dialog10.ShowDialog((IWin32Window)this);
                        goto label_16;
                    }
                    else if (num3 == 8)
                    {
                        if (Module1.IsFormOpen((Form)MyProject.Forms.DeductionsDialog))
                            MyProject.Forms.DeductionsDialog.Close();
                        int num5 = (int)MyProject.Forms.DeductionsDialog.ShowDialog((IWin32Window)this);
                        goto label_16;
                    }
                    else
                    {
                        int num6 = (int)Interaction.MsgBox((object)"Select correct column!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_16;
                    }
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
                int num7 = (int)Interaction.MsgBox((object)("EDITJUDGEDATAToolStripMenuItem_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_16:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (this.Completed1)
                {
                    this.Completed1 = false;
                    this.ImportTCP_Files();
                    this.Completed1 = true;
                    goto label_8;
                }
                else
                    goto label_8;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("Timer1_Tick - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
                this.Completed1 = true;
            }
            label_8:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void SetCreateResultsGreen()
        {
            bool flag = true;
            int num = 1;
            do
            {
                if (num <= checked(Module1.NoJ_GOE + Module1.NoTrj) | num == 7 & Module1.NoJ_GOE <= 6 & Module1.JudgeSel != 0 && this.DataGridView1.Rows[7].Cells[checked(5 + num)].Style.BackColor != Color.Green)
                    flag = false;
                checked { ++num; }
            }
            while (num <= 7);
            if (!(flag & Module1.WorkMode == 2))
                return;
            this.CREATERESULTSToolStripMenuItem.BackColor = Color.LightGreen;
            this.INPUTELEMENTToolStripMenuItem.BackColor = SystemColors.Control;
        }

        public void SetCreateResultsYellow(int J)
        {
            if (!(J <= checked(Module1.NoJ_GOE + Module1.NoTrj) | J == checked(7 * Module1.JudgeSel)))
                return;
            this.DataGridView1.Rows[7].Cells[checked(5 + J)].Style.BackColor = Color.Yellow;
        }

        public void SetCreateResultsRed(int J)
        {
            if (!(J <= checked(Module1.NoJ_GOE + Module1.NoTrj) | J == checked(7 * Module1.JudgeSel)) || !(this.DataGridView1.Rows[7].Cells[checked(5 + J)].Style.BackColor != Color.Green))
                return;
            this.DataGridView1.Rows[7].Cells[checked(5 + J)].Style.BackColor = Color.Red;
        }

        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (Module1.WorkMode == 3)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        this.DataGridView1.CurrentCell = this.DataGridView1[e.ColumnIndex, e.RowIndex];
                        if (this.MenuPossibleForm4())
                        {
                            switch (e.RowIndex)
                            {
                                case 3:
                                    if (e.ColumnIndex == 13)
                                    {
                                        if (Module1.IsFormOpen((Form)MyProject.Forms.DeductionsDialog))
                                            MyProject.Forms.DeductionsDialog.Close();
                                        int num3 = (int)MyProject.Forms.DeductionsDialog.ShowDialog((IWin32Window)this);
                                        goto label_21;
                                    }
                                    else
                                    {
                                        int num4 = (int)Interaction.MsgBox((object)"Select the Deduction cell!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                        goto label_21;
                                    }
                                case 7:
                                    int num5 = checked(e.ColumnIndex - 5);
                                    if (num5 > 0 & num5 <= checked(Module1.NoJ_GOE + Module1.NoTrj) | Module1.JudgeSel == 1 & num5 == 7)
                                    {
                                        if (Module1.IsFormOpen((Form)MyProject.Forms.InputJudgesDataDialog))
                                            MyProject.Forms.InputJudgesDataDialog.Close();
                                        InputJudgesDataDialog dialog10 = MyProject.Forms.InputJudgesDataDialog;
                                        dialog10.txtPno.Text = Conversions.ToString(Module1.PNo);
                                        dialog10.txtJudgeNo.Text = Conversions.ToString(num5);
                                        int num6 = (int)dialog10.ShowDialog((IWin32Window)this);
                                        goto label_21;
                                    }
                                    else
                                    {
                                        int num7 = (int)Interaction.MsgBox((object)"Select a Judge cell!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                        goto label_21;
                                    }
                                default:
                                    int num8 = (int)Interaction.MsgBox((object)"Select a Judge cell or the Deduction cell!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                    goto label_21;
                            }
                        }
                        else
                            goto label_21;
                    }
                    else
                        goto label_21;
                }
                else
                    goto label_21;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num9 = (int)Interaction.MsgBox((object)("DataGridView1_CellMouseDownk - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_21:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }
    }
}

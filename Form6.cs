// Decompiled with JetBrains decompiler
// Type: ClubCompFS.Form6
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
    public class Form6 : Form
    {
        private IContainer components;
        [AccessedThroughProperty("DataGridView1")]
        private DataGridView _DataGridView1;
        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;
        [AccessedThroughProperty("SHOWRESULTSToolStripMenuItem")]
        private ToolStripMenuItem _SHOWRESULTSToolStripMenuItem;
        [AccessedThroughProperty("ShortProgramToolStripMenuItem")]
        private ToolStripMenuItem _ShortProgramToolStripMenuItem;
        [AccessedThroughProperty("FreeSkatingToolStripMenuItem")]
        private ToolStripMenuItem _FreeSkatingToolStripMenuItem;
        [AccessedThroughProperty("FinalResultToolStripMenuItem")]
        private ToolStripMenuItem _FinalResultToolStripMenuItem;
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
        [AccessedThroughProperty("CREATEFILESToolStripMenuItem")]
        private ToolStripMenuItem _CREATEFILESToolStripMenuItem;
        [AccessedThroughProperty("EXITToolStripMenuItem")]
        private ToolStripMenuItem _EXITToolStripMenuItem;
        [AccessedThroughProperty("PrintDocument1")]
        private PrintDocument _PrintDocument1;
        [AccessedThroughProperty("PrintPreviewDialog1")]
        private PrintPreviewDialog _PrintPreviewDialog1;
        [AccessedThroughProperty("PRINTToolStripMenuItem1")]
        private ToolStripMenuItem _PRINTToolStripMenuItem1;
        private object[,] TDA;
        private int F6Height;
        private int DGW1width;
        private bool widthcorr;
        public string printSeg;

        public Form6()
        {
            this.Load += new EventHandler(this.Form6_Load);
            this.SizeChanged += new EventHandler(this.Form6_SizeChanged);
            this.TDA = new object[51, 9];
            this.widthcorr = false;
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
            DataGridViewCellStyle gridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form6));
            this.DataGridView1 = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.Column8 = new DataGridViewTextBoxColumn();
            this.MenuStrip1 = new MenuStrip();
            this.EXITToolStripMenuItem = new ToolStripMenuItem();
            this.SHOWRESULTSToolStripMenuItem = new ToolStripMenuItem();
            this.ShortProgramToolStripMenuItem = new ToolStripMenuItem();
            this.FreeSkatingToolStripMenuItem = new ToolStripMenuItem();
            this.FinalResultToolStripMenuItem = new ToolStripMenuItem();
            this.CREATEFILESToolStripMenuItem = new ToolStripMenuItem();
            this.PRINTToolStripMenuItem1 = new ToolStripMenuItem();
            this.PrintDocument1 = new PrintDocument();
            this.PrintPreviewDialog1 = new PrintPreviewDialog();
            ((ISupportInitialize)this.DataGridView1).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange((DataGridViewColumn)this.Column1, (DataGridViewColumn)this.Column2, (DataGridViewColumn)this.Column3, (DataGridViewColumn)this.Column4, (DataGridViewColumn)this.Column5, (DataGridViewColumn)this.Column6, (DataGridViewColumn)this.Column7, (DataGridViewColumn)this.Column8);
            this.DataGridView1.Dock = DockStyle.Left;
            this.DataGridView1.Location = new Point(0, 24);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ScrollBars = ScrollBars.Vertical;
            DataGridView dataGridView1 = this.DataGridView1;
            Size size1 = new Size(875, 306);
            Size size2 = size1;
            dataGridView1.Size = size2;
            this.DataGridView1.TabIndex = 0;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = DataGridViewTriState.False;
            this.Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = DataGridViewTriState.False;
            this.Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = DataGridViewTriState.False;
            this.Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = gridViewCellStyle1;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = DataGridViewTriState.False;
            this.Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = gridViewCellStyle2;
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = DataGridViewTriState.False;
            this.Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column6.DefaultCellStyle = gridViewCellStyle3;
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = DataGridViewTriState.False;
            this.Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column7.DefaultCellStyle = gridViewCellStyle4;
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = DataGridViewTriState.False;
            this.Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Column8.DefaultCellStyle = gridViewCellStyle5;
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = DataGridViewTriState.False;
            this.Column8.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.MenuStrip1.BackColor = SystemColors.Control;
            this.MenuStrip1.Items.AddRange(new ToolStripItem[4]
            {
        (ToolStripItem) this.EXITToolStripMenuItem,
        (ToolStripItem) this.SHOWRESULTSToolStripMenuItem,
        (ToolStripItem) this.CREATEFILESToolStripMenuItem,
        (ToolStripItem) this.PRINTToolStripMenuItem1
            });
            this.MenuStrip1.Location = new Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new Padding(7, 2, 0, 2);
            MenuStrip menuStrip1 = this.MenuStrip1;
            size1 = new Size(883, 24);
            Size size3 = size1;
            menuStrip1.Size = size3;
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            this.EXITToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem1 = this.EXITToolStripMenuItem;
            size1 = new Size(44, 20);
            Size size4 = size1;
            toolStripMenuItem1.Size = size4;
            this.EXITToolStripMenuItem.Text = "EXIT";
            this.SHOWRESULTSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.ShortProgramToolStripMenuItem,
        (ToolStripItem) this.FreeSkatingToolStripMenuItem,
        (ToolStripItem) this.FinalResultToolStripMenuItem
            });
            this.SHOWRESULTSToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.SHOWRESULTSToolStripMenuItem.Name = "SHOWRESULTSToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem2 = this.SHOWRESULTSToolStripMenuItem;
            size1 = new Size(105, 20);
            Size size5 = size1;
            toolStripMenuItem2.Size = size5;
            this.SHOWRESULTSToolStripMenuItem.Text = "SHOW RESULTS";
            this.ShortProgramToolStripMenuItem.Name = "ShortProgramToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem3 = this.ShortProgramToolStripMenuItem;
            size1 = new Size(139, 22);
            Size size6 = size1;
            toolStripMenuItem3.Size = size6;
            this.ShortProgramToolStripMenuItem.Text = "Segment 1";
            this.FreeSkatingToolStripMenuItem.Name = "FreeSkatingToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem4 = this.FreeSkatingToolStripMenuItem;
            size1 = new Size(139, 22);
            Size size7 = size1;
            toolStripMenuItem4.Size = size7;
            this.FreeSkatingToolStripMenuItem.Text = "Segment 2";
            this.FinalResultToolStripMenuItem.Name = "FinalResultToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem5 = this.FinalResultToolStripMenuItem;
            size1 = new Size(139, 22);
            Size size8 = size1;
            toolStripMenuItem5.Size = size8;
            this.FinalResultToolStripMenuItem.Text = "Final Result";
            this.CREATEFILESToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.CREATEFILESToolStripMenuItem.Name = "CREATEFILESToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem6 = this.CREATEFILESToolStripMenuItem;
            size1 = new Size(120, 20);
            Size size9 = size1;
            toolStripMenuItem6.Size = size9;
            this.CREATEFILESToolStripMenuItem.Text = "CREATE PDF-FILES";
            this.PRINTToolStripMenuItem1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.PRINTToolStripMenuItem1.Name = "PRINTToolStripMenuItem1";
            ToolStripMenuItem toolStripMenuItem1_1 = this.PRINTToolStripMenuItem1;
            size1 = new Size(53, 20);
            Size size10 = size1;
            toolStripMenuItem1_1.Size = size10;
            this.PRINTToolStripMenuItem1.Text = "PRINT";
            PrintPreviewDialog printPreviewDialog1_1 = this.PrintPreviewDialog1;
            size1 = new Size(0, 0);
            Size size11 = size1;
            printPreviewDialog1_1.AutoScrollMargin = size11;
            PrintPreviewDialog printPreviewDialog1_2 = this.PrintPreviewDialog1;
            size1 = new Size(0, 0);
            Size size12 = size1;
            printPreviewDialog1_2.AutoScrollMinSize = size12;
            PrintPreviewDialog printPreviewDialog1_3 = this.PrintPreviewDialog1;
            size1 = new Size(400, 300);
            Size size13 = size1;
            printPreviewDialog1_3.ClientSize = size13;
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = (Icon)componentResourceManager.GetObject("PrintPreviewDialog1.Icon");
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            this.AutoScaleDimensions = new SizeF(7f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(883, 330);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.DataGridView1);
            this.Controls.Add((Control)this.MenuStrip1);
            this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.Name = nameof(Form6);
            this.Text = "RESULTS";
            this.TopMost = true;
            ((ISupportInitialize)this.DataGridView1).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual DataGridView DataGridView1
        {
            get => this._DataGridView1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._DataGridView1 = value;
        }

        internal virtual MenuStrip MenuStrip1
        {
            get => this._MenuStrip1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._MenuStrip1 = value;
        }

        internal virtual ToolStripMenuItem SHOWRESULTSToolStripMenuItem
        {
            get => this._SHOWRESULTSToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._SHOWRESULTSToolStripMenuItem = value;
        }

        internal virtual ToolStripMenuItem ShortProgramToolStripMenuItem
        {
            get => this._ShortProgramToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ShortProgramToolStripMenuItem_Click);
                if (this._ShortProgramToolStripMenuItem != null)
                    this._ShortProgramToolStripMenuItem.Click -= eventHandler;
                this._ShortProgramToolStripMenuItem = value;
                if (this._ShortProgramToolStripMenuItem == null)
                    return;
                this._ShortProgramToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem FreeSkatingToolStripMenuItem
        {
            get => this._FreeSkatingToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.FreeSkatingToolStripMenuItem_Click);
                if (this._FreeSkatingToolStripMenuItem != null)
                    this._FreeSkatingToolStripMenuItem.Click -= eventHandler;
                this._FreeSkatingToolStripMenuItem = value;
                if (this._FreeSkatingToolStripMenuItem == null)
                    return;
                this._FreeSkatingToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem FinalResultToolStripMenuItem
        {
            get => this._FinalResultToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.FinalResultToolStripMenuItem_Click);
                if (this._FinalResultToolStripMenuItem != null)
                    this._FinalResultToolStripMenuItem.Click -= eventHandler;
                this._FinalResultToolStripMenuItem = value;
                if (this._FinalResultToolStripMenuItem == null)
                    return;
                this._FinalResultToolStripMenuItem.Click += eventHandler;
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

        internal virtual ToolStripMenuItem CREATEFILESToolStripMenuItem
        {
            get => this._CREATEFILESToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.CREATEFILESToolStripMenuItem_Click);
                if (this._CREATEFILESToolStripMenuItem != null)
                    this._CREATEFILESToolStripMenuItem.Click -= eventHandler;
                this._CREATEFILESToolStripMenuItem = value;
                if (this._CREATEFILESToolStripMenuItem == null)
                    return;
                this._CREATEFILESToolStripMenuItem.Click += eventHandler;
            }
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

        internal virtual PrintDocument PrintDocument1
        {
            get => this._PrintDocument1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                PrintPageEventHandler pageEventHandler = new PrintPageEventHandler(this.PrintDocument1_PrintPage);
                if (this._PrintDocument1 != null)
                    this._PrintDocument1.PrintPage -= pageEventHandler;
                this._PrintDocument1 = value;
                if (this._PrintDocument1 == null)
                    return;
                this._PrintDocument1.PrintPage += pageEventHandler;
            }
        }

        internal virtual PrintPreviewDialog PrintPreviewDialog1
        {
            get => this._PrintPreviewDialog1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PrintPreviewDialog1 = value;
        }

        internal virtual ToolStripMenuItem PRINTToolStripMenuItem1
        {
            get => this._PRINTToolStripMenuItem1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.PRINTToolStripMenuItem1_Click);
                if (this._PRINTToolStripMenuItem1 != null)
                    this._PRINTToolStripMenuItem1.Click -= eventHandler;
                this._PRINTToolStripMenuItem1 = value;
                if (this._PRINTToolStripMenuItem1 == null)
                    return;
                this._PRINTToolStripMenuItem1.Click += eventHandler;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Top = MyProject.Forms.Form1.Top;
            this.Left = MyProject.Forms.Form1.Left;
            this.TopMost = true;
            this.printSeg = Module1.Segment;
            string seg = Module1.GetSeg();
            if (Operators.CompareString(seg, "FF", false) == 0 || Operators.CompareString(seg, "SS", false) == 0 || Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "FS", false) == 0)
            {
                this.ShortProgramToolStripMenuItem.Visible = true;
                this.ShortProgramToolStripMenuItem.Text = Module1.GetSegTxt("Seg1");
                this.FreeSkatingToolStripMenuItem.Visible = true;
                this.FreeSkatingToolStripMenuItem.Text = Module1.GetSegTxt("Seg2");
                this.FinalResultToolStripMenuItem.Visible = true;
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    this.CreateSeg1Result(Module1.GetSegTxt("Seg1"));
                }
                else
                {
                    if (Operators.CompareString(segment, "Seg2", false) != 0)
                        return;
                    this.CreateSeg2Result(Module1.GetSegTxt("Seg2"));
                }
            }
            else if (Operators.CompareString(seg, "0S", false) == 0 || Operators.CompareString(seg, "0F", false) == 0)
            {
                this.ShortProgramToolStripMenuItem.Visible = false;
                this.FreeSkatingToolStripMenuItem.Visible = true;
                this.FreeSkatingToolStripMenuItem.Text = Module1.GetSegTxt("Seg2");
                this.FinalResultToolStripMenuItem.Visible = false;
                this.CreateSeg2Result(Module1.GetSegTxt("Seg2"));
            }
            else
            {
                if (Operators.CompareString(seg, "S0", false) != 0 && Operators.CompareString(seg, "F0", false) != 0)
                    return;
                this.ShortProgramToolStripMenuItem.Visible = true;
                this.ShortProgramToolStripMenuItem.Text = Module1.GetSegTxt("Seg1");
                this.FreeSkatingToolStripMenuItem.Visible = false;
                this.FinalResultToolStripMenuItem.Visible = false;
                this.CreateSeg1Result(Module1.GetSegTxt("Seg1"));
            }
        }

        public void CreateSeg1Result(string txt)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 0;
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                if (Module1.Bonus_Sel("Seg1"))
                    this.Width = checked(950 + Module1.WC);
                else
                    this.Width = checked(870 + Module1.WC);
                this.Text = "RESULT, " + txt;
                if (Module1.TNop > 0 & Module1.TNop <= 42)
                {
                    Module1.SortListSeg1(Module1.TNop);
                    Module1.Seg1Pl(checked(Module1.TNop - Module1.DNS_Seg1));
                    dataGridView1.ReadOnly = Module1.WorkMode > 1;
                    dataGridView1.Rows.Clear();
                    dataGridView1.ColumnHeadersVisible = true;
                    dataGridView1.RowHeadersVisible = false;
                    int index1 = 1;
                    do
                    {
                        if (Module1.Vek[index1].Startno_Seg1 == 0 & Module1.Vek[index1].DNS_Seg1 > 0)
                            checked { ++num3; }
                        checked { ++index1; }
                    }
                    while (index1 <= 42);
                    dataGridView1.RowCount = checked(Module1.TNop - num3);
                    if (Module1.Bonus_Sel("Seg1"))
                    {
                        dataGridView1.ColumnCount = 8;
                        dataGridView1.Width = 950;
                        dataGridView1.Columns[7].HeaderText = "Bonus";
                        dataGridView1.Columns[7].Width = 80;
                        dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    else
                    {
                        dataGridView1.ColumnCount = 7;
                        dataGridView1.Width = 870;
                    }
                    this.DGW1width = dataGridView1.Width;
                    dataGridView1.Columns[0].HeaderText = "Place";
                    dataGridView1.Columns[1].HeaderText = "Name";
                    dataGridView1.Columns[2].HeaderText = "Club";
                    dataGridView1.Columns[3].HeaderText = "TSS";
                    dataGridView1.Columns[4].HeaderText = "TES";
                    dataGridView1.Columns[5].HeaderText = "PCS";
                    dataGridView1.Columns[6].HeaderText = "Deduction";
                    dataGridView1.Columns[0].Width = 50;
                    dataGridView1.Columns[1].Width = 250;
                    dataGridView1.Columns[2].Width = 250;
                    dataGridView1.Columns[3].Width = 80;
                    dataGridView1.Columns[4].Width = 80;
                    dataGridView1.Columns[5].Width = 80;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    int index2 = 0;
                    int tnop = Module1.TNop;
                    int Pno = 1;
                    while (Pno <= tnop)
                    {
                        if (!(Module1.Vek[Pno].Startno_Seg1 == 0 & Module1.Vek[Pno].DNS_Seg1 > 0))
                        {
                            dataGridView1.Rows[index2].Cells[0].Value = (object)Module1.Vek[Pno].Place_Seg1;
                            dataGridView1.Rows[index2].Cells[1].Value = (object)(Module1.Vek[Pno].Name.FName + " " + Module1.Vek[Pno].Name.LName);
                            dataGridView1.Rows[index2].Cells[2].Value = (object)Module1.Vek[Pno].Club;
                            switch (Module1.Vek[Pno].DNS_Seg1)
                            {
                                case 0:
                                    dataGridView1.Rows[index2].Cells[3].Value = (object)Strings.Format((object)Module1.Vek[Pno].Score_Seg1, "0.00");
                                    dataGridView1.Rows[index2].Cells[4].Value = (object)Strings.Format((object)Module1.Vek[Pno].TES_Seg1, "0.00");
                                    dataGridView1.Rows[index2].Cells[5].Value = (object)Strings.Format((object)Module1.Vek[Pno].PCS_Seg1, "0.00");
                                    dataGridView1.Rows[index2].Cells[6].Value = (object)Module1.DedSeg1Seg2(Pno, "Seg1");
                                    if (Module1.Bonus_Sel("Seg1"))
                                    {
                                        dataGridView1.Rows[checked(Pno - 1)].Cells[7].Value = (object)Module1.Vek[Pno].Bonus_Seg1;
                                        break;
                                    }
                                    break;
                                case 1:
                                    dataGridView1.Rows[index2].Cells[3].Value = (object)"DNS";
                                    break;
                                case 2:
                                    dataGridView1.Rows[index2].Cells[3].Value = (object)"WD";
                                    break;
                                case 3:
                                    dataGridView1.Rows[index2].Cells[3].Value = (object)"DNF";
                                    break;
                                case 4:
                                    dataGridView1.Rows[index2].Cells[3].Value = (object)"DQ";
                                    break;
                            }
                            checked { ++index2; }
                        }
                        checked { ++Pno; }
                    }
                    this.F6Height = checked(dataGridView1.RowCount * 22 + dataGridView1.ColumnHeadersHeight + dataGridView1.Location.Y + Module1.HC);
                    if (this.F6Height < checked(Screen.PrimaryScreen.WorkingArea.Height - 50))
                    {
                        this.Height = this.F6Height;
                        this.DataGridView1.Width = this.DGW1width;
                        this.Width = checked(this.DGW1width + Module1.WC);
                    }
                    else
                    {
                        this.Height = checked(Screen.PrimaryScreen.WorkingArea.Height - 50);
                        this.DataGridView1.Width = checked(this.DGW1width + Module1.WC1);
                        this.Width = checked(this.DGW1width + Module1.WC2);
                    }
                    this.widthcorr = true;
                    goto label_33;
                }
                else
                    goto label_33;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("Form6, CreateSeg1Result - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_33:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void CreateSeg2Result(string txt)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                if (Module1.Bonus_Sel("Seg2"))
                    this.Width = checked(950 + Module1.WC);
                else
                    this.Width = checked(870 + Module1.WC);
                this.Text = "RESULT, " + txt;
                if (Module1.TNop > 0 & Module1.TNop <= 42)
                {
                    Module1.SortListSeg2(Module1.TNop);
                    Module1.Seg2Pl(checked(Module1.TNop - Module1.DNS_Seg1 - Module1.DNS_Seg2));
                    int num3 = 0;
                    string seg1 = Module1.GetSeg();
                    if (Operators.CompareString(seg1, "0F", false) == 0)
                    {
                        int index = 1;
                        do
                        {
                            if (Module1.Vek[index].Startno_Seg2 == 0 & Module1.Vek[index].DNS_Seg2 > 0)
                                checked { ++num3; }
                            checked { ++index; }
                        }
                        while (index <= 42);
                    }
                    else if (Operators.CompareString(seg1, "SF", false) == 0 || Operators.CompareString(seg1, "FF", false) == 0 || Operators.CompareString(seg1, "SS", false) == 0)
                    {
                        int tnop = Module1.TNop;
                        int index = 1;
                        while (index <= tnop)
                        {
                            if (Module1.Vek[index].DNS_Seg1 > 0)
                                checked { ++num3; }
                            checked { ++index; }
                        }
                    }
                    dataGridView1.ReadOnly = Module1.WorkMode > 1;
                    dataGridView1.Rows.Clear();
                    dataGridView1.ColumnHeadersVisible = true;
                    dataGridView1.RowHeadersVisible = false;
                    if (Module1.Bonus_Sel("Seg2"))
                    {
                        dataGridView1.Width = 950;
                        dataGridView1.ColumnCount = 8;
                        dataGridView1.Columns[7].HeaderText = "Bonus";
                        dataGridView1.Columns[7].Width = 80;
                        dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    else
                    {
                        dataGridView1.Width = 870;
                        dataGridView1.ColumnCount = 7;
                    }
                    this.DGW1width = dataGridView1.Width;
                    dataGridView1.RowCount = num3 <= 0 ? Module1.TNop : checked(Module1.TNop - num3);
                    dataGridView1.Columns[0].HeaderText = "Place";
                    dataGridView1.Columns[1].HeaderText = "Name";
                    dataGridView1.Columns[2].HeaderText = "Club";
                    dataGridView1.Columns[3].HeaderText = "TSS";
                    dataGridView1.Columns[4].HeaderText = "TES";
                    dataGridView1.Columns[5].HeaderText = "PCS";
                    dataGridView1.Columns[6].HeaderText = "Deduction";
                    dataGridView1.Columns[0].Width = 50;
                    dataGridView1.Columns[1].Width = 250;
                    dataGridView1.Columns[2].Width = 250;
                    dataGridView1.Columns[3].Width = 80;
                    dataGridView1.Columns[4].Width = 80;
                    dataGridView1.Columns[5].Width = 80;
                    dataGridView1.Columns[6].Width = 80;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    int index1 = 0;
                    string seg2 = Module1.GetSeg();
                    if (Operators.CompareString(seg2, "0F", false) == 0)
                    {
                        int tnop = Module1.TNop;
                        int Pno = 1;
                        while (Pno <= tnop)
                        {
                            if (!(Module1.Vek[Pno].Startno_Seg2 == 0 & Module1.Vek[Pno].DNS_Seg2 > 0))
                            {
                                dataGridView1.Rows[index1].Cells[0].Value = (object)Module1.Vek[Pno].Place_Seg2;
                                dataGridView1.Rows[index1].Cells[1].Value = (object)(Module1.Vek[Pno].Name.FName + " " + Module1.Vek[Pno].Name.LName);
                                dataGridView1.Rows[index1].Cells[2].Value = (object)Module1.Vek[Pno].Club;
                                switch (Module1.Vek[Pno].DNS_Seg2)
                                {
                                    case 0:
                                        dataGridView1.Rows[index1].Cells[3].Value = (object)Strings.Format((object)Module1.Vek[Pno].Score_Seg2, "0.00");
                                        dataGridView1.Rows[index1].Cells[4].Value = (object)Strings.Format((object)Module1.Vek[Pno].TES_Seg2, "0.00");
                                        dataGridView1.Rows[index1].Cells[5].Value = (object)Strings.Format((object)Module1.Vek[Pno].PCS_Seg2, "0.00");
                                        dataGridView1.Rows[index1].Cells[6].Value = (object)Module1.DedSeg1Seg2(Pno, "Seg2");
                                        if (Module1.Bonus_Sel("Seg2"))
                                        {
                                            dataGridView1.Rows[checked(Pno - 1)].Cells[7].Value = (object)Module1.Vek[Pno].Bonus_Seg2;
                                            break;
                                        }
                                        break;
                                    case 1:
                                        dataGridView1.Rows[index1].Cells[3].Value = (object)"DNS";
                                        break;
                                    case 2:
                                        dataGridView1.Rows[index1].Cells[3].Value = (object)"WD";
                                        break;
                                    case 3:
                                        dataGridView1.Rows[index1].Cells[3].Value = (object)"DNF";
                                        break;
                                    case 4:
                                        dataGridView1.Rows[index1].Cells[3].Value = (object)"DQ";
                                        break;
                                }
                                checked { ++index1; }
                            }
                            checked { ++Pno; }
                        }
                    }
                    else if (Operators.CompareString(seg2, "SF", false) == 0 || Operators.CompareString(seg2, "FF", false) == 0 || Operators.CompareString(seg2, "SS", false) == 0)
                    {
                        int tnop = Module1.TNop;
                        int Pno = 1;
                        while (Pno <= tnop)
                        {
                            if (Module1.Vek[Pno].DNS_Seg1 == 0)
                            {
                                dataGridView1.Rows[index1].Cells[0].Value = (object)Module1.Vek[Pno].Place_Seg2;
                                dataGridView1.Rows[index1].Cells[1].Value = (object)(Module1.Vek[Pno].Name.FName + " " + Module1.Vek[Pno].Name.LName);
                                dataGridView1.Rows[index1].Cells[2].Value = (object)Module1.Vek[Pno].Club;
                                switch (Module1.Vek[Pno].DNS_Seg1)
                                {
                                    case 0:
                                        switch (Module1.Vek[Pno].DNS_Seg2)
                                        {
                                            case 0:
                                                dataGridView1.Rows[index1].Cells[3].Value = (object)Strings.Format((object)Module1.Vek[Pno].Score_Seg2, "0.00");
                                                dataGridView1.Rows[index1].Cells[4].Value = (object)Strings.Format((object)Module1.Vek[Pno].TES_Seg2, "0.00");
                                                dataGridView1.Rows[index1].Cells[5].Value = (object)Strings.Format((object)Module1.Vek[Pno].PCS_Seg2, "0.00");
                                                dataGridView1.Rows[index1].Cells[6].Value = (object)Module1.DedSeg1Seg2(Pno, "Seg2");
                                                if (Module1.Bonus_Sel("Seg2"))
                                                {
                                                    dataGridView1.Rows[checked(Pno - 1)].Cells[7].Value = (object)Module1.Vek[Pno].Bonus_Seg2;
                                                    break;
                                                }
                                                break;
                                            case 1:
                                                dataGridView1.Rows[index1].Cells[3].Value = (object)"DNS";
                                                break;
                                            case 2:
                                                dataGridView1.Rows[index1].Cells[3].Value = (object)"WD";
                                                break;
                                            case 3:
                                                dataGridView1.Rows[index1].Cells[3].Value = (object)"DNF";
                                                break;
                                            case 4:
                                                dataGridView1.Rows[index1].Cells[3].Value = (object)"DQ";
                                                break;
                                        }
                                        break;
                                    case 1:
                                        dataGridView1.Rows[index1].Cells[3].Value = (object)"DNS";
                                        break;
                                    case 2:
                                        dataGridView1.Rows[index1].Cells[3].Value = (object)"WD";
                                        break;
                                    case 3:
                                        dataGridView1.Rows[index1].Cells[3].Value = (object)"DNF";
                                        break;
                                    case 4:
                                        dataGridView1.Rows[index1].Cells[3].Value = (object)"DQ";
                                        break;
                                }
                                checked { ++index1; }
                            }
                            checked { ++Pno; }
                        }
                    }
                    this.F6Height = checked(dataGridView1.RowCount * 22 + dataGridView1.ColumnHeadersHeight + dataGridView1.Location.Y + Module1.HC);
                    if (this.F6Height < checked(Screen.PrimaryScreen.WorkingArea.Height - 50))
                    {
                        this.Height = this.F6Height;
                        this.DataGridView1.Width = this.DGW1width;
                        this.Width = checked(this.DGW1width + Module1.WC);
                    }
                    else
                    {
                        this.Height = checked(Screen.PrimaryScreen.WorkingArea.Height - 50);
                        this.DataGridView1.Width = checked(this.DGW1width + Module1.WC1);
                        this.Width = checked(this.DGW1width + Module1.WC2);
                    }
                    this.widthcorr = true;
                    goto label_59;
                }
                else
                    goto label_59;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("Form6, CreateSeg2Result - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_59:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Form6_SizeChanged(object sender, EventArgs e)
        {
            if (!this.widthcorr)
                return;
            if (this.Height < this.F6Height)
            {
                this.DataGridView1.Width = checked(this.DGW1width + Module1.WC1);
                this.Width = checked(this.DGW1width + Module1.WC2);
            }
            else
            {
                this.DataGridView1.Width = this.DGW1width;
                this.Width = checked(this.DGW1width + Module1.WC);
            }
        }

        public void CreateFinalResult()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                this.Width = checked(790 + Module1.WC);
                this.Text = "RESULT, Final Result";
                if (Operators.CompareString(Module1.GetSeg(), "SF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "FF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "SS", false) == 0)
                {
                    if (Module1.TNop > 0 & Module1.TNop <= 42)
                    {
                        Module1.SortListSeg1(Module1.TNop);
                        Module1.Seg1Pl(checked(Module1.TNop - Module1.DNS_Seg1));
                        Module1.SortListSeg2(Module1.TNop);
                        Module1.Seg2Pl(checked(Module1.TNop - Module1.DNS_Seg1 - Module1.DNS_Seg2));
                        Module1.SumScore(Module1.TNop);
                        Module1.SortListTotal(Module1.TNop);
                        Module1.TotalPl(checked(Module1.TNop - Module1.DNS_Seg1 - Module1.DNS_Seg2));
                        int num3 = 0;
                        int tnop1 = Module1.TNop;
                        int index1 = 1;
                        while (index1 <= tnop1)
                        {
                            if (Module1.Vek[index1].DNS_Seg1 == 0 & Module1.Vek[index1].Finished_Seg1 == 1)
                            {
                                if (Module1.Vek[index1].Finished_Seg2 == 1 & Module1.Vek[index1].DNS_Seg2 == 0)
                                    checked { ++num3; }
                                else if (Module1.Vek[index1].DNS_Seg2 > 0)
                                    checked { ++num3; }
                            }
                            checked { ++index1; }
                        }
                        dataGridView1.ReadOnly = Module1.WorkMode > 1;
                        dataGridView1.Rows.Clear();
                        dataGridView1.ColumnHeadersVisible = true;
                        dataGridView1.RowHeadersVisible = false;
                        dataGridView1.ColumnCount = 6;
                        dataGridView1.RowCount = num3 <= 0 ? 1 : num3;
                        dataGridView1.Columns[0].HeaderText = "Place";
                        dataGridView1.Columns[1].HeaderText = "Name";
                        dataGridView1.Columns[2].HeaderText = "Club";
                        dataGridView1.Columns[3].HeaderText = "Total Score";
                        dataGridView1.Columns[4].HeaderText = "Place Segment 1";
                        dataGridView1.Columns[5].HeaderText = "Place Segment 2";
                        dataGridView1.Width = 790;
                        this.DGW1width = dataGridView1.Width;
                        dataGridView1.Columns[0].Width = 50;
                        dataGridView1.Columns[1].Width = 250;
                        dataGridView1.Columns[2].Width = 250;
                        dataGridView1.Columns[3].Width = 80;
                        dataGridView1.Columns[4].Width = 80;
                        dataGridView1.Columns[5].Width = 80;
                        dataGridView1.RowHeadersVisible = false;
                        dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        int index2 = 0;
                        int tnop2 = Module1.TNop;
                        int index3 = 1;
                        while (index3 <= tnop2)
                        {
                            if (Module1.Vek[index3].DNS_Seg1 == 0 & Module1.Vek[index3].Finished_Seg1 == 1)
                            {
                                if (Module1.Vek[index3].Finished_Seg2 == 1 & Module1.Vek[index3].DNS_Seg2 == 0)
                                {
                                    dataGridView1.Rows[index2].Cells[0].Value = (object)Module1.Vek[index3].Place;
                                    dataGridView1.Rows[index2].Cells[1].Value = (object)(Module1.Vek[index3].Name.FName + " " + Module1.Vek[index3].Name.LName);
                                    dataGridView1.Rows[index2].Cells[2].Value = (object)Module1.Vek[index3].Club;
                                    dataGridView1.Rows[index2].Cells[3].Value = (object)Strings.Format((object)Module1.Vek[index3].Score_Total, "0.00");
                                    dataGridView1.Rows[index2].Cells[4].Value = (object)Module1.Vek[index3].Place_Seg1;
                                    dataGridView1.Rows[index2].Cells[5].Value = (object)Module1.Vek[index3].Place_Seg2;
                                    checked { ++index2; }
                                }
                                else if (Module1.Vek[index3].DNS_Seg2 > 0)
                                {
                                    dataGridView1.Rows[index2].Cells[0].Value = (object)Module1.Vek[index3].Place;
                                    dataGridView1.Rows[index2].Cells[1].Value = (object)(Module1.Vek[index3].Name.FName + " " + Module1.Vek[index3].Name.LName);
                                    dataGridView1.Rows[index2].Cells[2].Value = (object)Module1.Vek[index3].Club;
                                    dataGridView1.Rows[index2].Cells[4].Value = (object)Module1.Vek[index3].Place_Seg1;
                                    switch (Module1.Vek[index3].DNS_Seg2)
                                    {
                                        case 1:
                                            dataGridView1.Rows[index2].Cells[3].Value = (object)"DNS";
                                            dataGridView1.Rows[index2].Cells[5].Value = (object)"DNS";
                                            break;
                                        case 2:
                                            dataGridView1.Rows[index2].Cells[3].Value = (object)"WD";
                                            dataGridView1.Rows[index2].Cells[5].Value = (object)"WD";
                                            break;
                                        case 3:
                                            dataGridView1.Rows[index2].Cells[3].Value = (object)"DNF";
                                            dataGridView1.Rows[index2].Cells[5].Value = (object)"DNF";
                                            break;
                                        case 4:
                                            dataGridView1.Rows[index2].Cells[3].Value = (object)"DQ";
                                            dataGridView1.Rows[index2].Cells[5].Value = (object)"DQ";
                                            break;
                                    }
                                    checked { ++index2; }
                                }
                            }
                            checked { ++index3; }
                        }
                        this.F6Height = checked(dataGridView1.RowCount * 22 + dataGridView1.ColumnHeadersHeight + dataGridView1.Location.Y + Module1.HC);
                        if (this.F6Height < checked(Screen.PrimaryScreen.WorkingArea.Height - 50))
                        {
                            this.Height = this.F6Height;
                            this.DataGridView1.Width = this.DGW1width;
                            this.Width = checked(this.DGW1width + Module1.WC);
                        }
                        else
                        {
                            this.Height = checked(Screen.PrimaryScreen.WorkingArea.Height - 50);
                            this.DataGridView1.Width = checked(this.DGW1width + Module1.WC1);
                            this.Width = checked(this.DGW1width + Module1.WC2);
                        }
                        this.widthcorr = true;
                        goto label_33;
                    }
                    else
                        goto label_33;
                }
                else
                    goto label_33;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("Form6, CreateFinalResult - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_33:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void ShortProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.printSeg = "Seg1";
            this.widthcorr = false;
            this.CreateSeg1Result(Module1.GetSegTxt("Seg1"));
        }

        private void FreeSkatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.printSeg = "Seg2";
            this.widthcorr = false;
            this.CreateSeg2Result(Module1.GetSegTxt("Seg2"));
        }

        private void FinalResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.widthcorr = false;
            this.printSeg = "Final";
            this.CreateFinalResult();
        }

        private void ExportDataToPDFTable1(
          int norow,
          int nocol,
          string txt,
          string pathfile,
          int msg)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string str1 = "";
                float[] numArray = new float[3] { 33f, 33f, 33f };
                int num3 = 20;
                int num4 = 20;
                int Length = 34;
                ProjectData.ClearProjectError();
                num1 = 2;
                string segment1 = Module1.Segment;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                    str1 = Module1.FormShortDate(Module1.Datum.Seg1);
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                    str1 = Module1.FormShortDate(Module1.Datum.Seg2);
                PdfDocument pdfDocument = new PdfDocument();
                pdfDocument.Info.Title = "RESULTS";
                pdfDocument.Info.Subject = Module1.Category.Name + Module1.SubCat() + ", " + txt;
                pdfDocument.Info.Author = "ClubCompFS Single ver. 10.0.6, 2019-01-12";
                PdfPage page = pdfDocument.AddPage();
                page.Size = PageSize.A4;
                int width1 = checked((int)Math.Round(unchecked(page.Width.Point - (double)num3 - (double)num4)));
                int num5 = checked((int)Math.Round(page.Height.Point));
                XFont font1 = new XFont("ARIAL", 12.0, XFontStyle.Bold);
                XFont font2 = new XFont("ARIAL", 10.0, XFontStyle.Bold);
                XFont xfont1 = new XFont("ARIAL", 10.0, XFontStyle.Regular);
                XFont xfont2 = new XFont("ARIAL", 6.0, XFontStyle.Regular);
                XGraphics xgraphics1 = XGraphics.FromPdfPage(page);
                XImage image = XImage.FromFile("IE_Logo_HD.png");
                XImage image2 = XImage.FromFile("FSI_Logo_HD.png");
                XRect rect = new XRect(10.0, 10.0, image.PointWidth, image.PointHeight);
                XRect rect2 = new XRect(480.0, 10.0, 100, 80);
                xgraphics1.DrawImage(image, rect);
                xgraphics1.DrawImage(image2, rect2);
                int y1 = 110;
                int height1 = checked((int)Math.Round(font1.GetHeight()));
                xgraphics1.DrawString("RESULTS", font1, (XBrush)XBrushes.Black, new XRect((double)num3, (double)y1, (double)width1, (double)height1), XStringFormats.TopLeft);
                int y2 = checked(y1 + height1 + 5);
                int height2 = checked((int)Math.Round(font2.GetHeight()));
                XGraphics xgraphics2 = xgraphics1;
                string str2 = "COMPETITION: " + Module1.Competition.Name;
                XFont xfont3 = font2;
                XSolidBrush black1 = XBrushes.Black;
                XRect xrect1 = new XRect((double)num3, (double)y2, (double)width1, (double)height2);
                XStringFormat topLeft1 = XStringFormats.TopLeft;
                string text1 = str2;
                XFont font3 = xfont3;
                XSolidBrush brush1 = black1;
                XRect layoutRectangle1 = xrect1;
                XStringFormat format1 = topLeft1;
                xgraphics2.DrawString(text1, font3, (XBrush)brush1, layoutRectangle1, format1);
                int y3 = checked(y2 + height2);
                xgraphics1.DrawString("CATEGORY: " + Module1.Category.Name + Module1.SubCat() + ", " + txt, font2, (XBrush)XBrushes.Black, new XRect((double)num3, (double)y3, (double)width1, (double)height2), XStringFormats.TopLeft);
                int y4 = checked(y3 + height2);
                XGraphics xgraphics3 = xgraphics1;
                string str3 = "DATE: " + str1;
                XFont xfont4 = font2;
                XSolidBrush black2 = XBrushes.Black;
                XRect xrect2 = new XRect((double)num3, (double)y4, (double)width1, (double)height2);
                XStringFormat topLeft2 = XStringFormats.TopLeft;
                string text2 = str3;
                XFont font4 = xfont4;
                XSolidBrush brush2 = black2;
                XRect layoutRectangle2 = xrect2;
                XStringFormat format2 = topLeft2;
                xgraphics3.DrawString(text2, font4, (XBrush)brush2, layoutRectangle2, format2);
                int num6 = checked(y4 + 2 * height2);
                switch (nocol)
                {
                    case 6:
                        Length = 29;
                        numArray = new float[6]
                        {
              7f,
              30f,
              27f,
              12f,
              12f,
              12f
                        };
                        break;
                    case 7:
                        Length = 28;
                        numArray = new float[7]
                        {
              7f,
              30f,
              30f,
              8f,
              8f,
              8f,
              9f
                        };
                        break;
                    case 8:
                        Length = 26;
                        numArray = new float[8]
                        {
              7f,
              26f,
              26f,
              7f,
              7f,
              7f,
              10f,
              10f
                        };
                        break;
                }
                int num7 = norow;
                int index1 = 0;
                while (index1 <= num7)
                {
                    XFont xfont5 = index1 != 0 ? xfont1 : font2;
                    int num8 = num3;
                    if (index1 == 0)
                        xgraphics1.DrawLine(XPens.Gray, num3, num6, checked(num3 + width1), num6);
                    int y5 = checked(num6 + 1);
                    int num9 = checked(nocol - 1);
                    int index2 = 0;
                    while (index2 <= num9)
                    {
                        int width2 = checked((int)Math.Round(unchecked((double)numArray[index2] * (double)width1 / 100.0)));
                        string str4 = Strings.Left(Strings.Len(RuntimeHelpers.GetObjectValue(this.TDA[index1, index2])) <= 0 ? " " : Conversions.ToString(this.TDA[index1, index2]), Length);
                        switch (index2)
                        {
                            case 0:
                                if (index1 == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(y5 - 1), num8, checked(y5 + height2 + 1));
                                XGraphics xgraphics4 = xgraphics1;
                                string str5 = str4;
                                XFont xfont6 = xfont5;
                                XSolidBrush black3 = XBrushes.Black;
                                XRect xrect3 = new XRect((double)checked(num8 + 1), (double)y5, (double)width2, (double)height2);
                                XStringFormat center1 = XStringFormats.Center;
                                string text3 = str5;
                                XFont font5 = xfont6;
                                XSolidBrush brush3 = black3;
                                XRect layoutRectangle3 = xrect3;
                                XStringFormat format3 = center1;
                                xgraphics4.DrawString(text3, font5, (XBrush)brush3, layoutRectangle3, format3);
                                break;
                            case 1:
                                if (index1 == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(y5 - 1), num8, checked(y5 + height2 + 1));
                                XGraphics xgraphics5 = xgraphics1;
                                string str6 = str4;
                                XFont xfont7 = xfont5;
                                XSolidBrush black4 = XBrushes.Black;
                                XRect xrect4 = new XRect((double)checked(num8 + 1), (double)y5, (double)width2, (double)height2);
                                XStringFormat topLeft3 = XStringFormats.TopLeft;
                                string text4 = str6;
                                XFont font6 = xfont7;
                                XSolidBrush brush4 = black4;
                                XRect layoutRectangle4 = xrect4;
                                XStringFormat format4 = topLeft3;
                                xgraphics5.DrawString(text4, font6, (XBrush)brush4, layoutRectangle4, format4);
                                break;
                            case 2:
                                if (index1 == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(y5 - 1), num8, checked(y5 + height2 + 1));
                                XGraphics xgraphics6 = xgraphics1;
                                string str7 = str4;
                                XFont xfont8 = xfont5;
                                XSolidBrush black5 = XBrushes.Black;
                                XRect xrect5 = new XRect((double)checked(num8 + 1), (double)y5, (double)width2, (double)height2);
                                XStringFormat topLeft4 = XStringFormats.TopLeft;
                                string text5 = str7;
                                XFont font7 = xfont8;
                                XSolidBrush brush5 = black5;
                                XRect layoutRectangle5 = xrect5;
                                XStringFormat format5 = topLeft4;
                                xgraphics6.DrawString(text5, font7, (XBrush)brush5, layoutRectangle5, format5);
                                break;
                            case 3:
                                if (index1 == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(y5 - 1), num8, checked(y5 + height2 + 1));
                                XGraphics xgraphics7 = xgraphics1;
                                string str8 = str4;
                                XFont xfont9 = xfont5;
                                XSolidBrush black6 = XBrushes.Black;
                                XRect xrect6 = new XRect((double)checked(num8 + 1), (double)y5, (double)width2, (double)height2);
                                XStringFormat center2 = XStringFormats.Center;
                                string text6 = str8;
                                XFont font8 = xfont9;
                                XSolidBrush brush6 = black6;
                                XRect layoutRectangle6 = xrect6;
                                XStringFormat format6 = center2;
                                xgraphics7.DrawString(text6, font8, (XBrush)brush6, layoutRectangle6, format6);
                                break;
                            case 4:
                                if (index1 == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(y5 - 1), num8, checked(y5 + height2 + 1));
                                XGraphics xgraphics8 = xgraphics1;
                                string str9 = str4;
                                XFont xfont10 = xfont5;
                                XSolidBrush black7 = XBrushes.Black;
                                XRect xrect7 = new XRect((double)checked(num8 + 1), (double)y5, (double)width2, (double)height2);
                                XStringFormat center3 = XStringFormats.Center;
                                string text7 = str9;
                                XFont font9 = xfont10;
                                XSolidBrush brush7 = black7;
                                XRect layoutRectangle7 = xrect7;
                                XStringFormat format7 = center3;
                                xgraphics8.DrawString(text7, font9, (XBrush)brush7, layoutRectangle7, format7);
                                break;
                            case 5:
                                if (index1 == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(y5 - 1), num8, checked(y5 + height2 + 1));
                                XGraphics xgraphics9 = xgraphics1;
                                string str10 = str4;
                                XFont xfont11 = xfont5;
                                XSolidBrush black8 = XBrushes.Black;
                                XRect xrect8 = new XRect((double)checked(num8 + 1), (double)y5, (double)width2, (double)height2);
                                XStringFormat center4 = XStringFormats.Center;
                                string text8 = str10;
                                XFont font10 = xfont11;
                                XSolidBrush brush8 = black8;
                                XRect layoutRectangle8 = xrect8;
                                XStringFormat format8 = center4;
                                xgraphics9.DrawString(text8, font10, (XBrush)brush8, layoutRectangle8, format8);
                                if (index1 == 0 & checked(nocol - 1) == 5)
                                {
                                    xgraphics1.DrawLine(XPens.Gray, checked(num3 + width1), checked(y5 - 1), checked(num3 + width1), checked(y5 + height2 + 1));
                                    break;
                                }
                                break;
                            case 6:
                                if (index1 == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(y5 - 1), num8, checked(y5 + height2 + 1));
                                XGraphics xgraphics10 = xgraphics1;
                                string str11 = str4;
                                XFont xfont12 = xfont5;
                                XSolidBrush black9 = XBrushes.Black;
                                XRect xrect9 = new XRect((double)checked(num8 + 1), (double)y5, (double)width2, (double)height2);
                                XStringFormat center5 = XStringFormats.Center;
                                string text9 = str11;
                                XFont font11 = xfont12;
                                XSolidBrush brush9 = black9;
                                XRect layoutRectangle9 = xrect9;
                                XStringFormat format9 = center5;
                                xgraphics10.DrawString(text9, font11, (XBrush)brush9, layoutRectangle9, format9);
                                if (index1 == 0 & checked(nocol - 1) == 6)
                                {
                                    xgraphics1.DrawLine(XPens.Gray, checked(num3 + width1), checked(y5 - 1), checked(num3 + width1), checked(y5 + height2 + 1));
                                    break;
                                }
                                break;
                            case 7:
                                if (index1 == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(y5 - 1), num8, checked(y5 + height2 + 1));
                                XGraphics xgraphics11 = xgraphics1;
                                string str12 = str4;
                                XFont xfont13 = xfont5;
                                XSolidBrush black10 = XBrushes.Black;
                                XRect xrect10 = new XRect((double)checked(num8 + 1), (double)y5, (double)width2, (double)height2);
                                XStringFormat center6 = XStringFormats.Center;
                                string text10 = str12;
                                XFont font12 = xfont13;
                                XSolidBrush brush10 = black10;
                                XRect layoutRectangle10 = xrect10;
                                XStringFormat format10 = center6;
                                xgraphics11.DrawString(text10, font12, (XBrush)brush10, layoutRectangle10, format10);
                                if (index1 == 0 & checked(nocol - 1) == 7)
                                {
                                    xgraphics1.DrawLine(XPens.Gray, checked(num3 + width1), checked(y5 - 1), checked(num3 + width1), checked(y5 + height2 + 1));
                                    break;
                                }
                                break;
                            case 8:
                                if (index1 == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(y5 - 1), num8, checked(y5 + height2 + 1));
                                XGraphics xgraphics12 = xgraphics1;
                                string str13 = str4;
                                XFont xfont14 = xfont5;
                                XSolidBrush black11 = XBrushes.Black;
                                XRect xrect11 = new XRect((double)checked(num8 + 1), (double)y5, (double)width2, (double)height2);
                                XStringFormat center7 = XStringFormats.Center;
                                string text11 = str13;
                                XFont font13 = xfont14;
                                XSolidBrush brush11 = black11;
                                XRect layoutRectangle11 = xrect11;
                                XStringFormat format11 = center7;
                                xgraphics12.DrawString(text11, font13, (XBrush)brush11, layoutRectangle11, format11);
                                if (index1 == 0 & checked(nocol - 1) == 8)
                                {
                                    xgraphics1.DrawLine(XPens.Gray, checked(num3 + width1), checked(y5 - 1), checked(num3 + width1), checked(y5 + height2 + 1));
                                    break;
                                }
                                break;
                        }
                        checked { num8 += width2; }
                        checked { ++index2; }
                    }
                    num6 = checked(y5 + height2 + 1);
                    if (index1 == 0)
                        xgraphics1.DrawLine(XPens.Gray, num3, num6, checked(num3 + width1), num6);
                    checked { ++index1; }
                }
                int y6 = checked(num6 + 2 * height2);
                XGraphics xgraphics13 = xgraphics1;
                XFont xfont15 = xfont1;
                XSolidBrush black12 = XBrushes.Black;
                XRect xrect12 = new XRect((double)num3, (double)y6, (double)width1, (double)height2);
                XStringFormat topLeft5 = XStringFormats.TopLeft;
                XFont font14 = xfont15;
                XSolidBrush brush12 = black12;
                XRect layoutRectangle12 = xrect12;
                XStringFormat format12 = topLeft5;
                xgraphics13.DrawString("Referee:......................................", font14, (XBrush)brush12, layoutRectangle12, format12);
                int y7 = checked(y6 + height2);
                string segment2 = Module1.Segment;
                if (Operators.CompareString(segment2, "Seg1", false) == 0)
                {
                    XGraphics xgraphics14 = xgraphics1;
                    string name = Module1.Referee.Seg1.Name;
                    XFont xfont16 = xfont1;
                    XSolidBrush black13 = XBrushes.Black;
                    XRect xrect13 = new XRect((double)num3 + (double)numArray[0] * (double)width1 / 100.0, (double)y7, (double)width1, (double)height2);
                    XStringFormat topLeft6 = XStringFormats.TopLeft;
                    string text12 = name;
                    XFont font15 = xfont16;
                    XSolidBrush brush13 = black13;
                    XRect layoutRectangle13 = xrect13;
                    XStringFormat format13 = topLeft6;
                    xgraphics14.DrawString(text12, font15, (XBrush)brush13, layoutRectangle13, format13);
                }
                else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                {
                    XGraphics xgraphics15 = xgraphics1;
                    string name = Module1.Referee.Seg2.Name;
                    XFont xfont17 = xfont1;
                    XSolidBrush black14 = XBrushes.Black;
                    XRect xrect14 = new XRect((double)num3 + (double)numArray[0] * (double)width1 / 100.0, (double)y7, (double)width1, (double)height2);
                    XStringFormat topLeft7 = XStringFormats.TopLeft;
                    string text13 = name;
                    XFont font16 = xfont17;
                    XSolidBrush brush14 = black14;
                    XRect layoutRectangle14 = xrect14;
                    XStringFormat format14 = topLeft7;
                    xgraphics15.DrawString(text13, font16, (XBrush)brush14, layoutRectangle14, format14);
                }
                int y8 = checked(y7 + 2 * height2);
                XGraphics xgraphics16 = xgraphics1;
                string str14 = "Figure Skating Italia | Created: " + Module1.DateTimeToStr(DateTime.Now);
                XFont xfont18 = xfont2;
                XSolidBrush black15 = XBrushes.Black;
                XRect xrect15 = new XRect((double)num3, (double)y8, (double)width1, (double)height2);
                XStringFormat topLeft8 = XStringFormats.TopLeft;
                string text14 = str14;
                XFont font17 = xfont18;
                XSolidBrush brush15 = black15;
                XRect layoutRectangle15 = xrect15;
                XStringFormat format15 = topLeft8;
                xgraphics16.DrawString(text14, font17, (XBrush)brush15, layoutRectangle15, format15);
                pdfDocument.Save(pathfile);
                pdfDocument.Close();
                switch (msg)
                {
                    case 1:
                        int num10 = (int)Interaction.MsgBox((object)("The file has been saved as:\r\n" + pathfile), MsgBoxStyle.Information | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_63;
                    case 2:
                        int num11 = (int)Interaction.MsgBox((object)("The file(s) has been saved in:\r\n" + Module1.GetPath(pathfile)), MsgBoxStyle.Information | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_63;
                    default:
                        goto label_63;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num12 = (int)Interaction.MsgBox((object)("Form6, ExportDataToPDFTable1 - \r\n" + Information.Err().Description), MsgBoxStyle.Critical, (object)"Susanne SW");
            }
            label_63:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void CreateSeg1PDF(string txt, int msg)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string Path = "";
                ProjectData.ClearProjectError();
                num1 = 2;
                this.TDA = new object[51, 9];
                this.TDA[0, 0] = (object)"Place";
                this.TDA[0, 1] = (object)"Name";
                this.TDA[0, 2] = (object)"Club";
                this.TDA[0, 3] = (object)"TSS";
                this.TDA[0, 4] = (object)"TES";
                this.TDA[0, 5] = (object)"PCS";
                this.TDA[0, 6] = (object)"Deduction";
                int num3;
                if (Module1.Bonus_Sel("Seg1"))
                {
                    this.TDA[0, 7] = (object)"Bonus";
                    num3 = 7;
                }
                else
                    num3 = 6;
                Module1.SortListSeg1(Module1.TNop);
                Module1.Seg1Pl(checked(Module1.TNop - Module1.DNS_Seg1));
                int index1 = 1;
                int tnop = Module1.TNop;
                int Pno = 1;
                while (Pno <= tnop)
                {
                    if (!(Module1.Vek[Pno].Startno_Seg1 == 0 & Module1.Vek[Pno].DNS_Seg1 > 0))
                    {
                        int num4 = num3;
                        int index2 = 0;
                        while (index2 <= num4)
                        {
                            switch (index2)
                            {
                                case 0:
                                    this.TDA[index1, index2] = (object)Module1.Vek[Pno].Place_Seg1;
                                    break;
                                case 1:
                                    this.TDA[index1, index2] = (object)(Module1.Vek[Pno].Name.FName + " " + Module1.Vek[Pno].Name.LName);
                                    break;
                                case 2:
                                    this.TDA[index1, index2] = (object)Module1.Vek[Pno].Club;
                                    break;
                            }
                            switch (Module1.Vek[Pno].DNS_Seg1)
                            {
                                case 0:
                                    switch (index2)
                                    {
                                        case 3:
                                            this.TDA[index1, index2] = (object)Strings.Format((object)Module1.Vek[Pno].Score_Seg1, "0.00");
                                            break;
                                        case 4:
                                            this.TDA[index1, index2] = (object)Strings.Format((object)Module1.Vek[Pno].TES_Seg1, "0.00");
                                            break;
                                        case 5:
                                            this.TDA[index1, index2] = (object)Strings.Format((object)Module1.Vek[Pno].PCS_Seg1, "0.00");
                                            break;
                                        case 6:
                                            this.TDA[index1, index2] = (object)Module1.DedSeg1Seg2(Pno, "Seg1");
                                            break;
                                        case 7:
                                            this.TDA[index1, index2] = (object)Module1.Vek[Pno].Bonus_Seg1;
                                            break;
                                    }
                                    break;
                                case 1:
                                    switch (index2)
                                    {
                                        case 3:
                                            this.TDA[index1, index2] = (object)"DNS";
                                            break;
                                        case 4:
                                        case 5:
                                        case 6:
                                        case 7:
                                            this.TDA[index1, index2] = (object)" ";
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (index2)
                                    {
                                        case 3:
                                            this.TDA[index1, index2] = (object)"WD";
                                            break;
                                        case 4:
                                        case 5:
                                        case 6:
                                        case 7:
                                            this.TDA[index1, index2] = (object)" ";
                                            break;
                                    }
                                    break;
                                case 3:
                                    switch (index2)
                                    {
                                        case 3:
                                            this.TDA[index1, index2] = (object)"DNF";
                                            break;
                                        case 4:
                                        case 5:
                                        case 6:
                                        case 7:
                                            this.TDA[index1, index2] = (object)" ";
                                            break;
                                    }
                                    break;
                                case 4:
                                    switch (index2)
                                    {
                                        case 3:
                                            this.TDA[index1, index2] = (object)"DQ";
                                            break;
                                        case 4:
                                        case 5:
                                        case 6:
                                        case 7:
                                            this.TDA[index1, index2] = (object)" ";
                                            break;
                                    }
                                    break;
                            }
                            checked { ++index2; }
                        }
                        checked { ++index1; }
                    }
                    checked { ++Pno; }
                }
                if (Conversions.ToBoolean(Module1.CreatePath("Segment_1", ref Path)))
                {
                    this.ExportDataToPDFTable1(checked(index1 - 1), checked(num3 + 1), txt, Path + "_Results.pdf", msg);
                    goto label_42;
                }
                else
                    goto label_42;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("Form6, CreateSeg1PDF - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_42:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void CreateSeg2PDF(string txt, int msg)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string Path = "";
                ProjectData.ClearProjectError();
                num1 = 2;
                this.TDA = new object[51, 9];
                this.TDA[0, 0] = (object)"Place";
                this.TDA[0, 1] = (object)"Name";
                this.TDA[0, 2] = (object)"Club";
                this.TDA[0, 3] = (object)"TSS";
                this.TDA[0, 4] = (object)"TES";
                this.TDA[0, 5] = (object)"PCS";
                this.TDA[0, 6] = (object)"Deduction";
                int num3;
                if (Module1.Bonus_Sel("Seg2"))
                {
                    this.TDA[0, 7] = (object)"Bonus";
                    num3 = 7;
                }
                else
                    num3 = 6;
                Module1.SortListSeg2(Module1.TNop);
                Module1.Seg2Pl(checked(Module1.TNop - Module1.DNS_Seg1 - Module1.DNS_Seg2));
                int num4 = 0;
                int tnop1 = Module1.TNop;
                int index1 = 1;
                while (index1 <= tnop1)
                {
                    if (Module1.Vek[index1].DNS_Seg1 > 0)
                        checked { ++num4; }
                    checked { ++index1; }
                }
                int index2 = 1;
                string seg = Module1.GetSeg();
                if (Operators.CompareString(seg, "0F", false) == 0)
                {
                    int tnop2 = Module1.TNop;
                    int Pno = 1;
                    while (Pno <= tnop2)
                    {
                        if (!(Module1.Vek[Pno].Startno_Seg2 == 0 & Module1.Vek[Pno].DNS_Seg2 > 0))
                        {
                            int num5 = num3;
                            int index3 = 0;
                            while (index3 <= num5)
                            {
                                switch (index3)
                                {
                                    case 0:
                                        this.TDA[index2, index3] = (object)Module1.Vek[Pno].Place_Seg2;
                                        break;
                                    case 1:
                                        this.TDA[index2, index3] = (object)(Module1.Vek[Pno].Name.FName + " " + Module1.Vek[Pno].Name.LName);
                                        break;
                                    case 2:
                                        this.TDA[index2, index3] = (object)Module1.Vek[Pno].Club;
                                        break;
                                }
                                switch (Module1.Vek[Pno].DNS_Seg2)
                                {
                                    case 0:
                                        switch (index3)
                                        {
                                            case 3:
                                                this.TDA[index2, index3] = (object)Strings.Format((object)Module1.Vek[Pno].Score_Seg2, "0.00");
                                                break;
                                            case 4:
                                                this.TDA[index2, index3] = (object)Strings.Format((object)Module1.Vek[Pno].TES_Seg2, "0.00");
                                                break;
                                            case 5:
                                                this.TDA[index2, index3] = (object)Strings.Format((object)Module1.Vek[Pno].PCS_Seg2, "0.00");
                                                break;
                                            case 6:
                                                this.TDA[index2, index3] = (object)Module1.DedSeg1Seg2(Pno, "Seg2");
                                                break;
                                            case 7:
                                                this.TDA[index2, index3] = (object)Module1.Vek[Pno].Bonus_Seg2;
                                                break;
                                        }
                                        break;
                                    case 1:
                                        switch (index3)
                                        {
                                            case 3:
                                                this.TDA[index2, index3] = (object)"DNS";
                                                break;
                                            case 4:
                                            case 5:
                                            case 6:
                                            case 7:
                                                this.TDA[index2, index3] = (object)" ";
                                                break;
                                        }
                                        break;
                                    case 2:
                                        switch (index3)
                                        {
                                            case 3:
                                                this.TDA[index2, index3] = (object)"WD";
                                                break;
                                            case 4:
                                            case 5:
                                            case 6:
                                            case 7:
                                                this.TDA[index2, index3] = (object)" ";
                                                break;
                                        }
                                        break;
                                    case 3:
                                        switch (index3)
                                        {
                                            case 3:
                                                this.TDA[index2, index3] = (object)"DNF";
                                                break;
                                            case 4:
                                            case 5:
                                            case 6:
                                            case 7:
                                                this.TDA[index2, index3] = (object)" ";
                                                break;
                                        }
                                        break;
                                    case 4:
                                        switch (index3)
                                        {
                                            case 3:
                                                this.TDA[index2, index3] = (object)"DQ";
                                                break;
                                            case 4:
                                            case 5:
                                            case 6:
                                            case 7:
                                                this.TDA[index2, index3] = (object)" ";
                                                break;
                                        }
                                        break;
                                }
                                checked { ++index3; }
                            }
                            checked { ++index2; }
                        }
                        checked { ++Pno; }
                    }
                }
                else if (Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "FF", false) == 0 || Operators.CompareString(seg, "SS", false) == 0)
                {
                    int num6 = checked(Module1.TNop - num4);
                    int Pno = 1;
                    while (Pno <= num6)
                    {
                        int num7 = num3;
                        int index4 = 0;
                        while (index4 <= num7)
                        {
                            switch (index4)
                            {
                                case 0:
                                    this.TDA[index2, index4] = (object)Module1.Vek[Pno].Place_Seg2;
                                    break;
                                case 1:
                                    this.TDA[index2, index4] = (object)(Module1.Vek[Pno].Name.FName + " " + Module1.Vek[Pno].Name.LName);
                                    break;
                                case 2:
                                    this.TDA[index2, index4] = (object)Module1.Vek[Pno].Club;
                                    break;
                            }
                            if (Module1.Vek[Pno].DNS_Seg1 > 0 | Module1.Vek[Pno].DNS_Seg2 > 0)
                            {
                                switch (index4)
                                {
                                    case 3:
                                        switch (Module1.Vek[Pno].DNS_Seg1)
                                        {
                                            case 0:
                                                switch (Module1.Vek[Pno].DNS_Seg2)
                                                {
                                                    case 1:
                                                        this.TDA[index2, index4] = (object)"DNS";
                                                        break;
                                                    case 2:
                                                        this.TDA[index2, index4] = (object)"WD";
                                                        break;
                                                    case 3:
                                                        this.TDA[index2, index4] = (object)"DNF";
                                                        break;
                                                    case 4:
                                                        this.TDA[index2, index4] = (object)"DQ";
                                                        break;
                                                }
                                                break;
                                            case 1:
                                                this.TDA[index2, index4] = (object)"DNS";
                                                break;
                                            case 2:
                                                this.TDA[index2, index4] = (object)"WD";
                                                break;
                                            case 3:
                                                this.TDA[index2, index4] = (object)"DNF";
                                                break;
                                            case 4:
                                                this.TDA[index2, index4] = (object)"DQ";
                                                break;
                                        }
                                        break;
                                    case 4:
                                    case 5:
                                    case 6:
                                    case 7:
                                        this.TDA[index2, index4] = (object)" ";
                                        break;
                                }
                            }
                            else
                            {
                                switch (index4)
                                {
                                    case 3:
                                        this.TDA[index2, index4] = (object)Strings.Format((object)Module1.Vek[Pno].Score_Seg2, "0.00");
                                        break;
                                    case 4:
                                        this.TDA[index2, index4] = (object)Strings.Format((object)Module1.Vek[Pno].TES_Seg2, "0.00");
                                        break;
                                    case 5:
                                        this.TDA[index2, index4] = (object)Strings.Format((object)Module1.Vek[Pno].PCS_Seg2, "0.00");
                                        break;
                                    case 6:
                                        this.TDA[index2, index4] = (object)Module1.DedSeg1Seg2(Pno, "Seg2");
                                        break;
                                    case 7:
                                        this.TDA[index2, index4] = (object)Module1.Vek[Pno].Bonus_Seg2;
                                        break;
                                }
                            }
                            checked { ++index4; }
                        }
                        checked { ++index2; }
                        checked { ++Pno; }
                    }
                }
                if (Conversions.ToBoolean(Module1.CreatePath("Segment_2", ref Path)))
                {
                    this.ExportDataToPDFTable1(checked(index2 - 1), checked(num3 + 1), txt, Path + "_Results.pdf", msg);
                    goto label_78;
                }
                else
                    goto label_78;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num8 = (int)Interaction.MsgBox((object)("Form6, CreateSeg2PDF - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_78:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void CreateFinalPDF(int msg)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string Path = "";
                ProjectData.ClearProjectError();
                num1 = 2;
                this.TDA = new object[51, 9];
                this.TDA[0, 0] = (object)"Place";
                this.TDA[0, 1] = (object)"Name";
                this.TDA[0, 2] = (object)"Club";
                this.TDA[0, 3] = (object)"Total Score";
                this.TDA[0, 4] = (object)"Place Seg. 1";
                this.TDA[0, 5] = (object)"Place Seg. 2";
                Module1.SortListSeg1(Module1.TNop);
                Module1.Seg1Pl(checked(Module1.TNop - Module1.DNS_Seg1));
                Module1.SortListSeg2(Module1.TNop);
                Module1.Seg2Pl(checked(Module1.TNop - Module1.DNS_Seg1 - Module1.DNS_Seg2));
                Module1.SumScore(Module1.TNop);
                Module1.SortListTotal(Module1.TNop);
                Module1.TotalPl(checked(Module1.TNop - Module1.DNS_Seg1 - Module1.DNS_Seg2));
                int index1 = 1;
                int tnop = Module1.TNop;
                int index2 = 1;
                while (index2 <= tnop)
                {
                    if (Module1.Vek[index2].DNS_Seg1 == 0 & Module1.Vek[index2].Finished_Seg1 == 1 && Module1.Vek[index2].Finished_Seg2 == 1 | Module1.Vek[index2].DNS_Seg2 > 0)
                    {
                        int index3 = 0;
                        do
                        {
                            if (Module1.Vek[index2].Finished_Seg2 == 1 & Module1.Vek[index2].DNS_Seg2 == 0)
                            {
                                switch (index3)
                                {
                                    case 0:
                                        this.TDA[index1, index3] = (object)Module1.Vek[index2].Place;
                                        break;
                                    case 1:
                                        this.TDA[index1, index3] = (object)(Module1.Vek[index2].Name.FName + " " + Module1.Vek[index2].Name.LName);
                                        break;
                                    case 2:
                                        this.TDA[index1, index3] = (object)Module1.Vek[index2].Club;
                                        break;
                                    case 3:
                                        this.TDA[index1, index3] = (object)Strings.Format((object)Module1.Vek[index2].Score_Total, "0.00");
                                        break;
                                    case 4:
                                        this.TDA[index1, index3] = (object)Strings.Format((object)Module1.Vek[index2].Place_Seg1, "#");
                                        break;
                                    case 5:
                                        this.TDA[index1, index3] = (object)Strings.Format((object)Module1.Vek[index2].Place_Seg2, "#");
                                        break;
                                }
                            }
                            else if (Module1.Vek[index2].DNS_Seg2 > 0)
                            {
                                switch (index3)
                                {
                                    case 0:
                                        this.TDA[index1, index3] = (object)Module1.Vek[index2].Place;
                                        break;
                                    case 1:
                                        this.TDA[index1, index3] = (object)(Module1.Vek[index2].Name.FName + " " + Module1.Vek[index2].Name.LName);
                                        break;
                                    case 2:
                                        this.TDA[index1, index3] = (object)Module1.Vek[index2].Club;
                                        break;
                                    case 3:
                                        switch (Module1.Vek[index2].DNS_Seg2)
                                        {
                                            case 1:
                                                this.TDA[index1, index3] = (object)"DNS";
                                                break;
                                            case 2:
                                                this.TDA[index1, index3] = (object)"WD";
                                                break;
                                            case 3:
                                                this.TDA[index1, index3] = (object)"DNF";
                                                break;
                                            case 4:
                                                this.TDA[index1, index3] = (object)"DQ";
                                                break;
                                        }
                                        break;
                                    case 4:
                                        this.TDA[index1, index3] = (object)Strings.Format((object)Module1.Vek[index2].Place_Seg1, "#");
                                        break;
                                    case 5:
                                        switch (Module1.Vek[index2].DNS_Seg2)
                                        {
                                            case 1:
                                                this.TDA[index1, index3] = (object)"DNS";
                                                break;
                                            case 2:
                                                this.TDA[index1, index3] = (object)"WD";
                                                break;
                                            case 3:
                                                this.TDA[index1, index3] = (object)"DNF";
                                                break;
                                            case 4:
                                                this.TDA[index1, index3] = (object)"DQ";
                                                break;
                                        }
                                        break;
                                }
                            }
                            checked { ++index3; }
                        }
                        while (index3 <= 5);
                        checked { ++index1; }
                    }
                    checked { ++index2; }
                }
                if (Conversions.ToBoolean(Module1.CreatePath("Final", ref Path)))
                {
                    this.ExportDataToPDFTable1(checked(index1 - 1), 6, "Final Result", Path + ".pdf", msg);
                    goto label_39;
                }
                else
                    goto label_39;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("Form6, CreateFinalPDF - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_39:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void CreateResultsPDF(string seg, int msg)
        {
            string Left = seg;
            if (Operators.CompareString(Left, "Seg1", false) == 0)
                this.CreateSeg1PDF(Module1.GetSegTxt(seg), msg);
            else if (Operators.CompareString(Left, "Seg2", false) == 0)
            {
                this.CreateSeg2PDF(Module1.GetSegTxt(seg), msg);
            }
            else
            {
                if (Operators.CompareString(Left, "Final", false) != 0)
                    return;
                this.CreateFinalPDF(msg);
            }
        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void PRINTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.PrintPreviewDialog1.TopMost = true;
                this.PrintPreviewDialog1.Document = this.PrintDocument1;
                int num3 = (int)this.PrintPreviewDialog1.ShowDialog();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("Form6, PRINTToolStripMenuItem1_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int pageLeftMargin = Module1.Page_Left_Margin;
                float pageTopMargin = (float)Module1.Page_Top_Margin;
                ProjectData.ClearProjectError();
                num1 = 2;
                StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit)
                {
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter
                };
                string str = "";
                StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
                StringFormat format2 = new StringFormat(StringFormatFlags.NoClip);
                format1.Alignment = StringAlignment.Center;
                format2.Alignment = StringAlignment.Near;
                string segTxt = Module1.GetSegTxt(this.printSeg);
                string printSeg1 = this.printSeg;
                int num3 = 0;
                if (Operators.CompareString(printSeg1, "Seg1", false) == 0)
                {
                    Module1.SortListSeg1(Module1.TNop);
                    Module1.Seg1Pl(checked(Module1.TNop - Module1.DNS_Seg1));
                    str = Module1.FormShortDate(Module1.Datum.Seg1);
                    string seg = Module1.GetSeg();
                    if (Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "SS", false) == 0 || Operators.CompareString(seg, "S0", false) == 0)
                        num3 = 7;
                    else if (Operators.CompareString(seg, "FF", false) == 0 || Operators.CompareString(seg, "F0", false) == 0)
                        num3 = 8;
                }
                else if (Operators.CompareString(printSeg1, "Seg2", false) == 0)
                {
                    Module1.SortListSeg2(Module1.TNop);
                    Module1.Seg2Pl(checked(Module1.TNop - Module1.DNS_Seg1 - Module1.DNS_Seg2));
                    string seg = Module1.GetSeg();
                    if (Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "FF", false) == 0 || Operators.CompareString(seg, "0F", false) == 0)
                    {
                        num3 = 8;
                        str = Module1.FormShortDate(Module1.Datum.Seg2);
                    }
                    else if (Operators.CompareString(seg, "SS", false) == 0 || Operators.CompareString(seg, "0S", false) == 0)
                    {
                        num3 = 7;
                        str = Module1.FormShortDate(Module1.Datum.Seg2);
                    }
                }
                else
                {
                    Module1.SortListSeg1(Module1.TNop);
                    Module1.Seg1Pl(checked(Module1.TNop - Module1.DNS_Seg1));
                    Module1.SortListSeg2(Module1.TNop);
                    Module1.Seg2Pl(checked(Module1.TNop - Module1.DNS_Seg1 - Module1.DNS_Seg2));
                    Module1.SumScore(Module1.TNop);
                    Module1.SortListTotal(Module1.TNop);
                    Module1.TotalPl(checked(Module1.TNop - Module1.DNS_Seg1 - Module1.DNS_Seg2));
                    num3 = 6;
                    str = Module1.FormShortDate(Module1.Datum.Seg2);
                }
                double num4;
                int emSize;
                switch (num3)
                {
                    case 6:
                        num4 = Module1.Page_Size * 0.9 / 100.0;
                        emSize = checked((int)Math.Round(Conversion.Int(unchecked(num4 * 10.0 + 3.55))));
                        break;
                    case 7:
                        num4 = Module1.Page_Size * 0.85 / 100.0;
                        emSize = checked((int)Math.Round(Conversion.Int(unchecked(num4 * 10.0 + 4.15))));
                        break;
                    case 8:
                        num4 = Module1.Page_Size * 0.75 / 100.0;
                        emSize = checked((int)Math.Round(Conversion.Int(unchecked(num4 * 10.0 + 5.05))));
                        break;
                    default:
                        goto label_154;
                }
                Font font1 = new Font("ARIAL", (float)checked(emSize + 2), FontStyle.Bold, GraphicsUnit.Pixel);
                Font font2 = new Font("ARIAL", (float)emSize, FontStyle.Bold, GraphicsUnit.Pixel);
                Font font3 = new Font("ARIAL", (float)emSize, FontStyle.Regular, GraphicsUnit.Pixel);
                Font font4 = new Font("ARIAL", 8f, FontStyle.Regular, GraphicsUnit.Pixel);
                double height1 = (double)font1.GetHeight(e.Graphics);
                e.Graphics.DrawString("RESULTS", font1, Brushes.Black, (float)pageLeftMargin, pageTopMargin, new StringFormat());
                float y1 = (float)((double)pageTopMargin + (double)font1.GetHeight(e.Graphics) + 5.0);
                e.Graphics.DrawString("COMPETITION: " + Module1.Competition.Name, font1, Brushes.Black, (float)pageLeftMargin, y1, new StringFormat());
                float y2 = y1 + font1.GetHeight(e.Graphics);
                e.Graphics.DrawString("CATEGORY: " + Module1.Category.Name + Module1.SubCat() + ", " + segTxt, font1, Brushes.Black, (float)pageLeftMargin, y2, new StringFormat());
                float y3 = y2 + font1.GetHeight(e.Graphics);
                e.Graphics.DrawString("DATE: " + str, font1, Brushes.Black, (float)pageLeftMargin, y3, new StringFormat());
                float num5 = (float)pageLeftMargin;
                float y4 = (float)((double)y3 + (double)font1.GetHeight(e.Graphics) + 10.0);
                float height2 = font3.GetHeight(e.Graphics);
                int num6 = num3;
                int num7 = 1;
                RectangleF layoutRectangle = new RectangleF(num5, y4, (float)(60.0 * num4), height2);
                int x1 = 0;
                while (num7 <= num6)
                {
                    switch (num7)
                    {
                        case 1:
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            e.Graphics.DrawString("Place", font2, Brushes.Black, layoutRectangle, format1);
                            break;
                        case 2:
                            num5 += layoutRectangle.Width;
                            x1 = checked((int)Math.Round((double)num5));
                            layoutRectangle = new RectangleF(num5, y4, (float)(200.0 * num4), height2);
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            e.Graphics.DrawString("Name", font2, Brushes.Black, layoutRectangle, format2);
                            break;
                        case 3:
                            num5 += layoutRectangle.Width;
                            layoutRectangle = new RectangleF(num5, y4, (float)(200.0 * num4), height2);
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            e.Graphics.DrawString("Club", font2, Brushes.Black, layoutRectangle, format2);
                            break;
                        case 4:
                            num5 += layoutRectangle.Width;
                            layoutRectangle = new RectangleF(num5, y4, (float)(100.0 * num4), height2);
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            string printSeg2 = this.printSeg;
                            if (Operators.CompareString(printSeg2, "Seg1", false) == 0 || Operators.CompareString(printSeg2, "Seg2", false) == 0)
                            {
                                e.Graphics.DrawString("TSS", font2, Brushes.Black, layoutRectangle, format1);
                                break;
                            }
                            e.Graphics.DrawString("Total Score", font2, Brushes.Black, layoutRectangle, format1);
                            break;
                        case 5:
                            num5 += layoutRectangle.Width;
                            layoutRectangle = new RectangleF(num5, y4, (float)(100.0 * num4), height2);
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            string printSeg3 = this.printSeg;
                            if (Operators.CompareString(printSeg3, "Seg1", false) == 0 || Operators.CompareString(printSeg3, "Seg2", false) == 0)
                            {
                                e.Graphics.DrawString("TES", font2, Brushes.Black, layoutRectangle, format1);
                                break;
                            }
                            e.Graphics.DrawString("Place Seg. 1", font2, Brushes.Black, layoutRectangle, format1);
                            break;
                        case 6:
                            num5 += layoutRectangle.Width;
                            layoutRectangle = new RectangleF(num5, y4, (float)(100.0 * num4), height2);
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            string printSeg4 = this.printSeg;
                            if (Operators.CompareString(printSeg4, "Seg1", false) == 0 || Operators.CompareString(printSeg4, "Seg2", false) == 0)
                            {
                                e.Graphics.DrawString("PCS", font2, Brushes.Black, layoutRectangle, format1);
                                break;
                            }
                            e.Graphics.DrawString("Place Seg. 2", font2, Brushes.Black, layoutRectangle, format1);
                            break;
                        case 7:
                            num5 += layoutRectangle.Width;
                            layoutRectangle = new RectangleF(num5, y4, (float)(100.0 * num4), height2);
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            e.Graphics.DrawString("Deduction", font2, Brushes.Black, layoutRectangle, format1);
                            break;
                        case 8:
                            num5 += layoutRectangle.Width;
                            layoutRectangle = new RectangleF(num5, y4, (float)(90.0 * num4), height2);
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            e.Graphics.DrawString("Bonus", font2, Brushes.Black, layoutRectangle, format1);
                            break;
                    }
                    checked { ++num7; }
                }
                float y5 = y4 + height2;
                int Pno = 1;
                string printSeg5 = this.printSeg;
                if (Operators.CompareString(printSeg5, "Seg1", false) == 0)
                {
                    while (Pno <= Module1.TNop)
                    {
                        if (!(Module1.Vek[Pno].Startno_Seg1 == 0 & Module1.Vek[Pno].DNS_Seg1 > 0))
                        {
                            float x2 = (float)pageLeftMargin;
                            int num8 = num3;
                            int num9 = 1;
                            while (num9 <= num8)
                            {
                                switch (num9)
                                {
                                    case 1:
                                        layoutRectangle = new RectangleF(x2, y5, (float)(60.0 * num4), height2);
                                        e.Graphics.DrawString(Conversions.ToString(Module1.Vek[Pno].Place_Seg1), font3, Brushes.Black, layoutRectangle, format1);
                                        break;
                                    case 2:
                                        x2 += layoutRectangle.Width;
                                        layoutRectangle = new RectangleF(x2, y5, (float)(200.0 * num4), height2);
                                        e.Graphics.DrawString(Module1.Vek[Pno].Name.FName + " " + Module1.Vek[Pno].Name.LName, font3, Brushes.Black, layoutRectangle, format2);
                                        break;
                                    case 3:
                                        x2 += layoutRectangle.Width;
                                        layoutRectangle = new RectangleF(x2, y5, (float)(200.0 * num4), height2);
                                        e.Graphics.DrawString(Module1.Vek[Pno].Club, font3, Brushes.Black, layoutRectangle, format2);
                                        break;
                                }
                                if (Module1.Vek[Pno].DNS_Seg1 == 0)
                                {
                                    switch (num9)
                                    {
                                        case 4:
                                            x2 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x2, y5, (float)(100.0 * num4), height2);
                                            e.Graphics.DrawString(Strings.Format((object)Module1.Vek[Pno].Score_Seg1, "0.00"), font3, Brushes.Black, layoutRectangle, format1);
                                            break;
                                        case 5:
                                            x2 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x2, y5, (float)(100.0 * num4), height2);
                                            e.Graphics.DrawString(Strings.Format((object)Module1.Vek[Pno].TES_Seg1, "0.00"), font3, Brushes.Black, layoutRectangle, format1);
                                            break;
                                        case 6:
                                            x2 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x2, y5, (float)(100.0 * num4), height2);
                                            e.Graphics.DrawString(Strings.Format((object)Module1.Vek[Pno].PCS_Seg1, "0.00"), font3, Brushes.Black, layoutRectangle, format1);
                                            break;
                                        case 7:
                                            x2 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x2, y5, (float)(100.0 * num4), height2);
                                            e.Graphics.DrawString(Conversions.ToString(Module1.DedSeg1Seg2(Pno, "Seg1")), font3, Brushes.Black, layoutRectangle, format1);
                                            break;
                                        case 8:
                                            x2 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x2, y5, (float)(100.0 * num4), height2);
                                            e.Graphics.DrawString(Conversions.ToString(Module1.Vek[Pno].Bonus_Seg1), font3, Brushes.Black, layoutRectangle, format1);
                                            break;
                                    }
                                }
                                else
                                {
                                    switch (num9)
                                    {
                                        case 4:
                                            x2 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x2, y5, (float)(100.0 * num4), height2);
                                            switch (Module1.Vek[Pno].DNS_Seg1)
                                            {
                                                case 1:
                                                    e.Graphics.DrawString("DNS", font3, Brushes.Black, layoutRectangle, format1);
                                                    break;
                                                case 2:
                                                    e.Graphics.DrawString("WD", font3, Brushes.Black, layoutRectangle, format1);
                                                    break;
                                                case 3:
                                                    e.Graphics.DrawString("DNF", font3, Brushes.Black, layoutRectangle, format1);
                                                    break;
                                                case 4:
                                                    e.Graphics.DrawString("DQ", font3, Brushes.Black, layoutRectangle, format1);
                                                    break;
                                            }
                                            break;
                                        case 5:
                                        case 6:
                                        case 7:
                                        case 8:
                                            x2 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x2, y5, (float)(100.0 * num4), height2);
                                            e.Graphics.DrawString(" ", font3, Brushes.Black, layoutRectangle, format1);
                                            break;
                                    }
                                }
                                checked { ++num9; }
                            }
                            y5 += height2;
                        }
                        checked { ++Pno; }
                    }
                }
                else if (Operators.CompareString(printSeg5, "Seg2", false) == 0)
                {
                    string seg = Module1.GetSeg();
                    if (Operators.CompareString(seg, "0F", false) == 0)
                    {
                        while (Pno <= Module1.TNop)
                        {
                            if (!(Module1.Vek[Pno].Startno_Seg2 == 0 & Module1.Vek[Pno].DNS_Seg2 > 0))
                            {
                                float x3 = (float)pageLeftMargin;
                                int num10 = num3;
                                int num11 = 1;
                                while (num11 <= num10)
                                {
                                    switch (num11)
                                    {
                                        case 1:
                                            layoutRectangle = new RectangleF(x3, y5, (float)(60.0 * num4), height2);
                                            e.Graphics.DrawString(Conversions.ToString(Module1.Vek[Pno].Place_Seg2), font3, Brushes.Black, layoutRectangle, format1);
                                            break;
                                        case 2:
                                            x3 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x3, y5, (float)(200.0 * num4), height2);
                                            e.Graphics.DrawString(Module1.Vek[Pno].Name.FName + " " + Module1.Vek[Pno].Name.LName, font3, Brushes.Black, layoutRectangle, format2);
                                            break;
                                        case 3:
                                            x3 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x3, y5, (float)(200.0 * num4), height2);
                                            e.Graphics.DrawString(Module1.Vek[Pno].Club, font3, Brushes.Black, layoutRectangle, format2);
                                            break;
                                    }
                                    if (Module1.Vek[Pno].DNS_Seg2 == 0)
                                    {
                                        switch (num11)
                                        {
                                            case 4:
                                                x3 += layoutRectangle.Width;
                                                layoutRectangle = new RectangleF(x3, y5, (float)(100.0 * num4), height2);
                                                e.Graphics.DrawString(Strings.Format((object)Module1.Vek[Pno].Score_Seg2, "0.00"), font3, Brushes.Black, layoutRectangle, format1);
                                                break;
                                            case 5:
                                                x3 += layoutRectangle.Width;
                                                layoutRectangle = new RectangleF(x3, y5, (float)(100.0 * num4), height2);
                                                e.Graphics.DrawString(Strings.Format((object)Module1.Vek[Pno].TES_Seg2, "0.00"), font3, Brushes.Black, layoutRectangle, format1);
                                                break;
                                            case 6:
                                                x3 += layoutRectangle.Width;
                                                layoutRectangle = new RectangleF(x3, y5, (float)(100.0 * num4), height2);
                                                e.Graphics.DrawString(Strings.Format((object)Module1.Vek[Pno].PCS_Seg2, "0.00"), font3, Brushes.Black, layoutRectangle, format1);
                                                break;
                                            case 7:
                                                x3 += layoutRectangle.Width;
                                                layoutRectangle = new RectangleF(x3, y5, (float)(100.0 * num4), height2);
                                                e.Graphics.DrawString(Conversions.ToString(Module1.DedSeg1Seg2(Pno, "Seg2")), font3, Brushes.Black, layoutRectangle, format1);
                                                break;
                                            case 8:
                                                x3 += layoutRectangle.Width;
                                                layoutRectangle = new RectangleF(x3, y5, (float)(100.0 * num4), height2);
                                                e.Graphics.DrawString(Conversions.ToString(Module1.Vek[Pno].Bonus_Seg2), font3, Brushes.Black, layoutRectangle, format1);
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        switch (num11)
                                        {
                                            case 4:
                                                x3 += layoutRectangle.Width;
                                                layoutRectangle = new RectangleF(x3, y5, (float)(100.0 * num4), height2);
                                                switch (Module1.Vek[Pno].DNS_Seg2)
                                                {
                                                    case 1:
                                                        e.Graphics.DrawString("DNS", font3, Brushes.Black, layoutRectangle, format1);
                                                        break;
                                                    case 2:
                                                        e.Graphics.DrawString("WD", font3, Brushes.Black, layoutRectangle, format1);
                                                        break;
                                                    case 3:
                                                        e.Graphics.DrawString("DNF", font3, Brushes.Black, layoutRectangle, format1);
                                                        break;
                                                    case 4:
                                                        e.Graphics.DrawString("DQ", font3, Brushes.Black, layoutRectangle, format1);
                                                        break;
                                                }
                                                break;
                                            case 5:
                                            case 6:
                                            case 7:
                                            case 8:
                                                x3 += layoutRectangle.Width;
                                                layoutRectangle = new RectangleF(x3, y5, (float)(100.0 * num4), height2);
                                                e.Graphics.DrawString(" ", font3, Brushes.Black, layoutRectangle, format1);
                                                break;
                                        }
                                    }
                                    checked { ++num11; }
                                }
                                y5 += height2;
                            }
                            checked { ++Pno; }
                        }
                    }
                    else if (Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "FF", false) == 0 || Operators.CompareString(seg, "SS", false) == 0)
                    {
                        while (Pno <= Module1.TNop)
                        {
                            if (Module1.Vek[Pno].DNS_Seg1 == 0)
                            {
                                float x4 = (float)pageLeftMargin;
                                int num12 = num3;
                                int num13 = 1;
                                while (num13 <= num12)
                                {
                                    switch (num13)
                                    {
                                        case 1:
                                            layoutRectangle = new RectangleF(x4, y5, (float)(60.0 * num4), height2);
                                            e.Graphics.DrawString(Conversions.ToString(Module1.Vek[Pno].Place_Seg2), font3, Brushes.Black, layoutRectangle, format1);
                                            break;
                                        case 2:
                                            x4 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x4, y5, (float)(200.0 * num4), height2);
                                            e.Graphics.DrawString(Module1.Vek[Pno].Name.FName + " " + Module1.Vek[Pno].Name.LName, font3, Brushes.Black, layoutRectangle, format2);
                                            break;
                                        case 3:
                                            x4 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x4, y5, (float)(200.0 * num4), height2);
                                            e.Graphics.DrawString(Module1.Vek[Pno].Club, font3, Brushes.Black, layoutRectangle, format2);
                                            break;
                                    }
                                    if (Module1.Vek[Pno].DNS_Seg2 > 0)
                                    {
                                        switch (num13)
                                        {
                                            case 4:
                                                x4 += layoutRectangle.Width;
                                                layoutRectangle = new RectangleF(x4, y5, (float)(100.0 * num4), height2);
                                                switch (Module1.Vek[Pno].DNS_Seg2)
                                                {
                                                    case 1:
                                                        e.Graphics.DrawString("DNS", font3, Brushes.Black, layoutRectangle, format1);
                                                        break;
                                                    case 2:
                                                        e.Graphics.DrawString("WD", font3, Brushes.Black, layoutRectangle, format1);
                                                        break;
                                                    case 3:
                                                        e.Graphics.DrawString("DNF", font3, Brushes.Black, layoutRectangle, format1);
                                                        break;
                                                    case 4:
                                                        e.Graphics.DrawString("DQ", font3, Brushes.Black, layoutRectangle, format1);
                                                        break;
                                                }
                                                break;
                                            case 5:
                                            case 6:
                                            case 7:
                                            case 8:
                                                x4 += layoutRectangle.Width;
                                                layoutRectangle = new RectangleF(x4, y5, (float)(100.0 * num4), height2);
                                                e.Graphics.DrawString(" ", font3, Brushes.Black, layoutRectangle, format1);
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        switch (num13)
                                        {
                                            case 4:
                                                x4 += layoutRectangle.Width;
                                                layoutRectangle = new RectangleF(x4, y5, (float)(100.0 * num4), height2);
                                                e.Graphics.DrawString(Strings.Format((object)Module1.Vek[Pno].Score_Seg2, "0.00"), font3, Brushes.Black, layoutRectangle, format1);
                                                break;
                                            case 5:
                                                x4 += layoutRectangle.Width;
                                                layoutRectangle = new RectangleF(x4, y5, (float)(100.0 * num4), height2);
                                                e.Graphics.DrawString(Strings.Format((object)Module1.Vek[Pno].TES_Seg2, "0.00"), font3, Brushes.Black, layoutRectangle, format1);
                                                break;
                                            case 6:
                                                x4 += layoutRectangle.Width;
                                                layoutRectangle = new RectangleF(x4, y5, (float)(100.0 * num4), height2);
                                                e.Graphics.DrawString(Strings.Format((object)Module1.Vek[Pno].PCS_Seg2, "0.00"), font3, Brushes.Black, layoutRectangle, format1);
                                                break;
                                            case 7:
                                                x4 += layoutRectangle.Width;
                                                layoutRectangle = new RectangleF(x4, y5, (float)(100.0 * num4), height2);
                                                e.Graphics.DrawString(Conversions.ToString(Module1.DedSeg1Seg2(Pno, "Seg2")), font3, Brushes.Black, layoutRectangle, format1);
                                                break;
                                            case 8:
                                                x4 += layoutRectangle.Width;
                                                layoutRectangle = new RectangleF(x4, y5, (float)(100.0 * num4), height2);
                                                e.Graphics.DrawString(Conversions.ToString(Module1.Vek[Pno].Bonus_Seg2), font3, Brushes.Black, layoutRectangle, format1);
                                                break;
                                        }
                                    }
                                    checked { ++num13; }
                                }
                                y5 += height2;
                            }
                            checked { ++Pno; }
                        }
                    }
                }
                else
                {
                    while (Pno <= Module1.TNop)
                    {
                        if (Module1.Vek[Pno].DNS_Seg1 == 0 & (Module1.Vek[Pno].Finished_Seg2 == 1 | Module1.Vek[Pno].DNS_Seg2 > 0))
                        {
                            float x5 = (float)pageLeftMargin;
                            int num14 = num3;
                            int num15 = 1;
                            while (num15 <= num14)
                            {
                                if (Module1.Vek[Pno].Finished_Seg2 == 1 & Module1.Vek[Pno].DNS_Seg2 == 0)
                                {
                                    switch (num15)
                                    {
                                        case 1:
                                            layoutRectangle = new RectangleF(x5, y5, (float)(60.0 * num4), height2);
                                            e.Graphics.DrawString(Conversions.ToString(Module1.Vek[Pno].Place), font3, Brushes.Black, layoutRectangle, format1);
                                            break;
                                        case 2:
                                            x5 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x5, y5, (float)(200.0 * num4), height2);
                                            e.Graphics.DrawString(Module1.Vek[Pno].Name.FName + " " + Module1.Vek[Pno].Name.LName, font3, Brushes.Black, layoutRectangle, format2);
                                            break;
                                        case 3:
                                            x5 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x5, y5, (float)(200.0 * num4), height2);
                                            e.Graphics.DrawString(Module1.Vek[Pno].Club, font3, Brushes.Black, layoutRectangle, format2);
                                            break;
                                        case 4:
                                            x5 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x5, y5, (float)(100.0 * num4), height2);
                                            e.Graphics.DrawString(Strings.Format((object)Module1.Vek[Pno].Score_Total, "0.00"), font3, Brushes.Black, layoutRectangle, format1);
                                            break;
                                        case 5:
                                            x5 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x5, y5, (float)(100.0 * num4), height2);
                                            e.Graphics.DrawString(Strings.Format((object)Module1.Vek[Pno].Place_Seg1, "#"), font3, Brushes.Black, layoutRectangle, format1);
                                            break;
                                        case 6:
                                            x5 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x5, y5, (float)(100.0 * num4), height2);
                                            e.Graphics.DrawString(Strings.Format((object)Module1.Vek[Pno].Place_Seg2, "#"), font3, Brushes.Black, layoutRectangle, format1);
                                            break;
                                    }
                                }
                                else if (Module1.Vek[Pno].DNS_Seg2 > 0)
                                {
                                    switch (num15)
                                    {
                                        case 1:
                                            layoutRectangle = new RectangleF(x5, y5, (float)(60.0 * num4), height2);
                                            e.Graphics.DrawString(Conversions.ToString(Module1.Vek[Pno].Place), font3, Brushes.Black, layoutRectangle, format1);
                                            break;
                                        case 2:
                                            x5 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x5, y5, (float)(200.0 * num4), height2);
                                            e.Graphics.DrawString(Module1.Vek[Pno].Name.FName + " " + Module1.Vek[Pno].Name.LName, font3, Brushes.Black, layoutRectangle, format2);
                                            break;
                                        case 3:
                                            x5 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x5, y5, (float)(200.0 * num4), height2);
                                            e.Graphics.DrawString(Module1.Vek[Pno].Club, font3, Brushes.Black, layoutRectangle, format2);
                                            break;
                                        case 4:
                                            x5 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x5, y5, (float)(100.0 * num4), height2);
                                            switch (Module1.Vek[Pno].DNS_Seg2)
                                            {
                                                case 1:
                                                    e.Graphics.DrawString("DNS", font3, Brushes.Black, layoutRectangle, format1);
                                                    break;
                                                case 2:
                                                    e.Graphics.DrawString("WD", font3, Brushes.Black, layoutRectangle, format1);
                                                    break;
                                                case 3:
                                                    e.Graphics.DrawString("DNF", font3, Brushes.Black, layoutRectangle, format1);
                                                    break;
                                                case 4:
                                                    e.Graphics.DrawString("DQ", font3, Brushes.Black, layoutRectangle, format1);
                                                    break;
                                            }
                                            break;
                                        case 5:
                                            x5 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x5, y5, (float)(100.0 * num4), height2);
                                            e.Graphics.DrawString(Strings.Format((object)Module1.Vek[Pno].Place_Seg1, "#"), font3, Brushes.Black, layoutRectangle, format1);
                                            break;
                                        case 6:
                                            x5 += layoutRectangle.Width;
                                            layoutRectangle = new RectangleF(x5, y5, (float)(100.0 * num4), height2);
                                            switch (Module1.Vek[Pno].DNS_Seg2)
                                            {
                                                case 1:
                                                    e.Graphics.DrawString("DNS", font3, Brushes.Black, layoutRectangle, format1);
                                                    break;
                                                case 2:
                                                    e.Graphics.DrawString("WD", font3, Brushes.Black, layoutRectangle, format1);
                                                    break;
                                                case 3:
                                                    e.Graphics.DrawString("DNF", font3, Brushes.Black, layoutRectangle, format1);
                                                    break;
                                                case 4:
                                                    e.Graphics.DrawString("DQ", font3, Brushes.Black, layoutRectangle, format1);
                                                    break;
                                            }
                                            break;
                                    }
                                }
                                checked { ++num15; }
                            }
                            y5 += height2;
                            checked { ++Pno; }
                        }
                        else
                            checked { ++Pno; }
                    }
                }
                float y6 = y5 + 40f;
                e.Graphics.DrawString("Referee:..................................................", font3, Brushes.Black, (float)pageLeftMargin, y6, new StringFormat());
                float y7 = y6 + 20f;
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                    e.Graphics.DrawString(Module1.Referee.Seg1.Name, font3, Brushes.Black, (float)x1, y7, new StringFormat());
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    e.Graphics.DrawString(Module1.Referee.Seg2.Name, font3, Brushes.Black, (float)x1, y7, new StringFormat());
                float y8 = y7 + 20f;
                e.Graphics.DrawString("Figure Skating Italia | Created: " + Module1.DateTimeToStr(DateTime.Now), font4, Brushes.Black, (float)pageLeftMargin, y8, new StringFormat());
                goto label_154;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num16 = (int)Interaction.MsgBox((object)("Form2, PrintDocument1_PrintPage_1 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_154:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void CREATEFILESToolStripMenuItem_Click(object sender, EventArgs e) => this.CreateResultsPDF(this.printSeg, 1);
    }
}

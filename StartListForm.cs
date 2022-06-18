// Decompiled with JetBrains decompiler
// Type: ClubCompFS.StartListForm
// Assembly: ClubCompFS_10p0p6, Version=1.0.0.6, Culture=neutral, PublicKeyToken=null
// MVID: F1E583B2-A781-4EC4-B47C-BA3F451903AE
// Assembly location: E:\zz Personal_Doc\Personal\Cinzia\programmaLibertas_openNEW\ClubCompFS_10p0p6.exe

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
    public class StartListForm : Form
    {
        private IContainer components;
        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;
        [AccessedThroughProperty("IndTAToolStripMenuItem")]
        private ToolStripMenuItem _IndTAToolStripMenuItem;
        [AccessedThroughProperty("GetFromIndTAToolStripMenuItem")]
        private ToolStripMenuItem _GetFromIndTAToolStripMenuItem;
        [AccessedThroughProperty("GenerateStartNoToolStripMenuItem")]
        private ToolStripMenuItem _GenerateStartNoToolStripMenuItem;
        [AccessedThroughProperty("RandomToolStripMenuItem")]
        private ToolStripMenuItem _RandomToolStripMenuItem;
        [AccessedThroughProperty("AccordingToShortProgramToolStripMenuItem")]
        private ToolStripMenuItem _AccordingToShortProgramToolStripMenuItem;
        [AccessedThroughProperty("ToolStripMenuItemFile")]
        private ToolStripMenuItem _ToolStripMenuItemFile;
        [AccessedThroughProperty("Mode")]
        private TextBox _Mode;
        [AccessedThroughProperty("CompetitionToolStripMenuItem")]
        private ToolStripMenuItem _CompetitionToolStripMenuItem;
        [AccessedThroughProperty("DataGridView1")]
        private DataGridView _DataGridView1;
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
        [AccessedThroughProperty("PrintDocument1")]
        private PrintDocument _PrintDocument1;
        [AccessedThroughProperty("PrintPreviewDialog1")]
        private PrintPreviewDialog _PrintPreviewDialog1;
        [AccessedThroughProperty("EntriesPDFToolStripMenuItem")]
        private ToolStripMenuItem _EntriesPDFToolStripMenuItem;
        [AccessedThroughProperty("StartListPDFToolStripMenuItem")]
        private ToolStripMenuItem _StartListPDFToolStripMenuItem;
        [AccessedThroughProperty("SPEAKERSTARTLISTToolStripMenuItem")]
        private ToolStripMenuItem _SPEAKERSTARTLISTToolStripMenuItem;
        [AccessedThroughProperty("INPUTELEMENTToolStripMenuItem")]
        private ToolStripMenuItem _INPUTELEMENTToolStripMenuItem;
        [AccessedThroughProperty("EDITSKATERToolStripMenuItem")]
        private ToolStripMenuItem _EDITSKATERToolStripMenuItem;
        [AccessedThroughProperty("NewToolStripMenuItem")]
        private ToolStripMenuItem _NewToolStripMenuItem;
        [AccessedThroughProperty("EditToolStripMenuItem")]
        private ToolStripMenuItem _EditToolStripMenuItem;
        [AccessedThroughProperty("InputElementToolStripMenuItem1")]
        private ToolStripMenuItem _InputElementToolStripMenuItem1;
        [AccessedThroughProperty("DeleteToolStripMenuItem")]
        private ToolStripMenuItem _DeleteToolStripMenuItem;
        [AccessedThroughProperty("PrintDocument2")]
        private PrintDocument _PrintDocument2;
        [AccessedThroughProperty("ToolStripSeparator2")]
        private ToolStripSeparator _ToolStripSeparator2;
        [AccessedThroughProperty("ToolStripSeparator3")]
        private ToolStripSeparator _ToolStripSeparator3;
        [AccessedThroughProperty("PrintEntriesToolStripMenuItem")]
        private ToolStripMenuItem _PrintEntriesToolStripMenuItem;
        [AccessedThroughProperty("PrintStartlistToolStripMenuItem")]
        private ToolStripMenuItem _PrintStartlistToolStripMenuItem;
        [AccessedThroughProperty("ExitToolStripMenuItem1")]
        private ToolStripMenuItem _ExitToolStripMenuItem1;
        [AccessedThroughProperty("ToolStripSeparator4")]
        private ToolStripSeparator _ToolStripSeparator4;
        [AccessedThroughProperty("WARMUPToolStripMenuItem")]
        private ToolStripMenuItem _WARMUPToolStripMenuItem;
        [AccessedThroughProperty("WarmupGroupsToolStripMenuItem")]
        private ToolStripMenuItem _WarmupGroupsToolStripMenuItem;
        [AccessedThroughProperty("EXITToolStripMenuItem")]
        private ToolStripMenuItem _EXITToolStripMenuItem;
        [AccessedThroughProperty("Panel1")]
        private Panel _Panel1;
        [AccessedThroughProperty("txtInfo")]
        private TextBox _txtInfo;
        [AccessedThroughProperty("txtEl")]
        private TextBox _txtEl;
        [AccessedThroughProperty("txtj7")]
        private TextBox _txtj7;
        [AccessedThroughProperty("txtJ4")]
        private TextBox _txtJ4;
        [AccessedThroughProperty("txtJ3")]
        private TextBox _txtJ3;
        [AccessedThroughProperty("txtJ2")]
        private TextBox _txtJ2;
        [AccessedThroughProperty("txtJ6")]
        private TextBox _txtJ6;
        [AccessedThroughProperty("txtJ5")]
        private TextBox _txtJ5;
        [AccessedThroughProperty("txtJ1")]
        private TextBox _txtJ1;
        [AccessedThroughProperty("txtMP")]
        private TextBox _txtMP;
        [AccessedThroughProperty("ContextMenuStrip1")]
        private ContextMenuStrip _ContextMenuStrip1;
        [AccessedThroughProperty("NewSkaterToolStripMenuItem")]
        private ToolStripMenuItem _NewSkaterToolStripMenuItem;
        [AccessedThroughProperty("EditSkaterToolStripMenuItem1")]
        private ToolStripMenuItem _EditSkaterToolStripMenuItem1;
        [AccessedThroughProperty("InputElementToolStripMenuItem2")]
        private ToolStripMenuItem _InputElementToolStripMenuItem2;
        [AccessedThroughProperty("ToolStripSeparator1")]
        private ToolStripSeparator _ToolStripSeparator1;
        [AccessedThroughProperty("DeleteSkaterToolStripMenuItem")]
        private ToolStripMenuItem _DeleteSkaterToolStripMenuItem;
        [AccessedThroughProperty("GetSkatersForToolStripMenuItem")]
        private ToolStripMenuItem _GetSkatersForToolStripMenuItem;
        public object[,] TArr;
        private int TarrRow;
        private int F2Height;
        private int DGW1width;
        private bool widthcorr;
        private bool StartListFormMin;
        public bool WillExitStartListForm;

        public StartListForm()
        {
            this.Activated += new EventHandler(this.StartListForm_Activated);
            this.Resize += new EventHandler(this.StartListForm_Resize);
            this.FormClosing += new FormClosingEventHandler(this.StartListForm_FormClosing);
            this.Load += new EventHandler(this.StartListForm_Load);
            this.SizeChanged += new EventHandler(this.StartListForm_SizeChanged);
            this.TArr = new object[51, 10];
            this.widthcorr = false;
            this.StartListFormMin = false;
            this.WillExitStartListForm = false;
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(StartListForm));
            this.MenuStrip1 = new MenuStrip();
            this.EXITToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripMenuItemFile = new ToolStripMenuItem();
            this.EntriesPDFToolStripMenuItem = new ToolStripMenuItem();
            this.StartListPDFToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.PrintEntriesToolStripMenuItem = new ToolStripMenuItem();
            this.PrintStartlistToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.ExitToolStripMenuItem1 = new ToolStripMenuItem();
            this.CompetitionToolStripMenuItem = new ToolStripMenuItem();
            this.SPEAKERSTARTLISTToolStripMenuItem = new ToolStripMenuItem();
            this.INPUTELEMENTToolStripMenuItem = new ToolStripMenuItem();
            this.IndTAToolStripMenuItem = new ToolStripMenuItem();
            this.GetFromIndTAToolStripMenuItem = new ToolStripMenuItem();
            this.GetSkatersForToolStripMenuItem = new ToolStripMenuItem();
            this.GenerateStartNoToolStripMenuItem = new ToolStripMenuItem();
            this.RandomToolStripMenuItem = new ToolStripMenuItem();
            this.AccordingToShortProgramToolStripMenuItem = new ToolStripMenuItem();
            this.WARMUPToolStripMenuItem = new ToolStripMenuItem();
            this.WarmupGroupsToolStripMenuItem = new ToolStripMenuItem();
            this.EDITSKATERToolStripMenuItem = new ToolStripMenuItem();
            this.NewToolStripMenuItem = new ToolStripMenuItem();
            this.EditToolStripMenuItem = new ToolStripMenuItem();
            this.InputElementToolStripMenuItem1 = new ToolStripMenuItem();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.DeleteToolStripMenuItem = new ToolStripMenuItem();
            this.DataGridView1 = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.Column8 = new DataGridViewTextBoxColumn();
            this.Mode = new TextBox();
            this.PrintDocument1 = new PrintDocument();
            this.PrintPreviewDialog1 = new PrintPreviewDialog();
            this.PrintDocument2 = new PrintDocument();
            this.Panel1 = new Panel();
            this.txtMP = new TextBox();
            this.txtInfo = new TextBox();
            this.txtEl = new TextBox();
            this.txtj7 = new TextBox();
            this.txtJ4 = new TextBox();
            this.txtJ3 = new TextBox();
            this.txtJ2 = new TextBox();
            this.txtJ6 = new TextBox();
            this.txtJ5 = new TextBox();
            this.txtJ1 = new TextBox();
            this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
            this.NewSkaterToolStripMenuItem = new ToolStripMenuItem();
            this.EditSkaterToolStripMenuItem1 = new ToolStripMenuItem();
            this.InputElementToolStripMenuItem2 = new ToolStripMenuItem();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.DeleteSkaterToolStripMenuItem = new ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            ((ISupportInitialize)this.DataGridView1).BeginInit();
            this.Panel1.SuspendLayout();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.MenuStrip1.BackColor = SystemColors.Control;
            this.MenuStrip1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
            this.MenuStrip1.Items.AddRange(new ToolStripItem[9]
            {
        (ToolStripItem) this.EXITToolStripMenuItem,
        (ToolStripItem) this.ToolStripMenuItemFile,
        (ToolStripItem) this.CompetitionToolStripMenuItem,
        (ToolStripItem) this.SPEAKERSTARTLISTToolStripMenuItem,
        (ToolStripItem) this.INPUTELEMENTToolStripMenuItem,
        (ToolStripItem) this.IndTAToolStripMenuItem,
        (ToolStripItem) this.GenerateStartNoToolStripMenuItem,
        (ToolStripItem) this.WARMUPToolStripMenuItem,
        (ToolStripItem) this.EDITSKATERToolStripMenuItem
            });
            this.MenuStrip1.Location = new Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new Padding(7, 2, 0, 2);
            MenuStrip menuStrip1 = this.MenuStrip1;
            Size size1 = new Size(961, 24);
            Size size2 = size1;
            menuStrip1.Size = size2;
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            this.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem1 = this.EXITToolStripMenuItem;
            size1 = new Size(44, 20);
            Size size3 = size1;
            toolStripMenuItem1.Size = size3;
            this.EXITToolStripMenuItem.Text = "EXIT";
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[7]
            {
        (ToolStripItem) this.EntriesPDFToolStripMenuItem,
        (ToolStripItem) this.StartListPDFToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator3,
        (ToolStripItem) this.PrintEntriesToolStripMenuItem,
        (ToolStripItem) this.PrintStartlistToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator4,
        (ToolStripItem) this.ExitToolStripMenuItem1
            });
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            ToolStripMenuItem stripMenuItemFile = this.ToolStripMenuItemFile;
            size1 = new Size(42, 20);
            Size size4 = size1;
            stripMenuItemFile.Size = size4;
            this.ToolStripMenuItemFile.Text = "FILE";
            this.EntriesPDFToolStripMenuItem.Name = "EntriesPDFToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem2 = this.EntriesPDFToolStripMenuItem;
            size1 = new Size(188, 22);
            Size size5 = size1;
            toolStripMenuItem2.Size = size5;
            this.EntriesPDFToolStripMenuItem.Text = "Create Entries.PDF";
            this.StartListPDFToolStripMenuItem.Name = "StartListPDFToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem3 = this.StartListPDFToolStripMenuItem;
            size1 = new Size(188, 22);
            Size size6 = size1;
            toolStripMenuItem3.Size = size6;
            this.StartListPDFToolStripMenuItem.Text = "Create StartList.PDF";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            ToolStripSeparator toolStripSeparator3 = this.ToolStripSeparator3;
            size1 = new Size(185, 6);
            Size size7 = size1;
            toolStripSeparator3.Size = size7;
            this.PrintEntriesToolStripMenuItem.Name = "PrintEntriesToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem4 = this.PrintEntriesToolStripMenuItem;
            size1 = new Size(188, 22);
            Size size8 = size1;
            toolStripMenuItem4.Size = size8;
            this.PrintEntriesToolStripMenuItem.Text = "Print Entries";
            this.PrintStartlistToolStripMenuItem.Name = "PrintStartlistToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem5 = this.PrintStartlistToolStripMenuItem;
            size1 = new Size(188, 22);
            Size size9 = size1;
            toolStripMenuItem5.Size = size9;
            this.PrintStartlistToolStripMenuItem.Text = "Print Start List";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            ToolStripSeparator toolStripSeparator4 = this.ToolStripSeparator4;
            size1 = new Size(185, 6);
            Size size10 = size1;
            toolStripSeparator4.Size = size10;
            this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            ToolStripMenuItem toolStripMenuItem1_1 = this.ExitToolStripMenuItem1;
            size1 = new Size(188, 22);
            Size size11 = size1;
            toolStripMenuItem1_1.Size = size11;
            this.ExitToolStripMenuItem1.Text = "Exit";
            this.CompetitionToolStripMenuItem.Name = "CompetitionToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem6 = this.CompetitionToolStripMenuItem;
            size1 = new Size(112, 20);
            Size size12 = size1;
            toolStripMenuItem6.Size = size12;
            this.CompetitionToolStripMenuItem.Text = "JUDGES DETAILS";
            this.SPEAKERSTARTLISTToolStripMenuItem.Name = "SPEAKERSTARTLISTToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem7 = this.SPEAKERSTARTLISTToolStripMenuItem;
            size1 = new Size(136, 20);
            Size size13 = size1;
            toolStripMenuItem7.Size = size13;
            this.SPEAKERSTARTLISTToolStripMenuItem.Text = "SPEAKER START LIST";
            this.INPUTELEMENTToolStripMenuItem.BackColor = Color.FromArgb(128, (int)byte.MaxValue, 128);
            this.INPUTELEMENTToolStripMenuItem.Name = "INPUTELEMENTToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem8 = this.INPUTELEMENTToolStripMenuItem;
            size1 = new Size(104, 20);
            Size size14 = size1;
            toolStripMenuItem8.Size = size14;
            this.INPUTELEMENTToolStripMenuItem.Text = "INPUT ELEMENT";
            this.IndTAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
            {
        (ToolStripItem) this.GetFromIndTAToolStripMenuItem,
        (ToolStripItem) this.GetSkatersForToolStripMenuItem
            });
            this.IndTAToolStripMenuItem.Name = "IndTAToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem9 = this.IndTAToolStripMenuItem;
            size1 = new Size(53, 20);
            Size size15 = size1;
            toolStripMenuItem9.Size = size15;
            this.IndTAToolStripMenuItem.Text = "IndTA";
            this.GetFromIndTAToolStripMenuItem.Name = "GetFromIndTAToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem10 = this.GetFromIndTAToolStripMenuItem;
            size1 = new Size(159, 22);
            Size size16 = size1;
            toolStripMenuItem10.Size = size16;
            this.GetFromIndTAToolStripMenuItem.Text = "Get all skaters";
            this.GetSkatersForToolStripMenuItem.Name = "GetSkatersForToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem11 = this.GetSkatersForToolStripMenuItem;
            size1 = new Size(159, 22);
            Size size17 = size1;
            toolStripMenuItem11.Size = size17;
            this.GetSkatersForToolStripMenuItem.Text = "Get skaters for";
            this.GenerateStartNoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
            {
        (ToolStripItem) this.RandomToolStripMenuItem,
        (ToolStripItem) this.AccordingToShortProgramToolStripMenuItem
            });
            this.GenerateStartNoToolStripMenuItem.Name = "GenerateStartNoToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem12 = this.GenerateStartNoToolStripMenuItem;
            size1 = new Size(133, 20);
            Size size18 = size1;
            toolStripMenuItem12.Size = size18;
            this.GenerateStartNoToolStripMenuItem.Text = "GENERATE START NO";
            this.RandomToolStripMenuItem.Name = "RandomToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem13 = this.RandomToolStripMenuItem;
            size1 = new Size(209, 22);
            Size size19 = size1;
            toolStripMenuItem13.Size = size19;
            this.RandomToolStripMenuItem.Text = "Random";
            this.AccordingToShortProgramToolStripMenuItem.Name = "AccordingToShortProgramToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem14 = this.AccordingToShortProgramToolStripMenuItem;
            size1 = new Size(209, 22);
            Size size20 = size1;
            toolStripMenuItem14.Size = size20;
            this.AccordingToShortProgramToolStripMenuItem.Text = "According to Segment 1";
            this.WARMUPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
            {
        (ToolStripItem) this.WarmupGroupsToolStripMenuItem
            });
            this.WARMUPToolStripMenuItem.Name = "WARMUPToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem15 = this.WARMUPToolStripMenuItem;
            size1 = new Size(120, 20);
            Size size21 = size1;
            toolStripMenuItem15.Size = size21;
            this.WARMUPToolStripMenuItem.Text = "WARMUP GROUPS";
            this.WarmupGroupsToolStripMenuItem.Name = "WarmupGroupsToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem16 = this.WarmupGroupsToolStripMenuItem;
            size1 = new Size(206, 22);
            Size size22 = size1;
            toolStripMenuItem16.Size = size22;
            this.WarmupGroupsToolStripMenuItem.Text = "Create Warmup Groups";
            this.EDITSKATERToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[5]
            {
        (ToolStripItem) this.NewToolStripMenuItem,
        (ToolStripItem) this.EditToolStripMenuItem,
        (ToolStripItem) this.InputElementToolStripMenuItem1,
        (ToolStripItem) this.ToolStripSeparator2,
        (ToolStripItem) this.DeleteToolStripMenuItem
            });
            this.EDITSKATERToolStripMenuItem.Name = "EDITSKATERToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem17 = this.EDITSKATERToolStripMenuItem;
            size1 = new Size(91, 20);
            Size size23 = size1;
            toolStripMenuItem17.Size = size23;
            this.EDITSKATERToolStripMenuItem.Text = "EDIT SKATER";
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem18 = this.NewToolStripMenuItem;
            size1 = new Size(154, 22);
            Size size24 = size1;
            toolStripMenuItem18.Size = size24;
            this.NewToolStripMenuItem.Text = "New";
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem19 = this.EditToolStripMenuItem;
            size1 = new Size(154, 22);
            Size size25 = size1;
            toolStripMenuItem19.Size = size25;
            this.EditToolStripMenuItem.Text = "Edit";
            this.InputElementToolStripMenuItem1.Name = "InputElementToolStripMenuItem1";
            ToolStripMenuItem toolStripMenuItem1_2 = this.InputElementToolStripMenuItem1;
            size1 = new Size(154, 22);
            Size size26 = size1;
            toolStripMenuItem1_2.Size = size26;
            this.InputElementToolStripMenuItem1.Text = "Input Element";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator toolStripSeparator2 = this.ToolStripSeparator2;
            size1 = new Size(151, 6);
            Size size27 = size1;
            toolStripSeparator2.Size = size27;
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem20 = this.DeleteToolStripMenuItem;
            size1 = new Size(154, 22);
            Size size28 = size1;
            toolStripMenuItem20.Size = size28;
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange((DataGridViewColumn)this.Column1, (DataGridViewColumn)this.Column2, (DataGridViewColumn)this.Column3, (DataGridViewColumn)this.Column4, (DataGridViewColumn)this.Column5, (DataGridViewColumn)this.Column6, (DataGridViewColumn)this.Column7, (DataGridViewColumn)this.Column8);
            this.DataGridView1.Dock = DockStyle.Left;
            this.DataGridView1.Location = new Point(0, 24);
            this.DataGridView1.MultiSelect = false;
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ScrollBars = ScrollBars.Vertical;
            this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView dataGridView1 = this.DataGridView1;
            size1 = new Size(961, 431);
            Size size29 = size1;
            dataGridView1.Size = size29;
            this.DataGridView1.TabIndex = 1;
            this.Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = DataGridViewTriState.False;
            this.Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = DataGridViewTriState.False;
            this.Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = DataGridViewTriState.False;
            this.Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = DataGridViewTriState.False;
            this.Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = DataGridViewTriState.False;
            this.Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = DataGridViewTriState.False;
            this.Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.Resizable = DataGridViewTriState.False;
            this.Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.Resizable = DataGridViewTriState.False;
            this.Column8.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Mode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.Mode.BackColor = Color.FromArgb(128, (int)byte.MaxValue, (int)byte.MaxValue);
            this.Mode.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Mode.Location = new Point(847, 2);
            this.Mode.Name = "Mode";
            TextBox mode = this.Mode;
            size1 = new Size(115, 20);
            Size size30 = size1;
            mode.Size = size30;
            this.Mode.TabIndex = 2;
            this.Mode.TextAlign = HorizontalAlignment.Center;
            PrintPreviewDialog printPreviewDialog1_1 = this.PrintPreviewDialog1;
            size1 = new Size(0, 0);
            Size size31 = size1;
            printPreviewDialog1_1.AutoScrollMargin = size31;
            PrintPreviewDialog printPreviewDialog1_2 = this.PrintPreviewDialog1;
            size1 = new Size(0, 0);
            Size size32 = size1;
            printPreviewDialog1_2.AutoScrollMinSize = size32;
            PrintPreviewDialog printPreviewDialog1_3 = this.PrintPreviewDialog1;
            size1 = new Size(400, 300);
            Size size33 = size1;
            printPreviewDialog1_3.ClientSize = size33;
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = (Icon)componentResourceManager.GetObject("PrintPreviewDialog1.Icon");
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            this.Panel1.Controls.Add((Control)this.txtMP);
            this.Panel1.Controls.Add((Control)this.txtInfo);
            this.Panel1.Controls.Add((Control)this.txtEl);
            this.Panel1.Controls.Add((Control)this.txtj7);
            this.Panel1.Controls.Add((Control)this.txtJ4);
            this.Panel1.Controls.Add((Control)this.txtJ3);
            this.Panel1.Controls.Add((Control)this.txtJ2);
            this.Panel1.Controls.Add((Control)this.txtJ6);
            this.Panel1.Controls.Add((Control)this.txtJ5);
            this.Panel1.Controls.Add((Control)this.txtJ1);
            this.Panel1.Location = new Point(388, 217);
            this.Panel1.Name = "Panel1";
            Panel panel1 = this.Panel1;
            size1 = new Size(216, 20);
            Size size34 = size1;
            panel1.Size = size34;
            this.Panel1.TabIndex = 80;
            this.Panel1.Visible = false;
            this.txtMP.BackColor = Color.Red;
            this.txtMP.BorderStyle = BorderStyle.FixedSingle;
            this.txtMP.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtMP.ForeColor = Color.White;
            this.txtMP.Location = new Point(183, 0);
            this.txtMP.Name = "txtMP";
            TextBox txtMp = this.txtMP;
            size1 = new Size(32, 18);
            Size size35 = size1;
            txtMp.Size = size35;
            this.txtMP.TabIndex = 167;
            this.txtMP.Text = "Info2";
            this.txtMP.TextAlign = HorizontalAlignment.Center;
            this.txtInfo.BackColor = Color.Red;
            this.txtInfo.BorderStyle = BorderStyle.FixedSingle;
            this.txtInfo.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtInfo.ForeColor = Color.White;
            this.txtInfo.Location = new Point(153, 0);
            this.txtInfo.Name = "txtInfo";
            TextBox txtInfo = this.txtInfo;
            size1 = new Size(30, 18);
            Size size36 = size1;
            txtInfo.Size = size36;
            this.txtInfo.TabIndex = 166;
            this.txtInfo.Text = "Info";
            this.txtInfo.TextAlign = HorizontalAlignment.Center;
            this.txtEl.BackColor = Color.Red;
            this.txtEl.BorderStyle = BorderStyle.FixedSingle;
            this.txtEl.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtEl.ForeColor = Color.White;
            this.txtEl.Location = new Point(135, 0);
            this.txtEl.Name = "txtEl";
            TextBox txtEl = this.txtEl;
            size1 = new Size(18, 18);
            Size size37 = size1;
            txtEl.Size = size37;
            this.txtEl.TabIndex = 165;
            this.txtEl.Text = "El";
            this.txtEl.TextAlign = HorizontalAlignment.Center;
            this.txtj7.BackColor = Color.Red;
            this.txtj7.BorderStyle = BorderStyle.FixedSingle;
            this.txtj7.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtj7.ForeColor = Color.White;
            this.txtj7.Location = new Point(109, 0);
            this.txtj7.Name = "txtj7";
            TextBox txtj7 = this.txtj7;
            size1 = new Size(18, 18);
            Size size38 = size1;
            txtj7.Size = size38;
            this.txtj7.TabIndex = 164;
            this.txtj7.Text = "J7";
            this.txtj7.TextAlign = HorizontalAlignment.Center;
            this.txtj7.Visible = false;
            this.txtJ4.BackColor = Color.Red;
            this.txtJ4.BorderStyle = BorderStyle.FixedSingle;
            this.txtJ4.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtJ4.ForeColor = Color.White;
            this.txtJ4.Location = new Point(55, 0);
            this.txtJ4.Name = "txtJ4";
            TextBox txtJ4 = this.txtJ4;
            size1 = new Size(18, 18);
            Size size39 = size1;
            txtJ4.Size = size39;
            this.txtJ4.TabIndex = 163;
            this.txtJ4.Text = "J4";
            this.txtJ4.TextAlign = HorizontalAlignment.Center;
            this.txtJ4.Visible = false;
            this.txtJ3.BackColor = Color.Red;
            this.txtJ3.BorderStyle = BorderStyle.FixedSingle;
            this.txtJ3.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtJ3.ForeColor = Color.White;
            this.txtJ3.Location = new Point(37, 0);
            this.txtJ3.Name = "txtJ3";
            TextBox txtJ3 = this.txtJ3;
            size1 = new Size(18, 18);
            Size size40 = size1;
            txtJ3.Size = size40;
            this.txtJ3.TabIndex = 162;
            this.txtJ3.Text = "J3";
            this.txtJ3.TextAlign = HorizontalAlignment.Center;
            this.txtJ3.Visible = false;
            this.txtJ2.BackColor = Color.Red;
            this.txtJ2.BorderStyle = BorderStyle.FixedSingle;
            this.txtJ2.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtJ2.ForeColor = Color.White;
            this.txtJ2.Location = new Point(19, 0);
            this.txtJ2.Name = "txtJ2";
            TextBox txtJ2 = this.txtJ2;
            size1 = new Size(18, 18);
            Size size41 = size1;
            txtJ2.Size = size41;
            this.txtJ2.TabIndex = 161;
            this.txtJ2.Text = "J2";
            this.txtJ2.TextAlign = HorizontalAlignment.Center;
            this.txtJ2.Visible = false;
            this.txtJ6.BackColor = Color.Red;
            this.txtJ6.BorderStyle = BorderStyle.FixedSingle;
            this.txtJ6.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtJ6.ForeColor = Color.White;
            this.txtJ6.Location = new Point(91, 0);
            this.txtJ6.Name = "txtJ6";
            TextBox txtJ6 = this.txtJ6;
            size1 = new Size(18, 18);
            Size size42 = size1;
            txtJ6.Size = size42;
            this.txtJ6.TabIndex = 160;
            this.txtJ6.Text = "J6";
            this.txtJ6.TextAlign = HorizontalAlignment.Center;
            this.txtJ6.Visible = false;
            this.txtJ5.BackColor = Color.Red;
            this.txtJ5.BorderStyle = BorderStyle.FixedSingle;
            this.txtJ5.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtJ5.ForeColor = Color.White;
            this.txtJ5.Location = new Point(73, 0);
            this.txtJ5.Name = "txtJ5";
            TextBox txtJ5 = this.txtJ5;
            size1 = new Size(18, 18);
            Size size43 = size1;
            txtJ5.Size = size43;
            this.txtJ5.TabIndex = 159;
            this.txtJ5.Text = "J5";
            this.txtJ5.TextAlign = HorizontalAlignment.Center;
            this.txtJ5.Visible = false;
            this.txtJ1.BackColor = Color.Red;
            this.txtJ1.BorderStyle = BorderStyle.FixedSingle;
            this.txtJ1.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtJ1.ForeColor = Color.White;
            this.txtJ1.Location = new Point(1, 0);
            this.txtJ1.Name = "txtJ1";
            TextBox txtJ1 = this.txtJ1;
            size1 = new Size(18, 18);
            Size size44 = size1;
            txtJ1.Size = size44;
            this.txtJ1.TabIndex = 158;
            this.txtJ1.Text = "J1";
            this.txtJ1.TextAlign = HorizontalAlignment.Center;
            this.txtJ1.Visible = false;
            this.ContextMenuStrip1.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[5]
            {
        (ToolStripItem) this.NewSkaterToolStripMenuItem,
        (ToolStripItem) this.EditSkaterToolStripMenuItem1,
        (ToolStripItem) this.InputElementToolStripMenuItem2,
        (ToolStripItem) this.ToolStripSeparator1,
        (ToolStripItem) this.DeleteSkaterToolStripMenuItem
            });
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip contextMenuStrip1 = this.ContextMenuStrip1;
            size1 = new Size(154, 120);
            Size size45 = size1;
            contextMenuStrip1.Size = size45;
            this.NewSkaterToolStripMenuItem.Name = "NewSkaterToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem21 = this.NewSkaterToolStripMenuItem;
            size1 = new Size(153, 22);
            Size size46 = size1;
            toolStripMenuItem21.Size = size46;
            this.NewSkaterToolStripMenuItem.Text = "New Skater";
            this.EditSkaterToolStripMenuItem1.Name = "EditSkaterToolStripMenuItem1";
            ToolStripMenuItem toolStripMenuItem1_3 = this.EditSkaterToolStripMenuItem1;
            size1 = new Size(153, 22);
            Size size47 = size1;
            toolStripMenuItem1_3.Size = size47;
            this.EditSkaterToolStripMenuItem1.Text = "Edit Skater";
            this.InputElementToolStripMenuItem2.Name = "InputElementToolStripMenuItem2";
            ToolStripMenuItem toolStripMenuItem2_1 = this.InputElementToolStripMenuItem2;
            size1 = new Size(153, 22);
            Size size48 = size1;
            toolStripMenuItem2_1.Size = size48;
            this.InputElementToolStripMenuItem2.Text = "Input Element";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator toolStripSeparator1 = this.ToolStripSeparator1;
            size1 = new Size(150, 6);
            Size size49 = size1;
            toolStripSeparator1.Size = size49;
            this.DeleteSkaterToolStripMenuItem.Name = "DeleteSkaterToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem22 = this.DeleteSkaterToolStripMenuItem;
            size1 = new Size(153, 22);
            Size size50 = size1;
            toolStripMenuItem22.Size = size50;
            this.DeleteSkaterToolStripMenuItem.Text = "Delete Skater";
            this.AutoScaleDimensions = new SizeF(7f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(961, 455);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.Panel1);
            this.Controls.Add((Control)this.Mode);
            this.Controls.Add((Control)this.DataGridView1);
            this.Controls.Add((Control)this.MenuStrip1);
            this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.Name = nameof(StartListForm);
            this.Text = "START LIST";
            this.TopMost = true;
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((ISupportInitialize)this.DataGridView1).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual MenuStrip MenuStrip1
        {
            get => this._MenuStrip1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._MenuStrip1 = value;
        }

        internal virtual ToolStripMenuItem IndTAToolStripMenuItem
        {
            get => this._IndTAToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._IndTAToolStripMenuItem = value;
        }

        internal virtual ToolStripMenuItem GetFromIndTAToolStripMenuItem
        {
            get => this._GetFromIndTAToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.GetFromIndTAToolStripMenuItem_Click);
                if (this._GetFromIndTAToolStripMenuItem != null)
                    this._GetFromIndTAToolStripMenuItem.Click -= eventHandler;
                this._GetFromIndTAToolStripMenuItem = value;
                if (this._GetFromIndTAToolStripMenuItem == null)
                    return;
                this._GetFromIndTAToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem GenerateStartNoToolStripMenuItem
        {
            get => this._GenerateStartNoToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._GenerateStartNoToolStripMenuItem = value;
        }

        internal virtual ToolStripMenuItem RandomToolStripMenuItem
        {
            get => this._RandomToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.RandomToolStripMenuItem_Click);
                if (this._RandomToolStripMenuItem != null)
                    this._RandomToolStripMenuItem.Click -= eventHandler;
                this._RandomToolStripMenuItem = value;
                if (this._RandomToolStripMenuItem == null)
                    return;
                this._RandomToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem AccordingToShortProgramToolStripMenuItem
        {
            get => this._AccordingToShortProgramToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.AccordingToShortProgramToolStripMenuItem_Click);
                if (this._AccordingToShortProgramToolStripMenuItem != null)
                    this._AccordingToShortProgramToolStripMenuItem.Click -= eventHandler;
                this._AccordingToShortProgramToolStripMenuItem = value;
                if (this._AccordingToShortProgramToolStripMenuItem == null)
                    return;
                this._AccordingToShortProgramToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem ToolStripMenuItemFile
        {
            get => this._ToolStripMenuItemFile;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ToolStripMenuItemFile = value;
        }

        internal virtual TextBox Mode
        {
            get => this._Mode;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Mode = value;
        }

        internal virtual ToolStripMenuItem CompetitionToolStripMenuItem
        {
            get => this._CompetitionToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.CompetitionToolStripMenuItem_Click);
                if (this._CompetitionToolStripMenuItem != null)
                    this._CompetitionToolStripMenuItem.Click -= eventHandler;
                this._CompetitionToolStripMenuItem = value;
                if (this._CompetitionToolStripMenuItem == null)
                    return;
                this._CompetitionToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual DataGridView DataGridView1
        {
            get => this._DataGridView1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                DataGridViewRowsRemovedEventHandler removedEventHandler = new DataGridViewRowsRemovedEventHandler(this.DataGridView1_RowsRemoved);
                DataGridViewCellMouseEventHandler mouseEventHandler1 = new DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDown);
                DataGridViewRowsAddedEventHandler addedEventHandler = new DataGridViewRowsAddedEventHandler(this.DataGridView1_RowsAdded);
                DataGridViewCellEventHandler cellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
                MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.DataGridView1_MouseDoubleClick);
                if (this._DataGridView1 != null)
                {
                    this._DataGridView1.RowsRemoved -= removedEventHandler;
                    this._DataGridView1.CellMouseDown -= mouseEventHandler1;
                    this._DataGridView1.RowsAdded -= addedEventHandler;
                    this._DataGridView1.CellEndEdit -= cellEventHandler;
                    this._DataGridView1.MouseDoubleClick -= mouseEventHandler2;
                }
                this._DataGridView1 = value;
                if (this._DataGridView1 == null)
                    return;
                this._DataGridView1.RowsRemoved += removedEventHandler;
                this._DataGridView1.CellMouseDown += mouseEventHandler1;
                this._DataGridView1.RowsAdded += addedEventHandler;
                this._DataGridView1.CellEndEdit += cellEventHandler;
                this._DataGridView1.MouseDoubleClick += mouseEventHandler2;
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

        internal virtual PrintDocument PrintDocument1
        {
            get => this._PrintDocument1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                PrintPageEventHandler pageEventHandler = new PrintPageEventHandler(this.PrintDocument1_PrintPage_1);
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

        internal virtual ToolStripMenuItem EntriesPDFToolStripMenuItem
        {
            get => this._EntriesPDFToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.EntriesPDFToolStripMenuItem_Click);
                if (this._EntriesPDFToolStripMenuItem != null)
                    this._EntriesPDFToolStripMenuItem.Click -= eventHandler;
                this._EntriesPDFToolStripMenuItem = value;
                if (this._EntriesPDFToolStripMenuItem == null)
                    return;
                this._EntriesPDFToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem StartListPDFToolStripMenuItem
        {
            get => this._StartListPDFToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.StartListPDFToolStripMenuItem_Click);
                if (this._StartListPDFToolStripMenuItem != null)
                    this._StartListPDFToolStripMenuItem.Click -= eventHandler;
                this._StartListPDFToolStripMenuItem = value;
                if (this._StartListPDFToolStripMenuItem == null)
                    return;
                this._StartListPDFToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem SPEAKERSTARTLISTToolStripMenuItem
        {
            get => this._SPEAKERSTARTLISTToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.SPEAKERSTARTLISTToolStripMenuItem_Click);
                if (this._SPEAKERSTARTLISTToolStripMenuItem != null)
                    this._SPEAKERSTARTLISTToolStripMenuItem.Click -= eventHandler;
                this._SPEAKERSTARTLISTToolStripMenuItem = value;
                if (this._SPEAKERSTARTLISTToolStripMenuItem == null)
                    return;
                this._SPEAKERSTARTLISTToolStripMenuItem.Click += eventHandler;
            }
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

        internal virtual ToolStripMenuItem EDITSKATERToolStripMenuItem
        {
            get => this._EDITSKATERToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._EDITSKATERToolStripMenuItem = value;
        }

        internal virtual ToolStripMenuItem NewToolStripMenuItem
        {
            get => this._NewToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.NewToolStripMenuItem_Click);
                if (this._NewToolStripMenuItem != null)
                    this._NewToolStripMenuItem.Click -= eventHandler;
                this._NewToolStripMenuItem = value;
                if (this._NewToolStripMenuItem == null)
                    return;
                this._NewToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem EditToolStripMenuItem
        {
            get => this._EditToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.EditToolStripMenuItem_Click);
                if (this._EditToolStripMenuItem != null)
                    this._EditToolStripMenuItem.Click -= eventHandler;
                this._EditToolStripMenuItem = value;
                if (this._EditToolStripMenuItem == null)
                    return;
                this._EditToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem InputElementToolStripMenuItem1
        {
            get => this._InputElementToolStripMenuItem1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.InputElementToolStripMenuItem1_Click);
                if (this._InputElementToolStripMenuItem1 != null)
                    this._InputElementToolStripMenuItem1.Click -= eventHandler;
                this._InputElementToolStripMenuItem1 = value;
                if (this._InputElementToolStripMenuItem1 == null)
                    return;
                this._InputElementToolStripMenuItem1.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem DeleteToolStripMenuItem
        {
            get => this._DeleteToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.DeleteToolStripMenuItem_Click);
                if (this._DeleteToolStripMenuItem != null)
                    this._DeleteToolStripMenuItem.Click -= eventHandler;
                this._DeleteToolStripMenuItem = value;
                if (this._DeleteToolStripMenuItem == null)
                    return;
                this._DeleteToolStripMenuItem.Click += eventHandler;
            }
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

        internal virtual ToolStripSeparator ToolStripSeparator2
        {
            get => this._ToolStripSeparator2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ToolStripSeparator2 = value;
        }

        internal virtual ToolStripSeparator ToolStripSeparator3
        {
            get => this._ToolStripSeparator3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ToolStripSeparator3 = value;
        }

        internal virtual ToolStripMenuItem PrintEntriesToolStripMenuItem
        {
            get => this._PrintEntriesToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.PrintEntriesToolStripMenuItem_Click);
                if (this._PrintEntriesToolStripMenuItem != null)
                    this._PrintEntriesToolStripMenuItem.Click -= eventHandler;
                this._PrintEntriesToolStripMenuItem = value;
                if (this._PrintEntriesToolStripMenuItem == null)
                    return;
                this._PrintEntriesToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem PrintStartlistToolStripMenuItem
        {
            get => this._PrintStartlistToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.PrintStartlistToolStripMenuItem_Click);
                if (this._PrintStartlistToolStripMenuItem != null)
                    this._PrintStartlistToolStripMenuItem.Click -= eventHandler;
                this._PrintStartlistToolStripMenuItem = value;
                if (this._PrintStartlistToolStripMenuItem == null)
                    return;
                this._PrintStartlistToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem ExitToolStripMenuItem1
        {
            get => this._ExitToolStripMenuItem1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ExitToolStripMenuItem1_Click);
                if (this._ExitToolStripMenuItem1 != null)
                    this._ExitToolStripMenuItem1.Click -= eventHandler;
                this._ExitToolStripMenuItem1 = value;
                if (this._ExitToolStripMenuItem1 == null)
                    return;
                this._ExitToolStripMenuItem1.Click += eventHandler;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator4
        {
            get => this._ToolStripSeparator4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ToolStripSeparator4 = value;
        }

        internal virtual ToolStripMenuItem WARMUPToolStripMenuItem
        {
            get => this._WARMUPToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._WARMUPToolStripMenuItem = value;
        }

        internal virtual ToolStripMenuItem WarmupGroupsToolStripMenuItem
        {
            get => this._WarmupGroupsToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.WarmupGroupsToolStripMenuItem_Click_1);
                if (this._WarmupGroupsToolStripMenuItem != null)
                    this._WarmupGroupsToolStripMenuItem.Click -= eventHandler;
                this._WarmupGroupsToolStripMenuItem = value;
                if (this._WarmupGroupsToolStripMenuItem == null)
                    return;
                this._WarmupGroupsToolStripMenuItem.Click += eventHandler;
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

        internal virtual Panel Panel1
        {
            get => this._Panel1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Panel1 = value;
        }

        internal virtual TextBox txtInfo
        {
            get => this._txtInfo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtInfo = value;
        }

        internal virtual TextBox txtEl
        {
            get => this._txtEl;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtEl = value;
        }

        internal virtual TextBox txtj7
        {
            get => this._txtj7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtj7 = value;
        }

        internal virtual TextBox txtJ4
        {
            get => this._txtJ4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtJ4 = value;
        }

        internal virtual TextBox txtJ3
        {
            get => this._txtJ3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtJ3 = value;
        }

        internal virtual TextBox txtJ2
        {
            get => this._txtJ2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtJ2 = value;
        }

        internal virtual TextBox txtJ6
        {
            get => this._txtJ6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtJ6 = value;
        }

        internal virtual TextBox txtJ5
        {
            get => this._txtJ5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtJ5 = value;
        }

        internal virtual TextBox txtJ1
        {
            get => this._txtJ1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtJ1 = value;
        }

        internal virtual TextBox txtMP
        {
            get => this._txtMP;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtMP = value;
        }

        internal virtual ContextMenuStrip ContextMenuStrip1
        {
            get => this._ContextMenuStrip1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ContextMenuStrip1 = value;
        }

        internal virtual ToolStripMenuItem NewSkaterToolStripMenuItem
        {
            get => this._NewSkaterToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.NewSkaterToolStripMenuItem_Click);
                if (this._NewSkaterToolStripMenuItem != null)
                    this._NewSkaterToolStripMenuItem.Click -= eventHandler;
                this._NewSkaterToolStripMenuItem = value;
                if (this._NewSkaterToolStripMenuItem == null)
                    return;
                this._NewSkaterToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem EditSkaterToolStripMenuItem1
        {
            get => this._EditSkaterToolStripMenuItem1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.EditSkaterToolStripMenuItem1_Click);
                if (this._EditSkaterToolStripMenuItem1 != null)
                    this._EditSkaterToolStripMenuItem1.Click -= eventHandler;
                this._EditSkaterToolStripMenuItem1 = value;
                if (this._EditSkaterToolStripMenuItem1 == null)
                    return;
                this._EditSkaterToolStripMenuItem1.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem InputElementToolStripMenuItem2
        {
            get => this._InputElementToolStripMenuItem2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.InputElementToolStripMenuItem2_Click);
                if (this._InputElementToolStripMenuItem2 != null)
                    this._InputElementToolStripMenuItem2.Click -= eventHandler;
                this._InputElementToolStripMenuItem2 = value;
                if (this._InputElementToolStripMenuItem2 == null)
                    return;
                this._InputElementToolStripMenuItem2.Click += eventHandler;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            get => this._ToolStripSeparator1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ToolStripSeparator1 = value;
        }

        internal virtual ToolStripMenuItem DeleteSkaterToolStripMenuItem
        {
            get => this._DeleteSkaterToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.DeleteSkaterToolStripMenuItem_Click);
                if (this._DeleteSkaterToolStripMenuItem != null)
                    this._DeleteSkaterToolStripMenuItem.Click -= eventHandler;
                this._DeleteSkaterToolStripMenuItem = value;
                if (this._DeleteSkaterToolStripMenuItem == null)
                    return;
                this._DeleteSkaterToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem GetSkatersForToolStripMenuItem
        {
            get => this._GetSkatersForToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.GetSkatersForToolStripMenuItem_Click);
                if (this._GetSkatersForToolStripMenuItem != null)
                    this._GetSkatersForToolStripMenuItem.Click -= eventHandler;
                this._GetSkatersForToolStripMenuItem = value;
                if (this._GetSkatersForToolStripMenuItem == null)
                    return;
                this._GetSkatersForToolStripMenuItem.Click += eventHandler;
            }
        }

        private void StartListForm_Activated(object sender, EventArgs e)
        {
            if (!this.StartListFormMin)
                return;
            this.NewStartList();
        }

        private void StartListForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
                return;
            this.StartListFormMin = true;
        }

        private void StartListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WillExitStartListForm)
                return;
            if (Interaction.MsgBox((object)"Do you really want to exit the Start List?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.Yes)
            {
                e.Cancel = false;
                Module1.SaveCategoryFile(Module1.CategoryFileName);
                this.CloseFormsDialogs();
            }
            else
                e.Cancel = true;
        }

        private void CloseFormsDialogs()
        {
            if (Module1.IsFormOpen((Form)MyProject.Forms.DBForm))
                MyProject.Forms.DBForm.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.ElementDBDisplayForm))
                MyProject.Forms.ElementDBDisplayForm.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.JudgesDetailsForm))
                MyProject.Forms.JudgesDetailsForm.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.ElementInputForm))
                MyProject.Forms.ElementInputForm.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form6))
                MyProject.Forms.Form6.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form7))
                MyProject.Forms.Form7.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form8))
                MyProject.Forms.Form8.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.CategoryDialog))
                MyProject.Forms.CategoryDialog.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.NetworkStatusDialog))
                MyProject.Forms.NetworkStatusDialog.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.JudgesSetupDialog))
                MyProject.Forms.JudgesSetupDialog.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.ConfigurationDataDialog))
                MyProject.Forms.ConfigurationDataDialog.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.ParticipantInputDialog))
                MyProject.Forms.ParticipantInputDialog.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.IndTAEntriesForm))
                MyProject.Forms.IndTAEntriesForm.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.IceResurfacingMealBreakDialog))
                MyProject.Forms.IceResurfacingMealBreakDialog.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.HeadPageDialog))
                MyProject.Forms.HeadPageDialog.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.InputJudgesDataDialog))
                MyProject.Forms.InputJudgesDataDialog.Close();
            if (!Module1.IsFormOpen((Form)MyProject.Forms.DeductionsDialog))
                return;
            MyProject.Forms.DeductionsDialog.Close();
        }

        private void StartListForm_Load(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string[] strArray = new string[26];
                ProjectData.ClearProjectError();
                num1 = 2;
                StartListForm startListForm = this;
                startListForm.Left = MyProject.Forms.MainForm.Left;
                startListForm.Top = MyProject.Forms.MainForm.Top;
                Module1.ScanJudges = 0;
                this.WillExitStartListForm = false;
                if (Module1.WorkMode > 1)
                {
                    this.Panel1.Location = new Point(checked(this.Width - 140 - this.Panel1.Width), 2);
                    this.Panel1.Visible = true;
                    startListForm.DataGridView1.ContextMenuStrip = (ContextMenuStrip)null;
                }
                else
                {
                    this.Panel1.Visible = false;
                    startListForm.DataGridView1.ContextMenuStrip = startListForm.ContextMenuStrip1;
                    this.GetSkatersForToolStripMenuItem.Text = "Get skater for " + Strings.UCase(Module1.Category.Name).Split(' ')[0];
                }
                this.NewStartList();
                goto label_10;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("StartList_Load - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_10:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void NewStartList()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.WillExitStartListForm = false;
                switch (Module1.WorkMode)
                {
                    case 1:
                        this.Menu_Workmode_1();
                        break;
                    case 2:
                    case 3:
                        this.Menu_Workmode_2_and_3();
                        break;
                }
                this.Text = "START LIST: " + Module1.Category.Name + Module1.SubCat() + ", " + Module1.GetSegTxt(Module1.Segment);
                this.CreateStartList(Module1.TNop);
                this.Mode.Text = Module1.GetWorkMode();
                this.StartListFormMin = false;
                goto label_10;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("NewStartList - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_10:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void Menu_Workmode_1()
        {
            this.EXITToolStripMenuItem.Visible = false;
            this.IndTAToolStripMenuItem.Visible = true;
            this.GenerateStartNoToolStripMenuItem.Visible = true;
            string seg = Module1.GetSeg();
            if (Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "FF", false) == 0 || Operators.CompareString(seg, "SS", false) == 0)
            {
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                    this.AccordingToShortProgramToolStripMenuItem.Visible = false;
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    this.AccordingToShortProgramToolStripMenuItem.Visible = true;
            }
            else
                this.AccordingToShortProgramToolStripMenuItem.Visible = false;
            this.WARMUPToolStripMenuItem.Visible = true;
            this.EDITSKATERToolStripMenuItem.Visible = true;
            this.ToolStripMenuItemFile.Visible = true;
            this.EntriesPDFToolStripMenuItem.Visible = true;
            this.StartListPDFToolStripMenuItem.Visible = true;
            this.PrintEntriesToolStripMenuItem.Visible = true;
            this.PrintStartlistToolStripMenuItem.Visible = true;
            this.INPUTELEMENTToolStripMenuItem.Visible = false;
            this.SPEAKERSTARTLISTToolStripMenuItem.Visible = false;
        }

        public void Menu_Workmode_2_and_3()
        {
            this.EXITToolStripMenuItem.Visible = true;
            this.IndTAToolStripMenuItem.Visible = false;
            this.GenerateStartNoToolStripMenuItem.Visible = false;
            this.WARMUPToolStripMenuItem.Visible = false;
            this.EDITSKATERToolStripMenuItem.Visible = false;
            this.ToolStripMenuItemFile.Visible = false;
            this.EntriesPDFToolStripMenuItem.Visible = false;
            this.StartListPDFToolStripMenuItem.Visible = false;
            this.PrintEntriesToolStripMenuItem.Visible = false;
            this.PrintStartlistToolStripMenuItem.Visible = false;
            this.INPUTELEMENTToolStripMenuItem.Visible = true;
            this.SPEAKERSTARTLISTToolStripMenuItem.Visible = true;
        }

        public void CreateStartList(int TNop)
        {
            string segment = Module1.Segment;
            if (Operators.CompareString(segment, "Seg1", false) == 0)
                this.SortStartNoSeg1(TNop);
            else if (Operators.CompareString(segment, "Seg2", false) == 0)
            {
                int DNS_Seg1 = 0;
                Module1.SortStartNoSeg2(TNop, ref DNS_Seg1);
            }
            this.CreateStartList1(TNop);
        }

        public void ShowPPC()
        {
            int index1 = 1;
            do
            {
                string str = "";
                int index2 = 1;
                do
                {
                    if (Strings.Len(Module1.Vek[index1].SSS_Seg1[index2]) > 0)
                        str = str + Module1.Vek[index1].SSS_Seg1[index2] + ";";
                    checked { ++index2; }
                }
                while (index2 <= 15);
                if (Strings.Len(Module1.Vek[index1].Name.FName) > 0)
                {
                    int num = (int)Interaction.MsgBox((object)(Module1.Vek[index1].Name.FName + " " + Module1.Vek[index1].Name.LName + " - " + str), MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
                checked { ++index1; }
            }
            while (index1 <= 42);
        }

        public void CreateStartList1(int NoP)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                DataGridView dataGridView1 = this.DataGridView1;
                num3 = 4;
                this.ShowStartList(NoP);
                num3 = 5;
                switch (Module1.WorkMode)
                {
                    case 1:
                        num3 = 9;
                        dataGridView1.RowCount = 42;
                        num3 = 10;
                        break;
                    case 2:
                    case 3:
                        num3 = 13;
                        dataGridView1.RowCount = NoP;
                        num3 = 14;
                        break;
                }
                num3 = 16;
                if (NoP > 0 & NoP <= 42)
                {
                    num3 = 17;
                    int num4 = NoP;
                    int index1 = 1;
                    while (index1 <= num4)
                    {
                        num3 = 18;
                        if ((double)index1 == Conversion.Int((double)index1 / 2.0) * 2.0)
                        {
                            num3 = 19;
                            dataGridView1.Rows[checked(index1 - 1)].DefaultCellStyle.BackColor = Color.LightGray;
                        }
                        num3 = 21;
                        string segment = Module1.Segment;
                        num3 = 24;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                        {
                            num3 = 25;
                            dataGridView1.Rows[checked(index1 - 1)].Cells[0].Value = (object)Module1.Vek[index1].Startno_Seg1;
                            num3 = 26;
                            if (Module1.Vek[index1].Finished_Seg1 == 1)
                            {
                                num3 = 27;
                                dataGridView1.Rows[checked(index1 - 1)].Cells[6].Value = (object)"Yes";
                            }
                            else
                            {
                                num3 = 29;
                                num3 = 30;
                                dataGridView1.Rows[checked(index1 - 1)].Cells[6].Value = (object)"No";
                            }
                            num3 = 32;
                            if (Module1.Vek[index1].WarmUp_Seg1 > 0)
                            {
                                num3 = 33;
                                int index2 = 1;
                                do
                                {
                                    num3 = 34;
                                    if (index1 == Module1.IceArr_Seg1[index2])
                                    {
                                        num3 = 35;
                                        dataGridView1.Rows[checked(index1 - 1)].Cells[7].Value = (object)(Conversions.ToString(Module1.Vek[index1].WarmUp_Seg1) + "  - Res");
                                    }
                                    num3 = 37;
                                    if (index1 == Module1.LunchArr_Seg1[index2])
                                    {
                                        num3 = 38;
                                        dataGridView1.Rows[checked(index1 - 1)].Cells[7].Value = (object)(Conversions.ToString(Module1.Vek[index1].WarmUp_Seg1) + "  - MB");
                                    }
                                    num3 = 40;
                                    checked { ++index2; }
                                }
                                while (index2 <= 7);
                                num3 = 41;
                                if (Strings.Len(RuntimeHelpers.GetObjectValue(dataGridView1.Rows[checked(index1 - 1)].Cells[7].Value)) < 1)
                                {
                                    num3 = 42;
                                    dataGridView1.Rows[checked(index1 - 1)].Cells[7].Value = (object)Module1.Vek[index1].WarmUp_Seg1;
                                }
                                num3 = 44;
                                if ((double)Module1.Vek[index1].WarmUp_Seg1 / 2.0 == Conversion.Int((double)Module1.Vek[index1].WarmUp_Seg1 / 2.0))
                                {
                                    num3 = 45;
                                    dataGridView1.Rows[checked(index1 - 1)].Cells[7].Style.BackColor = Color.LightCyan;
                                }
                                else
                                {
                                    num3 = 47;
                                    num3 = 48;
                                    dataGridView1.Rows[checked(index1 - 1)].Cells[7].Style.BackColor = Color.LightPink;
                                }
                            }
                            else
                            {
                                num3 = 51;
                                num3 = 52;
                                dataGridView1.Rows[checked(index1 - 1)].Cells[7].Value = (object)"-";
                            }
                            num3 = 54;
                            dataGridView1.Rows[checked(index1 - 1)].Cells[4].Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            num3 = 56;
                            if (Operators.CompareString(segment, "Seg2", false) == 0)
                            {
                                num3 = 57;
                                if (Module1.Vek[index1].DNS_Seg1 > 0)
                                {
                                    num3 = 58;
                                    dataGridView1.Rows[checked(index1 - 1)].Cells[0].Value = (object)"";
                                }
                                else
                                {
                                    num3 = 60;
                                    num3 = 61;
                                    dataGridView1.Rows[checked(index1 - 1)].Cells[0].Value = (object)Module1.Vek[index1].Startno_Seg2;
                                }
                                num3 = 63;
                                if (Module1.Vek[index1].Finished_Seg2 == 1)
                                {
                                    num3 = 64;
                                    dataGridView1.Rows[checked(index1 - 1)].Cells[6].Value = (object)"Yes";
                                }
                                else
                                {
                                    num3 = 66;
                                    num3 = 67;
                                    dataGridView1.Rows[checked(index1 - 1)].Cells[6].Value = (object)"No";
                                }
                                num3 = 69;
                                if (Module1.Vek[index1].WarmUp_Seg2 > 0)
                                {
                                    num3 = 70;
                                    int index3 = 1;
                                    do
                                    {
                                        num3 = 71;
                                        if (index1 == Module1.IceArr_Seg2[index3])
                                        {
                                            num3 = 72;
                                            dataGridView1.Rows[checked(index1 - 1)].Cells[7].Value = (object)(Conversions.ToString(Module1.Vek[index1].WarmUp_Seg2) + "  - Res");
                                        }
                                        num3 = 74;
                                        if (index1 == Module1.LunchArr_Seg2[index3])
                                        {
                                            num3 = 75;
                                            dataGridView1.Rows[checked(index1 - 1)].Cells[7].Value = (object)(Conversions.ToString(Module1.Vek[index1].WarmUp_Seg2) + "  - MB");
                                        }
                                        num3 = 77;
                                        checked { ++index3; }
                                    }
                                    while (index3 <= 7);
                                    num3 = 78;
                                    if (Strings.Len(RuntimeHelpers.GetObjectValue(dataGridView1.Rows[checked(index1 - 1)].Cells[7].Value)) < 1)
                                    {
                                        num3 = 79;
                                        dataGridView1.Rows[checked(index1 - 1)].Cells[7].Value = (object)Module1.Vek[index1].WarmUp_Seg2;
                                    }
                                    num3 = 81;
                                    if ((double)Module1.Vek[index1].WarmUp_Seg2 / 2.0 == Conversion.Int((double)Module1.Vek[index1].WarmUp_Seg2 / 2.0))
                                    {
                                        num3 = 82;
                                        dataGridView1.Rows[checked(index1 - 1)].Cells[7].Style.BackColor = Color.LightCyan;
                                    }
                                    else
                                    {
                                        num3 = 84;
                                        num3 = 85;
                                        dataGridView1.Rows[checked(index1 - 1)].Cells[7].Style.BackColor = Color.LightPink;
                                    }
                                }
                                else
                                {
                                    num3 = 88;
                                    num3 = 89;
                                    dataGridView1.Rows[checked(index1 - 1)].Cells[7].Value = (object)"-";
                                }
                                num3 = 91;
                                dataGridView1.Rows[checked(index1 - 1)].Cells[5].Style.BackColor = Color.Yellow;
                            }
                        }
                        num3 = 95;
                        dataGridView1.Rows[checked(index1 - 1)].Cells[1].Value = (object)Module1.Vek[index1].Name.FName;
                        num3 = 96;
                        dataGridView1.Rows[checked(index1 - 1)].Cells[2].Value = (object)Module1.Vek[index1].Name.LName;
                        num3 = 97;
                        dataGridView1.Rows[checked(index1 - 1)].Cells[3].Value = (object)Module1.Vek[index1].Club;
                        num3 = 98;
                        switch (Module1.Vek[index1].DNS_Seg1)
                        {
                            case 1:
                                num3 = 102;
                                dataGridView1.Rows[checked(index1 - 1)].Cells[4].Value = (object)"DNS";
                                break;
                            case 2:
                                num3 = 105;
                                dataGridView1.Rows[checked(index1 - 1)].Cells[4].Value = (object)"WD";
                                break;
                            case 3:
                                num3 = 108;
                                dataGridView1.Rows[checked(index1 - 1)].Cells[4].Value = (object)"DNF";
                                break;
                            case 4:
                                num3 = 111;
                                dataGridView1.Rows[checked(index1 - 1)].Cells[4].Value = (object)"DQ";
                                break;
                            default:
                                num3 = 114;
                                dataGridView1.Rows[checked(index1 - 1)].Cells[4].Value = (object)"";
                                break;
                        }
                        num3 = 116;
                        switch (Module1.Vek[index1].DNS_Seg2)
                        {
                            case 1:
                                num3 = 120;
                                dataGridView1.Rows[checked(index1 - 1)].Cells[5].Value = (object)"DNS";
                                break;
                            case 2:
                                num3 = 123;
                                dataGridView1.Rows[checked(index1 - 1)].Cells[5].Value = (object)"WD";
                                break;
                            case 3:
                                num3 = 126;
                                dataGridView1.Rows[checked(index1 - 1)].Cells[5].Value = (object)"DNF";
                                break;
                            case 4:
                                num3 = 129;
                                dataGridView1.Rows[checked(index1 - 1)].Cells[5].Value = (object)"DQ";
                                break;
                            default:
                                num3 = 132;
                                dataGridView1.Rows[checked(index1 - 1)].Cells[5].Value = (object)"";
                                break;
                        }
                        num3 = 134;
                        if (Operators.ConditionalCompareObjectEqual(dataGridView1.Rows[checked(index1 - 1)].Cells[6].Value, (object)"Yes", false))
                        {
                            num3 = 135;
                            dataGridView1.Rows[checked(index1 - 1)].Cells[6].Style.BackColor = Color.LightGreen;
                        }
                        num3 = 137;
                        checked { ++index1; }
                    }
                }
                num3 = 139;
                int num5 = checked(NoP - 1);
                int index = 0;
                while (index <= num5)
                {
                    num3 = 140;
                    if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridView1.Rows[index].Cells[6].Value, (object)"No", false), Operators.CompareObjectNotEqual(dataGridView1.Rows[index].Cells[4].Value, (object)"DNS", false)), Operators.CompareObjectNotEqual(dataGridView1.Rows[index].Cells[5].Value, (object)"DNS", false)), Operators.CompareObjectNotEqual(dataGridView1.Rows[index].Cells[4].Value, (object)"WD", false)), Operators.CompareObjectNotEqual(dataGridView1.Rows[index].Cells[5].Value, (object)"WD", false)), Operators.CompareObjectNotEqual(dataGridView1.Rows[index].Cells[4].Value, (object)"DNF", false)), Operators.CompareObjectNotEqual(dataGridView1.Rows[index].Cells[5].Value, (object)"DNF", false)), Operators.CompareObjectNotEqual(dataGridView1.Rows[index].Cells[4].Value, (object)"DQ", false)), Operators.CompareObjectNotEqual(dataGridView1.Rows[index].Cells[5].Value, (object)"DQ", false))))
                    {
                        num3 = 141;
                        dataGridView1.Rows[index].Cells[0].Selected = true;
                        break;
                    }
                    num3 = 144;
                    checked { ++index; }
                }
                num3 = 145;
                this.F2Height = checked(dataGridView1.RowCount * 22 + dataGridView1.ColumnHeadersHeight + dataGridView1.Location.Y + Module1.HC);
                num3 = 146;
                if (this.F2Height < checked(Screen.PrimaryScreen.WorkingArea.Height - 50))
                {
                    num3 = 147;
                    this.Height = this.F2Height;
                    num3 = 148;
                    this.DataGridView1.Width = this.DGW1width;
                    num3 = 149;
                    this.Width = checked(this.DGW1width + Module1.WC);
                }
                else
                {
                    num3 = 151;
                    num3 = 152;
                    this.Height = checked(Screen.PrimaryScreen.WorkingArea.Height - 50);
                    num3 = 153;
                    this.DataGridView1.Width = checked(this.DGW1width + Module1.WC1);
                    num3 = 154;
                    this.Width = checked(this.DGW1width + Module1.WC2);
                }
                num3 = 156;
                this.widthcorr = true;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void StartListForm_SizeChanged(object sender, EventArgs e)
        {
            if (!this.widthcorr)
                return;
            if (this.Height < this.F2Height)
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

        public void ShowStartList(int TNoP)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                dataGridView1.Rows.Clear();
                dataGridView1.ColumnHeadersVisible = true;
                dataGridView1.ColumnCount = 8;
                dataGridView1.Columns[0].HeaderText = "Start no";
                dataGridView1.Columns[1].HeaderText = "First Name";
                dataGridView1.Columns[2].HeaderText = "Surname";
                dataGridView1.Columns[3].HeaderText = "Club";
                dataGridView1.Columns[4].HeaderText = "DNS/WD/DNF Seg. 1";
                dataGridView1.Columns[5].HeaderText = "DNS/WD/DNF Seg. 2";
                dataGridView1.Columns[6].HeaderText = "Finished";
                dataGridView1.Columns[7].HeaderText = "Group";
                dataGridView1.Width = 980;
                this.DGW1width = dataGridView1.Width;
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].Width = 200;
                dataGridView1.Columns[2].Width = 200;
                dataGridView1.Columns[3].Width = 200;
                dataGridView1.Columns[4].Width = 95;
                dataGridView1.Columns[5].Width = 95;
                dataGridView1.Columns[6].Width = 70;
                dataGridView1.Columns[7].Width = 70;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.ReadOnly = true;
                dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.Width = checked(this.DGW1width + Module1.WC);
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ShowStartList - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void RandomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossibleStartListForm())
                return;
            string segment = Module1.Segment;
            if (Operators.CompareString(segment, "Seg1", false) == 0)
            {
                this.SortListSeg1DNS(Module1.TNop);
                this.RandomStartNo(checked(Module1.TNop - Module1.DNS_Seg1), Module1.TNop);
            }
            else if (Operators.CompareString(segment, "Seg2", false) == 0)
            {
                this.SortListSeg2DNS(Module1.TNop);
                this.RandomStartNo(checked(Module1.TNop - Module1.DNS_Seg1 - Module1.DNS_Seg2), Module1.TNop);
            }
            else
            {
                int num = (int)Interaction.MsgBox((object)"Please select a category and program!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        public void RandomStartNo(int NoSkater, int TotNoP)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (NoSkater > 0)
                {
                    bool flag1 = false;
                    VBMath.Randomize();
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        int num3 = NoSkater;
                        int index1 = 1;
                        while (index1 <= num3)
                        {
                            if (Module1.Vek[index1].Startno_Seg1 > 0)
                                flag1 = true;
                            checked { ++index1; }
                        }
                        if (flag1)
                        {
                            if (Interaction.MsgBox((object)"Do you really want to generate new start numbers?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                                goto label_62;
                        }
                        int index2 = 1;
                        int num4 = NoSkater;
                        int index3 = 1;
                        while (index3 <= num4)
                        {
                            Module1.Vek[index3].Startno_Seg1 = 0;
                            checked { ++index3; }
                        }
                        while (index2 <= NoSkater)
                        {
                            int num5 = checked((int)Math.Round(unchecked((double)Conversion.Int((float)NoSkater * VBMath.Rnd()) + 1.0)));
                            bool flag2 = false;
                            int num6 = checked(index2 - 1);
                            int index4 = 1;
                            while (index4 <= num6)
                            {
                                if (num5 == Module1.Vek[index4].Startno_Seg1)
                                    flag2 = true;
                                checked { ++index4; }
                            }
                            if (!flag2)
                            {
                                Module1.Vek[index2].Startno_Seg1 = num5;
                                checked { ++index2; }
                            }
                        }
                        if (TotNoP > NoSkater)
                        {
                            int num7 = checked(NoSkater + 1);
                            int num8 = TotNoP;
                            int index5 = num7;
                            while (index5 <= num8)
                            {
                                Module1.Vek[index5].Startno_Seg1 = 0;
                                checked { ++index5; }
                            }
                        }
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        int tnop = Module1.TNop;
                        int index6 = 1;
                        while (index6 <= tnop)
                        {
                            if (Module1.Vek[index6].Startno_Seg1 > 0 & Module1.Vek[index6].DNS_Seg1 == 0 & Module1.Vek[index6].Finished_Seg1 == 0 & Module1.Vek[index6].DNS_Seg2 == 0)
                            {
                                int num9 = (int)Interaction.MsgBox((object)"Segment 1 has to be completed!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                goto label_62;
                            }
                            else
                                checked { ++index6; }
                        }
                        int num10 = NoSkater;
                        int index7 = 1;
                        while (index7 <= num10)
                        {
                            if (Module1.Vek[index7].Startno_Seg2 > 0)
                                flag1 = true;
                            checked { ++index7; }
                        }
                        if (flag1)
                        {
                            if (Interaction.MsgBox((object)"Do you really want to generate new start numbers?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                                goto label_62;
                        }
                        int index8 = 1;
                        int num11 = NoSkater;
                        int index9 = 1;
                        while (index9 <= num11)
                        {
                            Module1.Vek[index9].Startno_Seg2 = 0;
                            checked { ++index9; }
                        }
                        while (index8 <= NoSkater)
                        {
                            int num12 = checked((int)Math.Round((double)Conversion.Int(unchecked((float)((double)checked(NoSkater - 1 + 1) * (double)VBMath.Rnd() + 1.0)))));
                            bool flag3 = false;
                            int num13 = checked(index8 - 1);
                            int index10 = 1;
                            while (index10 <= num13)
                            {
                                if (num12 == Module1.Vek[index10].Startno_Seg2)
                                    flag3 = true;
                                checked { ++index10; }
                            }
                            if (!flag3)
                            {
                                Module1.Vek[index8].Startno_Seg2 = num12;
                                checked { ++index8; }
                            }
                        }
                        if (TotNoP > NoSkater)
                        {
                            int num14 = checked(NoSkater + 1);
                            int num15 = TotNoP;
                            int index11 = num14;
                            while (index11 <= num15)
                            {
                                Module1.Vek[index11].Startno_Seg2 = 0;
                                checked { ++index11; }
                            }
                        }
                    }
                    else
                    {
                        int num16 = (int)Interaction.MsgBox((object)"Please select a category and program!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    }
                    this.CreateStartList(Module1.TNop);
                    Module1.SaveCategoryFile(Module1.CategoryFileName);
                    if (Interaction.MsgBox((object)"Do you want to create warmup groups?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.Yes)
                    {
                        this.Schedule(1);
                        goto label_62;
                    }
                    else
                        goto label_62;
                }
                else
                {
                    int num17 = (int)Interaction.MsgBox((object)"Check no. of skaters in the startlist!\r\nThe program in segment 1 has to be completed!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    goto label_62;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num18 = (int)Interaction.MsgBox((object)("RandomStartNo - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_62:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void SortListSeg1DNS(int NoOfSkater)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                Module1.DNS_Seg1 = 0;
                num3 = 3;
                int num4 = NoOfSkater;
                int index1 = 1;
                while (index1 <= num4)
                {
                    num3 = 4;
                    if (Module1.Vek[index1].DNS_Seg1 > 0)
                    {
                        num3 = 5;
                        checked { ++Module1.DNS_Seg1; }
                    }
                    num3 = 7;
                    checked { ++index1; }
                }
                num3 = 8;
                int num5 = checked(NoOfSkater - 1);
                int index2 = 1;
                while (index2 <= num5)
                {
                    num3 = 9;
                    Module1.Participant participant = Module1.Vek[index2];
                    num3 = 10;
                    int index3 = index2;
                    num3 = 11;
                    int num6 = checked(index2 + 1);
                    int num7 = NoOfSkater;
                    int index4 = num6;
                    while (index4 <= num7)
                    {
                        num3 = 12;
                        if (Module1.Vek[index4].DNS_Seg1 < participant.DNS_Seg1)
                        {
                            num3 = 13;
                            participant = Module1.Vek[index4];
                            num3 = 14;
                            index3 = index4;
                        }
                        num3 = 16;
                        checked { ++index4; }
                    }
                    num3 = 17;
                    Module1.Vek[index3] = Module1.Vek[index2];
                    num3 = 18;
                    Module1.Vek[index2] = participant;
                    num3 = 19;
                    checked { ++index2; }
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

        public void SortListSeg2DNS(int NoOfSkater)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Module1.DNS_Seg1 = 0;
                int num3 = NoOfSkater;
                int index1 = 1;
                while (index1 <= num3)
                {
                    if (Operators.CompareString(Module1.OpenDB[Module1.PcIndex].Segment_1, "S", false) == 0 | Operators.CompareString(Module1.OpenDB[Module1.PcIndex].Segment_1, "F", false) == 0)
                    {
                        if (Module1.Vek[index1].Finished_Seg1 == 0 & Module1.Vek[index1].DNS_Seg1 == 0)
                        {
                            int num4 = (int)Interaction.MsgBox((object)("Skater: " + Module1.Vek[index1].Name.FName + " " + Module1.Vek[index1].Name.LName + "\r\nhas not finished segment 1!"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            if (Module1.Vek[index1].DNS_Seg1 > 0)
                                checked { ++Module1.DNS_Seg1; }
                        }
                    }
                    else if (Module1.Vek[index1].DNS_Seg1 > 0)
                        checked { ++Module1.DNS_Seg1; }
                    checked { ++index1; }
                }
                int num5 = checked(NoOfSkater - 1);
                int index2 = 1;
                while (index2 <= num5)
                {
                    Module1.Participant participant = Module1.Vek[index2];
                    int index3 = index2;
                    int num6 = checked(index2 + 1);
                    int num7 = NoOfSkater;
                    int index4 = num6;
                    while (index4 <= num7)
                    {
                        if (Operators.CompareString(Module1.OpenDB[Module1.PcIndex].Segment_1, "S", false) == 0 | Operators.CompareString(Module1.OpenDB[Module1.PcIndex].Segment_1, "F", false) == 0)
                        {
                            if (Module1.Vek[index4].Finished_Seg1 > participant.Finished_Seg1 | Module1.Vek[index4].DNS_Seg1 < participant.DNS_Seg1)
                            {
                                participant = Module1.Vek[index4];
                                index3 = index4;
                            }
                        }
                        else if (Module1.Vek[index4].DNS_Seg1 < participant.DNS_Seg1)
                        {
                            participant = Module1.Vek[index4];
                            index3 = index4;
                        }
                        checked { ++index4; }
                    }
                    Module1.Vek[index3] = Module1.Vek[index2];
                    Module1.Vek[index2] = participant;
                    checked { ++index2; }
                }
                Module1.DNS_Seg2 = 0;
                int num8 = checked(NoOfSkater - Module1.DNS_Seg1);
                int index5 = 1;
                while (index5 <= num8)
                {
                    if (Module1.Vek[index5].DNS_Seg2 > 0)
                        checked { ++Module1.DNS_Seg2; }
                    checked { ++index5; }
                }
                int num9 = checked(NoOfSkater - 1 - Module1.DNS_Seg1);
                int index6 = 1;
                while (index6 <= num9)
                {
                    Module1.Participant participant = Module1.Vek[index6];
                    int index7 = index6;
                    int num10 = checked(index6 + 1);
                    int num11 = checked(NoOfSkater - Module1.DNS_Seg1);
                    int index8 = num10;
                    while (index8 <= num11)
                    {
                        if (Module1.Vek[index8].DNS_Seg2 < participant.DNS_Seg2)
                        {
                            participant = Module1.Vek[index8];
                            index7 = index8;
                        }
                        checked { ++index8; }
                    }
                    Module1.Vek[index7] = Module1.Vek[index6];
                    Module1.Vek[index6] = participant;
                    checked { ++index6; }
                }
                goto label_39;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num12 = (int)Interaction.MsgBox((object)("SortListSeg2DNS - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_39:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void SortStartNoSeg1(int NoOfSkater)
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
                int num5 = NoOfSkater;
                int index1 = 1;
                while (index1 <= num5)
                {
                    num3 = 4;
                    if (Module1.Vek[index1].Startno_Seg1 < 1)
                    {
                        num3 = 5;
                        checked { ++num4; }
                    }
                    num3 = 7;
                    checked { ++index1; }
                }
                num3 = 8;
                int num6 = checked(NoOfSkater - 1);
                int index2 = 1;
                while (index2 <= num6)
                {
                    num3 = 9;
                    Module1.Participant participant = Module1.Vek[index2];
                    num3 = 10;
                    int index3 = index2;
                    num3 = 11;
                    int num7 = checked(index2 + 1);
                    int num8 = NoOfSkater;
                    int index4 = num7;
                    while (index4 <= num8)
                    {
                        num3 = 12;
                        if (Module1.Vek[index4].Startno_Seg1 > participant.Startno_Seg1)
                        {
                            num3 = 13;
                            participant = Module1.Vek[index4];
                            num3 = 14;
                            index3 = index4;
                        }
                        num3 = 16;
                        checked { ++index4; }
                    }
                    num3 = 17;
                    Module1.Vek[index3] = Module1.Vek[index2];
                    num3 = 18;
                    Module1.Vek[index2] = participant;
                    num3 = 19;
                    checked { ++index2; }
                }
                num3 = 20;
                int num9 = checked(NoOfSkater - 1 - num4);
                int index5 = 1;
                while (index5 <= num9)
                {
                    num3 = 21;
                    Module1.Participant participant = Module1.Vek[index5];
                    num3 = 22;
                    int index6 = index5;
                    num3 = 23;
                    int num10 = checked(index5 + 1);
                    int num11 = checked(NoOfSkater - num4);
                    int index7 = num10;
                    while (index7 <= num11)
                    {
                        num3 = 24;
                        if ((double)Module1.Vek[index7].Startno_Seg1 < (double)participant.Startno_Seg1)
                        {
                            num3 = 25;
                            participant = Module1.Vek[index7];
                            num3 = 26;
                            index6 = index7;
                        }
                        num3 = 28;
                        checked { ++index7; }
                    }
                    num3 = 29;
                    Module1.Vek[index6] = Module1.Vek[index5];
                    num3 = 30;
                    Module1.Vek[index5] = participant;
                    num3 = 31;
                    checked { ++index5; }
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

        private void AccordingToShortProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossibleStartListForm())
                return;
            if (Operators.CompareString(Module1.Segment, "Seg2", false) == 0)
            {
                string seg = Module1.GetSeg();
                if (Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "FF", false) == 0 || Operators.CompareString(seg, "SS", false) == 0)
                {
                    int tnop = Module1.TNop;
                    int index = 1;
                    while (index <= tnop)
                    {
                        if (Module1.Vek[index].Startno_Seg1 > 0 & Module1.Vek[index].DNS_Seg1 == 0 & Module1.Vek[index].Finished_Seg1 == 0 & Module1.Vek[index].DNS_Seg2 == 0)
                        {
                            int num = (int)Interaction.MsgBox((object)"Segment 1 has to be completed!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            return;
                        }
                        checked { ++index; }
                    }
                    Module1.SortListSeg1(Module1.TNop);
                    this.SortListSeg2DNS(Module1.TNop);
                    Module1.Seg1Pl(checked(Module1.TNop - Module1.DNS_Seg1));
                    this.GenStartNoFree(checked(Module1.TNop - Module1.DNS_Seg1 - Module1.DNS_Seg2), Module1.TNop);
                }
                else
                {
                    int num1 = (int)Interaction.MsgBox((object)"Only possible for Segment 2 if results from Segment 1 exist!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
            }
            else
            {
                int num2 = (int)Interaction.MsgBox((object)"Only possible for Segment 2!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        public void GenStartNoFree(int NoSkater, int TotNoP)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                if (NoSkater > 0)
                {
                    num3 = 3;
                    Module1.SortListSeg1(NoSkater);
                    num3 = 4;
                    bool flag = false;
                    num3 = 5;
                    int num4 = NoSkater;
                    int index1 = 1;
                    while (index1 <= num4)
                    {
                        num3 = 6;
                        if (Module1.Vek[index1].Startno_Seg2 > 0)
                        {
                            num3 = 7;
                            flag = true;
                        }
                        num3 = 9;
                        checked { ++index1; }
                    }
                    num3 = 10;
                    if (flag)
                    {
                        num3 = 11;
                        int num5 = (int)Interaction.MsgBox((object)"Do you really want to generate new start numbers?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        num3 = 12;
                        if (num5 == 7)
                            goto label_22;
                    }
                    num3 = 16;
                    int num6 = NoSkater;
                    int index2 = 1;
                    while (index2 <= num6)
                    {
                        num3 = 17;
                        Module1.Vek[index2].Startno_Seg2 = checked(NoSkater + 1 - index2);
                        num3 = 18;
                        checked { ++index2; }
                    }
                    num3 = 19;
                    if (TotNoP > NoSkater)
                    {
                        num3 = 20;
                        int num7 = checked(NoSkater + 1);
                        int num8 = TotNoP;
                        int index3 = num7;
                        while (index3 <= num8)
                        {
                            num3 = 21;
                            Module1.Vek[index3].Startno_Seg2 = 0;
                            num3 = 22;
                            checked { ++index3; }
                        }
                    }
                    num3 = 24;
                    this.CreateStartList(TotNoP);
                    num3 = 25;
                    int num9 = (int)Interaction.MsgBox((object)"Do you want to create warmup groups and\r\nsave everything in the the database?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    num3 = 26;
                    if (num9 == 6)
                    {
                        num3 = 27;
                        this.Schedule(1);
                    }
                }
                else
                {
                    num3 = 30;
                    num3 = 31;
                    int num10 = (int)Interaction.MsgBox((object)"Check no. of skaters in the startlist!\r\nThe program in segment 1 has to be completed!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            label_22:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void ElementInput(int par)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (Module1.IsFormOpen((Form)MyProject.Forms.ElementInputForm))
                    MyProject.Forms.ElementInputForm.Close();
                int index = checked(this.DataGridView1.CurrentCellAddress.Y + 1);
                if (index > 0)
                {
                    switch (Module1.WorkMode)
                    {
                        case 1:
                            Module1.PNo = index;
                            break;
                        case 2:
                        case 3:
                            if (par != 4)
                            {
                                string segment = Module1.Segment;
                                if (Operators.CompareString(segment, "Seg1", false) == 0)
                                {
                                    if (Module1.Vek[index].Startno_Seg1 < 1)
                                    {
                                        int num3 = (int)Interaction.MsgBox((object)"Start number is missing!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                        goto label_30;
                                    }
                                    else
                                    {
                                        if (Module1.Vek[index].Finished_Seg1 > 0)
                                        {
                                            if (Interaction.MsgBox((object)"The program is already completed!\r\nDo you want to continue?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                                                goto label_30;
                                        }
                                        if (Module1.Vek[index].DNS_Seg1 > 0)
                                        {
                                            if (Interaction.MsgBox((object)"The Skater has been marked as DNS, WD, DNF or DQ!\r\nDo you want to continue?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                                                goto label_30;
                                        }
                                    }
                                }
                                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                                {
                                    if (Module1.Vek[index].Startno_Seg2 < 1)
                                    {
                                        int num4 = (int)Interaction.MsgBox((object)"Start number is missing!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                        goto label_30;
                                    }
                                    else
                                    {
                                        if (Module1.Vek[index].Finished_Seg2 > 0)
                                        {
                                            if (Interaction.MsgBox((object)"The program is already completed!\r\nDo you want to continue?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                                                goto label_30;
                                        }
                                        if (Module1.Vek[index].DNS_Seg1 > 0 | Module1.Vek[index].DNS_Seg2 > 0)
                                        {
                                            if (Interaction.MsgBox((object)"The Skater has been marked as DNS, WD, DNF or DQ!\r\nDo you want to continue?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                                                goto label_30;
                                        }
                                    }
                                }
                                Module1.PNo = index;
                                break;
                            }
                            break;
                    }
                    if (Module1.WorkMode == 2 & par == 2)
                        this.ClearData(Module1.PNo);
                    this.TopMost = false;
                    MyProject.Forms.ElementInputForm.OpName.Text = Module1.Vek[Module1.PNo].Name.FName + " " + Module1.Vek[Module1.PNo].Name.LName;
                    MyProject.Forms.ElementInputForm.OpClub.Text = Module1.Vek[Module1.PNo].Club;
                    MyProject.Forms.ElementInputForm.Show();
                    goto label_30;
                }
                else
                    goto label_30;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("ElementInput - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_30:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void ClearData(int skater)
        {
            Module1.Participant[] vek = Module1.Vek;
            int index = skater;
            string segment = Module1.Segment;
            if (Operators.CompareString(segment, "Seg1", false) == 0)
            {
                vek[index].J_Seg1.EE = new int[16, 8];
                vek[index].J_Seg1.PC = new double[16, 8];
                vek[index].J_Seg1.Deduction = new long[8];
                vek[index].Score_Seg1 = 0.0;
                vek[index].TES_Seg1 = 0.0;
                vek[index].PCS_Seg1 = 0.0;
                vek[index].Deductions_Seg1 = 0L;
                vek[index].Falls_seg1 = 0;
                vek[index].Bonus_Seg1 = 0;
            }
            else
            {
                if (Operators.CompareString(segment, "Seg2", false) != 0)
                    return;
                vek[index].J_Seg2.EE = new int[16, 8];
                vek[index].J_Seg2.PC = new double[16, 8];
                vek[index].J_Seg2.Deduction = new long[8];
                vek[index].Score_Seg2 = 0.0;
                vek[index].TES_Seg2 = 0.0;
                vek[index].PCS_Seg2 = 0.0;
                vek[index].Deductions_Seg2 = 0L;
                vek[index].Falls_seg2 = 0;
                vek[index].Bonus_Seg2 = 0;
            }
        }

        private void DNSChange(int row, int i)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                string seg = Module1.GetSeg();
                if (Operators.CompareString(seg, "0S", false) == 0 || Operators.CompareString(seg, "0F", false) == 0)
                {
                    object Left = dataGridView1.Rows[row].Cells[5].Value;
                    if (Operators.ConditionalCompareObjectEqual(Left, (object)"", false))
                    {
                        dataGridView1.Rows[row].Cells[5].Value = (object)"DNS";
                        Module1.Vek[i].DNS_Seg2 = 1;
                        goto label_54;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(Left, (object)"DNS", false))
                    {
                        dataGridView1.Rows[row].Cells[5].Value = (object)"WD";
                        Module1.Vek[i].DNS_Seg2 = 2;
                        goto label_54;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(Left, (object)"WD", false))
                    {
                        dataGridView1.Rows[row].Cells[5].Value = (object)"DNF";
                        Module1.Vek[i].DNS_Seg2 = 3;
                        goto label_54;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(Left, (object)"DNF", false))
                    {
                        dataGridView1.Rows[row].Cells[5].Value = (object)"DQ";
                        Module1.Vek[i].DNS_Seg2 = 4;
                        goto label_54;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(Left, (object)"DQ", false))
                    {
                        dataGridView1.Rows[row].Cells[5].Value = (object)"";
                        Module1.Vek[i].DNS_Seg2 = 0;
                        goto label_54;
                    }
                    else
                        goto label_54;
                }
                else if (Operators.CompareString(seg, "S0", false) == 0 || Operators.CompareString(seg, "F0", false) == 0)
                {
                    object Left = dataGridView1.Rows[row].Cells[4].Value;
                    if (Operators.ConditionalCompareObjectEqual(Left, (object)"", false))
                    {
                        dataGridView1.Rows[row].Cells[4].Value = (object)"DNS";
                        Module1.Vek[i].DNS_Seg1 = 1;
                        goto label_54;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(Left, (object)"DNS", false))
                    {
                        dataGridView1.Rows[row].Cells[4].Value = (object)"WD";
                        Module1.Vek[i].DNS_Seg1 = 2;
                        goto label_54;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(Left, (object)"WD", false))
                    {
                        dataGridView1.Rows[row].Cells[4].Value = (object)"DNF";
                        Module1.Vek[i].DNS_Seg1 = 3;
                        goto label_54;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(Left, (object)"DNF", false))
                    {
                        dataGridView1.Rows[row].Cells[4].Value = (object)"DQ";
                        Module1.Vek[i].DNS_Seg1 = 4;
                        goto label_54;
                    }
                    else if (Operators.ConditionalCompareObjectEqual(Left, (object)"DQ", false))
                    {
                        dataGridView1.Rows[row].Cells[4].Value = (object)"";
                        Module1.Vek[i].DNS_Seg1 = 0;
                        goto label_54;
                    }
                    else
                        goto label_54;
                }
                else if (Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "FF", false) == 0 || Operators.CompareString(seg, "SS", false) == 0)
                {
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        object Left = dataGridView1.Rows[row].Cells[4].Value;
                        if (Operators.ConditionalCompareObjectEqual(Left, (object)"", false))
                        {
                            dataGridView1.Rows[row].Cells[4].Value = (object)"DNS";
                            dataGridView1.Rows[row].Cells[5].Value = (object)"DNS";
                            Module1.Vek[i].DNS_Seg1 = 1;
                            Module1.Vek[i].DNS_Seg2 = 1;
                            goto label_54;
                        }
                        else if (Operators.ConditionalCompareObjectEqual(Left, (object)"DNS", false))
                        {
                            dataGridView1.Rows[row].Cells[4].Value = (object)"WD";
                            dataGridView1.Rows[row].Cells[5].Value = (object)"WD";
                            Module1.Vek[i].DNS_Seg1 = 2;
                            Module1.Vek[i].DNS_Seg2 = 2;
                            goto label_54;
                        }
                        else if (Operators.ConditionalCompareObjectEqual(Left, (object)"WD", false))
                        {
                            dataGridView1.Rows[row].Cells[4].Value = (object)"DNF";
                            dataGridView1.Rows[row].Cells[5].Value = (object)"DNF";
                            Module1.Vek[i].DNS_Seg1 = 3;
                            Module1.Vek[i].DNS_Seg2 = 3;
                            goto label_54;
                        }
                        else if (Operators.ConditionalCompareObjectEqual(Left, (object)"DNF", false))
                        {
                            dataGridView1.Rows[row].Cells[4].Value = (object)"DQ";
                            dataGridView1.Rows[row].Cells[5].Value = (object)"DQ";
                            Module1.Vek[i].DNS_Seg1 = 4;
                            Module1.Vek[i].DNS_Seg2 = 4;
                            goto label_54;
                        }
                        else if (Operators.ConditionalCompareObjectEqual(Left, (object)"DQ", false))
                        {
                            dataGridView1.Rows[row].Cells[4].Value = (object)"";
                            dataGridView1.Rows[row].Cells[5].Value = (object)"";
                            Module1.Vek[i].DNS_Seg1 = 0;
                            Module1.Vek[i].DNS_Seg2 = 0;
                            goto label_54;
                        }
                        else
                            goto label_54;
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        if (Module1.Vek[i].DNS_Seg1 == 0)
                        {
                            object Left = dataGridView1.Rows[row].Cells[5].Value;
                            if (Operators.ConditionalCompareObjectEqual(Left, (object)"", false))
                            {
                                dataGridView1.Rows[row].Cells[5].Value = (object)"DNS";
                                Module1.Vek[i].DNS_Seg2 = 1;
                                goto label_54;
                            }
                            else if (Operators.ConditionalCompareObjectEqual(Left, (object)"DNS", false))
                            {
                                dataGridView1.Rows[row].Cells[5].Value = (object)"WD";
                                Module1.Vek[i].DNS_Seg2 = 2;
                                goto label_54;
                            }
                            else if (Operators.ConditionalCompareObjectEqual(Left, (object)"WD", false))
                            {
                                dataGridView1.Rows[row].Cells[5].Value = (object)"DNF";
                                Module1.Vek[i].DNS_Seg2 = 3;
                                goto label_54;
                            }
                            else if (Operators.ConditionalCompareObjectEqual(Left, (object)"DNF", false))
                            {
                                dataGridView1.Rows[row].Cells[5].Value = (object)"DQ";
                                Module1.Vek[i].DNS_Seg2 = 4;
                                goto label_54;
                            }
                            else if (Operators.ConditionalCompareObjectEqual(Left, (object)"DQ", false))
                            {
                                dataGridView1.Rows[row].Cells[5].Value = (object)"";
                                Module1.Vek[i].DNS_Seg2 = 0;
                                goto label_54;
                            }
                            else
                                goto label_54;
                        }
                        else
                            goto label_54;
                    }
                    else
                    {
                        int num3 = (int)Interaction.MsgBox((object)"Select a program!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_54;
                    }
                }
                else
                {
                    int num4 = (int)Interaction.MsgBox((object)"Select a program!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    goto label_54;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("DNSChange - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_54:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                Point currentCellAddress = dataGridView1.CurrentCellAddress;
                int y = currentCellAddress.Y;
                currentCellAddress = dataGridView1.CurrentCellAddress;
                int x = currentCellAddress.X;
                switch (Module1.WorkMode)
                {
                    case 1:
                        switch (x)
                        {
                            case 4:
                                if (Operators.CompareString(Module1.Segment, "Seg1", false) == 0 & (Operators.CompareString(Module1.GetSeg(), "SF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "FF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "F0", false) == 0 | Operators.CompareString(Module1.GetSeg(), "S0", false) == 0 | Operators.CompareString(Module1.GetSeg(), "SS", false) == 0))
                                {
                                    this.DNSChange(y, checked(y + 1));
                                    dataGridView1.Rows[y].Cells[0].Selected = true;
                                    goto label_17;
                                }
                                else
                                    goto label_17;
                            case 5:
                                if (Operators.CompareString(Module1.Segment, "Seg2", false) == 0 & (Operators.CompareString(Module1.GetSeg(), "SF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "FF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "0F", false) == 0 | Operators.CompareString(Module1.GetSeg(), "SS", false) == 0))
                                {
                                    this.DNSChange(y, checked(y + 1));
                                    dataGridView1.Rows[y].Cells[0].Selected = true;
                                    goto label_17;
                                }
                                else
                                    goto label_17;
                            default:
                                goto label_17;
                        }
                    case 3:
                        switch (x)
                        {
                            case 4:
                                if (Operators.CompareString(Module1.Segment, "Seg1", false) == 0 & (Operators.CompareString(Module1.GetSeg(), "SF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "FF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "F0", false) == 0 | Operators.CompareString(Module1.GetSeg(), "S0", false) == 0 | Operators.CompareString(Module1.GetSeg(), "SS", false) == 0))
                                {
                                    this.DNSChange(y, checked(y + 1));
                                    dataGridView1.Rows[y].Cells[0].Selected = true;
                                    goto label_17;
                                }
                                else
                                    goto label_17;
                            case 5:
                                if (Operators.CompareString(Module1.Segment, "Seg2", false) == 0 & (Operators.CompareString(Module1.GetSeg(), "SF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "FF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "0F", false) == 0 | Operators.CompareString(Module1.GetSeg(), "SS", false) == 0))
                                {
                                    this.DNSChange(y, checked(y + 1));
                                    dataGridView1.Rows[y].Cells[0].Selected = true;
                                    goto label_17;
                                }
                                else
                                    goto label_17;
                            default:
                                goto label_17;
                        }
                    default:
                        goto label_17;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("DataGridView1_MouseDoubleClick - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_17:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void CreateStartListArr(ref int row)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                string segment1 = Module1.Segment;
                int DNS_Seg1 = 0;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                    this.SortStartNoSeg1(Module1.TNop);
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                    Module1.SortStartNoSeg2(Module1.TNop, ref DNS_Seg1);
                this.CreateStartList1(Module1.TNop);
                this.TArr = (object[,])null;
                this.TArr = new object[51, 10];
                this.TArr[0, 0] = (object)"Start no";
                this.TArr[0, 1] = (object)"Group";
                this.TArr[0, 2] = (object)"First name";
                this.TArr[0, 3] = (object)"Surname";
                this.TArr[0, 4] = (object)"Club";
                row = 0;
                int num3 = checked(Module1.TNop - DNS_Seg1);
                int index1 = 1;
                while (index1 <= num3)
                {
                    string segment2 = Module1.Segment;
                    if (Operators.CompareString(segment2, "Seg1", false) == 0)
                    {
                        if (index1 > 2 && Module1.Vek[index1].WarmUp_Seg1 > Module1.Vek[checked(index1 - 1)].WarmUp_Seg1 & Module1.Vek[index1].Startno_Seg1 > 0)
                        {
                            checked { ++row; }
                            int index2 = 1;
                            do
                            {
                                if (Module1.Vek[checked(index1 - 1)].Startno_Seg1 == Module1.IceArr_Seg1[index2])
                                    this.TArr[row, 2] = (object)"ICE RESURFACING";
                                if (Module1.Vek[checked(index1 - 1)].Startno_Seg1 == Module1.LunchArr_Seg1[index2])
                                    this.TArr[row, 2] = (object)"MEAL BREAK";
                                checked { ++index2; }
                            }
                            while (index2 <= 6);
                            if (Strings.Len(RuntimeHelpers.GetObjectValue(this.TArr[row, 2])) < 1)
                                this.TArr[row, 2] = (object)"WARM UP";
                        }
                        if (Module1.Vek[index1].Startno_Seg1 > 0)
                        {
                            checked { ++row; }
                            this.TArr[row, 0] = (object)Conversions.ToString(Module1.Vek[index1].Startno_Seg1);
                            this.TArr[row, 1] = Module1.Vek[index1].WarmUp_Seg1 <= 0 ? (object)"-" : (object)Conversions.ToString(Module1.Vek[index1].WarmUp_Seg1);
                            this.TArr[row, 2] = (object)Module1.Vek[index1].Name.FName;
                            this.TArr[row, 3] = (object)Module1.Vek[index1].Name.LName;
                            this.TArr[row, 4] = (object)Module1.Vek[index1].Club;
                        }
                    }
                    else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                    {
                        if (index1 > 2 && Module1.Vek[index1].WarmUp_Seg2 > Module1.Vek[checked(index1 - 1)].WarmUp_Seg2 & Module1.Vek[index1].Startno_Seg2 > 0)
                        {
                            checked { ++row; }
                            int index3 = 1;
                            do
                            {
                                if (Module1.Vek[checked(index1 - 1)].Startno_Seg2 == Module1.IceArr_Seg2[index3])
                                    this.TArr[row, 2] = (object)"ICE RESURFACING";
                                if (Module1.Vek[checked(index1 - 1)].Startno_Seg2 == Module1.LunchArr_Seg2[index3])
                                    this.TArr[row, 2] = (object)"MEAL BREAK";
                                checked { ++index3; }
                            }
                            while (index3 <= 6);
                            if (Strings.Len(RuntimeHelpers.GetObjectValue(this.TArr[row, 2])) < 1)
                                this.TArr[row, 2] = (object)"WARM UP";
                        }
                        if (Module1.Vek[index1].Startno_Seg2 > 0)
                        {
                            checked { ++row; }
                            this.TArr[row, 0] = (object)Conversions.ToString(Module1.Vek[index1].Startno_Seg2);
                            this.TArr[row, 1] = Module1.Vek[index1].WarmUp_Seg2 <= 0 ? (object)"-" : (object)Conversions.ToString(Module1.Vek[index1].WarmUp_Seg2);
                            this.TArr[row, 2] = (object)Module1.Vek[index1].Name.FName;
                            this.TArr[row, 3] = (object)Module1.Vek[index1].Name.LName;
                            this.TArr[row, 4] = (object)Module1.Vek[index1].Club;
                        }
                    }
                    checked { ++index1; }
                }
                goto label_37;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("CreateStartListArr - " + Information.Err().Description + "\r\n"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_37:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void CreateEntriesArr(ref int row)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.SortEntriesClub(Module1.TNop);
                this.Sort_Entries_Club_Surname(Module1.TNop);
                this.TArr = (object[,])null;
                this.TArr = new object[51, 3];
                this.TArr[0, 0] = (object)"First name";
                this.TArr[0, 1] = (object)"Surname";
                this.TArr[0, 2] = (object)"Club";
                int tnop = Module1.TNop;
                int index = 1;
                while (index <= tnop)
                {
                    this.TArr[index, 0] = (object)Module1.Vek[index].Name.FName;
                    this.TArr[index, 1] = (object)Module1.Vek[index].Name.LName;
                    this.TArr[index, 2] = (object)Module1.Vek[index].Club;
                    checked { ++index; }
                }
                row = checked(index - 1);
                goto label_10;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("CreateEntriesArr - " + Information.Err().Description + "\r\n"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_10:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void SortEntriesClub(int NoOfSkater)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int num4 = checked(NoOfSkater - 1);
                int index1 = 1;
                while (index1 <= num4)
                {
                    num3 = 3;
                    Module1.Participant participant = Module1.Vek[index1];
                    num3 = 4;
                    int index2 = index1;
                    num3 = 5;
                    int num5 = checked(index1 + 1);
                    int num6 = NoOfSkater;
                    int index3 = num5;
                    while (index3 <= num6)
                    {
                        num3 = 6;
                        if (Operators.CompareString(Strings.UCase(Module1.Vek[index3].Club), Strings.UCase(participant.Club), false) < 0)
                        {
                            num3 = 7;
                            participant = Module1.Vek[index3];
                            num3 = 8;
                            index2 = index3;
                        }
                        num3 = 10;
                        checked { ++index3; }
                    }
                    num3 = 11;
                    Module1.Vek[index2] = Module1.Vek[index1];
                    num3 = 12;
                    Module1.Vek[index1] = participant;
                    num3 = 13;
                    checked { ++index1; }
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

        public void Sort_Entries_Club_Surname(int No)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                string club = Module1.Vek[1].Club;
                int StartIndex = 1;
                int num3 = checked(No + 1);
                int index = 1;
                while (index <= num3)
                {
                    if (Operators.CompareString(club, Module1.Vek[index].Club, false) != 0)
                    {
                        int NoOfSkater = checked(index - 1);
                        this.SortEntriesSurname(StartIndex, NoOfSkater);
                        club = Module1.Vek[index].Club;
                        StartIndex = index;
                    }
                    checked { ++index; }
                }
                goto label_11;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("IndTAEntriesForm.Sort_IndTA_Klass_Club - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_11:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void SortEntriesSurname(int StartIndex, int NoOfSkater)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int num4 = StartIndex;
                int num5 = checked(NoOfSkater - 1);
                int index1 = num4;
                while (index1 <= num5)
                {
                    num3 = 3;
                    Module1.Participant participant = Module1.Vek[index1];
                    num3 = 4;
                    int index2 = index1;
                    num3 = 5;
                    int num6 = checked(index1 + 1);
                    int num7 = NoOfSkater;
                    int index3 = num6;
                    while (index3 <= num7)
                    {
                        num3 = 6;
                        if (Operators.CompareString(Strings.UCase(Module1.Vek[index3].Name.LName), Strings.UCase(participant.Name.LName), false) < 0)
                        {
                            num3 = 7;
                            participant = Module1.Vek[index3];
                            num3 = 8;
                            index2 = index3;
                        }
                        num3 = 10;
                        checked { ++index3; }
                    }
                    num3 = 11;
                    Module1.Vek[index2] = Module1.Vek[index1];
                    num3 = 12;
                    Module1.Vek[index1] = participant;
                    num3 = 13;
                    checked { ++index1; }
                }
                num3 = 14;
                int StartIndex1 = 0;
                num3 = 15;
                int NoOfSkater1 = 0;
                num3 = 16;
                int num8 = checked(NoOfSkater - 1);
                int index4 = 1;
                while (index4 <= num8)
                {
                    num3 = 17;
                    if (Operators.CompareString(Strings.UCase(Module1.Vek[index4].Name.LName), Strings.UCase(Module1.Vek[checked(index4 + 1)].Name.LName), false) == 0)
                    {
                        num3 = 18;
                        if (StartIndex1 == 0)
                        {
                            num3 = 19;
                            StartIndex1 = index4;
                        }
                        num3 = 21;
                        NoOfSkater1 = checked(index4 + 1);
                    }
                    else
                    {
                        num3 = 23;
                        num3 = 24;
                        if (NoOfSkater1 != StartIndex1)
                        {
                            num3 = 25;
                            Module1.SortFirstName(StartIndex1, NoOfSkater1);
                        }
                        num3 = 27;
                        StartIndex1 = 0;
                        num3 = 28;
                        NoOfSkater1 = 0;
                    }
                    num3 = 30;
                    if (NoOfSkater1 != StartIndex1)
                    {
                        num3 = 31;
                        Module1.SortFirstName(StartIndex1, NoOfSkater1);
                    }
                    num3 = 33;
                    checked { ++index4; }
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

        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                switch (e.ColumnIndex)
                {
                    case 0:
                    case 7:
                        string str = Conversions.ToString(this.DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                        int index = 0;
                        int length = str.Length;
                        while (index < length)
                        {
                            if (!char.IsDigit(str[index]))
                            {
                                int num3 = (int)MessageBox.Show("Please enter numeric value.");
                                this.DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = (object)"0";
                                break;
                            }
                            checked { ++index; }
                        }
                        goto label_12;
                    default:
                        goto label_12;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("DataGridView1_CellEndEdit - " + Information.Err().Description + "\r\n"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_12:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (this.DataGridView1.RowCount <= 42)
                return;
            int num = (int)MessageBox.Show("Maximun no. of records (" + Strings.Trim(Conversions.ToString(42)) + ") reached.");
            this.DataGridView1.AllowUserToAddRows = false;
        }

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.DataGridView1.RowCount >= 42)
                return;
            this.DataGridView1.AllowUserToAddRows = true;
        }

        private void GetFromIndTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (this.MenuPossibleStartListForm())
                {
                    int num3 = Module1.IndexEmptyRow();
                    if (Module1.IsFormOpen((Form)MyProject.Forms.IndTAEntriesForm))
                        MyProject.Forms.IndTAEntriesForm.Close();
                    if (num3 < 42)
                    {
                        MyProject.Forms.IndTAEntriesForm.txtIndTAGet.Text = "1";
                        this.TopMost = false;
                        MyProject.Forms.IndTAEntriesForm.Show();
                        goto label_12;
                    }
                    else
                    {
                        int num4 = (int)Interaction.MsgBox((object)"Max no of participants acieved!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_12;
                    }
                }
                else
                    goto label_12;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("GetFromIndTAToolStripMenuItem - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_12:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void GetSkatersForToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (this.MenuPossibleStartListForm())
                {
                    int num3 = Module1.IndexEmptyRow();
                    if (Module1.IsFormOpen((Form)MyProject.Forms.IndTAEntriesForm))
                        MyProject.Forms.IndTAEntriesForm.Close();
                    if (num3 < 42)
                    {
                        MyProject.Forms.IndTAEntriesForm.txtIndTAGet.Text = "2";
                        this.TopMost = false;
                        MyProject.Forms.IndTAEntriesForm.Show();
                        goto label_12;
                    }
                    else
                    {
                        int num4 = (int)Interaction.MsgBox((object)"Max no of participants acieved!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_12;
                    }
                }
                else
                    goto label_12;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("GetFromIndTAToolStripMenuItem - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_12:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void Schedule(int par)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                if (Operators.CompareString(Module1.Category.Name, "", false) == 0 | Operators.CompareString(Module1.GetProgType(Module1.Segment), "", false) == 0)
                {
                    num3 = 3;
                    int num4 = (int)Interaction.MsgBox((object)"Please select a Category and Segment!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
                else
                {
                    num3 = 6;
                    if (Module1.TNop < 1)
                    {
                        num3 = 7;
                        int num5 = (int)Interaction.MsgBox((object)"No team definded!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    }
                    else
                    {
                        num3 = 10;
                        string segment = Module1.Segment;
                        num3 = 13;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                        {
                            num3 = 14;
                            if (Operators.CompareString(Module1.Datum.Seg1Start, "", false) == 0)
                            {
                                num3 = 15;
                                Module1.Datum.Seg1Start = Conversions.ToString(1E-05);
                            }
                            num3 = 17;
                            int DNSnono = 0;
                            this.SortWSListSeg1(Module1.TNop, ref DNSnono);
                            num3 = 18;
                            switch (par)
                            {
                                case 0:
                                case 1:
                                    num3 = 22;
                                    if (checked(Module1.TNop - DNSnono) == 0)
                                    {
                                        num3 = 23;
                                        int num6 = (int)Interaction.MsgBox((object)"Start number is missing!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                        break;
                                    }
                                    num3 = 26;
                                    this.WarmUpSheet(checked(Module1.TNop - DNSnono), par);
                                    break;
                                case 2:
                                    num3 = 29;
                                    this.WarmUpSheet(Module1.TNop, par);
                                    break;
                                case 3:
                                    num3 = 32;
                                    this.WarmUpSheet(Module1.TNop, par);
                                    break;
                            }
                        }
                        else
                        {
                            num3 = 35;
                            if (Operators.CompareString(segment, "Seg2", false) == 0)
                            {
                                num3 = 36;
                                if (Operators.CompareString(Module1.Datum.Seg2Start, "", false) == 0)
                                {
                                    num3 = 37;
                                    Module1.Datum.Seg2Start = Conversions.ToString(1E-05);
                                }
                                num3 = 39;
                                int DNS_Seg1 = 0;
                                int DNSnono = 0;
                                this.SortWSListSeg2(Module1.TNop, ref DNS_Seg1, ref DNSnono);
                                num3 = 40;
                                switch (par)
                                {
                                    case 0:
                                    case 1:
                                        num3 = 44;
                                        if (checked(Module1.TNop - DNS_Seg1 - DNSnono) == 0)
                                        {
                                            num3 = 45;
                                            int num7 = (int)Interaction.MsgBox((object)"Start number is missing!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                            break;
                                        }
                                        num3 = 48;
                                        this.WarmUpSheet(checked(Module1.TNop - DNS_Seg1 - DNSnono), par);
                                        break;
                                    case 2:
                                        num3 = 51;
                                        this.WarmUpSheet(Module1.TNop, par);
                                        break;
                                    case 3:
                                        num3 = 54;
                                        this.WarmUpSheet(Module1.TNop, par);
                                        break;
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

        public void WarmUpSheet(int PartNo, int par)
        {
            this.TopMost = false;
            MyProject.Forms.Form7.txtPartNo.Text = Conversions.ToString(PartNo);
            MyProject.Forms.Form7.txtPar.Text = Conversions.ToString(par);
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form7))
                MyProject.Forms.Form7.Close();
            if (par != 3)
            {
                MyProject.Forms.Form7.Show();
            }
            else
            {
                MyProject.Forms.Form7.CreateWarmUp();
                MyProject.Forms.Form7.PRINTToolStripMenuItem.PerformClick();
            }
        }

        public void SortWSListSeg1(int NoOfSkater, ref int DNSnono)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                DNSnono = 0;
                num3 = 3;
                int num4 = NoOfSkater;
                int index1 = 1;
                while (index1 <= num4)
                {
                    num3 = 4;
                    if (Module1.Vek[index1].Startno_Seg1 < 1)
                    {
                        num3 = 5;
                        checked { ++DNSnono; }
                    }
                    num3 = 7;
                    checked { ++index1; }
                }
                num3 = 8;
                int num5 = checked(NoOfSkater - 1);
                int index2 = 1;
                while (index2 <= num5)
                {
                    num3 = 9;
                    Module1.Participant participant = Module1.Vek[index2];
                    num3 = 10;
                    int index3 = index2;
                    num3 = 11;
                    int num6 = checked(index2 + 1);
                    int num7 = NoOfSkater;
                    int index4 = num6;
                    while (index4 <= num7)
                    {
                        num3 = 12;
                        if (Module1.Vek[index4].Startno_Seg1 > participant.Startno_Seg1)
                        {
                            num3 = 13;
                            participant = Module1.Vek[index4];
                            num3 = 14;
                            index3 = index4;
                        }
                        num3 = 16;
                        checked { ++index4; }
                    }
                    num3 = 17;
                    Module1.Vek[index3] = Module1.Vek[index2];
                    num3 = 18;
                    Module1.Vek[index2] = participant;
                    num3 = 19;
                    checked { ++index2; }
                }
                num3 = 20;
                int num8 = checked(NoOfSkater - 1 - DNSnono);
                int index5 = 1;
                while (index5 <= num8)
                {
                    num3 = 21;
                    Module1.Participant participant = Module1.Vek[index5];
                    num3 = 22;
                    int index6 = index5;
                    num3 = 23;
                    int num9 = checked(index5 + 1);
                    int num10 = checked(NoOfSkater - DNSnono);
                    int index7 = num9;
                    while (index7 <= num10)
                    {
                        num3 = 24;
                        if ((double)Module1.Vek[index7].Startno_Seg1 < (double)participant.Startno_Seg1)
                        {
                            num3 = 25;
                            participant = Module1.Vek[index7];
                            num3 = 26;
                            index6 = index7;
                        }
                        num3 = 28;
                        checked { ++index7; }
                    }
                    num3 = 29;
                    Module1.Vek[index6] = Module1.Vek[index5];
                    num3 = 30;
                    Module1.Vek[index5] = participant;
                    num3 = 31;
                    checked { ++index5; }
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

        public void SortWSListSeg2(int NoOfSkater, ref int DNS_Seg1, ref int DNSnono)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                DNS_Seg1 = 0;
                num3 = 3;
                int num4 = NoOfSkater;
                int index1 = 1;
                while (index1 <= num4)
                {
                    num3 = 4;
                    if (Module1.Vek[index1].DNS_Seg1 > 0)
                    {
                        num3 = 5;
                        checked { ++DNS_Seg1; }
                    }
                    num3 = 7;
                    checked { ++index1; }
                }
                num3 = 8;
                int num5 = checked(NoOfSkater - 1);
                int index2 = 1;
                while (index2 <= num5)
                {
                    num3 = 9;
                    Module1.Participant participant = Module1.Vek[index2];
                    num3 = 10;
                    int index3 = index2;
                    num3 = 11;
                    int num6 = checked(index2 + 1);
                    int num7 = NoOfSkater;
                    int index4 = num6;
                    while (index4 <= num7)
                    {
                        num3 = 12;
                        if (Module1.Vek[index4].DNS_Seg1 < participant.DNS_Seg1)
                        {
                            num3 = 13;
                            participant = Module1.Vek[index4];
                            num3 = 14;
                            index3 = index4;
                        }
                        num3 = 16;
                        checked { ++index4; }
                    }
                    num3 = 17;
                    Module1.Vek[index3] = Module1.Vek[index2];
                    num3 = 18;
                    Module1.Vek[index2] = participant;
                    num3 = 19;
                    checked { ++index2; }
                }
                num3 = 20;
                DNSnono = 0;
                num3 = 21;
                int num8 = checked(NoOfSkater - DNS_Seg1);
                int index5 = 1;
                while (index5 <= num8)
                {
                    num3 = 22;
                    if (Module1.Vek[index5].Startno_Seg2 < 1)
                    {
                        num3 = 23;
                        checked { ++DNSnono; }
                    }
                    num3 = 25;
                    checked { ++index5; }
                }
                num3 = 26;
                int num9 = checked(NoOfSkater - 1 - DNS_Seg1);
                int index6 = 1;
                while (index6 <= num9)
                {
                    num3 = 27;
                    Module1.Participant participant = Module1.Vek[index6];
                    num3 = 28;
                    int index7 = index6;
                    num3 = 29;
                    int num10 = checked(index6 + 1);
                    int num11 = checked(NoOfSkater - DNS_Seg1);
                    int index8 = num10;
                    while (index8 <= num11)
                    {
                        num3 = 30;
                        if (Module1.Vek[index8].Startno_Seg2 > participant.Startno_Seg2)
                        {
                            num3 = 31;
                            participant = Module1.Vek[index8];
                            num3 = 32;
                            index7 = index8;
                        }
                        num3 = 34;
                        checked { ++index8; }
                    }
                    num3 = 35;
                    Module1.Vek[index7] = Module1.Vek[index6];
                    num3 = 36;
                    Module1.Vek[index6] = participant;
                    num3 = 37;
                    checked { ++index6; }
                }
                num3 = 38;
                int num12 = checked(NoOfSkater - 1 - DNS_Seg1 - DNSnono);
                int index9 = 1;
                while (index9 <= num12)
                {
                    num3 = 39;
                    Module1.Participant participant = Module1.Vek[index9];
                    num3 = 40;
                    int index10 = index9;
                    num3 = 41;
                    int num13 = checked(index9 + 1);
                    int num14 = checked(NoOfSkater - DNS_Seg1 - DNSnono);
                    int index11 = num13;
                    while (index11 <= num14)
                    {
                        num3 = 42;
                        if ((double)Module1.Vek[index11].Startno_Seg2 < (double)participant.Startno_Seg2)
                        {
                            num3 = 43;
                            participant = Module1.Vek[index11];
                            num3 = 44;
                            index10 = index11;
                        }
                        num3 = 46;
                        checked { ++index11; }
                    }
                    num3 = 47;
                    Module1.Vek[index10] = Module1.Vek[index9];
                    num3 = 48;
                    Module1.Vek[index9] = participant;
                    num3 = 49;
                    checked { ++index9; }
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

        public void CreateStartListPDF(int msg)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string Path = "";
                ProjectData.ClearProjectError();
                num1 = 2;
                int row = 0;
                this.CreateStartListArr(ref row);
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    if (!Conversions.ToBoolean(Module1.CreatePath("Segment_1", ref Path)))
                        goto label_11;
                }
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                {
                    if (!Conversions.ToBoolean(Module1.CreatePath("Segment_2", ref Path)))
                        goto label_11;
                }
                this.ExportDataToPDFTable1(row, 5, "START LIST", Path + "_Start.pdf", msg);
                goto label_11;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("CreateStartListPDF - " + Information.Err().Description + "\r\n"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_11:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void CreateEntriesPDF()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string Path = "";
                ProjectData.ClearProjectError();
                num1 = 2;
                int row = 0;
                this.CreateEntriesArr(ref row);
                if (Conversions.ToBoolean(Module1.CreatePath("", ref Path)))
                {
                    this.ExportDataToPDFTable1(Module1.TNop, 3, "ENTRIES", Path + "_Entries.pdf", 1);
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
                int num3 = (int)Interaction.MsgBox((object)("CreateEntriesPDF - " + Information.Err().Description + "\r\n"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_8:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void ExportDataToPDFTable1(
          int norow,
          int nocol,
          string txtinfo,
          string pathfile,
          int msg)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                float[] numArray = new float[3] { 33f, 33f, 33f };
                string str1 = " ";
                int num3 = 110;
                int num4 = 40;
                int num5 = 40;
                int Length = 27;
                ProjectData.ClearProjectError();
                num1 = 2;
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    str1 = Module1.FormShortDate(Module1.Datum.Seg1);
                    if (Operators.CompareString(txtinfo, "ENTRIES", false) != 0)
                        str1 = str1 + ", " + Module1.Datum.Seg1Start;
                }
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                {
                    str1 = Module1.FormShortDate(Module1.Datum.Seg2);
                    if (Operators.CompareString(txtinfo, "ENTRIES", false) != 0)
                        str1 = str1 + ", " + Module1.Datum.Seg2Start;
                }
                string str2 = Operators.CompareString(txtinfo, "ENTRIES", false) == 0 ? "" : ", " + Module1.GetSegTxt(Module1.Segment);
                PdfDocument pdfDocument = new PdfDocument();
                pdfDocument.Info.Title = txtinfo;
                pdfDocument.Info.Subject = str2;
                pdfDocument.Info.Author = "ClubCompFS Single ver. 10.0.6, 2019-01-12";
                PdfPage page = pdfDocument.AddPage();
                page.Size = PageSize.A4;
                int width1 = checked((int)Math.Round(unchecked(page.Width.Point - (double)num4 - (double)num5)));
                int num6 = checked((int)Math.Round(page.Height.Point));
                XFont font1 = new XFont("ARIAL", 12.0, XFontStyle.Bold);
                XFont xfont1 = new XFont("ARIAL", 10.0, XFontStyle.Bold);
                XFont xfont2 = new XFont("ARIAL", 10.0, XFontStyle.Regular);
                XFont xfont3 = new XFont("ARIAL", 6.0, XFontStyle.Regular);
                XGraphics xgraphics1 = XGraphics.FromPdfPage(page);
                XImage image = XImage.FromFile("IE_Logo_HD.png");
                XImage image2 = XImage.FromFile("FSI_Logo_HD.png");
                double pointWidth = image.PointWidth;
                double pointHeight = image.PointHeight;
                double num7 = pointWidth / pointHeight;
                XRect rect = new XRect(10.0, 10.0, pointWidth, pointHeight);
                XRect rect2 = new XRect(480.0, 10.0, 100, 80);
                xgraphics1.DrawImage(image, rect);
                xgraphics1.DrawImage(image2, rect2);

                switch (nocol)
                {
                    case 3:
                        Length = 30;
                        numArray = new float[3] { 33f, 33f, 33f };
                        break;
                    case 5:
                        Length = 24;
                        numArray = new float[5] { 9f, 9f, 27f, 27f, 27f };
                        break;
                }
                int y1 = num3;
                int height1 = checked((int)Math.Round(font1.GetHeight()));
                xgraphics1.DrawString(txtinfo, font1, (XBrush)XBrushes.Black, new XRect((double)num4, (double)y1, (double)width1, (double)height1), XStringFormats.TopLeft);
                int y2 = checked(y1 + height1 + 5);
                int height2 = checked((int)Math.Round(xfont1.GetHeight()));
                XGraphics xgraphics2 = xgraphics1;
                string str3 = "COMPETITION: " + Module1.Competition.Name;
                XFont xfont4 = xfont1;
                XSolidBrush black1 = XBrushes.Black;
                XRect xrect1 = new XRect((double)num4, (double)y2, (double)width1, (double)height2);
                XStringFormat topLeft1 = XStringFormats.TopLeft;
                string text1 = str3;
                XFont font2 = xfont4;
                XSolidBrush brush1 = black1;
                XRect layoutRectangle1 = xrect1;
                XStringFormat format1 = topLeft1;
                xgraphics2.DrawString(text1, font2, (XBrush)brush1, layoutRectangle1, format1);
                int y3 = checked(y2 + height2);
                XGraphics xgraphics3 = xgraphics1;
                string str4 = "CATEGORY: " + Module1.Category.Name + Module1.SubCat() + str2;
                XFont xfont5 = xfont1;
                XSolidBrush black2 = XBrushes.Black;
                XRect xrect2 = new XRect((double)num4, (double)y3, (double)width1, (double)height2);
                XStringFormat topLeft2 = XStringFormats.TopLeft;
                string text2 = str4;
                XFont font3 = xfont5;
                XSolidBrush brush2 = black2;
                XRect layoutRectangle2 = xrect2;
                XStringFormat format2 = topLeft2;
                xgraphics3.DrawString(text2, font3, (XBrush)brush2, layoutRectangle2, format2);
                int y4 = checked(y3 + height2);
                XGraphics xgraphics4 = xgraphics1;
                string str5 = "DATE: " + str1;
                XFont xfont6 = xfont1;
                XSolidBrush black3 = XBrushes.Black;
                XRect xrect3 = new XRect((double)num4, (double)y4, (double)width1, (double)height2);
                XStringFormat topLeft3 = XStringFormats.TopLeft;
                string text3 = str5;
                XFont font4 = xfont6;
                XSolidBrush brush3 = black3;
                XRect layoutRectangle3 = xrect3;
                XStringFormat format3 = topLeft3;
                xgraphics4.DrawString(text3, font4, (XBrush)brush3, layoutRectangle3, format3);
                int num8 = checked(y4 + 2 * height2);
                int num9 = norow;
                int index1 = 0;
                while (index1 <= num9)
                {
                    XFont xfont7 = index1 != 0 ? xfont2 : xfont1;
                    int num10 = num4;
                    xgraphics1.DrawLine(XPens.Gray, num4, num8, checked(num4 + width1), num8);
                    int y5 = checked(num8 + 1);
                    int num11 = checked(nocol - 1);
                    int index2 = 0;
                    while (index2 <= num11)
                    {
                        int width2 = checked((int)Math.Round(unchecked((double)numArray[index2] * (double)width1 / 100.0)));
                        string str6 = Strings.Left(Strings.Len(RuntimeHelpers.GetObjectValue(this.TArr[index1, index2])) <= 0 ? " " : Conversions.ToString(this.TArr[index1, index2]), Length);
                        switch (index2)
                        {
                            case 0:
                                xgraphics1.DrawLine(XPens.Gray, num10, checked(y5 - 1), num10, checked(y5 + height2 + 1));
                                switch (nocol)
                                {
                                    case 3:
                                        XGraphics xgraphics5 = xgraphics1;
                                        string str7 = str6;
                                        XFont xfont8 = xfont7;
                                        XSolidBrush black4 = XBrushes.Black;
                                        XRect xrect4 = new XRect((double)checked(num10 + 1), (double)y5, (double)width2, (double)height2);
                                        XStringFormat topLeft4 = XStringFormats.TopLeft;
                                        string text4 = str7;
                                        XFont font5 = xfont8;
                                        XSolidBrush brush4 = black4;
                                        XRect layoutRectangle4 = xrect4;
                                        XStringFormat format4 = topLeft4;
                                        xgraphics5.DrawString(text4, font5, (XBrush)brush4, layoutRectangle4, format4);
                                        break;
                                    case 5:
                                        XGraphics xgraphics6 = xgraphics1;
                                        string str8 = str6;
                                        XFont xfont9 = xfont7;
                                        XSolidBrush black5 = XBrushes.Black;
                                        XRect xrect5 = new XRect((double)checked(num10 + 1), (double)y5, (double)width2, (double)height2);
                                        XStringFormat center1 = XStringFormats.Center;
                                        string text5 = str8;
                                        XFont font6 = xfont9;
                                        XSolidBrush brush5 = black5;
                                        XRect layoutRectangle5 = xrect5;
                                        XStringFormat format5 = center1;
                                        xgraphics6.DrawString(text5, font6, (XBrush)brush5, layoutRectangle5, format5);
                                        break;
                                }
                                break;
                            case 1:
                                xgraphics1.DrawLine(XPens.Gray, num10, checked(y5 - 1), num10, checked(y5 + height2 + 1));
                                switch (nocol)
                                {
                                    case 3:
                                        XGraphics xgraphics7 = xgraphics1;
                                        string str9 = str6;
                                        XFont xfont10 = xfont7;
                                        XSolidBrush black6 = XBrushes.Black;
                                        XRect xrect6 = new XRect((double)checked(num10 + 1), (double)y5, (double)width2, (double)height2);
                                        XStringFormat topLeft5 = XStringFormats.TopLeft;
                                        string text6 = str9;
                                        XFont font7 = xfont10;
                                        XSolidBrush brush6 = black6;
                                        XRect layoutRectangle6 = xrect6;
                                        XStringFormat format6 = topLeft5;
                                        xgraphics7.DrawString(text6, font7, (XBrush)brush6, layoutRectangle6, format6);
                                        break;
                                    case 5:
                                        XGraphics xgraphics8 = xgraphics1;
                                        string str10 = str6;
                                        XFont xfont11 = xfont7;
                                        XSolidBrush black7 = XBrushes.Black;
                                        XRect xrect7 = new XRect((double)checked(num10 + 1), (double)y5, (double)width2, (double)height2);
                                        XStringFormat center2 = XStringFormats.Center;
                                        string text7 = str10;
                                        XFont font8 = xfont11;
                                        XSolidBrush brush7 = black7;
                                        XRect layoutRectangle7 = xrect7;
                                        XStringFormat format7 = center2;
                                        xgraphics8.DrawString(text7, font8, (XBrush)brush7, layoutRectangle7, format7);
                                        break;
                                }
                                break;
                            case 2:
                                xgraphics1.DrawLine(XPens.Gray, num10, checked(y5 - 1), num10, checked(y5 + height2 + 1));
                                XGraphics xgraphics9 = xgraphics1;
                                string str11 = str6;
                                XFont xfont12 = xfont7;
                                XSolidBrush black8 = XBrushes.Black;
                                XRect xrect8 = new XRect((double)checked(num10 + 1), (double)y5, (double)width2, (double)height2);
                                XStringFormat topLeft6 = XStringFormats.TopLeft;
                                string text8 = str11;
                                XFont font9 = xfont12;
                                XSolidBrush brush8 = black8;
                                XRect layoutRectangle8 = xrect8;
                                XStringFormat format8 = topLeft6;
                                xgraphics9.DrawString(text8, font9, (XBrush)brush8, layoutRectangle8, format8);
                                if (checked(nocol - 1) == 2)
                                {
                                    xgraphics1.DrawLine(XPens.Gray, checked(num4 + width1), checked(y5 - 1), checked(num4 + width1), checked(y5 + height2 + 1));
                                    break;
                                }
                                break;
                            case 3:
                                xgraphics1.DrawLine(XPens.Gray, num10, checked(y5 - 1), num10, checked(y5 + height2 + 1));
                                XGraphics xgraphics10 = xgraphics1;
                                string str12 = str6;
                                XFont xfont13 = xfont7;
                                XSolidBrush black9 = XBrushes.Black;
                                XRect xrect9 = new XRect((double)checked(num10 + 1), (double)y5, (double)width2, (double)height2);
                                XStringFormat topLeft7 = XStringFormats.TopLeft;
                                string text9 = str12;
                                XFont font10 = xfont13;
                                XSolidBrush brush9 = black9;
                                XRect layoutRectangle9 = xrect9;
                                XStringFormat format9 = topLeft7;
                                xgraphics10.DrawString(text9, font10, (XBrush)brush9, layoutRectangle9, format9);
                                if (checked(nocol - 1) == 3)
                                {
                                    xgraphics1.DrawLine(XPens.Gray, checked(num4 + width1), checked(y5 - 1), checked(num4 + width1), checked(y5 + height2 + 1));
                                    break;
                                }
                                break;
                            case 4:
                                xgraphics1.DrawLine(XPens.Gray, num10, checked(y5 - 1), num10, checked(y5 + height2 + 1));
                                XGraphics xgraphics11 = xgraphics1;
                                string str13 = str6;
                                XFont xfont14 = xfont7;
                                XSolidBrush black10 = XBrushes.Black;
                                XRect xrect10 = new XRect((double)checked(num10 + 1), (double)y5, (double)width2, (double)height2);
                                XStringFormat topLeft8 = XStringFormats.TopLeft;
                                string text10 = str13;
                                XFont font11 = xfont14;
                                XSolidBrush brush10 = black10;
                                XRect layoutRectangle10 = xrect10;
                                XStringFormat format10 = topLeft8;
                                xgraphics11.DrawString(text10, font11, (XBrush)brush10, layoutRectangle10, format10);
                                if (checked(nocol - 1) == 4)
                                {
                                    xgraphics1.DrawLine(XPens.Gray, checked(num4 + width1), checked(y5 - 1), checked(num4 + width1), checked(y5 + height2 + 1));
                                    break;
                                }
                                break;
                            case 5:
                                xgraphics1.DrawLine(XPens.Gray, num10, checked(y5 - 1), num10, checked(y5 + height2 + 1));
                                XGraphics xgraphics12 = xgraphics1;
                                string str14 = str6;
                                XFont xfont15 = xfont7;
                                XSolidBrush black11 = XBrushes.Black;
                                XRect xrect11 = new XRect((double)checked(num10 + 1), (double)y5, (double)width2, (double)height2);
                                XStringFormat topLeft9 = XStringFormats.TopLeft;
                                string text11 = str14;
                                XFont font12 = xfont15;
                                XSolidBrush brush11 = black11;
                                XRect layoutRectangle11 = xrect11;
                                XStringFormat format11 = topLeft9;
                                xgraphics12.DrawString(text11, font12, (XBrush)brush11, layoutRectangle11, format11);
                                if (checked(nocol - 1) == 5)
                                {
                                    xgraphics1.DrawLine(XPens.Gray, checked(num4 + width1), checked(y5 - 1), checked(num4 + width1), checked(y5 + height2 + 1));
                                    break;
                                }
                                break;
                        }
                        checked { num10 += width2; }
                        checked { ++index2; }
                    }
                    num8 = checked(y5 + height2 + 1);
                    xgraphics1.DrawLine(XPens.Gray, num4, num8, checked(num4 + width1), num8);
                    checked { ++index1; }
                }
                int y6 = checked(num8 + 2 * height2);
                XGraphics xgraphics13 = xgraphics1;
                string str15 = "Figure Skating Italia | Created: " + Module1.DateTimeToStr(DateTime.Now);
                XFont xfont16 = xfont3;
                XSolidBrush black12 = XBrushes.Black;
                XRect xrect12 = new XRect((double)num4, (double)y6, (double)width1, (double)height2);
                XStringFormat topLeft10 = XStringFormats.TopLeft;
                string text12 = str15;
                XFont font13 = xfont16;
                XSolidBrush brush12 = black12;
                XRect layoutRectangle12 = xrect12;
                XStringFormat format12 = topLeft10;
                xgraphics13.DrawString(text12, font13, (XBrush)brush12, layoutRectangle12, format12);
                pdfDocument.Save(pathfile);
                pdfDocument.Close();
                switch (msg)
                {
                    case 1:
                        int num12 = (int)Interaction.MsgBox((object)("The file has been saved as:\r\n" + pathfile), MsgBoxStyle.Information | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_39;
                    case 2:
                        int num13 = pathfile.LastIndexOf("\\");
                        int num14 = (int)Interaction.MsgBox((object)("The files have been saved in:\r\n" + Strings.Left(pathfile, checked(num13 + 1))), MsgBoxStyle.Information | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_39;
                    default:
                        goto label_39;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num15 = (int)Interaction.MsgBox((object)("Form6, ExportDataToPDFTable1 - \r\n" + Information.Err().Description), MsgBoxStyle.Critical | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_39:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void EntriesPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossibleStartListForm())
                return;
            this.CreateEntriesPDF();
            this.CreateStartList(Module1.TNop);
        }

        private void StartListPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossibleStartListForm())
                return;
            this.CreateStartListPDF(1);
        }

        private void PrintDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                double num3 = Module1.Page_Size * 1.0 / 100.0;
                int pageLeftMargin = Module1.Page_Left_Margin;
                float pageTopMargin = (float)Module1.Page_Top_Margin;
                string str = "";
                ProjectData.ClearProjectError();
                num1 = 2;
                StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit)
                {
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter
                };
                StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
                StringFormat format2 = new StringFormat(StringFormatFlags.NoClip);
                int emSize = checked((int)Math.Round(unchecked(Conversion.Int(num3 * 10.0 + 2.25) + 2.0)));
                Font font1 = new Font("ARIAL", (float)checked(emSize + 2), FontStyle.Bold, GraphicsUnit.Pixel);
                Font font2 = new Font("ARIAL", (float)emSize, FontStyle.Bold, GraphicsUnit.Pixel);
                Font font3 = new Font("ARIAL", (float)emSize, FontStyle.Regular, GraphicsUnit.Pixel);
                Font font4 = new Font("ARIAL", 8f, FontStyle.Regular, GraphicsUnit.Pixel);
                double height1 = (double)font1.GetHeight(e.Graphics);
                format1.Alignment = StringAlignment.Center;
                format2.Alignment = StringAlignment.Near;
                string segTxt = Module1.GetSegTxt(Module1.Segment);
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                    str = Module1.FormShortDate(Module1.Datum.Seg1) + ", " + Module1.Datum.Seg1Start;
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    str = Module1.FormShortDate(Module1.Datum.Seg2) + ", " + Module1.Datum.Seg2Start;
                e.Graphics.DrawString("START LIST", font1, Brushes.Black, (float)pageLeftMargin, pageTopMargin, new StringFormat());
                float y1 = (float)((double)pageTopMargin + (double)font1.GetHeight(e.Graphics) + 5.0);
                e.Graphics.DrawString("COMPETITION: " + Module1.Competition.Name, font1, Brushes.Black, (float)pageLeftMargin, y1, new StringFormat());
                float y2 = y1 + font1.GetHeight(e.Graphics);
                e.Graphics.DrawString("CATEGORY: " + Module1.Category.Name + Module1.SubCat() + ", " + segTxt, font1, Brushes.Black, (float)pageLeftMargin, y2, new StringFormat());
                float y3 = y2 + font1.GetHeight(e.Graphics);
                e.Graphics.DrawString("Date: " + str, font1, Brushes.Black, (float)pageLeftMargin, y3, new StringFormat());
                float x1 = (float)pageLeftMargin;
                float y4 = (float)((double)y3 + (double)font1.GetHeight(e.Graphics) + 10.0);
                float height2 = font3.GetHeight(e.Graphics);
                int index1 = 0;
                RectangleF layoutRectangle = new RectangleF(x1, y4, (float)(70.0 * num3), height2);
                do
                {
                    switch (index1)
                    {
                        case 0:
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            e.Graphics.DrawString(Conversions.ToString(this.TArr[0, index1]), font2, Brushes.Black, layoutRectangle, format1);
                            break;
                        case 1:
                            x1 += layoutRectangle.Width;
                            layoutRectangle = new RectangleF(x1, y4, (float)(70.0 * num3), height2);
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            e.Graphics.DrawString(Conversions.ToString(this.TArr[0, index1]), font2, Brushes.Black, layoutRectangle, format1);
                            break;
                        case 2:
                            x1 += layoutRectangle.Width;
                            layoutRectangle = new RectangleF(x1, y4, (float)(190.0 * num3), height2);
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            e.Graphics.DrawString(Conversions.ToString(this.TArr[0, index1]), font2, Brushes.Black, layoutRectangle, format2);
                            break;
                        case 3:
                            x1 += layoutRectangle.Width;
                            layoutRectangle = new RectangleF(x1, y4, (float)(190.0 * num3), height2);
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            e.Graphics.DrawString(Conversions.ToString(this.TArr[0, index1]), font2, Brushes.Black, layoutRectangle, format2);
                            break;
                        case 4:
                            x1 += layoutRectangle.Width;
                            layoutRectangle = new RectangleF(x1, y4, (float)(190.0 * num3), height2);
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            e.Graphics.DrawString(Conversions.ToString(this.TArr[0, index1]), font2, Brushes.Black, layoutRectangle, format2);
                            break;
                    }
                    checked { ++index1; }
                }
                while (index1 <= 4);
                float y5 = y4 + height2;
                int index2 = 1;
                while (index2 <= this.TarrRow)
                {
                    float x2 = (float)pageLeftMargin;
                    int index3 = 0;
                    do
                    {
                        switch (index3)
                        {
                            case 0:
                                layoutRectangle = new RectangleF(x2, y5, (float)(70.0 * num3), height2);
                                e.Graphics.DrawString(Conversions.ToString(this.TArr[index2, index3]), font3, Brushes.Black, layoutRectangle, format1);
                                break;
                            case 1:
                                x2 += layoutRectangle.Width;
                                layoutRectangle = new RectangleF(x2, y5, (float)(70.0 * num3), height2);
                                e.Graphics.DrawString(Conversions.ToString(this.TArr[index2, index3]), font3, Brushes.Black, layoutRectangle, format1);
                                break;
                            case 2:
                                x2 += layoutRectangle.Width;
                                layoutRectangle = new RectangleF(x2, y5, (float)(190.0 * num3), height2);
                                e.Graphics.DrawString(Conversions.ToString(this.TArr[index2, index3]), font3, Brushes.Black, layoutRectangle, format2);
                                break;
                            case 3:
                                x2 += layoutRectangle.Width;
                                layoutRectangle = new RectangleF(x2, y5, (float)(190.0 * num3), height2);
                                e.Graphics.DrawString(Conversions.ToString(this.TArr[index2, index3]), font3, Brushes.Black, layoutRectangle, format2);
                                break;
                            case 4:
                                x2 += layoutRectangle.Width;
                                layoutRectangle = new RectangleF(x2, y5, (float)(190.0 * num3), height2);
                                e.Graphics.DrawString(Conversions.ToString(this.TArr[index2, index3]), font3, Brushes.Black, layoutRectangle, format2);
                                break;
                        }
                        checked { ++index3; }
                    }
                    while (index3 <= 4);
                    y5 += height2;
                    checked { ++index2; }
                }
                float y6 = y5 + 20f;
                e.Graphics.DrawString("Figure Skating Italia | Created: " + Module1.DateTimeToStr(DateTime.Now), font4, Brushes.Black, (float)pageLeftMargin, y6, new StringFormat());
                goto label_30;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("StartListForm, PrintDocument1_PrintPage_1 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_30:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void PrintStartList()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.CreateStartListArr(ref this.TarrRow);
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("PrintStartlist - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public bool TestNoOfPart()
        {
            bool flag = false;
            if (Module1.TNop > 0 & Module1.TNop <= 42)
            {
                flag = true;
            }
            else
            {
                int num = (int)Interaction.MsgBox((object)"No participant defined!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            return flag;
        }

        public bool MenuPossibleStartListForm()
        {
            bool flag = true;
            if (Module1.IsFormOpen((Form)MyProject.Forms.IndTAEntriesForm))
            {
                int num = (int)Interaction.MsgBox((object)"Please close the IndTA ENTRIES!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                flag = false;
            }
            else if (Module1.IsFormOpen((Form)MyProject.Forms.IceResurfacingMealBreakDialog))
            {
                int num = (int)Interaction.MsgBox((object)"Please close the DIALOG!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                flag = false;
            }
            else if (Module1.IsFormOpen((Form)MyProject.Forms.Form7))
            {
                int num = (int)Interaction.MsgBox((object)"Please close the WARMUP GROUPS!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                flag = false;
            }
            else if (Module1.IsFormOpen((Form)MyProject.Forms.ElementInputForm))
            {
                int num = (int)Interaction.MsgBox((object)"Please close the ELEMENT INPUT!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                flag = false;
            }
            else if (Module1.IsFormOpen((Form)MyProject.Forms.JudgesDetailsForm))
            {
                int num = (int)Interaction.MsgBox((object)"Please close the JUDGES DETAILS!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                flag = false;
            }
            return flag;
        }

        private void CompetitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (this.MenuPossibleStartListForm())
                {
                    if (this.TestNoOfPart())
                    {
                        if (Module1.IsFormOpen((Form)MyProject.Forms.JudgesDetailsForm))
                            MyProject.Forms.JudgesDetailsForm.Close();
                        int index = checked(this.DataGridView1.CurrentCellAddress.Y + 1);
                        switch (Module1.WorkMode)
                        {
                            case 2:
                            case 3:
                                string segment = Module1.Segment;
                                if (Operators.CompareString(segment, "Seg1", false) == 0)
                                {
                                    if (Module1.Vek[index].Startno_Seg1 < 1)
                                    {
                                        int num3 = (int)Interaction.MsgBox((object)"Start number is missing!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                        goto label_19;
                                    }
                                    else
                                        break;
                                }
                                else if (Operators.CompareString(segment, "Seg2", false) == 0 && Module1.Vek[index].Startno_Seg2 < 1)
                                {
                                    int num4 = (int)Interaction.MsgBox((object)"Start number is missing!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                    goto label_19;
                                }
                                else
                                    break;
                        }
                        MyProject.Forms.JudgesDetailsForm.txtIndex.Text = Conversions.ToString(index);
                        if (index > 0 & index <= Module1.TNop)
                        {
                            Module1.F4arr = (string[,])null;
                            Module1.F4arr = new string[1501, 15];
                            Module1.PNo = index;
                            int rowDed = 0;
                            Module1.CreateJudgesDetails(0, ref rowDed);
                            this.TopMost = false;
                            MyProject.Forms.JudgesDetailsForm.ShowJD(rowDed);
                            MyProject.Forms.JudgesDetailsForm.Show();
                            goto label_19;
                        }
                        else
                        {
                            int num5 = (int)Interaction.MsgBox((object)"Please select a valid row!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            goto label_19;
                        }
                    }
                    else
                        goto label_19;
                }
                else
                    goto label_19;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num6 = (int)Interaction.MsgBox((object)("StartListForm, CompetitionToolStripMenuItem - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_19:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void SPEAKERSTARTLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (this.MenuPossibleStartListForm())
                {
                    switch (Module1.WorkMode)
                    {
                        case 2:
                        case 3:
                            string segment1 = Module1.Segment;
                            if (Operators.CompareString(segment1, "Seg1", false) == 0)
                            {
                                int tnop = Module1.TNop;
                                int index = 1;
                                while (index <= tnop)
                                {
                                    if (Module1.Vek[index].Startno_Seg1 < 1 & Module1.Vek[index].DNS_Seg1 == 0)
                                    {
                                        int num3 = (int)Interaction.MsgBox((object)"Start number is missing!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                        goto label_29;
                                    }
                                    else
                                        checked { ++index; }
                                }
                                break;
                            }
                            if (Operators.CompareString(segment1, "Seg2", false) == 0)
                            {
                                int tnop = Module1.TNop;
                                int index = 1;
                                while (index <= tnop)
                                {
                                    if (Module1.Vek[index].Startno_Seg2 < 1 & Module1.Vek[index].DNS_Seg2 == 0)
                                    {
                                        int num4 = (int)Interaction.MsgBox((object)"Start number is missing!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                        goto label_29;
                                    }
                                    else
                                        checked { ++index; }
                                }
                                break;
                            }
                            break;
                    }
                    string segment2 = Module1.Segment;
                    int StNo = 0;
                    if (Operators.CompareString(segment2, "Seg1", false) == 0)
                        StNo = Module1.Vek[checked(this.DataGridView1.CurrentCellAddress.Y + 1)].Startno_Seg1;
                    else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                        StNo = Module1.Vek[checked(this.DataGridView1.CurrentCellAddress.Y + 1)].Startno_Seg2;
                    if (StNo > 1)
                    {
                        if (Interaction.MsgBox((object)"Do you really want to create the SPEAKER START LIST?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                            goto label_29;
                    }
                    if (StNo > 0)
                    {
                        Module1.CreateHTMFile(StNo);
                        this.CreateStartList(Module1.TNop);
                        int num5 = (int)Interaction.MsgBox((object)"The Speaker Startlist has been created!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_29;
                    }
                    else
                    {
                        int num6 = (int)Interaction.MsgBox((object)"Start number is missing!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_29;
                    }
                }
                else
                    goto label_29;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num7 = (int)Interaction.MsgBox((object)("SPEAKERSTARTLISTToolStripMenuItem - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_29:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void INPUTELEMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossibleStartListForm())
                return;
            this.ElementInput(2);
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (this.MenuPossibleStartListForm())
                {
                    Module1.PNo = checked(this.DataGridView1.CurrentCellAddress.Y + 1);
                    int index1 = 1;
                    int index2 = 1;
                    do
                    {
                        if (index2 != Module1.PNo)
                        {
                            Module1.Vek[index1] = Module1.Vek[index2];
                            checked { ++index1; }
                        }
                        checked { ++index2; }
                    }
                    while (index2 <= 42);
                    if (Module1.TNop > 0)
                        checked { --Module1.TNop; }
                    int index3 = checked(Module1.TNop + 1);
                    while (index3 <= 42)
                    {
                        Module1.Vek[index3].SSS_Seg1 = (string[])null;
                        Module1.Vek[index3].SSS_Seg1 = new string[16];
                        Module1.Vek[index3].SSS_Seg2 = (string[])null;
                        Module1.Vek[index3].SSS_Seg2 = new string[16];
                        checked { ++index3; }
                    }
                    this.CreateStartList(Module1.TNop);
                    if (Module1.WorkMode == 1)
                        Module1.SaveCategoryFile(Module1.CategoryFileName);
                    MyProject.Forms.MainForm.txtParticipants.Text = Conversions.ToString(Module1.TNop);
                    goto label_19;
                }
                else
                    goto label_19;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("Button2_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_19:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (this.MenuPossibleStartListForm())
                {
                    int num3 = Module1.IndexEmptyRow();
                    if (num3 <= 41)
                    {
                        this.TopMost = false;
                        ParticipantInputDialog dialog5 = MyProject.Forms.ParticipantInputDialog;
                        dialog5.txtIndStartListForm.Text = Conversions.ToString(num3);
                        dialog5.txtFuncStartListForm.Text = "New";
                        dialog5.txtStartNo.Text = "";
                        dialog5.txtID.Text = "";
                        dialog5.txtFirstName.Text = "";
                        dialog5.txtSurname.Text = "";
                        dialog5.txtClub.Text = "";
                        dialog5.TxtClubID.Text = "";
                        dialog5.txtFirstName.Select();
                        if (Module1.IsFormOpen((Form)MyProject.Forms.ParticipantInputDialog))
                            MyProject.Forms.ParticipantInputDialog.Close();
                        int num4 = (int)MyProject.Forms.ParticipantInputDialog.ShowDialog();
                        MyProject.Forms.MainForm.txtParticipants.Text = Conversions.ToString(Module1.IndexEmptyRow());
                        goto label_12;
                    }
                    else
                    {
                        int num5 = (int)Interaction.MsgBox((object)"Reached the maximum numbers of skaters in a class!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_12;
                    }
                }
                else
                    goto label_12;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num6 = (int)Interaction.MsgBox((object)("btnNew_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_12:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (this.MenuPossibleStartListForm())
                {
                    int y = this.DataGridView1.CurrentCellAddress.Y;
                    if (y < Module1.IndexEmptyRow())
                    {
                        if (y >= 0 & y <= 42)
                        {
                            ParticipantInputDialog dialog5 = MyProject.Forms.ParticipantInputDialog;
                            dialog5.txtIndStartListForm.Text = Conversions.ToString(y);
                            dialog5.txtFuncStartListForm.Text = "Edit";
                            string segment = Module1.Segment;
                            if (Operators.CompareString(segment, "Seg1", false) == 0)
                                dialog5.txtStartNo.Text = Conversions.ToString(Module1.Vek[checked(y + 1)].Startno_Seg1);
                            else if (Operators.CompareString(segment, "Seg2", false) == 0)
                                dialog5.txtStartNo.Text = Conversions.ToString(Module1.Vek[checked(y + 1)].Startno_Seg2);
                            dialog5.txtFirstName.Text = Module1.Vek[checked(y + 1)].Name.FName;
                            dialog5.txtSurname.Text = Module1.Vek[checked(y + 1)].Name.LName;
                            dialog5.txtID.Text = Module1.Vek[checked(y + 1)].Name.ID;
                            dialog5.txtClub.Text = Module1.Vek[checked(y + 1)].Club;
                            dialog5.TxtClubID.Text = Module1.Vek[checked(y + 1)].ClubID;
                            dialog5.txtFirstName.Select();
                            if (Module1.IsFormOpen((Form)MyProject.Forms.ParticipantInputDialog))
                                MyProject.Forms.ParticipantInputDialog.Close();
                            int num3 = (int)MyProject.Forms.ParticipantInputDialog.ShowDialog();
                            goto label_17;
                        }
                        else
                            goto label_17;
                    }
                    else
                    {
                        int num4 = (int)Interaction.MsgBox((object)"Please select a valid row!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_17;
                    }
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
                int num5 = (int)Interaction.MsgBox((object)("btnEdit_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_17:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void PrintEntries()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.CreateEntriesArr(ref this.TarrRow);
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("PrintEntries - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
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
                double num3 = 1.0;
                int pageLeftMargin = Module1.Page_Left_Margin;
                float pageTopMargin = (float)Module1.Page_Top_Margin;
                string str = "";
                ProjectData.ClearProjectError();
                num1 = 2;
                StringFormat stringFormat1 = new StringFormat(StringFormatFlags.LineLimit)
                {
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter
                };
                StringFormat stringFormat2 = new StringFormat(StringFormatFlags.NoClip);
                StringFormat format = new StringFormat(StringFormatFlags.NoClip);
                int emSize = checked((int)Math.Round(Conversion.Int(unchecked(num3 * 10.0 + 2.25))));
                Font font1 = new Font("ARIAL", (float)checked(emSize + 2), FontStyle.Bold, GraphicsUnit.Pixel);
                Font font2 = new Font("ARIAL", (float)emSize, FontStyle.Bold, GraphicsUnit.Pixel);
                Font font3 = new Font("ARIAL", (float)emSize, FontStyle.Regular, GraphicsUnit.Pixel);
                Font font4 = new Font("ARIAL", 8f, FontStyle.Regular, GraphicsUnit.Pixel);
                double height1 = (double)font1.GetHeight(e.Graphics);
                stringFormat2.Alignment = StringAlignment.Center;
                format.Alignment = StringAlignment.Near;
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                    str = Module1.FormShortDate(Module1.Datum.Seg1);
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    str = Module1.FormShortDate(Module1.Datum.Seg2);
                e.Graphics.DrawString("ENTRIES", font1, Brushes.Black, (float)pageLeftMargin, pageTopMargin, new StringFormat());
                float y1 = (float)((double)pageTopMargin + (double)font1.GetHeight(e.Graphics) + 5.0);
                e.Graphics.DrawString("COMPETITION: " + Module1.Competition.Name, font1, Brushes.Black, (float)pageLeftMargin, y1, new StringFormat());
                float y2 = y1 + font1.GetHeight(e.Graphics);
                e.Graphics.DrawString("CATEGORY: " + Module1.Category.Name + Module1.SubCat(), font1, Brushes.Black, (float)pageLeftMargin, y2, new StringFormat());
                float y3 = y2 + font1.GetHeight(e.Graphics);
                e.Graphics.DrawString("Date: " + str, font1, Brushes.Black, (float)pageLeftMargin, y3, new StringFormat());
                float x1 = (float)pageLeftMargin;
                float y4 = (float)((double)y3 + (double)font1.GetHeight(e.Graphics) + 10.0);
                float height2 = font3.GetHeight(e.Graphics);
                int index1 = 0;
                RectangleF layoutRectangle = new RectangleF(x1, y4, (float)(200.0 * num3), height2);
                do
                {
                    switch (index1)
                    {
                        case 0:
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            e.Graphics.DrawString(Conversions.ToString(this.TArr[0, index1]), font2, Brushes.Black, layoutRectangle, format);
                            break;
                        case 1:
                            x1 += layoutRectangle.Width;
                            layoutRectangle = new RectangleF(x1, y4, (float)(300.0 * num3), height2);
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            e.Graphics.DrawString(Conversions.ToString(this.TArr[0, index1]), font2, Brushes.Black, layoutRectangle, format);
                            break;
                        case 2:
                            x1 += layoutRectangle.Width;
                            layoutRectangle = new RectangleF(x1, y4, (float)(200.0 * num3), height2);
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                            e.Graphics.DrawString(Conversions.ToString(this.TArr[0, index1]), font2, Brushes.Black, layoutRectangle, format);
                            break;
                    }
                    checked { ++index1; }
                }
                while (index1 <= 2);
                float y5 = y4 + height2;
                int index2 = 1;
                while (index2 <= this.TarrRow)
                {
                    float x2 = (float)pageLeftMargin;
                    int index3 = 0;
                    do
                    {
                        switch (index3)
                        {
                            case 0:
                                layoutRectangle = new RectangleF(x2, y5, (float)(200.0 * num3), height2);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                e.Graphics.DrawString(Conversions.ToString(this.TArr[index2, index3]), font3, Brushes.Black, layoutRectangle, format);
                                break;
                            case 1:
                                x2 += layoutRectangle.Width;
                                layoutRectangle = new RectangleF(x2, y5, (float)(300.0 * num3), height2);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                e.Graphics.DrawString(Conversions.ToString(this.TArr[index2, index3]), font3, Brushes.Black, layoutRectangle, format);
                                break;
                            case 2:
                                x2 += layoutRectangle.Width;
                                layoutRectangle = new RectangleF(x2, y5, (float)(200.0 * num3), height2);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                e.Graphics.DrawString(Conversions.ToString(this.TArr[index2, index3]), font3, Brushes.Black, layoutRectangle, format);
                                break;
                        }
                        checked { ++index3; }
                    }
                    while (index3 <= 4);
                    y5 += height2;
                    checked { ++index2; }
                }
                float y6 = y5 + 20f;
                e.Graphics.DrawString("Figure Skating Italia | Created: " + Module1.DateTimeToStr(DateTime.Now), font4, Brushes.Black, (float)pageLeftMargin, y6, new StringFormat());
                goto label_26;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("StartListForm, PrintDocument2_PrintPage - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_26:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void PrintEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (this.MenuPossibleStartListForm())
                {
                    this.PrintEntries();
                    this.PrintPreviewDialog1.TopMost = true;
                    this.PrintPreviewDialog1.Document = this.PrintDocument2;
                    int num3 = (int)this.PrintPreviewDialog1.ShowDialog();
                }
                this.CreateStartList(Module1.TNop);
                goto label_9;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("StartListForm, PrintEntriesToolStripMenuItem_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_9:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void PrintStartlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (this.MenuPossibleStartListForm())
                {
                    this.PrintStartList();
                    this.PrintPreviewDialog1.TopMost = true;
                    this.PrintPreviewDialog1.Document = this.PrintDocument1;
                    int num3 = (int)this.PrintPreviewDialog1.ShowDialog();
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
                int num4 = (int)Interaction.MsgBox((object)("StartListForm, PrintStartlistToolStripMenuItem_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_8:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WillExitStartListForm = false;
            if (Interaction.MsgBox((object)"Do you really want to exit the Start List", MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                return;
            this.WillExitStartListForm = true;
            this.CloseFormsDialogs();
            this.Close();
            Module1.CreateMainForm();
            Module1.SaveCategoryFile(Module1.CategoryFileName);
        }

        private void WarmupGroupsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!this.MenuPossibleStartListForm())
                return;
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form7))
                MyProject.Forms.Form7.Close();
            this.Schedule(1);
        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossibleStartListForm())
                return;
            this.WillExitStartListForm = false;
            if (Interaction.MsgBox((object)"Do you really want to exit the Start List", MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                return;
            this.WillExitStartListForm = true;
            this.CloseFormsDialogs();
            this.Close();
            Module1.CreateMainForm();
            Module1.SaveCategoryFile(Module1.CategoryFileName);
        }

        private void InputElementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossibleStartListForm())
                return;
            if (this.DataGridView1.CurrentCellAddress.Y < Module1.IndexEmptyRow())
            {
                this.ElementInput(1);
            }
            else
            {
                int num = (int)Interaction.MsgBox((object)"Please select a valid row!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        private void NewSkaterToolStripMenuItem_Click(object sender, EventArgs e) => this.NewToolStripMenuItem.PerformClick();

        private void EditSkaterToolStripMenuItem1_Click(object sender, EventArgs e) => this.EditToolStripMenuItem.PerformClick();

        private void InputElementToolStripMenuItem2_Click(object sender, EventArgs e) => this.InputElementToolStripMenuItem1.PerformClick();

        private void DeleteSkaterToolStripMenuItem_Click(object sender, EventArgs e) => this.DeleteToolStripMenuItem.PerformClick();

        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (Module1.WorkMode == 2)
                {
                    if (e.Button == MouseButtons.Right)
                    {
                        this.DataGridView1.CurrentCell = this.DataGridView1[e.ColumnIndex, e.RowIndex];
                        if (this.MenuPossibleStartListForm())
                        {
                            this.ElementInput(2);
                            goto label_10;
                        }
                        else
                            goto label_10;
                    }
                    else
                        goto label_10;
                }
                else
                    goto label_10;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("DataGridView1_CellMouseDownk - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_10:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }
    }
}

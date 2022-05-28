// Decompiled with JetBrains decompiler
// Type: ClubCompFS.Form12
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
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;

namespace ClubCompFS
{
    [DesignerGenerated]
    public class Form12 : Form
    {
        private IContainer components;
        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;
        [AccessedThroughProperty("ExitToolStripMenuItem")]
        private ToolStripMenuItem _ExitToolStripMenuItem;
        [AccessedThroughProperty("AddToStartListToolStripMenuItem")]
        private ToolStripMenuItem _AddToStartListToolStripMenuItem;
        [AccessedThroughProperty("txtNoOfParticipants")]
        private TextBox _txtNoOfParticipants;
        [AccessedThroughProperty("DataGridView1")]
        private DataGridView _DataGridView1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("txtCategory")]
        private TextBox _txtCategory;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("txtSubcategory")]
        private TextBox _txtSubcategory;
        [AccessedThroughProperty("SORTERAToolStripMenuItem")]
        private ToolStripMenuItem _SORTERAToolStripMenuItem;
        [AccessedThroughProperty("SortClassToolStripMenuItem")]
        private ToolStripMenuItem _SortClassToolStripMenuItem;
        [AccessedThroughProperty("SortClassAndClubToolStripMenuItem")]
        private ToolStripMenuItem _SortClassAndClubToolStripMenuItem;
        [AccessedThroughProperty("SortClassClubAndSurnameToolStripMenuItem")]
        private ToolStripMenuItem _SortClassClubAndSurnameToolStripMenuItem;
        [AccessedThroughProperty("ToolStripSeparator1")]
        private ToolStripSeparator _ToolStripSeparator1;
        [AccessedThroughProperty("SörtSurnameToolStripMenuItem")]
        private ToolStripMenuItem _SörtSurnameToolStripMenuItem;
        [AccessedThroughProperty("SortClubAndSUrnameToolStripMenuItem")]
        private ToolStripMenuItem _SortClubAndSUrnameToolStripMenuItem;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("txtNoIndTA")]
        private TextBox _txtNoIndTA;
        [AccessedThroughProperty("ContextMenuStrip1")]
        private ContextMenuStrip _ContextMenuStrip1;
        [AccessedThroughProperty("ToolStripMenuItem1")]
        private ToolStripMenuItem _ToolStripMenuItem1;
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
        [AccessedThroughProperty("IndTADiscipline")]
        private DataGridViewTextBoxColumn _IndTADiscipline;
        [AccessedThroughProperty("Column10")]
        private DataGridViewTextBoxColumn _Column10;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("txtSelected")]
        private TextBox _txtSelected;
        [AccessedThroughProperty("txtIndTAGet")]
        private TextBox _txtIndTAGet;
        private const int w0 = 110;
        private const int w1 = 150;
        private const int w2 = 150;
        private const int w3 = 150;
        private const int w4 = 80;
        private const int w5 = 190;
        private bool IndTA_DB;
        private int F12Height;
        private int DGW1width;
        private bool widthcorr;
        private string MyCompetitionName;
        private int No_Of_IndTA_Skaters;
        private bool LoadedGrid;

        public Form12()
        {
            this.SizeChanged += new EventHandler(this.Form12_SizeChanged);
            this.FormClosing += new FormClosingEventHandler(this.Form12_FormClosing);
            this.Load += new EventHandler(this.Form12_Load);
            this.IndTA_DB = false;
            this.widthcorr = false;
            this.MyCompetitionName = "";
            this.No_Of_IndTA_Skaters = 0;
            this.LoadedGrid = false;
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
            DataGridViewCellStyle gridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle12 = new DataGridViewCellStyle();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form12));
            this.MenuStrip1 = new MenuStrip();
            this.ExitToolStripMenuItem = new ToolStripMenuItem();
            this.SORTERAToolStripMenuItem = new ToolStripMenuItem();
            this.SortClassToolStripMenuItem = new ToolStripMenuItem();
            this.SortClassAndClubToolStripMenuItem = new ToolStripMenuItem();
            this.SortClassClubAndSurnameToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.SörtSurnameToolStripMenuItem = new ToolStripMenuItem();
            this.SortClubAndSUrnameToolStripMenuItem = new ToolStripMenuItem();
            this.AddToStartListToolStripMenuItem = new ToolStripMenuItem();
            this.txtNoOfParticipants = new TextBox();
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
            this.IndTADiscipline = new DataGridViewTextBoxColumn();
            this.Column10 = new DataGridViewTextBoxColumn();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.txtCategory = new TextBox();
            this.Label3 = new Label();
            this.txtSubcategory = new TextBox();
            this.Label4 = new Label();
            this.txtNoIndTA = new TextBox();
            this.ContextMenuStrip1 = new ContextMenuStrip(this.components);
            this.ToolStripMenuItem1 = new ToolStripMenuItem();
            this.Label5 = new Label();
            this.txtSelected = new TextBox();
            this.txtIndTAGet = new TextBox();
            this.MenuStrip1.SuspendLayout();
            ((ISupportInitialize)this.DataGridView1).BeginInit();
            this.ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.MenuStrip1.BackColor = SystemColors.Control;
            this.MenuStrip1.Items.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.ExitToolStripMenuItem,
        (ToolStripItem) this.SORTERAToolStripMenuItem,
        (ToolStripItem) this.AddToStartListToolStripMenuItem
            });
            this.MenuStrip1.Location = new Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            MenuStrip menuStrip1 = this.MenuStrip1;
            Size size1 = new Size(1320, 24);
            Size size2 = size1;
            menuStrip1.Size = size2;
            this.MenuStrip1.TabIndex = 3;
            this.MenuStrip1.Text = "MenuStrip1";
            this.ExitToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem1 = this.ExitToolStripMenuItem;
            size1 = new Size(44, 20);
            Size size3 = size1;
            toolStripMenuItem1.Size = size3;
            this.ExitToolStripMenuItem.Text = "EXIT";
            this.SORTERAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[6]
            {
        (ToolStripItem) this.SortClassToolStripMenuItem,
        (ToolStripItem) this.SortClassAndClubToolStripMenuItem,
        (ToolStripItem) this.SortClassClubAndSurnameToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator1,
        (ToolStripItem) this.SörtSurnameToolStripMenuItem,
        (ToolStripItem) this.SortClubAndSUrnameToolStripMenuItem
            });
            this.SORTERAToolStripMenuItem.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.SORTERAToolStripMenuItem.Name = "SORTERAToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem2 = this.SORTERAToolStripMenuItem;
            size1 = new Size(52, 20);
            Size size4 = size1;
            toolStripMenuItem2.Size = size4;
            this.SORTERAToolStripMenuItem.Text = "SORT";
            this.SortClassToolStripMenuItem.Name = "SortClassToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem3 = this.SortClassToolStripMenuItem;
            size1 = new Size(274, 22);
            Size size5 = size1;
            toolStripMenuItem3.Size = size5;
            this.SortClassToolStripMenuItem.Text = "Sort by Class";
            this.SortClassAndClubToolStripMenuItem.Name = "SortClassAndClubToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem4 = this.SortClassAndClubToolStripMenuItem;
            size1 = new Size(274, 22);
            Size size6 = size1;
            toolStripMenuItem4.Size = size6;
            this.SortClassAndClubToolStripMenuItem.Text = "Sort by Class and Club";
            this.SortClassClubAndSurnameToolStripMenuItem.Name = "SortClassClubAndSurnameToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem5 = this.SortClassClubAndSurnameToolStripMenuItem;
            size1 = new Size(274, 22);
            Size size7 = size1;
            toolStripMenuItem5.Size = size7;
            this.SortClassClubAndSurnameToolStripMenuItem.Text = "Sort by Class, Club and Surname";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator toolStripSeparator1 = this.ToolStripSeparator1;
            size1 = new Size(271, 6);
            Size size8 = size1;
            toolStripSeparator1.Size = size8;
            this.SörtSurnameToolStripMenuItem.Name = "SörtSurnameToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem6 = this.SörtSurnameToolStripMenuItem;
            size1 = new Size(274, 22);
            Size size9 = size1;
            toolStripMenuItem6.Size = size9;
            this.SörtSurnameToolStripMenuItem.Text = "Sort by Surname";
            this.SortClubAndSUrnameToolStripMenuItem.Name = "SortClubAndSUrnameToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem7 = this.SortClubAndSUrnameToolStripMenuItem;
            size1 = new Size(274, 22);
            Size size10 = size1;
            toolStripMenuItem7.Size = size10;
            this.SortClubAndSUrnameToolStripMenuItem.Text = "Sort by Club and Surname";
            this.AddToStartListToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.AddToStartListToolStripMenuItem.Name = "AddToStartListToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem8 = this.AddToStartListToolStripMenuItem;
            size1 = new Size(129, 20);
            Size size11 = size1;
            toolStripMenuItem8.Size = size11;
            this.AddToStartListToolStripMenuItem.Text = "ADD TO START LIST";
            this.txtNoOfParticipants.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 192);
            this.txtNoOfParticipants.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtNoOfParticipants.Location = new Point(894, 27);
            this.txtNoOfParticipants.Name = "txtNoOfParticipants";
            this.txtNoOfParticipants.ReadOnly = true;
            TextBox noOfParticipants = this.txtNoOfParticipants;
            size1 = new Size(49, 20);
            Size size12 = size1;
            noOfParticipants.Size = size12;
            this.txtNoOfParticipants.TabIndex = 9;
            this.txtNoOfParticipants.TextAlign = HorizontalAlignment.Center;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle1.BackColor = SystemColors.Control;
            gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            gridViewCellStyle1.ForeColor = SystemColors.WindowText;
            gridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            gridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            gridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange((DataGridViewColumn)this.Column1, (DataGridViewColumn)this.Column2, (DataGridViewColumn)this.Column3, (DataGridViewColumn)this.Column4, (DataGridViewColumn)this.Column5, (DataGridViewColumn)this.Column6, (DataGridViewColumn)this.Column7, (DataGridViewColumn)this.Column8, (DataGridViewColumn)this.Column9, (DataGridViewColumn)this.IndTADiscipline, (DataGridViewColumn)this.Column10);
            this.DataGridView1.Location = new Point(0, 53);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.ScrollBars = ScrollBars.Vertical;
            this.DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView dataGridView1 = this.DataGridView1;
            size1 = new Size(1145, 403);
            Size size13 = size1;
            dataGridView1.Size = size13;
            this.DataGridView1.TabIndex = 10;
            gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column1.DefaultCellStyle = gridViewCellStyle2;
            this.Column1.HeaderText = "IndTA Discipline";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column2.DefaultCellStyle = gridViewCellStyle3;
            this.Column2.HeaderText = "IndTA Class";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column3.DefaultCellStyle = gridViewCellStyle4;
            this.Column3.HeaderText = "First Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column4.DefaultCellStyle = gridViewCellStyle5;
            this.Column4.HeaderText = "Surname";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column5.DefaultCellStyle = gridViewCellStyle6;
            this.Column5.HeaderText = "Club";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column6.DefaultCellStyle = gridViewCellStyle7;
            this.Column6.HeaderText = "PPC Seg. 1";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column7.DefaultCellStyle = gridViewCellStyle8;
            this.Column7.HeaderText = "PPC Seg. 2";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column8.DefaultCellStyle = gridViewCellStyle9;
            this.Column8.HeaderText = "PID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column9.DefaultCellStyle = gridViewCellStyle10;
            this.Column9.HeaderText = "Club ID";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.IndTADiscipline.DefaultCellStyle = gridViewCellStyle11;
            this.IndTADiscipline.HeaderText = "IndTA ClassID";
            this.IndTADiscipline.Name = "IndTADiscipline";
            this.IndTADiscipline.ReadOnly = true;
            this.IndTADiscipline.SortMode = DataGridViewColumnSortMode.NotSortable;
            gridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Column10.DefaultCellStyle = gridViewCellStyle12;
            this.Column10.HeaderText = "Not in use";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new Point(800, 30);
            this.Label1.Name = "Label1";
            Label label1 = this.Label1;
            size1 = new Size(88, 13);
            Size size14 = size1;
            label1.Size = size14;
            this.Label1.TabIndex = 11;
            this.Label1.Text = "No. in Startlist";
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new Point(8, 30);
            this.Label2.Name = "Label2";
            Label label2 = this.Label2;
            size1 = new Size(74, 13);
            Size size15 = size1;
            label2.Size = size15;
            this.Label2.TabIndex = 13;
            this.Label2.Text = "CATEGORY";
            this.txtCategory.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 192);
            this.txtCategory.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtCategory.Location = new Point(88, 27);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            TextBox txtCategory = this.txtCategory;
            size1 = new Size(164, 20);
            Size size16 = size1;
            txtCategory.Size = size16;
            this.txtCategory.TabIndex = 12;
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new Point(262, 30);
            this.Label3.Name = "Label3";
            Label label3 = this.Label3;
            size1 = new Size(99, 13);
            Size size17 = size1;
            label3.Size = size17;
            this.Label3.TabIndex = 15;
            this.Label3.Text = "SUBCATEGORY";
            this.txtSubcategory.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 192);
            this.txtSubcategory.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtSubcategory.Location = new Point(367, 27);
            this.txtSubcategory.Name = "txtSubcategory";
            this.txtSubcategory.ReadOnly = true;
            TextBox txtSubcategory = this.txtSubcategory;
            size1 = new Size(164, 20);
            Size size18 = size1;
            txtSubcategory.Size = size18;
            this.txtSubcategory.TabIndex = 14;
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label4.Location = new Point(550, 30);
            this.Label4.Name = "Label4";
            Label label4 = this.Label4;
            size1 = new Size(102, 13);
            Size size19 = size1;
            label4.Size = size19;
            this.Label4.TabIndex = 17;
            this.Label4.Text = "Selected skaters";
            this.txtNoIndTA.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 192);
            this.txtNoIndTA.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtNoIndTA.Location = new Point(737, 27);
            this.txtNoIndTA.Name = "txtNoIndTA";
            this.txtNoIndTA.ReadOnly = true;
            TextBox txtNoIndTa = this.txtNoIndTA;
            size1 = new Size(49, 20);
            Size size20 = size1;
            txtNoIndTa.Size = size20;
            this.txtNoIndTA.TabIndex = 16;
            this.txtNoIndTA.TextAlign = HorizontalAlignment.Center;
            this.ContextMenuStrip1.Items.AddRange(new ToolStripItem[1]
            {
        (ToolStripItem) this.ToolStripMenuItem1
            });
            this.ContextMenuStrip1.Name = "ContextMenuStrip1";
            ContextMenuStrip contextMenuStrip1 = this.ContextMenuStrip1;
            size1 = new Size(193, 26);
            Size size21 = size1;
            contextMenuStrip1.Size = size21;
            this.ToolStripMenuItem1.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            ToolStripMenuItem toolStripMenuItem1_1 = this.ToolStripMenuItem1;
            size1 = new Size(192, 22);
            Size size22 = size1;
            toolStripMenuItem1_1.Size = size22;
            this.ToolStripMenuItem1.Text = "ADD TO STARTLIST";
            this.Label5.AutoSize = true;
            this.Label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label5.Location = new Point(713, 30);
            this.Label5.Name = "Label5";
            Label label5 = this.Label5;
            size1 = new Size(18, 13);
            Size size23 = size1;
            label5.Size = size23;
            this.Label5.TabIndex = 18;
            this.Label5.Text = "of";
            this.txtSelected.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 192);
            this.txtSelected.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtSelected.Location = new Point(658, 27);
            this.txtSelected.Name = "txtSelected";
            this.txtSelected.ReadOnly = true;
            TextBox txtSelected = this.txtSelected;
            size1 = new Size(49, 20);
            Size size24 = size1;
            txtSelected.Size = size24;
            this.txtSelected.TabIndex = 19;
            this.txtSelected.TextAlign = HorizontalAlignment.Center;
            this.txtIndTAGet.Location = new Point(894, 0);
            this.txtIndTAGet.Name = "txtIndTAGet";
            TextBox txtIndTaGet = this.txtIndTAGet;
            size1 = new Size(49, 20);
            Size size25 = size1;
            txtIndTaGet.Size = size25;
            this.txtIndTAGet.TabIndex = 20;
            this.txtIndTAGet.Visible = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(1320, 458);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.txtIndTAGet);
            this.Controls.Add((Control)this.txtSelected);
            this.Controls.Add((Control)this.Label5);
            this.Controls.Add((Control)this.Label4);
            this.Controls.Add((Control)this.txtNoIndTA);
            this.Controls.Add((Control)this.Label3);
            this.Controls.Add((Control)this.txtSubcategory);
            this.Controls.Add((Control)this.Label2);
            this.Controls.Add((Control)this.txtCategory);
            this.Controls.Add((Control)this.Label1);
            this.Controls.Add((Control)this.DataGridView1);
            this.Controls.Add((Control)this.txtNoOfParticipants);
            this.Controls.Add((Control)this.MenuStrip1);
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.Name = nameof(Form12);
            this.Text = "IndTA Entries";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((ISupportInitialize)this.DataGridView1).EndInit();
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

        internal virtual ToolStripMenuItem ExitToolStripMenuItem
        {
            get => this._ExitToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ExitToolStripMenuItem_Click);
                if (this._ExitToolStripMenuItem != null)
                    this._ExitToolStripMenuItem.Click -= eventHandler;
                this._ExitToolStripMenuItem = value;
                if (this._ExitToolStripMenuItem == null)
                    return;
                this._ExitToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem AddToStartListToolStripMenuItem
        {
            get => this._AddToStartListToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.AddToStartListToolStripMenuItem_Click);
                if (this._AddToStartListToolStripMenuItem != null)
                    this._AddToStartListToolStripMenuItem.Click -= eventHandler;
                this._AddToStartListToolStripMenuItem = value;
                if (this._AddToStartListToolStripMenuItem == null)
                    return;
                this._AddToStartListToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual TextBox txtNoOfParticipants
        {
            get => this._txtNoOfParticipants;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtNoOfParticipants = value;
        }

        internal virtual DataGridView DataGridView1
        {
            get => this._DataGridView1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.DataGridView1_SelectionChanged);
                if (this._DataGridView1 != null)
                    this._DataGridView1.SelectionChanged -= eventHandler;
                this._DataGridView1 = value;
                if (this._DataGridView1 == null)
                    return;
                this._DataGridView1.SelectionChanged += eventHandler;
            }
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

        internal virtual TextBox txtCategory
        {
            get => this._txtCategory;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtCategory = value;
        }

        internal virtual Label Label3
        {
            get => this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label3 = value;
        }

        internal virtual TextBox txtSubcategory
        {
            get => this._txtSubcategory;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtSubcategory = value;
        }

        internal virtual ToolStripMenuItem SORTERAToolStripMenuItem
        {
            get => this._SORTERAToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._SORTERAToolStripMenuItem = value;
        }

        internal virtual ToolStripMenuItem SortClassToolStripMenuItem
        {
            get => this._SortClassToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.SortClassToolStripMenuItem_Click);
                if (this._SortClassToolStripMenuItem != null)
                    this._SortClassToolStripMenuItem.Click -= eventHandler;
                this._SortClassToolStripMenuItem = value;
                if (this._SortClassToolStripMenuItem == null)
                    return;
                this._SortClassToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem SortClassAndClubToolStripMenuItem
        {
            get => this._SortClassAndClubToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.SortClassAndClubToolStripMenuItem_Click);
                if (this._SortClassAndClubToolStripMenuItem != null)
                    this._SortClassAndClubToolStripMenuItem.Click -= eventHandler;
                this._SortClassAndClubToolStripMenuItem = value;
                if (this._SortClassAndClubToolStripMenuItem == null)
                    return;
                this._SortClassAndClubToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem SortClassClubAndSurnameToolStripMenuItem
        {
            get => this._SortClassClubAndSurnameToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.SortClassClubAndSurnameToolStripMenuItem_Click);
                if (this._SortClassClubAndSurnameToolStripMenuItem != null)
                    this._SortClassClubAndSurnameToolStripMenuItem.Click -= eventHandler;
                this._SortClassClubAndSurnameToolStripMenuItem = value;
                if (this._SortClassClubAndSurnameToolStripMenuItem == null)
                    return;
                this._SortClassClubAndSurnameToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            get => this._ToolStripSeparator1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ToolStripSeparator1 = value;
        }

        internal virtual ToolStripMenuItem SörtSurnameToolStripMenuItem
        {
            get => this._SörtSurnameToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.SörtSurnameToolStripMenuItem_Click);
                if (this._SörtSurnameToolStripMenuItem != null)
                    this._SörtSurnameToolStripMenuItem.Click -= eventHandler;
                this._SörtSurnameToolStripMenuItem = value;
                if (this._SörtSurnameToolStripMenuItem == null)
                    return;
                this._SörtSurnameToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem SortClubAndSUrnameToolStripMenuItem
        {
            get => this._SortClubAndSUrnameToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.SortClubAndSUrnameToolStripMenuItem_Click);
                if (this._SortClubAndSUrnameToolStripMenuItem != null)
                    this._SortClubAndSUrnameToolStripMenuItem.Click -= eventHandler;
                this._SortClubAndSUrnameToolStripMenuItem = value;
                if (this._SortClubAndSUrnameToolStripMenuItem == null)
                    return;
                this._SortClubAndSUrnameToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual Label Label4
        {
            get => this._Label4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label4 = value;
        }

        internal virtual TextBox txtNoIndTA
        {
            get => this._txtNoIndTA;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtNoIndTA = value;
        }

        internal virtual ContextMenuStrip ContextMenuStrip1
        {
            get => this._ContextMenuStrip1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ContextMenuStrip1 = value;
        }

        internal virtual ToolStripMenuItem ToolStripMenuItem1
        {
            get => this._ToolStripMenuItem1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ToolStripMenuItem1_Click);
                if (this._ToolStripMenuItem1 != null)
                    this._ToolStripMenuItem1.Click -= eventHandler;
                this._ToolStripMenuItem1 = value;
                if (this._ToolStripMenuItem1 == null)
                    return;
                this._ToolStripMenuItem1.Click += eventHandler;
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

        internal virtual DataGridViewTextBoxColumn Column9
        {
            get => this._Column9;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column9 = value;
        }

        internal virtual DataGridViewTextBoxColumn IndTADiscipline
        {
            get => this._IndTADiscipline;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._IndTADiscipline = value;
        }

        internal virtual DataGridViewTextBoxColumn Column10
        {
            get => this._Column10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Column10 = value;
        }

        internal virtual Label Label5
        {
            get => this._Label5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label5 = value;
        }

        internal virtual TextBox txtSelected
        {
            get => this._txtSelected;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtSelected = value;
        }

        internal virtual TextBox txtIndTAGet
        {
            get => this._txtIndTAGet;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtIndTAGet = value;
        }

        private void Form12_FormClosing(object sender, FormClosingEventArgs e) => MyProject.Forms.Form2.TopMost = true;

        private void Form12_Load(object sender, EventArgs e)
        {
            this.Width = 1150;
            this.Left = checked((int)Math.Round(unchecked((double)checked(Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2.0)));
            this.Top = MyProject.Forms.Form2.Top;
            this.TopMost = true;
            Module1.IndTA = (Module1.IndTA_Type[])null;
            Module1.IndTA = new Module1.IndTA_Type[501];
            this.txtNoIndTA.Text = "";
            this.txtCategory.Text = Module1.Category.Name;
            this.txtSubcategory.Text = Module1.SubCategory;
            this.txtNoOfParticipants.Text = Conversions.ToString(Module1.TNop);
            this.IndTA_DB = false;
            this.ShowDatagrid1();
            this.LoadIndTAXMLfile(ref this.IndTA_DB);
            this.LoadIndTA_Data(this.No_Of_IndTA_Skaters);
            this.DataGridView1.ContextMenuStrip = this.ContextMenuStrip1;
        }

        private void ShowDatagrid1()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                dataGridView1.ColumnHeadersVisible = true;
                dataGridView1.ColumnCount = 9;
                dataGridView1.Columns[0].HeaderText = "IndTA Discipline";
                dataGridView1.Columns[1].HeaderText = "IndTA Class";
                dataGridView1.Columns[2].HeaderText = "First Name";
                dataGridView1.Columns[3].HeaderText = "Surname";
                dataGridView1.Columns[4].HeaderText = "Club";
                dataGridView1.Columns[5].HeaderText = "PPC Seg. 1";
                dataGridView1.Columns[6].HeaderText = "PPC Seg. 2";
                dataGridView1.Columns[7].HeaderText = "PID";
                dataGridView1.Columns[8].HeaderText = "Club ID";
                dataGridView1.Width = 1215;
                this.DGW1width = dataGridView1.Width;
                this.Width = checked(this.DGW1width + Module1.WC);
                dataGridView1.Columns[0].Width = 110;
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 150;
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[4].Width = 190;
                dataGridView1.Columns[5].Width = 150;
                dataGridView1.Columns[6].Width = 150;
                dataGridView1.Columns[7].Width = 80;
                dataGridView1.Columns[8].Width = 80;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.ReadOnly = true;
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ShowDatagrid1 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void LoadIndTA_Data(int No)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int index1 = 0;
                string[] strArray = new string[26];
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                int noOfIndTaSkaters = this.No_Of_IndTA_Skaters;
                int index2 = 0;
                while (index2 <= noOfIndTaSkaters)
                {
                    string str;
                    if (Operators.CompareString(this.txtIndTAGet.Text, "2", false) == 0)
                    {
                        strArray = Strings.UCase(Module1.IndTA[index2].Klass).Split(' ');
                        str = Strings.UCase(Module1.Category.Name);
                    }
                    else
                    {
                        str = "1";
                        strArray[0] = str;
                    }
                    if (str.Contains(strArray[0]))
                    {
                        if (No >= 0)
                            dataGridView1.Rows.Add();
                        dataGridView1.Rows[index1].Cells[0].Value = (object)Module1.IndTA[index2].Discipline;
                        dataGridView1.Rows[index1].Cells[1].Value = (object)Module1.IndTA[index2].Klass;
                        dataGridView1.Rows[index1].Cells[2].Value = (object)Module1.IndTA[index2].FirstName;
                        dataGridView1.Rows[index1].Cells[3].Value = (object)Module1.IndTA[index2].Surname;
                        dataGridView1.Rows[index1].Cells[4].Value = (object)Module1.IndTA[index2].Club;
                        dataGridView1.Rows[index1].Cells[5].Value = (object)Module1.IndTA[index2].PPC_S1;
                        dataGridView1.Rows[index1].Cells[6].Value = (object)Module1.IndTA[index2].PPC_S2;
                        dataGridView1.Rows[index1].Cells[7].Value = (object)Module1.IndTA[index2].Participant_ID;
                        dataGridView1.Rows[index1].Cells[8].Value = (object)Module1.IndTA[index2].Club_ID;
                        checked { ++index1; }
                    }
                    checked { ++index2; }
                }
                this.F12Height = checked(this.DataGridView1.RowCount * 22 + this.DataGridView1.ColumnHeadersHeight + this.DataGridView1.Location.Y + Module1.HC);
                if (this.F12Height < checked(Screen.PrimaryScreen.WorkingArea.Height - 100))
                {
                    this.Height = this.F12Height;
                    this.DataGridView1.Width = this.DGW1width;
                    this.Width = checked(this.DGW1width + Module1.WC);
                }
                else
                {
                    this.Height = checked(Screen.PrimaryScreen.WorkingArea.Height - 100);
                    this.DataGridView1.Width = checked(this.DGW1width + Module1.WC1);
                    this.Width = checked(this.DGW1width + Module1.WC2);
                }
                dataGridView1.ClearSelection();
                this.LoadedGrid = true;
                goto label_20;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("LoadIndTA_Data - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_20:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (!this.LoadedGrid)
                return;
            DataGridView dataGridView1 = this.DataGridView1;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (rowIndex <= this.No_Of_IndTA_Skaters)
            {
                dataGridView1.Rows[rowIndex].Selected = true;
                this.txtSelected.Text = Conversions.ToString(dataGridView1.SelectedRows.Count);
            }
            else
            {
                this.txtSelected.Text = Conversions.ToString(0);
                dataGridView1.ClearSelection();
            }
        }

        public void LoadIndTAXMLfile(ref bool IndTA_DB)
        {
            Stream stream = (Stream)null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "LOAD A IndTA FILE";
            openFileDialog.InitialDirectory = Conversions.ToString(Operators.CompareString(openFileDialog.Filter, "IndTA files (*.xml)|*.xml|All files (*.*)|*.*", false) == 0);
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                stream = openFileDialog.OpenFile();
                if (stream == null)
                    return;
                string fileName = openFileDialog.FileName;
                this.LoadIndTAFile(openFileDialog.FileName, ref IndTA_DB);
            }
            catch (Exception ex)
            {
                ProjectData.SetProjectError(ex);
                int num = (int)MessageBox.Show("Cannot read file from disk. Original error: " + ex.Message);
                ProjectData.ClearProjectError();
            }
            finally
            {
                stream?.Close();
            }
        }

        public void LoadIndTAFile(string File, ref bool IndTA_DB)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string myDiscipline = "";
                string myClas = "";
                string CatID = "";
                string stxt = "";
                ProjectData.ClearProjectError();
                num1 = 2;
                int ind = 0;
                using (XmlReader MyReader = XmlReader.Create(File))
                {
                    while (MyReader.Read())
                    {
                        if (MyReader.NodeType == XmlNodeType.Element)
                        {
                            if (!IndTA_DB)
                            {
                                if (Operators.CompareString(MyReader.Name, "IndTAEntries", false) == 0)
                                {
                                    MyReader.MoveToAttribute(0);
                                    string attribute = MyReader.GetAttribute(2);
                                    MyReader.MoveToElement();
                                    if (Operators.CompareString(attribute, "2.0", false) == 0)
                                    {
                                        IndTA_DB = true;
                                    }
                                    else
                                    {
                                        IndTA_DB = false;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                string name = MyReader.Name;
                                if (Operators.CompareString(name, "CompetitionHeader", false) == 0)
                                    this.ParseIndTACompetitionHeader(MyReader);
                                else if (Operators.CompareString(name, "ClassDiscipline", false) == 0)
                                {
                                    this.ParseIndTAClassDiscipline(MyReader, ref myDiscipline, ref myClas, ref CatID, ref stxt);
                                    if (Operators.CompareString(Strings.UCase(myDiscipline), Strings.UCase("Singel"), false) != 0)
                                    {
                                        IndTA_DB = false;
                                        break;
                                    }
                                }
                                else if (Operators.CompareString(name, "Person", false) == 0)
                                {
                                    this.ParseIndTAPerson(MyReader, myDiscipline, myClas, CatID, ind);
                                    checked { ++ind; }
                                    if (ind >= 500)
                                    {
                                        int num3 = (int)Interaction.MsgBox((object)"Passed max number of skaters!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                        break;
                                    }
                                }
                                else if (Operators.CompareString(name, "PPCEntry", false) == 0 && ind > 0)
                                    this.ParseIndTAExtendedProperty(MyReader, checked(ind - 1));
                            }
                        }
                    }
                }
                if (!IndTA_DB)
                {
                    int num4 = (int)Interaction.MsgBox((object)"This is not an IndTA 2.0 entry file for single skating!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
                this.txtNoIndTA.Text = Conversions.ToString(ind);
                this.No_Of_IndTA_Skaters = checked(ind - 1);
                this.widthcorr = true;
                goto label_31;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("LoadIndTAFile - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_31:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Form12_SizeChanged(object sender, EventArgs e)
        {
            if (!this.widthcorr)
                return;
            if (this.Height < this.F12Height)
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

        public void ParseIndTAEventHeader(XmlReader MyReader)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                MyReader.ReadToFollowing("EventName");
                this.Text = "IndTA Entries: " + MyReader.ReadString();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ParseIndTAEventnHeader - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void ParseIndTACompetitionHeader(XmlReader MyReader)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                MyReader.MoveToAttribute(0);
                string attribute1 = MyReader.GetAttribute(0);
                string[] strArray1 = new string[16];
                char[] chArray1 = new char[1] { '/' };
                string[] strArray2 = attribute1.Split(chArray1);
                Module1.Competition.ID = strArray2[1];
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("CompetitionName");
                this.MyCompetitionName = MyReader.ReadString();
                MyReader.ReadToFollowing("CompetitionDate");
                MyReader.ReadString();
                MyReader.ReadToFollowing("CompetitionType");
                Module1.Competition.Type = MyReader.ReadString();
                this.Text = "IndTA Entries: " + this.MyCompetitionName + ", ID: " + Module1.Competition.ID + " - " + Module1.Competition.Type;
                MyReader.ReadToFollowing("CompetitionOrganization");
                MyReader.MoveToAttribute(0);
                string attribute2 = MyReader.GetAttribute(0);
                string[] strArray3 = new string[16];
                char[] chArray2 = new char[1] { '/' };
                string[] strArray4 = attribute2.Split(chArray2);
                Module1.Organizer.ID = strArray4[1];
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("OrganizationName");
                Module1.Organizer.Name = MyReader.ReadString();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ParseIndTACompetitionHeader - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void ParseIndTAClassDiscipline(
          XmlReader MyReader,
          ref string myDiscipline,
          ref string myClas,
          ref string CatID,
          ref string stxt)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                MyReader.ReadToFollowing("Class");
                myClas = MyReader.ReadString();
                MyReader.ReadToFollowing("Discipline");
                myDiscipline = MyReader.ReadString();
                CatID = "Saknas";
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ParseIndTAClassDiscipline - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void ParseIndTAPerson(
          XmlReader MyReader,
          string pmyDiscipline,
          string pmyClass,
          string catID,
          int ind)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Module1.IndTA_Type[] indTa = Module1.IndTA;
                int index = ind;
                indTa[index].Discipline = pmyDiscipline;
                indTa[index].Klass = pmyClass;
                MyReader.ReadToFollowing("FirstName");
                indTa[index].FirstName = MyReader.ReadString();
                MyReader.ReadToFollowing("SurName");
                indTa[index].Surname = MyReader.ReadString();
                MyReader.ReadToFollowing("IdrottOnlineID");
                indTa[index].Participant_ID = MyReader.ReadString();
                MyReader.ReadToFollowing("Organization");
                MyReader.MoveToAttribute(0);
                string attribute = MyReader.GetAttribute(0);
                string[] strArray1 = new string[16];
                char[] chArray = new char[1] { '/' };
                string[] strArray2 = attribute.Split(chArray);
                indTa[index].Club_ID = strArray2[1];
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("OrganizationName");
                indTa[index].Club = MyReader.ReadString();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ParseIndTAPerson - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void ParseIndTAExtendedProperty(XmlReader MyReader, int ind)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Module1.IndTA_Type[] indTa = Module1.IndTA;
                int index = ind;
                MyReader.ReadToFollowing("Type");
                string Left = MyReader.ReadString();
                if (Operators.CompareString(Left, "Kortprogram", false) == 0)
                {
                    MyReader.ReadToFollowing("PPC");
                    indTa[index].PPC_S1 = MyReader.ReadString();
                    goto label_10;
                }
                else if (Operators.CompareString(Left, "Friåkning", false) == 0)
                {
                    MyReader.ReadToFollowing("PPC");
                    indTa[index].PPC_S2 = MyReader.ReadString();
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
                int num3 = (int)Interaction.MsgBox((object)("ParseIndTAExtendedProperty - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_10:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private bool AddToStartList()
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                if (dataGridView1.CurrentCell.RowIndex >= checked(dataGridView1.Rows.Count - 1))
                {
                    int num3 = (int)Interaction.MsgBox((object)"Wrong selection of row!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    flag = false;
                    goto label_25;
                }
                else
                {
                    switch (dataGridView1.CurrentCell.ColumnIndex)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            flag = true;
                            int num4 = Module1.IndexEmptyRow();
                            Module1.TNop = num4;
                            int num5 = checked(dataGridView1.Rows.Count - 1);
                            int index1 = 0;
                            while (index1 <= num5)
                            {
                                if ((dataGridView1.Rows[index1].Cells[0].Selected | dataGridView1.Rows[index1].Cells[1].Selected | dataGridView1.Rows[index1].Cells[2].Selected | dataGridView1.Rows[index1].Cells[3].Selected | dataGridView1.Rows[index1].Cells[4].Selected) & Strings.Len(RuntimeHelpers.GetObjectValue(dataGridView1.Rows[index1].Cells[1].Value)) > 1)
                                {
                                    if (num4 < 42)
                                    {
                                        Module1.Vek[checked(num4 + 1)].Name.FName = this.Get_Cell(index1, 2);
                                        Module1.Vek[checked(num4 + 1)].Name.LName = this.Get_Cell(index1, 3);
                                        Module1.Vek[checked(num4 + 1)].Name.ID = this.Get_Cell(index1, 7);
                                        Module1.Vek[checked(num4 + 1)].Club = this.Get_Cell(index1, 4);
                                        Module1.Vek[checked(num4 + 1)].ClubID = this.Get_Cell(index1, 8);
                                        Module1.Category.IndTADiscipline = this.Get_Cell(index1, 0);
                                        Module1.Category.IndTAClass = this.Get_Cell(index1, 1);
                                        string cell1 = this.Get_Cell(index1, 5);
                                        string cell2 = this.Get_Cell(index1, 6);
                                        Module1.Vek[checked(num4 + 1)].SSS_Seg1 = (string[])null;
                                        Module1.Vek[checked(num4 + 1)].SSS_Seg1 = new string[16];
                                        if (Strings.Len(cell1) > 0)
                                        {
                                            string[] strArray1 = new string[16];
                                            string[] strArray2 = cell1.Split(';');
                                            int num6 = checked(strArray2.Length - 1);
                                            int index2 = 0;
                                            while (index2 <= num6)
                                            {
                                                Module1.Vek[checked(num4 + 1)].SSS_Seg1[checked(index2 + 1)] = strArray2[index2];
                                                checked { ++index2; }
                                            }
                                        }
                                        Module1.Vek[checked(num4 + 1)].SSS_Seg2 = (string[])null;
                                        Module1.Vek[checked(num4 + 1)].SSS_Seg2 = new string[16];
                                        if (Strings.Len(cell2) > 0)
                                        {
                                            string[] strArray3 = new string[16];
                                            string[] strArray4 = cell2.Split(';');
                                            int num7 = checked(strArray4.Length - 1);
                                            int index3 = 0;
                                            while (index3 <= num7)
                                            {
                                                Module1.Vek[checked(num4 + 1)].SSS_Seg2[checked(index3 + 1)] = strArray4[index3];
                                                checked { ++index3; }
                                            }
                                        }
                                        checked { ++Module1.TNop; }
                                        checked { ++num4; }
                                    }
                                    else
                                    {
                                        int num8 = (int)Interaction.MsgBox((object)"Max no. of participants in a category reached!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                        goto label_25;
                                    }
                                }
                                checked { ++index1; }
                            }
                            MyProject.Forms.Form1.txtParticipants.Text = Conversions.ToString(Module1.TNop);
                            goto label_25;
                        default:
                            flag = false;
                            int num9 = (int)Interaction.MsgBox((object)"Wrong selection of column!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            goto label_25;
                    }
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                flag = false;
                int num10 = (int)Interaction.MsgBox((object)("AddToStartList - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_25:
            int num11 = flag ? 1 : 0;
            if (num2 == 0)
                return num11 != 0;
            ProjectData.ClearProjectError();
            return num11 != 0;
        }

        public string Get_Cell(int index, int col) => Conversions.ToString(this.DataGridView1.Rows[index].Cells[col].Value);

        public void GetEl(ref string[] elarr, string elstr)
        {
            int index1 = 1;
            do
            {
                elarr[index1] = "";
                checked { ++index1; }
            }
            while (index1 <= 15);
            if (Strings.Len(elstr) <= 0)
                return;
            string[] strArray = elstr.Split(';');
            int num = checked(strArray.Length - 1);
            int index2 = 0;
            while (index2 <= num)
            {
                elarr[checked(index2 + 1)] = strArray[index2];
                checked { ++index2; }
            }
        }

        public void ShowOnePPC(string name, string[] elarr)
        {
            string str = "";
            int index = 1;
            do
            {
                str = str + elarr[index] + ";";
                checked { ++index; }
            }
            while (index <= 15);
            int num = (int)Interaction.MsgBox((object)(name + " - " + str));
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
                    int num = (int)Interaction.MsgBox((object)(Module1.Vek[index1].Name.FName + " " + Module1.Vek[index1].Name.LName + " - " + str));
                }
                checked { ++index1; }
            }
            while (index1 <= 42);
        }

        private void AddToStartListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.AddToStartList())
                return;
            this.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form2))
            {
                MyProject.Forms.Form2.WillExitForm2 = true;
                MyProject.Forms.Form2.Close();
            }
            if (Operators.CompareString(this.MyCompetitionName, Module1.Competition.Name, false) != 0 && Interaction.MsgBox((object)"Do you want to change the Competition name?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.Yes)
            {
                Module1.Competition.Name = this.MyCompetitionName;
                MyProject.Forms.Form1.txtCompetitionName.Text = this.MyCompetitionName;
            }
            MyProject.Forms.Form2.TopMost = true;
            MyProject.Forms.Form2.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form2))
            {
                MyProject.Forms.Form2.WillExitForm2 = true;
                MyProject.Forms.Form2.Close();
            }
            Form1 form1 = MyProject.Forms.Form1;
            this.UpdateForm1();
            MyProject.Forms.Form2.TopMost = true;
            MyProject.Forms.Form2.Show();
        }

        private void UpdateForm1()
        {
            Form1 form1 = MyProject.Forms.Form1;
            form1.txtOrganizerName.Text = Module1.Organizer.Name;
            form1.txtOrganizerID.Text = Module1.Organizer.ID;
            form1.txtCompetitionID.Text = Module1.Competition.ID;
            form1.txtType.Text = Module1.Competition.Type;
            form1.txtCategoryID.Text = Module1.Category.ID;
            form1.txtIndTADiscipline.Text = Module1.Category.IndTADiscipline;
            form1.txtIndTAClass.Text = Module1.Category.IndTAClass;
        }

        public void Sort_IndTA_Klass(int No)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int num3 = checked(No - 1);
                int index1 = 0;
                while (index1 <= num3)
                {
                    Module1.IndTA_Type indTaType = Module1.IndTA[index1];
                    int index2 = index1;
                    int num4 = checked(index1 + 1);
                    int num5 = No;
                    int index3 = num4;
                    while (index3 <= num5)
                    {
                        if (Operators.CompareString(Module1.IndTA[index3].Klass, indTaType.Klass, false) < 0)
                        {
                            indTaType = Module1.IndTA[index3];
                            index2 = index3;
                        }
                        checked { ++index3; }
                    }
                    Module1.IndTA[index2] = Module1.IndTA[index1];
                    Module1.IndTA[index1] = indTaType;
                    checked { ++index1; }
                }
                goto label_14;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num6 = (int)Interaction.MsgBox((object)(" Form2.Sort_Start - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_14:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void Sort_IndTA_Klass_Club(int No)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                string klass = Module1.IndTA[0].Klass;
                int start = 0;
                int num3 = checked(No + 1);
                int index = 1;
                while (index <= num3)
                {
                    if (Operators.CompareString(klass, Module1.IndTA[index].Klass, false) != 0)
                    {
                        int stopp = checked(index - 1);
                        this.Sort_IndTA_Club(start, stopp);
                        klass = Module1.IndTA[index].Klass;
                        start = index;
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
                int num4 = (int)Interaction.MsgBox((object)("Form12.Sort_IndTA_Klass_Club - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_11:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void Sort_IndTA_Club(int start, int stopp)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int num3 = start;
                int num4 = checked(stopp - 1);
                int index1 = num3;
                while (index1 <= num4)
                {
                    Module1.IndTA_Type indTaType = Module1.IndTA[index1];
                    int index2 = index1;
                    int num5 = checked(index1 + 1);
                    int num6 = stopp;
                    int index3 = num5;
                    while (index3 <= num6)
                    {
                        if (Operators.CompareString(Module1.IndTA[index3].Club, indTaType.Club, false) < 0)
                        {
                            indTaType = Module1.IndTA[index3];
                            index2 = index3;
                        }
                        checked { ++index3; }
                    }
                    Module1.IndTA[index2] = Module1.IndTA[index1];
                    Module1.IndTA[index1] = indTaType;
                    checked { ++index1; }
                }
                goto label_14;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num7 = (int)Interaction.MsgBox((object)("Form2.Sort_IndTA_Club - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_14:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void Sort_IndTA_Klass_Club_Surname(int no)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                string klass = Module1.IndTA[0].Klass;
                string club = Module1.IndTA[0].Club;
                int start = 0;
                int num3 = checked(no + 1);
                int index = 1;
                while (index <= num3)
                {
                    if (Operators.CompareString(klass, Module1.IndTA[index].Klass, false) != 0 | Operators.CompareString(club, Module1.IndTA[index].Club, false) != 0)
                    {
                        int stopp = checked(index - 1);
                        this.Sort_IndTA_Surname(start, stopp);
                        klass = Module1.IndTA[index].Klass;
                        club = Module1.IndTA[index].Club;
                        start = index;
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
                int num4 = (int)Interaction.MsgBox((object)("Form12.Sort_IndTA_Klass_Club_Surname - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_11:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void Sort_IndTA_Club_Surname(int No)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                string club = Module1.IndTA[0].Club;
                int start = 0;
                int num3 = checked(No + 1);
                int index = 1;
                while (index <= num3)
                {
                    if (Operators.CompareString(club, Module1.IndTA[index].Club, false) != 0)
                    {
                        int stopp = checked(index - 1);
                        this.Sort_IndTA_Surname(start, stopp);
                        club = Module1.IndTA[index].Club;
                        start = index;
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
                int num4 = (int)Interaction.MsgBox((object)("Form12.Sort_IndTA_Klass_Club - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_11:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void Sort_IndTA_Surname(int start, int stopp)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int num3 = start;
                int num4 = checked(stopp - 1);
                int index1 = num3;
                while (index1 <= num4)
                {
                    Module1.IndTA_Type indTaType = Module1.IndTA[index1];
                    int index2 = index1;
                    int num5 = checked(index1 + 1);
                    int num6 = stopp;
                    int index3 = num5;
                    while (index3 <= num6)
                    {
                        if (Operators.CompareString(Module1.IndTA[index3].Surname, indTaType.Surname, false) < 0)
                        {
                            indTaType = Module1.IndTA[index3];
                            index2 = index3;
                        }
                        checked { ++index3; }
                    }
                    Module1.IndTA[index2] = Module1.IndTA[index1];
                    Module1.IndTA[index1] = indTaType;
                    checked { ++index1; }
                }
                goto label_14;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num7 = (int)Interaction.MsgBox((object)("Form12.Sort_IndTA_Surname - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_14:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void SortClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Sort_IndTA_Klass(this.No_Of_IndTA_Skaters);
            this.LoadIndTA_Data(-1);
        }

        private void SortClassAndClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Sort_IndTA_Klass(this.No_Of_IndTA_Skaters);
            this.Sort_IndTA_Klass_Club(this.No_Of_IndTA_Skaters);
            this.LoadIndTA_Data(-1);
        }

        private void SortClassClubAndSurnameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Sort_IndTA_Klass(this.No_Of_IndTA_Skaters);
            this.Sort_IndTA_Klass_Club(this.No_Of_IndTA_Skaters);
            this.Sort_IndTA_Klass_Club_Surname(this.No_Of_IndTA_Skaters);
            this.LoadIndTA_Data(-1);
        }

        private void SörtSurnameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Sort_IndTA_Surname(0, this.No_Of_IndTA_Skaters);
            this.LoadIndTA_Data(-1);
        }

        private void SortClubAndSUrnameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Sort_IndTA_Club(0, this.No_Of_IndTA_Skaters);
            this.Sort_IndTA_Club_Surname(this.No_Of_IndTA_Skaters);
            this.LoadIndTA_Data(-1);
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!this.AddToStartList())
                return;
            this.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form2))
            {
                MyProject.Forms.Form2.WillExitForm2 = true;
                MyProject.Forms.Form2.Close();
            }
            if (Operators.CompareString(this.MyCompetitionName, Module1.Competition.Name, false) != 0 && Interaction.MsgBox((object)"Do you want to change the Competition name?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.Yes)
            {
                Module1.Competition.Name = this.MyCompetitionName;
                MyProject.Forms.Form1.txtCompetitionName.Text = this.MyCompetitionName;
            }
            MyProject.Forms.Form2.TopMost = true;
            MyProject.Forms.Form2.Show();
        }
    }
}

// Decompiled with JetBrains decompiler
// Type: ClubCompFS.ElementDBDisplayForm
// Assembly: ClubCompFS_10p0p6, Version=1.0.0.6, Culture=neutral, PublicKeyToken=null
// MVID: 18AFA868-014F-449A-91A2-9536DA06DEFC
// Assembly location: E:\zz Personal_Doc\Personal\Cinzia\ClubCompFS_Version2_Oct2020_NEW3\ClubCompFS_NEW2.exe

using ClubCompFS.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ClubCompFS
{
    [DesignerGenerated]
    public class ElementDBDisplayForm : Form
    {
        private IContainer components;
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
        [AccessedThroughProperty("Column9")]
        private DataGridViewTextBoxColumn _Column9;
        [AccessedThroughProperty("Column10")]
        private DataGridViewTextBoxColumn _Column10;
        [AccessedThroughProperty("Column11")]
        private DataGridViewTextBoxColumn _Column11;
        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;
        [AccessedThroughProperty("EXITToolStripMenuItem")]
        private ToolStripMenuItem _EXITToolStripMenuItem;
        [AccessedThroughProperty("Column12")]
        private DataGridViewTextBoxColumn _Column12;
        [AccessedThroughProperty("Column13")]
        private DataGridViewTextBoxColumn _Column13;
        private int F13Height;
        private int DGW1width;
        private bool widthcorr;

        public ElementDBDisplayForm()
        {
            this.Load += new EventHandler(this.ElementDBDisplayForm_Load);
            this.SizeChanged += new EventHandler(this.ElementDBDisplayForm_SizeChanged1);
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
            DataGridViewCellStyle gridViewCellStyle = new DataGridViewCellStyle();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ElementDBDisplayForm));
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
            this.MenuStrip1 = new MenuStrip();
            this.EXITToolStripMenuItem = new ToolStripMenuItem();
            this.Column12 = new DataGridViewTextBoxColumn();
            this.Column13 = new DataGridViewTextBoxColumn();
            ((ISupportInitialize)this.DataGridView1).BeginInit();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.DataGridView1.AllowUserToResizeRows = false;
            gridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gridViewCellStyle.BackColor = SystemColors.Control;
            gridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            gridViewCellStyle.ForeColor = SystemColors.WindowText;
            gridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
            gridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
            gridViewCellStyle.WrapMode = DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = gridViewCellStyle;
            this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange((DataGridViewColumn)this.Column1, (DataGridViewColumn)this.Column2, (DataGridViewColumn)this.Column3, (DataGridViewColumn)this.Column4, (DataGridViewColumn)this.Column5, (DataGridViewColumn)this.Column6, (DataGridViewColumn)this.Column7, (DataGridViewColumn)this.Column8, (DataGridViewColumn)this.Column9, (DataGridViewColumn)this.Column10, (DataGridViewColumn)this.Column11, (DataGridViewColumn)this.Column12, (DataGridViewColumn)this.Column13);
            this.DataGridView1.Dock = DockStyle.Left;
            this.DataGridView1.Location = new Point(0, 24);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ScrollBars = ScrollBars.Vertical;
            DataGridView dataGridView1 = this.DataGridView1;
            Size size1 = new Size(1283, 430);
            Size size2 = size1;
            dataGridView1.Size = size2;
            this.DataGridView1.TabIndex = 1;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column10.HeaderText = "Column10";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.MenuStrip1.Items.AddRange(new ToolStripItem[1]
            {
        (ToolStripItem) this.EXITToolStripMenuItem
            });
            this.MenuStrip1.Location = new Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            MenuStrip menuStrip1 = this.MenuStrip1;
            size1 = new Size(1334, 24);
            Size size3 = size1;
            menuStrip1.Size = size3;
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            this.EXITToolStripMenuItem.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem = this.EXITToolStripMenuItem;
            size1 = new Size(44, 20);
            Size size4 = size1;
            toolStripMenuItem.Size = size4;
            this.EXITToolStripMenuItem.Text = "EXIT";
            this.Column12.HeaderText = "Column12";
            this.Column12.Name = "Column12";
            this.Column13.HeaderText = "Column13";
            this.Column13.Name = "Column13";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(1334, 454);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.DataGridView1);
            this.Controls.Add((Control)this.MenuStrip1);
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.Name = nameof(ElementDBDisplayForm);
            this.Text = nameof(ElementDBDisplayForm);
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

        internal virtual MenuStrip MenuStrip1
        {
            get => this._MenuStrip1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._MenuStrip1 = value;
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

        private void ElementDBDisplayForm_Load(object sender, EventArgs e)
        {
            this.Top = MyProject.Forms.MainForm.Top;
            this.Left = MyProject.Forms.MainForm.Left;
            this.CereateElementDBDisplay();
        }

        public void CereateElementDBDisplay()
        {
            this.Text = Program.ElementDBver + ", Created: " + Program.DateTimeToStr(Program.ElementDBLastWriteTime);
            DataGridView dataGridView1 = this.DataGridView1;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.ReadOnly = Program.WorkMode > 1;
            dataGridView1.ColumnCount = 12;
            dataGridView1.RowCount = checked(Program.ElDBmax + 1);
            dataGridView1.Columns[0].HeaderText = "Element name";
            dataGridView1.Columns[1].HeaderText = "+++++";
            dataGridView1.Columns[2].HeaderText = "++++";
            dataGridView1.Columns[3].HeaderText = "+++";
            dataGridView1.Columns[4].HeaderText = "++";
            dataGridView1.Columns[5].HeaderText = "+";
            dataGridView1.Columns[6].HeaderText = "Base";
            dataGridView1.Columns[7].HeaderText = "-";
            dataGridView1.Columns[8].HeaderText = "--";
            dataGridView1.Columns[9].HeaderText = "---";
            dataGridView1.Columns[10].HeaderText = "----";
            dataGridView1.Columns[11].HeaderText = "-----";
            dataGridView1.Width = 650;
            this.DGW1width = dataGridView1.Width;
            this.Width = checked(this.DGW1width + Program.WC);
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 50;
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[6].Width = 50;
            dataGridView1.Columns[7].Width = 50;
            dataGridView1.Columns[8].Width = 50;
            dataGridView1.Columns[9].Width = 50;
            dataGridView1.Columns[10].Width = 50;
            dataGridView1.Columns[11].Width = 50;
            dataGridView1.RowHeadersVisible = false;
            int elDbmax = Program.ElDBmax;
            int index = 0;
            while (index <= elDbmax)
            {
                dataGridView1.Rows[index].Cells[0].Value = RuntimeHelpers.GetObjectValue(Program.ElDB[index, 0]);
                dataGridView1.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(Program.ElDB[index, 1]);
                dataGridView1.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(Program.ElDB[index, 2]);
                dataGridView1.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(Program.ElDB[index, 3]);
                dataGridView1.Rows[index].Cells[4].Value = RuntimeHelpers.GetObjectValue(Program.ElDB[index, 4]);
                dataGridView1.Rows[index].Cells[5].Value = RuntimeHelpers.GetObjectValue(Program.ElDB[index, 5]);
                dataGridView1.Rows[index].Cells[6].Value = RuntimeHelpers.GetObjectValue(Program.ElDB[index, 6]);
                dataGridView1.Rows[index].Cells[7].Value = RuntimeHelpers.GetObjectValue(Program.ElDB[index, 7]);
                dataGridView1.Rows[index].Cells[8].Value = RuntimeHelpers.GetObjectValue(Program.ElDB[index, 8]);
                dataGridView1.Rows[index].Cells[9].Value = RuntimeHelpers.GetObjectValue(Program.ElDB[index, 9]);
                dataGridView1.Rows[index].Cells[10].Value = RuntimeHelpers.GetObjectValue(Program.ElDB[index, 10]);
                dataGridView1.Rows[index].Cells[11].Value = RuntimeHelpers.GetObjectValue(Program.ElDB[index, 11]);
                if ((double)index == Conversion.Int((double)index / 2.0) * 2.0)
                    dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightGray;
                checked { ++index; }
            }
            this.F13Height = checked(dataGridView1.Rows.Cast<DataGridViewRow>().Sum<DataGridViewRow>((Func<DataGridViewRow, int>)(r => r.Height)) + dataGridView1.ColumnHeadersHeight + dataGridView1.Location.Y + Program.HC);
            if (this.F13Height < checked(Screen.PrimaryScreen.WorkingArea.Height - 100))
            {
                this.Height = this.F13Height;
                this.DataGridView1.Width = this.DGW1width;
                this.Width = checked(this.DGW1width + Program.WC);
            }
            else
            {
                this.Height = checked(Screen.PrimaryScreen.WorkingArea.Height - 100);
                this.DataGridView1.Width = checked(this.DGW1width + Program.WC1);
                this.Width = checked(this.DGW1width + Program.WC2);
            }
            this.widthcorr = true;
        }

        private void EXITToolStripMenuItem_Click(object sender, EventArgs e) => this.Close();

        private void ElementDBDisplayForm_SizeChanged1(object sender, EventArgs e)
        {
            if (!this.widthcorr)
                return;
            if (this.Height < this.F13Height)
            {
                this.DataGridView1.Width = checked(this.DGW1width + Program.WC1);
                this.Width = checked(this.DGW1width + Program.WC2);
            }
            else
            {
                this.DataGridView1.Width = this.DGW1width;
                this.Width = checked(this.DGW1width + Program.WC);
            }
        }
    }
}

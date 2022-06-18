// Decompiled with JetBrains decompiler
// Type: ClubCompFS.Form7
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
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ClubCompFS
{
    [DesignerGenerated]
    public class Form7 : Form
    {
        private IContainer components;
        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;
        [AccessedThroughProperty("DataGridView1")]
        private DataGridView _DataGridView1;
        [AccessedThroughProperty("txtDate")]
        private TextBox _txtDate;
        [AccessedThroughProperty("txtPar")]
        private TextBox _txtPar;
        [AccessedThroughProperty("txtPartNo")]
        private TextBox _txtPartNo;
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
        [AccessedThroughProperty("ExitToolStripMenuItem")]
        private ToolStripMenuItem _ExitToolStripMenuItem;
        [AccessedThroughProperty("PRINTToolStripMenuItem")]
        private ToolStripMenuItem _PRINTToolStripMenuItem;
        [AccessedThroughProperty("PrintDocument1")]
        private PrintDocument _PrintDocument1;
        [AccessedThroughProperty("PrintPreviewDialog1")]
        private PrintPreviewDialog _PrintPreviewDialog1;
        [AccessedThroughProperty("CREATEPDFToolStripMenuItem")]
        private ToolStripMenuItem _CREATEPDFToolStripMenuItem;
        [AccessedThroughProperty("PrintDialog1")]
        private PrintDialog _PrintDialog1;
        [AccessedThroughProperty("WarmupGroupsToolStripMenuItem")]
        private ToolStripMenuItem _WarmupGroupsToolStripMenuItem;
        [AccessedThroughProperty("StartlistToolStripMenuItem")]
        private ToolStripMenuItem _StartlistToolStripMenuItem;
        [AccessedThroughProperty("CREATETWOPDFToolStripMenuItem")]
        private ToolStripMenuItem _CREATETWOPDFToolStripMenuItem;
        private int mlastRow;
        private object[,] Warr;
        private int F7Height;
        private int DGW1width;
        private bool widthcorr;

        public Form7()
        {
            this.SizeChanged += new EventHandler(this.Form7_SizeChanged);
            this.Load += new EventHandler(this.Form7_Load);
            this.Warr = new object[101, 7];
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
            DataGridViewCellStyle gridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle gridViewCellStyle7 = new DataGridViewCellStyle();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form7));
            this.MenuStrip1 = new MenuStrip();
            this.ExitToolStripMenuItem = new ToolStripMenuItem();
            this.PRINTToolStripMenuItem = new ToolStripMenuItem();
            this.CREATETWOPDFToolStripMenuItem = new ToolStripMenuItem();
            this.CREATEPDFToolStripMenuItem = new ToolStripMenuItem();
            this.WarmupGroupsToolStripMenuItem = new ToolStripMenuItem();
            this.StartlistToolStripMenuItem = new ToolStripMenuItem();
            this.DataGridView1 = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Column5 = new DataGridViewTextBoxColumn();
            this.Column6 = new DataGridViewTextBoxColumn();
            this.Column7 = new DataGridViewTextBoxColumn();
            this.txtDate = new TextBox();
            this.txtPar = new TextBox();
            this.txtPartNo = new TextBox();
            this.PrintDocument1 = new PrintDocument();
            this.PrintPreviewDialog1 = new PrintPreviewDialog();
            this.PrintDialog1 = new PrintDialog();
            this.MenuStrip1.SuspendLayout();
            ((ISupportInitialize)this.DataGridView1).BeginInit();
            this.SuspendLayout();
            this.MenuStrip1.BackColor = SystemColors.Control;
            this.MenuStrip1.Items.AddRange(new ToolStripItem[4]
            {
        (ToolStripItem) this.ExitToolStripMenuItem,
        (ToolStripItem) this.PRINTToolStripMenuItem,
        (ToolStripItem) this.CREATETWOPDFToolStripMenuItem,
        (ToolStripItem) this.CREATEPDFToolStripMenuItem
            });
            this.MenuStrip1.Location = new Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            MenuStrip menuStrip1 = this.MenuStrip1;
            Size size1 = new Size(902, 24);
            Size size2 = size1;
            menuStrip1.Size = size2;
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            this.ExitToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem1 = this.ExitToolStripMenuItem;
            size1 = new Size(44, 20);
            Size size3 = size1;
            toolStripMenuItem1.Size = size3;
            this.ExitToolStripMenuItem.Text = "EXIT";
            this.PRINTToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.PRINTToolStripMenuItem.Name = "PRINTToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem2 = this.PRINTToolStripMenuItem;
            size1 = new Size(53, 20);
            Size size4 = size1;
            toolStripMenuItem2.Size = size4;
            this.PRINTToolStripMenuItem.Text = "PRINT";
            this.CREATETWOPDFToolStripMenuItem.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            this.CREATETWOPDFToolStripMenuItem.Name = "CREATETWOPDFToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem3 = this.CREATETWOPDFToolStripMenuItem;
            size1 = new Size(256, 20);
            Size size5 = size1;
            toolStripMenuItem3.Size = size5;
            this.CREATETWOPDFToolStripMenuItem.Text = "CREATE WARMUP.PDF and STARTLIST.PDF";
            this.CREATEPDFToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
            {
        (ToolStripItem) this.WarmupGroupsToolStripMenuItem,
        (ToolStripItem) this.StartlistToolStripMenuItem
            });
            this.CREATEPDFToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.CREATEPDFToolStripMenuItem.Name = "CREATEPDFToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem4 = this.CREATEPDFToolStripMenuItem;
            size1 = new Size(88, 20);
            Size size6 = size1;
            toolStripMenuItem4.Size = size6;
            this.CREATEPDFToolStripMenuItem.Text = "CREATE  PDF";
            this.CREATEPDFToolStripMenuItem.Visible = false;
            this.WarmupGroupsToolStripMenuItem.Name = "WarmupGroupsToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem5 = this.WarmupGroupsToolStripMenuItem;
            size1 = new Size(165, 22);
            Size size7 = size1;
            toolStripMenuItem5.Size = size7;
            this.WarmupGroupsToolStripMenuItem.Text = "Warmup Groups";
            this.StartlistToolStripMenuItem.Name = "StartlistToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem6 = this.StartlistToolStripMenuItem;
            size1 = new Size(165, 22);
            Size size8 = size1;
            toolStripMenuItem6.Size = size8;
            this.StartlistToolStripMenuItem.Text = "Start List";
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.ColumnHeadersVisible = false;
            this.DataGridView1.Columns.AddRange((DataGridViewColumn)this.Column1, (DataGridViewColumn)this.Column2, (DataGridViewColumn)this.Column3, (DataGridViewColumn)this.Column4, (DataGridViewColumn)this.Column5, (DataGridViewColumn)this.Column6, (DataGridViewColumn)this.Column7);
            this.DataGridView1.Dock = DockStyle.Left;
            this.DataGridView1.Location = new Point(0, 24);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.ScrollBars = ScrollBars.Vertical;
            DataGridView dataGridView1 = this.DataGridView1;
            size1 = new Size(898, 142);
            Size size9 = size1;
            dataGridView1.Size = size9;
            this.DataGridView1.TabIndex = 1;
            this.DataGridView1.Visible = false;
            gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column1.DefaultCellStyle = gridViewCellStyle1;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column2.DefaultCellStyle = gridViewCellStyle2;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column3.DefaultCellStyle = gridViewCellStyle3;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column4.DefaultCellStyle = gridViewCellStyle4;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            gridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column5.DefaultCellStyle = gridViewCellStyle5;
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            gridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column6.DefaultCellStyle = gridViewCellStyle6;
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            gridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column7.DefaultCellStyle = gridViewCellStyle7;
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.txtDate.BackColor = Color.White;
            this.txtDate.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtDate.Location = new Point(449, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            TextBox txtDate = this.txtDate;
            size1 = new Size(155, 20);
            Size size10 = size1;
            txtDate.Size = size10;
            this.txtDate.TabIndex = 5;
            this.txtPar.Location = new Point(610, 2);
            this.txtPar.Name = "txtPar";
            TextBox txtPar = this.txtPar;
            size1 = new Size(45, 20);
            Size size11 = size1;
            txtPar.Size = size11;
            this.txtPar.TabIndex = 21;
            this.txtPar.Visible = false;
            this.txtPartNo.Location = new Point(673, 2);
            this.txtPartNo.Name = "txtPartNo";
            TextBox txtPartNo = this.txtPartNo;
            size1 = new Size(43, 20);
            Size size12 = size1;
            txtPartNo.Size = size12;
            this.txtPartNo.TabIndex = 22;
            this.txtPartNo.Visible = false;
            PrintPreviewDialog printPreviewDialog1_1 = this.PrintPreviewDialog1;
            size1 = new Size(0, 0);
            Size size13 = size1;
            printPreviewDialog1_1.AutoScrollMargin = size13;
            PrintPreviewDialog printPreviewDialog1_2 = this.PrintPreviewDialog1;
            size1 = new Size(0, 0);
            Size size14 = size1;
            printPreviewDialog1_2.AutoScrollMinSize = size14;
            PrintPreviewDialog printPreviewDialog1_3 = this.PrintPreviewDialog1;
            size1 = new Size(400, 300);
            Size size15 = size1;
            printPreviewDialog1_3.ClientSize = size15;
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = (Icon)componentResourceManager.GetObject("PrintPreviewDialog1.Icon");
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            this.PrintDialog1.UseEXDialog = true;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(902, 166);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.txtPartNo);
            this.Controls.Add((Control)this.txtPar);
            this.Controls.Add((Control)this.txtDate);
            this.Controls.Add((Control)this.DataGridView1);
            this.Controls.Add((Control)this.MenuStrip1);
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.Name = nameof(Form7);
            this.Text = "WARMUP GROUPS";
            this.TopMost = true;
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((ISupportInitialize)this.DataGridView1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual MenuStrip MenuStrip1
        {
            get => this._MenuStrip1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._MenuStrip1 = value;
        }

        internal virtual DataGridView DataGridView1
        {
            get => this._DataGridView1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._DataGridView1 = value;
        }

        internal virtual TextBox txtDate
        {
            get => this._txtDate;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtDate = value;
        }

        internal virtual TextBox txtPar
        {
            get => this._txtPar;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtPar = value;
        }

        internal virtual TextBox txtPartNo
        {
            get => this._txtPartNo;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtPartNo = value;
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

        internal virtual ToolStripMenuItem PRINTToolStripMenuItem
        {
            get => this._PRINTToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.PRINTToolStripMenuItem_Click);
                if (this._PRINTToolStripMenuItem != null)
                    this._PRINTToolStripMenuItem.Click -= eventHandler;
                this._PRINTToolStripMenuItem = value;
                if (this._PRINTToolStripMenuItem == null)
                    return;
                this._PRINTToolStripMenuItem.Click += eventHandler;
            }
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

        internal virtual ToolStripMenuItem CREATEPDFToolStripMenuItem
        {
            get => this._CREATEPDFToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.CREATEPDFToolStripMenuItem_Click);
                if (this._CREATEPDFToolStripMenuItem != null)
                    this._CREATEPDFToolStripMenuItem.Click -= eventHandler;
                this._CREATEPDFToolStripMenuItem = value;
                if (this._CREATEPDFToolStripMenuItem == null)
                    return;
                this._CREATEPDFToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual PrintDialog PrintDialog1
        {
            get => this._PrintDialog1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PrintDialog1 = value;
        }

        internal virtual ToolStripMenuItem WarmupGroupsToolStripMenuItem
        {
            get => this._WarmupGroupsToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.WarmupGroupsToolStripMenuItem_Click);
                if (this._WarmupGroupsToolStripMenuItem != null)
                    this._WarmupGroupsToolStripMenuItem.Click -= eventHandler;
                this._WarmupGroupsToolStripMenuItem = value;
                if (this._WarmupGroupsToolStripMenuItem == null)
                    return;
                this._WarmupGroupsToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem StartlistToolStripMenuItem
        {
            get => this._StartlistToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.StartlistToolStripMenuItem_Click);
                if (this._StartlistToolStripMenuItem != null)
                    this._StartlistToolStripMenuItem.Click -= eventHandler;
                this._StartlistToolStripMenuItem = value;
                if (this._StartlistToolStripMenuItem == null)
                    return;
                this._StartlistToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem CREATETWOPDFToolStripMenuItem
        {
            get => this._CREATETWOPDFToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.CREATETWOPDFToolStripMenuItem_Click);
                if (this._CREATETWOPDFToolStripMenuItem != null)
                    this._CREATETWOPDFToolStripMenuItem.Click -= eventHandler;
                this._CREATETWOPDFToolStripMenuItem = value;
                if (this._CREATETWOPDFToolStripMenuItem == null)
                    return;
                this._CREATETWOPDFToolStripMenuItem.Click += eventHandler;
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.Top = MyProject.Forms.MainForm.Top;
            if (Operators.CompareString(this.txtPar.Text, "3", false) == 0)
            {
                this.Left = MyProject.Forms.MainForm.Left;
                this.CREATETWOPDFToolStripMenuItem.Visible = false;
            }
            else
            {
                this.Left = checked(MyProject.Forms.StartListForm.Left + 55);
                this.CREATETWOPDFToolStripMenuItem.Visible = true;
            }
            this.CreateWarmUp();
        }

        public int GetSec(string time)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                num2 = 0;
                int num4;
                int integer1;
                int integer2;
                if (Strings.Len(time) == 5)
                {
                    num4 = 0;
                    integer1 = Conversions.ToInteger(time.Substring(3, 2));
                    integer2 = Conversions.ToInteger(time.Substring(0, 2));
                }
                else
                {
                    num4 = Conversions.ToInteger(time.Substring(6, 2));
                    integer1 = Conversions.ToInteger(time.Substring(3, 2));
                    integer2 = Conversions.ToInteger(time.Substring(0, 2));
                }
                num2 = checked(num4 + integer1 * 60 + integer2 * 3600);
                goto label_9;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num3 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("GetSec - " + Information.Err().Description + "\r\n"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_9:
            int sec = num2;
            if (num3 == 0)
                return sec;
            ProjectData.ClearProjectError();
            return sec;
        }

        public string ConvTime(int time)
        {
            string str = "00";
            if (time == 0)
                str = "00";
            if (time < 10)
                str = "0" + Strings.Trim(Conversions.ToString(time));
            if (time >= 10)
                str = Strings.Trim(Conversions.ToString(time));
            return str;
        }

        public string GetTime(int sec)
        {
            int num1 = 0;
            string str = "";
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int time1 = sec;
                int time2 = checked((int)Math.Round(Conversion.Int(unchecked((double)time1 / 3600.0))));
                if (time2 > 0)
                    checked { time1 -= time2 * 3600; }
                int time3 = checked((int)Math.Round(Conversion.Int(unchecked((double)time1 / 60.0))));
                if (time3 > 0)
                    checked { time1 -= time3 * 60; }
                if (time2 > 23)
                    checked { time2 -= 24; }
                str = this.ConvTime(time2) + ":" + this.ConvTime(time3) + ":" + this.ConvTime(time1);
                goto label_12;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("GetTime - " + Information.Err().Description + "\r\n"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_12:
            string time = str;
            if (num2 == 0)
                return time;
            ProjectData.ClearProjectError();
            return time;
        }

        public void CreateWarmUp()
        {
            if (Operators.CompareString(this.txtPar.Text, "3", false) == 0)
            {
                this.CreateWarmup_2(1);
            }
            else
            {
                this.TopMost = false;
                MyProject.Forms.IceResurfacingMealBreakDialog.txtNoSkater.Text = this.txtPartNo.Text;
                if (Module1.IsFormOpen((Form)MyProject.Forms.IceResurfacingMealBreakDialog))
                    MyProject.Forms.IceResurfacingMealBreakDialog.Close();
                int num = (int)MyProject.Forms.IceResurfacingMealBreakDialog.ShowDialog();
            }
        }

        public void CreateWarmup_2(int GrW)
        {
            int lastrow = 0;
            this.CreateWarr(GrW, ref lastrow);
            this.ShowWarmUp_1(Module1.TNop, lastrow);
        }

        public void CreateWarr(int GrW, ref int lastrow)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int integer1 = Conversions.ToInteger(this.txtPartNo.Text);
                int integer2 = Conversions.ToInteger(this.txtPar.Text);
                string segment1 = Module1.Segment;
                bool flag = true;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    this.txtDate.Text = "DATE: " + Module1.FormShortDate(Module1.Datum.Seg1);
                    int index = 1;
                    do
                    {
                        Module1.Vek[index].WarmUp_Seg1 = 0;
                        checked { ++index; }
                    }
                    while (index <= 42);
                    flag = Module1.RemWarmupTimeSeg1;
                }
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                {
                    this.txtDate.Text = "DATE: " + Module1.FormShortDate(Module1.Datum.Seg2);
                    int index = 1;
                    do
                    {
                        Module1.Vek[index].WarmUp_Seg2 = 0;
                        checked { ++index; }
                    }
                    while (index <= 42);
                    flag = Module1.RemWarmupTimeSeg2;
                }
                this.Warr[0, 0] = (object)"Start no";
                this.Warr[0, 1] = (object)"First Name";
                this.Warr[0, 2] = (object)"Surname";
                this.Warr[0, 3] = (object)"Club";
                this.Warr[0, 4] = integer2 != 2 ? (object)"Info" : (object)"";
                if (integer2 != 0)
                {
                    this.Warr[0, 5] = (object)"Start time";
                    this.Warr[0, 6] = (object)"Finish time";
                }
                if (integer1 > 0)
                {
                    int num3 = 0;
                    int num4 = 0;
                    int num5 = 0;
                    int num6 = 0;
                    object obj = (object)0;
                    int sec1 = 0;
                    if (GrW == 1)
                    {
                        int index = 0;
                        do
                        {
                            Module1.gr[index] = 0;
                            checked { ++index; }
                        }
                        while (index <= 10);
                        this.CalcGroup1(integer1, ref Module1.gr);
                    }
                    if (integer2 != 0)
                    {
                        num6 = this.GetSec(Module1.ResurfacingTime);
                        num5 = this.GetSec(Module1.LunchTime);
                        string segment2 = Module1.Segment;
                        if (Operators.CompareString(segment2, "Seg1", false) == 0)
                        {
                            num3 = this.GetSec(Module1.OpenDB[Module1.PcIndex].JudgeSeg1Time);
                            num4 = this.GetSec(Module1.OpenDB[Module1.PcIndex].Seg1Time);
                            obj = Operators.CompareString(Module1.Datum.Seg1Start, "", false) != 0 ? (object)this.GetSec(Module1.Datum.Seg1Start) : (object)this.GetSec("00:00:00");
                        }
                        else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                        {
                            num3 = this.GetSec(Module1.OpenDB[Module1.PcIndex].JudgeSeg2Time);
                            num4 = this.GetSec(Module1.OpenDB[Module1.PcIndex].Seg2Time);
                            obj = Operators.CompareString(Module1.Datum.Seg2Start, "", false) != 0 ? (object)this.GetSec(Module1.Datum.Seg2Start) : (object)this.GetSec("00:00:00");
                        }
                        sec1 = Conversions.ToInteger(obj);
                    }
                    int index1 = 1;
                    int index2 = 1;
                    int num7 = 1;
                    int num8 = 0;
                    while (Module1.gr[index1] > 0 & index1 <= 7)
                    {
                        int num9 = !(flag & index2 == 1) ? this.GetSec(Module1.WarmUpTime) : this.GetSec("00:00:00");
                        int num10 = !(flag & index2 == 1) ? this.GetSec(Module1.IceLeaveTime) : this.GetSec("00:00:00");
                        checked { num8 += Module1.gr[index1]; }
                        this.Warr[index2, 1] = (object)("Warmup Group " + Conversions.ToString(index1));
                        if (integer2 != 0)
                        {
                            this.Warr[index2, 5] = !(flag & index2 == 1) ? (object)this.GetTime(sec1) : (object)"";
                            int sec2 = checked(sec1 + num9);
                            this.Warr[index2, 6] = !(flag & index2 == 1) ? (object)this.GetTime(sec2) : (object)"";
                            sec1 = checked(sec2 + num10);
                        }
                        checked { ++index2; }
                        int num11 = num7;
                        int num12 = num8;
                        int index3 = num11;
                        while (index3 <= num12)
                        {
                            string segment3 = Module1.Segment;
                            if (Operators.CompareString(segment3, "Seg1", false) == 0)
                            {
                                this.Warr[index2, 0] = (object)Conversions.ToString(Module1.Vek[index3].Startno_Seg1);
                                Module1.Vek[index3].WarmUp_Seg1 = index1;
                                if (integer2 != 2)
                                {
                                    switch (Module1.Vek[index3].DNS_Seg1)
                                    {
                                        case 1:
                                            this.Warr[index2, 4] = (object)"DNS";
                                            break;
                                        case 2:
                                            this.Warr[index2, 4] = (object)"WD";
                                            break;
                                        case 3:
                                            this.Warr[index2, 4] = (object)"DNF";
                                            break;
                                        case 4:
                                            this.Warr[index2, 4] = (object)"DQ";
                                            break;
                                    }
                                }
                            }
                            else if (Operators.CompareString(segment3, "Seg2", false) == 0)
                            {
                                this.Warr[index2, 0] = (object)Conversions.ToString(Module1.Vek[index3].Startno_Seg2);
                                Module1.Vek[index3].WarmUp_Seg2 = index1;
                                if (integer2 != 2)
                                {
                                    switch (Module1.Vek[index3].DNS_Seg2)
                                    {
                                        case 1:
                                            this.Warr[index2, 4] = (object)"DNS";
                                            break;
                                        case 2:
                                            this.Warr[index2, 4] = (object)"WD";
                                            break;
                                        case 3:
                                            this.Warr[index2, 4] = (object)"DNF";
                                            break;
                                        case 4:
                                            this.Warr[index2, 4] = (object)"DQ";
                                            break;
                                    }
                                }
                            }
                            if (integer2 != 0)
                            {
                                this.Warr[index2, 5] = (object)this.GetTime(sec1);
                                sec1 = checked(sec1 + num4 + num3);
                                this.Warr[index2, 6] = (object)this.GetTime(sec1);
                            }
                            this.Warr[index2, 1] = (object)Module1.Vek[index3].Name.FName;
                            this.Warr[index2, 2] = (object)Module1.Vek[index3].Name.LName;
                            this.Warr[index2, 3] = (object)Module1.Vek[index3].Club;
                            checked { ++index2; }
                            checked { ++index3; }
                        }
                        num7 = index3;
                        int index4 = 1;
                        do
                        {
                            string segment4 = Module1.Segment;
                            if (Operators.CompareString(segment4, "Seg1", false) == 0)
                            {
                                if (Module1.LunchArr_Seg1[index4] > 0 & Module1.LunchArr_Seg1[index4] == checked(index3 - 1))
                                {
                                    this.Warr[index2, 1] = Module1.LunchArr_Seg1[index4] == Module1.IceArr_Seg1[index4] ? (object)"Meal break & Ice resurfacing" : (object)"Meal break";
                                    this.Warr[index2, 5] = (object)this.GetTime(sec1);
                                    checked { sec1 += num5; }
                                    this.Warr[index2, 6] = (object)this.GetTime(sec1);
                                    checked { ++index2; }
                                }
                                if (Module1.IceArr_Seg1[index4] > 0 & Module1.IceArr_Seg1[index4] == checked(index3 - 1) & Module1.LunchArr_Seg1[index4] != Module1.IceArr_Seg1[index4])
                                {
                                    this.Warr[index2, 1] = (object)"Resurfacing of the ice";
                                    this.Warr[index2, 5] = (object)this.GetTime(sec1);
                                    checked { sec1 += num6; }
                                    this.Warr[index2, 6] = (object)this.GetTime(sec1);
                                    checked { ++index2; }
                                }
                            }
                            else if (Operators.CompareString(segment4, "Seg2", false) == 0)
                            {
                                if (Module1.LunchArr_Seg2[index4] > 0 & Module1.LunchArr_Seg2[index4] == checked(index3 - 1))
                                {
                                    this.Warr[index2, 1] = Module1.LunchArr_Seg2[index4] == Module1.IceArr_Seg2[index4] ? (object)"Meal break & Ice resurfacing" : (object)"Meal break";
                                    this.Warr[index2, 5] = (object)this.GetTime(sec1);
                                    checked { sec1 += num5; }
                                    this.Warr[index2, 6] = (object)this.GetTime(sec1);
                                    checked { ++index2; }
                                }
                                if (Module1.IceArr_Seg2[index4] > 0 & Module1.IceArr_Seg2[index4] == checked(index3 - 1) & Module1.LunchArr_Seg2[index4] != Module1.IceArr_Seg2[index4])
                                {
                                    this.Warr[index2, 1] = (object)"Resurfacing of the ice";
                                    this.Warr[index2, 5] = (object)this.GetTime(sec1);
                                    checked { sec1 += num6; }
                                    this.Warr[index2, 6] = (object)this.GetTime(sec1);
                                    checked { ++index2; }
                                }
                            }
                            checked { ++index4; }
                        }
                        while (index4 <= 7);
                        checked { ++index1; }
                    }
                    lastrow = index2;
                    goto label_65;
                }
                else
                {
                    int num13 = (int)Interaction.MsgBox((object)"Start number is missing!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    goto label_65;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num14 = (int)Interaction.MsgBox((object)("CreateWarmUp - Error creating warmup groups! " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_65:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void ShowWarmUp_1(int TNoP, int norows)
        {
            this.Text = "WARMUP GROUPS: " + Strings.UCase(Module1.Category.Name) + Module1.SubCat() + ", " + Module1.GetSegTxt(Module1.Segment);
            DataGridView dataGridView1 = this.DataGridView1;
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = norows;
            dataGridView1.Visible = true;
            int num = checked(norows - 1);
            int index1 = 0;
            while (index1 <= num)
            {
                int index2 = 0;
                do
                {
                    dataGridView1.Rows[index1].Cells[index2].Value = RuntimeHelpers.GetObjectValue(this.Warr[index1, index2]);
                    checked { ++index2; }
                }
                while (index2 <= 6);
                checked { ++index1; }
            }
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.ColumnCount = 7;
            dataGridView1.Width = 920;
            this.DGW1width = dataGridView1.Width;
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 60;
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.Width = checked(this.DGW1width + Module1.WC);
            this.F7Height = checked(this.DataGridView1.Rows.Cast<DataGridViewRow>().Sum<DataGridViewRow>((Func<DataGridViewRow, int>)(r => r.Height)) + dataGridView1.Location.Y + Module1.HC);
            if (this.F7Height < checked(Screen.PrimaryScreen.WorkingArea.Height - 50))
            {
                this.Height = this.F7Height;
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
        }

        private void Form7_SizeChanged(object sender, EventArgs e)
        {
            if (!this.widthcorr)
                return;
            if (this.Height < this.F7Height)
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

        public void CalcGroup1(int NoSkater, ref int[] GR)
        {
            int num1 = 0;
            int num2 = 0;
            int MaxGr = Module1.WupG_Seg1;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 0;
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) != 0 && Operators.CompareString(segment, "Seg2", false) == 0)
                    MaxGr = Module1.WupG_Seg2;
                if (MaxGr == 0)
                    return;
                this.CalcGr1(NoSkater, MaxGr, ref GR);
                int index = 1;
                do
                {
                    if (GR[index] != 0)
                        num3 = index;
                    checked { ++index; }
                }
                while (index <= 7);
                if (num3 <= 0)
                    return;
                int num4 = 1;
                do
                {
                    if (num4 <= 7 | num4 > 10)
                    {
                        string key = num4 > 7 ? "M" + Strings.Trim(Conversions.ToString(num4)) : "Ice" + Strings.Trim(Conversions.ToString(num4));
                        if (num4 <= 7)
                        {
                            if (num4 <= num3)
                            {
                                MyProject.Forms.IceResurfacingMealBreakDialog.Controls[key].Visible = true;
                            }
                            else
                            {
                                MyProject.Forms.IceResurfacingMealBreakDialog.Controls[key].Visible = false;
                                MyProject.Forms.IceResurfacingMealBreakDialog.Controls[key].BackColor = Color.FromArgb(236, 233, 216);
                            }
                        }
                        else if (checked(num4 - 10) <= num3)
                        {
                            MyProject.Forms.IceResurfacingMealBreakDialog.Controls[key].Visible = true;
                        }
                        else
                        {
                            MyProject.Forms.IceResurfacingMealBreakDialog.Controls[key].Visible = false;
                            MyProject.Forms.IceResurfacingMealBreakDialog.Controls[key].BackColor = Color.FromArgb(236, 233, 216);
                        }
                    }
                    checked { ++num4; }
                }
                while (num4 <= 17);
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
        }

        private void CalcGr1(int NoOfSkater, int MaxGr, ref int[] gr)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (NoOfSkater > 0)
                {
                    string str;
                    switch (MaxGr)
                    {
                        case 6:
                            str = new string[43]
                            {
                "0",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "34",
                "44",
                "45",
                "55",
                "56",
                "66",
                "445",
                "455",
                "555",
                "556",
                "566",
                "666",
                "4555",
                "5555",
                "5556",
                "5566",
                "5666",
                "6666",
                "55555",
                "55556",
                "55566",
                "55666",
                "56666",
                "66666",
                "555556",
                "555566",
                "555666",
                "556666",
                "566666",
                "666666",
                "5555566",
                "5555666",
                "5556666",
                "5566666",
                "5666666",
                "6666666"
                            }[NoOfSkater];
                            break;
                        case 7:
                            str = new string[43]
                            {
                "0",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "44",
                "45",
                "55",
                "56",
                "66",
                "67",
                "77",
                "555",
                "556",
                "566",
                "666",
                "667",
                "677",
                "777",
                "5566",
                "5666",
                "6666",
                "6667",
                "6677",
                "6777",
                "7777",
                "56666",
                "66666",
                "66667",
                "66677",
                "66777",
                "67777",
                "77777",
                "666666",
                "666667",
                "666677",
                "666777",
                "667777",
                "677777",
                "777777"
                            }[NoOfSkater];
                            break;
                        case 8:
                            str = new string[49]
                            {
                "0",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "45",
                "55",
                "56",
                "66",
                "67",
                "77",
                "78",
                "88",
                "566",
                "666",
                "667",
                "677",
                "777",
                "778",
                "788",
                "888",
                "6667",
                "6677",
                "6777",
                "7777",
                "7778",
                "7788",
                "7888",
                "8888",
                "66777",
                "67777",
                "77777",
                "77778",
                "77788",
                "77888",
                "78888",
                "88888",
                "677777",
                "777777",
                "777778",
                "777788",
                "777888",
                "778888",
                "788888",
                "888888"
                            }[NoOfSkater];
                            break;
                        default:
                            int num3 = (int)Interaction.MsgBox((object)"Wrong selection of warmup group size!", MsgBoxStyle.YesNo, (object)"Susanne SW");
                            goto label_15;
                    }
                    int num4 = Strings.Len(str);
                    int Start = 1;
                    while (Start <= num4)
                    {
                        gr[Start] = Conversions.ToInteger(Strings.Mid(str, Start, 1));
                        checked { ++Start; }
                    }
                    goto label_15;
                }
                else
                    goto label_15;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("CalcGr1 - " + Information.Err().Description), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_15:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Operators.CompareString(this.txtPar.Text, "3", false) == 0)
            {
                this.Close();
            }
            else
            {
                Module1.SaveCategoryFile(Module1.CategoryFileName);
                if (Module1.IsFormOpen((Form)MyProject.Forms.IceResurfacingMealBreakDialog))
                    MyProject.Forms.IceResurfacingMealBreakDialog.Close();
                this.Close();
                if (Module1.IsFormOpen((Form)MyProject.Forms.StartListForm))
                {
                    MyProject.Forms.StartListForm.WillExitStartListForm = true;
                    MyProject.Forms.StartListForm.Close();
                }
                MyProject.Forms.StartListForm.TopMost = true;
                MyProject.Forms.StartListForm.Show();
            }
        }

        private void PrintDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                double num3 = Module1.Page_Size * 0.78 / 100.0;
                int pageLeftMargin = Module1.Page_Left_Margin;
                float pageTopMargin = (float)Module1.Page_Top_Margin;
                int index = 0;
                string str = "";
                double pageSize = Module1.Page_Size;
                int emSize = pageSize >= 85.0 ? (pageSize < 85.0 || pageSize > 92.0 ? (pageSize < 92.0 || pageSize > 99.0 ? (pageSize < 99.0 || pageSize > 110.0 ? 13 : 12) : 11) : 10) : 9;
                Font font1 = new Font("ARIAL", (float)checked(emSize + 2), FontStyle.Bold, GraphicsUnit.Pixel);
                Font font2 = new Font("ARIAL", (float)emSize, FontStyle.Bold, GraphicsUnit.Pixel);
                Font font3 = new Font("ARIAL", (float)emSize, FontStyle.Regular, GraphicsUnit.Pixel);
                Font font4 = new Font("ARIAL", 8f, FontStyle.Regular, GraphicsUnit.Pixel);
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit)
                {
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter
                };
                StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
                StringFormat format2 = new StringFormat(StringFormatFlags.NoClip);
                format1.Alignment = StringAlignment.Center;
                format2.Alignment = StringAlignment.Near;
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                    str = Module1.FormShortDate(Module1.Datum.Seg1);
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    str = Module1.FormShortDate(Module1.Datum.Seg2);
                e.Graphics.DrawString("WARMUP GROUPS", font1, Brushes.Black, (float)pageLeftMargin, pageTopMargin, new StringFormat());
                float y1 = (float)((double)pageTopMargin + (double)font1.GetHeight(e.Graphics) + 5.0);
                e.Graphics.DrawString("COMPETITION: " + Module1.Competition.Name, font1, Brushes.Black, (float)pageLeftMargin, y1, new StringFormat());
                float y2 = y1 + font1.GetHeight(e.Graphics);
                e.Graphics.DrawString("CATEGORY: " + Module1.Category.Name + Module1.SubCat() + ", " + Module1.GetSegTxt(Module1.Segment), font1, Brushes.Black, (float)pageLeftMargin, y2, new StringFormat());
                float y3 = y2 + font1.GetHeight(e.Graphics);
                e.Graphics.DrawString("DATE: " + str, font1, Brushes.Black, (float)pageLeftMargin, y3, new StringFormat());
                float y4 = (float)((double)y3 + (double)font1.GetHeight(e.Graphics) + 10.0);
                float num4 = font3.GetHeight(e.Graphics);
                while (index < this.mlastRow)
                {
                    DataGridViewRow row = dataGridView1.Rows[index];
                    float x = (float)pageLeftMargin;
                    foreach (DataGridViewCell cell in (BaseCollection)row.Cells)
                    {
                        int width = cell.ColumnIndex != 0 ? checked((int)Math.Round(unchecked((double)cell.Size.Width * num3))) : checked((int)Math.Round(unchecked((double)checked(cell.Size.Width + 6) * num3)));
                        RectangleF layoutRectangle = new RectangleF(x, y4, (float)width, num4);
                        if (index == 0)
                            e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                        object obj = index != 0 ? (object)font3 : (object)font2;
                        switch (cell.ColumnIndex)
                        {
                            case 0:
                            case 4:
                            case 5:
                            case 6:
                            case 7:
                                e.Graphics.DrawString(dataGridView1.Rows[cell.RowIndex].Cells[cell.ColumnIndex].FormattedValue.ToString(), (Font)obj, Brushes.Black, layoutRectangle, format1);
                                break;
                            default:
                                e.Graphics.DrawString(dataGridView1.Rows[cell.RowIndex].Cells[cell.ColumnIndex].FormattedValue.ToString(), (Font)obj, Brushes.Black, layoutRectangle, format2);
                                break;
                        }
                        x += layoutRectangle.Width;
                        num4 = Math.Max(num4, layoutRectangle.Height);
                    }
                    
                    y4 += num4;
                    checked { ++index; }
                    if ((double)y4 + (double)num4 > (double)e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        int num5 = checked(index - 1);
                        goto label_29;
                    }
                }
                dataGridView1?.Dispose();
                float y5 = y4 + 20f;
                e.Graphics.DrawString("Figure Skating Italia | Created: " + Module1.DateTimeToStr(DateTime.Now), font4, Brushes.Black, (float)pageLeftMargin, y5, new StringFormat());
                goto label_29;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num6 = (int)Interaction.MsgBox((object)("Form7, PrintDocument1_PrintPage_1 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_29:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void PRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (Module1.IsFormOpen((Form)MyProject.Forms.IceResurfacingMealBreakDialog))
                {
                    int num3 = (int)Interaction.MsgBox((object)"Please close the Dialog!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    goto label_24;
                }
                else
                {
                    DataGridView dataGridView1 = this.DataGridView1;
                    if (Operators.CompareString(this.txtPar.Text, "30", false) == 0)
                    {
                        this.mlastRow = checked(dataGridView1.RowCount - 1);
                        while (this.mlastRow >= 0 && Strings.Len(RuntimeHelpers.GetObjectValue(dataGridView1.Rows[this.mlastRow].Cells[1].Value)) <= 0)
                            checked { this.mlastRow += -1; }
                        checked { ++this.mlastRow; }
                        this.PrintDocument1.PrintController = (PrintController)new StandardPrintController();
                        this.PrintDocument1.Print();
                        this.txtPar.Text = "";
                        this.Close();
                        goto label_24;
                    }
                    else if (Operators.CompareString(this.txtPar.Text, "3", false) == 0)
                    {
                        this.mlastRow = checked(dataGridView1.RowCount - 1);
                        while (this.mlastRow >= 0 && Strings.Len(RuntimeHelpers.GetObjectValue(dataGridView1.Rows[this.mlastRow].Cells[1].Value)) <= 0)
                            checked { this.mlastRow += -1; }
                        checked { ++this.mlastRow; }
                        this.PrintDialog1.Document = this.PrintDocument1;
                        this.PrintDialog1.PrinterSettings = this.PrintDocument1.PrinterSettings;
                        this.PrintDialog1.AllowSomePages = true;
                        if (this.PrintDialog1.ShowDialog() == DialogResult.OK)
                        {
                            this.PrintDocument1.PrinterSettings = this.PrintDialog1.PrinterSettings;
                            this.PrintDocument1.Print();
                        }
                        this.Close();
                        goto label_24;
                    }
                    else
                    {
                        this.mlastRow = checked(dataGridView1.RowCount - 1);
                        while (this.mlastRow >= 0 && Strings.Len(RuntimeHelpers.GetObjectValue(dataGridView1.Rows[this.mlastRow].Cells[1].Value)) <= 0)
                            checked { this.mlastRow += -1; }
                        checked { ++this.mlastRow; }
                        this.PrintPreviewDialog1.TopMost = true;
                        this.PrintPreviewDialog1.Document = this.PrintDocument1;
                        int num4 = (int)this.PrintPreviewDialog1.ShowDialog();
                        goto label_24;
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
                int num5 = (int)Interaction.MsgBox((object)("Form7, PRINTToolStripMenuItem_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_24:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void CREATEPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Module1.IsFormOpen((Form)MyProject.Forms.IceResurfacingMealBreakDialog))
                return;
            int num = (int)Interaction.MsgBox((object)"Please close the Dialog!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
        }

        private void ExportDataToPDFTable1(string pathfile, int msg)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string str1 = " ";
                int num3 = 110;
                int num4 = 20;
                int num5 = 20;
                int Length = 26;
                ProjectData.ClearProjectError();
                num1 = 2;
                PdfDocument pdfDocument = new PdfDocument();
                pdfDocument.Info.Subject = Module1.Category.Name + Module1.SubCat() + ", " + Module1.GetSegTxt(Module1.Segment);
                pdfDocument.Info.Author = "ClubCompFS Single ver. 10.0.6, 2019-01-12";
                PdfPage page = pdfDocument.AddPage();
                page.Size = PageSize.A4;
                XUnit xunit = page.Width;
                int width1 = checked((int)Math.Round(unchecked(xunit.Point - (double)num4 - (double)num5)));
                xunit = page.Height;
                int num6 = checked((int)Math.Round(xunit.Point));
                XFont font1 = new XFont("ARIAL", 12.0, XFontStyle.Bold);
                XFont font2 = new XFont("ARIAL", 10.0, XFontStyle.Bold);
                XFont xfont1 = new XFont("ARIAL", 10.0, XFontStyle.Regular);
                XFont xfont2 = new XFont("ARIAL", 9.0, XFontStyle.Regular);
                XFont xfont3 = new XFont("ARIAL", 9.0, XFontStyle.Bold);
                XFont xfont4 = new XFont("ARIAL", 6.0, XFontStyle.Regular);
                XGraphics xgraphics1 = XGraphics.FromPdfPage(page);
                XImage image = XImage.FromFile("IE_Logo_HD.png");
                XImage image2 = XImage.FromFile("FSI_Logo_HD.png");
                XRect rect = new XRect(10.0, 10.0, image.PointWidth, image.PointHeight);
                XRect rect2 = new XRect(480.0, 10.0, 100, 80);
                xgraphics1.DrawImage(image, rect);
                xgraphics1.DrawImage(image2, rect2);
                float[] numArray = new float[7]
                {
          7f,
          24f,
          24f,
          23f,
          5f,
          8f,
          9f
                };
                int y1 = num3;
                int height1 = checked((int)Math.Round(font1.GetHeight()));
                xgraphics1.DrawString("WARMUP GROUPS", font1, (XBrush)XBrushes.Black, new XRect((double)num4, (double)y1, (double)width1, (double)height1), XStringFormats.TopLeft);
                int y2 = checked(y1 + height1 + 5);
                int height2 = checked((int)Math.Round(font2.GetHeight()));
                xgraphics1.DrawString("COMPETITION: " + Module1.Competition.Name, font2, (XBrush)XBrushes.Black, new XRect((double)num4, (double)y2, (double)width1, (double)height2), XStringFormats.TopLeft);
                int y3 = checked(y2 + height2);
                xgraphics1.DrawString("CATEGORY: " + Module1.Category.Name + Module1.SubCat() + ", " + Module1.GetSegTxt(Module1.Segment), font2, (XBrush)XBrushes.Black, new XRect((double)num4, (double)y3, (double)width1, (double)height2), XStringFormats.TopLeft);
                int y4 = checked(y3 + height2);
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                    str1 = "DATE: " + Module1.FormShortDate(Module1.Datum.Seg1);
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    str1 = "DATE: " + Module1.FormShortDate(Module1.Datum.Seg2);
                XGraphics xgraphics2 = xgraphics1;
                string str2 = str1;
                XFont xfont5 = font2;
                XSolidBrush black1 = XBrushes.Black;
                XRect xrect1 = new XRect((double)num4, (double)y4, (double)width1, (double)height2);
                XStringFormat topLeft1 = XStringFormats.TopLeft;
                string text1 = str2;
                XFont font3 = xfont5;
                XSolidBrush brush1 = black1;
                XRect layoutRectangle1 = xrect1;
                XStringFormat format1 = topLeft1;
                xgraphics2.DrawString(text1, font3, (XBrush)brush1, layoutRectangle1, format1);
                int num7 = checked(y4 + 2 * height2);
                int height3 = checked((int)Math.Round(xfont2.GetHeight()));
                xgraphics1.DrawLine(XPens.Gray, num4, checked(num7 - 1), checked(num4 + width1), checked(num7 - 1));
                DataGridView dataGridView1 = this.DataGridView1;
                int index = 0;
                while (index < dataGridView1.RowCount)
                {
                    XFont xfont6 = index != 0 ? xfont2 : xfont3;
                    DataGridViewRow row = dataGridView1.Rows[index];
                    int num8 = num4;
                    foreach (DataGridViewCell cell in (BaseCollection)row.Cells)
                    {
                        int width2 = checked((int)Math.Round(unchecked((double)numArray[cell.ColumnIndex] * (double)width1 / 100.0)));
                        string str3 = Strings.Left(dataGridView1.Rows[cell.RowIndex].Cells[cell.ColumnIndex].FormattedValue.ToString(), Length);
                        switch (cell.ColumnIndex)
                        {
                            case 0:
                                if (index == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(num7 - 1), num8, checked(num7 + height3 + 1));
                                XGraphics xgraphics3 = xgraphics1;
                                string str4 = str3;
                                XFont xfont7 = xfont6;
                                XSolidBrush black2 = XBrushes.Black;
                                XRect xrect2 = new XRect((double)checked(num8 + 1), (double)num7, (double)width2, (double)height3);
                                XStringFormat center1 = XStringFormats.Center;
                                string text2 = str4;
                                XFont font4 = xfont7;
                                XSolidBrush brush2 = black2;
                                XRect layoutRectangle2 = xrect2;
                                XStringFormat format2 = center1;
                                xgraphics3.DrawString(text2, font4, (XBrush)brush2, layoutRectangle2, format2);
                                break;
                            case 1:
                                if (index == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(num7 - 1), num8, checked(num7 + height3 + 1));
                                XGraphics xgraphics4 = xgraphics1;
                                string str5 = str3;
                                XFont xfont8 = xfont6;
                                XSolidBrush black3 = XBrushes.Black;
                                XRect xrect3 = new XRect((double)checked(num8 + 1), (double)num7, (double)width2, (double)height3);
                                XStringFormat topLeft2 = XStringFormats.TopLeft;
                                string text3 = str5;
                                XFont font5 = xfont8;
                                XSolidBrush brush3 = black3;
                                XRect layoutRectangle3 = xrect3;
                                XStringFormat format3 = topLeft2;
                                xgraphics4.DrawString(text3, font5, (XBrush)brush3, layoutRectangle3, format3);
                                break;
                            case 2:
                                if (index == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(num7 - 1), num8, checked(num7 + height3 + 1));
                                XGraphics xgraphics5 = xgraphics1;
                                string str6 = str3;
                                XFont xfont9 = xfont6;
                                XSolidBrush black4 = XBrushes.Black;
                                XRect xrect4 = new XRect((double)checked(num8 + 1), (double)num7, (double)width2, (double)height3);
                                XStringFormat topLeft3 = XStringFormats.TopLeft;
                                string text4 = str6;
                                XFont font6 = xfont9;
                                XSolidBrush brush4 = black4;
                                XRect layoutRectangle4 = xrect4;
                                XStringFormat format4 = topLeft3;
                                xgraphics5.DrawString(text4, font6, (XBrush)brush4, layoutRectangle4, format4);
                                break;
                            case 3:
                                if (index == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(num7 - 1), num8, checked(num7 + height3 + 1));
                                XGraphics xgraphics6 = xgraphics1;
                                string str7 = str3;
                                XFont xfont10 = xfont6;
                                XSolidBrush black5 = XBrushes.Black;
                                XRect xrect5 = new XRect((double)checked(num8 + 1), (double)num7, (double)width2, (double)height3);
                                XStringFormat topLeft4 = XStringFormats.TopLeft;
                                string text5 = str7;
                                XFont font7 = xfont10;
                                XSolidBrush brush5 = black5;
                                XRect layoutRectangle5 = xrect5;
                                XStringFormat format5 = topLeft4;
                                xgraphics6.DrawString(text5, font7, (XBrush)brush5, layoutRectangle5, format5);
                                break;
                            case 4:
                                if (index == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(num7 - 1), num8, checked(num7 + height3 + 1));
                                XGraphics xgraphics7 = xgraphics1;
                                string str8 = str3;
                                XFont xfont11 = xfont6;
                                XSolidBrush black6 = XBrushes.Black;
                                XRect xrect6 = new XRect((double)checked(num8 + 1), (double)num7, (double)width2, (double)height3);
                                XStringFormat center2 = XStringFormats.Center;
                                string text6 = str8;
                                XFont font8 = xfont11;
                                XSolidBrush brush6 = black6;
                                XRect layoutRectangle6 = xrect6;
                                XStringFormat format6 = center2;
                                xgraphics7.DrawString(text6, font8, (XBrush)brush6, layoutRectangle6, format6);
                                break;
                            case 5:
                                if (index == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(num7 - 1), num8, checked(num7 + height3 + 1));
                                XGraphics xgraphics8 = xgraphics1;
                                string str9 = str3;
                                XFont xfont12 = xfont6;
                                XSolidBrush black7 = XBrushes.Black;
                                XRect xrect7 = new XRect((double)checked(num8 + 1), (double)num7, (double)width2, (double)height3);
                                XStringFormat center3 = XStringFormats.Center;
                                string text7 = str9;
                                XFont font9 = xfont12;
                                XSolidBrush brush7 = black7;
                                XRect layoutRectangle7 = xrect7;
                                XStringFormat format7 = center3;
                                xgraphics8.DrawString(text7, font9, (XBrush)brush7, layoutRectangle7, format7);
                                break;
                            case 6:
                                if (index == 0)
                                    xgraphics1.DrawLine(XPens.Gray, num8, checked(num7 - 1), num8, checked(num7 + height3 + 1));
                                XGraphics xgraphics9 = xgraphics1;
                                string str10 = str3;
                                XFont xfont13 = xfont6;
                                XSolidBrush black8 = XBrushes.Black;
                                XRect xrect8 = new XRect((double)checked(num8 + 1), (double)num7, (double)width2, (double)height3);
                                XStringFormat center4 = XStringFormats.Center;
                                string text8 = str10;
                                XFont font10 = xfont13;
                                XSolidBrush brush8 = black8;
                                XRect layoutRectangle8 = xrect8;
                                XStringFormat format8 = center4;
                                xgraphics9.DrawString(text8, font10, (XBrush)brush8, layoutRectangle8, format8);
                                if (index == 0)
                                {
                                    xgraphics1.DrawLine(XPens.Gray, checked(num8 + width2), checked(num7 - 1), checked(num8 + width2), checked(num7 + height3 + 1));
                                    break;
                                }
                                break;
                        }
                        checked { num8 += width2; }
                    }
                    if (index == 0)
                    {
                        checked { num7 += height3 + 1; }
                        xgraphics1.DrawLine(XPens.Gray, num4, num7, checked(num4 + width1), num7);
                    }
                    else
                        checked { num7 += height3; }
                    checked { ++index; }
                }
                int y5 = checked(num7 + height3);
                XGraphics xgraphics10 = xgraphics1;
                string str11 = "Figure Skating Italia | Created: " + Module1.DateTimeToStr(DateTime.Now);
                XFont xfont14 = xfont4;
                XSolidBrush black9 = XBrushes.Black;
                XRect xrect9 = new XRect((double)num4, (double)y5, (double)width1, (double)height3);
                XStringFormat topLeft5 = XStringFormats.TopLeft;
                string text9 = str11;
                XFont font11 = xfont14;
                XSolidBrush brush9 = black9;
                XRect layoutRectangle9 = xrect9;
                XStringFormat format9 = topLeft5;
                xgraphics10.DrawString(text9, font11, (XBrush)brush9, layoutRectangle9, format9);
                pdfDocument.Save(pathfile);
                pdfDocument.Close();
                if (msg > 0)
                {
                    int num9 = (int)Interaction.MsgBox((object)("The file has been saved as:\r\n" + pathfile), MsgBoxStyle.Information, (object)"Susanne SW");
                    goto label_48;
                }
                else
                    goto label_48;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num10 = (int)Interaction.MsgBox((object)("Form7, ExportDataToPDFTable1 - \r\n" + Information.Err().Description), MsgBoxStyle.Critical, (object)"Susanne SW");
            }
            label_48:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void WarmupGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                string Path = "";
                if (Module1.IsFormOpen((Form)MyProject.Forms.IceResurfacingMealBreakDialog))
                {
                    int num3 = (int)Interaction.MsgBox((object)"Please close the Dialog!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    goto label_13;
                }
                else
                {
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        if (!Conversions.ToBoolean(Module1.CreatePath("Segment_1", ref Path)))
                            goto label_13;
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        if (!Conversions.ToBoolean(Module1.CreatePath("Segment_2", ref Path)))
                            goto label_13;
                    }
                    this.ExportDataToPDFTable1(Path + "_Warmup.pdf", 1);
                    goto label_13;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("Form7, WarmupGroupsToolStripMenuItem_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_13:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void WarmupGrouppsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                if (Operators.CompareString(this.txtPar.Text, "30", false) == 0)
                {
                    this.mlastRow = checked(dataGridView1.RowCount - 1);
                    while (this.mlastRow >= 0 && Strings.Len(RuntimeHelpers.GetObjectValue(dataGridView1.Rows[this.mlastRow].Cells[1].Value)) <= 0)
                        checked { this.mlastRow += -1; }
                    checked { ++this.mlastRow; }
                    this.PrintDocument1.PrintController = (PrintController)new StandardPrintController();
                    this.PrintDocument1.Print();
                    this.txtPar.Text = "";
                    this.Close();
                    goto label_22;
                }
                else if (Operators.CompareString(this.txtPar.Text, "3", false) == 0)
                {
                    this.mlastRow = checked(dataGridView1.RowCount - 1);
                    while (this.mlastRow >= 0 && Strings.Len(RuntimeHelpers.GetObjectValue(dataGridView1.Rows[this.mlastRow].Cells[1].Value)) <= 0)
                        checked { this.mlastRow += -1; }
                    checked { ++this.mlastRow; }
                    this.PrintDialog1.Document = this.PrintDocument1;
                    this.PrintDialog1.PrinterSettings = this.PrintDocument1.PrinterSettings;
                    this.PrintDialog1.AllowSomePages = true;
                    if (this.PrintDialog1.ShowDialog() == DialogResult.OK)
                    {
                        this.PrintDocument1.PrinterSettings = this.PrintDialog1.PrinterSettings;
                        this.PrintDocument1.Print();
                    }
                    this.Close();
                    goto label_22;
                }
                else
                {
                    this.mlastRow = checked(dataGridView1.RowCount - 1);
                    while (this.mlastRow >= 0 && Strings.Len(RuntimeHelpers.GetObjectValue(dataGridView1.Rows[this.mlastRow].Cells[1].Value)) <= 0)
                        checked { this.mlastRow += -1; }
                    checked { ++this.mlastRow; }
                    this.PrintPreviewDialog1.TopMost = true;
                    this.PrintPreviewDialog1.Document = this.PrintDocument1;
                    int num3 = (int)this.PrintPreviewDialog1.ShowDialog();
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
                int num4 = (int)Interaction.MsgBox((object)("Form7, PRINTToolStripMenuItem_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_22:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void StartlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Module1.IsFormOpen((Form)MyProject.Forms.IceResurfacingMealBreakDialog))
            {
                int num = (int)Interaction.MsgBox((object)"Please close the Dialog!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            else
            {
                if (!Module1.TestStart())
                    return;
                MyProject.Forms.StartListForm.CreateStartListPDF(1);
            }
        }

        private void CREATETWOPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                string Path = "";
                if (Module1.IsFormOpen((Form)MyProject.Forms.IceResurfacingMealBreakDialog))
                {
                    int num3 = (int)Interaction.MsgBox((object)"Please close the Dialog!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    goto label_14;
                }
                else
                {
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        if (!Conversions.ToBoolean(Module1.CreatePath("Segment_1", ref Path)))
                            goto label_14;
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        if (!Conversions.ToBoolean(Module1.CreatePath("Segment_2", ref Path)))
                            goto label_14;
                    }
                    this.ExportDataToPDFTable1(Path + "_Warmup.pdf", 0);
                    if (Module1.TestStart())
                    {
                        MyProject.Forms.StartListForm.CreateStartListPDF(2);
                        goto label_14;
                    }
                    else
                        goto label_14;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("Form7, CREATETWOPDFToolStripMenuItem_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_14:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }
    }
}

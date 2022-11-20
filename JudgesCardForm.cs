// Decompiled with JetBrains decompiler
// Type: ClubCompFS.JudgesCardForm
// Assembly: ClubCompFS_10p0p6, Version=1.0.0.6, Culture=neutral, PublicKeyToken=null
// MVID: 18AFA868-014F-449A-91A2-9536DA06DEFC
// Assembly location: E:\zz Personal_Doc\Personal\Cinzia\ClubCompFS_Version2_Oct2020_NEW3\ClubCompFS_NEW2.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
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
    public class JudgesCardForm : Form
    {
        private IContainer components;
        [AccessedThroughProperty("PrintPreviewDialog1")]
        private PrintPreviewDialog _PrintPreviewDialog1;
        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;
        [AccessedThroughProperty("PRINTToolStripMenuItem")]
        private ToolStripMenuItem _PRINTToolStripMenuItem;
        [AccessedThroughProperty("JudgePaperToolStripMenuItem")]
        private ToolStripMenuItem _JudgePaperToolStripMenuItem;
        [AccessedThroughProperty("TCTSPaperToolStripMenuItem")]
        private ToolStripMenuItem _TCTSPaperToolStripMenuItem;
        [AccessedThroughProperty("PrintDocument2")]
        private PrintDocument _PrintDocument2;
        [AccessedThroughProperty("PrintPreviewDialog2")]
        private PrintPreviewDialog _PrintPreviewDialog2;
        [AccessedThroughProperty("txtPno")]
        private TextBox _txtPno;
        [AccessedThroughProperty("txtJno")]
        private TextBox _txtJno;
        [AccessedThroughProperty("txtTCTSName")]
        private TextBox _txtTCTSName;
        [AccessedThroughProperty("PrintDocument1")]
        private PrintDocument _PrintDocument1;
        private int mRow;
        private bool newpage;
        public int JudgeNo;

        public JudgesCardForm()
        {
            this.mRow = 1;
            this.newpage = true;
            this.JudgeNo = 1;
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(JudgesCardForm));
            this.PrintDocument1 = new PrintDocument();
            this.PrintPreviewDialog1 = new PrintPreviewDialog();
            this.MenuStrip1 = new MenuStrip();
            this.PRINTToolStripMenuItem = new ToolStripMenuItem();
            this.JudgePaperToolStripMenuItem = new ToolStripMenuItem();
            this.TCTSPaperToolStripMenuItem = new ToolStripMenuItem();
            this.PrintDocument2 = new PrintDocument();
            this.PrintPreviewDialog2 = new PrintPreviewDialog();
            this.txtPno = new TextBox();
            this.txtJno = new TextBox();
            this.txtTCTSName = new TextBox();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            PrintPreviewDialog printPreviewDialog1_1 = this.PrintPreviewDialog1;
            Size size1 = new Size(0, 0);
            Size size2 = size1;
            printPreviewDialog1_1.AutoScrollMargin = size2;
            PrintPreviewDialog printPreviewDialog1_2 = this.PrintPreviewDialog1;
            size1 = new Size(0, 0);
            Size size3 = size1;
            printPreviewDialog1_2.AutoScrollMinSize = size3;
            PrintPreviewDialog printPreviewDialog1_3 = this.PrintPreviewDialog1;
            size1 = new Size(400, 300);
            Size size4 = size1;
            printPreviewDialog1_3.ClientSize = size4;
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = (Icon)componentResourceManager.GetObject("PrintPreviewDialog1.Icon");
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            this.MenuStrip1.Items.AddRange(new ToolStripItem[1]
            {
        (ToolStripItem) this.PRINTToolStripMenuItem
            });
            this.MenuStrip1.Location = new Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            MenuStrip menuStrip1 = this.MenuStrip1;
            size1 = new Size(364, 24);
            Size size5 = size1;
            menuStrip1.Size = size5;
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            this.PRINTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
            {
        (ToolStripItem) this.JudgePaperToolStripMenuItem,
        (ToolStripItem) this.TCTSPaperToolStripMenuItem
            });
            this.PRINTToolStripMenuItem.Name = "PRINTToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem1 = this.PRINTToolStripMenuItem;
            size1 = new Size(52, 20);
            Size size6 = size1;
            toolStripMenuItem1.Size = size6;
            this.PRINTToolStripMenuItem.Text = "PRINT";
            this.JudgePaperToolStripMenuItem.Name = "JudgePaperToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem2 = this.JudgePaperToolStripMenuItem;
            size1 = new Size(140, 22);
            Size size7 = size1;
            toolStripMenuItem2.Size = size7;
            this.JudgePaperToolStripMenuItem.Text = "Judge paper";
            this.TCTSPaperToolStripMenuItem.Name = "TCTSPaperToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem3 = this.TCTSPaperToolStripMenuItem;
            size1 = new Size(140, 22);
            Size size8 = size1;
            toolStripMenuItem3.Size = size8;
            this.TCTSPaperToolStripMenuItem.Text = "TC/TS paper";
            PrintPreviewDialog printPreviewDialog2_1 = this.PrintPreviewDialog2;
            size1 = new Size(0, 0);
            Size size9 = size1;
            printPreviewDialog2_1.AutoScrollMargin = size9;
            PrintPreviewDialog printPreviewDialog2_2 = this.PrintPreviewDialog2;
            size1 = new Size(0, 0);
            Size size10 = size1;
            printPreviewDialog2_2.AutoScrollMinSize = size10;
            PrintPreviewDialog printPreviewDialog2_3 = this.PrintPreviewDialog2;
            size1 = new Size(400, 300);
            Size size11 = size1;
            printPreviewDialog2_3.ClientSize = size11;
            this.PrintPreviewDialog2.Enabled = true;
            this.PrintPreviewDialog2.Icon = (Icon)componentResourceManager.GetObject("PrintPreviewDialog2.Icon");
            this.PrintPreviewDialog2.Name = "PrintPreviewDialog2";
            this.PrintPreviewDialog2.Visible = false;
            this.txtPno.Location = new Point(27, 49);
            this.txtPno.Name = "txtPno";
            TextBox txtPno = this.txtPno;
            size1 = new Size(77, 20);
            Size size12 = size1;
            txtPno.Size = size12;
            this.txtPno.TabIndex = 1;
            this.txtPno.Text = "Pno";
            this.txtJno.Location = new Point(150, 49);
            this.txtJno.Name = "txtJno";
            TextBox txtJno = this.txtJno;
            size1 = new Size(77, 20);
            Size size13 = size1;
            txtJno.Size = size13;
            this.txtJno.TabIndex = 2;
            this.txtJno.Text = "Jno";
            this.txtTCTSName.Location = new Point(267, 49);
            this.txtTCTSName.Name = "txtTCTSName";
            TextBox txtTctsName = this.txtTCTSName;
            size1 = new Size(77, 20);
            Size size14 = size1;
            txtTctsName.Size = size14;
            this.txtTCTSName.TabIndex = 3;
            this.txtTCTSName.Text = "TCTSName";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(364, 91);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.txtTCTSName);
            this.Controls.Add((Control)this.txtJno);
            this.Controls.Add((Control)this.txtPno);
            this.Controls.Add((Control)this.MenuStrip1);
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(JudgesCardForm);
            this.Text = "JUDGES CARD";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual PrintPreviewDialog PrintPreviewDialog1
        {
            get => this._PrintPreviewDialog1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PrintPreviewDialog1 = value;
        }

        internal virtual MenuStrip MenuStrip1
        {
            get => this._MenuStrip1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._MenuStrip1 = value;
        }

        internal virtual ToolStripMenuItem PRINTToolStripMenuItem
        {
            get => this._PRINTToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PRINTToolStripMenuItem = value;
        }

        internal virtual ToolStripMenuItem JudgePaperToolStripMenuItem
        {
            get => this._JudgePaperToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.JudgePaperToolStripMenuItem_Click);
                if (this._JudgePaperToolStripMenuItem != null)
                    this._JudgePaperToolStripMenuItem.Click -= eventHandler;
                this._JudgePaperToolStripMenuItem = value;
                if (this._JudgePaperToolStripMenuItem == null)
                    return;
                this._JudgePaperToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem TCTSPaperToolStripMenuItem
        {
            get => this._TCTSPaperToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.TCTSPaperToolStripMenuItem_Click);
                if (this._TCTSPaperToolStripMenuItem != null)
                    this._TCTSPaperToolStripMenuItem.Click -= eventHandler;
                this._TCTSPaperToolStripMenuItem = value;
                if (this._TCTSPaperToolStripMenuItem == null)
                    return;
                this._TCTSPaperToolStripMenuItem.Click += eventHandler;
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

        internal virtual PrintPreviewDialog PrintPreviewDialog2
        {
            get => this._PrintPreviewDialog2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PrintPreviewDialog2 = value;
        }

        internal virtual TextBox txtPno
        {
            get => this._txtPno;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtPno = value;
        }

        internal virtual TextBox txtJno
        {
            get => this._txtJno;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtJno = value;
        }

        internal virtual TextBox txtTCTSName
        {
            get => this._txtTCTSName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtTCTSName = value;
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

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                double num3 = Program.Page_Size * 1.0 / 100.0;
                int pageLeftMargin = Program.Page_Left_Margin;
                float pageTopMargin = (float)Program.Page_Top_Margin;
                ProjectData.ClearProjectError();
                num1 = 2;
                this.newpage = true;
                StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit)
                {
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter
                };
                StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
                StringFormat format2 = new StringFormat(StringFormatFlags.NoClip);
                format1.Alignment = StringAlignment.Center;
                format2.Alignment = StringAlignment.Near;
                int integer = Conversions.ToInteger(this.txtPno.Text);
                string segTxt = Program.GetSegTxt(Program.Segment);
                string segment1 = Program.Segment;
                int num4 = 0;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                    num4 = Program.Vek[integer].Startno_Seg1;
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                    num4 = Program.Vek[integer].Startno_Seg2;
                int emSize = checked((int)Math.Round(Conversion.Int(unchecked(num3 * 10.0 + 2.25))));
                Font font1 = new Font("ARIAL", (float)checked(emSize + 2), FontStyle.Bold, GraphicsUnit.Pixel);
                Font font2 = new Font("ARIAL", (float)emSize, FontStyle.Bold, GraphicsUnit.Pixel);
                Font font3 = new Font("ARIAL", (float)emSize, FontStyle.Regular, GraphicsUnit.Pixel);
                Font font4 = new Font("ARIAL", 8f, FontStyle.Regular, GraphicsUnit.Pixel);
                float height1 = font1.GetHeight(e.Graphics);
                int num5 = 0;
                RectangleF layoutRectangle = new RectangleF((float)checked(pageLeftMargin + 20 + 420 + 40 + 5 + 140) * (float)num3, pageTopMargin, (float)num5 * (float)num3, height1);
                e.Graphics.DrawString("J" + this.txtJno.Text, font1, Brushes.Black, layoutRectangle, format2);
                e.Graphics.DrawString("COMPETITION: " + Program.Competition.Name, font1, Brushes.Black, (float)pageLeftMargin, pageTopMargin, new StringFormat());
                float y1 = pageTopMargin + font1.GetHeight(e.Graphics);
                e.Graphics.DrawString("CATEGORY: " + Program.Category.Name + Program.SubCat() + ", " + segTxt, font1, Brushes.Black, (float)pageLeftMargin, y1, new StringFormat());
                float y2 = y1 + font1.GetHeight(e.Graphics);
                string segment2 = Program.Segment;
                if (Operators.CompareString(segment2, "Seg1", false) == 0)
                    e.Graphics.DrawString("Judge Card: J" + this.txtJno.Text + " - " + Program.Judge[Conversions.ToInteger(this.txtJno.Text)].Seg1.Name, font1, Brushes.Black, (float)pageLeftMargin, y2, new StringFormat());
                else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                    e.Graphics.DrawString("Judge Card: J" + this.txtJno.Text + " - " + Program.Judge[Conversions.ToInteger(this.txtJno.Text)].Seg2.Name, font1, Brushes.Black, (float)pageLeftMargin, y2, new StringFormat());
                float y3 = (float)((double)y2 + (double)font1.GetHeight(e.Graphics) + 10.0);
                float x1 = (float)pageLeftMargin;
                float height2 = font3.GetHeight(e.Graphics);
                int num6 = 160;
                layoutRectangle = new RectangleF(x1, y3, (float)num6 * (float)num3, height2);
                e.Graphics.DrawString("Start no.: " + Conversions.ToString(num4), font3, Brushes.Black, layoutRectangle, format2);
                float x2 = x1 + layoutRectangle.Width;
                int num7 = 325;
                layoutRectangle = new RectangleF(x2, y3, (float)num7 * (float)num3, height2);
                e.Graphics.DrawString("Name: " + Program.Vek[integer].Name.FName + " " + Program.Vek[integer].Name.LName, font3, Brushes.Black, layoutRectangle, format2);
                float x3 = x2 + layoutRectangle.Width;
                int num8 = 180;
                layoutRectangle = new RectangleF(x3, y3, (float)num8 * (float)num3, height2);
                e.Graphics.DrawString("Club: " + Program.Vek[integer].Club, font3, Brushes.Black, layoutRectangle, format2);
                float y4 = (float)((double)y3 + (double)height2 + 5.0);
                float height3 = font2.GetHeight(e.Graphics);
                float x4 = (float)pageLeftMargin;
                int num9 = 20;
                layoutRectangle = new RectangleF(x4, y4, (float)num9 * (float)num3, height3 * 4f);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                float x5 = x4 + layoutRectangle.Width;
                int num10 = 140;
                layoutRectangle = new RectangleF(x5, y4, (float)num10 * (float)num3, height3 * 4f);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                e.Graphics.DrawString("\r\nPlanned Elements", font2, Brushes.Black, layoutRectangle, format2);
                float x6 = x5 + layoutRectangle.Width;
                int num11 = 140;
                layoutRectangle = new RectangleF(x6, y4, (float)num11 * (float)num3, height3 * 4f);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                e.Graphics.DrawString("\r\nExecuted Elements", font2, Brushes.Black, layoutRectangle, format2);
                float x7 = x6 + layoutRectangle.Width;
                int num12 = 140;
                layoutRectangle = new RectangleF(x7, y4, (float)num12 * (float)num3, height3 * 4f);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                e.Graphics.DrawString("\r\nComments", font2, Brushes.Black, layoutRectangle, format2);
                float x8 = x7 + layoutRectangle.Width;
                int num13 = 40;
                layoutRectangle = new RectangleF(x8, y4, (float)num13 * (float)num3, height3 * 4f);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                e.Graphics.DrawString("\r\nGOE", font2, Brushes.Black, layoutRectangle, format1);
                float x9 = (float)((double)x8 + (double)layoutRectangle.Width + 5.0);
                int num14 = 180;
                layoutRectangle = new RectangleF(x9, y4, (float)num14 * (float)num3, height3 * 4f);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                e.Graphics.DrawString("Music", font2, Brushes.Black, layoutRectangle, format2);
                float height4 = font3.GetHeight(e.Graphics);
                float y5 = y4 + height4 * 4f;
                float height5 = 3f * height4;
                int index = 1;
                while (index <= 16)
                {
                    float x10 = (float)pageLeftMargin;
                    int num15 = 1;
                    do
                    {
                        switch (num15)
                        {
                            case 1:
                                int num16 = 20;
                                layoutRectangle = new RectangleF(x10, y5, (float)num16 * (float)num3, height5);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                e.Graphics.DrawString("\r\n" + Conversions.ToString(index), font3, Brushes.Black, layoutRectangle, format1);
                                break;
                            case 2:
                                int num17 = 140;
                                layoutRectangle = new RectangleF(x10, y5, (float)num17 * (float)num3, height5);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                string segment3 = Program.Segment;
                                if (Operators.CompareString(segment3, "Seg1", false) == 0)
                                {
                                    if (index <= 15)
                                    {
                                        e.Graphics.DrawString("\r\n" + Program.Vek[integer].SSS_Seg1[index], font3, Brushes.Black, layoutRectangle, format2);
                                        break;
                                    }
                                    break;
                                }
                                if (Operators.CompareString(segment3, "Seg2", false) == 0 && index <= 15)
                                {
                                    e.Graphics.DrawString("\r\n" + Program.Vek[integer].SSS_Seg2[index], font3, Brushes.Black, layoutRectangle, format2);
                                    break;
                                }
                                break;
                            case 3:
                                int num18 = 140;
                                layoutRectangle = new RectangleF(x10, y5, (float)num18 * (float)num3, height5);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                break;
                            case 4:
                                int num19 = 140;
                                layoutRectangle = new RectangleF(x10, y5, (float)num19 * (float)num3, height5);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                break;
                            case 5:
                                int num20 = 40;
                                layoutRectangle = new RectangleF(x10, y5, (float)num20 * (float)num3, height5);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                break;
                            case 6:
                                int num21 = 5;
                                layoutRectangle = new RectangleF(x10, y5, (float)num21 * (float)num3, height5);
                                break;
                            case 7:
                                switch (index)
                                {
                                    case 1:
                                        int num22 = 180;
                                        layoutRectangle = new RectangleF(x10, y5, (float)num22 * (float)num3, height5);
                                        e.Graphics.DrawString("\r\nPROGRAM COMPONENTS", font2, Brushes.Black, layoutRectangle, format2);
                                        break;
                                    case 2:
                                        int num23 = 150;
                                        layoutRectangle = new RectangleF(x10, y5, (float)num23 * (float)num3, height5);
                                        e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                        e.Graphics.DrawString("\r\nSkating Skills", font2, Brushes.Black, layoutRectangle, format2);
                                        break;
                                    case 3:
                                        int num24 = 180;
                                        layoutRectangle = new RectangleF(x10, y5, (float)num24 * (float)num3, height5 * 2f);
                                        e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                        e.Graphics.DrawString("Balance, Skating movements, Power", font4, Brushes.Black, layoutRectangle, format2);
                                        break;
                                    case 4:
                                    case 7:
                                    case 10:
                                    case 13:
                                    case 16:
                                        break;
                                    case 5:
                                        int num27 = 150;
                                        layoutRectangle = new RectangleF(x10, y5, (float)num27 * (float)num3, height5);
                                        e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                        e.Graphics.DrawString("\r\nPresentation", font2, Brushes.Black, layoutRectangle, format2);
                                        
                                        //int num25 = 140;
                                        //layoutRectangle = new RectangleF(x10, y5, (float)num25 * (float)num3, height5);
                                        //e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                        //e.Graphics.DrawString("\r\nScorrevolezza", font2, Brushes.Black, layoutRectangle, format2);
                                        break;
                                    case 6:
                                        int num28 = 180;
                                        layoutRectangle = new RectangleF(x10, y5, (float)num28 * (float)num3, height5 * 2f);
                                        e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                        e.Graphics.DrawString("Delivery, Projection, Personality/Style", font4, Brushes.Black, layoutRectangle, format2);
                                        
                                        //int num26 = 180;
                                        //layoutRectangle = new RectangleF(x10, y5, (float)num26 * (float)num3, height5 * 2f);
                                        //e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                        //e.Graphics.DrawString("Connection, Skating movements, Linking of elements", font4, Brushes.Black, layoutRectangle, format2);
                                        break;
                                    case 8:
                                        //int num27 = 140;
                                        //layoutRectangle = new RectangleF(x10, y5, (float)num27 * (float)num3, height5);
                                        //e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                        //e.Graphics.DrawString("\r\nPerformance/Execution", font2, Brushes.Black, layoutRectangle, format2);
                                        break;
                                    case 9:
                                        //int num28 = 180;
                                        //layoutRectangle = new RectangleF(x10, y5, (float)num28 * (float)num3, height5 * 2f);
                                        //e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                        //e.Graphics.DrawString("Delivery, Projection, Personality/Style", font4, Brushes.Black, layoutRectangle, format2);
                                        break;
                                    case 11:
                                        //int num29 = 140;
                                        //layoutRectangle = new RectangleF(x10, y5, (float)num29 * (float)num3, height5);
                                        //e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                        //e.Graphics.DrawString("\r\nCoreografia", font2, Brushes.Black, layoutRectangle, format2);
                                        break;
                                    case 12:
                                        //int num30 = 180;
                                        //layoutRectangle = new RectangleF(x10, y5, (float)num30 * (float)num3, height5 * 2f);
                                        //e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                        //e.Graphics.DrawString("Design, Pattern and Structure, Ice coverage", font4, Brushes.Black, layoutRectangle, format2);
                                        break;
                                    case 14:
                                        //int num31 = 140;
                                        //layoutRectangle = new RectangleF(x10, y5, (float)num31 * (float)num3, height5);
                                        //e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                        //e.Graphics.DrawString("\r\nInterpretation", font2, Brushes.Black, layoutRectangle, format2);
                                        break;
                                    case 15:
                                        //int num32 = 180;
                                        //layoutRectangle = new RectangleF(x10, y5, (float)num32 * (float)num3, height5 * 2f);
                                        //e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                        //e.Graphics.DrawString("Feeling, Delivery, Translation of music details", font4, Brushes.Black, layoutRectangle, format2);
                                        break;
                                    default:
                                        int num33 = 180;
                                        layoutRectangle = new RectangleF(x10, y5, (float)num33 * (float)num3, height5);
                                        e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                        break;
                                }
                                break;
                            case 8:
                                //if (index <= 5)
                                //{
                                    if (index != 2 && index != 5)
                                        break;
                                //}
                                //else if (index != 8 && index != 11 && index != 14)
                                //    break;
                                int num34 = 30;
                                layoutRectangle = new RectangleF(x10, y5, (float)num34 * (float)num3, height5);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                break;
                        }
                        x10 += layoutRectangle.Width;
                        checked { ++num15; }
                    }
                    while (num15 <= 8);
                    this.newpage = false;
                    y5 += height5;
                    checked { ++index; }
                }
                float x11 = (float)pageLeftMargin;
                float height6 = font3.GetHeight(e.Graphics);
                float y6 = y5 + height6;
                int num35 = 160;
                layoutRectangle = new RectangleF(x11, y6, (float)num35 * (float)num3, height6);
                e.Graphics.DrawString("Deductions:", font2, Brushes.Black, layoutRectangle, format2);
                float y7 = y6 + height6;
                int num36 = 160;
                layoutRectangle = new RectangleF(x11, y7, (float)num36 * (float)num3, height6);
                e.Graphics.DrawString("Costume violation:", font3, Brushes.Black, layoutRectangle, format2);
                float x12 = x11 + layoutRectangle.Width;
                int num37 = checked((int)Math.Round((double)height6));
                layoutRectangle = new RectangleF(x12, y7, (float)num37 * (float)num3, height6);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                float x13 = (float)pageLeftMargin;
                float y8 = y7 + height6;
                int num38 = 160;
                layoutRectangle = new RectangleF(x13, y8, (float)num38 * (float)num3, height6);
                e.Graphics.DrawString("Props violation:", font3, Brushes.Black, layoutRectangle, format2);
                float x14 = x13 + layoutRectangle.Width;
                int num39 = checked((int)Math.Round((double)height6));
                layoutRectangle = new RectangleF(x14, y8, (float)num39 * (float)num3, height6);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                float x15 = (float)pageLeftMargin;
                float y9 = y8 + height6;
                int num40 = 160;
                layoutRectangle = new RectangleF(x15, y9, (float)num40 * (float)num3, height6);
                e.Graphics.DrawString("Music violation:", font3, Brushes.Black, layoutRectangle, format2);
                float x16 = x15 + layoutRectangle.Width;
                int num41 = checked((int)Math.Round((double)height6));
                layoutRectangle = new RectangleF(x16, y9, (float)num41 * (float)num3, height6);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                float y10 = y9 + height6 * 2f;
                float x17 = (float)pageLeftMargin;
                int num42 = 665;
                layoutRectangle = new RectangleF(x17, y10, (float)num42 * (float)num3, height6 * 5f);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                e.Graphics.DrawString("Comments:", font2, Brushes.Black, layoutRectangle, format2);
                float y11 = y10 + height6 * 9f;
                int num43 = 440;
                layoutRectangle = new RectangleF(x17, y11, (float)num43 * (float)num3, height6);
                e.Graphics.DrawString("......................................................................", font3, Brushes.Black, layoutRectangle, format2);
                float y12 = y11 + height6;
                int num44 = 440;
                layoutRectangle = new RectangleF(x17, y12, (float)num44 * (float)num3, height6);
                e.Graphics.DrawString("Signature", font4, Brushes.Black, layoutRectangle, format2);
                goto label_48;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num45 = (int)Interaction.MsgBox((object)("JudgesCardForm, PrintDocument1_PrintPage_1 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_48:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void JudgePaperToolStripMenuItem_Click(object sender, EventArgs e)
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
                int num4 = (int)Interaction.MsgBox((object)("JudgesCardForm, PRINTToolStripMenuItem_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void TCTSPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.PrintPreviewDialog2.TopMost = true;
                this.PrintPreviewDialog2.Document = this.PrintDocument2;
                int num3 = (int)this.PrintPreviewDialog2.ShowDialog();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("JudgesCardForm, PRINTToolStripMenuItem_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
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
                double num3 = Program.Page_Size * 1.0 / 100.0;
                int pageLeftMargin = Program.Page_Left_Margin;
                float pageTopMargin = (float)Program.Page_Top_Margin;
                ProjectData.ClearProjectError();
                num1 = 2;
                this.newpage = true;
                StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit)
                {
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter
                };
                StringFormat format1 = new StringFormat(StringFormatFlags.NoClip);
                StringFormat format2 = new StringFormat(StringFormatFlags.NoClip);
                string[,] strArray = new string[3, 7]
                {
          {
            "BE",
            "CF",
            "SF",
            "US",
            "UL",
            "JS",
            "CE"
          },
          {
            "FE",
            "CS",
            "SS",
            "UF",
            "S/B",
            "CFJ",
            "8"
          },
          {
            "CD",
            "CU",
            "SB",
            "UB",
            "NBP",
            "IS",
            "3BP"
          }
                };
                format1.Alignment = StringAlignment.Center;
                format2.Alignment = StringAlignment.Near;
                int integer = Conversions.ToInteger(this.txtPno.Text);
                string segTxt = Program.GetSegTxt(Program.Segment);
                string segment1 = Program.Segment;
                int num4 = 0;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                    num4 = Program.Vek[integer].Startno_Seg1;
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                    num4 = Program.Vek[integer].Startno_Seg2;
                int emSize = checked((int)Math.Round(Conversion.Int(unchecked(num3 * 10.0 + 2.25))));
                Font font1 = new Font("ARIAL", (float)checked(emSize + 2), FontStyle.Bold, GraphicsUnit.Pixel);
                Font font2 = new Font("ARIAL", (float)emSize, FontStyle.Bold, GraphicsUnit.Pixel);
                Font font3 = new Font("ARIAL", (float)emSize, FontStyle.Regular, GraphicsUnit.Pixel);
                Font font4 = new Font("ARIAL", (float)checked(emSize - 4), FontStyle.Regular, GraphicsUnit.Pixel);
                Font font5 = new Font("ARIAL", 8f, FontStyle.Regular, GraphicsUnit.Pixel);
                float height1 = font1.GetHeight(e.Graphics);
                int num5 = 0;
                RectangleF layoutRectangle = new RectangleF((float)checked(pageLeftMargin + 20 + 560) * (float)num3, pageTopMargin, (float)num5 * (float)num3, height1);
                e.Graphics.DrawString(this.txtTCTSName.Text, font3, Brushes.Black, layoutRectangle, format2);
                e.Graphics.DrawString("COMPETITION: " + Program.Competition.Name, font1, Brushes.Black, (float)pageLeftMargin, pageTopMargin, new StringFormat());
                float y1 = pageTopMargin + font1.GetHeight(e.Graphics);
                e.Graphics.DrawString("CATEGORY: " + Program.Category.Name + Program.SubCat() + ", " + segTxt, font1, Brushes.Black, (float)pageLeftMargin, y1, new StringFormat());
                float y2 = y1 + font1.GetHeight(e.Graphics);
                e.Graphics.DrawString("TC TS Card: " + this.txtTCTSName.Text, font1, Brushes.Black, (float)pageLeftMargin, y2, new StringFormat());
                float x1 = (float)pageLeftMargin;
                float height2 = font3.GetHeight(e.Graphics);
                float y3 = (float)((double)y2 + (double)height2 + 10.0);
                int num6 = 160;
                layoutRectangle = new RectangleF(x1, y3, (float)num6 * (float)num3, height2);
                e.Graphics.DrawString("Start no.: " + Conversions.ToString(num4), font3, Brushes.Black, layoutRectangle, format2);
                float x2 = x1 + layoutRectangle.Width;
                int num7 = 280;
                layoutRectangle = new RectangleF(x2, y3, (float)num7 * (float)num3, height2);
                e.Graphics.DrawString("Name: " + Program.Vek[integer].Name.FName + " " + Program.Vek[integer].Name.LName, font3, Brushes.Black, layoutRectangle, format2);
                float x3 = x2 + layoutRectangle.Width;
                int num8 = 280;
                layoutRectangle = new RectangleF(x3, y3, (float)num8 * (float)num3, height2);
                e.Graphics.DrawString("Club: " + Program.Vek[integer].Club, font3, Brushes.Black, layoutRectangle, format2);
                float y4 = (float)((double)y3 + (double)height2 + 5.0);
                int num9 = 70;
                int index1 = 0;
                do
                {
                    float x4 = (float)pageLeftMargin;
                    int index2 = 0;
                    do
                    {
                        layoutRectangle = new RectangleF(x4, y4, (float)num9 * (float)num3, height2);
                        e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                        e.Graphics.DrawString(strArray[index1, index2], font3, Brushes.Black, layoutRectangle, format1);
                        x4 += layoutRectangle.Width;
                        checked { ++index2; }
                    }
                    while (index2 <= 6);
                    y4 += layoutRectangle.Height;
                    checked { ++index1; }
                }
                while (index1 <= 2);
                float y5 = y4 + 5f;
                float height3 = font2.GetHeight(e.Graphics);
                float x5 = (float)pageLeftMargin;
                int num10 = 20;
                layoutRectangle = new RectangleF(x5, y5, (float)num10 * (float)num3, height3 * 4f);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                float x6 = x5 + layoutRectangle.Width;
                int num11 = 140;
                layoutRectangle = new RectangleF(x6, y5, (float)num11 * (float)num3, height3 * 4f);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                e.Graphics.DrawString("\r\nPlanned Elements", font2, Brushes.Black, layoutRectangle, format2);
                float x7 = x6 + layoutRectangle.Width;
                int num12 = 140;
                layoutRectangle = new RectangleF(x7, y5, (float)num12 * (float)num3, height3 * 4f);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                e.Graphics.DrawString("\r\nExecuted Elements", font2, Brushes.Black, layoutRectangle, format2);
                float x8 = x7 + layoutRectangle.Width;
                int num13 = 140;
                layoutRectangle = new RectangleF(x8, y5, (float)num13 * (float)num3, height3 * 4f);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                e.Graphics.DrawString("\r\nComments/Falls", font2, Brushes.Black, layoutRectangle, format2);
                float x9 = x8 + layoutRectangle.Width;
                int num14 = 140;
                layoutRectangle = new RectangleF(x9, y5, (float)num14 * (float)num3, height3 * 4f);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                e.Graphics.DrawString("\r\nIllegeal Element", font2, Brushes.Black, layoutRectangle, format2);
                float x10 = x9 + layoutRectangle.Width;
                int num15 = 140;
                layoutRectangle = new RectangleF(x10, y5, (float)num15 * (float)num3, height3 * 4f);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                e.Graphics.DrawString("Deleted Element", font2, Brushes.Black, layoutRectangle, format2);
                layoutRectangle = new RectangleF(x10, y5 + height3, (float)num15 * (float)num3, height3 * 4f);
                e.Graphics.DrawString("Additional elements, element not according to the rules (i.e. for SP or well balanced program)", font4, Brushes.Black, layoutRectangle, format2);
                float height4 = font3.GetHeight(e.Graphics);
                float y6 = y5 + height4 * 4f;
                float height5 = 3f * height4;
                int index3 = 1;
                while (index3 <= 16)
                {
                    float x11 = (float)pageLeftMargin;
                    int num16 = 1;
                    do
                    {
                        switch (num16)
                        {
                            case 1:
                                int num17 = 20;
                                layoutRectangle = new RectangleF(x11, y6, (float)num17 * (float)num3, height5);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                e.Graphics.DrawString("\r\n" + Conversions.ToString(index3), font3, Brushes.Black, layoutRectangle, format1);
                                break;
                            case 2:
                                int num18 = 140;
                                layoutRectangle = new RectangleF(x11, y6, (float)num18 * (float)num3, height5);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                string segment2 = Program.Segment;
                                if (Operators.CompareString(segment2, "Seg1", false) == 0)
                                {
                                    if (index3 <= 15)
                                        e.Graphics.DrawString("\r\n" + Program.Vek[integer].SSS_Seg1[index3], font3, Brushes.Black, layoutRectangle, format2);
                                }
                                else if (Operators.CompareString(segment2, "Seg2", false) == 0 && index3 <= 15)
                                    e.Graphics.DrawString("\r\n" + Program.Vek[integer].SSS_Seg2[index3], font3, Brushes.Black, layoutRectangle, format2);
                                int num19 = 140;
                                layoutRectangle = new RectangleF(x11, y6, (float)num19 * (float)num3, height5);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                break;
                            case 3:
                                int num20 = 140;
                                layoutRectangle = new RectangleF(x11, y6, (float)num20 * (float)num3, height5);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                break;
                            case 4:
                                int num21 = 140;
                                layoutRectangle = new RectangleF(x11, y6, (float)num21 * (float)num3, height5);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                break;
                            case 5:
                                int num22 = 140;
                                layoutRectangle = new RectangleF(x11, y6, (float)num22 * (float)num3, height5);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                break;
                            case 6:
                                int num23 = 140;
                                layoutRectangle = new RectangleF(x11, y6, (float)num23 * (float)num3, height5);
                                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                                break;
                        }
                        x11 += layoutRectangle.Width;
                        checked { ++num16; }
                    }
                    while (num16 <= 8);
                    y6 += height5;
                    checked { ++index3; }
                }
                float x12 = (float)pageLeftMargin;
                float height6 = font3.GetHeight(e.Graphics);
                float y7 = y6 + height6;
                int num24 = 160;
                layoutRectangle = new RectangleF(x12, y7, (float)num24 * (float)num3, height6 * 2f);
                e.Graphics.DrawString("Time violation:", font3, Brushes.Black, layoutRectangle, format2);
                float x13 = x12 + layoutRectangle.Width;
                int num25 = 140;
                layoutRectangle = new RectangleF(x13, y7, (float)num25 * (float)num3, height6 * 2f);
                e.Graphics.DrawString("__________", font3, Brushes.Black, layoutRectangle, format2);
                float x14 = x13 + layoutRectangle.Width;
                int num26 = 420;
                layoutRectangle = new RectangleF(x14, y7, (float)num26 * (float)num3, height6 * 12f);
                e.Graphics.DrawRectangle(Pens.Black, layoutRectangle.Left, layoutRectangle.Top, layoutRectangle.Width, layoutRectangle.Height);
                e.Graphics.DrawString("Comments:", font2, Brushes.Black, layoutRectangle, format2);
                float x15 = (float)pageLeftMargin;
                float y8 = y7 + 2f * height6;
                int num27 = 160;
                layoutRectangle = new RectangleF(x15, y8, (float)num27 * (float)num3, height6 * 2f);
                e.Graphics.DrawString("Falls:", font3, Brushes.Black, layoutRectangle, format2);
                float x16 = x15 + layoutRectangle.Width;
                int num28 = 140;
                layoutRectangle = new RectangleF(x16, y8, (float)num28 * (float)num3, height6 * 2f);
                e.Graphics.DrawString("__________", font3, Brushes.Black, layoutRectangle, format2);
                float x17 = (float)pageLeftMargin;
                float y9 = y8 + layoutRectangle.Height;
                int num29 = 160;
                layoutRectangle = new RectangleF(x17, y9, (float)num29 * (float)num3, height6 * 2f);
                e.Graphics.DrawString("Illegal element:", font3, Brushes.Black, layoutRectangle, format2);
                float x18 = x17 + layoutRectangle.Width;
                int num30 = 140;
                layoutRectangle = new RectangleF(x18, y9, (float)num30 * (float)num3, height6 * 2f);
                e.Graphics.DrawString("__________", font3, Brushes.Black, layoutRectangle, format2);
                float x19 = (float)pageLeftMargin;
                float y10 = y9 + layoutRectangle.Height;
                int num31 = 160;
                layoutRectangle = new RectangleF(x19, y10, (float)num31 * (float)num3, height6 * 2f);
                e.Graphics.DrawString("Interrupt:", font3, Brushes.Black, layoutRectangle, format2);
                float x20 = x19 + layoutRectangle.Width;
                int num32 = 140;
                layoutRectangle = new RectangleF(x20, y10, (float)num32 * (float)num3, height6 * 2f);
                e.Graphics.DrawString("__________", font3, Brushes.Black, layoutRectangle, format2);
                float x21 = (float)pageLeftMargin;
                float y11 = y10 + height6 * 5f;
                int num33 = 440;
                layoutRectangle = new RectangleF(x21, y11, (float)num33 * (float)num3, height6);
                e.Graphics.DrawString("......................................................................", font3, Brushes.Black, layoutRectangle, format2);
                float y12 = y11 + height6;
                int num34 = 440;
                layoutRectangle = new RectangleF(x21, y12, (float)num34 * (float)num3, height6);
                e.Graphics.DrawString("Signature", font5, Brushes.Black, layoutRectangle, format2);
                this.newpage = false;
                e.HasMorePages = false;
                goto label_32;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num35 = (int)Interaction.MsgBox((object)("JudgesCardForm, PrintDocument1_PrintPage_1 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_32:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }
    }
}

// Decompiled with JetBrains decompiler
// Type: ClubCompFS.Dialog8
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
    public class Dialog8 : Form
    {
        private IContainer components;
        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;
        [AccessedThroughProperty("OK_Button")]
        private Button _OK_Button;
        [AccessedThroughProperty("Cancel_Button")]
        private Button _Cancel_Button;
        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;
        [AccessedThroughProperty("PRINTToolStripMenuItem")]
        private ToolStripMenuItem _PRINTToolStripMenuItem;
        [AccessedThroughProperty("HeadPageToolStripMenuItem")]
        private ToolStripMenuItem _HeadPageToolStripMenuItem;
        [AccessedThroughProperty("txtCompetition")]
        private TextBox _txtCompetition;
        [AccessedThroughProperty("txtCategory")]
        private TextBox _txtCategory;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("txtArea")]
        private TextBox _txtArea;
        [AccessedThroughProperty("txtIceCondition")]
        private TextBox _txtIceCondition;
        [AccessedThroughProperty("txtNoParticipants")]
        private TextBox _txtNoParticipants;
        [AccessedThroughProperty("lblProg1")]
        private Label _lblProg1;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("Label9")]
        private Label _Label9;
        [AccessedThroughProperty("Label10")]
        private Label _Label10;
        [AccessedThroughProperty("Label11")]
        private Label _Label11;
        [AccessedThroughProperty("Label12")]
        private Label _Label12;
        [AccessedThroughProperty("txtSkatingSkills1")]
        private TextBox _txtSkatingSkills1;
        [AccessedThroughProperty("txtTransitions1")]
        private TextBox _txtTransitions1;
        [AccessedThroughProperty("txtPerformance1")]
        private TextBox _txtPerformance1;
        [AccessedThroughProperty("txtChoreo1")]
        private TextBox _txtChoreo1;
        [AccessedThroughProperty("txtInterpretation1")]
        private TextBox _txtInterpretation1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("TxtDate1")]
        private TextBox _TxtDate1;
        [AccessedThroughProperty("txtDate2")]
        private TextBox _txtDate2;
        [AccessedThroughProperty("txtLblDate1")]
        private Label _txtLblDate1;
        [AccessedThroughProperty("txtLblDate2")]
        private Label _txtLblDate2;
        [AccessedThroughProperty("txtDuration1")]
        private TextBox _txtDuration1;
        [AccessedThroughProperty("txtDuration2")]
        private TextBox _txtDuration2;
        [AccessedThroughProperty("txtInterpretation2")]
        private TextBox _txtInterpretation2;
        [AccessedThroughProperty("txtChoreo2")]
        private TextBox _txtChoreo2;
        [AccessedThroughProperty("txtPerformance2")]
        private TextBox _txtPerformance2;
        [AccessedThroughProperty("txtTransitions2")]
        private TextBox _txtTransitions2;
        [AccessedThroughProperty("txtSkatingSkills2")]
        private TextBox _txtSkatingSkills2;
        [AccessedThroughProperty("lbl27")]
        private Label _lbl27;
        [AccessedThroughProperty("lbl26")]
        private Label _lbl26;
        [AccessedThroughProperty("lbl25")]
        private Label _lbl25;
        [AccessedThroughProperty("lbl24")]
        private Label _lbl24;
        [AccessedThroughProperty("lbl23")]
        private Label _lbl23;
        [AccessedThroughProperty("lbl22")]
        private Label _lbl22;
        [AccessedThroughProperty("lbl21")]
        private Label _lbl21;
        [AccessedThroughProperty("lbl20")]
        private Label _lbl20;
        [AccessedThroughProperty("PrintPreviewDialog1")]
        private PrintPreviewDialog _PrintPreviewDialog1;
        [AccessedThroughProperty("PrintDocument1")]
        private PrintDocument _PrintDocument1;
        [AccessedThroughProperty("CREATEPDFFILEToolStripMenuItem")]
        private ToolStripMenuItem _CREATEPDFFILEToolStripMenuItem;
        [AccessedThroughProperty("lblOpenDB")]
        private Label _lblOpenDB;
        [AccessedThroughProperty("lblElementDB")]
        private Label _lblElementDB;
        [AccessedThroughProperty("lblOpenDBCreation")]
        private Label _lblOpenDBCreation;
        [AccessedThroughProperty("lblElementDBCreation")]
        private Label _lblElementDBCreation;
        private string[,] HDA;

        public Dialog8()
        {
            this.Load += new EventHandler(this.Dialog8_Load);
            this.HDA = new string[51, 4];
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Dialog8));
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.Cancel_Button = new Button();
            this.OK_Button = new Button();
            this.MenuStrip1 = new MenuStrip();
            this.PRINTToolStripMenuItem = new ToolStripMenuItem();
            this.HeadPageToolStripMenuItem = new ToolStripMenuItem();
            this.CREATEPDFFILEToolStripMenuItem = new ToolStripMenuItem();
            this.txtCompetition = new TextBox();
            this.txtCategory = new TextBox();
            this.Label2 = new Label();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this.txtArea = new TextBox();
            this.txtIceCondition = new TextBox();
            this.txtNoParticipants = new TextBox();
            this.lblProg1 = new Label();
            this.Label6 = new Label();
            this.Label7 = new Label();
            this.Label8 = new Label();
            this.Label9 = new Label();
            this.Label10 = new Label();
            this.Label11 = new Label();
            this.Label12 = new Label();
            this.txtSkatingSkills1 = new TextBox();
            this.txtTransitions1 = new TextBox();
            this.txtPerformance1 = new TextBox();
            this.txtChoreo1 = new TextBox();
            this.txtInterpretation1 = new TextBox();
            this.Label1 = new Label();
            this.TxtDate1 = new TextBox();
            this.txtDate2 = new TextBox();
            this.txtLblDate1 = new Label();
            this.txtLblDate2 = new Label();
            this.txtDuration1 = new TextBox();
            this.txtDuration2 = new TextBox();
            this.txtInterpretation2 = new TextBox();
            this.txtChoreo2 = new TextBox();
            this.txtPerformance2 = new TextBox();
            this.txtTransitions2 = new TextBox();
            this.txtSkatingSkills2 = new TextBox();
            this.lbl27 = new Label();
            this.lbl26 = new Label();
            this.lbl25 = new Label();
            this.lbl24 = new Label();
            this.lbl23 = new Label();
            this.lbl22 = new Label();
            this.lbl21 = new Label();
            this.lbl20 = new Label();
            this.PrintPreviewDialog1 = new PrintPreviewDialog();
            this.PrintDocument1 = new PrintDocument();
            this.lblOpenDB = new Label();
            this.lblElementDB = new Label();
            this.lblOpenDBCreation = new Label();
            this.lblElementDBCreation = new Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.TableLayoutPanel1.BackColor = Color.White;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add((Control)this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Controls.Add((Control)this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Location = new Point(149, 608);
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
            this.MenuStrip1.BackColor = Color.FromArgb((int)byte.MaxValue, 192, 128);
            this.MenuStrip1.Items.AddRange(new ToolStripItem[2]
            {
        (ToolStripItem) this.PRINTToolStripMenuItem,
        (ToolStripItem) this.CREATEPDFFILEToolStripMenuItem
            });
            this.MenuStrip1.Location = new Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            MenuStrip menuStrip1 = this.MenuStrip1;
            size1 = new Size(447, 24);
            Size size5 = size1;
            menuStrip1.Size = size5;
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            this.PRINTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[1]
            {
        (ToolStripItem) this.HeadPageToolStripMenuItem
            });
            this.PRINTToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.PRINTToolStripMenuItem.Name = "PRINTToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem1 = this.PRINTToolStripMenuItem;
            size1 = new Size(53, 20);
            Size size6 = size1;
            toolStripMenuItem1.Size = size6;
            this.PRINTToolStripMenuItem.Text = "PRINT";
            this.HeadPageToolStripMenuItem.Name = "HeadPageToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem2 = this.HeadPageToolStripMenuItem;
            size1 = new Size(134, 22);
            Size size7 = size1;
            toolStripMenuItem2.Size = size7;
            this.HeadPageToolStripMenuItem.Text = "Head Page";
            this.CREATEPDFFILEToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.CREATEPDFFILEToolStripMenuItem.Name = "CREATEPDFFILEToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem3 = this.CREATEPDFFILEToolStripMenuItem;
            size1 = new Size(113, 20);
            Size size8 = size1;
            toolStripMenuItem3.Size = size8;
            this.CREATEPDFFILEToolStripMenuItem.Text = "CREATE PDF-FILE";
            this.txtCompetition.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtCompetition.Location = new Point(5, 27);
            this.txtCompetition.Name = "txtCompetition";
            this.txtCompetition.ReadOnly = true;
            TextBox txtCompetition = this.txtCompetition;
            size1 = new Size(424, 20);
            Size size9 = size1;
            txtCompetition.Size = size9;
            this.txtCompetition.TabIndex = 3;
            this.txtCategory.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtCategory.Location = new Point(5, 53);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            TextBox txtCategory = this.txtCategory;
            size1 = new Size(424, 20);
            Size size10 = size1;
            txtCategory.Size = size10;
            this.txtCategory.TabIndex = 4;
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new Point(4, 132);
            this.Label2.Name = "Label2";
            Label label2 = this.Label2;
            size1 = new Size(123, 13);
            Size size11 = size1;
            label2.Size = size11;
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Size of Skating Area";
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new Point(4, 154);
            this.Label3.Name = "Label3";
            Label label3 = this.Label3;
            size1 = new Size(88, 13);
            Size size12 = size1;
            label3.Size = size12;
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Ice Conditions";
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label4.Location = new Point(4, 176);
            this.Label4.Name = "Label4";
            Label label4 = this.Label4;
            size1 = new Size(136, 13);
            Size size13 = size1;
            label4.Size = size13;
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Number of Participants";
            this.txtArea.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtArea.Location = new Point(190, 129);
            this.txtArea.Name = "txtArea";
            TextBox txtArea = this.txtArea;
            size1 = new Size(128, 20);
            Size size14 = size1;
            txtArea.Size = size14;
            this.txtArea.TabIndex = 1;
            this.txtIceCondition.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtIceCondition.Location = new Point(190, 151);
            this.txtIceCondition.Name = "txtIceCondition";
            TextBox txtIceCondition = this.txtIceCondition;
            size1 = new Size(128, 20);
            Size size15 = size1;
            txtIceCondition.Size = size15;
            this.txtIceCondition.TabIndex = 2;
            this.txtNoParticipants.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtNoParticipants.Location = new Point(190, 173);
            this.txtNoParticipants.Name = "txtNoParticipants";
            this.txtNoParticipants.ReadOnly = true;
            TextBox txtNoParticipants = this.txtNoParticipants;
            size1 = new Size(38, 20);
            Size size16 = size1;
            txtNoParticipants.Size = size16;
            this.txtNoParticipants.TabIndex = 10;
            this.txtNoParticipants.TextAlign = HorizontalAlignment.Center;
            this.lblProg1.AutoSize = true;
            this.lblProg1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblProg1.Location = new Point(4, 204);
            this.lblProg1.Name = "lblProg1";
            Label lblProg1 = this.lblProg1;
            size1 = new Size(116, 13);
            Size size17 = size1;
            lblProg1.Size = size17;
            this.lblProg1.TabIndex = 11;
            this.lblProg1.Text = "SHORT PROGRAM";
            this.Label6.AutoSize = true;
            this.Label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label6.Location = new Point(4, 226);
            this.Label6.Name = "Label6";
            Label label6 = this.Label6;
            size1 = new Size(55, 13);
            Size size18 = size1;
            label6.Size = size18;
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Duration";
            this.Label7.AutoSize = true;
            this.Label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label7.Location = new Point(4, 248);
            this.Label7.Name = "Label7";
            Label label7 = this.Label7;
            size1 = new Size(166, 13);
            Size size19 = size1;
            label7.Size = size19;
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Program Component Factors";
            this.Label8.AutoSize = true;
            this.Label8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label8.Location = new Point(185, 248);
            this.Label8.Name = "Label8";
            Label label8 = this.Label8;
            size1 = new Size(84, 13);
            Size size20 = size1;
            label8.Size = size20;
            this.Label8.TabIndex = 14;
            this.Label8.Text = "Impostazione di base";
            this.Label10.AutoSize = true;
            this.Label10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label10.Location = new Point(185, 288);
            this.Label10.Name = "Label10";
            Label label10 = this.Label10;
            size1 = new Size(78, 13);
            Size size21 = size1;
            label10.Size = size21;
            this.Label10.TabIndex = 16;
            this.Label10.Text = "Performance";
            this.txtSkatingSkills1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtSkatingSkills1.Location = new Point(371, 245);
            this.txtSkatingSkills1.Name = "txtSkatingSkills1";
            this.txtSkatingSkills1.ReadOnly = true;
            TextBox txtSkatingSkills1 = this.txtSkatingSkills1;
            size1 = new Size(58, 20);
            Size size22 = size1;
            txtSkatingSkills1.Size = size22;
            this.txtSkatingSkills1.TabIndex = 19;
            this.txtSkatingSkills1.TextAlign = HorizontalAlignment.Center;
            this.txtTransitions1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtTransitions1.Location = new Point(371, 265);
            this.txtTransitions1.Name = "txtTransitions1";
            this.txtTransitions1.ReadOnly = true;
            TextBox txtTransitions1 = this.txtTransitions1;
            size1 = new Size(58, 20);
            Size size23 = size1;
            txtTransitions1.Size = size23;
            this.txtTransitions1.TabIndex = 20;
            this.txtTransitions1.TextAlign = HorizontalAlignment.Center;
            this.txtPerformance1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtPerformance1.Location = new Point(371, 285);
            this.txtPerformance1.Name = "txtPerformance1";
            this.txtPerformance1.ReadOnly = true;
            TextBox txtPerformance1 = this.txtPerformance1;
            size1 = new Size(58, 20);
            Size size24 = size1;
            txtPerformance1.Size = size24;
            this.txtPerformance1.TabIndex = 21;
            this.txtPerformance1.TextAlign = HorizontalAlignment.Center;
            this.txtChoreo1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtChoreo1.Location = new Point(371, 305);
            this.txtChoreo1.Name = "txtChoreo1";
            this.txtChoreo1.ReadOnly = true;
            TextBox txtChoreo1 = this.txtChoreo1;
            size1 = new Size(58, 20);
            Size size25 = size1;
            txtChoreo1.Size = size25;
            this.txtChoreo1.TabIndex = 22;
            this.txtChoreo1.TextAlign = HorizontalAlignment.Center;
            this.txtInterpretation1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtInterpretation1.Location = new Point(371, 325);
            this.txtInterpretation1.Name = "txtInterpretation1";
            this.txtInterpretation1.ReadOnly = true;
            TextBox txtInterpretation1 = this.txtInterpretation1;
            size1 = new Size(58, 20);
            Size size26 = size1;
            txtInterpretation1.Size = size26;
            this.txtInterpretation1.TabIndex = 23;
            this.txtInterpretation1.TextAlign = HorizontalAlignment.Center;
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new Point(4, 85);
            this.Label1.Name = "Label1";
            Label label1 = this.Label1;
            size1 = new Size(34, 13);
            Size size27 = size1;
            label1.Size = size27;
            this.Label1.TabIndex = 24;
            this.Label1.Text = "Date";
            this.TxtDate1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.TxtDate1.Location = new Point(190, 82);
            this.TxtDate1.Name = "TxtDate1";
            this.TxtDate1.ReadOnly = true;
            TextBox txtDate1 = this.TxtDate1;
            size1 = new Size(79, 20);
            Size size28 = size1;
            txtDate1.Size = size28;
            this.TxtDate1.TabIndex = 25;
            this.TxtDate1.TextAlign = HorizontalAlignment.Center;
            this.txtDate2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtDate2.Location = new Point(190, 102);
            this.txtDate2.Name = "txtDate2";
            this.txtDate2.ReadOnly = true;
            TextBox txtDate2 = this.txtDate2;
            size1 = new Size(80, 20);
            Size size29 = size1;
            txtDate2.Size = size29;
            this.txtDate2.TabIndex = 26;
            this.txtDate2.TextAlign = HorizontalAlignment.Center;
            this.txtDate2.Visible = false;
            this.txtLblDate1.AutoSize = true;
            this.txtLblDate1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtLblDate1.Location = new Point(85, 85);
            this.txtLblDate1.Name = "txtLblDate1";
            Label txtLblDate1 = this.txtLblDate1;
            size1 = new Size(87, 13);
            Size size30 = size1;
            txtLblDate1.Size = size30;
            this.txtLblDate1.TabIndex = 27;
            this.txtLblDate1.Text = "Short Program";
            this.txtLblDate2.AutoSize = true;
            this.txtLblDate2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtLblDate2.Location = new Point(85, 105);
            this.txtLblDate2.Name = "txtLblDate2";
            Label txtLblDate2 = this.txtLblDate2;
            size1 = new Size(79, 13);
            Size size31 = size1;
            txtLblDate2.Size = size31;
            this.txtLblDate2.TabIndex = 28;
            this.txtLblDate2.Text = "Free Skating";
            this.txtLblDate2.Visible = false;
            this.txtDuration1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtDuration1.Location = new Point(190, 219);
            this.txtDuration1.Name = "txtDuration1";
            this.txtDuration1.ReadOnly = true;
            TextBox txtDuration1 = this.txtDuration1;
            size1 = new Size(79, 20);
            Size size32 = size1;
            txtDuration1.Size = size32;
            this.txtDuration1.TabIndex = 29;
            this.txtDuration1.TextAlign = HorizontalAlignment.Center;
            this.txtDuration2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtDuration2.Location = new Point(188, 377);
            this.txtDuration2.Name = "txtDuration2";
            this.txtDuration2.ReadOnly = true;
            TextBox txtDuration2 = this.txtDuration2;
            size1 = new Size(82, 20);
            Size size33 = size1;
            txtDuration2.Size = size33;
            this.txtDuration2.TabIndex = 43;
            this.txtDuration2.TextAlign = HorizontalAlignment.Center;
            this.txtDuration2.Visible = false;
            this.txtInterpretation2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtInterpretation2.Location = new Point(373, 483);
            this.txtInterpretation2.Name = "txtInterpretation2";
            this.txtInterpretation2.ReadOnly = true;
            TextBox txtInterpretation2 = this.txtInterpretation2;
            size1 = new Size(58, 20);
            Size size34 = size1;
            txtInterpretation2.Size = size34;
            this.txtInterpretation2.TabIndex = 42;
            this.txtInterpretation2.TextAlign = HorizontalAlignment.Center;
            this.txtInterpretation2.Visible = false;
            this.txtChoreo2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtChoreo2.Location = new Point(373, 463);
            this.txtChoreo2.Name = "txtChoreo2";
            this.txtChoreo2.ReadOnly = true;
            TextBox txtChoreo2 = this.txtChoreo2;
            size1 = new Size(58, 20);
            Size size35 = size1;
            txtChoreo2.Size = size35;
            this.txtChoreo2.TabIndex = 41;
            this.txtChoreo2.TextAlign = HorizontalAlignment.Center;
            this.txtChoreo2.Visible = false;
            this.txtPerformance2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtPerformance2.Location = new Point(373, 443);
            this.txtPerformance2.Name = "txtPerformance2";
            this.txtPerformance2.ReadOnly = true;
            TextBox txtPerformance2 = this.txtPerformance2;
            size1 = new Size(58, 20);
            Size size36 = size1;
            txtPerformance2.Size = size36;
            this.txtPerformance2.TabIndex = 40;
            this.txtPerformance2.TextAlign = HorizontalAlignment.Center;
            this.txtPerformance2.Visible = false;
            this.txtTransitions2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtTransitions2.Location = new Point(373, 423);
            this.txtTransitions2.Name = "txtTransitions2";
            this.txtTransitions2.ReadOnly = true;
            TextBox txtTransitions2 = this.txtTransitions2;
            size1 = new Size(58, 20);
            Size size37 = size1;
            txtTransitions2.Size = size37;
            this.txtTransitions2.TabIndex = 39;
            this.txtTransitions2.TextAlign = HorizontalAlignment.Center;
            this.txtTransitions2.Visible = false;
            this.txtSkatingSkills2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtSkatingSkills2.Location = new Point(373, 403);
            this.txtSkatingSkills2.Name = "txtSkatingSkills2";
            this.txtSkatingSkills2.ReadOnly = true;
            TextBox txtSkatingSkills2 = this.txtSkatingSkills2;
            size1 = new Size(58, 20);
            Size size38 = size1;
            txtSkatingSkills2.Size = size38;
            this.txtSkatingSkills2.TabIndex = 38;
            this.txtSkatingSkills2.TextAlign = HorizontalAlignment.Center;
            this.txtSkatingSkills2.Visible = false;
            this.lbl26.AutoSize = true;
            this.lbl26.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lbl26.Location = new Point(187, 466);
            this.lbl26.Name = "lbl26";
            Label lbl26 = this.lbl26;
            size1 = new Size(75, 13);
            Size size39 = size1;
            lbl26.Size = size39;
            this.lbl26.TabIndex = 36;
            this.lbl26.Text = "Coreografia";
            this.lbl26.Visible = false;
            this.lbl25.AutoSize = true;
            this.lbl25.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lbl25.Location = new Point(185, 446);
            this.lbl25.Name = "lbl25";
            Label lbl25 = this.lbl25;
            size1 = new Size(78, 13);
            Size size40 = size1;
            lbl25.Size = size40;
            this.lbl25.TabIndex = 35;
            this.lbl25.Text = "Performance";
            this.lbl25.Visible = false;
            this.lbl24.AutoSize = true;
            this.lbl24.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lbl24.Location = new Point(185, 426);
            this.lbl24.Name = "lbl24";
            Label lbl24 = this.lbl24;
            size1 = new Size(69, 13);
            Size size41 = size1;
            lbl24.Size = size41;
            this.lbl24.TabIndex = 34;
            this.lbl24.Text = "Scorrevolezza";
            this.lbl24.Visible = false;
            this.lbl23.AutoSize = true;
            this.lbl23.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lbl23.Location = new Point(185, 406);
            this.lbl23.Name = "lbl23";
            Label lbl23 = this.lbl23;
            size1 = new Size(84, 13);
            Size size42 = size1;
            lbl23.Size = size42;
            this.lbl23.TabIndex = 33;
            this.lbl23.Text = "Impostazione di base";
            this.lbl23.Visible = false;
            this.lbl22.AutoSize = true;
            this.lbl22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lbl22.Location = new Point(6, 406);
            this.lbl22.Name = "lbl22";
            Label lbl22 = this.lbl22;
            size1 = new Size(166, 13);
            Size size43 = size1;
            lbl22.Size = size43;
            this.lbl22.TabIndex = 32;
            this.lbl22.Text = "Program Component Factors";
            this.lbl22.Visible = false;
            this.lbl21.AutoSize = true;
            this.lbl21.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lbl21.Location = new Point(6, 384);
            this.lbl21.Name = "lbl21";
            Label lbl21 = this.lbl21;
            size1 = new Size(55, 13);
            Size size44 = size1;
            lbl21.Size = size44;
            this.lbl21.TabIndex = 31;
            this.lbl21.Text = "Duration";
            this.lbl21.Visible = false;
            this.lbl20.AutoSize = true;
            this.lbl20.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lbl20.Location = new Point(6, 362);
            this.lbl20.Name = "lbl20";
            Label lbl20 = this.lbl20;
            size1 = new Size(97, 13);
            Size size45 = size1;
            lbl20.Size = size45;
            this.lbl20.TabIndex = 30;
            this.lbl20.Text = "FREE SKATING";
            this.lbl20.Visible = false;
            PrintPreviewDialog printPreviewDialog1_1 = this.PrintPreviewDialog1;
            size1 = new Size(0, 0);
            Size size46 = size1;
            printPreviewDialog1_1.AutoScrollMargin = size46;
            PrintPreviewDialog printPreviewDialog1_2 = this.PrintPreviewDialog1;
            size1 = new Size(0, 0);
            Size size47 = size1;
            printPreviewDialog1_2.AutoScrollMinSize = size47;
            PrintPreviewDialog printPreviewDialog1_3 = this.PrintPreviewDialog1;
            size1 = new Size(400, 300);
            Size size48 = size1;
            printPreviewDialog1_3.ClientSize = size48;
            this.PrintPreviewDialog1.Enabled = true;
            this.PrintPreviewDialog1.Icon = (Icon)componentResourceManager.GetObject("PrintPreviewDialog1.Icon");
            this.PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            this.PrintPreviewDialog1.Visible = false;
            this.lblOpenDB.AutoSize = true;
            this.lblOpenDB.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblOpenDB.Location = new Point(6, 515);
            this.lblOpenDB.Name = "lblOpenDB";
            Label lblOpenDb = this.lblOpenDB;
            size1 = new Size(58, 13);
            Size size49 = size1;
            lblOpenDb.Size = size49;
            this.lblOpenDB.TabIndex = 44;
            this.lblOpenDB.Text = "Open DB";
            this.lblElementDB.AutoSize = true;
            this.lblElementDB.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblElementDB.Location = new Point(6, 560);
            this.lblElementDB.Name = "lblElementDB";
            Label lblElementDb = this.lblElementDB;
            size1 = new Size(73, 13);
            Size size50 = size1;
            lblElementDb.Size = size50;
            this.lblElementDB.TabIndex = 45;
            this.lblElementDB.Text = "Element DB";
            this.lblOpenDBCreation.AutoSize = true;
            this.lblOpenDBCreation.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblOpenDBCreation.Location = new Point(6, 535);
            this.lblOpenDBCreation.Name = "lblOpenDBCreation";
            Label lblOpenDbCreation = this.lblOpenDBCreation;
            size1 = new Size(44, 13);
            Size size51 = size1;
            lblOpenDbCreation.Size = size51;
            this.lblOpenDBCreation.TabIndex = 46;
            this.lblOpenDBCreation.Text = "Created";
            this.lblElementDBCreation.AutoSize = true;
            this.lblElementDBCreation.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.lblElementDBCreation.Location = new Point(6, 580);
            this.lblElementDBCreation.Name = "lblElementDBCreation";
            Label elementDbCreation = this.lblElementDBCreation;
            size1 = new Size(44, 13);
            Size size52 = size1;
            elementDbCreation.Size = size52;
            this.lblElementDBCreation.TabIndex = 47;
            this.lblElementDBCreation.Text = "Created";
            this.AcceptButton = (IButtonControl)this.OK_Button;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb((int)byte.MaxValue, 192, 128);
            this.CancelButton = (IButtonControl)this.Cancel_Button;
            size1 = new Size(447, 649);
            this.ClientSize = size1;
            this.ControlBox = false;
            this.Controls.Add((Control)this.lblElementDBCreation);
            this.Controls.Add((Control)this.lblOpenDBCreation);
            this.Controls.Add((Control)this.lblElementDB);
            this.Controls.Add((Control)this.lblOpenDB);
            this.Controls.Add((Control)this.txtDuration2);
            this.Controls.Add((Control)this.txtInterpretation2);
            this.Controls.Add((Control)this.txtChoreo2);
            this.Controls.Add((Control)this.txtPerformance2);
            this.Controls.Add((Control)this.txtTransitions2);
            this.Controls.Add((Control)this.txtSkatingSkills2);
            this.Controls.Add((Control)this.lbl27);
            this.Controls.Add((Control)this.lbl26);
            this.Controls.Add((Control)this.lbl25);
            this.Controls.Add((Control)this.lbl24);
            this.Controls.Add((Control)this.lbl23);
            this.Controls.Add((Control)this.lbl22);
            this.Controls.Add((Control)this.lbl21);
            this.Controls.Add((Control)this.lbl20);
            this.Controls.Add((Control)this.txtDuration1);
            this.Controls.Add((Control)this.txtLblDate2);
            this.Controls.Add((Control)this.txtLblDate1);
            this.Controls.Add((Control)this.txtDate2);
            this.Controls.Add((Control)this.TxtDate1);
            this.Controls.Add((Control)this.Label1);
            this.Controls.Add((Control)this.txtInterpretation1);
            this.Controls.Add((Control)this.txtChoreo1);
            this.Controls.Add((Control)this.txtPerformance1);
            this.Controls.Add((Control)this.txtTransitions1);
            this.Controls.Add((Control)this.txtSkatingSkills1);
            this.Controls.Add((Control)this.Label12);
            this.Controls.Add((Control)this.Label11);
            this.Controls.Add((Control)this.Label10);
            this.Controls.Add((Control)this.Label9);
            this.Controls.Add((Control)this.Label8);
            this.Controls.Add((Control)this.Label7);
            this.Controls.Add((Control)this.Label6);
            this.Controls.Add((Control)this.lblProg1);
            this.Controls.Add((Control)this.txtNoParticipants);
            this.Controls.Add((Control)this.txtIceCondition);
            this.Controls.Add((Control)this.txtArea);
            this.Controls.Add((Control)this.Label4);
            this.Controls.Add((Control)this.Label3);
            this.Controls.Add((Control)this.Label2);
            this.Controls.Add((Control)this.txtCategory);
            this.Controls.Add((Control)this.txtCompetition);
            this.Controls.Add((Control)this.TableLayoutPanel1);
            this.Controls.Add((Control)this.MenuStrip1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(Dialog8);
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "HEAD PAGE";
            this.TopMost = true;
            this.TableLayoutPanel1.ResumeLayout(false);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
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

        internal virtual ToolStripMenuItem HeadPageToolStripMenuItem
        {
            get => this._HeadPageToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._HeadPageToolStripMenuItem = value;
        }

        internal virtual TextBox txtCompetition
        {
            get => this._txtCompetition;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtCompetition = value;
        }

        internal virtual TextBox txtCategory
        {
            get => this._txtCategory;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtCategory = value;
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

        internal virtual TextBox txtArea
        {
            get => this._txtArea;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtArea_KeyPress);
                if (this._txtArea != null)
                    this._txtArea.KeyPress -= pressEventHandler;
                this._txtArea = value;
                if (this._txtArea == null)
                    return;
                this._txtArea.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox txtIceCondition
        {
            get => this._txtIceCondition;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtIceCondition_KeyPress);
                if (this._txtIceCondition != null)
                    this._txtIceCondition.KeyPress -= pressEventHandler;
                this._txtIceCondition = value;
                if (this._txtIceCondition == null)
                    return;
                this._txtIceCondition.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox txtNoParticipants
        {
            get => this._txtNoParticipants;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtNoParticipants = value;
        }

        internal virtual Label lblProg1
        {
            get => this._lblProg1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblProg1 = value;
        }

        internal virtual Label Label6
        {
            get => this._Label6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label6 = value;
        }

        internal virtual Label Label7
        {
            get => this._Label7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label7 = value;
        }

        internal virtual Label Label8
        {
            get => this._Label8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label8 = value;
        }

        internal virtual Label Label9
        {
            get => this._Label9;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label9 = value;
        }

        internal virtual Label Label10
        {
            get => this._Label10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label10 = value;
        }

        internal virtual Label Label11
        {
            get => this._Label11;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label11 = value;
        }

        internal virtual Label Label12
        {
            get => this._Label12;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label12 = value;
        }

        internal virtual TextBox txtSkatingSkills1
        {
            get => this._txtSkatingSkills1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtSkatingSkills1 = value;
        }

        internal virtual TextBox txtTransitions1
        {
            get => this._txtTransitions1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtTransitions1 = value;
        }

        internal virtual TextBox txtPerformance1
        {
            get => this._txtPerformance1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtPerformance1 = value;
        }

        internal virtual TextBox txtChoreo1
        {
            get => this._txtChoreo1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtChoreo1 = value;
        }

        internal virtual TextBox txtInterpretation1
        {
            get => this._txtInterpretation1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtInterpretation1 = value;
        }

        internal virtual Label Label1
        {
            get => this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label1 = value;
        }

        internal virtual TextBox TxtDate1
        {
            get => this._TxtDate1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._TxtDate1 = value;
        }

        internal virtual TextBox txtDate2
        {
            get => this._txtDate2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtDate2 = value;
        }

        internal virtual Label txtLblDate1
        {
            get => this._txtLblDate1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtLblDate1 = value;
        }

        internal virtual Label txtLblDate2
        {
            get => this._txtLblDate2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtLblDate2 = value;
        }

        internal virtual TextBox txtDuration1
        {
            get => this._txtDuration1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtDuration1 = value;
        }

        internal virtual TextBox txtDuration2
        {
            get => this._txtDuration2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtDuration2 = value;
        }

        internal virtual TextBox txtInterpretation2
        {
            get => this._txtInterpretation2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtInterpretation2 = value;
        }

        internal virtual TextBox txtChoreo2
        {
            get => this._txtChoreo2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtChoreo2 = value;
        }

        internal virtual TextBox txtPerformance2
        {
            get => this._txtPerformance2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtPerformance2 = value;
        }

        internal virtual TextBox txtTransitions2
        {
            get => this._txtTransitions2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtTransitions2 = value;
        }

        internal virtual TextBox txtSkatingSkills2
        {
            get => this._txtSkatingSkills2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtSkatingSkills2 = value;
        }

        internal virtual Label lbl27
        {
            get => this._lbl27;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lbl27 = value;
        }

        internal virtual Label lbl26
        {
            get => this._lbl26;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lbl26 = value;
        }

        internal virtual Label lbl25
        {
            get => this._lbl25;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lbl25 = value;
        }

        internal virtual Label lbl24
        {
            get => this._lbl24;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lbl24 = value;
        }

        internal virtual Label lbl23
        {
            get => this._lbl23;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lbl23 = value;
        }

        internal virtual Label lbl22
        {
            get => this._lbl22;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lbl22 = value;
        }

        internal virtual Label lbl21
        {
            get => this._lbl21;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lbl21 = value;
        }

        internal virtual Label lbl20
        {
            get => this._lbl20;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lbl20 = value;
        }

        internal virtual PrintPreviewDialog PrintPreviewDialog1
        {
            get => this._PrintPreviewDialog1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PrintPreviewDialog1 = value;
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

        internal virtual ToolStripMenuItem CREATEPDFFILEToolStripMenuItem
        {
            get => this._CREATEPDFFILEToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.CREATEPDFFILEToolStripMenuItem_Click);
                if (this._CREATEPDFFILEToolStripMenuItem != null)
                    this._CREATEPDFFILEToolStripMenuItem.Click -= eventHandler;
                this._CREATEPDFFILEToolStripMenuItem = value;
                if (this._CREATEPDFFILEToolStripMenuItem == null)
                    return;
                this._CREATEPDFFILEToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual Label lblOpenDB
        {
            get => this._lblOpenDB;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblOpenDB = value;
        }

        internal virtual Label lblElementDB
        {
            get => this._lblElementDB;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblElementDB = value;
        }

        internal virtual Label lblOpenDBCreation
        {
            get => this._lblOpenDBCreation;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblOpenDBCreation = value;
        }

        internal virtual Label lblElementDBCreation
        {
            get => this._lblElementDBCreation;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblElementDBCreation = value;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Module1.IceArea = this.txtArea.Text;
            Module1.IceCondition = this.txtIceCondition.Text;
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void Dialog8_Load(object sender, EventArgs e)
        {
            this.Top = MyProject.Forms.Form1.Top;
            this.Left = checked((int)Math.Round(unchecked((double)MyProject.Forms.Form1.Left + (double)MyProject.Forms.Form1.Width / 2.0 - (double)this.Width / 2.0)));
            this.TopMost = true;
            this.CreateHeadPage();
        }

        public void CreateHeadPage()
        {
            string str = "";
            Dialog8 dialog8 = this;
            dialog8.txtCompetition.Text = Module1.Competition.Name;
            dialog8.txtCategory.Text = Module1.Category.Name + Module1.SubCat();
            if (Operators.CompareString(Module1.OpenDB[Module1.PcIndex].Segment_1, "S", false) == 0 | Operators.CompareString(Module1.OpenDB[Module1.PcIndex].Segment_1, "F", false) == 0)
            {
                string segment1 = Module1.OpenDB[Module1.PcIndex].Segment_1;
                if (Operators.CompareString(segment1, "S", false) == 0)
                    this.lblProg1.Text = "SEGMENT 1 - Short Program";
                else if (Operators.CompareString(segment1, "F", false) == 0)
                    this.lblProg1.Text = "SEGMENT 1 - Free Skating";
                dialog8.Height = 520;
                dialog8.TxtDate1.Text = Module1.FormShortDate(Module1.Datum.Seg1);
                dialog8.txtArea.Text = Module1.IceArea;
                dialog8.txtIceCondition.Text = Module1.IceCondition;
                dialog8.txtNoParticipants.Text = Conversions.ToString(Module1.TNop);
                dialog8.txtDuration1.Text = Module1.OpenDB[Module1.PcIndex].Seg1Time;
                dialog8.txtSkatingSkills1.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[1]);
                dialog8.txtTransitions1.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[2]);
                dialog8.txtPerformance1.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[3]);
                dialog8.txtChoreo1.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[4]);
                dialog8.txtInterpretation1.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[5]);
                dialog8.lblOpenDB.Top = checked(dialog8.txtInterpretation1.Top + 29);
                dialog8.lblOpenDBCreation.Top = checked(dialog8.lblOpenDB.Top + 20);
                dialog8.lblElementDB.Top = checked(dialog8.lblOpenDB.Top + 50);
                dialog8.lblElementDBCreation.Top = checked(dialog8.lblElementDB.Top + 20);
            }
            if (Operators.CompareString(Module1.GetSeg(), "0F", false) == 0 | Operators.CompareString(Module1.GetSeg(), "0S", false) == 0)
            {
                string segment2 = Module1.OpenDB[Module1.PcIndex].Segment_2;
                if (Operators.CompareString(segment2, "S", false) == 0)
                {
                    str = "Short Program";
                    this.lbl20.Text = "SEGMENT 2 - " + str;
                }
                else if (Operators.CompareString(segment2, "F", false) == 0)
                {
                    str = "Free Skating";
                    this.lbl20.Text = "SEGMENT 2 - " + str;
                }
                dialog8.Height = 520;
                dialog8.TxtDate1.Text = Module1.FormShortDate(Module1.Datum.Seg2);
                dialog8.txtLblDate1.Text = "Segment 2";
                dialog8.txtArea.Text = "30m*60m";
                dialog8.txtIceCondition.Text = "Very Good";
                dialog8.txtNoParticipants.Text = Conversions.ToString(Module1.TNop);
                dialog8.lblProg1.Text = "SEGMENT 2 - " + Strings.UCase(str);
                dialog8.txtDuration1.Text = Module1.OpenDB[Module1.PcIndex].Seg2Time;
                dialog8.txtSkatingSkills1.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[1]);
                dialog8.txtTransitions1.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[2]);
                dialog8.txtPerformance1.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[3]);
                dialog8.txtChoreo1.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[4]);
                dialog8.txtInterpretation1.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[5]);
                dialog8.lblOpenDB.Top = checked(dialog8.txtInterpretation1.Top + 29);
                dialog8.lblOpenDBCreation.Top = checked(dialog8.lblOpenDB.Top + 20);
                dialog8.lblElementDB.Top = checked(dialog8.lblOpenDB.Top + 50);
                dialog8.lblElementDBCreation.Top = checked(dialog8.lblElementDB.Top + 20);
            }
            if (Operators.CompareString(Module1.GetSeg(), "SF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "FF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "SS", false) == 0)
            {
                string segment2 = Module1.OpenDB[Module1.PcIndex].Segment_2;
                if (Operators.CompareString(segment2, "S", false) == 0)
                    this.lbl20.Text = "SEGMENT 2 - Short Program";
                else if (Operators.CompareString(segment2, "F", false) == 0)
                    this.lbl20.Text = "SEGMENT 2 - Free Skating";
                dialog8.txtDate2.Visible = true;
                dialog8.txtLblDate2.Visible = true;
                dialog8.txtDuration2.Visible = true;
                dialog8.txtSkatingSkills2.Visible = true;
                dialog8.txtTransitions2.Visible = true;
                dialog8.txtPerformance2.Visible = true;
                dialog8.txtChoreo2.Visible = true;
                dialog8.txtInterpretation2.Visible = true;
                dialog8.lbl20.Visible = true;
                dialog8.lbl21.Visible = true;
                dialog8.lbl22.Visible = true;
                dialog8.lbl23.Visible = true;
                dialog8.lbl24.Visible = true;
                dialog8.lbl25.Visible = true;
                dialog8.lbl26.Visible = true;
                dialog8.lbl27.Visible = true;
                dialog8.Height = 682;
                dialog8.txtDate2.Text = Module1.FormShortDate(Module1.Datum.Seg2);
                dialog8.txtDuration2.Text = Module1.OpenDB[Module1.PcIndex].Seg2Time;
                dialog8.txtSkatingSkills2.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[1]);
                dialog8.txtTransitions2.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[2]);
                dialog8.txtPerformance2.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[3]);
                dialog8.txtChoreo2.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[4]);
                dialog8.txtInterpretation2.Text = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[5]);
                dialog8.lblOpenDB.Top = checked(dialog8.txtInterpretation2.Top + 29);
                dialog8.lblOpenDBCreation.Top = checked(dialog8.lblOpenDB.Top + 20);
                dialog8.lblElementDB.Top = checked(dialog8.lblOpenDB.Top + 50);
                dialog8.lblElementDBCreation.Top = checked(dialog8.lblElementDB.Top + 20);
            }
            dialog8.lblOpenDB.Text = Module1.OpenDBver;
            dialog8.lblOpenDBCreation.Text = "Created: " + Module1.DateTimeToStr(Module1.OpenDBLastWriteTime);
            dialog8.lblElementDB.Text = Module1.ElementDBver;
            dialog8.lblElementDBCreation.Text = "Created: " + Module1.DateTimeToStr(Module1.ElementDBLastWriteTime);
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                double num3 = Module1.Page_Size * 1.0 / 100.0;
                double x1 = (double)Module1.Page_Left_Margin + num3 * 30.0;
                float num4 = (float)x1;
                float pageTopMargin = (float)Module1.Page_Top_Margin;
                ProjectData.ClearProjectError();
                num1 = 2;
                StringFormat stringFormat1 = new StringFormat(StringFormatFlags.LineLimit)
                {
                    LineAlignment = StringAlignment.Center,
                    Trimming = StringTrimming.EllipsisCharacter
                };
                StringFormat stringFormat2 = new StringFormat(StringFormatFlags.NoClip);
                StringFormat format = new StringFormat(StringFormatFlags.NoClip);
                stringFormat2.Alignment = StringAlignment.Center;
                format.Alignment = StringAlignment.Near;
                float emSize = (float)Conversion.Int(num3 * 10.0 + 2.25);
                Font font1 = new Font("ARIAL", emSize + 2f, FontStyle.Bold, GraphicsUnit.Pixel);
                Font font2 = new Font("ARIAL", emSize, FontStyle.Bold, GraphicsUnit.Pixel);
                Font font3 = new Font("ARIAL", emSize, FontStyle.Regular, GraphicsUnit.Pixel);
                Font font4 = new Font("ARIAL", 8f, FontStyle.Regular, GraphicsUnit.Pixel);
                double height1 = (double)font1.GetHeight(e.Graphics);
                e.Graphics.DrawString("HEAD PAGE", font1, Brushes.Black, (float)x1, pageTopMargin, new StringFormat());
                float height2 = (float)font1.Height;
                float y1 = (float)((double)pageTopMargin + (double)font1.GetHeight(e.Graphics) + 10.0);
                e.Graphics.DrawString("COMPETITION:", font2, Brushes.Black, (float)x1, y1, new StringFormat());
                RectangleF layoutRectangle = new RectangleF(num4 + (float)(200.0 * num3), y1, (float)(400.0 * num3), height2);
                e.Graphics.DrawString(Module1.Competition.Name, font3, Brushes.Black, layoutRectangle, format);
                float num5 = (float)x1;
                float y2 = y1 + font1.GetHeight(e.Graphics);
                e.Graphics.DrawString("CATEGORY:", font2, Brushes.Black, (float)x1, y2, new StringFormat());
                layoutRectangle = new RectangleF(num5 + (float)(200.0 * num3), y2, (float)(400.0 * num3), height2);
                e.Graphics.DrawString(Module1.Category.Name + Module1.SubCat(), font3, Brushes.Black, layoutRectangle, format);
                float x2 = (float)x1;
                float y3 = (float)((double)y2 + (double)font1.GetHeight(e.Graphics) + 10.0);
                float height3 = (float)font3.Height;
                layoutRectangle = new RectangleF(x2, y3, (float)(200.0 * num3), height3);
                if (Operators.CompareString(Module1.GetSeg(), "S0", false) == 0)
                {
                    layoutRectangle = new RectangleF(x2, y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("DATE:", font2, Brushes.Black, layoutRectangle, format);
                    float x3 = x2 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x3, y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.FormShortDate(Module1.Datum.Seg1), font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x3 + (float)(200.0 * num3), y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Short Program", font3, Brushes.Black, layoutRectangle, format);
                    float y4 = y3 + (height3 + 10f);
                    float x4 = (float)x1;
                    layoutRectangle = new RectangleF(x4, y4, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Size of Skating Area:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x4 + (float)(200.0 * num3), y4, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("30m*60m", font3, Brushes.Black, layoutRectangle, format);
                    float y5 = y4 + height3;
                    float x5 = (float)x1;
                    layoutRectangle = new RectangleF(x5, y5, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Ice Condition:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x5 + (float)(200.0 * num3), y5, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Very Good", font3, Brushes.Black, layoutRectangle, format);
                    float y6 = y5 + height3;
                    float x6 = (float)x1;
                    layoutRectangle = new RectangleF(x6, y6, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Number of Participants", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x6 + (float)(200.0 * num3), y6, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.TNop), font3, Brushes.Black, layoutRectangle, format);
                    float y7 = y6 + (height3 + 10f);
                    layoutRectangle = new RectangleF((float)x1, y7, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("SHORT PROGRAM", font2, Brushes.Black, layoutRectangle, format);
                    float y8 = y7 + height3;
                    float x7 = (float)x1;
                    layoutRectangle = new RectangleF(x7, y8, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Duration:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x7 + (float)(200.0 * num3), y8, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.OpenDB[Module1.PcIndex].Seg1Time, font3, Brushes.Black, layoutRectangle, format);
                    float y9 = y8 + height3;
                    float x8 = (float)x1;
                    layoutRectangle = new RectangleF(x8, y9, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Program Component Factors:", font3, Brushes.Black, layoutRectangle, format);
                    float x9 = x8 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x9, y9, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Impostazione di base", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x9 + (float)(200.0 * num3), y9, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[1]), font3, Brushes.Black, layoutRectangle, format);
                    float y10 = y9 + height3;
                    float x10 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x10, y10, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Scorrevolezza", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x10 + (float)(200.0 * num3), y10, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[2]), font3, Brushes.Black, layoutRectangle, format);
                    float y11 = y10 + height3 + height3;
                    float x11 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x11, y11, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Coreografia", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x11 + (float)(200.0 * num3), y11, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[4]), font3, Brushes.Black, layoutRectangle, format);
                    y3 = y11 + height3;
                }
                if (Operators.CompareString(Module1.GetSeg(), "F0", false) == 0)
                {
                    layoutRectangle = new RectangleF(x2, y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("DATE:", font2, Brushes.Black, layoutRectangle, format);
                    float x12 = x2 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x12, y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.FormShortDate(Module1.Datum.Seg1), font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x12 + (float)(200.0 * num3), y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Fres skating", font3, Brushes.Black, layoutRectangle, format);
                    float y12 = y3 + (height3 + 10f);
                    float x13 = (float)x1;
                    layoutRectangle = new RectangleF(x13, y12, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Size of Skating Area:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x13 + (float)(200.0 * num3), y12, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("30m*60m", font3, Brushes.Black, layoutRectangle, format);
                    float y13 = y12 + height3;
                    float x14 = (float)x1;
                    layoutRectangle = new RectangleF(x14, y13, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Ice Condition:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x14 + (float)(200.0 * num3), y13, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Very Good", font3, Brushes.Black, layoutRectangle, format);
                    float y14 = y13 + height3;
                    float x15 = (float)x1;
                    layoutRectangle = new RectangleF(x15, y14, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Number of Participants", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x15 + (float)(200.0 * num3), y14, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.TNop), font3, Brushes.Black, layoutRectangle, format);
                    float y15 = y14 + (height3 + 10f);
                    layoutRectangle = new RectangleF((float)x1, y15, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("FREE SKATING", font2, Brushes.Black, layoutRectangle, format);
                    float y16 = y15 + height3;
                    float x16 = (float)x1;
                    layoutRectangle = new RectangleF(x16, y16, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Duration:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x16 + (float)(200.0 * num3), y16, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.OpenDB[Module1.PcIndex].Seg1Time, font3, Brushes.Black, layoutRectangle, format);
                    float y17 = y16 + height3;
                    float x17 = (float)x1;
                    layoutRectangle = new RectangleF(x17, y17, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Program Component Factors:", font3, Brushes.Black, layoutRectangle, format);
                    float x18 = x17 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x18, y17, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Impostazione di base", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x18 + (float)(200.0 * num3), y17, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[1]), font3, Brushes.Black, layoutRectangle, format);
                    float y18 = y17 + height3;
                    float x19 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x19, y18, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Scorrevolezza", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x19 + (float)(200.0 * num3), y18, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[2]), font3, Brushes.Black, layoutRectangle, format);
                    float y19 = y18 + height3 + height3;
                    float x20 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x20, y19, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Coreografia", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x20 + (float)(200.0 * num3), y19, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[4]), font3, Brushes.Black, layoutRectangle, format);
                    y3 = y19 + height3;
                    x2 = (float)(x1 + 200.0 * num3) + (float)(200.0 * num3);
                }
                if (Operators.CompareString(Module1.GetSeg(), "0F", false) == 0)
                {
                    layoutRectangle = new RectangleF(x2, y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("DATE:", font2, Brushes.Black, layoutRectangle, format);
                    float x21 = x2 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x21, y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.FormShortDate(Module1.Datum.Seg2), font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x21 + (float)(200.0 * num3), y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Free skating", font3, Brushes.Black, layoutRectangle, format);
                    float y20 = y3 + (height3 + 10f);
                    float x22 = (float)x1;
                    layoutRectangle = new RectangleF(x22, y20, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Size of Skating Area:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x22 + (float)(200.0 * num3), y20, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("30m*60m", font3, Brushes.Black, layoutRectangle, format);
                    float y21 = y20 + height3;
                    float x23 = (float)x1;
                    layoutRectangle = new RectangleF(x23, y21, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Ice Condition:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x23 + (float)(200.0 * num3), y21, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Very Good", font3, Brushes.Black, layoutRectangle, format);
                    float y22 = y21 + height3;
                    float x24 = (float)x1;
                    layoutRectangle = new RectangleF(x24, y22, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Number of Participants", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x24 + (float)(200.0 * num3), y22, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.TNop), font3, Brushes.Black, layoutRectangle, format);
                    float y23 = y22 + (height3 + 10f);
                    layoutRectangle = new RectangleF((float)x1, y23, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("FREE SKATING", font2, Brushes.Black, layoutRectangle, format);
                    float y24 = y23 + height3;
                    float x25 = (float)x1;
                    layoutRectangle = new RectangleF(x25, y24, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Duration:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x25 + (float)(200.0 * num3), y24, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.OpenDB[Module1.PcIndex].Seg2Time, font3, Brushes.Black, layoutRectangle, format);
                    float y25 = y24 + height3;
                    float x26 = (float)x1;
                    layoutRectangle = new RectangleF(x26, y25, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Program Component Factors:", font3, Brushes.Black, layoutRectangle, format);
                    float x27 = x26 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x27, y25, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Impostazione di base", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x27 + (float)(200.0 * num3), y25, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[1]), font3, Brushes.Black, layoutRectangle, format);
                    float y26 = y25 + height3;
                    float x28 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x28, y26, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Scorrevolezza", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x28 + (float)(200.0 * num3), y26, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[2]), font3, Brushes.Black, layoutRectangle, format);
                    float y27 = y26 + height3 + height3;
                    float x29 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x29, y27, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Coreografia", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x29 + (float)(200.0 * num3), y27, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[4]), font3, Brushes.Black, layoutRectangle, format);
                    y3 = y27 + height3;
                }
                if (Operators.CompareString(Module1.GetSeg(), "SF", false) == 0)
                {
                    layoutRectangle = new RectangleF(x2, y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("DATE:", font2, Brushes.Black, layoutRectangle, format);
                    float x30 = x2 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x30, y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.FormShortDate(Module1.Datum.Seg1), font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x30 + (float)(200.0 * num3), y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Short Program", font3, Brushes.Black, layoutRectangle, format);
                    float y28 = y3 + height3;
                    float x31 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x31, y28, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.FormShortDate(Module1.Datum.Seg2), font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x31 + (float)(200.0 * num3), y28, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Free Skating", font3, Brushes.Black, layoutRectangle, format);
                    float y29 = y28 + (height3 + 10f);
                    float x32 = (float)x1;
                    layoutRectangle = new RectangleF(x32, y29, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Size of Skating Area:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x32 + (float)(200.0 * num3), y29, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("30m*60m", font3, Brushes.Black, layoutRectangle, format);
                    float y30 = y29 + height3;
                    float x33 = (float)x1;
                    layoutRectangle = new RectangleF(x33, y30, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Ice Condition:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x33 + (float)(200.0 * num3), y30, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Very Good", font3, Brushes.Black, layoutRectangle, format);
                    float y31 = y30 + height3;
                    float x34 = (float)x1;
                    layoutRectangle = new RectangleF(x34, y31, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Number of Participants", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x34 + (float)(200.0 * num3), y31, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.TNop), font3, Brushes.Black, layoutRectangle, format);
                    float y32 = y31 + (height3 + 10f);
                    layoutRectangle = new RectangleF((float)x1, y32, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("SHORT PROGRAM", font2, Brushes.Black, layoutRectangle, format);
                    float y33 = y32 + height3;
                    float x35 = (float)x1;
                    layoutRectangle = new RectangleF(x35, y33, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Duration:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x35 + (float)(200.0 * num3), y33, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.OpenDB[Module1.PcIndex].Seg1Time, font3, Brushes.Black, layoutRectangle, format);
                    float y34 = y33 + height3;
                    float x36 = (float)x1;
                    layoutRectangle = new RectangleF(x36, y34, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Program Component Factors:", font3, Brushes.Black, layoutRectangle, format);
                    float x37 = x36 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x37, y34, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Impostazione di base", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x37 + (float)(200.0 * num3), y34, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[1]), font3, Brushes.Black, layoutRectangle, format);
                    float y35 = y34 + height3;
                    float x38 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x38, y35, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Scorrevolezza", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x38 + (float)(200.0 * num3), y35, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[2]), font3, Brushes.Black, layoutRectangle, format);
                    float y36 = y35 + height3 + height3;
                    float x39 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x39, y36, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Coreografia", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x39 + (float)(200.0 * num3), y36, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[4]), font3, Brushes.Black, layoutRectangle, format);
                    float y37 = (float)((double)y36 + (double)height3 + ((double)height3 + 10.0));
                    layoutRectangle = new RectangleF((float)x1, y37, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("FREE SKATING", font2, Brushes.Black, layoutRectangle, format);
                    float y38 = y37 + height3;
                    float x40 = (float)x1;
                    layoutRectangle = new RectangleF(x40, y38, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Duration:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x40 + (float)(200.0 * num3), y38, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.OpenDB[Module1.PcIndex].Seg2Time, font3, Brushes.Black, layoutRectangle, format);
                    float y39 = y38 + height3;
                    float x41 = (float)x1;
                    layoutRectangle = new RectangleF(x41, y39, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Program Component Factors:", font3, Brushes.Black, layoutRectangle, format);
                    float x42 = x41 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x42, y39, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Impostazione di base", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x42 + (float)(200.0 * num3), y39, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[1]), font3, Brushes.Black, layoutRectangle, format);
                    float y40 = y39 + height3;
                    float x43 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x43, y40, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Scorrevolezza", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x43 + (float)(200.0 * num3), y40, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[2]), font3, Brushes.Black, layoutRectangle, format);
                    float y41 = y40 + height3 + height3;
                    float x44 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x44, y41, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Coreografia", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x44 + (float)(200.0 * num3), y41, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[4]), font3, Brushes.Black, layoutRectangle, format);
                    y3 = y41 + height3;
                }
                if (Operators.CompareString(Module1.GetSeg(), "FF", false) == 0)
                {
                    layoutRectangle = new RectangleF(x2, y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("DATE:", font2, Brushes.Black, layoutRectangle, format);
                    float x45 = x2 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x45, y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.FormShortDate(Module1.Datum.Seg1), font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x45 + (float)(200.0 * num3), y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Free Skating", font3, Brushes.Black, layoutRectangle, format);
                    float y42 = y3 + height3;
                    float x46 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x46, y42, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.FormShortDate(Module1.Datum.Seg2), font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x46 + (float)(200.0 * num3), y42, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Free Skating", font3, Brushes.Black, layoutRectangle, format);
                    float y43 = y42 + (height3 + 10f);
                    float x47 = (float)x1;
                    layoutRectangle = new RectangleF(x47, y43, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Size of Skating Area:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x47 + (float)(200.0 * num3), y43, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("30m*60m", font3, Brushes.Black, layoutRectangle, format);
                    float y44 = y43 + height3;
                    float x48 = (float)x1;
                    layoutRectangle = new RectangleF(x48, y44, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Ice Condition:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x48 + (float)(200.0 * num3), y44, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Very Good", font3, Brushes.Black, layoutRectangle, format);
                    float y45 = y44 + height3;
                    float x49 = (float)x1;
                    layoutRectangle = new RectangleF(x49, y45, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Number of Participants", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x49 + (float)(200.0 * num3), y45, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.TNop), font3, Brushes.Black, layoutRectangle, format);
                    float y46 = y45 + (height3 + 10f);
                    layoutRectangle = new RectangleF((float)x1, y46, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("FREE SKATING", font2, Brushes.Black, layoutRectangle, format);
                    float y47 = y46 + height3;
                    float x50 = (float)x1;
                    layoutRectangle = new RectangleF(x50, y47, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Duration:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x50 + (float)(200.0 * num3), y47, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.OpenDB[Module1.PcIndex].Seg1Time, font3, Brushes.Black, layoutRectangle, format);
                    float y48 = y47 + height3;
                    float x51 = (float)x1;
                    layoutRectangle = new RectangleF(x51, y48, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Program Component Factors:", font3, Brushes.Black, layoutRectangle, format);
                    float x52 = x51 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x52, y48, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Impostazione di base", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x52 + (float)(200.0 * num3), y48, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[1]), font3, Brushes.Black, layoutRectangle, format);
                    float y49 = y48 + height3;
                    float x53 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x53, y49, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Scorrevolezza", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x53 + (float)(200.0 * num3), y49, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[2]), font3, Brushes.Black, layoutRectangle, format);
                    float y50 = y49 + height3 + height3;
                    float x54 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x54, y50, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Coreografia", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x54 + (float)(200.0 * num3), y50, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[4]), font3, Brushes.Black, layoutRectangle, format);
                    float y51 = (float)((double)y50 + (double)height3 + ((double)height3 + 10.0));
                    layoutRectangle = new RectangleF((float)x1, y51, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("FREE SKATING", font2, Brushes.Black, layoutRectangle, format);
                    float y52 = y51 + height3;
                    float x55 = (float)x1;
                    layoutRectangle = new RectangleF(x55, y52, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Duration:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x55 + (float)(200.0 * num3), y52, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.OpenDB[Module1.PcIndex].Seg2Time, font3, Brushes.Black, layoutRectangle, format);
                    float y53 = y52 + height3;
                    float x56 = (float)x1;
                    layoutRectangle = new RectangleF(x56, y53, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Program Component Factors:", font3, Brushes.Black, layoutRectangle, format);
                    float x57 = x56 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x57, y53, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Impostazione di base", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x57 + (float)(200.0 * num3), y53, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[1]), font3, Brushes.Black, layoutRectangle, format);
                    float y54 = y53 + height3;
                    float x58 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x58, y54, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Scorrevolezza", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x58 + (float)(200.0 * num3), y54, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[2]), font3, Brushes.Black, layoutRectangle, format);
                    float y55 = y54 + height3 + height3;
                    float x59 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x59, y55, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Coreografia", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x59 + (float)(200.0 * num3), y55, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[4]), font3, Brushes.Black, layoutRectangle, format);
                    y3 = y55 + height3;
                }
                if (Operators.CompareString(Module1.GetSeg(), "SS", false) == 0)
                {
                    layoutRectangle = new RectangleF(x2, y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("DATE:", font2, Brushes.Black, layoutRectangle, format);
                    float x60 = x2 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x60, y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.FormShortDate(Module1.Datum.Seg1), font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x60 + (float)(200.0 * num3), y3, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Short Program", font3, Brushes.Black, layoutRectangle, format);
                    float y56 = y3 + height3;
                    float x61 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x61, y56, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.FormShortDate(Module1.Datum.Seg2), font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x61 + (float)(200.0 * num3), y56, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Short Program", font3, Brushes.Black, layoutRectangle, format);
                    float y57 = y56 + (height3 + 10f);
                    float x62 = (float)x1;
                    layoutRectangle = new RectangleF(x62, y57, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Size of Skating Area:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x62 + (float)(200.0 * num3), y57, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("30m*60m", font3, Brushes.Black, layoutRectangle, format);
                    float y58 = y57 + height3;
                    float x63 = (float)x1;
                    layoutRectangle = new RectangleF(x63, y58, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Ice Condition:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x63 + (float)(200.0 * num3), y58, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Very Good", font3, Brushes.Black, layoutRectangle, format);
                    float y59 = y58 + height3;
                    float x64 = (float)x1;
                    layoutRectangle = new RectangleF(x64, y59, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Number of Participants", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x64 + (float)(200.0 * num3), y59, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.TNop), font3, Brushes.Black, layoutRectangle, format);
                    float y60 = y59 + (height3 + 10f);
                    layoutRectangle = new RectangleF((float)x1, y60, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("SHORT PROGRAM", font2, Brushes.Black, layoutRectangle, format);
                    float y61 = y60 + height3;
                    float x65 = (float)x1;
                    layoutRectangle = new RectangleF(x65, y61, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Duration:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x65 + (float)(200.0 * num3), y61, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.OpenDB[Module1.PcIndex].Seg1Time, font3, Brushes.Black, layoutRectangle, format);
                    float y62 = y61 + height3;
                    float x66 = (float)x1;
                    layoutRectangle = new RectangleF(x66, y62, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Program Component Factors:", font3, Brushes.Black, layoutRectangle, format);
                    float x67 = x66 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x67, y62, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Impostazione di base", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x67 + (float)(200.0 * num3), y62, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[1]), font3, Brushes.Black, layoutRectangle, format);
                    float y63 = y62 + height3;
                    float x68 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x68, y63, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Scorrevolezza", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x68 + (float)(200.0 * num3), y63, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[2]), font3, Brushes.Black, layoutRectangle, format);
                    float y64 = y63 + height3 + height3;
                    float x69 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x69, y64, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Coreografia", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x69 + (float)(200.0 * num3), y64, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[4]), font3, Brushes.Black, layoutRectangle, format);
                    float y65 = (float)((double)y64 + (double)height3 + ((double)height3 + 10.0));
                    layoutRectangle = new RectangleF((float)x1, y65, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("SHORT PROGRAM", font2, Brushes.Black, layoutRectangle, format);
                    float y66 = y65 + height3;
                    float x70 = (float)x1;
                    layoutRectangle = new RectangleF(x70, y66, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Duration:", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x70 + (float)(200.0 * num3), y66, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.OpenDB[Module1.PcIndex].Seg2Time, font3, Brushes.Black, layoutRectangle, format);
                    float y67 = y66 + height3;
                    float x71 = (float)x1;
                    layoutRectangle = new RectangleF(x71, y67, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Program Component Factors:", font3, Brushes.Black, layoutRectangle, format);
                    float x72 = x71 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x72, y67, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Impostazione di base", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x72 + (float)(200.0 * num3), y67, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[1]), font3, Brushes.Black, layoutRectangle, format);
                    float y68 = y67 + height3;
                    float x73 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x73, y68, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Scorrevolezza", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x73 + (float)(200.0 * num3), y68, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[2]), font3, Brushes.Black, layoutRectangle, format);
                    float y69 = y68 + height3 + height3;
                    float x74 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x74, y69, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Coreografia", font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x74 + (float)(200.0 * num3), y69, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[4]), font3, Brushes.Black, layoutRectangle, format);
                    y3 = y69 + height3;
                }
                float y70 = y3 + (height3 + (float)checked((int)Math.Round(unchecked(40.0 * num3))));
                layoutRectangle = new RectangleF((float)x1, y70, (float)(200.0 * num3), height3);
                e.Graphics.DrawString("OFFICIALS", font2, Brushes.Black, layoutRectangle, format);
                float y71 = y70 + height3;
                float x75 = (float)x1;
                layoutRectangle = new RectangleF(x75, y71, (float)(200.0 * num3), height3);
                e.Graphics.DrawString("Technical Controller", font3, Brushes.Black, layoutRectangle, format);
                float x76 = x75 + (float)(200.0 * num3);
                layoutRectangle = new RectangleF(x76, y71, (float)(200.0 * num3), height3);
                string segment1 = Module1.Segment;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    e.Graphics.DrawString(Module1.Controller.Seg1.Name, font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x76 + (float)(200.0 * num3), y71, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.Controller.Seg1.Club, font3, Brushes.Black, layoutRectangle, format);
                    y71 += height3;
                    layoutRectangle = new RectangleF((float)x1, y71, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Technical Specialist", font3, Brushes.Black, layoutRectangle, format);
                    float x77 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x77, y71, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.Techspec.Seg1.Name, font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x77 + (float)(200.0 * num3), y71, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.Techspec.Seg1.Club, font3, Brushes.Black, layoutRectangle, format);
                }
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                {
                    e.Graphics.DrawString(Module1.Controller.Seg2.Name, font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x76 + (float)(200.0 * num3), y71, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.Controller.Seg2.Club, font3, Brushes.Black, layoutRectangle, format);
                    y71 += height3;
                    layoutRectangle = new RectangleF((float)x1, y71, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Technical Specialist", font3, Brushes.Black, layoutRectangle, format);
                    float x78 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x78, y71, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.Techspec.Seg2.Name, font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x78 + (float)(200.0 * num3), y71, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.Techspec.Seg2.Club, font3, Brushes.Black, layoutRectangle, format);
                }
                float y72 = y71 + height3;
                layoutRectangle = new RectangleF((float)x1, y72, (float)(200.0 * num3), height3);
                e.Graphics.DrawString("Referee", font3, Brushes.Black, layoutRectangle, format);
                float x79 = (float)(x1 + 200.0 * num3);
                layoutRectangle = new RectangleF(x79, y72, (float)(200.0 * num3), height3);
                string segment2 = Module1.Segment;
                if (Operators.CompareString(segment2, "Seg1", false) == 0)
                {
                    e.Graphics.DrawString(Module1.Referee.Seg1.Name, font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x79 + (float)(200.0 * num3), y72, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.Referee.Seg1.Club, font3, Brushes.Black, layoutRectangle, format);
                }
                else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                {
                    e.Graphics.DrawString(Module1.Referee.Seg2.Name, font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x79 + (float)(200.0 * num3), y72, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString(Module1.Referee.Seg2.Club, font3, Brushes.Black, layoutRectangle, format);
                }
                float x80 = (float)x1;
                float y73 = y72 + (height3 + 10f);
                layoutRectangle = new RectangleF(x80, y73, (float)(200.0 * num3), height3);
                e.Graphics.DrawString("JUDGES", font2, Brushes.Black, layoutRectangle, format);
                float y74 = y73 + height3;
                int noJGoe = Module1.NoJ_GOE;
                int index1 = 1;
                while (index1 <= noJGoe)
                {
                    layoutRectangle = new RectangleF((float)x1, y74, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Judge " + Conversions.ToString(index1), font3, Brushes.Black, layoutRectangle, format);
                    float x81 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x81, y74, (float)(200.0 * num3), height3);
                    string segment3 = Module1.Segment;
                    if (Operators.CompareString(segment3, "Seg1", false) == 0)
                        e.Graphics.DrawString(Module1.Judge[index1].Seg1.Name, font3, Brushes.Black, layoutRectangle, format);
                    else if (Operators.CompareString(segment3, "Seg2", false) == 0)
                        e.Graphics.DrawString(Module1.Judge[index1].Seg2.Name, font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x81 + (float)(200.0 * num3), y74, (float)(200.0 * num3), height3);
                    string segment4 = Module1.Segment;
                    if (Operators.CompareString(segment4, "Seg1", false) == 0)
                        e.Graphics.DrawString(Module1.Judge[index1].Seg1.Club, font3, Brushes.Black, layoutRectangle, format);
                    else if (Operators.CompareString(segment4, "Seg2", false) == 0)
                        e.Graphics.DrawString(Module1.Judge[index1].Seg2.Club, font3, Brushes.Black, layoutRectangle, format);
                    y74 += height3;
                    checked { ++index1; }
                }
                if (Module1.NoTrj > 0)
                {
                    int num6 = checked(Module1.NoJ_GOE + 1);
                    int num7 = checked(Module1.NoJ_GOE + Module1.NoTrj);
                    int index2 = num6;
                    while (index2 <= num7)
                    {
                        layoutRectangle = new RectangleF((float)x1, y74, (float)(200.0 * num3), height3);
                        e.Graphics.DrawString("Tr. Judge " + Conversions.ToString(index2), font3, Brushes.Black, layoutRectangle, format);
                        float x82 = (float)(x1 + 200.0 * num3);
                        layoutRectangle = new RectangleF(x82, y74, (float)(200.0 * num3), height3);
                        string segment5 = Module1.Segment;
                        if (Operators.CompareString(segment5, "Seg1", false) == 0)
                            e.Graphics.DrawString(Module1.Judge[index2].Seg1.Name, font3, Brushes.Black, layoutRectangle, format);
                        else if (Operators.CompareString(segment5, "Seg2", false) == 0)
                            e.Graphics.DrawString(Module1.Judge[index2].Seg2.Name, font3, Brushes.Black, layoutRectangle, format);
                        layoutRectangle = new RectangleF(x82 + (float)(200.0 * num3), y74, (float)(200.0 * num3), height3);
                        string segment6 = Module1.Segment;
                        if (Operators.CompareString(segment6, "Seg1", false) == 0)
                            e.Graphics.DrawString(Module1.Judge[index2].Seg1.Club, font3, Brushes.Black, layoutRectangle, format);
                        else if (Operators.CompareString(segment6, "Seg2", false) == 0)
                            e.Graphics.DrawString(Module1.Judge[index2].Seg2.Club, font3, Brushes.Black, layoutRectangle, format);
                        y74 += height3;
                        checked { ++index2; }
                    }
                }
                if (Module1.JudgeSel == 1)
                {
                    layoutRectangle = new RectangleF((float)x1, y74, (float)(200.0 * num3), height3);
                    e.Graphics.DrawString("Judge " + Conversions.ToString(7), font3, Brushes.Black, layoutRectangle, format);
                    float x83 = (float)(x1 + 200.0 * num3);
                    layoutRectangle = new RectangleF(x83, y74, (float)(200.0 * num3), height3);
                    string segment7 = Module1.Segment;
                    if (Operators.CompareString(segment7, "Seg1", false) == 0)
                        e.Graphics.DrawString(Module1.Judge[7].Seg1.Name, font3, Brushes.Black, layoutRectangle, format);
                    else if (Operators.CompareString(segment7, "Seg2", false) == 0)
                        e.Graphics.DrawString(Module1.Judge[7].Seg2.Name, font3, Brushes.Black, layoutRectangle, format);
                    layoutRectangle = new RectangleF(x83 + (float)(200.0 * num3), y74, (float)(200.0 * num3), height3);
                    string segment8 = Module1.Segment;
                    if (Operators.CompareString(segment8, "Seg1", false) == 0)
                        e.Graphics.DrawString(Module1.Judge[7].Seg1.Club, font3, Brushes.Black, layoutRectangle, format);
                    else if (Operators.CompareString(segment8, "Seg2", false) == 0)
                        e.Graphics.DrawString(Module1.Judge[7].Seg2.Club, font3, Brushes.Black, layoutRectangle, format);
                    y74 += height3;
                }
                float x84 = (float)x1;
                float y75 = y74 + 10f;
                layoutRectangle = new RectangleF(x84, y75, (float)(200.0 * num3), height3);
                e.Graphics.DrawString("OPERATORS", font2, Brushes.Black, layoutRectangle, format);
                float y76 = y75 + height3;
                int index3 = 1;
                do
                {
                    float x85 = (float)x1;
                    layoutRectangle = new RectangleF(x85, y76, (float)(200.0 * num3), height3);
                    if (index3 < 3)
                        e.Graphics.DrawString("DVO", font3, Brushes.Black, layoutRectangle, format);
                    else
                        e.Graphics.DrawString("Technical support", font3, Brushes.Black, layoutRectangle, format);
                    float x86 = x85 + (float)(200.0 * num3);
                    layoutRectangle = new RectangleF(x86, y76, (float)(200.0 * num3), height3);
                    string segment9 = Module1.Segment;
                    if (Operators.CompareString(segment9, "Seg1", false) == 0)
                    {
                        e.Graphics.DrawString(Module1.DVO[index3].Seg1.Name, font3, Brushes.Black, layoutRectangle, format);
                        layoutRectangle = new RectangleF(x86 + (float)(200.0 * num3), y76, (float)(200.0 * num3), height3);
                        e.Graphics.DrawString(Module1.DVO[index3].Seg1.Club, font3, Brushes.Black, layoutRectangle, format);
                    }
                    else if (Operators.CompareString(segment9, "Seg2", false) == 0)
                    {
                        e.Graphics.DrawString(Module1.DVO[index3].Seg2.Name, font3, Brushes.Black, layoutRectangle, format);
                        layoutRectangle = new RectangleF(x86 + (float)(200.0 * num3), y76, (float)(200.0 * num3), height3);
                        e.Graphics.DrawString(Module1.DVO[index3].Seg2.Club, font3, Brushes.Black, layoutRectangle, format);
                    }
                    y76 += height3;
                    checked { ++index3; }
                }
                while (index3 <= 3);
                float y77 = y76 + (float)checked((int)Math.Round(unchecked(40.0 * num3)));
                float num8 = (float)x1;
                e.Graphics.DrawString(Module1.OpenDBver, font4, Brushes.Black, (float)x1, y77, new StringFormat());
                layoutRectangle = new RectangleF(num8 + (float)(200.0 * num3), y77, (float)(400.0 * num3), height3);
                e.Graphics.DrawString("Created: " + Module1.DateTimeToStr(Module1.OpenDBLastWriteTime), font4, Brushes.Black, layoutRectangle, format);
                float y78 = y77 + layoutRectangle.Height;
                float num9 = (float)x1;
                e.Graphics.DrawString(Module1.ElementDBver, font4, Brushes.Black, (float)x1, y78, new StringFormat());
                layoutRectangle = new RectangleF(num9 + (float)(200.0 * num3), y78, (float)(400.0 * num3), height3);
                e.Graphics.DrawString("Created: " + Module1.DateTimeToStr(Module1.ElementDBLastWriteTime), font4, Brushes.Black, layoutRectangle, format);
                float y79 = y78 + layoutRectangle.Height;
                float num10 = (float)x1;
                e.Graphics.DrawString("Figure Skating Italia ", font4, Brushes.Black, (float)x1, y79, new StringFormat());
                layoutRectangle = new RectangleF(num10 + (float)(200.0 * num3), y79, (float)(400.0 * num3), height3);
                e.Graphics.DrawString("Created: " + Module1.DateTimeToStr(DateTime.Now), font4, Brushes.Black, layoutRectangle, format);
                goto label_69;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num11 = (int)Interaction.MsgBox((object)("Dialog8, PrintDocument1_PrintPage_1 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_69:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void PRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PrintPreviewDialog1.TopMost = true;
            this.PrintPreviewDialog1.Document = this.PrintDocument1;
            int num = (int)this.PrintPreviewDialog1.ShowDialog();
        }

        private void txtArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '"':
                case '&':
                case '\'':
                case ':':
                case ';':
                case '<':
                case '>':
                    e.Handled = true;
                    break;
            }
        }

        private void txtIceCondition_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '"':
                case '&':
                case '\'':
                case ':':
                case ';':
                case '<':
                case '>':
                    e.Handled = true;
                    break;
            }
        }

        private void ExportHeadPageToPDF(int norow, int nocol, string txt, string pathfile, int msg)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int x1 = 70;
                int num3 = 20;
                ProjectData.ClearProjectError();
                num1 = 2;
                PdfDocument pdfDocument = new PdfDocument();
                pdfDocument.Info.Title = "Head page";
                pdfDocument.Info.Subject = "Head page and Officials";
                pdfDocument.Info.Author = "ClubCompFS Single ver. 10.0.6, 2019-01-12";
                PdfPage page = pdfDocument.AddPage();
                page.Size = PageSize.A4;
                XUnit xunit = page.Width;
                int width1 = checked((int)Math.Round(unchecked(xunit.Point - (double)x1 - (double)num3)));
                float[] numArray = new float[3] { 33f, 33f, 33f };
                xunit = page.Height;
                int num4 = checked((int)Math.Round(xunit.Point));
                int num5 = 90; //60
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
                
                int x2 = checked((int)Math.Round(unchecked((double)x1 + (double)numArray[0] * (double)width1 / 100.0)));
                int y1 = num5;
                int height1 = checked((int)Math.Round(font1.GetHeight()));
                xgraphics1.DrawString("HEAD PAGE", font1, (XBrush)XBrushes.Black, new XRect((double)x1, (double)y1, (double)width1, (double)height1), XStringFormats.TopLeft);
                int y2 = checked(y1 + height1);
                int height2 = checked((int)Math.Round(font2.GetHeight()));
                xgraphics1.DrawString("COMPETITION:", font2, (XBrush)XBrushes.Black, new XRect((double)x1, (double)y2, (double)width1, (double)height2), XStringFormats.TopLeft);
                XGraphics xgraphics2 = xgraphics1;
                string name = Module1.Competition.Name;
                XFont xfont3 = xfont1;
                XSolidBrush black1 = XBrushes.Black;
                XRect xrect1 = new XRect((double)x2, (double)y2, (double)width1, (double)height2);
                XStringFormat topLeft1 = XStringFormats.TopLeft;
                string text1 = name;
                XFont font3 = xfont3;
                XSolidBrush brush1 = black1;
                XRect layoutRectangle1 = xrect1;
                XStringFormat format1 = topLeft1;
                xgraphics2.DrawString(text1, font3, (XBrush)brush1, layoutRectangle1, format1);
                int y3 = checked(y2 + height2);
                XGraphics xgraphics3 = xgraphics1;
                XFont xfont4 = font2;
                XSolidBrush black2 = XBrushes.Black;
                XRect xrect2 = new XRect((double)x1, (double)y3, (double)width1, (double)height2);
                XStringFormat topLeft2 = XStringFormats.TopLeft;
                XFont font4 = xfont4;
                XSolidBrush brush2 = black2;
                XRect layoutRectangle2 = xrect2;
                XStringFormat format2 = topLeft2;
                xgraphics3.DrawString("CATEGORY:", font4, (XBrush)brush2, layoutRectangle2, format2);
                XGraphics xgraphics4 = xgraphics1;
                string str1 = Module1.Category.Name + Module1.SubCat();
                XFont xfont5 = xfont1;
                XSolidBrush black3 = XBrushes.Black;
                XRect xrect3 = new XRect((double)x2, (double)y3, (double)width1, (double)height2);
                XStringFormat topLeft3 = XStringFormats.TopLeft;
                string text2 = str1;
                XFont font5 = xfont5;
                XSolidBrush brush3 = black3;
                XRect layoutRectangle3 = xrect3;
                XStringFormat format3 = topLeft3;
                xgraphics4.DrawString(text2, font5, (XBrush)brush3, layoutRectangle3, format3);
                int num6 = checked(y3 + 2 * height2);
                int num7 = norow;
                int index1 = 0;
                while (index1 <= num7)
                {
                    int x3 = x1;
                    int y4 = checked(num6 + 1);
                    int num8 = checked(nocol - 1);
                    int index2 = 0;
                    while (index2 <= num8)
                    {
                        int width2 = checked((int)Math.Round(unchecked((double)numArray[index2] * (double)width1 / 100.0)));
                        if (Operators.CompareString(this.HDA[index1, index2], "DATE", false) == 0 | Operators.CompareString(this.HDA[index1, index2], "OFFICIALS", false) == 0 | Operators.CompareString(this.HDA[index1, index2], "JUDGES", false) == 0 | Operators.CompareString(this.HDA[index1, index2], "OPERATORS", false) == 0 | Operators.CompareString(this.HDA[index1, index2], "SHORT PROGRAM", false) == 0 | Operators.CompareString(this.HDA[index1, index2], "FREE SKATING", false) == 0)
                        {
                            switch (index2)
                            {
                                case 0:
                                    XGraphics xgraphics5 = xgraphics1;
                                    string str2 = this.HDA[index1, index2];
                                    XFont xfont6 = font2;
                                    XSolidBrush black4 = XBrushes.Black;
                                    XRect xrect4 = new XRect((double)x3, (double)y4, (double)width2, (double)height2);
                                    XStringFormat topLeft4 = XStringFormats.TopLeft;
                                    string text3 = str2;
                                    XFont font6 = xfont6;
                                    XSolidBrush brush4 = black4;
                                    XRect layoutRectangle4 = xrect4;
                                    XStringFormat format4 = topLeft4;
                                    xgraphics5.DrawString(text3, font6, (XBrush)brush4, layoutRectangle4, format4);
                                    break;
                                case 1:
                                    XGraphics xgraphics6 = xgraphics1;
                                    string str3 = this.HDA[index1, index2];
                                    XFont xfont7 = font2;
                                    XSolidBrush black5 = XBrushes.Black;
                                    XRect xrect5 = new XRect((double)x3, (double)y4, (double)width2, (double)height2);
                                    XStringFormat topLeft5 = XStringFormats.TopLeft;
                                    string text4 = str3;
                                    XFont font7 = xfont7;
                                    XSolidBrush brush5 = black5;
                                    XRect layoutRectangle5 = xrect5;
                                    XStringFormat format5 = topLeft5;
                                    xgraphics6.DrawString(text4, font7, (XBrush)brush5, layoutRectangle5, format5);
                                    break;
                                case 2:
                                    XGraphics xgraphics7 = xgraphics1;
                                    string str4 = this.HDA[index1, index2];
                                    XFont xfont8 = font2;
                                    XSolidBrush black6 = XBrushes.Black;
                                    XRect xrect6 = new XRect((double)x3, (double)y4, (double)width2, (double)height2);
                                    XStringFormat topLeft6 = XStringFormats.TopLeft;
                                    string text5 = str4;
                                    XFont font8 = xfont8;
                                    XSolidBrush brush6 = black6;
                                    XRect layoutRectangle6 = xrect6;
                                    XStringFormat format6 = topLeft6;
                                    xgraphics7.DrawString(text5, font8, (XBrush)brush6, layoutRectangle6, format6);
                                    break;
                            }
                        }
                        else if (Strings.Len(this.HDA[index1, index2]) > 0)
                        {
                            switch (index2)
                            {
                                case 0:
                                    XGraphics xgraphics8 = xgraphics1;
                                    string str5 = this.HDA[index1, index2];
                                    XFont xfont9 = xfont1;
                                    XSolidBrush black7 = XBrushes.Black;
                                    XRect xrect7 = new XRect((double)x3, (double)y4, (double)width2, (double)height2);
                                    XStringFormat topLeft7 = XStringFormats.TopLeft;
                                    string text6 = str5;
                                    XFont font9 = xfont9;
                                    XSolidBrush brush7 = black7;
                                    XRect layoutRectangle7 = xrect7;
                                    XStringFormat format7 = topLeft7;
                                    xgraphics8.DrawString(text6, font9, (XBrush)brush7, layoutRectangle7, format7);
                                    break;
                                case 1:
                                    XGraphics xgraphics9 = xgraphics1;
                                    string str6 = this.HDA[index1, index2];
                                    XFont xfont10 = xfont1;
                                    XSolidBrush black8 = XBrushes.Black;
                                    XRect xrect8 = new XRect((double)x3, (double)y4, (double)width2, (double)height2);
                                    XStringFormat topLeft8 = XStringFormats.TopLeft;
                                    string text7 = str6;
                                    XFont font10 = xfont10;
                                    XSolidBrush brush8 = black8;
                                    XRect layoutRectangle8 = xrect8;
                                    XStringFormat format8 = topLeft8;
                                    xgraphics9.DrawString(text7, font10, (XBrush)brush8, layoutRectangle8, format8);
                                    break;
                                case 2:
                                    XGraphics xgraphics10 = xgraphics1;
                                    string str7 = this.HDA[index1, index2];
                                    XFont xfont11 = xfont1;
                                    XSolidBrush black9 = XBrushes.Black;
                                    XRect xrect9 = new XRect((double)x3, (double)y4, (double)width2, (double)height2);
                                    XStringFormat topLeft9 = XStringFormats.TopLeft;
                                    string text8 = str7;
                                    XFont font11 = xfont11;
                                    XSolidBrush brush9 = black9;
                                    XRect layoutRectangle9 = xrect9;
                                    XStringFormat format9 = topLeft9;
                                    xgraphics10.DrawString(text8, font11, (XBrush)brush9, layoutRectangle9, format9);
                                    break;
                            }
                        }
                        checked { x3 += width2; }
                        checked { ++index2; }
                    }
                    num6 = checked(y4 + height2);
                    checked { ++index1; }
                }
                int y5 = checked(num6 + 2 * height2);
                XGraphics xgraphics11 = xgraphics1;
                string openDbver = Module1.OpenDBver;
                XFont xfont12 = xfont2;
                XSolidBrush black10 = XBrushes.Black;
                XRect xrect10 = new XRect((double)x1, (double)y5, (double)width1, (double)height2);
                XStringFormat topLeft10 = XStringFormats.TopLeft;
                string text9 = openDbver;
                XFont font12 = xfont12;
                XSolidBrush brush10 = black10;
                XRect layoutRectangle10 = xrect10;
                XStringFormat format10 = topLeft10;
                xgraphics11.DrawString(text9, font12, (XBrush)brush10, layoutRectangle10, format10);
                XGraphics xgraphics12 = xgraphics1;
                string str8 = "Created: " + Module1.DateTimeToStr(Module1.OpenDBLastWriteTime);
                XFont xfont13 = xfont2;
                XSolidBrush black11 = XBrushes.Black;
                XRect xrect11 = new XRect((double)x2, (double)y5, (double)width1, (double)height2);
                XStringFormat topLeft11 = XStringFormats.TopLeft;
                string text10 = str8;
                XFont font13 = xfont13;
                XSolidBrush brush11 = black11;
                XRect layoutRectangle11 = xrect11;
                XStringFormat format11 = topLeft11;
                xgraphics12.DrawString(text10, font13, (XBrush)brush11, layoutRectangle11, format11);
                int y6 = checked(y5 + height2);
                XGraphics xgraphics13 = xgraphics1;
                string elementDbver = Module1.ElementDBver;
                XFont xfont14 = xfont2;
                XSolidBrush black12 = XBrushes.Black;
                XRect xrect12 = new XRect((double)x1, (double)y6, (double)width1, (double)height2);
                XStringFormat topLeft12 = XStringFormats.TopLeft;
                string text11 = elementDbver;
                XFont font14 = xfont14;
                XSolidBrush brush12 = black12;
                XRect layoutRectangle12 = xrect12;
                XStringFormat format12 = topLeft12;
                xgraphics13.DrawString(text11, font14, (XBrush)brush12, layoutRectangle12, format12);
                XGraphics xgraphics14 = xgraphics1;
                string str9 = "Created: " + Module1.DateTimeToStr(Module1.ElementDBLastWriteTime);
                XFont xfont15 = xfont2;
                XSolidBrush black13 = XBrushes.Black;
                XRect xrect13 = new XRect((double)x2, (double)y6, (double)width1, (double)height2);
                XStringFormat topLeft13 = XStringFormats.TopLeft;
                string text12 = str9;
                XFont font15 = xfont15;
                XSolidBrush brush13 = black13;
                XRect layoutRectangle13 = xrect13;
                XStringFormat format13 = topLeft13;
                xgraphics14.DrawString(text12, font15, (XBrush)brush13, layoutRectangle13, format13);
                int y7 = checked(y6 + height2);
                XGraphics xgraphics15 = xgraphics1;
                XFont xfont16 = xfont2;
                XSolidBrush black14 = XBrushes.Black;
                XRect xrect14 = new XRect((double)x1, (double)y7, (double)width1, (double)height2);
                XStringFormat topLeft14 = XStringFormats.TopLeft;
                XFont font16 = xfont16;
                XSolidBrush brush14 = black14;
                XRect layoutRectangle14 = xrect14;
                XStringFormat format14 = topLeft14;
                xgraphics15.DrawString("Figure Skating Italia ", font16, (XBrush)brush14, layoutRectangle14, format14);
                XGraphics xgraphics16 = xgraphics1;
                string str10 = "Created: " + Module1.DateTimeToStr(DateTime.Now);
                XFont xfont17 = xfont2;
                XSolidBrush black15 = XBrushes.Black;
                XRect xrect15 = new XRect((double)x2, (double)y7, (double)width1, (double)height2);
                XStringFormat topLeft15 = XStringFormats.TopLeft;
                string text13 = str10;
                XFont font17 = xfont17;
                XSolidBrush brush15 = black15;
                XRect layoutRectangle15 = xrect15;
                XStringFormat format15 = topLeft15;
                xgraphics16.DrawString(text13, font17, (XBrush)brush15, layoutRectangle15, format15);
                pdfDocument.Save(pathfile);
                pdfDocument.Close();
                if (msg == 1)
                {
                    int num9 = (int)Interaction.MsgBox((object)("The file has been saved as:\r\n" + pathfile), MsgBoxStyle.Information, (object)"Susanne SW");
                    goto label_24;
                }
                else
                    goto label_24;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num10 = (int)Interaction.MsgBox((object)("Form6, ExportDataToPDFTable1 - \r\n" + Information.Err().Description), MsgBoxStyle.Critical, (object)"Susanne SW");
            }
            label_24:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void CreateHP_PDFfile(int msg)
        {
            string Path = "";
            this.HDA = new string[51, 4];
            string seg = Module1.GetSeg();
            int index1 = 0;
            if (Operators.CompareString(seg, "S0", false) == 0)
            {
                int index2 = 0;
                this.HDA[index2, 0] = "DATE";
                this.HDA[index2, 1] = Module1.FormShortDate(Module1.Datum.Seg1);
                this.HDA[index2, 2] = "Short Program";
                int index3 = checked(index2 + 1);
                int index4 = 0;
                do
                {
                    this.HDA[index3, index4] = " ";
                    checked { ++index4; }
                }
                while (index4 <= 2);
                int index5 = checked(index3 + 1);
                this.HDA[index5, 0] = "Size of Skating Area:";
                this.HDA[index5, 1] = "30m*60m";
                this.HDA[index5, 2] = "";
                int index6 = checked(index5 + 1);
                this.HDA[index6, 0] = "Ice Condition:";
                this.HDA[index6, 1] = "Very Good";
                this.HDA[index6, 2] = "";
                int index7 = checked(index6 + 1);
                this.HDA[index7, 0] = "Number of Participants";
                this.HDA[index7, 1] = Conversions.ToString(Module1.TNop);
                this.HDA[index7, 2] = "";
                int index8 = checked(index7 + 1);
                int index9 = 0;
                do
                {
                    this.HDA[index8, index9] = " ";
                    checked { ++index9; }
                }
                while (index9 <= 2);
                int index10 = checked(index8 + 1);
                this.HDA[index10, 0] = "SHORT PROGRAM";
                this.HDA[index10, 1] = "";
                this.HDA[index10, 2] = "";
                int index11 = checked(index10 + 1);
                this.HDA[index11, 0] = "Duration:";
                this.HDA[index11, 1] = Module1.OpenDB[Module1.PcIndex].Seg1Time;
                this.HDA[index11, 2] = "";
                int index12 = checked(index11 + 1);
                this.HDA[index12, 0] = "Program Component Factors:";
                this.HDA[index12, 1] = "Skating Skills";  // "Impostazione di base";
                this.HDA[index12, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[1]);
                int index13 = checked(index12 + 1);
                this.HDA[index13, 0] = "";
                this.HDA[index13, 1] = ""; // "Scorrevolezza";
                this.HDA[index13, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[2]);
                int index14 = checked(index13 + 1);
                this.HDA[index14, 0] = "";
                this.HDA[index14, 1] = "Performance/Execution";
                this.HDA[index14, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[3]);
                int index15 = checked(index14 + 1);
                this.HDA[index15, 0] = "";
                this.HDA[index15, 1] = ""; // "Coreografia";
                this.HDA[index15, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[4]);
                index1 = checked(index15 + 1);
                this.HDA[index1, 0] = "";
                this.HDA[index1, 1] = "";
                this.HDA[index1, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[5]);
            }
            else if (Operators.CompareString(seg, "0F", false) == 0)
            {
                int index16 = 0;
                this.HDA[index16, 0] = "DATE";
                this.HDA[index16, 1] = Module1.FormShortDate(Module1.Datum.Seg2);
                this.HDA[index16, 2] = "Free Skating";
                int index17 = checked(index16 + 1);
                int index18 = 0;
                do
                {
                    this.HDA[index17, index18] = " ";
                    checked { ++index18; }
                }
                while (index18 <= 2);
                int index19 = checked(index17 + 1);
                this.HDA[index19, 0] = "Size of Skating Area:";
                this.HDA[index19, 1] = "30m*60m";
                this.HDA[index19, 2] = "";
                int index20 = checked(index19 + 1);
                this.HDA[index20, 0] = "Ice Condition:";
                this.HDA[index20, 1] = "Very Good";
                this.HDA[index20, 2] = "";
                int index21 = checked(index20 + 1);
                this.HDA[index21, 0] = "Number of Participants";
                this.HDA[index21, 1] = Conversions.ToString(Module1.TNop);
                this.HDA[index21, 2] = "";
                int index22 = checked(index21 + 1);
                int index23 = 0;
                do
                {
                    this.HDA[index22, index23] = " ";
                    checked { ++index23; }
                }
                while (index23 <= 2);
                int index24 = checked(index22 + 1);
                this.HDA[index24, 0] = "FREE SKATING";
                this.HDA[index24, 1] = "";
                this.HDA[index24, 2] = "";
                int index25 = checked(index24 + 1);
                this.HDA[index25, 0] = "Duration:";
                this.HDA[index25, 1] = Module1.OpenDB[Module1.PcIndex].Seg2Time;
                this.HDA[index25, 2] = "";
                int index26 = checked(index25 + 1);
                this.HDA[index26, 0] = "Program Component Factors:";
                this.HDA[index26, 1] = "Skating Skills";  // "Impostazione di base";
                this.HDA[index26, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[1]);
                int index27 = checked(index26 + 1);
                this.HDA[index27, 0] = "";
                this.HDA[index27, 1] = ""; // "Scorrevolezza";
                this.HDA[index27, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[2]);
                int index28 = checked(index27 + 1);
                this.HDA[index28, 0] = "";
                this.HDA[index28, 1] = "Performance/Execution";
                this.HDA[index28, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[3]);
                int index29 = checked(index28 + 1);
                this.HDA[index29, 0] = "";
                this.HDA[index29, 1] = ""; //"Coreografia";
                this.HDA[index29, 2] = "";// Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[4]);
                index1 = checked(index29 + 1);
                this.HDA[index1, 0] = "";
                this.HDA[index1, 1] = "";
                this.HDA[index1, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[5]);
            }
            else if (Operators.CompareString(seg, "SF", false) == 0)
            {
                int index30 = 0;
                this.HDA[index30, 0] = "DATE";
                this.HDA[index30, 1] = Module1.FormShortDate(Module1.Datum.Seg1);
                this.HDA[index30, 2] = "Short Program";
                int index31 = checked(index30 + 1);
                this.HDA[index31, 0] = "";
                this.HDA[index31, 1] = Module1.FormShortDate(Module1.Datum.Seg2);
                this.HDA[index31, 2] = "Free Skating";
                int index32 = checked(index31 + 1);
                int index33 = 0;
                do
                {
                    this.HDA[index32, index33] = " ";
                    checked { ++index33; }
                }
                while (index33 <= 2);
                int index34 = checked(index32 + 1);
                this.HDA[index34, 0] = "Size of Skating Area:";
                this.HDA[index34, 1] = "30m*60m";
                this.HDA[index34, 2] = "";
                int index35 = checked(index34 + 1);
                this.HDA[index35, 0] = "Ice Condition:";
                this.HDA[index35, 1] = "Very Good";
                this.HDA[index35, 2] = "";
                int index36 = checked(index35 + 1);
                this.HDA[index36, 0] = "Number of Participants";
                this.HDA[index36, 1] = Conversions.ToString(Module1.TNop);
                this.HDA[index36, 2] = "";
                int index37 = checked(index36 + 1);
                int index38 = 0;
                do
                {
                    this.HDA[index37, index38] = " ";
                    checked { ++index38; }
                }
                while (index38 <= 2);
                int index39 = checked(index37 + 1);
                this.HDA[index39, 0] = "SHORT PROGRAM";
                this.HDA[index39, 1] = "";
                this.HDA[index39, 2] = "";
                int index40 = checked(index39 + 1);
                this.HDA[index40, 0] = "Duration:";
                this.HDA[index40, 1] = Module1.OpenDB[Module1.PcIndex].Seg1Time;
                this.HDA[index40, 2] = "";
                int index41 = checked(index40 + 1);
                this.HDA[index41, 0] = "Program Component Factors:";
                this.HDA[index41, 1] = "Skating Skills"; // "Impostazione di base";
                this.HDA[index41, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[1]);
                int index42 = checked(index41 + 1);
                this.HDA[index42, 0] = "";
                this.HDA[index42, 1] = ""; // "Scorrevolezza";
                this.HDA[index42, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[2]);
                int index43 = checked(index42 + 1);
                this.HDA[index43, 0] = "";
                this.HDA[index43, 1] = "Performance/Execution";
                this.HDA[index43, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[3]);
                int index44 = checked(index43 + 1);
                this.HDA[index44, 0] = "";
                this.HDA[index44, 1] = ""; // "Coreografia";
                this.HDA[index44, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[4]);
                int index45 = checked(index44 + 1);
                this.HDA[index45, 0] = "";
                this.HDA[index45, 1] = "";
                this.HDA[index45, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[5]);
                int index46 = checked(index45 + 1);
                int index47 = 0;
                do
                {
                    this.HDA[index46, index47] = " ";
                    checked { ++index47; }
                }
                while (index47 <= 2);
                int index48 = checked(index46 + 1);
                this.HDA[index48, 0] = "FREE SKATING";
                this.HDA[index48, 1] = "";
                this.HDA[index48, 2] = "";
                int index49 = checked(index48 + 1);
                this.HDA[index49, 0] = "Duration:";
                this.HDA[index49, 1] = Module1.OpenDB[Module1.PcIndex].Seg2Time;
                this.HDA[index49, 2] = "";
                int index50 = checked(index49 + 1);
                this.HDA[index50, 0] = "Program Component Factors:";
                this.HDA[index50, 1] = "Skating Skills"; // "Impostazione di base";
                this.HDA[index50, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[1]);
                int index51 = checked(index50 + 1);
                this.HDA[index51, 0] = "";
                this.HDA[index51, 1] = ""; // "Scorrevolezza";
                this.HDA[index51, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[2]);
                int index52 = checked(index51 + 1);
                this.HDA[index52, 0] = "";
                this.HDA[index52, 1] = "Performance/Execution";
                this.HDA[index52, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[3]);
                int index53 = checked(index52 + 1);
                this.HDA[index53, 0] = "";
                this.HDA[index53, 1] = ""; // "Coreografia";
                this.HDA[index53, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[4]);
                index1 = checked(index53 + 1);
                this.HDA[index1, 0] = "";
                this.HDA[index1, 1] = "";
                this.HDA[index1, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[5]);
            }
            else if (Operators.CompareString(seg, "FF", false) == 0)
            {
                int index54 = 0;
                this.HDA[index54, 0] = "DATE";
                this.HDA[index54, 1] = Module1.FormShortDate(Module1.Datum.Seg1);
                this.HDA[index54, 2] = "Free Skating";
                int index55 = checked(index54 + 1);
                this.HDA[index55, 0] = "";
                this.HDA[index55, 1] = Module1.FormShortDate(Module1.Datum.Seg2);
                this.HDA[index55, 2] = "Free Skating";
                int index56 = checked(index55 + 1);
                int index57 = 0;
                do
                {
                    this.HDA[index56, index57] = " ";
                    checked { ++index57; }
                }
                while (index57 <= 2);
                int index58 = checked(index56 + 1);
                this.HDA[index58, 0] = "Size of Skating Area:";
                this.HDA[index58, 1] = "30m*60m";
                this.HDA[index58, 2] = "";
                int index59 = checked(index58 + 1);
                this.HDA[index59, 0] = "Ice Condition:";
                this.HDA[index59, 1] = "Very Good";
                this.HDA[index59, 2] = "";
                int index60 = checked(index59 + 1);
                this.HDA[index60, 0] = "Number of Participants";
                this.HDA[index60, 1] = Conversions.ToString(Module1.TNop);
                this.HDA[index60, 2] = "";
                int index61 = checked(index60 + 1);
                int index62 = 0;
                do
                {
                    this.HDA[index61, index62] = " ";
                    checked { ++index62; }
                }
                while (index62 <= 2);
                int index63 = checked(index61 + 1);
                this.HDA[index63, 0] = "FREE SKATING";
                this.HDA[index63, 1] = "";
                this.HDA[index63, 2] = "";
                int index64 = checked(index63 + 1);
                this.HDA[index64, 0] = "Duration:";
                this.HDA[index64, 1] = Module1.OpenDB[Module1.PcIndex].Seg1Time;
                this.HDA[index64, 2] = "";
                int index65 = checked(index64 + 1);
                this.HDA[index65, 0] = "Program Component Factors:";
                this.HDA[index65, 1] = "Skating Skills"; // "Impostazione di base";
                this.HDA[index65, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[1]);
                int index66 = checked(index65 + 1);
                this.HDA[index66, 0] = "";
                this.HDA[index66, 1] = ""; // "Scorrevolezza";
                this.HDA[index66, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[2]);
                int index67 = checked(index66 + 1);
                this.HDA[index67, 0] = "";
                this.HDA[index67, 1] = "Performance/Execution";
                this.HDA[index67, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[3]);
                int index68 = checked(index67 + 1);
                this.HDA[index68, 0] = "";
                this.HDA[index68, 1] = ""; // "Coreografia";
                this.HDA[index68, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[4]);
                int index69 = checked(index68 + 1);
                this.HDA[index69, 0] = "";
                this.HDA[index69, 1] = "";
                this.HDA[index69, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[5]);
                int index70 = checked(index69 + 1);
                int index71 = 0;
                do
                {
                    this.HDA[index70, index71] = " ";
                    checked { ++index71; }
                }
                while (index71 <= 2);
                int index72 = checked(index70 + 1);
                this.HDA[index72, 0] = "FREE SKATING";
                this.HDA[index72, 1] = "";
                this.HDA[index72, 2] = "";
                int index73 = checked(index72 + 1);
                this.HDA[index73, 0] = "Duration:";
                this.HDA[index73, 1] = Module1.OpenDB[Module1.PcIndex].Seg2Time;
                this.HDA[index73, 2] = "";
                int index74 = checked(index73 + 1);
                this.HDA[index74, 0] = "Program Component Factors:";
                this.HDA[index74, 1] = "Skating Skills"; // "Impostazione di base";
                this.HDA[index74, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[1]);
                int index75 = checked(index74 + 1);
                this.HDA[index75, 0] = "";
                this.HDA[index75, 1] = ""; // "Scorrevolezza";
                this.HDA[index75, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[2]);
                int index76 = checked(index75 + 1);
                this.HDA[index76, 0] = "";
                this.HDA[index76, 1] = "Performance/Execution";
                this.HDA[index76, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[3]);
                int index77 = checked(index76 + 1);
                this.HDA[index77, 0] = "";
                this.HDA[index77, 1] = ""; // "Coreografia";
                this.HDA[index77, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[4]);
                index1 = checked(index77 + 1);
                this.HDA[index1, 0] = "";
                this.HDA[index1, 1] = "";
                this.HDA[index1, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[5]);
            }
            else if (Operators.CompareString(seg, "SS", false) == 0)
            {
                int index78 = 0;
                this.HDA[index78, 0] = "DATE";
                this.HDA[index78, 1] = Module1.FormShortDate(Module1.Datum.Seg1);
                this.HDA[index78, 2] = "Short Program";
                int index79 = checked(index78 + 1);
                this.HDA[index79, 0] = "";
                this.HDA[index79, 1] = Module1.FormShortDate(Module1.Datum.Seg2);
                this.HDA[index79, 2] = "Short Program";
                int index80 = checked(index79 + 1);
                int index81 = 0;
                do
                {
                    this.HDA[index80, index81] = " ";
                    checked { ++index81; }
                }
                while (index81 <= 2);
                int index82 = checked(index80 + 1);
                this.HDA[index82, 0] = "Size of Skating Area:";
                this.HDA[index82, 1] = "30m*60m";
                this.HDA[index82, 2] = "";
                int index83 = checked(index82 + 1);
                this.HDA[index83, 0] = "Ice Condition:";
                this.HDA[index83, 1] = "Very Good";
                this.HDA[index83, 2] = "";
                int index84 = checked(index83 + 1);
                this.HDA[index84, 0] = "Number of Participants";
                this.HDA[index84, 1] = Conversions.ToString(Module1.TNop);
                this.HDA[index84, 2] = "";
                int index85 = checked(index84 + 1);
                int index86 = 0;
                do
                {
                    this.HDA[index85, index86] = " ";
                    checked { ++index86; }
                }
                while (index86 <= 2);
                int index87 = checked(index85 + 1);
                this.HDA[index87, 0] = "SHORT PROGRAM";
                this.HDA[index87, 1] = "";
                this.HDA[index87, 2] = "";
                int index88 = checked(index87 + 1);
                this.HDA[index88, 0] = "Duration:";
                this.HDA[index88, 1] = Module1.OpenDB[Module1.PcIndex].Seg1Time;
                this.HDA[index88, 2] = "";
                int index89 = checked(index88 + 1);
                this.HDA[index89, 0] = "Program Component Factors:";
                this.HDA[index89, 1] = "Skating Skills"; // "Impostazione di base";
                this.HDA[index89, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[1]);
                int index90 = checked(index89 + 1);
                this.HDA[index90, 0] = "";
                this.HDA[index90, 1] = ""; // "Scorrevolezza";
                this.HDA[index90, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[2]);
                int index91 = checked(index90 + 1);
                this.HDA[index91, 0] = "";
                this.HDA[index91, 1] = "Performance/Execution";
                this.HDA[index91, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[3]);
                int index92 = checked(index91 + 1);
                this.HDA[index92, 0] = "";
                this.HDA[index92, 1] = ""; // "Coreografia";
                this.HDA[index92, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[4]);
                int index93 = checked(index92 + 1);
                this.HDA[index93, 0] = "";
                this.HDA[index93, 1] = "";
                this.HDA[index93, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg1[5]);
                int index94 = checked(index93 + 1);
                int index95 = 0;
                do
                {
                    this.HDA[index94, index95] = " ";
                    checked { ++index95; }
                }
                while (index95 <= 2);
                int index96 = checked(index94 + 1);
                this.HDA[index96, 0] = "SHORT PROGRAM";
                this.HDA[index96, 1] = "";
                this.HDA[index96, 2] = "";
                int index97 = checked(index96 + 1);
                this.HDA[index97, 0] = "Duration:";
                this.HDA[index97, 1] = Module1.OpenDB[Module1.PcIndex].Seg2Time;
                this.HDA[index97, 2] = "";
                int index98 = checked(index97 + 1);
                this.HDA[index98, 0] = "Program Component Factors:";
                this.HDA[index98, 1] = "Skating Skills"; // "Impostazione di base";
                this.HDA[index98, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[1]);
                int index99 = checked(index98 + 1);
                this.HDA[index99, 0] = "";
                this.HDA[index99, 1] = ""; // "Scorrevolezza";
                this.HDA[index99, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[2]);
                int index100 = checked(index99 + 1);
                this.HDA[index100, 0] = "";
                this.HDA[index100, 1] = "Performance/Execution";
                this.HDA[index100, 2] = Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[3]);
                int index101 = checked(index100 + 1);
                this.HDA[index101, 0] = "";
                this.HDA[index101, 1] = ""; // "Coreografia";
                this.HDA[index101, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[4]);
                index1 = checked(index101 + 1);
                this.HDA[index1, 0] = "";
                this.HDA[index1, 1] = "";
                this.HDA[index1, 2] = ""; // Conversions.ToString(Module1.OpenDB[Module1.PcIndex].PCFactorsSeg2[5]);
            }
            int index102 = checked(index1 + 1);
            int index103 = 0;
            do
            {
                this.HDA[index102, index103] = " ";
                checked { ++index103; }
            }
            while (index103 <= 2);
            int index104 = checked(index102 + 1);
            int index105 = 0;
            do
            {
                this.HDA[index104, index105] = " ";
                checked { ++index105; }
            }
            while (index105 <= 2);
            int index106 = checked(index104 + 1);
            this.HDA[index106, 0] = "OFFICIALS";
            this.HDA[index106, 1] = "";
            this.HDA[index106, 2] = "";
            int index107 = checked(index106 + 1);
            string segment1 = Module1.Segment;
            if (Operators.CompareString(segment1, "Seg1", false) == 0)
            {
                this.HDA[index107, 0] = "Technical Controller";
                this.HDA[index107, 1] = Module1.Controller.Seg1.Name;
                this.HDA[index107, 2] = Module1.Controller.Seg1.Club;
                int index108 = checked(index107 + 1);
                this.HDA[index108, 0] = "Technical Specialist";
                this.HDA[index108, 1] = Module1.Techspec.Seg1.Name;
                this.HDA[index108, 2] = Module1.Techspec.Seg1.Club;
                index107 = checked(index108 + 1);
                this.HDA[index107, 0] = "Referee";
                this.HDA[index107, 1] = Module1.Referee.Seg1.Name;
                this.HDA[index107, 2] = Module1.Referee.Seg1.Club;
            }
            else if (Operators.CompareString(segment1, "Seg2", false) == 0)
            {
                this.HDA[index107, 0] = "Technical Controller";
                this.HDA[index107, 1] = Module1.Controller.Seg2.Name;
                this.HDA[index107, 2] = Module1.Controller.Seg2.Club;
                int index109 = checked(index107 + 1);
                this.HDA[index109, 0] = "Technical Specialist";
                this.HDA[index109, 1] = Module1.Techspec.Seg2.Name;
                this.HDA[index109, 2] = Module1.Techspec.Seg2.Club;
                index107 = checked(index109 + 1);
                this.HDA[index107, 0] = "Referee";
                this.HDA[index107, 1] = Module1.Referee.Seg2.Name;
                this.HDA[index107, 2] = Module1.Referee.Seg2.Club;
            }
            int index110 = checked(index107 + 1);
            int index111 = 0;
            do
            {
                this.HDA[index110, index111] = " ";
                checked { ++index111; }
            }
            while (index111 <= 2);
            int index112 = checked(index110 + 1);
            this.HDA[index112, 0] = "JUDGES";
            this.HDA[index112, 1] = "";
            this.HDA[index112, 2] = "";
            int noJGoe = Module1.NoJ_GOE;
            int index113 = 1;
            while (index113 <= noJGoe)
            {
                checked { ++index112; }
                this.HDA[index112, 0] = "Judge " + Conversions.ToString(index113);
                string segment2 = Module1.Segment;
                if (Operators.CompareString(segment2, "Seg1", false) == 0)
                {
                    this.HDA[index112, 1] = Module1.Judge[index113].Seg1.Name;
                    this.HDA[index112, 2] = Module1.Judge[index113].Seg1.Club;
                }
                else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                {
                    this.HDA[index112, 1] = Module1.Judge[index113].Seg2.Name;
                    this.HDA[index112, 2] = Module1.Judge[index113].Seg2.Club;
                }
                checked { ++index113; }
            }
            if (Module1.NoTrj > 0)
            {
                int num1 = checked(Module1.NoJ_GOE + 1);
                int num2 = checked(Module1.NoJ_GOE + Module1.NoTrj);
                int index114 = num1;
                while (index114 <= num2)
                {
                    checked { ++index112; }
                    this.HDA[index112, 0] = "Tr. Judge " + Conversions.ToString(index114);
                    string segment3 = Module1.Segment;
                    if (Operators.CompareString(segment3, "Seg1", false) == 0)
                    {
                        this.HDA[index112, 1] = Module1.Judge[index114].Seg1.Name;
                        this.HDA[index112, 2] = Module1.Judge[index114].Seg1.Club;
                    }
                    else if (Operators.CompareString(segment3, "Seg2", false) == 0)
                    {
                        this.HDA[index112, 1] = Module1.Judge[index114].Seg2.Name;
                        this.HDA[index112, 2] = Module1.Judge[index114].Seg2.Club;
                    }
                    checked { ++index114; }
                }
            }
            if (Module1.JudgeSel == 1)
            {
                checked { ++index112; }
                this.HDA[index112, 0] = "Judge " + Conversions.ToString(7);
                string segment4 = Module1.Segment;
                if (Operators.CompareString(segment4, "Seg1", false) == 0)
                {
                    this.HDA[index112, 1] = Module1.Judge[7].Seg1.Name;
                    this.HDA[index112, 2] = Module1.Judge[7].Seg1.Club;
                }
                else if (Operators.CompareString(segment4, "Seg2", false) == 0)
                {
                    this.HDA[index112, 1] = Module1.Judge[7].Seg2.Name;
                    this.HDA[index112, 2] = Module1.Judge[7].Seg2.Club;
                }
            }
            int index115 = checked(index112 + 1);
            int index116 = 0;
            do
            {
                this.HDA[index115, index116] = " ";
                checked { ++index116; }
            }
            while (index116 <= 2);
            int index117 = checked(index115 + 1);
            this.HDA[index117, 0] = "OPERATORS";
            this.HDA[index117, 1] = "";
            this.HDA[index117, 2] = "";
            int norow = checked(index117 + 1);
            this.HDA[norow, 0] = "DVO";
            string segment5 = Module1.Segment;
            if (Operators.CompareString(segment5, "Seg1", false) == 0)
            {
                this.HDA[norow, 1] = Module1.DVO[1].Seg1.Name;
                this.HDA[norow, 2] = Module1.DVO[1].Seg1.Club;
                int index118 = checked(norow + 1);
                this.HDA[index118, 0] = "DVO";
                this.HDA[index118, 1] = Module1.DVO[2].Seg1.Name;
                this.HDA[index118, 2] = Module1.DVO[2].Seg1.Club;
                norow = checked(index118 + 1);
                this.HDA[norow, 0] = "Technical support";
                this.HDA[norow, 1] = Module1.DVO[3].Seg1.Name;
                this.HDA[norow, 2] = Module1.DVO[3].Seg1.Club;
            }
            else if (Operators.CompareString(segment5, "Seg2", false) == 0)
            {
                this.HDA[norow, 1] = Module1.DVO[1].Seg2.Name;
                this.HDA[norow, 2] = Module1.DVO[1].Seg2.Club;
                int index119 = checked(norow + 1);
                this.HDA[index119, 0] = "DVO";
                this.HDA[index119, 1] = Module1.DVO[2].Seg2.Name;
                this.HDA[index119, 2] = Module1.DVO[2].Seg2.Club;
                norow = checked(index119 + 1);
                this.HDA[norow, 0] = "Technical support";
                this.HDA[norow, 1] = Module1.DVO[3].Seg2.Name;
                this.HDA[norow, 2] = Module1.DVO[3].Seg2.Club;
            }
            string segment6 = Module1.Segment;
            if (Operators.CompareString(segment6, "Seg1", false) == 0)
            {
                if (!Conversions.ToBoolean(Module1.CreatePath("Segment_1", ref Path)))
                    return;
            }
            else if (Operators.CompareString(segment6, "Seg2", false) == 0 && !Conversions.ToBoolean(Module1.CreatePath("Segment_2", ref Path)))
                return;
            this.ExportHeadPageToPDF(norow, 3, " ", Path + "_HeadPage.pdf", msg);
        }

        private void CREATEPDFFILEToolStripMenuItem_Click(object sender, EventArgs e) => this.CreateHP_PDFfile(1);
    }
}

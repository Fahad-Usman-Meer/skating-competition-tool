// Decompiled with JetBrains decompiler
// Type: ClubCompFS.ConfigurationDataDialog
// Assembly: ClubCompFS_10p0p6, Version=1.0.0.6, Culture=neutral, PublicKeyToken=null
// MVID: F1E583B2-A781-4EC4-B47C-BA3F451903AE
// Assembly location: E:\zz Personal_Doc\Personal\Cinzia\programmaLibertas_openNEW\ClubCompFS_10p0p6.exe

using ClubCompFS.My;
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
    public class ConfigurationDataDialog : Form
    {
        private IContainer components;
        [AccessedThroughProperty("TableLayoutPanel1")]
        private TableLayoutPanel _TableLayoutPanel1;
        [AccessedThroughProperty("OK_Button")]
        private Button _OK_Button;
        [AccessedThroughProperty("Cancel_Button")]
        private Button _Cancel_Button;
        [AccessedThroughProperty("Label10")]
        private Label _Label10;
        [AccessedThroughProperty("Label11")]
        private Label _Label11;
        [AccessedThroughProperty("Label12")]
        private Label _Label12;
        [AccessedThroughProperty("Label13")]
        private Label _Label13;
        [AccessedThroughProperty("txtResults")]
        private TextBox _txtResults;
        [AccessedThroughProperty("txtwarmup")]
        private TextBox _txtwarmup;
        [AccessedThroughProperty("txtIceleave")]
        private TextBox _txtIceleave;
        [AccessedThroughProperty("txtResurfacing")]
        private TextBox _txtResurfacing;
        [AccessedThroughProperty("txtMeal")]
        private TextBox _txtMeal;
        [AccessedThroughProperty("Label17")]
        private Label _Label17;
        [AccessedThroughProperty("txtComp")]
        private TextBox _txtComp;
        [AccessedThroughProperty("Label15")]
        private Label _Label15;
        [AccessedThroughProperty("txtShowJDed")]
        private TextBox _txtShowJDed;
        [AccessedThroughProperty("Label19")]
        private Label _Label19;
        [AccessedThroughProperty("Label21")]
        private Label _Label21;
        [AccessedThroughProperty("txtNoJudgeTMV")]
        private TextBox _txtNoJudgeTMV;
        [AccessedThroughProperty("Label22")]
        private Label _Label22;
        [AccessedThroughProperty("txtScoreBoard")]
        private TextBox _txtScoreBoard;
        [AccessedThroughProperty("Label23")]
        private Label _Label23;
        [AccessedThroughProperty("Label24")]
        private Label _Label24;
        [AccessedThroughProperty("Label26")]
        private Label _Label26;
        [AccessedThroughProperty("txtPort")]
        private TextBox _txtPort;
        [AccessedThroughProperty("lblPort")]
        private Label _lblPort;
        [AccessedThroughProperty("Label29")]
        private Label _Label29;
        [AccessedThroughProperty("Label28")]
        private Label _Label28;
        [AccessedThroughProperty("Label27")]
        private Label _Label27;
        [AccessedThroughProperty("txtTopMargin")]
        private TextBox _txtTopMargin;
        [AccessedThroughProperty("txtLeftMargin")]
        private TextBox _txtLeftMargin;
        [AccessedThroughProperty("txtSize")]
        private TextBox _txtSize;
        [AccessedThroughProperty("Label30")]
        private Label _Label30;
        [AccessedThroughProperty("txtJD")]
        private TextBox _txtJD;
        [AccessedThroughProperty("Label31")]
        private Label _Label31;
        [AccessedThroughProperty("Label32")]
        private Label _Label32;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("txtDelay")]
        private TextBox _txtDelay;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("txtResultsPhone")]
        private TextBox _txtResultsPhone;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("txtAdjust")]
        private TextBox _txtAdjust;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
        [AccessedThroughProperty("Label6")]
        private Label _Label6;
        [AccessedThroughProperty("txtTEScores")]
        private TextBox _txtTEScores;
        [AccessedThroughProperty("Label7")]
        private Label _Label7;
        [AccessedThroughProperty("Label8")]
        private Label _Label8;
        [AccessedThroughProperty("Label9")]
        private Label _Label9;
        [AccessedThroughProperty("Label14")]
        private Label _Label14;
        [AccessedThroughProperty("Label16")]
        private Label _Label16;
        [AccessedThroughProperty("txtPingClients")]
        private TextBox _txtPingClients;
        [AccessedThroughProperty("Label18")]
        private Label _Label18;
        [AccessedThroughProperty("Label20")]
        private Label _Label20;
        [AccessedThroughProperty("txtPingTimeout")]
        private TextBox _txtPingTimeout;
        [AccessedThroughProperty("Label25")]
        private Label _Label25;
        private string OldIceLeave;
        private string OldResurfacing;
        private string OldMeal;
        private string OldShowJDed;
        private string OldNoJudgeTMV;
        private string OldCreateScoreBoard;
        private int OldScoreboardDelay;
        private Decimal OldSize;
        private int OldLeftMargin;
        private int OldTopMargin;
        private int Old_AdjustToScreen;
        private int Old_PingClients;
        private int Old_PingTimeout;

        public ConfigurationDataDialog()
        {
            this.Load += new EventHandler(this.ConfigurationDataDialog_Load);
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ConfigurationDataDialog));
            this.TableLayoutPanel1 = new TableLayoutPanel();
            this.OK_Button = new Button();
            this.Cancel_Button = new Button();
            this.Label10 = new Label();
            this.Label11 = new Label();
            this.Label12 = new Label();
            this.Label13 = new Label();
            this.txtResults = new TextBox();
            this.txtwarmup = new TextBox();
            this.txtIceleave = new TextBox();
            this.txtResurfacing = new TextBox();
            this.txtMeal = new TextBox();
            this.Label17 = new Label();
            this.txtComp = new TextBox();
            this.Label15 = new Label();
            this.txtShowJDed = new TextBox();
            this.Label19 = new Label();
            this.Label21 = new Label();
            this.txtNoJudgeTMV = new TextBox();
            this.Label22 = new Label();
            this.txtScoreBoard = new TextBox();
            this.Label23 = new Label();
            this.Label24 = new Label();
            this.Label26 = new Label();
            this.txtPort = new TextBox();
            this.lblPort = new Label();
            this.Label29 = new Label();
            this.Label28 = new Label();
            this.Label27 = new Label();
            this.txtTopMargin = new TextBox();
            this.txtLeftMargin = new TextBox();
            this.txtSize = new TextBox();
            this.Label30 = new Label();
            this.txtJD = new TextBox();
            this.Label31 = new Label();
            this.Label32 = new Label();
            this.Label1 = new Label();
            this.txtDelay = new TextBox();
            this.Label2 = new Label();
            this.txtResultsPhone = new TextBox();
            this.Label3 = new Label();
            this.Label4 = new Label();
            this.Button1 = new Button();
            this.txtAdjust = new TextBox();
            this.Label5 = new Label();
            this.Label6 = new Label();
            this.txtTEScores = new TextBox();
            this.Label7 = new Label();
            this.Label8 = new Label();
            this.Label9 = new Label();
            this.Label14 = new Label();
            this.Label16 = new Label();
            this.txtPingClients = new TextBox();
            this.Label18 = new Label();
            this.Label20 = new Label();
            this.txtPingTimeout = new TextBox();
            this.Label25 = new Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            this.TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.TableLayoutPanel1.BackColor = Color.White;
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            this.TableLayoutPanel1.Controls.Add((Control)this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add((Control)this.Cancel_Button, 1, 0);
            this.TableLayoutPanel1.Location = new Point(152, 498);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
            TableLayoutPanel tableLayoutPanel1 = this.TableLayoutPanel1;
            Size size1 = new Size(146, 38);
            Size size2 = size1;
            tableLayoutPanel1.Size = size2;
            this.TableLayoutPanel1.TabIndex = 0;
            this.OK_Button.Anchor = AnchorStyles.None;
            this.OK_Button.Location = new Point(3, 7);
            this.OK_Button.Name = "OK_Button";
            Button okButton = this.OK_Button;
            size1 = new Size(67, 23);
            Size size3 = size1;
            okButton.Size = size3;
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.Cancel_Button.Anchor = AnchorStyles.None;
            this.Cancel_Button.DialogResult = DialogResult.Cancel;
            this.Cancel_Button.Location = new Point(76, 7);
            this.Cancel_Button.Name = "Cancel_Button";
            Button cancelButton = this.Cancel_Button;
            size1 = new Size(67, 23);
            Size size4 = size1;
            cancelButton.Size = size4;
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Label10.AutoSize = true;
            this.Label10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label10.Location = new Point(8, 35);
            this.Label10.Name = "Label10";
            Label label10 = this.Label10;
            size1 = new Size(94, 13);
            Size size5 = size1;
            label10.Size = size5;
            this.Label10.TabIndex = 17;
            this.Label10.Text = "Path Result-file";
            this.Label11.AutoSize = true;
            this.Label11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label11.Location = new Point(8, 144);
            this.Label11.Name = "Label11";
            Label label11 = this.Label11;
            size1 = new Size(80, 13);
            Size size6 = size1;
            label11.Size = size6;
            this.Label11.TabIndex = 19;
            this.Label11.Text = "Warmup time";
            this.Label11.Visible = false;
            this.Label12.AutoSize = true;
            this.Label12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label12.Location = new Point(8, 164);
            this.Label12.Name = "Label12";
            Label label12 = this.Label12;
            size1 = new Size(91, 13);
            Size size7 = size1;
            label12.Size = size7;
            this.Label12.TabIndex = 20;
            this.Label12.Text = "Ice Leave time";
            this.Label13.AutoSize = true;
            this.Label13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label13.Location = new Point(8, 184);
            this.Label13.Name = "Label13";
            Label label13 = this.Label13;
            size1 = new Size(102, 13);
            Size size8 = size1;
            label13.Size = size8;
            this.Label13.TabIndex = 21;
            this.Label13.Text = "Resurfacing time";
            this.txtResults.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtResults.Location = new Point(161, 32);
            this.txtResults.Name = "txtResults";
            TextBox txtResults = this.txtResults;
            size1 = new Size(280, 20);
            Size size9 = size1;
            txtResults.Size = size9;
            this.txtResults.TabIndex = 12;
            this.txtwarmup.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtwarmup.Location = new Point(161, 141);
            this.txtwarmup.Name = "txtwarmup";
            TextBox txtwarmup = this.txtwarmup;
            size1 = new Size(70, 20);
            Size size10 = size1;
            txtwarmup.Size = size10;
            this.txtwarmup.TabIndex = 15;
            this.txtwarmup.TextAlign = HorizontalAlignment.Center;
            this.txtwarmup.Visible = false;
            this.txtIceleave.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtIceleave.Location = new Point(161, 161);
            this.txtIceleave.Name = "txtIceleave";
            TextBox txtIceleave = this.txtIceleave;
            size1 = new Size(70, 20);
            Size size11 = size1;
            txtIceleave.Size = size11;
            this.txtIceleave.TabIndex = 16;
            this.txtIceleave.TextAlign = HorizontalAlignment.Center;
            this.txtResurfacing.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtResurfacing.Location = new Point(161, 181);
            this.txtResurfacing.Name = "txtResurfacing";
            TextBox txtResurfacing = this.txtResurfacing;
            size1 = new Size(70, 20);
            Size size12 = size1;
            txtResurfacing.Size = size12;
            this.txtResurfacing.TabIndex = 17;
            this.txtResurfacing.TextAlign = HorizontalAlignment.Center;
            this.txtMeal.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtMeal.Location = new Point(161, 201);
            this.txtMeal.Name = "txtMeal";
            TextBox txtMeal = this.txtMeal;
            size1 = new Size(70, 20);
            Size size13 = size1;
            txtMeal.Size = size13;
            this.txtMeal.TabIndex = 18;
            this.txtMeal.TextAlign = HorizontalAlignment.Center;
            this.Label17.AutoSize = true;
            this.Label17.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label17.Location = new Point(8, 204);
            this.Label17.Name = "Label17";
            Label label17 = this.Label17;
            size1 = new Size(61, 13);
            Size size14 = size1;
            label17.Size = size14;
            this.Label17.TabIndex = 31;
            this.Label17.Text = "Meal time";
            this.txtComp.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtComp.Location = new Point(161, 12);
            this.txtComp.Name = "txtComp";
            TextBox txtComp = this.txtComp;
            size1 = new Size(280, 20);
            Size size15 = size1;
            txtComp.Size = size15;
            this.txtComp.TabIndex = 11;
            this.Label15.AutoSize = true;
            this.Label15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label15.Location = new Point(8, 12);
            this.Label15.Name = "Label15";
            Label label15 = this.Label15;
            size1 = new Size(89, 13);
            Size size16 = size1;
            label15.Size = size16;
            this.Label15.TabIndex = 33;
            this.Label15.Text = "Path Comp-file";
            this.txtShowJDed.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtShowJDed.Location = new Point(161, 227);
            this.txtShowJDed.MaxLength = 1;
            this.txtShowJDed.Name = "txtShowJDed";
            TextBox txtShowJded = this.txtShowJDed;
            size1 = new Size(48, 20);
            Size size17 = size1;
            txtShowJded.Size = size17;
            this.txtShowJDed.TabIndex = 19;
            this.txtShowJDed.TextAlign = HorizontalAlignment.Center;
            this.Label19.AutoSize = true;
            this.Label19.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label19.Location = new Point(8, 230);
            this.Label19.Name = "Label19";
            Label label19 = this.Label19;
            size1 = new Size(107, 13);
            Size size18 = size1;
            label19.Size = size18;
            this.Label19.TabIndex = 37;
            this.Label19.Text = "Show Judge Ded.";
            this.Label21.AutoSize = true;
            this.Label21.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label21.Location = new Point(8, 250);
            this.Label21.Name = "Label21";
            Label label21 = this.Label21;
            size1 = new Size(114, 13);
            Size size19 = size1;
            label21.Size = size19;
            this.Label21.TabIndex = 41;
            this.Label21.Text = "Judge Trimmed MV";
            this.txtNoJudgeTMV.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtNoJudgeTMV.Location = new Point(161, 247);
            this.txtNoJudgeTMV.MaxLength = 1;
            this.txtNoJudgeTMV.Name = "txtNoJudgeTMV";
            TextBox txtNoJudgeTmv = this.txtNoJudgeTMV;
            size1 = new Size(48, 20);
            Size size20 = size1;
            txtNoJudgeTmv.Size = size20;
            this.txtNoJudgeTMV.TabIndex = 20;
            this.txtNoJudgeTMV.TextAlign = HorizontalAlignment.Center;
            this.Label22.AutoSize = true;
            this.Label22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label22.Location = new Point(215, 250);
            this.Label22.Name = "Label22";
            Label label22 = this.Label22;
            size1 = new Size(92, 13);
            Size size21 = size1;
            label22.Size = size21;
            this.Label22.TabIndex = 43;
            this.Label22.Text = "(Only 0, 5 or 7)";
            this.txtScoreBoard.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtScoreBoard.Location = new Point(161, 92);
            this.txtScoreBoard.MaxLength = 1;
            this.txtScoreBoard.Name = "txtScoreBoard";
            TextBox txtScoreBoard = this.txtScoreBoard;
            size1 = new Size(48, 20);
            Size size22 = size1;
            txtScoreBoard.Size = size22;
            this.txtScoreBoard.TabIndex = 44;
            this.txtScoreBoard.TextAlign = HorizontalAlignment.Center;
            this.Label23.AutoSize = true;
            this.Label23.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label23.Location = new Point(8, 95);
            this.Label23.Name = "Label23";
            Label label23 = this.Label23;
            size1 = new Size(130, 13);
            Size size23 = size1;
            label23.Size = size23;
            this.Label23.TabIndex = 45;
            this.Label23.Text = "Save ScoreBoard.htm";
            this.Label24.AutoSize = true;
            this.Label24.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label24.Location = new Point(215, 95);
            this.Label24.Name = "Label24";
            Label label24 = this.Label24;
            size1 = new Size(225, 13);
            Size size24 = size1;
            label24.Size = size24;
            this.Label24.TabIndex = 46;
            this.Label24.Text = "(0, 1,3 black or 2,4 white background)";
            this.Label26.AutoSize = true;
            this.Label26.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label26.Location = new Point(215, 230);
            this.Label26.Name = "Label26";
            Label label26 = this.Label26;
            size1 = new Size(48, 13);
            Size size25 = size1;
            label26.Size = size25;
            this.Label26.TabIndex = 48;
            this.Label26.Text = "(0 or 1)";
            this.txtPort.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtPort.Location = new Point(161, 293);
            this.txtPort.Name = "txtPort";
            TextBox txtPort = this.txtPort;
            size1 = new Size(70, 20);
            Size size26 = size1;
            txtPort.Size = size26;
            this.txtPort.TabIndex = 52;
            this.txtPort.Text = "23456";
            this.txtPort.TextAlign = HorizontalAlignment.Center;
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblPort.Location = new Point(8, 296);
            this.lblPort.Name = "lblPort";
            Label lblPort = this.lblPort;
            size1 = new Size(75, 13);
            Size size27 = size1;
            lblPort.Size = size27;
            this.lblPort.TabIndex = 53;
            this.lblPort.Text = "Port number";
            this.Label29.AutoSize = true;
            this.Label29.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label29.Location = new Point(8, 431);
            this.Label29.Name = "Label29";
            Label label29 = this.Label29;
            size1 = new Size(118, 13);
            Size size28 = size1;
            label29.Size = size28;
            this.Label29.TabIndex = 61;
            this.Label29.Text = "Top margin, (0-100)";
            this.Label28.AutoSize = true;
            this.Label28.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label28.Location = new Point(8, 411);
            this.Label28.Name = "Label28";
            Label label28 = this.Label28;
            size1 = new Size(118, 13);
            Size size29 = size1;
            label28.Size = size29;
            this.Label28.TabIndex = 60;
            this.Label28.Text = "Left margin, (0-100)";
            this.Label27.AutoSize = true;
            this.Label27.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label27.Location = new Point(9, 391);
            this.Label27.Name = "Label27";
            Label label27 = this.Label27;
            size1 = new Size(86, 13);
            Size size30 = size1;
            label27.Size = size30;
            this.Label27.TabIndex = 59;
            this.Label27.Text = "Size, (75-125)";
            this.txtTopMargin.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtTopMargin.Location = new Point(161, 428);
            this.txtTopMargin.MaxLength = 3;
            this.txtTopMargin.Name = "txtTopMargin";
            TextBox txtTopMargin = this.txtTopMargin;
            size1 = new Size(48, 20);
            Size size31 = size1;
            txtTopMargin.Size = size31;
            this.txtTopMargin.TabIndex = 65;
            this.txtTopMargin.TextAlign = HorizontalAlignment.Center;
            this.txtLeftMargin.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtLeftMargin.Location = new Point(161, 408);
            this.txtLeftMargin.MaxLength = 3;
            this.txtLeftMargin.Name = "txtLeftMargin";
            TextBox txtLeftMargin = this.txtLeftMargin;
            size1 = new Size(48, 20);
            Size size32 = size1;
            txtLeftMargin.Size = size32;
            this.txtLeftMargin.TabIndex = 64;
            this.txtLeftMargin.TextAlign = HorizontalAlignment.Center;
            this.txtSize.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtSize.Location = new Point(161, 388);
            this.txtSize.MaxLength = 3;
            this.txtSize.Name = "txtSize";
            TextBox txtSize = this.txtSize;
            size1 = new Size(48, 20);
            Size size33 = size1;
            txtSize.Size = size33;
            this.txtSize.TabIndex = 63;
            this.txtSize.TextAlign = HorizontalAlignment.Center;
            this.Label30.AutoSize = true;
            this.Label30.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label30.Location = new Point(8, 371);
            this.Label30.Name = "Label30";
            Label label30 = this.Label30;
            size1 = new Size(71, 13);
            Size size34 = size1;
            label30.Size = size34;
            this.Label30.TabIndex = 62;
            this.Label30.Text = "PRINTOUT";
            this.txtJD.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtJD.Location = new Point(161, 267);
            this.txtJD.MaxLength = 1;
            this.txtJD.Name = "txtJD";
            TextBox txtJd = this.txtJD;
            size1 = new Size(48, 20);
            Size size35 = size1;
            txtJd.Size = size35;
            this.txtJD.TabIndex = 66;
            this.txtJD.TextAlign = HorizontalAlignment.Center;
            this.txtJD.Visible = false;
            this.Label31.AutoSize = true;
            this.Label31.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label31.Location = new Point(9, 270);
            this.Label31.Name = "Label31";
            Label label31 = this.Label31;
            size1 = new Size(90, 13);
            Size size36 = size1;
            label31.Size = size36;
            this.Label31.TabIndex = 67;
            this.Label31.Text = "Judges Details";
            this.Label31.Visible = false;
            this.Label32.AutoSize = true;
            this.Label32.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label32.Location = new Point(215, 270);
            this.Label32.Name = "Label32";
            Label label32 = this.Label32;
            size1 = new Size(140, 13);
            Size size37 = size1;
            label32.Size = size37;
            this.Label32.TabIndex = 68;
            this.Label32.Text = "(1 or 2 tables per page)";
            this.Label32.Visible = false;
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new Point(8, 115);
            this.Label1.Name = "Label1";
            Label label1 = this.Label1;
            size1 = new Size(109, 13);
            Size size38 = size1;
            label1.Size = size38;
            this.Label1.TabIndex = 69;
            this.Label1.Text = "ScoreBoard Delay";
            this.txtDelay.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtDelay.Location = new Point(161, 112);
            this.txtDelay.MaxLength = 2;
            this.txtDelay.Name = "txtDelay";
            TextBox txtDelay = this.txtDelay;
            size1 = new Size(48, 20);
            Size size39 = size1;
            txtDelay.Size = size39;
            this.txtDelay.TabIndex = 70;
            this.txtDelay.TextAlign = HorizontalAlignment.Center;
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new Point(215, 115);
            this.Label2.Name = "Label2";
            Label label2 = this.Label2;
            size1 = new Size(83, 13);
            Size size40 = size1;
            label2.Size = size40;
            this.Label2.TabIndex = 71;
            this.Label2.Text = "(0 to 60 sec.)";
            this.txtResultsPhone.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtResultsPhone.Location = new Point(161, 52);
            this.txtResultsPhone.Name = "txtResultsPhone";
            TextBox txtResultsPhone = this.txtResultsPhone;
            size1 = new Size(48, 20);
            Size size41 = size1;
            txtResultsPhone.Size = size41;
            this.txtResultsPhone.TabIndex = 73;
            this.txtResultsPhone.TextAlign = HorizontalAlignment.Center;
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new Point(9, 55);
            this.Label3.Name = "Label3";
            Label label3 = this.Label3;
            size1 = new Size(142, 13);
            Size size42 = size1;
            label3.Size = size42;
            this.Label3.TabIndex = 74;
            this.Label3.Text = "Save ResultsPhone.htm";
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label4.Location = new Point(215, 55);
            this.Label4.Name = "Label4";
            Label label4 = this.Label4;
            size1 = new Size(48, 13);
            Size size43 = size1;
            label4.Size = size43;
            this.Label4.TabIndex = 75;
            this.Label4.Text = "(0 or 1)";
            this.Button1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Button1.Location = new Point(80, 462);
            this.Button1.Name = "Button1";
            Button button1 = this.Button1;
            size1 = new Size(275, 26);
            Size size44 = size1;
            button1.Size = size44;
            this.Button1.TabIndex = 76;
            this.Button1.Text = "Adjust the Element Input Form  to the Screen";
            this.Button1.UseVisualStyleBackColor = true;
            this.txtAdjust.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtAdjust.Location = new Point(378, 466);
            this.txtAdjust.Name = "txtAdjust";
            TextBox txtAdjust = this.txtAdjust;
            size1 = new Size(51, 20);
            Size size45 = size1;
            txtAdjust.Size = size45;
            this.txtAdjust.TabIndex = 77;
            this.txtAdjust.TextAlign = HorizontalAlignment.Center;
            this.Label5.AutoSize = true;
            this.Label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label5.Location = new Point(215, 75);
            this.Label5.Name = "Label5";
            Label label5 = this.Label5;
            size1 = new Size(48, 13);
            Size size46 = size1;
            label5.Size = size46;
            this.Label5.TabIndex = 80;
            this.Label5.Text = "(0 or 1)";
            this.Label6.AutoSize = true;
            this.Label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label6.Location = new Point(9, 75);
            this.Label6.Name = "Label6";
            Label label6 = this.Label6;
            size1 = new Size(119, 13);
            Size size47 = size1;
            label6.Size = size47;
            this.Label6.TabIndex = 79;
            this.Label6.Text = "Save TEScores.htm";
            this.txtTEScores.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtTEScores.Location = new Point(161, 72);
            this.txtTEScores.Name = "txtTEScores";
            TextBox txtTeScores = this.txtTEScores;
            size1 = new Size(48, 20);
            Size size48 = size1;
            txtTeScores.Size = size48;
            this.txtTEScores.TabIndex = 78;
            this.txtTEScores.TextAlign = HorizontalAlignment.Center;
            this.Label7.AutoSize = true;
            this.Label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label7.Location = new Point(231, 371);
            this.Label7.Name = "Label7";
            Label label7 = this.Label7;
            size1 = new Size(22, 13);
            Size size49 = size1;
            label7.Size = size49;
            this.Label7.TabIndex = 81;
            this.Label7.Text = "A4";
            this.Label8.AutoSize = true;
            this.Label8.Location = new Point(225, 391);
            this.Label8.Name = "Label8";
            Label label8 = this.Label8;
            size1 = new Size(31, 13);
            Size size50 = size1;
            label8.Size = size50;
            this.Label8.TabIndex = 82;
            this.Label8.Text = "(100)";
            this.Label9.AutoSize = true;
            this.Label9.Location = new Point(228, 411);
            this.Label9.Name = "Label9";
            Label label9 = this.Label9;
            size1 = new Size(25, 13);
            Size size51 = size1;
            label9.Size = size51;
            this.Label9.TabIndex = 83;
            this.Label9.Text = "(40)";
            this.Label14.AutoSize = true;
            this.Label14.Location = new Point(228, 431);
            this.Label14.Name = "Label14";
            Label label14 = this.Label14;
            size1 = new Size(25, 13);
            Size size52 = size1;
            label14.Size = size52;
            this.Label14.TabIndex = 84;
            this.Label14.Text = "(60)";
            this.Label16.AutoSize = true;
            this.Label16.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label16.Location = new Point(215, 322);
            this.Label16.Name = "Label16";
            Label label16 = this.Label16;
            size1 = new Size(48, 13);
            Size size53 = size1;
            label16.Size = size53;
            this.Label16.TabIndex = 87;
            this.Label16.Text = "(0 or 1)";
            this.txtPingClients.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtPingClients.Location = new Point(161, 319);
            this.txtPingClients.MaxLength = 1;
            this.txtPingClients.Name = "txtPingClients";
            TextBox txtPingClients = this.txtPingClients;
            size1 = new Size(48, 20);
            Size size54 = size1;
            txtPingClients.Size = size54;
            this.txtPingClients.TabIndex = 85;
            this.txtPingClients.TextAlign = HorizontalAlignment.Center;
            this.Label18.AutoSize = true;
            this.Label18.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label18.Location = new Point(8, 322);
            this.Label18.Name = "Label18";
            Label label18 = this.Label18;
            size1 = new Size(74, 13);
            Size size55 = size1;
            label18.Size = size55;
            this.Label18.TabIndex = 86;
            this.Label18.Text = "Ping Clients";
            this.Label20.AutoSize = true;
            this.Label20.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label20.Location = new Point(215, 342);
            this.Label20.Name = "Label20";
            Label label20 = this.Label20;
            size1 = new Size(95, 13);
            Size size56 = size1;
            label20.Size = size56;
            this.Label20.TabIndex = 90;
            this.Label20.Text = "(500 - 1500 ms)";
            this.txtPingTimeout.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtPingTimeout.Location = new Point(161, 339);
            this.txtPingTimeout.MaxLength = 4;
            this.txtPingTimeout.Name = "txtPingTimeout";
            TextBox txtPingTimeout = this.txtPingTimeout;
            size1 = new Size(48, 20);
            Size size57 = size1;
            txtPingTimeout.Size = size57;
            this.txtPingTimeout.TabIndex = 88;
            this.txtPingTimeout.TextAlign = HorizontalAlignment.Center;
            this.Label25.AutoSize = true;
            this.Label25.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label25.Location = new Point(9, 342);
            this.Label25.Name = "Label25";
            Label label25 = this.Label25;
            size1 = new Size(81, 13);
            Size size58 = size1;
            label25.Size = size58;
            this.Label25.TabIndex = 89;
            this.Label25.Text = "Ping Timeout";
            this.AcceptButton = (IButtonControl)this.OK_Button;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb((int)byte.MaxValue, 192, 128);
            this.CancelButton = (IButtonControl)this.Cancel_Button;
            size1 = new Size(452, 548);
            this.ClientSize = size1;
            this.ControlBox = false;
            this.Controls.Add((Control)this.Label20);
            this.Controls.Add((Control)this.txtPingTimeout);
            this.Controls.Add((Control)this.Label25);
            this.Controls.Add((Control)this.Label16);
            this.Controls.Add((Control)this.txtPingClients);
            this.Controls.Add((Control)this.Label18);
            this.Controls.Add((Control)this.Label14);
            this.Controls.Add((Control)this.Label9);
            this.Controls.Add((Control)this.Label8);
            this.Controls.Add((Control)this.Label7);
            this.Controls.Add((Control)this.Label5);
            this.Controls.Add((Control)this.Label6);
            this.Controls.Add((Control)this.txtTEScores);
            this.Controls.Add((Control)this.txtAdjust);
            this.Controls.Add((Control)this.Button1);
            this.Controls.Add((Control)this.Label4);
            this.Controls.Add((Control)this.Label3);
            this.Controls.Add((Control)this.txtResultsPhone);
            this.Controls.Add((Control)this.Label2);
            this.Controls.Add((Control)this.txtDelay);
            this.Controls.Add((Control)this.Label1);
            this.Controls.Add((Control)this.Label32);
            this.Controls.Add((Control)this.Label31);
            this.Controls.Add((Control)this.txtJD);
            this.Controls.Add((Control)this.txtTopMargin);
            this.Controls.Add((Control)this.txtLeftMargin);
            this.Controls.Add((Control)this.txtSize);
            this.Controls.Add((Control)this.Label30);
            this.Controls.Add((Control)this.Label29);
            this.Controls.Add((Control)this.Label28);
            this.Controls.Add((Control)this.Label27);
            this.Controls.Add((Control)this.lblPort);
            this.Controls.Add((Control)this.txtPort);
            this.Controls.Add((Control)this.Label26);
            this.Controls.Add((Control)this.Label24);
            this.Controls.Add((Control)this.Label23);
            this.Controls.Add((Control)this.txtScoreBoard);
            this.Controls.Add((Control)this.Label22);
            this.Controls.Add((Control)this.txtNoJudgeTMV);
            this.Controls.Add((Control)this.Label21);
            this.Controls.Add((Control)this.txtShowJDed);
            this.Controls.Add((Control)this.Label19);
            this.Controls.Add((Control)this.txtComp);
            this.Controls.Add((Control)this.Label15);
            this.Controls.Add((Control)this.txtMeal);
            this.Controls.Add((Control)this.Label17);
            this.Controls.Add((Control)this.txtResurfacing);
            this.Controls.Add((Control)this.txtIceleave);
            this.Controls.Add((Control)this.txtwarmup);
            this.Controls.Add((Control)this.txtResults);
            this.Controls.Add((Control)this.Label13);
            this.Controls.Add((Control)this.Label12);
            this.Controls.Add((Control)this.Label11);
            this.Controls.Add((Control)this.Label10);
            this.Controls.Add((Control)this.TableLayoutPanel1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = nameof(ConfigurationDataDialog);
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "CONFIGURATION DATA";
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

        internal virtual Label Label13
        {
            get => this._Label13;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label13 = value;
        }

        internal virtual TextBox txtResults
        {
            get => this._txtResults;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtResults_KeyPress);
                if (this._txtResults != null)
                    this._txtResults.KeyPress -= pressEventHandler;
                this._txtResults = value;
                if (this._txtResults == null)
                    return;
                this._txtResults.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox txtwarmup
        {
            get => this._txtwarmup;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtwarmup = value;
        }

        internal virtual TextBox txtIceleave
        {
            get => this._txtIceleave;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.txtIceleave_Leave);
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtIceleave_KeyPress);
                if (this._txtIceleave != null)
                {
                    this._txtIceleave.Leave -= eventHandler;
                    this._txtIceleave.KeyPress -= pressEventHandler;
                }
                this._txtIceleave = value;
                if (this._txtIceleave == null)
                    return;
                this._txtIceleave.Leave += eventHandler;
                this._txtIceleave.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox txtResurfacing
        {
            get => this._txtResurfacing;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.txtResurfacing_Leave);
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtResurfacing_KeyPress);
                if (this._txtResurfacing != null)
                {
                    this._txtResurfacing.Leave -= eventHandler;
                    this._txtResurfacing.KeyPress -= pressEventHandler;
                }
                this._txtResurfacing = value;
                if (this._txtResurfacing == null)
                    return;
                this._txtResurfacing.Leave += eventHandler;
                this._txtResurfacing.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox txtMeal
        {
            get => this._txtMeal;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.txtMeal_Leave);
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtMeal_KeyPress);
                if (this._txtMeal != null)
                {
                    this._txtMeal.Leave -= eventHandler;
                    this._txtMeal.KeyPress -= pressEventHandler;
                }
                this._txtMeal = value;
                if (this._txtMeal == null)
                    return;
                this._txtMeal.Leave += eventHandler;
                this._txtMeal.KeyPress += pressEventHandler;
            }
        }

        internal virtual Label Label17
        {
            get => this._Label17;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label17 = value;
        }

        internal virtual TextBox txtComp
        {
            get => this._txtComp;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtComp_KeyPress);
                if (this._txtComp != null)
                    this._txtComp.KeyPress -= pressEventHandler;
                this._txtComp = value;
                if (this._txtComp == null)
                    return;
                this._txtComp.KeyPress += pressEventHandler;
            }
        }

        internal virtual Label Label15
        {
            get => this._Label15;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label15 = value;
        }

        internal virtual TextBox txtShowJDed
        {
            get => this._txtShowJDed;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtShowJDed_KeyPress);
                if (this._txtShowJDed != null)
                    this._txtShowJDed.KeyPress -= pressEventHandler;
                this._txtShowJDed = value;
                if (this._txtShowJDed == null)
                    return;
                this._txtShowJDed.KeyPress += pressEventHandler;
            }
        }

        internal virtual Label Label19
        {
            get => this._Label19;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label19 = value;
        }

        internal virtual Label Label21
        {
            get => this._Label21;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label21 = value;
        }

        internal virtual TextBox txtNoJudgeTMV
        {
            get => this._txtNoJudgeTMV;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtNoJudgeTMV_KeyPress);
                if (this._txtNoJudgeTMV != null)
                    this._txtNoJudgeTMV.KeyPress -= pressEventHandler;
                this._txtNoJudgeTMV = value;
                if (this._txtNoJudgeTMV == null)
                    return;
                this._txtNoJudgeTMV.KeyPress += pressEventHandler;
            }
        }

        internal virtual Label Label22
        {
            get => this._Label22;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label22 = value;
        }

        internal virtual TextBox txtScoreBoard
        {
            get => this._txtScoreBoard;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtScoreBoard_KeyPress);
                if (this._txtScoreBoard != null)
                    this._txtScoreBoard.KeyPress -= pressEventHandler;
                this._txtScoreBoard = value;
                if (this._txtScoreBoard == null)
                    return;
                this._txtScoreBoard.KeyPress += pressEventHandler;
            }
        }

        internal virtual Label Label23
        {
            get => this._Label23;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label23 = value;
        }

        internal virtual Label Label24
        {
            get => this._Label24;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label24 = value;
        }

        internal virtual Label Label26
        {
            get => this._Label26;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label26 = value;
        }

        internal virtual TextBox txtPort
        {
            get => this._txtPort;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtPort_KeyPress);
                if (this._txtPort != null)
                    this._txtPort.KeyPress -= pressEventHandler;
                this._txtPort = value;
                if (this._txtPort == null)
                    return;
                this._txtPort.KeyPress += pressEventHandler;
            }
        }

        internal virtual Label lblPort
        {
            get => this._lblPort;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblPort = value;
        }

        internal virtual Label Label29
        {
            get => this._Label29;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label29 = value;
        }

        internal virtual Label Label28
        {
            get => this._Label28;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label28 = value;
        }

        internal virtual Label Label27
        {
            get => this._Label27;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label27 = value;
        }

        internal virtual TextBox txtTopMargin
        {
            get => this._txtTopMargin;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.txtTopMargin_Leave);
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtTopMargin_KeyPress);
                if (this._txtTopMargin != null)
                {
                    this._txtTopMargin.Leave -= eventHandler;
                    this._txtTopMargin.KeyPress -= pressEventHandler;
                }
                this._txtTopMargin = value;
                if (this._txtTopMargin == null)
                    return;
                this._txtTopMargin.Leave += eventHandler;
                this._txtTopMargin.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox txtLeftMargin
        {
            get => this._txtLeftMargin;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.txtLeftMargin_Leave);
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtLeftMargin_KeyPress);
                if (this._txtLeftMargin != null)
                {
                    this._txtLeftMargin.Leave -= eventHandler;
                    this._txtLeftMargin.KeyPress -= pressEventHandler;
                }
                this._txtLeftMargin = value;
                if (this._txtLeftMargin == null)
                    return;
                this._txtLeftMargin.Leave += eventHandler;
                this._txtLeftMargin.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox txtSize
        {
            get => this._txtSize;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.txtSize_Leave);
                if (this._txtSize != null)
                    this._txtSize.Leave -= eventHandler;
                this._txtSize = value;
                if (this._txtSize == null)
                    return;
                this._txtSize.Leave += eventHandler;
            }
        }

        internal virtual Label Label30
        {
            get => this._Label30;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label30 = value;
        }

        internal virtual TextBox txtJD
        {
            get => this._txtJD;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtJD = value;
        }

        internal virtual Label Label31
        {
            get => this._Label31;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label31 = value;
        }

        internal virtual Label Label32
        {
            get => this._Label32;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label32 = value;
        }

        internal virtual Label Label1
        {
            get => this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label1 = value;
        }

        internal virtual TextBox txtDelay
        {
            get => this._txtDelay;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.txtDelay_Leave);
                if (this._txtDelay != null)
                    this._txtDelay.Leave -= eventHandler;
                this._txtDelay = value;
                if (this._txtDelay == null)
                    return;
                this._txtDelay.Leave += eventHandler;
            }
        }

        internal virtual Label Label2
        {
            get => this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label2 = value;
        }

        internal virtual TextBox txtResultsPhone
        {
            get => this._txtResultsPhone;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtResultsPhone_KeyPress);
                if (this._txtResultsPhone != null)
                    this._txtResultsPhone.KeyPress -= pressEventHandler;
                this._txtResultsPhone = value;
                if (this._txtResultsPhone == null)
                    return;
                this._txtResultsPhone.KeyPress += pressEventHandler;
            }
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

        internal virtual Button Button1
        {
            get => this._Button1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Button1_Click);
                if (this._Button1 != null)
                    this._Button1.Click -= eventHandler;
                this._Button1 = value;
                if (this._Button1 == null)
                    return;
                this._Button1.Click += eventHandler;
            }
        }

        internal virtual TextBox txtAdjust
        {
            get => this._txtAdjust;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtAdjust = value;
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

        internal virtual TextBox txtTEScores
        {
            get => this._txtTEScores;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtTEScores_KeyPress);
                if (this._txtTEScores != null)
                    this._txtTEScores.KeyPress -= pressEventHandler;
                this._txtTEScores = value;
                if (this._txtTEScores == null)
                    return;
                this._txtTEScores.KeyPress += pressEventHandler;
            }
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

        internal virtual Label Label14
        {
            get => this._Label14;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label14 = value;
        }

        internal virtual Label Label16
        {
            get => this._Label16;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label16 = value;
        }

        internal virtual TextBox txtPingClients
        {
            get => this._txtPingClients;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtPingClients_KeyPress);
                if (this._txtPingClients != null)
                    this._txtPingClients.KeyPress -= pressEventHandler;
                this._txtPingClients = value;
                if (this._txtPingClients == null)
                    return;
                this._txtPingClients.KeyPress += pressEventHandler;
            }
        }

        internal virtual Label Label18
        {
            get => this._Label18;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label18 = value;
        }

        internal virtual Label Label20
        {
            get => this._Label20;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label20 = value;
        }

        internal virtual TextBox txtPingTimeout
        {
            get => this._txtPingTimeout;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.txtPingTimeout_Leave);
                if (this._txtPingTimeout != null)
                    this._txtPingTimeout.Leave -= eventHandler;
                this._txtPingTimeout = value;
                if (this._txtPingTimeout == null)
                    return;
                this._txtPingTimeout.Leave += eventHandler;
            }
        }

        internal virtual Label Label25
        {
            get => this._Label25;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label25 = value;
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Program.PathCompFile = this.txtComp.Text;
            Program.PathResultsFile = this.txtResults.Text;
            Program.CreateResultsPhone = Conversions.ToInteger(this.txtResultsPhone.Text);
            Program.CreateTEScores = Conversions.ToInteger(this.txtTEScores.Text);
            Program.IceLeaveTime = this.txtIceleave.Text;
            Program.ResurfacingTime = this.txtResurfacing.Text;
            Program.LunchTime = this.txtMeal.Text;
            Program.ShowJudgeDed = Conversions.ToInteger(this.txtShowJDed.Text);
            Program.NoJudgeTMV = Conversions.ToDouble(this.txtNoJudgeTMV.Text) != 0.0 ? Conversions.ToInteger(this.txtNoJudgeTMV.Text) : 9;
            Program.CreateScoreBoard = Conversions.ToInteger(this.txtScoreBoard.Text);
            Program.ScoreBoardDelay = !(Decimal.Compare(Convert.ToDecimal(this.txtDelay.Text), 0M) < 0 | Decimal.Compare(Convert.ToDecimal(this.txtDelay.Text), 60M) > 0) ? Convert.ToInt32(Conversions.ToDecimal(this.txtDelay.Text)) : this.OldScoreboardDelay;
            Program.PortNo = Conversions.ToInteger(this.txtPort.Text);
            Program.PingClients = Conversions.ToInteger(this.txtPingClients.Text);
            MyProject.Forms.MainForm.Timer3.Enabled = Program.PingClients == 1;
            Program.PingTimeout = Conversions.ToInteger(this.txtPingTimeout.Text);
            if (Program.PingTimeout < 500 | Program.PingTimeout > 1500)
                Program.PingTimeout = 1000;
            Program.AdjustToScreen = Operators.CompareString(this.txtAdjust.Text, "ON", false) != 0 ? 0 : 1;
            Program.Page_Size = !(Decimal.Compare(Convert.ToDecimal(this.txtSize.Text), 75M) < 0 | Decimal.Compare(Convert.ToDecimal(this.txtSize.Text), 125M) > 0) ? Convert.ToDouble(Conversions.ToDecimal(this.txtSize.Text)) : Convert.ToDouble(this.OldSize);
            Program.Page_Left_Margin = !(Decimal.Compare(Convert.ToDecimal(this.txtLeftMargin.Text), 0M) < 0 | Decimal.Compare(Convert.ToDecimal(this.txtLeftMargin.Text), 100M) > 0) ? Conversions.ToInteger(this.txtLeftMargin.Text) : this.OldLeftMargin;
            Program.Page_Top_Margin = !(Decimal.Compare(Convert.ToDecimal(this.txtTopMargin.Text), 0M) < 0 | Decimal.Compare(Convert.ToDecimal(this.txtTopMargin.Text), 100M) > 0) ? Conversions.ToInteger(this.txtTopMargin.Text) : this.OldTopMargin;
            Program.SaveIniData("CLUBCOMP.INI");
            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Program.AdjustToScreen = this.Old_AdjustToScreen;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ConfigurationDataDialog_Load(object sender, EventArgs e)
        {
            this.Top = MyProject.Forms.MainForm.Top;
            this.Left = checked((int)Math.Round(unchecked((double)MyProject.Forms.MainForm.Left + (double)MyProject.Forms.MainForm.Width / 2.0 - (double)this.Width / 2.0)));
            this.TopMost = true;
            this.txtComp.Text = Program.PathCompFile;
            this.txtResults.Text = Program.PathResultsFile;
            this.txtResultsPhone.Text = Conversions.ToString(Program.CreateResultsPhone);
            this.txtTEScores.Text = Conversions.ToString(Program.CreateTEScores);
            this.txtIceleave.Text = Program.IceLeaveTime;
            this.OldIceLeave = Program.IceLeaveTime;
            this.txtResurfacing.Text = Program.ResurfacingTime;
            this.OldResurfacing = Program.ResurfacingTime;
            this.txtMeal.Text = Program.LunchTime;
            this.OldMeal = Program.LunchTime;
            this.txtShowJDed.Text = Conversions.ToString(Program.ShowJudgeDed);
            this.OldShowJDed = Conversions.ToString(Program.ShowJudgeDed);
            this.txtNoJudgeTMV.Text = Program.NoJudgeTMV != 9 ? Conversions.ToString(Program.NoJudgeTMV) : Conversions.ToString(0);
            this.OldNoJudgeTMV = Conversions.ToString(Program.NoJudgeTMV);
            this.txtScoreBoard.Text = Conversions.ToString(Program.CreateScoreBoard);
            this.OldCreateScoreBoard = Conversions.ToString(Program.CreateScoreBoard);
            this.txtDelay.Text = Conversions.ToString(Program.ScoreBoardDelay);
            this.OldScoreboardDelay = Program.ScoreBoardDelay;
            this.txtPort.Text = Conversions.ToString(Program.PortNo);
            this.txtPingClients.Text = Conversions.ToString(Program.PingClients);
            this.Old_PingClients = Program.PingClients;
            this.txtPingTimeout.Text = Conversions.ToString(Program.PingTimeout);
            this.Old_PingTimeout = Program.PingTimeout;
            this.txtSize.Text = Conversions.ToString(Program.Page_Size);
            this.OldSize = new Decimal(Program.Page_Size);
            this.txtLeftMargin.Text = Conversions.ToString(Program.Page_Left_Margin);
            this.OldLeftMargin = Program.Page_Left_Margin;
            this.txtTopMargin.Text = Conversions.ToString(Program.Page_Top_Margin);
            this.OldTopMargin = Program.Page_Top_Margin;
            this.Old_AdjustToScreen = Program.AdjustToScreen;
            switch (Program.AdjustToScreen)
            {
                case 0:
                    this.txtAdjust.Text = "OFF";
                    break;
                case 1:
                    this.txtAdjust.Text = "ON";
                    break;
            }
        }

        private void txtComp_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\n':
                case '\r':
                case '!':
                case '"':
                case '&':
                //case '\'':   // enable apostrophe for Competition name
                case '*':
                case '+':
                case ',':
                case '/':
                case ';':
                case '<':
                case '>':
                case '?':
                case '[':
                case ']':
                case '~':
                    e.Handled = true;
                    break;
            }
        }

        private void txtResults_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\n':
                case '\r':
                case '!':
                case '"':
                case '&':
                //case '\'':   // enable apostrophe for Results name
                case '*':
                case '+':
                case ',':
                case '/':
                case ';':
                case '<':
                case '>':
                case '?':
                case '[':
                case ']':
                case '~':
                    e.Handled = true;
                    break;
            }
        }

        private void txtIceleave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ':' || e.KeyChar == '\b' || e.KeyChar == '\u007F')
                return;
            e.Handled = true;
        }

        private void txtIceleave_Leave(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(this.txtIceleave.Text, "HH:mm:ss", (IFormatProvider)null, DateTimeStyles.NoCurrentDateDefault, out DateTime _))
                return;
            int num = (int)MessageBox.Show("Enter a valid time e.g. 00:02:30");
            this.txtIceleave.Text = this.OldIceLeave;
        }

        private void txtResurfacing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ':' || e.KeyChar == '\b' || e.KeyChar == '\u007F')
                return;
            e.Handled = true;
        }

        private void txtResurfacing_Leave(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(this.txtResurfacing.Text, "HH:mm:ss", (IFormatProvider)null, DateTimeStyles.NoCurrentDateDefault, out DateTime _))
                return;
            int num = (int)MessageBox.Show("Enter a valid time e.g. 00:02:30");
            this.txtResurfacing.Text = this.OldResurfacing;
        }

        private void txtMeal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ':' || e.KeyChar == '\b' || e.KeyChar == '\u007F')
                return;
            e.Handled = true;
        }

        private void txtMeal_Leave(object sender, EventArgs e)
        {
            if (DateTime.TryParseExact(this.txtMeal.Text, "HH:mm:ss", (IFormatProvider)null, DateTimeStyles.NoCurrentDateDefault, out DateTime _))
                return;
            int num = (int)MessageBox.Show("Enter a valid time e.g. 00:02:30");
            this.txtMeal.Text = this.OldMeal;
        }

        private void txtShowJDed_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void txtNoJudgeTMV_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '5':
                case '7':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void txtScoreBoard_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar)))
                return;
            e.Handled = true;
        }

        private void txtSize_Leave(object sender, EventArgs e)
        {
            if (!(Decimal.Compare(Convert.ToDecimal(this.txtSize.Text), 75M) < 0 | Decimal.Compare(Convert.ToDecimal(this.txtSize.Text), 125M) > 0))
                return;
            int num = (int)MessageBox.Show("Valid Data: 75~125");
            this.txtSize.Text = Conversions.ToString(this.OldSize);
        }

        private void txtLeftMargin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar)))
                return;
            e.Handled = true;
        }

        private void txtLeftMargin_Leave(object sender, EventArgs e)
        {
            if (!(Decimal.Compare(Convert.ToDecimal(this.txtLeftMargin.Text), 0M) < 0 | Decimal.Compare(Convert.ToDecimal(this.txtLeftMargin.Text), 100M) > 0))
                return;
            int num = (int)MessageBox.Show("Valid Data: 00~100");
            this.txtLeftMargin.Text = Conversions.ToString(this.OldLeftMargin);
        }

        private void txtTopMargin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar)))
                return;
            e.Handled = true;
        }

        private void txtTopMargin_Leave(object sender, EventArgs e)
        {
            if (!(Decimal.Compare(Convert.ToDecimal(this.txtTopMargin.Text), 0M) < 0 | Decimal.Compare(Convert.ToDecimal(this.txtTopMargin.Text), 100M) > 0))
                return;
            int num = (int)MessageBox.Show("Valid Data: 00~100");
            this.txtTopMargin.Text = Conversions.ToString(this.OldTopMargin);
        }

        private void txtDelay_Leave(object sender, EventArgs e)
        {
            if (!(Decimal.Compare(Convert.ToDecimal(this.txtDelay.Text), 0M) < 0 | Decimal.Compare(Convert.ToDecimal(this.txtDelay.Text), 60M) > 0))
                return;
            int num = (int)MessageBox.Show("Valid Data: 00~60");
            this.txtDelay.Text = Conversions.ToString(this.OldScoreboardDelay);
        }

        private void txtResultsPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            switch (Program.AdjustToScreen)
            {
                case 0:
                    this.txtAdjust.Text = "ON";
                    Program.AdjustToScreen = 1;
                    break;
                case 1:
                    this.txtAdjust.Text = "OFF";
                    Program.AdjustToScreen = 0;
                    break;
            }
        }

        private void txtTEScores_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void txtPingClients_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                case '1':
                    e.Handled = false;
                    break;
                default:
                    e.Handled = true;
                    break;
            }
        }

        private void txtPingTimeout_Leave(object sender, EventArgs e)
        {
            if (!(Decimal.Compare(Convert.ToDecimal(this.txtPingTimeout.Text), 500M) < 0 | Decimal.Compare(Convert.ToDecimal(this.txtPingTimeout.Text), 1500M) > 0))
                return;
            int num = (int)MessageBox.Show("Valid Data: 500-1500");
            this.txtPingTimeout.Text = Conversions.ToString(this.Old_PingTimeout);
        }
    }
}

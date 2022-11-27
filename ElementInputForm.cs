// Decompiled with JetBrains decompiler
// Type: ClubCompFS.ElementInputForm
// Assembly: ClubCompFS_10p0p6, Version=1.0.0.6, Culture=neutral, PublicKeyToken=null
// MVID: F1E583B2-A781-4EC4-B47C-BA3F451903AE
// Assembly location: E:\zz Personal_Doc\Personal\Cinzia\programmaLibertas_openNEW\ClubCompFS_10p0p6.exe

using ClubCompFS.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ClubCompFS
{
    [DesignerGenerated]
    public class ElementInputForm : Form
    {
        #region Private Properties
        private IContainer components;
        [AccessedThroughProperty("OpStop")]
        private Button _OpStop;
        [AccessedThroughProperty("OpName")]
        private TextBox _OpName;
        [AccessedThroughProperty("OpClub")]
        private TextBox _OpClub;
        [AccessedThroughProperty("PictureBox1")]
        private PictureBox _PictureBox1;
        [AccessedThroughProperty("Axel")]
        private Button _Axel;
        [AccessedThroughProperty("ToeLoop")]
        private Button _ToeLoop;
        [AccessedThroughProperty("PictureBox2")]
        private PictureBox _PictureBox2;
        [AccessedThroughProperty("LoopText")]
        private Button _LoopText;
        [AccessedThroughProperty("PictureBox3")]
        private PictureBox _PictureBox3;
        [AccessedThroughProperty("Flip")]
        private Button _Flip;
        [AccessedThroughProperty("PictureBox4")]
        private PictureBox _PictureBox4;
        [AccessedThroughProperty("Lutz")]
        private Button _Lutz;
        [AccessedThroughProperty("PictureBox5")]
        private PictureBox _PictureBox5;
        [AccessedThroughProperty("Salchow")]
        private Button _Salchow;
        [AccessedThroughProperty("PictureBox6")]
        private PictureBox _PictureBox6;
        [AccessedThroughProperty("OpA1")]
        private Button _OpA1;
        [AccessedThroughProperty("OpA2")]
        private Button _OpA2;
        [AccessedThroughProperty("OpA3")]
        private Button _OpA3;
        [AccessedThroughProperty("OpA4")]
        private Button _OpA4;
        [AccessedThroughProperty("OpUR")]
        private Button _OpUR;
        [AccessedThroughProperty("OpSEQ")]
        private Button _OpSEQ;
        [AccessedThroughProperty("OpCOMBO")]
        private Button _OpCOMBO;
        [AccessedThroughProperty("OpDG")]
        private Button _OpDG;
        [AccessedThroughProperty("OpQ")]
        private Button _OpQ;
        [AccessedThroughProperty("Edge")]
        private Button _Edge;
        [AccessedThroughProperty("Zero")]
        private Button _Zero;
        [AccessedThroughProperty("Sit")]
        private Button _Sit;
        [AccessedThroughProperty("PictureBox7")]
        private PictureBox _PictureBox7;
        [AccessedThroughProperty("OpSSp4")]
        private Button _OpSSp4;
        [AccessedThroughProperty("OpSSp3")]
        private Button _OpSSp3;
        [AccessedThroughProperty("OpSSp2")]
        private Button _OpSSp2;
        [AccessedThroughProperty("OpSSp1")]
        private Button _OpSSp1;
        [AccessedThroughProperty("OpSSp0")]
        private Button _OpSSp0;
        [AccessedThroughProperty("OpLSp0")]
        private Button _OpLSp0;
        [AccessedThroughProperty("OpLSp4")]
        private Button _OpLSp4;
        [AccessedThroughProperty("OpLSp3")]
        private Button _OpLSp3;
        [AccessedThroughProperty("OpLSp2")]
        private Button _OpLSp2;
        [AccessedThroughProperty("OpLSp1")]
        private Button _OpLSp1;
        [AccessedThroughProperty("PictureBox8")]
        private PictureBox _PictureBox8;
        [AccessedThroughProperty("Layback")]
        private Button _Layback;
        [AccessedThroughProperty("OpUSp0")]
        private Button _OpUSp0;
        [AccessedThroughProperty("OpUSp4")]
        private Button _OpUSp4;
        [AccessedThroughProperty("OpUSp3")]
        private Button _OpUSp3;
        [AccessedThroughProperty("OpUSp2")]
        private Button _OpUSp2;
        [AccessedThroughProperty("OpUSp1")]
        private Button _OpUSp1;
        [AccessedThroughProperty("PictureBox9")]
        private PictureBox _PictureBox9;
        [AccessedThroughProperty("Upright")]
        private Button _Upright;
        [AccessedThroughProperty("OpCSp0")]
        private Button _OpCSp0;
        [AccessedThroughProperty("OpCSp4")]
        private Button _OpCSp4;
        [AccessedThroughProperty("OpCSp3")]
        private Button _OpCSp3;
        [AccessedThroughProperty("OpCSp2")]
        private Button _OpCSp2;
        [AccessedThroughProperty("OpCSp1")]
        private Button _OpCSp1;
        [AccessedThroughProperty("PictureBox10")]
        private PictureBox _PictureBox10;
        [AccessedThroughProperty("Camel")]
        private Button _Camel;
        [AccessedThroughProperty("OpCoSp0")]
        private Button _OpCoSp0;
        [AccessedThroughProperty("OpCoSp4")]
        private Button _OpCoSp4;
        [AccessedThroughProperty("OpCoSp3")]
        private Button _OpCoSp3;
        [AccessedThroughProperty("OpCoSp2")]
        private Button _OpCoSp2;
        [AccessedThroughProperty("OpCoSp1")]
        private Button _OpCoSp1;
        [AccessedThroughProperty("PictureBox11")]
        private PictureBox _PictureBox11;
        [AccessedThroughProperty("ComboSpin")]
        private Button _ComboSpin;
        [AccessedThroughProperty("OpChange")]
        private Button _OpChange;
        [AccessedThroughProperty("OpFlying")]
        private Button _OpFlying;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("ChSq1")]
        private Button _ChSq1;
        [AccessedThroughProperty("ChoreoSeq")]
        private Button _ChoreoSeq;
        [AccessedThroughProperty("PictureBox12")]
        private PictureBox _PictureBox12;
        [AccessedThroughProperty("OpStSq0")]
        private Button _OpStSq0;
        [AccessedThroughProperty("OpStSq4")]
        private Button _OpStSq4;
        [AccessedThroughProperty("OpStSq3")]
        private Button _OpStSq3;
        [AccessedThroughProperty("OpStSq2")]
        private Button _OpStSq2;
        [AccessedThroughProperty("OpStSq1")]
        private Button _OpStSq1;
        [AccessedThroughProperty("PictureBox13")]
        private PictureBox _PictureBox13;
        [AccessedThroughProperty("Straight")]
        private Button _Straight;
        [AccessedThroughProperty("OpNext1")]
        private Button _OpNext1;
        [AccessedThroughProperty("OpDeleteRow")]
        private Button _OpDeleteRow;
        [AccessedThroughProperty("OpInsert")]
        private Button _OpInsert;
        [AccessedThroughProperty("OpClearEntry")]
        private Button _OpClearEntry;
        [AccessedThroughProperty("Review")]
        private Button _Review;
        [AccessedThroughProperty("Falls_minus")]
        private Button _Falls_minus;
        [AccessedThroughProperty("Falls")]
        private Button _Falls;
        [AccessedThroughProperty("Falls_out")]
        private Button _Falls_out;
        [AccessedThroughProperty("OpT4")]
        private Button _OpT4;
        [AccessedThroughProperty("OpT3")]
        private Button _OpT3;
        [AccessedThroughProperty("OpT2")]
        private Button _OpT2;
        [AccessedThroughProperty("OpT1")]
        private Button _OpT1;
        [AccessedThroughProperty("OpL4")]
        private Button _OpL4;
        [AccessedThroughProperty("OpL3")]
        private Button _OpL3;
        [AccessedThroughProperty("OpL2")]
        private Button _OpL2;
        [AccessedThroughProperty("OpL1")]
        private Button _OpL1;
        [AccessedThroughProperty("OpF4")]
        private Button _OpF4;
        [AccessedThroughProperty("OpF3")]
        private Button _OpF3;
        [AccessedThroughProperty("OpF2")]
        private Button _OpF2;
        [AccessedThroughProperty("OpF1")]
        private Button _OpF1;
        [AccessedThroughProperty("OpLz4")]
        private Button _OpLz4;
        [AccessedThroughProperty("OpLz3")]
        private Button _OpLz3;
        [AccessedThroughProperty("OpLz2")]
        private Button _OpLz2;
        [AccessedThroughProperty("OpLz1")]
        private Button _OpLz1;
        [AccessedThroughProperty("OpS4")]
        private Button _OpS4;
        [AccessedThroughProperty("OpS3")]
        private Button _OpS3;
        [AccessedThroughProperty("OpS2")]
        private Button _OpS2;
        [AccessedThroughProperty("OpS1")]
        private Button _OpS1;
        [AccessedThroughProperty("HalfTime")]
        private Button _HalfTime;
        [AccessedThroughProperty("StartHT")]
        private Button _StartHT;
        [AccessedThroughProperty("StopHT")]
        private Button _StopHT;
        [AccessedThroughProperty("Bonus_minus")]
        private Button _Bonus_minus;
        [AccessedThroughProperty("Bonus_plus")]
        private Button _Bonus_plus;
        [AccessedThroughProperty("Bonus")]
        private Button _Bonus;
        [AccessedThroughProperty("OpMsg")]
        private TextBox _OpMsg;
        [AccessedThroughProperty("Set0")]
        private Button _Set0;
        [AccessedThroughProperty("Set4")]
        private Button _Set4;
        [AccessedThroughProperty("Set3")]
        private Button _Set3;
        [AccessedThroughProperty("Set2")]
        private Button _Set2;
        [AccessedThroughProperty("Set1")]
        private Button _Set1;
        [AccessedThroughProperty("NoLevel")]
        private Button _NoLevel;
        [AccessedThroughProperty("ColorBox")]
        private Label _ColorBox;
        [AccessedThroughProperty("DataGridView1")]
        private DataGridView _DataGridView1;
        [AccessedThroughProperty("Time")]
        private Button _Time;
        [AccessedThroughProperty("Timer1")]
        private Timer _Timer1;
        [AccessedThroughProperty("OpExcl")]
        private Button _OpExcl;
        [AccessedThroughProperty("OpFallinElement")]
        private Button _OpFallinElement;
        [AccessedThroughProperty("Spin_V")]
        private Button _Spin_V;
        [AccessedThroughProperty("opREP")]
        private Button _opREP;
        [AccessedThroughProperty("Column1")]
        private DataGridViewTextBoxColumn _Column1;
        [AccessedThroughProperty("Column2")]
        private DataGridViewTextBoxColumn _Column2;
        [AccessedThroughProperty("Column3")]
        private DataGridViewTextBoxColumn _Column3;
        [AccessedThroughProperty("Column4")]
        private DataGridViewTextBoxColumn _Column4;
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
        [AccessedThroughProperty("btnDED")]
        private Button _btnDED;
        [AccessedThroughProperty("txtInfo2")]
        private TextBox _txtInfo2;
        [AccessedThroughProperty("OpEu1")]
        private Button _OpEu1;
        [AccessedThroughProperty("Euler")]
        private Button _Euler;
        [AccessedThroughProperty("OpW1")]
        private Button _OpW1;
        [AccessedThroughProperty("Waltz")]
        private Button _Waltz;
        [AccessedThroughProperty("PictureBox14")]
        private PictureBox _PictureBox14;
        [AccessedThroughProperty("PictureBox15")]
        private PictureBox _PictureBox15;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        private int index;
        private int ClrDelInsR;
        private int ProgramHalfTime;
        private int Tid;
        private string[] Jarr;
        public bool WillExit;
        private ArrayList CtlArray;

        #endregion // end - Private Properties

        public ElementInputForm()
        {
            this.FormClosing += new FormClosingEventHandler(this.ElementInputForm_Closing);
            this.Load += new EventHandler(this.ElementInputForm_Load);
            this.Jarr = new string[61];
            this.WillExit = false;
            this.CtlArray = new ArrayList();
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ElementInputForm));
            this.OpStop = new Button();
            this.OpName = new TextBox();
            this.OpClub = new TextBox();
            this.Axel = new Button();
            this.ToeLoop = new Button();
            this.LoopText = new Button();
            this.Flip = new Button();
            this.Lutz = new Button();
            this.Salchow = new Button();
            this.OpA1 = new Button();
            this.OpA2 = new Button();
            this.OpA3 = new Button();
            this.OpA4 = new Button();
            this.OpUR = new Button();
            this.OpSEQ = new Button();
            this.OpCOMBO = new Button();
            this.OpDG = new Button();
            this.OpQ = new Button();
            this.Edge = new Button();
            this.Zero = new Button();
            this.Sit = new Button();
            this.OpSSp4 = new Button();
            this.OpSSp3 = new Button();
            this.OpSSp2 = new Button();
            this.OpSSp1 = new Button();
            this.OpSSp0 = new Button();
            this.OpLSp0 = new Button();
            this.OpLSp4 = new Button();
            this.OpLSp3 = new Button();
            this.OpLSp2 = new Button();
            this.OpLSp1 = new Button();
            this.Layback = new Button();
            this.OpUSp0 = new Button();
            this.OpUSp4 = new Button();
            this.OpUSp3 = new Button();
            this.OpUSp2 = new Button();
            this.OpUSp1 = new Button();
            this.Upright = new Button();
            this.OpCSp0 = new Button();
            this.OpCSp4 = new Button();
            this.OpCSp3 = new Button();
            this.OpCSp2 = new Button();
            this.OpCSp1 = new Button();
            this.Camel = new Button();
            this.OpCoSp0 = new Button();
            this.OpCoSp4 = new Button();
            this.OpCoSp3 = new Button();
            this.OpCoSp2 = new Button();
            this.OpCoSp1 = new Button();
            this.ComboSpin = new Button();
            this.OpChange = new Button();
            this.OpFlying = new Button();
            this.Label1 = new Label();
            this.Label3 = new Label();
            this.ChSq1 = new Button();
            this.ChoreoSeq = new Button();
            this.OpStSq0 = new Button();
            this.OpStSq4 = new Button();
            this.OpStSq3 = new Button();
            this.OpStSq2 = new Button();
            this.OpStSq1 = new Button();
            this.Straight = new Button();
            this.OpNext1 = new Button();
            this.OpDeleteRow = new Button();
            this.OpInsert = new Button();
            this.OpClearEntry = new Button();
            this.Review = new Button();
            this.Falls_minus = new Button();
            this.Falls = new Button();
            this.Falls_out = new Button();
            this.OpT4 = new Button();
            this.OpT3 = new Button();
            this.OpT2 = new Button();
            this.OpT1 = new Button();
            this.OpL4 = new Button();
            this.OpL3 = new Button();
            this.OpL2 = new Button();
            this.OpL1 = new Button();
            this.OpF4 = new Button();
            this.OpF3 = new Button();
            this.OpF2 = new Button();
            this.OpF1 = new Button();
            this.OpLz4 = new Button();
            this.OpLz3 = new Button();
            this.OpLz2 = new Button();
            this.OpLz1 = new Button();
            this.OpS4 = new Button();
            this.OpS3 = new Button();
            this.OpS2 = new Button();
            this.OpS1 = new Button();
            this.HalfTime = new Button();
            this.StartHT = new Button();
            this.StopHT = new Button();
            this.Bonus_minus = new Button();
            this.Bonus_plus = new Button();
            this.Bonus = new Button();
            this.OpMsg = new TextBox();
            this.Set0 = new Button();
            this.Set4 = new Button();
            this.Set3 = new Button();
            this.Set2 = new Button();
            this.Set1 = new Button();
            this.NoLevel = new Button();
            this.ColorBox = new Label();
            this.DataGridView1 = new DataGridView();
            this.Column1 = new DataGridViewTextBoxColumn();
            this.Column2 = new DataGridViewTextBoxColumn();
            this.Column3 = new DataGridViewTextBoxColumn();
            this.Column4 = new DataGridViewTextBoxColumn();
            this.Time = new Button();
            this.Timer1 = new Timer(this.components);
            this.OpExcl = new Button();
            this.OpFallinElement = new Button();
            this.Spin_V = new Button();
            this.opREP = new Button();
            this.PictureBox13 = new PictureBox();
            this.PictureBox12 = new PictureBox();
            this.PictureBox11 = new PictureBox();
            this.PictureBox10 = new PictureBox();
            this.PictureBox9 = new PictureBox();
            this.PictureBox8 = new PictureBox();
            this.PictureBox7 = new PictureBox();
            this.PictureBox6 = new PictureBox();
            this.PictureBox5 = new PictureBox();
            this.PictureBox4 = new PictureBox();
            this.PictureBox3 = new PictureBox();
            this.PictureBox2 = new PictureBox();
            this.PictureBox1 = new PictureBox();
            this.Panel1 = new Panel();
            this.txtInfo2 = new TextBox();
            this.txtInfo = new TextBox();
            this.txtEl = new TextBox();
            this.txtj7 = new TextBox();
            this.txtJ4 = new TextBox();
            this.txtJ3 = new TextBox();
            this.txtJ2 = new TextBox();
            this.txtJ6 = new TextBox();
            this.txtJ5 = new TextBox();
            this.txtJ1 = new TextBox();
            this.btnDED = new Button();
            this.OpEu1 = new Button();
            this.Euler = new Button();
            this.OpW1 = new Button();
            this.Waltz = new Button();
            this.PictureBox14 = new PictureBox();
            this.PictureBox15 = new PictureBox();
            this.Label2 = new Label();
            ((ISupportInitialize)this.DataGridView1).BeginInit();
            ((ISupportInitialize)this.PictureBox13).BeginInit();
            ((ISupportInitialize)this.PictureBox12).BeginInit();
            ((ISupportInitialize)this.PictureBox11).BeginInit();
            ((ISupportInitialize)this.PictureBox10).BeginInit();
            ((ISupportInitialize)this.PictureBox9).BeginInit();
            ((ISupportInitialize)this.PictureBox8).BeginInit();
            ((ISupportInitialize)this.PictureBox7).BeginInit();
            ((ISupportInitialize)this.PictureBox6).BeginInit();
            ((ISupportInitialize)this.PictureBox5).BeginInit();
            ((ISupportInitialize)this.PictureBox4).BeginInit();
            ((ISupportInitialize)this.PictureBox3).BeginInit();
            ((ISupportInitialize)this.PictureBox2).BeginInit();
            ((ISupportInitialize)this.PictureBox1).BeginInit();
            this.Panel1.SuspendLayout();
            ((ISupportInitialize)this.PictureBox14).BeginInit();
            this.SuspendLayout();
            ((ISupportInitialize)this.PictureBox15).BeginInit();
            this.SuspendLayout();
            this.OpStop.BackColor = Color.Red;
            this.OpStop.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpStop.Location = new Point(1, 0);
            this.OpStop.Name = "OpStop";
            Button opStop = this.OpStop;
            Size size1 = new Size(88, 74);
            Size size2 = size1;
            opStop.Size = size2;
            this.OpStop.TabIndex = 0;
            this.OpStop.Text = "EXIT";
            this.OpStop.UseVisualStyleBackColor = false;
            this.OpName.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpName.Location = new Point(89, 1);
            this.OpName.Multiline = true;
            this.OpName.Name = "OpName";
            TextBox opName = this.OpName;
            size1 = new Size(225, 37);
            Size size3 = size1;
            opName.Size = size3;
            this.OpName.TabIndex = 1;
            this.OpName.Text = "Name";
            this.OpClub.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpClub.Location = new Point(89, 38);
            this.OpClub.Multiline = true;
            this.OpClub.Name = "OpClub";
            TextBox opClub = this.OpClub;
            size1 = new Size(225, 37);
            Size size4 = size1;
            opClub.Size = size4;
            this.OpClub.TabIndex = 2;
            this.OpClub.Text = "Club";
            this.Axel.BackColor = Color.FromArgb(192, 192, 0);
            this.Axel.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Axel.Location = new Point(2, 115);
            this.Axel.Name = "Axel";
            Button axel = this.Axel;
            size1 = new Size(134, 38);
            Size size5 = size1;
            axel.Size = size5;
            this.Axel.TabIndex = 4;
            this.Axel.Text = "AXEL\r\n(A)";
            this.Axel.UseVisualStyleBackColor = false;
            this.ToeLoop.BackColor = Color.FromArgb(224, 224, 224);
            this.ToeLoop.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ToeLoop.Location = new Point(2, 155);
            this.ToeLoop.Name = "ToeLoop";
            Button toeLoop = this.ToeLoop;
            size1 = new Size(134, 38);
            Size size6 = size1;
            toeLoop.Size = size6;
            this.ToeLoop.TabIndex = 6;
            this.ToeLoop.Text = "TOE LOOP\r\n(T)";
            this.ToeLoop.UseVisualStyleBackColor = false;
            this.LoopText.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.LoopText.Location = new Point(2, 195);
            this.LoopText.Name = "LoopText";
            Button loopText = this.LoopText;
            size1 = new Size(134, 38);
            Size size7 = size1;
            loopText.Size = size7;
            this.LoopText.TabIndex = 8;
            this.LoopText.Text = "LOOP\r\n(Lo)";
            this.LoopText.UseVisualStyleBackColor = true;
            this.Flip.BackColor = Color.DarkBlue;
            this.Flip.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Flip.ForeColor = Color.White;
            this.Flip.Location = new Point(2, 235);
            this.Flip.Name = "Flip";
            Button flip = this.Flip;
            size1 = new Size(134, 38);
            Size size8 = size1;
            flip.Size = size8;
            this.Flip.TabIndex = 10;
            this.Flip.Text = "FLIP\r\n(F)";
            this.Flip.UseVisualStyleBackColor = false;
            this.Lutz.BackColor = Color.FromArgb(128, (int)byte.MaxValue, (int)byte.MaxValue);
            this.Lutz.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Lutz.Location = new Point(2, 275);
            this.Lutz.Name = "Lutz";
            Button lutz = this.Lutz;
            size1 = new Size(134, 38);
            Size size9 = size1;
            lutz.Size = size9;
            this.Lutz.TabIndex = 12;
            this.Lutz.Text = "LUTZ\r\n(Lz)\r\n";
            this.Lutz.UseVisualStyleBackColor = false;
            this.Salchow.BackColor = Color.FromArgb(192, 0, 192);
            this.Salchow.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Salchow.Location = new Point(2, 315);
            this.Salchow.Name = "Salchow";
            Button salchow = this.Salchow;
            size1 = new Size(134, 38);
            Size size10 = size1;
            salchow.Size = size10;
            this.Salchow.TabIndex = 14;
            this.Salchow.Text = "SALCHOW\r\n(S)";
            this.Salchow.UseVisualStyleBackColor = false;
            this.OpA1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpA1.Location = new Point(192, 115);
            this.OpA1.Name = "OpA1";
            Button opA1 = this.OpA1;
            size1 = new Size(30, 38);
            Size size11 = size1;
            opA1.Size = size11;
            this.OpA1.TabIndex = 15;
            this.OpA1.Text = "1";
            this.OpA1.UseVisualStyleBackColor = true;
            this.OpA2.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpA2.Location = new Point(222, 115);
            this.OpA2.Name = "OpA2";
            Button opA2 = this.OpA2;
            size1 = new Size(30, 38);
            Size size12 = size1;
            opA2.Size = size12;
            this.OpA2.TabIndex = 16;
            this.OpA2.Text = "2";
            this.OpA2.UseVisualStyleBackColor = true;
            this.OpA3.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpA3.Location = new Point(252, 115);
            this.OpA3.Name = "OpA3";
            Button opA3 = this.OpA3;
            size1 = new Size(30, 38);
            Size size13 = size1;
            opA3.Size = size13;
            this.OpA3.TabIndex = 17;
            this.OpA3.Text = "3";
            this.OpA3.UseVisualStyleBackColor = true;
            this.OpA4.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpA4.Location = new Point(282, 115);
            this.OpA4.Name = "OpA4";
            Button opA4 = this.OpA4;
            size1 = new Size(30, 38);
            Size size14 = size1;
            opA4.Size = size14;
            this.OpA4.TabIndex = 18;
            this.OpA4.Text = "4";
            this.OpA4.UseVisualStyleBackColor = true;
            this.OpUR.BackColor = Color.FromArgb((int)byte.MaxValue, 128, (int)byte.MaxValue);
            this.OpUR.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpUR.Location = new Point(320, 1);
            this.OpUR.Name = "OpUR";
            Button opUr = this.OpUR;
            size1 = new Size(56, 37);
            Size size15 = size1;
            opUr.Size = size15;
            this.OpUR.TabIndex = 19;
            this.OpUR.Text = "U-ROT\r\n<";
            this.OpUR.UseVisualStyleBackColor = false;
            this.OpSEQ.BackColor = Color.FromArgb(128, 64, 0);
            this.OpSEQ.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpSEQ.ForeColor = Color.White;
            this.OpSEQ.Location = new Point(320, 39);
            this.OpSEQ.Name = "OpSEQ";
            Button opSeq = this.OpSEQ;
            size1 = new Size(56, 37);
            Size size16 = size1;
            opSeq.Size = size16;
            this.OpSEQ.TabIndex = 20;
            this.OpSEQ.Text = "SEQ.";
            this.OpSEQ.UseVisualStyleBackColor = false;
            this.OpCOMBO.BackColor = Color.FromArgb((int)byte.MaxValue, 128, (int)byte.MaxValue);
            this.OpCOMBO.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpCOMBO.Location = new Point(450, 39);
            this.OpCOMBO.Name = "OpCOMBO";
            Button opCombo = this.OpCOMBO;
            size1 = new Size(74, 37);
            Size size17 = size1;
            opCombo.Size = size17;
            this.OpCOMBO.TabIndex = 21;
            this.OpCOMBO.Text = "COMBO";
            this.OpCOMBO.UseVisualStyleBackColor = false;
            this.OpDG.BackColor = Color.Yellow;
            this.OpDG.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpDG.Location = new Point(378, 1);
            this.OpDG.Name = "OpDG";
            Button opDg = this.OpDG;
            size1 = new Size(71, 37);
            Size size18 = size1;
            opDg.Size = size18;
            this.OpDG.TabIndex = 22;
            this.OpDG.Text = "D-GRADE\r\n<<";
            this.OpDG.UseVisualStyleBackColor = false;

            this.OpQ.BackColor = Color.FromArgb(128, 64, 0);
            this.OpQ.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpQ.ForeColor = Color.White;
            this.OpQ.Location = new Point(450, 1);
            this.OpQ.Name = "QUART";
            Button opQ = this.OpQ;
            opQ.Size = new Size(37, 37); // (74, 37)
            this.OpQ.TabIndex = 168;
            this.OpQ.Text = "q";
            this.OpQ.UseVisualStyleBackColor = false;

            this.Edge.BackColor = Color.Yellow;// FromArgb(128, 64, 0);
            this.Edge.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            //this.Edge.ForeColor = Color.White;
            this.Edge.Location = new Point(488, 1);
            this.Edge.Name = "Edge";
            Button edge = this.Edge;
            size1 = new Size(37, 37); // (74, 37)
            Size size19 = size1;
            edge.Size = size19;
            this.Edge.TabIndex = 23;
            this.Edge.Text = "e";// "EDGE\r\ne";
            this.Edge.UseVisualStyleBackColor = false;

            this.Zero.BackColor = SystemColors.Control;
            this.Zero.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Zero.Location = new Point(378, 39);
            this.Zero.Name = "Zero";
            Button zero = this.Zero;
            size1 = new Size(71, 37);
            Size size20 = size1;
            zero.Size = size20;
            this.Zero.TabIndex = 24;
            this.Zero.Text = "*";
            this.Zero.UseVisualStyleBackColor = false;
            this.Sit.BackColor = Color.Yellow;
            this.Sit.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Sit.Location = new Point(587, 115);
            this.Sit.Name = "Sit";
            Button sit = this.Sit;
            size1 = new Size(134, 38);
            Size size21 = size1;
            sit.Size = size21;
            this.Sit.TabIndex = 25;
            this.Sit.Text = "SIT\r\n(SSp)";
            this.Sit.UseVisualStyleBackColor = false;
            this.OpSSp4.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpSSp4.Location = new Point(904, 115);
            this.OpSSp4.Name = "OpSSp4";
            Button opSsp4 = this.OpSSp4;
            size1 = new Size(30, 38);
            Size size22 = size1;
            opSsp4.Size = size22;
            this.OpSSp4.TabIndex = 30;
            this.OpSSp4.Text = "4";
            this.OpSSp4.UseVisualStyleBackColor = true;
            this.OpSSp3.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpSSp3.Location = new Point(874, 115);
            this.OpSSp3.Name = "OpSSp3";
            Button opSsp3 = this.OpSSp3;
            size1 = new Size(30, 38);
            Size size23 = size1;
            opSsp3.Size = size23;
            this.OpSSp3.TabIndex = 29;
            this.OpSSp3.Text = "3";
            this.OpSSp3.UseVisualStyleBackColor = true;
            this.OpSSp2.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpSSp2.Location = new Point(844, 115);
            this.OpSSp2.Name = "OpSSp2";
            Button opSsp2 = this.OpSSp2;
            size1 = new Size(30, 38);
            Size size24 = size1;
            opSsp2.Size = size24;
            this.OpSSp2.TabIndex = 28;
            this.OpSSp2.Text = "2";
            this.OpSSp2.UseVisualStyleBackColor = true;
            this.OpSSp1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpSSp1.Location = new Point(814, 115);
            this.OpSSp1.Name = "OpSSp1";
            Button opSsp1 = this.OpSSp1;
            size1 = new Size(30, 38);
            Size size25 = size1;
            opSsp1.Size = size25;
            this.OpSSp1.TabIndex = 27;
            this.OpSSp1.Text = "1";
            this.OpSSp1.UseVisualStyleBackColor = true;
            this.OpSSp0.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpSSp0.Location = new Point(780, 115);
            this.OpSSp0.Name = "OpSSp0";
            Button opSsp0 = this.OpSSp0;
            size1 = new Size(34, 38);
            Size size26 = size1;
            opSsp0.Size = size26;
            this.OpSSp0.TabIndex = 31;
            this.OpSSp0.Text = "B";
            this.OpSSp0.UseVisualStyleBackColor = true;
            this.OpLSp0.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpLSp0.Location = new Point(780, 155);
            this.OpLSp0.Name = "OpLSp0";
            Button opLsp0 = this.OpLSp0;
            size1 = new Size(34, 38);
            Size size27 = size1;
            opLsp0.Size = size27;
            this.OpLSp0.TabIndex = 38;
            this.OpLSp0.Text = "B";
            this.OpLSp0.UseVisualStyleBackColor = true;
            this.OpLSp4.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpLSp4.Location = new Point(904, 155);
            this.OpLSp4.Name = "OpLSp4";
            Button opLsp4 = this.OpLSp4;
            size1 = new Size(30, 38);
            Size size28 = size1;
            opLsp4.Size = size28;
            this.OpLSp4.TabIndex = 37;
            this.OpLSp4.Text = "4";
            this.OpLSp4.UseVisualStyleBackColor = true;
            this.OpLSp3.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpLSp3.Location = new Point(874, 155);
            this.OpLSp3.Name = "OpLSp3";
            Button opLsp3 = this.OpLSp3;
            size1 = new Size(30, 38);
            Size size29 = size1;
            opLsp3.Size = size29;
            this.OpLSp3.TabIndex = 36;
            this.OpLSp3.Text = "3";
            this.OpLSp3.UseVisualStyleBackColor = true;
            this.OpLSp2.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpLSp2.Location = new Point(844, 155);
            this.OpLSp2.Name = "OpLSp2";
            Button opLsp2 = this.OpLSp2;
            size1 = new Size(30, 38);
            Size size30 = size1;
            opLsp2.Size = size30;
            this.OpLSp2.TabIndex = 35;
            this.OpLSp2.Text = "2";
            this.OpLSp2.UseVisualStyleBackColor = true;
            this.OpLSp1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpLSp1.Location = new Point(814, 155);
            this.OpLSp1.Name = "OpLSp1";
            Button opLsp1 = this.OpLSp1;
            size1 = new Size(30, 38);
            Size size31 = size1;
            opLsp1.Size = size31;
            this.OpLSp1.TabIndex = 34;
            this.OpLSp1.Text = "1";
            this.OpLSp1.UseVisualStyleBackColor = true;
            this.Layback.BackColor = Color.Goldenrod;
            this.Layback.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Layback.Location = new Point(587, 155);
            this.Layback.Name = "Layback";
            Button layback = this.Layback;
            size1 = new Size(134, 38);
            Size size32 = size1;
            layback.Size = size32;
            this.Layback.TabIndex = 32;
            this.Layback.Text = "LAYBACK\r\n(LSp)";
            this.Layback.UseVisualStyleBackColor = false;
            this.OpUSp0.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpUSp0.Location = new Point(780, 195);
            this.OpUSp0.Name = "OpUSp0";
            Button opUsp0 = this.OpUSp0;
            size1 = new Size(34, 38);
            Size size33 = size1;
            opUsp0.Size = size33;
            this.OpUSp0.TabIndex = 45;
            this.OpUSp0.Text = "B";
            this.OpUSp0.UseVisualStyleBackColor = true;
            this.OpUSp4.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpUSp4.Location = new Point(904, 195);
            this.OpUSp4.Name = "OpUSp4";
            Button opUsp4 = this.OpUSp4;
            size1 = new Size(30, 38);
            Size size34 = size1;
            opUsp4.Size = size34;
            this.OpUSp4.TabIndex = 44;
            this.OpUSp4.Text = "4";
            this.OpUSp4.UseVisualStyleBackColor = true;
            this.OpUSp3.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpUSp3.Location = new Point(874, 195);
            this.OpUSp3.Name = "OpUSp3";
            Button opUsp3 = this.OpUSp3;
            size1 = new Size(30, 38);
            Size size35 = size1;
            opUsp3.Size = size35;
            this.OpUSp3.TabIndex = 43;
            this.OpUSp3.Text = "3";
            this.OpUSp3.UseVisualStyleBackColor = true;
            this.OpUSp2.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpUSp2.Location = new Point(844, 195);
            this.OpUSp2.Name = "OpUSp2";
            Button opUsp2 = this.OpUSp2;
            size1 = new Size(30, 38);
            Size size36 = size1;
            opUsp2.Size = size36;
            this.OpUSp2.TabIndex = 42;
            this.OpUSp2.Text = "2";
            this.OpUSp2.UseVisualStyleBackColor = true;
            this.OpUSp1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpUSp1.Location = new Point(814, 195);
            this.OpUSp1.Name = "OpUSp1";
            Button opUsp1 = this.OpUSp1;
            size1 = new Size(30, 38);
            Size size37 = size1;
            opUsp1.Size = size37;
            this.OpUSp1.TabIndex = 41;
            this.OpUSp1.Text = "1";
            this.OpUSp1.UseVisualStyleBackColor = true;
            this.Upright.BackColor = Color.FromArgb(128, (int)byte.MaxValue, (int)byte.MaxValue);
            this.Upright.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Upright.Location = new Point(587, 195);
            this.Upright.Name = "Upright";
            Button upright = this.Upright;
            size1 = new Size(134, 38);
            Size size38 = size1;
            upright.Size = size38;
            this.Upright.TabIndex = 39;
            this.Upright.Text = "UPRIGHT\r\n(USp)";
            this.Upright.UseVisualStyleBackColor = false;
            this.OpCSp0.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpCSp0.Location = new Point(780, 235);
            this.OpCSp0.Name = "OpCSp0";
            Button opCsp0 = this.OpCSp0;
            size1 = new Size(34, 38);
            Size size39 = size1;
            opCsp0.Size = size39;
            this.OpCSp0.TabIndex = 52;
            this.OpCSp0.Text = "B";
            this.OpCSp0.UseVisualStyleBackColor = true;
            this.OpCSp4.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpCSp4.Location = new Point(904, 235);
            this.OpCSp4.Name = "OpCSp4";
            Button opCsp4 = this.OpCSp4;
            size1 = new Size(30, 38);
            Size size40 = size1;
            opCsp4.Size = size40;
            this.OpCSp4.TabIndex = 51;
            this.OpCSp4.Text = "4";
            this.OpCSp4.UseVisualStyleBackColor = true;
            this.OpCSp3.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpCSp3.Location = new Point(874, 235);
            this.OpCSp3.Name = "OpCSp3";
            Button opCsp3 = this.OpCSp3;
            size1 = new Size(30, 38);
            Size size41 = size1;
            opCsp3.Size = size41;
            this.OpCSp3.TabIndex = 50;
            this.OpCSp3.Text = "3";
            this.OpCSp3.UseVisualStyleBackColor = true;
            this.OpCSp2.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpCSp2.Location = new Point(844, 235);
            this.OpCSp2.Name = "OpCSp2";
            Button opCsp2 = this.OpCSp2;
            size1 = new Size(30, 38);
            Size size42 = size1;
            opCsp2.Size = size42;
            this.OpCSp2.TabIndex = 49;
            this.OpCSp2.Text = "2";
            this.OpCSp2.UseVisualStyleBackColor = true;
            this.OpCSp1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpCSp1.Location = new Point(814, 235);
            this.OpCSp1.Name = "OpCSp1";
            Button opCsp1 = this.OpCSp1;
            size1 = new Size(30, 38);
            Size size43 = size1;
            opCsp1.Size = size43;
            this.OpCSp1.TabIndex = 48;
            this.OpCSp1.Text = "1";
            this.OpCSp1.UseVisualStyleBackColor = true;
            this.Camel.BackColor = Color.Lime;
            this.Camel.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Camel.Location = new Point(587, 235);
            this.Camel.Name = "Camel";
            Button camel = this.Camel;
            size1 = new Size(134, 38);
            Size size44 = size1;
            camel.Size = size44;
            this.Camel.TabIndex = 46;
            this.Camel.Text = "CAMEL\r\n(CSp)";
            this.Camel.UseVisualStyleBackColor = false;
            this.OpCoSp0.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpCoSp0.Location = new Point(780, 275);
            this.OpCoSp0.Name = "OpCoSp0";
            Button opCoSp0 = this.OpCoSp0;
            size1 = new Size(34, 38);
            Size size45 = size1;
            opCoSp0.Size = size45;
            this.OpCoSp0.TabIndex = 59;
            this.OpCoSp0.Text = "B";
            this.OpCoSp0.UseVisualStyleBackColor = true;
            this.OpCoSp4.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpCoSp4.Location = new Point(904, 275);
            this.OpCoSp4.Name = "OpCoSp4";
            Button opCoSp4 = this.OpCoSp4;
            size1 = new Size(30, 38);
            Size size46 = size1;
            opCoSp4.Size = size46;
            this.OpCoSp4.TabIndex = 58;
            this.OpCoSp4.Text = "4";
            this.OpCoSp4.UseVisualStyleBackColor = true;
            this.OpCoSp3.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpCoSp3.Location = new Point(874, 275);
            this.OpCoSp3.Name = "OpCoSp3";
            Button opCoSp3 = this.OpCoSp3;
            size1 = new Size(30, 38);
            Size size47 = size1;
            opCoSp3.Size = size47;
            this.OpCoSp3.TabIndex = 57;
            this.OpCoSp3.Text = "3";
            this.OpCoSp3.UseVisualStyleBackColor = true;
            this.OpCoSp2.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpCoSp2.Location = new Point(844, 275);
            this.OpCoSp2.Name = "OpCoSp2";
            Button opCoSp2 = this.OpCoSp2;
            size1 = new Size(30, 38);
            Size size48 = size1;
            opCoSp2.Size = size48;
            this.OpCoSp2.TabIndex = 56;
            this.OpCoSp2.Text = "2";
            this.OpCoSp2.UseVisualStyleBackColor = true;
            this.OpCoSp1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpCoSp1.Location = new Point(814, 275);
            this.OpCoSp1.Name = "OpCoSp1";
            Button opCoSp1 = this.OpCoSp1;
            size1 = new Size(30, 38);
            Size size49 = size1;
            opCoSp1.Size = size49;
            this.OpCoSp1.TabIndex = 55;
            this.OpCoSp1.Text = "1";
            this.OpCoSp1.UseVisualStyleBackColor = true;
            this.ComboSpin.BackColor = Color.FromArgb(192, 192, 0);
            this.ComboSpin.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ComboSpin.Location = new Point(587, 275);
            this.ComboSpin.Name = "ComboSpin";
            Button comboSpin = this.ComboSpin;
            size1 = new Size(134, 38);
            Size size50 = size1;
            comboSpin.Size = size50;
            this.ComboSpin.TabIndex = 53;
            this.ComboSpin.Text = "COMBO SPIN\r\n(CoSp)";
            this.ComboSpin.UseVisualStyleBackColor = false;
            this.OpChange.BackColor = Color.FromArgb(224, 224, 224);
            this.OpChange.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpChange.Location = new Point(724, 315);
            this.OpChange.Name = "OpChange";
            Button opChange = this.OpChange;
            size1 = new Size(102, 38);
            Size size51 = size1;
            opChange.Size = size51;
            this.OpChange.TabIndex = 60;
            this.OpChange.Text = "CHANGE";
            this.OpChange.UseVisualStyleBackColor = true;
            this.OpFlying.BackColor = Color.FromArgb(224, 224, 224);
            this.OpFlying.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpFlying.Location = new Point(832, 315);
            this.OpFlying.Name = "OpFlying";
            Button opFlying = this.OpFlying;
            size1 = new Size(102, 38);
            Size size52 = size1;
            opFlying.Size = size52;
            this.OpFlying.TabIndex = 61;
            this.OpFlying.Text = "FLYING";
            this.OpFlying.UseVisualStyleBackColor = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new Point(2, 78);
            this.Label1.Name = "Label1";
            Label label1 = this.Label1;
            size1 = new Size(312, 32);
            Size size53 = size1;
            label1.Size = size53;
            this.Label1.TabIndex = 62;
            this.Label1.Text = "JUMPS";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new Point(587, 78);
            this.Label3.Name = "Label3";
            Label label3 = this.Label3;
            size1 = new Size(216, 32);
            Size size54 = size1;
            label3.Size = size54;
            this.Label3.TabIndex = 64;
            this.Label3.Text = "SPINS";
            this.Label3.TextAlign = ContentAlignment.MiddleCenter;
            this.ChSq1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ChSq1.Location = new Point(780, 430);
            this.ChSq1.Name = "ChSq1";
            Button chSq1 = this.ChSq1;
            size1 = new Size(64, 38);
            Size size55 = size1;
            chSq1.Size = size55;
            this.ChSq1.TabIndex = 68;
            this.ChSq1.Text = "1";
            this.ChSq1.UseVisualStyleBackColor = true;
            this.ChoreoSeq.BackColor = Color.Yellow;
            this.ChoreoSeq.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ChoreoSeq.Location = new Point(587, 430);
            this.ChoreoSeq.Name = "ChoreoSeq";
            Button choreoSeq = this.ChoreoSeq;
            size1 = new Size(134, 38);
            Size size56 = size1;
            choreoSeq.Size = size56;
            this.ChoreoSeq.TabIndex = 67;
            this.ChoreoSeq.Text = "CHOREO SEQ.\r\n(ChSq)";
            this.ChoreoSeq.UseVisualStyleBackColor = false;
            this.OpStSq0.BackColor = Color.FromArgb(128, 64, 0);
            this.OpStSq0.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpStSq0.ForeColor = Color.White;
            this.OpStSq0.Location = new Point(780, 390);
            this.OpStSq0.Name = "OpStSq0";
            Button opStSq0 = this.OpStSq0;
            size1 = new Size(34, 38);
            Size size57 = size1;
            opStSq0.Size = size57;
            this.OpStSq0.TabIndex = 75;
            this.OpStSq0.Text = "B";
            this.OpStSq0.UseVisualStyleBackColor = false;
            this.OpStSq4.BackColor = Color.FromArgb(128, 64, 0);
            this.OpStSq4.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpStSq4.ForeColor = Color.White;
            this.OpStSq4.Location = new Point(905, 390);
            this.OpStSq4.Name = "OpStSq4";
            Button opStSq4 = this.OpStSq4;
            size1 = new Size(30, 38);
            Size size58 = size1;
            opStSq4.Size = size58;
            this.OpStSq4.TabIndex = 74;
            this.OpStSq4.Text = "4";
            this.OpStSq4.UseVisualStyleBackColor = false;
            this.OpStSq3.BackColor = Color.FromArgb(128, 64, 0);
            this.OpStSq3.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpStSq3.ForeColor = Color.White;
            this.OpStSq3.Location = new Point(874, 390);
            this.OpStSq3.Name = "OpStSq3";
            Button opStSq3 = this.OpStSq3;
            size1 = new Size(30, 38);
            Size size59 = size1;
            opStSq3.Size = size59;
            this.OpStSq3.TabIndex = 73;
            this.OpStSq3.Text = "3";
            this.OpStSq3.UseVisualStyleBackColor = false;
            this.OpStSq2.BackColor = Color.FromArgb(128, 64, 0);
            this.OpStSq2.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpStSq2.ForeColor = Color.White;
            this.OpStSq2.Location = new Point(844, 390);
            this.OpStSq2.Name = "OpStSq2";
            Button opStSq2 = this.OpStSq2;
            size1 = new Size(30, 38);
            Size size60 = size1;
            opStSq2.Size = size60;
            this.OpStSq2.TabIndex = 72;
            this.OpStSq2.Text = "2";
            this.OpStSq2.UseVisualStyleBackColor = false;
            this.OpStSq1.BackColor = Color.FromArgb(128, 64, 0);
            this.OpStSq1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpStSq1.ForeColor = Color.White;
            this.OpStSq1.Location = new Point(814, 390);
            this.OpStSq1.Name = "OpStSq1";
            Button opStSq1 = this.OpStSq1;
            size1 = new Size(30, 38);
            Size size61 = size1;
            opStSq1.Size = size61;
            this.OpStSq1.TabIndex = 71;
            this.OpStSq1.Text = "1";
            this.OpStSq1.UseVisualStyleBackColor = false;
            this.Straight.BackColor = Color.FromArgb(128, 64, 0);
            this.Straight.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Straight.ForeColor = Color.White;
            this.Straight.Location = new Point(587, 390);
            this.Straight.Name = "Straight";
            Button straight = this.Straight;
            size1 = new Size(134, 38);
            Size size62 = size1;
            straight.Size = size62;
            this.Straight.TabIndex = 69;
            this.Straight.Text = "STEP SEQUENCE\r\n(StSq)";
            this.Straight.UseVisualStyleBackColor = false;
            this.OpNext1.BackColor = Color.FromArgb(224, 224, 224);
            this.OpNext1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpNext1.Location = new Point(2, 475);
            this.OpNext1.Name = "OpNext1";
            Button opNext1 = this.OpNext1;
            size1 = new Size(125, 74);
            Size size63 = size1;
            opNext1.Size = size63;
            this.OpNext1.TabIndex = 76;
            this.OpNext1.Text = "NEXT\r\nROW";
            this.OpNext1.UseVisualStyleBackColor = false;
            this.OpDeleteRow.BackColor = Color.FromArgb(192, 192, 0);
            this.OpDeleteRow.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpDeleteRow.Location = new Point(133, 475);
            this.OpDeleteRow.Name = "OpDeleteRow";
            Button opDeleteRow = this.OpDeleteRow;
            size1 = new Size(130, 74);
            Size size64 = size1;
            opDeleteRow.Size = size64;
            this.OpDeleteRow.TabIndex = 77;
            this.OpDeleteRow.Text = "DELETE\r\nROW";
            this.OpDeleteRow.UseVisualStyleBackColor = false;
            this.OpInsert.BackColor = Color.FromArgb((int)byte.MaxValue, 128, 0);
            this.OpInsert.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpInsert.Location = new Point(269, 475);
            this.OpInsert.Name = "OpInsert";
            Button opInsert = this.OpInsert;
            size1 = new Size(119, 74);
            Size size65 = size1;
            opInsert.Size = size65;
            this.OpInsert.TabIndex = 78;
            this.OpInsert.Text = "INSERT\r\nROW";
            this.OpInsert.UseVisualStyleBackColor = false;
            this.OpClearEntry.BackColor = Color.Yellow;
            this.OpClearEntry.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpClearEntry.Location = new Point(394, 475);
            this.OpClearEntry.Name = "OpClearEntry";
            Button opClearEntry = this.OpClearEntry;
            size1 = new Size(130, 74);
            Size size66 = size1;
            opClearEntry.Size = size66;
            this.OpClearEntry.TabIndex = 79;
            this.OpClearEntry.Text = "CLEAR\r\nENTRY";
            this.OpClearEntry.UseVisualStyleBackColor = false;
            this.Review.BackColor = Color.FromArgb(0, 192, 0);
            this.Review.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Review.Location = new Point(530, 475);
            this.Review.Name = "Review";
            Button review = this.Review;
            size1 = new Size(142, 74);
            Size size67 = size1;
            review.Size = size67;
            this.Review.TabIndex = 80;
            this.Review.Text = "REVIEW";
            this.Review.UseVisualStyleBackColor = false;
            this.Falls_minus.BackColor = Color.Blue;
            this.Falls_minus.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Falls_minus.ForeColor = Color.White;
            this.Falls_minus.Location = new Point(674, 512);
            this.Falls_minus.Name = "Falls_minus";
            Button fallsMinus = this.Falls_minus;
            size1 = new Size(62, 37);
            Size size68 = size1;
            fallsMinus.Size = size68;
            this.Falls_minus.TabIndex = 86;
            this.Falls_minus.Text = "-";
            this.Falls_minus.UseVisualStyleBackColor = false;
            this.Falls.BackColor = Color.Blue;
            this.Falls.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Falls.ForeColor = Color.White;
            this.Falls.Location = new Point(741, 512);
            this.Falls.Name = "Falls";
            Button falls = this.Falls;
            size1 = new Size(62, 37);
            Size size69 = size1;
            falls.Size = size69;
            this.Falls.TabIndex = 85;
            this.Falls.Text = "+";
            this.Falls.UseVisualStyleBackColor = false;
            this.Falls_out.BackColor = Color.Blue;
            this.Falls_out.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Falls_out.ForeColor = Color.White;
            this.Falls_out.Location = new Point(674, 475);
            this.Falls_out.Name = "Falls_out";
            Button fallsOut = this.Falls_out;
            size1 = new Size(129, 37);
            Size size70 = size1;
            fallsOut.Size = size70;
            this.Falls_out.TabIndex = 84;
            this.Falls_out.Text = "FALLS";
            this.Falls_out.UseVisualStyleBackColor = false;
            this.OpT4.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpT4.Location = new Point(282, 155);
            this.OpT4.Name = "OpT4";
            Button opT4 = this.OpT4;
            size1 = new Size(30, 38);
            Size size71 = size1;
            opT4.Size = size71;
            this.OpT4.TabIndex = 90;
            this.OpT4.Text = "4";
            this.OpT4.UseVisualStyleBackColor = true;
            this.OpT3.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpT3.Location = new Point(252, 155);
            this.OpT3.Name = "OpT3";
            Button opT3 = this.OpT3;
            size1 = new Size(30, 38);
            Size size72 = size1;
            opT3.Size = size72;
            this.OpT3.TabIndex = 89;
            this.OpT3.Text = "3";
            this.OpT3.UseVisualStyleBackColor = true;
            this.OpT2.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpT2.Location = new Point(222, 155);
            this.OpT2.Name = "OpT2";
            Button opT2 = this.OpT2;
            size1 = new Size(30, 38);
            Size size73 = size1;
            opT2.Size = size73;
            this.OpT2.TabIndex = 88;
            this.OpT2.Text = "2";
            this.OpT2.UseVisualStyleBackColor = true;
            this.OpT1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpT1.Location = new Point(192, 155);
            this.OpT1.Name = "OpT1";
            Button opT1 = this.OpT1;
            size1 = new Size(30, 38);
            Size size74 = size1;
            opT1.Size = size74;
            this.OpT1.TabIndex = 87;
            this.OpT1.Text = "1";
            this.OpT1.UseVisualStyleBackColor = true;
            this.OpL4.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpL4.Location = new Point(282, 195);
            this.OpL4.Name = "OpL4";
            Button opL4 = this.OpL4;
            size1 = new Size(30, 38);
            Size size75 = size1;
            opL4.Size = size75;
            this.OpL4.TabIndex = 94;
            this.OpL4.Text = "4";
            this.OpL4.UseVisualStyleBackColor = true;
            this.OpL3.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpL3.Location = new Point(252, 195);
            this.OpL3.Name = "OpL3";
            Button opL3 = this.OpL3;
            size1 = new Size(30, 38);
            Size size76 = size1;
            opL3.Size = size76;
            this.OpL3.TabIndex = 93;
            this.OpL3.Text = "3";
            this.OpL3.UseVisualStyleBackColor = true;
            this.OpL2.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpL2.Location = new Point(222, 195);
            this.OpL2.Name = "OpL2";
            Button opL2 = this.OpL2;
            size1 = new Size(30, 38);
            Size size77 = size1;
            opL2.Size = size77;
            this.OpL2.TabIndex = 92;
            this.OpL2.Text = "2";
            this.OpL2.UseVisualStyleBackColor = true;
            this.OpL1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpL1.Location = new Point(192, 195);
            this.OpL1.Name = "OpL1";
            Button opL1 = this.OpL1;
            size1 = new Size(30, 38);
            Size size78 = size1;
            opL1.Size = size78;
            this.OpL1.TabIndex = 91;
            this.OpL1.Text = "1";
            this.OpL1.UseVisualStyleBackColor = true;
            this.OpF4.BackColor = Color.DarkBlue;
            this.OpF4.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpF4.ForeColor = Color.White;
            this.OpF4.Location = new Point(282, 235);
            this.OpF4.Name = "OpF4";
            Button opF4 = this.OpF4;
            size1 = new Size(30, 38);
            Size size79 = size1;
            opF4.Size = size79;
            this.OpF4.TabIndex = 98;
            this.OpF4.Text = "4";
            this.OpF4.UseVisualStyleBackColor = false;
            this.OpF3.BackColor = Color.DarkBlue;
            this.OpF3.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpF3.ForeColor = Color.White;
            this.OpF3.Location = new Point(252, 235);
            this.OpF3.Name = "OpF3";
            Button opF3 = this.OpF3;
            size1 = new Size(30, 38);
            Size size80 = size1;
            opF3.Size = size80;
            this.OpF3.TabIndex = 97;
            this.OpF3.Text = "3";
            this.OpF3.UseVisualStyleBackColor = false;
            this.OpF2.BackColor = Color.DarkBlue;
            this.OpF2.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpF2.ForeColor = Color.White;
            this.OpF2.Location = new Point(222, 235);
            this.OpF2.Name = "OpF2";
            Button opF2 = this.OpF2;
            size1 = new Size(30, 38);
            Size size81 = size1;
            opF2.Size = size81;
            this.OpF2.TabIndex = 96;
            this.OpF2.Text = "2";
            this.OpF2.UseVisualStyleBackColor = false;
            this.OpF1.BackColor = Color.DarkBlue;
            this.OpF1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpF1.ForeColor = Color.White;
            this.OpF1.Location = new Point(192, 235);
            this.OpF1.Name = "OpF1";
            Button opF1 = this.OpF1;
            size1 = new Size(30, 38);
            Size size82 = size1;
            opF1.Size = size82;
            this.OpF1.TabIndex = 95;
            this.OpF1.Text = "1";
            this.OpF1.UseVisualStyleBackColor = false;
            this.OpLz4.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpLz4.Location = new Point(282, 275);
            this.OpLz4.Name = "OpLz4";
            Button opLz4 = this.OpLz4;
            size1 = new Size(30, 38);
            Size size83 = size1;
            opLz4.Size = size83;
            this.OpLz4.TabIndex = 102;
            this.OpLz4.Text = "4";
            this.OpLz4.UseVisualStyleBackColor = true;
            this.OpLz3.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpLz3.Location = new Point(252, 275);
            this.OpLz3.Name = "OpLz3";
            Button opLz3 = this.OpLz3;
            size1 = new Size(30, 38);
            Size size84 = size1;
            opLz3.Size = size84;
            this.OpLz3.TabIndex = 101;
            this.OpLz3.Text = "3";
            this.OpLz3.UseVisualStyleBackColor = true;
            this.OpLz2.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpLz2.Location = new Point(222, 275);
            this.OpLz2.Name = "OpLz2";
            Button opLz2 = this.OpLz2;
            size1 = new Size(30, 38);
            Size size85 = size1;
            opLz2.Size = size85;
            this.OpLz2.TabIndex = 100;
            this.OpLz2.Text = "2";
            this.OpLz2.UseVisualStyleBackColor = true;
            this.OpLz1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpLz1.Location = new Point(192, 275);
            this.OpLz1.Name = "OpLz1";
            Button opLz1 = this.OpLz1;
            size1 = new Size(30, 38);
            Size size86 = size1;
            opLz1.Size = size86;
            this.OpLz1.TabIndex = 99;
            this.OpLz1.Text = "1";
            this.OpLz1.UseVisualStyleBackColor = true;
            this.OpS4.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpS4.Location = new Point(282, 315);
            this.OpS4.Name = "OpS4";
            Button opS4 = this.OpS4;
            size1 = new Size(30, 38);
            Size size87 = size1;
            opS4.Size = size87;
            this.OpS4.TabIndex = 106;
            this.OpS4.Text = "4";
            this.OpS4.UseVisualStyleBackColor = true;
            this.OpS3.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpS3.Location = new Point(252, 315);
            this.OpS3.Name = "OpS3";
            Button opS3 = this.OpS3;
            size1 = new Size(30, 38);
            Size size88 = size1;
            opS3.Size = size88;
            this.OpS3.TabIndex = 105;
            this.OpS3.Text = "3";
            this.OpS3.UseVisualStyleBackColor = true;
            this.OpS2.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpS2.Location = new Point(222, 315);
            this.OpS2.Name = "OpS2";
            Button opS2 = this.OpS2;
            size1 = new Size(30, 38);
            Size size89 = size1;
            opS2.Size = size89;
            this.OpS2.TabIndex = 104;
            this.OpS2.Text = "2";
            this.OpS2.UseVisualStyleBackColor = true;
            this.OpS1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpS1.Location = new Point(192, 315);
            this.OpS1.Name = "OpS1";
            Button opS1 = this.OpS1;
            size1 = new Size(30, 38);
            Size size90 = size1;
            opS1.Size = size90;
            this.OpS1.TabIndex = 103;
            this.OpS1.Text = "1";
            this.OpS1.UseVisualStyleBackColor = true;
            this.HalfTime.BackColor = SystemColors.Control;
            this.HalfTime.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.HalfTime.Location = new Point(587, 39);
            this.HalfTime.Name = "HalfTime";
            Button halfTime = this.HalfTime;
            size1 = new Size(85, 37);
            Size size91 = size1;
            halfTime.Size = size91;
            this.HalfTime.TabIndex = 107;
            this.HalfTime.Text = "HALF TIME";
            this.HalfTime.UseVisualStyleBackColor = false;
            this.StartHT.BackColor = SystemColors.Control;
            this.StartHT.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.StartHT.Location = new Point(674, 39);
            this.StartHT.Name = "StartHT";
            Button startHt = this.StartHT;
            size1 = new Size(60, 37);
            Size size92 = size1;
            startHt.Size = size92;
            this.StartHT.TabIndex = 108;
            this.StartHT.Text = "START";
            this.StartHT.UseVisualStyleBackColor = false;
            this.StopHT.BackColor = SystemColors.Control;
            this.StopHT.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.StopHT.Location = new Point(736, 39);
            this.StopHT.Name = "StopHT";
            Button stopHt = this.StopHT;
            size1 = new Size(68, 37);
            Size size93 = size1;
            stopHt.Size = size93;
            this.StopHT.TabIndex = 109;
            this.StopHT.Text = "STOP";
            this.StopHT.UseVisualStyleBackColor = false;
            this.Bonus_minus.BackColor = Color.FromArgb((int)byte.MaxValue, 192, 128);
            this.Bonus_minus.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Bonus_minus.Location = new Point(806, 512);
            this.Bonus_minus.Name = "Bonus_minus";
            Button bonusMinus = this.Bonus_minus;
            size1 = new Size(62, 37);
            Size size94 = size1;
            bonusMinus.Size = size94;
            this.Bonus_minus.TabIndex = 110;
            this.Bonus_minus.Text = "-";
            this.Bonus_minus.UseVisualStyleBackColor = false;
            this.Bonus_plus.BackColor = Color.FromArgb((int)byte.MaxValue, 192, 128);
            this.Bonus_plus.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Bonus_plus.Location = new Point(870, 512);
            this.Bonus_plus.Name = "Bonus_plus";
            Button bonusPlus = this.Bonus_plus;
            size1 = new Size(62, 37);
            Size size95 = size1;
            bonusPlus.Size = size95;
            this.Bonus_plus.TabIndex = 111;
            this.Bonus_plus.Text = "+";
            this.Bonus_plus.UseVisualStyleBackColor = false;
            this.Bonus.BackColor = Color.FromArgb((int)byte.MaxValue, 192, 128);
            this.Bonus.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Bonus.Location = new Point(806, 475);
            this.Bonus.Name = "Bonus";
            Button bonus = this.Bonus;
            size1 = new Size((int)sbyte.MaxValue, 37);
            Size size96 = size1;
            bonus.Size = size96;
            this.Bonus.TabIndex = 112;
            this.Bonus.Text = "BONUS";
            this.Bonus.UseVisualStyleBackColor = false;
            this.OpMsg.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpMsg.Location = new Point(587, 1);
            this.OpMsg.Multiline = true;
            this.OpMsg.Name = "OpMsg";
            TextBox opMsg = this.OpMsg;
            size1 = new Size(147, 37);
            Size size97 = size1;
            opMsg.Size = size97;
            this.OpMsg.TabIndex = 113;
            this.Set0.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Set0.Location = new Point(383, 430);
            this.Set0.Name = "Set0";
            Button set0 = this.Set0;
            size1 = new Size(35, 38);
            Size size98 = size1;
            set0.Size = size98;
            this.Set0.TabIndex = 118;
            this.Set0.Text = "B";
            this.Set0.UseVisualStyleBackColor = true;
            this.Set4.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Set4.Location = new Point(547, 430);
            this.Set4.Name = "Set4";
            Button set4 = this.Set4;
            size1 = new Size(35, 38);
            Size size99 = size1;
            set4.Size = size99;
            this.Set4.TabIndex = 117;
            this.Set4.Text = "4";
            this.Set4.UseVisualStyleBackColor = true;
            this.Set3.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Set3.Location = new Point(506, 430);
            this.Set3.Name = "Set3";
            Button set3 = this.Set3;
            size1 = new Size(35, 38);
            Size size100 = size1;
            set3.Size = size100;
            this.Set3.TabIndex = 116;
            this.Set3.Text = "3";
            this.Set3.UseVisualStyleBackColor = true;
            this.Set2.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Set2.Location = new Point(465, 430);
            this.Set2.Name = "Set2";
            Button set2 = this.Set2;
            size1 = new Size(35, 38);
            Size size101 = size1;
            set2.Size = size101;
            this.Set2.TabIndex = 115;
            this.Set2.Text = "2";
            this.Set2.UseVisualStyleBackColor = true;
            this.Set1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Set1.Location = new Point(424, 430);
            this.Set1.Name = "Set1";
            Button set1 = this.Set1;
            size1 = new Size(35, 38);
            Size size102 = size1;
            set1.Size = size102;
            this.Set1.TabIndex = 114;
            this.Set1.Text = "1";
            this.Set1.UseVisualStyleBackColor = true;
            this.NoLevel.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.NoLevel.Location = new Point(320, 430);
            this.NoLevel.Name = "NoLevel";
            Button noLevel = this.NoLevel;
            size1 = new Size(58, 38);
            Size size103 = size1;
            noLevel.Size = size103;
            this.NoLevel.TabIndex = 119;
            this.NoLevel.Text = "NL";
            this.NoLevel.UseVisualStyleBackColor = true;
            this.ColorBox.Font = new Font("Microsoft Sans Serif", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ColorBox.Location = new Point(2, 430);
            this.ColorBox.Name = "ColorBox";
            Label colorBox = this.ColorBox;
            size1 = new Size(310, 36);
            Size size104 = size1;
            colorBox.Size = size104;
            this.ColorBox.TabIndex = 120;
            this.ColorBox.Text = "LEVEL MISSING";
            this.ColorBox.TextAlign = ContentAlignment.MiddleCenter;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.BackgroundColor = Color.White;
            this.DataGridView1.BorderStyle = BorderStyle.None;
            this.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.ColumnHeadersVisible = false;
            this.DataGridView1.Columns.AddRange((DataGridViewColumn)this.Column1, (DataGridViewColumn)this.Column2, (DataGridViewColumn)this.Column3, (DataGridViewColumn)this.Column4);
            this.DataGridView1.Location = new Point(320, 78);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.ScrollBars = ScrollBars.None;
            this.DataGridView1.ShowEditingIcon = false;
            DataGridView dataGridView1 = this.DataGridView1;
            size1 = new Size(262, 346);
            Size size105 = size1;
            dataGridView1.Size = size105;
            this.DataGridView1.TabIndex = 121;
            gridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Column1.DefaultCellStyle = gridViewCellStyle1;
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 20;
            gridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Column2.DefaultCellStyle = gridViewCellStyle2;
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 195;
            gridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Column3.DefaultCellStyle = gridViewCellStyle3;
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 30;
            gridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.Column4.DefaultCellStyle = gridViewCellStyle4;
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 15;
            this.Time.BackColor = SystemColors.Control;
            this.Time.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Time.Location = new Point(736, 1);
            this.Time.Name = "Time";
            Button time = this.Time;
            size1 = new Size(68, 37);
            Size size106 = size1;
            time.Size = size106;
            this.Time.TabIndex = 122;
            this.Time.UseVisualStyleBackColor = false;
            this.Timer1.Interval = 1000;

            this.OpExcl.BackColor = SystemColors.Control;
            this.OpExcl.Font = new Font("Microsoft Sans Serif", 20f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpExcl.Location = new Point(526, 1);
            this.OpExcl.Name = "OpExcl";
            Button opExcl = this.OpExcl;
            size1 = new Size(27, 37);
            Size size107 = size1;
            opExcl.Size = size107;
            this.OpExcl.TabIndex = 123;
            this.OpExcl.Text = "!";
            this.OpExcl.UseVisualStyleBackColor = false;

            this.OpFallinElement.BackColor = Color.Yellow;
            this.OpFallinElement.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpFallinElement.Location = new Point(554, 1);
            this.OpFallinElement.Name = "OpFallinElement";
            Button opFallinElement = this.OpFallinElement;
            size1 = new Size(27, 37);
            opFallinElement.Size = size1;
            this.OpFallinElement.TabIndex = 123;
            this.OpFallinElement.Text = "f";
            this.OpFallinElement.UseVisualStyleBackColor = false;

            this.Spin_V.BackColor = Color.FromArgb(128, (int)byte.MaxValue, (int)byte.MaxValue);
            this.Spin_V.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Spin_V.Location = new Point(806, 76);
            this.Spin_V.Name = "Spin_V";
            Button spinV = this.Spin_V;
            size1 = new Size(128, 37);
            Size size108 = size1;
            spinV.Size = size108;
            this.Spin_V.TabIndex = 124;
            this.Spin_V.Text = "V";
            this.Spin_V.UseVisualStyleBackColor = false;
            this.opREP.BackColor = SystemColors.Control;
            this.opREP.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.opREP.Location = new Point(526, 39);
            this.opREP.Name = "opREP";
            Button opRep = this.opREP;
            size1 = new Size(55, 37);
            Size size109 = size1;
            opRep.Size = size109;
            this.opREP.TabIndex = 126;
            this.opREP.Text = "REP";
            this.opREP.UseVisualStyleBackColor = false;
            this.PictureBox13.Image = (Image)ClubCompFS.My.Resources.Resources.Levels_53x38;
            this.PictureBox13.Location = new Point(724, 390);
            this.PictureBox13.Name = "PictureBox13";
            PictureBox pictureBox13 = this.PictureBox13;
            size1 = new Size(53, 38);
            Size size110 = size1;
            pictureBox13.Size = size110;
            this.PictureBox13.TabIndex = 70;
            this.PictureBox13.TabStop = false;
            this.PictureBox12.Image = (Image)ClubCompFS.My.Resources.Resources.Conf;
            this.PictureBox12.Location = new Point(724, 430);
            this.PictureBox12.Name = "PictureBox12";
            PictureBox pictureBox12 = this.PictureBox12;
            size1 = new Size(52, 38);
            Size size111 = size1;
            pictureBox12.Size = size111;
            this.PictureBox12.TabIndex = 66;
            this.PictureBox12.TabStop = false;
            this.PictureBox11.Image = (Image)ClubCompFS.My.Resources.Resources.Levels_53x38;
            this.PictureBox11.Location = new Point(724, 275);
            this.PictureBox11.Name = "PictureBox11";
            PictureBox pictureBox11 = this.PictureBox11;
            size1 = new Size(53, 38);
            Size size112 = size1;
            pictureBox11.Size = size112;
            this.PictureBox11.TabIndex = 54;
            this.PictureBox11.TabStop = false;
            this.PictureBox10.Image = (Image)ClubCompFS.My.Resources.Resources.Levels_53x38;
            this.PictureBox10.Location = new Point(724, 235);
            this.PictureBox10.Name = "PictureBox10";
            PictureBox pictureBox10 = this.PictureBox10;
            size1 = new Size(53, 38);
            Size size113 = size1;
            pictureBox10.Size = size113;
            this.PictureBox10.TabIndex = 47;
            this.PictureBox10.TabStop = false;
            this.PictureBox9.Image = (Image)ClubCompFS.My.Resources.Resources.Levels_53x38;
            this.PictureBox9.Location = new Point(724, 195);
            this.PictureBox9.Name = "PictureBox9";
            PictureBox pictureBox9 = this.PictureBox9;
            size1 = new Size(53, 38);
            Size size114 = size1;
            pictureBox9.Size = size114;
            this.PictureBox9.TabIndex = 40;
            this.PictureBox9.TabStop = false;
            this.PictureBox8.Image = (Image)ClubCompFS.My.Resources.Resources.Levels_53x38;
            this.PictureBox8.Location = new Point(724, 155);
            this.PictureBox8.Name = "PictureBox8";
            PictureBox pictureBox8 = this.PictureBox8;
            size1 = new Size(53, 38);
            Size size115 = size1;
            pictureBox8.Size = size115;
            this.PictureBox8.TabIndex = 33;
            this.PictureBox8.TabStop = false;
            this.PictureBox7.Image = (Image)ClubCompFS.My.Resources.Resources.Levels_53x38;
            this.PictureBox7.Location = new Point(724, 115);
            this.PictureBox7.Name = "PictureBox7";
            PictureBox pictureBox7 = this.PictureBox7;
            size1 = new Size(53, 38);
            Size size116 = size1;
            pictureBox7.Size = size116;
            this.PictureBox7.TabIndex = 26;
            this.PictureBox7.TabStop = false;
            this.PictureBox6.Image = (Image)ClubCompFS.My.Resources.Resources.Turns;
            this.PictureBox6.Location = new Point(138, 315);
            this.PictureBox6.Name = "PictureBox6";
            PictureBox pictureBox6 = this.PictureBox6;
            size1 = new Size(52, 38);
            Size size117 = size1;
            pictureBox6.Size = size117;
            this.PictureBox6.TabIndex = 13;
            this.PictureBox6.TabStop = false;
            this.PictureBox5.Image = (Image)ClubCompFS.My.Resources.Resources.Turns;
            this.PictureBox5.Location = new Point(138, 275);
            this.PictureBox5.Name = "PictureBox5";
            PictureBox pictureBox5 = this.PictureBox5;
            size1 = new Size(52, 38);
            Size size118 = size1;
            pictureBox5.Size = size118;
            this.PictureBox5.TabIndex = 11;
            this.PictureBox5.TabStop = false;
            this.PictureBox4.Image = (Image)ClubCompFS.My.Resources.Resources.Turns;
            this.PictureBox4.Location = new Point(138, 195);
            this.PictureBox4.Name = "PictureBox4";
            PictureBox pictureBox4 = this.PictureBox4;
            size1 = new Size(52, 38);
            Size size119 = size1;
            pictureBox4.Size = size119;
            this.PictureBox4.TabIndex = 9;
            this.PictureBox4.TabStop = false;
            this.PictureBox3.Image = (Image)ClubCompFS.My.Resources.Resources.Turns;
            this.PictureBox3.Location = new Point(138, 235);
            this.PictureBox3.Name = "PictureBox3";
            PictureBox pictureBox3 = this.PictureBox3;
            size1 = new Size(52, 38);
            Size size120 = size1;
            pictureBox3.Size = size120;
            this.PictureBox3.TabIndex = 7;
            this.PictureBox3.TabStop = false;
            this.PictureBox2.Image = (Image)ClubCompFS.My.Resources.Resources.Turns;
            this.PictureBox2.Location = new Point(138, 155);
            this.PictureBox2.Name = "PictureBox2";
            PictureBox pictureBox2 = this.PictureBox2;
            size1 = new Size(52, 38);
            Size size121 = size1;
            pictureBox2.Size = size121;
            this.PictureBox2.TabIndex = 5;
            this.PictureBox2.TabStop = false;
            this.PictureBox1.Image = (Image)ClubCompFS.My.Resources.Resources.Turns;
            this.PictureBox1.Location = new Point(138, 115);
            this.PictureBox1.Name = "PictureBox1";
            PictureBox pictureBox1 = this.PictureBox1;
            size1 = new Size(52, 38);
            Size size122 = size1;
            pictureBox1.Size = size122;
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            this.Panel1.BackColor = Color.White;
            this.Panel1.Controls.Add((Control)this.txtInfo2);
            this.Panel1.Controls.Add((Control)this.txtInfo);
            this.Panel1.Controls.Add((Control)this.txtEl);
            this.Panel1.Controls.Add((Control)this.txtj7);
            this.Panel1.Controls.Add((Control)this.txtJ4);
            this.Panel1.Controls.Add((Control)this.txtJ3);
            this.Panel1.Controls.Add((Control)this.txtJ2);
            this.Panel1.Controls.Add((Control)this.txtJ6);
            this.Panel1.Controls.Add((Control)this.txtJ5);
            this.Panel1.Controls.Add((Control)this.txtJ1);
            this.Panel1.Location = new Point(806, 1);
            this.Panel1.Name = "Panel1";
            Panel panel1 = this.Panel1;
            size1 = new Size(130, 37);
            Size size123 = size1;
            panel1.Size = size123;
            this.Panel1.TabIndex = 132;
            this.txtInfo2.BackColor = Color.Red;
            this.txtInfo2.BorderStyle = BorderStyle.FixedSingle;
            this.txtInfo2.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtInfo2.ForeColor = Color.White;
            this.txtInfo2.Location = new Point(49, 19);
            this.txtInfo2.Name = "txtInfo2";
            TextBox txtInfo2 = this.txtInfo2;
            size1 = new Size(32, 18);
            Size size124 = size1;
            txtInfo2.Size = size124;
            this.txtInfo2.TabIndex = 167;
            this.txtInfo2.Text = "Info2";
            this.txtInfo2.TextAlign = HorizontalAlignment.Center;
            this.txtInfo.BackColor = Color.Red;
            this.txtInfo.BorderStyle = BorderStyle.FixedSingle;
            this.txtInfo.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtInfo.ForeColor = Color.White;
            this.txtInfo.Location = new Point(19, 19);
            this.txtInfo.Name = "txtInfo";
            TextBox txtInfo = this.txtInfo;
            size1 = new Size(30, 18);
            Size size125 = size1;
            txtInfo.Size = size125;
            this.txtInfo.TabIndex = 166;
            this.txtInfo.Text = "Info";
            this.txtInfo.TextAlign = HorizontalAlignment.Center;
            this.txtEl.BackColor = Color.Red;
            this.txtEl.BorderStyle = BorderStyle.FixedSingle;
            this.txtEl.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtEl.ForeColor = Color.White;
            this.txtEl.Location = new Point(1, 19);
            this.txtEl.Name = "txtEl";
            TextBox txtEl = this.txtEl;
            size1 = new Size(18, 18);
            Size size126 = size1;
            txtEl.Size = size126;
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
            Size size127 = size1;
            txtj7.Size = size127;
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
            Size size128 = size1;
            txtJ4.Size = size128;
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
            Size size129 = size1;
            txtJ3.Size = size129;
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
            Size size130 = size1;
            txtJ2.Size = size130;
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
            Size size131 = size1;
            txtJ6.Size = size131;
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
            Size size132 = size1;
            txtJ5.Size = size132;
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
            Size size133 = size1;
            txtJ1.Size = size133;
            this.txtJ1.TabIndex = 158;
            this.txtJ1.Text = "J1";
            this.txtJ1.TextAlign = HorizontalAlignment.Center;
            this.txtJ1.Visible = false;
            this.btnDED.BackColor = Color.Blue;
            this.btnDED.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.btnDED.ForeColor = Color.White;
            this.btnDED.Location = new Point(806, 39);
            this.btnDED.Name = "btnDED";
            Button btnDed = this.btnDED;
            size1 = new Size(128, 37);
            Size size134 = size1;
            btnDed.Size = size134;
            this.btnDED.TabIndex = 133;
            this.btnDED.Text = "DEDUCTIONS";
            this.btnDED.UseVisualStyleBackColor = false;
            this.OpEu1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpEu1.Location = new Point(192, 355);
            this.OpEu1.Name = "OpEu1";
            Button opEu1 = this.OpEu1;
            size1 = new Size(62, 38);
            Size size135 = size1;
            opEu1.Size = size135;
            this.OpEu1.TabIndex = 136;
            this.OpEu1.Text = "1";
            this.OpEu1.UseVisualStyleBackColor = true;
            this.Euler.BackColor = Color.Yellow;
            this.Euler.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Euler.Location = new Point(2, 355);
            this.Euler.Name = "Euler";
            Button euler = this.Euler;
            size1 = new Size(134, 38);
            Size size136 = size1;
            euler.Size = size136;
            this.Euler.TabIndex = 135;
            this.Euler.Text = "EULER\r\n(Eu)";
            this.Euler.UseVisualStyleBackColor = false;
            this.OpW1.Font = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.OpW1.Location = new Point(192, 395);
            this.OpW1.Name = "OpW1";
            Button opW1 = this.OpW1;
            size1 = new Size(62, 38);
            Size size137 = size1;
            opW1.Size = size137;
            this.OpW1.TabIndex = 136;
            this.OpW1.Text = "1";
            this.OpW1.UseVisualStyleBackColor = true;
            this.Waltz.BackColor = Color.Yellow;
            this.Waltz.Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Waltz.Location = new Point(2, 395);
            this.Waltz.Name = "Waltz";
            Button waltz = this.Waltz;
            size1 = new Size(134, 38);
            Size size138 = size1;
            waltz.Size = size138;
            this.Waltz.TabIndex = 135;
            this.Waltz.Text = "WALTZ\r\n(W)";
            this.Waltz.UseVisualStyleBackColor = false;
            this.PictureBox14.Image = (Image)ClubCompFS.My.Resources.Resources.Turns;
            this.PictureBox14.Location = new Point(138, 355);
            this.PictureBox14.Name = "PictureBox14";
            PictureBox pictureBox14 = this.PictureBox14;
            size1 = new Size(52, 38);
            Size size139 = size1;
            pictureBox14.Size = size139;
            this.PictureBox14.TabIndex = 137;
            this.PictureBox14.TabStop = false;
            this.PictureBox15.Image = (Image)ClubCompFS.My.Resources.Resources.Turns;
            this.PictureBox15.Location = new Point(138, 395);
            this.PictureBox15.Name = "PictureBox15";
            PictureBox pictureBox15 = this.PictureBox15;
            size1 = new Size(52, 38);
            Size size140 = size1;
            pictureBox15.Size = size140;
            this.PictureBox15.TabIndex = 13;
            this.PictureBox15.TabStop = false;
            this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new Point(587, 355);
            this.Label2.Name = "Label2";
            Label label2 = this.Label2;
            size1 = new Size(345, 32);
            Size size141 = size1;
            label2.Size = size141;
            this.Label2.TabIndex = 138;
            this.Label2.Text = "SEQUENCES";
            this.Label2.TextAlign = ContentAlignment.MiddleCenter;
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = Color.White;
            size1 = new Size(935, 550);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.Label2);
            this.Controls.Add((Control)this.PictureBox14);
            this.Controls.Add((Control)this.PictureBox15);
            this.Controls.Add((Control)this.OpEu1);
            this.Controls.Add((Control)this.Euler);
            this.Controls.Add((Control)this.OpW1);
            this.Controls.Add((Control)this.Waltz);
            this.Controls.Add((Control)this.btnDED);
            this.Controls.Add((Control)this.Panel1);
            this.Controls.Add((Control)this.opREP);
            this.Controls.Add((Control)this.Spin_V);
            this.Controls.Add((Control)this.OpExcl);
            this.Controls.Add((Control)this.OpFallinElement);
            this.Controls.Add((Control)this.Time);
            this.Controls.Add((Control)this.DataGridView1);
            this.Controls.Add((Control)this.ColorBox);
            this.Controls.Add((Control)this.NoLevel);
            this.Controls.Add((Control)this.Set0);
            this.Controls.Add((Control)this.Set4);
            this.Controls.Add((Control)this.Set3);
            this.Controls.Add((Control)this.Set2);
            this.Controls.Add((Control)this.Set1);
            this.Controls.Add((Control)this.OpMsg);
            this.Controls.Add((Control)this.Bonus);
            this.Controls.Add((Control)this.Bonus_plus);
            this.Controls.Add((Control)this.Bonus_minus);
            this.Controls.Add((Control)this.StopHT);
            this.Controls.Add((Control)this.StartHT);
            this.Controls.Add((Control)this.HalfTime);
            this.Controls.Add((Control)this.OpS4);
            this.Controls.Add((Control)this.OpS3);
            this.Controls.Add((Control)this.OpS2);
            this.Controls.Add((Control)this.OpS1);
            this.Controls.Add((Control)this.OpLz4);
            this.Controls.Add((Control)this.OpLz3);
            this.Controls.Add((Control)this.OpLz2);
            this.Controls.Add((Control)this.OpLz1);
            this.Controls.Add((Control)this.OpF4);
            this.Controls.Add((Control)this.OpF3);
            this.Controls.Add((Control)this.OpF2);
            this.Controls.Add((Control)this.OpF1);
            this.Controls.Add((Control)this.OpL4);
            this.Controls.Add((Control)this.OpL3);
            this.Controls.Add((Control)this.OpL2);
            this.Controls.Add((Control)this.OpL1);
            this.Controls.Add((Control)this.OpT4);
            this.Controls.Add((Control)this.OpT3);
            this.Controls.Add((Control)this.OpT2);
            this.Controls.Add((Control)this.OpT1);
            this.Controls.Add((Control)this.Falls_minus);
            this.Controls.Add((Control)this.Falls);
            this.Controls.Add((Control)this.Falls_out);
            this.Controls.Add((Control)this.Review);
            this.Controls.Add((Control)this.OpClearEntry);
            this.Controls.Add((Control)this.OpInsert);
            this.Controls.Add((Control)this.OpDeleteRow);
            this.Controls.Add((Control)this.OpNext1);
            this.Controls.Add((Control)this.OpStSq0);
            this.Controls.Add((Control)this.OpStSq4);
            this.Controls.Add((Control)this.OpStSq3);
            this.Controls.Add((Control)this.OpStSq2);
            this.Controls.Add((Control)this.OpStSq1);
            this.Controls.Add((Control)this.PictureBox13);
            this.Controls.Add((Control)this.Straight);
            this.Controls.Add((Control)this.ChSq1);
            this.Controls.Add((Control)this.ChoreoSeq);
            this.Controls.Add((Control)this.PictureBox12);
            this.Controls.Add((Control)this.Label3);
            this.Controls.Add((Control)this.Label1);
            this.Controls.Add((Control)this.OpFlying);
            this.Controls.Add((Control)this.OpChange);
            this.Controls.Add((Control)this.OpCoSp0);
            this.Controls.Add((Control)this.OpCoSp4);
            this.Controls.Add((Control)this.OpCoSp3);
            this.Controls.Add((Control)this.OpCoSp2);
            this.Controls.Add((Control)this.OpCoSp1);
            this.Controls.Add((Control)this.PictureBox11);
            this.Controls.Add((Control)this.ComboSpin);
            this.Controls.Add((Control)this.OpCSp0);
            this.Controls.Add((Control)this.OpCSp4);
            this.Controls.Add((Control)this.OpCSp3);
            this.Controls.Add((Control)this.OpCSp2);
            this.Controls.Add((Control)this.OpCSp1);
            this.Controls.Add((Control)this.PictureBox10);
            this.Controls.Add((Control)this.Camel);
            this.Controls.Add((Control)this.OpUSp0);
            this.Controls.Add((Control)this.OpUSp4);
            this.Controls.Add((Control)this.OpUSp3);
            this.Controls.Add((Control)this.OpUSp2);
            this.Controls.Add((Control)this.OpUSp1);
            this.Controls.Add((Control)this.PictureBox9);
            this.Controls.Add((Control)this.Upright);
            this.Controls.Add((Control)this.OpLSp0);
            this.Controls.Add((Control)this.OpLSp4);
            this.Controls.Add((Control)this.OpLSp3);
            this.Controls.Add((Control)this.OpLSp2);
            this.Controls.Add((Control)this.OpLSp1);
            this.Controls.Add((Control)this.PictureBox8);
            this.Controls.Add((Control)this.Layback);
            this.Controls.Add((Control)this.OpSSp0);
            this.Controls.Add((Control)this.OpSSp4);
            this.Controls.Add((Control)this.OpSSp3);
            this.Controls.Add((Control)this.OpSSp2);
            this.Controls.Add((Control)this.OpSSp1);
            this.Controls.Add((Control)this.PictureBox7);
            this.Controls.Add((Control)this.Sit);
            this.Controls.Add((Control)this.Zero);
            this.Controls.Add((Control)this.Edge);
            this.Controls.Add((Control)this.OpDG);
            this.Controls.Add((Control)this.OpQ);
            this.Controls.Add((Control)this.OpCOMBO);
            this.Controls.Add((Control)this.OpSEQ);
            this.Controls.Add((Control)this.OpUR);
            this.Controls.Add((Control)this.OpA4);
            this.Controls.Add((Control)this.OpA3);
            this.Controls.Add((Control)this.OpA2);
            this.Controls.Add((Control)this.OpA1);
            this.Controls.Add((Control)this.Salchow);
            this.Controls.Add((Control)this.PictureBox6);
            this.Controls.Add((Control)this.Lutz);
            this.Controls.Add((Control)this.PictureBox5);
            this.Controls.Add((Control)this.Flip);
            this.Controls.Add((Control)this.PictureBox4);
            this.Controls.Add((Control)this.LoopText);
            this.Controls.Add((Control)this.PictureBox3);
            this.Controls.Add((Control)this.ToeLoop);
            this.Controls.Add((Control)this.PictureBox2);
            this.Controls.Add((Control)this.Axel);
            this.Controls.Add((Control)this.PictureBox1);
            this.Controls.Add((Control)this.OpClub);
            this.Controls.Add((Control)this.OpName);
            this.Controls.Add((Control)this.OpStop);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.Name = nameof(ElementInputForm);
            this.Text = "Element Input";
            this.TopMost = false;
            ((ISupportInitialize)this.DataGridView1).EndInit();
            ((ISupportInitialize)this.PictureBox13).EndInit();
            ((ISupportInitialize)this.PictureBox12).EndInit();
            ((ISupportInitialize)this.PictureBox11).EndInit();
            ((ISupportInitialize)this.PictureBox10).EndInit();
            ((ISupportInitialize)this.PictureBox9).EndInit();
            ((ISupportInitialize)this.PictureBox8).EndInit();
            ((ISupportInitialize)this.PictureBox7).EndInit();
            ((ISupportInitialize)this.PictureBox6).EndInit();
            ((ISupportInitialize)this.PictureBox5).EndInit();
            ((ISupportInitialize)this.PictureBox4).EndInit();
            ((ISupportInitialize)this.PictureBox3).EndInit();
            ((ISupportInitialize)this.PictureBox2).EndInit();
            ((ISupportInitialize)this.PictureBox1).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((ISupportInitialize)this.PictureBox14).EndInit();
            ((ISupportInitialize)this.PictureBox15).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual Button OpStop
        {
            get => this._OpStop;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpStop_Click);
                if (this._OpStop != null)
                    this._OpStop.Click -= eventHandler;
                this._OpStop = value;
                if (this._OpStop == null)
                    return;
                this._OpStop.Click += eventHandler;
            }
        }

        internal virtual TextBox OpName
        {
            get => this._OpName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._OpName = value;
        }

        internal virtual TextBox OpClub
        {
            get => this._OpClub;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._OpClub = value;
        }

        internal virtual PictureBox PictureBox1
        {
            get => this._PictureBox1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox1 = value;
        }

        internal virtual Button Axel
        {
            get => this._Axel;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Axel_Click);
                if (this._Axel != null)
                    this._Axel.Click -= eventHandler;
                this._Axel = value;
                if (this._Axel == null)
                    return;
                this._Axel.Click += eventHandler;
            }
        }

        internal virtual Button ToeLoop
        {
            get => this._ToeLoop;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ToeLoop_Click);
                if (this._ToeLoop != null)
                    this._ToeLoop.Click -= eventHandler;
                this._ToeLoop = value;
                if (this._ToeLoop == null)
                    return;
                this._ToeLoop.Click += eventHandler;
            }
        }

        internal virtual PictureBox PictureBox2
        {
            get => this._PictureBox2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox2 = value;
        }

        internal virtual Button LoopText
        {
            get => this._LoopText;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.LoopText_Click);
                if (this._LoopText != null)
                    this._LoopText.Click -= eventHandler;
                this._LoopText = value;
                if (this._LoopText == null)
                    return;
                this._LoopText.Click += eventHandler;
            }
        }

        internal virtual PictureBox PictureBox3
        {
            get => this._PictureBox3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox3 = value;
        }

        internal virtual Button Flip
        {
            get => this._Flip;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Flip_Click);
                if (this._Flip != null)
                    this._Flip.Click -= eventHandler;
                this._Flip = value;
                if (this._Flip == null)
                    return;
                this._Flip.Click += eventHandler;
            }
        }

        internal virtual PictureBox PictureBox4
        {
            get => this._PictureBox4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox4 = value;
        }

        internal virtual Button Lutz
        {
            get => this._Lutz;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Lutz_Click);
                if (this._Lutz != null)
                    this._Lutz.Click -= eventHandler;
                this._Lutz = value;
                if (this._Lutz == null)
                    return;
                this._Lutz.Click += eventHandler;
            }
        }

        internal virtual PictureBox PictureBox5
        {
            get => this._PictureBox5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox5 = value;
        }

        internal virtual Button Salchow
        {
            get => this._Salchow;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Salchow_Click);
                if (this._Salchow != null)
                    this._Salchow.Click -= eventHandler;
                this._Salchow = value;
                if (this._Salchow == null)
                    return;
                this._Salchow.Click += eventHandler;
            }
        }

        internal virtual PictureBox PictureBox6
        {
            get => this._PictureBox6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox6 = value;
        }

        internal virtual Button OpA1
        {
            get => this._OpA1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpA1_Click);
                if (this._OpA1 != null)
                    this._OpA1.Click -= eventHandler;
                this._OpA1 = value;
                if (this._OpA1 == null)
                    return;
                this._OpA1.Click += eventHandler;
            }
        }

        internal virtual Button OpA2
        {
            get => this._OpA2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpA2_Click);
                if (this._OpA2 != null)
                    this._OpA2.Click -= eventHandler;
                this._OpA2 = value;
                if (this._OpA2 == null)
                    return;
                this._OpA2.Click += eventHandler;
            }
        }

        internal virtual Button OpA3
        {
            get => this._OpA3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpA3_Click);
                if (this._OpA3 != null)
                    this._OpA3.Click -= eventHandler;
                this._OpA3 = value;
                if (this._OpA3 == null)
                    return;
                this._OpA3.Click += eventHandler;
            }
        }

        internal virtual Button OpA4
        {
            get => this._OpA4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpA4_Click);
                if (this._OpA4 != null)
                    this._OpA4.Click -= eventHandler;
                this._OpA4 = value;
                if (this._OpA4 == null)
                    return;
                this._OpA4.Click += eventHandler;
            }
        }

        internal virtual Button OpUR
        {
            get => this._OpUR;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpUR_Click);
                if (this._OpUR != null)
                    this._OpUR.Click -= eventHandler;
                this._OpUR = value;
                if (this._OpUR == null)
                    return;
                this._OpUR.Click += eventHandler;
            }
        }

        internal virtual Button OpSEQ
        {
            get => this._OpSEQ;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpSEQ_Click);
                if (this._OpSEQ != null)
                    this._OpSEQ.Click -= eventHandler;
                this._OpSEQ = value;
                if (this._OpSEQ == null)
                    return;
                this._OpSEQ.Click += eventHandler;
            }
        }

        internal virtual Button OpCOMBO
        {
            get => this._OpCOMBO;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpCOMBO_Click);
                if (this._OpCOMBO != null)
                    this._OpCOMBO.Click -= eventHandler;
                this._OpCOMBO = value;
                if (this._OpCOMBO == null)
                    return;
                this._OpCOMBO.Click += eventHandler;
            }
        }

        internal virtual Button OpDG
        {
            get => this._OpDG;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpDG_Click);
                if (this._OpDG != null)
                    this._OpDG.Click -= eventHandler;
                this._OpDG = value;
                if (this._OpDG == null)
                    return;
                this._OpDG.Click += eventHandler;
            }
        }

        internal virtual Button OpQ
        {
            get => this._OpQ;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpQ_Click);
                if (this._OpQ != null)
                    this._OpQ.Click -= eventHandler;
                this._OpQ = value;
                if (this._OpQ == null)
                    return;
                this._OpQ.Click += eventHandler;
            }
        }

        internal virtual Button Edge
        {
            get => this._Edge;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Edge_Click);
                if (this._Edge != null)
                    this._Edge.Click -= eventHandler;
                this._Edge = value;
                if (this._Edge == null)
                    return;
                this._Edge.Click += eventHandler;
            }
        }
        internal virtual Button Zero
        {
            get => this._Zero;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Zero_Click);
                if (this._Zero != null)
                    this._Zero.Click -= eventHandler;
                this._Zero = value;
                if (this._Zero == null)
                    return;
                this._Zero.Click += eventHandler;
            }
        }

        internal virtual Button Sit
        {
            get => this._Sit;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Sit_Click);
                if (this._Sit != null)
                    this._Sit.Click -= eventHandler;
                this._Sit = value;
                if (this._Sit == null)
                    return;
                this._Sit.Click += eventHandler;
            }
        }

        internal virtual PictureBox PictureBox7
        {
            get => this._PictureBox7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox7 = value;
        }

        internal virtual Button OpSSp4
        {
            get => this._OpSSp4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpSSp4_Click);
                if (this._OpSSp4 != null)
                    this._OpSSp4.Click -= eventHandler;
                this._OpSSp4 = value;
                if (this._OpSSp4 == null)
                    return;
                this._OpSSp4.Click += eventHandler;
            }
        }

        internal virtual Button OpSSp3
        {
            get => this._OpSSp3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpSSp3_Click);
                if (this._OpSSp3 != null)
                    this._OpSSp3.Click -= eventHandler;
                this._OpSSp3 = value;
                if (this._OpSSp3 == null)
                    return;
                this._OpSSp3.Click += eventHandler;
            }
        }

        internal virtual Button OpSSp2
        {
            get => this._OpSSp2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpSSp2_Click);
                if (this._OpSSp2 != null)
                    this._OpSSp2.Click -= eventHandler;
                this._OpSSp2 = value;
                if (this._OpSSp2 == null)
                    return;
                this._OpSSp2.Click += eventHandler;
            }
        }

        internal virtual Button OpSSp1
        {
            get => this._OpSSp1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpSSp1_Click);
                if (this._OpSSp1 != null)
                    this._OpSSp1.Click -= eventHandler;
                this._OpSSp1 = value;
                if (this._OpSSp1 == null)
                    return;
                this._OpSSp1.Click += eventHandler;
            }
        }

        internal virtual Button OpSSp0
        {
            get => this._OpSSp0;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpSSp0_Click);
                if (this._OpSSp0 != null)
                    this._OpSSp0.Click -= eventHandler;
                this._OpSSp0 = value;
                if (this._OpSSp0 == null)
                    return;
                this._OpSSp0.Click += eventHandler;
            }
        }

        internal virtual Button OpLSp0
        {
            get => this._OpLSp0;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpLSp0_Click);
                if (this._OpLSp0 != null)
                    this._OpLSp0.Click -= eventHandler;
                this._OpLSp0 = value;
                if (this._OpLSp0 == null)
                    return;
                this._OpLSp0.Click += eventHandler;
            }
        }

        internal virtual Button OpLSp4
        {
            get => this._OpLSp4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpLSp4_Click);
                if (this._OpLSp4 != null)
                    this._OpLSp4.Click -= eventHandler;
                this._OpLSp4 = value;
                if (this._OpLSp4 == null)
                    return;
                this._OpLSp4.Click += eventHandler;
            }
        }

        internal virtual Button OpLSp3
        {
            get => this._OpLSp3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpLSp3_Click);
                if (this._OpLSp3 != null)
                    this._OpLSp3.Click -= eventHandler;
                this._OpLSp3 = value;
                if (this._OpLSp3 == null)
                    return;
                this._OpLSp3.Click += eventHandler;
            }
        }

        internal virtual Button OpLSp2
        {
            get => this._OpLSp2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpLSp2_Click);
                if (this._OpLSp2 != null)
                    this._OpLSp2.Click -= eventHandler;
                this._OpLSp2 = value;
                if (this._OpLSp2 == null)
                    return;
                this._OpLSp2.Click += eventHandler;
            }
        }

        internal virtual Button OpLSp1
        {
            get => this._OpLSp1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpLSp1_Click);
                if (this._OpLSp1 != null)
                    this._OpLSp1.Click -= eventHandler;
                this._OpLSp1 = value;
                if (this._OpLSp1 == null)
                    return;
                this._OpLSp1.Click += eventHandler;
            }
        }

        internal virtual PictureBox PictureBox8
        {
            get => this._PictureBox8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox8 = value;
        }

        internal virtual Button Layback
        {
            get => this._Layback;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Layback_Click);
                if (this._Layback != null)
                    this._Layback.Click -= eventHandler;
                this._Layback = value;
                if (this._Layback == null)
                    return;
                this._Layback.Click += eventHandler;
            }
        }

        internal virtual Button OpUSp0
        {
            get => this._OpUSp0;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpUSp0_Click);
                if (this._OpUSp0 != null)
                    this._OpUSp0.Click -= eventHandler;
                this._OpUSp0 = value;
                if (this._OpUSp0 == null)
                    return;
                this._OpUSp0.Click += eventHandler;
            }
        }

        internal virtual Button OpUSp4
        {
            get => this._OpUSp4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpUSp4_Click);
                if (this._OpUSp4 != null)
                    this._OpUSp4.Click -= eventHandler;
                this._OpUSp4 = value;
                if (this._OpUSp4 == null)
                    return;
                this._OpUSp4.Click += eventHandler;
            }
        }

        internal virtual Button OpUSp3
        {
            get => this._OpUSp3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpUSp3_Click);
                if (this._OpUSp3 != null)
                    this._OpUSp3.Click -= eventHandler;
                this._OpUSp3 = value;
                if (this._OpUSp3 == null)
                    return;
                this._OpUSp3.Click += eventHandler;
            }
        }

        internal virtual Button OpUSp2
        {
            get => this._OpUSp2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpUSp2_Click);
                if (this._OpUSp2 != null)
                    this._OpUSp2.Click -= eventHandler;
                this._OpUSp2 = value;
                if (this._OpUSp2 == null)
                    return;
                this._OpUSp2.Click += eventHandler;
            }
        }

        internal virtual Button OpUSp1
        {
            get => this._OpUSp1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpUSp1_Click);
                if (this._OpUSp1 != null)
                    this._OpUSp1.Click -= eventHandler;
                this._OpUSp1 = value;
                if (this._OpUSp1 == null)
                    return;
                this._OpUSp1.Click += eventHandler;
            }
        }

        internal virtual PictureBox PictureBox9
        {
            get => this._PictureBox9;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox9 = value;
        }

        internal virtual Button Upright
        {
            get => this._Upright;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Upright_Click);
                if (this._Upright != null)
                    this._Upright.Click -= eventHandler;
                this._Upright = value;
                if (this._Upright == null)
                    return;
                this._Upright.Click += eventHandler;
            }
        }

        internal virtual Button OpCSp0
        {
            get => this._OpCSp0;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpCSp0_Click);
                if (this._OpCSp0 != null)
                    this._OpCSp0.Click -= eventHandler;
                this._OpCSp0 = value;
                if (this._OpCSp0 == null)
                    return;
                this._OpCSp0.Click += eventHandler;
            }
        }

        internal virtual Button OpCSp4
        {
            get => this._OpCSp4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpCSp4_Click);
                if (this._OpCSp4 != null)
                    this._OpCSp4.Click -= eventHandler;
                this._OpCSp4 = value;
                if (this._OpCSp4 == null)
                    return;
                this._OpCSp4.Click += eventHandler;
            }
        }

        internal virtual Button OpCSp3
        {
            get => this._OpCSp3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpCSp3_Click);
                if (this._OpCSp3 != null)
                    this._OpCSp3.Click -= eventHandler;
                this._OpCSp3 = value;
                if (this._OpCSp3 == null)
                    return;
                this._OpCSp3.Click += eventHandler;
            }
        }

        internal virtual Button OpCSp2
        {
            get => this._OpCSp2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpCSp2_Click);
                if (this._OpCSp2 != null)
                    this._OpCSp2.Click -= eventHandler;
                this._OpCSp2 = value;
                if (this._OpCSp2 == null)
                    return;
                this._OpCSp2.Click += eventHandler;
            }
        }

        internal virtual Button OpCSp1
        {
            get => this._OpCSp1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpCSp1_Click);
                if (this._OpCSp1 != null)
                    this._OpCSp1.Click -= eventHandler;
                this._OpCSp1 = value;
                if (this._OpCSp1 == null)
                    return;
                this._OpCSp1.Click += eventHandler;
            }
        }

        internal virtual PictureBox PictureBox10
        {
            get => this._PictureBox10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox10 = value;
        }

        internal virtual Button Camel
        {
            get => this._Camel;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Camel_Click);
                if (this._Camel != null)
                    this._Camel.Click -= eventHandler;
                this._Camel = value;
                if (this._Camel == null)
                    return;
                this._Camel.Click += eventHandler;
            }
        }

        internal virtual Button OpCoSp0
        {
            get => this._OpCoSp0;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpCoSp0_Click);
                if (this._OpCoSp0 != null)
                    this._OpCoSp0.Click -= eventHandler;
                this._OpCoSp0 = value;
                if (this._OpCoSp0 == null)
                    return;
                this._OpCoSp0.Click += eventHandler;
            }
        }

        internal virtual Button OpCoSp4
        {
            get => this._OpCoSp4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpCoSp4_Click);
                if (this._OpCoSp4 != null)
                    this._OpCoSp4.Click -= eventHandler;
                this._OpCoSp4 = value;
                if (this._OpCoSp4 == null)
                    return;
                this._OpCoSp4.Click += eventHandler;
            }
        }

        internal virtual Button OpCoSp3
        {
            get => this._OpCoSp3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpCoSp3_Click);
                if (this._OpCoSp3 != null)
                    this._OpCoSp3.Click -= eventHandler;
                this._OpCoSp3 = value;
                if (this._OpCoSp3 == null)
                    return;
                this._OpCoSp3.Click += eventHandler;
            }
        }

        internal virtual Button OpCoSp2
        {
            get => this._OpCoSp2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpCoSp2_Click);
                if (this._OpCoSp2 != null)
                    this._OpCoSp2.Click -= eventHandler;
                this._OpCoSp2 = value;
                if (this._OpCoSp2 == null)
                    return;
                this._OpCoSp2.Click += eventHandler;
            }
        }

        internal virtual Button OpCoSp1
        {
            get => this._OpCoSp1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpCoSp1_Click);
                if (this._OpCoSp1 != null)
                    this._OpCoSp1.Click -= eventHandler;
                this._OpCoSp1 = value;
                if (this._OpCoSp1 == null)
                    return;
                this._OpCoSp1.Click += eventHandler;
            }
        }

        internal virtual PictureBox PictureBox11
        {
            get => this._PictureBox11;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox11 = value;
        }

        internal virtual Button ComboSpin
        {
            get => this._ComboSpin;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ComboSpin_Click);
                if (this._ComboSpin != null)
                    this._ComboSpin.Click -= eventHandler;
                this._ComboSpin = value;
                if (this._ComboSpin == null)
                    return;
                this._ComboSpin.Click += eventHandler;
            }
        }

        internal virtual Button OpChange
        {
            get => this._OpChange;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpChange_Click);
                if (this._OpChange != null)
                    this._OpChange.Click -= eventHandler;
                this._OpChange = value;
                if (this._OpChange == null)
                    return;
                this._OpChange.Click += eventHandler;
            }
        }

        internal virtual Button OpFlying
        {
            get => this._OpFlying;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpFlying_Click);
                if (this._OpFlying != null)
                    this._OpFlying.Click -= eventHandler;
                this._OpFlying = value;
                if (this._OpFlying == null)
                    return;
                this._OpFlying.Click += eventHandler;
            }
        }

        internal virtual Label Label1
        {
            get => this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label1 = value;
        }

        internal virtual Label Label3
        {
            get => this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label3 = value;
        }

        internal virtual Button ChSq1
        {
            get => this._ChSq1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ChSq1_Click);
                if (this._ChSq1 != null)
                    this._ChSq1.Click -= eventHandler;
                this._ChSq1 = value;
                if (this._ChSq1 == null)
                    return;
                this._ChSq1.Click += eventHandler;
            }
        }

        internal virtual Button ChoreoSeq
        {
            get => this._ChoreoSeq;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ChoreoSeq_Click);
                if (this._ChoreoSeq != null)
                    this._ChoreoSeq.Click -= eventHandler;
                this._ChoreoSeq = value;
                if (this._ChoreoSeq == null)
                    return;
                this._ChoreoSeq.Click += eventHandler;
            }
        }

        internal virtual PictureBox PictureBox12
        {
            get => this._PictureBox12;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox12 = value;
        }

        internal virtual Button OpStSq0
        {
            get => this._OpStSq0;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpStSq0_Click);
                if (this._OpStSq0 != null)
                    this._OpStSq0.Click -= eventHandler;
                this._OpStSq0 = value;
                if (this._OpStSq0 == null)
                    return;
                this._OpStSq0.Click += eventHandler;
            }
        }

        internal virtual Button OpStSq4
        {
            get => this._OpStSq4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpStSq4_Click);
                if (this._OpStSq4 != null)
                    this._OpStSq4.Click -= eventHandler;
                this._OpStSq4 = value;
                if (this._OpStSq4 == null)
                    return;
                this._OpStSq4.Click += eventHandler;
            }
        }

        internal virtual Button OpStSq3
        {
            get => this._OpStSq3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpStSq3_Click);
                if (this._OpStSq3 != null)
                    this._OpStSq3.Click -= eventHandler;
                this._OpStSq3 = value;
                if (this._OpStSq3 == null)
                    return;
                this._OpStSq3.Click += eventHandler;
            }
        }

        internal virtual Button OpStSq2
        {
            get => this._OpStSq2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpStSq2_Click);
                if (this._OpStSq2 != null)
                    this._OpStSq2.Click -= eventHandler;
                this._OpStSq2 = value;
                if (this._OpStSq2 == null)
                    return;
                this._OpStSq2.Click += eventHandler;
            }
        }

        internal virtual Button OpStSq1
        {
            get => this._OpStSq1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpStSq1_Click);
                if (this._OpStSq1 != null)
                    this._OpStSq1.Click -= eventHandler;
                this._OpStSq1 = value;
                if (this._OpStSq1 == null)
                    return;
                this._OpStSq1.Click += eventHandler;
            }
        }

        internal virtual PictureBox PictureBox13
        {
            get => this._PictureBox13;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox13 = value;
        }

        internal virtual Button Straight
        {
            get => this._Straight;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Straight_Click);
                if (this._Straight != null)
                    this._Straight.Click -= eventHandler;
                this._Straight = value;
                if (this._Straight == null)
                    return;
                this._Straight.Click += eventHandler;
            }
        }

        internal virtual Button OpNext1
        {
            get => this._OpNext1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpNext1_Click);
                if (this._OpNext1 != null)
                    this._OpNext1.Click -= eventHandler;
                this._OpNext1 = value;
                if (this._OpNext1 == null)
                    return;
                this._OpNext1.Click += eventHandler;
            }
        }

        internal virtual Button OpDeleteRow
        {
            get => this._OpDeleteRow;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpDeleteRow_Click);
                if (this._OpDeleteRow != null)
                    this._OpDeleteRow.Click -= eventHandler;
                this._OpDeleteRow = value;
                if (this._OpDeleteRow == null)
                    return;
                this._OpDeleteRow.Click += eventHandler;
            }
        }

        internal virtual Button OpInsert
        {
            get => this._OpInsert;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpInsert_Click);
                if (this._OpInsert != null)
                    this._OpInsert.Click -= eventHandler;
                this._OpInsert = value;
                if (this._OpInsert == null)
                    return;
                this._OpInsert.Click += eventHandler;
            }
        }

        internal virtual Button OpClearEntry
        {
            get => this._OpClearEntry;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpClearEntry_Click);
                if (this._OpClearEntry != null)
                    this._OpClearEntry.Click -= eventHandler;
                this._OpClearEntry = value;
                if (this._OpClearEntry == null)
                    return;
                this._OpClearEntry.Click += eventHandler;
            }
        }

        internal virtual Button Review
        {
            get => this._Review;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Review_Click);
                if (this._Review != null)
                    this._Review.Click -= eventHandler;
                this._Review = value;
                if (this._Review == null)
                    return;
                this._Review.Click += eventHandler;
            }
        }

        internal virtual Button Falls_minus
        {
            get => this._Falls_minus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Falls_minus_Click);
                if (this._Falls_minus != null)
                    this._Falls_minus.Click -= eventHandler;
                this._Falls_minus = value;
                if (this._Falls_minus == null)
                    return;
                this._Falls_minus.Click += eventHandler;
            }
        }

        internal virtual Button Falls
        {
            get => this._Falls;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Falls_Click);
                if (this._Falls != null)
                    this._Falls.Click -= eventHandler;
                this._Falls = value;
                if (this._Falls == null)
                    return;
                this._Falls.Click += eventHandler;
            }
        }

        internal virtual Button Falls_out
        {
            get => this._Falls_out;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Falls_out_Click);
                if (this._Falls_out != null)
                    this._Falls_out.Click -= eventHandler;
                this._Falls_out = value;
                if (this._Falls_out == null)
                    return;
                this._Falls_out.Click += eventHandler;
            }
        }

        internal virtual Button OpT4
        {
            get => this._OpT4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpT4_Click);
                if (this._OpT4 != null)
                    this._OpT4.Click -= eventHandler;
                this._OpT4 = value;
                if (this._OpT4 == null)
                    return;
                this._OpT4.Click += eventHandler;
            }
        }

        internal virtual Button OpT3
        {
            get => this._OpT3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpT3_Click);
                if (this._OpT3 != null)
                    this._OpT3.Click -= eventHandler;
                this._OpT3 = value;
                if (this._OpT3 == null)
                    return;
                this._OpT3.Click += eventHandler;
            }
        }

        internal virtual Button OpT2
        {
            get => this._OpT2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpT2_Click);
                if (this._OpT2 != null)
                    this._OpT2.Click -= eventHandler;
                this._OpT2 = value;
                if (this._OpT2 == null)
                    return;
                this._OpT2.Click += eventHandler;
            }
        }

        internal virtual Button OpT1
        {
            get => this._OpT1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpT1_Click);
                if (this._OpT1 != null)
                    this._OpT1.Click -= eventHandler;
                this._OpT1 = value;
                if (this._OpT1 == null)
                    return;
                this._OpT1.Click += eventHandler;
            }
        }

        internal virtual Button OpL4
        {
            get => this._OpL4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpL4_Click);
                if (this._OpL4 != null)
                    this._OpL4.Click -= eventHandler;
                this._OpL4 = value;
                if (this._OpL4 == null)
                    return;
                this._OpL4.Click += eventHandler;
            }
        }

        internal virtual Button OpL3
        {
            get => this._OpL3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpL3_Click);
                if (this._OpL3 != null)
                    this._OpL3.Click -= eventHandler;
                this._OpL3 = value;
                if (this._OpL3 == null)
                    return;
                this._OpL3.Click += eventHandler;
            }
        }

        internal virtual Button OpL2
        {
            get => this._OpL2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpL2_Click);
                if (this._OpL2 != null)
                    this._OpL2.Click -= eventHandler;
                this._OpL2 = value;
                if (this._OpL2 == null)
                    return;
                this._OpL2.Click += eventHandler;
            }
        }

        internal virtual Button OpL1
        {
            get => this._OpL1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpL1_Click);
                if (this._OpL1 != null)
                    this._OpL1.Click -= eventHandler;
                this._OpL1 = value;
                if (this._OpL1 == null)
                    return;
                this._OpL1.Click += eventHandler;
            }
        }

        internal virtual Button OpF4
        {
            get => this._OpF4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpF4_Click);
                if (this._OpF4 != null)
                    this._OpF4.Click -= eventHandler;
                this._OpF4 = value;
                if (this._OpF4 == null)
                    return;
                this._OpF4.Click += eventHandler;
            }
        }

        internal virtual Button OpF3
        {
            get => this._OpF3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpF3_Click);
                if (this._OpF3 != null)
                    this._OpF3.Click -= eventHandler;
                this._OpF3 = value;
                if (this._OpF3 == null)
                    return;
                this._OpF3.Click += eventHandler;
            }
        }

        internal virtual Button OpF2
        {
            get => this._OpF2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpF2_Click);
                if (this._OpF2 != null)
                    this._OpF2.Click -= eventHandler;
                this._OpF2 = value;
                if (this._OpF2 == null)
                    return;
                this._OpF2.Click += eventHandler;
            }
        }

        internal virtual Button OpF1
        {
            get => this._OpF1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpF1_Click);
                if (this._OpF1 != null)
                    this._OpF1.Click -= eventHandler;
                this._OpF1 = value;
                if (this._OpF1 == null)
                    return;
                this._OpF1.Click += eventHandler;
            }
        }

        internal virtual Button OpLz4
        {
            get => this._OpLz4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpLz4_Click);
                if (this._OpLz4 != null)
                    this._OpLz4.Click -= eventHandler;
                this._OpLz4 = value;
                if (this._OpLz4 == null)
                    return;
                this._OpLz4.Click += eventHandler;
            }
        }

        internal virtual Button OpLz3
        {
            get => this._OpLz3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpLz3_Click);
                if (this._OpLz3 != null)
                    this._OpLz3.Click -= eventHandler;
                this._OpLz3 = value;
                if (this._OpLz3 == null)
                    return;
                this._OpLz3.Click += eventHandler;
            }
        }

        internal virtual Button OpLz2
        {
            get => this._OpLz2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpLz2_Click);
                if (this._OpLz2 != null)
                    this._OpLz2.Click -= eventHandler;
                this._OpLz2 = value;
                if (this._OpLz2 == null)
                    return;
                this._OpLz2.Click += eventHandler;
            }
        }

        internal virtual Button OpLz1
        {
            get => this._OpLz1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpLz1_Click);
                if (this._OpLz1 != null)
                    this._OpLz1.Click -= eventHandler;
                this._OpLz1 = value;
                if (this._OpLz1 == null)
                    return;
                this._OpLz1.Click += eventHandler;
            }
        }

        internal virtual Button OpS4
        {
            get => this._OpS4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpS4_Click);
                if (this._OpS4 != null)
                    this._OpS4.Click -= eventHandler;
                this._OpS4 = value;
                if (this._OpS4 == null)
                    return;
                this._OpS4.Click += eventHandler;
            }
        }

        internal virtual Button OpS3
        {
            get => this._OpS3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpS3_Click);
                if (this._OpS3 != null)
                    this._OpS3.Click -= eventHandler;
                this._OpS3 = value;
                if (this._OpS3 == null)
                    return;
                this._OpS3.Click += eventHandler;
            }
        }

        internal virtual Button OpS2
        {
            get => this._OpS2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpS2_Click);
                if (this._OpS2 != null)
                    this._OpS2.Click -= eventHandler;
                this._OpS2 = value;
                if (this._OpS2 == null)
                    return;
                this._OpS2.Click += eventHandler;
            }
        }

        internal virtual Button OpS1
        {
            get => this._OpS1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpS1_Click);
                if (this._OpS1 != null)
                    this._OpS1.Click -= eventHandler;
                this._OpS1 = value;
                if (this._OpS1 == null)
                    return;
                this._OpS1.Click += eventHandler;
            }
        }

        internal virtual Button HalfTime
        {
            get => this._HalfTime;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.HalfTime_Click);
                if (this._HalfTime != null)
                    this._HalfTime.Click -= eventHandler;
                this._HalfTime = value;
                if (this._HalfTime == null)
                    return;
                this._HalfTime.Click += eventHandler;
            }
        }

        internal virtual Button StartHT
        {
            get => this._StartHT;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.StartHT_Click);
                if (this._StartHT != null)
                    this._StartHT.Click -= eventHandler;
                this._StartHT = value;
                if (this._StartHT == null)
                    return;
                this._StartHT.Click += eventHandler;
            }
        }

        internal virtual Button StopHT
        {
            get => this._StopHT;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.StopHT_Click);
                if (this._StopHT != null)
                    this._StopHT.Click -= eventHandler;
                this._StopHT = value;
                if (this._StopHT == null)
                    return;
                this._StopHT.Click += eventHandler;
            }
        }

        internal virtual Button Bonus_minus
        {
            get => this._Bonus_minus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Bonus_minus_Click);
                if (this._Bonus_minus != null)
                    this._Bonus_minus.Click -= eventHandler;
                this._Bonus_minus = value;
                if (this._Bonus_minus == null)
                    return;
                this._Bonus_minus.Click += eventHandler;
            }
        }

        internal virtual Button Bonus_plus
        {
            get => this._Bonus_plus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Bonus_plus_Click);
                if (this._Bonus_plus != null)
                    this._Bonus_plus.Click -= eventHandler;
                this._Bonus_plus = value;
                if (this._Bonus_plus == null)
                    return;
                this._Bonus_plus.Click += eventHandler;
            }
        }

        internal virtual Button Bonus
        {
            get => this._Bonus;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Bonus_Click);
                if (this._Bonus != null)
                    this._Bonus.Click -= eventHandler;
                this._Bonus = value;
                if (this._Bonus == null)
                    return;
                this._Bonus.Click += eventHandler;
            }
        }

        internal virtual TextBox OpMsg
        {
            get => this._OpMsg;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._OpMsg = value;
        }

        internal virtual Button Set0
        {
            get => this._Set0;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Set0_Click);
                if (this._Set0 != null)
                    this._Set0.Click -= eventHandler;
                this._Set0 = value;
                if (this._Set0 == null)
                    return;
                this._Set0.Click += eventHandler;
            }
        }

        internal virtual Button Set4
        {
            get => this._Set4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Set4_Click);
                if (this._Set4 != null)
                    this._Set4.Click -= eventHandler;
                this._Set4 = value;
                if (this._Set4 == null)
                    return;
                this._Set4.Click += eventHandler;
            }
        }

        internal virtual Button Set3
        {
            get => this._Set3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Set3_Click);
                if (this._Set3 != null)
                    this._Set3.Click -= eventHandler;
                this._Set3 = value;
                if (this._Set3 == null)
                    return;
                this._Set3.Click += eventHandler;
            }
        }

        internal virtual Button Set2
        {
            get => this._Set2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Set2_Click);
                if (this._Set2 != null)
                    this._Set2.Click -= eventHandler;
                this._Set2 = value;
                if (this._Set2 == null)
                    return;
                this._Set2.Click += eventHandler;
            }
        }

        internal virtual Button Set1
        {
            get => this._Set1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Set1_Click);
                if (this._Set1 != null)
                    this._Set1.Click -= eventHandler;
                this._Set1 = value;
                if (this._Set1 == null)
                    return;
                this._Set1.Click += eventHandler;
            }
        }

        internal virtual Button NoLevel
        {
            get => this._NoLevel;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.NoLevel_Click);
                if (this._NoLevel != null)
                    this._NoLevel.Click -= eventHandler;
                this._NoLevel = value;
                if (this._NoLevel == null)
                    return;
                this._NoLevel.Click += eventHandler;
            }
        }

        internal virtual Label ColorBox
        {
            get => this._ColorBox;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ColorBox = value;
        }

        internal virtual DataGridView DataGridView1
        {
            get => this._DataGridView1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyEventHandler keyEventHandler = new KeyEventHandler(this.DataGridView1_KeyDown);
                EventHandler eventHandler1 = new EventHandler(this.DataGridView1_DoubleClick);
                EventHandler eventHandler2 = new EventHandler(this.DataGridView1_Click);
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.DataGridView1_KeyPress);
                if (this._DataGridView1 != null)
                {
                    this._DataGridView1.KeyDown -= keyEventHandler;
                    this._DataGridView1.DoubleClick -= eventHandler1;
                    this._DataGridView1.Click -= eventHandler2;
                    this._DataGridView1.KeyPress -= pressEventHandler;
                }
                this._DataGridView1 = value;
                if (this._DataGridView1 == null)
                    return;
                this._DataGridView1.KeyDown += keyEventHandler;
                this._DataGridView1.DoubleClick += eventHandler1;
                this._DataGridView1.Click += eventHandler2;
                this._DataGridView1.KeyPress += pressEventHandler;
            }
        }

        internal virtual Button Time
        {
            get => this._Time;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Time = value;
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

        internal virtual Button OpExcl
        {
            get => this._OpExcl;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpExcl_Click);
                if (this._OpExcl != null)
                    this._OpExcl.Click -= eventHandler;
                this._OpExcl = value;
                if (this._OpExcl == null)
                    return;
                this._OpExcl.Click += eventHandler;
            }
        }

        internal virtual Button OpFallinElement
        {
            get => this._OpFallinElement;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpFallinElement_Click);
                if (this._OpFallinElement != null)
                    this._OpFallinElement.Click -= eventHandler;
                this._OpFallinElement = value;
                if (this._OpFallinElement == null)
                    return;
                this._OpFallinElement.Click += eventHandler;
            }
        }

        internal virtual Button Spin_V
        {
            get => this._Spin_V;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Spin_V_Click);
                if (this._Spin_V != null)
                    this._Spin_V.Click -= eventHandler;
                this._Spin_V = value;
                if (this._Spin_V == null)
                    return;
                this._Spin_V.Click += eventHandler;
            }
        }

        internal virtual Button opREP
        {
            get => this._opREP;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.opREP_Click);
                if (this._opREP != null)
                    this._opREP.Click -= eventHandler;
                this._opREP = value;
                if (this._opREP == null)
                    return;
                this._opREP.Click += eventHandler;
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

        internal virtual Button btnDED
        {
            get => this._btnDED;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnDED_Click);
                if (this._btnDED != null)
                    this._btnDED.Click -= eventHandler;
                this._btnDED = value;
                if (this._btnDED == null)
                    return;
                this._btnDED.Click += eventHandler;
            }
        }

        internal virtual TextBox txtInfo2
        {
            get => this._txtInfo2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtInfo2 = value;
        }

        internal virtual Button OpEu1
        {
            get => this._OpEu1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpEu1_Click);
                if (this._OpEu1 != null)
                    this._OpEu1.Click -= eventHandler;
                this._OpEu1 = value;
                if (this._OpEu1 == null)
                    return;
                this._OpEu1.Click += eventHandler;
            }
        }

        internal virtual Button OpW1
        {
            get => this._OpW1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpW1_Click);
                if (this._OpW1 != null)
                    this._OpW1.Click -= eventHandler;
                this._OpW1 = value;
                if (this._OpW1 == null)
                    return;
                this._OpW1.Click += eventHandler;
            }
        }

        internal virtual Button Euler
        {
            get => this._Euler;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Euler_Click);
                if (this._Euler != null)
                    this._Euler.Click -= eventHandler;
                this._Euler = value;
                if (this._Euler == null)
                    return;
                this._Euler.Click += eventHandler;
            }
        }

        internal virtual Button Waltz
        {
            get => this._Waltz;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Waltz_Click);
                if (this._Waltz != null)
                    this._Waltz.Click -= eventHandler;
                this._Waltz = value;
                if (this._Waltz == null)
                    return;
                this._Waltz.Click += eventHandler;
            }
        }

        internal virtual PictureBox PictureBox14
        {
            get => this._PictureBox14;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox14 = value;
        }

        internal virtual PictureBox PictureBox15
        {
            get => this._PictureBox15;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox15 = value;
        }

        internal virtual Label Label2
        {
            get => this._Label2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label2 = value;
        }

        private void ElementInputForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (this.WillExit || Interaction.MsgBox((object)"Do you really want to exit?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW") != MsgBoxResult.No)
                return;
            e.Cancel = true;
        }

        private void ElementInputForm_Load(object sender, EventArgs e)
        {
            this.Left = checked((int)Math.Round(unchecked((double)checked(Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2.0)));
            this.Top = 0;
            if (Program.WorkMode > 1)
            {
                this.Panel1.Location = new Point(806, 1);
                this.Panel1.Visible = true;
            }
            else
                this.Panel1.Visible = false;
            this.Timer1.Enabled = false;
            string segment = Program.Segment;
            if (Operators.CompareString(segment, "Seg1", false) == 0)
                this.ProgramHalfTime = this.CalcHalfTime(Program.OpenDB[Program.PcIndex].Seg1Time);
            else if (Operators.CompareString(segment, "Seg2", false) == 0)
                this.ProgramHalfTime = this.CalcHalfTime(Program.OpenDB[Program.PcIndex].Seg2Time);
            this.ShowDatagrid();
            if (Program.AdjustToScreen != 1)
                return;
            this.AdjustTheDisplay();
        }

        private void ShowPanel(float Xratio, float Yratio)
        {
            int emSize = checked((int)Math.Round(unchecked((double)Xratio * 7.0)));
            Panel panel1 = this.Panel1;
            int num = 1;
            do
            {
                string key = "txtJ" + Conversions.ToString(num);
                panel1.Controls[key].Dock = DockStyle.None;
                panel1.Controls[key].Left = checked((int)Math.Round(unchecked((double)panel1.Controls[key].Left * (double)Xratio)));
                panel1.Controls[key].Width = checked((int)Math.Round(unchecked((double)panel1.Controls[key].Width * (double)Xratio)));
                panel1.Controls[key].Top = checked((int)Math.Round(unchecked((double)panel1.Controls[key].Top * (double)Yratio)));
                panel1.Controls[key].Font = new Font("Microsoft Sans Serif", (float)emSize, FontStyle.Bold);
                checked { ++num; }
            }
            while (num <= 7);
            this.txtEl.Left = checked((int)Math.Round(unchecked((double)this.txtEl.Left * (double)Xratio)));
            this.txtEl.Width = checked((int)Math.Round(unchecked((double)this.txtEl.Width * (double)Xratio)));
            this.txtEl.Top = checked((int)Math.Round(unchecked((double)this.txtEl.Top * (double)Yratio)));
            this.txtEl.Font = new Font("Microsoft Sans Serif", (float)emSize, FontStyle.Bold);
            this.txtInfo.Left = checked((int)Math.Round(unchecked((double)this.txtInfo.Left * (double)Xratio)));
            this.txtInfo.Width = checked((int)Math.Round(unchecked((double)this.txtInfo.Width * (double)Xratio)));
            this.txtInfo.Top = checked((int)Math.Round(unchecked((double)this.txtInfo.Top * (double)Yratio)));
            this.txtInfo.Font = new Font("Microsoft Sans Serif", (float)emSize, FontStyle.Bold);
            this.txtInfo2.Left = checked((int)Math.Round(unchecked((double)this.txtInfo2.Left * (double)Xratio)));
            this.txtInfo2.Width = checked((int)Math.Round(unchecked((double)this.txtInfo2.Width * (double)Xratio)));
            this.txtInfo2.Top = checked((int)Math.Round(unchecked((double)this.txtInfo2.Top * (double)Yratio)));
            this.txtInfo2.Font = new Font("Microsoft Sans Serif", (float)emSize, FontStyle.Bold);
        }

        private void AdjustTheDisplay()
        {
            // ISSUE: unable to decompile the method.
        }

        private void ResizeThem(float Xratio, float Yratio)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                DataGridViewColumn column1 = this.DataGridView1.Columns[0];
                num3 = 2;
                DataGridViewColumn column2 = this.DataGridView1.Columns[1];
                num3 = 3;
                DataGridViewColumn column3 = this.DataGridView1.Columns[2];
                num3 = 4;
                DataGridViewColumn column4 = this.DataGridView1.Columns[3];
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 6;
                int emSize1 = checked((int)Math.Round(unchecked((double)Xratio * 8.0)));
                num3 = 7;
                int num4 = checked((int)Math.Round(unchecked((double)Xratio * 11.25)));
                num3 = 8;
                int emSize2 = checked((int)Math.Round(unchecked((double)Xratio * 8.25)));
                num3 = 9;
                int emSize3 = checked((int)Math.Round(unchecked((double)Xratio * 12.0)));
                num3 = 10;
                int emSize4 = checked((int)Math.Round(unchecked((double)Xratio * 16.0)));
                num3 = 11;
                int emSize5 = checked((int)Math.Round(unchecked((double)Xratio * 20.0)));
                num3 = 12;
                int num5 = checked(this.CtlArray.Count - 1);
                int index1 = 0;
                while (index1 <= num5)
                {
                    num3 = 13;
                    if (!(this.CtlArray[index1] is MenuStrip))
                    {
                        num3 = 15;
                        num3 = 16;
                        if (!(this.CtlArray[index1] is Panel & NewLateBinding.LateGet(this.CtlArray[index1], (System.Type)null, "parent", new object[0], (string[])null, (System.Type[])null, (bool[])null) != this))
                        {
                            num3 = 18;
                            num3 = 19;
                            object Left1 = NewLateBinding.LateGet(this.CtlArray[index1], (System.Type)null, "name", new object[0], (string[])null, (System.Type[])null, (bool[])null);
                            num3 = 22;
                            if (Operators.ConditionalCompareObjectEqual(Left1, (object)"DataGridView1", false))
                            {
                                num3 = 23;
                                NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "autosize", new object[1]
                                {
                  (object) false
                                }, (string[])null, (System.Type[])null, false, true);
                                num3 = 24;
                                NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "dock", new object[1]
                                {
                  (object) 0
                                }, (string[])null, (System.Type[])null, false, true);
                                num3 = 25;
                                NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "width", new object[1]
                                {
                  Operators.MultiplyObject(NewLateBinding.LateGet(this.CtlArray[index1], (System.Type) null, "width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) Xratio)
                                }, (string[])null, (System.Type[])null, false, true);
                                num3 = 26;
                                NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "left", new object[1]
                                {
                  Operators.MultiplyObject(NewLateBinding.LateGet(this.CtlArray[index1], (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) Xratio)
                                }, (string[])null, (System.Type[])null, false, true);
                                num3 = 27;
                                NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "height", new object[1]
                                {
                  Operators.MultiplyObject(NewLateBinding.LateGet(this.CtlArray[index1], (System.Type) null, "height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) Yratio)
                                }, (string[])null, (System.Type[])null, false, true);
                                num3 = 28;
                                NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "top", new object[1]
                                {
                  Operators.MultiplyObject(NewLateBinding.LateGet(this.CtlArray[index1], (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) Yratio)
                                }, (string[])null, (System.Type[])null, false, true);
                                num3 = 29;
                                column1.Width = checked((int)Math.Round(unchecked((double)column1.Width * (double)Xratio)));
                                num3 = 30;
                                column2.Width = checked((int)Math.Round(unchecked((double)column2.Width * (double)Xratio)));
                                num3 = 31;
                                column3.Width = checked((int)Math.Round(unchecked((double)column3.Width * (double)Xratio)));
                                num3 = 32;
                                column4.Width = checked((int)Math.Round(unchecked((double)column4.Width * (double)Xratio)));
                                num3 = 33;
                                int num6 = checked(this.DataGridView1.Rows.Count - 1);
                                int index2 = 0;
                                while (index2 <= num6)
                                {
                                    num3 = 34;
                                    DataGridViewRow row = this.DataGridView1.Rows[index2];
                                    num3 = 35;
                                    row.Height = checked((int)Math.Round(unchecked((double)row.Height * (double)Yratio)));
                                    num3 = 36;
                                    checked { ++index2; }
                                }
                                num3 = 37;
                                this.DataGridView1.Columns[0].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", (float)emSize2, FontStyle.Regular);
                                num3 = 38;
                                this.DataGridView1.Columns[1].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", (float)emSize2, FontStyle.Bold);
                                num3 = 39;
                                this.DataGridView1.Columns[2].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", (float)emSize2, FontStyle.Regular);
                                num3 = 40;
                                this.DataGridView1.Columns[3].DefaultCellStyle.Font = new Font("Microsoft Sans Serif", (float)emSize2, FontStyle.Regular);
                            }
                            else
                            {
                                num3 = 43;
                                NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "autosize", new object[1]
                                {
                  (object) false
                                }, (string[])null, (System.Type[])null, false, true);
                                num3 = 44;
                                NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "dock", new object[1]
                                {
                  (object) 0
                                }, (string[])null, (System.Type[])null, false, true);
                                num3 = 45;
                                NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "width", new object[1]
                                {
                  Operators.MultiplyObject(NewLateBinding.LateGet(this.CtlArray[index1], (System.Type) null, "width", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) Xratio)
                                }, (string[])null, (System.Type[])null, false, true);
                                num3 = 46;
                                NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "left", new object[1]
                                {
                  Operators.MultiplyObject(NewLateBinding.LateGet(this.CtlArray[index1], (System.Type) null, "left", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) Xratio)
                                }, (string[])null, (System.Type[])null, false, true);
                                num3 = 47;
                                NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "height", new object[1]
                                {
                  Operators.MultiplyObject(NewLateBinding.LateGet(this.CtlArray[index1], (System.Type) null, "height", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) Yratio)
                                }, (string[])null, (System.Type[])null, false, true);
                                num3 = 48;
                                NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "top", new object[1]
                                {
                  Operators.MultiplyObject(NewLateBinding.LateGet(this.CtlArray[index1], (System.Type) null, "top", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null), (object) Yratio)
                                }, (string[])null, (System.Type[])null, false, true);
                                num3 = 49;
                                object Left2 = NewLateBinding.LateGet(this.CtlArray[index1], (System.Type)null, "name", new object[0], (string[])null, (System.Type[])null, (bool[])null);
                                num3 = 52;
                                if (Operators.ConditionalCompareObjectEqual(Left2, (object)"PictureBox1", false))
                                {
                                    num3 = 53;
                                    this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                }
                                else
                                {
                                    num3 = 55;
                                    if (Operators.ConditionalCompareObjectEqual(Left2, (object)"PictureBox2", false))
                                    {
                                        num3 = 56;
                                        this.PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                    else
                                    {
                                        num3 = 58;
                                        if (Operators.ConditionalCompareObjectEqual(Left2, (object)"PictureBox3", false))
                                        {
                                            num3 = 59;
                                            this.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                                        }
                                        else
                                        {
                                            num3 = 61;
                                            if (Operators.ConditionalCompareObjectEqual(Left2, (object)"PictureBox4", false))
                                            {
                                                num3 = 62;
                                                this.PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                                            }
                                            else
                                            {
                                                num3 = 64;
                                                if (Operators.ConditionalCompareObjectEqual(Left2, (object)"PictureBox5", false))
                                                {
                                                    num3 = 65;
                                                    this.PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                                                }
                                                else
                                                {
                                                    num3 = 67;
                                                    if (Operators.ConditionalCompareObjectEqual(Left2, (object)"PictureBox6", false))
                                                    {
                                                        num3 = 68;
                                                        this.PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
                                                    }
                                                    else
                                                    {
                                                        num3 = 70;
                                                        if (Operators.ConditionalCompareObjectEqual(Left2, (object)"PictureBox7", false))
                                                        {
                                                            num3 = 71;
                                                            this.PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
                                                        }
                                                        else
                                                        {
                                                            num3 = 73;
                                                            if (Operators.ConditionalCompareObjectEqual(Left2, (object)"PictureBox8", false))
                                                            {
                                                                num3 = 74;
                                                                this.PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
                                                            }
                                                            else
                                                            {
                                                                num3 = 76;
                                                                if (Operators.ConditionalCompareObjectEqual(Left2, (object)"PictureBox9", false))
                                                                {
                                                                    num3 = 77;
                                                                    this.PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
                                                                }
                                                                else
                                                                {
                                                                    num3 = 79;
                                                                    if (Operators.ConditionalCompareObjectEqual(Left2, (object)"PictureBox10", false))
                                                                    {
                                                                        num3 = 80;
                                                                        this.PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
                                                                    }
                                                                    else
                                                                    {
                                                                        num3 = 82;
                                                                        if (Operators.ConditionalCompareObjectEqual(Left2, (object)"PictureBox11", false))
                                                                        {
                                                                            num3 = 83;
                                                                            this.PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
                                                                        }
                                                                        else
                                                                        {
                                                                            num3 = 85;
                                                                            if (Operators.ConditionalCompareObjectEqual(Left2, (object)"PictureBox12", false))
                                                                            {
                                                                                num3 = 86;
                                                                                this.PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
                                                                            }
                                                                            else
                                                                            {
                                                                                num3 = 88;
                                                                                if (Operators.ConditionalCompareObjectEqual(Left2, (object)"PictureBox13", false))
                                                                                {
                                                                                    num3 = 89;
                                                                                    this.PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
                                                                                }
                                                                                else
                                                                                {
                                                                                    num3 = 91;
                                                                                    if (Operators.ConditionalCompareObjectEqual(Left2, (object)"PictureBox14", false))
                                                                                    {
                                                                                        num3 = 92;
                                                                                        this.PictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        num3 = 94;
                                                                                        if (Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"OpName", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"OpClub", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"OpMsg", false)) ? (object)true : (object)false))
                                                                                        {
                                                                                            num3 = 95;
                                                                                            NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "font", new object[1]
                                                                                            {
                                                (object) new Font("Microsoft Sans Serif", (float) emSize3, FontStyle.Bold)
                                                                                            }, (string[])null, (System.Type[])null, false, true);
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            num3 = 97;
                                                                                            if (Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"OpNext1", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"OpDeleteRow", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"OpInsert", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"OpClearEntry", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Review", false)) ? (object)true : (object)false))
                                                                                            {
                                                                                                num3 = 98;
                                                                                                NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "font", new object[1]
                                                                                                {
                                                  (object) new Font("Microsoft Sans Serif", (float) emSize3, FontStyle.Bold)
                                                                                                }, (string[])null, (System.Type[])null, false, true);
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                num3 = 100;
                                                                                                if (Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Spin_V", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"btn2p", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"btn3p", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"OpChange", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"OpFlying", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Label1", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Label2", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Label3", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Label4", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"ColorBox", false)) ? (object)true : (object)false))
                                                                                                {
                                                                                                    num3 = 101;
                                                                                                    NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "font", new object[1]
                                                                                                    {
                                                    (object) new Font("Microsoft Sans Serif", (float) emSize3, FontStyle.Bold)
                                                                                                    }, (string[])null, (System.Type[])null, false, true);
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    num3 = 103;
                                                                                                    if (Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Zero", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"OpExcl", false)) ? (object)true : (object)false))
                                                                                                    {
                                                                                                        num3 = 104;
                                                                                                        NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "font", new object[1]
                                                                                                        {
                                                      (object) new Font("Microsoft Sans Serif", (float) emSize4, FontStyle.Bold)
                                                                                                        }, (string[])null, (System.Type[])null, false, true);
                                                                                                    }
                                                                                                    else if (Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Zero", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"OpFallinElement", false)) ? (object)true : (object)false))
                                                                                                    {
                                                                                                        num3 = 105;
                                                                                                        NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "font", new object[1]
                                                                                                        {
                                                      (object) new Font("Microsoft Sans Serif", (float) emSize4, FontStyle.Bold)
                                                                                                        }, (string[])null, (System.Type[])null, false, true);
                                                                                                    }
                                                                                                    else
                                                                                                    {


                                                                                                        num3 = 106;
                                                                                                        if (Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"ChSq1", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"NoLevel", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Set0", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Set1", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Set2", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Set3", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Set4", false)) ? (object)true : (object)false))
                                                                                                        {
                                                                                                            num3 = 107;
                                                                                                            NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "font", new object[1]
                                                                                                            {
                                                        (object) new Font("Microsoft Sans Serif", (float) emSize4, FontStyle.Bold)
                                                                                                            }, (string[])null, (System.Type[])null, false, true);
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            num3 = 109;
                                                                                                            if (Operators.ConditionalCompareObjectEqual(Left2, (object)"OpStop", false))
                                                                                                            {
                                                                                                                num3 = 110;
                                                                                                                NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "font", new object[1]
                                                                                                                {
                                                          (object) new Font("Microsoft Sans Serif", (float) emSize4, FontStyle.Bold)
                                                                                                                }, (string[])null, (System.Type[])null, false, true);
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                num3 = 112;
                                                                                                                if (Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Falls_minus", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Falls", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"TimeVio_minus", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"TimeVio", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Bonus_minus", false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(Left2, (object)"Bonus_plus", false)) ? (object)true : (object)false))
                                                                                                                {
                                                                                                                    num3 = 113;
                                                                                                                    NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "font", new object[1]
                                                                                                                    {
                                                            (object) new Font("Microsoft Sans Serif", (float) emSize5, FontStyle.Bold)
                                                                                                                    }, (string[])null, (System.Type[])null, false, true);
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    num3 = 116;
                                                                                                                    NewLateBinding.LateSetComplex(this.CtlArray[index1], (System.Type)null, "font", new object[1]
                                                                                                                    {
                                                            (object) new Font("Microsoft Sans Serif", (float) emSize1, FontStyle.Bold)
                                                                                                                    }, (string[])null, (System.Type[])null, false, true);
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    num3 = 121;
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

        public void ShowDatagrid()
        {
            this.DataGridView1.RowCount = 15;
            this.DataGridView1.ClearSelection();
            this.DataGridView1.CurrentCell = this.DataGridView1.Rows[0].Cells[0];
            this.DataGridView1.Rows[0].Selected = true;
            this.InitOpForm();
        }

        public void VisaData()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                num3 = 3;
                int index = 1;
                do
                {
                    num3 = 4;
                    dataGridView1.Rows[checked(index - 1)].Cells[0].Value = (object)Conversions.ToString(index);
                    num3 = 5;
                    dataGridView1.Rows[checked(index - 1)].Cells[1].Value = (object)Program.OpArr[index].element;
                    num3 = 6;
                    dataGridView1.Rows[checked(index - 1)].Cells[2].Value = (object)Program.OpArr[index].edge;
                    num3 = 7;
                    dataGridView1.Rows[checked(index - 1)].Cells[3].Value = (object)Program.OpArr[index].replay;
                    num3 = 8;
                    checked { ++index; }
                }
                while (index <= 15);
                num3 = 9;
                if (index < 15)
                {
                    num3 = 10;
                    this.index = checked(index - 1);
                }
                else
                {
                    num3 = 12;
                    num3 = 13;
                }
                num3 = 15;
                dataGridView1.Select();
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void OpStop_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int ElNo = 0;
                if (!this.ElementTst(ref ElNo) && Interaction.MsgBox((object)"Do you want to EXIT anyway?", MsgBoxStyle.Exclamation | MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                {
                    this.OplistaSelect();
                    goto label_31;
                }
                else
                {
                    switch (Program.WorkMode)
                    {
                        case 0:
                        case 1:
                            this.UpdateVek();
                            break;
                        case 2:
                        case 3:
                            this.Timer1.Enabled = false;
                            string segment = Program.Segment;
                            int num3 = 0;
                            if (Operators.CompareString(segment, "Seg1", false) == 0)
                            {
                                if (Program.Vek[Program.PNo].HTIndSeg1 < 1 & Program.HalfTime_Sel())
                                    num3 = (int)Interaction.MsgBox((object)"Do you want to input the Half Time?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            }
                            else if (Operators.CompareString(segment, "Seg2", false) == 0 && Program.Vek[Program.PNo].HTIndSeg2 < 1 & Program.HalfTime_Sel())
                                num3 = (int)Interaction.MsgBox((object)"Do you want to input the Half Time?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            if (num3 == 6)
                            {
                                this.OplistaSelect();
                                goto label_31;
                            }
                            else if (Program.OpenDB[Program.PcIndex].ElementTest[7] > 0 && !this.Find_Axel() && Interaction.MsgBox((object)"Do you want to EXIT?", MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                            {
                                this.OplistaSelect();
                                goto label_31;
                            }
                            else if (Operators.CompareString(Program.Segment, "Seg2", false) == 0 && !this.Calc_El() && Interaction.MsgBox((object)"Do you want to EXIT?", MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                            {
                                this.OplistaSelect();
                                goto label_31;
                            }
                            else
                            {
                                this.UpdateVek();
                                break;
                            }
                    }
                    this.WillExit = true;
                    this.Close();
                    switch (Program.WorkMode)
                    {
                        case 0:
                        case 1:
                            MyProject.Forms.StartListForm.TopMost = false;
                            break;
                        case 2:
                            if (Program.IsFormOpen((Form)MyProject.Forms.JudgesDetailsForm))
                                MyProject.Forms.JudgesDetailsForm.Close();
                            MyProject.Forms.JudgesDetailsForm.txtIndex.Text = Conversions.ToString(Program.PNo);
                            Program.ScanJudges = 1;
                            int rowDed1 = 0;
                            Program.CreateJudgesDetails(0, ref rowDed1);
                            MyProject.Forms.JudgesDetailsForm.ShowJD(rowDed1);
                            MyProject.Forms.JudgesDetailsForm.Show();
                            MyProject.Forms.JudgesDetailsForm.TopMost = false;
                            MyProject.Forms.MainForm.MakeJudgeTxtFile(-1);
                            break;
                        case 3:
                            if (Program.IsFormOpen((Form)MyProject.Forms.JudgesDetailsForm))
                                MyProject.Forms.JudgesDetailsForm.Close();
                            MyProject.Forms.JudgesDetailsForm.txtIndex.Text = Conversions.ToString(Program.PNo);
                            int rowDed2 = 0;
                            Program.CreateJudgesDetails(0, ref rowDed2);
                            MyProject.Forms.JudgesDetailsForm.ShowJD(rowDed2);
                            MyProject.Forms.JudgesDetailsForm.Show();
                            MyProject.Forms.JudgesDetailsForm.TopMost = false;
                            break;
                    }
                    Program.SaveCategoryFile(Program.CategoryFileName);
                    goto label_31;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("OpStop_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_31:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public bool AllowedSpins()
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                flag = true;
                int index = 1;
                do
                {
                    string element = Program.OpArr[index].element;
                    if (Operators.CompareString(element, "CoSp", false) == 0 || Operators.CompareString(element, "CoSpB", false) == 0 || Operators.CompareString(element, "CoSp1", false) == 0 || Operators.CompareString(element, "CoSp2", false) == 0 || Operators.CompareString(element, "CoSp3", false) == 0 || Operators.CompareString(element, "CoSp4", false) == 0)
                    {
                        flag = false;
                        break;
                    }
                    if (Operators.CompareString(element, "CCoSp", false) == 0 || Operators.CompareString(element, "CCoSpB", false) == 0 || Operators.CompareString(element, "CCoSp1", false) == 0 || Operators.CompareString(element, "CCoSp2", false) == 0 || Operators.CompareString(element, "CCoSp3", false) == 0 || Operators.CompareString(element, "CCoSp4", false) == 0)
                    {
                        flag = false;
                        break;
                    }
                    if (Operators.CompareString(element, "FCoSp", false) == 0 || Operators.CompareString(element, "FCoSpB", false) == 0 || Operators.CompareString(element, "FCoSp1", false) == 0 || Operators.CompareString(element, "FCoSp2", false) == 0 || Operators.CompareString(element, "FCoSp3", false) == 0 || Operators.CompareString(element, "FCoSp4", false) == 0)
                    {
                        flag = false;
                        break;
                    }
                    if (Operators.CompareString(element, "FCCoSp", false) == 0 || Operators.CompareString(element, "FCCoSpB", false) == 0 || Operators.CompareString(element, "FCCoSp1", false) == 0 || Operators.CompareString(element, "FCCoSp2", false) == 0 || Operators.CompareString(element, "FCCoSp3", false) == 0 || Operators.CompareString(element, "FCCoSp4", false) == 0)
                    {
                        flag = false;
                        break;
                    }
                    checked { ++index; }
                }
                while (index <= 15);
                if (!flag)
                {
                    if (Interaction.MsgBox((object)("Element no. " + Conversions.ToString(index) + " is not correct!\r\nDo you want to EXIT?"), MsgBoxStyle.Exclamation | MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.Yes)
                    {
                        flag = true;
                        goto label_18;
                    }
                    else
                        goto label_18;
                }
                else
                    goto label_18;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("AllowedSpins - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_18:
            int num4 = flag ? 1 : 0;
            if (num2 == 0)
                return num4 != 0;
            ProjectData.ClearProjectError();
            return num4 != 0;
        }

        public bool Find_Axel()
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                bool Axel = false;
                ProjectData.ClearProjectError();
                num1 = 2;
                flag = true;
                int ind = 1;
                do
                {
                    string str = Program.OpArr[ind].element;
                    if (Strings.Len(str) != 0)
                    {
                        if (Strings.InStr(1, str, "+COMBO", CompareMethod.Text) > 0)
                            str = Strings.Replace(str, "+COMBO", "");
                        else if (Strings.InStr(1, str, "+SEQ", CompareMethod.Text) > 0)
                        {
                            this.FindAxelEl(Strings.Replace(str, "+SEQ", ""), ind, ref Axel);
                            goto label_14;
                        }
                        else if (Strings.InStr(1, str, "+REP", CompareMethod.Text) > 0)
                        {
                            this.FindAxelEl(Strings.Replace(str, "+REP", ""), ind, ref Axel);
                            goto label_14;
                        }
                        else if (Strings.InStr(2, str, "Sp", CompareMethod.Text) > 1)
                            goto label_14;
                        if (Strings.InStr(1, str, "+", CompareMethod.Text) > 0)
                            this.FindAxelEl(str, ind, ref Axel);
                        else if (Strings.InStr(1, str, "+", CompareMethod.Text) == 0 & Strings.Len(str) >= 1)
                            this.FindAxelEl(str, ind, ref Axel);
                    }
                label_14:
                    checked { ++ind; }
                }
                while (ind <= 15);
                if (!Axel)
                {
                    int num3 = (int)Interaction.MsgBox((object)"No Axel performed!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    flag = false;
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
                int num4 = (int)Interaction.MsgBox((object)("Find_Axel - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_21:
            int num5 = flag ? 1 : 0;
            if (num2 == 0)
                return num5 != 0;
            ProjectData.ClearProjectError();
            return num5 != 0;
        }

        public void FindAxelEl(string StringEl, int ind, ref bool Axel)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                string[] strArray = StringEl.Split('+');
                int num3 = checked(strArray.Length - 1);
                if (num3 > 9)
                {
                    num3 = 9;
                    int num4 = (int)Interaction.MsgBox((object)("Error in Element definition!\r\nMax number of jump elements has been exceeded!\r\nElement no. = " + Conversions.ToString(ind)), MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
                int num5 = num3;
                int index = 0;
                while (index <= num5)
                {
                    string str = Operators.CompareString(Strings.Right(strArray[index], 1), "*", false) != 0 ? strArray[index] : Strings.Trim(strArray[index].Replace("*", ""));
                    if (Operators.CompareString(Strings.Right(str, 1), "e", false) == 0)
                        str = Strings.Trim(str.Replace("e", ""));
                    if (Operators.CompareString(Strings.Right(str, 1), "<", false) == 0)
                        str = Strings.Trim(str.Replace("<", ""));
                    string Left = str;
                    
                    //if (Operators.CompareString(Left, "A", false) == 0 || Operators.CompareString(Left, "1A", false) == 0 || Operators.CompareString(Left, "2A", false) == 0 || Operators.CompareString(Left, "3A", false) == 0 || Operators.CompareString(Left, "4A", false) == 0)
                    if(Left.Contains("A"))
                        Axel = true;
                    checked { ++index; }
                }
                goto label_17;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num6 = (int)Interaction.MsgBox((object)("FindAxelEl - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_17:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public bool Calc_El()
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                string[] strArray1 = new string[7];
                int[] numArray1 = new int[7];
                int[] numArray2 = new int[7];
                int[] numArray3 = new int[16];
                bool Jump = false;
                ProjectData.ClearProjectError();
                num1 = 2;
                flag = true;
                this.Jarr = (string[])null;
                this.Jarr = new string[61];
                string[] strArray2 = new string[7];
                int[] numArray4 = new int[7];
                int[] numArray5 = new int[7];
                int[] numArray6 = new int[16];
                int num3 = 0;
                int num4 = 0;
                int index1 = 0;
                int num5 = 0;
                int num6 = 0;
                int Jnr = 1;
                strArray2[1] = "A";
                strArray2[2] = "T";
                strArray2[3] = "Lo";
                strArray2[4] = "F"; //Flips
                strArray2[5] = "Lz";
                strArray2[6] = "S";
                int ind = 1;
                do
                {
                    string str1 = Program.OpArr[ind].element;
                    if (Strings.Len(str1) != 0 && !(Operators.CompareString(Strings.Right(str1, 1), "*", false) == 0 & !str1.Contains("+")))
                    {
                        int NoOfAst = 0;
                        if (Strings.InStr(1, str1, "+COMBO", CompareMethod.Text) > 0)
                        {
                            Strings.InStr(1, str1, "+COMBO", CompareMethod.Text);
                            str1 = Strings.Replace(str1, "+COMBO", "");
                            if (Strings.InStr(str1, "+REP") > 0)
                                str1 = Strings.Replace(str1, "+REP", "");
                            if (!str1.Contains("+"))
                                checked { ++index1; }
                        }
                        else if (Strings.InStr(1, str1, "+SEQ", CompareMethod.Text) > 0)
                        {
                            Strings.InStr(1, str1, "+SEQ", CompareMethod.Text);
                            string str2 = Strings.Replace(str1, "+SEQ", "");
                            if (Strings.InStr(str2, "+REP") > 0)
                                str2 = Strings.Replace(str2, "+REP", "");
                            int Eno = 0;
                            this.FindJumpEl(str2, ind, ref Eno, ref Jnr, ref Jump, ref NoOfAst);
                            if (Eno > 0 & Jump)
                            {
                                checked { ++num3; }
                                goto label_39;
                            }
                            else
                                goto label_39;
                        }
                        else if (Strings.InStr(1, str1, "+REP", CompareMethod.Text) > 0)
                        {
                            Strings.InStr(1, str1, "+REP", CompareMethod.Text);
                            int Eno = 0;
                            this.FindJumpEl(Strings.Replace(str1, "+REP", ""), ind, ref Eno, ref Jnr, ref Jump, ref NoOfAst);
                            if (Eno > 1 & Jump)
                                checked { ++index1; }
                            if (Eno == 1)
                            {
                                checked { ++num5; }
                                goto label_39;
                            }
                            else
                                goto label_39;
                        }
                        else if (Strings.InStr(2, str1, "Sp", CompareMethod.Text) > 1)
                        {
                            string spin = Program.GetSpin(str1);
                            int spinMin = Program.SpinMin;
                            int spinmax = Program.Spinmax;
                            int index2 = spinMin;
                            while (index2 <= spinmax)
                            {
                                if (Operators.ConditionalCompareObjectEqual((object)spin, Program.ElDB[index2, 0], false))
                                {
                                    checked { ++num6; }
                                    break;
                                }
                                checked { ++index2; }
                            }
                            goto label_39;
                        }
                        if (Strings.InStr(1, str1, "+", CompareMethod.Text) > 0)
                        {
                            int Eno = 0;
                            this.FindJumpEl(str1, ind, ref Eno, ref Jnr, ref Jump, ref NoOfAst);
                            if (Eno > 1)
                            {
                                checked { ++index1; }
                                numArray6[index1] = Eno;
                            }
                        }
                        else if (Strings.InStr(1, str1, "+", CompareMethod.Text) == 0 & Strings.Len(str1) >= 1)
                        {
                            if (Operators.CompareString(Strings.Right(str1, 1), "e", false) == 0)
                                str1 = Strings.Trim(str1.Remove(checked(Strings.Len(str1) - 1)));
                            if (str1.Contains("<"))
                                str1 = Strings.Trim(str1.Replace("<", ""));
                            if (str1.Contains("!"))
                                str1 = Strings.Trim(str1.Replace("!", ""));
                            if (str1.Contains("f"))
                                str1 = Strings.Trim(str1.Replace("f", ""));
                            if (str1.Contains(" q"))
                                str1 = Strings.Trim(str1.Replace(" q", ""));

                            int jumpmin = Program.Jumpmin;
                            int jumpMax = Program.JumpMax;
                            int index3 = jumpmin;
                            while (index3 <= jumpMax)
                            {
                                if (Operators.ConditionalCompareObjectEqual((object)str1, Program.ElDB[index3, 0], false))
                                {
                                    this.Jarr[Jnr] = str1;
                                    checked { ++Jnr; }
                                    checked { ++num4; }
                                    break;
                                }
                                checked { ++index3; }
                            }
                        }
                    }
                label_39:
                    checked { ++ind; }
                }
                while (ind <= 15);
                if (Program.OpenDB[Program.PcIndex].ElementTest[5] > 0)
                {
                    int index4 = 1;
                    do
                    {
                        int num7 = checked(Jnr - 1);
                        int index5 = 1;
                        while (index5 <= num7)
                        {
                            if (Strings.InStr(1, this.Jarr[index5], "1" + strArray2[index4]) >= 1)
                                numArray4[index4] = checked(numArray4[index4] + 1);
                            checked { ++index5; }
                        }
                        checked { ++index4; }
                    }
                    while (index4 <= 6);
                    int index6 = 1;
                    do
                    {
                        if (numArray4[index6] > Program.OpenDB[Program.PcIndex].ElementTest[5])
                        {
                            int num8 = (int)Interaction.MsgBox((object)("More single jump elements than allowed!\r\nAllowed: " + Conversions.ToString(Program.OpenDB[Program.PcIndex].ElementTest[5]) + ", Entered: " + Conversions.ToString(numArray4[index6]) + " of type 1" + strArray2[index6]), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            flag = false;
                        }
                        checked { ++index6; }
                    }
                    while (index6 <= 6);
                }
                if (Program.OpenDB[Program.PcIndex].ElementTest[6] > 0)
                {
                    int index7 = 1;
                    do
                    {
                        int num9 = checked(Jnr - 1);
                        int index8 = 1;
                        while (index8 <= num9)
                        {
                            if (Strings.InStr(1, this.Jarr[index8], "2" + strArray2[index7]) >= 1)
                                numArray5[index7] = checked(numArray5[index7] + 1);
                            checked { ++index8; }
                        }
                        checked { ++index7; }
                    }
                    while (index7 <= 6);
                    int index9 = 1;
                    do
                    {
                        if (numArray5[index9] > Program.OpenDB[Program.PcIndex].ElementTest[6])
                        {
                            int num10 = (int)Interaction.MsgBox((object)("More double jump elements than allowed!\r\nAllowed: " + Conversions.ToString(Program.OpenDB[Program.PcIndex].ElementTest[6]) + ", Entered: " + Conversions.ToString(numArray5[index9]) + " of type 2" + strArray2[index9]), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            flag = false;
                        }
                        checked { ++index9; }
                    }
                    while (index9 <= 6);
                }
                if (Program.OpenDB[Program.PcIndex].ElementTest[1] > 0)
                {
                    int num11 = index1;
                    int index10 = 1;
                    while (index10 <= num11)
                    {
                        if (numArray6[index10] > 2)
                        {
                            int num12 = (int)Interaction.MsgBox((object)"A three jump combination is not allowed for this Category!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            flag = false;
                        }
                        checked { ++index10; }
                    }
                }
                if (Program.OpenDB[Program.PcIndex].ElementTest[2] > 0 && checked(num4 + index1 + num3 + num5) > 0 & checked(num4 + index1 + num3 + num5) > Program.OpenDB[Program.PcIndex].ElementTest[2])
                {
                    int num13 = (int)Interaction.MsgBox((object)("More jump elements than allowed!\r\nAllowed: " + Conversions.ToString(Program.OpenDB[Program.PcIndex].ElementTest[2]) + ", Entered: " + Conversions.ToString(checked(num4 + index1 + num3 + num5))), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    flag = false;
                }
                if (Program.OpenDB[Program.PcIndex].ElementTest[3] != 0 && checked(num3 + index1) > 0 & checked(num3 + index1) > Program.OpenDB[Program.PcIndex].ElementTest[3])
                {
                    int num14 = (int)Interaction.MsgBox((object)("More combo/seq than allowed!\r\nAllowed: " + Conversions.ToString(Program.OpenDB[Program.PcIndex].ElementTest[3]) + ", Entered: " + Conversions.ToString(checked(num3 + index1))), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    flag = false;
                }
                if (Program.OpenDB[Program.PcIndex].AllowedJumps.Length != 0 && Operators.CompareString(Program.OpenDB[Program.PcIndex].AllowedJumps[0], "", false) != 0)
                {
                    int num15 = checked(Jnr - 1);
                    int index11 = 1;
                    while (index11 <= num15)
                    {
                        if (Operators.CompareString(Strings.Right(this.Jarr[index11], 1), "*", false) != 0 && !((IEnumerable<string>)Program.OpenDB[Program.PcIndex].AllowedJumps).Contains<string>(this.Jarr[index11]))
                        {
                            int num16 = (int)Interaction.MsgBox((object)("Unallowed jumps!\r\nAllowed: " + string.Join(", ", Program.OpenDB[Program.PcIndex].AllowedJumps) + ", Entered: " + this.Jarr[index11]), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            flag = false;
                            index11 = checked(num15 + 1);
                        }
                        checked { ++index11; }
                    }
                }
                if (Program.OpenDB[Program.PcIndex].ElementTest[4] != 0)
                {
                    if (num6 > 0 & num6 > Program.OpenDB[Program.PcIndex].ElementTest[4])
                    {
                        int num17 = (int)Interaction.MsgBox((object)("More spins than allowed!\r\nAllowed: " + Conversions.ToString(Program.OpenDB[Program.PcIndex].ElementTest[4]) + ", Entered: " + Conversions.ToString(num6)), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        flag = false;
                        goto label_87;
                    }
                    else
                        goto label_87;
                }
                else
                    goto label_87;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num18 = (int)Interaction.MsgBox((object)("Calc_El - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_87:
            int num19 = flag ? 1 : 0;
            if (num2 == 0)
                return num19 != 0;
            ProjectData.ClearProjectError();
            return num19 != 0;
        }

        public string RemoveStarEl(string Instr)
        {
            string Expression = "";
            string[] strArray = Instr.Split('+');
            int length = strArray.Length;
            if (strArray[checked(length - 1)].Contains("SEQ"))
            {
                int num = checked(length - 1);
                int index = 0;
                while (index <= num)
                {
                    if (!strArray[index].Contains("*"))
                        Expression = Strings.Len(Expression) != 0 ? Expression + "+" + strArray[index] : strArray[index];
                    checked { ++index; }
                }
            }
            else
                Expression = Instr;
            return Expression;
        }

        public void FindJumpEl(
          string StringEl,
          int ind,
          ref int Eno,
          ref int Jnr,
          ref bool Jump,
          ref int NoOfAst)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Jump = false;
                Eno = 0;
                NoOfAst = 0;
                string[] strArray = StringEl.Split('+');
                Eno = strArray.Length;
                if (Eno > 9)
                {
                    Eno = 9;
                    int num3 = (int)Interaction.MsgBox((object)("Error in Element definition!\r\nMax number of jump elements has been exceeded!\r\nElement no. = " + Conversions.ToString(ind)), MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
                int num4 = checked(Eno - 1);
                int index1 = 0;
                while (index1 <= num4)
                {
                    string str;
                    if (strArray[index1].Contains("*"))
                    {
                        str = Strings.Trim(strArray[index1].Replace("*", ""));
                        checked { ++NoOfAst; }
                    }
                    else
                        str = strArray[index1];
                    if (Operators.CompareString(Strings.Right(str, 1), "e", false) == 0)
                        str = Strings.Trim(str.Replace("e", ""));
                    if (Operators.CompareString(Strings.Right(str, 1), "<", false) == 0)
                        str = Strings.Trim(str.Replace("<", ""));
                    if (str.Contains("!"))
                        str = Strings.Trim(str.Replace("!", ""));
                    if (str.Contains("f"))
                        str = Strings.Trim(str.Replace("f", ""));
                    if (str.Contains(" q"))
                        str = Strings.Trim(str.Replace(" q", ""));
                    int jumpmin = Program.Jumpmin;
                    int jumpMax = Program.JumpMax;
                    int index2 = jumpmin;
                    while (index2 <= jumpMax)
                    {
                        if (Operators.ConditionalCompareObjectEqual((object)str, Program.ElDB[index2, 0], false))
                        {
                            this.Jarr[Jnr] = strArray[index1];
                            checked { ++Jnr; }
                            break;
                        }
                        checked { ++index2; }
                    }
                    if (index2 > Program.JumpMax)
                    {
                        int num5 = (int)Interaction.MsgBox((object)("Error in Element definition!\r\nElement no. =" + Conversions.ToString(ind)), MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    }
                    else
                        Jump = true;
                    checked { ++index1; }
                }
                goto label_26;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num6 = (int)Interaction.MsgBox((object)("FindJumpEl - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_26:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public bool ElementTst(ref int ElNo)
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                flag = true;
                int index = 1;
                do
                {
                    if (Strings.Len(Program.OpArr[index].element) > 0 && !Program.TstElPP(Program.OpArr[index].element))
                    {
                        flag = false;
                        ElNo = index;
                        int num3 = (int)Interaction.MsgBox((object)("Element no. " + Conversions.ToString(index) + " is not correct!"), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    }
                    checked { ++index; }
                }
                while (index <= 15);
                goto label_9;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("ElementTst - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_9:
            int num5 = flag ? 1 : 0;
            if (num2 == 0)
                return num5 != 0;
            ProjectData.ClearProjectError();
            return num5 != 0;
        }

        private void ElSel(int indin, string el, string Lev)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string ElOut = "";
                string txt = "";
                ProjectData.ClearProjectError();
                num1 = 2;
                int index = checked(indin + 1);
                if (index > -1)
                {
                    string Right1 = "F" + el;
                    string Right2 = "C" + el;
                    string Right3 = "FC" + el;
                    if (Strings.Len(Program.OpArr[index].element) == 0)
                    {
                        if (this.OpFlying.BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0) & this.OpChange.BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0))
                        {
                            Program.OpArr[index].element = Program.OpArr[index].element + Right3 + Lev;
                            this.OpLista(indin, Program.OpArr[index].element);
                            goto label_26;
                        }
                        else if (this.OpFlying.BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0) & this.OpChange.BackColor != Color.FromArgb((int)byte.MaxValue, 0, 0))
                        {
                            Program.OpArr[index].element = Program.OpArr[index].element + Right1 + Lev;
                            this.OpLista(indin, Program.OpArr[index].element);
                            goto label_26;
                        }
                        else if (this.OpFlying.BackColor != Color.FromArgb((int)byte.MaxValue, 0, 0) & this.OpChange.BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0))
                        {
                            Program.OpArr[index].element = Program.OpArr[index].element + Right2 + Lev;
                            this.OpLista(indin, Program.OpArr[index].element);
                            goto label_26;
                        }
                        else if (this.OpFlying.BackColor != Color.FromArgb((int)byte.MaxValue, 0, 0) & this.OpChange.BackColor != Color.FromArgb((int)byte.MaxValue, 0, 0))
                        {
                            Program.OpArr[index].element = Program.OpArr[index].element + el + Lev;
                            this.OpLista(indin, Program.OpArr[index].element);
                            goto label_26;
                        }
                        else
                            goto label_26;
                    }
                    else
                    {
                        this.SpinEl(Program.OpArr[index].element, ref ElOut, ref txt);
                        int Length = !(Versioned.IsNumeric((object)Strings.Right(ElOut, 1)) | Operators.CompareString(Strings.Right(ElOut, 1), "B", false) == 0) ? Strings.Len(ElOut) : checked(Strings.Len(ElOut) - 1);
                        string Left = Strings.Left(ElOut, Length);
                        if (Operators.CompareString(Left, el, false) == 0)
                            Program.OpArr[index].element = Strings.Len(txt) <= 0 ? el + Lev : el + Lev + "+" + txt;
                        else if (Operators.CompareString(Left, Right1, false) == 0)
                            Program.OpArr[index].element = Strings.Len(txt) <= 0 ? Right1 + Lev : Right1 + Lev + "+" + txt;
                        else if (Operators.CompareString(Left, Right2, false) == 0)
                            Program.OpArr[index].element = Strings.Len(txt) <= 0 ? Right2 + Lev : Right2 + Lev + "+" + txt;
                        else if (Operators.CompareString(Left, Right3, false) == 0)
                            Program.OpArr[index].element = Strings.Len(txt) <= 0 ? Right3 + Lev : Right3 + Lev + "+" + txt;
                        else
                            this.WrongEl();
                        this.OpLista(indin, Program.OpArr[index].element);
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
                int num3 = (int)Interaction.MsgBox((object)("ElSel - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_26:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void ElSel1(int indin, string el, string Lev)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int index = checked(indin + 1);
                if (index > -1)
                {
                    string str = el + Lev;
                    if (Strings.Len(Program.OpArr[index].element) == 0)
                    {
                        // ISSUE: explicit reference operation
                        Program.OpArr[index].element += str;
                        this.OpLista(indin, Program.OpArr[index].element);
                        goto label_12;
                    }
                    else
                    {
                        int Length = Strings.Len(el);
                        if (Operators.CompareString(Strings.Left(Program.OpArr[index].element, Length), el, false) == 0)
                        {
                            Program.OpArr[index].element = str;
                            this.OpLista(indin, Program.OpArr[index].element);
                            goto label_12;
                        }
                        else
                        {
                            this.WrongEl();
                            goto label_12;
                        }
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
                int num3 = (int)Interaction.MsgBox((object)("ElSel1 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_12:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void ElSel2(int indin, string el, string Lev)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string ElOut = "";
                string txt = "";
                ProjectData.ClearProjectError();
                num1 = 2;
                int index = checked(indin + 1);
                if (index > -1)
                {
                    if (Strings.Len(Program.OpArr[index].element) == 0)
                    {
                        if (this.OpFlying.BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0) & this.OpChange.BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0))
                        {
                            Program.OpArr[index].element = Program.OpArr[index].element + "FC" + el + Lev;
                            this.OpLista(indin, Program.OpArr[index].element);
                            goto label_42;
                        }
                        else if (this.OpFlying.BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0) & this.OpChange.BackColor != Color.FromArgb((int)byte.MaxValue, 0, 0))
                        {
                            Program.OpArr[index].element = Program.OpArr[index].element + "F" + el + Lev;
                            this.OpLista(indin, Program.OpArr[index].element);
                            goto label_42;
                        }
                        else if (this.OpFlying.BackColor != Color.FromArgb((int)byte.MaxValue, 0, 0) & this.OpChange.BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0))
                        {
                            Program.OpArr[index].element = Program.OpArr[index].element + "C" + el + Lev;
                            this.OpLista(indin, Program.OpArr[index].element);
                            goto label_42;
                        }
                        else if (this.OpFlying.BackColor != Color.FromArgb((int)byte.MaxValue, 0, 0) & this.OpChange.BackColor != Color.FromArgb((int)byte.MaxValue, 0, 0))
                        {
                            Program.OpArr[index].element = Program.OpArr[index].element + el + Lev;
                            this.OpLista(indin, Program.OpArr[index].element);
                            goto label_42;
                        }
                        else
                            goto label_42;
                    }
                    else
                    {
                        this.SpinEl(Program.OpArr[index].element, ref ElOut, ref txt);
                        int Length = !(Versioned.IsNumeric((object)Strings.Right(ElOut, 1)) | Operators.CompareString(Strings.Right(ElOut, 1), "B", false) == 0) ? Strings.Len(ElOut) : checked(Strings.Len(ElOut) - 1);
                        string Left = Strings.Left(ElOut, Length);
                        if (Operators.CompareString(Left, "CoSp", false) == 0)
                            Program.OpArr[index].element = "CoSp" + Lev;
                        else if (Operators.CompareString(Left, "CCoSp", false) == 0)
                            Program.OpArr[index].element = "CCoSp" + Lev;
                        else if (Operators.CompareString(Left, "FCoSp", false) == 0)
                            Program.OpArr[index].element = "FCoSp" + Lev;
                        else if (Operators.CompareString(Left, "FCCoSp", false) == 0)
                            Program.OpArr[index].element = "FCCoSp" + Lev;
                        else if (Operators.CompareString(Left, "CoSp2p", false) == 0)
                            Program.OpArr[index].element = Strings.Len(txt) <= 0 ? "CoSp2p" + Lev : "CoSp2p" + Lev + "+" + txt;
                        else if (Operators.CompareString(Left, "CoSp3p", false) == 0)
                            Program.OpArr[index].element = Strings.Len(txt) <= 0 ? "CoSp3p" + Lev : "CoSp3p" + Lev + "+" + txt;
                        else if (Operators.CompareString(Left, "FCoSp2p", false) == 0)
                            Program.OpArr[index].element = Strings.Len(txt) <= 0 ? "FCoSp2p" + Lev : "FCoSp2p" + Lev + "+" + txt;
                        else if (Operators.CompareString(Left, "FCoSp3p", false) == 0)
                            Program.OpArr[index].element = Strings.Len(txt) <= 0 ? "FCoSp3p" + Lev : "FCoSp3p" + Lev + "+" + txt;
                        else if (Operators.CompareString(Left, "CCoSp2p", false) == 0)
                            Program.OpArr[index].element = Strings.Len(txt) <= 0 ? "CCoSp2p" + Lev : "CCoSp2p" + Lev + "+" + txt;
                        else if (Operators.CompareString(Left, "CCoSp3p", false) == 0)
                            Program.OpArr[index].element = Strings.Len(txt) <= 0 ? "CCoSp3p" + Lev : "CCoSp3p" + Lev + "+" + txt;
                        else if (Operators.CompareString(Left, "FCCoSp2p", false) == 0)
                            Program.OpArr[index].element = Strings.Len(txt) <= 0 ? "FCCoSp2p" + Lev : "FCCoSp2p" + Lev + "+" + txt;
                        else if (Operators.CompareString(Left, "FCCoSp3p", false) == 0)
                            Program.OpArr[index].element = Strings.Len(txt) <= 0 ? "FCCoSp3p" + Lev : "FCCoSp3p" + Lev + "+" + txt;
                        else
                            this.WrongEl();
                        this.OpLista(indin, Program.OpArr[index].element);
                        goto label_42;
                    }
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
                int num3 = (int)Interaction.MsgBox((object)("ElSel - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_42:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void OpLista(int ind, string element)
        {
            this.DataGridView1.Rows[ind].Cells[1].Value = (object)element;
            this.OpListaSet();
            this.SendVek();
            this.OplistaSelect();
        }

        public void OplistaSelect() => this.DataGridView1.Select();

        private void WrongEl()
        {
            Interaction.Beep();
            int num = (int)Interaction.MsgBox((object)"Wrong element!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            this.OplistaSelect();
        }

        private void SendVek()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                if (Program.WorkMode == 2)
                {
                    num3 = 3;
                    this.UpdateVek();
                    num3 = 4;
                    MyProject.Forms.MainForm.MakeJudgeTxtFile(0);
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

        private void UpdateVek()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int index = 1;
                do
                {
                    num3 = 3;
                    string edge = Program.OpArr[index].edge;
                    num3 = 6;
                    string str;
                    //if (Operators.CompareString(edge, "!", false) == 0)
                    //{
                    //    num3 = 7;
                    //    str = " !";
                    //}
                    //else
                    {
                        num3 = 9;
                        if (Operators.CompareString(edge, "REP", false) == 0)
                        {
                            num3 = 10;
                            str = " REP";
                        }
                        else
                        {
                            num3 = 13;
                            str = "";
                        }
                    }


                    num3 = 15;
                    string segment = Program.Segment;
                    num3 = 18;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        num3 = 19;
                        Program.Vek[Program.PNo].SSS_Seg1[index] = Program.OpArr[index].element + str;
                        Program.Vek[Program.PNo].SSS_Seg1_edges[index] = Program.OpArr[index].edge;
                    }
                    else
                    {
                        num3 = 21;
                        if (Operators.CompareString(segment, "Seg2", false) == 0)
                        {
                            num3 = 22;
                            Program.Vek[Program.PNo].SSS_Seg2[index] = Program.OpArr[index].element + str;
                            Program.Vek[Program.PNo].SSS_Seg2_edges[index] = Program.OpArr[index].edge;
                        }
                    }
                    num3 = 24;
                    checked { ++index; }
                }
                while (index <= 15);
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void ElSet(int indin, string Lev)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                string txt = "";
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                int index = checked(indin + 1);
                num3 = 4;
                if (indin > -1)
                {
                    num3 = 5;
                    string element = Program.OpArr[index].element;
                    num3 = 6;
                    this.SpinEl(Program.OpArr[index].element, ref element, ref txt);
                    num3 = 7;
                    if (Strings.Len(element) > 0 & this.SeqSpin(element))
                    {
                        num3 = 8;
                        string Left1 = Strings.Right(element, 2);
                        num3 = 11;
                        if (Operators.CompareString(Left1, "2p", false) == 0 || Operators.CompareString(Left1, "3p", false) == 0)
                        {
                            num3 = 12;
                            if (this.SeqSpin(element + Lev))
                            {
                                num3 = 13;
                                if (Strings.Len(txt) > 0)
                                {
                                    num3 = 14;
                                    Program.OpArr[index].element = element + Lev + "+" + txt;
                                }
                                else
                                {
                                    num3 = 16;
                                    num3 = 17;
                                    Program.OpArr[index].element = element + Lev;
                                }
                            }
                        }
                        else
                        {
                            num3 = 22;
                            string Left2 = Strings.Right(element, 1);
                            num3 = 25;
                            if (Operators.CompareString(Left2, "B", false) == 0 || Operators.CompareString(Left2, "0", false) == 0 || Operators.CompareString(Left2, "1", false) == 0 || Operators.CompareString(Left2, "2", false) == 0 || Operators.CompareString(Left2, "3", false) == 0 || Operators.CompareString(Left2, "4", false) == 0)
                            {
                                num3 = 26;
                                if (this.SeqSpin(Strings.Left(element, checked(Strings.Len(element) - 1)) + Lev))
                                {
                                    num3 = 27;
                                    if (Strings.Len(txt) > 0)
                                    {
                                        num3 = 28;
                                        Program.OpArr[index].element = Strings.Left(element, checked(Strings.Len(element) - 1)) + Lev + txt;
                                    }
                                    else
                                    {
                                        num3 = 30;
                                        num3 = 31;
                                        Program.OpArr[index].element = Strings.Left(element, checked(Strings.Len(element) - 1)) + Lev;
                                    }
                                }
                            }
                            else
                            {
                                num3 = 36;
                                if (this.SeqSpin(element + Lev))
                                {
                                    num3 = 37;
                                    if (Strings.Len(txt) > 0)
                                    {
                                        num3 = 38;
                                        Program.OpArr[index].element = element + Lev + txt;
                                    }
                                    else
                                    {
                                        num3 = 40;
                                        num3 = 41;
                                        Program.OpArr[index].element = element + Lev;
                                    }
                                }
                            }
                        }
                        num3 = 45;
                        this.OpLista(indin, Program.OpArr[index].element);
                    }
                }
                num3 = 48;
                this.OplistaSelect();
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private bool SeqSpin(string txt)
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                flag = false;
                num3 = 3;
                if (Strings.Len(txt) != 0)
                {
                    num3 = 6;
                    int jumpMax = Program.JumpMax;
                    int elDbmax = Program.ElDBmax;
                    int index = jumpMax;
                    while (index <= elDbmax)
                    {
                        num3 = 7;
                        if (Operators.ConditionalCompareObjectEqual((object)txt, Program.ElDB[index, 0], false))
                        {
                            num3 = 8;
                            flag = true;
                            break;
                        }
                        num3 = 11;
                        checked { ++index; }
                    }
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            int num4 = flag ? 1 : 0;
            if (num2 == 0)
                return num4 != 0;
            ProjectData.ClearProjectError();
            return num4 != 0;
        }

        private void ElDef(int indin, string el)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int index = checked(indin + 1);
                num3 = 3;
                if (index > -1)
                {
                    num3 = 4;
                    if (Strings.Len(Program.OpArr[index].element) == 0)
                    {
                        num3 = 5;
                        if (this.OpFlying.BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0) & this.OpChange.BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0))
                        {
                            num3 = 6;
                            Program.OpArr[index].element = "FC" + el;
                        }
                        num3 = 8;
                        if (this.OpFlying.BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0) & this.OpChange.BackColor != Color.FromArgb((int)byte.MaxValue, 0, 0))
                        {
                            num3 = 9;
                            Program.OpArr[index].element = "F" + el;
                        }
                        num3 = 11;
                        if (this.OpFlying.BackColor != Color.FromArgb((int)byte.MaxValue, 0, 0) & this.OpChange.BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0))
                        {
                            num3 = 12;
                            Program.OpArr[index].element = "C" + el;
                        }
                        num3 = 14;
                        if (this.OpFlying.BackColor != Color.FromArgb((int)byte.MaxValue, 0, 0) & this.OpChange.BackColor != Color.FromArgb((int)byte.MaxValue, 0, 0))
                        {
                            num3 = 15;
                            Program.OpArr[index].element = el;
                        }
                    }
                    else
                    {
                        num3 = 18;
                        num3 = 19;
                        Interaction.Beep();
                    }
                    num3 = 21;
                    this.OpLista(indin, Program.OpArr[index].element);
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

        private void ElDef1(int indin, string el)
        {
            int index = checked(indin + 1);
            if (index <= 0)
                return;
            if (Strings.Len(Program.OpArr[index].element) == 0)
            {
                // ISSUE: explicit reference operation
                Program.OpArr[index].element += el;
            }
            else
                Interaction.Beep();
            this.OpLista(indin, Program.OpArr[index].element);
        }

        private void ElDef2(int indin, string el)
        {
            int index = checked(indin + 1);
            if (Strings.Len(Program.OpArr[index].element) == 0)
                this.ElDef(indin, el);
            else if (Strings.InStr(1, Program.OpArr[index].element, el) > 0)
                this.ElSet(indin, "");
            else
                this.OplistaSelect();
        }

        private void ElDef3(int indin, string el)
        {
            int index = checked(indin + 1);
            if (indin <= -1)
                return;
            if (Strings.Len(Program.OpArr[index].element) == 0)
                this.ElDef1(indin, el);
            else if (Strings.InStr(1, Program.OpArr[index].element, el) > 0)
                this.ElSet(indin, "");
            else
                this.OplistaSelect();
        }

        private void Jsel(int indin, string el)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int index = checked(indin + 1);
                string str = el;
                int num3 = Strings.InStr(1, Program.OpArr[index].element, "COMBO", CompareMethod.Text);
                int num4 = Strings.InStr(1, Program.OpArr[index].element, "SEQ", CompareMethod.Text);
                int num5 = Strings.InStr(1, Program.OpArr[index].element, "REP", CompareMethod.Text);
                if ((num3 > 0 | num4 > 0 | num5 > 0) & this.TstStSp((object)Program.OpArr[index].element))
                {
                    this.WrongEl();
                    Interaction.Beep();
                    this.OplistaSelect();
                    goto label_12;
                }
                else
                {
                    if ((num3 > 0 | num4 > 0 | num5 > 0) & !this.TstStSp((object)Program.OpArr[index].element))
                        str += "*";
                    if (index > -1)
                    {
                        Program.OpArr[index].element = Strings.Len(Program.OpArr[index].element) != 0 ? Program.OpArr[index].element + "+" + str : Program.OpArr[index].element + str;
                        this.OpLista(indin, Program.OpArr[index].element);
                        goto label_12;
                    }
                    else
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
                int num6 = (int)Interaction.MsgBox((object)("Jsel - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_12:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public bool TstStSp(object el)
        {
            int num1 = 0;
            bool flag = false;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                flag = false;
                num3 = 3;
                if (Operators.ConditionalCompareObjectNotEqual(el, (object)"", false))
                {
                    num3 = 4;
                    int spinMin = Program.SpinMin;
                    int stepmax = Program.Stepmax;
                    int index = spinMin;
                    while (index <= stepmax)
                    {
                        num3 = 5;
                        if (Operators.ConditionalCompareObjectEqual(el, Program.ElDB[index, 0], false))
                        {
                            num3 = 6;
                            flag = true;
                            break;
                        }
                        num3 = 9;
                        checked { ++index; }
                    }
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            int num4 = flag ? 1 : 0;
            if (num2 == 0)
                return num4 != 0;
            ProjectData.ClearProjectError();
            return num4 != 0;
        }

        private void Axel_Click() => this.Jsel(this.index, "A");

        private void Bonus_Click() => this.OplistaSelect();

        private void ChoreoSeq_Click(object sender, EventArgs e) => this.ElDef3(this.index, "ChSq");

        private void ChSq1_Click(object sender, EventArgs e) => this.ElSel(this.index, "ChSq", "1");

        private void OpListaSet()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string ElOut = "";
                string txt = "";
                ProjectData.ClearProjectError();
                num1 = 2;
                object obj1 = (object)Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                string element = Program.OpArr[checked(this.index + 1)].element;
                if (element.Contains("Sp"))
                {
                    this.SpinEl(Program.OpArr[checked(this.index + 1)].element, ref ElOut, ref txt);
                    if (this.F_Spin(ElOut))
                    {
                        this.SetFlying(ElOut);
                        this.SetChange(ElOut);
                        this.Set_V_V1(txt);
                        this.SpinBackcolor();
                    }
                }
                else
                {
                    this.SetFlying("");
                    this.SetChange("");
                    this.Set_V_V1("");
                    this.SpinBackcolor();
                    ElOut = element;
                }
                int num3 = Strings.Len(ElOut);
                if (num3 > 1 & !Versioned.IsNumeric((object)Strings.Left(ElOut, 1)) & Program.WorkMode > 1)
                {
                    int col = this.FindCol(ElOut);
                    obj1 = RuntimeHelpers.GetObjectValue(Program.ColArr[col]);
                    if (col <= 16)
                    {
                        if (Versioned.IsNumeric((object)Strings.Right(ElOut, 1)) | Operators.CompareString(Strings.Right(ElOut, 1), "B", false) == 0)
                        {
                            this.ColorBox.Visible = false;
                        }
                        else
                        {
                            this.ColorBox.Visible = true;
                            Label colorBox = this.ColorBox;
                            object obj2 = obj1;
                            Color aliceBlue = Color.AliceBlue;
                            Color color = obj2 != null ? (Color)obj2 : aliceBlue;
                            colorBox.BackColor = color;
                        }
                    }
                    else
                        this.ColorBox.Visible = false;
                }
                else
                    this.ColorBox.Visible = false;
                switch (Program.WorkMode)
                {
                    case 2:
                    case 3:
                        if (num3 > 0 & this.SeqSpin(ElOut))
                        {
                            this.SetNum(ElOut, RuntimeHelpers.GetObjectValue(obj1));
                            break;
                        }
                        this.HideNum();
                        break;
                    default:
                        this.HideNum();
                        break;
                }
                string segment = Program.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    this.OpMsg.Text = !(checked(this.index + 1) >= Program.Vek[Program.PNo].HTIndSeg1 & Program.Vek[Program.PNo].HTIndSeg1 != 0) ? "" : "After half time!";
                    goto label_26;
                }
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                {
                    this.OpMsg.Text = !(checked(this.index + 1) >= Program.Vek[Program.PNo].HTIndSeg2 & Program.Vek[Program.PNo].HTIndSeg2 != 0) ? "" : "After half time!";
                    goto label_26;
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
                int num4 = (int)Interaction.MsgBox((object)("OpListaSet - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_26:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private int FindCol(string el)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num4 = 2;
                int Length;
                if (Versioned.IsNumeric((object)Strings.Right(el, 1)) | Operators.CompareString(Strings.Right(el, 1), "B", false) == 0)
                {
                    num4 = 3;
                    Length = checked(Strings.Len(el) - 1);
                }
                else
                {
                    num4 = 5;
                    num4 = 6;
                    Length = Strings.Len(el);
                }
                num4 = 8;
                string Left = Strings.Left(el, Length);
                num4 = 11;
                if (Operators.CompareString(Left, "SSp", false) == 0 || Operators.CompareString(Left, "CSSp", false) == 0 || Operators.CompareString(Left, "FSSp", false) == 0 || Operators.CompareString(Left, "FCSSp", false) == 0)
                {
                    num4 = 12;
                    num2 = 8;
                }
                else
                {
                    num4 = 14;
                    if (Operators.CompareString(Left, "LSp", false) == 0 || Operators.CompareString(Left, "CLSp", false) == 0 || Operators.CompareString(Left, "FLSp", false) == 0 || Operators.CompareString(Left, "FCLSp", false) == 0)
                    {
                        num4 = 15;
                        num2 = 9;
                    }
                    else
                    {
                        num4 = 17;
                        if (Operators.CompareString(Left, "USp", false) == 0 || Operators.CompareString(Left, "CUSp", false) == 0 || Operators.CompareString(Left, "FUSp", false) == 0 || Operators.CompareString(Left, "FCUSp", false) == 0)
                        {
                            num4 = 18;
                            num2 = 10;
                        }
                        else
                        {
                            num4 = 20;
                            if (Operators.CompareString(Left, "CSp", false) == 0 || Operators.CompareString(Left, "CCSp", false) == 0 || Operators.CompareString(Left, "FCSp", false) == 0 || Operators.CompareString(Left, "FCCSp", false) == 0)
                            {
                                num4 = 21;
                                num2 = 11;
                            }
                            else
                            {
                                num4 = 23;
                                if (Operators.CompareString(Left, "CoSp", false) == 0 || Operators.CompareString(Left, "CCoSp", false) == 0 || Operators.CompareString(Left, "FCoSp", false) == 0 || Operators.CompareString(Left, "FCCoSp", false) == 0)
                                {
                                    num4 = 24;
                                    num2 = 12;
                                }
                                else
                                {
                                    num4 = 26;
                                    if (Operators.CompareString(Left, "CoSp2p", false) == 0 || Operators.CompareString(Left, "CCoSp2p", false) == 0 || Operators.CompareString(Left, "FCoSp2p", false) == 0 || Operators.CompareString(Left, "FCCoSp2p", false) == 0)
                                    {
                                        num4 = 27;
                                        num2 = 12;
                                    }
                                    else
                                    {
                                        num4 = 29;
                                        if (Operators.CompareString(Left, "StSq", false) == 0)
                                        {
                                            num4 = 30;
                                            num2 = 13;
                                        }
                                        else
                                        {
                                            num4 = 32;
                                            if (Operators.CompareString(Left, "ChSq", false) == 0)
                                            {
                                                num4 = 33;
                                                num2 = 14;
                                            }
                                            else
                                            {
                                                num4 = 35;
                                                if (Operators.CompareString(Left, "CoSp3p", false) == 0 || Operators.CompareString(Left, "CCoSp3p", false) == 0 || Operators.CompareString(Left, "FCoSp3p", false) == 0 || Operators.CompareString(Left, "FCCoSp3p", false) == 0)
                                                {
                                                    num4 = 36;
                                                    num2 = 12;
                                                }
                                                else
                                                {
                                                    num4 = 39;
                                                    num2 = 16;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            int col = num2;
            if (num3 == 0)
                return col;
            ProjectData.ClearProjectError();
            return col;
        }

        private void HideNum()
        {
            this.ColorBox.Visible = false;
            this.NoLevel.Visible = false;
            this.Set0.Visible = false;
            this.Set1.Visible = false;
            this.Set2.Visible = false;
            this.Set3.Visible = false;
            this.Set4.Visible = false;
        }

        public void SetFalls(int value)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                string segment = Program.Segment;
                num3 = 5;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    num3 = 6;
                    Program.Vek[Program.PNo].Falls_seg1 = value;
                }
                else
                {
                    num3 = 8;
                    if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        num3 = 9;
                        Program.Vek[Program.PNo].Falls_seg2 = value;
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

        private void SetNum(string el, object col)
        {
            int num1 = 0;
            int num2 = 0;
            Color antiqueWhite = Color.AntiqueWhite;
            try
            {
                int num3 = 1;
                object[] objArray = new object[5];
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                object obj1 = (object)Color.FromArgb((int)byte.MaxValue, 0, 0);
                num3 = 4;
                string Left1 = Strings.Right(el, 1);
                num3 = 7;
                string str1;
                string str2;
                if (Operators.CompareString(Left1, "B", false) == 0)
                {
                    num3 = 8;
                    str1 = "0";
                    num3 = 9;
                    str2 = Strings.Left(el, checked(Strings.Len(el) - 1));
                }
                else
                {
                    num3 = 11;
                    if (Operators.CompareString(Left1, "0", false) == 0 || Operators.CompareString(Left1, "1", false) == 0 || Operators.CompareString(Left1, "2", false) == 0 || Operators.CompareString(Left1, "3", false) == 0 || Operators.CompareString(Left1, "4", false) == 0)
                    {
                        num3 = 12;
                        str1 = Strings.Right(el, 1);
                        num3 = 13;
                        str2 = Strings.Left(el, checked(Strings.Len(el) - 1));
                    }
                    else
                    {
                        num3 = 16;
                        str1 = "";
                        num3 = 17;
                        str2 = el;
                    }
                }
                num3 = 19;
                int Number = 0;
                do
                {
                    num3 = 20;
                    if (Operators.CompareString(Strings.Trim(Conversion.Str((object)Number)), str1, false) == 0)
                    {
                        num3 = 21;
                        objArray[Number] = RuntimeHelpers.GetObjectValue(obj1);
                    }
                    else
                    {
                        num3 = 23;
                        num3 = 24;
                        objArray[Number] = RuntimeHelpers.GetObjectValue(col);
                    }
                    num3 = 26;
                    checked { ++Number; }
                }
                while (Number <= 4);
                num3 = 27;
                if (Operators.CompareString(str1, "", false) == 0)
                {
                    num3 = 28;
                    Button noLevel = this.NoLevel;
                    object obj2 = obj1;
                    Color color = obj2 != null ? (Color)obj2 : antiqueWhite;
                    noLevel.BackColor = color;
                }
                else
                {
                    num3 = 30;
                    num3 = 31;
                    Button noLevel = this.NoLevel;
                    object obj3 = col;
                    Color color = obj3 != null ? (Color)obj3 : antiqueWhite;
                    noLevel.BackColor = color;
                }
                num3 = 33;
                Button set0 = this.Set0;
                object obj4 = objArray[0];
                Color color1 = obj4 != null ? (Color)obj4 : antiqueWhite;
                set0.BackColor = color1;
                num3 = 34;
                Button set1 = this.Set1;
                object obj5 = objArray[1];
                Color color2 = obj5 != null ? (Color)obj5 : antiqueWhite;
                set1.BackColor = color2;
                num3 = 35;
                Button set2 = this.Set2;
                object obj6 = objArray[2];
                Color color3 = obj6 != null ? (Color)obj6 : antiqueWhite;
                set2.BackColor = color3;
                num3 = 36;
                Button set3 = this.Set3;
                object obj7 = objArray[3];
                Color color4 = obj7 != null ? (Color)obj7 : antiqueWhite;
                set3.BackColor = color4;
                num3 = 37;
                Button set4 = this.Set4;
                object obj8 = objArray[4];
                Color color5 = obj8 != null ? (Color)obj8 : antiqueWhite;
                set4.BackColor = color5;
                num3 = 38;
                if (Strings.Len(str1) > 0)
                {
                    num3 = 39;
                    string Left2 = str2;
                    num3 = 42;
                    if (Operators.CompareString(Left2, "SSp", false) == 0 || Operators.CompareString(Left2, "CSSp", false) == 0 || Operators.CompareString(Left2, "FSSp", false) == 0 || Operators.CompareString(Left2, "FCSSp", false) == 0)
                    {
                        num3 = 43;
                        Control control = this.Controls["OpSSp" + str1];
                        object obj9 = obj1;
                        Color color6 = obj9 != null ? (Color)obj9 : antiqueWhite;
                        control.BackColor = color6;
                    }
                    else
                    {
                        num3 = 45;
                        if (Operators.CompareString(Left2, "LSp", false) == 0 || Operators.CompareString(Left2, "CLSp", false) == 0 || Operators.CompareString(Left2, "FLSp", false) == 0 || Operators.CompareString(Left2, "FCLSp", false) == 0)
                        {
                            num3 = 46;
                            Control control = this.Controls["OpLSp" + str1];
                            object obj10 = obj1;
                            Color color7 = obj10 != null ? (Color)obj10 : antiqueWhite;
                            control.BackColor = color7;
                        }
                        else
                        {
                            num3 = 48;
                            if (Operators.CompareString(Left2, "USp", false) == 0 || Operators.CompareString(Left2, "CUSp", false) == 0 || Operators.CompareString(Left2, "FUSp", false) == 0 || Operators.CompareString(Left2, "FCUSp", false) == 0)
                            {
                                num3 = 49;
                                Control control = this.Controls["OpUSp" + str1];
                                object obj11 = obj1;
                                Color color8 = obj11 != null ? (Color)obj11 : antiqueWhite;
                                control.BackColor = color8;
                            }
                            else
                            {
                                num3 = 51;
                                if (Operators.CompareString(Left2, "CSp", false) == 0 || Operators.CompareString(Left2, "CCSp", false) == 0 || Operators.CompareString(Left2, "FCSp", false) == 0 || Operators.CompareString(Left2, "FCCSp", false) == 0)
                                {
                                    num3 = 52;
                                    Control control = this.Controls["OpCSp" + str1];
                                    object obj12 = obj1;
                                    Color color9 = obj12 != null ? (Color)obj12 : antiqueWhite;
                                    control.BackColor = color9;
                                }
                                else
                                {
                                    num3 = 54;
                                    if (Operators.CompareString(Left2, "CoSp", false) == 0 || Operators.CompareString(Left2, "CCoSp", false) == 0 || Operators.CompareString(Left2, "FCoSp", false) == 0 || Operators.CompareString(Left2, "FCCoSp", false) == 0)
                                    {
                                        num3 = 55;
                                        Control control = this.Controls["OpCoSp" + str1];
                                        object obj13 = obj1;
                                        Color color10 = obj13 != null ? (Color)obj13 : antiqueWhite;
                                        control.BackColor = color10;
                                    }
                                    else
                                    {
                                        num3 = 57;
                                        if (Operators.CompareString(Left2, "CoSp2p", false) == 0 || Operators.CompareString(Left2, "CCoSp2p", false) == 0 || Operators.CompareString(Left2, "FCoSp2p", false) == 0 || Operators.CompareString(Left2, "FCCoSp2p", false) == 0 || Operators.CompareString(Left2, "CCoSp2p", false) == 0)
                                        {
                                            num3 = 58;
                                            Control control = this.Controls["OpCoSp" + str1];
                                            object obj14 = obj1;
                                            Color color11 = obj14 != null ? (Color)obj14 : antiqueWhite;
                                            control.BackColor = color11;
                                        }
                                        else
                                        {
                                            num3 = 60;
                                            if (Operators.CompareString(Left2, "CoSp3p", false) == 0 || Operators.CompareString(Left2, "CCoSp3p", false) == 0 || Operators.CompareString(Left2, "FCoSp3p", false) == 0 || Operators.CompareString(Left2, "FCCoSp3p", false) == 0 || Operators.CompareString(Left2, "CCoSp3p", false) == 0)
                                            {
                                                num3 = 61;
                                                Control control = this.Controls["OpCoSp" + str1];
                                                object obj15 = obj1;
                                                Color color12 = obj15 != null ? (Color)obj15 : antiqueWhite;
                                                control.BackColor = color12;
                                            }
                                            else
                                            {
                                                num3 = 63;
                                                if (Operators.CompareString(Left2, "StSq", false) == 0)
                                                {
                                                    num3 = 64;
                                                    Control control = this.Controls["OpStSq" + str1];
                                                    object obj16 = obj1;
                                                    Color color13 = obj16 != null ? (Color)obj16 : antiqueWhite;
                                                    control.BackColor = color13;
                                                }
                                                else
                                                {
                                                    num3 = 66;
                                                    if (Operators.CompareString(Left2, "ChSq", false) == 0)
                                                    {
                                                        num3 = 67;
                                                        Control control = this.Controls["OpChSq" + str1];
                                                        object obj17 = obj1;
                                                        Color color14 = obj17 != null ? (Color)obj17 : antiqueWhite;
                                                        control.BackColor = color14;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                num3 = 70;
                string Left3 = str2;
                num3 = 73;
                if (Operators.CompareString(Left3, "ChSq", false) == 0)
                {
                    num3 = 74;
                    this.NoLevel.Visible = true;
                    num3 = 75;
                    this.Set0.Visible = false;
                    num3 = 76;
                    this.Set1.Visible = true;
                    num3 = 77;
                    this.Set2.Visible = false;
                    num3 = 78;
                    this.Set3.Visible = false;
                    num3 = 79;
                    this.Set4.Visible = false;
                }
                else
                {
                    num3 = 82;
                    this.NoLevel.Visible = true;
                    num3 = 83;
                    this.Set0.Visible = true;
                    num3 = 84;
                    this.Set1.Visible = true;
                    num3 = 85;
                    this.Set2.Visible = true;
                    num3 = 86;
                    this.Set3.Visible = true;
                    num3 = 87;
                    this.Set4.Visible = true;
                }
                num3 = 89;
                string Left4 = str2;
                num3 = 92;
                if (Operators.CompareString(Left4, "StSq", false) == 0)
                {
                    num3 = 93;
                    this.NoLevel.ForeColor = Color.White;
                    num3 = 94;
                    int num4 = 0;
                    do
                    {
                        num3 = 95;
                        this.Controls["Set" + Conversions.ToString(num4)].ForeColor = Color.White;
                        num3 = 96;
                        checked { ++num4; }
                    }
                    while (num4 <= 4);
                }
                else
                {
                    num3 = 99;
                    this.NoLevel.ForeColor = Color.Black;
                    num3 = 100;
                    int num5 = 0;
                    do
                    {
                        num3 = 101;
                        this.Controls["Set" + Conversions.ToString(num5)].ForeColor = Color.Black;
                        num3 = 102;
                        checked { ++num5; }
                    }
                    while (num5 <= 4);
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

        private void SetFlying(string El)
        {
            if (Operators.CompareString(Strings.Left(El, 1), "F", false) != 0)
                this.OpFlying.BackColor = Color.FromArgb(236, 233, 216);
            else
                this.OpFlying.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
            this.OplistaSelect();
        }

        private void SetChange(string El)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int Length;
                if (Versioned.IsNumeric((object)Strings.Right(El, 1)) | Operators.CompareString(Strings.Right(El, 1), "B", false) == 0)
                {
                    num3 = 3;
                    Length = checked(Strings.Len(El) - 1);
                }
                else
                {
                    num3 = 5;
                    num3 = 6;
                    Length = Strings.Len(El);
                }
                num3 = 8;
                string Left = Strings.Left(El, Length);
                num3 = 11;
                if (Operators.CompareString(Left, "CSSp", false) == 0 || Operators.CompareString(Left, "CLSp", false) == 0 || Operators.CompareString(Left, "CUSp", false) == 0 || Operators.CompareString(Left, "CCSp", false) == 0 || Operators.CompareString(Left, "CCoSp", false) == 0 || Operators.CompareString(Left, "FCSSp", false) == 0 || Operators.CompareString(Left, "FCLSp", false) == 0 || Operators.CompareString(Left, "FCUSp", false) == 0 || Operators.CompareString(Left, "FCCSp", false) == 0 || Operators.CompareString(Left, "FCCoSp", false) == 0 || Operators.CompareString(Left, "CCoSp2p", false) == 0 || Operators.CompareString(Left, "CCoSp3p", false) == 0 || Operators.CompareString(Left, "FCCoSp2p", false) == 0 || Operators.CompareString(Left, "FCCoSp3p", false) == 0)
                {
                    num3 = 12;
                    this.OpChange.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                }
                else
                {
                    num3 = 15;
                    this.OpChange.BackColor = Color.FromArgb(236, 233, 216);
                }
                num3 = 17;
                this.OplistaSelect();
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Set_V_V1(string txt)
        {
            if (Operators.CompareString(txt, "V", false) == 0)
                this.Spin_V.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
            else
                this.BackColor_V();
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                num3 = 3;
                this.DataGridView1.Rows[this.index].Selected = true;
                num3 = 4;
                this.OpListaSet();
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int y = this.DataGridView1.CurrentCellAddress.Y;
                num3 = 3;
                string intxt = Conversions.ToString(this.DataGridView1.Rows[y].Cells[1].Value);
                num3 = 4;
                if (y > -1 & y < 15)
                {
                    string str;
                    do
                    {
                        num3 = 6;
                        str = this.CustomInputBox(intxt, Strings.Trim(Conversions.ToString(checked(y + 1))));
                        num3 = 7;
                        if (Strings.Len(str) != 0)
                        {
                            num3 = 10;
                            if (Strings.InStr(1, str, "|", CompareMethod.Text) > 0 | Strings.InStr(1, str, ";", CompareMethod.Text) > 0)
                            {
                                num3 = 11;
                                int num4 = (int)Interaction.MsgBox((object)"Wrong input!, a '|' or a ';' is not allowed!", MsgBoxStyle.SystemModal, (object)"Tomten");
                            }
                            num3 = 13;
                        }
                        else
                            break;
                    }
                    while (!(Strings.InStr(1, str, "|", CompareMethod.Text) == 0 & Strings.InStr(1, str, ";", CompareMethod.Text) == 0));
                    num3 = 14;
                    if (Strings.Len(str) > 0)
                    {
                        num3 = 15;
                        if (Program.TstElPP(str))
                        {
                            num3 = 16;
                            this.DataGridView1.Rows[y].Cells[1].Value = (object)str;
                            num3 = 17;
                            Program.OpArr[checked(y + 1)].element = str;
                            num3 = 18;
                            if (str.Contains(" e"))
                            {
                                num3 = 19;
                                Program.OpArr[checked(y + 1)].edge = nameof(e);
                            }
                            else
                            {
                                num3 = 21;
                                num3 = 22;
                                Program.OpArr[checked(y + 1)].edge = "";
                            }
                            num3 = 24;
                            this.DataGridView1.Rows[y].Cells[2].Value = (object)Program.OpArr[checked(y + 1)].edge;
                            num3 = 25;
                            this.SendVek();
                            num3 = 26;
                            this.OpListaSet();
                        }
                        else
                        {
                            num3 = 28;
                            num3 = 29;
                            int num5 = (int)Interaction.MsgBox((object)"The element is not correct!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
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

        private string CustomInputBox(string intxt, string no)
        {
            CustDialog custDialog = new CustDialog();
            custDialog.lblTxt.Text = "Edit element no. " + no + " with the keyboard!";
            custDialog.txtInput.Text = intxt;
            int num = (int)custDialog.ShowDialog();
            return custDialog.txtInput.Text;
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int keyValue = e.KeyValue;
                num3 = 5;
                if (keyValue == -(e.KeyValue == 112 ? 1 : 0) || keyValue == 113 || keyValue == 114 || keyValue == 115 || keyValue == 116 || keyValue == 117 || keyValue == 118 || keyValue == 119 || keyValue == 120 || keyValue == 121 || keyValue == 122 || keyValue == 123)
                {
                    num3 = 6;
                    if (Program.WorkMode == 2)
                    {
                        num3 = 7;
                        this.FuncKeysModule5((Keys)e.KeyValue);
                    }
                    num3 = 9;
                    e.Handled = true;
                }
                else
                {
                    num3 = 11;
                    if (keyValue == 38)
                    {
                        num3 = 12;
                        if (this.index > 0 & this.index < 15)
                        {
                            num3 = 13;
                            this.RowUp();
                            num3 = 14;
                            e.Handled = false;
                            num3 = 15;
                            checked { ++this.index; }
                            num3 = 16;
                            this.DataGridView1.ClearSelection();
                            num3 = 17;
                            this.DataGridView1.CurrentCell = this.DataGridView1.Rows[this.index].Cells[0];
                            num3 = 18;
                            this.DataGridView1.Rows[this.index].Selected = true;
                            num3 = 19;
                            checked { --this.index; }
                        }
                        else
                        {
                            num3 = 21;
                            num3 = 22;
                            e.Handled = true;
                        }
                    }
                    else
                    {
                        num3 = 25;
                        if (keyValue == 40)
                        {
                            num3 = 26;
                            if (this.index > -1 & this.index < 14)
                            {
                                num3 = 27;
                                this.NextRow();
                                num3 = 28;
                                e.Handled = false;
                                num3 = 29;
                                checked { --this.index; }
                                num3 = 30;
                                this.DataGridView1.ClearSelection();
                                num3 = 31;
                                this.DataGridView1.CurrentCell = this.DataGridView1.Rows[this.index].Cells[0];
                                num3 = 32;
                                this.DataGridView1.Rows[this.index].Selected = true;
                                num3 = 33;
                                checked { ++this.index; }
                            }
                            else
                            {
                                num3 = 35;
                                num3 = 36;
                                e.Handled = true;
                            }
                        }
                        else
                        {
                            num3 = 40;
                            e.Handled = true;
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

        public void FuncKeysModule5(Keys value)
        {
            if (value != Keys.F12)
                return;
            MyProject.Forms.MainForm.SendMessage(Program.LastOutTxt);
        }

        private void DataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int keyChar = (int)e.KeyChar;
                num3 = 5;
                if (keyChar == 8)
                {
                    num3 = 6;
                    this.ClearEntry();
                }
                else
                {
                    num3 = 8;
                    if (keyChar == 27)
                    {
                        num3 = 9;
                        this.ClearAllEntry();
                    }
                    else
                    {
                        num3 = 11;
                        if (keyChar == 32)
                        {
                            num3 = 12;
                            this.NextRow();
                        }
                        else
                        {
                            num3 = 14;
                            if (keyChar != 42)
                            {
                                num3 = 16;
                                if (keyChar != 43)
                                {
                                    num3 = 18;
                                    if (keyChar != 45)
                                    {
                                        num3 = 20;
                                        if (keyChar != 82)
                                        {
                                            if (keyChar != 114)
                                                num3 = 22;
                                        }
                                    }
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

        private void ClearAllEntry()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                num3 = 3;
                if (this.index > -1)
                {
                    num3 = 4;
                    int index = checked(this.index + 1);
                    while (index <= 15)
                    {
                        num3 = 5;
                        Program.OpArr[index].element = "";
                        num3 = 6;
                        Program.OpArr[index].edge = "";
                        num3 = 7;
                        Program.OpArr[index].replay = "";
                        num3 = 8;
                        checked { ++index; }
                    }
                    num3 = 9;
                    this.SpinBackcolor();
                    num3 = 10;
                    this.OpFlying.BackColor = Color.FromArgb(236, 233, 216);
                    num3 = 11;
                    this.OpChange.BackColor = Color.FromArgb(236, 233, 216);
                    num3 = 12;
                    this.BackColor_V();
                    num3 = 13;
                    this.HideNum();
                    num3 = 14;
                    string segment = Program.Segment;
                    num3 = 17;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        num3 = 18;
                        if (Program.Vek[Program.PNo].HTIndSeg1 >= checked(this.index + 1))
                        {
                            num3 = 19;
                            Program.Vek[Program.PNo].HTIndSeg1 = 0;
                        }
                    }
                    else
                    {
                        num3 = 22;
                        if (Operators.CompareString(segment, "Seg2", false) == 0)
                        {
                            num3 = 23;
                            if (Program.Vek[Program.PNo].HTIndSeg2 >= checked(this.index + 1))
                            {
                                num3 = 24;
                                Program.Vek[Program.PNo].HTIndSeg2 = 0;
                            }
                        }
                    }
                    num3 = 27;
                    this.ClrDelInsR = 1;
                    num3 = 28;
                    this.VisaData();
                }
                num3 = 30;
                this.SendVek();
                num3 = 31;
                this.OplistaSelect();
                num3 = 32;
                this.ClrDelInsR = 0;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void InitColArr()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                Program.ColArr[1] = (object)Color.FromArgb(212, 225, 1);
                num3 = 3;
                Program.ColArr[2] = (object)Color.FromArgb(133, 130, 0);
                num3 = 4;
                Program.ColArr[3] = (object)Color.FromArgb(198, 196, 198);
                num3 = 5;
                Program.ColArr[4] = (object)Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
                num3 = 6;
                Program.ColArr[5] = (object)Color.FromArgb(0, 0, 254);
                num3 = 7;
                Program.ColArr[6] = (object)Color.FromArgb(0, 254, 254);
                num3 = 8;
                Program.ColArr[7] = (object)Color.FromArgb(254, 0, 254);
                num3 = 9;
                Program.ColArr[8] = (object)Color.FromArgb(254, 254, 0);
                num3 = 10;
                Program.ColArr[9] = (object)Color.FromArgb(203, 170, 90);
                num3 = 11;
                Program.ColArr[10] = (object)Color.FromArgb(0, 254, 254);
                num3 = 12;
                Program.ColArr[11] = (object)Color.FromArgb(0, 254, 0);
                num3 = 13;
                Program.ColArr[12] = (object)Color.FromArgb(133, 130, 0);
                num3 = 14;
                Program.ColArr[16] = (object)Color.FromArgb((int)byte.MaxValue, 192, 128);
                num3 = 15;
                Program.ColArr[13] = (object)Color.FromArgb(133, 0, 0);
                num3 = 16;
                Program.ColArr[14] = (object)Color.FromArgb(254, 254, 0);
                num3 = 17;
                Program.ColArr[15] = (object)Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, (int)byte.MaxValue);
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void NextRow()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                num3 = 3;
                if (this.index > -1 & this.index < 14)
                {
                    num3 = 4;
                    checked { ++this.index; }
                    num3 = 5;
                    this.DataGridView1.ClearSelection();
                    num3 = 6;
                    this.DataGridView1.CurrentCell = this.DataGridView1.Rows[this.index].Cells[0];
                    num3 = 7;
                    this.DataGridView1.Rows[this.index].Selected = true;
                }
                else
                {
                    num3 = 9;
                    num3 = 10;
                    Interaction.Beep();
                }
                num3 = 12;
                this.OpListaSet();
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void RowUp()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                num3 = 3;
                if (this.index > 0 & this.index < 15)
                {
                    num3 = 4;
                    checked { --this.index; }
                    num3 = 5;
                    this.DataGridView1.ClearSelection();
                    num3 = 6;
                    this.DataGridView1.CurrentCell = this.DataGridView1.Rows[this.index].Cells[0];
                    num3 = 7;
                    this.DataGridView1.Rows[this.index].Selected = true;
                }
                else
                {
                    num3 = 9;
                    num3 = 10;
                    Interaction.Beep();
                }
                num3 = 12;
                this.OpListaSet();
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Review_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                if (this.index > -1)
                {
                    Program.OpArr[checked(this.index + 1)].replay = Operators.CompareString(Program.OpArr[checked(this.index + 1)].replay, "R", false) == 0 ? "" : "R";
                    this.ClrDelInsR = 1;
                }
                this.DataGridView1.Rows[this.index].Cells[3].Value = (object)Program.OpArr[checked(this.index + 1)].replay;
                this.SendVek();
                this.OplistaSelect();
                this.ClrDelInsR = 0;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void OpNext1_Click(object sender, EventArgs e) => this.NextRow();

        private void SpinBackcolor()
        {
            Button sit = this.Sit;
            object obj1 = Program.ColArr[8];
            Color aqua = Color.Aqua;
            Color color1 = obj1 != null ? (Color)obj1 : aqua;
            sit.BackColor = color1;
            Button opSsp0 = this.OpSSp0;
            object obj2 = Program.ColArr[8];
            Color color2 = obj2 != null ? (Color)obj2 : aqua;
            opSsp0.BackColor = color2;
            Button opSsp1 = this.OpSSp1;
            object obj3 = Program.ColArr[8];
            Color color3 = obj3 != null ? (Color)obj3 : aqua;
            opSsp1.BackColor = color3;
            Button opSsp2 = this.OpSSp2;
            object obj4 = Program.ColArr[8];
            Color color4 = obj4 != null ? (Color)obj4 : aqua;
            opSsp2.BackColor = color4;
            Button opSsp3 = this.OpSSp3;
            object obj5 = Program.ColArr[8];
            Color color5 = obj5 != null ? (Color)obj5 : aqua;
            opSsp3.BackColor = color5;
            Button opSsp4 = this.OpSSp4;
            object obj6 = Program.ColArr[8];
            Color color6 = obj6 != null ? (Color)obj6 : aqua;
            opSsp4.BackColor = color6;
            Button layback = this.Layback;
            object obj7 = Program.ColArr[9];
            Color color7 = obj7 != null ? (Color)obj7 : aqua;
            layback.BackColor = color7;
            Button opLsp0 = this.OpLSp0;
            object obj8 = Program.ColArr[9];
            Color color8 = obj8 != null ? (Color)obj8 : aqua;
            opLsp0.BackColor = color8;
            Button opLsp1 = this.OpLSp1;
            object obj9 = Program.ColArr[9];
            Color color9 = obj9 != null ? (Color)obj9 : aqua;
            opLsp1.BackColor = color9;
            Button opLsp2 = this.OpLSp2;
            object obj10 = Program.ColArr[9];
            Color color10 = obj10 != null ? (Color)obj10 : aqua;
            opLsp2.BackColor = color10;
            Button opLsp3 = this.OpLSp3;
            object obj11 = Program.ColArr[9];
            Color color11 = obj11 != null ? (Color)obj11 : aqua;
            opLsp3.BackColor = color11;
            Button opLsp4 = this.OpLSp4;
            object obj12 = Program.ColArr[9];
            Color color12 = obj12 != null ? (Color)obj12 : aqua;
            opLsp4.BackColor = color12;
            Button upright = this.Upright;
            object obj13 = Program.ColArr[10];
            Color color13 = obj13 != null ? (Color)obj13 : aqua;
            upright.BackColor = color13;
            Button opUsp0 = this.OpUSp0;
            object obj14 = Program.ColArr[10];
            Color color14 = obj14 != null ? (Color)obj14 : aqua;
            opUsp0.BackColor = color14;
            Button opUsp1 = this.OpUSp1;
            object obj15 = Program.ColArr[10];
            Color color15 = obj15 != null ? (Color)obj15 : aqua;
            opUsp1.BackColor = color15;
            Button opUsp2 = this.OpUSp2;
            object obj16 = Program.ColArr[10];
            Color color16 = obj16 != null ? (Color)obj16 : aqua;
            opUsp2.BackColor = color16;
            Button opUsp3 = this.OpUSp3;
            object obj17 = Program.ColArr[10];
            Color color17 = obj17 != null ? (Color)obj17 : aqua;
            opUsp3.BackColor = color17;
            Button opUsp4 = this.OpUSp4;
            object obj18 = Program.ColArr[10];
            Color color18 = obj18 != null ? (Color)obj18 : aqua;
            opUsp4.BackColor = color18;
            Button camel = this.Camel;
            object obj19 = Program.ColArr[11];
            Color color19 = obj19 != null ? (Color)obj19 : aqua;
            camel.BackColor = color19;
            Button opCsp0 = this.OpCSp0;
            object obj20 = Program.ColArr[11];
            Color color20 = obj20 != null ? (Color)obj20 : aqua;
            opCsp0.BackColor = color20;
            Button opCsp1 = this.OpCSp1;
            object obj21 = Program.ColArr[11];
            Color color21 = obj21 != null ? (Color)obj21 : aqua;
            opCsp1.BackColor = color21;
            Button opCsp2 = this.OpCSp2;
            object obj22 = Program.ColArr[11];
            Color color22 = obj22 != null ? (Color)obj22 : aqua;
            opCsp2.BackColor = color22;
            Button opCsp3 = this.OpCSp3;
            object obj23 = Program.ColArr[11];
            Color color23 = obj23 != null ? (Color)obj23 : aqua;
            opCsp3.BackColor = color23;
            Button opCsp4 = this.OpCSp4;
            object obj24 = Program.ColArr[11];
            Color color24 = obj24 != null ? (Color)obj24 : aqua;
            opCsp4.BackColor = color24;
            Button comboSpin = this.ComboSpin;
            object obj25 = Program.ColArr[12];
            Color color25 = obj25 != null ? (Color)obj25 : aqua;
            comboSpin.BackColor = color25;
            Button opCoSp0 = this.OpCoSp0;
            object obj26 = Program.ColArr[12];
            Color color26 = obj26 != null ? (Color)obj26 : aqua;
            opCoSp0.BackColor = color26;
            Button opCoSp1 = this.OpCoSp1;
            object obj27 = Program.ColArr[12];
            Color color27 = obj27 != null ? (Color)obj27 : aqua;
            opCoSp1.BackColor = color27;
            Button opCoSp2 = this.OpCoSp2;
            object obj28 = Program.ColArr[12];
            Color color28 = obj28 != null ? (Color)obj28 : aqua;
            opCoSp2.BackColor = color28;
            Button opCoSp3 = this.OpCoSp3;
            object obj29 = Program.ColArr[12];
            Color color29 = obj29 != null ? (Color)obj29 : aqua;
            opCoSp3.BackColor = color29;
            Button opCoSp4 = this.OpCoSp4;
            object obj30 = Program.ColArr[12];
            Color color30 = obj30 != null ? (Color)obj30 : aqua;
            opCoSp4.BackColor = color30;
            Button straight = this.Straight;
            object obj31 = Program.ColArr[13];
            Color color31 = obj31 != null ? (Color)obj31 : aqua;
            straight.BackColor = color31;
            Button opStSq0 = this.OpStSq0;
            object obj32 = Program.ColArr[13];
            Color color32 = obj32 != null ? (Color)obj32 : aqua;
            opStSq0.BackColor = color32;
            Button opStSq1 = this.OpStSq1;
            object obj33 = Program.ColArr[13];
            Color color33 = obj33 != null ? (Color)obj33 : aqua;
            opStSq1.BackColor = color33;
            Button opStSq2 = this.OpStSq2;
            object obj34 = Program.ColArr[13];
            Color color34 = obj34 != null ? (Color)obj34 : aqua;
            opStSq2.BackColor = color34;
            Button opStSq3 = this.OpStSq3;
            object obj35 = Program.ColArr[13];
            Color color35 = obj35 != null ? (Color)obj35 : aqua;
            opStSq3.BackColor = color35;
            Button opStSq4 = this.OpStSq4;
            object obj36 = Program.ColArr[13];
            Color color36 = obj36 != null ? (Color)obj36 : aqua;
            opStSq4.BackColor = color36;
        }

        public void ButtonBackColor()
        {
            this.OpStop.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
            Button axel = this.Axel;
            object obj1 = Program.ColArr[2];
            Color aqua = Color.Aqua;
            Color color1 = obj1 != null ? (Color)obj1 : aqua;
            axel.BackColor = color1;
            Button opA1 = this.OpA1;
            object obj2 = Program.ColArr[2];
            Color color2 = obj2 != null ? (Color)obj2 : aqua;
            opA1.BackColor = color2;
            Button opA2 = this.OpA2;
            object obj3 = Program.ColArr[2];
            Color color3 = obj3 != null ? (Color)obj3 : aqua;
            opA2.BackColor = color3;
            Button opA3 = this.OpA3;
            object obj4 = Program.ColArr[2];
            Color color4 = obj4 != null ? (Color)obj4 : aqua;
            opA3.BackColor = color4;
            Button opA4 = this.OpA4;
            object obj5 = Program.ColArr[2];
            Color color5 = obj5 != null ? (Color)obj5 : aqua;
            opA4.BackColor = color5;
            Button toeLoop = this.ToeLoop;
            object obj6 = Program.ColArr[3];
            Color color6 = obj6 != null ? (Color)obj6 : aqua;
            toeLoop.BackColor = color6;
            Button opT1 = this.OpT1;
            object obj7 = Program.ColArr[3];
            Color color7 = obj7 != null ? (Color)obj7 : aqua;
            opT1.BackColor = color7;
            Button opT2 = this.OpT2;
            object obj8 = Program.ColArr[3];
            Color color8 = obj8 != null ? (Color)obj8 : aqua;
            opT2.BackColor = color8;
            Button opT3 = this.OpT3;
            object obj9 = Program.ColArr[3];
            Color color9 = obj9 != null ? (Color)obj9 : aqua;
            opT3.BackColor = color9;
            Button opT4 = this.OpT4;
            object obj10 = Program.ColArr[3];
            Color color10 = obj10 != null ? (Color)obj10 : aqua;
            opT4.BackColor = color10;
            Button loopText = this.LoopText;
            object obj11 = Program.ColArr[4];
            Color color11 = obj11 != null ? (Color)obj11 : aqua;
            loopText.BackColor = color11;
            Button opL1 = this.OpL1;
            object obj12 = Program.ColArr[4];
            Color color12 = obj12 != null ? (Color)obj12 : aqua;
            opL1.BackColor = color12;
            Button opL2 = this.OpL2;
            object obj13 = Program.ColArr[4];
            Color color13 = obj13 != null ? (Color)obj13 : aqua;
            opL2.BackColor = color13;
            Button opL3 = this.OpL3;
            object obj14 = Program.ColArr[4];
            Color color14 = obj14 != null ? (Color)obj14 : aqua;
            opL3.BackColor = color14;
            Button opL4 = this.OpL4;
            object obj15 = Program.ColArr[4];
            Color color15 = obj15 != null ? (Color)obj15 : aqua;
            opL4.BackColor = color15;
            Button flip = this.Flip;
            object obj16 = Program.ColArr[5];
            Color color16 = obj16 != null ? (Color)obj16 : aqua;
            flip.BackColor = color16;
            Button opF1 = this.OpF1;
            object obj17 = Program.ColArr[5];
            Color color17 = obj17 != null ? (Color)obj17 : aqua;
            opF1.BackColor = color17;
            Button opF2 = this.OpF2;
            object obj18 = Program.ColArr[5];
            Color color18 = obj18 != null ? (Color)obj18 : aqua;
            opF2.BackColor = color18;
            Button opF3 = this.OpF3;
            object obj19 = Program.ColArr[5];
            Color color19 = obj19 != null ? (Color)obj19 : aqua;
            opF3.BackColor = color19;
            Button opF4 = this.OpF4;
            object obj20 = Program.ColArr[5];
            Color color20 = obj20 != null ? (Color)obj20 : aqua;
            opF4.BackColor = color20;
            Button lutz = this.Lutz;
            object obj21 = Program.ColArr[6];
            Color color21 = obj21 != null ? (Color)obj21 : aqua;
            lutz.BackColor = color21;
            Button opLz1 = this.OpLz1;
            object obj22 = Program.ColArr[6];
            Color color22 = obj22 != null ? (Color)obj22 : aqua;
            opLz1.BackColor = color22;
            Button opLz2 = this.OpLz2;
            object obj23 = Program.ColArr[6];
            Color color23 = obj23 != null ? (Color)obj23 : aqua;
            opLz2.BackColor = color23;
            Button opLz3 = this.OpLz3;
            object obj24 = Program.ColArr[6];
            Color color24 = obj24 != null ? (Color)obj24 : aqua;
            opLz3.BackColor = color24;
            Button opLz4 = this.OpLz4;
            object obj25 = Program.ColArr[6];
            Color color25 = obj25 != null ? (Color)obj25 : aqua;
            opLz4.BackColor = color25;
            Button salchow = this.Salchow;
            object obj26 = Program.ColArr[7];
            Color color26 = obj26 != null ? (Color)obj26 : aqua;
            salchow.BackColor = color26;
            Button opS1 = this.OpS1;
            object obj27 = Program.ColArr[7];
            Color color27 = obj27 != null ? (Color)obj27 : aqua;
            opS1.BackColor = color27;
            Button opS2 = this.OpS2;
            object obj28 = Program.ColArr[7];
            Color color28 = obj28 != null ? (Color)obj28 : aqua;
            opS2.BackColor = color28;
            Button opS3 = this.OpS3;
            object obj29 = Program.ColArr[7];
            Color color29 = obj29 != null ? (Color)obj29 : aqua;
            opS3.BackColor = color29;
            Button opS4 = this.OpS4;
            object obj30 = Program.ColArr[7];
            Color color30 = obj30 != null ? (Color)obj30 : aqua;
            opS4.BackColor = color30;
            this.OpSEQ.BackColor = Color.FromArgb(133, 0, 0);
            this.OpCOMBO.BackColor = Color.FromArgb(254, 0, 254);
            this.OpClearEntry.BackColor = Color.FromArgb(254, 254, 0);
            Button choreoSeq = this.ChoreoSeq;
            object obj31 = Program.ColArr[14];
            Color color31 = obj31 != null ? (Color)obj31 : aqua;
            choreoSeq.BackColor = color31;
            Button chSq1 = this.ChSq1;
            object obj32 = Program.ColArr[14];
            Color color32 = obj32 != null ? (Color)obj32 : aqua;
            chSq1.BackColor = color32;
            this.OpFlying.BackColor = Color.FromArgb(236, 233, 216);
            this.OpNext1.BackColor = Color.FromArgb(236, 233, 216);
            this.OpInsert.BackColor = Color.FromArgb(254, 191, 40);
            this.OpDeleteRow.BackColor = Color.FromArgb(192, 192, 0);
        }

        public void BackColor_V() => this.Spin_V.BackColor = Color.FromArgb(128, (int)byte.MaxValue, (int)byte.MaxValue);

        public void InitOpForm()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = -1;
                this.ClrDelInsR = 0;
                Program.OpArr = (Program.OpType[])null;
                Program.OpArr = new Program.OpType[16];
                Program.DoHTrun = false;
                this.HideNum();
                this.InitColArr();
                this.Text = "ELEMENT INPUT: " + Strings.UCase(Program.Category.Name) + Program.SubCat() + ": " + Strings.UCase(Program.GetSegTxt(Program.Segment));
                this.ButtonBackColor();
                this.SpinBackcolor();
                this.BackColor_V();
                if (Program.WorkMode < 2)
                {
                    this.ChSq1.Visible = false;
                    this.OpStSq0.Visible = false;
                    this.OpStSq1.Visible = false;
                    this.OpStSq2.Visible = false;
                    this.OpStSq3.Visible = false;
                    this.OpStSq4.Visible = false;
                    this.OpSSp0.Visible = false;
                    this.OpSSp1.Visible = false;
                    this.OpSSp2.Visible = false;
                    this.OpSSp3.Visible = false;
                    this.OpSSp4.Visible = false;
                    this.OpLSp0.Visible = false;
                    this.OpLSp1.Visible = false;
                    this.OpLSp2.Visible = false;
                    this.OpLSp3.Visible = false;
                    this.OpLSp4.Visible = false;
                    this.OpUSp0.Visible = false;
                    this.OpUSp1.Visible = false;
                    this.OpUSp2.Visible = false;
                    this.OpUSp3.Visible = false;
                    this.OpUSp4.Visible = false;
                    this.OpCSp0.Visible = false;
                    this.OpCSp1.Visible = false;
                    this.OpCSp2.Visible = false;
                    this.OpCSp3.Visible = false;
                    this.OpCSp4.Visible = false;
                    this.OpCoSp0.Visible = false;
                    this.OpCoSp1.Visible = false;
                    this.OpCoSp2.Visible = false;
                    this.OpCoSp3.Visible = false;
                    this.OpCoSp4.Visible = false;
                    this.opREP.Visible = false;
                    this.ColorBox.Visible = false;
                }
                if (Program.WorkMode > 1)
                {
                    string segment1 = Program.Segment;
                    if (Operators.CompareString(segment1, "Seg1", false) == 0)
                    {
                        if (Program.Bonus_Sel("Seg1"))
                        {
                            if (Program.Vek[Program.PNo].Bonus_Seg1 > 0)
                                this.Bonus.Text = "BONUS " + Conversions.ToString(Program.Vek[Program.PNo].Bonus_Seg1);
                            else
                                this.Bonus.Text = "BONUS  0";
                            this.Bonus.Visible = true;
                            this.Bonus_minus.Visible = true;
                            this.Bonus_plus.Visible = true;
                        }
                        else
                        {
                            this.Bonus.Visible = false;
                            this.Bonus_minus.Visible = false;
                            this.Bonus_plus.Visible = false;
                        }
                    }
                    else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                    {
                        if (Program.Bonus_Sel("Seg2"))
                        {
                            if (Program.Vek[Program.PNo].Bonus_Seg2 > 0)
                                this.Bonus.Text = "BONUS " + Conversions.ToString(Program.Vek[Program.PNo].Bonus_Seg2);
                            else
                                this.Bonus.Text = "BONUS  0";
                            this.Bonus.Visible = true;
                            this.Bonus_minus.Visible = true;
                            this.Bonus_plus.Visible = true;
                        }
                        else
                        {
                            this.Bonus.Visible = false;
                            this.Bonus_minus.Visible = false;
                            this.Bonus_plus.Visible = false;
                        }
                    }
                    string segment2 = Program.Segment;
                    if (Operators.CompareString(segment2, "Seg1", false) == 0)
                        this.Falls_out.Text = "FALLS  " + Conversions.ToString(Program.Vek[Program.PNo].Falls_seg1);
                    else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                        this.Falls_out.Text = "FALLS  " + Conversions.ToString(Program.Vek[Program.PNo].Falls_seg2);
                    this.OpDG.Visible = true;
                    this.OpQ.Visible = true;
                    this.OpUR.Visible = true;
                    this.Edge.Visible = true;
                    this.OpExcl.Visible = true;
                    this.OpFallinElement.Visible = true;
                    this.Zero.Visible = true;
                    this.Review.Visible = true;
                    this.Falls_out.Text = "FALLS  " + Conversions.ToString(this.NoFalls());
                    this.Falls_minus.Visible = true;
                    this.Falls_out.Visible = true;
                    this.Time.Visible = true;
                    this.btnDED.Visible = true;
                    this.OpMsg.Visible = true;
                    this.opREP.Visible = true;
                    string segment3 = Program.Segment;
                    if (Operators.CompareString(segment3, "Seg1", false) == 0)
                    {
                        if (Program.HalfTime_Sel())
                            this.HalfTime.Visible = true;
                        else
                            this.HalfTime.Visible = false;
                    }
                    else if (Operators.CompareString(segment3, "Seg2", false) == 0)
                    {
                        if (Program.HalfTime_Sel())
                            this.HalfTime.Visible = true;
                        else
                            this.HalfTime.Visible = false;
                    }
                    if (this.HalfTime.Visible)
                        this.HalfTime.BackColor = Color.FromArgb(236, 233, 216);
                    this.StartHT.BackColor = Color.FromArgb(236, 233, 216);
                    this.StartHT.Visible = true;
                    this.StopHT.BackColor = Color.FromArgb(236, 233, 216);
                    this.StopHT.Visible = true;
                    this.Spin_V.Visible = true;
                }
                else
                {
                    this.Bonus.Visible = false;
                    this.Bonus_minus.Visible = false;
                    this.Bonus_plus.Visible = false;
                    this.OpDG.Visible = false;
                    this.OpQ.Visible = false;
                    this.OpUR.Visible = false;
                    this.Edge.Visible = false;
                    this.OpExcl.Visible = false;
                    this.OpFallinElement.Visible = false;
                    this.HalfTime.Visible = false;
                    this.StartHT.Visible = false;
                    this.StopHT.Visible = false;
                    this.Zero.Visible = false;
                    this.Review.Visible = false;
                    this.Falls.Visible = false;
                    this.Falls_minus.Visible = false;
                    this.Falls_out.Visible = false;
                    this.Time.Visible = false;
                    this.btnDED.Visible = false;
                    this.OpMsg.Visible = false;
                    this.Spin_V.Visible = false;
                }
                this.OpName.Text = Program.Vek[Program.PNo].Name.FName + " " + Program.Vek[Program.PNo].Name.LName;
                this.OpClub.Text = Program.Vek[Program.PNo].Club;
                this.index = 0;
                int index = 1;
                do
                {
                    string str1 = "";
                    string str2 = "";
                    string segment = Program.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        str2 = Operators.CompareString(Program.Vek[Program.PNo].SSS_Seg1[index], (string)null, false) == 0 ? "" : Program.Vek[Program.PNo].SSS_Seg1[index];
                        str1 = Operators.CompareString(Program.Vek[Program.PNo].SSS_Seg1_edges[index], (string)null, false) == 0 ? "" : Program.Vek[Program.PNo].SSS_Seg1_edges[index];
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        str2 = Operators.CompareString(Program.Vek[Program.PNo].SSS_Seg2[index], (string)null, false) == 0 ? "" : Program.Vek[Program.PNo].SSS_Seg2[index];
                        str1 = Operators.CompareString(Program.Vek[Program.PNo].SSS_Seg2_edges[index], (string)null, false) == 0 ? "" : Program.Vek[Program.PNo].SSS_Seg2_edges[index];
                    }

                    if (str2.Contains(" e") && string.IsNullOrWhiteSpace(str1))
                    {
                        str1 = "e";
                    }

                    int num3 = Strings.InStr(1, str2, " !", CompareMethod.Text);
                    if (num3 > 0)
                    {
                        if (string.IsNullOrWhiteSpace(str1))
                            str1 += "!";

                        str2 = Strings.Left(str2, checked(num3 - 1));
                    }
                    
                    Program.OpArr[index].element = str2;
                    Program.OpArr[index].edge = str1;
                    checked { ++index; }
                }
                while (index <= 15);
                this.VisaData();
                if (Program.WorkMode == 2)
                {
                    Program.Get_CC_Time();
                    MyProject.Forms.MainForm.MakeJudgeTxtFile(0);
                }
                this.OpListaSet();
                goto label_52;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("InitOpForm - Max pno=" + Conversions.ToString(42) + "   i =" + Conversions.ToString(this.index)), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_52:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Sit_Click(object sender, EventArgs e) => this.ElDef2(this.index, "SSp");

        private void OpSSp0_Click(object sender, EventArgs e) => this.ElSel(this.index, "SSp", "B");

        private void OpSSp1_Click(object sender, EventArgs e) => this.ElSel(this.index, "SSp", "1");

        private void OpSSp2_Click(object sender, EventArgs e) => this.ElSel(this.index, "SSp", "2");

        private void OpSSp3_Click(object sender, EventArgs e) => this.ElSel(this.index, "SSp", "3");

        private void OpSSp4_Click(object sender, EventArgs e) => this.ElSel(this.index, "SSp", "4");

        private void OpLSp0_Click(object sender, EventArgs e) => this.ElSel(this.index, "LSp", "B");

        private void Layback_Click(object sender, EventArgs e) => this.ElDef2(this.index, "LSp");

        private void OpLSp1_Click(object sender, EventArgs e) => this.ElSel(this.index, "LSp", "1");

        private void OpLSp2_Click(object sender, EventArgs e) => this.ElSel(this.index, "LSp", "2");

        private void OpLSp3_Click(object sender, EventArgs e) => this.ElSel(this.index, "LSp", "3");

        private void OpLSp4_Click(object sender, EventArgs e) => this.ElSel(this.index, "LSp", "4");

        private void OpClearEntry_Click(object sender, EventArgs e) => this.ClearEntry();

        private void ClearEntry()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                num3 = 3;
                if (this.index > -1)
                {
                    num3 = 4;
                    Program.OpType[] opArr = Program.OpArr;
                    int index = checked(this.index + 1);
                    num3 = 5;
                    opArr[index].element = "";
                    num3 = 6;
                    opArr[index].edge = "";
                    num3 = 7;
                    opArr[index].replay = "";
                    num3 = 9;
                    this.OpFlying.BackColor = Color.FromArgb(236, 233, 216);
                    num3 = 10;
                    this.OpChange.BackColor = Color.FromArgb(236, 233, 216);
                    num3 = 11;
                    this.BackColor_V();
                    num3 = 12;
                    this.SpinBackcolor();
                    num3 = 13;
                    this.HideNum();
                    num3 = 14;
                    string segment = Program.Segment;
                    num3 = 17;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        num3 = 18;
                        if (Program.Vek[Program.PNo].HTIndSeg1 == checked(this.index + 1))
                        {
                            num3 = 19;
                            Program.Vek[Program.PNo].HTIndSeg1 = 0;
                        }
                    }
                    else
                    {
                        num3 = 22;
                        if (Operators.CompareString(segment, "Seg2", false) == 0)
                        {
                            num3 = 23;
                            if (Program.Vek[Program.PNo].HTIndSeg2 == checked(this.index + 1))
                            {
                                num3 = 24;
                                Program.Vek[Program.PNo].HTIndSeg2 = 0;
                            }
                        }
                    }
                    num3 = 27;
                    this.ClrDelInsR = 1;
                    num3 = 28;
                    DataGridView dataGridView1 = this.DataGridView1;
                    num3 = 29;
                    dataGridView1.Rows[this.index].Cells[1].Value = (object)"";
                    num3 = 30;
                    dataGridView1.Rows[this.index].Cells[2].Value = (object)"";
                    num3 = 31;
                    dataGridView1.Rows[this.index].Cells[3].Value = (object)"";
                }
                num3 = 34;
                this.SendVek();
                num3 = 35;
                this.OplistaSelect();
                num3 = 36;
                this.ClrDelInsR = 0;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void NoLevel_Click(object sender, EventArgs e) => this.ElSet(this.index, "");

        private void Set0_Click(object sender, EventArgs e) => this.ElSet(this.index, "B");

        private void Set1_Click(object sender, EventArgs e) => this.ElSet(this.index, "1");

        private void Set2_Click(object sender, EventArgs e) => this.ElSet(this.index, "2");

        private void Set3_Click(object sender, EventArgs e) => this.ElSet(this.index, "3");

        private void Set4_Click(object sender, EventArgs e) => this.ElSet(this.index, "4");

        private bool F_Spin(string txt)
        {
            int num1 = 0;
            bool flag = false;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                flag = false;
                num3 = 3;
                if (Strings.Len(txt) != 0)
                {
                    num3 = 6;
                    int spinMin = Program.SpinMin;
                    int spinmax = Program.Spinmax;
                    int index = spinMin;
                    while (index <= spinmax)
                    {
                        num3 = 7;
                        if (Operators.ConditionalCompareObjectEqual((object)txt, Program.ElDB[index, 0], false))
                        {
                            num3 = 8;
                            flag = true;
                            break;
                        }
                        num3 = 11;
                        checked { ++index; }
                    }
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            int num4 = flag ? 1 : 0;
            if (num2 == 0)
                return num4 != 0;
            ProjectData.ClearProjectError();
            return num4 != 0;
        }

        public void SpinEl(string ElIn, ref string ElOut, ref string txt)
        {
            ElOut = ElIn;
            if (Operators.CompareString(Strings.Right(ElIn, 1), "V", false) != 0)
                return;
            ElOut = Strings.Trim(ElOut.Remove(checked(ElOut.Length - 1)));
            txt = "V";
        }

        private void OpChange_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string ElOut = "";
                string txt = "";
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                int index = checked(this.index + 1);
                if (this.index > -1 & Strings.Len(Program.OpArr[index].element) == 0)
                {
                    if (this.OpChange.BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0))
                        this.OpChange.BackColor = Color.FromArgb(236, 233, 216);
                    else
                        this.OpChange.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                    this.OplistaSelect();
                    goto label_64;
                }
                else
                {
                    this.SpinEl(Program.OpArr[index].element, ref ElOut, ref txt);
                    if (Strings.Len(txt) > 0)
                        txt = txt;
                    if (this.F_Spin(ElOut))
                    {
                        int Length;
                        string str1;
                        if (Versioned.IsNumeric((object)Strings.Right(ElOut, 1)) | Operators.CompareString(Strings.Right(ElOut, 1), "B", false) == 0)
                        {
                            Length = checked(Strings.Len(ElOut) - 1);
                            str1 = Strings.Right(ElOut, 1);
                        }
                        else
                        {
                            Length = Strings.Len(ElOut);
                            str1 = "";
                        }
                        string str2 = Strings.Left(ElOut, Length);
                        string Left1 = str2;
                        if (Operators.CompareString(Left1, "SSp", false) == 0 || Operators.CompareString(Left1, "LSp", false) == 0 || Operators.CompareString(Left1, "USp", false) == 0 || Operators.CompareString(Left1, "CSp", false) == 0 || Operators.CompareString(Left1, "CoSp", false) == 0)
                        {
                            Program.OpArr[index].element = !this.Spin_Change("C" + str2) ? "C" + ElOut : (Strings.Len(txt) <= 0 ? "C" + ElOut : "C" + ElOut + txt);
                            this.OpChange.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                        }
                        else if (Operators.CompareString(Left1, "FSSp", false) == 0 || Operators.CompareString(Left1, "FLSp", false) == 0 || Operators.CompareString(Left1, "FUSp", false) == 0 || Operators.CompareString(Left1, "FCSp", false) == 0 || Operators.CompareString(Left1, "FCoSp", false) == 0)
                        {
                            int num3 = Strings.Len(str2);
                            if (this.Spin_Change("FC" + Strings.Right(str2, checked(num3 - 1))))
                            {
                                int num4 = Strings.Len(ElOut);
                                Program.OpArr[index].element = Strings.Len(txt) <= 0 ? "FC" + Strings.Right(ElOut, checked(num4 - 1)) : "FC" + Strings.Right(ElOut, checked(num4 - 1)) + txt;
                            }
                            else
                            {
                                int num5 = Strings.Len(ElOut);
                                Program.OpArr[index].element = Strings.Len(txt) <= 0 ? "FC" + Strings.Right(ElOut, checked(num5 - 1)) : "FC" + Strings.Right(ElOut, checked(num5 - 1)) + txt;
                            }
                            this.OpChange.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                        }
                        else if (Operators.CompareString(Left1, "CSSp", false) == 0 || Operators.CompareString(Left1, "CLSp", false) == 0 || Operators.CompareString(Left1, "CUSp", false) == 0 || Operators.CompareString(Left1, "CCSp", false) == 0 || Operators.CompareString(Left1, "CCoSp", false) == 0)
                        {
                            int num6 = Strings.Len(str2);
                            if (this.Spin_Change(Strings.Right(str2, checked(num6 - 1))))
                            {
                                int num7 = Strings.Len(ElOut);
                                Program.OpArr[index].element = Strings.Len(txt) <= 0 ? Strings.Right(ElOut, checked(num7 - 1)) : Strings.Right(ElOut, checked(num7 - 1)) + txt;
                            }
                            else
                            {
                                int num8 = Strings.Len(ElOut);
                                this.BackColor_V();
                                Program.OpArr[index].element = Strings.Right(ElOut, checked(num8 - 1));
                            }
                            this.OpChange.BackColor = Color.FromArgb(236, 233, 216);
                        }
                        else if (Operators.CompareString(Left1, "FCSSp", false) == 0 || Operators.CompareString(Left1, "FCLSp", false) == 0 || Operators.CompareString(Left1, "FCUSp", false) == 0 || Operators.CompareString(Left1, "FCCSp", false) == 0 || Operators.CompareString(Left1, "FCCoSp", false) == 0)
                        {
                            int num9 = Strings.Len(str2);
                            if (this.Spin_Change("F" + Strings.Right(str2, checked(num9 - 2))))
                            {
                                int num10 = Strings.Len(ElOut);
                                Program.OpArr[index].element = Strings.Len(txt) <= 0 ? "F" + Strings.Right(ElOut, checked(num10 - 2)) : "F" + Strings.Right(ElOut, checked(num10 - 2)) + txt;
                            }
                            else
                            {
                                int num11 = Strings.Len(ElOut);
                                Program.OpArr[index].element = Strings.Len(txt) <= 0 ? "F" + Strings.Right(ElOut, checked(num11 - 2)) : "F" + Strings.Right(ElOut, checked(num11 - 2)) + txt;
                            }
                            this.OpChange.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                        }
                        else if (Operators.CompareString(Left1, "CoSp2p", false) == 0 || Operators.CompareString(Left1, "CoSp3p", false) == 0)
                        {
                            string Left2 = Strings.Right(str2, 2);
                            if (Operators.CompareString(Left2, "2p", false) == 0)
                            {
                                this.BackColor_V();
                                Program.OpArr[index].element = "CCoSp2p" + str1 + txt;
                            }
                            else if (Operators.CompareString(Left2, "3p", false) == 0)
                            {
                                this.BackColor_V();
                                Program.OpArr[index].element = "CCoSp3p" + str1 + txt;
                            }
                            else
                                Program.OpArr[index].element = "CCoSp" + str1;
                            this.OpChange.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                        }
                        else if (Operators.CompareString(Left1, "CCoSp2p", false) == 0 || Operators.CompareString(Left1, "CCoSp3p", false) == 0)
                        {
                            string Left3 = Strings.Right(str2, 2);
                            if (Operators.CompareString(Left3, "2p", false) == 0)
                            {
                                this.BackColor_V();
                                Program.OpArr[index].element = "CoSp2p" + str1 + txt;
                            }
                            else if (Operators.CompareString(Left3, "3p", false) == 0)
                            {
                                this.BackColor_V();
                                Program.OpArr[index].element = "CoSp3p" + str1 + txt;
                            }
                            else
                                Program.OpArr[index].element = "CoSp" + str1;
                            this.OpChange.BackColor = Color.FromArgb(236, 233, 216);
                        }
                        else if (Operators.CompareString(Left1, "FCCoSp2p", false) == 0 || Operators.CompareString(Left1, "FCCoSp3p", false) == 0)
                        {
                            string Left4 = Strings.Right(str2, 2);
                            if (Operators.CompareString(Left4, "2p", false) == 0)
                            {
                                this.BackColor_V();
                                Program.OpArr[index].element = "FCoSp2p" + str1 + txt;
                            }
                            else if (Operators.CompareString(Left4, "3p", false) == 0)
                            {
                                this.BackColor_V();
                                Program.OpArr[index].element = "FCoSp3p" + str1 + txt;
                            }
                            else
                                Program.OpArr[index].element = "FCoSp" + str1;
                            this.OpChange.BackColor = Color.FromArgb(236, 233, 216);
                        }
                        else if (Operators.CompareString(Left1, "FCoSp2p", false) == 0 || Operators.CompareString(Left1, "FCoSp3p", false) == 0)
                        {
                            string Left5 = Strings.Right(str2, 2);
                            if (Operators.CompareString(Left5, "2p", false) == 0)
                            {
                                this.BackColor_V();
                                Program.OpArr[index].element = "FCCoSp2p" + str1 + txt;
                            }
                            else if (Operators.CompareString(Left5, "3p", false) == 0)
                            {
                                this.BackColor_V();
                                Program.OpArr[index].element = "FCCoSp3p" + str1 + txt;
                            }
                            else
                                Program.OpArr[index].element = "FCCoSp" + str1;
                            this.OpChange.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                        }
                        this.OpLista(this.index, Program.OpArr[index].element);
                        goto label_64;
                    }
                    else
                    {
                        Interaction.Beep();
                        this.OplistaSelect();
                        goto label_64;
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
                int num12 = (int)Interaction.MsgBox((object)("OpChange_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_64:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void OpFlying_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string ElOut = "";
                string txt = "";
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                int index = checked(this.index + 1);
                if (this.index > -1 & Strings.Len(Program.OpArr[index].element) == 0)
                {
                    if (this.OpFlying.BackColor == Color.FromArgb((int)byte.MaxValue, 0, 0))
                        this.OpFlying.BackColor = Color.FromArgb(236, 233, 216);
                    else
                        this.OpFlying.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                    this.OplistaSelect();
                    return;
                }
                this.SpinEl(Program.OpArr[index].element, ref ElOut, ref txt);
                if (this.F_Spin(ElOut))
                {
                    if (Operators.CompareString(Strings.Left(ElOut, 1), "F", false) != 0)
                    {
                        Program.OpArr[index].element = Strings.Len(txt) <= 0 ? "F" + ElOut : "F" + ElOut + txt;
                        this.OpFlying.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                    }
                    else
                    {
                        int num3 = Strings.Len(ElOut);
                        if (!this.Spin_Change(Strings.Right(ElOut, checked(num3 - 1))))
                        {
                            this.BackColor_V();
                            Program.OpArr[index].element = Strings.Right(ElOut, checked(num3 - 1));
                        }
                        else if (Strings.Len(txt) > 0)
                        {
                            Program.OpArr[index].element = Operators.CompareString(txt, "V", false) != 0 ? Strings.Right(ElOut, checked(num3 - 1)) : Strings.Right(ElOut, checked(num3 - 1)) + txt;
                        }
                        else
                        {
                            Program.OpArr[index].element = Strings.Right(ElOut, checked(num3 - 1));
                            this.BackColor_V();
                        }
                        this.OpFlying.BackColor = Color.FromArgb(236, 233, 216);
                    }
                    this.OpLista(this.index, Program.OpArr[index].element);
                    return;
                }
                Interaction.Beep();
                this.OplistaSelect();
                return;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            int num4 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("OpFlying_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            else
            {
                if (num4 == 0)
                    return;
                ProjectData.ClearProjectError();
            }
        }

        private void Upright_Click(object sender, EventArgs e) => this.ElDef2(this.index, "USp");

        private void OpUSp0_Click(object sender, EventArgs e) => this.ElSel(this.index, "USp", "B");

        private void OpUSp1_Click(object sender, EventArgs e) => this.ElSel(this.index, "USp", "1");

        private void OpUSp2_Click(object sender, EventArgs e) => this.ElSel(this.index, "USp", "2");

        private void OpUSp3_Click(object sender, EventArgs e) => this.ElSel(this.index, "USp", "3");

        private void OpUSp4_Click(object sender, EventArgs e) => this.ElSel(this.index, "USp", "4");

        private void Camel_Click(object sender, EventArgs e) => this.ElDef2(this.index, "CSp");

        private void OpCSp0_Click(object sender, EventArgs e) => this.ElSel(this.index, "CSp", "B");

        private void OpCSp1_Click(object sender, EventArgs e) => this.ElSel(this.index, "CSp", "1");

        private void OpCSp2_Click(object sender, EventArgs e) => this.ElSel(this.index, "CSp", "2");

        private void OpCSp3_Click(object sender, EventArgs e) => this.ElSel(this.index, "CSp", "3");

        private void OpCSp4_Click(object sender, EventArgs e) => this.ElSel(this.index, "CSp", "4");

        private void ComboSpin_Click(object sender, EventArgs e) => this.ElDef2(this.index, "CoSp");

        private void OpCoSp0_Click(object sender, EventArgs e) => this.ElSel2(this.index, "CoSp", "B");

        private void OpCoSp1_Click(object sender, EventArgs e) => this.ElSel2(this.index, "CoSp", "1");

        private void OpCoSp2_Click(object sender, EventArgs e) => this.ElSel2(this.index, "CoSp", "2");

        private void OpCoSp3_Click(object sender, EventArgs e) => this.ElSel2(this.index, "CoSp", "3");

        private void OpCoSp4_Click(object sender, EventArgs e) => this.ElSel2(this.index, "CoSp", "4");

        private void Straight_Click(object sender, EventArgs e) => this.ElDef3(this.index, "StSq");

        private void OpStSq0_Click(object sender, EventArgs e) => this.ElSel1(this.index, "StSq", "B");

        private void OpStSq1_Click(object sender, EventArgs e) => this.ElSel1(this.index, "StSq", "1");

        private void OpStSq2_Click(object sender, EventArgs e) => this.ElSel1(this.index, "StSq", "2");

        private void OpStSq3_Click(object sender, EventArgs e) => this.ElSel1(this.index, "StSq", "3");

        private void OpStSq4_Click(object sender, EventArgs e) => this.ElSel1(this.index, "StSq", "4");

        private void OpInsert_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                this.index = dataGridView1.CurrentCellAddress.Y;
                int index1 = 14;
                while (!Operators.ConditionalCompareObjectNotEqual(dataGridView1.Rows[index1].Cells[1].Value, (object)"", false))
                {
                    checked { index1 += -1; }
                    if (index1 < 0)
                        break;
                }
                if (this.index < 14 & index1 < 14)
                {
                    int num3 = this.index <= 0 ? 1 : this.index;
                    int num4 = num3;
                    int index2 = 14;
                    while (index2 >= num4)
                    {
                        dataGridView1.Rows[index2].Cells[1].Value = RuntimeHelpers.GetObjectValue(dataGridView1.Rows[checked(index2 - 1)].Cells[1].Value);
                        dataGridView1.Rows[index2].Cells[2].Value = RuntimeHelpers.GetObjectValue(dataGridView1.Rows[checked(index2 - 1)].Cells[2].Value);
                        dataGridView1.Rows[index2].Cells[3].Value = RuntimeHelpers.GetObjectValue(dataGridView1.Rows[checked(index2 - 1)].Cells[3].Value);
                        Program.OpArr[checked(index2 + 1)] = Program.OpArr[index2];
                        checked { index2 += -1; }
                    }
                    dataGridView1.Rows[this.index].Cells[1].Value = (object)"";
                    dataGridView1.Rows[this.index].Cells[2].Value = (object)"";
                    dataGridView1.Rows[this.index].Cells[3].Value = (object)"";
                    Program.OpArr[checked(this.index + 1)].element = "";
                    Program.OpArr[checked(this.index + 1)].edge = "";
                    Program.OpArr[checked(this.index + 1)].replay = "";
                    this.OpLista(checked(num3 - 1), Program.OpArr[this.index].element);
                }
                else
                {
                    int num5 = (int)Interaction.MsgBox((object)("Insert is not possible!" + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
                this.OplistaSelect();
                this.ClrDelInsR = 0;
                goto label_16;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num6 = (int)Interaction.MsgBox((object)("OpInsert_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_16:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void OpDeleteRow_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                DataGridView dataGridView1 = this.DataGridView1;
                this.index = dataGridView1.CurrentCellAddress.Y;
                if (this.index >= 0 & this.index <= 41)
                {
                    if (Interaction.MsgBox((object)("Row " + Conversions.ToString(checked(this.index + 1)) + " will be deleted!"), MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.Yes)
                    {
                        dataGridView1.Rows[this.index].Cells[1].Value = (object)"";
                        dataGridView1.Rows[this.index].Cells[2].Value = (object)"";
                        dataGridView1.Rows[this.index].Cells[3].Value = (object)"";
                        Program.OpArr[checked(this.index + 1)].element = "";
                        Program.OpArr[checked(this.index + 1)].edge = "";
                        Program.OpArr[checked(this.index + 1)].replay = "";
                        this.BackColor_V();
                        this.SpinBackcolor();
                        int index = this.index;
                        while (index <= 13)
                        {
                            dataGridView1.Rows[index].Cells[1].Value = RuntimeHelpers.GetObjectValue(dataGridView1.Rows[checked(index + 1)].Cells[1].Value);
                            dataGridView1.Rows[index].Cells[2].Value = RuntimeHelpers.GetObjectValue(dataGridView1.Rows[checked(index + 1)].Cells[2].Value);
                            dataGridView1.Rows[index].Cells[3].Value = RuntimeHelpers.GetObjectValue(dataGridView1.Rows[checked(index + 1)].Cells[3].Value);
                            Program.OpArr[checked(index + 1)] = Program.OpArr[checked(index + 2)];
                            checked { ++index; }
                        }
                        dataGridView1.Rows[14].Cells[1].Value = (object)"";
                        dataGridView1.Rows[14].Cells[2].Value = (object)"";
                        dataGridView1.Rows[14].Cells[3].Value = (object)"";
                        Program.OpArr[15].element = "";
                        Program.OpArr[15].edge = "";
                        Program.OpArr[15].replay = "";
                        this.VisaData();
                        this.ClrDelInsR = 1;
                    }
                }
                else
                {
                    int num3 = (int)Interaction.MsgBox((object)"Please select a row!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
                this.OpListaSet();
                this.SendVek();
                this.OplistaSelect();
                this.ClrDelInsR = 0;
                goto label_14;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("OpDeleteRow_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_14:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Axel_Click(object sender, EventArgs e) => this.Jsel(this.index, "A");

        private void OpA1_Click(object sender, EventArgs e) => this.Jsel(this.index, "1A");

        private void OpA2_Click(object sender, EventArgs e) => this.Jsel(this.index, "2A");

        private void OpA3_Click(object sender, EventArgs e) => this.Jsel(this.index, "3A");

        private void OpA4_Click(object sender, EventArgs e) => this.Jsel(this.index, "4A");

        private void ToeLoop_Click(object sender, EventArgs e) => this.Jsel(this.index, "T");

        private void OpT1_Click(object sender, EventArgs e) => this.Jsel(this.index, "1T");

        private void OpT2_Click(object sender, EventArgs e) => this.Jsel(this.index, "2T");

        private void OpT3_Click(object sender, EventArgs e) => this.Jsel(this.index, "3T");

        private void OpT4_Click(object sender, EventArgs e) => this.Jsel(this.index, "4T");

        private void LoopText_Click(object sender, EventArgs e) => this.Jsel(this.index, "Lo");

        private void OpL1_Click(object sender, EventArgs e) => this.Jsel(this.index, "1Lo");

        private void OpL2_Click(object sender, EventArgs e) => this.Jsel(this.index, "2Lo");

        private void OpL3_Click(object sender, EventArgs e) => this.Jsel(this.index, "3Lo");

        private void OpL4_Click(object sender, EventArgs e) => this.Jsel(this.index, "4Lo");

        private void Euler_Click(object sender, EventArgs e) => this.Jsel(this.index, "Eu");

        private void Waltz_Click(object sender, EventArgs e) => this.Jsel(this.index, "W");

        private void OpEu1_Click(object sender, EventArgs e) => this.Jsel(this.index, "1Eu");

        private void OpW1_Click(object sender, EventArgs e) => this.Jsel(this.index, "1W");

        private void Flip_Click(object sender, EventArgs e) => this.Jsel(this.index, "F");

        private void OpF1_Click(object sender, EventArgs e) => this.Jsel(this.index, "1F");

        private void OpF2_Click(object sender, EventArgs e) => this.Jsel(this.index, "2F");

        private void OpF3_Click(object sender, EventArgs e) => this.Jsel(this.index, "3F");

        private void OpF4_Click(object sender, EventArgs e) => this.Jsel(this.index, "4F");

        private void Lutz_Click(object sender, EventArgs e) => this.Jsel(this.index, "Lz");

        private void OpLz1_Click(object sender, EventArgs e) => this.Jsel(this.index, "1Lz");

        private void OpLz2_Click(object sender, EventArgs e) => this.Jsel(this.index, "2Lz");

        private void OpLz3_Click(object sender, EventArgs e) => this.Jsel(this.index, "3Lz");

        private void OpLz4_Click(object sender, EventArgs e) => this.Jsel(this.index, "4Lz");

        private void Salchow_Click(object sender, EventArgs e) => this.Jsel(this.index, "S");

        private void OpS1_Click(object sender, EventArgs e) => this.Jsel(this.index, "1S");

        private void OpS2_Click(object sender, EventArgs e) => this.Jsel(this.index, "2S");

        private void OpS3_Click(object sender, EventArgs e) => this.Jsel(this.index, "3S");

        private void OpS4_Click(object sender, EventArgs e) => this.Jsel(this.index, "4S");

        private bool TstJump(string ElIn)
        {
            int num1 = 0;
            bool flag = false;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                flag = false;
                string str = !ElIn.Contains("+") ? ElIn : ElIn.Substring(checked(ElIn.LastIndexOf("+") + 1));
                if (str.Contains("*"))
                    str = Strings.Replace(str, "*", "");
                if (str.Contains("!"))
                    str = Strings.Replace(str, "!", "");
                if (str.Contains("f"))
                    str = Strings.Replace(str, "f", "");
                if (str.Contains(" q"))
                    str = Strings.Replace(str, " q", "");
                if (Operators.CompareString(Strings.Right(str, 1), "e", false) == 0)
                    str = Strings.Trim(str.Remove(checked(str.Length - 1)));
                if (Strings.Len(str) <= 7)
                {
                    if (str.Contains("<"))
                        str = Strings.Trim(Strings.Replace(str, "<", ""));
                    int jumpmin = Program.Jumpmin;
                    int jumpMax = Program.JumpMax;
                    int index = jumpmin;
                    while (index <= jumpMax)
                    {
                        if (Operators.ConditionalCompareObjectEqual((object)str, Program.ElDB[index, 0], false))
                        {
                            flag = true;
                            break;
                        }
                        checked { ++index; }
                    }
                    goto label_17;
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
                int num3 = (int)Interaction.MsgBox((object)("TstJump - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_17:
            int num4 = flag ? 1 : 0;
            if (num2 == 0)
                return num4 != 0;
            ProjectData.ClearProjectError();
            return num4 != 0;
        }

        public bool Tst_Lz_F(string El)
        {
            string str = !El.Contains("+") ? El : El.Substring(checked(El.LastIndexOf("+") + 1));
            bool flag = false;
            if (str.Contains("Lz") | str.Contains("F"))
                flag = true;
            return flag;
        }

        public bool Tst_Lz_or_F(string El) => El.Contains("Lz") | El.Contains("F");

        private void OpSEQ_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 0;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                if (this.index > -1)
                {
                    string str = Program.OpArr[checked(this.index + 1)].element;
                    if (str.Contains("COMBO"))
                        num3 = 1;
                    if (str.Contains("SEQ"))
                    {
                        num4 = 1;
                        int num5 = Strings.InStr(1, str, "+SEQ", CompareMethod.Text);
                        if (num5 > 1)
                            str = Strings.Left(str, checked(num5 - 1));
                    }
                    if (Strings.Len(str) == 0 | num3 > 0 | !this.TstJump(str))
                    {
                        Interaction.Beep();
                        this.OplistaSelect();
                        goto label_16;
                    }
                    else
                    {
                        Program.OpArr[checked(this.index + 1)].element = num4 <= 0 ? str + "+SEQ" : str;
                        this.OpLista(this.index, Program.OpArr[checked(this.index + 1)].element);
                        goto label_16;
                    }
                }
                else
                {
                    this.OplistaSelect();
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
                int num6 = (int)Interaction.MsgBox((object)("OpSEQ_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_16:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void OpCOMBO_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 0;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                if (this.index > -1)
                {
                    string str = Program.OpArr[checked(this.index + 1)].element;
                    if (str.Contains("SEQ"))
                        num4 = 1;
                    if (str.Contains("COMBO"))
                    {
                        num3 = 1;
                        int num5 = Strings.InStr(1, str, "+COMBO", CompareMethod.Text);
                        if (num5 > 1)
                            str = Strings.Left(str, checked(num5 - 1));
                    }
                    if (Strings.Len(str) == 0 | num4 > 0 | !this.TstJump(str))
                    {
                        Interaction.Beep();
                        this.OplistaSelect();
                        goto label_16;
                    }
                    else
                    {
                        Program.OpArr[checked(this.index + 1)].element = num3 <= 0 ? str + "+COMBO" : str;
                        this.OpLista(this.index, Program.OpArr[checked(this.index + 1)].element);
                        goto label_16;
                    }
                }
                else
                {
                    this.OplistaSelect();
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
                int num6 = (int)Interaction.MsgBox((object)("OpCOMBO_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_16:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void OpUR_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string str1 = "";
                bool flag = false;
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                if (this.index > -1 & Strings.Len(Program.OpArr[checked(this.index + 1)].element) > 1 & Operators.CompareString(Strings.Right(Program.OpArr[checked(this.index + 1)].element, 1), "*", false) != 0)
                {
                    string str2 = Program.OpArr[checked(this.index + 1)].element;
                    if (str2.Contains("+SEQ"))
                    {
                        if (Operators.CompareString(Strings.Right(str2, 4), "+SEQ", false) == 0)
                        {
                            str1 = "+SEQ";
                            str2 = Strings.Left(str2, checked(Strings.Len(str2) - 4));
                        }
                        else
                        {
                            int Length = str2.LastIndexOf("+");
                            str1 = Strings.Left(str2, Length);
                            str2 = Strings.Right(str2, checked(Strings.Len(str2) - Length - 1));
                            flag = true;
                        }
                    }
                    else if (str2.Contains("+COMBO"))
                    {
                        if (Operators.CompareString(Strings.Right(str2, 6), "+COMBO", false) == 0)
                        {
                            str1 = "+COMBO";
                            str2 = Strings.Left(str2, checked(Strings.Len(str2) - 6));
                        }
                        else
                        {
                            int Length = str2.LastIndexOf("+");
                            str1 = Strings.Left(str2, Length);
                            str2 = Strings.Right(str2, checked(Strings.Len(str2) - Length - 1));
                            flag = true;
                        }
                    }
                    else if (str2.Contains("+REP"))
                    {
                        if (Operators.CompareString(Strings.Right(str2, 4), "+REP", false) == 0)
                        {
                            str1 = "+REP";
                            str2 = Strings.Left(str2, checked(Strings.Len(str2) - 4));
                        }
                        else
                        {
                            int Length = str2.LastIndexOf("+");
                            str1 = Strings.Left(str2, Length);
                            str2 = Strings.Right(str2, checked(Strings.Len(str2) - Length - 1));
                            flag = true;
                        }
                    }
                    if (Operators.CompareString(Strings.Right(str2, 2), "<<", false) == 0 | Operators.CompareString(Strings.Right(str2, 4), "<< e", false) == 0 | !this.TstJump(str2))
                    {
                        Interaction.Beep();
                        this.OplistaSelect();
                        goto label_23;
                    }
                    else
                    {
                        Program.OpArr[checked(this.index + 1)].element = Operators.CompareString(Strings.Right(str2, 1), "<", false) != 0 ? (Operators.CompareString(Strings.Right(str2, 3), "< e", false) != 0 ? (Operators.CompareString(Strings.Right(str2, 2), " e", false) != 0 ? (flag ? str1 + "+" + str2 + "<" : str2 + "<" + str1) : (flag ? str1 + "+" + Strings.Trim(Strings.Left(str2, checked(Strings.Len(str2) - 2))) + "< e" : Strings.Trim(Strings.Left(str2, checked(Strings.Len(str2) - 2))) + "< e" + str1)) : (flag ? str1 + "+" + Strings.Left(str2, checked(Strings.Len(str2) - 3)) + " e" : Strings.Left(str2, checked(Strings.Len(str2) - 3)) + " e" + str1)) : (flag ? str1 + "+" + Strings.Left(str2, checked(Strings.Len(str2) - 1)) : Strings.Left(str2, checked(Strings.Len(str2) - 1)) + str1);
                        this.OpLista(this.index, Program.OpArr[checked(this.index + 1)].element);
                        goto label_23;
                    }
                }
                else
                {
                    Interaction.Beep();
                    this.OplistaSelect();
                    goto label_23;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("OpUR_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_23:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void OpDG_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string str1 = "";
                bool flag = false;
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                if (this.index > -1 & Strings.Len(Program.OpArr[checked(this.index + 1)].element) > 0 & Operators.CompareString(Strings.Right(Program.OpArr[checked(this.index + 1)].element, 1), "*", false) != 0)
                {
                    string str2 = Program.OpArr[checked(this.index + 1)].element;
                    if (str2.Contains("+SEQ"))
                    {
                        if (Operators.CompareString(Strings.Right(str2, 4), "+SEQ", false) == 0)
                        {
                            str1 = "+SEQ";
                            str2 = Strings.Left(str2, checked(Strings.Len(str2) - 4));
                        }
                        else
                        {
                            int Length = str2.LastIndexOf("+");
                            str1 = Strings.Left(str2, Length);
                            str2 = Strings.Right(str2, checked(Strings.Len(str2) - Length - 1));
                            flag = true;
                        }
                    }
                    else if (str2.Contains("+COMBO"))
                    {
                        if (Operators.CompareString(Strings.Right(str2, 6), "+COMBO", false) == 0)
                        {
                            str1 = "+COMBO";
                            str2 = Strings.Left(str2, checked(Strings.Len(str2) - 6));
                        }
                        else
                        {
                            int Length = str2.LastIndexOf("+");
                            str1 = Strings.Left(str2, Length);
                            str2 = Strings.Right(str2, checked(Strings.Len(str2) - Length - 1));
                            flag = true;
                        }
                    }
                    else if (str2.Contains("+REP"))
                    {
                        if (Operators.CompareString(Strings.Right(str2, 4), "+REP", false) == 0)
                        {
                            str1 = "+REP";
                            str2 = Strings.Left(str2, checked(Strings.Len(str2) - 4));
                        }
                        else
                        {
                            int Length = str2.LastIndexOf("+");
                            str1 = Strings.Left(str2, Length);
                            str2 = Strings.Right(str2, checked(Strings.Len(str2) - Length - 1));
                            flag = true;
                        }
                    }
                    if (this.TstJump(str2))
                    {
                        if (Operators.CompareString(Strings.Right(str2, 2), "<<", false) == 0)
                            Program.OpArr[checked(this.index + 1)].element = flag ? str1 + "+" + Strings.Left(str2, checked(Strings.Len(str2) - 2)) : Strings.Left(str2, checked(Strings.Len(str2) - 2)) + str1;
                        else if (Operators.CompareString(Strings.Right(str2, 4), "<< e", false) == 0)
                            Program.OpArr[checked(this.index + 1)].element = flag ? str1 + "+" + Strings.Left(str2, checked(Strings.Len(str2) - 4)) + " e" : Strings.Left(str2, checked(Strings.Len(str2) - 4)) + " e" + str1;
                        else if (Operators.CompareString(Strings.Right(str2, 2), " e", false) == 0 & Operators.CompareString(Strings.Right(str2, 3), "< e", false) != 0)
                            Program.OpArr[checked(this.index + 1)].element = flag ? str1 + "+" + Strings.Trim(Strings.Left(str2, checked(Strings.Len(str2) - 2))) + "<< e" : Strings.Trim(Strings.Left(str2, checked(Strings.Len(str2) - 2))) + "<< e" + str1;
                        else if (Operators.CompareString(Strings.Right(str2, 1), "<", false) != 0 & Operators.CompareString(Strings.Right(str2, 3), "< e", false) != 0)
                            Program.OpArr[checked(this.index + 1)].element = flag ? str1 + "+" + str2 + "<<" : str2 + "<<" + str1;
                        this.OpLista(this.index, Program.OpArr[checked(this.index + 1)].element);
                        goto label_31;
                    }
                    else
                    {
                        Interaction.Beep();
                        this.OplistaSelect();
                        goto label_31;
                    }
                }
                else
                {
                    Interaction.Beep();
                    this.OplistaSelect();
                    goto label_31;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("OpDG_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_31:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void OpQ_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                index = this.DataGridView1.CurrentCellAddress.Y;
                if (this.index > -1)
                {
                    string element = Program.OpArr[checked(index + 1)].element ?? "";
                    string lastElement = element;
                    int elemLength = Strings.Len(element);

                    if (elemLength > 0)
                    {
                        if (lastElement.Contains("+SEQ"))
                        {
                            if (Operators.CompareString(Strings.Right(lastElement, 4), "+SEQ", false) == 0)
                            {
                                int Length = lastElement.LastIndexOf("+SEQ");
                                lastElement = Strings.Left(lastElement, Length);
                            }
                            else
                            {
                                int Length = lastElement.LastIndexOf("+");
                                Strings.Left(lastElement, Length);
                                lastElement = Strings.Right(lastElement, checked(Strings.Len(lastElement) - Length - 1));
                            }
                        }
                        else if (lastElement.Contains("+COMBO"))
                        {
                            if (Operators.CompareString(Strings.Right(lastElement, 6), "+COMBO", false) == 0)
                            {
                                int Length = lastElement.LastIndexOf("+COMBO");
                                lastElement = Strings.Left(lastElement, Length);
                            }
                            else
                            {
                                int Length = lastElement.LastIndexOf("+");
                                Strings.Left(lastElement, Length);
                                lastElement = Strings.Right(lastElement, checked(Strings.Len(lastElement) - Length - 1));
                            }
                        }
                        else if (lastElement.Contains("+REP"))
                        {
                            if (Operators.CompareString(Strings.Right(lastElement, 4), "+REP", false) == 0)
                            {
                                int Length = lastElement.LastIndexOf("+REP");
                                lastElement = Strings.Left(lastElement, Length);
                            }
                            else
                            {
                                int Length = lastElement.LastIndexOf("+");
                                Strings.Left(lastElement, Length);
                                lastElement = Strings.Right(lastElement, checked(Strings.Len(lastElement) - Length - 1));
                            }
                        }


                        if (!this.TstJump(lastElement)) // to check that it is valid jump or not
                        {
                            Interaction.Beep();
                        }
                        else if (elemLength > 1 && element.Substring(elemLength - 2, 2).Equals(" q")) // check last 2 chars are ' q' or not
                        {
                            int Length = element.LastIndexOf(" q"); // for removing ' q' from last
                            element = Strings.Left(element, Length);

                            if (!element.Contains(" q"))
                            {
                                Program.OpArr[checked(index + 1)].edge = Program.OpArr[checked(index + 1)].edge.Replace("q", "");
                            }
                        }
                        else
                        {
                            element += " q";
                            if (!Program.OpArr[checked(this.index + 1)].edge.Contains("q"))
                            {
                                Program.OpArr[checked(index + 1)].edge += "q";
                            }
                        }

                        Program.OpArr[checked(index + 1)].element = element;

                        DataGridView1.Rows[index].Cells[2].Value = (object)Program.OpArr[checked(index + 1)].edge;
                        OpLista(index, element);
                        goto label_25;
                    }
                    else
                        goto label_25;
                }
                else
                {
                    this.OplistaSelect();
                    goto label_25;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("OpQ_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_25:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Edge_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string str1 = "";
                string str2 = "";
                bool flag = false;
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                if (this.index > -1 & Strings.Len(Program.OpArr[checked(this.index + 1)].element) > 0 & Operators.CompareString(Strings.Right(Program.OpArr[checked(this.index + 1)].element, 1), "*", false) != 0)
                {
                    string str3 = Program.OpArr[checked(this.index + 1)].element;
                    if (str3.Contains("+SEQ"))
                    {
                        if (Operators.CompareString(Strings.Right(str3, 4), "+SEQ", false) == 0)
                        {
                            str2 = "+SEQ";
                            str3 = Strings.Left(str3, checked(Strings.Len(str3) - 4));
                            if (str3.Contains("*"))
                            {
                                str2 = "*+SEQ";
                                str3 = Strings.Replace(str3, "*", "");
                            }
                        }
                        else
                        {
                            int Length = str3.LastIndexOf("+");
                            str2 = Strings.Left(str3, Length);
                            str3 = Strings.Right(str3, checked(Strings.Len(str3) - Length - 1));
                            flag = true;
                        }
                    }
                    else if (str3.Contains("+COMBO"))
                    {
                        if (Operators.CompareString(Strings.Right(str3, 6), "+COMBO", false) == 0)
                        {
                            str2 = "+COMBO";
                            str3 = Strings.Left(str3, checked(Strings.Len(str3) - 6));
                            if (str3.Contains("*"))
                            {
                                str2 = "*+COMBO";
                                str3 = Strings.Replace(str3, "*", "");
                            }
                        }
                        else
                        {
                            int Length = str3.LastIndexOf("+");
                            str2 = Strings.Left(str3, Length);
                            str3 = Strings.Right(str3, checked(Strings.Len(str3) - Length - 1));
                            flag = true;
                        }
                    }
                    else if (str3.Contains("+REP"))
                    {
                        if (Operators.CompareString(Strings.Right(str3, 4), "+REP", false) == 0)
                        {
                            str2 = "+REP";
                            str3 = Strings.Left(str3, checked(Strings.Len(str3) - 4));
                            if (str3.Contains("*"))
                            {
                                str2 = "*+REP";
                                str3 = Strings.Replace(str3, "*", "");
                            }
                        }
                        else
                        {
                            int Length = str3.LastIndexOf("+");
                            str2 = Strings.Left(str3, Length);
                            str3 = Strings.Right(str3, checked(Strings.Len(str3) - Length - 1));
                            flag = true;
                        }
                    }
                    if (!this.TstJump(str3) | Program.OpArr[checked(this.index + 1)].edge.Contains("!") | !this.Tst_Lz_or_F(str3))
                    {
                        Interaction.Beep();
                        if (Operators.CompareString(Program.OpArr[checked(this.index + 1)].edge, "!", false) == 0)
                        {
                            int num3 = (int)Interaction.MsgBox((object)"Please remove the ! sign!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        }
                        this.OplistaSelect();
                        goto label_43;
                    }
                    else
                    {
                        if (str3.Contains("+"))
                        {
                            int Eno = 0;
                            Program.FindJumpEl1(str3, ref Eno);
                            int num4 = checked(Eno - 1);
                            int index1 = 1;
                            while (index1 <= num4)
                            {
                                if (this.Tst_Lz_F(Program.ElArr[index1].Elstr))
                                {
                                    if (Operators.CompareString(Strings.Right(Program.ElArr[index1].Elstr, 1), nameof(e), false) != 0)
                                    {
                                        Program.ElArr[index1].Elstr = Program.ElArr[index1].Elstr + " e";
                                    }
                                    else
                                    {
                                        Program.ElArr[index1].Elstr = Strings.Trim(Program.ElArr[index1].Elstr.Remove(checked(Program.ElArr[index1].Elstr.Length - 1)));
                                    }
                                }
                                checked { ++index1; }
                            }
                            Program.OpArr[checked(this.index + 1)].edge = Program.OpArr[checked(this.index + 1)].edge.Replace("e", "");
                            int num5 = checked(Eno - 1);
                            int index2 = 1;
                            while (index2 <= num5)
                            {
                                if (Program.ElArr[index2].Elstr.Contains("e") && !Program.OpArr[checked(this.index + 1)].edge.Contains("e"))
                                    Program.OpArr[checked(this.index + 1)].edge += "e";
                                str1 = index2 >= checked(Eno - 1) ? str1 + Program.ElArr[index2].Elstr : str1 + Program.ElArr[index2].Elstr + "+";
                                checked { ++index2; }
                            }
                            Program.OpArr[checked(this.index + 1)].element = flag ? str2 + "+" + str1 : str1 + str2;
                        }
                        else if (Operators.CompareString(Strings.Right(str3, 1), "e", false) == 0)
                        {
                            Program.OpArr[checked(this.index + 1)].element = flag ? str2 + "+" + Strings.Trim(Strings.Left(str3, checked(Strings.Len(str3) - 1))) : Strings.Trim(Strings.Left(str3, checked(Strings.Len(str3) - 1))) + str2;
                            Program.OpArr[checked(this.index + 1)].edge = Program.OpArr[checked(this.index + 1)].edge.Replace("e", "");
                        }
                        else
                        {
                            Program.OpArr[checked(this.index + 1)].element = flag ? str2 + "+" + str3 + " e" : str3 + " e" + str2;
                            Program.OpArr[checked(this.index + 1)].edge += "e";
                        }
                        //Program.OpArr[checked(this.index + 1)].edge = string.Join("", Program.OpArr[checked(this.index + 1)].edge?.ToCharArray().Distinct());
                        this.DataGridView1.Rows[this.index].Cells[2].Value = (object)Program.OpArr[checked(this.index + 1)].edge;
                        this.OpLista(this.index, Program.OpArr[checked(this.index + 1)].element);
                        goto label_43;
                    }
                }
                else
                {
                    this.OplistaSelect();
                    goto label_43;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num6 = (int)Interaction.MsgBox((object)("Edge_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_43:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                string element = Program.OpArr[checked(this.index + 1)].element;
                if (this.index > -1)
                {
                    if (Strings.Len(element) > 0 & Operators.CompareString(Strings.Right(element, 3), "SEQ", false) != 0 & Operators.CompareString(Strings.Right(element, 5), "COMBO", false) != 0 & Operators.CompareString(Strings.Right(element, 3), "REP", false) != 0)
                    {
                        if (Operators.CompareString(Strings.Right(element, 1), "*", false) != 0)
                        {
                            Program.OpArr[checked(this.index + 1)].element = element + "*";
                        }
                        else
                        {
                            int num3 = Strings.Len(element);
                            Program.OpArr[checked(this.index + 1)].element = Strings.Left(element, checked(num3 - 1));
                        }
                    }
                    else
                        Interaction.Beep();
                    this.OpLista(this.index, Program.OpArr[checked(this.index + 1)].element);
                    goto label_14;
                }
                else
                {
                    this.OplistaSelect();
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
                int num4 = (int)Interaction.MsgBox((object)("Zero_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_14:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void HalfTime_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                string segment = Program.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                    Program.Vek[Program.PNo].HTIndSeg1 = checked(this.index + 1);
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    Program.Vek[Program.PNo].HTIndSeg2 = checked(this.index + 1);
                this.HalfTime.BackColor = Color.FromArgb(236, 233, 216);
                this.OpMsg.Text = "After half time!";
                this.OplistaSelect();
                goto label_11;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("HalfTime_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_11:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void StartHT_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                this.Timer1.Enabled = true;
                num3 = 3;
                this.StartHT.BackColor = Color.FromArgb(17, (int)byte.MaxValue, 5);
                num3 = 4;
                this.StopHT.BackColor = Color.FromArgb(236, 233, 216);
                num3 = 5;
                this.Time.Text = "Running";
                num3 = 6;
                this.OplistaSelect();
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void StopHT_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                if (this.Timer1.Enabled)
                {
                    num3 = 3;
                    this.Timer1.Enabled = false;
                    num3 = 4;
                    this.StopHT.BackColor = Color.FromArgb(17, (int)byte.MaxValue, 5);
                    num3 = 5;
                    this.StartHT.BackColor = Color.FromArgb(236, 233, 216);
                    num3 = 6;
                    string str1 = Strings.LTrim(Conversion.Str((object)Conversion.Int((double)this.Tid / 60.0)));
                    num3 = 7;
                    string str2 = Strings.LTrim(Conversion.Str((object)((double)this.Tid - Conversion.Int((double)this.Tid / 60.0) * 60.0)));
                    num3 = 8;
                    this.Time.Text = str1 + " m " + str2 + " s";
                }
                else
                {
                    num3 = 10;
                    num3 = 11;
                    int num4 = (int)Interaction.MsgBox((object)"The Timer is not started!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
                num3 = 13;
                this.OplistaSelect();
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Bonus_Click(object sender, EventArgs e) => this.OplistaSelect();

        private void Bonus_plus_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                string segment = Program.Segment;
                num3 = 5;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    num3 = 6;
                    if (Program.Vek[Program.PNo].Bonus_Seg1 < 9)
                    {
                        num3 = 7;
                        checked { ++Program.Vek[Program.PNo].Bonus_Seg1; }
                        num3 = 8;
                        this.Bonus.Text = "BONUS " + Conversions.ToString(Program.Vek[Program.PNo].Bonus_Seg1);
                    }
                    else
                    {
                        num3 = 10;
                        num3 = 11;
                        int num4 = (int)Interaction.MsgBox((object)($"Max no. of Bonus = {Conversions.ToString(9)} !"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    }
                }
                else
                {
                    num3 = 14;
                    if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        num3 = 15;
                        if (Program.Vek[Program.PNo].Bonus_Seg2 < 9)
                        {
                            num3 = 16;
                            checked { ++Program.Vek[Program.PNo].Bonus_Seg2; }
                            num3 = 17;
                            this.Bonus.Text = "BONUS " + Conversions.ToString(Program.Vek[Program.PNo].Bonus_Seg2);
                        }
                        else
                        {
                            num3 = 19;
                            num3 = 20;
                            int num5 = (int)Interaction.MsgBox((object)($"Max no. of Bonus = {Conversions.ToString(9)} !"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        }
                    }
                }
                num3 = 23;
                this.OplistaSelect();
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Bonus_minus_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                string segment = Program.Segment;
                num3 = 5;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    num3 = 6;
                    int bonusSeg1 = Program.Vek[Program.PNo].Bonus_Seg1;
                    num3 = 9;
                    if (bonusSeg1 == 0)
                    {
                        num3 = 10;
                        this.Bonus.Text = "BONUS  0";
                    }
                    else
                    {
                        num3 = 12;
                        if (bonusSeg1 > 0)
                        {
                            num3 = 13;
                            checked { --Program.Vek[Program.PNo].Bonus_Seg1; }
                            num3 = 14;
                            if (Program.Vek[Program.PNo].Bonus_Seg1 == 0)
                            {
                                num3 = 15;
                                this.Bonus.Text = "BONUS  0";
                            }
                            else
                            {
                                num3 = 17;
                                num3 = 18;
                                this.Bonus.Text = "BONUS " + Conversions.ToString(Program.Vek[Program.PNo].Bonus_Seg1);
                            }
                        }
                    }
                }
                else
                {
                    num3 = 24;
                    if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        num3 = 25;
                        int bonusSeg2 = Program.Vek[Program.PNo].Bonus_Seg2;
                        num3 = 28;
                        if (bonusSeg2 == 0)
                        {
                            num3 = 29;
                            this.Bonus.Text = "BONUS  0";
                        }
                        else
                        {
                            num3 = 31;
                            if (bonusSeg2 > 0)
                            {
                                num3 = 32;
                                checked { --Program.Vek[Program.PNo].Bonus_Seg2; }
                                num3 = 33;
                                if (Program.Vek[Program.PNo].Bonus_Seg2 == 0)
                                {
                                    num3 = 34;
                                    this.Bonus.Text = "BONUS  0";
                                }
                                else
                                {
                                    num3 = 36;
                                    num3 = 37;
                                    this.Bonus.Text = "BONUS " + Conversions.ToString(Program.Vek[Program.PNo].Bonus_Seg2);
                                }
                            }
                        }
                    }
                }
                num3 = 43;
                this.OplistaSelect();
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
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
                checked { ++this.Tid; }
                if (this.Tid >= this.ProgramHalfTime)
                    this.HalfTime.BackColor = Color.Red;
                if (this.Tid > 3600)
                {
                    this.Timer1.Enabled = false;
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
                int num3 = (int)Interaction.MsgBox((object)("Timer1_Tick - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_10:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public int CalcHalfTime(string tid)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (Strings.Len(tid) > 1)
                {
                    num2 = 0;
                    int integer = Conversions.ToInteger(Strings.Right(tid, 2));
                    num2 = checked((int)Math.Round(unchecked((double)checked(60 * Conversions.ToInteger(tid.Substring(3, 2)) + integer) / 2.0)));
                    goto label_8;
                }
                else
                {
                    num2 = 0;
                    goto label_8;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num3 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("CalcHalfTime - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_8:
            int num5 = num2;
            if (num3 == 0)
                return num5;
            ProjectData.ClearProjectError();
            return num5;
        }

        private void Falls_out_Click(object sender, EventArgs e) => this.OplistaSelect();

        private void Falls_Click(object sender, EventArgs e)
        {
            IncrementFalls();
        }

        private void IncrementFalls()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int num3 = this.NoFalls();
                if (num3 < 19)
                {
                    string segment = Program.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                        Program.Vek[Program.PNo].Falls_seg1 = checked(num3 + 1);
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                        Program.Vek[Program.PNo].Falls_seg2 = checked(num3 + 1);
                    this.Falls_out.Text = "FALLS  " + Conversions.ToString(checked(num3 + 1));
                }
                else
                {
                    int num4 = (int)Interaction.MsgBox((object)($"Max no. of Falls = {Conversions.ToString(19)} !"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
                this.OplistaSelect();
                goto label_14;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("Falls_Plus_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_14:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Falls_minus_Click(object sender, EventArgs e)
        {
            DecrementFalls();
        }

        private void DecrementFalls()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int num3 = this.NoFalls();
                if (num3 > 0)
                {
                    string segment = Program.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                        Program.Vek[Program.PNo].Falls_seg1 = checked(num3 - 1);
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                        Program.Vek[Program.PNo].Falls_seg2 = checked(num3 - 1);
                    this.Falls_out.Text = "FALLS  " + Conversions.ToString(checked(num3 - 1));
                }
                this.OplistaSelect();
                goto label_13;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("DecrementFalls - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_13:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public int NoFalls()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num4 = 2;
                string segment = Program.Segment;
                num4 = 5;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    num4 = 6;
                    num2 = Program.Vek[Program.PNo].Falls_seg1;
                }
                else
                {
                    num4 = 8;
                    if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        num4 = 9;
                        num2 = Program.Vek[Program.PNo].Falls_seg2;
                    }
                    else
                    {
                        num4 = 12;
                        num2 = 0;
                    }
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            int num5 = num2;
            if (num3 == 0)
                return num5;
            ProjectData.ClearProjectError();
            return num5;
        }

        private void OpExcl_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                if (this.index > -1)
                {
                    string str = Program.OpArr[checked(this.index + 1)].element;
                    if (Strings.Len(str) > 0)
                    {
                        if (str.Contains("+SEQ"))
                        {
                            if (Operators.CompareString(Strings.Right(str, 4), "+SEQ", false) == 0)
                            {
                                int Length = str.LastIndexOf("+SEQ");
                                str = Strings.Left(str, Length);
                            }
                            else
                            {
                                int Length = str.LastIndexOf("+");
                                Strings.Left(str, Length);
                                str = Strings.Right(str, checked(Strings.Len(str) - Length - 1));
                            }
                        }
                        else if (str.Contains("+COMBO"))
                        {
                            if (Operators.CompareString(Strings.Right(str, 6), "+COMBO", false) == 0)
                            {
                                int Length = str.LastIndexOf("+COMBO");
                                str = Strings.Left(str, Length);
                            }
                            else
                            {
                                int Length = str.LastIndexOf("+");
                                Strings.Left(str, Length);
                                str = Strings.Right(str, checked(Strings.Len(str) - Length - 1));
                            }
                        }
                        else if (str.Contains("+REP"))
                        {
                            if (Operators.CompareString(Strings.Right(str, 4), "+REP", false) == 0)
                            {
                                int Length = str.LastIndexOf("+REP");
                                str = Strings.Left(str, Length);
                            }
                            else
                            {
                                int Length = str.LastIndexOf("+");
                                Strings.Left(str, Length);
                                str = Strings.Right(str, checked(Strings.Len(str) - Length - 1));
                            }
                        }
                        if (!this.TstJump(str) | !this.Tst_Lz_or_F(str) | Program.OpArr[checked(this.index + 1)].edge.Contains("e"))
                        {
                            Interaction.Beep();
                        }
                        else if (Program.OpArr[checked(this.index + 1)].edge.Contains("!"))
                        {
                            Program.OpArr[checked(this.index + 1)].edge = Program.OpArr[checked(this.index + 1)].edge?.Replace("!", "");
                            Program.OpArr[checked(this.index + 1)].element = Program.OpArr[checked(this.index + 1)].element?.Replace("!", "");
                        }
                        else
                        {
                            Program.OpArr[checked(this.index + 1)].edge += "!";
                            Program.OpArr[checked(this.index + 1)].element += "!";
                        }
                        this.DataGridView1.Rows[this.index].Cells[2].Value = (object)Program.OpArr[checked(this.index + 1)].edge;
                        this.OpLista(this.index, Program.OpArr[checked(this.index + 1)].element);
                        goto label_25;
                    }
                    else
                        goto label_25;
                }
                else
                {
                    this.OplistaSelect();
                    goto label_25;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("OpExcl_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_25:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void OpFallinElement_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                if (this.index > -1)
                {
                    string element = Program.OpArr[checked(index + 1)].element ?? "";
                    string lastElement = element;
                    int elemLength = Strings.Len(element);

                    if (Strings.Len(lastElement) > 0)
                    {
                        if (lastElement.Contains("+SEQ"))
                        {
                            if (Operators.CompareString(Strings.Right(lastElement, 4), "+SEQ", false) == 0)
                            {
                                int Length = lastElement.LastIndexOf("+SEQ");
                                lastElement = Strings.Left(lastElement, Length);
                            }
                            else
                            {
                                int Length = lastElement.LastIndexOf("+");
                                Strings.Left(lastElement, Length);
                                lastElement = Strings.Right(lastElement, checked(Strings.Len(lastElement) - Length - 1));
                            }
                        }
                        else if (lastElement.Contains("+COMBO"))
                        {
                            if (Operators.CompareString(Strings.Right(lastElement, 6), "+COMBO", false) == 0)
                            {
                                int Length = lastElement.LastIndexOf("+COMBO");
                                lastElement = Strings.Left(lastElement, Length);
                            }
                            else
                            {
                                int Length = lastElement.LastIndexOf("+");
                                Strings.Left(lastElement, Length);
                                lastElement = Strings.Right(lastElement, checked(Strings.Len(lastElement) - Length - 1));
                            }
                        }
                        else if (lastElement.Contains("+REP"))
                        {
                            if (Operators.CompareString(Strings.Right(lastElement, 4), "+REP", false) == 0)
                            {
                                int Length = lastElement.LastIndexOf("+REP");
                                lastElement = Strings.Left(lastElement, Length);
                            }
                            else
                            {
                                int Length = lastElement.LastIndexOf("+");
                                Strings.Left(lastElement, Length);
                                lastElement = Strings.Right(lastElement, checked(Strings.Len(lastElement) - Length - 1));
                            }
                        }
                        if (!this.TstJump(lastElement)) // | !this.Tst_Lz_or_F(lastElement))
                        {
                            Interaction.Beep();
                        }
                        else if (elemLength > 0 && element.Substring(elemLength - 1, 1).Equals("f")) // check last char is 'f' or not
                        {
                            int Length = element.LastIndexOf("f"); // for removing 'f' from last
                            element = Strings.Left(element, Length);

                            if (!element.Contains("f"))
                            {
                                Program.OpArr[checked(index + 1)].edge = Program.OpArr[checked(index + 1)].edge.Replace("f", "");
                            }
                        }
                        else
                        {
                            element += "f";
                            if (!Program.OpArr[checked(this.index + 1)].edge.Contains("f"))
                            {
                                Program.OpArr[checked(index + 1)].edge += "f";
                            }
                        }

                        Program.OpArr[checked(index + 1)].element = element;

                        DataGridView1.Rows[index].Cells[2].Value = (object)Program.OpArr[checked(index + 1)].edge;
                        OpLista(index, element);
                        goto label_25;
                    }
                    else
                        goto label_25;
                }
                else
                {
                    this.OplistaSelect();
                    goto label_25;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("OpFallinElement_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_25:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public bool Spin_Change(string Elin)
        {
            string spin = Program.GetSpin(Elin);
            bool flag = true;
            if (Operators.CompareString(Strings.Left(spin, 5), "FCoSp", false) == 0)
                flag = false;
            else if (Operators.CompareString(Strings.Left(spin, 4), "CoSp", false) == 0)
            {
                flag = false;
            }
            else
            {
                string Left = Strings.Left(spin, 3);
                if (Operators.CompareString(Left, "SSp", false) == 0 || Operators.CompareString(Left, "USp", false) == 0 || Operators.CompareString(Left, "LSp", false) == 0 || Operators.CompareString(Left, "CSp", false) == 0)
                    flag = false;
            }
            return flag;
        }

        private bool FindJump(string ElIn)
        {
            int num1 = 0;
            bool flag = false;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                flag = false;
                string str1 = ElIn;
                if (str1.Contains("+"))
                    str1 = Strings.Left(str1, str1.LastIndexOf("+"));
                if (Strings.Len(str1) <= 7)
                {
                    string str2 = Operators.CompareString(Strings.Right(str1, 1), "e", false) != 0 ? str1 : Strings.Trim(str1.Remove(checked(str1.Length - 1)));
                    if (Operators.CompareString(Strings.Right(str2, 2), "<<", false) == 0)
                        str2 = Strings.Trim(str2.Remove(checked(str2.Length - 2)));
                    else if (Operators.CompareString(Strings.Right(str2, 1), "<", false) == 0)
                        str2 = Strings.Trim(str2.Remove(checked(str2.Length - 1)));
                    int jumpmin = Program.Jumpmin;
                    int jumpMax = Program.JumpMax;
                    int index = jumpmin;
                    while (index <= jumpMax)
                    {
                        if (Operators.ConditionalCompareObjectEqual((object)str2, Program.ElDB[index, 0], false))
                        {
                            flag = true;
                            break;
                        }
                        checked { ++index; }
                    }
                    goto label_17;
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
                int num3 = (int)Interaction.MsgBox((object)("FindJump - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_17:
            int num4 = flag ? 1 : 0;
            if (num2 == 0)
                return num4 != 0;
            ProjectData.ClearProjectError();
            return num4 != 0;
        }

        public bool FindSpin(string El)
        {
            int num1 = 0;
            bool flag = false;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                flag = false;
                if (Strings.Len(El) > 2)
                {
                    string spin = Program.GetSpin(El);
                    int spinMin = Program.SpinMin;
                    int spinmax = Program.Spinmax;
                    int index = spinMin;
                    while (index <= spinmax)
                    {
                        if (Operators.ConditionalCompareObjectEqual(Program.ElDB[index, 0], (object)spin, false))
                        {
                            flag = true;
                            break;
                        }
                        checked { ++index; }
                    }
                    goto label_11;
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
                int num3 = (int)Interaction.MsgBox((object)("FindSpin - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_11:
            int num4 = flag ? 1 : 0;
            if (num2 == 0)
                return num4 != 0;
            ProjectData.ClearProjectError();
            return num4 != 0;
        }

        private void opREP_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                bool flag = false;
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                if (this.index > -1)
                {
                    string str = Program.OpArr[checked(this.index + 1)].element;
                    if (str.Contains("REP"))
                    {
                        flag = true;
                        int num3 = Strings.InStr(1, str, "+REP", CompareMethod.Text);
                        if (num3 > 1)
                            str = Strings.Left(str, checked(num3 - 1));
                    }
                    Program.OpArr[checked(this.index + 1)].element = !flag ? str + "+REP" : str;
                    this.OpLista(this.index, Program.OpArr[checked(this.index + 1)].element);
                    goto label_12;
                }
                else
                {
                    this.OplistaSelect();
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
                int num4 = (int)Interaction.MsgBox((object)("opREP_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_12:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void Spin_V_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.index = this.DataGridView1.CurrentCellAddress.Y;
                if (this.index > -1)
                {
                    string element = Program.OpArr[checked(this.index + 1)].element;
                    if (Strings.Len(element) < 2 | !this.Sp_V(element))
                    {
                        Interaction.Beep();
                        int num3 = (int)Interaction.MsgBox((object)"Not possible for this element!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    }
                    else if (Operators.CompareString(Strings.Right(element, 1), "*", false) == 0)
                    {
                        Interaction.Beep();
                        goto label_18;
                    }
                    else if (this.Sp_V(element))
                    {
                        if (element.Contains("V"))
                        {
                            int num4 = Strings.Len(Program.OpArr[checked(this.index + 1)].element);
                            this.Spin_V.BackColor = Color.FromArgb(128, (int)byte.MaxValue, (int)byte.MaxValue);
                            Program.OpArr[checked(this.index + 1)].element = Strings.Trim(Strings.Left(element, checked(num4 - 1)));
                        }
                        else
                        {
                            this.Spin_V.BackColor = Color.FromArgb((int)byte.MaxValue, 0, 0);
                            // ISSUE: explicit reference operation
                            Program.OpArr[checked(this.index + 1)].element += "V";
                        }
                        this.OpLista(this.index, Program.OpArr[checked(this.index + 1)].element);
                    }
                    else
                    {
                        int num5 = (int)Interaction.MsgBox((object)"Not possible for this spin element!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    }
                }
                this.OplistaSelect();
                goto label_18;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num6 = (int)Interaction.MsgBox((object)("Spin_V1_Click - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_18:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public bool Sp_Change(string Elin)
        {
            string Left = Strings.Left(Program.GetSpin(Elin), 4);
            return Operators.CompareString(Left, "CSSp", false) == 0 || Operators.CompareString(Left, "CLSp", false) == 0 || Operators.CompareString(Left, "CUSp", false) == 0 || Operators.CompareString(Left, "CCSp", false) == 0 || Operators.CompareString(Left, "CCoS", false) == 0;
        }

        public bool Sp_V(string Elin)
        {
            string spin = Program.GetSpin(Elin);
            bool flag = false;
            string Left1 = Strings.Left(spin, 4);
            if (Operators.CompareString(Left1, "FUSp", false) == 0 || Operators.CompareString(Left1, "FLSp", false) == 0 || Operators.CompareString(Left1, "FCSp", false) == 0 || Operators.CompareString(Left1, "FSSp", false) == 0 || Operators.CompareString(Left1, "CoSp", false) == 0 || Operators.CompareString(Left1, "CSSp", false) == 0 || Operators.CompareString(Left1, "CCSp", false) == 0 || Operators.CompareString(Left1, "CUSp", false) == 0 || Operators.CompareString(Left1, "CLSp", false) == 0)
            {
                flag = true;
            }
            else
            {
                string Left2 = Strings.Left(spin, 5);
                if (Operators.CompareString(Left2, "FCUSp", false) == 0 || Operators.CompareString(Left2, "FCLSp", false) == 0 || Operators.CompareString(Left2, "FCCSp", false) == 0 || Operators.CompareString(Left2, "FCSSp", false) == 0 || Operators.CompareString(Left2, "FCoSp", false) == 0 || Operators.CompareString(Left2, "CCoSp", false) == 0)
                    flag = true;
                else if (Operators.CompareString(Strings.Left(spin, 6), "FCCoSp", false) == 0)
                    flag = true;
            }
            return flag;
        }

        public bool Sp_Flying(string Elin) => Operators.CompareString(Strings.Left(Program.GetSpin(Elin), 1), "F", false) == 0;

        private void btnDED_Click(object sender, EventArgs e)
        {
            if (Program.IsFormOpen((Form)MyProject.Forms.DeductionsDialog))
                MyProject.Forms.DeductionsDialog.Close();
            DeductionsDialog dialog11 = MyProject.Forms.DeductionsDialog;
            dialog11.TopMost = true;
            int num = (int)dialog11.ShowDialog((IWin32Window)this);
        }
    }
}

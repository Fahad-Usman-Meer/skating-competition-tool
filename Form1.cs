// Decompiled with JetBrains decompiler
// Type: ClubCompFS.Form1
// Assembly: ClubCompFS_10p0p6, Version=1.0.0.6, Culture=neutral, PublicKeyToken=null
// MVID: F1E583B2-A781-4EC4-B47C-BA3F451903AE
// Assembly location: E:\zz Personal_Doc\Personal\Cinzia\programmaLibertas_openNEW\ClubCompFS_10p0p6.exe

using ClubCompFS.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace ClubCompFS
{
    [DesignerGenerated]
    public class Form1 : Form
    {
        private IContainer components;
        [AccessedThroughProperty("MenuStrip1")]
        private MenuStrip _MenuStrip1;
        [AccessedThroughProperty("ToolStripMenuItem1")]
        private ToolStripMenuItem _ToolStripMenuItem1;
        [AccessedThroughProperty("LoadCategoryToolStripMenuItem")]
        private ToolStripMenuItem _LoadCategoryToolStripMenuItem;
        [AccessedThroughProperty("SaveCategoryToolStripMenuItem")]
        private ToolStripMenuItem _SaveCategoryToolStripMenuItem;
        [AccessedThroughProperty("ClearDataToolStripMenuItem")]
        private ToolStripMenuItem _ClearDataToolStripMenuItem;
        [AccessedThroughProperty("ModeSelectionToolStripMenuItem")]
        private ToolStripMenuItem _ModeSelectionToolStripMenuItem;
        [AccessedThroughProperty("RunWithNetwotkToolStripMenuItem")]
        private ToolStripMenuItem _RunWithNetwotkToolStripMenuItem;
        [AccessedThroughProperty("PrepareModeToolStripMenuItem")]
        private ToolStripMenuItem _PrepareModeToolStripMenuItem;
        [AccessedThroughProperty("ManualInputToolStripMenuItem")]
        private ToolStripMenuItem _ManualInputToolStripMenuItem;
        [AccessedThroughProperty("CompetitionToolStripMenuItem")]
        private ToolStripMenuItem _CompetitionToolStripMenuItem;
        [AccessedThroughProperty("SetupToolStripMenuItem")]
        private ToolStripMenuItem _SetupToolStripMenuItem;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;
        [AccessedThroughProperty("Label2")]
        private Label _Label2;
        [AccessedThroughProperty("lblDate")]
        private Label _lblDate;
        [AccessedThroughProperty("Label4")]
        private Label _Label4;
        [AccessedThroughProperty("Label5")]
        private Label _Label5;
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
        [AccessedThroughProperty("Label13")]
        private Label _Label13;
        [AccessedThroughProperty("Label14")]
        private Label _Label14;
        [AccessedThroughProperty("ControllerName")]
        private TextBox _ControllerName;
        [AccessedThroughProperty("ControllerClub")]
        private TextBox _ControllerClub;
        [AccessedThroughProperty("lblJ1")]
        private Label _lblJ1;
        [AccessedThroughProperty("lblJ2")]
        private Label _lblJ2;
        [AccessedThroughProperty("lblJ3")]
        private Label _lblJ3;
        [AccessedThroughProperty("lblJ4")]
        private Label _lblJ4;
        [AccessedThroughProperty("lblJ5")]
        private Label _lblJ5;
        [AccessedThroughProperty("lblJ6")]
        private Label _lblJ6;
        [AccessedThroughProperty("lblJ7")]
        private Label _lblJ7;
        [AccessedThroughProperty("JudgeName1")]
        private TextBox _JudgeName1;
        [AccessedThroughProperty("JudgeName2")]
        private TextBox _JudgeName2;
        [AccessedThroughProperty("JudgeName3")]
        private TextBox _JudgeName3;
        [AccessedThroughProperty("JudgeName4")]
        private TextBox _JudgeName4;
        [AccessedThroughProperty("JudgeName5")]
        private TextBox _JudgeName5;
        [AccessedThroughProperty("JudgeName6")]
        private TextBox _JudgeName6;
        [AccessedThroughProperty("JudgeName7")]
        private TextBox _JudgeName7;
        [AccessedThroughProperty("JudgeClub1")]
        private TextBox _JudgeClub1;
        [AccessedThroughProperty("JudgeClub2")]
        private TextBox _JudgeClub2;
        [AccessedThroughProperty("JudgeClub3")]
        private TextBox _JudgeClub3;
        [AccessedThroughProperty("JudgeClub4")]
        private TextBox _JudgeClub4;
        [AccessedThroughProperty("JudgeClub5")]
        private TextBox _JudgeClub5;
        [AccessedThroughProperty("JudgeClub6")]
        private TextBox _JudgeClub6;
        [AccessedThroughProperty("JudgeClub7")]
        private TextBox _JudgeClub7;
        [AccessedThroughProperty("TechSpecName")]
        private TextBox _TechSpecName;
        [AccessedThroughProperty("RefereeName")]
        private TextBox _RefereeName;
        [AccessedThroughProperty("DVOName1")]
        private TextBox _DVOName1;
        [AccessedThroughProperty("DVOName2")]
        private TextBox _DVOName2;
        [AccessedThroughProperty("DVOName3")]
        private TextBox _DVOName3;
        [AccessedThroughProperty("txtCompetitionName")]
        private TextBox _txtCompetitionName;
        [AccessedThroughProperty("txtCategory")]
        private TextBox _txtCategory;
        [AccessedThroughProperty("txtDate")]
        private TextBox _txtDate;
        [AccessedThroughProperty("txtStartTime")]
        private TextBox _txtStartTime;
        [AccessedThroughProperty("txtNoOfJudges")]
        private TextBox _txtNoOfJudges;
        [AccessedThroughProperty("txtNoOfTrJ")]
        private TextBox _txtNoOfTrJ;
        [AccessedThroughProperty("Label22")]
        private Label _Label22;
        [AccessedThroughProperty("Label23")]
        private Label _Label23;
        [AccessedThroughProperty("Label24")]
        private Label _Label24;
        [AccessedThroughProperty("Label26")]
        private Label _Label26;
        [AccessedThroughProperty("Label27")]
        private Label _Label27;
        [AccessedThroughProperty("TechSpecClub")]
        private TextBox _TechSpecClub;
        [AccessedThroughProperty("RefereeClub")]
        private TextBox _RefereeClub;
        [AccessedThroughProperty("DVOClub1")]
        private TextBox _DVOClub1;
        [AccessedThroughProperty("DVOClub2")]
        private TextBox _DVOClub2;
        [AccessedThroughProperty("DVOClub3")]
        private TextBox _DVOClub3;
        [AccessedThroughProperty("lblStart")]
        private Label _lblStart;
        [AccessedThroughProperty("txtSubcategory")]
        private TextBox _txtSubcategory;
        [AccessedThroughProperty("txtSegment")]
        private TextBox _txtSegment;
        [AccessedThroughProperty("Label29")]
        private Label _Label29;
        [AccessedThroughProperty("Mode")]
        private TextBox _Mode;
        [AccessedThroughProperty("OpenDBToolStripMenuItem")]
        private ToolStripMenuItem _OpenDBToolStripMenuItem;
        [AccessedThroughProperty("DBToolStripMenuItem")]
        private ToolStripMenuItem _DBToolStripMenuItem;
        [AccessedThroughProperty("NetworkToolStripMenuItem")]
        private ToolStripMenuItem _NetworkToolStripMenuItem;
        [AccessedThroughProperty("OpenFileDialog1")]
        private OpenFileDialog _OpenFileDialog1;
        [AccessedThroughProperty("txtNonJudgingReferee")]
        private TextBox _txtNonJudgingReferee;
        [AccessedThroughProperty("CategorySelectionToolStripMenuItem")]
        private ToolStripMenuItem _CategorySelectionToolStripMenuItem;
        [AccessedThroughProperty("JudgesSetupToolStripMenuItem")]
        private ToolStripMenuItem _JudgesSetupToolStripMenuItem;
        [AccessedThroughProperty("PRINTToolStripMenuItem")]
        private ToolStripMenuItem _PRINTToolStripMenuItem;
        [AccessedThroughProperty("HeadPageToolStripMenuItem")]
        private ToolStripMenuItem _HeadPageToolStripMenuItem;
        [AccessedThroughProperty("HeadPageToolStripMenuItem1")]
        private ToolStripMenuItem _HeadPageToolStripMenuItem1;
        [AccessedThroughProperty("StartListToolStripMenuItem1")]
        private ToolStripMenuItem _StartListToolStripMenuItem1;
        [AccessedThroughProperty("JudgesDetailsToolStripMenuItem")]
        private ToolStripMenuItem _JudgesDetailsToolStripMenuItem;
        [AccessedThroughProperty("ExitToolStripMenuItem1")]
        private ToolStripMenuItem _ExitToolStripMenuItem1;
        [AccessedThroughProperty("TCTSCardToolStripMenuItem")]
        private ToolStripMenuItem _TCTSCardToolStripMenuItem;
        [AccessedThroughProperty("TCSCardForBothTCAndTCToolStripMenuItem")]
        private ToolStripMenuItem _TCSCardForBothTCAndTCToolStripMenuItem;
        [AccessedThroughProperty("TCTSCardForASelectedSkaterToolStripMenuItem")]
        private ToolStripMenuItem _TCTSCardForASelectedSkaterToolStripMenuItem;
        [AccessedThroughProperty("JudgeCardsFörOneJudgeToolStripMenuItem")]
        private ToolStripMenuItem _JudgeCardsFörOneJudgeToolStripMenuItem;
        [AccessedThroughProperty("JudgeCardForAllSkatersToolStripMenuItem")]
        private ToolStripMenuItem _JudgeCardForAllSkatersToolStripMenuItem;
        [AccessedThroughProperty("JusgeCardsForASelectedSkaterToolStripMenuItem")]
        private ToolStripMenuItem _JusgeCardsForASelectedSkaterToolStripMenuItem;
        [AccessedThroughProperty("JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem")]
        private ToolStripMenuItem _JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem;
        [AccessedThroughProperty("PrintAllResultDocumentsCategoryToolStripMenuItem")]
        private ToolStripMenuItem _PrintAllResultDocumentsCategoryToolStripMenuItem;
        [AccessedThroughProperty("ResultsToolStripMenuItem")]
        private ToolStripMenuItem _ResultsToolStripMenuItem;
        [AccessedThroughProperty("CREATEFILESToolStripMenuItem")]
        private ToolStripMenuItem _CREATEFILESToolStripMenuItem;
        [AccessedThroughProperty("ResultsPDFfilesToolStripMenuItem")]
        private ToolStripMenuItem _ResultsPDFfilesToolStripMenuItem;
        [AccessedThroughProperty("HeadPageToolStripMenuItem2")]
        private ToolStripMenuItem _HeadPageToolStripMenuItem2;
        [AccessedThroughProperty("JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem")]
        private ToolStripMenuItem _JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem;
        [AccessedThroughProperty("AllFilesToolStripMenuItem")]
        private ToolStripMenuItem _AllFilesToolStripMenuItem;
        [AccessedThroughProperty("btnSeg1")]
        private Button _btnSeg1;
        [AccessedThroughProperty("btnSeg2")]
        private Button _btnSeg2;
        [AccessedThroughProperty("SHOWRESULTSToolStripMenuItem")]
        private ToolStripMenuItem _SHOWRESULTSToolStripMenuItem;
        [AccessedThroughProperty("Label30")]
        private Label _Label30;
        [AccessedThroughProperty("txtParticipants")]
        private TextBox _txtParticipants;
        [AccessedThroughProperty("PingTheNetworkToolStripMenuItem")]
        private ToolStripMenuItem _PingTheNetworkToolStripMenuItem;
        [AccessedThroughProperty("Label31")]
        private Label _Label31;
        [AccessedThroughProperty("EntriesToolStripMenuItem")]
        private ToolStripMenuItem _EntriesToolStripMenuItem;
        [AccessedThroughProperty("SaveToolStripMenuItem")]
        private ToolStripMenuItem _SaveToolStripMenuItem;
        [AccessedThroughProperty("Timer2")]
        private System.Windows.Forms.Timer _Timer2;
        [AccessedThroughProperty("lblCC_El")]
        private Label _lblCC_El;
        [AccessedThroughProperty("ToolStripSeparator1")]
        private ToolStripSeparator _ToolStripSeparator1;
        [AccessedThroughProperty("ToolStripSeparator2")]
        private ToolStripSeparator _ToolStripSeparator2;
        [AccessedThroughProperty("ToolStripSeparator3")]
        private ToolStripSeparator _ToolStripSeparator3;
        [AccessedThroughProperty("ToolStripSeparator4")]
        private ToolStripSeparator _ToolStripSeparator4;
        [AccessedThroughProperty("ToolStripSeparator5")]
        private ToolStripSeparator _ToolStripSeparator5;
        [AccessedThroughProperty("ToolStripSeparator6")]
        private ToolStripSeparator _ToolStripSeparator6;
        [AccessedThroughProperty("PictureBox1")]
        private PictureBox _PictureBox1;
        [AccessedThroughProperty("BackgroundWorker2")]
        private BackgroundWorker _BackgroundWorker2;
        [AccessedThroughProperty("ToolStripSeparator7")]
        private ToolStripSeparator _ToolStripSeparator7;
        [AccessedThroughProperty("WarmupGroupsToolStripMenuItem")]
        private ToolStripMenuItem _WarmupGroupsToolStripMenuItem;
        [AccessedThroughProperty("BackgroundWorker5")]
        private BackgroundWorker _BackgroundWorker5;
        [AccessedThroughProperty("COPYOFFICIALSToolStripMenuItem")]
        private ToolStripMenuItem _COPYOFFICIALSToolStripMenuItem;
        [AccessedThroughProperty("lblSeg2")]
        private Label _lblSeg2;
        [AccessedThroughProperty("lblSeg1")]
        private Label _lblSeg1;
        [AccessedThroughProperty("EntriesToolStripMenuItem1")]
        private ToolStripMenuItem _EntriesToolStripMenuItem1;
        [AccessedThroughProperty("StartListToolStripMenuItem")]
        private ToolStripMenuItem _StartListToolStripMenuItem;
        [AccessedThroughProperty("CREATEPDFFILESToolStripMenuItem")]
        private ToolStripMenuItem _CREATEPDFFILESToolStripMenuItem;
        [AccessedThroughProperty("EntriesToolStripMenuItem2")]
        private ToolStripMenuItem _EntriesToolStripMenuItem2;
        [AccessedThroughProperty("StartListToolStripMenuItem2")]
        private ToolStripMenuItem _StartListToolStripMenuItem2;
        [AccessedThroughProperty("ToolStripSeparator8")]
        private ToolStripSeparator _ToolStripSeparator8;
        [AccessedThroughProperty("UnhudeJudgesDisplayToolStripMenuItem")]
        private ToolStripMenuItem _UnhudeJudgesDisplayToolStripMenuItem;
        [AccessedThroughProperty("HideJudgesComputersToolStripMenuItem")]
        private ToolStripMenuItem _HideJudgesComputersToolStripMenuItem;
        [AccessedThroughProperty("ToolStripSeparator9")]
        private ToolStripSeparator _ToolStripSeparator9;
        [AccessedThroughProperty("Timer3")]
        private System.Windows.Forms.Timer _Timer3;
        [AccessedThroughProperty("Timer10")]
        private System.Windows.Forms.Timer _Timer10;
        [AccessedThroughProperty("BackgroundWorker10")]
        private BackgroundWorker _BackgroundWorker10;
        [AccessedThroughProperty("BackgroundWorker1")]
        private BackgroundWorker _BackgroundWorker1;
        [AccessedThroughProperty("BackgroundWorker3")]
        private BackgroundWorker _BackgroundWorker3;
        [AccessedThroughProperty("Timer1")]
        private System.Windows.Forms.Timer _Timer1;
        [AccessedThroughProperty("lblCC_Info")]
        private Label _lblCC_Info;
        [AccessedThroughProperty("JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem")]
        private ToolStripMenuItem _JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem;
        [AccessedThroughProperty("Label3")]
        private Label _Label3;
        [AccessedThroughProperty("txtCompetitionID")]
        private TextBox _txtCompetitionID;
        [AccessedThroughProperty("Label17")]
        private Label _Label17;
        [AccessedThroughProperty("txtCategoryID")]
        private TextBox _txtCategoryID;
        [AccessedThroughProperty("Label16")]
        private Label _Label16;
        [AccessedThroughProperty("Label15")]
        private Label _Label15;
        [AccessedThroughProperty("txtOrganizerID")]
        private TextBox _txtOrganizerID;
        [AccessedThroughProperty("txtOrganizerName")]
        private TextBox _txtOrganizerName;
        [AccessedThroughProperty("Label18")]
        private Label _Label18;
        [AccessedThroughProperty("Label19")]
        private Label _Label19;
        [AccessedThroughProperty("txtType")]
        private TextBox _txtType;
        [AccessedThroughProperty("lblCC_MP")]
        private Label _lblCC_MP;
        [AccessedThroughProperty("txtIndTADiscipline")]
        private TextBox _txtIndTADiscipline;
        [AccessedThroughProperty("txtIndTAClass")]
        private TextBox _txtIndTAClass;
        private bool completed1;
        private Queue<int> Qout;
        private Queue<int> Qprint;
        private int[] Msg;
        private bool completed3;
        private bool completed5;
        private ConnectionManager _Manager;
        public bool WillExit;
        private bool Loading;
        public bool completed10;

        public Form1()
        {
            this.KeyDown += new KeyEventHandler(this.Form1_KeyDown);
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new EventHandler(this.Form1_Load);
            this.completed1 = true;
            this.Qout = new Queue<int>();
            this.Qprint = new Queue<int>();
            this.Msg = new int[12];
            this.completed3 = true;
            this.completed5 = true;
            this._Manager = new ConnectionManager();
            this.WillExit = false;
            this.Loading = false;
            this.completed10 = true;
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
            this.MenuStrip1 = new MenuStrip();
            this.ToolStripMenuItem1 = new ToolStripMenuItem();
            this.LoadCategoryToolStripMenuItem = new ToolStripMenuItem();
            this.SaveToolStripMenuItem = new ToolStripMenuItem();
            this.SaveCategoryToolStripMenuItem = new ToolStripMenuItem();
            this.ClearDataToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator7 = new ToolStripSeparator();
            this.ExitToolStripMenuItem1 = new ToolStripMenuItem();
            this.ModeSelectionToolStripMenuItem = new ToolStripMenuItem();
            this.RunWithNetwotkToolStripMenuItem = new ToolStripMenuItem();
            this.PrepareModeToolStripMenuItem = new ToolStripMenuItem();
            this.ManualInputToolStripMenuItem = new ToolStripMenuItem();
            this.CompetitionToolStripMenuItem = new ToolStripMenuItem();
            this.PRINTToolStripMenuItem = new ToolStripMenuItem();
            this.JudgeCardForAllSkatersToolStripMenuItem = new ToolStripMenuItem();
            this.JudgeCardsFörOneJudgeToolStripMenuItem = new ToolStripMenuItem();
            this.JusgeCardsForASelectedSkaterToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator3 = new ToolStripSeparator();
            this.TCTSCardToolStripMenuItem = new ToolStripMenuItem();
            this.TCSCardForBothTCAndTCToolStripMenuItem = new ToolStripMenuItem();
            this.TCTSCardForASelectedSkaterToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator4 = new ToolStripSeparator();
            this.HeadPageToolStripMenuItem = new ToolStripMenuItem();
            this.EntriesToolStripMenuItem = new ToolStripMenuItem();
            this.StartListToolStripMenuItem1 = new ToolStripMenuItem();
            this.WarmupGroupsToolStripMenuItem = new ToolStripMenuItem();
            this.JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator5 = new ToolStripSeparator();
            this.ResultsToolStripMenuItem = new ToolStripMenuItem();
            this.JudgesDetailsToolStripMenuItem = new ToolStripMenuItem();
            this.JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator6 = new ToolStripSeparator();
            this.PrintAllResultDocumentsCategoryToolStripMenuItem = new ToolStripMenuItem();
            this.CREATEFILESToolStripMenuItem = new ToolStripMenuItem();
            this.EntriesToolStripMenuItem1 = new ToolStripMenuItem();
            this.StartListToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator9 = new ToolStripSeparator();
            this.HeadPageToolStripMenuItem2 = new ToolStripMenuItem();
            this.ResultsPDFfilesToolStripMenuItem = new ToolStripMenuItem();
            this.JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator2 = new ToolStripSeparator();
            this.AllFilesToolStripMenuItem = new ToolStripMenuItem();
            this.CREATEPDFFILESToolStripMenuItem = new ToolStripMenuItem();
            this.EntriesToolStripMenuItem2 = new ToolStripMenuItem();
            this.StartListToolStripMenuItem2 = new ToolStripMenuItem();
            this.SHOWRESULTSToolStripMenuItem = new ToolStripMenuItem();
            this.COPYOFFICIALSToolStripMenuItem = new ToolStripMenuItem();
            this.SetupToolStripMenuItem = new ToolStripMenuItem();
            this.CategorySelectionToolStripMenuItem = new ToolStripMenuItem();
            this.JudgesSetupToolStripMenuItem = new ToolStripMenuItem();
            this.HeadPageToolStripMenuItem1 = new ToolStripMenuItem();
            this.OpenDBToolStripMenuItem = new ToolStripMenuItem();
            this.DBToolStripMenuItem = new ToolStripMenuItem();
            this.NetworkToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator8 = new ToolStripSeparator();
            this.HideJudgesComputersToolStripMenuItem = new ToolStripMenuItem();
            this.UnhudeJudgesDisplayToolStripMenuItem = new ToolStripMenuItem();
            this.ToolStripSeparator1 = new ToolStripSeparator();
            this.PingTheNetworkToolStripMenuItem = new ToolStripMenuItem();
            this.Label1 = new Label();
            this.Label2 = new Label();
            this.lblDate = new Label();
            this.Label4 = new Label();
            this.Label5 = new Label();
            this.Label6 = new Label();
            this.Label7 = new Label();
            this.Label8 = new Label();
            this.Label9 = new Label();
            this.Label10 = new Label();
            this.Label11 = new Label();
            this.Label12 = new Label();
            this.Label13 = new Label();
            this.Label14 = new Label();
            this.ControllerName = new TextBox();
            this.ControllerClub = new TextBox();
            this.lblJ1 = new Label();
            this.lblJ2 = new Label();
            this.lblJ3 = new Label();
            this.lblJ4 = new Label();
            this.lblJ5 = new Label();
            this.lblJ6 = new Label();
            this.lblJ7 = new Label();
            this.JudgeName1 = new TextBox();
            this.JudgeName2 = new TextBox();
            this.JudgeName3 = new TextBox();
            this.JudgeName4 = new TextBox();
            this.JudgeName5 = new TextBox();
            this.JudgeName6 = new TextBox();
            this.JudgeName7 = new TextBox();
            this.JudgeClub1 = new TextBox();
            this.JudgeClub2 = new TextBox();
            this.JudgeClub3 = new TextBox();
            this.JudgeClub4 = new TextBox();
            this.JudgeClub5 = new TextBox();
            this.JudgeClub6 = new TextBox();
            this.JudgeClub7 = new TextBox();
            this.TechSpecName = new TextBox();
            this.RefereeName = new TextBox();
            this.DVOName1 = new TextBox();
            this.DVOName2 = new TextBox();
            this.DVOName3 = new TextBox();
            this.txtCompetitionName = new TextBox();
            this.txtCategory = new TextBox();
            this.txtDate = new TextBox();
            this.txtStartTime = new TextBox();
            this.txtNoOfJudges = new TextBox();
            this.txtNoOfTrJ = new TextBox();
            this.Label22 = new Label();
            this.Label23 = new Label();
            this.Label24 = new Label();
            this.Label26 = new Label();
            this.Label27 = new Label();
            this.TechSpecClub = new TextBox();
            this.RefereeClub = new TextBox();
            this.DVOClub1 = new TextBox();
            this.DVOClub2 = new TextBox();
            this.DVOClub3 = new TextBox();
            this.lblStart = new Label();
            this.txtSubcategory = new TextBox();
            this.txtSegment = new TextBox();
            this.Label29 = new Label();
            this.Mode = new TextBox();
            this.OpenFileDialog1 = new OpenFileDialog();
            this.txtNonJudgingReferee = new TextBox();
            this.btnSeg1 = new Button();
            this.btnSeg2 = new Button();
            this.Label30 = new Label();
            this.txtParticipants = new TextBox();
            this.Label31 = new Label();
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblCC_El = new Label();
            this.PictureBox1 = new PictureBox();
            this.BackgroundWorker2 = new BackgroundWorker();
            this.BackgroundWorker5 = new BackgroundWorker();
            this.lblSeg2 = new Label();
            this.lblSeg1 = new Label();
            this.Timer3 = new System.Windows.Forms.Timer(this.components);
            this.Timer10 = new System.Windows.Forms.Timer(this.components);
            this.BackgroundWorker10 = new BackgroundWorker();
            this.BackgroundWorker1 = new BackgroundWorker();
            this.BackgroundWorker3 = new BackgroundWorker();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCC_Info = new Label();
            this.Label3 = new Label();
            this.txtCompetitionID = new TextBox();
            this.Label17 = new Label();
            this.txtCategoryID = new TextBox();
            this.Label16 = new Label();
            this.Label15 = new Label();
            this.txtOrganizerID = new TextBox();
            this.txtOrganizerName = new TextBox();
            this.Label18 = new Label();
            this.Label19 = new Label();
            this.txtType = new TextBox();
            this.lblCC_MP = new Label();
            this.txtIndTADiscipline = new TextBox();
            this.txtIndTAClass = new TextBox();
            this.MenuStrip1.SuspendLayout();
            ((ISupportInitialize)this.PictureBox1).BeginInit();
            this.SuspendLayout();
            this.MenuStrip1.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            this.MenuStrip1.Items.AddRange(new ToolStripItem[9]
            {
        (ToolStripItem) this.ToolStripMenuItem1,
        (ToolStripItem) this.ModeSelectionToolStripMenuItem,
        (ToolStripItem) this.CompetitionToolStripMenuItem,
        (ToolStripItem) this.PRINTToolStripMenuItem,
        (ToolStripItem) this.CREATEFILESToolStripMenuItem,
        (ToolStripItem) this.CREATEPDFFILESToolStripMenuItem,
        (ToolStripItem) this.SHOWRESULTSToolStripMenuItem,
        (ToolStripItem) this.COPYOFFICIALSToolStripMenuItem,
        (ToolStripItem) this.SetupToolStripMenuItem
            });
            this.MenuStrip1.Location = new Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new Padding(7, 2, 0, 2);
            MenuStrip menuStrip1 = this.MenuStrip1;
            Size size1 = new Size(943, 24);
            Size size2 = size1;
            menuStrip1.Size = size2;
            this.MenuStrip1.TabIndex = 0;
            this.MenuStrip1.Text = "MenuStrip1";
            this.ToolStripMenuItem1.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            this.ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[6]
            {
        (ToolStripItem) this.LoadCategoryToolStripMenuItem,
        (ToolStripItem) this.SaveToolStripMenuItem,
        (ToolStripItem) this.SaveCategoryToolStripMenuItem,
        (ToolStripItem) this.ClearDataToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator7,
        (ToolStripItem) this.ExitToolStripMenuItem1
            });
            this.ToolStripMenuItem1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            ToolStripMenuItem toolStripMenuItem1_1 = this.ToolStripMenuItem1;
            size1 = new Size(42, 20);
            Size size3 = size1;
            toolStripMenuItem1_1.Size = size3;
            this.ToolStripMenuItem1.Text = "FILE";
            this.LoadCategoryToolStripMenuItem.Name = "LoadCategoryToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem1 = this.LoadCategoryToolStripMenuItem;
            size1 = new Size(207, 22);
            Size size4 = size1;
            toolStripMenuItem1.Size = size4;
            this.LoadCategoryToolStripMenuItem.Text = "Load Category, CTRL+L";
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem2 = this.SaveToolStripMenuItem;
            size1 = new Size(207, 22);
            Size size5 = size1;
            toolStripMenuItem2.Size = size5;
            this.SaveToolStripMenuItem.Text = "Save Category, CTRL+S";
            this.SaveCategoryToolStripMenuItem.Name = "SaveCategoryToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem3 = this.SaveCategoryToolStripMenuItem;
            size1 = new Size(207, 22);
            Size size6 = size1;
            toolStripMenuItem3.Size = size6;
            this.SaveCategoryToolStripMenuItem.Text = "Save Category As";
            this.ClearDataToolStripMenuItem.Name = "ClearDataToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem4 = this.ClearDataToolStripMenuItem;
            size1 = new Size(207, 22);
            Size size7 = size1;
            toolStripMenuItem4.Size = size7;
            this.ClearDataToolStripMenuItem.Text = "Clear Officials";
            this.ToolStripSeparator7.Name = "ToolStripSeparator7";
            ToolStripSeparator toolStripSeparator7 = this.ToolStripSeparator7;
            size1 = new Size(204, 6);
            Size size8 = size1;
            toolStripSeparator7.Size = size8;
            this.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1";
            ToolStripMenuItem toolStripMenuItem1_2 = this.ExitToolStripMenuItem1;
            size1 = new Size(207, 22);
            Size size9 = size1;
            toolStripMenuItem1_2.Size = size9;
            this.ExitToolStripMenuItem1.Text = "Exit";
            this.ModeSelectionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[3]
            {
        (ToolStripItem) this.RunWithNetwotkToolStripMenuItem,
        (ToolStripItem) this.PrepareModeToolStripMenuItem,
        (ToolStripItem) this.ManualInputToolStripMenuItem
            });
            this.ModeSelectionToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ModeSelectionToolStripMenuItem.Name = "ModeSelectionToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem5 = this.ModeSelectionToolStripMenuItem;
            size1 = new Size(88, 20);
            Size size10 = size1;
            toolStripMenuItem5.Size = size10;
            this.ModeSelectionToolStripMenuItem.Text = "WORK MODE";
            this.RunWithNetwotkToolStripMenuItem.Name = "RunWithNetwotkToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem6 = this.RunWithNetwotkToolStripMenuItem;
            size1 = new Size(155, 22);
            Size size11 = size1;
            toolStripMenuItem6.Size = size11;
            this.RunWithNetwotkToolStripMenuItem.Text = "Network Mode";
            this.PrepareModeToolStripMenuItem.Name = "PrepareModeToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem7 = this.PrepareModeToolStripMenuItem;
            size1 = new Size(155, 22);
            Size size12 = size1;
            toolStripMenuItem7.Size = size12;
            this.PrepareModeToolStripMenuItem.Text = "Prepare Mode";
            this.ManualInputToolStripMenuItem.Name = "ManualInputToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem8 = this.ManualInputToolStripMenuItem;
            size1 = new Size(155, 22);
            Size size13 = size1;
            toolStripMenuItem8.Size = size13;
            this.ManualInputToolStripMenuItem.Text = "Manual Mode";
            this.CompetitionToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.CompetitionToolStripMenuItem.Name = "CompetitionToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem9 = this.CompetitionToolStripMenuItem;
            size1 = new Size(84, 20);
            Size size14 = size1;
            toolStripMenuItem9.Size = size14;
            this.CompetitionToolStripMenuItem.Text = "START LIST";
            this.PRINTToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[19]
            {
        (ToolStripItem) this.JudgeCardForAllSkatersToolStripMenuItem,
        (ToolStripItem) this.JudgeCardsFörOneJudgeToolStripMenuItem,
        (ToolStripItem) this.JusgeCardsForASelectedSkaterToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator3,
        (ToolStripItem) this.TCTSCardToolStripMenuItem,
        (ToolStripItem) this.TCSCardForBothTCAndTCToolStripMenuItem,
        (ToolStripItem) this.TCTSCardForASelectedSkaterToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator4,
        (ToolStripItem) this.HeadPageToolStripMenuItem,
        (ToolStripItem) this.EntriesToolStripMenuItem,
        (ToolStripItem) this.StartListToolStripMenuItem1,
        (ToolStripItem) this.WarmupGroupsToolStripMenuItem,
        (ToolStripItem) this.JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator5,
        (ToolStripItem) this.ResultsToolStripMenuItem,
        (ToolStripItem) this.JudgesDetailsToolStripMenuItem,
        (ToolStripItem) this.JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator6,
        (ToolStripItem) this.PrintAllResultDocumentsCategoryToolStripMenuItem
            });
            this.PRINTToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.PRINTToolStripMenuItem.Name = "PRINTToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem10 = this.PRINTToolStripMenuItem;
            size1 = new Size(53, 20);
            Size size15 = size1;
            toolStripMenuItem10.Size = size15;
            this.PRINTToolStripMenuItem.Text = "PRINT";
            this.JudgeCardForAllSkatersToolStripMenuItem.Name = "JudgeCardForAllSkatersToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem11 = this.JudgeCardForAllSkatersToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size16 = size1;
            toolStripMenuItem11.Size = size16;
            this.JudgeCardForAllSkatersToolStripMenuItem.Text = "Judge Cards for all skaters";
            this.JudgeCardsFörOneJudgeToolStripMenuItem.Name = "JudgeCardsFörOneJudgeToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem12 = this.JudgeCardsFörOneJudgeToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size17 = size1;
            toolStripMenuItem12.Size = size17;
            this.JudgeCardsFörOneJudgeToolStripMenuItem.Text = "Judge Cards for one Judge";
            this.JusgeCardsForASelectedSkaterToolStripMenuItem.Name = "JusgeCardsForASelectedSkaterToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem13 = this.JusgeCardsForASelectedSkaterToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size18 = size1;
            toolStripMenuItem13.Size = size18;
            this.JusgeCardsForASelectedSkaterToolStripMenuItem.Text = "Judge Cards for a selected skater";
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            ToolStripSeparator toolStripSeparator3 = this.ToolStripSeparator3;
            size1 = new Size(428, 6);
            Size size19 = size1;
            toolStripSeparator3.Size = size19;
            this.TCTSCardToolStripMenuItem.Name = "TCTSCardToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem14 = this.TCTSCardToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size20 = size1;
            toolStripMenuItem14.Size = size20;
            this.TCTSCardToolStripMenuItem.Text = "TC Cards for the TC";
            this.TCSCardForBothTCAndTCToolStripMenuItem.Name = "TCSCardForBothTCAndTCToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem15 = this.TCSCardForBothTCAndTCToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size21 = size1;
            toolStripMenuItem15.Size = size21;
            this.TCSCardForBothTCAndTCToolStripMenuItem.Text = "TC/TS Cards for both TC and TS";
            this.TCTSCardForASelectedSkaterToolStripMenuItem.Name = "TCTSCardForASelectedSkaterToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem16 = this.TCTSCardForASelectedSkaterToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size22 = size1;
            toolStripMenuItem16.Size = size22;
            this.TCTSCardForASelectedSkaterToolStripMenuItem.Text = "TC/TS Cards for a selected skater";
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            ToolStripSeparator toolStripSeparator4 = this.ToolStripSeparator4;
            size1 = new Size(428, 6);
            Size size23 = size1;
            toolStripSeparator4.Size = size23;
            this.HeadPageToolStripMenuItem.Name = "HeadPageToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem17 = this.HeadPageToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size24 = size1;
            toolStripMenuItem17.Size = size24;
            this.HeadPageToolStripMenuItem.Text = "Head Page";
            this.EntriesToolStripMenuItem.Name = "EntriesToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem18 = this.EntriesToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size25 = size1;
            toolStripMenuItem18.Size = size25;
            this.EntriesToolStripMenuItem.Text = "Entries";
            this.StartListToolStripMenuItem1.Name = "StartListToolStripMenuItem1";
            ToolStripMenuItem toolStripMenuItem1_3 = this.StartListToolStripMenuItem1;
            size1 = new Size(431, 22);
            Size size26 = size1;
            toolStripMenuItem1_3.Size = size26;
            this.StartListToolStripMenuItem1.Text = "Start List";
            this.WarmupGroupsToolStripMenuItem.Name = "WarmupGroupsToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem19 = this.WarmupGroupsToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size27 = size1;
            toolStripMenuItem19.Size = size27;
            this.WarmupGroupsToolStripMenuItem.Text = "Warmup Groups";
            this.JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem.Name = "JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem20 = this.JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size28 = size1;
            toolStripMenuItem20.Size = size28;
            this.JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem.Text = "Judges Details for the Category with one Skater per Page";
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            ToolStripSeparator toolStripSeparator5 = this.ToolStripSeparator5;
            size1 = new Size(428, 6);
            Size size29 = size1;
            toolStripSeparator5.Size = size29;
            this.ResultsToolStripMenuItem.Name = "ResultsToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem21 = this.ResultsToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size30 = size1;
            toolStripMenuItem21.Size = size30;
            this.ResultsToolStripMenuItem.Text = "Results";
            this.JudgesDetailsToolStripMenuItem.Name = "JudgesDetailsToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem22 = this.JudgesDetailsToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size31 = size1;
            toolStripMenuItem22.Size = size31;
            this.JudgesDetailsToolStripMenuItem.Text = "Judges Details for the Category with Tr. Judges and Referee";
            this.JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem.Name = "JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem23 = this.JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size32 = size1;
            toolStripMenuItem23.Size = size32;
            this.JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem.Text = "Judges Details for the Category without Tr. Judges and Referee";
            this.ToolStripSeparator6.Name = "ToolStripSeparator6";
            ToolStripSeparator toolStripSeparator6 = this.ToolStripSeparator6;
            size1 = new Size(428, 6);
            Size size33 = size1;
            toolStripSeparator6.Size = size33;
            this.PrintAllResultDocumentsCategoryToolStripMenuItem.Name = "PrintAllResultDocumentsCategoryToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem24 = this.PrintAllResultDocumentsCategoryToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size34 = size1;
            toolStripMenuItem24.Size = size34;
            this.PrintAllResultDocumentsCategoryToolStripMenuItem.Text = "All Result Documents / Category";
            this.CREATEFILESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[8]
            {
        (ToolStripItem) this.EntriesToolStripMenuItem1,
        (ToolStripItem) this.StartListToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator9,
        (ToolStripItem) this.HeadPageToolStripMenuItem2,
        (ToolStripItem) this.ResultsPDFfilesToolStripMenuItem,
        (ToolStripItem) this.JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator2,
        (ToolStripItem) this.AllFilesToolStripMenuItem
            });
            this.CREATEFILESToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.CREATEFILESToolStripMenuItem.Name = "CREATEFILESToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem25 = this.CREATEFILESToolStripMenuItem;
            size1 = new Size(120, 20);
            Size size35 = size1;
            toolStripMenuItem25.Size = size35;
            this.CREATEFILESToolStripMenuItem.Text = "CREATE PDF-FILES";
            this.EntriesToolStripMenuItem1.Name = "EntriesToolStripMenuItem1";
            ToolStripMenuItem toolStripMenuItem1_4 = this.EntriesToolStripMenuItem1;
            size1 = new Size(431, 22);
            Size size36 = size1;
            toolStripMenuItem1_4.Size = size36;
            this.EntriesToolStripMenuItem1.Text = "Entries";
            this.StartListToolStripMenuItem.Name = "StartListToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem26 = this.StartListToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size37 = size1;
            toolStripMenuItem26.Size = size37;
            this.StartListToolStripMenuItem.Text = "Start List";
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            ToolStripSeparator toolStripSeparator9 = this.ToolStripSeparator9;
            size1 = new Size(428, 6);
            Size size38 = size1;
            toolStripSeparator9.Size = size38;
            this.HeadPageToolStripMenuItem2.Name = "HeadPageToolStripMenuItem2";
            ToolStripMenuItem toolStripMenuItem2_1 = this.HeadPageToolStripMenuItem2;
            size1 = new Size(431, 22);
            Size size39 = size1;
            toolStripMenuItem2_1.Size = size39;
            this.HeadPageToolStripMenuItem2.Text = "Head Page";
            this.ResultsPDFfilesToolStripMenuItem.Name = "ResultsPDFfilesToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem27 = this.ResultsPDFfilesToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size40 = size1;
            toolStripMenuItem27.Size = size40;
            this.ResultsPDFfilesToolStripMenuItem.Text = "Results";
            this.JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem.Name = "JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem28 = this.JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size41 = size1;
            toolStripMenuItem28.Size = size41;
            this.JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem.Text = "Judges Details for the Category without Tr. Judges and Referee";
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator toolStripSeparator2 = this.ToolStripSeparator2;
            size1 = new Size(428, 6);
            Size size42 = size1;
            toolStripSeparator2.Size = size42;
            this.AllFilesToolStripMenuItem.Name = "AllFilesToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem29 = this.AllFilesToolStripMenuItem;
            size1 = new Size(431, 22);
            Size size43 = size1;
            toolStripMenuItem29.Size = size43;
            this.AllFilesToolStripMenuItem.Text = "All Result Documents / Category";
            this.CREATEPDFFILESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[2]
            {
        (ToolStripItem) this.EntriesToolStripMenuItem2,
        (ToolStripItem) this.StartListToolStripMenuItem2
            });
            this.CREATEPDFFILESToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
            this.CREATEPDFFILESToolStripMenuItem.Name = "CREATEPDFFILESToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem30 = this.CREATEPDFFILESToolStripMenuItem;
            size1 = new Size(120, 20);
            Size size44 = size1;
            toolStripMenuItem30.Size = size44;
            this.CREATEPDFFILESToolStripMenuItem.Text = "CREATE PDF-FILES";
            this.EntriesToolStripMenuItem2.Name = "EntriesToolStripMenuItem2";
            ToolStripMenuItem toolStripMenuItem2_2 = this.EntriesToolStripMenuItem2;
            size1 = new Size(126, 22);
            Size size45 = size1;
            toolStripMenuItem2_2.Size = size45;
            this.EntriesToolStripMenuItem2.Text = "Entries";
            this.StartListToolStripMenuItem2.Name = "StartListToolStripMenuItem2";
            ToolStripMenuItem toolStripMenuItem2_3 = this.StartListToolStripMenuItem2;
            size1 = new Size(126, 22);
            Size size46 = size1;
            toolStripMenuItem2_3.Size = size46;
            this.StartListToolStripMenuItem2.Text = "Start List";
            this.SHOWRESULTSToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.SHOWRESULTSToolStripMenuItem.Name = "SHOWRESULTSToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem31 = this.SHOWRESULTSToolStripMenuItem;
            size1 = new Size(105, 20);
            Size size47 = size1;
            toolStripMenuItem31.Size = size47;
            this.SHOWRESULTSToolStripMenuItem.Text = "SHOW RESULTS";
            this.COPYOFFICIALSToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.COPYOFFICIALSToolStripMenuItem.Name = "COPYOFFICIALSToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem32 = this.COPYOFFICIALSToolStripMenuItem;
            size1 = new Size(109, 20);
            Size size48 = size1;
            toolStripMenuItem32.Size = size48;
            this.COPYOFFICIALSToolStripMenuItem.Text = "COPY OFFICIALS";
            this.COPYOFFICIALSToolStripMenuItem.Visible = false;
            this.SetupToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[11]
            {
        (ToolStripItem) this.CategorySelectionToolStripMenuItem,
        (ToolStripItem) this.JudgesSetupToolStripMenuItem,
        (ToolStripItem) this.HeadPageToolStripMenuItem1,
        (ToolStripItem) this.OpenDBToolStripMenuItem,
        (ToolStripItem) this.DBToolStripMenuItem,
        (ToolStripItem) this.NetworkToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator8,
        (ToolStripItem) this.HideJudgesComputersToolStripMenuItem,
        (ToolStripItem) this.UnhudeJudgesDisplayToolStripMenuItem,
        (ToolStripItem) this.ToolStripSeparator1,
        (ToolStripItem) this.PingTheNetworkToolStripMenuItem
            });
            this.SetupToolStripMenuItem.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem33 = this.SetupToolStripMenuItem;
            size1 = new Size(54, 20);
            Size size49 = size1;
            toolStripMenuItem33.Size = size49;
            this.SetupToolStripMenuItem.Text = "SETUP";
            this.CategorySelectionToolStripMenuItem.Name = "CategorySelectionToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem34 = this.CategorySelectionToolStripMenuItem;
            size1 = new Size(200, 22);
            Size size50 = size1;
            toolStripMenuItem34.Size = size50;
            this.CategorySelectionToolStripMenuItem.Text = "Category";
            this.JudgesSetupToolStripMenuItem.Name = "JudgesSetupToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem35 = this.JudgesSetupToolStripMenuItem;
            size1 = new Size(200, 22);
            Size size51 = size1;
            toolStripMenuItem35.Size = size51;
            this.JudgesSetupToolStripMenuItem.Text = "Judges";
            this.HeadPageToolStripMenuItem1.Name = "HeadPageToolStripMenuItem1";
            ToolStripMenuItem toolStripMenuItem1_5 = this.HeadPageToolStripMenuItem1;
            size1 = new Size(200, 22);
            Size size52 = size1;
            toolStripMenuItem1_5.Size = size52;
            this.HeadPageToolStripMenuItem1.Text = "Head Page";
            this.OpenDBToolStripMenuItem.Name = "OpenDBToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem36 = this.OpenDBToolStripMenuItem;
            size1 = new Size(200, 22);
            Size size53 = size1;
            toolStripMenuItem36.Size = size53;
            this.OpenDBToolStripMenuItem.Text = "Open DB";
            this.DBToolStripMenuItem.Name = "DBToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem37 = this.DBToolStripMenuItem;
            size1 = new Size(200, 22);
            Size size54 = size1;
            toolStripMenuItem37.Size = size54;
            this.DBToolStripMenuItem.Text = "Element DB";
            this.NetworkToolStripMenuItem.Name = "NetworkToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem38 = this.NetworkToolStripMenuItem;
            size1 = new Size(200, 22);
            Size size55 = size1;
            toolStripMenuItem38.Size = size55;
            this.NetworkToolStripMenuItem.Text = "Configuration Data";
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            ToolStripSeparator toolStripSeparator8 = this.ToolStripSeparator8;
            size1 = new Size(197, 6);
            Size size56 = size1;
            toolStripSeparator8.Size = size56;
            this.HideJudgesComputersToolStripMenuItem.Name = "HideJudgesComputersToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem39 = this.HideJudgesComputersToolStripMenuItem;
            size1 = new Size(200, 22);
            Size size57 = size1;
            toolStripMenuItem39.Size = size57;
            this.HideJudgesComputersToolStripMenuItem.Text = "Hide Judges Display";
            this.UnhudeJudgesDisplayToolStripMenuItem.Name = "UnhudeJudgesDisplayToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem40 = this.UnhudeJudgesDisplayToolStripMenuItem;
            size1 = new Size(200, 22);
            Size size58 = size1;
            toolStripMenuItem40.Size = size58;
            this.UnhudeJudgesDisplayToolStripMenuItem.Text = "Unhide Judges Display";
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator toolStripSeparator1 = this.ToolStripSeparator1;
            size1 = new Size(197, 6);
            Size size59 = size1;
            toolStripSeparator1.Size = size59;
            this.PingTheNetworkToolStripMenuItem.Name = "PingTheNetworkToolStripMenuItem";
            ToolStripMenuItem toolStripMenuItem41 = this.PingTheNetworkToolStripMenuItem;
            size1 = new Size(200, 22);
            Size size60 = size1;
            toolStripMenuItem41.Size = size60;
            this.PingTheNetworkToolStripMenuItem.Text = "Ping the Network, F4";
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new Point(2, 41);
            this.Label1.Name = "Label1";
            Label label1 = this.Label1;
            size1 = new Size(92, 13);
            Size size61 = size1;
            label1.Size = size61;
            this.Label1.TabIndex = 1;
            this.Label1.Text = "COMPETITION";
            this.Label2.AutoSize = true;
            this.Label2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label2.Location = new Point(1, 120);
            this.Label2.Name = "Label2";
            Label label2 = this.Label2;
            size1 = new Size(142, 13);
            Size size62 = size1;
            label2.Size = size62;
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Category / Subcategory";
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblDate.Location = new Point(639, 122);
            this.lblDate.Name = "lblDate";
            Label lblDate = this.lblDate;
            size1 = new Size(34, 13);
            Size size63 = size1;
            lblDate.Size = size63;
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            this.Label4.AutoSize = true;
            this.Label4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label4.Location = new Point(1, 208);
            this.Label4.Name = "Label4";
            Label label4 = this.Label4;
            size1 = new Size(86, 13);
            Size size64 = size1;
            label4.Size = size64;
            this.Label4.TabIndex = 4;
            this.Label4.Text = "No. of Judges";
            this.Label5.AutoSize = true;
            this.Label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label5.Location = new Point(1, 228);
            this.Label5.Name = "Label5";
            Label label5 = this.Label5;
            size1 = new Size(115, 13);
            Size size65 = size1;
            label5.Size = size65;
            this.Label5.TabIndex = 5;
            this.Label5.Text = "No. of Trial Judges";
            this.Label6.AutoSize = true;
            this.Label6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label6.Location = new Point(1, 262);
            this.Label6.Name = "Label6";
            Label label6 = this.Label6;
            size1 = new Size(69, 13);
            Size size66 = size1;
            label6.Size = size66;
            this.Label6.TabIndex = 6;
            this.Label6.Text = "OFFICIALS";
            this.Label7.AutoSize = true;
            this.Label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label7.Location = new Point(2, 280);
            this.Label7.Name = "Label7";
            Label label7 = this.Label7;
            size1 = new Size(101, 13);
            Size size67 = size1;
            label7.Size = size67;
            this.Label7.TabIndex = 7;
            this.Label7.Text = "Technical Contr.";
            this.Label8.AutoSize = true;
            this.Label8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label8.Location = new Point(2, 300);
            this.Label8.Name = "Label8";
            Label label8 = this.Label8;
            size1 = new Size(140, 13);
            Size size68 = size1;
            label8.Size = size68;
            this.Label8.TabIndex = 8;
            this.Label8.Text = "Technical Contr./Spec.";
            this.Label9.AutoSize = true;
            this.Label9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label9.Location = new Point(2, 320);
            this.Label9.Name = "Label9";
            Label label9 = this.Label9;
            size1 = new Size(52, 13);
            Size size69 = size1;
            label9.Size = size69;
            this.Label9.TabIndex = 9;
            this.Label9.Text = "Referee";
            this.Label10.AutoSize = true;
            this.Label10.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label10.Location = new Point(1, 343);
            this.Label10.Name = "Label10";
            Label label10 = this.Label10;
            size1 = new Size(83, 13);
            Size size70 = size1;
            label10.Size = size70;
            this.Label10.TabIndex = 10;
            this.Label10.Text = "OPERATORS";
            this.Label11.AutoSize = true;
            this.Label11.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label11.Location = new Point(2, 381);
            this.Label11.Name = "Label11";
            Label label11 = this.Label11;
            size1 = new Size(33, 13);
            Size size71 = size1;
            label11.Size = size71;
            this.Label11.TabIndex = 11;
            this.Label11.Text = "DVO";
            this.Label12.AutoSize = true;
            this.Label12.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label12.Location = new Point(2, 361);
            this.Label12.Name = "Label12";
            Label label12 = this.Label12;
            size1 = new Size(33, 13);
            Size size72 = size1;
            label12.Size = size72;
            this.Label12.TabIndex = 12;
            this.Label12.Text = "DVO";
            this.Label13.AutoSize = true;
            this.Label13.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label13.Location = new Point(2, 401);
            this.Label13.Name = "Label13";
            Label label13 = this.Label13;
            size1 = new Size(109, 13);
            Size size73 = size1;
            label13.Size = size73;
            this.Label13.TabIndex = 13;
            this.Label13.Text = "Technical support";
            this.Label14.AutoSize = true;
            this.Label14.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label14.Location = new Point(546, 263);
            this.Label14.Name = "Label14";
            Label label14 = this.Label14;
            size1 = new Size(56, 13);
            Size size74 = size1;
            label14.Size = size74;
            this.Label14.TabIndex = 14;
            this.Label14.Text = "JUDGES";
            this.ControllerName.BackColor = Color.White;
            this.ControllerName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ControllerName.Location = new Point(164, 277);
            this.ControllerName.Name = "ControllerName";
            TextBox controllerName = this.ControllerName;
            size1 = new Size(201, 20);
            Size size75 = size1;
            controllerName.Size = size75;
            this.ControllerName.TabIndex = 4;
            this.ControllerClub.BackColor = Color.White;
            this.ControllerClub.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.ControllerClub.Location = new Point(372, 277);
            this.ControllerClub.Name = "ControllerClub";
            TextBox controllerClub = this.ControllerClub;
            size1 = new Size(143, 20);
            Size size76 = size1;
            controllerClub.Size = size76;
            this.ControllerClub.TabIndex = 5;
            this.lblJ1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblJ1.Location = new Point(521, 280);
            this.lblJ1.Name = "lblJ1";
            Label lblJ1 = this.lblJ1;
            size1 = new Size(84, 13);
            Size size77 = size1;
            lblJ1.Size = size77;
            this.lblJ1.TabIndex = 17;
            this.lblJ1.Text = "Judge 1";
            this.lblJ1.TextAlign = ContentAlignment.MiddleRight;
            this.lblJ2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblJ2.Location = new Point(521, 300);
            this.lblJ2.Name = "lblJ2";
            Label lblJ2 = this.lblJ2;
            size1 = new Size(84, 13);
            Size size78 = size1;
            lblJ2.Size = size78;
            this.lblJ2.TabIndex = 18;
            this.lblJ2.Text = "Judge 2";
            this.lblJ2.TextAlign = ContentAlignment.MiddleRight;
            this.lblJ3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblJ3.Location = new Point(521, 320);
            this.lblJ3.Name = "lblJ3";
            Label lblJ3 = this.lblJ3;
            size1 = new Size(84, 13);
            Size size79 = size1;
            lblJ3.Size = size79;
            this.lblJ3.TabIndex = 19;
            this.lblJ3.Text = "Judge 3";
            this.lblJ3.TextAlign = ContentAlignment.MiddleRight;
            this.lblJ4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblJ4.Location = new Point(521, 340);
            this.lblJ4.Name = "lblJ4";
            Label lblJ4 = this.lblJ4;
            size1 = new Size(84, 13);
            Size size80 = size1;
            lblJ4.Size = size80;
            this.lblJ4.TabIndex = 20;
            this.lblJ4.Text = "Judge 4";
            this.lblJ4.TextAlign = ContentAlignment.MiddleRight;
            this.lblJ5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblJ5.Location = new Point(521, 360);
            this.lblJ5.Name = "lblJ5";
            Label lblJ5 = this.lblJ5;
            size1 = new Size(84, 13);
            Size size81 = size1;
            lblJ5.Size = size81;
            this.lblJ5.TabIndex = 21;
            this.lblJ5.Text = "Judge 5";
            this.lblJ5.TextAlign = ContentAlignment.MiddleRight;
            this.lblJ6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblJ6.Location = new Point(521, 380);
            this.lblJ6.Name = "lblJ6";
            Label lblJ6 = this.lblJ6;
            size1 = new Size(84, 13);
            Size size82 = size1;
            lblJ6.Size = size82;
            this.lblJ6.TabIndex = 22;
            this.lblJ6.Text = "Judge 6";
            this.lblJ6.TextAlign = ContentAlignment.MiddleRight;
            this.lblJ7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblJ7.Location = new Point(521, 400);
            this.lblJ7.Name = "lblJ7";
            Label lblJ7 = this.lblJ7;
            size1 = new Size(84, 13);
            Size size83 = size1;
            lblJ7.Size = size83;
            this.lblJ7.TabIndex = 23;
            this.lblJ7.Text = "Judge 7";
            this.lblJ7.TextAlign = ContentAlignment.MiddleRight;
            this.JudgeName1.BackColor = Color.White;
            this.JudgeName1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JudgeName1.Location = new Point(611, 277);
            this.JudgeName1.Name = "JudgeName1";
            TextBox judgeName1 = this.JudgeName1;
            size1 = new Size(172, 20);
            Size size84 = size1;
            judgeName1.Size = size84;
            this.JudgeName1.TabIndex = 16;
            this.JudgeName1.Tag = (object)"";
            this.JudgeName2.BackColor = Color.White;
            this.JudgeName2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JudgeName2.Location = new Point(611, 297);
            this.JudgeName2.Name = "JudgeName2";
            TextBox judgeName2 = this.JudgeName2;
            size1 = new Size(172, 20);
            Size size85 = size1;
            judgeName2.Size = size85;
            this.JudgeName2.TabIndex = 18;
            this.JudgeName2.Tag = (object)"2";
            this.JudgeName3.BackColor = Color.White;
            this.JudgeName3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JudgeName3.Location = new Point(611, 317);
            this.JudgeName3.Name = "JudgeName3";
            TextBox judgeName3 = this.JudgeName3;
            size1 = new Size(172, 20);
            Size size86 = size1;
            judgeName3.Size = size86;
            this.JudgeName3.TabIndex = 20;
            this.JudgeName4.BackColor = Color.White;
            this.JudgeName4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JudgeName4.Location = new Point(611, 337);
            this.JudgeName4.Name = "JudgeName4";
            TextBox judgeName4 = this.JudgeName4;
            size1 = new Size(172, 20);
            Size size87 = size1;
            judgeName4.Size = size87;
            this.JudgeName4.TabIndex = 22;
            this.JudgeName4.Visible = false;
            this.JudgeName5.BackColor = Color.White;
            this.JudgeName5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JudgeName5.Location = new Point(611, 357);
            this.JudgeName5.Name = "JudgeName5";
            TextBox judgeName5 = this.JudgeName5;
            size1 = new Size(172, 20);
            Size size88 = size1;
            judgeName5.Size = size88;
            this.JudgeName5.TabIndex = 24;
            this.JudgeName5.Visible = false;
            this.JudgeName6.BackColor = Color.White;
            this.JudgeName6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JudgeName6.Location = new Point(611, 377);
            this.JudgeName6.Name = "JudgeName6";
            TextBox judgeName6 = this.JudgeName6;
            size1 = new Size(172, 20);
            Size size89 = size1;
            judgeName6.Size = size89;
            this.JudgeName6.TabIndex = 26;
            this.JudgeName6.Visible = false;
            this.JudgeName7.BackColor = Color.White;
            this.JudgeName7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JudgeName7.Location = new Point(611, 397);
            this.JudgeName7.Name = "JudgeName7";
            TextBox judgeName7 = this.JudgeName7;
            size1 = new Size(172, 20);
            Size size90 = size1;
            judgeName7.Size = size90;
            this.JudgeName7.TabIndex = 28;
            this.JudgeName7.Visible = false;
            this.JudgeClub1.BackColor = Color.White;
            this.JudgeClub1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JudgeClub1.Location = new Point(791, 277);
            this.JudgeClub1.Name = "JudgeClub1";
            TextBox judgeClub1 = this.JudgeClub1;
            size1 = new Size(143, 20);
            Size size91 = size1;
            judgeClub1.Size = size91;
            this.JudgeClub1.TabIndex = 17;
            this.JudgeClub2.BackColor = Color.White;
            this.JudgeClub2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JudgeClub2.Location = new Point(791, 297);
            this.JudgeClub2.Name = "JudgeClub2";
            TextBox judgeClub2 = this.JudgeClub2;
            size1 = new Size(143, 20);
            Size size92 = size1;
            judgeClub2.Size = size92;
            this.JudgeClub2.TabIndex = 19;
            this.JudgeClub3.BackColor = Color.White;
            this.JudgeClub3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JudgeClub3.Location = new Point(791, 317);
            this.JudgeClub3.Name = "JudgeClub3";
            TextBox judgeClub3 = this.JudgeClub3;
            size1 = new Size(143, 20);
            Size size93 = size1;
            judgeClub3.Size = size93;
            this.JudgeClub3.TabIndex = 21;
            this.JudgeClub4.BackColor = Color.White;
            this.JudgeClub4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JudgeClub4.Location = new Point(791, 337);
            this.JudgeClub4.Name = "JudgeClub4";
            TextBox judgeClub4 = this.JudgeClub4;
            size1 = new Size(143, 20);
            Size size94 = size1;
            judgeClub4.Size = size94;
            this.JudgeClub4.TabIndex = 23;
            this.JudgeClub4.Visible = false;
            this.JudgeClub5.BackColor = Color.White;
            this.JudgeClub5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JudgeClub5.Location = new Point(791, 357);
            this.JudgeClub5.Name = "JudgeClub5";
            TextBox judgeClub5 = this.JudgeClub5;
            size1 = new Size(143, 20);
            Size size95 = size1;
            judgeClub5.Size = size95;
            this.JudgeClub5.TabIndex = 25;
            this.JudgeClub5.Visible = false;
            this.JudgeClub6.BackColor = Color.White;
            this.JudgeClub6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JudgeClub6.Location = new Point(791, 377);
            this.JudgeClub6.Name = "JudgeClub6";
            TextBox judgeClub6 = this.JudgeClub6;
            size1 = new Size(143, 20);
            Size size96 = size1;
            judgeClub6.Size = size96;
            this.JudgeClub6.TabIndex = 27;
            this.JudgeClub6.Visible = false;
            this.JudgeClub7.BackColor = Color.White;
            this.JudgeClub7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.JudgeClub7.Location = new Point(791, 397);
            this.JudgeClub7.Name = "JudgeClub7";
            TextBox judgeClub7 = this.JudgeClub7;
            size1 = new Size(143, 20);
            Size size97 = size1;
            judgeClub7.Size = size97;
            this.JudgeClub7.TabIndex = 29;
            this.JudgeClub7.Visible = false;
            this.TechSpecName.BackColor = Color.White;
            this.TechSpecName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.TechSpecName.Location = new Point(164, 297);
            this.TechSpecName.Name = "TechSpecName";
            TextBox techSpecName = this.TechSpecName;
            size1 = new Size(201, 20);
            Size size98 = size1;
            techSpecName.Size = size98;
            this.TechSpecName.TabIndex = 6;
            this.RefereeName.BackColor = Color.White;
            this.RefereeName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.RefereeName.Location = new Point(164, 317);
            this.RefereeName.Name = "RefereeName";
            TextBox refereeName = this.RefereeName;
            size1 = new Size(201, 20);
            Size size99 = size1;
            refereeName.Size = size99;
            this.RefereeName.TabIndex = 8;
            this.DVOName1.BackColor = Color.White;
            this.DVOName1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DVOName1.Location = new Point(164, 358);
            this.DVOName1.Name = "DVOName1";
            TextBox dvoName1 = this.DVOName1;
            size1 = new Size(201, 20);
            Size size100 = size1;
            dvoName1.Size = size100;
            this.DVOName1.TabIndex = 10;
            this.DVOName2.BackColor = Color.White;
            this.DVOName2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DVOName2.Location = new Point(164, 378);
            this.DVOName2.Name = "DVOName2";
            TextBox dvoName2 = this.DVOName2;
            size1 = new Size(201, 20);
            Size size101 = size1;
            dvoName2.Size = size101;
            this.DVOName2.TabIndex = 12;
            this.DVOName3.BackColor = Color.White;
            this.DVOName3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DVOName3.Location = new Point(164, 398);
            this.DVOName3.Name = "DVOName3";
            TextBox dvoName3 = this.DVOName3;
            size1 = new Size(201, 20);
            Size size102 = size1;
            dvoName3.Size = size102;
            this.DVOName3.TabIndex = 14;
            this.txtCompetitionName.BackColor = Color.White;
            this.txtCompetitionName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtCompetitionName.Location = new Point(165, 38);
            this.txtCompetitionName.Name = "txtCompetitionName";
            TextBox txtCompetitionName = this.txtCompetitionName;
            size1 = new Size(352, 20);
            Size size103 = size1;
            txtCompetitionName.Size = size103;
            this.txtCompetitionName.TabIndex = 1;
            this.txtCategory.BackColor = SystemColors.Control;
            this.txtCategory.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtCategory.Location = new Point(164, 117);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            TextBox txtCategory = this.txtCategory;
            size1 = new Size(172, 20);
            Size size104 = size1;
            txtCategory.Size = size104;
            this.txtCategory.TabIndex = 30;
            this.txtDate.BackColor = SystemColors.Control;
            this.txtDate.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtDate.Location = new Point(642, 138);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            TextBox txtDate = this.txtDate;
            size1 = new Size(73, 20);
            Size size105 = size1;
            txtDate.Size = size105;
            this.txtDate.TabIndex = 32;
            this.txtDate.TextAlign = HorizontalAlignment.Center;
            this.txtStartTime.BackColor = SystemColors.Control;
            this.txtStartTime.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtStartTime.Location = new Point(721, 138);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.ReadOnly = true;
            TextBox txtStartTime = this.txtStartTime;
            size1 = new Size(58, 20);
            Size size106 = size1;
            txtStartTime.Size = size106;
            this.txtStartTime.TabIndex = 33;
            this.txtStartTime.TextAlign = HorizontalAlignment.Center;
            this.txtNoOfJudges.BackColor = SystemColors.Control;
            this.txtNoOfJudges.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtNoOfJudges.Location = new Point(164, 205);
            this.txtNoOfJudges.Name = "txtNoOfJudges";
            this.txtNoOfJudges.ReadOnly = true;
            TextBox txtNoOfJudges = this.txtNoOfJudges;
            size1 = new Size(37, 20);
            Size size107 = size1;
            txtNoOfJudges.Size = size107;
            this.txtNoOfJudges.TabIndex = 35;
            this.txtNoOfJudges.TextAlign = HorizontalAlignment.Center;
            this.txtNoOfTrJ.BackColor = SystemColors.Control;
            this.txtNoOfTrJ.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtNoOfTrJ.Location = new Point(164, 225);
            this.txtNoOfTrJ.Name = "txtNoOfTrJ";
            this.txtNoOfTrJ.ReadOnly = true;
            TextBox txtNoOfTrJ = this.txtNoOfTrJ;
            size1 = new Size(37, 20);
            Size size108 = size1;
            txtNoOfTrJ.Size = size108;
            this.txtNoOfTrJ.TabIndex = 37;
            this.txtNoOfTrJ.TextAlign = HorizontalAlignment.Center;
            this.Label22.AutoSize = true;
            this.Label22.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label22.Location = new Point(164, 262);
            this.Label22.Name = "Label22";
            Label label22 = this.Label22;
            size1 = new Size(39, 13);
            Size size109 = size1;
            label22.Size = size109;
            this.Label22.TabIndex = 49;
            this.Label22.Text = "Name";
            this.Label23.AutoSize = true;
            this.Label23.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label23.Location = new Point(611, 263);
            this.Label23.Name = "Label23";
            Label label23 = this.Label23;
            size1 = new Size(39, 13);
            Size size110 = size1;
            label23.Size = size110;
            this.Label23.TabIndex = 50;
            this.Label23.Text = "Name";
            this.Label24.AutoSize = true;
            this.Label24.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label24.Location = new Point(164, 343);
            this.Label24.Name = "Label24";
            Label label24 = this.Label24;
            size1 = new Size(39, 13);
            Size size111 = size1;
            label24.Size = size111;
            this.Label24.TabIndex = 51;
            this.Label24.Text = "Name";
            this.Label26.AutoSize = true;
            this.Label26.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label26.Location = new Point(371, 343);
            this.Label26.Name = "Label26";
            Label label26 = this.Label26;
            size1 = new Size(32, 13);
            Size size112 = size1;
            label26.Size = size112;
            this.Label26.TabIndex = 53;
            this.Label26.Text = "Club";
            this.Label27.AutoSize = true;
            this.Label27.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label27.Location = new Point(788, 263);
            this.Label27.Name = "Label27";
            Label label27 = this.Label27;
            size1 = new Size(32, 13);
            Size size113 = size1;
            label27.Size = size113;
            this.Label27.TabIndex = 54;
            this.Label27.Text = "Club";
            this.TechSpecClub.BackColor = Color.White;
            this.TechSpecClub.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.TechSpecClub.Location = new Point(372, 297);
            this.TechSpecClub.Name = "TechSpecClub";
            TextBox techSpecClub = this.TechSpecClub;
            size1 = new Size(143, 20);
            Size size114 = size1;
            techSpecClub.Size = size114;
            this.TechSpecClub.TabIndex = 7;
            this.RefereeClub.BackColor = Color.White;
            this.RefereeClub.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.RefereeClub.Location = new Point(372, 317);
            this.RefereeClub.Name = "RefereeClub";
            TextBox refereeClub = this.RefereeClub;
            size1 = new Size(143, 20);
            Size size115 = size1;
            refereeClub.Size = size115;
            this.RefereeClub.TabIndex = 9;
            this.DVOClub1.BackColor = Color.White;
            this.DVOClub1.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DVOClub1.Location = new Point(372, 358);
            this.DVOClub1.Name = "DVOClub1";
            TextBox dvoClub1 = this.DVOClub1;
            size1 = new Size(143, 20);
            Size size116 = size1;
            dvoClub1.Size = size116;
            this.DVOClub1.TabIndex = 11;
            this.DVOClub2.BackColor = Color.White;
            this.DVOClub2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DVOClub2.Location = new Point(372, 378);
            this.DVOClub2.Name = "DVOClub2";
            TextBox dvoClub2 = this.DVOClub2;
            size1 = new Size(143, 20);
            Size size117 = size1;
            dvoClub2.Size = size117;
            this.DVOClub2.TabIndex = 13;
            this.DVOClub3.BackColor = Color.White;
            this.DVOClub3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.DVOClub3.Location = new Point(372, 398);
            this.DVOClub3.Name = "DVOClub3";
            TextBox dvoClub3 = this.DVOClub3;
            size1 = new Size(143, 20);
            Size size118 = size1;
            dvoClub3.Size = size118;
            this.DVOClub3.TabIndex = 15;
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.lblStart.Location = new Point(718, 122);
            this.lblStart.Name = "lblStart";
            Label lblStart = this.lblStart;
            size1 = new Size(61, 13);
            Size size119 = size1;
            lblStart.Size = size119;
            this.lblStart.TabIndex = 60;
            this.lblStart.Text = "Start time";
            this.txtSubcategory.BackColor = SystemColors.Control;
            this.txtSubcategory.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtSubcategory.Location = new Point(345, 117);
            this.txtSubcategory.Name = "txtSubcategory";
            this.txtSubcategory.ReadOnly = true;
            TextBox txtSubcategory = this.txtSubcategory;
            size1 = new Size(172, 20);
            Size size120 = size1;
            txtSubcategory.Size = size120;
            this.txtSubcategory.TabIndex = 31;
            this.txtSegment.BackColor = SystemColors.Control;
            this.txtSegment.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtSegment.Location = new Point(164, 161);
            this.txtSegment.Name = "txtSegment";
            this.txtSegment.ReadOnly = true;
            TextBox txtSegment = this.txtSegment;
            size1 = new Size(88, 20);
            Size size121 = size1;
            txtSegment.Size = size121;
            this.txtSegment.TabIndex = 34;
            this.Label29.AutoSize = true;
            this.Label29.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label29.Location = new Point(1, 164);
            this.Label29.Name = "Label29";
            Label label29 = this.Label29;
            size1 = new Size(53, 13);
            Size size122 = size1;
            label29.Size = size122;
            this.Label29.TabIndex = 63;
            this.Label29.Text = "Program";
            this.Mode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.Mode.BackColor = Color.FromArgb(128, (int)byte.MaxValue, (int)byte.MaxValue);
            this.Mode.Enabled = false;
            this.Mode.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Mode.Location = new Point(826, 2);
            this.Mode.Name = "Mode";
            TextBox mode = this.Mode;
            size1 = new Size(116, 20);
            Size size123 = size1;
            mode.Size = size123;
            this.Mode.TabIndex = 64;
            this.Mode.TextAlign = HorizontalAlignment.Center;
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            this.txtNonJudgingReferee.BackColor = SystemColors.Control;
            this.txtNonJudgingReferee.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtNonJudgingReferee.Location = new Point(250, 205);
            this.txtNonJudgingReferee.Name = "txtNonJudgingReferee";
            this.txtNonJudgingReferee.ReadOnly = true;
            TextBox nonJudgingReferee = this.txtNonJudgingReferee;
            size1 = new Size(266, 20);
            Size size124 = size1;
            nonJudgingReferee.Size = size124;
            this.txtNonJudgingReferee.TabIndex = 36;
            this.txtNonJudgingReferee.TextAlign = HorizontalAlignment.Center;
            this.btnSeg1.Location = new Point(794, 131);
            this.btnSeg1.Name = "btnSeg1";
            Button btnSeg1 = this.btnSeg1;
            size1 = new Size(140, 31);
            Size size125 = size1;
            btnSeg1.Size = size125;
            this.btnSeg1.TabIndex = 65;
            this.btnSeg1.Text = "SHORT PROGRAM";
            this.btnSeg1.UseVisualStyleBackColor = true;
            this.btnSeg2.Location = new Point(794, 181);
            this.btnSeg2.Name = "btnSeg2";
            Button btnSeg2 = this.btnSeg2;
            size1 = new Size(140, 33);
            Size size126 = size1;
            btnSeg2.Size = size126;
            this.btnSeg2.TabIndex = 66;
            this.btnSeg2.Text = "FREE SKATING";
            this.btnSeg2.UseVisualStyleBackColor = true;
            this.Label30.AutoSize = true;
            this.Label30.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label30.Location = new Point(1, 184);
            this.Label30.Name = "Label30";
            Label label30 = this.Label30;
            size1 = new Size(113, 13);
            Size size127 = size1;
            label30.Size = size127;
            this.Label30.TabIndex = 67;
            this.Label30.Text = "No. of Participants";
            this.txtParticipants.BackColor = SystemColors.Control;
            this.txtParticipants.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtParticipants.Location = new Point(164, 181);
            this.txtParticipants.Name = "txtParticipants";
            this.txtParticipants.ReadOnly = true;
            TextBox txtParticipants = this.txtParticipants;
            size1 = new Size(37, 20);
            Size size128 = size1;
            txtParticipants.Size = size128;
            this.txtParticipants.TabIndex = 68;
            this.txtParticipants.TextAlign = HorizontalAlignment.Center;
            this.Label31.AutoSize = true;
            this.Label31.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label31.Location = new Point(371, 262);
            this.Label31.Name = "Label31";
            Label label31 = this.Label31;
            size1 = new Size(32, 13);
            Size size129 = size1;
            label31.Size = size129;
            this.Label31.TabIndex = 69;
            this.Label31.Text = "Club";
            this.lblCC_El.Location = new Point(840, 25);
            this.lblCC_El.Name = "lblCC_El";
            Label lblCcEl = this.lblCC_El;
            size1 = new Size(82, 18);
            Size size130 = size1;
            lblCcEl.Size = size130;
            this.lblCC_El.TabIndex = 70;
            this.lblCC_El.Text = "CC_Elements";
            this.lblCC_El.TextAlign = ContentAlignment.MiddleLeft;
            this.PictureBox1.Image = (Image)ClubCompFS.My.Resources.Resources.SSloggo_gul_76x31;
            this.PictureBox1.Location = new Point(682, 12);
            this.PictureBox1.Name = "PictureBox1";
            PictureBox pictureBox1 = this.PictureBox1;
            size1 = new Size(91, 90);
            Size size131 = size1;
            pictureBox1.Size = size131;
            this.PictureBox1.TabIndex = 71;
            this.PictureBox1.TabStop = false;
            this.lblSeg2.AutoSize = true;
            this.lblSeg2.Location = new Point(826, 166);
            this.lblSeg2.Name = "lblSeg2";
            Label lblSeg2 = this.lblSeg2;
            size1 = new Size(78, 13);
            Size size132 = size1;
            lblSeg2.Size = size132;
            this.lblSeg2.TabIndex = 75;
            this.lblSeg2.Text = "SEGMENT 2";
            this.lblSeg2.Visible = false;
            this.lblSeg1.AutoSize = true;
            this.lblSeg1.Location = new Point(826, 116);
            this.lblSeg1.Name = "lblSeg1";
            Label lblSeg1 = this.lblSeg1;
            size1 = new Size(78, 13);
            Size size133 = size1;
            lblSeg1.Size = size133;
            this.lblSeg1.TabIndex = 74;
            this.lblSeg1.Text = "SEGMENT 1";
            this.lblSeg1.Visible = false;
            this.Timer3.Interval = 2000;
            this.Timer10.Interval = 1000;
            this.Timer1.Interval = 1000;
            this.lblCC_Info.Location = new Point(840, 45);
            this.lblCC_Info.Name = "lblCC_Info";
            Label lblCcInfo = this.lblCC_Info;
            size1 = new Size(73, 18);
            Size size134 = size1;
            lblCcInfo.Size = size134;
            this.lblCC_Info.TabIndex = 76;
            this.lblCC_Info.Text = "CC_Info";
            this.lblCC_Info.TextAlign = ContentAlignment.MiddleLeft;
            this.Label3.AutoSize = true;
            this.Label3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label3.Location = new Point(1, 141);
            this.Label3.Name = "Label3";
            Label label3 = this.Label3;
            size1 = new Size(144, 13);
            Size size135 = size1;
            label3.Size = size135;
            this.Label3.TabIndex = 77;
            this.Label3.Text = "IndTA Discipline / Class";
            this.txtCompetitionID.BackColor = SystemColors.Control;
            this.txtCompetitionID.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtCompetitionID.Location = new Point(549, 38);
            this.txtCompetitionID.Name = "txtCompetitionID";
            TextBox txtCompetitionId = this.txtCompetitionID;
            size1 = new Size(72, 20);
            Size size136 = size1;
            txtCompetitionId.Size = size136;
            this.txtCompetitionID.TabIndex = 82;
            this.txtCompetitionID.TextAlign = HorizontalAlignment.Center;
            this.Label17.AutoSize = true;
            this.Label17.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label17.Location = new Point(523, 41);
            this.Label17.Name = "Label17";
            Label label17 = this.Label17;
            size1 = new Size(20, 13);
            Size size137 = size1;
            label17.Size = size137;
            this.Label17.TabIndex = 83;
            this.Label17.Text = "ID";
            this.txtCategoryID.BackColor = SystemColors.Control;
            this.txtCategoryID.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtCategoryID.Location = new Point(548, 138);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            TextBox txtCategoryId = this.txtCategoryID;
            size1 = new Size(72, 20);
            Size size138 = size1;
            txtCategoryId.Size = size138;
            this.txtCategoryID.TabIndex = 84;
            this.txtCategoryID.Visible = false;
            this.Label16.AutoSize = true;
            this.Label16.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label16.Location = new Point(521, 140);
            this.Label16.Name = "Label16";
            Label label16 = this.Label16;
            size1 = new Size(20, 13);
            Size size139 = size1;
            label16.Size = size139;
            this.Label16.TabIndex = 85;
            this.Label16.Text = "ID";
            this.Label16.Visible = false;
            this.Label15.AutoSize = true;
            this.Label15.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label15.Location = new Point(522, 93);
            this.Label15.Name = "Label15";
            Label label15 = this.Label15;
            size1 = new Size(20, 13);
            Size size140 = size1;
            label15.Size = size140;
            this.Label15.TabIndex = 89;
            this.Label15.Text = "ID";
            this.txtOrganizerID.BackColor = SystemColors.Control;
            this.txtOrganizerID.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtOrganizerID.Location = new Point(548, 90);
            this.txtOrganizerID.Name = "txtOrganizerID";
            TextBox txtOrganizerId = this.txtOrganizerID;
            size1 = new Size(72, 20);
            Size size141 = size1;
            txtOrganizerId.Size = size141;
            this.txtOrganizerID.TabIndex = 88;
            this.txtOrganizerID.TextAlign = HorizontalAlignment.Center;
            this.txtOrganizerName.BackColor = Color.White;
            this.txtOrganizerName.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtOrganizerName.Location = new Point(164, 90);
            this.txtOrganizerName.Name = "txtOrganizerName";
            TextBox txtOrganizerName = this.txtOrganizerName;
            size1 = new Size(352, 20);
            Size size142 = size1;
            txtOrganizerName.Size = size142;
            this.txtOrganizerName.TabIndex = 86;
            this.Label18.AutoSize = true;
            this.Label18.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label18.Location = new Point(1, 93);
            this.Label18.Name = "Label18";
            Label label18 = this.Label18;
            size1 = new Size(80, 13);
            Size size143 = size1;
            label18.Size = size143;
            this.Label18.TabIndex = 87;
            this.Label18.Text = "ORGANIZER";
            this.Label19.AutoSize = true;
            this.Label19.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label19.Location = new Point(1, 67);
            this.Label19.Name = "Label19";
            Label label19 = this.Label19;
            size1 = new Size(39, 13);
            Size size144 = size1;
            label19.Size = size144;
            this.Label19.TabIndex = 91;
            this.Label19.Text = "TYPE";
            this.txtType.BackColor = Color.White;
            this.txtType.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtType.Location = new Point(165, 64);
            this.txtType.Name = "txtType";
            TextBox txtType = this.txtType;
            size1 = new Size(351, 20);
            Size size145 = size1;
            txtType.Size = size145;
            this.txtType.TabIndex = 92;
            this.lblCC_MP.Location = new Point(840, 65);
            this.lblCC_MP.Name = "lblCC_MP";
            Label lblCcMp = this.lblCC_MP;
            size1 = new Size(73, 18);
            Size size146 = size1;
            lblCcMp.Size = size146;
            this.lblCC_MP.TabIndex = 93;
            this.lblCC_MP.Text = "CC_Info_2";
            this.lblCC_MP.TextAlign = ContentAlignment.MiddleLeft;
            this.txtIndTADiscipline.BackColor = SystemColors.Control;
            this.txtIndTADiscipline.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtIndTADiscipline.Location = new Point(164, 138);
            this.txtIndTADiscipline.Name = "txtIndTADiscipline";
            this.txtIndTADiscipline.ReadOnly = true;
            TextBox txtIndTaDiscipline = this.txtIndTADiscipline;
            size1 = new Size(172, 20);
            Size size147 = size1;
            txtIndTaDiscipline.Size = size147;
            this.txtIndTADiscipline.TabIndex = 94;
            this.txtIndTAClass.BackColor = SystemColors.Control;
            this.txtIndTAClass.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtIndTAClass.Location = new Point(345, 138);
            this.txtIndTAClass.Name = "txtIndTAClass";
            this.txtIndTAClass.ReadOnly = true;
            TextBox txtIndTaClass = this.txtIndTAClass;
            size1 = new Size(172, 20);
            Size size148 = size1;
            txtIndTaClass.Size = size148;
            this.txtIndTAClass.TabIndex = 95;
            this.AutoScaleDimensions = new SizeF(7f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb((int)byte.MaxValue, (int)byte.MaxValue, 128);
            size1 = new Size(943, 428);
            this.ClientSize = size1;
            this.Controls.Add((Control)this.txtIndTAClass);
            this.Controls.Add((Control)this.txtIndTADiscipline);
            this.Controls.Add((Control)this.lblCC_MP);
            this.Controls.Add((Control)this.txtType);
            this.Controls.Add((Control)this.Label19);
            this.Controls.Add((Control)this.Label15);
            this.Controls.Add((Control)this.txtOrganizerID);
            this.Controls.Add((Control)this.txtOrganizerName);
            this.Controls.Add((Control)this.Label18);
            this.Controls.Add((Control)this.Label16);
            this.Controls.Add((Control)this.txtCategoryID);
            this.Controls.Add((Control)this.Label17);
            this.Controls.Add((Control)this.txtCompetitionID);
            this.Controls.Add((Control)this.Label3);
            this.Controls.Add((Control)this.lblCC_Info);
            this.Controls.Add((Control)this.lblSeg2);
            this.Controls.Add((Control)this.lblSeg1);
            this.Controls.Add((Control)this.PictureBox1);
            this.Controls.Add((Control)this.lblCC_El);
            this.Controls.Add((Control)this.Label31);
            this.Controls.Add((Control)this.txtParticipants);
            this.Controls.Add((Control)this.Label30);
            this.Controls.Add((Control)this.btnSeg2);
            this.Controls.Add((Control)this.btnSeg1);
            this.Controls.Add((Control)this.txtNonJudgingReferee);
            this.Controls.Add((Control)this.Mode);
            this.Controls.Add((Control)this.Label29);
            this.Controls.Add((Control)this.txtSegment);
            this.Controls.Add((Control)this.txtSubcategory);
            this.Controls.Add((Control)this.lblStart);
            this.Controls.Add((Control)this.DVOClub3);
            this.Controls.Add((Control)this.DVOClub2);
            this.Controls.Add((Control)this.DVOClub1);
            this.Controls.Add((Control)this.RefereeClub);
            this.Controls.Add((Control)this.TechSpecClub);
            this.Controls.Add((Control)this.Label27);
            this.Controls.Add((Control)this.Label26);
            this.Controls.Add((Control)this.Label24);
            this.Controls.Add((Control)this.Label23);
            this.Controls.Add((Control)this.Label22);
            this.Controls.Add((Control)this.txtNoOfTrJ);
            this.Controls.Add((Control)this.txtNoOfJudges);
            this.Controls.Add((Control)this.txtStartTime);
            this.Controls.Add((Control)this.txtDate);
            this.Controls.Add((Control)this.txtCategory);
            this.Controls.Add((Control)this.txtCompetitionName);
            this.Controls.Add((Control)this.DVOName3);
            this.Controls.Add((Control)this.DVOName2);
            this.Controls.Add((Control)this.DVOName1);
            this.Controls.Add((Control)this.RefereeName);
            this.Controls.Add((Control)this.TechSpecName);
            this.Controls.Add((Control)this.JudgeClub7);
            this.Controls.Add((Control)this.JudgeClub6);
            this.Controls.Add((Control)this.JudgeClub5);
            this.Controls.Add((Control)this.JudgeClub4);
            this.Controls.Add((Control)this.JudgeClub3);
            this.Controls.Add((Control)this.JudgeClub2);
            this.Controls.Add((Control)this.JudgeClub1);
            this.Controls.Add((Control)this.JudgeName7);
            this.Controls.Add((Control)this.JudgeName6);
            this.Controls.Add((Control)this.JudgeName5);
            this.Controls.Add((Control)this.JudgeName4);
            this.Controls.Add((Control)this.JudgeName3);
            this.Controls.Add((Control)this.JudgeName2);
            this.Controls.Add((Control)this.JudgeName1);
            this.Controls.Add((Control)this.lblJ7);
            this.Controls.Add((Control)this.lblJ6);
            this.Controls.Add((Control)this.lblJ5);
            this.Controls.Add((Control)this.lblJ4);
            this.Controls.Add((Control)this.lblJ3);
            this.Controls.Add((Control)this.lblJ2);
            this.Controls.Add((Control)this.lblJ1);
            this.Controls.Add((Control)this.ControllerClub);
            this.Controls.Add((Control)this.ControllerName);
            this.Controls.Add((Control)this.Label14);
            this.Controls.Add((Control)this.Label13);
            this.Controls.Add((Control)this.Label12);
            this.Controls.Add((Control)this.Label11);
            this.Controls.Add((Control)this.Label10);
            this.Controls.Add((Control)this.Label9);
            this.Controls.Add((Control)this.Label8);
            this.Controls.Add((Control)this.Label7);
            this.Controls.Add((Control)this.Label6);
            this.Controls.Add((Control)this.Label5);
            this.Controls.Add((Control)this.Label4);
            this.Controls.Add((Control)this.lblDate);
            this.Controls.Add((Control)this.Label2);
            this.Controls.Add((Control)this.Label1);
            this.Controls.Add((Control)this.MenuStrip1);
            this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.Name = nameof(Form1);
            this.StartPosition = FormStartPosition.Manual;
            this.Text = "ClubCompFS";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((ISupportInitialize)this.PictureBox1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        internal virtual MenuStrip MenuStrip1
        {
            get => this._MenuStrip1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._MenuStrip1 = value;
        }

        internal virtual ToolStripMenuItem ToolStripMenuItem1
        {
            get => this._ToolStripMenuItem1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ToolStripMenuItem1 = value;
        }

        internal virtual ToolStripMenuItem LoadCategoryToolStripMenuItem
        {
            get => this._LoadCategoryToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.LoadCategoryToolStripMenuItem_Click);
                if (this._LoadCategoryToolStripMenuItem != null)
                    this._LoadCategoryToolStripMenuItem.Click -= eventHandler;
                this._LoadCategoryToolStripMenuItem = value;
                if (this._LoadCategoryToolStripMenuItem == null)
                    return;
                this._LoadCategoryToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem SaveCategoryToolStripMenuItem
        {
            get => this._SaveCategoryToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.SaveCategoryToolStripMenuItem_Click);
                if (this._SaveCategoryToolStripMenuItem != null)
                    this._SaveCategoryToolStripMenuItem.Click -= eventHandler;
                this._SaveCategoryToolStripMenuItem = value;
                if (this._SaveCategoryToolStripMenuItem == null)
                    return;
                this._SaveCategoryToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem ClearDataToolStripMenuItem
        {
            get => this._ClearDataToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ClearDataToolStripMenuItem_Click);
                if (this._ClearDataToolStripMenuItem != null)
                    this._ClearDataToolStripMenuItem.Click -= eventHandler;
                this._ClearDataToolStripMenuItem = value;
                if (this._ClearDataToolStripMenuItem == null)
                    return;
                this._ClearDataToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem ModeSelectionToolStripMenuItem
        {
            get => this._ModeSelectionToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ModeSelectionToolStripMenuItem = value;
        }

        internal virtual ToolStripMenuItem RunWithNetwotkToolStripMenuItem
        {
            get => this._RunWithNetwotkToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.RunWithNetwotkToolStripMenuItem_Click);
                if (this._RunWithNetwotkToolStripMenuItem != null)
                    this._RunWithNetwotkToolStripMenuItem.Click -= eventHandler;
                this._RunWithNetwotkToolStripMenuItem = value;
                if (this._RunWithNetwotkToolStripMenuItem == null)
                    return;
                this._RunWithNetwotkToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem PrepareModeToolStripMenuItem
        {
            get => this._PrepareModeToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.PrepareModeToolStripMenuItem_Click);
                if (this._PrepareModeToolStripMenuItem != null)
                    this._PrepareModeToolStripMenuItem.Click -= eventHandler;
                this._PrepareModeToolStripMenuItem = value;
                if (this._PrepareModeToolStripMenuItem == null)
                    return;
                this._PrepareModeToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem ManualInputToolStripMenuItem
        {
            get => this._ManualInputToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ManualInputToolStripMenuItem_Click);
                if (this._ManualInputToolStripMenuItem != null)
                    this._ManualInputToolStripMenuItem.Click -= eventHandler;
                this._ManualInputToolStripMenuItem = value;
                if (this._ManualInputToolStripMenuItem == null)
                    return;
                this._ManualInputToolStripMenuItem.Click += eventHandler;
            }
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

        internal virtual ToolStripMenuItem SetupToolStripMenuItem
        {
            get => this._SetupToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._SetupToolStripMenuItem = value;
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

        internal virtual Label lblDate
        {
            get => this._lblDate;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblDate = value;
        }

        internal virtual Label Label4
        {
            get => this._Label4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label4 = value;
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

        internal virtual Label Label13
        {
            get => this._Label13;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label13 = value;
        }

        internal virtual Label Label14
        {
            get => this._Label14;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label14 = value;
        }

        internal virtual TextBox ControllerName
        {
            get => this._ControllerName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.ControllerName_KeyPress);
                EventHandler eventHandler = new EventHandler(this.ControllerName_Leave);
                if (this._ControllerName != null)
                {
                    this._ControllerName.KeyPress -= pressEventHandler;
                    this._ControllerName.Leave -= eventHandler;
                }
                this._ControllerName = value;
                if (this._ControllerName == null)
                    return;
                this._ControllerName.KeyPress += pressEventHandler;
                this._ControllerName.Leave += eventHandler;
            }
        }

        internal virtual TextBox ControllerClub
        {
            get => this._ControllerClub;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.ControllerClub_KeyPress1);
                EventHandler eventHandler = new EventHandler(this.ControllerClub_Leave);
                if (this._ControllerClub != null)
                {
                    this._ControllerClub.KeyPress -= pressEventHandler;
                    this._ControllerClub.Leave -= eventHandler;
                }
                this._ControllerClub = value;
                if (this._ControllerClub == null)
                    return;
                this._ControllerClub.KeyPress += pressEventHandler;
                this._ControllerClub.Leave += eventHandler;
            }
        }

        internal virtual Label lblJ1
        {
            get => this._lblJ1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblJ1 = value;
        }

        internal virtual Label lblJ2
        {
            get => this._lblJ2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblJ2 = value;
        }

        internal virtual Label lblJ3
        {
            get => this._lblJ3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblJ3 = value;
        }

        internal virtual Label lblJ4
        {
            get => this._lblJ4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblJ4 = value;
        }

        internal virtual Label lblJ5
        {
            get => this._lblJ5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblJ5 = value;
        }

        internal virtual Label lblJ6
        {
            get => this._lblJ6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblJ6 = value;
        }

        internal virtual Label lblJ7
        {
            get => this._lblJ7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblJ7 = value;
        }

        internal virtual TextBox JudgeName1
        {
            get => this._JudgeName1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JudgeName1_KeyPress);
                EventHandler eventHandler = new EventHandler(this.JudgeName1_Leave);
                if (this._JudgeName1 != null)
                {
                    this._JudgeName1.KeyPress -= pressEventHandler;
                    this._JudgeName1.Leave -= eventHandler;
                }
                this._JudgeName1 = value;
                if (this._JudgeName1 == null)
                    return;
                this._JudgeName1.KeyPress += pressEventHandler;
                this._JudgeName1.Leave += eventHandler;
            }
        }

        internal virtual TextBox JudgeName2
        {
            get => this._JudgeName2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JudgeName2_KeyPress);
                EventHandler eventHandler = new EventHandler(this.JudgeName2_Leave);
                if (this._JudgeName2 != null)
                {
                    this._JudgeName2.KeyPress -= pressEventHandler;
                    this._JudgeName2.Leave -= eventHandler;
                }
                this._JudgeName2 = value;
                if (this._JudgeName2 == null)
                    return;
                this._JudgeName2.KeyPress += pressEventHandler;
                this._JudgeName2.Leave += eventHandler;
            }
        }

        internal virtual TextBox JudgeName3
        {
            get => this._JudgeName3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JudgeName3_KeyPress);
                EventHandler eventHandler = new EventHandler(this.JudgeName3_Leave);
                if (this._JudgeName3 != null)
                {
                    this._JudgeName3.KeyPress -= pressEventHandler;
                    this._JudgeName3.Leave -= eventHandler;
                }
                this._JudgeName3 = value;
                if (this._JudgeName3 == null)
                    return;
                this._JudgeName3.KeyPress += pressEventHandler;
                this._JudgeName3.Leave += eventHandler;
            }
        }

        internal virtual TextBox JudgeName4
        {
            get => this._JudgeName4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JudgeName4_KeyPress);
                EventHandler eventHandler = new EventHandler(this.JudgeName4_Leave);
                if (this._JudgeName4 != null)
                {
                    this._JudgeName4.KeyPress -= pressEventHandler;
                    this._JudgeName4.Leave -= eventHandler;
                }
                this._JudgeName4 = value;
                if (this._JudgeName4 == null)
                    return;
                this._JudgeName4.KeyPress += pressEventHandler;
                this._JudgeName4.Leave += eventHandler;
            }
        }

        internal virtual TextBox JudgeName5
        {
            get => this._JudgeName5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JudgeName5_KeyPress);
                EventHandler eventHandler = new EventHandler(this.JudgeName5_Leave);
                if (this._JudgeName5 != null)
                {
                    this._JudgeName5.KeyPress -= pressEventHandler;
                    this._JudgeName5.Leave -= eventHandler;
                }
                this._JudgeName5 = value;
                if (this._JudgeName5 == null)
                    return;
                this._JudgeName5.KeyPress += pressEventHandler;
                this._JudgeName5.Leave += eventHandler;
            }
        }

        internal virtual TextBox JudgeName6
        {
            get => this._JudgeName6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JudgeName6_KeyPress);
                EventHandler eventHandler = new EventHandler(this.JudgeName6_Leave);
                if (this._JudgeName6 != null)
                {
                    this._JudgeName6.KeyPress -= pressEventHandler;
                    this._JudgeName6.Leave -= eventHandler;
                }
                this._JudgeName6 = value;
                if (this._JudgeName6 == null)
                    return;
                this._JudgeName6.KeyPress += pressEventHandler;
                this._JudgeName6.Leave += eventHandler;
            }
        }

        internal virtual TextBox JudgeName7
        {
            get => this._JudgeName7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JudgeName7_KeyPress);
                EventHandler eventHandler = new EventHandler(this.JudgeName7_Leave);
                if (this._JudgeName7 != null)
                {
                    this._JudgeName7.KeyPress -= pressEventHandler;
                    this._JudgeName7.Leave -= eventHandler;
                }
                this._JudgeName7 = value;
                if (this._JudgeName7 == null)
                    return;
                this._JudgeName7.KeyPress += pressEventHandler;
                this._JudgeName7.Leave += eventHandler;
            }
        }

        internal virtual TextBox JudgeClub1
        {
            get => this._JudgeClub1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JudgeClub1_KeyPress);
                EventHandler eventHandler = new EventHandler(this.JudgeClub1_Leave);
                if (this._JudgeClub1 != null)
                {
                    this._JudgeClub1.KeyPress -= pressEventHandler;
                    this._JudgeClub1.Leave -= eventHandler;
                }
                this._JudgeClub1 = value;
                if (this._JudgeClub1 == null)
                    return;
                this._JudgeClub1.KeyPress += pressEventHandler;
                this._JudgeClub1.Leave += eventHandler;
            }
        }

        internal virtual TextBox JudgeClub2
        {
            get => this._JudgeClub2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JudgeClub2_KeyPress);
                EventHandler eventHandler = new EventHandler(this.JudgeClub2_Leave);
                if (this._JudgeClub2 != null)
                {
                    this._JudgeClub2.KeyPress -= pressEventHandler;
                    this._JudgeClub2.Leave -= eventHandler;
                }
                this._JudgeClub2 = value;
                if (this._JudgeClub2 == null)
                    return;
                this._JudgeClub2.KeyPress += pressEventHandler;
                this._JudgeClub2.Leave += eventHandler;
            }
        }

        internal virtual TextBox JudgeClub3
        {
            get => this._JudgeClub3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JudgeClub3_KeyPress);
                EventHandler eventHandler = new EventHandler(this.JudgeClub3_Leave);
                if (this._JudgeClub3 != null)
                {
                    this._JudgeClub3.KeyPress -= pressEventHandler;
                    this._JudgeClub3.Leave -= eventHandler;
                }
                this._JudgeClub3 = value;
                if (this._JudgeClub3 == null)
                    return;
                this._JudgeClub3.KeyPress += pressEventHandler;
                this._JudgeClub3.Leave += eventHandler;
            }
        }

        internal virtual TextBox JudgeClub4
        {
            get => this._JudgeClub4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JudgeClub4_KeyPress);
                EventHandler eventHandler = new EventHandler(this.JudgeClub4_Leave);
                if (this._JudgeClub4 != null)
                {
                    this._JudgeClub4.KeyPress -= pressEventHandler;
                    this._JudgeClub4.Leave -= eventHandler;
                }
                this._JudgeClub4 = value;
                if (this._JudgeClub4 == null)
                    return;
                this._JudgeClub4.KeyPress += pressEventHandler;
                this._JudgeClub4.Leave += eventHandler;
            }
        }

        internal virtual TextBox JudgeClub5
        {
            get => this._JudgeClub5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JudgeClub5_KeyPress);
                EventHandler eventHandler = new EventHandler(this.JudgeClub5_Leave);
                if (this._JudgeClub5 != null)
                {
                    this._JudgeClub5.KeyPress -= pressEventHandler;
                    this._JudgeClub5.Leave -= eventHandler;
                }
                this._JudgeClub5 = value;
                if (this._JudgeClub5 == null)
                    return;
                this._JudgeClub5.KeyPress += pressEventHandler;
                this._JudgeClub5.Leave += eventHandler;
            }
        }

        internal virtual TextBox JudgeClub6
        {
            get => this._JudgeClub6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JudgeClub6_KeyPress);
                EventHandler eventHandler = new EventHandler(this.JudgeClub6_Leave);
                if (this._JudgeClub6 != null)
                {
                    this._JudgeClub6.KeyPress -= pressEventHandler;
                    this._JudgeClub6.Leave -= eventHandler;
                }
                this._JudgeClub6 = value;
                if (this._JudgeClub6 == null)
                    return;
                this._JudgeClub6.KeyPress += pressEventHandler;
                this._JudgeClub6.Leave += eventHandler;
            }
        }

        internal virtual TextBox JudgeClub7
        {
            get => this._JudgeClub7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.JudgeClub7_KeyPress);
                EventHandler eventHandler = new EventHandler(this.JudgeClub7_Leave);
                if (this._JudgeClub7 != null)
                {
                    this._JudgeClub7.KeyPress -= pressEventHandler;
                    this._JudgeClub7.Leave -= eventHandler;
                }
                this._JudgeClub7 = value;
                if (this._JudgeClub7 == null)
                    return;
                this._JudgeClub7.KeyPress += pressEventHandler;
                this._JudgeClub7.Leave += eventHandler;
            }
        }

        internal virtual TextBox TechSpecName
        {
            get => this._TechSpecName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.TechSpecName_KeyPress);
                EventHandler eventHandler = new EventHandler(this.TechSpecName_Leave);
                if (this._TechSpecName != null)
                {
                    this._TechSpecName.KeyPress -= pressEventHandler;
                    this._TechSpecName.Leave -= eventHandler;
                }
                this._TechSpecName = value;
                if (this._TechSpecName == null)
                    return;
                this._TechSpecName.KeyPress += pressEventHandler;
                this._TechSpecName.Leave += eventHandler;
            }
        }

        internal virtual TextBox RefereeName
        {
            get => this._RefereeName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.RefereeName_KeyPress);
                EventHandler eventHandler = new EventHandler(this.RefereeName_Leave);
                if (this._RefereeName != null)
                {
                    this._RefereeName.KeyPress -= pressEventHandler;
                    this._RefereeName.Leave -= eventHandler;
                }
                this._RefereeName = value;
                if (this._RefereeName == null)
                    return;
                this._RefereeName.KeyPress += pressEventHandler;
                this._RefereeName.Leave += eventHandler;
            }
        }

        internal virtual TextBox DVOName1
        {
            get => this._DVOName1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.DVOName1_Leave);
                if (this._DVOName1 != null)
                    this._DVOName1.Leave -= eventHandler;
                this._DVOName1 = value;
                if (this._DVOName1 == null)
                    return;
                this._DVOName1.Leave += eventHandler;
            }
        }

        internal virtual TextBox DVOName2
        {
            get => this._DVOName2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.DVOName2_Leave);
                if (this._DVOName2 != null)
                    this._DVOName2.Leave -= eventHandler;
                this._DVOName2 = value;
                if (this._DVOName2 == null)
                    return;
                this._DVOName2.Leave += eventHandler;
            }
        }

        internal virtual TextBox DVOName3
        {
            get => this._DVOName3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.DVOName3_Leave);
                if (this._DVOName3 != null)
                    this._DVOName3.Leave -= eventHandler;
                this._DVOName3 = value;
                if (this._DVOName3 == null)
                    return;
                this._DVOName3.Leave += eventHandler;
            }
        }

        internal virtual TextBox txtCompetitionName
        {
            get => this._txtCompetitionName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.CompetitionName_KeyPress);
                EventHandler eventHandler1 = new EventHandler(this.txtCompetitionName_Leave);
                EventHandler eventHandler2 = new EventHandler(this.txtCompetitionName_TextChanged);
                if (this._txtCompetitionName != null)
                {
                    this._txtCompetitionName.KeyPress -= pressEventHandler;
                    this._txtCompetitionName.Leave -= eventHandler1;
                    this._txtCompetitionName.TextChanged -= eventHandler2;
                }
                this._txtCompetitionName = value;
                if (this._txtCompetitionName == null)
                    return;
                this._txtCompetitionName.KeyPress += pressEventHandler;
                this._txtCompetitionName.Leave += eventHandler1;
                this._txtCompetitionName.TextChanged += eventHandler2;
            }
        }

        internal virtual TextBox txtCategory
        {
            get => this._txtCategory;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtCategory = value;
        }

        internal virtual TextBox txtDate
        {
            get => this._txtDate;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtDate = value;
        }

        internal virtual TextBox txtStartTime
        {
            get => this._txtStartTime;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtStartTime = value;
        }

        internal virtual TextBox txtNoOfJudges
        {
            get => this._txtNoOfJudges;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtNoOfJudges = value;
        }

        internal virtual TextBox txtNoOfTrJ
        {
            get => this._txtNoOfTrJ;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtNoOfTrJ = value;
        }

        internal virtual Label Label22
        {
            get => this._Label22;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label22 = value;
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

        internal virtual Label Label27
        {
            get => this._Label27;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label27 = value;
        }

        internal virtual TextBox TechSpecClub
        {
            get => this._TechSpecClub;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.TechSpecClub_KeyPress);
                EventHandler eventHandler = new EventHandler(this.TechSpecClub_Leave);
                if (this._TechSpecClub != null)
                {
                    this._TechSpecClub.KeyPress -= pressEventHandler;
                    this._TechSpecClub.Leave -= eventHandler;
                }
                this._TechSpecClub = value;
                if (this._TechSpecClub == null)
                    return;
                this._TechSpecClub.KeyPress += pressEventHandler;
                this._TechSpecClub.Leave += eventHandler;
            }
        }

        internal virtual TextBox RefereeClub
        {
            get => this._RefereeClub;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.RefereeClub_KeyPress);
                EventHandler eventHandler = new EventHandler(this.RefereeClub_Leave);
                if (this._RefereeClub != null)
                {
                    this._RefereeClub.KeyPress -= pressEventHandler;
                    this._RefereeClub.Leave -= eventHandler;
                }
                this._RefereeClub = value;
                if (this._RefereeClub == null)
                    return;
                this._RefereeClub.KeyPress += pressEventHandler;
                this._RefereeClub.Leave += eventHandler;
            }
        }

        internal virtual TextBox DVOClub1
        {
            get => this._DVOClub1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.DVOClub1_Leave);
                if (this._DVOClub1 != null)
                    this._DVOClub1.Leave -= eventHandler;
                this._DVOClub1 = value;
                if (this._DVOClub1 == null)
                    return;
                this._DVOClub1.Leave += eventHandler;
            }
        }

        internal virtual TextBox DVOClub2
        {
            get => this._DVOClub2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.DVOClub2_Leave);
                if (this._DVOClub2 != null)
                    this._DVOClub2.Leave -= eventHandler;
                this._DVOClub2 = value;
                if (this._DVOClub2 == null)
                    return;
                this._DVOClub2.Leave += eventHandler;
            }
        }

        internal virtual TextBox DVOClub3
        {
            get => this._DVOClub3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.DVOClub3_Leave);
                if (this._DVOClub3 != null)
                    this._DVOClub3.Leave -= eventHandler;
                this._DVOClub3 = value;
                if (this._DVOClub3 == null)
                    return;
                this._DVOClub3.Leave += eventHandler;
            }
        }

        internal virtual Label lblStart
        {
            get => this._lblStart;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblStart = value;
        }

        internal virtual TextBox txtSubcategory
        {
            get => this._txtSubcategory;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtSubcategory = value;
        }

        internal virtual TextBox txtSegment
        {
            get => this._txtSegment;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtSegment = value;
        }

        internal virtual Label Label29
        {
            get => this._Label29;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label29 = value;
        }

        internal virtual TextBox Mode
        {
            get => this._Mode;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Mode = value;
        }

        internal virtual ToolStripMenuItem OpenDBToolStripMenuItem
        {
            get => this._OpenDBToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.OpenDBToolStripMenuItem_Click);
                if (this._OpenDBToolStripMenuItem != null)
                    this._OpenDBToolStripMenuItem.Click -= eventHandler;
                this._OpenDBToolStripMenuItem = value;
                if (this._OpenDBToolStripMenuItem == null)
                    return;
                this._OpenDBToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem DBToolStripMenuItem
        {
            get => this._DBToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.DBToolStripMenuItem_Click);
                if (this._DBToolStripMenuItem != null)
                    this._DBToolStripMenuItem.Click -= eventHandler;
                this._DBToolStripMenuItem = value;
                if (this._DBToolStripMenuItem == null)
                    return;
                this._DBToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem NetworkToolStripMenuItem
        {
            get => this._NetworkToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.NetworkToolStripMenuItem_Click);
                if (this._NetworkToolStripMenuItem != null)
                    this._NetworkToolStripMenuItem.Click -= eventHandler;
                this._NetworkToolStripMenuItem = value;
                if (this._NetworkToolStripMenuItem == null)
                    return;
                this._NetworkToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual OpenFileDialog OpenFileDialog1
        {
            get => this._OpenFileDialog1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._OpenFileDialog1 = value;
        }

        internal virtual TextBox txtNonJudgingReferee
        {
            get => this._txtNonJudgingReferee;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtNonJudgingReferee = value;
        }

        internal virtual ToolStripMenuItem CategorySelectionToolStripMenuItem
        {
            get => this._CategorySelectionToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.CategorySelectionToolStripMenuItem_Click);
                if (this._CategorySelectionToolStripMenuItem != null)
                    this._CategorySelectionToolStripMenuItem.Click -= eventHandler;
                this._CategorySelectionToolStripMenuItem = value;
                if (this._CategorySelectionToolStripMenuItem == null)
                    return;
                this._CategorySelectionToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem JudgesSetupToolStripMenuItem
        {
            get => this._JudgesSetupToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.JudgesSetupToolStripMenuItem_Click);
                if (this._JudgesSetupToolStripMenuItem != null)
                    this._JudgesSetupToolStripMenuItem.Click -= eventHandler;
                this._JudgesSetupToolStripMenuItem = value;
                if (this._JudgesSetupToolStripMenuItem == null)
                    return;
                this._JudgesSetupToolStripMenuItem.Click += eventHandler;
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

        internal virtual ToolStripMenuItem HeadPageToolStripMenuItem
        {
            get => this._HeadPageToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.HeadPageToolStripMenuItem_Click);
                if (this._HeadPageToolStripMenuItem != null)
                    this._HeadPageToolStripMenuItem.Click -= eventHandler;
                this._HeadPageToolStripMenuItem = value;
                if (this._HeadPageToolStripMenuItem == null)
                    return;
                this._HeadPageToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem HeadPageToolStripMenuItem1
        {
            get => this._HeadPageToolStripMenuItem1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.HeadPageToolStripMenuItem1_Click);
                if (this._HeadPageToolStripMenuItem1 != null)
                    this._HeadPageToolStripMenuItem1.Click -= eventHandler;
                this._HeadPageToolStripMenuItem1 = value;
                if (this._HeadPageToolStripMenuItem1 == null)
                    return;
                this._HeadPageToolStripMenuItem1.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem StartListToolStripMenuItem1
        {
            get => this._StartListToolStripMenuItem1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.StartListToolStripMenuItem1_Click);
                if (this._StartListToolStripMenuItem1 != null)
                    this._StartListToolStripMenuItem1.Click -= eventHandler;
                this._StartListToolStripMenuItem1 = value;
                if (this._StartListToolStripMenuItem1 == null)
                    return;
                this._StartListToolStripMenuItem1.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem JudgesDetailsToolStripMenuItem
        {
            get => this._JudgesDetailsToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.JudgesDetailsToolStripMenuItem_Click_1);
                if (this._JudgesDetailsToolStripMenuItem != null)
                    this._JudgesDetailsToolStripMenuItem.Click -= eventHandler;
                this._JudgesDetailsToolStripMenuItem = value;
                if (this._JudgesDetailsToolStripMenuItem == null)
                    return;
                this._JudgesDetailsToolStripMenuItem.Click += eventHandler;
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

        internal virtual ToolStripMenuItem TCTSCardToolStripMenuItem
        {
            get => this._TCTSCardToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.TCTSCardToolStripMenuItem_Click);
                if (this._TCTSCardToolStripMenuItem != null)
                    this._TCTSCardToolStripMenuItem.Click -= eventHandler;
                this._TCTSCardToolStripMenuItem = value;
                if (this._TCTSCardToolStripMenuItem == null)
                    return;
                this._TCTSCardToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem TCSCardForBothTCAndTCToolStripMenuItem
        {
            get => this._TCSCardForBothTCAndTCToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.TCSCardForBothTCAndTCToolStripMenuItem_Click);
                if (this._TCSCardForBothTCAndTCToolStripMenuItem != null)
                    this._TCSCardForBothTCAndTCToolStripMenuItem.Click -= eventHandler;
                this._TCSCardForBothTCAndTCToolStripMenuItem = value;
                if (this._TCSCardForBothTCAndTCToolStripMenuItem == null)
                    return;
                this._TCSCardForBothTCAndTCToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem TCTSCardForASelectedSkaterToolStripMenuItem
        {
            get => this._TCTSCardForASelectedSkaterToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.TCTSCardForASelectedSkaterToolStripMenuItem_Click);
                if (this._TCTSCardForASelectedSkaterToolStripMenuItem != null)
                    this._TCTSCardForASelectedSkaterToolStripMenuItem.Click -= eventHandler;
                this._TCTSCardForASelectedSkaterToolStripMenuItem = value;
                if (this._TCTSCardForASelectedSkaterToolStripMenuItem == null)
                    return;
                this._TCTSCardForASelectedSkaterToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem JudgeCardsFörOneJudgeToolStripMenuItem
        {
            get => this._JudgeCardsFörOneJudgeToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.JudgeCardsForOneJudgeToolStripMenuItem_Click);
                if (this._JudgeCardsFörOneJudgeToolStripMenuItem != null)
                    this._JudgeCardsFörOneJudgeToolStripMenuItem.Click -= eventHandler;
                this._JudgeCardsFörOneJudgeToolStripMenuItem = value;
                if (this._JudgeCardsFörOneJudgeToolStripMenuItem == null)
                    return;
                this._JudgeCardsFörOneJudgeToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem JudgeCardForAllSkatersToolStripMenuItem
        {
            get => this._JudgeCardForAllSkatersToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.JudgeCardForAllSkatersToolStripMenuItem_Click);
                if (this._JudgeCardForAllSkatersToolStripMenuItem != null)
                    this._JudgeCardForAllSkatersToolStripMenuItem.Click -= eventHandler;
                this._JudgeCardForAllSkatersToolStripMenuItem = value;
                if (this._JudgeCardForAllSkatersToolStripMenuItem == null)
                    return;
                this._JudgeCardForAllSkatersToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem JusgeCardsForASelectedSkaterToolStripMenuItem
        {
            get => this._JusgeCardsForASelectedSkaterToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.JusgeCardsForASelectedSkaterToolStripMenuItem_Click);
                if (this._JusgeCardsForASelectedSkaterToolStripMenuItem != null)
                    this._JusgeCardsForASelectedSkaterToolStripMenuItem.Click -= eventHandler;
                this._JusgeCardsForASelectedSkaterToolStripMenuItem = value;
                if (this._JusgeCardsForASelectedSkaterToolStripMenuItem == null)
                    return;
                this._JusgeCardsForASelectedSkaterToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem
        {
            get => this._JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem_Click);
                if (this._JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem != null)
                    this._JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem.Click -= eventHandler;
                this._JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem = value;
                if (this._JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem == null)
                    return;
                this._JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem PrintAllResultDocumentsCategoryToolStripMenuItem
        {
            get => this._PrintAllResultDocumentsCategoryToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.PrintAllResultDocumentsCategoryToolStripMenuItem_Click);
                if (this._PrintAllResultDocumentsCategoryToolStripMenuItem != null)
                    this._PrintAllResultDocumentsCategoryToolStripMenuItem.Click -= eventHandler;
                this._PrintAllResultDocumentsCategoryToolStripMenuItem = value;
                if (this._PrintAllResultDocumentsCategoryToolStripMenuItem == null)
                    return;
                this._PrintAllResultDocumentsCategoryToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem ResultsToolStripMenuItem
        {
            get => this._ResultsToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ResultsToolStripMenuItem_Click);
                if (this._ResultsToolStripMenuItem != null)
                    this._ResultsToolStripMenuItem.Click -= eventHandler;
                this._ResultsToolStripMenuItem = value;
                if (this._ResultsToolStripMenuItem == null)
                    return;
                this._ResultsToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem CREATEFILESToolStripMenuItem
        {
            get => this._CREATEFILESToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._CREATEFILESToolStripMenuItem = value;
        }

        internal virtual ToolStripMenuItem ResultsPDFfilesToolStripMenuItem
        {
            get => this._ResultsPDFfilesToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.ResultsPDFfilesToolStripMenuItem_Click);
                if (this._ResultsPDFfilesToolStripMenuItem != null)
                    this._ResultsPDFfilesToolStripMenuItem.Click -= eventHandler;
                this._ResultsPDFfilesToolStripMenuItem = value;
                if (this._ResultsPDFfilesToolStripMenuItem == null)
                    return;
                this._ResultsPDFfilesToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem HeadPageToolStripMenuItem2
        {
            get => this._HeadPageToolStripMenuItem2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.HeadPageToolStripMenuItem2_Click);
                if (this._HeadPageToolStripMenuItem2 != null)
                    this._HeadPageToolStripMenuItem2.Click -= eventHandler;
                this._HeadPageToolStripMenuItem2 = value;
                if (this._HeadPageToolStripMenuItem2 == null)
                    return;
                this._HeadPageToolStripMenuItem2.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem
        {
            get => this._JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem_Click);
                if (this._JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem != null)
                    this._JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem.Click -= eventHandler;
                this._JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem = value;
                if (this._JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem == null)
                    return;
                this._JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem AllFilesToolStripMenuItem
        {
            get => this._AllFilesToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.AllFilesToolStripMenuItem_Click);
                if (this._AllFilesToolStripMenuItem != null)
                    this._AllFilesToolStripMenuItem.Click -= eventHandler;
                this._AllFilesToolStripMenuItem = value;
                if (this._AllFilesToolStripMenuItem == null)
                    return;
                this._AllFilesToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual Button btnSeg1
        {
            get => this._btnSeg1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnSeg1_Click);
                if (this._btnSeg1 != null)
                    this._btnSeg1.Click -= eventHandler;
                this._btnSeg1 = value;
                if (this._btnSeg1 == null)
                    return;
                this._btnSeg1.Click += eventHandler;
            }
        }

        internal virtual Button btnSeg2
        {
            get => this._btnSeg2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.btnSeg2_Click);
                if (this._btnSeg2 != null)
                    this._btnSeg2.Click -= eventHandler;
                this._btnSeg2 = value;
                if (this._btnSeg2 == null)
                    return;
                this._btnSeg2.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem SHOWRESULTSToolStripMenuItem
        {
            get => this._SHOWRESULTSToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.SHOWRESULTSToolStripMenuItem_Click);
                if (this._SHOWRESULTSToolStripMenuItem != null)
                    this._SHOWRESULTSToolStripMenuItem.Click -= eventHandler;
                this._SHOWRESULTSToolStripMenuItem = value;
                if (this._SHOWRESULTSToolStripMenuItem == null)
                    return;
                this._SHOWRESULTSToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual Label Label30
        {
            get => this._Label30;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label30 = value;
        }

        internal virtual TextBox txtParticipants
        {
            get => this._txtParticipants;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtParticipants = value;
        }

        internal virtual ToolStripMenuItem PingTheNetworkToolStripMenuItem
        {
            get => this._PingTheNetworkToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.PingTheNetworkToolStripMenuItem_Click);
                if (this._PingTheNetworkToolStripMenuItem != null)
                    this._PingTheNetworkToolStripMenuItem.Click -= eventHandler;
                this._PingTheNetworkToolStripMenuItem = value;
                if (this._PingTheNetworkToolStripMenuItem == null)
                    return;
                this._PingTheNetworkToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual Label Label31
        {
            get => this._Label31;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label31 = value;
        }

        internal virtual ToolStripMenuItem EntriesToolStripMenuItem
        {
            get => this._EntriesToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.EntriesToolStripMenuItem_Click);
                if (this._EntriesToolStripMenuItem != null)
                    this._EntriesToolStripMenuItem.Click -= eventHandler;
                this._EntriesToolStripMenuItem = value;
                if (this._EntriesToolStripMenuItem == null)
                    return;
                this._EntriesToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem SaveToolStripMenuItem
        {
            get => this._SaveToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.SaveToolStripMenuItem_Click);
                if (this._SaveToolStripMenuItem != null)
                    this._SaveToolStripMenuItem.Click -= eventHandler;
                this._SaveToolStripMenuItem = value;
                if (this._SaveToolStripMenuItem == null)
                    return;
                this._SaveToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.Timer Timer2
        {
            get => this._Timer2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Timer2_Tick);
                if (this._Timer2 != null)
                    this._Timer2.Tick -= eventHandler;
                this._Timer2 = value;
                if (this._Timer2 == null)
                    return;
                this._Timer2.Tick += eventHandler;
            }
        }

        internal virtual Label lblCC_El
        {
            get => this._lblCC_El;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblCC_El = value;
        }

        internal virtual ToolStripSeparator ToolStripSeparator1
        {
            get => this._ToolStripSeparator1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ToolStripSeparator1 = value;
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

        internal virtual ToolStripSeparator ToolStripSeparator4
        {
            get => this._ToolStripSeparator4;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ToolStripSeparator4 = value;
        }

        internal virtual ToolStripSeparator ToolStripSeparator5
        {
            get => this._ToolStripSeparator5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ToolStripSeparator5 = value;
        }

        internal virtual ToolStripSeparator ToolStripSeparator6
        {
            get => this._ToolStripSeparator6;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ToolStripSeparator6 = value;
        }

        internal virtual PictureBox PictureBox1
        {
            get => this._PictureBox1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._PictureBox1 = value;
        }

        internal virtual BackgroundWorker BackgroundWorker2
        {
            get => this._BackgroundWorker2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker2_RunWorkerCompleted);
                DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker2_DoWork);
                if (this._BackgroundWorker2 != null)
                {
                    this._BackgroundWorker2.RunWorkerCompleted -= completedEventHandler;
                    this._BackgroundWorker2.DoWork -= workEventHandler;
                }
                this._BackgroundWorker2 = value;
                if (this._BackgroundWorker2 == null)
                    return;
                this._BackgroundWorker2.RunWorkerCompleted += completedEventHandler;
                this._BackgroundWorker2.DoWork += workEventHandler;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator7
        {
            get => this._ToolStripSeparator7;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ToolStripSeparator7 = value;
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

        internal virtual BackgroundWorker BackgroundWorker5
        {
            get => this._BackgroundWorker5;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker5_RunWorkerCompleted);
                DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker5_DoWork);
                if (this._BackgroundWorker5 != null)
                {
                    this._BackgroundWorker5.RunWorkerCompleted -= completedEventHandler;
                    this._BackgroundWorker5.DoWork -= workEventHandler;
                }
                this._BackgroundWorker5 = value;
                if (this._BackgroundWorker5 == null)
                    return;
                this._BackgroundWorker5.RunWorkerCompleted += completedEventHandler;
                this._BackgroundWorker5.DoWork += workEventHandler;
            }
        }

        internal virtual ToolStripMenuItem COPYOFFICIALSToolStripMenuItem
        {
            get => this._COPYOFFICIALSToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.COPYOFFICIALSToolStripMenuItem_Click);
                if (this._COPYOFFICIALSToolStripMenuItem != null)
                    this._COPYOFFICIALSToolStripMenuItem.Click -= eventHandler;
                this._COPYOFFICIALSToolStripMenuItem = value;
                if (this._COPYOFFICIALSToolStripMenuItem == null)
                    return;
                this._COPYOFFICIALSToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual Label lblSeg2
        {
            get => this._lblSeg2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblSeg2 = value;
        }

        internal virtual Label lblSeg1
        {
            get => this._lblSeg1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblSeg1 = value;
        }

        internal virtual ToolStripMenuItem EntriesToolStripMenuItem1
        {
            get => this._EntriesToolStripMenuItem1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.EntriesToolStripMenuItem1_Click);
                if (this._EntriesToolStripMenuItem1 != null)
                    this._EntriesToolStripMenuItem1.Click -= eventHandler;
                this._EntriesToolStripMenuItem1 = value;
                if (this._EntriesToolStripMenuItem1 == null)
                    return;
                this._EntriesToolStripMenuItem1.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem StartListToolStripMenuItem
        {
            get => this._StartListToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.StartListToolStripMenuItem_Click);
                if (this._StartListToolStripMenuItem != null)
                    this._StartListToolStripMenuItem.Click -= eventHandler;
                this._StartListToolStripMenuItem = value;
                if (this._StartListToolStripMenuItem == null)
                    return;
                this._StartListToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem CREATEPDFFILESToolStripMenuItem
        {
            get => this._CREATEPDFFILESToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._CREATEPDFFILESToolStripMenuItem = value;
        }

        internal virtual ToolStripMenuItem EntriesToolStripMenuItem2
        {
            get => this._EntriesToolStripMenuItem2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.EntriesToolStripMenuItem2_Click);
                if (this._EntriesToolStripMenuItem2 != null)
                    this._EntriesToolStripMenuItem2.Click -= eventHandler;
                this._EntriesToolStripMenuItem2 = value;
                if (this._EntriesToolStripMenuItem2 == null)
                    return;
                this._EntriesToolStripMenuItem2.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem StartListToolStripMenuItem2
        {
            get => this._StartListToolStripMenuItem2;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.StartListToolStripMenuItem2_Click);
                if (this._StartListToolStripMenuItem2 != null)
                    this._StartListToolStripMenuItem2.Click -= eventHandler;
                this._StartListToolStripMenuItem2 = value;
                if (this._StartListToolStripMenuItem2 == null)
                    return;
                this._StartListToolStripMenuItem2.Click += eventHandler;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator8
        {
            get => this._ToolStripSeparator8;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ToolStripSeparator8 = value;
        }

        internal virtual ToolStripMenuItem UnhudeJudgesDisplayToolStripMenuItem
        {
            get => this._UnhudeJudgesDisplayToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.UnhudeJudgesDisplayToolStripMenuItem_Click);
                if (this._UnhudeJudgesDisplayToolStripMenuItem != null)
                    this._UnhudeJudgesDisplayToolStripMenuItem.Click -= eventHandler;
                this._UnhudeJudgesDisplayToolStripMenuItem = value;
                if (this._UnhudeJudgesDisplayToolStripMenuItem == null)
                    return;
                this._UnhudeJudgesDisplayToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripMenuItem HideJudgesComputersToolStripMenuItem
        {
            get => this._HideJudgesComputersToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.HideJudgesComputersToolStripMenuItem_Click);
                if (this._HideJudgesComputersToolStripMenuItem != null)
                    this._HideJudgesComputersToolStripMenuItem.Click -= eventHandler;
                this._HideJudgesComputersToolStripMenuItem = value;
                if (this._HideJudgesComputersToolStripMenuItem == null)
                    return;
                this._HideJudgesComputersToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual ToolStripSeparator ToolStripSeparator9
        {
            get => this._ToolStripSeparator9;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._ToolStripSeparator9 = value;
        }

        internal virtual System.Windows.Forms.Timer Timer3
        {
            get => this._Timer3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Timer3_Tick);
                if (this._Timer3 != null)
                    this._Timer3.Tick -= eventHandler;
                this._Timer3 = value;
                if (this._Timer3 == null)
                    return;
                this._Timer3.Tick += eventHandler;
            }
        }

        internal virtual System.Windows.Forms.Timer Timer10
        {
            get => this._Timer10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.Timer10_Tick);
                if (this._Timer10 != null)
                    this._Timer10.Tick -= eventHandler;
                this._Timer10 = value;
                if (this._Timer10 == null)
                    return;
                this._Timer10.Tick += eventHandler;
            }
        }

        internal virtual BackgroundWorker BackgroundWorker10
        {
            get => this._BackgroundWorker10;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker10_RunWorkerCompleted);
                DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker10_DoWork);
                if (this._BackgroundWorker10 != null)
                {
                    this._BackgroundWorker10.RunWorkerCompleted -= completedEventHandler;
                    this._BackgroundWorker10.DoWork -= workEventHandler;
                }
                this._BackgroundWorker10 = value;
                if (this._BackgroundWorker10 == null)
                    return;
                this._BackgroundWorker10.RunWorkerCompleted += completedEventHandler;
                this._BackgroundWorker10.DoWork += workEventHandler;
            }
        }

        internal virtual BackgroundWorker BackgroundWorker1
        {
            get => this._BackgroundWorker1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
                DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker1_DoWork);
                if (this._BackgroundWorker1 != null)
                {
                    this._BackgroundWorker1.RunWorkerCompleted -= completedEventHandler;
                    this._BackgroundWorker1.DoWork -= workEventHandler;
                }
                this._BackgroundWorker1 = value;
                if (this._BackgroundWorker1 == null)
                    return;
                this._BackgroundWorker1.RunWorkerCompleted += completedEventHandler;
                this._BackgroundWorker1.DoWork += workEventHandler;
            }
        }

        internal virtual BackgroundWorker BackgroundWorker3
        {
            get => this._BackgroundWorker3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                RunWorkerCompletedEventHandler completedEventHandler = new RunWorkerCompletedEventHandler(this.BackgroundWorker3_RunWorkerCompleted);
                DoWorkEventHandler workEventHandler = new DoWorkEventHandler(this.BackgroundWorker3_DoWork);
                if (this._BackgroundWorker3 != null)
                {
                    this._BackgroundWorker3.RunWorkerCompleted -= completedEventHandler;
                    this._BackgroundWorker3.DoWork -= workEventHandler;
                }
                this._BackgroundWorker3 = value;
                if (this._BackgroundWorker3 == null)
                    return;
                this._BackgroundWorker3.RunWorkerCompleted += completedEventHandler;
                this._BackgroundWorker3.DoWork += workEventHandler;
            }
        }

        internal virtual System.Windows.Forms.Timer Timer1
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

        internal virtual Label lblCC_Info
        {
            get => this._lblCC_Info;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblCC_Info = value;
        }

        internal virtual ToolStripMenuItem JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem
        {
            get => this._JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem_Click);
                if (this._JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem != null)
                    this._JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem.Click -= eventHandler;
                this._JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem = value;
                if (this._JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem == null)
                    return;
                this._JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem.Click += eventHandler;
            }
        }

        internal virtual Label Label3
        {
            get => this._Label3;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label3 = value;
        }

        internal virtual TextBox txtCompetitionID
        {
            get => this._txtCompetitionID;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.txtCompetitionID_Leave);
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtCompetitionID_KeyPress);
                if (this._txtCompetitionID != null)
                {
                    this._txtCompetitionID.Leave -= eventHandler;
                    this._txtCompetitionID.KeyPress -= pressEventHandler;
                }
                this._txtCompetitionID = value;
                if (this._txtCompetitionID == null)
                    return;
                this._txtCompetitionID.Leave += eventHandler;
                this._txtCompetitionID.KeyPress += pressEventHandler;
            }
        }

        internal virtual Label Label17
        {
            get => this._Label17;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label17 = value;
        }

        internal virtual TextBox txtCategoryID
        {
            get => this._txtCategoryID;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtCategoryID = value;
        }

        internal virtual Label Label16
        {
            get => this._Label16;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label16 = value;
        }

        internal virtual Label Label15
        {
            get => this._Label15;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label15 = value;
        }

        internal virtual TextBox txtOrganizerID
        {
            get => this._txtOrganizerID;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler = new EventHandler(this.txtOrganizerID_Leave);
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtOrganizerID_KeyPress);
                if (this._txtOrganizerID != null)
                {
                    this._txtOrganizerID.Leave -= eventHandler;
                    this._txtOrganizerID.KeyPress -= pressEventHandler;
                }
                this._txtOrganizerID = value;
                if (this._txtOrganizerID == null)
                    return;
                this._txtOrganizerID.Leave += eventHandler;
                this._txtOrganizerID.KeyPress += pressEventHandler;
            }
        }

        internal virtual TextBox txtOrganizerName
        {
            get => this._txtOrganizerName;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                EventHandler eventHandler1 = new EventHandler(this.txtOrganizerName_TextChanged);
                EventHandler eventHandler2 = new EventHandler(this.txtOrganizerName_Leave);
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtOrganizerName_KeyPress);
                if (this._txtOrganizerName != null)
                {
                    this._txtOrganizerName.TextChanged -= eventHandler1;
                    this._txtOrganizerName.Leave -= eventHandler2;
                    this._txtOrganizerName.KeyPress -= pressEventHandler;
                }
                this._txtOrganizerName = value;
                if (this._txtOrganizerName == null)
                    return;
                this._txtOrganizerName.TextChanged += eventHandler1;
                this._txtOrganizerName.Leave += eventHandler2;
                this._txtOrganizerName.KeyPress += pressEventHandler;
            }
        }

        internal virtual Label Label18
        {
            get => this._Label18;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label18 = value;
        }

        internal virtual Label Label19
        {
            get => this._Label19;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label19 = value;
        }

        internal virtual TextBox txtType
        {
            get => this._txtType;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.txtType_KeyPress);
                EventHandler eventHandler1 = new EventHandler(this.txtType_Leave);
                EventHandler eventHandler2 = new EventHandler(this.txtType_TextChanged);
                if (this._txtType != null)
                {
                    this._txtType.KeyPress -= pressEventHandler;
                    this._txtType.Leave -= eventHandler1;
                    this._txtType.TextChanged -= eventHandler2;
                }
                this._txtType = value;
                if (this._txtType == null)
                    return;
                this._txtType.KeyPress += pressEventHandler;
                this._txtType.Leave += eventHandler1;
                this._txtType.TextChanged += eventHandler2;
            }
        }

        internal virtual Label lblCC_MP
        {
            get => this._lblCC_MP;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._lblCC_MP = value;
        }

        internal virtual TextBox txtIndTADiscipline
        {
            get => this._txtIndTADiscipline;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtIndTADiscipline = value;
        }

        internal virtual TextBox txtIndTAClass
        {
            get => this._txtIndTAClass;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtIndTAClass = value;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Module1.CategoryFileSaved | !this.completed5)
            {
                if (Interaction.MsgBox((object)"All started jobs are not yet finished!\r\nDo you really want to exit?", MsgBoxStyle.Exclamation | MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    this.CloseFormsDialogs();
                }
            }
            else
            {
                if (this.WillExit)
                    return;
                if (Interaction.MsgBox((object)"Do you really want to Exit ClubCompFS?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    this.CloseFormsDialogs();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Module1.Vek = new Module1.Participant[43];
            Application.CurrentCulture = new CultureInfo("sv-SE");
            this.Text = "ClubCompFS Single ver. 10.0.6, 2019-01-12";
            if (MyProject.Computer.Info.OSFullName.Contains("XP"))
            {
                Module1.HC = 39;
                Module1.WC = 10;
                Module1.WC1 = 15;
                Module1.WC2 = 25;
            }
            else
            {
                Module1.HC = 42;
                Module1.WC = 20;
                Module1.WC1 = 20;
                Module1.WC2 = 40;
            }
            int num1 = 0;
            int num2 = 0;
            using (Graphics graphics = this.CreateGraphics())
            {
                num1 = checked((int)Math.Round((double)graphics.DpiX));
                num2 = checked((int)Math.Round((double)graphics.DpiY));
            }
            if (num1 != 96 | num2 != 96 && Interaction.MsgBox((object)"Please change the font scale to 100% (96 DPI)!\r\nDo you want to quit?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.Yes)
                this.Close();
            Module1.TimeLimit(File.GetCreationTime(Application.ExecutablePath).ToString("yyyy-MM-dd"));
            Module1.TimeLimit(File.GetLastWriteTime(Application.ExecutablePath).ToString("yyyy-MM-dd"));
            DateTime dateTime = DateTime.Now;
            dateTime = dateTime.Date;
            Module1.TimeLimit(dateTime.ToString("yyyy-MM-dd"));
            this.InitJudgeComp();
            if (Module1.GetIniData("CLUBCOMP.INI"))
            {
                this.InitVariables();
                Module1.CreateForm1();
                Module1.LoadOpenDB("OpenDB.xml");
                this.LoadElementDB("ElementDB.xml");
                Module1.SetWorkMode(2);
                this.EnableTextboxes(false);
                this.btnSeg1Seg2();
                this.KeyPreview = true;
                this.StartServer();
                this.Timer3.Enabled = Module1.PingClients == 1;
            }
            this.Left = checked((int)Math.Round(unchecked((double)checked(Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2.0)));
            this.Top = 0;
        }

        private void InitJudgeComp()
        {
            int index = 1;
            do
            {
                Module1.JudgeCompNo[index] = index;
                Module1.JudgeCompFunc[index] = 2;
                checked { ++index; }
            }
            while (index <= 7);
        }

        private void CloseFormsDialogs()
        {
            MyProject.Forms.Form2.WillExitForm2 = true;
            MyProject.Forms.Form4.WillExitForm4 = true;
            MyProject.Forms.Form5.WillExit = true;
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form2))
                MyProject.Forms.Form2.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form3))
                MyProject.Forms.Form3.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form13))
                MyProject.Forms.Form13.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form4))
                MyProject.Forms.Form4.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form5))
                MyProject.Forms.Form5.Close();
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
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form12))
                MyProject.Forms.Form12.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.Dialog7))
                MyProject.Forms.Dialog7.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.Dialog8))
                MyProject.Forms.Dialog8.Close();
            if (Module1.IsFormOpen((Form)MyProject.Forms.InputJudgesDataDialog))
                MyProject.Forms.InputJudgesDataDialog.Close();
            if (!Module1.IsFormOpen((Form)MyProject.Forms.Dialog11))
                return;
            MyProject.Forms.Dialog11.Close();
        }

        private void LoadCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible())
                return;
            this.LoadCategory();
        }

        public void LoadCategory()
        {
            Stream stream = (Stream)null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (!this.completed5)
            {
                Module1.PrinterMessage();
            }
            else
            {
                openFileDialog.Title = "LOAD A COMPETITION FILE";
                openFileDialog.InitialDirectory = Module1.PathCompFile;
                openFileDialog.Filter = "Competition files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                this.Loading = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (Module1.WorkMode == 1)
                        {
                            this.txtCompetitionName.Select();
                            if (Strings.Len(Module1.Competition.Name) > 0 & Strings.Len(Module1.Category.Name) > 0)
                                Module1.SaveCategoryFile(Module1.CategoryFileName);
                        }
                        this.CloseFormsDialogs();
                        this.InitVariables();
                        stream = openFileDialog.OpenFile();
                        if (stream != null)
                        {
                            Module1.CategoryFileName = openFileDialog.FileName;
                            Module1.TimeLimit(File.GetCreationTime(Module1.CategoryFileName).ToString("yyyy-MM-dd"));
                            Module1.LoadXML_DB(openFileDialog.FileName);
                            Module1.CalcPCindex();
                            switch (Module1.WorkMode)
                            {
                                case 1:
                                    this.EnableTextboxes(true);
                                    break;
                                case 2:
                                case 3:
                                    this.EnableTextboxes(false);
                                    break;
                                default:
                                    this.EnableTextboxes(false);
                                    break;
                            }
                            string seg = Module1.GetSeg();
                            if (Operators.CompareString(seg, "SF", false) == 0)
                            {
                                Module1.Segment = this.Testsegment();
                                this.TestOfficials();
                            }
                            else if (Operators.CompareString(seg, "FF", false) == 0)
                            {
                                Module1.Segment = this.Testsegment();
                                this.TestOfficials();
                            }
                            else if (Operators.CompareString(seg, "SS", false) == 0)
                            {
                                Module1.Segment = this.Testsegment();
                                this.TestOfficials();
                            }
                            else if (Operators.CompareString(seg, "S0", false) == 0)
                                Module1.Segment = "Seg1";
                            else if (Operators.CompareString(seg, "0F", false) == 0)
                                Module1.Segment = "Seg2";
                            else if (Operators.CompareString(seg, "F0", false) == 0)
                                Module1.Segment = "Seg1";
                            Module1.SetNoJ();
                            Module1.CreateForm1();
                            this.btnSeg1Seg2();
                            if (Module1.CreateTEScores > 0)
                            {
                                Module1.TE_Leader = "0";
                                Module1.MakeTEScore(Module1.TE_Leader, "0", "0");
                            }
                        }
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
                this.Loading = false;
            }
        }

        public void TestOfficials()
        {
            if (Strings.Len(Module1.Referee.Seg1.Name) == 0 & Strings.Len(Module1.Referee.Seg2.Name) > 0 | Strings.Len(Module1.Controller.Seg1.Name) == 0 & Strings.Len(Module1.Controller.Seg2.Name) > 0 | Strings.Len(Module1.Techspec.Seg1.Name) == 0 & Strings.Len(Module1.Techspec.Seg2.Name) > 0)
            {
                int num1 = (int)Interaction.MsgBox((object)"Don´t forget to copy the officials name to segment 1?", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            else
            {
                if (!(Strings.Len(Module1.Referee.Seg1.Name) > 0 & Strings.Len(Module1.Referee.Seg2.Name) == 0 | Strings.Len(Module1.Controller.Seg1.Name) > 0 & Strings.Len(Module1.Controller.Seg2.Name) == 0 | Strings.Len(Module1.Techspec.Seg1.Name) > 0 & Strings.Len(Module1.Techspec.Seg2.Name) == 0))
                    return;
                int num2 = (int)Interaction.MsgBox((object)"Don´t forget to copy the officials name to segment 2?", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        public string Testsegment()
        {
            string str = Module1.TNop != 0 ? "Seg2" : "Seg1";
            int tnop = Module1.TNop;
            int index = 1;
            while (index <= tnop)
            {
                if (Module1.Vek[index].Finished_Seg1 == 0 & Module1.Vek[index].DNS_Seg1 == 0)
                    str = "Seg1";
                checked { ++index; }
            }
            return str;
        }

        public void EnableTextboxes(bool blnLock)
        {
            Module1.Form1_TxtBoxEnabled = blnLock;
            int num1 = 1;
            do
            {
                string key1 = "JudgeName" + Strings.Trim(Conversions.ToString(num1));
                string key2 = "JudgeClub" + Strings.Trim(Conversions.ToString(num1));
                this.Controls[key1].Enabled = blnLock;
                this.Controls[key2].Enabled = blnLock;
                checked { ++num1; }
            }
            while (num1 <= 7);
            int num2 = 1;
            do
            {
                string key3 = "DVOName" + Strings.Trim(Conversions.ToString(num2));
                string key4 = "DVOClub" + Strings.Trim(Conversions.ToString(num2));
                this.Controls[key3].Enabled = blnLock;
                this.Controls[key4].Enabled = blnLock;
                checked { ++num2; }
            }
            while (num2 <= 3);
            this.txtOrganizerName.Enabled = blnLock;
            this.txtOrganizerID.Enabled = blnLock;
            this.txtCompetitionName.Enabled = blnLock;
            this.txtCompetitionID.Enabled = blnLock;
            this.txtType.Enabled = blnLock;
            this.ControllerName.Enabled = blnLock;
            this.ControllerClub.Enabled = blnLock;
            this.TechSpecName.Enabled = blnLock;
            this.TechSpecClub.Enabled = blnLock;
            this.RefereeName.Enabled = blnLock;
            this.RefereeClub.Enabled = blnLock;
        }

        private void RunWithNetwotkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible())
                return;
            this.CloseFormsDialogs();
            if (!Module1.TestStart())
                return;
            if (!this.completed5)
            {
                Module1.PrinterMessage();
            }
            else
            {
                this.EnableTextboxes(false);
                if (Module1.WorkMode == 1)
                {
                    this.GetInputForm1();
                    Module1.SaveCategoryFile(Module1.CategoryFileName);
                }
                Module1.SetWorkMode(2);
            }
        }

        private void PrepareModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible())
                return;
            if (!this.completed5)
            {
                Module1.PrinterMessage();
            }
            else
            {
                this.CloseFormsDialogs();
                this.EnableTextboxes(true);
                Module1.SetWorkMode(1);
                this.txtCompetitionName.Select();
            }
        }

        private void ManualInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible())
                return;
            this.CloseFormsDialogs();
            if (!Module1.TestStart())
                return;
            if (!this.completed5)
            {
                Module1.PrinterMessage();
            }
            else
            {
                this.EnableTextboxes(false);
                if (Module1.WorkMode == 1)
                {
                    this.GetInputForm1();
                    Module1.SaveCategoryFile(Module1.CategoryFileName);
                }
                Module1.SetWorkMode(3);
            }
        }

        private void DBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible())
                return;
            this.TopMost = false;
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form13))
                MyProject.Forms.Form13.Close();
            int num = (int)MyProject.Forms.Form13.ShowDialog();
        }

        public void LoadElementDB(string File)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Module1.ElementDBLastWriteTime = new FileInfo(File).LastWriteTime;
                int i;
                using (XmlReader MyReader = XmlReader.Create(File))
                {
                    Module1.Jumpmin = 0;
                    i = 0;
                    while (MyReader.Read())
                    {
                        if (MyReader.NodeType == XmlNodeType.Element)
                        {
                            string name = MyReader.Name;
                            if (Operators.CompareString(name, "ElementDB", false) == 0)
                                this.ParseElementDB(MyReader);
                            else if (Operators.CompareString(name, "Jump", false) == 0)
                            {
                                this.ParseJump(MyReader, i);
                                Module1.JumpMax = i;
                                checked { ++i; }
                            }
                            else if (Operators.CompareString(name, "Spin", false) == 0)
                            {
                                this.ParseSpin(MyReader, i);
                                Module1.Spinmax = i;
                                checked { ++i; }
                            }
                            else if (Operators.CompareString(name, "Step", false) == 0)
                            {
                                this.ParseStep(MyReader, i);
                                Module1.Stepmax = i;
                                checked { ++i; }
                            }
                        }
                    }
                }
                Module1.SpinMin = checked(Module1.JumpMax + 1);
                Module1.Stepmin = checked(Module1.Spinmax + 1);
                Module1.ElDBmax = i;
                goto label_22;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("LoadElementDB - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_22:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void ParseElementDB(XmlReader MyReader)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                MyReader.ReadToFollowing("Version");
                Module1.ElementDBver = MyReader.ReadString();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ParseElementDB - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void ParseJump(XmlReader MyReader, int i)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Module1.ElDB[i, 0] = (object)MyReader.GetAttribute(0);
                Module1.ElDB[i, 1] = (object)MyReader.GetAttribute(1);
                Module1.ElDB[i, 2] = (object)MyReader.GetAttribute(2);
                Module1.ElDB[i, 3] = (object)MyReader.GetAttribute(3);
                Module1.ElDB[i, 4] = (object)MyReader.GetAttribute(4);
                Module1.ElDB[i, 5] = (object)MyReader.GetAttribute(5);
                Module1.ElDB[i, 6] = (object)MyReader.GetAttribute(6);
                Module1.ElDB[i, 7] = (object)MyReader.GetAttribute(7);
                Module1.ElDB[i, 8] = (object)MyReader.GetAttribute(8);
                Module1.ElDB[i, 9] = (object)MyReader.GetAttribute(9);
                Module1.ElDB[i, 10] = (object)MyReader.GetAttribute(10);
                Module1.ElDB[i, 11] = (object)MyReader.GetAttribute(11);
                MyReader.MoveToElement();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ParseJump - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void ParseSpin(XmlReader MyReader, int i)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Module1.ElDB[i, 0] = (object)MyReader.GetAttribute(0);
                Module1.ElDB[i, 1] = (object)MyReader.GetAttribute(1);
                Module1.ElDB[i, 2] = (object)MyReader.GetAttribute(2);
                Module1.ElDB[i, 3] = (object)MyReader.GetAttribute(3);
                Module1.ElDB[i, 4] = (object)MyReader.GetAttribute(4);
                Module1.ElDB[i, 5] = (object)MyReader.GetAttribute(5);
                Module1.ElDB[i, 6] = (object)MyReader.GetAttribute(6);
                Module1.ElDB[i, 7] = (object)MyReader.GetAttribute(7);
                Module1.ElDB[i, 8] = (object)MyReader.GetAttribute(8);
                Module1.ElDB[i, 9] = (object)MyReader.GetAttribute(9);
                Module1.ElDB[i, 10] = (object)MyReader.GetAttribute(10);
                Module1.ElDB[i, 11] = (object)MyReader.GetAttribute(11);
                MyReader.MoveToElement();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ParseJump - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void ParseStep(XmlReader MyReader, int i)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Module1.ElDB[i, 0] = (object)MyReader.GetAttribute(0);
                Module1.ElDB[i, 1] = (object)MyReader.GetAttribute(1);
                Module1.ElDB[i, 2] = (object)MyReader.GetAttribute(2);
                Module1.ElDB[i, 3] = (object)MyReader.GetAttribute(3);
                Module1.ElDB[i, 4] = (object)MyReader.GetAttribute(4);
                Module1.ElDB[i, 5] = (object)MyReader.GetAttribute(5);
                Module1.ElDB[i, 6] = (object)MyReader.GetAttribute(6);
                Module1.ElDB[i, 7] = (object)MyReader.GetAttribute(7);
                Module1.ElDB[i, 8] = (object)MyReader.GetAttribute(8);
                Module1.ElDB[i, 9] = (object)MyReader.GetAttribute(9);
                Module1.ElDB[i, 10] = (object)MyReader.GetAttribute(10);
                Module1.ElDB[i, 11] = (object)MyReader.GetAttribute(11);
                MyReader.MoveToElement();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ParseJump - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void CategorySelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible())
                return;
            if (!this.completed5)
            {
                Module1.PrinterMessage();
            }
            else
            {
                if (Module1.IsFormOpen((Form)MyProject.Forms.CategoryDialog))
                    MyProject.Forms.CategoryDialog.Close();
                int num = (int)MyProject.Forms.CategoryDialog.ShowDialog();
            }
        }

        private void JudgesSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible())
                return;
            if (!this.completed5)
            {
                Module1.PrinterMessage();
            }
            else
            {
                if (Module1.IsFormOpen((Form)MyProject.Forms.JudgesSetupDialog))
                    MyProject.Forms.JudgesSetupDialog.Close();
                int num = (int)MyProject.Forms.JudgesSetupDialog.ShowDialog();
            }
        }

        private void SaveCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible())
                return;
            this.SaveCategoryDB_As();
        }

        public void SaveCategoryDB_As()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string Path = "";
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                ProjectData.ClearProjectError();
                num1 = 2;
                if (Module1.TestStart())
                {
                    saveFileDialog.Title = "SAVE A COMPETITION FILE";
                    if (this.SaveDir(ref Path))
                    {
                        saveFileDialog.InitialDirectory = Path;
                        string categoryFileName = Module1.CategoryFileName;
                        string str = Strings.UCase(Module1.StrConv(Module1.Competition.Name + "_" + Module1.Category.Name + Module1.SubCat_()));
                        if (!Strings.UCase(Module1.CategoryFileName).Contains(str))
                            Module1.CategoryFileName = Module1.StrConv(Strings.Trim(Module1.Competition.Name) + "_" + Module1.Category.Name + Module1.SubCat_() + ".xml");
                        saveFileDialog.FileName = Module1.CategoryFileName;
                        saveFileDialog.Filter = "Competition files (*.xml)|*.xml|All files (*.*)|*.*";
                        saveFileDialog.FilterIndex = 1;
                        saveFileDialog.RestoreDirectory = true;
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            Stream stream = saveFileDialog.OpenFile();
                            if (stream != null)
                            {
                                Module1.CategoryFileName = saveFileDialog.FileName;
                                stream.Close();
                            }
                            if (Module1.WorkMode == 1)
                                this.GetInputForm1();
                            Module1.CreateCategoryFile(Module1.CategoryFileName);
                            goto label_17;
                        }
                        else
                        {
                            Module1.CategoryFileName = categoryFileName;
                            int num3 = (int)Interaction.MsgBox((object)"The file is not saved?", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            goto label_17;
                        }
                    }
                    else
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
                int num4 = (int)Interaction.MsgBox((object)("SaveCategoryDB_As - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_17:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private bool SaveDir(ref string Path)
        {
            int num1 = 0;
            bool flag = false;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                flag = false;
                string pathCompFile = Module1.PathCompFile;
                if (Operators.CompareString(pathCompFile, "", false) != 0)
                {
                    if (Operators.CompareString(Strings.Right(Module1.PathCompFile, 1), "\\", false) != 0)
                        pathCompFile += "\\";
                    Path = Module1.StrConv(pathCompFile + Module1.Competition.Name + "\\");
                    if (!MyProject.Computer.FileSystem.DirectoryExists(Path))
                    {
                        if (Interaction.MsgBox((object)("The folder:\r\n" + Path + "\r\ndoes not exist!\r\nDo you want to create it?"), MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") != MsgBoxResult.Yes)
                        {
                            int num3 = (int)Interaction.MsgBox((object)"The file(s) has not been created!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            flag = false;
                            goto label_17;
                        }
                        else
                        {
                            int Start = 4;
                            int Length;
                            do
                            {
                                Length = Strings.InStr(Start, Path, "\\");
                                string str = Strings.Left(Path, Length);
                                if (Length > Start & !MyProject.Computer.FileSystem.DirectoryExists(str))
                                    FileSystem.MkDir(str);
                                Start = checked(Length + 1);
                            }
                            while (!(Length == 0 | Start > Strings.Len(Path)));
                            flag = true;
                            goto label_17;
                        }
                    }
                    else
                    {
                        flag = true;
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
                int num4 = (int)Interaction.MsgBox((object)("Error in the folder or file name!\r\n" + Path + "\r\n" + Information.Err().Description), MsgBoxStyle.Critical | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_17:
            int num5 = flag ? 1 : 0;
            if (num2 == 0)
                return num5 != 0;
            ProjectData.ClearProjectError();
            return num5 != 0;
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !Module1.TestStart() || Interaction.MsgBox((object)"Do you want to save everything in the the database?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW") != MsgBoxResult.Yes)
                return;
            if (Module1.WorkMode == 1)
                this.GetInputForm1();
            Module1.SaveCategoryFile(Module1.CategoryFileName);
        }

        private void NetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible())
                return;
            if (!this.completed5)
            {
                Module1.PrinterMessage();
            }
            else
            {
                if (Module1.IsFormOpen((Form)MyProject.Forms.ConfigurationDataDialog))
                    MyProject.Forms.ConfigurationDataDialog.Close();
                int num = (int)MyProject.Forms.ConfigurationDataDialog.ShowDialog();
            }
        }

        private void CompetitionName_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '!':
                case '"':
                case '&':
                case '\'':
                case '*':
                case '+':
                case ',':
                case '.':
                case '/':
                case ':':
                case ';':
                case '<':
                case '>':
                case '?':
                case '[':
                case '\\':
                case ']':
                case '~':
                    e.Handled = true;
                    break;
            }
        }

        private void txtType_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ControllerName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ControllerClub_KeyPress1(object sender, KeyPressEventArgs e)
        {
            if (!Constants.IsValidCharForClubName(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TechSpecName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TechSpecClub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Constants.IsValidCharForClubName(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RefereeName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void RefereeClub_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Constants.IsValidCharForClubName(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void JudgeName1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void JudgeClub1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Constants.IsValidCharForClubName(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void JudgeName2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void JudgeClub2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Constants.IsValidCharForClubName(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void JudgeName3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void JudgeClub3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Constants.IsValidCharForClubName(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void JudgeName4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void JudgeClub4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Constants.IsValidCharForClubName(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void JudgeName5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void JudgeClub5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Constants.IsValidCharForClubName(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void JudgeName6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void JudgeClub6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Constants.IsValidCharForClubName(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void JudgeName7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void JudgeClub7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Constants.IsValidCharForClubName(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GetInputForm1()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (Module1.WorkMode == 1)
                {
                    Module1.Organizer.Name = this.txtOrganizerName.Text;
                    Module1.Organizer.ID = this.txtOrganizerID.Text;
                    Module1.Competition.Name = this.txtCompetitionName.Text;
                    Module1.Competition.ID = this.txtCompetitionID.Text;
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        this.GetSeg1Officials();
                        if (Operators.CompareString(Module1.GetSeg(), "S0", false) == 0 | Operators.CompareString(Module1.GetSeg(), "F0", false) == 0)
                        {
                            this.GetSeg2Officials();
                            goto label_13;
                        }
                        else
                            goto label_13;
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        this.GetSeg2Officials();
                        if (Operators.CompareString(Module1.GetSeg(), "0F", false) == 0 | Operators.CompareString(Module1.GetSeg(), "0S", false) == 0)
                        {
                            this.GetSeg1Officials();
                            goto label_13;
                        }
                        else
                            goto label_13;
                    }
                    else
                        goto label_13;
                }
                else
                    goto label_13;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("GetInputForm1 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_13:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void GetSeg1Officials()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Module1.Techspec.Seg1.Name = this.TechSpecName.Text;
                Module1.Techspec.Seg1.Club = this.TechSpecClub.Text;
                Module1.Controller.Seg1.Name = this.ControllerName.Text;
                Module1.Controller.Seg1.Club = this.ControllerClub.Text;
                Module1.Referee.Seg1.Name = this.RefereeName.Text;
                Module1.Referee.Seg1.Club = this.RefereeClub.Text;
                int index1 = 1;
                do
                {
                    string key1 = "JudgeName" + Strings.Trim(Conversions.ToString(index1));
                    Module1.Judge[index1].Seg1.Name = this.Controls[key1].Text;
                    string key2 = "JudgeClub" + Strings.Trim(Conversions.ToString(index1));
                    Module1.Judge[index1].Seg1.Club = this.Controls[key2].Text;
                    checked { ++index1; }
                }
                while (index1 <= 7);
                int index2 = 1;
                do
                {
                    string key3 = "DVOName" + Strings.Trim(Conversions.ToString(index2));
                    Module1.DVO[index2].Seg1.Name = this.Controls[key3].Text;
                    string key4 = "DVOClub" + Strings.Trim(Conversions.ToString(index2));
                    Module1.DVO[index2].Seg1.Club = this.Controls[key4].Text;
                    checked { ++index2; }
                }
                while (index2 <= 3);
                goto label_10;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("GetSeg1Officials - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_10:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void GetSeg2Officials()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Module1.Techspec.Seg2.Name = this.TechSpecName.Text;
                Module1.Techspec.Seg2.Club = this.TechSpecClub.Text;
                Module1.Controller.Seg2.Name = this.ControllerName.Text;
                Module1.Controller.Seg2.Club = this.ControllerClub.Text;
                Module1.Referee.Seg2.Name = this.RefereeName.Text;
                Module1.Referee.Seg2.Club = this.RefereeClub.Text;
                int index1 = 1;
                do
                {
                    string key1 = "JudgeName" + Strings.Trim(Conversions.ToString(index1));
                    Module1.Judge[index1].Seg2.Name = this.Controls[key1].Text;
                    string key2 = "JudgeClub" + Strings.Trim(Conversions.ToString(index1));
                    Module1.Judge[index1].Seg2.Club = this.Controls[key2].Text;
                    checked { ++index1; }
                }
                while (index1 <= 7);
                int index2 = 1;
                do
                {
                    string key3 = "DVOName" + Strings.Trim(Conversions.ToString(index2));
                    Module1.DVO[index2].Seg2.Name = this.Controls[key3].Text;
                    string key4 = "DVOClub" + Strings.Trim(Conversions.ToString(index2));
                    Module1.DVO[index2].Seg2.Club = this.Controls[key4].Text;
                    checked { ++index2; }
                }
                while (index2 <= 3);
                goto label_10;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("GetSeg2Officials - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_10:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void InitVariables()
        {
            Module1.Vek = (Module1.Participant[])null;
            Module1.Vek = new Module1.Participant[43];
            int index = 1;
            do
            {
                Module1.Vek[index].J_Seg1.EE = new int[16, 8];
                Module1.Vek[index].J_Seg2.EE = new int[16, 8];
                Module1.Vek[index].J_Seg1.PC = new double[16, 8];
                Module1.Vek[index].J_Seg2.PC = new double[16, 8];
                Module1.Vek[index].J_Seg1.Deduction = new long[8];
                Module1.Vek[index].J_Seg2.Deduction = new long[8];
                Module1.Vek[index].SSS_Seg1 = (string[])null;
                Module1.Vek[index].SSS_Seg1 = new string[16];
                Module1.Vek[index].SSS_Seg2 = (string[])null;
                Module1.Vek[index].SSS_Seg2 = new string[16];
                Module1.Vek[index].Falls_seg1 = 0;
                Module1.Vek[index].Falls_seg2 = 0;
                checked { ++index; }
            }
            while (index <= 42);
            Module1.CategoryFileName = "";
            Module1.Category.Name = "";
            Module1.SubCategory = "";
            Module1.WarmUpTime = "";
            Module1.PcIndex = -1;
            Module1.TNop = 0;
            Module1.WupG_Seg1 = 0;
            Module1.WupG_Seg2 = 0;
            Module1.IceArr_Seg1 = (int[])null;
            Module1.IceArr_Seg1 = new int[8];
            Module1.LunchArr_Seg1 = (int[])null;
            Module1.LunchArr_Seg1 = new int[8];
            Module1.Segment = "";
            Module1.Datum.Seg1 = DateTime.Today;
            Module1.Datum.Seg2 = DateTime.Today;
            Module1.Datum.Seg1Start = Strings.Format((object)DateTime.Now, "HH:mm");
            Module1.Datum.Seg2Start = Strings.Format((object)DateTime.Now, "HH:mm");
        }

        private void InitChategory()
        {
            Module1.Vek = (Module1.Participant[])null;
            Module1.Vek = new Module1.Participant[43];
            int index = 1;
            do
            {
                Module1.Vek[index].J_Seg1.EE = new int[16, 8];
                Module1.Vek[index].J_Seg2.EE = new int[16, 8];
                Module1.Vek[index].J_Seg1.PC = new double[16, 8];
                Module1.Vek[index].J_Seg2.PC = new double[16, 8];
                Module1.Vek[index].J_Seg1.Deduction = new long[8];
                Module1.Vek[index].J_Seg2.Deduction = new long[8];
                Module1.Vek[index].SSS_Seg1 = new string[16];
                Module1.Vek[index].SSS_Seg2 = new string[16];
                checked { ++index; }
            }
            while (index <= 42);
            Module1.CategoryFileName = "";
            Module1.Category.Name = "";
            Module1.SubCategory = "";
            Module1.PcIndex = -1;
            Module1.TNop = 0;
            Module1.WupG_Seg1 = 0;
            Module1.WupG_Seg2 = 0;
            Module1.IceArr_Seg1 = (int[])null;
            Module1.IceArr_Seg1 = new int[7];
            Module1.LunchArr_Seg1 = (int[])null;
            Module1.LunchArr_Seg1 = new int[7];
            Module1.Segment = "";
            Module1.Datum.Seg1 = DateTime.Today;
            Module1.Datum.Seg2 = DateTime.Today;
            Module1.Datum.Seg1Start = Strings.Format((object)DateTime.Now, "HH:mm");
            Module1.Datum.Seg2Start = Strings.Format((object)DateTime.Now, "HH:mm");
        }

        private void ClearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || Module1.WorkMode != 1)
                return;
            Module1.ClearOfficials();
            Module1.CreateForm1();
        }

        public void ClearOff()
        {
            Module1.ClearOfficials();
            Module1.CreateForm1();
        }

        private void HeadPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !Module1.TestStart())
                return;
            int num = checked((int)Math.Round(Conversion.Val(Interaction.InputBox("Number of copies, 0-9?", "Susanne SW", Conversions.ToString(1)))));
            if (!(num > 0 & num < 10))
                return;
            this.Qprint.Enqueue(checked(10 + num));
            MyProject.Forms.Form10.txtPrint.Text = "Head Page!";
            MyProject.Forms.Form10.Show();
            this.BGW();
        }

        private void HeadPageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible())
                return;
            if (Strings.Len(Module1.Category.Name) > 2)
            {
                if (Module1.IsFormOpen((Form)MyProject.Forms.Dialog8))
                    MyProject.Forms.Dialog8.Close();
                int num = (int)MyProject.Forms.Dialog8.ShowDialog();
            }
            else
            {
                int num1 = (int)Interaction.MsgBox((object)"Please select a Category!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        private void StartListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (this.TstStartNo())
            {
                int num = checked((int)Math.Round(Conversion.Val(Interaction.InputBox("Number of copies, 0-9?", "Susanne SW", Conversions.ToString(1)))));
                if (!(num > 0 & num < 10))
                    return;
                this.DisableMenu();
                this.Qprint.Enqueue(checked(30 + num));
                MyProject.Forms.Form10.txtPrint.Text = "Start List!";
                MyProject.Forms.Form10.Show();
                this.BGW();
            }
            else
            {
                int num1 = (int)Interaction.MsgBox((object)"The start numbers are not yet created!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        public bool TstStartNo()
        {
            bool flag = true;
            string segment = Module1.Segment;
            if (Operators.CompareString(segment, "Seg1", false) == 0)
            {
                int tnop = Module1.TNop;
                int index = 1;
                while (index <= tnop)
                {
                    if (Module1.Vek[index].Startno_Seg1 == 0 & Module1.Vek[index].DNS_Seg1 == 0)
                        flag = false;
                    checked { ++index; }
                }
            }
            else if (Operators.CompareString(segment, "Seg2", false) == 0)
            {
                int tnop = Module1.TNop;
                int index = 1;
                while (index <= tnop)
                {
                    if (Module1.Vek[index].Startno_Seg2 == 0 & Module1.Vek[index].DNS_Seg1 == 0 & Module1.Vek[index].DNS_Seg2 == 0)
                        flag = false;
                    checked { ++index; }
                }
            }
            return flag;
        }

        private void CompetitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible())
                return;
            if (Module1.TestStart())
            {
                if (!this.completed5)
                {
                    Module1.PrinterMessage();
                }
                else
                {
                    if (Strings.Len(Module1.CategoryFileName) > 1)
                    {
                        if (Module1.WorkMode == 1)
                        {
                            this.GetInputForm1();
                            Module1.SaveCategoryFile(Module1.CategoryFileName);
                        }
                        if (Module1.IsFormOpen((Form)MyProject.Forms.Form6))
                            MyProject.Forms.Form6.Close();
                        if (Module1.IsFormOpen((Form)MyProject.Forms.Form2))
                            MyProject.Forms.Form2.Close();
                        if (Module1.WorkMode == 2)
                            this.UnhudeJudgesDisplayToolStripMenuItem.PerformClick();
                    }
                    MyProject.Forms.Form2.TopMost = true;
                    MyProject.Forms.Form2.Show();
                }
            }
            else
            {
                int num = (int)Interaction.MsgBox((object)"First you need to save the new Category!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        private void ExitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.WillExit = true;
            if (Operators.CompareString(Module1.Competition.Name, (string)null, false) == 0 & Operators.CompareString(Module1.Category.Name, (string)null, false) == 0)
            {
                this.WillExit = true;
                this.CloseFormsDialogs();
                this.Close();
            }
            else
            {
                string str = Strings.UCase(Module1.StrConv(Module1.Competition.Name + "_" + Module1.Category.Name + Module1.SubCat_() + ".xml"));
                if (!Strings.UCase(Module1.CategoryFileName).Contains(str))
                {
                    if (Interaction.MsgBox((object)"This is a new Category which isn't saved!\r\nDo you really want to Exit ClubCompFS without saving?", MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.Yes)
                    {
                        this.WillExit = true;
                        this.CloseFormsDialogs();
                        this.Close();
                    }
                    else
                        this.WillExit = false;
                }
                else if (Interaction.MsgBox((object)"Do you really want to Exit ClubCompFS?", MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.No)
                {
                    this.WillExit = false;
                }
                else
                {
                    this.WillExit = true;
                    this.BackgroundWorker2.RunWorkerAsync();
                }
            }
        }

        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            if (Module1.WorkMode == 1)
                this.GetInputForm1();
            Module1.SaveCategoryFile(Module1.CategoryFileName);
        }

        private void BackgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Module1.CategoryFileSaved & this.completed5)
            {
                this.CloseFormsDialogs();
                this.Close();
            }
            else
            {
                int num = (int)Interaction.MsgBox((object)"All started jobs are not yet finished!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        private void PingTheNetworkToolStripMenuItem_Click(object sender, EventArgs e) => this.Ping();

        private void EntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            int num = checked((int)Math.Round(Conversion.Val(Interaction.InputBox("Number of copies, 0-9?", "Susanne SW", Conversions.ToString(1)))));
            if (!(num > 0 & num < 10))
                return;
            this.Qprint.Enqueue(checked(20 + num));
            MyProject.Forms.Form10.txtPrint.Text = "Entries!";
            MyProject.Forms.Form10.Show();
            this.BGW();
        }

        private void PrintAllResultDocumentsCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (this.TstStartNo())
            {
                string segment1 = Module1.Segment;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    if (!this.OnlyDNSSeg1() && !this.FinishedSeg1())
                    {
                        int num = (int)Interaction.MsgBox((object)"The short program is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        return;
                    }
                }
                else if (Operators.CompareString(segment1, "Seg2", false) == 0 && !this.OnlyDNSSeg2() && !this.FinishedSeg2())
                {
                    int num = (int)Interaction.MsgBox((object)"The free skating is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    return;
                }
                int num1 = checked((int)Math.Round(Conversion.Val(Interaction.InputBox("Number of copies, 0-9?", "Susanne SW", Conversions.ToString(1)))));
                if (!(num1 > 0 & num1 < 10))
                    return;
                switch (Module1.WorkMode)
                {
                    case 2:
                    case 3:
                        MyProject.Forms.Form10.txtPrint.Text = "All Result Documents / Category!";
                        MyProject.Forms.Form10.Show();
                        int num2 = num1;
                        int num3 = 1;
                        while (num3 <= num2)
                        {
                            this.Qprint.Enqueue(11);
                            this.Qprint.Enqueue(801);
                            string segment2 = Module1.Segment;
                            if (Operators.CompareString(segment2, "Seg1", false) == 0)
                            {
                                if (!this.OnlyDNSSeg1())
                                    this.Qprint.Enqueue(911);
                            }
                            else if (Operators.CompareString(segment2, "Seg2", false) == 0 && !this.OnlyDNSSeg2())
                                this.Qprint.Enqueue(911);
                            checked { ++num3; }
                        }
                        this.BGW();
                        break;
                }
            }
            else
            {
                int num4 = (int)Interaction.MsgBox((object)"Start numbers are not defined!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        private void HeadPageToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !Module1.TestStart())
                return;
            if (!this.completed5)
                Module1.PrinterMessage();
            else
                MyProject.Forms.Dialog8.CreateHP_PDFfile(1);
        }

        private void ResultsPDFfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (!this.completed5)
            {
                Module1.PrinterMessage();
            }
            else
            {
                string segment1 = Module1.Segment;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    if (!this.OnlyDNSSeg1() && !this.FinishedSeg1())
                    {
                        int num = (int)Interaction.MsgBox((object)"The program in segment 1 is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        return;
                    }
                }
                else if (Operators.CompareString(segment1, "Seg2", false) == 0 && !this.OnlyDNSSeg2() && !this.FinishedSeg2())
                {
                    int num = (int)Interaction.MsgBox((object)"The program in segment 2 is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    return;
                }
                this.CloseFormsDialogs();
                string segment2 = Module1.Segment;
                if (Operators.CompareString(segment2, "Seg1", false) == 0)
                {
                    MyProject.Forms.Form6.CreateResultsPDF("Seg1", 1);
                }
                else
                {
                    if (Operators.CompareString(segment2, "Seg2", false) != 0)
                        return;
                    if (Operators.CompareString(Module1.GetSeg(), "SF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "FF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "SS", false) == 0 | Operators.CompareString(Module1.GetSeg(), "FS", false) == 0)
                    {
                        MyProject.Forms.Form6.CreateResultsPDF("Seg2", 0);
                        MyProject.Forms.Form6.CreateResultsPDF("Final", 2);
                    }
                    else
                        MyProject.Forms.Form6.CreateResultsPDF("Seg2", 1);
                }
            }
        }

        private void JudgesDetailsForTheCategoryWithoutTrJudgesAndRefereeToolStripMenuItem_Click(
          object sender,
          EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (this.TstStartNo())
            {
                if (!this.completed5)
                {
                    Module1.PrinterMessage();
                }
                else
                {
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        if (!this.FinishedSeg1())
                        {
                            int num = (int)Interaction.MsgBox((object)"The short program is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            return;
                        }
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0 && !this.FinishedSeg2())
                    {
                        int num = (int)Interaction.MsgBox((object)"The free skating is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        return;
                    }
                    this.CloseFormsDialogs();
                    MyProject.Forms.Form4.txtPrint.Text = "0";
                    MyProject.Forms.Form4.CreateJD_PDFfile(1);
                }
            }
            else
            {
                int num1 = (int)Interaction.MsgBox((object)"Start numbers are not defined!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        private void ResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            switch (Module1.WorkMode)
            {
                case 2:
                case 3:
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        if (!this.OnlyDNSSeg1() && !this.FinishedSeg1())
                        {
                            int num = (int)Interaction.MsgBox((object)"The short program is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            break;
                        }
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0 && !this.OnlyDNSSeg2() && !this.FinishedSeg2())
                    {
                        int num = (int)Interaction.MsgBox((object)"The free skating is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        break;
                    }
                    int num1 = checked((int)Math.Round(Conversion.Val(Interaction.InputBox("Number of copies, 0-9?", "Susanne SW", Conversions.ToString(1)))));
                    if (!(num1 > 0 & num1 < 10))
                        break;
                    this.Qprint.Enqueue(checked(800 + num1));
                    MyProject.Forms.Form10.txtPrint.Text = "Results!";
                    MyProject.Forms.Form10.Show();
                    this.BGW();
                    break;
            }
        }

        private void AllFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (this.TstStartNo())
            {
                if (!this.completed5)
                {
                    Module1.PrinterMessage();
                }
                else
                {
                    string segment1 = Module1.Segment;
                    if (Operators.CompareString(segment1, "Seg1", false) == 0)
                    {
                        if (!this.OnlyDNSSeg1() && !this.FinishedSeg1())
                        {
                            int num = (int)Interaction.MsgBox((object)"Segment 1 is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                            return;
                        }
                    }
                    else if (Operators.CompareString(segment1, "Seg2", false) == 0 && !this.OnlyDNSSeg2() && !this.FinishedSeg2())
                    {
                        int num = (int)Interaction.MsgBox((object)"Segment 2 is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        return;
                    }
                    this.CloseFormsDialogs();
                    MyProject.Forms.Dialog8.CreateHP_PDFfile(0);
                    string segment2 = Module1.Segment;
                    if (Operators.CompareString(segment2, "Seg1", false) == 0)
                    {
                        if (!this.OnlyDNSSeg1())
                        {
                            MyProject.Forms.Form6.CreateResultsPDF("Seg1", 0);
                            MyProject.Forms.Form4.txtPrint.Text = "0";
                            MyProject.Forms.Form4.CreateJD_PDFfile(2);
                        }
                        else
                            MyProject.Forms.Form6.CreateResultsPDF("Seg1", 2);
                    }
                    else
                    {
                        if (Operators.CompareString(segment2, "Seg2", false) != 0)
                            return;
                        if (!this.OnlyDNSSeg2())
                        {
                            MyProject.Forms.Form6.CreateResultsPDF("Seg2", 0);
                            if (Operators.CompareString(Module1.GetSeg(), "SF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "FF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "SS", false) == 0)
                                MyProject.Forms.Form6.CreateResultsPDF("Final", 0);
                            MyProject.Forms.Form4.txtPrint.Text = "0";
                            MyProject.Forms.Form4.CreateJD_PDFfile(2);
                        }
                        else if (Operators.CompareString(Module1.GetSeg(), "SF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "FF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "SS", false) == 0)
                        {
                            MyProject.Forms.Form6.CreateResultsPDF("Seg2", 0);
                            MyProject.Forms.Form6.CreateResultsPDF("Final", 2);
                        }
                        else
                            MyProject.Forms.Form6.CreateResultsPDF("Seg2", 2);
                    }
                }
            }
            else
            {
                int num1 = (int)Interaction.MsgBox((object)"Start numbers are not defined!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        private void SHOWRESULTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (!this.completed5)
            {
                Module1.PrinterMessage();
            }
            else
            {
                this.CloseFormsDialogs();
                if (Module1.IsFormOpen((Form)MyProject.Forms.Form6))
                    MyProject.Forms.Form6.Close();
                MyProject.Forms.Form6.Show();
            }
        }

        private void TCTSCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (this.MaxStartNo() > 0)
            {
                this.Qprint.Enqueue(400);
                MyProject.Forms.Form10.txtPrint.Text = "The TC Cards for the TC!";
                MyProject.Forms.Form10.Show();
                this.BGW();
            }
            else
            {
                int num = (int)Interaction.MsgBox((object)"No skater(s) with a start number in the start list!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        private void TCSCardForBothTCAndTCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (this.MaxStartNo() > 0)
            {
                this.Qprint.Enqueue(500);
                MyProject.Forms.Form10.txtPrint.Text = "The TC/TS Cards for both TC and TS!";
                MyProject.Forms.Form10.Show();
                this.BGW();
            }
            else
            {
                int num = (int)Interaction.MsgBox((object)"No skater(s) with a start number in the start list!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        public int MaxStartNo()
        {
            int num = 0;
            if (Module1.TNop > 0)
            {
                int tnop = Module1.TNop;
                int index = 1;
                while (index <= tnop)
                {
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        if (Module1.Vek[index].Startno_Seg1 > num)
                            num = Module1.Vek[index].Startno_Seg1;
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0 && Module1.Vek[index].Startno_Seg2 > num)
                        num = Module1.Vek[index].Startno_Seg2;
                    checked { ++index; }
                }
            }
            return num;
        }

        private void TCTSCardForASelectedSkaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (this.MaxStartNo() > 0)
            {
                int num1 = checked((int)Math.Round(Conversion.Val(Interaction.InputBox("Print TC/TS cards for the skater\r\nwith serial number = 1 to " + Conversions.ToString(Module1.TNop), "Susanne SW", Conversions.ToString(1)))));
                if (num1 > 0 & num1 <= Module1.TNop)
                {
                    int num2 = checked(num1 + 600);
                    this.Qprint.Enqueue(num2);
                    MyProject.Forms.Form10.txtPrint.Text = "The TC/TS Cards for skater number " + Conversions.ToString(checked(num2 - 600)) + "!";
                    MyProject.Forms.Form10.Show();
                    this.BGW();
                }
                else
                {
                    int num3 = (int)Interaction.MsgBox((object)("Only serial numbers 1 - " + Conversions.ToString(Module1.TNop) + " are possible!"), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
            }
            else
            {
                int num = (int)Interaction.MsgBox((object)"No skater(s) with a start number in the start list!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        private void JudgeCardsForOneJudgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (this.MaxStartNo() > 0)
            {
                int num1 = checked((int)Math.Round(Conversion.Val(Interaction.InputBox("Print Judge cards for the given\r\nJudge with no. 1 to 7", "Susanne SW", Conversions.ToString(1)))));
                if (num1 > 0 & num1 <= checked(Module1.NoJ_GOE + Module1.NoTrj) | Module1.JudgeSel == 1 & num1 == 7)
                {
                    int num2 = checked(200 + num1);
                    this.Qprint.Enqueue(num2);
                    MyProject.Forms.Form10.txtPrint.Text = "The Judge cards for Judge number " + Conversions.ToString(checked(num2 - 200)) + "!";
                    MyProject.Forms.Form10.Show();
                    this.BGW();
                }
                else
                {
                    int num3 = (int)Interaction.MsgBox((object)"Wrong selection of Judge no.!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
            }
            else
            {
                int num = (int)Interaction.MsgBox((object)"No skater(s) with a start number in the start list!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        private void JusgeCardsForASelectedSkaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (this.MaxStartNo() > 0)
            {
                int num1 = checked((int)Math.Round(Conversion.Val(Interaction.InputBox("Print Judge cards for the skater\r\nwith serial number = 1 to " + Conversions.ToString(Module1.TNop), "Susanne SW", Conversions.ToString(1)))));
                if (num1 > 0 & num1 <= Module1.TNop)
                {
                    int num2 = checked(num1 + 300);
                    this.Qprint.Enqueue(num2);
                    MyProject.Forms.Form10.txtPrint.Text = "The Judge cards for skater number " + Conversions.ToString(checked(num2 - 300)) + "!";
                    MyProject.Forms.Form10.Show();
                    this.BGW();
                }
                else
                {
                    int num3 = (int)Interaction.MsgBox((object)("Only serial numbers 1 - " + Conversions.ToString(Module1.TNop) + " are possible!"), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
            }
            else
            {
                int num = (int)Interaction.MsgBox((object)"No skater(s) with a start number in the start list!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        private void JudgeCardForAllSkatersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (this.MaxStartNo() > 0)
            {
                if (checked(Module1.NoJ_GOE + Module1.NoTrj) > 0)
                {
                    this.Qprint.Enqueue(100);
                    MyProject.Forms.Form10.txtPrint.Text = "The Judge cards for all skaters!";
                    MyProject.Forms.Form10.Show();
                    this.BGW();
                }
                else
                {
                    int num1 = (int)Interaction.MsgBox((object)"Wrong selection of Judge no.!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
            }
            else
            {
                int num2 = (int)Interaction.MsgBox((object)"No skater(s) with a start number in the start list!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        private void Form8PrintPnoDoc1(int i)
        {
            MyProject.Forms.Form8.txtPno.Text = Conversions.ToString(i);
            MyProject.Forms.Form8.PrintDocument1.PrintController = (PrintController)new StandardPrintController();
            MyProject.Forms.Form8.PrintDocument1.Print();
        }

        private void Form8PrintJnoDoc1(int i)
        {
            MyProject.Forms.Form8.txtJno.Text = Conversions.ToString(i);
            MyProject.Forms.Form8.PrintDocument1.PrintController = (PrintController)new StandardPrintController();
            MyProject.Forms.Form8.PrintDocument1.Print();
        }

        private void Form8PrintPnoDoc2(int i)
        {
            MyProject.Forms.Form8.txtPno.Text = Conversions.ToString(i);
            MyProject.Forms.Form8.PrintDocument2.PrintController = (PrintController)new StandardPrintController();
            MyProject.Forms.Form8.PrintDocument2.Print();
        }

        public bool FinishedSeg1()
        {
            bool flag = false;
            int tnop = Module1.TNop;
            int index = 1;
            while (index <= tnop)
            {
                if (Module1.Vek[index].Finished_Seg1 == 1)
                {
                    flag = true;
                    break;
                }
                checked { ++index; }
            }
            return flag;
        }

        public bool OnlyDNSSeg1()
        {
            bool flag = true;
            int tnop = Module1.TNop;
            int index = 1;
            while (index <= tnop)
            {
                if (Module1.Vek[index].DNS_Seg1 == 0)
                {
                    flag = false;
                    break;
                }
                checked { ++index; }
            }
            return flag;
        }

        public bool FinishedSeg2()
        {
            bool flag = false;
            int tnop = Module1.TNop;
            int index = 1;
            while (index <= tnop)
            {
                if (Module1.Vek[index].Finished_Seg2 == 1)
                {
                    flag = true;
                    break;
                }
                checked { ++index; }
            }
            return flag;
        }

        public bool OnlyDNSSeg2()
        {
            bool flag = true;
            int tnop = Module1.TNop;
            int index = 1;
            while (index <= tnop)
            {
                if (Module1.Vek[index].DNS_Seg2 == 0)
                {
                    flag = false;
                    break;
                }
                checked { ++index; }
            }
            return flag;
        }

        private void BackgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.completed5 = false;
                while (this.Qprint.Count > 0)
                {
                    int num3 = this.Qprint.Dequeue();
                    int num4 = num3;
                    if (num4 >= 10 && num4 <= 19)
                    {
                        int num5 = checked(num3 - 10);
                        MyProject.Forms.Dialog8.CreateHeadPage();
                        MyProject.Forms.Dialog8.PrintDocument1.PrinterSettings.Copies = checked((short)num5);
                        MyProject.Forms.Dialog8.PrintDocument1.PrintController = (PrintController)new StandardPrintController();
                        MyProject.Forms.Dialog8.PrintDocument1.Print();
                    }
                    else if (num4 >= 20 && num4 <= 29)
                    {
                        int num6 = checked(num3 - 20);
                        MyProject.Forms.Form2.PrintEntries();
                        MyProject.Forms.Form2.PrintDocument2.PrinterSettings.Copies = checked((short)num6);
                        MyProject.Forms.Form2.PrintDocument2.PrintController = (PrintController)new StandardPrintController();
                        MyProject.Forms.Form2.PrintDocument2.Print();
                    }
                    else if (num4 >= 30 && num4 <= 39)
                    {
                        int num7 = checked(num3 - 30);
                        MyProject.Forms.Form2.PrintStartList();
                        MyProject.Forms.Form2.PrintDocument1.PrinterSettings.Copies = checked((short)num7);
                        MyProject.Forms.Form2.PrintDocument1.PrintController = (PrintController)new StandardPrintController();
                        MyProject.Forms.Form2.PrintDocument1.Print();
                    }
                    else if (num4 >= 40 && num4 <= 49)
                    {
                        if (Module1.IsFormOpen((Form)MyProject.Forms.Form7))
                            MyProject.Forms.Form7.Close();
                        int num8 = checked(num3 - 40);
                        int num9 = 1;
                        while (num9 <= num8)
                        {
                            string segment = Module1.Segment;
                            if (Operators.CompareString(segment, "Seg1", false) == 0)
                            {
                                if (Operators.CompareString(Module1.Datum.Seg1Start, "", false) == 0)
                                    Module1.Datum.Seg1Start = Conversions.ToString(1E-05);
                                int DNSnono = 0;
                                MyProject.Forms.Form2.SortWSListSeg1(Module1.TNop, ref DNSnono);
                                MyProject.Forms.Form7.txtPartNo.Text = Conversions.ToString(checked(Module1.TNop - DNSnono));
                            }
                            else if (Operators.CompareString(segment, "Seg2", false) == 0)
                            {
                                if (Operators.CompareString(Module1.Datum.Seg2Start, "", false) == 0)
                                    Module1.Datum.Seg2Start = Conversions.ToString(1E-05);
                                int DNS_Seg1 = 0;
                                int DNSnono = 0;
                                MyProject.Forms.Form2.SortWSListSeg2(Module1.TNop, ref DNS_Seg1, ref DNSnono);
                                MyProject.Forms.Form7.txtPartNo.Text = Conversions.ToString(checked(Module1.TNop - DNS_Seg1 - DNSnono));
                            }
                            MyProject.Forms.Form7.txtPar.Text = Conversions.ToString(3);
                            MyProject.Forms.Form7.CreateWarmUp();
                            MyProject.Forms.Form7.txtPar.Text = Conversions.ToString(30);
                            MyProject.Forms.Form7.PRINTToolStripMenuItem.PerformClick();
                            checked { ++num9; }
                        }
                    }
                    else if (num4 >= 100 && num4 <= 199)
                    {
                        string segment1 = Module1.Segment;
                        if (Operators.CompareString(segment1, "Seg1", false) == 0)
                            Module1.SortListStartNo(Module1.TNop);
                        else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                            Module1.SortStartNoSeg2(Module1.TNop, ref Module1.DNS_Seg1);
                        int num10 = checked(Module1.NoJ_GOE + Module1.NoTrj);
                        int num11 = 1;
                        while (num11 <= num10)
                        {
                            MyProject.Forms.Form8.txtJno.Text = Conversions.ToString(num11);
                            int num12 = this.MaxStartNo();
                            int i = 1;
                            while (i <= num12)
                            {
                                string segment2 = Module1.Segment;
                                if (Operators.CompareString(segment2, "Seg1", false) == 0)
                                {
                                    if (Module1.Vek[i].Startno_Seg1 > 0)
                                        this.Form8PrintPnoDoc1(i);
                                }
                                else if (Operators.CompareString(segment2, "Seg2", false) == 0 && Module1.Vek[i].Startno_Seg2 > 0)
                                    this.Form8PrintPnoDoc1(i);
                                checked { ++i; }
                            }
                            checked { ++num11; }
                        }
                        if (Module1.JudgeSel == 1)
                        {
                            MyProject.Forms.Form8.txtJno.Text = Conversions.ToString(7);
                            int num13 = this.MaxStartNo();
                            int i = 1;
                            while (i <= num13)
                            {
                                string segment3 = Module1.Segment;
                                if (Operators.CompareString(segment3, "Seg1", false) == 0)
                                {
                                    if (Module1.Vek[i].Startno_Seg1 > 0)
                                        this.Form8PrintPnoDoc1(i);
                                }
                                else if (Operators.CompareString(segment3, "Seg2", false) == 0 && Module1.Vek[i].Startno_Seg2 > 0)
                                    this.Form8PrintPnoDoc1(i);
                                checked { ++i; }
                            }
                        }
                    }
                    else if (num4 >= 200 && num4 <= 299)
                    {
                        MyProject.Forms.Form8.txtJno.Text = Conversions.ToString(checked(num3 - 200));
                        string segment = Module1.Segment;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                        {
                            Module1.SortListStartNo(Module1.TNop);
                            int num14 = this.MaxStartNo();
                            int i = 1;
                            while (i <= num14)
                            {
                                if (Module1.Vek[i].Startno_Seg1 > 0)
                                    this.Form8PrintPnoDoc1(i);
                                checked { ++i; }
                            }
                        }
                        else if (Operators.CompareString(segment, "Seg2", false) == 0)
                        {
                            Module1.SortStartNoSeg2(Module1.TNop, ref Module1.DNS_Seg1);
                            int num15 = this.MaxStartNo();
                            int i = 1;
                            while (i <= num15)
                            {
                                if (Module1.Vek[i].Startno_Seg2 > 0)
                                    this.Form8PrintPnoDoc1(i);
                                checked { ++i; }
                            }
                        }
                    }
                    else if (num4 >= 300 && num4 <= 399)
                    {
                        MyProject.Forms.Form8.txtPno.Text = Conversions.ToString(checked(num3 - 300));
                        string segment = Module1.Segment;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                            Module1.SortListStartNo(Module1.TNop);
                        else if (Operators.CompareString(segment, "Seg2", false) == 0)
                            Module1.SortStartNoSeg2(Module1.TNop, ref Module1.DNS_Seg1);
                        int num16 = checked(Module1.NoJ_GOE + Module1.NoTrj);
                        int i = 1;
                        while (i <= num16)
                        {
                            this.Form8PrintJnoDoc1(i);
                            checked { ++i; }
                        }
                        if (Module1.JudgeSel == 1)
                            this.Form8PrintJnoDoc1(7);
                    }
                    else if (num4 >= 400 && num4 <= 499)
                    {
                        string segment4 = Module1.Segment;
                        if (Operators.CompareString(segment4, "Seg1", false) == 0)
                            MyProject.Forms.Form8.txtTCTSName.Text = Module1.Controller.Seg1.Name;
                        else if (Operators.CompareString(segment4, "Seg2", false) == 0)
                            MyProject.Forms.Form8.txtTCTSName.Text = Module1.Controller.Seg2.Name;
                        string segment5 = Module1.Segment;
                        if (Operators.CompareString(segment5, "Seg1", false) == 0)
                        {
                            Module1.SortListStartNo(Module1.TNop);
                            int num17 = this.MaxStartNo();
                            int i = 1;
                            while (i <= num17)
                            {
                                if (Module1.Vek[i].Startno_Seg1 > 0)
                                    this.Form8PrintPnoDoc2(i);
                                checked { ++i; }
                            }
                        }
                        else if (Operators.CompareString(segment5, "Seg2", false) == 0)
                        {
                            Module1.SortStartNoSeg2(Module1.TNop, ref Module1.DNS_Seg1);
                            int num18 = this.MaxStartNo();
                            int i = 1;
                            while (i <= num18)
                            {
                                if (Module1.Vek[i].Startno_Seg2 > 0)
                                    this.Form8PrintPnoDoc2(i);
                                checked { ++i; }
                            }
                        }
                    }
                    else if (num4 >= 500 && num4 <= 599)
                    {
                        string segment6 = Module1.Segment;
                        if (Operators.CompareString(segment6, "Seg1", false) == 0)
                            MyProject.Forms.Form8.txtTCTSName.Text = Module1.Controller.Seg1.Name;
                        else if (Operators.CompareString(segment6, "Seg2", false) == 0)
                            MyProject.Forms.Form8.txtTCTSName.Text = Module1.Controller.Seg2.Name;
                        string segment7 = Module1.Segment;
                        if (Operators.CompareString(segment7, "Seg1", false) == 0)
                        {
                            Module1.SortListStartNo(Module1.TNop);
                            int num19 = this.MaxStartNo();
                            int i = 1;
                            while (i <= num19)
                            {
                                if (Module1.Vek[i].Startno_Seg1 > 0)
                                    this.Form8PrintPnoDoc2(i);
                                checked { ++i; }
                            }
                        }
                        else if (Operators.CompareString(segment7, "Seg2", false) == 0)
                        {
                            Module1.SortStartNoSeg2(Module1.TNop, ref Module1.DNS_Seg1);
                            int num20 = this.MaxStartNo();
                            int i = 1;
                            while (i <= num20)
                            {
                                if (Module1.Vek[i].Startno_Seg2 > 0)
                                    this.Form8PrintPnoDoc2(i);
                                checked { ++i; }
                            }
                        }
                        string segment8 = Module1.Segment;
                        if (Operators.CompareString(segment8, "Seg1", false) == 0)
                            MyProject.Forms.Form8.txtTCTSName.Text = Module1.Techspec.Seg1.Name;
                        else if (Operators.CompareString(segment8, "Seg2", false) == 0)
                            MyProject.Forms.Form8.txtTCTSName.Text = Module1.Techspec.Seg2.Name;
                        string segment9 = Module1.Segment;
                        if (Operators.CompareString(segment9, "Seg1", false) == 0)
                        {
                            Module1.SortListStartNo(Module1.TNop);
                            int num21 = this.MaxStartNo();
                            int i = 1;
                            while (i <= num21)
                            {
                                if (Module1.Vek[i].Startno_Seg1 > 0)
                                    this.Form8PrintPnoDoc2(i);
                                checked { ++i; }
                            }
                        }
                        else if (Operators.CompareString(segment9, "Seg2", false) == 0)
                        {
                            Module1.SortStartNoSeg2(Module1.TNop, ref Module1.DNS_Seg1);
                            int num22 = this.MaxStartNo();
                            int i = 1;
                            while (i <= num22)
                            {
                                if (Module1.Vek[i].Startno_Seg2 > 0)
                                    this.Form8PrintPnoDoc2(i);
                                checked { ++i; }
                            }
                        }
                    }
                    else if (num4 >= 600 && num4 <= 699)
                    {
                        int i = checked(num3 - 600);
                        string segment10 = Module1.Segment;
                        if (Operators.CompareString(segment10, "Seg1", false) == 0)
                            Module1.SortListStartNo(Module1.TNop);
                        else if (Operators.CompareString(segment10, "Seg2", false) == 0)
                            Module1.SortStartNoSeg2(Module1.TNop, ref Module1.DNS_Seg1);
                        string segment11 = Module1.Segment;
                        if (Operators.CompareString(segment11, "Seg1", false) == 0)
                        {
                            MyProject.Forms.Form8.txtTCTSName.Text = Module1.Controller.Seg1.Name;
                            this.Form8PrintPnoDoc2(i);
                            MyProject.Forms.Form8.txtTCTSName.Text = Module1.Techspec.Seg1.Name;
                        }
                        else if (Operators.CompareString(segment11, "Seg2", false) == 0)
                        {
                            MyProject.Forms.Form8.txtTCTSName.Text = Module1.Controller.Seg2.Name;
                            this.Form8PrintPnoDoc2(i);
                            MyProject.Forms.Form8.txtTCTSName.Text = Module1.Techspec.Seg2.Name;
                        }
                        this.Form8PrintPnoDoc2(i);
                    }
                    else if (num4 >= 800 && num4 <= 809)
                    {
                        this.CloseFormsDialogs();
                        int num23 = checked(num3 - 800);
                        string segment = Module1.Segment;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                        {
                            MyProject.Forms.Form6.printSeg = "Seg1";
                            MyProject.Forms.Form6.PrintDocument1.PrinterSettings.Copies = checked((short)num23);
                            MyProject.Forms.Form6.PrintDocument1.PrintController = (PrintController)new StandardPrintController();
                            MyProject.Forms.Form6.PrintDocument1.Print();
                        }
                        else if (Operators.CompareString(segment, "Seg2", false) == 0)
                        {
                            MyProject.Forms.Form6.printSeg = "Seg2";
                            MyProject.Forms.Form6.PrintDocument1.PrinterSettings.Copies = checked((short)num23);
                            MyProject.Forms.Form6.PrintDocument1.PrintController = (PrintController)new StandardPrintController();
                            MyProject.Forms.Form6.PrintDocument1.Print();
                            if (Operators.CompareString(Module1.GetSeg(), "SF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "FF", false) == 0 | Operators.CompareString(Module1.GetSeg(), "SS", false) == 0)
                            {
                                MyProject.Forms.Form6.printSeg = "Final";
                                MyProject.Forms.Form6.PrintDocument1.PrinterSettings.Copies = checked((short)num23);
                                MyProject.Forms.Form6.PrintDocument1.PrintController = (PrintController)new StandardPrintController();
                                MyProject.Forms.Form6.PrintDocument1.Print();
                            }
                        }
                    }
                    else if (num4 >= 900 && num4 <= 909)
                    {
                        this.CloseFormsDialogs();
                        Module1.JDperPage = 2;
                        MyProject.Forms.Form4.txtNoOfCopies.Text = "0";
                        MyProject.Forms.Form4.txtPrint.Text = "1";
                        MyProject.Forms.Form4.CreateJDAllSkaters(0);
                        MyProject.Forms.Form4.PrintDocument2.PrinterSettings.Copies = checked((short)(num3 - 900));
                        MyProject.Forms.Form4.PrintDocument2.PrintController = (PrintController)new StandardPrintController();
                        MyProject.Forms.Form4.PrintDocument2.Print();
                    }
                    else if (num4 >= 910 && num4 <= 919)
                    {
                        this.CloseFormsDialogs();
                        Module1.JDperPage = 2;
                        MyProject.Forms.Form4.txtNoOfCopies.Text = "0";
                        MyProject.Forms.Form4.txtPrint.Text = "0";
                        MyProject.Forms.Form4.CreateJDAllSkaters(0);
                        MyProject.Forms.Form4.PrintDocument2.PrinterSettings.Copies = checked((short)(num3 - 910));
                        MyProject.Forms.Form4.PrintDocument2.PrintController = (PrintController)new StandardPrintController();
                        MyProject.Forms.Form4.PrintDocument2.Print();
                    }
                    else if (num4 >= 920 && num4 <= 929)
                    {
                        this.CloseFormsDialogs();
                        Module1.JDperPage = 1;
                        MyProject.Forms.Form4.txtNoOfCopies.Text = "0";
                        MyProject.Forms.Form4.txtPrint.Text = "0";
                        MyProject.Forms.Form4.CreateJDAllSkaters(0);
                        MyProject.Forms.Form4.PrintDocument2.PrinterSettings.Copies = checked((short)(num3 - 920));
                        MyProject.Forms.Form4.PrintDocument2.PrintController = (PrintController)new StandardPrintController();
                        MyProject.Forms.Form4.PrintDocument2.Print();
                    }
                }
                goto label_148;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num24 = (int)Interaction.MsgBox((object)("Form1, BackgroundWorker5_DoWork - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_148:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void BackgroundWorker5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.EnableMenu();
            if (Module1.WorkMode == 1)
                this.EnableTextboxes(true);
            this.completed5 = true;
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form10))
                MyProject.Forms.Form10.Close();
            if (!Module1.IsFormOpen((Form)MyProject.Forms.Form11))
                return;
            MyProject.Forms.Form11.Close();
        }

        public void BGW()
        {
            if (!this.completed5)
                return;
            this.DisableMenu();
            if (Module1.WorkMode == 1)
                this.EnableTextboxes(false);
            this.BackgroundWorker5.RunWorkerAsync();
        }

        public void DisableMenu()
        {
            this.LoadCategoryToolStripMenuItem.Enabled = false;
            this.ClearDataToolStripMenuItem.Enabled = false;
            this.ExitToolStripMenuItem1.Enabled = false;
            this.CompetitionToolStripMenuItem.Enabled = false;
            this.ModeSelectionToolStripMenuItem.Enabled = false;
            this.COPYOFFICIALSToolStripMenuItem.Enabled = false;
            this.SHOWRESULTSToolStripMenuItem.Enabled = false;
            this.HeadPageToolStripMenuItem1.Enabled = false;
            this.CategorySelectionToolStripMenuItem.Enabled = false;
            this.JudgesSetupToolStripMenuItem.Enabled = false;
            this.NetworkToolStripMenuItem.Enabled = false;
        }

        public void EnableMenu()
        {
            this.LoadCategoryToolStripMenuItem.Enabled = true;
            this.ClearDataToolStripMenuItem.Enabled = true;
            this.ExitToolStripMenuItem1.Enabled = true;
            this.CompetitionToolStripMenuItem.Enabled = true;
            this.ModeSelectionToolStripMenuItem.Enabled = true;
            this.COPYOFFICIALSToolStripMenuItem.Enabled = true;
            this.SHOWRESULTSToolStripMenuItem.Enabled = true;
            this.HeadPageToolStripMenuItem1.Enabled = true;
            this.CategorySelectionToolStripMenuItem.Enabled = true;
            this.JudgesSetupToolStripMenuItem.Enabled = true;
            this.NetworkToolStripMenuItem.Enabled = true;
        }

        private void PRINTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Module1.WorkMode <= 1)
                return;
            if (Module1.NoTrj > 0 | Module1.JudgeSel > 0)
            {
                this.JudgesDetailsToolStripMenuItem.Visible = true;
                this.JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem.Visible = true;
            }
            else
            {
                this.JudgesDetailsToolStripMenuItem.Visible = false;
                this.JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem.Visible = true;
            }
        }

        private void JudgesDetailsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (this.TstStartNo())
            {
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    if (!this.FinishedSeg1())
                    {
                        int num = (int)Interaction.MsgBox((object)"The short program is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        return;
                    }
                }
                else if (Operators.CompareString(segment, "Seg2", false) == 0 && !this.FinishedSeg2())
                {
                    int num = (int)Interaction.MsgBox((object)"The free skating is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    return;
                }
                int num1 = checked((int)Math.Round(Conversion.Val(Interaction.InputBox("Number of copies, 0-9?", "Susanne SW", Conversions.ToString(1)))));
                if (!(num1 > 0 & num1 < 10))
                    return;
                switch (Module1.WorkMode)
                {
                    case 2:
                    case 3:
                        this.Qprint.Enqueue(checked(900 + num1));
                        MyProject.Forms.Form10.txtPrint.Text = "Judges Details with Tr. Judge and Referee!";
                        MyProject.Forms.Form10.Show();
                        this.BGW();
                        break;
                }
            }
            else
            {
                int num2 = (int)Interaction.MsgBox((object)"Start numbers are not defined!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        private void JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem_Click(
          object sender,
          EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (this.TstStartNo())
            {
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    if (!this.FinishedSeg1())
                    {
                        int num = (int)Interaction.MsgBox((object)"The short program is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        return;
                    }
                }
                else if (Operators.CompareString(segment, "Seg2", false) == 0 && !this.FinishedSeg2())
                {
                    int num = (int)Interaction.MsgBox((object)"The free skating is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    return;
                }
                int num1 = checked((int)Math.Round(Conversion.Val(Interaction.InputBox("Number of copies, 0-9?", "Susanne SW", Conversions.ToString(1)))));
                if (!(num1 > 0 & num1 < 10))
                    return;
                switch (Module1.WorkMode)
                {
                    case 2:
                    case 3:
                        this.Qprint.Enqueue(checked(910 + num1));
                        MyProject.Forms.Form10.txtPrint.Text = "Judges Details without Tr. Judge and Referee!";
                        MyProject.Forms.Form10.Show();
                        this.BGW();
                        break;
                }
            }
            else
            {
                int num2 = (int)Interaction.MsgBox((object)"Start numbers are not defined!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case 112:
                case 115:
                case 119:
                    this.FuncKeysModule((Keys)e.KeyValue);
                    e.Handled = true;
                    break;
            }
            if (e.KeyCode == Keys.L && e.Modifiers == Keys.Control)
            {
                this.LoadCategory();
                e.Handled = true;
            }
            else
            {
                if (e.KeyCode != Keys.S || e.Modifiers != Keys.Control || Strings.Len(Module1.CategoryFileName) <= 1)
                    return;
                if (Interaction.MsgBox((object)"Do you want to save everything in the the database?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.Yes)
                    Module1.SaveCategoryFile(Module1.CategoryFileName);
                e.Handled = true;
            }
        }

        public void FuncKeysModule(Keys value)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                switch (value)
                {
                    case Keys.F1:
                        num3 = 6;
                        Interaction.Shell("hh.exe Help.chm", AppWinStyle.NormalFocus);
                        break;
                    case Keys.F4:
                        num3 = 9;
                        this.Ping();
                        break;
                    case Keys.F8:
                        num3 = 12;
                        if (Interaction.MsgBox((object)"Do you really want to close all Clients?", MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.Yes)
                        {
                            num3 = 13;
                            string str = "&#EXIT#&;";
                            num3 = 14;
                            int length = str.Length;
                            num3 = 15;
                            string msg = Strings.Trim(Conversions.ToString(length)) + ";" + str;
                            num3 = 16;
                            this.SendMessage(msg);
                            break;
                        }
                        break;
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

        public void Ping()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string[] strArray1 = new string[12];
                string[] strArray2 = new string[12];
                string[] strArray3 = new string[12];
                string[] strArray4 = new string[12];
                ProjectData.ClearProjectError();
                num1 = 2;
                int ind = 1;
                do
                {
                    if (Strings.Len(Module1.IPArr[ind]) > 3)
                    {
                        this.GetIP(Module1.IPArr[ind], ref strArray2[ind]);
                        if (this.PingOne(strArray2[ind], ref strArray3[ind]))
                        {
                            strArray1[ind] = "True";
                            strArray4[ind] = Conversions.ToString(Module1.GetJudgeNo((object)ind));
                        }
                        else
                            strArray1[ind] = "False";
                    }
                    checked { ++ind; }
                }
                while (ind <= 11);
                int index = 1;
                do
                {
                    string key1 = "txtCno" + Conversions.ToString(index);
                    string key2 = "txtIP" + Conversions.ToString(index);
                    string key3 = "txtStat" + Conversions.ToString(index);
                    string key4 = "txtJno" + Conversions.ToString(index);
                    string key5 = "txtDelay" + Conversions.ToString(index);
                    MyProject.Forms.NetworkStatusDialog.Controls[key2].Text = strArray2[index];
                    MyProject.Forms.NetworkStatusDialog.Controls[key3].Text = strArray1[index];
                    MyProject.Forms.NetworkStatusDialog.Controls[key5].Text = strArray3[index];
                    if (index <= 7)
                    {
                        MyProject.Forms.NetworkStatusDialog.Controls[key1].Text = Conversions.ToString(index);
                        MyProject.Forms.NetworkStatusDialog.Controls[key4].Text = strArray4[index];
                    }
                    checked { ++index; }
                }
                while (index <= 11);
                if (Module1.IsFormOpen((Form)MyProject.Forms.NetworkStatusDialog))
                    MyProject.Forms.NetworkStatusDialog.Close();
                int num3 = (int)MyProject.Forms.NetworkStatusDialog.ShowDialog();
                goto label_19;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("Ping - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_19:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void GetIP(string EndPoint, ref string IPadr)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string[] strArray1 = new string[11];
                ProjectData.ClearProjectError();
                num1 = 2;
                IPadr = "";
                string[] strArray2 = EndPoint.Split(':');
                IPadr = strArray2[0];
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("GeIP - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public bool PingOne(string IpAdr, ref string UsedTime)
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                DateTime now1 = DateAndTime.Now;
                DateTime now2;
                if (MyProject.Computer.Network.Ping(IpAdr, Module1.PingTimeout))
                {
                    now2 = DateAndTime.Now;
                    flag = true;
                }
                else
                {
                    now2 = DateAndTime.Now;
                    flag = false;
                }
                TimeSpan timeSpan = now2.Subtract(now1);
                UsedTime = timeSpan.TotalSeconds.ToString("0.000000");
                goto label_9;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("PingOne - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_9:
            int num4 = flag ? 1 : 0;
            if (num2 == 0)
                return num4 != 0;
            ProjectData.ClearProjectError();
            return num4 != 0;
        }

        private bool IDataObject(object oPingResult) => throw new NotImplementedException();

        private void btnSeg1_Click(object sender, EventArgs e)
        {
            if (!this.completed5)
                Module1.PrinterMessage();
            else
                this.btnSeg1_1();
        }

        private void btnSeg2_Click(object sender, EventArgs e)
        {
            if (!this.completed5)
                Module1.PrinterMessage();
            else
                this.btnSeg2_1();
        }

        private void btnSeg1_1()
        {
            if (Module1.PcIndex < 0)
                return;
            string segment1 = Module1.OpenDB[Module1.PcIndex].Segment_1;
            if (Operators.CompareString(segment1, "S", false) == 0)
            {
                if ((Operators.CompareString(Module1.OpenDB[Module1.PcIndex].Segment_2, "F", false) == 0 | Operators.CompareString(Module1.OpenDB[Module1.PcIndex].Segment_2, "S", false) == 0) & Operators.CompareString(Module1.Segment, "Seg2", false) == 0)
                {
                    this.CloseFormsDialogs();
                    this.btnSeg1.BackColor = Color.Green;
                    this.btnSeg2.BackColor = SystemColors.Control;
                }
                Module1.Segment = "Seg1";
            }
            else if (Operators.CompareString(segment1, "F", false) == 0)
            {
                if (Operators.CompareString(Module1.OpenDB[Module1.PcIndex].Segment_2, "F", false) == 0 & Operators.CompareString(Module1.Segment, "Seg2", false) == 0)
                {
                    this.CloseFormsDialogs();
                    this.btnSeg1.BackColor = Color.Green;
                    this.btnSeg2.BackColor = SystemColors.Control;
                }
                Module1.Segment = "Seg1";
            }
            Module1.SetNoJ();
            Module1.CreateForm1();
        }

        private void btnSeg2_1()
        {
            if (Module1.PcIndex < 0)
                return;
            string segment2 = Module1.OpenDB[Module1.PcIndex].Segment_2;
            if (Operators.CompareString(segment2, "S", false) == 0)
            {
                if (Operators.CompareString(Module1.OpenDB[Module1.PcIndex].Segment_1, "S", false) == 0 & Operators.CompareString(Module1.Segment, "Seg1", false) == 0)
                {
                    this.CloseFormsDialogs();
                    this.btnSeg1.BackColor = SystemColors.Control;
                    this.btnSeg2.BackColor = Color.Green;
                    Module1.Segment = "Seg2";
                }
            }
            else if (Operators.CompareString(segment2, "F", false) == 0)
            {
                if (Operators.CompareString(Module1.OpenDB[Module1.PcIndex].Segment_1, "S", false) == 0 & Operators.CompareString(Module1.Segment, "Seg1", false) == 0)
                {
                    this.CloseFormsDialogs();
                    this.btnSeg1.BackColor = SystemColors.Control;
                    this.btnSeg2.BackColor = Color.Green;
                    Module1.Segment = "Seg2";
                }
                if (Operators.CompareString(Module1.OpenDB[Module1.PcIndex].Segment_1, "F", false) == 0 & Operators.CompareString(Module1.Segment, "Seg1", false) == 0)
                {
                    this.CloseFormsDialogs();
                    this.btnSeg1.BackColor = SystemColors.Control;
                    this.btnSeg2.BackColor = Color.Green;
                    Module1.Segment = "Seg2";
                }
            }
            Module1.SetNoJ();
            Module1.CreateForm1();
        }

        public void btnSeg1Seg2()
        {
            Form1 form1 = this;
            if (Module1.PcIndex >= 0)
            {
                string seg = Module1.GetSeg();
                if (Operators.CompareString(seg, "0F", false) == 0)
                {
                    form1.lblSeg1.Visible = false;
                    form1.btnSeg1.Visible = false;
                    form1.btnSeg1.BackColor = SystemColors.Control;
                    form1.btnSeg2.Text = "FREE SKATING";
                    form1.btnSeg2.BackColor = Color.Green;
                    form1.lblSeg2.Visible = false;
                    form1.btnSeg2.Visible = true;
                }
                else if (Operators.CompareString(seg, "F0", false) == 0)
                {
                    form1.btnSeg1.Text = "FREE SKATING";
                    form1.lblSeg1.Visible = false;
                    form1.btnSeg1.Visible = true;
                    form1.btnSeg1.BackColor = Color.Green;
                    form1.btnSeg2.BackColor = SystemColors.Control;
                    form1.lblSeg2.Visible = false;
                    form1.btnSeg2.Visible = false;
                }
                else if (Operators.CompareString(seg, "S0", false) == 0)
                {
                    form1.btnSeg1.Text = "SHORT PROGRAM";
                    form1.lblSeg1.Visible = false;
                    form1.btnSeg1.Visible = true;
                    form1.btnSeg1.BackColor = Color.Green;
                    form1.btnSeg2.BackColor = SystemColors.Control;
                    form1.lblSeg2.Visible = false;
                    form1.btnSeg2.Visible = false;
                }
                else if (Operators.CompareString(seg, "SF", false) == 0)
                {
                    form1.btnSeg1.Text = "SHORT PROGRAM";
                    form1.btnSeg2.Text = "FREE SKATING";
                    form1.lblSeg1.Visible = true;
                    form1.btnSeg1.Visible = true;
                    form1.lblSeg2.Visible = true;
                    form1.btnSeg2.Visible = true;
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        form1.btnSeg1.BackColor = Color.Green;
                        form1.btnSeg2.BackColor = SystemColors.Control;
                        form1.btnSeg1.Select();
                    }
                    else
                    {
                        if (Operators.CompareString(segment, "Seg2", false) != 0)
                            return;
                        form1.btnSeg1.BackColor = SystemColors.Control;
                        form1.btnSeg2.BackColor = Color.Green;
                        form1.btnSeg2.Select();
                    }
                }
                else if (Operators.CompareString(seg, "SS", false) == 0)
                {
                    form1.btnSeg1.Text = "SHORT PROGRAM";
                    form1.btnSeg1.Visible = true;
                    form1.btnSeg2.Text = "SHORT PROGRAM";
                    form1.btnSeg2.Visible = true;
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        form1.btnSeg1.BackColor = Color.Green;
                        form1.btnSeg2.BackColor = SystemColors.Control;
                        form1.btnSeg1.Select();
                    }
                    else
                    {
                        if (Operators.CompareString(segment, "Seg2", false) != 0)
                            return;
                        form1.btnSeg1.BackColor = SystemColors.Control;
                        form1.btnSeg2.BackColor = Color.Green;
                        form1.btnSeg2.Select();
                    }
                }
                else
                {
                    if (Operators.CompareString(seg, "FF", false) != 0)
                        return;
                    form1.btnSeg1.Text = "FREE SKATING";
                    form1.btnSeg1.Visible = true;
                    form1.lblSeg1.Visible = true;
                    form1.btnSeg2.Text = "FREE SKATING";
                    form1.btnSeg2.Visible = true;
                    form1.lblSeg2.Visible = true;
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        form1.btnSeg1.BackColor = Color.Green;
                        form1.btnSeg2.BackColor = SystemColors.Control;
                        form1.btnSeg1.Select();
                    }
                    else
                    {
                        if (Operators.CompareString(segment, "Seg2", false) != 0)
                            return;
                        form1.btnSeg1.BackColor = SystemColors.Control;
                        form1.btnSeg2.BackColor = Color.Green;
                        form1.btnSeg2.Select();
                    }
                }
            }
            else
            {
                form1.lblSeg1.Visible = true;
                form1.btnSeg1.Visible = true;
                form1.btnSeg1.BackColor = SystemColors.Control;
                form1.lblSeg2.Visible = true;
                form1.btnSeg2.Visible = true;
                form1.btnSeg2.BackColor = SystemColors.Control;
            }
        }

        public bool ActivPossible()
        {
            bool flag = false;
            if (Module1.TestStart())
            {
                if (Module1.ScanJudges == 0 & !Module1.IsFormOpen((Form)MyProject.Forms.Form2) & !Module1.IsFormOpen((Form)MyProject.Forms.Form5))
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    int num = (int)Interaction.MsgBox((object)"Not possible due to other ongoing functions!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
            }
            return flag;
        }

        public bool MenuPossible()
        {
            bool flag = true;
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form12))
            {
                int num = (int)Interaction.MsgBox((object)"Please close the IndTA ENTRIES!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                flag = false;
            }
            else if (Module1.IsFormOpen((Form)MyProject.Forms.Dialog7))
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
            else if (Module1.IsFormOpen((Form)MyProject.Forms.Form4))
            {
                int num = (int)Interaction.MsgBox((object)"Please close the JUDGES DETAILS!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                flag = false;
            }
            else if (Module1.IsFormOpen((Form)MyProject.Forms.Form2))
            {
                int num = (int)Interaction.MsgBox((object)"Please close the START LIST!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                flag = false;
            }
            return flag;
        }

        private void WarmupGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (this.TstStartNo())
            {
                if (this.TstWarmupGr())
                {
                    int num = checked((int)Math.Round(Conversion.Val(Interaction.InputBox("Number of copies, 0-9?", "Susanne SW", Conversions.ToString(1)))));
                    if (!(num > 0 & num < 10))
                        return;
                    this.Qprint.Enqueue(checked(40 + num));
                    MyProject.Forms.Form10.txtPrint.Text = "Warmup Groups!";
                    MyProject.Forms.Form10.Show();
                    this.BGW();
                }
                else
                {
                    int num1 = (int)Interaction.MsgBox((object)"The Warmup Groups are not yet created!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                }
            }
            else
            {
                int num2 = (int)Interaction.MsgBox((object)"The start numbers are not yet created!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        public bool TstWarmupGr()
        {
            bool flag = true;
            string segment = Module1.Segment;
            if (Operators.CompareString(segment, "Seg1", false) == 0)
            {
                int tnop = Module1.TNop;
                int index = 1;
                while (index <= tnop)
                {
                    if (Module1.Vek[index].WarmUp_Seg1 == 0 & Module1.Vek[index].DNS_Seg1 == 0)
                        flag = false;
                    checked { ++index; }
                }
            }
            else if (Operators.CompareString(segment, "Seg2", false) == 0)
            {
                int tnop = Module1.TNop;
                int index = 1;
                while (index <= tnop)
                {
                    if (Module1.Vek[index].WarmUp_Seg2 == 0 & Module1.Vek[index].DNS_Seg1 == 0 & Module1.Vek[index].DNS_Seg2 == 0)
                        flag = false;
                    checked { ++index; }
                }
            }
            return flag;
        }

        private void LeavedCompetition()
        {
            if (Module1.WorkMode != 1 || this.Loading | this.WillExit | !Module1.Form1_TxtBoxEnabled)
                return;
            if (!this.Loading & Strings.Len(Module1.Category.Name) > 0)
            {
                string str = Module1.StrConv(Module1.Competition.Name + "_" + Module1.Category.Name + Module1.SubCat_() + ".xml");
                if (Module1.CategoryFileName.Contains(str))
                    return;
                this.GetInputForm1();
                Module1.SaveCategoryFile(Module1.CategoryFileName);
            }
            else
            {
                int num = (int)Interaction.MsgBox((object)"Select a Category?", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                this.CategorySelectionToolStripMenuItem.PerformClick();
            }
        }

        private void txtCompetitionName_TextChanged(object sender, EventArgs e)
        {
            if (Module1.WorkMode != 1)
                return;
            Module1.Competition.Name = this.txtCompetitionName.Text;
        }

        private void txtCompetitionName_Leave(object sender, EventArgs e)
        {
            if (!this.txtCompetitionName.Enabled)
                return;
            this.LeavedCompetition();
        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            if (Module1.WorkMode != 1)
                return;
            Module1.Competition.Type = this.txtType.Text;
        }

        private void txtType_Leave(object sender, EventArgs e) => this.Leaved();

        private void txtCompetitionID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                return;
            e.KeyChar = char.MinValue;
        }

        private void txtCompetitionID_Leave(object sender, EventArgs e) => this.Leaved();

        private void txtOrganizerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '!':
                case '"':
                case '&':
                case '\'':
                case '*':
                case '+':
                case ',':
                case '.':
                case '/':
                case ':':
                case ';':
                case '<':
                case '>':
                case '?':
                case '[':
                case '\\':
                case ']':
                case '~':
                    e.Handled = true;
                    break;
            }
        }

        private void txtOrganizerName_Leave(object sender, EventArgs e)
        {
            if (!this.txtOrganizerName.Enabled)
                return;
            this.LeavedCompetition();
        }

        private void txtOrganizerName_TextChanged(object sender, EventArgs e)
        {
            if (Module1.WorkMode != 1)
                return;
            Module1.Organizer.Name = this.txtOrganizerName.Text;
        }

        private void txtOrganizerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                return;
            e.KeyChar = char.MinValue;
        }

        private void txtOrganizerID_Leave(object sender, EventArgs e) => this.Leaved();

        private void Leaved()
        {
            if (!Module1.Form1_TxtBoxEnabled || !(Module1.WorkMode == 1 & !this.Loading & Strings.Len(Module1.CategoryFileName) > 0))
                return;
            this.GetInputForm1();
            Module1.SaveCategoryFile(Module1.CategoryFileName);
        }

        private void TechSpecName_Leave(object sender, EventArgs e) => this.Leaved();

        private void TechSpecClub_Leave(object sender, EventArgs e) => this.Leaved();

        private void ControllerName_Leave(object sender, EventArgs e) => this.Leaved();

        private void ControllerClub_Leave(object sender, EventArgs e) => this.Leaved();

        private void RefereeName_Leave(object sender, EventArgs e) => this.Leaved();

        private void RefereeClub_Leave(object sender, EventArgs e) => this.Leaved();

        private void DVOName1_Leave(object sender, EventArgs e) => this.Leaved();

        private void DVOClub1_Leave(object sender, EventArgs e) => this.Leaved();

        private void DVOName2_Leave(object sender, EventArgs e) => this.Leaved();

        private void DVOClub2_Leave(object sender, EventArgs e) => this.Leaved();

        private void DVOName3_Leave(object sender, EventArgs e) => this.Leaved();

        private void DVOClub3_Leave(object sender, EventArgs e) => this.Leaved();

        private void JudgeName1_Leave(object sender, EventArgs e) => this.Leaved();

        private void JudgeClub1_Leave(object sender, EventArgs e) => this.Leaved();

        private void JudgeName2_Leave(object sender, EventArgs e) => this.Leaved();

        private void JudgeClub2_Leave(object sender, EventArgs e) => this.Leaved();

        private void JudgeName3_Leave(object sender, EventArgs e) => this.Leaved();

        private void JudgeClub3_Leave(object sender, EventArgs e) => this.Leaved();

        private void JudgeName4_Leave(object sender, EventArgs e) => this.Leaved();

        private void JudgeClub4_Leave(object sender, EventArgs e) => this.Leaved();

        private void JudgeName5_Leave(object sender, EventArgs e) => this.Leaved();

        private void JudgeClub5_Leave(object sender, EventArgs e) => this.Leaved();

        private void JudgeName6_Leave(object sender, EventArgs e) => this.Leaved();

        private void JudgeClub6_Leave(object sender, EventArgs e) => this.Leaved();

        private void JudgeName7_Leave(object sender, EventArgs e) => this.Leaved();

        private void JudgeClub7_Leave(object sender, EventArgs e) => this.Leaved();

        private void COPYOFFICIALSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !Module1.TestStart())
                return;
            string segment = Module1.Segment;
            if (Operators.CompareString(segment, "Seg1", false) == 0)
            {
                string seg = Module1.GetSeg();
                if (Operators.CompareString(seg, "SS", false) != 0 && Operators.CompareString(seg, "SF", false) != 0 && Operators.CompareString(seg, "FF", false) != 0 || Interaction.MsgBox((object)"Do you want to copy the officals to segment 2?", MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") != MsgBoxResult.Yes)
                    return;
                this.CopyOfficialsTo2();
                Module1.SaveCategoryFile(Module1.CategoryFileName);
            }
            else
            {
                if (Operators.CompareString(segment, "Seg2", false) != 0)
                    return;
                string seg = Module1.GetSeg();
                if (Operators.CompareString(seg, "SS", false) != 0 && Operators.CompareString(seg, "SF", false) != 0 && Operators.CompareString(seg, "FF", false) != 0 || Interaction.MsgBox((object)"Do you want to copy the officals to segment 1?", MsgBoxStyle.YesNo | MsgBoxStyle.DefaultButton2 | MsgBoxStyle.SystemModal, (object)"Susanne SW") != MsgBoxResult.Yes)
                    return;
                this.CopyOfficialsTo1();
                Module1.SaveCategoryFile(Module1.CategoryFileName);
            }
        }

        public void CopyOfficialsTo1()
        {
            Module1.Techspec.Seg1.Name = Module1.Techspec.Seg2.Name;
            Module1.Techspec.Seg1.Club = Module1.Techspec.Seg2.Club;
            Module1.Controller.Seg1.Name = Module1.Controller.Seg2.Name;
            Module1.Controller.Seg1.Club = Module1.Controller.Seg2.Club;
            Module1.Referee.Seg1.Name = Module1.Referee.Seg2.Name;
            Module1.Referee.Seg1.Club = Module1.Referee.Seg2.Club;
            int index1 = 1;
            do
            {
                Module1.Judge[index1].Seg1.Name = Module1.Judge[index1].Seg2.Name;
                Module1.Judge[index1].Seg1.Club = Module1.Judge[index1].Seg2.Club;
                checked { ++index1; }
            }
            while (index1 <= 7);
            int index2 = 1;
            do
            {
                Module1.DVO[index2].Seg1.Name = Module1.DVO[index2].Seg2.Name;
                Module1.DVO[index2].Seg1.Club = Module1.DVO[index2].Seg2.Club;
                checked { ++index2; }
            }
            while (index2 <= 3);
            Module1.NoJ_Seg1 = Module1.NoJ_Seg2;
            Module1.NoTrJ_Seg1 = Module1.NoTrJ_Seg2;
            Module1.JudgeSel_Seg1 = Module1.JudgeSel_Seg2;
        }

        public void CopyOfficialsTo2()
        {
            Module1.Techspec.Seg2.Name = Module1.Techspec.Seg1.Name;
            Module1.Techspec.Seg2.Club = Module1.Techspec.Seg1.Club;
            Module1.Controller.Seg2.Name = Module1.Controller.Seg1.Name;
            Module1.Controller.Seg2.Club = Module1.Controller.Seg1.Club;
            Module1.Referee.Seg2.Name = Module1.Referee.Seg1.Name;
            Module1.Referee.Seg2.Club = Module1.Referee.Seg1.Club;
            int index1 = 1;
            do
            {
                Module1.Judge[index1].Seg2.Name = Module1.Judge[index1].Seg1.Name;
                Module1.Judge[index1].Seg2.Club = Module1.Judge[index1].Seg1.Club;
                checked { ++index1; }
            }
            while (index1 <= 7);
            int index2 = 1;
            do
            {
                Module1.DVO[index2].Seg2.Name = Module1.DVO[index2].Seg1.Name;
                Module1.DVO[index2].Seg2.Club = Module1.DVO[index2].Seg1.Club;
                checked { ++index2; }
            }
            while (index2 <= 3);
            Module1.NoJ_Seg2 = Module1.NoJ_Seg1;
            Module1.NoTrJ_Seg2 = Module1.NoTrJ_Seg1;
            Module1.JudgeSel_Seg2 = Module1.JudgeSel_Seg1;
        }

        private void EntriesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !Module1.TestStart())
                return;
            MyProject.Forms.Form2.CreateEntriesPDF();
        }

        private void StartListToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !Module1.TestStart())
                return;
            MyProject.Forms.Form2.CreateStartListPDF(1);
        }

        private void HideJudgesComputersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conversions.ToString(0);
            Conversions.ToString(0);
            string str1 = "";
            string Left = "";
            int index = 1;
            do
            {
                int judgeNo = Module1.GetJudgeNo((object)Module1.JudgeCompNo[index]);
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                    Left = Module1.Judge[judgeNo].Seg1.Name;
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    Left = Module1.Judge[judgeNo].Seg2.Name;
                if (Operators.CompareString(Left, "", false) == 0)
                    Left = "-";
                string str2 = Conversions.ToString(Module1.JudgeCompNo[index]);
                string str3 = Conversions.ToString(Module1.JudgeCompFunc[index]);
                str1 = str1 + str2 + ";" + Conversions.ToString(index) + ";" + str3 + ";" + Left + ";";
                checked { ++index; }
            }
            while (index <= 7);
            string str4 = "&#HIDE#&;" + str1;
            this.SendMessage(Strings.Trim(Conversions.ToString(str4.Length)) + ";" + str4);
        }

        public void SendFunc()
        {
            Conversions.ToString(0);
            Conversions.ToString(0);
            string str1 = "";
            string Left = "";
            int index = 1;
            do
            {
                int judgeNo = Module1.GetJudgeNo((object)Module1.JudgeCompNo[index]);
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                    Left = Module1.Judge[judgeNo].Seg1.Name;
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    Left = Module1.Judge[judgeNo].Seg2.Name;
                if (Operators.CompareString(Left, "", false) == 0)
                    Left = "-";
                string str2 = Conversions.ToString(Module1.JudgeCompNo[index]);
                string str3 = Conversions.ToString(Module1.JudgeCompFunc[index]);
                str1 = str1 + str2 + ";" + Conversions.ToString(index) + ";" + str3 + ";" + Left + ";";
                checked { ++index; }
            }
            while (index <= 7);
            string str4 = "&#FUNC#&;" + str1;
            this.SendMessage(Strings.Trim(Conversions.ToString(str4.Length)) + ";" + str4);
        }

        private void UnhudeJudgesDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conversions.ToString(0);
            Conversions.ToString(0);
            string str1 = "";
            string Left = "";
            int index = 1;
            do
            {
                int judgeNo = Module1.GetJudgeNo((object)Module1.JudgeCompNo[index]);
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                    Left = Module1.Judge[judgeNo].Seg1.Name;
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    Left = Module1.Judge[judgeNo].Seg2.Name;
                if (Operators.CompareString(Left, "", false) == 0)
                    Left = "-";
                string str2 = Conversions.ToString(Module1.JudgeCompNo[index]);
                string str3 = Conversions.ToString(Module1.JudgeCompFunc[index]);
                str1 = str1 + str2 + ";" + Conversions.ToString(index) + ";" + str3 + ";" + Left + ";";
                checked { ++index; }
            }
            while (index <= 7);
            string str4 = "&#UNHIDE#&;" + str1;
            this.SendMessage(Strings.Trim(Conversions.ToString(str4.Length)) + ";" + str4);
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            if (!(this.completed3 & Module1.PingClients == 1))
                return;
            this.BackgroundWorker3.RunWorkerAsync();
        }

        private void BackgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                this.completed3 = false;
                int index = 1;
                do
                {
                    if (Strings.Len(Module1.IPArr[index]) > 3)
                    {
                        if (MyProject.Computer.Network.Ping(this.GetIPadr(Module1.IPArr[index]), Module1.PingTimeout))
                        {
                            this.Msg[index] = 0;
                        }
                        else
                        {
                            this.Msg[index] = checked(this.Msg[index] + 1);
                            if (this.Msg[index] > 4)
                                Module1.IPArr[index] = "";
                        }
                    }
                    checked { ++index; }
                }
                while (index <= 11);
                goto label_13;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("BackgroundWorker3_DoWork - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
                this.completed3 = true;
            }
            label_13:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void BackgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) => this.completed3 = true;

        public string GetIPadr(string EndPoint)
        {
            int num1 = 0;
            string str = "";
            int num2 = 0;
            try
            {
                string[] strArray = new string[11];
                ProjectData.ClearProjectError();
                num1 = 2;
                str = "";
                str = EndPoint.Split(':')[0];
                goto label_6;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("GetIPadr - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_6:
            string ipadr = str;
            if (num2 == 0)
                return ipadr;
            ProjectData.ClearProjectError();
            return ipadr;
        }

        private void EntriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !Module1.TestStart())
                return;
            MyProject.Forms.Form2.CreateEntriesPDF();
        }

        private void StartListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible() || !Module1.TestStart())
                return;
            MyProject.Forms.Form2.CreateStartListPDF(1);
        }

        private void OpenDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MenuPossible())
                return;
            this.TopMost = false;
            if (Module1.IsFormOpen((Form)MyProject.Forms.Form3))
                MyProject.Forms.Form3.Close();
            int num = (int)MyProject.Forms.Form3.ShowDialog();
        }

        public void Timer10_Tick(object sender, EventArgs e)
        {
            if (!this.completed10)
                return;
            this.BackgroundWorker10.RunWorkerAsync();
        }

        private void BackgroundWorker10_DoWork(object sender, DoWorkEventArgs e)
        {
            this.completed10 = false;
            this.Timer10.Enabled = false;
            switch (Module1.CreateScoreBoard)
            {
                case 1:
                case 2:
                    Module1.MakeScoreBoard_12(Module1.MakesScoreBoard_StNo);
                    break;
                case 3:
                case 4:
                    Module1.MakeScoreBoard_34(Module1.MakesScoreBoard_StNo);
                    break;
            }
        }

        private void BackgroundWorker10_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) => this.completed10 = true;

        public void MakeJudgeTxtFile(int CompNo)
        {
            this.Qout.Enqueue(CompNo);
            if (this.BackgroundWorker1.IsBusy)
            {
                this.Timer1.Enabled = true;
            }
            else
            {
                if (!this.completed1)
                    return;
                this.BackgroundWorker1.RunWorkerAsync();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Qout.Count > 0)
            {
                if (!this.completed1)
                    return;
                this.BackgroundWorker1.RunWorkerAsync();
            }
            else
                this.Timer1.Enabled = false;
        }

        public void CreateJudgeTxtFile(int CompNo, ref string Outtxt)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 0;
                string str1 = "1";
                string str2 = "0";
                ProjectData.ClearProjectError();
                num1 = 2;
                if (Module1.PNo > 0)
                {
                    int Number1 = Module1.NoOfElement();
                    string progType = Module1.GetProgType(Module1.Segment);
                    if (Operators.CompareString(progType, "Short", false) == 0)
                    {
                        str1 = "11";
                        num3 = Module1.Vek[Module1.PNo].Startno_Seg1;
                    }
                    else if (Operators.CompareString(progType, "Free", false) == 0)
                    {
                        str1 = "12";
                        num3 = Module1.Vek[Module1.PNo].Startno_Seg2;
                    }
                    else
                        Operators.CompareString(progType, "Free", false);
                    switch (CompNo)
                    {
                        case -1:
                            str2 = "1";
                            break;
                        case 0:
                            str2 = "0";
                            break;
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                            Module1.JCStatus[CompNo] = 1;
                            str2 = "1";
                            break;
                    }
                    Outtxt = Strings.Trim(Strings.Trim(Module1.Vek[Module1.PNo].Name.FName) + " " + Strings.Trim(Module1.Vek[Module1.PNo].Name.LName)) + ";" + Strings.Trim(Module1.Vek[Module1.PNo].Club) + ";" + Strings.Trim(Module1.Category.Name) + Strings.Trim(Module1.SubCat()) + ";" + Module1.Segment + ";" + Strings.Trim(Conversions.ToString(num3)) + ";" + Strings.Trim(str2) + ";" + Strings.Trim(Conversion.Str((object)Number1)) + ";" + Strings.Trim(Module1.PCSel()) + ";";
                    int index1 = 1;
                    do
                    {
                        int index2 = Module1.JudgeCompNo[index1];
                        string str3 = Module1.JCStatus[index2] != 1 ? "0" : "1";
                        Outtxt += str3;
                        checked { ++index1; }
                    }
                    while (index1 <= 7);
                    Outtxt += ";";
                    if (Number1 > 0)
                    {
                        int num4 = Number1;
                        int index3 = 1;
                        while (index3 <= num4)
                        {
                            string str4 = "";
                            string str5 = Operators.CompareString(Module1.OpArr[index3].replay, "R", false) != 0 ? "" : "?";
                            string segment = Module1.Segment;
                            if (Operators.CompareString(segment, "Seg1", false) == 0)
                                str4 = Module1.Vek[Module1.PNo].SSS_Seg1[index3] + str5;
                            else if (Operators.CompareString(segment, "Seg2", false) == 0)
                                str4 = Module1.Vek[Module1.PNo].SSS_Seg2[index3] + str5;
                            Outtxt = Outtxt + str4 + ";";
                            checked { ++index3; }
                        }
                    }
                    Outtxt = Module1.CC_Time + ";" + Outtxt;
                    Outtxt = str1 + ";" + Outtxt;
                    int Number2 = Strings.Len(Outtxt);
                    Outtxt = Strings.Trim(Conversion.Str((object)Number2)) + ";" + Outtxt;
                    Module1.LastOutTxt = Outtxt;
                    goto label_27;
                }
                else
                    goto label_27;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("CreateJudgeTxtFile -Description : " + Information.Err().Description), MsgBoxStyle.Critical | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_27:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void CalcBV_and_TEScores(ref string BVScore, ref string TEScore)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string InElement = "";
                bool AfterHalfTime = false;
                double Expression = 0.0;
                ProjectData.ClearProjectError();
                num1 = 2;
                int index = 1;
                do
                {
                    string segment = Module1.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        InElement = Module1.Vek[Module1.PNo].SSS_Seg1[index];
                        AfterHalfTime = Module1.Vek[Module1.PNo].HTIndSeg1 > 0 & index >= Module1.Vek[Module1.PNo].HTIndSeg1;
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        InElement = Module1.Vek[Module1.PNo].SSS_Seg2[index];
                        AfterHalfTime = Module1.Vek[Module1.PNo].HTIndSeg2 > 0 & index >= Module1.Vek[Module1.PNo].HTIndSeg2;
                    }
                    if (!string.IsNullOrEmpty(InElement))
                        Expression += this.Calc_BV(InElement, AfterHalfTime);
                    checked { ++index; }
                }
                while (index <= 15);
                BVScore = Strings.Format((object)Expression, "0.00");
                string segment1 = Module1.Segment;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    TEScore = Strings.Format((object)Module1.Vek[Module1.PNo].TES_Seg1, "0.00");
                    goto label_18;
                }
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                {
                    TEScore = Strings.Format((object)Module1.Vek[Module1.PNo].TES_Seg2, "0.00");
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
                int num3 = (int)Interaction.MsgBox((object)("CalcBV_and_TEScores - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_18:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public double Calc_BV(string InElement, bool AfterHalfTime)
        {
            int num1 = 0;
            double num2 = 0.0;
            int num3 = 0;
            try
            {
                int elDbmax = Module1.ElDBmax;
                ProjectData.ClearProjectError();
                num1 = 2;
                num2 = 0.0;
                if (Strings.Len(Strings.Trim(InElement)) != 0)
                {
                    string str1 = InElement;
                    int num4 = Strings.InStr(1, str1, " !", CompareMethod.Text);
                    if (num4 > 0)
                        str1 = Strings.Left(str1, checked(num4 - 1));
                    string str2 = Module1.Test_SEQ_COMBO_REP(str1);
                    if (Strings.Len(str2) >= 1)
                    {
                        int num5 = Strings.InStr(1, str2, "+COMBO", CompareMethod.Text);
                        if (num5 > 0)
                            str2 = Strings.Left(str2, checked(num5 - 1));
                        double Right = !AfterHalfTime ? 1.0 : 1.1;
                        if (Strings.InStr(1, str2, "+SEQ", CompareMethod.Text) > 0)
                        {
                            int num6 = Strings.InStr(str2, "+SEQ");
                            int Eno = 0;
                            Module1.FindJumpEl1(Strings.Left(str2, checked(num6 - 1)), ref Eno);
                            int num7 = checked(Eno - 1);
                            int index1 = 1;
                            while (index1 <= num7)
                            {
                                string elstr = Module1.ElArr[index1].Elstr;
                                if (elstr.Contains("*"))
                                {
                                    Module1.ElArr[index1].Value = 0.0;
                                    Module1.ElArr[index1].BaseValue = 0.0;
                                    Module1.ElArr[index1].row = 0;
                                }
                                else
                                {
                                    int jumpmin = Module1.Jumpmin;
                                    int jumpMax = Module1.JumpMax;
                                    int index2 = jumpmin;
                                    while (index2 <= jumpMax)
                                    {
                                        if (Operators.ConditionalCompareObjectEqual((object)elstr, Module1.ElDB[index2, 0], false))
                                        {
                                            Module1.ElArr[index1].row = index2;
                                            int index3 = 6;
                                            Module1.ElArr[index1].Value = Conversions.ToDouble(Module1.ElDB[index2, index3]);
                                            Module1.ElArr[index1].BaseValue = Conversions.ToDouble(Module1.ElDB[index2, 6]);
                                            if (Module1.ElArr[index1].Value != 0.0)
                                                break;
                                            break;
                                        }
                                        checked { ++index2; }
                                    }
                                    if (index2 > Module1.JumpMax)
                                        this.ErrMessage_1(InElement);
                                }
                                checked { ++index1; }
                            }
                            int num8 = checked(Eno - 1 - 1);
                            int index4 = 1;
                            while (index4 <= num8)
                            {
                                Module1.El_type elType = Module1.ElArr[index4];
                                int index5 = index4;
                                int num9 = checked(index4 + 1);
                                int num10 = checked(Eno - 1);
                                int index6 = num9;
                                while (index6 <= num10)
                                {
                                    if (Module1.ElArr[index6].BaseValue > elType.BaseValue)
                                    {
                                        elType = Module1.ElArr[index6];
                                        index5 = index6;
                                    }
                                    checked { ++index6; }
                                }
                                Module1.ElArr[index5] = Module1.ElArr[index4];
                                Module1.ElArr[index4] = elType;
                                checked { ++index4; }
                            }
                            int row = Module1.ElArr[1].row;
                            double num11 = Module1.ElArr[2].row != 0 ? Module1.ElArr[2].Value : 0.0;
                            num2 = row <= 0 ? 0.0 : Conversion.Int(100.0 * (num11 + Module1.ElArr[1].Value) * 0.8 + 0.5000001) / 100.0 * Right;
                        }
                        else if (Strings.InStr(1, str2, "+REP", CompareMethod.Text) > 0)
                        {
                            double num12 = 0.0;
                            int num13 = Strings.InStr(str2, "+REP");
                            int Eno = 0;
                            Module1.FindJumpEl1(Strings.Left(str2, checked(num13 - 1)), ref Eno);
                            int num14 = checked(Eno - 1);
                            int index7 = 1;
                            while (index7 <= num14)
                            {
                                string elstr = Module1.ElArr[index7].Elstr;
                                if (elstr.Contains("*"))
                                {
                                    Module1.ElArr[index7].Value = 0.0;
                                    Module1.ElArr[index7].BaseValue = 0.0;
                                    Module1.ElArr[index7].row = 0;
                                }
                                else
                                {
                                    int jumpmin = Module1.Jumpmin;
                                    int jumpMax = Module1.JumpMax;
                                    int index8 = jumpmin;
                                    while (index8 <= jumpMax)
                                    {
                                        if (Operators.ConditionalCompareObjectEqual((object)elstr, Module1.ElDB[index8, 0], false))
                                        {
                                            Module1.ElArr[index7].row = index8;
                                            int index9 = 6;
                                            Module1.ElArr[index7].Value = Conversions.ToDouble(Operators.MultiplyObject(Operators.MultiplyObject(Module1.ElDB[index8, index9], (object)Right), (object)0.7));
                                            Module1.ElArr[index7].BaseValue = Conversions.ToDouble(Module1.ElDB[index8, 6]);
                                            if (Module1.ElArr[index7].Value != 0.0)
                                                break;
                                            break;
                                        }
                                        checked { ++index8; }
                                    }
                                    if (index8 > Module1.JumpMax)
                                        this.ErrMessage_1(InElement);
                                }
                                checked { ++index7; }
                            }
                            Module1.El_type elType;
                            elType.Value = 0.0;
                            elType.BaseValue = 0.0;
                            elType.row = 0;
                            int num15 = checked(Eno - 1);
                            int index10 = 1;
                            while (index10 <= num15)
                            {
                                num12 += Module1.ElArr[index10].Value;
                                if (Module1.ElArr[index10].BaseValue > elType.BaseValue)
                                    elType = Module1.ElArr[index10];
                                checked { ++index10; }
                            }
                            num2 = num12;
                        }
                        else if (str2.Contains("Sp") & Strings.Len(str2) >= 1)
                        {
                            double Left1 = 0.0;
                            int num16 = 0;
                            string Left2 = str2;
                            int spinMin = Module1.SpinMin;
                            int spinmax = Module1.Spinmax;
                            if (Left2.Contains("*"))
                            {
                                Left1 += 0.0;
                            }
                            else
                            {
                                do
                                {
                                    if (Operators.ConditionalCompareObjectNotEqual(Module1.ElDB[spinMin, 0], (object)"", false) && Operators.ConditionalCompareObjectEqual((object)Left2, Module1.ElDB[spinMin, 0], false))
                                    {
                                        num16 = spinMin;
                                        int num17 = spinMin;
                                        if (num17 >= Module1.SpinMin && num17 <= Module1.Spinmax)
                                        {
                                            int index = 6;
                                            Left1 = Conversions.ToDouble(Operators.AddObject((object)Left1, Module1.ElDB[spinMin, index]));
                                        }
                                    }
                                    checked { ++spinMin; }
                                }
                                while (!(spinMin > spinmax | num16 > 0));
                                if (spinMin > checked(Module1.ElDBmax + 2))
                                    this.ErrMessage_1(InElement);
                            }
                            num2 = Left1;
                        }
                        else if (Strings.InStr(1, str2, "+", CompareMethod.Text) > 0 & !str2.Contains("+V"))
                        {
                            double num18 = 0.0;
                            int Eno = 0;
                            Module1.FindJumpEl1(str2, ref Eno);
                            int num19 = checked(Eno - 1);
                            int index11 = 1;
                            while (index11 <= num19)
                            {
                                string elstr = Module1.ElArr[index11].Elstr;
                                if (elstr.Contains("*"))
                                {
                                    Module1.ElArr[index11].Value = 0.0;
                                    Module1.ElArr[index11].BaseValue = 0.0;
                                    Module1.ElArr[index11].row = 0;
                                }
                                else
                                {
                                    int jumpmin = Module1.Jumpmin;
                                    int jumpMax = Module1.JumpMax;
                                    int index12 = jumpmin;
                                    while (index12 <= jumpMax)
                                    {
                                        if (Operators.ConditionalCompareObjectEqual((object)elstr, Module1.ElDB[index12, 0], false))
                                        {
                                            Module1.ElArr[index11].row = index12;
                                            int index13 = 6;
                                            Module1.ElArr[index11].Value = Conversions.ToDouble(Operators.MultiplyObject(Module1.ElDB[index12, index13], (object)Right));
                                            Module1.ElArr[index11].BaseValue = Conversions.ToDouble(Module1.ElDB[index12, 6]);
                                            if (Module1.ElArr[index11].Value != 0.0)
                                                break;
                                            break;
                                        }
                                        checked { ++index12; }
                                    }
                                    if (index12 > Module1.JumpMax)
                                        this.ErrMessage_1(InElement);
                                }
                                checked { ++index11; }
                            }
                            Module1.El_type elType;
                            elType.Value = 0.0;
                            elType.BaseValue = 0.0;
                            elType.row = 0;
                            int num20 = checked(Eno - 1);
                            int index14 = 1;
                            while (index14 <= num20)
                            {
                                num18 += Module1.ElArr[index14].Value;
                                if (Module1.ElArr[index14].BaseValue > elType.BaseValue)
                                    elType = Module1.ElArr[index14];
                                checked { ++index14; }
                            }
                            num2 = num18;
                        }
                        else if (Strings.InStr(1, str2, "+", CompareMethod.Text) == 0 & Strings.Len(str2) >= 1)
                        {
                            double Left3 = 0.0;
                            int num21 = 0;
                            string Left4 = str2;
                            int index15;
                            int num22;
                            if (str2.Contains("St"))
                            {
                                index15 = Module1.Stepmin;
                                num22 = Module1.Stepmax;
                            }
                            else if (str2.Contains("Ch"))
                            {
                                index15 = Module1.Stepmin;
                                num22 = Module1.Stepmax;
                            }
                            else
                            {
                                index15 = Module1.Jumpmin;
                                num22 = Module1.JumpMax;
                            }
                            if (Left4.Contains("*"))
                            {
                                Left3 += 0.0;
                            }
                            else
                            {
                                do
                                {
                                    if (Operators.ConditionalCompareObjectNotEqual(Module1.ElDB[index15, 0], (object)"", false) && Operators.ConditionalCompareObjectEqual((object)Left4, Module1.ElDB[index15, 0], false))
                                    {
                                        num21 = index15;
                                        int num23 = index15;
                                        if (num23 >= Module1.Jumpmin && num23 <= Module1.JumpMax)
                                        {
                                            int index16 = 6;
                                            Left3 = Conversions.ToDouble(Operators.AddObject((object)Left3, Operators.MultiplyObject(Module1.ElDB[index15, index16], (object)Right)));
                                        }
                                        else if (num23 >= Module1.Stepmin && num23 <= Module1.Stepmax)
                                            Left3 = Conversions.ToDouble(Operators.AddObject((object)Left3, Module1.ElDB[index15, 6]));
                                    }
                                    checked { ++index15; }
                                }
                                while (!(index15 > num22 | num21 > 0));
                                if (index15 > checked(Module1.ElDBmax + 2))
                                    this.ErrMessage_1(InElement);
                            }
                            num2 = Left3;
                        }
                    }
                    num2 = Conversion.Int(100.0 * num2 + 0.5000001) / 100.0;
                    goto label_99;
                }
                else
                    goto label_99;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num3 = -1;
            if (num1 == 2)
            {
                int num24 = (int)Interaction.MsgBox((object)("Calc_BV - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_99:
            double num25 = num2;
            if (num3 == 0)
                return num25;
            ProjectData.ClearProjectError();
            return num25;
        }

        public void ErrMessage_1(string el)
        {
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string BVScore = "0";
                string TEScore = "0";
                ProjectData.ClearProjectError();
                num1 = 2;
                this.completed1 = false;
                while (this.Qout.Count > 0)
                {
                    string str = Conversions.ToString(this.Qout.Dequeue());
                    string Outtxt = "";
                    this.CreateJudgeTxtFile(Conversions.ToInteger(str), ref Outtxt);
                    this.SendMessage(Outtxt);
                    if (Module1.WorkMode == 2 & Module1.CreateTEScores > 0)
                    {
                        this.CalcBV_and_TEScores(ref BVScore, ref TEScore);
                        Module1.MakeTEScore(Module1.TE_Leader, BVScore, TEScore);
                    }
                    Thread.Sleep(110);
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
                int num3 = (int)Interaction.MsgBox((object)("CCFS BackgroundWorker1_DoWork - !\r\n" + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_11:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                int num1 = (int)Interaction.MsgBox((object)("Form1, BackgroundWorker1_RunWorkerCompleted - exception was thrown. " + e.Error.Message), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            else if (e.Cancelled)
            {
                int num2 = (int)Interaction.MsgBox((object)"Form1, BackgroundWorker1_RunWorkerCompleted - Canceled", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            else
                this.completed1 = true;
        }

        public void StartServer()
        {
            if (this.Timer2.Enabled)
                return;
            this._Manager.Start();
            this.Timer2.Enabled = true;
        }

        public void StopServer() => this._Manager.Stop();

        public void SendMessage(string msg)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int index = checked(Module1._Clients.Count - 1);
                while (index >= 0)
                {
                    num3 = 3;
                    TcpClient client = Module1._Clients[index];
                    num3 = 4;
                    bool flag = client.Client.Poll(1, SelectMode.SelectRead);
                    num3 = 5;
                    if (!(flag & client.Available == 0))
                    {
                        num3 = 7;
                        num3 = 8;
                        NetworkStream stream = client.GetStream();
                        num3 = 9;
                        byte[] bytes = Encoding.UTF8.GetBytes(msg);
                        num3 = 10;
                        stream.Write(bytes, 0, bytes.Length);
                    }
                    num3 = 12;
                    checked { index += -1; }
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

        private void Timer2_Tick(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (Module1.CompletedTimer2)
                {
                    Module1.CompletedTimer2 = false;
                    this.RejectJI();
                    this.SetColor();
                    Module1.CompletedTimer2 = true;
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
                int num3 = (int)Interaction.MsgBox((object)("Form1, Timer2_Tick -  " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_8:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void RejectJI()
        {
            string IPadr = "";
            int index = 1;
            do
            {
                if (Strings.Len(Module1.IPreject[index]) > 3)
                {
                    this.GetIP(Module1.IPreject[index], ref IPadr);
                    string str = "&#REJECT#&;" + Conversions.ToString(index) + ";" + IPadr + ";";
                    this.SendMessage(Strings.Trim(Conversions.ToString(str.Length)) + ";" + str);
                    Module1.IPreject[index] = "";
                }
                checked { ++index; }
            }
            while (index <= 7);
        }

        public void SetColor()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int index = 1;
                do
                {
                    int judgeNo = Module1.GetJudgeNo((object)Module1.JudgeCompNo[index]);
                    if (judgeNo > 0)
                    {
                        string key1 = "lblJ" + Conversions.ToString(judgeNo);
                        string key2 = "txtCno" + Conversions.ToString(index);
                        string key3 = "btnJ" + Conversions.ToString(judgeNo);
                        string key4 = "txtJ" + Conversions.ToString(judgeNo);
                        if (judgeNo <= checked(Module1.NoJ_GOE + Module1.NoTrj) | Module1.JudgeSel == 1 & judgeNo == 7)
                        {
                            MyProject.Forms.Form2.Panel1.Controls[key4].Visible = true;
                            MyProject.Forms.Form5.Panel1.Controls[key4].Visible = true;
                        }
                        if (Strings.Len(Module1.IPArr[Module1.JudgeCompNo[index]]) > 3)
                        {
                            this.Controls[key1].ForeColor = Color.Green;
                            MyProject.Forms.JudgesSetupDialog.Controls[key3].BackColor = Color.Green;
                            MyProject.Forms.JudgesSetupDialog.Controls[key2].BackColor = Color.Green;
                            MyProject.Forms.Form2.Panel1.Controls[key4].BackColor = Color.Green;
                            MyProject.Forms.Form5.Panel1.Controls[key4].BackColor = Color.Green;
                        }
                        else
                        {
                            this.Controls[key1].ForeColor = Color.Red;
                            MyProject.Forms.JudgesSetupDialog.Controls[key3].BackColor = Color.Red;
                            MyProject.Forms.JudgesSetupDialog.Controls[key2].BackColor = Color.Red;
                            MyProject.Forms.Form2.Panel1.Controls[key4].BackColor = Color.Red;
                            MyProject.Forms.Form5.Panel1.Controls[key4].BackColor = Color.Red;
                        }
                    }
                    checked { ++index; }
                }
                while (index <= 7);
                if (Strings.Len(Module1.IPArr[9]) > 3 & Module1.WorkMode == 2)
                {
                    this.lblCC_El.Visible = true;
                    this.lblCC_El.ForeColor = Color.Green;
                    MyProject.Forms.Form2.txtEl.BackColor = Color.Green;
                    MyProject.Forms.Form5.txtEl.BackColor = Color.Green;
                }
                else
                {
                    this.lblCC_El.ForeColor = Color.Red;
                    MyProject.Forms.Form2.txtEl.BackColor = Color.Red;
                    MyProject.Forms.Form5.txtEl.BackColor = Color.Red;
                }
                if (Strings.Len(Module1.IPArr[10]) > 3 & Module1.WorkMode >= 2)
                {
                    this.lblCC_Info.Visible = true;
                    this.lblCC_Info.ForeColor = Color.Green;
                    MyProject.Forms.Form2.txtInfo.BackColor = Color.Green;
                    MyProject.Forms.Form5.txtInfo.BackColor = Color.Green;
                }
                else
                {
                    this.lblCC_Info.ForeColor = Color.Red;
                    MyProject.Forms.Form2.txtInfo.BackColor = Color.Red;
                    MyProject.Forms.Form5.txtInfo.BackColor = Color.Red;
                }
                if (Strings.Len(Module1.IPArr[11]) > 3 & Module1.WorkMode >= 2)
                {
                    this.lblCC_MP.Visible = true;
                    this.lblCC_MP.ForeColor = Color.Green;
                    MyProject.Forms.Form2.txtMP.BackColor = Color.Green;
                    MyProject.Forms.Form5.txtInfo2.BackColor = Color.Green;
                    goto label_23;
                }
                else
                {
                    this.lblCC_MP.ForeColor = Color.Red;
                    MyProject.Forms.Form2.txtMP.BackColor = Color.Red;
                    MyProject.Forms.Form5.txtInfo2.BackColor = Color.Red;
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
                int num3 = (int)Interaction.MsgBox((object)("SetColor - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_23:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private void JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem_Click(
          object sender,
          EventArgs e)
        {
            if (!this.MenuPossible() || !this.ActivPossible())
                return;
            if (this.TstStartNo())
            {
                string segment = Module1.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    if (!this.FinishedSeg1())
                    {
                        int num = (int)Interaction.MsgBox((object)"The short program is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        return;
                    }
                }
                else if (Operators.CompareString(segment, "Seg2", false) == 0 && !this.FinishedSeg2())
                {
                    int num = (int)Interaction.MsgBox((object)"The free skating is not yet finished!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    return;
                }
                int num1 = checked((int)Math.Round(Conversion.Val(Interaction.InputBox("Number of copies, 0-9?", "Susanne SW", Conversions.ToString(1)))));
                if (!(num1 > 0 & num1 < 10))
                    return;
                switch (Module1.WorkMode)
                {
                    case 2:
                    case 3:
                        this.Qprint.Enqueue(checked(920 + num1));
                        MyProject.Forms.Form10.txtPrint.Text = "Judges Details without Tr. Judge and Referee!";
                        MyProject.Forms.Form10.Show();
                        this.BGW();
                        break;
                }
            }
            else
            {
                int num2 = (int)Interaction.MsgBox((object)"Start numbers are not defined!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }
    }
}

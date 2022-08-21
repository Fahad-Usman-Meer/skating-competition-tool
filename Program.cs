// Decompiled with JetBrains decompiler
// Type: ClubCompFS.Program
// Assembly: ClubCompFS_10p0p6, Version=1.0.0.6, Culture=neutral, PublicKeyToken=null
// MVID: F1E583B2-A781-4EC4-B47C-BA3F451903AE
// Assembly location: E:\zz Personal_Doc\Personal\Cinzia\programmaLibertas_openNEW\ClubCompFS_10p0p6.exe

using ClubCompFS.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ClubCompFS
{
    [StandardModule]
    internal sealed class Program
    {
        public static bool CompletedTimer2 = true;
        public static string[] UpdStr = new string[21];
        public static string OldUpdStr = (string)null;
        public static Program.IndTA_Type[] IndTA = new Program.IndTA_Type[501];
        public static Program.Participant[] Vek = new Program.Participant[43];
        public static Program.SegType[] DVO = new Program.SegType[4];
        public static Program.SegType[] Judge = new Program.SegType[8];
        public static int[] JudgeCompNo = new int[8];
        public static int[] JudgeCompFunc = new int[8];
        public static int[] IceArr_Seg1 = new int[8];
        public static int[] IceArr_Seg2 = new int[8];
        public static int[] LunchArr_Seg1 = new int[8];
        public static int[] LunchArr_Seg2 = new int[8];
        public static Program.OpenDBType[] OpenDB = new Program.OpenDBType[81];
        public static int NoJ_Seg1 = 0;
        public static int NoJ_Seg2 = 0;
        public static int NoJ_GOE = 0;
        public static int NoTrJ_Seg1 = 0;
        public static int NoTrJ_Seg2 = 0;
        public static int NoTrj = 0;
        public static int JudgeSel_Seg1 = 0;
        public static int JudgeSel_Seg2 = 0;
        public static int JudgeSel = 0;
        public static string[,] JDarr = new string[51, 15];
        public static string[,] F4arr = new string[1501, 15];
        public static Program.El_type[] ElArr = new Program.El_type[31];
        public static object[,] ElDB = new object[351, 15];
        public static int[] ElErrorArr = new int[31];
        public static int[] J_GOE = new int[8];
        public static double[] J_PC = new double[8];
        public static Program.OpType[] OpArr = new Program.OpType[16];
        public static object[] ColArr = new object[17];
        public static int JDperPage = 2;
        public static int CreateScoreBoard = 0;
        public static int ScoreBoardDelay = 0;
        public static bool MainForm_TxtBoxEnabled = true;
        public static bool RemWarmupTimeSeg1 = false;
        public static bool RemWarmupTimeSeg2 = false;
        public static bool CategoryFileSaved = true;
        private static object[,] TArrLive = new object[3, 10];
        private static object[,] TArrResult = new object[51, 10];
        private static object[,] TArrNext = new object[51, 10];
        public static string IceCondition = "Very Good";
        public static string IceArea = "30m*60m";
        public static int ScanJudges = 0;
        public static int[] JCStatus = new int[8];
        public static int[] gr = new int[11];
        public static string PathCompFile = "D:\\COMPETITION\\";
        public static string PathResultsFile = "C:\\RESULTS\\";
        public static int CreateResultsPhone = 0;
        public static int CreateTEScores = 0;
        public static int ShowJudgeDed = 0;
        public static int NoJudgeTMV = 5;
        public static int AdjustToScreen = 0;
        public static int PingClients = 1;
        public static int PingTimeout = 1000;
        public static double Page_Size = 100.0;
        public static int Page_Left_Margin = 40;
        public static int Page_Top_Margin = 60;
        public static List<TcpClient> _Clients = new List<TcpClient>();
        public static string[] IPArr = new string[12];
        public static string[] IPreject = new string[12];
        public static int PortNo = 23456;
        public static int HC = 42;
        public static int WC = 20;
        public static int WC1 = 20;
        public static int WC2 = 40;
        public static string TE_Leader = "0";
        public static Queue<string> Qin = new Queue<string>();
        public static string MaxDate = "736973632000000000";
        public const string Version = "ClubCompFS Single ver. 10.0.6, 2019-01-12";
        public const string Z = "|";
        public const int MaxJ = 7;
        public const int MaxEl = 15;
        public const int MaxPno = 42;
        public const int MaxWarmGr = 7;
        public const int MaxPC = 5;
        public const int MaxCat = 80;
        public const int MaxCol = 16;
        public const int MaxBonus = 9;
        public const int MaxDed = 9;
        public const int MaxDedFalls = 19;
        public const int MaxClient = 11;
        public const int MaxIndTA = 500;
        public const int DedIllEl = 2;
        public const int DedIllElArtistisk = 1;
        public const string SH = "Short";
        public const string FR = "Free";
        public const string Seg1 = "Seg1";
        public const string Seg2 = "Seg2";
        public const string MsgText = "Susanne SW";
        public const string IniFile = "CLUBCOMP.INI";
        public const int ZCol = 6;
        public const int ColV = 12;
        public const int ColV1 = 13;
        public const int ISU = 1;
        public const double pf = 0.5000001;
        public const double df = 1E-09;
        public const string HTML_Folder = "html";
        public const string OpenDBfile = "OpenDB.xml";
        public const string ElementDBfile = "ElementDB.xml";
        public const int CC_EL_No = 9;
        public const int CC_Info_No = 10;
        public const int CC_MP_No = 11;
        public const string StdPrintFont = "ARIAL";
        public const string PDFfont = "ARIAL";
        public const string CloseDown = "VABpAG0AZQBsAGkAbQBpAHQAIABoAGEAcwAgAHAAYQBzAHMAZQBkACEADQAKAFQAaABlACAAcAByAG8AZwByAGEAbQAgAHcAaQBsAGwAIABjAGwAbwBzAGUAIABkAG8AdwBuACEA";
        public const string SpErrV = "V";
        public const string msgHIDE = "&#HIDE#&";
        public const string msgUNHIDE = "&#UNHIDE#&";
        public const string msgFUNC = "&#FUNC#&";
        public const string msgEXIT = "&#EXIT#&";
        public const string msgREJECT = "&#REJECT#&";
        public static Program.NameID Competition;
        public static Program.NameID Organizer;
        public static Program.CatID Category;
        public static string SubCategory;
        public static Program.DateType Datum;
        public static Program.SegType Techspec;
        public static Program.SegType Controller;
        public static Program.SegType Referee;
        public static int TNop;
        public static int PNo;
        public static string Segment;
        public static int WorkMode;
        public static int DNS_Seg1;
        public static int DNS_Seg2;
        public static int PcIndex;
        public static int WupG_Seg1;
        public static int WupG_Seg2;
        public static int NoOfCategory;
        public static int JumpMax;
        public static int Spinmax;
        public static int Stepmax;
        public static int Jumpmin;
        public static int SpinMin;
        public static int Stepmin;
        public static int ElDBmax;
        public static int WOR;
        public static int RowJD;
        public static DateTime OpenDBLastWriteTime;
        public static DateTime ElementDBLastWriteTime;
        public static bool DoHTrun;
        public static string OpenDBver;
        public static string ElementDBver;
        public static string CategoryFileName;
        public static string CC_Time;
        public static string In_Time;
        public static Program.ImpType IPar;
        public static string WarmUpTime;
        public static string IceLeaveTime;
        public static string ResurfacingTime;
        public static string LunchTime;
        public static string LastOutTxt;
        private static string BC;
        public static int MakesScoreBoard_StNo;

        public static void CreateMainForm()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                MainForm mainForm = MyProject.Forms.MainForm;
                mainForm.txtOrganizerName.Text = Program.Organizer.Name;
                mainForm.txtOrganizerID.Text = Program.Organizer.ID;
                mainForm.txtCompetitionName.Text = Program.Competition.Name;
                mainForm.txtCompetitionID.Text = Program.Competition.ID;
                mainForm.txtType.Text = Program.Competition.Type;
                mainForm.txtCategory.Text = Program.Category.Name;
                mainForm.txtCategoryID.Text = Program.Category.ID;
                mainForm.txtIndTADiscipline.Text = Program.Category.IndTADiscipline;
                mainForm.txtIndTAClass.Text = Program.Category.IndTAClass;
                mainForm.txtSubcategory.Text = Program.SubCategory;
                mainForm.txtParticipants.Text = Conversions.ToString(Program.TNop);
                if (Strings.Len(Program.WarmUpTime) < 3)
                {
                    Program.CalcPCindex();
                    if (Program.PcIndex > -1)
                        Program.WarmUpTime = Program.OpenDB[Program.PcIndex].Warmup;
                }
                string segment1 = Program.Segment;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    mainForm.txtSegment.Text = Program.GetSeg1();
                    mainForm.txtNoOfJudges.Text = Conversions.ToString(Program.NoJ_Seg1);
                    mainForm.txtNoOfTrJ.Text = Conversions.ToString(Program.NoTrJ_Seg1);
                    mainForm.lblDate.Top = 122;
                    mainForm.txtDate.Top = 138;
                    mainForm.txtDate.Text = Program.FormShortDate(Program.Datum.Seg1);
                    mainForm.lblStart.Top = 122;
                    mainForm.txtStartTime.Top = 138;
                    mainForm.txtStartTime.Text = Program.Datum.Seg1Start;
                }
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                {
                    mainForm.txtSegment.Text = Program.GetSeg2();
                    mainForm.txtNoOfJudges.Text = Conversions.ToString(Program.NoJ_Seg2);
                    mainForm.txtNoOfTrJ.Text = Conversions.ToString(Program.NoTrJ_Seg2);
                    mainForm.lblDate.Top = 172;
                    mainForm.txtDate.Top = 188;
                    mainForm.txtDate.Text = Program.FormShortDate(Program.Datum.Seg2);
                    mainForm.lblStart.Top = 172;
                    mainForm.txtStartTime.Top = 188;
                    mainForm.txtStartTime.Text = Program.Datum.Seg2Start;
                }
                else
                {
                    mainForm.txtNoOfJudges.Text = Conversions.ToString(Program.NoJ_GOE);
                    mainForm.txtNoOfTrJ.Text = Conversions.ToString(Program.NoTrj);
                    mainForm.btnSeg1.Visible = false;
                    mainForm.btnSeg2.Visible = false;
                    mainForm.txtSegment.Text = "";
                }
                switch (Program.JudgeSel)
                {
                    case 0:
                        int index1 = 1;
                        while (Program.JudgeCompFunc[index1] != 1)
                        {
                            mainForm.txtNonJudgingReferee.Text = "Referee not selected!";
                            mainForm.txtNonJudgingReferee.ForeColor = Color.Red;
                            checked { ++index1; }
                            if (index1 > 7)
                                goto label_15;
                        }
                        mainForm.txtNonJudgingReferee.Text = "Referee and Judge no. " + Strings.Trim(Conversions.ToString(index1)) + " for Scores";
                        mainForm.txtNonJudgingReferee.ForeColor = Color.Black;
                        break;
                    case 1:
                        mainForm.txtNonJudgingReferee.Text = "Non-judging Referee as Judge no. 7";
                        mainForm.txtNonJudgingReferee.ForeColor = Color.Black;
                        break;
                }
            label_15:
                string segment2 = Program.Segment;
                if (Operators.CompareString(segment2, "Seg1", false) == 0)
                {
                    mainForm.TechSpecName.Text = Program.Techspec.Seg1.Name;
                    mainForm.TechSpecClub.Text = Program.Techspec.Seg1.Club;
                    mainForm.ControllerName.Text = Program.Controller.Seg1.Name;
                    mainForm.ControllerClub.Text = Program.Controller.Seg1.Club;
                    mainForm.RefereeName.Text = Program.Referee.Seg1.Name;
                    mainForm.RefereeClub.Text = Program.Referee.Seg1.Club;
                }
                else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                {
                    mainForm.TechSpecName.Text = Program.Techspec.Seg2.Name;
                    mainForm.TechSpecClub.Text = Program.Techspec.Seg2.Club;
                    mainForm.ControllerName.Text = Program.Controller.Seg2.Name;
                    mainForm.ControllerClub.Text = Program.Controller.Seg2.Club;
                    mainForm.RefereeName.Text = Program.Referee.Seg2.Name;
                    mainForm.RefereeClub.Text = Program.Referee.Seg2.Club;
                }
                else
                {
                    mainForm.TechSpecName.Text = "";
                    mainForm.TechSpecClub.Text = "";
                    mainForm.ControllerName.Text = "";
                    mainForm.ControllerClub.Text = "";
                    mainForm.RefereeName.Text = "";
                    mainForm.RefereeClub.Text = "";
                }
                int index2 = 1;
                do
                {
                    string key1 = "JudgeName" + Strings.Trim(Conversions.ToString(index2));
                    string key2 = "JudgeClub" + Strings.Trim(Conversions.ToString(index2));
                    if (index2 <= checked(Program.NoJ_GOE + Program.NoTrj) | index2 == checked(Program.JudgeSel * 7))
                    {
                        string segment3 = Program.Segment;
                        if (Operators.CompareString(segment3, "Seg1", false) == 0)
                        {
                            mainForm.Controls[key1].Text = Program.Judge[index2].Seg1.Name;
                            mainForm.Controls[key1].Visible = true;
                            mainForm.Controls[key2].Text = Program.Judge[index2].Seg1.Club;
                            mainForm.Controls[key2].Visible = true;
                        }
                        else if (Operators.CompareString(segment3, "Seg2", false) == 0)
                        {
                            mainForm.Controls[key1].Text = Program.Judge[index2].Seg2.Name;
                            mainForm.Controls[key1].Visible = true;
                            mainForm.Controls[key2].Text = Program.Judge[index2].Seg2.Club;
                            mainForm.Controls[key2].Visible = true;
                        }
                        else
                        {
                            mainForm.Controls[key1].Text = "";
                            mainForm.Controls[key1].Visible = true;
                            mainForm.Controls[key2].Text = "";
                            mainForm.Controls[key2].Visible = true;
                        }
                    }
                    else
                    {
                        mainForm.Controls[key1].Visible = false;
                        mainForm.Controls[key2].Visible = false;
                    }
                    string key3 = "lblJ" + Conversions.ToString(index2);
                    if (index2 <= Program.NoJ_GOE)
                    {
                        mainForm.Controls[key3].Text = "Judge " + Strings.Trim(Conversions.ToString(index2));
                        mainForm.Controls[key3].Visible = true;
                    }
                    else if (index2 > Program.NoJ_GOE & index2 <= checked(Program.NoJ_GOE + Program.NoTrj))
                    {
                        mainForm.Controls[key3].Text = "Tr. Judge " + Strings.Trim(Conversions.ToString(index2));
                        mainForm.Controls[key3].Visible = true;
                    }
                    else if (index2 == checked(Program.JudgeSel * 7))
                    {
                        mainForm.Controls[key3].Text = "Non J. Ref. " + Strings.Trim(Conversions.ToString(index2));
                        mainForm.Controls[key3].Visible = true;
                    }
                    else
                        mainForm.Controls[key3].Visible = false;
                    checked { ++index2; }
                }
                while (index2 <= 7);
                string segment4 = Program.Segment;
                if (Operators.CompareString(segment4, "Seg1", false) == 0)
                {
                    int index3 = 1;
                    do
                    {
                        string key4 = "DVOName" + Strings.Trim(Conversions.ToString(index3));
                        mainForm.Controls[key4].Text = Program.DVO[index3].Seg1.Name;
                        string key5 = "DVOClub" + Strings.Trim(Conversions.ToString(index3));
                        mainForm.Controls[key5].Text = Program.DVO[index3].Seg1.Club;
                        checked { ++index3; }
                    }
                    while (index3 <= 3);
                }
                else if (Operators.CompareString(segment4, "Seg2", false) == 0)
                {
                    int index4 = 1;
                    do
                    {
                        string key6 = "DVOName" + Strings.Trim(Conversions.ToString(index4));
                        mainForm.Controls[key6].Text = Program.DVO[index4].Seg2.Name;
                        string key7 = "DVOClub" + Strings.Trim(Conversions.ToString(index4));
                        mainForm.Controls[key7].Text = Program.DVO[index4].Seg2.Club;
                        checked { ++index4; }
                    }
                    while (index4 <= 3);
                }
                mainForm.txtCompetitionName.Select();
                if (Program.WorkMode == 1)
                {
                    string seg = Program.GetSeg();
                    if (Operators.CompareString(seg, "SS", false) == 0 || Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "FF", false) == 0 || Operators.CompareString(seg, "FS", false) == 0)
                    {
                        mainForm.COPYOFFICIALSToolStripMenuItem.Visible = true;
                        goto label_52;
                    }
                    else
                    {
                        mainForm.COPYOFFICIALSToolStripMenuItem.Visible = false;
                        goto label_52;
                    }
                }
                else
                {
                    mainForm.COPYOFFICIALSToolStripMenuItem.Visible = false;
                    goto label_52;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("CreateMainForm - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_52:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void TimeLimit(string Nu)
        {
            string Right = DateTime.FromBinary(checked((long)Math.Round(Conversion.Val(Program.MaxDate)))).ToString("yyyy-MM-dd");
            string Prompt = Program.decode((object)"VABpAG0AZQBsAGkAbQBpAHQAIABoAGEAcwAgAHAAYQBzAHMAZQBkACEADQAKAFQAaABlACAAcAByAG8AZwByAGEAbQAgAHcAaQBsAGwAIABjAGwAbwBzAGUAIABkAG8AdwBuACEA");
            if (Operators.CompareString(Nu, Right, false) <= 0)
                return;
            int num = (int)Interaction.MsgBox((object)Prompt, MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            MyProject.Forms.MainForm.WillExit = true;
            MyProject.Forms.MainForm.Close();
        }

        public static string encode(object instring)
        {
            UnicodeEncoding Instance = new UnicodeEncoding();
            object[] objArray = new object[1]
            {
        RuntimeHelpers.GetObjectValue(instring)
            };
            object[] Arguments = objArray;
            bool[] flagArray;
            bool[] CopyBack = flagArray = new bool[1] { true };
            object inArray = NewLateBinding.LateGet((object)Instance, (System.Type)null, "GetBytes", Arguments, (string[])null, (System.Type[])null, CopyBack);
            if (flagArray[0])
                instring = RuntimeHelpers.GetObjectValue(objArray[0]);
            return Convert.ToBase64String((byte[])inArray);
        }

        public static string decode(object instring) => new UnicodeEncoding().GetString(Convert.FromBase64String(Conversions.ToString(instring)));

        public static void LoadXML_DB(string File)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                bool flag = false;
                ProjectData.ClearProjectError();
                num1 = 2;
                using (XmlReader MyReader = XmlReader.Create(File))
                {
                    int i = 1;
                    while (MyReader.Read())
                    {
                        if (MyReader.NodeType == XmlNodeType.Element)
                        {
                            if (!flag)
                            {
                                if (Operators.CompareString(MyReader.Name, "ClubCompDB10", false) == 0)
                                    flag = true;
                            }
                            else
                            {
                                string name = MyReader.Name;
                                if (Operators.CompareString(name, "CompetitionHeader", false) == 0)
                                    Program.ParseCompetitionHeader(MyReader);
                                else if (Operators.CompareString(name, "Officials", false) == 0)
                                    Program.ParseOffSegment1(MyReader);
                                else if (Operators.CompareString(name, "Officials2", false) == 0)
                                    Program.ParseOffSegment2(MyReader);
                                else if (Operators.CompareString(name, "Segment", false) == 0)
                                    Program.ParseSegment(MyReader);
                                else if (Operators.CompareString(name, "Person", false) == 0)
                                {
                                    Program.Participant[] vek = Program.Vek;
                                    int index = i;
                                    vek[index].J_Seg1.EE = new int[16, 8];
                                    vek[index].J_Seg2.EE = new int[16, 8];
                                    vek[index].J_Seg1.PC = new double[16, 8];
                                    vek[index].J_Seg2.PC = new double[16, 8];
                                    vek[index].J_Seg1.Deduction = new long[8];
                                    vek[index].J_Seg2.Deduction = new long[8];
                                    //TODO: Edges: initialize here
                                    vek[index].SSS_Seg1 = new string[16];
                                    vek[index].SSS_Seg1_edges = new string[16];
                                    vek[index].SSS_Seg2 = new string[16];
                                    vek[index].SSS_Seg2_edges = new string[16];
                                    Program.ParsePerson(MyReader, i);
                                    checked { ++i; }
                                }
                            }
                        }
                    }
                }
                if (!flag)
                {
                    int num3 = (int)Interaction.MsgBox((object)"This is not a Competition DB for Single Skating!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    goto label_28;
                }
                else
                    goto label_28;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("LoadXML_DB - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_28:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void ClearOfficials()
        {
            Program.Techspec.Seg1.Name = "";
            Program.Techspec.Seg1.Club = "";
            Program.Controller.Seg1.Name = "";
            Program.Controller.Seg1.Club = "";
            Program.Referee.Seg1.Name = "";
            Program.Referee.Seg1.Club = "";
            Program.Techspec.Seg2.Name = "";
            Program.Techspec.Seg2.Club = "";
            Program.Controller.Seg2.Name = "";
            Program.Controller.Seg2.Club = "";
            Program.Referee.Seg2.Name = "";
            Program.Referee.Seg2.Club = "";
            Program.Judge = new Program.SegType[8];
            Program.DVO = new Program.SegType[4];
        }

        public static void ParseSegment(XmlReader MyReader)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                MyReader.ReadToFollowing("Date");
                MyReader.MoveToAttribute(0);
                string attribute1 = MyReader.GetAttribute(0);
                Program.Datum.Seg1 = Strings.Len(attribute1) <= 1 ? DateTime.Today : Conversions.ToDate(attribute1);
                MyReader.MoveToAttribute(1);
                string attribute2 = MyReader.GetAttribute(1);
                Program.Datum.Seg2 = Strings.Len(attribute2) <= 1 ? DateTime.Today : Conversions.ToDate(attribute2);
                MyReader.MoveToElement();
                Program.TimeLimit(Program.Datum.Seg1.ToString("yyyy-MM-dd"));
                Program.TimeLimit(Program.Datum.Seg2.ToString("yyyy-MM-dd"));
                MyReader.ReadToFollowing("Time");
                MyReader.MoveToAttribute(0);
                Program.Datum.Seg1Start = MyReader.GetAttribute(0);
                MyReader.MoveToAttribute(1);
                Program.Datum.Seg2Start = MyReader.GetAttribute(1);
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("Group1");
                MyReader.MoveToAttribute(0);
                Program.RemWarmupTimeSeg1 = Operators.CompareString(MyReader.GetAttribute(0), "1", false) == 0;
                MyReader.MoveToAttribute(1);
                Program.RemWarmupTimeSeg2 = Operators.CompareString(MyReader.GetAttribute(1), "1", false) == 0;
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("NoSkaters");
                Program.TNop = Conversions.ToInteger(MyReader.ReadString());
                if (Program.WorkMode == 1)
                {
                    MyReader.ReadToFollowing("NoJudges");
                    MyReader.MoveToAttribute(0);
                    string attribute3 = MyReader.GetAttribute(0);
                    if ((double)Program.NoJ_Seg1 == Conversions.ToDouble("0"))
                        Program.NoJ_Seg1 = Conversions.ToInteger(attribute3);
                    MyReader.MoveToAttribute(1);
                    string attribute4 = MyReader.GetAttribute(1);
                    if ((double)Program.NoJ_Seg2 == Conversions.ToDouble("0"))
                        Program.NoJ_Seg2 = Conversions.ToInteger(attribute4);
                    MyReader.MoveToElement();
                    MyReader.ReadToFollowing("NoTrialJudges");
                    MyReader.MoveToAttribute(0);
                    string attribute5 = MyReader.GetAttribute(0);
                    if ((double)Program.NoTrJ_Seg1 == Conversions.ToDouble("0"))
                        Program.NoTrJ_Seg1 = Conversions.ToInteger(attribute5);
                    MyReader.MoveToAttribute(1);
                    string attribute6 = MyReader.GetAttribute(1);
                    if ((double)Program.NoTrJ_Seg2 == Conversions.ToDouble("0"))
                        Program.NoTrJ_Seg2 = Conversions.ToInteger(attribute6);
                    MyReader.MoveToElement();
                    MyReader.ReadToFollowing("NonJudgeReferee");
                    MyReader.MoveToAttribute(0);
                    string attribute7 = MyReader.GetAttribute(0);
                    if ((double)Program.JudgeSel_Seg1 == Conversions.ToDouble("0"))
                        Program.JudgeSel_Seg1 = Conversions.ToInteger(attribute7);
                    MyReader.MoveToAttribute(1);
                    string attribute8 = MyReader.GetAttribute(1);
                    if ((double)Program.JudgeSel_Seg2 == Conversions.ToDouble("0"))
                        Program.JudgeSel_Seg2 = Conversions.ToInteger(attribute8);
                    MyReader.MoveToElement();
                }
                else
                {
                    MyReader.ReadToFollowing("NoJudges");
                    MyReader.MoveToAttribute(0);
                    Program.NoJ_Seg1 = Conversions.ToInteger(MyReader.GetAttribute(0));
                    MyReader.MoveToAttribute(1);
                    Program.NoJ_Seg2 = Conversions.ToInteger(MyReader.GetAttribute(1));
                    MyReader.MoveToElement();
                    MyReader.ReadToFollowing("NoTrialJudges");
                    MyReader.MoveToAttribute(0);
                    Program.NoTrJ_Seg1 = Conversions.ToInteger(MyReader.GetAttribute(0));
                    MyReader.MoveToAttribute(1);
                    Program.NoTrJ_Seg2 = Conversions.ToInteger(MyReader.GetAttribute(1));
                    MyReader.MoveToElement();
                    MyReader.ReadToFollowing("NonJudgeReferee");
                    MyReader.MoveToAttribute(0);
                    Program.JudgeSel_Seg1 = Conversions.ToInteger(MyReader.GetAttribute(0));
                    MyReader.MoveToAttribute(1);
                    Program.JudgeSel_Seg2 = Conversions.ToInteger(MyReader.GetAttribute(1));
                    MyReader.MoveToElement();
                }
                MyReader.ReadToFollowing("NoWarmUpGr");
                MyReader.MoveToAttribute(0);
                Program.WupG_Seg1 = Conversions.ToInteger(MyReader.GetAttribute(0));
                MyReader.MoveToAttribute(1);
                Program.WupG_Seg2 = Conversions.ToInteger(MyReader.GetAttribute(1));
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("Resurface");
                MyReader.MoveToAttribute(0);
                string[] strArray1 = MyReader.GetAttribute(0).Split('|');
                int index1 = 1;
                do
                {
                    Program.IceArr_Seg1[index1] = Conversions.ToInteger(strArray1[checked(index1 - 1)]);
                    checked { ++index1; }
                }
                while (index1 <= 7);
                MyReader.MoveToAttribute(1);
                string[] strArray2 = MyReader.GetAttribute(1).Split('|');
                int index2 = 1;
                do
                {
                    Program.IceArr_Seg2[index2] = Conversions.ToInteger(strArray2[checked(index2 - 1)]);
                    checked { ++index2; }
                }
                while (index2 <= 7);
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("Meal");
                MyReader.MoveToAttribute(0);
                string[] strArray3 = MyReader.GetAttribute(0).Split('|');
                int index3 = 1;
                do
                {
                    Program.LunchArr_Seg1[index3] = Conversions.ToInteger(strArray3[checked(index3 - 1)]);
                    checked { ++index3; }
                }
                while (index3 <= 7);
                MyReader.MoveToAttribute(1);
                string[] strArray4 = MyReader.GetAttribute(1).Split('|');
                int index4 = 1;
                do
                {
                    Program.LunchArr_Seg2[index4] = Conversions.ToInteger(strArray4[checked(index4 - 1)]);
                    checked { ++index4; }
                }
                while (index4 <= 7);
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("IceCondition");
                string Expression1 = MyReader.ReadString();
                if (Strings.Len(Expression1) > 1)
                    Program.IceCondition = Expression1;
                MyReader.ReadToFollowing("IceArea");
                string Expression2 = MyReader.ReadString();
                if (Strings.Len(Expression2) > 1)
                {
                    Program.IceArea = Expression2;
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
                int num3 = (int)Interaction.MsgBox((object)("ParseSegment - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_33:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void ParseOffSegment1(XmlReader MyReader)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (Program.WorkMode == 1)
                {
                    MyReader.ReadToFollowing("TechSpec");
                    MyReader.MoveToAttribute(0);
                    string attribute1 = MyReader.GetAttribute(0);
                    if (Strings.Len(attribute1) > 0)
                        Program.Techspec.Seg1.Name = attribute1;
                    MyReader.MoveToAttribute(1);
                    string attribute2 = MyReader.GetAttribute(1);
                    if (Strings.Len(attribute2) > 0)
                        Program.Techspec.Seg1.Club = attribute2;
                    MyReader.MoveToElement();
                    MyReader.ReadToFollowing("Controller");
                    MyReader.MoveToAttribute(0);
                    string attribute3 = MyReader.GetAttribute(0);
                    if (Strings.Len(attribute3) > 0)
                        Program.Controller.Seg1.Name = attribute3;
                    MyReader.MoveToAttribute(1);
                    string attribute4 = MyReader.GetAttribute(1);
                    if (Strings.Len(attribute4) > 0)
                        Program.Controller.Seg1.Club = attribute4;
                    MyReader.MoveToElement();
                    MyReader.ReadToFollowing("Referee");
                    MyReader.MoveToAttribute(0);
                    string attribute5 = MyReader.GetAttribute(0);
                    if (Strings.Len(attribute5) > 0)
                        Program.Referee.Seg1.Name = attribute5;
                    MyReader.MoveToAttribute(1);
                    string attribute6 = MyReader.GetAttribute(1);
                    if (Strings.Len(attribute6) > 0)
                        Program.Referee.Seg1.Club = attribute6;
                    MyReader.MoveToElement();
                    int index1 = 1;
                    do
                    {
                        string name = "Judge" + Conversions.ToString(index1);
                        MyReader.ReadToFollowing(name);
                        MyReader.MoveToAttribute(0);
                        string attribute7 = MyReader.GetAttribute(0);
                        if (Strings.Len(attribute7) > 0)
                            Program.Judge[index1].Seg1.Name = attribute7;
                        MyReader.MoveToAttribute(1);
                        string attribute8 = MyReader.GetAttribute(1);
                        if (Strings.Len(attribute8) > 0)
                            Program.Judge[index1].Seg1.Club = attribute8;
                        MyReader.MoveToElement();
                        checked { ++index1; }
                    }
                    while (index1 <= 7);
                    int index2 = 1;
                    do
                    {
                        string name = "DVO" + Conversions.ToString(index2);
                        MyReader.ReadToFollowing(name);
                        MyReader.MoveToAttribute(0);
                        string attribute9 = MyReader.GetAttribute(0);
                        if (Strings.Len(attribute9) > 0)
                            Program.DVO[index2].Seg1.Name = attribute9;
                        MyReader.MoveToAttribute(1);
                        string attribute10 = MyReader.GetAttribute(1);
                        if (Strings.Len(attribute10) > 0)
                            Program.DVO[index2].Seg1.Club = attribute10;
                        MyReader.MoveToElement();
                        checked { ++index2; }
                    }
                    while (index2 <= 3);
                    goto label_35;
                }
                else
                {
                    MyReader.ReadToFollowing("TechSpec");
                    MyReader.MoveToAttribute(0);
                    Program.Techspec.Seg1.Name = MyReader.GetAttribute(0);
                    MyReader.MoveToAttribute(1);
                    Program.Techspec.Seg1.Club = MyReader.GetAttribute(1);
                    MyReader.MoveToElement();
                    MyReader.ReadToFollowing("Controller");
                    MyReader.MoveToAttribute(0);
                    Program.Controller.Seg1.Name = MyReader.GetAttribute(0);
                    MyReader.MoveToAttribute(1);
                    Program.Controller.Seg1.Club = MyReader.GetAttribute(1);
                    MyReader.MoveToElement();
                    MyReader.ReadToFollowing("Referee");
                    MyReader.MoveToAttribute(0);
                    Program.Referee.Seg1.Name = MyReader.GetAttribute(0);
                    MyReader.MoveToAttribute(1);
                    Program.Referee.Seg1.Club = MyReader.GetAttribute(1);
                    MyReader.MoveToElement();
                    int index3 = 1;
                    do
                    {
                        string name = "Judge" + Conversions.ToString(index3);
                        MyReader.ReadToFollowing(name);
                        MyReader.MoveToAttribute(0);
                        Program.Judge[index3].Seg1.Name = MyReader.GetAttribute(0);
                        MyReader.MoveToAttribute(1);
                        Program.Judge[index3].Seg1.Club = MyReader.GetAttribute(1);
                        MyReader.MoveToElement();
                        checked { ++index3; }
                    }
                    while (index3 <= 7);
                    int index4 = 1;
                    do
                    {
                        string name = "DVO" + Conversions.ToString(index4);
                        MyReader.ReadToFollowing(name);
                        MyReader.MoveToAttribute(0);
                        Program.DVO[index4].Seg1.Name = MyReader.GetAttribute(0);
                        MyReader.MoveToAttribute(1);
                        Program.DVO[index4].Seg1.Club = MyReader.GetAttribute(1);
                        MyReader.MoveToElement();
                        checked { ++index4; }
                    }
                    while (index4 <= 3);
                    goto label_35;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ParseOfficials - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_35:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void ParseOffSegment2(XmlReader MyReader)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (Program.WorkMode == 1)
                {
                    MyReader.ReadToFollowing("TechSpec");
                    MyReader.MoveToAttribute(0);
                    string attribute1 = MyReader.GetAttribute(0);
                    if (Strings.Len(attribute1) > 0)
                        Program.Techspec.Seg2.Name = attribute1;
                    MyReader.MoveToAttribute(1);
                    string attribute2 = MyReader.GetAttribute(1);
                    if (Strings.Len(attribute2) > 0)
                        Program.Techspec.Seg2.Club = attribute2;
                    MyReader.MoveToElement();
                    MyReader.ReadToFollowing("Controller");
                    MyReader.MoveToAttribute(0);
                    string attribute3 = MyReader.GetAttribute(0);
                    if (Strings.Len(attribute3) > 0)
                        Program.Controller.Seg2.Name = attribute3;
                    MyReader.MoveToAttribute(1);
                    string attribute4 = MyReader.GetAttribute(1);
                    if (Strings.Len(attribute4) > 0)
                        Program.Controller.Seg2.Club = attribute4;
                    MyReader.MoveToElement();
                    MyReader.ReadToFollowing("Referee");
                    MyReader.MoveToAttribute(0);
                    string attribute5 = MyReader.GetAttribute(0);
                    if (Strings.Len(attribute5) > 0)
                        Program.Referee.Seg2.Name = attribute5;
                    MyReader.MoveToAttribute(1);
                    string attribute6 = MyReader.GetAttribute(1);
                    if (Strings.Len(attribute6) > 0)
                        Program.Referee.Seg2.Club = attribute6;
                    MyReader.MoveToElement();
                    int index1 = 1;
                    do
                    {
                        string name = "Judge" + Conversions.ToString(index1);
                        MyReader.ReadToFollowing(name);
                        MyReader.MoveToAttribute(0);
                        string attribute7 = MyReader.GetAttribute(0);
                        if (Strings.Len(attribute7) > 0)
                            Program.Judge[index1].Seg2.Name = attribute7;
                        MyReader.MoveToAttribute(1);
                        string attribute8 = MyReader.GetAttribute(1);
                        if (Strings.Len(attribute8) > 0)
                            Program.Judge[index1].Seg2.Club = attribute8;
                        MyReader.MoveToElement();
                        checked { ++index1; }
                    }
                    while (index1 <= 7);
                    int index2 = 1;
                    do
                    {
                        string name = "DVO" + Conversions.ToString(index2);
                        MyReader.ReadToFollowing(name);
                        MyReader.MoveToAttribute(0);
                        string attribute9 = MyReader.GetAttribute(0);
                        if (Strings.Len(attribute9) > 0)
                            Program.DVO[index2].Seg2.Name = attribute9;
                        MyReader.MoveToAttribute(1);
                        string attribute10 = MyReader.GetAttribute(1);
                        if (Strings.Len(attribute10) > 0)
                            Program.DVO[index2].Seg2.Club = attribute10;
                        MyReader.MoveToElement();
                        checked { ++index2; }
                    }
                    while (index2 <= 3);
                    goto label_35;
                }
                else
                {
                    MyReader.ReadToFollowing("TechSpec");
                    MyReader.MoveToAttribute(0);
                    Program.Techspec.Seg2.Name = MyReader.GetAttribute(0);
                    MyReader.MoveToAttribute(1);
                    Program.Techspec.Seg2.Club = MyReader.GetAttribute(1);
                    MyReader.MoveToElement();
                    MyReader.ReadToFollowing("Controller");
                    MyReader.MoveToAttribute(0);
                    Program.Controller.Seg2.Name = MyReader.GetAttribute(0);
                    MyReader.MoveToAttribute(1);
                    Program.Controller.Seg2.Club = MyReader.GetAttribute(1);
                    MyReader.MoveToElement();
                    MyReader.ReadToFollowing("Referee");
                    MyReader.MoveToAttribute(0);
                    Program.Referee.Seg2.Name = MyReader.GetAttribute(0);
                    MyReader.MoveToAttribute(1);
                    Program.Referee.Seg2.Club = MyReader.GetAttribute(1);
                    MyReader.MoveToElement();
                    int index3 = 1;
                    do
                    {
                        string name = "Judge" + Conversions.ToString(index3);
                        MyReader.ReadToFollowing(name);
                        MyReader.MoveToAttribute(0);
                        Program.Judge[index3].Seg2.Name = MyReader.GetAttribute(0);
                        MyReader.MoveToAttribute(1);
                        Program.Judge[index3].Seg2.Club = MyReader.GetAttribute(1);
                        MyReader.MoveToElement();
                        checked { ++index3; }
                    }
                    while (index3 <= 7);
                    int index4 = 1;
                    do
                    {
                        string name = "DVO" + Conversions.ToString(index4);
                        MyReader.ReadToFollowing(name);
                        MyReader.MoveToAttribute(0);
                        Program.DVO[index4].Seg2.Name = MyReader.GetAttribute(0);
                        MyReader.MoveToAttribute(1);
                        Program.DVO[index4].Seg2.Club = MyReader.GetAttribute(1);
                        MyReader.MoveToElement();
                        checked { ++index4; }
                    }
                    while (index4 <= 3);
                    goto label_35;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ParseOfficials2 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_35:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void ParseCompetitionHeader(XmlReader MyReader)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                MyReader.ReadToFollowing("Organizer");
                MyReader.MoveToAttribute(0);
                Program.Organizer.Name = Strings.Trim(MyReader.GetAttribute(0));
                MyReader.MoveToAttribute(1);
                Program.Organizer.ID = Strings.Trim(MyReader.GetAttribute(1));
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("Competition");
                MyReader.MoveToAttribute(0);
                Program.Competition.Name = Strings.Trim(MyReader.GetAttribute(0));
                MyReader.MoveToAttribute(1);
                Program.Competition.Type = Strings.Trim(MyReader.GetAttribute(1));
                MyReader.MoveToAttribute(2);
                Program.Competition.ID = Strings.Trim(MyReader.GetAttribute(2));
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("Category");
                Program.Category.Name = Strings.Trim(MyReader.ReadString());
                MyReader.ReadToFollowing("Subcategory");
                Program.SubCategory = Strings.Trim(MyReader.ReadString());
                MyReader.ReadToFollowing("IndTA");
                MyReader.MoveToAttribute(0);
                Program.Category.IndTADiscipline = Strings.Trim(MyReader.GetAttribute(0));
                MyReader.MoveToAttribute(1);
                Program.Category.IndTAClass = Strings.Trim(MyReader.GetAttribute(1));
                MyReader.MoveToAttribute(2);
                Program.Category.ID = Strings.Trim(MyReader.GetAttribute(2));
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
                int num3 = (int)Interaction.MsgBox((object)("ParseCompetitionHeader - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void ParsePerson(XmlReader MyReader, int i)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                MyReader.ReadToFollowing("Startno");
                MyReader.MoveToAttribute(0);
                Program.Vek[i].Startno_Seg1 = Conversions.ToInteger(MyReader.GetAttribute(0));
                MyReader.MoveToAttribute(1);
                Program.Vek[i].Startno_Seg2 = Conversions.ToInteger(MyReader.GetAttribute(1));
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("WarmUpGr");
                MyReader.MoveToAttribute(0);
                Program.Vek[i].WarmUp_Seg1 = Conversions.ToInteger(MyReader.GetAttribute(0));
                MyReader.MoveToAttribute(1);
                Program.Vek[i].WarmUp_Seg2 = Conversions.ToInteger(MyReader.GetAttribute(1));
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("Skater");
                MyReader.MoveToAttribute(0);
                Program.Vek[i].Name.FName = Strings.Trim(MyReader.GetAttribute(0));
                MyReader.MoveToAttribute(1);
                Program.Vek[i].Name.LName = Strings.Trim(MyReader.GetAttribute(1));
                MyReader.MoveToAttribute(2);
                Program.Vek[i].Name.ID = Strings.Trim(MyReader.GetAttribute(2));
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("Club");
                MyReader.MoveToAttribute(0);
                Program.Vek[i].Club = Strings.Trim(MyReader.GetAttribute(0));
                MyReader.MoveToAttribute(1);
                Program.Vek[i].ClubID = Strings.Trim(MyReader.GetAttribute(1));
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("Seg1");
                MyReader.MoveToAttribute(0);
                Program.Vek[i].TES_Seg1 = Conversions.ToDouble(MyReader.GetAttribute(0));
                MyReader.MoveToAttribute(1);
                Program.Vek[i].PCS_Seg1 = Conversions.ToDouble(MyReader.GetAttribute(1));
                MyReader.MoveToAttribute(2);
                Program.Vek[i].Score_Seg1 = Conversions.ToDouble(MyReader.GetAttribute(2));
                MyReader.MoveToAttribute(3);
                Program.Vek[i].Finished_Seg1 = Conversions.ToInteger(MyReader.GetAttribute(3));
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("Seg2");
                MyReader.MoveToAttribute(0);
                Program.Vek[i].TES_Seg2 = Conversions.ToDouble(MyReader.GetAttribute(0));
                MyReader.MoveToAttribute(1);
                Program.Vek[i].PCS_Seg2 = Conversions.ToDouble(MyReader.GetAttribute(1));
                MyReader.MoveToAttribute(2);
                Program.Vek[i].Score_Seg2 = Conversions.ToDouble(MyReader.GetAttribute(2));
                MyReader.MoveToAttribute(3);
                Program.Vek[i].Finished_Seg2 = Conversions.ToInteger(MyReader.GetAttribute(3));
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("ScoreFinal");
                Program.Vek[i].Score_Total = Conversions.ToDouble(MyReader.ReadString());
                MyReader.ReadToFollowing("Place");
                MyReader.MoveToAttribute(0);
                Program.Vek[i].Place_Seg1 = Conversions.ToInteger(MyReader.GetAttribute(0));
                MyReader.MoveToAttribute(1);
                Program.Vek[i].Place_Seg2 = Conversions.ToInteger(MyReader.GetAttribute(1));
                MyReader.MoveToAttribute(2);
                Program.Vek[i].Place = Conversions.ToInteger(MyReader.GetAttribute(2));
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("DNS");
                MyReader.MoveToAttribute(0);
                Program.Vek[i].DNS_Seg1 = Conversions.ToInteger(MyReader.GetAttribute(0));
                MyReader.MoveToAttribute(1);
                Program.Vek[i].DNS_Seg2 = Conversions.ToInteger(MyReader.GetAttribute(1));
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("HTindex");
                MyReader.MoveToAttribute(0);
                Program.Vek[i].HTIndSeg1 = Conversions.ToInteger(MyReader.GetAttribute(0));
                MyReader.MoveToAttribute(1);
                Program.Vek[i].HTIndSeg2 = Conversions.ToInteger(MyReader.GetAttribute(1));
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("ElSeg1");
                string[] strArray1 = MyReader.ReadString().Split('|');
                int index1 = 1;
                do
                {
                    Program.Vek[i].SSS_Seg1[index1] = strArray1[checked(index1 - 1)];
                    checked { ++index1; }
                }
                while (index1 <= 15);

                MyReader.ReadToFollowing("ElSeg1Edges");
                string[] strArray1Edges = MyReader.ReadString().Split('|');
                int index1Edges = 1;
                do
                {
                    Program.Vek[i].SSS_Seg1_edges[index1Edges] = strArray1Edges[checked(index1Edges - 1)];
                    checked { ++index1Edges; }
                }
                while (index1Edges <= 15);

                MyReader.ReadToFollowing("ElSeg2");
                string[] strArray2 = MyReader.ReadString().Split('|');
                int index2 = 1;
                do
                {
                    Program.Vek[i].SSS_Seg2[index2] = strArray2[checked(index2 - 1)];
                    checked { ++index2; }
                }
                while (index2 <= 15);
                
                MyReader.ReadToFollowing("ElSeg2Edges");
                string[] strArray2Edges = MyReader.ReadString().Split('|');
                int index2Edges = 1;
                do
                {
                    Program.Vek[i].SSS_Seg2_edges[index2Edges] = strArray2Edges[checked(index2Edges - 1)];
                    checked { ++index2Edges; }
                }
                while (index2Edges <= 15);

                int index3 = 1;
                do
                {
                    string name = "JEESeg1_" + Strings.Trim(Conversions.ToString(index3));
                    MyReader.ReadToFollowing(name);
                    string[] strArray3 = MyReader.ReadString().Split('|');
                    int index4 = 1;
                    do
                    {
                        Program.Vek[i].J_Seg1.EE[index4, index3] = Conversions.ToInteger(strArray3[checked(index4 - 1)]);
                        checked { ++index4; }
                    }
                    while (index4 <= 15);
                    checked { ++index3; }
                }
                while (index3 <= 7);
                int index5 = 1;
                do
                {
                    string name = "JEESeg2_" + Strings.Trim(Conversions.ToString(index5));
                    MyReader.ReadToFollowing(name);
                    string[] strArray4 = MyReader.ReadString().Split('|');
                    int index6 = 1;
                    do
                    {
                        Program.Vek[i].J_Seg2.EE[index6, index5] = Conversions.ToInteger(strArray4[checked(index6 - 1)]);
                        checked { ++index6; }
                    }
                    while (index6 <= 15);
                    checked { ++index5; }
                }
                while (index5 <= 7);
                int index7 = 1;
                do
                {
                    string name = "JPCSeg1_" + Strings.Trim(Conversions.ToString(index7));
                    MyReader.ReadToFollowing(name);
                    string[] strArray5 = MyReader.ReadString().Split('|');
                    int index8 = 1;
                    do
                    {
                        Program.Vek[i].J_Seg1.PC[index8, index7] = Conversions.ToDouble(strArray5[checked(index8 - 1)]);
                        checked { ++index8; }
                    }
                    while (index8 <= Constants.TOTAL_COMPONENTS_COUNT);
                    checked { ++index7; }
                }
                while (index7 <= 7);
                int index9 = 1;
                do
                {
                    string name = "JPCSeg2_" + Strings.Trim(Conversions.ToString(index9));
                    MyReader.ReadToFollowing(name);
                    string[] strArray6 = MyReader.ReadString().Split('|');
                    int index10 = 1;
                    do
                    {
                        Program.Vek[i].J_Seg2.PC[index10, index9] = Conversions.ToDouble(strArray6[checked(index10 - 1)]);
                        checked { ++index10; }
                    }
                    while (index10 <= Constants.TOTAL_COMPONENTS_COUNT);
                    checked { ++index9; }
                }
                while (index9 <= 7);
                MyReader.ReadToFollowing("Deductions");
                MyReader.MoveToAttribute(0);
                string attribute1 = MyReader.GetAttribute(0);
                if (Strings.Len(attribute1) > 0)
                    Program.Vek[i].Deductions_Seg1 = Conversions.ToLong(attribute1);
                MyReader.MoveToAttribute(1);
                string attribute2 = MyReader.GetAttribute(1);
                if (Strings.Len(attribute2) > 0)
                    Program.Vek[i].Deductions_Seg2 = Conversions.ToLong(attribute2);
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("MajDeductions");
                MyReader.MoveToAttribute(0);
                string[] strArray7 = MyReader.GetAttribute(0).Split('|');
                int index11 = 1;
                do
                {
                    Program.Vek[i].J_Seg1.Deduction[index11] = Conversions.ToLong(strArray7[checked(index11 - 1)]);
                    checked { ++index11; }
                }
                while (index11 <= 7);
                MyReader.MoveToAttribute(1);
                string[] strArray8 = MyReader.GetAttribute(1).Split('|');
                int index12 = 1;
                do
                {
                    Program.Vek[i].J_Seg2.Deduction[index12] = Conversions.ToLong(strArray8[checked(index12 - 1)]);
                    checked { ++index12; }
                }
                while (index12 <= 7);
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("Falls");
                MyReader.MoveToAttribute(0);
                string attribute3 = MyReader.GetAttribute(0);
                if (Strings.Len(attribute3) > 0)
                    Program.Vek[i].Falls_seg1 = Conversions.ToInteger(attribute3);
                MyReader.MoveToAttribute(1);
                string attribute4 = MyReader.GetAttribute(1);
                if (Strings.Len(attribute4) > 0)
                    Program.Vek[i].Falls_seg2 = Conversions.ToInteger(attribute4);
                MyReader.MoveToElement();
                MyReader.ReadToFollowing("Bonus");
                MyReader.MoveToAttribute(0);
                Program.Vek[i].Bonus_Seg1 = Conversions.ToInteger(MyReader.GetAttribute(0));
                MyReader.MoveToAttribute(1);
                Program.Vek[i].Bonus_Seg2 = Conversions.ToInteger(MyReader.GetAttribute(1));
                MyReader.MoveToElement();
                goto label_39;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ParsePerson - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_39:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void SaveCategoryFile(string MySender)
        {
            if (Strings.Len(Program.Competition.Name) > 0)
            {
                string str = Strings.UCase(Program.StrConv(Program.Competition.Name + "_" + Program.Category.Name + Program.SubCat_()));
                if (!Strings.UCase(MySender).Contains(str))
                {
                    if (Interaction.MsgBox((object)"The Competition or Category is new or has been changed!\r\n\r\nDo you want to save the file?", MsgBoxStyle.YesNo | MsgBoxStyle.Question | MsgBoxStyle.SystemModal, (object)"Susanne SW") == MsgBoxResult.Yes)
                    {
                        MyProject.Forms.MainForm.SaveCategoryDB_As();
                    }
                    else
                    {
                        int num = (int)Interaction.MsgBox((object)"The file is not saved?", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    }
                }
                else
                {
                    if (Strings.Len(MySender) <= 1)
                        return;
                    Program.CreateCategoryFile(MySender);
                }
            }
            else
            {
                int num1 = (int)Interaction.MsgBox((object)"The Competition's name is missing!\r\nThe file is not saved?", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        }

        public static void CreateCategoryFile(string MySender)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string[] strArray1 = new string[8];
                string[] strArray2 = new string[8];
                string[] strArray3 = new string[8];
                string[] strArray4 = new string[8];
                ProjectData.ClearProjectError();
                num1 = 2;
                Program.CategoryFileSaved = false;
                string pResSeg1 = "";
                string pMSeg1 = "";
                string pResSeg2 = "";
                string pMSeg2 = "";
                int index1 = 1;
                do
                {
                    pResSeg1 += Conversions.ToString(Program.IceArr_Seg1[index1]);
                    pMSeg1 += Conversions.ToString(Program.LunchArr_Seg1[index1]);
                    pResSeg2 += Conversions.ToString(Program.IceArr_Seg2[index1]);
                    pMSeg2 += Conversions.ToString(Program.LunchArr_Seg2[index1]);
                    if (index1 < 7)
                    {
                        pResSeg1 += "|";
                        pMSeg1 += "|";
                        pResSeg2 += "|";
                        pMSeg2 += "|";
                    }
                    checked { ++index1; }
                }
                while (index1 <= 7);
                XmlTextWriter writer = new XmlTextWriter(MySender, Encoding.UTF8);
                ProjectData.ClearProjectError();
                num1 = 3;
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;
                writer.WriteStartElement("ClubCompDB10");
                Program.createNode1(Program.Organizer.Name, Program.Organizer.ID, Program.Competition.Name, Program.Competition.ID, Program.Competition.Type, Program.Category.Name, Program.SubCategory, Program.Category.ID, Program.Category.IndTADiscipline, Program.Category.IndTAClass, writer);
                writer.WriteStartElement("ClassCategory");
                writer.WriteElementString("Discipline", "Single");
                writer.WriteStartElement("Officials");
                Program.createNode2(Program.Techspec.Seg1.Name, Program.Techspec.Seg1.Club, Program.Controller.Seg1.Name, Program.Controller.Seg1.Club, Program.Referee.Seg1.Name, Program.Referee.Seg1.Club, writer);
                int pi1 = 1;
                do
                {
                    Program.createNode3(checked((short)pi1), Program.Judge[pi1].Seg1.Name, Program.Judge[pi1].Seg1.Club, writer);
                    checked { ++pi1; }
                }
                while (pi1 <= 7);
                int pi2 = 1;
                do
                {
                    Program.createNode4(checked((short)pi2), Program.DVO[pi2].Seg1.Name, Program.DVO[pi2].Seg1.Club, writer);
                    checked { ++pi2; }
                }
                while (pi2 <= 3);
                writer.WriteEndElement();
                writer.WriteStartElement("Officials2");
                Program.createNode2(Program.Techspec.Seg2.Name, Program.Techspec.Seg2.Club, Program.Controller.Seg2.Name, Program.Controller.Seg2.Club, Program.Referee.Seg2.Name, Program.Referee.Seg2.Club, writer);
                int pi3 = 1;
                do
                {
                    Program.createNode3(checked((short)pi3), Program.Judge[pi3].Seg2.Name, Program.Judge[pi3].Seg2.Club, writer);
                    checked { ++pi3; }
                }
                while (pi3 <= 7);
                int pi4 = 1;
                do
                {
                    Program.createNode4(checked((short)pi4), Program.DVO[pi4].Seg2.Name, Program.DVO[pi4].Seg2.Club, writer);
                    checked { ++pi4; }
                }
                while (pi4 <= 3);
                writer.WriteEndElement();
                string pRemSeg1 = !Program.RemWarmupTimeSeg1 ? "0" : "1";
                string pRemSeg2 = !Program.RemWarmupTimeSeg2 ? "0" : "1";
                Program.createNode5(Conversions.ToString(Program.Datum.Seg1), Conversions.ToString(Program.Datum.Seg2), Program.Datum.Seg1Start, Program.Datum.Seg2Start, pRemSeg1, pRemSeg2, Conversions.ToString(Program.TNop), Conversions.ToString(Program.NoJ_Seg1), Conversions.ToString(Program.NoJ_Seg2), Conversions.ToString(Program.NoTrJ_Seg1), Conversions.ToString(Program.NoTrJ_Seg2), Conversions.ToString(Program.JudgeSel_Seg1), Conversions.ToString(Program.JudgeSel_Seg2), Conversions.ToString(Program.WupG_Seg1), Conversions.ToString(Program.WupG_Seg2), pResSeg1, pMSeg1, pResSeg2, pMSeg2, Program.IceCondition, Program.IceArea, writer);
                if (Program.TNop > 0)
                {
                    int tnop = Program.TNop;
                    int num3 = 1;
                    while (num3 <= tnop)
                    {
                        Program.Participant[] vek = Program.Vek;
                        int index2 = num3;
                        string pElSeg1 = "";
                        string pElSeg1Edges = "";
                        string pElSeg2 = "";
                        string pElSeg2Edges = "";
                        int index3 = 1;
                        do
                        {
                            pElSeg1 += vek[index2].SSS_Seg1[index3];
                            pElSeg1Edges += vek[index2].SSS_Seg1_edges[index3];
                            if (index3 < 15)
                            {
                                pElSeg1 += "|";
                                pElSeg1Edges += "|";
                            }

                            pElSeg2 += vek[index2].SSS_Seg2[index3];
                            pElSeg2Edges += vek[index2].SSS_Seg2_edges[index3];
                            if (index3 < 15)
                            {
                                pElSeg2 += "|";
                                pElSeg2Edges += "|";
                            }
                            checked { ++index3; }
                        }
                        while (index3 <= 15);
                        string[] strArray5 = new string[8];
                        string[] strArray6 = new string[8];
                        int index4 = 1;
                        do
                        {
                            int index5 = 1;
                            do
                            {
                                strArray5[index4] = strArray5[index4] + Conversions.ToString(vek[index2].J_Seg1.EE[index5, index4]);
                                strArray6[index4] = strArray6[index4] + Conversions.ToString(vek[index2].J_Seg2.EE[index5, index4]);
                                if (index5 < 15)
                                {
                                    strArray5[index4] = strArray5[index4] + "|";
                                    strArray6[index4] = strArray6[index4] + "|";
                                }
                                checked { ++index5; }
                            }
                            while (index5 <= 15);
                            checked { ++index4; }
                        }
                        while (index4 <= 7);
                        string[] strArray7 = new string[8];
                        string[] strArray8 = new string[8];
                        int index6 = 1;
                        do
                        {
                            int index7 = 1;
                            do
                            {
                                strArray7[index6] = strArray7[index6] + Program.CCstr(vek[index2].J_Seg1.PC[index7, index6]);
                                strArray8[index6] = strArray8[index6] + Program.CCstr(vek[index2].J_Seg2.PC[index7, index6]);
                                if (index7 < 15)
                                {
                                    strArray7[index6] = strArray7[index6] + "|";
                                    strArray8[index6] = strArray8[index6] + "|";
                                }
                                checked { ++index7; }
                            }
                            while (index7 <= 15);
                            checked { ++index6; }
                        }
                        while (index6 <= 7);
                        string pMajSeg1 = "";
                        string pMajSeg2 = "";
                        int index8 = 1;
                        do
                        {
                            pMajSeg1 += Conversions.ToString(vek[index2].J_Seg1.Deduction[index8]);
                            pMajSeg2 += Conversions.ToString(vek[index2].J_Seg2.Deduction[index8]);
                            if (index8 < 7)
                            {
                                pMajSeg1 += "|";
                                pMajSeg2 += "|";
                            }
                            checked { ++index8; }
                        }
                        while (index8 <= 7);
                        Program.createNode6(Conversions.ToString(vek[index2].Startno_Seg1), Conversions.ToString(vek[index2].Startno_Seg2), Conversions.ToString(vek[index2].WarmUp_Seg1), Conversions.ToString(vek[index2].WarmUp_Seg2), vek[index2].Name.FName, vek[index2].Name.LName, vek[index2].Name.ID, vek[index2].Club, vek[index2].ClubID, Conversions.ToString(vek[index2].TES_Seg1), Conversions.ToString(vek[index2].PCS_Seg1), Conversions.ToString(vek[index2].Score_Seg1), Conversions.ToString(vek[index2].TES_Seg2), Conversions.ToString(vek[index2].PCS_Seg2), Conversions.ToString(vek[index2].Score_Seg2), Conversions.ToString(vek[index2].Score_Total), Conversions.ToString(vek[index2].Finished_Seg1), Conversions.ToString(vek[index2].Finished_Seg2), Conversions.ToString(vek[index2].Place_Seg1), Conversions.ToString(vek[index2].Place_Seg2), Conversions.ToString(vek[index2].Place), Conversions.ToString(vek[index2].DNS_Seg1), Conversions.ToString(vek[index2].DNS_Seg2), Conversions.ToString(vek[index2].HTIndSeg1), Conversions.ToString(vek[index2].HTIndSeg2), pElSeg1, pElSeg1Edges, pElSeg2, pElSeg2Edges, strArray5[1], strArray5[2], strArray5[3], strArray5[4], strArray5[5], strArray5[6], strArray5[7], strArray6[1], strArray6[2], strArray6[3], strArray6[4], strArray6[5], strArray6[6], strArray6[7], strArray7[1], strArray7[2], strArray7[3], strArray7[4], strArray7[5], strArray7[6], strArray7[7], strArray8[1], strArray8[2], strArray8[3], strArray8[4], strArray8[5], strArray8[6], strArray8[7], Conversions.ToString(vek[index2].Deductions_Seg1), Conversions.ToString(vek[index2].Deductions_Seg2), pMajSeg1, pMajSeg2, Conversions.ToString(vek[index2].Falls_seg1), Conversions.ToString(vek[index2].Falls_seg2), Conversions.ToString(vek[index2].Bonus_Seg1), Conversions.ToString(vek[index2].Bonus_Seg2), writer);
                        checked { ++num3; }
                    }
                    writer.WriteEndElement();
                }
                writer.WriteElementString("Version", "ClubCompFS Single ver. 10.0.6, 2019-01-12 / " + DateTime.Now.ToString("yyyy-MM-dd, HH:mm"));
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
                Program.CategoryFileSaved = true;
                goto label_47;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            switch (num1)
            {
                case 2:
                    int num4 = (int)Interaction.MsgBox((object)("CreateCategoryFile - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    break;
                case 3:
                    Program.CategoryFileSaved = true;
                    goto case 2;
            }
        label_47:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static string CCstr(double val)
        {
            string str = Conversions.ToString(val);
            return str.Contains(".") ? str.Replace(".", ",") : str;
        }

        private static void createNode1(
          string pOrg,
          string pOrgID,
          string pName,
          string pCompID,
          string pType,
          string pCat,
          string pScat,
          string pClassID,
          string pIndTADis,
          string pIndTAClass,
          XmlTextWriter writer)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                writer.WriteStartElement("CompetitionHeader");
                writer.WriteStartElement("Organizer");
                writer.WriteAttributeString("Name", pOrg);
                writer.WriteAttributeString("ID", pOrgID);
                writer.WriteEndElement();
                writer.WriteStartElement("Competition");
                writer.WriteAttributeString("Name", pName);
                writer.WriteAttributeString("Type", pType);
                writer.WriteAttributeString("ID", pCompID);
                writer.WriteEndElement();
                writer.WriteElementString("Category", pCat);
                writer.WriteElementString("Subcategory", pScat);
                writer.WriteStartElement("IndTA");
                writer.WriteAttributeString("IndTADiscipline", pIndTADis);
                writer.WriteAttributeString("IndTAClass", pIndTAClass);
                writer.WriteAttributeString("ClassID", pClassID);
                writer.WriteEndElement();
                writer.WriteEndElement();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("createNode1 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private static void createNode2(
          string pTSname,
          string pTSclub,
          string pTCname,
          string pTCclub,
          string pRefname,
          string pRefclub,
          XmlTextWriter writer)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                writer.WriteStartElement("TechSpec");
                writer.WriteAttributeString("Name", pTSname);
                writer.WriteAttributeString("Club", pTSclub);
                writer.WriteEndElement();
                writer.WriteStartElement("Controller");
                writer.WriteAttributeString("Name", pTCname);
                writer.WriteAttributeString("Club", pTCclub);
                writer.WriteEndElement();
                writer.WriteStartElement("Referee");
                writer.WriteAttributeString("Name", pRefname);
                writer.WriteAttributeString("Club", pRefclub);
                writer.WriteEndElement();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("createNode2 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private static void createNode3(short pi, string pName, string pClub, XmlTextWriter writer)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                writer.WriteStartElement("Judge" + Conversions.ToString((int)pi));
                writer.WriteAttributeString("Name", pName);
                writer.WriteAttributeString("Club", pClub);
                writer.WriteEndElement();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("createNode3 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private static void createNode4(short pi, string pName, string pClub, XmlTextWriter writer)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                writer.WriteStartElement("DVO" + Conversions.ToString((int)pi));
                writer.WriteAttributeString("Name", pName);
                writer.WriteAttributeString("Club", pClub);
                writer.WriteEndElement();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("createNode4 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private static void createNode5(
          string pDSeg1,
          string pDSeg2,
          string pSSeg1,
          string pSSeg2,
          string pRemSeg1,
          string pRemSeg2,
          string pTNoP,
          string pJSeg1,
          string pJSeg2,
          string pTrJSeg1,
          string pTrJSeg2,
          string pNJrefSeg1,
          string pNJrefSeg2,
          string pWSeg1,
          string pWSeg2,
          string pResSeg1,
          string pMSeg1,
          string pResSeg2,
          string pMSeg2,
          string pIceCon,
          string pIceArea,
          XmlTextWriter writer)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                writer.WriteStartElement("Segment");
                writer.WriteStartElement("Date");
                writer.WriteAttributeString("Seg1", pDSeg1);
                writer.WriteAttributeString("Seg2", pDSeg2);
                writer.WriteEndElement();
                writer.WriteStartElement("Time");
                writer.WriteAttributeString("Seg1", pSSeg1);
                writer.WriteAttributeString("Seg2", pSSeg2);
                writer.WriteEndElement();
                writer.WriteStartElement("Group1");
                writer.WriteAttributeString("RemWTSeg1", pRemSeg1);
                writer.WriteAttributeString("RemWTSeg2", pRemSeg2);
                writer.WriteEndElement();
                writer.WriteElementString("NoSkaters", pTNoP);
                writer.WriteStartElement("NoJudges");
                writer.WriteAttributeString("Seg1", pJSeg1);
                writer.WriteAttributeString("Seg2", pJSeg2);
                writer.WriteEndElement();
                writer.WriteStartElement("NoTrialJudges");
                writer.WriteAttributeString("Seg1", pTrJSeg1);
                writer.WriteAttributeString("Seg2", pTrJSeg2);
                writer.WriteEndElement();
                writer.WriteStartElement("NonJudgeReferee");
                writer.WriteAttributeString("Seg1", pNJrefSeg1);
                writer.WriteAttributeString("Seg2", pNJrefSeg2);
                writer.WriteEndElement();
                writer.WriteStartElement("NoWarmUpGr");
                writer.WriteAttributeString("Seg1", pWSeg1);
                writer.WriteAttributeString("Seg2", pWSeg2);
                writer.WriteEndElement();
                writer.WriteStartElement("Resurface");
                writer.WriteAttributeString("Seg1", pResSeg1);
                writer.WriteAttributeString("Seg2", pResSeg2);
                writer.WriteEndElement();
                writer.WriteStartElement("Meal");
                writer.WriteAttributeString("Seg1", pMSeg1);
                writer.WriteAttributeString("Seg2", pMSeg2);
                writer.WriteEndElement();
                writer.WriteElementString("IceCondition", pIceCon);
                writer.WriteElementString("IceArea", pIceArea);
                writer.WriteEndElement();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("createNode5 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        private static void createNode6(
          string pSnoSeg1,
          string pSnoSeg2,
          string pWuGrSeg1,
          string pWuGrSeg2,
          string pFName,
          string pLName,
          string pNameID,
          string pClub,
          string pClubID,
          string pTESSeg1,
          string pPCSeg1,
          string pSSeg1,
          string pTESSeg2,
          string pPCSeg2,
          string pSSeg2,
          string pSFinal,
          string pFinSeg1,
          string pFinSeg2,
          string pPSeg1,
          string pPSeg2,
          string pPFinal,
          string pDNSSeg1,
          string pDNSSeg2,
          string pHindSeg1,
          string pHindSeg2,
          string pElSeg1,
          string pElSeg1Edges,
          string pElSeg2,
          string pElSeg2Edges,
          string pJEESeg1_1,
          string pJEESeg1_2,
          string pJEESeg1_3,
          string pJEESeg1_4,
          string pJEESeg1_5,
          string pJEESeg1_6,
          string pJEESeg1_7,
          string pJEESeg2_1,
          string pJEESeg2_2,
          string pJEESeg2_3,
          string pJEESeg2_4,
          string pJEESeg2_5,
          string pJEESeg2_6,
          string pJEESeg2_7,
          string pPCSeg1_1,
          string pPCSeg1_2,
          string pPCSeg1_3,
          string pPCSeg1_4,
          string pPCSeg1_5,
          string pPCSeg1_6,
          string pPCSeg1_7,
          string pPCSeg2_1,
          string pPCSeg2_2,
          string pPCSeg2_3,
          string pPCSeg2_4,
          string pPCSeg2_5,
          string pPCSeg2_6,
          string pPCSeg2_7,
          string pDedSeg1,
          string pDedSeg2,
          string pMajSeg1,
          string pMajSeg2,
          string pFSeg1,
          string pFSeg2,
          string pBonSeg1,
          string pBonSeg2,
          XmlTextWriter writer)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                writer.WriteStartElement("Person");
                writer.WriteStartElement("Startno");
                writer.WriteAttributeString("Seg1", pSnoSeg1);
                writer.WriteAttributeString("Seg2", pSnoSeg2);
                writer.WriteEndElement();
                writer.WriteStartElement("WarmUpGr");
                writer.WriteAttributeString("Seg1", pWuGrSeg1);
                writer.WriteAttributeString("Seg2", pWuGrSeg2);
                writer.WriteEndElement();
                writer.WriteStartElement("Skater");
                writer.WriteAttributeString("Firstname", pFName);
                writer.WriteAttributeString("Surname", pLName);
                writer.WriteAttributeString("ID", pNameID);
                writer.WriteEndElement();
                writer.WriteStartElement("Club");
                writer.WriteAttributeString("Name", pClub);
                writer.WriteAttributeString("ID", pClubID);
                writer.WriteEndElement();
                writer.WriteStartElement("Seg1");
                writer.WriteAttributeString("TES", pTESSeg1);
                writer.WriteAttributeString("PCS", pPCSeg1);
                writer.WriteAttributeString("Score", pSSeg1);
                writer.WriteAttributeString("Finished", pFinSeg1);
                writer.WriteEndElement();
                writer.WriteStartElement("Seg2");
                writer.WriteAttributeString("TES", pTESSeg2);
                writer.WriteAttributeString("PCS", pPCSeg2);
                writer.WriteAttributeString("Score", pSSeg2);
                writer.WriteAttributeString("Finished", pFinSeg2);
                writer.WriteEndElement();
                writer.WriteElementString("ScoreFinal", pSFinal);
                writer.WriteStartElement("Place");
                writer.WriteAttributeString("Seg1", pPSeg1);
                writer.WriteAttributeString("Seg2", pPSeg2);
                writer.WriteAttributeString("Final", pPFinal);
                writer.WriteEndElement();
                writer.WriteStartElement("DNS");
                writer.WriteAttributeString("Seg1", pDNSSeg1);
                writer.WriteAttributeString("Seg2", pDNSSeg2);
                writer.WriteEndElement();
                writer.WriteStartElement("HTindex");
                writer.WriteAttributeString("Seg1", pHindSeg1);
                writer.WriteAttributeString("Seg2", pHindSeg2);
                writer.WriteEndElement();
                writer.WriteElementString("ElSeg1", pElSeg1);
                writer.WriteElementString("ElSeg1Edges", pElSeg1Edges);
                writer.WriteElementString("ElSeg2", pElSeg2);
                writer.WriteElementString("ElSeg2Edges", pElSeg2Edges);
                writer.WriteElementString("JEESeg1_1", pJEESeg1_1);
                writer.WriteElementString("JEESeg1_2", pJEESeg1_2);
                writer.WriteElementString("JEESeg1_3", pJEESeg1_3);
                writer.WriteElementString("JEESeg1_4", pJEESeg1_4);
                writer.WriteElementString("JEESeg1_5", pJEESeg1_5);
                writer.WriteElementString("JEESeg1_6", pJEESeg1_6);
                writer.WriteElementString("JEESeg1_7", pJEESeg1_7);
                writer.WriteElementString("JEESeg2_1", pJEESeg2_1);
                writer.WriteElementString("JEESeg2_2", pJEESeg2_2);
                writer.WriteElementString("JEESeg2_3", pJEESeg2_3);
                writer.WriteElementString("JEESeg2_4", pJEESeg2_4);
                writer.WriteElementString("JEESeg2_5", pJEESeg2_5);
                writer.WriteElementString("JEESeg2_6", pJEESeg2_6);
                writer.WriteElementString("JEESeg2_7", pJEESeg2_7);
                writer.WriteElementString("JPCSeg1_1", pPCSeg1_1);
                writer.WriteElementString("JPCSeg1_2", pPCSeg1_2);
                writer.WriteElementString("JPCSeg1_3", pPCSeg1_3);
                writer.WriteElementString("JPCSeg1_4", pPCSeg1_4);
                writer.WriteElementString("JPCSeg1_5", pPCSeg1_5);
                writer.WriteElementString("JPCSeg1_6", pPCSeg1_6);
                writer.WriteElementString("JPCSeg1_7", pPCSeg1_7);
                writer.WriteElementString("JPCSeg2_1", pPCSeg2_1);
                writer.WriteElementString("JPCSeg2_2", pPCSeg2_2);
                writer.WriteElementString("JPCSeg2_3", pPCSeg2_3);
                writer.WriteElementString("JPCSeg2_4", pPCSeg2_4);
                writer.WriteElementString("JPCSeg2_5", pPCSeg2_5);
                writer.WriteElementString("JPCSeg2_6", pPCSeg2_6);
                writer.WriteElementString("JPCSeg2_7", pPCSeg2_7);
                writer.WriteStartElement("Deductions");
                writer.WriteAttributeString("Seg1", pDedSeg1);
                writer.WriteAttributeString("Seg2", pDedSeg2);
                writer.WriteEndElement();
                writer.WriteStartElement("MajDeductions");
                writer.WriteAttributeString("Seg1", pMajSeg1);
                writer.WriteAttributeString("Seg2", pMajSeg2);
                writer.WriteEndElement();
                writer.WriteStartElement("Falls");
                writer.WriteAttributeString("Seg1", pFSeg1);
                writer.WriteAttributeString("Seg2", pFSeg2);
                writer.WriteEndElement();
                writer.WriteStartElement("Bonus");
                writer.WriteAttributeString("Seg1", pBonSeg1);
                writer.WriteAttributeString("Seg2", pBonSeg2);
                writer.WriteEndElement();
                writer.WriteEndElement();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("createNode6 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void LoadOpenDB(string File)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Program.OpenDBLastWriteTime = new FileInfo(File).LastWriteTime;
                int i;
                using (XmlReader MyReader = XmlReader.Create(File))
                {
                    i = 0;
                    while (MyReader.Read())
                    {
                        if (MyReader.NodeType == XmlNodeType.Element)
                        {
                            string name = MyReader.Name;
                            if (Operators.CompareString(name, "OpenDBversion", false) == 0)
                                Program.ParseOpenDBVersion(MyReader);
                            else if (Operators.CompareString(name, "Category", false) == 0)
                            {
                                Program.OpenDBType[] openDb = Program.OpenDB;
                                int index = i;
                                openDb[index].PCFactorsSeg1 = new double[6];
                                openDb[index].PCFactorsSeg2 = new double[6];
                                openDb[index].HT_Bonus_Calc = new int[3];
                                openDb[index].ElementTest = new int[8];
                                Program.ParseOpenDBCategory(MyReader, i);
                                checked { ++i; }
                            }
                        }
                    }
                }
                Program.NoOfCategory = i;
                goto label_18;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("LoadOpenDB - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_18:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void ParseOpenDBVersion(XmlReader MyReader)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                MyReader.ReadToFollowing("Version");
                Program.OpenDBver = MyReader.ReadString();
                goto label_7;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ParseOpenDBVersion - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_7:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void ParseOpenDBCategory(XmlReader MyReader, int i)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                MyReader.ReadToFollowing("Name");
                Program.OpenDB[i].Category = MyReader.ReadString();
                MyReader.ReadToFollowing("Warmup");
                Program.OpenDB[i].Warmup = MyReader.ReadString();
                MyReader.ReadToFollowing("Segments");
                string[] strArray1 = MyReader.ReadString().Split('|');
                Program.OpenDB[i].Segment_1 = Strings.Trim(Strings.UCase(strArray1[0]));
                Program.OpenDB[i].Segment_2 = Strings.Trim(Strings.UCase(strArray1[1]));
                MyReader.ReadToFollowing("TimeValues");
                string[] strArray2 = MyReader.ReadString().Split('|');
                Program.OpenDB[i].Seg1Time = strArray2[0];
                Program.OpenDB[i].Seg2Time = strArray2[1];
                Program.OpenDB[i].JudgeSeg1Time = strArray2[2];
                Program.OpenDB[i].JudgeSeg2Time = strArray2[3];
                MyReader.ReadToFollowing("GrSize");
                Program.OpenDB[i].GrSize = Conversions.ToInteger(MyReader.ReadString());
                MyReader.ReadToFollowing("PCFactorsSeg1");
                string[] strArray3 = MyReader.ReadString().Split('|');
                int index1 = 1;
                do
                {
                    Program.OpenDB[i].PCFactorsSeg1[index1] = Conversions.ToDouble(strArray3[checked(index1 - 1)]);
                    checked { ++index1; }
                }
                while (index1 <= Constants.TOTAL_COMPONENTS_COUNT);
                MyReader.ReadToFollowing("PCFactorsSeg2");
                string[] strArray4 = MyReader.ReadString().Split('|');
                int index2 = 1;
                do
                {
                    Program.OpenDB[i].PCFactorsSeg2[index2] = Conversions.ToDouble(strArray4[checked(index2 - 1)]);
                    checked { ++index2; }
                }
                while (index2 <= Constants.TOTAL_COMPONENTS_COUNT);
                MyReader.ReadToFollowing("DedFall");
                Program.OpenDB[i].DedFall = Conversions.ToDouble(MyReader.ReadString());
                MyReader.ReadToFollowing("DedInter");
                Program.OpenDB[i].DedInter = Conversions.ToDouble(MyReader.ReadString());
                MyReader.ReadToFollowing("HalfTimeCalc");
                string[] strArray5 = MyReader.ReadString().Split('|');
                int index3 = 1;
                do
                {
                    Program.OpenDB[i].HT_Bonus_Calc[index3] = Conversions.ToInteger(strArray5[checked(index3 - 1)]);
                    checked { ++index3; }
                }
                while (index3 <= 2);
                MyReader.ReadToFollowing("ElementTest");
                string[] strArray6 = MyReader.ReadString().Split('|');
                int index4 = 1;
                do
                {
                    Program.OpenDB[i].ElementTest[index4] = Conversions.ToInteger(strArray6[checked(index4 - 1)]);
                    checked { ++index4; }
                }
                while (index4 <= 7);
                MyReader.ReadToFollowing("AllowedJump");
                string[] strArray7 = MyReader.ReadString().Split('|');
                Program.OpenDB[i].AllowedJumps = new string[strArray7.Length];
                int index5 = 0;
                do
                {
                    Program.OpenDB[i].AllowedJumps[index5] = strArray7[index5];
                    checked { ++index5; }
                }
                while (index5 < strArray7.Length);
                goto label_16;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("ParseOpenDBCategory - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_16:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static string GetWorkMode()
        {
            string workMode = "Not selected";
            switch (Program.WorkMode)
            {
                case 1:
                    workMode = "Prepare mode";
                    break;
                case 2:
                    workMode = "Network mode";
                    break;
                case 3:
                    workMode = "Manual mode";
                    break;
            }
            return workMode;
        }

        public static void SetWorkMode(int mode)
        {
            MyProject.Forms.DBForm.Close();
            MyProject.Forms.ElementDBDisplayForm.Close();
            MyProject.Forms.JudgesDetailsForm.Close();
            MyProject.Forms.ElementInputForm.Close();
            MyProject.Forms.ResultsForm.Close();
            MyProject.Forms.WarmupGroupsForm.Close();
            MyProject.Forms.CategoryDialog.Close();
            MyProject.Forms.JudgesSetupDialog.Close();
            MyProject.Forms.ConfigurationDataDialog.Close();
            MyProject.Forms.ParticipantInputDialog.Close();
            MyProject.Forms.IndTAEntriesForm.Close();
            MyProject.Forms.IceResurfacingMealBreakDialog.Close();
            MyProject.Forms.HeadPageDialog.Close();
            switch (mode)
            {
                case 0:
                    Program.WorkMode = 0;
                    MyProject.Forms.MainForm.Mode.Text = "";
                    MyProject.Forms.StartListForm.Mode.Text = "";
                    break;
                case 1:
                    Program.WorkMode = 1;
                    MainForm mainForm_1 = MyProject.Forms.MainForm;
                    mainForm_1.Mode.Text = "Prepare mode";
                    mainForm_1.ClearDataToolStripMenuItem.Visible = true;
                    mainForm_1.CategorySelectionToolStripMenuItem.Visible = true;
                    mainForm_1.HeadPageToolStripMenuItem1.Visible = true;
                    mainForm_1.EntriesToolStripMenuItem.Visible = true;
                    mainForm_1.JudgesSetupToolStripMenuItem.Visible = true;
                    mainForm_1.OpenDBToolStripMenuItem.Visible = true;
                    mainForm_1.DBToolStripMenuItem.Visible = true;
                    mainForm_1.JudgeCardsFörOneJudgeToolStripMenuItem.Visible = true;
                    mainForm_1.JusgeCardsForASelectedSkaterToolStripMenuItem.Visible = true;
                    mainForm_1.JudgeCardForAllSkatersToolStripMenuItem.Visible = true;
                    mainForm_1.ToolStripSeparator3.Visible = true;
                    mainForm_1.TCTSCardToolStripMenuItem.Visible = true;
                    mainForm_1.TCSCardForBothTCAndTCToolStripMenuItem.Visible = true;
                    mainForm_1.TCTSCardForASelectedSkaterToolStripMenuItem.Visible = true;
                    mainForm_1.ToolStripSeparator4.Visible = true;
                    mainForm_1.ToolStripSeparator5.Visible = false;
                    mainForm_1.ToolStripSeparator6.Visible = false;
                    mainForm_1.HeadPageToolStripMenuItem.Visible = true;
                    mainForm_1.WarmupGroupsToolStripMenuItem.Visible = true;
                    mainForm_1.JudgesDetailsToolStripMenuItem.Visible = false;
                    mainForm_1.JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem.Visible = false;
                    mainForm_1.JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem.Visible = false;
                    mainForm_1.PrintAllResultDocumentsCategoryToolStripMenuItem.Visible = false;
                    mainForm_1.ResultsToolStripMenuItem.Visible = false;
                    mainForm_1.CREATEFILESToolStripMenuItem.Visible = false;
                    mainForm_1.CREATEPDFFILESToolStripMenuItem.Visible = true;
                    mainForm_1.SHOWRESULTSToolStripMenuItem.Visible = false;
                    string seg = Program.GetSeg();
                    if (Operators.CompareString(seg, "SS", false) == 0 || Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "FF", false) == 0)
                        mainForm_1.COPYOFFICIALSToolStripMenuItem.Visible = true;
                    else
                        mainForm_1.COPYOFFICIALSToolStripMenuItem.Visible = false;
                    mainForm_1.ToolStripSeparator1.Visible = false;
                    mainForm_1.PingTheNetworkToolStripMenuItem.Visible = false;
                    mainForm_1.lblCC_El.Visible = false;
                    mainForm_1.lblCC_Info.Visible = false;
                    mainForm_1.lblCC_MP.Visible = false;
                    StartListForm startListForm_1 = MyProject.Forms.StartListForm;
                    startListForm_1.Mode.Text = "Prepare mode";
                    startListForm_1.Menu_Workmode_1();
                    startListForm_1.Panel1.Visible = false;
                    startListForm_1.DataGridView1.ContextMenuStrip = startListForm_1.ContextMenuStrip1;
                    JudgesDetailsForm judgesDetailsForm_1 = MyProject.Forms.JudgesDetailsForm;
                    judgesDetailsForm_1.INPUTELEMENTToolStripMenuItem.Visible = false;
                    judgesDetailsForm_1.CREATERESULTSToolStripMenuItem.Visible = false;
                    judgesDetailsForm_1.EDITJUDGEDATAToolStripMenuItem.Visible = false;
                    MyProject.Forms.ElementInputForm.Panel1.Visible = false;
                    break;
                case 2:
                    Program.WorkMode = 2;
                    MyProject.Forms.MainForm.Mode.Text = "Network mode";
                    MainForm mainForm_2 = MyProject.Forms.MainForm;
                    mainForm_2.StartServer();
                    mainForm_2.Mode.Text = "Network mode";
                    mainForm_2.ClearDataToolStripMenuItem.Visible = false;
                    mainForm_2.CategorySelectionToolStripMenuItem.Visible = false;
                    mainForm_2.HeadPageToolStripMenuItem1.Visible = true;
                    mainForm_2.EntriesToolStripMenuItem.Visible = false;
                    mainForm_2.JudgesSetupToolStripMenuItem.Visible = false;
                    mainForm_2.OpenDBToolStripMenuItem.Visible = false;
                    mainForm_2.DBToolStripMenuItem.Visible = false;
                    mainForm_2.JudgeCardsFörOneJudgeToolStripMenuItem.Visible = false;
                    mainForm_2.JusgeCardsForASelectedSkaterToolStripMenuItem.Visible = false;
                    mainForm_2.JudgeCardForAllSkatersToolStripMenuItem.Visible = false;
                    mainForm_2.ToolStripSeparator3.Visible = false;
                    mainForm_2.TCTSCardToolStripMenuItem.Visible = false;
                    mainForm_2.TCSCardForBothTCAndTCToolStripMenuItem.Visible = false;
                    mainForm_2.TCTSCardForASelectedSkaterToolStripMenuItem.Visible = false;
                    mainForm_2.ToolStripSeparator4.Visible = false;
                    mainForm_2.ToolStripSeparator5.Visible = true;
                    mainForm_2.ToolStripSeparator6.Visible = true;
                    mainForm_2.HeadPageToolStripMenuItem.Visible = false;
                    mainForm_2.WarmupGroupsToolStripMenuItem.Visible = true;
                    mainForm_2.JudgesDetailsToolStripMenuItem.Visible = true;
                    mainForm_2.JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem.Visible = true;
                    mainForm_2.JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem.Visible = true;
                    mainForm_2.PrintAllResultDocumentsCategoryToolStripMenuItem.Visible = true;
                    mainForm_2.ResultsToolStripMenuItem.Visible = true;
                    mainForm_2.CREATEFILESToolStripMenuItem.Visible = true;
                    mainForm_2.CREATEPDFFILESToolStripMenuItem.Visible = false;
                    mainForm_2.SHOWRESULTSToolStripMenuItem.Visible = true;
                    mainForm_2.COPYOFFICIALSToolStripMenuItem.Visible = false;
                    mainForm_2.ToolStripSeparator1.Visible = true;
                    mainForm_2.PingTheNetworkToolStripMenuItem.Visible = true;
                    mainForm_2.lblCC_El.Visible = true;
                    mainForm_2.lblCC_Info.Visible = true;
                    mainForm_2.lblCC_MP.Visible = true;
                    StartListForm startListForm_2 = MyProject.Forms.StartListForm;
                    startListForm_2.Mode.Text = "Network mode";
                    startListForm_2.Menu_Workmode_2_and_3();
                    startListForm_2.Panel1.Visible = true;
                    startListForm_2.DataGridView1.ContextMenuStrip = (ContextMenuStrip)null;
                    JudgesDetailsForm judgesDetailsForm_2 = MyProject.Forms.JudgesDetailsForm;
                    judgesDetailsForm_2.INPUTELEMENTToolStripMenuItem.Visible = true;
                    judgesDetailsForm_2.CREATERESULTSToolStripMenuItem.Visible = true;
                    judgesDetailsForm_2.EDITJUDGEDATAToolStripMenuItem.Visible = false;
                    MyProject.Forms.ElementInputForm.Panel1.Visible = true;
                    break;
                case 3:
                    Program.WorkMode = 3;
                    MyProject.Forms.MainForm.Mode.Text = "Manual mode";
                    MainForm mainForm_3 = MyProject.Forms.MainForm;
                    mainForm_3.Mode.Text = "Manual mode";
                    mainForm_3.ClearDataToolStripMenuItem.Visible = false;
                    mainForm_3.CategorySelectionToolStripMenuItem.Visible = false;
                    mainForm_3.HeadPageToolStripMenuItem1.Visible = true;
                    mainForm_3.EntriesToolStripMenuItem.Visible = false;
                    mainForm_3.JudgesSetupToolStripMenuItem.Visible = false;
                    mainForm_3.OpenDBToolStripMenuItem.Visible = false;
                    mainForm_3.DBToolStripMenuItem.Visible = false;
                    mainForm_3.JudgeCardsFörOneJudgeToolStripMenuItem.Visible = false;
                    mainForm_3.JusgeCardsForASelectedSkaterToolStripMenuItem.Visible = false;
                    mainForm_3.JudgeCardForAllSkatersToolStripMenuItem.Visible = false;
                    mainForm_3.ToolStripSeparator3.Visible = false;
                    mainForm_3.TCTSCardToolStripMenuItem.Visible = false;
                    mainForm_3.TCSCardForBothTCAndTCToolStripMenuItem.Visible = false;
                    mainForm_3.TCTSCardForASelectedSkaterToolStripMenuItem.Visible = false;
                    mainForm_3.ToolStripSeparator4.Visible = false;
                    mainForm_3.ToolStripSeparator5.Visible = true;
                    mainForm_3.ToolStripSeparator6.Visible = true;
                    mainForm_3.HeadPageToolStripMenuItem.Visible = false;
                    mainForm_3.WarmupGroupsToolStripMenuItem.Visible = true;
                    mainForm_3.JudgesDetailsToolStripMenuItem.Visible = true;
                    mainForm_3.JudgesDetailsForTheCategoryWithoutTRJudgesToolStripMenuItem.Visible = true;
                    mainForm_3.JudgesDetailsForTheCategoryWithOneSkaterPerPageToolStripMenuItem.Visible = true;
                    mainForm_3.PrintAllResultDocumentsCategoryToolStripMenuItem.Visible = true;
                    mainForm_3.ResultsToolStripMenuItem.Visible = true;
                    mainForm_3.CREATEFILESToolStripMenuItem.Visible = true;
                    mainForm_3.CREATEPDFFILESToolStripMenuItem.Visible = false;
                    mainForm_3.SHOWRESULTSToolStripMenuItem.Visible = true;
                    mainForm_3.COPYOFFICIALSToolStripMenuItem.Visible = false;
                    mainForm_3.ToolStripSeparator1.Visible = false;
                    mainForm_3.PingTheNetworkToolStripMenuItem.Visible = false;
                    mainForm_3.lblCC_El.Visible = false;
                    mainForm_3.lblCC_Info.Visible = true;
                    mainForm_3.lblCC_MP.Visible = true;
                    StartListForm startListForm_3 = MyProject.Forms.StartListForm;
                    startListForm_3.Mode.Text = "Manual mode";
                    startListForm_3.Menu_Workmode_2_and_3();
                    startListForm_3.Panel1.Visible = true;
                    startListForm_3.DataGridView1.ContextMenuStrip = (ContextMenuStrip)null;
                    JudgesDetailsForm judgesDetailsForm_3 = MyProject.Forms.JudgesDetailsForm;
                    judgesDetailsForm_3.INPUTELEMENTToolStripMenuItem.Visible = true;
                    judgesDetailsForm_3.CREATERESULTSToolStripMenuItem.Visible = true;
                    judgesDetailsForm_3.EDITJUDGEDATAToolStripMenuItem.Visible = true;
                    MyProject.Forms.ElementInputForm.Panel1.Visible = true;
                    break;
            }
        }

        public static void CalcPCindex()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                ProjectData.ClearProjectError();
                num1 = 1;
                int index = 0;
                while (Operators.CompareString(Program.OpenDB[index].Category, Program.Category.Name, false) != 0)
                {
                    checked { ++index; }
                    if (index > 80)
                    {
                        Program.PcIndex = -1;
                        int num3 = (int)Interaction.MsgBox((object)"Can't find the Category in OpenDB!", MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_10;
                    }
                }
                Program.PcIndex = index;
                goto label_10;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            int num4 = (int)Interaction.MsgBox((object)("ParseOpenDBCategory - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
        label_10:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void CreateJudgesDetails(int R, ref int rowDed)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                string segment1 = Program.Segment;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    ref Program.Participant local1 = ref Program.Vek[Program.PNo];
                }
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                {
                    ref Program.Participant local2 = ref Program.Vek[Program.PNo];
                }
                Program.JDarr = (string[,])null;
                Program.JDarr = new string[51, 15];
                Program.RowJD = 0;
                if (Program.PNo > 0 & Program.PNo <= Program.TNop & Program.PNo <= 42)
                {
                    Program.A_Calc_Sum(0, 1);
                    JudgesDetailsForm judgesDetailsForm = MyProject.Forms.JudgesDetailsForm;
                    if (R == 0)
                        judgesDetailsForm.DataGridView1.Rows.Clear();
                    Program.B_Init_SheetText(0);
                    Program.RowJD = Program.B_SSS_data(0);
                    int num3 = checked(Program.RowJD - 8);
                    if (Program.RowJD > 0)
                    {
                        Program.B_Show_GOEdata(0, Program.RowJD);
                        Program.B_Show_PCfactors(0, checked(Program.RowJD + 1));
                        Program.A_CalcPC(0, checked(Program.RowJD + 2), 1);
                        Program.B_Show_PCdata(0, checked(Program.RowJD + 3));
                        Program.B_Calc_BaseSum(0, Program.RowJD);
                        Program.B_Show_Bonus(0);
                        Program.B_Show_Deductions(0, checked(Program.RowJD + 9), ref rowDed);
                        Program.B_Show_Scores(0);
                        goto label_20;
                    }
                    else
                    {
                        string segment2 = Program.Segment;
                        if (Operators.CompareString(segment2, "Seg1", false) == 0)
                        {
                            Program.Vek[Program.PNo].Score_Seg1 = 0.0;
                            Program.Vek[Program.PNo].Deductions_Seg1 = 0L;
                            Program.Vek[Program.PNo].TES_Seg1 = 0.0;
                            Program.Vek[Program.PNo].PCS_Seg1 = 0.0;
                        }
                        else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                        {
                            Program.Vek[Program.PNo].Score_Seg2 = 0.0;
                            Program.Vek[Program.PNo].Deductions_Seg2 = 0L;
                            Program.Vek[Program.PNo].PCS_Seg2 = 0.0;
                            Program.Vek[Program.PNo].TES_Seg2 = 0.0;
                        }
                        int num4 = (int)Interaction.MsgBox((object)"No data available!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        goto label_20;
                    }
                }
                else
                    goto label_20;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("CreateJudgesDetails - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_20:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void SetNoJ()
        {
            string segment = Program.Segment;
            if (Operators.CompareString(segment, "Seg1", false) == 0)
            {
                Program.NoJ_GOE = Program.NoJ_Seg1;
                Program.NoTrj = Program.NoTrJ_Seg1;
                Program.JudgeSel = Program.JudgeSel_Seg1;
            }
            else if (Operators.CompareString(segment, "Seg2", false) == 0)
            {
                Program.NoJ_GOE = Program.NoJ_Seg2;
                Program.NoTrj = Program.NoTrJ_Seg2;
                Program.JudgeSel = Program.JudgeSel_Seg2;
            }
            else
            {
                Program.NoJ_GOE = Program.NoJ_Seg1;
                Program.NoTrj = Program.NoTrJ_Seg1;
                Program.JudgeSel = Program.JudgeSel_Seg1;
            }
        }

        public static void A_Calc_Sum(int R, int JDA)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                double num3 = Program.A_Calc_BV_GOE(R, Program.A_CalcNoOfEl(), JDA);
                double num4 = Program.A_CalcPC(0, 0, 0);
                double num5 = Program.A_Calc_Bonus();
                double num6 = Program.DedSeg1Seg2(Program.PNo, Program.Segment);
                string segment = Program.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    double num7 = Program.Vek[Program.PNo].Bonus_Seg1 <= 0 ? num3 + num4 - num6 : num3 + num4 + num5 - num6;
                    if (Program.Vek[Program.PNo].Finished_Seg1 == 1)
                    {
                        Program.Vek[Program.PNo].Score_Seg1 = num7;
                        Program.Vek[Program.PNo].TES_Seg1 = num3;
                        Program.Vek[Program.PNo].PCS_Seg1 = num4;
                        goto label_12;
                    }
                    else
                        goto label_12;
                }
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                {
                    double num8 = Program.Vek[Program.PNo].Bonus_Seg2 <= 0 ? num3 + num4 - num6 : num3 + num4 + num5 - num6;
                    if (Program.Vek[Program.PNo].Finished_Seg2 == 1)
                    {
                        Program.Vek[Program.PNo].Score_Seg2 = num8;
                        Program.Vek[Program.PNo].TES_Seg2 = num3;
                        Program.Vek[Program.PNo].PCS_Seg2 = num4;
                        goto label_12;
                    }
                    else
                        goto label_12;
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
                int num9 = (int)Interaction.MsgBox((object)("A_Calc_Sum - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_12:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static string Test_SEQ_COMBO_REP(string El)
        {
            int num1 = 0;
            string str1 = "";
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                str1 = El;
                if (El.Contains("+SEQ") & El.Contains("+REP"))
                {
                    int num3 = Strings.InStr(El, "+SEQ");
                    str1 = Strings.Left(El, checked(num3 - 1)) + "+REP";
                    goto label_9;
                }
                else if (El.Contains("+COMBO") & El.Contains("+REP"))
                {
                    int num4 = Strings.InStr(El, "+COMBO");
                    str1 = Strings.Left(El, checked(num4 - 1)) + "+REP";
                    goto label_9;
                }
                else
                    goto label_9;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("Test_SEQ_COMBO_REP - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_9:
            string str2 = str1;
            if (num2 == 0)
                return str2;
            ProjectData.ClearProjectError();
            return str2;
        }

        public static bool FindJumpEl(string StringEl)
        {
            int num1 = 0;
            bool flag = false;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Program.ElArr = (Program.El_type[])null;
                Program.ElArr = new Program.El_type[31];
                string[] strArray = StringEl.Split('+');
                string str = !strArray[0].Contains("*") ? strArray[0] : Strings.Replace(strArray[0], "*", "");
                if (str.Contains("!"))
                    str = Strings.Replace(str, "!", "");
                else if (str.Contains("f"))
                    str = Strings.Replace(str, "f", "");
                else if (str.Contains(" q"))
                    str = Strings.Replace(str, " q", "");
                flag = false;
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
                goto label_12;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("FindJumpEl - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_12:
            int num4 = flag ? 1 : 0;
            if (num2 == 0)
                return num4 != 0;
            ProjectData.ClearProjectError();
            return num4 != 0;
        }

        public static double A_Calc_BV_GOE(int R, int NoOfEE, int C_JDA)
        {
            int num1 = 0;
            double num2 = 0.0;
            int num3 = 0;
            try
            {
                int elDbmax = Program.ElDBmax;
                double[] numArray1 = new double[41];
                double[] numArray2 = new double[50];
                double[] numArray3 = new double[41];
                int[] numArray4 = new int[16];
                ProjectData.ClearProjectError();
                num1 = 2;
                Program.ElErrorArr = (int[])null;
                Program.ElErrorArr = new int[31];
                int[] numArray5 = new int[16];
                num2 = 0.0;
                if (Program.NoJ_GOE != 0)
                {
                    int num4 = 0;
                    int index1 = NoOfEE;
                    while (index1 >= 1)
                    {
                        string segment = Program.Segment;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                        {
                            if (Program.FindJumpEl(Program.Vek[Program.PNo].SSS_Seg1[index1]) && num4 < 1)
                            {
                                checked { ++num4; }
                                numArray5[index1] = num4;
                            }
                        }
                        else if (Operators.CompareString(segment, "Seg2", false) == 0 && Program.FindJumpEl(Program.Vek[Program.PNo].SSS_Seg2[index1]) && num4 < 3)
                        {
                            checked { ++num4; }
                            numArray5[index1] = num4;
                        }
                        checked { index1 += -1; }
                    }
                    int num5 = NoOfEE;
                    int ind = 1;
                    double num6 = 0.0;
                    while (ind <= num5)
                    {
                        string str1 = "";
                        string segment1 = Program.Segment;
                        if (Operators.CompareString(segment1, "Seg1", false) == 0)
                            str1 = Program.Vek[Program.PNo].SSS_Seg1[ind];
                        else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                            str1 = Program.Vek[Program.PNo].SSS_Seg2[ind];
                        int num7 = Strings.InStr(1, str1, " !", CompareMethod.Text);
                        if (num7 > 0)
                            str1 = Strings.Left(str1, checked(num7 - 1));

                        num7 = Strings.InStr(1, str1, " f", CompareMethod.Text);
                        if (num7 > 0)
                            str1 = Strings.Left(str1, checked(num7 - 1));

                        string str2 = Program.Test_SEQ_COMBO_REP(str1);
                        if (Strings.Len(str2) >= 1)
                        {
                            int num8 = Strings.InStr(1, str2, "+COMBO", CompareMethod.Text);
                            if (num8 > 0)
                                str2 = Strings.Left(str2, checked(num8 - 1));
                            string segment2 = Program.Segment;
                            double Right1 = Operators.CompareString(segment2, "Seg1", false) != 0 ? (Operators.CompareString(segment2, "Seg2", false) != 0 ? 1.0 : (!(ind >= Program.Vek[Program.PNo].HTIndSeg2 & Program.Vek[Program.PNo].HTIndSeg2 != 0) ? 1.0 : (numArray5[ind] == 0 ? 1.0 : 1.1))) : (!(ind >= Program.Vek[Program.PNo].HTIndSeg1 & Program.Vek[Program.PNo].HTIndSeg1 != 0) ? 1.0 : (numArray5[ind] <= 0 ? 1.0 : 1.1));
                            int Eno = 0;
                            Program.El_type elType;
                            if (Strings.InStr(1, str2, "+SEQ", CompareMethod.Text) > 0)
                            {
                                double Right2 = 0.0;
                                int num9 = Strings.InStr(str2, "+SEQ");
                                Program.FindJumpEl1(Strings.Left(str2, checked(num9 - 1)), ref Eno);
                                int num10 = checked(Eno - 1);
                                int index2 = 1;
                                while (index2 <= num10)
                                {
                                    string elstr = Program.ElArr[index2].Elstr;
                                    if (elstr.Contains("*"))
                                    {
                                        Program.ElArr[index2].Value = 0.0;
                                        Program.ElArr[index2].BaseValue = 0.0;
                                        Program.ElArr[index2].row = 0;
                                    }
                                    else
                                    {
                                        int jumpmin = Program.Jumpmin;
                                        int jumpMax = Program.JumpMax;
                                        int index3 = jumpmin;

                                        elstr = Strings.Replace(elstr, "*", "");
                                        elstr = Strings.Replace(elstr, " !", "");
                                        elstr = Strings.Replace(elstr, "!", "");
                                        elstr = Strings.Replace(elstr, "f", "");
                                        elstr = Strings.Replace(elstr, " q", "");

                                        while (index3 <= jumpMax)
                                        {
                                            if (Operators.ConditionalCompareObjectEqual((object)elstr, Program.ElDB[index3, 0], false))
                                            {
                                                Program.ElArr[index2].row = index3;
                                                int index4 = 6;
                                                Program.ElArr[index2].Value = Conversions.ToDouble(Program.ElDB[index3, index4]);
                                                Program.ElArr[index2].BaseValue = Conversions.ToDouble(Program.ElDB[index3, 6]);
                                                if (Program.ElArr[index2].Value != 0.0)
                                                    break;
                                                break;
                                            }
                                            checked { ++index3; }
                                        }
                                        if (index3 > Program.JumpMax)
                                            Program.ErrMessage(ind);
                                    }
                                    checked { ++index2; }
                                }
                                int num11 = checked(Eno - 1 - 1);
                                int index5 = 1;
                                while (index5 <= num11)
                                {
                                    elType = Program.ElArr[index5];
                                    int index6 = index5;
                                    int num12 = checked(index5 + 1);
                                    int num13 = checked(Eno - 1);
                                    int index7 = num12;
                                    while (index7 <= num13)
                                    {
                                        if (Program.ElArr[index7].BaseValue > elType.BaseValue)
                                        {
                                            elType = Program.ElArr[index7];
                                            index6 = index7;
                                        }
                                        checked { ++index7; }
                                    }
                                    Program.ElArr[index6] = Program.ElArr[index5];
                                    Program.ElArr[index5] = elType;
                                    checked { ++index5; }
                                }
                                int row = Program.ElArr[1].row;
                                double num14 = Program.ElArr[2].row != 0 ? Program.ElArr[2].Value : 0.0;
                                if (row > 0)
                                {
                                    double Expression = Conversion.Int(100.0 * (num14 + Program.ElArr[1].Value) * 0.8 + 0.5000001) / 100.0 * Right1;
                                    numArray1[ind] = Expression;
                                    if (C_JDA > 0)
                                    {
                                        Program.JDarr[checked(R + ind + 8), 4] = Strings.Format((object)Expression, "0.00");
                                        if (Right1 > 1.0)
                                            Program.JDarr[checked(R + ind + 8), 5] = "x";
                                    }
                                    int noJGoe1 = Program.NoJ_GOE;
                                    int index8 = 1;
                                    while (index8 <= noJGoe1)
                                    {
                                        string segment3 = Program.Segment;
                                        if (Operators.CompareString(segment3, "Seg1", false) == 0)
                                            Program.J_GOE[index8] = Program.Vek[Program.PNo].J_Seg1.EE[ind, index8];
                                        else if (Operators.CompareString(segment3, "Seg2", false) == 0)
                                            Program.J_GOE[index8] = Program.Vek[Program.PNo].J_Seg2.EE[ind, index8];
                                        checked { ++index8; }
                                    }
                                    if (Program.NoJ_GOE < Program.NoJudgeTMV)
                                    {
                                        int noJGoe2 = Program.NoJ_GOE;
                                        int index9 = 1;
                                        while (index9 <= noJGoe2)
                                        {
                                            int index10 = checked(6 - Program.J_GOE[index9]);
                                            Right2 = index10 != 6 ? Conversions.ToDouble(Operators.AddObject(Program.ElDB[row, index10], (object)Right2)) : 0.0 + Right2;
                                            checked { ++index9; }
                                        }
                                        numArray2[ind] = Right2 / (double)Program.NoJ_GOE;
                                        if (C_JDA > 0)
                                            Program.JDarr[checked(R + ind + 8), 6] = Conversions.ToString(numArray2[ind]);
                                    }
                                    else
                                    {
                                        Program.Sort_J_GOE(Program.NoJ_GOE);
                                        int num15 = checked(Program.NoJ_GOE - 1);
                                        int index11 = 2;
                                        while (index11 <= num15)
                                        {
                                            int index12 = checked(6 - Program.J_GOE[index11]);
                                            Right2 = index12 != 6 ? Conversions.ToDouble(Operators.AddObject(Program.ElDB[row, index12], (object)Right2)) : 0.0 + Right2;
                                            checked { ++index11; }
                                        }
                                        numArray2[ind] = Right2 / (double)checked(Program.NoJ_GOE - 2);
                                        if (C_JDA > 0)
                                            Program.JDarr[checked(R + ind + 8), 6] = Conversions.ToString(numArray2[ind]);
                                    }
                                }
                                else
                                {
                                    numArray1[ind] = 0.0;
                                    if (C_JDA > 0)
                                        Program.JDarr[checked(R + ind + 8), 4] = Strings.Format((object)numArray1[ind], "0.00");
                                    numArray2[ind] = 0.0;
                                    if (C_JDA > 0)
                                        Program.JDarr[checked(R + ind + 8), 6] = Conversions.ToString(numArray2[ind]);
                                }
                            }
                            else if (Strings.InStr(1, str2, "+REP", CompareMethod.Text) > 0)
                            {
                                double num16 = 0.0;
                                double Right3 = 0.0;
                                int num17 = Strings.InStr(str2, "+REP");
                                Program.FindJumpEl1(Strings.Left(str2, checked(num17 - 1)), ref Eno);
                                int num18 = checked(Eno - 1);
                                int index13 = 1;
                                while (index13 <= num18)
                                {
                                    string elstr = Program.ElArr[index13].Elstr;
                                    if (elstr.Contains("*"))
                                    {
                                        Program.ElArr[index13].Value = 0.0;
                                        Program.ElArr[index13].BaseValue = 0.0;
                                        Program.ElArr[index13].row = 0;
                                    }
                                    else
                                    {
                                        int jumpmin = Program.Jumpmin;
                                        int jumpMax = Program.JumpMax;
                                        int index14 = jumpmin;

                                        elstr = Strings.Replace(elstr, "*", "");
                                        elstr = Strings.Replace(elstr, " !", "");
                                        elstr = Strings.Replace(elstr, "!", "");
                                        elstr = Strings.Replace(elstr, "f", "");
                                        elstr = Strings.Replace(elstr, " q", "");

                                        while (index14 <= jumpMax)
                                        {
                                            if (Operators.ConditionalCompareObjectEqual((object)elstr, Program.ElDB[index14, 0], false))
                                            {
                                                Program.ElArr[index13].row = index14;
                                                int index15 = 6;
                                                Program.ElArr[index13].Value = Conversions.ToDouble(Operators.MultiplyObject(Operators.MultiplyObject(Program.ElDB[index14, index15], (object)Right1), (object)0.7));
                                                Program.ElArr[index13].BaseValue = Conversions.ToDouble(Program.ElDB[index14, 6]);
                                                if (Program.ElArr[index13].Value != 0.0)
                                                    break;
                                                break;
                                            }
                                            checked { ++index14; }
                                        }
                                        if (index14 > Program.JumpMax)
                                            Program.ErrMessage(ind);
                                    }
                                    checked { ++index13; }
                                }
                                elType.Value = 0.0;
                                elType.BaseValue = 0.0;
                                elType.row = 0;
                                int num19 = checked(Eno - 1);
                                int index16 = 1;
                                while (index16 <= num19)
                                {
                                    num16 += Program.ElArr[index16].Value;
                                    if (Program.ElArr[index16].BaseValue > elType.BaseValue)
                                        elType = Program.ElArr[index16];
                                    checked { ++index16; }
                                }
                                int row = elType.row;
                                numArray1[ind] = num16;
                                if (C_JDA > 0)
                                {
                                    Program.JDarr[checked(R + ind + 8), 4] = Strings.Format((object)numArray1[ind], "0.00");
                                    if (Right1 > 1.0)
                                        Program.JDarr[checked(R + ind + 8), 5] = "x";
                                }
                                int noJGoe3 = Program.NoJ_GOE;
                                int index17 = 1;
                                while (index17 <= noJGoe3)
                                {
                                    string segment4 = Program.Segment;
                                    if (Operators.CompareString(segment4, "Seg1", false) == 0)
                                        Program.J_GOE[index17] = Program.Vek[Program.PNo].J_Seg1.EE[ind, index17];
                                    else if (Operators.CompareString(segment4, "Seg2", false) == 0)
                                        Program.J_GOE[index17] = Program.Vek[Program.PNo].J_Seg2.EE[ind, index17];
                                    checked { ++index17; }
                                }
                                if (Program.NoJ_GOE < Program.NoJudgeTMV)
                                {
                                    int noJGoe4 = Program.NoJ_GOE;
                                    int index18 = 1;
                                    while (index18 <= noJGoe4)
                                    {
                                        int index19 = checked(6 - Program.J_GOE[index18]);
                                        Right3 = index19 != 6 ? Conversions.ToDouble(Operators.AddObject(Program.ElDB[row, index19], (object)Right3)) : 0.0 + Right3;
                                        checked { ++index18; }
                                    }
                                    numArray2[ind] = Right3 / (double)Program.NoJ_GOE;
                                    if (C_JDA > 0)
                                        Program.JDarr[checked(R + ind + 8), 6] = Conversions.ToString(numArray2[ind]);
                                }
                                else
                                {
                                    Program.Sort_J_GOE(Program.NoJ_GOE);
                                    int num20 = checked(Program.NoJ_GOE - 1);
                                    int index20 = 2;
                                    while (index20 <= num20)
                                    {
                                        int index21 = checked(6 - Program.J_GOE[index20]);
                                        Right3 = index21 != 6 ? Conversions.ToDouble(Operators.AddObject(Program.ElDB[row, index21], (object)Right3)) : 0.0 + Right3;
                                        checked { ++index20; }
                                    }
                                    numArray2[ind] = Right3 / (double)checked(Program.NoJ_GOE - 2);
                                    if (C_JDA > 0)
                                        Program.JDarr[checked(R + ind + 8), 6] = Conversions.ToString(numArray2[ind]);
                                }
                            }
                            else if (str2.Contains("Sp") & Strings.Len(str2) >= 1)
                            {
                                double Left1 = 0.0;
                                double Right4 = 0.0;
                                int index22 = 0;
                                string Left2 = str2;
                                int spinMin = Program.SpinMin;
                                int spinmax = Program.Spinmax;
                                if (Left2.Contains("*"))
                                {
                                    Left1 += 0.0;
                                }
                                else
                                {
                                    do
                                    {
                                        if (Operators.ConditionalCompareObjectNotEqual(Program.ElDB[spinMin, 0], (object)"", false) && Operators.ConditionalCompareObjectEqual((object)Left2, Program.ElDB[spinMin, 0], false))
                                        {
                                            index22 = spinMin;
                                            int num21 = spinMin;
                                            if (num21 >= Program.SpinMin && num21 <= Program.Spinmax)
                                            {
                                                int index23 = 6;
                                                Left1 = Conversions.ToDouble(Operators.AddObject((object)Left1, Program.ElDB[spinMin, index23]));
                                            }
                                        }
                                        checked { ++spinMin; }
                                    }
                                    while (!(spinMin > spinmax | index22 > 0));
                                    if (spinMin > checked(Program.ElDBmax + 2))
                                        Program.ErrMessage(ind);
                                }
                                numArray1[ind] = Left1;
                                if (C_JDA > 0)
                                    Program.JDarr[checked(R + ind + 8), 4] = Strings.Format((object)numArray1[ind], "0.00");
                                int noJGoe5 = Program.NoJ_GOE;
                                int index24 = 1;
                                while (index24 <= noJGoe5)
                                {
                                    string segment5 = Program.Segment;
                                    if (Operators.CompareString(segment5, "Seg1", false) == 0)
                                        Program.J_GOE[index24] = Program.Vek[Program.PNo].J_Seg1.EE[ind, index24];
                                    else if (Operators.CompareString(segment5, "Seg2", false) == 0)
                                        Program.J_GOE[index24] = Program.Vek[Program.PNo].J_Seg2.EE[ind, index24];
                                    checked { ++index24; }
                                }
                                if (Program.NoJ_GOE < Program.NoJudgeTMV)
                                {
                                    int noJGoe6 = Program.NoJ_GOE;
                                    int index25 = 1;
                                    while (index25 <= noJGoe6)
                                    {
                                        int index26 = checked(6 - Program.J_GOE[index25]);
                                        Right4 = index26 != 6 ? Conversions.ToDouble(Operators.AddObject(Program.ElDB[index22, index26], (object)Right4)) : 0.0 + Right4;
                                        checked { ++index25; }
                                    }
                                    if (Program.NoJ_GOE != 0)
                                    {
                                        numArray2[ind] = Right4 / (double)Program.NoJ_GOE;
                                        if (C_JDA > 0)
                                            Program.JDarr[checked(R + ind + 8), 6] = Conversions.ToString(numArray2[ind]);
                                    }
                                    else
                                        goto label_225;
                                }
                                else
                                {
                                    Program.Sort_J_GOE(Program.NoJ_GOE);
                                    int num22 = checked(Program.NoJ_GOE - 1);
                                    int index27 = 2;
                                    while (index27 <= num22)
                                    {
                                        int index28 = checked(6 - Program.J_GOE[index27]);
                                        Right4 = index28 != 6 ? Conversions.ToDouble(Operators.AddObject(Program.ElDB[index22, index28], (object)Right4)) : 0.0 + Right4;
                                        checked { ++index27; }
                                    }
                                    numArray2[ind] = Right4 / (double)checked(Program.NoJ_GOE - 2);
                                    if (C_JDA > 0)
                                        Program.JDarr[checked(R + ind + 8), 6] = Conversions.ToString(numArray2[ind]);
                                }
                            }
                            else if (Strings.InStr(1, str2, "+", CompareMethod.Text) > 0 & !str2.Contains("+V"))
                            {
                                double num23 = 0.0;
                                double Right5 = 0.0;
                                Program.FindJumpEl1(str2, ref Eno);
                                int num24 = checked(Eno - 1);
                                int index29 = 1;
                                while (index29 <= num24)
                                {
                                    string elstr = Program.ElArr[index29].Elstr;
                                    if (elstr.Contains("*"))
                                    {
                                        Program.ElArr[index29].Value = 0.0;
                                        Program.ElArr[index29].BaseValue = 0.0;
                                        Program.ElArr[index29].row = 0;
                                    }
                                    else
                                    {
                                        int jumpmin = Program.Jumpmin;
                                        int jumpMax = Program.JumpMax;
                                        int index30 = jumpmin;
                                        
                                        if (elstr.Contains("*"))
                                            elstr = Strings.Trim(elstr.Replace("*", ""));
                                        if (Operators.CompareString(Strings.Right(elstr, 1), "e", false) == 0)
                                            elstr = Strings.Trim(elstr.Replace("e", ""));
                                        if (Operators.CompareString(Strings.Right(elstr, 1), "<", false) == 0)
                                            elstr = Strings.Trim(elstr.Replace("<", ""));
                                        if (elstr.Contains("!"))
                                            elstr = Strings.Trim(elstr.Replace("!", ""));
                                        if (elstr.Contains("f"))
                                            elstr = Strings.Trim(elstr.Replace("f", ""));
                                        if (elstr.Contains(" q"))
                                            elstr = Strings.Trim(elstr.Replace(" q", ""));

                                        while (index30 <= jumpMax)
                                        {
                                            if (Operators.ConditionalCompareObjectEqual((object)elstr, Program.ElDB[index30, 0], false))
                                            {
                                                Program.ElArr[index29].row = index30;
                                                int index31 = 6;
                                                Program.ElArr[index29].Value = Conversions.ToDouble(Operators.MultiplyObject(Program.ElDB[index30, index31], (object)Right1));
                                                Program.ElArr[index29].BaseValue = Conversions.ToDouble(Program.ElDB[index30, 6]);
                                                if (Program.ElArr[index29].Value != 0.0)
                                                    break;
                                                break;
                                            }
                                            checked { ++index30; }
                                        }
                                        if (index30 > Program.JumpMax)
                                            Program.ErrMessage(ind);
                                    }
                                    checked { ++index29; }
                                }
                                elType.Value = 0.0;
                                elType.BaseValue = 0.0;
                                elType.row = 0;
                                int num25 = checked(Eno - 1);
                                int index32 = 1;
                                while (index32 <= num25)
                                {
                                    num23 += Program.ElArr[index32].Value;
                                    if (Program.ElArr[index32].BaseValue > elType.BaseValue)
                                        elType = Program.ElArr[index32];
                                    checked { ++index32; }
                                }
                                int row = elType.row;
                                numArray1[ind] = num23;
                                if (C_JDA > 0)
                                {
                                    Program.JDarr[checked(R + ind + 8), 4] = Strings.Format((object)numArray1[ind], "0.00");
                                    if (Right1 > 1.0)
                                        Program.JDarr[checked(R + ind + 8), 5] = "x";
                                }
                                int noJGoe7 = Program.NoJ_GOE;
                                int index33 = 1;
                                while (index33 <= noJGoe7)
                                {
                                    string segment6 = Program.Segment;
                                    if (Operators.CompareString(segment6, "Seg1", false) == 0)
                                        Program.J_GOE[index33] = Program.Vek[Program.PNo].J_Seg1.EE[ind, index33];
                                    else if (Operators.CompareString(segment6, "Seg2", false) == 0)
                                        Program.J_GOE[index33] = Program.Vek[Program.PNo].J_Seg2.EE[ind, index33];
                                    checked { ++index33; }
                                }
                                if (Program.NoJ_GOE < Program.NoJudgeTMV)
                                {
                                    int noJGoe8 = Program.NoJ_GOE;
                                    int index34 = 1;
                                    while (index34 <= noJGoe8)
                                    {
                                        int index35 = checked(6 - Program.J_GOE[index34]);
                                        Right5 = index35 != 6 ? Conversions.ToDouble(Operators.AddObject(Program.ElDB[row, index35], (object)Right5)) : 0.0 + Right5;
                                        checked { ++index34; }
                                    }
                                    numArray2[ind] = Right5 / (double)Program.NoJ_GOE;
                                    if (C_JDA > 0)
                                        Program.JDarr[checked(R + ind + 8), 6] = Conversions.ToString(numArray2[ind]);
                                }
                                else
                                {
                                    Program.Sort_J_GOE(Program.NoJ_GOE);
                                    int num26 = checked(Program.NoJ_GOE - 1);
                                    int index36 = 2;
                                    while (index36 <= num26)
                                    {
                                        int index37 = checked(6 - Program.J_GOE[index36]);
                                        Right5 = index37 != 6 ? Conversions.ToDouble(Operators.AddObject(Program.ElDB[row, index37], (object)Right5)) : 0.0 + Right5;
                                        checked { ++index36; }
                                    }
                                    numArray2[ind] = Right5 / (double)checked(Program.NoJ_GOE - 2);
                                    if (C_JDA > 0)
                                        Program.JDarr[checked(R + ind + 8), 6] = Conversions.ToString(numArray2[ind]);
                                }
                            }
                            else if (Strings.InStr(1, str2, "+", CompareMethod.Text) == 0 & Strings.Len(str2) >= 1)
                            {
                                double Left3 = 0.0;
                                double Right6 = 0.0;
                                int index38 = 0;
                                string Left4 = str2;
                                int index39;
                                int num27;
                                if (str2.Contains("St"))
                                {
                                    index39 = Program.Stepmin;
                                    num27 = Program.Stepmax;
                                }
                                else if (str2.Contains("Ch"))
                                {
                                    index39 = Program.Stepmin;
                                    num27 = Program.Stepmax;
                                }
                                else
                                {
                                    index39 = Program.Jumpmin;
                                    num27 = Program.JumpMax;
                                }
                                if (Left4.Contains("*"))
                                {
                                    Left3 += 0.0;
                                    if (C_JDA > 0 & Right1 > 1.0)
                                        Program.JDarr[checked(R + ind + 8), 5] = "x";
                                }
                                else
                                {
                                    do
                                    {
                                        if (Operators.ConditionalCompareObjectNotEqual(Program.ElDB[index39, 0], (object)"", false) && Operators.ConditionalCompareObjectEqual((object)Left4, Program.ElDB[index39, 0], false))
                                        {
                                            index38 = index39;
                                            int num28 = index39;
                                            if (num28 >= Program.Jumpmin && num28 <= Program.JumpMax)
                                            {
                                                int index40 = 6;
                                                Left3 = Conversions.ToDouble(Operators.AddObject((object)Left3, Operators.MultiplyObject(Program.ElDB[index39, index40], (object)Right1)));
                                                if (C_JDA > 0 & Right1 > 1.0)
                                                    Program.JDarr[checked(R + ind + 8), 5] = "x";
                                            }
                                            else if (num28 >= Program.Stepmin && num28 <= Program.Stepmax)
                                                Left3 = Conversions.ToDouble(Operators.AddObject((object)Left3, Program.ElDB[index39, 6]));
                                        }
                                        checked { ++index39; }
                                    }
                                    while (!(index39 > num27 | index38 > 0));
                                    if (index39 > checked(num27 + 2))
                                        Program.ErrMessage(ind);
                                }
                                numArray1[ind] = Left3;
                                if (C_JDA > 0)
                                    Program.JDarr[checked(R + ind + 8), 4] = Strings.Format((object)numArray1[ind], "0.00");
                                int noJGoe9 = Program.NoJ_GOE;
                                int index41 = 1;
                                while (index41 <= noJGoe9)
                                {
                                    string segment7 = Program.Segment;
                                    if (Operators.CompareString(segment7, "Seg1", false) == 0)
                                        Program.J_GOE[index41] = Program.Vek[Program.PNo].J_Seg1.EE[ind, index41];
                                    else if (Operators.CompareString(segment7, "Seg2", false) == 0)
                                        Program.J_GOE[index41] = Program.Vek[Program.PNo].J_Seg2.EE[ind, index41];
                                    checked { ++index41; }
                                }
                                if (Program.NoJ_GOE < Program.NoJudgeTMV)
                                {
                                    int noJGoe10 = Program.NoJ_GOE;
                                    int index42 = 1;
                                    while (index42 <= noJGoe10)
                                    {
                                        int index43 = checked(6 - Program.J_GOE[index42]);
                                        Right6 = index43 != 6 ? (double.TryParse(Program.ElDB[index38, index43].ToString(), out double res) ? res : 0.0 + Right6) : 0.0 + Right6;
                                        checked { ++index42; }
                                    }
                                    if (Program.NoJ_GOE != 0)
                                    {
                                        numArray2[ind] = Right6 / (double)Program.NoJ_GOE;
                                        if (C_JDA > 0)
                                            Program.JDarr[checked(R + ind + 8), 6] = Conversions.ToString(numArray2[ind]);
                                    }
                                    else
                                        goto label_225;
                                }
                                else
                                {
                                    Program.Sort_J_GOE(Program.NoJ_GOE);
                                    int num29 = checked(Program.NoJ_GOE - 1);
                                    int index44 = 2;
                                    while (index44 <= num29)
                                    {
                                        int index45 = checked(6 - Program.J_GOE[index44]);
                                        Right6 = index45 != 6 ? Conversions.ToDouble(Operators.AddObject(Program.ElDB[index38, index45], (object)Right6)) : 0.0 + Right6;
                                        checked { ++index44; }
                                    }
                                    numArray2[ind] = Right6 / (double)checked(Program.NoJ_GOE - 2);
                                    if (C_JDA > 0)
                                        Program.JDarr[checked(R + ind + 8), 6] = Conversions.ToString(numArray2[ind]);
                                }
                            }
                        }
                        numArray1[ind] = Conversion.Int(100.0 * numArray1[ind] + 0.5000001) / 100.0;
                        numArray2[ind] = numArray2[ind] <= 0.0 ? -Conversion.Int(-100.0 * numArray2[ind] + 0.5000001) / 100.0 : Conversion.Int(100.0 * numArray2[ind] + 0.5000001) / 100.0;
                        if (C_JDA > 0)
                            Program.JDarr[checked(R + ind + 8), 6] = Strings.Format((object)numArray2[ind], "0.00");
                        numArray3[ind] = numArray1[ind] + numArray2[ind];
                        numArray3[ind] = Conversion.Int(100.0 * numArray3[ind] + 0.5000001) / 100.0;
                        if (C_JDA > 0)
                            Program.JDarr[checked(R + ind + 8), 14] = Strings.Format((object)numArray3[ind], "0.00");
                        num6 += numArray3[ind];
                        checked { ++ind; }
                    }
                    num2 = Conversion.Int(100.0 * num6 + 0.5000001) / 100.0;
                    goto label_225;
                }
                else
                    goto label_225;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num3 = -1;
            if (num1 == 2)
            {
                int num30 = (int)Interaction.MsgBox((object)("A_Calc_BV_GOE - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_225:
            double num31 = num2;
            if (num3 == 0)
                return num31;
            ProjectData.ClearProjectError();
            return num31;
        }

        public static string GetSpin(string El)
        {
            string spin = El;
            if (Operators.CompareString(Strings.Right(El, 1), "V", false) == 0)
                spin = Strings.Trim(El.Remove(checked(El.Length - 1)));
            return spin;
        }

        public static void Sort_J_GOE(int NoJ)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = checked(NoJ - 1);
                int index1 = 1;
                while (index1 <= num3)
                {
                    int num4 = Program.J_GOE[index1];
                    int index2 = index1;
                    int num5 = checked(index1 + 1);
                    int num6 = NoJ;
                    int index3 = num5;
                    while (index3 <= num6)
                    {
                        if (Program.J_GOE[index3] < num4)
                        {
                            num4 = Program.J_GOE[index3];
                            index2 = index3;
                        }
                        checked { ++index3; }
                    }
                    Program.J_GOE[index2] = Program.J_GOE[index1];
                    Program.J_GOE[index1] = num4;
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

        public static void Sort_J_PC(int NoJ)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = checked(NoJ - 1);
                int index1 = 1;
                while (index1 <= num3)
                {
                    double num4 = Program.J_PC[index1];
                    int index2 = index1;
                    int num5 = checked(index1 + 1);
                    int num6 = NoJ;
                    int index3 = num5;
                    while (index3 <= num6)
                    {
                        if (Program.J_PC[index3] < num4)
                        {
                            num4 = Program.J_PC[index3];
                            index2 = index3;
                        }
                        checked { ++index3; }
                    }
                    Program.J_PC[index2] = Program.J_PC[index1];
                    Program.J_PC[index1] = num4;
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

        public static void ErrMessage(int ind)
        {
            Program.ElErrorArr[ind] = 1;
            int num = (int)Interaction.MsgBox((object)("Element no. " + Conversions.ToString(ind) + " is not correct!\r\nThe element is marked red in Judges Details!"), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
        }

        public static void FindJumpEl1(string StringEl, ref int Eno)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Program.ElArr = (Program.El_type[])null;
                Program.ElArr = new Program.El_type[31];
                Eno = 1;
                string[] strArray = StringEl.Split('+');
                int length = strArray.Length;
                int index = 1;
                while (index <= length)
                {
                    Program.ElArr[index].Elstr = strArray[checked(index - 1)];
                    checked { ++index; }
                }
                Eno = checked(strArray.Length + 1);
                goto label_10;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("FindJumpEl1 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_10:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static int A_CalcNoOfEl()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                num2 = 0;
                int index = 1;
                do
                {
                    string Left = "";
                    string segment = Program.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        if (Operators.CompareString(Program.Vek[Program.PNo].SSS_Seg1[index], "", false) != 0)
                            Left = Program.Vek[Program.PNo].SSS_Seg1[index];
                    }
                    else if (Operators.CompareString(segment, "Seg2", false) == 0 && Operators.CompareString(Program.Vek[Program.PNo].SSS_Seg2[index], "", false) != 0)
                        Left = Program.Vek[Program.PNo].SSS_Seg2[index];
                    if (Operators.CompareString(Left, "", false) != 0)
                        num2 = index;
                    checked { ++index; }
                }
                while (index <= 15);
                goto label_14;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num3 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("A_CalcNoOfEl - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_14:
            int num5 = num2;
            if (num3 == 0)
                return num5;
            ProjectData.ClearProjectError();
            return num5;
        }

        public static double A_CalcPC(int dum, int R, int C_JDA)
        {
            int num1 = 0;
            double num2 = 0.0;
            int num3 = 0;
            try
            {
                double[] numArray = new double[6];
                ProjectData.ClearProjectError();
                num1 = 2;
                num2 = 0.0;
                if (Program.NoJ_GOE != 0)
                {
                    double num4 = 0.0;
                    int nr = 1;
                    do
                    {
                        if (Program.PC_Factor(nr) > 0.0)
                        {
                            double num5 = 0.0;
                            int noJGoe1 = Program.NoJ_GOE;
                            int index1 = 1;
                            while (index1 <= noJGoe1)
                            {
                                string segment = Program.Segment;
                                if (Operators.CompareString(segment, "Seg1", false) == 0)
                                    Program.J_PC[index1] = Program.Vek[Program.PNo].J_Seg1.PC[nr, index1];
                                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                                    Program.J_PC[index1] = Program.Vek[Program.PNo].J_Seg2.PC[nr, index1];
                                checked { ++index1; }
                            }
                            if (Program.NoJ_GOE < Program.NoJudgeTMV)
                            {
                                int noJGoe2 = Program.NoJ_GOE;
                                int index2 = 1;
                                while (index2 <= noJGoe2)
                                {
                                    num5 += Program.J_PC[index2];
                                    checked { ++index2; }
                                }
                                numArray[nr] = num5 / (double)Program.NoJ_GOE;
                            }
                            else
                            {
                                Program.Sort_J_PC(Program.NoJ_GOE);
                                int num6 = checked(Program.NoJ_GOE - 1);
                                int index3 = 2;
                                while (index3 <= num6)
                                {
                                    num5 += Program.J_PC[index3];
                                    checked { ++index3; }
                                }
                                numArray[nr] = num5 / (double)checked(Program.NoJ_GOE - 2);
                            }
                            numArray[nr] = Conversion.Int(100.0 * numArray[nr] + 0.5000001) / 100.0;
                            num4 += Conversion.Int(numArray[nr] * 100.0 * Program.PC_Factor(nr) + 0.5000001) / 100.0;
                            if (C_JDA > 0)
                                Program.JDarr[checked(R + nr), 14] = Strings.Format((object)numArray[nr], "0.00");
                        }
                        checked { ++nr; }
                    }
                    while (nr <= Constants.TOTAL_COMPONENTS_COUNT);
                    double Expression = Conversion.Int(1000.0 * num4 + 0.5000001) / 1000.0;
                    if (C_JDA > 0)
                        Program.JDarr[checked(R + 6), 14] = Strings.Format((object)Expression, "0.00");
                    string segment1 = Program.Segment;
                    if (Operators.CompareString(segment1, "Seg1", false) == 0)
                        Program.Vek[Program.PNo].Finished_Seg1 = Expression <= 0.0 ? 0 : 1;
                    else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                        Program.Vek[Program.PNo].Finished_Seg2 = Expression <= 0.0 ? 0 : 1;
                    num2 = Expression;
                    goto label_34;
                }
                else
                    goto label_34;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num3 = -1;
            if (num1 == 2)
            {
                int num7 = (int)Interaction.MsgBox((object)("A_CalcPC - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_34:
            double num8 = num2;
            if (num3 == 0)
                return num8;
            ProjectData.ClearProjectError();
            return num8;
        }

        public static double PC_Factor(int nr)
        {
            int num1 = 0;
            double num2 = 0.0;
            int num3 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                string segment = Program.Segment;
                num2 = Operators.CompareString(segment, "Seg1", false) != 0 ? (Operators.CompareString(segment, "Seg2", false) != 0 ? 0.0 : Program.OpenDB[Program.PcIndex].PCFactorsSeg2[nr]) : Program.OpenDB[Program.PcIndex].PCFactorsSeg1[nr];
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            double num4 = num2;
            if (num3 == 0)
                return num4;
            ProjectData.ClearProjectError();
            return num4;
        }

        public static double A_Calc_Bonus()
        {
            double num = 0.0;
            string segment = Program.Segment;
            if (Operators.CompareString(segment, "Seg1", false) == 0)
                num = Program.Vek[Program.PNo].Bonus_Seg1 <= 0 ? 0.0 : (double)Program.Vek[Program.PNo].Bonus_Seg1;
            else if (Operators.CompareString(segment, "Seg2", false) == 0)
                num = Program.Vek[Program.PNo].Bonus_Seg2 <= 0 ? 0.0 : (double)Program.Vek[Program.PNo].Bonus_Seg2;
            return num;
        }

        public static void B_Init_SheetText(int R)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Program.JDarr[checked(R + 1), 2] = Program.Competition.Name;
                Program.JDarr[checked(R + 2), 2] = Strings.UCase(Program.Category.Name) + Program.SubCat();
                Program.JDarr[checked(R + 3), 2] = Strings.UCase(Program.GetProgType(Program.Segment)) + " PROGRAM";
                int num3 = 4;
                Program.JDarr[checked(R + num3), 1] = "Pl.";
                Program.JDarr[checked(R + num3), 2] = "NAME";
                Program.JDarr[checked(R + num3), 4] = "START No.";
                Program.JDarr[checked(R + num3), 8] = "TOTAL";
                Program.JDarr[checked(R + num3), 10] = "TOTAL";
                Program.JDarr[checked(R + num3), 11] = "TOTAL";
                string segment1 = Program.Segment;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    if (Program.Vek[Program.PNo].Bonus_Seg1 > 0)
                        Program.JDarr[checked(R + num3), 12] = "BONUS";
                }
                else if (Operators.CompareString(segment1, "Seg2", false) == 0 && Program.Vek[Program.PNo].Bonus_Seg2 > 0)
                    Program.JDarr[checked(R + num3), 12] = "BONUS";
                Program.JDarr[checked(R + num3), 14] = "DEDUCTION";
                int num4 = 5;
                string segment2 = Program.Segment;
                if (Operators.CompareString(segment2, "Seg1", false) == 0)
                {
                    Program.JDarr[checked(R + num4), 1] = Conversions.ToString(Program.Vek[Program.PNo].Place_Seg1);
                    Program.JDarr[checked(R + num4), 4] = Conversions.ToString(Program.Vek[Program.PNo].Startno_Seg1);
                }
                else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                {
                    Program.JDarr[checked(R + num4), 1] = Conversions.ToString(Program.Vek[Program.PNo].Place_Seg2);
                    Program.JDarr[checked(R + num4), 4] = Conversions.ToString(Program.Vek[Program.PNo].Startno_Seg2);
                }
                Program.JDarr[checked(R + num4), 2] = Program.Vek[Program.PNo].Name.FName + " " + Program.Vek[Program.PNo].Name.LName;
                Program.JDarr[checked(R + num4), 8] = "Segments";
                Program.JDarr[checked(R + num4), 10] = "Elements";
                Program.JDarr[checked(R + num4), 11] = "PC";
                int num5 = 6;
                Program.JDarr[checked(R + num5), 2] = Program.Vek[Program.PNo].Club;
                Program.JDarr[checked(R + num5), 8] = "Score";
                Program.JDarr[checked(R + num5), 10] = "Score";
                Program.JDarr[checked(R + num5), 11] = "Score";
                int num6 = 7;
                Program.JDarr[checked(R + num6), 9] = "=";
                int num7 = 8;
                Program.JDarr[checked(R + num7), 1] = "#";
                Program.JDarr[checked(R + num7), 2] = "EXECUTED ELEMENTS";
                Program.JDarr[checked(R + num7), 4] = "BASE VALUE";
                Program.JDarr[checked(R + num7), 6] = "GOE";
                int noJGoe = Program.NoJ_GOE;
                int Number1 = 1;
                while (Number1 <= noJGoe)
                {
                    Program.JDarr[checked(R + num7), checked(6 + Number1)] = "J" + Strings.Right(Conversion.Str((object)Number1), 1);
                    checked { ++Number1; }
                }
                if (Program.NoJ_GOE <= 6 & Program.WOR == 0 && Program.JudgeSel > 0)
                    Program.JDarr[checked(R + num7), 13] = "Ref";
                if (Program.NoTrj > 0 & Program.WOR == 0)
                {
                    int num8 = checked(Program.NoJ_GOE + 1);
                    int num9 = checked(Program.NoJ_GOE + Program.NoTrj);
                    int Number2 = num8;
                    while (Number2 <= num9)
                    {
                        Program.JDarr[checked(R + num7), checked(6 + Number2)] = "Tr. J" + Strings.Trim(Conversion.Str((object)Number2));
                        checked { ++Number2; }
                    }
                }
                Program.JDarr[checked(R + num7), 14] = "SCORES";
                goto label_25;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num10 = (int)Interaction.MsgBox((object)("B_Init_SheetText - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_25:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static string GetCat() => Strings.Len(Program.SubCategory) == 0 ? Program.Category.Name : Program.Category.Name + ", " + Program.SubCategory;

        public static string SubCat() => Operators.CompareString(Strings.Trim(Program.SubCategory), "", false) == 0 ? "" : ", " + Program.SubCategory;

        public static string SubCat_() => Operators.CompareString(Strings.Trim(Program.SubCategory), "", false) == 0 ? "" : "_" + Program.SubCategory;

        public static int B_SSS_data(int R)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                num2 = 0;
                if (Program.PNo > 0)
                {
                    int num4 = 10;
                    int index = 1;
                    do
                    {
                        string str = "";
                        string segment = Program.Segment;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                        {
                            if (Operators.CompareString(Program.Vek[Program.PNo].SSS_Seg1[index], "", false) != 0)
                            {
                                Program.JDarr[checked(R + index + 8), 1] = Conversions.ToString(index);
                                str = Program.Vek[Program.PNo].SSS_Seg1[index];
                            }
                        }
                        else if (Operators.CompareString(segment, "Seg2", false) == 0 && Operators.CompareString(Program.Vek[Program.PNo].SSS_Seg2[index], "", false) != 0)
                        {
                            Program.JDarr[checked(R + index + 8), 1] = Conversions.ToString(index);
                            str = Program.Vek[Program.PNo].SSS_Seg2[index];
                        }

                        string edgesSignsColumn = "";// Program.JDarr[checked(R + index + 8), 3];
                        //TODO: character combinations to add in excel sheet
                        if (str.Contains("*"))
                            edgesSignsColumn = "*";
                        else if (str.Contains("V"))
                            edgesSignsColumn = "V";
                        else if (str.Contains("<< e"))
                            edgesSignsColumn = "<<e";
                        else if (str.Contains("< e"))
                            edgesSignsColumn = "<e";
                        else if (str.Contains(" e"))
                            edgesSignsColumn = "e";
                        else if (str.Contains("<< !"))
                            edgesSignsColumn = "<<!";
                        else if (str.Contains("<<f"))
                            edgesSignsColumn = "<<f";
                        else if (str.Contains("< !"))
                            edgesSignsColumn = "<!";
                        else if (str.Contains("<f"))
                            edgesSignsColumn = "<f";
                        else if (str.Contains(" !"))
                            edgesSignsColumn = "!";
                        else if (str.Contains(" q"))
                            edgesSignsColumn = "q";
                        else if (str.Contains("f"))
                            edgesSignsColumn = "f";
                        else if (str.Contains("<<"))
                            edgesSignsColumn = "<<";
                        else if (str.Contains("<"))
                            edgesSignsColumn = "<";
                        
                        string tempSigns = edgesSignsColumn;
                        if (!string.IsNullOrWhiteSpace(Program.OpArr[index].edge))
                        {
                            if (!string.IsNullOrWhiteSpace(edgesSignsColumn))
                            {
                                foreach (char ch in edgesSignsColumn)
                                {
                                    if (Program.OpArr[index].edge.Contains(ch))
                                    {
                                        tempSigns = tempSigns.Replace(ch.ToString(), Program.OpArr[index].edge);
                                    }
                                }
                            }
                            else
                            {
                                tempSigns = Program.OpArr[index].edge;
                            }
                        }

                        Program.JDarr[checked(R + index + 8), 3] = tempSigns;
                        
                        if (!string.IsNullOrWhiteSpace(str))
                        {
                            Program.JDarr[checked(R + index + 8), 2] = str;
                            num4 = checked(index + 8);
                        }
                        checked { ++index; }
                    }
                    while (index <= 15);
                    num2 = num4;
                    goto label_38;
                }
                else
                    goto label_38;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num3 = -1;
            if (num1 == 2)
            {
                int num6 = (int)Interaction.MsgBox((object)("B_SSS_data - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_38:
            int num7 = num2;
            if (num3 == 0)
                return num7;
            ProjectData.ClearProjectError();
            return num7;
        }

        public static void B_Show_GOEdata(int R, int row)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int num3 = !(Program.NoTrj > 0 & Program.WOR == 1) ? checked(Program.NoJ_GOE + Program.NoTrj) : Program.NoJ_GOE;
                int num4 = row;
                int num5 = 9;
                while (num5 <= num4)
                {
                    int num6 = num3;
                    int index = 1;
                    while (index <= num6)
                    {
                        string segment = Program.Segment;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                            Program.JDarr[checked(R + num5), checked(6 + index)] = Conversions.ToDouble(Program.JDarr[checked(R + num5), 4]) <= 0.0 ? "--" : Conversions.ToString(Program.Vek[Program.PNo].J_Seg1.EE[checked(num5 - 9 + 1), index]);
                        else if (Operators.CompareString(segment, "Seg2", false) == 0)
                            Program.JDarr[checked(R + num5), checked(6 + index)] = Conversions.ToDouble(Program.JDarr[checked(R + num5), 4]) <= 0.0 ? "--" : Conversions.ToString(Program.Vek[Program.PNo].J_Seg2.EE[checked(num5 - 9 + 1), index]);
                        checked { ++index; }
                    }
                    checked { ++num5; }
                }
                if (Program.NoJ_GOE <= 6 & Program.JudgeSel != 0 & Program.WOR == 0)
                {
                    int num7 = row;
                    int num8 = 9;
                    while (num8 <= num7)
                    {
                        string segment = Program.Segment;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                            Program.JDarr[checked(R + num8), 13] = Conversions.ToDouble(Program.JDarr[checked(R + num8), 4]) <= 0.0 ? "--" : Conversions.ToString(Program.Vek[Program.PNo].J_Seg1.EE[checked(num8 - 9 + 1), 7]);
                        else if (Operators.CompareString(segment, "Seg2", false) == 0)
                            Program.JDarr[checked(R + num8), 13] = Conversions.ToDouble(Program.JDarr[checked(R + num8), 4]) <= 0.0 ? "--" : Conversions.ToString(Program.Vek[Program.PNo].J_Seg2.EE[checked(num8 - 9 + 1), 7]);
                        checked { ++num8; }
                    }
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
                int num9 = (int)Interaction.MsgBox((object)("B_Show_GOEdata - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_24:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void B_Show_PCfactors(int R, int row)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                Program.JDarr[checked(R + row + 1), 2] = "PROGRAM COMPONENTS";
                Program.JDarr[checked(R + row + 1), 4] = "FACTOR";
                int noJGoe = Program.NoJ_GOE;
                int Number1 = 1;
                while (Number1 <= noJGoe)
                {
                    Program.JDarr[checked(R + row + 1), checked(6 + Number1)] = "J" + Strings.Right(Conversion.Str((object)Number1), 1);
                    checked { ++Number1; }
                }
                if (Program.NoTrj > 0 & Program.WOR == 0)
                {
                    int num3 = checked(Program.NoJ_GOE + 1);
                    int num4 = checked(Program.NoJ_GOE + Program.NoTrj);
                    int Number2 = num3;
                    while (Number2 <= num4)
                    {
                        Program.JDarr[checked(R + row + 1), checked(6 + Number2)] = "Tr. J" + Strings.Trim(Conversion.Str((object)Number2));
                        checked { ++Number2; }
                    }
                }
                //TODO: show only 3 components
                if (Program.NoJ_GOE <= 6 & Program.WOR == 0 && Program.JudgeSel > 0)
                    Program.JDarr[checked(R + row + 1), 13] = "Ref";
                Program.JDarr[checked(R + row + 2), 2] = "Skating Skills";
                Program.JDarr[checked(R + row + 2), 4] = Conversions.ToString(Program.PC_Factor(1));
                Program.JDarr[checked(R + row + 3), 2] = "Composition";
                Program.JDarr[checked(R + row + 3), 4] = Conversions.ToString(Program.PC_Factor(2));
                Program.JDarr[checked(R + row + 4), 2] = "Presentation";///Execution";
                Program.JDarr[checked(R + row + 4), 4] = Conversions.ToString(Program.PC_Factor(3));
                //Program.JDarr[checked(R + row + 5), 2] = "Composition";
                //Program.JDarr[checked(R + row + 5), 4] = Conversions.ToString(Program.PC_Factor(4));
                //Program.JDarr[checked(R + row + 6), 2] = "Interpretation";
                //Program.JDarr[checked(R + row + 6), 4] = Conversions.ToString(Program.PC_Factor(5));
                goto label_16;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("B_Show_PCfactors - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_16:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void B_Show_PCdata(int R, int row)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int num3 = !(Program.NoTrj > 0 & Program.WOR == 1) ? checked(Program.NoJ_GOE + Program.NoTrj) : Program.NoJ_GOE;
                int num4 = row;
                int num5 = checked(row + 4);
                int num6 = num4;
                while (num6 <= num5)
                {
                    int num7 = num3;
                    int index = 1;
                    while (index <= num7)
                    {
                        string segment = Program.Segment;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                        {
                            if (Conversions.ToInteger(Program.JDarr[checked(R + num6), 4]) > 0)
                                Program.JDarr[checked(R + num6), checked(6 + index)] = Strings.Format((object)Program.Vek[Program.PNo].J_Seg1.PC[checked(num6 - row + 1), index], "0.00");
                        }
                        else if (Operators.CompareString(segment, "Seg2", false) == 0 && Conversions.ToInteger(Program.JDarr[checked(R + num6), 4]) > 0)
                            Program.JDarr[checked(R + num6), checked(6 + index)] = Strings.Format((object)Program.Vek[Program.PNo].J_Seg2.PC[checked(num6 - row + 1), index], "0.00");
                        checked { ++index; }
                    }
                    checked { ++num6; }
                }
                if (Program.NoJ_GOE <= 6 & Program.JudgeSel != 0 & Program.WOR == 0)
                {
                    int num8 = row;
                    int num9 = checked(row + 4);
                    int num10 = num8;
                    while (num10 <= num9)
                    {
                        string segment = Program.Segment;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                        {
                            if (Conversions.ToInteger(Program.JDarr[checked(R + num10), 4]) > 0)
                                Program.JDarr[checked(R + num10), 13] = Strings.Format((object)Program.Vek[Program.PNo].J_Seg1.PC[checked(num10 - row + 1), 7], "0.00");
                        }
                        else if (Operators.CompareString(segment, "Seg2", false) == 0 && Conversions.ToInteger(Program.JDarr[checked(R + num10), 4]) > 0)
                            Program.JDarr[checked(R + num10), 13] = Strings.Format((object)Program.Vek[Program.PNo].J_Seg2.PC[checked(num10 - row + 1), 7], "0.00");
                        checked { ++num10; }
                    }
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
                int num11 = (int)Interaction.MsgBox((object)("B_Show_PCdata - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_26:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void B_Calc_BaseSum(int R, int row)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                double Expression1 = 0.0;
                double Expression2 = 0.0;
                int num3 = checked(R + 9);
                int num4 = checked(R + row);
                int index = num3;
                while (index <= num4)
                {
                    Expression1 += Conversions.ToDouble(Program.JDarr[index, 4]);
                    Expression2 += Conversions.ToDouble(Program.JDarr[index, 14]);
                    checked { ++index; }
                }
                Program.JDarr[checked(R + row + 1), 4] = Strings.Format((object)Expression1, "0.00");
                Program.JDarr[checked(R + row + 1), 14] = Strings.Format((object)Expression2, "0.00");
                goto label_10;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num5 = (int)Interaction.MsgBox((object)("B_Calc_BaseSum - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_10:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void B_Show_Bonus(int R)
        {
            string segment = Program.Segment;
            if (Operators.CompareString(segment, "Seg1", false) == 0)
            {
                if (Program.Vek[Program.PNo].Bonus_Seg1 <= 0)
                    return;
                Program.JDarr[checked(R + 7), 12] = Conversions.ToString(Program.Vek[Program.PNo].Bonus_Seg1);
            }
            else
            {
                if (Operators.CompareString(segment, "Seg2", false) != 0 || Program.Vek[Program.PNo].Bonus_Seg2 <= 0)
                    return;
                Program.JDarr[checked(R + 7), 12] = Conversions.ToString(Program.Vek[Program.PNo].Bonus_Seg2);
            }
        }

        public static void B_Show_Deductions(int R, int row, ref int rowDGW)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int[] myarr = new int[11];
                ProjectData.ClearProjectError();
                num1 = 2;
                string str1 = "";
                string str2 = "";
                Program.JDarr[checked(R + row), 2] = "DEDUCTIONS";
                if (Program.ShowJudgeDed == 1)
                {
                    int index = 1;
                    do
                    {
                        string segment = Program.Segment;
                        long num3 = 0;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                            num3 = Program.Vek[Program.PNo].J_Seg1.Deduction[index];
                        else if (Operators.CompareString(segment, "Seg2", false) == 0)
                            num3 = Program.Vek[Program.PNo].J_Seg2.Deduction[index];
                        if (index <= checked(Program.NoJ_GOE + Program.NoTrj) | index == 7 & Program.NoJ_GOE <= 6 & Program.JudgeSel != 0)
                        {
                            string str;
                            switch (num3 - 1L)
                            {
                                case 0:
                                    str = "C";
                                    break;
                                case 1:
                                    str = "P";
                                    break;
                                case 2:
                                    str = "CP";
                                    break;
                                case 3:
                                    str = "M";
                                    break;
                                case 4:
                                    str = "CM";
                                    break;
                                case 5:
                                    str = "PM";
                                    break;
                                case 6:
                                    str = "CPM";
                                    break;
                                default:
                                    str = "";
                                    break;
                            }
                            Program.JDarr[checked(R + row), checked(6 + index)] = str;
                        }
                        checked { ++index; }
                    }
                    while (index <= 7);
                }
                rowDGW = checked(R + row + 1);
                long d1 = Program.MV_Ded(Program.PNo, 1, Program.Segment);
                if (d1 > 0L)
                    Program.MakeString("Costume Violation: ", checked((int)d1), ref str1, ref str2);
                long d2 = Program.MV_Ded(Program.PNo, 2, Program.Segment);
                if (d2 > 0L)
                    Program.MakeString("Props: ", checked((int)d2), ref str1, ref str2);
                long d3 = Program.MV_Ded(Program.PNo, 3, Program.Segment);
                if (d3 > 0L)
                    Program.MakeString("Music Violation: ", checked((int)d3), ref str1, ref str2);
                string segment1 = Program.Segment;
                long DedLong;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    if (Program.Vek[Program.PNo].Falls_seg1 > 0)
                        Program.MakeString("Fall: ", Program.Vek[Program.PNo].Falls_seg1, ref str1, ref str2);
                    DedLong = Conversion.Int(Program.Vek[Program.PNo].Deductions_Seg1);
                }
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                {
                    if (Program.Vek[Program.PNo].Falls_seg2 > 0)
                        Program.MakeString("Fall: ", Program.Vek[Program.PNo].Falls_seg2, ref str1, ref str2);
                    DedLong = Conversion.Int(Program.Vek[Program.PNo].Deductions_Seg2);
                }
                else
                    DedLong = 0L;
                Program.GetArr(ref myarr, DedLong);
                if (myarr[1] > 0)
                    Program.MakeString("Time Violation: ", myarr[1], ref str1, ref str2);
                if (myarr[2] > 0)
                    Program.MakeString("Late start: ", myarr[2], ref str1, ref str2);
                if (myarr[3] > 0)
                    Program.MakeString("Illegal Elements: ", myarr[3], ref str1, ref str2);
                if (myarr[4] > 0)
                    Program.MakeString("Interrupts: ", myarr[4], ref str1, ref str2);
                if (myarr[5] > 0)
                    Program.MakeString("Costume failure: ", myarr[5], ref str1, ref str2);
                if (myarr[6] > 0)
                    Program.MakeString("Missing Elements: ", myarr[6], ref str1, ref str2);
                Program.JDarr[checked(R + row + 1), 2] = str1;
                rowDGW = checked(R + row + 1);
                goto label_52;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("B_Show_Deductions - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_52:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void GetArr(ref int[] myarr, long DedLong)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int index = 0;
                do
                {
                    myarr[index] = 0;
                    checked { ++index; }
                }
                while (index <= 10);
                string Expression = Conversions.ToString(DedLong);
                int num3 = Strings.Len(Expression);
                int startIndex = checked(num3 - 1);
                while (startIndex >= 0)
                {
                    myarr[checked(num3 - startIndex)] = Conversions.ToInteger(Expression.Substring(startIndex, 1));
                    checked { startIndex += -1; }
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
                int num4 = (int)Interaction.MsgBox((object)("GetArr - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_11:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void MakeString(string NewStr, int d, ref string str1, ref string str2)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 3;
                if (Strings.Len(str1) == 0)
                {
                    num3 = 4;
                    str1 = NewStr + Conversions.ToString(d) + "        ";
                }
                else
                {
                    num3 = 7;
                    if (Strings.Len(str1) < 200)
                    {
                        num3 = 8;
                        str1 = str1 + NewStr + Conversions.ToString(d) + "        ";
                    }
                    else
                    {
                        num3 = 11;
                        if (Strings.Len(str1) > 200 & Strings.Len(str2) == 0)
                        {
                            num3 = 12;
                            str2 = NewStr + Conversions.ToString(d) + "        ";
                        }
                        else
                        {
                            num3 = 15;
                            if (Strings.Len(str2) > 0)
                            {
                                num3 = 16;
                                str2 = str2 + NewStr + Conversions.ToString(d) + "        ";
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

        public static long MV_Ded(int Pno, int Dno, string Prog)
        {
            int num1 = 0;
            long num2 = 0;
            int num3 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                num2 = 0L;
                int num4 = 0;
                int num5 = 0;
                int noJGoe = Program.NoJ_GOE;
                int Jno = 1;
                while (Jno <= noJGoe)
                {
                    checked { num4 += Program.JDED(Pno, Jno, Dno, Prog); }
                    checked { ++num5; }
                    checked { ++Jno; }
                }
                if (Program.JudgeSel == 1)
                {
                    checked { num4 += Program.JDED(Pno, 7, Dno, Prog); }
                    checked { ++num5; }
                }
                if ((double)num4 > (double)num5 / 2.0)
                {
                    num2 = 1L;
                    goto label_12;
                }
                else
                    goto label_12;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num3 = -1;
            if (num1 == 2)
            {
                int num6 = (int)Interaction.MsgBox((object)("MV_Ded - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_12:
            long num7 = num2;
            if (num3 == 0)
                return num7;
            ProjectData.ClearProjectError();
            return num7;
        }

        public static int JDED(int Pno, int Jno, int Dno, string Prog)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                string Left = Prog;
                long num4 = Operators.CompareString(Left, "Seg1", false) != 0 ? (Operators.CompareString(Left, "Seg2", false) != 0 ? 0L : Program.Vek[Pno].J_Seg2.Deduction[Jno]) : Program.Vek[Pno].J_Seg1.Deduction[Jno];
                num2 = 0;
                switch (Dno)
                {
                    case 1:
                        if (checked((long)Math.Round(unchecked((double)num4 - Conversion.Int((double)num4 / 2.0) * 2.0))) > 0L)
                        {
                            num2 = 1;
                            goto label_12;
                        }
                        else
                            goto label_12;
                    case 2:
                        long num5 = checked((long)Math.Round(Conversion.Int(unchecked((double)num4 / 2.0))));
                        if (checked((long)Math.Round(unchecked((double)num5 - Conversion.Int((double)num5 / 2.0) * 2.0))) > 0L)
                        {
                            num2 = 1;
                            goto label_12;
                        }
                        else
                            goto label_12;
                    case 3:
                        long num6 = checked((long)Math.Round(Conversion.Int(unchecked((double)num4 / 4.0))));
                        if (checked((long)Math.Round(unchecked((double)num6 - Conversion.Int((double)num6 / 2.0) * 2.0))) > 0L)
                        {
                            num2 = 1;
                            goto label_12;
                        }
                        else
                            goto label_12;
                    default:
                        goto label_12;
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num3 = -1;
            if (num1 == 2)
            {
                int num7 = (int)Interaction.MsgBox((object)("JDED - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_12:
            int num8 = num2;
            if (num3 == 0)
                return num8;
            ProjectData.ClearProjectError();
            return num8;
        }

        public static void B_Show_Scores(int R)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                string segment = Program.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    if (Program.Vek[Program.PNo].Finished_Seg1 == 1)
                    {
                        Program.JDarr[checked(R + 7), 8] = Strings.Format((object)Program.Vek[Program.PNo].Score_Seg1, "0.00");
                        Program.JDarr[checked(R + 7), 10] = Strings.Format((object)Program.Vek[Program.PNo].TES_Seg1, "0.00");
                        Program.JDarr[checked(R + 7), 11] = Strings.Format((object)Program.Vek[Program.PNo].PCS_Seg1, "0.00");
                        Program.JDarr[checked(R + 7), 14] = Strings.Format((object)Program.DedSeg1Seg2(Program.PNo, Program.Segment));
                        goto label_12;
                    }
                    else
                        goto label_12;
                }
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                {
                    if (Program.Vek[Program.PNo].Finished_Seg2 == 1)
                    {
                        Program.JDarr[checked(R + 7), 8] = Strings.Format((object)Program.Vek[Program.PNo].Score_Seg2, "0.00");
                        Program.JDarr[checked(R + 7), 10] = Strings.Format((object)Program.Vek[Program.PNo].TES_Seg2, "0.00");
                        Program.JDarr[checked(R + 7), 11] = Strings.Format((object)Program.Vek[Program.PNo].PCS_Seg2, "0.00");
                        Program.JDarr[checked(R + 7), 14] = Strings.Format((object)Program.DedSeg1Seg2(Program.PNo, Program.Segment));
                        goto label_12;
                    }
                    else
                        goto label_12;
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
                int num3 = (int)Interaction.MsgBox((object)("B_Show_Scores - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_12:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static double DedSeg1Seg2(int Pno, string Prog)
        {
            int num1 = 0;
            double num2 = 0.0;
            int num3 = 0;
            try
            {
                int num4 = 0;
                int[] myarr = new int[11];
                ProjectData.ClearProjectError();
                num1 = 2;
                double num5 = Program.Init_DedFall();
                double num6 = Program.Init_DedInter();
                double num7 = 0.0 + (double)Program.MV_Ded(Pno, 1, Prog) + (double)Program.MV_Ded(Pno, 2, Prog) + (double)Program.MV_Ded(Pno, 3, Prog);
                string Left = Prog;
                long DedLong = 0;
                if (Operators.CompareString(Left, "Seg1", false) == 0)
                {
                    DedLong = Program.Vek[Pno].Deductions_Seg1;
                    num4 = Program.Vek[Pno].Falls_seg1;
                }
                else if (Operators.CompareString(Left, "Seg2", false) == 0)
                {
                    DedLong = Program.Vek[Pno].Deductions_Seg2;
                    num4 = Program.Vek[Pno].Falls_seg2;
                }
                Program.GetArr(ref myarr, DedLong);
                double num8 = (double)myarr[1];
                double num9 = num7 + num8 + (double)myarr[2];
                double num10 = (!Strings.UCase(Program.Category.Name).Contains("ARTISTISK") ? num9 + (double)checked(myarr[3] * 2) : num9 + (double)myarr[3]) + (double)myarr[4] * num6 + (double)myarr[5] + (double)myarr[6];
                if (Strings.UCase(Program.Category.Name).Contains("SENIOR A") | Strings.UCase(Program.Category.Name).Contains("SENIORER A"))
                {
                    switch (num4)
                    {
                        case 1:
                        case 2:
                            num10 += (double)num4 * num5;
                            break;
                        case 3:
                        case 4:
                            num10 = num10 + 2.0 * num5 + (double)checked(num4 - 4) * num5;
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                            num10 = num10 + 2.0 * num5 + 4.0 * num5 + (double)checked(num4 - 12) * num5;
                            break;
                    }
                }
                else
                    num10 += (double)num4 * num5;
                num2 = num10;
                goto label_16;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num3 = -1;
            if (num1 == 2)
            {
                int num11 = (int)Interaction.MsgBox((object)("DedSeg1Seg2 - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_16:
            double num12 = num2;
            if (num3 == 0)
                return num12;
            ProjectData.ClearProjectError();
            return num12;
        }

        public static double Init_DedFall()
        {
            Program.CalcPCindex();
            return Program.OpenDB[Program.PcIndex].DedFall;
        }

        public static double Init_DedInter()
        {
            Program.CalcPCindex();
            return Program.OpenDB[Program.PcIndex].DedInter;
        }

        public static void SetDed(int par, int Funk, string Prog)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                long[] numArray = new long[8];
                int[] myarr = new int[11];
                ProjectData.ClearProjectError();
                num1 = 2;
                string Left = Prog;
                long DedLong = 0;
                if (Operators.CompareString(Left, "Seg1", false) == 0)
                    DedLong = Program.Vek[Program.PNo].Deductions_Seg1;
                else if (Operators.CompareString(Left, "Seg2", false) == 0)
                    DedLong = Program.Vek[Program.PNo].Deductions_Seg2;
                Program.GetArr(ref myarr, DedLong);
                if (myarr[1] > 0)
                    numArray[1] = (long)myarr[1];
                if (myarr[2] > 0)
                    numArray[2] = (long)myarr[2];
                if (myarr[3] > 0)
                    numArray[3] = (long)myarr[3];
                if (myarr[4] > 0)
                    numArray[4] = (long)myarr[4];
                if (myarr[5] > 0)
                    numArray[5] = (long)myarr[5];
                if (myarr[6] > 0)
                    numArray[6] = (long)myarr[6];
                switch (Funk)
                {
                    case 1:
                        numArray[1] = (long)par;
                        break;
                    case 2:
                        numArray[2] = (long)par;
                        break;
                    case 3:
                        numArray[3] = (long)par;
                        break;
                    case 4:
                        numArray[4] = (long)par;
                        break;
                    case 5:
                        numArray[5] = (long)par;
                        break;
                    case 6:
                        numArray[6] = (long)par;
                        break;
                    default:
                        int num3 = (int)Interaction.MsgBox((object)"Internal error wrong call", MsgBoxStyle.SystemModal, (object)"Susanne SW");
                        break;
                }
                string segment = Program.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    Program.Vek[Program.PNo].Deductions_Seg1 = checked(numArray[1] + numArray[2] * 10L + numArray[3] * 100L + numArray[4] * 1000L + numArray[5] * 10000L + numArray[6] * 100000L);
                    goto label_34;
                }
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                {
                    Program.Vek[Program.PNo].Deductions_Seg2 = checked(numArray[1] + numArray[2] * 10L + numArray[3] * 100L + numArray[4] * 1000L + numArray[5] * 10000L + numArray[6] * 100000L);
                    goto label_34;
                }
                else
                    goto label_34;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("SetDed - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_34:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static bool TstElPP(string Elin)
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                flag = true;
                if (Operators.CompareString(Elin, "", false) != 0)
                {
                    string str = Elin;
                    if (Strings.UCase(Elin).Contains("+COMBO"))
                        str = Strings.Trim(str.Replace("+COMBO", ""));
                    if (Strings.UCase(Elin).Contains("+SEQ"))
                        str = Strings.Trim(str.Replace("+SEQ", ""));
                    if (Strings.UCase(Elin).Contains("+REP"))
                        str = Strings.Trim(str.Replace("+REP", ""));
                    if (Elin.Contains("Sp") && Elin.Contains("+V"))
                        str = Program.GetSpin(Elin);
                    if (Strings.InStr(1, str, "+", CompareMethod.Text) > 0)
                    {
                        string[] strArray = str.Split('+');
                        int num3 = checked(strArray.Length - 1);
                        int index = 0;
                        while (index <= num3)
                        {
                            if (!Program.TstOneEl(strArray[index]))
                            {
                                flag = false;
                                break;
                            }
                            checked { ++index; }
                        }
                        goto label_22;
                    }
                    else if (!Program.TstOneEl(str))
                    {
                        flag = false;
                        goto label_22;
                    }
                    else
                        goto label_22;
                }
                else
                    goto label_22;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("TstElPP - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_22:
            int num5 = flag ? 1 : 0;
            if (num2 == 0)
                return num5 != 0;
            ProjectData.ClearProjectError();
            return num5 != 0;
        }

        public static bool TstOneEl(string Elin)
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                if (Elin.Contains("*"))
                {
                    flag = true;
                    goto label_20;
                }
                else
                {
                    flag = false;
                    if (Strings.Len(Elin) > 0)
                    {
                        string str = Elin;
                        if (str.Contains("+V"))
                        {
                            str = Program.GetSpin(str);
                        }
                        else
                        {
                            if (Operators.CompareString(Strings.Right(str, 1), "e", false) == 0)
                                str = Strings.Trim(str.Replace("e", ""));
                            if (str.Contains("<"))
                                str = Strings.Trim(str.Replace("<", ""));
                            if (str.Contains("!"))
                                str = Strings.Trim(str.Replace("!", ""));
                            if (str.Contains("f"))
                                str = Strings.Trim(str.Replace("f", ""));
                            if (str.Contains(" q"))
                                str = Strings.Trim(str.Replace(" q", ""));
                        }
                        int elDbmax = Program.ElDBmax;
                        int index = 0;
                        while (index <= elDbmax)
                        {
                            if (Operators.ConditionalCompareObjectEqual((object)str, Program.ElDB[index, 0], false))
                            {
                                flag = true;
                                break;
                            }
                            checked { ++index; }
                        }
                        goto label_20;
                    }
                    else
                    {
                        flag = true;
                        goto label_20;
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
                int num3 = (int)Interaction.MsgBox((object)("TstOneEl - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_20:
            int num4 = flag ? 1 : 0;
            if (num2 == 0)
                return num4 != 0;
            ProjectData.ClearProjectError();
            return num4 != 0;
        }

        public static void SortListStartNo(int NoOfSkater)
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
                    Program.Participant participant = Program.Vek[index1];
                    num3 = 4;
                    int index2 = index1;
                    num3 = 5;
                    int num5 = checked(index1 + 1);
                    int num6 = NoOfSkater;
                    int index3 = num5;
                    while (index3 <= num6)
                    {
                        num3 = 6;
                        string segment = Program.Segment;
                        num3 = 9;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                        {
                            num3 = 10;
                            if ((double)Program.Vek[index3].Startno_Seg1 < (double)participant.Startno_Seg1)
                            {
                                num3 = 11;
                                participant = Program.Vek[index3];
                                num3 = 12;
                                index2 = index3;
                            }
                        }
                        else
                        {
                            num3 = 15;
                            if (Operators.CompareString(segment, "Seg2", false) == 0)
                            {
                                num3 = 16;
                                if ((double)Program.Vek[index3].Startno_Seg2 < (double)participant.Startno_Seg2)
                                {
                                    num3 = 17;
                                    participant = Program.Vek[index3];
                                    num3 = 18;
                                    index2 = index3;
                                }
                            }
                        }
                        num3 = 21;
                        checked { ++index3; }
                    }
                    num3 = 22;
                    Program.Vek[index2] = Program.Vek[index1];
                    num3 = 23;
                    Program.Vek[index1] = participant;
                    num3 = 24;
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

        public static void SortStartNoSeg2(int NoOfSkater, ref int DNS_Seg1)
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
                    if (Program.Vek[index1].DNS_Seg1 > 0)
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
                    Program.Participant participant = Program.Vek[index2];
                    num3 = 10;
                    int index3 = index2;
                    num3 = 11;
                    int num6 = checked(index2 + 1);
                    int num7 = NoOfSkater;
                    int index4 = num6;
                    while (index4 <= num7)
                    {
                        num3 = 12;
                        if (Program.Vek[index4].DNS_Seg1 < participant.DNS_Seg1)
                        {
                            num3 = 13;
                            participant = Program.Vek[index4];
                            num3 = 14;
                            index3 = index4;
                        }
                        num3 = 16;
                        checked { ++index4; }
                    }
                    num3 = 17;
                    Program.Vek[index3] = Program.Vek[index2];
                    num3 = 18;
                    Program.Vek[index2] = participant;
                    num3 = 19;
                    checked { ++index2; }
                }
                num3 = 20;
                int num8 = 0;
                num3 = 21;
                int num9 = checked(NoOfSkater - DNS_Seg1);
                int index5 = 1;
                while (index5 <= num9)
                {
                    num3 = 22;
                    if (Program.Vek[index5].Startno_Seg2 < 1)
                    {
                        num3 = 23;
                        checked { ++num8; }
                    }
                    num3 = 25;
                    checked { ++index5; }
                }
                num3 = 26;
                int num10 = checked(NoOfSkater - 1 - DNS_Seg1);
                int index6 = 1;
                while (index6 <= num10)
                {
                    num3 = 27;
                    Program.Participant participant = Program.Vek[index6];
                    num3 = 28;
                    int index7 = index6;
                    num3 = 29;
                    int num11 = checked(index6 + 1);
                    int num12 = checked(NoOfSkater - DNS_Seg1);
                    int index8 = num11;
                    while (index8 <= num12)
                    {
                        num3 = 30;
                        if (Program.Vek[index8].Startno_Seg2 > participant.Startno_Seg2)
                        {
                            num3 = 31;
                            participant = Program.Vek[index8];
                            num3 = 32;
                            index7 = index8;
                        }
                        num3 = 34;
                        checked { ++index8; }
                    }
                    num3 = 35;
                    Program.Vek[index7] = Program.Vek[index6];
                    num3 = 36;
                    Program.Vek[index6] = participant;
                    num3 = 37;
                    checked { ++index6; }
                }
                num3 = 38;
                int num13 = checked(NoOfSkater - 1 - DNS_Seg1 - num8);
                int index9 = 1;
                while (index9 <= num13)
                {
                    num3 = 39;
                    Program.Participant participant = Program.Vek[index9];
                    num3 = 40;
                    int index10 = index9;
                    num3 = 41;
                    int num14 = checked(index9 + 1);
                    int num15 = checked(NoOfSkater - DNS_Seg1 - num8);
                    int index11 = num14;
                    while (index11 <= num15)
                    {
                        num3 = 42;
                        if ((double)Program.Vek[index11].Startno_Seg2 < (double)participant.Startno_Seg2)
                        {
                            num3 = 43;
                            participant = Program.Vek[index11];
                            num3 = 44;
                            index10 = index11;
                        }
                        num3 = 46;
                        checked { ++index11; }
                    }
                    num3 = 47;
                    Program.Vek[index10] = Program.Vek[index9];
                    num3 = 48;
                    Program.Vek[index9] = participant;
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

        public static bool IsFormOpen(Form frm) => Application.OpenForms.OfType<Form>().Contains<Form>(frm);

        [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
        public static bool GetIniData(string FName)
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int FileNumber = FileSystem.FreeFile();
                string startupPath = Application.StartupPath;
                FileSystem.FileOpen(FileNumber, startupPath + "\\" + FName, OpenMode.Input);
                int num3 = 0;
                while (!FileSystem.EOF(FileNumber) & num3 < 60)
                {
                    string str1 = FileSystem.LineInput(FileNumber);
                    checked { ++num3; }
                    string str2 = Strings.Trim(str1);
                    if (!str2.StartsWith("'"))
                    {
                        if (Strings.UCase(str2).Contains("COMP_FOLDER="))
                        {
                            Program.PathCompFile = Strings.Trim(str2.Split('=')[1]);
                            Program.PathCompFile = Program.PathCompFile.Replace("/", "\\");
                        }
                        if (Strings.UCase(str2).Contains("RESULTS_FOLDER="))
                        {
                            Program.PathResultsFile = Strings.Trim(str2.Split('=')[1]);
                            Program.PathResultsFile = Program.PathResultsFile.Replace("/", "\\");
                        }
                        if (Strings.UCase(str2).Contains("RESULTSPHONE="))
                        {
                            Program.CreateResultsPhone = Conversions.ToInteger(Strings.Trim(str2.Split('=')[1]));
                            switch (Program.CreateResultsPhone)
                            {
                                case 0:
                                case 1:
                                    break;
                                default:
                                    Program.CreateResultsPhone = 0;
                                    break;
                            }
                        }
                        if (Strings.UCase(str2).Contains("TESCORES="))
                        {
                            Program.CreateTEScores = Conversions.ToInteger(Strings.Trim(str2.Split('=')[1]));
                            switch (Program.CreateTEScores)
                            {
                                case 0:
                                case 1:
                                    break;
                                default:
                                    Program.CreateTEScores = 0;
                                    break;
                            }
                        }
                        if (Strings.UCase(str2).Contains("ICELEAVETIME="))
                            Program.IceLeaveTime = Strings.Trim(str2.Split('=')[1]);
                        if (Strings.UCase(str2).Contains("RESURFACINGTIME"))
                            Program.ResurfacingTime = Strings.Trim(str2.Split('=')[1]);
                        if (Strings.UCase(str2).Contains("LUNCHTIME="))
                            Program.LunchTime = Strings.Trim(str2.Split('=')[1]);
                        if (Strings.UCase(str2).Contains("SHOW_JUDGE_DED="))
                            Program.ShowJudgeDed = Conversions.ToInteger(Strings.Trim(str2.Split('=')[1]));
                        if (Strings.UCase(str2).Contains("TRIMMED_MV="))
                        {
                            Program.NoJudgeTMV = Conversions.ToInteger(Strings.Trim(str2.Split('=')[1]));
                            switch (Program.NoJudgeTMV)
                            {
                                case 0:
                                case 9:
                                    Program.NoJudgeTMV = 9;
                                    break;
                                case 5:
                                case 7:
                                    break;
                                default:
                                    Program.NoJudgeTMV = 5;
                                    break;
                            }
                        }
                        if (Strings.UCase(str2).Contains("SCOREBOARD="))
                        {
                            Program.CreateScoreBoard = Conversions.ToInteger(Strings.Trim(str2.Split('=')[1]));
                            switch (Program.CreateScoreBoard)
                            {
                                case 0:
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                    break;
                                default:
                                    Program.CreateScoreBoard = 0;
                                    break;
                            }
                        }
                        if (Strings.UCase(str2).Contains("SCOREBOARD DELAY="))
                        {
                            Program.ScoreBoardDelay = Conversions.ToInteger(Strings.Trim(str2.Split('=')[1]));
                            int pageLeftMargin = Program.Page_Left_Margin;
                            if (pageLeftMargin < 0 || pageLeftMargin > 60)
                                Program.ScoreBoardDelay = 0;
                        }
                        if (Strings.UCase(str2).Contains("PORT_NO="))
                            Program.PortNo = Conversions.ToInteger(Strings.Trim(str2.Split('=')[1]));
                        if (Strings.UCase(str2).Contains("PING CLIENTS="))
                        {
                            Program.PingClients = Conversions.ToInteger(Strings.Trim(str2.Split('=')[1]));
                            switch (Program.PingClients)
                            {
                                case 0:
                                case 1:
                                    break;
                                default:
                                    Program.PingClients = 1;
                                    break;
                            }
                        }
                        if (Strings.UCase(str2).Contains("PING TIMEOUT="))
                        {
                            Program.PingTimeout = Conversions.ToInteger(Strings.Trim(str2.Split('=')[1]));
                            if (Program.PingTimeout < 500 & Program.PingTimeout > 1500)
                                Program.PingTimeout = 1000;
                        }
                        if (Strings.UCase(str2).Contains("PAGE SIZE="))
                        {
                            Program.Page_Size = (double)Conversions.ToInteger(Strings.Trim(str2.Split('=')[1]));
                            double pageSize = Program.Page_Size;
                            if (pageSize < 75.0 || pageSize > 125.0)
                                Program.Page_Size = 100.0;
                        }
                        if (Strings.UCase(str2).Contains("LEFT MARGIN="))
                        {
                            Program.Page_Left_Margin = Conversions.ToInteger(Strings.Trim(str2.Split('=')[1]));
                            int pageLeftMargin = Program.Page_Left_Margin;
                            if (pageLeftMargin < 0 || pageLeftMargin > 100)
                                Program.Page_Left_Margin = 40;
                        }
                        if (Strings.UCase(str2).Contains("TOP MARGIN="))
                        {
                            Program.Page_Top_Margin = Conversions.ToInteger(Strings.Trim(str2.Split('=')[1]));
                            int pageTopMargin = Program.Page_Top_Margin;
                            if (pageTopMargin < 0 || pageTopMargin > 100)
                                Program.Page_Top_Margin = 60;
                        }
                        if (Strings.UCase(str2).Contains("COMPUTERNO1="))
                        {
                            string str3 = Strings.Trim(str2.Split('=')[1]);
                            Program.JudgeCompNo[1] = Conversions.ToInteger(Strings.Left(str3, 1));
                            Program.JudgeCompFunc[1] = Conversions.ToInteger(Strings.Right(str3, 1));
                        }
                        if (Strings.UCase(str2).Contains("COMPUTERNO2="))
                        {
                            string str4 = Strings.Trim(str2.Split('=')[1]);
                            Program.JudgeCompNo[2] = Conversions.ToInteger(Strings.Left(str4, 1));
                            Program.JudgeCompFunc[2] = Conversions.ToInteger(Strings.Right(str4, 1));
                        }
                        if (Strings.UCase(str2).Contains("COMPUTERNO3="))
                        {
                            string str5 = Strings.Trim(str2.Split('=')[1]);
                            Program.JudgeCompNo[3] = Conversions.ToInteger(Strings.Left(str5, 1));
                            Program.JudgeCompFunc[3] = Conversions.ToInteger(Strings.Right(str5, 1));
                        }
                        if (Strings.UCase(str2).Contains("COMPUTERNO4="))
                        {
                            string str6 = Strings.Trim(str2.Split('=')[1]);
                            Program.JudgeCompNo[4] = Conversions.ToInteger(Strings.Left(str6, 1));
                            Program.JudgeCompFunc[4] = Conversions.ToInteger(Strings.Right(str6, 1));
                        }
                        if (Strings.UCase(str2).Contains("COMPUTERNO5="))
                        {
                            string str7 = Strings.Trim(str2.Split('=')[1]);
                            Program.JudgeCompNo[5] = Conversions.ToInteger(Strings.Left(str7, 1));
                            Program.JudgeCompFunc[5] = Conversions.ToInteger(Strings.Right(str7, 1));
                        }
                        if (Strings.UCase(str2).Contains("COMPUTERNO6="))
                        {
                            string str8 = Strings.Trim(str2.Split('=')[1]);
                            Program.JudgeCompNo[6] = Conversions.ToInteger(Strings.Left(str8, 1));
                            Program.JudgeCompFunc[6] = Conversions.ToInteger(Strings.Right(str8, 1));
                        }
                        if (Strings.UCase(str2).Contains("COMPUTERNO7="))
                        {
                            string str9 = Strings.Trim(str2.Split('=')[1]);
                            Program.JudgeCompNo[7] = Conversions.ToInteger(Strings.Left(str9, 1));
                            Program.JudgeCompFunc[7] = Conversions.ToInteger(Strings.Right(str9, 1));
                        }
                        if (Strings.UCase(str2).Contains("ADJUSTTOSCREEN="))
                            Program.AdjustToScreen = Conversions.ToInteger(Strings.Trim(str2.Split('=')[1]));
                    }
                }
                flag = true;
                FileSystem.FileClose(FileNumber);
                goto label_70;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                flag = false;
                int num4 = (int)Interaction.MsgBox((object)("GetIniData - Error reading CLUBCOMP.INI!" + Information.Err().Description), MsgBoxStyle.Critical | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_70:
            int num5 = flag ? 1 : 0;
            if (num2 == 0)
                return num5 != 0;
            ProjectData.ClearProjectError();
            return num5 != 0;
        }

        public static void SaveIniData(string IniFile)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                StreamWriter streamWriter = new StreamWriter(Application.StartupPath + "\\" + IniFile, false, Encoding.Default);
                streamWriter.Write("' [CLUBCOMP.INI]\r\n");
                streamWriter.Write("'\r\n");
                streamWriter.Write("' Comp_folder= C:\\Competition\\, Folder for Category.xml files\r\n");
                streamWriter.Write("' Results_folder= C:\\Results\\, Folder for Results.htm, ResultsPhone.htm, ScoreBoard.htm files and Speaker.html\r\n");
                streamWriter.Write("' ResultsPhone, 0 ==> no action, 1 ==> ResultsPhone.htm for smartphones is created\r\n");
                streamWriter.Write("' TEScores, 0 ==> no action, 1 ==> TEScores.htm is created\r\n");
                streamWriter.Write("'\r\n");
                streamWriter.Write("' Show Judge majority deductions: 0 or 1\r\n");
                streamWriter.Write("' No. of Judges for calculation of trimmed MV: 0, 5 or 7\r\n");
                streamWriter.Write("' ScoreBoard, 0 ==> no action, 1 ==> backcolor=black, 2 ==> backcolor=white\r\n");
                streamWriter.Write("' ScoreBoard Delay, 0 - 60 sec.\r\n");
                streamWriter.Write("' Ping Clients: 0 or 1\r\n");
                streamWriter.Write("' Ping Timeout: 500 - 1500 ms\r\n");
                streamWriter.Write("' For a A4 page: Page Size= 100, Left Margin= 40, Top Margin= 60\r\n");
                streamWriter.Write("'\r\n");
                streamWriter.Write("Comp_folder= " + Program.PathCompFile + "\r\n");
                streamWriter.Write("Results_folder= " + Program.PathResultsFile + "\r\n");
                streamWriter.Write("ResultsPhone= " + Strings.Trim(Conversions.ToString(Program.CreateResultsPhone)) + "\r\n");
                streamWriter.Write("TEScores= " + Strings.Trim(Conversions.ToString(Program.CreateTEScores)) + "\r\n");
                streamWriter.Write("'\r\n");
                streamWriter.Write("WarmUpTime= " + Program.WarmUpTime + "\r\n");
                streamWriter.Write("IceLeaveTime= " + Program.IceLeaveTime + "\r\n");
                streamWriter.Write("ResurfacingTime= " + Program.ResurfacingTime + "\r\n");
                streamWriter.Write("LunchTime= " + Program.LunchTime + "\r\n");
                streamWriter.Write("'\r\n");
                streamWriter.Write("SHOW_JUDGE_DED= " + Strings.Trim(Conversions.ToString(Program.ShowJudgeDed)) + "\r\n");
                streamWriter.Write("'\r\n");
                switch (Program.NoJudgeTMV)
                {
                    case 0:
                    case 9:
                        streamWriter.Write("TRIMMED_MV= " + Strings.Trim(Conversions.ToString(0)) + "\r\n");
                        break;
                    default:
                        streamWriter.Write("TRIMMED_MV= " + Strings.Trim(Conversions.ToString(Program.NoJudgeTMV)) + "\r\n");
                        break;
                }
                streamWriter.Write("'\r\n");
                streamWriter.Write("SCOREBOARD= " + Strings.Trim(Conversions.ToString(Program.CreateScoreBoard)) + "\r\n");
                streamWriter.Write("SCOREBOARD DELAY= " + Strings.Trim(Conversions.ToString(Program.ScoreBoardDelay)) + "\r\n");
                streamWriter.Write("'\r\n");
                streamWriter.Write("Port_No= " + Strings.Trim(Conversions.ToString(Program.PortNo)) + "\r\n");
                streamWriter.Write("Ping Clients= " + Strings.Trim(Conversions.ToString(Program.PingClients)) + "\r\n");
                streamWriter.Write("Ping Timeout= " + Strings.Trim(Conversions.ToString(Program.PingTimeout)) + "\r\n");
                streamWriter.Write("'\r\n");
                streamWriter.Write("Page Size= " + Strings.Trim(Conversions.ToString(Program.Page_Size)) + "\r\n");
                streamWriter.Write("Left Margin= " + Strings.Trim(Conversions.ToString(Program.Page_Left_Margin)) + "\r\n");
                streamWriter.Write("Top Margin= " + Strings.Trim(Conversions.ToString(Program.Page_Top_Margin)) + "\r\n");
                streamWriter.Write("'\r\n");
                streamWriter.Write("' Setup of the Judges Computers, Judge no ; Function\r\n");
                int index = 1;
                do
                {
                    streamWriter.Write("ComputerNo" + Conversions.ToString(index) + "=" + Strings.Trim(Conversions.ToString(Program.JudgeCompNo[index])) + ";" + Strings.Trim(Conversions.ToString(Program.JudgeCompFunc[index])) + "\r\n");
                    checked { ++index; }
                }
                while (index <= 7);
                streamWriter.Write("'\r\n");
                streamWriter.Write("AdjustToScreen= " + Strings.Trim(Conversions.ToString(Program.AdjustToScreen)) + "\r\n");
                streamWriter.Close();
                streamWriter.Dispose();
                goto label_12;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("SaveIniData - Error exporting " + IniFile + "\r\nDescription : " + Information.Err().Description), MsgBoxStyle.Critical | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_12:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static int NoOfElement()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num4 = 2;
                num2 = 0;
                num4 = 3;
                int num5 = 0;
                num4 = 4;
                int index = 1;
                do
                {
                    num4 = 5;
                    string segment = Program.Segment;
                    num4 = 8;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                    {
                        num4 = 9;
                        if (Operators.CompareString(Program.Vek[Program.PNo].SSS_Seg1[index], "", false) != 0)
                        {
                            num4 = 10;
                            num5 = index;
                        }
                    }
                    else
                    {
                        num4 = 13;
                        if (Operators.CompareString(segment, "Seg2", false) == 0)
                        {
                            num4 = 14;
                            if (Operators.CompareString(Program.Vek[Program.PNo].SSS_Seg2[index], "", false) != 0)
                            {
                                num4 = 15;
                                num5 = index;
                            }
                        }
                    }
                    num4 = 18;
                    checked { ++index; }
                }
                while (index <= 15);
                num2 = num5;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num3 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            int num6 = num2;
            if (num3 == 0)
                return num6;
            ProjectData.ClearProjectError();
            return num6;
        }

        public static string PCSel()
        {
            int num1 = 0;
            string str1 = "";
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                int num3 = 0;
                string segment = Program.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    if (Program.OpenDB[Program.PcIndex].PCFactorsSeg1[1] > 0.0)
                        num3 = 1;
                    if (Program.OpenDB[Program.PcIndex].PCFactorsSeg1[2] > 0.0)
                        checked { num3 += 2; }
                    if (Program.OpenDB[Program.PcIndex].PCFactorsSeg1[3] > 0.0)
                        checked { num3 += 4; }
                    if (Program.OpenDB[Program.PcIndex].PCFactorsSeg1[4] > 0.0)
                        checked { num3 += 8; }
                    if (Program.OpenDB[Program.PcIndex].PCFactorsSeg1[5] > 0.0)
                        checked { num3 += 16; }
                }
                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                {
                    if (Program.OpenDB[Program.PcIndex].PCFactorsSeg2[1] > 0.0)
                        num3 = 1;
                    if (Program.OpenDB[Program.PcIndex].PCFactorsSeg2[2] > 0.0)
                        checked { num3 += 2; }
                    if (Program.OpenDB[Program.PcIndex].PCFactorsSeg2[3] > 0.0)
                        checked { num3 += 4; }
                    if (Program.OpenDB[Program.PcIndex].PCFactorsSeg2[4] > 0.0)
                        checked { num3 += 8; }
                    if (Program.OpenDB[Program.PcIndex].PCFactorsSeg2[5] > 0.0)
                        checked { num3 += 16; }
                }
                str1 = Conversions.ToString(num3);
                goto label_28;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("PCSel -Description : " + Information.Err().Description), MsgBoxStyle.Critical | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_28:
            string str2 = str1;
            if (num2 == 0)
                return str2;
            ProjectData.ClearProjectError();
            return str2;
        }

        public static void Get_CC_Time()
        {
            Program.CC_Time = DateAndTime.Now.ToString("HH:mm:ss:");
            Program.JCStatus = (int[])null;
            Program.JCStatus = new int[8];
        }

        public static bool CreateHTMFile(int StNo)
        {
            int num1 = 0;
            bool flag = false;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int Row = 0;
                num3 = 2;
                int row = 0;
                ProjectData.ClearProjectError();
                num1 = 2;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 5;
                flag = false;
                num3 = 6;
                string bc = Program.BC;
                num3 = 9;
                if (Operators.CompareString(bc, " bgcolor='#CCFFFF'", false) == 0)
                {
                    num3 = 10;
                    Program.BC = " bgcolor='FFFF99'";
                }
                else
                {
                    num3 = 12;
                    if (Operators.CompareString(bc, " bgcolor='FFFF99'", false) == 0)
                    {
                        num3 = 13;
                        Program.BC = " bgcolor='#CCFFFF'";
                    }
                    else
                    {
                        num3 = 16;
                        Program.BC = " bgcolor='#CCFFFF'";
                    }
                }
                num3 = 18;
                if (Program.TNop > 0)
                {
                    num3 = 19;
                    if (MyProject.Computer.FileSystem.DirectoryExists(Program.PathResultsFile))
                    {
                        num3 = 20;
                        string seg = Program.GetSeg();
                        num3 = 23;
                        if (Operators.CompareString(seg, "0F", false) == 0)
                        {
                            num3 = 24;
                            Program.SortListSeg2(Program.TNop);
                            num3 = 25;
                            Program.Seg2Pl(checked(Program.TNop - Program.DNS_Seg1 - Program.DNS_Seg2));
                            num3 = 26;
                            Program.CreateLiveArr(StNo);
                            num3 = 27;
                            Program.CreateResultArr(ref Row);
                            num3 = 28;
                            Program.CreateNextArr(ref row);
                            num3 = 29;
                            if (Program.CreateResultsPhone > 0)
                            {
                                num3 = 30;
                                flag = Program.MakeCSS(Program.BC, StNo, Row, row);
                            }
                            num3 = 32;
                            flag = Program.MakeResultHTM(Program.BC, StNo, Row, row);
                            num3 = 33;
                            flag = Program.MakeSpeakerHTM(Program.BC, StNo, Row, row);
                        }
                        else
                        {
                            num3 = 35;
                            if (Operators.CompareString(seg, "S0", false) == 0 || Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "FF", false) == 0 || Operators.CompareString(seg, "F0", false) == 0 || Operators.CompareString(seg, "SS", false) == 0)
                            {
                                num3 = 36;
                                string segment = Program.Segment;
                                num3 = 39;
                                if (Operators.CompareString(segment, "Seg1", false) == 0)
                                {
                                    num3 = 40;
                                    Program.SortListSeg1(Program.TNop);
                                    num3 = 41;
                                    Program.Seg1Pl(checked(Program.TNop - Program.DNS_Seg1));
                                    num3 = 42;
                                    Program.CreateLiveArr(StNo);
                                    num3 = 43;
                                    Program.CreateResultArr(ref Row);
                                    num3 = 44;
                                    Program.CreateNextArr(ref row);
                                    num3 = 45;
                                    if (Program.CreateResultsPhone > 0)
                                    {
                                        num3 = 46;
                                        flag = Program.MakeCSS(Program.BC, StNo, Row, row);
                                    }
                                    num3 = 48;
                                    flag = Program.MakeResultHTM(Program.BC, StNo, Row, row);
                                    num3 = 49;
                                    flag = Program.MakeSpeakerHTM(Program.BC, StNo, Row, row);
                                }
                                else
                                {
                                    num3 = 51;
                                    if (Operators.CompareString(segment, "Seg2", false) == 0)
                                    {
                                        num3 = 52;
                                        Program.SortListSeg1(Program.TNop);
                                        num3 = 53;
                                        Program.Seg1Pl(checked(Program.TNop - Program.DNS_Seg1));
                                        num3 = 54;
                                        Program.SortListSeg2(Program.TNop);
                                        num3 = 55;
                                        Program.Seg2Pl(checked(Program.TNop - Program.DNS_Seg1 - Program.DNS_Seg2));
                                        num3 = 56;
                                        Program.SumScore(Program.TNop);
                                        num3 = 57;
                                        Program.SortListTotal(Program.TNop);
                                        num3 = 58;
                                        Program.TotalPl(checked(Program.TNop - Program.DNS_Seg1 - Program.DNS_Seg2));
                                        num3 = 59;
                                        Program.CreateLiveArr(StNo);
                                        num3 = 60;
                                        Program.CreateResultArr(ref Row);
                                        num3 = 61;
                                        Program.CreateNextArr(ref row);
                                        num3 = 62;
                                        if (Program.CreateResultsPhone > 0)
                                        {
                                            num3 = 63;
                                            flag = Program.MakeCSS(Program.BC, StNo, Row, row);
                                        }
                                        num3 = 65;
                                        flag = Program.MakeResultHTM(Program.BC, StNo, Row, row);
                                        num3 = 66;
                                        flag = Program.MakeSpeakerHTM(Program.BC, StNo, Row, row);
                                    }
                                }
                            }
                        }
                        num3 = 69;
                        if (Program.CreateScoreBoard > 0)
                        {
                            num3 = 70;
                            if (MyProject.Forms.MainForm.completed10)
                            {
                                num3 = 71;
                                if (Program.ScoreBoardDelay > 0)
                                {
                                    num3 = 72;
                                    Program.MakesScoreBoard_StNo = StNo;
                                    num3 = 73;
                                    MyProject.Forms.MainForm.Timer10.Interval = checked(Program.ScoreBoardDelay * 1000);
                                    num3 = 74;
                                    MyProject.Forms.MainForm.Timer10.Enabled = true;
                                }
                                else
                                {
                                    num3 = 76;
                                    num3 = 77;
                                    Program.MakesScoreBoard_StNo = StNo;
                                    num3 = 78;
                                    MyProject.Forms.MainForm.Timer10.Interval = 10;
                                    num3 = 79;
                                    MyProject.Forms.MainForm.Timer10.Enabled = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        num3 = 84;
                        num3 = 85;
                        int num4 = (int)Interaction.MsgBox((object)("The folder:\r\n" + Program.PathResultsFile + "\r\ndoes not exist!"), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                    }
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            int num5 = flag ? 1 : 0;
            if (num2 == 0)
                return num5 != 0;
            ProjectData.ClearProjectError();
            return num5 != 0;
        }

        public static bool CreateHTMFileSpeaker(int StNo)
        {
            int num1 = 0;
            bool flag = false;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int Row = 0;
                num3 = 2;
                int row = 0;
                ProjectData.ClearProjectError();
                num1 = 2;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 5;
                flag = false;
                num3 = 6;
                string bc = Program.BC;
                num3 = 9;
                if (Operators.CompareString(bc, " bgcolor='#CCFFFF'", false) == 0)
                {
                    num3 = 10;
                    Program.BC = " bgcolor='FFFF99'";
                }
                else
                {
                    num3 = 12;
                    if (Operators.CompareString(bc, " bgcolor='FFFF99'", false) == 0)
                    {
                        num3 = 13;
                        Program.BC = " bgcolor='#CCFFFF'";
                    }
                    else
                    {
                        num3 = 16;
                        Program.BC = " bgcolor='#CCFFFF'";
                    }
                }
                num3 = 18;
                if (Program.TNop > 0)
                {
                    num3 = 19;
                    string seg = Program.GetSeg();
                    num3 = 22;
                    if (Operators.CompareString(seg, "0F", false) == 0)
                    {
                        num3 = 23;
                        Program.SortListSeg2(Program.TNop);
                        num3 = 24;
                        Program.Seg2Pl(checked(Program.TNop - Program.DNS_Seg1 - Program.DNS_Seg2));
                        num3 = 25;
                        Program.CreateLiveArr(StNo);
                        num3 = 26;
                        Program.CreateResultArr(ref Row);
                        num3 = 27;
                        Program.CreateNextArr(ref row);
                        num3 = 28;
                        flag = Program.MakeSpeakerHTM(Program.BC, StNo, Row, row);
                    }
                    else
                    {
                        num3 = 30;
                        if (Operators.CompareString(seg, "S0", false) != 0 && Operators.CompareString(seg, "SF", false) != 0 && Operators.CompareString(seg, "FF", false) != 0 && Operators.CompareString(seg, "F0", false) != 0)
                        {
                            if (Operators.CompareString(seg, "SS", false) != 0)
                                goto label_17;
                        }
                        num3 = 31;
                        string segment = Program.Segment;
                        num3 = 34;
                        if (Operators.CompareString(segment, "Seg1", false) == 0)
                        {
                            num3 = 35;
                            Program.SortListSeg1(Program.TNop);
                            num3 = 36;
                            Program.Seg1Pl(checked(Program.TNop - Program.DNS_Seg1));
                            num3 = 37;
                            Program.CreateLiveArr(StNo);
                            num3 = 38;
                            Program.CreateResultArr(ref Row);
                            num3 = 39;
                            Program.CreateNextArr(ref row);
                            num3 = 40;
                            flag = Program.MakeSpeakerHTM(Program.BC, StNo, Row, row);
                        }
                        else
                        {
                            num3 = 42;
                            if (Operators.CompareString(segment, "Seg2", false) == 0)
                            {
                                num3 = 43;
                                Program.SortListSeg1(Program.TNop);
                                num3 = 44;
                                Program.Seg1Pl(checked(Program.TNop - Program.DNS_Seg1));
                                num3 = 45;
                                Program.SortListSeg2(Program.TNop);
                                num3 = 46;
                                Program.Seg2Pl(checked(Program.TNop - Program.DNS_Seg1 - Program.DNS_Seg2));
                                num3 = 47;
                                Program.SumScore(Program.TNop);
                                num3 = 48;
                                Program.SortListTotal(Program.TNop);
                                num3 = 49;
                                Program.TotalPl(checked(Program.TNop - Program.DNS_Seg1 - Program.DNS_Seg2));
                                num3 = 50;
                                Program.CreateLiveArr(StNo);
                                num3 = 51;
                                Program.CreateResultArr(ref Row);
                                num3 = 52;
                                Program.CreateNextArr(ref row);
                                num3 = 53;
                                flag = Program.MakeSpeakerHTM(Program.BC, StNo, Row, row);
                            }
                        }
                    }
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
        label_17:
            int num4 = flag ? 1 : 0;
            if (num2 == 0)
                return num4 != 0;
            ProjectData.ClearProjectError();
            return num4 != 0;
        }

        public static void MakeScoreBoard_12(int StNo)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string str1 = " bgcolor='#000000'";
                string str2 = " color='#FFFFFF'";
                object[,] objArray1 = new object[26, 8];
                ProjectData.ClearProjectError();
                num1 = 2;
                string pathResultsFile = Program.PathResultsFile;
                string str3 = "ScoreBoard.htm";
                object[,] objArray2 = new object[51, 10];
                switch (Program.CreateScoreBoard)
                {
                    case 1:
                    case 3:
                        str1 = " bgcolor='#000000'";
                        str2 = " color='#FFFFFF'";
                        break;
                    case 2:
                    case 4:
                        str1 = " bgcolor='#FFFFFF'";
                        str2 = " color='#000000'";
                        break;
                }
                string str4 = "Score Board";
                StreamWriter streamWriter = new StreamWriter(pathResultsFile + str3, false, Encoding.Default);
                streamWriter.Write("<html>\r\n");
                streamWriter.Write("<head>\r\n");
                streamWriter.Write("<title>ClubCompFS " + str4 + "</title>\r\n");
                streamWriter.Write("</head>\r\n");
                streamWriter.Write("<body" + str1 + ">\r\n");
                streamWriter.Write("<style type='text/css'>\r\n");
                streamWriter.Write("td { font-family: Arial}\r\n");
                streamWriter.Write("</style>\r\n");
                streamWriter.Write("<table border='0' cellspacing='0'" + str1 + ">\r\n");
                string segment1 = Program.Segment;
                int Pno = 0;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    Pno = 1;
                    while (Program.Vek[Pno].Startno_Seg1 != StNo)
                    {
                        checked { ++Pno; }
                        if (Pno > 42)
                            break;
                    }
                }
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                {
                    Pno = 1;
                    while (Program.Vek[Pno].Startno_Seg2 != StNo)
                    {
                        checked { ++Pno; }
                        if (Pno > 42)
                            break;
                    }
                }
                string str5 = Strings.UCase(Program.GetCat() + ", " + Program.GetSegTxt(Program.Segment));
                streamWriter.Write("<tr>\r\n");
                string str6 = "<b>" + str5 + "</b>";
                string str7 = "<td align='center' width='480'><font size='3'" + str2 + ">" + str6 + "</td>";
                streamWriter.Write(str7 + "\r\n");
                streamWriter.Write("</tr>\r\n");
                streamWriter.Write("</table>\r\n");
                int num3 = 0;
                if (Pno <= Program.TNop)
                {
                    string[] strArray = new string[2]
                    {
            "'0'",
            "'480'"
                    };
                    objArray2[3, 1] = (object)"RESULTS FOR";
                    objArray2[4, 1] = (object)(Program.Vek[Pno].Name.FName + " " + Program.Vek[Pno].Name.LName);
                    objArray2[5, 1] = (object)Program.Vek[Pno].Club;
                    num3 = 1;
                    streamWriter.Write("<br/>\r\n");
                    streamWriter.Write("<table border='0' cellspacing='0'" + str1 + ">\r\n");
                    int index1 = 3;
                    do
                    {
                        streamWriter.Write("<tr>\r\n");
                        int num4 = num3;
                        int index2 = 1;
                        while (index2 <= num4)
                        {
                            string str8 = Conversions.ToString(objArray2[index1, index2]);
                            if (Strings.Len(RuntimeHelpers.GetObjectValue(objArray2[index1, index2])) < 1)
                                str8 = "&nbsp;";
                            string str9 = "<b>" + str8 + "</b>";
                            string str10 = "<td align='left' width=" + strArray[index2] + "><font size='3'" + str2 + ">" + str9 + "</td>";
                            streamWriter.Write(str10 + "\r\n");
                            checked { ++index2; }
                        }
                        streamWriter.Write("</tr>\r\n");
                        checked { ++index1; }
                    }
                    while (index1 <= Constants.TOTAL_COMPONENTS_COUNT);
                    streamWriter.Write("</table>\r\n");
                }
                objArray2[6, 4] = (object)"TES";
                objArray2[6, 5] = (object)"PCS";
                objArray2[6, 6] = (object)"DED";
                string seg = Program.GetSeg();
                if (Operators.CompareString(seg, "0F", false) == 0)
                {
                    objArray2[7, 1] = (object)"FREE:";
                    objArray2[7, 2] = (object)Program.Vek[Pno].Score_Seg2;
                    objArray2[7, 4] = (object)Program.Vek[Pno].TES_Seg2;
                    objArray2[7, 5] = (object)Program.Vek[Pno].PCS_Seg2;
                    objArray2[7, 6] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                    if (Program.Bonus_Sel("Seg2"))
                    {
                        objArray2[6, 7] = (object)"BON";
                        objArray2[7, 7] = (object)Program.Vek[Pno].Bonus_Seg2;
                        num3 = 7;
                    }
                    else
                        num3 = 6;
                    objArray2[8, 1] = (object)"TOTAL:";
                    objArray2[8, 2] = (object)Program.Vek[Pno].Score_Seg2;
                    objArray2[8, 4] = (object)("CURRENT STANDING:  " + Conversions.ToString(Program.Vek[Pno].Place_Seg2));
                }
                else if (Operators.CompareString(seg, "SF", false) == 0)
                {
                    string segment2 = Program.Segment;
                    if (Operators.CompareString(segment2, "Seg1", false) == 0)
                    {
                        objArray2[7, 1] = (object)"SHORT:";
                        objArray2[7, 2] = (object)Program.Vek[Pno].Score_Seg1;
                        objArray2[7, 4] = (object)Program.Vek[Pno].TES_Seg1;
                        objArray2[7, 5] = (object)Program.Vek[Pno].PCS_Seg1;
                        objArray2[7, 6] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                        if (Program.Bonus_Sel("Seg1"))
                        {
                            objArray2[6, 7] = (object)"BON";
                            objArray2[7, 7] = (object)Program.Vek[Pno].Bonus_Seg1;
                            num3 = 7;
                        }
                        else
                            num3 = 6;
                        objArray2[8, 4] = (object)("CURRENT STANDING:  " + Conversions.ToString(Program.Vek[Pno].Place_Seg1));
                    }
                    else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                    {
                        objArray2[6, 1] = (object)"SHORT:";
                        objArray2[6, 2] = (object)Program.Vek[Pno].Score_Seg1;
                        objArray2[6, 7] = (object)"BON";
                        objArray2[7, 1] = (object)"FREE:";
                        objArray2[7, 2] = (object)Program.Vek[Pno].Score_Seg2;
                        objArray2[7, 4] = (object)Program.Vek[Pno].TES_Seg2;
                        objArray2[7, 5] = (object)Program.Vek[Pno].PCS_Seg2;
                        objArray2[7, 6] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                        if (Program.Bonus_Sel("Seg2"))
                        {
                            objArray2[6, 7] = (object)"BON";
                            objArray2[7, 7] = (object)Program.Vek[Pno].Bonus_Seg2;
                            num3 = 7;
                        }
                        else
                            num3 = 6;
                        objArray2[8, 1] = (object)"TOTAL:";
                        objArray2[8, 2] = (object)Program.Vek[Pno].Score_Total;
                        objArray2[8, 4] = (object)("CURRENT STANDING:  " + Conversions.ToString(Program.Vek[Pno].Place));
                    }
                }
                else if (Operators.CompareString(seg, "FF", false) == 0)
                {
                    string segment3 = Program.Segment;
                    if (Operators.CompareString(segment3, "Seg1", false) == 0)
                    {
                        objArray2[7, 1] = (object)"FREE:";
                        objArray2[7, 2] = (object)Program.Vek[Pno].Score_Seg1;
                        objArray2[7, 4] = (object)Program.Vek[Pno].TES_Seg1;
                        objArray2[7, 5] = (object)Program.Vek[Pno].PCS_Seg1;
                        objArray2[7, 6] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                        if (Program.Bonus_Sel("Seg1"))
                        {
                            objArray2[6, 7] = (object)"BON";
                            objArray2[7, 7] = (object)Program.Vek[Pno].Bonus_Seg1;
                            num3 = 7;
                        }
                        else
                            num3 = 6;
                        objArray2[8, 4] = (object)("CURRENT STANDING:  " + Conversions.ToString(Program.Vek[Pno].Place_Seg1));
                    }
                    else if (Operators.CompareString(segment3, "Seg2", false) == 0)
                    {
                        objArray2[6, 1] = (object)"FREE:";
                        objArray2[6, 2] = (object)Program.Vek[Pno].Score_Seg1;
                        objArray2[7, 1] = (object)"FREE:";
                        objArray2[7, 2] = (object)Program.Vek[Pno].Score_Seg2;
                        objArray2[7, 4] = (object)Program.Vek[Pno].TES_Seg2;
                        objArray2[7, 5] = (object)Program.Vek[Pno].PCS_Seg2;
                        objArray2[7, 6] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                        if (Program.Bonus_Sel("Seg2"))
                        {
                            objArray2[6, 7] = (object)"BON";
                            objArray2[7, 7] = (object)Program.Vek[Pno].Bonus_Seg2;
                            num3 = 7;
                        }
                        else
                            num3 = 6;
                        objArray2[8, 1] = (object)"TOTAL:";
                        objArray2[8, 2] = (object)Program.Vek[Pno].Score_Total;
                        objArray2[8, 4] = (object)("CURRENT STANDING:  " + Conversions.ToString(Program.Vek[Pno].Place));
                    }
                }
                else if (Operators.CompareString(seg, "SS", false) == 0)
                {
                    string segment4 = Program.Segment;
                    if (Operators.CompareString(segment4, "Seg1", false) == 0)
                    {
                        objArray2[6, 7] = (object)"BON";
                        objArray2[7, 1] = (object)"SHORT:";
                        objArray2[7, 2] = (object)Program.Vek[Pno].Score_Seg1;
                        objArray2[7, 4] = (object)Program.Vek[Pno].TES_Seg1;
                        objArray2[7, 5] = (object)Program.Vek[Pno].PCS_Seg1;
                        objArray2[7, 6] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                        if (Program.Bonus_Sel("Seg1"))
                        {
                            objArray2[6, 7] = (object)"BON";
                            objArray2[7, 7] = (object)Program.Vek[Pno].Bonus_Seg1;
                            num3 = 7;
                        }
                        else
                            num3 = 6;
                        objArray2[8, 4] = (object)("CURRENT STANDING:  " + Conversions.ToString(Program.Vek[Pno].Place_Seg1));
                    }
                    else if (Operators.CompareString(segment4, "Seg2", false) == 0)
                    {
                        objArray2[6, 1] = (object)"SHORT:";
                        objArray2[6, 2] = (object)Program.Vek[Pno].Score_Seg1;
                        objArray2[7, 1] = (object)"FREE:";
                        objArray2[7, 2] = (object)Program.Vek[Pno].Score_Seg2;
                        objArray2[7, 4] = (object)Program.Vek[Pno].TES_Seg2;
                        objArray2[7, 5] = (object)Program.Vek[Pno].PCS_Seg2;
                        objArray2[7, 6] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                        if (Program.Bonus_Sel("Seg2"))
                        {
                            objArray2[6, 7] = (object)"BON";
                            objArray2[7, 7] = (object)Program.Vek[Pno].Bonus_Seg2;
                            num3 = 7;
                        }
                        else
                            num3 = 6;
                        objArray2[8, 1] = (object)"TOTAL:";
                        objArray2[8, 2] = (object)Program.Vek[Pno].Score_Total;
                        objArray2[8, 4] = (object)("CURRENT STANDING:  " + Conversions.ToString(Program.Vek[Pno].Place));
                    }
                }
                string[] strArray1 = new string[8]
                {
          "'0'",
          "'100'",
          "'70'",
          "'70'",
          "'70'",
          "'70'",
          "'50'",
          "'50'"
                };
                streamWriter.Write("<table border='0' cellspacing='0'" + str1 + ">\r\n");
                int index3 = 6;
                do
                {
                    streamWriter.Write("<tr>\r\n");
                    int num5 = num3;
                    int index4 = 1;
                    while (index4 <= num5)
                    {
                        string str11;
                        if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objArray2[index3, index4])))
                        {
                            switch (index4)
                            {
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                    str11 = Strings.Format(RuntimeHelpers.GetObjectValue(objArray2[index3, index4]), "#0.00");
                                    break;
                                case 6:
                                case 7:
                                    str11 = Strings.Format(RuntimeHelpers.GetObjectValue(objArray2[index3, index4]), "#0.0");
                                    break;
                                default:
                                    str11 = Conversions.ToString(objArray2[index3, index4]);
                                    break;
                            }
                        }
                        else
                            str11 = Conversions.ToString(objArray2[index3, index4]);
                        string str12;
                        switch (index4)
                        {
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                                str12 = " align='left'";
                                break;
                            case 6:
                            case 7:
                                str12 = " align='center'";
                                break;
                            default:
                                str12 = " align='left'";
                                break;
                        }
                        if (Strings.Len(RuntimeHelpers.GetObjectValue(objArray2[index3, index4])) < 1)
                            str11 = "&nbsp;";
                        string str13 = "<b>" + str11 + "</b>";
                        string str14 = " width=" + strArray1[index4];
                        string str15 = "<td" + str12 + str14 + "><font size='3'" + str2 + ">" + str13 + "</td>";
                        streamWriter.Write(str15 + "\r\n");
                        checked { ++index4; }
                    }
                    streamWriter.Write("</tr>\r\n");
                    checked { ++index3; }
                }
                while (index3 <= 7);
                streamWriter.Write("</table>\r\n");
                int num6 = 4;
                string[] strArray2 = new string[5]
                {
          "'0'",
          "'100'",
          "'70'",
          "'70'",
          "'240'"
                };
                streamWriter.Write("<table border='0' cellspacing='0'" + str1 + ">\r\n");
                streamWriter.Write("<tr>\r\n");
                int index5 = 8;
                int num7 = num6;
                int index6 = 1;
                while (index6 <= num7)
                {
                    string str16 = !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objArray2[index5, index6])) ? Conversions.ToString(objArray2[index5, index6]) : (index6 != 2 ? Conversions.ToString(objArray2[index5, index6]) : Strings.Format(RuntimeHelpers.GetObjectValue(objArray2[index5, index6]), "#0.00"));
                    if (Strings.Len(RuntimeHelpers.GetObjectValue(objArray2[index5, index6])) < 1)
                        str16 = "&nbsp;";
                    string str17 = "<b>" + str16 + "</b>";
                    string str18 = "<td align='left' width=" + strArray2[index6] + "><font size='3'" + str2 + ">" + str17 + "</td>";
                    streamWriter.Write(str18 + "\r\n");
                    checked { ++index6; }
                }
                streamWriter.Write("</tr>\r\n");
                streamWriter.Write("</table>\r\n");
                int num8 = 1;
                int index7 = 1;
                do
                {
                    string segment5 = Program.Segment;
                    if (Operators.CompareString(segment5, "Seg1", false) == 0)
                    {
                        if (Program.Vek[index7].Startno_Seg1 == checked(StNo + num8))
                        {
                            if (!(Program.Vek[index7].DNS_Seg1 == 0 & Program.Vek[index7].Finished_Seg1 == 0))
                                checked { ++num8; }
                            else
                                break;
                        }
                    }
                    else if (Operators.CompareString(segment5, "Seg2", false) == 0 && Program.Vek[index7].Startno_Seg2 == checked(StNo + num8))
                    {
                        if (!(Program.Vek[index7].DNS_Seg2 == 0 & Program.Vek[index7].Finished_Seg2 == 0))
                            checked { ++num8; }
                        else
                            break;
                    }
                    checked { ++index7; }
                }
                while (index7 <= 42);
                if (index7 <= Program.TNop)
                {
                    string[] strArray3 = new string[2]
                    {
            "'0'",
            "'480'"
                    };
                    objArray2[20, 1] = (object)"NEXT SKATER";
                    objArray2[21, 1] = (object)(Program.Vek[index7].Name.FName + " " + Program.Vek[index7].Name.LName);
                    objArray2[22, 1] = (object)Program.Vek[index7].Club;
                    int num9 = 1;
                    streamWriter.Write("<br/>\r\n");
                    streamWriter.Write("<table border='0' cellspacing='0'" + str1 + ">\r\n");
                    int index8 = 20;
                    do
                    {
                        streamWriter.Write("<tr>\r\n");
                        int num10 = num9;
                        int index9 = 1;
                        while (index9 <= num10)
                        {
                            string str19 = Conversions.ToString(objArray2[index8, index9]);
                            if (Strings.Len(RuntimeHelpers.GetObjectValue(objArray2[index8, index9])) < 1)
                                str19 = "&nbsp;";
                            string str20 = "<b>" + str19 + "</b>";
                            string str21 = "<td align='left' width=" + strArray3[index9] + "><font size='3'" + str2 + ">" + str20 + "</td>";
                            streamWriter.Write(str21 + "\r\n");
                            checked { ++index9; }
                        }
                        streamWriter.Write("</tr>\r\n");
                        checked { ++index8; }
                    }
                    while (index8 <= 22);
                    streamWriter.Write("</table>\r\n");
                }
                streamWriter.Write("</body>\r\n");
                streamWriter.Write("</html>\r\n");
                streamWriter.Close();
                streamWriter.Dispose();
                goto label_105;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num11 = (int)Interaction.MsgBox((object)("MakeScoreBoard_12 - " + Information.Err().Description + "\r\n"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_105:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void MakeScoreBoard_34(int StNo)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string str1 = " bgcolor='#000000'";
                string str2 = " color='#FFFFFF'";
                object[,] objArray1 = new object[26, 8];
                ProjectData.ClearProjectError();
                num1 = 2;
                string pathResultsFile = Program.PathResultsFile;
                string str3 = "ScoreBoard.htm";
                object[,] objArray2 = new object[51, 10];
                switch (Program.CreateScoreBoard)
                {
                    case 1:
                    case 3:
                        str1 = " bgcolor='#000000'";
                        str2 = " color='#FFFFFF'";
                        break;
                    case 2:
                    case 4:
                        str1 = " bgcolor='#FFFFFF'";
                        str2 = " color='#000000'";
                        break;
                }
                string str4 = "Score Board";
                StreamWriter streamWriter = new StreamWriter(pathResultsFile + str3, false, Encoding.Default);
                streamWriter.Write("<html>\r\n");
                streamWriter.Write("<head>\r\n");
                streamWriter.Write("<title>ClubCompFS " + str4 + "</title>\r\n");
                streamWriter.Write("</head>\r\n");
                streamWriter.Write("<body" + str1 + ">\r\n");
                streamWriter.Write("<style type='text/css'>\r\n");
                streamWriter.Write("td { font-family: Arial}\r\n");
                streamWriter.Write("P { line-height : 50%; }\r\n");
                streamWriter.Write("</style>\r\n");
                streamWriter.Write("<table border='0' cellspacing='0'" + str1 + ">\r\n");
                string segment1 = Program.Segment;
                int Pno = 0;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    Pno = 1;
                    while (Program.Vek[Pno].Startno_Seg1 != StNo)
                    {
                        checked { ++Pno; }
                        if (Pno > 42)
                            break;
                    }
                }
                else if (Operators.CompareString(segment1, "Seg2", false) == 0)
                {
                    Pno = 1;
                    while (Program.Vek[Pno].Startno_Seg2 != StNo)
                    {
                        checked { ++Pno; }
                        if (Pno > 42)
                            break;
                    }
                }
                string str5 = Strings.UCase(Program.GetCat() + ", " + Program.GetSegTxt(Program.Segment));
                streamWriter.Write("<tr>\r\n");
                string str6 = "<b>" + str5 + "</b>";
                string str7 = "<td align='center' width='410'><font size='3'" + str2 + ">" + str6 + "</td>";
                streamWriter.Write(str7 + "\r\n");
                streamWriter.Write("</tr>\r\n");
                streamWriter.Write("</table>\r\n");
                int num3 = 0;
                if (Pno <= Program.TNop)
                {
                    objArray2[3, 1] = (object)("RESULTS FOR: " + Program.Vek[Pno].Name.FName + " " + Program.Vek[Pno].Name.LName);
                    string[] strArray = new string[2]
                    {
            "'0'",
            "'410'"
                    };
                    num3 = 1;
                    streamWriter.Write("<table border='0' cellspacing='0'" + str1 + ">\r\n");
                    int index1 = 3;
                    do
                    {
                        streamWriter.Write("<tr>\r\n");
                        int num4 = num3;
                        int index2 = 1;
                        while (index2 <= num4)
                        {
                            string str8 = Conversions.ToString(objArray2[index1, index2]);
                            if (Strings.Len(RuntimeHelpers.GetObjectValue(objArray2[index1, index2])) < 1)
                                str8 = "&nbsp;";
                            string str9 = "<b>" + str8 + "</b>";
                            string str10 = "<td align='left' width=" + strArray[index2] + "><font size='3'" + str2 + ">" + str9 + "</td>";
                            streamWriter.Write(str10 + "\r\n");
                            checked { ++index2; }
                        }
                        streamWriter.Write("</tr>\r\n");
                        checked { ++index1; }
                    }
                    while (index1 <= 3);
                    streamWriter.Write("</table>\r\n");
                }
                objArray2[6, 3] = (object)"TES";
                objArray2[6, 4] = (object)"PCS";
                objArray2[6, 5] = (object)"DED";
                string seg = Program.GetSeg();
                if (Operators.CompareString(seg, "0F", false) == 0)
                {
                    objArray2[7, 1] = (object)"FREE:";
                    objArray2[7, 2] = (object)Program.Vek[Pno].Score_Seg2;
                    objArray2[7, 3] = (object)Program.Vek[Pno].TES_Seg2;
                    objArray2[7, 4] = (object)Program.Vek[Pno].PCS_Seg2;
                    objArray2[7, 5] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                    if (Program.Bonus_Sel("Seg2"))
                    {
                        objArray2[6, 6] = (object)"BON";
                        objArray2[7, 6] = (object)Program.Vek[Pno].Bonus_Seg2;
                        num3 = 6;
                    }
                    else
                        num3 = 5;
                    objArray2[8, 1] = (object)"TOTAL:";
                    objArray2[8, 2] = (object)Program.Vek[Pno].Score_Seg2;
                    objArray2[8, 3] = (object)("CURRENT STANDING:  " + Conversions.ToString(Program.Vek[Pno].Place_Seg2));
                }
                else if (Operators.CompareString(seg, "SF", false) == 0)
                {
                    string segment2 = Program.Segment;
                    if (Operators.CompareString(segment2, "Seg1", false) == 0)
                    {
                        objArray2[7, 1] = (object)"SHORT:";
                        objArray2[7, 2] = (object)Program.Vek[Pno].Score_Seg1;
                        objArray2[7, 3] = (object)Program.Vek[Pno].TES_Seg1;
                        objArray2[7, 4] = (object)Program.Vek[Pno].PCS_Seg1;
                        objArray2[7, 5] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                        if (Program.Bonus_Sel("Seg1"))
                        {
                            objArray2[6, 6] = (object)"BON";
                            objArray2[7, 6] = (object)Program.Vek[Pno].Bonus_Seg1;
                            num3 = 6;
                        }
                        else
                            num3 = 5;
                        objArray2[8, 3] = (object)("CURRENT STANDING:  " + Conversions.ToString(Program.Vek[Pno].Place_Seg1));
                    }
                    else if (Operators.CompareString(segment2, "Seg2", false) == 0)
                    {
                        objArray2[6, 1] = (object)"SHORT:";
                        objArray2[6, 2] = (object)Program.Vek[Pno].Score_Seg1;
                        objArray2[6, 6] = (object)"BON";
                        objArray2[7, 1] = (object)"FREE:";
                        objArray2[7, 2] = (object)Program.Vek[Pno].Score_Seg2;
                        objArray2[7, 3] = (object)Program.Vek[Pno].TES_Seg2;
                        objArray2[7, 4] = (object)Program.Vek[Pno].PCS_Seg2;
                        objArray2[7, 5] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                        if (Program.Bonus_Sel("Seg2"))
                        {
                            objArray2[6, 6] = (object)"BON";
                            objArray2[7, 6] = (object)Program.Vek[Pno].Bonus_Seg2;
                            num3 = 6;
                        }
                        else
                            num3 = 5;
                        objArray2[8, 1] = (object)"TOTAL:";
                        objArray2[8, 2] = (object)Program.Vek[Pno].Score_Total;
                        objArray2[8, 3] = (object)("CURRENT STANDING:  " + Conversions.ToString(Program.Vek[Pno].Place));
                    }
                }
                else if (Operators.CompareString(seg, "FF", false) == 0)
                {
                    string segment3 = Program.Segment;
                    if (Operators.CompareString(segment3, "Seg1", false) == 0)
                    {
                        objArray2[7, 1] = (object)"FREE:";
                        objArray2[7, 2] = (object)Program.Vek[Pno].Score_Seg1;
                        objArray2[7, 3] = (object)Program.Vek[Pno].TES_Seg1;
                        objArray2[7, 4] = (object)Program.Vek[Pno].PCS_Seg1;
                        objArray2[7, 5] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                        if (Program.Bonus_Sel("Seg1"))
                        {
                            objArray2[6, 6] = (object)"BON";
                            objArray2[7, 6] = (object)Program.Vek[Pno].Bonus_Seg1;
                            num3 = 6;
                        }
                        else
                            num3 = 5;
                        objArray2[8, 3] = (object)("CURRENT STANDING:  " + Conversions.ToString(Program.Vek[Pno].Place_Seg1));
                    }
                    else if (Operators.CompareString(segment3, "Seg2", false) == 0)
                    {
                        objArray2[6, 1] = (object)"FREE:";
                        objArray2[6, 2] = (object)Program.Vek[Pno].Score_Seg1;
                        objArray2[7, 1] = (object)"FREE:";
                        objArray2[7, 2] = (object)Program.Vek[Pno].Score_Seg2;
                        objArray2[7, 3] = (object)Program.Vek[Pno].TES_Seg2;
                        objArray2[7, 4] = (object)Program.Vek[Pno].PCS_Seg2;
                        objArray2[7, 5] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                        if (Program.Bonus_Sel("Seg2"))
                        {
                            objArray2[6, 6] = (object)"BON";
                            objArray2[7, 6] = (object)Program.Vek[Pno].Bonus_Seg2;
                            num3 = 6;
                        }
                        else
                            num3 = 5;
                        objArray2[8, 1] = (object)"TOTAL:";
                        objArray2[8, 2] = (object)Program.Vek[Pno].Score_Total;
                        objArray2[8, 3] = (object)("CURRENT STANDING:  " + Conversions.ToString(Program.Vek[Pno].Place));
                    }
                }
                else if (Operators.CompareString(seg, "SS", false) == 0)
                {
                    string segment4 = Program.Segment;
                    if (Operators.CompareString(segment4, "Seg1", false) == 0)
                    {
                        objArray2[6, 7] = (object)"BON";
                        objArray2[7, 1] = (object)"SHORT:";
                        objArray2[7, 2] = (object)Program.Vek[Pno].Score_Seg1;
                        objArray2[7, 3] = (object)Program.Vek[Pno].TES_Seg1;
                        objArray2[7, 4] = (object)Program.Vek[Pno].PCS_Seg1;
                        objArray2[7, 5] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                        if (Program.Bonus_Sel("Seg1"))
                        {
                            objArray2[6, 6] = (object)"BON";
                            objArray2[7, 6] = (object)Program.Vek[Pno].Bonus_Seg1;
                            num3 = 6;
                        }
                        else
                            num3 = 5;
                        objArray2[8, 3] = (object)("CURRENT STANDING:  " + Conversions.ToString(Program.Vek[Pno].Place_Seg1));
                    }
                    else if (Operators.CompareString(segment4, "Seg2", false) == 0)
                    {
                        objArray2[6, 1] = (object)"SHORT:";
                        objArray2[6, 2] = (object)Program.Vek[Pno].Score_Seg1;
                        objArray2[7, 1] = (object)"FREE:";
                        objArray2[7, 2] = (object)Program.Vek[Pno].Score_Seg2;
                        objArray2[7, 3] = (object)Program.Vek[Pno].TES_Seg2;
                        objArray2[7, 4] = (object)Program.Vek[Pno].PCS_Seg2;
                        objArray2[7, 5] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                        if (Program.Bonus_Sel("Seg2"))
                        {
                            objArray2[6, 6] = (object)"BON";
                            objArray2[7, 6] = (object)Program.Vek[Pno].Bonus_Seg2;
                            num3 = 6;
                        }
                        else
                            num3 = 5;
                        objArray2[8, 1] = (object)"TOTAL:";
                        objArray2[8, 2] = (object)Program.Vek[Pno].Score_Total;
                        objArray2[8, 3] = (object)("CURRENT STANDING:  " + Conversions.ToString(Program.Vek[Pno].Place));
                    }
                }
                string[] strArray1 = new string[7]
                {
          "'0'",
          "'100'",
          "'70'",
          "'70'",
          "'70'",
          "'50'",
          "'50'"
                };
                streamWriter.Write("<table border='0' cellspacing='0'" + str1 + ">\r\n");
                int index3 = 6;
                do
                {
                    streamWriter.Write("<tr>\r\n");
                    int num5 = num3;
                    int index4 = 1;
                    while (index4 <= num5)
                    {
                        string str11;
                        if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objArray2[index3, index4])))
                        {
                            switch (index4)
                            {
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                    str11 = Strings.Format(RuntimeHelpers.GetObjectValue(objArray2[index3, index4]), "#0.00");
                                    break;
                                case 6:
                                case 7:
                                    str11 = Strings.Format(RuntimeHelpers.GetObjectValue(objArray2[index3, index4]), "#0.0");
                                    break;
                                default:
                                    str11 = Conversions.ToString(objArray2[index3, index4]);
                                    break;
                            }
                        }
                        else
                            str11 = Conversions.ToString(objArray2[index3, index4]);
                        string str12;
                        switch (index4)
                        {
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                                str12 = " align='left'";
                                break;
                            case 6:
                            case 7:
                                str12 = " align='center'";
                                break;
                            default:
                                str12 = " align='left'";
                                break;
                        }
                        if (Strings.Len(RuntimeHelpers.GetObjectValue(objArray2[index3, index4])) < 1)
                            str11 = "&nbsp;";
                        string str13 = "<b>" + str11 + "</b>";
                        string str14 = " width=" + strArray1[index4];
                        string str15 = "<td" + str12 + str14 + "><font size='3'" + str2 + ">" + str13 + "</td>";
                        streamWriter.Write(str15 + "\r\n");
                        checked { ++index4; }
                    }
                    streamWriter.Write("</tr>\r\n");
                    checked { ++index3; }
                }
                while (index3 <= 7);
                streamWriter.Write("</table>\r\n");
                int num6 = 3;
                string[] strArray2 = new string[4]
                {
          "'0'",
          "'100'",
          "'70'",
          "'240'"
                };
                streamWriter.Write("<table border='0' cellspacing='0'" + str1 + ">\r\n");
                streamWriter.Write("<tr>\r\n");
                int index5 = 8;
                int num7 = num6;
                int index6 = 1;
                while (index6 <= num7)
                {
                    string str16 = !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objArray2[index5, index6])) ? Conversions.ToString(objArray2[index5, index6]) : (index6 != 2 ? Conversions.ToString(objArray2[index5, index6]) : Strings.Format(RuntimeHelpers.GetObjectValue(objArray2[index5, index6]), "#0.00"));
                    if (Strings.Len(RuntimeHelpers.GetObjectValue(objArray2[index5, index6])) < 1)
                        str16 = "&nbsp;";
                    string str17 = "<b>" + str16 + "</b>";
                    string str18 = "<td align='left' width=" + strArray2[index6] + "><font size='3'" + str2 + ">" + str17 + "</td>";
                    streamWriter.Write(str18 + "\r\n");
                    checked { ++index6; }
                }
                streamWriter.Write("</tr>\r\n");
                streamWriter.Write("</table>\r\n");
                int num8 = 1;
                int index7 = 1;
                do
                {
                    string segment5 = Program.Segment;
                    if (Operators.CompareString(segment5, "Seg1", false) == 0)
                    {
                        if (Program.Vek[index7].Startno_Seg1 == checked(StNo + num8))
                        {
                            if (!(Program.Vek[index7].DNS_Seg1 == 0 & Program.Vek[index7].Finished_Seg1 == 0))
                                checked { ++num8; }
                            else
                                break;
                        }
                    }
                    else if (Operators.CompareString(segment5, "Seg2", false) == 0 && Program.Vek[index7].Startno_Seg2 == checked(StNo + num8))
                    {
                        if (!(Program.Vek[index7].DNS_Seg2 == 0 & Program.Vek[index7].Finished_Seg2 == 0))
                            checked { ++num8; }
                        else
                            break;
                    }
                    checked { ++index7; }
                }
                while (index7 <= 42);
                if (index7 <= Program.TNop)
                {
                    string[] strArray3 = new string[2]
                    {
            "'0'",
            "'410'"
                    };
                    objArray2[20, 1] = (object)("NEXT SKATER: " + Program.Vek[index7].Name.FName + " " + Program.Vek[index7].Name.LName);
                    int num9 = 1;
                    streamWriter.Write("<p>\r\n");
                    streamWriter.Write("<table border='0' cellspacing='0'" + str1 + ">\r\n");
                    int index8 = 20;
                    do
                    {
                        streamWriter.Write("<tr>\r\n");
                        int num10 = num9;
                        int index9 = 1;
                        while (index9 <= num10)
                        {
                            string str19 = Conversions.ToString(objArray2[index8, index9]);
                            if (Strings.Len(RuntimeHelpers.GetObjectValue(objArray2[index8, index9])) < 1)
                                str19 = "&nbsp;";
                            string str20 = "<b>" + str19 + "</b>";
                            string str21 = "<td align='left' width=" + strArray3[index9] + "><font size='3'" + str2 + ">" + str20 + "</td>";
                            streamWriter.Write(str21 + "\r\n");
                            checked { ++index9; }
                        }
                        streamWriter.Write("</tr>\r\n");
                        checked { ++index8; }
                    }
                    while (index8 <= 20);
                    streamWriter.Write("</table>\r\n");
                }
                streamWriter.Write("</body>\r\n");
                streamWriter.Write("</html>\r\n");
                streamWriter.Close();
                streamWriter.Dispose();
                goto label_105;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num11 = (int)Interaction.MsgBox((object)("MakeScoreBoard_34 - " + Information.Err().Description + "\r\n"), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_105:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void MakeTEScore(string TE_Leader, string BaseValue, string TEScores)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string pathResultsFile = Program.PathResultsFile;
                string str1 = " bgcolor='#000000'";
                string str2 = " color='#FFFFFF'";
                int num3 = 1;
                ProjectData.ClearProjectError();
                num1 = 2;
                switch (num3)
                {
                    case 1:
                    case 3:
                        str1 = " bgcolor='#000000'";
                        str2 = " color='#FFFFFF'";
                        break;
                    case 2:
                    case 4:
                        str1 = " bgcolor='#FFFFFF'";
                        str2 = " color='#000000'";
                        break;
                }
                string str3 = Conversions.ToInteger(TEScores) >= 1 ? TEScores : BaseValue;
                StreamWriter streamWriter = new StreamWriter(pathResultsFile + "TEScores.htm", false, Encoding.Default);
                streamWriter.Write("<html>\r\n");
                streamWriter.Write("<head>\r\n");
                streamWriter.Write("<title>ClubCompFS Score</title>\r\n");
                streamWriter.Write("</head>\r\n");
                streamWriter.Write("<body>\r\n");
                string[] strArray = new string[3]
                {
          "'0'",
          "'100'",
          "'70'"
                };
                int index = 1;
                do
                {
                    strArray[index] = " width=" + strArray[index];
                    checked { ++index; }
                }
                while (index <= 2);
                string str4 = " width=" + Conversions.ToString(170);
                if (Program.TNop > 0)
                {
                    streamWriter.Write("<table border='2' cellspacing='0'" + str2 + str1 + ">\r\n");
                    streamWriter.Write("<tr>\r\n");
                    streamWriter.Write("<td colspan='2' align='left'" + str4 + "><font size='3'" + str2 + "><b>&nbsp;TECHNICAL SCORE</b></td>\r\n");
                    streamWriter.Write("</tr>\r\n");
                    if (Conversions.ToInteger(TE_Leader) > 1)
                    {
                        streamWriter.Write("<tr>\r\n");
                        streamWriter.Write("<td align='left'" + strArray[1] + "><font size='3'" + str2 + "><b>&nbsp;LEADER</b></td>\r\n");
                        streamWriter.Write("<td align='center'" + strArray[2] + "><font size='3'" + str2 + "><b>" + TE_Leader + "</b></td>\r\n");
                        streamWriter.Write("</tr>\r\n");
                    }
                    streamWriter.Write("<tr>\r\n");
                    streamWriter.Write("<td align='left'" + strArray[1] + "><font size='3'" + str2 + "><b>&nbsp;CURRENT</b></td>\r\n");
                    streamWriter.Write("<td align='center'" + strArray[2] + "><font size='3'" + str2 + "><b>" + str3 + "</b></td>\r\n");
                    streamWriter.Write("</tr>\r\n");
                    streamWriter.Write("</table><br />\r\n");
                }
                streamWriter.Write("</body>\r\n");
                streamWriter.Write("</html>\r\n");
                streamWriter.Close();
                streamWriter.Dispose();
                goto label_16;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("MakeTEScore - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_16:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public static void CreateLiveArr(int Stno)
        {
            Program.TArrLive = (object[,])null;
            Program.TArrLive = new object[51, 10];
            string seg = Program.GetSeg();
            if (Operators.CompareString(seg, "0F", false) == 0)
            {
                int Pno = 1;
                while (Program.Vek[Pno].Startno_Seg2 != Stno)
                {
                    checked { ++Pno; }
                    if (Pno > 42)
                        break;
                }
                Program.TArrLive[1, 1] = (object)Program.Vek[Pno].Place_Seg2;
                Program.TArrLive[1, 2] = (object)Program.Vek[Pno].Startno_Seg2;
                Program.TArrLive[1, 3] = (object)(Program.Vek[Pno].Name.FName + " " + Program.Vek[Pno].Name.LName);
                Program.TArrLive[1, 4] = (object)Program.Vek[Pno].Club;
                switch (Program.Vek[Pno].DNS_Seg2)
                {
                    case 0:
                        Program.TArrLive[1, 5] = (object)Program.Vek[Pno].Score_Seg2;
                        Program.TArrLive[1, 6] = (object)Program.Vek[Pno].TES_Seg2;
                        Program.TArrLive[1, 7] = (object)Program.Vek[Pno].PCS_Seg2;
                        Program.TArrLive[1, 8] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                        Program.TArrLive[1, 9] = (object)Program.Vek[Pno].Bonus_Seg2;
                        break;
                    case 1:
                        Program.TArrLive[1, 5] = (object)"DNS";
                        break;
                    case 2:
                        Program.TArrLive[1, 5] = (object)"WD";
                        break;
                    case 3:
                        Program.TArrLive[1, 5] = (object)"DNF";
                        break;
                    case 4:
                        Program.TArrLive[1, 5] = (object)"DQ";
                        break;
                }
            }
            else if (Operators.CompareString(seg, "S0", false) == 0 || Operators.CompareString(seg, "F0", false) == 0)
            {
                if (Operators.CompareString(Program.Segment, "Seg1", false) != 0)
                    return;
                int Pno = 1;
                while (Program.Vek[Pno].Startno_Seg1 != Stno)
                {
                    checked { ++Pno; }
                    if (Pno > 42)
                        break;
                }
                Program.TArrLive[1, 1] = (object)Program.Vek[Pno].Place_Seg1;
                Program.TArrLive[1, 2] = (object)Program.Vek[Pno].Startno_Seg1;
                Program.TArrLive[1, 3] = (object)(Program.Vek[Pno].Name.FName + " " + Program.Vek[Pno].Name.LName);
                Program.TArrLive[1, 4] = (object)Program.Vek[Pno].Club;
                switch (Program.Vek[Pno].DNS_Seg1)
                {
                    case 0:
                        Program.TArrLive[1, 5] = (object)Program.Vek[Pno].Score_Seg1;
                        Program.TArrLive[1, 6] = (object)Program.Vek[Pno].TES_Seg1;
                        Program.TArrLive[1, 7] = (object)Program.Vek[Pno].PCS_Seg1;
                        Program.TArrLive[1, 8] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                        Program.TArrLive[1, 9] = (object)Program.Vek[Pno].Bonus_Seg1;
                        break;
                    case 1:
                        Program.TArrLive[1, 5] = (object)"DNS";
                        break;
                    case 2:
                        Program.TArrLive[1, 5] = (object)"WD";
                        break;
                    case 3:
                        Program.TArrLive[1, 5] = (object)"DNF";
                        break;
                    case 4:
                        Program.TArrLive[1, 5] = (object)"DQ";
                        break;
                }
            }
            else
            {
                if (Operators.CompareString(seg, "FF", false) != 0 && Operators.CompareString(seg, "SS", false) != 0 && Operators.CompareString(seg, "SF", false) != 0)
                    return;
                string segment = Program.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    int Pno = 1;
                    while (Program.Vek[Pno].Startno_Seg1 != Stno)
                    {
                        checked { ++Pno; }
                        if (Pno > 42)
                            break;
                    }
                    Program.TArrLive[1, 1] = (object)Program.Vek[Pno].Place_Seg1;
                    Program.TArrLive[1, 2] = (object)Program.Vek[Pno].Startno_Seg1;
                    Program.TArrLive[1, 3] = (object)(Program.Vek[Pno].Name.FName + " " + Program.Vek[Pno].Name.LName);
                    Program.TArrLive[1, 4] = (object)Program.Vek[Pno].Club;
                    switch (Program.Vek[Pno].DNS_Seg1)
                    {
                        case 0:
                            Program.TArrLive[1, 5] = (object)Program.Vek[Pno].Score_Seg1;
                            Program.TArrLive[1, 6] = (object)Program.Vek[Pno].TES_Seg1;
                            Program.TArrLive[1, 7] = (object)Program.Vek[Pno].PCS_Seg1;
                            Program.TArrLive[1, 8] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                            Program.TArrLive[1, 9] = (object)Program.Vek[Pno].Bonus_Seg1;
                            break;
                        case 1:
                            Program.TArrLive[1, 5] = (object)"DNS";
                            break;
                        case 2:
                            Program.TArrLive[1, 5] = (object)"WD";
                            break;
                        case 3:
                            Program.TArrLive[1, 5] = (object)"DNF";
                            break;
                        case 4:
                            Program.TArrLive[1, 5] = (object)"DQ";
                            break;
                    }
                }
                else
                {
                    if (Operators.CompareString(segment, "Seg2", false) != 0)
                        return;
                    int Pno = 1;
                    while (Program.Vek[Pno].Startno_Seg2 != Stno)
                    {
                        checked { ++Pno; }
                        if (Pno > 42)
                            break;
                    }
                    Program.TArrLive[1, 1] = (object)Program.Vek[Pno].Place_Seg2;
                    Program.TArrLive[1, 2] = (object)Program.Vek[Pno].Startno_Seg2;
                    Program.TArrLive[1, 3] = (object)(Program.Vek[Pno].Name.FName + " " + Program.Vek[Pno].Name.LName);
                    Program.TArrLive[1, 4] = (object)Program.Vek[Pno].Club;
                    switch (Program.Vek[Pno].DNS_Seg2)
                    {
                        case 0:
                            Program.TArrLive[1, 5] = (object)Program.Vek[Pno].Score_Seg2;
                            Program.TArrLive[1, 6] = (object)Program.Vek[Pno].TES_Seg2;
                            Program.TArrLive[1, 7] = (object)Program.Vek[Pno].PCS_Seg2;
                            Program.TArrLive[1, 8] = (object)Program.DedSeg1Seg2(Pno, Program.Segment);
                            Program.TArrLive[1, 9] = (object)Program.Vek[Pno].Bonus_Seg2;
                            break;
                        case 1:
                            Program.TArrLive[1, 5] = (object)"DNS";
                            break;
                        case 2:
                            Program.TArrLive[1, 5] = (object)"WD";
                            break;
                        case 3:
                            Program.TArrLive[1, 5] = (object)"DNF";
                            break;
                        case 4:
                            Program.TArrLive[1, 5] = (object)"DQ";
                            break;
                    }
                    Program.TArrLive[2, 1] = (object)Program.Vek[Pno].Place;
                    Program.TArrLive[2, 2] = (object)Program.Vek[Pno].Startno_Seg2;
                    Program.TArrLive[2, 3] = (object)(Program.Vek[Pno].Name.FName + " " + Program.Vek[Pno].Name.LName);
                    Program.TArrLive[2, 4] = (object)Program.Vek[Pno].Club;
                    switch (Program.Vek[Pno].DNS_Seg2)
                    {
                        case 0:
                            Program.TArrLive[2, 5] = (object)Program.Vek[Pno].Score_Total;
                            Program.TArrLive[2, 6] = (object)Program.Vek[Pno].Score_Seg1;
                            Program.TArrLive[2, 7] = (object)Program.Vek[Pno].Score_Seg2;
                            break;
                        case 1:
                            Program.TArrLive[2, 5] = (object)"DNS";
                            break;
                        case 2:
                            Program.TArrLive[2, 5] = (object)"WD";
                            break;
                        case 3:
                            Program.TArrLive[2, 5] = (object)"DNF";
                            break;
                        case 4:
                            Program.TArrLive[1, 5] = (object)"DQ";
                            break;
                    }
                }
            }
        }

        public static void CreateResultArr(ref int Row)
        {
            Program.TArrResult = (object[,])null;
            Program.TArrResult = new object[51, 10];
            string seg = Program.GetSeg();
            if (Operators.CompareString(seg, "0F", false) == 0)
            {
                Row = 1;
                int tnop = Program.TNop;
                int index = 1;
                while (index <= tnop)
                {
                    if ((Program.Vek[index].Finished_Seg2 == 1 | Program.Vek[index].DNS_Seg2 > 0) & Program.Vek[index].Startno_Seg2 > 0)
                    {
                        checked { ++Row; }
                        Program.TArrResult[Row, 1] = (object)Program.Vek[index].Place_Seg2;
                        Program.TArrResult[Row, 2] = (object)Program.Vek[index].Startno_Seg2;
                        Program.TArrResult[Row, 3] = (object)(Program.Vek[index].Name.FName + " " + Program.Vek[index].Name.LName);
                        Program.TArrResult[Row, 4] = (object)Program.Vek[index].Club;
                        switch (Program.Vek[index].DNS_Seg2)
                        {
                            case 0:
                                Program.TArrResult[Row, 5] = (object)Program.Vek[index].Score_Seg2;
                                break;
                            case 1:
                                Program.TArrResult[Row, 5] = (object)"DNS";
                                break;
                            case 2:
                                Program.TArrResult[Row, 5] = (object)"WD";
                                break;
                            case 3:
                                Program.TArrResult[Row, 5] = (object)"DNF";
                                break;
                            case 4:
                                Program.TArrResult[Row, 5] = (object)"DQ";
                                break;
                        }
                    }
                    checked { ++index; }
                }
            }
            else if (Operators.CompareString(seg, "S0", false) == 0 || Operators.CompareString(seg, "F0", false) == 0)
            {
                if (Operators.CompareString(Program.Segment, "Seg1", false) != 0)
                    return;
                Row = 1;
                int tnop = Program.TNop;
                int index = 1;
                while (index <= tnop)
                {
                    if ((Program.Vek[index].Finished_Seg1 == 1 | Program.Vek[index].DNS_Seg1 > 0) & Program.Vek[index].Startno_Seg1 > 0)
                    {
                        checked { ++Row; }
                        Program.TArrResult[Row, 1] = (object)Program.Vek[index].Place_Seg1;
                        Program.TArrResult[Row, 2] = (object)Program.Vek[index].Startno_Seg1;
                        Program.TArrResult[Row, 3] = (object)(Program.Vek[index].Name.FName + " " + Program.Vek[index].Name.LName);
                        Program.TArrResult[Row, 4] = (object)Program.Vek[index].Club;
                        switch (Program.Vek[index].DNS_Seg1)
                        {
                            case 0:
                                Program.TArrResult[Row, 5] = (object)Program.Vek[index].Score_Seg1;
                                break;
                            case 1:
                                Program.TArrResult[Row, 5] = (object)"DNS";
                                break;
                            case 2:
                                Program.TArrResult[Row, 5] = (object)"WD";
                                break;
                            case 3:
                                Program.TArrResult[Row, 5] = (object)"DNF";
                                break;
                            case 4:
                                Program.TArrResult[Row, 5] = (object)"DQ";
                                break;
                        }
                    }
                    checked { ++index; }
                }
            }
            else
            {
                if (Operators.CompareString(seg, "SF", false) != 0 && Operators.CompareString(seg, "FF", false) != 0 && Operators.CompareString(seg, "SS", false) != 0)
                    return;
                string segment = Program.Segment;
                if (Operators.CompareString(segment, "Seg1", false) == 0)
                {
                    Row = 1;
                    int tnop = Program.TNop;
                    int index = 1;
                    while (index <= tnop)
                    {
                        if ((Program.Vek[index].Finished_Seg1 == 1 | Program.Vek[index].DNS_Seg1 > 0) & Program.Vek[index].Startno_Seg1 > 0)
                        {
                            checked { ++Row; }
                            Program.TArrResult[Row, 1] = (object)Program.Vek[index].Place_Seg1;
                            Program.TArrResult[Row, 2] = (object)Program.Vek[index].Startno_Seg1;
                            Program.TArrResult[Row, 3] = (object)(Program.Vek[index].Name.FName + " " + Program.Vek[index].Name.LName);
                            Program.TArrResult[Row, 4] = (object)Program.Vek[index].Club;
                            switch (Program.Vek[index].DNS_Seg1)
                            {
                                case 0:
                                    Program.TArrResult[Row, 5] = (object)Program.Vek[index].Score_Seg1;
                                    break;
                                case 1:
                                    Program.TArrResult[Row, 5] = (object)"DNS";
                                    break;
                                case 2:
                                    Program.TArrResult[Row, 5] = (object)"WD";
                                    break;
                                case 3:
                                    Program.TArrResult[Row, 5] = (object)"DNF";
                                    break;
                                case 4:
                                    Program.TArrResult[Row, 5] = (object)"DQ";
                                    break;
                            }
                        }
                        checked { ++index; }
                    }
                }
                else
                {
                    if (Operators.CompareString(segment, "Seg2", false) != 0)
                        return;
                    Row = 1;
                    int tnop = Program.TNop;
                    int index = 1;
                    while (index <= tnop)
                    {
                        if (Program.Vek[index].DNS_Seg1 == 0 && Program.Vek[index].Finished_Seg2 == 1 & Program.Vek[index].Finished_Seg1 == 1 | Program.Vek[index].DNS_Seg2 > 0)
                        {
                            checked { ++Row; }
                            Program.TArrResult[Row, 1] = (object)Program.Vek[index].Place;
                            Program.TArrResult[Row, 2] = (object)Program.Vek[index].Startno_Seg2;
                            Program.TArrResult[Row, 3] = (object)(Program.Vek[index].Name.FName + " " + Program.Vek[index].Name.LName);
                            Program.TArrResult[Row, 4] = (object)Program.Vek[index].Club;
                            switch (Program.Vek[index].DNS_Seg2)
                            {
                                case 0:
                                    Program.TArrResult[Row, 5] = (object)Program.Vek[index].Score_Total;
                                    Program.TArrResult[Row, 6] = (object)Program.Vek[index].Place_Seg1;
                                    Program.TArrResult[Row, 7] = (object)Program.Vek[index].Place_Seg2;
                                    break;
                                case 1:
                                    Program.TArrResult[Row, 5] = (object)"DNS";
                                    Program.TArrResult[Row, 6] = (object)Program.Vek[index].Place_Seg1;
                                    break;
                                case 2:
                                    Program.TArrResult[Row, 5] = (object)"WD";
                                    Program.TArrResult[Row, 6] = (object)Program.Vek[index].Place_Seg1;
                                    break;
                                case 3:
                                    Program.TArrResult[Row, 5] = (object)"DNF";
                                    Program.TArrResult[Row, 6] = (object)Program.Vek[index].Place_Seg1;
                                    break;
                                case 4:
                                    Program.TArrResult[Row, 5] = (object)"DQ";
                                    Program.TArrResult[Row, 6] = (object)Program.Vek[index].Place_Seg1;
                                    break;
                            }
                        }
                        checked { ++index; }
                    }
                }
            }
        }

        public static void CreateNextArr(ref int row)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                int num3 = 1;
                int num4 = 0;
                ProjectData.ClearProjectError();
                num1 = 1;
                num3 = 3;
                Program.TArrNext = (object[,])null;
                num3 = 4;
                Program.TArrNext = new object[51, 10];
                num3 = 7;
                string segment1 = Program.Segment;
                num3 = 10;
                if (Operators.CompareString(segment1, "Seg1", false) == 0)
                {
                    num3 = 11;
                    int index = 1;
                    do
                    {
                        num3 = 12;
                        if (Program.Vek[index].DNS_Seg1 > 0 & Program.Vek[index].Startno_Seg1 == 0)
                        {
                            num3 = 13;
                            checked { ++num4; }
                        }
                        num3 = 15;
                        checked { ++index; }
                    }
                    while (index <= 42);
                }
                else
                {
                    num3 = 17;
                    if (Operators.CompareString(segment1, "Seg2", false) == 0)
                    {
                        num3 = 18;
                        int index = 1;
                        do
                        {
                            num3 = 19;
                            if (Program.Vek[index].DNS_Seg1 > 0)
                            {
                                num3 = 20;
                                checked { ++num4; }
                            }
                            num3 = 22;
                            checked { ++index; }
                        }
                        while (index <= 42);
                    }
                }
                num3 = 24;
                if (checked(Program.TNop - num4) > 0)
                {
                    num3 = 25;
                    Program.SortListStartNo(Program.TNop);
                    num3 = 26;
                    row = 1;
                    num3 = 27;
                    int tnop = Program.TNop;
                    int R = 1;
                    while (R <= tnop)
                    {
                        num3 = 28;
                        string seg = Program.GetSeg();
                        num3 = 31;
                        if (Operators.CompareString(seg, "0F", false) == 0)
                        {
                            num3 = 32;
                            if (R > 2)
                            {
                                num3 = 33;
                                if (Program.Vek[R].WarmUp_Seg2 > Program.Vek[checked(R - 1)].WarmUp_Seg2 & Program.Vek[R].Finished_Seg2 == 0)
                                {
                                    num3 = 34;
                                    if (Program.FinishedRestSeg2(R) == 0)
                                    {
                                        num3 = 35;
                                        checked { ++row; }
                                        num3 = 36;
                                        int index = 1;
                                        do
                                        {
                                            num3 = 37;
                                            if (Program.Vek[checked(R - 1)].Startno_Seg2 == Program.IceArr_Seg2[index] & Program.Vek[checked(R - 1)].DNS_Seg2 == 0)
                                            {
                                                num3 = 38;
                                                Program.TArrNext[row, 3] = (object)"ICE RESURFACING";
                                            }
                                            num3 = 40;
                                            if (Program.Vek[checked(R - 1)].Startno_Seg2 == Program.LunchArr_Seg2[index] & Program.Vek[checked(R - 1)].DNS_Seg2 == 0)
                                            {
                                                num3 = 41;
                                                Program.TArrNext[row, 3] = (object)"MEAL BREAK";
                                            }
                                            num3 = 43;
                                            checked { ++index; }
                                        }
                                        while (index <= 6);
                                        num3 = 44;
                                        if (Strings.Len(RuntimeHelpers.GetObjectValue(Program.TArrNext[row, 3])) < 1)
                                        {
                                            num3 = 45;
                                            Program.TArrNext[row, 3] = (object)"WARM UP";
                                        }
                                    }
                                }
                            }
                            num3 = 50;
                            if (Program.Vek[R].DNS_Seg2 == 0 & Program.Vek[R].Finished_Seg2 == 0)
                            {
                                num3 = 51;
                                checked { ++row; }
                                num3 = 52;
                                Program.TArrNext[row, 1] = (object)Conversions.ToString(Program.Vek[R].Startno_Seg2);
                                num3 = 53;
                                if (Program.Vek[R].WarmUp_Seg2 > 0)
                                {
                                    num3 = 54;
                                    Program.TArrNext[row, 2] = (object)Conversions.ToString(Program.Vek[R].WarmUp_Seg2);
                                }
                                else
                                {
                                    num3 = 56;
                                    num3 = 57;
                                    Program.TArrNext[row, 2] = (object)"-";
                                }
                                num3 = 59;
                                Program.TArrNext[row, 3] = (object)(Program.Vek[R].Name.FName + " " + Program.Vek[R].Name.LName);
                                num3 = 60;
                                Program.TArrNext[row, 4] = (object)Program.Vek[R].Club;
                                num3 = 61;
                                if (Operators.CompareString(Program.OpenDB[Program.PcIndex].Segment_1, "S", false) == 0 & Operators.CompareString(Program.OpenDB[Program.PcIndex].Segment_2, "F", false) == 0)
                                {
                                    num3 = 62;
                                    Program.TArrNext[row, 5] = (object)Program.Vek[R].Score_Seg1;
                                }
                            }
                        }
                        else
                        {
                            num3 = 66;
                            if (Operators.CompareString(seg, "S0", false) == 0 || Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "FF", false) == 0 || Operators.CompareString(seg, "F0", false) == 0 || Operators.CompareString(seg, "SS", false) == 0)
                            {
                                num3 = 67;
                                string segment2 = Program.Segment;
                                num3 = 70;
                                if (Operators.CompareString(segment2, "Seg1", false) == 0)
                                {
                                    num3 = 71;
                                    if (R > 2)
                                    {
                                        num3 = 72;
                                        if (Program.Vek[R].WarmUp_Seg1 > Program.Vek[checked(R - 1)].WarmUp_Seg1 & Program.Vek[R].Finished_Seg1 == 0)
                                        {
                                            num3 = 73;
                                            if (Program.FinishedRestSeg1(R) == 0)
                                            {
                                                num3 = 74;
                                                checked { ++row; }
                                                num3 = 75;
                                                int index = 1;
                                                do
                                                {
                                                    num3 = 76;
                                                    if (Program.Vek[checked(R - 1)].Startno_Seg1 == Program.IceArr_Seg1[index] & Program.Vek[checked(R - 1)].DNS_Seg1 == 0)
                                                    {
                                                        num3 = 77;
                                                        Program.TArrNext[row, 3] = (object)"ICE RESURFACING";
                                                    }
                                                    num3 = 79;
                                                    if (Program.Vek[checked(R - 1)].Startno_Seg1 == Program.LunchArr_Seg1[index] & Program.Vek[checked(R - 1)].DNS_Seg1 == 0)
                                                    {
                                                        num3 = 80;
                                                        Program.TArrNext[row, 3] = (object)"MEAL BREAK";
                                                    }
                                                    num3 = 82;
                                                    checked { ++index; }
                                                }
                                                while (index <= 6);
                                                num3 = 83;
                                                if (Strings.Len(RuntimeHelpers.GetObjectValue(Program.TArrNext[row, 3])) < 1)
                                                {
                                                    num3 = 84;
                                                    Program.TArrNext[row, 3] = (object)"WARM UP";
                                                }
                                            }
                                        }
                                    }
                                    num3 = 89;
                                    if (Program.Vek[R].DNS_Seg1 == 0 & Program.Vek[R].Finished_Seg1 == 0)
                                    {
                                        num3 = 90;
                                        checked { ++row; }
                                        num3 = 91;
                                        Program.TArrNext[row, 1] = (object)Conversions.ToString(Program.Vek[R].Startno_Seg1);
                                        num3 = 92;
                                        if (Program.Vek[R].WarmUp_Seg1 > 0)
                                        {
                                            num3 = 93;
                                            Program.TArrNext[row, 2] = (object)Conversions.ToString(Program.Vek[R].WarmUp_Seg1);
                                        }
                                        else
                                        {
                                            num3 = 95;
                                            num3 = 96;
                                            Program.TArrNext[row, 2] = (object)"-";
                                        }
                                        num3 = 98;
                                        Program.TArrNext[row, 3] = (object)(Program.Vek[R].Name.FName + " " + Program.Vek[R].Name.LName);
                                        num3 = 99;
                                        Program.TArrNext[row, 4] = (object)Program.Vek[R].Club;
                                    }
                                }
                                else
                                {
                                    num3 = 102;
                                    if (Operators.CompareString(segment2, "Seg2", false) == 0)
                                    {
                                        num3 = 103;
                                        if (R > 2)
                                        {
                                            num3 = 104;
                                            if (Program.Vek[R].WarmUp_Seg2 > Program.Vek[checked(R - 1)].WarmUp_Seg2 & Program.Vek[R].Finished_Seg2 == 0)
                                            {
                                                num3 = 105;
                                                if (Program.FinishedRestSeg2(R) == 0)
                                                {
                                                    num3 = 106;
                                                    checked { ++row; }
                                                    num3 = 107;
                                                    int index = 1;
                                                    do
                                                    {
                                                        num3 = 108;
                                                        if (Program.Vek[checked(R - 1)].Startno_Seg2 == Program.IceArr_Seg2[index] & Program.Vek[checked(R - 1)].DNS_Seg2 == 0)
                                                        {
                                                            num3 = 109;
                                                            Program.TArrNext[row, 3] = (object)"ICE RESURFACING";
                                                        }
                                                        num3 = 111;
                                                        if (Program.Vek[checked(R - 1)].Startno_Seg2 == Program.LunchArr_Seg2[index] & Program.Vek[checked(R - 1)].DNS_Seg2 == 0)
                                                        {
                                                            num3 = 112;
                                                            Program.TArrNext[row, 3] = (object)"MEAL BREAK";
                                                        }
                                                        num3 = 114;
                                                        checked { ++index; }
                                                    }
                                                    while (index <= 6);
                                                    num3 = 115;
                                                    if (Strings.Len(RuntimeHelpers.GetObjectValue(Program.TArrNext[row, 3])) < 1)
                                                    {
                                                        num3 = 116;
                                                        Program.TArrNext[row, 3] = (object)"WARM UP";
                                                    }
                                                }
                                            }
                                        }
                                        num3 = 121;
                                        if (Program.Vek[R].DNS_Seg2 == 0 & Program.Vek[R].Finished_Seg2 == 0)
                                        {
                                            num3 = 122;
                                            checked { ++row; }
                                            num3 = 123;
                                            Program.TArrNext[row, 1] = (object)Conversions.ToString(Program.Vek[R].Startno_Seg2);
                                            num3 = 124;
                                            if (Program.Vek[R].WarmUp_Seg2 > 0)
                                            {
                                                num3 = 125;
                                                Program.TArrNext[row, 2] = (object)Conversions.ToString(Program.Vek[R].WarmUp_Seg2);
                                            }
                                            else
                                            {
                                                num3 = (int)sbyte.MaxValue;
                                                num3 = 128;
                                                Program.TArrNext[row, 2] = (object)"-";
                                            }
                                            num3 = 130;
                                            Program.TArrNext[row, 3] = (object)(Program.Vek[R].Name.FName + " " + Program.Vek[R].Name.LName);
                                            num3 = 131;
                                            Program.TArrNext[row, 4] = (object)Program.Vek[R].Club;
                                            num3 = 132;
                                            if (Operators.CompareString(Program.GetSeg(), "SF", false) == 0 | Operators.CompareString(Program.GetSeg(), "FF", false) == 0 | Operators.CompareString(Program.GetSeg(), "SS", false) == 0)
                                            {
                                                num3 = 133;
                                                Program.TArrNext[row, 5] = (object)Program.Vek[R].Score_Seg1;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        num3 = 138;
                        checked { ++R; }
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

        public static int FinishedRestSeg1(int R)
        {
            int num1 = 0;
            int num2 = checked(R + 1);
            int tnop = Program.TNop;
            int index = num2;
            while (index <= tnop)
            {
                if (Program.Vek[R].WarmUp_Seg1 == Program.Vek[index].WarmUp_Seg1)
                {
                    if (Program.Vek[index].Finished_Seg1 == 0)
                    {
                        num1 = 0;
                    }
                    else
                    {
                        num1 = 1;
                        break;
                    }
                }
                checked { ++index; }
            }
            return num1;
        }

        public static int FinishedRestSeg2(int R)
        {
            int num1 = 0;
            int num2 = checked(R + 1);
            int tnop = Program.TNop;
            int index = num2;
            while (index <= tnop)
            {
                if (Program.Vek[R].WarmUp_Seg2 == Program.Vek[index].WarmUp_Seg2)
                {
                    if (Program.Vek[index].Finished_Seg2 == 0)
                    {
                        num1 = 0;
                    }
                    else
                    {
                        num1 = 1;
                        break;
                    }
                }
                checked { ++index; }
            }
            return num1;
        }

        public static bool MakeResultHTM(string BC, int StNo, int row, int rowRemain)
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                StreamWriter streamWriter = new StreamWriter(Program.PathResultsFile + "Results.htm", false, Encoding.Default);
                streamWriter.Write("<html>\r\n");
                streamWriter.Write("<head>\r\n");
                streamWriter.Write("<title>ClubCompFS Results</title>\r\n");
                streamWriter.Write("<meta http-equiv='refresh' content='30' />\r\n");
                streamWriter.Write("</head>\r\n");
                streamWriter.Write("<body>\r\n");
                string[] strArray1 = new string[3]
                {
          "'0'",
          "'600'",
          "'250'"
                };
                int index1 = 1;
                do
                {
                    strArray1[index1] = " width=" + strArray1[index1];
                    checked { ++index1; }
                }
                while (index1 <= 2);
                streamWriter.Write("<table border='0' cellspacing='0'>\r\n");
                streamWriter.Write("<tr>\r\n");
                streamWriter.Write("<td align='left'" + strArray1[1] + "><font size='3'><b>COMPETITION: " + Program.Competition.Name + "</b></td>\r\n");
                streamWriter.Write("<td align='left'" + strArray1[2] + "><font size='3'><b>" + Program.DateTimeToStr(DateTime.Now) + "</b></td>\r\n");
                streamWriter.Write("</tr>\r\n");
                streamWriter.Write("<tr>\r\n");
                streamWriter.Write("<td align='left'" + strArray1[1] + "><font size='3'><b>CATEGORY: " + Program.GetCat() + ", " + Program.GetSegTxt(Program.Segment) + "</b></td>\r\n");
                streamWriter.Write("</tr>\r\n");
                streamWriter.Write("</table><br />\r\n");
                int num3 = 0;
                if (Operators.CompareString(Program.GetSeg(), "0F", false) == 0)
                {
                    num3 = 1;
                }
                else
                {
                    string segment = Program.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                        num3 = 1;
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                        num3 = 2;
                }
                string[] strArray2 = new string[10]
                {
          "'0'",
          "'40'",
          "'35'",
          "'250'",
          "'200'",
          "'60'",
          "'60'",
          "'60'",
          "'40'",
          "'40'"
                };
                int index2 = 1;
                do
                {
                    strArray2[index2] = " width=" + strArray2[index2];
                    checked { ++index2; }
                }
                while (index2 <= 9);
                streamWriter.Write("<font size =3><b>CURRENT SKATER</b><br />\r\n");
                streamWriter.Write("<table border='0' cellspacing='0'>\r\n");
                streamWriter.Write("<tr>\r\n");
                streamWriter.Write("<td align='left'" + BC + strArray2[1] + "><font size='3'><b>Place</b></td>\r\n");
                streamWriter.Write("<td align='left'" + BC + strArray2[2] + "><font size='3'><b>St</b></td>\r\n");
                streamWriter.Write("<td align='left'" + BC + strArray2[3] + "><font size='3'><b>Name</b></td>\r\n");
                streamWriter.Write("<td align='left'" + BC + strArray2[4] + "><font size='3'><b>Club</b></td>\r\n");
                streamWriter.Write("<td align='center'" + BC + strArray2[5] + "><font size='3'><b>TSS</b></td>\r\n");
                streamWriter.Write("<td align='center'" + BC + strArray2[6] + "><font size='3'><b>TES</b></td>\r\n");
                streamWriter.Write("<td align='center'" + BC + strArray2[7] + "><font size='3'><b>PCS</b></td>\r\n");
                streamWriter.Write("<td align='center'" + BC + strArray2[8] + "><font size='3'><b>Ded</b></td>\r\n");
                if (Program.Bonus_Sel(Program.Segment))
                    streamWriter.Write("<td align='center'" + BC + strArray2[9] + "><font size='3'><b>Bon</b></td>\r\n");
                streamWriter.Write("</tr>\r\n");
                streamWriter.Write("<tr>\r\n");
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[1] + "><font size='3'>"), Program.TArrLive[1, 1]), (object)"</td>"), (object)"\r\n"));
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[2] + "><font size='3'>"), Program.TArrLive[1, 2]), (object)"</td>"), (object)"\r\n"));
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[3] + "><font size='3'>"), Program.TArrLive[1, 3]), (object)"</td>"), (object)"\r\n"));
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[4] + "><font size='3'>"), Program.TArrLive[1, 4]), (object)"</td>"), (object)"\r\n"));
                if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Program.TArrLive[1, 5])))
                    streamWriter.Write("<td align='center'" + BC + strArray2[5] + "><font size='3'>" + Strings.Format(RuntimeHelpers.GetObjectValue(Program.TArrLive[1, 5]), "#0.00") + "</td>\r\n");
                else
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='center'" + BC + strArray2[6] + "><font size='3'>"), Program.TArrLive[1, 5]), (object)"</td>"), (object)"\r\n"));
                streamWriter.Write("<td align='center'" + BC + strArray2[6] + "><font size='3'>" + Strings.Format(RuntimeHelpers.GetObjectValue(Program.TArrLive[1, 6]), "#0.00") + "</td>\r\n");
                streamWriter.Write("<td align='center'" + BC + strArray2[7] + "><font size='3'>" + Strings.Format(RuntimeHelpers.GetObjectValue(Program.TArrLive[1, 7]), "#0.00") + "</td>\r\n");
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='center'" + BC + strArray2[8] + "><font size='3'>"), Program.TArrLive[1, 8]), (object)"</td>"), (object)"\r\n"));
                if (Program.Bonus_Sel(Program.Segment))
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='center'" + BC + strArray2[9] + "><font size='3'><b>"), Program.TArrLive[1, 9]), (object)"</b>"), (object)"</td>"), (object)"\r\n"));
                streamWriter.Write("</tr>\r\n");
                if (num3 == 1)
                {
                    streamWriter.Write("</table><br />\r\n");
                }
                else
                {
                    streamWriter.Write("</table>\r\n");
                    streamWriter.Write("<font size =3><b>TOTAL RESULT</b><br />\r\n");
                    streamWriter.Write("<table border='0' cellspacing='0'>\r\n");
                    streamWriter.Write("<tr>\r\n");
                    streamWriter.Write("<td align='left'" + BC + strArray2[1] + "><font size='3'><b>Place</b></td>\r\n");
                    streamWriter.Write("<td align='left'" + BC + strArray2[2] + "><font size='3'><b>St</b></td>\r\n");
                    streamWriter.Write("<td align='left'" + BC + strArray2[3] + "><font size='3'><b>Name</b></td>\r\n");
                    streamWriter.Write("<td align='left'" + BC + strArray2[4] + "><font size='3'><b>Club</b></td>\r\n");
                    streamWriter.Write("<td align='center'" + BC + strArray2[5] + "><font size='3'><b>Total</b></td>\r\n");
                    streamWriter.Write("<td align='center'" + BC + strArray2[6] + "><font size='3'><b>SP</b></td>\r\n");
                    streamWriter.Write("<td align='center'" + BC + strArray2[7] + "><font size='3'><b>FS</b></td>\r\n");
                    streamWriter.Write("</tr>\r\n");
                    streamWriter.Write("<tr>\r\n");
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[1] + "><font size='3'>"), Program.TArrLive[2, 1]), (object)"</td>"), (object)"\r\n"));
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[2] + "><font size='3'>"), Program.TArrLive[2, 2]), (object)"</td>"), (object)"\r\n"));
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[3] + "><font size='3'>"), Program.TArrLive[2, 3]), (object)"</td>"), (object)"\r\n"));
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[4] + "><font size='3'>"), Program.TArrLive[2, 4]), (object)"</td>"), (object)"\r\n"));
                    if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Program.TArrLive[1, 5])))
                        streamWriter.Write("<td align='center'" + BC + strArray2[5] + "><font size='3'>" + Strings.Format(RuntimeHelpers.GetObjectValue(Program.TArrLive[2, 5]), "#0.00") + "</td>\r\n");
                    else
                        streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='center'" + BC + strArray2[5] + "><font size='3'>"), Program.TArrLive[2, 5]), (object)"</td>"), (object)"\r\n"));
                    streamWriter.Write("<td align='center'" + BC + strArray2[6] + "><font size='3'>" + Strings.Format(RuntimeHelpers.GetObjectValue(Program.TArrLive[2, 6]), "#0.00") + "</td>\r\n");
                    streamWriter.Write("<td align='center'" + BC + strArray2[7] + "><font size='3'>" + Strings.Format(RuntimeHelpers.GetObjectValue(Program.TArrLive[2, 7]), "#0.00") + "</td>\r\n");
                    streamWriter.Write("</table><br />\r\n");
                }
                if (Program.TNop > 0)
                {
                    if (row > 1)
                    {
                        streamWriter.Write("<font size =3><b>CURRENT STANDINGS</b><br />\r\n");
                        streamWriter.Write("<table border='0' cellspacing='0'>\r\n");
                        streamWriter.Write("<tr>\r\n");
                        streamWriter.Write("<td align='left'" + strArray2[1] + "><font size='3'><b>Place</b></td>\r\n");
                        streamWriter.Write("<td align='left'" + strArray2[2] + "><font size='3'><b>St</b></td>\r\n");
                        streamWriter.Write("<td align='left'" + strArray2[3] + "><font size='3'><b>Name</b></td>\r\n");
                        streamWriter.Write("<td align='left'" + strArray2[4] + "><font size='3'><b>Club</b></td>\r\n");
                        string seg1 = Program.GetSeg();
                        if (Operators.CompareString(seg1, "SS", false) == 0)
                        {
                            string segment = Program.Segment;
                            if (Operators.CompareString(segment, "Seg1", false) == 0)
                                streamWriter.Write("<td align='center'" + strArray2[5] + "><font size='3'><b>TSS</b></td>\r\n");
                            else if (Operators.CompareString(segment, "Seg2", false) == 0)
                            {
                                streamWriter.Write("<td align='center'" + strArray2[5] + "><font size='3'><b>Total</b></td>\r\n");
                                streamWriter.Write("<td align='center'" + strArray2[6] + "><font size='3'><b>SP</b></td>\r\n");
                                streamWriter.Write("<td align='center'" + strArray2[7] + "><font size='3'><b>SP</b></td>\r\n");
                            }
                        }
                        else if (Operators.CompareString(seg1, "S0", false) == 0 || Operators.CompareString(seg1, "0F", false) == 0)
                            streamWriter.Write("<td align='center'" + strArray2[5] + "><font size='3'><b>Total</b></td>\r\n");
                        else if (Operators.CompareString(seg1, "SF", false) == 0)
                        {
                            string segment = Program.Segment;
                            if (Operators.CompareString(segment, "Seg1", false) == 0)
                                streamWriter.Write("<td align='center'" + strArray2[5] + "><font size='3'><b>TSS</b></td>\r\n");
                            else if (Operators.CompareString(segment, "Seg2", false) == 0)
                            {
                                streamWriter.Write("<td align='center'" + strArray2[5] + "><font size='3'><b>Total</b></td>\r\n");
                                streamWriter.Write("<td align='center'" + strArray2[6] + "><font size='3'><b>SP</b></td>\r\n");
                                streamWriter.Write("<td align='center'" + strArray2[7] + "><font size='3'><b>FS</b></td>\r\n");
                            }
                        }
                        else if (Operators.CompareString(seg1, "FF", false) == 0)
                        {
                            string segment = Program.Segment;
                            if (Operators.CompareString(segment, "Seg1", false) == 0)
                                streamWriter.Write("<td align='center'" + strArray2[5] + "><font size='3'><b>TSS</b></td>\r\n");
                            else if (Operators.CompareString(segment, "Seg2", false) == 0)
                            {
                                streamWriter.Write("<td align='center'" + strArray2[5] + "><font size='3'><b>Total</b></td>\r\n");
                                streamWriter.Write("<td align='center'" + strArray2[6] + "><font size='3'><b>FS</b></td>\r\n");
                                streamWriter.Write("<td align='center'" + strArray2[7] + "><font size='3'><b>FS</b></td>\r\n");
                            }
                        }
                        streamWriter.Write("</tr>\r\n");
                        int num4 = row;
                        int index3 = 2;
                        while (index3 <= num4)
                        {
                            string str1 = !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Program.TArrResult[index3, 5])) ? Conversions.ToString(Program.TArrResult[index3, 5]) : Strings.Format(RuntimeHelpers.GetObjectValue(Program.TArrResult[index3, 5]), "0.00");
                            streamWriter.Write("<tr>\r\n");
                            string str2 = Operators.CompareString(Strings.Trim(Conversions.ToString(StNo)), Strings.Trim(Conversions.ToString(Program.TArrResult[index3, 2])), false) != 0 ? "" : BC;
                            streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + str2 + strArray2[1] + "><font size='3'>"), Program.TArrResult[index3, 1]), (object)"</td>"), (object)"\r\n"));
                            streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + str2 + strArray2[2] + "><font size='3'>"), Program.TArrResult[index3, 2]), (object)"</td>"), (object)"\r\n"));
                            streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + str2 + strArray2[3] + "><font size='3'>"), Program.TArrResult[index3, 3]), (object)"</td>"), (object)"\r\n"));
                            streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + str2 + strArray2[4] + "><font size='3'>"), Program.TArrResult[index3, 4]), (object)"</td>"), (object)"\r\n"));
                            string seg2 = Program.GetSeg();
                            if (Operators.CompareString(seg2, "S0", false) == 0 || Operators.CompareString(seg2, "0F", false) == 0)
                                streamWriter.Write("<td align='center'" + str2 + strArray2[5] + "><font size='3'>" + str1 + "</td>\r\n");
                            else if (Operators.CompareString(seg2, "SS", false) == 0 || Operators.CompareString(seg2, "SF", false) == 0 || Operators.CompareString(seg2, "FF", false) == 0)
                            {
                                string segment = Program.Segment;
                                if (Operators.CompareString(segment, "Seg1", false) == 0)
                                    streamWriter.Write("<td align='center'" + str2 + strArray2[5] + "><font size='3'>" + str1 + "</td>\r\n");
                                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                                {
                                    streamWriter.Write("<td align='center'" + str2 + strArray2[5] + "><font size='3'>" + str1 + "</td>\r\n");
                                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='center'" + str2 + strArray2[6] + "><font size='3'>"), Program.TArrResult[index3, 6]), (object)"</td>"), (object)"\r\n"));
                                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='center'" + str2 + strArray2[7] + "><font size='3'>"), Program.TArrResult[index3, 7]), (object)"</td>"), (object)"\r\n"));
                                }
                            }
                            streamWriter.Write("</tr>\r\n");
                            checked { ++index3; }
                        }
                        streamWriter.Write("</table><br />\r\n");
                    }
                    if (rowRemain > 1)
                    {
                        streamWriter.Write("<font size =3><b>REMAINING SKATERS</b><br />\r\n");
                        streamWriter.Write("<table border='0' cellspacing='0'>\r\n");
                        streamWriter.Write("<tr>\r\n");
                        streamWriter.Write("<td align='left'" + strArray2[1] + "><font size='3'><b>St</b></td>\r\n");
                        streamWriter.Write("<td align='left'" + strArray2[2] + "><font size='3'><b>Gr</b></td>\r\n");
                        streamWriter.Write("<td align='left'" + strArray2[3] + "><font size='3'><b>Name</b></td>\r\n");
                        streamWriter.Write("<td align='left'" + strArray2[4] + "><font size='3'><b>Club</b></td>\r\n");
                        streamWriter.Write("</tr>\r\n");
                        int num5 = rowRemain;
                        int index4 = 2;
                        while (index4 <= num5)
                        {
                            if (Strings.Len(RuntimeHelpers.GetObjectValue(Program.TArrNext[index4, 1])) > 0 | Strings.Len(RuntimeHelpers.GetObjectValue(Program.TArrNext[index4, 3])) > 0)
                            {
                                streamWriter.Write("<tr>\r\n");
                                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + strArray2[1] + "><font size='3'>"), Program.TArrNext[index4, 1]), (object)"</td>"), (object)"\r\n"));
                                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + strArray2[2] + "><font size='3'>"), Program.TArrNext[index4, 2]), (object)"</td>"), (object)"\r\n"));
                                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + strArray2[3] + "><font size='3'>"), Program.TArrNext[index4, 3]), (object)"</td>"), (object)"\r\n"));
                                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + strArray2[4] + "><font size='3'>"), Program.TArrNext[index4, 4]), (object)"</td>"), (object)"\r\n"));
                                streamWriter.Write("</tr>\r\n");
                            }
                            checked { ++index4; }
                        }
                        streamWriter.Write("</table><br />\r\n");
                    }
                }
                streamWriter.Write("<font size =2>ClubCompFS Single ver. 10.0.6, 2019-01-12</b><br />\r\n");
                streamWriter.Write("</body>\r\n");
                streamWriter.Write("</html>\r\n");
                streamWriter.Close();
                streamWriter.Dispose();
                flag = true;
                goto label_66;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                flag = false;
                int num6 = (int)Interaction.MsgBox((object)("MakeResultHTM - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_66:
            int num7 = flag ? 1 : 0;
            if (num2 == 0)
                return num7 != 0;
            ProjectData.ClearProjectError();
            return num7 != 0;
        }

        public static bool MakeSpeakerHTM(string BC, int StNo, int row, int rowRemain)
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                StreamWriter streamWriter = new StreamWriter(Program.PathResultsFile + "Speaker.html", false, Encoding.Default);
                streamWriter.Write("<html>\r\n");
                streamWriter.Write("<head>\r\n");
                streamWriter.Write("<title>ClubCompFS Speaker</title>\r\n");
                streamWriter.Write("</head>\r\n");
                streamWriter.Write("<body>\r\n");
                string[] strArray1 = new string[3]
                {
          "'0'",
          "'600'",
          "'250'"
                };
                int index1 = 1;
                do
                {
                    strArray1[index1] = " width=" + strArray1[index1];
                    checked { ++index1; }
                }
                while (index1 <= 2);
                streamWriter.Write("<table border='0' cellspacing='0'>\r\n");
                streamWriter.Write("<tr>\r\n");
                streamWriter.Write("<td align='left'" + strArray1[1] + "><font size='3'><b>COMPETITION: " + Program.Competition.Name + "</b></td>\r\n");
                streamWriter.Write("<td align='left'" + strArray1[2] + "><font size='3'><b>" + Program.DateTimeToStr(DateTime.Now) + "</b></td>\r\n");
                streamWriter.Write("</tr>\r\n");
                streamWriter.Write("<tr>\r\n");
                streamWriter.Write("<td align='left'" + strArray1[1] + "><font size='3'><b>CATEGORY: " + Program.GetCat() + ", " + Program.GetSegTxt(Program.Segment) + "</b></td>\r\n");
                streamWriter.Write("</tr>\r\n");
                streamWriter.Write("</table><br />\r\n");
                int num3 = 0;
                if (Operators.CompareString(Program.GetSeg(), "0F", false) == 0)
                {
                    num3 = 1;
                }
                else
                {
                    string segment = Program.Segment;
                    if (Operators.CompareString(segment, "Seg1", false) == 0)
                        num3 = 1;
                    else if (Operators.CompareString(segment, "Seg2", false) == 0)
                        num3 = 2;
                }
                string[] strArray2 = new string[10]
                {
          "'0'",
          "'40'",
          "'35'",
          "'250'",
          "'200'",
          "'60'",
          "'60'",
          "'60'",
          "'40'",
          "'40'"
                };
                int index2 = 1;
                do
                {
                    strArray2[index2] = " width=" + strArray2[index2];
                    checked { ++index2; }
                }
                while (index2 <= 9);
                streamWriter.Write("<font size =3><b>CURRENT SKATER</b><br />\r\n");
                streamWriter.Write("<table border='0' cellspacing='0'>\r\n");
                streamWriter.Write("<tr>\r\n");
                streamWriter.Write("<td align='left'" + BC + strArray2[1] + "><font size='3'><b>Place</b></td>\r\n");
                streamWriter.Write("<td align='left'" + BC + strArray2[2] + "><font size='3'><b>St</b></td>\r\n");
                streamWriter.Write("<td align='left'" + BC + strArray2[3] + "><font size='3'><b>Name</b></td>\r\n");
                streamWriter.Write("<td align='left'" + BC + strArray2[4] + "><font size='3'><b>Club</b></td>\r\n");
                streamWriter.Write("<td align='center'" + BC + strArray2[5] + "><font size='3'><b>TES</b></td>\r\n");
                streamWriter.Write("<td align='center'" + BC + strArray2[6] + "><font size='3'><b>PCS</b></td>\r\n");
                streamWriter.Write("<td align='center'" + BC + strArray2[7] + "><font size='3'><b>TSS</b></td>\r\n");
                streamWriter.Write("<td align='center'" + BC + strArray2[8] + "><font size='3'><b>Ded</b></td>\r\n");
                if (Program.Bonus_Sel(Program.Segment))
                    streamWriter.Write("<td align='center'" + BC + strArray2[9] + "><font size='3'><b>Bon</b></td>\r\n");
                streamWriter.Write("</tr>\r\n");
                streamWriter.Write("<tr>\r\n");
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[1] + "><font size='3'>"), Program.TArrLive[1, 1]), (object)"</td>"), (object)"\r\n"));
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[2] + "><font size='3'>"), Program.TArrLive[1, 2]), (object)"</td>"), (object)"\r\n"));
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[3] + "><font size='3'>"), Program.TArrLive[1, 3]), (object)"</td>"), (object)"\r\n"));
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[4] + "><font size='3'>"), Program.TArrLive[1, 4]), (object)"</td>"), (object)"\r\n"));
                streamWriter.Write("<td align='center'" + BC + strArray2[6] + "><font size='3'>" + Strings.Format(RuntimeHelpers.GetObjectValue(Program.TArrLive[1, 6]), "#0.00") + "</td>\r\n");
                streamWriter.Write("<td align='center'" + BC + strArray2[7] + "><font size='3'>" + Strings.Format(RuntimeHelpers.GetObjectValue(Program.TArrLive[1, 7]), "#0.00") + "</td>\r\n");
                if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Program.TArrLive[1, 5])))
                    streamWriter.Write("<td align='center'" + BC + strArray2[5] + "><font size='3'>" + Strings.Format(RuntimeHelpers.GetObjectValue(Program.TArrLive[1, 5]), "#0.00") + "</td>\r\n");
                else
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='center'" + BC + strArray2[6] + "><font size='3'>"), Program.TArrLive[1, 5]), (object)"</td>"), (object)"\r\n"));
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='center'" + BC + strArray2[8] + "><font size='3'>"), Program.TArrLive[1, 8]), (object)"</td>"), (object)"\r\n"));
                if (Program.Bonus_Sel(Program.Segment))
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='center'" + BC + strArray2[9] + "><font size='3'><b>"), Program.TArrLive[1, 9]), (object)"</b>"), (object)"</td>"), (object)"\r\n"));
                streamWriter.Write("</tr>\r\n");
                if (num3 == 1)
                {
                    streamWriter.Write("</table><br />\r\n");
                }
                else
                {
                    streamWriter.Write("</table>\r\n");
                    streamWriter.Write("<font size =3><b>TOTAL RESULT</b><br />\r\n");
                    streamWriter.Write("<table border='0' cellspacing='0'>\r\n");
                    streamWriter.Write("<tr>\r\n");
                    streamWriter.Write("<td align='left'" + BC + strArray2[1] + "><font size='3'><b>Place</b></td>\r\n");
                    streamWriter.Write("<td align='left'" + BC + strArray2[2] + "><font size='3'><b>St</b></td>\r\n");
                    streamWriter.Write("<td align='left'" + BC + strArray2[3] + "><font size='3'><b>Name</b></td>\r\n");
                    streamWriter.Write("<td align='left'" + BC + strArray2[4] + "><font size='3'><b>Club</b></td>\r\n");
                    streamWriter.Write("<td align='center'" + BC + strArray2[5] + "><font size='3'><b>Total</b></td>\r\n");
                    streamWriter.Write("<td align='center'" + BC + strArray2[6] + "><font size='3'><b>SP</b></td>\r\n");
                    streamWriter.Write("<td align='center'" + BC + strArray2[7] + "><font size='3'><b>FS</b></td>\r\n");
                    streamWriter.Write("</tr>\r\n");
                    streamWriter.Write("<tr>\r\n");
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[1] + "><font size='3'>"), Program.TArrLive[2, 1]), (object)"</td>"), (object)"\r\n"));
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[2] + "><font size='3'>"), Program.TArrLive[2, 2]), (object)"</td>"), (object)"\r\n"));
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[3] + "><font size='3'>"), Program.TArrLive[2, 3]), (object)"</td>"), (object)"\r\n"));
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + BC + strArray2[4] + "><font size='3'>"), Program.TArrLive[2, 4]), (object)"</td>"), (object)"\r\n"));
                    if (Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Program.TArrLive[1, 5])))
                        streamWriter.Write("<td align='center'" + BC + strArray2[5] + "><font size='3'>" + Strings.Format(RuntimeHelpers.GetObjectValue(Program.TArrLive[2, 5]), "#0.00") + "</td>\r\n");
                    else
                        streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='center'" + BC + strArray2[5] + "><font size='3'>"), Program.TArrLive[2, 5]), (object)"</td>"), (object)"\r\n"));
                    streamWriter.Write("<td align='center'" + BC + strArray2[6] + "><font size='3'>" + Strings.Format(RuntimeHelpers.GetObjectValue(Program.TArrLive[2, 6]), "#0.00") + "</td>\r\n");
                    streamWriter.Write("<td align='center'" + BC + strArray2[7] + "><font size='3'>" + Strings.Format(RuntimeHelpers.GetObjectValue(Program.TArrLive[2, 7]), "#0.00") + "</td>\r\n");
                    streamWriter.Write("</table><br />\r\n");
                }
                if (Program.TNop > 0 && rowRemain > 1)
                {
                    streamWriter.Write("<font size =3><b>REMAINING SKATERS</b><br />\r\n");
                    streamWriter.Write("<table border='0' cellspacing='0'>\r\n");
                    streamWriter.Write("<tr>\r\n");
                    streamWriter.Write("<td align='left'" + strArray2[1] + "><font size='3'><b>St</b></td>\r\n");
                    streamWriter.Write("<td align='left'" + strArray2[2] + "><font size='3'><b>Gr</b></td>\r\n");
                    streamWriter.Write("<td align='left'" + strArray2[3] + "><font size='3'><b>Name</b></td>\r\n");
                    streamWriter.Write("<td align='left'" + strArray2[4] + "><font size='3'><b>Club</b></td>\r\n");
                    streamWriter.Write("</tr>\r\n");
                    int num4 = rowRemain;
                    int index3 = 2;
                    while (index3 <= num4)
                    {
                        if (Strings.Len(RuntimeHelpers.GetObjectValue(Program.TArrNext[index3, 1])) > 0 | Strings.Len(RuntimeHelpers.GetObjectValue(Program.TArrNext[index3, 3])) > 0)
                        {
                            streamWriter.Write("<tr>\r\n");
                            streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + strArray2[1] + "><font size='3'>"), Program.TArrNext[index3, 1]), (object)"</td>"), (object)"\r\n"));
                            streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + strArray2[2] + "><font size='3'>"), Program.TArrNext[index3, 2]), (object)"</td>"), (object)"\r\n"));
                            streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + strArray2[3] + "><font size='3'>"), Program.TArrNext[index3, 3]), (object)"</td>"), (object)"\r\n"));
                            streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("<td align='left'" + strArray2[4] + "><font size='3'>"), Program.TArrNext[index3, 4]), (object)"</td>"), (object)"\r\n"));
                            streamWriter.Write("</tr>\r\n");
                        }
                        checked { ++index3; }
                    }
                    streamWriter.Write("</table><br />\r\n");
                }
                streamWriter.Write("<font size =2>ClubCompFS Single ver. 10.0.6, 2019-01-12</b><br />\r\n");
                streamWriter.Write("</body>\r\n");
                streamWriter.Write("</html>\r\n");
                streamWriter.Close();
                streamWriter.Dispose();
                flag = true;
                goto label_36;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                flag = false;
                int num5 = (int)Interaction.MsgBox((object)("MakeSpeakerHTM - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_36:
            int num6 = flag ? 1 : 0;
            if (num2 == 0)
                return num6 != 0;
            ProjectData.ClearProjectError();
            return num6 != 0;
        }

        public static bool MakeCSS(string BC, int StNo, int row, int rowRemain)
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                StreamWriter streamWriter = new StreamWriter(Program.PathResultsFile + "ResultsPhone.htm", false, Encoding.Default);
                streamWriter.Write("<!DOCTYPE html>\r\n");
                streamWriter.Write("<!--[if IE 9]><html class='lt-ie10' lang='en' > <![endif]-->\r\n");
                streamWriter.Write("<html class='no-js' lang='en' >\r\n");
                streamWriter.Write("<head>\r\n");
                streamWriter.Write("<meta name='viewport' content='width=device-width, initial-scale=1.0'>\r\n");
                streamWriter.Write("<meta http-equiv='refresh' content='30' />\r\n");
                streamWriter.Write("<title>CCFS live results</title>\r\n");
                streamWriter.Write("<link rel='stylesheet' href='http://www.skatesweden.wehost.se/css/foundation.css'>\r\n");
                streamWriter.Write("<link rel='stylesheet' href='http://www.skatesweden.wehost.se/css/custom-styles.css'>\r\n");
                streamWriter.Write("</head>\r\n");
                streamWriter.Write("<body>\r\n");
                streamWriter.Write("<div class='row'>\r\n");
                streamWriter.Write(" <div class='small-12 columns'>\r\n");
                streamWriter.Write("  <h1>" + Program.Competition.Name + "</h1>\r\n");
                streamWriter.Write("  <h2>" + Program.GetCat() + "</h2>\r\n");
                streamWriter.Write("  <h3>" + Program.GetSegTxt(Program.Segment) + "</h3>\r\n");
                streamWriter.Write("  <hr />\r\n");
                streamWriter.Write(" </div>\r\n");
                streamWriter.Write("</div>\r\n");
                streamWriter.Write("<!-- Current skater -->\r\n");
                streamWriter.Write("<div class='row'>\r\n");
                streamWriter.Write(" <div class='small-12 columns'>\r\n");
                streamWriter.Write("  <div class='row'>\r\n");
                streamWriter.Write("  <div class='small-12 columns'><h4>Current skater</h4>\r\n");
                streamWriter.Write("  </div>\r\n");
                streamWriter.Write(" </div>\r\n");
                streamWriter.Write("<!-- Headlines -->\r\n");
                streamWriter.Write(" <div class='row'>\r\n");
                streamWriter.Write("  <div class='small-2 large-1 columns'><h5>Place</h5></div>\r\n");
                streamWriter.Write("  <div class='small-9 large-3 columns'><h5>Name</h5></div>\r\n");
                streamWriter.Write("  <div class='show-for-large-up large-3 columns'><h5>Club</h5></div>\r\n");
                streamWriter.Write("  <div class='small-12 large-5 columns show-for-large-up'>\r\n");
                streamWriter.Write("   <div class='row'>\r\n");
                streamWriter.Write("    <div class='small-2 columns'><h6>TSS</h6></div>\r\n");
                streamWriter.Write("    <div class='small-2 columns'><h6>TES</h6></div>\r\n");
                streamWriter.Write("    <div class='small-2 columns'><h6>PCS</h6></div>\r\n");
                if (Program.Bonus_Sel(Program.Segment))
                {
                    streamWriter.Write("    <div class='small-2 columns'><h6>Ded</h6></div>\r\n");
                    streamWriter.Write("    <div class='small-2 columns end'><h6>Bon</h6></div>\r\n");
                }
                else
                    streamWriter.Write("    <div class='small-2 columns end'><h6>Ded</h6></div>\r\n");
                streamWriter.Write("   </div>\r\n");
                streamWriter.Write("  </div>\r\n");
                streamWriter.Write(" </div>\r\n");
                streamWriter.Write("<!-- Skater info -->\r\n");
                streamWriter.Write(" <div class='row'>\r\n");
                string Left1 = BC;
                if (Operators.CompareString(Left1, " bgcolor='FFFF99'", false) == 0)
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"  <div class='small-2 large-1 columns latest-green'><p>", Program.TArrLive[1, 1]), (object)"</p></div>"), (object)"\r\n"));
                else if (Operators.CompareString(Left1, " bgcolor='#CCFFFF'", false) == 0)
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"  <div class='small-2 large-1 columns latest-yellow'><p>", Program.TArrLive[1, 1]), (object)"</p></div>"), (object)"\r\n"));
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"  <div class='small-9 large-3 columns'><p>", Program.TArrLive[1, 3]), (object)"</p></div>"), (object)"\r\n"));
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"  <div class='show-for-large-up large-3 columns'><p>", Program.TArrLive[1, 4]), (object)"</p></div>"), (object)"\r\n"));
                streamWriter.Write("  <div class='small-12 large-5 columns'>\r\n");
                streamWriter.Write("   <div class='row'>\r\n");
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"    <div class='small-2 columns'><h6 class='hide-for-large-up'>TSS</h6><p>", Program.TArrLive[1, 5]), (object)"</p></div>"), (object)"\r\n"));
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"    <div class='small-2 columns'><h6 class='hide-for-large-up'>TES</h6><p>", Program.TArrLive[1, 6]), (object)"</p></div>"), (object)"\r\n"));
                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"    <div class='small-2 columns'><h6 class='hide-for-large-up'>PCS</h6><p>", Program.TArrLive[1, 7]), (object)"</p></div>"), (object)"\r\n"));
                if (Program.Bonus_Sel(Program.Segment))
                {
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"    <div class='small-2 columns'><h6 class='hide-for-large-up'>Ded</h6><p>", Program.TArrLive[1, 8]), (object)"</p></div>"), (object)"\r\n"));
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"    <div class='small-2 columns end'><h6 class='hide-for-large-up'>Bon</h6><p>", Program.TArrLive[1, 9]), (object)"</p></div>"), (object)"\r\n"));
                }
                else
                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"    <div class='small-2 columns end'><h6 class='hide-for-large-up'>Ded</h6><p>", Program.TArrLive[1, 8]), (object)"</p></div>"), (object)"\r\n"));
                streamWriter.Write("   </div>\r\n");
                streamWriter.Write("  </div>\r\n");
                streamWriter.Write(" </div>\r\n");
                streamWriter.Write(" <hr style='margin-top:30px;' />\r\n");
                streamWriter.Write(" </div>\r\n");
                streamWriter.Write("</div>\r\n");
                if (Program.TNop > 0)
                {
                    if (row > 1)
                    {
                        streamWriter.Write("<!-- Current standing -->\r\n");
                        streamWriter.Write("<div class='row'>\r\n");
                        streamWriter.Write(" <div class='small-12 columns'>\r\n");
                        streamWriter.Write("  <div class='row'>\r\n");
                        streamWriter.Write("   <div class='small-12 columns'><h4>Current standings</h4></div> \r\n");
                        streamWriter.Write("  </div>\r\n");
                        streamWriter.Write("<!-- Headlines -->\r\n");
                        streamWriter.Write("  <div class='row'>\r\n");
                        streamWriter.Write("   <div class='small-2 large-1 columns'><h5>Place</h5></div>\r\n");
                        streamWriter.Write("   <div class='small-8 large-3 columns'><h5>Name</h5></div>\r\n");
                        streamWriter.Write("   <div class='show-for-large-up large-3 columns end'><h5>Club</h5></div>\r\n");
                        streamWriter.Write("   <div class='small-12 show-for-large-up large-5 columns'>\r\n");
                        streamWriter.Write("    <div class='row'>\r\n");
                        string seg1 = Program.GetSeg();
                        if (Operators.CompareString(seg1, "SS", false) == 0)
                        {
                            string segment = Program.Segment;
                            if (Operators.CompareString(segment, "Seg1", false) == 0)
                                streamWriter.Write("    <div class='small-2 columns'><h6>TSS</h6></div>\r\n");
                            else if (Operators.CompareString(segment, "Seg2", false) == 0)
                            {
                                streamWriter.Write("    <div class='small-2 columns'><h6>Total</h6></div>\r\n");
                                streamWriter.Write("    <div class='small-2 columns'><h6>SP</h6></div>\r\n");
                                streamWriter.Write("    <div class='small-2 columns end'><h6>SP</h6></div>\r\n");
                            }
                        }
                        else if (Operators.CompareString(seg1, "S0", false) == 0 || Operators.CompareString(seg1, "0F", false) == 0)
                            streamWriter.Write("    <div class='small-2 columns end'><h6>Total</h6></div>\r\n");
                        else if (Operators.CompareString(seg1, "SF", false) == 0)
                        {
                            string segment = Program.Segment;
                            if (Operators.CompareString(segment, "Seg1", false) == 0)
                                streamWriter.Write("    <div class='small-2 columns'><h6>TSS</h6></div>\r\n");
                            else if (Operators.CompareString(segment, "Seg2", false) == 0)
                            {
                                streamWriter.Write("    <div class='small-2 columns'><h6>Total</h6></div>\r\n");
                                streamWriter.Write("    <div class='small-2 columns'><h6>SP</h6></div>\r\n");
                                streamWriter.Write("    <div class='small-2 columns end'><h6>FS</h6></div>\r\n");
                            }
                        }
                        else if (Operators.CompareString(seg1, "FF", false) == 0)
                        {
                            string segment = Program.Segment;
                            if (Operators.CompareString(segment, "Seg1", false) == 0)
                                streamWriter.Write("    <div class='small-2 columns'><h6>TSS</h6></div>\r\n");
                            else if (Operators.CompareString(segment, "Seg2", false) == 0)
                            {
                                streamWriter.Write("    <div class='small-2 columns'><h6>Total</h6></div>\r\n");
                                streamWriter.Write("    <div class='small-2 columns'><h6>FS</h6></div>\r\n");
                                streamWriter.Write("    <div class='small-2 columns end'><h6>FS</h6></div>\r\n");
                            }
                        }
                        streamWriter.Write("   </div>\r\n");
                        streamWriter.Write("  </div>\r\n");
                        streamWriter.Write(" </div>\r\n");
                        int num3 = row;
                        int index = 2;
                        while (index <= num3)
                        {
                            string str = !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(Program.TArrResult[index, 5])) ? Conversions.ToString(Program.TArrResult[index, 5]) : Strings.Format(RuntimeHelpers.GetObjectValue(Program.TArrResult[index, 5]), "0.00");
                            streamWriter.Write("<!-- Skater info -->\r\n");
                            if (Operators.CompareString(Strings.Trim(Conversions.ToString(StNo)), Strings.Trim(Conversions.ToString(Program.TArrResult[index, 2])), false) == 0)
                            {
                                string Left2 = BC;
                                if (Operators.CompareString(Left2, " bgcolor='FFFF99'", false) == 0)
                                    streamWriter.Write(" <div class='row list latest-green'>\r\n");
                                else if (Operators.CompareString(Left2, " bgcolor='#CCFFFF'", false) == 0)
                                    streamWriter.Write(" <div class='row list latest-yellow'>\r\n");
                            }
                            else
                                streamWriter.Write(" <div class='row list'>\r\n");
                            streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"  <div class='small-2 large-1 columns'><p>", Program.TArrResult[index, 1]), (object)"</p></div>"), (object)"\r\n"));
                            streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"  <div class='small-10 large-3 columns'><p>", Program.TArrResult[index, 3]), (object)"</p></div>"), (object)"\r\n"));
                            streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"  <div class='show-for-large-up large-3 columns'><p>", Program.TArrResult[index, 4]), (object)"</p></div>"), (object)"\r\n"));
                            streamWriter.Write("  <div class='small-12 large-5 columns'>\r\n");
                            streamWriter.Write("   <div class='row'>\r\n");
                            string seg2 = Program.GetSeg();
                            if (Operators.CompareString(seg2, "S0", false) == 0 || Operators.CompareString(seg2, "0F", false) == 0)
                                streamWriter.Write("    <div class='small-2 columns end'><h6 class='hide-for-large-up'>Total</h6><p>" + str + "</p></div>\r\n");
                            else if (Operators.CompareString(seg2, "SS", false) == 0 || Operators.CompareString(seg2, "SF", false) == 0 || Operators.CompareString(seg2, "FF", false) == 0)
                            {
                                string segment = Program.Segment;
                                if (Operators.CompareString(segment, "Seg1", false) == 0)
                                    streamWriter.Write("    <div class='small-2 columns'><h6 class='hide-for-large-up'>Total</h6><p>" + str + "</p></div>\r\n");
                                else if (Operators.CompareString(segment, "Seg2", false) == 0)
                                {
                                    streamWriter.Write("    <div class='small-2 columns'><h6 class='hide-for-large-up'>Total</h6><p>" + str + "</p></div>\r\n");
                                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"    <div class='small-2 columns'><h6 class='hide-for-large-up'>SP</h6><p>", Program.TArrResult[index, 6]), (object)"</p></div>"), (object)"\r\n"));
                                    streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"    <div class='small-2 columns end'><h6 \tclass='hide-for-large-up'>FS</h6><p>", Program.TArrResult[index, 7]), (object)"</p></div>"), (object)"\r\n"));
                                }
                            }
                            streamWriter.Write("   </div>\r\n");
                            streamWriter.Write("  </div>\r\n");
                            streamWriter.Write("</div>\r\n");
                            checked { ++index; }
                        }
                        streamWriter.Write(" <hr style='margin-top:30px;' />\r\n");
                        streamWriter.Write(" </div>\r\n");
                        streamWriter.Write("</div>\r\n");
                    }
                    if (rowRemain > 1)
                    {
                        streamWriter.Write("<!-- Remaining skaters -->\r\n");
                        streamWriter.Write("<div class='row'>\r\n");
                        streamWriter.Write("<div class='small-12 columns'>\r\n");
                        streamWriter.Write("  <div class='row'>\r\n");
                        streamWriter.Write("   <div class='small-12 columns'><h4>Remaining skaters</h4></div>\r\n");
                        streamWriter.Write("  </div>\r\n");
                        streamWriter.Write("<!-- Headlines -->\r\n");
                        streamWriter.Write(" <div class='row'>\r\n");
                        streamWriter.Write("  <div class='small-2 large-1 columns'><h5>St</h5></div>\r\n");
                        streamWriter.Write("  <div class='small-10 large-3 columns'><h5>Name</h5></div>\r\n");
                        streamWriter.Write("  <div class='show-for-large-up large-3 columns end'><h5>Club</h5></div>\r\n");
                        streamWriter.Write(" </div>\r\n");
                        int num4 = rowRemain;
                        int index = 2;
                        while (index <= num4)
                        {
                            if (index < rowRemain)
                            {
                                streamWriter.Write("<!-- Skater info -->\r\n");
                                streamWriter.Write(" <div class='row'>\r\n");
                                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"  <div class='small-2 large-1 columns'><p>", Program.TArrNext[index, 1]), (object)"</p></div>"), (object)"\r\n"));
                                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"  <div class='small-10 large-3 columns'><p>", Program.TArrNext[index, 3]), (object)"</p></div>  "), (object)"\r\n"));
                                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"  <div class='show-for-large-up large-3 columns end'><p>", Program.TArrNext[index, 4]), (object)"</p></div>\t"), (object)"\r\n"));
                                streamWriter.Write(" </div>\r\n");
                            }
                            else
                            {
                                streamWriter.Write("<!-- Skater info (last block is different) -->\r\n");
                                streamWriter.Write(" <div class='row'>\r\n");
                                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"  <div class='small-2 large-1 columns'><p>", Program.TArrNext[index, 1]), (object)"</p></div>"), (object)"\r\n"));
                                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"  <div class='small-10 large-3 columns'><p>", Program.TArrNext[index, 3]), (object)"</p></div> "), (object)"\r\n"));
                                streamWriter.Write(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"  <div class='show-for-large-up large-3 columns end'><p>", Program.TArrNext[index, 4]), (object)"</p></div> "), (object)"\r\n"));
                                streamWriter.Write(" </div>\r\n");
                                streamWriter.Write(" <hr />\r\n");
                                streamWriter.Write(" </div>\r\n");
                                streamWriter.Write("</div>\r\n");
                            }
                            checked { ++index; }
                        }
                    }
                    streamWriter.Write("<div class='row'>\r\n");
                    streamWriter.Write(" <div class='small-12 columns'>\r\n");
                    streamWriter.Write("  <p class='footer'>Updated, " + Program.DateTimeToStr(DateTime.Now) + "</p>\r\n");
                    streamWriter.Write(" </div>\r\n");
                    streamWriter.Write("</div>\r\n");
                    streamWriter.Write("</body>\r\n");
                    streamWriter.Write("</html>\r\n");
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
                flag = true;
                goto label_60;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                flag = false;
                int num5 = (int)Interaction.MsgBox((object)("MakeCSS - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_60:
            int num6 = flag ? 1 : 0;
            if (num2 == 0)
                return num6 != 0;
            ProjectData.ClearProjectError();
            return num6 != 0;
        }

        public static void SortListSeg1(int NoOfSkater)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                Program.DNS_Seg1 = 0;
                num3 = 3;
                int num4 = NoOfSkater;
                int index1 = 1;
                while (index1 <= num4)
                {
                    num3 = 4;
                    if (Program.Vek[index1].Finished_Seg1 == 0 | Program.Vek[index1].DNS_Seg1 > 0)
                    {
                        num3 = 5;
                        checked { ++Program.DNS_Seg1; }
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
                    Program.Participant participant = Program.Vek[index2];
                    num3 = 10;
                    int index3 = index2;
                    num3 = 11;
                    int num6 = checked(index2 + 1);
                    int num7 = NoOfSkater;
                    int index4 = num6;
                    while (index4 <= num7)
                    {
                        num3 = 12;
                        if (Program.Vek[index4].Finished_Seg1 > participant.Finished_Seg1 | Program.Vek[index4].DNS_Seg1 < participant.DNS_Seg1)
                        {
                            num3 = 13;
                            participant = Program.Vek[index4];
                            num3 = 14;
                            index3 = index4;
                        }
                        num3 = 16;
                        checked { ++index4; }
                    }
                    num3 = 17;
                    Program.Vek[index3] = Program.Vek[index2];
                    num3 = 18;
                    Program.Vek[index2] = participant;
                    num3 = 19;
                    checked { ++index2; }
                }
                num3 = 20;
                int num8 = checked(NoOfSkater - 1 - Program.DNS_Seg1);
                int index5 = 1;
                while (index5 <= num8)
                {
                    num3 = 21;
                    Program.Participant participant = Program.Vek[index5];
                    num3 = 22;
                    int index6 = index5;
                    num3 = 23;
                    int num9 = checked(index5 + 1);
                    int num10 = checked(NoOfSkater - Program.DNS_Seg1);
                    int index7 = num9;
                    while (index7 <= num10)
                    {
                        num3 = 24;
                        if (Program.Vek[index7].Score_Seg1 > participant.Score_Seg1)
                        {
                            num3 = 25;
                            participant = Program.Vek[index7];
                            num3 = 26;
                            index6 = index7;
                        }
                        num3 = 28;
                        checked { ++index7; }
                    }
                    num3 = 29;
                    Program.Vek[index6] = Program.Vek[index5];
                    num3 = 30;
                    Program.Vek[index5] = participant;
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

        public static void Seg1Pl(int TNop)
        {
            int num1 = 0;
            int num2 = 0;
            int index1 = 1;
            int i1 = index1;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int P = 1;
                num3 = 3;
                int no = 0;
                num3 = 4;
                Program.Vek[1].Place_Seg1 = P;
                num3 = 5;
                int num4 = checked(TNop - 1);
                while (index1 <= num4)
                {
                    num3 = 6;
                    if (Conversion.Int(100.0 * Program.Vek[index1].Score_Seg1 + 1E-09) == Conversion.Int(100.0 * Program.Vek[checked(index1 + 1)].Score_Seg1 + 1E-09))
                    {
                        num3 = 7;
                        if (no == 0)
                            num3 = 8;
                        num3 = 10;
                        P = P;
                        num3 = 11;
                        checked { ++no; }
                    }
                    else
                    {
                        num3 = 13;
                        num3 = 14;
                        string progType = Program.GetProgType("Seg1");
                        num3 = 17;
                        if (Operators.CompareString(progType, "Short", false) == 0)
                        {
                            num3 = 18;
                            if (no > 0)
                            {
                                num3 = 19;
                                Program.SortSeg1Tech(i1, no, P);
                            }
                        }
                        else
                        {
                            num3 = 22;
                            if (Operators.CompareString(progType, "Free", false) == 0)
                            {
                                num3 = 23;
                                if (no > 0)
                                {
                                    num3 = 24;
                                    Program.SortSeg1PC(i1, no, P);
                                }
                            }
                        }
                        num3 = 27;
                        P = checked(P + 1 + no);
                        num3 = 28;
                        no = 0;
                        num3 = 29;
                        Program.Vek[checked(index1 + 1)].Place_Seg1 = P;
                    }
                    num3 = 31;
                    checked { ++index1; }
                }
                num3 = 32;
                if (no > 0)
                {
                    num3 = 33;
                    Program.SortSeg1Tech(i1, no, P);
                }
                num3 = 35;
                int index2 = checked(TNop + 1);
                while (index2 <= 42)
                {
                    num3 = 36;
                    Program.Vek[index2].Place_Seg1 = 0;
                    num3 = 37;
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

        public static void SortSeg1Tech(int i1, int no, int P)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int num4 = i1;
                int num5 = checked(i1 + no - 1);
                int index1 = num4;
                while (index1 <= num5)
                {
                    num3 = 3;
                    Program.Participant participant = Program.Vek[index1];
                    num3 = 4;
                    int index2 = index1;
                    num3 = 5;
                    int num6 = checked(index1 + 1);
                    int num7 = checked(i1 + no);
                    int index3 = num6;
                    while (index3 <= num7)
                    {
                        num3 = 6;
                        if (Conversion.Int(100.0 * Program.Vek[index3].TES_Seg1 + 1E-09) > Conversion.Int(100.0 * participant.TES_Seg1 + 1E-09))
                        {
                            num3 = 7;
                            participant = Program.Vek[index3];
                            num3 = 8;
                            index2 = index3;
                        }
                        num3 = 10;
                        checked { ++index3; }
                    }
                    num3 = 11;
                    Program.Vek[index2] = Program.Vek[index1];
                    num3 = 12;
                    Program.Vek[index1] = participant;
                    num3 = 13;
                    checked { ++index1; }
                }
                num3 = 14;
                int num8 = P;
                num3 = 15;
                int index4 = i1;
                num3 = 16;
                int num9 = 0;
                num3 = 17;
                Program.Vek[index4].Place_Seg1 = P;
                num3 = 18;
                int num10 = checked(i1 + 1);
                int num11 = checked(i1 + no);
                int index5 = num10;
                while (index5 <= num11)
                {
                    num3 = 19;
                    if (Conversion.Int(100.0 * Program.Vek[index5].TES_Seg1 + 1E-09) == Conversion.Int(100.0 * Program.Vek[checked(index5 - 1)].TES_Seg1 + 1E-09))
                    {
                        num3 = 20;
                        Program.Vek[index5].Place_Seg1 = num8;
                        num3 = 21;
                        checked { ++num9; }
                    }
                    else
                    {
                        num3 = 23;
                        num3 = 24;
                        num8 = checked(num8 + 1 + num9);
                        num3 = 25;
                        Program.Vek[index5].Place_Seg1 = num8;
                    }
                    num3 = 27;
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

        public static void SortSeg1PC(int i1, int no, int P)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int num4 = P;
                num3 = 3;
                int num5 = i1;
                int num6 = checked(i1 + no - 1);
                int index1 = num5;
                while (index1 <= num6)
                {
                    num3 = 4;
                    Program.Participant participant = Program.Vek[index1];
                    num3 = 5;
                    int index2 = index1;
                    num3 = 6;
                    int num7 = checked(index1 + 1);
                    int num8 = checked(i1 + no);
                    int index3 = num7;
                    while (index3 <= num8)
                    {
                        num3 = 7;
                        if (Conversion.Int(100.0 * Program.Vek[index3].PCS_Seg1 + 1E-09) > Conversion.Int(100.0 * participant.PCS_Seg1 + 1E-09))
                        {
                            num3 = 8;
                            participant = Program.Vek[index3];
                            num3 = 9;
                            index2 = index3;
                        }
                        num3 = 11;
                        checked { ++index3; }
                    }
                    num3 = 12;
                    Program.Vek[index2] = Program.Vek[index1];
                    num3 = 13;
                    Program.Vek[index1] = participant;
                    num3 = 14;
                    checked { ++index1; }
                }
                num3 = 15;
                int index4 = i1;
                num3 = 16;
                int num9 = 0;
                num3 = 17;
                Program.Vek[index4].Place_Seg1 = P;
                num3 = 18;
                int num10 = checked(i1 + 1);
                int num11 = checked(i1 + no);
                int index5 = num10;
                while (index5 <= num11)
                {
                    num3 = 19;
                    if (Conversion.Int(100.0 * Program.Vek[index5].PCS_Seg1 + 1E-09) == Conversion.Int(100.0 * Program.Vek[checked(index5 - 1)].PCS_Seg1 + 1E-09))
                    {
                        num3 = 20;
                        Program.Vek[index5].Place_Seg1 = num4;
                        num3 = 21;
                        checked { ++num9; }
                    }
                    else
                    {
                        num3 = 23;
                        num3 = 24;
                        num4 = checked(num4 + 1 + num9);
                        num3 = 25;
                        Program.Vek[index5].Place_Seg1 = num4;
                    }
                    num3 = 27;
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

        public static void SortListSeg2(int NoOfSkater)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                Program.DNS_Seg1 = 0;
                num3 = 3;
                int num4 = NoOfSkater;
                int index1 = 1;
                while (index1 <= num4)
                {
                    num3 = 4;
                    if (Operators.CompareString(Program.OpenDB[Program.PcIndex].Segment_1, "S", false) == 0)
                    {
                        num3 = 5;
                        if (Program.Vek[index1].Finished_Seg1 == 0 | Program.Vek[index1].DNS_Seg1 > 0)
                        {
                            num3 = 6;
                            checked { ++Program.DNS_Seg1; }
                        }
                    }
                    else
                    {
                        num3 = 9;
                        num3 = 10;
                        if (Program.Vek[index1].DNS_Seg1 > 0)
                        {
                            num3 = 11;
                            checked { ++Program.DNS_Seg1; }
                        }
                    }
                    num3 = 14;
                    checked { ++index1; }
                }
                num3 = 15;
                int num5 = checked(NoOfSkater - 1);
                int index2 = 1;
                while (index2 <= num5)
                {
                    num3 = 16;
                    Program.Participant participant = Program.Vek[index2];
                    num3 = 17;
                    int index3 = index2;
                    num3 = 18;
                    int num6 = checked(index2 + 1);
                    int num7 = NoOfSkater;
                    int index4 = num6;
                    while (index4 <= num7)
                    {
                        num3 = 19;
                        if (Operators.CompareString(Program.OpenDB[Program.PcIndex].Segment_1, "S", false) == 0)
                        {
                            num3 = 20;
                            if (Program.Vek[index4].Finished_Seg1 > participant.Finished_Seg1 | Program.Vek[index4].DNS_Seg1 < participant.DNS_Seg1)
                            {
                                num3 = 21;
                                participant = Program.Vek[index4];
                                num3 = 22;
                                index3 = index4;
                            }
                        }
                        else
                        {
                            num3 = 25;
                            num3 = 26;
                            if (Program.Vek[index4].DNS_Seg1 < participant.DNS_Seg1)
                            {
                                num3 = 27;
                                participant = Program.Vek[index4];
                                num3 = 28;
                                index3 = index4;
                            }
                        }
                        num3 = 31;
                        checked { ++index4; }
                    }
                    num3 = 32;
                    Program.Vek[index3] = Program.Vek[index2];
                    num3 = 33;
                    Program.Vek[index2] = participant;
                    num3 = 34;
                    checked { ++index2; }
                }
                num3 = 35;
                Program.DNS_Seg2 = 0;
                num3 = 36;
                int num8 = checked(NoOfSkater - Program.DNS_Seg1);
                int index5 = 1;
                while (index5 <= num8)
                {
                    num3 = 37;
                    if (Program.Vek[index5].Finished_Seg2 == 0 | Program.Vek[index5].DNS_Seg2 > 0)
                    {
                        num3 = 38;
                        checked { ++Program.DNS_Seg2; }
                    }
                    num3 = 40;
                    checked { ++index5; }
                }
                num3 = 41;
                int num9 = checked(NoOfSkater - 1 - Program.DNS_Seg1);
                int index6 = 1;
                while (index6 <= num9)
                {
                    num3 = 42;
                    Program.Participant participant = Program.Vek[index6];
                    num3 = 43;
                    int index7 = index6;
                    num3 = 44;
                    int num10 = checked(index6 + 1);
                    int num11 = checked(NoOfSkater - Program.DNS_Seg1);
                    int index8 = num10;
                    while (index8 <= num11)
                    {
                        num3 = 45;
                        if (Program.Vek[index8].Finished_Seg2 > participant.Finished_Seg2 | Program.Vek[index8].DNS_Seg2 < participant.DNS_Seg2)
                        {
                            num3 = 46;
                            participant = Program.Vek[index8];
                            num3 = 47;
                            index7 = index8;
                        }
                        num3 = 49;
                        checked { ++index8; }
                    }
                    num3 = 50;
                    Program.Vek[index7] = Program.Vek[index6];
                    num3 = 51;
                    Program.Vek[index6] = participant;
                    num3 = 52;
                    checked { ++index6; }
                }
                num3 = 53;
                int num12 = checked(NoOfSkater - 1 - Program.DNS_Seg1 - Program.DNS_Seg2);
                int index9 = 1;
                while (index9 <= num12)
                {
                    num3 = 54;
                    Program.Participant participant = Program.Vek[index9];
                    num3 = 55;
                    int index10 = index9;
                    num3 = 56;
                    int num13 = checked(index9 + 1);
                    int num14 = checked(NoOfSkater - Program.DNS_Seg1 - Program.DNS_Seg2);
                    int index11 = num13;
                    while (index11 <= num14)
                    {
                        num3 = 57;
                        if (Program.Vek[index11].Score_Seg2 > participant.Score_Seg2)
                        {
                            num3 = 58;
                            participant = Program.Vek[index11];
                            num3 = 59;
                            index10 = index11;
                        }
                        num3 = 61;
                        checked { ++index11; }
                    }
                    num3 = 62;
                    Program.Vek[index10] = Program.Vek[index9];
                    num3 = 63;
                    Program.Vek[index9] = participant;
                    num3 = 64;
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

        public static void Seg2Pl(int NoP)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int P = 1;
                num3 = 3;
                int no = 0;
                num3 = 4;
                Program.Vek[1].Place_Seg2 = P;
                num3 = 5;
                int num4 = checked(NoP - 1);
                int index1 = 1;
                int i1 = index1;
                while (index1 <= num4)
                {
                    num3 = 6;
                    if (Conversion.Int(100.0 * Program.Vek[index1].Score_Seg2 + 1E-09) == Conversion.Int(100.0 * Program.Vek[checked(index1 + 1)].Score_Seg2 + 1E-09))
                    {
                        num3 = 7;
                        if (no == 0)
                            num3 = 8;
                        num3 = 10;
                        P = P;
                        num3 = 11;
                        checked { ++no; }
                    }
                    else
                    {
                        num3 = 13;
                        num3 = 14;
                        string progType = Program.GetProgType("Seg2");
                        num3 = 17;
                        if (Operators.CompareString(progType, "Short", false) == 0)
                        {
                            num3 = 18;
                            if (no > 0)
                            {
                                num3 = 19;
                                Program.SortSeg2Tech(i1, no, P);
                            }
                        }
                        else
                        {
                            num3 = 22;
                            if (Operators.CompareString(progType, "Free", false) == 0)
                            {
                                num3 = 23;
                                if (no > 0)
                                {
                                    num3 = 24;
                                    Program.SortSeg2PC(i1, no, P);
                                }
                            }
                        }
                        num3 = 27;
                        P = checked(P + 1 + no);
                        num3 = 28;
                        no = 0;
                        num3 = 29;
                        Program.Vek[checked(index1 + 1)].Place_Seg2 = P;
                    }
                    num3 = 31;
                    checked { ++index1; }
                }
                num3 = 32;
                if (no > 0)
                {
                    num3 = 33;
                    Program.SortSeg2PC(i1, no, P);
                }
                num3 = 35;
                int index2 = checked(NoP + 1);
                while (index2 <= 42)
                {
                    num3 = 36;
                    Program.Vek[index2].Place_Seg2 = 0;
                    num3 = 37;
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

        public static void SortSeg2Tech(int i1, int no, int P)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int num4 = i1;
                int num5 = checked(i1 + no - 1);
                int index1 = num4;
                while (index1 <= num5)
                {
                    num3 = 3;
                    Program.Participant participant = Program.Vek[index1];
                    num3 = 4;
                    int index2 = index1;
                    num3 = 5;
                    int num6 = checked(index1 + 1);
                    int num7 = checked(i1 + no);
                    int index3 = num6;
                    while (index3 <= num7)
                    {
                        num3 = 6;
                        if (Conversion.Int(100.0 * Program.Vek[index3].TES_Seg2 + 1E-09) > Conversion.Int(100.0 * participant.TES_Seg2 + 1E-09))
                        {
                            num3 = 7;
                            participant = Program.Vek[index3];
                            num3 = 8;
                            index2 = index3;
                        }
                        num3 = 10;
                        checked { ++index3; }
                    }
                    num3 = 11;
                    Program.Vek[index2] = Program.Vek[index1];
                    num3 = 12;
                    Program.Vek[index1] = participant;
                    num3 = 13;
                    checked { ++index1; }
                }
                num3 = 14;
                int num8 = P;
                num3 = 15;
                int index4 = i1;
                num3 = 16;
                int num9 = 0;
                num3 = 17;
                Program.Vek[index4].Place_Seg2 = P;
                num3 = 18;
                int num10 = checked(i1 + 1);
                int num11 = checked(i1 + no);
                int index5 = num10;
                while (index5 <= num11)
                {
                    num3 = 19;
                    if (Conversion.Int(100.0 * Program.Vek[index5].TES_Seg2 + 1E-09) == Conversion.Int(100.0 * Program.Vek[checked(index5 - 1)].TES_Seg2 + 1E-09))
                    {
                        num3 = 20;
                        Program.Vek[index5].Place_Seg2 = num8;
                        num3 = 21;
                        checked { ++num9; }
                    }
                    else
                    {
                        num3 = 23;
                        num3 = 24;
                        num8 = checked(num8 + 1 + num9);
                        num3 = 25;
                        Program.Vek[index5].Place_Seg2 = num8;
                    }
                    num3 = 27;
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

        public static void SortSeg2PC(int i1, int no, int P)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int num4 = P;
                num3 = 3;
                int num5 = i1;
                int num6 = checked(i1 + no - 1);
                int index1 = num5;
                while (index1 <= num6)
                {
                    num3 = 4;
                    Program.Participant participant = Program.Vek[index1];
                    num3 = 5;
                    int index2 = index1;
                    num3 = 6;
                    int num7 = checked(index1 + 1);
                    int num8 = checked(i1 + no);
                    int index3 = num7;
                    while (index3 <= num8)
                    {
                        num3 = 7;
                        if (Conversion.Int(100.0 * Program.Vek[index3].PCS_Seg2 + 1E-09) > Conversion.Int(100.0 * participant.PCS_Seg2 + 1E-09))
                        {
                            num3 = 8;
                            participant = Program.Vek[index3];
                            num3 = 9;
                            index2 = index3;
                        }
                        num3 = 11;
                        checked { ++index3; }
                    }
                    num3 = 12;
                    Program.Vek[index2] = Program.Vek[index1];
                    num3 = 13;
                    Program.Vek[index1] = participant;
                    num3 = 14;
                    checked { ++index1; }
                }
                num3 = 15;
                int index4 = i1;
                num3 = 16;
                int num9 = 0;
                num3 = 17;
                Program.Vek[index4].Place_Seg2 = P;
                num3 = 18;
                int num10 = checked(i1 + 1);
                int num11 = checked(i1 + no);
                int index5 = num10;
                while (index5 <= num11)
                {
                    num3 = 19;
                    if (Conversion.Int(100.0 * Program.Vek[index5].PCS_Seg2 + 1E-09) == Conversion.Int(100.0 * Program.Vek[checked(index5 - 1)].PCS_Seg2 + 1E-09))
                    {
                        num3 = 20;
                        Program.Vek[index5].Place_Seg2 = num4;
                        num3 = 21;
                        checked { ++num9; }
                    }
                    else
                    {
                        num3 = 23;
                        num3 = 24;
                        num4 = checked(num4 + 1 + num9);
                        num3 = 25;
                        Program.Vek[index5].Place_Seg2 = num4;
                    }
                    num3 = 27;
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

        public static void SumScore(int TNop)
        {
            int index = 1;
            do
            {
                Program.Vek[index].Score_Total = Program.Vek[index].Score_Seg1 + Program.Vek[index].Score_Seg2;
                checked { ++index; }
            }
            while (index <= 42);
        }

        public static void SortListTotal(int NoOfSkater)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                Program.DNS_Seg1 = 0;
                num3 = 3;
                int num4 = NoOfSkater;
                int index1 = 1;
                while (index1 <= num4)
                {
                    num3 = 4;
                    if (Program.Vek[index1].Finished_Seg1 == 0 | Program.Vek[index1].DNS_Seg1 > 0)
                    {
                        num3 = 5;
                        checked { ++Program.DNS_Seg1; }
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
                    Program.Participant participant = Program.Vek[index2];
                    num3 = 10;
                    int index3 = index2;
                    num3 = 11;
                    int num6 = checked(index2 + 1);
                    int num7 = NoOfSkater;
                    int index4 = num6;
                    while (index4 <= num7)
                    {
                        num3 = 12;
                        if (Program.Vek[index4].Finished_Seg1 > participant.Finished_Seg1 | Program.Vek[index4].DNS_Seg1 < participant.DNS_Seg1)
                        {
                            num3 = 13;
                            participant = Program.Vek[index4];
                            num3 = 14;
                            index3 = index4;
                        }
                        num3 = 16;
                        checked { ++index4; }
                    }
                    num3 = 17;
                    Program.Vek[index3] = Program.Vek[index2];
                    num3 = 18;
                    Program.Vek[index2] = participant;
                    num3 = 19;
                    checked { ++index2; }
                }
                num3 = 20;
                Program.DNS_Seg2 = 0;
                num3 = 21;
                int num8 = checked(NoOfSkater - Program.DNS_Seg1);
                int index5 = 1;
                while (index5 <= num8)
                {
                    num3 = 22;
                    if (Program.Vek[index5].Finished_Seg2 == 0 | Program.Vek[index5].DNS_Seg2 > 0)
                    {
                        num3 = 23;
                        checked { ++Program.DNS_Seg2; }
                    }
                    num3 = 25;
                    checked { ++index5; }
                }
                num3 = 26;
                int num9 = checked(NoOfSkater - 1 - Program.DNS_Seg1);
                int index6 = 1;
                while (index6 <= num9)
                {
                    num3 = 27;
                    Program.Participant participant = Program.Vek[index6];
                    num3 = 28;
                    int index7 = index6;
                    num3 = 29;
                    int num10 = checked(index6 + 1);
                    int num11 = checked(NoOfSkater - Program.DNS_Seg1);
                    int index8 = num10;
                    while (index8 <= num11)
                    {
                        num3 = 30;
                        if (Program.Vek[index8].Finished_Seg2 > participant.Finished_Seg2 | Program.Vek[index8].DNS_Seg2 < participant.DNS_Seg2)
                        {
                            num3 = 31;
                            participant = Program.Vek[index8];
                            num3 = 32;
                            index7 = index8;
                        }
                        num3 = 34;
                        checked { ++index8; }
                    }
                    num3 = 35;
                    Program.Vek[index7] = Program.Vek[index6];
                    num3 = 36;
                    Program.Vek[index6] = participant;
                    num3 = 37;
                    checked { ++index6; }
                }
                num3 = 38;
                int num12 = checked(NoOfSkater - 1 - Program.DNS_Seg2 - Program.DNS_Seg1);
                int index9 = 1;
                while (index9 <= num12)
                {
                    num3 = 39;
                    Program.Participant participant = Program.Vek[index9];
                    num3 = 40;
                    int index10 = index9;
                    num3 = 41;
                    int num13 = checked(index9 + 1);
                    int num14 = checked(NoOfSkater - Program.DNS_Seg2 - Program.DNS_Seg1);
                    int index11 = num13;
                    while (index11 <= num14)
                    {
                        num3 = 42;
                        if (Program.Vek[index11].Score_Total > participant.Score_Total)
                        {
                            num3 = 43;
                            participant = Program.Vek[index11];
                            num3 = 44;
                            index10 = index11;
                        }
                        num3 = 46;
                        checked { ++index11; }
                    }
                    num3 = 47;
                    Program.Vek[index10] = Program.Vek[index9];
                    num3 = 48;
                    Program.Vek[index9] = participant;
                    num3 = 49;
                    checked { ++index9; }
                }
                num3 = 50;
                int num15 = checked(NoOfSkater - Program.DNS_Seg2 - Program.DNS_Seg1 + 1);
                int num16 = checked(NoOfSkater - 1);
                int index12 = num15;
                while (index12 <= num16)
                {
                    num3 = 51;
                    Program.Participant participant = Program.Vek[index12];
                    num3 = 52;
                    int index13 = index12;
                    num3 = 53;
                    int num17 = checked(index12 + 1);
                    int num18 = NoOfSkater;
                    int index14 = num17;
                    while (index14 <= num18)
                    {
                        num3 = 54;
                        if (Program.Vek[index14].Score_Seg1 > participant.Score_Seg1)
                        {
                            num3 = 55;
                            participant = Program.Vek[index14];
                            num3 = 56;
                            index13 = index14;
                        }
                        num3 = 58;
                        checked { ++index14; }
                    }
                    num3 = 59;
                    Program.Vek[index13] = Program.Vek[index12];
                    num3 = 60;
                    Program.Vek[index12] = participant;
                    num3 = 61;
                    checked { ++index12; }
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

        public static void TotalPl(int NoP)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int P = 1;
                num3 = 3;
                int no = 0;
                num3 = 4;
                Program.Vek[1].Place = P;
                num3 = 5;
                int num4 = checked(NoP - 1);
                int index1 = 1;
                int i1 = index1;
                while (index1 <= num4)
                {
                    num3 = 6;
                    if (Conversion.Int(100.0 * Program.Vek[index1].Score_Total + 1E-09) == Conversion.Int(100.0 * Program.Vek[checked(index1 + 1)].Score_Total + 1E-09))
                    {
                        num3 = 7;
                        if (no == 0)
                            num3 = 8;
                        num3 = 10;
                        P = P;
                        num3 = 11;
                        checked { ++no; }
                    }
                    else
                    {
                        num3 = 13;
                        num3 = 14;
                        if (no > 0)
                        {
                            num3 = 15;
                            Program.SortTotalSeg2(i1, no, P);
                        }
                        num3 = 17;
                        P = checked(P + 1 + no);
                        num3 = 18;
                        no = 0;
                        num3 = 19;
                        Program.Vek[checked(index1 + 1)].Place = P;
                    }
                    num3 = 21;
                    checked { ++index1; }
                }
                num3 = 22;
                if (no > 0)
                {
                    num3 = 23;
                    Program.SortTotalSeg2(i1, no, P);
                }
                num3 = 25;
                int index2 = checked(NoP + 1);
                while (index2 <= 42)
                {
                    num3 = 26;
                    Program.Vek[index2].Place = 0;
                    num3 = 27;
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

        public static void SortTotalSeg2(int i1, int no, int P)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                int num4 = i1;
                int num5 = checked(i1 + no - 1);
                int index1 = num4;
                while (index1 <= num5)
                {
                    num3 = 3;
                    Program.Participant participant = Program.Vek[index1];
                    num3 = 4;
                    int index2 = index1;
                    num3 = 5;
                    int num6 = checked(index1 + 1);
                    int num7 = checked(i1 + no);
                    int index3 = num6;
                    while (index3 <= num7)
                    {
                        num3 = 6;
                        if (Conversion.Int(100.0 * Program.Vek[index3].Score_Seg2 + 1E-09) > Conversion.Int(100.0 * participant.Score_Seg2 + 1E-09))
                        {
                            num3 = 7;
                            participant = Program.Vek[index3];
                            num3 = 8;
                            index2 = index3;
                        }
                        num3 = 10;
                        checked { ++index3; }
                    }
                    num3 = 11;
                    Program.Vek[index2] = Program.Vek[index1];
                    num3 = 12;
                    Program.Vek[index1] = participant;
                    num3 = 13;
                    checked { ++index1; }
                }
                num3 = 14;
                int index4 = i1;
                num3 = 15;
                int num8 = P;
                num3 = 16;
                int num9 = 0;
                num3 = 17;
                Program.Vek[index4].Place = P;
                num3 = 18;
                int num10 = checked(i1 + 1);
                int num11 = checked(i1 + no);
                int index5 = num10;
                while (index5 <= num11)
                {
                    num3 = 19;
                    if (Conversion.Int(100.0 * Program.Vek[index5].Score_Seg2 + 1E-09) == Conversion.Int(100.0 * Program.Vek[checked(index5 - 1)].Score_Seg2 + 1E-09))
                    {
                        num3 = 20;
                        Program.Vek[index5].Place = num8;
                        num3 = 21;
                        checked { ++num9; }
                    }
                    else
                    {
                        num3 = 23;
                        num3 = 24;
                        num8 = checked(num8 + 1 + num9);
                        num3 = 25;
                        Program.Vek[index5].Place = num8;
                    }
                    num3 = 27;
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

        public static bool MakeDir(ref string Path)
        {
            int num1 = 0;
            bool flag = false;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 2;
                flag = false;
                string pathCompFile = Program.PathCompFile;
                if (Operators.CompareString(pathCompFile, "", false) != 0)
                {
                    if (Operators.CompareString(Strings.Right(Program.PathCompFile, 1), "\\", false) != 0)
                        pathCompFile += "\\";
                    Path = Program.StrConv(pathCompFile + Program.Competition.Name + "\\html\\");
                    Path = Strings.Len(Program.SubCategory) <= 0 ? Program.StrConv(Path + Program.Category.Name) + "\\" : Program.StrConv(Path + Program.Category.Name + "_" + Program.SubCategory) + "\\";
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
                int num4 = (int)Interaction.MsgBox((object)("MakeDir - Error in the folder or file name!\r\n" + Path + "\r\n" + Information.Err().Description), MsgBoxStyle.Critical | MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
        label_17:
            int num5 = flag ? 1 : 0;
            if (num2 == 0)
                return num5 != 0;
            ProjectData.ClearProjectError();
            return num5 != 0;
        }

        public static string CreatePath(string par, ref string Path)
        {
            string Path1 = "";
            string path = Conversions.ToString(false);
            if (Program.MakeDir(ref Path1))
            {
                string Left = par;
                if (Operators.CompareString(Left, "Segment_1", false) == 0 || Operators.CompareString(Left, "Segment_2", false) == 0 || Operators.CompareString(Left, "Final", false) == 0 || Operators.CompareString(Left, "HeadPage", false) == 0)
                {
                    string str;
                    if (Strings.Len(Program.SubCategory) > 0)
                        str = Program.Category.Name + "_" + Program.StrConv3(Program.SubCategory) + "_" + par;
                    else
                        str = Program.Category.Name + "_" + par;
                    Path1 += str;
                }
                else if (Operators.CompareString(Left, "", false) == 0)
                {
                    string str = Strings.Len(Program.SubCategory) <= 0 ? Program.Category.Name : Program.Category.Name + "_" + Program.StrConv3(Program.SubCategory);
                    Path1 += str;
                }
                Path = Program.StrConv(Path1);
                path = Conversions.ToString(true);
            }
            return path;
        }

        public static string StrConv(string txt)
        {
            int num1 = 0;
            string txt1 = "";
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                txt1 = (string)null;
                int num3 = Strings.Len(txt);
                int Start = 1;
                while (Start <= num3)
                {
                    string Left = Strings.Mid(txt, Start, 1);
                    if (Operators.CompareString(Left, "&", false) == 0 || Operators.CompareString(Left, "<", false) == 0 || Operators.CompareString(Left, ">", false) == 0 || Operators.CompareString(Left, ";", false) == 0)
                        ++Start;
                    else if (Operators.CompareString(Left, " ", false) != 0)
                    {
                        txt1 += Strings.Mid(txt, Start, 1);
                        ++Start;
                    }
                    else
                    {
                        txt1 += "_";
                        ++Start;
                    }
                }
                do
                    ;
                while (!Program.StrConv1(ref txt1));
                while (!Program.StrConv2(ref txt1))
                    ;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            string str = txt1;
            if (num2 == 0)
                return str;
            ProjectData.ClearProjectError();
            return str;
        }

        public static bool StrConv1(ref string txt)
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                flag = true;
                num3 = 3;
                int Length = Strings.InStr(1, txt, "_-");
                num3 = 4;
                if (Length > 1 & checked(Strings.Len(txt) - Length - 1) > 0)
                {
                    num3 = 5;
                    txt = Strings.Left(txt, Length) + Strings.Right(txt, checked(Strings.Len(txt) - Length - 1));
                    num3 = 6;
                    flag = false;
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

        public static bool StrConv2(ref string txt)
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                flag = true;
                num3 = 3;
                int Length = Strings.InStr(1, txt, "__");
                num3 = 4;
                if (Length > 1 & checked(Strings.Len(txt) - Length - 1) > 0)
                {
                    num3 = 5;
                    txt = Strings.Left(txt, Length) + Strings.Right(txt, checked(Strings.Len(txt) - Length - 1));
                    num3 = 6;
                    flag = false;
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

        public static string StrConv3(string txt)
        {
            int num1 = 0;
            string str1 = "";
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                str1 = (string)null;
                num3 = 3;
                int num4 = Strings.Len(txt);
                int Start = 1;
                while (Start <= num4)
                {
                    num3 = 4;
                    string Left = Strings.Mid(txt, Start, 1);
                    num3 = 7;
                    if (Operators.CompareString(Left, "\\", false) == 0)
                    {
                        num3 = 8;
                        str1 = str1;
                    }
                    else
                    {
                        num3 = 10;
                        if (Operators.CompareString(Left, "/", false) == 0)
                        {
                            num3 = 11;
                            str1 = str1;
                        }
                        else
                        {
                            num3 = 13;
                            if (Operators.CompareString(Left, ";", false) == 0)
                            {
                                num3 = 14;
                                str1 = str1;
                            }
                            else
                            {
                                num3 = 17;
                                str1 += Strings.Mid(txt, Start, 1);
                            }
                        }
                    }
                    num3 = 19;
                    checked { ++Start; }
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            string str2 = str1;
            if (num2 == 0)
                return str2;
            ProjectData.ClearProjectError();
            return str2;
        }

        public static void SortListSurname(int NoOfSkater)
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
                    Program.Participant participant = Program.Vek[index1];
                    num3 = 4;
                    int index2 = index1;
                    num3 = 5;
                    int num5 = checked(index1 + 1);
                    int num6 = NoOfSkater;
                    int index3 = num5;
                    while (index3 <= num6)
                    {
                        num3 = 6;
                        if (Operators.CompareString(Strings.UCase(Program.Vek[index3].Name.LName), Strings.UCase(participant.Name.LName), false) < 0)
                        {
                            num3 = 7;
                            participant = Program.Vek[index3];
                            num3 = 8;
                            index2 = index3;
                        }
                        num3 = 10;
                        checked { ++index3; }
                    }
                    num3 = 11;
                    Program.Vek[index2] = Program.Vek[index1];
                    num3 = 12;
                    Program.Vek[index1] = participant;
                    num3 = 13;
                    checked { ++index1; }
                }
                num3 = 14;
                int StartIndex = 0;
                num3 = 15;
                int NoOfSkater1 = 0;
                num3 = 16;
                int num7 = checked(NoOfSkater - 1);
                int index4 = 1;
                while (index4 <= num7)
                {
                    num3 = 17;
                    if (Operators.CompareString(Strings.UCase(Program.Vek[index4].Name.LName), Strings.UCase(Program.Vek[checked(index4 + 1)].Name.LName), false) == 0)
                    {
                        num3 = 18;
                        if (StartIndex == 0)
                        {
                            num3 = 19;
                            StartIndex = index4;
                        }
                        num3 = 21;
                        NoOfSkater1 = checked(index4 + 1);
                    }
                    else
                    {
                        num3 = 23;
                        num3 = 24;
                        if (NoOfSkater1 != StartIndex)
                        {
                            num3 = 25;
                            Program.SortFirstName(StartIndex, NoOfSkater1);
                        }
                        num3 = 27;
                        StartIndex = 0;
                        num3 = 28;
                        NoOfSkater1 = 0;
                    }
                    num3 = 30;
                    if (NoOfSkater1 != StartIndex)
                    {
                        num3 = 31;
                        Program.SortFirstName(StartIndex, NoOfSkater1);
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

        public static void SortFirstName(int StartIndex, int NoOfSkater)
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
                    Program.Participant participant = Program.Vek[index1];
                    num3 = 4;
                    int index2 = index1;
                    num3 = 5;
                    int num6 = checked(index1 + 1);
                    int num7 = NoOfSkater;
                    int index3 = num6;
                    while (index3 <= num7)
                    {
                        num3 = 6;
                        if (Operators.CompareString(Strings.UCase(Program.Vek[index3].Name.FName), Strings.UCase(participant.Name.FName), false) < 0)
                        {
                            num3 = 7;
                            participant = Program.Vek[index3];
                            num3 = 8;
                            index2 = index3;
                        }
                        num3 = 10;
                        checked { ++index3; }
                    }
                    num3 = 11;
                    Program.Vek[index2] = Program.Vek[index1];
                    num3 = 12;
                    Program.Vek[index1] = participant;
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

        public static int IndexEmptyRow()
        {
            DataGridView dataGridView1 = MyProject.Forms.StartListForm.DataGridView1;
            int index = 0;
            while (!(Strings.Len(RuntimeHelpers.GetObjectValue(dataGridView1.Rows[index].Cells[0].Value)) == 0 & Strings.Len(RuntimeHelpers.GetObjectValue(dataGridView1.Rows[index].Cells[1].Value)) == 0 & Strings.Len(RuntimeHelpers.GetObjectValue(dataGridView1.Rows[index].Cells[2].Value)) == 0 & Strings.Len(RuntimeHelpers.GetObjectValue(dataGridView1.Rows[index].Cells[3].Value)) == 0))
            {
                checked { ++index; }
                if (index > 41)
                    break;
            }
            return index;
        }

        public static int CalcLunch(ref int[] gr, int ReNo)
        {
            int num1 = 0;
            if (ReNo > 10)
            {
                int num2 = checked(ReNo - 10);
                int index = 1;
                while (index <= num2)
                {
                    checked { num1 += gr[index]; }
                    checked { ++index; }
                }
            }
            return num1;
        }

        public static int CalcRes(ref int[] gr, int ReNo)
        {
            int num1 = 0;
            if (ReNo > 0 & ReNo < 10)
            {
                int num2 = ReNo;
                int index = 1;
                while (index <= num2)
                {
                    checked { num1 += gr[index]; }
                    checked { ++index; }
                }
            }
            return num1;
        }

        public static bool TestStart()
        {
            Program.Competition.Name = MyProject.Forms.MainForm.txtCompetitionName.Text;
            bool flag;
            if (Strings.Len(Program.Category.Name) < 1 | Strings.Len(Program.Competition.Name) < 1 | Program.PcIndex < 0)
            {
                flag = false;
                int num = (int)Interaction.MsgBox((object)"Please load a Competition-DB or\r\nselect a Category, input the Name\r\nof the Competition etc!", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            else
                flag = true;
            return flag;
        }

        public static bool Bonus_Sel(string PT)
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            int index = 1;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                string Left = PT;
                num3 = 5;
                if (Operators.CompareString(Left, "Seg1", false) == 0)
                {
                    num3 = 6;
                }
                else
                {
                    num3 = 8;
                    if (Operators.CompareString(Left, "Seg2", false) == 0)
                    {
                        num3 = 9;
                        index = 2;
                    }
                }
                num3 = 11;
                switch (Program.OpenDB[Program.PcIndex].HT_Bonus_Calc[index])
                {
                    case 2:
                    case 3:
                        num3 = 15;
                        flag = true;
                        break;
                    default:
                        num3 = 18;
                        flag = false;
                        break;
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

        public static bool HalfTime_Sel()
        {
            int num1 = 0;
            bool flag = true;
            int num2 = 0;
            int index = 1;
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
                }
                else
                {
                    num3 = 8;
                    if (Operators.CompareString(segment, "Seg2", false) == 0)
                    {
                        num3 = 9;
                        index = 2;
                    }
                }
                num3 = 11;
                switch (Program.OpenDB[Program.PcIndex].HT_Bonus_Calc[index])
                {
                    case 1:
                    case 3:
                        num3 = 15;
                        flag = true;
                        break;
                    default:
                        num3 = 18;
                        flag = false;
                        break;
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

        public static void PrinterMessage()
        {
            if (Program.IsFormOpen((Form)MyProject.Forms.PrinterMessageForm))
                return;
            MyProject.Forms.PrinterMessageForm.Show();
        }

        public static string GetSeg1()
        {
            int num1 = 0;
            string str = "";
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                str = "";
                num3 = 3;
                if (Program.PcIndex > -1)
                {
                    num3 = 4;
                    string segment1 = Program.OpenDB[Program.PcIndex].Segment_1;
                    num3 = 7;
                    if (Operators.CompareString(segment1, "S", false) == 0)
                    {
                        num3 = 8;
                        str = "Short";
                    }
                    else
                    {
                        num3 = 10;
                        if (Operators.CompareString(segment1, "F", false) == 0)
                        {
                            num3 = 11;
                            str = "Free";
                        }
                        else
                        {
                            num3 = 14;
                            str = "-";
                        }
                    }
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            string seg1 = str;
            if (num2 == 0)
                return seg1;
            ProjectData.ClearProjectError();
            return seg1;
        }

        public static string GetSeg2()
        {
            int num1 = 0;
            string str = "";
            int num2 = 0;
            try
            {
                ProjectData.ClearProjectError();
                num1 = 1;
                int num3 = 2;
                str = "";
                num3 = 3;
                if (Program.PcIndex > -1)
                {
                    num3 = 4;
                    string segment2 = Program.OpenDB[Program.PcIndex].Segment_2;
                    num3 = 7;
                    if (Operators.CompareString(segment2, "S", false) == 0)
                    {
                        num3 = 8;
                        str = "Short";
                    }
                    else
                    {
                        num3 = 10;
                        if (Operators.CompareString(segment2, "F", false) == 0)
                        {
                            num3 = 11;
                            str = "Free";
                        }
                        else
                        {
                            num3 = 14;
                            str = "-";
                        }
                    }
                }
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            string seg2 = str;
            if (num2 == 0)
                return seg2;
            ProjectData.ClearProjectError();
            return seg2;
        }

        public static int GetJudgeNo(object ind)
        {
            int judgeNo = 0;
            if (Operators.ConditionalCompareObjectGreater(ind, (object)0, false))
            {
                int index = 1;
                while (!Operators.ConditionalCompareObjectEqual(ind, (object)Program.JudgeCompNo[index], false))
                {
                    checked { ++index; }
                    if (index > 7)
                        goto label_5;
                }
                judgeNo = index;
            }
        label_5:
            return judgeNo;
        }

        public static string GetProgType(string segin)
        {
            string progType = "";
            string Left = segin;
            if (Operators.CompareString(Left, "Seg1", false) == 0)
            {
                string seg = Program.GetSeg();
                if (Operators.CompareString(seg, "FF", false) == 0 || Operators.CompareString(seg, "F0", false) == 0 || Operators.CompareString(seg, "FS", false) == 0)
                    progType = "Free";
                else if (Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "SS", false) == 0 || Operators.CompareString(seg, "S0", false) == 0)
                    progType = "Short";
            }
            else if (Operators.CompareString(Left, "Seg2", false) == 0)
            {
                string seg = Program.GetSeg();
                if (Operators.CompareString(seg, "FF", false) == 0 || Operators.CompareString(seg, "SF", false) == 0 || Operators.CompareString(seg, "0F", false) == 0)
                    progType = "Free";
                else if (Operators.CompareString(seg, "SS", false) == 0 || Operators.CompareString(seg, "0S", false) == 0 || Operators.CompareString(seg, "FS", false) == 0)
                    progType = "Short";
            }
            else
                progType = "";
            return progType;
        }

        public static string GetSeg() => Program.PcIndex > -1 ? Program.OpenDB[Program.PcIndex].Segment_1 + Program.OpenDB[Program.PcIndex].Segment_2 : "";

        public static string GetSegTxt(string segin)
        {
            string segTxt = "";
            string Left = segin;
            if (Operators.CompareString(Left, "Seg1", false) == 0)
            {
                string seg = Program.GetSeg();
                if (Operators.CompareString(seg, "FF", false) == 0)
                    segTxt = "Segment 1 - Free Skating";
                else if (Operators.CompareString(seg, "SS", false) == 0)
                    segTxt = "Segment 1 - Short Program";
                else if (Operators.CompareString(seg, "SF", false) == 0)
                    segTxt = "Short Program";
                else if (Operators.CompareString(seg, "FS", false) == 0)
                    segTxt = "Free Skating";
                else if (Operators.CompareString(seg, "F0", false) == 0)
                    segTxt = "Free Skating";
                else if (Operators.CompareString(seg, "S0", false) == 0)
                    segTxt = "Short Program";
            }
            else if (Operators.CompareString(Left, "Seg2", false) == 0)
            {
                string seg = Program.GetSeg();
                if (Operators.CompareString(seg, "FF", false) == 0)
                    segTxt = "Segment 2 - Free Skating";
                else if (Operators.CompareString(seg, "SS", false) == 0)
                    segTxt = "Segment 2 - Short Program";
                else if (Operators.CompareString(seg, "SF", false) == 0)
                    segTxt = "Free Skating";
                else if (Operators.CompareString(seg, "FS", false) == 0)
                    segTxt = "Short Program";
                else if (Operators.CompareString(seg, "0F", false) == 0)
                    segTxt = "Free Skating";
                else if (Operators.CompareString(seg, "0S", false) == 0)
                    segTxt = "Short Program";
            }
            else if (Operators.CompareString(Left, "Final", false) == 0)
                segTxt = "Final Result";
            return segTxt;
        }

        public static string GetPath(string pathfile)
        {
            int Length = pathfile.LastIndexOf("\\");
            return Strings.Left(pathfile, Length);
        }

        public static string DateTimeToStr(DateTime Datum) => Strings.Format((object)Datum, "Short Date") + ", " + Strings.Format((object)Datum, "Long Time");

        public static string FormShortDate(DateTime Datum) => Strings.Format((object)Datum, "Short Date");

        public struct DateType
        {
            public DateTime Seg1;
            public string Seg1Start;
            public DateTime Seg2;
            public string Seg2Start;
        }

        public struct OpType
        {
            public string element;
            public string edge;
            public string replay;
        }

        public struct El_type
        {
            public int row;
            public string Elstr;
            public double Value;
            public double BaseValue;
        }

        public struct ImpType
        {
            public string JudgeNo;
            public string Name;
            public string Club;
            public string Category;
            public string Segment;
            public int NoE;
            public string[] EE;
            public int NoPC;
            public string[] PC;
            public long Deduct1;
            public long Deduct2;
            public long Deduct3;
            public int StartNo;
        }

        public struct NameID
        {
            public string Name;
            public string ID;
            public string Type;
        }

        public struct CatID
        {
            public string Name;
            public string ID;
            public string Type;
            public string IndTADiscipline;
            public string IndTAClass;
        }

        public struct JudgeType
        {
            public string Name;
            public string Club;
        }

        public struct SegType
        {
            public Program.JudgeType Seg1;
            public Program.JudgeType Seg2;
        }

        public struct Judge_type
        {
            public int[,] EE;
            public double[,] PC;
            public long[] Deduction;
        }

        public struct Name_type
        {
            public string FName;
            public string LName;
            public string ID;
        }

        public struct OpenDBType
        {
            public string Category;
            public string Warmup;
            public string Segment_1;
            public string Segment_2;
            public string Seg1Time;
            public string Seg2Time;
            public string JudgeSeg1Time;
            public string JudgeSeg2Time;
            public int GrSize;
            public double[] PCFactorsSeg1;
            public double[] PCFactorsSeg2;
            public double DedFall;
            public double DedInter;
            public int[] HT_Bonus_Calc;
            public int[] ElementTest;
            public string[] AllowedJumps;
        }

        public struct Participant
        {
            public Program.Name_type Name;
            public string Club;
            public string ClubID;
            public int Finished_Seg1;
            public int Finished_Seg2;
            public int Startno_Seg1;
            public int Startno_Seg2;
            public int WarmUp_Seg1;
            public int WarmUp_Seg2;
            public string[] SSS_Seg1;
            public string[] SSS_Seg1_edges;
            public string[] SSS_Seg2;
            public string[] SSS_Seg2_edges;
            public int DNS_Seg1;
            public int DNS_Seg2;
            public double TES_Seg1;
            public double TES_Seg2;
            public double PCS_Seg1;
            public double PCS_Seg2;
            public string ID;
            public Program.Judge_type J_Seg1;
            public Program.Judge_type J_Seg2;
            public int Bonus_Seg1;
            public int Bonus_Seg2;
            public int HTIndSeg1;
            public int HTIndSeg2;
            public int Place_Seg1;
            public int Place_Seg2;
            public int Place;
            public double Score_Seg1;
            public double Score_Seg2;
            public double Score_Total;
            public long Deductions_Seg1;
            public long Deductions_Seg2;
            public int Falls_seg1;
            public int Falls_seg2;
            public double Points;
        }

        public struct Comp_type
        {
            public int CompNo;
            public int JudgeNo;
            public int J_Func;
        }

        public struct IndTA_Type
        {
            public string Discipline;
            public string Klass;
            public string Klass_ID;
            public string FirstName;
            public string Surname;
            public string Participant_ID;
            public string PPC_S1;
            public string PPC_S2;
            public string Club;
            public string Club_ID;
        }
    }
}

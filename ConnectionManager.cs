// Decompiled with JetBrains decompiler
// Type: ClubCompFS.ConnectionManager
// Assembly: ClubCompFS_10p0p6, Version=1.0.0.6, Culture=neutral, PublicKeyToken=null
// MVID: 18AFA868-014F-449A-91A2-9536DA06DEFC
// Assembly location: E:\zz Personal_Doc\Personal\Cinzia\ClubCompFS_Version2_Oct2020_NEW3\ClubCompFS_NEW2.exe

using ClubCompFS.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClubCompFS
{
    public class ConnectionManager
    {
        protected TcpListener _Server;
        protected bool _IsRunning;
        private object _controls;
        private object txt1;

        public void Stop() => this._IsRunning = false;

        public void Start()
        {
            this._Server = new TcpListener(IPAddress.Any, Module1.PortNo);
            this._Server.ExclusiveAddressUse = false;
            this._Server.Start();
            this._Server.BeginAcceptTcpClient(new AsyncCallback(this.ClientConnect), (object)this._Server);
            this._IsRunning = true;
            new Task(new Action(this.DoWork)).Start();
        }

        protected void ClientConnect(IAsyncResult result)
        {
            if (!this._IsRunning)
                return;
            if (this._Server.Server.Connected)
            {
                int num = (int)Interaction.MsgBox((object)"Server connected", MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            TcpClient tcpClient = this._Server.EndAcceptTcpClient(result);
            Module1._Clients.Add(tcpClient);
            this._Server.BeginAcceptTcpClient(new AsyncCallback(this.ClientConnect), (object)this._Server);
        }

        protected void DoWork()
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string[] strArray1 = new string[101];
                ProjectData.ClearProjectError();
                num1 = 2;
                while (this._IsRunning)
                {
                    if (Module1._Clients.Count == 0)
                    {
                        Thread.Sleep(10);
                    }
                    else
                    {
                        int index1 = checked(Module1._Clients.Count - 1);
                        while (index1 >= 0)
                        {
                            TcpClient client = Module1._Clients[index1];
                            if (client.Client.Poll(1, SelectMode.SelectRead) & client.Available == 0)
                            {
                                string Right = client.Client.RemoteEndPoint.ToString();
                                int index2 = 1;
                                do
                                {
                                    if (Operators.CompareString(Module1.IPArr[index2], Right, false) == 0)
                                        Module1.IPArr[index2] = "";
                                    checked { ++index2; }
                                }
                                while (index2 <= 11);
                                Module1._Clients.Remove(client);
                                break;
                            }
                            if (client.Available > 0)
                            {
                                NetworkStream stream = client.GetStream();
                                byte[] bytes = new byte[checked(client.Available - 1 + 1)];
                                byte[] buffer = bytes;
                                int length = bytes.Length;
                                stream.Read(buffer, 0, length);
                                string Intxt = Encoding.UTF8.GetString(bytes);
                                string Right = client.Client.RemoteEndPoint.ToString();
                                if (Intxt.Contains("Client #"))
                                {
                                    string[] strArray2 = Intxt.Split(';');
                                    if (Operators.CompareString(strArray2[1], "Client #", false) == 0)
                                    {
                                        int integer = Conversions.ToInteger(strArray2[2]);
                                        if (Strings.Len(Module1.IPArr[integer]) > 3 & Operators.CompareString(Module1.IPArr[integer], Right, false) != 0)
                                        {
                                            Module1.IPreject[integer] = Right;
                                            int num3 = (int)Interaction.MsgBox((object)("Check the setup of the clients!\r\nPC No. " + Conversions.ToString(integer) + " is already connected!"), MsgBoxStyle.Exclamation | MsgBoxStyle.SystemModal, (object)"Susanne SW");
                                            Module1._Clients.Remove(client);
                                        }
                                        else
                                        {
                                            Module1.IPArr[integer] = Right;
                                            int index3 = 1;
                                            do
                                            {
                                                if (index3 != integer & Operators.CompareString(Module1.IPArr[index3], Right, false) == 0)
                                                    Module1.IPArr[index3] = "";
                                                checked { ++index3; }
                                            }
                                            while (index3 <= 11);
                                        }
                                    }
                                }
                                else
                                    this.CCinQue(Intxt);
                            }
                            checked { index1 += -1; }
                        }
                    }
                }
                this._Server.Stop();
                List<TcpClient>.Enumerator enumerator = Module1._Clients.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    TcpClient current = enumerator.Current;
                    if (current.Connected)
                        current.Close();
                }
                enumerator.Dispose();
                Module1._Clients.Clear();
                Module1.IPArr = (string[])null;
                Module1.IPArr = new string[21];
                goto label_34;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num4 = (int)Interaction.MsgBox((object)("Form1, DoWork - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_34:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void CCinQue(string Intxt)
        {
            int num1 = 0;
            int num2 = 0;
            try
            {
                string[] strArray1 = new string[101];
                ProjectData.ClearProjectError();
                num1 = 2;
                int Length1;
                for (string str1 = Intxt; Strings.Len(str1) > 3; str1 = Strings.Right(str1, Length1))
                {
                    int Length2 = str1.IndexOf(";");
                    string str2 = Strings.Left(str1, Length2);
                    int integer = Conversions.ToInteger(str2);
                    string str3 = Strings.Left(str1, checked(integer + str2.Length + 1));
                    Module1.Qin.Enqueue(str3);
                    Length1 = checked(str1.Length - integer - str2.Length - 1);
                    if (Length1 < 0)
                        break;
                }
                while (Module1.Qin.Count > 0)
                {
                    string str = Module1.Qin.Dequeue();
                    if (str.Contains("ClientALIVE #"))
                    {
                        string[] strArray2 = str.Split(';');
                        if (Operators.CompareString(strArray2[1], "ClientALIVE #", false) == 0)
                            Conversions.ToInteger(strArray2[2]);
                    }
                    else if (str.Contains("ClientRe #"))
                    {
                        if (Strings.Len(Module1.LastOutTxt) > 0)
                            this.SendMessage1(Module1.LastOutTxt);
                    }
                    else
                    {
                        MyProject.Forms.Form4.completed2 = false;
                        int integer = Conversions.ToInteger(str.Split(';')[2]);
                        Module1.UpdStr[integer] = str;
                        MyProject.Forms.Form4.completed2 = true;
                    }
                }
                goto label_18;
            }
            catch (Exception ex) when (ex != null & num1 != 0 & num2 == 0)
            {
                ProjectData.SetProjectError(ex);
            }
            num2 = -1;
            if (num1 == 2)
            {
                int num3 = (int)Interaction.MsgBox((object)("CCinQue - " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
            }
            label_18:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }

        public void SendMessage1(string msg)
        {
            int num1 = 0;
            int num2 = 0;
            int index1 = 0;
            try
            {
                string[] strArray = new string[101];
                ProjectData.ClearProjectError();
                num1 = 2;
                int index2 = checked(Module1._Clients.Count - 1);
                while (index2 >= 0)
                {
                    TcpClient client = Module1._Clients[index2];
                    if (!(client.Client.Poll(1, SelectMode.SelectRead) & client.Available == 0))
                    {
                        NetworkStream stream = client.GetStream();
                        byte[] bytes = Encoding.UTF8.GetBytes(msg);
                        byte[] buffer = bytes;
                        int length = bytes.Length;
                        stream.Write(buffer, 0, length);
                    }
                    checked { index2 += -1; }
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
                int num3 = (int)Interaction.MsgBox((object)("SendMessage1 -  " + Information.Err().Description), MsgBoxStyle.SystemModal, (object)"Susanne SW");
                Module1.IPArr[index1] = "";
            }
            label_11:
            if (num2 == 0)
                return;
            ProjectData.ClearProjectError();
        }
    }
}

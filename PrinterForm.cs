// Decompiled with JetBrains decompiler
// Type: ClubCompFS.PrinterForm
// Assembly: ClubCompFS_10p0p6, Version=1.0.0.6, Culture=neutral, PublicKeyToken=null
// MVID: F1E583B2-A781-4EC4-B47C-BA3F451903AE
// Assembly location: E:\zz Personal_Doc\Personal\Cinzia\programmaLibertas_openNEW\ClubCompFS_10p0p6.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ClubCompFS
{
    [DesignerGenerated]
    public class PrinterForm : Form
    {
        private IContainer components;
        [AccessedThroughProperty("txtPrint")]
        private Label _txtPrint;
        [AccessedThroughProperty("Timer1")]
        private Timer _Timer1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        public PrinterForm()
        {
            this.Load += new EventHandler(this.PrinterForm_Load);
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
            this.txtPrint = new Label();
            this.Timer1 = new Timer(this.components);
            this.Label1 = new Label();
            this.SuspendLayout();
            this.txtPrint.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.txtPrint.Location = new Point(3, 38);
            this.txtPrint.Name = "txtPrint";
            Label txtPrint = this.txtPrint;
            Size size1 = new Size(357, 24);
            Size size2 = size1;
            txtPrint.Size = size2;
            this.txtPrint.TabIndex = 0;
            this.txtPrint.Text = "txtPrint";
            this.txtPrint.TextAlign = ContentAlignment.MiddleCenter;
            this.Timer1.Interval = 2000;
            this.Label1.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new Point(6, 9);
            this.Label1.Name = "Label1";
            Label label1 = this.Label1;
            size1 = new Size(354, 24);
            Size size3 = size1;
            label1.Size = size3;
            this.Label1.TabIndex = 1;
            this.Label1.Text = "THE DEFAULT PRINTER IS ACTIVATED WITH:";
            this.Label1.TextAlign = ContentAlignment.MiddleCenter;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = SystemColors.Control;
            size1 = new Size(364, 66);
            this.ClientSize = size1;
            this.ControlBox = false;
            this.Controls.Add((Control)this.Label1);
            this.Controls.Add((Control)this.txtPrint);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Name = nameof(PrinterForm);
            this.ShowIcon = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Susanne Software";
            this.TopMost = true;
            this.ResumeLayout(false);
        }

        internal virtual Label txtPrint
        {
            get => this._txtPrint;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._txtPrint = value;
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

        internal virtual Label Label1
        {
            get => this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label1 = value;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
            this.Timer1.Enabled = false;
        }

        private void PrinterForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.Timer1.Enabled = true;
        }
    }
}

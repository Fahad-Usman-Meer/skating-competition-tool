// Decompiled with JetBrains decompiler
// Type: ClubCompFS.Form11
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
    public class Form11 : Form
    {
        private IContainer components;
        [AccessedThroughProperty("Button1")]
        private Button _Button1;
        [AccessedThroughProperty("Label1")]
        private Label _Label1;

        public Form11()
        {
            this.Load += new EventHandler(this.Form11_Load);
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
            this.Button1 = new Button();
            this.Label1 = new Label();
            this.SuspendLayout();
            this.Button1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Button1.Location = new Point(114, 41);
            this.Button1.Name = "Button1";
            Button button1 = this.Button1;
            Size size1 = new Size(96, 28);
            Size size2 = size1;
            button1.Size = size2;
            this.Button1.TabIndex = 0;
            this.Button1.Text = "OK";
            this.Button1.UseVisualStyleBackColor = true;
            this.Label1.AutoSize = true;
            this.Label1.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte)0);
            this.Label1.Location = new Point(2, 9);
            this.Label1.Name = "Label1";
            Label label1 = this.Label1;
            size1 = new Size(316, 17);
            Size size3 = size1;
            label1.Size = size3;
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Please wait until the printouts are created!";
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            size1 = new Size(319, 75);
            this.ClientSize = size1;
            this.ControlBox = false;
            this.Controls.Add((Control)this.Label1);
            this.Controls.Add((Control)this.Button1);
            this.Name = nameof(Form11);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "PRINTER MESSAGE";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();
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

        internal virtual Label Label1
        {
            get => this._Label1;
            [MethodImpl(MethodImplOptions.Synchronized)]
            set => this._Label1 = value;
        }

        private void Button1_Click(object sender, EventArgs e) => this.Close();

        private void Form11_Load(object sender, EventArgs e) => this.TopMost = true;
    }
}

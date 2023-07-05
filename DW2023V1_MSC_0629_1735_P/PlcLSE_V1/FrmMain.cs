using System;
using System.Windows.Forms;

namespace PlcLSE_V1
{
    public partial class FrmMain : Form
    {
        // 디자인 영역====================================================================================================================
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "PLC Sensor Setting";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "PLC Test Setting";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "PLC 채널명 Setting";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "PLC Get Data IO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        //================================================================================================================================



        public FrmMain()
        {
            InitializeComponent();

            frmChannelName = new FrmChannelName();
            frmPlcSensor = new FrmPlcSensor();
            frmDataIO = new FrmDataIO();

            frmPlcSensor.SetUnitAI01(frmChannelName.GetUnitAI01());
            frmPlcSensor.SetUnitAI02(frmChannelName.GetUnitAI02());
            frmPlcSensor.SetUnitAI03(frmChannelName.GetUnitAI03());
            frmPlcSensor.SetUnitAI04(frmChannelName.GetUnitAI04());
            frmPlcSensor.SetUnitAI05(frmChannelName.GetUnitAI05());
            frmPlcSensor.SetUnitAI06(frmChannelName.GetUnitAI06());
            frmPlcSensor.SetUnitAI07(frmChannelName.GetUnitAI07());
            frmPlcSensor.SetUnitAI08(frmChannelName.GetUnitAI08());
            frmPlcSensor.SetUnitAI09(frmChannelName.GetUnitAI09());
            frmPlcSensor.SetUnitAI10(frmChannelName.GetUnitAI10());
            frmPlcSensor.SetUnitAI11(frmChannelName.GetUnitAI11());
            frmPlcSensor.SetUnitAI12(frmChannelName.GetUnitAI12());

            mIns = this;
        }
        public static FrmMain mIns;
        FrmChannelName frmChannelName;
        FrmPlcSensor frmPlcSensor;
        FrmDataIO frmDataIO;
        FrmPlcTest frmPlcTest;

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmPlcSensor == null || frmPlcSensor.IsDisposed)
                frmPlcSensor = new FrmPlcSensor();
            frmPlcSensor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (frmPlcTest == null || frmPlcTest.IsDisposed) 
                frmPlcTest = new FrmPlcTest();
            frmPlcTest.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (frmChannelName == null || frmChannelName.IsDisposed)
                frmChannelName = new FrmChannelName();
            frmChannelName.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (frmDataIO == null || frmDataIO.IsDisposed)
                frmDataIO = new FrmDataIO();
            frmDataIO.Show();
        }

        
    }
}

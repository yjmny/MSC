using PlcLSE_V1.Data;
using log4net;
using System;
using System.Text;
using System.Windows.Forms;

namespace PlcLSE_V1
{
    public partial class FrmDataIO : Form
    {

        // 디자인 영역====================================================================================================================
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxDO01 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxDO02 = new System.Windows.Forms.TextBox();
            this.tbxDI03 = new System.Windows.Forms.TextBox();
            this.tbxDI04 = new System.Windows.Forms.TextBox();
            this.tbxDI01 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxDI02 = new System.Windows.Forms.TextBox();
            this.tbxAO01 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxAO02 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRead1 = new System.Windows.Forms.Button();
            this.tbxAI01 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAI10 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxAI09 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxAI08 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxAI07 = new System.Windows.Forms.TextBox();
            this.tbxAI06 = new System.Windows.Forms.TextBox();
            this.tbxAI05 = new System.Windows.Forms.TextBox();
            this.tbxAI11 = new System.Windows.Forms.TextBox();
            this.tbxAI02 = new System.Windows.Forms.TextBox();
            this.tbxAI04 = new System.Windows.Forms.TextBox();
            this.tbxAI12 = new System.Windows.Forms.TextBox();
            this.tbxAI03 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 537);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data IO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.tbxDO01);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.tbxDO02);
            this.panel1.Controls.Add(this.tbxDI03);
            this.panel1.Controls.Add(this.tbxDI04);
            this.panel1.Controls.Add(this.tbxDI01);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.tbxDI02);
            this.panel1.Controls.Add(this.tbxAO01);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.tbxAO02);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnRead1);
            this.panel1.Controls.Add(this.tbxAI01);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxAI10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxAI09);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbxAI08);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbxAI07);
            this.panel1.Controls.Add(this.tbxAI06);
            this.panel1.Controls.Add(this.tbxAI05);
            this.panel1.Controls.Add(this.tbxAI11);
            this.panel1.Controls.Add(this.tbxAI02);
            this.panel1.Controls.Add(this.tbxAI04);
            this.panel1.Controls.Add(this.tbxAI12);
            this.panel1.Controls.Add(this.tbxAI03);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 499);
            this.panel1.TabIndex = 31;
            // 
            // tbxDO01
            // 
            this.tbxDO01.BackColor = System.Drawing.SystemColors.Info;
            this.tbxDO01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDO01.Location = new System.Drawing.Point(464, 78);
            this.tbxDO01.Name = "tbxDO01";
            this.tbxDO01.Size = new System.Drawing.Size(100, 21);
            this.tbxDO01.TabIndex = 54;
            this.tbxDO01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(462, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 12);
            this.label16.TabIndex = 53;
            this.label16.Text = "DO 2ch";
            // 
            // tbxDO02
            // 
            this.tbxDO02.BackColor = System.Drawing.SystemColors.Info;
            this.tbxDO02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDO02.Location = new System.Drawing.Point(464, 105);
            this.tbxDO02.Name = "tbxDO02";
            this.tbxDO02.Size = new System.Drawing.Size(100, 21);
            this.tbxDO02.TabIndex = 55;
            this.tbxDO02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxDI03
            // 
            this.tbxDI03.BackColor = System.Drawing.SystemColors.Info;
            this.tbxDI03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDI03.Location = new System.Drawing.Point(358, 132);
            this.tbxDI03.Name = "tbxDI03";
            this.tbxDI03.Size = new System.Drawing.Size(100, 21);
            this.tbxDI03.TabIndex = 51;
            this.tbxDI03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxDI04
            // 
            this.tbxDI04.BackColor = System.Drawing.SystemColors.Info;
            this.tbxDI04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDI04.Location = new System.Drawing.Point(358, 159);
            this.tbxDI04.Name = "tbxDI04";
            this.tbxDI04.Size = new System.Drawing.Size(100, 21);
            this.tbxDI04.TabIndex = 52;
            this.tbxDI04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxDI01
            // 
            this.tbxDI01.BackColor = System.Drawing.SystemColors.Info;
            this.tbxDI01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDI01.Location = new System.Drawing.Point(358, 78);
            this.tbxDI01.Name = "tbxDI01";
            this.tbxDI01.Size = new System.Drawing.Size(100, 21);
            this.tbxDI01.TabIndex = 49;
            this.tbxDI01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(356, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 12);
            this.label15.TabIndex = 48;
            this.label15.Text = "DI 4ch";
            // 
            // tbxDI02
            // 
            this.tbxDI02.BackColor = System.Drawing.SystemColors.Info;
            this.tbxDI02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxDI02.Location = new System.Drawing.Point(358, 105);
            this.tbxDI02.Name = "tbxDI02";
            this.tbxDI02.Size = new System.Drawing.Size(100, 21);
            this.tbxDI02.TabIndex = 50;
            this.tbxDI02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxAO01
            // 
            this.tbxAO01.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAO01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAO01.Location = new System.Drawing.Point(252, 78);
            this.tbxAO01.Name = "tbxAO01";
            this.tbxAO01.Size = new System.Drawing.Size(100, 21);
            this.tbxAO01.TabIndex = 46;
            this.tbxAO01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(250, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 12);
            this.label12.TabIndex = 45;
            this.label12.Text = "AO 2ch";
            // 
            // tbxAO02
            // 
            this.tbxAO02.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAO02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAO02.Location = new System.Drawing.Point(252, 105);
            this.tbxAO02.Name = "tbxAO02";
            this.tbxAO02.Size = new System.Drawing.Size(100, 21);
            this.tbxAO02.TabIndex = 47;
            this.tbxAO02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(87, 350);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 12);
            this.label13.TabIndex = 43;
            this.label13.Text = "#11";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(87, 377);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 12);
            this.label14.TabIndex = 44;
            this.label14.Text = "#12";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 38;
            this.label6.Text = "#6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 39;
            this.label8.Text = "#7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 40;
            this.label9.Text = "#8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 41;
            this.label10.Text = "#9";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 42;
            this.label11.Text = "#10";
            // 
            // btnRead1
            // 
            this.btnRead1.Location = new System.Drawing.Point(790, 446);
            this.btnRead1.Name = "btnRead1";
            this.btnRead1.Size = new System.Drawing.Size(150, 50);
            this.btnRead1.TabIndex = 37;
            this.btnRead1.Text = "읽어 오기";
            this.btnRead1.UseVisualStyleBackColor = true;
            this.btnRead1.Click += new System.EventHandler(this.btnRead1_Click);
            // 
            // tbxAI01
            // 
            this.tbxAI01.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAI01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAI01.Location = new System.Drawing.Point(146, 78);
            this.tbxAI01.Name = "tbxAI01";
            this.tbxAI01.Size = new System.Drawing.Size(100, 21);
            this.tbxAI01.TabIndex = 11;
            this.tbxAI01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "#1";
            // 
            // tbxAI10
            // 
            this.tbxAI10.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAI10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAI10.Location = new System.Drawing.Point(146, 321);
            this.tbxAI10.Name = "tbxAI10";
            this.tbxAI10.Size = new System.Drawing.Size(100, 21);
            this.tbxAI10.TabIndex = 29;
            this.tbxAI10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "#2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "#3";
            // 
            // tbxAI09
            // 
            this.tbxAI09.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAI09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAI09.Location = new System.Drawing.Point(146, 294);
            this.tbxAI09.Name = "tbxAI09";
            this.tbxAI09.Size = new System.Drawing.Size(100, 21);
            this.tbxAI09.TabIndex = 27;
            this.tbxAI09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "#4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "#5";
            // 
            // tbxAI08
            // 
            this.tbxAI08.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAI08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAI08.Location = new System.Drawing.Point(146, 267);
            this.tbxAI08.Name = "tbxAI08";
            this.tbxAI08.Size = new System.Drawing.Size(100, 21);
            this.tbxAI08.TabIndex = 25;
            this.tbxAI08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "AI 12ch";
            // 
            // tbxAI07
            // 
            this.tbxAI07.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAI07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAI07.Location = new System.Drawing.Point(146, 240);
            this.tbxAI07.Name = "tbxAI07";
            this.tbxAI07.Size = new System.Drawing.Size(100, 21);
            this.tbxAI07.TabIndex = 23;
            this.tbxAI07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxAI06
            // 
            this.tbxAI06.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAI06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAI06.Location = new System.Drawing.Point(146, 213);
            this.tbxAI06.Name = "tbxAI06";
            this.tbxAI06.Size = new System.Drawing.Size(100, 21);
            this.tbxAI06.TabIndex = 21;
            this.tbxAI06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxAI05
            // 
            this.tbxAI05.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAI05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAI05.Location = new System.Drawing.Point(146, 186);
            this.tbxAI05.Name = "tbxAI05";
            this.tbxAI05.Size = new System.Drawing.Size(100, 21);
            this.tbxAI05.TabIndex = 19;
            this.tbxAI05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxAI11
            // 
            this.tbxAI11.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAI11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAI11.Location = new System.Drawing.Point(146, 348);
            this.tbxAI11.Name = "tbxAI11";
            this.tbxAI11.Size = new System.Drawing.Size(100, 21);
            this.tbxAI11.TabIndex = 12;
            this.tbxAI11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxAI02
            // 
            this.tbxAI02.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAI02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAI02.Location = new System.Drawing.Point(146, 105);
            this.tbxAI02.Name = "tbxAI02";
            this.tbxAI02.Size = new System.Drawing.Size(100, 21);
            this.tbxAI02.TabIndex = 13;
            this.tbxAI02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxAI04
            // 
            this.tbxAI04.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAI04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAI04.Location = new System.Drawing.Point(146, 159);
            this.tbxAI04.Name = "tbxAI04";
            this.tbxAI04.Size = new System.Drawing.Size(100, 21);
            this.tbxAI04.TabIndex = 17;
            this.tbxAI04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxAI12
            // 
            this.tbxAI12.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAI12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAI12.Location = new System.Drawing.Point(146, 375);
            this.tbxAI12.Name = "tbxAI12";
            this.tbxAI12.Size = new System.Drawing.Size(100, 21);
            this.tbxAI12.TabIndex = 14;
            this.tbxAI12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxAI03
            // 
            this.tbxAI03.BackColor = System.Drawing.SystemColors.Info;
            this.tbxAI03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAI03.Location = new System.Drawing.Point(146, 132);
            this.tbxAI03.Name = "tbxAI03";
            this.tbxAI03.Size = new System.Drawing.Size(100, 21);
            this.tbxAI03.TabIndex = 15;
            this.tbxAI03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(304, 465);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 12);
            this.label17.TabIndex = 56;
            this.label17.Text = "0~16,000 FLOAT 표시";
            // 
            // frmDataIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDataIO";
            this.Text = "frmAI";
            this.Load += new System.EventHandler(this.frmDataIO_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRead1;
        private System.Windows.Forms.TextBox tbxAI01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAI10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxAI09;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxAI08;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxAI07;
        private System.Windows.Forms.TextBox tbxAI06;
        private System.Windows.Forms.TextBox tbxAI05;
        private System.Windows.Forms.TextBox tbxAI11;
        private System.Windows.Forms.TextBox tbxAI02;
        private System.Windows.Forms.TextBox tbxAI04;
        private System.Windows.Forms.TextBox tbxAI12;
        private System.Windows.Forms.TextBox tbxAI03;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxDO01;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxDO02;
        private System.Windows.Forms.TextBox tbxDI03;
        private System.Windows.Forms.TextBox tbxDI04;
        private System.Windows.Forms.TextBox tbxDI01;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbxDI02;
        private System.Windows.Forms.TextBox tbxAO01;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxAO02;
        private System.Windows.Forms.Label label17;
        //================================================================================================================================


        private static readonly ILog log = LogManager.GetLogger("Measure");
        public FrmDataIO()
        {
            InitializeComponent();
            mIns = this;
            plcComm1 = new PlcComm(ip: "192.168.0.153", port: 2004);
            m_calc = new MscCalcClass();

        }
        public static FrmDataIO mIns;
        PlcComm plcComm1 = null;
        MscCalcClass m_calc = null;

        private void PlcSensorDataRead()
        {
            ReadPlcAI01_12(1);
            ReadPlcAO01_02(1);
            ReadPlcDI01_04(1);
            ReadPlcD001_02(1);
        }

        public string[] ReadPlcAIO_DIO()
        {
            string[] strRtnArray = null;
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(ReadPlcAanlogIO_14());
                sb.Append(",");
                sb.Append(ReadPlcDIO_6());
                string getData = sb.ToString();
                sb = null;
                strRtnArray = getData.Split(',');
                if (strRtnArray.Length != 20)
                {
                    strRtnArray = null;
                    strRtnArray = new string[20];
                    strRtnArray = getData.Split(',');
                    for (int i = 0; i < 20; i++)
                    {
                        if (string.IsNullOrEmpty(strRtnArray[i]))
                        {
                            strRtnArray[i] = "99999";
                        }

                    }
                }

                return strRtnArray;
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString(), this.Name + " ReadPlcAIO_DIO()");
                log.Error("[" + this.Name + "]\r\n " + exc.ToString());
                strRtnArray = null;
                strRtnArray = new string[20];
                for (int i = 0; i < strRtnArray.Length; i++)
                {
                    strRtnArray[i] = "99999";
                }
            }
            return strRtnArray;
        }


        public double Calculation(double dx1, double dy1, double dx2, double dy2, double dInValue, int iGetDataType = 1)
        {
            double dRtn = 0;

            if (iGetDataType == 1)
            {
                m_calc.CalculationX(dx1, dy1, dx2, dy2, out double dxValue, dInValue);
                dRtn = dxValue;
            }
            else
            {
                m_calc.CalculationY(dx1, dy1, dx2, dy2, out double dyValue, dInValue);
                dRtn = dyValue;
            }
            return dRtn;

        }

        public string ReadPlcAanlogIO_14()
        {
            int iUpdate = 230604;

            if (iUpdate == 230604)
            {

                string str1 = ReadPlcAIAO_14();
                try
                {
                    string[] dioArray = str1.Split(',');

                    if (dioArray.Length != 14)//1회차 에러발생
                    {
                        dioArray = null;
                        str1 = ReadPlcAIAO_14();
                        string[] dioArray1 = str1.Split(',');
                        if (dioArray1.Length != 14)//2회차 에러발생
                        {
                            dioArray1 = null;
                            str1 = ReadPlcAIAO_14();
                            string[] dioArray2 = str1.Split(',');
                            if (dioArray2.Length != 14)//3회차 에러발생
                            {
                                dioArray2 = null;
                                str1 = ReadPlcAIAO_14();
                                string[] dioArray3 = str1.Split(',');
                                if (dioArray3.Length != 14)//4회차 에러발생
                                {
                                    str1 = "99999,99999,99999,99999,99999,99999,99999,99999,99999,99999,99999,99999,99999,99999,";
                                }
                            }
                        }
                    }
                }
                catch (Exception exc)
                {
                    log.Error("[" + this.Name + "]\r\n " + exc.ToString());
                }
                return str1;
            }
            else
            {
                string str1 = ReadPlcAI01_12(0);//12
                string str2 = ReadPlcAO01_02(0);//2
                try
                {
                    if (isErrorOn)//1회차 에러발생
                    {
                        str1 = ReadPlcAI01_12(0);
                    }
                    if (isErrorOn)//2회차 에러발생
                    {
                        str1 = ReadPlcAI01_12(0);
                    }
                    if (isErrorOn)//3회차 에러발생
                    {
                        str1 = ReadPlcAI01_12(0);
                    }
                    if (isErrorOn)
                    {
                        str1 = "99999,99999,99999,99999,99999,99999,99999,99999,99999,99999,99999,99999";
                    }
                   
                    if (isErrorOn)//1회차 에러발생
                    {
                        str2 = ReadPlcAO01_02(0);
                    }
                    if (isErrorOn)//2회차 에러발생
                    {
                        str2 = ReadPlcAO01_02(0);
                    }
                    if (isErrorOn)//3회차 에러발생
                    {
                        str2 = ReadPlcAO01_02(0);
                    }
                    if (isErrorOn)
                    {
                        str2 = "99999,99999";
                    }
                }
                catch (Exception exc)
                {
                    log.Error("[" + this.Name + "]\r\n " + exc.ToString());
                }

                return str1 + "," + str2;
            }
        }
        public string ReadPlcDigitalIO()
        {
            string[] addrMapList = new string[] { "M0110", "M0111", "M0112", "M0113", "M0200", "M0201" };//6
            string strRtn = plcComm1.ReadBitEachRun(addrMapList);
            strRtn = strRtn.TrimEnd(',');
            return strRtn;
        }

        private string ReadPlcDIO_6()
        {
            string str1 = ReadPlcDigitalIO();
            string[] dioArray = str1.Split(',');

            if (dioArray.Length != 6)//1회차 에러발생
            {
                dioArray = null;
                str1 = ReadPlcDigitalIO();
                string[] dioArray1 = str1.Split(',');
                if (dioArray1.Length != 6)//2회차 에러발생
                {
                    dioArray1 = null;
                    str1 = ReadPlcDigitalIO();
                    string[] dioArray2 = str1.Split(',');
                    if (dioArray2.Length != 6)//3회차 에러발생
                    {
                        dioArray2 = null;
                        str1 = ReadPlcDigitalIO();
                        string[] dioArray3 = str1.Split(',');
                        if (dioArray3.Length != 6)//4회차 에러발생
                        {
                            str1 = "99999,99999,99999,99999,99999,99999,";
                        }
                    }
                }
            }
            return str1;
        }

        private string ReadPlcAIAO_14()
        {
            int[] iAddrList = new int[] { 700, 702, 704, 706, 708, 710, 712, 714, 716, 718, 720, 722, 1000, 1002 };
            string[] addrMapList = new string[14];
            string[] strArry_int32_float = new string[14];
            string strRtn = "";
            try
            {
                StringBuilder sbAddrLoc = new StringBuilder(0, 1024);
                for (int i = 0; i < strArry_int32_float.Length; i++)
                {
                    int iMapNoIndex = XGT.AddressCalcDword2Word(iAddrList[i]);
                    //string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                    //addrMapList[i] = sAddrLoc;
                    sbAddrLoc.Append("D");
                    sbAddrLoc.Append(String.Format("{0:D4}", iMapNoIndex));
                    addrMapList[i] = sbAddrLoc.ToString();
                    strArry_int32_float[i] = "FLOAT";
                    sbAddrLoc.Remove(0, sbAddrLoc.Length);
                }
                sbAddrLoc = null;
                strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            }
            catch (Exception exc)
            {
                log.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }                                                          
            return strRtn;
        }

        private string ReadPlcAI01_12(int iBurnInMode_10)
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 12;
            int iDataProcMax = 16;
            int startAddress = 700;
            string strRtn = "";
            try
            {
                if (iDataCountMax > iDataProcMax) { }
                else { iDataProcMax = iDataCountMax; }


                string[] addrMapList = new string[iDataProcMax];
                string[] strArry_int32_float = new string[iDataProcMax];
                for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
                {
                    int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                    string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                    addrMapList[idx] = sAddrLoc;
                    //strArry_int32_float[idx] = "INT32";
                    strArry_int32_float[idx] = "FLOAT";
                }

                strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
                                                                                     
                ChannelDataUpdate(1, strRtn, iBurnInMode_10);
            }
            catch (Exception exc)
            {
                log.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }
            return strRtn;
        }
        private string ReadPlcAO01_02(int iBurnInMode_10)
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 2;
            int iDataProcMax = 16;
            int startAddress = 1000;
            string strRtn = "";

            try
            {
                if (iDataCountMax > iDataProcMax) { }
                else { iDataProcMax = iDataCountMax; }


                string[] addrMapList = new string[iDataProcMax];
                string[] strArry_int32_float = new string[iDataProcMax];
                for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
                {
                    int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                    string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                    addrMapList[idx] = sAddrLoc;
                    strArry_int32_float[idx] = "FLOAT";
                }

                strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
                System.Diagnostics.Debug.WriteLine("ReadPlcAO01_02()" + strRtn);
                ChannelDataUpdate(2, strRtn, iBurnInMode_10);
            }
            catch (Exception exc)
            {
                log.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }

            return strRtn;
        }

        private string ReadPlcDI01_04(int iBurnInMode_10)
        {
            string[] addrMapList = new string[] { "M0110", "M0111", "M0112", "M0113" };
            string strRtn = plcComm1.ReadBitEachRun(addrMapList);
            ChannelDataUpdate(3, strRtn, iBurnInMode_10);

            return strRtn;
        }
        private string ReadPlcD001_02(int iBurnInMode_10)
        {
            string[] addrMapList = new string[] { "M0200", "M0201" };
            string strRtn = plcComm1.ReadBitEachRun(addrMapList);
            ChannelDataUpdate(4, strRtn, iBurnInMode_10);
            return strRtn;
        }

        bool isErrorOn = false;
        private void ChannelDataUpdate(int chNo, string strRtn, int iBurnInMode_10)
        {
            try
            {
                isErrorOn = false;
                string[] split_comma = strRtn.Split(',');

                if (iBurnInMode_10 == 1)
                {
                    switch (chNo)
                    {
                        case 1:
                            tbxAI01.Text = split_comma[0];
                            tbxAI02.Text = split_comma[1];
                            tbxAI03.Text = split_comma[2];
                            tbxAI04.Text = split_comma[3];
                            tbxAI05.Text = split_comma[4];
                            tbxAI06.Text = split_comma[5];
                            tbxAI07.Text = split_comma[6];
                            tbxAI08.Text = split_comma[7];
                            tbxAI09.Text = split_comma[8];
                            tbxAI10.Text = split_comma[9];
                            tbxAI11.Text = split_comma[10];
                            tbxAI12.Text = split_comma[11];
                            break;
                        case 2:
                            tbxAO01.Text = split_comma[0];
                            tbxAO02.Text = split_comma[1];
                            break;
                        case 3:
                            tbxDI01.Text = split_comma[0];
                            tbxDI02.Text = split_comma[1];
                            tbxDI03.Text = split_comma[2];
                            tbxDI04.Text = split_comma[3];
                            break;
                        case 4:
                            tbxDO01.Text = split_comma[0];
                            tbxDO02.Text = split_comma[1];
                            break;
                    }
                }
                else
                {
                    switch (chNo)
                    {
                        case 1:
                            if (split_comma.Length != 12) isErrorOn = true;
                            break;
                        case 2:
                            if (split_comma.Length != 2) isErrorOn = true;
                            break;
                        case 3:
                            if (split_comma.Length != 3) isErrorOn = true;
                            break;
                        case 4:
                            if (split_comma.Length != 2) isErrorOn = true;
                            break;
                    }

                }
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.ToString());
                isErrorOn = true;
            }
            finally
            {

            }
        }

        private void frmDataIO_Load(object sender, EventArgs e)
        {
            PlcSensorDataRead();
        }

        private void btnRead1_Click(object sender, EventArgs e)
        {
            PlcSensorDataRead();
        }
    }
}

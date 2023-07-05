using System.Windows.Forms;

namespace PlcLSE_V1
{
    public partial class FrmChannelName : Form
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
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxUnitAI12 = new System.Windows.Forms.TextBox();
            this.tbxNameAI12 = new System.Windows.Forms.TextBox();
            this.tbxUnitAI11 = new System.Windows.Forms.TextBox();
            this.tbxNameAI11 = new System.Windows.Forms.TextBox();
            this.tbxNameAI01 = new System.Windows.Forms.TextBox();
            this.tbxUnitAI10 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNameAI10 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxUnitAI09 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNameAI09 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxUnitAI08 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxNameAI08 = new System.Windows.Forms.TextBox();
            this.tbxUnitAI07 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxNameAI07 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxUnitAI06 = new System.Windows.Forms.TextBox();
            this.tbxNameAI06 = new System.Windows.Forms.TextBox();
            this.tbxUnitAI05 = new System.Windows.Forms.TextBox();
            this.tbxNameAI05 = new System.Windows.Forms.TextBox();
            this.tbxUnitAI01 = new System.Windows.Forms.TextBox();
            this.tbxUnitAI04 = new System.Windows.Forms.TextBox();
            this.tbxNameAI02 = new System.Windows.Forms.TextBox();
            this.tbxNameAI04 = new System.Windows.Forms.TextBox();
            this.tbxUnitAI02 = new System.Windows.Forms.TextBox();
            this.tbxUnitAI03 = new System.Windows.Forms.TextBox();
            this.tbxNameAI03 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxNameAO01 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tbxUnitAO02 = new System.Windows.Forms.TextBox();
            this.tbxNameAO02 = new System.Windows.Forms.TextBox();
            this.tbxUnitAO01 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxNameDI03 = new System.Windows.Forms.TextBox();
            this.tbxUnitDI04 = new System.Windows.Forms.TextBox();
            this.tbxNameDI04 = new System.Windows.Forms.TextBox();
            this.tbxUnitDI03 = new System.Windows.Forms.TextBox();
            this.tbxNameDI01 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.tbxUnitDI02 = new System.Windows.Forms.TextBox();
            this.tbxNameDI02 = new System.Windows.Forms.TextBox();
            this.tbxUnitDI01 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxNameDO01 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.tbxUnitDO02 = new System.Windows.Forms.TextBox();
            this.tbxNameDO02 = new System.Windows.Forms.TextBox();
            this.tbxUnitDO01 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
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
            this.tabPage1.Text = "채널 & 단위 설정";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.tbxNameDO01);
            this.panel1.Controls.Add(this.label45);
            this.panel1.Controls.Add(this.label51);
            this.panel1.Controls.Add(this.label52);
            this.panel1.Controls.Add(this.tbxUnitDO02);
            this.panel1.Controls.Add(this.tbxNameDO02);
            this.panel1.Controls.Add(this.tbxUnitDO01);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbxNameDI03);
            this.panel1.Controls.Add(this.tbxUnitDI04);
            this.panel1.Controls.Add(this.tbxNameDI04);
            this.panel1.Controls.Add(this.tbxUnitDI03);
            this.panel1.Controls.Add(this.tbxNameDI01);
            this.panel1.Controls.Add(this.label34);
            this.panel1.Controls.Add(this.label40);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.tbxUnitDI02);
            this.panel1.Controls.Add(this.tbxNameDI02);
            this.panel1.Controls.Add(this.tbxUnitDI01);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbxNameAO01);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.tbxUnitAO02);
            this.panel1.Controls.Add(this.tbxNameAO02);
            this.panel1.Controls.Add(this.tbxUnitAO01);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.tbxUnitAI12);
            this.panel1.Controls.Add(this.tbxNameAI12);
            this.panel1.Controls.Add(this.tbxUnitAI11);
            this.panel1.Controls.Add(this.tbxNameAI11);
            this.panel1.Controls.Add(this.tbxNameAI01);
            this.panel1.Controls.Add(this.tbxUnitAI10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxNameAI10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxUnitAI09);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxNameAI09);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxUnitAI08);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbxNameAI08);
            this.panel1.Controls.Add(this.tbxUnitAI07);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbxNameAI07);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbxUnitAI06);
            this.panel1.Controls.Add(this.tbxNameAI06);
            this.panel1.Controls.Add(this.tbxUnitAI05);
            this.panel1.Controls.Add(this.tbxNameAI05);
            this.panel1.Controls.Add(this.tbxUnitAI01);
            this.panel1.Controls.Add(this.tbxUnitAI04);
            this.panel1.Controls.Add(this.tbxNameAI02);
            this.panel1.Controls.Add(this.tbxNameAI04);
            this.panel1.Controls.Add(this.tbxUnitAI02);
            this.panel1.Controls.Add(this.tbxUnitAI03);
            this.panel1.Controls.Add(this.tbxNameAI03);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 499);
            this.panel1.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(87, 350);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 12);
            this.label17.TabIndex = 46;
            this.label17.Text = "AI - 11";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(87, 377);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 12);
            this.label18.TabIndex = 47;
            this.label18.Text = "AI - 12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 12);
            this.label12.TabIndex = 41;
            this.label12.Text = "AI - 06";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(87, 242);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 12);
            this.label13.TabIndex = 42;
            this.label13.Text = "AI - 07";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(87, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 12);
            this.label14.TabIndex = 43;
            this.label14.Text = "AI - 08";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(87, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 12);
            this.label15.TabIndex = 44;
            this.label15.Text = "AI - 09";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(87, 323);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 12);
            this.label16.TabIndex = 45;
            this.label16.Text = "AI - 10";
            // 
            // tbxUnitAI12
            // 
            this.tbxUnitAI12.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitAI12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI12.Location = new System.Drawing.Point(252, 375);
            this.tbxUnitAI12.Name = "tbxUnitAI12";
            this.tbxUnitAI12.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI12.TabIndex = 40;
            this.tbxUnitAI12.Text = "AI12";
            this.tbxUnitAI12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNameAI12
            // 
            this.tbxNameAI12.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameAI12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameAI12.Location = new System.Drawing.Point(146, 375);
            this.tbxNameAI12.Name = "tbxNameAI12";
            this.tbxNameAI12.Size = new System.Drawing.Size(100, 21);
            this.tbxNameAI12.TabIndex = 39;
            this.tbxNameAI12.Text = "AI_12";
            this.tbxNameAI12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUnitAI11
            // 
            this.tbxUnitAI11.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitAI11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI11.Location = new System.Drawing.Point(252, 348);
            this.tbxUnitAI11.Name = "tbxUnitAI11";
            this.tbxUnitAI11.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI11.TabIndex = 38;
            this.tbxUnitAI11.Text = "AI11";
            this.tbxUnitAI11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNameAI11
            // 
            this.tbxNameAI11.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameAI11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameAI11.Location = new System.Drawing.Point(146, 348);
            this.tbxNameAI11.Name = "tbxNameAI11";
            this.tbxNameAI11.Size = new System.Drawing.Size(100, 21);
            this.tbxNameAI11.TabIndex = 37;
            this.tbxNameAI11.Text = "AI_11";
            this.tbxNameAI11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNameAI01
            // 
            this.tbxNameAI01.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameAI01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameAI01.Location = new System.Drawing.Point(146, 78);
            this.tbxNameAI01.Name = "tbxNameAI01";
            this.tbxNameAI01.Size = new System.Drawing.Size(100, 21);
            this.tbxNameAI01.TabIndex = 11;
            this.tbxNameAI01.Text = "AI_01";
            this.tbxNameAI01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUnitAI10
            // 
            this.tbxUnitAI10.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitAI10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI10.Location = new System.Drawing.Point(252, 321);
            this.tbxUnitAI10.Name = "tbxUnitAI10";
            this.tbxUnitAI10.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI10.TabIndex = 30;
            this.tbxUnitAI10.Text = "AI10";
            this.tbxUnitAI10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "AI - 01";
            // 
            // tbxNameAI10
            // 
            this.tbxNameAI10.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameAI10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameAI10.Location = new System.Drawing.Point(146, 321);
            this.tbxNameAI10.Name = "tbxNameAI10";
            this.tbxNameAI10.Size = new System.Drawing.Size(100, 21);
            this.tbxNameAI10.TabIndex = 29;
            this.tbxNameAI10.Text = "AI_10";
            this.tbxNameAI10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "AI - 02";
            // 
            // tbxUnitAI09
            // 
            this.tbxUnitAI09.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitAI09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI09.Location = new System.Drawing.Point(252, 294);
            this.tbxUnitAI09.Name = "tbxUnitAI09";
            this.tbxUnitAI09.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI09.TabIndex = 28;
            this.tbxUnitAI09.Text = "AI09";
            this.tbxUnitAI09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "AI - 03";
            // 
            // tbxNameAI09
            // 
            this.tbxNameAI09.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameAI09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameAI09.Location = new System.Drawing.Point(146, 294);
            this.tbxNameAI09.Name = "tbxNameAI09";
            this.tbxNameAI09.Size = new System.Drawing.Size(100, 21);
            this.tbxNameAI09.TabIndex = 27;
            this.tbxNameAI09.Text = "AI_09";
            this.tbxNameAI09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "AI - 04";
            // 
            // tbxUnitAI08
            // 
            this.tbxUnitAI08.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitAI08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI08.Location = new System.Drawing.Point(252, 267);
            this.tbxUnitAI08.Name = "tbxUnitAI08";
            this.tbxUnitAI08.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI08.TabIndex = 26;
            this.tbxUnitAI08.Text = "AI08";
            this.tbxUnitAI08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "AI - 05";
            // 
            // tbxNameAI08
            // 
            this.tbxNameAI08.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameAI08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameAI08.Location = new System.Drawing.Point(146, 267);
            this.tbxNameAI08.Name = "tbxNameAI08";
            this.tbxNameAI08.Size = new System.Drawing.Size(100, 21);
            this.tbxNameAI08.TabIndex = 25;
            this.tbxNameAI08.Text = "AI_08";
            this.tbxNameAI08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUnitAI07
            // 
            this.tbxUnitAI07.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitAI07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI07.Location = new System.Drawing.Point(252, 240);
            this.tbxUnitAI07.Name = "tbxUnitAI07";
            this.tbxUnitAI07.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI07.TabIndex = 24;
            this.tbxUnitAI07.Text = "AI07";
            this.tbxUnitAI07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "채널 명칭";
            // 
            // tbxNameAI07
            // 
            this.tbxNameAI07.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameAI07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameAI07.Location = new System.Drawing.Point(146, 240);
            this.tbxNameAI07.Name = "tbxNameAI07";
            this.tbxNameAI07.Size = new System.Drawing.Size(100, 21);
            this.tbxNameAI07.TabIndex = 23;
            this.tbxNameAI07.Text = "AI_07";
            this.tbxNameAI07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "단위";
            // 
            // tbxUnitAI06
            // 
            this.tbxUnitAI06.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitAI06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI06.Location = new System.Drawing.Point(252, 213);
            this.tbxUnitAI06.Name = "tbxUnitAI06";
            this.tbxUnitAI06.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI06.TabIndex = 22;
            this.tbxUnitAI06.Text = "AI06";
            this.tbxUnitAI06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNameAI06
            // 
            this.tbxNameAI06.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameAI06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameAI06.Location = new System.Drawing.Point(146, 213);
            this.tbxNameAI06.Name = "tbxNameAI06";
            this.tbxNameAI06.Size = new System.Drawing.Size(100, 21);
            this.tbxNameAI06.TabIndex = 21;
            this.tbxNameAI06.Text = "AI_06";
            this.tbxNameAI06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUnitAI05
            // 
            this.tbxUnitAI05.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitAI05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI05.Location = new System.Drawing.Point(252, 186);
            this.tbxUnitAI05.Name = "tbxUnitAI05";
            this.tbxUnitAI05.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI05.TabIndex = 20;
            this.tbxUnitAI05.Text = "AI05";
            this.tbxUnitAI05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNameAI05
            // 
            this.tbxNameAI05.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameAI05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameAI05.Location = new System.Drawing.Point(146, 186);
            this.tbxNameAI05.Name = "tbxNameAI05";
            this.tbxNameAI05.Size = new System.Drawing.Size(100, 21);
            this.tbxNameAI05.TabIndex = 19;
            this.tbxNameAI05.Text = "AI_05";
            this.tbxNameAI05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUnitAI01
            // 
            this.tbxUnitAI01.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitAI01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI01.Location = new System.Drawing.Point(252, 78);
            this.tbxUnitAI01.Name = "tbxUnitAI01";
            this.tbxUnitAI01.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI01.TabIndex = 12;
            this.tbxUnitAI01.Text = "AI01";
            this.tbxUnitAI01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUnitAI04
            // 
            this.tbxUnitAI04.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitAI04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI04.Location = new System.Drawing.Point(252, 159);
            this.tbxUnitAI04.Name = "tbxUnitAI04";
            this.tbxUnitAI04.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI04.TabIndex = 18;
            this.tbxUnitAI04.Text = "AI04";
            this.tbxUnitAI04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNameAI02
            // 
            this.tbxNameAI02.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameAI02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameAI02.Location = new System.Drawing.Point(146, 105);
            this.tbxNameAI02.Name = "tbxNameAI02";
            this.tbxNameAI02.Size = new System.Drawing.Size(100, 21);
            this.tbxNameAI02.TabIndex = 13;
            this.tbxNameAI02.Text = "AI_02";
            this.tbxNameAI02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNameAI04
            // 
            this.tbxNameAI04.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameAI04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameAI04.Location = new System.Drawing.Point(146, 159);
            this.tbxNameAI04.Name = "tbxNameAI04";
            this.tbxNameAI04.Size = new System.Drawing.Size(100, 21);
            this.tbxNameAI04.TabIndex = 17;
            this.tbxNameAI04.Text = "AI_04";
            this.tbxNameAI04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUnitAI02
            // 
            this.tbxUnitAI02.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitAI02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI02.Location = new System.Drawing.Point(252, 105);
            this.tbxUnitAI02.Name = "tbxUnitAI02";
            this.tbxUnitAI02.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI02.TabIndex = 14;
            this.tbxUnitAI02.Text = "AI02";
            this.tbxUnitAI02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUnitAI03
            // 
            this.tbxUnitAI03.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitAI03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI03.Location = new System.Drawing.Point(252, 132);
            this.tbxUnitAI03.Name = "tbxUnitAI03";
            this.tbxUnitAI03.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI03.TabIndex = 16;
            this.tbxUnitAI03.Text = "AI03";
            this.tbxUnitAI03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNameAI03
            // 
            this.tbxNameAI03.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameAI03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameAI03.Location = new System.Drawing.Point(146, 132);
            this.tbxNameAI03.Name = "tbxNameAI03";
            this.tbxNameAI03.Size = new System.Drawing.Size(100, 21);
            this.tbxNameAI03.TabIndex = 15;
            this.tbxNameAI03.Text = "AI_03";
            this.tbxNameAI03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 12);
            this.label6.TabIndex = 55;
            this.label6.Text = "AO - 02";
            // 
            // tbxNameAO01
            // 
            this.tbxNameAO01.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameAO01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameAO01.Location = new System.Drawing.Point(427, 78);
            this.tbxNameAO01.Name = "tbxNameAO01";
            this.tbxNameAO01.Size = new System.Drawing.Size(100, 21);
            this.tbxNameAO01.TabIndex = 51;
            this.tbxNameAO01.Text = "AO_01";
            this.tbxNameAO01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(368, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 12);
            this.label23.TabIndex = 48;
            this.label23.Text = "AO - 01";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(467, 49);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 12);
            this.label29.TabIndex = 49;
            this.label29.Text = "채널 명칭";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(569, 49);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 12);
            this.label30.TabIndex = 50;
            this.label30.Text = "단위";
            // 
            // tbxUnitAO02
            // 
            this.tbxUnitAO02.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitAO02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAO02.Location = new System.Drawing.Point(533, 105);
            this.tbxUnitAO02.Name = "tbxUnitAO02";
            this.tbxUnitAO02.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAO02.TabIndex = 54;
            this.tbxUnitAO02.Text = "AO02";
            this.tbxUnitAO02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNameAO02
            // 
            this.tbxNameAO02.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameAO02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameAO02.Location = new System.Drawing.Point(427, 105);
            this.tbxNameAO02.Name = "tbxNameAO02";
            this.tbxNameAO02.Size = new System.Drawing.Size(100, 21);
            this.tbxNameAO02.TabIndex = 53;
            this.tbxNameAO02.Text = "AO_02";
            this.tbxNameAO02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUnitAO01
            // 
            this.tbxUnitAO01.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitAO01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAO01.Location = new System.Drawing.Point(533, 78);
            this.tbxUnitAO01.Name = "tbxUnitAO01";
            this.tbxUnitAO01.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAO01.TabIndex = 52;
            this.tbxUnitAO01.Text = "AO01";
            this.tbxUnitAO01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(368, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 12);
            this.label10.TabIndex = 69;
            this.label10.Text = "DI - 04";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(368, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 12);
            this.label11.TabIndex = 68;
            this.label11.Text = "DI - 03";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 12);
            this.label9.TabIndex = 67;
            this.label9.Text = "DI - 02";
            // 
            // tbxNameDI03
            // 
            this.tbxNameDI03.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameDI03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameDI03.Location = new System.Drawing.Point(427, 240);
            this.tbxNameDI03.Name = "tbxNameDI03";
            this.tbxNameDI03.Size = new System.Drawing.Size(100, 21);
            this.tbxNameDI03.TabIndex = 63;
            this.tbxNameDI03.Text = "DI_03";
            this.tbxNameDI03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUnitDI04
            // 
            this.tbxUnitDI04.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitDI04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitDI04.Location = new System.Drawing.Point(533, 267);
            this.tbxUnitDI04.Name = "tbxUnitDI04";
            this.tbxUnitDI04.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitDI04.TabIndex = 66;
            this.tbxUnitDI04.Text = "DI04";
            this.tbxUnitDI04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNameDI04
            // 
            this.tbxNameDI04.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameDI04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameDI04.Location = new System.Drawing.Point(427, 267);
            this.tbxNameDI04.Name = "tbxNameDI04";
            this.tbxNameDI04.Size = new System.Drawing.Size(100, 21);
            this.tbxNameDI04.TabIndex = 65;
            this.tbxNameDI04.Text = "DI_04";
            this.tbxNameDI04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUnitDI03
            // 
            this.tbxUnitDI03.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitDI03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitDI03.Location = new System.Drawing.Point(533, 240);
            this.tbxUnitDI03.Name = "tbxUnitDI03";
            this.tbxUnitDI03.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitDI03.TabIndex = 64;
            this.tbxUnitDI03.Text = "DI03";
            this.tbxUnitDI03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNameDI01
            // 
            this.tbxNameDI01.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameDI01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameDI01.Location = new System.Drawing.Point(427, 186);
            this.tbxNameDI01.Name = "tbxNameDI01";
            this.tbxNameDI01.Size = new System.Drawing.Size(100, 21);
            this.tbxNameDI01.TabIndex = 59;
            this.tbxNameDI01.Text = "DI_01";
            this.tbxNameDI01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(368, 188);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(42, 12);
            this.label34.TabIndex = 56;
            this.label34.Text = "DI - 01";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(467, 157);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(57, 12);
            this.label40.TabIndex = 57;
            this.label40.Text = "채널 명칭";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(569, 157);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(29, 12);
            this.label41.TabIndex = 58;
            this.label41.Text = "단위";
            // 
            // tbxUnitDI02
            // 
            this.tbxUnitDI02.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitDI02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitDI02.Location = new System.Drawing.Point(533, 213);
            this.tbxUnitDI02.Name = "tbxUnitDI02";
            this.tbxUnitDI02.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitDI02.TabIndex = 62;
            this.tbxUnitDI02.Text = "DI02";
            this.tbxUnitDI02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNameDI02
            // 
            this.tbxNameDI02.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameDI02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameDI02.Location = new System.Drawing.Point(427, 213);
            this.tbxNameDI02.Name = "tbxNameDI02";
            this.tbxNameDI02.Size = new System.Drawing.Size(100, 21);
            this.tbxNameDI02.TabIndex = 61;
            this.tbxNameDI02.Text = "DI_02";
            this.tbxNameDI02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUnitDI01
            // 
            this.tbxUnitDI01.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitDI01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitDI01.Location = new System.Drawing.Point(533, 186);
            this.tbxUnitDI01.Name = "tbxUnitDI01";
            this.tbxUnitDI01.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitDI01.TabIndex = 60;
            this.tbxUnitDI01.Text = "DI01";
            this.tbxUnitDI01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(368, 377);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 12);
            this.label19.TabIndex = 77;
            this.label19.Text = "DO - 02";
            // 
            // tbxNameDO01
            // 
            this.tbxNameDO01.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameDO01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameDO01.Location = new System.Drawing.Point(427, 348);
            this.tbxNameDO01.Name = "tbxNameDO01";
            this.tbxNameDO01.Size = new System.Drawing.Size(100, 21);
            this.tbxNameDO01.TabIndex = 73;
            this.tbxNameDO01.Text = "DO_01";
            this.tbxNameDO01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(368, 350);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(48, 12);
            this.label45.TabIndex = 70;
            this.label45.Text = "DO - 01";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(467, 319);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(57, 12);
            this.label51.TabIndex = 71;
            this.label51.Text = "채널 명칭";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(569, 319);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(29, 12);
            this.label52.TabIndex = 72;
            this.label52.Text = "단위";
            // 
            // tbxUnitDO02
            // 
            this.tbxUnitDO02.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitDO02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitDO02.Location = new System.Drawing.Point(533, 375);
            this.tbxUnitDO02.Name = "tbxUnitDO02";
            this.tbxUnitDO02.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitDO02.TabIndex = 76;
            this.tbxUnitDO02.Text = "DO02";
            this.tbxUnitDO02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNameDO02
            // 
            this.tbxNameDO02.BackColor = System.Drawing.SystemColors.Info;
            this.tbxNameDO02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNameDO02.Location = new System.Drawing.Point(427, 375);
            this.tbxNameDO02.Name = "tbxNameDO02";
            this.tbxNameDO02.Size = new System.Drawing.Size(100, 21);
            this.tbxNameDO02.TabIndex = 75;
            this.tbxNameDO02.Text = "DO_02";
            this.tbxNameDO02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxUnitDO01
            // 
            this.tbxUnitDO01.BackColor = System.Drawing.SystemColors.Info;
            this.tbxUnitDO01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitDO01.Location = new System.Drawing.Point(533, 348);
            this.tbxUnitDO01.Name = "tbxUnitDO01";
            this.tbxUnitDO01.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitDO01.TabIndex = 74;
            this.tbxUnitDO01.Text = "DO01";
            this.tbxUnitDO01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmChannelName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmChannelName";
            this.Text = "채널 단위 설정";
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
        private System.Windows.Forms.TextBox tbxNameAI01;
        private System.Windows.Forms.TextBox tbxUnitAI10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNameAI10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUnitAI09;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNameAI09;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxUnitAI08;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxNameAI08;
        private System.Windows.Forms.TextBox tbxUnitAI07;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxNameAI07;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxUnitAI06;
        private System.Windows.Forms.TextBox tbxNameAI06;
        private System.Windows.Forms.TextBox tbxUnitAI05;
        private System.Windows.Forms.TextBox tbxNameAI05;
        private System.Windows.Forms.TextBox tbxUnitAI01;
        private System.Windows.Forms.TextBox tbxUnitAI04;
        private System.Windows.Forms.TextBox tbxNameAI02;
        private System.Windows.Forms.TextBox tbxNameAI04;
        private System.Windows.Forms.TextBox tbxUnitAI02;
        private System.Windows.Forms.TextBox tbxUnitAI03;
        private System.Windows.Forms.TextBox tbxNameAI03;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxUnitAI12;
        private System.Windows.Forms.TextBox tbxNameAI12;
        private System.Windows.Forms.TextBox tbxUnitAI11;
        private System.Windows.Forms.TextBox tbxNameAI11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxNameDO01;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox tbxUnitDO02;
        private System.Windows.Forms.TextBox tbxNameDO02;
        private System.Windows.Forms.TextBox tbxUnitDO01;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxNameDI03;
        private System.Windows.Forms.TextBox tbxUnitDI04;
        private System.Windows.Forms.TextBox tbxNameDI04;
        private System.Windows.Forms.TextBox tbxUnitDI03;
        private System.Windows.Forms.TextBox tbxNameDI01;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox tbxUnitDI02;
        private System.Windows.Forms.TextBox tbxNameDI02;
        private System.Windows.Forms.TextBox tbxUnitDI01;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxNameAO01;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbxUnitAO02;
        private System.Windows.Forms.TextBox tbxNameAO02;
        private System.Windows.Forms.TextBox tbxUnitAO01;
        //================================================================================================================================



        public FrmChannelName()
        {
            InitializeComponent();
        }

        public string GetUnitAI01()
        {
            return tbxUnitAI01.Text;
        }
        public string GetUnitAI02()
        {
            return tbxUnitAI02.Text;
        }
        public string GetUnitAI03()
        {
            return tbxUnitAI03.Text;
        }
        public string GetUnitAI04()
        {
            return tbxUnitAI04.Text;
        }
        public string GetUnitAI05()
        {
            return tbxUnitAI05.Text;
        }
        public string GetUnitAI06()
        {
            return tbxUnitAI06.Text;
        }
        public string GetUnitAI07()
        {
            return tbxUnitAI07.Text;
        }
        public string GetUnitAI08()
        {
            return tbxUnitAI08.Text;
        }
        public string GetUnitAI09()
        {
            return tbxUnitAI09.Text;
        }
        public string GetUnitAI10()
        {
            return tbxUnitAI10.Text;
        }
        public string GetUnitAI11()
        {
            return tbxUnitAI11.Text;
        }
        public string GetUnitAI12()
        {
            return tbxUnitAI12.Text;
        }
    }
}

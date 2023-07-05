using PlcLSE_V1.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlcLSE_V1
{
    public partial class FrmPlcSensor : Form
    {

        // 디자인 영역====================================================================================================================
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveCh1 = new System.Windows.Forms.Button();
            this.label104 = new System.Windows.Forms.Label();
            this.tbxUnitAI01 = new System.Windows.Forms.TextBox();
            this.tbxD1006 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tbxD1004 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0100 = new System.Windows.Forms.TextBox();
            this.tbxPlcData0109 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxPlcData0108 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPlcData0107 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPlcData0106 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPlcData0105 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPlcData0104 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPlcData0103 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPlcData0102 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxPlcData0101 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxPlcData0100 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxPlcSignal0109 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxPlcSignal0108 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0101 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0107 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0102 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0106 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0103 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0105 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0104 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSaveCh2 = new System.Windows.Forms.Button();
            this.tbxPlcData0209 = new System.Windows.Forms.TextBox();
            this.tbxPlcData0208 = new System.Windows.Forms.TextBox();
            this.label129 = new System.Windows.Forms.Label();
            this.tbxPlcData0207 = new System.Windows.Forms.TextBox();
            this.label130 = new System.Windows.Forms.Label();
            this.tbxPlcData0206 = new System.Windows.Forms.TextBox();
            this.label131 = new System.Windows.Forms.Label();
            this.tbxPlcData0205 = new System.Windows.Forms.TextBox();
            this.label132 = new System.Windows.Forms.Label();
            this.tbxPlcData0204 = new System.Windows.Forms.TextBox();
            this.tbxPlcData0203 = new System.Windows.Forms.TextBox();
            this.tbxPlcData0202 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0209 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0208 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0207 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0202 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0206 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0203 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0205 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0204 = new System.Windows.Forms.TextBox();
            this.label112 = new System.Windows.Forms.Label();
            this.tbxUnitAI02 = new System.Windows.Forms.TextBox();
            this.tbxD1050 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tbxD1048 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0200 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.tbxPlcData0201 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tbxPlcData0200 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tbxPlcSignal0201 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSaveCh3 = new System.Windows.Forms.Button();
            this.tbxPlcData0309 = new System.Windows.Forms.TextBox();
            this.tbxPlcData0308 = new System.Windows.Forms.TextBox();
            this.label133 = new System.Windows.Forms.Label();
            this.tbxPlcData0307 = new System.Windows.Forms.TextBox();
            this.label134 = new System.Windows.Forms.Label();
            this.tbxPlcData0306 = new System.Windows.Forms.TextBox();
            this.label135 = new System.Windows.Forms.Label();
            this.tbxPlcData0305 = new System.Windows.Forms.TextBox();
            this.label136 = new System.Windows.Forms.Label();
            this.tbxPlcData0304 = new System.Windows.Forms.TextBox();
            this.tbxPlcData0303 = new System.Windows.Forms.TextBox();
            this.tbxPlcData0302 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0309 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0308 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0307 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0302 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0306 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0303 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0305 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0304 = new System.Windows.Forms.TextBox();
            this.label113 = new System.Windows.Forms.Label();
            this.tbxUnitAI03 = new System.Windows.Forms.TextBox();
            this.tbxD1094 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.tbxD1092 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0300 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.tbxPlcData0301 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.tbxPlcData0300 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.tbxPlcSignal0301 = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSaveCh4 = new System.Windows.Forms.Button();
            this.label114 = new System.Windows.Forms.Label();
            this.tbxUnitAI04 = new System.Windows.Forms.TextBox();
            this.tbxD1138 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.tbxD1136 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0400 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.tbxPlcData0401 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.tbxPlcData0400 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.tbxPlcSignal0401 = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSaveCh5 = new System.Windows.Forms.Button();
            this.label115 = new System.Windows.Forms.Label();
            this.tbxUnitAI05 = new System.Windows.Forms.TextBox();
            this.tbxD1182 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.tbxD1180 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0500 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.tbxPlcData0501 = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.tbxPlcData0500 = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.tbxPlcSignal0501 = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSaveCh6 = new System.Windows.Forms.Button();
            this.label122 = new System.Windows.Forms.Label();
            this.tbxUnitAI06 = new System.Windows.Forms.TextBox();
            this.tbxD1226 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.tbxD1224 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0600 = new System.Windows.Forms.TextBox();
            this.label67 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.tbxPlcData0601 = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.tbxPlcData0600 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.tbxPlcSignal0601 = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaveCh7 = new System.Windows.Forms.Button();
            this.label123 = new System.Windows.Forms.Label();
            this.tbxUnitAI07 = new System.Windows.Forms.TextBox();
            this.tbxD1270 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.tbxD1268 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0700 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxPlcData0701 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbxPlcData0700 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tbxPlcSignal0701 = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSaveCh8 = new System.Windows.Forms.Button();
            this.label124 = new System.Windows.Forms.Label();
            this.tbxUnitAI08 = new System.Windows.Forms.TextBox();
            this.tbxD1314 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.tbxD1312 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0800 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.tbxPlcData0801 = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.tbxPlcData0800 = new System.Windows.Forms.TextBox();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.tbxPlcSignal0801 = new System.Windows.Forms.TextBox();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnSaveCh9 = new System.Windows.Forms.Button();
            this.label125 = new System.Windows.Forms.Label();
            this.tbxUnitAI09 = new System.Windows.Forms.TextBox();
            this.tbxD1358 = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.tbxD1356 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal0900 = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.tbxPlcData0901 = new System.Windows.Forms.TextBox();
            this.label101 = new System.Windows.Forms.Label();
            this.tbxPlcData0900 = new System.Windows.Forms.TextBox();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.tbxPlcSignal0901 = new System.Windows.Forms.TextBox();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSaveCh10 = new System.Windows.Forms.Button();
            this.label126 = new System.Windows.Forms.Label();
            this.tbxUnitAI10 = new System.Windows.Forms.TextBox();
            this.tbxD1402 = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.tbxD1400 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal1000 = new System.Windows.Forms.TextBox();
            this.label89 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.tbxPlcData1001 = new System.Windows.Forms.TextBox();
            this.label97 = new System.Windows.Forms.Label();
            this.tbxPlcData1000 = new System.Windows.Forms.TextBox();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.tbxPlcSignal1001 = new System.Windows.Forms.TextBox();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnSaveCh11 = new System.Windows.Forms.Button();
            this.label127 = new System.Windows.Forms.Label();
            this.tbxUnitAI11 = new System.Windows.Forms.TextBox();
            this.tbxD1446 = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.tbxD1444 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal1100 = new System.Windows.Forms.TextBox();
            this.label100 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.tbxPlcData1101 = new System.Windows.Forms.TextBox();
            this.label108 = new System.Windows.Forms.Label();
            this.tbxPlcData1100 = new System.Windows.Forms.TextBox();
            this.label109 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.tbxPlcSignal1101 = new System.Windows.Forms.TextBox();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnSaveCh12 = new System.Windows.Forms.Button();
            this.label128 = new System.Windows.Forms.Label();
            this.tbxUnitAI12 = new System.Windows.Forms.TextBox();
            this.tbxD1490 = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            this.tbxD1488 = new System.Windows.Forms.TextBox();
            this.tbxPlcSignal1200 = new System.Windows.Forms.TextBox();
            this.label111 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.tbxPlcData1201 = new System.Windows.Forms.TextBox();
            this.label119 = new System.Windows.Forms.Label();
            this.tbxPlcData1200 = new System.Windows.Forms.TextBox();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.tbxPlcSignal1201 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReadAllChannel = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage12);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 537);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
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
            this.tabPage1.Text = "측정센서 1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveCh1);
            this.panel1.Controls.Add(this.label104);
            this.panel1.Controls.Add(this.tbxUnitAI01);
            this.panel1.Controls.Add(this.tbxD1006);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.tbxD1004);
            this.panel1.Controls.Add(this.tbxPlcSignal0100);
            this.panel1.Controls.Add(this.tbxPlcData0109);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbxPlcData0108);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxPlcData0107);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxPlcData0106);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxPlcData0105);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbxPlcData0104);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbxPlcData0103);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbxPlcData0102);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbxPlcData0101);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.tbxPlcData0100);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.tbxPlcSignal0109);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.tbxPlcSignal0108);
            this.panel1.Controls.Add(this.tbxPlcSignal0101);
            this.panel1.Controls.Add(this.tbxPlcSignal0107);
            this.panel1.Controls.Add(this.tbxPlcSignal0102);
            this.panel1.Controls.Add(this.tbxPlcSignal0106);
            this.panel1.Controls.Add(this.tbxPlcSignal0103);
            this.panel1.Controls.Add(this.tbxPlcSignal0105);
            this.panel1.Controls.Add(this.tbxPlcSignal0104);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 499);
            this.panel1.TabIndex = 31;
            // 
            // btnSaveCh1
            // 
            this.btnSaveCh1.Location = new System.Drawing.Point(790, 446);
            this.btnSaveCh1.Name = "btnSaveCh1";
            this.btnSaveCh1.Size = new System.Drawing.Size(150, 50);
            this.btnSaveCh1.TabIndex = 37;
            this.btnSaveCh1.Text = "설정 저장하기";
            this.btnSaveCh1.UseVisualStyleBackColor = true;
            this.btnSaveCh1.Click += new System.EventHandler(this.btnSaveCh1_Click);
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.Location = new System.Drawing.Point(805, 134);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(26, 12);
            this.label104.TabIndex = 35;
            this.label104.Text = "Unit";
            // 
            // tbxUnitAI01
            // 
            this.tbxUnitAI01.BackColor = System.Drawing.Color.Silver;
            this.tbxUnitAI01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI01.Location = new System.Drawing.Point(837, 132);
            this.tbxUnitAI01.Name = "tbxUnitAI01";
            this.tbxUnitAI01.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI01.TabIndex = 36;
            this.tbxUnitAI01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxD1006
            // 
            this.tbxD1006.BackColor = System.Drawing.Color.Silver;
            this.tbxD1006.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1006.Location = new System.Drawing.Point(837, 105);
            this.tbxD1006.Name = "tbxD1006";
            this.tbxD1006.Size = new System.Drawing.Size(100, 21);
            this.tbxD1006.TabIndex = 33;
            this.tbxD1006.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(742, 107);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 12);
            this.label24.TabIndex = 31;
            this.label24.Text = "실시간 SIGNAL";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(754, 80);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 12);
            this.label25.TabIndex = 32;
            this.label25.Text = "실시간 DATA";
            // 
            // tbxD1004
            // 
            this.tbxD1004.BackColor = System.Drawing.Color.Silver;
            this.tbxD1004.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1004.Location = new System.Drawing.Point(837, 78);
            this.tbxD1004.Name = "tbxD1004";
            this.tbxD1004.Size = new System.Drawing.Size(100, 21);
            this.tbxD1004.TabIndex = 34;
            this.tbxD1004.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0100
            // 
            this.tbxPlcSignal0100.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0100.Location = new System.Drawing.Point(146, 78);
            this.tbxPlcSignal0100.Name = "tbxPlcSignal0100";
            this.tbxPlcSignal0100.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0100.TabIndex = 11;
            this.tbxPlcSignal0100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData0109
            // 
            this.tbxPlcData0109.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0109.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0109.Location = new System.Drawing.Point(520, 186);
            this.tbxPlcData0109.Name = "tbxPlcData0109";
            this.tbxPlcData0109.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0109.TabIndex = 30;
            this.tbxPlcData0109.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "STEP #1";
            // 
            // tbxPlcData0108
            // 
            this.tbxPlcData0108.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0108.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0108.Location = new System.Drawing.Point(414, 186);
            this.tbxPlcData0108.Name = "tbxPlcData0108";
            this.tbxPlcData0108.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0108.TabIndex = 29;
            this.tbxPlcData0108.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "STEP #2";
            // 
            // tbxPlcData0107
            // 
            this.tbxPlcData0107.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0107.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0107.Location = new System.Drawing.Point(520, 159);
            this.tbxPlcData0107.Name = "tbxPlcData0107";
            this.tbxPlcData0107.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0107.TabIndex = 28;
            this.tbxPlcData0107.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "STEP #3";
            // 
            // tbxPlcData0106
            // 
            this.tbxPlcData0106.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0106.Location = new System.Drawing.Point(414, 159);
            this.tbxPlcData0106.Name = "tbxPlcData0106";
            this.tbxPlcData0106.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0106.TabIndex = 27;
            this.tbxPlcData0106.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "STEP #4";
            // 
            // tbxPlcData0105
            // 
            this.tbxPlcData0105.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0105.Location = new System.Drawing.Point(520, 132);
            this.tbxPlcData0105.Name = "tbxPlcData0105";
            this.tbxPlcData0105.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0105.TabIndex = 26;
            this.tbxPlcData0105.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "STEP #5";
            // 
            // tbxPlcData0104
            // 
            this.tbxPlcData0104.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0104.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0104.Location = new System.Drawing.Point(414, 132);
            this.tbxPlcData0104.Name = "tbxPlcData0104";
            this.tbxPlcData0104.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0104.TabIndex = 25;
            this.tbxPlcData0104.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "PLC SIGNAL";
            // 
            // tbxPlcData0103
            // 
            this.tbxPlcData0103.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0103.Location = new System.Drawing.Point(520, 105);
            this.tbxPlcData0103.Name = "tbxPlcData0103";
            this.tbxPlcData0103.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0103.TabIndex = 24;
            this.tbxPlcData0103.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "Min";
            // 
            // tbxPlcData0102
            // 
            this.tbxPlcData0102.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0102.Location = new System.Drawing.Point(414, 105);
            this.tbxPlcData0102.Name = "tbxPlcData0102";
            this.tbxPlcData0102.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0102.TabIndex = 23;
            this.tbxPlcData0102.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "Max";
            // 
            // tbxPlcData0101
            // 
            this.tbxPlcData0101.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0101.Location = new System.Drawing.Point(520, 78);
            this.tbxPlcData0101.Name = "tbxPlcData0101";
            this.tbxPlcData0101.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0101.TabIndex = 22;
            this.tbxPlcData0101.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(482, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "PLC DATA";
            // 
            // tbxPlcData0100
            // 
            this.tbxPlcData0100.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0100.Location = new System.Drawing.Point(414, 78);
            this.tbxPlcData0100.Name = "tbxPlcData0100";
            this.tbxPlcData0100.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0100.TabIndex = 21;
            this.tbxPlcData0100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "Min";
            // 
            // tbxPlcSignal0109
            // 
            this.tbxPlcSignal0109.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0109.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0109.Location = new System.Drawing.Point(252, 186);
            this.tbxPlcSignal0109.Name = "tbxPlcSignal0109";
            this.tbxPlcSignal0109.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0109.TabIndex = 20;
            this.tbxPlcSignal0109.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "Max";
            // 
            // tbxPlcSignal0108
            // 
            this.tbxPlcSignal0108.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0108.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0108.Location = new System.Drawing.Point(146, 186);
            this.tbxPlcSignal0108.Name = "tbxPlcSignal0108";
            this.tbxPlcSignal0108.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0108.TabIndex = 19;
            this.tbxPlcSignal0108.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0101
            // 
            this.tbxPlcSignal0101.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0101.Location = new System.Drawing.Point(252, 78);
            this.tbxPlcSignal0101.Name = "tbxPlcSignal0101";
            this.tbxPlcSignal0101.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0101.TabIndex = 12;
            this.tbxPlcSignal0101.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0107
            // 
            this.tbxPlcSignal0107.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0107.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0107.Location = new System.Drawing.Point(252, 159);
            this.tbxPlcSignal0107.Name = "tbxPlcSignal0107";
            this.tbxPlcSignal0107.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0107.TabIndex = 18;
            this.tbxPlcSignal0107.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0102
            // 
            this.tbxPlcSignal0102.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0102.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0102.Location = new System.Drawing.Point(146, 105);
            this.tbxPlcSignal0102.Name = "tbxPlcSignal0102";
            this.tbxPlcSignal0102.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0102.TabIndex = 13;
            this.tbxPlcSignal0102.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0106
            // 
            this.tbxPlcSignal0106.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0106.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0106.Location = new System.Drawing.Point(146, 159);
            this.tbxPlcSignal0106.Name = "tbxPlcSignal0106";
            this.tbxPlcSignal0106.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0106.TabIndex = 17;
            this.tbxPlcSignal0106.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0103
            // 
            this.tbxPlcSignal0103.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0103.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0103.Location = new System.Drawing.Point(252, 105);
            this.tbxPlcSignal0103.Name = "tbxPlcSignal0103";
            this.tbxPlcSignal0103.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0103.TabIndex = 14;
            this.tbxPlcSignal0103.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0105
            // 
            this.tbxPlcSignal0105.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0105.Location = new System.Drawing.Point(252, 132);
            this.tbxPlcSignal0105.Name = "tbxPlcSignal0105";
            this.tbxPlcSignal0105.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0105.TabIndex = 16;
            this.tbxPlcSignal0105.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0104
            // 
            this.tbxPlcSignal0104.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0104.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0104.Location = new System.Drawing.Point(146, 132);
            this.tbxPlcSignal0104.Name = "tbxPlcSignal0104";
            this.tbxPlcSignal0104.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0104.TabIndex = 15;
            this.tbxPlcSignal0104.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "측정센서 2";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveCh2);
            this.panel3.Controls.Add(this.tbxPlcData0209);
            this.panel3.Controls.Add(this.tbxPlcData0208);
            this.panel3.Controls.Add(this.label129);
            this.panel3.Controls.Add(this.tbxPlcData0207);
            this.panel3.Controls.Add(this.label130);
            this.panel3.Controls.Add(this.tbxPlcData0206);
            this.panel3.Controls.Add(this.label131);
            this.panel3.Controls.Add(this.tbxPlcData0205);
            this.panel3.Controls.Add(this.label132);
            this.panel3.Controls.Add(this.tbxPlcData0204);
            this.panel3.Controls.Add(this.tbxPlcData0203);
            this.panel3.Controls.Add(this.tbxPlcData0202);
            this.panel3.Controls.Add(this.tbxPlcSignal0209);
            this.panel3.Controls.Add(this.tbxPlcSignal0208);
            this.panel3.Controls.Add(this.tbxPlcSignal0207);
            this.panel3.Controls.Add(this.tbxPlcSignal0202);
            this.panel3.Controls.Add(this.tbxPlcSignal0206);
            this.panel3.Controls.Add(this.tbxPlcSignal0203);
            this.panel3.Controls.Add(this.tbxPlcSignal0205);
            this.panel3.Controls.Add(this.tbxPlcSignal0204);
            this.panel3.Controls.Add(this.label112);
            this.panel3.Controls.Add(this.tbxUnitAI02);
            this.panel3.Controls.Add(this.tbxD1050);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.tbxD1048);
            this.panel3.Controls.Add(this.tbxPlcSignal0200);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.label30);
            this.panel3.Controls.Add(this.tbxPlcData0201);
            this.panel3.Controls.Add(this.label31);
            this.panel3.Controls.Add(this.tbxPlcData0200);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.tbxPlcSignal0201);
            this.panel3.Location = new System.Drawing.Point(6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(940, 499);
            this.panel3.TabIndex = 32;
            // 
            // btnSaveCh2
            // 
            this.btnSaveCh2.Location = new System.Drawing.Point(787, 446);
            this.btnSaveCh2.Name = "btnSaveCh2";
            this.btnSaveCh2.Size = new System.Drawing.Size(150, 50);
            this.btnSaveCh2.TabIndex = 61;
            this.btnSaveCh2.Text = "설정 저장하기";
            this.btnSaveCh2.UseVisualStyleBackColor = true;
            this.btnSaveCh2.Click += new System.EventHandler(this.btnSaveCh2_Click);
            // 
            // tbxPlcData0209
            // 
            this.tbxPlcData0209.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0209.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0209.Location = new System.Drawing.Point(520, 186);
            this.tbxPlcData0209.Name = "tbxPlcData0209";
            this.tbxPlcData0209.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0209.TabIndex = 60;
            this.tbxPlcData0209.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData0208
            // 
            this.tbxPlcData0208.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0208.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0208.Location = new System.Drawing.Point(414, 186);
            this.tbxPlcData0208.Name = "tbxPlcData0208";
            this.tbxPlcData0208.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0208.TabIndex = 59;
            this.tbxPlcData0208.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.Location = new System.Drawing.Point(87, 107);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(53, 12);
            this.label129.TabIndex = 41;
            this.label129.Text = "STEP #2";
            // 
            // tbxPlcData0207
            // 
            this.tbxPlcData0207.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0207.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0207.Location = new System.Drawing.Point(520, 159);
            this.tbxPlcData0207.Name = "tbxPlcData0207";
            this.tbxPlcData0207.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0207.TabIndex = 58;
            this.tbxPlcData0207.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.Location = new System.Drawing.Point(87, 134);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(53, 12);
            this.label130.TabIndex = 42;
            this.label130.Text = "STEP #3";
            // 
            // tbxPlcData0206
            // 
            this.tbxPlcData0206.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0206.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0206.Location = new System.Drawing.Point(414, 159);
            this.tbxPlcData0206.Name = "tbxPlcData0206";
            this.tbxPlcData0206.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0206.TabIndex = 57;
            this.tbxPlcData0206.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.Location = new System.Drawing.Point(87, 161);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(53, 12);
            this.label131.TabIndex = 43;
            this.label131.Text = "STEP #4";
            // 
            // tbxPlcData0205
            // 
            this.tbxPlcData0205.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0205.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0205.Location = new System.Drawing.Point(520, 132);
            this.tbxPlcData0205.Name = "tbxPlcData0205";
            this.tbxPlcData0205.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0205.TabIndex = 56;
            this.tbxPlcData0205.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.Location = new System.Drawing.Point(87, 188);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(53, 12);
            this.label132.TabIndex = 44;
            this.label132.Text = "STEP #5";
            // 
            // tbxPlcData0204
            // 
            this.tbxPlcData0204.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0204.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0204.Location = new System.Drawing.Point(414, 132);
            this.tbxPlcData0204.Name = "tbxPlcData0204";
            this.tbxPlcData0204.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0204.TabIndex = 55;
            this.tbxPlcData0204.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData0203
            // 
            this.tbxPlcData0203.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0203.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0203.Location = new System.Drawing.Point(520, 105);
            this.tbxPlcData0203.Name = "tbxPlcData0203";
            this.tbxPlcData0203.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0203.TabIndex = 54;
            this.tbxPlcData0203.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData0202
            // 
            this.tbxPlcData0202.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0202.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0202.Location = new System.Drawing.Point(414, 105);
            this.tbxPlcData0202.Name = "tbxPlcData0202";
            this.tbxPlcData0202.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0202.TabIndex = 53;
            this.tbxPlcData0202.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0209
            // 
            this.tbxPlcSignal0209.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0209.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0209.Location = new System.Drawing.Point(252, 186);
            this.tbxPlcSignal0209.Name = "tbxPlcSignal0209";
            this.tbxPlcSignal0209.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0209.TabIndex = 52;
            this.tbxPlcSignal0209.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0208
            // 
            this.tbxPlcSignal0208.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0208.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0208.Location = new System.Drawing.Point(146, 186);
            this.tbxPlcSignal0208.Name = "tbxPlcSignal0208";
            this.tbxPlcSignal0208.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0208.TabIndex = 51;
            this.tbxPlcSignal0208.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0207
            // 
            this.tbxPlcSignal0207.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0207.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0207.Location = new System.Drawing.Point(252, 159);
            this.tbxPlcSignal0207.Name = "tbxPlcSignal0207";
            this.tbxPlcSignal0207.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0207.TabIndex = 50;
            this.tbxPlcSignal0207.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0202
            // 
            this.tbxPlcSignal0202.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0202.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0202.Location = new System.Drawing.Point(146, 105);
            this.tbxPlcSignal0202.Name = "tbxPlcSignal0202";
            this.tbxPlcSignal0202.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0202.TabIndex = 45;
            this.tbxPlcSignal0202.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0206
            // 
            this.tbxPlcSignal0206.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0206.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0206.Location = new System.Drawing.Point(146, 159);
            this.tbxPlcSignal0206.Name = "tbxPlcSignal0206";
            this.tbxPlcSignal0206.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0206.TabIndex = 49;
            this.tbxPlcSignal0206.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0203
            // 
            this.tbxPlcSignal0203.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0203.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0203.Location = new System.Drawing.Point(252, 105);
            this.tbxPlcSignal0203.Name = "tbxPlcSignal0203";
            this.tbxPlcSignal0203.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0203.TabIndex = 46;
            this.tbxPlcSignal0203.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0205
            // 
            this.tbxPlcSignal0205.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0205.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0205.Location = new System.Drawing.Point(252, 132);
            this.tbxPlcSignal0205.Name = "tbxPlcSignal0205";
            this.tbxPlcSignal0205.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0205.TabIndex = 48;
            this.tbxPlcSignal0205.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0204
            // 
            this.tbxPlcSignal0204.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0204.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0204.Location = new System.Drawing.Point(146, 132);
            this.tbxPlcSignal0204.Name = "tbxPlcSignal0204";
            this.tbxPlcSignal0204.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0204.TabIndex = 47;
            this.tbxPlcSignal0204.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Location = new System.Drawing.Point(805, 134);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(26, 12);
            this.label112.TabIndex = 39;
            this.label112.Text = "Unit";
            // 
            // tbxUnitAI02
            // 
            this.tbxUnitAI02.BackColor = System.Drawing.Color.Silver;
            this.tbxUnitAI02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI02.Location = new System.Drawing.Point(837, 132);
            this.tbxUnitAI02.Name = "tbxUnitAI02";
            this.tbxUnitAI02.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI02.TabIndex = 40;
            this.tbxUnitAI02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxD1050
            // 
            this.tbxD1050.BackColor = System.Drawing.Color.Silver;
            this.tbxD1050.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1050.Location = new System.Drawing.Point(837, 105);
            this.tbxD1050.Name = "tbxD1050";
            this.tbxD1050.Size = new System.Drawing.Size(100, 21);
            this.tbxD1050.TabIndex = 37;
            this.tbxD1050.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(742, 107);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(89, 12);
            this.label26.TabIndex = 35;
            this.label26.Text = "실시간 SIGNAL";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(754, 80);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 12);
            this.label27.TabIndex = 36;
            this.label27.Text = "실시간 DATA";
            // 
            // tbxD1048
            // 
            this.tbxD1048.BackColor = System.Drawing.Color.Silver;
            this.tbxD1048.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1048.Location = new System.Drawing.Point(837, 78);
            this.tbxD1048.Name = "tbxD1048";
            this.tbxD1048.Size = new System.Drawing.Size(100, 21);
            this.tbxD1048.TabIndex = 38;
            this.tbxD1048.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0200
            // 
            this.tbxPlcSignal0200.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0200.Location = new System.Drawing.Point(146, 78);
            this.tbxPlcSignal0200.Name = "tbxPlcSignal0200";
            this.tbxPlcSignal0200.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0200.TabIndex = 11;
            this.tbxPlcSignal0200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(87, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 0;
            this.label23.Text = "STEP #1";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(208, 20);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(77, 12);
            this.label28.TabIndex = 5;
            this.label28.Text = "PLC SIGNAL";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(186, 49);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(26, 12);
            this.label29.TabIndex = 6;
            this.label29.Text = "Min";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(288, 49);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 12);
            this.label30.TabIndex = 7;
            this.label30.Text = "Max";
            // 
            // tbxPlcData0201
            // 
            this.tbxPlcData0201.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0201.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0201.Location = new System.Drawing.Point(520, 78);
            this.tbxPlcData0201.Name = "tbxPlcData0201";
            this.tbxPlcData0201.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0201.TabIndex = 22;
            this.tbxPlcData0201.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(482, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(65, 12);
            this.label31.TabIndex = 8;
            this.label31.Text = "PLC DATA";
            // 
            // tbxPlcData0200
            // 
            this.tbxPlcData0200.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0200.Location = new System.Drawing.Point(414, 78);
            this.tbxPlcData0200.Name = "tbxPlcData0200";
            this.tbxPlcData0200.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0200.TabIndex = 21;
            this.tbxPlcData0200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(451, 49);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(26, 12);
            this.label32.TabIndex = 9;
            this.label32.Text = "Min";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(553, 49);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(30, 12);
            this.label33.TabIndex = 10;
            this.label33.Text = "Max";
            // 
            // tbxPlcSignal0201
            // 
            this.tbxPlcSignal0201.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0201.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0201.Location = new System.Drawing.Point(252, 78);
            this.tbxPlcSignal0201.Name = "tbxPlcSignal0201";
            this.tbxPlcSignal0201.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0201.TabIndex = 12;
            this.tbxPlcSignal0201.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(952, 511);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "측정센서 3";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSaveCh3);
            this.panel4.Controls.Add(this.tbxPlcData0309);
            this.panel4.Controls.Add(this.tbxPlcData0308);
            this.panel4.Controls.Add(this.label133);
            this.panel4.Controls.Add(this.tbxPlcData0307);
            this.panel4.Controls.Add(this.label134);
            this.panel4.Controls.Add(this.tbxPlcData0306);
            this.panel4.Controls.Add(this.label135);
            this.panel4.Controls.Add(this.tbxPlcData0305);
            this.panel4.Controls.Add(this.label136);
            this.panel4.Controls.Add(this.tbxPlcData0304);
            this.panel4.Controls.Add(this.tbxPlcData0303);
            this.panel4.Controls.Add(this.tbxPlcData0302);
            this.panel4.Controls.Add(this.tbxPlcSignal0309);
            this.panel4.Controls.Add(this.tbxPlcSignal0308);
            this.panel4.Controls.Add(this.tbxPlcSignal0307);
            this.panel4.Controls.Add(this.tbxPlcSignal0302);
            this.panel4.Controls.Add(this.tbxPlcSignal0306);
            this.panel4.Controls.Add(this.tbxPlcSignal0303);
            this.panel4.Controls.Add(this.tbxPlcSignal0305);
            this.panel4.Controls.Add(this.tbxPlcSignal0304);
            this.panel4.Controls.Add(this.label113);
            this.panel4.Controls.Add(this.tbxUnitAI03);
            this.panel4.Controls.Add(this.tbxD1094);
            this.panel4.Controls.Add(this.label35);
            this.panel4.Controls.Add(this.label36);
            this.panel4.Controls.Add(this.tbxD1092);
            this.panel4.Controls.Add(this.tbxPlcSignal0300);
            this.panel4.Controls.Add(this.label34);
            this.panel4.Controls.Add(this.label39);
            this.panel4.Controls.Add(this.label40);
            this.panel4.Controls.Add(this.label41);
            this.panel4.Controls.Add(this.tbxPlcData0301);
            this.panel4.Controls.Add(this.label42);
            this.panel4.Controls.Add(this.tbxPlcData0300);
            this.panel4.Controls.Add(this.label43);
            this.panel4.Controls.Add(this.label44);
            this.panel4.Controls.Add(this.tbxPlcSignal0301);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(940, 499);
            this.panel4.TabIndex = 32;
            // 
            // btnSaveCh3
            // 
            this.btnSaveCh3.Location = new System.Drawing.Point(787, 446);
            this.btnSaveCh3.Name = "btnSaveCh3";
            this.btnSaveCh3.Size = new System.Drawing.Size(150, 50);
            this.btnSaveCh3.TabIndex = 61;
            this.btnSaveCh3.Text = "설정 저장하기";
            this.btnSaveCh3.UseVisualStyleBackColor = true;
            this.btnSaveCh3.Click += new System.EventHandler(this.btnSaveCh3_Click);
            // 
            // tbxPlcData0309
            // 
            this.tbxPlcData0309.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0309.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0309.Location = new System.Drawing.Point(520, 186);
            this.tbxPlcData0309.Name = "tbxPlcData0309";
            this.tbxPlcData0309.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0309.TabIndex = 60;
            this.tbxPlcData0309.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData0308
            // 
            this.tbxPlcData0308.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0308.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0308.Location = new System.Drawing.Point(414, 186);
            this.tbxPlcData0308.Name = "tbxPlcData0308";
            this.tbxPlcData0308.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0308.TabIndex = 59;
            this.tbxPlcData0308.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.Location = new System.Drawing.Point(87, 107);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(53, 12);
            this.label133.TabIndex = 41;
            this.label133.Text = "STEP #2";
            // 
            // tbxPlcData0307
            // 
            this.tbxPlcData0307.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0307.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0307.Location = new System.Drawing.Point(520, 159);
            this.tbxPlcData0307.Name = "tbxPlcData0307";
            this.tbxPlcData0307.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0307.TabIndex = 58;
            this.tbxPlcData0307.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.Location = new System.Drawing.Point(87, 134);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(53, 12);
            this.label134.TabIndex = 42;
            this.label134.Text = "STEP #3";
            // 
            // tbxPlcData0306
            // 
            this.tbxPlcData0306.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0306.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0306.Location = new System.Drawing.Point(414, 159);
            this.tbxPlcData0306.Name = "tbxPlcData0306";
            this.tbxPlcData0306.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0306.TabIndex = 57;
            this.tbxPlcData0306.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.Location = new System.Drawing.Point(87, 161);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(53, 12);
            this.label135.TabIndex = 43;
            this.label135.Text = "STEP #4";
            // 
            // tbxPlcData0305
            // 
            this.tbxPlcData0305.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0305.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0305.Location = new System.Drawing.Point(520, 132);
            this.tbxPlcData0305.Name = "tbxPlcData0305";
            this.tbxPlcData0305.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0305.TabIndex = 56;
            this.tbxPlcData0305.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.Location = new System.Drawing.Point(87, 188);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(53, 12);
            this.label136.TabIndex = 44;
            this.label136.Text = "STEP #5";
            // 
            // tbxPlcData0304
            // 
            this.tbxPlcData0304.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0304.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0304.Location = new System.Drawing.Point(414, 132);
            this.tbxPlcData0304.Name = "tbxPlcData0304";
            this.tbxPlcData0304.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0304.TabIndex = 55;
            this.tbxPlcData0304.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData0303
            // 
            this.tbxPlcData0303.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0303.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0303.Location = new System.Drawing.Point(520, 105);
            this.tbxPlcData0303.Name = "tbxPlcData0303";
            this.tbxPlcData0303.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0303.TabIndex = 54;
            this.tbxPlcData0303.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcData0302
            // 
            this.tbxPlcData0302.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0302.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0302.Location = new System.Drawing.Point(414, 105);
            this.tbxPlcData0302.Name = "tbxPlcData0302";
            this.tbxPlcData0302.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0302.TabIndex = 53;
            this.tbxPlcData0302.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0309
            // 
            this.tbxPlcSignal0309.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0309.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0309.Location = new System.Drawing.Point(252, 186);
            this.tbxPlcSignal0309.Name = "tbxPlcSignal0309";
            this.tbxPlcSignal0309.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0309.TabIndex = 52;
            this.tbxPlcSignal0309.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0308
            // 
            this.tbxPlcSignal0308.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0308.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0308.Location = new System.Drawing.Point(146, 186);
            this.tbxPlcSignal0308.Name = "tbxPlcSignal0308";
            this.tbxPlcSignal0308.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0308.TabIndex = 51;
            this.tbxPlcSignal0308.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0307
            // 
            this.tbxPlcSignal0307.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0307.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0307.Location = new System.Drawing.Point(252, 159);
            this.tbxPlcSignal0307.Name = "tbxPlcSignal0307";
            this.tbxPlcSignal0307.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0307.TabIndex = 50;
            this.tbxPlcSignal0307.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0302
            // 
            this.tbxPlcSignal0302.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0302.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0302.Location = new System.Drawing.Point(146, 105);
            this.tbxPlcSignal0302.Name = "tbxPlcSignal0302";
            this.tbxPlcSignal0302.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0302.TabIndex = 45;
            this.tbxPlcSignal0302.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0306
            // 
            this.tbxPlcSignal0306.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0306.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0306.Location = new System.Drawing.Point(146, 159);
            this.tbxPlcSignal0306.Name = "tbxPlcSignal0306";
            this.tbxPlcSignal0306.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0306.TabIndex = 49;
            this.tbxPlcSignal0306.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0303
            // 
            this.tbxPlcSignal0303.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0303.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0303.Location = new System.Drawing.Point(252, 105);
            this.tbxPlcSignal0303.Name = "tbxPlcSignal0303";
            this.tbxPlcSignal0303.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0303.TabIndex = 46;
            this.tbxPlcSignal0303.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0305
            // 
            this.tbxPlcSignal0305.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0305.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0305.Location = new System.Drawing.Point(252, 132);
            this.tbxPlcSignal0305.Name = "tbxPlcSignal0305";
            this.tbxPlcSignal0305.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0305.TabIndex = 48;
            this.tbxPlcSignal0305.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0304
            // 
            this.tbxPlcSignal0304.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0304.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0304.Location = new System.Drawing.Point(146, 132);
            this.tbxPlcSignal0304.Name = "tbxPlcSignal0304";
            this.tbxPlcSignal0304.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0304.TabIndex = 47;
            this.tbxPlcSignal0304.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Location = new System.Drawing.Point(805, 134);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(26, 12);
            this.label113.TabIndex = 39;
            this.label113.Text = "Unit";
            // 
            // tbxUnitAI03
            // 
            this.tbxUnitAI03.BackColor = System.Drawing.Color.Silver;
            this.tbxUnitAI03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI03.Location = new System.Drawing.Point(837, 132);
            this.tbxUnitAI03.Name = "tbxUnitAI03";
            this.tbxUnitAI03.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI03.TabIndex = 40;
            this.tbxUnitAI03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxD1094
            // 
            this.tbxD1094.BackColor = System.Drawing.Color.Silver;
            this.tbxD1094.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1094.Location = new System.Drawing.Point(837, 105);
            this.tbxD1094.Name = "tbxD1094";
            this.tbxD1094.Size = new System.Drawing.Size(100, 21);
            this.tbxD1094.TabIndex = 37;
            this.tbxD1094.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(742, 107);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(89, 12);
            this.label35.TabIndex = 35;
            this.label35.Text = "실시간 SIGNAL";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(754, 80);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(77, 12);
            this.label36.TabIndex = 36;
            this.label36.Text = "실시간 DATA";
            // 
            // tbxD1092
            // 
            this.tbxD1092.BackColor = System.Drawing.Color.Silver;
            this.tbxD1092.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1092.Location = new System.Drawing.Point(837, 78);
            this.tbxD1092.Name = "tbxD1092";
            this.tbxD1092.Size = new System.Drawing.Size(100, 21);
            this.tbxD1092.TabIndex = 38;
            this.tbxD1092.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0300
            // 
            this.tbxPlcSignal0300.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0300.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0300.Location = new System.Drawing.Point(146, 78);
            this.tbxPlcSignal0300.Name = "tbxPlcSignal0300";
            this.tbxPlcSignal0300.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0300.TabIndex = 11;
            this.tbxPlcSignal0300.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(87, 80);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(53, 12);
            this.label34.TabIndex = 0;
            this.label34.Text = "STEP #1";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(208, 20);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(77, 12);
            this.label39.TabIndex = 5;
            this.label39.Text = "PLC SIGNAL";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(186, 49);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(26, 12);
            this.label40.TabIndex = 6;
            this.label40.Text = "Min";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(288, 49);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(30, 12);
            this.label41.TabIndex = 7;
            this.label41.Text = "Max";
            // 
            // tbxPlcData0301
            // 
            this.tbxPlcData0301.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0301.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0301.Location = new System.Drawing.Point(520, 78);
            this.tbxPlcData0301.Name = "tbxPlcData0301";
            this.tbxPlcData0301.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0301.TabIndex = 22;
            this.tbxPlcData0301.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(482, 20);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(65, 12);
            this.label42.TabIndex = 8;
            this.label42.Text = "PLC DATA";
            // 
            // tbxPlcData0300
            // 
            this.tbxPlcData0300.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0300.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0300.Location = new System.Drawing.Point(414, 78);
            this.tbxPlcData0300.Name = "tbxPlcData0300";
            this.tbxPlcData0300.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0300.TabIndex = 21;
            this.tbxPlcData0300.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(451, 49);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(26, 12);
            this.label43.TabIndex = 9;
            this.label43.Text = "Min";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(553, 49);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(30, 12);
            this.label44.TabIndex = 10;
            this.label44.Text = "Max";
            // 
            // tbxPlcSignal0301
            // 
            this.tbxPlcSignal0301.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0301.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0301.Location = new System.Drawing.Point(252, 78);
            this.tbxPlcSignal0301.Name = "tbxPlcSignal0301";
            this.tbxPlcSignal0301.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0301.TabIndex = 12;
            this.tbxPlcSignal0301.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(952, 511);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "측정센서 4";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSaveCh4);
            this.panel5.Controls.Add(this.label114);
            this.panel5.Controls.Add(this.tbxUnitAI04);
            this.panel5.Controls.Add(this.tbxD1138);
            this.panel5.Controls.Add(this.label37);
            this.panel5.Controls.Add(this.label38);
            this.panel5.Controls.Add(this.tbxD1136);
            this.panel5.Controls.Add(this.tbxPlcSignal0400);
            this.panel5.Controls.Add(this.label45);
            this.panel5.Controls.Add(this.label50);
            this.panel5.Controls.Add(this.label51);
            this.panel5.Controls.Add(this.label52);
            this.panel5.Controls.Add(this.tbxPlcData0401);
            this.panel5.Controls.Add(this.label53);
            this.panel5.Controls.Add(this.tbxPlcData0400);
            this.panel5.Controls.Add(this.label54);
            this.panel5.Controls.Add(this.label55);
            this.panel5.Controls.Add(this.tbxPlcSignal0401);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(940, 499);
            this.panel5.TabIndex = 32;
            // 
            // btnSaveCh4
            // 
            this.btnSaveCh4.Location = new System.Drawing.Point(787, 446);
            this.btnSaveCh4.Name = "btnSaveCh4";
            this.btnSaveCh4.Size = new System.Drawing.Size(150, 50);
            this.btnSaveCh4.TabIndex = 41;
            this.btnSaveCh4.Text = "설정 저장하기";
            this.btnSaveCh4.UseVisualStyleBackColor = true;
            this.btnSaveCh4.Click += new System.EventHandler(this.btnSaveCh4_Click);
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Location = new System.Drawing.Point(805, 134);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(26, 12);
            this.label114.TabIndex = 39;
            this.label114.Text = "Unit";
            // 
            // tbxUnitAI04
            // 
            this.tbxUnitAI04.BackColor = System.Drawing.Color.Silver;
            this.tbxUnitAI04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI04.Location = new System.Drawing.Point(837, 132);
            this.tbxUnitAI04.Name = "tbxUnitAI04";
            this.tbxUnitAI04.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI04.TabIndex = 40;
            this.tbxUnitAI04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxD1138
            // 
            this.tbxD1138.BackColor = System.Drawing.Color.Silver;
            this.tbxD1138.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1138.Location = new System.Drawing.Point(837, 105);
            this.tbxD1138.Name = "tbxD1138";
            this.tbxD1138.Size = new System.Drawing.Size(100, 21);
            this.tbxD1138.TabIndex = 37;
            this.tbxD1138.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(742, 107);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(89, 12);
            this.label37.TabIndex = 35;
            this.label37.Text = "실시간 SIGNAL";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(754, 80);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(77, 12);
            this.label38.TabIndex = 36;
            this.label38.Text = "실시간 DATA";
            // 
            // tbxD1136
            // 
            this.tbxD1136.BackColor = System.Drawing.Color.Silver;
            this.tbxD1136.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1136.Location = new System.Drawing.Point(837, 78);
            this.tbxD1136.Name = "tbxD1136";
            this.tbxD1136.Size = new System.Drawing.Size(100, 21);
            this.tbxD1136.TabIndex = 38;
            this.tbxD1136.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0400
            // 
            this.tbxPlcSignal0400.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0400.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0400.Location = new System.Drawing.Point(146, 78);
            this.tbxPlcSignal0400.Name = "tbxPlcSignal0400";
            this.tbxPlcSignal0400.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0400.TabIndex = 11;
            this.tbxPlcSignal0400.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(87, 80);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(53, 12);
            this.label45.TabIndex = 0;
            this.label45.Text = "STEP #1";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(208, 20);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(77, 12);
            this.label50.TabIndex = 5;
            this.label50.Text = "PLC SIGNAL";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(186, 49);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(26, 12);
            this.label51.TabIndex = 6;
            this.label51.Text = "Min";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(288, 49);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(30, 12);
            this.label52.TabIndex = 7;
            this.label52.Text = "Max";
            // 
            // tbxPlcData0401
            // 
            this.tbxPlcData0401.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0401.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0401.Location = new System.Drawing.Point(520, 78);
            this.tbxPlcData0401.Name = "tbxPlcData0401";
            this.tbxPlcData0401.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0401.TabIndex = 22;
            this.tbxPlcData0401.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(482, 20);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(65, 12);
            this.label53.TabIndex = 8;
            this.label53.Text = "PLC DATA";
            // 
            // tbxPlcData0400
            // 
            this.tbxPlcData0400.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0400.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0400.Location = new System.Drawing.Point(414, 78);
            this.tbxPlcData0400.Name = "tbxPlcData0400";
            this.tbxPlcData0400.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0400.TabIndex = 21;
            this.tbxPlcData0400.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(451, 49);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(26, 12);
            this.label54.TabIndex = 9;
            this.label54.Text = "Min";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(553, 49);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(30, 12);
            this.label55.TabIndex = 10;
            this.label55.Text = "Max";
            // 
            // tbxPlcSignal0401
            // 
            this.tbxPlcSignal0401.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0401.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0401.Location = new System.Drawing.Point(252, 78);
            this.tbxPlcSignal0401.Name = "tbxPlcSignal0401";
            this.tbxPlcSignal0401.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0401.TabIndex = 12;
            this.tbxPlcSignal0401.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.panel6);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(952, 511);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "측정센서 5";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSaveCh5);
            this.panel6.Controls.Add(this.label115);
            this.panel6.Controls.Add(this.tbxUnitAI05);
            this.panel6.Controls.Add(this.tbxD1182);
            this.panel6.Controls.Add(this.label46);
            this.panel6.Controls.Add(this.label47);
            this.panel6.Controls.Add(this.tbxD1180);
            this.panel6.Controls.Add(this.tbxPlcSignal0500);
            this.panel6.Controls.Add(this.label56);
            this.panel6.Controls.Add(this.label61);
            this.panel6.Controls.Add(this.label62);
            this.panel6.Controls.Add(this.label63);
            this.panel6.Controls.Add(this.tbxPlcData0501);
            this.panel6.Controls.Add(this.label64);
            this.panel6.Controls.Add(this.tbxPlcData0500);
            this.panel6.Controls.Add(this.label65);
            this.panel6.Controls.Add(this.label66);
            this.panel6.Controls.Add(this.tbxPlcSignal0501);
            this.panel6.Location = new System.Drawing.Point(6, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(940, 499);
            this.panel6.TabIndex = 32;
            // 
            // btnSaveCh5
            // 
            this.btnSaveCh5.Location = new System.Drawing.Point(787, 446);
            this.btnSaveCh5.Name = "btnSaveCh5";
            this.btnSaveCh5.Size = new System.Drawing.Size(150, 50);
            this.btnSaveCh5.TabIndex = 41;
            this.btnSaveCh5.Text = "설정 저장하기";
            this.btnSaveCh5.UseVisualStyleBackColor = true;
            this.btnSaveCh5.Click += new System.EventHandler(this.btnSaveCh5_Click);
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Location = new System.Drawing.Point(805, 134);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(26, 12);
            this.label115.TabIndex = 39;
            this.label115.Text = "Unit";
            // 
            // tbxUnitAI05
            // 
            this.tbxUnitAI05.BackColor = System.Drawing.Color.Silver;
            this.tbxUnitAI05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI05.Location = new System.Drawing.Point(837, 132);
            this.tbxUnitAI05.Name = "tbxUnitAI05";
            this.tbxUnitAI05.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI05.TabIndex = 40;
            this.tbxUnitAI05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxD1182
            // 
            this.tbxD1182.BackColor = System.Drawing.Color.Silver;
            this.tbxD1182.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1182.Location = new System.Drawing.Point(837, 105);
            this.tbxD1182.Name = "tbxD1182";
            this.tbxD1182.Size = new System.Drawing.Size(100, 21);
            this.tbxD1182.TabIndex = 37;
            this.tbxD1182.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(742, 107);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(89, 12);
            this.label46.TabIndex = 35;
            this.label46.Text = "실시간 SIGNAL";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(754, 80);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(77, 12);
            this.label47.TabIndex = 36;
            this.label47.Text = "실시간 DATA";
            // 
            // tbxD1180
            // 
            this.tbxD1180.BackColor = System.Drawing.Color.Silver;
            this.tbxD1180.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1180.Location = new System.Drawing.Point(837, 78);
            this.tbxD1180.Name = "tbxD1180";
            this.tbxD1180.Size = new System.Drawing.Size(100, 21);
            this.tbxD1180.TabIndex = 38;
            this.tbxD1180.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0500
            // 
            this.tbxPlcSignal0500.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0500.Location = new System.Drawing.Point(146, 78);
            this.tbxPlcSignal0500.Name = "tbxPlcSignal0500";
            this.tbxPlcSignal0500.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0500.TabIndex = 11;
            this.tbxPlcSignal0500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(87, 80);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(53, 12);
            this.label56.TabIndex = 0;
            this.label56.Text = "STEP #1";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(208, 20);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(77, 12);
            this.label61.TabIndex = 5;
            this.label61.Text = "PLC SIGNAL";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(186, 49);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(26, 12);
            this.label62.TabIndex = 6;
            this.label62.Text = "Min";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(288, 49);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(30, 12);
            this.label63.TabIndex = 7;
            this.label63.Text = "Max";
            // 
            // tbxPlcData0501
            // 
            this.tbxPlcData0501.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0501.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0501.Location = new System.Drawing.Point(520, 78);
            this.tbxPlcData0501.Name = "tbxPlcData0501";
            this.tbxPlcData0501.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0501.TabIndex = 22;
            this.tbxPlcData0501.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(482, 20);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(65, 12);
            this.label64.TabIndex = 8;
            this.label64.Text = "PLC DATA";
            // 
            // tbxPlcData0500
            // 
            this.tbxPlcData0500.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0500.Location = new System.Drawing.Point(414, 78);
            this.tbxPlcData0500.Name = "tbxPlcData0500";
            this.tbxPlcData0500.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0500.TabIndex = 21;
            this.tbxPlcData0500.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(451, 49);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(26, 12);
            this.label65.TabIndex = 9;
            this.label65.Text = "Min";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(553, 49);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(30, 12);
            this.label66.TabIndex = 10;
            this.label66.Text = "Max";
            // 
            // tbxPlcSignal0501
            // 
            this.tbxPlcSignal0501.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0501.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0501.Location = new System.Drawing.Point(252, 78);
            this.tbxPlcSignal0501.Name = "tbxPlcSignal0501";
            this.tbxPlcSignal0501.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0501.TabIndex = 12;
            this.tbxPlcSignal0501.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Controls.Add(this.panel7);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(952, 511);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "측정센서 6";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnSaveCh6);
            this.panel7.Controls.Add(this.label122);
            this.panel7.Controls.Add(this.tbxUnitAI06);
            this.panel7.Controls.Add(this.tbxD1226);
            this.panel7.Controls.Add(this.label48);
            this.panel7.Controls.Add(this.label49);
            this.panel7.Controls.Add(this.tbxD1224);
            this.panel7.Controls.Add(this.tbxPlcSignal0600);
            this.panel7.Controls.Add(this.label67);
            this.panel7.Controls.Add(this.label72);
            this.panel7.Controls.Add(this.label73);
            this.panel7.Controls.Add(this.label74);
            this.panel7.Controls.Add(this.tbxPlcData0601);
            this.panel7.Controls.Add(this.label75);
            this.panel7.Controls.Add(this.tbxPlcData0600);
            this.panel7.Controls.Add(this.label76);
            this.panel7.Controls.Add(this.label77);
            this.panel7.Controls.Add(this.tbxPlcSignal0601);
            this.panel7.Location = new System.Drawing.Point(6, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(940, 499);
            this.panel7.TabIndex = 32;
            // 
            // btnSaveCh6
            // 
            this.btnSaveCh6.Location = new System.Drawing.Point(787, 446);
            this.btnSaveCh6.Name = "btnSaveCh6";
            this.btnSaveCh6.Size = new System.Drawing.Size(150, 50);
            this.btnSaveCh6.TabIndex = 41;
            this.btnSaveCh6.Text = "설정 저장하기";
            this.btnSaveCh6.UseVisualStyleBackColor = true;
            this.btnSaveCh6.Click += new System.EventHandler(this.btnSaveCh6_Click);
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.Location = new System.Drawing.Point(805, 134);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(26, 12);
            this.label122.TabIndex = 39;
            this.label122.Text = "Unit";
            // 
            // tbxUnitAI06
            // 
            this.tbxUnitAI06.BackColor = System.Drawing.Color.Silver;
            this.tbxUnitAI06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI06.Location = new System.Drawing.Point(837, 132);
            this.tbxUnitAI06.Name = "tbxUnitAI06";
            this.tbxUnitAI06.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI06.TabIndex = 40;
            this.tbxUnitAI06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxD1226
            // 
            this.tbxD1226.BackColor = System.Drawing.Color.Silver;
            this.tbxD1226.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1226.Location = new System.Drawing.Point(837, 105);
            this.tbxD1226.Name = "tbxD1226";
            this.tbxD1226.Size = new System.Drawing.Size(100, 21);
            this.tbxD1226.TabIndex = 37;
            this.tbxD1226.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(742, 107);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(89, 12);
            this.label48.TabIndex = 35;
            this.label48.Text = "실시간 SIGNAL";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(754, 80);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(77, 12);
            this.label49.TabIndex = 36;
            this.label49.Text = "실시간 DATA";
            // 
            // tbxD1224
            // 
            this.tbxD1224.BackColor = System.Drawing.Color.Silver;
            this.tbxD1224.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1224.Location = new System.Drawing.Point(837, 78);
            this.tbxD1224.Name = "tbxD1224";
            this.tbxD1224.Size = new System.Drawing.Size(100, 21);
            this.tbxD1224.TabIndex = 38;
            this.tbxD1224.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0600
            // 
            this.tbxPlcSignal0600.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0600.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0600.Location = new System.Drawing.Point(146, 78);
            this.tbxPlcSignal0600.Name = "tbxPlcSignal0600";
            this.tbxPlcSignal0600.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0600.TabIndex = 11;
            this.tbxPlcSignal0600.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(87, 80);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(53, 12);
            this.label67.TabIndex = 0;
            this.label67.Text = "STEP #1";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Location = new System.Drawing.Point(208, 20);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(77, 12);
            this.label72.TabIndex = 5;
            this.label72.Text = "PLC SIGNAL";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(186, 49);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(26, 12);
            this.label73.TabIndex = 6;
            this.label73.Text = "Min";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(288, 49);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(30, 12);
            this.label74.TabIndex = 7;
            this.label74.Text = "Max";
            // 
            // tbxPlcData0601
            // 
            this.tbxPlcData0601.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0601.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0601.Location = new System.Drawing.Point(520, 78);
            this.tbxPlcData0601.Name = "tbxPlcData0601";
            this.tbxPlcData0601.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0601.TabIndex = 22;
            this.tbxPlcData0601.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Location = new System.Drawing.Point(482, 20);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(65, 12);
            this.label75.TabIndex = 8;
            this.label75.Text = "PLC DATA";
            // 
            // tbxPlcData0600
            // 
            this.tbxPlcData0600.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0600.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0600.Location = new System.Drawing.Point(414, 78);
            this.tbxPlcData0600.Name = "tbxPlcData0600";
            this.tbxPlcData0600.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0600.TabIndex = 21;
            this.tbxPlcData0600.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Location = new System.Drawing.Point(451, 49);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(26, 12);
            this.label76.TabIndex = 9;
            this.label76.Text = "Min";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(553, 49);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(30, 12);
            this.label77.TabIndex = 10;
            this.label77.Text = "Max";
            // 
            // tbxPlcSignal0601
            // 
            this.tbxPlcSignal0601.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0601.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0601.Location = new System.Drawing.Point(252, 78);
            this.tbxPlcSignal0601.Name = "tbxPlcSignal0601";
            this.tbxPlcSignal0601.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0601.TabIndex = 12;
            this.tbxPlcSignal0601.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.Color.White;
            this.tabPage7.Controls.Add(this.panel2);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(952, 511);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "측정센서 7";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveCh7);
            this.panel2.Controls.Add(this.label123);
            this.panel2.Controls.Add(this.tbxUnitAI07);
            this.panel2.Controls.Add(this.tbxD1270);
            this.panel2.Controls.Add(this.label57);
            this.panel2.Controls.Add(this.label58);
            this.panel2.Controls.Add(this.tbxD1268);
            this.panel2.Controls.Add(this.tbxPlcSignal0700);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.tbxPlcData0701);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.tbxPlcData0700);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.tbxPlcSignal0701);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 499);
            this.panel2.TabIndex = 32;
            // 
            // btnSaveCh7
            // 
            this.btnSaveCh7.Location = new System.Drawing.Point(787, 446);
            this.btnSaveCh7.Name = "btnSaveCh7";
            this.btnSaveCh7.Size = new System.Drawing.Size(150, 50);
            this.btnSaveCh7.TabIndex = 41;
            this.btnSaveCh7.Text = "설정 저장하기";
            this.btnSaveCh7.UseVisualStyleBackColor = true;
            this.btnSaveCh7.Click += new System.EventHandler(this.btnSaveCh7_Click);
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(805, 134);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(26, 12);
            this.label123.TabIndex = 39;
            this.label123.Text = "Unit";
            // 
            // tbxUnitAI07
            // 
            this.tbxUnitAI07.BackColor = System.Drawing.Color.Silver;
            this.tbxUnitAI07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI07.Location = new System.Drawing.Point(837, 132);
            this.tbxUnitAI07.Name = "tbxUnitAI07";
            this.tbxUnitAI07.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI07.TabIndex = 40;
            this.tbxUnitAI07.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxD1270
            // 
            this.tbxD1270.BackColor = System.Drawing.Color.Silver;
            this.tbxD1270.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1270.Location = new System.Drawing.Point(837, 105);
            this.tbxD1270.Name = "tbxD1270";
            this.tbxD1270.Size = new System.Drawing.Size(100, 21);
            this.tbxD1270.TabIndex = 37;
            this.tbxD1270.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(742, 107);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(89, 12);
            this.label57.TabIndex = 35;
            this.label57.Text = "실시간 SIGNAL";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(754, 80);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(77, 12);
            this.label58.TabIndex = 36;
            this.label58.Text = "실시간 DATA";
            // 
            // tbxD1268
            // 
            this.tbxD1268.BackColor = System.Drawing.Color.Silver;
            this.tbxD1268.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1268.Location = new System.Drawing.Point(837, 78);
            this.tbxD1268.Name = "tbxD1268";
            this.tbxD1268.Size = new System.Drawing.Size(100, 21);
            this.tbxD1268.TabIndex = 38;
            this.tbxD1268.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0700
            // 
            this.tbxPlcSignal0700.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0700.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0700.Location = new System.Drawing.Point(146, 78);
            this.tbxPlcSignal0700.Name = "tbxPlcSignal0700";
            this.tbxPlcSignal0700.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0700.TabIndex = 11;
            this.tbxPlcSignal0700.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "STEP #1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(208, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 12);
            this.label17.TabIndex = 5;
            this.label17.Text = "PLC SIGNAL";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(186, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 12);
            this.label18.TabIndex = 6;
            this.label18.Text = "Min";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(288, 49);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 12);
            this.label19.TabIndex = 7;
            this.label19.Text = "Max";
            // 
            // tbxPlcData0701
            // 
            this.tbxPlcData0701.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0701.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0701.Location = new System.Drawing.Point(520, 78);
            this.tbxPlcData0701.Name = "tbxPlcData0701";
            this.tbxPlcData0701.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0701.TabIndex = 22;
            this.tbxPlcData0701.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(482, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 12);
            this.label20.TabIndex = 8;
            this.label20.Text = "PLC DATA";
            // 
            // tbxPlcData0700
            // 
            this.tbxPlcData0700.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0700.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0700.Location = new System.Drawing.Point(414, 78);
            this.tbxPlcData0700.Name = "tbxPlcData0700";
            this.tbxPlcData0700.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0700.TabIndex = 21;
            this.tbxPlcData0700.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(451, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 12);
            this.label21.TabIndex = 9;
            this.label21.Text = "Min";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(553, 49);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 12);
            this.label22.TabIndex = 10;
            this.label22.Text = "Max";
            // 
            // tbxPlcSignal0701
            // 
            this.tbxPlcSignal0701.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0701.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0701.Location = new System.Drawing.Point(252, 78);
            this.tbxPlcSignal0701.Name = "tbxPlcSignal0701";
            this.tbxPlcSignal0701.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0701.TabIndex = 12;
            this.tbxPlcSignal0701.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.Color.White;
            this.tabPage8.Controls.Add(this.panel8);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(952, 511);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "측정센서 8";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSaveCh8);
            this.panel8.Controls.Add(this.label124);
            this.panel8.Controls.Add(this.tbxUnitAI08);
            this.panel8.Controls.Add(this.tbxD1314);
            this.panel8.Controls.Add(this.label59);
            this.panel8.Controls.Add(this.label60);
            this.panel8.Controls.Add(this.tbxD1312);
            this.panel8.Controls.Add(this.tbxPlcSignal0800);
            this.panel8.Controls.Add(this.label78);
            this.panel8.Controls.Add(this.label83);
            this.panel8.Controls.Add(this.label84);
            this.panel8.Controls.Add(this.label85);
            this.panel8.Controls.Add(this.tbxPlcData0801);
            this.panel8.Controls.Add(this.label86);
            this.panel8.Controls.Add(this.tbxPlcData0800);
            this.panel8.Controls.Add(this.label87);
            this.panel8.Controls.Add(this.label88);
            this.panel8.Controls.Add(this.tbxPlcSignal0801);
            this.panel8.Location = new System.Drawing.Point(6, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(940, 499);
            this.panel8.TabIndex = 32;
            // 
            // btnSaveCh8
            // 
            this.btnSaveCh8.Location = new System.Drawing.Point(787, 446);
            this.btnSaveCh8.Name = "btnSaveCh8";
            this.btnSaveCh8.Size = new System.Drawing.Size(150, 50);
            this.btnSaveCh8.TabIndex = 41;
            this.btnSaveCh8.Text = "설정 저장하기";
            this.btnSaveCh8.UseVisualStyleBackColor = true;
            this.btnSaveCh8.Click += new System.EventHandler(this.btnSaveCh8_Click);
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.Location = new System.Drawing.Point(805, 134);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(26, 12);
            this.label124.TabIndex = 39;
            this.label124.Text = "Unit";
            // 
            // tbxUnitAI08
            // 
            this.tbxUnitAI08.BackColor = System.Drawing.Color.Silver;
            this.tbxUnitAI08.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI08.Location = new System.Drawing.Point(837, 132);
            this.tbxUnitAI08.Name = "tbxUnitAI08";
            this.tbxUnitAI08.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI08.TabIndex = 40;
            this.tbxUnitAI08.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxD1314
            // 
            this.tbxD1314.BackColor = System.Drawing.Color.Silver;
            this.tbxD1314.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1314.Location = new System.Drawing.Point(837, 105);
            this.tbxD1314.Name = "tbxD1314";
            this.tbxD1314.Size = new System.Drawing.Size(100, 21);
            this.tbxD1314.TabIndex = 37;
            this.tbxD1314.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(742, 107);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(89, 12);
            this.label59.TabIndex = 35;
            this.label59.Text = "실시간 SIGNAL";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(754, 80);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(77, 12);
            this.label60.TabIndex = 36;
            this.label60.Text = "실시간 DATA";
            // 
            // tbxD1312
            // 
            this.tbxD1312.BackColor = System.Drawing.Color.Silver;
            this.tbxD1312.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1312.Location = new System.Drawing.Point(837, 78);
            this.tbxD1312.Name = "tbxD1312";
            this.tbxD1312.Size = new System.Drawing.Size(100, 21);
            this.tbxD1312.TabIndex = 38;
            this.tbxD1312.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0800
            // 
            this.tbxPlcSignal0800.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0800.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0800.Location = new System.Drawing.Point(146, 78);
            this.tbxPlcSignal0800.Name = "tbxPlcSignal0800";
            this.tbxPlcSignal0800.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0800.TabIndex = 11;
            this.tbxPlcSignal0800.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Location = new System.Drawing.Point(87, 80);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(53, 12);
            this.label78.TabIndex = 0;
            this.label78.Text = "STEP #1";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Location = new System.Drawing.Point(208, 20);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(77, 12);
            this.label83.TabIndex = 5;
            this.label83.Text = "PLC SIGNAL";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Location = new System.Drawing.Point(186, 49);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(26, 12);
            this.label84.TabIndex = 6;
            this.label84.Text = "Min";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Location = new System.Drawing.Point(288, 49);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(30, 12);
            this.label85.TabIndex = 7;
            this.label85.Text = "Max";
            // 
            // tbxPlcData0801
            // 
            this.tbxPlcData0801.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0801.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0801.Location = new System.Drawing.Point(520, 78);
            this.tbxPlcData0801.Name = "tbxPlcData0801";
            this.tbxPlcData0801.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0801.TabIndex = 22;
            this.tbxPlcData0801.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Location = new System.Drawing.Point(482, 20);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(65, 12);
            this.label86.TabIndex = 8;
            this.label86.Text = "PLC DATA";
            // 
            // tbxPlcData0800
            // 
            this.tbxPlcData0800.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0800.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0800.Location = new System.Drawing.Point(414, 78);
            this.tbxPlcData0800.Name = "tbxPlcData0800";
            this.tbxPlcData0800.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0800.TabIndex = 21;
            this.tbxPlcData0800.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Location = new System.Drawing.Point(451, 49);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(26, 12);
            this.label87.TabIndex = 9;
            this.label87.Text = "Min";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Location = new System.Drawing.Point(553, 49);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(30, 12);
            this.label88.TabIndex = 10;
            this.label88.Text = "Max";
            // 
            // tbxPlcSignal0801
            // 
            this.tbxPlcSignal0801.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0801.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0801.Location = new System.Drawing.Point(252, 78);
            this.tbxPlcSignal0801.Name = "tbxPlcSignal0801";
            this.tbxPlcSignal0801.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0801.TabIndex = 12;
            this.tbxPlcSignal0801.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.Color.White;
            this.tabPage9.Controls.Add(this.panel12);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(952, 511);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "측정센서 9";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnSaveCh9);
            this.panel12.Controls.Add(this.label125);
            this.panel12.Controls.Add(this.tbxUnitAI09);
            this.panel12.Controls.Add(this.tbxD1358);
            this.panel12.Controls.Add(this.label68);
            this.panel12.Controls.Add(this.label69);
            this.panel12.Controls.Add(this.tbxD1356);
            this.panel12.Controls.Add(this.tbxPlcSignal0900);
            this.panel12.Controls.Add(this.label90);
            this.panel12.Controls.Add(this.label91);
            this.panel12.Controls.Add(this.label92);
            this.panel12.Controls.Add(this.label93);
            this.panel12.Controls.Add(this.tbxPlcData0901);
            this.panel12.Controls.Add(this.label101);
            this.panel12.Controls.Add(this.tbxPlcData0900);
            this.panel12.Controls.Add(this.label102);
            this.panel12.Controls.Add(this.label103);
            this.panel12.Controls.Add(this.tbxPlcSignal0901);
            this.panel12.Location = new System.Drawing.Point(6, 6);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(940, 499);
            this.panel12.TabIndex = 33;
            // 
            // btnSaveCh9
            // 
            this.btnSaveCh9.Location = new System.Drawing.Point(787, 446);
            this.btnSaveCh9.Name = "btnSaveCh9";
            this.btnSaveCh9.Size = new System.Drawing.Size(150, 50);
            this.btnSaveCh9.TabIndex = 41;
            this.btnSaveCh9.Text = "설정 저장하기";
            this.btnSaveCh9.UseVisualStyleBackColor = true;
            this.btnSaveCh9.Click += new System.EventHandler(this.btnSaveCh9_Click);
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.Location = new System.Drawing.Point(805, 134);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(26, 12);
            this.label125.TabIndex = 39;
            this.label125.Text = "Unit";
            // 
            // tbxUnitAI09
            // 
            this.tbxUnitAI09.BackColor = System.Drawing.Color.Silver;
            this.tbxUnitAI09.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI09.Location = new System.Drawing.Point(837, 132);
            this.tbxUnitAI09.Name = "tbxUnitAI09";
            this.tbxUnitAI09.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI09.TabIndex = 40;
            this.tbxUnitAI09.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxD1358
            // 
            this.tbxD1358.BackColor = System.Drawing.Color.Silver;
            this.tbxD1358.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1358.Location = new System.Drawing.Point(837, 105);
            this.tbxD1358.Name = "tbxD1358";
            this.tbxD1358.Size = new System.Drawing.Size(100, 21);
            this.tbxD1358.TabIndex = 37;
            this.tbxD1358.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Location = new System.Drawing.Point(742, 107);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(89, 12);
            this.label68.TabIndex = 35;
            this.label68.Text = "실시간 SIGNAL";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Location = new System.Drawing.Point(754, 80);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(77, 12);
            this.label69.TabIndex = 36;
            this.label69.Text = "실시간 DATA";
            // 
            // tbxD1356
            // 
            this.tbxD1356.BackColor = System.Drawing.Color.Silver;
            this.tbxD1356.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1356.Location = new System.Drawing.Point(837, 78);
            this.tbxD1356.Name = "tbxD1356";
            this.tbxD1356.Size = new System.Drawing.Size(100, 21);
            this.tbxD1356.TabIndex = 38;
            this.tbxD1356.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal0900
            // 
            this.tbxPlcSignal0900.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0900.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0900.Location = new System.Drawing.Point(146, 78);
            this.tbxPlcSignal0900.Name = "tbxPlcSignal0900";
            this.tbxPlcSignal0900.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0900.TabIndex = 11;
            this.tbxPlcSignal0900.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Location = new System.Drawing.Point(87, 80);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(53, 12);
            this.label90.TabIndex = 0;
            this.label90.Text = "STEP #1";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Location = new System.Drawing.Point(208, 20);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(77, 12);
            this.label91.TabIndex = 5;
            this.label91.Text = "PLC SIGNAL";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Location = new System.Drawing.Point(186, 49);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(26, 12);
            this.label92.TabIndex = 6;
            this.label92.Text = "Min";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Location = new System.Drawing.Point(288, 49);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(30, 12);
            this.label93.TabIndex = 7;
            this.label93.Text = "Max";
            // 
            // tbxPlcData0901
            // 
            this.tbxPlcData0901.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0901.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0901.Location = new System.Drawing.Point(520, 78);
            this.tbxPlcData0901.Name = "tbxPlcData0901";
            this.tbxPlcData0901.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0901.TabIndex = 22;
            this.tbxPlcData0901.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.Location = new System.Drawing.Point(482, 20);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(65, 12);
            this.label101.TabIndex = 8;
            this.label101.Text = "PLC DATA";
            // 
            // tbxPlcData0900
            // 
            this.tbxPlcData0900.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData0900.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData0900.Location = new System.Drawing.Point(414, 78);
            this.tbxPlcData0900.Name = "tbxPlcData0900";
            this.tbxPlcData0900.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData0900.TabIndex = 21;
            this.tbxPlcData0900.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.Location = new System.Drawing.Point(451, 49);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(26, 12);
            this.label102.TabIndex = 9;
            this.label102.Text = "Min";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.Location = new System.Drawing.Point(553, 49);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(30, 12);
            this.label103.TabIndex = 10;
            this.label103.Text = "Max";
            // 
            // tbxPlcSignal0901
            // 
            this.tbxPlcSignal0901.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal0901.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal0901.Location = new System.Drawing.Point(252, 78);
            this.tbxPlcSignal0901.Name = "tbxPlcSignal0901";
            this.tbxPlcSignal0901.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal0901.TabIndex = 12;
            this.tbxPlcSignal0901.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage10
            // 
            this.tabPage10.BackColor = System.Drawing.Color.White;
            this.tabPage10.Controls.Add(this.panel9);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(952, 511);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "측정센서 10";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnSaveCh10);
            this.panel9.Controls.Add(this.label126);
            this.panel9.Controls.Add(this.tbxUnitAI10);
            this.panel9.Controls.Add(this.tbxD1402);
            this.panel9.Controls.Add(this.label70);
            this.panel9.Controls.Add(this.label71);
            this.panel9.Controls.Add(this.tbxD1400);
            this.panel9.Controls.Add(this.tbxPlcSignal1000);
            this.panel9.Controls.Add(this.label89);
            this.panel9.Controls.Add(this.label94);
            this.panel9.Controls.Add(this.label95);
            this.panel9.Controls.Add(this.label96);
            this.panel9.Controls.Add(this.tbxPlcData1001);
            this.panel9.Controls.Add(this.label97);
            this.panel9.Controls.Add(this.tbxPlcData1000);
            this.panel9.Controls.Add(this.label98);
            this.panel9.Controls.Add(this.label99);
            this.panel9.Controls.Add(this.tbxPlcSignal1001);
            this.panel9.Location = new System.Drawing.Point(6, 6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(940, 499);
            this.panel9.TabIndex = 32;
            // 
            // btnSaveCh10
            // 
            this.btnSaveCh10.Location = new System.Drawing.Point(787, 446);
            this.btnSaveCh10.Name = "btnSaveCh10";
            this.btnSaveCh10.Size = new System.Drawing.Size(150, 50);
            this.btnSaveCh10.TabIndex = 41;
            this.btnSaveCh10.Text = "설정 저장하기";
            this.btnSaveCh10.UseVisualStyleBackColor = true;
            this.btnSaveCh10.Click += new System.EventHandler(this.btnSaveCh10_Click);
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.Location = new System.Drawing.Point(805, 134);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(26, 12);
            this.label126.TabIndex = 39;
            this.label126.Text = "Unit";
            // 
            // tbxUnitAI10
            // 
            this.tbxUnitAI10.BackColor = System.Drawing.Color.Silver;
            this.tbxUnitAI10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI10.Location = new System.Drawing.Point(837, 132);
            this.tbxUnitAI10.Name = "tbxUnitAI10";
            this.tbxUnitAI10.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI10.TabIndex = 40;
            this.tbxUnitAI10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxD1402
            // 
            this.tbxD1402.BackColor = System.Drawing.Color.Silver;
            this.tbxD1402.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1402.Location = new System.Drawing.Point(837, 105);
            this.tbxD1402.Name = "tbxD1402";
            this.tbxD1402.Size = new System.Drawing.Size(100, 21);
            this.tbxD1402.TabIndex = 37;
            this.tbxD1402.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(742, 107);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(89, 12);
            this.label70.TabIndex = 35;
            this.label70.Text = "실시간 SIGNAL";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(754, 80);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(77, 12);
            this.label71.TabIndex = 36;
            this.label71.Text = "실시간 DATA";
            // 
            // tbxD1400
            // 
            this.tbxD1400.BackColor = System.Drawing.Color.Silver;
            this.tbxD1400.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1400.Location = new System.Drawing.Point(837, 78);
            this.tbxD1400.Name = "tbxD1400";
            this.tbxD1400.Size = new System.Drawing.Size(100, 21);
            this.tbxD1400.TabIndex = 38;
            this.tbxD1400.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal1000
            // 
            this.tbxPlcSignal1000.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal1000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal1000.Location = new System.Drawing.Point(146, 78);
            this.tbxPlcSignal1000.Name = "tbxPlcSignal1000";
            this.tbxPlcSignal1000.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal1000.TabIndex = 11;
            this.tbxPlcSignal1000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Location = new System.Drawing.Point(87, 80);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(53, 12);
            this.label89.TabIndex = 0;
            this.label89.Text = "STEP #1";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Location = new System.Drawing.Point(208, 20);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(77, 12);
            this.label94.TabIndex = 5;
            this.label94.Text = "PLC SIGNAL";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.Location = new System.Drawing.Point(186, 49);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(26, 12);
            this.label95.TabIndex = 6;
            this.label95.Text = "Min";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.Location = new System.Drawing.Point(288, 49);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(30, 12);
            this.label96.TabIndex = 7;
            this.label96.Text = "Max";
            // 
            // tbxPlcData1001
            // 
            this.tbxPlcData1001.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData1001.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData1001.Location = new System.Drawing.Point(520, 78);
            this.tbxPlcData1001.Name = "tbxPlcData1001";
            this.tbxPlcData1001.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData1001.TabIndex = 22;
            this.tbxPlcData1001.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.Location = new System.Drawing.Point(482, 20);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(65, 12);
            this.label97.TabIndex = 8;
            this.label97.Text = "PLC DATA";
            // 
            // tbxPlcData1000
            // 
            this.tbxPlcData1000.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData1000.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData1000.Location = new System.Drawing.Point(414, 78);
            this.tbxPlcData1000.Name = "tbxPlcData1000";
            this.tbxPlcData1000.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData1000.TabIndex = 21;
            this.tbxPlcData1000.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.Location = new System.Drawing.Point(451, 49);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(26, 12);
            this.label98.TabIndex = 9;
            this.label98.Text = "Min";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Location = new System.Drawing.Point(553, 49);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(30, 12);
            this.label99.TabIndex = 10;
            this.label99.Text = "Max";
            // 
            // tbxPlcSignal1001
            // 
            this.tbxPlcSignal1001.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal1001.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal1001.Location = new System.Drawing.Point(252, 78);
            this.tbxPlcSignal1001.Name = "tbxPlcSignal1001";
            this.tbxPlcSignal1001.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal1001.TabIndex = 12;
            this.tbxPlcSignal1001.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage11
            // 
            this.tabPage11.BackColor = System.Drawing.Color.White;
            this.tabPage11.Controls.Add(this.panel10);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(952, 511);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "측정센서 11";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnSaveCh11);
            this.panel10.Controls.Add(this.label127);
            this.panel10.Controls.Add(this.tbxUnitAI11);
            this.panel10.Controls.Add(this.tbxD1446);
            this.panel10.Controls.Add(this.label79);
            this.panel10.Controls.Add(this.label80);
            this.panel10.Controls.Add(this.tbxD1444);
            this.panel10.Controls.Add(this.tbxPlcSignal1100);
            this.panel10.Controls.Add(this.label100);
            this.panel10.Controls.Add(this.label105);
            this.panel10.Controls.Add(this.label106);
            this.panel10.Controls.Add(this.label107);
            this.panel10.Controls.Add(this.tbxPlcData1101);
            this.panel10.Controls.Add(this.label108);
            this.panel10.Controls.Add(this.tbxPlcData1100);
            this.panel10.Controls.Add(this.label109);
            this.panel10.Controls.Add(this.label110);
            this.panel10.Controls.Add(this.tbxPlcSignal1101);
            this.panel10.Location = new System.Drawing.Point(6, 6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(940, 499);
            this.panel10.TabIndex = 32;
            // 
            // btnSaveCh11
            // 
            this.btnSaveCh11.Location = new System.Drawing.Point(787, 446);
            this.btnSaveCh11.Name = "btnSaveCh11";
            this.btnSaveCh11.Size = new System.Drawing.Size(150, 50);
            this.btnSaveCh11.TabIndex = 41;
            this.btnSaveCh11.Text = "설정 저장하기";
            this.btnSaveCh11.UseVisualStyleBackColor = true;
            this.btnSaveCh11.Click += new System.EventHandler(this.btnSaveCh11_Click);
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.Location = new System.Drawing.Point(805, 134);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(26, 12);
            this.label127.TabIndex = 39;
            this.label127.Text = "Unit";
            // 
            // tbxUnitAI11
            // 
            this.tbxUnitAI11.BackColor = System.Drawing.Color.Silver;
            this.tbxUnitAI11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI11.Location = new System.Drawing.Point(837, 132);
            this.tbxUnitAI11.Name = "tbxUnitAI11";
            this.tbxUnitAI11.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI11.TabIndex = 40;
            this.tbxUnitAI11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxD1446
            // 
            this.tbxD1446.BackColor = System.Drawing.Color.Silver;
            this.tbxD1446.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1446.Location = new System.Drawing.Point(837, 105);
            this.tbxD1446.Name = "tbxD1446";
            this.tbxD1446.Size = new System.Drawing.Size(100, 21);
            this.tbxD1446.TabIndex = 37;
            this.tbxD1446.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Location = new System.Drawing.Point(742, 107);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(89, 12);
            this.label79.TabIndex = 35;
            this.label79.Text = "실시간 SIGNAL";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Location = new System.Drawing.Point(754, 80);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(77, 12);
            this.label80.TabIndex = 36;
            this.label80.Text = "실시간 DATA";
            // 
            // tbxD1444
            // 
            this.tbxD1444.BackColor = System.Drawing.Color.Silver;
            this.tbxD1444.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1444.Location = new System.Drawing.Point(837, 78);
            this.tbxD1444.Name = "tbxD1444";
            this.tbxD1444.Size = new System.Drawing.Size(100, 21);
            this.tbxD1444.TabIndex = 38;
            this.tbxD1444.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal1100
            // 
            this.tbxPlcSignal1100.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal1100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal1100.Location = new System.Drawing.Point(146, 78);
            this.tbxPlcSignal1100.Name = "tbxPlcSignal1100";
            this.tbxPlcSignal1100.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal1100.TabIndex = 11;
            this.tbxPlcSignal1100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Location = new System.Drawing.Point(87, 80);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(53, 12);
            this.label100.TabIndex = 0;
            this.label100.Text = "STEP #1";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.Location = new System.Drawing.Point(208, 20);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(77, 12);
            this.label105.TabIndex = 5;
            this.label105.Text = "PLC SIGNAL";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Location = new System.Drawing.Point(186, 49);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(26, 12);
            this.label106.TabIndex = 6;
            this.label106.Text = "Min";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.Location = new System.Drawing.Point(288, 49);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(30, 12);
            this.label107.TabIndex = 7;
            this.label107.Text = "Max";
            // 
            // tbxPlcData1101
            // 
            this.tbxPlcData1101.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData1101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData1101.Location = new System.Drawing.Point(520, 78);
            this.tbxPlcData1101.Name = "tbxPlcData1101";
            this.tbxPlcData1101.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData1101.TabIndex = 22;
            this.tbxPlcData1101.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.Location = new System.Drawing.Point(482, 20);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(65, 12);
            this.label108.TabIndex = 8;
            this.label108.Text = "PLC DATA";
            // 
            // tbxPlcData1100
            // 
            this.tbxPlcData1100.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData1100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData1100.Location = new System.Drawing.Point(414, 78);
            this.tbxPlcData1100.Name = "tbxPlcData1100";
            this.tbxPlcData1100.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData1100.TabIndex = 21;
            this.tbxPlcData1100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.Location = new System.Drawing.Point(451, 49);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(26, 12);
            this.label109.TabIndex = 9;
            this.label109.Text = "Min";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.Location = new System.Drawing.Point(553, 49);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(30, 12);
            this.label110.TabIndex = 10;
            this.label110.Text = "Max";
            // 
            // tbxPlcSignal1101
            // 
            this.tbxPlcSignal1101.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal1101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal1101.Location = new System.Drawing.Point(252, 78);
            this.tbxPlcSignal1101.Name = "tbxPlcSignal1101";
            this.tbxPlcSignal1101.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal1101.TabIndex = 12;
            this.tbxPlcSignal1101.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage12
            // 
            this.tabPage12.BackColor = System.Drawing.Color.White;
            this.tabPage12.Controls.Add(this.panel11);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(952, 511);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "측정센서 12";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnSaveCh12);
            this.panel11.Controls.Add(this.label128);
            this.panel11.Controls.Add(this.tbxUnitAI12);
            this.panel11.Controls.Add(this.tbxD1490);
            this.panel11.Controls.Add(this.label81);
            this.panel11.Controls.Add(this.label82);
            this.panel11.Controls.Add(this.tbxD1488);
            this.panel11.Controls.Add(this.tbxPlcSignal1200);
            this.panel11.Controls.Add(this.label111);
            this.panel11.Controls.Add(this.label116);
            this.panel11.Controls.Add(this.label117);
            this.panel11.Controls.Add(this.label118);
            this.panel11.Controls.Add(this.tbxPlcData1201);
            this.panel11.Controls.Add(this.label119);
            this.panel11.Controls.Add(this.tbxPlcData1200);
            this.panel11.Controls.Add(this.label120);
            this.panel11.Controls.Add(this.label121);
            this.panel11.Controls.Add(this.tbxPlcSignal1201);
            this.panel11.Location = new System.Drawing.Point(6, 6);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(940, 499);
            this.panel11.TabIndex = 32;
            // 
            // btnSaveCh12
            // 
            this.btnSaveCh12.Location = new System.Drawing.Point(787, 446);
            this.btnSaveCh12.Name = "btnSaveCh12";
            this.btnSaveCh12.Size = new System.Drawing.Size(150, 50);
            this.btnSaveCh12.TabIndex = 41;
            this.btnSaveCh12.Text = "설정 저장하기";
            this.btnSaveCh12.UseVisualStyleBackColor = true;
            this.btnSaveCh12.Click += new System.EventHandler(this.btnSaveCh12_Click);
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.Location = new System.Drawing.Point(805, 134);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(26, 12);
            this.label128.TabIndex = 39;
            this.label128.Text = "Unit";
            // 
            // tbxUnitAI12
            // 
            this.tbxUnitAI12.BackColor = System.Drawing.Color.Silver;
            this.tbxUnitAI12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxUnitAI12.Location = new System.Drawing.Point(837, 132);
            this.tbxUnitAI12.Name = "tbxUnitAI12";
            this.tbxUnitAI12.Size = new System.Drawing.Size(100, 21);
            this.tbxUnitAI12.TabIndex = 40;
            this.tbxUnitAI12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxD1490
            // 
            this.tbxD1490.BackColor = System.Drawing.Color.Silver;
            this.tbxD1490.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1490.Location = new System.Drawing.Point(837, 105);
            this.tbxD1490.Name = "tbxD1490";
            this.tbxD1490.Size = new System.Drawing.Size(100, 21);
            this.tbxD1490.TabIndex = 37;
            this.tbxD1490.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Location = new System.Drawing.Point(742, 107);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(89, 12);
            this.label81.TabIndex = 35;
            this.label81.Text = "실시간 SIGNAL";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Location = new System.Drawing.Point(754, 80);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(77, 12);
            this.label82.TabIndex = 36;
            this.label82.Text = "실시간 DATA";
            // 
            // tbxD1488
            // 
            this.tbxD1488.BackColor = System.Drawing.Color.Silver;
            this.tbxD1488.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxD1488.Location = new System.Drawing.Point(837, 78);
            this.tbxD1488.Name = "tbxD1488";
            this.tbxD1488.Size = new System.Drawing.Size(100, 21);
            this.tbxD1488.TabIndex = 38;
            this.tbxD1488.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPlcSignal1200
            // 
            this.tbxPlcSignal1200.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal1200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal1200.Location = new System.Drawing.Point(146, 78);
            this.tbxPlcSignal1200.Name = "tbxPlcSignal1200";
            this.tbxPlcSignal1200.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal1200.TabIndex = 11;
            this.tbxPlcSignal1200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.Location = new System.Drawing.Point(87, 80);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(53, 12);
            this.label111.TabIndex = 0;
            this.label111.Text = "STEP #1";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.Location = new System.Drawing.Point(208, 20);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(77, 12);
            this.label116.TabIndex = 5;
            this.label116.Text = "PLC SIGNAL";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.Location = new System.Drawing.Point(186, 49);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(26, 12);
            this.label117.TabIndex = 6;
            this.label117.Text = "Min";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(288, 49);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(30, 12);
            this.label118.TabIndex = 7;
            this.label118.Text = "Max";
            // 
            // tbxPlcData1201
            // 
            this.tbxPlcData1201.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData1201.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData1201.Location = new System.Drawing.Point(520, 78);
            this.tbxPlcData1201.Name = "tbxPlcData1201";
            this.tbxPlcData1201.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData1201.TabIndex = 22;
            this.tbxPlcData1201.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Location = new System.Drawing.Point(482, 20);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(65, 12);
            this.label119.TabIndex = 8;
            this.label119.Text = "PLC DATA";
            // 
            // tbxPlcData1200
            // 
            this.tbxPlcData1200.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcData1200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcData1200.Location = new System.Drawing.Point(414, 78);
            this.tbxPlcData1200.Name = "tbxPlcData1200";
            this.tbxPlcData1200.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcData1200.TabIndex = 21;
            this.tbxPlcData1200.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Location = new System.Drawing.Point(451, 49);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(26, 12);
            this.label120.TabIndex = 9;
            this.label120.Text = "Min";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.Location = new System.Drawing.Point(553, 49);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(30, 12);
            this.label121.TabIndex = 10;
            this.label121.Text = "Max";
            // 
            // tbxPlcSignal1201
            // 
            this.tbxPlcSignal1201.BackColor = System.Drawing.SystemColors.Info;
            this.tbxPlcSignal1201.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPlcSignal1201.Location = new System.Drawing.Point(252, 78);
            this.tbxPlcSignal1201.Name = "tbxPlcSignal1201";
            this.tbxPlcSignal1201.Size = new System.Drawing.Size(100, 21);
            this.tbxPlcSignal1201.TabIndex = 12;
            this.tbxPlcSignal1201.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnReadAllChannel
            // 
            this.btnReadAllChannel.Location = new System.Drawing.Point(22, 555);
            this.btnReadAllChannel.Name = "btnReadAllChannel";
            this.btnReadAllChannel.Size = new System.Drawing.Size(150, 50);
            this.btnReadAllChannel.TabIndex = 38;
            this.btnReadAllChannel.Text = "12채널 전체 읽기";
            this.btnReadAllChannel.UseVisualStyleBackColor = true;
            this.btnReadAllChannel.Click += new System.EventHandler(this.btnReadAllChannel_Click);
            // 
            // frmPlcSensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 672);
            this.Controls.Add(this.btnReadAllChannel);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPlcSensor";
            this.Text = "PLC Sensor";
            this.Load += new System.EventHandler(this.frmPlcSensor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tabPage10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tabPage11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbxD1006;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbxD1004;
        private System.Windows.Forms.TextBox tbxPlcSignal0100;
        private System.Windows.Forms.TextBox tbxPlcData0109;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxPlcData0108;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPlcData0107;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPlcData0106;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPlcData0105;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPlcData0104;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPlcData0103;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPlcData0102;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxPlcData0101;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxPlcData0100;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxPlcSignal0109;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxPlcSignal0108;
        private System.Windows.Forms.TextBox tbxPlcSignal0101;
        private System.Windows.Forms.TextBox tbxPlcSignal0107;
        private System.Windows.Forms.TextBox tbxPlcSignal0102;
        private System.Windows.Forms.TextBox tbxPlcSignal0106;
        private System.Windows.Forms.TextBox tbxPlcSignal0103;
        private System.Windows.Forms.TextBox tbxPlcSignal0105;
        private System.Windows.Forms.TextBox tbxPlcSignal0104;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbxD1050;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox tbxD1048;
        private System.Windows.Forms.TextBox tbxPlcSignal0200;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox tbxPlcData0201;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox tbxPlcData0200;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox tbxPlcSignal0201;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbxD1094;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox tbxD1092;
        private System.Windows.Forms.TextBox tbxPlcSignal0300;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox tbxPlcData0301;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tbxPlcData0300;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox tbxPlcSignal0301;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbxD1138;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox tbxD1136;
        private System.Windows.Forms.TextBox tbxPlcSignal0400;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox tbxPlcData0401;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox tbxPlcData0400;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox tbxPlcSignal0401;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbxD1182;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox tbxD1180;
        private System.Windows.Forms.TextBox tbxPlcSignal0500;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox tbxPlcData0501;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox tbxPlcData0500;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.TextBox tbxPlcSignal0501;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox tbxD1226;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox tbxD1224;
        private System.Windows.Forms.TextBox tbxPlcSignal0600;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.TextBox tbxPlcData0601;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.TextBox tbxPlcData0600;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.TextBox tbxPlcSignal0601;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbxD1270;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox tbxD1268;
        private System.Windows.Forms.TextBox tbxPlcSignal0700;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxPlcData0701;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbxPlcData0700;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbxPlcSignal0701;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox tbxD1314;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox tbxD1312;
        private System.Windows.Forms.TextBox tbxPlcSignal0800;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.TextBox tbxPlcData0801;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox tbxPlcData0800;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.TextBox tbxPlcSignal0801;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox tbxD1358;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox tbxD1356;
        private System.Windows.Forms.TextBox tbxPlcSignal0900;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.TextBox tbxPlcData0901;
        private System.Windows.Forms.Label label101;
        private System.Windows.Forms.TextBox tbxPlcData0900;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label103;
        private System.Windows.Forms.TextBox tbxPlcSignal0901;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox tbxD1402;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.TextBox tbxD1400;
        private System.Windows.Forms.TextBox tbxPlcSignal1000;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label94;
        private System.Windows.Forms.Label label95;
        private System.Windows.Forms.Label label96;
        private System.Windows.Forms.TextBox tbxPlcData1001;
        private System.Windows.Forms.Label label97;
        private System.Windows.Forms.TextBox tbxPlcData1000;
        private System.Windows.Forms.Label label98;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.TextBox tbxPlcSignal1001;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox tbxD1446;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.TextBox tbxD1444;
        private System.Windows.Forms.TextBox tbxPlcSignal1100;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.Label label105;
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.Label label107;
        private System.Windows.Forms.TextBox tbxPlcData1101;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.TextBox tbxPlcData1100;
        private System.Windows.Forms.Label label109;
        private System.Windows.Forms.Label label110;
        private System.Windows.Forms.TextBox tbxPlcSignal1101;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox tbxD1490;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.TextBox tbxD1488;
        private System.Windows.Forms.TextBox tbxPlcSignal1200;
        private System.Windows.Forms.Label label111;
        private System.Windows.Forms.Label label116;
        private System.Windows.Forms.Label label117;
        private System.Windows.Forms.Label label118;
        private System.Windows.Forms.TextBox tbxPlcData1201;
        private System.Windows.Forms.Label label119;
        private System.Windows.Forms.TextBox tbxPlcData1200;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.Label label121;
        private System.Windows.Forms.TextBox tbxPlcSignal1201;
        private System.Windows.Forms.Label label104;
        private System.Windows.Forms.TextBox tbxUnitAI01;
        private System.Windows.Forms.Label label112;
        private System.Windows.Forms.TextBox tbxUnitAI02;
        private System.Windows.Forms.Label label113;
        private System.Windows.Forms.TextBox tbxUnitAI03;
        private System.Windows.Forms.Label label114;
        private System.Windows.Forms.TextBox tbxUnitAI04;
        private System.Windows.Forms.Label label115;
        private System.Windows.Forms.TextBox tbxUnitAI05;
        private System.Windows.Forms.Label label122;
        private System.Windows.Forms.TextBox tbxUnitAI06;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.TextBox tbxUnitAI07;
        private System.Windows.Forms.Label label124;
        private System.Windows.Forms.TextBox tbxUnitAI08;
        private System.Windows.Forms.Label label125;
        private System.Windows.Forms.TextBox tbxUnitAI09;
        private System.Windows.Forms.Label label126;
        private System.Windows.Forms.TextBox tbxUnitAI10;
        private System.Windows.Forms.Label label127;
        private System.Windows.Forms.TextBox tbxUnitAI11;
        private System.Windows.Forms.Label label128;
        private System.Windows.Forms.TextBox tbxUnitAI12;
        private System.Windows.Forms.TextBox tbxPlcData0209;
        private System.Windows.Forms.TextBox tbxPlcData0208;
        private System.Windows.Forms.Label label129;
        private System.Windows.Forms.TextBox tbxPlcData0207;
        private System.Windows.Forms.Label label130;
        private System.Windows.Forms.TextBox tbxPlcData0206;
        private System.Windows.Forms.Label label131;
        private System.Windows.Forms.TextBox tbxPlcData0205;
        private System.Windows.Forms.Label label132;
        private System.Windows.Forms.TextBox tbxPlcData0204;
        private System.Windows.Forms.TextBox tbxPlcData0203;
        private System.Windows.Forms.TextBox tbxPlcData0202;
        private System.Windows.Forms.TextBox tbxPlcSignal0209;
        private System.Windows.Forms.TextBox tbxPlcSignal0208;
        private System.Windows.Forms.TextBox tbxPlcSignal0207;
        private System.Windows.Forms.TextBox tbxPlcSignal0202;
        private System.Windows.Forms.TextBox tbxPlcSignal0206;
        private System.Windows.Forms.TextBox tbxPlcSignal0203;
        private System.Windows.Forms.TextBox tbxPlcSignal0205;
        private System.Windows.Forms.TextBox tbxPlcSignal0204;
        private System.Windows.Forms.TextBox tbxPlcData0309;
        private System.Windows.Forms.TextBox tbxPlcData0308;
        private System.Windows.Forms.Label label133;
        private System.Windows.Forms.TextBox tbxPlcData0307;
        private System.Windows.Forms.Label label134;
        private System.Windows.Forms.TextBox tbxPlcData0306;
        private System.Windows.Forms.Label label135;
        private System.Windows.Forms.TextBox tbxPlcData0305;
        private System.Windows.Forms.Label label136;
        private System.Windows.Forms.TextBox tbxPlcData0304;
        private System.Windows.Forms.TextBox tbxPlcData0303;
        private System.Windows.Forms.TextBox tbxPlcData0302;
        private System.Windows.Forms.TextBox tbxPlcSignal0309;
        private System.Windows.Forms.TextBox tbxPlcSignal0308;
        private System.Windows.Forms.TextBox tbxPlcSignal0307;
        private System.Windows.Forms.TextBox tbxPlcSignal0302;
        private System.Windows.Forms.TextBox tbxPlcSignal0306;
        private System.Windows.Forms.TextBox tbxPlcSignal0303;
        private System.Windows.Forms.TextBox tbxPlcSignal0305;
        private System.Windows.Forms.TextBox tbxPlcSignal0304;
        private System.Windows.Forms.Button btnSaveCh1;
        private System.Windows.Forms.Button btnSaveCh2;
        private System.Windows.Forms.Button btnSaveCh3;
        private System.Windows.Forms.Button btnSaveCh4;
        private System.Windows.Forms.Button btnSaveCh5;
        private System.Windows.Forms.Button btnSaveCh6;
        private System.Windows.Forms.Button btnSaveCh7;
        private System.Windows.Forms.Button btnSaveCh8;
        private System.Windows.Forms.Button btnSaveCh9;
        private System.Windows.Forms.Button btnSaveCh10;
        private System.Windows.Forms.Button btnSaveCh11;
        private System.Windows.Forms.Button btnSaveCh12;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnReadAllChannel;
        //================================================================================================================================


        public FrmPlcSensor()
        {
            InitializeComponent();
            mIns = this;
            plcComm1 = new PlcComm(ip: "192.168.0.153", port: 2004);
        }
        public static FrmPlcSensor mIns;
        PlcComm plcComm1 = null;

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl1.TabPages[e.Index];
            e.Graphics.FillRectangle(new SolidBrush(page.BackColor), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, e.Font, paddedBounds, page.ForeColor);
        }

        public bool SetChAi_1_12(string[] ch1, string[] ch2, string[] ch3, string[] ch4, string[] ch5, string[] ch6, string[] ch7, string[] ch8, string[] ch9, string[] ch10, string[] ch11, string[] ch12)
        {
            try
            {
                tbxPlcSignal0100.Text = ch1[0];
                tbxPlcSignal0101.Text = ch1[1];
                tbxPlcSignal0102.Text = ch1[2];
                tbxPlcSignal0103.Text = ch1[3];
                tbxPlcSignal0104.Text = ch1[4];
                tbxPlcSignal0105.Text = ch1[5];
                tbxPlcSignal0106.Text = ch1[6];
                tbxPlcSignal0107.Text = ch1[7];
                tbxPlcSignal0108.Text = ch1[8];
                tbxPlcSignal0109.Text = ch1[9];

                tbxPlcData0100.Text = ch1[10];
                tbxPlcData0101.Text = ch1[11];
                tbxPlcData0102.Text = ch1[12];
                tbxPlcData0103.Text = ch1[13];
                tbxPlcData0104.Text = ch1[14];
                tbxPlcData0105.Text = ch1[15];
                tbxPlcData0106.Text = ch1[16];
                tbxPlcData0107.Text = ch1[17];
                tbxPlcData0108.Text = ch1[18];
                tbxPlcData0109.Text = ch1[19];

                tbxPlcSignal0200.Text = ch2[0];
                tbxPlcSignal0201.Text = ch2[1];
                tbxPlcSignal0202.Text = ch2[2];
                tbxPlcSignal0203.Text = ch2[3];
                tbxPlcSignal0204.Text = ch2[4];
                tbxPlcSignal0205.Text = ch2[5];
                tbxPlcSignal0206.Text = ch2[6];
                tbxPlcSignal0207.Text = ch2[7];
                tbxPlcSignal0208.Text = ch2[8];
                tbxPlcSignal0209.Text = ch2[9];

                tbxPlcData0200.Text = ch2[10];
                tbxPlcData0201.Text = ch2[11];
                tbxPlcData0202.Text = ch2[12];
                tbxPlcData0203.Text = ch2[13];
                tbxPlcData0204.Text = ch2[14];
                tbxPlcData0205.Text = ch2[15];
                tbxPlcData0206.Text = ch2[16];
                tbxPlcData0207.Text = ch2[17];
                tbxPlcData0208.Text = ch2[18];
                tbxPlcData0209.Text = ch2[19];


                tbxPlcSignal0300.Text = ch3[0];
                tbxPlcSignal0301.Text = ch3[1];
                tbxPlcSignal0302.Text = ch3[2];
                tbxPlcSignal0303.Text = ch3[3];
                tbxPlcSignal0304.Text = ch3[4];
                tbxPlcSignal0305.Text = ch3[5];
                tbxPlcSignal0306.Text = ch3[6];
                tbxPlcSignal0307.Text = ch3[7];
                tbxPlcSignal0308.Text = ch3[8];
                tbxPlcSignal0309.Text = ch3[9];

                tbxPlcData0300.Text = ch3[10];
                tbxPlcData0301.Text = ch3[11];
                tbxPlcData0302.Text = ch3[12];
                tbxPlcData0303.Text = ch3[13];
                tbxPlcData0304.Text = ch3[14];
                tbxPlcData0305.Text = ch3[15];
                tbxPlcData0306.Text = ch3[16];
                tbxPlcData0307.Text = ch3[17];
                tbxPlcData0308.Text = ch3[18];
                tbxPlcData0309.Text = ch3[19];

                tbxPlcSignal0400.Text = ch4[0];
                tbxPlcSignal0401.Text = ch4[1];
                tbxPlcData0400.Text = ch4[2];
                tbxPlcData0401.Text = ch4[3];

                tbxPlcSignal0500.Text = ch5[0];
                tbxPlcSignal0501.Text = ch5[1];
                tbxPlcData0500.Text = ch5[2];
                tbxPlcData0501.Text = ch5[3];

                tbxPlcSignal0600.Text = ch6[0];
                tbxPlcSignal0601.Text = ch6[1];
                tbxPlcData0600.Text = ch6[2];
                tbxPlcData0601.Text = ch6[3];

                tbxPlcSignal0700.Text = ch7[0];
                tbxPlcSignal0701.Text = ch7[1];
                tbxPlcData0700.Text = ch7[2];
                tbxPlcData0701.Text = ch7[3];

                tbxPlcSignal0800.Text = ch8[0];
                tbxPlcSignal0801.Text = ch8[1];
                tbxPlcData0800.Text = ch8[2];
                tbxPlcData0801.Text = ch8[3];

                tbxPlcSignal0900.Text = ch9[0];
                tbxPlcSignal0901.Text = ch9[1];
                tbxPlcData0900.Text = ch9[2];
                tbxPlcData0901.Text = ch9[3];

                tbxPlcSignal1000.Text = ch10[0];
                tbxPlcSignal1001.Text = ch10[1];
                tbxPlcData1000.Text = ch10[2];
                tbxPlcData1001.Text = ch10[3];

                tbxPlcSignal1100.Text = ch11[0];
                tbxPlcSignal1101.Text = ch11[1];
                tbxPlcData1100.Text = ch11[2];
                tbxPlcData1101.Text = ch11[3];

                tbxPlcSignal1200.Text = ch12[0];
                tbxPlcSignal1201.Text = ch12[1];
                tbxPlcData1200.Text = ch12[2];
                tbxPlcData1201.Text = ch12[3];

                return true;
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.ToString());
                return false;
            }
        }
        public bool WritePlcChAi_1_12()
        {
            object sender = null;
            EventArgs e = null;
            try
            {
                btnSaveCh1_Click(sender, e);
                btnSaveCh2_Click(sender, e);
                btnSaveCh3_Click(sender, e);
                btnSaveCh4_Click(sender, e);

                btnSaveCh5_Click(sender, e);
                btnSaveCh6_Click(sender, e);
                btnSaveCh7_Click(sender, e);
                btnSaveCh8_Click(sender, e);

                btnSaveCh9_Click(sender, e);
                btnSaveCh10_Click(sender, e);
                btnSaveCh11_Click(sender, e);
                btnSaveCh12_Click(sender, e);

                return true;
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.ToString());
                return false;
            }


        }

        private void btnSaveCh1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal0100.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0101.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0102.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0103.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0104.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0105.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0106.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0107.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0108.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0109.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData0100.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0101.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0102.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0103.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0104.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0105.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0106.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0107.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0108.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0109.Text)) return;

            int iDataCountMax = 20;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1008;
            int nextIndex = 0;
            int addCount = 0;
              Single[] setDataValueList = new Single[iDataCountMax];


            //--밀양 tpstjdusth 23.06.13 수정안 (min & max address 변경)
            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal0101.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal0100.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData0101.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData0100.Text);

            setDataValueList[4] = Convert.ToSingle(tbxPlcSignal0103.Text);
            setDataValueList[5] = Convert.ToSingle(tbxPlcSignal0102.Text);
            setDataValueList[6] = Convert.ToSingle(tbxPlcData0103.Text);
            setDataValueList[7] = Convert.ToSingle(tbxPlcData0102.Text);

            setDataValueList[8] = Convert.ToSingle(tbxPlcSignal0105.Text);
            setDataValueList[9] = Convert.ToSingle(tbxPlcSignal0104.Text);
            setDataValueList[10] = Convert.ToSingle(tbxPlcData0105.Text);
            setDataValueList[11] = Convert.ToSingle(tbxPlcData0104.Text);

            setDataValueList[12] = Convert.ToSingle(tbxPlcSignal0107.Text);
            setDataValueList[13] = Convert.ToSingle(tbxPlcSignal0106.Text);
            setDataValueList[14] = Convert.ToSingle(tbxPlcData0107.Text);
            setDataValueList[15] = Convert.ToSingle(tbxPlcData0106.Text);

            setDataValueList[16] = Convert.ToSingle(tbxPlcSignal0109.Text);
            setDataValueList[17] = Convert.ToSingle(tbxPlcSignal0108.Text);
            setDataValueList[18] = Convert.ToSingle(tbxPlcData0109.Text);
            setDataValueList[19] = Convert.ToSingle(tbxPlcData0108.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //------------------add
            addrMapList = null;
            addrMapList = new string[addCount];
            startAddress = nextIndex;
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            startIndex = iDataProcMax;
            endIndex = iDataCountMax;
            strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
   
        }

        private void btnSaveCh2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal0200.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0201.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0202.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0203.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0204.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0205.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0206.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0207.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0208.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0209.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData0200.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0201.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0202.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0203.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0204.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0205.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0206.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0207.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0208.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0209.Text)) return;

            int iDataCountMax = 20;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1052;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];
          
            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal0201.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal0200.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData0201.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData0200.Text);

            setDataValueList[4] = Convert.ToSingle(tbxPlcSignal0203.Text);
            setDataValueList[5] = Convert.ToSingle(tbxPlcSignal0202.Text);
            setDataValueList[6] = Convert.ToSingle(tbxPlcData0203.Text);
            setDataValueList[7] = Convert.ToSingle(tbxPlcData0202.Text);

            setDataValueList[8] = Convert.ToSingle(tbxPlcSignal0205.Text);
            setDataValueList[9] = Convert.ToSingle(tbxPlcSignal0204.Text);
            setDataValueList[10] = Convert.ToSingle(tbxPlcData0205.Text);
            setDataValueList[11] = Convert.ToSingle(tbxPlcData0204.Text);

            setDataValueList[12] = Convert.ToSingle(tbxPlcSignal0207.Text);
            setDataValueList[13] = Convert.ToSingle(tbxPlcSignal0206.Text);
            setDataValueList[14] = Convert.ToSingle(tbxPlcData0207.Text);
            setDataValueList[15] = Convert.ToSingle(tbxPlcData0206.Text);

            setDataValueList[16] = Convert.ToSingle(tbxPlcSignal0209.Text);
            setDataValueList[17] = Convert.ToSingle(tbxPlcSignal0208.Text);
            setDataValueList[18] = Convert.ToSingle(tbxPlcData0209.Text);
            setDataValueList[19] = Convert.ToSingle(tbxPlcData0208.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //------------------add
            addrMapList = null;
            addrMapList = new string[addCount];
            startAddress = nextIndex;
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            startIndex = iDataProcMax;
            endIndex = iDataCountMax;
            strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
            //Read Ch2
            //btnReadCh2();
        }

        private void btnSaveCh3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal0300.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0301.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0302.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0303.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0304.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0305.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0306.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0307.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0308.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0309.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData0300.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0301.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0302.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0303.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0304.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0305.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0306.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0307.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0308.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0309.Text)) return;

            int iDataCountMax = 20;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1096;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal0301.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal0300.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData0300.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData0301.Text);

            setDataValueList[4] = Convert.ToSingle(tbxPlcSignal0303.Text);
            setDataValueList[5] = Convert.ToSingle(tbxPlcSignal0302.Text);
            setDataValueList[6] = Convert.ToSingle(tbxPlcData0303.Text);
            setDataValueList[7] = Convert.ToSingle(tbxPlcData0302.Text);

            setDataValueList[8] = Convert.ToSingle(tbxPlcSignal0305.Text);
            setDataValueList[9] = Convert.ToSingle(tbxPlcSignal0304.Text);
            setDataValueList[10] = Convert.ToSingle(tbxPlcData0305.Text);
            setDataValueList[11] = Convert.ToSingle(tbxPlcData0304.Text);

            setDataValueList[12] = Convert.ToSingle(tbxPlcSignal0307.Text);
            setDataValueList[13] = Convert.ToSingle(tbxPlcSignal0306.Text);
            setDataValueList[14] = Convert.ToSingle(tbxPlcData0307.Text);
            setDataValueList[15] = Convert.ToSingle(tbxPlcData0306.Text);

            setDataValueList[16] = Convert.ToSingle(tbxPlcSignal0309.Text);
            setDataValueList[17] = Convert.ToSingle(tbxPlcSignal0308.Text);
            setDataValueList[18] = Convert.ToSingle(tbxPlcData0309.Text);
            setDataValueList[19] = Convert.ToSingle(tbxPlcData0308.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //------------------add
            addrMapList = null;
            addrMapList = new string[addCount];
            startAddress = nextIndex;
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            startIndex = iDataProcMax;
            endIndex = iDataCountMax;
            strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------

        }

        private void btnSaveCh4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal0400.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0401.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData0400.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0401.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1140;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal0401.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal0400.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData0401.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData0400.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
            //Read Channel
            //btnReadCh4();
        }

        private void btnSaveCh5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal0500.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0501.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData0500.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0501.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1184;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal0501.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal0500.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData0501.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData0500.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
        }

        private void btnSaveCh6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal0600.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0601.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData0600.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0601.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1228;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal0601.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal0600.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData0601.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData0600.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
        }

        private void btnSaveCh7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal0700.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0701.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData0700.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0701.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1272;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal0701.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal0700.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData0701.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData0700.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
        }

        private void btnSaveCh8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal0800.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0801.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData0800.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0801.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1316;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal0801.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal0800.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData0801.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData0800.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
        }

        private void btnSaveCh9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal0900.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal0901.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData0900.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData0901.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1360;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal0901.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal0900.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData0901.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData0900.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
        }

        private void btnSaveCh10_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal1000.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal1001.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData1000.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData1001.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1404;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal1001.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal1000.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData1001.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData1000.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
        }

        private void btnSaveCh11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal1100.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal1101.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData1100.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData1101.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1448;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal1101.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal1100.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData1101.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData1100.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
        }

        private void btnSaveCh12_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPlcSignal1200.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcSignal1201.Text)) return;

            if (string.IsNullOrEmpty(tbxPlcData1200.Text)) return;
            if (string.IsNullOrEmpty(tbxPlcData1201.Text)) return;

            int iDataCountMax = 4;
            int iDataProcMax = 16;//write max; //읽기,쓰기 최대 16 DWORD
            int startAddress = 1492;
            int nextIndex = 0;
            int addCount = 0;
            float[] setDataValueList = new float[iDataCountMax];

            setDataValueList[0] = Convert.ToSingle(tbxPlcSignal1201.Text);
            setDataValueList[1] = Convert.ToSingle(tbxPlcSignal1200.Text);
            setDataValueList[2] = Convert.ToSingle(tbxPlcData1201.Text);
            setDataValueList[3] = Convert.ToSingle(tbxPlcData1200.Text);

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }
            else
            {
                iDataProcMax = iDataCountMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
            }

            int startIndex = 0;
            int endIndex = iDataProcMax;
            string strRtn = plcComm1.WriteDwordEachRun(addrMapList, setDataValueList, startIndex, endIndex);
            //---------------------
        }

        private void frmPlcSensor_Load(object sender, EventArgs e)
        {
        }

        private void PlcSensorDataRead()
        {
            btnReadCh1();
            btnReadCh2();
            btnReadCh3();
            btnReadCh4();
            btnReadCh5();
            btnReadCh6();
            btnReadCh7();
            btnReadCh8();
            btnReadCh9();
            btnReadCh10();
            btnReadCh11();
            btnReadCh12();
            btnReadAI1_12();
        }

        private void ChannelDataUpdate(int chNo, string strRtn)
        {
            string[] split_comma = strRtn.Split(',');

            switch (chNo)
            {
                case 1:
                    tbxD1004.Text = split_comma[0];
                    tbxD1006.Text = split_comma[1];

                    tbxPlcSignal0100.Text = split_comma[2];
                    tbxPlcSignal0101.Text = split_comma[3];
                    tbxPlcData0100.Text = split_comma[4];
                    tbxPlcData0101.Text = split_comma[5];

                    tbxPlcSignal0102.Text = split_comma[6];
                    tbxPlcSignal0103.Text = split_comma[7];
                    tbxPlcData0102.Text = split_comma[8];
                    tbxPlcData0103.Text = split_comma[9];

                    tbxPlcSignal0104.Text = split_comma[10];
                    tbxPlcSignal0105.Text = split_comma[11];
                    tbxPlcData0104.Text = split_comma[12];
                    tbxPlcData0105.Text = split_comma[13];

                    tbxPlcSignal0106.Text = split_comma[14];
                    tbxPlcSignal0107.Text = split_comma[15];
                    tbxPlcData0106.Text = split_comma[16];
                    tbxPlcData0107.Text = split_comma[17];

                    tbxPlcSignal0108.Text = split_comma[18];
                    tbxPlcSignal0109.Text = split_comma[19];
                    tbxPlcData0108.Text = split_comma[20];
                    tbxPlcData0109.Text = split_comma[21];
                    break;
                case 2:
                    tbxD1048.Text = split_comma[0];
                    tbxD1050.Text = split_comma[1];

                    tbxPlcSignal0200.Text = split_comma[2];
                    tbxPlcSignal0201.Text = split_comma[3];
                    tbxPlcData0200.Text = split_comma[4];
                    tbxPlcData0201.Text = split_comma[5];

                    tbxPlcSignal0202.Text = split_comma[6];
                    tbxPlcSignal0203.Text = split_comma[7];
                    tbxPlcData0202.Text = split_comma[8];
                    tbxPlcData0203.Text = split_comma[9];

                    tbxPlcSignal0204.Text = split_comma[10];
                    tbxPlcSignal0205.Text = split_comma[11];
                    tbxPlcData0204.Text = split_comma[12];
                    tbxPlcData0205.Text = split_comma[13];

                    tbxPlcSignal0206.Text = split_comma[14];
                    tbxPlcSignal0207.Text = split_comma[15];
                    tbxPlcData0206.Text = split_comma[16];
                    tbxPlcData0207.Text = split_comma[17];

                    tbxPlcSignal0208.Text = split_comma[18];
                    tbxPlcSignal0209.Text = split_comma[19];
                    tbxPlcData0208.Text = split_comma[20];
                    tbxPlcData0209.Text = split_comma[21];
                    break;
                case 3:
                    tbxD1092.Text = split_comma[0];
                    tbxD1094.Text = split_comma[1];

                    tbxPlcSignal0300.Text = split_comma[2];
                    tbxPlcSignal0301.Text = split_comma[3];
                    tbxPlcData0300.Text = split_comma[4];
                    tbxPlcData0301.Text = split_comma[5];

                    tbxPlcSignal0302.Text = split_comma[6];
                    tbxPlcSignal0303.Text = split_comma[7];
                    tbxPlcData0302.Text = split_comma[8];
                    tbxPlcData0303.Text = split_comma[9];

                    tbxPlcSignal0304.Text = split_comma[10];
                    tbxPlcSignal0305.Text = split_comma[11];
                    tbxPlcData0304.Text = split_comma[12];
                    tbxPlcData0305.Text = split_comma[13];

                    tbxPlcSignal0306.Text = split_comma[14];
                    tbxPlcSignal0307.Text = split_comma[15];
                    tbxPlcData0306.Text = split_comma[16];
                    tbxPlcData0307.Text = split_comma[17];

                    tbxPlcSignal0308.Text = split_comma[18];
                    tbxPlcSignal0309.Text = split_comma[19];
                    tbxPlcData0308.Text = split_comma[20];
                    tbxPlcData0309.Text = split_comma[21];
                    break;

                case 4:
                    tbxD1136.Text = split_comma[0];
                    tbxD1138.Text = split_comma[1];

                    tbxPlcSignal0400.Text = split_comma[2];
                    tbxPlcSignal0401.Text = split_comma[3];
                    tbxPlcData0400.Text = split_comma[4];
                    tbxPlcData0401.Text = split_comma[5];
                    break;
                case 5:
                    tbxD1180.Text = split_comma[0];
                    tbxD1182.Text = split_comma[1];

                    tbxPlcSignal0500.Text = split_comma[2];
                    tbxPlcSignal0501.Text = split_comma[3];
                    tbxPlcData0500.Text = split_comma[4];
                    tbxPlcData0501.Text = split_comma[5];
                    break;
                case 6:
                    tbxD1224.Text = split_comma[0];
                    tbxD1226.Text = split_comma[1];

                    tbxPlcSignal0600.Text = split_comma[2];
                    tbxPlcSignal0601.Text = split_comma[3];
                    tbxPlcData0600.Text = split_comma[4];
                    tbxPlcData0601.Text = split_comma[5];
                    break;
                case 7:
                    tbxD1268.Text = split_comma[0];
                    tbxD1270.Text = split_comma[1];

                    tbxPlcSignal0700.Text = split_comma[2];
                    tbxPlcSignal0701.Text = split_comma[3];
                    tbxPlcData0700.Text = split_comma[4];
                    tbxPlcData0701.Text = split_comma[5];
                    break;
                case 8:
                    tbxD1312.Text = split_comma[0];
                    tbxD1314.Text = split_comma[1];

                    tbxPlcSignal0800.Text = split_comma[2];
                    tbxPlcSignal0801.Text = split_comma[3];
                    tbxPlcData0800.Text = split_comma[4];
                    tbxPlcData0801.Text = split_comma[5];
                    break;
                case 9:
                    tbxD1356.Text = split_comma[0];
                    tbxD1358.Text = split_comma[1];

                    tbxPlcSignal0900.Text = split_comma[2];
                    tbxPlcSignal0901.Text = split_comma[3];
                    tbxPlcData0900.Text = split_comma[4];
                    tbxPlcData0901.Text = split_comma[5];
                    break;
                case 10:
                    tbxD1400.Text = split_comma[0];
                    tbxD1402.Text = split_comma[1];

                    tbxPlcSignal1000.Text = split_comma[2];
                    tbxPlcSignal1001.Text = split_comma[3];
                    tbxPlcData1000.Text = split_comma[4];
                    tbxPlcData1001.Text = split_comma[5];
                    break;
                case 11:
                    tbxD1444.Text = split_comma[0];
                    tbxD1446.Text = split_comma[1];

                    tbxPlcSignal1100.Text = split_comma[2];
                    tbxPlcSignal1101.Text = split_comma[3];
                    tbxPlcData1100.Text = split_comma[4];
                    tbxPlcData1101.Text = split_comma[5];
                    break;
                case 12:
                    tbxD1488.Text = split_comma[0];
                    tbxD1490.Text = split_comma[1];

                    tbxPlcSignal1200.Text = split_comma[2];
                    tbxPlcSignal1201.Text = split_comma[3];
                    tbxPlcData1200.Text = split_comma[4];
                    tbxPlcData1201.Text = split_comma[5];
                    break;


            }
        }

        private void btnReadCh1()
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 22;
            int iDataProcMax = 16;
            int startAddress = 1004;
            int nextIndex = 0;
            int addCount = 0;

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            addrMapList = null;
            addrMapList = new string[addCount];
            startAddress = nextIndex;
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                strArry_int32_float[idx] = "FLOAT";
            }
            strRtn += ",";
            strRtn += plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리

            ChannelDataUpdate(1, strRtn);
            return;

        }



        private void btnReadCh2()
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 22;
            int iDataProcMax = 16;
            int startAddress = 1048;
            int nextIndex = 0;
            int addCount = 0;

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            addrMapList = null;
            addrMapList = new string[addCount];
            startAddress = nextIndex;
            strArry_int32_float = null;
            strArry_int32_float=new string[addCount];

            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                strArry_int32_float[idx] = "FLOAT";
            }
            strRtn += ",";
            strRtn += plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리

            ChannelDataUpdate(2, strRtn);
            return;
        }

        private void btnReadCh3()
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 22;
            int iDataProcMax = 16;
            int startAddress = 1092;
            int nextIndex = 0;
            int addCount = 0;

            if (iDataCountMax > iDataProcMax)
            {
                nextIndex = startAddress + iDataProcMax * 2;
                addCount = iDataCountMax - iDataProcMax;
            }

            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList,strArry_int32_float); //,로 분리
            addrMapList = null;
            addrMapList = new string[addCount];
            strArry_int32_float = null;
            strArry_int32_float=new string[addCount];
            startAddress = nextIndex;
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                strArry_int32_float[idx] = "FLOAT";
            }
            strRtn += ",";
            strRtn += plcComm1.ReadDwordEachRun(addrMapList,strArry_int32_float); //,로 분리
            ChannelDataUpdate(3, strRtn);
            return;
        }

        private void btnReadCh4()
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1136;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            ChannelDataUpdate(4, strRtn);
            return;
        }

        private void btnReadCh5()
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1180;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            ChannelDataUpdate(5, strRtn);

            return;
        }
        private void btnReadCh6()
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1224;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리

            ChannelDataUpdate(6, strRtn);
            return;
        }
        private void btnReadCh7()
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1268;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리

            ChannelDataUpdate(7, strRtn);
            return;

        }

        private void btnReadCh8()
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1312;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            ChannelDataUpdate(8, strRtn);
            return;

        }

        private void btnReadCh9()
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1356;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            ChannelDataUpdate(9, strRtn);
            return;
        }

        private void btnReadCh10()
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1400;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            ChannelDataUpdate(10, strRtn);
            return;
        }

        private void btnReadCh11()
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1444;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            ChannelDataUpdate(11, strRtn);
            return;
        }

        private void btnReadCh12()
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 6;
            int iDataProcMax = 16;
            int startAddress = 1488;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                if (idx == 1) { strArry_int32_float[idx] = "INT32"; }
                else { strArry_int32_float[idx] = "FLOAT"; }
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리
            ChannelDataUpdate(12, strRtn);
            return;

        }

        private void btnReadAI1_12()
        {
            //-------------------------
            //개별 읽기 DWORD
            int iDataCountMax = 12;
            int iDataProcMax = 16;
            int startAddress = 700;

            if (iDataCountMax > iDataProcMax) { }
            else { iDataProcMax = iDataCountMax; }


            string[] addrMapList = new string[iDataProcMax];
            string[] strArry_int32_float = new string[iDataProcMax];
            for (int i = startAddress, idx = 0; idx < addrMapList.Length; i = i + 2, idx++)
            {
                int iMapNoIndex = XGT.AddressCalcDword2Word(i);
                string sAddrLoc = "D" + String.Format("{0:D4}", iMapNoIndex);
                addrMapList[idx] = sAddrLoc;
                strArry_int32_float[idx] = "INT32";
            }

            string strRtn = plcComm1.ReadDwordEachRun(addrMapList, strArry_int32_float); //,로 분리

            return;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        internal void SetUnitAI01(string v)
        {
            tbxUnitAI01.Text = v;
        }

        internal void SetUnitAI02(string v)
        {
            tbxUnitAI02.Text = v;
        }

        internal void SetUnitAI03(string v)
        {
            tbxUnitAI03.Text = v;
        }

        internal void SetUnitAI04(string v)
        {
            tbxUnitAI04.Text = v;
        }

        internal void SetUnitAI05(string v)
        {
            tbxUnitAI05.Text = v;
        }

        internal void SetUnitAI06(string v)
        {
            tbxUnitAI06.Text = v;
        }

        internal void SetUnitAI07(string v)
        {
            tbxUnitAI07.Text = v;
        }

        internal void SetUnitAI08(string v)
        {
            tbxUnitAI08.Text = v;
        }

        internal void SetUnitAI09(string v)
        {
            tbxUnitAI09.Text = v;
        }

        internal void SetUnitAI10(string v)
        {
            tbxUnitAI10.Text = v;
        }

        internal void SetUnitAI11(string v)
        {
            tbxUnitAI11.Text = v;
        }

        internal void SetUnitAI12(string v)
        {
            tbxUnitAI12.Text = v;
        }

        private void btnReadAllChannel_Click(object sender, EventArgs e)
        {
            PlcSensorDataRead();
        }
    }
}

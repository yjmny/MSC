using DashBoard;
using DBMS_V1;
using DoAnalysisMSC.Pages;
using DwLib.Data.Generic;
using EventLog;
using log4net;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Threading;
using LoginLib;
namespace DoAnalysisMSC
{
    public partial class MainWindow : Form
    {

        // 디자인 영역====================================================================================================================
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbMin = new System.Windows.Forms.Button();
            this.pbMax = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxLiveTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnTestResultD = new System.Windows.Forms.Button();
            this.btnAlarmResult = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatuDB = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.tbxMemberlevel = new System.Windows.Forms.Label();
            this.tbxMemberId = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.pnTitle.Controls.Add(this.lblTitle);
            this.pnTitle.Controls.Add(this.pbMin);
            this.pnTitle.Controls.Add(this.pbMax);
            this.pnTitle.Controls.Add(this.pbClose);
            this.pnTitle.Controls.Add(this.pbLogo);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1920, 35);
            this.pnTitle.TabIndex = 0;
            this.pnTitle.DoubleClick += new System.EventHandler(this.PnTitle_DoubleClick);
            this.pnTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnTitle_MouseDown);
            this.pnTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnTitle_MouseMove);
            this.pnTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnTitle_MouseUp);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(39, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 15);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "MainWindow Label";
            // 
            // pbMin
            // 
            this.pbMin.BackColor = System.Drawing.Color.White;
            this.pbMin.BackgroundImage = global::DoAnalysisMSC.Properties.Resources.win_min1;
            this.pbMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMin.Location = new System.Drawing.Point(1815, 4);
            this.pbMin.Name = "pbMin";
            this.pbMin.Size = new System.Drawing.Size(27, 27);
            this.pbMin.TabIndex = 3;
            this.pbMin.TabStop = false;
            this.pbMin.UseVisualStyleBackColor = false;
            this.pbMin.Click += new System.EventHandler(this.PbMin_Click);
            this.pbMin.MouseLeave += new System.EventHandler(this.PbMin_MouseLeave);
            this.pbMin.MouseHover += new System.EventHandler(this.PbMin_MouseHover);
            // 
            // pbMax
            // 
            this.pbMax.BackColor = System.Drawing.Color.White;
            this.pbMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMax.BackgroundImage")));
            this.pbMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMax.Location = new System.Drawing.Point(1848, 4);
            this.pbMax.Name = "pbMax";
            this.pbMax.Size = new System.Drawing.Size(27, 27);
            this.pbMax.TabIndex = 2;
            this.pbMax.TabStop = false;
            this.pbMax.UseVisualStyleBackColor = false;
            this.pbMax.Click += new System.EventHandler(this.PbMax_Click);
            this.pbMax.MouseLeave += new System.EventHandler(this.PbMax_MouseLeave);
            this.pbMax.MouseHover += new System.EventHandler(this.PbMax_MouseHover);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.White;
            this.pbClose.BackgroundImage = global::DoAnalysisMSC.Properties.Resources.win_close3;
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbClose.Location = new System.Drawing.Point(1881, 4);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(27, 27);
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.UseVisualStyleBackColor = false;
            this.pbClose.Click += new System.EventHandler(this.PbClose_Click);
            this.pbClose.MouseLeave += new System.EventHandler(this.PbClose_MouseLeave);
            this.pbClose.MouseHover += new System.EventHandler(this.PbClose_MouseHover);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::DoAnalysisMSC.Properties.Resources.icon_status1;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(31, 31);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(1920, 1005);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxLiveTime, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDashboard, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnTestResultD, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnAlarmResult, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 1005);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DoAnalysisMSC.Properties.Resources.logo2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 64);
            this.panel1.TabIndex = 20;
            // 
            // tbxLiveTime
            // 
            this.tbxLiveTime.AutoSize = true;
            this.tbxLiveTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLiveTime.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLiveTime.ForeColor = System.Drawing.Color.White;
            this.tbxLiveTime.Location = new System.Drawing.Point(3, 70);
            this.tbxLiveTime.Name = "tbxLiveTime";
            this.tbxLiveTime.Size = new System.Drawing.Size(254, 55);
            this.tbxLiveTime.TabIndex = 20;
            this.tbxLiveTime.Text = "label2";
            this.tbxLiveTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "메인";
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::DoAnalysisMSC.Properties.Resources.icon_m2_30;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 163);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(251, 49);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "            M1 대시보드";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click_1);
            // 
            // btnTestResultD
            // 
            this.btnTestResultD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnTestResultD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnTestResultD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestResultD.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestResultD.ForeColor = System.Drawing.Color.White;
            this.btnTestResultD.Image = global::DoAnalysisMSC.Properties.Resources.icon_H2_30;
            this.btnTestResultD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestResultD.Location = new System.Drawing.Point(3, 218);
            this.btnTestResultD.Name = "btnTestResultD";
            this.btnTestResultD.Size = new System.Drawing.Size(251, 49);
            this.btnTestResultD.TabIndex = 18;
            this.btnTestResultD.Text = "            M2 측정 이력 조회";
            this.btnTestResultD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTestResultD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTestResultD.UseVisualStyleBackColor = false;
            this.btnTestResultD.Click += new System.EventHandler(this.BtnTestResultD_Click);
            // 
            // btnAlarmResult
            // 
            this.btnAlarmResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnAlarmResult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnAlarmResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlarmResult.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmResult.ForeColor = System.Drawing.Color.White;
            this.btnAlarmResult.Image = global::DoAnalysisMSC.Properties.Resources.icon_A1_30;
            this.btnAlarmResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlarmResult.Location = new System.Drawing.Point(3, 273);
            this.btnAlarmResult.Name = "btnAlarmResult";
            this.btnAlarmResult.Size = new System.Drawing.Size(251, 49);
            this.btnAlarmResult.TabIndex = 10;
            this.btnAlarmResult.Text = "            M3 알람 이력 조회";
            this.btnAlarmResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlarmResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlarmResult.UseVisualStyleBackColor = false;
            this.btnAlarmResult.Click += new System.EventHandler(this.BtnAlarmResult_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Location = new System.Drawing.Point(3, 328);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 674);
            this.panel4.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(-1, 597);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 74);
            this.panel2.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(2, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "F 063-214-8557";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::DoAnalysisMSC.Properties.Resources.logo2;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(129, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 46);
            this.panel3.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(2, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "T 063-214-8556";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(8, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "고객지원";
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label7);
            this.splitContainer3.Panel1.Controls.Add(this.lblStatuDB);
            this.splitContainer3.Panel1.Controls.Add(this.pictureBox3);
            this.splitContainer3.Panel1.Controls.Add(this.btnlogout);
            this.splitContainer3.Panel1.Controls.Add(this.tbxMemberlevel);
            this.splitContainer3.Panel1.Controls.Add(this.tbxMemberId);
            this.splitContainer3.Size = new System.Drawing.Size(1650, 1005);
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(20, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "DB연결:";
            // 
            // lblStatuDB
            // 
            this.lblStatuDB.AutoSize = true;
            this.lblStatuDB.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStatuDB.Location = new System.Drawing.Point(79, 16);
            this.lblStatuDB.Name = "lblStatuDB";
            this.lblStatuDB.Size = new System.Drawing.Size(51, 15);
            this.lblStatuDB.TabIndex = 14;
            this.lblStatuDB.Text = "label10";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DoAnalysisMSC.Properties.Resources.user_1;
            this.pictureBox3.Location = new System.Drawing.Point(1291, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // btnlogout
            // 
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnlogout.Image = global::DoAnalysisMSC.Properties.Resources.icon_logout_40;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(1507, 3);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(137, 44);
            this.btnlogout.TabIndex = 9;
            this.btnlogout.Text = "로그아웃";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogout.UseCompatibleTextRendering = true;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.Btnlogout_Click);
            // 
            // tbxMemberlevel
            // 
            this.tbxMemberlevel.AutoSize = true;
            this.tbxMemberlevel.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxMemberlevel.Location = new System.Drawing.Point(1433, 14);
            this.tbxMemberlevel.Name = "tbxMemberlevel";
            this.tbxMemberlevel.Size = new System.Drawing.Size(55, 19);
            this.tbxMemberlevel.TabIndex = 8;
            this.tbxMemberlevel.Text = "label6";
            this.tbxMemberlevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxMemberId
            // 
            this.tbxMemberId.AutoSize = true;
            this.tbxMemberId.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxMemberId.Location = new System.Drawing.Point(1363, 14);
            this.tbxMemberId.Name = "tbxMemberId";
            this.tbxMemberId.Size = new System.Drawing.Size(55, 19);
            this.tbxMemberId.TabIndex = 7;
            this.tbxMemberId.Text = "label2";
            this.tbxMemberId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(39, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 51);
            this.button2.TabIndex = 26;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1040);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(1918, 1030);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing_1);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button pbMin;
        private System.Windows.Forms.Button pbMax;
        private System.Windows.Forms.Button pbClose;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Label tbxMemberlevel;
        private System.Windows.Forms.Label tbxMemberId;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tbxLiveTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnTestResultD;
        private System.Windows.Forms.Button btnAlarmResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStatuDB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        //================================================================================================================================


        public MainWindow(string mbid)
        {
            InitializeComponent();
            this.Hide();

            CallLoginWindow(ref mbid);


            MessageBox.Show("hello");

            this.button2.BackColor = Color.Aquamarine;

        }

        private readonly AnalyzeWriteLog cAwlog = new AnalyzeWriteLog();
        private readonly LoginWriteLog cLoginlog = new LoginWriteLog();
        private static readonly ILog cLog = LogManager.GetLogger("Analysis");
        public static MainWindow mIns;
        readonly MySqlDTO cMysqlDto = new MySqlDTO();

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);

        }
        private bool CallLoginWindow(ref string mbid)
        {
            LoginLib.FrmLogin login1 = new LoginLib.FrmLogin(CommonClass.an_programId, mbid);
            login1.ShowDialog();

            if (Analysis.loginSuccess == false)
            {
                return false;
            }
            else
            {
                LoginAfterLoad(Analysis.mbno, Analysis.mbid);
                cLog.Info(cLoginlog.LoginOk);
                cLog.Info(cAwlog.AnalysisProgramStartEventLog);
                return true;
            }
        }

        private void LoginAfterLoad(string mbno, string mbid)
        {
            mIns = this;

            string sql = $"SELECT divlevel FROM tbl_member WHERE tbl_member.id =\"{mbid}\" ";

            Dictionary<string, string> row = cMysqlDto.SelectSql2(sql, "divlevel")[0];
            if (row != null)
            {
                Analysis.divlevel = Int32.Parse(row["divlevel"]);
            }
            cMysqlDto.Close();
            Analysis.mbno = mbno.ToString();

            ShowCurTime();
          

            if (Analysis.divlevel == 0)
            {
                tbxMemberId.Text = "[ 사용자 ]" + "  " + mbid;
                tbxMemberlevel.Visible = false;
            }
            else
            {
                tbxMemberId.Text = "[ 관리자 ]" + "  " + mbid;
                tbxMemberlevel.Visible = false;
            }
            //-------메인 윈도우 설정
            Analysis.mbid = mbid;
            this.Text = CommonClass.program_title.ToString();
            this.lblTitle.Text = this.Text;
            //---기타 설정
            IntializeCustomizingLoadingWindow();
            EventButtonSettings();

            //-- 메인윈도우 뷰

            DashboardPage dashboard = new DashboardPage();
            SelectPage(dashboard);
            this.Show();
        }

        private void EventButtonSettings()
        {
            string strOk = "GOOD";
            string strFail = "NG";

            if (CommonClass.IsDeviceCheckOn == true)
            {
                lblStatuDB.Text = CommonClass.IsDBCtrlConn10 ? strOk : strFail;

            }
            else
            {
                lblStatuDB.Text = CommonClass.IsDBCtrlConn10 ? strOk : strFail;
            }

            //Color set
            LabelColorSettings(ref lblStatuDB);

        }

        private void LabelColorSettings(ref System.Windows.Forms.Label label)
        {
            string strOk = "GOOD";
            //string strFail = "NG";
            if (label.Text.ToUpper().Trim().Equals(strOk))
            {
                label.ForeColor = ColorTranslator.FromHtml("#FF39C445");
            }
            else
            {
                label.ForeColor = ColorTranslator.FromHtml("#FFE85454");
            }
            label.Refresh();
        }

        private void IntializeCustomizingLoadingWindow()
        {

        }

        private void ShowCurTime()
        {
            DispatcherTimer LiveTime = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(1),
            };
            LiveTime.Tick += Timer_Tick;
            LiveTime.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            tbxLiveTime.Text = DateTime.Now.ToString("yyyy-MM-dd  HH:mm");
        }
        private void SelectPage(Form page)
        {
            if (ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != page)
                {
                    this.ActiveMdiChild.Close();

                }
                page.MdiParent = this;
                page.TopLevel = false;
                page.Visible = true;
                page.Dock = DockStyle.Top;
                page.FormBorderStyle = FormBorderStyle.None;
                this.splitContainer3.Panel2.Controls.Add(page);

            }
            else
            {
                page.MdiParent = this;
                page.TopLevel = false;
                page.Visible = true;
                page.Dock = DockStyle.Top;
                page.FormBorderStyle = FormBorderStyle.None;
                this.splitContainer3.Panel2.Controls.Add(page);
            }
        }


        private void BtnDashboard_Click_1(object sender, EventArgs e)
        {
            cLog.Info(cAwlog.DashBoardMenuClickEventLog);
            DashboardPage dashboard = new DashboardPage();
            SelectPage(dashboard);
        }
        private void BtnTestResultD_Click(object sender, EventArgs e)
        {
            cLog.Info(cAwlog.TestListManageClickEventLog);
            TestResult_Detail testresultdetail = new TestResult_Detail();
            SelectPage(testresultdetail);
        }
        private void BtnAlarmResult_Click(object sender, EventArgs e)
        {
            cLog.Info(cAwlog.AlarmListManageClickEventLog);
            AlarmResult_Simple alarmresult = new AlarmResult_Simple();
            SelectPage(alarmresult);
        }

        private void MainWindow_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (Analysis.program_exit == false)
            {
                e.Cancel = true;
                this.Hide();

                try
                {
                    LoginLib.FrmLogin clogin = new LoginLib.FrmLogin();
                    clogin.LogoutUpdateDB(mbid: Analysis.mbid, logouttime: "20" + tbxLiveTime.Text, exeLocation: "analysis", programId: 2);
                    clogin = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Analysis.mbid = "";
                CallLoginWindow(ref Analysis.mbid);

            }
        }

        //=============================상단바
        private void MainWindow_Resize(object sender, EventArgs e)
        {
        }

        private void PbMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Minimized;
        }

        private void PbMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            Btnlogout_Click(sender, e);
        }

        bool isFormMove;
        System.Drawing.Point fPt;
        private void PnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            isFormMove = true;
            fPt = new System.Drawing.Point(e.X, e.Y);
        }

        private void PnTitle_MouseUp(object sender, MouseEventArgs e)
        {
            isFormMove = true;
        }

        private void PnTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isFormMove && (e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Left - (fPt.X - e.X), this.Top - (fPt.Y - e.Y));
            }
        }

        private void PnTitle_DoubleClick(object sender, EventArgs e)
        {
            PbMax_Click(null, null);
        }

        private void PbMin_MouseHover(object sender, EventArgs e)
        {
            pbMin.BackColor = System.Drawing.Color.Silver;
        }

        private void PbMin_MouseLeave(object sender, EventArgs e)
        {
            pbMin.BackColor = System.Drawing.Color.White;
        }

        private void PbMax_MouseHover(object sender, EventArgs e)
        {
            pbMax.BackColor = System.Drawing.Color.Silver;
        }

        private void PbMax_MouseLeave(object sender, EventArgs e)
        {
            pbMax.BackColor = System.Drawing.Color.White;
        }

        private void PbClose_MouseHover(object sender, EventArgs e)
        {
            pbClose.BackColor = System.Drawing.Color.Silver;
        }

        private void PbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackColor = System.Drawing.Color.White;
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {
                cLog.Info(cLoginlog.LogoutOk);
                Analysis.isExit = true;
                this.Close();
            }
        }
    }
}

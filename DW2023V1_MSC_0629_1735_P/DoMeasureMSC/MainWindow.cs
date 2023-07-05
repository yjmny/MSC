using DoMeasureMSC.Pages;
using DashBoard;
using DBMS_V1;
using EventLog;
using DwLib.Data.Generic;
using DWLib.Data.Generic;
using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Threading;
using MessageBox = System.Windows.MessageBox;

namespace DoMeasureMSC
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxLiveTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblStatusPlc1 = new System.Windows.Forms.Label();
            this.lblStatuDB = new System.Windows.Forms.Label();
            this.lblStatusPlc = new System.Windows.Forms.Label();
            this.lblStatusChamber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMemberId = new System.Windows.Forms.Label();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbMin = new System.Windows.Forms.Button();
            this.pbMax = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPatternManage = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnRecipe = new System.Windows.Forms.Button();
            this.btnRequester = new System.Windows.Forms.Button();
            this.btnRequesterSample = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnDbmsCtrl = new System.Windows.Forms.Button();
            this.btnPlcCtrl = new System.Windows.Forms.Button();
            this.btnHMICtrl = new System.Windows.Forms.Button();
            this.btnCaliManage = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPatternManage, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.btnUser, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMeasure, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDashBoard, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnRecipe, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnRequester, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnRequesterSample, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbxLiveTime, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAnalysis, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.btnDbmsCtrl, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.btnPlcCtrl, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.btnHMICtrl, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.btnCaliManage, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 18);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 19;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 1005);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "기본 정보 관리";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "측정 정보 관리";
            // 
            // tbxLiveTime
            // 
            this.tbxLiveTime.AutoSize = true;
            this.tbxLiveTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLiveTime.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxLiveTime.ForeColor = System.Drawing.Color.White;
            this.tbxLiveTime.Location = new System.Drawing.Point(3, 70);
            this.tbxLiveTime.Name = "tbxLiveTime";
            this.tbxLiveTime.Size = new System.Drawing.Size(254, 55);
            this.tbxLiveTime.TabIndex = 20;
            this.tbxLiveTime.Text = "label2";
            this.tbxLiveTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 670);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "기타관리";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 928);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 74);
            this.panel2.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "F 063-214-8557";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "T 063-214-8556";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "고객지원";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1MinSize = 260;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2MinSize = 1640;
            this.splitContainer1.Size = new System.Drawing.Size(1920, 1005);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel1.Controls.Add(this.lblStatusPlc1);
            this.splitContainer2.Panel1.Controls.Add(this.lblStatuDB);
            this.splitContainer2.Panel1.Controls.Add(this.lblStatusPlc);
            this.splitContainer2.Panel1.Controls.Add(this.lblStatusChamber);
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.label6);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer2.Panel1.Controls.Add(this.btnlogout);
            this.splitContainer2.Panel1.Controls.Add(this.tbxMemberId);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Panel2MinSize = 950;
            this.splitContainer2.Size = new System.Drawing.Size(1650, 1005);
            this.splitContainer2.SplitterDistance = 51;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblStatusPlc1
            // 
            this.lblStatusPlc1.AutoSize = true;
            this.lblStatusPlc1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStatusPlc1.Location = new System.Drawing.Point(268, 14);
            this.lblStatusPlc1.Name = "lblStatusPlc1";
            this.lblStatusPlc1.Size = new System.Drawing.Size(43, 15);
            this.lblStatusPlc1.TabIndex = 13;
            this.lblStatusPlc1.Text = "label8";
            // 
            // lblStatuDB
            // 
            this.lblStatuDB.AutoSize = true;
            this.lblStatuDB.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStatuDB.Location = new System.Drawing.Point(435, 14);
            this.lblStatuDB.Name = "lblStatuDB";
            this.lblStatuDB.Size = new System.Drawing.Size(51, 15);
            this.lblStatuDB.TabIndex = 12;
            this.lblStatuDB.Text = "label10";
            // 
            // lblStatusPlc
            // 
            this.lblStatusPlc.AutoSize = true;
            this.lblStatusPlc.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStatusPlc.Location = new System.Drawing.Point(268, 14);
            this.lblStatusPlc.Name = "lblStatusPlc";
            this.lblStatusPlc.Size = new System.Drawing.Size(0, 15);
            this.lblStatusPlc.TabIndex = 11;
            // 
            // lblStatusChamber
            // 
            this.lblStatusChamber.AutoSize = true;
            this.lblStatusChamber.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblStatusChamber.Location = new System.Drawing.Point(94, 14);
            this.lblStatusChamber.Name = "lblStatusChamber";
            this.lblStatusChamber.Size = new System.Drawing.Size(43, 15);
            this.lblStatusChamber.TabIndex = 10;
            this.lblStatusChamber.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(378, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "DB연결:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(207, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "PLC연결:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(25, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "챔버연결:";
            // 
            // tbxMemberId
            // 
            this.tbxMemberId.AutoSize = true;
            this.tbxMemberId.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxMemberId.Location = new System.Drawing.Point(1279, 16);
            this.tbxMemberId.Name = "tbxMemberId";
            this.tbxMemberId.Size = new System.Drawing.Size(55, 19);
            this.tbxMemberId.TabIndex = 2;
            this.tbxMemberId.Text = "label2";
            this.tbxMemberId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblTitle.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(39, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(115, 14);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "MainWindow Label";
            // 
            // pbMin
            // 
            this.pbMin.BackColor = System.Drawing.Color.White;
            this.pbMin.BackgroundImage = global::DoMeasureMSC.Properties.Resources.win_min;
            this.pbMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMin.Location = new System.Drawing.Point(1815, 4);
            this.pbMin.Name = "pbMin";
            this.pbMin.Size = new System.Drawing.Size(27, 27);
            this.pbMin.TabIndex = 3;
            this.pbMin.TabStop = false;
            this.pbMin.UseVisualStyleBackColor = false;
            this.pbMin.Click += new System.EventHandler(this.PbMin_Click);
            this.pbMin.Paint += new System.Windows.Forms.PaintEventHandler(this.PbMin_Paint);
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
            this.pbMax.Paint += new System.Windows.Forms.PaintEventHandler(this.PbMax_Paint);
            this.pbMax.MouseLeave += new System.EventHandler(this.PbMax_MouseLeave);
            this.pbMax.MouseHover += new System.EventHandler(this.PbMax_MouseHover);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.White;
            this.pbClose.BackgroundImage = global::DoMeasureMSC.Properties.Resources.win_close3;
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbClose.Location = new System.Drawing.Point(1881, 4);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(27, 27);
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.UseVisualStyleBackColor = false;
            this.pbClose.Click += new System.EventHandler(this.PbClose_Click);
            this.pbClose.Paint += new System.Windows.Forms.PaintEventHandler(this.PbClose_Paint);
            this.pbClose.MouseLeave += new System.EventHandler(this.PbClose_MouseLeave);
            this.pbClose.MouseHover += new System.EventHandler(this.PbClose_MouseHover);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.BackgroundImage = global::DoMeasureMSC.Properties.Resources.icon_status;
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLogo.Location = new System.Drawing.Point(2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(31, 31);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::DoMeasureMSC.Properties.Resources.logo2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 64);
            this.panel1.TabIndex = 20;
            // 
            // btnPatternManage
            // 
            this.btnPatternManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnPatternManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnPatternManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatternManage.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatternManage.ForeColor = System.Drawing.Color.White;
            this.btnPatternManage.Image = global::DoMeasureMSC.Properties.Resources.icon_b2_301;
            this.btnPatternManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatternManage.Location = new System.Drawing.Point(3, 563);
            this.btnPatternManage.Name = "btnPatternManage";
            this.btnPatternManage.Size = new System.Drawing.Size(254, 49);
            this.btnPatternManage.TabIndex = 21;
            this.btnPatternManage.Text = "            B2  패턴 관리";
            this.btnPatternManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatternManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatternManage.UseVisualStyleBackColor = false;
            this.btnPatternManage.Click += new System.EventHandler(this.BtnPatternManage_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::DoMeasureMSC.Properties.Resources.icon_B1_30;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(3, 508);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(254, 49);
            this.btnUser.TabIndex = 11;
            this.btnUser.Text = "            B1 사용자 관리";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // btnMeasure
            // 
            this.btnMeasure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnMeasure.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeasure.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeasure.ForeColor = System.Drawing.Color.White;
            this.btnMeasure.Image = global::DoMeasureMSC.Properties.Resources.icon_m1_30;
            this.btnMeasure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeasure.Location = new System.Drawing.Point(3, 163);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(254, 49);
            this.btnMeasure.TabIndex = 4;
            this.btnMeasure.Text = "            M1  시험측정";
            this.btnMeasure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMeasure.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMeasure.UseVisualStyleBackColor = false;
            this.btnMeasure.Click += new System.EventHandler(this.BtnMeasure_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnDashBoard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.White;
            this.btnDashBoard.Image = global::DoMeasureMSC.Properties.Resources.icon_m2_30;
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(3, 218);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(254, 49);
            this.btnDashBoard.TabIndex = 5;
            this.btnDashBoard.Text = "            M2 대시보드";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.BtnDashBoard_Click);
            // 
            // btnRecipe
            // 
            this.btnRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnRecipe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecipe.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecipe.ForeColor = System.Drawing.Color.White;
            this.btnRecipe.Image = global::DoMeasureMSC.Properties.Resources.icon_R3_30;
            this.btnRecipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecipe.Location = new System.Drawing.Point(3, 418);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Size = new System.Drawing.Size(254, 49);
            this.btnRecipe.TabIndex = 10;
            this.btnRecipe.Text = "            R3 레시피 관리";
            this.btnRecipe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecipe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecipe.UseVisualStyleBackColor = false;
            this.btnRecipe.Click += new System.EventHandler(this.BtnRecipe_Click);
            // 
            // btnRequester
            // 
            this.btnRequester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnRequester.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnRequester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequester.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequester.ForeColor = System.Drawing.Color.White;
            this.btnRequester.Image = global::DoMeasureMSC.Properties.Resources.icon_R1_30;
            this.btnRequester.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequester.Location = new System.Drawing.Point(3, 308);
            this.btnRequester.Name = "btnRequester";
            this.btnRequester.Size = new System.Drawing.Size(254, 49);
            this.btnRequester.TabIndex = 17;
            this.btnRequester.Text = "            R1 의뢰자 관리";
            this.btnRequester.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequester.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRequester.UseVisualStyleBackColor = false;
            this.btnRequester.Click += new System.EventHandler(this.BtnRequester_Click);
            // 
            // btnRequesterSample
            // 
            this.btnRequesterSample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnRequesterSample.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnRequesterSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequesterSample.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequesterSample.ForeColor = System.Drawing.Color.White;
            this.btnRequesterSample.Image = global::DoMeasureMSC.Properties.Resources.icon_R2_30;
            this.btnRequesterSample.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequesterSample.Location = new System.Drawing.Point(3, 363);
            this.btnRequesterSample.Name = "btnRequesterSample";
            this.btnRequesterSample.Size = new System.Drawing.Size(254, 49);
            this.btnRequesterSample.TabIndex = 18;
            this.btnRequesterSample.Text = "            R2 의뢰자샘플 관리";
            this.btnRequesterSample.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRequesterSample.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRequesterSample.UseVisualStyleBackColor = false;
            this.btnRequesterSample.Click += new System.EventHandler(this.BtnRequesterSample_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnAnalysis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalysis.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnAnalysis.Image = global::DoMeasureMSC.Properties.Resources.icon_D5_30;
            this.btnAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalysis.Location = new System.Drawing.Point(3, 873);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(254, 49);
            this.btnAnalysis.TabIndex = 16;
            this.btnAnalysis.Text = "            D4 분석 프로그램";
            this.btnAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnalysis.UseVisualStyleBackColor = false;
            this.btnAnalysis.Click += new System.EventHandler(this.BtnAnalysis_Click);
            // 
            // btnDbmsCtrl
            // 
            this.btnDbmsCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnDbmsCtrl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnDbmsCtrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbmsCtrl.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDbmsCtrl.ForeColor = System.Drawing.Color.White;
            this.btnDbmsCtrl.Image = global::DoMeasureMSC.Properties.Resources.icon_D4_30;
            this.btnDbmsCtrl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDbmsCtrl.Location = new System.Drawing.Point(3, 818);
            this.btnDbmsCtrl.Name = "btnDbmsCtrl";
            this.btnDbmsCtrl.Size = new System.Drawing.Size(254, 49);
            this.btnDbmsCtrl.TabIndex = 15;
            this.btnDbmsCtrl.Text = "            D3 DBMS 관리";
            this.btnDbmsCtrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDbmsCtrl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDbmsCtrl.UseVisualStyleBackColor = false;
            this.btnDbmsCtrl.Click += new System.EventHandler(this.BtnDBMS_Click);
            // 
            // btnPlcCtrl
            // 
            this.btnPlcCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnPlcCtrl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnPlcCtrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlcCtrl.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlcCtrl.ForeColor = System.Drawing.Color.White;
            this.btnPlcCtrl.Image = global::DoMeasureMSC.Properties.Resources.plc;
            this.btnPlcCtrl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlcCtrl.Location = new System.Drawing.Point(3, 763);
            this.btnPlcCtrl.Name = "btnPlcCtrl";
            this.btnPlcCtrl.Size = new System.Drawing.Size(254, 49);
            this.btnPlcCtrl.TabIndex = 22;
            this.btnPlcCtrl.Text = "            D2 PLC 컨트롤러 관리";
            this.btnPlcCtrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlcCtrl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlcCtrl.UseVisualStyleBackColor = false;
            this.btnPlcCtrl.Click += new System.EventHandler(this.BtnPLCManage_Click);
            // 
            // btnHMICtrl
            // 
            this.btnHMICtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnHMICtrl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnHMICtrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHMICtrl.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHMICtrl.ForeColor = System.Drawing.Color.White;
            this.btnHMICtrl.Image = global::DoMeasureMSC.Properties.Resources.icon_D2_30;
            this.btnHMICtrl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHMICtrl.Location = new System.Drawing.Point(3, 708);
            this.btnHMICtrl.Name = "btnHMICtrl";
            this.btnHMICtrl.Size = new System.Drawing.Size(254, 49);
            this.btnHMICtrl.TabIndex = 14;
            this.btnHMICtrl.Text = "            D1 HMI 컨트롤러 관리";
            this.btnHMICtrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHMICtrl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHMICtrl.UseVisualStyleBackColor = false;
            this.btnHMICtrl.Click += new System.EventHandler(this.BtnHMICtrl_Click);
            // 
            // btnCaliManage
            // 
            this.btnCaliManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnCaliManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnCaliManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaliManage.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaliManage.ForeColor = System.Drawing.Color.White;
            this.btnCaliManage.Image = global::DoMeasureMSC.Properties.Resources.icon_b3_30;
            this.btnCaliManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaliManage.Location = new System.Drawing.Point(3, 618);
            this.btnCaliManage.Name = "btnCaliManage";
            this.btnCaliManage.Size = new System.Drawing.Size(254, 49);
            this.btnCaliManage.TabIndex = 23;
            this.btnCaliManage.Text = "            B3  캘리브레이션 관리";
            this.btnCaliManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaliManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaliManage.UseVisualStyleBackColor = false;
            this.btnCaliManage.Click += new System.EventHandler(this.BtnCaliManage_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::DoMeasureMSC.Properties.Resources.logowhite;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(129, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 46);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DoMeasureMSC.Properties.Resources.user_1;
            this.pictureBox2.Location = new System.Drawing.Point(1207, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btnlogout
            // 
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnlogout.Image = global::DoMeasureMSC.Properties.Resources.icon_logout_40;
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(1508, 3);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(137, 44);
            this.btnlogout.TabIndex = 4;
            this.btnlogout.Text = "로그아웃";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlogout.UseCompatibleTextRendering = true;
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.Btnlogout_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1040);
            this.ControlBox = false;
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(1918, 1030);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMeasure;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRecipe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHMICtrl;
        private System.Windows.Forms.Button btnDbmsCtrl;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnRequester;
        private System.Windows.Forms.Button btnRequesterSample;

        private System.Windows.Forms.Label tbxLiveTime;
        private System.Windows.Forms.Button btnPatternManage;
        private System.Windows.Forms.Button btnPlcCtrl;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tbxMemberId;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button pbMin;
        private System.Windows.Forms.Button pbMax;
        private System.Windows.Forms.Button pbClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStatuDB;
        private System.Windows.Forms.Label lblStatusPlc;
        private System.Windows.Forms.Label lblStatusChamber;
        private System.Windows.Forms.Button btnCaliManage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStatusPlc1;
        //================================================================================================================================


        public MainWindow(string mbid)
        {
            InitializeComponent();

            this.Hide();
  
            CallLoginWindow(ref mbid);

        }

        private readonly MeasureWriteLog cMwLog = new MeasureWriteLog();
        private readonly LoginWriteLog cLwLog = new LoginWriteLog();
        private static readonly ILog cLog = LogManager.GetLogger("Measure");
        public static MainWindow mIns;
        readonly MySqlDTO cMysqlDto = new MySqlDTO();
        int m_iMblevel;


        [DllImport("DwmApi")] //System.Runtime.InteropServices
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);

        }

        private bool CallLoginWindow(ref string mbid)
        {
            LoginLib.FrmLogin cLogin = new LoginLib.FrmLogin(CommonClass.ms_programId, mbid);

            cLogin.ShowDialog();

            if (Measure.loginSuccess == false)
            {
                return false;
            }
            else
            {
                LoginAfterLoad(Measure.mbid);
                cLog.Info(cLwLog.LoginOk);
                cLog.Info(cMwLog.MeasureProgramStartEventLog);
                return true;
            }
        }

        private void LoginAfterLoad(string mbid)
        {
            mIns = this;
            string dbsql = $"SELECT divlevel FROM tbl_member WHERE tbl_member.id =\"{mbid}\" ";

            Dictionary<string, string> row = cMysqlDto.SelectSql2(dbsql, "divlevel")[0];
            if (row != null)
            {
                m_iMblevel = Int32.Parse(row["divlevel"]);
            }
            cMysqlDto.Close();
   
            ShowCurTime();


            if (m_iMblevel == 0)
            {
                btnUser.Enabled = false;
                btnPatternManage.Enabled = false;
                btnCaliManage.Enabled = false;
                btnPlcCtrl.Enabled = false;
                btnHMICtrl.Enabled = false;
                btnDbmsCtrl.Enabled = false;

                tbxMemberId.Text = " [ 사용자 ]" +"  "+ mbid;
                
            }
            else
            {
                btnUser.Enabled = true;
                btnPatternManage.Enabled = true;
                btnCaliManage.Enabled = true;
                btnPlcCtrl.Enabled = true;
                btnHMICtrl.Enabled = true;
                btnDbmsCtrl.Enabled = true;
                tbxMemberId.Text = "[ 관리자 ]" + "  " + mbid;
               
            }

            //-------메인 윈도우 설정
            Measure.mbid = mbid;
            this.Text = CommonClass.program_title.ToString();
            this.lblTitle.Text = this.Text;
            this.IsMdiContainer = true;
            this.DoubleBuffered = true;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(0, 0);
            this.Size = new System.Drawing.Size(1920, 1040);
            this.MaximumSize = new System.Drawing.Size(1920, 1040);
            this.MinimumSize = new System.Drawing.Size(1920, 1040);

            //---기타 설정
            InitializeHmi();            //HMI 컨트롤러
            IntializeCustomizingLoadingWindow();
            EventButtonSettings();

            this.WindowState = FormWindowState.Minimized;
            MeasureManagePage measureManage = new MeasureManagePage();
            SelectPage(measureManage);
            this.WindowState = FormWindowState.Normal;
            //-- 메인윈도우 뷰
            this.Show();

        }

        private void EventButtonSettings()
        {
            string strOk = "GOOD";
            string strFail = "NG";

            if (CommonClass.IsDeviceCheckOn == true)
            {

                if (Measure.IsRecUse && Measure.IsHmiUse)
                {
                    lblStatusChamber.Text = CommonClass.IsHmiCtrlConn10 && CommonClass.IsRecoCtrlConn10 ? strOk : strFail;
                }
                else
                {
                    lblStatusChamber.Text = CommonClass.IsHmiCtrlConn10 ? strOk : strFail;
                }
                lblStatuDB.Text = CommonClass.IsDBCtrlConn10 ? strOk : strFail;
                if (Measure.IsPlcUse)
                {
                    lblStatusPlc1.Text = CommonClass.IsPlcCtrlConn10 ? strOk : strFail;
                }
                else
                {
                    lblStatusPlc1.Text = CommonClass.IsPlcCtrlConn10 ? strOk : strFail;
                }

            }
            else
            {
                if (Measure.IsRecUse && Measure.IsHmiUse)
                {
                    lblStatusChamber.Text = CommonClass.IsHmiCtrlConn10 && CommonClass.IsRecoCtrlConn10 ? strOk : strFail;
                }
                else
                {
                    lblStatusChamber.Text = CommonClass.IsHmiCtrlConn10 ? strOk : strFail;
                }
                lblStatuDB.Text = CommonClass.IsDBCtrlConn10 ? strOk : strFail;
                if (Measure.IsPlcUse)
                {
                    lblStatusPlc1.Text = CommonClass.IsPlcCtrlConn10 ? strOk : strFail;
                }
                else
                {
                    lblStatusPlc1.Text = CommonClass.IsPlcCtrlConn10 ? strOk : strFail;
                }
            }

            //Color set
            LabelColorSettings(ref lblStatuDB);
            LabelColorSettings(ref lblStatusChamber);
            LabelColorSettings(ref lblStatusPlc1);
        }

        private void LabelColorSettings(ref System.Windows.Forms.Label label)
        {
            string strOk = "GOOD";

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

        private void InitializeHmi()
        {

        }

        private void ShowCurTime()
        {
            var LiveTime = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(1)
            };

            LiveTime.Tick += Timer_Tick;
            LiveTime.Start();
        }

        private void ShowCurTime1()
        {
            var LiveTime = new DispatcherTimer()
            {
                Interval = TimeSpan.FromSeconds(1)
            };

            LiveTime.Tick += Timer_Tick;
            LiveTime.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tbxLiveTime.Text = DateTime.Now.ToString("yyyy-MM-dd  HH:mm");
            //tbxLiveTime.Text = DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss");

        }
        private void SelectPage(Form page)
        {
            this.splitContainer2.Panel2.Controls.Clear();
            page.MdiParent = this;
            page.TopLevel = false;
            page.Visible = true;
            page.Dock = DockStyle.Fill;
            page.FormBorderStyle = FormBorderStyle.None;
            page.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Panel2.Controls.Add(page);
        }


        private void BtnMeasure_Click(object sender, EventArgs e)
        {
            cLog.Info(cMwLog.MeasureManageMenuClickEventLog);
            if (!(this.splitContainer2.Panel2.Controls.Equals(MeasureManagePage.mIns)))
            {
                if (MeasureManagePage.mIns == null)
                {
                    MeasureManagePage measuremanage = new MeasureManagePage();
                    SelectPage(measuremanage);
                }
                else
                {
                    SelectPage(MeasureManagePage.mIns);

                }
            }

        }

        private void BtnDashBoard_Click(object sender, EventArgs e)
        {
            cLog.Info(cMwLog.DashBoardMenuClickEventLog);
            DashboardPage dashboard = new DashboardPage();

            SelectPage(dashboard);
        }

        private void BtnRequester_Click(object sender, EventArgs e)
        {
            cLog.Info(cMwLog.RequesterManageMenuClickEventLog);
            RequesterManagePage requestermanage = new RequesterManagePage();
            SelectPage(requestermanage);
        }

        private void BtnRequesterSample_Click(object sender, EventArgs e)
        {
            cLog.Info(cMwLog.RequesterSampleManageMenuClickEventLog);
            RequesterSampleManagePage requestersamplemanage = new RequesterSampleManagePage();

            SelectPage(requestersamplemanage);
        }

        private void BtnRecipe_Click(object sender, EventArgs e)
        {
            cLog.Info(cMwLog.RecipeManageMenuClickEventLog);
            RecipeManagePage recipemanage = new RecipeManagePage();

            SelectPage(recipemanage);
        }
        private void BtnUser_Click(object sender, EventArgs e)
        {
            cLog.Info(cMwLog.UserManageMenuClickEventLog);
            UserManagePage usermanage = new UserManagePage();

            SelectPage(usermanage);
        }

        private void BtnPatternManage_Click(object sender, EventArgs e)
        {
            cLog.Info(cMwLog.PatternMenuClickEventLog);
            PatternManagePage pattern = new PatternManagePage();

            SelectPage(pattern);
        }
        private void BtnCaliManage_Click(object sender, EventArgs e)
        {
            cLog.Info(cMwLog.CalibManageMenuClickEventLog);
            PlcCalibraionPage calib = new PlcCalibraionPage();

            SelectPage(calib);
        }
        private void BtnHMICtrl_Click(object sender, EventArgs e)
        {
            cLog.Info(cMwLog.HMIManageMenuClickEventLog);
            if (!(this.splitContainer2.Panel2.Controls.Equals(HMIController.mIns)))
            {
                if (HMIController.mIns == null)
                {
                    HMIController hmi = new HMIController();
                    SelectPage(hmi);
                }
                else
                {
                    SelectPage(HMIController.mIns);

                }
            }
        }


        private void BtnPLCManage_Click(object sender, EventArgs e)
        {
            cLog.Info(cMwLog.PLCIManageMenuClickEventLog);
            if (PLCController.mIns == null)
            {
                PLCController plc = new PLCController();
                SelectPage(plc);
            }
            else
            {
                SelectPage(PLCController.mIns);

            }
        }

        private void BtnDBMS_Click(object sender, EventArgs e)
        {
            cLog.Info(cMwLog.DBMSManageMenuClickEventLog);
            if (DBMSController.mIns == null)
            {
                DBMSController dbms = new DBMSController();
                SelectPage(dbms);
            }
            else
            {
                SelectPage(DBMSController.mIns);

            }
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            if (Measure.IsMesureOn10 == 1)
                return;

            if (MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                cLog.Info(cLwLog.LogoutOk);
                Measure.isExit = true;
                this.Close();
            }
        }

        private void BtnAnalysis_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = System.Windows.Forms.Application.StartupPath + @"\\DoAnalysisMSC.exe";

                Process.Start(filePath);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Measure.program_exit == false)
            {
                e.Cancel = true;
                this.Hide();

                try
                {
                    LoginLib.FrmLogin insLogin1 = new LoginLib.FrmLogin();
                    insLogin1.LogoutUpdateDB(mbid: Measure.mbid, logouttime: "20" + tbxLiveTime.Text,
                        exeLocation: "measure", programId: 1);
                    insLogin1 = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Measure.mbid = "";
                CallLoginWindow(ref Measure.mbid);

            }
        }

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

        private void PbMin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PbMax_Paint(object sender, PaintEventArgs e)
        {
        }

        private void PbClose_Paint(object sender, PaintEventArgs e)
        {
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

        public void MWEnabledButton(bool value)
        {
            Measure.IsMesureOn10 = value == false ? 1 : 0;

            System.Drawing.Color bgColor;
            System.Drawing.Color bgColor2;
            if (Measure.IsMesureOn10 == 0)
            {//black
                bgColor = Color.FromArgb(50, 58, 71);
                bgColor2 = Color.FromArgb(255, 255, 255);

            }
            else
            {//red
                bgColor = Color.FromArgb(85, 99, 122);
                bgColor2 = Color.FromArgb(217, 217, 217);
            }
            btnMeasure.BackColor = bgColor;
            btnDashBoard.BackColor = bgColor;
            btnRequester.BackColor = bgColor;
            btnRequesterSample.BackColor = bgColor;
            btnRecipe.BackColor = bgColor;
            btnUser.BackColor = bgColor;
            btnPatternManage.BackColor = bgColor;
            btnCaliManage.BackColor = bgColor;
            btnHMICtrl.BackColor = bgColor;
            btnPlcCtrl.BackColor = bgColor;
            btnDbmsCtrl.BackColor = bgColor;
            btnAnalysis.BackColor = bgColor;
            btnlogout.BackColor = bgColor2;
            pbMin.BackColor = bgColor2;
            pbMax.BackColor = bgColor2;
            pbClose.BackColor = bgColor2;

            this.btnMeasure.Enabled = value;
            this.btnDashBoard.Enabled = value;
            this.btnRequester.Enabled = value;
            this.btnRequesterSample.Enabled = value;
            this.btnRecipe.Enabled = value;

            this.btnAnalysis.Enabled = value;
            this.btnlogout.Enabled = value;
            this.pbMin.Enabled = value;
            this.pbMax.Enabled = value;
            this.pbClose.Enabled = value;

            if (m_iMblevel == 0)
            {
                btnUser.Enabled = false;
                btnPatternManage.Enabled = false;
                btnCaliManage.Enabled = false;
                btnPlcCtrl.Enabled = false;
                btnHMICtrl.Enabled = false;
                btnDbmsCtrl.Enabled = false;
            }
            else
            {
                this.btnUser.Enabled = value;
                this.btnPatternManage.Enabled = value;
                this.btnCaliManage.Enabled = value;
                this.btnHMICtrl.Enabled = value;
                this.btnPlcCtrl.Enabled = value;
                this.btnDbmsCtrl.Enabled = value;
            }

        }

    }
}


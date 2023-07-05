using C1.Chart;
using C1.Win.C1FlexGrid;
using C1.Win.Chart;
using DBMS_V1;
using DwLib.Data.Generic;
using DWLib.Data.Generic;
using EventLog;
using log4net;
using PlcLSE_V1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Threading;
using MessageBox = System.Windows.MessageBox;
using Tbl_measure_chamber = DBMS_V1.Data.MSC.Tbl_measure_chamber;

namespace DoMeasureMSC.Pages
{
    public partial class MeasureManagePage : Form
    {
        // 디자인 영역====================================================================================================================
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeasureManagePage));
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblShowStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblchamberend = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.lblchamberstart = new System.Windows.Forms.Label();
            this.lblmstart = new System.Windows.Forms.Label();
            this.lblmode = new System.Windows.Forms.Label();
            this.lblrcp = new System.Windows.Forms.Label();
            this.btnRunModeAtMt = new ItachiUIBunifu.ButtonBunifuItachi();
            this.btnPatternModeOn = new ItachiUIBunifu.ButtonBunifuItachi();
            this.btnFixModeOn = new ItachiUIBunifu.ButtonBunifuItachi();
            this.btnChamberStop = new ItachiUIBunifu.ButtonBunifuItachi();
            this.btnChamberStart = new ItachiUIBunifu.ButtonBunifuItachi();
            this.btnSampleMeasureStop = new ItachiUIBunifu.ButtonBunifuItachi();
            this.btnrcp = new ItachiUIBunifu.ButtonBunifuItachi();
            this.btnMeasureStart = new ItachiUIBunifu.ButtonBunifuItachi();
            this.btnExport = new ItachiUIBunifu.ButtonBunifuItachi();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.fgReqInfo = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.logbox = new System.Windows.Forms.ListBox();
            this.fgtimeGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.fgMeasureBaseInfo = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.fgCallRecipe = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fcDataChart = new C1.Win.Chart.FlexChart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fgDataGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgReqInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgtimeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgMeasureBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgCallRecipe)).BeginInit();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcDataChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1640, 950);
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblShowStatus);
            this.panel1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(428, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 32);
            this.panel1.TabIndex = 1;
            // 
            // lblShowStatus
            // 
            this.lblShowStatus.AutoSize = true;
            this.lblShowStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShowStatus.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblShowStatus.Location = new System.Drawing.Point(0, 0);
            this.lblShowStatus.MaximumSize = new System.Drawing.Size(860, 24);
            this.lblShowStatus.MinimumSize = new System.Drawing.Size(860, 24);
            this.lblShowStatus.Name = "lblShowStatus";
            this.lblShowStatus.Size = new System.Drawing.Size(860, 24);
            this.lblShowStatus.TabIndex = 0;
            this.lblShowStatus.Text = "label5";
            this.lblShowStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "측정관리";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblchamberend);
            this.splitContainer2.Panel1.Controls.Add(this.lblresult);
            this.splitContainer2.Panel1.Controls.Add(this.lblchamberstart);
            this.splitContainer2.Panel1.Controls.Add(this.lblmstart);
            this.splitContainer2.Panel1.Controls.Add(this.lblmode);
            this.splitContainer2.Panel1.Controls.Add(this.lblrcp);
            this.splitContainer2.Panel1.Controls.Add(this.btnRunModeAtMt);
            this.splitContainer2.Panel1.Controls.Add(this.btnPatternModeOn);
            this.splitContainer2.Panel1.Controls.Add(this.btnFixModeOn);
            this.splitContainer2.Panel1.Controls.Add(this.btnChamberStop);
            this.splitContainer2.Panel1.Controls.Add(this.btnChamberStart);
            this.splitContainer2.Panel1.Controls.Add(this.btnSampleMeasureStop);
            this.splitContainer2.Panel1.Controls.Add(this.btnrcp);
            this.splitContainer2.Panel1.Controls.Add(this.btnMeasureStart);
            this.splitContainer2.Panel1.Controls.Add(this.btnExport);
            this.splitContainer2.Panel1.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1640, 896);
            this.splitContainer2.SplitterDistance = 130;
            this.splitContainer2.TabIndex = 0;
            // 
            // lblchamberend
            // 
            this.lblchamberend.AutoSize = true;
            this.lblchamberend.BackColor = System.Drawing.Color.White;
            this.lblchamberend.Location = new System.Drawing.Point(830, 9);
            this.lblchamberend.MaximumSize = new System.Drawing.Size(180, 21);
            this.lblchamberend.MinimumSize = new System.Drawing.Size(180, 21);
            this.lblchamberend.Name = "lblchamberend";
            this.lblchamberend.Size = new System.Drawing.Size(180, 21);
            this.lblchamberend.TabIndex = 32;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lblresult.Location = new System.Drawing.Point(1235, 9);
            this.lblresult.MaximumSize = new System.Drawing.Size(180, 21);
            this.lblresult.MinimumSize = new System.Drawing.Size(180, 21);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(180, 21);
            this.lblresult.TabIndex = 31;
            // 
            // lblchamberstart
            // 
            this.lblchamberstart.AutoSize = true;
            this.lblchamberstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lblchamberstart.Location = new System.Drawing.Point(627, 9);
            this.lblchamberstart.MaximumSize = new System.Drawing.Size(180, 21);
            this.lblchamberstart.MinimumSize = new System.Drawing.Size(180, 21);
            this.lblchamberstart.Name = "lblchamberstart";
            this.lblchamberstart.Size = new System.Drawing.Size(180, 21);
            this.lblchamberstart.TabIndex = 30;
            // 
            // lblmstart
            // 
            this.lblmstart.AutoSize = true;
            this.lblmstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lblmstart.Location = new System.Drawing.Point(1032, 9);
            this.lblmstart.MaximumSize = new System.Drawing.Size(180, 21);
            this.lblmstart.MinimumSize = new System.Drawing.Size(180, 21);
            this.lblmstart.Name = "lblmstart";
            this.lblmstart.Size = new System.Drawing.Size(180, 21);
            this.lblmstart.TabIndex = 29;
            // 
            // lblmode
            // 
            this.lblmode.AutoSize = true;
            this.lblmode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lblmode.Location = new System.Drawing.Point(424, 9);
            this.lblmode.MaximumSize = new System.Drawing.Size(180, 21);
            this.lblmode.MinimumSize = new System.Drawing.Size(180, 21);
            this.lblmode.Name = "lblmode";
            this.lblmode.Size = new System.Drawing.Size(180, 21);
            this.lblmode.TabIndex = 28;
            // 
            // lblrcp
            // 
            this.lblrcp.AutoSize = true;
            this.lblrcp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lblrcp.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblrcp.Location = new System.Drawing.Point(225, 8);
            this.lblrcp.MaximumSize = new System.Drawing.Size(180, 21);
            this.lblrcp.MinimumSize = new System.Drawing.Size(180, 21);
            this.lblrcp.Name = "lblrcp";
            this.lblrcp.Size = new System.Drawing.Size(180, 21);
            this.lblrcp.TabIndex = 27;
            // 
            // btnRunModeAtMt
            // 
            this.btnRunModeAtMt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnRunModeAtMt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnRunModeAtMt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnRunModeAtMt.BorderRadius = 14;
            this.btnRunModeAtMt.BorderSize = 0;
            this.btnRunModeAtMt.FlatAppearance.BorderSize = 0;
            this.btnRunModeAtMt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunModeAtMt.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunModeAtMt.ForeColor = System.Drawing.Color.White;
            this.btnRunModeAtMt.Location = new System.Drawing.Point(9, 32);
            this.btnRunModeAtMt.Name = "btnRunModeAtMt";
            this.btnRunModeAtMt.Padding = new System.Windows.Forms.Padding(3);
            this.btnRunModeAtMt.Size = new System.Drawing.Size(200, 89);
            this.btnRunModeAtMt.TabIndex = 26;
            this.btnRunModeAtMt.Text = "자동모드";
            this.btnRunModeAtMt.TextColor = System.Drawing.Color.White;
            this.btnRunModeAtMt.UseVisualStyleBackColor = false;
            this.btnRunModeAtMt.Click += new System.EventHandler(this.BtnRunModeATMT_Click);
            // 
            // btnPatternModeOn
            // 
            this.btnPatternModeOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnPatternModeOn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnPatternModeOn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnPatternModeOn.BorderRadius = 14;
            this.btnPatternModeOn.BorderSize = 0;
            this.btnPatternModeOn.FlatAppearance.BorderSize = 0;
            this.btnPatternModeOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatternModeOn.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatternModeOn.ForeColor = System.Drawing.Color.White;
            this.btnPatternModeOn.Location = new System.Drawing.Point(415, 83);
            this.btnPatternModeOn.Name = "btnPatternModeOn";
            this.btnPatternModeOn.Padding = new System.Windows.Forms.Padding(3);
            this.btnPatternModeOn.Size = new System.Drawing.Size(200, 39);
            this.btnPatternModeOn.TabIndex = 25;
            this.btnPatternModeOn.Text = "패턴모드";
            this.btnPatternModeOn.TextColor = System.Drawing.Color.White;
            this.btnPatternModeOn.UseVisualStyleBackColor = false;
            this.btnPatternModeOn.Click += new System.EventHandler(this.BtnPatternModeOn_Click);
            // 
            // btnFixModeOn
            // 
            this.btnFixModeOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnFixModeOn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnFixModeOn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnFixModeOn.BorderRadius = 14;
            this.btnFixModeOn.BorderSize = 0;
            this.btnFixModeOn.FlatAppearance.BorderSize = 0;
            this.btnFixModeOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixModeOn.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixModeOn.ForeColor = System.Drawing.Color.White;
            this.btnFixModeOn.Location = new System.Drawing.Point(415, 36);
            this.btnFixModeOn.Name = "btnFixModeOn";
            this.btnFixModeOn.Padding = new System.Windows.Forms.Padding(3);
            this.btnFixModeOn.Size = new System.Drawing.Size(200, 39);
            this.btnFixModeOn.TabIndex = 24;
            this.btnFixModeOn.Text = "정치모드";
            this.btnFixModeOn.TextColor = System.Drawing.Color.White;
            this.btnFixModeOn.UseVisualStyleBackColor = false;
            this.btnFixModeOn.Click += new System.EventHandler(this.BtnFixModeOn_Click);
            // 
            // btnChamberStop
            // 
            this.btnChamberStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnChamberStop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnChamberStop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnChamberStop.BorderRadius = 14;
            this.btnChamberStop.BorderSize = 0;
            this.btnChamberStop.FlatAppearance.BorderSize = 0;
            this.btnChamberStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamberStop.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamberStop.ForeColor = System.Drawing.Color.White;
            this.btnChamberStop.Location = new System.Drawing.Point(820, 33);
            this.btnChamberStop.Name = "btnChamberStop";
            this.btnChamberStop.Padding = new System.Windows.Forms.Padding(3);
            this.btnChamberStop.Size = new System.Drawing.Size(200, 89);
            this.btnChamberStop.TabIndex = 23;
            this.btnChamberStop.Text = "챔버중지";
            this.btnChamberStop.TextColor = System.Drawing.Color.White;
            this.btnChamberStop.UseVisualStyleBackColor = false;
            this.btnChamberStop.Click += new System.EventHandler(this.BtnChamberStop_Click);
            // 
            // btnChamberStart
            // 
            this.btnChamberStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnChamberStart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnChamberStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnChamberStart.BorderRadius = 14;
            this.btnChamberStart.BorderSize = 0;
            this.btnChamberStart.FlatAppearance.BorderSize = 0;
            this.btnChamberStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamberStart.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamberStart.ForeColor = System.Drawing.Color.White;
            this.btnChamberStart.Location = new System.Drawing.Point(617, 33);
            this.btnChamberStart.Name = "btnChamberStart";
            this.btnChamberStart.Padding = new System.Windows.Forms.Padding(3);
            this.btnChamberStart.Size = new System.Drawing.Size(200, 89);
            this.btnChamberStart.TabIndex = 22;
            this.btnChamberStart.Text = "챔버가동";
            this.btnChamberStart.TextColor = System.Drawing.Color.White;
            this.btnChamberStart.UseVisualStyleBackColor = false;
            this.btnChamberStart.Click += new System.EventHandler(this.BtnChamberStart_Click);
            // 
            // btnSampleMeasureStop
            // 
            this.btnSampleMeasureStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(78)))), ((int)(((byte)(77)))));
            this.btnSampleMeasureStop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(78)))), ((int)(((byte)(77)))));
            this.btnSampleMeasureStop.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnSampleMeasureStop.BorderRadius = 14;
            this.btnSampleMeasureStop.BorderSize = 0;
            this.btnSampleMeasureStop.FlatAppearance.BorderSize = 0;
            this.btnSampleMeasureStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSampleMeasureStop.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSampleMeasureStop.ForeColor = System.Drawing.Color.White;
            this.btnSampleMeasureStop.Location = new System.Drawing.Point(1428, 32);
            this.btnSampleMeasureStop.Name = "btnSampleMeasureStop";
            this.btnSampleMeasureStop.Padding = new System.Windows.Forms.Padding(3);
            this.btnSampleMeasureStop.Size = new System.Drawing.Size(200, 89);
            this.btnSampleMeasureStop.TabIndex = 19;
            this.btnSampleMeasureStop.Text = "샘플측정중지";
            this.btnSampleMeasureStop.TextColor = System.Drawing.Color.White;
            this.btnSampleMeasureStop.UseVisualStyleBackColor = false;
            this.btnSampleMeasureStop.Click += new System.EventHandler(this.BtnSampleMeasureStop_Click);
            // 
            // btnrcp
            // 
            this.btnrcp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnrcp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnrcp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnrcp.BorderRadius = 14;
            this.btnrcp.BorderSize = 0;
            this.btnrcp.FlatAppearance.BorderSize = 0;
            this.btnrcp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrcp.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrcp.ForeColor = System.Drawing.Color.White;
            this.btnrcp.Location = new System.Drawing.Point(212, 32);
            this.btnrcp.Name = "btnrcp";
            this.btnrcp.Padding = new System.Windows.Forms.Padding(3);
            this.btnrcp.Size = new System.Drawing.Size(200, 89);
            this.btnrcp.TabIndex = 17;
            this.btnrcp.Text = "레시피선택";
            this.btnrcp.TextColor = System.Drawing.Color.White;
            this.btnrcp.UseVisualStyleBackColor = false;
            this.btnrcp.Click += new System.EventHandler(this.BtnChooseRecipe_Click);
            // 
            // btnMeasureStart
            // 
            this.btnMeasureStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnMeasureStart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnMeasureStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnMeasureStart.BorderRadius = 14;
            this.btnMeasureStart.BorderSize = 0;
            this.btnMeasureStart.FlatAppearance.BorderSize = 0;
            this.btnMeasureStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeasureStart.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMeasureStart.ForeColor = System.Drawing.Color.White;
            this.btnMeasureStart.Location = new System.Drawing.Point(1022, 33);
            this.btnMeasureStart.Name = "btnMeasureStart";
            this.btnMeasureStart.Padding = new System.Windows.Forms.Padding(3);
            this.btnMeasureStart.Size = new System.Drawing.Size(200, 89);
            this.btnMeasureStart.TabIndex = 18;
            this.btnMeasureStart.Text = "샘플측정시작";
            this.btnMeasureStart.TextColor = System.Drawing.Color.White;
            this.btnMeasureStart.UseVisualStyleBackColor = false;
            this.btnMeasureStart.Click += new System.EventHandler(this.BtnMeasureStart_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnExport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.btnExport.BorderRadius = 14;
            this.btnExport.BorderSize = 0;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1225, 33);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(3);
            this.btnExport.Size = new System.Drawing.Size(200, 89);
            this.btnExport.TabIndex = 20;
            this.btnExport.Text = "테스트결과보기";
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.BackColor = System.Drawing.Color.White;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.fgReqInfo);
            this.splitContainer3.Panel1.Controls.Add(this.logbox);
            this.splitContainer3.Panel1.Controls.Add(this.fgtimeGrid);
            this.splitContainer3.Panel1.Controls.Add(this.fgMeasureBaseInfo);
            this.splitContainer3.Panel1.Controls.Add(this.fgCallRecipe);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tab1);
            this.splitContainer3.Size = new System.Drawing.Size(1640, 762);
            this.splitContainer3.SplitterDistance = 374;
            this.splitContainer3.TabIndex = 0;
            // 
            // fgReqInfo
            // 
            this.fgReqInfo.AllowEditing = false;
            this.fgReqInfo.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fgReqInfo.BackColor = System.Drawing.Color.White;
            this.fgReqInfo.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgReqInfo.ColumnInfo = resources.GetString("fgReqInfo.ColumnInfo");
            this.fgReqInfo.Location = new System.Drawing.Point(958, 46);
            this.fgReqInfo.Name = "fgReqInfo";
            this.fgReqInfo.Rows.Count = 13;
            this.fgReqInfo.Rows.DefaultSize = 25;
            this.fgReqInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fgReqInfo.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgReqInfo.Size = new System.Drawing.Size(670, 323);
            this.fgReqInfo.StyleInfo = resources.GetString("fgReqInfo.StyleInfo");
            this.fgReqInfo.TabIndex = 7;
            // 
            // logbox
            // 
            this.logbox.BackColor = System.Drawing.Color.LightGray;
            this.logbox.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logbox.FormattingEnabled = true;
            this.logbox.ItemHeight = 17;
            this.logbox.Location = new System.Drawing.Point(7, 212);
            this.logbox.MaximumSize = new System.Drawing.Size(411, 160);
            this.logbox.MinimumSize = new System.Drawing.Size(411, 160);
            this.logbox.Name = "logbox";
            this.logbox.Size = new System.Drawing.Size(411, 157);
            this.logbox.TabIndex = 6;
            // 
            // fgtimeGrid
            // 
            this.fgtimeGrid.BackColor = System.Drawing.Color.White;
            this.fgtimeGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgtimeGrid.ColumnInfo = resources.GetString("fgtimeGrid.ColumnInfo");
            this.fgtimeGrid.Location = new System.Drawing.Point(7, 104);
            this.fgtimeGrid.Name = "fgtimeGrid";
            this.fgtimeGrid.Rows.Count = 4;
            this.fgtimeGrid.Rows.DefaultSize = 25;
            this.fgtimeGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgtimeGrid.Size = new System.Drawing.Size(411, 102);
            this.fgtimeGrid.StyleInfo = resources.GetString("fgtimeGrid.StyleInfo");
            this.fgtimeGrid.TabIndex = 5;
            // 
            // fgMeasureBaseInfo
            // 
            this.fgMeasureBaseInfo.AllowEditing = false;
            this.fgMeasureBaseInfo.BackColor = System.Drawing.Color.White;
            this.fgMeasureBaseInfo.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgMeasureBaseInfo.ColumnInfo = resources.GetString("fgMeasureBaseInfo.ColumnInfo");
            this.fgMeasureBaseInfo.Location = new System.Drawing.Point(7, 45);
            this.fgMeasureBaseInfo.Name = "fgMeasureBaseInfo";
            this.fgMeasureBaseInfo.Rows.Count = 2;
            this.fgMeasureBaseInfo.Rows.DefaultSize = 25;
            this.fgMeasureBaseInfo.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgMeasureBaseInfo.Size = new System.Drawing.Size(411, 53);
            this.fgMeasureBaseInfo.StyleInfo = resources.GetString("fgMeasureBaseInfo.StyleInfo");
            this.fgMeasureBaseInfo.TabIndex = 4;
            this.fgMeasureBaseInfo.Click += new System.EventHandler(this.FgMeasureBaseInfo_Click);
            // 
            // fgCallRecipe
            // 
            this.fgCallRecipe.AllowEditing = false;
            this.fgCallRecipe.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fgCallRecipe.BackColor = System.Drawing.Color.White;
            this.fgCallRecipe.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgCallRecipe.ColumnInfo = resources.GetString("fgCallRecipe.ColumnInfo");
            this.fgCallRecipe.Location = new System.Drawing.Point(440, 46);
            this.fgCallRecipe.Name = "fgCallRecipe";
            this.fgCallRecipe.Rows.Count = 13;
            this.fgCallRecipe.Rows.DefaultSize = 25;
            this.fgCallRecipe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fgCallRecipe.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgCallRecipe.Size = new System.Drawing.Size(495, 323);
            this.fgCallRecipe.StyleInfo = resources.GetString("fgCallRecipe.StyleInfo");
            this.fgCallRecipe.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "측정 기본 정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(439, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "레시피 정보";
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tab1.Location = new System.Drawing.Point(6, 0);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(1622, 384);
            this.tab1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.fcDataChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1614, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "스팩트럼";
            // 
            // fcDataChart
            // 
            this.fcDataChart.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.fcDataChart.AnimationLoad.Duration = 400;
            this.fcDataChart.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.fcDataChart.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.fcDataChart.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.fcDataChart.AnimationUpdate.Duration = 400;
            this.fcDataChart.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.fcDataChart.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.fcDataChart.AxisX.AxisLine = true;
            this.fcDataChart.AxisX.Chart = this.fcDataChart;
            this.fcDataChart.AxisX.DataSource = null;
            this.fcDataChart.AxisX.Formatter = null;
            this.fcDataChart.AxisX.GroupProvider = null;
            this.fcDataChart.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.fcDataChart.AxisX.GroupStyle.VerticalText = false;
            this.fcDataChart.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.fcDataChart.AxisX.GroupVisibilityLevel = 0;
            this.fcDataChart.AxisX.MajorGridStyle.VerticalText = false;
            this.fcDataChart.AxisX.MinorGridStyle.VerticalText = false;
            this.fcDataChart.AxisX.PlotAreaName = null;
            this.fcDataChart.AxisX.Position = C1.Chart.Position.Bottom;
            this.fcDataChart.AxisX.Style.VerticalText = false;
            this.fcDataChart.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.fcDataChart.AxisX.TitleStyle.VerticalText = false;
            this.fcDataChart.AxisY.AxisLine = false;
            this.fcDataChart.AxisY.Chart = this.fcDataChart;
            this.fcDataChart.AxisY.DataSource = null;
            this.fcDataChart.AxisY.Formatter = null;
            this.fcDataChart.AxisY.GroupProvider = null;
            this.fcDataChart.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.fcDataChart.AxisY.GroupStyle.VerticalText = false;
            this.fcDataChart.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.fcDataChart.AxisY.GroupVisibilityLevel = 0;
            this.fcDataChart.AxisY.MajorGrid = true;
            this.fcDataChart.AxisY.MajorGridStyle.VerticalText = false;
            this.fcDataChart.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.fcDataChart.AxisY.MinorGridStyle.VerticalText = false;
            this.fcDataChart.AxisY.PlotAreaName = null;
            this.fcDataChart.AxisY.Position = C1.Chart.Position.Left;
            this.fcDataChart.AxisY.Style.VerticalText = false;
            this.fcDataChart.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.fcDataChart.AxisY.TitleStyle.VerticalText = false;
            this.fcDataChart.BindingX = "strxPos1";
            this.fcDataChart.ChartType = C1.Chart.ChartType.Line;
            this.fcDataChart.DataLabel.Angle = 0;
            this.fcDataChart.DataLabel.Border = false;
            this.fcDataChart.DataLabel.BorderStyle.VerticalText = false;
            this.fcDataChart.DataLabel.ConnectingLine = false;
            this.fcDataChart.DataLabel.Content = null;
            this.fcDataChart.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.fcDataChart.DataLabel.MaxAutoLabels = 100;
            this.fcDataChart.DataLabel.MaxLines = 0;
            this.fcDataChart.DataLabel.MaxWidth = 0;
            this.fcDataChart.DataLabel.Offset = 0;
            this.fcDataChart.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.fcDataChart.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.fcDataChart.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.fcDataChart.DataLabel.Style.VerticalText = false;
            this.fcDataChart.Legend.ItemMaxWidth = 0;
            this.fcDataChart.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.fcDataChart.Legend.Position = C1.Chart.Position.Right;
            this.fcDataChart.Legend.Reversed = false;
            this.fcDataChart.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.fcDataChart.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.fcDataChart.Legend.Title = null;
            this.fcDataChart.LegendToggle = true;
            this.fcDataChart.Location = new System.Drawing.Point(9, 3);
            this.fcDataChart.Margin = new System.Windows.Forms.Padding(10);
            this.fcDataChart.Name = "fcDataChart";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.fcDataChart.Options.ClusterSize = elementSize1;
            this.fcDataChart.PlotMargin = new System.Windows.Forms.Padding(0);
            this.fcDataChart.PlotStyle.VerticalText = false;
            this.fcDataChart.SelectedSeries = null;
            this.fcDataChart.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.fcDataChart.SelectionStyle.VerticalText = false;
            this.fcDataChart.Size = new System.Drawing.Size(1595, 346);
            this.fcDataChart.TabIndex = 0;
            this.fcDataChart.Text = "flexChart1";
            // 
            // 
            // 
            this.fcDataChart.ToolTip.Content = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.fgDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1614, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "데이터";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fgDataGrid
            // 
            this.fgDataGrid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.fgDataGrid.AllowEditing = false;
            this.fgDataGrid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgDataGrid.BackColor = System.Drawing.Color.White;
            this.fgDataGrid.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.fgDataGrid.ColumnInfo = resources.GetString("fgDataGrid.ColumnInfo");
            this.fgDataGrid.Font = new System.Drawing.Font("나눔고딕", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fgDataGrid.ForeColor = System.Drawing.Color.Black;
            this.fgDataGrid.Location = new System.Drawing.Point(-1, 3);
            this.fgDataGrid.Name = "fgDataGrid";
            this.fgDataGrid.Rows.Count = 101;
            this.fgDataGrid.Rows.DefaultSize = 30;
            this.fgDataGrid.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgDataGrid.Size = new System.Drawing.Size(1615, 346);
            this.fgDataGrid.StyleInfo = resources.GetString("fgDataGrid.StyleInfo");
            this.fgDataGrid.TabIndex = 1;
            // 
            // MeasureManagePage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 950);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1640, 950);
            this.MinimumSize = new System.Drawing.Size(1640, 950);
            this.Name = "MeasureManagePage";
            this.Text = "MeasureManagePage";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgReqInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgtimeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgMeasureBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgCallRecipe)).EndInit();
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcDataChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private ItachiUIBunifu.ButtonBunifuItachi btnChamberStart;
        private ItachiUIBunifu.ButtonBunifuItachi btnSampleMeasureStop;
        private ItachiUIBunifu.ButtonBunifuItachi btnrcp;
        private ItachiUIBunifu.ButtonBunifuItachi btnMeasureStart;
        private ItachiUIBunifu.ButtonBunifuItachi btnExport;
        private ItachiUIBunifu.ButtonBunifuItachi btnChamberStop;
        private ItachiUIBunifu.ButtonBunifuItachi btnPatternModeOn;
        private ItachiUIBunifu.ButtonBunifuItachi btnFixModeOn;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private C1.Win.Chart.FlexChart fcDataChart;
        private C1.Win.C1FlexGrid.C1FlexGrid fgCallRecipe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1FlexGrid.C1FlexGrid fgtimeGrid;
        private System.Windows.Forms.ListBox logbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblShowStatus;
        private C1FlexGrid fgMeasureBaseInfo;
        private C1FlexGrid fgDataGrid;
        private ItachiUIBunifu.ButtonBunifuItachi btnRunModeAtMt;
        private C1FlexGrid fgReqInfo;
        private System.Windows.Forms.Label lblmstart;
        private System.Windows.Forms.Label lblmode;
        private System.Windows.Forms.Label lblrcp;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Label lblchamberstart;
        private System.Windows.Forms.Label lblchamberend;
        //================================================================================================================================


        public MeasureManagePage()
        {
            InitializeComponent();
            InitalizeCallRecipe();
            InitalizeTime();

            fcDataChart.AxisY.MajorGridStyle.LinePattern = LinePatternEnum.DashDot;
            _mMeasureStep = new MStepClass();
            fgMeasureBaseInfo[1, 1] = "1";
            fgMeasureBaseInfo[1, 2] = "측정 ID";

            fgMeasureBaseInfo.AllowEditing = true;
            fgMeasureBaseInfo.Cols[1].AllowEditing = false;
            fgMeasureBaseInfo.Cols[2].AllowEditing = false;

            SetNewMeasureID();
            mIns = this;

            cCurrentMdata = new ObservableCollection<CurrentMeasureData>();

            IsManualRunOn = true;//기본값 - 자동운전
            BtnRunModeATMT_Click(null, null);
            //InitializeMeasureThread();
            InitializeDevieInstance();

            lblShowStatus.Text = "[01] 레시피를 선택하세요. ";

            InitFxChart();
        }

        public static MeasureManagePage mIns;
        private readonly MeasureWriteLog cMwlog = new MeasureWriteLog();
        private static readonly ILog cLog = LogManager.GetLogger("Measure");

        private void InitFxChart()
        {
            series1 = new Series { Name = "현재온도1", Binding = fchartBindY_name };
            series3 = new Series { Name = "현재습도", Binding = fchartBindY_name };
            series4 = new Series { Name = "설정온도", Binding = fchartBindY_name };
            series5 = new Series { Name = "설정습도", Binding = fchartBindY_name };
            series6 = new Series { Name = "AI01", Binding = fchartBindY_name };
            series7 = new Series { Name = "AI02", Binding = fchartBindY_name };
            series8 = new Series { Name = "AI03", Binding = fchartBindY_name };
            series9 = new Series { Name = "AI04", Binding = fchartBindY_name };
            series10 = new Series { Name = "AI05", Binding = fchartBindY_name };
            series11 = new Series { Name = "AI06", Binding = fchartBindY_name };
            series12 = new Series { Name = "AI07", Binding = fchartBindY_name };
            series13 = new Series { Name = "AI08", Binding = fchartBindY_name };
            series14 = new Series { Name = "AI09", Binding = fchartBindY_name };
            series15 = new Series { Name = "AI10", Binding = fchartBindY_name };
            series16 = new Series { Name = "AI11", Binding = fchartBindY_name };
            series17 = new Series { Name = "AI12", Binding = fchartBindY_name };
            series18 = new Series { Name = "AO01", Binding = fchartBindY_name };
            series19 = new Series { Name = "AO02", Binding = fchartBindY_name };
            series20 = new Series { Name = "DI01", Binding = fchartBindY_name };
            series21 = new Series { Name = "DI02", Binding = fchartBindY_name };
            series22 = new Series { Name = "DI03", Binding = fchartBindY_name };
            series23 = new Series { Name = "DI04", Binding = fchartBindY_name };
            series24 = new Series { Name = "DO01", Binding = fchartBindY_name };
            series25 = new Series { Name = "DO02", Binding = fchartBindY_name };
            ChamberAddSeries(null);
        }

        Series series1;
        Series series3;
        Series series4;
        Series series5;
        Series series6;
        Series series7;
        Series series8;
        Series series9;
        Series series10;
        Series series11;
        Series series12;
        Series series13;
        Series series14;
        Series series15;
        Series series16;
        Series series17;
        Series series18;
        Series series19;
        Series series20;
        Series series21;
        Series series22;
        Series series23;
        Series series24;
        Series series25;
        readonly string fchartBindY_name = "PosY";

        private readonly ObservableCollection<DataXY> obCurTemp1 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> obCurTemp2 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> obCurHumi = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> obSetTemp = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> obSetHumi = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AI01 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AI02 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AI03 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AI04 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AI05 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AI06 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AI07 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AI08 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AI09 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AI10 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AI11 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AI12 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AO01 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AO02 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> DI01 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> DI02 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> DI03 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> DI04 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> DO01 = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> DO02 = new ObservableCollection<DataXY>() { };
        private readonly CurrentMeasureData _curMeasureData = new CurrentMeasureData();
        private readonly MySqlDTO msdto = new MySqlDTO();


        float hmi_data_md1avg = 0.0f;
        float hmi_data_md2avg = 0.0f;
        float hmi_data_md3avg = 0.0f;
        float hmi_data_md4avg = 0.0f;
        float hmi_data_ai01avg = 0.0f;
        float hmi_data_ai02avg = 0.0f;
        float hmi_data_ai03avg = 0.0f;
        float hmi_data_ai04avg = 0.0f;
        float hmi_data_ai05avg = 0.0f;
        float hmi_data_ai06avg = 0.0f;
        float hmi_data_ai07avg = 0.0f;
        float hmi_data_ai08avg = 0.0f;
        float hmi_data_ai09avg = 0.0f;
        float hmi_data_ai10avg = 0.0f;
        float hmi_data_ai11avg = 0.0f;
        float hmi_data_ai12avg = 0.0f;
        float hmi_data_ao01avg = 0.0f;
        float hmi_data_ao02avg = 0.0f;
        float hmi_data_di01avg = 0.0f;
        float hmi_data_di02avg = 0.0f;
        float hmi_data_di03avg = 0.0f;
        float hmi_data_di04avg = 0.0f;
        float hmi_data_do01avg = 0.0f;
        float hmi_data_do02avg = 0.0f;


        private double md1min = 999.000;
        private double md2min = 999.000;
        private double md3min = 999.000;
        private double md4min = 999.000;

        private double ai01min = 999.000;
        private double ai02min = 999.000;
        private double ai03min = 999.000;
        private double ai04min = 999.000;
        private double ai05min = 999.000;
        private double ai06min = 999.000;
        private double ai07min = 999.000;
        private double ai08min = 999.000;
        private double ai09min = 999.000;
        private double ai10min = 999.000;
        private double ai11min = 999.000;
        private double ai12min = 999.000;
        private double ao01min = 999.000;
        private double ao02min = 999.000;
        private double di01min = 999.000;
        private double di02min = 999.000;
        private double di03min = 999.000;
        private double di04min = 999.000;
        private double do01min = 999.000;
        private double do02min = 999.000;

        private double md1max = 0;
        private double md2max = 0;
        private double md3max = 0;
        private double md4max = 0;

        private double ai01max = 0;
        private double ai02max = 0;
        private double ai03max = 0;
        private double ai04max = 0;
        private double ai05max = 0;
        private double ai06max = 0;
        private double ai07max = 0;
        private double ai08max = 0;
        private double ai09max = 0;
        private double ai10max = 0;
        private double ai11max = 0;
        private double ai12max = 0;
        private double ao01max = 0;
        private double ao02max = 0;
        private double di01max = 0;
        private double di02max = 0;
        private double di03max = 0;
        private double di04max = 0;
        private double do01max = 0;
        private double do02max = 0;


        private int iMacroOpMode = 1;
        int mtime = 0;
        int countnum = 0;
        string mode = "";
        int flag100000 = 0;

        public static string rcpname;
        public static string rcpid;
        public string msid;
        public string mbid;
        public string reqmbname;

        string measureidText = "";
        private bool isChamberLoop;
        private bool IsManualRunOn = true;//false;

        public DBMS_V1.Data.MSC.Tbl_recipe cTbl_recipe = new DBMS_V1.Data.MSC.Tbl_recipe();
        public DBMS_V1.Data.MSC.Tbl_measure_result_statistics cTbl_statistics1 = new DBMS_V1.Data.MSC.Tbl_measure_result_statistics();
        public DBMS_V1.Data.MSC.Tbl_plc_calibration cTbl_calib = new DBMS_V1.Data.MSC.Tbl_plc_calibration();
        private readonly MStepClass _mMeasureStep;
        string m_strNowPlcPatternNo = string.Empty;

        /// <summary>
        /// 차트리셋 타이머 사용여부 (기본값 :false)
        /// </summary>
        readonly bool isChartReset_time_use = false;
        DispatcherTimer timer_chart_reset;


        private DateTime m_runningTime;

        private DateTime m_estEndtime;
        private readonly ObservableCollection<CurrentMeasureData> cCurrentMdata;
        private string m_logbox_title;
        UInt32 m_fstkeyno;
        private int chamber_repeat = 0;
        private string measurediv;

        private readonly List<string> keynolist = new List<string>();
        int iNowMeasurementType = 0;
        private Thread bwChamberMeasureThead1;
        private int pre_mdata_count = 0;
        private int aft_mdata_count = 0;
        private int aft_mdata_no_idx = 1;
        private int iAcqCount = 0;
        private int iAcqCountMax = 0;
        string m_strAcqStdTime;
        readonly AutoResetEvent autoEvent = new AutoResetEvent(false);
        bool m_isDbIndexUpdate;

        private readonly Stopwatch sw_device_acq = new Stopwatch();
        private readonly Stopwatch sw_ui_update = new Stopwatch();
        private readonly Stopwatch sw_db_update = new Stopwatch();

        enum MeasurementType
        {
            New = 0,
            Retry = 1
        }
        enum MeasureEndStdTypeValue
        {
            count_only = 0x00,
            time_only = 0x01,
            dual = 0x02,//measure time and measure count
            tripple = 0x03,//measure time and count and esttime
        }
        public class CurrentMeasureData
        {
            public int DataNo { get; set; }
            public string MeasureStarttime { get; set; }

            public string MeasureHD1 { get; set; }//HMI 현재 온도
            public string MeasureHD2 { get; set; }//HMI 현재 습도
            public string MeasureHD5 { get; set; }//HMI 설정 온도
            public string MeasureHD6 { get; set; }//HMI //설정 습도

            public string MeasureAI_01 { get; set; }
            public string MeasureAI_02 { get; set; }
            public string MeasureAI_03 { get; set; }
            public string MeasureAI_04 { get; set; }
            public string MeasureAI_05 { get; set; }
            public string MeasureAI_06 { get; set; }
            public string MeasureAI_07 { get; set; }
            public string MeasureAI_08 { get; set; }
            public string MeasureAI_09 { get; set; }
            public string MeasureAI_10 { get; set; }
            public string MeasureAI_11 { get; set; }
            public string MeasureAI_12 { get; set; }

            public string MeasureAO_01 { get; set; }
            public string MeasureAO_02 { get; set; }

            public string MeasureDI_01 { get; set; }
            public string MeasureDI_02 { get; set; }
            public string MeasureDI_03 { get; set; }
            public string MeasureDI_04 { get; set; }

            public string MeasureDO_01 { get; set; }
            public string MeasureDO_02 { get; set; }
        }
        public class Data { }
        private class MStepClass
        {
            public int id;
            public int iStep1_rcp;
            public int iStep2_a1_chamber;
            public int iStep6_result_report;
        }
        private enum Status
        {
            none = 0,
            not_set = 0,
            finished = 1,
            end = 1,
            success = 1,
            error = 2,
        }
        public class DataXY
        {
            public object PosX { get; set; }
            public Double PosY { get; set; }
        }
        //-------------------------------------------------------------------------------------------------
        //시작할 준비되면 호출됨
        private void InitializeDevieInstance()
        {
#pragma warning disable IDE0059
            if (HMIController.mIns == null)
            {
                var hmiCtrl = new HMIController();
            }

            if (PLCController.mIns == null)
            {
                var plcCtrl = new PLCController();
            }
            else
            {
                PLCController.mIns = null;
                var plcCtrl = new PLCController();

            }
#pragma warning restore IDE0059
        }

        private void InitializeMeasureThread()
        {
            if (isChartReset_time_use)
            {
                if (timer_chart_reset == null)
                    timer_chart_reset = new DispatcherTimer();
            }

            bwChamberMeasureThead1 = null;
            bwChamberMeasureThead1 = new Thread(new ParameterizedThreadStart(BwChamberMeasureThread1_DoWork))
            {
                IsBackground = true,
                Name = "Chamber Thread"
            };

        }
        //=============버튼이벤트=========================================================================================
        private void BtnChamberStart_Click(object sender, EventArgs e)
        {
            string StepID = "[03]" + " ";

            lblShowStatus.Text = StepID + "챔버 가동를 시작합니다.";
            string logbox_title = "챔버가동시작";
            lblchamberstart.BackColor = Color.FromArgb(255, 255, 0);
            lblchamberend.BackColor = Color.FromArgb(255, 255, 255);
            if (CommonClass.isMacroOn && CommonClass.isMacroNextRun)
            {

            }
            else
            {
                if (System.Windows.MessageBox.Show("챔버 가동 시작 하시겠습니까?", logbox_title, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                {
                    LogBoxAdd(logbox_title, "취소");
                    lblShowStatus.Text = StepID + "챔버 가동를 취소합니다.";
                    lblchamberstart.BackColor = Color.FromArgb(217, 217, 217);
                    //IsEnabledButton(true);
                    return;
                }
            }
            Cursor.Current = Cursors.WaitCursor;
            LogBoxAdd(logbox_title, "챔버 가동시작");
            lblShowStatus.Text = StepID + "챔버 가동을 시작 준비 중입니다.";
            if (ChamberRunningStart())
            {
                LogBoxAdd(logbox_title, "챔버 가동시작완료");
                cLog.Info(cMwlog.ChamberStertClickEventLog);
                lblchamberstart.BackColor = Color.FromArgb(68, 114, 196);
                Cursor.Current = Cursors.Default;
                Measure.IsChamberRunOn10 = 1;
                ChamberRunColor();
                lblShowStatus.Text = StepID + "챔버 가동 중입니다. [04] 샘플 측정 시작을 선택 하세요.";
                Delay(2000);
            }
            else
            {
                Measure.IsChamberRunOn10 = 0;
                ChamberRunColor();
                LogBoxAdd(logbox_title, "챔버 가동시작취소");
                lblShowStatus.Text = StepID + "챔버 가동를 취소합니다.";
            }
        }

        private void BtnChamberStop_Click(object sender, EventArgs e)
        {
            string StepID = "[03]" + " ";
            lblShowStatus.Text = StepID + "챔버 가동 중지를 시작합니다.";
            string logbox_title = "챔버가동중지";
            lblchamberstart.BackColor = Color.FromArgb(255, 255, 255);
            lblchamberend.BackColor = Color.FromArgb(255, 255, 0);
            if (System.Windows.MessageBox.Show("챔버 가동 중지 하시겠습니까?", logbox_title, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                LogBoxAdd(logbox_title, "취소");
                lblShowStatus.Text = StepID + "챔버 가동 중지를 취소합니다.";
                lblchamberstart.BackColor = Color.FromArgb(68, 114, 196);
                lblchamberend.BackColor = Color.FromArgb(255, 255, 255);
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            LogBoxAdd(logbox_title, "챔버 가동중지 시작");
            lblShowStatus.Text = StepID + "챔버 가동 중지 중입니다. ";
            if (ChamberRunningStop())
            {
                LogBoxAdd(logbox_title, "챔버 가동중지완료");
                cLog.Info(cMwlog.ChamberStopClickEventLog);
                lblchamberend.BackColor = Color.FromArgb(68, 114, 196);
                Cursor.Current = Cursors.Default;
                lblShowStatus.Text = StepID + "챔버 가동 중지가 완료됩니다. ";
            }
            else
            {
                Measure.IsChamberRunOn10 = 1;
                ChamberRunColor();
                LogBoxAdd(logbox_title, "챔버 가동중지취소");
                lblShowStatus.Text = StepID + "챔버 가동 중지를 취소합니다.";
            }
        }


        private void SetNewMeasureID()
        {
            measureidText = Measure.mbid + "_" + DateTime.Now.ToString("yyMMddHHmmss");

            fgMeasureBaseInfo[1, 3] = measureidText;
            fgMeasureBaseInfo.Cols[3].AllowEditing = true;
        }
        private void ResetProcLabels(bool option)
        {
            if (option) //스티커 회색으로 리셋
            {
                lblmode.BackColor = Color.FromArgb(217, 217, 217);
                lblmstart.BackColor = Color.FromArgb(217, 217, 217);
                lblchamberstart.BackColor = Color.FromArgb(217, 217, 217);
                lblresult.BackColor = Color.FromArgb(217, 217, 217);
            }
            else
            {
                return;
            }

        }

        bool m_isChangedCalibName = true;
        string m_strNowCalibId = string.Empty;

        private void BtnChooseRecipe_Click(object sender, EventArgs e)
        {
            string strValue = "레시피선택";
            if (System.Windows.MessageBox.Show(strValue + " 하시겠습니까?", strValue, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                LogBoxAdd(strValue, "취소");
                return;
            }
            lblShowStatus.Text = "[01] 레시피 선택 중입니다";
            lblrcp.BackColor = Color.FromArgb(255, 255, 0);
            //스티커 및 버튼 색상 초기화
            ResetProcLabels(true);

            try
            {
                SetNewMeasureID();  //측정ID reset

                //최대,최소값 reset
                _mMeasureStep.id = 1;
                _mMeasureStep.iStep1_rcp = (int)Status.not_set;

                string logbox_title = btnrcp.Text.ToString();

                InitalizeCallRecipe();


                LogBoxAdd(logbox_title, "시작");
                RecipeWindow rw = new RecipeWindow();
                if (rw.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    lblShowStatus.Text = "";

                    string sql = $"select name, method, mtime, roidiameter, patternid, settemp, sethumi, calibid," +
                        $"reqmbid1,reqmbid2,reqmbid3,reqmbid4,reqmbid5,reqmbid6,reqmbid7,reqmbid8,reqmbid9,reqmbid10,reqmbid11,reqmbid12," +
                        $"reqmbname1,reqmbname2,reqmbname3,reqmbname4,reqmbname5,reqmbname6,reqmbname7,reqmbname8,reqmbname9,reqmbname10,reqmbname11,reqmbname12," +
                        $"reqsampleid1,reqsampleid2,reqsampleid3,reqsampleid4,reqsampleid5,reqsampleid6,reqsampleid7,reqsampleid8,reqsampleid9,reqsampleid10,reqsampleid11,reqsampleid12," +
                        $"reqsamplename1,reqsamplename2,reqsamplename3,reqsamplename4,reqsamplename5,reqsamplename6,reqsamplename7,reqsamplename8,reqsamplename9,reqsamplename10,reqsamplename11,reqsamplename12" +
                        $" from tbl_recipe where id = \"{rcpid}\"";

                    Dictionary<string, string> row = msdto.SelectSql2(sql, "name", "method", "mtime", "roidiameter", "patternid", "settemp", "sethumi", "calibid", "reqmbid1", "reqmbid2", "reqmbid3", "reqmbid4", "reqmbid5", "reqmbid6", "reqmbid7", "reqmbid8", "reqmbid9", "reqmbid10", "reqmbid11", "reqmbid12",
                       "reqmbname1", "reqmbname2", "reqmbname3", "reqmbname4", "reqmbname5", "reqmbname6", "reqmbname7", "reqmbname8", "reqmbname9", "reqmbname10", "reqmbname11", "reqmbname12",
                       "reqsampleid1", "reqsampleid2", "reqsampleid3", "reqsampleid4", "reqsampleid5", "reqsampleid6", "reqsampleid7", "reqsampleid8", "reqsampleid9", "reqsampleid10", "reqsampleid11", "reqsampleid12",
                       "reqsamplename1", "reqsamplename2", "reqsamplename3", "reqsamplename4", "reqsamplename5", "reqsamplename6", "reqsamplename7", "reqsamplename8", "reqsamplename9", "reqsamplename10", "reqsamplename11", "reqsamplename12")[0];
                    string calibid = row["calibid"];
                    //CheckCalibID(calibid);
                    if (row != null)
                    {


                        cTbl_recipe.name = row["name"];
                        cTbl_recipe.method = row["method"];
                        cTbl_recipe.mtime = row["mtime"];
                        cTbl_recipe.pattern = row["patternid"];
                        cTbl_recipe.calibid = row["calibid"];
                        cTbl_recipe.settemp = row["settemp"];
                        cTbl_recipe.sethumi = row["sethumi"];

                        Measure.iAcqCountMax = Convert.ToInt32(cTbl_recipe.mtime);//recipe mtime-> acqtime
                        double a = Measure.iAcqCountMax;
                        double b = Measure.iAcqUpdateStep;
                        double c = a / b;
                        Measure.iAcqCountMax = (int)System.Math.Truncate(c);

                        int valueIndex = 3;

                        string strSpaceEmpty = "    ";
                        fgCallRecipe[1, valueIndex] = strSpaceEmpty + Measure.mbid;
                        fgCallRecipe[2, valueIndex] = strSpaceEmpty + cTbl_recipe.name;
                        fgCallRecipe[3, valueIndex] = strSpaceEmpty + cTbl_recipe.method;
                        fgCallRecipe[4, valueIndex] = strSpaceEmpty + cTbl_recipe.mtime;
                        fgCallRecipe[5, valueIndex] = strSpaceEmpty + cTbl_recipe.settemp;
                        fgCallRecipe[6, valueIndex] = strSpaceEmpty + cTbl_recipe.sethumi;
                        fgCallRecipe[7, valueIndex] = strSpaceEmpty + cTbl_recipe.pattern;
                        fgCallRecipe[8, valueIndex] = strSpaceEmpty + cTbl_recipe.calibid;

                        for (int i = 1; i <= 12; i++)
                        {
                            fgReqInfo[i, 3] = row["reqmbname" + i].ToString();
                            fgReqInfo[i, 4] = row["reqmbid" + i].ToString();
                            fgReqInfo[i, 5] = row["reqsamplename" + i].ToString();
                            fgReqInfo[i, 6] = row["reqsampleid" + i].ToString();
                        }

                    }

                    sql = $"select ch1_name,ch2_name,ch3_name,ch4_name,ch5_name,ch6_name,ch7_name,ch8_name,ch9_name,ch10_name,ch11_name,ch12_name, ch1_unit,ch2_unit,ch3_unit,ch4_unit,ch5_unit,ch6_unit,ch7_unit,ch8_unit,ch9_unit,ch10_unit,ch11_unit,ch12_unit from tbl_plc_calibration, (select @num:= 0) as s where id ='{cTbl_recipe.calibid}' ";
                    Dictionary<string, string> rowcal = msdto.SelectSql2(sql, "ch1_name", "ch2_name", "ch3_name", "ch4_name", "ch5_name", "ch6_name", "ch7_name", "ch8_name", "ch9_name", "ch10_name", "ch11_name", "ch12_name")[0];
                    Dictionary<string, string> ch_unit = msdto.SelectSql2(sql, "ch1_unit", "ch2_unit", "ch3_unit", "ch4_unit", "ch5_unit", "ch6_unit", "ch7_unit", "ch8_unit", "ch9_unit", "ch10_unit", "ch11_unit", "ch12_unit")[0];


                    if (rowcal != null && ch_unit != null)
                    {

                        bool isUpdate_fgDataGrid = true;//--[데이터] update
                        bool isUpdate_fcDataChart = true;//--[스펙트럼] update
                        string[] plcAiNameList = null;
                        if (isUpdate_fcDataChart)
                        {
                            plcAiNameList = new string[12];
                        }

                        for (int i = 1; i <= 12; i++)
                        {
                            string chName = rowcal["ch" + i.ToString() + "_name"].ToString();
                            fgReqInfo[i, 2] = chName;
                            if (isUpdate_fgDataGrid) { fgDataGrid[0, i + 6] = chName; }
                            if (isUpdate_fcDataChart) { plcAiNameList[(i - 1)] = chName; }
                        }



                        //fgDataGrid.Cols[7].Caption = rowcal["ch1_name"] + " (" + ch_unit["ch1_unit"] + ")";
                        //fgDataGrid.Cols[8].Caption = rowcal["ch2_name"] + " (" + ch_unit["ch2_unit"] + ")";
                        //fgDataGrid.Cols[9].Caption = rowcal["ch3_name"] + " (" + ch_unit["ch3_unit"] + ")";
                        //fgDataGrid.Cols[11].Caption = rowcal["ch5_name"] + " (" + ch_unit["ch5_unit"] + ")";
                        //fgDataGrid.Cols[10].Caption = rowcal["ch4_name"] + " (" + ch_unit["ch4_unit"] + ")";
                        //fgDataGrid.Cols[12].Caption = rowcal["ch6_name"] + " (" + ch_unit["ch6_unit"] + ")";
                        //fgDataGrid.Cols[13].Caption = rowcal["ch7_name"] + " (" + ch_unit["ch7_unit"] + ")";
                        //fgDataGrid.Cols[14].Caption = rowcal["ch8_name"] + " (" + ch_unit["ch8_unit"] + ")";
                        //fgDataGrid.Cols[15].Caption = rowcal["ch9_name"] + " (" + ch_unit["ch9_unit"] + ")";
                        //fgDataGrid.Cols[16].Caption = rowcal["ch10_name"] + " (" + ch_unit["ch10_unit"] + ")";
                        //fgDataGrid.Cols[17].Caption = rowcal["ch11_name"] + " (" + ch_unit["ch11_unit"] + ")";
                        //fgDataGrid.Cols[18].Caption = rowcal["ch12_name"] + " (" + ch_unit["ch12_unit"] + ")";

                        //plcAiNameList[0] = rowcal["ch1_name"]; plcAiNameList[4] = rowcal["ch5_name"]; plcAiNameList[8] = rowcal["ch9_name"];
                        //plcAiNameList[1] = rowcal["ch2_name"]; plcAiNameList[5] = rowcal["ch6_name"]; plcAiNameList[9] = rowcal["ch10_name"];
                        //plcAiNameList[2] = rowcal["ch3_name"]; plcAiNameList[6] = rowcal["ch7_name"]; plcAiNameList[10] = rowcal["ch11_name"];
                        //plcAiNameList[3] = rowcal["ch4_name"]; plcAiNameList[7] = rowcal["ch8_name"]; plcAiNameList[11] = rowcal["ch12_name"];

                        fgDataGrid.Cols[7].Caption = plcAiNameList[0] + " (" + ch_unit["ch1_unit"] + ")";
                        fgDataGrid.Cols[8].Caption = plcAiNameList[1] + " (" + ch_unit["ch2_unit"] + ")";
                        fgDataGrid.Cols[9].Caption = plcAiNameList[2] + " (" + ch_unit["ch3_unit"] + ")";
                        fgDataGrid.Cols[11].Caption = plcAiNameList[3] + " (" + ch_unit["ch5_unit"] + ")";
                        fgDataGrid.Cols[10].Caption = plcAiNameList[4] + " (" + ch_unit["ch4_unit"] + ")";
                        fgDataGrid.Cols[12].Caption = plcAiNameList[5] + " (" + ch_unit["ch6_unit"] + ")";
                        fgDataGrid.Cols[13].Caption = plcAiNameList[6] + " (" + ch_unit["ch7_unit"] + ")";
                        fgDataGrid.Cols[14].Caption = plcAiNameList[7] + " (" + ch_unit["ch8_unit"] + ")";
                        fgDataGrid.Cols[15].Caption = plcAiNameList[8] + " (" + ch_unit["ch9_unit"] + ")";
                        fgDataGrid.Cols[16].Caption = plcAiNameList[9] + " (" + ch_unit["ch10_unit"] + ")";
                        fgDataGrid.Cols[17].Caption = plcAiNameList[10] + " (" + ch_unit["ch11_unit"] + ")";
                        fgDataGrid.Cols[18].Caption = plcAiNameList[11] + " (" + ch_unit["ch12_unit"] + ")";


                        ResetChartSeries(hmiNameList: null, plcAiNameList: plcAiNameList, plcAoNameList: null, plcDiNameList: null, plcDoNameList: null);



                        //Hmi 캘리브레이션 값 적용 확인

                        if (Measure.IsPlcUse)
                        {
                            if (string.IsNullOrEmpty(m_strNowCalibId))
                            {
                                m_strNowCalibId = cTbl_recipe.calibid;
                                m_isChangedCalibName = true;
                            }

                            else
                            {
                                m_isChangedCalibName = true;
                            }

                            if (m_isChangedCalibName)//Calib 가 변경되었다면, plc에 업데이트
                            {
                                SettingPlcCalibrationDatas(cTbl_recipe.calibid);

                            }

                        }
                        for (int i = 1; i <= 12; i++)
                        {
                            if (row["reqmbname" + i] == "미지정")
                            {
                                this.fcDataChart.Series[i + 3].Visibility = SeriesVisibility.Hidden;
                            }
                        }
                        for (int i = 16; i < 24; i++)
                        {
                            this.fcDataChart.Series[i].Visibility = SeriesVisibility.Legend;
                        }
                    }
                    else if (rw.ShowDialog() == DialogResult.Cancel)
                    {
                        lblShowStatus.Text = "[01] 레시피를 선택하세요.";
                    }

                    //-----레시피 설정완료 중
                    lblShowStatus.Text = "[02] 챔버 측정 모드를 선택하세요.";
                    cLog.Info(cMwlog.RecipeChooseEventLog);
                    LogBoxAdd(logbox_title, "완료");
                    _mMeasureStep.iStep1_rcp = (int)Status.end;
                    SetStep1ControlEventHandler(true);
                    iNowMeasurementType = 0;
                    chamber_repeat = 0;
                    SetNewMeasureID();
                    lblrcp.BackColor = Color.FromArgb(68, 114, 196);


                    //-----레시피 설정완료 후
                    if (CommonClass.isMacroOn && CommonClass.isMacroNextRun)
                    {
                        SetMacroOpMode();
                        BtnMeasureStart_Click(sender, e);
                    }
                }
                else
                {
                    lblShowStatus.Text = "[01] 레시피를 선택하세요.";
                    LogBoxAdd(logbox_title, "취소");
                    SetStep1ControlEventHandler(false);
                    lblrcp.BackColor = Color.FromArgb(217, 217, 217);
                }
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
                SetStep1ControlEventHandler(false);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void SettingPlcCalibrationDatas(string id)
        {
            if (FrmPlcSensor.mIns == null) return;

            string sql = $"select  * "
                     + $"from tbl_plc_calibration as s where id=\"{id}\" ";
            DataTable dt = msdto.SelectSqlToDataTable(sql);

            if (dt == null) return;
            if (dt.Rows.Count > 0)
            {
                string[] ch1 = new string[20];
                string[] ch2 = new string[20];
                string[] ch3 = new string[20];
                string[] ch4 = new string[4];
                string[] ch5 = new string[4];
                string[] ch6 = new string[4];
                string[] ch7 = new string[4];
                string[] ch8 = new string[4];
                string[] ch9 = new string[4];
                string[] ch10 = new string[4];
                string[] ch11 = new string[4];
                string[] ch12 = new string[4];


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int col = 0; col < dt.Columns.Count; col++)
                    {
                        string getColName = dt.Columns[col].ColumnName;
                        string getValue = dt.Rows[i][col].ToString();
                        switch (getColName)
                        {
                            case "calno": cTbl_calib.calno = getValue; break;    //calno,5
                            case "id": cTbl_calib.id = getValue; break;    //id,C1
                            case "no": cTbl_calib.no = getValue; break;    //no, C1
                            case "name": cTbl_calib.name = getValue; break;    //name,CN테스트1
                            case "use10": cTbl_calib.use10 = getValue; break;    //use10,1
                            case "regdate": cTbl_calib.regdate = getValue; break;    //regdate,2023 - 05 - 25 오후 2:45:35
                            case "updatedate": cTbl_calib.updatedate = getValue; break;    //updatedate,

                            case "ch1_plc_min1": cTbl_calib.ch1_plc_min1 = getValue; ch1[0] = getValue; break;    //ch1_plc_min1,0
                            case "ch1_plc_max1": cTbl_calib.ch1_plc_max1 = getValue; ch1[1] = getValue; break;    //ch1_plc_max1,800
                            case "ch1_plc_min2": cTbl_calib.ch1_plc_min2 = getValue; ch1[2] = getValue; break;    //ch1_plc_min2,801
                            case "ch1_plc_max2": cTbl_calib.ch1_plc_max2 = getValue; ch1[3] = getValue; break;    //ch1_plc_max2,1600
                            case "ch1_plc_min3": cTbl_calib.ch1_plc_min3 = getValue; ch1[4] = getValue; break;    //ch1_plc_min3,1601
                            case "ch1_plc_max3": cTbl_calib.ch1_plc_max3 = getValue; ch1[5] = getValue; break;    //ch1_plc_max3,2400
                            case "ch1_plc_min4": cTbl_calib.ch1_plc_min4 = getValue; ch1[6] = getValue; break;    //ch1_plc_min4,2401
                            case "ch1_plc_max4": cTbl_calib.ch1_plc_max4 = getValue; ch1[7] = getValue; break;    //ch1_plc_max4,3200
                            case "ch1_plc_min5": cTbl_calib.ch1_plc_min5 = getValue; ch1[8] = getValue; break;    //ch1_plc_min5,3201
                            case "ch1_plc_max5": cTbl_calib.ch1_plc_max5 = getValue; ch1[9] = getValue; break;    //ch1_plc_max5,4000
                            case "ch1_pc_min1": cTbl_calib.ch1_pc_min1 = getValue; ch1[10] = Measure.PlcMultiple(getValue); break;    //ch1_pc_min1,0
                            case "ch1_pc_max1": cTbl_calib.ch1_pc_max1 = getValue; ch1[11] = Measure.PlcMultiple(getValue); break;    //ch1_pc_max1,2
                            case "ch1_pc_min2": cTbl_calib.ch1_pc_min2 = getValue; ch1[12] = Measure.PlcMultiple(getValue); break;    //ch1_pc_min2,2.1
                            case "ch1_pc_max2": cTbl_calib.ch1_pc_max2 = getValue; ch1[13] = Measure.PlcMultiple(getValue); break;    //ch1_pc_max2,4
                            case "ch1_pc_min3": cTbl_calib.ch1_pc_min3 = getValue; ch1[14] = Measure.PlcMultiple(getValue); break;    //ch1_pc_min3,4.1
                            case "ch1_pc_max3": cTbl_calib.ch1_pc_max3 = getValue; ch1[15] = Measure.PlcMultiple(getValue); break;    //ch1_pc_max3,6
                            case "ch1_pc_min4": cTbl_calib.ch1_pc_min4 = getValue; ch1[16] = Measure.PlcMultiple(getValue); break;    //ch1_pc_min4,6.1
                            case "ch1_pc_max4": cTbl_calib.ch1_pc_max4 = getValue; ch1[17] = Measure.PlcMultiple(getValue); break;    //ch1_pc_max4,8
                            case "ch1_pc_min5": cTbl_calib.ch1_pc_min5 = getValue; ch1[18] = Measure.PlcMultiple(getValue); break;    //ch1_pc_min5,8.1
                            case "ch1_pc_max5": cTbl_calib.ch1_pc_max5 = getValue; ch1[19] = Measure.PlcMultiple(getValue); break;    //ch1_pc_max5,10

                            case "ch2_plc_min1": cTbl_calib.ch2_plc_min1 = getValue; ch2[0] = getValue; break;     //ch2_plc_min1,0
                            case "ch2_plc_max1": cTbl_calib.ch2_plc_max1 = getValue; ch2[1] = getValue; break;    //ch2_plc_max1,800
                            case "ch2_plc_min2": cTbl_calib.ch2_plc_min2 = getValue; ch2[2] = getValue; break;     //ch2_plc_min2,801
                            case "ch2_plc_max2": cTbl_calib.ch2_plc_max2 = getValue; ch2[3] = getValue; break;   //ch2_plc_max2,1600
                            case "ch2_plc_min3": cTbl_calib.ch2_plc_min3 = getValue; ch2[4] = getValue; break;     //ch2_plc_min3,1601
                            case "ch2_plc_max3": cTbl_calib.ch2_plc_max3 = getValue; ch2[5] = getValue; break;    //ch2_plc_max3,2400
                            case "ch2_plc_min4": cTbl_calib.ch2_plc_min4 = getValue; ch2[6] = getValue; break;    //ch2_plc_min4,2401
                            case "ch2_plc_max4": cTbl_calib.ch2_plc_max4 = getValue; ch2[7] = getValue; break;    //ch2_plc_max4,3200
                            case "ch2_plc_min5": cTbl_calib.ch2_plc_min5 = getValue; ch2[8] = getValue; break;     //ch2_plc_min5,3201
                            case "ch2_plc_max5": cTbl_calib.ch2_plc_max5 = getValue; ch2[9] = getValue; break;     //ch2_plc_max5,4000
                            case "ch2_pc_min1": cTbl_calib.ch2_pc_min1 = getValue; ch2[10] = Measure.PlcMultiple(getValue); break;      //ch2_pc_min1,0
                            case "ch2_pc_max1": cTbl_calib.ch2_pc_max1 = getValue; ch2[11] = Measure.PlcMultiple(getValue); break;      //ch2_pc_max1,2
                            case "ch2_pc_min2": cTbl_calib.ch2_pc_min2 = getValue; ch2[12] = Measure.PlcMultiple(getValue); break;      //ch2_pc_min2,2.1
                            case "ch2_pc_max2": cTbl_calib.ch2_pc_max2 = getValue; ch2[13] = Measure.PlcMultiple(getValue); break;     //ch2_pc_max2,4
                            case "ch2_pc_min3": cTbl_calib.ch2_pc_min3 = getValue; ch2[14] = Measure.PlcMultiple(getValue); break;      //ch2_pc_min3,4.1
                            case "ch2_pc_max3": cTbl_calib.ch2_pc_max3 = getValue; ch2[15] = Measure.PlcMultiple(getValue); break;     //ch2_pc_max3,6
                            case "ch2_pc_min4": cTbl_calib.ch2_pc_min4 = getValue; ch2[16] = Measure.PlcMultiple(getValue); break;      //ch2_pc_min4,6.1
                            case "ch2_pc_max4": cTbl_calib.ch2_pc_max4 = getValue; ch2[17] = Measure.PlcMultiple(getValue); break;     //ch2_pc_max4,8
                            case "ch2_pc_min5": cTbl_calib.ch2_pc_min5 = getValue; ch2[18] = Measure.PlcMultiple(getValue); break;      //ch2_pc_min5,8.1
                            case "ch2_pc_max5": cTbl_calib.ch2_pc_max5 = getValue; ch2[19] = Measure.PlcMultiple(getValue); break;     //ch2_pc_max5,10

                            case "ch3_plc_min1": cTbl_calib.ch3_plc_min1 = getValue; ch3[0] = getValue; break;      //ch3_plc_min1,0
                            case "ch3_plc_max1": cTbl_calib.ch3_plc_max1 = getValue; ch3[1] = getValue; break;    //ch3_plc_max1,800
                            case "ch3_plc_min2": cTbl_calib.ch3_plc_min2 = getValue; ch3[2] = getValue; break;      //ch3_plc_min2,801
                            case "ch3_plc_max2": cTbl_calib.ch3_plc_max2 = getValue; ch3[3] = getValue; break;    //ch3_plc_max2,1600
                            case "ch3_plc_min3": cTbl_calib.ch3_plc_min3 = getValue; ch3[4] = getValue; break;      //ch3_plc_min3,1601
                            case "ch3_plc_max3": cTbl_calib.ch3_plc_max3 = getValue; ch3[5] = getValue; break;    //ch3_plc_max3,2400
                            case "ch3_plc_min4": cTbl_calib.ch3_plc_min4 = getValue; ch3[6] = getValue; break;      //ch3_plc_min4,2401
                            case "ch3_plc_max4": cTbl_calib.ch3_plc_max4 = getValue; ch3[7] = getValue; break;    //ch3_plc_max4,3200
                            case "ch3_plc_min5": cTbl_calib.ch3_plc_min5 = getValue; ch3[8] = getValue; break;      //ch3_plc_min5,3201
                            case "ch3_plc_max5": cTbl_calib.ch3_plc_max5 = getValue; ch3[9] = getValue; break;    //ch3_plc_max5,4000
                            case "ch3_pc_min1": cTbl_calib.ch3_pc_min1 = getValue; ch3[10] = Measure.PlcMultiple(getValue); break;       //ch3_pc_min1,0
                            case "ch3_pc_max1": cTbl_calib.ch3_pc_max1 = getValue; ch3[11] = Measure.PlcMultiple(getValue); break;      //ch3_pc_max1,2
                            case "ch3_pc_min2": cTbl_calib.ch3_pc_min2 = getValue; ch3[12] = Measure.PlcMultiple(getValue); break;       //ch3_pc_min2,2.1
                            case "ch3_pc_max2": cTbl_calib.ch3_pc_max2 = getValue; ch3[13] = Measure.PlcMultiple(getValue); break;      //ch3_pc_max2,4
                            case "ch3_pc_min3": cTbl_calib.ch3_pc_min3 = getValue; ch3[14] = Measure.PlcMultiple(getValue); break;       //ch3_pc_min3,4.1
                            case "ch3_pc_max3": cTbl_calib.ch3_pc_max3 = getValue; ch3[15] = Measure.PlcMultiple(getValue); break;      //ch3_pc_max3,6
                            case "ch3_pc_min4": cTbl_calib.ch3_pc_min4 = getValue; ch3[16] = Measure.PlcMultiple(getValue); break;       //ch3_pc_min4,6.1
                            case "ch3_pc_max4": cTbl_calib.ch3_pc_max4 = getValue; ch3[17] = Measure.PlcMultiple(getValue); break;      //ch3_pc_max4,8
                            case "ch3_pc_min5": cTbl_calib.ch3_pc_min5 = getValue; ch3[18] = Measure.PlcMultiple(getValue); break;       //ch3_pc_min5,8.1
                            case "ch3_pc_max5": cTbl_calib.ch3_pc_max5 = getValue; ch3[19] = Measure.PlcMultiple(getValue); break;      //ch3_pc_max5,10

                            case "ch4_plc_min1": cTbl_calib.ch4_plc_min1 = getValue; ch4[0] = getValue; break;    //ch4_plc_min1,0
                            case "ch4_plc_max1": cTbl_calib.ch4_plc_max1 = getValue; ch4[1] = getValue; break;    //ch4_plc_max1,4000
                            case "ch4_pc_min1": cTbl_calib.ch4_pc_min1 = getValue; ch4[2] = Measure.PlcMultiple(getValue); break;    //ch4_pc_min1,0
                            case "ch4_pc_max1": cTbl_calib.ch4_pc_max1 = getValue; ch4[3] = Measure.PlcMultiple(getValue); break;    //ch4_pc_max1,10

                            case "ch5_plc_min1": cTbl_calib.ch5_plc_min1 = getValue; ch5[0] = getValue; break;      //ch5_plc_min1,0
                            case "ch5_plc_max1": cTbl_calib.ch5_plc_max1 = getValue; ch5[1] = getValue; break;    //ch5_plc_max1,4000
                            case "ch5_pc_min1": cTbl_calib.ch5_pc_min1 = getValue; ch5[2] = Measure.PlcMultiple(getValue); break;       //ch5_pc_min1,0
                            case "ch5_pc_max1": cTbl_calib.ch5_pc_max1 = getValue; ch5[3] = Measure.PlcMultiple(getValue); break;      //ch5_pc_max1,10

                            case "ch6_plc_min1": cTbl_calib.ch6_plc_min1 = getValue; ch6[0] = getValue; break;     //ch6_plc_min1,0
                            case "ch6_plc_max1": cTbl_calib.ch6_plc_max1 = getValue; ch6[1] = getValue; break;   //ch6_plc_max1,4000
                            case "ch6_pc_min1": cTbl_calib.ch6_pc_min1 = getValue; ch6[2] = Measure.PlcMultiple(getValue); break;      //ch6_pc_min1,0
                            case "ch6_pc_max1": cTbl_calib.ch6_pc_max1 = getValue; ch6[3] = Measure.PlcMultiple(getValue); break;     //ch6_pc_max1,10

                            case "ch7_plc_min1": cTbl_calib.ch7_plc_min1 = getValue; ch7[0] = getValue; break;      //ch7_plc_min1,0
                            case "ch7_plc_max1": cTbl_calib.ch7_plc_max1 = getValue; ch7[1] = getValue; break;    //ch7_plc_max1,4000
                            case "ch7_pc_min1": cTbl_calib.ch7_pc_min1 = getValue; ch7[2] = Measure.PlcMultiple(getValue); break;       //ch7_pc_min1,0
                            case "ch7_pc_max1": cTbl_calib.ch7_pc_max1 = getValue; ch7[3] = Measure.PlcMultiple(getValue); break;      //ch7_pc_max1,10

                            case "ch8_plc_min1": cTbl_calib.ch8_plc_min1 = getValue; ch8[0] = getValue; break;       //ch8_plc_min1,0
                            case "ch8_plc_max1": cTbl_calib.ch8_plc_max1 = getValue; ch8[1] = getValue; break;     //ch8_plc_max1,4000
                            case "ch8_pc_min1": cTbl_calib.ch8_pc_min1 = getValue; ch8[2] = Measure.PlcMultiple(getValue); break;        //ch8_pc_min1,0
                            case "ch8_pc_max1": cTbl_calib.ch8_pc_max1 = getValue; ch8[3] = Measure.PlcMultiple(getValue); break;       //ch8_pc_max1,10

                            case "ch9_plc_min1": cTbl_calib.ch9_plc_min1 = getValue; ch9[0] = getValue; break;       //ch9_plc_min1,0
                            case "ch9_plc_max1": cTbl_calib.ch9_plc_max1 = getValue; ch9[1] = getValue; break;     //ch9_plc_max1,4000
                            case "ch9_pc_max1": cTbl_calib.ch9_pc_max1 = getValue; ch9[3] = Measure.PlcMultiple(getValue); break;       //ch9_pc_max1,10
                            case "ch9_pc_min1": cTbl_calib.ch9_pc_min1 = getValue; ch9[2] = Measure.PlcMultiple(getValue); break;        //ch9_pc_min1,0

                            case "ch10_plc_min1": cTbl_calib.ch10_plc_min1 = getValue; ch10[0] = getValue; break;       //ch10_plc_min1,0
                            case "ch10_plc_max1": cTbl_calib.ch10_plc_max1 = getValue; ch10[1] = getValue; break;     //ch10_plc_max1,4000
                            case "ch10_pc_min1": cTbl_calib.ch10_pc_min1 = getValue; ch10[2] = Measure.PlcMultiple(getValue); break;        //ch10_pc_min1,0
                            case "ch10_pc_max1": cTbl_calib.ch10_pc_max1 = getValue; ch10[3] = Measure.PlcMultiple(getValue); break;       //ch10_pc_max1,10

                            case "ch11_plc_min1": cTbl_calib.ch11_plc_min1 = getValue; ch11[0] = getValue; break;       //ch11_plc_min1,0
                            case "ch11_plc_max1": cTbl_calib.ch11_plc_max1 = getValue; ch11[1] = getValue; break;     //ch11_plc_max1,4000
                            case "ch11_pc_max1": cTbl_calib.ch11_pc_max1 = getValue; ch11[3] = Measure.PlcMultiple(getValue); break;       //ch11_pc_max1,10
                            case "ch11_pc_min1": cTbl_calib.ch11_pc_min1 = getValue; ch11[2] = Measure.PlcMultiple(getValue); break;        //ch11_pc_min1,0

                            case "ch12_plc_min1": cTbl_calib.ch12_plc_min1 = getValue; ch12[0] = getValue; break;       //ch12_plc_min1,0
                            case "ch12_plc_max1": cTbl_calib.ch12_plc_max1 = getValue; ch12[1] = getValue; break;     //ch12_plc_max1,4000
                            case "ch12_pc_min1": cTbl_calib.ch12_pc_min1 = getValue; ch12[2] = Measure.PlcMultiple(getValue); break;        //ch12_pc_min1,0
                            case "ch12_pc_max1": cTbl_calib.ch12_pc_max1 = getValue; ch12[3] = Measure.PlcMultiple(getValue); break;       //ch12_pc_max1,10

                            case "ch1_name": cTbl_calib.ch1_name = getValue; break;    //ch1_name,AI01
                            case "ch2_name": cTbl_calib.ch2_name = getValue; break;    //ch2_name, AI02
                            case "ch3_name": cTbl_calib.ch3_name = getValue; break;    //ch3_name,AI03
                            case "ch4_name": cTbl_calib.ch4_name = getValue; break;    //ch4_name, AI04
                            case "ch5_name": cTbl_calib.ch5_name = getValue; break;    //ch5_name,AI05
                            case "ch6_name": cTbl_calib.ch6_name = getValue; break;    //ch6_name, AI06
                            case "ch7_name": cTbl_calib.ch7_name = getValue; break;    //ch7_name,AI07
                            case "ch8_name": cTbl_calib.ch8_name = getValue; break;    //ch8_name, AI08
                            case "ch9_name": cTbl_calib.ch9_name = getValue; break;    //ch9_name,AI09
                            case "ch10_name": cTbl_calib.ch10_name = getValue; break;    //ch10_name, AI10
                            case "ch11_name": cTbl_calib.ch11_name = getValue; break;    //ch11_name,AI11
                            case "ch12_name": cTbl_calib.ch12_name = getValue; break;    //ch12_name, AI12

                            case "ch1_unit": cTbl_calib.ch1_unit = getValue; break;    //ch1_unit,AI01
                            case "ch2_unit": cTbl_calib.ch2_unit = getValue; break;    //ch2_unit, AI02
                            case "ch3_unit": cTbl_calib.ch3_unit = getValue; break;    //ch3_unit,AI03
                            case "ch4_unit": cTbl_calib.ch4_unit = getValue; break;    //ch4_unit, AI04
                            case "ch5_unit": cTbl_calib.ch5_unit = getValue; break;    //ch5_unit,AI05
                            case "ch6_unit": cTbl_calib.ch6_unit = getValue; break;    //ch6_unit, AI06
                            case "ch7_unit": cTbl_calib.ch7_unit = getValue; break;    //ch7_unit,AI07
                            case "ch8_unit": cTbl_calib.ch8_unit = getValue; break;    //ch8_unit, AI08
                            case "ch9_unit": cTbl_calib.ch9_unit = getValue; break;    //ch9_unit,AI09
                            case "ch10_unit": cTbl_calib.ch10_unit = getValue; break;    //ch10_unit, AI10
                            case "ch11_unit": cTbl_calib.ch11_unit = getValue; break;    //ch11_unit,AI11
                            case "ch12_unit": cTbl_calib.ch12_unit = getValue; break;    //ch12_unit, AI12


                        }
                    }//end for
                }//end for
                if (FrmPlcSensor.mIns.SetChAi_1_12(ch1, ch2, ch3, ch4, ch5, ch6, ch7, ch8, ch9, ch10, ch11, ch12))
                {
                    FrmPlcSensor.mIns.WritePlcChAi_1_12();
                }

                PLCController.mIns.MemSetPlcCalibParams(cTbl_calib);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            lblShowStatus.Text = "[05] 테스트 결과보기를 시작합니다.";
            //this.rcpname = rcpname;
            reqmbname = fgReqInfo[1, 3].ToString();
            msid = measureidText;
            mbid = Measure.mbid;

            bool isOk = false;
            System.Windows.Controls.Button btn = sender as System.Windows.Controls.Button;
            string logbox_title = btnExport.Text.ToString();
            bool isCheckOk;
            LogBoxAdd(logbox_title, "시작");
            if (CommonClass.isMacroOn)
            {

            }
            else
            {
                string strBtnName;

                if (IsManualRunOn)
                {
                    if (fgCallRecipe[0, 2] == null)
                        isCheckOk = false;
                    else
                        isCheckOk = !(string.IsNullOrEmpty(fgCallRecipe[0, 2].ToString()));
                    if (isCheckOk == false)
                    {
                        strBtnName = "레시피 선택";
                        System.Windows.MessageBox.Show(strBtnName + "를 완료되지 않았습니다.", btn.Content.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);
                        LogBoxAdd(logbox_title, "취소");
                        return;
                    }
                    if (isCheckOk == false)
                    {
                        strBtnName = "A1 챔버측정 또는 A2 챔버측정";
                        System.Windows.MessageBox.Show(strBtnName + "를 완료되지 않았습니다.", btn.Content.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);
                        LogBoxAdd(logbox_title, "취소");
                        return;
                    }


                }
                else
                {

                    if (System.Windows.MessageBox.Show(" 테스트 결과보기 하시겠습니까?", "테스트 결과보기", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                    {
                        LogBoxAdd(logbox_title, "취소");
                        lblShowStatus.Text = "[05] 테스트 결과보기를 선택 하세요.";
                        return;
                    }
                }

            }
            ExportPDF.FrmMain exportwindow;
            try
            {
                exportwindow = new ExportPDF.FrmMain(msid: msid, ms_mbid: mbid, reqmbname: reqmbname, rcpname: rcpname);

                if (exportwindow != null)
                {
                    lblShowStatus.Text = "[05] 테스트 결과보기 중입니다.";
                    lblresult.BackColor = Color.FromArgb(255, 255, 0);
                    if (exportwindow.ShowDialog() == DialogResult.OK)
                    {
                        lblShowStatus.Text = "";
                        Color brush = ColorTranslator.FromHtml("#727CF5");
                        btnExport.BackgroundColor = brush;
                        SetStep6ControlEventHandler(true);
                        isOk = true;
                    }
                    else
                    {
                        isOk = false;
                    }
                }

            }
            catch (Exception exc)
            {
                isOk = false;
                System.Diagnostics.Debug.WriteLine(exc.ToString());
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }
            finally
            {
                cLog.Info(cMwlog.TestResultClickEventLog);
                exportwindow = null;
                if (isOk)
                {
                    lblShowStatus.Text = "[05] 테스트 결과보기가 완료 되었습니다.";
                    lblresult.BackColor = Color.FromArgb(68, 114, 196);
                    LogBoxAdd(logbox_title, "완료");
                }
                else
                { LogBoxAdd(logbox_title, "취소"); lblShowStatus.Text = ""; }
            }

        }

        private void SetStep6ControlEventHandler(bool v)
        {
            if (v)
            {
                _mMeasureStep.id = 6;
            }
            //버튼 다열기
            IsEnabledButton(true);
            //결과보기 활성화
            btnExport.Enabled = v;
            //무게저울2 완료
            Color brush = ColorTranslator.FromHtml("#727CF5");
            btnMeasureStart.BackgroundColor = brush;

            _mMeasureStep.iStep6_result_report = v == true ? (int)Status.end : (int)Status.not_set;
        }

        private void IsEnabledButton(bool value)
        {
            ButtonsColorBlock(value);
            btnRunModeAtMt.Enabled = value;
            btnrcp.Enabled = value;
            btnMeasureStart.Enabled = value;
            btnFixModeOn.Enabled = value;
            btnPatternModeOn.Enabled = value;
            btnChamberStart.Enabled = value;
            btnExport.Enabled = value;
            DoMeasureMSC.MainWindow.mIns.MWEnabledButton(value);

        }

        private void ButtonsColorBlock(bool value)
        {
            var bgColor = value ? Color.FromArgb(7, 154, 114) : Color.FromArgb(217, 217, 217);

            btnRunModeAtMt.BackColor = bgColor;
            btnrcp.BackColor = bgColor;
            btnMeasureStart.BackColor = bgColor;
            btnFixModeOn.BackColor = bgColor;
            btnPatternModeOn.BackColor = bgColor;
            btnChamberStart.BackColor = bgColor;
            btnExport.BackColor = bgColor;

        }

        enum MeasureUnitFlag
        {
            NewMeasure = 0,//  "신규측정"
            RetryMeasure = 1,// "재측정"
            Error = 9999,//"Error"
        }


        private void BtnMeasureStart_Click(object sender, EventArgs e)
        {
            try
            {
                #region //측정 준비
                this.fgDataGrid.Rows.Count = 101;
                lblmstart.BackColor = Color.FromArgb(255, 255, 0);
                flag100000 = 0;

                //측정준비
                System.Windows.Controls.Button btn = sender as System.Windows.Controls.Button;
                string logbox_title = btnMeasureStart.Text.ToString();
                m_logbox_title = logbox_title;
                LogBoxAdd(logbox_title, "시작");

                _mMeasureStep.iStep2_a1_chamber = (int)Status.not_set;


                if (CommonClass.isMacroOn == true)
                {

                    CommonClass.isMacroStop = false;

                }
                else
                {
                    if (_mMeasureStep.iStep1_rcp == (int)Status.not_set)
                    {
                        System.Windows.MessageBox.Show("1. 레시피를 선택하세요.", logbox_title, MessageBoxButton.OK, MessageBoxImage.Information);
                        LogBoxAdd(logbox_title, "취소");
                        lblmstart.BackColor = Color.FromArgb(217, 217, 217);
                        return;
                    }

                    if (System.Windows.MessageBox.Show("챔버안에 샘플을 확인하세요.\r\n[" + logbox_title + "] 진행 하시겠습니까?", logbox_title, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                    {
                        LogBoxAdd(logbox_title, "취소");
                        lblmstart.BackColor = Color.FromArgb(217, 217, 217);
                        lblShowStatus.Text = "";
                        return;
                    }
                }

                iAcqCount = 0;
                iAcqCountMax = Measure.iAcqCountMax;
                measurediv = "c1";
                //측정, 재측정 판단
                int iFlag = CheckMeasureProcChamberA1A2();

                if (iFlag == (int)MeasureUnitFlag.Error)
                    return;


                if (CommonClass.isMacroOn && CommonClass.isMacroNextRun)
                {

                    if (chamber_repeat >= 1)
                    {
                        LogBoxAdd(logbox_title, "챔버 매크로 재측정시작");
                        iNowMeasurementType = (int)MeasurementType.Retry;
                    }
                    else
                    {
                        LogBoxAdd(logbox_title, "챔버 매크로 신규측정시작");
                        iNowMeasurementType = (int)MeasurementType.New;
                    }
                }
                else
                {
                    if (iFlag == (int)MeasureUnitFlag.RetryMeasure)
                    {
                        if (System.Windows.MessageBox.Show("샘플을 재측정하시겠습니까?", logbox_title, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                        {
                            LogBoxAdd(logbox_title, "취소");
                            lblShowStatus.Text = "";
                            return;
                        }
                        else
                        {
                            LogBoxAdd(logbox_title, "챔버 재측정시작");
                            cLog.Info(cMwlog.MeasureReStartClickEventLog);
                            iNowMeasurementType = (int)MeasurementType.Retry;
                            //iFlag = CheckMeasureProcChamberA1A2();
                        }
                    }
                    else if (iFlag == (int)MeasureUnitFlag.NewMeasure)
                    {
                        if (System.Windows.MessageBox.Show("샘플측정 하시겠습니까?", logbox_title, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                        {
                            LogBoxAdd(logbox_title, "취소");
                            lblmstart.BackColor = Color.FromArgb(217, 217, 217);
                            lblShowStatus.Text = "";
                            return;
                        }
                        else
                        {
                            LogBoxAdd(logbox_title, "챔버 측정시작");
                            iNowMeasurementType = (int)MeasurementType.New;
                            cLog.Info(cMwlog.MeasureStartClickEventLog);

                        }
                    }
                }

                //버튼 다막기
                IsEnabledButton(false);
                //IsEnabledButton(true);
                fgMeasureBaseInfo.Cols[3].AllowEditing = false;
                ChamberA1Settings();
                ResetChartData_fcDataChart();
                m_strAcqStdTime = string.Empty;
                //----Hmi 정치, 패턴 모드 확인


                hmi_data_md1avg = 0.0f;
                hmi_data_md2avg = 0.0f;
                hmi_data_md3avg = 0.0f;
                hmi_data_md4avg = 0.0f;
                hmi_data_ai01avg = 0.0f;
                hmi_data_ai02avg = 0.0f;
                hmi_data_ai03avg = 0.0f;
                hmi_data_ai04avg = 0.0f;
                hmi_data_ai05avg = 0.0f;
                hmi_data_ai06avg = 0.0f;
                hmi_data_ai07avg = 0.0f;
                hmi_data_ai08avg = 0.0f;
                hmi_data_ai09avg = 0.0f;
                hmi_data_ai10avg = 0.0f;
                hmi_data_ai11avg = 0.0f;
                hmi_data_ai12avg = 0.0f;
                hmi_data_ao01avg = 0.0f;
                hmi_data_ao02avg = 0.0f;
                hmi_data_di01avg = 0.0f;
                hmi_data_di02avg = 0.0f;
                hmi_data_di03avg = 0.0f;
                hmi_data_di04avg = 0.0f;
                hmi_data_do01avg = 0.0f;
                hmi_data_do02avg = 0.0f;

                #endregion //측정 준비

                #region //측정 진행
                //측정, 재측정 시작

                lblShowStatus.Text = "[04] " + mode + " 샘플 측정 중입니다";
                //버튼 다막기
                IsEnabledButton(false);
                //IsEnabledButton(true) ;
                fgDataGrid.Cols[1].Style.Font = new Font("나눔고딕", 12, FontStyle.Regular);
                BwChamberMeasureThead1_Start();
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.ToString(), "DoMeasureMSC");
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }

            #endregion //측정 진행

        }


        private void BtnSampleMeasureStop_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = sender as System.Windows.Forms.Button;
            string logbox_title = btn.Text.ToString();

            try
            {
                LogBoxAdd(logbox_title, "시작");
                if (System.Windows.MessageBox.Show(btn.Text.ToString() + " 하시겠습니까?", btn.Text.ToString(), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                {
                    LogBoxAdd(logbox_title, "취소");

                    return;
                }
                lblShowStatus.Text = "샘플 측정 중지";
                isChamberLoop = false;
                BwChamberMeasureThead1_Stop();
                cLog.Info(cMwlog.MeasureStopClickEventLog);
                CalcuChamberTimer();
                DateTime dateTime = m_runningTime;
                string strT1 = dateTime.ToString("yyMMddHHmmss");

                LogBoxAdd(logbox_title, "완료", strT1);
                IsEnabledButton(true);
                if (msdto.IsOpened())
                    msdto.Close();

                CommonClass.isMacroStop = true;
                if (CommonClass.isMacroOn)
                {
                    LogBoxAdd(logbox_title, "자동테스트중지");
                }

            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.ToString(), "DoMeasureMSC");
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }

        }

        private void BwChamberMeasureThead1_Start()
        {
            InitializeMeasureThread();
            bwChamberMeasureThead1.Start();

        }
        //================추가 이벤트=============================================================================

        public void LogBoxAdd(string title, string content)
        {
            if (logbox.Items.Count > 10)
            {
                logbox.Items.Clear();

            }
            DateTime dateTime = DateTime.Now;
            string str1 = dateTime.ToString("yyMMddHHmmss");
            logbox.Items.Add(str1 + "_" + title + "_" + content);
            logbox.SelectedIndex = logbox.Items.Count - 1;
        }

        public void LogBoxAdd(string title, string content, string dtime)
        {
            if (logbox.Items.Count > 10)
            {
                logbox.Items.Clear();

            }
            logbox.Items.Add(dtime + "_" + title + "_" + content);
            logbox.SelectedIndex = logbox.Items.Count - 1;
        }

        private void ChamberRunColor()
        {
            if (Measure.IsChamberRunOn10 == 1)//가동시작
            {
                btnChamberStart.BackgroundColor = Color.FromArgb(7, 154, 114);
                btnChamberStop.BackgroundColor = Color.FromArgb(242, 78, 77);//빨강
            }
            else
            {
                btnChamberStart.BackgroundColor = Color.FromArgb(217, 217, 217);
                btnChamberStop.BackgroundColor = Color.FromArgb(242, 78, 77);//빨강
            }
        }

        private bool ChamberRunningStart()
        {
            bool isRtn;
            try
            {
                Measure.IsChamberRunOn10 = 1;
                ChamberRunColor();


                if (Measure.IsHmiUse)
                {
                    string OM_OPMODE = HMIController.mIns.GetD0010();

                    bool isHmiRunning = true;
                    if (OM_OPMODE.Equals("1"))//정치, 패턴모드 Stop 상태 //0x0001
                    {
                        isHmiRunning = false;

                    }
                    else if (OM_OPMODE.Equals("2"))//정치모드 Run 상태//0x0010
                    {
                        isHmiRunning = true;
                    }
                    else if (OM_OPMODE.Equals("4"))//패턴모드 Run 상태//0x0100
                    {
                        isHmiRunning = true;
                    }

                    if (isHmiRunning)
                        HMIController.mIns.SetD0101_4();

                    HMIController.mIns.SetD0101_1();

                    Task.Delay(100).GetAwaiter().GetResult();
                }

                isRtn = true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                cLog.Error("[" + this.Name + "]\r\n " + ex.ToString());
                isRtn = false;
            }

            return isRtn;
        }

        private void SetStep1ControlEventHandler(bool v)
        {
            if (v)
            {
                _mMeasureStep.id = 2;
            }

            //레시피 완료
            if (v == true)
            {
                btnMeasureStart.Enabled = v;
                btnSampleMeasureStop.Enabled = v;
                Color brush = ColorTranslator.FromHtml("#727CF5");
                btnrcp.BackgroundColor = brush;
            }

        }


        private void InitalizeTime()
        {
            if (fgtimeGrid.Rows.Count > 0)
            {
            }
#pragma warning disable IDE0059
            List<Data> lstRecipeData = new List<Data>();

            if (CommonClass.IsStdSampleMethodOn)
            {
                for (int i = 1; i < 4; i++)
                    fgtimeGrid[i, 1] = (i).ToString();

                fgtimeGrid[1, 2] = "측정시작시간";
                fgtimeGrid[2, 2] = "완료예정시간";
                fgtimeGrid[3, 2] = "측정잔여시간";

            }
            else
            {
                for (int i = 1; i < 4; i++)
                    fgtimeGrid[i, 1] = (i).ToString();

                fgtimeGrid[1, 2] = "측정시작시간";
                fgtimeGrid[2, 2] = "완료예정시간";
                fgtimeGrid[3, 2] = "측정잔여시간";
            }
#pragma warning restore IDE0059
        }
        private void InitalizeCallRecipe()
        {
#pragma warning disable IDE0059
            List<Data> lstRecipeData = new List<Data>();

            int iRowMax = 13;
            fgCallRecipe.Rows.Count = iRowMax;
            if (CommonClass.IsStdSampleMethodOn)
            {

                for (int i = 1; i < iRowMax; i++)
                    fgCallRecipe[i, 1] = (i).ToString();

                fgCallRecipe[1, 2] = "측정자 ID";
                fgCallRecipe[2, 2] = "레시피명";
                fgCallRecipe[3, 2] = "시험방법";
                fgCallRecipe[4, 2] = "측정 시간(sec)";
                fgCallRecipe[5, 2] = "정치모드_설정온도(℃)";
                fgCallRecipe[6, 2] = "정치모드_설정습도(%)";
                fgCallRecipe[7, 2] = "패턴모드_설정번호";
                fgCallRecipe[8, 2] = "캘리브레이션ID";
                for (int i = 1; i <= 12; i++)
                {
                    fgReqInfo[i, 1] = i.ToString();
                }

            }
            else
            {
                for (int i = 1; i < 9; i++)
                    fgCallRecipe[i, 1] = (i).ToString();
                for (int i = 9; i < iRowMax; i++)
                    fgCallRecipe[i, 1] = "";

                fgCallRecipe[1, 2] = "측정자 ID";
                fgCallRecipe[2, 2] = "레시피명";
                fgCallRecipe[3, 2] = "시험방법";
                fgCallRecipe[4, 2] = "측정 시간(sec)";
                fgCallRecipe[5, 2] = "정치모드_설정온도(℃)";
                fgCallRecipe[6, 2] = "정치모드_설정습도(%)";
                fgCallRecipe[7, 2] = "패턴모드_설정번호";
                fgCallRecipe[8, 2] = "캘리브레이션ID";
                for (int i = 1; i <= 12; i++)
                {
                    fgReqInfo[i, 1] = i.ToString();
                }
            }
#pragma warning restore IDE0059
        }

        private bool ChamberRunningStop()
        {
            bool isRtn;
            try
            {
                Measure.IsChamberRunOn10 = 0;
                ChamberRunColor();
                if (Measure.IsHmiUse)
                {
                    string OM_OPMODE = HMIController.mIns.GetD0010();

                    bool isHmiRunning = true;
                    if (OM_OPMODE.Equals("1"))//정치, 패턴모드 Stop 상태
                    {
                        isHmiRunning = false;

                    }
                    else if (OM_OPMODE.Equals("2"))//정치모드 Run 상태
                    {
                        isHmiRunning = true;
                    }
                    else if (OM_OPMODE.Equals("4"))//패턴모드 Run 상태
                    {
                        isHmiRunning = true;
                    }

                    if (isHmiRunning)
                        HMIController.mIns.SetD0101_4();

                }

                isRtn = true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                cLog.Error("[" + this.Name + "]\r\n " + ex.ToString());

                isRtn = false;
            }

            return isRtn;
        }
        private int CalcuChamberTimer()
        {
            DateTime runningTime = m_runningTime;
            try
            {
                if (fgtimeGrid[2, 3] == null)
                {

                }
                else
                {
                    DateTime dtEstEndTime = DateTime.Parse(fgtimeGrid[2, 3].ToString());
                    TimeSpan ts2 = dtEstEndTime - runningTime;
                    int diffDay2 = ts2.Days;
                    int hour2 = ts2.Hours;
                    int min2 = ts2.Minutes;
                    int sec2 = ts2.Seconds;

                    if (min2 < 0) min2 = 0;
                    if (sec2 < 0) sec2 = 0;


                    mtime = Int32.Parse(fgCallRecipe[4, 3].ToString());
                    mtime /= 86400;
                    if (mtime < 0) mtime = 0;
                    string str2 = "D-" + diffDay2 + "  " + string.Format("{0:D2}", hour2) + ":" + string.Format("{0:D2}", min2) + ":" + string.Format("{0:D2}", sec2);
                    fgtimeGrid[3, 3] = str2;
                }

            }
            catch (Exception exc)
            {
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }

            return 1;
        }

        private int CheckMeasureProcChamberA1A2()
        {
#pragma warning disable IDE0059
            int iRtn = 0;
            keynolist.Clear();

            var row = new Dictionary<string, string>();
            try
            {
                List<Dictionary<string, string>> dicReturn = new List<Dictionary<string, string>>();
                string sql = $"SELECT(select chamberno from tbl_measure_chamber where msid = \"{measureidText}\" && divno= \"{measurediv}\" order by  chamberno asc limit 1) as chamberno, (select count(*) from tbl_measure_chamber where msid = \"{measureidText}\" && divno= \"{measurediv}\"   ) as count FROM tbl_measure_chamber limit 1;";
                msdto.OpenKeepUp();
                dicReturn = msdto.SelectAll(sql);

                if (dicReturn.Count > 0)
                {
                    row = dicReturn[0];
                    if (row != null)
                    {
                        foreach (string key in row.Values)
                        {
                            keynolist.Add(key);
                        }
                        if (string.IsNullOrEmpty(keynolist[0]))
                        {
                            m_fstkeyno = 0;
                            iRtn = 0;
                        }
                        else
                        {
                            UInt32 fstkeyno = UInt32.Parse(keynolist[0]);
                            int fstcount = Int32.Parse(keynolist[1]);

                            m_fstkeyno = fstkeyno;
                            iRtn = 1;
                        }
                    }
                }
                else
                {
                    m_fstkeyno = 0;
                    iRtn = 0;
                }
            }
            catch (Exception exc)
            {
                System.Windows.MessageBox.Show(exc.Message);
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
                iRtn = 9999;//Error
            }
            finally
            {
                msdto.Close();
            }
#pragma warning restore IDE0059
            return iRtn;
        }

        private void ChamberAddSeries(string[] plcAiNameList)
        {
            if (plcAiNameList == null)
            {
                FcDataChartSettings(series1, 0, Color.OrangeRed, ChartType.Line, "현재온도");
                FcDataChartSettings(series3, 1, Color.LightBlue, ChartType.Line, "현재습도");

                FcDataChartSettings(series4, 2, Color.DarkRed, ChartType.Line, "설정온도");
                FcDataChartSettings(series5, 3, Color.DarkBlue, ChartType.Line, "설정습도");

                FcDataChartSettings(series6, 4, Color.Olive, ChartType.Line, "AI01");
                FcDataChartSettings(series7, 5, Color.FromArgb(71, 75, 120), ChartType.Line, "AI02");
                FcDataChartSettings(series8, 6, Color.Orange, ChartType.Line, "AI03");
                FcDataChartSettings(series9, 7, Color.FromArgb(35, 85, 87), ChartType.Line, "AI04");
                FcDataChartSettings(series10, 8, Color.FromArgb(39, 88, 35), ChartType.Line, "AI05");
                FcDataChartSettings(series11, 9, Color.LightBlue, ChartType.Line, "AI06");
                FcDataChartSettings(series12, 10, Color.FromArgb(79, 60, 151), ChartType.Line, "AI07");
                FcDataChartSettings(series13, 11, Color.FromArgb(244, 112, 187), ChartType.Line, "AI08");
                FcDataChartSettings(series14, 12, Color.GreenYellow, ChartType.Line, "AI09");
                FcDataChartSettings(series15, 13, Color.FromArgb(246, 177, 104), ChartType.Line, "AI10");
                FcDataChartSettings(series16, 14, Color.FromArgb(69, 163, 181), ChartType.Line, "AI11");
                FcDataChartSettings(series17, 15, Color.FromArgb(103, 182, 37), ChartType.Line, "AI12");

                FcDataChartSettings(series18, 16, Color.CornflowerBlue, ChartType.Line, "AO01");
                FcDataChartSettings(series19, 17, Color.LawnGreen, ChartType.Line, "AO02");

                FcDataChartSettings(series20, 18, Color.Black, ChartType.Line, "DI01");
                FcDataChartSettings(series21, 19, Color.DarkViolet, ChartType.Line, "DI02");
                FcDataChartSettings(series22, 20, Color.FromArgb(107, 208, 137), ChartType.Line, "DI03");
                FcDataChartSettings(series23, 21, Color.MistyRose, ChartType.Line, "DI04");

                FcDataChartSettings(series24, 22, Color.FromArgb(128, 121, 0), ChartType.Line, "DO01");
                FcDataChartSettings(series25, 23, Color.FromArgb(157, 63, 41), ChartType.Line, "DO02");
            }
            else
            {
                FcDataChartSettings(series1, 0, Color.OrangeRed, ChartType.Line, "현재온도");
                FcDataChartSettings(series3, 1, Color.LightBlue, ChartType.Line, "현재습도");

                FcDataChartSettings(series4, 2, Color.DarkRed, ChartType.Line, "설정온도");
                FcDataChartSettings(series5, 3, Color.DarkBlue, ChartType.Line, "설정습도");

                FcDataChartSettings(series6, 4, Color.Olive, ChartType.Line, plcAiNameList[0]);
                FcDataChartSettings(series7, 5, Color.FromArgb(71, 75, 120), ChartType.Line, plcAiNameList[1]);
                FcDataChartSettings(series8, 6, Color.Orange, ChartType.Line, plcAiNameList[2]);
                FcDataChartSettings(series9, 7, Color.FromArgb(35, 85, 87), ChartType.Line, plcAiNameList[3]);
                FcDataChartSettings(series10, 8, Color.FromArgb(39, 88, 35), ChartType.Line, plcAiNameList[4]);
                FcDataChartSettings(series11, 9, Color.LightBlue, ChartType.Line, plcAiNameList[5]);
                FcDataChartSettings(series12, 10, Color.FromArgb(79, 60, 151), ChartType.Line, plcAiNameList[6]);
                FcDataChartSettings(series13, 11, Color.FromArgb(244, 112, 187), ChartType.Line, plcAiNameList[7]);
                FcDataChartSettings(series14, 12, Color.GreenYellow, ChartType.Line, plcAiNameList[8]);
                FcDataChartSettings(series15, 13, Color.FromArgb(246, 177, 104), ChartType.Line, plcAiNameList[9]);
                FcDataChartSettings(series16, 14, Color.FromArgb(69, 163, 181), ChartType.Line, plcAiNameList[10]);
                FcDataChartSettings(series17, 15, Color.FromArgb(103, 182, 37), ChartType.Line, plcAiNameList[11]);

                FcDataChartSettings(series18, 16, Color.CornflowerBlue, ChartType.Line, "AO01");
                FcDataChartSettings(series19, 17, Color.LawnGreen, ChartType.Line, "AO02");

                FcDataChartSettings(series20, 18, Color.Black, ChartType.Line, "DI01");
                FcDataChartSettings(series21, 19, Color.DarkViolet, ChartType.Line, "DI02");
                FcDataChartSettings(series22, 20, Color.FromArgb(107, 208, 137), ChartType.Line, "DI03");
                FcDataChartSettings(series23, 21, Color.MistyRose, ChartType.Line, "DI04");

                FcDataChartSettings(series24, 22, Color.FromArgb(128, 121, 0), ChartType.Line, "DO01");
                FcDataChartSettings(series25, 23, Color.FromArgb(157, 63, 41), ChartType.Line, "DO02");
            }




            this.fcDataChart.ChartType = ChartType.Line;
            //this.fcDataChart.ChartType = ChartType.LineSymbols; 


        }
        private void FcDataChartSettings(Series objId, int idx, Color color, ChartType chartType, string labelName)
        {
            this.fcDataChart.Series.Add(objId);//현재온도
            this.fcDataChart.Series[idx].Style.StrokeColor = color;
            this.fcDataChart.Series[idx].Name = labelName;
            this.fcDataChart.Series[idx].ChartType = chartType;
        }

        public void ResetChartSeries(string[] hmiNameList, string[] plcAiNameList, string[] plcAoNameList, string[] plcDiNameList, string[] plcDoNameList)
        {
            fcDataChart.Series.Clear();
            //fcDataChart.Refresh();
            series1 = null;
            series3 = null;
            series4 = null;
            series5 = null;
            series6 = null;
            series7 = null;
            series8 = null;
            series9 = null;
            series10 = null;
            series11 = null;
            series12 = null;
            series13 = null;
            series14 = null;
            series15 = null;
            series16 = null;
            series17 = null;
            series18 = null;
            series19 = null;
            series20 = null;
            series21 = null;
            series22 = null;
            series23 = null;
            series24 = null;
            series25 = null;

            if (hmiNameList == null)
            {
                series1 = new Series { Name = "현재온도", Binding = fchartBindY_name };
                series3 = new Series { Name = "현재습도", Binding = fchartBindY_name };
                series4 = new Series { Name = "설정온도", Binding = fchartBindY_name };
                series5 = new Series { Name = "설정습도", Binding = fchartBindY_name };
            }
            else
            {
                series1 = new Series { Name = hmiNameList[0], Binding = fchartBindY_name };
                series3 = new Series { Name = hmiNameList[1], Binding = fchartBindY_name };
                series4 = new Series { Name = hmiNameList[2], Binding = fchartBindY_name };
                series5 = new Series { Name = hmiNameList[3], Binding = fchartBindY_name };
            }

            if (plcAiNameList == null)
            {
                series6 = new Series { Name = "AI01", Binding = fchartBindY_name };
                series7 = new Series { Name = "AI02", Binding = fchartBindY_name };
                series8 = new Series { Name = "AI03", Binding = fchartBindY_name };
                series9 = new Series { Name = "AI04", Binding = fchartBindY_name };
                series10 = new Series { Name = "AI05", Binding = fchartBindY_name };
                series11 = new Series { Name = "AI06", Binding = fchartBindY_name };
                series12 = new Series { Name = "AI07", Binding = fchartBindY_name };
                series13 = new Series { Name = "AI08", Binding = fchartBindY_name };
                series14 = new Series { Name = "AI09", Binding = fchartBindY_name };
                series15 = new Series { Name = "AI10", Binding = fchartBindY_name };
                series16 = new Series { Name = "AI11", Binding = fchartBindY_name };
                series17 = new Series { Name = "AI12", Binding = fchartBindY_name };
            }
            else
            {
                series6 = new Series { Name = plcAiNameList[0], Binding = fchartBindY_name };
                series7 = new Series { Name = plcAiNameList[1], Binding = fchartBindY_name };
                series8 = new Series { Name = plcAiNameList[2], Binding = fchartBindY_name };
                series9 = new Series { Name = plcAiNameList[3], Binding = fchartBindY_name };
                series10 = new Series { Name = plcAiNameList[4], Binding = fchartBindY_name };
                series11 = new Series { Name = plcAiNameList[5], Binding = fchartBindY_name };
                series12 = new Series { Name = plcAiNameList[6], Binding = fchartBindY_name };
                series13 = new Series { Name = plcAiNameList[7], Binding = fchartBindY_name };
                series14 = new Series { Name = plcAiNameList[8], Binding = fchartBindY_name };
                series15 = new Series { Name = plcAiNameList[9], Binding = fchartBindY_name };
                series16 = new Series { Name = plcAiNameList[10], Binding = fchartBindY_name };
                series17 = new Series { Name = plcAiNameList[11], Binding = fchartBindY_name };
            }

            if (plcAoNameList == null)
            {
                series18 = new Series { Name = "AO01", Binding = fchartBindY_name };
                series19 = new Series { Name = "AO02", Binding = fchartBindY_name };
            }
            else
            {
                series18 = new Series { Name = plcAoNameList[0], Binding = fchartBindY_name };
                series19 = new Series { Name = plcAoNameList[1], Binding = fchartBindY_name };
            }

            if (plcDiNameList == null)
            {
                series20 = new Series { Name = "DI01", Binding = fchartBindY_name };
                series21 = new Series { Name = "DI02", Binding = fchartBindY_name };
                series22 = new Series { Name = "DI03", Binding = fchartBindY_name };
                series23 = new Series { Name = "DI04", Binding = fchartBindY_name };
            }
            else
            {
                series20 = new Series { Name = plcDiNameList[0], Binding = fchartBindY_name };
                series21 = new Series { Name = plcDiNameList[1], Binding = fchartBindY_name };
                series22 = new Series { Name = plcDiNameList[2], Binding = fchartBindY_name };
                series23 = new Series { Name = plcDiNameList[3], Binding = fchartBindY_name };
            }

            if (plcDoNameList == null)
            {
                series24 = new Series { Name = "DO01", Binding = fchartBindY_name };
                series25 = new Series { Name = "DO02", Binding = fchartBindY_name };
            }
            else
            {
                series24 = new Series { Name = plcDoNameList[0], Binding = fchartBindY_name };
                series25 = new Series { Name = plcDoNameList[1], Binding = fchartBindY_name };
            }

            ChamberAddSeries(plcAiNameList);
            fcDataChart.BindingX = "PosX";
            fcDataChart.AxisX.Labels = true;
        }
        private void ResetChartData_fcDataChart()
        {
            try
            {
                obCurTemp1.Clear();
                obCurTemp2.Clear();
                obCurHumi.Clear();
                obSetTemp.Clear();
                obSetHumi.Clear();
                AI01.Clear();
                AI02.Clear();
                AI03.Clear();
                AI04.Clear();
                AI05.Clear();
                AI06.Clear();
                AI07.Clear();
                AI08.Clear();
                AI09.Clear();
                AI10.Clear();
                AI11.Clear();
                AI12.Clear();
                AO01.Clear();
                AO02.Clear();
                DI01.Clear();
                DI02.Clear();
                DI03.Clear();
                DI04.Clear();
                DO01.Clear();
                DO02.Clear();
            }
            catch (Exception exc)
            {
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }
        }
        private void ChamberA1Settings()
        {
            chamber_repeat++;

            if (CommonClass.isMacroOn)
            {
                LogBoxAdd("챔버측정A1", "자동테스트시작");
            }
        }


        bool isFixModeOn = true;
        bool isPatternModeOn = false;

        private void BtnFixModeOn_Click(object sender, EventArgs e)
        {
            string StepID = "[02]" + " ";
            string strValue = "정치 모드로 동작";

            string logbox_title = "정치 모드 동작";
            lblmode.BackColor = Color.FromArgb(255, 255, 0);
            if (CommonClass.isMacroOn && CommonClass.isMacroNextRun)
            {

            }
            else
            {
                if (System.Windows.MessageBox.Show(strValue + " 하시겠습니까?", logbox_title, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                {
                    LogBoxAdd(logbox_title, "취소");
                    lblmode.BackColor = Color.FromArgb(217, 217, 217);
                    return;
                }
            }
            Cursor.Current = Cursors.WaitCursor;
            LogBoxAdd(logbox_title, strValue + " 시작");
            if (SetHmiModeSetting(1))
            {
                SetHmiFixModeEnvConfig();
            }
            LogBoxAdd(logbox_title, strValue + "완료");

            isFixModeOn = true;
            isPatternModeOn = false;
            RunModeColorSet();
            lblShowStatus.Text = StepID + "정치 모드로 지정 되었습니다.";
            cLog.Info(cMwlog.SettingModeClickEventLog);
            lblmode.BackColor = Color.FromArgb(68, 114, 196);
            mode = "정치모드";
            Cursor.Current = Cursors.Default;
            Delay(1000);

            lblShowStatus.Text = "[03] 챔버가동 여부를 선택하세요.";
        }



        private bool SetHmiModeSetting(int v)
        {
            string logbox_title = "HMI 모드 동작 설정";
            string strValue;
            if (HMIController.mIns == null)
            {
                strValue = "HMI 장치관리 인스턴스 오류입니다.";
                LogBoxAdd(logbox_title, strValue + "취소");
                return false;
            }
            else
            {
                if (HMIController.mIns.SetHmiModeSetting(v))
                {
                    string strMode = "";
                    switch (v)
                    {
                        case 0: strMode = "패턴모드"; break;
                        case 1: strMode = "정치모드"; break;
                    }
                    strValue = "HMI 운전모드가 " + strMode + "로 변경되었습니다.";
                    LogBoxAdd(logbox_title, strValue + "완료");
                    return true;
                }
                else
                {
                    strValue = "HMI 장치관리 미사용입니다.";
                    LogBoxAdd(logbox_title, strValue + "취소");
                    return false;
                }
            }
        }

        private void BtnPatternModeOn_Click(object sender, EventArgs e)
        {
            string StepID = "[02]" + " ";
            string strValue = "패턴 모드로 동작";

            string logbox_title = "패턴 모드 동작";
            lblmode.BackColor = Color.FromArgb(255, 255, 0);
            if (CommonClass.isMacroOn && CommonClass.isMacroNextRun)
            {

            }
            else
            {
                if (System.Windows.MessageBox.Show(strValue + " 하시겠습니까?", logbox_title, MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
                {
                    LogBoxAdd(logbox_title, "취소");
                    lblmode.BackColor = Color.FromArgb(217, 217, 217);
                    return;
                }
            }
            Cursor.Current = Cursors.WaitCursor;
            LogBoxAdd(logbox_title, strValue + " 시작");
            if (SetHmiModeSetting(0))
            {
                SetHmiPatternNo();
            }
            LogBoxAdd(logbox_title, strValue + "완료");
            isFixModeOn = false;
            isPatternModeOn = true;
            RunModeColorSet();
            lblShowStatus.Text = StepID + "패턴 모드로 지정 되었습니다.";
            mode = "패턴모드";
            cLog.Info(cMwlog.PatternModeClickEventLog);
            lblmode.BackColor = Color.FromArgb(68, 114, 196);
            Cursor.Current = Cursors.Default;
            Delay(1000);
            lblShowStatus.Text = "[03] 챔버가동 여부를 선택하세요.";
        }

        private void SetHmiFixModeEnvConfig()
        {
            if (Measure.IsHmiUse)
            {
                if (HMIController.mIns == null) return;

                if (cTbl_recipe == null) return;

                //정치 온도 셋팅
                if (string.IsNullOrEmpty(cTbl_recipe.settemp)) { }
                else
                    HMIController.mIns.SetD0102(cTbl_recipe.settemp);

                //정치 습도 셋팅
                if (string.IsNullOrEmpty(cTbl_recipe.sethumi)) { }
                else
                    HMIController.mIns.SetD0106(cTbl_recipe.sethumi);
            }
        }

        private bool SetHmiPatternNo()
        {

            string logbox_title = "HMI 패턴 번호 지정 설정";
            if (HMIController.mIns == null)
            {

                string strValue = "HMI Instance가 null 입니다.";
                LogBoxAdd(logbox_title, strValue + "완료");
                return false;
            }
            else if (string.IsNullOrEmpty(cTbl_recipe.pattern))
            {
                string strValue = "레시피에 패턴 번호가 없습니다.";
                LogBoxAdd(logbox_title, strValue + "취소");
                return false;
            }
            else
            {
                Int32.TryParse(cTbl_recipe.pattern, out int iPtnNo);
                if (iPtnNo == 0)
                {
                    string strValue = "레시피에 패턴 번호가 없습니다.";
                    LogBoxAdd(logbox_title, strValue + "취소");
                    return false;
                }
                else
                {
                    if (string.IsNullOrEmpty(m_strNowPlcPatternNo))
                    {
                        m_strNowPlcPatternNo = cTbl_recipe.pattern;
                    }

                    HMIController.mIns.SetHmiPatternNo(iPtnNo: iPtnNo);
                    string strValue = "HMI 패턴모드의 번호가 설정 되었습니다.";
                    LogBoxAdd(logbox_title, strValue + "완료");

                    m_strNowPlcPatternNo = cTbl_recipe.pattern;
                    return true;
                }
            }
        }

        private void RunModeColorSet()
        {
            if (isFixModeOn)
            {
                this.btnFixModeOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
                this.btnFixModeOn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
                this.btnFixModeOn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));

                this.btnPatternModeOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                this.btnPatternModeOn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                this.btnPatternModeOn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            }
            else if (isPatternModeOn)
            {
                this.btnPatternModeOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
                this.btnPatternModeOn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
                this.btnPatternModeOn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));

                this.btnFixModeOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                this.btnFixModeOn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
                this.btnFixModeOn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            }
        }


        private void EventButtonsSettings(bool isbool)
        {
            btnrcp.Enabled = isbool;
            btnMeasureStart.Enabled = isbool;
            btnSampleMeasureStop.Enabled = isbool;
            btnExport.Enabled = isbool;
        }
        private void ButtonsTitleSetting(string mode)
        {
            string strSpace = " ";
            btnrcp.Text = mode + "01" + strSpace + "레시피선택"; ;
            btnFixModeOn.Text = mode + "02" + strSpace + "정치모드";
            btnPatternModeOn.Text = mode + "02" + strSpace + "패턴모드";
            btnChamberStart.Text = mode + "03" + strSpace + "챔버가동";
            btnChamberStop.Text = mode + "03" + strSpace + "챔버중지";
            btnMeasureStart.Text = mode + "04" + strSpace + "샘플측정시작";
            btnExport.Text = mode + "05" + strSpace + "테스트결과보기";

        }

        private void ButtonsColor()
        {
            btnrcp.BackgroundColor = Color.FromArgb(7, 154, 114);
            btnMeasureStart.BackgroundColor = Color.FromArgb(7, 154, 114);
            btnExport.BackgroundColor = Color.FromArgb(7, 154, 114);
        }

        private int DelayStopWatch(int delayMax = 10)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long prevTime = stopwatch.ElapsedMilliseconds;
            int iRtn = 0;
            bool isLoop = true;
            while (isLoop)
            {
                long currentTime = stopwatch.ElapsedMilliseconds;
                if ((currentTime - prevTime) >= 1000)
                {
                    prevTime = currentTime;
                    iRtn++;
                    if (iRtn >= delayMax) { break; }
                }
                System.Windows.Forms.Application.DoEvents();
            }
            stopwatch.Stop();
            System.Windows.Forms.Application.DoEvents();
            return iRtn;
        }

        public void Delay1000(int ms = 1000)
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);
            while (dateTimeAdd >= dateTimeNow)
            {
                System.Windows.Forms.Application.DoEvents();
                dateTimeNow = DateTime.Now;
            }
            return;
        }

        public void Delay(int ms)
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);
            while (dateTimeAdd >= dateTimeNow)
            {
                System.Windows.Forms.Application.DoEvents();
                dateTimeNow = DateTime.Now;
            }
            return;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ResetChartData_fcDataChart();

        }

        //-----------------------------------------------------------------------------
        private void BwChamberMeasureThread1_DoWork(object sender)
        {
            MeasureRunAcq();

            if (bwChamberMeasureThead1.IsAlive)
            {
                bwChamberMeasureThead1.Join();
            }
        }

        private void MeasureRunAcq()
        {
            int isec = 10000000;// ticks 10000000 = 1초

            if (isChartReset_time_use)
            {
                if (Measure.iAcqCountMax >= 1000)
                {
                    timer_chart_reset.Interval = TimeSpan.FromTicks(30 * isec);
                }
                else if (Measure.iAcqCountMax >= 360)
                {
                    timer_chart_reset.Interval = TimeSpan.FromTicks(60 * isec);
                }
                else
                {
                    timer_chart_reset.Interval = TimeSpan.FromTicks(120 * isec);
                }

                timer_chart_reset.Tick += new EventHandler(Timer_Tick);
                timer_chart_reset.Stop();
                timer_chart_reset.Start();
            }
            else
            {
                //ResetChartData_fcDataChart();//시작시 이미 클리어
            }

            this.Invoke(new MethodInvoker(
                delegate ()
                {
                    //[데이터] grid reset
                    fgDataGrid.Rows.RemoveRange(1, fgDataGrid.Rows.Count - 1);
                }));

            try
            {
                this.Invoke(new MethodInvoker(
                 delegate ()
                 {
                     ChamberAcq();
                 }));

                MeasureEndUpdate();
            }
            catch (Exception exc)
            {
                iNowMeasurementType = 0;
                System.Windows.MessageBox.Show(exc.ToString(), "bwChamberMeasureThread1_DoWork()");
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }
            finally
            {


            }
        }

        private void MeasureEndUpdate()
        {
            if (bwChamberMeasureThead1.IsAlive)
            {
                this.Invoke(new MethodInvoker(
        delegate ()
        {
            lblShowStatus.Text = "[04] 챔버 측정 완료/중지";
            Delay(2000);
            lblShowStatus.Text = "측정중지되었습니다. 챔버 가동중이면 '챔버중지' 버튼을 누르세요";
            Delay(2000);
            IsEnabledButton(true);
            lblShowStatus.Text = "[05] 테스트 결과보기를 선택 하세요.";

        }));
            }
            else
            {
                lblShowStatus.Text = "[04] 챔버 측정 완료/중지";
                Delay(2000);
                lblShowStatus.Text = "측정중지되었습니다. 챔버 가동중이면 '챔버중지' 버튼을 누르세요";
                Delay(2000);
                IsEnabledButton(true);
                lblShowStatus.Text = "[05] 테스트 결과보기를 선택 하세요.";
            }

        }

        private void BwChamberMeasureThead1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }
        private void BwChamberMeasureThead1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {


                if (e.Cancelled) System.Windows.Forms.MessageBox.Show("작업 취소...");
                else if (e.Error != null)
                {
                    System.Windows.Forms.MessageBox.Show("에러발생..." + e.Error);
                    if (CommonClass.isDemoOn == false)
                    {
                        Task.Delay(100).GetAwaiter().GetResult();
                        this.Invoke(new MethodInvoker(
                       delegate ()
                       {

                           if (HMIController.mIns.GetD0010().Equals("2"))
                               HMIController.mIns.SetD0101_4();
                       }));
                        Task.Delay(100).GetAwaiter().GetResult();
                    }
                }
                else
                {
                    if (CommonClass.isMacroOn && (CommonClass.isMacroStop == false) && (CommonClass.isMacroNextRun == false))
                    {
                        Delay(1000);

                    }
                    else if (CommonClass.isMacroOn && (CommonClass.isMacroStop == false) && (CommonClass.isMacroNextRun == true))
                    {
                        Delay(1000);
                        SetNewMeasureID();
                        SetMacroOpMode();
                        BtnMeasureStart_Click(null, null);
                    }
                }
            }
            catch (Exception exc)
            {
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }
        }

        private void SetMacroOpMode()
        {
            try
            {
                if (iMacroOpMode == 1)
                {
                    BtnFixModeOn_Click(null, null);
                    iMacroOpMode = 0;
                }
                else
                {
                    BtnPatternModeOn_Click(null, null);
                    iMacroOpMode = 1;
                }
                BtnChamberStart_Click(null, null);
            }
            catch (Exception exc)
            {
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }

        }

        private void BwChamberMeasureThead1_Stop()
        {
            try
            {
                m_strAcqStdTime = string.Empty;


                isChamberLoop = false;
                if (bwChamberMeasureThead1 != null && bwChamberMeasureThead1.IsAlive)
                {
                    Delay(1000);
                }
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.ToString(), "DoMeasureMSC_Thread");
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }
        }

        private void ChamberAcq()
        {
            try
            {
                bool isDemo = CommonClass.isDemoOn;
                pre_mdata_count = 0;
                aft_mdata_count = 0;
                aft_mdata_no_idx = 1;
                isChamberLoop = true;

                UInt32 iUpdateDbIdx = m_fstkeyno;
                while (isChamberLoop)
                {
                    if (isChamberLoop == false)
                    {
                        Delay1000(1000);
                        break;
                    }
                    else
                    {
                        iAcqCount = (int)ChamberAcqData(iUpdateDbIdx);
                    }
                }
            }
            catch (Exception exc)
            {
                System.Windows.MessageBox.Show(exc.ToString(), "ChamberAcq");
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }
            finally
            {

                sw_device_acq.Stop();
                sw_ui_update.Stop();
                sw_db_update.Stop();

                if (isChartReset_time_use)
                {
                    timer_chart_reset.Stop();
                }
            }
        }
        private double ChamberAcqData(UInt32 iUpdateDbIdx)
        {
            try
            {
                sw_device_acq.Restart();

                //--------HMI Datas
                double[] hmi_data = new double[4];//D1,D2,D5,D6
                                                  //-------PLC Datas
                double[] plc_data_ai = new double[12];// 3 * 4ch (-10~10Vdc)
                double[] plc_data_ao = new double[2];//2ch (0~10Vdc)
                double[] plc_data_di = new double[4];
                double[] plc_data_do = new double[2];

                //-----------------------
                DateTime stdtime = DateTime.Now;
                DateTime startTime;
                DateTime acqTime;
                startTime = stdtime.AddTicks(-1 * stdtime.Ticks % 10000);

                bool isUpdateOk = false;
                pre_mdata_count++;
                isUpdateOk = pre_mdata_count % Measure.iAcqUpdateStep == 0;//? true : false;

                if (isUpdateOk || string.IsNullOrEmpty(m_strAcqStdTime))
                {
                    if (CommonClass.isDemoOn)
                    {
                        Random random = new Random();

                        if (Measure.IsHmiUse)
                        {

                            //Delay(10000);
                            string[] strHmiGetData = HMIController.mIns.GetListStringData();
                            //설정 - 온도, 습도, 현재 - 온도,습도
                            double.TryParse(strHmiGetData[0], out hmi_data[0]);//현재온도 D1
                            double.TryParse(strHmiGetData[1], out hmi_data[2]);//설정온도 D2
                            double.TryParse(strHmiGetData[2], out hmi_data[1]);//현재습도 D5
                            double.TryParse(strHmiGetData[3], out hmi_data[3]);//설정습도 D6

                        }
                        else
                        {
                            hmi_data[0] = random.Next(-100, 321); //현재 온도
                            hmi_data[1] = random.Next(0, 101);//현재 습도
                            hmi_data[2] = random.Next(-100, 321);//설정 온도
                            hmi_data[3] = random.Next(0, 101);//설정 습도
                        }

                        if (Measure.IsRecUse)
                        {

                        }

                        if (Measure.IsPlcUse)
                        {
                            string[] strPlcGetData = PLCController.mIns.GetListStringData();
                            if (strPlcGetData != null)
                            {
                                int iPlcIDatandex = 0;

                                for (int i = 0; i < plc_data_ai.Length; i++) { double.TryParse(strPlcGetData[iPlcIDatandex++], out plc_data_ai[i]); }
                                for (int i = 0; i < plc_data_ao.Length; i++) { double.TryParse(strPlcGetData[iPlcIDatandex++], out plc_data_ao[i]); }
                                for (int i = 0; i < plc_data_di.Length; i++) { double.TryParse(strPlcGetData[iPlcIDatandex++], out plc_data_di[i]); }
                                for (int i = 0; i < plc_data_do.Length; i++) { double.TryParse(strPlcGetData[iPlcIDatandex++], out plc_data_do[i]); }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < plc_data_ai.Length; i++) { plc_data_ai[i] = (double)((int)random.Next(-10, 11)); }
                            for (int i = 0; i < plc_data_ao.Length; i++) { plc_data_ao[i] = (double)((int)random.Next(-10, 11)); }
                            for (int i = 0; i < plc_data_di.Length; i++) { plc_data_di[i] = (double)((int)random.Next(0, 2)); }
                            for (int i = 0; i < plc_data_do.Length; i++) { plc_data_do[i] = (double)((int)random.Next(0, 2)); }
                        }
                    }
                    else
                    {
                        if (Measure.IsHmiUse)
                        {

                            string[] strHmiGetData = HMIController.mIns.GetListStringData();
                            //설정 - 온도, 습도, 현재 - 온도,습도
                            double.TryParse(strHmiGetData[0], out hmi_data[0]);//현재온도 D1
                            double.TryParse(strHmiGetData[1], out hmi_data[2]);//설정온도 D2
                            double.TryParse(strHmiGetData[2], out hmi_data[1]);//현재습도 D5
                            double.TryParse(strHmiGetData[3], out hmi_data[3]);//설정습도 D6
                        }

                        if (Measure.IsPlcUse)
                        {
                            string[] strPlcGetData = PLCController.mIns.GetListStringData();
                            if (strPlcGetData != null)
                            {
                                int iPlcIDatandex = 0;

                                for (int i = 0; i < plc_data_ai.Length; i++) { double.TryParse(strPlcGetData[iPlcIDatandex++], out plc_data_ai[i]); }
                                for (int i = 0; i < plc_data_ao.Length; i++) { double.TryParse(strPlcGetData[iPlcIDatandex++], out plc_data_ao[i]); }
                                for (int i = 0; i < plc_data_di.Length; i++) { double.TryParse(strPlcGetData[iPlcIDatandex++], out plc_data_di[i]); }
                                for (int i = 0; i < plc_data_do.Length; i++) { double.TryParse(strPlcGetData[iPlcIDatandex++], out plc_data_do[i]); }
                            }
                        }

                    }

                    DateTime compareTime = DateTime.Now;
                    acqTime = compareTime.AddTicks(-1 * compareTime.Ticks % 10000);

                    if (string.IsNullOrEmpty(m_strAcqStdTime))
                    {
                        TimeSpan ts1 = acqTime - startTime;
                        int iGap = ts1.Milliseconds;
                        if (iGap > 0)
                        {
                            autoEvent.WaitOne(1000 - iGap);
                        }
                    }
                    else
                    {
                        TimeSpan ts1 = m_runningTime - startTime;
                        int iGap = ts1.Milliseconds;
                        if (iGap > 0)
                        {
                            autoEvent.WaitOne(1000 - iGap);
                        }
                    }

                    DateTime acqStartTime = acqTime;
                    DateTime acqEndTime = acqTime.AddSeconds(1);


                    if (string.IsNullOrEmpty(m_strAcqStdTime))
                    {
                        //-시작시간, 진행시간, 완료시간, 소요시간
                        DateTime dateTime = acqStartTime;// startTime;
                        string str1 = dateTime.ToString("yyMMddHHmmss");
                        string str2 = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
                        LogBoxAdd(m_logbox_title, "챔버측정시작", str1);

                        m_strAcqStdTime = string.Empty;

                        //측정완료예정시간
                        string strTotalTime = cTbl_recipe.mtime;
                        int totalSec = Convert.ToInt32(strTotalTime);
                        TimeSpan tspan1 = TimeSpan.FromSeconds(totalSec);
                        m_estEndtime = dateTime.Add(tspan1);

                        fgtimeGrid[1, 3] = str2.ToString();
                        fgtimeGrid[2, 3] = m_estEndtime.ToString("yyyy-MM-dd HH:mm:ss");
                        fgtimeGrid[3, 3] = "";

                        if (measurediv.Equals("c1"))
                        {
                            //최초로 측정을 시작할때만, 적용
                            cTbl_statistics1.mstotalstarttime = str2;
                        }
                    }

                    m_runningTime = acqEndTime;

                    int iCheckEndTimer = CheckChamberTimer1();
                    if (iCheckEndTimer == 99 || iCheckEndTimer == 100) { }
                    else
                    {

                        //---------------------------------------------------------------------------------
                        //Data Update
                        UpdateDataChart(acqStartTime, hmi_data, plc_data_ai, plc_data_ao, plc_data_di, plc_data_do);//--차트 업데이트
                        UpdateDataTable(acqStartTime, hmi_data, plc_data_ai, plc_data_ao, plc_data_di, plc_data_do);//--표 업데이트
                        UpdateDataStatistics(hmi_data, plc_data_ai, plc_data_ao, plc_data_di, plc_data_do);//--통계 업데이트
                        UpdateDbTask(hmi_data, plc_data_ai, plc_data_ao, plc_data_di, plc_data_do, acqStartTime, acqEndTime, iUpdateDbIdx);//--DB 업데이트
                    }

                    aft_mdata_no_idx++;
                    aft_mdata_count++;
                    m_isDbIndexUpdate = true;
                    //---------------------------------------------------------------------------------
                    m_strAcqStdTime = acqEndTime.ToString("yyyy-MM-dd HH:mm:ss");

                    if (Measure.iAcqUpdateStep != 1)
                    {
                        DelayStopWatch(1);
                    }

                    //---------------------------------------------------------------------------------

                }
                else
                {
                    m_isDbIndexUpdate = false;
                    DelayStopWatch(1);
                    m_strAcqStdTime = startTime.ToString("yyyy-MM-dd HH:mm:ss");
                    m_runningTime = startTime;
                    CheckChamberTimer1();
                }

                //---------------------------------------------------------------------------------
                if (m_isDbIndexUpdate)
                {
                    iUpdateDbIdx++;
                    if (iUpdateDbIdx >= int.MaxValue)
                    {
                        iUpdateDbIdx = 0;
                    }
                }
                if (Measure.iAcqUpdateStep == 1)
                {
                    System.Windows.Forms.Application.DoEvents();
                }
            }
            catch (Exception exc)
            {
                System.Windows.MessageBox.Show(exc.ToString(), "ChamberAcq");
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }
            return aft_mdata_count;
        }

        private void UpdateDataStatistics(double[] hmi_data, double[] plc_data_ai, double[] plc_data_ao, double[] plc_data_di, double[] plc_data_do)
        {
            //--최대-----
            if (countnum == 0)
            {
                countnum++;
                md1max = hmi_data[0];
                md2max = hmi_data[1];
                md3max = hmi_data[2];
                md4max = hmi_data[3];
                ai01max = plc_data_ai[0];
                ai02max = plc_data_ai[1];
                ai03max = plc_data_ai[2];
                ai04max = plc_data_ai[3];
                ai05max = plc_data_ai[4];
                ai06max = plc_data_ai[5];
                ai07max = plc_data_ai[6];
                ai08max = plc_data_ai[7];
                ai09max = plc_data_ai[8];
                ai10max = plc_data_ai[9];
                ai11max = plc_data_ai[10];
                ai12max = plc_data_ai[11];
                ao01max = plc_data_ao[0];
                ao02max = plc_data_ao[1];
                di01max = plc_data_di[0];
                di02max = plc_data_di[1];
                di03max = plc_data_di[2];
                di04max = plc_data_di[3];
                do01max = plc_data_do[0];
                do02max = plc_data_do[1];
                md1min = hmi_data[0];
                md2min = hmi_data[1];
                md3min = hmi_data[2];
                md4min = hmi_data[3];
                ai01min = plc_data_ai[0];
                ai02min = plc_data_ai[1];
                ai03min = plc_data_ai[2];
                ai04min = plc_data_ai[3];
                ai05min = plc_data_ai[4];
                ai06min = plc_data_ai[5];
                ai07min = plc_data_ai[6];
                ai08min = plc_data_ai[7];
                ai09min = plc_data_ai[8];
                ai10min = plc_data_ai[9];
                ai11min = plc_data_ai[10];
                ai12min = plc_data_ai[11];
                ao01min = plc_data_ao[0];
                ao02min = plc_data_ao[1];
                di01min = plc_data_di[0];
                di02min = plc_data_di[1];
                di03min = plc_data_di[2];
                di04min = plc_data_di[3];
                do01min = plc_data_do[0];
                do02min = plc_data_do[1];
            }
            else
            {
                if (hmi_data[0] > md1max) { md1max = hmi_data[0]; }
                if (hmi_data[1] > md2max) { md2max = hmi_data[1]; }
                if (hmi_data[2] > md3max) { md3max = hmi_data[2]; }
                if (hmi_data[3] > md4max) { md4max = hmi_data[3]; }
                if (plc_data_ai[0] > ai01max) { ai01max = plc_data_ai[0]; }
                if (plc_data_ai[1] > ai02max) { ai02max = plc_data_ai[1]; }
                if (plc_data_ai[2] > ai03max) { ai03max = plc_data_ai[2]; }
                if (plc_data_ai[3] > ai04max) { ai04max = plc_data_ai[3]; }
                if (plc_data_ai[4] > ai05max) { ai05max = plc_data_ai[4]; }
                if (plc_data_ai[5] > ai06max) { ai06max = plc_data_ai[5]; }
                if (plc_data_ai[6] > ai07max) { ai07max = plc_data_ai[6]; }
                if (plc_data_ai[7] > ai08max) { ai08max = plc_data_ai[7]; }
                if (plc_data_ai[8] > ai09max) { ai09max = plc_data_ai[8]; }
                if (plc_data_ai[9] > ai10max) { ai10max = plc_data_ai[9]; }
                if (plc_data_ai[10] > ai11max) { ai11max = plc_data_ai[10]; }
                if (plc_data_ai[11] > ai12max) { ai12max = plc_data_ai[11]; }
                if (plc_data_ao[0] > ao01max) { ao01max = plc_data_ao[0]; }
                if (plc_data_ao[1] > ao02max) { ao02max = plc_data_ao[1]; }
                if (plc_data_di[0] > di01max) { di01max = plc_data_di[0]; }
                if (plc_data_di[1] > di02max) { di02max = plc_data_di[1]; }
                if (plc_data_di[2] > di03max) { di03max = plc_data_di[2]; }
                if (plc_data_di[3] > di04max) { di04max = plc_data_di[3]; }
                if (plc_data_do[0] > do01max) { do01max = plc_data_do[0]; }
                if (plc_data_do[1] > do02max) { do02max = plc_data_do[1]; }


                //---최소-----
                if (hmi_data[0] < md1min) { md1min = hmi_data[0]; }
                if (hmi_data[1] < md2min) { md2min = hmi_data[1]; }
                if (hmi_data[2] < md3min) { md3min = hmi_data[2]; }
                if (hmi_data[3] < md4min) { md4min = hmi_data[3]; }
                if (plc_data_ai[0] < ai01min) { ai01min = plc_data_ai[0]; }
                if (plc_data_ai[1] < ai02min) { ai02min = plc_data_ai[1]; }
                if (plc_data_ai[2] < ai03min) { ai03min = plc_data_ai[2]; }
                if (plc_data_ai[3] < ai04min) { ai04min = plc_data_ai[3]; }
                if (plc_data_ai[4] < ai05min) { ai05min = plc_data_ai[4]; }
                if (plc_data_ai[5] < ai06min) { ai06min = plc_data_ai[5]; }
                if (plc_data_ai[6] < ai07min) { ai07min = plc_data_ai[6]; }
                if (plc_data_ai[7] < ai08min) { ai08min = plc_data_ai[7]; }
                if (plc_data_ai[8] < ai09min) { ai09min = plc_data_ai[8]; }
                if (plc_data_ai[9] < ai10min) { ai10min = plc_data_ai[9]; }
                if (plc_data_ai[10] < ai11min) { ai11min = plc_data_ai[10]; }
                if (plc_data_ai[11] < ai12min) { ai12min = plc_data_ai[11]; }
                if (plc_data_ao[0] < ao01min) { ao01min = plc_data_ao[0]; }
                if (plc_data_ao[1] < ao02min) { ao02min = plc_data_ao[1]; }
                if (plc_data_di[0] < di01min) { di01min = plc_data_di[0]; }
                if (plc_data_di[1] < di02min) { di02min = plc_data_di[1]; }
                if (plc_data_di[2] < di03min) { di03min = plc_data_di[2]; }
                if (plc_data_di[3] < di04min) { di04min = plc_data_di[3]; }
                if (plc_data_do[0] < do01min) { do01min = plc_data_do[0]; }
                if (plc_data_do[1] < do02min) { do02min = plc_data_do[1]; }
            }

            ////--평균-----
            int iAvgIndex = aft_mdata_no_idx;
            //hmi_data_md1avg = hmi_data_md1avg + ((float)hmi_data[0] - hmi_data_md1avg) / iAvgIndex;
            //hmi_data_md2avg = hmi_data_md2avg + ((float)hmi_data[1] - hmi_data_md2avg) / iAvgIndex;
            //hmi_data_md3avg = hmi_data_md3avg + ((float)hmi_data[2] - hmi_data_md3avg) / iAvgIndex;
            //hmi_data_md4avg = hmi_data_md4avg + ((float)hmi_data[3] - hmi_data_md4avg) / iAvgIndex;
            //hmi_data_ai01avg = hmi_data_ai01avg + ((float)plc_data_ai[0] - hmi_data_ai01avg) / iAvgIndex;
            //hmi_data_ai02avg = hmi_data_ai02avg + ((float)plc_data_ai[1] - hmi_data_ai02avg) / iAvgIndex;
            //hmi_data_ai03avg = hmi_data_ai03avg + ((float)plc_data_ai[2] - hmi_data_ai03avg) / iAvgIndex;
            //hmi_data_ai04avg = hmi_data_ai04avg + ((float)plc_data_ai[3] - hmi_data_ai04avg) / iAvgIndex;
            //hmi_data_ai05avg = hmi_data_ai05avg + ((float)plc_data_ai[4] - hmi_data_ai05avg) / iAvgIndex;
            //hmi_data_ai06avg = hmi_data_ai06avg + ((float)plc_data_ai[5] - hmi_data_ai06avg) / iAvgIndex;
            //hmi_data_ai07avg = hmi_data_ai07avg + ((float)plc_data_ai[6] - hmi_data_ai07avg) / iAvgIndex;
            //hmi_data_ai08avg = hmi_data_ai08avg + ((float)plc_data_ai[7] - hmi_data_ai08avg) / iAvgIndex;
            //hmi_data_ai09avg = hmi_data_ai09avg + ((float)plc_data_ai[8] - hmi_data_ai09avg) / iAvgIndex;
            //hmi_data_ai10avg = hmi_data_ai10avg + ((float)plc_data_ai[9] - hmi_data_ai10avg) / iAvgIndex;
            //hmi_data_ai11avg = hmi_data_ai11avg + ((float)plc_data_ai[10] - hmi_data_ai11avg) / iAvgIndex;
            //hmi_data_ai12avg = hmi_data_ai12avg + ((float)plc_data_ai[11] - hmi_data_ai12avg) / iAvgIndex;
            //hmi_data_ao01avg = hmi_data_ao01avg + ((float)plc_data_ao[0] - hmi_data_ao01avg) / iAvgIndex;
            //hmi_data_ao02avg = hmi_data_ao02avg + ((float)plc_data_ao[1] - hmi_data_ao02avg) / iAvgIndex;
            //hmi_data_di01avg = hmi_data_di01avg + ((float)plc_data_di[0] - hmi_data_di01avg) / iAvgIndex;
            //hmi_data_di02avg = hmi_data_di02avg + ((float)plc_data_di[1] - hmi_data_di02avg) / iAvgIndex;
            //hmi_data_di03avg = hmi_data_di03avg + ((float)plc_data_di[2] - hmi_data_di03avg) / iAvgIndex;
            //hmi_data_di04avg = hmi_data_di04avg + ((float)plc_data_di[3] - hmi_data_di04avg) / iAvgIndex;
            //hmi_data_do01avg = hmi_data_do01avg + ((float)plc_data_do[0] - hmi_data_do01avg) / iAvgIndex;
            //hmi_data_do02avg = hmi_data_do02avg + ((float)plc_data_do[1] - hmi_data_do02avg) / iAvgIndex;

            hmi_data_md1avg += ((float)hmi_data[0] - hmi_data_md1avg) / iAvgIndex;
            hmi_data_md2avg += ((float)hmi_data[1] - hmi_data_md2avg) / iAvgIndex;
            hmi_data_md3avg += ((float)hmi_data[2] - hmi_data_md3avg) / iAvgIndex;
            hmi_data_md4avg += ((float)hmi_data[3] - hmi_data_md4avg) / iAvgIndex;
            hmi_data_ai01avg += ((float)plc_data_ai[0] - hmi_data_ai01avg) / iAvgIndex;
            hmi_data_ai02avg += ((float)plc_data_ai[1] - hmi_data_ai02avg) / iAvgIndex;
            hmi_data_ai03avg += ((float)plc_data_ai[2] - hmi_data_ai03avg) / iAvgIndex;
            hmi_data_ai04avg += ((float)plc_data_ai[3] - hmi_data_ai04avg) / iAvgIndex;
            hmi_data_ai05avg += ((float)plc_data_ai[4] - hmi_data_ai05avg) / iAvgIndex;
            hmi_data_ai06avg += ((float)plc_data_ai[5] - hmi_data_ai06avg) / iAvgIndex;
            hmi_data_ai07avg += ((float)plc_data_ai[6] - hmi_data_ai07avg) / iAvgIndex;
            hmi_data_ai08avg += ((float)plc_data_ai[7] - hmi_data_ai08avg) / iAvgIndex;
            hmi_data_ai09avg += ((float)plc_data_ai[8] - hmi_data_ai09avg) / iAvgIndex;
            hmi_data_ai10avg += ((float)plc_data_ai[9] - hmi_data_ai10avg) / iAvgIndex;
            hmi_data_ai11avg += ((float)plc_data_ai[10] - hmi_data_ai11avg) / iAvgIndex;
            hmi_data_ai12avg += ((float)plc_data_ai[11] - hmi_data_ai12avg) / iAvgIndex;
            hmi_data_ao01avg += ((float)plc_data_ao[0] - hmi_data_ao01avg) / iAvgIndex;
            hmi_data_ao02avg += ((float)plc_data_ao[1] - hmi_data_ao02avg) / iAvgIndex;
            hmi_data_di01avg += ((float)plc_data_di[0] - hmi_data_di01avg) / iAvgIndex;
            hmi_data_di02avg += ((float)plc_data_di[1] - hmi_data_di02avg) / iAvgIndex;
            hmi_data_di03avg += ((float)plc_data_di[2] - hmi_data_di03avg) / iAvgIndex;
            hmi_data_di04avg += ((float)plc_data_di[3] - hmi_data_di04avg) / iAvgIndex;
            hmi_data_do01avg += ((float)plc_data_do[0] - hmi_data_do01avg) / iAvgIndex;
            hmi_data_do02avg += ((float)plc_data_do[1] - hmi_data_do02avg) / iAvgIndex;
        }

        private void UpdateDataTable(DateTime acqStartTime, double[] hmi_data, double[] plc_data_ai, double[] plc_data_ao, double[] plc_data_di, double[] plc_data_do)
        {
            //데이터 테이블

            _curMeasureData.DataNo = aft_mdata_no_idx;
            _curMeasureData.MeasureStarttime = acqStartTime.ToString("yyyy-MM-dd HH:mm:ss");
            _curMeasureData.MeasureHD1 = string.Format("{0:0.0#}", hmi_data[0]);
            _curMeasureData.MeasureHD2 = string.Format("{0:0.0#}", hmi_data[1]);
            _curMeasureData.MeasureHD5 = string.Format("{0:0.0#}", hmi_data[2]);
            _curMeasureData.MeasureHD6 = string.Format("{0:0.0#}", hmi_data[3]);

            _curMeasureData.MeasureAI_01 = string.Format("{0:0.0#}", plc_data_ai[0]);
            _curMeasureData.MeasureAI_02 = string.Format("{0:0.0#}", plc_data_ai[1]);
            _curMeasureData.MeasureAI_03 = string.Format("{0:0.0#}", plc_data_ai[2]);
            _curMeasureData.MeasureAI_04 = string.Format("{0:0.0#}", plc_data_ai[3]);
            _curMeasureData.MeasureAI_05 = string.Format("{0:0.0#}", plc_data_ai[4]);
            _curMeasureData.MeasureAI_06 = string.Format("{0:0.0#}", plc_data_ai[5]);
            _curMeasureData.MeasureAI_07 = string.Format("{0:0.0#}", plc_data_ai[6]);
            _curMeasureData.MeasureAI_08 = string.Format("{0:0.0#}", plc_data_ai[7]);
            _curMeasureData.MeasureAI_09 = string.Format("{0:0.0#}", plc_data_ai[8]);
            _curMeasureData.MeasureAI_10 = string.Format("{0:0.0#}", plc_data_ai[9]);
            _curMeasureData.MeasureAI_11 = string.Format("{0:0.0#}", plc_data_ai[10]);
            _curMeasureData.MeasureAI_12 = string.Format("{0:0.0#}", plc_data_ai[11]);

            _curMeasureData.MeasureAO_01 = string.Format("{0:0.0#}", plc_data_ao[0]);
            _curMeasureData.MeasureAO_02 = string.Format("{0:0.0#}", plc_data_ao[1]);

            _curMeasureData.MeasureDI_01 = string.Format("{0:0.0#}", plc_data_di[0]);
            _curMeasureData.MeasureDI_02 = string.Format("{0:0.0#}", plc_data_di[1]);
            _curMeasureData.MeasureDI_03 = string.Format("{0:0.0#}", plc_data_di[2]);
            _curMeasureData.MeasureDI_04 = string.Format("{0:0.0#}", plc_data_di[3]);

            _curMeasureData.MeasureDO_01 = string.Format("{0:0.0#}", plc_data_do[0]);
            _curMeasureData.MeasureDO_02 = string.Format("{0:0.0#}", plc_data_do[1]);
            cCurrentMdata.Add(_curMeasureData);


            try
            {
                int gridIndex = 0;

                if (aft_mdata_no_idx < fgDataGrid.Rows.Count)
                {
                    gridIndex = aft_mdata_no_idx;
                }
                else
                {

                    if (aft_mdata_no_idx % 100 == 1)
                    {
                        fgDataGrid.Rows.RemoveRange(1, fgDataGrid.Rows.Count - 1);
                        fgDataGrid.Rows.Count = 101;
                        if (aft_mdata_no_idx > 100)
                            ResetChartData_fcDataChart();
                    }
                    if (aft_mdata_no_idx % 100 == 0)
                    {
                        gridIndex = 100;
                    }
                    else
                    {
                        gridIndex = aft_mdata_no_idx % 100; ;
                    }


                }

                int colIndex = 1;

                ChangeFontto10();
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.DataNo;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureStarttime;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureHD1;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureHD2;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureHD5;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureHD6;

                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureAI_01;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureAI_02;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureAI_03;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureAI_04;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureAI_05;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureAI_06;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureAI_07;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureAI_08;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureAI_09;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureAI_10;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureAI_11;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureAI_12;

                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureAO_01;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureAO_02;

                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureDI_01;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureDI_02;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureDI_03;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureDI_04;

                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureDO_01;
                fgDataGrid[gridIndex, colIndex++] = _curMeasureData.MeasureDO_02;

                fgDataGrid.Row = gridIndex;
                fgDataGrid.Col = 1;

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "ChamberAcqData");
                cLog.Error("[" + this.Name + "]\r\n " + ex.ToString());
            }
        }

        private void UpdateDataChart(DateTime acqStartTime, double[] hmi_data, double[] plc_data_ai, double[] plc_data_ao, double[] plc_data_di, double[] plc_data_do)
        {
            //------------chart
            string strxPos1 = acqStartTime.ToString("HH:mm:ss");
            //string strxPos1 = acqStartTime.ToString("yyyy-MM-dd HH:mm:ss");

            //option 데이터 소수점 확인 체크(if문으로 나눔)----예정사항

            obCurTemp1.Add(new DataXY() { PosX = strxPos1, PosY = hmi_data[0] });
            obCurHumi.Add(new DataXY() { PosX = strxPos1, PosY = hmi_data[1] });
            obSetTemp.Add(new DataXY() { PosX = strxPos1, PosY = hmi_data[2] });
            obSetHumi.Add(new DataXY() { PosX = strxPos1, PosY = hmi_data[3] });

            AI01.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_ai[0] });
            AI02.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_ai[1] });
            AI03.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_ai[2] });
            AI04.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_ai[3] });
            AI05.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_ai[4] });
            AI06.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_ai[5] });
            AI07.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_ai[6] });
            AI08.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_ai[7] });
            AI09.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_ai[8] });
            AI10.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_ai[9] });
            AI11.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_ai[10] });
            AI12.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_ai[11] });

            AO01.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_ao[0] });
            AO02.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_ao[1] });

            DI01.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_di[0] });
            DI02.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_di[1] });
            DI03.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_di[2] });
            DI04.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_di[3] });

            DO01.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_do[0] });
            DO02.Add(new DataXY() { PosX = strxPos1, PosY = plc_data_do[1] });

            series1.DataSource = obCurTemp1;
            series3.DataSource = obCurHumi;
            series4.DataSource = obSetTemp;
            series5.DataSource = obSetHumi;
            series6.DataSource = AI01;
            series7.DataSource = AI02;
            series8.DataSource = AI03;
            series9.DataSource = AI04;
            series10.DataSource = AI05;
            series11.DataSource = AI06;
            series12.DataSource = AI07;
            series13.DataSource = AI08;
            series14.DataSource = AI09;
            series15.DataSource = AI10;
            series16.DataSource = AI11;
            series17.DataSource = AI12;
            series18.DataSource = AO01;
            series19.DataSource = AO02;
            series20.DataSource = DI01;
            series21.DataSource = DI02;
            series22.DataSource = DI03;
            series23.DataSource = DI04;
            series24.DataSource = DO01;
            series25.DataSource = DO02;

            //그래프 표시

            fcDataChart.DataSource = obCurTemp1;

            System.Diagnostics.Debug.WriteLine(fcDataChart.DataSource.ToString());
        }

        private void ChangeFontto10()
        {


            if (_curMeasureData.DataNo == 100000 && flag100000 == 0)
            {
                flag100000++;
                fgDataGrid.Cols[1].Style.Font = new Font("나눔고딕", 10, FontStyle.Regular);
            }
        }

        private async void UpdateDbTask(double[] hmi_data, double[] plc_data_ai, double[] plc_data_ao, double[] plc_data_di, double[] plc_data_do, DateTime acqStartTime, DateTime acqEndTime, UInt32 ui32UpdateIndex)
        {
            try
            {
                await Task.Run(() => { ChamberDataDbUpdate(hmi_data, plc_data_ai, plc_data_ao, plc_data_di, plc_data_do, acqStartTime, acqEndTime, ui32UpdateIndex); });

            }
            catch (Exception exc) { System.Diagnostics.Debug.WriteLine(exc.ToString()); }
            finally
            {

            }
        }
        private bool ChamberDataDbUpdate(double[] hmi_data, double[] plc_data_ai, double[] plc_data_ao, double[] plc_data_di, double[] plc_data_do, DateTime acqStartTime, DateTime acqEndTime, UInt32 ui32GetUpdateIndex)
        {
            double md1 = hmi_data[0];
            double md2 = hmi_data[1];
            double md3 = hmi_data[1];
            double md4 = hmi_data[2];
            double md5 = hmi_data[3];
            double ai01 = plc_data_ai[0];
            double ai02 = plc_data_ai[1];
            double ai03 = plc_data_ai[2];
            double ai04 = plc_data_ai[3];
            double ai05 = plc_data_ai[4];
            double ai06 = plc_data_ai[5];
            double ai07 = plc_data_ai[6];
            double ai08 = plc_data_ai[7];
            double ai09 = plc_data_ai[8];
            double ai10 = plc_data_ai[9];
            double ai11 = plc_data_ai[10];
            double ai12 = plc_data_ai[11];
            double ao01 = plc_data_ao[0];
            double ao02 = plc_data_ao[1];
            double di01 = plc_data_di[0];
            double di02 = plc_data_di[1];
            double di03 = plc_data_di[2];
            double di04 = plc_data_di[3];
            double do01 = plc_data_do[0];
            double do02 = plc_data_do[1];
            DateTime startTime = acqStartTime;
            DateTime endTime = acqEndTime;
            UInt32 iUpdateIndex = ui32GetUpdateIndex;
            bool isOK = false;
            string sql;
            try
            {
                Tbl_measure_chamber cTbl_measure_chamber = new Tbl_measure_chamber()
                {
                    msid = measureidText,
                    reqmbid1 = cTbl_recipe.reqmbname,
                    rcpname = cTbl_recipe.name,
                    stdname = cTbl_recipe.stdid1,

                    md1 = md1.ToString(),
                    md2 = md2.ToString(),
                    md3 = md3.ToString(),
                    md4 = md4.ToString(),
                    md5 = md5.ToString(),
                    ai01 = ai01.ToString(),
                    ai02 = ai02.ToString(),
                    ai03 = ai03.ToString(),
                    ai04 = ai04.ToString(),
                    ai05 = ai05.ToString(),
                    ai06 = ai06.ToString(),
                    ai07 = ai07.ToString(),
                    ai08 = ai08.ToString(),
                    ai09 = ai09.ToString(),
                    ai10 = ai10.ToString(),
                    ai11 = ai11.ToString(),
                    ai12 = ai12.ToString(),
                    ao01 = ao01.ToString(),
                    ao02 = ao02.ToString(),
                    di01 = di01.ToString(),
                    di02 = di02.ToString(),
                    di03 = di03.ToString(),
                    di04 = di04.ToString(),
                    do01 = do01.ToString(),
                    do02 = do02.ToString(),
                    divno = measurediv,
                    totalstarttime = startTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    totalendtime = endTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    method = cTbl_recipe.method
                };



                if (iNowMeasurementType == (int)MeasurementType.New)
                {

                    //queue 데이터 insert
                    sql = $@"insert into tbl_measure_chamber 
                                                (reqmbid1, rcpname,stdname, msid,
                                               md1, md2, md3, md4, md5, ai01, ai02, ai03, ai04, ai05, ai06, ai07, ai08, ai09, ai10, ai11, ai12,ao01, ao02,di01,di02,di03,di04,do01,do02,
                                                reqsampleid1, divno,totalstarttime,totalendtime,method)
                                                
                                values (
                                            '{cTbl_measure_chamber.reqmbid1}', '{cTbl_measure_chamber.rcpname}', '{cTbl_measure_chamber.stdname}','{cTbl_measure_chamber.msid}',
                                            '{cTbl_measure_chamber.md1}', '{cTbl_measure_chamber.md2}', '{cTbl_measure_chamber.md3}','{cTbl_measure_chamber.md4}','{cTbl_measure_chamber.md5}', '{cTbl_measure_chamber.ai01}', '{cTbl_measure_chamber.ai02}','{cTbl_measure_chamber.ai03}', '{cTbl_measure_chamber.ai04}', 
                                            '{cTbl_measure_chamber.ai05}', '{cTbl_measure_chamber.ai06}', '{cTbl_measure_chamber.ai07}','{cTbl_measure_chamber.ai08}','{cTbl_measure_chamber.ai09}', '{cTbl_measure_chamber.ai10}', '{cTbl_measure_chamber.ai11}','{cTbl_measure_chamber.ai12}', '{cTbl_measure_chamber.ao01}', 
                                            '{cTbl_measure_chamber.ao02}', '{cTbl_measure_chamber.di01}', '{cTbl_measure_chamber.di02}','{cTbl_measure_chamber.di03}','{cTbl_measure_chamber.di04}', '{cTbl_measure_chamber.do01}', '{cTbl_measure_chamber.do02}', 
                                            '{cTbl_measure_chamber.reqsampleid1}', '{cTbl_measure_chamber.divno}', '{cTbl_measure_chamber.totalstarttime}','{cTbl_measure_chamber.totalendtime}','{cTbl_measure_chamber.method}')";



                    msdto.OpenKeepUp();
                    if (Measure.isChamberDBUpdate == false) { }
                    else
                    {
                        msdto.RunSql("INSERT", sql);
                        UpdateDbMeasureResultStatistics();
                    }
                    isOK = true;
                }
                else if (iNowMeasurementType == (int)MeasurementType.Retry)
                {
                    UInt32 iIndex = iUpdateIndex;
                    cTbl_measure_chamber.chamberno = iIndex;
                    sql = $@"INSERT INTO tbl_measure_chamber (chamberno,reqmbid1, rcpname,stdname, msid, md1, md2, md3, md4, md5, ai01, ai02, ai03, ai04, ai05, ai06, ai07, ai08, ai09, ai10, ai11, ai12,ao01, ao02,di01,di02,di03,di04,do01,do02, divno,totalstarttime, totalendtime, method) 
                                            VALUES ( {iIndex},'{cTbl_recipe.reqmbname}', '{cTbl_recipe.name}', '{cTbl_recipe.stdid1}','{cTbl_measure_chamber.msid}', 
                                            '{cTbl_measure_chamber.md1}', '{cTbl_measure_chamber.md2}', '{cTbl_measure_chamber.md3}','{cTbl_measure_chamber.md4}','{cTbl_measure_chamber.md5}', '{cTbl_measure_chamber.ai01}', '{cTbl_measure_chamber.ai02}','{cTbl_measure_chamber.ai03}', '{cTbl_measure_chamber.ai04}', 
                                            '{cTbl_measure_chamber.ai05}', '{cTbl_measure_chamber.ai06}', '{cTbl_measure_chamber.ai07}','{cTbl_measure_chamber.ai08}','{cTbl_measure_chamber.ai09}', '{cTbl_measure_chamber.ai10}', '{cTbl_measure_chamber.ai11}','{cTbl_measure_chamber.ai12}', '{cTbl_measure_chamber.ao01}', 
                                            '{cTbl_measure_chamber.ao02}', '{cTbl_measure_chamber.di01}', '{cTbl_measure_chamber.di02}','{cTbl_measure_chamber.di03}','{cTbl_measure_chamber.di04}', '{cTbl_measure_chamber.do01}', '{cTbl_measure_chamber.do02}',
                                            '{measurediv}', '{cTbl_measure_chamber.totalstarttime}','{cTbl_measure_chamber.totalendtime}','{cTbl_recipe.method}')
                                            ON DUPLICATE KEY 
                                            UPDATE 
                                                            chamberno={cTbl_measure_chamber.chamberno},
                                                           totalstarttime = '{cTbl_measure_chamber.totalstarttime}',
                                                           totalendtime = '{cTbl_measure_chamber.totalendtime}',
                                                           md1='{cTbl_measure_chamber.md1}',
                                                           md2='{cTbl_measure_chamber.md2}',
                                                           md3='{cTbl_measure_chamber.md3}',
                                                           md4='{cTbl_measure_chamber.md4}',
                                                           md5='{cTbl_measure_chamber.md5}',
                                                           ai01='{cTbl_measure_chamber.ai01}',
                                                           ai02='{cTbl_measure_chamber.ai02}',
                                                           ai03='{cTbl_measure_chamber.ai03}',
                                                           ai04='{cTbl_measure_chamber.ai04}',
                                                           ai05='{cTbl_measure_chamber.ai05}',
                                                           ai06='{cTbl_measure_chamber.ai06}',
                                                           ai07='{cTbl_measure_chamber.ai07}',
                                                           ai08='{cTbl_measure_chamber.ai08}',
                                                           ai09='{cTbl_measure_chamber.ai09}',
                                                           ai10='{cTbl_measure_chamber.ai10}',
                                                           ai11='{cTbl_measure_chamber.ai11}',
                                                           ai12='{cTbl_measure_chamber.ai12}',
                                                           ao01='{cTbl_measure_chamber.ao01}',
                                                           ao02='{cTbl_measure_chamber.ao02}',
                                                           di01='{cTbl_measure_chamber.di01}',
                                                           di02='{cTbl_measure_chamber.di02}',
                                                           di03='{cTbl_measure_chamber.di03}',
                                                           di04='{cTbl_measure_chamber.di04}',
                                                           do01='{cTbl_measure_chamber.do01}',
                                                           do02='{cTbl_measure_chamber.do02}'";

                    msdto.OpenKeepUp();
                    if (Measure.isChamberDBUpdate == false) { }
                    else
                    {

                        msdto.RunSql("INSERT", sql);
                        UpdateDbMeasureResultStatistics();
                    }
                }

            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine("1410\rn" + exc);
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
                isOK = false;
            }
            finally
            {
                msdto.Close();
            }
            return isOK;
        }

        private int CheckChamberTimer1()
        {
            int iEnded;// = (-1);
            try
            {

                int hour = CalcuChamberTimer();
                iEnded = IsAcqCheck();
                if (iEnded == -1) { }
                else
                {
                    isChamberLoop = false;
                    m_strAcqStdTime = "";
                    DateTime dateTime = DateTime.Now;
                    string strT1 = dateTime.ToString("yyMMddHHmmss");

                    switch (measurediv.ToUpper())
                    {
                        case "C1":

                            LogBoxAdd(m_logbox_title, "완료", strT1);
                            SetStep6ControlEventHandler(true);
                            cLog.Info(cMwlog.MeasureEndEventLog);
                            lblmstart.BackColor = Color.FromArgb(68, 114, 196);
                            break;
                        case "C2":
                            LogBoxAdd(m_logbox_title, "완료", strT1);
                            break;
                    }
                }
            }
            catch (Exception exc)
            {
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
                isChamberLoop = false;
                iEnded = 99;
            }

            return iEnded;
        }

        private enum DateComparisonResult
        {
            Earlier = -1,
            TheSame = 0,
            Later = 1,

        };

        int IsAcqCheck()
        {
            int iEnded = 99;
            switch (Measure.MeasureEndStdType)
            {
                case (byte)MeasureEndStdTypeValue.count_only:
                    if (iAcqCount < iAcqCountMax) iEnded = (int)DateComparisonResult.Earlier;
                    else if (iAcqCount == iAcqCountMax) iEnded = (int)DateComparisonResult.TheSame;
                    else if (iAcqCount > iAcqCountMax) iEnded = (int)DateComparisonResult.Later;
                    break;

                case (byte)MeasureEndStdTypeValue.time_only:
                    iEnded = m_runningTime.CompareTo(m_estEndtime);
                    break;
                case (byte)MeasureEndStdTypeValue.dual:
                    int a = 0;
                    if (iAcqCount < iAcqCountMax) a = (int)DateComparisonResult.Earlier;
                    else if (iAcqCount == iAcqCountMax) a = (int)DateComparisonResult.TheSame;
                    else if (iAcqCount > iAcqCountMax) a = (int)DateComparisonResult.Later;
                    int b = m_runningTime.CompareTo(m_estEndtime);
                    if (a == -1 && (b == 0 || b == 1))
                    {
                        iEnded = 1;//End - update 후 end
                    }
                    else if (a == 0 && b == 0)
                    {
                        iEnded = 2;//End - update 후 end
                    }
                    else if (a == 0 && b == 1)
                    {
                        iEnded = 2;// End - update 후 end
                    }
                    else if (a == 1 && b == 1)
                    {
                        //iEnded = 100;//End  - 제외하고 end
                        iEnded = 2;// End - update 후 end
                    }
                    else if (a == 1 && b == (-1))
                    {
                        iEnded = -1;//Not End - countinue update
                    }
                    else
                    {
                        iEnded = -1;//Not End - countinue update
                    }
                    break;

            }
            return iEnded;
        }

        private bool UpdateDbMeasureResultStatistics()
        {
            bool isOk = false;

            //측정 최종 완료시간
            cTbl_statistics1.mstotalendtime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //평균 계산
            CalculateAVG();

            cTbl_statistics1.msid = measureidText;
            cTbl_statistics1.mbid = Measure.mbid;
            try
            {
                string sql = "";


                List<Dictionary<string, string>> dicReturn1 = new List<Dictionary<string, string>>();
                Dictionary<string, string> row = new Dictionary<string, string>();

                List<Dictionary<string, string>> dicReturn = new List<Dictionary<string, string>>();

                int pkno = 0;

                sql = $@"select msresultno as pkno from tbl_measure_result_statistics tme WHERE  msid='{cTbl_statistics1.msid}';";
                dicReturn = msdto.SelectAll(sql);
                if (dicReturn.Count == 0)
                {
                    sql = $@"select msresultno as pkno from tbl_measure_result_statistics tmrs  ORDER BY msresultno  DESC LIMIT 1;";
                    dicReturn1 = msdto.SelectAll(sql);
                    if (dicReturn1.Count > 0)
                    {
                        row = dicReturn1[0];
                        if (row != null)
                        {
                            List<string> columnlist = new List<string>();
                            foreach (string key in row.Values)
                            {
                                columnlist.Add(key);
                            }
                            pkno = Int32.Parse(columnlist[0]);
                        }
                    }
                    pkno++;
                }
                else
                {

                    if (row != null)
                    {
                        row = dicReturn[0];
                        List<string> columnlist = new List<string>();
                        foreach (string key in row.Values)
                        {
                            columnlist.Add(key);
                        }
                        pkno = Int32.Parse(columnlist[0]);
                    }
                }

                string mstotalstarttime = string.IsNullOrEmpty(cTbl_statistics1.mstotalstarttime) ? "null" : "\'" + cTbl_statistics1.mstotalstarttime + "\'";

                if (CommonClass.IsStdSampleMethodOn)
                {
                    cTbl_statistics1.mbid = fgCallRecipe[1, 3].ToString().Trim();// = "측정자ID";
                    cTbl_statistics1.rcpname = fgCallRecipe[2, 3].ToString().Trim();// = "레시피명";
                    cTbl_statistics1.method = fgCallRecipe[3, 3].ToString().Trim();// = "시험방법";
                }
                else
                {
                    cTbl_statistics1.mbid = fgCallRecipe[1, 3].ToString().Trim();// = "측정자ID";
                    cTbl_statistics1.rcpname = fgCallRecipe[2, 3].ToString().Trim();// = "레시피명";
                    cTbl_statistics1.method = fgCallRecipe[3, 3].ToString().Trim();// = "시험방법";
                    cTbl_statistics1.stdname = "default";
                }



                sql = $@" INSERT INTO tbl_measure_result_statistics (msresultno, msid, mbid, mstotalstarttime, mstotalendtime,rcpname, method,
                                                                     md1avg,md2avg,md3avg,md4avg,ai01avg, ai02avg, ai03avg, ai04avg, ai05avg, ai06avg, ai07avg, ai08avg, ai09avg, ai10avg, ai11avg, ai12avg, ao01avg, ao02avg,di01avg,di02avg,di03avg,di04avg,do01avg,do02avg,
                                                                     md1min,md2min,md3min,md4min,ai01min,ai02min,ai03min,ai04min,ai05min,ai06min,ai07min,ai08min,ai09min,ai10min,ai11min,ai12min,ao01min,ao02min,di01min,di02min,di03min,di04min,do01min,do02min,
                                                                     md1max,md2max,md3max,md4max,ai01max,ai02max,ai03max,ai04max,ai05max,ai06max,ai07max,ai08max,ai09max,ai10max,ai11max,ai12max,ao01max,ao02max,di01max,di02max,di03max,di04max,do01max,do02max)
                                        VALUES ({pkno},'{cTbl_statistics1.msid}', '{cTbl_statistics1.mbid}', {mstotalstarttime}, '{cTbl_statistics1.mstotalendtime}', 
                                                '{cTbl_statistics1.rcpname}', '{cTbl_statistics1.method}',
                                                '{cTbl_statistics1.md1avg}', '{cTbl_statistics1.md2avg}', '{cTbl_statistics1.md3avg}', '{cTbl_statistics1.md4avg}', '{cTbl_statistics1.ai01avg}', '{cTbl_statistics1.ai02avg}', '{cTbl_statistics1.ai03avg}', '{cTbl_statistics1.ai04avg}', '{cTbl_statistics1.ai05avg}','{cTbl_statistics1.ai06avg}', '{cTbl_statistics1.ai07avg}', '{cTbl_statistics1.ai08avg}', '{cTbl_statistics1.ai09avg}', '{cTbl_statistics1.ai10avg}', '{cTbl_statistics1.ai11avg}','{cTbl_statistics1.ai12avg}',
                                                '{cTbl_statistics1.ao01avg}', '{cTbl_statistics1.ao02avg}', '{cTbl_statistics1.di01avg}','{cTbl_statistics1.di02avg}', '{cTbl_statistics1.di03avg}', '{cTbl_statistics1.di04avg}', '{cTbl_statistics1.do01avg}', '{cTbl_statistics1.do02avg}', 
                                                '{md1min}', '{md2min}', '{md3min}', '{md4min}', '{ai01min}', '{ai02min}', '{ai03min}', '{ai04min}', '{ai05min}','{ai06min}', '{ai07min}', '{ai08min}', '{ai09min}', '{ai10min}', '{ai11min}','{ai12min}',
                                                '{ao01min}', '{ao02min}', '{di01min}','{di02min}', '{di03min}', '{di04min}', '{do01min}', '{do02min}', 
                                                '{md1max}', '{md2max}', '{md3max}', '{md4max}', '{ai01max}', '{ai02max}', '{ai03max}', '{ai04max}', '{ai05max}','{ai06max}', '{ai07max}', '{ai08max}', '{ai09max}', '{ai10max}', '{ai11max}','{ai12max}',
                                                '{ao01max}', '{ao02max}', '{di01max}','{di02max}', '{di03max}', '{di04max}', '{do01max}', '{do02max}' 
                                              )
                        ON DUPLICATE KEY  
                             UPDATE
                                        msresultno={pkno},
                                        mstotalendtime = {mstotalstarttime},
                                       md1avg='{cTbl_statistics1.md1avg}',
                                       md2avg='{cTbl_statistics1.md2avg}',
                                       md3avg='{cTbl_statistics1.md3avg}',
                                       md4avg='{cTbl_statistics1.md4avg}',
                                       ai01avg='{cTbl_statistics1.ai01avg}',
                                       ai02avg='{cTbl_statistics1.ai02avg}',
                                       ai03avg='{cTbl_statistics1.ai03avg}',
                                       ai04avg='{cTbl_statistics1.ai04avg}',
                                       ai05avg='{cTbl_statistics1.ai05avg}',
                                       ai06avg='{cTbl_statistics1.ai06avg}',
                                       ai07avg='{cTbl_statistics1.ai07avg}',
                                       ai08avg='{cTbl_statistics1.ai08avg}',
                                       ai09avg='{cTbl_statistics1.ai09avg}',
                                       ai10avg='{cTbl_statistics1.ai10avg}',
                                       ai11avg='{cTbl_statistics1.ai11avg}',
                                       ai12avg='{cTbl_statistics1.ai12avg}',
                                       ao01avg='{cTbl_statistics1.ao01avg}',
                                       ao02avg='{cTbl_statistics1.ao02avg}',
                                       di01avg='{cTbl_statistics1.di01avg}',
                                       di02avg='{cTbl_statistics1.di02avg}',
                                       di03avg='{cTbl_statistics1.di03avg}',
                                       di04avg='{cTbl_statistics1.di04avg}',
                                       do01avg='{cTbl_statistics1.do01avg}',
                                       do02avg='{cTbl_statistics1.do02avg}',

                                       md1min='{md1min}',
                                       md2min='{md2min}',
                                       md3min='{md3min}',
                                       md4min='{md4min}',
                                       ai01min='{ai01min}',
                                       ai02min='{ai02min}',
                                       ai03min='{ai03min}',
                                       ai04min='{ai04min}',
                                       ai05min='{ai05min}',
                                       ai06min='{ai06min}',
                                       ai07min='{ai07min}',
                                       ai08min='{ai08min}',
                                       ai09min='{ai09min}',
                                       ai10min='{ai10min}',
                                       ai11min='{ai11min}',
                                       ai12min='{ai12min}',
                                       ao01min='{ao01min}',
                                       ao02min='{ao02min}',
                                       di01min='{di01min}',
                                       di02min='{di02min}',
                                       di03min='{di03min}',
                                       di04min='{di04min}',
                                       do01min='{do01min}',
                                       do02min='{do02min}',

                                       md1max='{md1max}',
                                       md2max='{md2max}',
                                       md3max='{md3max}',
                                       md4max='{md4max}',
                                       ai01max='{ai01max}',
                                       ai02max='{ai02max}',
                                       ai03max='{ai03max}',
                                       ai04max='{ai04max}',
                                       ai05max='{ai05max}',
                                       ai06max='{ai06max}',
                                       ai07max='{ai07max}',
                                       ai08max='{ai08max}',
                                       ai09max='{ai09max}',
                                       ai10max='{ai10max}',
                                       ai11max='{ai11max}',
                                       ai12max='{ai12max}',
                                       ao01max='{ao01max}',
                                       ao02max='{ao02max}',
                                       di01max='{di01max}',
                                       di02max='{di02max}',
                                       di03max='{di03max}',
                                       di04max='{di04max}',
                                       do01max='{do01max}',
                                       do02max='{do02max}'";

                isOk = msdto.RunSql("INSERT_OR_UPDATE", sql);


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
                isOk = false;
            }
            finally
            {
                msdto.Close();
            }
            return isOk;
        }

        private void CalculateAVG()
        {
            try
            {
                cTbl_statistics1.md1avg = String.Format("{0,10:N1}", hmi_data_md1avg);
                cTbl_statistics1.md2avg = String.Format("{0,10:N1}", hmi_data_md2avg);
                cTbl_statistics1.md3avg = String.Format("{0,10:N1}", hmi_data_md3avg);
                cTbl_statistics1.md4avg = String.Format("{0,10:N1}", hmi_data_md4avg);

                cTbl_statistics1.ai01avg = String.Format("{0,10:N1}", hmi_data_ai01avg);
                cTbl_statistics1.ai02avg = String.Format("{0,10:N1}", hmi_data_ai02avg);
                cTbl_statistics1.ai03avg = String.Format("{0,10:N1}", hmi_data_ai03avg);
                cTbl_statistics1.ai04avg = String.Format("{0,10:N1}", hmi_data_ai04avg);
                cTbl_statistics1.ai05avg = String.Format("{0,10:N1}", hmi_data_ai05avg);
                cTbl_statistics1.ai06avg = String.Format("{0,10:N1}", hmi_data_ai06avg);
                cTbl_statistics1.ai07avg = String.Format("{0,10:N1}", hmi_data_ai07avg);
                cTbl_statistics1.ai08avg = String.Format("{0,10:N1}", hmi_data_ai08avg);
                cTbl_statistics1.ai09avg = String.Format("{0,10:N1}", hmi_data_ai09avg);
                cTbl_statistics1.ai10avg = String.Format("{0,10:N1}", hmi_data_ai10avg);
                cTbl_statistics1.ai11avg = String.Format("{0,10:N1}", hmi_data_ai11avg);
                cTbl_statistics1.ai12avg = String.Format("{0,10:N1}", hmi_data_ai12avg);
                cTbl_statistics1.ao01avg = String.Format("{0,10:N1}", hmi_data_ao01avg);
                cTbl_statistics1.ao02avg = String.Format("{0,10:N1}", hmi_data_ao02avg);
                cTbl_statistics1.di01avg = String.Format("{0,10:N1}", hmi_data_di01avg);
                cTbl_statistics1.di02avg = String.Format("{0,10:N1}", hmi_data_di02avg);
                cTbl_statistics1.di03avg = String.Format("{0,10:N1}", hmi_data_di03avg);
                cTbl_statistics1.di04avg = String.Format("{0,10:N1}", hmi_data_di04avg);
                cTbl_statistics1.do01avg = String.Format("{0,10:N1}", hmi_data_do01avg);
                cTbl_statistics1.do02avg = String.Format("{0,10:N1}", hmi_data_do02avg);
            }
            catch (Exception exc)
            {
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }


        }


        private void BtnRunModeATMT_Click(object sender, EventArgs e)
        {

            IsManualRunOn = !IsManualRunOn;

            if (IsManualRunOn)
            {
                IsManualRunOn = true;
                btnRunModeAtMt.BackColor = System.Drawing.Color.FromArgb(255, 195, 89);
                btnRunModeAtMt.Text = "수동운전";
                lblShowStatus.Text = "수동운전으로 변경합니다";
                cLog.Info(cMwlog.ManualModeClickEventLog);
                EventButtonsSettings(true);
                ButtonsTitleSetting("M");
                ButtonsColor();
            }
            else
            {
                IsManualRunOn = false;
                btnRunModeAtMt.BackColor = System.Drawing.Color.FromArgb(114, 124, 245);
                btnRunModeAtMt.Text = "자동운전";
                lblShowStatus.Text = "자동운전으로 변경합니다";
                cLog.Info(cMwlog.AutoModeClickEventLog);
                EventButtonsSettings(false);
                btnrcp.Enabled = true;
                ButtonsTitleSetting("A");
                ButtonsColor();
            }
        }

        private void FgMeasureBaseInfo_Click(object sender, EventArgs e)
        {
            measureidText = fgMeasureBaseInfo[1, 3].ToString();

        }
    }
}

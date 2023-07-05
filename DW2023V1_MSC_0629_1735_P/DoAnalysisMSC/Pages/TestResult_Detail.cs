using DBMS_V1;
using EventLog;
using log4net;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Series = C1.Win.Chart.Series;

namespace DoAnalysisMSC.Pages
{
    public partial class TestResult_Detail : Form
    {
        // 디자인 영역====================================================================================================================
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestResult_Detail));
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEndSec = new C1.Win.C1Input.C1ComboBox();
            this.cbxEndMinute = new C1.Win.C1Input.C1ComboBox();
            this.cbxPeriod = new C1.Win.C1Input.C1ComboBox();
            this.cbxEndHour = new C1.Win.C1Input.C1ComboBox();
            this.btnSendCSV = new System.Windows.Forms.Button();
            this.cbxStartSec = new C1.Win.C1Input.C1ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.fgMeasureList = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.fgMeasureBaseInfo = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fcMeasureData = new C1.Win.Chart.FlexChart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvMeasureDetail = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvreqmbname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvreqsamplename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxStartMinute = new C1.Win.C1Input.C1ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxStartHour = new C1.Win.C1Input.C1ComboBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.dpenddate = new System.Windows.Forms.DateTimePicker();
            this.dpstartdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEndSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEndMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStartSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgMeasureList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgMeasureBaseInfo)).BeginInit();
            this.tab1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcMeasureData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasureDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStartMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cbxEndSec);
            this.splitContainer1.Panel2.Controls.Add(this.cbxEndMinute);
            this.splitContainer1.Panel2.Controls.Add(this.cbxPeriod);
            this.splitContainer1.Panel2.Controls.Add(this.cbxEndHour);
            this.splitContainer1.Panel2.Controls.Add(this.btnSendCSV);
            this.splitContainer1.Panel2.Controls.Add(this.cbxStartSec);
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.cbxStartMinute);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.cbxStartHour);
            this.splitContainer1.Panel2.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel2.Controls.Add(this.btnExport);
            this.splitContainer1.Panel2.Controls.Add(this.dpenddate);
            this.splitContainer1.Panel2.Controls.Add(this.dpstartdate);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(1640, 950);
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "측정이력조회";
            // 
            // cbxEndSec
            // 
            this.cbxEndSec.AllowSpinLoop = false;
            this.cbxEndSec.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxEndSec.GapHeight = 0;
            this.cbxEndSec.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxEndSec.Location = new System.Drawing.Point(976, 45);
            this.cbxEndSec.Name = "cbxEndSec";
            this.cbxEndSec.Size = new System.Drawing.Size(70, 32);
            this.cbxEndSec.TabIndex = 156;
            this.cbxEndSec.Tag = null;
            this.cbxEndSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxEndMinute
            // 
            this.cbxEndMinute.AllowSpinLoop = false;
            this.cbxEndMinute.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxEndMinute.GapHeight = 0;
            this.cbxEndMinute.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxEndMinute.Location = new System.Drawing.Point(900, 45);
            this.cbxEndMinute.Name = "cbxEndMinute";
            this.cbxEndMinute.Size = new System.Drawing.Size(70, 32);
            this.cbxEndMinute.TabIndex = 155;
            this.cbxEndMinute.Tag = null;
            this.cbxEndMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxPeriod
            // 
            this.cbxPeriod.AllowSpinLoop = false;
            this.cbxPeriod.BackColor = System.Drawing.Color.White;
            this.cbxPeriod.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxPeriod.DropDownStyle = C1.Win.C1Input.DropDownStyle.DropDownList;
            this.cbxPeriod.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxPeriod.GapHeight = 0;
            this.cbxPeriod.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxPeriod.Items.Add("당일");
            this.cbxPeriod.Items.Add("1일");
            this.cbxPeriod.Items.Add("7일");
            this.cbxPeriod.Items.Add("30일");
            this.cbxPeriod.Location = new System.Drawing.Point(149, 45);
            this.cbxPeriod.Name = "cbxPeriod";
            this.cbxPeriod.Size = new System.Drawing.Size(132, 32);
            this.cbxPeriod.TabIndex = 20;
            this.cbxPeriod.Tag = null;
            this.cbxPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbxPeriod.SelectedItemChanged += new System.EventHandler(this.CbxPeriod_SelectedItemChanged);
            this.cbxPeriod.TextChanged += new System.EventHandler(this.CbxPeriod_TextChanged);
            // 
            // cbxEndHour
            // 
            this.cbxEndHour.AllowSpinLoop = false;
            this.cbxEndHour.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxEndHour.GapHeight = 0;
            this.cbxEndHour.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxEndHour.Location = new System.Drawing.Point(824, 45);
            this.cbxEndHour.Name = "cbxEndHour";
            this.cbxEndHour.Size = new System.Drawing.Size(70, 32);
            this.cbxEndHour.TabIndex = 154;
            this.cbxEndHour.Tag = null;
            this.cbxEndHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSendCSV
            // 
            this.btnSendCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnSendCSV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnSendCSV.FlatAppearance.BorderSize = 0;
            this.btnSendCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCSV.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSendCSV.Location = new System.Drawing.Point(1167, 43);
            this.btnSendCSV.Name = "btnSendCSV";
            this.btnSendCSV.Size = new System.Drawing.Size(230, 32);
            this.btnSendCSV.TabIndex = 19;
            this.btnSendCSV.Text = "목록 CSV내보내기";
            this.btnSendCSV.UseVisualStyleBackColor = false;
            this.btnSendCSV.Click += new System.EventHandler(this.BtnSendCSV_Click);
            // 
            // cbxStartSec
            // 
            this.cbxStartSec.AllowSpinLoop = false;
            this.cbxStartSec.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxStartSec.GapHeight = 0;
            this.cbxStartSec.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxStartSec.Location = new System.Drawing.Point(576, 45);
            this.cbxStartSec.Name = "cbxStartSec";
            this.cbxStartSec.Size = new System.Drawing.Size(70, 32);
            this.cbxStartSec.TabIndex = 153;
            this.cbxStartSec.Tag = null;
            this.cbxStartSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitContainer2
            // 
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 90);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.fgMeasureList);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.fgMeasureBaseInfo);
            this.splitContainer2.Panel2.Controls.Add(this.tab1);
            this.splitContainer2.Size = new System.Drawing.Size(1640, 821);
            this.splitContainer2.SplitterDistance = 460;
            this.splitContainer2.TabIndex = 18;
            // 
            // fgMeasureList
            // 
            this.fgMeasureList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.fgMeasureList.AllowEditing = false;
            this.fgMeasureList.AllowNodeCellCheck = false;
            this.fgMeasureList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fgMeasureList.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgMeasureList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgMeasureList.ColumnInfo = resources.GetString("fgMeasureList.ColumnInfo");
            this.fgMeasureList.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.fgMeasureList.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.fgMeasureList.ColumnPickerInfo.ShowToolButton = false;
            this.fgMeasureList.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fgMeasureList.Location = new System.Drawing.Point(4, 3);
            this.fgMeasureList.Name = "fgMeasureList";
            this.fgMeasureList.Rows.Count = 30;
            this.fgMeasureList.Rows.DefaultSize = 40;
            this.fgMeasureList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgMeasureList.Size = new System.Drawing.Size(443, 796);
            this.fgMeasureList.StyleInfo = resources.GetString("fgMeasureList.StyleInfo");
            this.fgMeasureList.TabIndex = 15;
            this.fgMeasureList.UseCompatibleTextRendering = false;
            this.fgMeasureList.Click += new System.EventHandler(this.FgMeasureList_Click);
            // 
            // fgMeasureBaseInfo
            // 
            this.fgMeasureBaseInfo.AllowEditing = false;
            this.fgMeasureBaseInfo.BackColor = System.Drawing.Color.White;
            this.fgMeasureBaseInfo.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgMeasureBaseInfo.ColumnInfo = resources.GetString("fgMeasureBaseInfo.ColumnInfo");
            this.fgMeasureBaseInfo.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.fgMeasureBaseInfo.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.fgMeasureBaseInfo.ColumnPickerInfo.ShowToolButton = false;
            this.fgMeasureBaseInfo.Location = new System.Drawing.Point(4, 3);
            this.fgMeasureBaseInfo.Name = "fgMeasureBaseInfo";
            this.fgMeasureBaseInfo.Rows.Count = 2;
            this.fgMeasureBaseInfo.Rows.DefaultSize = 25;
            this.fgMeasureBaseInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fgMeasureBaseInfo.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgMeasureBaseInfo.Size = new System.Drawing.Size(1165, 54);
            this.fgMeasureBaseInfo.StyleInfo = resources.GetString("fgMeasureBaseInfo.StyleInfo");
            this.fgMeasureBaseInfo.TabIndex = 150;
            this.fgMeasureBaseInfo.UseCompatibleTextRendering = false;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Controls.Add(this.tabPage2);
            this.tab1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tab1.Location = new System.Drawing.Point(4, 89);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(1165, 710);
            this.tab1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.fcMeasureData);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1157, 678);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "스팩트럼";
            // 
            // fcMeasureData
            // 
            this.fcMeasureData.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.fcMeasureData.AnimationLoad.Duration = 400;
            this.fcMeasureData.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.fcMeasureData.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.fcMeasureData.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.fcMeasureData.AnimationUpdate.Duration = 400;
            this.fcMeasureData.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.fcMeasureData.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.fcMeasureData.AxisX.AxisLine = true;
            this.fcMeasureData.AxisX.Chart = this.fcMeasureData;
            this.fcMeasureData.AxisX.DataSource = null;
            this.fcMeasureData.AxisX.GroupProvider = null;
            this.fcMeasureData.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.fcMeasureData.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.fcMeasureData.AxisX.GroupVisibilityLevel = 0;
            this.fcMeasureData.AxisX.LabelMax = false;
            this.fcMeasureData.AxisX.LabelMin = false;
            this.fcMeasureData.AxisX.PlotAreaName = null;
            this.fcMeasureData.AxisX.Position = C1.Chart.Position.Bottom;
            this.fcMeasureData.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.fcMeasureData.AxisY.AxisLine = false;
            this.fcMeasureData.AxisY.Chart = this.fcMeasureData;
            this.fcMeasureData.AxisY.DataSource = null;
            this.fcMeasureData.AxisY.GroupProvider = null;
            this.fcMeasureData.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.fcMeasureData.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.fcMeasureData.AxisY.GroupVisibilityLevel = 0;
            this.fcMeasureData.AxisY.LabelMax = false;
            this.fcMeasureData.AxisY.LabelMin = false;
            this.fcMeasureData.AxisY.MajorGrid = true;
            this.fcMeasureData.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.fcMeasureData.AxisY.PlotAreaName = null;
            this.fcMeasureData.AxisY.Position = C1.Chart.Position.Left;
            this.fcMeasureData.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.fcMeasureData.BindingX = "strxPos";
            this.fcMeasureData.ChartType = C1.Chart.ChartType.LineSymbols;
            this.fcMeasureData.DataLabel.Angle = 0;
            this.fcMeasureData.DataLabel.Border = false;
            this.fcMeasureData.DataLabel.ConnectingLine = false;
            this.fcMeasureData.DataLabel.Content = null;
            this.fcMeasureData.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.fcMeasureData.DataLabel.MaxAutoLabels = 100;
            this.fcMeasureData.DataLabel.MaxLines = 0;
            this.fcMeasureData.DataLabel.MaxWidth = 0;
            this.fcMeasureData.DataLabel.Offset = 0;
            this.fcMeasureData.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.fcMeasureData.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.fcMeasureData.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.fcMeasureData.Legend.ItemMaxWidth = 0;
            this.fcMeasureData.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.fcMeasureData.Legend.Position = C1.Chart.Position.Right;
            this.fcMeasureData.Legend.Reversed = false;
            this.fcMeasureData.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.fcMeasureData.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.fcMeasureData.Legend.Title = null;
            this.fcMeasureData.LegendToggle = true;
            this.fcMeasureData.Location = new System.Drawing.Point(9, 8);
            this.fcMeasureData.Margin = new System.Windows.Forms.Padding(10);
            this.fcMeasureData.Name = "fcMeasureData";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.fcMeasureData.Options.ClusterSize = elementSize1;
            this.fcMeasureData.PlotMargin = new System.Windows.Forms.Padding(0);
            this.fcMeasureData.SelectedSeries = null;
            this.fcMeasureData.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.fcMeasureData.Size = new System.Drawing.Size(1132, 657);
            this.fcMeasureData.TabIndex = 0;
            this.fcMeasureData.Text = "flexChart1";
            // 
            // 
            // 
            this.fcMeasureData.ToolTip.Content = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvMeasureDetail);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1157, 678);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "데이터";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMeasureDetail
            // 
            this.dgvMeasureDetail.AllowUserToAddRows = false;
            this.dgvMeasureDetail.AllowUserToDeleteRows = false;
            this.dgvMeasureDetail.AllowUserToResizeColumns = false;
            this.dgvMeasureDetail.AllowUserToResizeRows = false;
            this.dgvMeasureDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeasureDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvMeasureDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeasureDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMeasureDetail.ColumnHeadersHeight = 50;
            this.dgvMeasureDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMeasureDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewTextBoxColumn19,
            this.dgvreqmbname,
            this.dataGridViewTextBoxColumn21,
            this.dgvreqsamplename,
            this.dataGridViewTextBoxColumn23,
            this.Column3,
            this.Column1,
            this.Column4});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMeasureDetail.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvMeasureDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvMeasureDetail.EnableHeadersVisualStyles = false;
            this.dgvMeasureDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvMeasureDetail.Location = new System.Drawing.Point(-4, 6);
            this.dgvMeasureDetail.MultiSelect = false;
            this.dgvMeasureDetail.Name = "dgvMeasureDetail";
            this.dgvMeasureDetail.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMeasureDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvMeasureDetail.RowHeadersVisible = false;
            this.dgvMeasureDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMeasureDetail.RowTemplate.Height = 23;
            this.dgvMeasureDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeasureDetail.Size = new System.Drawing.Size(1158, 676);
            this.dgvMeasureDetail.TabIndex = 148;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "NO";
            this.Column2.MinimumWidth = 95;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ch";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn19.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn19.FillWeight = 50F;
            this.dataGridViewTextBoxColumn19.HeaderText = "채널";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn19.Width = 80;
            // 
            // dgvreqmbname
            // 
            this.dgvreqmbname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvreqmbname.DataPropertyName = "reqmbname";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvreqmbname.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvreqmbname.HeaderText = "의뢰자명";
            this.dgvreqmbname.MinimumWidth = 150;
            this.dgvreqmbname.Name = "dgvreqmbname";
            this.dgvreqmbname.ReadOnly = true;
            this.dgvreqmbname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvreqmbname.Width = 173;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn21.DataPropertyName = "reqmbid";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn21.HeaderText = "의뢰자ID";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn21.Width = 173;
            // 
            // dgvreqsamplename
            // 
            this.dgvreqsamplename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvreqsamplename.DataPropertyName = "reqsamplename";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvreqsamplename.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvreqsamplename.HeaderText = "의뢰자샘플명";
            this.dgvreqsamplename.MinimumWidth = 150;
            this.dgvreqsamplename.Name = "dgvreqsamplename";
            this.dgvreqsamplename.ReadOnly = true;
            this.dgvreqsamplename.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvreqsamplename.Width = 173;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn23.DataPropertyName = "reqsampleid";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn23.HeaderText = "의뢰자샘플ID";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 173;
            // 
            // Column3
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column3.HeaderText = "누적 최소";
            this.Column3.MinimumWidth = 96;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column1.HeaderText = "누적 최대";
            this.Column1.MinimumWidth = 96;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("나눔고딕", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column4.HeaderText = "누적 평균";
            this.Column4.MinimumWidth = 96;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // cbxStartMinute
            // 
            this.cbxStartMinute.AllowSpinLoop = false;
            this.cbxStartMinute.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxStartMinute.GapHeight = 0;
            this.cbxStartMinute.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxStartMinute.Location = new System.Drawing.Point(500, 45);
            this.cbxStartMinute.Name = "cbxStartMinute";
            this.cbxStartMinute.Size = new System.Drawing.Size(70, 32);
            this.cbxStartMinute.TabIndex = 152;
            this.cbxStartMinute.Tag = null;
            this.cbxStartMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(655, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "~";
            // 
            // cbxStartHour
            // 
            this.cbxStartHour.AllowSpinLoop = false;
            this.cbxStartHour.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxStartHour.GapHeight = 0;
            this.cbxStartHour.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxStartHour.Location = new System.Drawing.Point(424, 45);
            this.cbxStartHour.Name = "cbxStartHour";
            this.cbxStartHour.Size = new System.Drawing.Size(70, 32);
            this.cbxStartHour.TabIndex = 151;
            this.cbxStartHour.Tag = null;
            this.cbxStartHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(124)))), ((int)(((byte)(245)))));
            this.btnSearch.Image = global::DoAnalysisMSC.Properties.Resources.find;
            this.btnSearch.Location = new System.Drawing.Point(1063, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 15;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExport.Location = new System.Drawing.Point(1403, 43);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(230, 32);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "선택 테스트결과 레포트";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // dpenddate
            // 
            this.dpenddate.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpenddate.Location = new System.Drawing.Point(691, 45);
            this.dpenddate.MaximumSize = new System.Drawing.Size(130, 32);
            this.dpenddate.MinimumSize = new System.Drawing.Size(130, 32);
            this.dpenddate.Name = "dpenddate";
            this.dpenddate.Size = new System.Drawing.Size(130, 32);
            this.dpenddate.TabIndex = 4;
            // 
            // dpstartdate
            // 
            this.dpstartdate.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpstartdate.Location = new System.Drawing.Point(289, 45);
            this.dpstartdate.MaximumSize = new System.Drawing.Size(130, 32);
            this.dpstartdate.MinimumSize = new System.Drawing.Size(130, 32);
            this.dpstartdate.Name = "dpstartdate";
            this.dpstartdate.Size = new System.Drawing.Size(130, 32);
            this.dpstartdate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "기간선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "기간별 측정이력 조회";
            // 
            // TestResult_Detail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 950);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestResult_Detail";
            this.Text = "TestResult_Detail";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxEndSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEndMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStartSec)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgMeasureList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgMeasureBaseInfo)).EndInit();
            this.tab1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fcMeasureData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasureDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStartMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpenddate;
        private System.Windows.Forms.DateTimePicker dpstartdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage1;
        private C1.Win.Chart.FlexChart fcMeasureData;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSendCSV;
        private C1.Win.C1FlexGrid.C1FlexGrid fgMeasureList;
        private C1.Win.C1Input.C1ComboBox cbxPeriod;
        private System.Windows.Forms.DataGridView dgvMeasureDetail;
        private C1.Win.C1FlexGrid.C1FlexGrid fgMeasureBaseInfo;
        private C1.Win.C1Input.C1ComboBox cbxEndSec;
        private C1.Win.C1Input.C1ComboBox cbxEndMinute;
        private C1.Win.C1Input.C1ComboBox cbxEndHour;
        private C1.Win.C1Input.C1ComboBox cbxStartSec;
        private C1.Win.C1Input.C1ComboBox cbxStartMinute;
        private C1.Win.C1Input.C1ComboBox cbxStartHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvreqmbname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvreqsamplename;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        //================================================================================================================================


        public TestResult_Detail()
        {
            InitializeComponent();



            for (int i = 0; i < 24; i++)
            {
                cbxStartHour.Items.Add(i.ToString("00"));
                cbxEndHour.Items.Add(i.ToString("00"));
            }

            for (int j = 0; j < 60; j++)
            {
                cbxStartMinute.Items.Add(j.ToString("00"));
                cbxStartSec.Items.Add(j.ToString("00"));
                cbxEndMinute.Items.Add(j.ToString("00"));
                cbxEndSec.Items.Add(j.ToString("00"));
            }
            cbxStartHour.SelectedItem = "00";
            cbxStartMinute.SelectedItem = "00";
            cbxStartSec.SelectedItem = "00";

            cbxEndHour.SelectedItem = "23";
            cbxEndMinute.SelectedItem = "59";
            cbxEndSec.SelectedItem = "59";
        }

        private readonly AnalyzeWriteLog Awlog = new AnalyzeWriteLog();
        private static readonly ILog log = LogManager.GetLogger("Analysis");
        readonly MySqlDTO msdto = new MySqlDTO();
        private DataTable m_dtResultData = new DataTable();
        private DataTable m_dtResultDataTable_grid = new DataTable();

        readonly Series series1 = new Series { Name = "누적 최대", Binding = "PosY" };
        readonly Series series2 = new Series { Name = "누적 최소", Binding = "PosY" };
        readonly Series series3 = new Series { Name = "누적 평균", Binding = "PosY" };
        private readonly ObservableCollection<DataXY> MaxPoints = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> MinPoints = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> AvgPoints = new ObservableCollection<DataXY>() { };

        private void CbxPeriod_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        public void DailyMeasureList()
        {
            string start = dpstartdate.Value.ToString("yyyy-MM-dd");
            string end = dpenddate.Value.ToString("yyyy-MM-dd");
            string h1 = cbxStartHour.SelectedItem.ToString();
            string m1 = cbxStartMinute.SelectedItem.ToString();
            string s1 = cbxStartSec.SelectedItem.ToString();
            string h2 = cbxEndHour.SelectedItem.ToString();
            string m2 = cbxEndMinute.SelectedItem.ToString();
            string s2 = cbxEndSec.SelectedItem.ToString();

            start = start + " " + h1 + ":" + m1 + ":" + s1;
            end = end + " " + h2 + ":" + m2 + ":" + s2;

            string sql = $@"select count(*) as cnt 
                            from (select @num:=0) as s, tbl_measure_result_statistics as t
                            left join tbl_recipe tr 
                            on t.rcpname = tr.name
                            WHERE t.mstotalstarttime >='{start}' AND t.mstotalstarttime <= '{end}' AND not t.mstotalendtime <=> null And tr.name is not null;";

            try
            {


                int rowCnt = Convert.ToInt32(msdto.SelectSql2(sql, "cnt")[0]["cnt"]);

                if (rowCnt == 0)
                {
                    MessageBox.Show("측정 이력이 없습니다.", "측정이력조회", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.Message);
            }

            try
            {
                string dbsql = $@"select (@num:=@num+1) as no,msid,rcpname, t.method as method, mbid, DATE_FORMAT(mstotalstarttime, '%Y-%m-%d %H:%i:%s') AS mstotalstarttime ,
                                  DATE_FORMAT(mstotalendtime, '%Y-%m-%d %H:%i:%s') AS mstotalendtime 
                                  from (select @num:=0) as s, tbl_measure_result_statistics as t
                                  left join tbl_recipe tr 
                                  on t.rcpname = tr.name
                                  WHERE t.mstotalstarttime >='{start}' AND t.mstotalstarttime <='{end}' AND not t.mstotalendtime <=> null and tr.name is not null;";

                List<Dictionary<string, string>> dicReturn1 = new List<Dictionary<string, string>>();
                Dictionary<string, string> row = new Dictionary<string, string>();
                dicReturn1 = msdto.SelectAll(dbsql);
                m_dtResultData = msdto.SelectSqlToDataTable(dbsql);
                m_dtResultDataTable_grid = msdto.SelectSqlToDataTable(dbsql);

                fgMeasureList.SetDataBinding(m_dtResultDataTable_grid, m_dtResultDataTable_grid.TableName, true);
                ChangeHeader();

            }
            catch
            {
                MessageBox.Show("검색한 기간내 측정 이력 정보를 불러오는데 실패했습니다.", "측정이력조회", MessageBoxButtons.OK, MessageBoxIcon.Information);
                log.Error(Awlog.MeasureListSearchError);
                return;
            }

        }

        private void ChangeHeader()
        {
            m_dtResultData.Columns["no"].ColumnName = "NO";
            m_dtResultData.Columns["msid"].ColumnName = "측정ID";
            m_dtResultData.Columns["method"].ColumnName = "시험방법";
            m_dtResultData.Columns["rcpname"].ColumnName = "레시피명";
            m_dtResultData.Columns["mbid"].ColumnName = "측정자";
            m_dtResultData.Columns["mstotalstarttime"].ColumnName = "측정시작시간";
            m_dtResultData.Columns["mstotalendtime"].ColumnName = "측정완료시간";

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            log.Info(Awlog.MeasureListSearchEventLog);
            DailyMeasureList();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                log.Info(Awlog.TestResultEventLog);
                Button btn = sender as Button;
                string msid = (string)fgMeasureList.GetData(fgMeasureList.RowSel, "msid");
                string mbid = (string)fgMeasureList.GetData(fgMeasureList.RowSel, "mbid");
                string rcpname = (string)fgMeasureList.GetData(fgMeasureList.RowSel, "rcpname");
                string reqmbname = dgvMeasureDetail.Rows[4].Cells[2].Value.ToString();

                string strBtnName = "테스트 결과 레포트";

                if (rcpname == null)
                {
                    MessageBox.Show("값이 선택되지 않았습니다", strBtnName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        try
                        {
                            ExportPDF.FrmMain exportwindow = new ExportPDF.FrmMain(msid: msid, ms_mbid: mbid, reqmbname: reqmbname, rcpname: rcpname);

                            if (exportwindow.ShowDialog() == DialogResult.OK)
                            {
                            }
                            else { }
                        }
                        catch
                        {
                            log.Error(Awlog.TestResultError);
                        }
                        finally
                        {
                        }
                    }
                    catch { }
                }
            }
            catch
            {
                MessageBox.Show("측정정보를 선택하세요", "선택테스트결과 레포트", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FgMeasureList_Click(object sender, EventArgs e)
        {
            log.Info(Awlog.ShowMeasureDetailEventLog);


            string msid = (string)fgMeasureList.GetData(fgMeasureList.RowSel, "msid");
            string mbid = (string)fgMeasureList.GetData(fgMeasureList.RowSel, "mbid");
            string rcpname = (string)fgMeasureList.GetData(fgMeasureList.RowSel, "rcpname");

            if (string.IsNullOrEmpty(msid) || string.IsNullOrEmpty(rcpname))
            {
                log.Info("msid 또는 rcpname 가 null 입니다.");
                return;
            }

            ChamberClearSeries();
            ChamberAddSeries();
            dgvMeasureDetail.Rows.Clear();
            for (int i = 1; i <= 24; i++)
            {
                dgvMeasureDetail.Rows.Add(i.ToString());
            }
            for (int i = 2; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dgvMeasureDetail.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(217, 217, 217);
                }
                for (int j = 16; j < 24; j++)
                {
                    dgvMeasureDetail.Rows[j].Cells[i].Style.BackColor = Color.FromArgb(217, 217, 217);
                }
            }

            try
            {
                string dbsql = $"select (@num:=@num+1) as no, msid, DATE_FORMAT(mstotalstarttime, '%Y-%m-%d %H:%i:%s') AS mstotalstarttime, DATE_FORMAT(mstotalendtime, '%Y-%m-%d %H:%i:%s') AS mstotalendtime," +
                    $" rcpname,reqmbname, method, mbid," +
                    $" md1max,md1min,md1avg, md2max,md2min,md2avg, md3max,md3min,md3avg, md4max,md4min,md4avg," +
                    $" ai01max,ai01min,ai01avg, ai02max,ai02min,ai02avg, ai03max,ai03min,ai03avg, ai04max,ai04min,ai04avg, ai05max,ai05min,ai05avg, ai06max,ai06min,ai06avg, ai07max,ai07min,ai07avg, " +
                    $" ai08max,ai08min,ai08avg, ai09max,ai09min,ai09avg, ai10max,ai10min,ai10avg, ai11max,ai11min,ai11avg, ai12max,ai12min, ai12avg," +
                    $" ao01max,ao01min,ao01avg, ao02max,ao02min,ao02avg, di01max,di01min,di01avg, di02max,di02min,di02avg, di03max,di03min,di03avg, di04max,di04min,di04avg, " +
                    $" do01max,do01min,do01avg, do02max,do02min,do02avg" +
                    $" from (select @num:=0) as s, tbl_measure_result_statistics as t  WHERE t.msid = '{msid}' ";

                List<Dictionary<string, string>> dicReturn1 = new List<Dictionary<string, string>>();
                Dictionary<string, string> row = new Dictionary<string, string>();
                dicReturn1 = msdto.SelectAll(dbsql);

                if (dicReturn1.Count == 0)
                {
                    log.Info("db data가 없습니다.");
                    return;
                }
                row = dicReturn1[0];
                fgMeasureBaseInfo[1, 1] = "1";
                fgMeasureBaseInfo[1, 2] = row["msid"];
                fgMeasureBaseInfo[1, 3] = row["method"];
                fgMeasureBaseInfo[1, 4] = row["rcpname"];
                fgMeasureBaseInfo[1, 5] = row["mbid"];

               

                //============테이블 데이터
                if (row != null)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        var sValue = (i + 1).ToString("D1");
  
                        dgvMeasureDetail.Rows[i].Cells[6].Value = row[$"md{sValue}min"].ToString();
                        dgvMeasureDetail.Rows[i].Cells[7].Value = row[$"md{sValue}max"].ToString();
                        dgvMeasureDetail.Rows[i].Cells[8].Value = row[$"md{sValue}avg"].ToString();
                    }
                    for (int i = 0; i < 12; i++)
                    {
                        var sValue = (i + 1).ToString("D2");
                        dgvMeasureDetail.Rows[4 + i].Cells[6].Value = row[$"ai{sValue}min"].ToString();
                        dgvMeasureDetail.Rows[4 + i].Cells[7].Value = row[$"ai{sValue}max"].ToString();
                        dgvMeasureDetail.Rows[4 + i].Cells[8].Value = row[$"ai{sValue}avg"].ToString();
                    }

                    for (int i = 0; i < 2; i++)
                    {
                        var sValue = (i + 1).ToString("D2");
                        dgvMeasureDetail.Rows[16 + i].Cells[6].Value = row[$"ao{sValue}min"].ToString();
                        dgvMeasureDetail.Rows[16 + i].Cells[7].Value = row[$"ao{sValue}max"].ToString();
                        dgvMeasureDetail.Rows[16 + i].Cells[8].Value = row[$"ao{sValue}avg"].ToString();
                    }

                    for (int i = 0; i < 4; i++)
                    {
                        var sValue = (i + 1).ToString("D2");
                        dgvMeasureDetail.Rows[18 + i].Cells[6].Value = row[$"di{sValue}min"].ToString();
                        dgvMeasureDetail.Rows[18 + i].Cells[7].Value = row[$"di{sValue}max"].ToString();
                        dgvMeasureDetail.Rows[18 + i].Cells[8].Value = row[$"di{sValue}avg"].ToString();
                    }

                    for (int i = 0; i < 2; i++)
                    {
                        var sValue = (i + 1).ToString("D2");
                        dgvMeasureDetail.Rows[22 + i].Cells[6].Value = row[$"do{sValue}min"].ToString();
                        dgvMeasureDetail.Rows[22 + i].Cells[7].Value = row[$"do{sValue}max"].ToString();
                        dgvMeasureDetail.Rows[22 + i].Cells[8].Value = row[$"do{sValue}avg"].ToString();
                    }

                   

                }
                string sql = $"select method, calibid, reqmbid1,reqmbid2,reqmbid3,reqmbid4,reqmbid5,reqmbid6,reqmbid7,reqmbid8,reqmbid9,reqmbid10,reqmbid11,reqmbid12," +
                   $"reqmbname1,reqmbname2,reqmbname3,reqmbname4,reqmbname5,reqmbname6,reqmbname7,reqmbname8,reqmbname9,reqmbname10,reqmbname11,reqmbname12," +
                   $"reqsampleid1,reqsampleid2,reqsampleid3,reqsampleid4,reqsampleid5,reqsampleid6,reqsampleid7,reqsampleid8,reqsampleid9,reqsampleid10,reqsampleid11,reqsampleid12," +
                   $"reqsamplename1,reqsamplename2,reqsamplename3,reqsamplename4,reqsamplename5,reqsamplename6,reqsamplename7,reqsamplename8,reqsamplename9,reqsamplename10,reqsamplename11,reqsamplename12" +
                   $" from tbl_recipe, (select @num:= 0) as s where name ='{rcpname}' ";
                List<Dictionary<string, string>> dicReturn2 = new List<Dictionary<string, string>>();
                Dictionary<string, string> row2 = new Dictionary<string, string>();
                dicReturn2 = msdto.SelectAll(sql);

                if (dicReturn2.Count == 0)
                {
                    log.Info("tbl_recipe db의 레시피명 " + rcpname + "(이)가 없습니다.");
                    MessageBox.Show("검색한 기간내 측정 이력 정보 중에서\r\n[" + rcpname + "]의 레시피 정보를 불러오는데 실패했습니다.", "측정이력조회", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                row2 = dicReturn2[0];

                if (row != null)
                {
                    for (int i = 4; i < 16; i++)
                    {

                        dgvMeasureDetail.Rows[i].Cells[2].Value = row2["reqmbname" + (i - 3)].ToString();
                        dgvMeasureDetail.Rows[i].Cells[3].Value = row2["reqmbid" + (i - 3)].ToString();
                        dgvMeasureDetail.Rows[i].Cells[4].Value = row2["reqsamplename" + (i - 3)].ToString();
                        dgvMeasureDetail.Rows[i].Cells[5].Value = row2["reqsampleid" + (i - 3)].ToString();
                    }

                }
                sql = $"select ch1_name,ch2_name,ch3_name,ch4_name,ch5_name,ch6_name,ch7_name,ch8_name,ch9_name,ch10_name,ch11_name,ch12_name from tbl_plc_calibration, (select @num:= 0) as s where id ='{row2["calibid"]}' ";
                Dictionary<string, string> rowcal = msdto.SelectSql2(sql, "ch1_name", "ch2_name", "ch3_name", "ch4_name", "ch5_name", "ch6_name", "ch7_name", "ch8_name", "ch9_name", "ch10_name", "ch11_name", "ch12_name")[0];
                if (rowcal != null)
                {
                    dgvMeasureDetail.Rows[0].Cells[1].Value = "현재온도";
                    dgvMeasureDetail.Rows[1].Cells[1].Value = "현재습도";
                    dgvMeasureDetail.Rows[2].Cells[1].Value = "설정온도";
                    dgvMeasureDetail.Rows[3].Cells[1].Value = "설정습도";
                    dgvMeasureDetail.Rows[4].Cells[1].Value = rowcal["ch1_name"].ToString();
                    dgvMeasureDetail.Rows[5].Cells[1].Value = rowcal["ch2_name"].ToString();
                    dgvMeasureDetail.Rows[6].Cells[1].Value = rowcal["ch3_name"].ToString();
                    dgvMeasureDetail.Rows[7].Cells[1].Value = rowcal["ch4_name"].ToString();
                    dgvMeasureDetail.Rows[8].Cells[1].Value = rowcal["ch5_name"].ToString();
                    dgvMeasureDetail.Rows[9].Cells[1].Value = rowcal["ch6_name"].ToString();
                    dgvMeasureDetail.Rows[10].Cells[1].Value = rowcal["ch7_name"].ToString();
                    dgvMeasureDetail.Rows[11].Cells[1].Value = rowcal["ch8_name"].ToString();
                    dgvMeasureDetail.Rows[12].Cells[1].Value = rowcal["ch9_name"].ToString();
                    dgvMeasureDetail.Rows[13].Cells[1].Value = rowcal["ch10_name"].ToString();
                    dgvMeasureDetail.Rows[14].Cells[1].Value = rowcal["ch11_name"].ToString();
                    dgvMeasureDetail.Rows[15].Cells[1].Value = rowcal["ch12_name"].ToString();
                    dgvMeasureDetail.Rows[16].Cells[1].Value = "AO01";
                    dgvMeasureDetail.Rows[17].Cells[1].Value = "AO02";
                    dgvMeasureDetail.Rows[18].Cells[1].Value = "DI01";
                    dgvMeasureDetail.Rows[19].Cells[1].Value = "DI02";
                    dgvMeasureDetail.Rows[20].Cells[1].Value = "DI03";
                    dgvMeasureDetail.Rows[21].Cells[1].Value = "DI04";
                    dgvMeasureDetail.Rows[22].Cells[1].Value = "DO01";
                    dgvMeasureDetail.Rows[23].Cells[1].Value = "DO02";
                }


                //============ 차트 데이터
                string[] variables = { "현재온도", "현재습도", "설정온도", "설정습도" };

                for (int i = 1; i <= variables.Length; i++)
                {
                    string maxKey = string.Format("md{0}max", i);
                    string minKey = string.Format("md{0}min", i);
                    string avgKey = string.Format("md{0}avg", i);

                    MaxPoints.Add(new DataXY() { PosX = variables[i - 1], PosY = double.Parse(row[maxKey]) });
                    MinPoints.Add(new DataXY() { PosX = variables[i - 1], PosY = double.Parse(row[minKey]) });
                    AvgPoints.Add(new DataXY() { PosX = variables[i - 1], PosY = double.Parse(row[avgKey]) });
                }
                string[] variables2 = { rowcal["ch1_name"].ToString(), rowcal["ch2_name"].ToString(), rowcal["ch3_name"].ToString(),
                                        rowcal["ch4_name"].ToString(), rowcal["ch5_name"].ToString(), rowcal["ch6_name"].ToString(),
                                        rowcal["ch7_name"].ToString(), rowcal["ch8_name"].ToString(), rowcal["ch9_name"].ToString(),
                                        rowcal["ch10_name"].ToString(), rowcal["ch11_name"].ToString(), rowcal["ch12_name"].ToString() };

                for (int i = 1; i <= variables2.Length; i++)
                {
                    string aiKey = string.Format("ai{0:D2}", i);
                    string maxKey = string.Format("{0}max", aiKey);
                    string minKey = string.Format("{0}min", aiKey);
                    string avgKey = string.Format("{0}avg", aiKey);
                    MaxPoints.Add(new DataXY() { PosX = variables2[i - 1], PosY = double.Parse(row[maxKey]) });
                    MinPoints.Add(new DataXY() { PosX = variables2[i - 1], PosY = double.Parse(row[minKey]) });
                    AvgPoints.Add(new DataXY() { PosX = variables2[i - 1], PosY = double.Parse(row[avgKey]) });
                }
                for (int i = 1; i <= 2; i++)
                {
                    string aoKey = string.Format("ao{0:D2}", i);
                    string maxKey = string.Format("{0}max", aoKey);
                    string minKey = string.Format("{0}min", aoKey);
                    string avgKey = string.Format("{0}avg", aoKey);

                    MaxPoints.Add(new DataXY() { PosX = aoKey, PosY = double.Parse(row[maxKey]) });
                    MinPoints.Add(new DataXY() { PosX = aoKey, PosY = double.Parse(row[minKey]) });
                    AvgPoints.Add(new DataXY() { PosX = aoKey, PosY = double.Parse(row[avgKey]) });

                }
                for (int i = 1; i <= 4; i++)
                {
                    string diKey = string.Format("di{0:D2}", i);
                    string maxKey = string.Format("{0}max", diKey);
                    string minKey = string.Format("{0}min", diKey);
                    string avgKey = string.Format("{0}avg", diKey);

                    MaxPoints.Add(new DataXY() { PosX = diKey, PosY = double.Parse(row[maxKey]) });
                    MinPoints.Add(new DataXY() { PosX = diKey, PosY = double.Parse(row[minKey]) });
                    AvgPoints.Add(new DataXY() { PosX = diKey, PosY = double.Parse(row[avgKey]) });
                }
                for (int i = 1; i <= 2; i++)
                {
                    string doKey = string.Format("do{0:D2}", i);
                    string maxKey = string.Format("{0}max", doKey);
                    string minKey = string.Format("{0}min", doKey);
                    string avgKey = string.Format("{0}avg", doKey);

                    MaxPoints.Add(new DataXY() { PosX = doKey, PosY = double.Parse(row[maxKey]) });
                    MinPoints.Add(new DataXY() { PosX = doKey, PosY = double.Parse(row[minKey]) });
                    AvgPoints.Add(new DataXY() { PosX = doKey, PosY = double.Parse(row[avgKey]) });

                }

                fcMeasureData.BindingX = "PosX";
                fcMeasureData.DataSource = MinPoints;
                series1.DataSource = MaxPoints;
                series2.DataSource = MinPoints;
                series3.DataSource = AvgPoints;
            }

            catch
            {
                MessageBox.Show("검색한 기간내 측정 이력 정보를 불러오는데 실패했습니다.", "측정이력조회", MessageBoxButtons.OK, MessageBoxIcon.Information);
                log.Error(Awlog.ShowMeasureDetailError);
                return;
            }
        }



        //fcMeasureData.AxisX.Min =  1;
        //fcMeasureData.AxisX.MajorUnit = 1;
        //fcMeasureData.AxisX.MinorUnit = 1;
        //fcMeasureData.AxisX.LabelAngle = 60;
        private void ChamberAddSeries()
        {
            fcMeasureData.Series.Add(series1);
            this.fcMeasureData.Series[0].Style.StrokeColor = Color.Red;
            this.fcMeasureData.Series[0].Style.Fill = Brushes.Red;
            fcMeasureData.Series.Add(series2);
            this.fcMeasureData.Series[1].Style.StrokeColor = Color.Blue;
            this.fcMeasureData.Series[1].Style.Fill = Brushes.Blue;
            fcMeasureData.Series.Add(series3);
            this.fcMeasureData.Series[2].Style.StrokeColor = Color.Green;
            this.fcMeasureData.Series[2].Style.Fill = Brushes.Green;

        }
        private void ChamberClearSeries()
        {
            series1.DataSource = null;
            series2.DataSource = null;
            series3.DataSource = null;

            MaxPoints.Clear();
            MinPoints.Clear();
            AvgPoints.Clear();

            fcMeasureData.Series.Remove(series1);
            fcMeasureData.Series.Remove(series2);
            fcMeasureData.Series.Remove(series3);
        }

        public class DataXY
        {
            public string PosX { get; set; }
            public Double PosY { get; set; }
        }
        private void BtnSendCSV_Click(object sender, EventArgs e)
        {
            if (fgMeasureList.DataSource == null)
            {
                MessageBox.Show("데이터가 없습니다", "목록csv내보내기", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                log.Info(Awlog.MeasureListExportCSVEventLog);
                string strBtnName = "CSV 내보내기";

                if (MessageBox.Show(strBtnName + "하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    //파일 저장 위치 선택.
                    System.Windows.Forms.SaveFileDialog saveDlg = new System.Windows.Forms.SaveFileDialog()
                    {
                        Title = "CSV 내보내기",
                        RestoreDirectory = true,
                        FileName = DateTime.Now.ToString("yyyyMMdHHmmssfff") + "_mdata",
                        Filter = "csv (*.csv)|*.csv|txt (*txt)|*.txt|All files (*.*)|*.*",
                    };

                    if (saveDlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)

                    {
                        return;
                    }

                    try
                    {
                        //파일 저장을 위해 스트림 생성.
                        FileStream fs = new FileStream(saveDlg.FileName, FileMode.Create, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

                        //컬럼 이름들을 ","로 나누고 저장.
                        string line = string.Join(",", m_dtResultData.Columns.Cast<object>());
                        sw.WriteLine(line);

                        //row들을 ","로 나누고 저장.
                        foreach (DataRow item in m_dtResultData.Rows)
                        {
                            line = string.Join(",", item.ItemArray.Cast<object>());
                            sw.WriteLine(line);
                        }

                        sw.Close();
                        fs.Close();
                        MessageBox.Show("저장이 완료되었습니다", "측정이력조회", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                        log.Error(Awlog.MeasureListExportCSVError);
                    }
                    finally { }
                }
            }
        }

        private void CbxPeriod_TextChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            string strSerchOpt = cbxPeriod.SelectedItem.ToString();

            switch (strSerchOpt)
            {
                case "당일":
                    dpstartdate.Value = new DateTime(now.Year, now.Month, now.Day);
                    dpenddate.Value = new DateTime(now.Year, now.Month, now.Day);
                    break;
                case "1일":
                    DateTime dt1Dm = now.AddDays(-1);
                    dpstartdate.Value = new DateTime(dt1Dm.Year, dt1Dm.Month, dt1Dm.Day);
                    dpenddate.Value = new DateTime(now.Year, now.Month, now.Day);
                    break;
                case "7일":
                    DateTime dt7Dm = now.AddDays(-7);
                    dpstartdate.Value = new DateTime(dt7Dm.Year, dt7Dm.Month, dt7Dm.Day);
                    dpenddate.Value = new DateTime(now.Year, now.Month, now.Day);
                    break;
                case "30일":
                    DateTime dt30Dm = now.AddDays(-30);
                    dpstartdate.Value = new DateTime(dt30Dm.Year, dt30Dm.Month, dt30Dm.Day);
                    dpenddate.Value = new DateTime(now.Year, now.Month, now.Day);
                    break;
            }

            DailyMeasureList();
        }
    }
}

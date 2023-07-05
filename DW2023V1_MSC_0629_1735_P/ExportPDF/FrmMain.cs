using C1.Win.Chart;
using DBMS_V1;
using DwLib.Data.Generic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ExportPDF
{
    public partial class FrmMain : Form
    {
        // 디자인 영역====================================================================================================================
        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fgSampleInfo = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fgTestResult = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnCSV = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fgRcpInfo = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.fcMeasureData = new C1.Win.Chart.FlexChart();
            this.fgMeasureInfoList = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgSampleInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgTestResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgRcpInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fcMeasureData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgMeasureInfoList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(51, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1950, 1098);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.fgSampleInfo);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.fgTestResult);
            this.panel2.Controls.Add(this.btnCSV);
            this.panel2.Controls.Add(this.btnPDF);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.fgRcpInfo);
            this.panel2.Controls.Add(this.fcMeasureData);
            this.panel2.Controls.Add(this.fgMeasureInfoList);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(6, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1610, 957);
            this.panel2.TabIndex = 0;
            // 
            // fgSampleInfo
            // 
            this.fgSampleInfo.AllowEditing = false;
            this.fgSampleInfo.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fgSampleInfo.BackColor = System.Drawing.Color.White;
            this.fgSampleInfo.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgSampleInfo.ColumnInfo = resources.GetString("fgSampleInfo.ColumnInfo");
            this.fgSampleInfo.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.fgSampleInfo.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.fgSampleInfo.ColumnPickerInfo.ShowToolButton = false;
            this.fgSampleInfo.Location = new System.Drawing.Point(936, 140);
            this.fgSampleInfo.Name = "fgSampleInfo";
            this.fgSampleInfo.Rows.Count = 13;
            this.fgSampleInfo.Rows.DefaultSize = 30;
            this.fgSampleInfo.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgSampleInfo.Size = new System.Drawing.Size(652, 402);
            this.fgSampleInfo.StyleInfo = resources.GetString("fgSampleInfo.StyleInfo");
            this.fgSampleInfo.TabIndex = 47;
            this.fgSampleInfo.UseCompatibleTextRendering = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(78)))), ((int)(((byte)(77)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1458, 895);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(130, 33);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 36);
            this.label1.TabIndex = 35;
            this.label1.Text = "테스트 결과 레포트";
            // 
            // fgTestResult
            // 
            this.fgTestResult.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.fgTestResult.AllowEditing = false;
            this.fgTestResult.AllowNodeCellCheck = false;
            this.fgTestResult.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fgTestResult.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgTestResult.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgTestResult.ColumnInfo = resources.GetString("fgTestResult.ColumnInfo");
            this.fgTestResult.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.fgTestResult.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.fgTestResult.ColumnPickerInfo.ShowToolButton = false;
            this.fgTestResult.Location = new System.Drawing.Point(936, 548);
            this.fgTestResult.Name = "fgTestResult";
            this.fgTestResult.Rows.Count = 25;
            this.fgTestResult.Rows.DefaultSize = 30;
            this.fgTestResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fgTestResult.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgTestResult.Size = new System.Drawing.Size(652, 309);
            this.fgTestResult.StyleInfo = resources.GetString("fgTestResult.StyleInfo");
            this.fgTestResult.TabIndex = 45;
            this.fgTestResult.UseCompatibleTextRendering = false;
            // 
            // btnCSV
            // 
            this.btnCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(154)))), ((int)(((byte)(114)))));
            this.btnCSV.FlatAppearance.BorderSize = 0;
            this.btnCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCSV.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCSV.ForeColor = System.Drawing.Color.White;
            this.btnCSV.Location = new System.Drawing.Point(785, 14);
            this.btnCSV.Name = "btnCSV";
            this.btnCSV.Size = new System.Drawing.Size(400, 55);
            this.btnCSV.TabIndex = 36;
            this.btnCSV.Text = "CSV파일 내보내기";
            this.btnCSV.UseVisualStyleBackColor = false;
            this.btnCSV.Click += new System.EventHandler(this.BtnCSV_Click_1);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(195)))));
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Location = new System.Drawing.Point(1188, 14);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(400, 55);
            this.btnPDF.TabIndex = 37;
            this.btnPDF.Text = "PDF파일 내보내기";
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.BtnPDF_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(20, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "시험결과";
            // 
            // fgRcpInfo
            // 
            this.fgRcpInfo.AllowEditing = false;
            this.fgRcpInfo.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fgRcpInfo.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgRcpInfo.BackColor = System.Drawing.Color.White;
            this.fgRcpInfo.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgRcpInfo.ColumnInfo = resources.GetString("fgRcpInfo.ColumnInfo");
            this.fgRcpInfo.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.fgRcpInfo.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.fgRcpInfo.ColumnPickerInfo.ShowToolButton = false;
            this.fgRcpInfo.Location = new System.Drawing.Point(478, 140);
            this.fgRcpInfo.Name = "fgRcpInfo";
            this.fgRcpInfo.Rows.Count = 4;
            this.fgRcpInfo.Rows.DefaultSize = 30;
            this.fgRcpInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fgRcpInfo.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgRcpInfo.Size = new System.Drawing.Size(452, 121);
            this.fgRcpInfo.StyleInfo = resources.GetString("fgRcpInfo.StyleInfo");
            this.fgRcpInfo.TabIndex = 41;
            this.fgRcpInfo.UseCompatibleTextRendering = false;
            this.fgRcpInfo.Click += new System.EventHandler(this.FgRcpInfo_Click);
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
            this.fcMeasureData.AxisX.Formatter = null;
            this.fcMeasureData.AxisX.GroupProvider = null;
            this.fcMeasureData.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.fcMeasureData.AxisX.GroupStyle.VerticalText = false;
            this.fcMeasureData.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.fcMeasureData.AxisX.GroupVisibilityLevel = 0;
            this.fcMeasureData.AxisX.MajorGridStyle.VerticalText = false;
            this.fcMeasureData.AxisX.MinorGridStyle.VerticalText = false;
            this.fcMeasureData.AxisX.PlotAreaName = null;
            this.fcMeasureData.AxisX.Position = C1.Chart.Position.Bottom;
            this.fcMeasureData.AxisX.Style.VerticalText = false;
            this.fcMeasureData.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.fcMeasureData.AxisX.TitleStyle.VerticalText = false;
            this.fcMeasureData.AxisY.AxisLine = false;
            this.fcMeasureData.AxisY.Chart = this.fcMeasureData;
            this.fcMeasureData.AxisY.DataSource = null;
            this.fcMeasureData.AxisY.Formatter = null;
            this.fcMeasureData.AxisY.GroupProvider = null;
            this.fcMeasureData.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.fcMeasureData.AxisY.GroupStyle.VerticalText = false;
            this.fcMeasureData.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.fcMeasureData.AxisY.GroupVisibilityLevel = 0;
            this.fcMeasureData.AxisY.MajorGrid = true;
            this.fcMeasureData.AxisY.MajorGridStyle.VerticalText = false;
            this.fcMeasureData.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.fcMeasureData.AxisY.MinorGridStyle.VerticalText = false;
            this.fcMeasureData.AxisY.PlotAreaName = null;
            this.fcMeasureData.AxisY.Position = C1.Chart.Position.Left;
            this.fcMeasureData.AxisY.Style.VerticalText = false;
            this.fcMeasureData.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.fcMeasureData.AxisY.TitleStyle.VerticalText = false;
            this.fcMeasureData.Binding = "yPos";
            this.fcMeasureData.BindingMode = C1.Win.Chart.BindingMode.Direct;
            this.fcMeasureData.BindingX = "strxPos";
            this.fcMeasureData.ChartType = C1.Chart.ChartType.LineSymbols;
            this.fcMeasureData.DataLabel.Angle = 0;
            this.fcMeasureData.DataLabel.Border = false;
            this.fcMeasureData.DataLabel.BorderStyle.VerticalText = false;
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
            this.fcMeasureData.DataLabel.Style.VerticalText = false;
            this.fcMeasureData.Legend.ItemMaxWidth = 0;
            this.fcMeasureData.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.fcMeasureData.Legend.Position = C1.Chart.Position.Right;
            this.fcMeasureData.Legend.Reversed = false;
            this.fcMeasureData.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.fcMeasureData.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.fcMeasureData.Legend.Title = null;
            this.fcMeasureData.Location = new System.Drawing.Point(41, 416);
            this.fcMeasureData.Margin = new System.Windows.Forms.Padding(10);
            this.fcMeasureData.Name = "fcMeasureData";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.fcMeasureData.Options.ClusterSize = elementSize1;
            this.fcMeasureData.PlotMargin = new System.Windows.Forms.Padding(0);
            this.fcMeasureData.PlotStyle.VerticalText = false;
            this.fcMeasureData.SelectedSeries = null;
            this.fcMeasureData.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.fcMeasureData.SelectionStyle.VerticalText = false;
            this.fcMeasureData.Size = new System.Drawing.Size(843, 441);
            this.fcMeasureData.TabIndex = 44;
            this.fcMeasureData.Text = "flexChart1";
            // 
            // 
            // 
            this.fcMeasureData.ToolTip.Content = "";
            // 
            // fgMeasureInfoList
            // 
            this.fgMeasureInfoList.AllowEditing = false;
            this.fgMeasureInfoList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fgMeasureInfoList.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgMeasureInfoList.BackColor = System.Drawing.Color.White;
            this.fgMeasureInfoList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgMeasureInfoList.ColumnInfo = resources.GetString("fgMeasureInfoList.ColumnInfo");
            this.fgMeasureInfoList.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.fgMeasureInfoList.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.fgMeasureInfoList.ColumnPickerInfo.ShowToolButton = false;
            this.fgMeasureInfoList.Location = new System.Drawing.Point(20, 140);
            this.fgMeasureInfoList.Name = "fgMeasureInfoList";
            this.fgMeasureInfoList.Rows.Count = 4;
            this.fgMeasureInfoList.Rows.DefaultSize = 30;
            this.fgMeasureInfoList.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fgMeasureInfoList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgMeasureInfoList.Size = new System.Drawing.Size(452, 121);
            this.fgMeasureInfoList.StyleInfo = resources.GetString("fgMeasureInfoList.StyleInfo");
            this.fgMeasureInfoList.TabIndex = 39;
            this.fgMeasureInfoList.UseCompatibleTextRendering = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(19, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 30);
            this.label4.TabIndex = 38;
            this.label4.Text = "측정정보";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1622, 971);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgSampleInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgTestResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgRcpInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fcMeasureData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgMeasureInfoList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1FlexGrid.C1FlexGrid fgTestResult;
        private System.Windows.Forms.Button btnCSV;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1FlexGrid.C1FlexGrid fgRcpInfo;
        private C1.Win.Chart.FlexChart fcMeasureData;
        private C1.Win.C1FlexGrid.C1FlexGrid fgMeasureInfoList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private C1.Win.C1FlexGrid.C1FlexGrid fgSampleInfo;
        //================================================================================================================================



        public string m_msid;
        public string m_mbid;
        public string m_reqmbname;
        public string m_rcpname;

        string rcpid = "";
        string calibid;
        private readonly Series series1 = new Series { Name = "누적 최대", Binding = "PosY" };
        private readonly Series series2 = new Series { Name = "누적 최소", Binding = "PosY" };
        private readonly Series series3 = new Series { Name = "누적 평균", Binding = "PosY" };

        private readonly ObservableCollection<DataXY> cMaxPoints = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> cMinPoints = new ObservableCollection<DataXY>() { };
        private readonly ObservableCollection<DataXY> cAvgPoints = new ObservableCollection<DataXY>() { };
        Dictionary<string, string> rowcal = new Dictionary<string, string>();
        private readonly DataTable cMeasureInfo = new DataTable();
        private readonly DataTable cRcpInfo = new DataTable();
        private readonly DataTable cSampleInfo = new DataTable();
        private readonly DataTable cSampleInfo_csv = new DataTable();
        private readonly DataTable cTestResult = new DataTable();
        private readonly MySqlDTO cMysqlDto = new MySqlDTO();

        public FrmMain(string msid, string ms_mbid, string reqmbname, string rcpname)
        {
            InitializeComponent();

            this.m_msid = msid;
            this.m_mbid = ms_mbid;
            this.m_reqmbname = reqmbname;
            this.m_rcpname = rcpname;

            InitializeGrid();



            this.Text = CommonClass.program_title.ToString();
            ReqInfoList();

            MeasureInfoList();
            TestResultList();

 

        }
        private void InitializeGrid()
        {

            string sql = $"select id, calibid from tbl_recipe where name = \"{m_rcpname}\"";
            Dictionary<string, string> row1 = cMysqlDto.SelectSql2(sql, "id", "calibid")[0];
            rcpid = row1["id"];
            calibid = row1["calibid"];
            string dbsql = $"select ch1_name,ch2_name,ch3_name,ch4_name,ch5_name,ch6_name,ch7_name,ch8_name,ch9_name,ch10_name,ch11_name,ch12_name from tbl_plc_calibration, (select @num:= 0) as s where id ='{calibid}' ";
            rowcal = cMysqlDto.SelectSql2(dbsql, "ch1_name", "ch2_name", "ch3_name", "ch4_name", "ch5_name", "ch6_name", "ch7_name", "ch8_name", "ch9_name", "ch10_name", "ch11_name", "ch12_name")[0];
            for (int i = 1; i < 4; i++)
            {
                fgMeasureInfoList[i, 1] = i;
            }
            fgMeasureInfoList[1, 2] = "측정ID";
            fgMeasureInfoList[2, 2] = "측정자명";
            fgMeasureInfoList[3, 2] = "측정자ID";

            for (int i = 1; i < 4; i++)
            {
                fgRcpInfo[i, 1] = i;
            }
            fgRcpInfo[1, 2] = "레시피명";
            fgRcpInfo[2, 2] = "시험방법";
            fgRcpInfo[3, 2] = "시험일자";

            for (int i = 1; i < 13; i++)
            {
                fgSampleInfo[i, 1] = i;
            }


            for (int i = 1; i < 25; i++)
            {
                fgTestResult[i, 1] = i;
            }

            string[] channel = new string[25] { "현재온도", "현재습도", "설정온도", "설정습도", rowcal["ch1_name"], rowcal["ch2_name"], rowcal["ch3_name"], rowcal["ch4_name"], rowcal["ch5_name"], rowcal["ch6_name"], rowcal["ch7_name"], rowcal["ch8_name"], rowcal["ch9_name"], rowcal["ch10_name"], rowcal["ch11_name"], rowcal["ch12_name"], "AO01", "AO02", "DI01", "DI02", "DI03", "DI04", "DO01", "DO02", "" };
            for (int i = 1; i < 25; i++)
            {
                fgTestResult[i, 2] = channel[i - 1];
            }
        }
        private void ReqInfoList()
        {


            string sql = $"select name, method, mtime, roidiameter, patternid, settemp, sethumi, calibid," +
                      $"reqmbname1,reqmbname2,reqmbname3,reqmbname4,reqmbname5,reqmbname6,reqmbname7,reqmbname8,reqmbname9,reqmbname10,reqmbname11,reqmbname12," +
                      $"reqsampleid1,reqsampleid2,reqsampleid3,reqsampleid4,reqsampleid5,reqsampleid6,reqsampleid7,reqsampleid8,reqsampleid9,reqsampleid10,reqsampleid11,reqsampleid12," +
                      $"reqsamplename1,reqsamplename2,reqsamplename3,reqsamplename4,reqsamplename5,reqsamplename6,reqsamplename7,reqsamplename8,reqsamplename9,reqsamplename10,reqsamplename11,reqsamplename12" +
                      $" from tbl_recipe where id = \"{rcpid}\"";

            Dictionary<string, string> row = cMysqlDto.SelectSql2(sql, "name", "method", "mtime", "roidiameter", "patternid", "settemp", "sethumi", "calibid",
               "reqmbname1", "reqmbname2", "reqmbname3", "reqmbname4", "reqmbname5", "reqmbname6", "reqmbname7", "reqmbname8", "reqmbname9", "reqmbname10", "reqmbname11", "reqmbname12",
               "reqsampleid1", "reqsampleid2", "reqsampleid3", "reqsampleid4", "reqsampleid5", "reqsampleid6", "reqsampleid7", "reqsampleid8", "reqsampleid9", "reqsampleid10", "reqsampleid11", "reqsampleid12",
               "reqsamplename1", "reqsamplename2", "reqsamplename3", "reqsamplename4", "reqsamplename5", "reqsamplename6", "reqsamplename7", "reqsamplename8", "reqsamplename9", "reqsamplename10", "reqsamplename11", "reqsamplename12")[0];

            for (int i = 1; i <= 12; i++)
            {
                fgSampleInfo[i, 2] = row["reqmbname" + i].ToString();
                fgSampleInfo[i, 3] = row["reqsamplename" + i].ToString();
                fgSampleInfo[i, 4] = row["reqsampleid" + i].ToString();
                fgSampleInfo[i, 5] = "default";
                fgSampleInfo[i, 6] = "default";
            }

            //if (CommonClass.ShowReqNotSet)
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        fgSampleInfo[i, 2] = row["reqmbname" + i].ToString();
            //        fgSampleInfo[i, 3] = row["reqsamplename" + i].ToString();
            //        fgSampleInfo[i, 4] = row["reqsampleid" + i].ToString();
            //        fgSampleInfo[i, 5] = "default";
            //        fgSampleInfo[i, 6] = "default";
            //    }
            //}
            //else
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        fgSampleInfo[i, 2] = row["reqmbname" + i].Equals("미지정") ? "" : row["reqmbname" + i].ToString();
            //        fgSampleInfo[i, 3] = row["reqsamplename" + i].Equals("미지정") ? "" : row["reqsamplename" + i].ToString();
            //        fgSampleInfo[i, 4] = row["reqsampleid" + i].Equals("not_set") ? "" : row["reqsampleid" + i].ToString();
            //        fgSampleInfo[i, 5] = row["reqmbname" + i].Equals("미지정") ? "" : "default";
            //        fgSampleInfo[i, 6] = row["reqmbname" + i].Equals("미지정") ? "" : "default";

            //    }
            //}



            //pdf 내보내기용
            string reqmbname;
            string reqsamplename;
            string reqsampleid;
            string form;
            string cat;
            List<string> ch_num = new List<string> { };

            cSampleInfo.Columns.Add("NO", typeof(string));
            cSampleInfo.Columns.Add("의뢰자명", typeof(string));
            cSampleInfo.Columns.Add("의뢰자샘플명", typeof(string));
            cSampleInfo.Columns.Add("의뢰자샘플ID", typeof(string));
            cSampleInfo.Columns.Add("형식", typeof(string));
            cSampleInfo.Columns.Add("구분", typeof(string));

            cSampleInfo_csv.Columns.Add("NO", typeof(string));
            cSampleInfo_csv.Columns.Add("의뢰자명", typeof(string));
            cSampleInfo_csv.Columns.Add("의뢰자샘플명", typeof(string));
            cSampleInfo_csv.Columns.Add("의뢰자샘플ID", typeof(string));
            cSampleInfo_csv.Columns.Add("형식", typeof(string));
            cSampleInfo_csv.Columns.Add("구분", typeof(string));
            for (int i = 1; i <= 12; i++)
            {
                cSampleInfo_csv.Rows.Add(new object[] { i, row["reqmbname" + i], row["reqsamplename" + i], row["reqsampleid" + i], "default", "default" });
            }

            for (int i = 1; i <= 12; i++)
            {
                reqmbname = row["reqmbname" + i].Equals("미지정") ? "" : row["reqmbname" + i].ToString();
                reqsamplename = row["reqsamplename" + i].Equals("미지정") ? "" : row["reqsamplename" + i].ToString();
                reqsampleid = row["reqsampleid" + i].Equals("not_set") ? "" : row["reqsampleid" + i].ToString();
                form = row["reqmbname" + i].Equals("미지정") ? "" : "default";
                cat = row["reqmbname" + i].Equals("미지정") ? "" : "default";
                cSampleInfo.Rows.Add(new object[] { i, reqmbname, reqsamplename, reqsampleid, form, cat });
                if (!row["reqmbname" + i].Equals("미지정"))
                {
                    ch_num.Add(i.ToString("00"));
                }
                CreatePDF.ch_num = ch_num;
            }

            //if (CommonClass.ShowReqNotSet)
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        SampleInfo_csv.Rows.Add(new object[] { i, row["reqmbname" + i], row["reqsamplename" + i], row["reqsampleid" + i], "default", "default" });
            //    }
            //}
            //else
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        reqmbname = row["reqmbname" + i].Equals("미지정") ? "" : row["reqmbname" + i].ToString();
            //        reqsamplename = row["reqsamplename" + i].Equals("미지정") ? "" : row["reqsamplename" + i].ToString();
            //        reqsampleid = row["reqsampleid" + i].Equals("not_set") ? "" : row["reqsampleid" + i].ToString();
            //        form = row["reqmbname" + i].Equals("미지정") ? "" : "default";
            //        cat = row["reqmbname" + i].Equals("미지정") ? "" : "default";
            //        SampleInfo.Rows.Add(new object[] { i, reqmbname, reqsamplename, reqsampleid, form, cat });
            //    }
            //}
        }

        private void MeasureInfoList()
        {
            try
            {

                string sql = $"select (@num:=@num+1) as no, (select teamname from tbl_reqmember where name='{m_reqmbname}')as teamname,(select id from tbl_reqmember where name='{m_reqmbname}')as reqmbid, method, DATE_FORMAT(mstotalstarttime, '%Y-%m-%d') AS mstotalstarttime, rcpname,(select name from tbl_member where id='{m_mbid}')as mbname from tbl_measure_result_statistics, (select @num:=0) as s where msid = '{m_msid}';";// order by name asc;";
                List<Dictionary<string, string>> dicReturn = new List<Dictionary<string, string>>();
                dicReturn = cMysqlDto.SelectSql2(sql, "method", "mstotalstarttime", "teamname", "reqmbid", "rcpname", "mbname");
                Dictionary<string, string> row = new Dictionary<string, string>();
                if (dicReturn.Count == 0)
                {
                    return;

                }
                row = dicReturn[0];
                if (row != null)
                {
                    fgMeasureInfoList[1, 3] = m_msid;
                    fgMeasureInfoList[2, 3] = row["mbname"];
                    fgMeasureInfoList[3, 3] = m_mbid;

                    fgRcpInfo[1, 3] = row["rcpname"];
                    fgRcpInfo[2, 3] = row["method"];
                    fgRcpInfo[3, 3] = row["mstotalstarttime"];
                }


                //PDF내보내기용
                cMeasureInfo.Columns.Add("NO", typeof(string));
                cMeasureInfo.Columns.Add("구분", typeof(string));
                cMeasureInfo.Columns.Add("값", typeof(string));
                cMeasureInfo.Rows.Add(new object[] { "1", "측정ID", m_msid });
                cMeasureInfo.Rows.Add(new object[] { "2", "측정자명", row["mbname"] });
                cMeasureInfo.Rows.Add(new object[] { "3", "측정자ID", m_mbid });

                cRcpInfo.Columns.Add("NO", typeof(string));
                cRcpInfo.Columns.Add("구분", typeof(string));
                cRcpInfo.Columns.Add("값", typeof(string));
                cRcpInfo.Rows.Add(new object[] { "1", "레시피명", row["rcpname"] });
                cRcpInfo.Rows.Add(new object[] { "2", "시험방법", row["method"] });
                cRcpInfo.Rows.Add(new object[] { "3", "시험일자", row["mstotalstarttime"] });



            }
            catch (Exception)
            {

            }
            finally
            {
                cMysqlDto.Close();
            }
        }

        private void TestResultList()
        {
            ChamberAddSeries();
            try
            {
                string dbsql = $"select (@num:=@num+1) as no, msid, DATE_FORMAT(mstotalstarttime, '%Y-%m-%d %H:%i:%s') AS mstotalstarttime, DATE_FORMAT(mstotalendtime, '%Y-%m-%d %H:%i:%s') AS mstotalendtime , rcpname,reqmbname, method, " +
                  $" Format(md1max,1) as md1max,Format(md1min,1)as md1min,md1avg, Format(md2max,1) as md2max ,Format(md2min,1) as md2min ,md2avg, Format(md3max,1) as md3max ,Format(md3min,1) as md3min ,md3avg, Format(md4max,1) as md4max, Format(md4min,1) as md4min,md4avg," +
                  $" Format(ai01max,1) as ai01max, Format(ai01min,1) as ai01min,ai01avg,  Format(ai02max,1) as ai02max,Format(ai02min,1) as ai02min,ai02avg, Format(ai03max,1) as ai03max,Format(ai03min,1) as ai03min,ai03avg, Format(ai04max,1) as ai04max,Format(ai04min,1) as ai04min,ai04avg, Format(ai05max,1) as ai05max,Format(ai05min,1) as ai05min,ai05avg, Format(ai06max,1) as ai06max,Format(ai06min,1) as ai06min,ai06avg, Format(ai07max,1) as ai07max,Format(ai07min,1) as ai07min,ai07avg, " +
                  $" Format(ai08max,1) as ai08max, Format(ai08min,1) as ai08min,ai08avg,  Format(ai09max,1) as ai09max,Format(ai09min,1) as ai09min,ai09avg, Format(ai10max,1) as ai10max,Format(ai10min,1) as ai10min,ai10avg, Format(ai11max,1) as ai11max,Format(ai11min,1) as ai11min,ai11avg, Format(ai12max,1) as ai12max,Format(ai12min,1) as ai12min, ai12avg," +
                  $" Format(ao01max,1) as ao01max, Format(ao01min,1) as ao01min,ao01avg,  Format(ao02max,1) as ao02max,Format(ao02min,1) as ao02min,ao02avg, Format(di01max,1) as di01max,Format(di01min,1) as di01min,di01avg, Format(di02max,1) as di02max,Format(di02min,1) as di02min,di02avg, Format(di03max,1) as di03max,Format(di03min,1) as di03min,di03avg, Format(di04max,1) as di04max,Format(di04min,1) as di04min,di04avg, Format(do01max,1) as do01max,Format(do01min,1) as do01min,do01avg, Format(do02max,1) as do02max,Format(do02min,1) as do02min,do02avg" +
                  $" from (select @num:=0) as s, tbl_measure_result_statistics as t  WHERE t.msid = '{m_msid}' ";


                List<Dictionary<string, string>> rows = cMysqlDto.SelectSql2(dbsql, "md1avg", "md2avg", "md3avg", "md4avg", "ai01avg", "ai02avg", "ai03avg", "ai04avg", "ai05avg", "ai06avg", "ai07avg", "ai08avg", "ai09avg", "ai10avg", "ai11avg", "ai12avg", "ao01avg", "ao02avg", "di01avg", "di02avg", "di03avg", "di04avg", "do01avg", "do02avg",
                                                                                "md1min", "md2min", "md3min", "md4min", "ai01min", "ai02min", "ai03min", "ai04min", "ai05min", "ai06min", "ai07min", "ai08min", "ai09min", "ai10min", "ai11min", "ai12min", "ao01min", "ao02min", "di01min", "di02min", "di03min", "di04min", "do01min", "do02min",
                                                                                "md1max", "md2max", "md3max", "md4max", "ai01max", "ai02max", "ai03max", "ai04max", "ai05max", "ai06max", "ai07max", "ai08max", "ai09max", "ai10max", "ai11max", "ai12max", "ao01max", "ao02max", "di01max", "di02max", "di03max", "di04max", "do01max", "do02max");


                if (rows.Count > 0)
                {

                    foreach (Dictionary<string, string> row2 in rows)
                    {
                        for (int i = 1; i <= 4; i++)
                        {
                            fgTestResult[i, 3] = row2["md" + i + "min"];
                            fgTestResult[i, 4] = row2["md" + i + "max"];
                            fgTestResult[i, 5] = row2["md" + i + "avg"];
                        }


                        for (int i = 5; i <= 16; i++)
                        {
                            string columnName = "ai" + (i - 4).ToString("D2");
                            string columnNameAvg = columnName + "avg";
                            string columnNameMax = columnName + "max";
                            string columnNameMin = columnName + "min";

                            fgTestResult[i, 3] = row2[columnNameMin];
                            fgTestResult[i, 4] = row2[columnNameMax];
                            fgTestResult[i, 5] = row2[columnNameAvg];
                        }

                        for (int i = 17; i <= 18; i++)
                        {
                            string columnName = "ao" + (i - 16).ToString("D2");
                            string columnNameAvg = columnName + "avg";
                            string columnNameMax = columnName + "max";
                            string columnNameMin = columnName + "min";

                            fgTestResult[i, 3] = row2[columnNameMin];
                            fgTestResult[i, 4] = row2[columnNameMax];
                            fgTestResult[i, 5] = row2[columnNameAvg];
                        }
                        for (int i = 19; i <= 22; i++)
                        {
                            string columnName = "di" + (i - 18).ToString("D2");
                            string columnNameAvg = columnName + "avg";
                            string columnNameMax = columnName + "max";
                            string columnNameMin = columnName + "min";

                            fgTestResult[i, 3] = row2[columnNameMin];
                            fgTestResult[i, 4] = row2[columnNameMax];
                            fgTestResult[i, 5] = row2[columnNameAvg];
                        }

                        for (int i = 23; i <= 24; i++)
                        {
                            string columnName = "do" + (i - 22).ToString("D2");
                            string columnNameAvg = columnName + "avg";
                            string columnNameMax = columnName + "max";
                            string columnNameMin = columnName + "min";

                            fgTestResult[i, 3] = row2[columnNameMin];
                            fgTestResult[i, 4] = row2[columnNameMax];
                            fgTestResult[i, 5] = row2[columnNameAvg];
                        }

                        cMaxPoints.Add(new DataXY() { PosX = "현재온도", PosY = double.Parse(row2["md1max"]) });
                        cMinPoints.Add(new DataXY() { PosX = "현재온도", PosY = double.Parse(row2["md1min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = "현재온도", PosY = double.Parse(row2["md1avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = "현재습도", PosY = double.Parse(row2["md2max"]) });
                        cMinPoints.Add(new DataXY() { PosX = "현재습도", PosY = double.Parse(row2["md2min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = "현재습도", PosY = double.Parse(row2["md2avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = "설정온도", PosY = double.Parse(row2["md3max"]) });
                        cMinPoints.Add(new DataXY() { PosX = "설정온도", PosY = double.Parse(row2["md3min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = "설정온도", PosY = double.Parse(row2["md3avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = "설정습도", PosY = double.Parse(row2["md4max"]) });
                        cMinPoints.Add(new DataXY() { PosX = "설정습도", PosY = double.Parse(row2["md4min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = "설정습도", PosY = double.Parse(row2["md4avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = rowcal["ch1_name"], PosY = double.Parse(row2["ai01max"]) });
                        cMinPoints.Add(new DataXY() { PosX = rowcal["ch1_name"], PosY = double.Parse(row2["ai01min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = rowcal["ch1_name"], PosY = double.Parse(row2["ai01avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = rowcal["ch2_name"], PosY = double.Parse(row2["ai02max"]) });
                        cMinPoints.Add(new DataXY() { PosX = rowcal["ch2_name"], PosY = double.Parse(row2["ai02min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = rowcal["ch2_name"], PosY = double.Parse(row2["ai02avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = rowcal["ch3_name"], PosY = double.Parse(row2["ai03max"]) });
                        cMinPoints.Add(new DataXY() { PosX = rowcal["ch3_name"], PosY = double.Parse(row2["ai03min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = rowcal["ch3_name"], PosY = double.Parse(row2["ai03avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = rowcal["ch4_name"], PosY = double.Parse(row2["ai04max"]) });
                        cMinPoints.Add(new DataXY() { PosX = rowcal["ch4_name"], PosY = double.Parse(row2["ai04min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = rowcal["ch4_name"], PosY = double.Parse(row2["ai04avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = rowcal["ch5_name"], PosY = double.Parse(row2["ai05max"]) });
                        cMinPoints.Add(new DataXY() { PosX = rowcal["ch5_name"], PosY = double.Parse(row2["ai05min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = rowcal["ch5_name"], PosY = double.Parse(row2["ai05avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = rowcal["ch6_name"], PosY = double.Parse(row2["ai06max"]) });
                        cMinPoints.Add(new DataXY() { PosX = rowcal["ch6_name"], PosY = double.Parse(row2["ai06min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = rowcal["ch6_name"], PosY = double.Parse(row2["ai06avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = rowcal["ch7_name"], PosY = double.Parse(row2["ai07max"]) });
                        cMinPoints.Add(new DataXY() { PosX = rowcal["ch7_name"], PosY = double.Parse(row2["ai07min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = rowcal["ch7_name"], PosY = double.Parse(row2["ai07avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = rowcal["ch8_name"], PosY = double.Parse(row2["ai08max"]) });
                        cMinPoints.Add(new DataXY() { PosX = rowcal["ch8_name"], PosY = double.Parse(row2["ai08min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = rowcal["ch8_name"], PosY = double.Parse(row2["ai08avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = rowcal["ch9_name"], PosY = double.Parse(row2["ai09max"]) });
                        cMinPoints.Add(new DataXY() { PosX = rowcal["ch9_name"], PosY = double.Parse(row2["ai09min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = rowcal["ch9_name"], PosY = double.Parse(row2["ai09avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = rowcal["ch10_name"], PosY = double.Parse(row2["ai10max"]) });
                        cMinPoints.Add(new DataXY() { PosX = rowcal["ch10_name"], PosY = double.Parse(row2["ai10min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = rowcal["ch10_name"], PosY = double.Parse(row2["ai10avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = rowcal["ch11_name"], PosY = double.Parse(row2["ai11max"]) });
                        cMinPoints.Add(new DataXY() { PosX = rowcal["ch11_name"], PosY = double.Parse(row2["ai11min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = rowcal["ch11_name"], PosY = double.Parse(row2["ai11avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = rowcal["ch12_name"], PosY = double.Parse(row2["ai12max"]) });
                        cMinPoints.Add(new DataXY() { PosX = rowcal["ch12_name"], PosY = double.Parse(row2["ai12min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = rowcal["ch12_name"], PosY = double.Parse(row2["ai12avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = "AO01", PosY = double.Parse(row2["ao01max"]) });
                        cMinPoints.Add(new DataXY() { PosX = "AO01", PosY = double.Parse(row2["ao01min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = "AO01", PosY = double.Parse(row2["ao01avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = "AO02", PosY = double.Parse(row2["ao02max"]) });
                        cMinPoints.Add(new DataXY() { PosX = "AO02", PosY = double.Parse(row2["ao02min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = "AO02", PosY = double.Parse(row2["ao02avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = "DI01", PosY = double.Parse(row2["di01max"]) });
                        cMinPoints.Add(new DataXY() { PosX = "DI01", PosY = double.Parse(row2["di01min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = "DI01", PosY = double.Parse(row2["di01avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = "DI02", PosY = double.Parse(row2["di02max"]) });
                        cMinPoints.Add(new DataXY() { PosX = "DI02", PosY = double.Parse(row2["di02min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = "DI02", PosY = double.Parse(row2["di02avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = "DI03", PosY = double.Parse(row2["di03max"]) });
                        cMinPoints.Add(new DataXY() { PosX = "DI03", PosY = double.Parse(row2["di03min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = "DI03", PosY = double.Parse(row2["di03avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = "DI04", PosY = double.Parse(row2["di04max"]) });
                        cMinPoints.Add(new DataXY() { PosX = "DI04", PosY = double.Parse(row2["di04min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = "DI04", PosY = double.Parse(row2["di04avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = "DO01", PosY = double.Parse(row2["do01max"]) });
                        cMinPoints.Add(new DataXY() { PosX = "DO01", PosY = double.Parse(row2["do01min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = "DO01", PosY = double.Parse(row2["do01avg"]) });
                        cMaxPoints.Add(new DataXY() { PosX = "DO02", PosY = double.Parse(row2["do02max"]) });
                        cMinPoints.Add(new DataXY() { PosX = "DO02", PosY = double.Parse(row2["do02min"]) });
                        cAvgPoints.Add(new DataXY() { PosX = "DO02", PosY = double.Parse(row2["do02avg"]) });

                        series1.DataSource = cMaxPoints;
                        series2.DataSource = cMinPoints;
                        series3.DataSource = cAvgPoints;
                        fcMeasureData.BindingX = "PosX";
                        fcMeasureData.DataSource = cMaxPoints;
                        fcMeasureData.AxisX.LabelAngle = 60;
                        //PDF내보내기용
                        cTestResult.Columns.Add("NO", typeof(string));
                        cTestResult.Columns.Add("채널", typeof(string));
                        cTestResult.Columns.Add("누적 최소", typeof(string));
                        cTestResult.Columns.Add("누적 최대", typeof(string));
                        cTestResult.Columns.Add("누적 평균", typeof(string));



                        cTestResult.Rows.Add(new object[] { "1", "현재온도", row2["md1min"], row2["md1max"], row2["md1avg"] });
                        cTestResult.Rows.Add(new object[] { "2", "현재습도", row2["md2min"], row2["md2max"], row2["md2avg"] });
                        cTestResult.Rows.Add(new object[] { "3", "설정온도", row2["md3min"], row2["md3max"], row2["md3avg"] });
                        cTestResult.Rows.Add(new object[] { "4", "설정습도", row2["md4min"], row2["md4max"], row2["md4avg"] });
                        cTestResult.Rows.Add(new object[] { "5", rowcal["ch1_name"], row2["ai01min"].Replace(",", ""), row2["ai01max"].Replace(",", ""), row2["ai01avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "6", rowcal["ch2_name"], row2["ai02min"].Replace(",", ""), row2["ai02max"].Replace(",", ""), row2["ai02avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "7", rowcal["ch3_name"], row2["ai03min"].Replace(",", ""), row2["ai03max"].Replace(",", ""), row2["ai03avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "8", rowcal["ch4_name"], row2["ai04min"].Replace(",", ""), row2["ai04max"].Replace(",", ""), row2["ai04avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "9", rowcal["ch5_name"], row2["ai05min"].Replace(",", ""), row2["ai05max"].Replace(",", ""), row2["ai05avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "10", rowcal["ch6_name"], row2["ai06min"].Replace(",", ""), row2["ai06max"].Replace(",", ""), row2["ai06avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "11", rowcal["ch7_name"], row2["ai07min"].Replace(",", ""), row2["ai07max"].Replace(",", ""), row2["ai07avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "12", rowcal["ch8_name"], row2["ai08min"].Replace(",", ""), row2["ai08max"].Replace(",", ""), row2["ai08avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "13", rowcal["ch9_name"], row2["ai09min"].Replace(",", ""), row2["ai09max"].Replace(",", ""), row2["ai09avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "14", rowcal["ch10_name"], row2["ai10min"].Replace(",", ""), row2["ai10max"].Replace(",", ""), row2["ai10avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "15", rowcal["ch11_name"], row2["ai11min"].Replace(",", ""), row2["ai11max"].Replace(",", ""), row2["ai11avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "16", rowcal["ch12_name"], row2["ai12min"].Replace(",", ""), row2["ai12max"].Replace(",", ""), row2["ai12avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "17", "AO01", row2["ao01min"].Replace(",", ""), row2["ao01max"].Replace(",", ""), row2["ao01avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "18", "AO02", row2["ao02min"].Replace(",", ""), row2["ao02max"].Replace(",", ""), row2["ao02avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "19", "DI01", row2["di01min"].Replace(",", ""), row2["di01max"].Replace(",", ""), row2["di01avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "20", "DI02", row2["di02min"].Replace(",", ""), row2["di02max"].Replace(",", ""), row2["di02avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "21", "DI03", row2["di03min"].Replace(",", ""), row2["di03max"].Replace(",", ""), row2["di03avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "22", "DI04", row2["di04min"].Replace(",", ""), row2["di04max"].Replace(",", ""), row2["di04avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "23", "DO01", row2["do01min"].Replace(",", ""), row2["do01max"].Replace(",", ""), row2["do01avg"].Replace(",", "") });
                        cTestResult.Rows.Add(new object[] { "24", "DO02", row2["do02min"].Replace(",", ""), row2["do02max"].Replace(",", ""), row2["do02avg"].Replace(",", "") });
                    }
                }
            }
            catch
            {
                MessageBox.Show("검색한 기간내 측정 이력 정보를 불러오는데 실패했습니다.", "측정이력조회", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }


        public class DataXY
        {
            public object PosX { get; set; }
            public Double PosY { get; set; }
        }

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
        //private void ChamberClearSeries()
        //{
        //    series1.DataSource = null;
        //    series2.DataSource = null;
        //    series3.DataSource = null;

        //    MaxPoints.Clear();
        //    MinPoints.Clear();
        //    AvgPoints.Clear();

        //    fcMeasureData.Series.Remove(series1);
        //    fcMeasureData.Series.Remove(series2);
        //    fcMeasureData.Series.Remove(series3);
        //}

        public static string filename;
        public static string checkcancel = "";
        public static void ThreadProc()
        {
            System.Windows.Forms.SaveFileDialog saveDlg = new System.Windows.Forms.SaveFileDialog()
            {
                Title = "CSV 내보내기",
                RestoreDirectory = true,
                FileName = DateTime.Now.ToString("yyyyMMdHHmmssfff") + "_mdata",
                Filter = "csv (*.csv)|*.csv|txt (*txt)|*.txt|All files (*.*)|*.*",
            };

            if (saveDlg.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)

            {
                checkcancel = "cancel";
                return;
            }

            filename = saveDlg.FileName;


        }
        private void BtnCSV_Click_1(object sender, EventArgs e)
        {
            checkcancel = "ok";
            Thread t = new Thread(ThreadProc);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
            if (checkcancel.Equals("cancel"))
            {
                return;
            }
            else if (checkcancel.Equals("ok"))
            {


                List<string[]> headers = new List<string[]>();

                foreach (DataRow row in cMeasureInfo.Rows)
                {
                    foreach (DataColumn column in cMeasureInfo.Columns)
                    {

                        headers.Add(new string[] { column.ColumnName.ToString(), row[column].ToString() });
                    }
                }
                headers.Add(new string[] { " ", "" });
                headers.Add(new string[] { "[DATA]", "" });
                foreach (DataRow row in cRcpInfo.Rows)
                {
                    foreach (DataColumn column in cRcpInfo.Columns)
                    {

                        headers.Add(new string[] { column.ColumnName.ToString(), row[column].ToString() });
                    }
                }
                foreach (DataRow row in cSampleInfo_csv.Rows)
                {
                    foreach (DataColumn column in cSampleInfo_csv.Columns)
                    {

                        headers.Add(new string[] { column.ColumnName.ToString(), row[column].ToString() });
                    }
                }
                foreach (DataRow row in cTestResult.Rows)
                {
                    foreach (DataColumn column in cTestResult.Columns)
                    {

                        headers.Add(new string[] { column.ColumnName.ToString(), row[column].ToString() });
                    }
                }


                //파일 저장 위치 선택.

                try
                {
                    //파일 저장을 위해 스트림 생성.
                    FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);

                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {

                        //측정 데이터 테이블 추가시
                        string line = string.Join(",", cMeasureInfo.Columns.Cast<object>());
                        sw.WriteLine(" ");
                        sw.WriteLine(line);
                        //row들을 ","로 나누고 저장.
                        foreach (DataRow item in cMeasureInfo.Rows)
                        {
                            line = string.Join(",", item.ItemArray.Cast<object>());
                            sw.WriteLine(line);
                        }

                        string line2 = string.Join(",", cRcpInfo.Columns.Cast<object>());
                        sw.WriteLine(" ");
                        sw.WriteLine(line2);
                        //row들을 ","로 나누고 저장.
                        foreach (DataRow item in cRcpInfo.Rows)
                        {
                            line2 = string.Join(",", item.ItemArray.Cast<object>());
                            sw.WriteLine(line2);
                        }

                        string line3 = string.Join(",", cSampleInfo_csv.Columns.Cast<object>());
                        sw.WriteLine(" ");
                        sw.WriteLine(line3);
                        //row들을 ","로 나누고 저장.
                        foreach (DataRow item in cSampleInfo_csv.Rows)
                        {
                            line3 = string.Join(",", item.ItemArray.Cast<object>());
                            sw.WriteLine(line3);
                        }

                        string line4 = string.Join(",", cTestResult.Columns.Cast<object>());
                        sw.WriteLine(" ");
                        sw.WriteLine(line4);
                        //row들을 ","로 나누고 저장.
                        foreach (DataRow item in cTestResult.Rows)
                        {
                            line4 = string.Join(",", item.ItemArray.Cast<object>());
                            sw.WriteLine(line4);
                        }

                    }

                    fs.Close();
                    MessageBox.Show("저장이 완료되었습니다", "CSV내보내기", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
                finally { }
            }
        }

        private void BtnPDF_Click_1(object sender, EventArgs e)
        {
            SaveChart.msid = m_msid;
            SaveChart.calibid = calibid;
            CreatePDF pdf = new CreatePDF();
            pdf.createPDF_test(cMeasureInfo, cRcpInfo, cSampleInfo, cTestResult);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FgRcpInfo_Click(object sender, EventArgs e)
        {

        }
    }
}

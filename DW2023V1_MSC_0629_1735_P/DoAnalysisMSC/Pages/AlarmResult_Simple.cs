using DBMS_V1;
using EventLog;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoAnalysisMSC.Pages
{
    public partial class AlarmResult_Simple : Form
    {
        // 디자인 영역====================================================================================================================
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmResult_Simple));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEndSec = new C1.Win.C1Input.C1ComboBox();
            this.cbxEndMinute = new C1.Win.C1Input.C1ComboBox();
            this.cbxEndHour = new C1.Win.C1Input.C1ComboBox();
            this.cbxStartSec = new C1.Win.C1Input.C1ComboBox();
            this.cbxStartMinute = new C1.Win.C1Input.C1ComboBox();
            this.cbxStartHour = new C1.Win.C1Input.C1ComboBox();
            this.cbxPeriod = new C1.Win.C1Input.C1ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.dpenddate = new System.Windows.Forms.DateTimePicker();
            this.dpstartdate = new System.Windows.Forms.DateTimePicker();
            this.fgAlarmList = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnSendCSV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEndSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEndMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStartSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStartMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStartHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgAlarmList)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.cbxEndHour);
            this.splitContainer1.Panel2.Controls.Add(this.cbxStartSec);
            this.splitContainer1.Panel2.Controls.Add(this.cbxStartMinute);
            this.splitContainer1.Panel2.Controls.Add(this.cbxStartHour);
            this.splitContainer1.Panel2.Controls.Add(this.cbxPeriod);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel2.Controls.Add(this.dpenddate);
            this.splitContainer1.Panel2.Controls.Add(this.dpstartdate);
            this.splitContainer1.Panel2.Controls.Add(this.fgAlarmList);
            this.splitContainer1.Panel2.Controls.Add(this.btnSendCSV);
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
            this.label1.Text = "알람이력조회";
            // 
            // cbxEndSec
            // 
            this.cbxEndSec.AllowSpinLoop = false;
            this.cbxEndSec.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxEndSec.GapHeight = 0;
            this.cbxEndSec.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxEndSec.Location = new System.Drawing.Point(978, 48);
            this.cbxEndSec.Name = "cbxEndSec";
            this.cbxEndSec.Size = new System.Drawing.Size(70, 32);
            this.cbxEndSec.TabIndex = 43;
            this.cbxEndSec.Tag = null;
            this.cbxEndSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxEndMinute
            // 
            this.cbxEndMinute.AllowSpinLoop = false;
            this.cbxEndMinute.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxEndMinute.GapHeight = 0;
            this.cbxEndMinute.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxEndMinute.Location = new System.Drawing.Point(902, 48);
            this.cbxEndMinute.Name = "cbxEndMinute";
            this.cbxEndMinute.Size = new System.Drawing.Size(70, 32);
            this.cbxEndMinute.TabIndex = 42;
            this.cbxEndMinute.Tag = null;
            this.cbxEndMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxEndHour
            // 
            this.cbxEndHour.AllowSpinLoop = false;
            this.cbxEndHour.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxEndHour.GapHeight = 0;
            this.cbxEndHour.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxEndHour.Location = new System.Drawing.Point(826, 48);
            this.cbxEndHour.Name = "cbxEndHour";
            this.cbxEndHour.Size = new System.Drawing.Size(70, 32);
            this.cbxEndHour.TabIndex = 41;
            this.cbxEndHour.Tag = null;
            this.cbxEndHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxStartSec
            // 
            this.cbxStartSec.AllowSpinLoop = false;
            this.cbxStartSec.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxStartSec.GapHeight = 0;
            this.cbxStartSec.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxStartSec.Location = new System.Drawing.Point(578, 48);
            this.cbxStartSec.Name = "cbxStartSec";
            this.cbxStartSec.Size = new System.Drawing.Size(70, 32);
            this.cbxStartSec.TabIndex = 40;
            this.cbxStartSec.Tag = null;
            this.cbxStartSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxStartMinute
            // 
            this.cbxStartMinute.AllowSpinLoop = false;
            this.cbxStartMinute.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxStartMinute.GapHeight = 0;
            this.cbxStartMinute.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxStartMinute.Location = new System.Drawing.Point(502, 48);
            this.cbxStartMinute.Name = "cbxStartMinute";
            this.cbxStartMinute.Size = new System.Drawing.Size(70, 32);
            this.cbxStartMinute.TabIndex = 39;
            this.cbxStartMinute.Tag = null;
            this.cbxStartMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxStartHour
            // 
            this.cbxStartHour.AllowSpinLoop = false;
            this.cbxStartHour.Font = new System.Drawing.Font("나눔고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbxStartHour.GapHeight = 0;
            this.cbxStartHour.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cbxStartHour.Location = new System.Drawing.Point(426, 48);
            this.cbxStartHour.Name = "cbxStartHour";
            this.cbxStartHour.Size = new System.Drawing.Size(70, 32);
            this.cbxStartHour.TabIndex = 38;
            this.cbxStartHour.Tag = null;
            this.cbxStartHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.cbxPeriod.Location = new System.Drawing.Point(150, 48);
            this.cbxPeriod.Name = "cbxPeriod";
            this.cbxPeriod.Size = new System.Drawing.Size(132, 32);
            this.cbxPeriod.TabIndex = 31;
            this.cbxPeriod.Tag = null;
            this.cbxPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbxPeriod.SelectedItemChanged += new System.EventHandler(this.CbxPeriod_SelectedItemChanged);
            this.cbxPeriod.TextChanged += new System.EventHandler(this.CbxPeriod_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(656, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "~";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(124)))), ((int)(((byte)(245)))));
            this.btnSearch.Image = global::DoAnalysisMSC.Properties.Resources.find;
            this.btnSearch.Location = new System.Drawing.Point(1064, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 29;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // dpenddate
            // 
            this.dpenddate.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpenddate.Location = new System.Drawing.Point(692, 48);
            this.dpenddate.MaximumSize = new System.Drawing.Size(130, 32);
            this.dpenddate.MinimumSize = new System.Drawing.Size(130, 32);
            this.dpenddate.Name = "dpenddate";
            this.dpenddate.Size = new System.Drawing.Size(130, 32);
            this.dpenddate.TabIndex = 28;
            // 
            // dpstartdate
            // 
            this.dpstartdate.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpstartdate.Location = new System.Drawing.Point(290, 48);
            this.dpstartdate.MaximumSize = new System.Drawing.Size(130, 32);
            this.dpstartdate.MinimumSize = new System.Drawing.Size(130, 32);
            this.dpstartdate.Name = "dpstartdate";
            this.dpstartdate.Size = new System.Drawing.Size(130, 32);
            this.dpstartdate.TabIndex = 27;
            // 
            // fgAlarmList
            // 
            this.fgAlarmList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.fgAlarmList.AllowEditing = false;
            this.fgAlarmList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fgAlarmList.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgAlarmList.AutoGenerateColumns = false;
            this.fgAlarmList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgAlarmList.ColumnInfo = resources.GetString("fgAlarmList.ColumnInfo");
            this.fgAlarmList.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.fgAlarmList.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.fgAlarmList.ColumnPickerInfo.ShowToolButton = false;
            this.fgAlarmList.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fgAlarmList.Location = new System.Drawing.Point(6, 100);
            this.fgAlarmList.Name = "fgAlarmList";
            this.fgAlarmList.Rows.DefaultSize = 40;
            this.fgAlarmList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgAlarmList.Size = new System.Drawing.Size(1631, 784);
            this.fgAlarmList.StyleInfo = resources.GetString("fgAlarmList.StyleInfo");
            this.fgAlarmList.TabIndex = 15;
            this.fgAlarmList.UseCompatibleTextRendering = false;
            // 
            // btnSendCSV
            // 
            this.btnSendCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnSendCSV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(89)))));
            this.btnSendCSV.FlatAppearance.BorderSize = 0;
            this.btnSendCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCSV.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCSV.Location = new System.Drawing.Point(1407, 48);
            this.btnSendCSV.Name = "btnSendCSV";
            this.btnSendCSV.Size = new System.Drawing.Size(230, 32);
            this.btnSendCSV.TabIndex = 13;
            this.btnSendCSV.Text = "목록 CSV내보내기";
            this.btnSendCSV.UseVisualStyleBackColor = false;
            this.btnSendCSV.Click += new System.EventHandler(this.BtnSendCSV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "기간선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "기간별 알람이력 조회";
            // 
            // AlarmResult_Simple
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 950);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlarmResult_Simple";
            this.Text = "AlarmResult_Simple";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxEndSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEndMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStartSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStartMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStartHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgAlarmList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendCSV;
        private C1.Win.C1FlexGrid.C1FlexGrid fgAlarmList;
        private C1.Win.C1Input.C1ComboBox cbxPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.DateTimePicker dpenddate;
        private System.Windows.Forms.DateTimePicker dpstartdate;
        private C1.Win.C1Input.C1ComboBox cbxStartSec;
        private C1.Win.C1Input.C1ComboBox cbxStartMinute;
        private C1.Win.C1Input.C1ComboBox cbxStartHour;
        private C1.Win.C1Input.C1ComboBox cbxEndSec;
        private C1.Win.C1Input.C1ComboBox cbxEndMinute;
        private C1.Win.C1Input.C1ComboBox cbxEndHour;
        //================================================================================================================================


        public AlarmResult_Simple()
        {
            InitializeComponent();
            InitInputData();

        }

        private readonly AnalyzeWriteLog cAwLog = new AnalyzeWriteLog();
        private static readonly ILog cLog = LogManager.GetLogger("Analysis");
        readonly MySqlDTO cMysqlDto = new MySqlDTO();
        private DataTable m_dtResultData = new DataTable();

        private void InitInputData()
        {
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

            string sql = $"select count(*) as cnt from tbl_alarm ,(select @num:=0) as s where starttime >='{start}' AND starttime <='{end}' AND not starttime <=> null ";

            try
            {


                int rowCnt = Convert.ToInt32(cMysqlDto.SelectSql2(sql, "cnt")[0]["cnt"]);

                if (rowCnt == 0)
                {
                    MessageBox.Show("알람 이력이 없습니다.", "알람이력조회", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.Message);
            }
            try
            {
                string dbsql = $"select (@num:=@num+1) as no, DATE_FORMAT(starttime, '%Y-%m-%d %H:%i:%s') AS starttime,aldiv, mbid, alno,title,content, memo from (select @num:=0) as s, tbl_alarm as t  WHERE t.starttime >='{start}' AND t.starttime <='{end}' AND not t.starttime <=> null";
                List<Dictionary<string, string>> dicReturn1 = new List<Dictionary<string, string>>();
                Dictionary<string, string> row = new Dictionary<string, string>();
                dicReturn1 = cMysqlDto.SelectAll(dbsql);

                int colIndex;
                int gridIndex;

                if (dicReturn1.Count > 0)
                {
                    for (int i = 0; i < dicReturn1.Count; i++)
                    {
                        colIndex = 1;
                        gridIndex = i == dicReturn1.Count ? i : i + 1;
                        row = dicReturn1[i];
                        if (row != null)
                        {
                            List<string> columnlist = new List<string>();
                            foreach (string key in row.Values)
                            {
                                fgAlarmList[gridIndex, colIndex++] = key;
                            }
                        }
                    }
                }
                //csv파일 위해
                m_dtResultData = cMysqlDto.SelectSqlToDataTable(dbsql);
                ChangeHeader();
            }
            catch
            {
                MessageBox.Show("검색한 기간내 알람 이력 정보를 불러오는데 실패했습니다.", "알람이력조회", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cLog.Error(cAwLog.AlarmSearchError);
                return;
            }

        }
        private void ChangeHeader()
        {
            m_dtResultData.Columns["no"].ColumnName = "NO";
            m_dtResultData.Columns["starttime"].ColumnName = "알람발생시간";
            m_dtResultData.Columns["aldiv"].ColumnName = "알람등급";
            m_dtResultData.Columns["mbid"].ColumnName = "사용자명";
            m_dtResultData.Columns["alno"].ColumnName = "알람코드";
            m_dtResultData.Columns["title"].ColumnName = "알람제목";
            m_dtResultData.Columns["content"].ColumnName = "알람내용";
            m_dtResultData.Columns["memo"].ColumnName = "옵션";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            cLog.Info(cAwLog.AlarmSearchEventLog);
            DailyMeasureList();
        }

        private void BtnSendCSV_Click(object sender, EventArgs e)
        {

            if (fgAlarmList[2, 2] == null)
            {
                MessageBox.Show("데이터가 없습니다", "목록csv내보내기", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cLog.Info(cAwLog.AlarmSendCSVEventLog);
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
                        Title = strBtnName,
                        RestoreDirectory = true,
                        FileName = DateTime.Now.ToString("yyyyMMdHHmmssfff") + "_alarm_history",
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
                        MessageBox.Show("저장이 완료되었습니다", "알람이력조회", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                        cLog.Error(cAwLog.AlarmListExportCSVError);
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

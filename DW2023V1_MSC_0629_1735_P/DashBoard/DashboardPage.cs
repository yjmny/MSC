using DBMS_V1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace DashBoard
{
    public partial class DashboardPage : Form
    {

        // 디자인 영역====================================================================================================================
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPage));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.fgDailyMeasure = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.fgMonthlyMeasure = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.fgDailyAlarm = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.fgMonthlyAlarm = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgDailyMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgMonthlyMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgDailyAlarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgMonthlyAlarm)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1640, 950);
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "대시보드";
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
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(1640, 899);
            this.splitContainer2.SplitterDistance = 440;
            this.splitContainer2.SplitterWidth = 10;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.fgDailyMeasure);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.fgMonthlyMeasure);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Size = new System.Drawing.Size(1640, 440);
            this.splitContainer3.SplitterDistance = 820;
            this.splitContainer3.SplitterWidth = 10;
            this.splitContainer3.TabIndex = 0;
            // 
            // fgDailyMeasure
            // 
            this.fgDailyMeasure.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.fgDailyMeasure.AllowEditing = false;
            this.fgDailyMeasure.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgDailyMeasure.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgDailyMeasure.ColumnInfo = resources.GetString("fgDailyMeasure.ColumnInfo");
            this.fgDailyMeasure.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None;
            this.fgDailyMeasure.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.fgDailyMeasure.Location = new System.Drawing.Point(12, 28);
            this.fgDailyMeasure.Name = "fgDailyMeasure";
            this.fgDailyMeasure.Rows.Count = 32;
            this.fgDailyMeasure.Rows.DefaultSize = 30;
            this.fgDailyMeasure.Size = new System.Drawing.Size(793, 400);
            this.fgDailyMeasure.StyleInfo = resources.GetString("fgDailyMeasure.StyleInfo");
            this.fgDailyMeasure.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "측정 일별 현황";
            // 
            // fgMonthlyMeasure
            // 
            this.fgMonthlyMeasure.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.fgMonthlyMeasure.AllowEditing = false;
            this.fgMonthlyMeasure.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgMonthlyMeasure.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgMonthlyMeasure.ColumnInfo = resources.GetString("fgMonthlyMeasure.ColumnInfo");
            this.fgMonthlyMeasure.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.fgMonthlyMeasure.Location = new System.Drawing.Point(7, 31);
            this.fgMonthlyMeasure.Name = "fgMonthlyMeasure";
            this.fgMonthlyMeasure.Rows.Count = 13;
            this.fgMonthlyMeasure.Rows.DefaultSize = 30;
            this.fgMonthlyMeasure.Size = new System.Drawing.Size(791, 397);
            this.fgMonthlyMeasure.StyleInfo = resources.GetString("fgMonthlyMeasure.StyleInfo");
            this.fgMonthlyMeasure.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "측정 월별 현황";
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.fgDailyAlarm);
            this.splitContainer4.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.fgMonthlyAlarm);
            this.splitContainer4.Panel2.Controls.Add(this.label5);
            this.splitContainer4.Size = new System.Drawing.Size(1640, 449);
            this.splitContainer4.SplitterDistance = 820;
            this.splitContainer4.SplitterWidth = 10;
            this.splitContainer4.TabIndex = 0;
            // 
            // fgDailyAlarm
            // 
            this.fgDailyAlarm.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.fgDailyAlarm.AllowEditing = false;
            this.fgDailyAlarm.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgDailyAlarm.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgDailyAlarm.ColumnInfo = resources.GetString("fgDailyAlarm.ColumnInfo");
            this.fgDailyAlarm.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.fgDailyAlarm.Location = new System.Drawing.Point(12, 31);
            this.fgDailyAlarm.Name = "fgDailyAlarm";
            this.fgDailyAlarm.Rows.Count = 32;
            this.fgDailyAlarm.Rows.DefaultSize = 30;
            this.fgDailyAlarm.Size = new System.Drawing.Size(793, 400);
            this.fgDailyAlarm.StyleInfo = resources.GetString("fgDailyAlarm.StyleInfo");
            this.fgDailyAlarm.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "알람 일간 현황";
            // 
            // fgMonthlyAlarm
            // 
            this.fgMonthlyAlarm.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.fgMonthlyAlarm.AllowEditing = false;
            this.fgMonthlyAlarm.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgMonthlyAlarm.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgMonthlyAlarm.ColumnInfo = resources.GetString("fgMonthlyAlarm.ColumnInfo");
            this.fgMonthlyAlarm.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Bold);
            this.fgMonthlyAlarm.Location = new System.Drawing.Point(8, 31);
            this.fgMonthlyAlarm.Name = "fgMonthlyAlarm";
            this.fgMonthlyAlarm.Rows.Count = 13;
            this.fgMonthlyAlarm.Rows.DefaultSize = 30;
            this.fgMonthlyAlarm.Size = new System.Drawing.Size(790, 400);
            this.fgMonthlyAlarm.StyleInfo = resources.GetString("fgMonthlyAlarm.StyleInfo");
            this.fgMonthlyAlarm.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "알람 월간 현황";
            // 
            // DashboardPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 950);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1640, 950);
            this.MinimumSize = new System.Drawing.Size(1640, 950);
            this.Name = "DashboardPage";
            this.Text = "DashboardPage";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgDailyMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgMonthlyMeasure)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgDailyAlarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgMonthlyAlarm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private C1.Win.C1FlexGrid.C1FlexGrid fgDailyMeasure;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1FlexGrid.C1FlexGrid fgMonthlyMeasure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private C1.Win.C1FlexGrid.C1FlexGrid fgDailyAlarm;
        private System.Windows.Forms.Label label4;
        private C1.Win.C1FlexGrid.C1FlexGrid fgMonthlyAlarm;
        private System.Windows.Forms.Label label5;
        //================================================================================================================================


        public DashboardPage()
        {
            InitializeComponent();

            try
            {
                DateTime today = DateTime.Today;
                int day = today.Day;
                int selmonth = today.Month;

                DailyMeasureList();
                MonthlyMeasureList();


                AlarmDailyMeasureList();
                AlarmMonthlyMeasureList();

                fgDailyMeasure.Rows[day].Selected = true; fgDailyMeasure.Select(day, 1);
                fgMonthlyMeasure.Rows[selmonth].Selected = true; fgMonthlyMeasure.Select(selmonth, 1);
                fgDailyAlarm.Rows[day].Selected = true; fgDailyAlarm.Select(day, 1);
                fgMonthlyAlarm.Rows[selmonth].Selected = true; fgMonthlyAlarm.Select(selmonth, 1);
            }
            catch (Exception exc) { System.Diagnostics.Debug.WriteLine(exc.ToString()); }
            finally { }
        }

        readonly MySqlDTO msdto = new MySqlDTO();

        public void DailyMeasureList()
        {
            DateTime today = DateTime.Today;
            string year = today.Year.ToString();
            string month = today.Month.ToString("00");
            int daysinmonth = DateTime.DaysInMonth(int.Parse(year), int.Parse(month));
           

            for (int i = 3; i < 5; i++)
            {
                for (int j = 1; j <= daysinmonth; j++)
                {
                    fgDailyMeasure[j, i] = "0";

                }
            }
            int colnum = 1;
            for (int i = 1; i <= daysinmonth; i++)
            {
                fgDailyMeasure[i, colnum] = i.ToString();
                fgDailyMeasure[i, colnum + 1] = year + "-" + month + "-" + i.ToString("00");
            }
            try
            {

                DateTime firstDay = today.AddDays(1 - today.Day);
                DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

                string startDay = firstDay.ToString("yyyyMMdd");
                string endDay = lastDay.ToString("yyyyMMdd");

                string sql = $@"select DATE_FORMAT(mstotalendtime, '%Y-%m-%d') days, count(*) as mcount
                                from(select @num:= 0) as num, tbl_measure_result_statistics
                                where mstotalendtime between '{startDay}' and '{endDay}'
                                group by days;";

                List<Dictionary<string, string>> dicReturn1 = new List<Dictionary<string, string>>();
                Dictionary<string, string> row = new Dictionary<string, string>();
                dicReturn1 = msdto.SelectAll(sql);

                int colIndex;
                int gridIndex;

                if (dicReturn1.Count > 0)
                {
                    for (int i = 0; i < dicReturn1.Count; i++)
                    {
                        Dictionary<string, string> row1 = msdto.SelectSql2(sql, "days")[i];
                        string days = row1["days"].ToString().Substring(row1["days"].ToString().Length - 2);
                        colIndex = 2;
                        gridIndex = int.Parse(days.Trim('0'));

                        row = dicReturn1[i];
                        if (row != null)
                        {
                            List<string> columnlist = new List<string>();
                            foreach (string key in row.Values)
                            {
                                fgDailyMeasure[gridIndex, colIndex++] = key;
                            }
                        }
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("일간 측정 통계 데이터 로드 실패", "대시보드", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public void MonthlyMeasureList()
        {
            DateTime today = DateTime.Today;
            string year = today.Year.ToString();

            for (int i = 3; i < 5; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    fgMonthlyMeasure[j, i] = "0";

                }
            }
           
            int colnum = 1;
            for (int i = 1; i < 13; i++)
            {
                fgMonthlyMeasure[i, colnum] = i.ToString();
                fgMonthlyMeasure[i, colnum + 1] = year + "-" + i.ToString("00");
            }
            try
            {
                string startDay = today.ToString("yy") + "0101";
                string endDay = today.ToString("yy") + "1231";

                string sql = $@"select DATE_FORMAT(mstotalendtime, '%Y-%m') monthly, count(*) as mcount
                                from(select @num:= 0) as num, tbl_measure_result_statistics
                                where mstotalendtime between '{startDay}' and '{endDay}'
                                group by monthly;";

                List<Dictionary<string, string>> dicReturn1 = new List<Dictionary<string, string>>();
                Dictionary<string, string> row = new Dictionary<string, string>();


                dicReturn1 = msdto.SelectAll(sql);

                int colIndex;
                int gridIndex;

                if (dicReturn1.Count > 0)
                {
                    for (int i = 0; i < dicReturn1.Count; i++)
                    {
                        Dictionary<string, string> row1 = msdto.SelectSql2(sql, "monthly")[i];
                        string month = row1["monthly"].ToString().Substring(row1["monthly"].ToString().Length - 2);
                        colIndex = 2;
                        gridIndex = int.Parse(month.Trim('0')); //== dicReturn1.Count ? i : i + 1;
                        row = dicReturn1[i];

                        if (row != null)
                        {
                            List<string> columnlist = new List<string>();
                            foreach (string key in row.Values)
                            {
                                fgMonthlyMeasure[gridIndex, colIndex++] = key;
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("월간 측정 통계 데이터 로드 실패", "대시보드", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public void AlarmDailyMeasureList()
        {
            DateTime today = DateTime.Today;
            string year = today.Year.ToString();
            string month = today.Month.ToString("00");
            int daysinmonth = DateTime.DaysInMonth(int.Parse(year), int.Parse(month));

            for (int i = 3; i < 6; i++)
            {
                for (int j = 1; j <= daysinmonth; j++)
                {
                    fgDailyAlarm[j, i] = "0";

                }
            }
          
            int colnum = 1;
            for (int i = 1; i <= daysinmonth; i++)
            {
                fgDailyAlarm[i, colnum] = i.ToString();
                fgDailyAlarm[i, colnum + 1] = year + "-" + month + "-" + i.ToString("00");
            }
            try
            {

                DateTime firstDay = today.AddDays(1 - today.Day);
                DateTime lastDay = firstDay.AddMonths(1).AddDays(-1);

                string startDay = firstDay.ToString("yyyyMMdd");
                string endDay = lastDay.ToString("yyyyMMdd");

                string sql = $@"select
                 (x.starttime) as days
                   , 0 as max
                   , (select count(*) from tbl_alarm a where DATE_FORMAT(a.starttime, '%Y-%m-%d') = x.starttime and a.aldiv = 'ERROR') as mid
                   , (select count(*) from tbl_alarm a where DATE_FORMAT(a.starttime, '%Y-%m-%d') = x.starttime and a.aldiv = 'WARNING') as min
                from(select @num:= 0) as num,(
                   select
                    DATE_FORMAT(starttime, '%Y-%m-%d') as starttime
                   from tbl_alarm
                   where starttime between '{startDay}' and '{endDay}'
                   group by DATE_FORMAT(starttime, '%Y-%m-%d')

                ) x
                order by starttime;";

                List<Dictionary<string, string>> dicReturn1 = new List<Dictionary<string, string>>();
                Dictionary<string, string> row = new Dictionary<string, string>();
                dicReturn1 = msdto.SelectAll(sql);

                int colIndex;
                int gridIndex;

                if (dicReturn1.Count > 0)
                {
                    for (int i = 0; i < dicReturn1.Count; i++)
                    {
                        Dictionary<string, string> row1 = msdto.SelectSql2(sql, "days")[i];
                        string days = row1["days"].ToString().Substring(row1["days"].ToString().Length - 2);
                        colIndex = 2;
                        gridIndex = int.Parse(days.Trim('0'));
                        row = dicReturn1[i];
                        if (row != null)
                        {
                            List<string> columnlist = new List<string>();
                            foreach (string key in row.Values)
                            {
                                fgDailyAlarm[gridIndex, colIndex++] = key;
                            }
                        }
                    }
                }



            }
            catch (Exception exc)
            {
                MessageBox.Show("일간 측정 통계 데이터 로드 실패", "대시보드", MessageBoxButton.OK, MessageBoxImage.Information);
                System.Diagnostics.Debug.WriteLine(exc.Message);
            }
        }
        public void AlarmMonthlyMeasureList()
        {
            DateTime today = DateTime.Today;
            string year = today.Year.ToString();
            for (int i = 3; i < 6; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    fgMonthlyAlarm[j, i] = "0";

                }
            }
          
            int colnum = 1;
            for (int i = 1; i < 13; i++)
            {
                fgMonthlyAlarm[i, colnum] = i.ToString();
                fgMonthlyAlarm[i, colnum + 1] = year + "-" + i.ToString("00");
            }
            try
            {

                string sql = $@"select 
                             (x.starttime) as days
                               , 0 as max
                               , (select count(*) from tbl_alarm a where DATE_FORMAT(a.starttime,'%Y-%m') = x.starttime and  a.aldiv = 'ERROR') as mid
                               , (select count(*) from tbl_alarm a where DATE_FORMAT(a.starttime,'%Y-%m') = x.starttime and  a.aldiv = 'WARNING') as min
                            from (select @num:=0) as num,(
                               select 
                                DATE_FORMAT(starttime,'%Y-%m') as starttime 
                               from tbl_alarm
                               group by DATE_FORMAT(starttime,'%Y-%m') 
                              
                            ) x
                            order by starttime;";


                List<Dictionary<string, string>> dicReturn1 = new List<Dictionary<string, string>>();
                Dictionary<string, string> row = new Dictionary<string, string>();
                dicReturn1 = msdto.SelectAll(sql);

                int colIndex;
                int gridIndex;

                if (dicReturn1.Count > 0)
                {
                    for (int i = 0; i < dicReturn1.Count; i++)
                    {
                        Dictionary<string, string> row1 = msdto.SelectSql2(sql, "days")[i];
                        string month = row1["days"].ToString().Substring(row1["days"].ToString().Length - 2);
                        colIndex = 2;
                        gridIndex = int.Parse(month.Trim('0'));
                        row = dicReturn1[i];
                        if (row != null)
                        {
                            List<string> columnlist = new List<string>();
                            foreach (string key in row.Values)
                            {
                                fgMonthlyAlarm[gridIndex, colIndex++] = key;
                            }
                        }
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("월간 측정 통계 데이터 로드 실패", "대시보드", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }


    }
}

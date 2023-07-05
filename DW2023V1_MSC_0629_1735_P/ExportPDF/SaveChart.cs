using C1.Win.Chart;
using DBMS_V1;
using DwLib.Data.Generic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static ExportPDF.FrmMain;

namespace ExportPDF
{
    public partial class SaveChart : Form
    {
        // 디자인 영역====================================================================================================================
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            this.flexChart = new C1.Win.Chart.FlexChart();
            this.tbxMessage = new System.Windows.Forms.Label();
            this.progressbar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart)).BeginInit();
            this.SuspendLayout();
            // 
            // flexChart
            // 
            this.flexChart.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.flexChart.AnimationLoad.Duration = 400;
            this.flexChart.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.flexChart.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.flexChart.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.flexChart.AnimationUpdate.Duration = 400;
            this.flexChart.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.flexChart.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.flexChart.AxisX.AxisLine = true;
            this.flexChart.AxisX.Chart = this.flexChart;
            this.flexChart.AxisX.DataSource = null;
            this.flexChart.AxisX.Formatter = null;
            this.flexChart.AxisX.GroupProvider = null;
            this.flexChart.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.flexChart.AxisX.GroupStyle.VerticalText = false;
            this.flexChart.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.flexChart.AxisX.GroupVisibilityLevel = 0;
            this.flexChart.AxisX.MajorGridStyle.VerticalText = false;
            this.flexChart.AxisX.MinorGridStyle.VerticalText = false;
            this.flexChart.AxisX.PlotAreaName = null;
            this.flexChart.AxisX.Position = C1.Chart.Position.Bottom;
            this.flexChart.AxisX.Style.VerticalText = false;
            this.flexChart.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.flexChart.AxisX.TitleStyle.VerticalText = false;
            this.flexChart.AxisY.AxisLine = false;
            this.flexChart.AxisY.Chart = this.flexChart;
            this.flexChart.AxisY.DataSource = null;
            this.flexChart.AxisY.Formatter = null;
            this.flexChart.AxisY.GroupProvider = null;
            this.flexChart.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.flexChart.AxisY.GroupStyle.VerticalText = false;
            this.flexChart.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.flexChart.AxisY.GroupVisibilityLevel = 0;
            this.flexChart.AxisY.MajorGrid = true;
            this.flexChart.AxisY.MajorGridStyle.VerticalText = false;
            this.flexChart.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.flexChart.AxisY.MinorGridStyle.VerticalText = false;
            this.flexChart.AxisY.PlotAreaName = null;
            this.flexChart.AxisY.Position = C1.Chart.Position.Left;
            this.flexChart.AxisY.Style.VerticalText = false;
            this.flexChart.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.flexChart.AxisY.TitleStyle.VerticalText = false;
            this.flexChart.BackColor = System.Drawing.Color.White;
            this.flexChart.ChartType = C1.Chart.ChartType.LineSymbols;
            this.flexChart.DataLabel.Angle = 0;
            this.flexChart.DataLabel.Border = false;
            this.flexChart.DataLabel.BorderStyle.VerticalText = false;
            this.flexChart.DataLabel.ConnectingLine = false;
            this.flexChart.DataLabel.Content = null;
            this.flexChart.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.flexChart.DataLabel.MaxAutoLabels = 100;
            this.flexChart.DataLabel.MaxLines = 0;
            this.flexChart.DataLabel.MaxWidth = 0;
            this.flexChart.DataLabel.Offset = 0;
            this.flexChart.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.flexChart.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.flexChart.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.flexChart.DataLabel.Style.VerticalText = false;
            this.flexChart.Legend.ItemMaxWidth = 0;
            this.flexChart.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.flexChart.Legend.Position = C1.Chart.Position.Right;
            this.flexChart.Legend.Reversed = false;
            this.flexChart.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.flexChart.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.flexChart.Legend.Title = null;
            this.flexChart.Location = new System.Drawing.Point(19, 19);
            this.flexChart.Margin = new System.Windows.Forms.Padding(10);
            this.flexChart.Name = "flexChart";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.flexChart.Options.ClusterSize = elementSize1;
            this.flexChart.PlotMargin = new System.Windows.Forms.Padding(0);
            this.flexChart.PlotStyle.VerticalText = false;
            this.flexChart.SelectedSeries = null;
            this.flexChart.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.flexChart.SelectionStyle.VerticalText = false;
            this.flexChart.Size = new System.Drawing.Size(846, 290);
            this.flexChart.TabIndex = 0;
            this.flexChart.Text = "flexChart1";
            // 
            // 
            // 
            this.flexChart.ToolTip.Content = "";
            // 
            // tbxMessage
            // 
            this.tbxMessage.AutoSize = true;
            this.tbxMessage.BackColor = System.Drawing.Color.White;
            this.tbxMessage.Location = new System.Drawing.Point(388, 319);
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(121, 12);
            this.tbxMessage.TabIndex = 1;
            this.tbxMessage.Text = "차트 저장중 입니다...";
            // 
            // progressbar1
            // 
            this.progressbar1.Location = new System.Drawing.Point(169, 350);
            this.progressbar1.Name = "progressbar1";
            this.progressbar1.Size = new System.Drawing.Size(543, 48);
            this.progressbar1.TabIndex = 2;
            // 
            // SaveChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 410);
            this.Controls.Add(this.progressbar1);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.flexChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaveChart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SaveChart";
            ((System.ComponentModel.ISupportInitialize)(this.flexChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Chart.FlexChart flexChart;
        private System.Windows.Forms.Label tbxMessage;
        private System.Windows.Forms.ProgressBar progressbar1;
        //================================================================================================================================




        Series series1 = new Series { Name = "누적 최대", Binding = "PosY" };
        Series series2 = new Series { Name = "누적 최소", Binding = "PosY" };
        Series series3 = new Series { Name = "누적 평균", Binding = "PosY" };

        private ObservableCollection<DataXY> MaxPoints = new ObservableCollection<DataXY>() { };
        private ObservableCollection<DataXY> MinPoints = new ObservableCollection<DataXY>() { };
        private ObservableCollection<DataXY> AvgPoints = new ObservableCollection<DataXY>() { };
        public static string msid;
        public static string calibid;
        private MySqlDTO msdto = new MySqlDTO();
        public SaveChart(List<string> option)
        {
            InitializeComponent();

            string dbsql = $"select (@num:=@num+1) as no, msid, DATE_FORMAT(mstotalstarttime, '%Y-%m-%d %H:%i:%s') AS mstotalstarttime, DATE_FORMAT(mstotalendtime, '%Y-%m-%d %H:%i:%s') AS mstotalendtime , rcpname,reqmbname, method, " +
                     $" md1max,md1min,md1avg, md2max,md2min,md2avg, md3max,md3min,md3avg, md4max,md4min,md4avg," +
                     $" ai01max,ai01min,ai01avg, ai02max,ai02min,ai02avg, ai03max,ai03min,ai03avg, ai04max,ai04min,ai04avg, ai05max,ai05min,ai05avg, ai06max,ai06min,ai06avg, ai07max,ai07min,ai07avg, " +
                     $" ai08max,ai08min,ai08avg, ai09max,ai09min,ai09avg, ai10max,ai10min,ai10avg, ai11max,ai11min,ai11avg, ai12max,ai12min, ai12avg," +
                     $" ao01max,ao01min,ao01avg, ao02max,ao02min,ao02avg, di01max,di01min,di01avg, di02max,di02min,di02avg, di03max,di03min,di03avg, di04max,di04min,di04avg, do01max,do01min,do01avg, do02max,do02min,do02avg" +
                     $" from (select @num:=0) as s, tbl_measure_result_statistics as t  WHERE t.msid = '{msid}' ";


            List<Dictionary<string, string>> rows = msdto.SelectSql2(dbsql, "md1avg", "md2avg", "md3avg", "md4avg", "ai01avg", "ai02avg", "ai03avg", "ai04avg", "ai05avg", "ai06avg", "ai07avg", "ai08avg", "ai09avg", "ai10avg", "ai11avg", "ai12avg", "ao01avg", "ao02avg", "di01avg", "di02avg", "di03avg", "di04avg", "do01avg", "do02avg",
                                                                            "md1min", "md2min", "md3min", "md4min", "ai01min", "ai02min", "ai03min", "ai04min", "ai05min", "ai06min", "ai07min", "ai08min", "ai09min", "ai10min", "ai11min", "ai12min", "ao01min", "ao02min", "di01min", "di02min", "di03min", "di04min", "do01min", "do02min",
                                                                            "md1max", "md2max", "md3max", "md4max", "ai01max", "ai02max", "ai03max", "ai04max", "ai05max", "ai06max", "ai07max", "ai08max", "ai09max", "ai10max", "ai11max", "ai12max", "ao01max", "ao02max", "di01max", "di02max", "di03max", "di04max", "do01max", "do02max");

            Dictionary<string, string> rowch = msdto.SelectSql2(dbsql, "ai01avg", "ai01min", "ai01max", "ai02avg", "ai02min", "ai02max", "ai03avg", "ai04avg", "ai05avg", "ai06avg", "ai07avg", "ai08avg", "ai09avg", "ai10avg", "ai11avg", "ai12avg", "ai03min", "ai04min", "ai05min", "ai06min", "ai07min", "ai08min", "ai09min", "ai10min", "ai11min", "ai12min", "ai03max", "ai04max", "ai05max", "ai06max", "ai07max", "ai08max", "ai09max", "ai10max", "ai11max", "ai12max")[0];
            string sql = $"select ch1_name,ch2_name,ch3_name,ch4_name,ch5_name,ch6_name,ch7_name,ch8_name,ch9_name,ch10_name,ch11_name,ch12_name from tbl_plc_calibration, (select @num:= 0) as s where id ='{calibid}' ";
            Dictionary<string, string> rowcal = msdto.SelectSql2(sql, "ch1_name", "ch2_name", "ch3_name", "ch4_name", "ch5_name", "ch6_name", "ch7_name", "ch8_name", "ch9_name", "ch10_name", "ch11_name", "ch12_name")[0];
            if (option == null)
            {
                ChamberAddSeries();
                try
                {
                    if (rows.Count > 0)
                    {
                        foreach (Dictionary<string, string> row2 in rows)
                        {

                            MaxPoints.Add(new DataXY() { PosX = "현재온도", PosY = double.Parse(row2["md1max"]) });
                            MinPoints.Add(new DataXY() { PosX = "현재온도", PosY = double.Parse(row2["md1min"]) });
                            AvgPoints.Add(new DataXY() { PosX = "현재온도", PosY = double.Parse(row2["md1avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = "현재습도", PosY = double.Parse(row2["md2max"]) });
                            MinPoints.Add(new DataXY() { PosX = "현재습도", PosY = double.Parse(row2["md2min"]) });
                            AvgPoints.Add(new DataXY() { PosX = "현재습도", PosY = double.Parse(row2["md2avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = "설정온도", PosY = double.Parse(row2["md3max"]) });
                            MinPoints.Add(new DataXY() { PosX = "설정온도", PosY = double.Parse(row2["md3min"]) });
                            AvgPoints.Add(new DataXY() { PosX = "설정온도", PosY = double.Parse(row2["md3avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = "설정습도", PosY = double.Parse(row2["md4max"]) });
                            MinPoints.Add(new DataXY() { PosX = "설정습도", PosY = double.Parse(row2["md4min"]) });
                            AvgPoints.Add(new DataXY() { PosX = "설정습도", PosY = double.Parse(row2["md4avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = rowcal["ch1_name"], PosY = double.Parse(row2["ai01max"]) });
                            MinPoints.Add(new DataXY() { PosX = rowcal["ch1_name"], PosY = double.Parse(row2["ai01min"]) });
                            AvgPoints.Add(new DataXY() { PosX = rowcal["ch1_name"], PosY = double.Parse(row2["ai01avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = rowcal["ch2_name"], PosY = double.Parse(row2["ai02max"]) });
                            MinPoints.Add(new DataXY() { PosX = rowcal["ch2_name"], PosY = double.Parse(row2["ai02min"]) });
                            AvgPoints.Add(new DataXY() { PosX = rowcal["ch2_name"], PosY = double.Parse(row2["ai02avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = rowcal["ch3_name"], PosY = double.Parse(row2["ai03max"]) });
                            MinPoints.Add(new DataXY() { PosX = rowcal["ch3_name"], PosY = double.Parse(row2["ai03min"]) });
                            AvgPoints.Add(new DataXY() { PosX = rowcal["ch3_name"], PosY = double.Parse(row2["ai03avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = rowcal["ch4_name"], PosY = double.Parse(row2["ai04max"]) });
                            MinPoints.Add(new DataXY() { PosX = rowcal["ch4_name"], PosY = double.Parse(row2["ai04min"]) });
                            AvgPoints.Add(new DataXY() { PosX = rowcal["ch4_name"], PosY = double.Parse(row2["ai04avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = rowcal["ch5_name"], PosY = double.Parse(row2["ai05max"]) });
                            MinPoints.Add(new DataXY() { PosX = rowcal["ch5_name"], PosY = double.Parse(row2["ai05min"]) });
                            AvgPoints.Add(new DataXY() { PosX = rowcal["ch5_name"], PosY = double.Parse(row2["ai05avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = rowcal["ch6_name"], PosY = double.Parse(row2["ai06max"]) });
                            MinPoints.Add(new DataXY() { PosX = rowcal["ch6_name"], PosY = double.Parse(row2["ai06min"]) });
                            AvgPoints.Add(new DataXY() { PosX = rowcal["ch6_name"], PosY = double.Parse(row2["ai06avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = rowcal["ch7_name"], PosY = double.Parse(row2["ai07max"]) });
                            MinPoints.Add(new DataXY() { PosX = rowcal["ch7_name"], PosY = double.Parse(row2["ai07min"]) });
                            AvgPoints.Add(new DataXY() { PosX = rowcal["ch7_name"], PosY = double.Parse(row2["ai07avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = rowcal["ch8_name"], PosY = double.Parse(row2["ai08max"]) });
                            MinPoints.Add(new DataXY() { PosX = rowcal["ch8_name"], PosY = double.Parse(row2["ai08min"]) });
                            AvgPoints.Add(new DataXY() { PosX = rowcal["ch8_name"], PosY = double.Parse(row2["ai08avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = rowcal["ch9_name"], PosY = double.Parse(row2["ai09max"]) });
                            MinPoints.Add(new DataXY() { PosX = rowcal["ch9_name"], PosY = double.Parse(row2["ai09min"]) });
                            AvgPoints.Add(new DataXY() { PosX = rowcal["ch9_name"], PosY = double.Parse(row2["ai09avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = rowcal["ch10_name"], PosY = double.Parse(row2["ai10max"]) });
                            MinPoints.Add(new DataXY() { PosX = rowcal["ch10_name"], PosY = double.Parse(row2["ai10min"]) });
                            AvgPoints.Add(new DataXY() { PosX = rowcal["ch10_name"], PosY = double.Parse(row2["ai10avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = rowcal["ch11_name"], PosY = double.Parse(row2["ai11max"]) });
                            MinPoints.Add(new DataXY() { PosX = rowcal["ch11_name"], PosY = double.Parse(row2["ai11min"]) });
                            AvgPoints.Add(new DataXY() { PosX = rowcal["ch11_name"], PosY = double.Parse(row2["ai11avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = rowcal["ch12_name"], PosY = double.Parse(row2["ai12max"]) });
                            MinPoints.Add(new DataXY() { PosX = rowcal["ch12_name"], PosY = double.Parse(row2["ai12min"]) });
                            AvgPoints.Add(new DataXY() { PosX = rowcal["ch12_name"], PosY = double.Parse(row2["ai12avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = "AO01", PosY = double.Parse(row2["ao01max"]) });
                            MinPoints.Add(new DataXY() { PosX = "AO01", PosY = double.Parse(row2["ao01min"]) });
                            AvgPoints.Add(new DataXY() { PosX = "AO01", PosY = double.Parse(row2["ao01avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = "AO02", PosY = double.Parse(row2["ao02max"]) });
                            MinPoints.Add(new DataXY() { PosX = "AO02", PosY = double.Parse(row2["ao02min"]) });
                            AvgPoints.Add(new DataXY() { PosX = "AO02", PosY = double.Parse(row2["ao02avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = "DI01", PosY = double.Parse(row2["di01max"]) });
                            MinPoints.Add(new DataXY() { PosX = "DI01", PosY = double.Parse(row2["di01min"]) });
                            AvgPoints.Add(new DataXY() { PosX = "DI01", PosY = double.Parse(row2["di01avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = "DI02", PosY = double.Parse(row2["di02max"]) });
                            MinPoints.Add(new DataXY() { PosX = "DI02", PosY = double.Parse(row2["di02min"]) });
                            AvgPoints.Add(new DataXY() { PosX = "DI02", PosY = double.Parse(row2["di02avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = "DI03", PosY = double.Parse(row2["di03max"]) });
                            MinPoints.Add(new DataXY() { PosX = "DI03", PosY = double.Parse(row2["di03min"]) });
                            AvgPoints.Add(new DataXY() { PosX = "DI03", PosY = double.Parse(row2["di03avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = "DI04", PosY = double.Parse(row2["di04max"]) });
                            MinPoints.Add(new DataXY() { PosX = "DI04", PosY = double.Parse(row2["di04min"]) });
                            AvgPoints.Add(new DataXY() { PosX = "DI04", PosY = double.Parse(row2["di04avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = "DO01", PosY = double.Parse(row2["do01max"]) });
                            MinPoints.Add(new DataXY() { PosX = "DO01", PosY = double.Parse(row2["do01min"]) });
                            AvgPoints.Add(new DataXY() { PosX = "DO01", PosY = double.Parse(row2["do01avg"]) });
                            MaxPoints.Add(new DataXY() { PosX = "DO02", PosY = double.Parse(row2["do02max"]) });
                            MinPoints.Add(new DataXY() { PosX = "DO02", PosY = double.Parse(row2["do02min"]) });
                            AvgPoints.Add(new DataXY() { PosX = "DO02", PosY = double.Parse(row2["do02avg"]) });

                            flexChart.BindingX = "PosX";
                            series1.DataSource = MaxPoints;
                            series2.DataSource = MinPoints;
                            series3.DataSource = AvgPoints;
                            flexChart.DataSource = MaxPoints;
                            flexChart.AxisX.LabelAngle = 60;
                        }
                    }
                }
                catch (Exception exc)
                {
                    System.Diagnostics.Debug.WriteLine(exc);
                }
                Delay(2000);
                SaveChart123();
            }

            else
            {
                ChamberAddSeries();

                try
                {
                    if (rows.Count > 0)
                    {

                        foreach (string i in option)
                        {

                            MaxPoints.Add(new DataXY() { PosX = rowcal["ch" + i.TrimStart('0') + "_name"], PosY = double.Parse(rowch["ai" + i + "max"]) });
                            MinPoints.Add(new DataXY() { PosX = rowcal["ch" + i.TrimStart('0') + "_name"], PosY = double.Parse(rowch["ai" + i + "min"]) });
                            AvgPoints.Add(new DataXY() { PosX = rowcal["ch" + i.TrimStart('0') + "_name"], PosY = double.Parse(rowch["ai" + i + "avg"]) });
                        }

                        flexChart.BindingX = "PosX";
                        series1.DataSource = MaxPoints;
                        series2.DataSource = MinPoints;
                        series3.DataSource = AvgPoints;
                        flexChart.DataSource = MaxPoints;
                        flexChart.AxisX.LabelAngle = 60;

                    }
                }
                catch (Exception exc)
                {
                    System.Diagnostics.Debug.WriteLine(exc);
                }
                Delay(2000);
                SaveChart123();


            }
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

        public bool SaveChart123()
        {
            try
            {
                using (FileStream stream = new FileStream("chart1.png", FileMode.Create, FileAccess.Write))
                {
                    var format = ImageFormat.Jpg;
                    flexChart.SaveImage(stream, format, flexChart.Width, flexChart.Height);
                    progressbar1.Value = 100;
                    tbxMessage.Text = "PDF 저장 완료되었습니다." + " (" + progressbar1.Value.ToString() + "%)";
                    Delay(1000);
                    CommonClass.isExportPdfClosed = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("차트1가 저장되지 않았습니다.\r\n저장을 취소합니다.", "PDF내보내기", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressbar1.Value = 0;
                System.Diagnostics.Debug.WriteLine(exc);
                CommonClass.isExportPdfClosed = false;
                return false;
            }

            return true;
        }

        private void ChamberAddSeries()
        {
            if (CommonClass.chartOption == 4)
                flexChart.ChartType = C1.Chart.ChartType.Column;
            else
                flexChart.ChartType = C1.Chart.ChartType.Line;

            flexChart.Series.Add(series1);
            this.flexChart.Series[0].Style.StrokeColor = Color.Red;
            this.flexChart.Series[0].Style.Fill = Brushes.Red;
            flexChart.Series.Add(series2);
            this.flexChart.Series[1].Style.StrokeColor = Color.Blue;
            this.flexChart.Series[1].Style.Fill = Brushes.Blue;
            flexChart.Series.Add(series3);
            this.flexChart.Series[2].Style.StrokeColor = Color.Green;
            this.flexChart.Series[2].Style.Fill = Brushes.Green;

        }

    }
}

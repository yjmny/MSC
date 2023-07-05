using C1.Win.C1FlexGrid;
using DWDBMS_V1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace DoAnalysisMSC.Pages
{
    public partial class TestResult_Simple : Form
    {
        MySqlDTO msdto = new MySqlDTO();
        private DataTable resultDataTable1 = new DataTable();
        public TestResult_Simple()
        {
            InitializeComponent();
            fgMeasureList[1, 1] = "NO";
            fgMeasureList[1, 2] = "측정ID";
            fgMeasureList[1, 3] = "측정시작시간";
            fgMeasureList[1, 4] = "측정완료시간";
            fgMeasureList[1, 5] = "레시피명";
            fgMeasureList[1, 6] = "의뢰자명";
            fgMeasureList[1, 7] = "시험방법";

            for(int i=8; i<81; i = i+3)
            {
                fgMeasureList[1, i] = "최대";
            }
            for (int i = 9; i < 82; i = i + 3)
            {
                fgMeasureList[1, i] = "최소";
            }
            for (int i = 10; i < 83; i = i + 3)
            {
                fgMeasureList[1, i] = "평균";
            }

            //fgMeasureList.AllowMerging = C1.Win.C1FlexGrid.AllowMergingEnum.RestrictCols;
            //for (int i = 0; i < fgMeasureList.Cols.Count; i++)
            //    fgMeasureList.Cols[i].AllowMerging = true;

            fgMeasureList.AllowMerging = AllowMergingEnum.Custom;
            for (int i = 1; i < 8; i++)
            {
                CellRange cCellRange = fgMeasureList.GetCellRange(0, i, 1, i);
                fgMeasureList.MergedRanges.Add(cCellRange);
            }

            for (int i = 8; i<83 ; i=i+3)
            {
                CellRange rCellRange = fgMeasureList.GetCellRange(0, i, 0, i+2);
                fgMeasureList.MergedRanges.Add(rCellRange);
            }
            
           
        }

        private void cbxPeriod_SelectedValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            //ComboBox typeItem = (ComboBox)cbxPeriod.SelectedItem;
            string strSerchOpt = cbxPeriod.SelectedItem.ToString();
            string sql = "";


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

        public void DailyMeasureList()
        {
            string sql = "";
            string start = dpstartdate.Value.ToString("yyyy-MM-dd");
            string end = dpenddate.Value.ToString("yyyy-MM-dd");
            //string time1 = testarttime.Value.ToString();
            //string time2 = teendtime.Value.ToString();

            //start = start + " " + time1;
            //end = end + " " + time2;
            //sql = $"select count(*) as cnt from tbl_measure_result_statistics ,(select @num:=0) as s where mstotalstarttime >='{start}' AND mstotalstarttime <= '{end}' AND not mstotalendtime <=> null ";

           sql = $"select count(*) as cnt from tbl_measure_result_statistics ,(select @num:=0) as s where mstotalstarttime between date('{start}') AND date('{end}')+1;";
            int rowCnt = 0;
            try
            {


                rowCnt = Convert.ToInt32(msdto.SelectSql2(sql, "cnt")[0]["cnt"]);

                if (rowCnt == 0)
                {
                    MessageBox.Show("측정 이력이 없습니다.", "측정이력조회(기본)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
            }
            catch (Exception exc)
            {

            }
            try
            {
                string dbsql = $"select (@num:=@num+1) as no, msid, DATE_FORMAT(mstotalstarttime, '%Y-%m-%d %H:%i:%s') AS mstotalstarttime, DATE_FORMAT(mstotalendtime, '%Y-%m-%d %H:%i:%s') AS mstotalendtime , rcpname,reqmbname, method, " +
                    $"  md1avg,md2avg,md3avg,md4avg,ai01avg, ai02avg, ai03avg, ai04avg, ai05avg, ai06avg, ai07avg, ai08avg, ai09avg, ai10avg, ai11avg, ai12avg, ao01avg, ao02avg,di01avg,di02avg,di03avg,di04avg,do01avg,do02avg," +
                    $"  md1min,md2min,md3min,md4min,ai01min,ai02min,ai03min,ai04min,ai05min,ai06min,ai07min,ai08min,ai09min,ai10min,ai11min,ai12min,ao01min,ao02min,di01min,di02min,di03min,di04min,do01min,do02min,"+
                    $"  md1max,md2max,md3max,md4max,ai01max,ai02max,ai03max,ai04max,ai05max,ai06max,ai07max,ai08max,ai09max,ai10max,ai11max,ai12max,ao01max,ao02max,di01max,di02max,di03max,di04max,do01max,do02max " +
                    $"  from (select @num:=0) as s, tbl_measure_result_statistics as t  WHERE t.mstotalstarttime >='{start}' AND t.mstotalstarttime <= date('{end}')+1 AND not t.mstotalendtime <=> null";
                //DataTable dt = msdto.SelectSqlToDataTable(dbsql);
                //fgMeasureList.DataSource = dt;


                List<Dictionary<string, string>> dicReturn1 = new List<Dictionary<string, string>>();
                Dictionary<string, string> row = new Dictionary<string, string>();
                dicReturn1 = msdto.SelectAll(dbsql);

                int pkno = 0;
                int colIndex;
                int gridIndex;

                if (dicReturn1.Count > 0)
                {
                    for (int i = 0; i < dicReturn1.Count; i++)
                    {
                        colIndex = 1;
                        gridIndex = i == dicReturn1.Count ? i : i + 2;
                        row = dicReturn1[i];
                        if (row != null)
                        {
                            List<string> columnlist = new List<string>();
                            foreach (string key in row.Values)
                            {
                                fgMeasureList[gridIndex, colIndex++] = key;
                            }
                        }
                    }
                }
                //resultDataTable1 = msdto.SelectSqlToDataTable(dbsql);
                //ChangeHeader(resultDataTable1);
            }
            catch
            {
                MessageBox.Show("검색한 기간내 측정 이력 정보를 불러오는데 실패했습니다.", "측정이력조회(기본)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //log.Error(Awlog.SimpleMeasureSearchError);
                return;
            }

        }
        private void ChangeHeader(DataTable reultDataTable1)
        {
            resultDataTable1.Columns["no"].ColumnName = "NO";
            resultDataTable1.Columns["mstotalstarttime"].ColumnName = "측정시작시간";
            resultDataTable1.Columns["mstotalendtime"].ColumnName = "측정완료시간";
            resultDataTable1.Columns["rcpname"].ColumnName = "레시피명";
            resultDataTable1.Columns["method"].ColumnName = "시험방법";
            resultDataTable1.Columns["reqmbname"].ColumnName = "의뢰자명";
            resultDataTable1.Columns["reqsampleid1"].ColumnName = "의뢰자샘플ID";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //log.Info(Awlog.SimpleMeasureSearchEventLog);
            DailyMeasureList();
        }

        private void btnSendCSV_Click(object sender, EventArgs e)
        {
            //log.Info(Awlog.SimpleMeasureSendCSVEventLog);
            string strBtnName = "CSV 내보내기";
            Button btn = sender as Button;
            if (MessageBox.Show(strBtnName + "하시겠습니까?", strBtnName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            else
            {


                //파일 저장 위치 선택.
                System.Windows.Forms.SaveFileDialog saveDlg = new System.Windows.Forms.SaveFileDialog();
                saveDlg.Title = "CSV 내보내기";
                saveDlg.RestoreDirectory = true;
                saveDlg.FileName = DateTime.Now.ToString("yyyyMMdHHmmssfff") + "mdata";
                saveDlg.Filter = "csv (*.csv)|*.csv|txt (*txt)|*.txt|All files (*.*)|*.*";
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
                    string line = string.Join(",", resultDataTable1.Columns.Cast<object>());
                    sw.WriteLine(line);

                    //row들을 ","로 나누고 저장.
                    foreach (DataRow item in resultDataTable1.Rows)
                    {
                        line = string.Join(",", item.ItemArray.Cast<object>());
                        sw.WriteLine(line);
                    }

                    sw.Close();
                    fs.Close();
                    MessageBox.Show("저장이 완료되었습니다", "측정이력조회(기본)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                    //log.Error(Awlog.SimpleMeasureExportCSVError);
                }
                finally { }
            }
        }

        private void fgMeasureList_Click(object sender, EventArgs e)
        {

        }

        private void fgMeasureList_Click_1(object sender, EventArgs e)
        {

        }
    }
}

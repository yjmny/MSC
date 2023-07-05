using C1.WPF.FlexGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using EventLog;
using log4net;

namespace DBMS_V1
{
    /// <summary>
    /// dbmssetting.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class dbmssetting : Page
    {
        private static readonly ILog log = LogManager.GetLogger("Measure");
        MeasureWriteLog Mwlog = new MeasureWriteLog();
        public dbmssetting()
        {
            InitializeComponent();

            //테이블 설정
            inDbmsSetting.ColumnHeaders.Rows[0].Height = 50;
            outDbmsSetting.ColumnHeaders.Rows[0].Height = 50;
            inDbmsSetting.SelectionMode = C1.WPF.FlexGrid.SelectionMode.Row;
            outDbmsSetting.SelectionMode = C1.WPF.FlexGrid.SelectionMode.Row;

            inDbmsSetting.ColumnHeaders[0, 0] = "NO";
            inDbmsSetting.ColumnHeaders[0, 1] = "NAME";
            inDbmsSetting.ColumnHeaders[0, 2] = "COM TYPE";
            inDbmsSetting.ColumnHeaders[0, 3] = "IP ADDRESS";
            inDbmsSetting.ColumnHeaders[0, 4] = "이벤트";
            inDbmsSetting.ColumnHeaders[0, 5] = "이벤트";

            outDbmsSetting.ColumnHeaders[0, 0] = "NO";
            outDbmsSetting.ColumnHeaders[0, 1] = "NAME";
            outDbmsSetting.ColumnHeaders[0, 2] = "COM TYPE";
            outDbmsSetting.ColumnHeaders[0, 3] = "IP ADDRESS";
            outDbmsSetting.ColumnHeaders[0, 4] = "이벤트";
            outDbmsSetting.ColumnHeaders[0, 5] = "이벤트";


            List<Data> samplesetting = new List<Data>();

            samplesetting.Add(new Data() { no = 1, name = "DWSMARTICT_WVP", type = "TCP/IP", ip = "127.0.0.1:3306" });
            inDbmsSetting.ItemsSource = samplesetting;

            List<Data> samplevalue = new List<Data>();
            samplevalue.Add(new Data() { no = 1, name = "COM1", type = "TCP/IP", ip = "192.168.0.1:3306" });

            outDbmsSetting.ItemsSource = samplevalue;

            var col = inDbmsSetting.ColumnHeaders;
            inDbmsSetting.AllowMerging = AllowMerging.All;
            col.Rows[0].AllowMerging = true;

            var col1 = outDbmsSetting.ColumnHeaders;
            outDbmsSetting.AllowMerging = AllowMerging.All;
            col1.Rows[0].AllowMerging = true;
        }

        public class Data
        {
            public int no { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string ip { get; set; }
           


        }
   MySqlDTO mysqlDto = null;
        private void btnDbmsOpen_Click(object sender, RoutedEventArgs e)
        {
            log.Info(Mwlog.DBMSConnectEventLog);
            mysqlDto = new MySqlDTO();
            //mysqlDto.Open();
            bool isRtn = mysqlDto.OpenKeepUp();
            if (isRtn)
            {
                LogList.Items.Add(DateTime.Now + "-DBMS Connected.");
            }
        }

        private void btnPortChaeck_Click(object sender, RoutedEventArgs e)
        {
            log.Info(Mwlog.PortConnectEventLog);
            mysqlDto = new MySqlDTO();
            //mysqlDto.Open();
            bool isRtn = mysqlDto.OpenKeepUp();
            if (isRtn)
            {
                LogList.Items.Add(DateTime.Now + "-Port Connected.");
            }
        }
    }
}

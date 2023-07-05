using DBMS_V1;
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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DWDBMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tbSql1.Text="select mbid as ID from tbl_member tm ;";
        }

        MySqlDTO mysqlDto = null;

        private void btnConnection_Click(object sender, RoutedEventArgs e)
        {
            mysqlDto = new MySqlDTO();
            //mysqlDto.Open();
           bool isRtn= mysqlDto.OpenKeepUp();
            if(isRtn)
            {
                lblStatus1.Content = "DBMS Connected.";
            }
        }

        private void btnDisconnection_Click(object sender, RoutedEventArgs e)
        {
            if (mysqlDto != null)
            {
                bool isRtn = mysqlDto.Close(mysqlDto);
                if (isRtn)
                {
                    lblStatus1.Content = "DBMS Disconnected.";
                }
            }
        }

        private void btnRunSql_Click(object sender, RoutedEventArgs e)
        {
            string strSql = tbSql1.Text;

            if (mysqlDto != null)
            {
                string[] sqlParse = strSql.ToUpper().Split(new string[] {" "}, StringSplitOptions.None);
                switch (sqlParse[0])
                {
                    case "INSERT":
                    case "DELETE":
                    case "UPDATE":
                        mysqlDto.RunSql(sqlParse[0], strSql);
                        break;
                    case "SELECT": 
                       tbSql2.Text= mysqlDto.SelectSql(strSql,"ID"); 
                        break;
                }

            }
        }
    }
}

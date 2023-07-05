using C1.Win.C1List.ListBase;
using DoMeasureMSC.Pages;
using DWDBMS_V1;
using DWLib.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace DoMeasureMSC
{
    public partial class Form2 : Form
    {
        DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
        public static Form2 mInsMain1;
        MySqlDTO msdto = new MySqlDTO();

        int mblevel;


        public Form2(int programId, int mbno, string mbid)
        {
            InitializeComponent();

            this.Hide();

            bool isLoginSuc = CallLoginWindow(ref mbno, ref mbid);
            if (isLoginSuc) LoginAfterLoad(mbno, mbid);
        }

        [DllImport("DwmApi")] //System.Runtime.InteropServices
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }

        private bool CallLoginWindow(ref int mbno, ref string mbid)
        {
            DWLOGIN.Form1 login1 = new DWLOGIN.Form1(CommonClass.ms_programId, mbno, mbid);
            login1.ShowDialog();

            if (CommonClass.ms_loginSuccess == false)
            {
                //this.Close();
                return false;
            }
            else
            {
                mbid = CommonClass.ms_mbid;
                mbno = 1;
                LoginAfterLoad(mbno, mbid);

                return true;
            }
        }

        private void LoginAfterLoad(int mbno, string mbid)
        {
            mInsMain1 = this;

            string dbsql = $"SELECT divlevel FROM tbl_member WHERE tbl_member.id =\"{mbid}\" ";

            Dictionary<string, string> row = msdto.SelectSql2(dbsql, "divlevel")[0];
            if (row != null)
            {
                mblevel = Int32.Parse(row["divlevel"]);
            }
            msdto.Close();

            string latestsalt = "";
            ShowCurTime();
            tbxMemberId.Text = mbid;
            //log.Info(Mwlog.MeasureProgramStartEventLog);

            if (mblevel == 0)
            {
                btnUser.Enabled = false;
                tbxMemberlevel.Text = "[사용자]";
            }
            else
            {
                tbxMemberlevel.Text = "[관리자]";
            }

            CommonClass.mbid = tbxMemberId.Text;
            this.Show();
        }

        private void ShowCurTime()
        {
            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //tbxLiveTime.Text = DateTime.Now.ToString("yyyy-MM-dd  HH:mm:ss");
            tbxLiveTime.Text = DateTime.Now.ToString("yyyy-MM-dd  HH:mm");

        }
        private void SelectPage(Form page)
        {
            if (ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != page)
                {
                    this.ActiveMdiChild.Close();

                }
                //requesterpage = ShowActiveForm(requesterpage, typeof(Requester)) as Requester;
                page.MdiParent = this;
                page.TopLevel = false;
                page.Visible = true;
                page.Dock = DockStyle.Fill;
                page.FormBorderStyle = FormBorderStyle.None;
                this.splitContainer3.Panel2.Controls.Add(page);

            }
            else
            {
                //requesterpage = ShowActiveForm(requesterpage, typeof(Requester)) as Requester;
                page.MdiParent = this;
                page.TopLevel = false;
                page.Visible = true;
                page.Dock = DockStyle.Fill;
                page.FormBorderStyle = FormBorderStyle.None;
                this.splitContainer3.Panel2.Controls.Add(page);
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserManagePage usermanage = new UserManagePage();

            SelectPage(usermanage);
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            MeasureManagePage measuremanage = new MeasureManagePage();

            SelectPage(measuremanage);
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {

        }

        private void btnRequester_Click(object sender, EventArgs e)
        {
            RequesterManagePage requestermanage = new RequesterManagePage();
            SelectPage(requestermanage);
        }

        private void btnRequesterSample_Click(object sender, EventArgs e)
        {
            RequesterSampleManagePage requestersamplemanage = new RequesterSampleManagePage();

            SelectPage(requestersamplemanage);
        }

        private void btnRecipe_Click(object sender, EventArgs e)
        {
            RecipeManagePage recipemanage = new RecipeManagePage();

            SelectPage(recipemanage);
        }

        private void btnHMICtr_Click(object sender, EventArgs e)
        {
            HMIController hmi = new HMIController();

            SelectPage(hmi);
        }

        private void btnPatternManage_Click(object sender, EventArgs e)
        {
            PatternManagePage pattern = new PatternManagePage();

            SelectPage(pattern);
        }

        private void btnPLCManage_Click(object sender, EventArgs e)
        {
            PLCController plc = new PLCController();

            SelectPage(plc);
        }

        private void btnDBMS_Click(object sender, EventArgs e)
        {
            DBMSController dbms = new DBMSController();

            SelectPage(dbms);
        }
    }
}

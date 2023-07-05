using DBMS_V1;
using DoMeasureMSC.Data;
using NetworkLib;
using System;
using System.Collections;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace DoMeasureMSC.Pages
{

    public partial class DBMSController : Form
    {
        // 디자인 영역====================================================================================================================
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBMSController));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.inDbmsSetting = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.outDbmsSetting = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.LogList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.inDbmsSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outDbmsSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "DBMS연동 관리";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.LogList);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Size = new System.Drawing.Size(1640, 896);
            this.splitContainer2.SplitterDistance = 820;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.inDbmsSetting);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.outDbmsSetting);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Size = new System.Drawing.Size(820, 896);
            this.splitContainer3.SplitterDistance = 237;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 0;
            // 
            // inDbmsSetting
            // 
            this.inDbmsSetting.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.inDbmsSetting.AllowEditing = false;
            this.inDbmsSetting.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.inDbmsSetting.BackColor = System.Drawing.Color.White;
            this.inDbmsSetting.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.inDbmsSetting.ColumnInfo = resources.GetString("inDbmsSetting.ColumnInfo");
            this.inDbmsSetting.DataMember = "HMISettingData";
            this.inDbmsSetting.ExtendLastCol = true;
            this.inDbmsSetting.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.inDbmsSetting.ForeColor = System.Drawing.Color.Black;
            this.inDbmsSetting.Location = new System.Drawing.Point(4, 26);
            this.inDbmsSetting.Name = "inDbmsSetting";
            this.inDbmsSetting.Rows.Count = 2;
            this.inDbmsSetting.Rows.DefaultSize = 35;
            this.inDbmsSetting.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inDbmsSetting.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.inDbmsSetting.Size = new System.Drawing.Size(805, 86);
            this.inDbmsSetting.StyleInfo = resources.GetString("inDbmsSetting.StyleInfo");
            this.inDbmsSetting.TabIndex = 8;
            this.inDbmsSetting.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "DBMS 설정(내부)";
            // 
            // outDbmsSetting
            // 
            this.outDbmsSetting.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.outDbmsSetting.AllowEditing = false;
            this.outDbmsSetting.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.outDbmsSetting.BackColor = System.Drawing.Color.White;
            this.outDbmsSetting.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.outDbmsSetting.ColumnInfo = resources.GetString("outDbmsSetting.ColumnInfo");
            this.outDbmsSetting.DataMember = "HMISettingData";
            this.outDbmsSetting.ExtendLastCol = true;
            this.outDbmsSetting.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold);
            this.outDbmsSetting.ForeColor = System.Drawing.Color.Black;
            this.outDbmsSetting.Location = new System.Drawing.Point(4, 24);
            this.outDbmsSetting.Name = "outDbmsSetting";
            this.outDbmsSetting.Rows.Count = 2;
            this.outDbmsSetting.Rows.DefaultSize = 35;
            this.outDbmsSetting.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.outDbmsSetting.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.outDbmsSetting.Size = new System.Drawing.Size(805, 86);
            this.outDbmsSetting.StyleInfo = resources.GetString("outDbmsSetting.StyleInfo");
            this.outDbmsSetting.TabIndex = 9;
            this.outDbmsSetting.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "DBMS 설정(외부)";
            // 
            // LogList
            // 
            this.LogList.BackColor = System.Drawing.Color.LightGray;
            this.LogList.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LogList.FormattingEnabled = true;
            this.LogList.ItemHeight = 19;
            this.LogList.Location = new System.Drawing.Point(7, 26);
            this.LogList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(800, 859);
            this.LogList.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "로그";
            // 
            // DBMSController
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 950);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximumSize = new System.Drawing.Size(1640, 950);
            this.MinimumSize = new System.Drawing.Size(1640, 950);
            this.Name = "DBMSController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBMSController";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inDbmsSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outDbmsSetting)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LogList;
        private System.Windows.Forms.Label label7;
        private C1.Win.C1FlexGrid.C1FlexGrid inDbmsSetting;
        private C1.Win.C1FlexGrid.C1FlexGrid outDbmsSetting;
        //=================================================================================================================================

        public DBMSController()
        {
            InitializeComponent();
            cMysqlDto = new MySqlDTO();
            InitializeComponent_flexgrid();
            mIns = this;
        }

        readonly MySqlDTO cMysqlDto = null;
        public static DBMSController mIns;

        private void InitializeComponent_flexgrid()
        {
            //테이블 설정

            inDbmsSetting.Rows[0].Height = 50;
            outDbmsSetting.Rows[0].Height = 50;
            inDbmsSetting.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            outDbmsSetting.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;

            Call_inDbmsInfo();
            Call_outDbmsInfo();
        }



        private void Call_inDbmsInfo()
        {

            try
            {
                string sql = $@"select (@num:=@num+1) as no, type, name, port, ip, use10, isalive10,isconnect10 from (select @num:=0) as s, tbl_dbms as t where t.category = 'dwmysql'";
                cMysqlDto.OpenKeepUp();

                DataTable ds = cMysqlDto.SelectSqlToDataTable(sql, "inDbmsSetting");
                if (ds != null)
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Rows)
                        {
                            inDbmsSetting[1, 1] = dr["no"].ToString();
                            inDbmsSetting[1, 2] = dr["name"].ToString();
                            inDbmsSetting[1, 3] = dr["type"].ToString();
                            inDbmsSetting[1, 4] = dr["ip"].ToString();
                            inDbmsSetting[1, 5] = dr["port"].ToString();
                        }
                    }

                //event Button
                Button btn1 = new Button()
                {
                    BackColor = System.Drawing.SystemColors.Control,
                    Text = "연결상태확인",
                    Tag = "연결상태확인",
                };

                btn1.Click += CustomButton_indb_Click;

                alBtn.Add(new GridButtonClass(inDbmsSetting, btn1, 1, 6));
                this.inDbmsSetting.Paint += new System.Windows.Forms.PaintEventHandler(this.InDbmsSetting_Paint);
            }
            catch (Exception)
            {
                MessageBox.Show("데이터 로드 실패", "DBMS관리", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            finally
            {
                cMysqlDto.Close();
            }
        }

        private void Call_outDbmsInfo()
        {
            try
            {
                string sql = $@"select (@num:=@num+1) as no, type, name, port, ip, use10, isalive10,isconnect10 from (select @num:=0) as s, tbl_dbms as t where t.category = 'dworacle'";

                cMysqlDto.OpenKeepUp();
                DataTable ds = cMysqlDto.SelectSqlToDataTable(sql, "inDbmsSetting");
                if (ds != null)
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Rows)
                        {
                            outDbmsSetting[1, 1] = dr["no"].ToString(); //no
                            outDbmsSetting[1, 2] = dr["name"].ToString();
                            outDbmsSetting[1, 3] = dr["type"].ToString();
                            outDbmsSetting[1, 4] = dr["ip"].ToString();
                            outDbmsSetting[1, 5] = dr["port"].ToString();
                        }
                    }

                //event Button
                Button btn1 = new Button()
                {
                    BackColor = System.Drawing.SystemColors.Control,
                    Text = "연결상태확인",
                    Tag = "연결상태확인",
                };

                btn1.Click += CustomButton_outdb_Click;

                alBtn2.Add(new GridButtonClass(outDbmsSetting, btn1, 1, 6));
                this.outDbmsSetting.Paint += new System.Windows.Forms.PaintEventHandler(this.OutDbmsSetting_Paint);
            }
            catch (Exception)
            {
                MessageBox.Show("데이터 로드 실패", "DBMS관리", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            finally
            {
                cMysqlDto.Close();
            }
        }



        private void InDbmsSetting_Paint(object sender, PaintEventArgs e)
        {
            foreach (GridButtonClass hosted in alBtn)
                hosted.UpdatePosition();
        }
        private void OutDbmsSetting_Paint(object sender, PaintEventArgs e)
        {
            foreach (GridButtonClass hosted in alBtn2)
                hosted.UpdatePosition();
        }
        private void CustomButton_indb_Click(object sender, EventArgs e)
        {
            string ipa;
            string port;
            if (string.IsNullOrEmpty(inDbmsSetting[1, 4].ToString())) return;
            else
            {
                ipa = inDbmsSetting[1, 4].ToString();
            }
            if (string.IsNullOrEmpty(inDbmsSetting[1, 5].ToString())) return;
            else
            {
                port = inDbmsSetting[1, 5].ToString();
            }

            bool isRtn = IsOpen(ipa: ipa, port: port);
            if (isRtn)
            {
                LogList.Items.Add(DateTime.Now + "-내부 DBMS Connected.");
            }
            else
            {
                LogList.Items.Add(DateTime.Now + "-내부 DBMS Fail.");
            }
        }
        private void CustomButton_outdb_Click(object sender, EventArgs e)
        {
            string ipa;
            string port;
            if (string.IsNullOrEmpty(outDbmsSetting[1, 4].ToString())) return;
            else
                ipa = outDbmsSetting[1, 4].ToString();
            if (string.IsNullOrEmpty(outDbmsSetting[1, 5].ToString())) return;
            else
                port = outDbmsSetting[1, 5].ToString();

            bool isRtn = IsOpen(ipa: ipa, port: port);
            if (isRtn)
            {
                LogList.Items.Add(DateTime.Now + "-외부 DBMS Connected.");
            }
            else
            {
                LogList.Items.Add(DateTime.Now + "-외부 DBMS Fail.");
            }
        }
        public bool IsOpen(string ipa, string port)
        {
            bool isOk;
            // Ping Check
            isOk = IsOpenPing(ipa);
            if (isOk)
            {
                //Port Ping Check
                isOk = IsOpenPortPing(ipa, port);
                if (isOk) { }
                else
                {
                    isOk = false;
                }
            }
            else
            {
                isOk = false;
            }
            return isOk;
        }
        public bool IsOpenPing(string strIpAddress)
        {
            NetworkDTO nwdto = new NetworkDTO();

            int iRtn = nwdto.SendToPing(strIpAddress);
            System.Diagnostics.Trace.WriteLine(iRtn);
            bool isRtn = iRtn == 1;
            return isRtn;
        }
        private bool IsOpenPortPing(string strIpAddress, string strPort)
        {
            NetworkDTO nwdto = new NetworkDTO();

            int iRtn = nwdto.SendToTcping(strIpAddress, strPort, 3000);
            System.Diagnostics.Trace.WriteLine(iRtn);
            bool isRtn = iRtn == 1;
            return isRtn;
        }
        readonly ArrayList alBtn = new ArrayList();
        readonly ArrayList alBtn2 = new ArrayList();
    }

    public class Data
    {
        public int No { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Ip { get; set; }
    }
}


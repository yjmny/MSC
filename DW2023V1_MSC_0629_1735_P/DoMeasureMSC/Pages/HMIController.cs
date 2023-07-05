using DoMeasureMSC.Data;
using DBMS_V1;
using DBMS_V1.Data.MSC;
using DWLib.Data.Generic;
using HMI_TEMI2500;
using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using HmiCtrl = HMI_TEMI2500.HmiCtrl;
using MessageBox = System.Windows.MessageBox;

namespace DoMeasureMSC.Pages
{

    public partial class HMIController : Form
    {
        // 디자인 영역====================================================================================================================
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HMIController));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.HMISetting = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.DataProtocol = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.lstLog1 = new System.Windows.Forms.ListBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.HMISetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataProtocol)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "HMI 컨트롤러 관리";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lstLog1);
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
            this.splitContainer3.Panel1.Controls.Add(this.HMISetting);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.DataProtocol);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Size = new System.Drawing.Size(820, 896);
            this.splitContainer3.SplitterDistance = 236;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 0;
            // 
            // HMISetting
            // 
            this.HMISetting.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.HMISetting.AllowEditing = false;
            this.HMISetting.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Rows;
            this.HMISetting.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.HMISetting.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.HMISetting.AutoGenerateColumns = false;
            this.HMISetting.BackColor = System.Drawing.Color.White;
            this.HMISetting.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.HMISetting.ColumnInfo = resources.GetString("HMISetting.ColumnInfo");
            this.HMISetting.DataMember = "HMISettingData";
            this.HMISetting.ExtendLastCol = true;
            this.HMISetting.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold);
            this.HMISetting.ForeColor = System.Drawing.Color.Black;
            this.HMISetting.Location = new System.Drawing.Point(4, 24);
            this.HMISetting.Name = "HMISetting";
            this.HMISetting.Rows.Count = 2;
            this.HMISetting.Rows.DefaultSize = 35;
            this.HMISetting.Rows.GlyphVisible = false;
            this.HMISetting.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.HMISetting.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.HMISetting.Size = new System.Drawing.Size(805, 86);
            this.HMISetting.StyleInfo = resources.GetString("HMISetting.StyleInfo");
            this.HMISetting.TabIndex = 3;
            this.HMISetting.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "HMI 컨트롤러 설정";
            // 
            // DataProtocol
            // 
            this.DataProtocol.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.DataProtocol.AutoGenerateColumns = false;
            this.DataProtocol.BackColor = System.Drawing.Color.White;
            this.DataProtocol.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.DataProtocol.ColumnInfo = resources.GetString("DataProtocol.ColumnInfo");
            this.DataProtocol.ExtendLastCol = true;
            this.DataProtocol.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DataProtocol.ForeColor = System.Drawing.Color.Black;
            this.DataProtocol.Location = new System.Drawing.Point(4, 24);
            this.DataProtocol.Name = "DataProtocol";
            this.DataProtocol.Rows.Count = 15;
            this.DataProtocol.Rows.DefaultSize = 35;
            this.DataProtocol.Rows.GlyphVisible = false;
            this.DataProtocol.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.DataProtocol.Size = new System.Drawing.Size(805, 623);
            this.DataProtocol.StyleInfo = resources.GetString("DataProtocol.StyleInfo");
            this.DataProtocol.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "데이터 프로토콜";
            // 
            // lstLog1
            // 
            this.lstLog1.BackColor = System.Drawing.Color.LightGray;
            this.lstLog1.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lstLog1.FormattingEnabled = true;
            this.lstLog1.ItemHeight = 19;
            this.lstLog1.Location = new System.Drawing.Point(7, 24);
            this.lstLog1.Name = "lstLog1";
            this.lstLog1.Size = new System.Drawing.Size(800, 859);
            this.lstLog1.TabIndex = 9;
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
            // HMIController
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 950);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1640, 950);
            this.MinimumSize = new System.Drawing.Size(1640, 950);
            this.Name = "HMIController";
            this.Text = "HMIController";
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
            ((System.ComponentModel.ISupportInitialize)(this.HMISetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataProtocol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstLog1;
        private System.Windows.Forms.Label label7;
        private C1.Win.C1FlexGrid.C1FlexGrid HMISetting;
        private C1.Win.C1FlexGrid.C1FlexGrid DataProtocol;
        //================================================================================================================================

        public HMIController()
        {
            InitializeComponent();
            InitializeComponent_HMI();
            mIns = this;
        }

        private readonly MySqlDTO cMysqlDto = new MySqlDTO();
        private static readonly ILog cLog = LogManager.GetLogger("Measure");
        public static HMIController mIns;
        readonly ArrayList m_alBtn = new ArrayList();
        readonly ArrayList m_alBtn2 = new ArrayList();

        private void InitializeComponent_HMI()
        {
            //header 넓이
            DataProtocol.Rows[0].Height = 50;
            HMISetting.Rows[0].Height = 50;
            HMISetting.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            DataProtocol.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;

            CallHMIInfo();
            CallDataProtocol();

            mIns = this;


            if (HmiCtrl.mIns == null)
            {
#pragma warning disable IDE0059
                var hmiCtrl = new HMI_TEMI2500.HmiCtrl("Call HMI");
#pragma warning restore IDE0059
            }
        }
        ArrayList alBtn2 = new ArrayList();
        private void CallDataProtocol()
        {
#pragma warning disable IDE0028
            List<DataWinform> samplevalue = new List<DataWinform>();

            samplevalue.Add(new DataWinform() { No = 1, Name = "현재 온도 값 확인", Send = "D0001", Recv = "", InputData = "" });
            samplevalue.Add(new DataWinform() { No = 2, Name = "현재 습도 값 확인", Send = "D0005", Recv = "", InputData = "" });
            samplevalue.Add(new DataWinform() { No = 3, Name = "설정 온도 값 확인", Send = "D0002", Recv = "", InputData = "" });
            samplevalue.Add(new DataWinform() { No = 4, Name = "설정 습도 값 확인", Send = "D0006", Recv = "", InputData = "" });
            samplevalue.Add(new DataWinform() { No = 5, Name = "온도 출력 값 확인", Send = "D0007", Recv = "", InputData = "" });
            samplevalue.Add(new DataWinform() { No = 6, Name = "습도 출력 값 확인", Send = "D0008", Recv = "", InputData = "" });
            samplevalue.Add(new DataWinform() { No = 7, Name = "운전시간 시 확인", Send = "D0024", Recv = "", InputData = "" });
            samplevalue.Add(new DataWinform() { No = 8, Name = "운전시간 분 확인", Send = "D0025", Recv = "", InputData = "" });
            samplevalue.Add(new DataWinform() { No = 9, Name = "운전시간 초 확인", Send = "D0026", Recv = "", InputData = "" });
            samplevalue.Add(new DataWinform() { No = 10, Name = "운전시간 시분초 확인", Send = "D0024", Recv = "", InputData = "" });
            samplevalue.Add(new DataWinform() { No = 11, Name = "운전 시작 확인", Send = "D0101_1", Recv = "", InputData = "" });
            samplevalue.Add(new DataWinform() { No = 12, Name = "운전 중지 확인", Send = "D0101_4", Recv = "", InputData = "" });
            samplevalue.Add(new DataWinform() { No = 13, Name = "설정 온도 W", Send = "D0102", Recv = "", InputData = "" });
            samplevalue.Add(new DataWinform() { No = 14, Name = "설정 습도 W", Send = "D0106", Recv = "", InputData = "" });
#pragma warning restore IDE0028

            String[] arrayB = new String[samplevalue.Count];
            for (int i = 0; i < samplevalue.Count; i++)
            {
                DataProtocol[i + 1, 1] = samplevalue[i].No.ToString();
                DataProtocol[i + 1, 2] = samplevalue[i].Name.ToString();
                DataProtocol[i + 1, 3] = samplevalue[i].Send.ToString();
                DataProtocol[i + 1, 4] = samplevalue[i].Recv.ToString();
                DataProtocol[i + 1, 5] = samplevalue[i].InputData.ToString();
            }

            //event Button

            Button[] btn = new Button[samplevalue.Count];

            for (int i = 0; i < btn.Length; i++)
            {
                btn[i] = new Button();
                btn[i].BackColor = System.Drawing.SystemColors.Control;
                btn[i].Text = "데이터 체크";
                btn[i].Tag = "NO" + (i + 1).ToString() + " 데이터 체크";
                btn[i].Click += DataProtocolCheck_Click;

                alBtn2.Add(new GridButtonClass(DataProtocol, btn[i], i + 1, 6));
            }
            this.DataProtocol.Paint += new System.Windows.Forms.PaintEventHandler(this._flex_dataProtocol_Paint);


            //Button[] btn = new Button[samplevalue.Count];

            //for (int i = 0; i < btn.Length; i++)
            //{
            //    //btn[i] = new Button();
            //    //btn[i].BackColor = System.Drawing.SystemColors.Control;
            //    //btn[i].Text = "데이터 체크";
            //    //btn[i].Tag = "NO" + (i + 1).ToString() + " 데이터 체크";
            //    //btn[i].Click += DataProtocolCheck_Click;

            //    btn[i] = new Button()
            //    {
            //        BackColor = System.Drawing.SystemColors.Control,
            //        Text = "데이터 체크",
            //        Tag = "NO" + (i + 1).ToString() + " 데이터 체크",
            //    };
            //    btn[i].Click += DataProtocolCheck_Click;

            //    m_alBtn2.Add(new GridButtonClass(DataProtocol, btn[i], i + 1, 6));
            //}
            ////this.DataProtocol.Paint += new System.Windows.Forms.PaintEventHandler(this.FlexGrid_dataProtocol_Paint);
        }
        private void _flex_dataProtocol_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            foreach (GridButtonClass hosted in alBtn2)
                hosted.UpdatePosition();
        }
        private void DataProtocolCheck_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            bool isDebug = false;
            if (isDebug)
            {
                if (MessageBox.Show(btn.Text.ToString() + "하시겠습니까?", btn.Text.ToString(), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) { return; }
                MessageBox.Show(btn.Tag.ToString());
            }
            BtnCmdCheck1_Click((object)btn, e);
        }

        private void BtnIpOpenCheck_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (MessageBox.Show(btn.Text.ToString() + "하시겠습니까?", btn.Text.ToString(), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) { return; }
            Tbl_tcpipcomm tbl_tcpip1 = new Tbl_tcpipcomm();

            bool isFlexGrid_use = true;
            if (isFlexGrid_use)
            {
                tbl_tcpip1.name = HMISetting[1, 2] == null ? "" : HMISetting[1, 2].ToString();
                tbl_tcpip1.ipaddress = HMISetting[1, 4] == null ? "" : HMISetting[1, 4].ToString();
                tbl_tcpip1.port = HMISetting[1, 5] == null ? "" : HMISetting[1, 5].ToString();
            }
            else
            {
                tbl_tcpip1.name = HMISetting.Rows[1]["name"] == null ? "" : HMISetting.Rows[1]["name"].ToString();
                tbl_tcpip1.ipaddress = HMISetting.Rows[1]["ipaddress"] == null ? "" : HMISetting.Rows[1]["ipaddress"].ToString();
                tbl_tcpip1.port = HMISetting.Rows[1]["port"] == null ? "" : HMISetting.Rows[1]["port"].ToString();
            }


            TEMI2500.IP = tbl_tcpip1.ipaddress;
            TEMI2500.PORT_FIX = tbl_tcpip1.port;

            string logStr = "HMI컨트롤러 연결 요청 시작."; ListLogAdd(logStr);
            if (HmiCtrl.mIns == null)
            {
                logStr = "HMI컨트롤러 인스턴스가 호출되지 않았습니다."; ListLogAdd(logStr);
                logStr = "HMI컨트롤러 연결 요청 취소."; ListLogAdd(logStr);
                return;
            }
            bool isBool = HmiCtrl.mIns.IsOpen(tbl_tcpip1.ipaddress, tbl_tcpip1.port);
            logStr = "HMI컨트롤러 연결 요청 완료."; ListLogAdd(logStr);

            if (isBool)
            {
                logStr = "HMI컨트롤러 통신연결 되어 있습니다.";
                ListLogAdd(logStr);
            }
            else
            {
                logStr = "HMI컨트롤러 통신연결이 되지 않았습니다.";
                ListLogAdd(logStr);
            }
        }


        public void CallHMIInfo()
        {
            try
            {
                string sql = $@"select (@num:=@num+1) as no, type, name, port, ipaddress, use10, isalive10,isconnect10 from (select @num:=0) as s, tbl_tcpcomm as t where t.category = 'hmi'";
                cMysqlDto.OpenKeepUp();
                DataTable ds = cMysqlDto.SelectSqlToDataTable(sql, "HMISettingData");
                if (ds != null)
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Rows)
                        {
                            HMISetting[1, 1] = dr["no"].ToString(); //no
                            HMISetting[1, 2] = dr["name"].ToString();
                            HMISetting[1, 3] = dr["type"].ToString();
                            HMISetting[1, 4] = dr["ipaddress"].ToString();
                            HMISetting[1, 5] = dr["port"].ToString();
                        }
                    }

                //event Button
                Button btn1 = new Button()
                {
                    BackColor = System.Drawing.SystemColors.Control,
                    Text = "연결상태확인",
                    Tag = "연결상태확인",
                };
                btn1.Click += CustomButton_Click;

                m_alBtn.Add(new GridButtonClass(HMISetting, btn1, 1, 6));
                this.HMISetting.Paint += new System.Windows.Forms.PaintEventHandler(this.FlexGrid_Paint);
            }
            catch (Exception)
            {
                MessageBox.Show("데이터 로드 실패", "HMI컨트롤러관리", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            finally
            {
                cMysqlDto.Close();
            }
        }



        private void CustomButton_Click(object sender, EventArgs e)
        {
            BtnIpOpenCheck_Click(sender, e);
        }

        private void FlexGrid_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            foreach (GridButtonClass hosted in m_alBtn)
                hosted.UpdatePosition();
        }

        private void FlexGriddataProtocol_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            foreach (GridButtonClass hosted in m_alBtn2)
                hosted.UpdatePosition();
        }

        private void BtnCmdCheck1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string strTag = btn.Tag.ToString();
            if (btn == null) return;

            string[] strNo = strTag.Split(' ');
            if (strNo.Length < 0) return;

            string sNo = strNo[0].Substring(2);
            string name = DataProtocol[Convert.ToInt32(sNo), 2].ToString();

            string msg = "[" + sNo + "][" + name + "]";

            if (MessageBox.Show(msg + btn.Text.ToString() + " 하시겠습니까?", btn.Text.ToString(), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                return;
            }


            Tbl_tcpipcomm tbl_tcpip1 = new Tbl_tcpipcomm();

            bool isFlexGrid_use = true;
            if (isFlexGrid_use)
            {
                tbl_tcpip1.name = HMISetting[1, 2] == null ? "" : HMISetting[1, 2].ToString();
                tbl_tcpip1.ipaddress = HMISetting[1, 4] == null ? "" : HMISetting[1, 4].ToString();
                tbl_tcpip1.port = HMISetting[1, 5] == null ? "" : HMISetting[1, 5].ToString();
            }
            else
            {
                tbl_tcpip1.name = HMISetting.Rows[1]["name"] == null ? "" : HMISetting.Rows[1]["name"].ToString();
                tbl_tcpip1.ipaddress = HMISetting.Rows[1]["ipaddress"] == null ? "" : HMISetting.Rows[1]["ipaddress"].ToString();
                tbl_tcpip1.port = HMISetting.Rows[1]["port"] == null ? "" : HMISetting.Rows[1]["port"].ToString();
            }


            TEMI2500.IP = tbl_tcpip1.ipaddress;
            TEMI2500.PORT_FIX = tbl_tcpip1.port;


            int cmdIndex = Convert.ToInt32(sNo);
            tbl_tcpip1.commmandName = DataProtocol[Convert.ToInt32(sNo), 3].ToString();

            string addrD = tbl_tcpip1.commmandName.ToUpper();
            string sCheck = "D";
            bool isbool = addrD.Contains(sCheck);
            if (isbool)
            {
                tbl_tcpip1.dregaddr = addrD.Substring(1);
            }
            else
            {
                tbl_tcpip1.dregaddr = addrD;
            }

            int inputDataIndex = 5;
            tbl_tcpip1.inputData = DataProtocol[cmdIndex, inputDataIndex] == null ? "" : DataProtocol[cmdIndex, inputDataIndex].ToString();

            if (HmiCtrl.mIns.IsOpen() == false)
            {
                MessageBox.Show("통신 연결 되어 있지 않습니다.", btn.Text.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            int iNo = Convert.ToInt32(sNo);
            string sRtn = "";
            string logStr;
            switch (iNo)
            {
                case 1:
                    sRtn = GetD0001();

                    break;
                case 2:
                    logStr = "HMI컨트롤러 현재 습도 값 요청 시작.";
                    ListLogAdd(logStr);
                    sRtn = HmiCtrl.mIns.GetD0005();
                    logStr = "HMI컨트롤러 현재 습도 값 요청 완료.";
                    ListLogAdd(logStr);
                    break;
                case 3:
                    logStr = "HMI컨트롤러 설정온도 값 요청 시작.";
                    ListLogAdd(logStr);
                    sRtn = HmiCtrl.mIns.GetD0002();
                    logStr = "HMI컨트롤러 설정온도 값 요청 완료.";
                    ListLogAdd(logStr);
                    break;
                case 4:
                    logStr = "HMI컨트롤러 설정습도 값 요청 시작.";
                    ListLogAdd(logStr);
                    sRtn = HmiCtrl.mIns.GetD0006();
                    logStr = "HMI컨트롤러 설정습도 값 요청 완료.";
                    ListLogAdd(logStr);
                    break;
                case 5:
                    logStr = "HMI컨트롤러 온도 출력값 요청 시작.";
                    ListLogAdd(logStr);
                    sRtn = HmiCtrl.mIns.GetD0007();
                    logStr = "HMI컨트롤러 온도 출력값 요청 완료.";
                    ListLogAdd(logStr);
                    break;
                case 6:
                    logStr = "HMI컨트롤러 습도 출력값 요청 시작.";
                    ListLogAdd(logStr);
                    sRtn = HmiCtrl.mIns.GetD0008();
                    logStr = "HMI컨트롤러 습도 출력값 요청 완료.";
                    ListLogAdd(logStr);
                    break;
                case 7:
                    logStr = "HMI컨트롤러 운전시간 시 요청 시작.";
                    ListLogAdd(logStr);
                    sRtn = HmiCtrl.mIns.GetD0024();
                    logStr = "HMI컨트롤러 운전시간 시 요청 완료.";
                    ListLogAdd(logStr);
                    break;
                case 8:
                    logStr = "HMI컨트롤러 운전시간 분 요청 시작.";
                    ListLogAdd(logStr);
                    sRtn = HmiCtrl.mIns.GetD0025();
                    logStr = "HMI컨트롤러 운전시간 분 요청 완료.";
                    ListLogAdd(logStr);
                    break;
                case 9:
                    logStr = "HMI컨트롤러 운전시간 초 요청 시작.";
                    ListLogAdd(logStr);
                    sRtn = HmiCtrl.mIns.GetD0026();
                    logStr = "HMI컨트롤러 운전시간 초 요청 완료.";
                    ListLogAdd(logStr);
                    break;
                case 10:
                    logStr = "HMI컨트롤러 운전시간 시분초 요청 시작.";
                    ListLogAdd(logStr);
                    sRtn = HmiCtrl.mIns.GetD0024To0026();
                    logStr = "HMI컨트롤러 운전시간 시분초 요청 완료.";
                    ListLogAdd(logStr);
                    break;
                case 11: SetD0101_1(); break;
                case 12: SetD0101_4(); break;
                case 13:
                    if (string.IsNullOrEmpty(tbl_tcpip1.inputData))
                    {
                        if (MessageBox.Show(msg + "[설정 입력값]이 없습니다.", btn.Text.ToString(), MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                        { return; }
                    }
                    string val1 = tbl_tcpip1.inputData;
                    SetD0102(val1);


                    break;
                case 14:
                    if (string.IsNullOrEmpty(tbl_tcpip1.inputData))
                    {
                        if (MessageBox.Show(msg + "[설정 입력값]이 없습니다.", btn.Text.ToString(), MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                        { return; }
                    }
                    string val2 = tbl_tcpip1.inputData;
                    SetD0106(val2);

                    break;
                case 15:
                    if (string.Compare(tbl_tcpip1.dregaddr, "ANDOM") == 0)
                    {
                        if (MessageBox.Show(msg + "[주소 값]이 없습니다.", btn.Text.ToString(), MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                        { return; }
                    }
                    if (string.IsNullOrEmpty(tbl_tcpip1.dregaddr))
                    {
                        if (MessageBox.Show(msg + "[주소 값]이 없습니다.", btn.Text.ToString(), MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                        { return; }
                    }
                    if (string.IsNullOrEmpty(tbl_tcpip1.inputData))
                    {
                        if (MessageBox.Show(msg + "[설정 입력값]이 없습니다.", btn.Text.ToString(), MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                        { return; }
                    }
                    string addr = tbl_tcpip1.dregaddr;
                    string param1 = tbl_tcpip1.inputData;

                    string param2 = "1";
                    switch (addr)
                    {
                        case "0101": param2 = "0"; break;
                    }

                    logStr = "HMI컨트롤러 주소-값 변경 요청 시작.";
                    ListLogAdd(logStr);
                    sRtn = HmiCtrl.mIns.SetDmap(addr, param1, param2);
                    logStr = "HMI컨트롤러 주소-값 변경 요청 완료.";
                    ListLogAdd(logStr);

                    break;
            }

            DataProtocol[iNo, 4] = sRtn;
            ListLogAdd("recv value : " + sRtn);
        }

        public string GetD0001()
        {
            string logStr = "HMI컨트롤러 현재온도 값 요청 시작.";
            ListLogAdd(logStr);
            string sRtn = HmiCtrl.mIns.GetD0001();
            logStr = "HMI컨트롤러 현재온도 값 요청 완료.";
            ListLogAdd(logStr);
            return sRtn;
        }
        public string GetD0010()
        {
            string sRtn = "";
            try
            {
                string logStr = "HMI컨트롤러 운전상태 값 요청 시작.";
                ListLogAdd(logStr);
                sRtn = HmiCtrl.mIns.GetD0010();
                logStr = "HMI컨트롤러 운전상태 값 요청 완료.";
                ListLogAdd(logStr);
            }
            catch (Exception exc)
            {
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }

            return sRtn;
        }
        public void ListLogAdd(string str)
        {
            if (lstLog1.Items.Count > 100)//50 이상이면 지울지 여부 확인
                lstLog1.Items.Clear();
            str = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ") + str;
            lstLog1.Items.Add(str);
        }

        private void BnCtrilConn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (MessageBox.Show(btn.Text.ToString() + "하시겠습니까?", btn.Text.ToString(), MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No) { return; }

            Tbl_tcpipcomm tbl_tcpip1 = new Tbl_tcpipcomm()
            {
                name = HMISetting[0, 1] == null ? "" : HMISetting[0, 1].ToString(),
                ipaddress = HMISetting[0, 3] == null ? "" : HMISetting[0, 3].ToString(),
                port = HMISetting[0, 4] == null ? "" : HMISetting[0, 4].ToString()
            };

            TEMI2500.IP = tbl_tcpip1.ipaddress;
            TEMI2500.PORT_FIX = tbl_tcpip1.port;

            string logStr = "HMI컨트롤러 연결 요청 시작."; ListLogAdd(logStr);
            bool isBool = HmiCtrl.mIns.IsOpen(tbl_tcpip1.ipaddress, tbl_tcpip1.port);
            logStr = "HMI컨트롤러 연결 요청 완료."; ListLogAdd(logStr);

            if (isBool)
            {
                logStr = "HMI컨트롤러 통신연결 되어 있습니다.";
                ListLogAdd(logStr);
            }
            else
            {
                logStr = "HMI컨트롤러 통신연결이 되지 않았습니다.";
                ListLogAdd(logStr);
            }

        }

        public string[] GetListStringData()
        {
            // frmMain InsfrmPlcMain
            //AI 1~12
            //AO 1~4
            //DI 1~4
            //DO 2
            string[] strRtn = null; ;
            try
            {
                string strGetData = HmiCtrl.mIns.GetD1D2D5D6();
                if (string.IsNullOrEmpty(strGetData))
                {
                    string strDebugValue = "12345";
                    strRtn = new string[4];
                    strRtn[0] = strDebugValue;
                    strRtn[2] = strDebugValue;
                    strRtn[1] = strDebugValue;
                    strRtn[3] = strDebugValue;
                }
                else { strRtn = strGetData.Split(','); }

                if (strRtn == null)
                {
                    string strDebugValue = "99999";
                    strRtn = new string[4];
                    strRtn[0] = strDebugValue;
                    strRtn[2] = strDebugValue;
                    strRtn[1] = strDebugValue;
                    strRtn[3] = strDebugValue;
                }

            }
            catch (Exception exc)
            {
                System.Windows.MessageBox.Show(exc.ToString(), "GetListStringData");
                System.Diagnostics.Debug.WriteLine(exc);
                cLog.Error("[DoMeasureMSC.Pages]\r\n " + exc.ToString());
            }
            finally
            {

            }
            return strRtn;

        }

        public string GetD1D2D5D6()
        {
            string logStr = "HMI컨트롤러 현재(온도,습도), 설정(온도,습도) 요청 시작."; ListLogAdd(logStr);
            string strRtn = HmiCtrl.mIns.GetD1D2D5D6();
            logStr = "HMI컨트롤러 현재(온도,습도), 설정(온도,습도) 요청 완료."; ListLogAdd(logStr);

            return strRtn;
        }

        public string GetD1D2D5D6D24D25D26()
        {
            string logStr = "HMI컨트롤러 현재(온도,습도), 설정(온도,습도), 운전중 시분초 요청 시작."; ListLogAdd(logStr);
            string strRtn = HmiCtrl.mIns.GetD1D2D5D6D24D25D26();
            logStr = "HMI컨트롤러 현재(온도,습도), 설정(온도,습도), 운전중 시분초 요청 완료."; ListLogAdd(logStr);

            return strRtn;
        }



        public string SetD0101_1()
        {
            string logStr = "HMI컨트롤러 운전시작 요청 시작."; ListLogAdd(logStr);
            string strRtn = HmiCtrl.mIns.SetD0101_1();
            logStr = "HMI컨트롤러 운전시작 요청 완료."; ListLogAdd(logStr);

            return strRtn;
        }

        public string SetD0101_4()
        {

            string strRtn = "";
            try
            {

                string logStr = "HMI컨트롤러 운전중지 요청 시작."; ListLogAdd(logStr);
                strRtn = HmiCtrl.mIns.SetD0101_4();
                logStr = "HMI컨트롤러 운전중지 요청 완료."; ListLogAdd(logStr);
            }
            catch (Exception exc)
            {
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }

            return strRtn;
        }

        public string SetD0102(string value)
        {
            string logStr = "HMI컨트롤러 정치모드 설정온도 변경 요청 시작."; ListLogAdd(logStr);
            string strRtn = HmiCtrl.mIns.SetD0102(value);
            logStr = "HMI컨트롤러 정치모드 설정온도 변경 요청 완료."; ListLogAdd(logStr);
            return strRtn;
        }
        public string SetD0106(string val2)
        {

            string logStr = "HMI컨트롤러 정치모드 설정습도 변경 요청 시작."; ListLogAdd(logStr);
            string strRtn = HmiCtrl.mIns.SetD0106(val2);
            logStr = "HMI컨트롤러 정치모드 설정습도 변경 요청 완료."; ListLogAdd(logStr);
            return strRtn;
        }

        internal bool SetHmiModeSetting(int v)
        {
            if (Measure.IsHmiUse)
            {
                if (HmiCtrl.mIns == null) { return false; }
                switch (v)
                {
                    case 0: HmiCtrl.mIns.SetPatternMode(); break;
                    case 1: HmiCtrl.mIns.SetFixMode(); break;
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        internal bool SetHmiPatternNo(int iPtnNo)
        {
            if (HmiCtrl.mIns == null) { return false; }
            HmiCtrl.mIns.SetHmiPatternNo(iPtnNo);
            return true;
        }

        public class DataWinform
        {
            public int No { get; set; }
            public string Name { get; set; }
            public string Recv { get; set; }
            public string Send { get; set; }
            public string InputData { get; set; }
            public string Event1 { get; set; }
        }

    }
}


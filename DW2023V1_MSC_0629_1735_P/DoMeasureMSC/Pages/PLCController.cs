using DBMS_V1;
using DBMS_V1.Data.MSC;
using DoMeasureMSC.Data;
using DWLib.Data.Generic;
using log4net;
using NetworkLib;
using PlcLSE_V1;
using System;
using System.Collections;
using System.Data;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;



namespace DoMeasureMSC.Pages
{
    public partial class PLCController : Form
    {
        // 디자인 영역====================================================================================================================
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PLCController));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.LogList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fgPlcSetting = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label7 = new System.Windows.Forms.Label();
            this.plcpage = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgPlcSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.LogList);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.fgPlcSetting);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.plcpage);
            this.splitContainer1.Size = new System.Drawing.Size(1640, 950);
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLC 컨트롤러 관리";
            // 
            // LogList
            // 
            this.LogList.BackColor = System.Drawing.Color.LightGray;
            this.LogList.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LogList.FormattingEnabled = true;
            this.LogList.ItemHeight = 19;
            this.LogList.Location = new System.Drawing.Point(840, 22);
            this.LogList.Margin = new System.Windows.Forms.Padding(0);
            this.LogList.Name = "LogList";
            this.LogList.Size = new System.Drawing.Size(791, 859);
            this.LogList.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "PLC 컨트롤러 설정";
            // 
            // fgPlcSetting
            // 
            this.fgPlcSetting.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.fgPlcSetting.AllowEditing = false;
            this.fgPlcSetting.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fgPlcSetting.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fgPlcSetting.AutoGenerateColumns = false;
            this.fgPlcSetting.BackColor = System.Drawing.Color.White;
            this.fgPlcSetting.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgPlcSetting.ColumnInfo = resources.GetString("fgPlcSetting.ColumnInfo");
            this.fgPlcSetting.DataMember = "HMISettingData";
            this.fgPlcSetting.ExtendLastCol = true;
            this.fgPlcSetting.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.fgPlcSetting.ForeColor = System.Drawing.Color.Black;
            this.fgPlcSetting.Location = new System.Drawing.Point(3, 22);
            this.fgPlcSetting.Name = "fgPlcSetting";
            this.fgPlcSetting.Rows.Count = 2;
            this.fgPlcSetting.Rows.DefaultSize = 35;
            this.fgPlcSetting.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fgPlcSetting.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgPlcSetting.Size = new System.Drawing.Size(805, 86);
            this.fgPlcSetting.StyleInfo = resources.GetString("fgPlcSetting.StyleInfo");
            this.fgPlcSetting.TabIndex = 16;
            this.fgPlcSetting.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.System;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(836, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "로그";
            // 
            // plcpage
            // 
            this.plcpage.BackColor = System.Drawing.Color.Gainsboro;
            this.plcpage.Location = new System.Drawing.Point(10, 172);
            this.plcpage.Name = "plcpage";
            this.plcpage.Size = new System.Drawing.Size(798, 709);
            this.plcpage.TabIndex = 15;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Size = new System.Drawing.Size(1640, 236);
            this.splitContainer3.SplitterDistance = 815;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 0;
            // 
            // PLCController
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1640, 950);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1640, 950);
            this.MinimumSize = new System.Drawing.Size(1640, 950);
            this.Name = "PLCController";
            this.Text = "PLCController";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgPlcSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;

        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LogList;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1FlexGrid.C1FlexGrid fgPlcSetting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel plcpage;
        //================================================================================================================================


        public PLCController()
        {
            InitializeComponent();
            mIns = this;
            cMysqlDto = new MySqlDTO();


            InitializeComponent_flexgrid();
            Button1_Click(null, null);//hmi ctrl lib - call
        }

        private static readonly ILog cLog = LogManager.GetLogger("Measure");
        readonly MySqlDTO cMysqlDto = null;
        public static PLCController mIns;
        readonly ArrayList m_alBtn = new ArrayList();
        Tbl_plc_calibration cTbl_calib = new Tbl_plc_calibration();

        private void InitializeComponent_flexgrid()
        {
            fgPlcSetting.Rows[0].Height = 50;
            fgPlcSetting.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;

            CallPlcInfo();

        }

        private void CallPlcInfo()
        {

            try
            {
                string sql = $@"select (@num:=@num+1) as no, type, name, port, ipaddress, use10, isalive10,isconnect10 from (select @num:=0) as s, tbl_tcpcomm as t where t.category = 'plc'";

                cMysqlDto.OpenKeepUp();
                DataTable ds = cMysqlDto.SelectSqlToDataTable(sql, "fgPlcSetting");
                if (ds != null)
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow dr in ds.Rows)
                        {
                            fgPlcSetting[1, 1] = dr["no"].ToString(); //no
                            fgPlcSetting[1, 2] = dr["name"].ToString();
                            fgPlcSetting[1, 3] = dr["type"].ToString();
                            fgPlcSetting[1, 4] = dr["ipaddress"].ToString();
                            fgPlcSetting[1, 5] = dr["port"].ToString();
                        }
                    }

                //event Button
                Button btn1 = new Button()
                {
                    BackColor = System.Drawing.SystemColors.Control,
                    Text = "연결상태확인",
                    Tag = "연결상태확인"
                };

                btn1.Click += CustomButton_Click;

                m_alBtn.Add(new GridButtonClass(fgPlcSetting, btn1, 1, 6));
                this.fgPlcSetting.Paint += new System.Windows.Forms.PaintEventHandler(this.FgPlcSetting_flex_Paint);
            }
            catch (Exception)
            {
                MessageBox.Show("데이터 로드 실패", "PLC컨트롤러관리", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            finally
            {
                cMysqlDto.Close();
            }
        }

        private void FgPlcSetting_flex_Paint(object sender, PaintEventArgs e)
        {
            foreach (GridButtonClass hosted in m_alBtn)
                hosted.UpdatePosition();
        }

        private void CustomButton_Click(object sender, EventArgs e)
        {
            string ipa;
            string port;
            if (string.IsNullOrEmpty(fgPlcSetting[1, 4].ToString())) return;
            else
                ipa = fgPlcSetting[1, 4].ToString();
            if (string.IsNullOrEmpty(fgPlcSetting[1, 5].ToString())) return;
            else
                port = fgPlcSetting[1, 5].ToString();

            bool isRtn = IsOpen(ipa: ipa, port: port);
            if (isRtn)
            {
                LogList.Items.Add(DateTime.Now + "-PLC Connected.");
            }
            else
            {
                LogList.Items.Add(DateTime.Now + "-PLC Fail.");
            }
        }

        private void SelectPage(Form page)
        {
            if (ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != page)
                {
                    this.plcpage.Controls.Clear();

                }
                page.Text = "";
                page.ControlBox = false;
                page.TopLevel = false;
                page.Show();
                this.plcpage.Controls.Add(page);

            }
            else
            {
                page.Text = "";
                page.ControlBox = false;
                page.TopLevel = false;
                page.Show();
                this.plcpage.Controls.Add(page);
            }
        }






        public bool IsOpen(string ipa, string port)
        {
            // Ping Check
            bool isOk = IsOpenPing(ipa);
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


        //frmPlcTest InsfrmPlcTest;


        private void Button1_Click(object sender, EventArgs e)
        {
            if (Measure.mbid.Equals("ID0001"))
            {
                FrmMain frmMain = new FrmMain();
                SelectPage(frmMain);

            }
            else
            {
                plcpage.Visible = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //frmDataIO frmDataIO = new frmDataIO();
            //SelectPage(frmDataIO);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //frmPlcSensor frmPLCSensor = new frmPlcSensor();
            //SelectPage(frmPLCSensor);
        }

        public string[] GetListStringData()
        {
            // frmMain InsfrmPlcMain
            //AI 1~12
            //AO 1~4
            //DI 1~4
            //DO 2
            string[] strRtn = null;
            try
            {

                strRtn = FrmDataIO.mIns.ReadPlcAIO_DIO();
                if (strRtn != null)
                {
                    for (int i = 0; i < strRtn.Length; i++)
                    {
                        //sensor -- 1~12//sensor --- 4~12
                        if (i < 12)
                        {
                            Double.TryParse(strRtn[i], out double dTempY);
                            double dValue = GetSignalValues(channelNo: (i + 1), dTempY, 1);
                            strRtn[i] = dValue.ToString();
                        }
                    }
                }
                else
                {
                    strRtn = new string[20];
                    for (int i = 0; i < strRtn.Length; i++)
                    { strRtn[i] = "99999"; }
                }
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc.ToString());
                cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
            }
            finally
            {

            }
            return strRtn;

        }

        private bool CheckMinMax(double dMin, double dMax, double target)
        {
            if (dMin <= target && target <= dMax)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// 1안  dTempY가 signal (0~16000) : X, Y (-10, 0),(10, 16000)
        /// 2안 dTempY 가 voltage (-10~10) : X, Y (0,-10), (16000, 10)
        /// </summary>
        /// <param name="channelNo"></param>
        /// <param name="dTempY"></param>
        /// <param name="iCalcutType"></param>
        /// <returns></returns>
        public double GetSignalValues(int channelNo, double dTempY, int iCalcutType)
        {
            double dRtnValue = 0;
            double dx1 = 0, dx2 = 0, dy1 = 0, dy2 = 0;
            //1안  dTempY가 signal (0~16000)
            //(-10, 0),(10, 16000)
            if (iCalcutType == 1)
            {
                double target = dTempY;

                try
                {
                    if (channelNo == 1)
                    {
                        double dy11 = Convert.ToDouble(cTbl_calib.ch1_plc_min1);
                        double dy12 = Convert.ToDouble(cTbl_calib.ch1_plc_max1);
                        double dy21 = Convert.ToDouble(cTbl_calib.ch1_plc_min2);
                        double dy22 = Convert.ToDouble(cTbl_calib.ch1_plc_max2);
                        double dy31 = Convert.ToDouble(cTbl_calib.ch1_plc_min3);
                        double dy32 = Convert.ToDouble(cTbl_calib.ch1_plc_max3);
                        double dy41 = Convert.ToDouble(cTbl_calib.ch1_plc_min4);
                        double dy42 = Convert.ToDouble(cTbl_calib.ch1_plc_max4);
                        double dy51 = Convert.ToDouble(cTbl_calib.ch1_plc_min5);
                        double dy52 = Convert.ToDouble(cTbl_calib.ch1_plc_max5);

                        double dx11 = Convert.ToDouble(cTbl_calib.ch1_pc_min1);
                        double dx12 = Convert.ToDouble(cTbl_calib.ch1_pc_max1);
                        double dx21 = Convert.ToDouble(cTbl_calib.ch1_pc_min2);
                        double dx22 = Convert.ToDouble(cTbl_calib.ch1_pc_max2);
                        double dx31 = Convert.ToDouble(cTbl_calib.ch1_pc_min3);
                        double dx32 = Convert.ToDouble(cTbl_calib.ch1_pc_max3);
                        double dx41 = Convert.ToDouble(cTbl_calib.ch1_pc_min4);
                        double dx42 = Convert.ToDouble(cTbl_calib.ch1_pc_max4);
                        double dx51 = Convert.ToDouble(cTbl_calib.ch1_pc_min5);
                        double dx52 = Convert.ToDouble(cTbl_calib.ch1_pc_max5);

                        int idx = 0;
                        if (CheckMinMax(dy11, dy12, target) == true) { idx = 1; }
                        else if (CheckMinMax(dy22, dy22, target) == true) { idx = 2; }
                        else if (CheckMinMax(dy31, dy32, target) == true) { idx = 3; }
                        else if (CheckMinMax(dy41, dy42, target) == true) { idx = 4; }
                        else if (CheckMinMax(dy51, dy52, target) == true) { idx = 5; }

                        switch (idx)
                        {
                            case 1: dy1 = dy11; dy2 = dy12; dx1 = dx11; dx2 = dx12; break;
                            case 2: dy1 = dy21; dy2 = dy22; dx1 = dx21; dx2 = dx22; break;
                            case 3: dy1 = dy31; dy2 = dy32; dx1 = dx31; dx2 = dx32; break;
                            case 4: dy1 = dy41; dy2 = dy42; dx1 = dx41; dx2 = dx42; break;
                            case 5: dy1 = dy51; dy2 = dy52; dx1 = dx51; dx2 = dx52; break;
                        }

                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY);

                    }
                    else if (channelNo == 2)
                    {
                        double dy11 = Convert.ToDouble(cTbl_calib.ch2_plc_min1);
                        double dy12 = Convert.ToDouble(cTbl_calib.ch2_plc_max1);
                        double dy21 = Convert.ToDouble(cTbl_calib.ch2_plc_min2);
                        double dy22 = Convert.ToDouble(cTbl_calib.ch2_plc_max2);
                        double dy31 = Convert.ToDouble(cTbl_calib.ch2_plc_min3);
                        double dy32 = Convert.ToDouble(cTbl_calib.ch2_plc_max3);
                        double dy41 = Convert.ToDouble(cTbl_calib.ch2_plc_min4);
                        double dy42 = Convert.ToDouble(cTbl_calib.ch2_plc_max4);
                        double dy51 = Convert.ToDouble(cTbl_calib.ch2_plc_min5);
                        double dy52 = Convert.ToDouble(cTbl_calib.ch2_plc_max5);

                        double dx11 = Convert.ToDouble(cTbl_calib.ch2_pc_min1);
                        double dx12 = Convert.ToDouble(cTbl_calib.ch2_pc_max1);
                        double dx21 = Convert.ToDouble(cTbl_calib.ch2_pc_min2);
                        double dx22 = Convert.ToDouble(cTbl_calib.ch2_pc_max2);
                        double dx31 = Convert.ToDouble(cTbl_calib.ch2_pc_min3);
                        double dx32 = Convert.ToDouble(cTbl_calib.ch2_pc_max3);
                        double dx41 = Convert.ToDouble(cTbl_calib.ch2_pc_min4);
                        double dx42 = Convert.ToDouble(cTbl_calib.ch2_pc_max4);
                        double dx51 = Convert.ToDouble(cTbl_calib.ch2_pc_min5);
                        double dx52 = Convert.ToDouble(cTbl_calib.ch2_pc_max5);

                        int idx = 0;
                        if (CheckMinMax(dy11, dy12, target) == true) { idx = 1; }
                        else if (CheckMinMax(dy22, dy22, target) == true) { idx = 2; }
                        else if (CheckMinMax(dy31, dy32, target) == true) { idx = 3; }
                        else if (CheckMinMax(dy41, dy42, target) == true) { idx = 4; }
                        else if (CheckMinMax(dy51, dy52, target) == true) { idx = 5; }

                        switch (idx)
                        {
                            case 1: dy1 = dy11; dy2 = dy12; dx1 = dx11; dx2 = dx12; break;
                            case 2: dy1 = dy21; dy2 = dy22; dx1 = dx21; dx2 = dx22; break;
                            case 3: dy1 = dy31; dy2 = dy32; dx1 = dx31; dx2 = dx32; break;
                            case 4: dy1 = dy41; dy2 = dy42; dx1 = dx41; dx2 = dx42; break;
                            case 5: dy1 = dy51; dy2 = dy52; dx1 = dx51; dx2 = dx52; break;
                        }

                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY);
                    }
                    else if (channelNo == 3)
                    {
                        double dy11 = Convert.ToDouble(cTbl_calib.ch3_plc_min1);
                        double dy12 = Convert.ToDouble(cTbl_calib.ch3_plc_max1);
                        double dy21 = Convert.ToDouble(cTbl_calib.ch3_plc_min2);
                        double dy22 = Convert.ToDouble(cTbl_calib.ch3_plc_max2);
                        double dy31 = Convert.ToDouble(cTbl_calib.ch3_plc_min3);
                        double dy32 = Convert.ToDouble(cTbl_calib.ch3_plc_max3);
                        double dy41 = Convert.ToDouble(cTbl_calib.ch3_plc_min4);
                        double dy42 = Convert.ToDouble(cTbl_calib.ch3_plc_max4);
                        double dy51 = Convert.ToDouble(cTbl_calib.ch3_plc_min5);
                        double dy52 = Convert.ToDouble(cTbl_calib.ch3_plc_max5);

                        double dx11 = Convert.ToDouble(cTbl_calib.ch3_pc_min1);
                        double dx12 = Convert.ToDouble(cTbl_calib.ch3_pc_max1);
                        double dx21 = Convert.ToDouble(cTbl_calib.ch3_pc_min2);
                        double dx22 = Convert.ToDouble(cTbl_calib.ch3_pc_max2);
                        double dx31 = Convert.ToDouble(cTbl_calib.ch3_pc_min3);
                        double dx32 = Convert.ToDouble(cTbl_calib.ch3_pc_max3);
                        double dx41 = Convert.ToDouble(cTbl_calib.ch3_pc_min4);
                        double dx42 = Convert.ToDouble(cTbl_calib.ch3_pc_max4);
                        double dx51 = Convert.ToDouble(cTbl_calib.ch3_pc_min5);
                        double dx52 = Convert.ToDouble(cTbl_calib.ch3_pc_max5);

                        int idx = 0;
                        if (CheckMinMax(dy11, dy12, target) == true) { idx = 1; }
                        else if (CheckMinMax(dy22, dy22, target) == true) { idx = 2; }
                        else if (CheckMinMax(dy31, dy32, target) == true) { idx = 3; }
                        else if (CheckMinMax(dy41, dy42, target) == true) { idx = 4; }
                        else if (CheckMinMax(dy51, dy52, target) == true) { idx = 5; }

                        switch (idx)
                        {
                            case 1: dy1 = dy11; dy2 = dy12; dx1 = dx11; dx2 = dx12; break;
                            case 2: dy1 = dy21; dy2 = dy22; dx1 = dx21; dx2 = dx22; break;
                            case 3: dy1 = dy31; dy2 = dy32; dx1 = dx31; dx2 = dx32; break;
                            case 4: dy1 = dy41; dy2 = dy42; dx1 = dx41; dx2 = dx42; break;
                            case 5: dy1 = dy51; dy2 = dy52; dx1 = dx51; dx2 = dx52; break;
                        }

                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY);
                    }
                    else if (channelNo == 4)
                    {
                        dy1 = Convert.ToDouble(cTbl_calib.ch4_plc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch4_plc_max1);
                        dx1 = Convert.ToDouble(cTbl_calib.ch4_pc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch4_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY);
                    }
                    else if (channelNo == 5)
                    {
                        dy1 = Convert.ToDouble(cTbl_calib.ch5_plc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch5_plc_max1);
                        dx1 = Convert.ToDouble(cTbl_calib.ch5_pc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch5_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY);
                    }
                    else if (channelNo == 6)
                    {
                        dy1 = Convert.ToDouble(cTbl_calib.ch6_plc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch6_plc_max1);
                        dx1 = Convert.ToDouble(cTbl_calib.ch6_pc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch6_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY);
                    }
                    else if (channelNo == 7)
                    {
                        dy1 = Convert.ToDouble(cTbl_calib.ch7_plc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch7_plc_max1);
                        dx1 = Convert.ToDouble(cTbl_calib.ch7_pc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch7_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY);

                    }
                    else if (channelNo == 8)
                    {
                        dy1 = Convert.ToDouble(cTbl_calib.ch8_plc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch8_plc_max1);
                        dx1 = Convert.ToDouble(cTbl_calib.ch8_pc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch8_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY);

                    }
                    else if (channelNo == 9)
                    {
                        dy1 = Convert.ToDouble(cTbl_calib.ch9_plc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch9_plc_max1);
                        dx1 = Convert.ToDouble(cTbl_calib.ch9_pc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch9_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY);

                    }
                    else if (channelNo == 10)
                    {
                        dy1 = Convert.ToDouble(cTbl_calib.ch10_plc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch10_plc_max1);
                        dx1 = Convert.ToDouble(cTbl_calib.ch10_pc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch10_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY);

                    }
                    else if (channelNo == 11)
                    {
                        dy1 = Convert.ToDouble(cTbl_calib.ch11_plc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch11_plc_max1);
                        dx1 = Convert.ToDouble(cTbl_calib.ch11_pc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch11_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY);
                    }
                    else if (channelNo == 12)
                    {
                        dy1 = Convert.ToDouble(cTbl_calib.ch12_plc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch12_plc_max1);
                        dx1 = Convert.ToDouble(cTbl_calib.ch12_pc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch12_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY);

                    }

                }
                catch (Exception exc)
                {
                    System.Diagnostics.Debug.WriteLine(exc);
                    cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
                }
                finally { }

                //2안 dTempY 가 voltage (-10~10)
            }
            else if (iCalcutType == 2)
            {


                double target = dTempY;

                try
                {
                    if (channelNo == 1)
                    {
                        dx1 = Convert.ToDouble(cTbl_calib.ch1_plc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch1_plc_max1);

                        if (CheckMinMax(dx1, dx2, target) == true)
                        {
                            dy1 = Convert.ToDouble(cTbl_calib.ch1_pc_min1);
                            dy2 = Convert.ToDouble(cTbl_calib.ch1_pc_max1);
                            dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                        }
                        else
                        {
                            dx1 = Convert.ToDouble(cTbl_calib.ch1_plc_min2);
                            dx2 = Convert.ToDouble(cTbl_calib.ch1_plc_max2);
                            if (CheckMinMax(dx1, dx2, target) == true)
                            {
                                dy1 = Convert.ToDouble(cTbl_calib.ch1_pc_min2);
                                dy2 = Convert.ToDouble(cTbl_calib.ch1_pc_max2);
                                dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                            }
                            else
                            {
                                dx1 = Convert.ToDouble(cTbl_calib.ch1_plc_min3);
                                dx2 = Convert.ToDouble(cTbl_calib.ch1_plc_max3);
                                if (CheckMinMax(dx1, dx2, target) == true)
                                {
                                    dy1 = Convert.ToDouble(cTbl_calib.ch1_pc_min3);
                                    dy2 = Convert.ToDouble(cTbl_calib.ch1_pc_max3);
                                    dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                                }
                                else
                                {
                                    dx1 = Convert.ToDouble(cTbl_calib.ch1_plc_min4);
                                    dx2 = Convert.ToDouble(cTbl_calib.ch1_plc_max4);
                                    if (CheckMinMax(dx1, dx2, target) == true)
                                    {
                                        dy1 = Convert.ToDouble(cTbl_calib.ch1_pc_min4);
                                        dy2 = Convert.ToDouble(cTbl_calib.ch1_pc_max4);
                                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                                    }
                                    else
                                    {
                                        dx1 = Convert.ToDouble(cTbl_calib.ch1_plc_min5);
                                        dx2 = Convert.ToDouble(cTbl_calib.ch1_plc_max5);
                                        if (CheckMinMax(dx1, dx2, target) == true)
                                        {
                                            dy1 = Convert.ToDouble(cTbl_calib.ch1_pc_min4);
                                            dy2 = Convert.ToDouble(cTbl_calib.ch1_pc_max4);
                                            dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                                        }
                                    }
                                }
                            }

                        }

                    }
                    else if (channelNo == 2)
                    {
                        dx1 = Convert.ToDouble(cTbl_calib.ch2_plc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch2_plc_max1);

                        if (CheckMinMax(dx1, dx2, target) == true)
                        {
                            dy1 = Convert.ToDouble(cTbl_calib.ch2_pc_min1);
                            dy2 = Convert.ToDouble(cTbl_calib.ch2_pc_max1);
                            dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                        }
                        else
                        {
                            dx1 = Convert.ToDouble(cTbl_calib.ch2_plc_min2);
                            dx2 = Convert.ToDouble(cTbl_calib.ch2_plc_max2);
                            if (CheckMinMax(dx1, dx2, target) == true)
                            {
                                dy1 = Convert.ToDouble(cTbl_calib.ch2_pc_min2);
                                dy2 = Convert.ToDouble(cTbl_calib.ch2_pc_max2);
                                dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                            }
                            else
                            {
                                dx1 = Convert.ToDouble(cTbl_calib.ch2_plc_min3);
                                dx2 = Convert.ToDouble(cTbl_calib.ch2_plc_max3);
                                if (CheckMinMax(dx1, dx2, target) == true)
                                {
                                    dy1 = Convert.ToDouble(cTbl_calib.ch2_pc_min3);
                                    dy2 = Convert.ToDouble(cTbl_calib.ch2_pc_max3);
                                    dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                                }
                                else
                                {
                                    dx1 = Convert.ToDouble(cTbl_calib.ch2_plc_min4);
                                    dx2 = Convert.ToDouble(cTbl_calib.ch2_plc_max4);
                                    if (CheckMinMax(dx1, dx2, target) == true)
                                    {
                                        dy1 = Convert.ToDouble(cTbl_calib.ch2_pc_min4);
                                        dy2 = Convert.ToDouble(cTbl_calib.ch2_pc_max4);
                                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                                    }
                                    else
                                    {
                                        dx1 = Convert.ToDouble(cTbl_calib.ch2_plc_min5);
                                        dx2 = Convert.ToDouble(cTbl_calib.ch2_plc_max5);
                                        if (CheckMinMax(dx1, dx2, target) == true)
                                        {
                                            dy1 = Convert.ToDouble(cTbl_calib.ch2_pc_min4);
                                            dy2 = Convert.ToDouble(cTbl_calib.ch2_pc_max4);
                                            dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (channelNo == 3)
                    {
                        dx1 = Convert.ToDouble(cTbl_calib.ch3_plc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch3_plc_max1);

                        if (CheckMinMax(dx1, dx2, target) == true)
                        {
                            dy1 = Convert.ToDouble(cTbl_calib.ch3_pc_min1);
                            dy2 = Convert.ToDouble(cTbl_calib.ch3_pc_max1);
                            dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                        }
                        else
                        {
                            dx1 = Convert.ToDouble(cTbl_calib.ch3_plc_min2);
                            dx2 = Convert.ToDouble(cTbl_calib.ch3_plc_max2);
                            if (CheckMinMax(dx1, dx2, target) == true)
                            {
                                dy1 = Convert.ToDouble(cTbl_calib.ch3_pc_min2);
                                dy2 = Convert.ToDouble(cTbl_calib.ch3_pc_max2);
                                dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                            }
                            else
                            {
                                dx1 = Convert.ToDouble(cTbl_calib.ch3_plc_min3);
                                dx2 = Convert.ToDouble(cTbl_calib.ch3_plc_max3);
                                if (CheckMinMax(dx1, dx2, target) == true)
                                {
                                    dy1 = Convert.ToDouble(cTbl_calib.ch3_pc_min3);
                                    dy2 = Convert.ToDouble(cTbl_calib.ch3_pc_max3);
                                    dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                                }
                                else
                                {
                                    dx1 = Convert.ToDouble(cTbl_calib.ch3_plc_min4);
                                    dx2 = Convert.ToDouble(cTbl_calib.ch3_plc_max4);
                                    if (CheckMinMax(dx1, dx2, target) == true)
                                    {
                                        dy1 = Convert.ToDouble(cTbl_calib.ch3_pc_min4);
                                        dy2 = Convert.ToDouble(cTbl_calib.ch3_pc_max4);
                                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                                    }
                                    else
                                    {
                                        dx1 = Convert.ToDouble(cTbl_calib.ch3_plc_min5);
                                        dx2 = Convert.ToDouble(cTbl_calib.ch3_plc_max5);
                                        if (CheckMinMax(dx1, dx2, target) == true)
                                        {
                                            dy1 = Convert.ToDouble(cTbl_calib.ch3_pc_min4);
                                            dy2 = Convert.ToDouble(cTbl_calib.ch3_pc_max4);
                                            dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (channelNo == 4)
                    {
                        dx1 = Convert.ToDouble(cTbl_calib.ch4_plc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch4_plc_max1);
                        dy1 = Convert.ToDouble(cTbl_calib.ch4_pc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch4_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                    }
                    else if (channelNo == 5)
                    {
                        dx1 = Convert.ToDouble(cTbl_calib.ch5_plc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch5_plc_max1);
                        dy1 = Convert.ToDouble(cTbl_calib.ch5_pc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch5_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                    }
                    else if (channelNo == 6)
                    {
                        dx1 = Convert.ToDouble(cTbl_calib.ch6_plc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch6_plc_max1);
                        dy1 = Convert.ToDouble(cTbl_calib.ch6_pc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch6_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                    }   
                    else if (channelNo == 7)
                    {
                        dx1 = Convert.ToDouble(cTbl_calib.ch7_plc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch7_plc_max1);
                        dy1 = Convert.ToDouble(cTbl_calib.ch7_pc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch7_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);

                    }
                    else if (channelNo == 8)
                    {
                        dx1 = Convert.ToDouble(cTbl_calib.ch8_plc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch8_plc_max1);
                        dy1 = Convert.ToDouble(cTbl_calib.ch8_pc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch8_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);

                    }
                    else if (channelNo == 9)
                    {
                        dx1 = Convert.ToDouble(cTbl_calib.ch9_plc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch9_plc_max1);
                        dy1 = Convert.ToDouble(cTbl_calib.ch9_pc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch9_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);

                    }
                    else if (channelNo == 10)
                    {
                        dx1 = Convert.ToDouble(cTbl_calib.ch10_plc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch10_plc_max1);
                        dy1 = Convert.ToDouble(cTbl_calib.ch10_pc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch10_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);

                    }
                    else if (channelNo == 11)
                    {
                        dx1 = Convert.ToDouble(cTbl_calib.ch11_plc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch11_plc_max1);
                        dy1 = Convert.ToDouble(cTbl_calib.ch11_pc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch11_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);
                    }
                    else if (channelNo == 12)
                    {
                        dx1 = Convert.ToDouble(cTbl_calib.ch12_plc_min1);
                        dx2 = Convert.ToDouble(cTbl_calib.ch12_plc_max1);
                        dy1 = Convert.ToDouble(cTbl_calib.ch12_pc_min1);
                        dy2 = Convert.ToDouble(cTbl_calib.ch12_pc_max1);
                        dRtnValue = FrmDataIO.mIns.Calculation(dx1, dy1, dx2, dy2, dTempY, iCalcutType);

                    }

                }
                catch (Exception exc)
                {
                    System.Diagnostics.Debug.WriteLine(exc);
                    cLog.Error("[" + this.Name + "]\r\n " + exc.ToString());
                }
                finally { }

                //2안 dTempY 가 voltage (-10~10)

            }


            return dRtnValue;

        }
  
        internal void MemSetPlcCalibParams(Tbl_plc_calibration plc_calib)
        {
            cTbl_calib = plc_calib;

        }
    }
}

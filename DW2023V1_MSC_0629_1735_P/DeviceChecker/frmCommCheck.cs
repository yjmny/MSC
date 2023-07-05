using DBMS_V1;
using DBMS_V1.Data.MSC;
using DwLib.Data.Generic;
using NetworkLib;
using System;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceChecker
{
    public partial class FrmCommCheck : Form
    {
        // 디자인 영역====================================================================================================================
        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnIgnoreNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "다시 체크";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnIgnoreNext
            // 
            this.btnIgnoreNext.Location = new System.Drawing.Point(93, 12);
            this.btnIgnoreNext.Name = "btnIgnoreNext";
            this.btnIgnoreNext.Size = new System.Drawing.Size(75, 23);
            this.btnIgnoreNext.TabIndex = 1;
            this.btnIgnoreNext.Text = "다음 단계";
            this.btnIgnoreNext.UseVisualStyleBackColor = true;
            this.btnIgnoreNext.Click += new System.EventHandler(this.BtnIgnoreNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(174, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "종료";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(343, 12);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(445, 422);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "";
            // 
            // frmCommCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnIgnoreNext);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmCommCheck";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnIgnoreNext;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox lblMsg;
        //================================================================================================================================


        public FrmCommCheck()
        {
            InitializeComponent();
            cMysqlDto = new MySqlDTO();
        }

        readonly MySqlDTO cMysqlDto = null;
        public string DeviceCheckString { get; set; }

        private bool GetSerialDB(ref Tbl_serialcomm table)
        {
            bool isOk = false;

            try
            {

                bool isRtn = cMysqlDto.OpenKeepUp();
                if (isRtn)
                {
                    string strSql = "";
                    string[] sqlParams = new string[4];
                    sqlParams[0] = "type";
                    sqlParams[1] = "id";
                    sqlParams[2] = "name";
                    sqlParams[3] = "port";

                    strSql = @"SELECT type, id, name, port
FROM tbl_serialcomm
where use10 = 1; ";

                    string strData = cMysqlDto.SelectSql(strSql, sqlParams);
                    System.Diagnostics.Debug.WriteLine(strData);

                    string[] strGetData = strData.Split('|');
                    table.type = strGetData[0];
                    table.name = strGetData[2];
                    table.port = strGetData[3];
                }
                isOk = true;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
            finally { cMysqlDto.Close(); }
            return isOk;
        }
        private bool GetTcpDB(ref Tbl_tcpipcomm table, string id)
        {
            bool isOk = false;

            try
            {
                bool isRtn = cMysqlDto.OpenKeepUp();
                if (isRtn)
                {
                    string strSql = "";
                    string[] sqlParams = new string[5];
                    sqlParams[0] = "type";
                    sqlParams[1] = "id";
                    sqlParams[2] = "name";
                    sqlParams[3] = "port";
                    sqlParams[4] = "ipaddress";

                    strSql = @"SELECT type, id, name, port, ipaddress
                                        FROM tbl_tcpcomm
                                        where use10=1 and id='" + id + "';";

                    string strData = cMysqlDto.SelectSql(strSql, sqlParams);//TCP/IP|ID0001|COM|5000|192.168.0.151|
                    System.Diagnostics.Debug.WriteLine("strData : " + strData);


                    if (string.IsNullOrEmpty(strData))
                    {
                        isOk = false;
                    }
                    else
                    {
                        string[] strGetData = strData.Split('|');
                        table.type = strGetData[0];
                        table.name = strGetData[2];
                        table.port = strGetData[3];
                        table.ipaddress = strGetData[4];
                    }
                    isOk = true;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);

            }
            finally { cMysqlDto.Close(); }
            return isOk;
        }

        public bool IsDeviceLsitCheck(int iIndexNo, int iDeviceFull, string DeviceId, ref Tbl_serialcomm tbl_serialcomm, ref Tbl_tcpipcomm tbl_tcpipcomm)
        {
            bool isOk = false;
            bool isFlag = false;

            string strSpace = "  ";
            switch (DeviceId)
            {
                case "DB":
                    isFlag = CheckDeviceDB();
                    if (isFlag)
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "DB Device 연결상태를 확인(OK)";
                        CommonClass.IsDBCtrlConn10 = true; ;
                        lblMsg.Text = DeviceCheckString;

                        iIndexNo++;
                    }
                    else
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "DB Device 연결에러";
                        CommonClass.IsDBCtrlConn10 = false;
                        lblMsg.Text = DeviceCheckString;
                        isOk = false;
                    }
                    break;
                case "SerialComDB":

                    isFlag = GetSerialDB(ref tbl_serialcomm);
                    if (isFlag)
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "DB Device 연결상태를 확인(OK)";
                        CommonClass.IsDBCtrlConn10 = true;
                        lblMsg.Text = DeviceCheckString;
                        iIndexNo++;
                    }
                    else
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "DB Device 연결상태를 확인하세요.";
                        CommonClass.IsDBCtrlConn10 = false;
                        lblMsg.Text = DeviceCheckString;
                        isOk = false;
                    }
                    break;
                case "SerialComCtrl":
                    isFlag = CheckDeviceEscaleComm(ref tbl_serialcomm);
                    if (isFlag)
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "무게저울 Device 연결 상태를 확인(OK)";
                        CommonClass.IsEscaleCtrlConn10 = true;
                        lblMsg.Text = DeviceCheckString;
                        iIndexNo++;
                    }
                    else
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "무게저울 Device 연결에러";
                        CommonClass.IsEscaleCtrlConn10 = false;
                        lblMsg.Text = DeviceCheckString;
                        isOk = false;
                    }
                    break;
                case "HMICtrlDB":

                    isFlag = GetTcpDB(ref tbl_tcpipcomm, "ID151");
                    if (isFlag)
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "HMI DB Device 연결상태를 확인(OK)";
                        CommonClass.IsDBCtrlConn10 = true;
                            lblMsg.Text = DeviceCheckString;
                        iIndexNo++;
                    }
                    else
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "HMI DB Device 연결에러";
                        CommonClass.IsDBCtrlConn10 = false;
                        lblMsg.Text = DeviceCheckString;
                        isOk = false;
                    }
                    break;
                case "HMICtrl":
                    isFlag = CheckDeviceHMIComm(ref tbl_tcpipcomm);
                    if (isFlag)
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "HMI 컨트롤러 연결상태를 확인(OK)";
                        CommonClass.IsHmiCtrlConn10 = true;
                        lblMsg.Text = DeviceCheckString;
                        iIndexNo++;
                    }
                    else
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "HMI 컨트롤러 Device 연결에러";
                        CommonClass.IsHmiCtrlConn10 = false;
                        lblMsg.Text += DeviceCheckString;
                        isOk = false;
                    }
                    break;

                case "RecoCtrlDB":
                    isFlag = GetTcpDB(ref tbl_tcpipcomm, "ID152");
                    if (isFlag)
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "레코더 DB Device 연결상태를 확인(OK)";
                        CommonClass.IsDBCtrlConn10 = true;
                        lblMsg.Text = DeviceCheckString;
                        iIndexNo++;
                    }
                    else
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "레코더 DB Device 연결에러";
                        CommonClass.IsDBCtrlConn10 = false;
                        lblMsg.Text = DeviceCheckString;
                        isOk = false;
                    }
                    break;

                case "RecoCtrl":
                    isFlag = CheckDeviceRecorderComm(ref tbl_tcpipcomm);
                    if (isFlag)
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "레코더 컨트롤러 연결상태를 확인(OK)";
                        CommonClass.IsRecoCtrlConn10 = true;
                        lblMsg.Text = DeviceCheckString;
                        iIndexNo++;
                    }
                    else
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "레코더 컨트롤러 Device 연결에러";
                        CommonClass.IsRecoCtrlConn10 = false;
                        lblMsg.Text += DeviceCheckString;
                        isOk = false;

                    }
                    break;
                case "PlcCtrlDB":
                    isFlag = GetTcpDB(ref tbl_tcpipcomm, "ID153");
                    if (isFlag)
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "PLC DB Device 연결상태를 확인(OK)";
                        CommonClass.IsDBCtrlConn10 = true;
                        lblMsg.Text = DeviceCheckString;
                        iIndexNo++;
                    }
                    else
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "PLC DB Device 연결에러";
                        CommonClass.IsDBCtrlConn10 = false;
                        lblMsg.Text = DeviceCheckString;
                        isOk = false;
                    }
                    break;

                case "PlcCtrl":
                    isFlag = CheckDevicPlcComm(ref tbl_tcpipcomm);
                    if (isFlag)
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "PLC 컨트롤러 연결상태를 확인(OK)";
                        CommonClass.IsPlcCtrlConn10 = true;
                        lblMsg.Text = DeviceCheckString;
                        iIndexNo++;
                    }
                    else
                    {
                        DeviceCheckString = "(" + iIndexNo + "/" + iDeviceFull + ")" + strSpace + "PLC 컨트롤러 Device 연결에러";
                        CommonClass.IsPlcCtrlConn10 = false;
                        lblMsg.Text += DeviceCheckString;
                        isOk = false;

                    }
                    break;
            }
            return isOk;
        }
        public bool IsDbCheck()
        {
            bool isOk;
            bool isFlag;
            int iDeviceFull = 0;
            int iDbDataCheck = 1; //DB
            iDeviceFull += iDbDataCheck;//iDeviceFull = iDeviceFull + iDbDataCheck;
            lblMsg.Text = "";
            String strCheck = "";
            int iIndexNo = 1;
            Tbl_serialcomm tbl_serialcomm = new Tbl_serialcomm();
            Tbl_tcpipcomm tbl_tcpipcomm = new Tbl_tcpipcomm();
            //-------------------------------------------------------------------------------------------
            isFlag = IsDeviceLsitCheck(iIndexNo, iDeviceFull, "DB", ref tbl_serialcomm, ref tbl_tcpipcomm);
            if (isFlag) { iIndexNo++; }
            //else { isOk = isFlag; }
            strCheck += DeviceCheckString + "\r\n";
            Task.Delay(100).GetAwaiter().GetResult();
            isOk = isFlag;
            if (isOk)
            {
                DeviceCheckString = "Device Ready Complete";
                lblMsg.Text = DeviceCheckString;
                iIndexNo = 0;
            }
            else
            {
                DeviceCheckString = strCheck;
                lblMsg.Text = DeviceCheckString;
            }

            return isOk;
        }

        public bool IsDeviceLsitCheck(int programId, string projectName)
        {
            bool isOk = false;
            bool isFlag = false;


            int iIndexNo = 1;
            string programName = null;

            switch (programId)
            {
                case 0:
                case 1: programName = "MS"; break;
                case 2: programName = "AN"; break;
            }

            if (programName.Equals("MS"))
            {
                int iDeviceFull = 4;
                int iDbDataCheck = 3;
                String strCheck = "";
                Tbl_serialcomm tbl_serialcomm = new Tbl_serialcomm();
                Tbl_tcpipcomm tbl_tcpipcomm = new Tbl_tcpipcomm();


                switch (projectName)
                {
                    case "WVP":
                        iDeviceFull = 4; //DB, HMI, Rec, escale
                        iDbDataCheck = 3; //HMI, Rec, escale (DB제외)
                        iDeviceFull += iDbDataCheck;//iDeviceFull = iDeviceFull + iDbDataCheck;
                        lblMsg.Text = "";
                        //-------------------------------------------------------------------------------------------
                        isFlag = IsDeviceLsitCheck(iIndexNo, iDeviceFull, "DB", ref tbl_serialcomm, ref tbl_tcpipcomm);
                        iIndexNo++;
                        strCheck += DeviceCheckString + "\r\n";
                        Task.Delay(100).GetAwaiter().GetResult();
                        //-------------------------------------------------------------------------------------------
                        isFlag = IsDeviceLsitCheck(iIndexNo, iDeviceFull, "SerialComDB", ref tbl_serialcomm, ref tbl_tcpipcomm);
                        iIndexNo++;
                        strCheck += DeviceCheckString + "\r\n";
                        Task.Delay(100).GetAwaiter().GetResult();
                        //-------------------------------------------------------------------------------------------
                        isFlag = IsDeviceLsitCheck(iIndexNo, iDeviceFull, "SerialComCtrl", ref tbl_serialcomm, ref tbl_tcpipcomm);
                        iIndexNo++;
                        strCheck += DeviceCheckString + "\r\n";
                        Task.Delay(100).GetAwaiter().GetResult();
                        //-------------------------------------------------------------------------------------------
                        isFlag = IsDeviceLsitCheck(iIndexNo, iDeviceFull, "HMICtrlDB", ref tbl_serialcomm, ref tbl_tcpipcomm);
                        iIndexNo++;
                        strCheck += DeviceCheckString + "\r\n";
                        Task.Delay(100).GetAwaiter().GetResult();
                        //-------------------------------------------------------------------------------------------
                        isFlag = IsDeviceLsitCheck(iIndexNo, iDeviceFull, "HMICtrl", ref tbl_serialcomm, ref tbl_tcpipcomm);

                        iIndexNo++;
                        strCheck += DeviceCheckString + "\r\n";
                        Task.Delay(100).GetAwaiter().GetResult();
                        //-------------------------------------------------------------------------------------------
                        isFlag = IsDeviceLsitCheck(iIndexNo, iDeviceFull, "RecoCtrlDB", ref tbl_serialcomm, ref tbl_tcpipcomm);

                        iIndexNo++;
                        strCheck += DeviceCheckString + "\r\n";
                        Task.Delay(100).GetAwaiter().GetResult();
                        //-------------------------------------------------------------------------------------------
                        isFlag = IsDeviceLsitCheck(iIndexNo, iDeviceFull, "RecoCtrl", ref tbl_serialcomm, ref tbl_tcpipcomm);

                        iIndexNo++;
                        strCheck += DeviceCheckString + "\r\n";
                        Task.Delay(100).GetAwaiter().GetResult();
                        //-------------------------------------------------------------------------------------------
                        break;
                    case "MSC":
                        iDeviceFull = 3; //DB, HMI, PLC
                        iDbDataCheck = 2; //HMI, PLC
                        iDeviceFull += iDbDataCheck;
                        lblMsg.Text = "";
                        strCheck = "";

                        //-------------------------------------------------------------------------------------------
                        isFlag = IsDeviceLsitCheck(iIndexNo, iDeviceFull, "DB", ref tbl_serialcomm, ref tbl_tcpipcomm);
                        iIndexNo++;
                        strCheck += DeviceCheckString + "\r\n";
                        Task.Delay(100).GetAwaiter().GetResult();
                        //-------------------------------------------------------------------------------------------
                        isFlag = IsDeviceLsitCheck(iIndexNo, iDeviceFull, "HMICtrlDB", ref tbl_serialcomm, ref tbl_tcpipcomm);
                        iIndexNo++;
                        strCheck += DeviceCheckString + "\r\n";
                        Task.Delay(100).GetAwaiter().GetResult();
                        //-------------------------------------------------------------------------------------------
                        isFlag = IsDeviceLsitCheck(iIndexNo, iDeviceFull, "HMICtrl", ref tbl_serialcomm, ref tbl_tcpipcomm);
                        iIndexNo++;
                        strCheck += DeviceCheckString + "\r\n";
                        Task.Delay(100).GetAwaiter().GetResult();
                        //-------------------------------------------------------------------------------------------
                        isFlag = IsDeviceLsitCheck(iIndexNo, iDeviceFull, "PlcCtrlDB", ref tbl_serialcomm, ref tbl_tcpipcomm);
                        iIndexNo++;
                        strCheck += DeviceCheckString + "\r\n";
                        Task.Delay(100).GetAwaiter().GetResult();
                        //-------------------------------------------------------------------------------------------
                        isFlag = IsDeviceLsitCheck(iIndexNo, iDeviceFull, "PlcCtrl", ref tbl_serialcomm, ref tbl_tcpipcomm);
                        iIndexNo++;
                        strCheck += DeviceCheckString + "\r\n";
                        Task.Delay(100).GetAwaiter().GetResult();
                        break;
                }


                isOk = isFlag;
                if (isOk)
                {
                    DeviceCheckString = "Device Ready Complete";
                    lblMsg.Text = DeviceCheckString;
                    iIndexNo = 0;
                }
                else
                {
                    DeviceCheckString = strCheck;
                    lblMsg.Text = DeviceCheckString;
                }

                return isOk;
            }
            else if (programName.Equals("AN"))
            {
                int iDeviceFull = 0;
                int iDbDataCheck = 1; //DB
                iDeviceFull += iDbDataCheck;
                lblMsg.Text = "";
                String strCheck = "";
                iIndexNo = 1;
                Tbl_serialcomm tbl_serialcomm = new Tbl_serialcomm();
                Tbl_tcpipcomm tbl_tcpipcomm = new Tbl_tcpipcomm();
                //-------------------------------------------------------------------------------------------
                isFlag = IsDeviceLsitCheck(iIndexNo, iDeviceFull, "DB", ref tbl_serialcomm, ref tbl_tcpipcomm);
                if (isFlag) { iIndexNo++; }
                else { isOk = isFlag; }
                strCheck += DeviceCheckString + "\r\n";
                Task.Delay(100).GetAwaiter().GetResult();
                isOk = isFlag;
                if (isOk)
                {
                    DeviceCheckString = "Device Ready Complete";
                    lblMsg.Text = DeviceCheckString;
                    iIndexNo = 0;
                }
                else
                {
                    DeviceCheckString = strCheck;
                    lblMsg.Text = DeviceCheckString;
                }

                return isOk;
            }

            return isOk;
        }

        private bool CheckDeviceDB()
        {
            //DB Info Load
            bool isOk = false;
            // Ping Check
            if (string.IsNullOrEmpty(CommonClass.dbip))
            {
                isOk = IsOpenPing("127.0.0.1");
            }
            else
            {
                isOk = IsOpenPing(CommonClass.dbip);
            }
            //Port Ping Check
            if (string.IsNullOrEmpty(CommonClass.dbport))
            {
                isOk = IsOpenPortPing("127.0.0.1", "3306");
            }
            else
            {
                isOk = IsOpenPortPing(CommonClass.dbip, CommonClass.dbport);
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

        System.IO.Ports.SerialPort serialPort1;

        public class SerialInfo
        {
            public string Name;
            public string Port;

            public SerialInfo(string name, string port)
            {
                Name = name;
                Port = port;
            }
        }

        private bool CheckDeviceEscaleComm(ref Tbl_serialcomm tbl)
        {

            bool isOk = false;
            serialPort1 = new System.IO.Ports.SerialPort();

            string[] PortNames = SerialPort.GetPortNames();  // 포트 검색.

            try
            {
                if (PortNames.Length > 0)
                {

                    serialPort1.PortName = tbl.name + tbl.port;// "COM5";
                    serialPort1.BaudRate = 9600;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Parity = Parity.None;
                    serialPort1.Open();

                    isOk = serialPort1.IsOpen;
                    if (isOk)
                    {
                        serialPort1.Close();
                    }
                    else
                    {
                        isOk = false;
                    }
                }
                else
                {
                    isOk = false;
                }
            }
            catch
            {
                isOk = false;
            }
            //----------------------------------------------------------
            //int iIndex = commlist.IndexOf("COM");

            return isOk;
        }



        private bool CheckDeviceHMIComm(ref Tbl_tcpipcomm tbl_tcpipcomm)
        {
            bool isOk = false;
            // Ping Check
            isOk = IsOpenPing(tbl_tcpipcomm.ipaddress);
            if (isOk)
            {
                //Port Ping Check
                isOk = IsOpenPortPing(tbl_tcpipcomm.ipaddress, tbl_tcpipcomm.port);
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
        private bool CheckDeviceRecorderComm(ref Tbl_tcpipcomm tbl_tcpipcomm)
        {
            bool isOk = false;
            // Ping Check
            isOk = IsOpenPing(tbl_tcpipcomm.ipaddress);
            if (isOk)
            {
                //Port Ping Check
                isOk = IsOpenPortPing(tbl_tcpipcomm.ipaddress, tbl_tcpipcomm.port);
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

        private bool CheckDevicPlcComm(ref Tbl_tcpipcomm tbl_tcpipcomm)
        {
            bool isOk = false;
            // Ping Check
            isOk = IsOpenPing(tbl_tcpipcomm.ipaddress);
            if (isOk)
            {
                //Port Ping Check
                isOk = IsOpenPortPing(tbl_tcpipcomm.ipaddress, tbl_tcpipcomm.port);
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {

        }

        private void BtnIgnoreNext_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

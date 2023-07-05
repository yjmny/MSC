using log4net;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO.Ports;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using MessageBox = System.Windows.Forms.MessageBox;

namespace DoOneDaqSystemKSx3267
{
    public partial class FormDaqMain : Form
    {
        private static readonly ILog log = LogManager.GetLogger("file_event");
        private static readonly ILog logDataCsv = LogManager.GetLogger("file_data");

        public FormDaqMain()
        {
            InitializeComponent();
            log.Info("=============  Started application  =============");

        }

        private int iCommandNo = 0;

        // Slave의 데이터이며 Master가 쓰기 및 읽기 데이터를 저장하는 변수
        //private byte[] m_bSlaveMemoryMapArray = new byte[1000];
        private byte[] m_bSensorNodeRegisterMapArray = new byte[1000];

        private void Form1_Load(object sender, EventArgs e)
        {/*
            Common common = new Common();
            if (!common.ReadSettings())
            {
                MessageBox.Show("설정읽기 에러");
            }
            log.Info("프로그램 시작 설정합니다.");
            DaqKS3267ModbusSetting();
            DaqLoraSetting();
            */
        }

        public enum CommandList
        {
            NodeInfo = 1,
            SensorList = 2,
            SensorValueCheck = 3,
            ControlSearch = 4,
        }

        public enum BAUDRATE
        {
            _110bps = 110,
            _300bps = 300,
            _600bps = 600,
            _1200bps = 1200,
            _2400bps = 2400,
            _4800bps = 4800,
            _9600bps = 9600,
            _14400bps = 14400,
            _19200bps = 19200,
            _38400bps = 38400,
            _56000bps = 56000,
            _57600bps = 57600,
            _115200bps = 115200
        }

        private void DaqKS3267ModbusSetting()
        {
            serialPort1.BaudRate = 9600;
            serialPort1.PortName = "COM6";// 7";// 3";
            serialPort1.ReadTimeout = 500;
            serialPort1.WriteTimeout = 500;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Parity = Parity.None;

            SetPortName();
            SetPortBaudRate();
            log.Info("유선 Comport 정보 로드 완료.");
        }

        private void DaqLoraSetting()
        {
            serialPort2.BaudRate = 9600;
            serialPort2.PortName = "COM6";// 7";// 3";
            serialPort2.ReadTimeout = 500;
            serialPort2.WriteTimeout = 500;
            serialPort2.DataBits = 8;
            serialPort2.StopBits = StopBits.One;
            serialPort2.Parity = Parity.None;

            SetPortName_Lora();
            SetPortBaudRate_Lora();
            log.Info("무선 Comport 정보 로드 완료.");
        }

        public void SetPortName()
        {
            cboPortName.Items.Clear();
            int iPortNo = 0;
            bool isPortScearch = false;
            foreach (string s in SerialPort.GetPortNames())
            {
                cboPortName.Items.Add(s);
                if (string.Compare(serialPort1.PortName, s, true) == 0)
                {
                    cboPortName.SelectedIndex = iPortNo;
                    isPortScearch = true;
                }
                else
                {
                    if (isPortScearch == false)
                        cboPortName.SelectedIndex = 0;
                }
                iPortNo++;
            }
        }

        public void SetPortName_Lora()
        {
            cboPortNameLora.Items.Clear();

            int iPortNo = 0;
            foreach (string s in SerialPort.GetPortNames())
            {
                cboPortNameLora.Items.Add(s);
                bool isPortScearch = false;
                if (string.Compare(serialPort2.PortName, s, true) == 0)
                {
                    cboPortNameLora.SelectedIndex = iPortNo;
                }
                else
                {
                    if (isPortScearch == false)
                        cboPortNameLora.SelectedIndex = 0;
                }
                iPortNo++;
            }
        }

        public void SetPortBaudRate()
        {
            int iPortBaudrate = 0;
            foreach (BAUDRATE s in Enum.GetValues(typeof(BAUDRATE)))
            {
                string[] val = s.ToString().Split('_');
                string val1 = val[1].Replace("bps", "").Trim();
                cboPortBaudRate.Items.Add(val1);

                if (string.Compare(serialPort1.BaudRate.ToString(), val1, true) == 0)
                {
                    cboPortBaudRate.SelectedIndex = iPortBaudrate;
                }
                iPortBaudrate++;
            }

        }

        public void SetPortBaudRate_Lora()
        {
            int iPortBaudrate = 0;
            foreach (BAUDRATE s in Enum.GetValues(typeof(BAUDRATE)))
            {
                string[] val = s.ToString().Split('_');
                string val1 = val[1].Replace("bps", "").Trim();
                cboPortBaudRateLora.Items.Add(val1);

                if (string.Compare(serialPort2.BaudRate.ToString(), val1, true) == 0)
                {
                    cboPortBaudRateLora.SelectedIndex = iPortBaudrate;
                }
                iPortBaudrate++;
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Serial1Open();
        }

        private void Serial1Open()
        {
            try
            {
                if (serialPort1 != null && serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = cboPortName.Text;
                    serialPort1.Open();
                    btnOpen.Enabled = false;
                    btnClose.Enabled = true;
                    log.Info("RS485 modbus Comm Open 완료.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);

            }
            finally
            {

            }
        }

        private void Serial2Open()
        {
            try
            {
                if (serialPort2 != null && serialPort2.IsOpen == false)
                {
                    serialPort2.PortName = cboPortNameLora.Text;
                    serialPort2.Open();
                    btnOpenLora.Enabled = false;
                    btnCloseLora.Enabled = true;
                    log.Info("Lora Comm Open 완료.");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);

            }
            finally
            {

            }
        }

        private void Serial1Close()
        {
            try
            {
                if (timerSensorRecv1.Enabled)
                {
                    btnSendSensorValue_autoStop_Click(null, null);
                }

                if (serialPort1.IsOpen)
                {
                    btnOpen.Enabled = true;
                    btnClose.Enabled = false;
                    serialPort1.Close();
                }
                log.Info("RS485 modbus Comm Close 완료.");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }
            finally
            {

            }
        }

        private void Serial2Close()
        {
            try
            {
                if (timerSensorRecv1Lora.Enabled)
                {
                    btnSendSensorValue_autoStop_Click(null, null);
                }

                if (serialPort2.IsOpen)
                {
                    btnOpenLora.Enabled = true;
                    btnCloseLora.Enabled = false;
                    serialPort2.Close();
                }
                log.Info("Lora Comm Close 완료.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }
            finally
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Serial1Close();

        }

        private byte[] ReadSerialByteData()
        {

            int sum = 0;
            byte[] tmp = new byte[1024];
            int iCheckCount = 0;
            switch (iCommandNo)
            {
                case (int)CommandList.NodeInfo: iCheckCount = 21; break;
                case (int)CommandList.SensorList: iCheckCount = 85; break;
                case (int)CommandList.SensorValueCheck: iCheckCount = 83; break;
                case (int)CommandList.ControlSearch: iCheckCount = 5; break;
            }

            for (; ; )
            {
                try
                {
                    byte[] bytesBuffer = new byte[serialPort1.BytesToRead];
                    int bufferOffset = 0;
                    int bytesToRead = bytesBuffer.Length;// serialPort1.BytesToRead;

                    int readBytes = 0;
                    if (bytesToRead > 0)
                    {
                        readBytes = serialPort1.Read(bytesBuffer, bufferOffset, bytesToRead - bufferOffset);
                        bytesToRead -= readBytes;
                        bufferOffset += readBytes;

                        
                        if (sum != iCheckCount)
                        {
                            Buffer.BlockCopy(bytesBuffer, 0, tmp, sum, readBytes);
                            sum = sum + readBytes;
                            if (sum == iCheckCount) { break; }
                            continue;
                        }
                        else if (readBytes == iCheckCount && sum == 0) { Buffer.BlockCopy(bytesBuffer, 0, tmp, sum, readBytes); break; }
                        else { break; }

                    }

                }
                catch (TimeoutException ex)
                {
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                }
                catch (Exception ex)
                {
                    log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
                }
            }

            byte[] rtnData = new byte[sum];
            Buffer.BlockCopy(tmp, 0, rtnData, 0, sum);

            return rtnData;
            //return tmp;
        }
        private byte[] ReadSerialByteDataLora()
        {

         
            byte[] rtnRawData = null;// new byte[sum];
            try
            {

                byte[] bMadeRawdata = new byte[8192];//total buffer
                int readInTotalCount = 0;

                //RECV:541338:-109:temp?22.9, humi?27.4, co2?775, time?20221222163351
                //    //CR(carriage return) = 0xd(십진수 13)이구요
                //    //LF(line feed) = 0xa(십진수 10)입니다.
                //ASCII
                //char R = (char)0x52;
                //char E = (char)0x45;
                //char C = (char)0x43;
                //char V = (char)0x56;
                //char semicolon = (char)0x3a;
                byte R = 0x52;
                byte E = 0x45;
                byte C = 0x43;
                byte V = 0x56;
                //byte semicolon = 0x3a;


                //char CR = (char)0x0D; // \r
                //char LF = (char)0x0A; // \n
                                      //                          //public final static char SPaceBar = (char)0x20;

                int startStep = 0;
                byte[] bMadeData1 = new byte[2048];
                int iMadeDataIndex = 0;
                for (; ; )
                {
                    //Gets the number of bytes of data in the receive buffer.
                    byte[] inbuffer = new byte[serialPort2.BytesToRead];

                    int readInCount = inbuffer.Length;

                    //string RecvStr = string.Empty;
                    //lock (obj)
                    //{
                        if (readInCount > 0)
                        {
                            readInTotalCount = readInTotalCount + serialPort2.Read(inbuffer, 0, readInCount);

                        bool isbreak = false;
                         for (int i = 0; i < readInCount; i++)
                        {

                            if (inbuffer[i] == R && startStep == 0)
                            {
                                startStep = 1;
                                bMadeData1[0] = inbuffer[i];
                            }
                            else if(inbuffer[i] == E && startStep==1)
                            {
                                startStep = 2;
                                bMadeData1[1] = inbuffer[i];
                            }
                            else if (inbuffer[i] == C && startStep == 2)
                            {
                                startStep =3;
                                bMadeData1[2] = inbuffer[i];
                            }
                            else if (inbuffer[i] == V && startStep == 3)
                            {
                                startStep = 4;
                                bMadeData1[3] = inbuffer[i];
                                iMadeDataIndex = 4;
                            }
                            else if(startStep >0)
                            {
                                bMadeData1[iMadeDataIndex++] = inbuffer[i];
                            }
                            
                            if(iMadeDataIndex >= 69)//수신데이터
                            {
                                isbreak =true;
                                break;
                            }
                        }

                         if(isbreak)
                        {
                            break;
                        }
                       
                    }
                        Thread.Sleep(10);
                   
                }//end for

                //end
                rtnRawData = new byte[iMadeDataIndex];// [readInTotalCount];
                Buffer.BlockCopy(bMadeData1, 0, rtnRawData, 0, iMadeDataIndex);
             
            }
            catch (TimeoutException ex)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }
            catch (Exception ex)
            {
                //Debug.WriteLine(ex);
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }
            return rtnRawData;
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] recvData = ReadSerialByteData();
             
                string hex = BitConverter.ToString(recvData);
               
                //01-03-10-00-00-22-AD-00-01-00-0B-00-0A-00-1E-00-54-13-2D-AC-A4
                string[] strRecvData = hex.Split('-');
                string[] hexValue = null;
                long[] lfloathex = null;
                string textValue = "";

                switch (strRecvData[2])
                {
                    case "10"://0x10 노드 정보
                        hexValue = new string[8];
                        lfloathex = new long[8];
                        //Console.WriteLine();

                        if (this.InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                richTextBox1.Text = "";
                            }));
                        }
                        else
                        {
                            richTextBox1.Text = "";
                        }
                        textValue = "";
                        textValue = "노드정보 " + "\n";
                        hexValue[0] = strRecvData[3] + strRecvData[4]; lfloathex[0] = Convert.ToInt64(hexValue[0], 16);
                        textValue += "기관코드 : " + lfloathex[0].ToString() + "\n";
                        hexValue[1] = strRecvData[5] + strRecvData[6]; lfloathex[1] = Convert.ToInt64(hexValue[1], 16);
                        textValue += "회사코드 : " + lfloathex[1].ToString() + "\n";
                        hexValue[2] = strRecvData[7] + strRecvData[8]; lfloathex[2] = Convert.ToInt64(hexValue[2], 16);
                        textValue += "제품타입 : " + lfloathex[2].ToString() + "\n";
                        hexValue[3] = strRecvData[9] + strRecvData[10]; lfloathex[3] = Convert.ToInt64(hexValue[3], 16);
                        textValue += "제품코드 : " + lfloathex[3].ToString() + "\n";
                        hexValue[4] = strRecvData[11] + strRecvData[12]; lfloathex[4] = Convert.ToInt64(hexValue[4], 16);
                        textValue += "프로토콜버전 : " + lfloathex[4].ToString() + "\n";
                        hexValue[5] = strRecvData[13] + strRecvData[14]; lfloathex[5] = Convert.ToInt64(hexValue[5], 16);
                        textValue += "장비연결숫자(채널수) : " + lfloathex[5].ToString() + "\n";
                        hexValue[6] = strRecvData[15] + strRecvData[16]; lfloathex[6] = Convert.ToInt64(hexValue[6], 16);
                        textValue += "노드 시리얼 번호#1 : " + lfloathex[6].ToString() + "\n";
                        hexValue[7] = strRecvData[17] + strRecvData[18]; lfloathex[7] = Convert.ToInt64(hexValue[7], 16);
                        textValue += "노드 시리얼 번호#2 : " + lfloathex[7].ToString() + "\n";


                        if (this.InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                richTextBox1.Text = textValue;
                                richTextBox1.Refresh();
                                logDataCsv.Info("\t[센서노드 정보저장]\t" + richTextBox1.Text.Replace(":", "|").Replace("\n", "|"));

                            }));
                        }
                        else
                        {
                            richTextBox1.Text = textValue;
                            richTextBox1.Refresh();
                            logDataCsv.Info("\t[센서노드 정보저장]\t" + richTextBox1.Text.Replace(":", "|").Replace("\n", "|"));
                        }

                        log.Info("센서 노드에 연결된 노드정보 수집 완료.");
                        break;

                    case "4E"://0x4E 센서값  확인 83
                        hexValue = new string[8];
                        float[] floathex = new float[8];

                        if (this.InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                richTextBox2.Text = "";
                            }));
                        }
                        else
                        {
                            richTextBox2.Text = "";
                        }
                        textValue = "";
                        textValue = "센서값  확인 " + "\n";

                        //들어오는 것을 뒤바꾸고 CCCD 41D0 를 41D0CCCD 로 하고,
                        //hexValue[0] = "41D0CCCD";
                        //Int64 IntRep = Int64.Parse(hexValue[0], NumberStyles.AllowHexSpecifier);
                        //floathex[0] = BitConverter.ToSingle(BitConverter.GetBytes(IntRep), 0);

                        Int64 IntRep = 0;

                        hexValue[0] = strRecvData[5] + strRecvData[6] + strRecvData[3] + strRecvData[4];
                        IntRep = Int64.Parse(hexValue[0], NumberStyles.AllowHexSpecifier);
                        floathex[0] = BitConverter.ToSingle(BitConverter.GetBytes(IntRep), 0);
                        textValue += "온도센서 값 (°C): " + floathex[0].ToString() + "\n";


                        hexValue[1] = strRecvData[23] + strRecvData[24] + strRecvData[21] + strRecvData[22];
                        IntRep = Int64.Parse(hexValue[1], NumberStyles.AllowHexSpecifier);
                        floathex[1] = BitConverter.ToSingle(BitConverter.GetBytes(IntRep), 0);
                        textValue += "습도센서 값(%) : " + floathex[1].ToString() + "\n";

                        hexValue[2] = strRecvData[77] + strRecvData[78] + strRecvData[75] + strRecvData[76];
                        IntRep = Int64.Parse(hexValue[2], NumberStyles.AllowHexSpecifier);
                        floathex[2] = BitConverter.ToSingle(BitConverter.GetBytes(IntRep), 0);
                        textValue += "Co2센서 값(ppm) : " + floathex[2].ToString() + "\n";


                        if (this.InvokeRequired)
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                richTextBox2.Text = textValue;
                                richTextBox2.Refresh();
                                logDataCsv.Info("\t[환경센서 정보저장]\t" + richTextBox2.Text.Replace(":", "|").Replace("\n", "|"));

                            }));
                        }
                        else
                        {
                            richTextBox2.Text = textValue;
                            richTextBox2.Refresh();
                            logDataCsv.Info("\t[환경센서 정보저장]\t" + richTextBox2.Text.Replace(":", "|").Replace("\n", "|"));
                        }

                        log.Info("센서 노드에 연결된 센서정보 수집 완료.");
                        break;
                }

                //        //기관코드 0
                //        //회사코드 8877
                //        //제품타입 1
                //        //제품코드 11
                //        //프로토콜버전 10
                //        //연결장비 숫자 30
                //        //장비시리얼#1 84
                //        //장비시리얼#2 4909

            }
            catch (Exception ex)
            {
                //Debug.WriteLine(ex.ToString());
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }

        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            //Debug.WriteLine(e.ToString());
            log.Error(e.ToString());
        }

        private void serialPort1_PinChanged(object sender, SerialPinChangedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serial1Close();
            Serial2Close();
            log.Info("=============  Closed application  =============");
        }

        private void btnSendNodeInfo1_Click(object sender, EventArgs e)
        {
            log.Info("센서 노드 정보 요청 시작.");
            Serial1Open();

            iCommandNo = 1;
            //01 03 00 01 00 08 15 CC | 노드 정보 HEX
            byte[] bytesToSend = new byte[8] { 0x01, 0x03, 0x00, 0x01, 0x00, 0x08, 0x15, 0xCC };
            //port.Open();
            serialPort1.DiscardOutBuffer();
            serialPort1.DiscardInBuffer();
            serialPort1.Write(bytesToSend, 0, bytesToSend.Length);

        }

        private void btnSendSensorList1_Click(object sender, EventArgs e)
        {
            log.Info("센서 리스트 정보 요청 시작.");
            Serial1Open();
            iCommandNo = 2;
            //01 03 00 65 00 28 55 CB | 센서리스트 HEX
            byte[] bytesToSend = new byte[8] { 0x01, 0x03, 0x00, 0x65, 0x00, 0x28, 0x55, 0xCB };
            serialPort1.DiscardOutBuffer();
            serialPort1.DiscardInBuffer();
            serialPort1.Write(bytesToSend, 0, bytesToSend.Length);
        }

        private void btnSendSensorValue1_Click(object sender, EventArgs e)
        {
            log.Info("센서 노드에 연결된 센서 값 확인 요청 시작.");
            Serial1Open();
            iCommandNo = 3;
            //01 03 00 CB 00 27 74 2E | 센서값 확인 HEX
            byte[] bytesToSend = new byte[8] { 0x01, 0x03, 0x00, 0xCB, 0x00, 0x27, 0x74, 0x2E };
            serialPort1.DiscardOutBuffer();
            serialPort1.DiscardInBuffer();
            serialPort1.Write(bytesToSend, 0, bytesToSend.Length);
        }

        private void btnSendCtrlValue1_Click(object sender, EventArgs e)
        {
            log.Info("센서 노드 제어값 정보 요청 시작.");
            Serial1Open();
            iCommandNo = 4;
            //01 03 01 F7 00 34 F4 13 | 제어값 조회 HEX
            byte[] bytesToSend = new byte[8] { 0x01, 0x03, 0x01, 0xF7, 0x00, 0x34, 0xF4, 0x13 };  //$D0 $F2 $FF $00 $06 $C7
            serialPort1.DiscardOutBuffer();
            serialPort1.DiscardInBuffer();
            serialPort1.Write(bytesToSend, 0, bytesToSend.Length);
        }

        public static String byteToHexString(byte[] byteArray)
        {
            StringBuilder sb = new StringBuilder(byteArray.Length * 2);
            foreach (byte b in byteArray)
            {
                sb.AppendFormat("{0:x2}", b);
            }
            return sb.ToString();
        }

        private void btnSendSensorValue_auto_Click(object sender, EventArgs e)
        {
            log.Info("센서 노드에 연결된 센서 값 자동 확인 요청 시작.");
            timerSensorRecv1.Interval = 1000;
            timerSensorRecv1.Enabled = true;
            timerSensorRecv1.Start();
            btnSendSensorValue_autoStart.Enabled = false;
            btnSendSensorValue_autoStop.Enabled = true;
            btnSendNodeInfo1.Enabled = false;
            btnSendSensorValue1.Enabled = false;
            log.Info("센서 노드에 연결된 센서 값 자동 확인 요청 완료.");
        }

        private void btnSendSensorValue_autoStop_Click(object sender, EventArgs e)
        {
            log.Info("센서 노드에 연결된 센서 값 자동 확인 중지요청 시작.");
            timerSensorRecv1.Enabled = false;
            timerSensorRecv1.Stop();
            btnSendSensorValue_autoStart.Enabled = true;
            btnSendSensorValue_autoStop.Enabled = false;
            btnSendNodeInfo1.Enabled = true;
            btnSendSensorValue1.Enabled = true;
            log.Info("센서 노드에 연결된 센서 값 자동 확인 중지요청 완료.");
        }

        private void timerSensorRecv1_Tick(object sender, EventArgs e)
        {
            if (timerSensorRecv1.Enabled)
            {
                btnSendSensorValue1_Click(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logDataCsv.Info("[센서노드 정보저장]" + richTextBox1.Text.Replace(":", "|").Replace("\n", "|"));
            logDataCsv.Info("[환경센서 정보저장]" + richTextBox2.Text.Replace(":", "|").Replace("\n", "|"));
        }

        private void btnOpenLora_Click(object sender, EventArgs e)
        {
            Serial2Open();
        }

        private void btnCloseLora_Click(object sender, EventArgs e)
        {
            Serial2Close();
        }

        private void btnSendSensorValue1Lora_Click(object sender, EventArgs e)
        {
            log.Info("Lora 센서 노드에 연결된 센서 값 확인 요청 시작.");
            Serial2Open();
            iCommandNo = 3;
            //01 03 00 CB 00 27 74 2E | 센서값 확인 HEX
            //byte[] bytesToSend = new byte[8] { 0x01, 0x03, 0x00, 0xCB, 0x00, 0x27, 0x74, 0x2E };
            //serialPort2.DiscardOutBuffer();
            //serialPort2.DiscardInBuffer();
            //serialPort2.Write(bytesToSend, 0, bytesToSend.Length);
        }

        private void btnSendSensorValueLora_autoStart_Click(object sender, EventArgs e)
        {

        }

        private void btnSendSensorValueLora_autoStop_Click(object sender, EventArgs e)
        {

        }

        private void timerSensorRecv1Lora_Tick(object sender, EventArgs e)
        {

        }


        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] recvData = ReadSerialByteDataLora();

                //strBuffer_ascii >>> RECV:541338:-100:temp ? 22.0, humi ? 27.7, co2 ? 775, time ? 20221222171035

                string strBuffer_ascii = Encoding.ASCII.GetString(recvData);
                strBuffer_ascii = strBuffer_ascii.ToUpper().Trim();
                strBuffer_ascii = strBuffer_ascii + Environment.NewLine;
                Console.WriteLine(strBuffer_ascii.Length);

                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        if(richTextBox4.Text.Length >= 10000)
                        {
                            richTextBox4.Text = "";
                        }
                        richTextBox4.Text += strBuffer_ascii;
                        richTextBox4.Select(richTextBox4.TextLength, 0);
                        richTextBox4.ScrollToCaret();
                        logDataCsv.Info("[환경센서 정보저장][Lora]" + strBuffer_ascii.Replace(":", "|").Replace("\n", "|"));
                    }));
                }
                else
                {
                    if (richTextBox4.Text.Length >= 10000)
                    {
                        richTextBox4.Text = "";
                    }
                    richTextBox4.Text += strBuffer_ascii;
                    richTextBox4.Select(richTextBox4.TextLength, 0);
                    richTextBox4.ScrollToCaret();
                    
                    logDataCsv.Info("[환경센서 정보저장][Lora]" + strBuffer_ascii.Replace(":", "|").Replace("\n", "|"));
                }
                
            }
            catch (Exception ex)
            {
                log.Error($"An exception occurred from {MethodBase.GetCurrentMethod().Name}", ex);
            }

        }

        private void serialPort2_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            log.Error(e.ToString());
        }

        private void serialPort2_PinChanged(object sender, SerialPinChangedEventArgs e)
        {

        }
    }
}

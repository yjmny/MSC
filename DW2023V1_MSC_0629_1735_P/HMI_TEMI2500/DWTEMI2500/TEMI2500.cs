using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using static HMI_TEMI2500.Protocol;

namespace HMI_TEMI2500
{
    public class TEMI2500
    {
        public TEMI2500()
        {
        }

        bool isRunLoopOn = false;
        public void RunLoopSettings()
        {
        }

        public static string ModelName = "TEMP2500 ";


        public static string IP = "";//"192.168.0.100";
        public static string PORT_FIX = "5000";//fix
        private string newLine = "\r\n";

        [Browsable(false)]
        public static bool IsOpen
        {
            get
            {
                return false;
            }
        }
        public byte[] MakeStringToAsciiBytearray(string text)
        {
            if (!IsOpen)
            {
            }

            if (text == null)
            {
                throw new ArgumentNullException("text");
            }

            if (text.Length != 0)
            {
                byte[] string2asciiBytes = asciiEncoding.GetBytes(text);
                return string2asciiBytes;
            }

            return null;
        }

        private void TcpIpSend(byte[] arrbData)
        {
            System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);
            try
            {
                sock.SendTimeout = 3000;
                sock.ReceiveTimeout = 3000;

                System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(System.Net.IPAddress.Parse(IP), int.Parse(PORT_FIX));

                if (sock.IsBound) { sock.Close(); }

                sock.Connect(ipep);
                string sHexData;
                bool isCheckDebug = false;
                bool isDebugLog = false;
                if (sock.Connected)
                {
                    sock.Send(arrbData);

                    if (isCheckDebug)
                    {
                        sHexData = Protocol.ByteArrayToHex(arrbData);

                        if (isDebugLog) { System.Diagnostics.Debug.WriteLine("SEND : " + sHexData); }
                    }

                    byte[] recvData = new byte[1024];
                    int iRecvCnt = sock.Receive(recvData);

                    if (isCheckDebug)
                    {
                        for (int i = 0; i < iRecvCnt; i++)
                        {
                            char a = (char)recvData[i];
                            System.Diagnostics.Debug.Write(a);
                        }
                        sHexData = Protocol.ByteArrayToHex(recvData);
                        if (isDebugLog) { System.Diagnostics.Debug.WriteLine("RECV : " + sHexData); }
                    }

                    if (iRecvCnt > 0)
                    {
                        //명령어에 따른 구분자
                        //RSD
                        if (Protocol.I32RecvTypeCheck == (int)Protocol.I32RecvType.RSD)
                        {
                            int iGetCount = iRecvCnt - 5;//STX(1), SUM(2),CR(1),LF(1) 제외
                            byte[] bytes = new byte[iGetCount];
                            Array.Copy(recvData, 1, bytes, 0, iGetCount);
                            RecvDataParse(bytes);
                        }
                        else if (Protocol.I32RecvTypeCheck == (int)Protocol.I32RecvType.RRD)
                        {
                            int iGetCount = iRecvCnt - 5;//STX(1), SUM(2),CR(1),LF(1) 제외
                            byte[] bytes = new byte[iGetCount];
                            Array.Copy(recvData, 1, bytes, 0, iGetCount);
                            RecvDataParse(bytes);
                        }
                        //WSD
                        else if (Protocol.I32RecvTypeCheck == (int)Protocol.I32RecvType.WSD)
                        {
                            int iGetCount = iRecvCnt - 2;//STX(1), SUM(2),CR(1),LF(1) 제외
                            byte[] bytes = new byte[iGetCount];
                            Array.Copy(recvData, 1, bytes, 0, iGetCount);
                            RecvDataParseCaseWrite(bytes);
                        }
                    }



                }
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message, "HMI 컨트롤러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sock.Close();
            }
        }

        private void RecvDataParseCaseWrite(byte[] bytes)
        {
            string str = Encoding.UTF8.GetString(bytes);
            Console.WriteLine("RecvDataParseCaseWrite String is: " + str);
            str = str.Trim();

            string[] strParse = str.Split(new char[] { (char)Protocol.stx, ',' });
            string stCmdID = strParse[0];
            string strDelimeter = strParse[1];

            if (strDelimeter.Equals("NG"))
            {
                //Error
            }
            else if (strDelimeter.Equals("OK"))
            {
                //exception
            }
            else if (strDelimeter.Equals("OK15"))
            {
                Protocol.RecvDataOK = "15";
            }
        }

        private void RecvDataParse(byte[] bytes)
        {
            string str = Encoding.UTF8.GetString(bytes);
            str = str.Trim();

            string[] strParse = str.Split(new char[] { (char)Protocol.stx, ',' });
            string strCmdID = strParse[0];
            string strDelimeter = strParse[1];


            if (strDelimeter.Equals("NG"))
            {
                //Error
            }
            else if (strDelimeter.Equals("OK"))
            {
                int datas = strParse.Length - 2;

                int[] iDataList = new int[datas];

                for (int i = 2; i < strParse.Length; i++)
                {
                    iDataList[i - 2] = HexStringToDec(strParse[i]);
                }

                StringBuilder sb = new StringBuilder(0, 1024);
                // Command
                double dD1 = 0;
                double dD2 = 0;
                double dD5 = 0;
                double dD6 = 0;

                switch (Protocol.SignalDregister)
                {
                    //② 변환한 값에 0.1을 곱한다. : 500 * 0.1 → 50.0
                    case D_REGISTER.D1:
                        dD1 = iDataList[0];
                        //-300 ~ 100 도
                        //소주점 1 자리 (온도)
                        if (dD1 > 60000) { dD1 = (double)((65536 - dD1) * (-1)); }
                        dD1 = dD1 * 0.1;
                        Protocol.RecvD1 = dD1;
                        break;
                    case D_REGISTER.D2:
                        dD2 = iDataList[0];
                        if (dD2 > 60000) { dD2 = (double)((65536 - dD2) * (-1)); }
                        dD2 = dD2 * 0.1;
                        Protocol.RecvD2 = dD2;
                        break;
                    case D_REGISTER.D5:
                        Protocol.RecvD5 = iDataList[0] * 0.1;
                        break;

                    case D_REGISTER.D6:
                        Protocol.RecvD6 = iDataList[0] * 0.100; //150-> 15.0%-> 메뉴얼은 소수점 1자리, HMI도 소수점 1자리
                        break;
                    case D_REGISTER.D1D5:
                        Protocol.RecvD1 = iDataList[0] * 0.1;
                        Protocol.RecvD5 = iDataList[1] * 0.1;
                        Protocol.RecvD1D5 = Protocol.RecvD1 + "," + Protocol.RecvD5;
                        break;

                    case D_REGISTER.D2D6:
                        dD2 = iDataList[0];
                        if (dD2 > 60000) { dD2 = (double)((65536 - dD2) * (-1)); }
                        dD2 = dD2 * 0.1;

                        dD6 = iDataList[1];
                        if (dD6 > 60000) { dD2 = (double)((65536 - dD6) * (-1)); }
                        dD6 = dD6 * 0.1;

                        Protocol.RecvD2 = dD2;
                        Protocol.RecvD6 = dD6;
                        Protocol.RecvD2D6 = Protocol.RecvD2 + "," + Protocol.RecvD6;
                        break;
                    case D_REGISTER.D1D2D5D6:
                        dD1 = iDataList[0];
                        dD2 = iDataList[1];
                        //-300 ~ 100 도
                        //소주점 1 자리 (온도)
                        if (dD1 > 60000) { dD1 = (double)((65536 - dD1) * (-1)); }
                        dD1 = dD1 * 0.1;

                        if (dD2 > 60000) { dD2 = (double)((65536 - dD2) * (-1)); }
                        dD2 = dD2 * 0.1;

                        dD5 = iDataList[2] * 0.1;  //소주점 1 자리 (습도)
                        dD6 = iDataList[3] * 0.1;  //소주점 1 자리 (습도)

                        Protocol.RecvD1 = dD1;
                        Protocol.RecvD2 = dD2;
                        Protocol.RecvD5 = dD5;
                        Protocol.RecvD6 = dD6;
       
                        sb.Append(Protocol.RecvD1);sb.Append(comma);
                        sb.Append(Protocol.RecvD2); sb.Append(comma);
                        sb.Append(Protocol.RecvD5); sb.Append(comma);
                        sb.Append(Protocol.RecvD6);

                        Protocol.RecvD1D2D5D6 = sb.ToString();// Protocol.RecvD1 + "," + Protocol.RecvD2 + "," + Protocol.RecvD5 + "," + Protocol.RecvD6;
       
                        break;
                    case D_REGISTER.D1D2D5D6D24D25D26:

                        Protocol.RecvD1 = iDataList[0] * 0.1;
                        Protocol.RecvD2 = iDataList[1] * 0.1;
                        Protocol.RecvD5 = iDataList[2] * 0.1;
                        Protocol.RecvD6 = iDataList[3] * 0.1;
                        Protocol.RecvD24 = iDataList[4];
                        Protocol.RecvD25 = iDataList[5];
                        Protocol.RecvD26 = iDataList[6];
                        Protocol.RecvD1D2D5D6D24D25D26 = Protocol.RecvD1 + "," + Protocol.RecvD2 + "," + Protocol.RecvD5 + "," + Protocol.RecvD6 + "," + Protocol.RecvD24 + "," + Protocol.RecvD25 + "," + Protocol.RecvD26;
                        break;
                    case D_REGISTER.D7:
                        Protocol.RecvD7 = iDataList[0] * 0.010;//30도 -> 메뉴얼과 다름...
                        break;
                    case D_REGISTER.D8:
                        Protocol.RecvD8 = iDataList[0] * 0.010;//30도 -> 메뉴얼과 다름...
                        break;
                    case D_REGISTER.D10:
                        Protocol.RecvD10 = iDataList[0];
                        break;
                    case D_REGISTER.D24:
                        Protocol.RecvD24 = iDataList[0];
                        break;
                    case D_REGISTER.D25:
                        Protocol.RecvD25 = iDataList[0];
                        break;
                    case D_REGISTER.D26:
                        Protocol.RecvD26 = iDataList[0];
                        break;
                    case D_REGISTER.D24D25D26:

                        string strHH = strParse[2];//0000
                        string strMM = strParse[3];//000C
                        string strSS = strParse[4];//001B
                        Protocol.RecvD24 = string.Format("{0:D2}", Protocol.HexStringToDec(strHH));
                        Protocol.RecvD25 = string.Format("{0:D2}", Protocol.HexStringToDec(strMM));
                        Protocol.RecvD26 = string.Format("{0:D2}", Protocol.HexStringToDec(strSS));
                        Protocol.RecvD24D25D26 = Protocol.RecvD24 + ":" + Protocol.RecvD25 + ":" + Protocol.RecvD26;
                        break;
                    case D_REGISTER.D104:
                        Protocol.RecvD104 = iDataList[0];
                        break;
                    case D_REGISTER.D1708:
                        Protocol.RecvD1708 = iDataList[0];
                        break;
                    case D_REGISTER.D1725_TO_D1733:
                        //-----------------------------------------------
                        //-300 ~ 100 도
                        dD1 = iDataList[0];
                        if (dD1 > 3000) { dD1 = (double)((65536 - dD1) * (-1)); }
                        dD1 = dD1 * 0.1;
                        dD2 = iDataList[1] * 0.1;

                        Protocol.RecvD1725 = dD1;
                        Protocol.RecvD1726 = dD2;

                        //-----------------------------------------------
                        Protocol.RecvD1727 = iDataList[2];//시
                        double dmmss = 0;
                        double dMinute = 0;
                        double dSec = 0;
                        if (iDataList[3] == 65535)//분,초 == > 65535 이면 -1 (설정안됨)
                        {
                            dmmss = -1;
                        }
                        else
                        {
                            dmmss = iDataList[3];
                            if (dmmss < 60)
                            {
                                dMinute = 0;
                                dSec = dmmss % 60;
                            }
                            else
                            {
                                dMinute = Math.Truncate(dmmss / 60);
                                dSec = dmmss % 60;
                            }
                        }
                        Protocol.RecvD1728 = dmmss;
                        //-----------------------------------------------
                        Protocol.RecvD1729 = iDataList[4];//TS1
                        Protocol.RecvD1730 = iDataList[5];//TS2
                        Protocol.RecvD1731 = iDataList[6];//TS3
                        Protocol.RecvD1732 = iDataList[7];//TS4
                        Protocol.RecvD1733 = iDataList[8];//Wait
                        string sData1 = "";
                        for (int i = 0; i < iDataList.Length; i++)
                        {
                            if (i == 0)
                            {
                                sData1 = sData1 + dD1.ToString() + ",";
                            }
                            else if (i == 1)
                            {
                                sData1 = sData1 + dD2.ToString() + ",";
                            }
                            else if (i == 3)
                            {
                                if (dmmss == -1)
                                { sData1 = sData1 + dmmss.ToString() + ","; }
                                else
                                { sData1 = sData1 + string.Format("{0:D2}", (int)dMinute) + string.Format("{0:D2}", (int)dSec) + ","; }
                            }
                            else
                                sData1 = sData1 + iDataList[i] + ",";
                        }
                        Protocol.RecvD1725_TO_D1733 = sData1;
                        //-----------------------------------------------
                        break;
                }
                sb = null;
            }
        }


        private int CharToHexDecimal(char val)
        {
            int res = 0;
            int tmp = 0;
            switch (val)
            {
                case 'A':
                    tmp = 10;
                    break;
                case 'B':
                    tmp = 11;
                    break;
                case 'C':
                    tmp = 12;
                    break;
                case 'D':
                    tmp = 13;
                    break;
                case 'E':
                    tmp = 14;
                    break;
                case 'F':
                    tmp = 15;
                    break;
                default:
                    tmp = val - '0';
                    break;
            }
            res += tmp;
            return res;
        }


        private void TcpIpRecv()
        {
            System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

            sock.SendTimeout = 3000;
            sock.ReceiveTimeout = 300;

            System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(IP);
            int serverPort = int.Parse(PORT_FIX);
            System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

            if (sock.IsBound) { sock.Close(); }

            try
            {
                sock.Connect(ipep);

                while (isRunLoopOn)
                {
                    if (sock.Connected)
                    {
                        byte[] recvData = new byte[4096];
                        int recvInt = sock.Receive(recvData);

                        //Parsing....
                        //    Received_Data_Processing_BIT_READ_CONTINUE(recvData);
                        Protocol.WaitDelayFromMilliseconds(100);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally { sock.Close(); }

        }
        private static Encoding asciiEncoding = Encoding.ASCII;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [MonitoringDescription("Encoding")]
        public static Encoding Encoding
        {
            get
            {
                return asciiEncoding;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Encoding");
                }

                if (!(value is ASCIIEncoding) && !(value is UTF8Encoding) && !(value is UnicodeEncoding) && !(value is UTF32Encoding) && ((value.CodePage >= 50000 && value.CodePage != 54936) || !(value.GetType().Assembly == typeof(string).Assembly)))
                {

                }
            }
        }

        public void Write(byte[] buffer, int offset, int count)
        {
            if (!IsOpen)
            {
                //throw new InvalidOperationException(SR.GetString("Port_not_open"));
            }

            if (buffer == null)
            {
                //throw new ArgumentNullException("buffer", SR.GetString("ArgumentNull_Buffer"));
            }

            if (offset < 0)
            {
                // throw new ArgumentOutOfRangeException("offset", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
            }

            if (count < 0)
            {
                // throw new ArgumentOutOfRangeException("count", SR.GetString("ArgumentOutOfRange_NeedNonNegNumRequired"));
            }

            if (buffer.Length - offset < count)
            {
                //throw new ArgumentException(SR.GetString("Argument_InvalidOffLen"));
            }

            if (buffer.Length != 0)
            {
                TcpIpSend(buffer);
            }
        }

        [Browsable(false)]
        [DefaultValue("\n")]
        [MonitoringDescription("NewLine")]
        public string NewLine
        {
            get
            {
                return newLine;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                if (value.Length == 0)
                {
                }

                newLine = value;
            }
        }



        private void SendMessage_Write(byte[] sendFrame)
        {
            System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

            sock.SendTimeout = 3000;
            sock.ReceiveTimeout = 300;

            System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(IP);
            int serverPort = int.Parse(PORT_FIX);
            System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

            if (sock.IsBound) { sock.Close(); }

            sock.Connect(ipep);
            if (sock.Connected)
            {
                sock.Send(sendFrame);

                //Log 추가

                sock.Close();
            }
        }

        /// <summary>
        /// CRC 코드 생성
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public byte MakeCRC_checkSum(byte[] data)
        {
            byte crc = 0xF;
            //ushort sum = 0;
            ushort sum = 0;
            for (int pos = 0; pos < data.Length; pos++)
            {
                sum = (ushort)(sum + data[pos]);//713

            }
            crc = (byte)(sum & 0xff);//201
            return crc;
        }

        public byte[] MakeByteData(string sData)
        {
            try
            {
                byte[] baStep1 = Encoding.ASCII.GetBytes(sData);
                string strCrc2Byte = MakeCRCToString(baStep1);
                string strCrcLow = MakeParseCrc(strCrc2Byte);

                string sData2 = sData + strCrcLow;
                byte[] baStep2 = Encoding.ASCII.GetBytes(sData2);
                byte[] baStep3 = new byte[baStep2.Length + 3];
                baStep3[0] = Protocol.stx;
                Array.Copy(baStep2, 0, baStep3, 1, baStep2.Length);


                baStep3[baStep3.Length - 2] = Protocol.cr;
                baStep3[baStep3.Length - 1] = Protocol.lf;

                bool isCheck = false;
                if (isCheck)
                {
                    string sHexData = Protocol.ByteArrayToHex(baStep3);
                    System.Diagnostics.Debug.WriteLine(sHexData);
                }
                return baStep3;
            }
            catch
            {
                return null;
            }
        }

        public byte MakeByteCRC(byte[] data)
        {
            byte crc = 0xF;
            //ushort sum = 0;
            ushort sum = 0;
            for (int pos = 0; pos < data.Length; pos++)
            {
                sum = (ushort)(sum + data[pos]);//713

            }
            crc = (byte)(sum & 0xff);//201 //2C9 -> C9
                                     // char crcChar = (char)crc;

            return crc;
        }
        private byte[] MakeByteCRC_2byte(byte[] data)
        {
            byte[] crcA = new byte[2];
            ushort sum = 0;
            for (int pos = 0; pos < data.Length; pos++)
            {
                sum = (ushort)(sum + data[pos]);//713

            }
            crcA[0] = (byte)(sum & 0xf);
            crcA[1] = (byte)(sum & 0xff);//201 //2C9 -> C9
                                         // char crcChar = (char)crc;

            return crcA;
        }
        private string MakeCRCToString(byte[] data)
        {
            byte[] value = MakeByteCRC_2byte(data);


            int num = value.Length * 3;
            char[] array = new char[num];
            int startIndex = 0;
            int num2 = 0;
            int num3 = startIndex;
            for (num2 = 0; num2 < num; num2 += 3)
            {
                byte b = value[num3++];
                array[num2] = GetHexValue((int)b / 16);
                array[num2 + 1] = GetHexValue((int)b % 16);
                array[num2 + 2] = '-';
            }
            string hashHex = new string(array, 0, array.Length - 1);
            return hashHex;
        }

        private string MakeParseCrc(string str)
        {
            string[] str1 = str.Split('-');
            return str1[1];
        }

        private char GetHexValue(int i)
        {
            if (i < 10) { return (char)(i + 48); }

            return (char)(i - 10 + 65);
        }
        public string MakeCRC_checksum(byte[] data)
        {
            byte crc = 0xF;
            ushort sum = 0;
            for (int pos = 0; pos < data.Length; pos++)
            {
                sum = (ushort)(sum + data[pos]);//713

            }
            crc = (byte)(sum & 0xff);//201 //2C9 -> C9  // char crcChar = (char)crc;

            return ByteToString(crc);
        }
        private string ByteToString(byte bValue)
        {
            Char c = (Char)bValue;
            return Char.ToString(c);
        }
        private void writeRichTextbox(string str)  // richTextbox1 에 쓰기 함수
        {
           
        }
        

    }
}

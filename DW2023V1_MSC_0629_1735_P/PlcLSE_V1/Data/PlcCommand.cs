using DBMS_V1;
using NetworkLib;
using System;
using System.Text;

namespace PlcLSE_V1.Data
{

    public class PlcComm
    {

        public PlcComm(string ip = "192.168.1.100", int port = 2004)
        {
            mstrNwPlcIp = ip;
            miNwPlcPort_tcpip = port;

            readBitEach = new ReadBitEach();
            readByteEach = new ReadByteEach();
            readWordEach = new ReadWordEach();
            readDwordEach = new ReadDwordEach();

            readBitStream = new ReadBitStream();
            readWordStream = new ReadWordStream();

            writeBitEach = new WriteBitEach();
            writeByteEach = new WriteByteEach();
            writeWordEach = new WriteWordEach();
            writeDwordEach = new WritDwordEach();

            writeBitStream = new WriteBitStream();
            writeWordStream = new WriteWordStream();
        }

        //--------------------------------------------------------------------------------------------------------------------------------
        //개별 읽기
        ReadBitEach readBitEach = null;
        ReadByteEach readByteEach = null;
        ReadWordEach readWordEach = null;
        ReadDwordEach readDwordEach = null;
        //--------------------------------------------------------------------------------------------------------------------------------
        //연속 읽기
        ReadBitStream readBitStream = null;
        ReadWordStream readWordStream = null;
        //--------------------------------------------------------------------------------------------------------------------------------
        //개별 쓰기
        WriteBitEach writeBitEach = null;
        WriteByteEach writeByteEach = null;
        WriteWordEach writeWordEach = null;
        WritDwordEach writeDwordEach = null;
        //--------------------------------------------------------------------------------------------------------------------------------
        //연속 쓰기
        WriteBitStream writeBitStream = null;
        WriteWordStream writeWordStream = null;
        //--------------------------------------------------------------------------------------------------------------------------------
        private String mstrNwPlcIp;
        private int miNwPlcPort_tcpip;
        //int mbno;


        NetworkDTO nwdto = new NetworkDTO();
        MySqlDTO msdto = new MySqlDTO();


        private byte[] MakeHeader(byte[] dataFrame)
        {

            //byte[] FrameHeader = null;
            string company_id = "LSIS-XGT";
            byte[] FrameHeader = System.Text.Encoding.Default.GetBytes(company_id);

            //reserved - 예비
            byte RESERVE01 = 0x00;
            //byte RESERVE02 = 0x00;
            byte PLC_INFO_CLIENT = 0x00;// client_to_server : dontcare
            byte PLC_INFO_SERVER = 0x00;// server_to_client : 0x00
            byte INVOKE_ID01 = 0x00;//프레임간 구변 ID
            byte INVOKE_ID02 = 0x00;

            byte XGB_MK = 0xB0;
            byte HMI_TO_PLC = 0x33;
            //byte PLC_TO_MHI = 0x11;
            byte[] cpu_info = new byte[] { RESERVE01, XGT.HexTag.H00, PLC_INFO_CLIENT, PLC_INFO_SERVER, XGB_MK, HMI_TO_PLC, INVOKE_ID01, INVOKE_ID02 };
            FrameHeader = ByteCombine(FrameHeader, cpu_info);

            byte[] length = new byte[] { (byte)dataFrame.Length, XGT.HexTag.H00 };
            FrameHeader = ByteCombine(FrameHeader, length);

            byte[] FEnetPosition = new byte[] { 0x01 };
            FrameHeader = ByteCombine(FrameHeader, FEnetPosition);

            byte[] Reserved2_BCC = new byte[1];
            ushort crc = MakeCRC(FrameHeader);
            Reserved2_BCC[0] = (byte)crc;
            FrameHeader = ByteCombine(FrameHeader, Reserved2_BCC);

            return FrameHeader;


            //LSIS 고유번호 : LSIS-XGT 시리즈
            //Company ID - 10byte
            //PLC Info - 2byte
            //CPU Info - 1byte
            //Source Of Frame - 1byte
            //Invoke ID - 2byte
            //Length - 2byte
            //FEnet Position - 1 Byte
            //Reserved2(BCC) - 1byte
            //XGB(MK)
            //PC->PLC
            //인식번호(0번)
            //PLC 타입
            //XGK(0xA0), XGB(MK)(0xB0), XGI(0xA4), XGB(0xB4),XGR(0xA8)
        }

        /// <summary>
        /// CRC 코드 생성
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private ushort MakeCRC(byte[] data)
        {
            ushort crc = 0xFFFF;
            for (int pos = 0; pos < data.Length; pos++)
            {
                crc ^= (UInt16)data[pos];// crc = crc ^ (UInt16)data[pos]; 
                for (int i = 8; i != 0; i--)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;
                    }
                    else
                    { crc >>= 1; }
                }
            }
            return crc;
        }

        private string SelectMapName(string text)
        {
            string mapName = "";
            switch (text)
            {
                case "P": mapName = XGT.MEMDEVICE.P; break;
                case "M": mapName = XGT.MEMDEVICE.M; break;
                case "L": mapName = XGT.MEMDEVICE.L; break;
                case "F": mapName = XGT.MEMDEVICE.F; break;
                case "K": mapName = XGT.MEMDEVICE.K; break;
                case "C": mapName = XGT.MEMDEVICE.C; break;
                case "D": mapName = XGT.MEMDEVICE.D; break;
                case "T": mapName = XGT.MEMDEVICE.T; break;
                case "N": mapName = XGT.MEMDEVICE.N; break;
                case "R": mapName = XGT.MEMDEVICE.R; break;
                case "S": mapName = XGT.MEMDEVICE.S; break;
                case "W": mapName = XGT.MEMDEVICE.W; break;
            }
            return mapName;
        }



        //private bool StringCheck(string strValue)
        //{
        //    return string.IsNullOrEmpty(strValue);
        //}

        //-------------------Byte-------------------------------------------------------------------------------------------------------

        /// <summary>
        /// 변수 길이 (0x0005 : 5개(%MB20))
        /// </summary>
        /// <param name="v"></param>
        /// <param name="varBlock"></param>
        /// <returns></returns>
        private byte[] MakeBlock_BYTE(string varName, byte[] varBlock)
        {
            //byte[] varLengh = new byte[2] { 0x05, XGT.TAG_HEX.H00 };
            byte[] varLengh = new byte[2] { (byte)varName.Length, XGT.HexTag.H00 };
            varBlock = ByteCombine(varBlock, varLengh);

            byte[] varFrame = System.Text.Encoding.Default.GetBytes(varName);
            varBlock = ByteCombine(varBlock, varFrame);
            return varBlock;
        }

        private byte[] ByteCombine(byte[] a, byte[] b)
        {
            byte[] c = new byte[a.Length + b.Length];
            Buffer.BlockCopy(a, 0, c, 0, a.Length);
            Buffer.BlockCopy(b, 0, c, a.Length, b.Length);
            return c;
        }

        //---------------싱글워드---------------------------------------------------------------------------------------------------------
        private byte[] MakeDataFrame_WORD(string mapName, string mapIndex)
        {
            //읽기 명령 0x54, 0x00
            //WORD   0x02, 0x00
            //예비  0x00, 0x00,
            //변수 개수 3
            byte[] dateFrame = new byte[] {
                XGT.HexTag.READ, XGT.HexTag.H00,
                XGT.HexDataType.WORD, XGT.HexTag.H00,
                0x00, XGT.HexTag.H00,
                //0x03, XGT.TAG_HEX.H00 };
                0x01, XGT.HexTag.H00 };
            byte[] dataBlock = MakeVariableBlock_WORD(mapName, mapIndex);
            dateFrame = ByteCombine(dateFrame, dataBlock);
            return dateFrame;
        }

        private byte[] MakeVariableBlock_WORD(string getMapName, string mapIndex)
        {
            byte[] varBlock = new byte[0];

            string mapName = SelectMapName(getMapName);// TB_MAP_NAME.Text);
            string mapAddr = mapIndex;// TB_MAP_ADDR.Text;
            varBlock = MakeBlock_BYTE(mapName + XGT.DATATYPE_STRING.WORD + mapAddr, varBlock);

            return varBlock;
        }

        private string SendMessage_Read_WORD(byte[] sendFrame, int printLocUi0)//, string mapAddr)
        {
            System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

            sock.SendTimeout = 3000;
            sock.ReceiveTimeout = 3000;

            System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
            int serverPort = miNwPlcPort_tcpip;
            System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

            string strRtn = "";
            try
            {

                if (sock.IsBound) { sock.Close(); }

                sock.Connect(ipep);
                if (sock.Connected)
                {
                    sock.Send(sendFrame);
                    byte[] recvData = new byte[100];// 2048];// [2048];
                    sock.Receive(recvData);

                    if (printLocUi0 == 0)
                    {
                        strRtn = Received_Data_Processing_WORD(recvData);//, mapAddr);
                    }
                    else
                    {
                        short Datas = BitConverter.ToInt16(recvData, 32);
                        strRtn = Datas.ToString();
                    }

                }
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc);
            }
            finally { sock.Close(); }

            return strRtn;
        }


        private string Received_Data_Processing_WORD(byte[] Rdata)//, string Addr)
        {
            short Datas = BitConverter.ToInt16(Rdata, 32);
            return Datas.ToString();


            //if (Addr.Equals("D700"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    txbAI01.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D702"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    txbAI02.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D704"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    txbAI03.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D706"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    txbAI04.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D708"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    txbAI05.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D710"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    txbAI06.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D712"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    txbAI07.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D714"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    txbAI08.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D716"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    txbAI09.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D718"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    txbAI10.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D720"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    txbAI11.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D722"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    txbAI12.Text = Datas.ToString();
            //}


        }

        //--------------------더블워드---------------------------------------------------------------------------------------------------
        private byte[] MakeDataFrame_DOUBLEWORD(string getMapName, string getMapAddr)
        {
            //읽기 명령 0x54, 0x00
            //DWORD(double word)   0x03, 0x00
            //예비  0x00, 0x00,
            //변수(블록) 개수 2
            byte[] dateFrame = new byte[] {
                XGT.HexTag.READ, XGT.HexTag.H00,
                XGT.HexDataType.DWORD, XGT.HexTag.H00,
                0x00, XGT.HexTag.H00,
                //0x02, XGT.TAG_HEX.H00 };
                  0x01, XGT.HexTag.H00 };
            byte[] dataBlock = MakeVariableBlock_DOUBLEWORD(getMapName, getMapAddr);
            dateFrame = ByteCombine(dateFrame, dataBlock);
            return dateFrame;
        }

        private byte[] MakeVariableBlock_DOUBLEWORD(string getMapName, string getMapAddr)
        {
            //실제 어드레스/2 : Double word, D0->D0, D10->D05 ????
            byte[] varBlock = new byte[0];
            //varBlock = MakeBlock_BYTE("%DD00", varBlock);
            //varBlock = MakeBlock_BYTE("%DD05", varBlock);

            string mapName = SelectMapName(getMapName);// TB_MAP_NAME.Text);
            string mapAddr = getMapAddr;// TB_MAP_ADDR.Text;
            //varBlock = MakeBlock_BYTE(XGT.MEMDEVICE.D + XGT.DATATYPE_STRING.DWORD + "00", varBlock);
            varBlock = MakeBlock_BYTE(mapName + XGT.DATATYPE_STRING.DWORD + mapAddr, varBlock);
            //varBlock = MakeBlock_BYTE(XGT.MEMORY.D + XGT.DATA_TYPE.DWORD + "05", varBlock);
            return varBlock;
        }

        private string SendMessage_Read_DOUBLEWORD(byte[] sendFrame, string sInt32_Float)
        {
            System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

            sock.SendTimeout = 3000;
            sock.ReceiveTimeout = 3000;

            System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
            int serverPort = miNwPlcPort_tcpip;
            System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

            if (sock.IsBound) { sock.Close(); }

            string strRtn = "";
            try
            {
                sock.Connect(ipep);
                if (sock.Connected)
                {
                    sock.Send(sendFrame);
                    byte[] recvData = new byte[256];
                    sock.Receive(recvData);
                    strRtn = Received_Data_Processing_DOUBLEWORD(recvData, sInt32_Float);

                }
            }
            catch (Exception exc) { System.Diagnostics.Debug.WriteLine(exc.ToString()); }
            finally
            {
                sock.Close();
            }
            return strRtn;
        }

        private string Received_Data_Processing_DOUBLEWORD(byte[] Rdata, string sInt32_Float)
        {
            string strRtn;// = "";

            //for(int i=0; i<Rdata.Length;i++)
            //{
            //    System.Diagnostics.Debug.WriteLine(i+": " + Rdata[i]);
            //}

            if (sInt32_Float.Equals("FLOAT"))
            {
                float Datas = BitConverter.ToSingle(Rdata, 32);
                strRtn = Datas.ToString();
            }
            else
            {
                int Datas = BitConverter.ToInt32(Rdata, 32);
                strRtn = Datas.ToString();
            }

            return strRtn;
        }

        //private string Received_Data_Processing_DOUBLEWORD(byte[] Rdata)
        //{
        //    int Datas = BitConverter.ToInt32(Rdata, 32);
        //    return Datas.ToString();
        //}


        /// <summary>
        /// 검정센서1
        /// </summary>
        /// <returns></returns>
//-----------------------------------공통-----------------------------------------------------------------------------------

        public int IsConnect()
        {
            //         private String mstrNwPlcIp;
            //private int miNwPlcPort_tcpip;

            //string strNowTime = String.Empty;
            //string strTimeFormat = "yyyyMMddHHmmssfff";
            String strIp = mstrNwPlcIp;
            String strPort = miNwPlcPort_tcpip.ToString();

            //string strNowTime = DateTime.Now.ToString(strTimeFormat);
            int iRtn = nwdto.SendToPing(strIp);
            //System.Diagnostics.Trace.WriteLine(iRtn);
            if (iRtn == 0) { return iRtn; }
            iRtn = nwdto.SendToTcping(strIp, strPort, 3000);

            return iRtn;
        }


        //--------------------일괄측정--------------------------------------------------------------------------------------------------
        private void AIChannel1to12()
        {
            string[] mapAddr = new string[] { "D700", "D702", "D704", "D706", "D708", "D710", "D712", "D714", "D716", "D718", "D720", "D722" };

            string getMapName = mapAddr[0].Substring(0, 1); //D

            for (int i = 0; i < mapAddr.Length; i++)
            {
                string getMapAddr = mapAddr[i].Substring(1); //123
                //System.Diagnostics.Debug.WriteLine(getMapName);

                byte[] DataFrame = MakeDataFrame_WORD(getMapName, getMapAddr);
                byte[] SendFrame = MakeHeader(DataFrame);
                SendFrame = ByteCombine(SendFrame, DataFrame);
                string mapAddr_final = getMapName + getMapAddr;
                SendMessage_Read_AI(SendFrame, 0);//, mapAddr_final);
            }

        }

        private string SendMessage_Read_AI(byte[] sendFrame, int printLocUi0)//, string mapAddr_final)
        {
            System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

            sock.SendTimeout = 3000;
            sock.ReceiveTimeout = 3000;

            //System.Net.IPAddress serverIP = System.Net.IPAddress.Parse("127.0.0.1");//여기 주소 입력 10.10.10.100
            System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
            int serverPort = miNwPlcPort_tcpip;
            System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);
            string strRtn = "";
            try
            {
                if (sock.IsBound) { sock.Close(); }

                sock.Connect(ipep);
                if (sock.Connected)
                {
                    sock.Send(sendFrame);
                    byte[] recvData = new byte[256];
                    sock.Receive(recvData);

                    if (printLocUi0 == 0)
                    {
                       // Received_Data_Processing_AI(recvData, mapAddr_final);
                    }
                    else
                    {
                        short Datas = BitConverter.ToInt16(recvData, 32);
                        strRtn = Datas.ToString();
                    }

                }
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine(exc);
            }
            finally { sock.Close(); }
            return strRtn;
        }


        //private void Received_Data_Processing_AI(byte[] Rdata, string Addr)
        //{
            //if (Addr.Equals("D700"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    AI01.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D702"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    AI02.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D704"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    AI03.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D706"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    AI04.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D708"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    AI05.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D710"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    AI06.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D712"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    AI07.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D714"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    AI08.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D716"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    AI09.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D718"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    AI10.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D720"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    AI11.Text = Datas.ToString();
            //}
            //if (Addr.Equals("D722"))
            //{
            //    short Datas = BitConverter.ToInt16(Rdata, 32);
            //    AI12.Text = Datas.ToString();
            //}

        //}

        //-------------개별측정-------------------------------------------------------------------------------------------------------

        /// <summary>
        /// 메뉴 리스트 중 하나를 클릭할 때 이벤트
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIndividualCheck_Click()
        {
            string mapAddr = "";
            
            string getMapName = mapAddr.Substring(0, 1); //D
            string getMapAddr = mapAddr.Substring(1); //123

            //System.Diagnostics.Debug.WriteLine(getMapName);

            byte[] DataFrame = MakeDataFrame_WORD(getMapName, getMapAddr);
            byte[] SendFrame = MakeHeader(DataFrame);
            SendFrame = ByteCombine(SendFrame, DataFrame);
            SendMessage_Read_WORD(SendFrame, 0);//, mapAddr);
        }



        //-------------PLC쓰기------------------------------------------------------------------------------------------------------------
        public void WriteByte(string Address, string setValue)
        {
            string str1 = Address;
            string str2 = setValue;

            string[] arrAddress = new string[2];
            arrAddress[0] = str1.Substring(0, 1);
            arrAddress[1] = str1.Substring(1);
            string strSetValue = str2;

            byte[] arrbPacket = XGT.MakeWriteByteOneData(arrAddress, strSetValue);
            SendMessage_Write(arrbPacket);
        }

        public void WriteWord16bit(string Address, string setValue)
        {
            string str1 = Address;
            string str2 = setValue;
            string[] arrAddress = new string[2];
            arrAddress[0] = str1.Substring(0, 1);//D
            arrAddress[1] = str1.Substring(1);//123

            string strSetValue = str2;
            byte[] arrbPacket = XGT.MakeWriteWordOneData(arrAddress, strSetValue);
            SendMessage_Write(arrbPacket);

        }

        public void WriteDword32bit(string Address, string setValue, string sInt32_Float)
        {
            string str1 = Address;
            string str2 = setValue;
            string[] arrAddress = new string[2];
            arrAddress[0] = str1.Substring(0, 1);
            arrAddress[1] = str1.Substring(1);
            string strSetValue = str2;
            byte[] arrbPacket = XGT.MakeWriteDoubleWordOneData(arrAddress, strSetValue, sInt32_Float);
            SendMessage_Write(arrbPacket);

        }

        private void SendMessage_Write(byte[] sendFrame)
        {
            System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

            sock.SendTimeout = 3000;
            sock.ReceiveTimeout = 3000;

            System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
            int serverPort = miNwPlcPort_tcpip;
            System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

            if (sock.IsBound) { sock.Close(); }

            sock.Connect(ipep);
            if (sock.Connected)
            {
                sock.Send(sendFrame);
                sock.Close();
            }
        }

        //----------------PLC읽기----------------------------------------------------------------------------------------------------------
        public string ReadWord16bit(string Address)
        {
            string mapAddr = Address;
            string getMapName = mapAddr.Substring(0, 1); //D
            string getMapAddr = mapAddr.Substring(1); //123

            //System.Diagnostics.Debug.WriteLine(getMapName);

            byte[] DataFrame = MakeDataFrame_WORD(getMapName, getMapAddr);
            byte[] SendFrame = MakeHeader(DataFrame);
            SendFrame = ByteCombine(SendFrame, DataFrame);
            return SendMessage_Read_WORD(SendFrame, 0);//, "");
        }

        public string ReadDword32bit(string Address, string sInt32_Float)
        {
            string mapAddr = Address;
            string getMapName = mapAddr.Substring(0, 1);
            string getMapAddr = mapAddr.Substring(1);
            byte[] DataFrame = MakeDataFrame_DOUBLEWORD(getMapName, getMapAddr);
            byte[] SendFrame = MakeHeader(DataFrame);
            SendFrame = ByteCombine(SendFrame, DataFrame);
            return SendMessage_Read_DOUBLEWORD(SendFrame, sInt32_Float);
        }

        //-----------------------------------------------------------------------------
        internal string ReadBitEachRun(string[] addrMapList)
        {
            string strRtn;// = "";
            int iDataCount = addrMapList.Length;
            byte[] dataFrame = readBitEach.MakeDataFrame(iDataCount);

            byte[] dataBlock = readBitEach.MakeVariableBlock(addrMapList);
            dataFrame = XGT.ByteCombine(dataFrame, dataBlock);

            byte[] sendFrame = XGT.MakeSendData(dataFrame);
            strRtn = readBitEach.SendMessage(mstrNwPlcIp, miNwPlcPort_tcpip, sendFrame, iDataCount);
            return strRtn;
        }

        internal string ReadBitStreamRun(string[] addrMapList)
        {
           // string strRtn = "";
            int iDataCount = addrMapList.Length;
            byte[] dataFrame = readBitStream.MakeDataFrame(iDataCount, addrMapList);
            byte[] sendFrame = XGT.MakeSendData(dataFrame);

            string strRtn = readBitStream.SendMessage(mstrNwPlcIp, miNwPlcPort_tcpip, sendFrame);//, iDataCount);
            return strRtn;
        }

        internal string WriteBitEachRun(string[] addrMapList, int setValue)
        {
            //string strRtn = "";
            int iDataCount = addrMapList.Length;
            byte[] dataFrame = writeBitEach.MakeDataFrame(iDataCount, addrMapList, setValue: setValue);
            byte[] sendFrame = XGT.MakeSendData(dataFrame);

            string strRtn = writeBitEach.SendMessage(mstrNwPlcIp, miNwPlcPort_tcpip, sendFrame);//, iDataCount);
            return strRtn;
        }

        //byte[] Int32To16bit(int getValue)
        //{
        //    byte[] data = new byte[2];

        //    data[0] = (byte)((getValue >> 8) & 0x000000ff);
        //    data[1] = (byte)(getValue & 0x000000ff);

        //    return data;
        //}

        internal string WriteBitStreamRun(string[] addrMapList, string setValue)
        {
            //string strRtn = "";
            int iDataCount = addrMapList.Length;

            byte[] setData_16bit = new byte[16];
            for (int k = 0, i = setValue.Length - 1; i > 0; i--, k++)
            {
                //System.Diagnostics.Debug.WriteLine(setValue[i]);
                setData_16bit[k] = (byte)(setValue[i].Equals('1') ? 0x01 : 0x00);
            }

            byte[] dataFrame = writeBitStream.MakeDataFrame(addrMapList, setData_16bit);//, iDataCount);
            byte[] sendFrame = XGT.MakeSendData(dataFrame);

            string strRtn = writeBitStream.SendMessage(mstrNwPlcIp, miNwPlcPort_tcpip, sendFrame);//, iDataCount);
            return strRtn;
        }

        internal string ReadDwordEachRun(string[] addrMapList, string[] strArry_int32_float)
        {
            //string strRtn = "";
            int iDataCount = addrMapList.Length;
            byte[] dataFrame = readDwordEach.MakeDataFrame(iDataCount, addrMapList);

            byte[] sendFrame = XGT.MakeSendData(dataFrame);

            return readDwordEach.SendMessage(mstrNwPlcIp, miNwPlcPort_tcpip, sendFrame, iDataCount, strArry_int32_float);
        }

        internal string ReadWordStreamRun(string[] addrMapList)
        {
            //string strRtn = "";
            int iDataCount = addrMapList.Length;
            byte[] dataFrame = readWordStream.MakeDataFrame(addrMapList);//, iDataCount);

            byte[] sendFrame = XGT.MakeSendData(dataFrame);

            string strRtn = readWordStream.SendMessage(mstrNwPlcIp, miNwPlcPort_tcpip, sendFrame);//, iDataCount);
            return strRtn;
        }

        internal string ReadWordStreamRunChannel(string[] addrMapList, int addressCount)//, int totalBytecount)
        {
            //string strRtn = "";

            byte[] dataFrame = readWordStream.MakeDataFrame(addrMapList);//, totalBytecount);

            byte[] sendFrame = XGT.MakeSendData(dataFrame);

            string strRtn = readWordStream.SendMessageChannel(mstrNwPlcIp, miNwPlcPort_tcpip, sendFrame, addressCount);
            return strRtn;
        }

        internal string ReadWordEachRun(string[] addrMapList)
        {
            //string strRtn = "";
            int iDataCount = addrMapList.Length;
            byte[] dataFrame = readWordEach.MakeDataFrame(iDataCount, addrMapList);

            byte[] sendFrame = XGT.MakeSendData(dataFrame);

            string strRtn = readWordEach.SendMessage(mstrNwPlcIp, miNwPlcPort_tcpip, sendFrame, iDataCount);
            return strRtn;
        }

        internal string WriteWordEachRun(string[] addrMapList, int setValue)
        {
            //string strRtn = "";
            int iDataCount = addrMapList.Length;
            byte[] dataFrame = writeWordEach.MakeDataFrame(iDataCount, addrMapList, setValue);

            byte[] sendFrame = XGT.MakeSendData(dataFrame);

            string strRtn = writeWordEach.SendMessage(mstrNwPlcIp, miNwPlcPort_tcpip, sendFrame);//, iDataCount);
            return strRtn;
        }

        internal string WriteDwordEachRun(string[] addrMapList, Single setValue)
        {
            //string strRtn = "";
            int iDataCount = addrMapList.Length;
            byte[] dataFrame = writeDwordEach.MakeDataFrame(iDataCount, addrMapList, setValue);

            byte[] sendFrame = XGT.MakeSendData(dataFrame);

            string strRtn = writeDwordEach.SendMessage(mstrNwPlcIp, miNwPlcPort_tcpip, sendFrame);//, iDataCount);
            return strRtn;
        }

        internal string WriteDwordEachRun(string[] addrMapList, float[] setValueList, int startIndex, int endIndex)
        {
            //string strRtn = "";
            int iDataCount = addrMapList.Length;
            byte[] dataFrame = writeDwordEach.MakeDataFrame(iDataCount, addrMapList, setValueList, startIndex, endIndex);

            byte[] sendFrame = XGT.MakeSendData(dataFrame);

            string strRtn = writeDwordEach.SendMessage(mstrNwPlcIp, miNwPlcPort_tcpip, sendFrame);//, iDataCount);
            return strRtn;
        }

        internal string WriteWordStreamRun(string[] addrMapList, int setValue, int setValue2)
        {
            //string strRtn = "";
            int iDataCount = addrMapList.Length;
            byte[] dataFrame = writeWordStream.MakeDataFrame(addrMapList, setValue, setValue2);//, iDataCount);

            byte[] sendFrame = XGT.MakeSendData(dataFrame);

            string strRtn = writeWordStream.SendMessage(mstrNwPlcIp, miNwPlcPort_tcpip, sendFrame);//, iDataCount);
            return strRtn;
        }





        //--------------------------------------------------------------------------------------------------------------------------------
        //개별 읽기
        public class ReadBitEach
        {
            public byte[] MakeDataFrame(int iDataCount)
            {
                byte bCount = 0x00;
                switch (iDataCount)
                {
                    case 1: bCount = 0x01; break;
                    case 2: bCount = 0x02; break;
                    case 3: bCount = 0x03; break;
                    case 4: bCount = 0x04; break;
                    case 5: bCount = 0x05; break;
                    case 6: bCount = 0x06; break;
                    case 7: bCount = 0x07; break;
                    case 8: bCount = 0x08; break;
                    case 9: bCount = 0x09; break;
                    case 10: bCount = 0x0A; break;
                    case 11: bCount = 0x0B; break;
                    case 12: bCount = 0x0C; break;
                    case 13: bCount = 0x0D; break;
                    case 14: bCount = 0x0E; break;
                    case 15: bCount = 0x0F; break;
                }

                byte[] dataFrame = new byte[]
                {
                0x54,0x00,//Read command
                0x00,0x00, //dataType (BIT)
                0x00,0x00, //reserved
                bCount,0x00  //data count 
                };


                return dataFrame;
            }

            public byte[] MakeVariableBlock(string[] addrMapList)
            {
                byte[] varBlock = new byte[0];
                //varBlock = MakeVariableBlock("%MX0000", varBlock);
                //varBlock = MakeVariableBlock("%MX0001", varBlock);
                for (int i = 0; i < addrMapList.Length; i++)
                {
                    string map = addrMapList[i].Substring(0, 1);
                    string mapNo = addrMapList[i].Substring(1);

                    string addrblock = "%" + map + "X" + mapNo;

                    varBlock = MakeVariableBlock(addrblock, varBlock);
                }

                return varBlock;
            }

            private byte[] MakeVariableBlock(string v, byte[] varBlock)
            {
                byte[] bLength = new byte[2] {
                0x07,0x00 //변수길이 데이터 길이 (%MX0100)
            };
                varBlock = XGT.ByteCombine(varBlock, bLength);

                byte[] varFrame = Encoding.Default.GetBytes(v);
                varBlock = XGT.ByteCombine(varBlock, varFrame);

                return varBlock;
            }


            public string SendMessage(string mstrNwPlcIp, int miNwPlcPort_tcpip, byte[] sendFrame, int dataCount)
            {
                System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

                sock.SendTimeout = 3000;
                sock.ReceiveTimeout = 3000;

                System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
                int serverPort = miNwPlcPort_tcpip;
                System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

                if (sock.IsBound) { sock.Close(); }

                string strRtn = "";
                try
                {
                    sock.Connect(ipep);
                    if (sock.Connected)
                    {
                        sock.Send(sendFrame);
                        byte[] recvData = new byte[256];// 2048];// [2048];
                        sock.Receive(recvData);
                        strRtn = DataRead(recvData, dataCount);
                    }
                }
                catch (Exception exc) { System.Diagnostics.Debug.WriteLine("error_catch" + DateTime.Now + Environment.NewLine + exc.ToString()); }
                finally
                {
                    sock.Close();
                }
                return strRtn;
            }

            private string DataRead(byte[] recvData, int dataCount)
            {
                int index = 32;
                int max = index + (3 * dataCount);
                int ncnt = 0;
                StringBuilder sb = new StringBuilder();
                for (int i = 32; i < max; i += 3)
                {
                    string val = BitConverter.ToBoolean(recvData, i) == true ? "1" : "0";
                    sb.Append(val);sb.Append(",");//comma 구분자
                    ncnt++;
                }
                string strRtn = sb.ToString();
                sb = null;
                return strRtn;
            }
        }
        public class ReadByteEach
        {

        }
        public class ReadWordEach //16
        {
            public byte[] MakeDataFrame(int iDataCount, string[] addrMapList)
            {
                byte bCount = 0x00;
                switch (iDataCount)
                {
                    case 1: bCount = 0x01; break;
                    case 2: bCount = 0x02; break;
                    case 3: bCount = 0x03; break;
                    case 4: bCount = 0x04; break;
                    case 5: bCount = 0x05; break;
                    case 6: bCount = 0x06; break;
                    case 7: bCount = 0x07; break;
                    case 8: bCount = 0x08; break;
                    case 9: bCount = 0x09; break;
                    case 10: bCount = 0x0A; break;
                    case 11: bCount = 0x0B; break;
                    case 12: bCount = 0x0C; break;
                    case 13: bCount = 0x0D; break;
                    case 14: bCount = 0x0E; break;
                    case 15: bCount = 0x0F; break;
                }

                byte[] dataFrame = new byte[]
                {
               XGT.HexTag.READ,0x00,//Read command
                XGT.HexDataType.WORD,0x00, //dataType (Word)
                0x00,0x00, //reserved
                bCount,0x00  //data count 
                };

                byte[] dataBlock = MakeVariableBlock(addrMapList);
                dataFrame = XGT.ByteCombine(dataFrame, dataBlock);

                return dataFrame;
            }

            public byte[] MakeVariableBlock(string[] addrMapList)
            {
                byte[] varBlock = new byte[0];

                for (int i = 0; i < addrMapList.Length; i++)
                {
                    string map = addrMapList[i].Substring(0, 1);
                    string mapNo = addrMapList[i].Substring(1);

                    string addrblock = "%" + map + "W" + mapNo;

                    varBlock = MakeVariableBlock(addrblock, varBlock);
                }

                return varBlock;
            }

            private byte[] MakeVariableBlock(string v, byte[] varBlock)
            {
                byte[] bLength = new byte[2] {
                0x07,0x00 //변수길이 데이터 길이 (%DD0100)
            };
                varBlock = XGT.ByteCombine(varBlock, bLength);

                byte[] varFrame = Encoding.Default.GetBytes(v);
                varBlock = XGT.ByteCombine(varBlock, varFrame);

                return varBlock;
            }


            public string SendMessage(string mstrNwPlcIp, int miNwPlcPort_tcpip, byte[] sendFrame, int dataCount)
            {
                System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

                sock.SendTimeout = 3000;
                sock.ReceiveTimeout = 3000;

                System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
                int serverPort = miNwPlcPort_tcpip;
                System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

                if (sock.IsBound) { sock.Close(); }

                string strRtn = "";
                try
                {
                    sock.Connect(ipep);
                    if (sock.Connected)
                    {
                        sock.Send(sendFrame);
                        byte[] recvData = new byte[100];// 2048];// [2048];
                        sock.Receive(recvData);

                        strRtn = DataRead(recvData, dataCount);


                    }
                }
                catch (Exception exc) { System.Diagnostics.Debug.WriteLine(exc.ToString()); }
                finally
                {
                    sock.Close();
                }
                return strRtn;
            }

            private string DataRead(byte[] recvData, int dataCount)
            {
                string strRtn = "";
                int index = 32;
                int max = index + (XGT.GetDataIndexStepUnit.WORD * dataCount);
                int ncnt = 0;
                for (int i = 32; i < max; i += XGT.GetDataIndexStepUnit.WORD)
                {
                    //System.Diagnostics.Debug.WriteLine(ncnt + " " + i + " " + BitConverter.ToInt16(recvData, i));
                    string val = BitConverter.ToInt16(recvData, i).ToString();
                    strRtn += val + ",";//comma 구분자
                    ncnt++;
                }
                return strRtn;
            }
        }
        public class ReadDwordEach//32
        {
            //실제 어드레스 /2 
            //D0->D0
            //DD100->DW200

            public byte[] MakeDataFrame(int iDataCount, string[] addrMapList)
            {
                //byte bDataCount = 0x02;
                //int intValue =  iDataCount;//255
                //byte[] intBytes = BitConverter.GetBytes(intValue);
                //Array.Reverse(intBytes);
                //byte[] result = intBytes;
                //bDataCount = result[3];

                byte bDataCount = XGT.IntToHex(iDataCount);

                byte[] dataFrame = new byte[]
                {
                0x54,0x00,//Read command
                0x03,0x00, //dataType (DWord)
                0x00,0x00, //reserved
                bDataCount,0x00  //data count 
                };

                byte[] dataBlock = MakeVariableBlock(addrMapList);
                dataFrame = XGT.ByteCombine(dataFrame, dataBlock);

                return dataFrame;
            }


            public byte[] MakeVariableBlock(string[] addrMapList)
            {
                byte[] varBlock = new byte[0];

                for (int i = 0; i < addrMapList.Length; i++)
                {
                    string map = addrMapList[i].Substring(0, 1);
                    string mapNo = addrMapList[i].Substring(1);

                    string addrblock = "%" + map + "D" + mapNo;

                    varBlock = MakeVariableBlock(addrblock, varBlock);
                }

                return varBlock;
            }

            private byte[] MakeVariableBlock(string v, byte[] varBlock)
            {
                byte[] bLength = new byte[2] {
                0x07,0x00 //변수길이 데이터 길이 (%DD0100)
            };
                varBlock = XGT.ByteCombine(varBlock, bLength);

                byte[] varFrame = Encoding.Default.GetBytes(v);
                varBlock = XGT.ByteCombine(varBlock, varFrame);

                return varBlock;
            }


            public string SendMessage(string mstrNwPlcIp, int miNwPlcPort_tcpip, byte[] sendFrame, int dataCount, string[] strArry_int32_float)
            {
                System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

                sock.SendTimeout = 3000;
                sock.ReceiveTimeout = 3000;//300->3000

                System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
                int serverPort = miNwPlcPort_tcpip;
                System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

                if (sock.IsBound) { sock.Close(); }

                string strRtn = "";
                try
                {
                    sock.Connect(ipep);
                    if (sock.Connected)
                    {
                        sock.Send(sendFrame);
                        byte[] recvData = new byte[256];//[2048];
                        sock.Receive(recvData);

                        if (recvData.Length > 0)
                        {

                            strRtn = DataRead(recvData, dataCount, strArry_int32_float);
                        }
                        else
                        {
                            //strRtn = "0,0,0,0,0,0,0,0,0,0,0,0";
                        }
                    }
                }
                catch (Exception exc) { System.Diagnostics.Debug.WriteLine(exc.ToString()); }
                finally
                {
                    sock.Close();
                }
                return strRtn;
            }

            private string DataRead(byte[] recvData, int dataCount, string[] strArry_int32_float)
            {

                int index = 32;
                int increStep6 = XGT.GetDataIndexStepUnit.DWORD;
                int max = index + (increStep6 * dataCount);
                int ncnt = 0;

                StringBuilder sb = new StringBuilder();

                for (int i = 32; i < max; i += increStep6)
                {
                    string val;// = "";
                    if (strArry_int32_float[ncnt].Equals("FLOAT"))
                    {
                        //실수형 4BYTE
                        val = BitConverter.ToSingle(recvData, i).ToString();

                    }
                    else
                    {
                        //부호있는 10진수 4BYTE
                        val = BitConverter.ToInt32(recvData, i).ToString();
                    }

                    //strRtn += val + ",";//comma 구분자
                    sb.Append(val);sb.Append(",");
                    ncnt++;
                }
                string strRtn = sb.ToString();
                sb = null;
                strRtn = strRtn.TrimEnd(',');
                return strRtn;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------
        //연속 읽기
        public class ReadBitStream
        {
            public byte[] MakeDataFrame(int iDataCount, string[] addrMapList)
            {
                byte bCount = 0x00;
                iDataCount = 7;
                switch (iDataCount)
                {
                    case 1: bCount = 0x01; break;
                    case 2: bCount = 0x02; break;
                    case 3: bCount = 0x03; break;
                    case 4: bCount = 0x04; break;
                    case 5: bCount = 0x05; break;
                    case 6: bCount = 0x06; break;
                    case 7: bCount = 0x07; break;
                    case 8: bCount = 0x08; break;
                    case 9: bCount = 0x09; break;
                    case 10: bCount = 0x0A; break;
                    case 11: bCount = 0x0B; break;
                    case 12: bCount = 0x0C; break;
                    case 13: bCount = 0x0D; break;
                    case 14: bCount = 0x0E; break;
                    case 15: bCount = 0x0F; break;
                }

                byte[] dataFrame = new byte[]
                {
                0x54,0x00,//Read command
                0x14,0x00, //dataType (BIT)
                0x00,0x00, //reserved
                0x01,0x00, //변수개수(1), 고정
                bCount,0x00  //변수길이 (%PB0004)
                };

                //  byte[] varFrame = Encoding.Default.GetBytes("%PB0004");
                byte[] varFrame = MakeVariableBlock(addrMapList);
                dataFrame = XGT.ByteCombine(dataFrame, varFrame);

                byte[] bLength = new byte[] { 0x02 };
                dataFrame = XGT.ByteCombine(dataFrame, bLength);

                return dataFrame;
            }

            public byte[] MakeVariableBlock(string[] addrMapList)
            {
                byte[] varBlock = new byte[0];
                //varBlock = MakeVariableBlock("%MX0000", varBlock);
                //varBlock = MakeVariableBlock("%MX0001", varBlock);
                for (int i = 0; i < addrMapList.Length; i++)
                {
                    string map = addrMapList[i].Substring(0, 1);
                    string mapNo = addrMapList[i].Substring(1);

                    string addrblock = "%" + map + "B" + mapNo;

                    varBlock = MakeVariableBlock(addrblock, varBlock);
                }

                return varBlock;
            }

            private byte[] MakeVariableBlock(string v, byte[] varBlock)
            {
                byte[] bLength = new byte[2] {
                0x07,0x00 //변수길이 데이터 길이 (%MX0100)
            };
                varBlock = XGT.ByteCombine(varBlock, bLength);

                byte[] varFrame = Encoding.Default.GetBytes(v);
                varBlock = XGT.ByteCombine(varBlock, varFrame);

                return varBlock;
            }


            public string SendMessage(string mstrNwPlcIp, int miNwPlcPort_tcpip, byte[] sendFrame)//, int dataCount)
            {
                System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

                sock.SendTimeout = 3000;
                sock.ReceiveTimeout = 3000;

                System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
                int serverPort = miNwPlcPort_tcpip;
                System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

                if (sock.IsBound) { sock.Close(); }

                string strRtn = "";
                try
                {
                    sock.Connect(ipep);
                    if (sock.Connected)
                    {
                        sock.Send(sendFrame);
                        byte[] recvData = new byte[256];
                        sock.Receive(recvData);
                        strRtn = DataRead(recvData);//, dataCount);


                    }
                }
                catch (Exception exc) { System.Diagnostics.Debug.WriteLine(exc.ToString()); }
                finally
                {
                    sock.Close();
                }
                return strRtn;
            }

            private string DataRead(byte[] recvData)//, int dataCount)
            {
                string strRtn = "";
                byte[] recData = new byte[16];
                int iDatas = BitConverter.ToInt32(recvData, 32);

                for (int i = 0; i < 16; i++)
                {
                    recData[i] = (byte)(iDatas & 0x00000001);
                    iDatas = iDatas >> 1;
                }

                for (int k = 0; k < recData.Length; k++)
                {
                    //System.Diagnostics.Debug.WriteLine(k + " " + BitConverter.ToBoolean(recvData, k));
                    string val = BitConverter.ToBoolean(recvData, k) == true ? "1" : "0";
                    strRtn += val + ",";//comma 구분자
                }

                return strRtn;
            }
        }

        /// <summary>
        /// Word(16)로 연속 읽어와서 Dword(32) 값 표시
        /// </summary>
        public class ReadWordStream
        {
            public byte[] MakeDataFrame(string[] addrMapList , int iDataCount)
            {
                byte bCount = 0x07;

                byte[] dataFrame = new byte[]
                {
                0x54,0x00,//Read command
                0x14,0x00, //dataType (BIT)
                0x00,0x00, //reserved
                0x01,0x00, //변수개수(1), 고정
                bCount,0x00  //변수길이 (%DB0020)-> DW10 
                };

                //  byte[] varFrame = Encoding.Default.GetBytes("%DB0020");
                byte[] varFrame = MakeVariableBlock(addrMapList);
                dataFrame = XGT.ByteCombine(dataFrame, varFrame);

                byte[] bLength = new byte[] { 0x08 };//D10 - 2 , D11 -2, D12-4 (D12,D13)
                dataFrame = XGT.ByteCombine(dataFrame, bLength);

                return dataFrame;
            }

            public byte[] MakeDataFrame(string[] addrMapList)//, int byteCount)
            {
                byte bCmdCount = 0x07;

                byte[] dataFrame = new byte[]
                {
                0x54,0x00,//Read command
                0x14,0x00, //dataType (BIT)
                0x00,0x00, //reserved
                0x01,0x00, //변수개수(1), 고정
                bCmdCount,0x00  //변수길이 (%DB0020)-> DW10 
                };

                //  byte[] varFrame = Encoding.Default.GetBytes("%DB0020");
                byte[] varFrame = MakeVariableBlock(addrMapList);
                dataFrame = XGT.ByteCombine(dataFrame, varFrame);


                //byte[] bLength = new byte[] { (byte)byteCount };
                byte[] bLength = new byte[] { 0x08 };//88->58
                dataFrame = XGT.ByteCombine(dataFrame, bLength);

                return dataFrame;
            }

            //private void ConvertInt32ToHex(int byteCount)
            //{
            //    string strHexSum = "";
            //    string strHexCode = "";
            //    int valMax = byteCount;
            //    int value = 0;
            //   do
            //    {
            //        value = (valMax / 16);

            //        if(value != 0)
            //        {
            //            switch(value)
            //            {
            //                case 0: strHexCode = "0"; break;
            //                case 1: strHexCode = "1"; break;
            //                case 2: strHexCode = "2"; break;
            //                case 3: strHexCode = "3"; break;
            //                case 4: strHexCode = "4"; break;
            //                case 5: strHexCode = "5"; break;
            //                case 6: strHexCode = "6"; break;
            //                case 7: strHexCode = "7"; break;
            //                case 8: strHexCode = "8"; break;
            //                case 9: strHexCode = "9"; break;
            //                case 10: strHexCode = "A"; break;
            //                case 11: strHexCode = "B"; break;
            //                case 12: strHexCode = "C"; break;
            //                case 13: strHexCode = "D"; break;
            //                case 14: strHexCode = "E"; break;
            //                case 15: strHexCode = "F"; break;
            //            }

            //            strHexSum += strHexCode;
            //        }
            //    }
            //   while((value != 0)

            //}

            public byte[] MakeVariableBlock(string[] addrMapList)
            {
               // byte[] varBlock = new byte[0];

                string map = addrMapList[0].Substring(0, 1);
                string mapNo = addrMapList[0].Substring(1);

                string addrblock = "%" + map + "B" + mapNo;

                byte[] varBlock = Encoding.Default.GetBytes(addrblock);

                return varBlock;
            }


            public string SendMessage(string mstrNwPlcIp, int miNwPlcPort_tcpip, byte[] sendFrame)//, int dataCount)
            {
                System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

                sock.SendTimeout = 3000;
                sock.ReceiveTimeout = 3000;

                System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
                int serverPort = miNwPlcPort_tcpip;
                System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

                if (sock.IsBound) { sock.Close(); }

                string strRtn = "";
                try
                {
                    sock.Connect(ipep);
                    if (sock.Connected)
                    {
                        sock.Send(sendFrame);
                        byte[] recvData = new byte[256];
                        sock.Receive(recvData);
                        strRtn = DataRead(recvData);//, dataCount);

                    }
                }
                catch (Exception exc) { System.Diagnostics.Debug.WriteLine(exc.ToString()); }
                finally
                {
                    sock.Close();
                }
                return strRtn;
            }

            private string DataRead(byte[] recvData)//, int dataCount)
            {
                //string strRtn = "";
                short data1 = BitConverter.ToInt16(recvData, 32);
                short data2 = BitConverter.ToInt16(recvData, 34);
                int data3 = BitConverter.ToInt32(recvData, 36);
                Int16 data4 = BitConverter.ToInt16(recvData, 36);
                Int16 data5 = BitConverter.ToInt16(recvData, 38);
                //strRtn += data1 + "," + data2 + "," + data3;
                string strRtn = data1 + "," + data2 + "," + data3 + "," + data4 + data5;

                return strRtn;
            }

            public string SendMessageChannel(string mstrNwPlcIp, int miNwPlcPort_tcpip, byte[] sendFrame, int dataCount)
            {
                System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

                sock.SendTimeout = 3000;
                sock.ReceiveTimeout = 3000;

                System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
                int serverPort = miNwPlcPort_tcpip;
                System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

                if (sock.IsBound) { sock.Close(); }

                string strRtn = "";
                try
                {
                    sock.Connect(ipep);
                    if (sock.Connected)
                    {
                        sock.Send(sendFrame);
                        byte[] recvData = new byte[256];
                        sock.Receive(recvData);
                        strRtn = DataReadChannel(recvData, dataCount);

                    }
                }
                catch (Exception exc) { System.Diagnostics.Debug.WriteLine(exc.ToString()); }
                finally
                {
                    sock.Close();
                }
                return strRtn;
            }

            private string DataReadChannel(byte[] recvData, int dataCount)
            {
                string strRtn = "";
                int index = 32;
                int increStep = XGT.GetDataIndexStepUnit.WORD;
                int max = index + (increStep * dataCount);
                int ncnt = 0;
                for (int i = 32; i < max; i += increStep)
                {
                    string val = BitConverter.ToInt32(recvData, i).ToString();
                    strRtn += val + ",";//comma 구분자
                    ncnt++;
                }

                return strRtn;
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------
        //개별 쓰기
        public class WriteBitEach
        {
            public byte[] MakeDataFrame(int iDataCount, string[] addrMapList, int setValue)
            {
                byte bCount = 0x00;
                switch (iDataCount)
                {
                    case 1: bCount = 0x01; break;
                    case 2: bCount = 0x02; break;
                    case 3: bCount = 0x03; break;
                    case 4: bCount = 0x04; break;
                    case 5: bCount = 0x05; break;
                    case 6: bCount = 0x06; break;
                    case 7: bCount = 0x07; break;
                    case 8: bCount = 0x08; break;
                    case 9: bCount = 0x09; break;
                    case 10: bCount = 0x0A; break;
                    case 11: bCount = 0x0B; break;
                    case 12: bCount = 0x0C; break;
                    case 13: bCount = 0x0D; break;
                    case 14: bCount = 0x0E; break;
                    case 15: bCount = 0x0F; break;
                }

                byte[] dataFrame = new byte[]
                {
                0x58,0x00,//Write command
                0x00,0x00, //dataType (BIT)
                0x00,0x00, //reserved
                bCount,0x00  //data count 
                };

                byte[] dataBlock = MakeVariableBlock(addrMapList);
                dataFrame = XGT.ByteCombine(dataFrame, dataBlock);

                //set value
                byte[] dataValue = null;
                if (setValue == 1)
                {
                    dataValue = new byte[] {
                        0x01, 0x00,
                        0x01,0x01,
                        0x00,0x00
                    };
                }
                else if (setValue == 0)
                {
                    dataValue = new byte[] {
                        0x01, 0x00,
                        0x00,0x01,
                        0x00,0x00
                    };
                }
                dataFrame = XGT.ByteCombine(dataFrame, dataValue);
                return dataFrame;
            }

            public byte[] MakeVariableBlock(string[] addrMapList)
            {
                byte[] varBlock = new byte[0];
                //varBlock = MakeVariableBlock("%MX0000", varBlock);
                for (int i = 0; i < addrMapList.Length; i++)
                {
                    string map = addrMapList[i].Substring(0, 1);
                    string mapNo = addrMapList[i].Substring(1);

                    string addrblock = "%" + map + "X" + mapNo;

                    varBlock = MakeVariableBlock(addrblock, varBlock);
                }

                return varBlock;
            }

            private byte[] MakeVariableBlock(string v, byte[] varBlock)
            {
                byte[] bLength = new byte[2] { 0x07, 0x00 }; //변수길이 데이터 길이 (%MX0100)
                varBlock = XGT.ByteCombine(varBlock, bLength);

                byte[] varFrame = Encoding.Default.GetBytes(v);
                varBlock = XGT.ByteCombine(varBlock, varFrame);

                return varBlock;
            }



            public string SendMessage(string mstrNwPlcIp, int miNwPlcPort_tcpip, byte[] sendFrame)//, int dataCount)
            {
                System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

                sock.SendTimeout = 3000;
                sock.ReceiveTimeout = 3000;

                System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
                int serverPort = miNwPlcPort_tcpip;
                System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

                if (sock.IsBound) { sock.Close(); }

                string strRtn = "";
                try
                {
                    sock.Connect(ipep);
                    if (sock.Connected)
                    {
                        sock.Send(sendFrame);
                    }
                }
                catch (Exception exc) { System.Diagnostics.Debug.WriteLine(exc.ToString()); }
                finally
                {
                    sock.Close();
                }
                return strRtn;
            }

        }
        public class WriteByteEach
        {

        }
        public class WriteWordEach //16
        {
            public byte[] MakeDataFrame(int iDataCount, string[] addrMapList, int setValue)
            {
                byte bCount = 0x00;
                switch (iDataCount)
                {
                    case 1: bCount = 0x01; break;
                    case 2: bCount = 0x02; break;
                    case 3: bCount = 0x03; break;
                    case 4: bCount = 0x04; break;
                    case 5: bCount = 0x05; break;
                    case 6: bCount = 0x06; break;
                    case 7: bCount = 0x07; break;
                    case 8: bCount = 0x08; break;
                    case 9: bCount = 0x09; break;
                    case 10: bCount = 0x0A; break;
                    case 11: bCount = 0x0B; break;
                    case 12: bCount = 0x0C; break;
                    case 13: bCount = 0x0D; break;
                    case 14: bCount = 0x0E; break;
                    case 15: bCount = 0x0F; break;
                }

                byte[] dataFrame = new byte[]
                {
                0x58,0x00,//Write command
               XGT.HexDataType.WORD,0x00, //dataType 
                0x00,0x00, //reserved
                bCount,0x00  //data count 
                };

                byte[] dataBlock = MakeVariableBlock(addrMapList);
                dataFrame = XGT.ByteCombine(dataFrame, dataBlock);

                //set value
                byte[] dataValue = MakeDatas((Int16)setValue);
                dataFrame = XGT.ByteCombine(dataFrame, dataValue);
                return dataFrame;
            }

            private byte[] MakeDatas(Int16 setValue)
            {
                byte[] bData = new byte[0];
                byte[] bDataCount = new byte[2] { 0x02, 0x00 }; //byte 수 

                bData = XGT.ByteCombine(bData, bDataCount);
                byte[] bWordData = BitConverter.GetBytes(setValue);
                bData = XGT.ByteCombine(bData, bWordData);

                bData = XGT.ByteCombine(bData, bDataCount);
                bWordData = BitConverter.GetBytes(setValue);
                bData = XGT.ByteCombine(bData, bWordData);

                return bData;
            }

            public byte[] MakeVariableBlock(string[] addrMapList)
            {
                byte[] varBlock = new byte[0];
                //varBlock = MakeVariableBlock("%MX0000", varBlock);
                for (int i = 0; i < addrMapList.Length; i++)
                {
                    string map = addrMapList[i].Substring(0, 1);
                    string mapNo = addrMapList[i].Substring(1);

                    string addrblock = "%" + map + "W" + mapNo;

                    varBlock = MakeVariableBlock(addrblock, varBlock);
                }

                return varBlock;
            }

            private byte[] MakeVariableBlock(string v, byte[] varBlock)
            {
                byte[] bLength = new byte[2] { 0x07, 0x00 }; //변수길이 데이터 길이 (%MX0100)
                varBlock = XGT.ByteCombine(varBlock, bLength);

                byte[] varFrame = Encoding.Default.GetBytes(v);
                varBlock = XGT.ByteCombine(varBlock, varFrame);

                return varBlock;
            }



            public string SendMessage(string mstrNwPlcIp, int miNwPlcPort_tcpip, byte[] sendFrame)//, int dataCount)
            {
                System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

                sock.SendTimeout = 3000;
                sock.ReceiveTimeout = 3000;

                System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
                int serverPort = miNwPlcPort_tcpip;
                System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

                if (sock.IsBound) { sock.Close(); }

                string strRtn = "";
                try
                {
                    sock.Connect(ipep);
                    if (sock.Connected)
                    {
                        sock.Send(sendFrame);
                    }
                }
                catch (Exception exc) { System.Diagnostics.Debug.WriteLine(exc.ToString()); }
                finally
                {
                    sock.Close();
                }
                return strRtn;
            }

        }
        public class WritDwordEach//32
        {
            public byte[] MakeDataFrame(int iDataCount, string[] addrMapList, float setValue)
            {
                byte bCount = 0x00;
                switch (iDataCount)
                {
                    case 1: bCount = 0x01; break;
                    case 2: bCount = 0x02; break;
                    case 3: bCount = 0x03; break;
                    case 4: bCount = 0x04; break;
                    case 5: bCount = 0x05; break;
                    case 6: bCount = 0x06; break;
                    case 7: bCount = 0x07; break;
                    case 8: bCount = 0x08; break;
                    case 9: bCount = 0x09; break;
                    case 10: bCount = 0x0A; break;
                    case 11: bCount = 0x0B; break;
                    case 12: bCount = 0x0C; break;
                    case 13: bCount = 0x0D; break;
                    case 14: bCount = 0x0E; break;
                    case 15: bCount = 0x0F; break;
                }

                byte[] dataFrame = new byte[]
                {
                    XGT.HexTag.WRITE,0x00,//Write command
                    XGT.HexDataType.DWORD,0x00, //dataType 
                    0x00,0x00, //reserved
                    bCount,0x00  //data count 
                };

                byte[] dataBlock = MakeVariableBlock(addrMapList);
                dataFrame = XGT.ByteCombine(dataFrame, dataBlock);

                //set value
                //byte[] dataValue = MakeDatas((Int32)setValue);
                byte[] dataValue = MakeDatas(setValue);
                dataFrame = XGT.ByteCombine(dataFrame, dataValue);
                return dataFrame;
            }

            public byte[] MakeDataFrame(int iDataCount, string[] addrMapList, float[] setValueList, int startIndex, int endIndex)
            {
                byte bDataCount = XGT.IntToHex(iDataCount);

                byte[] dataFrame = new byte[]
                {
                XGT.HexTag.WRITE,0x00,//Write command
               XGT.HexDataType.DWORD,0x00, //dataType 
                0x00,0x00, //reserved
                bDataCount,0x00  //data count 
                };

                byte[] dataBlock = MakeVariableBlock(addrMapList);
                dataFrame = XGT.ByteCombine(dataFrame, dataBlock);

                //set value
                for (int i = startIndex; i < endIndex; i++)
                {
                    byte[] dataValue = MakeDatas2((float)setValueList[i]);
                    dataFrame = XGT.ByteCombine(dataFrame, dataValue);
                }
                return dataFrame;
            }

            //public byte[] MakeDataFrame(int iDataCount, string[] addrMapList, int[] setValueList, int startIndex, int endIndex)
            //{
            //    byte bDataCount = XGT.IntToHex(iDataCount);

            //    byte[] dataFrame = new byte[]
            //    {
            //    XGT.HexTag.WRITE,0x00,//Write command
            //   XGT.HexDataType.DWORD,0x00, //dataType 
            //    0x00,0x00, //reserved
            //    bDataCount,0x00  //data count 
            //    };

            //    byte[] dataBlock = MakeVariableBlock(addrMapList);
            //    dataFrame = XGT.ByteCombine(dataFrame, dataBlock);

            //    //set value
            //    for (int i = startIndex; i < endIndex; i++)
            //    {
            //        byte[] dataValue = MakeDatas2((Int32)setValueList[i]);
            //        dataFrame = XGT.ByteCombine(dataFrame, dataValue);
            //    }
            //    return dataFrame;
            //}

            private byte[] MakeDatas2(float setValue)
            {
                byte[] bData = new byte[0];
                byte[] bDataCount = new byte[2] { 0x04, 0x00 }; //byte 수  32bit 4byte

                bData = XGT.ByteCombine(bData, bDataCount);
                byte[] bWordData = BitConverter.GetBytes(setValue);
                bData = XGT.ByteCombine(bData, bWordData);

                return bData;
            }

            //private byte[] MakeDatas2(Int32 setValue)
            //{
            //    byte[] bData = new byte[0];
            //    byte[] bDataCount = new byte[2] { 0x04, 0x00 }; //byte 수  32bit 4byte

            //    bData = XGT.ByteCombine(bData, bDataCount);
            //    byte[] bWordData = BitConverter.GetBytes(setValue);
            //    bData = XGT.ByteCombine(bData, bWordData);

            //    return bData;
            //}

            private byte[] MakeDatas(float setValue)
            {
                byte[] bData = new byte[0];
                byte[] bDataCount = new byte[2] { 0x04, 0x00 }; //byte 수  32bit 4byte

                bData = XGT.ByteCombine(bData, bDataCount);

                byte[] bWordData = BitConverter.GetBytes(setValue);
                bData = XGT.ByteCombine(bData, bWordData);
                bData = XGT.ByteCombine(bData, bDataCount);

                bWordData = BitConverter.GetBytes(setValue);
                bData = XGT.ByteCombine(bData, bWordData);

                return bData;
            }

            //private byte[] MakeDatas(Int32 setValue)
            //{
            //    byte[] bData = new byte[0];
            //    byte[] bDataCount = new byte[2] { 0x04, 0x00 }; //byte 수  32bit 4byte

            //    bData = XGT.ByteCombine(bData, bDataCount);
            //    byte[] bWordData = BitConverter.GetBytes(setValue);
            //    bData = XGT.ByteCombine(bData, bWordData);

            //    bData = XGT.ByteCombine(bData, bDataCount);
            //    bWordData = BitConverter.GetBytes(setValue);
            //    bData = XGT.ByteCombine(bData, bWordData);

            //    return bData;
            //}

            public byte[] MakeVariableBlock(string[] addrMapList)
            {
                byte[] varBlock = new byte[0];

                for (int i = 0; i < addrMapList.Length; i++)
                {
                    string map = addrMapList[i].Substring(0, 1);
                    string mapNo = addrMapList[i].Substring(1);

                    string addrblock = "%" + map + "D" + mapNo;

                    varBlock = MakeVariableBlock(addrblock, varBlock);
                }

                return varBlock;
            }

            private byte[] MakeVariableBlock(string v, byte[] varBlock)
            {
                byte[] bLength = new byte[2] { 0x07, 0x00 }; //변수길이 데이터 길이 (%MX0100)
                varBlock = XGT.ByteCombine(varBlock, bLength);

                byte[] varFrame = Encoding.Default.GetBytes(v);
                varBlock = XGT.ByteCombine(varBlock, varFrame);

                return varBlock;
            }



            public string SendMessage(string mstrNwPlcIp, int miNwPlcPort_tcpip, byte[] sendFrame)//, int dataCount)
            {
                System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

                sock.SendTimeout = 3000;
                sock.ReceiveTimeout = 3000;

                System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
                int serverPort = miNwPlcPort_tcpip;
                System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

                if (sock.IsBound) { sock.Close(); }

                string strRtn = "";
                try
                {
                    sock.Connect(ipep);
                    if (sock.Connected)
                    {
                        sock.Send(sendFrame);
                    }
                }
                catch (Exception exc) { System.Diagnostics.Debug.WriteLine(exc.ToString()); }
                finally
                {
                    sock.Close();
                }
                return strRtn;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------
        //연속 쓰기
        public class WriteBitStream
        {
            public byte[] MakeDataFrame( string[] addrMapList, byte[] setData_16bit)//, int iDataCount)
            {
                byte bCount = 0x01; //Fix

                byte[] dataFrame = new byte[]
                {
                0x58,0x00,//Write command
                0x14,0x00, //dataType (BIT)
                0x00,0x00, //reserved
                bCount,0x00  //data count 
                };

                byte[] dataBlock = MakeVariableBlock(addrMapList);
                dataFrame = XGT.ByteCombine(dataFrame, dataBlock);

                //set value
                byte[] dataValue = MakeDatas(setData_16bit);
                dataFrame = XGT.ByteCombine(dataFrame, dataValue);
                return dataFrame;
            }

            private byte[] MakeDatas(byte[] setData_16bit)
            {
                byte[] bData = new byte[0];
                byte[] byteDatas = new byte[1] { 0 };

                if (setData_16bit[0] == 1) byteDatas[0] += 1;
                if (setData_16bit[1] == 1) byteDatas[0] += 2;
                if (setData_16bit[2] == 1) byteDatas[0] += 4;
                if (setData_16bit[3] == 1) byteDatas[0] += 8;
                if (setData_16bit[4] == 1) byteDatas[0] += 16;
                if (setData_16bit[5] == 1) byteDatas[0] += 32;
                if (setData_16bit[6] == 1) byteDatas[0] += 64;
                if (setData_16bit[7] == 1) byteDatas[0] += 128;

                bData = XGT.ByteCombine(bData, byteDatas);
                byteDatas[0] = 0;

                if (setData_16bit[8] == 1) byteDatas[0] += 1;
                if (setData_16bit[9] == 1) byteDatas[0] += 2;
                if (setData_16bit[10] == 1) byteDatas[0] += 4;
                if (setData_16bit[11] == 1) byteDatas[0] += 8;
                if (setData_16bit[12] == 1) byteDatas[0] += 16;
                if (setData_16bit[13] == 1) byteDatas[0] += 32;
                if (setData_16bit[14] == 1) byteDatas[0] += 64;
                if (setData_16bit[15] == 1) byteDatas[0] += 128;

                bData = XGT.ByteCombine(bData, byteDatas);

                return bData;
            }

            public byte[] MakeVariableBlock(string[] addrMapList)
            {
                byte[] varBlock = new byte[0];

                for (int i = 0; i < addrMapList.Length; i++)
                {
                    string map = addrMapList[i].Substring(0, 1);
                    string mapNo = addrMapList[i].Substring(1);

                    string addrblock = "%" + map + "B" + mapNo;

                    varBlock = MakeVariableBlock(addrblock, varBlock);
                }

                return varBlock;
            }

            private byte[] MakeVariableBlock(string v, byte[] varBlock)
            {
                byte[] bLength = new byte[2] { 0x07, 0x00 }; //변수길이 데이터 길이 (%MB0000)
                varBlock = XGT.ByteCombine(varBlock, bLength);

                byte[] varFrame = Encoding.Default.GetBytes(v);
                varBlock = XGT.ByteCombine(varBlock, varFrame);

                byte[] bCount = new byte[2] { 0x02, 0x00 }; //데이터 개수 (바이트) 
                varBlock = XGT.ByteCombine(varBlock, bCount);

                return varBlock;
            }


            public string SendMessage(string mstrNwPlcIp, int miNwPlcPort_tcpip, byte[] sendFrame)//, int dataCount)
            {
                System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

                sock.SendTimeout = 3000;
                sock.ReceiveTimeout = 3000;

                System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
                int serverPort = miNwPlcPort_tcpip;
                System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

                if (sock.IsBound) { sock.Close(); }

                string strRtn = "";
                try
                {
                    sock.Connect(ipep);
                    if (sock.Connected)
                    {
                        sock.Send(sendFrame);
                    }
                }
                catch (Exception exc) { System.Diagnostics.Debug.WriteLine(exc.ToString()); }
                finally
                {
                    sock.Close();
                }
                return strRtn;
            }
        }

        public class WriteWordStream//16
        {
            public byte[] MakeDataFrame(string[] addrMapList, int setValue, int setValue2)// int iDataCount)
            {
                byte bBlockCount = 0x01;

                byte[] dataFrame = new byte[]
                {
                XGT.HexTag.WRITE,0x00,//Write command
               XGT.HexDataType.STREAM,0x00, //dataType 
                0x00,0x00, //reserved
                bBlockCount,0x00  //data count Fix(고정)
                };

                byte[] dataBlock = MakeVariableBlock(addrMapList);
                dataFrame = XGT.ByteCombine(dataFrame, dataBlock);

                //set value
                byte[] dataValue = MakeDatas((Int16)setValue, (Int16)setValue2);
                dataFrame = XGT.ByteCombine(dataFrame, dataValue);
                return dataFrame;
            }

            private byte[] MakeDatas(Int16 setValue, Int16 setValue2)
            {
                byte[] bData = new byte[0];

                byte[] bWordData = BitConverter.GetBytes(setValue);
                bData = XGT.ByteCombine(bData, bWordData);

                bWordData = BitConverter.GetBytes(setValue2);
                bData = XGT.ByteCombine(bData, bWordData);

                return bData;
            }

            public byte[] MakeVariableBlock(string[] addrMapList)
            {
                byte[] varBlock = new byte[0];
                string map = addrMapList[0].Substring(0, 1);
                string mapNo = addrMapList[0].Substring(1);
                string addrblock = "%" + map + "B" + mapNo;

                byte[] bLength = new byte[2] { 0x07, 0x00 }; //변수길이 데이터 길이 (%DB0100)
                varBlock = XGT.ByteCombine(varBlock, bLength);

                byte[] varFrame = Encoding.Default.GetBytes(addrblock);
                varBlock = XGT.ByteCombine(varBlock, varFrame);

                byte[] bCount = new byte[] { 0x04, 0x00 }; //byte count 32bit : 4byte
                varBlock = XGT.ByteCombine(varBlock, bCount);

                return varBlock;
            }


            public string SendMessage(string mstrNwPlcIp, int miNwPlcPort_tcpip, byte[] sendFrame)//, int dataCount)
            {
                System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);

                sock.SendTimeout = 3000;
                sock.ReceiveTimeout = 3000;

                System.Net.IPAddress serverIP = System.Net.IPAddress.Parse(mstrNwPlcIp);
                int serverPort = miNwPlcPort_tcpip;
                System.Net.IPEndPoint ipep = new System.Net.IPEndPoint(serverIP, serverPort);

                if (sock.IsBound) { sock.Close(); }

                string strRtn = "";
                try
                {
                    sock.Connect(ipep);
                    if (sock.Connected)
                    {
                        sock.Send(sendFrame);
                    }
                }
                catch (Exception exc) { System.Diagnostics.Debug.WriteLine(exc.ToString()); }
                finally
                {
                    sock.Close();
                }
                return strRtn;
            }

        }

        //--------------------------------------------------------------------------------------------------------------------------------
    }
}


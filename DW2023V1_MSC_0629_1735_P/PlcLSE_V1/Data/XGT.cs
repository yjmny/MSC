using System;

namespace PlcLSE_V1
{
    /// <summary>
    /// LS산전 FEnet I/F 모듈간에 통신을 하는 프로토콜
    /// </summary>
    public static class XGT
    {
        /// <summary>
        /// Memory Device
        /// </summary>
        public static class MEMDEVICE
        {
            public static string P = "%P";
            public static string M = "%M";
            public static string L = "%L";
            public static string F = "%F";
            public static string K = "%K";
            public static string C = "%C";
            public static string D = "%D";
            public static string T = "%T";
            public static string N = "%N";
            public static string R = "%R";
            public static string S = "%S";
            public static string W = "%W";

            public static string SelectMapName(string text)
            {
                string mapName = "";
                switch (text)
                {
                    case "P": mapName = P; break;
                    case "M": mapName = M; break;
                    case "L": mapName = L; break;
                    case "F": mapName = F; break;
                    case "K": mapName = K; break;
                    case "C": mapName = C; break;
                    case "D": mapName = D; break;
                    case "T": mapName = T; break;
                    case "N": mapName = N; break;
                    case "R": mapName = R; break;
                    case "S": mapName = S; break;
                    case "W": mapName = W; break;
                }
                return mapName;
            }
        }
        public static class DATATYPE_STRING
        {
            /// <summary>
            /// BIT = X
            /// </summary>
            public static string BIT = "X";
            /// <summary>
            /// BYTE = B
            /// </summary>
            public static string BYTE = "B";
            /// <summary>
            /// WORD = W
            /// </summary>
            public static string WORD = "W";
            /// <summary>
            /// DWORD = D
            /// </summary>
            public static string DWORD = "D";
            /// <summary>
            /// LWORD = L
            /// </summary>
            public static string LWORD = "L";
            /// <summary>
            /// CONTINUE_BYTE = -
            /// </summary>
            public static string CONTINUE_BYTE = "-";
        }
        public static class HexTag
        {
            /// <summary>
            /// 0x54
            /// </summary>
            public static byte READ = 0x54;
            /// <summary>
            /// 0x58
            /// </summary>
            public static byte WRITE = 0x58;
            /// <summary>
            /// 0x00
            /// </summary>
            public static byte H00 = 0x00;
        }

        public static class HexDataType
        {
            /// <summary>
            /// 0x00
            /// </summary>
            public static byte BIT = 0x00;
            /// <summary>
            /// 0x01
            /// </summary>
            public static byte BYTE = 0x01;
            /// <summary>
            /// 0x02
            /// </summary>
            public static byte WORD = 0x02;
            /// <summary>
            /// 0x03
            /// </summary>
            public static byte DWORD = 0x03;

            /// <summary>
            /// 0x14 데이터 타입(연속)
            /// </summary>
            public static byte STREAM = 0x14;
        }

        public static class GetDataIndexStepUnit
        {
            public static int WORD =4;
            public static int DWORD = 6;
        }

        #region //Write - sendData
        public static byte[] MakeWriteByteOneData(string[] arrAddress, string strSetValue)
        {
            byte[] bDataFrame = MakeWriteByteSettings(ByteCheckAddress(arrAddress), ByteCheckMinMax(strSetValue));
            byte[] bFrame = MakeHeader(bDataFrame);
            bFrame = ByteCombine(bFrame, bDataFrame);

            return bFrame;
        }
        public static byte[] MakeWriteWordOneData(string[] arrAddress, string strSetValue)
        {
            byte[] bDataFrame = MakeWriteWordSettings(arrAddress, Uint16CheckMinMax(strSetValue));
            byte[] bFrame = MakeHeader(bDataFrame);
            bFrame = ByteCombine(bFrame, bDataFrame);
            return bFrame;
        }

        public static byte[] MakeWriteDoubleWordOneData(string[] arrAddress, string strSetValue, string sInt32_Float)
        {
            double plcCalcAddr = Convert.ToDouble(arrAddress[1]);
            double plcRealAddr = 0;
            if (plcCalcAddr == 0)
                plcRealAddr = 0;
            else if (plcCalcAddr % 2 == 0)
            {
                plcCalcAddr = plcCalcAddr / 2;
                plcRealAddr = plcCalcAddr;
            }
            arrAddress[1] = plcRealAddr.ToString();

            byte[] bDataFrame = MakeWriteDoubleWordSettings(arrAddress, ValueCheckMinMax(strSetValue, sInt32_Float), sInt32_Float);
            byte[] bFrame = MakeHeader(bDataFrame);
            bFrame = ByteCombine(bFrame, bDataFrame);
            return bFrame;
        }
        #endregion //Write - sendData



        public static byte[] MakeHeader(byte[] dataFrame)
        {
            //LSIS 고유번호 : LSIS-XGT 시리즈
            //Company ID - 10byte
            //PLC Info - 2byte
            //CPU Info - 1byte
            //Source Of Frame - 1byte
            //Invoke ID - 2byte
            //Length - 2byte
            //FEnet Position - 1 Byte
            //Reserved2(BCC) - 1byte

            byte[] FrameHeader = null;
            string company_id = "LSIS-XGT";
            FrameHeader = System.Text.Encoding.Default.GetBytes(company_id);

            //reserved - 예비
            byte RESERVE01 = 0x00;
            byte RESERVE02 = 0x00;
            byte PLC_INFO_01 = 0x00;// fix
            byte PLC_INFO_02 = 0x00;// fix
            byte XGB_MK = 0xB0;   //byte CPU_INFO = 0xB0;// XGB(MK))

            byte INVOKE_ID01 = 0x00;//프레임간 구변 ID
            byte INVOKE_ID02 = 0x00;
            byte HMI_TO_PLC = 0x33;//Client->Server 프레임 디렉션
            //byte FRAME_INDEX = 0x00; //0x0000 프레임 순서번호
                                     //위치정보 : 0x01 베이스번호(0), 슬롯번호(1)
                                     //byte PLC_TO_MHI = 0x11;
            byte[] cpu_info = new byte[] {
                RESERVE01, RESERVE02,
                PLC_INFO_01, PLC_INFO_02,
                XGB_MK, HMI_TO_PLC,
                INVOKE_ID01, INVOKE_ID02 //인식번호(0번)
            };
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
        }

        /// <summary>
        /// CRC 코드 생성
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static ushort MakeCRC(byte[] data)
        {
            ushort crc = 0xFFFF;
            for (int pos = 0; pos < data.Length; pos++)
            {
                crc ^= (UInt16)data[pos];
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

        public static byte[] ByteCombine(byte[] a, byte[] b)
        {
            byte[] c = new byte[a.Length + b.Length];
            Buffer.BlockCopy(a, 0, c, 0, a.Length);
            Buffer.BlockCopy(b, 0, c, a.Length, b.Length);
            return c;
        }

        public static Byte ByteCheckMinMax(string strVal)
        {
            double dVal = Convert.ToDouble(strVal);
            byte dataVal = 0;
            if (dVal > Byte.MaxValue)
            {
                dVal = Byte.MaxValue;
            }
            else if (dVal < Byte.MinValue)
            {
                dVal = Byte.MinValue;
            }
            return dataVal = (Byte)dVal;
        }

        public static UInt16 Uint16CheckMinMax(string strVal)
        {
            double dVal = Convert.ToDouble(strVal);
            UInt16 u16DataVal = 0;
            if (dVal > UInt16.MaxValue)
            {
                dVal = UInt16.MaxValue;
            }
            else if (dVal < UInt16.MinValue)
            {
                dVal = UInt16.MinValue;
            }
            return u16DataVal = (UInt16)dVal;
        }

        public static object ValueCheckMinMax(string strVal, string sInt32_Float)
        {
            double dVal = Convert.ToDouble(strVal);
            object rtnVal = 0;
            if (dVal > Int32.MaxValue)
            {
                dVal = Int32.MaxValue;
            }
            else if (dVal < Int32.MinValue)
            {
                dVal = Int32.MinValue;
            }

            if (sInt32_Float.Equals("FLOAT"))
            {
                return rtnVal = (Single)dVal;
            }
            else
            {
                return rtnVal = (Int32)dVal;
            }
        }

        
        #region// Write BYTE(8bit, 1byte)
        private static byte[] MakeWriteByteSettings(string[] arrAddress, byte dataVal)
        {
            byte[] dataFrame = new byte[] {
                XGT.HexTag.WRITE, XGT.HexTag.H00,
                XGT.HexDataType.BYTE, XGT.HexTag.H00,
                0x00, XGT.HexTag.H00,
                //0x02, XGT.TAG_HEX.H00};
                0x01, XGT.HexTag.H00};

            byte[] bBlock = new byte[0];
            byte[] dataBlock = MakeWriteByteMapBlock(bBlock, XGT.MEMDEVICE.SelectMapName(arrAddress[0]) + XGT.DATATYPE_STRING.BYTE + arrAddress[1]);

            dataFrame = ByteCombine(dataFrame, dataBlock);

            byte[] bData = MakeWriteByteDataBlock(dataVal);
            dataFrame = ByteCombine(dataFrame, bData);
            return dataFrame;
        }
        private static byte[] MakeWriteByteMapBlock(byte[] varBlock, string varName)
        {
            byte[] varLengh = new byte[2] { (byte)varName.Length, XGT.HexTag.H00 };
            varBlock = ByteCombine(varBlock, varLengh);

            byte[] varFrame = System.Text.Encoding.Default.GetBytes(varName);
            varBlock = ByteCombine(varBlock, varFrame);
            return varBlock;
        }
        private static byte[] MakeWriteByteDataBlock(byte dataVal)
        {
            byte[] bData = new byte[0];
            byte[] dByteData = new byte[1] { 0 };

            //if (CB_M10.Checked) dByteData[0] += 1;
            //if (CB_M11.Checked) dByteData[0] += 2;
            //if (CB_M12.Checked) dByteData[0] += 4;// (2*2);
            //if (CB_M13.Checked) dByteData[0] += 8;
            //if (CB_M14.Checked) dByteData[0] += 16;
            //if (CB_M15.Checked) dByteData[0] += 32;
            //if (CB_M16.Checked) dByteData[0] += 64;
            //if (CB_M17.Checked) dByteData[0] += 128;
            dByteData[0] = Convert.ToByte(dataVal);
            byte[] dataCount = new byte[2] { XGT.HexDataType.BYTE, XGT.HexTag.H00 };//byte 수
            bData = ByteCombine(bData, dataCount);
            bData = ByteCombine(bData, dByteData);
            //bData = MakeWriteByte_step6(bData, ByteData);

            //ByteData[0] = 0;
            //if (CB_M18.Checked) ByteData[0] += 1;
            //if (CB_M19.Checked) ByteData[0] += 2;
            //if (CB_M1A.Checked) ByteData[0] += 4;// (2*2);
            //if (CB_M1B.Checked) ByteData[0] += 8;
            //if (CB_M1C.Checked) ByteData[0] += 16;
            //if (CB_M1D.Checked) ByteData[0] += 32;
            //if (CB_M1E.Checked) ByteData[0] += 64;
            //if (CB_M1F.Checked) ByteData[0] += 128;
            //bData = MakeWriteByte_step6(bData, ByteData);

            return bData;
        }
        private static string[] ByteCheckAddress(string[] arrAddress)
        {
            double plcCalcAddr = Convert.ToDouble(arrAddress[1]);
            double plcRealAddr = 0;
            if (plcCalcAddr == 0)
            {
                plcRealAddr = 0;
            }
            else if (plcCalcAddr % 2 == 0)
            {
                plcCalcAddr = plcCalcAddr * 2;
                plcRealAddr = (UInt16)plcCalcAddr;
            }
            else
            {
                plcCalcAddr = plcCalcAddr * 2 - 1;
                plcRealAddr = (UInt16)plcCalcAddr;
            }
            arrAddress[1] = plcRealAddr.ToString();

            return arrAddress;
        }

        #endregion// Write BYTE(8bit, 1byte)

        #region// Write WORD(16bit, 2byte)
        private static byte[] MakeWriteWordSettings(string[] arrAddress, ushort u16dataVal)
        {
            //Data_frame 쓰기 명령 0x58, 0x00
            //Data type  WORD  0x02, 0x00
            //Reserved 예비  0x00, 0x00,
            //BlockNo 변수 개수 1
            byte[] dataFrame = new byte[] {
                XGT.HexTag.WRITE, XGT.HexTag.H00,
                XGT.HexDataType.WORD, XGT.HexTag.H00,
                0x00, XGT.HexTag.H00,
                0x01, XGT.HexTag.H00};

            byte[] varBlock = MakeWriteWordMapBlock(arrAddress);
            dataFrame = ByteCombine(dataFrame, varBlock);

            byte[] bData = MakeWriteWordDataBlock(u16dataVal);
            dataFrame = ByteCombine(dataFrame, bData);
            return dataFrame;
        }
        private static byte[] MakeWriteWordMapBlock(string[] arrAddress)
        {
            byte[] varBlock = new byte[0];

            string mapName = XGT.MEMDEVICE.SelectMapName(arrAddress[0]);
            string mapAddr = arrAddress[1];
            string varName;
            varName = mapName + XGT.DATATYPE_STRING.WORD + mapAddr;
            byte[] varFrame = System.Text.Encoding.Default.GetBytes(varName);
            byte[] varLengh = new byte[2] { (byte)varName.Length, XGT.HexTag.H00 };

            varBlock = ByteCombine(varBlock, varLengh);
            varBlock = ByteCombine(varBlock, varFrame);

            return varBlock;
        }
        private static byte[] MakeWriteWordDataBlock(ushort u16dataVal)
        {
            byte[] bData = new byte[0];
            byte[] bDataCount = new byte[2] { 0x01, XGT.HexTag.H00 };
            bData = ByteCombine(bData, bDataCount);

            byte[] bWordData = BitConverter.GetBytes(u16dataVal);
            bData = ByteCombine(bData, bWordData);

            return bData;

        }
        private static byte[] MakeByteDatas_WORD_WRITE(string strValue)
        {
            byte[] bData =  new byte[0];
            byte[] bDataCount = new byte[2] { 0x01, XGT.HexTag.H00 };
            bData = ByteCombine(bData, bDataCount);

            byte[] bWordData = BitConverter.GetBytes(Convert.ToInt16(strValue));
            bData = ByteCombine(bData, bWordData);

            return bData;
        }
        #endregion// Write WORD(16bit, 2byte)

        #region //Write DWORD (32bit, 4byte)
        private static byte[] MakeWriteDoubleWordSettings(string[] arrAddress, object iValue, string sInt32_Float)
        {
            //Data_frame 쓰기 명령 0x58, 0x00
            //Data type  DOUBLE WORD  0x03, 0x00
            //Reserved 예비  0x00, 0x00,
            //BlockNo 변수 개수 2, 0x02, 0x00

            byte[] bDataFrame = new byte[] {
                XGT.HexTag.WRITE, XGT.HexTag.H00,
                XGT.HexDataType.DWORD, XGT.HexTag.H00,
                0x00, XGT.HexTag.H00,
                //0x02, XGT.TAG_HEX.H00 };
                0x01, XGT.HexTag.H00 };
            byte[] bVariableBlock = MakeWriteDoubleWordMapBlock(arrAddress);
            bDataFrame = ByteCombine(bDataFrame, bVariableBlock);

            byte[] bData = MakeWriteDoubleWordDataBlock(iValue, sInt32_Float);
            bDataFrame = ByteCombine(bDataFrame, bData);

            return bDataFrame;
        }
        private static byte[] MakeWriteDoubleWordMapBlock(string[] arrAddress)
        {
            byte[] varBlock = new byte[0];

            string mapName = XGT.MEMDEVICE.SelectMapName(arrAddress[0]);
            string mapAddr = arrAddress[1];
            string varName = mapName + XGT.DATATYPE_STRING.DWORD + mapAddr;

            byte[] varLengh = new byte[2] { (byte)varName.Length, XGT.HexTag.H00 };
            varBlock = ByteCombine(varBlock, varLengh);

            byte[] varFrame = System.Text.Encoding.Default.GetBytes(varName);
            varBlock = ByteCombine(varBlock, varFrame);

            return varBlock;
        }
        private static byte[] MakeWriteDoubleWordDataBlock(object value, string sInt32_Float) // Int32 iValue)//string strValue)
        {
            //Double word : 32bit 4byte
            //참고, DW일때는 주소의 반절을 주소값으로 함
            byte[] bData = new byte[0];
            byte[] bDataCount = new byte[2] { XGT.HexDataType.WORD, XGT.HexTag.H00 };//?0x02?0x04?

            byte[] bWordData = null;
            if (sInt32_Float.Equals("FLOAT"))
            {
                bWordData = BitConverter.GetBytes(Convert.ToSingle(value));
            }
            else
            {
                bWordData = BitConverter.GetBytes(Convert.ToInt32(value));
            }

            bData = ByteCombine(bData, bDataCount);
            bData = ByteCombine(bData, bWordData);

            return bData;
        }

        public static byte[] MakeSendData(byte[] dataFrame)
        {
            byte[] sendFrame = MakeHeader(dataFrame);
            sendFrame = ByteCombine(sendFrame, dataFrame);
            return sendFrame;
        }

        internal static int AddressCalcDword2Word(int iMapNo1)
        {
            return iMapNo1 / 2;
        }
        internal static int AddressCalcByte2Word(int iMapNo1)
        {
            return iMapNo1 * 2;
        }

        internal static byte IntToHex(int iDataCount)
        {
            byte bRtn = 0x00;
            switch (iDataCount)
            {
                case 1: bRtn = 0x01; break;
                case 2: bRtn= 0x02; break;
                case 3: bRtn= 0x03; break;
                case 4: bRtn= 0x04; break;
                case 5: bRtn= 0x05; break;
                case 6: bRtn= 0x06; break;
                case 7: bRtn= 0x07; break;
                case 8: bRtn= 0x08; break;
                case 9: bRtn = 0x09; break;
                case 10: bRtn= 0x0A; break;
                case 11: bRtn= 0x0B; break;
                case 12: bRtn= 0x0C; break;
                case 13: bRtn= 0x0D; break;
                case 14: bRtn= 0x0E; break;
                case 15: bRtn= 0x0F; break;
                case 16: bRtn= 0x10; break;
                case 17: bRtn= 0x11; break;
                case 18: bRtn= 0x12; break;
                case 19: bRtn= 0x13; break;
                case 20: bRtn= 0x14; break;
                case 21: bRtn= 0x15; break;
                case 22: bRtn= 0x16; break;
                case 23: bRtn= 0x17; break;
                case 24: bRtn= 0x18; break;
                case 25: bRtn= 0x19; break;
                case 26: bRtn= 0x1A; break;
                case 27: bRtn= 0x1B; break;
                case 28: bRtn= 0x1C; break;
                case 29: bRtn= 0x1D; break;
                case 30: bRtn= 0x1E; break;
                case 31: bRtn = 0x1F; break;
            }

            return bRtn;
        }
        #endregion
    }
}

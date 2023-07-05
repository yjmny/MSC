using System;
using System.Text;
using System.Threading.Tasks;
using static HMI_TEMI2500.Protocol;

namespace HMI_TEMI2500
{
    public static class Protocol
    {
        /// <summary>
        /// DELIMITER_STX 
        /// </summary>
        public static byte stx = 0x02;
        /// <summary>
        /// DELIMITER_CR
        /// </summary>
        public static byte cr = 0x0D;
        /// <summary>
        /// DELIMITER_LF
        /// </summary>
        public static byte lf = 0x0A;
        /// <summary>
        /// DELIMITER_CRLF
        /// </summary>
        public static byte[] crlf = { 0x0D, 0x0A };
        internal static readonly string hmi_id = "01";
        internal static readonly string comma = ",";
        public static bool IsAcqureEnd { get; internal set; }
        public static string SignalDregister { get; internal set; }
        public static object RecvD1 { get; internal set; }
        public static object RecvD2 { get; internal set; }
        public static object RecvD5 { get; internal set; }
        public static object RecvD1D5 { get; internal set; }
        public static object RecvD6 { get; internal set; }
        public static object RecvD2D6 { get; internal set; }
        public static object RecvD1D2D5D6 { get; internal set; }
        public static object RecvD1D2D5D6D24D25D26 { get; internal set; }

        public static object RecvD7 { get; internal set; }
        public static object RecvD8 { get; internal set; }
        public static object RecvD10 { get; internal set; }
        public static object RecvD24 { get; internal set; }
        public static object RecvD25 { get; internal set; }
        public static object RecvD26 { get; internal set; }
        public static object RecvD24D25D26 { get; internal set; }
        public static object RecvD104 { get; internal set; }

        public static object RecvD1708 { get; internal set; }
        public static object RecvD1725_TO_D1733 { get; internal set; }
        public static object RecvD1725 { get; internal set; }
        public static object RecvD1726 { get; internal set; }
        public static object RecvD1727 { get; internal set; }
        public static object RecvD1728 { get; internal set; }
        public static object RecvD1729 { get; internal set; }
        public static object RecvD1730 { get; internal set; }
        public static object RecvD1731 { get; internal set; }
        public static object RecvD1732 { get; internal set; }
        public static object RecvD1733 { get; internal set; }
        public static object RecvDataOK { get; internal set; }
        /// <summary>
        ///RSD = 1,
        ///RRD = 2,
        ///WSD = 3,
        /// </summary>
        public static int I32RecvTypeCheck { get; internal set; }


        public enum I32RecvType
        {
            RSD = 1,
            RRD = 2,
            WSD = 3,
        }
        public enum I32DecimalPoint
        {
            Zero = 0,
            F1 = 1,
            F2 = 2,
        }
        public static string ByteArrayToHex(byte[] a)
        {
            string hashHex = System.BitConverter.ToString(a);

            hashHex = hashHex.Replace("-", " ");
            return hashHex;
        }

        public static void WaitDelayFromSeconds(double val)
        {
            Task.Delay(TimeSpan.FromSeconds(val)).GetAwaiter().GetResult();
        }
        public static void WaitDelayFromMilliseconds(double val)
        {
            Task.Delay(TimeSpan.FromMilliseconds(val)).GetAwaiter().GetResult();
        }

        public static int HexStringToDec(string hex)
        {
            int res = 0;
            int power = 1;

            for (int i = hex.Length - 1; i >= 0; i--)
            {
                int tmp = 0;
                switch (hex[i])
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
                        tmp = hex[i] - '0';
                        break;
                }
                res += tmp * power;
                power *= 16;
            }

            return res;
        }

        internal static string ReadCommand(string[] strArray, int length)
        {
            StringBuilder sb = new StringBuilder(10, 2048);
            for (int i = 0; i < strArray.Length; i++)
            {
                sb.Append(strArray[i]);
                if (i <= strArray.Length - 2)
                    sb.Append(comma);
            }
            string strCmdList = sb.ToString();
            string sCount = string.Format("{0:D2}", length);

            StringBuilder sbCmd = new StringBuilder(10, 2048);
            sbCmd.Append(hmi_id);
            sbCmd.Append(CMD.RRD);
            sbCmd.Append(comma);
            sbCmd.Append(sCount);
            sbCmd.Append(comma);
            sbCmd.Append(strCmdList);

            string strRtn = sbCmd.ToString();
            sb = null;
            sbCmd = null;
            strCmdList = null;
            return strRtn;
        }

        internal static string ReadCommand(string addr, string addr2, int count)
        {
            // ▪ 개수: 1 ~64
            //▪ Data: 16진수의 소수점 없는 데이터
            //◈ 예제
            //온도 PV(D0001), 온도 SP(D0002)의 D-Register를 읽는 경우
            // -송신 : [stx] 01RRD,02,0001,0002[cr][lf]
            // - 송신(CheckSum 포함) : [stx] 01RRD,02,0001,0002B2[cr][lf]
            // 수신된 온도 PV(D0001) 값이 50.0이고, 온도 SP(D0002) 값이 30.0일 경우
            // -수신 : [stx] 01RRD,OK,01F4,012C[cr][lf]
            // - 수신(CheckSum 포함) : [stx] 01RRD,OK,01F4,012C18[cr][lf]


            //※ 수신된 16진수 데이터의 PV값을 화면에 디스플레이 하기 위해서 변환하는 과정
            // ① 10진수로 변환 : 01F4(16진수) → 500(10진수)
            // ② 변환한 값에 0.1을 곱한다. : 500 * 0.1 → 50.0

            string sCount = string.Format("{0:D2}", count);
            return hmi_id + CMD.RRD + comma + sCount + comma + addr + comma + addr2;
        }
        internal static string ReadCommand(string addr, int count)
        {
            //온도 PV(D0001)에서 온도 SP(D0002)까지의 D-Register를 읽는 경우
            // -송신 : [stx] 01RSD,02,0001[cr][lf]
            // - 송신(CheckSum 포함) : [stx] 01RSD,02,0001C5[cr][lf]
            // ([stx] = 0x02, [cr] = 0x0d, [lf] = 0x0a)
            //수신된 온도 PV(D0001) 값이 50.0이고, 온도 SP(D0002) 값이 30.0일 경우
            // -수신 : [stx] 01RSD,OK,01F4,012C[cr][lf]
            // - 수신(CheckSum 포함) : [stx] 01RSD,OK,01F4,012C19[cr][lf]


            //※ 수신된 16진수 데이터의 PV값을 화면에 디스플레이 하기 위해서 변환하는 과정
            // ① 10진수로 변환 : 01F4(16진수) → 500(10진수)
            // ② 변환한 값에 0.1을 곱한다. : 500 * 0.1 → 50.0

            string sCount = string.Format("{0:D2}", count);
            return hmi_id + CMD.RSD + comma + sCount + comma + addr;
        }
        internal static string WriteCommand(string addr, int count, int decimal_point, string val1)// , string val2 )//double val1=50.0, double val2=80.0)
        {
            //FIX운전시의 온도 SP(D0102)와 습도 SP(D0103)에 데이터를 쓸 경우
            //-온도 SP 설정 : 50.0 ℃ → 소수점제거(500) → 16진수화(0x01F4)
            //- 습도 SP 설정 : 80.0 % → 소수점제거(800) → 16진수화(0x0320)
            //- 송신 : [stx] 01WSD,02,0102,01F4,0320[cr][lf]
            //- 송신(CheckSum 포함) : [stx] 01WSD,02,0102,01F4,0320C4[cr][lf]

            //1개 쓸때,
            string sCount = string.Format("{0:D2}", count);
            //HMI의 속성에 따라
            //소수점 1자리인경우 50.0 -> 500
            //소수점 2자리인경우 50.0 -> 5000
            int ratio = 0;
            switch (decimal_point)
            {
                case 0: ratio = 1; break;
                case 1: ratio = 10; break;
                case 2: ratio = 100; break;
            }

            int val1_ratio = (int)(Convert.ToDouble(val1) * ratio);
            string strHexValue = StringToHex(val1_ratio);
            return hmi_id + CMD.WSD + comma + sCount + comma + addr + comma + strHexValue;

            //2개 쓸때,
        }

        private static string StringToHex(int val1_10x)
        {
            //500 -> 01F4
            //5 -> 0005
            string strHex = Convert.ToString(val1_10x, 16);
            strHex = strHex.PadLeft(4, '0');
            return strHex;
        }




        public static class CMD
        {
            public static string AMI = "AMI";//TEMI2500의 모델명 및 Version-Revision 표시
            public static string RSD = "RSD";//D-Register의 연속 읽기(Read
            public static string RRD = "RRD";//RRD D-Register의 Random 읽기(Read)
            public static string WSD = "WSD";  //WSD D-Register의 연속 쓰기(Write)(일련된위치에쓰기)
            public static string WRD = "WRD"; //WRD D-Register의 Random 쓰기(Write)(다른위치에쓰기)
            public static string STD = "STD"; //STD D-Register의 Random 등록
            public static string CLD = "CLD";  //CLD STD에서 등록된 D-Register의 Call

        }
        public static class ADDRESS
        {


        }
        /// <summary>
        /// 에러코드 수신
        /// </summary>
        public static class ErrorCode
        {
            //STX , 주소, NG, 에러코드, SUM, CR, LF 수신
            //            ▣ 에러코드의 내용
            //에러코드 내 용 비 고
            //01 존재하지 않는 커맨드 지정시 
            //02 존재하지 않는 D-Register 지정시 
            //04 데이터 설정 Error 유효한 데이터 이외의 문자를 사용
            //(데이터는 0~9, A ~F의 16진수만 사용) 
            //08 잘못된 Format 구성시 ▪ 지정한 커맨드 와 Format 이 다름
            //▪ 지정한 개수와 설정된 개수가 다름
            //11 CheckSum Error 
            //12 Monitoring 커맨드 Error 지정된 Monitoring 커맨드가 없음
            //00 기타 Error 발생시
        }


        public static class RSD
        {
            //            5.4 RSD 커맨드
            //D-Register 상의 일련의 데이터를 읽고자 할 때 사용하는 커맨드입니다.
            //▣ 송신 포맷
            //byte 수 1 2 3 1 2 1 4 2 1 1
            //내 용 STX TEMI2500의
            //주소 RSD, 개수, D-Reg.SUM CR LF
            //▣ 수신 포맷
            //byte 수 1 2 3 1 2 1 4 1 …
            //내 용 STX TEMI2500의
            //주소 RSD, OK, Data - 1 , …
            //1 4 2 1 1
            //, Data - n SUM CR LF
            //▪ 개수 : 1 ~ 64
            //▪ Data : 16진수의 소수점 없는 데이터
            //◈ 예제
            //온도 PV(D0001)에서 온도 SP(D0002)까지의 D-Register를 읽는 경우
            // - 송신 : [stx]01RSD,02,0001[cr][lf]
            // - 송신(CheckSum 포함) : [stx]01RSD,02,0001C5[cr][lf]
            // ([stx] = 0x02, [cr] = 0x0d, [lf] = 0x0a)
            //수신된 온도 PV(D0001) 값이 50.0이고, 온도 SP(D0002) 값이 30.0일 경우
            // - 수신 : [stx]01RSD,OK,01F4,012C[cr][lf]
            // - 수신(CheckSum 포함) : [stx]01RSD,OK,01F4,012C19[cr][lf]


            //※ 수신된 16진수 데이터의 PV값을 화면에 디스플레이 하기 위해서 변환하는 과정
            // ① 10진수로 변환 : 01F4(16진수) → 500(10진수)
            // ② 변환한 값에 0.1을 곱한다. : 500 * 0.1 → 50.0
        }


        public static class RRD
        {
            //            5.5 RRD 커맨드
            //D-Register 상의 Random한 데이터를 읽고자 할 때 사용하는 커맨드입니다.
            //▣ 송신 포맷
            //byte 수 1 2 3 1 2 1 4 1 …
            //내 용 STX TEMI2500의
            //주소 RRD, 개수, D-Reg.- 1 , …
            //1 4 2 1 1
            //, D-Reg.- n SUM CR LF
            //▣ 수신 포맷
            //byte 수 1 2 3 1 2 1 4 1 …
            //내 용 STX TEMI2500의
            //주소 RRD, OK, Data - 1 , …
            //1 4 2 1 1
            //, Data - n SUM CR LF
            //▪ 개수 : 1 ~ 64
            //▪ Data : 16진수의 소수점 없는 데이터
            //◈ 예제
            //온도 PV(D0001), 온도 SP(D0002)의 D-Register를 읽는 경우
            // - 송신 : [stx]01RRD,02,0001,0002[cr][lf]
            // - 송신(CheckSum 포함) : [stx]01RRD,02,0001,0002B2[cr][lf]
            // 수신된 온도 PV(D0001) 값이 50.0이고, 온도 SP(D0002) 값이 30.0일 경우
            // - 수신 : [stx]01RRD,OK,01F4,012C[cr][lf]
            // - 수신(CheckSum 포함) : [stx]01RRD,OK,01F4,012C18[cr][lf]
            //SAMWONTECH
            //2nd Edition of TEMI2000_Series IM : Apr. 2014 Page 13 / 59
            //5.6 WSD 커맨드
            //D-Register 상의 일련한 데이터를 쓰고자 할 때 사용하는 커맨드입니다.
            //▣ 송신 포맷
            //byte 수 1 2 3 1 2 1 4 1 4
            //내 용 STX TEMI2500의
            //주소 WSD, 개수, D-Reg. , Data - 1
            //1 … 1 4 2 1 1
            //, … , Data - n SUM CR LF
        }

        public static class WSD
        {
            //            ▣ 수신 포맷
            //byte 수 1 2 3 1 2 2 1 1
            //내 용 STX TEMI2500의
            //주소 WSD, OK SUM CR LF
            //▪ 개수 : 1 ~ 64
            //▪ Data : 16진수의 소수점 없는 데이터
            //◈ 예제
            //FIX운전시의 온도 SP(D0102)와 습도 SP(D0103)에 데이터를 쓸 경우
            //- 온도 SP 설정 : 50.0 ℃ → 소수점제거(500) → 16진수화(0x01F4)
            //- 습도 SP 설정 : 80.0 % → 소수점제거(800) → 16진수화(0x0320)
            //- 송신 : [stx]01WSD,02,0102,01F4,0320[cr][lf]
            //- 송신(CheckSum 포함) : [stx]01WSD,02,0102,01F4,0320C4[cr][lf]
        }

        public static class WRD
        {
            //5.7 WRD 커맨드
            //D-Register 상의 Random한 데이터를 쓰고자 할 때 사용하는 커맨드입니다.
            //▣ 송신 포맷
            //byte 수 1 2 3 1 2 1 4 1 4
            //내 용 STX TEMI2500의
            //주소 WRD, 개수, D-Reg.- 1 , Data - 1
            //1 … 1 4 1 4 2 1 1
            //, … , D-Reg. - n , Data - n SUM CR LF
            //▣ 수신 포맷
            //byte 수 1 2 3 1 2 2 1 1
            //내 용 STX TEMI2500의
            //주소 WRD, OK SUM CR LF
            //▪ 개수 : 1 ~ 64
            //▪ Data : 16진수의 소수점 없는 데이터
            //◈ 예제
            //FIX운전시의 온도 SP(D0102)와 온도 SLOPE(D0106)에 데이터를 쓸 경우
            //- 온도 SP 설정 : 50.0 ℃ → 소수점제거(500) → 16진수화(0x01F4)
            //- 온도 SLOPE 설정 : 0.5 ℃ → 소수점제거(5) → 16진수화(0x0005)
            //- 송신 : [stx]01WRD,02,0102,01F4,0106,0005[cr][lf]
            //- 송신(CheckSum 포함) : [stx]01WRD,02,0102,01F4,0106,0005B6[cr][lf]
        }

        public static class STD
        {
            //            5.8 STD 커맨드
            //TEMI2500에 미리 원하는 D-Register를 등록시키는 커맨드입니다.
            //▣ 송신 포맷
            //byte 수 1 2 3 1 2 1 4 1 4
            //내 용 STX
            //TEMI2500의
            //주소 STD, 개수, D-Reg. - 1 , D-Reg. - 2
            //1 … 1 4 1 4 2 1 1
            //, … , D-Reg. - (n-1) , D-Reg. - n SUM CR LF
            //▣ 수신 포맷
            //byte 수 1 2 3 1 2 2 1 1
            //내 용 STX TEMI2500의
            //주소 STD, OK SUM CR LF
            //▪ 개수 : 1 ~ 64
            //◈ 예제
            //온도 PV(D0001), 온도 SP(D0002), 습도 PV(D0005), 습도 SP(D0006)를 등록하는 경우
            //- 송신 : [stx]01STD,04,0001,0002,0005,0006[cr][lf]
            //- 송신(CheckSum 포함) : [stx]01STD,04,0001,0002,0005,00069A[cr][lf]
        }

        public static class CLD
        {

            //5.9 CLD 커맨드
            //TEMI2500에 STD 커맨드로 미리 등록한 D-Register를 읽어오는 커맨드입니다.
            //▣ 송신 포맷
            //byte 수 1 2 3 2 1 1
            //내 용 STX TEMI2500의
            //주소 CLD SUM CR LF
            //▣ 수신 포맷
            //byte 수 1 2 3 1 2 1 4 1 4
            //내 용 STX TEMI2500의
            //주소 CLD, OK, Data - 1 , Data - 2
            //1 … 1 4 1 4 2 1 1
            //, … , Data - (n-1) , Data - n SUM CR LF
            //▪ Data : 16진수의 소수점 없는 데이터
        }

        public static class AMI
        {
            //            5.10 AMI 커맨드
            //TEMI2500의 정보를 확인할 때 사용하는 커맨드입니다.
            //▣ 송신 포맷
            //byte 수 1 2 3 2 1 1
            //내 용 STX TEMI2500의
            //주소 AMI SUM CR LF
            //▣ 수신 포맷
            //byte 수 1 2 3 1 2 1
            //내 용 STX TEMI2500의
            //주소 AMI, OK ,
            //9 2 7 2 1 1
            //모델명 SPACE Version-Revision SUM CR LF
            //◈ 예제
            //TEMI2500의 정보를 확인할 경우
            //- 송신 : [STX]01AMI[CR][LF]
            // - 송신 (CheckSum 포함) : [STX]01AMI38[CR][LF]
            //- 수신 : [STX]01AMI, OK, TEMI-2000[sp][sp] V00-R00[CR][LF]
            // - 수신 (CheckSum 포함) : [stx]01AMI, OK, TEMI-2000[sp][sp] V00-R001D[cr][lf]
        }

        //public class CommandStruct
        //{
        //    //            6.1 통신 커맨드의 구성 
        //    //▣ 데이터 포맷
        //    //내 용 ASCII RTU
        //    //통신선두문자 :(콜론) 없음
        //    //통신종단문자[CR][LF] 없음
        //    //데이터길이 7-bit(고정) 8-bit(고정)
        //    //데이터형식 ASCII Binary
        //    //에러 검출 LRC
        //    //(Longitudinal Redundancy Check)
        //    //CRC-16
        //    //(Cyclic Redundancy Check)
        //    //데이터시간간격 1초 이하 24-bit 시간 이하
        //    //▣ 프레임의 구성 
        //    //▶ Modbus ASCII
        //    //선두문자 통신주소 기능코드 데이터 LRC Check 종단문자
        //    //1문자 2문자 2문자 N 문자 2문자 2문자(CR+LF)
        //    //▶ Modbus RTU
        //    //선두문자 통신주소 기능코드 데이터 CRC Check 종단문자
        //    //없음 8-bit 8-bit N * 8-bit 16-bit 없음
        //    //▪ N : 16진수 데이터 개수
        //    //SAMWONTECH
        //    //2nd Edition of TEMI2000_Series IM : Apr. 2014 Page 19 / 59
        //    //6.2 통신 기능 코드
        //    //Modbus 통신 기능코드는 D-Register의 내용을 Read/Write 할 수 있는 기능코드와 루프백(Loop-Back) 검출 기능 코드로
        //    //구성되어 있습니다.
        //    //기능코드 내 용




        //    //MODBUS 프로토콜 사용시 D-Register는 0 부터 사용되기 때문에, D-Register 테이블에서 정의된 번호에
        //    //서 1을 뺀 번호를 적용해야만 합니다.
        //}

        //03 D-Register의 연속 읽기
        public class FuntionCode_03
        {

            //6.3 기능 코드 - 03 
            //기능코드 - 03은 연속된 D-Register의 내용을 최대 64개까지 읽을 수 있습니다.
            //▣ 송신 포맷
            //내 용 ASCII RTU
            //통신선두문자 :(콜론) 없음
            //통신주소 2문자 8-bit
            //기능코드 - 03 2문자 8-bit
            //D-Register Hi 2문자 8-bit
            //D-Register Lo 2문자 8-bit
            //읽을 개수 Hi 2문자 8-bit
            //읽을 개수 Lo 2문자 8-bit
            //에러 검출 2문자 16-bit
            //통신종단문자 2문자(CR+LF) 없음
            //◈ 예제
            //온도 PV(D0001)에서 온도 SP(D0002)까지의 D-Register를 읽는 경우
            // - MODBUS ASCII :010300000002FA[cr][lf]
            // - MODBUS RTU 010300000002C40B
            //☞ D-Register 테이블에서 정의된 번호에서 1을 뺀 번호를 적용해야 됩니다.
            //▣ 수신 포맷
            //내 용 ASCII RTU
            //통신선두문자 :(콜론) 없음
            //통신주소 2문자 8-bit
            //기능코드 - 03 2문자 8-bit
            //데이터 byte 수 2문자 8-bit
            //데이터 - 1 Hi 2문자 8-bit
            //데이터 - 1 Lo 2문자 8-bit
            //… … …
            //데이터 - n Hi 2문자 8-bit
            //데이터 - n Lo 2문자 8-bit
            //에러 검출 2문자 16-bit
            //통신종단문자 2문자(CR+LF) 없음
            //◈ 예제
            //수신된 온도 PV(D0001) 값이 49.3이고, 온도 SP(D0002) 값이 10.8일 경우
            // - MODBUS ASCII :01030401ED006C9E[cr][lf]
            // - MODBUS RTU 01030401ED006C6BD7
        }

        //06 단일 D-Register 쓰기
        public class FuntionCode_06
        {
            //            6.4 기능 코드 - 06 
            //기능코드 - 06은 단일 D-Register 내용을 기입 할 수 있습니다.
            //▣ 송신 Format
            //내 용 ASCII RTU
            //통신선두문자 :(콜론) 없음
            //통신주소 2문자 8-bit
            //기능코드 - 06 2문자 8-bit
            //D-Register Hi 2문자 8-bit
            //D-Register Lo 2문자 8-bit
            //쓰기 데이터 Hi 2문자 8-bit
            //쓰기 데이터 Lo 2문자 8-bit
            //에러 검출 2문자 16-bit
            //통신종단문자 2문자(CR+LF) 없음
            //◈ 예제
            //운전 할 패턴번호(D0100)에‘2’를 설정 할 경우
            // - MODBUS ASCII :01060063000294[cr][lf]
            // - MODBUS RTU 010600630002F815
            //☞ D-Register 테이블에서 정의된 번호에서 1을 뺀 번호를 적용해야 됩니다.
            //▣ 수신 포맷
            //내 용 ASCII RTU
            //통신선두문자 :(콜론) 없음
            //통신주소 2문자 8-bit
            //기능코드 - 06 2문자 8-bit
            //D-Register Hi 2문자 8-bit
            //D-Register Lo 2문자 8-bit
            //쓰기 데이터 Hi 2문자 8-bit
            //쓰기 데이터 Lo 2문자 8-bit
            //에러 검출 2문자 16-bit
            //통신종단문자 2문자(CR+LF) 없음
            //◈ 예제
            // 정상적으로 설정되었을 경우, 아래와 같이 수신됩니다.
            // - MODBUS ASCII :01060063000294[cr][lf]
            // - MODBUS RTU 010600630002F815
        }
        //08 Diagnostics(Loop-Back Test)
        public class FuntionCode_08
        {
            //        6.5 기능 코드 - 08 
            //기능코드 - 08은 자기 진단용으로 사용됩니다.
            //▣ 송신 포맷
            //내 용 ASCII RTU
            //통신선두문자 :(콜론) 없음
            //통신주소 2문자 8-bit
            //기능코드 - 08 2문자 8-bit
            //진단코드 Hi 2문자 8-bit
            //진단코드 Lo 2문자 8-bit
            //데이터 Hi 2문자 8-bit
            //데이터 Lo 2문자 8-bit
            //에러 검출 2문자 16-bit
            //통신종단문자 2문자(CR+LF) 없음
            //◈ 예제
            //아래와 같은 프레임을 자기 진단용으로 송신 했을 경우
            // - MODBUS ASCII :010800000002F5[cr][lf]
            // - MODBUS RTU 01080000000261CA
            //▣ 수신 포맷
            //내 용 ASCII RTU
            //통신선두문자 :(콜론) 없음
            //통신주소 2문자 8-bit
            //기능코드 - 08 2문자 8-bit
            //진단코드 Hi 2문자 8-bit
            //진단코드 Lo 2문자 8-bit
            //데이터 Hi 2문자 8-bit
            //데이터 Lo 2문자 8-bit
            //에러 검출 2문자 16-bit
            //통신종단문자 2문자(CR+LF) 없음
            //◈ 예제
            // 정상적으로 설정되었을 경우, 아래와 같이 수신됩니다.
            // - MODBUS ASCII :010800000002F5[cr][lf]
            // - MODBUS RTU 01080000000261CA
        }
        //16 D-Register 연속 쓰기
        public class FuntionCode_16
        {
            //            6.6 기능 코드 - 16 
            //기능코드 - 16은 일련의 D-Register의 내용을 최대 64개까지 기입 할 수 있습니다.
            //▣ 송신 포맷
            //내 용 ASCII RTU
            //통신선두문자 :(콜론) 없음
            //통신주소 2문자 8-bit
            //기능코드 - 16 2문자 8-bit
            //D-Register Hi 2문자 8-bit
            //D-Register Lo 2문자 8-bit
            //쓰기 개수 Hi 2문자 8-bit
            //쓰기 개수 Lo 2문자 8-bit
            //데이터 byte 수 2문자 8-bit
            //데이터 - 1 Hi 2문자 8-bit
            //데이터 - 1 Lo 2문자 8-bit
            //… … …
            //데이터 - n Hi 2문자 8-bit
            //데이터 - n Lo 2문자 8-bit
            //통신종단문자 2문자 16-bit
            //에러 검출 2문자(CR+LF) 없음

            //◈ 예제
            //정치 운전에서의 온도 SP(D0102)에‘10.0’을, 습도 SP(D0103)에‘20.0’을 설정 할 경우
            // - MODBUS ASCII :01100065000204006400C858[cr][lf]
            // - MODBUS RTU 01100065000204006400C875F1

            //▣ 수신 포맷


            //내 용 ASCII RTU
            //통신선두문자 :(콜론) 없음
            //통신주소 2문자 8-bit
            //기능코드 - 16 2문자 8-bit
            //D-Register Hi 2문자 8-bit
            //D-Register Lo 2문자 8-bit
            //쓰기 개수 Hi 2문자 8-bit
            //쓰기 개수 Lo 2문자 8-bit
            //에러 검출 2문자 16-bit
            //통신종단문자 2문자(CR+LF) 없음
            //◈ 예제
            //정상적으로 설정되었을 경우, 아래와 같이 수신됩니다.
            // - MODBUS ASCII :01100065000288[cr][lf]
            // - MODBUS RTU 01100065000251D7
        }

        /// <summary>
        ///  //            7. D-REGISTER 설명
        //D-Register는 TEMI2500의 모든 상태를 통신을 통하여 확인 할 수 있도록 제공되는 데이터들의 모임입니다.
        //내용에 따라서 기본적으로 100개 단위로 그룹화 되어 있으며 그 내용은 다음과 같습니다.
        //D-Register 범위 그룹명 내 용 Read Write
        //D0001~D0099 PROCESS 기본 운전 정보 표시 ○ ◈
        //D0100 ~D0199 FUNCTION 운전 정보 설정 ○ ○
        //D0200 ~D0299 RESERVATION 시계 및 예약기능 설정 ○ △
        //D0300 ~D0399 ON/OFF SIGNAL ON/OFF 시그널 설정 ○ ○
        //D0400 ~D0499 INNER SIGNAL INNER 시그널 설정 ○ ○
        //D0500 ~D0599 ALARM SIGNAL ALARM 시그널 설정 ○ ○
        //D0600 ~D0699 TIME SIGNAL TIME 시그널 설정 ○ ○
        //D0700 ~D0799 PID P.I.D 설정 ○ ○
        //D0800~D0899 COMMUNICATION 통신관련 정보 ○ ◈
        //D0900 ~D0999 INPUT 입력 설정 ○ ○
        //D1000 ~D1099 OUTPUT 제어 출력 설정 ○ ○
        //D1100 ~D1199 DO CONFIG DO 설정 ○ △
        //D1200 ~D1299 DI CONFIG1 DI 설정 ○ ○
        //D1300 ~D1399 DI CONFIG2 DI NAME 설정-1 ○ ○
        //D1400 ~D1499 DI CONFIG3 DI NAME 설정-2 ○ ○
        //D1500 ~D1599 PICTURE PICTURE 보기 설정 ○ ○
        //D1600 ~D1699 INITIAL 초기 설정 ○ ○
        //D1700 ~D1799 PROGRAM 프로그램 패턴 설정 ○ ○
        //D1800 ~D1899 PATTERN INFO1 패턴 정보-1 ○ ◈
        //D1900 ~D1999 PATTERN INFO2 패턴 정보-2 ○ ◈
        //D2000 ~D2099 RESERVED 예비 ◈ ◈
        //D2100 ~D2999 FILE1 ~FILE9 파일 정보 ○ ◈
        //☞ 각각의 D-Register는 16진수 4자리(2-Byte)로 구성되어 있습니다.
        //▪ ○ : 적용된 범위의 모든 파라메터에서 읽기 또는 쓰기가 가능합니다.
        //▪ △ : 적용된 범위에서 부분적으로 읽기 또는 쓰기가 가능합니다.
        //▪ ◈ : 적용된 범위의 모든 파라메터에서 읽기 또는 쓰기가 안됩니다.
        /// </summary>
        public class D_REGISTER
        {
            //-Read
            //1 현재 온도 | D0001 | TEMP.NPV
            //2 설정 온도 | D0002 | TEMP.NSP
            //5 현재 습도 | D0005 | HUMI.NPV
            //6 설정 습도 | D0006 | HUMI.NSP
            //7 온도 출력값 | D0007 | TEMP.MVOUT
            //8 습도 출력값 | D0008 | HUMI.MVOUT
            //24 운전시간 시 | D0024 | RUN.TIME_H
            //25 운전시간 분 | D0025 | RUN.TIME_M
            //26 운전시간 초 | D0026 | RUN.TIME_S

            //-Write
            //101 COM.OPMODE |D0101| 1 또는 4 | RUN / STOP
            //온도설정
            //습도설정

            public const string D1 = "0001";//현재 온도
            public const string D2 = "0002";//설정 온도
            public const string D5 = "0005";//현재 습도
            public const string D6 = "0006";//설정 습도
            public const string D7 = "0007";
            public const string D8 = "0008";
            /// <summary>
            /// 반환값 가동중 2, 중지 4
            /// </summary>
            public const string D10 = "0010";
            public const string D24 = "0024";
            public const string D25 = "0025";
            public const string D26 = "0026";
            public const string D100 = "0100";
            public const string D101 = "0101";
            public const string D102 = "0102";
            public const string D103 = "0103";
            public const string D104 = "0104";
            public const string D1701 = "1701";
            public const string D1702 = "1702";
            public const string D1707 = "1707";
            public const string D1708 = "1708";
            public const string D1725 = "1725";

            public const string D1D5 = "D1D5";
            public const string D2D6 = "D2D6";
            public const string D1D2D5D6 = "D1D2D5D6";
            public const string D1D2D5D6D24D25D26 = "D1D2D5D6D24D25D26";
            public const string D24D25D26 = "D24D25D26";//시분초 
            public const string D1725_TO_D1733 = "D1725_TO_D1733";

            public class SYMBOL
            {
                public static string _0001_ = "SET_PTNO";
                public static string _0002_TEMP_NPV = "TEMP_NPV";
                public static string _0003_TEMP_NSP = "TEMP_NSP";
                public static string _0004_WET_NPV = "WET_NPV";
                public static string _0005_WET_NSP = "WET_NSP";
                public static string _0006_HUMI_NPV = "HUMI_NPV";
                public static string _0007_HUMI_NSP = "HUMI_NSP";
                public static string _0008_TEMP_MVOUT = "TEMP_MVOUT";
                public static string _0009_HUMI_MVOUT = "HUMI_MVOUT";
                public static string _0010_C_PIDNO = "C_PIDNO";
                public static string _0011_NOW_STS = "NOW_STS";
                public static string _0012_IS_STS = "IS_STS";
                public static string _0013_TS_STS = "TS_STS";
                public static string _0014_ALM_STS = "ALM_STS";
                public static string _0015_ONOFF_STS = "ONOFF_STS";
                public static string _0016_DOCTR_STS = "DOCTR_STS";
                public static string _0017_CTR_STS = "CTR_STS";
                public static string _0018_USEROUT_STSL = "USEROUT_STSL";
                public static string _0019_USEROUT_STSH = "USEROUT_STSH";
                public static string _0020_DI_DATA = "DI_DATA";
                public static string _0021_ADERR_STS = "ADERR_STS";
                public static string _0022_ = "0";
                public static string _0023_ = "0";
                public static string _0024_RUN_TIME_H = "RUN_TIME_H";
                public static string _0025_RUN_TIME_M = "RUN_TIME_M";
                public static string _0026_RUN_TIME_S = "RUN_TIME_S";
                public static string _0027_RUN_PTNO = "RUN_PTNO";
                public static string _0028_RUN_SEGNO = "RUN_SEGNO";
                public static string _0029_NOW_PT_RPT = "NOW_PT_RPT";
                public static string _0030_TOTAL_PT_RPT = "TOTAL_PT_RPT";
                public static string _0031_NOW_SEG_RPT = "NOW_SEG_RPT";
                public static string _0032_TOTAL_SEG_RPT = "TOTAL_SEG_RPT";
                public static string _0033_NOW_SEGTIME_H = "NOW_SEGTIME_H";
                public static string _0034_NOW_SEGTIME_L = "NOW_SEGTIME_L";
                public static string _0035_TOTAL_SEGTIME_H = "TOTAL_SEGTIME_H";
                public static string _0036_TOTAL_SEGTIME_L = "TOTAL_SEGTIME_L";
                public static string _0037_ = "0";
                public static string _0038_ = "0";
                public static string _0039_PREV_TEMP_TSP = "PREV_TEMP_TSP";
                public static string _0040_NOW_TEMP_TSP = "NOW_TEMP_TSP";
                public static string _0041_PREV_HUMI_TSP = "PREV_HUMI_TSP";
                public static string _0042_NOW_HUMI_TSP = "NOW_HUMI_TSP";
                public static string _0043_ = "0";
                public static string _0044_ = "0";
                public static string _0045_ = "0";
                public static string _0046_ = "0";
                public static string _0047_ = "0";
                public static string _0048_ = "0";
                public static string _0049_ = "0";
                public static string _0050_USED_PATTERN = "USED_PATTERN";
                public static string _0051_USED_SEGMENT = "USED_SEGMENT";
                public static string _0052_ = "";
                public static string _0053_ = "0";
                public static string _0054_ = "0";
                public static string _0055_ = "0";
                public static string _0056_ = "0";
                public static string _0057_ = "0";
                public static string _0058_ = "0";
                public static string _0059_ = "0";
                public static string _0060_ = "0";
                public static string _0061_ = "0";
                public static string _0062_ = "0";
                public static string _0063_ = "0";
                public static string _0064_ = "0";
                public static string _0065_ = "0";
                public static string _0066_ = "0";
                public static string _0067_ = "0";
                public static string _0068_ = "0";
                public static string _0069_ = "0";
                public static string _0070_ = "0";
                public static string _0071_ = "0";
                public static string _0072_ = "0";
                public static string _0073_ = "0";
                public static string _0074_ = "0";
                public static string _0075_ = "0";
                public static string _0076_ = "0";
                public static string _0077_ = "0";
                public static string _0078_ = "0";
                public static string _0079_ = "0";
                public static string _0080_ = "0";
                public static string _0081_ = "0";
                public static string _0082_ = "0";
                public static string _0083_ = "0";
                public static string _0084_ = "0";
                public static string _0085_ = "0";
                public static string _0086_ = "0";
                public static string _0087_ = "0";
                public static string _0088_ = "0";
                public static string _0089_ = "0";
                public static string _0090_ = "0";
                public static string _0091_ = "0";
                public static string _0092_ = "0";
                public static string _0093_ = "0";
                public static string _0094_ = "0";
                public static string _0095_ = "0";
                public static string _0096_ = "0";
                public static string _0097_ = "0";
                public static string _0098_ = "0";
                public static string _0099_ = "0";
                public static string _0100_SET_PTNO = "SET_PTNO";
                public static string _0101_COM_OPMODE = "COM_OPMODE";
                public static string _0102_FIX_TEMP_TSP = "FIX_TEMP_TSP";
                public static string _0103_FIX_HUMI_TSP = "FIX_HUMI_TSP";
                public static string _0104_OP_MODE = "OP_MODE";
                public static string _0105_PWR_MODE = "PWR_MODE";
                public static string _0106_TEMP_SLOPE = "TEMP_SLOPE";
                public static string _0107_HUMI_SLOPE = "HUMI_SLOPE";
                public static string _0108_FUZZY = "FUZZY";
                public static string _0109_TIME_OP = "TIME_OP";
                public static string _0110_TIME_OP_H = "TIME_OP_H";
                public static string _0111_TIME_OP_M = "TIME_OP_M";
                public static string _0112_KEYLOCK = "KEYLOCK";
                public static string _0113_ = "0";
                public static string _0114_LIGHT_OFFTM = "LIGHT_OFFTM";
                public static string _0115_ = "0";
                public static string _0116_ = "0";
                public static string _0117_ = "0";
                public static string _0118_ = "0";
                public static string _0119_ = "0";
                public static string _0120_RESTRICT_MAIN = "RESTRICT_MAIN";
                public static string _0121_ = "0";
                public static string _0122_ = "0";
                public static string _0123_ = "0";
                public static string _0124_REC_PLACE = "REC_PLACE";
                public static string _0125_ = "0";
                public static string _0126_ = "0";
                public static string _0127_ = "0";
                public static string _0128_ = "0";
                public static string _0129_REC_OP = "REC_OP";
                public static string _0130_REC_CYCLE = "REC_CYCLE";
                public static string _0131_BACK_ITEM = "BACK_ITEM";
                public static string _0132_BACK_DIR = "BACK_DIR";
                public static string _0133_ = "0";
                public static string _0134_ = "0";
                public static string _0135_ = "0";
                public static string _0136_TEMP_AT = "TEMP_AT";
                public static string _0137_HUMI_AT = "HUMI_AT";
                public static string _0138_ = "0";
                public static string _0139_ = "0";
                public static string _0140_WAIT_USE = "WAIT_USE";
                public static string _0141_WAIT_TZONE = "WAIT_TZONE";
                public static string _0142_WAIT_HZONE = "WAIT_HZONE";
                public static string _0143_WAIT_TIME = "WAIT_TIME";
                public static string _0144_WAIT_METHOD = "WAIT_METHOD";
                public static string _0145_ = "0";
                public static string _0146_ = "0";
                public static string _0147_PV_FONT = "PV_FONT";
                public static string _0148_HUMI_DISPLAY = "HUMI_DISPLAY";
                public static string _0149_BUZ_ONOFF = "BUZ_ONOFF";
                public static string _0150_ = "0";
                public static string _0151_ = "0";
                public static string _0152_ = "0";
                public static string _0153_ = "0";
                public static string _0154_ = "0";
                public static string _0155_ = "0";
                public static string _0156_ = "0";
                public static string _0157_ = "0";
                public static string _0158_ = "0";
                public static string _0159_ = "0";
                public static string _0160_ = "0";
                public static string _0161_ = "0";
                public static string _0162_ = "0";
                public static string _0163_ = "0";
                public static string _0164_ = "0";
                public static string _0165_ = "0";
                public static string _0166_ = "0";
                public static string _0167_ = "0";
                public static string _0168_ = "0";
                public static string _0169_ = "0";
                public static string _0170_ = "0";
                public static string _0171_ = "0";
                public static string _0172_ = "0";
                public static string _0173_ = "0";
                public static string _0174_ = "0";
                public static string _0175_ = "0";
                public static string _0176_ = "0";
                public static string _0177_ = "0";
                public static string _0178_ = "0";
                public static string _0179_ = "0";
                public static string _0180_ = "0";
                public static string _0181_ = "0";
                public static string _0182_ = "0";
                public static string _0183_ = "0";
                public static string _0184_ = "0";
                public static string _0185_ = "0";
                public static string _0186_ = "0";
                public static string _0187_ = "0";
                public static string _0188_ = "0";
                public static string _0189_ = "0";
                public static string _0190_ = "0";
                public static string _0191_ = "0";
                public static string _0192_ = "0";
                public static string _0193_ = "0";
                public static string _0194_ = "0";
                public static string _0195_ = "0";
                public static string _0196_ = "0";
                public static string _0197_ = "0";
                public static string _0198_ = "0";
                public static string _0199_ = "0";
                public static string _0200_ = "0";
                public static string _0201_ = "0";
                public static string _0202_ = "0";
                public static string _0203_ = "0";
                public static string _0204_ = "0";
                public static string _0205_ = "0";
                public static string _0206_ = "0";
                public static string _0207_ = "0";
                public static string _0208_ = "0";
                public static string _0209_ = "0";
                public static string _0210_ = "0";
                public static string _0211_ = "0";
                public static string _0212_ = "0";
                public static string _0213_ = "0";
                public static string _0214_ = "0";
                public static string _0215_ = "0";
                public static string _0216_ = "0";
                public static string _0217_ = "0";
                public static string _0218_ = "0";
                public static string _0219_ = "0";
                public static string _0220_ = "0";
                public static string _0221_ = "0";
                public static string _0222_ = "0";
                public static string _0223_ = "0";
                public static string _0224_ = "0";
                public static string _0225_ = "0";
                public static string _0226_ = "0";
                public static string _0227_ = "0";
                public static string _0228_ = "0";
                public static string _0229_ = "0";
                public static string _0230_ = "0";
                public static string _0231_ = "0";
                public static string _0232_ = "0";
                public static string _0233_ = "0";
                public static string _0234_ = "0";
                public static string _0235_ = "0";
                public static string _0236_ = "0";
                public static string _0237_ = "0";
                public static string _0238_ = "0";
                public static string _0239_ = "0";
                public static string _0240_ = "0";
                public static string _0241_ = "0";
                public static string _0242_ = "0";
                public static string _0243_ = "0";
                public static string _0244_ = "0";
                public static string _0245_ = "0";
                public static string _0246_ = "0";
                public static string _0247_ = "0";
                public static string _0248_ = "0";
                public static string _0249_ = "0";
                public static string _0250_ = "0";
                public static string _0251_ = "0";
                public static string _0252_ = "0";
                public static string _0253_ = "0";
                public static string _0254_ = "0";
                public static string _0255_ = "0";
                public static string _0256_ = "0";
                public static string _0257_ = "0";
                public static string _0258_ = "0";
                public static string _0259_ = "0";
                public static string _0260_ = "0";
                public static string _0261_ = "0";
                public static string _0262_ = "0";
                public static string _0263_ = "0";
                public static string _0264_ = "0";
                public static string _0265_ = "0";
                public static string _0266_ = "0";
                public static string _0267_ = "0";
                public static string _0268_ = "0";
                public static string _0269_ = "0";
                public static string _0270_ = "0";
                public static string _0271_ = "0";
                public static string _0272_ = "0";
                public static string _0273_ = "0";
                public static string _0274_ = "0";
                public static string _0275_ = "0";
                public static string _0276_ = "0";
                public static string _0277_ = "0";
                public static string _0278_ = "0";
                public static string _0279_ = "0";
                public static string _0280_ = "0";
                public static string _0281_ = "0";
                public static string _0282_ = "0";
                public static string _0283_ = "0";
                public static string _0284_ = "0";
                public static string _0285_ = "0";
                public static string _0286_ = "0";
                public static string _0287_ = "0";
                public static string _0288_ = "0";
                public static string _0289_ = "0";
                public static string _0290_ = "0";
                public static string _0291_ = "0";
                public static string _0292_ = "0";
                public static string _0293_ = "0";
                public static string _0294_ = "0";
                public static string _0295_ = "0";
                public static string _0296_ = "0";
                public static string _0297_ = "0";
                public static string _0298_ = "0";
                public static string _0299_ = "0";
                public static string _0300_ = "0";
                public static string _0301_ = "0";
                public static string _0302_ = "0";
                public static string _0303_ = "0";
                public static string _0304_ = "0";
                public static string _0305_ = "0";
                public static string _0306_ = "0";
                public static string _0307_ = "0";
                public static string _0308_ = "0";
                public static string _0309_ = "0";
                public static string _0310_ = "0";
                public static string _0311_ = "0";
                public static string _0312_ = "0";
                public static string _0313_ = "0";
                public static string _0314_ = "0";
                public static string _0315_ = "0";
                public static string _0316_ = "0";
                public static string _0317_ = "0";
                public static string _0318_ = "0";
                public static string _0319_ = "0";
                public static string _0320_ = "0";
                public static string _0321_ = "0";
                public static string _0322_ = "0";
                public static string _0323_ = "0";
                public static string _0324_ = "0";
                public static string _0325_ = "0";
                public static string _0326_ = "0";
                public static string _0327_ = "0";
                public static string _0328_ = "0";
                public static string _0329_ = "0";
                public static string _0330_ = "0";
                public static string _0331_ = "0";
                public static string _0332_ = "0";
                public static string _0333_ = "0";
                public static string _0334_ = "0";
                public static string _0335_ = "0";
                public static string _0336_ = "0";
                public static string _0337_ = "0";
                public static string _0338_ = "0";
                public static string _0339_ = "0";
                public static string _0340_ = "0";
                public static string _0341_ = "0";
                public static string _0342_ = "0";
                public static string _0343_ = "0";
                public static string _0344_ = "0";
                public static string _0345_ = "0";
                public static string _0346_ = "0";
                public static string _0347_ = "0";
                public static string _0348_ = "0";
                public static string _0349_ = "0";
                public static string _0350_ = "0";
                public static string _0351_ = "0";
                public static string _0352_ = "0";
                public static string _0353_ = "0";
                public static string _0354_ = "0";
                public static string _0355_ = "0";
                public static string _0356_ = "0";
                public static string _0357_ = "0";
                public static string _0358_ = "0";
                public static string _0359_ = "0";
                public static string _0360_ = "0";
                public static string _0361_ = "0";
                public static string _0362_ = "0";
                public static string _0363_ = "0";
                public static string _0364_ = "0";
                public static string _0365_ = "0";
                public static string _0366_ = "0";
                public static string _0367_ = "0";
                public static string _0368_ = "0";
                public static string _0369_ = "0";
                public static string _0370_ = "0";
                public static string _0371_ = "0";
                public static string _0372_ = "0";
                public static string _0373_ = "0";
                public static string _0374_ = "0";
                public static string _0375_ = "0";
                public static string _0376_ = "0";
                public static string _0377_ = "0";
                public static string _0378_ = "0";
                public static string _0379_ = "0";
                public static string _0380_ = "0";
                public static string _0381_ = "0";
                public static string _0382_ = "0";
                public static string _0383_ = "0";
                public static string _0384_ = "0";
                public static string _0385_ = "0";
                public static string _0386_ = "0";
                public static string _0387_ = "0";
                public static string _0388_ = "0";
                public static string _0389_ = "0";
                public static string _0390_ = "0";
                public static string _0391_ = "0";
                public static string _0392_ = "0";
                public static string _0393_ = "0";
                public static string _0394_ = "0";
                public static string _0395_ = "0";
                public static string _0396_ = "0";
                public static string _0397_ = "0";
                public static string _0398_ = "0";
                public static string _0399_ = "0";
                public static string _0400_ = "0";
                public static string _0401_ = "0";
                public static string _0402_ = "0";
                public static string _0403_ = "0";
                public static string _0404_ = "0";
                public static string _0405_ = "0";
                public static string _0406_ = "0";
                public static string _0407_ = "0";
                public static string _0408_ = "0";
                public static string _0409_ = "0";
                public static string _0410_ = "0";
                public static string _0411_ = "0";
                public static string _0412_ = "0";
                public static string _0413_ = "0";
                public static string _0414_ = "0";
                public static string _0415_ = "0";
                public static string _0416_ = "0";
                public static string _0417_ = "0";
                public static string _0418_ = "0";
                public static string _0419_ = "0";
                public static string _0420_ = "0";
                public static string _0421_ = "0";
                public static string _0422_ = "0";
                public static string _0423_ = "0";
                public static string _0424_ = "0";
                public static string _0425_ = "0";
                public static string _0426_ = "0";
                public static string _0427_ = "0";
                public static string _0428_ = "0";
                public static string _0429_ = "0";
                public static string _0430_ = "0";
                public static string _0431_ = "0";
                public static string _0432_ = "0";
                public static string _0433_ = "0";
                public static string _0434_ = "0";
                public static string _0435_ = "0";
                public static string _0436_ = "0";
                public static string _0437_ = "0";
                public static string _0438_ = "0";
                public static string _0439_ = "0";
                public static string _0440_ = "0";
                public static string _0441_ = "0";
                public static string _0442_ = "0";
                public static string _0443_ = "0";
                public static string _0444_ = "0";
                public static string _0445_ = "0";
                public static string _0446_ = "0";
                public static string _0447_ = "0";
                public static string _0448_ = "0";
                public static string _0449_ = "0";
                public static string _0450_ = "0";
                public static string _0451_ = "0";
                public static string _0452_ = "0";
                public static string _0453_ = "0";
                public static string _0454_ = "0";
                public static string _0455_ = "0";
                public static string _0456_ = "0";
                public static string _0457_ = "0";
                public static string _0458_ = "0";
                public static string _0459_ = "0";
                public static string _0460_ = "0";
                public static string _0461_ = "0";
                public static string _0462_ = "0";
                public static string _0463_ = "0";
                public static string _0464_ = "0";
                public static string _0465_ = "0";
                public static string _0466_ = "0";
                public static string _0467_ = "0";
                public static string _0468_ = "0";
                public static string _0469_ = "0";
                public static string _0470_ = "0";
                public static string _0471_ = "0";
                public static string _0472_ = "0";
                public static string _0473_ = "0";
                public static string _0474_ = "0";
                public static string _0475_ = "0";
                public static string _0476_ = "0";
                public static string _0477_ = "0";
                public static string _0478_ = "0";
                public static string _0479_ = "0";
                public static string _0480_ = "0";
                public static string _0481_ = "0";
                public static string _0482_ = "0";
                public static string _0483_ = "0";
                public static string _0484_ = "0";
                public static string _0485_ = "0";
                public static string _0486_ = "0";
                public static string _0487_ = "0";
                public static string _0488_ = "0";
                public static string _0489_ = "0";
                public static string _0490_ = "0";
                public static string _0491_ = "0";
                public static string _0492_ = "0";
                public static string _0493_ = "0";
                public static string _0494_ = "0";
                public static string _0495_ = "0";
                public static string _0496_ = "0";
                public static string _0497_ = "0";
                public static string _0498_ = "0";
                public static string _0499_ = "0";
                public static string _0500_ = "0";
                public static string _0501_ = "0";
                public static string _0502_ = "0";
                public static string _0503_ = "0";
                public static string _0504_ = "0";
                public static string _0505_ = "0";
                public static string _0506_ = "0";
                public static string _0507_ = "0";
                public static string _0508_ = "0";
                public static string _0509_ = "0";
                public static string _0510_ = "0";
                public static string _0511_ = "0";
                public static string _0512_ = "0";
                public static string _0513_ = "0";
                public static string _0514_ = "0";
                public static string _0515_ = "0";
                public static string _0516_ = "0";
                public static string _0517_ = "0";
                public static string _0518_ = "0";
                public static string _0519_ = "0";
                public static string _0520_ = "0";
                public static string _0521_ = "0";
                public static string _0522_ = "0";
                public static string _0523_ = "0";
                public static string _0524_ = "0";
                public static string _0525_ = "0";
                public static string _0526_ = "0";
                public static string _0527_ = "0";
                public static string _0528_ = "0";
                public static string _0529_ = "0";
                public static string _0530_ = "0";
                public static string _0531_ = "0";
                public static string _0532_ = "0";
                public static string _0533_ = "0";
                public static string _0534_ = "0";
                public static string _0535_ = "0";
                public static string _0536_ = "0";
                public static string _0537_ = "0";
                public static string _0538_ = "0";
                public static string _0539_ = "0";
                public static string _0540_ = "0";
                public static string _0541_ = "0";
                public static string _0542_ = "0";
                public static string _0543_ = "0";
                public static string _0544_ = "0";
                public static string _0545_ = "0";
                public static string _0546_ = "0";
                public static string _0547_ = "0";
                public static string _0548_ = "0";
                public static string _0549_ = "0";
                public static string _0550_ = "0";
                public static string _0551_ = "0";
                public static string _0552_ = "0";
                public static string _0553_ = "0";
                public static string _0554_ = "0";
                public static string _0555_ = "0";
                public static string _0556_ = "0";
                public static string _0557_ = "0";
                public static string _0558_ = "0";
                public static string _0559_ = "0";
                public static string _0560_ = "0";
                public static string _0561_ = "0";
                public static string _0562_ = "0";
                public static string _0563_ = "0";
                public static string _0564_ = "0";
                public static string _0565_ = "0";
                public static string _0566_ = "0";
                public static string _0567_ = "0";
                public static string _0568_ = "0";
                public static string _0569_ = "0";
                public static string _0570_ = "0";
                public static string _0571_ = "0";
                public static string _0572_ = "0";
                public static string _0573_ = "0";
                public static string _0574_ = "0";
                public static string _0575_ = "0";
                public static string _0576_ = "0";
                public static string _0577_ = "0";
                public static string _0578_ = "0";
                public static string _0579_ = "0";
                public static string _0580_ = "0";
                public static string _0581_ = "0";
                public static string _0582_ = "0";
                public static string _0583_ = "0";
                public static string _0584_ = "0";
                public static string _0585_ = "0";
                public static string _0586_ = "0";
                public static string _0587_ = "0";
                public static string _0588_ = "0";
                public static string _0589_ = "0";
                public static string _0590_ = "0";
                public static string _0591_ = "0";
                public static string _0592_ = "0";
                public static string _0593_ = "0";
                public static string _0594_ = "0";
                public static string _0595_ = "0";
                public static string _0596_ = "0";
                public static string _0597_ = "0";
                public static string _0598_ = "0";
                public static string _0599_ = "0";
                public static string _0600_ = "0";
                public static string _0601_ = "0";
                public static string _0602_ = "0";
                public static string _0603_ = "0";
                public static string _0604_ = "0";
                public static string _0605_ = "0";
                public static string _0606_ = "0";
                public static string _0607_ = "0";
                public static string _0608_ = "0";
                public static string _0609_ = "0";
                public static string _0610_ = "0";
                public static string _0611_ = "0";
                public static string _0612_ = "0";
                public static string _0613_ = "0";
                public static string _0614_ = "0";
                public static string _0615_ = "0";
                public static string _0616_ = "0";
                public static string _0617_ = "0";
                public static string _0618_ = "0";
                public static string _0619_ = "0";
                public static string _0620_ = "0";
                public static string _0621_ = "0";
                public static string _0622_ = "0";
                public static string _0623_ = "0";
                public static string _0624_ = "0";
                public static string _0625_ = "0";
                public static string _0626_ = "0";
                public static string _0627_ = "0";
                public static string _0628_ = "0";
                public static string _0629_ = "0";
                public static string _0630_ = "0";
                public static string _0631_ = "0";
                public static string _0632_ = "0";
                public static string _0633_ = "0";
                public static string _0634_ = "0";
                public static string _0635_ = "0";
                public static string _0636_ = "0";
                public static string _0637_ = "0";
                public static string _0638_ = "0";
                public static string _0639_ = "0";
                public static string _0640_ = "0";
                public static string _0641_ = "0";
                public static string _0642_ = "0";
                public static string _0643_ = "0";
                public static string _0644_ = "0";
                public static string _0645_ = "0";
                public static string _0646_ = "0";
                public static string _0647_ = "0";
                public static string _0648_ = "0";
                public static string _0649_ = "0";
                public static string _0650_ = "0";
                public static string _0651_ = "0";
                public static string _0652_ = "0";
                public static string _0653_ = "0";
                public static string _0654_ = "0";
                public static string _0655_ = "0";
                public static string _0656_ = "0";
                public static string _0657_ = "0";
                public static string _0658_ = "0";
                public static string _0659_ = "0";
                public static string _0660_ = "0";
                public static string _0661_ = "0";
                public static string _0662_ = "0";
                public static string _0663_ = "0";
                public static string _0664_ = "0";
                public static string _0665_ = "0";
                public static string _0666_ = "0";
                public static string _0667_ = "0";
                public static string _0668_ = "0";
                public static string _0669_ = "0";
                public static string _0670_ = "0";
                public static string _0671_ = "0";
                public static string _0672_ = "0";
                public static string _0673_ = "0";
                public static string _0674_ = "0";
                public static string _0675_ = "0";
                public static string _0676_ = "0";
                public static string _0677_ = "0";
                public static string _0678_ = "0";
                public static string _0679_ = "0";
                public static string _0680_ = "0";
                public static string _0681_ = "0";
                public static string _0682_ = "0";
                public static string _0683_ = "0";
                public static string _0684_ = "0";
                public static string _0685_ = "0";
                public static string _0686_ = "0";
                public static string _0687_ = "0";
                public static string _0688_ = "0";
                public static string _0689_ = "0";
                public static string _0690_ = "0";
                public static string _0691_ = "0";
                public static string _0692_ = "0";
                public static string _0693_ = "0";
                public static string _0694_ = "0";
                public static string _0695_ = "0";
                public static string _0696_ = "0";
                public static string _0697_ = "0";
                public static string _0698_ = "0";
                public static string _0699_ = "0";
                public static string _0700_ = "0";
                public static string _0701_ = "0";
                public static string _0702_ = "0";
                public static string _0703_ = "0";
                public static string _0704_ = "0";
                public static string _0705_ = "0";
                public static string _0706_ = "0";
                public static string _0707_ = "0";
                public static string _0708_ = "0";
                public static string _0709_ = "0";
                public static string _0710_ = "0";
                public static string _0711_ = "0";
                public static string _0712_ = "0";
                public static string _0713_ = "0";
                public static string _0714_ = "0";
                public static string _0715_ = "0";
                public static string _0716_ = "0";
                public static string _0717_ = "0";
                public static string _0718_ = "0";
                public static string _0719_ = "0";
                public static string _0720_ = "0";
                public static string _0721_ = "0";
                public static string _0722_ = "0";
                public static string _0723_ = "0";
                public static string _0724_ = "0";
                public static string _0725_ = "0";
                public static string _0726_ = "0";
                public static string _0727_ = "0";
                public static string _0728_ = "0";
                public static string _0729_ = "0";
                public static string _0730_ = "0";
                public static string _0731_ = "0";
                public static string _0732_ = "0";
                public static string _0733_ = "0";
                public static string _0734_ = "0";
                public static string _0735_ = "0";
                public static string _0736_ = "0";
                public static string _0737_ = "0";
                public static string _0738_ = "0";
                public static string _0739_ = "0";
                public static string _0740_ = "0";
                public static string _0741_ = "0";
                public static string _0742_ = "0";
                public static string _0743_ = "0";
                public static string _0744_ = "0";
                public static string _0745_ = "0";
                public static string _0746_ = "0";
                public static string _0747_ = "0";
                public static string _0748_ = "0";
                public static string _0749_ = "0";
                public static string _0750_ = "0";
                public static string _0751_ = "0";
                public static string _0752_ = "0";
                public static string _0753_ = "0";
                public static string _0754_ = "0";
                public static string _0755_ = "0";
                public static string _0756_ = "0";
                public static string _0757_ = "0";
                public static string _0758_ = "0";
                public static string _0759_ = "0";
                public static string _0760_ = "0";
                public static string _0761_ = "0";
                public static string _0762_ = "0";
                public static string _0763_ = "0";
                public static string _0764_ = "0";
                public static string _0765_ = "0";
                public static string _0766_ = "0";
                public static string _0767_ = "0";
                public static string _0768_ = "0";
                public static string _0769_ = "0";
                public static string _0770_ = "0";
                public static string _0771_ = "0";
                public static string _0772_ = "0";
                public static string _0773_ = "0";
                public static string _0774_ = "0";
                public static string _0775_ = "0";
                public static string _0776_ = "0";
                public static string _0777_ = "0";
                public static string _0778_ = "0";
                public static string _0779_ = "0";
                public static string _0780_ = "0";
                public static string _0781_ = "0";
                public static string _0782_ = "0";
                public static string _0783_ = "0";
                public static string _0784_ = "0";
                public static string _0785_ = "0";
                public static string _0786_ = "0";
                public static string _0787_ = "0";
                public static string _0788_ = "0";
                public static string _0789_ = "0";
                public static string _0790_ = "0";
                public static string _0791_ = "0";
                public static string _0792_ = "0";
                public static string _0793_ = "0";
                public static string _0794_ = "0";
                public static string _0795_ = "0";
                public static string _0796_ = "0";
                public static string _0797_ = "0";
                public static string _0798_ = "0";
                public static string _0799_ = "0";
                public static string _0800_ = "0";
                public static string _0801_ = "0";
                public static string _0802_ = "0";
                public static string _0803_ = "0";
                public static string _0804_ = "0";
                public static string _0805_ = "0";
                public static string _0806_ = "0";
                public static string _0807_ = "0";
                public static string _0808_ = "0";
                public static string _0809_ = "0";
                public static string _0810_ = "0";
                public static string _0811_ = "0";
                public static string _0812_ = "0";
                public static string _0813_ = "0";
                public static string _0814_ = "0";
                public static string _0815_ = "0";
                public static string _0816_ = "0";
                public static string _0817_ = "0";
                public static string _0818_ = "0";
                public static string _0819_ = "0";
                public static string _0820_ = "0";
                public static string _0821_ = "0";
                public static string _0822_ = "0";
                public static string _0823_ = "0";
                public static string _0824_ = "0";
                public static string _0825_ = "0";
                public static string _0826_ = "0";
                public static string _0827_ = "0";
                public static string _0828_ = "0";
                public static string _0829_ = "0";
                public static string _0830_ = "0";
                public static string _0831_ = "0";
                public static string _0832_ = "0";
                public static string _0833_ = "0";
                public static string _0834_ = "0";
                public static string _0835_ = "0";
                public static string _0836_ = "0";
                public static string _0837_ = "0";
                public static string _0838_ = "0";
                public static string _0839_ = "0";
                public static string _0840_ = "0";
                public static string _0841_ = "0";
                public static string _0842_ = "0";
                public static string _0843_ = "0";
                public static string _0844_ = "0";
                public static string _0845_ = "0";
                public static string _0846_ = "0";
                public static string _0847_ = "0";
                public static string _0848_ = "0";
                public static string _0849_ = "0";
                public static string _0850_ = "0";
                public static string _0851_ = "0";
                public static string _0852_ = "0";
                public static string _0853_ = "0";
                public static string _0854_ = "0";
                public static string _0855_ = "0";
                public static string _0856_ = "0";
                public static string _0857_ = "0";
                public static string _0858_ = "0";
                public static string _0859_ = "0";
                public static string _0860_ = "0";
                public static string _0861_ = "0";
                public static string _0862_ = "0";
                public static string _0863_ = "0";
                public static string _0864_ = "0";
                public static string _0865_ = "0";
                public static string _0866_ = "0";
                public static string _0867_ = "0";
                public static string _0868_ = "0";
                public static string _0869_ = "0";
                public static string _0870_ = "0";
                public static string _0871_ = "0";
                public static string _0872_ = "0";
                public static string _0873_ = "0";
                public static string _0874_ = "0";
                public static string _0875_ = "0";
                public static string _0876_ = "0";
                public static string _0877_ = "0";
                public static string _0878_ = "0";
                public static string _0879_ = "0";
                public static string _0880_ = "0";
                public static string _0881_ = "0";
                public static string _0882_ = "0";
                public static string _0883_ = "0";
                public static string _0884_ = "0";
                public static string _0885_ = "0";
                public static string _0886_ = "0";
                public static string _0887_ = "0";
                public static string _0888_ = "0";
                public static string _0889_ = "0";
                public static string _0890_ = "0";
                public static string _0891_ = "0";
                public static string _0892_ = "0";
                public static string _0893_ = "0";
                public static string _0894_ = "0";
                public static string _0895_ = "0";
                public static string _0896_ = "0";
                public static string _0897_ = "0";
                public static string _0898_ = "0";
                public static string _0899_ = "0";
                public static string _0900_ = "0";
                public static string _0901_ = "0";
                public static string _0902_ = "0";
                public static string _0903_ = "0";
                public static string _0904_ = "0";
                public static string _0905_ = "0";
                public static string _0906_ = "0";
                public static string _0907_ = "0";
                public static string _0908_ = "0";
                public static string _0909_ = "0";
                public static string _0910_ = "0";
                public static string _0911_ = "0";
                public static string _0912_ = "0";
                public static string _0913_ = "0";
                public static string _0914_ = "0";
                public static string _0915_ = "0";
                public static string _0916_ = "0";
                public static string _0917_ = "0";
                public static string _0918_ = "0";
                public static string _0919_ = "0";
                public static string _0920_ = "0";
                public static string _0921_ = "0";
                public static string _0922_ = "0";
                public static string _0923_ = "0";
                public static string _0924_ = "0";
                public static string _0925_ = "0";
                public static string _0926_ = "0";
                public static string _0927_ = "0";
                public static string _0928_ = "0";
                public static string _0929_ = "0";
                public static string _0930_ = "0";
                public static string _0931_ = "0";
                public static string _0932_ = "0";
                public static string _0933_ = "0";
                public static string _0934_ = "0";
                public static string _0935_ = "0";
                public static string _0936_ = "0";
                public static string _0937_ = "0";
                public static string _0938_ = "0";
                public static string _0939_ = "0";
                public static string _0940_ = "0";
                public static string _0941_ = "0";
                public static string _0942_ = "0";
                public static string _0943_ = "0";
                public static string _0944_ = "0";
                public static string _0945_ = "0";
                public static string _0946_ = "0";
                public static string _0947_ = "0";
                public static string _0948_ = "0";
                public static string _0949_ = "0";
                public static string _0950_ = "0";
                public static string _0951_ = "0";
                public static string _0952_ = "0";
                public static string _0953_ = "0";
                public static string _0954_ = "0";
                public static string _0955_ = "0";
                public static string _0956_ = "0";
                public static string _0957_ = "0";
                public static string _0958_ = "0";
                public static string _0959_ = "0";
                public static string _0960_ = "0";
                public static string _0961_ = "0";
                public static string _0962_ = "0";
                public static string _0963_ = "0";
                public static string _0964_ = "0";
                public static string _0965_ = "0";
                public static string _0966_ = "0";
                public static string _0967_ = "0";
                public static string _0968_ = "0";
                public static string _0969_ = "0";
                public static string _0970_ = "0";
                public static string _0971_ = "0";
                public static string _0972_ = "0";
                public static string _0973_ = "0";
                public static string _0974_ = "0";
                public static string _0975_ = "0";
                public static string _0976_ = "0";
                public static string _0977_ = "0";
                public static string _0978_ = "0";
                public static string _0979_ = "0";
                public static string _0980_ = "0";
                public static string _0981_ = "0";
                public static string _0982_ = "0";
                public static string _0983_ = "0";
                public static string _0984_ = "0";
                public static string _0985_ = "0";
                public static string _0986_ = "0";
                public static string _0987_ = "0";
                public static string _0988_ = "0";
                public static string _0989_ = "0";
                public static string _0990_ = "0";
                public static string _0991_ = "0";
                public static string _0992_ = "0";
                public static string _0993_ = "0";
                public static string _0994_ = "0";
                public static string _0995_ = "0";
                public static string _0996_ = "0";
                public static string _0997_ = "0";
                public static string _0998_ = "0";
                public static string _0999_ = "0";
                public static string _1000_ = "0";
                public static string _1001_ = "0";
                public static string _1002_ = "0";
                public static string _1003_ = "0";
                public static string _1004_ = "0";
                public static string _1005_ = "0";
                public static string _1006_ = "0";
                public static string _1007_ = "0";
                public static string _1008_ = "0";
                public static string _1009_ = "0";
                public static string _1010_ = "0";
                public static string _1011_ = "0";
                public static string _1012_ = "0";
                public static string _1013_ = "0";
                public static string _1014_ = "0";
                public static string _1015_ = "0";
                public static string _1016_ = "0";
                public static string _1017_ = "0";
                public static string _1018_ = "0";
                public static string _1019_ = "0";
                public static string _1020_ = "0";
                public static string _1021_ = "0";
                public static string _1022_ = "0";
                public static string _1023_ = "0";
                public static string _1024_ = "0";
                public static string _1025_ = "0";
                public static string _1026_ = "0";
                public static string _1027_ = "0";
                public static string _1028_ = "0";
                public static string _1029_ = "0";
                public static string _1030_ = "0";
                public static string _1031_ = "0";
                public static string _1032_ = "0";
                public static string _1033_ = "0";
                public static string _1034_ = "0";
                public static string _1035_ = "0";
                public static string _1036_ = "0";
                public static string _1037_ = "0";
                public static string _1038_ = "0";
                public static string _1039_ = "0";
                public static string _1040_ = "0";
                public static string _1041_ = "0";
                public static string _1042_ = "0";
                public static string _1043_ = "0";
                public static string _1044_ = "0";
                public static string _1045_ = "0";
                public static string _1046_ = "0";
                public static string _1047_ = "0";
                public static string _1048_ = "0";
                public static string _1049_ = "0";
                public static string _1050_ = "0";
                public static string _1051_ = "0";
                public static string _1052_ = "0";
                public static string _1053_ = "0";
                public static string _1054_ = "0";
                public static string _1055_ = "0";
                public static string _1056_ = "0";
                public static string _1057_ = "0";
                public static string _1058_ = "0";
                public static string _1059_ = "0";
                public static string _1060_ = "0";
                public static string _1061_ = "0";
                public static string _1062_ = "0";
                public static string _1063_ = "0";
                public static string _1064_ = "0";
                public static string _1065_ = "0";
                public static string _1066_ = "0";
                public static string _1067_ = "0";
                public static string _1068_ = "0";
                public static string _1069_ = "0";
                public static string _1070_ = "0";
                public static string _1071_ = "0";
                public static string _1072_ = "0";
                public static string _1073_ = "0";
                public static string _1074_ = "0";
                public static string _1075_ = "0";
                public static string _1076_ = "0";
                public static string _1077_ = "0";
                public static string _1078_ = "0";
                public static string _1079_ = "0";
                public static string _1080_ = "0";
                public static string _1081_ = "0";
                public static string _1082_ = "0";
                public static string _1083_ = "0";
                public static string _1084_ = "0";
                public static string _1085_ = "0";
                public static string _1086_ = "0";
                public static string _1087_ = "0";
                public static string _1088_ = "0";
                public static string _1089_ = "0";
                public static string _1090_ = "0";
                public static string _1091_ = "0";
                public static string _1092_ = "0";
                public static string _1093_ = "0";
                public static string _1094_ = "0";
                public static string _1095_ = "0";
                public static string _1096_ = "0";
                public static string _1097_ = "0";
                public static string _1098_ = "0";
                public static string _1099_ = "0";
                public static string _1100_ = "0";
                public static string _1101_ = "0";
                public static string _1102_ = "0";
                public static string _1103_ = "0";
                public static string _1104_ = "0";
                public static string _1105_ = "0";
                public static string _1106_ = "0";
                public static string _1107_ = "0";
                public static string _1108_ = "0";
                public static string _1109_ = "0";
                public static string _1110_ = "0";
                public static string _1111_ = "0";
                public static string _1112_ = "0";
                public static string _1113_ = "0";
                public static string _1114_ = "0";
                public static string _1115_ = "0";
                public static string _1116_ = "0";
                public static string _1117_ = "0";
                public static string _1118_ = "0";
                public static string _1119_ = "0";
                public static string _1120_ = "0";
                public static string _1121_ = "0";
                public static string _1122_ = "0";
                public static string _1123_ = "0";
                public static string _1124_ = "0";
                public static string _1125_ = "0";
                public static string _1126_ = "0";
                public static string _1127_ = "0";
                public static string _1128_ = "0";
                public static string _1129_ = "0";
                public static string _1130_ = "0";
                public static string _1131_ = "0";
                public static string _1132_ = "0";
                public static string _1133_ = "0";
                public static string _1134_ = "0";
                public static string _1135_ = "0";
                public static string _1136_ = "0";
                public static string _1137_ = "0";
                public static string _1138_ = "0";
                public static string _1139_ = "0";
                public static string _1140_ = "0";
                public static string _1141_ = "0";
                public static string _1142_ = "0";
                public static string _1143_ = "0";
                public static string _1144_ = "0";
                public static string _1145_ = "0";
                public static string _1146_ = "0";
                public static string _1147_ = "0";
                public static string _1148_ = "0";
                public static string _1149_ = "0";
                public static string _1150_ = "0";
                public static string _1151_ = "0";
                public static string _1152_ = "0";
                public static string _1153_ = "0";
                public static string _1154_ = "0";
                public static string _1155_ = "0";
                public static string _1156_ = "0";
                public static string _1157_ = "0";
                public static string _1158_ = "0";
                public static string _1159_ = "0";
                public static string _1160_ = "0";
                public static string _1161_ = "0";
                public static string _1162_ = "0";
                public static string _1163_ = "0";
                public static string _1164_ = "0";
                public static string _1165_ = "0";
                public static string _1166_ = "0";
                public static string _1167_ = "0";
                public static string _1168_ = "0";
                public static string _1169_ = "0";
                public static string _1170_ = "0";
                public static string _1171_ = "0";
                public static string _1172_ = "0";
                public static string _1173_ = "0";
                public static string _1174_ = "0";
                public static string _1175_ = "0";
                public static string _1176_ = "0";
                public static string _1177_ = "0";
                public static string _1178_ = "0";
                public static string _1179_ = "0";
                public static string _1180_ = "0";
                public static string _1181_ = "0";
                public static string _1182_ = "0";
                public static string _1183_ = "0";
                public static string _1184_ = "0";
                public static string _1185_ = "0";
                public static string _1186_ = "0";
                public static string _1187_ = "0";
                public static string _1188_ = "0";
                public static string _1189_ = "0";
                public static string _1190_ = "0";
                public static string _1191_ = "0";
                public static string _1192_ = "0";
                public static string _1193_ = "0";
                public static string _1194_ = "0";
                public static string _1195_ = "0";
                public static string _1196_ = "0";
                public static string _1197_ = "0";
                public static string _1198_ = "0";
                public static string _1199_ = "0";
                public static string _1200_ = "0";
                public static string _1201_ = "0";
                public static string _1202_ = "0";
                public static string _1203_ = "0";
                public static string _1204_ = "0";
                public static string _1205_ = "0";
                public static string _1206_ = "0";
                public static string _1207_ = "0";
                public static string _1208_ = "0";
                public static string _1209_ = "0";
                public static string _1210_ = "0";
                public static string _1211_ = "0";
                public static string _1212_ = "0";
                public static string _1213_ = "0";
                public static string _1214_ = "0";
                public static string _1215_ = "0";
                public static string _1216_ = "0";
                public static string _1217_ = "0";
                public static string _1218_ = "0";
                public static string _1219_ = "0";
                public static string _1220_ = "0";
                public static string _1221_ = "0";
                public static string _1222_ = "0";
                public static string _1223_ = "0";
                public static string _1224_ = "0";
                public static string _1225_ = "0";
                public static string _1226_ = "0";
                public static string _1227_ = "0";
                public static string _1228_ = "0";
                public static string _1229_ = "0";
                public static string _1230_ = "0";
                public static string _1231_ = "0";
                public static string _1232_ = "0";
                public static string _1233_ = "0";
                public static string _1234_ = "0";
                public static string _1235_ = "0";
                public static string _1236_ = "0";
                public static string _1237_ = "0";
                public static string _1238_ = "0";
                public static string _1239_ = "0";
                public static string _1240_ = "0";
                public static string _1241_ = "0";
                public static string _1242_ = "0";
                public static string _1243_ = "0";
                public static string _1244_ = "0";
                public static string _1245_ = "0";
                public static string _1246_ = "0";
                public static string _1247_ = "0";
                public static string _1248_ = "0";
                public static string _1249_ = "0";
                public static string _1250_ = "0";
                public static string _1251_ = "0";
                public static string _1252_ = "0";
                public static string _1253_ = "0";
                public static string _1254_ = "0";
                public static string _1255_ = "0";
                public static string _1256_ = "0";
                public static string _1257_ = "0";
                public static string _1258_ = "0";
                public static string _1259_ = "0";
                public static string _1260_ = "0";
                public static string _1261_ = "0";
                public static string _1262_ = "0";
                public static string _1263_ = "0";
                public static string _1264_ = "0";
                public static string _1265_ = "0";
                public static string _1266_ = "0";
                public static string _1267_ = "0";
                public static string _1268_ = "0";
                public static string _1269_ = "0";
                public static string _1270_ = "0";
                public static string _1271_ = "0";
                public static string _1272_ = "0";
                public static string _1273_ = "0";
                public static string _1274_ = "0";
                public static string _1275_ = "0";
                public static string _1276_ = "0";
                public static string _1277_ = "0";
                public static string _1278_ = "0";
                public static string _1279_ = "0";
                public static string _1280_ = "0";
                public static string _1281_ = "0";
                public static string _1282_ = "0";
                public static string _1283_ = "0";
                public static string _1284_ = "0";
                public static string _1285_ = "0";
                public static string _1286_ = "0";
                public static string _1287_ = "0";
                public static string _1288_ = "0";
                public static string _1289_ = "0";
                public static string _1290_ = "0";
                public static string _1291_ = "0";
                public static string _1292_ = "0";
                public static string _1293_ = "0";
                public static string _1294_ = "0";
                public static string _1295_ = "0";
                public static string _1296_ = "0";
                public static string _1297_ = "0";
                public static string _1298_ = "0";
                public static string _1299_ = "0";
                public static string _1300_ = "0";
                public static string _1301_ = "0";
                public static string _1302_ = "0";
                public static string _1303_ = "0";
                public static string _1304_ = "0";
                public static string _1305_ = "0";
                public static string _1306_ = "0";
                public static string _1307_ = "0";
                public static string _1308_ = "0";
                public static string _1309_ = "0";
                public static string _1310_ = "0";
                public static string _1311_ = "0";
                public static string _1312_ = "0";
                public static string _1313_ = "0";
                public static string _1314_ = "0";
                public static string _1315_ = "0";
                public static string _1316_ = "0";
                public static string _1317_ = "0";
                public static string _1318_ = "0";
                public static string _1319_ = "0";
                public static string _1320_ = "0";
                public static string _1321_ = "0";
                public static string _1322_ = "0";
                public static string _1323_ = "0";
                public static string _1324_ = "0";
                public static string _1325_ = "0";
                public static string _1326_ = "0";
                public static string _1327_ = "0";
                public static string _1328_ = "0";
                public static string _1329_ = "0";
                public static string _1330_ = "0";
                public static string _1331_ = "0";
                public static string _1332_ = "0";
                public static string _1333_ = "0";
                public static string _1334_ = "0";
                public static string _1335_ = "0";
                public static string _1336_ = "0";
                public static string _1337_ = "0";
                public static string _1338_ = "0";
                public static string _1339_ = "0";
                public static string _1340_ = "0";
                public static string _1341_ = "0";
                public static string _1342_ = "0";
                public static string _1343_ = "0";
                public static string _1344_ = "0";
                public static string _1345_ = "0";
                public static string _1346_ = "0";
                public static string _1347_ = "0";
                public static string _1348_ = "0";
                public static string _1349_ = "0";
                public static string _1350_ = "0";
                public static string _1351_ = "0";
                public static string _1352_ = "0";
                public static string _1353_ = "0";
                public static string _1354_ = "0";
                public static string _1355_ = "0";
                public static string _1356_ = "0";
                public static string _1357_ = "0";
                public static string _1358_ = "0";
                public static string _1359_ = "0";
                public static string _1360_ = "0";
                public static string _1361_ = "0";
                public static string _1362_ = "0";
                public static string _1363_ = "0";
                public static string _1364_ = "0";
                public static string _1365_ = "0";
                public static string _1366_ = "0";
                public static string _1367_ = "0";
                public static string _1368_ = "0";
                public static string _1369_ = "0";
                public static string _1370_ = "0";
                public static string _1371_ = "0";
                public static string _1372_ = "0";
                public static string _1373_ = "0";
                public static string _1374_ = "0";
                public static string _1375_ = "0";
                public static string _1376_ = "0";
                public static string _1377_ = "0";
                public static string _1378_ = "0";
                public static string _1379_ = "0";
                public static string _1380_ = "0";
                public static string _1381_ = "0";
                public static string _1382_ = "0";
                public static string _1383_ = "0";
                public static string _1384_ = "0";
                public static string _1385_ = "0";
                public static string _1386_ = "0";
                public static string _1387_ = "0";
                public static string _1388_ = "0";
                public static string _1389_ = "0";
                public static string _1390_ = "0";
                public static string _1391_ = "0";
                public static string _1392_ = "0";
                public static string _1393_ = "0";
                public static string _1394_ = "0";
                public static string _1395_ = "0";
                public static string _1396_ = "0";
                public static string _1397_ = "0";
                public static string _1398_ = "0";
                public static string _1399_ = "0";
                public static string _1400_ = "0";
                public static string _1401_ = "0";
                public static string _1402_ = "0";
                public static string _1403_ = "0";
                public static string _1404_ = "0";
                public static string _1405_ = "0";
                public static string _1406_ = "0";
                public static string _1407_ = "0";
                public static string _1408_ = "0";
                public static string _1409_ = "0";
                public static string _1410_ = "0";
                public static string _1411_ = "0";
                public static string _1412_ = "0";
                public static string _1413_ = "0";
                public static string _1414_ = "0";
                public static string _1415_ = "0";
                public static string _1416_ = "0";
                public static string _1417_ = "0";
                public static string _1418_ = "0";
                public static string _1419_ = "0";
                public static string _1420_ = "0";
                public static string _1421_ = "0";
                public static string _1422_ = "0";
                public static string _1423_ = "0";
                public static string _1424_ = "0";
                public static string _1425_ = "0";
                public static string _1426_ = "0";
                public static string _1427_ = "0";
                public static string _1428_ = "0";
                public static string _1429_ = "0";
                public static string _1430_ = "0";
                public static string _1431_ = "0";
                public static string _1432_ = "0";
                public static string _1433_ = "0";
                public static string _1434_ = "0";
                public static string _1435_ = "0";
                public static string _1436_ = "0";
                public static string _1437_ = "0";
                public static string _1438_ = "0";
                public static string _1439_ = "0";
                public static string _1440_ = "0";
                public static string _1441_ = "0";
                public static string _1442_ = "0";
                public static string _1443_ = "0";
                public static string _1444_ = "0";
                public static string _1445_ = "0";
                public static string _1446_ = "0";
                public static string _1447_ = "0";
                public static string _1448_ = "0";
                public static string _1449_ = "0";
                public static string _1450_ = "0";
                public static string _1451_ = "0";
                public static string _1452_ = "0";
                public static string _1453_ = "0";
                public static string _1454_ = "0";
                public static string _1455_ = "0";
                public static string _1456_ = "0";
                public static string _1457_ = "0";
                public static string _1458_ = "0";
                public static string _1459_ = "0";
                public static string _1460_ = "0";
                public static string _1461_ = "0";
                public static string _1462_ = "0";
                public static string _1463_ = "0";
                public static string _1464_ = "0";
                public static string _1465_ = "0";
                public static string _1466_ = "0";
                public static string _1467_ = "0";
                public static string _1468_ = "0";
                public static string _1469_ = "0";
                public static string _1470_ = "0";
                public static string _1471_ = "0";
                public static string _1472_ = "0";
                public static string _1473_ = "0";
                public static string _1474_ = "0";
                public static string _1475_ = "0";
                public static string _1476_ = "0";
                public static string _1477_ = "0";
                public static string _1478_ = "0";
                public static string _1479_ = "0";
                public static string _1480_ = "0";
                public static string _1481_ = "0";
                public static string _1482_ = "0";
                public static string _1483_ = "0";
                public static string _1484_ = "0";
                public static string _1485_ = "0";
                public static string _1486_ = "0";
                public static string _1487_ = "0";
                public static string _1488_ = "0";
                public static string _1489_ = "0";
                public static string _1490_ = "0";
                public static string _1491_ = "0";
                public static string _1492_ = "0";
                public static string _1493_ = "0";
                public static string _1494_ = "0";
                public static string _1495_ = "0";
                public static string _1496_ = "0";
                public static string _1497_ = "0";
                public static string _1498_ = "0";
                public static string _1499_ = "0";
                public static string _1500_ = "0";
                public static string _1501_ = "0";
                public static string _1502_ = "0";
                public static string _1503_ = "0";
                public static string _1504_ = "0";
                public static string _1505_ = "0";
                public static string _1506_ = "0";
                public static string _1507_ = "0";
                public static string _1508_ = "0";
                public static string _1509_ = "0";
                public static string _1510_ = "0";
                public static string _1511_ = "0";
                public static string _1512_ = "0";
                public static string _1513_ = "0";
                public static string _1514_ = "0";
                public static string _1515_ = "0";
                public static string _1516_ = "0";
                public static string _1517_ = "0";
                public static string _1518_ = "0";
                public static string _1519_ = "0";
                public static string _1520_ = "0";
                public static string _1521_ = "0";
                public static string _1522_ = "0";
                public static string _1523_ = "0";
                public static string _1524_ = "0";
                public static string _1525_ = "0";
                public static string _1526_ = "0";
                public static string _1527_ = "0";
                public static string _1528_ = "0";
                public static string _1529_ = "0";
                public static string _1530_ = "0";
                public static string _1531_ = "0";
                public static string _1532_ = "0";
                public static string _1533_ = "0";
                public static string _1534_ = "0";
                public static string _1535_ = "0";
                public static string _1536_ = "0";
                public static string _1537_ = "0";
                public static string _1538_ = "0";
                public static string _1539_ = "0";
                public static string _1540_ = "0";
                public static string _1541_ = "0";
                public static string _1542_ = "0";
                public static string _1543_ = "0";
                public static string _1544_ = "0";
                public static string _1545_ = "0";
                public static string _1546_ = "0";
                public static string _1547_ = "0";
                public static string _1548_ = "0";
                public static string _1549_ = "0";
                public static string _1550_ = "0";
                public static string _1551_ = "0";
                public static string _1552_ = "0";
                public static string _1553_ = "0";
                public static string _1554_ = "0";
                public static string _1555_ = "0";
                public static string _1556_ = "0";
                public static string _1557_ = "0";
                public static string _1558_ = "0";
                public static string _1559_ = "0";
                public static string _1560_ = "0";
                public static string _1561_ = "0";
                public static string _1562_ = "0";
                public static string _1563_ = "0";
                public static string _1564_ = "0";
                public static string _1565_ = "0";
                public static string _1566_ = "0";
                public static string _1567_ = "0";
                public static string _1568_ = "0";
                public static string _1569_ = "0";
                public static string _1570_ = "0";
                public static string _1571_ = "0";
                public static string _1572_ = "0";
                public static string _1573_ = "0";
                public static string _1574_ = "0";
                public static string _1575_ = "0";
                public static string _1576_ = "0";
                public static string _1577_ = "0";
                public static string _1578_ = "0";
                public static string _1579_ = "0";
                public static string _1580_ = "0";
                public static string _1581_ = "0";
                public static string _1582_ = "0";
                public static string _1583_ = "0";
                public static string _1584_ = "0";
                public static string _1585_ = "0";
                public static string _1586_ = "0";
                public static string _1587_ = "0";
                public static string _1588_ = "0";
                public static string _1589_ = "0";
                public static string _1590_ = "0";
                public static string _1591_ = "0";
                public static string _1592_ = "0";
                public static string _1593_ = "0";
                public static string _1594_ = "0";
                public static string _1595_ = "0";
                public static string _1596_ = "0";
                public static string _1597_ = "0";
                public static string _1598_ = "0";
                public static string _1599_ = "0";
                public static string _1600_ = "0";
                public static string _1601_ = "0";
                public static string _1602_ = "0";
                public static string _1603_ = "0";
                public static string _1604_ = "0";
                public static string _1605_ = "0";
                public static string _1606_ = "0";
                public static string _1607_ = "0";
                public static string _1608_ = "0";
                public static string _1609_ = "0";
                public static string _1610_ = "0";
                public static string _1611_ = "0";
                public static string _1612_ = "0";
                public static string _1613_ = "0";
                public static string _1614_ = "0";
                public static string _1615_ = "0";
                public static string _1616_ = "0";
                public static string _1617_ = "0";
                public static string _1618_ = "0";
                public static string _1619_ = "0";
                public static string _1620_ = "0";
                public static string _1621_ = "0";
                public static string _1622_ = "0";
                public static string _1623_ = "0";
                public static string _1624_ = "0";
                public static string _1625_ = "0";
                public static string _1626_ = "0";
                public static string _1627_ = "0";
                public static string _1628_ = "0";
                public static string _1629_ = "0";
                public static string _1630_ = "0";
                public static string _1631_ = "0";
                public static string _1632_ = "0";
                public static string _1633_ = "0";
                public static string _1634_ = "0";
                public static string _1635_ = "0";
                public static string _1636_ = "0";
                public static string _1637_ = "0";
                public static string _1638_ = "0";
                public static string _1639_ = "0";
                public static string _1640_ = "0";
                public static string _1641_ = "0";
                public static string _1642_ = "0";
                public static string _1643_ = "0";
                public static string _1644_ = "0";
                public static string _1645_ = "0";
                public static string _1646_ = "0";
                public static string _1647_ = "0";
                public static string _1648_ = "0";
                public static string _1649_ = "0";
                public static string _1650_ = "0";
                public static string _1651_ = "0";
                public static string _1652_ = "0";
                public static string _1653_ = "0";
                public static string _1654_ = "0";
                public static string _1655_ = "0";
                public static string _1656_ = "0";
                public static string _1657_ = "0";
                public static string _1658_ = "0";
                public static string _1659_ = "0";
                public static string _1660_ = "0";
                public static string _1661_ = "0";
                public static string _1662_ = "0";
                public static string _1663_ = "0";
                public static string _1664_ = "0";
                public static string _1665_ = "0";
                public static string _1666_ = "0";
                public static string _1667_ = "0";
                public static string _1668_ = "0";
                public static string _1669_ = "0";
                public static string _1670_ = "0";
                public static string _1671_ = "0";
                public static string _1672_ = "0";
                public static string _1673_ = "0";
                public static string _1674_ = "0";
                public static string _1675_ = "0";
                public static string _1676_ = "0";
                public static string _1677_ = "0";
                public static string _1678_ = "0";
                public static string _1679_ = "0";
                public static string _1680_ = "0";
                public static string _1681_ = "0";
                public static string _1682_ = "0";
                public static string _1683_ = "0";
                public static string _1684_ = "0";
                public static string _1685_ = "0";
                public static string _1686_ = "0";
                public static string _1687_ = "0";
                public static string _1688_ = "0";
                public static string _1689_ = "0";
                public static string _1690_ = "0";
                public static string _1691_ = "0";
                public static string _1692_ = "0";
                public static string _1693_ = "0";
                public static string _1694_ = "0";
                public static string _1695_ = "0";
                public static string _1696_ = "0";
                public static string _1697_ = "0";
                public static string _1698_ = "0";
                public static string _1699_ = "0";
                public static string _1700_ = "0";
                public static string _1701_ = "0";
                public static string _1702_ = "0";
                public static string _1703_ = "0";
                public static string _1704_ = "0";
                public static string _1705_ = "0";
                public static string _1706_ = "0";
                public static string _1707_ = "0";
                public static string _1708_ = "0";
                public static string _1709_ = "0";
                public static string _1710_ = "0";
                public static string _1711_ = "0";
                public static string _1712_ = "0";
                public static string _1713_ = "0";
                public static string _1714_ = "0";
                public static string _1715_ = "0";
                public static string _1716_ = "0";
                public static string _1717_ = "0";
                public static string _1718_ = "0";
                public static string _1719_ = "0";
                public static string _1720_ = "0";
                public static string _1721_ = "0";
                public static string _1722_ = "0";
                public static string _1723_ = "0";
                public static string _1724_ = "0";
                public static string _1725_ = "0";
                public static string _1726_ = "0";
                public static string _1727_ = "0";
                public static string _1728_ = "0";
                public static string _1729_ = "0";
                public static string _1730_ = "0";
                public static string _1731_ = "0";
                public static string _1732_ = "0";
                public static string _1733_ = "0";
                public static string _1734_ = "0";
                public static string _1735_ = "0";
                public static string _1736_ = "0";
                public static string _1737_ = "0";
                public static string _1738_ = "0";
                public static string _1739_ = "0";
                public static string _1740_ = "0";
                public static string _1741_ = "0";
                public static string _1742_ = "0";
                public static string _1743_ = "0";
                public static string _1744_ = "0";
                public static string _1745_ = "0";
                public static string _1746_ = "0";
                public static string _1747_ = "0";
                public static string _1748_ = "0";
                public static string _1749_ = "0";
                public static string _1750_ = "0";
                public static string _1751_ = "0";
                public static string _1752_ = "0";
                public static string _1753_ = "0";
                public static string _1754_ = "0";
                public static string _1755_ = "0";
                public static string _1756_ = "0";
                public static string _1757_ = "0";
                public static string _1758_ = "0";
                public static string _1759_ = "0";
                public static string _1760_ = "0";
                public static string _1761_ = "0";
                public static string _1762_ = "0";
                public static string _1763_ = "0";
                public static string _1764_ = "0";
                public static string _1765_ = "0";
                public static string _1766_ = "0";
                public static string _1767_ = "0";
                public static string _1768_ = "0";
                public static string _1769_ = "0";
                public static string _1770_ = "0";
                public static string _1771_ = "0";
                public static string _1772_ = "0";
                public static string _1773_ = "0";
                public static string _1774_ = "0";
                public static string _1775_ = "0";
                public static string _1776_ = "0";
                public static string _1777_ = "0";
                public static string _1778_ = "0";
                public static string _1779_ = "0";
                public static string _1780_ = "0";
                public static string _1781_ = "0";
                public static string _1782_ = "0";
                public static string _1783_ = "0";
                public static string _1784_ = "0";
                public static string _1785_ = "0";
                public static string _1786_ = "0";
                public static string _1787_ = "0";
                public static string _1788_ = "0";
                public static string _1789_ = "0";
                public static string _1790_ = "0";
                public static string _1791_ = "0";
                public static string _1792_ = "0";
                public static string _1793_ = "0";
                public static string _1794_ = "0";
                public static string _1795_ = "0";
                public static string _1796_ = "0";
                public static string _1797_ = "0";
                public static string _1798_ = "0";
                public static string _1799_ = "0";
                public static string _1800_ = "0";
                public static string _1801_ = "0";
                public static string _1802_ = "0";
                public static string _1803_ = "0";
                public static string _1804_ = "0";
                public static string _1805_ = "0";
                public static string _1806_ = "0";
                public static string _1807_ = "0";
                public static string _1808_ = "0";
                public static string _1809_ = "0";
                public static string _1810_ = "0";
                public static string _1811_ = "0";
                public static string _1812_ = "0";
                public static string _1813_ = "0";
                public static string _1814_ = "0";
                public static string _1815_ = "0";
                public static string _1816_ = "0";
                public static string _1817_ = "0";
                public static string _1818_ = "0";
                public static string _1819_ = "0";
                public static string _1820_ = "0";
                public static string _1821_ = "0";
                public static string _1822_ = "0";
                public static string _1823_ = "0";
                public static string _1824_ = "0";
                public static string _1825_ = "0";
                public static string _1826_ = "0";
                public static string _1827_ = "0";
                public static string _1828_ = "0";
                public static string _1829_ = "0";
                public static string _1830_ = "0";
                public static string _1831_ = "0";
                public static string _1832_ = "0";
                public static string _1833_ = "0";
                public static string _1834_ = "0";
                public static string _1835_ = "0";
                public static string _1836_ = "0";
                public static string _1837_ = "0";
                public static string _1838_ = "0";
                public static string _1839_ = "0";
                public static string _1840_ = "0";
                public static string _1841_ = "0";
                public static string _1842_ = "0";
                public static string _1843_ = "0";
                public static string _1844_ = "0";
                public static string _1845_ = "0";
                public static string _1846_ = "0";
                public static string _1847_ = "0";
                public static string _1848_ = "0";
                public static string _1849_ = "0";
                public static string _1850_ = "0";
                public static string _1851_ = "0";
                public static string _1852_ = "0";
                public static string _1853_ = "0";
                public static string _1854_ = "0";
                public static string _1855_ = "0";
                public static string _1856_ = "0";
                public static string _1857_ = "0";
                public static string _1858_ = "0";
                public static string _1859_ = "0";
                public static string _1860_ = "0";
                public static string _1861_ = "0";
                public static string _1862_ = "0";
                public static string _1863_ = "0";
                public static string _1864_ = "0";
                public static string _1865_ = "0";
                public static string _1866_ = "0";
                public static string _1867_ = "0";
                public static string _1868_ = "0";
                public static string _1869_ = "0";
                public static string _1870_ = "0";
                public static string _1871_ = "0";
                public static string _1872_ = "0";
                public static string _1873_ = "0";
                public static string _1874_ = "0";
                public static string _1875_ = "0";
                public static string _1876_ = "0";
                public static string _1877_ = "0";
                public static string _1878_ = "0";
                public static string _1879_ = "0";
                public static string _1880_ = "0";
                public static string _1881_ = "0";
                public static string _1882_ = "0";
                public static string _1883_ = "0";
                public static string _1884_ = "0";
                public static string _1885_ = "0";
                public static string _1886_ = "0";
                public static string _1887_ = "0";
                public static string _1888_ = "0";
                public static string _1889_ = "0";
                public static string _1890_ = "0";
                public static string _1891_ = "0";
                public static string _1892_ = "0";
                public static string _1893_ = "0";
                public static string _1894_ = "0";
                public static string _1895_ = "0";
                public static string _1896_ = "0";
                public static string _1897_ = "0";
                public static string _1898_ = "0";
                public static string _1899_ = "0";
                public static string _1900_ = "0";
                public static string _1901_ = "0";
                public static string _1902_ = "0";
                public static string _1903_ = "0";
                public static string _1904_ = "0";
                public static string _1905_ = "0";
                public static string _1906_ = "0";
                public static string _1907_ = "0";
                public static string _1908_ = "0";
                public static string _1909_ = "0";
                public static string _1910_ = "0";
                public static string _1911_ = "0";
                public static string _1912_ = "0";
                public static string _1913_ = "0";
                public static string _1914_ = "0";
                public static string _1915_ = "0";
                public static string _1916_ = "0";
                public static string _1917_ = "0";
                public static string _1918_ = "0";
                public static string _1919_ = "0";
                public static string _1920_ = "0";
                public static string _1921_ = "0";
                public static string _1922_ = "0";
                public static string _1923_ = "0";
                public static string _1924_ = "0";
                public static string _1925_ = "0";
                public static string _1926_ = "0";
                public static string _1927_ = "0";
                public static string _1928_ = "0";
                public static string _1929_ = "0";
                public static string _1930_ = "0";
                public static string _1931_ = "0";
                public static string _1932_ = "0";
                public static string _1933_ = "0";
                public static string _1934_ = "0";
                public static string _1935_ = "0";
                public static string _1936_ = "0";
                public static string _1937_ = "0";
                public static string _1938_ = "0";
                public static string _1939_ = "0";
                public static string _1940_ = "0";
                public static string _1941_ = "0";
                public static string _1942_ = "0";
                public static string _1943_ = "0";
                public static string _1944_ = "0";
                public static string _1945_ = "0";
                public static string _1946_ = "0";
                public static string _1947_ = "0";
                public static string _1948_ = "0";
                public static string _1949_ = "0";
                public static string _1950_ = "0";
                public static string _1951_ = "0";
                public static string _1952_ = "0";
                public static string _1953_ = "0";
                public static string _1954_ = "0";
                public static string _1955_ = "0";
                public static string _1956_ = "0";
                public static string _1957_ = "0";
                public static string _1958_ = "0";
                public static string _1959_ = "0";
                public static string _1960_ = "0";
                public static string _1961_ = "0";
                public static string _1962_ = "0";
                public static string _1963_ = "0";
                public static string _1964_ = "0";
                public static string _1965_ = "0";
                public static string _1966_ = "0";
                public static string _1967_ = "0";
                public static string _1968_ = "0";
                public static string _1969_ = "0";
                public static string _1970_ = "0";
                public static string _1971_ = "0";
                public static string _1972_ = "0";
                public static string _1973_ = "0";
                public static string _1974_ = "0";
                public static string _1975_ = "0";
                public static string _1976_ = "0";
                public static string _1977_ = "0";
                public static string _1978_ = "0";
                public static string _1979_ = "0";
                public static string _1980_ = "0";
                public static string _1981_ = "0";
                public static string _1982_ = "0";
                public static string _1983_ = "0";
                public static string _1984_ = "0";
                public static string _1985_ = "0";
                public static string _1986_ = "0";
                public static string _1987_ = "0";
                public static string _1988_ = "0";
                public static string _1989_ = "0";
                public static string _1990_ = "0";
                public static string _1991_ = "0";
                public static string _1992_ = "0";
                public static string _1993_ = "0";
                public static string _1994_ = "0";
                public static string _1995_ = "0";
                public static string _1996_ = "0";
                public static string _1997_ = "0";
                public static string _1998_ = "0";
                public static string _1999_ = "0";
                public static string _2000_ = "0";
                public static string _2001_ = "0";
                public static string _2002_ = "0";
                public static string _2003_ = "0";
                public static string _2004_ = "0";
                public static string _2005_ = "0";
                public static string _2006_ = "0";
                public static string _2007_ = "0";
                public static string _2008_ = "0";
                public static string _2009_ = "0";
                public static string _2010_ = "0";
                public static string _2011_ = "0";
                public static string _2012_ = "0";
                public static string _2013_ = "0";
                public static string _2014_ = "0";
                public static string _2015_ = "0";
                public static string _2016_ = "0";
                public static string _2017_ = "0";
                public static string _2018_ = "0";
                public static string _2019_ = "0";
                public static string _2020_ = "0";
                public static string _2021_ = "0";
                public static string _2022_ = "0";
                public static string _2023_ = "0";
                public static string _2024_ = "0";
                public static string _2025_ = "0";
                public static string _2026_ = "0";
                public static string _2027_ = "0";
                public static string _2028_ = "0";
                public static string _2029_ = "0";
                public static string _2030_ = "0";
                public static string _2031_ = "0";
                public static string _2032_ = "0";
                public static string _2033_ = "0";
                public static string _2034_ = "0";
                public static string _2035_ = "0";
                public static string _2036_ = "0";
                public static string _2037_ = "0";
                public static string _2038_ = "0";
                public static string _2039_ = "0";
                public static string _2040_ = "0";
                public static string _2041_ = "0";
                public static string _2042_ = "0";
                public static string _2043_ = "0";
                public static string _2044_ = "0";
                public static string _2045_ = "0";
                public static string _2046_ = "0";
                public static string _2047_ = "0";
                public static string _2048_ = "0";
                public static string _2049_ = "0";
                public static string _2050_ = "0";
                public static string _2051_ = "0";
                public static string _2052_ = "0";
                public static string _2053_ = "0";
                public static string _2054_ = "0";
                public static string _2055_ = "0";
                public static string _2056_ = "0";
                public static string _2057_ = "0";
                public static string _2058_ = "0";
                public static string _2059_ = "0";
                public static string _2060_ = "0";
                public static string _2061_ = "0";
                public static string _2062_ = "0";
                public static string _2063_ = "0";
                public static string _2064_ = "0";
                public static string _2065_ = "0";
                public static string _2066_ = "0";
                public static string _2067_ = "0";
                public static string _2068_ = "0";
                public static string _2069_ = "0";
                public static string _2070_ = "0";
                public static string _2071_ = "0";
                public static string _2072_ = "0";
                public static string _2073_ = "0";
                public static string _2074_ = "0";
                public static string _2075_ = "0";
                public static string _2076_ = "0";
                public static string _2077_ = "0";
                public static string _2078_ = "0";
                public static string _2079_ = "0";
                public static string _2080_ = "0";
                public static string _2081_ = "0";
                public static string _2082_ = "0";
                public static string _2083_ = "0";
                public static string _2084_ = "0";
                public static string _2085_ = "0";
                public static string _2086_ = "0";
                public static string _2087_ = "0";
                public static string _2088_ = "0";
                public static string _2089_ = "0";
                public static string _2090_ = "0";
                public static string _2091_ = "0";
                public static string _2092_ = "0";
                public static string _2093_ = "0";
                public static string _2094_ = "0";
                public static string _2095_ = "0";
                public static string _2096_ = "0";
                public static string _2097_ = "0";
                public static string _2098_ = "0";
                public static string _2099_ = "0";
                public static string _2100_ = "0";
                public static string _2101_ = "0";
                public static string _2102_ = "0";
                public static string _2103_ = "0";
                public static string _2104_ = "0";
                public static string _2105_ = "0";
                public static string _2106_ = "0";
                public static string _2107_ = "0";
                public static string _2108_ = "0";
                public static string _2109_ = "0";
                public static string _2110_ = "0";
                public static string _2111_ = "0";
                public static string _2112_ = "0";
                public static string _2113_ = "0";
                public static string _2114_ = "0";
                public static string _2115_ = "0";
                public static string _2116_ = "0";
                public static string _2117_ = "0";
                public static string _2118_ = "0";
                public static string _2119_ = "0";
                public static string _2120_ = "0";
                public static string _2121_ = "0";
                public static string _2122_ = "0";
                public static string _2123_ = "0";
                public static string _2124_ = "0";
                public static string _2125_ = "0";
                public static string _2126_ = "0";
                public static string _2127_ = "0";
                public static string _2128_ = "0";
                public static string _2129_ = "0";
                public static string _2130_ = "0";
                public static string _2131_ = "0";
                public static string _2132_ = "0";
                public static string _2133_ = "0";
                public static string _2134_ = "0";
                public static string _2135_ = "0";
                public static string _2136_ = "0";
                public static string _2137_ = "0";
                public static string _2138_ = "0";
                public static string _2139_ = "0";
                public static string _2140_ = "0";
                public static string _2141_ = "0";
                public static string _2142_ = "0";
                public static string _2143_ = "0";
                public static string _2144_ = "0";
                public static string _2145_ = "0";
                public static string _2146_ = "0";
                public static string _2147_ = "0";
                public static string _2148_ = "0";
                public static string _2149_ = "0";
                public static string _2150_ = "0";
                public static string _2151_ = "0";
                public static string _2152_ = "0";
                public static string _2153_ = "0";
                public static string _2154_ = "0";
                public static string _2155_ = "0";
                public static string _2156_ = "0";
                public static string _2157_ = "0";
                public static string _2158_ = "0";
                public static string _2159_ = "0";
                public static string _2160_ = "0";
                public static string _2161_ = "0";
                public static string _2162_ = "0";
                public static string _2163_ = "0";
                public static string _2164_ = "0";
                public static string _2165_ = "0";
                public static string _2166_ = "0";
                public static string _2167_ = "0";
                public static string _2168_ = "0";
                public static string _2169_ = "0";
                public static string _2170_ = "0";
                public static string _2171_ = "0";
                public static string _2172_ = "0";
                public static string _2173_ = "0";
                public static string _2174_ = "0";
                public static string _2175_ = "0";
                public static string _2176_ = "0";
                public static string _2177_ = "0";
                public static string _2178_ = "0";
                public static string _2179_ = "0";
                public static string _2180_ = "0";
                public static string _2181_ = "0";
                public static string _2182_ = "0";
                public static string _2183_ = "0";
                public static string _2184_ = "0";
                public static string _2185_ = "0";
                public static string _2186_ = "0";
                public static string _2187_ = "0";
                public static string _2188_ = "0";
                public static string _2189_ = "0";
                public static string _2190_ = "0";
                public static string _2191_ = "0";
                public static string _2192_ = "0";
                public static string _2193_ = "0";
                public static string _2194_ = "0";
                public static string _2195_ = "0";
                public static string _2196_ = "0";
                public static string _2197_ = "0";
                public static string _2198_ = "0";
                public static string _2199_ = "0";
                public static string _2200_ = "0";
                public static string _2201_ = "0";
                public static string _2202_ = "0";
                public static string _2203_ = "0";
                public static string _2204_ = "0";
                public static string _2205_ = "0";
                public static string _2206_ = "0";
                public static string _2207_ = "0";
                public static string _2208_ = "0";
                public static string _2209_ = "0";
                public static string _2210_ = "0";
                public static string _2211_ = "0";
                public static string _2212_ = "0";
                public static string _2213_ = "0";
                public static string _2214_ = "0";
                public static string _2215_ = "0";
                public static string _2216_ = "0";
                public static string _2217_ = "0";
                public static string _2218_ = "0";
                public static string _2219_ = "0";
                public static string _2220_ = "0";
                public static string _2221_ = "0";
                public static string _2222_ = "0";
                public static string _2223_ = "0";
                public static string _2224_ = "0";
                public static string _2225_ = "0";
                public static string _2226_ = "0";
                public static string _2227_ = "0";
                public static string _2228_ = "0";
                public static string _2229_ = "0";
                public static string _2230_ = "0";
                public static string _2231_ = "0";
                public static string _2232_ = "0";
                public static string _2233_ = "0";
                public static string _2234_ = "0";
                public static string _2235_ = "0";
                public static string _2236_ = "0";
                public static string _2237_ = "0";
                public static string _2238_ = "0";
                public static string _2239_ = "0";
                public static string _2240_ = "0";
                public static string _2241_ = "0";
                public static string _2242_ = "0";
                public static string _2243_ = "0";
                public static string _2244_ = "0";
                public static string _2245_ = "0";
                public static string _2246_ = "0";
                public static string _2247_ = "0";
                public static string _2248_ = "0";
                public static string _2249_ = "0";
                public static string _2250_ = "0";
                public static string _2251_ = "0";
                public static string _2252_ = "0";
                public static string _2253_ = "0";
                public static string _2254_ = "0";
                public static string _2255_ = "0";
                public static string _2256_ = "0";
                public static string _2257_ = "0";
                public static string _2258_ = "0";
                public static string _2259_ = "0";
                public static string _2260_ = "0";
                public static string _2261_ = "0";
                public static string _2262_ = "0";
                public static string _2263_ = "0";
                public static string _2264_ = "0";
                public static string _2265_ = "0";
                public static string _2266_ = "0";
                public static string _2267_ = "0";
                public static string _2268_ = "0";
                public static string _2269_ = "0";
                public static string _2270_ = "0";
                public static string _2271_ = "0";
                public static string _2272_ = "0";
                public static string _2273_ = "0";
                public static string _2274_ = "0";
                public static string _2275_ = "0";
                public static string _2276_ = "0";
                public static string _2277_ = "0";
                public static string _2278_ = "0";
                public static string _2279_ = "0";
                public static string _2280_ = "0";
                public static string _2281_ = "0";
                public static string _2282_ = "0";
                public static string _2283_ = "0";
                public static string _2284_ = "0";
                public static string _2285_ = "0";
                public static string _2286_ = "0";
                public static string _2287_ = "0";
                public static string _2288_ = "0";
                public static string _2289_ = "0";
                public static string _2290_ = "0";
                public static string _2291_ = "0";
                public static string _2292_ = "0";
                public static string _2293_ = "0";
                public static string _2294_ = "0";
                public static string _2295_ = "0";
                public static string _2296_ = "0";
                public static string _2297_ = "0";
                public static string _2298_ = "0";
                public static string _2299_ = "0";
                public static string _2300_ = "0";
                public static string _2301_ = "0";
                public static string _2302_ = "0";
                public static string _2303_ = "0";
                public static string _2304_ = "0";
                public static string _2305_ = "0";
                public static string _2306_ = "0";
                public static string _2307_ = "0";
                public static string _2308_ = "0";
                public static string _2309_ = "0";
                public static string _2310_ = "0";
                public static string _2311_ = "0";
                public static string _2312_ = "0";
                public static string _2313_ = "0";
                public static string _2314_ = "0";
                public static string _2315_ = "0";
                public static string _2316_ = "0";
                public static string _2317_ = "0";
                public static string _2318_ = "0";
                public static string _2319_ = "0";
                public static string _2320_ = "0";
                public static string _2321_ = "0";
                public static string _2322_ = "0";
                public static string _2323_ = "0";
                public static string _2324_ = "0";
                public static string _2325_ = "0";
                public static string _2326_ = "0";
                public static string _2327_ = "0";
                public static string _2328_ = "0";
                public static string _2329_ = "0";
                public static string _2330_ = "0";
                public static string _2331_ = "0";
                public static string _2332_ = "0";
                public static string _2333_ = "0";
                public static string _2334_ = "0";
                public static string _2335_ = "0";
                public static string _2336_ = "0";
                public static string _2337_ = "0";
                public static string _2338_ = "0";
                public static string _2339_ = "0";
                public static string _2340_ = "0";
                public static string _2341_ = "0";
                public static string _2342_ = "0";
                public static string _2343_ = "0";
                public static string _2344_ = "0";
                public static string _2345_ = "0";
                public static string _2346_ = "0";
                public static string _2347_ = "0";
                public static string _2348_ = "0";
                public static string _2349_ = "0";
                public static string _2350_ = "0";
                public static string _2351_ = "0";
                public static string _2352_ = "0";
                public static string _2353_ = "0";
                public static string _2354_ = "0";
                public static string _2355_ = "0";
                public static string _2356_ = "0";
                public static string _2357_ = "0";
                public static string _2358_ = "0";
                public static string _2359_ = "0";
                public static string _2360_ = "0";
                public static string _2361_ = "0";
                public static string _2362_ = "0";
                public static string _2363_ = "0";
                public static string _2364_ = "0";
                public static string _2365_ = "0";
                public static string _2366_ = "0";
                public static string _2367_ = "0";
                public static string _2368_ = "0";
                public static string _2369_ = "0";
                public static string _2370_ = "0";
                public static string _2371_ = "0";
                public static string _2372_ = "0";
                public static string _2373_ = "0";
                public static string _2374_ = "0";
                public static string _2375_ = "0";
                public static string _2376_ = "0";
                public static string _2377_ = "0";
                public static string _2378_ = "0";
                public static string _2379_ = "0";
                public static string _2380_ = "0";
                public static string _2381_ = "0";
                public static string _2382_ = "0";
                public static string _2383_ = "0";
                public static string _2384_ = "0";
                public static string _2385_ = "0";
                public static string _2386_ = "0";
                public static string _2387_ = "0";
                public static string _2388_ = "0";
                public static string _2389_ = "0";
                public static string _2390_ = "0";
                public static string _2391_ = "0";
                public static string _2392_ = "0";
                public static string _2393_ = "0";
                public static string _2394_ = "0";
                public static string _2395_ = "0";
                public static string _2396_ = "0";
                public static string _2397_ = "0";
                public static string _2398_ = "0";
                public static string _2399_ = "0";
                public static string _2400_ = "0";
                public static string _2401_ = "0";
                public static string _2402_ = "0";
                public static string _2403_ = "0";
                public static string _2404_ = "0";
                public static string _2405_ = "0";
                public static string _2406_ = "0";
                public static string _2407_ = "0";
                public static string _2408_ = "0";
                public static string _2409_ = "0";
                public static string _2410_ = "0";
                public static string _2411_ = "0";
                public static string _2412_ = "0";
                public static string _2413_ = "0";
                public static string _2414_ = "0";
                public static string _2415_ = "0";
                public static string _2416_ = "0";
                public static string _2417_ = "0";
                public static string _2418_ = "0";
                public static string _2419_ = "0";
                public static string _2420_ = "0";
                public static string _2421_ = "0";
                public static string _2422_ = "0";
                public static string _2423_ = "0";
                public static string _2424_ = "0";
                public static string _2425_ = "0";
                public static string _2426_ = "0";
                public static string _2427_ = "0";
                public static string _2428_ = "0";
                public static string _2429_ = "0";
                public static string _2430_ = "0";
                public static string _2431_ = "0";
                public static string _2432_ = "0";
                public static string _2433_ = "0";
                public static string _2434_ = "0";
                public static string _2435_ = "0";
                public static string _2436_ = "0";
                public static string _2437_ = "0";
                public static string _2438_ = "0";
                public static string _2439_ = "0";
                public static string _2440_ = "0";
                public static string _2441_ = "0";
                public static string _2442_ = "0";
                public static string _2443_ = "0";
                public static string _2444_ = "0";
                public static string _2445_ = "0";
                public static string _2446_ = "0";
                public static string _2447_ = "0";
                public static string _2448_ = "0";
                public static string _2449_ = "0";
                public static string _2450_ = "0";
                public static string _2451_ = "0";
                public static string _2452_ = "0";
                public static string _2453_ = "0";
                public static string _2454_ = "0";
                public static string _2455_ = "0";
                public static string _2456_ = "0";
                public static string _2457_ = "0";
                public static string _2458_ = "0";
                public static string _2459_ = "0";
                public static string _2460_ = "0";
                public static string _2461_ = "0";
                public static string _2462_ = "0";
                public static string _2463_ = "0";
                public static string _2464_ = "0";
                public static string _2465_ = "0";
                public static string _2466_ = "0";
                public static string _2467_ = "0";
                public static string _2468_ = "0";
                public static string _2469_ = "0";
                public static string _2470_ = "0";
                public static string _2471_ = "0";
                public static string _2472_ = "0";
                public static string _2473_ = "0";
                public static string _2474_ = "0";
                public static string _2475_ = "0";
                public static string _2476_ = "0";
                public static string _2477_ = "0";
                public static string _2478_ = "0";
                public static string _2479_ = "0";
                public static string _2480_ = "0";
                public static string _2481_ = "0";
                public static string _2482_ = "0";
                public static string _2483_ = "0";
                public static string _2484_ = "0";
                public static string _2485_ = "0";
                public static string _2486_ = "0";
                public static string _2487_ = "0";
                public static string _2488_ = "0";
                public static string _2489_ = "0";
                public static string _2490_ = "0";
                public static string _2491_ = "0";
                public static string _2492_ = "0";
                public static string _2493_ = "0";
                public static string _2494_ = "0";
                public static string _2495_ = "0";
                public static string _2496_ = "0";
                public static string _2497_ = "0";
                public static string _2498_ = "0";
                public static string _2499_ = "0";
                public static string _2500_ = "0";
                public static string _2501_ = "0";
                public static string _2502_ = "0";
                public static string _2503_ = "0";
                public static string _2504_ = "0";
                public static string _2505_ = "0";
                public static string _2506_ = "0";
                public static string _2507_ = "0";
                public static string _2508_ = "0";
                public static string _2509_ = "0";
                public static string _2510_ = "0";
                public static string _2511_ = "0";
                public static string _2512_ = "0";
                public static string _2513_ = "0";
                public static string _2514_ = "0";
                public static string _2515_ = "0";
                public static string _2516_ = "0";
                public static string _2517_ = "0";
                public static string _2518_ = "0";
                public static string _2519_ = "0";
                public static string _2520_ = "0";
                public static string _2521_ = "0";
                public static string _2522_ = "0";
                public static string _2523_ = "0";
                public static string _2524_ = "0";
                public static string _2525_ = "0";
                public static string _2526_ = "0";
                public static string _2527_ = "0";
                public static string _2528_ = "0";
                public static string _2529_ = "0";
                public static string _2530_ = "0";
                public static string _2531_ = "0";
                public static string _2532_ = "0";
                public static string _2533_ = "0";
                public static string _2534_ = "0";
                public static string _2535_ = "0";
                public static string _2536_ = "0";
                public static string _2537_ = "0";
                public static string _2538_ = "0";
                public static string _2539_ = "0";
                public static string _2540_ = "0";
                public static string _2541_ = "0";
                public static string _2542_ = "0";
                public static string _2543_ = "0";
                public static string _2544_ = "0";
                public static string _2545_ = "0";
                public static string _2546_ = "0";
                public static string _2547_ = "0";
                public static string _2548_ = "0";
                public static string _2549_ = "0";
                public static string _2550_ = "0";
                public static string _2551_ = "0";
                public static string _2552_ = "0";
                public static string _2553_ = "0";
                public static string _2554_ = "0";
                public static string _2555_ = "0";
                public static string _2556_ = "0";
                public static string _2557_ = "0";
                public static string _2558_ = "0";
                public static string _2559_ = "0";
                public static string _2560_ = "0";
                public static string _2561_ = "0";
                public static string _2562_ = "0";
                public static string _2563_ = "0";
                public static string _2564_ = "0";
                public static string _2565_ = "0";
                public static string _2566_ = "0";
                public static string _2567_ = "0";
                public static string _2568_ = "0";
                public static string _2569_ = "0";
                public static string _2570_ = "0";
                public static string _2571_ = "0";
                public static string _2572_ = "0";
                public static string _2573_ = "0";
                public static string _2574_ = "0";
                public static string _2575_ = "0";
                public static string _2576_ = "0";
                public static string _2577_ = "0";
                public static string _2578_ = "0";
                public static string _2579_ = "0";
                public static string _2580_ = "0";
                public static string _2581_ = "0";
                public static string _2582_ = "0";
                public static string _2583_ = "0";
                public static string _2584_ = "0";
                public static string _2585_ = "0";
                public static string _2586_ = "0";
                public static string _2587_ = "0";
                public static string _2588_ = "0";
                public static string _2589_ = "0";
                public static string _2590_ = "0";
                public static string _2591_ = "0";
                public static string _2592_ = "0";
                public static string _2593_ = "0";
                public static string _2594_ = "0";
                public static string _2595_ = "0";
                public static string _2596_ = "0";
                public static string _2597_ = "0";
                public static string _2598_ = "0";
                public static string _2599_ = "0";
                public static string _2600_ = "0";
                public static string _2601_ = "0";
                public static string _2602_ = "0";
                public static string _2603_ = "0";
                public static string _2604_ = "0";
                public static string _2605_ = "0";
                public static string _2606_ = "0";
                public static string _2607_ = "0";
                public static string _2608_ = "0";
                public static string _2609_ = "0";
                public static string _2610_ = "0";
                public static string _2611_ = "0";
                public static string _2612_ = "0";
                public static string _2613_ = "0";
                public static string _2614_ = "0";
                public static string _2615_ = "0";
                public static string _2616_ = "0";
                public static string _2617_ = "0";
                public static string _2618_ = "0";
                public static string _2619_ = "0";
                public static string _2620_ = "0";
                public static string _2621_ = "0";
                public static string _2622_ = "0";
                public static string _2623_ = "0";
                public static string _2624_ = "0";
                public static string _2625_ = "0";
                public static string _2626_ = "0";
                public static string _2627_ = "0";
                public static string _2628_ = "0";
                public static string _2629_ = "0";
                public static string _2630_ = "0";
                public static string _2631_ = "0";
                public static string _2632_ = "0";
                public static string _2633_ = "0";
                public static string _2634_ = "0";
                public static string _2635_ = "0";
                public static string _2636_ = "0";
                public static string _2637_ = "0";
                public static string _2638_ = "0";
                public static string _2639_ = "0";
                public static string _2640_ = "0";
                public static string _2641_ = "0";
                public static string _2642_ = "0";
                public static string _2643_ = "0";
                public static string _2644_ = "0";
                public static string _2645_ = "0";
                public static string _2646_ = "0";
                public static string _2647_ = "0";
                public static string _2648_ = "0";
                public static string _2649_ = "0";
                public static string _2650_ = "0";
                public static string _2651_ = "0";
                public static string _2652_ = "0";
                public static string _2653_ = "0";
                public static string _2654_ = "0";
                public static string _2655_ = "0";
                public static string _2656_ = "0";
                public static string _2657_ = "0";
                public static string _2658_ = "0";
                public static string _2659_ = "0";
                public static string _2660_ = "0";
                public static string _2661_ = "0";
                public static string _2662_ = "0";
                public static string _2663_ = "0";
                public static string _2664_ = "0";
                public static string _2665_ = "0";
                public static string _2666_ = "0";
                public static string _2667_ = "0";
                public static string _2668_ = "0";
                public static string _2669_ = "0";
                public static string _2670_ = "0";
                public static string _2671_ = "0";
                public static string _2672_ = "0";
                public static string _2673_ = "0";
                public static string _2674_ = "0";
                public static string _2675_ = "0";
                public static string _2676_ = "0";
                public static string _2677_ = "0";
                public static string _2678_ = "0";
                public static string _2679_ = "0";
                public static string _2680_ = "0";
                public static string _2681_ = "0";
                public static string _2682_ = "0";
                public static string _2683_ = "0";
                public static string _2684_ = "0";
                public static string _2685_ = "0";
                public static string _2686_ = "0";
                public static string _2687_ = "0";
                public static string _2688_ = "0";
                public static string _2689_ = "0";
                public static string _2690_ = "0";
                public static string _2691_ = "0";
                public static string _2692_ = "0";
                public static string _2693_ = "0";
                public static string _2694_ = "0";
                public static string _2695_ = "0";
                public static string _2696_ = "0";
                public static string _2697_ = "0";
                public static string _2698_ = "0";
                public static string _2699_ = "0";
                public static string _2700_ = "0";
                public static string _2701_ = "0";
                public static string _2702_ = "0";
                public static string _2703_ = "0";
                public static string _2704_ = "0";
                public static string _2705_ = "0";
                public static string _2706_ = "0";
                public static string _2707_ = "0";
                public static string _2708_ = "0";
                public static string _2709_ = "0";
                public static string _2710_ = "0";
                public static string _2711_ = "0";
                public static string _2712_ = "0";
                public static string _2713_ = "0";
                public static string _2714_ = "0";
                public static string _2715_ = "0";
                public static string _2716_ = "0";
                public static string _2717_ = "0";
                public static string _2718_ = "0";
                public static string _2719_ = "0";
                public static string _2720_ = "0";
                public static string _2721_ = "0";
                public static string _2722_ = "0";
                public static string _2723_ = "0";
                public static string _2724_ = "0";
                public static string _2725_ = "0";
                public static string _2726_ = "0";
                public static string _2727_ = "0";
                public static string _2728_ = "0";
                public static string _2729_ = "0";
                public static string _2730_ = "0";
                public static string _2731_ = "0";
                public static string _2732_ = "0";
                public static string _2733_ = "0";
                public static string _2734_ = "0";
                public static string _2735_ = "0";
                public static string _2736_ = "0";
                public static string _2737_ = "0";
                public static string _2738_ = "0";
                public static string _2739_ = "0";
                public static string _2740_ = "0";
                public static string _2741_ = "0";
                public static string _2742_ = "0";
                public static string _2743_ = "0";
                public static string _2744_ = "0";
                public static string _2745_ = "0";
                public static string _2746_ = "0";
                public static string _2747_ = "0";
                public static string _2748_ = "0";
                public static string _2749_ = "0";
                public static string _2750_ = "0";
                public static string _2751_ = "0";
                public static string _2752_ = "0";
                public static string _2753_ = "0";
                public static string _2754_ = "0";
                public static string _2755_ = "0";
                public static string _2756_ = "0";
                public static string _2757_ = "0";
                public static string _2758_ = "0";
                public static string _2759_ = "0";
                public static string _2760_ = "0";
                public static string _2761_ = "0";
                public static string _2762_ = "0";
                public static string _2763_ = "0";
                public static string _2764_ = "0";
                public static string _2765_ = "0";
                public static string _2766_ = "0";
                public static string _2767_ = "0";
                public static string _2768_ = "0";
                public static string _2769_ = "0";
                public static string _2770_ = "0";
                public static string _2771_ = "0";
                public static string _2772_ = "0";
                public static string _2773_ = "0";
                public static string _2774_ = "0";
                public static string _2775_ = "0";
                public static string _2776_ = "0";
                public static string _2777_ = "0";
                public static string _2778_ = "0";
                public static string _2779_ = "0";
                public static string _2780_ = "0";
                public static string _2781_ = "0";
                public static string _2782_ = "0";
                public static string _2783_ = "0";
                public static string _2784_ = "0";
                public static string _2785_ = "0";
                public static string _2786_ = "0";
                public static string _2787_ = "0";
                public static string _2788_ = "0";
                public static string _2789_ = "0";
                public static string _2790_ = "0";
                public static string _2791_ = "0";
                public static string _2792_ = "0";
                public static string _2793_ = "0";
                public static string _2794_ = "0";
                public static string _2795_ = "0";
                public static string _2796_ = "0";
                public static string _2797_ = "0";
                public static string _2798_ = "0";
                public static string _2799_ = "0";
                public static string _2800_ = "0";
                public static string _2801_ = "0";
                public static string _2802_ = "0";
                public static string _2803_ = "0";
                public static string _2804_ = "0";
                public static string _2805_ = "0";
                public static string _2806_ = "0";
                public static string _2807_ = "0";
                public static string _2808_ = "0";
                public static string _2809_ = "0";
                public static string _2810_ = "0";
                public static string _2811_ = "0";
                public static string _2812_ = "0";
                public static string _2813_ = "0";
                public static string _2814_ = "0";
                public static string _2815_ = "0";
                public static string _2816_ = "0";
                public static string _2817_ = "0";
                public static string _2818_ = "0";
                public static string _2819_ = "0";
                public static string _2820_ = "0";
                public static string _2821_ = "0";
                public static string _2822_ = "0";
                public static string _2823_ = "0";
                public static string _2824_ = "0";
                public static string _2825_ = "0";
                public static string _2826_ = "0";
                public static string _2827_ = "0";
                public static string _2828_ = "0";
                public static string _2829_ = "0";
                public static string _2830_ = "0";
                public static string _2831_ = "0";
                public static string _2832_ = "0";
                public static string _2833_ = "0";
                public static string _2834_ = "0";
                public static string _2835_ = "0";
                public static string _2836_ = "0";
                public static string _2837_ = "0";
                public static string _2838_ = "0";
                public static string _2839_ = "0";
                public static string _2840_ = "0";
                public static string _2841_ = "0";
                public static string _2842_ = "0";
                public static string _2843_ = "0";
                public static string _2844_ = "0";
                public static string _2845_ = "0";
                public static string _2846_ = "0";
                public static string _2847_ = "0";
                public static string _2848_ = "0";
                public static string _2849_ = "0";
                public static string _2850_ = "0";
                public static string _2851_ = "0";
                public static string _2852_ = "0";
                public static string _2853_ = "0";
                public static string _2854_ = "0";
                public static string _2855_ = "0";
                public static string _2856_ = "0";
                public static string _2857_ = "0";
                public static string _2858_ = "0";
                public static string _2859_ = "0";
                public static string _2860_ = "0";
                public static string _2861_ = "0";
                public static string _2862_ = "0";
                public static string _2863_ = "0";
                public static string _2864_ = "0";
                public static string _2865_ = "0";
                public static string _2866_ = "0";
                public static string _2867_ = "0";
                public static string _2868_ = "0";
                public static string _2869_ = "0";
                public static string _2870_ = "0";
                public static string _2871_ = "0";
                public static string _2872_ = "0";
                public static string _2873_ = "0";
                public static string _2874_ = "0";
                public static string _2875_ = "0";
                public static string _2876_ = "0";
                public static string _2877_ = "0";
                public static string _2878_ = "0";
                public static string _2879_ = "0";
                public static string _2880_ = "0";
                public static string _2881_ = "0";
                public static string _2882_ = "0";
                public static string _2883_ = "0";
                public static string _2884_ = "0";
                public static string _2885_ = "0";
                public static string _2886_ = "0";
                public static string _2887_ = "0";
                public static string _2888_ = "0";
                public static string _2889_ = "0";
                public static string _2890_ = "0";
                public static string _2891_ = "0";
                public static string _2892_ = "0";
                public static string _2893_ = "0";
                public static string _2894_ = "0";
                public static string _2895_ = "0";
                public static string _2896_ = "0";
                public static string _2897_ = "0";
                public static string _2898_ = "0";
                public static string _2899_ = "0";
                public static string _2900_ = "0";
                public static string _2901_ = "0";
                public static string _2902_ = "0";
                public static string _2903_ = "0";
                public static string _2904_ = "0";
                public static string _2905_ = "0";
                public static string _2906_ = "0";
                public static string _2907_ = "0";
                public static string _2908_ = "0";
                public static string _2909_ = "0";
                public static string _2910_ = "0";
                public static string _2911_ = "0";
                public static string _2912_ = "0";
                public static string _2913_ = "0";
                public static string _2914_ = "0";
                public static string _2915_ = "0";
                public static string _2916_ = "0";
                public static string _2917_ = "0";
                public static string _2918_ = "0";
                public static string _2919_ = "0";
                public static string _2920_ = "0";
                public static string _2921_ = "0";
                public static string _2922_ = "0";
                public static string _2923_ = "0";
                public static string _2924_ = "0";
                public static string _2925_ = "0";
                public static string _2926_ = "0";
                public static string _2927_ = "0";
                public static string _2928_ = "0";
                public static string _2929_ = "0";
                public static string _2930_ = "0";
                public static string _2931_ = "0";
                public static string _2932_ = "0";
                public static string _2933_ = "0";
                public static string _2934_ = "0";
                public static string _2935_ = "0";
                public static string _2936_ = "0";
                public static string _2937_ = "0";
                public static string _2938_ = "0";
                public static string _2939_ = "0";
                public static string _2940_ = "0";
                public static string _2941_ = "0";
                public static string _2942_ = "0";
                public static string _2943_ = "0";
                public static string _2944_ = "0";
                public static string _2945_ = "0";
                public static string _2946_ = "0";
                public static string _2947_ = "0";
                public static string _2948_ = "0";
                public static string _2949_ = "0";
                public static string _2950_ = "0";
                public static string _2951_ = "0";
                public static string _2952_ = "0";
                public static string _2953_ = "0";
                public static string _2954_ = "0";
                public static string _2955_ = "0";
                public static string _2956_ = "0";
                public static string _2957_ = "0";
                public static string _2958_ = "0";
                public static string _2959_ = "0";
                public static string _2960_ = "0";
                public static string _2961_ = "0";
                public static string _2962_ = "0";
                public static string _2963_ = "0";
                public static string _2964_ = "0";
                public static string _2965_ = "0";
                public static string _2966_ = "0";
                public static string _2967_ = "0";
                public static string _2968_ = "0";
                public static string _2969_ = "0";
                public static string _2970_ = "0";
                public static string _2971_ = "0";
                public static string _2972_ = "0";
                public static string _2973_ = "0";
                public static string _2974_ = "0";
                public static string _2975_ = "0";
                public static string _2976_ = "0";
                public static string _2977_ = "0";
                public static string _2978_ = "0";
                public static string _2979_ = "0";
                public static string _2980_ = "0";
                public static string _2981_ = "0";
                public static string _2982_ = "0";
                public static string _2983_ = "0";
                public static string _2984_ = "0";
                public static string _2985_ = "0";
                public static string _2986_ = "0";
                public static string _2987_ = "0";
                public static string _2988_ = "0";
                public static string _2989_ = "0";
                public static string _2990_ = "0";
                public static string _2991_ = "0";
                public static string _2992_ = "0";
                public static string _2993_ = "0";
                public static string _2994_ = "0";
                public static string _2995_ = "0";
                public static string _2996_ = "0";
                public static string _2997_ = "0";
                public static string _2998_ = "0";
                public static string _2999_ = "0";
                public static string _3000_ = "0";
            }
        }





    }
}

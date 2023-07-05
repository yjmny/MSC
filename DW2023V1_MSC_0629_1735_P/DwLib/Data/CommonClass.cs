//#define MACRO_MODE_ON
#undef MACRO_MODE_ON

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwLib.Data.Generic
{
    public class CommonClass
    {
        
        public static readonly int ms_programId = 1;/// 1: 측정프로그램
        public static readonly int an_programId = 2;/// 2: 분석프로그램
        public static readonly string program_title = "DWSMARTICT MSC V1.23.0401";//최초 개발


        /// <summary>
        /// 개발자모드 활성화 (활성화:true, 비활성 : false)
        /// </summary>
        public static bool isDeveloperMode = false;// true;

        /// <summary>
        /// 장치 연결 및 운영(false), 시뮬레이션 데모(true)
        /// </summary>
        public static bool isDemoOn = true;

        /// <summary>
        /// 장치 연결 체크 기능 활성 여부(활성 :true, 비활성:false)
        /// 메인 윈도우 버튼과 연동함
        /// 비활성일때, 메인윈도우 버튼 막기 안함
        /// </summary>
        public static bool IsDeviceCheckOn = true;// false;

        public static bool isExportPdfClosed = true;

        /// <summary>
        /// 1: 24채널 라인차트, 
        /// 2: 12채널 라인차트, 
        /// 3: 의뢰자선택 항목 라인차트,
        /// 4: 의뢰자 선택항목 컬럼차트
        /// </summary>
        public static int chartOption = 1;//4;  


        #region //디바이스 체커 프로그램 정보
        public static string dbip;
        public static string dbport;
        #endregion //디바이스 체커 프로그램 정보


#if MACRO_MODE_ON
        /// <summary>
        /// Macro Option - On
        /// </summary>
        public static bool isMacroOn = true;
        public static bool isMacroStop=false;
        public static bool isMacroNextRun = true;
#else 
        /// <summary>
        /// Macro Option - Off
        /// </summary>
        public static bool isMacroOn = false;
        public static bool isMacroStop = false;
        public static bool isMacroNextRun = false;
#endif


        /// <summary>
        /// 표준시편 기능 활성 여부(활성 :true, 비활성:false)
        /// </summary>
        public static bool IsStdSampleMethodOn = false;

        //device 연결체크
        public static bool IsHmiCtrlConn10 { get; set; }//삼원테크 TEMI2500
        public static bool IsDBCtrlConn10 { get; set; }//MySql 8.0
        public static bool IsRecoCtrlConn10 { get; set; }//삼원테크 SDR100E
        public static bool IsEscaleCtrlConn10 { get; set; }//카스스케일 저울 CUW420HX
        public static bool IsPlcCtrlConn10 { get; set; }//Ls산전 PLC


 

    }
}

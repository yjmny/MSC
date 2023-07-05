using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DWLib.Data.Generic
{
    public class Measure
    {
        #region //측정 프로그램 정보
        public static string mbno;
        public static string mbid;
        public static string mbpwd;
        public static string loginTime;
        public static string loginok;
        public static bool loginSuccess;
        public static bool isExit = true;
        public static bool program_exit = false;
        public static bool program_run;

        /// <summary>
        /// Recipe mtime에 연동
        /// 단위(sec)
        /// </summary>
        public static int iAcqCountMax = 3600;
        public static int iAcqUpdateStep = 2;//1;//10;10 unit(sec)
        /// <summary>
        /// 챔버 측정 데이터 DB에 업데이트
        /// </summary>
        public static bool isChamberDBUpdate = true;

        /// <summary>
        /// Add-In 장치, 소프트웨어를 프로그램에서 사용할지 여부 
        /// 사용: true , 미사용 : false
        /// </summary>
        public static bool IsPlcUse = true;
        public static bool IsHmiUse = false;//true;
        public static bool IsRecUse = false;
        public static bool IsDbUse = true;
        public static bool IsEscaleUse = false;
        /// <summary>
        /// 측정 시작하면 1, 측정중지면 0
        /// </summary>
        public static int IsMesureOn10;

        /// <summary>
        /// 챔버 가동 시작하면 1, 가동중지면 0
        /// </summary>
        public static int IsChamberRunOn10;

        public static string PlcMultiple(string value, double digit = 1)
        {
            string strRtn;
            Double.TryParse(value, out double dValue);
            if (dValue == 0) { }
            else
            {
                dValue *= digit;

                if (dValue > Int32.MaxValue)
                {
                    dValue = Int32.MaxValue;
                }
                else if (dValue < Int32.MinValue)
                {
                    dValue = Int32.MinValue;
                }
            }

            strRtn = dValue.ToString();
            return strRtn;
        }


        public static string PlcDivide(string value, double digit = 1)
        {
            string strRtn;
            Double.TryParse(value, out double dValue);
            if (dValue == 0) { }
            else
            {
                dValue /= digit;
                if (dValue > Int32.MaxValue)
                {
                    dValue = Int32.MaxValue;
                }
                else if (dValue < Int32.MinValue)
                {
                    dValue = Int32.MinValue;
                }
            }

            strRtn = dValue.ToString();
            return strRtn;
        }
        public static byte MeasureEndStdType = 0x02;

        #endregion//측정 프로그램 정보
    }
}

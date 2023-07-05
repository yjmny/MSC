using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KS
{
    /// <summary>
    /// 텍스타일의 투습도 시험방법
    /// KSK0594:2021
    /// 산업표준심의회
    /// 2021년7월1일 개정
    /// </summary>
    public static class KSK0594_2021
    {
        /// <summary>
        ///  투습도 =  g/(m^2 *h)
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <param name="circleArea1"></param>
        /// <returns></returns>
        private static int P(double a1, double a2, double circleArea1)
        {
            int iRtnVal = 0;

            double g_h = gPerh(a1, a2);//1h 경과 후 시험체의 질량 변황 (g/h)
            double S = CircleArea(circleArea1);//투습면적

            double P = g_h / S; //투습도( g/(m^2 *h)
            Console.WriteLine("double P = " + P);
            iRtnVal = (int)P;
            return iRtnVal;
        }

        private static double gPerh(double a1, double a2)//1h 경과 후 시험체의 질량 변황 (g/h)
        {
            return a2 - a1;
        }
        private static double CircleArea(double diameter_mm)//투습면적
        {
            //CircleArea
            double rtnValue = 0;

            //=(3.141592*70mm^2/4)*10^-6
            //0.0038484502
            double dVal = (3.141592 * Math.Pow(diameter_mm, 2) / 4) * Math.Pow(10, -6);
            rtnValue = Math.Round(dVal, 5);//소수점 5자리
            Console.WriteLine("Circle Area = " + rtnValue);
            return rtnValue;
        }

        public static int CalcTest(double v1, double v2, double v3)
        {
            return P(v1, v2, v3);
        }

        /// <summary>
        /// 투습도 계산식
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <param name="v3"></param>
        /// <returns></returns>
        public static int CalcWvp(double a1, double a2, double circleArea1)
        {
            return P(a1, a2, circleArea1);
        }
    }
}

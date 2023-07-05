using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace DwLib.Data
{
    public static class Util
    {
        public static string InputdataCheckHanEngNum(string programName, string value)
        {
            //탐색기 제한문자
            bool isRtn = Regex.IsMatch(value, @"[a-zA-Z0-9ㄱ-ㅎ가-힣]+$");
            string strRtn = value;
            if (isRtn == false)
            {
                strRtn = "";
                if (MessageBox.Show("한글,영문과 숫자만 가능합니다.", programName, MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                {

                }
            }
            else
            {
                isRtn = true;
            }

            return strRtn;
        }

        public static string InputdataCheck(string programName, string value)
        {
            // \ / : * ? " < > | 허용안함
            char[] invalidChar = Path.GetInvalidFileNameChars();//41

            string strRtn = value;
            bool isSame = false;
            foreach (char c1 in value)
            {
                for (int i = 0; i < invalidChar.Length; i++)
                {
                    if (c1 == invalidChar[i])
                    {
                        isSame = true;
                        break;
                    }
                }
            }

            if (isSame)
            {
                strRtn = "";
                if (MessageBox.Show("다음문자를 사용할 수 없습니다.\r\n\t\\ / : * ? \" < > |", programName, MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                {

                }
            }

            return strRtn;
        }

        public static string InputdataCheckEngNum(string programName, string value)
        {
            //bool isRtn = true;
            //Regex regex = new Regex(@"[a-zA-Z0-9]+$"); //정규식 지정
            //string strRtn = value;
            //if (!(regex.IsMatch(value)))
            //{
            //    strRtn = "";
            //    if (MessageBox.Show("영문과 숫자만 가능합니다.", programName, MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
            //    {

            //    }
            //}
            string idChecker = Regex.Replace(value, @"[^a-zA-Z0-9_]", "", RegexOptions.Singleline);


            string strRtn = value;
            if (value.Equals(idChecker) == false)

            {
                strRtn = "";
               // value.Remove(0, value.Length);
                //value.Text = "";

                if (MessageBox.Show("영문과 숫자만 가능합니다.", programName, MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                {

                }


            }


            //bool isRtn = true;
            //for (int i = 0; i < value.Length; i++)
            //{
            //    char c1 = value[i];
            //    string a = char.GetUnicodeCategory(c1).ToString();
            //    if (a.Equals("OtherLetter"))
            //    {
            //        isRtn = false;
            //        break;
            //    }

            //}
            //if (isRtn)
            //{
            //    isRtn = Regex.IsMatch(value, @"[a-zA-Z0-9]+$");

            //}
            //string strRtn = value;
            //if (isRtn == false)
            //{
            //    strRtn = "";
            //    if (MessageBox.Show("영문과 숫자만 가능합니다.", programName, MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
            //    {

            //    }
            //}
            //else
            //{
            //    isRtn = true;
            //}

            return strRtn;
        }
        public static string InputdataCheckEngNumSpectial(string programName, string value)
        {
            bool isRtn = Regex.IsMatch(value, @"[ a-zA-Z0-9_!@#$-]+$");
            string strRtn = value;
            if (isRtn == false)
            {
                strRtn = "";
                if (MessageBox.Show("영문과 숫자, 하이픈(-),언더바(_)만 가능합니다.", programName, MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                {

                }
            }
            else
            {
                isRtn = true;
            }

            return strRtn;
        }
        public static string InputdataCheckEngNumHipeun(string programName, string value)
        {
            bool isRtn = Regex.IsMatch(value, @"[ a-zA-Z0-9-]+$");
            string strRtn = value;
            if (isRtn == false)
            {
                strRtn = "";
                if (MessageBox.Show("영문과 숫자, 하이픈(-), 가능합니다.", programName, MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                {

                }
            }
            else
            {
                isRtn = true;
            }

            return strRtn;
        }

        public static string InputdataCheckNumHipeun(string programName, string value)
        {
            bool isRtn = Regex.IsMatch(value, @"[ 0-9]+$");
            string[] strSplit = value.Split('_');

            string strRtn = value;
            if (isRtn == false || strSplit.Length > 1)
            {
                strRtn = "";
                if (MessageBox.Show("숫자, 하이픈(-), 가능합니다.", programName, MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                {

                }
            }
            else
            {
                isRtn = true;
            }

            return strRtn;
        }

        public static string InputdataCheckOnlyNum(string programName, string value)
        {
            bool isRtn = Regex.IsMatch(value, @"[ 0-9]+$");
            string strRtn = value;
            if (isRtn == false)
            {
                strRtn = "";
                if (MessageBox.Show("숫자만 가능합니다.", programName, MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                {

                }
            }
            else
            {
                isRtn = true;
            }

            return strRtn;
        }
        public static string InputdataCheckNum(string programName, string value)
        {
            bool isRtn = Regex.IsMatch(value, @"[ 0-9_.]+$");
            string strRtn = value;
            if (isRtn == false)
            {
                strRtn = "";
                if (MessageBox.Show("숫자, 포인트(.)만 가능합니다.", programName, MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                {

                }
            }
            else
            {
                isRtn = true;
            }

            return strRtn;
        }
    }
}

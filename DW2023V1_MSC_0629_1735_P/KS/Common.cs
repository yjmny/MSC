using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KS
{
    internal class Common
    {
        //private string fileName = @"\Flash Disk\Documents and Settings\config.txt"; //@"\Program Files\config.txt";
        private string fileName = Application.StartupPath + @"\config.txt"; //@"\Program Files\config.txt";
        static public byte RS485_Addr = 1;
        static public int RS485_BaudRate = 115200;
        static public string LoRa_SvrAddr = "NODATA";
        static public string LoRa_MyAddr = "NODATA";
        static public string Password = "1234"; //"dwsensor!@#$";
        static public string[] RegName1 = new string[] { "기관코드", "회사코드", "제품타입", "제품코드", "프로토콜버전", "채널수", "노드시리얼번호H", "노드시리얼번호L" };
        static public string[] RegData1 = new string[] { "-", "두원글로벌", "센서노드", "제품코드", "-", "-", "-", "-" };
        //static public string[] RegName2 = new string[] { "온도1", "습도1", "CO2 센서" };
        static public string[] RegName2 = new string[] { "온도1", "온도2", "온도3", "습도1", "이슬점 센서", "감우 센서", "유량 센서", "강우 센서", "일사 센서", "풍속 센서", "풍향 센서", "전압 센서", "CO2 센서", "EC 센서", "광양자 센서", "토양함수율 센서", "토양수분장력 센서", "pH", "지온", "온도4", "온도5", "온도6", "온도7", "온도8", "온도9", "온도10", "습도2", "습도3", "무게1", "무게2" };
        //static public string[] RegData2 = new string[] { "사용", "사용", "사용" };
        static public string[] RegData2 = new string[] { "사용", "", "", "사용", "", "", "", "", "", "", "", "", "사용", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
        static public string[] RegName3 = new string[] { "노드 상태",
            "온도 센서(#1) 값H", "온도 센서(#1) 값L", "온도 센서(#1) 상태",
            "온도 센서(#2) 값H", "온도 센서(#2) 값L", "온도 센서(#2) 상태",
            "온도 센서(#3) 값H", "온도 센서(#3) 값L", "온도 센서(#3) 상태",
            "습도 센서(#1) 값H", "습도 센서(#1) 값L", "습도 센서(#1) 상태",
            "이슬점 센서 값H", "이슬점 센서 값L", "이슬점 센서 상태",
            "감우 센서 값H", "감우 센서 값L", "감우 센서 상태",
            "유량 센서 값H", "유량 센서 값L", "유량 센서 상태",
            "강우 센서 값H", "강우 센서 값L", "강우 센서 상태",
            "일사 센서 값H", "일사 센서 값L", "일사 센서 상태",
            "풍속 센서 값H", "풍속 센서 값L", "풍속 센서 상태",
            "풍향 센서 값H", "풍향 센서 값L", "풍향 센서 상태",
            "전압 센서 값H", "전압 센서 값L", "전압 센서 상태",
            "CO2 센서 값H", "CO2 센서 값L", "CO2 센서 상태",
            "EC 센서 값H", "EC 센서 값L", "EC 센서 상태",
            "광양자 센서 값H", "광양자 센서 값L", "광양자 센서 상태",
            "토양함수율 센서 값H", "토양함수율 센서 값L", "토양함수율 센서 상태",
            "토양수분장력 센서 값H", "토양수분장력 센서 값L", "토양수분장력 센서 상태",
            "pH 센서 값H", "pH 센서 값L", "pH 센서 상태",
            "지온 센서 값H", "지온 센서 값L", "지온 센서 상태",
            "온도 센서(#4) 값H", "온도 센서(#4) 값L", "온도 센서(#4) 상태",
            "온도 센서(#5) 값H", "온도 센서(#5) 값L", "온도 센서(#5) 상태",
            "온도 센서(#6) 값H", "온도 센서(#6) 값L", "온도 센서(#6) 상태",
            "온도 센서(#7) 값H", "온도 센서(#7) 값L", "온도 센서(#7) 상태",
            "온도 센서(#8) 값H", "온도 센서(#8) 값L", "온도 센서(#8) 상태",
            "온도 센서(#9) 값H", "온도 센서(#9) 값L", "온도 센서(#9) 상태",
            "온도 센서(#10) 값H", "온도 센서(#10) 값L", "온도 센서(#10) 상태",
            "습도 센서(#2) 값H", "습도 센서(#2) 값L", "습도 센서(#2) 상태",
            "습도 센서(#3) 값H", "습도 센서(#3) 값L", "습도 센서(#3) 상태",
            "무게 센서(#1) 값H", "무게 센서(#1) 값L", "무게 센서(#1) 상태",
            "무게 센서(#2) 값H", "무게 센서(#2) 값L", "무게 센서(#2) 상태" };
        static public string[] RegData3 = new string[] { "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상" };

        //static public string[] RegName3 = new string[] { "노드 상태", "온도 센서(#1) 값H", "온도 센서(#1) 값L", "온도 센서(#1) 상태", "습도 센서(#1) 값H", "습도 센서(#1) 값L", "습도 센서(#1) 상태", "CO2 센서(#1) 값H", "CO2 센서(#1) 값L", "CO2 센서(#1) 상태" };
        //static public string[] RegData3 = new string[] { "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상", "-", "-", "0:정상, 1:이상" };        

        public bool ReadSettings()
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    return false;
                }
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string text = "";
                    while ((text = sr.ReadLine()) != null)
                    {
                        string[] data = text.Split(',');
                        switch (data[0])
                        {
                            case "modbus":
                                RS485_Addr = byte.Parse(data[1]);
                                RS485_BaudRate = int.Parse(data[2]);
                                break;
                            case "lora":
                                LoRa_SvrAddr = data[1];
                                LoRa_MyAddr = data[2];
                                break;
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool WriteSetting()
        {
            try
            {
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.WriteLine(string.Format("{0},{1},{2}", "modbus", RS485_Addr, RS485_BaudRate));
                    sw.WriteLine(string.Format("{0},{1},{2}", "lora", LoRa_SvrAddr, LoRa_MyAddr));
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

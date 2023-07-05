using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMS_V1;

namespace Alarm_V1
{
    public class Alarm
    {
        MySqlDTO msdto = new MySqlDTO();

        public string aldivError = "ERROR";
        public string aldivWARNING = "WARNING";

        public string altitleMeasureDash = "측정프로그램-대시보드";
        public string altitleMeasureRcpManage = "측정프로그램-레시피 관리";
        public string altitleMeasureRcpRegister = "측정프로그램-레시피 등록";
        public string altitleMeasureMeasure = "측정프로그램-측정관리";
        public string alcontentPLCFlagError = "PLC 플래그 에러";
        public string alcontentMeasureStopWarning = "측정 중지 경고";

        public void insertAlarm(int mbno, string aldiv, string altitle, string alcontent)
        {
            try
            {
                msdto.OpenKeepUp();
                string alarmSql = $@"insert into tbl_alarmvo (mbno, alstartdate, aldiv, altitle, alcontent, mbid) values ({mbno}, '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', '{aldiv}',
                                        '{altitle}', 'alcontent', (select mbid from tbl_member where mbno = {mbno}))";
                msdto.RunSql("INSERT", alarmSql);
            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                msdto.Close();

            }
        }
    }
}

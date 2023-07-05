using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.WVP
{
    internal class tbl_alarm
    {
        public tbl_alarm()
        {

        }

        public int alno=0; // '알람이력 기본키',
        public int mbno =0; // '멤버순번',
        public int nwno = 0; // '네트워크순번',
        public int dbno = 0; // 'DB순번',
        public int comno = 0; // '시리얼통신순번',
        public int webno = 0; // '웹서버순번',
        //public DateTime starttime;// '알람발생 시작시간',
        //public DateTime endtime;// '알람처리완료시간',
        public string div =null;// '알람구분(경고(W),오류(E))',
        public string title = null;// '알람제목',
        public string content = null;// '알람내용',
        public string memo = null;// '알람장애 처리사항',
        public string mbid = null;// '장애처리 확인자 맴버',
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.MSC
{
    public class Tbl_loginout
    {
        public Tbl_loginout() { }

        public int loginno; // '로그인아웃 순번(PK)',
        public string mbid; // '멤버 ID',
        public string logintime; // '로그인 시간',
        public string logouttime; // '로그아웃시간',
        public string exeloc; // '실행위치',
        public int mbno; // '멤버순번(FK)',

    }
}

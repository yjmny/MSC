using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.MSC
{
    public class Tbl_member
    {
        public Tbl_member()
        {

        }

        public int mbno; // '멤버순번 기본키',
        public string id;// '맴버 ID',
        public string name;// '사용자명',
        public string pwd;// '멤버 비밀번호',
        public string regdate;// '등록일자',
        public string outdate;// '탈퇴일자',
        public string out10;// '탈퇴여부(사용1,미사용0)',
        public string divlevel;// '멤버 등급 구분',
        public string comname;// '멤버소속 기관명',
        public string teamname;// '부서구분',
        public string use10;// '사용여부(사용1,미사용0)',
        public string contact;// '연락처',
        public string updatedate;// '변경일자',
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
//using static log4net.Appender.RollingFileAppender;

namespace DBMS_V1.Data.MSC
{
    /// <summary>
    /// 표준시편 테이블
    /// </summary>
    public class Tbl_standardspec
    {

        public Tbl_standardspec()
        {
            //guid = Guid.NewGuid();
        }

        public int stdno; // '표준시편 순번 기본키',
        public string divno;// '표준시편 구분번호(PH,EC,...)',
        public string id;// '표준시편 ID',
        public string name;// '표준시편명',
        public string value;// '표준시편값',
        public string intensity;// '표준시편 인텐시티',
        public string max;// '표준시편 최대값',
        public string min;// '표준시편 최소값',
        public string marginoferror;// '표준시편 허용오차',
        public string unit;// '표준시편 표시 단위',
        public string regdate;// '표준시편 정보등록일자',
        public string updatedate;// '표준시편 정보변경일자',
        public string notusedate;// '표준시편 사용안함등록일자(미삭제)',
        public int use10;// '표준시편 사용여부(사용1,미사용0)',
        public string mcname;// '표준시편 제조업체명(Manufacturer)',
        public string method;//'시험방법',





    }
}

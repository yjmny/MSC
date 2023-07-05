using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
//using static log4net.Appender.RollingFileAppender;

namespace DBMS_V1.Data.WVP
{
    /// <summary>
    /// 표준시편 테이블
    /// </summary>
    public class tbl_standardspec
    {

//        CREATE TABLE `tbl_standardspec` (
//  `stdno` int NOT NULL AUTO_INCREMENT COMMENT '표준시편 순번 기본키',
//  `divno` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준시편 구분번호(PH,EC,...)',
//  `id` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '표준시편 ID',
//  `name` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준시편명',
//  `value` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준시편값',
//  `intensity` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준시편 인텐시티',
//  `max` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준시편 최대값',
//  `min` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준시편 최소값',
//  `marginoferror` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준시편 허용오차',
//  `unit` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준시편 표시 단위',
//  `regdate` datetime DEFAULT CURRENT_TIMESTAMP COMMENT '표준시편 정보등록일자',
//  `updatedate` datetime DEFAULT NULL COMMENT '표준시편 정보변경일자',
//  `notusedate` datetime DEFAULT NULL COMMENT '표준시편 사용안함등록일자(미삭제)',
//  `use10` int DEFAULT '1' COMMENT '표준시편 사용여부(사용1,미사용0)',
//  `mcname` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT 'not set' COMMENT '표준시편 제조업체명(Manufacturer)',
//  `method` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '시험방법',
//  PRIMARY KEY(`stdno`)
//) ENGINE=InnoDB AUTO_INCREMENT = 8 DEFAULT CHARSET = utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT = 'SAMPLE 정보테이블';

        public tbl_standardspec()
        {
            //guid = Guid.NewGuid();
        }

        //[Display]
        //public Guid guid
        //{
        //    get; set;
        //}
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
        public DateTime regdate;// '표준시편 정보등록일자',
        public DateTime updatedate;// '표준시편 정보변경일자',
        public DateTime notusedate;// '표준시편 사용안함등록일자(미삭제)',
        public int use10;// '표준시편 사용여부(사용1,미사용0)',
        public string mcname;// '표준시편 제조업체명(Manufacturer)',
        public string method;//'시험방법',





    }
}

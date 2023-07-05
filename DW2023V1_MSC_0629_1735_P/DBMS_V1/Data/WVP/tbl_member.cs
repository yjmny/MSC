using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.WVP
{
    public class tbl_member
    {
        //        CREATE TABLE `tbl_member` (
        //  `mbno` int NOT NULL AUTO_INCREMENT COMMENT '멤버순번',
        //  `id` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '맴버 ID',
        //  `name` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '사용자명',
        //  `pwd` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '멤버 비밀번호',
        //  `regdate` datetime DEFAULT CURRENT_TIMESTAMP COMMENT '등록일자',
        //  `outdate` datetime DEFAULT CURRENT_TIMESTAMP COMMENT '탈퇴일자',
        //  `out10` int DEFAULT '1' COMMENT '탈퇴여부(사용1,미사용0)',
        //  `divlevel` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0' DEFAULT NULL COMMENT '멤버 등급 구분',
        //  `comname` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT 'not set' DEFAULT NULL COMMENT '멤버소속 기관명',
        //  `teamname` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT 'not set' DEFAULT NULL COMMENT '부서구분',
        //  `use10` int DEFAULT '1' COMMENT '사용여부(사용1,미사용0)',
        //  `contact` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '연락처',
        //  `updatedate` datetime DEFAULT CURRENT_TIMESTAMP COMMENT '변경일자',

        //  PRIMARY KEY(`mbno`)
        //) ENGINE=InnoDB AUTO_INCREMENT = 8 DEFAULT CHARSET = utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT = '사용자 멤버관리 정보테이블';

        public tbl_member()
        {

        }

        public int mbno; // '멤버순번 기본키',
        public string id;// '맴버 ID',
        public string name;// '사용자명',
        public string pwd;// '멤버 비밀번호',
        public DateTime regdate;// '등록일자',
        public DateTime outdate;// '탈퇴일자',
        public string out10;// '탈퇴여부(사용1,미사용0)',
        public string divlevel;// '멤버 등급 구분',
        public string comname;// '멤버소속 기관명',
        public string teamname;// '부서구분',
        public string use10;// '사용여부(사용1,미사용0)',
        public string contact;// '연락처',
        public DateTime updatedate;// '변경일자',
    }
}

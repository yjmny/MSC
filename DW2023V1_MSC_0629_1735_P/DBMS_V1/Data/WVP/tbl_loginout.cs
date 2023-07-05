using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.WVP
{
    public class tbl_loginout
    {
        //        CREATE TABLE `tbl_loginout` (
        //  `loginno` int NOT NULL AUTO_INCREMENT COMMENT '로그인아웃 순번(PK)',
        //  `mbid` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '멤버 ID',
        //  `logintime` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '로그인 시간',
        //  `logouttime` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '로그아웃시간',
        //  `exeloc` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '실행위치',
        //  `mbno` int DEFAULT NULL COMMENT '멤버순번(FK)',
        //  PRIMARY KEY(`loginno`)
        //) ENGINE=InnoDB AUTO_INCREMENT = 462 DEFAULT CHARSET = utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
        public tbl_loginout()
        {

        }

        public int loginno; // '로그인아웃 순번(PK)',
        public string mbid; // '멤버 ID',
        public string logintime; // '로그인 시간',
        public string logouttime; // '로그아웃시간',
        public string exeloc; // '실행위치',
        public int mbno; // '멤버순번(FK)',

    }
}

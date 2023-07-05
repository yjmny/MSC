using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.WVP
{
    /// <summary>
    /// Web 통합관제시스템 SI 정보테이블
    /// </summary>
    public class tbl_webserver
    {
        public tbl_webserver() { }

        //-- dwsmartictdb_wvp.tbl_webserver definition
        //CREATE TABLE `tbl_webserver` (
        //  `webno` int NOT NULL AUTO_INCREMENT COMMENT '웹 순번 기본키',
        //  `nwno` int DEFAULT NULL COMMENT '네트워크 순번(FK)',
        //  `type` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT 'TCP' COMMENT '네트워크 타입(TCP,UDP)',
        //  `name` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '통신명',
        //  `id` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '웹 아이디',
        //  `pwd` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '비밀번호(SHA256)',
        //  `ip` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '웹 IP',
        //  `port` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '8080' COMMENT '웹 PORT번호(8080)',
        //  `getpost` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT 'POST' COMMENT 'GET,POST',
        //  `use10` int DEFAULT NULL COMMENT '통신 사용여부',
        //  `isalive10` int DEFAULT NULL COMMENT '통신 생존여부',
        //  `isconnect10` int DEFAULT NULL COMMENT '통신 연결여부',
        //  PRIMARY KEY(`webno`)
        //) ENGINE=InnoDB AUTO_INCREMENT = 2 DEFAULT CHARSET = utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT = 'Web 통합관제시스템 SI 정보테이블';

        public string webno;//` int NOT NULL AUTO_INCREMENT COMMENT '웹 순번 기본키',
        public string nwno;//` int DEFAULT NULL COMMENT '네트워크 순번(FK)',
        public string type;//` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT 'TCP' COMMENT '네트워크 타입(TCP,UDP)',
        public string name;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '통신명',
        public string id;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '웹 아이디',
        public string pwd;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '비밀번호(SHA256)',
        public string ip;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '웹 IP',
        public string port;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT '8080' COMMENT '웹 PORT번호(8080)',
        public string getpost;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT 'POST' COMMENT 'GET,POST',
        public string use10;//` int DEFAULT NULL COMMENT '통신 사용여부',
        public string isalive10;//` int DEFAULT NULL COMMENT '통신 생존여부',
        public string isconnect10;//` int DEFAULT NULL COMMENT '통신 연결여부',

    }
}

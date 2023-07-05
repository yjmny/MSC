using C1.Silverlight.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.WVP
{
    /// <summary>
    /// 네트워크 정보테이블
    /// </summary>
    public class tbl_tcpipcomm
    {
        //-- dwsmartictdb_wvp.tbl_tcpipcomm definition

        //CREATE TABLE `tbl_tcpipcomm` (
        //  `comno` int NOT NULL AUTO_INCREMENT COMMENT '시리얼통신 순번',
        //  `nwno` int DEFAULT NULL COMMENT '네트워크 순번(FK)',
        //  `type` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL DEFAULT 'TCP' COMMENT '시리얼통신 타입(RS232,RS485)',
        //  `id` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '통신ID',
        //  `name` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '시리얼통신명',
        //  `port` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '시리얼통신 PORT번호',
        //  `use10` int DEFAULT NULL COMMENT '시리얼통신 사용여부',
        //  `isalive10` int DEFAULT NULL COMMENT '시리얼통신 생존여부',
        //  `isconnect10` int DEFAULT NULL COMMENT '시리얼통신 연결여부',
        //  PRIMARY KEY(`comno`)
        //) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE = utf8mb4_0900_ai_ci COMMENT='네트워크 정보테이블';

        public string comno;
        public string nwno;
        public string type;
        public string id;
        public string name;
        public string ipaddress;
        public string port;
        public string baudrate;
        public string use10;
        public string isalive10;
        public string isconnect10;
        public string commmandName;
        public string inputData;
        public string dregaddr;
        
    }
}

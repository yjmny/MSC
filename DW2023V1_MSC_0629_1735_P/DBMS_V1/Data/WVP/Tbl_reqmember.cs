using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.WVP
{
    /// <summary>
    /// 
    /// </summary>
    public class Tbl_reqmember
    {
        public Tbl_reqmember() { }

        public string reqmbno;//` int NOT NULL AUTO_INCREMENT COMMENT '의뢰자 멤버 순번 기본키',
        public string id;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '의뢰자멤버 아이디(사업자등록번호)',
        public string regdate;//` datetime DEFAULT CURRENT_TIMESTAMP COMMENT '등록일자',
        public string outdate;//` datetime DEFAULT NULL COMMENT '탈퇴일자',
        public string out10;//` int DEFAULT '0' COMMENT '탈퇴여부(탈퇴:1,default:0)',
        public string divlevel;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '0' COMMENT '멤버 등급 구분(VIP:1,default:0)',
        public string comname;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '멤버 소속기관명',
        public string teamname;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '부서구분',
        public string tel1;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '연락처1(00-000-000-0000)',
        public string tel2;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '연락처2',
        public string use10;//` int DEFAULT '1' COMMENT '사용여부(사용1,중지0)',
        public string name;//` varchar(200) DEFAULT NULL COMMENT '의뢰자명',
        public string contact;//` varchar(100) DEFAULT NULL COMMENT '연락처',
        public string updatedate;//` datetime DEFAULT NULL,

    }
}

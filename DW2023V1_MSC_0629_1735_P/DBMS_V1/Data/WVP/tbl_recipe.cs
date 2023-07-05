using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.WVP
{
    public class tbl_recipe
    {
        public tbl_recipe() { }

        public string rcpno;//` int NOT NULL AUTO_INCREMENT COMMENT '레시피 순번 기본키',
        public string mbno;//` int DEFAULT NULL COMMENT '사용자 순번(FK)',
        public string stdidlist;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT 'net set' COMMENT '표준시편 ID 리스트',
        public string reqmbidlist;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT 'net set' COMMENT '의뢰자 ID 리스트',
        public string reqsampleidlist;//` varchar(200) DEFAULT 'net set' COMMENT '의뢰자샘플 ID 리스트',
        public string id;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '레시피 ID',
        public string name;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '레시피명',
        public string benchmarkvalue;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '레시피기준값',
        public string max;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '레시피 최대값',
        public string min;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '레시피 최소값',
        public string marginoferror;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '레시피 허용오차',
        public string unit;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '레시피 표시 단위',
        public string regdate;//` datetime DEFAULT NULL COMMENT '레시피 등록일자',
        public string updatedate;//` datetime DEFAULT CURRENT_TIMESTAMP COMMENT '레시피 변경일자',
        public string stdid1;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준시편 ID1',
        public string stdid2;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준시편 ID2',
        public string stdid3;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준시편 ID3',
        public string stdid4;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준시편 ID4',
        public string stdid5;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준시편 ID5',
        public string stdid6;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준시편 ID6',
        public string reqmbid1;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 ID1',
        public string reqmbid2;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 ID2',
        public string reqmbid3;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 ID3',
        public string reqsampleid1;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자샘플 ID1',
        public string reqsampleid2;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자샘플 ID2',
        public string reqsampleid3;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자샘플 ID3',
        public string notusedate;//` datetime DEFAULT NULL COMMENT '레시피사용안함등록일자(미삭제)',
        public string useyn;//` int DEFAULT '1' COMMENT '레시피사용여부(미사용0,사용1)',
        public string stdno;//` int NOT NULL COMMENT '표준시편 순번(FK)',
        public string reqsampleno;//` int NOT NULL COMMENT '의뢰자샘플 순번(FK)',
        public string reqmbno;//` int NOT NULL COMMENT '의뢰자 맴버순번(FK)',
        public string use10;//` int DEFAULT NULL COMMENT '레시피 사용여부',
        public string method;
        public string reqmbname;
        public string mtime;//측정시간(기본값:3600) 단위:sec
        public string roidiameter;//측정직경(기본값:60) 단위:mm
    }
}

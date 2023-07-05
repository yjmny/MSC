using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.MSC
{
    /// <summary>
    /// 
    /// </summary>
    public class Tbl_reqmember_sample
    {
        public Tbl_reqmember_sample() { }

        public string reqsampleno;//` int NOT NULL AUTO_INCREMENT COMMENT '의뢰자샘픔 순번 기본키',
        public string divno;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자샘픔 구분번호(PH,EC,...)',
        public string id;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '의뢰자샘픔 ID',
        public string name;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자샘픔명',
        public string value;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자샘픔값',
        public string intensity;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자샘픔 인텐시티',
        public string max;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자샘픔 최대값',
        public string min;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자샘픔 최소값',
        public string marginoferror;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자샘픔 허용오차',
        public string unit;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자샘픔 표시 단위',
        public string regdate;//` datetime DEFAULT CURRENT_TIMESTAMP COMMENT '의뢰자샘픔정보등록일자',
        public string updatedate;//` datetime DEFAULT NULL COMMENT '의뢰자샘픔정보변경일자',
        public string notusedate;//` datetime DEFAULT NULL COMMENT '의뢰자샘픔 사용안함등록일자(미삭제)',
        public string use10;//` int DEFAULT '1' COMMENT '의뢰자샘픔 사용여부(사용1,미사용0)',
        public string mcname;//` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT 'not set' COMMENT '의뢰자샘픔 제조업체명(Manufacturer)',
        public string reqmbno;//` int DEFAULT NULL COMMENT '의뢰자 멤버 순번(FK)',
        public string reqmbname;//` int DEFAULT NULL COMMENT '의뢰자 멤버 이름',
        public string method;//'시험방법',
    }
}

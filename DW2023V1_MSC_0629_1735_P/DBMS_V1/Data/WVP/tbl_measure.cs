using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.WVP
{
    public class tbl_measure
    {
        //        CREATE TABLE `tbl_measure` (
        //  `msno` int NOT NULL AUTO_INCREMENT COMMENT '측정 샘플 순번 기본키',
        //  `rcpno` int NOT NULL DEFAULT '0' COMMENT '로드한 레시피 순번(FK)',
        //  `mbno` int NOT NULL COMMENT '멤버 순번(FK)',
        //  `stdno` int DEFAULT NULL COMMENT '표준 샘플 순번(FK)',
        //  `reqmbno` int DEFAULT NULL COMMENT '의뢰자 멤버 순번(FK)',
        //  `rcpid` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '로드한 레시피 ID',
        //  `rcpname` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '로드한 레시피명',
        //  `rcpbenchmarkvalue` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '로드한 레시피 기준값',
        //  `rcpmax` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '로드한 레시피 최대값',
        //  `rcpmin` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '로드한 레시피 최소값',
        //  `unit` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '표준 샘플 표시 단위',
        //  `divno` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정용 샘플 구분번호',
        //  `id` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '측정 ID(202301181336123_0001)',
        //  `name` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정명(투습도_202301181336123_0001)',
        //  `mbid` varchar(200) DEFAULT NULL COMMENT '측정자멤버ID',
        //  `reqmbid1` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 ID 1',
        //  `reqsampleid1` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자샘플 ID1',
        //  `reqsampleid2` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자샘플 ID2',
        //  `reqsampleid3` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자샘플 ID3',
        //  `reqsampleno` int NOT NULL COMMENT '의뢰자 샘플 순번(FK)',
        //  `totalstartdate` datetime DEFAULT NULL COMMENT '측정 시작시간(전체)',
        //  `totalenddate` datetime DEFAULT NULL COMMENT '측정완료시간(전체)',
        //  `totalaccutime` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정용 샘플 측정시간 누적',
        //  `reqmbid2` varchar(200) DEFAULT NULL COMMENT '의뢰자 ID 2',
        //  `reqmbid3` varchar(200) DEFAULT NULL COMMENT '의뢰자 ID 3',
        //  PRIMARY KEY(`msno`),
        //  KEY `FK_tbl_member_TO_tbl_measurevo` (`mbno`),
        //  KEY `FK_tbl_samplevo_TO_tbl_measurevo` (`stdno`),
        //  KEY `FK_tbl_requestermember_TO_tbl_measurevo` (`reqmbno`),
        //  CONSTRAINT `FK_tbl_member_TO_tbl_measurevo` FOREIGN KEY(`mbno`) REFERENCES `tbl_member` (`mbno`),
        //  CONSTRAINT `FK_tbl_requestermember_TO_tbl_measurevo` FOREIGN KEY(`reqmbno`) REFERENCES `tbl_reqmember` (`reqmbno`),
        //  CONSTRAINT `FK_tbl_samplevo_TO_tbl_measurevo` FOREIGN KEY(`stdno`) REFERENCES `tbl_standardspec` (`stdno`)
        //) ENGINE=InnoDB AUTO_INCREMENT = 3848 DEFAULT CHARSET = utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT = '샘플 측정 정보테이블';

        public tbl_measure()
        {

        }

        public int msno; // '측정 샘플 순번 기본키',
        public int rcpno; // '로드한 레시피 순번(FK)',
        public int mbno; // '멤버 순번(FK)',
        public int stdno; // '표준 샘플 순번(FK)',
        public int reqmbno; // '의뢰자 멤버 순번(FK)',
        public int rcpid; // '로드한 레시피 ID',
        public DateTime rcpname;// '로드한 레시피명',
        public DateTime rcpbenchmarkvalue;// '로드한 레시피 기준값',
        public string rcpmax;// '로드한 레시피 최대값',
        public string rcpmin;// '로드한 레시피 최소값',
        public string unit;// '표준 샘플 표시 단위',
        public string divno;// '측정용 샘플 구분번호',
        public string id;// '측정 ID(202301181336123_0001)',
        public string name;// '측정명(투습도_202301181336123_0001)',
        public string mbid;// '측정자멤버ID',
        public string reqmbid1;// '의뢰자 ID 1',
        public string reqsampleid1;// '의뢰자샘플 ID1',
        public string reqsampleid2;// '의뢰자샘플 ID2',
        public string reqsampleid3;// '의뢰자샘플 ID3',
        public string reqsampleno;// '의뢰자 샘플 순번(FK)',
        public string totalstartdate;// '측정 시작시간(전체)',
        public string totalenddate;// '측정완료시간(전체)',
        public string totalaccutime;// '측정용 샘플 측정시간 누적',
        public string reqmbid2;// '의뢰자 ID 2',
        public string reqmbid3;// '의뢰자 ID 3',

    }
}

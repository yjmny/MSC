using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.WVP
{
    public class tbl_measure_chamber
    {
        //        CREATE TABLE `tbl_measure_chamber` (
        //  `chamberno` int NOT NULL AUTO_INCREMENT COMMENT '챔버순번',
        //  `rcpno` int NOT NULL DEFAULT '0' COMMENT '레시피 순번(FK)',
        //  `rcpid` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '로드한 레시피 ID',
        //  `id` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '챔버 ID',
        //  `mbid` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정자멤버ID',
        //  `reqmbid1` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자ID1',
        //  `mbno` int NOT NULL COMMENT '멤버순번(FK)',
        //  `stdno` int NOT NULL COMMENT '표준시편 순번(FK)',
        //  `reqsampleno` int NOT NULL COMMENT '의뢰자샘플순번(FK)',
        //  `reqmbno` int NOT NULL COMMENT '의뢰자 멤버순번(FK)',
        //  `msid` varchar(200) DEFAULT NULL COMMENT '측정ID',
        //  `msname` varchar(200) DEFAULT NULL COMMENT '측정명',
        //  `reqmbid2` varchar(200) DEFAULT NULL COMMENT '의뢰자ID2',
        //  `reqmbid3` varchar(200) DEFAULT NULL COMMENT '의뢰자ID3',
        //  `totalstarttime` datetime DEFAULT NULL COMMENT '측정시작시간(전체)',
        //  `totalendtime` datetime DEFAULT NULL COMMENT '측정완료시간(전체)',
        //  `accumtime` varchar(200) DEFAULT NULL COMMENT '측정시간누적',
        //  `divno` varchar(200) DEFAULT NULL COMMENT '측정구분번호(무게전1, 챔버2, 무게후3)',
        //  `unit` varchar(200) DEFAULT NULL COMMENT '표시단위',
        //  `reqsampleid1` varchar(200) DEFAULT NULL COMMENT '의뢰자샘플ID1',
        //  `reqsampleid2` varchar(200) DEFAULT NULL COMMENT '의뢰자샘플ID2',
        //  `reqsampleid3` varchar(200) DEFAULT NULL COMMENT '의뢰자샘플ID3',
        //  `divtime` varchar(200) DEFAULT NULL COMMENT '측정구분시간',
        //  `temp1` varchar(200) DEFAULT NULL COMMENT '온도 측정값1',
        //  `humi1` varchar(200) DEFAULT NULL COMMENT '습도 측정값1',
        //  `windspeed1` varchar(200) DEFAULT NULL COMMENT '풍속 측정값1',
        //  `msno` int NOT NULL COMMENT '측정순번(FK)',
        //  `rcpname` varchar(200) DEFAULT NULL COMMENT '로드한 레시피 명',
        //  PRIMARY KEY(`chamberno`)
        //) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE = utf8mb4_0900_ai_ci COMMENT='샘플 측정 정보테이블';
        public tbl_measure_chamber()
        {

        }

         public int chamberno; // '챔버순번',
        public int rcpno;// '레시피 순번(FK)',
        public string rcpid;// '로드한 레시피 ID',
        public string id;// '챔버 ID',
        public string mbid;// '측정자멤버ID',
        public string reqmbid1;// '의뢰자ID1',
        public int mbno;// '멤버순번',
        public int stdno;// '표준시편순번',
        public int reqsampleno;// '의뢰자샘플순번',
        public int reqmbno;// '의뢰자 멤버순번',
        public string msid;// '측정ID',
        public string msname;// '측정명',
        public string reqmbid2;// '의뢰자ID2',
        public string reqmbid3;// '의뢰자ID3',
        public string totalstarttime;// '측정시작시간',
        public string totalendtime;//'측정완료시간',
        public string accumtime;//'측정시간누적',
        public string divno;//'측정구분번호(무게전1, 챔버2, 무게후3)',
        public string unit;//'표시단위',
        public string reqsampleid1;//'의뢰자샘플ID1',
        public string reqsampleid2;//'의뢰자샘플ID2',
        public string reqsampleid3;//'의뢰자샘플ID3',
        public string divtime;//'측정구분시간',
        public string rd1;//'온도 측정값1',
        public string rd2;//'습도 측정값1',
        public string rd3;//'풍속 측정값1',
        public string rd4;//'온도 측정값1',
        public string rd5;//'습도 측정값1',
        public string hd1;//'풍속 측정값1',
        public string hd2;//'온도 측정값1',
        public string hd5;//'습도 측정값1',
        public string hd6;//'풍속 측정값1',
        public string msno;//'측정순번',
        public string rcpname;//'로드한 레시피 명',
        public string stdname;
        public string method;
    }
}

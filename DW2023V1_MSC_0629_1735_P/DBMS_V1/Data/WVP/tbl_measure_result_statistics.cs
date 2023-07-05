using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.WVP
{
    /// <summary>
    /// 측정통계 정보테이블
    /// </summary>
    public class tbl_measure_result_statistics
    {
        //        -- dwsmartictdb_wvp.tbl_measure_result_statistics definition
        //CREATE TABLE `tbl_measure_result_statistics` (
        //  `msresultno` int NOT NULL AUTO_INCREMENT COMMENT '측정결과통계 순번(PK)',
        //  `msno` int DEFAULT NULL COMMENT '측정 샘플 순번(FK)',
        //  `rcpno` int DEFAULT NULL COMMENT '레시피 순번(FK)',
        //  `mbno` int DEFAULT NULL COMMENT '멤버 순번(FK)',
        //  `stdno` int DEFAULT NULL COMMENT '표준 샘플 순번(FK)',
        //  `reqsampleno` int DEFAULT NULL COMMENT '의뢰자 샘플 순번(FK)',
        //  `reqmbno` int DEFAULT NULL COMMENT '의뢰자 멤버 순번(FK)',
        //  `escaleno` int DEFAULT NULL COMMENT '무게저울 순번(FK)',
        //  `chamberno` int DEFAULT NULL COMMENT '챔버 순번',
        //  `id` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정통계 ID',
        //  `msid` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정 ID',
        //  `msname` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정명',
        //  `rcpid` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '레시피 ID',
        //  `rcpname` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '레시피명',
        //  `mbid` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정자 ID',
        //  `reqmbid1` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 ID1',
        //  `reqmbid2` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 ID2',
        //  `reqmbid3` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 ID3',
        //  `mstotalstarttime` datetime DEFAULT NULL COMMENT '측정 시작시간(전체)',
        //  `mstotalendtime` datetime DEFAULT NULL COMMENT '측정 완료시간(전체)',
        //  `predata1` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '무게저울 챔버 측정 전1 측정값',
        //  `predata2` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '무게저울 챔버 측정 전2 측정값',
        //  `predata3` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '무게저울 챔버 측정 전3 측정값',
        //  `aftdata1` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '무게저울 챔버 측정 후1 측정값',
        //  `aftdata2` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '무게저울 챔버 측정 후2 측정값',
        //  `aftdata3` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '무게저울 챔버 측정 후3 측정값',
        //  `wvpdata1` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 샘플 투습도1',
        //  `wvpdata2` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 샘플 투습도2',
        //  `wvpdata3` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 샘플 투습도3',
        //  `wvpavg` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정샘플결과_평균값',
        //  `wvpmax` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정샘플결과_최대값',
        //  `wvpmin` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정샘플결과_최소값',
        //  `wvpstdev` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정샘플결과_표준편차',
        //  `wvpgab` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정샘플결과_레시피간 갭',
        //  `wvpokng` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '측정샘플결과_판정',
        //  PRIMARY KEY(`msresultno`)
        //) ENGINE=InnoDB AUTO_INCREMENT = 65 DEFAULT CHARSET = utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT = '측정통계 정보테이블';

        public string msresultno;//` int NOT NULL AUTO_INCREMENT COMMENT '측정결과통계 순번(PK)',
        public string msno;//` int DEFAULT NULL COMMENT '측정 샘플 순번(FK)',
        public string rcpno;//` int DEFAULT NULL COMMENT '레시피 순번(FK)',
        public string mbno;//` int DEFAULT NULL COMMENT '멤버 순번(FK)',
        public string stdno;//` int DEFAULT NULL COMMENT '표준 샘플 순번(FK)',
        public string reqsampleno;//` int DEFAULT NULL COMMENT '의뢰자 샘플 순번(FK)',
        public string reqmbno;//` int DEFAULT NULL COMMENT '의뢰자 멤버 순번(FK)',
        public string escaleno;//` int DEFAULT NULL COMMENT '무게저울 순번(FK)',
        public string chamberno;//` int DEFAULT NULL COMMENT '챔버 순번',
        public string id;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정통계 ID',
        public string msid;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정 ID',
        public string msname;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정명',
        public string rcpid;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '레시피 ID',
        public string rcpname;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '레시피명',
        public string mbid;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정자 ID',
        public string reqmbid1;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 ID1',
        public string reqmbid2;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 ID2',
        public string reqmbid3;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 ID3',
        public string mstotalstarttime;//` datetime DEFAULT NULL COMMENT '측정 시작시간(전체)',
        public string mstotalendtime;//` datetime DEFAULT NULL COMMENT '측정 완료시간(전체)',
        public string predata1;//` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '무게저울 챔버 측정 전1 측정값',
        public string predata2;//` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '무게저울 챔버 측정 전2 측정값',
        public string predata3;//` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '무게저울 챔버 측정 전3 측정값',
        public string aftdata1;//` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '무게저울 챔버 측정 후1 측정값',
        public string aftdata2;//` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '무게저울 챔버 측정 후2 측정값',
        public string aftdata3;//` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '무게저울 챔버 측정 후3 측정값',
        public string wvpdata1;//` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 샘플 투습도1',
        public string wvpdata2;//` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 샘플 투습도2',
        public string wvpdata3;//` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '의뢰자 샘플 투습도3',
        public string wvpavg;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정샘플결과_평균값',
        public string wvpmax;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정샘플결과_최대값',
        public string wvpmin;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정샘플결과_최소값',
        public string wvpstdev;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정샘플결과_표준편차',
        public string wvpgab;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정샘플결과_레시피간 갭',
        public string wvpokng;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL COMMENT '측정샘플결과_판정',
        public string method;
        public string reqsampleid1;
        public string reqsampleid2;
        public string reqsampleid3;
        public string reqmbname;
        public string stdname;
    }
}

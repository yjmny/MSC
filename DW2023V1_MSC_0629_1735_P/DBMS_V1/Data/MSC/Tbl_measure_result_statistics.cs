using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.MSC
{
    /// <summary>
    /// 측정통계 정보테이블
    /// </summary>
    public class Tbl_measure_result_statistics
    {
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


        public string md1avg;
        public string md2avg;
        public string md3avg;
        public string md4avg;
        public string md5avg;
        public string ai01avg;
        public string ai02avg;
        public string ai03avg;
        public string ai04avg;
        public string ai05avg;
        public string ai06avg;
        public string ai07avg;
        public string ai08avg;
        public string ai09avg;
        public string ai10avg;
        public string ai11avg;
        public string ai12avg;
        public string ao01avg;
        public string ao02avg;
        public string di01avg;
        public string di02avg;
        public string di03avg;
        public string di04avg;
        public string do01avg;
        public string do02avg;

        public string md1min;
        public string md2min;
        public string md3min;
        public string md4min;
        public string md5min;
        public string ai01min;
        public string ai02min;
        public string ai03min;
        public string ai04min;
        public string ai05min;
        public string ai06min;
        public string ai07min;
        public string ai08min;
        public string ai09min;
        public string ai10min;
        public string ai11min;
        public string ai12min;
        public string ao01min;
        public string ao02min;
        public string di01min;
        public string di02min;
        public string di03min;
        public string di04min;
        public string do01min;
        public string do02min;

        public string md1max;
        public string md2max;
        public string md3max;
        public string md4max;
        public string md5max;
        public string ai01max;
        public string ai02max;
        public string ai03max;
        public string ai04max;
        public string ai05max;
        public string ai06max;
        public string ai07max;
        public string ai08max;
        public string ai09max;
        public string ai10max;
        public string ai11max;
        public string ai12max;
        public string ao01max;
        public string ao02max;
        public string di01max;
        public string di02max;
        public string di03max;
        public string di04max;
        public string do01max;
        public string do02max;

    }
}

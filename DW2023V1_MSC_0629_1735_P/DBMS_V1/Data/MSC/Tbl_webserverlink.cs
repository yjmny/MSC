﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.MSC
{
    /// <summary>
    /// Web 통합운영시스템 연동데이터 이력정보테이블'
    /// </summary>
    public class Tbl_webserverlink
    {
        public Tbl_webserverlink() { }

        public string weblinkno;//; '웹서버 데이터 전송링크 순번',
        public string alno;//` int DEFAULT NULL COMMENT '알람이력 순번',
        public string mbno;//` int DEFAULT NULL COMMENT '멤버 순번',
        public string msresultno;//` int NOT NULL COMMENT '측정결과 통계 순번',
        public string msno;//` int NOT NULL COMMENT '측정 순번',
        public string rcpno;//` int NOT NULL COMMENT '레시피 순번',
        public string stdno;//` int NOT NULL COMMENT '표준시편 순번',
        public string reqsampleno;//` int NOT NULL COMMENT '의뢰자 샘플 순번',
        public string reqmbno;//` int NOT NULL COMMENT '의뢰자 순번',
        public string escaleno;//` int NOT NULL COMMENT '무게저울 순번',
        public string dbno;//` int DEFAULT NULL COMMENT 'DB 순번',
        public string nwno;//` int DEFAULT NULL COMMENT '네트워크 순번',
        public string comno;//` int DEFAULT NULL COMMENT '시리얼통신 순번',
        public string webno;//` int DEFAULT NULL COMMENT '웹서버 순번',
        public string chamberno;//` int DEFAULT NULL COMMENT '챔버 순번',
        public string id;//` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '웹서버 링크 ID',
        public string senddiv;//` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '전송구분(알람,측정데이터)',
        public string alstarttime;//` datetime DEFAULT CURRENT_TIMESTAMP COMMENT '알람발생시작시간',
        public string alendtime;//` datetime DEFAULT NULL COMMENT '알람발생처리완료시간',
        public string aldiv;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '알람구분(경고(W),오류(E))',
        public string altitle;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '알람제목',
        public string alcontent;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '알람내용',
        public string almemo;// varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '알람 장애 처리사항',
        public string almbid;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '장애처리확인자 멤버ID',
        public string statisticsid;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '측정 통계 ID',
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
        public string starttime;//` datetime DEFAULT CURRENT_TIMESTAMP COMMENT '내보내기 시작시간',
        public string enddate;//` datetime DEFAULT NULL COMMENT '내보내기 완료시간',
        public string okng;//` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '내보내기 판정',
    }
}


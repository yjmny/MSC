﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.WVP
{
    /// <summary>
    /// PDF 내보내기 정보테이블
    /// </summary>
    public class tbl_pdf
    {
        //-- dwsmartictdb_wvp.tbl_pdf definition

        //CREATE TABLE `tbl_pdf` (
        //  `pdfno` int NOT NULL AUTO_INCREMENT COMMENT 'DB 순번',
        //  `msresultno` int NOT NULL COMMENT '측정결과 통계 순번',
        //  `msno` int NOT NULL COMMENT '측정 순번',
        //  `rcpno` int NOT NULL COMMENT '레시피 순번',
        //  `mbno` int NOT NULL COMMENT '멤버 순번',
        //  `stdno` int NOT NULL COMMENT '표준시편 순번',
        //  `reqsampleno` int NOT NULL COMMENT '의뢰자 샘플 순번',
        //  `escaleno` int NOT NULL COMMENT '무게저울 순번',
        //  `chamberno` int DEFAULT NULL COMMENT '챔버 순번',
        //  `id` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT 'CSV ID',
        //  `phyloc` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '물리적위치 파일정보',
        //  `logicalloc` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '논리적위치 파일정보',
        //  `phyname` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '물리적 파일명',
        //  `logicalname` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '논리적파일명',
        //  `filesize` int DEFAULT NULL COMMENT '파일크기',
        //  `starttime` datetime DEFAULT NULL COMMENT '내보내기 시작시간',
        //  `endtime` datetime DEFAULT NULL COMMENT '내보내기 완료시간',
        //  `okng` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '내보내기 판정',
        //  `reqmbno` varchar(100) NOT NULL COMMENT '의뢰자 멤버 순번',
        //  PRIMARY KEY(`pdfno`)
        //) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE = utf8mb4_0900_ai_ci COMMENT='PDF 내보내기 정보테이블';


        public string pdfno;//` int NOT NULL AUTO_INCREMENT COMMENT 'DB 순번',
        public string msresultno;//` int NOT NULL COMMENT '측정결과 통계 순번',
        public string msno;//` int NOT NULL COMMENT '측정 순번',
        public string rcpno;//` int NOT NULL COMMENT '레시피 순번',
        public string mbno;//` int NOT NULL COMMENT '멤버 순번',
        public string stdno;//` int NOT NULL COMMENT '표준시편 순번',
        public string reqsampleno;//` int NOT NULL COMMENT '의뢰자 샘플 순번',
        public string escaleno;//` int NOT NULL COMMENT '무게저울 순번',
        public string chamberno;//` int DEFAULT NULL COMMENT '챔버 순번',
        public string id;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT 'CSV ID',
        public string phyloc;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '물리적위치 파일정보',
        public string logicalloc;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '논리적위치 파일정보',
        public string phyname;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '물리적 파일명',
        public string logicalname;//` varchar(200) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '논리적파일명',
        public string filesize;//` int DEFAULT NULL COMMENT '파일크기',
        public string starttime;//` datetime DEFAULT NULL COMMENT '내보내기 시작시간',
        public string endtime;//` datetime DEFAULT NULL COMMENT '내보내기 완료시간',
        public string okng;//` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL COMMENT '내보내기 판정',
        public string reqmbno;//` varchar(100) NOT NULL COMMENT '의뢰자 멤버 순번',

    }
}

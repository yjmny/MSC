﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.MSC
{
    public class Tbl_plc_calibration
    {
        public Tbl_plc_calibration()
        {

        }
        public string calno;// int NOT NULL AUTO_INCREMENT COMMENT 'PLC 캘리브레이션 순번 기본키',
        public string id;//` varchar(50) 'PLC 캘리브레이션 ID',
        public string no;//` varchar(50)  'PLC 캘리브레이션NO == ID와 동일',
        public string name;//` varchar(50) 'PLC 캘리브레이션 NAME',
        public string use10;//` varchar(100) '사용여부(사용1,미사용0)',
        public string regdate;//` datetime(6) DEFAULT CURRENT_TIMESTAMP(6) COMMENT '등록일자',
        public string updatedate;//` datetime(6) DEFAULT NULL COMMENT '변경일자',
        public string ch1_plc_min1;//` varchar(50)  '채널1 PLC step1 min',
        public string ch1_plc_max1;//` varchar(50) '채널1 PLC step1 max',
        public string ch1_plc_min2;//` varchar(50)  '채널1 PLC step2 min',
        public string ch1_plc_max2;//` varchar(50) '채널1 PLC step2 max',
        public string ch1_plc_min3;//` varchar(50)  '채널1 PLC step3 min',
        public string ch1_plc_max3;//` varchar(50) '채널1 PLC step3 max',
        public string ch1_plc_min4;//` varchar(50)  '채널1 PLC step4 min',
        public string ch1_plc_max4;//` varchar(50) '채널1 PLC step4 max',
        public string ch1_plc_min5;//` varchar(50)  '채널1 PLC step5 min',
        public string ch1_plc_max5;//` varchar(50) '채널1 PLC step5 max',
        public string ch1_pc_min1;//` varchar(50) '채널1 PC step1 min',
        public string ch1_pc_max1;//` varchar(50)  '채널1 PC step1 max',
        public string ch1_pc_min2;//` varchar(50) '채널1 PC step2 min',
        public string ch1_pc_max2;//` varchar(50)  '채널1 PC step2 max',
        public string ch1_pc_min3;//` varchar(50) '채널1 PC step3 min',
        public string ch1_pc_max3;//` varchar(50)  '채널1 PC step3 max',
        public string ch1_pc_min4;//` varchar(50) '채널1 PC step4 min',
        public string ch1_pc_max4;//` varchar(50)  '채널1 PC step4 max',
        public string ch1_pc_min5;//` varchar(50) '채널1 PC step5 min',
        public string ch1_pc_max5;//` varchar(50)  '채널1 PC step5 max',
        public string ch2_plc_min1;//` varchar(50)  '채널2 PLC step1 min',
        public string ch2_plc_max1;//` varchar(50) '채널2 PLC step1 max',
        public string ch2_plc_min2;//` varchar(50)  '채널2 PLC step2 min',
        public string ch2_plc_max2;//` varchar(50) '채널2 PLC step2 max',
        public string ch2_plc_min3;//` varchar(50)  '채널2 PLC step3 min',
        public string ch2_plc_max3;//` varchar(50) '채널2 PLC step3 max',
        public string ch2_plc_min4;//` varchar(50)  '채널2 PLC step4 min',
        public string ch2_plc_max4;//` varchar(50) '채널2 PLC step4 max',
        public string ch2_plc_min5;//` varchar(50)  '채널2 PLC step5 min',
        public string ch2_plc_max5;//` varchar(50) '채널2 PLC step5 max',
        public string ch2_pc_min1;//` varchar(50) '채널2 PC step1 min',
        public string ch2_pc_max1;//` varchar(50)  '채널2 PC step1 max',
        public string ch2_pc_min2;//` varchar(50) '채널2 PC step2 min',
        public string ch2_pc_max2;//` varchar(50)  '채널2 PC step2 max',
        public string ch2_pc_min3;//` varchar(50) '채널2 PC step3 min',
        public string ch2_pc_max3;//` varchar(50)  '채널2 PC step3 max',
        public string ch2_pc_min4;//` varchar(50) '채널2 PC step4 min',
        public string ch2_pc_max4;//` varchar(50)  '채널2 PC step4 max',
        public string ch2_pc_min5;//` varchar(50) '채널2 PC step5 min',
        public string ch2_pc_max5;//` varchar(50)  '채널2 PC step5 max',
        public string ch3_plc_min1;//` varchar(50)  '채널3 PLC step1 min',
        public string ch3_plc_max1;//` varchar(50) '채널3 PLC step1 max',
        public string ch3_plc_min2;//` varchar(50)  '채널3 PLC step2 min',
        public string ch3_plc_max2;//` varchar(50) '채널3 PLC step2 max',
        public string ch3_plc_min3;//` varchar(50)  '채널3 PLC step3 min',
        public string ch3_plc_max3;//` varchar(50) '채널3 PLC step3 max',
        public string ch3_plc_min4;//` varchar(50)  '채널3 PLC step4 min',
        public string ch3_plc_max4;//` varchar(50) '채널3 PLC step4 max',
        public string ch3_plc_min5;//` varchar(50)  '채널3 PLC step5 min',
        public string ch3_plc_max5;//` varchar(50) '채널3 PLC step5 max',
        public string ch3_pc_min1;//` varchar(50) '채널3 PC step1 min',
        public string ch3_pc_max1;//` varchar(50)  '채널3 PC step1 max',
        public string ch3_pc_min2;//` varchar(50) '채널3 PC step2 min',
        public string ch3_pc_max2;//` varchar(50)  '채널3 PC step2 max',
        public string ch3_pc_min3;//` varchar(50) '채널3 PC step3 min',
        public string ch3_pc_max3;//` varchar(50)  '채널3 PC step3 max',
        public string ch3_pc_min4;//` varchar(50) '채널3 PC step4 min',
        public string ch3_pc_max4;//` varchar(50)  '채널3 PC step4 max',
        public string ch3_pc_min5;//` varchar(50) '채널3 PC step5 min',
        public string ch3_pc_max5;//` varchar(50)  '채널3 PC step5 max',
        public string ch4_plc_min1;//` varchar(50)  '채널4 PLC step1 min',
        public string ch4_plc_max1;//` varchar(50) '채널4 PLC step1 max',
        public string ch4_pc_min1;//` varchar(50) '채널4 PC step1 min',
        public string ch4_pc_max1;//` varchar(50)  '채널4 PC step1 max',
        public string ch5_plc_min1;//` varchar(50)  '채널5 PLC step1 min',
        public string ch5_plc_max1;//` varchar(50) '채널5 PLC step1 max',
        public string ch5_pc_min1;//` varchar(50) '채널5 PC step1 min',
        public string ch5_pc_max1;//` varchar(50)  '채널5 PC step1 max',
        public string ch6_plc_min1;//` varchar(50)  '채널6 PLC step1 min',
        public string ch6_plc_max1;//` varchar(50) '채널6 PLC step1 max',
        public string ch6_pc_min1;//` varchar(50) '채널6 PC step1 min',
        public string ch6_pc_max1;//` varchar(50)  '채널6 PC step1 max',
        public string ch7_plc_min1;//` varchar(50)  '채널7 PLC step1 min',
        public string ch7_plc_max1;//` varchar(50) '채널7 PLC step1 max',
        public string ch7_pc_min1;//` varchar(50) '채널7 PC step1 min',
        public string ch7_pc_max1;//` varchar(50)  '채널7 PC step1 max',
        public string ch8_plc_min1;//` varchar(50)  '채널8 PLC step1 min',
        public string ch8_plc_max1;//` varchar(50) '채널8 PLC step1 max',
        public string ch8_pc_min1;//` varchar(50) '채널8 PC step1 min',
        public string ch8_pc_max1;//` varchar(50)  '채널8 PC step1 max',
        public string ch9_plc_min1;//` varchar(50)  '채널9 PLC step1 min',
        public string ch9_plc_max1;//` varchar(50) '채널9 PLC step1 max',
        public string ch9_pc_min1;//` varchar(50) '채널9 PC step1 min',
        public string ch9_pc_max1;//` varchar(50)  '채널9 PC step1 max',
        public string ch10_plc_min1;//` varchar(50T '채널10 PLC step1 min',
        public string ch10_plc_max1;//` varchar(50T '채널10 PLC step1 max',
        public string ch10_pc_min1;//` varchar(50)T '채널10 PC step1 min',
        public string ch10_pc_max1;//` varchar(50T '채널10 PC step1 max',
        public string ch11_plc_min1;//` varchar(50T '채널11 PLC step1 min',
        public string ch11_plc_max1;//` varchar(50T '채널11 PLC step1 max',
        public string ch11_pc_min1;//` varchar(50)T '채널11 PC step1 min',
        public string ch11_pc_max1;//` varchar(50T '채널11 PC step1 max',
        public string ch12_plc_min1;//` varchar(50T '채널12 PLC step1 min',
        public string ch12_plc_max1;//` varchar(50T '채널12 PLC step1 max',
        public string ch12_pc_min1;//` varchar(50)T '채널12 PC step1 min',
        public string ch12_pc_max1;//` varchar(50T '채널12 PC step1 max',
        public string ch1_name;//` varchar(50) 채널1 name',
        public string ch2_name;//` varchar(50) 채널2 name',
        public string ch3_name;//` varchar(50) 채널3 name',
        public string ch4_name;//` varchar(50) 채널4 name',
        public string ch5_name;//` varchar(50) 채널5 name',
        public string ch6_name;//` varchar(50) 채널6 name',
        public string ch7_name;//` varchar(50) 채널7 name',
        public string ch8_name;//` varchar(50) 채널8 name',
        public string ch9_name;//` varchar(50) 채널9 name',
        public string ch10_name;//` varchar(50 '채널10 name',
        public string ch11_name;//` varchar(50 '채널11 name',
        public string ch12_name;//` varchar(50 '채널12 name',
        public string ch1_unit;//` varchar(50)  '채널1 단위(도,%,ppm,...)',
        public string ch2_unit;//` varchar(50)  '채널2 단위(도,%,ppm,...)',
        public string ch3_unit;//` varchar(50)  '채널3 단위(도,%,ppm,...)',
        public string ch4_unit;//` varchar(50)  '채널4 단위(도,%,ppm,...)',
        public string ch5_unit;//` varchar(50)  '채널5 단위(도,%,ppm,...)',
        public string ch6_unit;//` varchar(50)  '채널6 단위(도,%,ppm,...)',
        public string ch7_unit;//` varchar(50)  '채널7 단위(도,%,ppm,...)',
        public string ch8_unit;//` varchar(50)  '채널8 단위(도,%,ppm,...)',
        public string ch9_unit;//` varchar(50)  '채널9 단위(도,%,ppm,...)',
        public string ch10_unit;//` varchar(50) '채널10 단위(도,%,ppm,...)',
        public string ch11_unit;//` varchar(50) '채널11 단위(도,%,ppm,...)',
        public string ch12_unit;//` varchar(50) '채널12 단위(도,%,ppm,...)',
    }
}
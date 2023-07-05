using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.MSC
{
    public class Tbl_hmi_pattern
    {

        public Tbl_hmi_pattern() { }

        public string patternno;//HMI 패턴관리순번 기본키',
        public string name;// HMI 패턴명 (PC)
        public string pattern_name;// HMI 패턴Name_HMI',
        public string com_ptno;// HMI 패턴NO_HMI',
        public string com_segno;// HMI 세그먼트 번호',
        public string regdate;// 등록일자',

        public string temp_tsp;// HMI 온도 목표 설정치 TEMP.TSP',
        public string humi_tsp;// HMI 습도 목표 설정치 HUMI.TSP',
        public string seg_hhmmss;
        public string seg_time_h;// HMI 세그먼트 설정시간  Hour',
        public string seg_time_l;// HMI 세그먼트 설정시간  Minute & Second',
        public string ts1;//MI 타임시그널 ts1',
        public string ts2;//MI 타임시그널 ts2',
        public string ts3;//MI 타임시그널 ts3',
        public string ts4;//HMI 타임시그널 ts4',
        public string seg_wait;// HMI 타임시그널 wait',

    }
}

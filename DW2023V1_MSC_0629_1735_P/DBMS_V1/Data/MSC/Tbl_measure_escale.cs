using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.MSC
{
    public class Tbl_measure_escale
    {

        public Tbl_measure_escale()
        {
            InitEscaleMeasurementStatus();
        }

       public int escaleno; // '무게저울순번',
        public int mbno;// '멤버순번',
        public int stdno;// '표준샘플 순번',
        public int reqmbno;// '의뢰자멤버순번',
        public int rcpno;// '레시피순번',
        public int msno;// '측정순번',
        public int reqsampleno;// '의뢰자샘플 순번',
        public string id;// '무게저울 ID',
        public string msid;// '측정 ID',
        public string msname;// '측정명',
        public string rcpid;// '로드한 레시피 ID',
        public string mbid;// '측정자 ID',
        public string reqmbid1;// '의뢰자 ID1',
        public string reqmbid2;// '의뢰자 ID2',
        public string reqmbid3;// '의뢰자 ID3',
        public string predata1;//'무게저울 챔버 측정 전1 측정값',
        public string predata2;//'무게저울 챔버 측정 전2 측정값',
        public string predata3;//'무게저울 챔버 측정 전3 측정값',
        public string aftdata1;//'무게저울 챔버 측정 후1 측정값',
        public string aftdata2;//'무게저울 챔버 측정 후2 측정값',
        public string aftdata3;//'무게저울 챔버 측정 후3 측정값',
        public string totalstarttime;//'무게저울측정시작시간(전체)',
        public string totalendtime;//'무게저울측정완료시간',
        public string accumtime;//'무게저울측정시간누적',
        public string prestarttime1;//'무게저울 챔버 측정 전1 측정시작시간',
        public string prestarttime2;//'무게저울 챔버 측정 전2 측정시작시간',
        public string prestarttime3;//'무게저울 챔버 측정 전3 측정시작시간',
        public string preendtime1;//'무게저울 챔버 측정 전1 측정완료시간',
        public string preendtime2;//'무게저울 챔버 측정 전2 측정완료시간',
        public string preendtime3;//'무게저울 챔버 측정 전3 측정완료시간',
        public string afterstarttime1;//'무게저울 챔버 측정 후1 측정시작시간',
        public string afterstarttime2;//'무게저울 챔버 측정 후2 측정시작시간',
        public string afterstarttime3;//'무게저울 챔버 측정 후3 측정시작시간',
        public string afterendtime1;//'무게저울 챔버 측정 후1 측정완료시간',
        public string afterendtime2;//'무게저울 챔버 측정 후2 측정완료시간',
        public string afterendtime3;//'무게저울 챔버 측정 후3 측정완료시간',
        public string predatamax;//'무게저울 챔버 측정 s_a1 측정 최대값',
        public string predatamin;//'무게저울 챔버 측정 s_a1 측정 최소값',
        public string aftdatamax;//'무게저울 챔버 측정 s_a2 측정 최대값',
        public string aftdatamin;//'무게저울 챔버 측정 s_a2 측정 최소값',
        public string predataavg;//'무게저울 챔버 측정 s_a1 측정 평균값',
        public string aftdataavg;//'무게저울 챔버 측정 s_a2 측정 평균값',
        public string reqsampleid1;
        public string reqsampleid2;
        public string reqsampleid3;

        public  int PreMeasureCheck1 { get; set; }
        public  int PreMeasureCheck2 { get; set; }
        public  int PreMeasureCheck3 { get; set; }
        public  int PreMeasureCheckAll { get; set; }
        public  int PreSaveCheck1 { get; set; }
        public  int PreSaveCheck2 { get; set; }
        public  int PreSaveCheck3 { get; set; }
        public  int PreSaveCheckAll { get; set; }

        public  int AftMeasureCheck1 { get; set; }
        public  int AftMeasureCheck2 { get; set; }
        public  int AftMeasureCheck3 { get; set; }
        public  int AfterMeasureCheckAll { get; set; }
        public  int AftSaveCheck1 { get; set; }
        public  int AftSaveCheck2 { get; set; }
        public  int AftSaveCheck3 { get; set; }
        public  int AftSaveCheckAll { get; set; }

        public void InitEscaleMeasurementStatus()
        {
            PreMeasureCheck1 = 0;
            PreMeasureCheck2 = 0;
            PreMeasureCheck3 = 0;
            PreMeasureCheckAll = 0;
            PreSaveCheck1 = 0;
            PreSaveCheck2 = 0;
            PreSaveCheck3 = 0;
            PreSaveCheckAll = 0;

            AftMeasureCheck1 = 0;
            AftMeasureCheck2 = 0;
            AftMeasureCheck3 = 0;
            AfterMeasureCheckAll = 0;
            AftSaveCheck1 = 0;
            AftSaveCheck2 = 0;
            AftSaveCheck3 = 0;
            AftSaveCheckAll = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.MSC
{
    public class Tbl_measure_chamber
    {
        public Tbl_measure_chamber() { }

        public UInt32 chamberno; // '챔버순번',
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
        public string md1;
        public string md2;
        public string md3;
        public string md4;
        public string md5;
        public string ai01;
        public string ai02;
        public string ai03;
        public string ai04;
        public string ai05;
        public string ai06;
        public string ai07;
        public string ai08;
        public string ai09;
        public string ai10;
        public string ai11;
        public string ai12;
        public string ao01;
        public string ao02;
        public string di01;
        public string di02;
        public string di03;
        public string di04;
        public string do01;
        public string do02;

    }
}

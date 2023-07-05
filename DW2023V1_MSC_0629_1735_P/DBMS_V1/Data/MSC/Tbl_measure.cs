using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS_V1.Data.MSC
{
    public class Tbl_measure
    {
        public Tbl_measure() { }

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

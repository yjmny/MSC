using NetworkLib;
using System;
using System.Collections.Generic;
using System.Data;

namespace DBMS_V1
{
    public abstract class DbmsDTO
    {
        NetworkDTO nwdto = null;

        public DbmsDTO()
        {
            nwdto = new NetworkDTO();
        }
        /// <summary>
        /// DBMS 지정 생성
        /// None = 0,
        /// MySQL = 1,
        /// SQLite = 2,
        /// MariaDB = 3,
        /// Oracle = 4,
        /// PostgreSQL = 5,
        /// SQL_Server = 6,
        /// </summary>
        /// <param name="databaseModelNum"></param>
        public abstract void ConstructDbmsVo(int databaseModelNum);

        /// <summary>
        /// DBMS 커넥션 연결 on
        /// </summary>
        /// <returns>연결 성공(true), 실패(false)</returns>
        public abstract bool Open();
        /// <summary>
        /// DBMS 커넥션 연결 off
        /// </summary>
        /// <returns>연결 성공(true), 실패(false)</returns>
        public abstract bool Close();
        /// <summary>
        /// Sql 쿼리 전송
        /// </summary>
        /// <param name="strParse">INSERT,DELETE, UPDATE</param>
        /// <param name="strSql">sql query</param>
        public abstract bool RunSql(string strParse, string strSql);
        /// <summary>
        /// db read 
        /// </summary>
        /// <param name="strSql">sql query</param>
        /// <returns>string 인자</returns>
        public abstract String SelectSql(string strSql, params string[] strParams);

        /// <summary>
        /// db read
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="strParams"></param>
        /// <returns></returns>
        public abstract List<Dictionary<string, string>> SelectSql2(string strSql, params string[] strParams);

        /// <summary>
        /// 테이블 전체 조회
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public abstract List<Dictionary<string, string>> SelectAll(string strSql);
        /// <summary>
        /// DB data를 DataSet에 바인딩
        /// </summary>
        /// <param name="strSql">sql query</param>
        /// <param name="srcTable">데이터바인딩될 title name을 지정</param>
        /// <returns>dataset - data list</returns>
        public abstract DataSet SelectSqlToDataSet(string strSql, string srcTable);
        /// <summary>
        /// DB data를 DataSet에 바인딩
        /// </summary>
        /// <param name="strSql">sql query</param>
        /// <returns>dataset -  data list</returns>
        public abstract DataSet SelectSqlToDataSet2(string strSql);
        /// <summary>
        ///  DB data를 DataTable 바인딩
        /// </summary>
        /// <param name="strSql">sql query</param>
        /// <returns>datatable - data list</returns>
        public abstract DataTable SelectSqlToDataTable(string strSql);

        /// <summary>
        ///  DB data를 DataTable 바인딩
        /// </summary>
        /// <param name="strSql">sql query</param>
        /// <param name="srcTablel">binding table name</param>
        /// <returns>datatable - data list</returns>
        public abstract DataTable SelectSqlToDataTable(string strSql, string srcTablel);

    }
}

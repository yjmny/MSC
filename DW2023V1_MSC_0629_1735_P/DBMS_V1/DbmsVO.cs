namespace DBMS_V1
{
    public class DbmsVO
    {

        public DbmsVO(string dbmsModelName = "", string serverIp = "",
            int serverPort = 3306, string dbName = "dw_schema",
            string accountId = "", string accountPwd = "")
        {
            m_strDbModelName = dbmsModelName;
            m_strServerIp = serverIp;
            m_iServerPort = serverPort;
            m_strDbName = dbName;
            m_strAccountId = accountId;
            m_strAccountPwd = accountPwd;
        }

        public enum DatabaseModel
        {
            None = 0,
            MySQL = 1,
            SQLite = 2,
            MariaDB = 3,
            Oracle = 4,
            PostgreSQL = 5,
            SQL_Server = 6,
        }

        public string m_strServerIp = "";
        public int m_iServerPort = 3306;
        public string m_strDbModelName = "";//mysql, oracle, postgresql
        public string m_strDbName = "dw_schema";
        public string m_strAccountId = "";//연결 계정
        public string m_strAccountPwd = "";//연결 Pwd

        

    }
}

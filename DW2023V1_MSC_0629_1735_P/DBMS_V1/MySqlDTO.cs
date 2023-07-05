using System;
using System.Collections.Generic;

#region DBMS-Mysql
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using DwLib.Data.Generic;

#endregion

namespace DBMS_V1
{
    public class MySqlDTO : DbmsDTO
    {

        public MySqlDTO()
        {
            ConstructDbmsVo((int)DbmsVO.DatabaseModel.MySQL);
        }

        DbmsVO dbvo = null;
        string m_strConnFormat = "";


        MySqlConnection conn = null;

        public void MessageBoxErrorShow(string title, string content)
        {
            MessageBox.Show(content, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public override void ConstructDbmsVo(int databaseModelNum)
        {
            switch (databaseModelNum)
            {
                case 1:
                    string dbmsModelName = DbmsVO.DatabaseModel.MySQL.ToString();
                    string serverIp = "127.0.0.1";
                    //string serverIp = "192.168.0.100";
                    //string serverIp = "192.168.70.11";
                    int serverPort = 3306;
                    CommonClass.dbip = serverIp;
                    CommonClass.dbport = serverPort.ToString();
                    string dbName = "dwsmartictdb_msc";
                    string accountId = "dwsmartict";
                    string accountPwd = "P@ssw0rd!@#$";

                    dbvo = new DbmsVO(dbmsModelName, serverIp,
                   serverPort, dbName,
                   accountId, accountPwd);

                    m_strConnFormat = String.Format("SERVER = {0};Port={1}; DATABASE = {2}; UID = {3}; PASSWORD = {4};Allow User Variables=True;Charset=utf8;",
                 dbvo.m_strServerIp, dbvo.m_iServerPort, dbvo.m_strDbName, dbvo.m_strAccountId, dbvo.m_strAccountPwd);
                    conn = new MySqlConnection(m_strConnFormat);
                    break;
            }

        }

        public override bool RunSql(string strParse, string strSql)
        {
            bool isRtn = false;
            switch (strParse)
            {
                case "INSERT": isRtn = Insert(strSql); break;
                case "DELETE": isRtn = Delete(strSql); break;
                case "UPDATE": isRtn = Update(strSql); break;
                case "INSERT_OR_UPDATE": isRtn = Update(strSql); break;
                case "SELECT": break;
            }
            return isRtn;
        }

        public override string SelectSql(string strSql, params string[] strParams)
        {
            string strRetrun = "";
            //int iParamLength = strParams.Length;
            using (MySqlCommand cmd = new MySqlCommand(strSql, conn))
            {
                using (conn)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        OpenKeepUp();
                    }
                    MySqlDataReader msdr = cmd.ExecuteReader();
                    while (msdr.Read())
                    {
                        string tempStr = "";
                        foreach (string str in strParams)
                        {
                            tempStr = tempStr + msdr[str] + "|";
                        }
                        strRetrun += string.Format("{0}", tempStr) + "\n";
                    }
                }
            }
            return strRetrun;
        }

        /// <summary>
        /// select 구문 실행 
        /// 하나의 행의 데이터들을 딕셔너리 데이터로 담고 리스트로 행들을 리스트로 구성하여 반환
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="strParams"></param>
        /// <returns></returns>
        public override List<Dictionary<string, string>> SelectSql2(string strSql, params string[] strParams)
        {
            List<Dictionary<string, string>> dicReturn = new List<Dictionary<string, string>>();

            try
            {
                using (conn)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    MySqlCommand cmd = new MySqlCommand(strSql, conn);

                    MySqlDataReader msdr = cmd.ExecuteReader();
                    while (msdr.Read())
                    {
                        Dictionary<string, string> temp = new Dictionary<string, string>();
                        foreach (string str in strParams)
                        {
                            temp.Add(str, Convert.ToString(msdr[str]));
                        }
                        dicReturn.Add(temp);
                    }

                }
            }
            catch (Exception exc)
            {
                MessageBoxErrorShow("DB Select", exc.Message);
                dicReturn = null;
            }


            return dicReturn;
        }

        /// <summary>
        /// select 문에서 전체 행을 가져옴
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public override List<Dictionary<string, string>> SelectAll(string strSql)
        {
            List<Dictionary<string, string>> dicReturn = new List<Dictionary<string, string>>();

            try
            {
                using (conn)
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        OpenKeepUp();
                    }

                    MySqlCommand cmd = new MySqlCommand(strSql, conn);

                    MySqlDataReader msdr = cmd.ExecuteReader();
                    while (msdr.Read())
                    {
                        Dictionary<string, string> temp = new Dictionary<string, string>();
                        for (int i = 0; i < msdr.FieldCount; i++)
                        {
                            temp.Add(msdr.GetName(i), Convert.ToString(msdr[i]));
                        }
                        dicReturn.Add(temp);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBoxErrorShow("DB Select", exc.Message);
                throw exc;
            }


            return dicReturn;
        }

        /// <summary>
        /// DataSet에 바인딩 
        /// </summary>
        /// <param name="strSql">Query</param>
        /// <param name="srcTable">바이딩할 테이블명</param>
        /// <returns></returns>
        public override DataSet SelectSqlToDataSet(string strSql, string srcTable)
        {
            DataSet dsRtn = new DataSet();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(strSql, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dsRtn, srcTable);
                }
            }
            catch (Exception exc)
            {
                MessageBoxErrorShow("DB Read", exc.Message);
                throw exc;
            }

            return dsRtn;
        }
        /// <summary>
        /// DataSet에 바인딩2 
        /// </summary>
        /// <param name="strSql">Query</param>
        /// <param name="srcTable">바이딩할 테이블명</param>
        /// <returns></returns>
        public override DataSet SelectSqlToDataSet2(string strSql)
        {
            DataSet dsRtn = new DataSet();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(strSql, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dsRtn);
                }
            }
            catch (Exception exc)
            {
                MessageBoxErrorShow("DB Read", exc.Message);
            }

            return dsRtn;
        }

        /// <summary>
        /// DataTable에 바인딩
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public override DataTable SelectSqlToDataTable(string strSql)
        {
            DataTable dtRtn = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(strSql, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtRtn);
                }
            }
            catch (Exception exc)
            {
                MessageBoxErrorShow("DB Read", exc.Message);
            }

            return dtRtn;
        }
        /// <summary>
        /// DataTable에 바인딩
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public override DataTable SelectSqlToDataTable(string strSql, string srcTablel)
        {
            DataTable dtRtn = new DataTable();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(strSql, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dtRtn);
                }
            }
            catch (Exception exc)
            {
                MessageBoxErrorShow("DB Read", exc.Message);
            }

            return dtRtn;
        }


        private bool Update(string strSql)
        {
            bool isRtn;
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    OpenKeepUp();
                }
                using (MySqlCommand cmd = new MySqlCommand(strSql, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                isRtn = true;
            }
            catch (Exception exc)
            {
                throw exc;
            }

            return isRtn;
        }

        private bool Delete(string strSql)
        {
            bool isRtn;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(strSql, conn))
                {
                    cmd.ExecuteNonQuery();

                }
                isRtn = true;
            }
            catch (Exception exc)
            {
                throw exc;
            }

            return isRtn;
        }

        private bool Insert(string strSql)
        {
            bool isRtn;
            using (MySqlCommand cmd = new MySqlCommand(strSql, conn))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    isRtn = true;
                }
                catch (Exception e)
                {
                    isRtn = false;
                    MessageBox.Show(e.Message);
                    System.Diagnostics.Debug.WriteLine(e);
                    throw e;
                }
            }

            return isRtn;
        }

        public override bool Open()
        {
            bool isOpen = false;

            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    isOpen = true;
                }
                else
                {
                    isOpen = false;
                }
            }
            catch (Exception exc)
            {
                conn.Close();
                isOpen = false;
                MessageBoxErrorShow("DB Error", exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return isOpen;
        }

        public bool IsOpened()
        {
            bool isOpened = false;
            if (conn.State == ConnectionState.Open)
            {
                isOpened = true;
            }
            else if (conn.State == ConnectionState.Closed)
            {
                isOpened = false;
            }
            return isOpened;
        }
        public bool OpenKeepUp()
        {
            bool isOpen;
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                if (conn.State == ConnectionState.Open) { isOpen = true; }
                else { isOpen = false; }
            }
            catch (Exception exc)
            {
                conn.Close();
                isOpen = false;
                MessageBoxErrorShow("DB Error", exc.Message);
            }
            finally
            {

            }
            return isOpen;
        }

        public bool Close(MySqlDTO mysqlDto)
        {
            bool isClose;
            if (mysqlDto == null)
            {
                isClose = false;
                return isClose;
            }
            else
            {
                isClose = Close();
                return isClose;
            }
        }
        public override bool Close()
        {
            bool isClose;
            try
            {
                conn.Close();
                if (conn.State == ConnectionState.Closed)
                {
                    isClose = true;
                }
                else
                {
                    isClose = false;
                }
            }
            catch (Exception exc)
            {
                isClose = false;
                MessageBoxErrorShow("DB Error", exc.Message);
            }
            finally
            {
                //conn.Close();
            }
            return isClose;

        }


    }
}

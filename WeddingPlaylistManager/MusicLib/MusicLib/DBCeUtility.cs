using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace MusicLib
{
    class DBCeUtility
    {

        private SqlCeConnection _DBConn;
        private String _SqlCeConnString;
        //Note: SQL Compact does not support stored procedures.
        //Note: This is a simple program. We will ignore SQL injection prevention.

        public DBCeUtility(String pSqlCeConnectionString)
        {
            _SqlCeConnString = pSqlCeConnectionString;
            OpenCeDBConnection();
        }//Constructor

        ~DBCeUtility()
        {
            _DBConn.Close();
        }//Destructor

        private void OpenCeDBConnection()
        {
            _DBConn = new SqlCeConnection(_SqlCeConnString);
            _DBConn.Open();
        }//openCeDBConnection

        private void CloseCeDBConnection()
        {
            _DBConn.Close();
        }//CloseCeDBConnection

        public void ExecuteNonQuerySQL(String pSQL)
        {
            //Best Practices is to keep the DB connection short, rather than keep the DB connection persistent.
            //OpenCeDBConnection();
            GetSqlCeCommand(pSQL).ExecuteNonQuery();
            //CloseCeDBConnection();
        }//ExecuteNonQuerySQL

        public SqlCeResultSet ExecuteQuerySQL(String pSQL)
        {
            //Best Practices is to keep the DB connection short, rather than keep the DB connection persistent.
            //OpenCeDBConnection();
            SqlCeResultSet rs = GetSqlCeCommand(pSQL).ExecuteResultSet(ResultSetOptions.Scrollable);
            //CloseCeDBConnection();
            return rs;
        }//ExecuteQuerySQL


        #region Misc Helper Functions

        public SqlCeCommand GetSqlCeCommand(String pSQL)
        {
            SqlCeCommand cmd = new SqlCeCommand();
            cmd.Connection = _DBConn;
            cmd.CommandText = pSQL;
            return cmd;
        }//GetSqlCeCommand

        public String SantizeForSQL(String pSqlElement)
        {
            //Check for single quotes in the Sql Element. This will cause an error if left alone. Place double single quotes to resolve this in SQL.
            pSqlElement = pSqlElement.Replace("'", "''");

            return pSqlElement;
        }//SanitizeForSQL

#endregion

    }
}

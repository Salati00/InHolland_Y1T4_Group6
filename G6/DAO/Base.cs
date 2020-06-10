using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAO
{
    public abstract class Base
    {
        private SqlDataAdapter adapter;
        protected SqlConnection conn;
        public Base()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbchapeau06"].ConnectionString);
            adapter = new SqlDataAdapter();
        }

        protected SqlConnection OpenConnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbchapeau06"].ConnectionString);
            adapter = new SqlDataAdapter();
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        private void CloseConnection()
        {
            conn.Close();
        }

        /* For Insert/Update/Delete Queries with transaction */
        protected void ExecuteEditTranQuery(String query, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction)
        {
            SqlCommand command = new SqlCommand(query, conn, sqlTransaction);
            try
            {
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* For Insert/Update/Delete Queries */
        protected void ExecuteEditQuery(String query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }



        /* For Select Queries */
        protected DataTable ExecuteSelectQuery(String query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            DataTable dataTable;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                dataTable = dataSet.Tables[0];
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }

        /*For queries that only return ONE object*/
        protected Object ExecuteScalarQuery(String query, params SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            Object Target;
            DataSet dataSet = new DataSet();

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                Target = command.ExecuteScalar();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return Target;
        }
    }
}

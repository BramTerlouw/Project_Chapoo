using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAL_Chapoo
{
    public abstract class Base
    {
        private SqlDataAdapter adapter;
        private SqlConnection conn;
        public Base()
        {
            // DO NOT FORGET TO INSERT YOUR CONNECTION STRING NAMED 'SOMEREN DATABASE' IN YOUR APP.CONFIG!!

            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ProjectChapoo"].ConnectionString);
            adapter = new SqlDataAdapter();

        }

        protected SqlConnection OpenConnection()
        {
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
        protected void ExecuteEditTranQuery(string query, SqlParameter[] sqlParameters, SqlTransaction sqlTransaction)
        {
            SqlCommand command = new SqlCommand(query, conn, sqlTransaction);
            try
            {
                command.Parameters.AddRange(sqlParameters);
                adapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.Write(e);
                throw;
            }
        }

        /* For Insert/Update/Delete Queries */
        protected void ExecuteEditQuery(string query, SqlParameter[] sqlParameters)
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
            catch (SqlException e)
            {
                Console.Write(e);
                throw new Exception(e.ToString());
            }
            finally
            {
                CloseConnection();
            }
        }



        /* For Select Queries */
        protected DataTable ExecuteSelectQuery(string query, params SqlParameter[] sqlParameters)
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
            catch (SqlException e)
            {
                Console.Write(e);
                return null;
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }





        protected int ExecuteCount(string query, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            int value = 0;

            try
            {
                command.Connection = OpenConnection();
                command.CommandText = query;
                command.Parameters.AddRange(sqlParameters);
                value = (int)command.ExecuteScalar(); // get and cast
            }
            catch (Exception)
            {
                throw new Exception("Querie did not succeed!"); // or throw exception, program keeps running
            }
            finally
            {
                CloseConnection(); // close connection
            }
            return value; // return the value
        }
    }
}

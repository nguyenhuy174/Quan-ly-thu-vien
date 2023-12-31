﻿    using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.Models
{
    class Connection
    {
        public static string connStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLTV;Integrated Security=True";
        public static SqlConnection Getconnection()
        {
            SqlConnection con = new SqlConnection(connStr);
            return con;
        }
        public static void open()
        {
            try
            {
                if (Getconnection().State == ConnectionState.Closed)
                    Getconnection().Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        public static void close()
        {
            try
            {
                if (Getconnection().State == ConnectionState.Open)
                    Getconnection().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static DataTable getData(string strQuery, CommandType cmdtype)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection();
                con = Getconnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdtype;
                cmd.Connection = con;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return ds.Tables[0];
        }
        public static DataTable getData(string strQuery,CommandType cmdtype,string[] paras,object[] values)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection();
                con = Getconnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdtype;
                cmd.Connection = con;
                SqlParameter sqlpara;
                for (int i = 0; i < paras.Length; i++)
                {
                    sqlpara = new SqlParameter();
                    sqlpara.ParameterName = paras[i];
                    sqlpara.SqlValue = values[i];
                    cmd.Parameters.Add(sqlpara);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return ds.Tables[0];
        }
        public static int ExcuteQuery(string query, CommandType cmdtype, string[] paras, object[] values)
        {
            SqlConnection conn = new SqlConnection();
            conn = Getconnection();
            conn.Open();
            int efftectRecord = 0;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandText = query;
            sqlcmd.Connection = conn;
            sqlcmd.CommandType = cmdtype;

            SqlParameter sqlpara;
            for (int i = 0; i < paras.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = paras[i];
                sqlpara.SqlValue = values[i];
                sqlcmd.Parameters.Add(sqlpara);
            }
            try
            {
                efftectRecord = sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            return efftectRecord;
        }
        public static DataTable SeachInDataBase(string query)
        {
            DataTable data = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    connection.Open();

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(data);
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erorr");
            }
            return data;
        }
        public DataSet getDataSet(string query)
        {
            DataTable temp = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(temp);
                    connection.Close();

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erroorrr", "Erroorrr");
            }
            finally
            {

            }
            DataSet dataM = new DataSet();
            dataM.Tables.Add(temp);
            return dataM;
        }
    }
}

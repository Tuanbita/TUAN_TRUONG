using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Data.SqlClient;
namespace DAL
{
    public class KetNoi
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;

        public void OpenConn()
        {
            if (conn == null)
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-UDEEE13\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
            }
            if (conn.State != ConnectionState.Open) conn.Open();
        }

        public void CloseConn()
        {
            if (conn != null) conn.Close();
        }

        public int thucthilenh(string sql)//Chỉ thực hiện câu lệnh Insert, update,Delete
        {
            try
            {
                OpenConn();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                CloseConn();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public object laygiatridon(string sql)
        {
            try
            {
                OpenConn();
                object result = -1;
                cmd = new SqlCommand(sql,conn);
                result = cmd.ExecuteScalar();
                CloseConn();
                return result;

            }catch(Exception ex)
            {
                return -1;
            }
        }
        public DataTable taobang(string sql)
        {
            try
            {
                OpenConn();
                SqlDataAdapter adap = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                CloseConn();
                return dt;
            }
            catch(Exception ex)
            {
                return null;
            }
        }


    }
}

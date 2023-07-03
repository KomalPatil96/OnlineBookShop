using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace OnlineBookShop.Models
{
    public class Functions
    {
        private SqlConnection Con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string Constr;
        public Functions()
        {
            Constr = "Data Source=KOMAL;Initial Catalog=onlineshop;Integrated Security=True";
            Con = new SqlConnection(Constr);
            cmd = new SqlCommand();
            cmd.Connection = Con;
        }

        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, Constr);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(string Query)
        {
            int cnt = 0;
            if(Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            cmd.CommandText = Query;
            cnt = cmd.ExecuteNonQuery();
            Con.Close();
            return cnt;
        }
    }
}
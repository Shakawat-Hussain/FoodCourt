using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourt
{
    class Entri
    {
        SqlConnection con;
        SqlCommand com;
        public Entri()
        {
            this.con = new SqlConnection(ConfigurationManager.ConnectionStrings["Food"].ConnectionString);
        }
        public void Connection()
        {
            this.con.Open();
        }
        public void Execute(string sql)
        {
            this.com = new SqlCommand(sql,this.con);
            com.ExecuteNonQuery();
        }
        public SqlDataReader Reecive(string sql)
        {
            Connection();
            this.com=new SqlCommand(sql,this.con);
            SqlDataReader reader = this.com.ExecuteReader();
            return reader;
        }
        public void Cclose()
        {
            this.con.Close();
        }
    }
}

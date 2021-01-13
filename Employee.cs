using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourt
{
    class Employee
    {
        Entri e;
        public Employee()
        {
            this.e = new Entri();
        }
        public string Name
        { get; set; }

        public int Empid
        { get; set; }

        public double Salary
        { get; set; }
       /* public List<string> Employees(string sql)
        {
            SqlDataReader reader = this.e.Reecive(sql);
            List<string> Emps = new List<string>();
            while (reader.Read())
            {
                Employee em = new Employee();
                em.Name = reader["Name"].ToString();
                em.Empid = (int)reader["Empid"];
                em.Salary = (double)reader["Salary"];
                Emps.Add(em.Name);
                Emps.Add(em.Empid.ToString());
                Emps.Add(em.Empid.ToString());


            }
            reader.Close();
            return Emps;

        }
        public List<string> Emplist(string sql)
        {
            return Employees(sql);
        }*/
       public void Emplist(string sql)
        {
            SqlDataReader reader = this.e.Reecive(sql);
            while (reader.Read())
            {
                Console.WriteLine(reader["Name"].ToString());
                Console.WriteLine((int)reader["Empid"]);

                Console.WriteLine((double)reader["Salary"]);
            }
            //return reader;
            reader.Close();
        }
    }
}

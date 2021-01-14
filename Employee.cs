using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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

        public  Object Add()
        {
            Employee e = new Employee();
            Console.WriteLine("Enter Name: ");
            e.Name = Console.ReadLine();
            Console.WriteLine("Enter Id: ");
            e.Empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Salary: ");
           e.Salary= Convert.ToDouble(Console.ReadLine());

            Filex();
            string Filename = @"C:\Users\Public\Documents\"+e.Empid+".txt";
          
         
            string Likho = "" + e.Name + "------" + e.Empid + "-----" + e.Salary + "-------";
            File.WriteAllText(Filename, Likho);
            return e;
           
        }
       
        
        
        
        
        
        public void ReadAll()
        {
            string path = "C:\\Users\\Public\\Documents";
            var files = Directory.GetFiles(path, "*.txt");
            List<Employee> list = new List<Employee>();
            string[] text;
            foreach (var item in files)
            {
                text = File.ReadAllLines(item);
                
                 list.Add(new Employee { Name = text[1], Empid = Convert.ToInt32(text[2]), Salary = Convert.ToDouble(text[3]) });
                
            }

            foreach (var item in list)
            {
                text = new string[] { item.Name, item.Empid.ToString(), item.Salary.ToString() };
                string result = string.Join(",", text) + Environment.NewLine;
                File.AppendAllText("C:\\Users\\Public\\Documents\\total.txt", result);
            }
        }
        
        
        
        
        
        public void Filex()
        {
            Employee e = new Employee();

            string Filename = @"C:\Users\Public\Documents\"+e.Empid+".txt";
            if (File.Exists(Filename))
            {
                Console.WriteLine();
            }
            else
            {
                File.Create(Filename);
            }


        }

    }
}

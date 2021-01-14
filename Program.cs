using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourt
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Entri ent = new Entri();
            Employee em = new Employee();
            bool repeat = true;
           
                while (repeat)
            {
                try { 
                    Console.WriteLine("1. Employee Management");
                    Console.WriteLine("2. Restaurant Management");
                    Console.WriteLine("3. Restaurant FoodItem Management");
                    Console.WriteLine("4. FoodItem Quantity Add-Sell");
                    Console.WriteLine("5. eXIT");


                    Console.WriteLine("Enter Option");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("1.Insert New Employee");
                            Console.WriteLine("2. Remove Existing Employee");
                            Console.WriteLine("3. Show All Employees");
                            Console.WriteLine("4. Search an Employee");
                            Console.WriteLine("5.  Go back");

                            Console.WriteLine("Enter Option");
                            int chose = Convert.ToInt32(Console.ReadLine());
                            switch (chose)
                            {
                                case 1:
                                    try
                                    {
                                        /* Console.WriteLine("You chose to Insert new Employee");
                                         Console.WriteLine("Enter Name: ");
                                         string name = Console.ReadLine();
                                         Console.WriteLine("Enter Id: ");
                                         int Id = Convert.ToInt32(Console.ReadLine());
                                         Console.WriteLine("Enter Salary: ");
                                         double salary = Convert.ToDouble(Console.ReadLine());

                                         ent.Connection();
                                         ent.Execute("Insert Into Employee(Name,Empid,Salary) Values('" + name + "','" + Id + "','" + salary + "')");
                                         ent.Cclose();*/

                                        em.Filex();
                                        //string Path = @"C:\Users\Public\Documents\Employee.txt";
                                        em.Add();
                                       
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    break;
                                case 2:

                                    Console.WriteLine("You chose to remove an employee");
                                    try
                                    {
                                        Console.WriteLine("Enter Id: ");
                                        int Eid = Convert.ToInt32(Console.ReadLine());
                                        ent.Connection();
                                        ent.Execute("Delete from Employee where Empid='" + Eid + "'");
                                        ent.Cclose();
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("You chose to see All employees");


                                    /*  em.Emplist("Select * from Employee");
                                      ent.Cclose();*/





                                    em.ReadAll();

                                    
                                    
                                    
                                  /*  string Empid = Console.ReadLine();
                                    TextReader tr = new StreamReader(@"C:\Users\Public\Documents\"+Empid+".txt");
                                    Console.WriteLine(tr.ReadLine());
                                    tr.Close();*/

                                    break;
                                case 4:
                                    Console.WriteLine("You chose to search an employee ");
                                    Console.WriteLine("Enter Id: ");

                                    int Sid = Convert.ToInt32(Console.ReadLine());

                                    em.Emplist("Select * from Employee where Empid='" + Sid + "'");
                                    ent.Cclose();

                                    break;
                                case 5:
                                    Console.WriteLine("You chose to Go back");
                                    // repeat = false;
                                    break;
                                default:
                                    Console.WriteLine("Invalid choice");
                                    break;
                            }




                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            Console.WriteLine("You chose to Exit");
                            repeat = false;

                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;

                    }
                }
                catch (Exception ex)
                {
                   
                    Console.WriteLine(""+ex.Message+"-----At least select an option idiot");
                }
            }
        }
    }
}

using EmoplyeesApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MovieApp.Models;
using System;
using System.Linq;

namespace EmoplyeesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new EFContext();
            var empList = db.Employees;

            // Query 2 -------------------------
            foreach(var emp in empList)
            {
                Console.WriteLine("Emp_ID : "+emp.Employee_Id+" First_Name : "+emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }


            //Query 3 -----------------------------
            foreach (var emp in empList)
            {
                Console.WriteLine(" First_Name : " + emp.First_Name + " | Last_Name : " + emp.Last_Name );
            }


            //Query 4 -----------------------------
            using (var db1=new EFContext())
            {
                var list = db1.Employees.FromSqlRaw("select * from Employees").ToList();
                foreach (var emp in list)
                {
                    Console.WriteLine(emp);
                }
            }

            //Query 5 ----------------------------------
            foreach (var emp in empList)
            {
                Console.WriteLine(" First_Name : " + emp.First_Name.ToUpper() );
            }

            //Query 6 ---------------------------------
            foreach (var emp in empList)
            {
                Console.WriteLine(" First_Name : " + emp.First_Name.ToLower());
            }

            //Query 7 ---------------------------------

            var depList = empList.Select(t => t.Department).Distinct().ToList();
            foreach (var dep in depList)
            {
                Console.WriteLine(dep);
            }


            //Query 8 ---------------------------------
            foreach (var emp in empList)
            {
                string temp = emp.First_Name.Substring(0, 3);
                Console.WriteLine(" First_Name : " + temp);
            }

            //Query 9 -----------------------------------

            int pos = db.Employees.Where(t => t.First_Name == "John").Single().ToString().IndexOf('o');
            Console.WriteLine(pos);


            //query 10 ----------------------------------
            foreach (var emp in empList)
            {
                Console.WriteLine(" First_Name : " + emp.First_Name.TrimEnd());
            }

            //query 11 ----------------------------------
            foreach (var emp in empList)
            {
                Console.WriteLine(" First_Name : " + emp.First_Name.TrimStart());
            }

            //query 12 ----------------------------------
            foreach (var emp in empList)
            {
                Console.WriteLine(" First_Name length : " + emp.First_Name.Length);
            }

            //query 13 ----------------------------------
            foreach (var emp in empList)
            {
                Console.WriteLine(" First_Name : " + emp.First_Name.Replace('o','$'));
            }

            //Query 14 ---------------------------------
            foreach (var emp in empList)
            {
                Console.WriteLine(" Full_Name : " + string.Join('_',emp.First_Name,emp.Last_Name));
            }

            //Query 15 -------------------------------------
            
            foreach (var emp in empList)
            {
                Console.WriteLine(" First_Name : " + emp.First_Name+" Joining year : "+emp.Joining_Date.Year+ " Joining month : " + emp.Joining_Date.Month + " Joining day : " + emp.Joining_Date.Day );
            }

            //Query 16 ------------------------------------
            var listOrder = db.Employees.OrderBy(t=>t.First_Name);
            foreach (var emp in listOrder)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 17 ----------------------------------------
            var listOrderDesc = db.Employees.OrderByDescending(t => t.First_Name);
            foreach (var emp in listOrderDesc)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 18 ----------------------------------------
            listOrder = db.Employees.OrderBy(t => t.First_Name).OrderByDescending(t=>t.Salary);
            foreach (var emp in listOrder)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 20 ---------------------------------------------
            var list20 = db.Employees.Where(t=>t.First_Name=="John" || t.First_Name=="Roy");
            foreach (var emp in list20)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 21 ---------------------------------------------
            var list21 = db.Employees.Where(t => t.First_Name != "John" || t.First_Name != "Roy");
            foreach (var emp in list21)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 22 ---------------------------------------------
            var list22 = db.Employees.Where(t => t.First_Name.StartsWith("J"));
            foreach (var emp in list22)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 23 ---------------------------------------------
            var list23 = db.Employees.Where(t => t.First_Name.Contains("o"));
            foreach (var emp in list23)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 24 ---------------------------------------------
            var list24 = db.Employees.Where(t => t.First_Name.EndsWith("n"));
            foreach (var emp in list24)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 25 ---------------------------------------------
            var list25 = db.Employees.Where(t => t.First_Name.EndsWith("n") && t.First_Name.Length==4);
            foreach (var emp in list25)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 26 ---------------------------------------------
            var list26 = db.Employees.Where(t => t.First_Name.StartsWith("j") && t.First_Name.Length == 4);
            foreach (var emp in list26)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 27 ---------------------------------------------
            var list27 = db.Employees.Where(t => t.Salary>600000);
            foreach (var emp in list27)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 28 ---------------------------------------------
            var list28 = db.Employees.Where(t => t.Salary < 800000);
            foreach (var emp in list28)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 29 ---------------------------------------------
            var list29 = db.Employees.Where(t => t.Salary >500000 && t.Salary<800000);
            foreach (var emp in list29)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }


            //Query 30 ---------------------------------------------
            var list30 = db.Employees.Where(t => t.First_Name == "John" || t.First_Name == "Micheal");
            foreach (var emp in list30)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 31 ---------------------------------------------
            var list31 = db.Employees.Where(t => t.Joining_Date.Year==2013);
            foreach (var emp in list31)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 32 ---------------------------------------------
            var list32 = db.Employees.Where(t => t.Joining_Date.Month == 01);
            foreach (var emp in list32)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }

            //Query 33 ---------------------------------------------
            /*var list33 = db.Employees.Where(t => t.Joining_Date.Date.ToString() < "2013-01-31");
            foreach (var emp in list33)
            {
                Console.WriteLine("Emp_ID : " + emp.Employee_Id + " First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name + " Salary : " + emp.Salary + " Joining_Date : " + emp.Joining_Date + " Department : " + emp.Department);
            }*/


            //Query 35,36 ------------------------------------------
            
            foreach (var emp in list32)
            {
                Console.WriteLine(" Joining_Date : " + emp.Joining_Date );
            }

            //Query 39 -------------------------------------------------

            var list39 = db.Employees.Where(t => t.Last_Name.Contains("/%"));
            foreach (var emp in list39)
            {
                Console.WriteLine(" First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name  );
            }

            //Query 40 -------------------------------------------------

            foreach (var emp in empList)
            {
                Console.WriteLine(" First_Name : " + emp.First_Name + " Last_Name : " + emp.Last_Name.Replace("%"," "));
            }


        }
    }
}

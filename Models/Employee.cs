using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EmoplyeesApp.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Employee_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Salary { get; set; }
        public DateTime Joining_Date { get; set; }
        public string Department { get; set; }

        public Employee()
        {

        }
        public Employee(int i,string fn,string ln,int s,DateTime jd,string d)
        {
            this.Employee_Id = i;
            this.First_Name = fn;
            this.Last_Name = ln;
            this.Salary = s;
            this.Joining_Date = jd;
            this.Department = d;
        }

    }
}

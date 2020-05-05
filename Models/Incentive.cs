using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EmoplyeesApp.Models
{
   
    public class Incentive
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Incentive_Id { get; set; }
        [ForeignKey(nameof(Employee))]
        public int Employee_Ref_Id { get; set; }
        public DateTime Incentive_Date { get; set; }
        public int Incentive_Amount { get; set; }
        public Incentive()
        {

        }
        public Incentive(int i,DateTime d,int a)
        {
            this.Employee_Ref_Id = i;
            this.Incentive_Date = d;
            this.Incentive_Amount = a;
        }
    }
}

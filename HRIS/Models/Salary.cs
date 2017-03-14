using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Models
{
    public class Salary
    {
        public int id { get; set; }
        public Employee Employee { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string SalaryRate { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> DateEnteredHRIS { get; set; }
    }
}

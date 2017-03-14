using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Models
{
    public class EmployeeType
    {
        public int id { get; set; }
        public Employee Employee { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string HoursPerWeek { get; set; }
        public string DaysPerWeek { get; set; }
        public string Title { get; set; }
        public Employee Supervisor { get; set; }
        public Office Office { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> DateEnteredHRIS { get; set; }
    }
}

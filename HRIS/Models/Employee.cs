using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> DateEntered { get; set; }
        public string Comments { get; set; }
        public Nullable<int> isActive { get; set; }

        public IList<AddressContact> AddressContacts{ get; set; }
        public IList<Bonus> Bonuses { get; set; }
        public IList<Salary> Salaries { get; set; }
        public IList<EmployeeType> EmployeeTypes { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HR.Models;

namespace HR
{
    public class HRContext : DbContext
    {
        //Definition od Database Tables
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Termination> Terminations { get; set; }
        public DbSet<AddressContact> AddressContacts { get; set; }
        public DbSet<Bonus> Bonuses { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Salary> Salaries { get; set; }

        /*****************************/

        public DbSet<TerminationReason> TerminationReasons { get; set; }
        public DbSet<TerminationType> TerminationTypes { get; set; }
        public DbSet<Office> Offices { get; set; }

        public HRContext() : base("name=DefaultConnection")
        { }
    }
}

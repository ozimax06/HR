using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HRIS
{



    public class TerminationReason
    {
        public int id { get; set; }
        public string TerminationReason1 { get; set; }
    }

    public class TerminationType
    {
        public int id { get; set; }
        public string TerminationType1 { get; set; }
    }

    public class Office
    {
        public int id { get; set; }
        public string Office1 { get; set; }
    }

    /*Master Tables*/
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
    }

    public class Termination
    {
        public int id { get; set; }
        public Employee Employee { get; set; }
        public Nullable<System.DateTime> TerminationDate { get; set; }
        public Nullable<System.DateTime> LastDayOfWork { get; set; }
        public Nullable<System.DateTime> BenefitsEndDate { get; set; }
        public TerminationType TerminationType { get; set; }
        public TerminationReason TerminationReason { get; set; }
        public string NewEmployer { get; set; }
        public string ReceivedSeverance { get; set; }
        public string SeveranceTotal { get; set; }
        public Nullable<System.DateTime> DateEnteredHRIS { get; set; }
        public string Comments { get; set; }

    }

    public class AddressContact
    {   
        public int id { get; set; }
        public Employee Employee { get; set; }
        public string StreetAddress { get; set; }
        public string ApartmentUnit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> DateEntered { get; set; }
    }

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

    public class Bonus
    {
        public int id { get; set; }
        public Employee Employee { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<short> CurrencyID { get; set; }
        public string BonusAmount { get; set; }
        public string OfficeID { get; set; }
        public Nullable<System.DateTime> DateEnteredHRIS { get; set; }
    }

    public class Salary
    {
        public int id { get; set; }
        public Employee Employee { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string CurrencyID { get; set; }
        public string SalaryRate { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> DateEnteredHRIS { get; set; }
    }

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
        {}

        class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

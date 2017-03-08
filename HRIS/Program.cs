using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS
{

    public class SeparationReason
    {
        public int id { get; set; }
        public string SeparationReason1 { get; set; }
        public Nullable<int> IsActive { get; set; }
    }

    public class TypesOfLeave
    {
        public int id { get; set; }
        public string TypeOfLeave { get; set; }
    }

    public class PaymentScope
    {
        public int id { get; set; }
        public string PaymentScope1 { get; set; }
    }

    public class FinancialResponsibility
    {
        public int id { get; set; }
        public string FinancialResponsibility1 { get; set; }
    }

    public class TerminationReason
    {
        public int id { get; set; }
        public string TerminationReason1 { get; set; }
    }

    public class VacationWeek
    {
        public int id { get; set; }
        public string VacationWeek1 { get; set; }
        public Nullable<int> IsActive { get; set; }
    }



    public class EmployeeChangeType
    {
        public int id { get; set; }
        public string EmployeeChangeType1 { get; set; }
        public Nullable<int> IsActive { get; set; }
    }

    public class CompensationChangeType
    {
        public int id { get; set; }
        public string CompensationChangeType1 { get; set; }
        public Nullable<int> IsActive { get; set; }
    }


    public class CompensationChangeReason
    {
        public int id { get; set; }
        public string CompensationChangeReason1 { get; set; }
        public Nullable<int> IsActive { get; set; }
    }
    public class TerminationType
    {
        public int id { get; set; }
        public string TerminationType1 { get; set; }
        public Nullable<int> IsActive { get; set; }
    }

    public class AddressContactChanx
    {
        public int id { get; set; }
        public string StaffNumber { get; set; }
        public string EENumber { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string StreetAddress { get; set; }
        public string ApartmentUnit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> DateEnteredPS { get; set; }
        public Nullable<System.DateTime> DateEnteredHRIS { get; set; }
        public Nullable<int> ModifiedByPersonID { get; set; }
        public Nullable<int> IsActive { get; set; }
        public string ReceiversLastUpdate { get; set; }
    }

    public class EmployeeTypeChanx
    {
        public int id { get; set; }
        public string StaffNumber { get; set; }
        public Nullable<int> EENumber { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string EAFTicket { get; set; }
        public string ChangeType { get; set; }
        public string NewSalary { get; set; }
        public Nullable<short> CurrencyID { get; set; }
        public string NewHoursPerWeek { get; set; }
        public string NewDaysPerWeek { get; set; }
        public string NewFLSAStatus { get; set; }
        public string NewTitle { get; set; }
        public string SupervisorStaffNumber { get; set; }
        public string OfficeID { get; set; }
        public string FinancialResponsibility { get; set; }
        public string DepartmentID { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> DateEnteredHRIS { get; set; }
        public Nullable<System.DateTime> DateEnteredPS { get; set; }
        public Nullable<int> ModifiedByPersonID { get; set; }
        public Nullable<int> IsActive { get; set; }
        public string ReceiversLastUpdate { get; set; }
    }

    public class Bonus
    {
        public int id { get; set; }
        public string StaffNumber { get; set; }
        public Nullable<int> EENumber { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string BonusType { get; set; }
        public Nullable<short> CurrencyID { get; set; }
        public string BonusAmount { get; set; }
        public string GrossOrNet { get; set; }
        public string FinancialResponsibility { get; set; }
        public string FRPercentage { get; set; }
        public string OfficeID { get; set; }
        public string DepartmentID { get; set; }
        public Nullable<System.DateTime> DateEnteredHRIS { get; set; }
        public Nullable<System.DateTime> DateEnteredPS { get; set; }
        public Nullable<int> ModifiedByPersonID { get; set; }
        public Nullable<int> IsActive { get; set; }
        public string ReceiversLastUpdate { get; set; }
    }

    public class SalaryHoursChange
    {
        public int id { get; set; }
        public string StaffNumber { get; set; }
        public Nullable<int> EENumber { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string CompensationChangeType { get; set; }
        public string CompensationChangeReason { get; set; }
        public string CurrencyID { get; set; }
        public string NewSalaryRate { get; set; }
        public string PaymentScope { get; set; }
        public string EEStatus { get; set; }
        public string MinHoursPerWeek { get; set; }
        public string MinDaysPerWeek { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> DateEnteredHRIS { get; set; }
        public Nullable<System.DateTime> DateEnteredPS { get; set; }
        public Nullable<int> ModifiedByPersonID { get; set; }
        public Nullable<int> IsActive { get; set; }
        public string ReceiversLastUpdate { get; set; }
    }


    public class LOA_STD_FML_Changes
    {
        public int id { get; set; }
        public string StaffNumber { get; set; }
        public Nullable<int> EENumber { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public Nullable<System.DateTime> AnticipatedReturnDate { get; set; }
        public string TypeOfLeave { get; set; }
        public string WeeksOfLeave { get; set; }
        public string IsPaid { get; set; }
        public Nullable<System.DateTime> ActualReturnDate { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> DateEnteredHRIS { get; set; }
        public Nullable<System.DateTime> DateEnteredPS { get; set; }
        public Nullable<int> ModifiedByPersonID { get; set; }
        public Nullable<int> isActive { get; set; }
        public string ReceiversLastUpdate { get; set; }
    }

    public class SupervisorDepartmentChanx
    {
        public int id { get; set; }
        public string StaffNumber { get; set; }
        public string EENumber { get; set; }
        public Nullable<System.DateTime> EffectiveDate { get; set; }
        public string CurrentSupervisorStaffNumber { get; set; }
        public string NewSupervisorStaffNumber { get; set; }
        public string CurrentOfficeID { get; set; }
        public string NewOfficeID { get; set; }
        public Nullable<int> CurrentDepartmentID { get; set; }
        public Nullable<int> NewDepartmentID { get; set; }
        public string CurrentFinancialResponsibility { get; set; }
        public string NewFinancialResponsibility { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> DateEnteredPS { get; set; }
        public Nullable<System.DateTime> DateEnteredHRIS { get; set; }
        public Nullable<int> ModifiedByPersonID { get; set; }
        public Nullable<int> isActive { get; set; }
        public string ReceiversLastUpdate { get; set; }
    }

    public class NewHire
    {
        public int id { get; set; }
        public string EENumber { get; set; }
        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public string IsNewHire { get; set; }
        public string ExemptStatus { get; set; }
        public string IsFullTime { get; set; }
        public string IsRegular { get; set; }
        public string WeeklyHours { get; set; }
        public string PayRate { get; set; }
        public string OfficeID { get; set; }
        public string Title { get; set; }
        public string DepartmentID { get; set; }
        public string FinancialResponsibility { get; set; }
        public string SupervisorID { get; set; }
        public string CommentsInstructions { get; set; }
        public string NewHirePaperworkReceived { get; set; }
        public string RecruiterOrHRBP { get; set; }
        public string EAFTicket { get; set; }
        public Nullable<System.DateTime> DateEnteredHRIS { get; set; }
        public Nullable<System.DateTime> DateEnteredPS { get; set; }
        public Nullable<System.DateTime> DatePrintedPAR { get; set; }
        public Nullable<System.DateTime> DatePrintedTD { get; set; }
        public string EntryNotes { get; set; }
        public string StreetAddress { get; set; }
        public string ApartmentUnit { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string VacationWeeks { get; set; }
        public Nullable<int> ModifiedByPersonID { get; set; }
        public Nullable<int> isActive { get; set; }
        public string ReceiversLastUpdate { get; set; }
    }

    public class Termination
    {
        public int id { get; set; }
        public string StaffNumber { get; set; }
        public Nullable<int> EENumber { get; set; }
        public string OfficeID { get; set; }
        public Nullable<System.DateTime> TerminationDate { get; set; }
        public Nullable<System.DateTime> LastDayOfWork { get; set; }
        public Nullable<System.DateTime> BenefitsEndDate { get; set; }
        public string VacationAccrualAmount { get; set; }
        public string TerminationType { get; set; }
        public string VacationPayout { get; set; }
        public string ReasonsForLeaving { get; set; }
        public string IsWppTransfer { get; set; }
        public string NewEmployer { get; set; }
        public string ReceivedSeverance { get; set; }
        public string SeveranceTotal { get; set; }
        public string SeveranceWeeks { get; set; }
        public string SignedSeveranceAgreementUploaded { get; set; }
        public string CommentsInstructions { get; set; }
        public string EAFTicket { get; set; }
        public Nullable<System.DateTime> DateEnteredHRIS { get; set; }
        public Nullable<System.DateTime> DateEnteredPS { get; set; }
        public Nullable<int> ModifiedByPersonID { get; set; }
        public string EntryNotes { get; set; }
        public Nullable<int> IsActive { get; set; }
        public string ReceiversLastUpdate { get; set; }
    }

    public class Employee
    {
        public int id { get; set; }

        public string FirstNamePreferred { get; set; }

        public string LastNamePreferred { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OfficeID { get; set; }

        public string Title { get; set; }

        public string Password { get; set; }

        public string DepartmentID { get; set; }

        public string WorkPhone { get; set; }

        public string ActiveStatus { get; set; }

        public string EmployeeType { get; set; }

        public string FinancialResponsibility { get; set; }

        public System.Nullable<System.DateTime> BirthDate { get; set; }

        public System.Nullable<System.DateTime> LastHireDate { get; set; }

        public string CellPhone { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }

        public string HomePhone { get; set; }

        public string EmergencyName { get; set; }

        public string EmergencyPhone { get; set; }

        public string YRStaffNumber { get; set; }

        public string StaffNumberSupervisor { get; set; }

        public string Email { get; set; }

        public string UserNameTemp { get; set; }

        public string HomeFax { get; set; }

        public System.Nullable<bool> ShowHomePhone { get; set; }

        public System.Nullable<bool> ShowHomeFax { get; set; }

        public System.Nullable<bool> ShowCellPhone { get; set; }

        public string EmergencyRelationship { get; set; }

        public string FullNameCalc { get; set; }

        public string JobClassID { get; set; }

        public string SearchText { get; set; }

        public string FirstNamePreferredUnicode { get; set; }

        public string LastNamePreferredUnicode { get; set; }

        public string MiddleName { get; set; }

        public string MiddleNamePreferred { get; set; }

        public string EmailHome { get; set; }
    }

    public class HRContext : DbContext
    {
        //Definition od Database Tables
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Termination> Terminations { get; set; }
        public DbSet<AddressContactChanx> AddressContactChanges { get; set; }
        public DbSet<NewHire> NewHires { get; set; }
        public DbSet<SupervisorDepartmentChanx> SupervisorDepartmentChanges { get; set; }
        public DbSet<Bonus> Bonuses { get; set; }
        public DbSet<EmployeeTypeChanx> EmployeeTypeChanges { get; set; }

        public DbSet<LOA_STD_FML_Changes> LOA_STD_FML_Changes { get; set; }
        public DbSet<SalaryHoursChange> SalaryHoursChanges { get; set; }

        public DbSet<SeparationReason> SeparationReasons { get; set; }

        public DbSet<TypesOfLeave> TypesOfLeave { get; set; }

        public DbSet<PaymentScope> PaymentScopes { get; set; }

        public DbSet<FinancialResponsibility> FinancialResponsibilities { get; set; }

        public DbSet<TerminationReason> TerminationReasons { get; set; }

        public DbSet<VacationWeek> VacationWeeks { get; set; }

        public DbSet<EmployeeChangeType> EmployeeChangeTypes { get; set; }

        public DbSet<CompensationChangeType> CompensationChangeTypes { get; set; }

        public DbSet<CompensationChangeReason> CompensationChangeReasons { get; set; }

        public DbSet<TerminationType> TerminationTypes { get; set; }

        public HRISContext() : base("name=DefaultConnection")
        {
        }

        class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

namespace HRIS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddressContacts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        StreetAddress = c.String(),
                        ApartmentUnit = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        Country = c.String(),
                        Comments = c.String(),
                        DateEntered = c.DateTime(),
                        Employee_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Employees", t => t.Employee_id)
                .Index(t => t.Employee_id);

            //Sql("INSERT INTO  AddressContacts VALUES('abc sokagi', 'e-18', 'ankara', '01/12/2014', GetDate(), 'senior employee', 1)");

            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Salutation = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        StartDate = c.DateTime(),
                        DateEntered = c.DateTime(),
                        Comments = c.String(),
                        isActive = c.Int(),
                    })
                .PrimaryKey(t => t.id);

            Sql("INSERT INTO  Employees VALUES('Mr', 'Ozan', 'Onder', '01/12/2014', GetDate(), 'senior employee', 1)");
            Sql("INSERT INTO  Employees VALUES('Ms', 'Jannie', 'JupJup', '03/13/2012', GetDate(), 'not so good employee', 1)");
            Sql("INSERT INTO  Employees VALUES('Mr', 'Baturay', 'Ozden', '01/12/2016', GetDate(), 'added', 1)");
            Sql("INSERT INTO  Employees VALUES('Mr', 'Mike', 'Mrozo', '01/12/2014', GetDate(), 'added', 1)");
            Sql("INSERT INTO  Employees VALUES('Mr', 'Ibo', 'Muhit', '01/01/2017', GetDate(), 'added newly', 1)");
            Sql("INSERT INTO  Employees VALUES('Ms', 'Yesim', 'Onder', '01/12/2012', GetDate(), 'editted', 1)");
            Sql("INSERT INTO  Employees VALUES('Ms', 'Buket', 'Karakas', '01/12/2011', GetDate(), 'made', 1)");
            Sql("INSERT INTO  Employees VALUES('Mr', 'Marloboro', 'Light', '01/03/2017', GetDate(), 'added newly', 1)");
            Sql("INSERT INTO  Employees VALUES('Ms', 'Yeni', 'Haci', '01/05/2009', GetDate(), 'editted', 1)");
            Sql("INSERT INTO  Employees VALUES('Ms', 'Musluyma', 'Kara', '01/12/2011', '02/02/2017', 'birseyler oldu ise girdi fa;an filan etc etc ect', 1)");

            CreateTable(
                "dbo.Bonus",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        EffectiveDate = c.DateTime(),
                        BonusAmount = c.String(),
                        DateEnteredHRIS = c.DateTime(),
                        Employee_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Employees", t => t.Employee_id)
                .Index(t => t.Employee_id);

            
            /*Sql("INSERT INTO  Bonus VALUES('01/12/2011', 500, GetDate(), 1)");
            Sql("INSERT INTO  Bonus VALUES('01/12/2010', 500, GetDate(), 1)");
            Sql("INSERT INTO  Bonus VALUES('01/12/2004', 500, GetDate(), 2)");
            Sql("INSERT INTO  Bonus VALUES('01/12/2001', 7598, GetDate(), 3)");
            Sql("INSERT INTO  Bonus VALUES('01/12/1999', 23423, GetDate(), 6)");
            Sql("INSERT INTO  Bonus VALUES('01/12/2000', 20000, '02/02/2016', 8)");*/


            CreateTable(
                "dbo.EmployeeTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        EffectiveDate = c.DateTime(),
                        HoursPerWeek = c.String(),
                        DaysPerWeek = c.String(),
                        Title = c.String(),
                        Comments = c.String(),
                        DateEnteredHRIS = c.DateTime(),
                        Employee_id = c.Int(),
                        Office_id = c.Int(),
                        Supervisor_id = c.Int(),
                        Employee_id1 = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Employees", t => t.Employee_id)
                .ForeignKey("dbo.Offices", t => t.Office_id)
                .ForeignKey("dbo.Employees", t => t.Supervisor_id)
                .ForeignKey("dbo.Employees", t => t.Employee_id1)
                .Index(t => t.Employee_id)
                .Index(t => t.Office_id)
                .Index(t => t.Supervisor_id)
                .Index(t => t.Employee_id1);
            
            CreateTable(
                "dbo.Offices",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Office1 = c.String(),
                    })
                .PrimaryKey(t => t.id);

           /* Sql("INSERT INTO  Offices VALUES('Ankara')");
            Sql("INSERT INTO  Offices VALUES('Istanbul')");
            Sql("INSERT INTO  Offices VALUES('Izmir')");
            Sql("INSERT INTO  Offices VALUES('Hatay')");
            Sql("INSERT INTO  Offices VALUES('Giresun')");
            Sql("INSERT INTO  Offices VALUES('Kocaeli')");
            Sql("INSERT INTO  Offices VALUES('Trabzon')");
            Sql("INSERT INTO  Offices VALUES('Antalya')");*/

            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        EffectiveDate = c.DateTime(),
                        SalaryRate = c.String(),
                        Comments = c.String(),
                        DateEnteredHRIS = c.DateTime(),
                        Employee_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Employees", t => t.Employee_id)
                .Index(t => t.Employee_id);

            /*Sql("INSERT INTO  Salaries VALUES('02/02/2004', 4000, 'new salary', GetDate(), 1)");
            Sql("INSERT INTO  Salaries VALUES('02/02/2010', 4000, 'salary increase', GetDate(), 1)");
            Sql("INSERT INTO  Salaries VALUES('02/02/2004', 4000, 'new salary', GetDate(), 2)");
            Sql("INSERT INTO  Salaries VALUES('02/02/2004', 4000, 'new salary', GetDate(), 3)");
            Sql("INSERT INTO  Salaries VALUES('02/02/2004', 900, 'new salary', GetDate(), 4)");
            Sql("INSERT INTO  Salaries VALUES('02/02/2004', 8000, 'new salary', GetDate(), 5)");
            Sql("INSERT INTO  Salaries VALUES('02/02/2004', 7000, 'new salary', GetDate(), 6)");
            Sql("INSERT INTO  Salaries VALUES('02/02/2004', 30000, 'new salary', GetDate(), 7)");
            Sql("INSERT INTO  Salaries VALUES('02/02/2004', 200, 'new salary', GetDate(), 8)");
            Sql("INSERT INTO  Salaries VALUES('02/02/2004', 100, 'new salary', GetDate(), 9)");
            Sql("INSERT INTO  Salaries VALUES('02/02/2004', 440, 'new salary', GetDate(), 10)");*/


            CreateTable(
                "dbo.TerminationReasons",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        TerminationReason1 = c.String(),
                    })
                .PrimaryKey(t => t.id);

            /*Sql("INSERT INTO  TerminationReasons VALUES('Kariyer degisim')");
            Sql("INSERT INTO  TerminationReasons VALUES('Tatminsizliki')");
            Sql("INSERT INTO  TerminationReasons VALUES('Ise son verme')");
            Sql("INSERT INTO  TerminationReasons VALUES('Maas')");
            Sql("INSERT INTO  TerminationReasons VALUES('Calisma saatleri')");*/


            CreateTable(
                "dbo.Terminations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        TerminationDate = c.DateTime(),
                        LastDayOfWork = c.DateTime(),
                        BenefitsEndDate = c.DateTime(),
                        NewEmployer = c.String(),
                        ReceivedSeverance = c.String(),
                        SeveranceTotal = c.String(),
                        DateEnteredHRIS = c.DateTime(),
                        Comments = c.String(),
                        Employee_id = c.Int(),
                        TerminationReason_id = c.Int(),
                        TerminationType_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Employees", t => t.Employee_id)
                .ForeignKey("dbo.TerminationReasons", t => t.TerminationReason_id)
                .ForeignKey("dbo.TerminationTypes", t => t.TerminationType_id)
                .Index(t => t.Employee_id)
                .Index(t => t.TerminationReason_id)
                .Index(t => t.TerminationType_id);
            
            CreateTable(
                "dbo.TerminationTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        TerminationType1 = c.String(),
                    })
                .PrimaryKey(t => t.id);


            /*Sql("INSERT INTO  TerminationTypes VALUES('Isden atilma')");
            Sql("INSERT INTO  TerminationTypes VALUES('Isden cikarilma')");
            Sql("INSERT INTO  TerminationTypes VALUES('Istifa')");
            Sql("INSERT INTO  TerminationTypes VALUES('Gecici ayrilma')");*/

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Terminations", "TerminationType_id", "dbo.TerminationTypes");
            DropForeignKey("dbo.Terminations", "TerminationReason_id", "dbo.TerminationReasons");
            DropForeignKey("dbo.Terminations", "Employee_id", "dbo.Employees");
            DropForeignKey("dbo.Salaries", "Employee_id", "dbo.Employees");
            DropForeignKey("dbo.EmployeeTypes", "Employee_id1", "dbo.Employees");
            DropForeignKey("dbo.EmployeeTypes", "Supervisor_id", "dbo.Employees");
            DropForeignKey("dbo.EmployeeTypes", "Office_id", "dbo.Offices");
            DropForeignKey("dbo.EmployeeTypes", "Employee_id", "dbo.Employees");
            DropForeignKey("dbo.Bonus", "Employee_id", "dbo.Employees");
            DropForeignKey("dbo.AddressContacts", "Employee_id", "dbo.Employees");
            DropIndex("dbo.Terminations", new[] { "TerminationType_id" });
            DropIndex("dbo.Terminations", new[] { "TerminationReason_id" });
            DropIndex("dbo.Terminations", new[] { "Employee_id" });
            DropIndex("dbo.Salaries", new[] { "Employee_id" });
            DropIndex("dbo.EmployeeTypes", new[] { "Employee_id1" });
            DropIndex("dbo.EmployeeTypes", new[] { "Supervisor_id" });
            DropIndex("dbo.EmployeeTypes", new[] { "Office_id" });
            DropIndex("dbo.EmployeeTypes", new[] { "Employee_id" });
            DropIndex("dbo.Bonus", new[] { "Employee_id" });
            DropIndex("dbo.AddressContacts", new[] { "Employee_id" });
            DropTable("dbo.TerminationTypes");
            DropTable("dbo.Terminations");
            DropTable("dbo.TerminationReasons");
            DropTable("dbo.Salaries");
            DropTable("dbo.Offices");
            DropTable("dbo.EmployeeTypes");
            DropTable("dbo.Bonus");
            DropTable("dbo.Employees");
            DropTable("dbo.AddressContacts");
        }
    }
}

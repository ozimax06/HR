using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HR.Models;
using HRIS;
using HR;
using HRIS.Repositories;

namespace HRIS
{

        class Program
    {
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new HRContext()))
            {
                // Example1
                var emp = unitOfWork.employees.GetActiveEmployees();

                if (true)
                { }

            }
        }

        /*EmployeeRepository emp = new EmployeeRepository(HRContext);

            var x = emp.GetActiveEmployees();

            if (true)
            { }
            
        }*/
    }
}

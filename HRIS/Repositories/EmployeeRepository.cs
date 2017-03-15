using HR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR;

namespace HRIS.Repositories
{
    public class EmployeeRepository : Repository<Employee>
    {
        public EmployeeRepository(HRContext context) : base(context)
        {}

        public IEnumerable<Employee> GetActiveEmployees()
        {
            return HRContext.Employees
                    .Where(e => e.isActive == 1).OrderByDescending(x => x.StartDate).ToList();
        }
        public HRContext HRContext
        {
            get { return Context as HRContext; }
        }
    }
}

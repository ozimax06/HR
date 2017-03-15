using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR;
using HRIS.Repositories;

namespace HRIS
{
    public class UnitOfWork : IDisposable
    {
        private readonly HRContext _context;

        public EmployeeRepository employees;

        public UnitOfWork(HRContext context)
        {
            _context = context;
            employees = new EmployeeRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}

using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyWeb.Models;

namespace MyWeb.Data.Repositories.Employee
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _db;
        public EmployeeRepository(ApplicationDbContext db)
        {
            this._db = db;

        }

        public Task<IEnumerable<EmployeeModel>> GetAllEmployeeAsync(int Id, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public async Task<EmployeeModel> GetEmployeeAsync(int Id,CancellationToken cancellationToken)
        {
          return await _db.Employeies.FirstOrDefaultAsync(x=>x.Id==Id,cancellationToken);
        }
    }
}
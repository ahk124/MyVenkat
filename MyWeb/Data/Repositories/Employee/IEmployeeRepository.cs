using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MyWeb.Models;
namespace MyWeb.Data.Repositories.Employee
{
    public interface IEmployeeRepository
    {
        Task<EmployeeModel> GetEmployeeAsync(int Id,CancellationToken cancellationToken);
        Task<IEnumerable<EmployeeModel>> GetAllEmployeeAsync(int Id,CancellationToken cancellationToken);
    }
}
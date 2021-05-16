using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers
{
    public class EmployeeController:Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public async Task Create([FromBody] string value)
        {
            
        }
    }
}
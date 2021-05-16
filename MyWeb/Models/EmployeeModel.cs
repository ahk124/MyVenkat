using MyWeb.Enums;

namespace MyWeb.Models
{
    public class EmployeeModel:BaseModelDate<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public EmployeeDepEnum Department { get; set; }
    }
}
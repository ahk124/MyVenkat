using System.ComponentModel.DataAnnotations;
using MyWeb.Enums;

namespace MyWeb.ViewModels
{
    public class EmployeeCreateViewModel
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public EmployeeDepEnum Department { get; set; }
    }
}
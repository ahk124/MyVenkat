using System.ComponentModel.DataAnnotations;
using MyWeb.Enums;
using MyWeb.Models;

namespace MyWeb.ViewModels
{
    public class EmployeeEditViewModel : BaseModelDate<int>
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
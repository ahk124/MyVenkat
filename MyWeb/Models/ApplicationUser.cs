using Microsoft.AspNetCore.Identity;

namespace MyWeb.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string CodeMeli { get; set; }
        public int Age { get; set; }
        public SexEnum Sex { get; set; }
    }

    public enum SexEnum{
        male,
        Femal
    }
}
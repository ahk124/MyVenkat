using Microsoft.AspNetCore.Identity;

namespace MyWeb.Models
{
    public class ApplicationRole:IdentityRole
    {
        public System.DateTimeOffset DateCreated { get; set; }
    }
}
using Microsoft.AspNetCore.Identity;

namespace QLNS.Entities
{
    public class ApplicationUsers : IdentityUser
    {
        public string? FullName { get; set; }

    }
}

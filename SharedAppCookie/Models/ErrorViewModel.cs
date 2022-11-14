using Microsoft.AspNetCore.Identity;

namespace SharedAppCookie.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class ApplicationUser : IdentityUser
    {
 
    }
}
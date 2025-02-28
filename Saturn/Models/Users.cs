using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;

namespace Saturn.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; } //What i did 
    }
}

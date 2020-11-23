using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Passapi.Domain
{
    public class User: IdentityUser
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
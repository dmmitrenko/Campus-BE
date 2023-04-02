using Microsoft.AspNetCore.Identity;

namespace Campus.DataContext.Entities;
public class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

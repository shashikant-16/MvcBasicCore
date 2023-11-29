using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcBasicCore.Entity;

[Table("Users",Schema ="UserSecurity")]
public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Email { get; set; }

    public string Phone { get; set; } = null!;
}

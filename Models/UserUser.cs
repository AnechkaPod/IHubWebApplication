using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class UserUser
{
    public string UserName { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<UserProfile> Profiles { get; set; } = new List<UserProfile>();
}

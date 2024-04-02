using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VUsersWithProfile
{
    public string UserName { get; set; } = null!;

    public string? Email { get; set; }

    public int Id { get; set; }

    public string? ProfileName { get; set; }
}

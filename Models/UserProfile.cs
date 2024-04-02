using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class UserProfile
{
    public int Id { get; set; }

    public string? ProfileName { get; set; }

    public virtual ICollection<UserProfilesScreen> UserProfilesScreens { get; set; } = new List<UserProfilesScreen>();

    public virtual ICollection<UserUser> UserNames { get; set; } = new List<UserUser>();
}

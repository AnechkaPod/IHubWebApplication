using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class UserScreen
{
    public int ScreenId { get; set; }

    public string? ScreenName { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<UserProfilesScreen> UserProfilesScreens { get; set; } = new List<UserProfilesScreen>();
}

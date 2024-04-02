using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class UserProfilesScreen
{
    public int ProfileId { get; set; }

    public int ScreenId { get; set; }

    public bool IsReadOnly { get; set; }

    public virtual UserProfile Profile { get; set; } = null!;

    public virtual UserScreen Screen { get; set; } = null!;
}

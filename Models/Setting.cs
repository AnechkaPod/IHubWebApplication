using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class Setting
{
    public string? SettingName { get; set; }

    public string Value { get; set; } = null!;
}

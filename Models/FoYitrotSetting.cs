using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class FoYitrotSetting
{
    public string? QueryDescription { get; set; }

    public string SqlCommand { get; set; } = null!;

    public string SourceServer { get; set; } = null!;

    public string SourceDb { get; set; } = null!;
}

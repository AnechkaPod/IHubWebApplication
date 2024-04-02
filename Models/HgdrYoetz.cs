using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrYoetz
{
    public int KodYoetz { get; set; }

    public string TeurYoetz { get; set; } = null!;

    public string? TeurYoetzCrm { get; set; }

    public int? KodSnif { get; set; }
}

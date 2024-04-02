using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VFoBakaratManpik
{
    public int? KodMutzarCategory { get; set; }

    public string? TeurCategory { get; set; }

    public int? KodManpik { get; set; }

    public string? TeurManpik { get; set; }

    public string? Ticker { get; set; }

    public decimal? ChasifaAfterTnua { get; set; }
}

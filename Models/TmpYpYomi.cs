using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class TmpYpYomi
{
    public int? KodMutzar { get; set; }

    public string? Mutzar { get; set; }

    public int? KodChaverBursa { get; set; }

    public string? ChaverBursa { get; set; }

    public int? YezirotKamut { get; set; }

    public decimal? YezirotShovi { get; set; }

    public int? PidyonotKamut { get; set; }

    public decimal? PidyonotShovi { get; set; }

    public DateTime? Taarich { get; set; }

    public TimeSpan? Time { get; set; }
}

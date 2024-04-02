using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class YpYomi
{
    public int KodMutzar { get; set; }

    public string? Mutzar { get; set; }

    public int KodChaverBursa { get; set; }

    public string ChaverBursa { get; set; } = null!;

    public int? YezirotKamut { get; set; }

    public decimal YezirotShovi { get; set; }

    public int? PidyonotKamut { get; set; }

    public decimal PidyonotShovi { get; set; }

    public DateTime Taarich { get; set; }

    public TimeSpan? Time { get; set; }
}

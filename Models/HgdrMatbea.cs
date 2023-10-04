using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class HgdrMatbea
{
    public string KodNeches { get; set; } = null!;

    public string KodMatbea { get; set; } = null!;

    public string Matbea { get; set; } = null!;

    public byte Rank { get; set; }

    public string? Ric { get; set; }

    public string? UnderlyingRic { get; set; }

    public decimal? PriceMultiplier { get; set; }

    public int Id { get; set; }

    public string? Source { get; set; }
}

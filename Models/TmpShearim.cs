using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class TmpShearim
{
    public DateTime Date { get; set; }

    public string Source { get; set; } = null!;

    public string KodNeches { get; set; } = null!;

    public string? Neches { get; set; }

    public decimal? Price { get; set; }

    public string? Ticker { get; set; }

    public string? Isin { get; set; }
}

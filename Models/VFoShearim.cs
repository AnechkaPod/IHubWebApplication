using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VFoShearim
{
    public DateTime Date { get; set; }

    public int SourceKod { get; set; }

    public string Source { get; set; } = null!;

    public string KodNeches { get; set; } = null!;

    public string? Ticker { get; set; }

    public decimal? Shaar { get; set; }

    public int Sort { get; set; }
}

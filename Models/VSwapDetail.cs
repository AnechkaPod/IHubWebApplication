using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VSwapDetail
{
    public string KodNeches { get; set; } = null!;

    public string Neches { get; set; } = null!;

    public decimal? Interest { get; set; }

    public decimal? Spread { get; set; }

    public DateTime? InterestDate { get; set; }
}

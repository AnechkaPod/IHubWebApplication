using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VFoExportLeumi
{
    public short? Branch { get; set; }

    public string Acct { get; set; } = null!;

    public string? AcctFut { get; set; }

    public string? Symbol { get; set; }

    public string Ticker { get; set; } = null!;

    public bool? NechesRashi { get; set; }

    public decimal? ErechNakuv { get; set; }

    public int? Status { get; set; }
}

using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VFoExportGilgulLeumi
{
    public int KodMutzar { get; set; }

    public string? Mutzar { get; set; }

    public short? Branch { get; set; }

    public string? Acct { get; set; }

    public string? AcctFut { get; set; }

    public string? Ticker { get; set; }

    public string? TickerAfter { get; set; }

    public decimal? Kamut { get; set; }

    public decimal? QttyS { get; set; }

    public decimal? QttyB { get; set; }
}

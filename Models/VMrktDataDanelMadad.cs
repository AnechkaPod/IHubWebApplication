using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VMrktDataDanelMadad
{
    public string KodNeches { get; set; } = null!;

    public string Neches { get; set; } = null!;

    public string? Ric { get; set; }

    public decimal? Price { get; set; }

    public DateTime? TradeDate { get; set; }

    public decimal? OfficialClosePrice { get; set; }

    public DateTime? DanelDate { get; set; }
}

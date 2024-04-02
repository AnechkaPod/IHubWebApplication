using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VMrktDataDanelMatach
{
    public string KodNeches { get; set; } = null!;

    public string Matbea { get; set; } = null!;

    public string? Ric { get; set; }

    public decimal? Price { get; set; }

    public DateTime? TradeDate { get; set; }

    public string? UnderlyingRic { get; set; }

    public decimal? OfficialClosePrice { get; set; }

    public decimal? Undl { get; set; }

    public DateTime? DanelDate { get; set; }
}

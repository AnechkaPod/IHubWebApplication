using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class MrktDatum
{
    public DateTime Taarich { get; set; }

    public string? KodNeches { get; set; }

    public string? SecurityId { get; set; }

    public string? Ric { get; set; }

    public string? Isin { get; set; }

    public string? Ticker { get; set; }

    public decimal? OfficialClosePrice { get; set; }

    public DateTime? TradeDate { get; set; }

    public decimal? Bid { get; set; }

    public decimal? Ask { get; set; }

    public string? UrrencyCode { get; set; }
}

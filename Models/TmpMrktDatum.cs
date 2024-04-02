using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class TmpMrktDatum
{
    public string Taarich { get; set; } = null!;

    public string? Security { get; set; }

    public string? Ric { get; set; }

    public string? Isin { get; set; }

    public string? Ticker { get; set; }

    public string? OfficialClosePrice { get; set; }

    public DateTime? TradeDate { get; set; }

    public string? Bid { get; set; }

    public string? Ask { get; set; }

    public string? CurrencyCode { get; set; }
}

using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VFoExportGoldman
{
    public string TransactionType { get; set; } = null!;

    public string? ProductCode { get; set; }

    public int? Strike { get; set; }

    public string BuySell { get; set; } = null!;

    public string AccountNumber { get; set; } = null!;

    public int? Price { get; set; }

    public string ExecutionBroker { get; set; } = null!;

    public string ClearingBroker { get; set; } = null!;

    public string SymbologyType { get; set; } = null!;

    public int? GroupId { get; set; }

    public string? ClearingDate { get; set; }

    public string? UniqueTradeId { get; set; }

    public string CommissionFlag { get; set; } = null!;

    public decimal? Quantity { get; set; }

    public int? Status { get; set; }

    public string Ticker { get; set; } = null!;
}

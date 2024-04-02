using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class TmpBtzTnout
{
    public int Id { get; set; }

    public string SecurityId { get; set; } = null!;

    public int AccountId { get; set; }

    public string? KodNeches { get; set; }

    public string? KodMutzar { get; set; }

    public DateTime TaarichPeula { get; set; }

    public int Kamut { get; set; }

    public decimal? Shaar { get; set; }

    public string? SibatRechisha { get; set; }

    public string? InsUser { get; set; }

    public bool? IsGilgul { get; set; }

    public string? Remarks { get; set; }

    public string? Counterparty { get; set; }

    public string? BuyCurrency { get; set; }

    public string? SellCurrency { get; set; }

    public string? TaarichPkia { get; set; }

    public string? Strike { get; set; }
}

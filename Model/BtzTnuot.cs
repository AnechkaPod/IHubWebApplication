using System;
using System.Collections.Generic;

namespace IHubWebApplication.Model;

public partial class BtzTnuot
{
    public int Id { get; set; }

    public string SecurityId { get; set; } = null!;

    public int? AcountId { get; set; }

    public string? KodNeches { get; set; }

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

    public DateTime? TaarichPika { get; set; }

    public decimal? Strike { get; set; }

    public virtual HgdrNech? KodNechesNavigation { get; set; }
}

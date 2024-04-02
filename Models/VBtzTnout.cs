using System;
using System.Collections.Generic;

namespace IHubWebApplication.Models;

public partial class VBtzTnout
{
    public string SecurityId { get; set; } = null!;

    public int AccountId { get; set; }

    public string? KodNeches { get; set; }

    public int? KodMutzar { get; set; }

    public string? Mutzar { get; set; }

    public DateTime TaarichPeula { get; set; }

    public int Kamut { get; set; }

    public decimal? Shaar { get; set; }

    public string? SibatRechisha { get; set; }

    public string? InsUser { get; set; }

    public bool? IsGilgul { get; set; }

    public string? Remarks { get; set; }
}
